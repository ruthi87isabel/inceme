Public Class frm_BancoImag_Galeria


    Dim context As CMLinqDataContext
    Dim selectedNode As TreeNode

    Public SelectedRC_Imagen As RC_Categorias_Imagene
    Public _SelectedImagePath As String
    Private SelectedImage As Image

    Public ReadOnly Property SelectedImagePath
        Get
            Return _SelectedImagePath
        End Get
    End Property



    Private Sub frm_RevisionesComparativas_NuevaRev_BancoImag_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        'Dim imagenes As List(Of RC_Categorias_Imagene) = (From r As RC_Categorias_Imagene In context.RC_Categorias_Imagenes _
        '                                                 Select r).ToList()
        'RCCategoriasImageneBindingSource.DataSource = imagenes
        PopulateTree()
    End Sub

    Private Sub PopulateTree()
        context = New CMLinqDataContext

        Dim categorias As List(Of RC_Categorias_GaleriaImagene) = (From c As RC_Categorias_GaleriaImagene In context.RC_Categorias_GaleriaImagenes Where c.ID_Parent Is Nothing Select c).ToList()
        For Each cat As RC_Categorias_GaleriaImagene In categorias
            Dim node As New TreeNode
            node.Name = cat.ID_Categoria.ToString()
            node.Text = cat.Titulo
            node.ToolTipText = cat.Descripcion
            node.Tag = cat
            node.ContextMenuStrip = NodeContextStrip
            TreeView1.Nodes.Add(node)
            AddChildren(node)
        Next
        TreeView1.ExpandAll()
    End Sub

    Private Sub AddChildren(parent As TreeNode)
        Dim idParent As Integer = parent.Tag.ID_Categoria
        Dim categorias As List(Of RC_Categorias_GaleriaImagene) = (From c As RC_Categorias_GaleriaImagene In context.RC_Categorias_GaleriaImagenes _
                                                                           Where c.ID_Parent = idParent Select c).ToList()
        For Each cat As RC_Categorias_GaleriaImagene In categorias
            Dim node As New TreeNode
            node.Name = cat.ID_Categoria.ToString()
            node.Text = cat.Titulo
            node.ToolTipText = cat.Descripcion
            node.Tag = cat
            node.ContextMenuStrip = NodeContextStrip
            parent.Nodes.Add(node)
            AddChildren(node)
        Next
    End Sub

    Private Sub CargaImagenes(node As TreeNode)
        If Not node Is Nothing Then

            lblImagenesDe.Text = "Imagenes de '" & node.FullPath & "'"

            Dim cat As RC_Categorias_GaleriaImagene = node.Tag

            ' Dim imagenes As List(Of RC_Categorias_Imagene) = (From r As RC_Categorias_Imagene In context.RC_Categorias_Imagenes _
            '                                                  Where r.ID_Categoria = cat.ID_Categoria _
            '                                                  Select r).ToList()


            'RCCategoriasImageneBindingSource.DataSource = imagenes

            ListView1.Items.Clear()
            ImageList2.Images.Clear()

            Dim imagenes As New List(Of RC_Categorias_Imagene)

            If node.Parent Is Nothing Then
                imagenes = (From r As RC_Categorias_Imagene In context.RC_Categorias_Imagenes _
                                                            Select r).ToList()
            Else
                imagenes = (From r As RC_Categorias_Imagene In context.RC_Categorias_Imagenes _
                                                            Where r.ID_Categoria = cat.ID_Categoria _
                                                            Select r).ToList()
            End If


            For Each im As RC_Categorias_Imagene In imagenes
                If Not im.Image Is Nothing Then
                    Try
                        Dim ms As New IO.MemoryStream(im.Image.ToArray())
                        Dim image As Image = image.FromStream(ms)

                        ImageList2.Images.Add(im.ID_IMAGEN.ToString(), image)
                        Dim item As New ListViewItem()
                        item.Text = im.Titulo
                        item.Tag = im
                        item.ImageKey = im.ID_IMAGEN.ToString()
                        ListView1.Items.Add(item)
                    Catch ex As Exception

                    End Try

                End If
            Next

        Else
            lblImagenesDe.Text = "Seleccione categoría"

        End If

        btnRemove.Enabled = Not TreeView1.SelectedNode Is Nothing

        ListView1.Enabled = Not TreeView1.SelectedNode Is Nothing
        btnNuevaImagen.Enabled = Not TreeView1.SelectedNode Is Nothing
        'btnEliminarImagen.Enabled = Not TreeView1.SelectedNode Is Nothing
        ListView1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub TreeView1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        CargaImagenes(e.Node)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedIndices.Count > 0 Then
            SelectedRC_Imagen = ListView1.SelectedItems(0).Tag
            lblDescription.Text = SelectedRC_Imagen.Descripcion
            btnEliminarImagen.Enabled = True
            btnAceptar.Enabled = True
            btnEditarImagen.Enabled = True
        Else
            SelectedRC_Imagen = Nothing
            lblDescription.Text = String.Empty
            btnEliminarImagen.Enabled = False
            btnAceptar.Enabled = False
            btnEditarImagen.Enabled = False
        End If
    End Sub

    Private Sub TreeView1_BeforeSelect(sender As System.Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        lblNode.Text = e.Node.Text
    End Sub

    Private Sub NuevaCategoraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaCategoraToolStripMenuItem.Click


        Dim imag As RC_Categorias_GaleriaImagene = New RC_Categorias_GaleriaImagene

        Dim frm As New frm_BancoImag_NuevaCategoria
        frm.RC_Categorias_GaleriaImageneBindingSource.DataSource = imag

        If selectedNode Is Nothing Then
            selectedNode = TreeView1.SelectedNode
        End If

        If Not selectedNode Is Nothing Then
            frm.txtLocacion.Text = selectedNode.FullPath
        End If

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If context.RC_Categorias_GaleriaImagenes.Count > 0 Then
                imag.ID_Categoria = context.RC_Categorias_GaleriaImagenes.Max(Function(o) o.ID_Categoria) + 1
            Else
                imag.ID_Categoria = 0
            End If

            If Not selectedNode Is Nothing Then
                Dim parent As RC_Categorias_GaleriaImagene = selectedNode.Tag
                imag.ID_Parent = parent.ID_Categoria
            End If

            context.RC_Categorias_GaleriaImagenes.InsertOnSubmit(imag)
            context.SubmitChanges()

            Dim nuevoNode As New TreeNode()
            nuevoNode.Text = imag.Titulo
            nuevoNode.Tag = imag
            nuevoNode.ContextMenuStrip = NodeContextStrip


            If TreeView1.Nodes.Count > 0 And Not selectedNode Is Nothing Then
                selectedNode.Nodes.Add(nuevoNode)
                selectedNode.ExpandAll()

            Else
                TreeView1.Nodes.Add(nuevoNode)
            End If

            TreeView1.SelectedNode = nuevoNode

        End If


    End Sub


    Private Sub TreeView1_NodeMouseClick(sender As System.Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        selectedNode = e.Node
    End Sub



    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        If Not selectedNode Is Nothing Then
            If MessageBox.Show("¿Desea eliminar esta categoria, y todas sus subcategorías e imagenes?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                EliminarNodo(selectedNode)
                selectedNode.Remove()
                selectedNode = Nothing
            End If
        End If
        btnRemove.Enabled = Not TreeView1.SelectedNode Is Nothing
        ListView1.Enabled = Not TreeView1.SelectedNode Is Nothing
        btnNuevaImagen.Enabled = Not TreeView1.SelectedNode Is Nothing
        'btnEliminarImagen.Enabled = Not TreeView1.SelectedNode Is Nothing

    End Sub

    Private Sub EliminarNodo(ByRef toDelete As TreeNode)
        If toDelete Is Nothing Then
            Return
        End If

        For Each node As TreeNode In toDelete.Nodes
            EliminarNodo(node)
        Next

        Dim rc_categ As RC_Categorias_GaleriaImagene = toDelete.Tag
        'Eliminar imagenes
        Dim images As List(Of RC_Categorias_Imagene) = (From img In context.RC_Categorias_Imagenes Where img.ID_Categoria = rc_categ.ID_Categoria Select img).ToList()
        For Each img As RC_Categorias_Imagene In images
            context.RC_Categorias_Imagenes.DeleteOnSubmit(img)
        Next
        context.SubmitChanges()

        'Eliminar la categoria
        context.RC_Categorias_GaleriaImagenes.DeleteOnSubmit(rc_categ)
        context.SubmitChanges()

        'Eliminar el nodo del treeview
        'toDelete.Remove()

    End Sub


    Private Sub EditarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        If Not selectedNode Is Nothing Then
            Dim frm As New frm_BancoImag_NuevaCategoria()
            frm.RC_Categorias_GaleriaImageneBindingSource.DataSource = selectedNode.Tag
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                context.SubmitChanges()
                selectedNode.Text = frm.RC_Categorias_GaleriaImageneBindingSource.Current.Titulo
            End If
        End If

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        NuevaCategoraToolStripMenuItem_Click(Nothing, Nothing)
    End Sub


    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        If TreeView1.Nodes.Count > 0 Then
            EliminarToolStripMenuItem_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub btnNuevaImagen_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevaImagen.Click
        Dim imag As New RC_Categorias_Imagene
        imag.ID_Categoria = selectedNode.Tag.ID_Categoria

        If context.RC_Categorias_Imagenes.Count = 0 Then
            imag.ID_IMAGEN = 1
        Else
            imag.ID_IMAGEN = context.RC_Categorias_Imagenes.Max(Function(o) o.ID_IMAGEN) + 1
        End If

        Dim frm As New frm_BancoImag_NuevaImagen()
        frm.RC_Categorias_ImageneBindingSource.DataSource = imag
        frm.txtCategoria.Text = selectedNode.FullPath
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            context.RC_Categorias_Imagenes.InsertOnSubmit(imag)
            context.SubmitChanges()
        End If
        CargaImagenes(selectedNode)
    End Sub

    Private Sub btnEliminarImagen_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarImagen.Click
        If Not SelectedRC_Imagen Is Nothing Then
            If MessageBox.Show("¿Desea eliminar esta imagen '" & SelectedRC_Imagen.Titulo & "' de la galería?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                context.RC_Categorias_Imagenes.DeleteOnSubmit(SelectedRC_Imagen)
                context.SubmitChanges()
                CargaImagenes(selectedNode)
            End If
        End If

    End Sub

    Private Sub btnEditarImagen_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarImagen.Click
        If Not SelectedRC_Imagen Is Nothing Then
            Dim frm As New frm_BancoImag_NuevaImagen()
            frm.RC_Categorias_ImageneBindingSource.DataSource = SelectedRC_Imagen
            If Not selectedNode Is Nothing Then
                frm.txtCategoria.Text = selectedNode.FullPath
            End If

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                context.SubmitChanges()
                CargaImagenes(selectedNode)
            End If

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.SelectedRC_Imagen = Nothing
        Me.SelectedImage = Nothing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    Private Sub btnPersonalizada_Buscar_Click(sender As System.Object, e As System.EventArgs) Handles btnPersonalizada_Buscar.Click
        Dim diag As New OpenFileDialog()
        If diag.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Dim fs As New IO.FileStream(diag.FileName, IO.FileMode.Open, IO.FileAccess.Read)
            'SelectedImage = Image.FromStream(fs)
            'fs.Close()
            'txtPersonalizada.Text = IO.Path.GetFileName(diag.FileName)
            txtPersonalizada.Text = IO.Path.GetFileName(diag.FileName)
            _SelectedImagePath = diag.FileName
            btnAceptar.Enabled = True
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If rb_Galeria.Checked Then
            Dim ms As New IO.MemoryStream(SelectedRC_Imagen.Image.ToArray())
            SelectedImage = Image.FromStream(ms)
            If Not SelectedImage Is Nothing Then
                Dim tempImage As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\" & Date.Now.Ticks & ".jpg"
                SelectedImage.Save(tempImage)
                Dim fs As New System.IO.FileStream(tempImage, IO.FileMode.Open, IO.FileAccess.Read)
                Dim arr(fs.Length) As Byte
                fs.Read(arr, 0, fs.Length)
                fs.Close()
                _SelectedImagePath = tempImage
            End If
        Else
            'SelectedImage = Image.FromFile(txtPersonalizada.Text)
            'If Not SelectedImage Is Nothing Then
            '    Dim tempImage As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\temp.jpg"
            '    SelectedImage.Save(tempImage)
            '    Dim fs As New System.IO.FileStream(tempImage, IO.FileMode.Open, IO.FileAccess.Read)
            '    Dim arr(fs.Length) As Byte
            '    fs.Read(arr, 0, fs.Length)
            '    fs.Close()
            '    _SelectedImagePath = tempImage
            'End If
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub rb_Galeria_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_Galeria.CheckedChanged
        If rb_Galeria.Checked Then
            TreeView1.Enabled = True
            ListView1.Enabled = True
            btnEditarImagen.Enabled = True
            btnNuevaImagen.Enabled = True
            btnEliminarImagen.Enabled = True
            btnPersonalizada_Buscar.Enabled = False
        End If
    End Sub

    Private Sub rb_Personzalizada_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_Personzalizada.CheckedChanged
        If rb_Personzalizada.Checked Then
            TreeView1.Enabled = False
            ListView1.Enabled = False
            btnEditarImagen.Enabled = False
            btnNuevaImagen.Enabled = False
            btnEliminarImagen.Enabled = False
            btnPersonalizada_Buscar.Enabled = True
            btnAceptar.Enabled = txtPersonalizada.Text <> String.Empty
        End If
    End Sub
End Class