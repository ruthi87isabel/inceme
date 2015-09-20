<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_remesa_de_recibos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_remesa_de_recibos))
        Me.gb_generarRecibos = New System.Windows.Forms.GroupBox()
        Me.chb_listaremitidos = New System.Windows.Forms.CheckBox()
        Me.dtg_recibos = New System.Windows.Forms.DataGridView()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMITIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAEMISION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFPACIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COBRADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAVENCIMIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUENTABANCO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OFICINA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONCEPTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACOBRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFORMAPAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFEMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECIBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lb_fechafinal = New System.Windows.Forms.Label()
        Me.lb_fechainicial = New System.Windows.Forms.Label()
        Me.dtp_fechafinal = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fechainicial = New System.Windows.Forms.DateTimePicker()
        Me.bt_mostrar = New System.Windows.Forms.Button()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_generar = New System.Windows.Forms.Button()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.RECIBOSTableAdapter = New centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsl_FilasFiltradas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsl_FilasSeleccionadas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gb_generarRecibos.SuspendLayout()
        CType(Me.dtg_recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_generarRecibos
        '
        Me.gb_generarRecibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_generarRecibos.Controls.Add(Me.chb_listaremitidos)
        Me.gb_generarRecibos.Controls.Add(Me.dtg_recibos)
        Me.gb_generarRecibos.Controls.Add(Me.Label5)
        Me.gb_generarRecibos.Controls.Add(Me.lb_fechafinal)
        Me.gb_generarRecibos.Controls.Add(Me.lb_fechainicial)
        Me.gb_generarRecibos.Controls.Add(Me.dtp_fechafinal)
        Me.gb_generarRecibos.Controls.Add(Me.dtp_fechainicial)
        Me.gb_generarRecibos.Controls.Add(Me.bt_mostrar)
        Me.gb_generarRecibos.Controls.Add(Me.bt_filtrar)
        Me.gb_generarRecibos.Location = New System.Drawing.Point(5, 3)
        Me.gb_generarRecibos.Name = "gb_generarRecibos"
        Me.gb_generarRecibos.Size = New System.Drawing.Size(712, 448)
        Me.gb_generarRecibos.TabIndex = 0
        Me.gb_generarRecibos.TabStop = False
        Me.gb_generarRecibos.Text = "Imprimir recibos con fecha de emisión"
        '
        'chb_listaremitidos
        '
        Me.chb_listaremitidos.AutoSize = True
        Me.chb_listaremitidos.Location = New System.Drawing.Point(317, 42)
        Me.chb_listaremitidos.Name = "chb_listaremitidos"
        Me.chb_listaremitidos.Size = New System.Drawing.Size(148, 17)
        Me.chb_listaremitidos.TabIndex = 2
        Me.chb_listaremitidos.Text = "Listar también los emitidos"
        Me.chb_listaremitidos.UseVisualStyleBackColor = True
        '
        'dtg_recibos
        '
        Me.dtg_recibos.AllowUserToAddRows = False
        Me.dtg_recibos.AllowUserToDeleteRows = False
        Me.dtg_recibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_recibos.AutoGenerateColumns = False
        Me.dtg_recibos.BackgroundColor = System.Drawing.Color.White
        Me.dtg_recibos.ColumnHeadersHeight = 28
        Me.dtg_recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtg_recibos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.EMITIDO, Me.FECHAEMISION, Me.REFPACIENTE, Me.NOMBRE, Me.COBRADO, Me.REFCITA, Me.REFFACTURA, Me.IMPORTE, Me.FECHAVENCIMIENTO, Me.DIRECCION, Me.NOTAS, Me.CUENTABANCO, Me.ENTIDAD, Me.OFICINA, Me.DC, Me.CUENTA, Me.CONCEPTO, Me.FECHACOBRO, Me.N19, Me.REFFORMAPAGO, Me.TIPO, Me.REFEMPRESA})
        Me.dtg_recibos.DataSource = Me.RECIBOSBindingSource
        Me.dtg_recibos.Location = New System.Drawing.Point(12, 86)
        Me.dtg_recibos.Name = "dtg_recibos"
        Me.dtg_recibos.ReadOnly = True
        Me.dtg_recibos.RowHeadersVisible = False
        Me.dtg_recibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_recibos.Size = New System.Drawing.Size(689, 324)
        Me.dtg_recibos.TabIndex = 4
        '
        'NUMERO
        '
        Me.NUMERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NUMERO.DataPropertyName = "NUMERO"
        Me.NUMERO.HeaderText = "NUMERO"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        Me.NUMERO.Width = 80
        '
        'EMITIDO
        '
        Me.EMITIDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.EMITIDO.DataPropertyName = "EMITIDO"
        Me.EMITIDO.HeaderText = "EMITIDO"
        Me.EMITIDO.Name = "EMITIDO"
        Me.EMITIDO.ReadOnly = True
        Me.EMITIDO.Width = 77
        '
        'FECHAEMISION
        '
        Me.FECHAEMISION.DataPropertyName = "FECHAEMISION"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FECHAEMISION.DefaultCellStyle = DataGridViewCellStyle1
        Me.FECHAEMISION.HeaderText = "F. EMISION"
        Me.FECHAEMISION.Name = "FECHAEMISION"
        Me.FECHAEMISION.ReadOnly = True
        '
        'REFPACIENTE
        '
        Me.REFPACIENTE.DataPropertyName = "REFPACIENTE"
        Me.REFPACIENTE.HeaderText = "C.PACIENTE"
        Me.REFPACIENTE.Name = "REFPACIENTE"
        Me.REFPACIENTE.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 200
        '
        'COBRADO
        '
        Me.COBRADO.DataPropertyName = "COBRADO"
        Me.COBRADO.HeaderText = "COBRADO"
        Me.COBRADO.Name = "COBRADO"
        Me.COBRADO.ReadOnly = True
        Me.COBRADO.Width = 75
        '
        'REFCITA
        '
        Me.REFCITA.DataPropertyName = "REFCITA"
        Me.REFCITA.HeaderText = "CITA"
        Me.REFCITA.Name = "REFCITA"
        Me.REFCITA.ReadOnly = True
        Me.REFCITA.Visible = False
        Me.REFCITA.Width = 75
        '
        'REFFACTURA
        '
        Me.REFFACTURA.DataPropertyName = "REFFACTURA"
        Me.REFFACTURA.HeaderText = "FACTURA"
        Me.REFFACTURA.Name = "REFFACTURA"
        Me.REFFACTURA.ReadOnly = True
        Me.REFFACTURA.Visible = False
        '
        'IMPORTE
        '
        Me.IMPORTE.DataPropertyName = "IMPORTE"
        DataGridViewCellStyle2.Format = "c"
        Me.IMPORTE.DefaultCellStyle = DataGridViewCellStyle2
        Me.IMPORTE.HeaderText = "IMPORTE"
        Me.IMPORTE.Name = "IMPORTE"
        Me.IMPORTE.ReadOnly = True
        Me.IMPORTE.Width = 75
        '
        'FECHAVENCIMIENTO
        '
        Me.FECHAVENCIMIENTO.DataPropertyName = "FECHAVENCIMIENTO"
        DataGridViewCellStyle3.Format = "d"
        Me.FECHAVENCIMIENTO.DefaultCellStyle = DataGridViewCellStyle3
        Me.FECHAVENCIMIENTO.HeaderText = "F. VENC."
        Me.FECHAVENCIMIENTO.Name = "FECHAVENCIMIENTO"
        Me.FECHAVENCIMIENTO.ReadOnly = True
        Me.FECHAVENCIMIENTO.Width = 75
        '
        'DIRECCION
        '
        Me.DIRECCION.DataPropertyName = "DIRECCION"
        Me.DIRECCION.HeaderText = "DIRECCION"
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.ReadOnly = True
        Me.DIRECCION.Visible = False
        '
        'NOTAS
        '
        Me.NOTAS.DataPropertyName = "NOTAS"
        Me.NOTAS.HeaderText = "NOTAS"
        Me.NOTAS.Name = "NOTAS"
        Me.NOTAS.ReadOnly = True
        Me.NOTAS.Visible = False
        '
        'CUENTABANCO
        '
        Me.CUENTABANCO.DataPropertyName = "CUENTABANCO"
        Me.CUENTABANCO.HeaderText = "NºCUENTA"
        Me.CUENTABANCO.Name = "CUENTABANCO"
        Me.CUENTABANCO.ReadOnly = True
        Me.CUENTABANCO.Width = 200
        '
        'ENTIDAD
        '
        Me.ENTIDAD.DataPropertyName = "ENTIDAD"
        Me.ENTIDAD.HeaderText = "ENTIDAD"
        Me.ENTIDAD.Name = "ENTIDAD"
        Me.ENTIDAD.ReadOnly = True
        Me.ENTIDAD.Visible = False
        '
        'OFICINA
        '
        Me.OFICINA.DataPropertyName = "OFICINA"
        Me.OFICINA.HeaderText = "OFICINA"
        Me.OFICINA.Name = "OFICINA"
        Me.OFICINA.ReadOnly = True
        Me.OFICINA.Visible = False
        '
        'DC
        '
        Me.DC.DataPropertyName = "DC"
        Me.DC.HeaderText = "DC"
        Me.DC.Name = "DC"
        Me.DC.ReadOnly = True
        Me.DC.Visible = False
        '
        'CUENTA
        '
        Me.CUENTA.DataPropertyName = "CUENTA"
        Me.CUENTA.HeaderText = "CUENTA"
        Me.CUENTA.Name = "CUENTA"
        Me.CUENTA.ReadOnly = True
        Me.CUENTA.Visible = False
        '
        'CONCEPTO
        '
        Me.CONCEPTO.DataPropertyName = "CONCEPTO"
        Me.CONCEPTO.HeaderText = "CONCEPTO"
        Me.CONCEPTO.Name = "CONCEPTO"
        Me.CONCEPTO.ReadOnly = True
        '
        'FECHACOBRO
        '
        Me.FECHACOBRO.DataPropertyName = "FECHACOBRO"
        DataGridViewCellStyle4.Format = "d"
        Me.FECHACOBRO.DefaultCellStyle = DataGridViewCellStyle4
        Me.FECHACOBRO.HeaderText = "FECHACOBRO"
        Me.FECHACOBRO.Name = "FECHACOBRO"
        Me.FECHACOBRO.ReadOnly = True
        '
        'N19
        '
        Me.N19.DataPropertyName = "N19"
        Me.N19.HeaderText = "N19"
        Me.N19.Name = "N19"
        Me.N19.ReadOnly = True
        Me.N19.Visible = False
        '
        'REFFORMAPAGO
        '
        Me.REFFORMAPAGO.DataPropertyName = "REFFORMAPAGO"
        Me.REFFORMAPAGO.HeaderText = "REFFORMAPAGO"
        Me.REFFORMAPAGO.Name = "REFFORMAPAGO"
        Me.REFFORMAPAGO.ReadOnly = True
        Me.REFFORMAPAGO.Visible = False
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "TIPO"
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.Visible = False
        '
        'REFEMPRESA
        '
        Me.REFEMPRESA.DataPropertyName = "REFEMPRESA"
        Me.REFEMPRESA.HeaderText = "REFEMPRESA"
        Me.REFEMPRESA.Name = "REFEMPRESA"
        Me.REFEMPRESA.ReadOnly = True
        Me.REFEMPRESA.Visible = False
        '
        'RECIBOSBindingSource
        '
        Me.RECIBOSBindingSource.DataMember = "RECIBOS"
        Me.RECIBOSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Remesa resultante"
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
        'dtp_fechafinal
        '
        Me.dtp_fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechafinal.Location = New System.Drawing.Point(143, 39)
        Me.dtp_fechafinal.Name = "dtp_fechafinal"
        Me.dtp_fechafinal.Size = New System.Drawing.Size(109, 20)
        Me.dtp_fechafinal.TabIndex = 1
        '
        'dtp_fechainicial
        '
        Me.dtp_fechainicial.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fechainicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechainicial.Location = New System.Drawing.Point(12, 39)
        Me.dtp_fechainicial.Name = "dtp_fechainicial"
        Me.dtp_fechainicial.Size = New System.Drawing.Size(109, 20)
        Me.dtp_fechainicial.TabIndex = 0
        '
        'bt_mostrar
        '
        Me.bt_mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_mostrar.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_mostrar.Location = New System.Drawing.Point(663, 416)
        Me.bt_mostrar.Name = "bt_mostrar"
        Me.bt_mostrar.Size = New System.Drawing.Size(38, 27)
        Me.bt_mostrar.TabIndex = 5
        Me.bt_mostrar.UseVisualStyleBackColor = True
        '
        'bt_filtrar
        '
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.ImageIndex = 0
        Me.bt_filtrar.ImageList = Me.ImageList1
        Me.bt_filtrar.Location = New System.Drawing.Point(534, 35)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(75, 28)
        Me.bt_filtrar.TabIndex = 3
        Me.bt_filtrar.Text = "Filtrar   "
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search4doc.ico")
        '
        'bt_generar
        '
        Me.bt_generar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_generar.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_generar.Location = New System.Drawing.Point(476, 457)
        Me.bt_generar.Name = "bt_generar"
        Me.bt_generar.Size = New System.Drawing.Size(149, 30)
        Me.bt_generar.TabIndex = 1
        Me.bt_generar.Text = "Emitir e Imprimir remesa"
        Me.bt_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_generar.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(631, 457)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 30)
        Me.bt_cancelar.TabIndex = 2
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'RECIBOSTableAdapter
        '
        Me.RECIBOSTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_FilasFiltradas, Me.tsl_FilasSeleccionadas})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 496)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(724, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsl_FilasFiltradas
        '
        Me.tsl_FilasFiltradas.Name = "tsl_FilasFiltradas"
        Me.tsl_FilasFiltradas.Size = New System.Drawing.Size(116, 17)
        Me.tsl_FilasFiltradas.Text = "Mostrando registros."
        '
        'tsl_FilasSeleccionadas
        '
        Me.tsl_FilasSeleccionadas.Name = "tsl_FilasSeleccionadas"
        Me.tsl_FilasSeleccionadas.Size = New System.Drawing.Size(107, 17)
        Me.tsl_FilasSeleccionadas.Text = "filas seleccionadas."
        '
        'form_remesa_de_recibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(724, 518)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.bt_generar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.gb_generarRecibos)
        Me.Name = "form_remesa_de_recibos"
        Me.ShowIcon = False
        Me.Text = "form_remesa_de_recibos"
        Me.gb_generarRecibos.ResumeLayout(False)
        Me.gb_generarRecibos.PerformLayout()
        CType(Me.dtg_recibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_generar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents gb_generarRecibos As System.Windows.Forms.GroupBox
    Friend WithEvents dtg_recibos As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lb_fechafinal As System.Windows.Forms.Label
    Friend WithEvents lb_fechainicial As System.Windows.Forms.Label
    Friend WithEvents dtp_fechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechainicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_mostrar As System.Windows.Forms.Button
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents chb_listaremitidos As System.Windows.Forms.CheckBox
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents RECIBOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECIBOSTableAdapter As centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsl_FilasFiltradas As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsl_FilasSeleccionadas As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMITIDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAEMISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFPACIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COBRADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFACTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAVENCIMIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUENTABANCO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OFICINA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUENTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONCEPTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHACOBRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFORMAPAGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFEMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
