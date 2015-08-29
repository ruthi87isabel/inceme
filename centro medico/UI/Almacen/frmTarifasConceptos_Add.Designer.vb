<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifasConceptos_Add
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
        Dim ImporteLabel As System.Windows.Forms.Label
        Me.ConceptoFacturable = New centro_medico.ctrlConceptoFacturable
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.TarifasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TarifasTableAdapter = New centro_medico.CMDataSetTableAdapters.TarifasTableAdapter
        Me.ImporteTextBox = New System.Windows.Forms.TextBox
        ImporteLabel = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Location = New System.Drawing.Point(9, 90)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(45, 13)
        ImporteLabel.TabIndex = 3
        ImporteLabel.Text = "Importe:"
        '
        'ConceptoFacturable
        '
        Me.ConceptoFacturable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConceptoFacturable.DataBindings.Add(New System.Windows.Forms.Binding("ID_ConceptosFra", Me.TarifasBindingSource, "IdConceptoFra", True))
        Me.ConceptoFacturable.ID_ConceptosFra = Nothing
        Me.ConceptoFacturable.Location = New System.Drawing.Point(12, 12)
        Me.ConceptoFacturable.Name = "ConceptoFacturable"
        Me.ConceptoFacturable.Size = New System.Drawing.Size(399, 53)
        Me.ConceptoFacturable.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(336, 103)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TarifasBindingSource
        '
        Me.TarifasBindingSource.DataMember = "Tarifas"
        Me.TarifasBindingSource.DataSource = Me.CMDataSet
        '
        'TarifasTableAdapter
        '
        Me.TarifasTableAdapter.ClearBeforeFill = True
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "Importe", True))
        Me.ImporteTextBox.Location = New System.Drawing.Point(60, 87)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImporteTextBox.TabIndex = 4
        '
        'frmTarifasConceptos_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 129)
        Me.Controls.Add(ImporteLabel)
        Me.Controls.Add(Me.ImporteTextBox)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.ConceptoFacturable)
        Me.Name = "frmTarifasConceptos_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Concepto Tarifa e Importe"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ConceptoFacturable As centro_medico.ctrlConceptoFacturable
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents TarifasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TarifasTableAdapter As centro_medico.CMDataSetTableAdapters.TarifasTableAdapter
    Friend WithEvents ImporteTextBox As System.Windows.Forms.TextBox
End Class
