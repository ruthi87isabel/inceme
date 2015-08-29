Public Class form_analresult

    Public _result As String

    Private Sub form_analresult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_result.Text = _result
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        _result = tb_result.Text
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        Me.Close()
    End Sub

    Private Sub tb_result_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_result.KeyPress

        If e.KeyChar = Chr(13) Then
            bt_aceptar.Focus()



        End If
    End Sub
End Class