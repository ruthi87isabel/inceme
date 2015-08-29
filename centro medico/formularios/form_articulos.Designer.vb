<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_articulos
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
        Dim CARTICULOLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim REFPROVEEDORLabel As System.Windows.Forms.Label
        Dim STOCKLabel As System.Windows.Forms.Label
        Dim STOCKMINLabel As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.tb_cod = New ctrlTextboxAvanzado
        Me.ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_descipc = New ctrlTextboxAvanzado
        Me.tb_pcod = New ctrlTextboxAvanzado
        Me.tb_stock = New ctrlTextboxAvanzado
        Me.tb_minstock = New ctrlTextboxAvanzado
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.tb_notas = New ctrlTextboxAvanzado
        Me.lb_datos = New System.Windows.Forms.Label
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_proveedor = New System.Windows.Forms.Button
        Me.tb_proveedor = New ctrlTextboxAvanzado
        Me.Label1 = New System.Windows.Forms.Label
        Me.ARTICULOSTableAdapter = New centro_medico.CMDataSetTableAdapters.ARTICULOSTableAdapter
        Me.PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROVEEDORESTableAdapter = New centro_medico.CMDataSetTableAdapters.PROVEEDORESTableAdapter
        CARTICULOLabel = New System.Windows.Forms.Label
        DESCRIPCIONLabel = New System.Windows.Forms.Label
        REFPROVEEDORLabel = New System.Windows.Forms.Label
        STOCKLabel = New System.Windows.Forms.Label
        STOCKMINLabel = New System.Windows.Forms.Label
        FECHALabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CARTICULOLabel
        '
        CARTICULOLabel.AutoSize = True
        CARTICULOLabel.Location = New System.Drawing.Point(10, 28)
        CARTICULOLabel.Name = "CARTICULOLabel"
        CARTICULOLabel.Size = New System.Drawing.Size(43, 13)
        CARTICULOLabel.TabIndex = 1
        CARTICULOLabel.Text = "Código:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(129, 28)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(66, 13)
        DESCRIPCIONLabel.TabIndex = 3
        DESCRIPCIONLabel.Text = "Descripción:"
        '
        'REFPROVEEDORLabel
        '
        REFPROVEEDORLabel.AutoSize = True
        REFPROVEEDORLabel.Location = New System.Drawing.Point(9, 77)
        REFPROVEEDORLabel.Name = "REFPROVEEDORLabel"
        REFPROVEEDORLabel.Size = New System.Drawing.Size(84, 13)
        REFPROVEEDORLabel.TabIndex = 5
        REFPROVEEDORLabel.Text = "Cód. Proveedor:"
        '
        'STOCKLabel
        '
        STOCKLabel.AutoSize = True
        STOCKLabel.Location = New System.Drawing.Point(120, 124)
        STOCKLabel.Name = "STOCKLabel"
        STOCKLabel.Size = New System.Drawing.Size(38, 13)
        STOCKLabel.TabIndex = 7
        STOCKLabel.Text = "Stock:"
        '
        'STOCKMINLabel
        '
        STOCKMINLabel.AutoSize = True
        STOCKMINLabel.Location = New System.Drawing.Point(220, 124)
        STOCKMINLabel.Name = "STOCKMINLabel"
        STOCKMINLabel.Size = New System.Drawing.Size(78, 13)
        STOCKMINLabel.TabIndex = 9
        STOCKMINLabel.Text = "Stock mínimo :"
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(10, 124)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(40, 13)
        FECHALabel.TabIndex = 11
        FECHALabel.Text = "Fecha:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(10, 174)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 13
        NOTASLabel.Text = "Notas:"
        '
        'tb_cod
        '
        Me.tb_cod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "CARTICULO", True))
        Me.tb_cod.Location = New System.Drawing.Point(13, 44)
        Me.tb_cod.Name = "tb_cod"
        Me.tb_cod.Size = New System.Drawing.Size(95, 20)
        Me.tb_cod.TabIndex = 0
        '
        'ARTICULOSBindingSource
        '
        Me.ARTICULOSBindingSource.DataMember = "ARTICULOS"
        Me.ARTICULOSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_descipc
        '
        Me.tb_descipc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "DESCRIPCION", True))
        Me.tb_descipc.Location = New System.Drawing.Point(132, 44)
        Me.tb_descipc.MaxLength = 40
        Me.tb_descipc.Name = "tb_descipc"
        Me.tb_descipc.Size = New System.Drawing.Size(206, 20)
        Me.tb_descipc.TabIndex = 1
        '
        'tb_pcod
        '
        Me.tb_pcod.BackColor = System.Drawing.Color.White
        Me.tb_pcod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "REFPROVEEDOR", True))
        Me.tb_pcod.Location = New System.Drawing.Point(10, 93)
        Me.tb_pcod.Name = "tb_pcod"
        Me.tb_pcod.Size = New System.Drawing.Size(105, 20)
        Me.tb_pcod.TabIndex = 2
        '
        'tb_stock
        '
        Me.tb_stock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "STOCK", True))
        Me.tb_stock.Location = New System.Drawing.Point(114, 140)
        Me.tb_stock.MaxLength = 30000
        Me.tb_stock.Name = "tb_stock"
        Me.tb_stock.Size = New System.Drawing.Size(98, 20)
        Me.tb_stock.TabIndex = 6
        '
        'tb_minstock
        '
        Me.tb_minstock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "STOCKMIN", True))
        Me.tb_minstock.Location = New System.Drawing.Point(218, 140)
        Me.tb_minstock.MaxLength = 30000
        Me.tb_minstock.Name = "tb_minstock"
        Me.tb_minstock.Size = New System.Drawing.Size(120, 20)
        Me.tb_minstock.TabIndex = 7
        '
        'dtp_fecha
        '
        Me.dtp_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ARTICULOSBindingSource, "FECHA", True))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(12, 140)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(96, 20)
        Me.dtp_fecha.TabIndex = 5
        '
        'tb_notas
        '
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(13, 190)
        Me.tb_notas.MaxLength = 120
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.Size = New System.Drawing.Size(325, 63)
        Me.tb_notas.TabIndex = 8
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(5, 2)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(335, 19)
        Me.lb_datos.TabIndex = 31
        Me.lb_datos.Text = "Articulo"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(263, 263)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 10
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(182, 263)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 9
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'bt_proveedor
        '
        Me.bt_proveedor.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_proveedor.Location = New System.Drawing.Point(114, 91)
        Me.bt_proveedor.Name = "bt_proveedor"
        Me.bt_proveedor.Size = New System.Drawing.Size(30, 23)
        Me.bt_proveedor.TabIndex = 3
        Me.bt_proveedor.UseVisualStyleBackColor = True
        '
        'tb_proveedor
        '
        Me.tb_proveedor.BackColor = System.Drawing.Color.White
        Me.tb_proveedor.Location = New System.Drawing.Point(172, 94)
        Me.tb_proveedor.Name = "tb_proveedor"
        Me.tb_proveedor.ReadOnly = True
        Me.tb_proveedor.Size = New System.Drawing.Size(166, 20)
        Me.tb_proveedor.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Proveedor"
        '
        'ARTICULOSTableAdapter
        '
        Me.ARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'PROVEEDORESBindingSource
        '
        Me.PROVEEDORESBindingSource.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource.DataSource = Me.CMDataSet
        '
        'PROVEEDORESTableAdapter
        '
        Me.PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'form_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 292)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_proveedor)
        Me.Controls.Add(Me.bt_proveedor)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.lb_datos)
        Me.Controls.Add(CARTICULOLabel)
        Me.Controls.Add(Me.tb_cod)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.tb_descipc)
        Me.Controls.Add(REFPROVEEDORLabel)
        Me.Controls.Add(Me.tb_pcod)
        Me.Controls.Add(STOCKLabel)
        Me.Controls.Add(Me.tb_stock)
        Me.Controls.Add(STOCKMINLabel)
        Me.Controls.Add(Me.tb_minstock)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.tb_notas)
        Me.Name = "form_articulos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_articulos"
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOSTableAdapter As centro_medico.CMDataSetTableAdapters.ARTICULOSTableAdapter
    Friend WithEvents tb_cod As ctrlTextboxAvanzado
    Friend WithEvents tb_descipc As ctrlTextboxAvanzado
    Friend WithEvents tb_pcod As ctrlTextboxAvanzado
    Friend WithEvents tb_stock As ctrlTextboxAvanzado
    Friend WithEvents tb_minstock As ctrlTextboxAvanzado
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_proveedor As System.Windows.Forms.Button
    Friend WithEvents tb_proveedor As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROVEEDORESTableAdapter As centro_medico.CMDataSetTableAdapters.PROVEEDORESTableAdapter
End Class
