<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BancoImag_Galeria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BancoImag_Galeria))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.NodeContextStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaCategoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RCCategoriasImageneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblImagenesDe = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblNode = New System.Windows.Forms.Label()
        Me.btnNuevaImagen = New System.Windows.Forms.Button()
        Me.btnEliminarImagen = New System.Windows.Forms.Button()
        Me.txtPersonalizada = New System.Windows.Forms.TextBox()
        Me.btnPersonalizada_Buscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditarImagen = New System.Windows.Forms.Button()
        Me.rb_Galeria = New System.Windows.Forms.RadioButton()
        Me.rb_Personzalizada = New System.Windows.Forms.RadioButton()
        Me.NodeContextStrip.SuspendLayout()
        CType(Me.RCCategoriasImageneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.ContextMenuStrip = Me.NodeContextStrip
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(3, 29)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 1
        Me.TreeView1.Size = New System.Drawing.Size(201, 415)
        Me.TreeView1.TabIndex = 0
        '
        'NodeContextStrip
        '
        Me.NodeContextStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaCategoraToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.NodeContextStrip.Name = "NodeContextStrip"
        Me.NodeContextStrip.Size = New System.Drawing.Size(161, 70)
        '
        'NuevaCategoraToolStripMenuItem
        '
        Me.NuevaCategoraToolStripMenuItem.Name = "NuevaCategoraToolStripMenuItem"
        Me.NuevaCategoraToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.NuevaCategoraToolStripMenuItem.Text = "Nueva categoría"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder.ico")
        Me.ImageList1.Images.SetKeyName(1, "folder_open.ico")
        '
        'RCCategoriasImageneBindingSource
        '
        Me.RCCategoriasImageneBindingSource.DataSource = GetType(RC_Categorias_Imagene)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Categorias"
        '
        'lblImagenesDe
        '
        Me.lblImagenesDe.AutoSize = True
        Me.lblImagenesDe.Location = New System.Drawing.Point(214, 9)
        Me.lblImagenesDe.Name = "lblImagenesDe"
        Me.lblImagenesDe.Size = New System.Drawing.Size(53, 13)
        Me.lblImagenesDe.TabIndex = 5
        Me.lblImagenesDe.Text = "Imágenes"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Image = My.Resources.apply
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(799, 421)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(92, 39)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Seleccionar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Enabled = False
        Me.ListView1.LargeImageList = Me.ImageList2
        Me.ListView1.Location = New System.Drawing.Point(217, 29)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(755, 331)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(128, 128)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Location = New System.Drawing.Point(218, 370)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(754, 39)
        Me.lblDescription.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(157, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.Location = New System.Drawing.Point(180, 2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "X"
        Me.btnRemove.UseVisualStyleBackColor = True
        Me.btnRemove.Visible = False
        '
        'lblNode
        '
        Me.lblNode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNode.AutoSize = True
        Me.lblNode.Location = New System.Drawing.Point(3, 447)
        Me.lblNode.Name = "lblNode"
        Me.lblNode.Size = New System.Drawing.Size(0, 13)
        Me.lblNode.TabIndex = 11
        '
        'btnNuevaImagen
        '
        Me.btnNuevaImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaImagen.Enabled = False
        Me.btnNuevaImagen.Image = My.Resources.add
        Me.btnNuevaImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevaImagen.Location = New System.Drawing.Point(732, 2)
        Me.btnNuevaImagen.Name = "btnNuevaImagen"
        Me.btnNuevaImagen.Size = New System.Drawing.Size(74, 25)
        Me.btnNuevaImagen.TabIndex = 12
        Me.btnNuevaImagen.Text = "Agregar"
        Me.btnNuevaImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevaImagen.UseVisualStyleBackColor = True
        '
        'btnEliminarImagen
        '
        Me.btnEliminarImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarImagen.Enabled = False
        Me.btnEliminarImagen.Image = My.Resources.Delete
        Me.btnEliminarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarImagen.Location = New System.Drawing.Point(896, 2)
        Me.btnEliminarImagen.Name = "btnEliminarImagen"
        Me.btnEliminarImagen.Size = New System.Drawing.Size(74, 25)
        Me.btnEliminarImagen.TabIndex = 12
        Me.btnEliminarImagen.Text = "Eliminar"
        Me.btnEliminarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarImagen.UseVisualStyleBackColor = True
        '
        'txtPersonalizada
        '
        Me.txtPersonalizada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPersonalizada.Location = New System.Drawing.Point(429, 424)
        Me.txtPersonalizada.Name = "txtPersonalizada"
        Me.txtPersonalizada.ReadOnly = True
        Me.txtPersonalizada.Size = New System.Drawing.Size(237, 20)
        Me.txtPersonalizada.TabIndex = 13
        '
        'btnPersonalizada_Buscar
        '
        Me.btnPersonalizada_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPersonalizada_Buscar.Location = New System.Drawing.Point(666, 423)
        Me.btnPersonalizada_Buscar.Name = "btnPersonalizada_Buscar"
        Me.btnPersonalizada_Buscar.Size = New System.Drawing.Size(63, 23)
        Me.btnPersonalizada_Buscar.TabIndex = 15
        Me.btnPersonalizada_Buscar.Text = "Buscar"
        Me.btnPersonalizada_Buscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(897, 421)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 39)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditarImagen
        '
        Me.btnEditarImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarImagen.Enabled = False
        Me.btnEditarImagen.Image = My.Resources.edit
        Me.btnEditarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarImagen.Location = New System.Drawing.Point(814, 2)
        Me.btnEditarImagen.Name = "btnEditarImagen"
        Me.btnEditarImagen.Size = New System.Drawing.Size(74, 25)
        Me.btnEditarImagen.TabIndex = 12
        Me.btnEditarImagen.Text = "Modificar"
        Me.btnEditarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarImagen.UseVisualStyleBackColor = True
        '
        'rb_Galeria
        '
        Me.rb_Galeria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rb_Galeria.AutoSize = True
        Me.rb_Galeria.Checked = True
        Me.rb_Galeria.Location = New System.Drawing.Point(232, 424)
        Me.rb_Galeria.Name = "rb_Galeria"
        Me.rb_Galeria.Size = New System.Drawing.Size(85, 17)
        Me.rb_Galeria.TabIndex = 16
        Me.rb_Galeria.TabStop = True
        Me.rb_Galeria.Text = "Usar Galería"
        Me.rb_Galeria.UseVisualStyleBackColor = True
        '
        'rb_Personzalizada
        '
        Me.rb_Personzalizada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rb_Personzalizada.AutoSize = True
        Me.rb_Personzalizada.Location = New System.Drawing.Point(335, 424)
        Me.rb_Personzalizada.Name = "rb_Personzalizada"
        Me.rb_Personzalizada.Size = New System.Drawing.Size(88, 17)
        Me.rb_Personzalizada.TabIndex = 16
        Me.rb_Personzalizada.Text = "Usar archivo:"
        Me.rb_Personzalizada.UseVisualStyleBackColor = True
        '
        'frm_RevisionesComparativas_NuevaRev_BancoImag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 465)
        Me.Controls.Add(Me.btnEliminarImagen)
        Me.Controls.Add(Me.btnEditarImagen)
        Me.Controls.Add(Me.lblNode)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.rb_Galeria)
        Me.Controls.Add(Me.btnNuevaImagen)
        Me.Controls.Add(Me.rb_Personzalizada)
        Me.Controls.Add(Me.txtPersonalizada)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnPersonalizada_Buscar)
        Me.Controls.Add(Me.lblImagenesDe)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_RevisionesComparativas_NuevaRev_BancoImag"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Galería de Imágenes"
        Me.NodeContextStrip.ResumeLayout(False)
        CType(Me.RCCategoriasImageneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblImagenesDe As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents RCCategoriasImageneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents NodeContextStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaCategoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNode As System.Windows.Forms.Label
    Friend WithEvents btnNuevaImagen As System.Windows.Forms.Button
    Friend WithEvents btnEliminarImagen As System.Windows.Forms.Button
    Friend WithEvents txtPersonalizada As System.Windows.Forms.TextBox
    Friend WithEvents btnPersonalizada_Buscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEditarImagen As System.Windows.Forms.Button
    Friend WithEvents rb_Galeria As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Personzalizada As System.Windows.Forms.RadioButton
End Class
