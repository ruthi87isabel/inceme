<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPaciente2
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
        Me.btnVerFicha = New System.Windows.Forms.Button
        Me.txt_Nombre = New ctrlTextboxAvanzado
        Me.btn_Deseleccionar = New System.Windows.Forms.Button
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.txt_Codigo = New ctrlTextboxAvanzado
        Me.SuspendLayout()
        '
        'btnVerFicha
        '
        Me.btnVerFicha.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_frame
        Me.btnVerFicha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerFicha.Enabled = False
        Me.btnVerFicha.FlatAppearance.BorderSize = 0
        Me.btnVerFicha.Location = New System.Drawing.Point(95, 1)
        Me.btnVerFicha.Margin = New System.Windows.Forms.Padding(1)
        Me.btnVerFicha.Name = "btnVerFicha"
        Me.btnVerFicha.Size = New System.Drawing.Size(22, 23)
        Me.btnVerFicha.TabIndex = 103
        Me.btnVerFicha.UseVisualStyleBackColor = True
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.ForeColor = System.Drawing.Color.DarkGray
        Me.txt_Nombre.Location = New System.Drawing.Point(117, 3)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(394, 18)
        Me.txt_Nombre.TabIndex = 102
        Me.txt_Nombre.Text = "Seleccione paciente ...."
        '
        'btn_Deseleccionar
        '
        Me.btn_Deseleccionar.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btn_Deseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Deseleccionar.FlatAppearance.BorderSize = 0
        Me.btn_Deseleccionar.Location = New System.Drawing.Point(74, 1)
        Me.btn_Deseleccionar.Name = "btn_Deseleccionar"
        Me.btn_Deseleccionar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Deseleccionar.TabIndex = 101
        Me.btn_Deseleccionar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.FlatAppearance.BorderSize = 0
        Me.btn_Buscar.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btn_Buscar.Location = New System.Drawing.Point(53, 1)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Buscar.TabIndex = 100
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Codigo.Location = New System.Drawing.Point(1, 3)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(51, 18)
        Me.txt_Codigo.TabIndex = 98
        '
        'ctrlPaciente2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnVerFicha)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.btn_Deseleccionar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.txt_Codigo)
        Me.Name = "ctrlPaciente2"
        Me.Size = New System.Drawing.Size(514, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVerFicha As System.Windows.Forms.Button
    Friend WithEvents txt_Nombre As ctrlTextboxAvanzado
    Friend WithEvents btn_Deseleccionar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents txt_Codigo As ctrlTextboxAvanzado

End Class
