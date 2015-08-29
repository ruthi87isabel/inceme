Public Class frmErrores

    Public Exception As Exception

    Public Sub New(ByVal msg As String, ByRef ex As Exception)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.lbl_Msg.Text = msg
        Me.Exception = ex
        txtMessage.Text = ex.Message
        txtStackTrace.Text = ex.StackTrace
        If Not ex.InnerException Is Nothing Then
            txtInnerException.Text = ex.InnerException.Message + vbCrLf + ex.InnerException.StackTrace
        End If

    End Sub

    Public Sub New(ByRef ex As Exception)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Exception = ex
        txtMessage.Text = ex.Message
        txtStackTrace.Text = ex.StackTrace
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Enviar.Click

    End Sub
End Class