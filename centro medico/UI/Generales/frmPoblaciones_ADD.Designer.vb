<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoblaciones_ADD
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
        Me.components = New System.ComponentModel.Container
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbFicha = New System.Windows.Forms.TabPage
        Me.N_ProvinciasComboBox = New System.Windows.Forms.ComboBox
        Me.N_PoblacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New CMDataSet
        Me.N_ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreTextBox = New ctrlTextboxAvanzado
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.N_PoblacionesTableAdapter = New CMDataSetTableAdapters.N_PoblacionesTableAdapter
        Me.N_ProvinciasTableAdapter = New CMDataSetTableAdapters.N_ProvinciasTableAdapter
        NombreLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tbFicha.SuspendLayout()
        CType(Me.N_PoblacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(31, 23)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(24, 58)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(54, 13)
        Label1.TabIndex = 2
        Label1.Text = "Provincia:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbFicha)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(342, 136)
        Me.TabControl1.TabIndex = 0
        '
        'tbFicha
        '
        Me.tbFicha.AutoScroll = True
        Me.tbFicha.Controls.Add(Me.N_ProvinciasComboBox)
        Me.tbFicha.Controls.Add(Label1)
        Me.tbFicha.Controls.Add(NombreLabel)
        Me.tbFicha.Controls.Add(Me.NombreTextBox)
        Me.tbFicha.Location = New System.Drawing.Point(4, 22)
        Me.tbFicha.Name = "tbFicha"
        Me.tbFicha.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFicha.Size = New System.Drawing.Size(334, 110)
        Me.tbFicha.TabIndex = 0
        Me.tbFicha.Text = "Ficha"
        Me.tbFicha.UseVisualStyleBackColor = True
        '
        'N_ProvinciasComboBox
        '
        Me.N_ProvinciasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_PoblacionesBindingSource, "ID_Provincia", True))
        Me.N_ProvinciasComboBox.DataSource = Me.N_ProvinciasBindingSource
        Me.N_ProvinciasComboBox.DisplayMember = "Nombre"
        Me.N_ProvinciasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.N_ProvinciasComboBox.Location = New System.Drawing.Point(84, 55)
        Me.N_ProvinciasComboBox.Name = "N_ProvinciasComboBox"
        Me.N_ProvinciasComboBox.Size = New System.Drawing.Size(207, 21)
        Me.N_ProvinciasComboBox.TabIndex = 3
        Me.N_ProvinciasComboBox.ValueMember = "ID_Provincias"
        '
        'N_PoblacionesBindingSource
        '
        Me.N_PoblacionesBindingSource.DataMember = "N_Poblaciones"
        Me.N_PoblacionesBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_ProvinciasBindingSource
        '
        Me.N_ProvinciasBindingSource.DataMember = "N_Provincias"
        Me.N_ProvinciasBindingSource.DataSource = Me.CMDataSet
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PoblacionesBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(84, 20)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(221, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(268, 140)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 1
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'N_PoblacionesTableAdapter
        '
        Me.N_PoblacionesTableAdapter.ClearBeforeFill = True
        '
        'N_ProvinciasTableAdapter
        '
        Me.N_ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'frmPoblaciones_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 169)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmPoblaciones_ADD"
        Me.Text = "Modificar Población"
        Me.TabControl1.ResumeLayout(False)
        Me.tbFicha.ResumeLayout(False)
        Me.tbFicha.PerformLayout()
        CType(Me.N_PoblacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbFicha As System.Windows.Forms.TabPage
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_PoblacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_PoblacionesTableAdapter As CMDataSetTableAdapters.N_PoblacionesTableAdapter
    Friend WithEvents NombreTextBox As ctrlTextboxAvanzado
    Friend WithEvents N_ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_ProvinciasTableAdapter As CMDataSetTableAdapters.N_ProvinciasTableAdapter
    Public WithEvents N_ProvinciasComboBox As System.Windows.Forms.ComboBox
End Class

