Imports System.Data.Linq

Public Class PacienteDebitoManager


    Public Enum TipoDocumento
        Cita = 1
        Factura = 2
        Recibo = 3
        N_Tickets = 4
        N_Facturas = 5
        PagoCuenta = 6
    End Enum

    Public Paciente As PACIENTE
    Public Context As New CMLinqDataContext
    'Esta clase es para PacienteDebito

    Public Filtro As FiltroGenericoDocumentos

  

    Public Sub New(paciente As PACIENTE, context As CMLinqDataContext, filter As FiltroGenericoDocumentos)
        Me.Paciente = paciente
        Me.Filtro = filter
        Me.Context = context

    End Sub


    Public ReadOnly Property CITAs As EntitySet(Of CITA)
        Get
            Dim dt As New EntitySet(Of CITA)
            If Not Paciente Is Nothing Then
                dt.AddRange(CitasManager.ListadoCitasDebitoPaciente(Context, Filtro))
            End If
            Return dt
        End Get
    End Property

    Public ReadOnly Property FACTURAs As EntitySet(Of FACTURA)
        Get
            Dim dt As New EntitySet(Of FACTURA)
            If Not Paciente Is Nothing Then
                dt.AddRange(FacturasManager.ListadoFACTURAsDebitoPaciente(Context, Filtro))
            End If
            Return dt
        End Get
    End Property

    'ESTO de aqui hay que cambiarlo por la referencia a la lista de RecibosManager, N_Tickets 

    Public ReadOnly Property RECIBOs As EntitySet(Of RECIBO)
        Get
            Dim dt As New System.Data.Linq.EntitySet(Of RECIBO)
            If Not Paciente Is Nothing Then
                dt.AddRange(Paciente.RECIBOs.Where(Function(o) o.COBRADO = "N" And (Not o.REFFACTURA.HasValue Or o.REFFACTURA = 0) And o.IMPORTE > 0))
            End If
            Return dt
        End Get
    End Property

    Public ReadOnly Property N_Tickets As EntitySet(Of N_Ticket)
        Get
            Dim dt As New System.Data.Linq.EntitySet(Of N_Ticket)
            If Not Paciente Is Nothing Then
                dt.AddRange(Paciente.N_Tickets.Where(Function(o) (o.Eliminado = False Or Not o.Eliminado.HasValue) And (o.Pagado = False) And o.Total > 0))
            End If
            Return dt
        End Get
    End Property


    Public ReadOnly Property N_Facturas As EntitySet(Of N_Factura)
        Get
            Dim dt As New System.Data.Linq.EntitySet(Of N_Factura)
            If Not Paciente Is Nothing Then
                dt.AddRange(Paciente.N_Facturas.Where(Function(o) o.Pagado = False And o.Total > 0))
            End If
            Return dt
        End Get
    End Property

    Public ReadOnly Property PagosPacientes As EntitySet(Of PagosPaciente)
        Get
            Dim dt As New System.Data.Linq.EntitySet(Of PagosPaciente)
            If Not Paciente Is Nothing Then
                'Return FacturasManager.ListadoFACTURAsDebitoPaciente(Context, Filtro)
                dt.AddRange(Paciente.PagosPacientes.AsQueryable())
            End If
            Return dt
           End Get
    End Property

    Public ReadOnly Property EntregasCuentas As EntitySet(Of EntregasCuenta)
        Get
            Dim dt As New System.Data.Linq.EntitySet(Of EntregasCuenta)
            If Not Paciente Is Nothing Then
                dt.AddRange(Paciente.EntregasCuentas.Where(Function(o) o.Eliminado = False))
            End If
            Return dt
        End Get
    End Property


    Public ReadOnly Property Debe As Double
        Get
            'La suma de todos los documentos
            Dim _debe As Double = 0
            _debe += CITAs.Sum(Function(o) o.TOTAL)
            _debe += FACTURAs.Sum(Function(o) o.TOTAL)
            _debe += RECIBOs.Sum(Function(o) o.IMPORTE)
            _debe += N_Tickets.Sum(Function(o) o.Total)
            _debe += N_Facturas.Sum(Function(o) o.Total)
            Return _debe
        End Get
    End Property

    Public ReadOnly Property Credito As Double
        Get
            'La suma de todos los documentos
            Dim _credito As Double = 0
            _credito = PagosPacientes.Sum(Function(o) o.Importe) - EntregasCuentas.Sum(Function(o) o.Importe And o.Eliminado = False)

            Return _credito
        End Get
    End Property



    Public Function PagarDocumentos(documentos As ICollection(Of IDocumentoPagable),
                                    formDocumentos As IFormDocumentosPendientes,
                                    idFormaPagoPreseleccionada As String,
                                    idUsuarioEfectua As Integer,
                                    context As CMLinqDataContext) As DialogResult

        'Se muestran los documentos a pagar al usuario, y se obtiene su respuesta, la cual incluye la forma de pago,

        formDocumentos.DocumentosPendientes = documentos

        If Not String.IsNullOrEmpty(idFormaPagoPreseleccionada) Then
            formDocumentos.IdFormaPagoPreseleccionada = idFormaPagoPreseleccionada
        End If

        Dim res As DialogResult '= DialogResult.OK
        'formDocumentos.Importe = documentos.Sum(Function(o) o.Importe)
        If formDocumentos.Muestra(Me.Credito) = DialogResult.OK Then
            For Each doc As IDocumentoPagable In documentos
                res = PagarDocumento(doc,
                               formDocumentos.IdFormaPagoSeleccionada,
                               New Date(formDocumentos.FechaPago.Year, formDocumentos.FechaPago.Month, formDocumentos.FechaPago.Day, Now.Hour, Now.Minute, Now.Second),
                               idUsuarioEfectua,
                               formDocumentos.UsarCredito,
                               context)
                If res = DialogResult.Cancel Then
                    Return res
                End If

            Next
        Else
            res = DialogResult.Cancel
        End If
        Return res
    End Function

    Public Function PagarDocumento(doc As IDocumentoPagable,
                                   idFormaPago As String,
                                   fechacobro As Date,
                                   idUsuarioEfectua As Integer,
                                   pagarConCredito As Boolean,
                                   context As CMLinqDataContext) As DialogResult

        ''Es necesario hacer una salvedad con las facturas
        ''ya que pueden proceder de citas pagadas. Lo correcto
        ''es que si pagamos una factura con citas ya pagadas solo 
        ''se inserte la diferencia entre lo ya pagado y lo no pagado.
        'Dim importe As Double = 0
        'If doc.TipoDocumento = TipoDocumento.Factura Then
        '    Dim a = context.LINEASFACTURAs.Where(Function(o) o.REFFACTURA = doc.IDDocumento).ToList

        'End If
        'Validaciones

        If doc.Pagado Then
            MessageBox.Show("Error: El documento ya está marcado como pagado")
            Return DialogResult.Cancel
        End If

        If pagarConCredito And Globales.Configuracion.UsarPacienteDebitoAlPagar Then
            Dim credito As Double = DameCreditoPaciente(doc.IDPaciente, context)
            If credito < doc.Importe Then
                MessageBox.Show(String.Format("Error: Crédito {0} insuficiente para cubrir el importe {1}", credito, doc.Importe))
                Return DialogResult.Cancel
            End If
        End If


        Dim res As DialogResult = DialogResult.OK

        doc.PagadoConCredito = pagarConCredito
        If Globales.Configuracion.UsarPacienteDebitoAlPagar Then

            If Not pagarConCredito Then
                Dim pago As New PagosPaciente With
                   {
                       .Fecha = fechacobro,
                       .IDFormaPago = idFormaPago,
                       .IDPaciente = doc.IDPaciente,
                       .IDUsuario = idUsuarioEfectua,
                       .Importe = doc.Importe,
                       .Automatico = True,
                .Notas = "Pago para cubrir  " & doc.DescripcionDocumento
                   }
                context.PagosPacientes.InsertOnSubmit(pago)
                context.SubmitChanges()


                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.PagosPaciente, "Pago paciente", pago.IDEntrega, "Pago paciente para cubrir " & doc.DescripcionDocumento)

            End If
        Else
            'Si el usuario no usa el PacienteDebito, entonces crear un pago ficticio

            Dim pago As New PagosPaciente With
                    {
                        .Fecha = fechacobro,
                        .IDFormaPago = idFormaPago,
                        .IDPaciente = doc.IDPaciente,
                        .IDUsuario = idUsuarioEfectua,
                        .Importe = doc.Importe,
                        .Automatico = True,
                        .Notas = "Pago de sistema para -> " & doc.DescripcionDocumento
                    }
            context.PagosPacientes.InsertOnSubmit(pago)
            context.SubmitChanges()

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.PagosPaciente, "Sistema, Pago paciente", pago.IDEntrega, "Pago para compensar entrega pq no se usa el Paciente Debito")
        End If


        Dim entrega As New EntregasCuenta With
            {
                .CodDocumento = doc.IDDocumento,
                .Descripcion = "Pago de " & doc.DescripcionDocumento,
                .Eliminado = False,
                .Fecha = fechacobro,
                .IDFormaPago = idFormaPago,
                .IDPaciente = doc.IDPaciente,
                .IDUsuarioEfectua = idUsuarioEfectua,
                .Importe = doc.Importe,
                .PagadoConCredito = pagarConCredito,
                .TipoDocumento = doc.TipoDocumento
            }

        context.EntregasCuentas.InsertOnSubmit(entrega)
        context.SubmitChanges()

        If res = DialogResult.OK Then
            doc.MarcarPagado(fechacobro, idFormaPago)

            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Pagar,
                                            doc.TipoDocumento,
                                            doc.TipoDocumento.ToString(),
                                            doc.IDDocumento,
                                            doc.DescripcionDocumento)
        End If


        Return res
    End Function

    Public Shared Function DameImporteEntregasPaciente(ByVal idPaciente As Integer, context As CMLinqDataContext) As Double

        Dim importe As Double = 0

        Dim entregas As List(Of EntregasCuenta) = (From e In context.EntregasCuentas Where e.IDPaciente = idPaciente And e.Eliminado = False Select e).ToList()

        If entregas.Count > 0 Then
            importe = entregas.Sum(Function(ob) ob.Importe).Value
        End If
        Return importe
    End Function

    Public Shared Function DamePagosPaciente(ByVal idPaciente As Integer, context As CMLinqDataContext) As Double
        Dim importe As Double = 0
        Dim pagos As List(Of PagosPaciente) = (From p In context.PagosPacientes Where p.IDPaciente = idPaciente Select p).ToList()

        If pagos.Count > 0 Then
            importe = pagos.Sum(Function(ob) ob.Importe).Value
        End If
        Return importe
    End Function

    Public Shared Function DameCreditoPaciente(ByVal idPaciente As Integer, context As CMLinqDataContext) As Double
        Return DamePagosPaciente(idPaciente, context) - DameImporteEntregasPaciente(idPaciente, context)
    End Function

    Public Shared Sub Despagar(ByVal doc As IDocumentoPagable)
        Dim context As New CMLinqDataContext

        If (Not doc.PagadoConCredito) Then
            Dim pago As New PagosPaciente With {
                        .Fecha = Now,
                        .IDPaciente = doc.IDPaciente,
                        .IDUsuario = Globales.Usuario.CODIGO,
                        .Importe = doc.Importe * -1,
                        .IDFormaPago = doc.IDFormaPago,
                        .Automatico = True,
                        .Notas = "Abono de sistema al cancelar pago de documento -> " & doc.DescripcionDocumento
                         }
            context.PagosPacientes.InsertOnSubmit(pago)

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Despagar,
                                           doc.TipoDocumento,
                                           doc.TipoDocumento.ToString(),
                                           doc.IDDocumento,
                                           "Abono de crédito por cambiar estado de pago -> " & doc.DescripcionDocumento)




        End If

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Despagar,
                                          doc.TipoDocumento,
                                          doc.TipoDocumento.ToString(),
                                          doc.IDDocumento,
                                          "Eliminado pago -> " & doc.DescripcionDocumento)
        Dim entregas As List(Of EntregasCuenta)
        entregas = context.EntregasCuentas.Where(Function(o) o.TipoDocumento = doc.TipoDocumento And o.CodDocumento = doc.IDDocumento And o.Eliminado = False And o.Importe = doc.Importe).ToList
        For Each i As EntregasCuenta In entregas
            i.Eliminado = True
        Next
        context.SubmitChanges()
    End Sub
