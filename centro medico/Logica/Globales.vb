Imports Microsoft.ApplicationBlocks.Data
Imports System.Net
Imports System.IO
Imports System.ComponentModel
Imports Ciloci.Flee
Imports System.Xml.Linq
Imports centro_medico.UI.Reportes

Public Class Globales

    Public Shared Configuracion As centro_medico.Configuracion = New centro_medico.Configuracion()
    Public Shared Context As New CMLinqDataContext()
    Public Shared Usuario As USUARIO
    Public Shared Reportes As New ReportesManager

    Private Shared richT As New RichTextBox


    Public Class RecetaImagenes

        Public Shared RecetaGeneralFondo As String = Application.StartupPath & "\RDLC\img\recetaimpresageneral.jpg"
        Public Shared RecetaValencianoFondo As String = Application.StartupPath & "\RDLC\img\recetaimpresavalenciano.jpg"
        Public Shared ConsejoMedicos As String = Application.StartupPath & "\RDLC\img\consejo-medicos.jpg"
        Public Shared ColegioMedicoAlicante As String = Application.StartupPath & "\RDLC\img\colegio-medico-alicante.jpg"
        Public Shared pathImagenesRecetasXml As String = Globales.Configuracion.imagedirectory & "\imgRecetasxml"

        Public Shared ReadOnly Property LogoClinica As String
            Get
                If Globales.Configuracion.logotipo <> String.Empty Then
                    If System.IO.File.Exists(Globales.Configuracion.logotipo) Then
                        Return "file:///" & Globales.Configuracion.logotipo
                    Else
                        Return Application.StartupPath & "\RDLC\img\logo3.jpg"
                    End If

                Else
                    Return Application.StartupPath & "\RDLC\img\logo3.jpg"
                End If
            End Get
        End Property



    End Class
    Public Shared Sub ImprimeJustificante(ByRef cita As CITA)

        'Datasources
        Dim dsCitaDatos As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsCitaLineas As New Microsoft.Reporting.WinForms.ReportDataSource
        dsCitaDatos.Name = "dsCitaDatos"
        dsCitaLineas.Name = "dsCitaLineas"
        'dsClinica.Name = "dsClinica"

        Dim listCitaDatos As New List(Of WRAPPER_CITA)
        listCitaDatos.Add(New WRAPPER_CITA(cita))
        dsCitaDatos.Value = listCitaDatos

        dsCitaLineas.Value = cita.LineasCitas

        UI.Reportes.ReportesManager.Imprime("CitaJustificantePago.rdlc", {dsCitaDatos, dsCitaLineas})

    End Sub

    Public Shared Function ValorModelo(ByRef dato As DATOSCOMPARATIVA) As Object
        Try
            Select Case dato.MODELOSDATO.TIPODATO
                Case "T"
                    Return dato.DVARCHAR
                Case "N"
                    Return dato.DFLOAT
                Case "B"
                    Return dato.DBOOLEAN
                Case "E"
                    Return GetCheckedValues(dato.DXML)
                Case "M"
                    Return GetCheckedValues(dato.DXML)
                Case "X"
                    Return Globales.EvaluaExpresion(dato.DXML.Value, dato)
            End Select
        Catch ex As Exception

        End Try
        Return String.Empty
    End Function


    Public Shared Function DiffValores(ByVal dato1 As DATOSCOMPARATIVA, ByVal revAnterior As LCOMPARATIVA)

        'buscar el mismo dato en la revision anterior

        Dim dato2 As DATOSCOMPARATIVA = revAnterior.DATOSCOMPARATIVAs.Where(Function(o) o.REFMODELODATO = dato1.REFMODELODATO).SingleOrDefault()

        If dato2 Is Nothing Then
            Return String.Empty
        End If

        If dato1.MODELOSDATO.TIPODATO = "N" Then
            Dim val1 As Double = dato1.DFLOAT.Value
            Dim val2 As Double = dato2.DFLOAT.Value
            'Return "Diferencia con el anterior " & (val1 - val2).ToString("N3")
            Return (val1 - val2).ToString("N3")
        End If

        If dato1.MODELOSDATO.TIPODATO = "X" Then
            Dim val1 As Double = Globales.EvaluaExpresion(dato1.DXML.Value, dato1)
            Dim val2 As Double = Globales.EvaluaExpresion(dato2.DXML.Value, dato2)
            Return (val1 - val2).ToString("N3")
        End If

        Return String.Empty
    End Function



#Region "Public Shared Function GetCheckedValues(xml As Xml.Linq.XElement) As String"
    Public Shared Function GetCheckedValues(xml As Xml.Linq.XElement) As String
        Dim s As New List(Of String)
        For Each el As XElement In xml.<item>
            Dim ischecked As Boolean = Boolean.Parse(el.Attribute("ischecked").Value)
            If ischecked Then
                s.Add(el.Value)
            End If
        Next
        Return String.Join("; ", s.ToArray())
    End Function
#End Region


    Public Shared Function DameCampos(ByRef dato As DATOSCOMPARATIVA) As List(Of Campo)
        Dim campos As New List(Of Campo)
        Dim datos As List(Of DATOSCOMPARATIVA) = dato.LCOMPARATIVA.DATOSCOMPARATIVAs.ToList
        For Each d As DATOSCOMPARATIVA In datos
            If d.MODELOSDATO.TIPODATO = "N" Then
                Dim campo As New Campo With {
                       .Nombre = d.MODELOSDATO.NOMBREDATO,
                       .Tipo = "N",
                       .Valor = d.DFLOAT
                      }
                campos.Add(campo)

            End If
        Next
        Return campos
    End Function

    Public Shared Function EvaluaExpresion(ByVal expresion As String, ByRef dato As DATOSCOMPARATIVA) As Double

        Dim result As Double = 0

        Dim expressionContext As New ExpressionContext
        expressionContext.[Imports].AddType(GetType(Math))
        expressionContext.[Imports].AddType(GetType(Date))
        expressionContext.Options.ParseCulture = New Globalization.CultureInfo("es-ES")

        Dim campos As List(Of Campo) = DameCampos(dato)
        For Each Campo As Campo In campos
            expressionContext.Variables.Add(Campo.FormattedName, Campo.Valor)
        Next

        Try
            Dim eDynamic As IDynamicExpression = expressionContext.CompileDynamic(Parsea(campos, expresion))
            result = CDbl(eDynamic.Evaluate())

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return result
    End Function

    Public Shared Function Parsea(ByRef Campos As List(Of Campo), ByVal texto As String) As String
        Dim str As String = texto
        For Each campo As Campo In Campos
            str = str.Replace(campo.Nombre, campo.FormattedName)
        Next
        'str = str.Replace(".", ",")
        Return str
    End Function




#Region "Public Shared Function ObtenImporteConceptoSegunTarifa(ByVal idConcepto As String,Byval descripcion as String, ByVal importeDefecto As Double) As Double"
    Public Shared Function ObtenImporteConceptoSegunTarifaMutua(ByVal idConcepto As String, ByVal idMutua As Integer?, ByVal importeDefecto As Double) As Double

        'Pasos
        'Obtener la tarifa de la mutua seleccionada si hay una seleccionada
        If Not idMutua.HasValue Then
            Return importeDefecto
        End If

        Dim importe As Double = importeDefecto

        'Verificar si hay una mutua seleccionada

        Dim context As New CMLinqDataContext

        Dim mutua As MUTUA = (From m In context.MUTUAs Where m.CMUTUA = idMutua Select m).SingleOrDefault()
        If mutua Is Nothing Then
            Return importeDefecto
        End If

        'Si tiene tarifa
        If mutua.IdTarifa.HasValue Then

            'Cargarla
            Dim tarifa As Tarifa = (From t In context.Tarifas
                                    Where t.IdTarifa = mutua.IdTarifa And t.IdConceptoFra = idConcepto Select t).SingleOrDefault()
            If tarifa Is Nothing Then
                Return importe
            Else
                Return tarifa.Importe
            End If
        End If

        Return importe
    End Function
