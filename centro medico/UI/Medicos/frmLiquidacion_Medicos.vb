Imports centro_medico
Imports Janus.Windows.GridEX
Imports System.Data.Linq
Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Reportes

Public Class frmLiquidacion_Medicos
    Dim context As New CMLinqDataContext()
    Dim Credito As Double = 0
    Dim Debe As Double = 0
    Dim Selected As Double = 0
    Dim formSize As Integer = 0

    Public CitasPagadas As New List(Of CITA)


    Public PagarDirecto As Boolean = False
    Public IdsCitasPreseleccionadas As List(Of Integer) = New List(Of Integer)


    'Private RowToPagarDirecto As GridEXRow
    'Private FechaPagoDirecto As Date = Date.Now

    Private threadStart As New Threading.ThreadStart(AddressOf CargaDatosAsync)
    Private thread As Threading.Thread
    Private Delegate Sub InvokeDelegate()
    Private Delegate Sub InvokeDelegateEnabled(ByVal enabled As Boolean)

    Dim citas As List(Of CITA)
    Dim liquidaciones As List(Of Liquidacion_Medico)


    Public Event CitaPagada(ByVal id As Integer)


    Public Sub PagaCreditoDirecto()


        Calcula()
        btnPagar_Click(Nothing, Nothing)

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        If CitasPagadas.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If


        Me.Close()

    End Sub

    Private Sub frmLiquidacion_Medicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CtrlMedico1.ID_Medico = 888
        formSize = Me.Size.Width
        If CtrlMedico1.ID_Medico.HasValue Then
            CargaDatos()
        Else
            dtp_Inicio.Value = New Date(Date.Now.Year, Date.Now.Month, 1)
        End If

        'PagaCreditoDirecto()
    End Sub

    Private Sub CargaDatos()
        SetEnabled(False)
        pnl_Loading.Enabled = True
        pnl_Loading.Visible = True

        thread = New Threading.Thread(threadStart)
        thread.Start()
    End Sub

#Region "Private Sub CargaDatosAsync()"
    Private Sub CargaDatosAsync()



        'GridEXDocs.BeginInvoke(New InvokeDelegateEnabled(AddressOf SetEnabled), False)

        Dim fi As Date = New Date(dtp_Inicio.Value.Year, dtp_Inicio.Value.Month, dtp_Inicio.Value.Day, 0, 0, 0, 0)
        Dim ff As Date = New Date(dtp_Final.Value.Year, dtp_Final.Value.Month, dtp_Final.Value.Day, 23, 59, 59, 0)


        If CtrlMedico1.ID_Medico.HasValue Then
            'MEDICOBindingSource.Clear()

            Dim idMedico As Integer = CtrlMedico1.ID_Medico
            context = New CMLinqDataContext()


            Dim medico As MEDICO = (From p In context.MEDICOs Where p.CMEDICO = idMedico).SingleOrDefault()

            citas = Nothing
            liquidaciones = Nothing

            If rb_todascobrar.Checked Then
                citas = medico.CITAs.Where(Function(c) _
              c.FECHA >= fi And c.FECHA <= ff _
              And (c.Eliminado = False Or c.Eliminado Is Nothing) _
              And c.CONFIRMADA = "S" And c.ATENDIDO = "S" _
              ).ToList()
            End If

            If rb_cobradas.Checked Then
                citas = medico.CITAs.Where(Function(c) _
                c.FECHA >= fi And c.FECHA <= ff _
                And (c.Eliminado = False Or c.Eliminado Is Nothing) _
                And c.CONFIRMADA = "S" And c.ATENDIDO = "S" _
                And c.PAGADA = "S").ToList()
            End If

            If rb_sincobrar.Checked Then
                citas = medico.CITAs.Where(Function(c) _
                c.FECHA >= fi And c.FECHA <= ff _
                And (c.Eliminado = False Or c.Eliminado Is Nothing) _
                And c.CONFIRMADA = "S" And c.ATENDIDO = "S" _
                And c.PAGADA = "N"
                ).ToList()
            End If

            If Not chkMostrarCitasImporteCero.Checked Then
                citas = citas.Where(Function(c) c.DrImporteConDtoSum > 0).ToList()
            End If

            liquidaciones = medico.Liquidacion_Medicos.ToList()

            CITAsBindingSource.DataSource = citas
            LiquidacionMedicosBindingSource.DataSource = liquidaciones
        Else
            MEDICOBindingSource.DataSource = Nothing
            CITAsBindingSource.DataSource = Nothing
            LiquidacionMedicosBindingSource.DataSource = Nothing
        End If
        If Me.IsHandleCreated Then
            Me.BeginInvoke(New InvokeDelegate(AddressOf ShowData))
        End If
    End Sub
