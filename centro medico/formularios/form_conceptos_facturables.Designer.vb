<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_conceptos_facturables
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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim IMPORTELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.tb_cod = New centro_medico.ctrlTextboxAvanzado()
        Me.CONCEPTOSFACTURABLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.tb_descrip = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_importe = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_BuscarCodigo = New System.Windows.Forms.Button()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.CONCEPTOSFACTURABLESTableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFACTURABLESTableAdapter()
        Me.CONCEPTOSFRATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter()
        Me.CONCEPTOSFRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDuracion = New System.Windows.Forms.DateTimePicker()
        Me.CtrlFamilia1 = New centro_medico.ctrlFamilia()
        IDLabel = New System.Windows.Forms.Label()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        IMPORTELabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.CONCEPTOSFACTURABLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 9)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(43, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "Código:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(151, 9)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(66, 13)
        DESCRIPCIONLabel.TabIndex = 6
        DESCRIPCIONLabel.Text = "Descripción:"
        '
        'IMPORTELabel
        '
        IMPORTELabel.AutoSize = True
        IMPORTELabel.Location = New System.Drawing.Point(388, 9)
        IMPORTELabel.Name = "IMPORTELabel"
        IMPORTELabel.Size = New System.Drawing.Size(45, 13)
        IMPORTELabel.TabIndex = 8
        IMPORTELabel.Text = "Importe:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(43, 64)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(104, 13)
        Label1.TabIndex = 6
        Label1.Text = "Duración (Opcional):"
        '
        'tb_cod
        '
        Me.tb_cod.AcceptsReturn = True
        Me.tb_cod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSFACTURABLESBindingSource, "ID", True))
        Me.tb_cod.Location = New System.Drawing.Point(15, 25)
        Me.tb_cod.Name = "tb_cod"
        Me.tb_cod.Size = New System.Drawing.Size(89, 20)
        Me.tb_cod.TabIndex = 0
        '
        'CONCEPTOSFACTURABLESBindingSource
        '
        Me.CONCEPTOSFACTURABLESBindingSource.DataMember = "CONCEPTOSFACTURABLES"
        Me.CONCEPTOSFACTURABLESBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_descrip
        '
        Me.tb_descrip.AcceptsReturn = True
        Me.tb_descrip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSFACTURABLESBindingSource, "DESCRIPCION", True))
        Me.tb_descrip.Location = New System.Drawing.Point(153, 25)
        Me.tb_descrip.MaxLength = 150
        Me.tb_descrip.Name = "tb_descrip"
        Me.tb_descrip.Size = New System.Drawing.Size(216, 20)
        Me.tb_descrip.TabIndex = 2
        '
        'tb_importe
        '
        Me.tb_importe.AcceptsReturn = True
        Me.tb_importe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSFACTURABLESBindingSource, "IMPORTE", True))
        Me.tb_importe.Location = New System.Drawing.Point(391, 25)
        Me.tb_importe.Name = "tb_importe"
        Me.tb_importe.Size = New System.Drawing.Size(100, 20)
        Me.tb_importe.TabIndex = 3
        Me.tb_importe.Text = "0.00"
        '
        'bt_BuscarCodigo
        '
        Me.bt_BuscarCodigo.BackgroundImage = Global.centro_medico.My.Resources.Resources.Search1
        Me.bt_BuscarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_BuscarCodigo.Location = New System.Drawing.Point(104, 25)
        Me.bt_BuscarCodigo.Name = "bt_BuscarCodigo"
        Me.bt_BuscarCodigo.Size = New System.Drawing.Size(25, 20)
        Me.bt_BuscarCodigo.TabIndex = 1
        Me.bt_BuscarCodigo.UseVisualStyleBackColor = True
        Me.bt_BuscarCodigo.Visible = False
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(416, 88)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 5
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(335, 88)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 4
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'CONCEPTOSFACTURABLESTableAdapter
        '
        Me.CONCEPTOSFACTURABLESTableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSFRATableAdapter
        '
        Me.CONCEPTOSFRATableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSFRABindingSource
        '
        Me.CONCEPTOSFRABindingSource.DataMember = "CONCEPTOSFRA"
        Me.CONCEPTOSFRABindingSource.DataSource = Me.CMDataSet
        '
        'txtDuracion
        '
        Me.txtDuracion.CustomFormat = "HH:mm"
        Me.txtDuracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDuracion.Location = New System.Drawing.Point(154, 64)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.ShowUpDown = True
        Me.txtDuracion.Size = New System.Drawing.Size(58, 20)
        Me.txtDuracion.TabIndex = 70
        Me.txtDuracion.Value = New Date(2010, 6, 21, 0, 0, 0, 0)
        '
        'CtrlFamilia1
        '
        Me.CtrlFamilia1.ID_CONCEPTOFAMILIA = Nothing
        Me.CtrlFamilia1.Location = New System.Drawing.Point(15, 92)
        Me.CtrlFamilia1.Name = "CtrlFamilia1"
        Me.CtrlFamilia1.Size = New System.Drawing.Size(277, 24)
        Me.CtrlFamilia1.TabIndex = 71
        '
        'form_conceptos_facturables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 133)
        Me.Controls.Add(Me.CtrlFamilia1)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.bt_BuscarCodigo)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.tb_cod)
        Me.Controls.Add(Label1)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.tb_descrip)
        Me.Controls.Add(IMPORTELabel)
        Me.Controls.Add(Me.tb_importe)
        Me.Name = "form_conceptos_facturables"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edición de concepto Facturable"
        CType(Me.CONCEPTOSFACTURABLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CONCEPTOSFACTURABLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFACTURABLESTableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFACTURABLESTableAdapter
    Friend WithEvents tb_cod As ctrlTextboxAvanzado
    Friend WithEvents tb_descrip As ctrlTextboxAvanzado
    Friend WithEvents tb_importe As ctrlTextboxAvanzado
    Friend WithEvents CONCEPTOSFRATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter
    Friend WithEvents CONCEPTOSFRABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bt_BuscarCodigo As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents txtDuracion As System.Windows.Forms.DateTimePicker
    Friend WithEvents CtrlFamilia1 As centro_medico.ctrlFamilia
End Class
