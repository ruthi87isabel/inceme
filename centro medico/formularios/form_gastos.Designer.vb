<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_gastos
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
        Dim REFFORMAPAGOLabel As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim IMPORTELabel As System.Windows.Forms.Label
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.GASTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GASTOSTableAdapter = New centro_medico.CMDataSetTableAdapters.GASTOSTableAdapter
        Me.tb_concepto = New ctrlTextboxAvanzado
        Me.tb_idforma = New ctrlTextboxAvanzado
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.tb_importe = New ctrlTextboxAvanzado
        Me.tb_forma = New ctrlTextboxAvanzado
        Me.bt_forma = New System.Windows.Forms.Button
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.lb_datos = New System.Windows.Forms.Label
        Me.FORMASPAGOTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
        Me.FORMASPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CONCEPTOLabel = New System.Windows.Forms.Label
        REFFORMAPAGOLabel = New System.Windows.Forms.Label
        FECHALabel = New System.Windows.Forms.Label
        IMPORTELabel = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GASTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CONCEPTOLabel
        '
        CONCEPTOLabel.AutoSize = True
        CONCEPTOLabel.Location = New System.Drawing.Point(4, 69)
        CONCEPTOLabel.Name = "CONCEPTOLabel"
        CONCEPTOLabel.Size = New System.Drawing.Size(56, 13)
        CONCEPTOLabel.TabIndex = 3
        CONCEPTOLabel.Text = "Concepto:"
        '
        'REFFORMAPAGOLabel
        '
        REFFORMAPAGOLabel.AutoSize = True
        REFFORMAPAGOLabel.Location = New System.Drawing.Point(4, 108)
        REFFORMAPAGOLabel.Name = "REFFORMAPAGOLabel"
        REFFORMAPAGOLabel.Size = New System.Drawing.Size(86, 13)
        REFFORMAPAGOLabel.TabIndex = 9
        REFFORMAPAGOLabel.Text = "Formas de pago:"
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(4, 30)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(40, 13)
        FECHALabel.TabIndex = 10
        FECHALabel.Text = "Fecha:"
        '
        'IMPORTELabel
        '
        IMPORTELabel.AutoSize = True
        IMPORTELabel.Location = New System.Drawing.Point(162, 30)
        IMPORTELabel.Name = "IMPORTELabel"
        IMPORTELabel.Size = New System.Drawing.Size(45, 13)
        IMPORTELabel.TabIndex = 11
        IMPORTELabel.Text = "Importe:"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GASTOSBindingSource
        '
        Me.GASTOSBindingSource.DataMember = "GASTOS"
        Me.GASTOSBindingSource.DataSource = Me.CMDataSet
        '
        'GASTOSTableAdapter
        '
        Me.GASTOSTableAdapter.ClearBeforeFill = True
        '
        'tb_concepto
        '
        Me.tb_concepto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GASTOSBindingSource, "CONCEPTO", True))
        Me.tb_concepto.Location = New System.Drawing.Point(7, 85)
        Me.tb_concepto.MaxLength = 250
        Me.tb_concepto.Name = "tb_concepto"
        Me.tb_concepto.Size = New System.Drawing.Size(258, 20)
        Me.tb_concepto.TabIndex = 2
        '
        'tb_idforma
        '
        Me.tb_idforma.BackColor = System.Drawing.Color.White
        Me.tb_idforma.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GASTOSBindingSource, "REFFORMAPAGO", True))
        Me.tb_idforma.Location = New System.Drawing.Point(7, 124)
        Me.tb_idforma.MaxLength = 10
        Me.tb_idforma.Name = "tb_idforma"
        Me.tb_idforma.Size = New System.Drawing.Size(84, 20)
        Me.tb_idforma.TabIndex = 3
        '
        'dtp_fecha
        '
        Me.dtp_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GASTOSBindingSource, "FECHA", True))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(7, 46)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(120, 20)
        Me.dtp_fecha.TabIndex = 0
        '
        'tb_importe
        '
        Me.tb_importe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GASTOSBindingSource, "IMPORTE", True))
        Me.tb_importe.Location = New System.Drawing.Point(165, 47)
        Me.tb_importe.Name = "tb_importe"
        Me.tb_importe.Size = New System.Drawing.Size(100, 20)
        Me.tb_importe.TabIndex = 1
        '
        'tb_forma
        '
        Me.tb_forma.BackColor = System.Drawing.Color.White
        Me.tb_forma.Location = New System.Drawing.Point(124, 124)
        Me.tb_forma.MaxLength = 90
        Me.tb_forma.Name = "tb_forma"
        Me.tb_forma.ReadOnly = True
        Me.tb_forma.Size = New System.Drawing.Size(141, 20)
        Me.tb_forma.TabIndex = 5
        '
        'bt_forma
        '
        Me.bt_forma.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_forma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_forma.Location = New System.Drawing.Point(88, 121)
        Me.bt_forma.Name = "bt_forma"
        Me.bt_forma.Size = New System.Drawing.Size(30, 23)
        Me.bt_forma.TabIndex = 4
        Me.bt_forma.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(190, 161)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 7
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(109, 161)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 6
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(1, 5)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(272, 18)
        Me.lb_datos.TabIndex = 68
        Me.lb_datos.Text = "Datos de la factura"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FORMASPAGOTableAdapter
        '
        Me.FORMASPAGOTableAdapter.ClearBeforeFill = True
        '
        'FORMASPAGOBindingSource
        '
        Me.FORMASPAGOBindingSource.DataMember = "FORMASPAGO"
        Me.FORMASPAGOBindingSource.DataSource = Me.CMDataSet
        '
        'form_gastos
        '
        Me.AcceptButton = Me.bt_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancel
        Me.ClientSize = New System.Drawing.Size(273, 192)
        Me.Controls.Add(Me.lb_datos)
        Me.Controls.Add(Me.tb_forma)
        Me.Controls.Add(Me.bt_forma)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(IMPORTELabel)
        Me.Controls.Add(Me.tb_importe)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(CONCEPTOLabel)
        Me.Controls.Add(Me.tb_concepto)
        Me.Controls.Add(REFFORMAPAGOLabel)
        Me.Controls.Add(Me.tb_idforma)
        Me.Name = "form_gastos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_gastos"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GASTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents GASTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GASTOSTableAdapter As centro_medico.CMDataSetTableAdapters.GASTOSTableAdapter
    Friend WithEvents tb_concepto As ctrlTextboxAvanzado
    Friend WithEvents tb_idforma As ctrlTextboxAvanzado
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_importe As ctrlTextboxAvanzado
    Friend WithEvents tb_forma As ctrlTextboxAvanzado
    Friend WithEvents bt_forma As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
    Friend WithEvents FORMASPAGOBindingSource As System.Windows.Forms.BindingSource
End Class
