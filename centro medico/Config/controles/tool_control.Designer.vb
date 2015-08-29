<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tool_control
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tool_control))
        Me.ts_tool = New System.Windows.Forms.ToolStrip
        Me.ts_open = New System.Windows.Forms.ToolStripButton
        Me.ts_save = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_cut = New System.Windows.Forms.ToolStripButton
        Me.ts_copy = New System.Windows.Forms.ToolStripButton
        Me.ts_paste = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_font = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_bold = New System.Windows.Forms.ToolStripButton
        Me.ts_italic = New System.Windows.Forms.ToolStripButton
        Me.ts_underline = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_left = New System.Windows.Forms.ToolStripButton
        Me.ts_center = New System.Windows.Forms.ToolStripButton
        Me.ts_rigth = New System.Windows.Forms.ToolStripButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.rtb_texto = New System.Windows.Forms.RichTextBox
        Me.ts_tool.SuspendLayout()
        Me.SuspendLayout()
        '
        'ts_tool
        '
        Me.ts_tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_open, Me.ts_save, Me.ToolStripSeparator1, Me.ts_cut, Me.ts_copy, Me.ts_paste, Me.ToolStripSeparator2, Me.ts_font, Me.ToolStripSeparator3, Me.ts_bold, Me.ts_italic, Me.ts_underline, Me.ToolStripSeparator4, Me.ts_left, Me.ts_center, Me.ts_rigth})
        Me.ts_tool.Location = New System.Drawing.Point(0, 0)
        Me.ts_tool.Name = "ts_tool"
        Me.ts_tool.Size = New System.Drawing.Size(401, 25)
        Me.ts_tool.TabIndex = 2
        Me.ts_tool.Text = "ToolStrip1"
        '
        'ts_open
        '
        Me.ts_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_open.Image = CType(resources.GetObject("ts_open.Image"), System.Drawing.Image)
        Me.ts_open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_open.Name = "ts_open"
        Me.ts_open.Size = New System.Drawing.Size(23, 22)
        Me.ts_open.Text = "ToolStripButton1"
        Me.ts_open.ToolTipText = "Open"
        '
        'ts_save
        '
        Me.ts_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_save.Image = CType(resources.GetObject("ts_save.Image"), System.Drawing.Image)
        Me.ts_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_save.Name = "ts_save"
        Me.ts_save.Size = New System.Drawing.Size(23, 22)
        Me.ts_save.Text = "ToolStripButton2"
        Me.ts_save.ToolTipText = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ts_cut
        '
        Me.ts_cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_cut.Image = CType(resources.GetObject("ts_cut.Image"), System.Drawing.Image)
        Me.ts_cut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_cut.Name = "ts_cut"
        Me.ts_cut.Size = New System.Drawing.Size(23, 22)
        Me.ts_cut.Text = "ToolStripButton3"
        Me.ts_cut.ToolTipText = "Cut"
        '
        'ts_copy
        '
        Me.ts_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_copy.Image = CType(resources.GetObject("ts_copy.Image"), System.Drawing.Image)
        Me.ts_copy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_copy.Name = "ts_copy"
        Me.ts_copy.Size = New System.Drawing.Size(23, 22)
        Me.ts_copy.Text = "ToolStripButton4"
        Me.ts_copy.ToolTipText = "Copy"
        '
        'ts_paste
        '
        Me.ts_paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_paste.Image = CType(resources.GetObject("ts_paste.Image"), System.Drawing.Image)
        Me.ts_paste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_paste.Name = "ts_paste"
        Me.ts_paste.Size = New System.Drawing.Size(23, 22)
        Me.ts_paste.Text = "ToolStripButton5"
        Me.ts_paste.ToolTipText = "Paste"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ts_font
        '
        Me.ts_font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_font.Image = CType(resources.GetObject("ts_font.Image"), System.Drawing.Image)
        Me.ts_font.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_font.Name = "ts_font"
        Me.ts_font.Size = New System.Drawing.Size(23, 22)
        Me.ts_font.Text = "ToolStripButton6"
        Me.ts_font.ToolTipText = "Font"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ts_bold
        '
        Me.ts_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_bold.Image = CType(resources.GetObject("ts_bold.Image"), System.Drawing.Image)
        Me.ts_bold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_bold.Name = "ts_bold"
        Me.ts_bold.Size = New System.Drawing.Size(23, 22)
        Me.ts_bold.Text = "ToolStripButton7"
        Me.ts_bold.ToolTipText = "Bold"
        '
        'ts_italic
        '
        Me.ts_italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_italic.Image = CType(resources.GetObject("ts_italic.Image"), System.Drawing.Image)
        Me.ts_italic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_italic.Name = "ts_italic"
        Me.ts_italic.Size = New System.Drawing.Size(23, 22)
        Me.ts_italic.Text = "ToolStripButton8"
        Me.ts_italic.ToolTipText = "Italic"
        '
        'ts_underline
        '
        Me.ts_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_underline.Image = CType(resources.GetObject("ts_underline.Image"), System.Drawing.Image)
        Me.ts_underline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_underline.Name = "ts_underline"
        Me.ts_underline.Size = New System.Drawing.Size(23, 22)
        Me.ts_underline.Text = "ToolStripButton9"
        Me.ts_underline.ToolTipText = "Underline"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ts_left
        '
        Me.ts_left.Checked = True
        Me.ts_left.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ts_left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_left.Image = CType(resources.GetObject("ts_left.Image"), System.Drawing.Image)
        Me.ts_left.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_left.Name = "ts_left"
        Me.ts_left.Size = New System.Drawing.Size(23, 22)
        Me.ts_left.Text = "ToolStripButton10"
        Me.ts_left.ToolTipText = "Left Alignment"
        '
        'ts_center
        '
        Me.ts_center.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_center.Image = CType(resources.GetObject("ts_center.Image"), System.Drawing.Image)
        Me.ts_center.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_center.Name = "ts_center"
        Me.ts_center.Size = New System.Drawing.Size(23, 22)
        Me.ts_center.Text = "ToolStripButton11"
        Me.ts_center.ToolTipText = "Center Alignment"
        '
        'ts_rigth
        '
        Me.ts_rigth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_rigth.Image = CType(resources.GetObject("ts_rigth.Image"), System.Drawing.Image)
        Me.ts_rigth.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_rigth.Name = "ts_rigth"
        Me.ts_rigth.Size = New System.Drawing.Size(23, 22)
        Me.ts_rigth.Text = "ToolStripButton12"
        Me.ts_rigth.ToolTipText = "Rigth Alignment"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'rtb_texto
        '
        Me.rtb_texto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rtb_texto.Location = New System.Drawing.Point(0, 25)
        Me.rtb_texto.Name = "rtb_texto"
        Me.rtb_texto.Size = New System.Drawing.Size(401, 268)
        Me.rtb_texto.TabIndex = 3
        Me.rtb_texto.Text = ""
        '
        'tool_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.rtb_texto)
        Me.Controls.Add(Me.ts_tool)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "tool_control"
        Me.Size = New System.Drawing.Size(401, 293)
        Me.ts_tool.ResumeLayout(False)
        Me.ts_tool.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ts_tool As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_open As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_save As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_cut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_copy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_paste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_font As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_bold As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_italic As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_underline As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_left As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_center As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_rigth As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents rtb_texto As System.Windows.Forms.RichTextBox

End Class
