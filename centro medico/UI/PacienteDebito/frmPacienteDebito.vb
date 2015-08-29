Imports centro_medico
Imports Janus.Windows.GridEX
Imports System.Data.Linq
Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Reportes

Public Class frmPacienteDebito

    Dim context As New CMLinqDataContext()
    Dim Credito As Double = 0
    Dim Debe As Double = 0
    Dim Selected As Double = 0

    Public CitasPagadas As New List(Of CITA)
    Public FacturaPagadas As New List(Of FACTURA)
    Public TicketsPagados As New List(Of N_Ticket)
    Public RecibosPagados As New List(Of RECIBO)
    Public FacturasTPVPagados As New List(Of N_Factura)



    Public PagarDirecto As Boolean = False

    Public DocumentosPreseleccionados As New List(Of IDocumentoPagable)

    Public IdsCitasPreseleccionadas As List(Of Integer) = New List(Of Integer)
    Public IdsFacturasPreseleccionadas As List(Of Integer) = New List(Of Integer)
    Public IdsRecibosPreseleccionadas As List(Of Integer) = New List(Of Integer)
    Public IdsTicketsPreseleccionadas As List(Of Integer) = New List(Of Integer)
    Public IdsFacturasTPVPreseleccionadas As List(Of Integer) = New List(Of Integer)



    Public FormaPagoPreseleccionada As FORMASPAGO = Nothing
    Public FormaPagoSeleccionadaAlPagar As FORMASPAGO = Nothing



    'Private RowToPagarDirecto As GridEXRow
    Private FechaPagoDirecto As Date = Date.Now

    Public Event CitaPagada(ByVal id As Integer)
    Public Event FacturaPagada(ByVal id As Integer)
    Public Event ReciboPagado(ByVal id As Integer)
    Public Event TicketPagado(ByVal idFactura As Integer)
    Public Event FacturasTPVPagado(ByVal idFactura As Integer)

    'Private frm As New frmPagarCantidad

    Public Sub PagaCreditoDirecto()


        Calcula()
        btnPagar_Click(Nothing, Nothing)

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        If CitasPagadas.Count > 0 Or _
           FacturaPagadas.Count > 0 Or TicketsPagados.Count > 0 Or RecibosPagados.Count > 0 Or FacturasTPVPagados.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If


        Me.Close()

    End Sub

    Private Sub frmPacienteDebito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CtrlPaciente1.ID_PACIENTE = 888
        CargaDatos()
        GridEXDocs.ExpandRecords()
        'PagaCreditoDirecto()
    End Sub

    Private Sub CargaDatos()
        'btnPagar.Enabled = False
        If Not RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.PagosPaciente_Borrar) = RoleManager.TipoPermisos.Total Then
            Me.cmsPagos.Enabled = False
        End If

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            PACIENTEBindingSource.Clear()

            Dim idPaciente As Integer = CtrlPaciente1.ID_PACIENTE
            context = New CMLinqDataContext()

            Dim paciente As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = idPaciente).SingleOrDefault()


            Dim filtro As New FiltroGenericoDocumentos()
            filtro.StatusPago = StatusPago.NoPagado
            filtro.CPACIENTE = idPaciente

            If dtp_Inicio.Checked Then
                filtro.FechaEmisionInicial = dtp_Inicio.Value
            End If

            If dtp_Final.Checked Then
                filtro.FechaEmisionFinal = dtp_Final.Value
            End If


            Dim pacienteDebito As New PacienteDebitoManager(paciente, context, filtro)
            Try
                PACIENTEBindingSource.DataSource = pacienteDebito
                PagosPacientesBindingSource.DataSource = pacienteDebito.PagosPacientes
                EntregasCuentasBindingSource.DataSource = pacienteDebito.EntregasCuentas

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            ' GridEXDocs.DataSource = datospaciente
            GridEXDocs.Refresh()


            Filtrar()
        Else
            PACIENTEBindingSource.DataSource = Nothing
            PagosPacientesBindingSource.DataSource = Nothing
            EntregasCuentasBindingSource.DataSource = Nothing
            'TabPageCitas.Text = "CITAS (0)"
        End If
        GridEXDocs.ExpandRecords()
    End Sub

