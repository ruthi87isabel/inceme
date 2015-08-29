Public Class frmProcesos

    Public Proceso As CM3DataSet.N_Procesos_ResumenRow = Nothing
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion


    Private Sub frmProcesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.N_Procesos_ResumenTableAdapter.Fill(Me.CM3DataSet.N_Procesos_Resumen)
        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            Filtrar()
        End If
    End Sub
    Private Sub btn_Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Filtrar.Click
        Filtrar()
    End Sub

    Private Sub chk_FechaInicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_FechaInicio.CheckedChanged
        dtp_fi.Enabled = chk_FechaInicio.Checked
    End Sub

    Private Sub chk_Final_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Final.CheckedChanged
        dtp_ff.Enabled = chk_Final.Checked
    End Sub

#Region "Private Sub Filtrar()"
    Private Sub Filtrar()
        Dim filtros As New List(Of String)

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            filtros.Add("ID_PACIENTE=" & CtrlPaciente1.ID_PACIENTE.Value & "")
        End If

        If rb_Abiertos.Checked Then
            filtros.Add("FechaFinal is Null AND Finalizado=False")
        End If

        If rb_Cerrados.Checked Then
            filtros.Add("NOT FechaFinal is Null AND Finalizado=False")
        End If

        If rb_Finalizados.Checked Then
            filtros.Add("NOT FechaFinal is Null AND Finalizado=True")
        End If

        If chk_FechaInicio.Checked Then
            filtros.Add("FechaInicio>='" & dtp_fi.Value.ToShortDateString() & "'")
        End If

        If chk_Final.Checked Then
            filtros.Add("FechaInicio<='" & dtp_ff.Value.ToShortDateString() & "'")
        End If


        Dim filtro = String.Join(" AND ", filtros.ToArray())

        Try
            'Me.filtro = filter

            Dim dw As DataView = Me.CM3DataSet.N_Procesos_Resumen.DefaultView
            dw.RowFilter = filtro
            dw.RowStateFilter = DataViewRowState.CurrentRows
            N_Procesos_ResumenDataGridView.DataSource = dw
            N_Procesos_ResumenDataGridView.Update()
            'lb_total.Text = dw.Count
            'CalculaTotal(filtro)
        Catch ex As Exception
        End Try

    End Sub
#End Region

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click

        Dim frm As frmProcesos_ADD = New frmProcesos_ADD()
        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            frm.CtrlPaciente1.ID_PACIENTE = CtrlPaciente1.ID_PACIENTE
            frm.CtrlPaciente1.Enabled = CtrlPaciente1.Enabled
        End If

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_Procesos_ResumenTableAdapter.Fill(Me.CM3DataSet.N_Procesos_Resumen)
            Me.N_Procesos_ResumenBindingSource.MoveLast()
            CalculaTotal(String.Empty)
        End If
    End Sub

    Private Sub N_Procesos_ResumenDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Procesos_ResumenDataGridView.SelectionChanged
        tst_Editar.Enabled = N_Procesos_ResumenDataGridView.SelectedRows.Count > 0 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Procesos) > RoleManager.TipoPermisos.Lectura
        tst_Eliminar.Enabled = N_Procesos_ResumenDataGridView.SelectedRows.Count > 0 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Procesos) > RoleManager.TipoPermisos.Lectura
        If N_Procesos_ResumenDataGridView.SelectedRows.Count > 0 Then
            Proceso = N_Procesos_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row
            'tst_TotalSeleccionado.Text = "Total seleccionado: " & Proceso.Total
        End If
    End Sub

    Private Sub CalculaTotal(ByVal filtro As String)
        If CM3DataSet.N_Procesos_Resumen.Count > 0 Then
            'Dim total As Object = CM3DataSet.N_Procesos_Resumen.Compute("SUM(Total)", filtro)
            'If Not total Is DBNull.Value Then
            'tst_Total.Text = "Total: " & CType(total, Double).ToString("C2")
            'Else
            'tst_Total.Text = "Total: 0.0"
            'End If
            'Else
            'tst_Total.Text = "Total: 0.0"
        End If

    End Sub

    Private Sub N_Procesos_ResumenDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_Procesos_ResumenDataGridView.CellDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            Proceso = N_Procesos_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Procesos) > RoleManager.TipoPermisos.Lectura Then
                tst_Editar_Click(Nothing, Nothing)
            End If

        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Proceso = N_Procesos_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmProcesos_ADD = New frmProcesos_ADD()
        frm.CtrlPaciente1.Enabled = False 'No se puede cambiar el paciente una vez creado el proceso
        frm.ID_Proceso = Proceso.ID_Proceso
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_Procesos_ResumenDataGridView.SelectedRows(0).Index
            Me.N_Procesos_ResumenTableAdapter.Fill(Me.CM3DataSet.N_Procesos_Resumen)
            'MuestraTotales()
            If pos < N_Procesos_ResumenDataGridView.Rows.Count Then
                N_Procesos_ResumenDataGridView.Rows(pos).Selected = True
            End If

            CalculaTotal(String.Empty)
        End If
    End Sub

    'Private Sub N_Procesos_ResumenDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_Procesos_ResumenDataGridView.CellFormatting

    '    'If e.ColumnIndex = EstadoDataGridViewTextBoxColumn.Index Then
    '    '    If Not e.Value Is DBNull.Value Then
    '    '        e.Value = CType(e.Value, Globals.Procesos_Estado)
    '    '    End If

    '    'End If
    'End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click

        If MessageBox.Show("Al eliminar este proceso NO se eliminarán las citas, partes y facturas asociadas al mismo. ¿Desea continuar?", "Comformación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Proceso = N_Procesos_ResumenDataGridView.SelectedRows(0).DataBoundItem.Row

            Dim adapter As CM3DataSetTableAdapters.N_ProcesosTableAdapter = New CM3DataSetTableAdapters.N_ProcesosTableAdapter()
            'Hay que hacer null todas aquellas facturas, citas y partes asociados
            HacerProcesoNull("FACTURAS", "ID_Proceso", "ID_Proceso=" & Proceso.ID_Proceso)
            HacerProcesoNull("CITAS", "ID_Proceso", "ID_Proceso=" & Proceso.ID_Proceso)
            HacerProcesoNull("N_Partes", "ID_Proceso", "ID_Proceso=" & Proceso.ID_Proceso)
            HacerProcesoNull("N_Partes_Asistencia", "ID_Proceso", "ID_Proceso=" & Proceso.ID_Proceso)

            Dim n As Integer = adapter.DeleteQuery(Proceso.ID_Proceso)
            If n > 0 Then
                Proceso.Delete()
                Me.N_Procesos_ResumenBindingSource.EndEdit()
                CalculaTotal(String.Empty)
            End If
        End If
    End Sub

    Private Sub HacerProcesoNull(ByVal table As String, ByVal columnName As String, ByVal where As String)
        Dim query As String = "UPDATE " & table & " SET " & columnName & "=NULL WHERE " & where
        Dim n As Integer = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, query)

    End Sub