#End Region

    Private Sub ShowData()
        Filtrar()
        GridEXDocs.ExpandRecords()
        SetEnabled(True)
        btImprimirMedicoDebito.Enabled = Not citas.Count = 0
        pnl_Loading.Visible = False
    End Sub

    Public Sub SetEnabled(ByVal enabled As Boolean)

        For Each control As Control In Me.Controls
            control.Enabled = enabled
        Next

    End Sub

#Region "Private Sub Filtrar()"
    Private Sub Filtrar()


        'Filtrar citas

        'If Not chkMostrarCitasImporteCero.Checked Then
        '    Dim conditionCitas As GridEXFilterCondition = New GridEXFilterCondition(GridEXDocs.RootTable.Columns("IMPORTEDR"), ConditionOperator.GreaterThan, 0)

        '    GridEXDocs.RootTable.FilterCondition = Nothing
        '    GridEXDocs.RootTable.FilterCondition = conditionCitas

        '    'GridEXDocs.Refresh()

        'End If

        Calcula()

    End Sub
#End Region

    '#Region "Private Sub GridEXCitas_LoadingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEXDocs.LoadingRow"
    '    Private Sub GridEXDocs_LoadingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEXDocs.LoadingRow
    '        If e.Row.RowType = RowType.Record Then
    '            'You can get the values directly from the GridEXRow object
    '            If e.Row.Table.Key = "CITA" Then
    '                Dim cita As CITA = e.Row.DataRow
    '                Dim importe As Double = 0
    '                If cita.TOTAL.HasValue Then
    '                    importe = cita.TOTAL
    '                Else
    '                    importe = Globales.CalculaImporteTotalCita(cita)
    '                End If

    '                e.Row.Cells("ImporteDr").Text = importe.ToString("c2")


    '                'If PagarDirecto And cita.IDCITA = IdCitaParaPagoDirecto Then
    '                '    RowToPagarDirecto = e.Row
    '                'End If
    '            End If

    '            If e.Row.Table.Key = "CITA" Then
    '                Dim cita As CITA = e.Row.DataRow
    '                If IdsCitasPreseleccionadas.Contains(cita.IDCITA) Then
    '                    e.Row.CheckState = RowCheckState.Checked
    '                End If
    '            End If


    '            'If e.Row.Table.Key = "FACTURAs" Then
    '            'End If
    '            'If e.Row.Table.Key = "Recibos" Then
    '            'End If

    '            'If e.Row.Table.Key = "N_Tickets" Then
    '            'End If
    '        End If

    '    End Sub
    '#End Region

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CtrlMedico1_PacienteNoEncontrado() Handles CtrlMedico1.MedicoNoEncontrado
        'CargaDatos()
    End Sub

    Private Sub CtrlMedico1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal oldMedico As Nullable(Of Integer), ByVal isReturnPressed As Boolean) Handles CtrlMedico1.MEDICOSeleccionado
        'CargaDatos()
    End Sub

    Private Sub CtrlMedico1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlMedico1.MEDICOEliminado
        'CargaDatos()
    End Sub

    Private Sub GridEXDocs_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEXDocs.RowCheckStateChanged, GridEXDocs.RowCheckStateChanged
        Calcula()
    End Sub


    Private Sub Calcula()

        Credito = 0
        'DamePagosPaciente(-DameImporteEntregas())

        'Calcular el Debe
        Dim citas As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.Columns("IMPORTEDR"), AggregateFunction.Sum)


        'Dim filtrolineasFactura As GridEXFilterCondition = New GridEXFilterCondition(GridEXDocs.RootTable.ChildTables("FACTURAS").ChildTables("LINEASFACTURAs").Columns("ColumnPagada"), ConditionOperator.Equal, 0)
        'Dim facturas As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.ChildTables("FACTURAS").ChildTables("LINEASFACTURAs").Columns("IMPORTE"), AggregateFunction.Sum, filtrolineasFactura)

        'Dim recibos As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.ChildTables("RECIBOS").Columns("IMPORTE"), AggregateFunction.Sum)
        'Dim tickets As Double = GridEXDocs.GetTotal(GridEXDocs.RootTable.ChildTables("N_Tickets").Columns("Total"), AggregateFunction.Sum)

        Debe = (citas)

        Selected = 0
        For Each row As GridEXRow In GridEXDocs.GetCheckedRows()
            If row.RowType = RowType.Record Then
                If row.Table.Key = "LineasCitas" Then
                    Dim linea As LineasCita = row.DataRow
                    Selected = Selected + linea.DrImporteConDto
                End If
            End If

        Next

        'lblSaldo.Text = Credito.ToString("C2")
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

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        'Dim context As New CMLinqDataContext()

        If GridEXDocs.GetCheckedRows().Count = 0 Then
            MessageBox.Show("No hay documentos seleccionados")
            Return
        End If

        CitasPagadas.Clear()

        If Selected >= Credito Then

            Dim frm As New frmPagarCantidad()
            frm.Text = "Liquidación."
            frm.txtImporteOriginal.Value = Selected '- Credito
            frm.txtMontoAbonar.Value = Selected - Credito
            frm.txtMontoAbonar.Enabled = False
            frm.txtMontoAbonar.ReadOnly = True
            frm.CtrlFormaPago21.Visible = True
            frm.txtCredito.Visible = False
            frm.Text = "Importe a ser abonado al médico para cubrir los documentos seleccionados."
            frm.grpAbonar.Enabled = True

            If IdsCitasPreseleccionadas.Count = 1 Then
                Dim cita As CITA = BuscaCita(IdsCitasPreseleccionadas(0))
                frm.txtNotas.Text = "Importe para Liquidar cita fecha " & cita.FECHA.Value.ToShortDateString() & " a las " _
                                                & cita.HORA.Value.ToShortTimeString() & " del paciente " & cita.PACIENTE

            End If


            'Descripcion de todas las citas liquidadas
            Dim descripcionLiquidacion As String = String.Empty

            For Each row As GridEXRow In GridEXDocs.GetCheckedRows()
                If row.RowType = RowType.Record Then
                    If row.Table.Key = "CITA" Then
                        Dim cita As CITA = row.DataRow
                        If Not cita Is Nothing And cita.FECHA.HasValue And cita.HORA.HasValue Then
                            descripcionLiquidacion += String.Format("Cita {0} - {1} Paciente [{2}] {3}", _
                                                                cita.FECHA.Value.ToShortDateString(), _
                                                                cita.HORA.Value.ToShortTimeString(), _
                                                                cita.REFPACIENTE, _
                                                                cita.PACIENTE) & vbCrLf
                        End If

                    End If
                End If
            Next
            frm.txtDescripcion.Text = descripcionLiquidacion

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                If (frm.txtMontoAbonar.Value + Credito) < frm.txtImporteOriginal.Value Then
                    MessageBox.Show("El importe abonado no cubre los documentos seleccionados, se abortará la operación")
                    Return
                End If

                Dim liquidacion As New Liquidacion_Medico()

                'liquidacion.Descripcion = 
                Dim _fecha As New Date(frm.dtp_Fecha.Value.Year, frm.dtp_Fecha.Value.Month, frm.dtp_Fecha.Value.Day, frm.dtp_hora.Value.Hour, frm.dtp_hora.Value.Minute, frm.dtp_hora.Value.Second)
                liquidacion.Fecha = _fecha
                Try
                    liquidacion.ID_FormaPago = frm.CtrlFormaPago21.ID_FORMASPAGO

                Catch ex As Exception

                End Try

                liquidacion.ID_Medico = CtrlMedico1.ID_Medico
                liquidacion.ID_Usuario = Globales.Usuario.CODIGO
                liquidacion.Descripcion = frm.txtDescripcion.Text & vbCrLf & frm.txtNotas.Text
                liquidacion.Importe = CType(frm.txtMontoAbonar.Value, Double)


                For Each row As GridEXRow In GridEXDocs.GetCheckedRows()
                    If row.RowType = RowType.Record Then
                        If row.Table.Key = "LineasCitas" Then
                            Dim linea As LineasCita = row.DataRow
                            Dim lineaLiquidacion As New Liquidacion_Medico_Linea()


                            If Not linea.RefConcepto Is Nothing Then
                                lineaLiquidacion.Descripcion = "(" + linea.RefConcepto + ") " + linea.DESCRIPCION

                            Else
                                lineaLiquidacion.Descripcion = linea.DESCRIPCION
                            End If

                            lineaLiquidacion.Fecha = linea.CITA.FECHA
                            lineaLiquidacion.ID_LineaCita = linea.IdLinea
                            lineaLiquidacion.ID_Usuario = Globales.Usuario.CODIGO
                            lineaLiquidacion.Importe = linea.DrImporteConDto


                            liquidacion.Liquidacion_Medico_Lineas.Add(lineaLiquidacion)
                            linea.Liquidada_al_Medico = True

                        End If
                    End If
                Next


                context.Liquidacion_Medicos.InsertOnSubmit(liquidacion)
                context.SubmitChanges()
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.LiquidacionMedico, "Liquidación de Médico ", _
                                                liquidacion.ID_Liquidacion.ToString(), " Medico . " & CtrlMedico1.Medico.NOMBRECOMPLETO & " Importe:" & liquidacion.Importe)
                Calcula()
                If MessageBox.Show("¿Desea imprimir un justificante de Pago para la liquidación del " & liquidacion.Fecha.Value.ToShortDateString() & "?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    ImprimeJustificante(liquidacion)
                End If

            Else
                Return
            End If
        End If


        context.SubmitChanges()
        CargaDatos()
    End Sub

    Private Sub btnPagoAutomatico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagoAutomatico.Click
        MessageBox.Show("No implementado, en espera de aprobacion")
    End Sub



    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        ' Me.CierraCorrectamente()
        Me.Close()
    End Sub

    Private Sub frmPacienteDebito_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If PagarDirecto Then
            PagaCreditoDirecto()
        End If
    End Sub

    Public Sub ImprimeJustificante(ByRef liquidacion As Liquidacion_Medico)

        'Datasources
        Dim dsCitaDatos As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsCitaLineas As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsMedico As New Microsoft.Reporting.WinForms.ReportDataSource

        dsCitaDatos.Name = "dsLiquidacion_Medico"
        dsCitaLineas.Name = "dsLiquidacion_Medico_Lineas"
        dsMedico.Name = "dsMedico"

        Dim listCitaDatos As New List(Of Liquidacion_Medico)
        listCitaDatos.Add(liquidacion)
        dsCitaDatos.Value = listCitaDatos

        dsCitaLineas.Value = liquidacion.Liquidacion_Medico_Lineas

        Dim listaMedicos As New List(Of MEDICO)
        listaMedicos.Add(liquidacion.MEDICO)
        dsMedico.Value = listaMedicos

        UI.Reportes.ReportesManager.Imprime("MedicoJustificantePago.rdlc", {dsCitaDatos, dsCitaLineas, dsMedico})

    End Sub

    Private Sub GridEX2_ColumnButtonClick(sender As System.Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick

        Dim liquidacion As Liquidacion_Medico = GridEX1.CurrentRow.DataRow

        'Cita
        Try
            ImprimeJustificante(liquidacion)

        Catch ex As Exception

        End Try

    End Sub


    Private Sub btImprimirMedicoDebito_Click(sender As System.Object, e As System.EventArgs) Handles btImprimirMedicoDebito.Click

        Dim lineas As New List(Of WRAPPER_LineasCita)

        For Each row As GridEXRow In GridEXDocs.GetRows()
            'If row.Table.Key = "PACIENTE" Then
            ' For Each child As GridEXRow In row.GetChildRows
            If row.Table.Key = "CITA" Then
                Dim cita As CITA = row.DataRow
                For Each child As GridEXRow In row.GetChildRows
                    If child.RowType = RowType.Record Then
                        If child.Table.Key = "LineasCitas" Then
                            Dim linea As LineasCita = child.DataRow
                            lineas.Add(New WRAPPER_LineasCita(linea, cita))
                        End If
                    End If
                Next

            End If
            'Next
            'End If
        Next


        'Datasources
        Dim dsWRAPPER_LineasCita As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsMedico As New Microsoft.Reporting.WinForms.ReportDataSource

        dsWRAPPER_LineasCita.Name = "dsWRAPPER_LineasCita"
        dsMedico.Name = "dsMedico"

        dsWRAPPER_LineasCita.Value = lineas

        Dim listaMedicos As New List(Of MEDICO)
        listaMedicos.Add(CtrlMedico1.Medico)
        dsMedico.Value = listaMedicos

        UI.Reportes.ReportesManager.Imprime("MedicoReporteDebito.rdlc", {dsWRAPPER_LineasCita, dsMedico})

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargaDatos()
    End Sub

    Private Sub frmLiquidacion_Medicos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not formSize = 0 Then
            Dim Gi As Integer = GridEXDocs.Width
            Dim Gd As Integer = GridEX1.Width
            Gi = (61 * Me.Size.Width) / 100
            Gd = (36 * Me.Size.Width) / 100
            GridEX1.Location = New System.Drawing.Point((Me.Size.Width - (Gd + 22)), 167)
            GridEXDocs.Width = Gi
            GridEX1.Width = Gd
        End If
    End Sub

End Class

Partial Public Class Liquidacion_Medico
    Public Property NOMBREMEDICO
        Get
            Return Me.MEDICO.NOMBRECOMPLETO
        End Get
        Set(value)

        End Set
    End Property


End Class
