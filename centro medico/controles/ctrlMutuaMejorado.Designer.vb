<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlMutuaMejorado
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
        Me.components = New System.ComponentModel.Container()
        Me.txt_Nombre = New centro_medico.ctrlTextboxAvanzado()
        Me.btn_Deseleccionar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Codigo = New centro_medico.ctrlTextboxAvanzado()
        Me.lblMutua = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_Nombre
        '
        Me.txt_Nombre.AcceptsReturn = True
        Me.txt_Nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_Nombre.Location = New System.Drawing.Point(143, 1)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(317, 20)
        Me.txt_Nombre.TabIndex = 15
        '
        'btn_Deseleccionar
        '
        Me.btn_Deseleccionar.FlatAppearance.BorderSize = 0
        Me.btn_Deseleccionar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btn_Deseleccionar.Location = New System.Drawing.Point(115, -1)
        Me.btn_Deseleccionar.Name = "btn_Deseleccionar"
        Me.btn_Deseleccionar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Deseleccionar.TabIndex = 13
        Me.btn_Deseleccionar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.FlatAppearance.BorderSize = 0
        Me.btn_Buscar.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btn_Buscar.Location = New System.Drawing.Point(94, -1)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Buscar.TabIndex = 14
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.AcceptsReturn = True
        Me.txt_Codigo.Location = New System.Drawing.Point(47, 1)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(43, 20)
        Me.txt_Codigo.TabIndex = 12
        '
        'lblMutua
        '
        Me.lblMutua.AutoSize = True
        Me.lblMutua.Location = New System.Drawing.Point(1, 4)
        Me.lblMutua.Name = "lblMutua"
        Me.lblMutua.Size = New System.Drawing.Size(40, 13)
        Me.lblMutua.TabIndex = 16
        Me.lblMutua.Text = "Mutua:"
        '
        'ctrlMutuaMejorado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblMutua)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.btn_Deseleccionar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.txt_Codigo)
        Me.Name = "ctrlMutuaMejorado"
        Me.Size = New System.Drawing.Size(463, 21)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Nombre As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents btn_Deseleccionar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents txt_Codigo As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents lblMutua As System.Windows.Forms.Label

End Class