#End Region


    Public Shared Function TextFromRtf(p1 As String) As String
        Try
            If p1 Is Nothing Then
                Return String.Empty
            End If

            If p1.Trim() = "" Then
                Return String.Empty
            End If

            richT.Rtf = p1.Trim()

            Dim res As String = richT.Text.Trim()
            res = res.Trim("\r", "\n")
            Return res
        Catch ex As Exception
            Return p1.Trim()
        End Try

    End Function


    ''' <summary>
    ''' Checks testString for RichTextFormat
    ''' </summary>
    ''' <param name="testString">The string to check</param>
    ''' <returns>True if testString is in RichTextFormat</returns>
    Public Shared Function IsRichText(testString As String) As Boolean
        If (testString IsNot Nothing) AndAlso (testString.Trim().StartsWith("{\rtf")) Then
            Return True
        Else
            Return False
        End If
    End Function


#Region "Enumeradores"


#Region "Procesos"
    Public Enum Partes_Tipos
        <Description("BAJA")> Baja = 1
        <Description("ALTA")> Alta = 2
        <Description("ASISTENCIA")> Asistencia = 3
    End Enum

    Public Enum Partes_Regimen
        <Description("General")> General
        <Description("Agr. C/ Propia")> Agr_C_Propia
        <Description("Agr. C/ Ajena")> Agr_C_Ajena
        <Description("Mar C/ Propia")> Mar_C_Propia
        <Description("Mar C/Ajena")> Mar_C_Ajena
        <Description("M. Carbón")> M_Carbon
    End Enum

    Public Enum Partes_Situacion
        <Description("Activo")> Activo
        <Description("Desempleado jejejej")> Desempleado
    End Enum

    Public Enum Partes_Entidad_Pago_IT_CP
        <Description("INSS")> INSS
        <Description("ISM")> ISM
    End Enum

    Public Enum Partes_Caracter
        <Description("Leve")> Leve
        <Description("Grave")> Grave
        <Description("Muy Grave")> Muy_Grave
    End Enum

    Public Enum Partes_Causa_de_Baja
        <Description("Accidente de Trabajo ")> Accidente_de_Trabajo
        <Description("Enfermedad Profesional ")> Enfermedad_Profesional
        <Description("Periodos de Observación por E.P")> Periodos_de_Observacion_por_EP
        <Description("ICC")> ICC
        <Description("Tráfico")> Trafico
    End Enum


    Public Enum Partes_Causa_de_Alta
        <Description("Curación")> Curacion
        <Description("Fallecimiento")> Fallecimiento
        <Description("Inspección Médica")> Inspección_Medica
        <Description("Propuesta de Incapacidad")> Propuesta_de_Incapacidad
        <Description("Agotamiento Plazo")> Agotamiento_Plazo
        <Description("Mejoría que permite realizar trabajo habitual")> Mejoria_permite_trabajo_habitual
        <Description("Incomparecencia")> Incomparecencia
    End Enum

    Public Enum Partes_Asistencia_Pronostico
        <Description("Leve")> Leve
        <Description("Grave")> Grave
        <Description("Muy Grave")> Muy_Grave
    End Enum


    Public Enum Partes_Asistencia_Regimen
        <Description("General")> General
        <Description("Agr. C/ Propia")> Agr_C_Propia
        <Description("Agr. C/ Ajena")> Agr_C_Ajena
        <Description("Mar C/ Propia")> Mar_C_Propia
        <Description("Mar C/Ajena")> Mar_C_Ajena
        <Description("M. Carbón")> M_Carbon
    End Enum


    Public Enum Partes_Asistencia_Situacion
        <Description("Activo")> Activo
        <Description("Desempleado")> Desempleado
    End Enum

    Public Enum Partes_Asistencia_Tratamiento
        <Description("Domicilio")> Domicilio
        <Description("Ambulatorio")> Ambulatorio
        <Description("Institución Cerrada")> Institucion_Cerrada
    End Enum

    Public Shared Function Proceso_DameIconoEstado(ByVal proceso As CM3DataSet.N_Procesos_ResumenRow) As Image
        If Not proceso.IsFechaFinalNull Then
            If proceso.Finalizado Then
                'Finalizado
                Return Global.centro_medico.My.Resources.Procesos_Finalizado
            Else
                'Cerrado
                Return Global.centro_medico.My.Resources.Procesos_Cerrado
            End If
        Else
            'Abierto
            Return Global.centro_medico.My.Resources.Resources.Procesos_Abierto
        End If
    End Function

#End Region

#Region "TipoPorte"
    Public Enum TipoPorte
        Debidos = 1
        Pagados = 2
    End Enum
#End Region

#Region "TipoProveedor"
    Public Enum TipoProveedor
        Proveedor = 1
        Acreedor = 2
    End Enum
#End Region

#Region "ProveedorIVA"
    Public Enum ProveedorIVA
        Si = 1
        No = 2
        Intracomunitarios = 3
        Importacion = 4
    End Enum
#End Region

#Region "Presupuestos_Estado"
    Public Enum Presupuestos_Estado
        Pendiente = 1
        Aceptado = 2
        Rechazado = 3
        Enviado = 4
    End Enum
#End Region

#Region "Facturas_Estado"
    Public Enum Facturas_Estado
        Pendiente = 1
        PendienteParcial = 2
        Cobrada = 3
        Devuelta = 4
        Anulada = 5
    End Enum
#End Region

#Region "Pedidos_Estado"
    Public Enum Pedidos_Estado
        Pendiente = 1
        PendienteParcial = 2
        Enviado = 3
        Almacenado = 4
    End Enum
#End Region

#Region "PedidosProveedor_Estado"
    Public Enum PedidosProveedor_Estado
        Pendiente_Recibir = 1
        Pendiente_Parcial = 2
        Recibido = 3
    End Enum
#End Region

#Region "FacturasRecibidas_Estado"
    Public Enum FacturasRecibidas_Estado
        Pendiente_Recibir = 1
        Pendiente_Parcial = 2
        Recibido = 3
    End Enum
#End Region

#Region "Devoluciones_Estado"
    Public Enum Devoluciones_Estado
        Sin_Estado = 1
    End Enum
#End Region

#Region "Albaranes_Estado"
    Public Enum Albaranes_Estado
        Pendiente = 1
        Cobrado = 2
        Cobrado_Parcial = 3
    End Enum
#End Region

#Region "Entradas_Estado"
    Public Enum Entradas_Estado
        Pendiente = 1
        Facturado = 2
    End Enum
#End Region

#Region "ModoParaFormas"
    Public Enum ModoParaFormas
        Edicion
        Seleccion
    End Enum
#End Region

#Region "TipoDocumento"
    Public Enum TipoDocumento
        Presupuesto = 1
        Factura = 2
        Albaran = 3
        Pedido = 4
        Entrada = 5
        Devolucion = 6
        PedidoProveedor = 7
        FacturaProveedor = 8
        ParteTrabajo = 9
        Ticket = 10
        RecetasXml = 11
    End Enum
#End Region

#Region "CategoriaDocumento"
    Public Enum CategoriaDocumento
        Notario = 1
        DocumentoExpediente = 2
        DocumentoTramite = 3
        DocumentoGestion = 5
        Comunicaciones = 6
        Poderes = 9
        RegistroPropiedad = 13
        Testamento = 21
        Escrituras = 25
        NIF = 32
        Residencias = 7
        DocumentoCliente = 33
        Agencias = 34
        Bancos = 35
        Notarias = 36
        Ninguno = -1
        DocumentodeVentas = 40
        PresupuestosVentas = 41
        PedidosVentas = 42
        AlbVentas = 43
        FacturasVentas = 44
        DocumentosCompras = 45
        PresupuestosCompras = 46
        PedidosCompras = 47
        AlbaranesCompras = 48
        FacturasCompras = 49
        DocsClientes = 50
        DocsProveedores = 51
        GastosGenerales = 52
        GastosVehiculos = 53
        DocsPersonal = 54
        GastosConductores = 55
    End Enum
#End Region

#Region "Public Enum FormPacienteKeys"
    Public Enum FormPacienteKeys
        Antecendentes = Keys.F1
        DatosPersonales = Keys.F2
        ServiciosPeriodicos = Keys.F3
        HistorialClinico = Keys.F4
        Cita = Keys.F5
        Derivacione = Keys.F6
        Recetas = Keys.F7
        Factura = Keys.F8
        Analiticas = Keys.F9
        RevComparativa = Keys.F10
    End Enum
#End Region

#Region "Public Enum TeclasBasicas"
    Public Enum TeclasBasicas
        Annadir = Keys.Alt Or Keys.A
        Borrar = Keys.Alt Or Keys.B
        Editar = Keys.Alt Or Keys.E
        Filtrar = Keys.Alt Or Keys.F
    End Enum
#End Region

    Public Enum EstadoRecurrencia
        Libre = 1
        Modificandose = 2
    End Enum

    Public Enum ComunicacionTipo
        EMAIL = 1
        SMS = 2
    End Enum

    Public Shared Function VerificaSiCitaEstaEnUsoYSePuedeProceder(ByVal idCita As Integer)

        Dim context As New CMLinqDataContext()
        Try
            Dim cita As CITA = (From c In context.CITAs Where c.IDCITA = idCita Select c).Single()
            If cita.EstadoRecurrencia = Globales.EstadoRecurrencia.Modificandose Then
                Dim diff As Long = DateDiff(DateInterval.Minute, CType(cita.FechaUltimoEstadoRecurrencia, Date), Date.Now)
                Dim diag As DialogResult = MessageBox.Show("Esta cita esta siendo utilizada por otro usuario desde hace " _
                                            & diff & " minutos. Desea desbloquearla? esto podria ocasionar pérdida de datos o inconsistencias. ", "Confirmación", MessageBoxButtons.YesNo)
                If diag = DialogResult.Yes Then
                    Globales.CambiaEstadoRecurrencia(idCita, EstadoRecurrencia.Libre)
                    Return True
                Else
                    Return False
                End If
            Else
                cita.EstadoRecurrencia = Globales.EstadoRecurrencia.Modificandose
                cita.FechaUltimoEstadoRecurrencia = Date.Now
                context.SubmitChanges()
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function DameEstadRecurrenciaCita(ByVal idCita As Integer) As EstadoRecurrencia
        Dim context As New CMLinqDataContext()
        Try
            Dim cita As CITA = (From c In context.CITAs Where c.IDCITA = idCita Select c).Single()
            If cita.EstadoRecurrencia Is Nothing Then Return EstadoRecurrencia.Libre
            Return cita.EstadoRecurrencia
        Catch ex As Exception

        End Try
    End Function

    Public Shared Sub CambiaEstadoRecurrencia(ByVal idCita As Integer, ByVal estado As EstadoRecurrencia)
        Dim context As New CMLinqDataContext()
        Try
            Dim cita As CITA = (From c In context.CITAs Where c.IDCITA = idCita Select c).Single()
            cita.EstadoRecurrencia = estado
            cita.FechaUltimoEstadoRecurrencia = Date.Now
            context.SubmitChanges()
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Verifica el estado de las citas marcadas como Modificandose, si lleva mas de N horas en ese 
    ''' estado pasaran a estar libres.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Function VerificaEstadoRecurrencia(ByVal cantHorasToleradas As Integer) As Integer

        Try
            Dim cont As Integer = -1
            Dim sqlparams(0) As SqlClient.SqlParameter
            Dim tipo As String = ""
            'Dim strSql As String = "Select * FROM CITAS WHERE (EstadoRecurrencia = 2) AND (DATEDIFF(hour, FechaUltimoEstadoRecurrencia, GETDATE()) >= @hora) "

            Dim strSql As String = "UPDATE CITAS  SET EstadoRecurrencia = 1, FechaUltimoEstadoRecurrencia = GETDATE() WHERE  (EstadoRecurrencia = 2) AND (DATEDIFF(hour, FechaUltimoEstadoRecurrencia, GETDATE()) >= @hora)"

            sqlparams(0) = New SqlClient.SqlParameter("@hora", cantHorasToleradas)
            cont = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql, sqlparams)

            Return cont
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Private Shared Function DiferenciaFechas(ByVal d1, ByVal d2) As Long
        Return DateDiff(DateInterval.Hour, d1, d2)
    End Function








    Public Class AuditoriaInfo
        Public Enum Accion
            Abrir = 0
            Borrar = 1
            Guardar = 2
            Imprimir = 3
            Insertar = 4
            Modificar = 5
            Pagar = 6
            Despagar = 7
            Cambio_de_tipo_de_Cita = 8
        End Enum

        Public Shared Sub Registra(ByVal eAccion As Accion, _
                                   ByVal eLocacion As RoleManager.Items, _
                                   Optional ByVal TipoDocumento As String = Nothing, _
                                   Optional ByVal codigoDocumento As String = Nothing, _
                                   Optional ByVal DetallesDocumento As String = "")

            Dim context As New CMLinqDataContext()
            Dim audit As New Auditoria()

            audit.FechaHora = Date.Now
            'audit.idLog = Globales.Usuario.CODIGO
            If Not Globales.Usuario.NOMBRECOMPLETO Is Nothing Then
                audit.NombreUsuario = Globales.Usuario.NOMBRECOMPLETO
            Else
                audit.NombreUsuario = Globales.Usuario.USUARIO
            End If

            If DetallesDocumento Is Nothing Then
                DetallesDocumento = String.Empty
            End If

            audit.loginUsuario = Globales.Usuario.USUARIO
            audit.TipoDocumento = TipoDocumento
            audit.CodigoDocumento = codigoDocumento
            audit.DetallesDocumento = DetallesDocumento
            audit.eAccion = eAccion
            audit.eLocacion = eLocacion
            context.Auditorias.InsertOnSubmit(audit)
            context.SubmitChanges()
        End Sub


    End Class

#End Region

#Region "CITAS"

    'Public Shared Function CalculaImporteTotalDeLineaCita(lineasCita As LineasCita) As Double
    '    Dim res As Double = 0
    '    Dim dto As Double = 0
    '    res = lineasCita.Cantidad * (lineasCita.ImporteClinica + lineasCita.ImporteDr)
    '    If lineasCita.DescuentoPercent.HasValue And res > 0 Then
    '        dto = lineasCita.DescuentoPercent / res
    '    End If
    '    Return res - dto
    'End Function


    Public Shared Function CalculaImporteTotalCitaViaLineasAsCita(ByVal cita As CITA) As CITA
        Dim result As New CITA
        If cita.LineasCitas.Count = 0 Then
            'result.IMPORTEDR = cita.IMPORTEDR
            'result.IMPORTECL = cita.IMPORTECL
            'result.Descuento = cita.Descuento
            'result.TOTAL = CalculaImporteTotalCita(cita)
        Else
            result.IMPORTEDR = cita.LineasCitas.Sum(Function(o) o.ImporteDr * o.Cantidad)
            result.IMPORTECL = cita.LineasCitas.Sum(Function(o) o.ImporteClinica * o.Cantidad)
            result.Descuento = cita.Descuento
            'result.Descuento = cita.LineasCitas.Sum(Function(o) If(o.DescuentoPercent.HasValue And (o.Cantidad * (o.ImporteClinica + o.ImporteDr) > 0), (o.DescuentoPercent / 100) * o.Cantidad * (o.ImporteClinica + o.ImporteDr), 0))

            result.TOTAL = cita.LineasCitas.Sum(Function(o) o.Total)

            'Condiciones para reparacion de datos
            If result.IMPORTECL = 0 And result.IMPORTEDR = 0 And cita.TOTAL <> 0 Then
                result.IMPORTECL = cita.TOTAL
            End If

            Dim diff As Decimal = cita.TOTAL - result.IMPORTECL
            If (result.Descuento = 0 Or Not result.Descuento.HasValue) And result.IMPORTEDR = 0 And Math.Abs(diff) < 0.01 Then
                result.IMPORTECL = cita.TOTAL
            End If

        End If
        Return result
    End Function

    Public Shared Function CalculaImporteTotalCita(ByVal cita As CITA) As Double
        If cita Is Nothing Then Return 0
        Dim total As Double = 0
        Try

            total = cita.IMPORTECL + cita.IMPORTEDR
            If cita.Descuento.HasValue Then
                total = total - cita.Descuento
            End If

            Return total
        Catch ex As Exception
            Return total
        End Try
    End Function

