<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlImageWithStickers
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlImageWithStickers))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnCambiarImagen = New System.Windows.Forms.Button()
        Me.tsOpciones = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstAnnadir = New System.Windows.Forms.ToolStripButton()
        Me.tstEliminar = New System.Windows.Forms.ToolStripButton()
        Me.CtrlMyPanel1 = New centro_medico.ctrlMyPanel()
        Me.tsbQuitarImagen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(4, 648)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 13)
        Me.lblInfo.TabIndex = 18
        '
        'btnCambiarImagen
        '
        Me.btnCambiarImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCambiarImagen.Image = Global.centro_medico.My.Resources.Resources._24_image_open
        Me.btnCambiarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCambiarImagen.Location = New System.Drawing.Point(703, 3)
        Me.btnCambiarImagen.Name = "btnCambiarImagen"
        Me.btnCambiarImagen.Size = New System.Drawing.Size(119, 30)
        Me.btnCambiarImagen.TabIndex = 22
        Me.btnCambiarImagen.Text = "Cambiar imagen"
        Me.btnCambiarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCambiarImagen.UseVisualStyleBackColor = True
        Me.btnCambiarImagen.Visible = False
        '
        'tsOpciones
        '
        Me.tsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tstAnnadir, Me.tstEliminar, Me.ToolStripSeparator1, Me.tsbQuitarImagen})
        Me.tsOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsOpciones.Name = "tsOpciones"
        Me.tsOpciones.Size = New System.Drawing.Size(825, 25)
        Me.tsOpciones.TabIndex = 23
        Me.tsOpciones.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripLabel1.Text = "Cuadros de notas:"
        '
        'tstAnnadir
        '
        Me.tstAnnadir.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstAnnadir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstAnnadir.Name = "tstAnnadir"
        Me.tstAnnadir.Size = New System.Drawing.Size(58, 22)
        Me.tstAnnadir.Text = "Añadir"
        '
        'tstEliminar
        '
        Me.tstEliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tstEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstEliminar.Name = "tstEliminar"
        Me.tstEliminar.Size = New System.Drawing.Size(63, 22)
        Me.tstEliminar.Text = "Eliminar"
        '
        'CtrlMyPanel1
        '
        Me.CtrlMyPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlMyPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CtrlMyPanel1.Location = New System.Drawing.Point(-1, 25)
        Me.CtrlMyPanel1.Name = "CtrlMyPanel1"
        Me.CtrlMyPanel1.Size = New System.Drawing.Size(827, 620)
        Me.CtrlMyPanel1.TabIndex = 19
        '
        'tsbQuitarImagen
        '
        Me.tsbQuitarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbQuitarImagen.Image = CType(resources.GetObject("tsbQuitarImagen.Image"), System.Drawing.Image)
        Me.tsbQuitarImagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarImagen.Name = "tsbQuitarImagen"
        Me.tsbQuitarImagen.Size = New System.Drawing.Size(80, 22)
        Me.tsbQuitarImagen.Text = "Quitar Imagen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ctrlImageWithStickers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.btnCambiarImagen)
        Me.Controls.Add(Me.tsOpciones)
        Me.Controls.Add(Me.CtrlMyPanel1)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "ctrlImageWithStickers"
        Me.Size = New System.Drawing.Size(825, 664)
        Me.tsOpciones.ResumeLayout(False)
        Me.tsOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents CtrlMyPanel1 As ctrlMyPanel
    'Private WithEvents dragControl1 As draggableControls.Resources.DragControl
    Friend WithEvents btnCambiarImagen As System.Windows.Forms.Button
    Friend WithEvents tstEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstAnnadir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Public WithEvents tsOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbQuitarImagen As System.Windows.Forms.ToolStripButton


End Class
