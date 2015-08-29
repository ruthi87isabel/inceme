Imports Janus.Windows.GridEX

Public Class frmDental_ListadoPresupuestos
    Dim context As CMLinqDataContext
    Dim presupuestos As IQueryable(Of d_Presupuesto)
    Public SelectedLineas As List(Of d_PresupuestoLinea)

    Private Sub frmDental_ListadoPresupuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Permisos de acceso
        Dim apermiso As Integer = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Dental)
        NewToolStripButton.Visible = apermiso > RoleManager.TipoPermisos.Modificar
        tst_Eliminar.Visible = apermiso > RoleManager.TipoPermisos.Lectura
        tst_Editar.Visible = apermiso > RoleManager.TipoPermisos.Lectura
        'tstDuplicarCita.Visible = apermiso > RoleManager.TipoPermisos.Lectura


        GridEX1.RootTable.Columns("Importe").Visible = Not (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) = RoleManager.TipoPermisos.Ninguno)
        GridEX1.RootTable.ChildTables(0).Columns("Importe").Visible = Not (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) = RoleManager.TipoPermisos.Ninguno)

        'Definimos que cargue solo los ultimos 30 días
        Me.dtpDesde.Checked = True
        Me.dtpDesde.Value = DateAdd(DateInterval.Day, -30, Now)
        Me.dtpHasta.Checked = True
        Me.dtpHasta.Value = Now
        CargaDatos()
    End Sub

    Private Sub CargaDatos()
        Try
            context = New CMLinqDataContext()





            Filtrar()

        Catch ex As Exception
            Globales.ErrorMsg(ex, "error cargando presupuestos")
        End Try
    End Sub

    Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Table.Key = "d_Presupuesto" Then
                Dim o As d_Presupuesto = e.Row.DataRow
                If Not o Is Nothing Then
                    e.Row.Cells("PACIENTE").Text = e.Row.Cells("NOMBRE").Value & " " & e.Row.Cells("APELLIDO1").Value & " " & e.Row.Cells("APELLIDO2").Value 'o.d_Odontograma.PACIENTE.NOMBRE & " " & o.d_Odontograma.PACIENTE.APELLIDO1 & " " & o.d_Odontograma.PACIENTE.APELLIDO2

                    If o.d_Odontograma.TipoDenticion = 0 Then
                        e.Row.Cells("TipoDenticion").Text = "Temporal"
                    Else
                        e.Row.Cells("TipoDenticion").Text = "Permanente"
                    End If


                    e.Row.Cells("Importe").Text = o.d_PresupuestoLineas.Sum(Function(l) l.Importe).ToString("C2")
                    e.Row.Cells("columnDescuento").Text = o.d_PresupuestoLineas.Sum(Function(l) l.DescuentoPercent)


                    Dim cant_aceptados As Integer = o.d_PresupuestoLineas.Where(Function(l) l.Confirmado).Count()
                    If cant_aceptados > 0 And cant_aceptados < o.d_PresupuestoLineas.Count Then
                        'Parcialmente aceptados
                        If e.Row.RowStyle Is Nothing Then e.Row.RowStyle = New GridEXFormatStyle()
                        e.Row.RowStyle.BackColor = Color.FromArgb(70, 200, 200)
                    Else
                        If cant_aceptados = o.d_PresupuestoLineas.Count Then
                            If e.Row.RowStyle Is Nothing Then e.Row.RowStyle = New GridEXFormatStyle()
                            e.Row.RowStyle.BackColor = Color.FromArgb(120, 240, 120)
                        End If
                    End If
                    
                End If
            End If
            If e.Row.Table.Key = "d_PresupuestoLineas" Then
                Dim linea As d_PresupuestoLinea = e.Row.DataRow
                If Not linea Is Nothing Then
                    e.Row.Cells("IDCITA").Text = linea.IDCITA.HasValue

                    If linea.Urgencia > 0 Then
                        If e.Row.RowStyle Is Nothing Then e.Row.RowStyle = New GridEXFormatStyle()
                        e.Row.RowStyle.ForeColor = Color.Red
                        e.Row.Cells("Urgencia").Image = My.Resources.Alarma.GetThumbnailImage(16, 16, Nothing, Nothing)
                    End If
                End If

                'If linea.Confirmado Then
                '    'Parcialmente aceptados
                '    If e.Row.RowStyle Is Nothing Then e.Row.RowStyle = New GridEXFormatStyle()
                '    e.Row.RowStyle.BackColor = Color.FromArgb(70, 200, 200)
                'Else
                '    'If e.Row.RowStyle Is Nothing Then e.Row.RowStyle = New GridEXFormatStyle()
                '    'e.Row.RowStyle.BackColor = Color.FromArgb(120, 240, 120)
                '    ' End If
                'End If
            End If
        End If
        
    End Sub