#Region "Public Shared Sub EliminarCitaCorrectamente(ByVal cita As CITA)"
    Public Shared Sub EliminarCitaCorrectamente(ByVal cita As CITA, ByVal confirmadaeliminacion As Boolean)
        If Not cita Is Nothing Then
            If Not confirmadaeliminacion Then
                If MessageBox.Show("Desea realmente eliminar esta cita? ", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    Return
                End If
            End If

            Dim context2 As New CMLinqDataContext()
            Dim cBorrar As CITA = (From c In context2.CITAs Where c.IDCITA = cita.IDCITA Select c).Single()

            'Buscar pagos
            Dim entregascuenta As List(Of EntregasCuenta) = (From e In context2.EntregasCuentas _
                                                            Where e.CodDocumento = cBorrar.IDCITA And e.Eliminado = False _
                                                            Select e).ToList()

            If cBorrar.PAGADA = "S" Then
                If Not Globales.Usuario.EsAdministrador() Then
                    MessageBox.Show("Esta(s) cita(s) está(n) pagada(s), no puede ser eliminada, contacte al Administrador ")
                    Return
                Else
                    If MessageBox.Show("La cita esta pagada, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Return
                    End If
                End If
            End If

            If entregascuenta.Count > 0 Then
                If MessageBox.Show("La cita contiene pagos, desea eliminar estos pagos? En caso negativo se abortará la operación", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    Return
                End If
            End If


            If Not cBorrar.REFFRA Is Nothing Then
                If MessageBox.Show("¿Desea desvincular la cita de su factura asociada? en caso negativo, se abortará la eliminación de la cita ", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                    Dim fact As FACTURA = (From f In context2.FACTURAs Where f.IDFACTURA = cBorrar.REFFRA Select f).SingleOrDefault()

                    If Not fact Is Nothing Then

                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, _
                                                         RoleManager.Items.Citas, "Desvincular Cita", cita.IDCITA, _
                                                         "Desvinculada Factura " & fact.NUMERO & " de cita " & cita.FECHA & " Debido a eliminación de la cita. ")
                    End If
                    cBorrar.REFFRA = Nothing
                Else
                    Return
                End If
            End If

            For Each entrega As EntregasCuenta In entregascuenta
                entrega.Eliminado = True
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, _
                                      RoleManager.Items.Citas, "Eliminar pago", entrega.IDEntregaCuenta, _
                                      "Eliminado pago (" & entrega.Importe.Value.ToString("c2") & " de cita " & cBorrar.IDCITA & " Fecha: " & cBorrar.FECHA & " Paciente:" & _
                                      cBorrar.PACIENTE & " debido a eliminación de la cita. ")

            Next


            centro_medico.CITA.DesvincularSesion(context2, cBorrar)

            'context2.CITAs.DeleteOnSubmit(cBorrar)
            cBorrar.Eliminado = True
            context2.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Citas, "Citas", cita.IDCITA.ToString(), " Paciente: " & cita.PACIENTE & ", Fecha cita: " & cita.FECHA.ToString())

        End If

    End Sub
#End Region






    Public Shared Sub ColoreaCitas(ByVal CONFIRMADA As String, ByVal ATENDIDO As String, ByVal FALTA As String, ByVal PAGADA As String, ByRef bgColor As Color, ByRef forecolor As Color)
        If CONFIRMADA = "S" Then bgColor = Color.Silver
        If ATENDIDO = "S" Then bgColor = Color.FromArgb(70, 200, 200)
        If FALTA = "S" Then bgColor = Color.FromArgb(220, 120, 100)
        If PAGADA = "S" Then bgColor = Color.FromArgb(120, 240, 120)
    End Sub

#End Region

    Public Shared Function DameDatosClinicaReportDatasource() As Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsClinica As New Microsoft.Reporting.WinForms.ReportDataSource
        dsClinica.Name = "dsClinica"

        Dim clinica As New CLINICAINCEME()
        clinica.NOMBRE = centro_medico.Globales.Configuracion.nombrecomercial.Trim()
        clinica.DIRECCION = Globales.Configuracion.domicilio.Trim()
        clinica.CIUDAD = Globales.Configuracion.localidad.Trim()
        clinica.CIF = Globales.Configuracion.CIF.Trim()
        clinica.CPClinica = Globales.Configuracion.CP.Trim()
        clinica.Telefono1 = Globales.Configuracion.Tlfno1
        clinica.Telefono2 = Globales.Configuracion.Tlfno2
        clinica.Fax = Globales.Configuracion.fax
        clinica.Web = Globales.Configuracion.web
        clinica.Email = Globales.Configuracion.Email
        clinica.PROVINCIA = Globales.Configuracion.provincia

        If Globales.Configuracion.logotipo <> String.Empty Then
            clinica.LOGOTIPOURLPARAREPORTE = "file:///" & Globales.Configuracion.logotipo
        End If


        'If Not clinica.LOGOTIPO Is Nothing Then
        '    Dim myImage As Byte() = clinica.LOGOTIPO.ToArray

        '    Dim imgMemoryStream As New IO.MemoryStream(myImage)
        '    Dim bitmap As Bitmap = New Bitmap(imgMemoryStream)

        '    'Salvar la imagen en una direccion temporal

        '    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\logotemp.jpg"

        '    bitmap.Save(filename)
        '    clinica.LOGOTIPOURLPARAREPORTE = "file:///" & filename
        'Else
        '    clinica.LOGOTIPOURLPARAREPORTE = Nothing
        'End If



        Dim listClinica As New List(Of CLINICAINCEME)
        listClinica.Add(clinica)
        dsClinica.Value = listClinica
        Return dsClinica
    End Function

    Public Shared Function GetNewFacturaID() As Integer
        'Determinar el nuevo id
        Dim context As New CMLinqDataContext()
        Dim facturas As List(Of FACTURA) = (From f In context.FACTURAs Select f).ToList()
        If facturas.Count = 0 Then
            Return 1
        Else
            Return facturas.Max(Function(t) t.IDFACTURA) + 1
        End If
    End Function


    Public Shared Function Factura_CreaNueva() As FACTURA
        Dim context As New CMLinqDataContext()
        Dim factura As FACTURA = New FACTURA()

        factura.EMPRESA = String.Empty
        factura.RECIBO = "N"
        factura.EMPRESA = String.Empty
        factura.FEMISION = Date.Now

        'Determinar el nuevo id
        Dim facturas As List(Of FACTURA) = (From f In context.FACTURAs Select f).ToList()
        If facturas.Count = 0 Then
            factura.IDFACTURA = 1
        Else
            factura.IDFACTURA = facturas.Max(Function(t) t.IDFACTURA) + 1
        End If

        Dim frm As New frmFacturasM_ADD()
        frm.Factura = factura
        If frm.ShowDialog() = DialogResult.OK Then
            context.FACTURAs.InsertOnSubmit(factura)
            context.SubmitChanges()
        End If
        Return factura
    End Function

    Public Shared Function Factura_Modifica_y_Salva(ByVal idFactura As Integer) As FACTURA
        Dim context As New CMLinqDataContext()
        Dim factura As FACTURA = (From f In context.FACTURAs Where f.IDFACTURA = idFactura).SingleOrDefault
        If factura Is Nothing Then
            Return Nothing
        End If
        Dim frm As New frmFacturasM_ADD()
        frm.Factura = factura
        If frm.ShowDialog() = DialogResult.OK Then
            context.SubmitChanges()
        End If
        Return factura
    End Function

    Public Shared Sub ConceptoFRA_EliminarCorrectamente(ByVal idConcepto As String, Optional ByVal yesToAll As Boolean = False)
        Dim context As New CMLinqDataContext()
        Dim ConceptoFra As CONCEPTOSFRA = (From c In context.CONCEPTOSFRAs Where c.CODIGO = idConcepto Select c).SingleOrDefault()

        If Not yesToAll Then
            If MessageBox.Show("¿Seguro desea eliminar este concepto facturable? (S/N)", "Confirmacion", MessageBoxButtons.YesNo) = DialogResult.No Then
                Return
            End If
        End If
        Try
            For Each linea As d_PresupuestoLinea In ConceptoFra.d_PresupuestoLineas
                'context.d_PresupuestoLineas.DeleteOnSubmit(linea)
                linea.IDTratamiento = Nothing
            Next

            For Each linea As LINEASFACTURA In ConceptoFra.LINEASFACTURAs
                'context.d_PresupuestoLineas.DeleteOnSubmit(linea)
                linea.REFCONCEPTO = Nothing
            Next

            context.CONCEPTOSFRAs.DeleteOnSubmit(ConceptoFra)
            context.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show("No ha podido ser eliminado el concepto pues esta siendo utilizado por otra entidad")
        End Try



    End Sub


    Public Shared Sub BorrarFicheroLocked(ByVal path As String)
        'Borrar fichero utilizado por otro proceso
        LiberaFichero(path)
        LiberaFichero(path)
        File.Delete(path)
    End Sub




    Private Shared Function GetDNILetter(ByVal DNI As String) As String
        If DNI.Length < 8 Then
            Return "-"
        Else
            Try
                Dim _letters As String() = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"}
                Dim _resto As Integer = Integer.Parse(DNI) Mod 23
                Return _letters(_resto)
            Catch ex As Exception
                Return Nothing
            End Try
        End If
    End Function

#Region "Private Shared Sub LiberaFichero(ByVal path As String)"

    Private Shared Sub LiberaFichero(ByVal path As String)
        'hace llamada a handle.exe

        'System.Environment.ru()

        Dim p As New Process()
        ' Redirect the output stream of the child process.
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = System.Environment.CurrentDirectory + "/handle.exe"
        p.StartInfo.Arguments = " /accepteula " & """" & path & """"
        p.Start()
        ' Do not wait for the child process to exit before
        ' reading to the end of its redirected stream.
        ' p.WaitForExit();
        ' Read the output stream first and then wait.
        Dim output As String = p.StandardOutput.ReadToEnd()
        'Dim pidStartIndex As Integer = output.IndexOf("pid: ") + 5
        'Dim pid As String = output.Substring(pidStartIndex, output.IndexOf(" ", pidStartIndex) - pidStartIndex)
        'Dim handleidStart As Integer = output.IndexOf(pid) + pid.Length
        'Dim handleId As String = output.Substring(handleidStart, output.IndexOf(":", handleidStart) - handleidStart).Trim()
        p.WaitForExit()

        Dim arr() As String = output.Split(New String() {"pid: ", path, "  "}, StringSplitOptions.RemoveEmptyEntries)

        If arr.Length > 2 Then
            Dim i As Integer = 1
            'For i = 1 To arr.Length - 1 Step 2
            Dim pid As String = arr(i + 1).Trim()
            Dim handleId As String = (arr(i + 2).Split(":"))(0).Trim()

            Dim p2 As New Process()
            p2.StartInfo.CreateNoWindow = True
            ' Redirect the output stream of the child process.
            p2.StartInfo.UseShellExecute = False
            p2.StartInfo.RedirectStandardOutput = True
            p2.StartInfo.FileName = System.Environment.CurrentDirectory + "/handle.exe"
            p2.StartInfo.Arguments = " /accepteula -c " & handleId & " -p " & pid & " -y"
            p2.Start()
            p2.WaitForExit()
            'Next
        End If
    End Sub
#End Region

    Public Shared Function Mutua_Existe(ByVal idMutua As Integer, ByVal idPaciente As Integer) As Boolean
        'Si la mutua puesta aqui no esta en la tabla del historial laboral del paciente, hay que insertarlo.
        '-- compruebo si esta.
        Dim cont As Integer = -1
        Dim sqlparams(1) As SqlClient.SqlParameter
        Dim tipo As String = ""
        Dim strSql As String = "Select count(CODIGO) from LMUTUAS WHERE REFMUTUA=@REFMUTUA and REFPACIENTE=@CODPACIENTE"
        sqlparams(0) = New SqlClient.SqlParameter("@REFMUTUA", idMutua)
        sqlparams(1) = New SqlClient.SqlParameter("@CODPACIENTE", idPaciente)
        cont = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql, sqlparams)
        Return cont > 0
    End Function


    Public Shared Function Empresa_Existe(ByVal idEmpresa As Integer, ByVal idPaciente As Integer) As Boolean
        'Si la empresa puesta aqui no esta en la tabla del historial laboral del paciente, hay que insertarlo.
        '-- compruebo si esta.
        Dim cont As Integer = -1
        Dim sqlparams(1) As SqlClient.SqlParameter
        Dim tipo As String
        Dim strSql As String = "Select count(*) from LEMPRESAS WHERE REFEMPRESA=@REFEMPRESA and REFPACIENTE=@CODPACIENTE"
        sqlparams(0) = New SqlClient.SqlParameter("@REFEMPRESA", idEmpresa)
        sqlparams(1) = New SqlClient.SqlParameter("@CODPACIENTE", idPaciente)
        cont = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql, sqlparams)
        Return cont > 0
    End Function

    Public Shared Function PuedeBorrarsePaciente(ByVal idPaciente As Integer)
        Dim context As New CMLinqDataContext()
        Dim paciente As PACIENTE = (From p In context.PACIENTEs _
                                   Where p.CPACIENTE = idPaciente _
                                   Select p).Single()

        Return paciente.HISTORIALEs.Count = 0 Or Usuario.ADMINISTRADOR = "S"
    End Function