End Class




Partial Public Class CITA
    Implements IDocumentoPagable


    Public ReadOnly Property IDDocumento As String Implements IDocumentoPagable.IDDocumento
        Get
            Return Me.IDCITA.ToString
        End Get
    End Property

    Public ReadOnly Property DescripcionDocumento As String Implements IDocumentoPagable.DescripcionDocumento
        Get
            Return String.Format("Cita {0}-{1} Paciente: {2} Doctor: {3}",
                                 Me.FECHA.Value.ToShortDateString(),
                                 Me.HORA.Value.ToShortTimeString(),
                                 Me.PACIENTE,
                                 Me.MEDICO.NOMBRECOMPLETO)
        End Get
    End Property

    Public ReadOnly Property Importe As Double Implements IDocumentoPagable.Importe
        Get
            If Me.TOTAL Is Nothing Then
                Return 0
            Else
                Return Me.TOTAL
            End If

        End Get
    End Property

    Public Sub MarcarDespagado() Implements IDocumentoPagable.MarcarDespagado
        Me.PAGADA = "N"
        PacienteDebitoManager.Despagar(Me)
    End Sub

    Public Sub MarcarPagado(fecha As Date, Optional idFormaPago As String = "") Implements IDocumentoPagable.MarcarPagado
        Me.PAGADA = "S"
        Me.FECHACOBRO = fecha
        If (Not idFormaPago Is Nothing) AndAlso idFormaPago.Trim.Length > 0 Then
            ' Se adopta esta formula deacuerdo con lo leido en 
            'http://dotnetslackers.com/Community/blogs/bmains/archive/2009/05/21/linq-to-sql-error-foreignkeyreferencealreadyhasvalueexception.aspx
            Me._FORMASPAGO = CType(Nothing, EntityRef(Of FORMASPAGO))
            Me.REFFORMAPAGO = idFormaPago
        End If

    End Sub



    Function PagadoDoc() As Boolean Implements IDocumentoPagable.Pagado
        Return (Me.PAGADA = "S")
    End Function

    Public ReadOnly Property IDPaciente As Integer Implements IDocumentoPagable.IDPaciente
        Get
            Return Me.REFPACIENTE
        End Get
    End Property

    Public ReadOnly Property IDFormaPago As String Implements IDocumentoPagable.IDFormaPago
        Get
            Return Me.REFFORMAPAGO
        End Get
    End Property

    Public ReadOnly Property TipoDocumento As PacienteDebitoManager.TipoDocumento Implements IDocumentoPagable.TipoDocumento
        Get
            Return PacienteDebitoManager.TipoDocumento.Cita
        End Get
    End Property


    Public Property PagadoCredito() As Boolean Implements IDocumentoPagable.PagadoConCredito
        Get
            Return Me.PagadoConCredito
        End Get
        Set(ByVal value As Boolean)
            Me.PagadoConCredito = value
        End Set
    End Property