#Region "Private Sub Filtrar()"
    Private Sub Filtrar()


        ''Filtrar citas
        'Dim conditionCitas As GridEXFilterCondition = GridEXDocs.RootTable.ChildTables("CITAs").StoredFilters("StoredFilterCitas").FilterCondition.Clone()

        'Dim conditionFacturas As GridEXFilterCondition = GridEXDocs.RootTable.ChildTables("FACTURAs").StoredFilters("StoredFilterFacturas").FilterCondition.Clone()

        'Dim conditionRecibos As GridEXFilterCondition = GridEXDocs.RootTable.ChildTables("RECIBOs").StoredFilters("StoredFilterRecibos").FilterCondition.Clone()
        'Dim conditionTickets As GridEXFilterCondition = GridEXDocs.RootTable.ChildTables("N_Tickets").StoredFilters("StoredFilterTickets").FilterCondition.Clone()
        ''Dim conditionFACTURASTPV As GridEXFilterCondition = GridEXDocs.RootTable.ChildTables("N_Facturas").StoredFilters("StoredFilter1").FilterCondition.Clone()


        ''conditionFacturas.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("FACTURAs").Columns(""), ConditionOperator.IsNull, Nothing))

        'If dtp_Inicio.Checked Then
        '    Dim fechaIni As Date = New Date(dtp_Inicio.Value.Year, dtp_Inicio.Value.Month, dtp_Inicio.Value.Day, 0, 0, 0)
        '    conditionCitas.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("CITAs").Columns("FECHA"), ConditionOperator.GreaterThanOrEqualTo, fechaIni))
        '    conditionFacturas.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("FACTURAs").Columns("FECHA"), ConditionOperator.GreaterThanOrEqualTo, fechaIni))
        '    conditionRecibos.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("RECIBOs").Columns("FECHAEMISION"), ConditionOperator.GreaterThanOrEqualTo, fechaIni))
        '    conditionTickets.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("N_Tickets").Columns("Fecha"), ConditionOperator.GreaterThanOrEqualTo, fechaIni))
        'End If

        'If dtp_Final.Checked Then
        '    Dim fechaFin As Date = New Date(dtp_Final.Value.Year, dtp_Final.Value.Month, dtp_Final.Value.Day, 23, 59, 59)
        '    conditionCitas.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("CITAs").Columns("FECHA"), ConditionOperator.LessThanOrEqualTo, fechaFin))
        '    conditionFacturas.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("FACTURAs").Columns("FECHA"), ConditionOperator.LessThanOrEqualTo, fechaFin))
        '    conditionRecibos.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("RECIBOs").Columns("FECHAEMISION"), ConditionOperator.LessThanOrEqualTo, fechaFin))
        '    conditionTickets.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("N_Tickets").Columns("Fecha"), ConditionOperator.LessThanOrEqualTo, fechaFin))
        'End If

        'GridEXDocs.RootTable.ChildTables("CITAs").FilterCondition = conditionCitas

        'GridEXDocs.RootTable.ChildTables("FACTURAs").FilterCondition = conditionFacturas
        ''GridEXDocs.RootTable.ChildTables("FACTURAs").ChildTables("LINEASFACTURAs").FilterCondition = New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("FACTURAS").ChildTables("LINEASFACTURAs").Columns("ColumnPagada"), ConditionOperator.Equal, 0)


        'GridEXDocs.RootTable.ChildTables("RECIBOs").FilterCondition = conditionRecibos
        'GridEXDocs.RootTable.ChildTables("N_Tickets").FilterCondition = conditionTickets
        ''GridEXDocs.RootTable.ChildTables("N_Facturas").FilterCondition = conditionFACTURASTPV

        Calcula()

    End Sub
#End Region



    Private Sub dtp_Final_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Final.ValueChanged
        'CargaDatos()
        Filtrar()
    End Sub

    Private Sub dtp_Inicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Inicio.ValueChanged
        'CargaDatos()
        Filtrar()
    End Sub

    Function EsLineaFacturaPagada(row As GridEXRow) As Boolean

        Dim lineaFactura As LINEASFACTURA = row.DataRow
        If Not lineaFactura Is Nothing Then
            If lineaFactura.RefLineaCita.HasValue Then
                Dim lineaCita As LineasCita = (From c In Context.LineasCitas Where c.IdLinea = lineaFactura.RefLineaCita Select c).SingleOrDefault()
                If Not lineaCita.CITA Is Nothing Then
                    If lineaCita.CITA.PAGADA = "S" Then
                        Return True
                    End If
                End If
            End If
        End If
        Return False
    End Function