#Region "Public Shared Function ExisteCodigoPropioPaciente(ByVal codigoPropioas as String, byval idPaciente as Integer) As Boolean"
    Public Shared Function ExisteCodigoPropioPaciente(ByVal codigoPropio As String, ByVal idPaciente As Integer) As Boolean


        Dim query As String = "SELECT CODIGOPROPIO FROM PACIENTES WHERE CODIGOPROPIO='" & codigoPropio.Trim() & "' AND CPACIENTE<>" & idPaciente

        'Dim params(1) As SqlClient.SqlParameter

        'params(1) = New SqlClient.SqlParameter("CODIGOPROPIO", SqlDbType.VarChar)
        'params(1).Value = codigoPropio
        'params(0) = New SqlClient.SqlParameter("CPACIENTE", SqlDbType.Int)
        'params(0).Value = idPaciente

        Dim res As String = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(System.Configuration.ConfigurationManager.ConnectionStrings("centro_medico.My.MySettings.CMConnectionString").ConnectionString, CommandType.Text, query)

        Return Not res = Nothing
    End Function
#End Region

#Region "RecuperCodigoSerie"
    Shared Function RecuperaCodigoSerie(ByVal id As Integer, ByVal tipo As Globales.TipoDocumento) As String
        Dim res As String = ""
        Dim NomCampoId As String = ""
        Dim NomCampoCodigo As String = "Codigo"
        Dim NomCampoTipo As String = ""
        Dim NomTabla As String = ""
        Select Case tipo
            Case TipoDocumento.Presupuesto
                NomCampoId = "ID_Presupuesto"
                NomCampoTipo = "ID_TipoPresupuesto"
                NomTabla = "N_Presupuestos"
            Case TipoDocumento.Pedido
                NomCampoId = "ID_Pedido"
                NomCampoTipo = "ID_TipoPedido"
                NomTabla = "N_Pedidos"
            Case TipoDocumento.Albaran
                NomCampoId = "ID_Albaran"
                NomCampoTipo = "ID_TipoAlbaran"
                NomTabla = "N_Albaranes"
            Case TipoDocumento.Factura
                NomCampoId = "ID_Factura"
                NomCampoTipo = "ID_TipoFactura"
                NomTabla = "N_Factura"
            Case TipoDocumento.Ticket
                NomCampoId = "ID_Ticket"
                NomCampoTipo = "ID_TipoTicket"
                NomTabla = "N_Ticket"
            Case TipoDocumento.PedidoProveedor
                NomCampoId = "ID_PedidoProveedor"
                NomCampoTipo = "ID_TipoPedidoProveedor"
                NomTabla = "N_PedidosProveedor"
            Case TipoDocumento.Entrada
                NomCampoId = "ID_Entrada"
                NomCampoTipo = "ID_TipoEntrada"
                NomTabla = "N_Entradas"
            Case TipoDocumento.Devolucion
                NomCampoId = "ID_Devolucion"
                NomCampoTipo = "ID_TipoDevolucion"
                NomTabla = "N_Devoluciones"
            Case TipoDocumento.FacturaProveedor
                NomCampoId = "ID_FacturaRecibida"
                NomCampoTipo = "ID_TipoFacturaRecibida"
                NomTabla = "N_FacturasRecibidas"
            Case Else
                Return id
                Exit Function

        End Select

        res = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, "SELECT CONVERT(varchar(10), " & NomCampoTipo & ") + '/' + " & NomCampoCodigo & " AS CodigoSerie FROM  " & NomTabla & " Where " & NomCampoId & " = " & id)
        Return res
    End Function
#End Region

#Region "Public Shared Function PuedeModificarseHistorial(ByVal FECHA As Date) As Boolean"
    Public Shared Function PuedeModificarseHistorial(ByVal FECHA As Date) As Boolean
        If Globales.Usuario.Permisos(RoleManager.Items.Bloquear_historial) = RoleManager.TipoPermisos.Ninguno Then
            If Date.Now.Subtract(FECHA).Days > 0 Then
                Return False
            End If
        End If
        Return True
    End Function
#End Region

#Region "Public Shared Sub ChequeaIdentidadTarifas()"
    Public Shared Sub ChequeaIdentidadTarifas()

        'Determinar si la columna es Identidad

        Dim tbl As DataTable

        Dim str As String = "Select * From Tarifas"
        tbl = SqlHelper.ExecuteReader(System.Configuration.ConfigurationManager.ConnectionStrings("centro_medico.My.MySettings.CMConnectionString").ConnectionString, CommandType.Text, str).GetSchemaTable()

        Dim row As DataRow
        For Each row In tbl.Rows
            If row("IsAutoIncrement") Then
                SqlHelper.ExecuteNonQuery(System.Configuration.ConfigurationManager.ConnectionStrings("centro_medico.My.MySettings.CMConnectionString").ConnectionString, CommandType.Text, My.Resources.EliminaIdentidadTarifas)
                Return
            End If
        Next

    End Sub
#End Region

#Region "Public Shared Function DocumentosRelacionados(ByVal TipoDoc As TipoDocumento, ByVal Id_Doc As Integer) As String(,)"

    Public Shared Function DocumentosRelacionados(ByVal TipoDoc As TipoDocumento, ByVal Id_Doc As Integer) As String(,)
        Dim resultado(1, 0) As String
        Select Case TipoDoc
            Case TipoDocumento.Presupuesto
                Dim dreader As SqlClient.SqlDataReader
                Dim i As Integer = -1
                'pedidos
                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_pedido from N_Pedidos_Lineas where ID_DocOrigen=" & Id_Doc & " And Id_TipoDocOrigen = 1")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = CInt(TipoDocumento.Pedido)
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_Pedido"), TipoDocumento.Pedido)
                End While
                dreader.Close()
                dreader = Nothing

                'albaranes
                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_Albaran from N_Albaranes_Lineas where ID_DocOrigen=" & Id_Doc & " And Id_TipoDocOrigen = 1")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = CInt(TipoDocumento.Albaran)
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_Albaran"), TipoDocumento.Albaran)
                End While

                'facturas
                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_Factura from N_Facturas_Lineas where ID_DocOrigen=" & Id_Doc & " And Id_TipoDocOrigen = 1")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = CInt(TipoDocumento.Factura)
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_Factura"), TipoDocumento.Factura)
                End While
                dreader.Close()
                dreader = Nothing

            Case TipoDocumento.Pedido
                Dim dreader As SqlClient.SqlDataReader
                Dim i As Integer = -1


                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_DocOrigen,Id_TipoDocOrigen from N_Pedidos_Lineas where ID_Pedido=" & Id_Doc & " and not Id_DocOrigen is null")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = dreader.Item("Id_TipoDocOrigen")
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_DocOrigen"), dreader.Item("Id_TipoDocOrigen"))
                End While
                dreader.Close()
                dreader = Nothing

                'albaranes
                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_Albaran from N_Albaranes_Lineas where ID_DocOrigen=" & Id_Doc & " AND ID_TipoDocOrigen = 4")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = CInt(TipoDocumento.Albaran)
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_Albaran"), TipoDocumento.Albaran)
                End While
                dreader.Close()
                dreader = Nothing

                'facturas
                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_Factura from N_Facturas_Lineas where ID_DocOrigen=" & Id_Doc & " AND id_TipoDocOrigen = 4")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = CInt(TipoDocumento.Factura)
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_Factura"), TipoDocumento.Factura)
                End While
                dreader.Close()
                dreader = Nothing

            Case TipoDocumento.Ticket
                Dim dreader As SqlClient.SqlDataReader
                Dim i As Integer = -1


                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_DocOrigen,Id_TipoDocOrigen from N_Ticket_Lineas where ID_Ticket=" & Id_Doc & " and not Id_DocOrigen is null")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = dreader.Item("Id_TipoDocOrigen")
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_DocOrigen"), dreader.Item("Id_TipoDocOrigen"))
                End While
                dreader.Close()
                dreader = Nothing

                ''albaranes
                'dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_Albaran from N_Albaranes_Lineas where ID_DocOrigen=" & Id_Doc & " AND ID_TipoDocOrigen = 4")
                'While dreader.Read
                '    i += 1
                '    ReDim Preserve resultado(1, i)
                '    resultado(0, i) = CInt(TipoDocumento.Albaran)
                '    resultado(1, i) = Globals.RecuperaCodigoSerie(dreader.Item("Id_Albaran"), TipoDocumento.Albaran)
                'End While
                'dreader.Close()
                'dreader = Nothing

                'facturas
                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_Factura from N_Factura_Lineas where ID_DocOrigen=" & Id_Doc & " AND id_TipoDocOrigen = 10")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = CInt(TipoDocumento.Factura)
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_Factura"), TipoDocumento.Factura)
                End While
                dreader.Close()
                dreader = Nothing

            Case TipoDocumento.Albaran
                Dim dreader As SqlClient.SqlDataReader
                Dim i As Integer = -1

                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_DocOrigen,Id_TipoDocOrigen from N_Albaranes_Lineas where ID_Albaran=" & Id_Doc & " and not Id_DocOrigen is null")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = dreader.Item("Id_TipoDocOrigen")
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_DocOrigen"), dreader.Item("Id_TipoDocOrigen"))
                End While
                dreader.Close()
                dreader = Nothing

                'facturas
                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_Factura from N_Facturas_Lineas where ID_DocOrigen=" & Id_Doc & " And Id_TipoDocOrigen = 3")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = CInt(TipoDocumento.Factura)
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_Factura"), TipoDocumento.Factura)
                End While
                dreader.Close()
                dreader = Nothing

            Case TipoDocumento.Factura
                Dim dreader As SqlClient.SqlDataReader
                Dim i As Integer = -1


                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_DocOrigen,Id_TipoDocOrigen from N_Factura_Lineas where ID_Factura=" & Id_Doc & " and not Id_DocOrigen is null")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = dreader.Item("Id_TipoDocOrigen")
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_DocOrigen"), dreader.Item("Id_TipoDocOrigen"))
                End While
                dreader.Close()
                dreader = Nothing

            Case TipoDocumento.PedidoProveedor
                Dim dreader As SqlClient.SqlDataReader
                Dim i As Integer = -1

                'Entrada
                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_Entrada from N_Entradas_Lineas where ID_DocOrigen=" & Id_Doc & " And Id_TipoDocOrigen = 7")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = CInt(TipoDocumento.Entrada)
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_Entrada"), TipoDocumento.Entrada)
                End While
                dreader.Close()
                dreader = Nothing

                ''Devolucion
                'dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_Devolucion from N_Devoluciones_Lineas where ID_DocOrigen=" & Id_Doc & " And Id_TipoDocOrigen = 7")
                'While dreader.Read
                '    i += 1
                '    ReDim Preserve resultado(1, i)
                '    resultado(0, i) = CInt(TipoDocumento.Devolucion)
                '    resultado(1, i) = Globals.RecuperaCodigoSerie(dreader.Item("Id_Devolucion"), TipoDocumento.Devolucion)
                'End While
                'dreader.Close()
                'dreader = Nothing

                'facturas_proveedor
                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_FacturaRecibida from N_FacturasRecibidas_Lineas where ID_DocOrigen=" & Id_Doc & " And Id_TipoDocOrigen = 7")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = CInt(TipoDocumento.Factura)
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_FacturaRecibida"), TipoDocumento.FacturaProveedor)
                End While
                dreader.Close()
                dreader = Nothing

            Case TipoDocumento.Entrada
                Dim dreader As SqlClient.SqlDataReader
                Dim i As Integer = -1

                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_DocOrigen,Id_TipoDocOrigen from N_Entradas_Lineas where ID_Entrada=" & Id_Doc & " and not Id_DocOrigen is null")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = dreader.Item("Id_TipoDocOrigen")
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_DocOrigen"), dreader.Item("Id_TipoDocOrigen"))
                End While
                dreader.Close()
                dreader = Nothing

                'Devolucion
                'dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_Devolucion from N_Devoluciones_Lineas where ID_DocOrigen=" & Id_Doc & " And Id_TipoDocOrigen = 5")
                'While dreader.Read
                '    i += 1
                '    ReDim Preserve resultado(1, i)
                '    resultado(0, i) = CInt(TipoDocumento.Devolucion)
                '    resultado(1, i) = Globals.RecuperaCodigoSerie(dreader.Item("Id_Devolucion"), TipoDocumento.Devolucion)
                'End While
                'dreader.Close()
                'dreader = Nothing

                'facturas_proveedor
                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_FacturaRecibida from N_FacturasRecibidas_Lineas where ID_DocOrigen=" & Id_Doc & " And Id_TipoDocOrigen = 5")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = CInt(TipoDocumento.Factura)
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_FacturaRecibida"), TipoDocumento.FacturaProveedor)
                End While
                dreader.Close()
                dreader = Nothing

                'Case TipoDocumento.Devolucion
                '    Dim dreader As SqlClient.SqlDataReader
                '    Dim i As Integer = -1

                '    dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_DocOrigen,Id_TipoDocOrigen from N_Devoluciones_Lineas where ID_Devolucion=" & Id_Doc & " and not Id_DocOrigen is null")
                '    While dreader.Read
                '        i += 1
                '        ReDim Preserve resultado(1, i)
                '        resultado(0, i) = dreader.Item("Id_TipoDocOrigen")
                '        resultado(1, i) = Globals.RecuperaCodigoSerie(dreader.Item("Id_DocOrigen"), dreader.Item("Id_TipoDocOrigen"))
                '    End While
                '    dreader.Close()
                '    dreader = Nothing

                '    'facturas_proveedor
                '    dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_FacturaRecibida from N_FacturasRecibidas_Lineas where ID_DocOrigen=" & Id_Doc & " And Id_TipoDocOrigen = 6")
                '    While dreader.Read
                '        i += 1
                '        ReDim Preserve resultado(1, i)
                '        resultado(0, i) = CInt(TipoDocumento.Factura)
                '        resultado(1, i) = Globals.RecuperaCodigoSerie(dreader.Item("Id_FacturaRecibida"), TipoDocumento.FacturaProveedor)
                '    End While
                '    dreader.Close()
                '    dreader = Nothing

            Case TipoDocumento.FacturaProveedor
                Dim dreader As SqlClient.SqlDataReader
                Dim i As Integer = -1

                dreader = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteReader(My.MySettings.Default.CMConnectionString, CommandType.Text, "Select distinct Id_DocOrigen,Id_TipoDocOrigen from N_FacturasRecibidas_Lineas where ID_FacturaRecibida=" & Id_Doc & " and not Id_DocOrigen is null")
                While dreader.Read
                    i += 1
                    ReDim Preserve resultado(1, i)
                    resultado(0, i) = dreader.Item("Id_TipoDocOrigen")
                    resultado(1, i) = Globales.RecuperaCodigoSerie(dreader.Item("Id_DocOrigen"), dreader.Item("Id_TipoDocOrigen"))
                End While
                dreader.Close()
                dreader = Nothing
        End Select

        Return resultado
    End Function
