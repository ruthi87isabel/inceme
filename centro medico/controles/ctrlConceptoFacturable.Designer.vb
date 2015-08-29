<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlConceptoFacturable
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Especialidad = New ctrlTextboxAvanzado
        Me.txt_Nombre = New ctrlTextboxAvanzado
        Me.btn_Deseleccionar = New System.Windows.Forms.Button
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.txt_Codigo = New ctrlTextboxAvanzado
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Importe Tarifa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Concepto:"
        '
        'txt_Especialidad
        '
        Me.txt_Especialidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Especialidad.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_Especialidad.Location = New System.Drawing.Point(319, 20)
        Me.txt_Especialidad.Name = "txt_Especialidad"
        Me.txt_Especialidad.ReadOnly = True
        Me.txt_Especialidad.Size = New System.Drawing.Size(77, 20)
        Me.txt_Especialidad.TabIndex = 5
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_Nombre.Location = New System.Drawing.Point(110, 20)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(207, 20)
        Me.txt_Nombre.TabIndex = 4
        '
        'btn_Deseleccionar
        '
        Me.btn_Deseleccionar.FlatAppearance.BorderSize = 0
        Me.btn_Deseleccionar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btn_Deseleccionar.Location = New System.Drawing.Point(87, 18)
        Me.btn_Deseleccionar.Name = "btn_Deseleccionar"
        Me.btn_Deseleccionar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Deseleccionar.TabIndex = 3
        Me.btn_Deseleccionar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.FlatAppearance.BorderSize = 0
        Me.btn_Buscar.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btn_Buscar.Location = New System.Drawing.Point(65, 18)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(7, 20)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(58, 20)
        Me.txt_Codigo.TabIndex = 1
        '
        'ctrlConceptoFacturable
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
        Me.Name = "ctrlConceptoFacturable"
        Me.Size = New System.Drawing.Size(399, 53)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Especialidad As ctrlTextboxAvanzado
    Friend WithEvents txt_Nombre As ctrlTextboxAvanzado
    Friend WithEvents btn_Deseleccionar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents txt_Codigo As ctrlTextboxAvanzado

End Class