#Region "Private Sub GridEXCitas_LoadingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEXDocs.LoadingRow"
    Private Sub GridEXDocs_LoadingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEXDocs.LoadingRow
        If e.Row.RowType = RowType.Record Then
            'You can get the values directly from the GridEXRow object
            If e.Row.Table.Key = "CITAs" Then
                Dim cita As CITA = e.Row.DataRow
                Dim importe As Double = 0
                If cita.TOTAL.HasValue Then
                    importe = cita.TOTAL
                Else
                    importe = Globales.CalculaImporteTotalCita(cita)
                End If

                e.Row.Cells("ColumnImporteCitas").Value = importe


                'If PagarDirecto And cita.IDCITA = IdCitaParaPagoDirecto Then
                '    RowToPagarDirecto = e.Row
                'End If
            End If

            If e.Row.Table.Key = "CITAs" Then
                Dim cita As CITA = e.Row.DataRow
                If IdsCitasPreseleccionadas.Contains(cita.IDCITA) Then
                    e.Row.CheckState = RowCheckState.Checked
                End If
            End If

            If e.Row.Table.Key = "FACTURAs" Then
                Dim factura As FACTURA = e.Row.DataRow
                If IdsFacturasPreseleccionadas.Contains(factura.IDFACTURA) Then
                    e.Row.CheckState = RowCheckState.Checked
                End If

                Dim filtrolineasFactura As GridEXFilterCondition = New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("FACTURAS").ChildTables("LINEASFACTURAs").Columns("ColumnPagada"), ConditionOperator.Equal, 0)
                Dim facturas As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.ChildTables("FACTURAS").ChildTables("LINEASFACTURAs").Columns("IMPORTE"), AggregateFunction.Sum, filtrolineasFactura)

                e.Row.Cells("ColumnDebe").Value = facturas
            End If

            If e.Row.Table.Key = "LINEASFACTURAs" Then
                If Not e.Row.DataRow Is Nothing Then
                    If EsLineaFacturaPagada(e.Row) Then
                        e.Row.Cells("ColumnPagada").Value = True
                    Else
                        e.Row.Cells("ColumnPagada").Value = False
                    End If
                End If
            End If




            If e.Row.Table.Key = "RECIBOs" Then
                Dim recibo As RECIBO = e.Row.DataRow
                If IdsRecibosPreseleccionadas.Contains(recibo.NUMERO) Then
                    e.Row.CheckState = RowCheckState.Checked
                End If

            End If
            If e.Row.Table.Key = "N_Tickets" Then
                Dim ticket As N_Ticket = e.Row.DataRow
                If IdsTicketsPreseleccionadas.Contains(ticket.ID_Ticket) Then
                    e.Row.CheckState = RowCheckState.Checked
                End If
            End If
            If e.Row.Table.Key = "FacturasTPVs" Then
                Dim facturaTPV As N_Factura = e.Row.DataRow
                If IdsFacturasPreseleccionadas.Contains(facturaTPV.ID_Factura) Then
                    e.Row.CheckState = RowCheckState.Checked
                End If

            End If
            'If e.Row.Table.Key = "FACTURAs" Then
            'End If
            'If e.Row.Table.Key = "Recibos" Then
            'End If

            'If e.Row.Table.Key = "N_Tickets" Then
            'End If
        End If

    End Sub