End Class

Partial Public Class FACTURA
    Implements IDocumentoPagable

    Private Function importeCitasPagadas() As Double
        Dim importeCitas As Double = 0
        importeCitas = Me.LINEASFACTURAs.Where(Function(o) Not o.CITA Is Nothing AndAlso o.CITA.PAGADA = "S").Sum(Function(e) e.IMPORTE)
        Return importeCitas
    End Function
    Public ReadOnly Property IDDocumento As String Implements IDocumentoPagable.IDDocumento
        Get
            Return Me.IDFACTURA.ToString
        End Get
    End Property

    Public ReadOnly Property DescripcionDocumento As String Implements IDocumentoPagable.DescripcionDocumento
        Get
            Dim txt As String = ""
            If importeCitasPagadas() > 0 Then
                txt = "Resto "
            End If
            Return String.Format(txt & "Factura {0}-{1} Paciente: {2} ",
                                 Me.FEMISION.Value.ToShortDateString(),
                                 Me.NUMERO,
                                 Me.PACIENTE
                                 )
        End Get
    End Property

    Public ReadOnly Property Importe As Double Implements IDocumentoPagable.Importe
        Get
            Return Me.TOTAL - importeCitasPagadas()
        End Get
    End Property

    Public Sub MarcarDespagado() Implements IDocumentoPagable.MarcarDespagado
        Me.PAGADA = "N"
        PacienteDebitoManager.Despagar(Me)
    End Sub

    Public Sub MarcarPagado(fecha As Date, Optional idFormaPago As String = "") Implements IDocumentoPagable.MarcarPagado
        Me.PAGADA = "S"
        Me.FECHACOBRO = fecha
        If (Not idFormaPago Is Nothing) AndAlso idFormaPago.Trim.Length > 0 Then
            'Se opta por esta solución tal y como se explica en esta url
            'http://dotnetslackers.com/Community/blogs/bmains/archive/2009/05/21/linq-to-sql-error-foreignkeyreferencealreadyhasvalueexception.aspx
            Me._FORMASPAGO = CType(Nothing, EntityRef(Of FORMASPAGO))
            Me.REFFORMAPAGO = idFormaPago
        End If

    End Sub

    Function PagadoDoc() As Boolean Implements IDocumentoPagable.Pagado
        Return (Me.PAGADA = "S")
    End Function

    Public ReadOnly Property IDPaciente As Integer Implements IDocumentoPagable.IDPaciente
        Get
            Return Me.REFPACIENTE
        End Get
    End Property

    Public ReadOnly Property IDFormaPago As String Implements IDocumentoPagable.IDFormaPago
        Get
            Return Me.REFFORMAPAGO
        End Get
    End Property

    Public ReadOnly Property TipoDocumento As PacienteDebitoManager.TipoDocumento Implements IDocumentoPagable.TipoDocumento
        Get
            Return PacienteDebitoManager.TipoDocumento.Factura
        End Get
    End Property

    Public Property PagadoCredito() As Boolean Implements IDocumentoPagable.PagadoConCredito
        Get
            Return Me.PagadoConCredito
        End Get
        Set(ByVal value As Boolean)
            Me.PagadoConCredito = value
        End Set
    End Property

