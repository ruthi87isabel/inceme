Public Class frmConnectionDB
    Dim con As New conexion
    Public conString As String
    Private Sub frmConnectionDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ConexionBindingSource.DataSource = con
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        con.guardar()
        Me.conString = con.connectionString
        Me.DialogResult = vbYes
        Me.Close()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub
End Class