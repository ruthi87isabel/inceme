<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPaises
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Nombre = New ctrlTextboxAvanzado
        Me.btn_Deseleccionar = New System.Windows.Forms.Button
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.txt_Codigo = New ctrlTextboxAvanzado
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.PAISESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAISESTableAdapter = New centro_medico.CMDataSetTableAdapters.PAISESTableAdapter
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAISESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "País:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_Nombre.Location = New System.Drawing.Point(121, 3)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(272, 20)
        Me.txt_Nombre.TabIndex = 16
        '
        'btn_Deseleccionar
        '
        Me.btn_Deseleccionar.FlatAppearance.BorderSize = 0
        Me.btn_Deseleccionar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btn_Deseleccionar.Location = New System.Drawing.Point(100, 2)
        Me.btn_Deseleccionar.Name = "btn_Deseleccionar"
        Me.btn_Deseleccionar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Deseleccionar.TabIndex = 15
        Me.btn_Deseleccionar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.FlatAppearance.BorderSize = 0
        Me.btn_Buscar.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btn_Buscar.Location = New System.Drawing.Point(79, 2)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Buscar.TabIndex = 14
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(35, 3)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(43, 20)
        Me.txt_Codigo.TabIndex = 13
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PAISESBindingSource
        '
        Me.PAISESBindingSource.DataMember = "PAISES"
        Me.PAISESBindingSource.DataSource = Me.CMDataSet
        '
        'PAISESTableAdapter
        '
        Me.PAISESTableAdapter.ClearBeforeFill = True
        '
        'ctrlPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.btn_Deseleccionar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.txt_Codigo)
        Me.Name = "ctrlPaises"
        Me.Size = New System.Drawing.Size(394, 25)
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAISESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Nombre As ctrlTextboxAvanzado
    Friend WithEvents btn_Deseleccionar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents txt_Codigo As ctrlTextboxAvanzado
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PAISESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PAISESTableAdapter As centro_medico.CMDataSetTableAdapters.PAISESTableAdapter

End Class
