<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlMedico
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
        Me.txt_Codigo = New ctrlTextboxAvanzado()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Deseleccionar = New System.Windows.Forms.Button()
        Me.txt_Nombre = New ctrlTextboxAvanzado()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Especialidad = New ctrlTextboxAvanzado()
        Me.SuspendLayout()
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(0, 21)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(43, 20)
        Me.txt_Codigo.TabIndex = 0
        '
        'btn_Buscar
        '
        Me.btn_Buscar.FlatAppearance.BorderSize = 0
        Me.btn_Buscar.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btn_Buscar.Location = New System.Drawing.Point(43, 20)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Buscar.TabIndex = 1
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Deseleccionar
        '
        Me.btn_Deseleccionar.FlatAppearance.BorderSize = 0
        Me.btn_Deseleccionar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btn_Deseleccionar.Location = New System.Drawing.Point(65, 20)
        Me.btn_Deseleccionar.Name = "btn_Deseleccionar"
        Me.btn_Deseleccionar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Deseleccionar.TabIndex = 1
        Me.btn_Deseleccionar.UseVisualStyleBackColor = True
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_Nombre.Location = New System.Drawing.Point(88, 22)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(194, 20)
        Me.txt_Nombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Médico:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Especialidad"
        '
        'txt_Especialidad
        '
        Me.txt_Especialidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Especialidad.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_Especialidad.Location = New System.Drawing.Point(284, 22)
        Me.txt_Especialidad.Name = "txt_Especialidad"
        Me.txt_Especialidad.ReadOnly = True
        Me.txt_Especialidad.Size = New System.Drawing.Size(170, 20)
        Me.txt_Especialidad.TabIndex = 2
        '
        'ctrlMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Especialidad)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.btn_Deseleccionar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.txt_Codigo)
        Me.Name = "ctrlMedico"
        Me.Size = New System.Drawing.Size(454, 42)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Codigo As ctrlTextboxAvanzado
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Deseleccionar As System.Windows.Forms.Button
    Friend WithEvents txt_Nombre As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Especialidad As ctrlTextboxAvanzado

End Class
