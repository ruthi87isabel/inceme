<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_plantilla__analiticas
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
        'Dim IMPORTELabel As System.Windows.Forms.Label
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgv_realizar = New System.Windows.Forms.DataGridView
        Me.bt_der = New System.Windows.Forms.Button
        Me.tb_total = New ctrlTextboxAvanzado
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tb_buscar = New ctrlTextboxAvanzado
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgv_disponibles = New System.Windows.Forms.DataGridView
        Me.bt_izq = New System.Windows.Forms.Button
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.tb_codigo = New ctrlTextboxAvanzado
        Me.PLANTILLAANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_descripcion = New ctrlTextboxAvanzado
        Me.PLANTILLAANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.PLANTILLAANALITICASTableAdapter
        Me.LPLANTILLAANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LPLANTILLAANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.LPLANTILLAANALITICASTableAdapter
        Me.CONCEPTOSANALITICATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSANALITICATableAdapter
        Me.CONCEPTOSANALITICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        IMPORTELabel = New System.Windows.Forms.Label
        CODIGOLabel = New System.Windows.Forms.Label
        DESCRIPCIONLabel = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_realizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_disponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMPORTELabel
        '
        IMPORTELabel.AutoSize = True
        IMPORTELabel.Location = New System.Drawing.Point(174, 240)
        IMPORTELabel.Name = "IMPORTELabel"
        IMPORTELabel.Size = New System.Drawing.Size(34, 13)
        IMPORTELabel.TabIndex = 2
        IMPORTELabel.Text = "Total:"
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(12, 14)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(43, 13)
        CODIGOLabel.TabIndex = 118
        CODIGOLabel.Text = "Codigo:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(224, 14)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(66, 13)
        DESCRIPCIONLabel.TabIndex = 120
        DESCRIPCIONLabel.Text = "Descripcion:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_realizar)
        Me.GroupBox3.Controls.Add(Me.bt_der)
        Me.GroupBox3.Controls.Add(IMPORTELabel)
        Me.GroupBox3.Controls.Add(Me.tb_total)
        Me.GroupBox3.Location = New System.Drawing.Point(371, 84)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(365, 264)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Analisis a Realizar"
        '
        'dgv_realizar
        '
        Me.dgv_realizar.AllowUserToAddRows = False
        Me.dgv_realizar.AllowUserToDeleteRows = False
        Me.dgv_realizar.BackgroundColor = System.Drawing.Color.White
        Me.dgv_realizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_realizar.Location = New System.Drawing.Point(15, 19)
        Me.dgv_realizar.Name = "dgv_realizar"
        Me.dgv_realizar.ReadOnly = True
        Me.dgv_realizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_realizar.Size = New System.Drawing.Size(344, 212)
        Me.dgv_realizar.TabIndex = 0
        '
        'bt_der
        '
        Me.bt_der.BackgroundImage = Global.centro_medico.My.Resources.Resources.Back
        Me.bt_der.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_der.Location = New System.Drawing.Point(10, 241)
        Me.bt_der.Name = "bt_der"
        Me.bt_der.Size = New System.Drawing.Size(36, 20)
        Me.bt_der.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.bt_der, "Realizar análisis")
        Me.bt_der.UseVisualStyleBackColor = True
        '
        'tb_total
        '
        Me.tb_total.Location = New System.Drawing.Point(214, 237)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.ReadOnly = True
        Me.tb_total.Size = New System.Drawing.Size(145, 20)
        Me.tb_total.TabIndex = 3
        Me.tb_total.Text = "0,00"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(567, 371)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 4
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb_buscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgv_disponibles)
        Me.GroupBox2.Controls.Add(Me.bt_izq)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 264)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Analisis disponibles"
        '
        'tb_buscar
        '
        Me.tb_buscar.Location = New System.Drawing.Point(53, 16)
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(298, 20)
        Me.tb_buscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar"
        '
        'dgv_disponibles
        '
        Me.dgv_disponibles.AllowUserToAddRows = False
        Me.dgv_disponibles.AllowUserToDeleteRows = False
        Me.dgv_disponibles.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_disponibles.Location = New System.Drawing.Point(7, 42)
        Me.dgv_disponibles.Name = "dgv_disponibles"
        Me.dgv_disponibles.ReadOnly = True
        Me.dgv_disponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_disponibles.Size = New System.Drawing.Size(344, 189)
        Me.dgv_disponibles.TabIndex = 2
        '
        'bt_izq
        '
        Me.bt_izq.BackgroundImage = Global.centro_medico.My.Resources.Resources._Next
        Me.bt_izq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_izq.Location = New System.Drawing.Point(315, 241)
        Me.bt_izq.Name = "bt_izq"
        Me.bt_izq.Size = New System.Drawing.Size(36, 20)
        Me.bt_izq.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.bt_izq, "Realizar análisis")
        Me.bt_izq.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(661, 371)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 5
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'tb_codigo
        '
        Me.tb_codigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTILLAANALITICASBindingSource, "CODIGO", True))
        Me.tb_codigo.Location = New System.Drawing.Point(15, 39)
        Me.tb_codigo.MaxLength = 10
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(149, 20)
        Me.tb_codigo.TabIndex = 0
        '
        'PLANTILLAANALITICASBindingSource
        '
        Me.PLANTILLAANALITICASBindingSource.DataMember = "PLANTILLAANALITICAS"
        Me.PLANTILLAANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_descripcion
        '
        Me.tb_descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTILLAANALITICASBindingSource, "DESCRIPCION", True))
        Me.tb_descripcion.Location = New System.Drawing.Point(227, 39)
        Me.tb_descripcion.MaxLength = 90
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(438, 20)
        Me.tb_descripcion.TabIndex = 1
        '
        'PLANTILLAANALITICASTableAdapter
        '
        Me.PLANTILLAANALITICASTableAdapter.ClearBeforeFill = True
        '
        'LPLANTILLAANALITICASBindingSource
        '
        Me.LPLANTILLAANALITICASBindingSource.DataMember = "LPLANTILLAANALITICAS"
        Me.LPLANTILLAANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'LPLANTILLAANALITICASTableAdapter
        '
        Me.LPLANTILLAANALITICASTableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSANALITICATableAdapter
        '
        Me.CONCEPTOSANALITICATableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSANALITICABindingSource
        '
        Me.CONCEPTOSANALITICABindingSource.DataMember = "CONCEPTOSANALITICA"
        Me.CONCEPTOSANALITICABindingSource.DataSource = Me.CMDataSet
        '
        'form_plantilla__analiticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 406)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.tb_codigo)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.tb_descripcion)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bt_cancel)
        Me.Name = "form_plantilla__analiticas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_plantilla__analiticas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_realizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_disponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_realizar As System.Windows.Forms.DataGridView
    Friend WithEvents bt_der As System.Windows.Forms.Button
    Friend WithEvents tb_total As ctrlTextboxAvanzado
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_buscar As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IMPORTELabel As System.Windows.Forms.Label
    Friend WithEvents dgv_disponibles As System.Windows.Forms.DataGridView
    Friend WithEvents bt_izq As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PLANTILLAANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLANTILLAANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.PLANTILLAANALITICASTableAdapter
    Friend WithEvents tb_codigo As ctrlTextboxAvanzado
    Friend WithEvents tb_descripcion As ctrlTextboxAvanzado
    Friend WithEvents LPLANTILLAANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LPLANTILLAANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.LPLANTILLAANALITICASTableAdapter
    Friend WithEvents CONCEPTOSANALITICATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSANALITICATableAdapter
    Friend WithEvents CONCEPTOSANALITICABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
