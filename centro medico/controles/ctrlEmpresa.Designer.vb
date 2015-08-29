<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlEmpresa
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
        Me.txt_Nombre = New centro_medico.ctrlTextboxAvanzado()
        Me.btn_Deseleccionar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Codigo = New centro_medico.ctrlTextboxAvanzado()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Nombre
        '
        Me.txt_Nombre.AcceptsReturn = True
        Me.txt_Nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_Nombre.Location = New System.Drawing.Point(142, 2)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(238, 20)
        Me.txt_Nombre.TabIndex = 6
        '
        'btn_Deseleccionar
        '
        Me.btn_Deseleccionar.FlatAppearance.BorderSize = 0
        Me.btn_Deseleccionar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btn_Deseleccionar.Location = New System.Drawing.Point(121, 1)
        Me.btn_Deseleccionar.Name = "btn_Deseleccionar"
        Me.btn_Deseleccionar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Deseleccionar.TabIndex = 5
        Me.btn_Deseleccionar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.FlatAppearance.BorderSize = 0
        Me.btn_Buscar.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btn_Buscar.Location = New System.Drawing.Point(100, 1)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Buscar.TabIndex = 4
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.AcceptsReturn = True
        Me.txt_Codigo.Location = New System.Drawing.Point(56, 2)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(43, 20)
        Me.txt_Codigo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Empresa:"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'EMPRESASTableAdapter
        '
        Me.EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'ctrlEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.btn_Deseleccionar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.txt_Codigo)
        Me.Name = "ctrlEmpresa"
        Me.Size = New System.Drawing.Size(383, 25)
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Nombre As ctrlTextboxAvanzado
    Friend WithEvents btn_Deseleccionar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents txt_Codigo As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter

End Class
