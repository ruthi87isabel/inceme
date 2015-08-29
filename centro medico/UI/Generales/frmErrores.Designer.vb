<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErrores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.txtMessage = New centro_medico.ctrlTextboxAvanzado()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_Enviar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtStackTrace = New centro_medico.ctrlTextboxAvanzado()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtInnerException = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.AcceptsReturn = True
        Me.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMessage.Location = New System.Drawing.Point(3, 3)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(429, 306)
        Me.txtMessage.TabIndex = 0
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Close.Location = New System.Drawing.Point(376, 379)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 30)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.Text = "Cerrar"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'btn_Enviar
        '
        Me.btn_Enviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Enviar.Image = Global.centro_medico.My.Resources.Resources._24_frame_open
        Me.btn_Enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Enviar.Location = New System.Drawing.Point(2, 378)
        Me.btn_Enviar.Name = "btn_Enviar"
        Me.btn_Enviar.Size = New System.Drawing.Size(158, 33)
        Me.btn_Enviar.TabIndex = 1
        Me.btn_Enviar.Text = "Enviar a soporte técnico"
        Me.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Enviar.UseVisualStyleBackColor = True
        Me.btn_Enviar.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(8, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(443, 338)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtMessage)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(435, 312)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mensaje"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtStackTrace)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(435, 312)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "StackTrace"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtStackTrace
        '
        Me.txtStackTrace.AcceptsReturn = True
        Me.txtStackTrace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStackTrace.Location = New System.Drawing.Point(3, 3)
        Me.txtStackTrace.Multiline = True
        Me.txtStackTrace.Name = "txtStackTrace"
        Me.txtStackTrace.ReadOnly = True
        Me.txtStackTrace.Size = New System.Drawing.Size(429, 306)
        Me.txtStackTrace.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.centro_medico.My.Resources.Resources._24_message_warn
        Me.PictureBox1.Location = New System.Drawing.Point(8, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(38, 9)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(290, 13)
        Me.lbl_Msg.TabIndex = 4
        Me.lbl_Msg.Text = "Ha ocurrido un error!!, contacte a soporte técnico"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtInnerException)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(435, 312)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Inner Exception"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtInnerException
        '
        Me.txtInnerException.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInnerException.Location = New System.Drawing.Point(3, 3)
        Me.txtInnerException.Multiline = True
        Me.txtInnerException.Name = "txtInnerException"
        Me.txtInnerException.ReadOnly = True
        Me.txtInnerException.Size = New System.Drawing.Size(429, 306)
        Me.txtInnerException.TabIndex = 0
        '
        'frmErrores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 413)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_Enviar)
        Me.Controls.Add(Me.btn_Close)
        Me.Name = "frmErrores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensaje"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessage As ctrlTextboxAvanzado
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Enviar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtStackTrace As ctrlTextboxAvanzado
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtInnerException As System.Windows.Forms.TextBox
End Class