#End Region



    Public Shared Function GetLetter(ByVal DNI As String) As String
        Try
            If DNI.Length < 8 Then
                Return String.Empty
            Else
                Dim _letters As String() = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"}
                Dim _resto As Integer = Integer.Parse(DNI) Mod 23
                Return _letters(_resto)
            End If
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Shared Sub ErrorMsg(ByRef ex As Exception, ByVal msg As String)
        Dim frm As frmErrores = New frmErrores(msg, ex)
        Dim io As New System.IO.StreamWriter(Application.StartupPath & "\logError.txt", True)
        io.WriteLine(Now.ToShortDateString & " " & Now.ToShortTimeString & " - " & msg)
        io.WriteLine(ex.ToString)
        io.Flush()
        io.Close()
        frm.ShowDialog()
    End Sub

    Public Shared Sub ShowError(ByVal msg As String, ByRef ex As Exception)
        Dim frm As frmErrores = New frmErrores(msg, ex)
        frm.ShowDialog()
    End Sub

    Public Shared Sub ShowError(ByRef ex As Exception)
        Dim frm As frmErrores = New frmErrores(ex)
        frm.ShowDialog()
    End Sub
    Public Nmedicamentos As Integer = 0

    Public Shared Function ObtenerMedicamentos(Optional ByRef NombreMedicamento As String = "") As DataTable
        Dim req As HttpWebRequest
        Dim strUrl As String
        Dim Nombre As String = ""
        Dim CNacional As Object
        Dim CRegistro As Object
        Dim strm As System.IO.Stream
        Dim strm2 As System.IO.StreamReader
        Dim encode As System.Text.Encoding
        Dim i As Integer = 0
        Dim x As Integer = 0
        Dim xmlRead As Xml.XmlDataDocument
        Dim tabla As New DataTable("table")
        Dim fila As DataRow
        Try
            Nombre = NombreMedicamento
            CNacional = ""
            CRegistro = ""

            strUrl = "https://sinaem4.agemed.es/consaem/fichasTecnicas.do?d-1338201-e=3&fichaFIni=&fichaCompleta=on&6578706f7274=1&grupTerap=&fichaFFin=&prActiv1=&prActiv2=&codNacional=" & CNacional & "&descLabora=&numDefinitivo=" & CRegistro & "&especialidad=*" & Nombre & "*&formulario=FICHAS&metodo=buscar&metodo=buscar"
            req = HttpWebRequest.Create(strUrl)
            req.Method = "GET"

            Dim resp As System.Net.HttpWebResponse
            resp = req.GetResponse
            strm = resp.GetResponseStream()
            encode = System.Text.Encoding.GetEncoding("utf-8")
            strm2 = New System.IO.StreamReader(strm, encode)

            'Paso la respuesta de la web a un xml

            xmlRead = New Xml.XmlDataDocument
            xmlRead.Load(strm2)

            'Preparo la tabla
            tabla.Columns.Add("CodigoNacional")
            tabla.Columns.Add("CodigoRegistro")
            tabla.Columns.Add("NombreMedicamento")
            tabla.Columns.Add("Laboratorio")
            tabla.Columns.Add("FechaAutorizacion")
            tabla.Columns.Add("EstadoPresentacion")
            tabla.Columns.Add("Comercializacion")
            tabla.Columns.Add("FichaTecnica")
            tabla.Columns.Add("Prospecto")

            For i = 0 To xmlRead.DocumentElement.ChildNodes.Count - 1
                fila = tabla.NewRow
                For x = 0 To xmlRead.DocumentElement.ChildNodes(i).ChildNodes.Count - 1
                    With xmlRead.DocumentElement.ChildNodes(i).ChildNodes(x)
                        Select Case x
                            Case 0 : fila("CodigoNacional") = .FirstChild.Value
                            Case 1 : fila("CodigoRegistro") = .FirstChild.Value
                            Case 2 : fila("NombreMedicamento") = .FirstChild.Value
                            Case 3 : fila("Laboratorio") = .FirstChild.Value
                            Case 4 : fila("FechaAutorizacion") = .FirstChild.Value
                            Case 5 : fila("EstadoPresentacion") = .FirstChild.Value
                            Case 6 : fila("Comercializacion") = .FirstChild.Value

                        End Select

                    End With
                Next
                fila("FichaTecnica") = "https://sinaem4.agemed.es/consaem/especialidad.do?metodo=verFichaWordPdf&codigo=" & fila("CodigoRegistro").ToString & "&formato=pdf&formulario=FICHAS"
                fila("Prospecto") = "https://sinaem4.agemed.es/consaem/especialidad.do?metodo=verFichaWordPdf&codigo=" & fila("CodigoRegistro").ToString & "&formato=pdf&formulario=PROSPECTOS"
                tabla.Rows.Add(fila)
            Next

            Return tabla
        Catch EX As Exception
            Return Nothing
        End Try
    End Function

#Region "Public Shared Function DamePrimeraFecha(ByVal campoFecha As String, ByVal tabla As String) As Date"
    Public Shared Function DamePrimeraFecha(ByVal campoFecha As String, ByVal tabla As String) As Date
        Dim query As String = "SELECT MIN(" & campoFecha & ")AS FECHA FROM " & tabla
        Dim res As Object = SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, query)
        If res Is Nothing Or res Is DBNull.Value Then
            Return New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 0, 0, 0)
        Else
            Return res
        End If
    End Function
#End Region


