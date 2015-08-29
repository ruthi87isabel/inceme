<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlCuentaBancaria
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
        Me.components = New System.ComponentModel.Container()
        Me.txtEntidad = New System.Windows.Forms.MaskedTextBox()
        Me.txtOficina = New System.Windows.Forms.MaskedTextBox()
        Me.txtCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.txtDC = New centro_medico.ctrlTextboxAvanzado()
        Me.pb_Cheq = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTipImg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pb_Cheq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEntidad
        '
        Me.txtEntidad.BeepOnError = True
        Me.txtEntidad.Location = New System.Drawing.Point(1, 16)
        Me.txtEntidad.Mask = "0000"
        Me.txtEntidad.Name = "txtEntidad"
        Me.txtEntidad.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtEntidad.Size = New System.Drawing.Size(43, 20)
        Me.txtEntidad.TabIndex = 0
        Me.txtEntidad.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.txtEntidad.ValidatingType = GetType(Integer)
        '
        'txtOficina
        '
        Me.txtOficina.BeepOnError = True
        Me.txtOficina.Location = New System.Drawing.Point(50, 16)
        Me.txtOficina.Mask = "0000"
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtOficina.Size = New System.Drawing.Size(40, 20)
        Me.txtOficina.TabIndex = 1
        Me.txtOficina.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.txtOficina.ValidatingType = GetType(Integer)
        '
        'txtCuenta
        '
        Me.txtCuenta.BeepOnError = True
        Me.txtCuenta.Location = New System.Drawing.Point(128, 16)
        Me.txtCuenta.Mask = "0000000000"
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtCuenta.Size = New System.Drawing.Size(74, 20)
        Me.txtCuenta.TabIndex = 2
        Me.txtCuenta.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.txtCuenta.ValidatingType = GetType(Integer)
        '
        'txtDC
        '
        Me.txtDC.AcceptsReturn = True
        Me.txtDC.BackColor = System.Drawing.Color.Red
        Me.txtDC.Location = New System.Drawing.Point(96, 16)
        Me.txtDC.Name = "txtDC"
        Me.txtDC.ReadOnly = True
        Me.txtDC.Size = New System.Drawing.Size(26, 20)
        Me.txtDC.TabIndex = 4
        Me.txtDC.TabStop = False
        '
        'pb_Cheq
        '
        Me.pb_Cheq.Image = Global.centro_medico.My.Resources.Resources._24_message_warn
        Me.pb_Cheq.Location = New System.Drawing.Point(205, 17)
        Me.pb_Cheq.Name = "pb_Cheq"
        Me.pb_Cheq.Size = New System.Drawing.Size(16, 16)
        Me.pb_Cheq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Cheq.TabIndex = 2
        Me.pb_Cheq.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Entidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Oficina"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DC"
        '
        'ctrlCuentaBancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtDC)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtOficina)
        Me.Controls.Add(Me.txtEntidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_Cheq)
        Me.Name = "ctrlCuentaBancaria"
        Me.Size = New System.Drawing.Size(231, 39)
        CType(Me.pb_Cheq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEntidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtOficina As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDC As ctrlTextboxAvanzado
    Friend WithEvents pb_Cheq As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTipImg As System.Windows.Forms.ToolTip

End Class
