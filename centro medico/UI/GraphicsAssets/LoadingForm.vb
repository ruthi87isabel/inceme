Public Class LoadingForm

    Public Worker As System.ComponentModel.BackgroundWorker

    Public Property DisplayMessage() As String
        Get
            Return Label3.Text
        End Get
        Set(ByVal value As String)
            Label3.BeginInvoke(Sub()
                                   Label3.Text = value
                               End Sub)
        End Set
    End Property

    Private Sub linkCancel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCancel.LinkClicked
        If Not Worker Is Nothing Then
            Worker.CancelAsync()
        End If

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub
End Class