Imports System.IO
Imports centro_medico.ClasesOdontogramaDataContext
Public Class frmImagen
    Public currentID As Integer = 0
    Private ImageChanged As Boolean = False
    'CARGAR LA IMAGEN
    Private Sub frmImagen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If currentID > 0 Then
            Text = "Modificando imagen asociada a tratamiento"
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim img As md_d_Imagen = classOdontograma.GetImagenByID(currentID)
            tbxDescripcion.Text = img.Descripcion
            pbxImagen.Image = Image.FromStream(New MemoryStream(img.Imagen.ToArray()))
        End If
    End Sub
    'BUSCAR LA IMAGEN
    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
        dlgOpen.Filter = "Ficheros de imagen (*.gif;*.jpg;*.jpeg*.bmp;*.wmf;*.png;)|*.gif;*.jpg;*.jpeg*.bmp;*.wmf;*.png"
        dlgOpen.Title = "Seleccionado imagen"
        If dlgOpen.ShowDialog() = DialogResult.OK Then
            pbxImagen.Image = Image.FromFile(dlgOpen.FileName)
            ImageChanged = True
        End If
    End Sub
    'ACEPTAR LOS CAMBIOS
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If (tbxDescripcion.Text.Trim = "") Or (pbxImagen.Image Is Nothing) Then
            MsgBox("Campos incompletos", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim img As md_d_Imagen
        If currentID = 0 Then
            img = New md_d_Imagen()
            img.Descripcion = tbxDescripcion.Text
            img.Imagen = Image2Bytes(pbxImagen.Image)
            img.Crdt = Date.Now
            classOdontograma.md_d_Imagens.InsertOnSubmit(img)
        Else
            img = classOdontograma.GetImagenByID(currentID)
            img.Descripcion = tbxDescripcion.Text
            img.Crdt = Date.Now
            If ImageChanged = True Then
                Img.Imagen = Image2Bytes(pbxImagen.Image)
            End If
        End If
        Try
            classOdontograma.SubmitChanges()
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MsgBox("Error al salvar imagen: " + ex.ToString())
        End Try
    End Sub
End Class