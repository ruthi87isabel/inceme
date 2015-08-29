Public Class frmEntregas

    Private Sub frmEntregas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim context As New CMLinqDataContext()
        'ENTREGABindingSource.DataSource = From entrega In context.ENTREGAs Select entrega Order By e.Fecha Descending

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click

    End Sub
End Class