#Region "Public Sub Filtrar()"
    Public Sub Filtrar()

        If Not Me.IsHandleCreated Then
            Return
        End If
        presupuestos = context.d_Presupuestos.Where(Function(o) o.d_PresupuestoLineas.Count > 0).OrderBy(Function(p) p.d_Odontograma.PACIENTE.NOMBRE)

        'presupuestos = (From p In context.d_Presupuestos Where p.d_PresupuestoLineas.Count > 0 Select p Order By p.d_Odontograma.PACIENTE.NOMBRE Descending)
        Dim condition As New GridEXFilterCondition()
        condition.LogicalOperator = LogicalOperator.And

        Dim conditionLineas As New GridEXFilterCondition()
        conditionLineas.LogicalOperator = LogicalOperator.And

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("IDPACIENTE"), ConditionOperator.Equal, CtrlPaciente1.ID_PACIENTE))
            presupuestos = presupuestos.Where(Function(o) o.d_Odontograma.PACIENTE.CPACIENTE = CtrlPaciente1.ID_PACIENTE)
        End If

        If dtpDesde.Checked Then
            Dim fecha As New Date(dtpDesde.Value.Year, dtpDesde.Value.Month, dtpDesde.Value.Day)
            presupuestos = presupuestos.Where(Function(o) o.FechaConcepcion >= fecha)
        End If

        If dtpHasta.Checked Then
            Dim fecha As New Date(dtpHasta.Value.Year, dtpHasta.Value.Month, dtpHasta.Value.Day)
            presupuestos = presupuestos.Where(Function(o) o.FechaConcepcion <= fecha)
        End If

        If txtNombre.Text.Length > 0 Then
            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("NOMBRE"), _
            '                        ConditionOperator.BeginsWith, txtNombre.Text))
            presupuestos = presupuestos.Where(Function(o) o.d_Odontograma.PACIENTE.NOMBRE.Contains(txtNombre.Text.Trim))
        End If

        If txtApellido1.Text.Length > 0 Then
            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("APELLIDO1"), _
            '                        ConditionOperator.BeginsWith, txtApellido1.Text))
            presupuestos = presupuestos.Where(Function(o) o.d_Odontograma.PACIENTE.APELLIDO1.Contains(txtApellido1.Text.Trim))
        End If

        If txtApellido2.Text.Length > 0 Then
            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("APELLIDO2"), _
            '                        ConditionOperator.BeginsWith, txtApellido2.Text))
            presupuestos = presupuestos.Where(Function(o) o.d_Odontograma.PACIENTE.APELLIDO2.Contains(txtApellido2.Text.Trim))
        End If

        If rbCitasAsociados.Checked Then
            'GridEX1.RootTable.ChildTables(0).FilterCondition = New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("IDCITA"), _
            '                                               ConditionOperator.NotIsNull, Nothing)
            conditionLineas.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("IDCITA"), _
                                                          ConditionOperator.NotIsNull, Nothing))
        End If

        If rbCitasNoAsociados.Checked Then
            'GridEX1.RootTable.ChildTables(0).FilterCondition = New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("IDCITA"), _
            '                                              ConditionOperator.IsNull, Nothing)
            conditionLineas.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("IDCITA"), _
                                                          ConditionOperator.IsNull, Nothing))
        End If


        If chkConfirmados.Checked Then
            conditionLineas.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("Confirmado"), _
                                                       ConditionOperator.Equal, True))
        End If

        If chkRealizados.Checked Then
            conditionLineas.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("Realizado"), _
                                                       ConditionOperator.Equal, True))
        End If

        If Not chkMostrarLineasImporte0.Checked Then
            conditionLineas.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEX1.RootTable.ChildTables(0).Columns("Importe"), _
                                                       ConditionOperator.GreaterThan, 0))
        End If

        
        Try
            DPresupuestoBindingSource.DataSource = Nothing
            DPresupuestoBindingSource.DataSource = presupuestos
            GridEX1.RootTable.FilterCondition = condition
            GridEX1.RootTable.ChildTables(0).FilterCondition = conditionLineas

        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al filtrar ptos dentales")
        End Try

    End Sub
