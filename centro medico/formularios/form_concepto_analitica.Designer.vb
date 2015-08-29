<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_concepto_analitica
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
        Dim CONCEPTOLabel As System.Windows.Forms.Label
        'Dim IMPORTELabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.tb_concepto = New ctrlTextboxAvanzado
        Me.CONCEPTOSANALITICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_importe = New ctrlTextboxAvanzado
        Me.tb_notas = New ctrlTextboxAvanzado
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.CONCEPTOSANALITICATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSANALITICATableAdapter
        CONCEPTOLabel = New System.Windows.Forms.Label
        IMPORTELabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CONCEPTOLabel
        '
        CONCEPTOLabel.AutoSize = True
        CONCEPTOLabel.Location = New System.Drawing.Point(12, 9)
        CONCEPTOLabel.Name = "CONCEPTOLabel"
        CONCEPTOLabel.Size = New System.Drawing.Size(56, 13)
        CONCEPTOLabel.TabIndex = 1
        CONCEPTOLabel.Text = "Concepto:"
        '
        'IMPORTELabel
        '
        IMPORTELabel.AutoSize = True
        IMPORTELabel.Location = New System.Drawing.Point(247, 9)
        IMPORTELabel.Name = "IMPORTELabel"
        IMPORTELabel.Size = New System.Drawing.Size(45, 13)
        IMPORTELabel.TabIndex = 3
        IMPORTELabel.Text = "Importe:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(12, 58)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 5
        NOTASLabel.Text = "Notas:"
        '
        'tb_concepto
        '
        Me.tb_concepto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSANALITICABindingSource, "CONCEPTO", True))
        Me.tb_concepto.Location = New System.Drawing.Point(15, 25)
        Me.tb_concepto.MaxLength = 90
        Me.tb_concepto.Name = "tb_concepto"
        Me.tb_concepto.Size = New System.Drawing.Size(219, 20)
        Me.tb_concepto.TabIndex = 0
        '
        'CONCEPTOSANALITICABindingSource
        '
        Me.CONCEPTOSANALITICABindingSource.DataMember = "CONCEPTOSANALITICA"
        Me.CONCEPTOSANALITICABindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_importe
        '
        Me.tb_importe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSANALITICABindingSource, "IMPORTE", True))
        Me.tb_importe.Location = New System.Drawing.Point(250, 25)
        Me.tb_importe.Name = "tb_importe"
        Me.tb_importe.Size = New System.Drawing.Size(100, 20)
        Me.tb_importe.TabIndex = 1
        '
        'tb_notas
        '
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSANALITICABindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(15, 74)
        Me.tb_notas.MaxLength = 120
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.Size = New System.Drawing.Size(336, 80)
        Me.tb_notas.TabIndex = 2
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(275, 160)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 4
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(190, 160)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 3
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'CONCEPTOSANALITICATableAdapter
        '
        Me.CONCEPTOSANALITICATableAdapter.ClearBeforeFill = True
        '
        'form_concepto_analitica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 195)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.tb_notas)
        Me.Controls.Add(IMPORTELabel)
        Me.Controls.Add(Me.tb_importe)
        Me.Controls.Add(CONCEPTOLabel)
        Me.Controls.Add(Me.tb_concepto)
        Me.Name = "form_concepto_analitica"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_concepto_analitica"
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CONCEPTOSANALITICABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSANALITICATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSANALITICATableAdapter
    Friend WithEvents tb_concepto As ctrlTextboxAvanzado
    Friend WithEvents tb_importe As ctrlTextboxAvanzado
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents IMPORTELabel As System.Windows.Forms.Label
End Class
