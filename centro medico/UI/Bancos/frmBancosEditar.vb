Public Class frmBancosEditar

    Private Sub bt_aceptar_Click(sender As Object, e As EventArgs) Handles bt_aceptar.Click
        Me.BANCOSBindingSource.EndEdit()
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class