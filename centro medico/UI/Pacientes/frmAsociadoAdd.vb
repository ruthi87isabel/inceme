Public Class frmAsociadoAdd

    

    Private Sub frmAsociadoAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim context As New CMLinqDataContext()

        ParentescoBindingSource.DataSource = (From p In context.Parentescos _
                                           Select p).ToList()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Debe seleccionar un paciente")
            CtrlPaciente1.Focus()
            Return
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class