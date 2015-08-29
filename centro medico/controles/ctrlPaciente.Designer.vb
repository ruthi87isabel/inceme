<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPaciente
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
        Me.lbl_DNI = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Deseleccionar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btnVerFicha = New System.Windows.Forms.Button()
        Me.pb_Imagen = New System.Windows.Forms.PictureBox()
        Me.lblAsociado = New System.Windows.Forms.Label()
        Me.lblBeneficiario = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txt_Nombre = New centro_medico.ctrlTextboxAvanzado()
        Me.txt_CP = New centro_medico.ctrlTextboxAvanzado()
        Me.txt_Codigo = New centro_medico.ctrlTextboxAvanzado()
        Me.lblFechaValidoSocio = New System.Windows.Forms.Label()
        CType(Me.pb_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_DNI
        '
        Me.lbl_DNI.AutoSize = True
        Me.lbl_DNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DNI.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_DNI.Location = New System.Drawing.Point(321, 2)
        Me.lbl_DNI.Name = "lbl_DNI"
        Me.lbl_DNI.Size = New System.Drawing.Size(82, 13)
        Me.lbl_DNI.TabIndex = 92
        Me.lbl_DNI.Text = "DNI:12345678Z"
        Me.lbl_DNI.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "C. Propio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "C. Paciente"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Deseleccionar
        '
        Me.btn_Deseleccionar.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btn_Deseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Deseleccionar.FlatAppearance.BorderSize = 0
        Me.btn_Deseleccionar.Location = New System.Drawing.Point(168, 17)
        Me.btn_Deseleccionar.Name = "btn_Deseleccionar"
        Me.btn_Deseleccionar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Deseleccionar.TabIndex = 95
        Me.btn_Deseleccionar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.FlatAppearance.BorderSize = 0
        Me.btn_Buscar.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btn_Buscar.Location = New System.Drawing.Point(147, 17)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Buscar.TabIndex = 94
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btnVerFicha
        '
        Me.btnVerFicha.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_frame
        Me.btnVerFicha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerFicha.Enabled = False
        Me.btnVerFicha.FlatAppearance.BorderSize = 0
        Me.btnVerFicha.Location = New System.Drawing.Point(189, 17)
        Me.btnVerFicha.Margin = New System.Windows.Forms.Padding(1)
        Me.btnVerFicha.Name = "btnVerFicha"
        Me.btnVerFicha.Size = New System.Drawing.Size(22, 23)
        Me.btnVerFicha.TabIndex = 97
        Me.btnVerFicha.UseVisualStyleBackColor = True
        '
        'pb_Imagen
        '
        Me.pb_Imagen.BackColor = System.Drawing.Color.Transparent
        Me.pb_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_Imagen.Image = Global.centro_medico.My.Resources.Resources.pacienteSingular
        Me.pb_Imagen.Location = New System.Drawing.Point(0, 4)
        Me.pb_Imagen.Name = "pb_Imagen"
        Me.pb_Imagen.Size = New System.Drawing.Size(42, 46)
        Me.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Imagen.TabIndex = 91
        Me.pb_Imagen.TabStop = False
        '
        'lblAsociado
        '
        Me.lblAsociado.AutoSize = True
        Me.lblAsociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsociado.ForeColor = System.Drawing.Color.Purple
        Me.lblAsociado.Location = New System.Drawing.Point(180, 3)
        Me.lblAsociado.Name = "lblAsociado"
        Me.lblAsociado.Size = New System.Drawing.Size(50, 13)
        Me.lblAsociado.TabIndex = 93
        Me.lblAsociado.Text = "Asociado"
        Me.lblAsociado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAsociado.Visible = False
        '
        'lblBeneficiario
        '
        Me.lblBeneficiario.AutoSize = True
        Me.lblBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeneficiario.ForeColor = System.Drawing.Color.Blue
        Me.lblBeneficiario.Location = New System.Drawing.Point(175, 2)
        Me.lblBeneficiario.Name = "lblBeneficiario"
        Me.lblBeneficiario.Size = New System.Drawing.Size(61, 13)
        Me.lblBeneficiario.TabIndex = 93
        Me.lblBeneficiario.Text = "Beneficiario"
        Me.lblBeneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBeneficiario.Visible = False
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(48, 40)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(16, 13)
        Me.lblFechaNacimiento.TabIndex = 98
        Me.lblFechaNacimiento.Text = "..."
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(186, 40)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(16, 13)
        Me.lblTelefono.TabIndex = 99
        Me.lblTelefono.Text = "..."
        '
        'txt_Nombre
        '
        Me.txt_Nombre.AcceptsReturn = True
        Me.txt_Nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.ForeColor = System.Drawing.Color.DarkGray
        Me.txt_Nombre.Location = New System.Drawing.Point(211, 19)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(196, 18)
        Me.txt_Nombre.TabIndex = 96
        Me.txt_Nombre.Text = "Seleccione paciente ...."
        '
        'txt_CP
        '
        Me.txt_CP.AcceptsReturn = True
        Me.txt_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CP.Location = New System.Drawing.Point(50, 19)
        Me.txt_CP.Name = "txt_CP"
        Me.txt_CP.Size = New System.Drawing.Size(42, 18)
        Me.txt_CP.TabIndex = 91
        '
        'txt_Codigo
        '
        Me.txt_Codigo.AcceptsReturn = True
        Me.txt_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Codigo.Location = New System.Drawing.Point(96, 19)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(51, 18)
        Me.txt_Codigo.TabIndex = 90
        '
        'lblFechaValidoSocio
        '
        Me.lblFechaValidoSocio.AutoSize = True
        Me.lblFechaValidoSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaValidoSocio.ForeColor = System.Drawing.Color.Blue
        Me.lblFechaValidoSocio.Location = New System.Drawing.Point(237, 2)
        Me.lblFechaValidoSocio.Name = "lblFechaValidoSocio"
        Me.lblFechaValidoSocio.Size = New System.Drawing.Size(16, 13)
        Me.lblFechaValidoSocio.TabIndex = 100
        Me.lblFechaValidoSocio.Text = "..."
        Me.lblFechaValidoSocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFechaValidoSocio.Visible = False
        '
        'ctrlPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblFechaValidoSocio)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.btnVerFicha)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.btn_Deseleccionar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.lblBeneficiario)
        Me.Controls.Add(Me.lblAsociado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_DNI)
        Me.Controls.Add(Me.pb_Imagen)
        Me.Controls.Add(Me.txt_CP)
        Me.Controls.Add(Me.txt_Codigo)
        Me.Name = "ctrlPaciente"
        Me.Size = New System.Drawing.Size(407, 61)
        CType(Me.pb_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Codigo As ctrlTextboxAvanzado
    Friend WithEvents txt_CP As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Nombre As ctrlTextboxAvanzado
    Friend WithEvents btn_Deseleccionar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Public WithEvents lbl_DNI As System.Windows.Forms.Label
    Friend WithEvents btnVerFicha As System.Windows.Forms.Button
    Friend WithEvents pb_Imagen As System.Windows.Forms.PictureBox
    Friend WithEvents lblAsociado As System.Windows.Forms.Label
    Friend WithEvents lblBeneficiario As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblFechaValidoSocio As System.Windows.Forms.Label

End Class
