Public Class frmBancos

    Public Modo As Globals.ModoParaFormas = Globals.ModoParaFormas.Edicion
    Public Banco As CMDataSet.N_BancosRow


    Private Sub frmBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.N_BancosTableAdapter.Fill(Me.CMDataSet.N_Bancos)

        NewToolStripButton.Visible = (Globals.Usuario.Permisos(RoleManager.Items.Bancos) > 2)
        tst_Editar.Visible = (Globals.Usuario.Permisos(RoleManager.Items.Bancos) > 2)
        tst_Eliminar.Visible = (Globals.Usuario.Permisos(RoleManager.Items.Bancos) > 3)

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As frmBancos_ADD = New frmBancos_ADD()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.N_BancosTableAdapter.Fill(Me.CMDataSet.N_Bancos)
            Me.N_BancosBindingSource.MoveLast()
        End If
    End Sub

    Private Sub N_BancosDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_BancosDataGridView.SelectionChanged
        tst_Editar.Enabled = N_BancosDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = N_BancosDataGridView.SelectedRows.Count > 0
        If N_BancosDataGridView.SelectedRows.Count > 0 Then
            Banco = N_BancosDataGridView.SelectedRows(0).DataBoundItem.Row

        End If
    End Sub


    Private Sub N_BancosDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles N_BancosDataGridView.CellDoubleClick
        If Modo = Globals.ModoParaFormas.Seleccion Then
            Banco = N_BancosDataGridView.SelectedRows(0).DataBoundItem.Row
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            tst_Editar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        Banco = N_BancosDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim frm As frmBancos_ADD = New frmBancos_ADD()
        frm.ID_Banco = Banco.ID_Banco
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim pos As Integer = N_BancosDataGridView.SelectedRows(0).Index
            Me.N_BancosTableAdapter.Fill(Me.CMDataSet.N_Bancos)
            N_BancosDataGridView.Rows(pos).Selected = True
        End If
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Banco = N_BancosDataGridView.SelectedRows(0).DataBoundItem.Row
        Banco.Delete()
        Me.N_BancosBindingSource.EndEdit()
        Me.N_BancosTableAdapter.Update(Me.CMDataSet.N_Bancos)
    End Sub
End Class
