<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_generar_recibos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_generar_recibos))
        Me.gb_generarRecibos = New System.Windows.Forms.GroupBox
        Me.dtg_recibos = New System.Windows.Forms.DataGridView
        Me.Label5 = New System.Windows.Forms.Label
        Me.lb_fechavencimiento = New System.Windows.Forms.Label
        Me.lb_fechaemision = New System.Windows.Forms.Label
        Me.lb_fechafinal = New System.Windows.Forms.Label
        Me.lb_fechainicial = New System.Windows.Forms.Label
        Me.dtp_fechavencimiento = New System.Windows.Forms.DateTimePicker
        Me.dtp_fechaemision = New System.Windows.Forms.DateTimePicker
        Me.dtp_fechafinal = New System.Windows.Forms.DateTimePicker
        Me.dtp_fechainicial = New System.Windows.Forms.DateTimePicker
        Me.bt_mostrar = New System.Windows.Forms.Button
        Me.bt_filtrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_agruparporcliente = New System.Windows.Forms.Button
        Me.bt_generar = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.RECIBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECIBOSTableAdapter = New centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
        Me.CITASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CITASTableAdapter = New centro_medico.CMDataSetTableAdapters.CITASTableAdapter
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.gb_generarRecibos.SuspendLayout()
        CType(Me.dtg_recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_generarRecibos
        '
        Me.gb_generarRecibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_generarRecibos.Controls.Add(Me.dtg_recibos)
        Me.gb_generarRecibos.Controls.Add(Me.Label5)
        Me.gb_generarRecibos.Controls.Add(Me.lb_fechavencimiento)
        Me.gb_generarRecibos.Controls.Add(Me.lb_fechaemision)
        Me.gb_generarRecibos.Controls.Add(Me.lb_fechafinal)
        Me.gb_generarRecibos.Controls.Add(Me.lb_fechainicial)
        Me.gb_generarRecibos.Controls.Add(Me.dtp_fechavencimiento)
        Me.gb_generarRecibos.Controls.Add(Me.dtp_fechaemision)
        Me.gb_generarRecibos.Controls.Add(Me.dtp_fechafinal)
        Me.gb_generarRecibos.Controls.Add(Me.dtp_fechainicial)
        Me.gb_generarRecibos.Controls.Add(Me.bt_mostrar)
        Me.gb_generarRecibos.Controls.Add(Me.bt_filtrar)
        Me.gb_generarRecibos.Location = New System.Drawing.Point(3, 3)
        Me.gb_generarRecibos.Name = "gb_generarRecibos"
        Me.gb_generarRecibos.Size = New System.Drawing.Size(754, 441)
        Me.gb_generarRecibos.TabIndex = 0
        Me.gb_generarRecibos.TabStop = False
        Me.gb_generarRecibos.Text = "Generar Recibos"
        '
        'dtg_recibos
        '
        Me.dtg_recibos.AllowUserToAddRows = False
        Me.dtg_recibos.AllowUserToDeleteRows = False
        Me.dtg_recibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_recibos.BackgroundColor = System.Drawing.Color.White
        Me.dtg_recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_recibos.Location = New System.Drawing.Point(12, 96)
        Me.dtg_recibos.Name = "dtg_recibos"
        Me.dtg_recibos.ReadOnly = True
        Me.dtg_recibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_recibos.Size = New System.Drawing.Size(689, 328)
        Me.dtg_recibos.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Remesa resultante"
        '
        'lb_fechavencimiento
        '
        Me.lb_fechavencimiento.AutoSize = True
        Me.lb_fechavencimiento.Location = New System.Drawing.Point(608, 23)
        Me.lb_fechavencimiento.Name = "lb_fechavencimiento"
        Me.lb_fechavencimiento.Size = New System.Drawing.Size(112, 13)
        Me.lb_fechavencimiento.TabIndex = 9
        Me.lb_fechavencimiento.Text = "Fecha de vencimiento"
        '
        'lb_fechaemision
        '
        Me.lb_fechaemision.AutoSize = True
        Me.lb_fechaemision.Location = New System.Drawing.Point(483, 23)
        Me.lb_fechaemision.Name = "lb_fechaemision"
        Me.lb_fechaemision.Size = New System.Drawing.Size(90, 13)
        Me.lb_fechaemision.TabIndex = 8
        Me.lb_fechaemision.Text = "Fecha de emisión"
        '
        'lb_fechafinal
        '
        Me.lb_fechafinal.AutoSize = True
        Me.lb_fechafinal.Location = New System.Drawing.Point(140, 23)
        Me.lb_fechafinal.Name = "lb_fechafinal"
        Me.lb_fechafinal.Size = New System.Drawing.Size(62, 13)
        Me.lb_fechafinal.TabIndex = 7
        Me.lb_fechafinal.Text = "Fecha Final"
        '
        'lb_fechainicial
        '
        Me.lb_fechainicial.AutoSize = True
        Me.lb_fechainicial.Location = New System.Drawing.Point(9, 23)
        Me.lb_fechainicial.Name = "lb_fechainicial"
        Me.lb_fechainicial.Size = New System.Drawing.Size(67, 13)
        Me.lb_fechainicial.TabIndex = 6
        Me.lb_fechainicial.Text = "Fecha Inicial"
        '
        'dtp_fechavencimiento
        '
        Me.dtp_fechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechavencimiento.Location = New System.Drawing.Point(611, 39)
        Me.dtp_fechavencimiento.Name = "dtp_fechavencimiento"
        Me.dtp_fechavencimiento.Size = New System.Drawing.Size(109, 20)
        Me.dtp_fechavencimiento.TabIndex = 5
        '
        'dtp_fechaemision
        '
        Me.dtp_fechaemision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaemision.Location = New System.Drawing.Point(486, 39)
        Me.dtp_fechaemision.Name = "dtp_fechaemision"
        Me.dtp_fechaemision.Size = New System.Drawing.Size(109, 20)
        Me.dtp_fechaemision.TabIndex = 4
        '
        'dtp_fechafinal
        '
        Me.dtp_fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechafinal.Location = New System.Drawing.Point(143, 39)
        Me.dtp_fechafinal.Name = "dtp_fechafinal"
        Me.dtp_fechafinal.Size = New System.Drawing.Size(109, 20)
        Me.dtp_fechafinal.TabIndex = 3
        '
        'dtp_fechainicial
        '
        Me.dtp_fechainicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechainicial.Location = New System.Drawing.Point(12, 39)
        Me.dtp_fechainicial.Name = "dtp_fechainicial"
        Me.dtp_fechainicial.Size = New System.Drawing.Size(109, 20)
        Me.dtp_fechainicial.TabIndex = 2
        '
        'bt_mostrar
        '
        Me.bt_mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_mostrar.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_mostrar.Location = New System.Drawing.Point(709, 388)
        Me.bt_mostrar.Name = "bt_mostrar"
        Me.bt_mostrar.Size = New System.Drawing.Size(38, 27)
        Me.bt_mostrar.TabIndex = 1
        Me.bt_mostrar.UseVisualStyleBackColor = True
        '
        'bt_filtrar
        '
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.ImageIndex = 0
        Me.bt_filtrar.ImageList = Me.ImageList1
        Me.bt_filtrar.Location = New System.Drawing.Point(314, 28)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(75, 31)
        Me.bt_filtrar.TabIndex = 0
        Me.bt_filtrar.Text = "Filtrar   "
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search4doc.ico")
        Me.ImageList1.Images.SetKeyName(1, "WLM.png")
        '
        'bt_agruparporcliente
        '
        Me.bt_agruparporcliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_agruparporcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_agruparporcliente.ImageIndex = 1
        Me.bt_agruparporcliente.ImageList = Me.ImageList1
        Me.bt_agruparporcliente.Location = New System.Drawing.Point(15, 457)
        Me.bt_agruparporcliente.Name = "bt_agruparporcliente"
        Me.bt_agruparporcliente.Size = New System.Drawing.Size(138, 30)
        Me.bt_agruparporcliente.TabIndex = 12
        Me.bt_agruparporcliente.Text = "Agrupar por Cliente"
        Me.bt_agruparporcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_agruparporcliente.UseVisualStyleBackColor = True
        '
        'bt_generar
        '
        Me.bt_generar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_generar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_generar.Location = New System.Drawing.Point(555, 457)
        Me.bt_generar.Name = "bt_generar"
        Me.bt_generar.Size = New System.Drawing.Size(75, 30)
        Me.bt_generar.TabIndex = 13
        Me.bt_generar.Text = "Generar"
        Me.bt_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_generar.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(658, 457)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 30)
        Me.bt_cancelar.TabIndex = 14
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RECIBOSBindingSource
        '
        Me.RECIBOSBindingSource.DataMember = "RECIBOS"
        Me.RECIBOSBindingSource.DataSource = Me.CMDataSet
        '
        'RECIBOSTableAdapter
        '
        Me.RECIBOSTableAdapter.ClearBeforeFill = True
        '
        'CITASBindingSource
        '
        Me.CITASBindingSource.DataMember = "CITAS"
        Me.CITASBindingSource.DataSource = Me.CMDataSet
        '
        'CITASTableAdapter
        '
        Me.CITASTableAdapter.ClearBeforeFill = True
        '
        'FACTURASBindingSource
        '
        Me.FACTURASBindingSource.DataMember = "FACTURAS"
        Me.FACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'FACTURASTableAdapter
        '
        Me.FACTURASTableAdapter.ClearBeforeFill = True
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'form_generar_recibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(777, 507)
        Me.Controls.Add(Me.bt_agruparporcliente)
        Me.Controls.Add(Me.bt_generar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.gb_generarRecibos)
        Me.Name = "form_generar_recibos"
        Me.ShowIcon = False
        Me.Text = "Generar Recibos"
        Me.gb_generarRecibos.ResumeLayout(False)
        Me.gb_generarRecibos.PerformLayout()
        CType(Me.dtg_recibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_generarRecibos As System.Windows.Forms.GroupBox
    Friend WithEvents bt_mostrar As System.Windows.Forms.Button
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents dtg_recibos As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lb_fechavencimiento As System.Windows.Forms.Label
    Friend WithEvents lb_fechaemision As System.Windows.Forms.Label
    Friend WithEvents lb_fechafinal As System.Windows.Forms.Label
    Friend WithEvents lb_fechainicial As System.Windows.Forms.Label
    Friend WithEvents dtp_fechavencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechaemision As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechainicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_agruparporcliente As System.Windows.Forms.Button
    Friend WithEvents bt_generar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents RECIBOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECIBOSTableAdapter As centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
    Friend WithEvents CITASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CITASTableAdapter As centro_medico.CMDataSetTableAdapters.CITASTableAdapter
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
End Class
