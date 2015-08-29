Imports System.ComponentModel
Imports System.Reflection

Public Class frmPartes

    Dim Parte As CM3DataSet.N_PartesRow
    Dim Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion



    Private Sub frmPartes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CM3DataSet.N_Partes' table. You can move, or remove it, as needed.
        Me.N_PartesTableAdapter.Fill(Me.CM3DataSet.N_Partes)

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

        If rb_Bajas.Checked Then
            filtros.Add("E_Tipo=" & Globales.Partes_Tipos.Baja)
        End If
        If rb_Altas.Checked Then
            filtros.Add("E_Tipo=" & Globales.Partes_Tipos.Alta)
        End If


        If chk_FechaInicio.Checked Then
            filtros.Add("FechaBaja>='" & dtp_fi.Value.ToShortDateString() & "'")
        End If

        If chk_Final.Checked Then
            filtros.Add("FechaBaja<='" & dtp_ff.Value.ToShortDateString() & "'")
        End If


        Dim filtro = String.Join(" AND ", filtros.ToArray())

        Try
            'Me.filtro = filter

            Dim dw As DataView = Me.CM3DataSet.N_Partes.DefaultView
            dw.RowFilter = filtro
            dw.RowStateFilter = DataViewRowState.CurrentRows
            gridExPartes.DataSource = dw
            gridExPartes.Update()
            'lb_total.Text = dw.Count
            'CalculaTotal(filtro)
        Catch ex As Exception
        End Try

    End Sub
#End Region

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click

        Dim frm As frmPartes_ADD = New frmPartes_ADD()
        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            frm.ID_Paciente = CtrlPaciente1.ID_PACIENTE
        End If
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_PartesTableAdapter.Fill(Me.CM3DataSet.N_Partes)
            Me.N_PartesBindingSource.MoveLast()
            'CalculaTotal(String.Empty)
        End If
    End Sub

    Private Sub gridExPartes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridExPartes.SelectionChanged
        tst_Editar.Enabled = gridExPartes.RowCount > 0 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Partes) > RoleManager.TipoPermisos.Lectura
        tst_Eliminar.Enabled = gridExPartes.RowCount > 0 And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Partes) > RoleManager.TipoPermisos.Lectura

    End Sub

    Private Sub CalculaTotal(ByVal filtro As String)
        If CM3DataSet.N_Partes.Count > 0 Then
            'Dim total As Object = CM3DataSet.N_Partes.Compute("SUM(Total)", filtro)
            'If Not total Is DBNull.Value Then
            'tst_Total.Text = "Total: " & CType(total, Double).ToString("C2")
            'Else
            'tst_Total.Text = "Total: 0.0"
            'End If
            'Else
            'tst_Total.Text = "Total: 0.0"
        End If

    End Sub

    Private Sub gridExPartes_CellDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles gridExPartes.RowDoubleClick
        If Modo = Globales.ModoParaFormas.Seleccion Then
            Parte = gridExPartes.GetRow(gridExPartes.Row).DataRow.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Partes) > RoleManager.TipoPermisos.Lectura Then
                tst_Editar_Click(Nothing, Nothing)
            End If

        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Parte = gridExPartes.GetRow(gridExPartes.Row).DataRow.Row
        Dim frm As frmPartes_ADD = New frmPartes_ADD()
        frm.ID_Parte = Parte.ID_Parte
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = gridExPartes.Row
            Me.N_PartesTableAdapter.Fill(Me.CM3DataSet.N_Partes)
            'MuestraTotales()
            gridExPartes.MoveLast()
            CalculaTotal(String.Empty)
        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click

        If gridExPartes.SelectedItems.Count > 0 Then
            If gridExPartes.SelectedItems(0).RowType = Janus.Windows.GridEX.RowType.Record Then
                If Not gridExPartes.SelectedItems(0).GetRow().Parent Is Nothing Then
                    'Es Parte de alta
                    Dim parteAlta As CM3DataSet.N_PartesRow = gridExPartes.SelectedItems(0).GetRow().DataRow.Row
                    parteAlta.Delete()
                Else
                    'Es parte de baja
                    If Not gridExPartes.SelectedItems(0).GetRow().DataRow Is Nothing Then
                        Dim parteBaja As CM3DataSet.N_PartesRow = gridExPartes.SelectedItems(0).GetRow().DataRow.Row

                        'Borrar los hijos
                        For Each child As Janus.Windows.GridEX.GridEXRow In gridExPartes.SelectedItems(0).GetRow().GetChildRows()
                            Dim parteAlta As CM3DataSet.N_PartesRow = child.DataRow.Row
                            parteAlta.Delete()
                            Me.N_PartesBindingSource.EndEdit()
                            Me.N_PartesTableAdapter.Update(CM3DataSet.N_Partes)

                        Next
                        parteBaja.Delete()
                    End If

                End If
                Me.N_PartesBindingSource.EndEdit()
                Me.N_PartesTableAdapter.Update(CM3DataSet.N_Partes)
            End If
        End If

        Me.N_PartesTableAdapter.Fill(Me.CM3DataSet.N_Partes)
        Filtrar()

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

        rdatasourceTotales.Name = "CM3DataSet_N_Partes"
        rdatasourceTotales.Value = gridExPartes.DataSource.N_Partes

        UI.Reportes.ReportesManager.Imprime("PartesBajaAltaListado.rdlc", {rdatasourceTotales})

    End Sub

    Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles gridExPartes.FormattingRow

        e.Row.Cells("E_Tipo").Text = CType(e.Row.Cells("E_Tipo").Value, Globales.Partes_Tipos).ToString()
        e.Row.Cells("E_Regimen").Text = CType(e.Row.Cells("E_Regimen").Value, Globales.Partes_Regimen).ToString()
        e.Row.Cells("E_Situacion").Text = CType(e.Row.Cells("E_Situacion").Value, Globales.Partes_Situacion).ToString()
        e.Row.Cells("E_Caracter").Text = CType(e.Row.Cells("E_Caracter").Value, Globales.Partes_Caracter).ToString()

        If Not e.Row.Cells("E_Causa_de_baja").Value Is DBNull.Value Then
            e.Row.Cells("E_Causa_de_baja").Text = CType(e.Row.Cells("E_Causa_de_baja").Value, Globales.Partes_Causa_de_Baja).ToString()
        End If

        If Not e.Row.Cells("Alta_E_Causa_de_Alta").Value Is DBNull.Value Then
            e.Row.Cells("Alta_E_Causa_de_Alta").Text = CType(e.Row.Cells("Alta_E_Causa_de_Alta").Value, Globales.Partes_Causa_de_Alta).ToString()
        End If

    End Sub
End Class