#End Region

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CtrlPaciente1_PacienteNoEncontrado() Handles CtrlPaciente1.PacienteNoEncontrado
        CargaDatos()
    End Sub

    Private Sub CtrlPaciente1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal IsReturnPressed As System.Boolean) Handles CtrlPaciente1.PacienteSeleccionado
        CargaDatos()
    End Sub

    Private Sub CtrlPaciente1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteEliminado
        CargaDatos()
    End Sub


    Function AgregaCreditoPaciente(idPaciente As Integer, montoInicial As Double, formaPago As String, notas As String) As PagosPaciente

        Dim frm As New frmAgregarCredito()
        frm.Text = "Introduzca el importe abonado por el paciente"
        frm.txtMontoAbonar.Value = montoInicial
        frm.txtNotas.Text = notas

        If Not formaPago Is Nothing Then
            frm.CtrlFormaPago21.ID_FORMASPAGO = formaPago
        End If

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FormaPagoSeleccionadaAlPagar = frm.CtrlFormaPago21.FORMASPAGO

            Dim pago As New PagosPaciente()
            pago.Fecha = frm.dtp_Fecha.Value
            pago.IDFormaPago = frm.CtrlFormaPago21.ID_FORMASPAGO
            pago.IDPaciente = idPaciente
            pago.Automatico = False

            pago.Importe = Double.Parse(frm.txtMontoAbonar.Value.ToString())
            pago.Notas = frm.txtNotas.Text

            context.PagosPacientes.InsertOnSubmit(pago)
            context.SubmitChanges()
            Return pago
        End If

        Return Nothing
    End Function

    Private Sub btn_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ADD.Click

        'Aqui cargo la ventana de pagar para que el usuario ponga cuanto abono el paciente.
        'Dim context As New CMLinqDataContext()
        If CtrlPaciente1.ID_PACIENTE Is Nothing Then
            MsgBox("Debe indicar un paciente para poder agregar un pago o una entrega a cuenta")
            Return
        End If


        Dim montoInicial As Double = 0

        If Debe - Credito > 0 Then
            montoInicial = Debe - Credito
        End If


        Dim pagop = AgregaCreditoPaciente(CtrlPaciente1.ID_PACIENTE, montoInicial, CtrlPaciente1.Paciente.REFFORMAPAGO, "Crédito agregado")
       
        If Not pagop Is Nothing Then
            CargaDatos()
        End If

        If Selected > Credito Then
            'btnPagar.Enabled = False
            lblMessage.Visible = True
            'Exit For
        Else
            'btnPagar.Enabled = True
            lblMessage.Visible = False
        End If
    End Sub

    Private Sub GridEXDocs_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEXDocs.RowCheckStateChanged
        Calcula()
    End Sub



    Private Sub Calcula()

        Credito = PacienteDebitoManager.DameCreditoPaciente(CtrlPaciente1.ID_PACIENTE, context)

        'Calcular el Debe
        Dim citas As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.ChildTables("CITAS").Columns("ColumnImporteCitas"), AggregateFunction.Sum)

        Dim filtrolineasFactura As GridEXFilterCondition = New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("FACTURAS").ChildTables("LINEASFACTURAs").Columns("ColumnPagada"), ConditionOperator.Equal, 0)
        Dim facturas As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.ChildTables("FACTURAS").ChildTables("LINEASFACTURAs").Columns("IMPORTE"), AggregateFunction.Sum, filtrolineasFactura)

        Dim recibos As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.ChildTables("RECIBOS").Columns("IMPORTE"), AggregateFunction.Sum)
        Dim tickets As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.ChildTables("N_Tickets").Columns("Total"), AggregateFunction.Sum)

        Debe = (citas + facturas + recibos + tickets)
        'Throw New Exception("Excepcion intencional")
        Selected = 0
        For Each row As GridEXRow In GridEXDocs.GetCheckedRows()
            If row.RowType = RowType.Record Then
                If row.Table.Key = "CITAs" Then
                    Dim cita As CITA = row.DataRow
                    If cita.TOTAL Is Nothing Then
                        cita.TOTAL = cita.IMPORTEDR + cita.IMPORTECL - cita.Descuento
                    End If
                    Selected = Selected + cita.TOTAL
                End If

                'If row.Table.Key = "FACTURAs" Then
                '    Dim factura As FACTURA = row.DataRow
                '    If filtrolineasFactura.EvaluateRow(row)
                '    Dim facturas As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.ChildTables("FACTURAS").ChildTables("LINEASFACTURAs").Columns("IMPORTE"), AggregateFunction.Sum, filtrolineasFactura)

                '    Selected = Selected + factura.TOTAL
                'End If
                If row.Table.Key = "LINEASFACTURAs" Then
                    If row.Cells("ColumnPagada").Value = 0 Then
                        Dim lineaFactura As LINEASFACTURA = row.DataRow
                        Selected = Selected + lineaFactura.IMPORTE
                    End If
                End If

                If row.Table.Key = "RECIBOs" Then
                    Dim recibo As RECIBO = row.DataRow
                    Selected = Selected + recibo.IMPORTE
                End If

                If row.Table.Key = "N_Tickets" Then
                    Dim ticket As N_Ticket = row.DataRow
                    Selected = Selected + ticket.Total
                End If
                If Selected > Credito Then
                    'btnPagar.Enabled = False
                    lblMessage.Visible = True
                    'Exit For
                Else
                    'btnPagar.Enabled = True
                    lblMessage.Visible = False
                End If
            End If

        Next

        ''Dim format As New System.Globalization.NumberFormatInfo()
        ''format.CurrencyNegativePattern = 5

        lblSaldo.Text = Credito.ToString("C2")
        lblDebe.Text = Debe.ToString("C2")
        lblSeleccionados.Text = Selected.ToString("C2")

    End Sub

    Private Function BuscaCita(ByVal id As Integer) As CITA
        For Each row As GridEXRow In GridEXDocs.GetCheckedRows()
            If row.Table.Key = "CITAs" Then
                Dim cita As CITA = row.DataRow
                If cita.IDCITA = id Then
                    Return cita
                End If
            End If
        Next
        Return Nothing
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pdm As New PacienteDebitoManager(CtrlPaciente1.Paciente, context, Nothing)

        'cogemos elementos selccionados
        Dim seleccionadas As GridEXRow() = GridEXDocs.GetCheckedRows()
        Dim docsPendientes As New List(Of IDocumentoPagable)
        For Each row As GridEXRow In seleccionadas
            If row.RowType = RowType.Record Then
                Select Case row.Table.Key
                    Case "CITAs", "FACTURAs", "N_Tickets", "N_Facturas"
                        docsPendientes.Add(row.DataRow)
                End Select
            End If
        Next

        If pdm.PagarDocumentos(docsPendientes,
                                New frmPagarDocumentos(Now),
                                Nothing,
                                Globales.Usuario.CODIGO,
                               context) = Windows.Forms.DialogResult.OK Then
            Calcula()
            CargaDatos()
        End If
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        'Dim context As  New CMLinqDataContext()

        If GridEXDocs.GetCheckedRows().Count = 0 Then
            MessageBox.Show("No hay documentos seleccionados")
            Return
        End If

        CitasPagadas.Clear()
        TicketsPagados.Clear()
        FacturaPagadas.Clear()
        RecibosPagados.Clear()
        FacturasTPVPagados.Clear()

        If Selected > Credito Then

            'Annadir credito
            Dim pago As PagosPaciente = AgregaCreditoPaciente(CtrlPaciente1.ID_PACIENTE, Selected - Credito,
                                  CtrlPaciente1.Paciente.REFFORMAPAGO,
                                  "Importe a ser abonado por el paciente para cubrir los documentos seleccionados.")
            If pago Is Nothing Then Return

        End If
        Calcula()




        Dim frm As New frmPagarDocumentos(Now)
        'frm.Paciente = CtrlPaciente1.Paciente


        frm.txtImporte.Value = Selected '- Credito
        'frm.txtMontoAbonar.Value = Selected - Credito
        frm.txtCredito.Value = Credito
        'frm.txtDescripcion.Text = 

        If Selected > Credito Then
            frm.Text = "Credito insuficiente."
            frm.chkUtilizarCredito.Visible = True
            frm.chkUtilizarCredito.Visible = False
            frm.chkUtilizarCredito.Checked = False

        Else
            'frm.txtMontoAbonar.Value = Selected
            frm.chkUtilizarCredito.Visible = True
            frm.chkUtilizarCredito.Checked = True
        End If



        If IdsCitasPreseleccionadas.Count = 1 Then
            Dim cita As CITA = BuscaCita(IdsCitasPreseleccionadas(0))
            If Not cita Is Nothing Then
                MessageBox.Show("No Implementado")
                '    frm.txtDescripcion.Text = "Importe para Liquidar cita fecha " & cita.FECHA.Value.ToShortDateString() & " a las " _
                '                                & cita.HORA.Value.ToShortTimeString() & " del paciente " & cita.PACIENTE
            End If

            If Not FormaPagoPreseleccionada Is Nothing Then
                'frm.FormaPagoPreseleccionada = FormaPagoPreseleccionada
            End If

        End If


        If frm.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return

        FormaPagoSeleccionadaAlPagar = frm.CtrlFormaPago21.FORMASPAGO

        'If Credito + frm.txtMontoAbonar.Value < Selected Then
        '    MessageBox.Show("El importe abonado más el crédito no cubre los documentos seleccionados")
        '    Return
        'End If

        Dim seUsaraCredito As Boolean = False

        If Selected > Credito Then
            'Crear entrada de credito con el monto seleccionado
            'CrearEntradaDeCredito(frm.dtp_Fecha.Value, frm.CtrlFormaPago21.FORMASPAGO.CODIGO, frm.txtMontoAbonar.Value, frm.txtDescripcion.Text & vbCrLf & frm.txtNotas.Text)
        Else
            'Selected <=Credito
            If frm.chkUtilizarCredito.Checked Then
                MessageBox.Show("El pago se deducirá del crédito")
                seUsaraCredito = True
            Else
                'CrearEntradaDeCredito(frm.dtp_Fecha.Value, frm.CtrlFormaPago21.FORMASPAGO.CODIGO, frm.txtMontoAbonar.Value, frm.txtDescripcion.Text & vbCrLf & frm.txtNotas.Text)
            End If
        End If

        Calcula()

        If Not frm.CtrlFormaPago21.FORMASPAGO Is Nothing Then
            CrearPagosParaDocumentos(seUsaraCredito, frm.CtrlFormaPago21.FORMASPAGO.CODIGO)
        Else
            CrearPagosParaDocumentos(seUsaraCredito, Nothing)
        End If

        CargaDatos()
    End Sub

    Private Sub CrearEntradaDeCredito(ByVal fecha As Date, ByVal codFormaPago As String, ByVal importe As Double,
                                      ByVal notas As String)
        Dim pago As New PagosPaciente()
        pago.Fecha = fecha

        FechaPagoDirecto = fecha
        pago.IDFormaPago = codFormaPago
        pago.IDPaciente = CtrlPaciente1.ID_PACIENTE
        'pago.IDUsuario = ""
        pago.Importe = importe
        pago.Notas = notas

        If pago.Importe > Selected Then
            Dim diferencia As Double = (pago.Importe - Selected)
            If MessageBox.Show("El pago es superior al importe en " & diferencia.ToString("C2") & ". ¿Desea añadirlo al crédito del paciente?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                pago.Importe = Selected
            Else

                MessageBox.Show("Agregados " & diferencia.ToString("C2") & " al credito del paciente")
            End If
        End If

        context.PagosPacientes.InsertOnSubmit(pago)
        context.SubmitChanges()
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Debito, "Entregas Cuenta", pago.IDEntrega.ToString(), " Paciente no. " & pago.IDPaciente & " Importe:" & pago.Importe)

    End Sub

    Private Sub CrearPagosParaDocumentos(seUsaraCredito As Boolean, idFormaPago As String)
        For Each row As GridEXRow In GridEXDocs.GetCheckedRows()
            If row.RowType = RowType.Record Then

                Dim entrada As New EntregasCuenta()
                entrada.Fecha = Date.Now
                entrada.Eliminado = False
                entrada.IDPaciente = CtrlPaciente1.ID_PACIENTE
                entrada.IDFormaPago = idFormaPago
                entrada.PagadoConCredito = seUsaraCredito

                If Not Globales.Usuario Is Nothing Then
                    entrada.IDUsuarioEfectua = Globales.Usuario.CODIGO
                End If


                If row.Table.Key = "CITAs" Then
                    Dim cita As CITA = row.DataRow

                    entrada.CodDocumento = cita.IDCITA
                    entrada.Descripcion = "Cita del " & cita.FECHA.Value.ToShortDateString() & " a las " & cita.HORA.Value.ToShortTimeString()

                    If PagarDirecto Then
                        If IdsCitasPreseleccionadas.Contains(cita.IDCITA) Then
                            entrada.Descripcion = "Pago de la cita " & cita.FECHA.Value.ToShortDateString() & " a las " & cita.HORA.Value.ToShortTimeString()
                            entrada.Fecha = FechaPagoDirecto
                        End If
                    End If

                    entrada.Importe = cita.TOTAL
                    entrada.TipoDocumento = 1

                    cita.PagadoConCredito = seUsaraCredito
                    cita.EntregasCuenta = entrada


                    cita.PAGADA = "S"
                    cita.FECHACOBRO = Date.Now

                    context.EntregasCuentas.InsertOnSubmit(entrada)

                    context.SubmitChanges()
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Debito, "Pago Efectuado", entrada.IDEntregaCuenta.ToString(), "A cita del " & cita.FECHA.Value.ToShortDateString() & " a las " & cita.HORA.Value.ToShortTimeString() & " no. " & cita.IDCITA & " Importe:" & entrada.Importe.ToString())

                    CitasPagadas.Add(cita)
                    RaiseEvent CitaPagada(cita.IDCITA)

                    Calcula()

                    If MessageBox.Show("¿Desea imprimir un justificante de Pago para la cita del " & cita.FECHA.Value.ToShortDateString() & "?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Globales.ImprimeJustificante(cita)
                    End If

                End If

                If row.Table.Key = "FACTURAs" Then
                    Dim factura As FACTURA = row.DataRow

                    entrada.CodDocumento = factura.IDFACTURA
                    entrada.Descripcion = "Factura emitida el " & factura.FECHA.Value.ToShortDateString()

                    Dim filtrolineasFactura As GridEXFilterCondition = New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("FACTURAS").ChildTables("LINEASFACTURAs").Columns("ColumnPagada"), ConditionOperator.Equal, 0)
                    Dim Total As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.ChildTables("FACTURAS").ChildTables("LINEASFACTURAs").Columns("IMPORTE"), AggregateFunction.Sum, filtrolineasFactura)

                    entrada.Importe = Selected 'Total
                    entrada.TipoDocumento = 2

                    factura.PagadoConCredito = seUsaraCredito
                    factura.EntregasCuenta = entrada

                    factura.PAGADA = "S"
                    factura.FECHACOBRO = Date.Now
                    context.EntregasCuentas.InsertOnSubmit(entrada)

                    context.SubmitChanges()
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Debito, "Pago Efectuado", entrada.IDEntregaCuenta.ToString(), "A factura " & factura.FECHA.Value.ToShortDateString() & " no. " & factura.IDFACTURA & " Importe:" & entrada.Importe.ToString())

                    'Hay que poner como pagada todas las citas asociadas a esta Factura
                    FacturaPagadas.Add(factura)
                    PagarCitasAsociadasAFactura(factura.IDFACTURA)
                    RaiseEvent FacturaPagada(factura.IDFACTURA)
                    If MessageBox.Show("¿Desea imprimir un justificante de Pago para la factura del " & factura.FECHA.Value.ToShortDateString() & "?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        ImprimeJustificante(factura)
                    End If

                End If

                If row.Table.Key = "RECIBOs" Then
                    Dim recibo As RECIBO = row.DataRow

                    entrada.CodDocumento = recibo.NUMERO

                    If recibo.FECHAEMISION.HasValue Then
                        entrada.Descripcion = "Recibo emitido el " & recibo.FECHAEMISION.Value.ToShortDateString()
                    Else
                        entrada.Descripcion = "Recibo "
                    End If

                    entrada.Importe = recibo.IMPORTE
                    entrada.TipoDocumento = 3

                    recibo.PagadoConCredito = seUsaraCredito
                    recibo.EntregasCuenta = entrada


                    recibo.COBRADO = "S"
                    recibo.FECHACOBRO = Date.Now
                    context.EntregasCuentas.InsertOnSubmit(entrada)

                    context.SubmitChanges()
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Debito, "Pago Efectuado", entrada.IDEntregaCuenta.ToString(), "A recibo no. " & recibo.NUMERO & " Importe:" & entrada.Importe.ToString())

                    RecibosPagados.Add(recibo)
                    RaiseEvent ReciboPagado(recibo.NUMERO)
                End If

                If row.Table.Key = "N_Tickets" Then
                    Dim ticket As N_Ticket = row.DataRow


                    entrada.CodDocumento = ticket.ID_Ticket
                    entrada.Descripcion = "Ticket emitido el " & ticket.Fecha.ToShortDateString()

                    entrada.Importe = ticket.Total
                    entrada.TipoDocumento = 4

                    ticket.PagadoConCredito = seUsaraCredito
                    ticket.EntregasCuenta = entrada

                    ticket.Pagado = True
                    ticket.FechaPagado = Date.Now

                    context.EntregasCuentas.InsertOnSubmit(entrada)

                    context.SubmitChanges()
                    TicketsPagados.Add(ticket)
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Debito, "Pago Efectuado", entrada.IDEntregaCuenta.ToString(), "A ticket no. " & ticket.ID_Ticket & " Importe:" & entrada.Importe.ToString())
                    RaiseEvent TicketPagado(ticket.ID_Ticket)
                End If
                If row.Table.Key = "N_Facturas" Then
                    Dim factura As N_Factura = row.DataRow

                    entrada.CodDocumento = factura.ID_Factura
                    entrada.Descripcion = "Factura TPV emitida el " & factura.Fecha.Value.ToShortDateString()

                    entrada.Importe = factura.Total
                    entrada.TipoDocumento = 5

                    factura.PagadoConCredito = seUsaraCredito
                    factura.EntregasCuenta = entrada

                    factura.Pagado = True
                    factura.FechaPagado = Date.Now

                    context.EntregasCuentas.InsertOnSubmit(entrada)

                    context.SubmitChanges()
                    FacturasTPVPagados.Add(factura)
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Debito, "Pago Efectuado", entrada.IDEntregaCuenta.ToString(), "A factura TPV no. " & factura.ID_Factura & " Importe:" & entrada.Importe.ToString())
                    RaiseEvent FacturasTPVPagado(factura.ID_Factura)
                End If
            End If


        Next
        context.SubmitChanges()
    End Sub

    Private Sub PagarCitasAsociadasAFactura(ByVal idfactura As Integer)
        Dim context As New CMLinqDataContext()
        Dim citas As List(Of CITA) = (From c As CITA In context.CITAs _
                                     Where c.REFFRA = idfactura _
                                     Select c).ToList()

        For Each c As CITA In citas
            c.PAGADA = "S"
            context.SubmitChanges()
            RaiseEvent CitaPagada(c.IDCITA)
        Next

    End Sub

    Private Sub btnPagoAutomatico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagoAutomatico.Click
        MessageBox.Show("No implementado, en espera de aprobacion")
    End Sub


    Private Sub ResumenDePagosYEntregasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDePagosYEntregasToolStripMenuItem.Click

        Dim context As New CMLinqDataContext()

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe escoger un paciente primero")
            CtrlPaciente1.Focus()
            Return
        End If


        Dim rptDS_Paciente As New Microsoft.Reporting.WinForms.ReportDataSource()
        rptDS_Paciente.Name = "centro_medico_PACIENTE"
        rptDS_Paciente.Value = (From p In context.PACIENTEs Where p.CPACIENTE = CtrlPaciente1.ID_PACIENTE Select p).ToList()


        If rptDS_Paciente.Value Is Nothing Then
            MessageBox.Show("Error cargando datos del reporte")
            Return
        End If


        Dim rptDS_EntregasCuentas As New Microsoft.Reporting.WinForms.ReportDataSource()
        rptDS_EntregasCuentas.Name = "centro_medico_EntregasCuentas"

        Dim entregas As List(Of EntregasCuenta) = (From entrega In context.EntregasCuentas Where entrega.IDPaciente = CtrlPaciente1.ID_PACIENTE And (entrega.Eliminado = 0 Or Not entrega.Eliminado.HasValue) Select entrega).ToList()
        ' Dim entregas As List(Of EntregasCuenta) = (From entrega In context.EntregasCuentas Where entrega.IDPaciente = CtrlPaciente1.ID_PACIENTE Select entrega).ToList()

        rptDS_EntregasCuentas.Value = entregas


        Dim rptDS_PagosPacientes As New Microsoft.Reporting.WinForms.ReportDataSource()
        rptDS_PagosPacientes.Name = "centro_medico_PagosPacientes"

        Dim pagos As List(Of WRAPPER_PagosPaciente) = (From p In context.PagosPacientes Where p.IDPaciente = CtrlPaciente1.ID_PACIENTE Select New WRAPPER_PagosPaciente(p)).ToList()

        rptDS_PagosPacientes.Value = pagos


        UI.Reportes.ReportesManager.Imprime("PacienteDebitoResumen.rdlc", {rptDS_Paciente, rptDS_EntregasCuentas, rptDS_PagosPacientes})


    End Sub

    Private Function GetLargeDescription(ByVal entrega As EntregasCuenta)
        Dim context As New CMLinqDataContext()
        Dim descripcion As String = entrega.Descripcion
        Try
            Select Case entrega.TipoDocumento
                Case 1
                    Dim idCita As Integer = Integer.Parse(entrega.CodDocumento)
                    Dim cita As CITA = (From c In context.CITAs Where c.IDCITA = idCita Select c).SingleOrDefault()
                    descripcion = "Cita:"
                    If Not cita.MEDICO Is Nothing Then
                        descripcion += " Doctor " & cita.MEDICO.NOMBRE & " " & cita.MEDICO.APELLIDO1
                        If Not cita.MEDICO.ESPECIALIDAD Is Nothing Then
                            descripcion += ", " & cita.MEDICO.ESPECIALIDAD
                        End If
                    End If
                    'Case 2
                Case 3
                    Dim idRecibo As Integer = Integer.Parse(entrega.CodDocumento)
                    Dim recibo As RECIBO = (From r In context.RECIBOs Where r.NUMERO = idRecibo Select r).SingleOrDefault()
                    descripcion = "Recibo " & recibo.CONCEPTO
                    'Case 4
            End Select
            Return descripcion
        Catch ex As Exception
            Return entrega.Descripcion
        End Try
        context.Dispose()
    End Function

    Private Sub JustificanteDeEntregaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JustificanteDeEntregaToolStripMenuItem.Click

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe escoger un paciente primero")
            CtrlPaciente1.Focus()
            Return
        End If

        Dim frm As New frmListadoEntregas()
        frm.IdPaciente = CtrlPaciente1.ID_PACIENTE
        frm.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmPacienteDebito_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If PagarDirecto Then
            PagaCreditoDirecto()
        End If
    End Sub



    Public Sub ImprimeJustificante(ByRef factura As FACTURA)


        'Datasources
        Dim dsFacturas As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsFacturasLineas As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsPaciente As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsDesglose As New Microsoft.Reporting.WinForms.ReportDataSource

        dsFacturas.Name = "dsFactura"
        dsFacturasLineas.Name = "dsLineas"
        dsPaciente.Name = "dsPacientes"
        dsDesglose.Name = "dsDesglose"

        Dim listFactura As New List(Of WRAPPER_FACTURA)
        listFactura.Add(New WRAPPER_FACTURA(factura))
        Dim listPaciente As New List(Of PACIENTE)
        listPaciente.Add(factura.PACIENTE1)

        dsFacturas.Value = listFactura
        dsFacturasLineas.Value = factura.LINEASFACTURAs
        dsPaciente.Value = listPaciente
        dsDesglose.Value = New List(Of centro_medico.DESGLOSEIVAS)


        'Parametros
        Dim _params_list As List(Of Microsoft.Reporting.WinForms.ReportParameter) = New List(Of ReportParameter)

        Dim _LetraDni As String = centro_medico.Globales.GetLetter(factura.DNI)
        _params_list.Add(New ReportParameter("params_LetraDNI", _LetraDni))



        Dim dsMutuas As New Microsoft.Reporting.WinForms.ReportDataSource
        dsMutuas.Name = "dsMutuas"

        If factura.FACTURAR = "M" Then
            'Agregar la mutua como datasource

            If factura.REFMUTUA.HasValue Then
                Dim idMutua As Integer = factura.REFMUTUA
                Dim mutua As MUTUA = (From m In context.MUTUAs Where m.CMUTUA = idMutua).SingleOrDefault
                Dim listMutua As New List(Of MUTUA)
                listMutua.Add(mutua)
                dsMutuas.Value = listMutua
            Else
                MessageBox.Show("Esta factura es de mutua pero no tiene mutua asignada.")
                Return
            End If
        End If

        Dim plantillaReporte As String = ""

        If factura.FACTURAR = "M" Then
            plantillaReporte = "FacturaMutua.rdlc"
        Else
            plantillaReporte = "Factura.rdlc"
        End If

        UI.Reportes.ReportesManager.Imprime(plantillaReporte, {dsFacturas, dsFacturasLineas, dsPaciente, dsDesglose, dsMutuas}, _params_list.ToArray)

    End Sub

    Private Sub GridEX2_ColumnButtonClick(sender As System.Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX2.ColumnButtonClick

        Dim pago As EntregasCuenta = GridEX2.CurrentRow.DataRow

        If pago.TipoDocumento = 1 Then
            Dim cita As CITA = (From c In context.CITAs Where c.IDCITA = Integer.Parse(pago.CodDocumento) Select c).SingleOrDefault()
            If Not cita Is Nothing Then
                Globales.ImprimeJustificante(cita)
            End If
        End If


        If pago.TipoDocumento = 2 Then
            'Factura
            Dim factura As FACTURA = (From c In context.FACTURAs Where c.IDFACTURA = Integer.Parse(pago.CodDocumento) Select c).SingleOrDefault()
            If Not factura Is Nothing Then
                ImprimeJustificante(factura)
            End If

        End If

    End Sub

    Private Sub eliminaPago(idEntrega As Integer)
        Dim db As New CMLinqDataContext
        Dim pagoAEliminar As PagosPaciente = db.PagosPacientes.Where(Function(o) o.IDEntrega = idEntrega).Single
        Dim res As MsgBoxResult
        res = MsgBox("Se dispone a borrar una entrega realizada por un paciente. Esta acción no podrá deshacerse ¿Seguro que desea continuar?", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.Yes Then
            db.PagosPacientes.DeleteOnSubmit(pagoAEliminar)
            db.SubmitChanges()
            Me.Calcula()
            Me.CargaDatos()
        End If
    End Sub

    Private Sub tsmBorraPago_Click(sender As Object, e As EventArgs) Handles tsmBorraPago.Click

        If GridEX1.SelectedItems.Count = 1 AndAlso GridEX1.SelectedItems.Item(0).RowType = RowType.Record Then
            Dim identrega As Integer = GridEX1.SelectedItems.Item(0).GetRow.Cells("idEntrega").Value
            eliminaPago(identrega)
        End If
    End Sub
End Class