End Class

Partial Public Class N_TICKET
    Implements IDocumentoPagable


    Public ReadOnly Property IDDocumento As String Implements IDocumentoPagable.IDDocumento
        Get
            Return Me.ID_Ticket.ToString
        End Get
    End Property

    Public ReadOnly Property DescripcionDocumento As String Implements IDocumentoPagable.DescripcionDocumento
        Get
            Return String.Format("Ticket {0}-{1} Paciente: {2} ",
                                 Me.Fecha.ToShortDateString(),
                                 Me.ID_Ticket,
                                 Me.PACIENTE
                                 )
        End Get
    End Property

    Public ReadOnly Property Importe As Double Implements IDocumentoPagable.Importe
        Get
            Return Me.TOTAL
        End Get
    End Property

    Public Sub MarcarDespagado() Implements IDocumentoPagable.MarcarDespagado
        Me.Pagado = False
        PacienteDebitoManager.Despagar(Me)
    End Sub

    Public Sub MarcarPagado(fecha As Date, Optional idFormaPago As String = "") Implements IDocumentoPagable.MarcarPagado
        Me.Pagado = True
        Me.FechaPagado = fecha
        If idFormaPago.Trim.Length > 0 Then
            'Se opta por esta solución tal y como se explica en esta url
            'http://dotnetslackers.com/Community/blogs/bmains/archive/2009/05/21/linq-to-sql-error-foreignkeyreferencealreadyhasvalueexception.aspx
            Me._FORMASPAGO = CType(Nothing, EntityRef(Of FORMASPAGO))
            Me.ID_FormaPago = idFormaPago
        End If

    End Sub

    Function PagadoDoc() As Boolean Implements IDocumentoPagable.Pagado
        Return Me.Pagado = True
    End Function

    Public ReadOnly Property IDPaciente As Integer Implements IDocumentoPagable.IDPaciente
        Get
            Return Me.ID_Cliente
        End Get
    End Property

    Public ReadOnly Property IDFormaPago As String Implements IDocumentoPagable.IDFormaPago
        Get
            Return Me.ID_FormaPago
        End Get
    End Property

    Public ReadOnly Property TipoDocumento As PacienteDebitoManager.TipoDocumento Implements IDocumentoPagable.TipoDocumento
        Get
            Return PacienteDebitoManager.TipoDocumento.N_Tickets
        End Get
    End Property

    Public Property PagadoCredito() As Boolean Implements IDocumentoPagable.PagadoConCredito
        Get
            Return Me.PagadoConCredito
        End Get
        Set(ByVal value As Boolean)
            Me.PagadoConCredito = value
        End Set
    End Property

