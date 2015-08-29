Public Class frmBancos_ADD

    Public ID_Banco As Long = -1
    Public Banco As CMDataSet.N_BancosRow = Nothing

    Private Sub frmBancos_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.grpDetalles.Enabled = (Globals.Usuario.Permisos(RoleManager.Items.Bancos) > 2)
        Me.btn_Guardar.Enabled = (Globals.Usuario.Permisos(RoleManager.Items.Bancos) > 2)

        If ID_Banco <> -1 Then
            Me.N_BancosTableAdapter.FillBy(Me.CMDataSet.N_Bancos, ID_Banco)
            Banco = Me.CMDataSet.N_Bancos(0)
        Else
            'Crearlo Nuevo
            Banco = N_BancosBindingSource.AddNew().Row()
            CodigoTextBox.Text = Globals.GeneraCodigoAutomatico("N_Bancos", "ID_Banco", "000000")
        End If

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If CodigoTextBox.Text.Length = 0 Then
            MessageBox.Show("Debe introducir algun código")
            CodigoTextBox.Focus()
            Return
        End If

        Me.Validate()
        Me.N_BancosBindingSource.EndEdit()
        Me.N_BancosTableAdapter.Update(Me.CMDataSet.N_Bancos)
        ID_Banco = Banco.ID_Banco

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class