#Region "Private Sub CalculaTotales()"
    Private Sub CalculaTotales(ByVal fil As String)
        'Dim total_medicos As Object = CM2DataSet.ListadoCitas.Compute("Sum([Importe médico])", fil)
        'Dim total_clinica As Object = CM2DataSet.ListadoCitas.Compute("Sum([Importe clínica])", fil)
        'Dim total As Object = CM2DataSet.ListadoCitas.Compute("Sum([Importe Total])", fil)

        'If Not total_medicos Is DBNull.Value Then
        '    lb_medico.Text = CType(total_medicos, Double).ToString("C2")
        'Else
        '    lb_medico.Text = "0"
        'End If

        'If Not total_clinica Is DBNull.Value Then
        '    lb_clinica.Text = CType(total_clinica, Double).ToString("C2")
        'Else
        '    lb_clinica.Text = "0"
        'End If

        'If Not total Is DBNull.Value Then
        '    lb_total.Text = CType(total, Double).ToString("C2")
        'Else
        '    lb_total.Text = "0"
        'End If
    End Sub
#End Region



    Private Sub tst_ButtonFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Filtrar()
    End Sub

    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click
        Dim rdatasourceTotales As New Microsoft.Reporting.WinForms.ReportDataSource
        rdatasourceTotales.Name = "CM3DataSet_N_Procesos_Resumen"
        rdatasourceTotales.Value = N_Procesos_ResumenDataGridView.DataSource

        UI.Reportes.ReportesManager.Imprime("ProcesosListado.rdlc", {rdatasourceTotales})

   
    End Sub

    Private Sub N_Procesos_ResumenDataGridView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles N_Procesos_ResumenDataGridView.CellFormatting
        If e.ColumnIndex = 1 Then
            Dim proceso As CM3DataSet.N_Procesos_ResumenRow = N_Procesos_ResumenDataGridView.Rows(e.RowIndex).DataBoundItem.Row
            If Not proceso.IsFechaFinalNull Then
                If proceso.Finalizado Then
                    'Finalizado
                    N_Procesos_ResumenDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.DarkGray
                    N_Procesos_ResumenDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
                Else
                    'Cerrado
                    N_Procesos_ResumenDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
                End If
            Else
                'Normal
            End If

            N_Procesos_ResumenDataGridView.Rows(e.RowIndex).Cells(columnEstado.Index).Value = Globales.Proceso_DameIconoEstado(proceso)
        End If

    End Sub

End Class