End Class

Partial Public Class N_Factura
    Implements IDocumentoPagable


    Public ReadOnly Property IDDocumento As String Implements IDocumentoPagable.IDDocumento
        Get
            Return Me.ID_Factura.ToString
        End Get
    End Property

    Public ReadOnly Property DescripcionDocumento As String Implements IDocumentoPagable.DescripcionDocumento
        Get
            Return String.Format("Factura TPV {0}-{1} Paciente: {2} ",
                                 Me.Fecha.Value.ToShortDateString(),
                                Me.ID_TipoFactura & "-" & Me.Codigo,
                                 Me.PACIENTE.APELLIDO1 & " " & Me.PACIENTE.APELLIDO2 & " " & Me.PACIENTE.NOMBRE
                                 )
        End Get
    End Property

    Public ReadOnly Property Importe As Double Implements IDocumentoPagable.Importe
        Get
            Return Me.Total
        End Get
    End Property

    Public Sub MarcarDespagado() Implements IDocumentoPagable.MarcarDespagado
        Me.Pagado = False
        PacienteDebitoManager.Despagar(Me)
    End Sub

    Public Sub MarcarPagado(fecha As Date, Optional idFormaPago As String = "") Implements IDocumentoPagable.MarcarPagado
        Me.Pagado = True
        Me.FechaPagado = fecha
        If idFormaPago.Trim.Length > 0 Then
            'Se opta por esta solución tal y como se explica en esta url
            'http://dotnetslackers.com/Community/blogs/bmains/archive/2009/05/21/linq-to-sql-error-foreignkeyreferencealreadyhasvalueexception.aspx
            Me._FORMASPAGO = CType(Nothing, EntityRef(Of FORMASPAGO))
            Me.ID_FormaPago = idFormaPago
        End If

    End Sub

    Function PagadoDoc() As Boolean Implements IDocumentoPagable.Pagado
        Return (Me.Pagado = True)
    End Function

    Public ReadOnly Property IDPaciente As Integer Implements IDocumentoPagable.IDPaciente
        Get
            Return Me.ID_Cliente
        End Get
    End Property

    Public ReadOnly Property IDFormaPago As String Implements IDocumentoPagable.IDFormaPago
        Get
            Return Me.ID_FormaPago
        End Get
    End Property

    Public ReadOnly Property TipoDocumento As PacienteDebitoManager.TipoDocumento Implements IDocumentoPagable.TipoDocumento
        Get
            Return PacienteDebitoManager.TipoDocumento.N_Facturas
        End Get
    End Property

    Public Property PagadoCredito() As Boolean Implements IDocumentoPagable.PagadoConCredito
        Get
            Return Me.PagadoConCredito
        End Get
        Set(ByVal value As Boolean)
            Me.PagadoConCredito = value
        End Set
    End Property

End Class

Partial Class Liquidacion_Medico
    Public ReadOnly Property DescripcionText() As String
        Get
            Return "Liquidacion médico nº " & Me.ID_Liquidacion & " a " & Me.MEDICO.NOMBRECOMPLETO
        End Get
    End Property
End Class

Partial Class PagosPaciente


    Public ReadOnly Property NotasCompletas() As String
        Get
            Dim cadenas As String
            'obtenemos solo los 15 primeros caracteres de notas en caso de ser mayor de 15
            If Not Me.Notas Is Nothing AndAlso Me.Notas.Length >= 15 Then
                cadenas = Mid(Me.Notas, 1, 15)
            Else
                cadenas = Me.Notas
            End If
            Return "Entrega de " & Me.PACIENTE.NombreCompleto & " - Nota: " & cadenas
        End Get

    End Property

End Class


