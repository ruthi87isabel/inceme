<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_password
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
        Dim USUARIOLabel As System.Windows.Forms.Label
        Dim CONTRASENALabel As System.Windows.Forms.Label
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.tb_user = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_contrasena = New centro_medico.ctrlTextboxAvanzado()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Contrasenna = New System.Windows.Forms.Label()
        Me.lbl_Version = New System.Windows.Forms.Label()
        USUARIOLabel = New System.Windows.Forms.Label()
        CONTRASENALabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USUARIOLabel
        '
        USUARIOLabel.AutoSize = True
        USUARIOLabel.BackColor = System.Drawing.Color.Gainsboro
        USUARIOLabel.Location = New System.Drawing.Point(111, 57)
        USUARIOLabel.Name = "USUARIOLabel"
        USUARIOLabel.Size = New System.Drawing.Size(46, 13)
        USUARIOLabel.TabIndex = 93
        USUARIOLabel.Text = "Usuario:"
        '
        'CONTRASENALabel
        '
        CONTRASENALabel.AutoSize = True
        CONTRASENALabel.BackColor = System.Drawing.Color.Gainsboro
        CONTRASENALabel.Location = New System.Drawing.Point(111, 104)
        CONTRASENALabel.Name = "CONTRASENALabel"
        CONTRASENALabel.Size = New System.Drawing.Size(64, 13)
        CONTRASENALabel.TabIndex = 95
        CONTRASENALabel.Text = "Contraseña:"
        '
        'bt_cancel
        '
        Me.bt_cancel.BackColor = System.Drawing.Color.Gainsboro
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(161, 162)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(61, 28)
        Me.bt_cancel.TabIndex = 4
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.UseVisualStyleBackColor = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(85, 162)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(61, 28)
        Me.bt_aceptar.TabIndex = 2
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.UseVisualStyleBackColor = False
        '
        'tb_user
        '
        Me.tb_user.AcceptsReturn = True
        Me.tb_user.Location = New System.Drawing.Point(114, 73)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(95, 20)
        Me.tb_user.TabIndex = 0
        '
        'tb_contrasena
        '
        Me.tb_contrasena.AcceptsReturn = True
        Me.tb_contrasena.Location = New System.Drawing.Point(114, 120)
        Me.tb_contrasena.Name = "tb_contrasena"
        Me.tb_contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_contrasena.Size = New System.Drawing.Size(95, 20)
        Me.tb_contrasena.TabIndex = 1
        Me.tb_contrasena.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.centro_medico.My.Resources.Resources.estetoscopio
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 202)
        Me.PictureBox1.TabIndex = 97
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "INCEME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label2.Location = New System.Drawing.Point(119, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 12)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Información Centros Médicos"
        '
        'lbl_Contrasenna
        '
        Me.lbl_Contrasenna.AutoSize = True
        Me.lbl_Contrasenna.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Contrasenna.ForeColor = System.Drawing.Color.Red
        Me.lbl_Contrasenna.Location = New System.Drawing.Point(111, 143)
        Me.lbl_Contrasenna.Name = "lbl_Contrasenna"
        Me.lbl_Contrasenna.Size = New System.Drawing.Size(111, 13)
        Me.lbl_Contrasenna.TabIndex = 100
        Me.lbl_Contrasenna.Text = "Contraseña incorrecta"
        Me.lbl_Contrasenna.Visible = False
        '
        'lbl_Version
        '
        Me.lbl_Version.AutoSize = True
        Me.lbl_Version.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Version.Location = New System.Drawing.Point(11, 160)
        Me.lbl_Version.Name = "lbl_Version"
        Me.lbl_Version.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Version.TabIndex = 101
        Me.lbl_Version.Text = "v1.0.0.0"
        '
        'form_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Version)
        Me.Controls.Add(Me.lbl_Contrasenna)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(USUARIOLabel)
        Me.Controls.Add(Me.tb_user)
        Me.Controls.Add(CONTRASENALabel)
        Me.Controls.Add(Me.tb_contrasena)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_password"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso de usuario"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents tb_user As ctrlTextboxAvanzado
    Friend WithEvents tb_contrasena As ctrlTextboxAvanzado
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Contrasenna As System.Windows.Forms.Label
    Friend WithEvents lbl_Version As System.Windows.Forms.Label
End Class
