<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturas_ADD
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim DocumentacionAsociadaLabel As System.Windows.Forms.Label
        Dim PrivadoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturas_ADD))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_FechaPagado = New System.Windows.Forms.DateTimePicker()
        Me.CtrlDocProcesados1 = New centro_medico.ctrlDocProcesados()
        Me.cmb_Estado = New System.Windows.Forms.ComboBox()
        Me.N_FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.N_Factura_TiposComboBox = New System.Windows.Forms.ComboBox()
        Me.N_Factura_TiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.ReferenciaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.tc_Presupuestos = New System.Windows.Forms.TabControl()
        Me.tb_Lineas = New System.Windows.Forms.TabPage()
        Me.bt_ValidarLineas = New System.Windows.Forms.Button()
        Me.bt_ImprimirFactura = New System.Windows.Forms.Button()
        Me.N_Factura_LineasDataGridView = New System.Windows.Forms.DataGridView()
        Me.L = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_Factura_LineasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_NuevaLinea = New System.Windows.Forms.Button()
        Me.tb_Totales = New System.Windows.Forms.TabPage()
        Me.lbl_ImporteNeto = New System.Windows.Forms.Button()
        Me.lbl_Finaciacion = New System.Windows.Forms.Button()
        Me.lbl_Suma = New System.Windows.Forms.Button()
        Me.lbl_RE = New System.Windows.Forms.Button()
        Me.lbl_Portes = New System.Windows.Forms.Button()
        Me.lbl_IVA = New System.Windows.Forms.Button()
        Me.lbl_TipoIVA = New System.Windows.Forms.Button()
        Me.lbl_Descuento = New System.Windows.Forms.Button()
        Me.lbl_TOTAL = New System.Windows.Forms.Button()
        Me.lbl_ProntoPago = New System.Windows.Forms.Button()
        Me.lbl_IRPF = New System.Windows.Forms.Button()
        Me.IRPFCantidadTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.IRPFPorcientoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.txt_Total = New centro_medico.ctrlTextboxAvanzado()
        Me.ObservacionesTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.CtrlFormaPago1 = New centro_medico.ctrlFormaPago()
        Me.TextBox7 = New centro_medico.ctrlTextboxAvanzado()
        Me.pnl_Totales = New System.Windows.Forms.Panel()
        Me.tb_OtrosDatos = New System.Windows.Forms.TabPage()
        Me.grbDocumentos = New System.Windows.Forms.GroupBox()
        Me.grpPortes = New System.Windows.Forms.GroupBox()
        Me.rb_PorteNoPagado = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PorteTextoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.ComentariosTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DocumentacionAsociadaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.PrivadoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tst_SumaNeta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tst_TotalNeto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.N_Factura_LineasTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Factura_LineasTableAdapter()
        Me.N_FacturaTableAdapter = New centro_medico.CMDataSetTableAdapters.N_FacturaTableAdapter()
        Me.N_Factura_TiposTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Factura_TiposTableAdapter()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.CtrlStatusPaciente1 = New centro_medico.ctrlStatusPaciente()
        Me.chk_pagado = New System.Windows.Forms.CheckBox()
        CodigoLabel = New System.Windows.Forms.Label()
        ReferenciaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        DocumentacionAsociadaLabel = New System.Windows.Forms.Label()
        PrivadoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.N_FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Factura_TiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_Presupuestos.SuspendLayout()
        Me.tb_Lineas.SuspendLayout()
        CType(Me.N_Factura_LineasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Factura_LineasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_Totales.SuspendLayout()
        Me.tb_OtrosDatos.SuspendLayout()
        Me.grpPortes.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(45, 21)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(78, 13)
        CodigoLabel.TabIndex = 2
        CodigoLabel.Text = "No. de Factura"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(473, 47)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(43, 13)
        ReferenciaLabel.TabIndex = 6
        ReferenciaLabel.Text = "Su Ref:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(476, 20)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 8
        FechaLabel.Text = "Fecha:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(473, 73)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(43, 13)
        Label2.TabIndex = 16
        Label2.Text = "Estado:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(44, 421)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 43
        ObservacionesLabel.Text = "Observaciones:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(34, 170)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(68, 13)
        ComentariosLabel.TabIndex = 14
        ComentariosLabel.Text = "Comentarios:"
        '
        'DocumentacionAsociadaLabel
        '
        DocumentacionAsociadaLabel.Location = New System.Drawing.Point(10, 135)
        DocumentacionAsociadaLabel.Name = "DocumentacionAsociadaLabel"
        DocumentacionAsociadaLabel.Size = New System.Drawing.Size(92, 28)
        DocumentacionAsociadaLabel.TabIndex = 12
        DocumentacionAsociadaLabel.Text = "Documentaci�n Asociada:"
        DocumentacionAsociadaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrivadoLabel
        '
        PrivadoLabel.AutoSize = True
        PrivadoLabel.Location = New System.Drawing.Point(56, 93)
        PrivadoLabel.Name = "PrivadoLabel"
        PrivadoLabel.Size = New System.Drawing.Size(46, 13)
        PrivadoLabel.TabIndex = 10
        PrivadoLabel.Text = "Privado:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.chk_pagado)
        Me.GroupBox1.Controls.Add(Me.CtrlPaciente1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaPagado)
        Me.GroupBox1.Controls.Add(Me.CtrlDocProcesados1)
        Me.GroupBox1.Controls.Add(Me.cmb_Estado)
        Me.GroupBox1.Controls.Add(Me.N_Factura_TiposComboBox)
        Me.GroupBox1.Controls.Add(CodigoLabel)
        Me.GroupBox1.Controls.Add(ReferenciaLabel)
        Me.GroupBox1.Controls.Add(Me.CodigoTextBox)
        Me.GroupBox1.Controls.Add(Me.ReferenciaTextBox)
        Me.GroupBox1.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox1.Controls.Add(FechaLabel)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(832, 125)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(48, 46)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(382, 50)
        Me.CtrlPaciente1.TabIndex = 91
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Pagado:"
        '
        'dtp_FechaPagado
        '
        Me.dtp_FechaPagado.Checked = False
        Me.dtp_FechaPagado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaPagado.Location = New System.Drawing.Point(163, 97)
        Me.dtp_FechaPagado.Name = "dtp_FechaPagado"
        Me.dtp_FechaPagado.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaPagado.TabIndex = 21
        '
        'CtrlDocProcesados1
        '
        Me.CtrlDocProcesados1.Location = New System.Drawing.Point(667, 9)
        Me.CtrlDocProcesados1.Name = "CtrlDocProcesados1"
        Me.CtrlDocProcesados1.Size = New System.Drawing.Size(155, 97)
        Me.CtrlDocProcesados1.TabIndex = 87
        '
        'cmb_Estado
        '
        Me.cmb_Estado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.N_FacturaBindingSource, "ID_Estado", True))
        Me.cmb_Estado.DisplayMember = "ID_Estado"
        Me.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Estado.Location = New System.Drawing.Point(522, 69)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(119, 21)
        Me.cmb_Estado.TabIndex = 84
        Me.cmb_Estado.ValueMember = "ID_Estado"
        '
        'N_FacturaBindingSource
        '
        Me.N_FacturaBindingSource.DataMember = "N_Factura"
        Me.N_FacturaBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_Factura_TiposComboBox
        '
        Me.N_Factura_TiposComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_FacturaBindingSource, "ID_TipoFactura", True))
        Me.N_Factura_TiposComboBox.DataSource = Me.N_Factura_TiposBindingSource
        Me.N_Factura_TiposComboBox.DisplayMember = "Codigo"
        Me.N_Factura_TiposComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.N_Factura_TiposComboBox.Location = New System.Drawing.Point(129, 17)
        Me.N_Factura_TiposComboBox.Name = "N_Factura_TiposComboBox"
        Me.N_Factura_TiposComboBox.Size = New System.Drawing.Size(61, 21)
        Me.N_Factura_TiposComboBox.TabIndex = 3
        Me.N_Factura_TiposComboBox.ValueMember = "ID_TipoFactura"
        '
        'N_Factura_TiposBindingSource
        '
        Me.N_Factura_TiposBindingSource.DataMember = "N_Factura_Tipos"
        Me.N_Factura_TiposBindingSource.DataSource = Me.CMDataSet
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.AcceptsReturn = True
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturaBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(196, 18)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(114, 20)
        Me.CodigoTextBox.TabIndex = 3
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.AcceptsReturn = True
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturaBindingSource, "Referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(522, 44)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(119, 20)
        Me.ReferenciaTextBox.TabIndex = 7
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_FacturaBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(522, 16)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(86, 20)
        Me.FechaDateTimePicker.TabIndex = 9
        '
        'tc_Presupuestos
        '
        Me.tc_Presupuestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_Presupuestos.Controls.Add(Me.tb_Lineas)
        Me.tc_Presupuestos.Controls.Add(Me.tb_Totales)
        Me.tc_Presupuestos.Controls.Add(Me.tb_OtrosDatos)
        Me.tc_Presupuestos.Location = New System.Drawing.Point(-1, 159)
        Me.tc_Presupuestos.Name = "tc_Presupuestos"
        Me.tc_Presupuestos.SelectedIndex = 0
        Me.tc_Presupuestos.Size = New System.Drawing.Size(837, 486)
        Me.tc_Presupuestos.TabIndex = 3
        '
        'tb_Lineas
        '
        Me.tb_Lineas.AutoScroll = True
        Me.tb_Lineas.Controls.Add(Me.bt_ValidarLineas)
        Me.tb_Lineas.Controls.Add(Me.bt_ImprimirFactura)
        Me.tb_Lineas.Controls.Add(Me.N_Factura_LineasDataGridView)
        Me.tb_Lineas.Controls.Add(Me.btn_Eliminar)
        Me.tb_Lineas.Controls.Add(Me.btn_Editar)
        Me.tb_Lineas.Controls.Add(Me.btn_NuevaLinea)
        Me.tb_Lineas.Location = New System.Drawing.Point(4, 22)
        Me.tb_Lineas.Name = "tb_Lineas"
        Me.tb_Lineas.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Lineas.Size = New System.Drawing.Size(829, 460)
        Me.tb_Lineas.TabIndex = 0
        Me.tb_Lineas.Text = "L�neas de Detalle"
        Me.tb_Lineas.UseVisualStyleBackColor = True
        '
        'bt_ValidarLineas
        '
        Me.bt_ValidarLineas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_ValidarLineas.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.bt_ValidarLineas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_ValidarLineas.Location = New System.Drawing.Point(333, 371)
        Me.bt_ValidarLineas.Name = "bt_ValidarLineas"
        Me.bt_ValidarLineas.Size = New System.Drawing.Size(104, 31)
        Me.bt_ValidarLineas.TabIndex = 5
        Me.bt_ValidarLineas.Text = "Validar L�neas"
        Me.bt_ValidarLineas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_ValidarLineas.UseVisualStyleBackColor = True
        '
        'bt_ImprimirFactura
        '
        Me.bt_ImprimirFactura.Location = New System.Drawing.Point(695, 368)
        Me.bt_ImprimirFactura.Name = "bt_ImprimirFactura"
        Me.bt_ImprimirFactura.Size = New System.Drawing.Size(125, 31)
        Me.bt_ImprimirFactura.TabIndex = 4
        Me.bt_ImprimirFactura.Text = "Imprimir Factura"
        Me.bt_ImprimirFactura.UseVisualStyleBackColor = True
        Me.bt_ImprimirFactura.Visible = False
        '
        'N_Factura_LineasDataGridView
        '
        Me.N_Factura_LineasDataGridView.AllowUserToAddRows = False
        Me.N_Factura_LineasDataGridView.AllowUserToDeleteRows = False
        Me.N_Factura_LineasDataGridView.AllowUserToResizeRows = False
        Me.N_Factura_LineasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_Factura_LineasDataGridView.AutoGenerateColumns = False
        Me.N_Factura_LineasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.N_Factura_LineasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.L, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn13, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.N_Factura_LineasDataGridView.DataSource = Me.N_Factura_LineasBindingSource
        Me.N_Factura_LineasDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.N_Factura_LineasDataGridView.MultiSelect = False
        Me.N_Factura_LineasDataGridView.Name = "N_Factura_LineasDataGridView"
        Me.N_Factura_LineasDataGridView.ReadOnly = True
        Me.N_Factura_LineasDataGridView.RowHeadersVisible = False
        Me.N_Factura_LineasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_Factura_LineasDataGridView.Size = New System.Drawing.Size(814, 346)
        Me.N_Factura_LineasDataGridView.TabIndex = 3
        '
        'L
        '
        Me.L.FillWeight = 1.0!
        Me.L.HeaderText = "L"
        Me.L.MinimumWidth = 20
        Me.L.Name = "L"
        Me.L.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Factura"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_Factura"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 65
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_Articulo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID_Articulo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 74
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 62
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Descuento1"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Dto 1"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 58
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Descuento2"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Dto 2"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 58
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Descuento3"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Dto 3"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 58
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 56
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ID_TipoIVA"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ID_TipoIVA"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IVAIncluido"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "IVAIncluido"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Costo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Imagen"
        Me.DataGridViewImageColumn1.HeaderText = "Imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ID_Almacen"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ID_Almacen"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'N_Factura_LineasBindingSource
        '
        Me.N_Factura_LineasBindingSource.DataMember = "N_Factura_Lineas"
        Me.N_Factura_LineasBindingSource.DataSource = Me.CMDataSet
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.Location = New System.Drawing.Point(223, 371)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(104, 31)
        Me.btn_Eliminar.TabIndex = 1
        Me.btn_Eliminar.Text = "Eliminar L�nea"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Editar.Enabled = False
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Editar.Location = New System.Drawing.Point(113, 371)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(104, 31)
        Me.btn_Editar.TabIndex = 1
        Me.btn_Editar.Text = "Editar L�nea"
        Me.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_NuevaLinea
        '
        Me.btn_NuevaLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_NuevaLinea.Image = CType(resources.GetObject("btn_NuevaLinea.Image"), System.Drawing.Image)
        Me.btn_NuevaLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NuevaLinea.Location = New System.Drawing.Point(3, 371)
        Me.btn_NuevaLinea.Name = "btn_NuevaLinea"
        Me.btn_NuevaLinea.Size = New System.Drawing.Size(104, 31)
        Me.btn_NuevaLinea.TabIndex = 1
        Me.btn_NuevaLinea.Text = "Nueva L�nea"
        Me.btn_NuevaLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NuevaLinea.UseVisualStyleBackColor = True
        '
        'tb_Totales
        '
        Me.tb_Totales.AutoScroll = True
        Me.tb_Totales.Controls.Add(Me.lbl_ImporteNeto)
        Me.tb_Totales.Controls.Add(Me.lbl_Finaciacion)
        Me.tb_Totales.Controls.Add(Me.lbl_Suma)
        Me.tb_Totales.Controls.Add(Me.lbl_RE)
        Me.tb_Totales.Controls.Add(Me.lbl_Portes)
        Me.tb_Totales.Controls.Add(Me.lbl_IVA)
        Me.tb_Totales.Controls.Add(Me.lbl_TipoIVA)
        Me.tb_Totales.Controls.Add(Me.lbl_Descuento)
        Me.tb_Totales.Controls.Add(Me.lbl_TOTAL)
        Me.tb_Totales.Controls.Add(Me.lbl_ProntoPago)
        Me.tb_Totales.Controls.Add(Me.lbl_IRPF)
        Me.tb_Totales.Controls.Add(Me.IRPFCantidadTextBox)
        Me.tb_Totales.Controls.Add(Me.IRPFPorcientoTextBox)
        Me.tb_Totales.Controls.Add(Me.txt_Total)
        Me.tb_Totales.Controls.Add(ObservacionesLabel)
        Me.tb_Totales.Controls.Add(Me.ObservacionesTextBox)
        Me.tb_Totales.Controls.Add(Me.CtrlFormaPago1)
        Me.tb_Totales.Controls.Add(Me.TextBox7)
        Me.tb_Totales.Controls.Add(Me.pnl_Totales)
        Me.tb_Totales.Location = New System.Drawing.Point(4, 22)
        Me.tb_Totales.Name = "tb_Totales"
        Me.tb_Totales.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Totales.Size = New System.Drawing.Size(829, 460)
        Me.tb_Totales.TabIndex = 1
        Me.tb_Totales.Text = "Totales"
        Me.tb_Totales.UseVisualStyleBackColor = True
        '
        'lbl_ImporteNeto
        '
        Me.lbl_ImporteNeto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_ImporteNeto.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_ImporteNeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_ImporteNeto.Location = New System.Drawing.Point(147, 17)
        Me.lbl_ImporteNeto.Name = "lbl_ImporteNeto"
        Me.lbl_ImporteNeto.Size = New System.Drawing.Size(91, 23)
        Me.lbl_ImporteNeto.TabIndex = 52
        Me.lbl_ImporteNeto.Text = "Importe Neto"
        Me.lbl_ImporteNeto.UseVisualStyleBackColor = False
        '
        'lbl_Finaciacion
        '
        Me.lbl_Finaciacion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Finaciacion.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_Finaciacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Finaciacion.Location = New System.Drawing.Point(552, 17)
        Me.lbl_Finaciacion.Name = "lbl_Finaciacion"
        Me.lbl_Finaciacion.Size = New System.Drawing.Size(91, 23)
        Me.lbl_Finaciacion.TabIndex = 55
        Me.lbl_Finaciacion.Text = "Financiaci�n"
        Me.lbl_Finaciacion.UseVisualStyleBackColor = False
        '
        'lbl_Suma
        '
        Me.lbl_Suma.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Suma.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_Suma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Suma.Location = New System.Drawing.Point(77, 166)
        Me.lbl_Suma.Name = "lbl_Suma"
        Me.lbl_Suma.Size = New System.Drawing.Size(158, 23)
        Me.lbl_Suma.TabIndex = 50
        Me.lbl_Suma.UseVisualStyleBackColor = False
        '
        'lbl_RE
        '
        Me.lbl_RE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_RE.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_RE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_RE.Location = New System.Drawing.Point(358, 166)
        Me.lbl_RE.Name = "lbl_RE"
        Me.lbl_RE.Size = New System.Drawing.Size(91, 23)
        Me.lbl_RE.TabIndex = 49
        Me.lbl_RE.Text = "RE"
        Me.lbl_RE.UseVisualStyleBackColor = False
        '
        'lbl_Portes
        '
        Me.lbl_Portes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Portes.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_Portes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Portes.Location = New System.Drawing.Point(455, 17)
        Me.lbl_Portes.Name = "lbl_Portes"
        Me.lbl_Portes.Size = New System.Drawing.Size(91, 23)
        Me.lbl_Portes.TabIndex = 56
        Me.lbl_Portes.Text = "Portes"
        Me.lbl_Portes.UseVisualStyleBackColor = False
        '
        'lbl_IVA
        '
        Me.lbl_IVA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_IVA.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_IVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_IVA.Location = New System.Drawing.Point(244, 166)
        Me.lbl_IVA.Name = "lbl_IVA"
        Me.lbl_IVA.Size = New System.Drawing.Size(108, 23)
        Me.lbl_IVA.TabIndex = 48
        Me.lbl_IVA.Text = "IVA"
        Me.lbl_IVA.UseVisualStyleBackColor = False
        '
        'lbl_TipoIVA
        '
        Me.lbl_TipoIVA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_TipoIVA.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_TipoIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_TipoIVA.Location = New System.Drawing.Point(80, 17)
        Me.lbl_TipoIVA.Name = "lbl_TipoIVA"
        Me.lbl_TipoIVA.Size = New System.Drawing.Size(61, 23)
        Me.lbl_TipoIVA.TabIndex = 51
        Me.lbl_TipoIVA.Text = "IVA"
        Me.lbl_TipoIVA.UseVisualStyleBackColor = False
        '
        'lbl_Descuento
        '
        Me.lbl_Descuento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Descuento.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_Descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Descuento.Location = New System.Drawing.Point(244, 17)
        Me.lbl_Descuento.Name = "lbl_Descuento"
        Me.lbl_Descuento.Size = New System.Drawing.Size(108, 23)
        Me.lbl_Descuento.TabIndex = 57
        Me.lbl_Descuento.Text = "Descuento"
        Me.lbl_Descuento.UseVisualStyleBackColor = False
        '
        'lbl_TOTAL
        '
        Me.lbl_TOTAL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_TOTAL.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_TOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_TOTAL.Location = New System.Drawing.Point(552, 166)
        Me.lbl_TOTAL.Name = "lbl_TOTAL"
        Me.lbl_TOTAL.Size = New System.Drawing.Size(91, 23)
        Me.lbl_TOTAL.TabIndex = 53
        Me.lbl_TOTAL.Text = "TOTAL"
        Me.lbl_TOTAL.UseVisualStyleBackColor = False
        '
        'lbl_ProntoPago
        '
        Me.lbl_ProntoPago.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_ProntoPago.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_ProntoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_ProntoPago.Location = New System.Drawing.Point(358, 17)
        Me.lbl_ProntoPago.Name = "lbl_ProntoPago"
        Me.lbl_ProntoPago.Size = New System.Drawing.Size(91, 23)
        Me.lbl_ProntoPago.TabIndex = 58
        Me.lbl_ProntoPago.Text = "Pronto Pago"
        Me.lbl_ProntoPago.UseVisualStyleBackColor = False
        '
        'lbl_IRPF
        '
        Me.lbl_IRPF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_IRPF.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_IRPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_IRPF.Location = New System.Drawing.Point(455, 166)
        Me.lbl_IRPF.Name = "lbl_IRPF"
        Me.lbl_IRPF.Size = New System.Drawing.Size(91, 23)
        Me.lbl_IRPF.TabIndex = 54
        Me.lbl_IRPF.Text = "IRPF"
        Me.lbl_IRPF.UseVisualStyleBackColor = False
        '
        'IRPFCantidadTextBox
        '
        Me.IRPFCantidadTextBox.AcceptsReturn = True
        Me.IRPFCantidadTextBox.Location = New System.Drawing.Point(493, 197)
        Me.IRPFCantidadTextBox.Name = "IRPFCantidadTextBox"
        Me.IRPFCantidadTextBox.Size = New System.Drawing.Size(54, 20)
        Me.IRPFCantidadTextBox.TabIndex = 47
        Me.IRPFCantidadTextBox.Text = "0"
        Me.IRPFCantidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IRPFPorcientoTextBox
        '
        Me.IRPFPorcientoTextBox.AcceptsReturn = True
        Me.IRPFPorcientoTextBox.Location = New System.Drawing.Point(456, 197)
        Me.IRPFPorcientoTextBox.Name = "IRPFPorcientoTextBox"
        Me.IRPFPorcientoTextBox.Size = New System.Drawing.Size(33, 20)
        Me.IRPFPorcientoTextBox.TabIndex = 46
        Me.IRPFPorcientoTextBox.Text = "0"
        Me.IRPFPorcientoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Total
        '
        Me.txt_Total.AcceptsReturn = True
        Me.txt_Total.BackColor = System.Drawing.SystemColors.Info
        Me.txt_Total.Location = New System.Drawing.Point(552, 197)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(91, 20)
        Me.txt_Total.TabIndex = 59
        Me.txt_Total.Text = "0"
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.AcceptsReturn = True
        Me.ObservacionesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturaBindingSource, "Comentarios", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(127, 421)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(558, 33)
        Me.ObservacionesTextBox.TabIndex = 44
        '
        'CtrlFormaPago1
        '
        Me.CtrlFormaPago1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CtrlFormaPago1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlFormaPago1.DataBindings.Add(New System.Windows.Forms.Binding("ID_FormaPago", Me.N_FacturaBindingSource, "ID_FormaPago", True))
        Me.CtrlFormaPago1.ID_FormaPago = Nothing
        Me.CtrlFormaPago1.Location = New System.Drawing.Point(48, 386)
        Me.CtrlFormaPago1.Name = "CtrlFormaPago1"
        Me.CtrlFormaPago1.Size = New System.Drawing.Size(265, 29)
        Me.CtrlFormaPago1.TabIndex = 0
        '
        'TextBox7
        '
        Me.TextBox7.AcceptsReturn = True
        Me.TextBox7.Location = New System.Drawing.Point(-254, 132)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 4
        '
        'pnl_Totales
        '
        Me.pnl_Totales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_Totales.AutoScroll = True
        Me.pnl_Totales.Location = New System.Drawing.Point(3, 3)
        Me.pnl_Totales.Name = "pnl_Totales"
        Me.pnl_Totales.Size = New System.Drawing.Size(721, 366)
        Me.pnl_Totales.TabIndex = 8
        '
        'tb_OtrosDatos
        '
        Me.tb_OtrosDatos.AutoScroll = True
        Me.tb_OtrosDatos.Controls.Add(Me.grbDocumentos)
        Me.tb_OtrosDatos.Controls.Add(Me.grpPortes)
        Me.tb_OtrosDatos.Controls.Add(ComentariosLabel)
        Me.tb_OtrosDatos.Controls.Add(Me.ComentariosTextBox)
        Me.tb_OtrosDatos.Controls.Add(DocumentacionAsociadaLabel)
        Me.tb_OtrosDatos.Controls.Add(Me.DocumentacionAsociadaTextBox)
        Me.tb_OtrosDatos.Controls.Add(PrivadoLabel)
        Me.tb_OtrosDatos.Controls.Add(Me.PrivadoTextBox)
        Me.tb_OtrosDatos.Location = New System.Drawing.Point(4, 22)
        Me.tb_OtrosDatos.Name = "tb_OtrosDatos"
        Me.tb_OtrosDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_OtrosDatos.Size = New System.Drawing.Size(829, 460)
        Me.tb_OtrosDatos.TabIndex = 2
        Me.tb_OtrosDatos.Text = "Otros datos"
        Me.tb_OtrosDatos.UseVisualStyleBackColor = True
        '
        'grbDocumentos
        '
        Me.grbDocumentos.Location = New System.Drawing.Point(666, 11)
        Me.grbDocumentos.Name = "grbDocumentos"
        Me.grbDocumentos.Size = New System.Drawing.Size(157, 152)
        Me.grbDocumentos.TabIndex = 21
        Me.grbDocumentos.TabStop = False
        Me.grbDocumentos.Text = "Documentos Adjuntos"
        '
        'grpPortes
        '
        Me.grpPortes.Controls.Add(Me.rb_PorteNoPagado)
        Me.grpPortes.Controls.Add(Me.RadioButton1)
        Me.grpPortes.Controls.Add(Me.PorteTextoTextBox)
        Me.grpPortes.Location = New System.Drawing.Point(20, 11)
        Me.grpPortes.Name = "grpPortes"
        Me.grpPortes.Size = New System.Drawing.Size(640, 73)
        Me.grpPortes.TabIndex = 17
        Me.grpPortes.TabStop = False
        Me.grpPortes.Text = "Portes"
        '
        'rb_PorteNoPagado
        '
        Me.rb_PorteNoPagado.AutoSize = True
        Me.rb_PorteNoPagado.Location = New System.Drawing.Point(88, 22)
        Me.rb_PorteNoPagado.Name = "rb_PorteNoPagado"
        Me.rb_PorteNoPagado.Size = New System.Drawing.Size(59, 17)
        Me.rb_PorteNoPagado.TabIndex = 10
        Me.rb_PorteNoPagado.Text = "Debido"
        Me.rb_PorteNoPagado.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.N_FacturaBindingSource, "PortePagado", True))
        Me.RadioButton1.Location = New System.Drawing.Point(15, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Pagado"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PorteTextoTextBox
        '
        Me.PorteTextoTextBox.AcceptsReturn = True
        Me.PorteTextoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PorteTextoTextBox.Location = New System.Drawing.Point(15, 45)
        Me.PorteTextoTextBox.Name = "PorteTextoTextBox"
        Me.PorteTextoTextBox.Size = New System.Drawing.Size(610, 20)
        Me.PorteTextoTextBox.TabIndex = 9
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.AcceptsReturn = True
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturaBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(108, 170)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ComentariosTextBox.Size = New System.Drawing.Size(540, 35)
        Me.ComentariosTextBox.TabIndex = 15
        '
        'DocumentacionAsociadaTextBox
        '
        Me.DocumentacionAsociadaTextBox.AcceptsReturn = True
        Me.DocumentacionAsociadaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturaBindingSource, "DocumentacionAsociada", True))
        Me.DocumentacionAsociadaTextBox.Location = New System.Drawing.Point(108, 132)
        Me.DocumentacionAsociadaTextBox.Multiline = True
        Me.DocumentacionAsociadaTextBox.Name = "DocumentacionAsociadaTextBox"
        Me.DocumentacionAsociadaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DocumentacionAsociadaTextBox.Size = New System.Drawing.Size(540, 31)
        Me.DocumentacionAsociadaTextBox.TabIndex = 13
        '
        'PrivadoTextBox
        '
        Me.PrivadoTextBox.AcceptsReturn = True
        Me.PrivadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturaBindingSource, "Privado", True))
        Me.PrivadoTextBox.Location = New System.Drawing.Point(108, 90)
        Me.PrivadoTextBox.Multiline = True
        Me.PrivadoTextBox.Name = "PrivadoTextBox"
        Me.PrivadoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PrivadoTextBox.Size = New System.Drawing.Size(540, 35)
        Me.PrivadoTextBox.TabIndex = 11
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_SumaNeta, Me.ToolStripStatusLabel1, Me.tst_TotalNeto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 650)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(835, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tst_SumaNeta
        '
        Me.tst_SumaNeta.Name = "tst_SumaNeta"
        Me.tst_SumaNeta.Size = New System.Drawing.Size(77, 17)
        Me.tst_SumaNeta.Text = "Suma Neta: 0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(127, 17)
        Me.ToolStripStatusLabel1.Text = "                                        "
        '
        'tst_TotalNeto
        '
        Me.tst_TotalNeto.Name = "tst_TotalNeto"
        Me.tst_TotalNeto.Size = New System.Drawing.Size(46, 17)
        Me.tst_TotalNeto.Text = "Total: 0"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(754, 647)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 5
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        Me.btn_Guardar.Visible = False
        '
        'N_Factura_LineasTableAdapter
        '
        Me.N_Factura_LineasTableAdapter.ClearBeforeFill = True
        '
        'N_FacturaTableAdapter
        '
        Me.N_FacturaTableAdapter.ClearBeforeFill = True
        '
        'N_Factura_TiposTableAdapter
        '
        Me.N_Factura_TiposTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tlbImprimir})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(835, 25)
        Me.ToolStrip2.TabIndex = 20
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'CtrlStatusPaciente1
        '
        Me.CtrlStatusPaciente1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlStatusPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.N_FacturaBindingSource, "ID_Cliente", True))
        Me.CtrlStatusPaciente1.ID_PACIENTE = Nothing
        Me.CtrlStatusPaciente1.Location = New System.Drawing.Point(598, 0)
        Me.CtrlStatusPaciente1.Name = "CtrlStatusPaciente1"
        Me.CtrlStatusPaciente1.Size = New System.Drawing.Size(236, 28)
        Me.CtrlStatusPaciente1.TabIndex = 101
        '
        'chk_pagado
        '
        Me.chk_pagado.AutoSize = True
        Me.chk_pagado.Location = New System.Drawing.Point(144, 100)
        Me.chk_pagado.Name = "chk_pagado"
        Me.chk_pagado.Size = New System.Drawing.Size(15, 14)
        Me.chk_pagado.TabIndex = 92
        Me.chk_pagado.UseVisualStyleBackColor = True
        '
        'frmFacturas_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 672)
        Me.Controls.Add(Me.CtrlStatusPaciente1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tc_Presupuestos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFacturas_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.N_FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Factura_TiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_Presupuestos.ResumeLayout(False)
        Me.tb_Lineas.ResumeLayout(False)
        CType(Me.N_Factura_LineasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Factura_LineasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_Totales.ResumeLayout(False)
        Me.tb_Totales.PerformLayout()
        Me.tb_OtrosDatos.ResumeLayout(False)
        Me.tb_OtrosDatos.PerformLayout()
        Me.grpPortes.ResumeLayout(False)
        Me.grpPortes.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Estado As System.Windows.Forms.ComboBox
    Friend WithEvents N_Factura_TiposComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CodigoTextBox As ctrlTextboxAvanzado
    Friend WithEvents ReferenciaTextBox As ctrlTextboxAvanzado
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents tc_Presupuestos As System.Windows.Forms.TabControl
    Friend WithEvents tb_Lineas As System.Windows.Forms.TabPage
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_NuevaLinea As System.Windows.Forms.Button
    Friend WithEvents tb_Totales As System.Windows.Forms.TabPage
    Friend WithEvents lbl_ImporteNeto As System.Windows.Forms.Button
    Friend WithEvents lbl_Finaciacion As System.Windows.Forms.Button
    Friend WithEvents lbl_Suma As System.Windows.Forms.Button
    Friend WithEvents lbl_RE As System.Windows.Forms.Button
    Friend WithEvents lbl_Portes As System.Windows.Forms.Button
    Friend WithEvents lbl_IVA As System.Windows.Forms.Button
    Friend WithEvents lbl_TipoIVA As System.Windows.Forms.Button
    Friend WithEvents lbl_Descuento As System.Windows.Forms.Button
    Friend WithEvents lbl_TOTAL As System.Windows.Forms.Button
    Friend WithEvents lbl_ProntoPago As System.Windows.Forms.Button
    Friend WithEvents lbl_IRPF As System.Windows.Forms.Button
    Friend WithEvents IRPFCantidadTextBox As ctrlTextboxAvanzado
    Friend WithEvents IRPFPorcientoTextBox As ctrlTextboxAvanzado
    Friend WithEvents txt_Total As ctrlTextboxAvanzado
    Friend WithEvents ObservacionesTextBox As ctrlTextboxAvanzado
    Friend WithEvents CtrlFormaPago1 As ctrlFormaPago
    Friend WithEvents TextBox7 As ctrlTextboxAvanzado
    Friend WithEvents pnl_Totales As System.Windows.Forms.Panel
    Friend WithEvents tb_OtrosDatos As System.Windows.Forms.TabPage
    Friend WithEvents grpPortes As System.Windows.Forms.GroupBox
    Friend WithEvents rb_PorteNoPagado As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents PorteTextoTextBox As ctrlTextboxAvanzado
    Friend WithEvents ComentariosTextBox As ctrlTextboxAvanzado
    Friend WithEvents DocumentacionAsociadaTextBox As ctrlTextboxAvanzado
    Friend WithEvents PrivadoTextBox As ctrlTextboxAvanzado
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tst_SumaNeta As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tst_TotalNeto As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_Factura_LineasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Factura_LineasTableAdapter As CMDataSetTableAdapters.N_Factura_LineasTableAdapter
    Friend WithEvents N_Factura_LineasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents N_FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_FacturaTableAdapter As CMDataSetTableAdapters.N_FacturaTableAdapter
    Friend WithEvents N_Factura_TiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Factura_TiposTableAdapter As CMDataSetTableAdapters.N_Factura_TiposTableAdapter
    Friend WithEvents L As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_ImprimirFactura As System.Windows.Forms.Button
    Friend WithEvents CtrlDocProcesados1 As ctrlDocProcesados
    Friend WithEvents grbDocumentos As System.Windows.Forms.GroupBox
    Friend WithEvents bt_ValidarLineas As System.Windows.Forms.Button
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaPagado As System.Windows.Forms.DateTimePicker
    Friend WithEvents CtrlStatusPaciente1 As centro_medico.ctrlStatusPaciente
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents chk_pagado As System.Windows.Forms.CheckBox
    'Friend WithEvents DocumentManager1 As DocumentManager
    'Friend WithEvents DocumentosBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents DocumentosFacturasTableAdapter As CMDataSetTableAdapters.DocumentosFacturasTableAdapter
End Class