#Region "Public Shared Function GeneraCodigoAutomatico(ByVal tableName As String, ByVal columnName As String, ByVal format As String) As String"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tableName">Nombre de la tabla a consultar</param>
    ''' <param name="columnName">Nombre de la columna de la que debemos obtener el valor maximo</param>
    ''' <param name="format">"Formato que debe tener en cuenta la función para devolver el codigo correspondiente"</param>
    ''' <param name="where">Condición que deseamos añadir a la consulta, debemos añadir el comando where, por ejemplo "where columnname='a'"</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GeneraCodigoAutomatico(ByVal tableName As String, ByVal columnName As String, ByVal format As String, Optional ByVal where As String = "") As String
        Dim query As String = "SELECT MAX(" & columnName & ") FROM " + tableName + " " + where
        Dim max As Long = 0
        Dim numberStr As String = ""
        Dim fill As String = format
        Try
            Dim obj As Object = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, query)
            If Not obj Is DBNull.Value Then
                max = CType(obj, Long)
            End If
            numberStr = (max + 1).ToString()
            fill = format.Substring(0, format.Length - numberStr.Length)
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        End Try
        Return fill + numberStr
    End Function
#End Region

#Region "Public Shared Function ObtenerMaximoValor(ByVal tableName As String, ByVal columnName As String, ByVal format As String) As Long"

    Public Shared Function ObtenerMaximoValor(ByVal tableName As String, ByVal columnName As String) As Long
        Dim query As String = "SELECT MAX(" & columnName & ") FROM " + tableName
        Dim max As Long = 0
        Try
            Dim obj As Object = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, query)
            If Not obj Is DBNull.Value Then
                max = CType(obj, Long)
            End If
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        End Try
        Return max
    End Function
#End Region


    'Calculo de Stock

#Region "Public Shared Function CalculaStock(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer, ByVal Fecha2 As Date) As Long"
    Public Shared Function CalculaStock(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer, ByVal Fecha2 As Date) As StockArticulo
        'Para efectuar la consolidacion de un Articulo, se necesita un intervalo de tiempo
        ' - Fecha Inicio: Fecha de la consolidacion anterior, de no haber ninguna se consolidaran todas las entradas
        '                 existentes para el a
        'Fecha Final:     Fecha especificada por el usuario, indica que debe consolidarse hasta esta fecha el inventario

        'Determinar Fecha Inicio para un articulo y almacen especificos, como la mayor fecha que es menor que la especificada

        Dim stockArticulo As New StockArticulo()
        stockArticulo.ID_Articulo = ID_Articulo
        stockArticulo.ID_Almacen = ID_Almacen
        stockArticulo.FechaCalculado = DateTime.Now

        Dim entradas As Long = 0
        Dim facturasProveedor As Long = 0
        Dim pedidosProveedor As Long = 0
        Dim tickets As Double = 0
        Dim facturas As Double = 0

        'Dim ff As Date = New Date(Fecha2.Year, Fecha2.Month, Fecha2.Day

        'Dim consolidacion As CMDataSet.N_Articulos_ConsolidacionStockRow = Globales.Consolidacion_MasReciente_Anterior_a_Fecha(ID_Articulo, _
        '                                                              ID_Almacen, _
        '                                                              Fecha2)

        Dim context As New CMLinqDataContext
        Dim consolidacion As N_Articulos_ConsolidacionStock = (From c In context.N_Articulos_ConsolidacionStocks
                                                              Where c.ID_Articulo = ID_Articulo And ID_Almacen = ID_Almacen _
                                                              And c.Fecha <= Fecha2
                                                              Order By c.Fecha Descending
                                                              Select c).FirstOrDefault()


        If consolidacion Is Nothing Then
            'No hay consolidacion previa consolidar todas las entradas (y pedidos a proveedor) anteriores a @Fecha
            'MessageBox.Show("No hay consolidaciones previas")

            'COMPRAS
            entradas = Globales.SumaEntradas(ID_Articulo, ID_Almacen)
            facturasProveedor = Globales.SumaFacturasProveedorLineas(ID_Articulo, ID_Almacen)
            pedidosProveedor = Globales.SumaPedidosProveedorLineas(ID_Articulo, ID_Almacen)

            'VENTAS
            tickets = Globales.SumaTickets(ID_Articulo, ID_Almacen)
            facturas = Globales.SumaFacturasVentas(ID_Articulo, ID_Almacen)

            'STOCK
            stockArticulo.StockReal = (entradas + facturasProveedor) - (tickets + facturas)

            Try
                Dim articulosPendientesValidacion = (From l In context.N_PedidosProveedor_Lineas
                                         Where l.ID_Articulo = ID_Articulo And (Not l.Validado.HasValue Or l.Validado = False)
                                         Select l
                                         ).ToList().Sum(Function(k) k.Cantidad)

                'If articulosPendientesValidacion.Count > 0 Then
                stockArticulo.StockPrevisto = stockArticulo.StockReal + articulosPendientesValidacion
                ' End If


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


            'stockArticulo.StockPrevisto = (entradas + facturasProveedor + pedidosProveedor) - (tickets + facturas)

        Else
            'Sumar a partir de la consolidacion anterior
            'COMPRAS
            entradas = Globales.SumaEntradas(ID_Articulo, ID_Almacen, consolidacion.Fecha)
            facturasProveedor = Globales.SumaFacturasProveedorLineas(ID_Articulo, ID_Almacen, consolidacion.Fecha)
            pedidosProveedor = Globales.SumaPedidosProveedorLineas(ID_Articulo, ID_Almacen, consolidacion.Fecha)

            'VENTAS
            tickets = Globales.SumaTickets(ID_Articulo, ID_Almacen, consolidacion.Fecha)
            facturas = Globales.SumaFacturasVentas(ID_Articulo, ID_Almacen, consolidacion.Fecha)

            'STOCK
            stockArticulo.StockReal = (consolidacion.UnidadesContadas + entradas + facturasProveedor) - (tickets + facturas)



            Try
                Dim articulosPendientesValidacion = (From l In context.N_PedidosProveedor_Lineas
                                         Where l.ID_Articulo = ID_Articulo And (Not l.Validado.HasValue Or l.Validado = False) And l.N_PedidosProveedor.Fecha >= consolidacion.Fecha
                                         Select l
                                         ).ToList().Sum(Function(k) k.Cantidad)

                'If articulosPendientesValidacion.Count > 0 Then
                stockArticulo.StockPrevisto = stockArticulo.StockReal + articulosPendientesValidacion
                ' End If


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            'stockArticulo.StockPrevisto = (consolidacion.UnidadesContadas + entradas + facturasProveedor + pedidosProveedor) - (tickets + facturas)

        End If
        Return stockArticulo
    End Function
#End Region

#Region "Public Shared Function CalculaStockTodosAlmacenes(ByVal ID_Articulo As Long, ByVal Fecha2 As Date) As StockArticulo"
    Public Shared Function CalculaStockTodosAlmacenes(ByVal ID_Articulo As Long, ByVal Fecha2 As Date) As StockArticulo

        Dim stockArticulo As New StockArticulo()
        stockArticulo.ID_Articulo = ID_Articulo
        'stockArticulo.ID_Almacen = ID_Almacen
        stockArticulo.FechaCalculado = DateTime.Now

        Dim almacenes As CMDataSet.N_AlmacenDataTable = New CMDataSet.N_AlmacenDataTable()
        Dim AlmacenAdapter As CMDataSetTableAdapters.N_AlmacenTableAdapter = New CMDataSetTableAdapters.N_AlmacenTableAdapter()
        AlmacenAdapter.Fill(almacenes)

        stockArticulo.StockReal = 0
        stockArticulo.StockPrevisto = 0

        For Each almacen As CMDataSet.N_AlmacenRow In almacenes
            Dim temp As StockArticulo = CalculaStock(ID_Articulo, almacen.ID_Almacen, Fecha2)
            stockArticulo.StockReal = stockArticulo.StockReal + temp.StockReal
            stockArticulo.StockPrevisto = stockArticulo.StockPrevisto + temp.StockPrevisto
        Next
        Return stockArticulo
    End Function
#End Region

    '#Region "Public Shared Function Consolidacion_MasReciente_Anterior_a_Fecha(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer, ByVal FechaFinal As Date)"
    '    Public Shared Function Consolidacion_MasReciente_Anterior_a_Fecha(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer, ByVal FechaFinal As Date) As CMDataSet.N_Articulos_ConsolidacionStockRow

    '        Dim consolidaciones As CMDataSet.N_Articulos_ConsolidacionStockDataTable = New CMDataSet.N_Articulos_ConsolidacionStockDataTable()
    '        Dim adapter As CMDataSetTableAdapters.N_Articulos_ConsolidacionStockTableAdapter = New CMDataSetTableAdapters.N_Articulos_ConsolidacionStockTableAdapter()

    '        adapter.FillByAlmacenOrdenByFechaDesc(consolidaciones, ID_Articulo, ID_Almacen)

    '        If consolidaciones.Count > 0 Then
    '            Return consolidaciones(0)
    '        Else
    '            Return Nothing
    '        End If
    '    End Function
    '#End Region

#Region "Public Shared Function SumaEntradas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer) As Long"
    Public Shared Function SumaEntradas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer) As Long
        Dim query As String = "SELECT SUM(Cantidad) AS Cantidad FROM N_Entradas_Lineas WHERE (ID_Articulo = @ID_Articulo) AND (ID_Almacen = @ID_Almacen)"

        Dim parameters As List(Of SqlClient.SqlParameter) = New List(Of SqlClient.SqlParameter)
        Dim p1 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Articulo", SqlDbType.BigInt)
        p1.Value = ID_Articulo

        Dim p2 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Almacen", SqlDbType.Int)
        p2.Value = ID_Almacen

        'Dim p3 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@FechaInicial", SqlDbType.DateTime)
        'p3.Value = FechaFinal

        parameters.Add(p1)
        parameters.Add(p2)
        'parameters.Add(p3)

        Dim res As Object = SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, query, parameters.ToArray())

        If res Is DBNull.Value Then
            Return 0
        Else
            Return CType(res, Integer)
        End If
    End Function
#End Region

#Region "Public Shared Function SumaEntradas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer, ByVal Fecha As Date)"
    Public Shared Function SumaEntradas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer, ByVal FechaInicial As Date) As Long
        Dim query As String = "SELECT  ISNULL(SUM(Cantidad), 0) AS Cantidad FROM  N_Entradas_Lineas WHERE  (ID_Articulo = @ID_Articulo) AND (ID_Almacen = @ID_Almacen) AND (ID_Entrada IN  (SELECT     ID_Entrada FROM N_Entradas WHERE (Fecha >= @Fecha1)))"

        Dim parameters As List(Of SqlClient.SqlParameter) = New List(Of SqlClient.SqlParameter)
        Dim p1 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Articulo", SqlDbType.BigInt)
        p1.Value = ID_Articulo

        Dim p2 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Almacen", SqlDbType.Int)
        p2.Value = ID_Almacen

        Dim p3 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@Fecha1", SqlDbType.DateTime)
        p3.Value = FechaInicial

        'Dim p4 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@Fecha2", SqlDbType.DateTime)
        'p4.Value = FechaFinal

        parameters.Add(p1)
        parameters.Add(p2)
        parameters.Add(p3)
        'parameters.Add(p4)

        Dim res As Object = SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, query, parameters.ToArray())

        If res Is DBNull.Value Then
            Return 0
        Else
            Return CType(res, Integer)
        End If
    End Function
#End Region


#Region "Public Shared Function SumaFacturasProveedorLineas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer, ByVal Fecha As Date)"
    Public Shared Function SumaFacturasProveedorLineas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer, ByVal FechaInicial As Date) As Long

        'Que no provengan de una entrada

        Dim query As String = "SELECT     ISNULL(SUM(Cantidad), 0) AS Cantidad FROM         N_FacturasRecibidas_Lineas WHERE     (ID_Articulo = @ID_Articulo) AND (ID_Almacen = @ID_Almacen) AND (ID_TipoDocOrigen <> 5 OR  ID_TipoDocOrigen IS NULL) AND (ID_FacturaRecibida IN  (SELECT ID_FacturaRecibida FROM N_FacturasRecibidas WHERE (Fecha >= @Fecha1)))"

        Dim parameters As List(Of SqlClient.SqlParameter) = New List(Of SqlClient.SqlParameter)
        Dim p1 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Articulo", SqlDbType.BigInt)
        p1.Value = ID_Articulo

        Dim p2 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Almacen", SqlDbType.Int)
        p2.Value = ID_Almacen

        Dim p3 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@Fecha1", SqlDbType.DateTime)
        p3.Value = FechaInicial

        'Dim p4 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@Fecha2", SqlDbType.DateTime)
        'p4.Value = FechaFinal

        parameters.Add(p1)
        parameters.Add(p2)
        parameters.Add(p3)
        'parameters.Add(p4)

        Dim res As Object = SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, query, parameters.ToArray())

        If res Is DBNull.Value Then
            Return 0
        Else
            Return CType(res, Integer)
        End If
    End Function
#End Region

#Region "Public Shared Function SumaFacturasProveedorLineas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer)"
    Public Shared Function SumaFacturasProveedorLineas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer) As Long

        'Suma todas las FacturasProveedorLineas existentes sin restriccion de fecha
        'y que no provengan de una Entrada

        Dim query As String = "SELECT     ISNULL(SUM(Cantidad), 0) AS Cantidad FROM         N_FacturasRecibidas_Lineas WHERE     (ID_Articulo = @ID_Articulo) AND (ID_Almacen = @ID_Almacen) AND (ID_TipoDocOrigen <> 5 OR  ID_TipoDocOrigen IS NULL)"

        Dim parameters As List(Of SqlClient.SqlParameter) = New List(Of SqlClient.SqlParameter)
        Dim p1 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Articulo", SqlDbType.BigInt)
        p1.Value = ID_Articulo

        Dim p2 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Almacen", SqlDbType.Int)
        p2.Value = ID_Almacen


        'Dim p4 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@Fecha2", SqlDbType.DateTime)
        'p4.Value = FechaFinal

        parameters.Add(p1)
        parameters.Add(p2)
        'parameters.Add(p4)

        Dim res As Object = SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, query, parameters.ToArray())

        If res Is DBNull.Value Then
            Return 0
        Else
            Return CType(res, Integer)
        End If
    End Function
#End Region


#Region "Public Shared Function SumaPedidosProveedorLineas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer, ByVal Fecha As Date)"
    Public Shared Function SumaPedidosProveedorLineas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer, ByVal FechaInicial As Date) As Long

        'Que no provengan de una entrada

        Dim query As String = "SELECT ISNULL(SUM(Cantidad), 0) AS Cantidad FROM N_PedidosProveedor_Lineas WHERE (ID_Articulo = @ID_Articulo) AND (ID_Almacen = @ID_Almacen) AND (ID_PedidoProveedor IN  (SELECT ID_PedidoProveedor FROM N_PedidosProveedor WHERE (Fecha >= @Fecha1)))"

        Dim parameters As List(Of SqlClient.SqlParameter) = New List(Of SqlClient.SqlParameter)
        Dim p1 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Articulo", SqlDbType.BigInt)
        p1.Value = ID_Articulo

        Dim p2 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Almacen", SqlDbType.Int)
        p2.Value = ID_Almacen

        Dim p3 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@Fecha1", SqlDbType.DateTime)
        p3.Value = FechaInicial

        'Dim p4 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@Fecha2", SqlDbType.DateTime)
        'p4.Value = FechaFinal

        parameters.Add(p1)
        parameters.Add(p2)
        parameters.Add(p3)
        'parameters.Add(p4)

        Dim res As Object = SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, query, parameters.ToArray())

        If res Is DBNull.Value Then
            Return 0
        Else
            Return CType(res, Integer)
        End If
    End Function
#End Region

#Region "Public Shared Function SumaPedidosProveedorLineas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer)"
    Public Shared Function SumaPedidosProveedorLineas(ByVal ID_Articulo As Long, ByVal ID_Almacen As Integer) As Long

        'Que no provengan de una entrada

        Dim query As String = "SELECT ISNULL(SUM(Cantidad), 0) AS Cantidad FROM N_PedidosProveedor_Lineas WHERE (ID_Articulo = @ID_Articulo) AND (ID_Almacen = @ID_Almacen)"

        Dim parameters As List(Of SqlClient.SqlParameter) = New List(Of SqlClient.SqlParameter)
        Dim p1 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Articulo", SqlDbType.BigInt)
        p1.Value = ID_Articulo

        Dim p2 As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ID_Almacen", SqlDbType.Int)
        p2.Value = ID_Almacen

        parameters.Add(p1)
        parameters.Add(p2)

        Dim res As Object = SqlHelper.ExecuteScalar(My.MySettings.Default.CMConnectionString, CommandType.Text, query, parameters.ToArray())

        If res Is DBNull.Value Then
            Return 0
        Else
            Return CType(res, Integer)
        End If
    End Function
#End Region

    Public Shared Function SumaTickets(ByVal id_articulo As Long, ByVal id_almacen As Integer, ByVal Fecha As Date) As Double
        'he de sumar la cantidad de articulos cuya linea de ticket tenga en el campo Id_Almacen el id_almacen y cuyo id_articulo sea el 
        'Id_articulo siempre que no hayan sido procesados
        Dim strSql As String = ""
        Dim sqlpar(2) As Data.SqlClient.SqlParameter
        Dim Total As Double = 0


        strSql = "Select ISNULL(sum(Cantidad),0) AS Total from " & _
                " N_ticket_lineas inner join N_Ticket on N_Ticket_Lineas.ID_Ticket = N_Ticket.ID_Ticket " & _
                " where id_articulo = @id_articulo and id_almacen = @id_almacen and N_Ticket.Fecha >= @Fecha and " & _
                " N_Ticket.id_ticket not in (Select id_DocOrigen from N_Factura_Lineas Where Id_TipoDocOrigen = 10) "

        sqlpar(0) = New Data.SqlClient.SqlParameter("@id_Articulo", id_articulo)
        sqlpar(1) = New Data.SqlClient.SqlParameter("@id_almacen", id_almacen)
        sqlpar(2) = New Data.SqlClient.SqlParameter("@Fecha", Fecha)

        Total = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql, sqlpar)

        Return Total
    End Function

    Public Shared Function SumaTickets(ByVal id_articulo As Long, ByVal id_almacen As Integer) As Double
        'he de sumar la cantidad de articulos cuya linea de ticket tenga en el campo Id_Almacen el id_almacen y cuyo id_articulo sea el 
        'Id_articulo siempre que no hayan sido procesados

        Dim strSql As String = ""
        Dim sqlpar As Data.SqlClient.SqlParameter()
        Dim Total As Double = 0


        strSql = "Select ISNULL(sum(Cantidad),0) AS Total from N_ticket_lineas, N_ticket where N_Ticket.id_Ticket = N_Ticket_Lineas.id_Ticket and " & _
        " id_articulo = @id_articulo and id_almacen = @id_almacen and " & _
        " N_Ticket_lineas.id_ticket not in (Select id_DocOrigen from N_Factura_Lineas, N_Factura Where N_Factura.ID_Factura = N_Factura_Lineas.ID_Factura and Id_TipoDocOrigen = 10 " & _
        ")"
        ReDim sqlpar(1)
        sqlpar(0) = New Data.SqlClient.SqlParameter("@id_Articulo", id_articulo)
        sqlpar(1) = New Data.SqlClient.SqlParameter("@id_almacen", id_almacen)


        Total = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql, sqlpar)

        Return Total
    End Function

    Public Shared Function SumaFacturasVentas(ByVal id_articulo As Long, ByVal id_almacen As Integer, ByVal Fecha As Date) As Double
        'he de sumar la cantidad de articulos cuya linea de fra tenga en el campo Id_Almacen el id_almacen y cuyo id_articulo sea el id_Articulo

        Dim strSql As String = ""
        Dim sqlpar(2) As Data.SqlClient.SqlParameter
        Dim Total As Double = 0


        strSql = "Select ISNULL(sum(Cantidad),0) AS Total from N_Factura_lineas inner join N_Factura on N_Factura_Lineas.ID_Factura = N_Factura.ID_Factura where id_articulo = @id_articulo and id_almacen = @id_almacen and N_Factura.Fecha >= @Fecha"

        sqlpar(0) = New Data.SqlClient.SqlParameter("@id_Articulo", id_articulo)
        sqlpar(1) = New Data.SqlClient.SqlParameter("@id_almacen", id_almacen)
        sqlpar(2) = New Data.SqlClient.SqlParameter("@Fecha", Fecha)

        Total = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql, sqlpar)

        Return Total
    End Function

    Public Shared Function SumaFacturasVentas(ByVal id_articulo As Long, ByVal id_almacen As Integer) As Double
        'he de sumar la cantidad de articulos cuya linea de fra tenga en el campo Id_Almacen el id_almacen y cuyo id_articulo sea el id_Articulo

        Dim strSql As String = ""
        Dim sqlpar As Data.SqlClient.SqlParameter()
        Dim Total As Double = 0


        strSql = "Select ISNULL(sum(Cantidad),0) AS Total from N_Factura_lineas where id_articulo = @id_articulo and id_almacen = @id_almacen"
        ReDim sqlpar(1)
        sqlpar(0) = New Data.SqlClient.SqlParameter("@id_Articulo", id_articulo)
        sqlpar(1) = New Data.SqlClient.SqlParameter("@id_almacen", id_almacen)

        Total = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql, sqlpar)

        Return Total
    End Function
#Region "Public Shared Sub CobroEnCascada(Optional ByRef RefFra As Integer = -1, Optional ByRef RefRecibo As Integer = -1, _"
    'Actualiza Citas, Facturas y recibos
    Public Shared Sub CobroEnCascada(Optional ByRef RefFra As Integer = -1, Optional ByRef RefRecibo As Integer = -1, _
    Optional ByRef RefAnalitica As Integer = -1, Optional ByRef RefCita As Integer = -1)
        Dim strSqlFacturaPagada As String
        Dim strSqlCitaPagada As String
        Dim strSqlAnaliticaPagada As String
        Dim strSqlReciboPagada As String
        Dim conString As String = Global.centro_medico.My.MySettings.Default.CMConnectionString
        Dim paramFacturas(2) As SqlClient.SqlParameter
        Dim paramCitas(2) As SqlClient.SqlParameter
        Dim paramRecibos(2) As SqlClient.SqlParameter
        Dim paramAnaliticas(0) As SqlClient.SqlParameter
        Dim Estado As Object = ""
        strSqlFacturaPagada = "Update FACTURAS Set PAGADA=@ESTADO, FECHACOBRO=@FRAFECHAPAGADA WHERE IDFACTURA=@IDFACTURA"
        strSqlCitaPagada = "Update CITAS Set PAGADA=@ESTADO, FECHACOBRO=@CITFECHAPAGADA WHERE IDCITA=@IDCITA"
        strSqlAnaliticaPagada = "Update ANALITICAS Set ESTADO=@ESTADO WHERE REFFRA="
        strSqlReciboPagada = "Update RECIBOS Set COBRADO=@ESTADO, FECHACOBRO=@RECFECHAPAGADA WHERE NUMERO=@IDRECIBO"

        'RECIBOS
        If RefRecibo > -1 Then
            'ACTUALIZAR LAS FACTURAS RELACIONADAS
            Estado = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select COBRADO From RECIBOS where NUMERO =" & RefRecibo)
            Dim idfactura As Object
            Dim fechaPagada As Object
            idfactura = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select REFFACTURA From RECIBOS where NUMERO =" & RefRecibo)
            If Not idfactura Is Nothing Then
                If Not idfactura.GetType Is GetType(DBNull) Then
                    If idfactura > 0 Then
                        fechaPagada = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select FECHACOBRO From RECIBOS where NUMERO =" & RefRecibo)
                        If fechaPagada.GetType Is GetType(DBNull) Then fechaPagada = Now
                        paramFacturas(0) = New SqlClient.SqlParameter("@FRAFECHAPAGADA", fechaPagada.Date)
                        paramFacturas(1) = New SqlClient.SqlParameter("@IDFACTURA", idfactura)
                        paramFacturas(2) = New SqlClient.SqlParameter("@ESTADO", Estado)
                        SqlHelper.ExecuteNonQuery(conString, CommandType.Text, strSqlFacturaPagada, paramFacturas)
                    End If
                End If
            End If

            'ACTUALIZAR LAS CITAS RELACIONADAS
            Dim idcita As Object
            idcita = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select REFCITA From RECIBOS where NUMERO =" & RefRecibo)
            If Not idcita Is Nothing Then
                If Not idcita.GetType Is GetType(DBNull) Then
                    If idcita > 0 Then
                        fechaPagada = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select FECHACOBRO From RECIBOS where NUMERO =" & RefRecibo)
                        If fechaPagada.GetType Is GetType(DBNull) Then fechaPagada = Now
                        paramCitas(0) = New SqlClient.SqlParameter("@CITFECHAPAGADA", fechaPagada.Date)
                        paramCitas(1) = New SqlClient.SqlParameter("@IDCITA", idcita)
                        paramCitas(2) = New SqlClient.SqlParameter("@ESTADO", Estado)
                        SqlHelper.ExecuteNonQuery(conString, CommandType.Text, strSqlCitaPagada, paramCitas)
                    End If
                End If
            End If
        End If
        'FACTURAS
        If RefFra > 0 Then
            'ACTUALIZAR LAS CITAS RELACIONADAS
            Estado = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select PAGADA From FACTURAS where IDFACTURA =" & RefFra)
            Dim fechaPagada As Object
            Dim idcita As Object
            idcita = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select REFCITA From FACTURAS where IDFACTURA =" & RefFra)
            If Not idcita Is Nothing Then
                If Not idcita.GetType Is GetType(DBNull) Then
                    If idcita > 0 Then
                        fechaPagada = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select FECHACOBRO From FACTURAS where IDFACTURA =" & RefFra)
                        If fechaPagada.GetType Is GetType(DBNull) Then fechaPagada = Now
                        paramCitas(0) = New SqlClient.SqlParameter("@CITFECHAPAGADA", fechaPagada.Date)
                        paramCitas(1) = New SqlClient.SqlParameter("@IDCITA", idcita)
                        paramCitas(2) = New SqlClient.SqlParameter("@ESTADO", Estado)
                        SqlHelper.ExecuteNonQuery(conString, CommandType.Text, strSqlCitaPagada, paramCitas)
                    End If
                End If
            End If
            'ACTUALIZAR LOS RECIBOS RELACIONAD0S
            Dim idrecibo As Object
            idrecibo = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select REFRECIBO From FACTURAS where IDFACTURA =" & RefFra)
            If Not idrecibo Is Nothing Then
                If Not idrecibo.GetType Is GetType(DBNull) Then
                    If idrecibo > 0 Then
                        fechaPagada = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select FECHACOBRO From FACTURAS where IDFACTURA =" & RefFra)
                        If fechaPagada.GetType Is GetType(DBNull) Then fechaPagada = Now
                        paramRecibos(0) = New SqlClient.SqlParameter("@RECFECHAPAGADA", fechaPagada.Date)
                        paramRecibos(1) = New SqlClient.SqlParameter("@IDRECIBO", idrecibo)
                        paramRecibos(2) = New SqlClient.SqlParameter("@ESTADO", Estado)
                        SqlHelper.ExecuteNonQuery(conString, CommandType.Text, strSqlReciboPagada, paramRecibos)
                    End If
                End If
            End If
            'ACTUALIZAR LOS ANALITICAS RELACIONADAS
            paramAnaliticas(0) = New SqlClient.SqlParameter("@ESTADO", Estado)
            SqlHelper.ExecuteNonQuery(conString, CommandType.Text, strSqlAnaliticaPagada & RefFra, paramAnaliticas)

        End If


        'CITAS
        If RefCita > -1 Then
            'ACTUALIZAR LAS FACTURAS RELACIONADAS
            Estado = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select PAGADA From CITAS where IDCITA =" & RefCita)
            Dim fechaPagada As Object
            Dim idfra As Object
            idfra = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select REFFRA From CITAS where IDCITA =" & RefCita)

            If Not idfra Is Nothing Then
                If Not idfra.GetType Is GetType(DBNull) Then
                    If idfra > 0 Then
                        fechaPagada = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select FECHACOBRO From CITAS where IDCITA=" & RefCita)
                        If fechaPagada.GetType Is GetType(DBNull) Then fechaPagada = Now
                        paramFacturas(0) = New SqlClient.SqlParameter("@FRAFECHAPAGADA", fechaPagada.Date)
                        paramFacturas(1) = New SqlClient.SqlParameter("@IDFACTURA", idfra)
                        paramFacturas(2) = New SqlClient.SqlParameter("@ESTADO", Estado)
                        SqlHelper.ExecuteNonQuery(conString, CommandType.Text, strSqlFacturaPagada, paramFacturas)
                    End If
                End If
            End If

            'ACTUALIZAR LOS RECIBOS RELACIONAD0S
            Dim idrecibo As Object
            idrecibo = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select REFRECIBO From CITAS where IDCITA =" & RefCita)
            If Not idrecibo Is Nothing Then
                If Not idrecibo.GetType Is GetType(DBNull) Then
                    If idrecibo > 0 Then
                        fechaPagada = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select FECHACOBRO From CITAS where IDCITA=" & RefCita)
                        If fechaPagada.GetType Is GetType(DBNull) Then fechaPagada = Now
                        paramRecibos(0) = New SqlClient.SqlParameter("@RECFECHAPAGADA", fechaPagada.Date)
                        paramRecibos(1) = New SqlClient.SqlParameter("@IDRECIBO", idrecibo)
                        paramRecibos(2) = New SqlClient.SqlParameter("@ESTADO", Estado)
                        SqlHelper.ExecuteNonQuery(conString, CommandType.Text, strSqlReciboPagada, paramRecibos)
                    End If
                End If
            End If
        End If

        'ANALITICAS
        If RefAnalitica > -1 Then
            'ACTUALIZAR LAS FACTURAS RELACIONADAS
            Estado = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select ESTADO From ANALITICAS where NUMERO =" & RefAnalitica)
            Dim fechapagada As Object
            Dim idfra As Object
            idfra = SqlHelper.ExecuteScalar(conString, CommandType.Text, "Select REFFRA From ANALITICAS where NUMERO =" & RefAnalitica)
            fechapagada = Now.Date
            If Not idfra Is Nothing Then
                If Not idfra.GetType Is GetType(DBNull) Then
                    If idfra > 0 Then
                        paramFacturas(0) = New SqlClient.SqlParameter("@FRAFECHAPAGADA", fechapagada.Date)
                        paramFacturas(1) = New SqlClient.SqlParameter("@IDFACTURA", idfra)
                        paramFacturas(2) = New SqlClient.SqlParameter("@ESTADO", Estado)
                        SqlHelper.ExecuteNonQuery(conString, CommandType.Text, strSqlFacturaPagada, paramFacturas)
                    End If
                End If
            End If
        End If

    End Sub

#End Region

#Region "Public Shared Sub CheckPermisosEnBD()"
    ''' <summary>
    ''' Checkea si existe el permiso BloquearHistorial. Si no existe lo crea y lo añade a los roles que hay creado 
    ''' en la bd  asignandole un valor inicial y siendo este true en caso de tener la propiedad Fixed a true ya que eso 
    ''' identifica al administrador.
    ''' Se crea con el fin de no tener que modificar mediante script en caso de no existir.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub CheckPermisoBloquearHistorial()
        Try
            ' check si existe el permiso
            Dim existe As Integer = 0
            existe = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, "Select count(*) from ROLESITEMS where Nombre='Bloquear_historial'")

            'si es 0 lo creo en la tabal ROLESITEMS
            If existe = 0 Then
                'obtengo el ultimo id insertado
                Dim ultimoId As Integer = -1
                'ultimoId = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, "Select Max(Id_ROLESITEM) from ROLESITEMS")
                ultimoId = 63

                'inserto en la tabla ROLESITEMS el permiso
                SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, "insert ROLESITEMS (ID_ROLESITEM,Nombre) values (" & ultimoId & ",'Bloquear_historial')")

                'insertamos el permiso a todos los roles creados.
                Dim dreader As SqlClient.SqlDataReader
                dreader = SqlHelper.ExecuteReader(My.Settings.CMConnectionString, CommandType.Text, "Select distinct ID_ROLES from ROLESPERMISOS")
                While dreader.Read
                    Dim fixed As Boolean = False
                    Dim permiso As RoleManager.TipoPermisos

                    'Compruebo si el rol es Fixed para ponerle como valor al permiso (Total), en caso contrario le pondre (ninguno)
                    ' lo cual se traduce en que permiso (total) permite ver los historiales del dia siguientes, permiso (ninguno) no lo permite
                    fixed = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, "Select Fixed From ROLES Where ID_ROLE=" & dreader.Item("ID_ROLES"))

                    'Inserto el permiso
                    If fixed = True Then
                        permiso = RoleManager.TipoPermisos.Total
                    Else
                        permiso = RoleManager.TipoPermisos.Ninguno
                    End If
                    SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, "Insert ROLESPERMISOS (ID_ROLES,ID_PERMISO,ID_ROLESITEM,Notas) values (" & dreader.Item("ID_ROLES") & "," & CInt(permiso) & "," & ultimoId & ",'')")
                End While

            End If
        Catch ex As Exception
            Globales.ShowError("Error al crear el permiso BloquearHistorial", ex)
        End Try
    End Sub

    Public Shared Sub CheckPermisoAlmacen()
        CheckPermisos(65, "Almacen")
    End Sub

    Public Shared Sub CheckPermisoConsolidarStock()
        CheckPermisos(66, "Consolidar_Stock")
    End Sub

    Public Shared Sub CheckPermisoComerciales()
        CheckPermisos(67, "Comerciales")
    End Sub

    Public Shared Sub CheckPermisoArticulosAlmacen()
        CheckPermisos(68, "Articulos_Stock_Almacen")
    End Sub

    Public Shared Sub CheckPermisoArticulos()
        CheckPermisos(69, "Articulos")
    End Sub

    Public Shared Sub CheckPermisoEntradas()
        CheckPermisos(70, "Entradas")
    End Sub

    Public Shared Sub CheckPermisoFacturasRecibidas()
        CheckPermisos(71, "Facturas_Compras")
    End Sub

    Public Shared Sub CheckPermisoPedidosProveedores()
        CheckPermisos(72, "Pedidos_Compras")
    End Sub

    Public Shared Sub CheckPermisoPoblaciones()
        CheckPermisos(74, "Poblaciones")
    End Sub

    Public Shared Sub CheckPermisoFacturasVentas()
        CheckPermisos(75, "Facturas_Ventas")
    End Sub

    Public Shared Sub CheckPermisoTickets()
        CheckPermisos(76, "Tickets_Ventas")
    End Sub

    Public Shared Sub CheckPermisoAsistenteFacturacion()
        CheckPermisos(77, "Asistente_Facturacion")
    End Sub

    Public Shared Sub CheckPermisoImporteCitas()
        CheckPermisos(78, "ImporteCitas")
    End Sub


    Public Shared Sub CheckPermisoComoConocio()
        CheckPermisos(79, "ComoConocio")
    End Sub

