Imports System.IO

Public Class frm_BancoImag_NuevaImagen

    Private Sub frm_BancoImagNuevaImagen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If Not RC_Categorias_ImageneBindingSource.DataSource Is Nothing Then
            Dim imag As RC_Categorias_Imagene = RC_Categorias_ImageneBindingSource.Current
            If Not imag.Image Is Nothing Then
                Dim ms As New MemoryStream(imag.Image.ToArray())
                PictureBox1.Image = Image.FromStream(ms)
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Debe elegir una imagen")
            Return
        End If

        Me.RC_Categorias_ImageneBindingSource.EndEdit()

        Dim imag As RC_Categorias_Imagene = RC_Categorias_ImageneBindingSource.Current
        imag.Image = ImageToByteArray(PictureBox1.Image)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnLoadImage_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadImage.Click
        Dim diag As New OpenFileDialog()
        If diag.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim fs As New IO.FileStream(diag.FileName, IO.FileMode.Open, IO.FileAccess.Read)
            PictureBox1.Image = Image.FromStream(fs)
        End If
    End Sub

    Private Function ImageToByteArray(imageIn As System.Drawing.Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, imageIn.RawFormat)
        Return ms.ToArray()
    End Function

End Class