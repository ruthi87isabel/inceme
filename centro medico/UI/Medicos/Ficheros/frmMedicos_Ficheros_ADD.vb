Imports System.Data.Linq
Imports System.IO

Public Class frmMedicos_Ficheros_ADD

    Private Sub bt_FiBuscar_Click(sender As Object, e As EventArgs) Handles bt_FiBuscar.Click
        Dim frm As New OpenFileDialog
        If frm.ShowDialog() = DialogResult.OK Then
            Dim fichero As MEDICOS_FICHERO = MEDICOSFICHEROBindingSource.DataSource
            Try

                Dim fs As New FileStream(frm.FileName, FileMode.Open)
                Dim buffer(fs.Length) As Byte
                fs.Read(buffer, 0, fs.Length)
                fs.Close()
                fichero.Fichero = New Binary(buffer)
                fichero.NombreFichero = Path.GetFileName(frm.FileName)
                fichero.FechaSubido = Date.Now
                fichero.FechaModificado = Date.Now

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub bt_FiAceptar_Click(sender As Object, e As EventArgs) Handles bt_FiAceptar.Click

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub bt_FiCancelar_Click(sender As Object, e As EventArgs) Handles bt_FiCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class