#Region "Public Shared Sub CheckPermisos(ByVal Idcorrespondiente As Integer, ByVal NombrePermiso As String)"
    Public Shared Sub CheckPermisos(ByVal Idcorrespondiente As Integer, ByVal NombrePermiso As String)
        Try
            Dim existe As Integer = 0
            existe = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, "Select count(*) from ROLESITEMS where Nombre='" & NombrePermiso.Trim & "'")

            'si es 0 lo creo en la tabal ROLESITEMS
            If existe = 0 Then
                'obtengo el ultimo id insertado
                Dim ultimoId As Integer = -1
                ultimoId = Idcorrespondiente

                'inserto en la tabla ROLESITEMS el permiso
                SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, "insert ROLESITEMS (ID_ROLESITEM,Nombre) values (" & ultimoId & ",'" & NombrePermiso.Trim & "')")

                'insertamos el permiso a todos los roles creados.
                Dim dreader As SqlClient.SqlDataReader
                dreader = SqlHelper.ExecuteReader(My.Settings.CMConnectionString, CommandType.Text, "Select distinct ID_ROLES from ROLESPERMISOS")
                While dreader.Read
                    Dim fixed As Boolean = False
                    Dim permiso As RoleManager.TipoPermisos

                    'Compruebo si el rol es Fixed para ponerle como valor al permiso (Total), en caso contrario le pondre (ninguno)
                    ' lo cual se traduce en que permiso (total) permite ver los historiales del dia siguientes, permiso (ninguno) no lo permite
                    fixed = SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, "Select Fixed From ROLES Where ID_ROLE=" & dreader.Item("ID_ROLES"))

                    'Inserto el permiso
                    If fixed = True Then
                        permiso = RoleManager.TipoPermisos.Total
                    Else
                        permiso = RoleManager.TipoPermisos.Ninguno
                    End If
                    SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, "Insert ROLESPERMISOS (ID_ROLES,ID_PERMISO,ID_ROLESITEM,Notas) values (" & dreader.Item("ID_ROLES") & "," & CInt(permiso) & "," & ultimoId & ",'')")
                End While

            End If
        Catch ex As Exception
            Globales.ShowError("Error al crear el permiso BloquearHistorial", ex)
        End Try
    End Sub
