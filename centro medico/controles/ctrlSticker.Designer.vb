<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlSticker
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
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbExpand = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbExpand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle1
        '
        Me.lblTitle1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitle1.CausesValidation = False
        Me.lblTitle1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.Location = New System.Drawing.Point(0, 13)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Padding = New System.Windows.Forms.Padding(2)
        Me.lblTitle1.Size = New System.Drawing.Size(145, 49)
        Me.lblTitle1.TabIndex = 0
        Me.lblTitle1.Text = "Texto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.BackgroundImage = Global.centro_medico.My.Resources.Resources.textAreaResizeCorner
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.PictureBox1.Location = New System.Drawing.Point(129, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'pbExpand
        '
        Me.pbExpand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbExpand.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.pbExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbExpand.Location = New System.Drawing.Point(133, -1)
        Me.pbExpand.Name = "pbExpand"
        Me.pbExpand.Size = New System.Drawing.Size(12, 11)
        Me.pbExpand.TabIndex = 4
        Me.pbExpand.TabStop = False
        '
        'ctrlSticker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.pbExpand)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ctrlSticker"
        Me.Size = New System.Drawing.Size(145, 62)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbExpand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbExpand As System.Windows.Forms.PictureBox

End Class
