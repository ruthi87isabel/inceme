Imports centro_medico.UI.Citas
Imports Janus.Windows.GridEX
Imports System.ComponentModel
Imports centro_medico.UI.Reportes

Public Class frmListadoCitas

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion

    Dim filtro As String = ""
    Dim rowSelected As Integer = 0
    Dim context As New CMLinqDataContext()
    Dim citas As List(Of CITA)
    Dim _worker As New BackgroundWorker()

    Dim filtros As FiltroListadoCitas
    Dim cit As Integer = 0

    Private Sub frmListadoCitas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        GC.Collect()
    End Sub


    Private Sub frmListadoCitas_Load(ByVal sender As System.Object, ByVal ex As System.EventArgs) Handles MyBase.Load

        dtp_ff.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 23, 59, 59)
        Dim di As Date = Date.Now.AddMonths(-1)
        dtp_fi.Value = New Date(di.Year, di.Month, di.Day, 0, 0, 0)

        AplicarFormato()


        bt_modificar.Visible = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        bt_Borrar.Visible = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Citas) > RoleManager.TipoPermisos.Lectura
        btnComunicaciones.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Comunicaciones) > RoleManager.TipoPermisos.Lectura


        _worker.WorkerReportsProgress = True
        _worker.WorkerSupportsCancellation = True

        AddHandler _worker.ProgressChanged, Sub(o, e)
                                                'RaiseEvent UpdateCurrentProgress(e.ProgressPercentage)
                                            End Sub

        AddHandler _worker.DoWork, Sub(o, e)
                                       loadCitas()

                                       GridEX1.BeginInvoke(Sub()
                                                               GridEX1.DataSource = citas
                                                               GridEX1.EnsureVisible(0)
                                                               'Filtrar()
                                                           End Sub)

                                   End Sub
        AddHandler _worker.RunWorkerCompleted, Sub(o, e)
                                                   If e.Cancelled = True Then
                                                       '_updateCancelled = True
                                                       Return
                                                   End If

                                                   If e.Error Is Nothing Then
                                                       CargaCitaTerminada()
                                                   End If

                                               End Sub

        CargarCitas()
    End Sub

    Private Sub CargarCitas()
        pnl_Loading.Visible = True
        SetEnabled(False)
        'elimino los filtros que puedan estar establecidos con anterioridad
        GridEX1.RootTable.FilterCondition = Nothing
        cit = LLenaNum()
        filtros = New FiltroListadoCitas With
                  {
                      .FechaEmisionInicial = IIf(dtp_fi.Checked, dtp_fi.Value, Nothing),
                      .FechaEmisionFinal = IIf(dtp_ff.Checked, dtp_ff.Value, Nothing),
                       .IncluirConImporteCero = chb_importe.Checked,
                      .FormaPago = IIf(Not CtrlFormaPago21.ID_FORMASPAGO Is Nothing, CtrlFormaPago21.ID_FORMASPAGO, Nothing),
                      .StatusPago = IIf(rb_cobradas.Checked, StatusPago.Pagado, (IIf(rb_sincobrar.Checked, StatusPago.NoPagado, StatusPago.Todos))),
                      .NOMBREPACIENTE = IIf(txtNombre.Text <> "", txtNombre.Text, Nothing),
                      .APELLIDO1 = IIf(txtApellido1.Text <> "", txtApellido1.Text, Nothing),
                      .APELLIDO2 = IIf(txtApellido2.Text <> "", txtApellido2.Text, Nothing),
                      .NumeroCita = IIf((cit < 4 And cit > 0), cit, Nothing)
                  }

        _worker.RunWorkerAsync()
    End Sub

    Private Function LLenaNum() As Integer
        Dim citas As Integer
        If CBcitas.SelectedItem = "3ra Cita" Then citas = 3
        If CBcitas.SelectedItem = "2da Cita" Then citas = 2
        If CBcitas.SelectedItem = "1ra Cita" Then citas = 1
        Return citas
    End Function

    Private Sub CargaCitaTerminada()
        pnl_Loading.Visible = False
        SetEnabled(True)
        GridEX1.Row = rowSelected
        GridEX1.Refresh()
    End Sub

    Public Sub SetEnabled(ByVal enabled As Boolean)
        For Each control As Control In Me.Controls
            control.Enabled = enabled
        Next
    End Sub


    Private Sub loadCitas()

        context = New CMLinqDataContext()

        Dim tmp As IQueryable(Of CITA) = CitasManager.ListadoCitas(context, filtros)

        If txtDni.Text <> "" Then
            tmp = From c In tmp Where c.PACIENTE1.DNI.StartsWith(txtDni.Text) Select c
        End If

        'If Not chb_importe.Checked Then
        '    tmp = From c In tmp Where c.TOTAL > 0 Select c
        'End If

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            tmp = From c In tmp Where c.REFPACIENTE = CtrlPaciente1.ID_PACIENTE Select c
        End If

        If CtrlMutua1.ID_Mutuas.HasValue Then
            tmp = From c In tmp Where c.REFPROCEDENCIA = CtrlMutua1.ID_Mutuas.Value Select c
        End If

        If CtrlMedico1.ID_Medico.HasValue Then
            tmp = From c In tmp Where c.REFMEDICO = CtrlMedico1.ID_Medico.Value Select c
        End If

        'If rb_cobradas.Checked Then
        '    tmp = From c In tmp Where c.PAGADA = "S" Select c
        'End If

        'If rb_sincobrar.Checked Then
        '    tmp = From c In tmp Where c.PAGADA = "N" And c.FALTA = "N" Select c

        'End If

        If rbFalta.Checked Then
            tmp = From c In tmp Where c.FALTA = "S" Select c
        End If


        If rb_atendidas.Checked Then
            tmp = From c In tmp Where c.ATENDIDO = "S" Select c
        End If

        If rb_noatendidas.Checked Then
            tmp = From c In tmp Where c.ATENDIDO = "N" Select c
        End If

        'Facturacion

        If rb_Facturadas.Checked Then
            tmp = From c In tmp Where c.REFFRA.HasValue And c.REFFRA > 0 Select c
        End If

        If rb_NoFacturadas.Checked Then
            tmp = From c In tmp Where Not c.REFFRA.HasValue Or c.REFFRA = 0 Select c
        End If

        If Not CtrlConceptoFacturable1.ID_ConceptosFra Is Nothing Then
            'Dim condition As New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("RefConcepto"), ConditionOperator.Equal, CtrlConceptoFacturable1.ID_ConceptosFra)
            ' condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("RefConcepto"), ConditionOperator.Equal, CtrlConceptoFacturable1.ID_ConceptosFra))
            tmp = From c In tmp From a In context.LineasCitas Where c.IDCITA = a.IdCita And a.RefConcepto = CtrlConceptoFacturable1.ID_ConceptosFra Select c
        Else
            'If Not GridEX1.RootTable.FilterCondition Is Nothing Then
            '    GridEX1.RootTable.FilterCondition = Nothing
            'End If
        End If

        'If Not CtrlFormaPago21.ID_FORMASPAGO Is Nothing Then
        '    tmp = From c In tmp Where c.REFFORMAPAGO = CtrlFormaPago21.ID_FORMASPAGO Select c
        'End If

        If rb_SoloMutuas.Checked Then
            tmp = From c In tmp Where c.REFPROCEDENCIA.HasValue Select c
        End If

        If rb_SoloPrivados.Checked Then
            tmp = From c In tmp Where Not c.REFPROCEDENCIA.HasValue Select c

        End If

        If cit <> 0 Then
            tmp = From c In tmp Where c.NumeroCita = cit Select c
        End If


        citas = tmp.ToList()
    End Sub

    Public Sub AplicarFormato()

        'Dim importeDr As Double = citas.Sum(Function(c As CITA) _
        '                                         c.IMPORTEDR)
        'Dim importeCL As Double = citas.Sum(Function(c) c.IMPORTEDR)
        'lb_medico.Text = importeDr.ToString("C2")
        'lb_clinica.Text = importeCL.ToString("C2")
        'lb_total.Text = (importeDr + importeCL).ToString("C2")

        Try
            Dim fc As GridEXFormatCondition
            fc = New GridEXFormatCondition( _
                GridEX1.RootTable.Columns("CONFIRMADA"), _
                ConditionOperator.Equal, "S")

            fc.FormatStyle.BackColor = Color.Silver
            GridEX1.RootTable.FormatConditions.Add(fc)

            Dim fc2 As GridEXFormatCondition
            fc2 = New GridEXFormatCondition( _
                GridEX1.RootTable.Columns("ATENDIDO"), _
                ConditionOperator.Equal, "S")
            fc2.FormatStyle.BackColor = Color.FromArgb(70, 200, 200)
            GridEX1.RootTable.FormatConditions.Add(fc2)

            Dim fc3 As GridEXFormatCondition
            fc3 = New GridEXFormatCondition( _
                GridEX1.RootTable.Columns("FALTA"), _
                ConditionOperator.Equal, "S")
            fc3.FormatStyle.BackColor = Color.FromArgb(220, 120, 100)
            GridEX1.RootTable.FormatConditions.Add(fc3)

            Dim fc4 As GridEXFormatCondition
            fc4 = New GridEXFormatCondition( _
                GridEX1.RootTable.Columns("PAGADA"), _
                ConditionOperator.Equal, "S")
            fc4.FormatStyle.BackColor = Color.FromArgb(120, 240, 120)
            GridEX1.RootTable.FormatConditions.Add(fc4)

            Dim fc5 As GridEXFormatCondition
            fc5 = New GridEXFormatCondition( _
                GridEX1.RootTable.Columns("PACIENTE1.BENEFICIARIOCODIGOSOCIO"), _
                ConditionOperator.GreaterThan, 0)
            fc5.FormatStyle.FontBold = TriState.True
            fc5.FormatStyle.ForeColor = Color.Blue
            fc5.TargetColumn = GridEX1.RootTable.Columns("PACIENTE")

            GridEX1.RootTable.FormatConditions.Add(fc5)

            Dim fc6 As GridEXFormatCondition
            fc6 = New GridEXFormatCondition( _
                GridEX1.RootTable.Columns("PACIENTE1.SOCIO"), _
                ConditionOperator.Equal, "S")
            fc6.FormatStyle.FontBold = TriState.True
            fc6.FormatStyle.ForeColor = Color.Purple
            fc6.TargetColumn = GridEX1.RootTable.Columns("PACIENTE")

            GridEX1.RootTable.FormatConditions.Add(fc6)

            Dim fc7 As GridEXFormatCondition
            Dim ccondition As New GridEXFilterCondition
            ccondition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("PAGADA"), ConditionOperator.Equal, "S"))
            ccondition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FALTA"), ConditionOperator.Equal, "S"))

            fc7 = New GridEXFormatCondition(GridEX1.RootTable.Columns("FALTA"), ConditionOperator.Equal, "S")
            fc7.FilterCondition = ccondition
            'fc7.FilterCondition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("PAGADA"), ConditionOperator.Equal, "S"))
            ' fc7.FilterCondition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FALTA"), ConditionOperator.Equal, "S"))
            fc7.FormatStyle.ForeColor = Color.Red
            GridEX1.RootTable.FormatConditions.Add(fc7)



            'Establezco los colores de los labels de la leyenda
            Me.tlsConfirmada.BackColor = Color.Silver
            Me.tlsAtendida.BackColor = Color.FromArgb(70, 200, 200)
            Me.tlsFalta.BackColor = Color.FromArgb(220, 120, 100)
            Me.tlsCobrada.BackColor = Color.FromArgb(120, 240, 120)
            Me.lblPagadaFalta.BackColor = Color.FromArgb(120, 240, 120)
            Me.lblPagadaFalta.ForeColor = Color.Red
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al aplicar formatos")
        End Try
    End Sub




    '#Region "Public Sub Filtrar()"
    '    Public Sub Filtrar()

    '        'Return

    '        If Not Me.IsHandleCreated Then
    '            Return
    '        End If

    '        Dim condition As New GridEXFilterCondition()

    '        'Dim filtros As New List(Of String)

    '        If Not Me.IsHandleCreated Then
    '            Return
    '        End If

    '        If Not chb_importe.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("TOTAL"), ConditionOperator.GreaterThan, 0))
    '        Else
    '            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("TOTAL"), ConditionOperator.GreaterThanOrEqualTo, 0))
    '        End If

    '        'If ID_Proceso <> -1 Then
    '        '    'filtros.Add(" ID_Proceso=" & ID_Proceso)
    '        '    condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ID_Proceso"), ConditionOperator.Equal, ID_Proceso))
    '        'End If

    '        'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ID_Proceso"), ConditionOperator.Equal, ID_Proceso))

    '        If CtrlPaciente1.ID_PACIENTE.HasValue Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPACIENTE"), ConditionOperator.Equal, CtrlPaciente1.ID_PACIENTE))
    '        End If


    '        If CtrlMutua1.ID_Mutuas.HasValue Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPROCEDENCIA"), ConditionOperator.Equal, CtrlMutua1.ID_Mutuas.Value))
    '        End If

    '        If CtrlMedico1.ID_Medico.HasValue Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFMEDICO"), ConditionOperator.Equal, CtrlMedico1.ID_Medico.Value))
    '        End If

    '        If rb_cobradas.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("PAGADA"), ConditionOperator.Equal, "S"))
    '        End If

    '        If rb_sincobrar.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("PAGADA"), ConditionOperator.Equal, "N"))
    '            condition.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEX1.RootTable.Columns("FALTA"), ConditionOperator.Equal, "N"))
    '        End If


    '        If rb_atendidas.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ATENDIDO"), ConditionOperator.Equal, "S"))
    '        End If

    '        If rb_noatendidas.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ATENDIDO"), ConditionOperator.Equal, "N"))
    '        End If

    '        'Facturacion

    '        If rb_Facturadas.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFFRA"), ConditionOperator.GreaterThan, 0))
    '        End If

    '        If rb_NoFacturadas.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFFRA"), ConditionOperator.IsNull, Nothing))
    '            condition.AddCondition(LogicalOperator.Or, New GridEXFilterCondition(GridEX1.RootTable.Columns("REFFRA"), ConditionOperator.Equal, 0))
    '        End If

    '        If rbFalta.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FALTA"), ConditionOperator.Equal, "S"))
    '        End If


    '        If dtp_fi.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FECHA"), ConditionOperator.GreaterThanOrEqualTo, New Date(dtp_fi.Value.Year, dtp_fi.Value.Month, dtp_fi.Value.Day, 0, 0, 0).ToShortDateString()))
    '        End If

    '        If dtp_ff.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FECHA"), ConditionOperator.LessThanOrEqualTo, New Date(dtp_ff.Value.Year, dtp_ff.Value.Month, dtp_ff.Value.Day, 23, 59, 59).ToShortDateString()))
    '        End If

    '        If Not CtrlConceptoFacturable1.ID_ConceptosFra Is Nothing Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("RefConcepto"), ConditionOperator.Equal, CtrlConceptoFacturable1.ID_ConceptosFra))
    '        End If

    '        If Not CtrlFormaPago21.ID_FORMASPAGO Is Nothing Then
    '            condition.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEX1.RootTable.Columns("REFFORMAPAGO"), ConditionOperator.Equal, CtrlFormaPago21.ID_FORMASPAGO))
    '        End If

    '        If rb_SoloMutuas.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPROCEDENCIA"), ConditionOperator.NotIsNull, Nothing))
    '        End If

    '        If rb_SoloPrivados.Checked Then
    '            condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("REFPROCEDENCIA"), ConditionOperator.IsNull, Nothing))
    '        End If



    '        Try
    '            GridEX1.RootTable.FilterCondition = condition
    '            'GridEX1.Update()

    '        Catch ex As Exception
    '            Dim m As String = ex.Message
    '        End Try

    '    End Sub
    '#End Region


    '#Region "Private Sub CalculaTotales()"
    '    Private Sub CalculaTotales(ByVal fil As String)
    '        'Dim total_medicos As Object = CM2DataSet.ListadoCitas.Compute("Sum([Importe médico])", fil)
    '        'Dim total_clinica As Object = CM2DataSet.ListadoCitas.Compute("Sum([Importe clínica])", fil)
    '        'Dim total As Object = CM2DataSet.ListadoCitas.Compute("Sum([Importe Total])", fil)

    '        'If Not total_medicos Is DBNull.Value Then
    '        '    lb_medico.Text = CType(total_medicos, Double).ToString("C2")
    '        'Else
    '        '    lb_medico.Text = "0"
    '        'End If

    '        'If Not total_clinica Is DBNull.Value Then
    '        '    lb_clinica.Text = CType(total_clinica, Double).ToString("C2")
    '        'Else
    '        '    lb_clinica.Text = "0"
    '        'End If

    '        'If Not total Is DBNull.Value Then
    '        '    lb_total.Text = CType(total, Double).ToString("C2")
    '        'Else
    '        '    lb_total.Text = "0"
    '        'End If
    '    End Sub
    '#End Region


    Private Sub bt_Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Filtrar.Click
        CargarCitas()

    End Sub

    'Private Sub chk_FechaInicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_FechaInicio.CheckedChanged
    '    dtp_fi.Enabled = chk_FechaInicio.Checked
    '    Filtrar()
    'End Sub

    'Private Sub chk_Final_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Final.CheckedChanged
    '    dtp_ff.Enabled = chk_Final.Checked
    '    Filtrar()
    'End Sub

    Private Sub bt_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ver.Click
        If Not GridEX1.CurrentRow Is Nothing > 0 Then
            Dim cita As CITA = GridEX1.CurrentRow.DataRow
            Dim _nueva_cita As form_citas = New form_citas("Ficha de citas-ver", Enums.Accion.Ver, cita.IDCITA)
            _nueva_cita.ShowInTaskbar = False
            _nueva_cita.ShowDialog()
        End If
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If Not GridEX1.CurrentRow Is Nothing > 0 Then
            Dim cita As CITA

            rowSelected = GridEX1.Row
            If GridEX1.CurrentRow.Parent Is Nothing Then
                cita = GridEX1.CurrentRow.DataRow
            Else
                cita = GridEX1.CurrentRow.Parent.DataRow
            End If

            ''Dim Id As Integer = ListadoCitasDataGridView.SelectedRows(0).DataBoundItem.Row.IDCITA
            'Dim _nueva_cita As form_citas_sub = New form_citas_sub("Ficha de citas-Editar", Enums.Accion.Modificar, cita.IDCITA)
            '_nueva_cita.ShowInTaskbar = False
            '_nueva_cita.ShowDialog()
            ''Me.ListadoCitasTableAdapter.Fill(Me.CM2DataSet.ListadoCitas)
            ''CalculaTotales(Nothing)
            'loadCitas()

            If Not Globales.VerificaSiCitaEstaEnUsoYSePuedeProceder(cita.IDCITA) Then Return

            If Not cita Is Nothing Then
                Dim _nueva_cita As form_citas = New form_citas("Ficha de citas-Editar", Enums.Accion.Modificar, cita.IDCITA)
                _nueva_cita.ShowInTaskbar = False

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Citas, "Citas", cita.IDCITA.ToString(), cita.PACIENTE)

                _nueva_cita.ShowDialog()

                Globales.CambiaEstadoRecurrencia(cita.IDCITA, Globales.EstadoRecurrencia.Libre)

                CargarCitas()
            End If

        End If
    End Sub


