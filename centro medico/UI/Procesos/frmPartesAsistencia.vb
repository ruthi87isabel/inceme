

Imports System.ComponentModel
Imports System.Reflection

Public Class frmPartesAsistencia

    Dim Parte As CM3DataSet.N_Partes_AsistenciaRow
    Dim Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion



    Private Sub frmPartes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.N_Partes_AsistenciaTableAdapter.Fill(Me.CM3DataSet.N_Partes_Asistencia)


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

#Region "Public Sub Filtrar()"
    Public Sub Filtrar()
        Dim filtros As New List(Of String)

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            filtros.Add("ID_PACIENTE=" & CtrlPaciente1.ID_PACIENTE.Value & "")
        End If

        'If rb_Bajas.Checked Then
        '    filtros.Add("E_Tipo=" & Globals.Partes_Tipos.Baja)
        'End If
        'If rb_Altas.Checked Then
        '    filtros.Add("E_Tipo=" & Globals.Partes_Tipos.Alta)
        'End If


        If chk_FechaInicio.Checked Then
            filtros.Add("FechaBaja>='" & dtp_fi.Value.ToShortDateString() & "'")
        End If

        If chk_Final.Checked Then
            filtros.Add("FechaBaja<='" & dtp_ff.Value.ToShortDateString() & "'")
        End If


        Dim filtro = String.Join(" AND ", filtros.ToArray())

        Try
            'Me.filtro = filter

            Dim dw As DataView = Me.CM3DataSet.N_Partes_Asistencia.DefaultView
            dw.RowFilter = filtro
            dw.RowStateFilter = DataViewRowState.CurrentRows
            GridEX1.DataSource = dw
            GridEX1.Update()
            'lb_total.Text = dw.Count
            'CalculaTotal(filtro)
        Catch ex As Exception
        End Try

    End Sub