#End Region

    Private Sub rbCitasNoAsociados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCitasNoAsociados.CheckedChanged
        ' Filtrar()
    End Sub

    Private Sub rbCitasAsociados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCitasAsociados.CheckedChanged
        'Filtrar()
    End Sub

    Private Sub rbCitasTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCitasTodos.CheckedChanged
        'Filtrar()
    End Sub

    Private Sub btnSeleccionarLineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarLineas.Click
        SelectedLineas = New List(Of d_PresupuestoLinea)
        For Each row As GridEXRow In GridEX1.GetCheckedRows()
            If TypeOf (row.DataRow) Is d_PresupuestoLinea Then
                SelectedLineas.Add(row.DataRow)
            End If
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CtrlPaciente1_PacienteEliminado(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteEliminado
        ' Filtrar()
    End Sub

    Private Sub CtrlPaciente1_PacienteFichaAbierta(ByVal IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteFichaAbierta
        ' Filtrar()
    End Sub

    Private Sub CtrlPaciente1_PacienteNoEncontrado() Handles CtrlPaciente1.PacienteNoEncontrado
        '  Filtrar()
    End Sub

    Private Sub CtrlPaciente1_PacienteSeleccionado(ByVal IdPaciente As System.Int32, ByVal IsReturnPressed As System.Boolean) Handles CtrlPaciente1.PacienteSeleccionado
        ' Filtrar()
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        'Nuevo presupuesto
        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe seleccionar una paciente primero")
            CtrlPaciente1.Focus()
            Return
        End If

        Dim frm As New frmOdontograma()
        frm.Text = "Odontograma de " & CtrlPaciente1.NombreCompleto()
        'frm.MostrarSoloPresupuesto = True

        frm.PacienteActual = CtrlPaciente1.ID_PACIENTE

        Me.GridEX1.Enabled = False
        lblLoading.Visible = True
        Me.Update()
        frm.ShowDialog()
        lblLoading.Visible = False
        Me.GridEX1.Enabled = True

        CargaDatos()
        'LevantaHilo()
    End Sub

    Private Sub LevantaHilo()
        Dim ts As New System.Threading.ThreadStart(AddressOf OpenOdontograma)
        Dim thread As New System.Threading.Thread(ts)
        thread.Start()
    End Sub

    Private Sub OpenOdontograma()
        
    End Sub

    Private Sub chkConfirmados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConfirmados.CheckedChanged
        ' Filtrar()
    End Sub

    Private Sub chkRealizados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRealizados.CheckedChanged
        ' Filtrar()
    End Sub

    Private Sub GridEX1_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEX1.RowCheckStateChanged
        tst_Eliminar.Enabled = GridEX1.GetCheckedRows.Count > 0
        'tst_Editar.Enabled = GridEX1.GetCheckedRows.Count > 0
    End Sub

    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        'tst_Eliminar.Enabled = GridEX1.SelectedItems.Count > 0
        tst_Editar.Enabled = GridEX1.SelectedItems.Count > 0
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        If MessageBox.Show("Esta seguro que desea eliminar el/los presupuesto(s)?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim cont As New CMLinqDataContext()

                For Each row As GridEXRow In GridEX1.GetCheckedRows()
                    If row.RowType = RowType.Record Then
                        If row.Table.Key = "d_Presupuesto" Then
                            Dim prep As d_Presupuesto = row.DataRow

                            Dim presupuesto As d_Presupuesto = (From p In cont.d_Presupuestos Where p.IDPresupuesto = prep.IDPresupuesto Select p).SingleOrDefault()
                            cont.d_Presupuestos.DeleteOnSubmit(presupuesto)
                        End If
                    End If
                Next
                cont.SubmitChanges()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            CargaDatos()
        End If
    End Sub


    Private Sub GridEX1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        Try
            If e.Row.RowType = RowType.Record Then
                tst_Editar_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Try
            If GridEX1.SelectedItems(0).RowType = RowType.Record Then
                Dim pres As d_Presupuesto
                If GridEX1.SelectedItems(0).GetRow().Parent Is Nothing Then
                    pres = GridEX1.SelectedItems(0).GetRow().DataRow
                Else
                    pres = GridEX1.SelectedItems(0).GetRow().Parent.DataRow
                End If

                Dim frm As New frmOdontograma()
                frm.Text = "Odontograma de " & pres.d_Odontograma.PACIENTE.NOMBRE & " " & pres.d_Odontograma.PACIENTE.APELLIDO1
                frm.PacienteActual = pres.d_Odontograma.IDPaciente
                frm.MostrarSoloPresupuesto = True

                Me.GridEX1.Enabled = False
                'GridEX1.BackColor = color.Gray
                lblLoading.Visible = True
                Me.Update()


                frm.ShowDialog()
                lblLoading.Visible = False
                Me.GridEX1.Enabled = True
                CargaDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkMostrarLineasImporte0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMostrarLineasImporte0.CheckedChanged
        ' Filtrar()
    End Sub


    Private Sub GridEX1_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick
        Try

            Dim linea As d_PresupuestoLinea = GridEX1.SelectedItems(0).GetRow().DataRow
            If Not linea.IDCITA.HasValue Then
                MessageBox.Show("La linea no tiene cita asociada")
                Return
            End If
            If tst_Editar.Visible Then
                Dim frm As New form_citas("Editar cita", Enums.Accion.Modificar, linea.IDCITA)
                frm.ShowDialog()
            Else
                Dim frm As New form_citas("Ver cita", Enums.Accion.Ver, linea.IDCITA)
                frm.ShowDialog()
            End If

            CargaDatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub dtpDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.ValueChanged
        'Filtrar()
    End Sub

    Private Sub dtpHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.ValueChanged
        'Filtrar()
    End Sub

    'Private Sub Temp()
    '    'Permisos de acceso


    '    Try
    '        Dim apermiso As Integer = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Citas)

    '        Dim linea As d_PresupuestoLinea = GridEX1.SelectedItems(0).GetRow().DataRow

    '        If Not linea.IDCITA.HasValue Then
    '            MessageBox.Show("La linea no tiene cita asociada")
    '            Return

    '        End If
    '        If apermiso > RoleManager.TipoPermisos.Lectura Then
    '            Dim frm As New form_citas_sub("Editar cita", Enums.Accion.Modificar, linea.IDCITA)
    '            frm.ShowDialog()
    '        Else
    '            Dim frm As New form_citas_sub("Ver cita", Enums.Accion.Ver, linea.IDCITA)
    '            frm.ShowDialog()
    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        'Filtrar()
    End Sub

    Private Sub txtApellido1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApellido1.TextChanged
        'Filtrar()
    End Sub

    Private Sub txtApellido2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApellido2.TextChanged
        ' Filtrar()
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        Filtrar()
    End Sub
End Class