#Region "Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click"
    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click

        Dim tipofiltro As String = ""
        Dim ii As Integer = 0
        Dim listacampos As String = ""

        Dim parametros(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource()
        'Preparo el filtro para mostrarlo en el report
        If Not Me.CtrlFormaPago21.ID_FORMASPAGO Is Nothing Then tipofiltro += " F. pago = " & Me.CtrlFormaPago21.NombreCompleto
        If CtrlMedico1.ID_Medico.HasValue Then tipofiltro += " Médico = " & Me.CtrlMedico1.Medico.NOMBRECOMPLETO
        If CtrlPaciente1.ID_PACIENTE.HasValue Then tipofiltro += " Paciente = " & CtrlPaciente1.NombreCompleto

        If Me.rb_cobradas.Checked = True Then tipofiltro += " Cobradas = S "
        'If Me.rb_continua.Checked = True Then tipofiltro += " Citas Continuas = S "
        'If Me.rb_normal.Checked = True Then tipofiltro += " Citas Continuas = N "
        If Me.rb_sincobrar.Checked = True Then tipofiltro += " Cobradas = N "
        'If Me.rb_todas.Checked = True Then tipofiltro += " Todas (normal y continuas) "
        If Me.rb_todascobrar.Checked = True Then tipofiltro += " Cobradas y Sin cobrar "
        If Me.chb_importe.Checked = True Then tipofiltro += " Citas de importe 0 "

        ds.Name = "centro_medico_CITA"

        Dim lista As List(Of Object) = (From row In GridEX1.GetDataRows Where row.IsVisible Select c = row.DataRow Select wrapper = New WRAPPER_CITA(DirectCast(c, CITA))).Cast(Of Object)().ToList()

        ds.Value = lista

        parametros(0) = New Microsoft.Reporting.WinForms.ReportParameter("Filtro", "Filtro aplicado: " & tipofiltro)

        UI.Reportes.ReportesManager.Imprime("CitasListadoConImportes.rdlc", {ds}, parametros)


    End Sub
#End Region


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Borrar.Click
        If GridEX1.GetCheckedRows().Count = 0 Then
            MessageBox.Show("¡¡No hay citas seleccionadas!!")
            Return
        Else
            If MessageBox.Show("¿Desea eliminar las citas seleccionadas ?", "Confirmacion", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                For Each row As GridEXRow In GridEX1.GetCheckedRows()
                    If row.Parent Is Nothing Then
                        Dim cita As CITA = row.DataRow
                        Globales.EliminarCitaCorrectamente(cita, True)
                    End If
                Next

                'context.SubmitChanges()
                CargarCitas()
            End If
        End If
    End Sub

    'Private Sub ListadoCitasDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

    '    Dim cita As CM2DataSet.ListadoCitasRow = ListadoCitasDataGridView.Rows(e.RowIndex).DataBoundItem.Row
    '    Globals.ColoreaCitas(cita.CONFIRMADA, cita.ATENDIDO, cita.FALTA, cita.PAGADA, e.CellStyle.BackColor, e.CellStyle.ForeColor)

    'End Sub

    Private Sub frmListadoCitas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Globales.TeclasBasicas.Editar
                bt_modificar_Click(Nothing, Nothing)
            Case Globales.TeclasBasicas.Borrar
                Button1_Click(Nothing, Nothing)
            Case Globales.TeclasBasicas.Filtrar
                bt_Filtrar_Click(Nothing, Nothing)
            Case Keys.Alt Or Keys.I
                bt_imprimir_Click(Nothing, Nothing)
            Case Keys.Alt Or Keys.C
                bt_cerrar_Click(Nothing, Nothing)
            Case Keys.Alt Or Keys.V
                bt_ver_Click(Nothing, Nothing)

        End Select
    End Sub

    Private Sub bt_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Private Sub CtrlPaciente1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal IsReturnPressed As System.Boolean) Handles CtrlPaciente1.PacienteSeleccionado
    '    Filtrar()
    'End Sub

    'Private Sub CtrlPaciente1_PacienteNoEncontrado() Handles CtrlPaciente1.PacienteNoEncontrado
    '    Filtrar()
    'End Sub

    'Private Sub CtrlPaciente1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteEliminado
    '    Filtrar()
    'End Sub


    Private Sub btnAnnadirCita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnadirCita.Click
        'Dim _nueva_cita As form_citas_sub = New form_citas_sub("Ficha de citas-Editar", Enums.Accion.Insertar, Date.Now)
        '_nueva_cita.ShowInTaskbar = False
        '_nueva_cita.ShowDialog()
        Dim calendar As New frmCalendarioCitas()
        calendar.ShowDialog()
        CargarCitas()
    End Sub


    Private Sub GridEX1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridEX1.MouseDoubleClick
        rowSelected = GridEX1.Row
        If GridEX1.HitTest(e.X, e.Y) = GridArea.Cell Then
            bt_modificar_Click(Nothing, Nothing)
        End If

    End Sub


    Private Sub GridEX1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.CurrentCellChanged
        Try
            bt_modificar.Enabled = Not GridEX1.CurrentRow Is Nothing
            bt_ver.Enabled = Not GridEX1.CurrentRow Is Nothing
            bt_Borrar.Enabled = Not GridEX1.CurrentRow Is Nothing
            btn_FacturarSeleccionadas.Enabled = Not GridEX1.CurrentRow Is Nothing
        Catch ex As InvalidOperationException
        End Try
    End Sub





    Private Sub btn_FacturarSeleccionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FacturarSeleccionadas.Click

        If GridEX1.GetCheckedRows().Count = 0 Then
            MessageBox.Show("Debe seleccionar una cita")
            Return
        End If


        If GridEX1.GetCheckedRows(0).Parent Is Nothing Then
            Dim cita As CITA = GridEX1.GetCheckedRows(0).DataRow
            'Facturar la seleccionada
            If cita.REFFRA Is Nothing Then

                If cita.LineasCitas.Count = 0 Then
                    MessageBox.Show("No hay lineas que facturar")
                    Return
                End If

                MessageBox.Show("Se procedera a facturar solo la primera de las citas seleccionadas")

                'Dim context As New CMLinqDataContext()

                'Generar una nueva factura y asignarle las lineas
                Dim factura As New FACTURA()

                'Esta linea es obligatoria pues la tabla Facturas.Mutua no permite nulls
                factura.MUTUA = "N"


                If Not cita.REFPROCEDENCIA Is Nothing Then
                    factura.REFMUTUA = cita.REFPROCEDENCIA
                    factura.MUTUA = cita.MUTUA.NOMBRE
                    factura.FACTURAR = "M"
                Else
                    factura.FACTURAR = "P"
                End If


                If Not cita.REFPACIENTE Is Nothing Then
                    factura.REFPACIENTE = cita.REFPACIENTE
                    factura.PACIENTE = cita.PACIENTE
                    If Not cita.REFFORMAPAGO Is Nothing Then
                        factura.REFFORMAPAGO = cita.REFFORMAPAGO
                    End If
                End If

                factura.FECHA = Date.Now
                factura.FEMISION = Date.Now

                factura.IDFACTURA = Globales.ObtenerMaximoValor("FACTURAS", "IDFACTURA") + 1
                factura.REFCITA = cita.IDCITA
                factura.REFSERIE = Globales.Configuracion.serie


                Dim total As Double = 0
                For Each row As GridEXRow In GridEX1.CurrentRow.GetChildRows

                    Dim lineaCita As LineasCita = row.DataRow
                    Dim lineaFactura As New LINEASFACTURA()
                    lineaFactura.REFFACTURA = factura.IDFACTURA
                    lineaFactura.TIPOIVA = 0

                    lineaFactura.CONCEPTO = lineaCita.DESCRIPCION
                    If Not lineaCita.RefConcepto Is Nothing Then
                        If lineaCita.RefConcepto.Trim() <> "" Then
                            lineaFactura.REFCONCEPTO = lineaCita.RefConcepto
                        End If

                    End If

                    lineaFactura.ImporteOriginal = lineaCita.ImporteClinica + lineaCita.ImporteDr
                    lineaFactura.IMPORTE = lineaCita.ImporteClinica + lineaCita.ImporteDr

                    lineaFactura.ID_Cita = lineaCita.IdCita
                    lineaFactura.CANTIDAD = lineaCita.Cantidad
                    'context.LINEASFACTURAs.InsertOnSubmit(lineaFactura)
                    total = total + lineaFactura.IMPORTE
                    lineaFactura.Descuento = lineaCita.DescuentoPercent / 100 * ((lineaCita.ImporteClinica + lineaCita.ImporteDr) * lineaCita.Cantidad)
                    factura.LINEASFACTURAs.Add(lineaFactura)
                Next

                factura.TOTAL = total
                factura.NUMEROFACTURA = factura.IDFACTURA
                factura.PAGADA = "N"

                factura.RECIBO = ""
                factura.PORCENTAJEIRPF = 0

                'If Not EMPRESA Is Nothing Then
                '    factura.REFEMPRESA = EMPRESA.CEMPRESA
                '    factura.EMPRESA = EMPRESA.NOMBRE
                'Else
                factura.EMPRESA = ""
                'End If

                'If rbCitas_Paciente.Checked Then
                '    factura.FACTURAR = "P"
                'Else
                '    factura.FACTURAR = "M"
                'End If

                factura.IRPF = 0

                If Not cita.PACIENTE1 Is Nothing Then
                    If Not cita.PACIENTE1.DNI Is Nothing Then
                        factura.DNI = cita.PACIENTE1.DNI
                    End If

                End If

                Try

                    Dim frm As New frmFacturasM_ADD()
                    frm.Factura = factura
                    'frm.Nuevo = True
                    frm.Context = context
                    frm.CtrlPaciente1.ID_PACIENTE = factura.REFPACIENTE
                    frm.CargaDatosPaciente()

                    If frm.ShowDialog() = DialogResult.OK Then
                        context.FACTURAs.InsertOnSubmit(factura)
                        context.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict)
                        'Marcar citas como facturadas
                        cita.REFFRA = factura.IDFACTURA
                        'CambiarCitaAFacturada(factura.IDFACTURA)
                        context.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict)
                        CargarCitas()
                    End If
                Catch ex As Exception

                End Try


            Else
                MessageBox.Show("Cita ya facturada!!")
                Return
            End If

        End If

    End Sub


    Private Sub GridEX1_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEX1.RowCheckStateChanged
        btn_FacturarSeleccionadas.Enabled = (GridEX1.GetCheckedRows().Count > 0)
    End Sub

    Private Sub btnComunicaciones_Click(sender As System.Object, e As System.EventArgs) Handles btnComunicaciones.Click
        Dim lista As New List(Of CITA)

        For Each row As GridEXRow In GridEX1.GetCheckedRows
            If row.IsVisible Then
                Dim c As CITA = row.DataRow
                'dim myEvent = new Event("Test Name", "Test Location", new List<Person>())
                lista.Add(c)
            End If
        Next

        Dim frm As New frmComunicaciones_EnviarRecordatoriosCita()
        frm.Citas = lista
        frm.dtp_fi.Value = dtp_fi.Value
        frm.dtp_ff.Value = dtp_ff.Value

        frm.ShowDialog()

    End Sub



    'Private Sub GridEX1_SelectionChanged(sender As Object, e As EventArgs) Handles GridEX1.SelectionChanged
    '    btnImprimirJustificante.Enabled = GridEX1.SelectedItems.Count > 0

    'End Sub

    Private Sub btnImprimirJustificante_Click(sender As Object, e As EventArgs) Handles btnImprimirJustificante.Click
        If GridEX1.SelectedItems.Count > 0 Then
            Dim cita As CITA = GridEX1.SelectedItems(0).GetRow().DataRow
            Globales.ImprimeJustificante(cita)
        End If
    End Sub


    Private Sub GridEX1_LoadingRow(sender As Object, e As RowLoadEventArgs) Handles GridEX1.LoadingRow
        Dim a As GridEXRow = sender.currentrow
        Dim i As Integer = 0
        If Not a Is Nothing AndAlso a.RowType = RowType.Record Then

            If chkFalta0.Checked Then
                a.DataRow.importecl = 0D
                a.DataRow.importedr = 0D
                a.DataRow.total = 0D
            End If


        End If

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Me.GridEX1.Refresh()
    End Sub
End Class