#End Region

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click

        Dim frm As frmPartesAsistencia_ADD = New frmPartesAsistencia_ADD()
        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            frm.ID_Paciente = CtrlPaciente1.ID_PACIENTE
        End If

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_Partes_AsistenciaTableAdapter.Fill(Me.CM3DataSet.N_Partes_Asistencia)
            Me.N_Partes_AsistenciaBindingSource.MoveLast()
            'CalculaTotal(String.Empty)
        End If
    End Sub

    Private Sub N_Partes_AsistenciaDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        If GridEX1.SelectedItems.Count > 0 Then
            If GridEX1.SelectedItems(0).RowType = Janus.Windows.GridEX.RowType.Record Then
                tst_Editar.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Partes) > RoleManager.TipoPermisos.Lectura
                tst_Eliminar.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Partes) > RoleManager.TipoPermisos.Lectura
                'Parte = GridEX1.SelectedItems(0).GetRow().DataRow.Row
            End If
        End If
    End Sub

    Private Sub CalculaTotal(ByVal filtro As String)
        If CM3DataSet.N_Partes_Asistencia.Count > 0 Then
            'Dim total As Object = CM3DataSet.N_Partes_Asistencia.Compute("SUM(Total)", filtro)
            'If Not total Is DBNull.Value Then
            'tst_Total.Text = "Total: " & CType(total, Double).ToString("C2")
            'Else
            'tst_Total.Text = "Total: 0.0"
            'End If
            'Else
            'tst_Total.Text = "Total: 0.0"
        End If

    End Sub

    Private Sub N_Partes_AsistenciaDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick

        If e.Row.RowType = Janus.Windows.GridEX.RowType.Record Then
            If Modo = Globales.ModoParaFormas.Seleccion Then
                Parte = GridEX1.SelectedItems(0).GetRow().DataRow.Row
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Partes) > RoleManager.TipoPermisos.Lectura Then
                    tst_Editar_Click(Nothing, Nothing)
                End If
            End If
        End If

    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click

        If GridEX1.SelectedItems.Count > 0 Then
            If GridEX1.SelectedItems(0).RowType = Janus.Windows.GridEX.RowType.Record Then
                Parte = GridEX1.SelectedItems(0).GetRow().DataRow.Row

                Dim frm As frmPartesAsistencia_ADD = New frmPartesAsistencia_ADD()
                frm.ID_Parte = Parte.ID_ParteAsistencia
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    'Dim pos As Integer = GridEX1.SelectedRows(0).Index
                    Me.N_Partes_AsistenciaTableAdapter.Fill(Me.CM3DataSet.N_Partes_Asistencia)
                    'MuestraTotales()
                    'GridEX1.Rows(pos).Selected = True
                    CalculaTotal(String.Empty)
                End If
            End If
        End If

    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        If GridEX1.SelectedItems.Count > 0 Then
            If GridEX1.SelectedItems(0).RowType = Janus.Windows.GridEX.RowType.Record Then
                Parte = GridEX1.SelectedItems(0).GetRow().DataRow.Row
                Parte.Delete()
                Me.N_Partes_AsistenciaTableAdapter.Update(CM3DataSet.N_Partes_Asistencia)
                Me.N_Partes_AsistenciaTableAdapter.Fill(Me.CM3DataSet.N_Partes_Asistencia)
                Filtrar()
            End If
        End If
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
        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "CMDataSet_PARTES"
        ds.Value = GridEX1.DataSource

        UI.Reportes.ReportesManager.Imprime("PartesAsistenciasListado.rdlc", {ds})
    End Sub

    '    Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles GridEX1.CellFormatting

    'If e.ColumnIndex = columnRegimen.Index Then
    '    GridEX1.Rows(e.RowIndex).Cells(columnRegimen.Index).Value = Globals.Partes_Asistencia_Regimen.M_Carbon ' CType(e.Value, Globals.Partes_Asistencia_Regimen)
    '    'GridEX1.Rows(e.RowIndex).Cells(columnRegimen.Index).ValueType = GetType(Globals.Partes_Asistencia_Regimen)
    'End If


    'e.Row.Cells("E_Tipo").Text = CType(e.Row.Cells("E_Tipo").Value, Globals.Partes_Tipos).ToString()
    'e.Row.Cells("E_Regimen").Text = CType(e.Row.Cells("E_Regimen").Value, Globals.Partes_Regimen).ToString()
    'e.Row.Cells("E_Situacion").Text = CType(e.Row.Cells("E_Situacion").Value, Globals.Partes_Situacion).ToString()
    'e.Row.Cells("E_Caracter").Text = CType(e.Row.Cells("E_Caracter").Value, Globals.Partes_Caracter).ToString()

    'If Not e.Row.Cells("E_Causa_de_baja").Value Is DBNull.Value Then
    '    e.Row.Cells("E_Causa_de_baja").Text = CType(e.Row.Cells("E_Causa_de_baja").Value, Globals.Partes_Causa_de_Baja).ToString()
    'End If

    'If Not e.Row.Cells("Alta_E_Causa_de_Alta").Value Is DBNull.Value Then
    '    e.Row.Cells("Alta_E_Causa_de_Alta").Text = CType(e.Row.Cells("Alta_E_Causa_de_Alta").Value, Globals.Partes_Causa_de_Alta).ToString()
    'End If

    '   End Sub

    Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.FormattingRow
        e.Row.Cells("E_Pronostico").Text = CType(e.Row.Cells("E_Pronostico").Value, Globales.Partes_Asistencia_Pronostico).ToString()
        e.Row.Cells("E_Regimen").Text = CType(e.Row.Cells("E_Regimen").Value, Globales.Partes_Asistencia_Regimen).ToString()
        e.Row.Cells("E_Situacion").Text = CType(e.Row.Cells("E_Situacion").Value, Globales.Partes_Situacion).ToString()
        e.Row.Cells("E_Tratamiento").Text = CType(e.Row.Cells("E_Tratamiento").Value, Globales.Partes_Asistencia_Tratamiento).ToString()
    End Sub


End Class




