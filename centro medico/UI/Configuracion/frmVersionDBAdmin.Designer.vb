<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVersionDBAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVersionDBAdmin))
        Dim ValorLabel As System.Windows.Forms.Label
        Dim ClaveLabel As System.Windows.Forms.Label
        Me.CM3DataSet = New centro_medico.CM3DataSet
        Me.VariablesGlobalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VariablesGlobalesTableAdapter = New centro_medico.CM3DataSetTableAdapters.VariablesGlobalesTableAdapter
        Me.VariablesGlobalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.VariablesGlobalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        ValorLabel = New System.Windows.Forms.Label
        ClaveLabel = New System.Windows.Forms.Label
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariablesGlobalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariablesGlobalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VariablesGlobalesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CM3DataSet
        '
        Me.CM3DataSet.DataSetName = "CM3DataSet"
        Me.CM3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VariablesGlobalesBindingSource
        '
        Me.VariablesGlobalesBindingSource.DataMember = "VariablesGlobales"
        Me.VariablesGlobalesBindingSource.DataSource = Me.CM3DataSet
        '
        'VariablesGlobalesTableAdapter
        '
        Me.VariablesGlobalesTableAdapter.ClearBeforeFill = True
        '
        'VariablesGlobalesBindingNavigator
        '
        Me.VariablesGlobalesBindingNavigator.AddNewItem = Nothing
        Me.VariablesGlobalesBindingNavigator.BindingSource = Me.VariablesGlobalesBindingSource
        Me.VariablesGlobalesBindingNavigator.CountItem = Nothing
        Me.VariablesGlobalesBindingNavigator.DeleteItem = Nothing
        Me.VariablesGlobalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VariablesGlobalesBindingNavigatorSaveItem})
        Me.VariablesGlobalesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VariablesGlobalesBindingNavigator.MoveFirstItem = Nothing
        Me.VariablesGlobalesBindingNavigator.MoveLastItem = Nothing
        Me.VariablesGlobalesBindingNavigator.MoveNextItem = Nothing
        Me.VariablesGlobalesBindingNavigator.MovePreviousItem = Nothing
        Me.VariablesGlobalesBindingNavigator.Name = "VariablesGlobalesBindingNavigator"
        Me.VariablesGlobalesBindingNavigator.PositionItem = Nothing
        Me.VariablesGlobalesBindingNavigator.Size = New System.Drawing.Size(209, 25)
        Me.VariablesGlobalesBindingNavigator.TabIndex = 0
        Me.VariablesGlobalesBindingNavigator.Text = "Guardar"
        '
        'VariablesGlobalesBindingNavigatorSaveItem
        '
        Me.VariablesGlobalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("VariablesGlobalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VariablesGlobalesBindingNavigatorSaveItem.Name = "VariablesGlobalesBindingNavigatorSaveItem"
        Me.VariablesGlobalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(69, 22)
        Me.VariablesGlobalesBindingNavigatorSaveItem.Text = "Guardar"
        Me.VariablesGlobalesBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(20, 70)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 3
        ValorLabel.Text = "Valor:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VariablesGlobalesBindingSource, "Valor", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(63, 70)
        Me.MaskedTextBox1.Mask = "0.0.0.0"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 4
        '
        'ClaveLabel
        '
        ClaveLabel.AutoSize = True
        ClaveLabel.Location = New System.Drawing.Point(20, 44)
        ClaveLabel.Name = "ClaveLabel"
        ClaveLabel.Size = New System.Drawing.Size(129, 13)
        ClaveLabel.TabIndex = 1
        ClaveLabel.Text = "Version mínima requerida:"
        '
        'frmVersionDBAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 116)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(ClaveLabel)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.VariablesGlobalesBindingNavigator)
        Me.Name = "frmVersionDBAdmin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Version Minima"
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariablesGlobalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariablesGlobalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VariablesGlobalesBindingNavigator.ResumeLayout(False)
        Me.VariablesGlobalesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CM3DataSet As centro_medico.CM3DataSet
    Friend WithEvents VariablesGlobalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VariablesGlobalesTableAdapter As centro_medico.CM3DataSetTableAdapters.VariablesGlobalesTableAdapter
    Friend WithEvents VariablesGlobalesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents VariablesGlobalesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
End Class
