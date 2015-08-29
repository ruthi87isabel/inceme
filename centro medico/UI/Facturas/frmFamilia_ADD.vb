Imports System.IO

Public Class frmFamilia_ADD

    Public Familia As CONCEPTOSFAMILIA
    Public Categorias As ctrlFamilia.MostrarCategorias = ctrlFamilia.MostrarCategorias.Todos

    Private Sub chkDental_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDental.CheckedChanged
        grpDental.Enabled = chkDental.Checked
        Familia.Categoria = 1
    End Sub

    Private Sub frmFamilia_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Familia Is Nothing Then
            CONCEPTOSFAMILIABindingSource.DataSource = Familia
            If Not Familia.IconoName Is Nothing Then
                Dim ms As New MemoryStream(Familia.IconoName.ToArray())
                PictureBox1.Image = Image.FromStream(ms)
                ms.Close()
            End If
            Try
                chkDental.Checked = Familia.Categoria.Value = 1
            Catch ex As Exception
            End Try

            'If Categorias <> ctrlFamilia.MostrarCategorias.Dentales Then
            'chkDental.Enabled = False
            'grpDental.Enabled = False

            'End If

        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        'If chkDental.Checked And Familia.Categoria <> "1" Then
        '    MessageBox.Show("La categoria dental debe ser 1")
        '    Return
        'End If

        If Not chkDental.Checked And Familia.Categoria = "1" Then
            'MessageBox.Show("La categoria 1 corresponde a la dental, debe marcar 'Dental'")
            Familia.Categoria = Nothing
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub



    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            Dim frm As New OpenFileDialog()
            If frm.ShowDialog() = DialogResult.OK Then

                Dim fs As New FileStream(frm.FileName, FileMode.Open)
                Dim array(fs.Length) As Byte

                fs.Read(array, 0, fs.Length - 1)

                PictureBox1.Image = Image.FromStream(fs)
                Familia.IconoName = New Data.Linq.Binary(array)

                fs.Close()

            End If
        Catch ex As Exception

        End Try
        
    End Sub
End Class