#End Region

#End Region
#Region "Frases"
    Public Shared ErrorPermisoNoAutorizado As String = "No tiene permisos para acceder a esta parte del programa"
    Public Shared Sub MsgboxErrorPermisoNoAutorizado()
        MsgBox(ErrorPermisoNoAutorizado, MsgBoxStyle.Exclamation)
    End Sub
#End Region

    Shared Function EstaDisponibleSala(ID_Sala As Integer?, fecha As Date, horainicio As Date, horafin As Date) As Boolean
        Dim fInicio As Date = New Date(fecha.Year, fecha.Month, fecha.Day, horainicio.Hour, horainicio.Minute, 0)
        Dim fFinal As Date = New Date(fecha.Year, fecha.Month, fecha.Day, horafin.Hour, horafin.Minute, 0)
        Try
            Dim con As New CMLinqDataContext()

            Dim citassalas As List(Of CITA) = (From c In con.CITAs
                                              Where (((c.HORA >= fInicio And c.HORA < fFinal) _
                                              Or (c.HORAFIN > fInicio And c.HORAFIN <= fFinal)) _
                                              Or (c.HORA <= fInicio And c.HORAFIN >= fFinal)) _
                                              And c.Eliminado = False _
                                              And c.ID_SALA = ID_Sala _
                                              Select c).ToList()
            Return (citassalas.Count = 0)

        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al chequear Disponbilidad de sala")
            Return False
        End Try
    End Function


    Shared Function EstaDisponibleSala(ID_Sala As Integer?, fecha As Date, horainicio As Date, horafin As Date, ByVal ID_Cita_a_Excluir As Integer) As Boolean
        Dim fInicio As Date = New Date(fecha.Year, fecha.Month, fecha.Day, horainicio.Hour, horainicio.Minute, 0)
        Dim fFinal As Date = New Date(fecha.Year, fecha.Month, fecha.Day, horafin.Hour, horafin.Minute, 0)

        Dim con As New CMLinqDataContext()

        Dim citassalas As List(Of CITA) = (From c In con.CITAs
                                          Where (((c.HORA >= fInicio And c.HORA < fFinal) _
                                          Or (c.HORAFIN > fInicio And c.HORAFIN <= fFinal)) _
                                          Or (c.HORA <= fInicio And c.HORAFIN >= fFinal)) _
                                          And c.Eliminado = False _
                                          And c.ID_SALA = ID_Sala _
                                          And c.IDCITA <> ID_Cita_a_Excluir
                                          Select c).ToList()

        Return (citassalas.Count = 0)


    End Function

    'Shared Function HorarioDisponible(ID_Sala As Integer?, fecha As Date, horainicio As Date, horafin As Date) As DateTime
    '    Dim fInicio As Date = New Date(fecha.Year, fecha.Month, fecha.Day, horainicio.Hour, horainicio.Minute, 0)
    '    Dim fFinal As Date = New Date(fecha.Year, fecha.Month, fecha.Day, horafin.Hour, horafin.Minute, 0)

    '    Dim context As New CMLinqDataContext()
    '    Dim ScheduleSalas As New Janus.Windows.Schedule.Schedule
    '    ScheduleSalas.DataSource = From c In context.CITAs
    '                                Select c



    '    ScheduleSalas.EndTimeMember = "HORAFIN"
    '    ScheduleSalas.OwnerMember = "ID_Sala"
    '    ScheduleSalas.StartTimeMember = "HORA"

    '    ScheduleSalas.MultiOwner = True ' Globales.Configuracion.Calendario_MostrarListaMedicosPorDefecto
    '    ScheduleSalas.Date = Date.Now

    '    ScheduleSalas.ShowTimeAsClocks = False
    '    ScheduleSalas.Owners.Clear()

    '    Dim salas = (From s In context.SALAs Select New ScheduleAppointmentOwner(s.ID_SALA, s.Nombre)).ToArray()
    '    'GridEXSalas.DataSource = salas
    '    ScheduleSalas.Owners.AddRange(salas)
    '    ScheduleSalas.DayColumns = salas.Length


    '    Dim salaOwner As New Janus.Windows.Schedule.ScheduleAppointmentOwner(ID_Sala, "ID_SALDA")
    '    Dim datef As Date = ScheduleSalas.FindFreeTimeSlot(fInicio, fFinal - fInicio, True, salaOwner)
    '    Return datef
    'End Function






End Class


Public Class StockArticulo
    Public ID_Articulo As Long
    Public ID_Almacen As Long
    Public FechaCalculado As Date
    Public StockReal As Long
    Public StockPrevisto As Long
End Class

Public Class FreeMemory

    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" ( _
    ByVal process As IntPtr, _
    ByVal minimumWorkingSetSize As Integer, _
    ByVal maximumWorkingSetSize As Integer) As Integer

    Public Shared Sub FlushMemory()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
        End If
    End Sub

End Class
