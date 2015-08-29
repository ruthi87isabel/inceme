<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidos_ADD
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim DocumentacionAsociadaLabel As System.Windows.Forms.Label
        Dim PrivadoLabel As System.Windows.Forms.Label
        Dim PlazoEntregaLabel As System.Windows.Forms.Label
        Dim PedidoPorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidos_ADD))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CtrlDocProcesados1 = New centro_medico.ctrlDocProcesados
        Me.N_PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.cmb_Estado = New System.Windows.Forms.ComboBox
        Me.N_Pedidos_TiposComboBox = New System.Windows.Forms.ComboBox
        Me.N_Pedidos_TiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.tc_Presupuestos = New System.Windows.Forms.TabControl
        Me.tb_Lineas = New System.Windows.Forms.TabPage
        Me.bt_ImprimirPedido = New System.Windows.Forms.Button
        Me.N_Pedidos_LineasDataGridView = New System.Windows.Forms.DataGridView
        Me.L = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDPedidoLineasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDPedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descuento1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descuento2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descuento3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDTipoIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IVAIncluidoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ImagenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BultosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValidadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IDDocOrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDTipoDocOrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.N_Pedidos_LineasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Editar = New System.Windows.Forms.Button
        Me.btn_ValidarLineas = New System.Windows.Forms.Button
        Me.btn_NuevaLinea = New System.Windows.Forms.Button
        Me.tb_Totales = New System.Windows.Forms.TabPage
        Me.lbl_ImporteNeto = New System.Windows.Forms.Button
        Me.lbl_Finaciacion = New System.Windows.Forms.Button
        Me.lbl_Suma = New System.Windows.Forms.Button
        Me.lbl_RE = New System.Windows.Forms.Button
        Me.lbl_Portes = New System.Windows.Forms.Button
        Me.lbl_IVA = New System.Windows.Forms.Button
        Me.lbl_TipoIVA = New System.Windows.Forms.Button
        Me.lbl_Descuento = New System.Windows.Forms.Button
        Me.lbl_TOTAL = New System.Windows.Forms.Button
        Me.lbl_ProntoPago = New System.Windows.Forms.Button
        Me.lbl_IRPF = New System.Windows.Forms.Button
        Me.IRPFCantidadTextBox = New System.Windows.Forms.TextBox
        Me.IRPFPorcientoTextBox = New System.Windows.Forms.TextBox
        Me.txt_Total = New System.Windows.Forms.TextBox
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox
        Me.CtrlFormaPago1 = New centro_medico.ctrlFormaPago
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.pnl_Totales = New System.Windows.Forms.Panel
        Me.tb_OtrosDatos = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PedidoPorTextBox = New System.Windows.Forms.TextBox
        Me.CtrlProveedor1 = New centro_medico.ctrlProveedor
        Me.PlazoEntregaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.grpPortes = New System.Windows.Forms.GroupBox
        Me.rb_PorteNoPagado = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.PorteTextoTextBox = New System.Windows.Forms.TextBox
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox
        Me.DocumentacionAsociadaTextBox = New System.Windows.Forms.TextBox
        Me.PrivadoTextBox = New System.Windows.Forms.TextBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tst_SumaNeta = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tst_TotalNeto = New System.Windows.Forms.ToolStripStatusLabel
        Me.N_Pedidos_TiposTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Pedidos_TiposTableAdapter
        Me.N_PedidosTableAdapter = New centro_medico.CMDataSetTableAdapters.N_PedidosTableAdapter
        Me.N_Pedidos_LineasTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter
        CodigoLabel = New System.Windows.Forms.Label
        ReferenciaLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        ObservacionesLabel = New System.Windows.Forms.Label
        ComentariosLabel = New System.Windows.Forms.Label
        DocumentacionAsociadaLabel = New System.Windows.Forms.Label
        PrivadoLabel = New System.Windows.Forms.Label
        PlazoEntregaLabel = New System.Windows.Forms.Label
        PedidoPorLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.N_PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Pedidos_TiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_Presupuestos.SuspendLayout()
        Me.tb_Lineas.SuspendLayout()
        CType(Me.N_Pedidos_LineasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Pedidos_LineasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_Totales.SuspendLayout()
        Me.tb_OtrosDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpPortes.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(48, 21)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(75, 13)
        CodigoLabel.TabIndex = 2
        CodigoLabel.Text = "No. de Pedido"
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
        ObservacionesLabel.Location = New System.Drawing.Point(39, 343)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 43
        ObservacionesLabel.Text = "Observaciones:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(34, 272)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(68, 13)
        ComentariosLabel.TabIndex = 14
        ComentariosLabel.Text = "Comentarios:"
        '
        'DocumentacionAsociadaLabel
        '
        DocumentacionAsociadaLabel.Location = New System.Drawing.Point(10, 237)
        DocumentacionAsociadaLabel.Name = "DocumentacionAsociadaLabel"
        DocumentacionAsociadaLabel.Size = New System.Drawing.Size(92, 28)
        DocumentacionAsociadaLabel.TabIndex = 12
        DocumentacionAsociadaLabel.Text = "Documentación Asociada:"
        DocumentacionAsociadaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrivadoLabel
        '
        PrivadoLabel.AutoSize = True
        PrivadoLabel.Location = New System.Drawing.Point(56, 195)
        PrivadoLabel.Name = "PrivadoLabel"
        PrivadoLabel.Size = New System.Drawing.Size(46, 13)
        PrivadoLabel.TabIndex = 10
        PrivadoLabel.Text = "Privado:"
        '
        'PlazoEntregaLabel
        '
        PlazoEntregaLabel.AutoSize = True
        PlazoEntregaLabel.Location = New System.Drawing.Point(34, 87)
        PlazoEntregaLabel.Name = "PlazoEntregaLabel"
        PlazoEntregaLabel.Size = New System.Drawing.Size(76, 13)
        PlazoEntregaLabel.TabIndex = 0
        PlazoEntregaLabel.Text = "Plazo Entrega:"
        '
        'PedidoPorLabel
        '
        PedidoPorLabel.AutoSize = True
        PedidoPorLabel.Location = New System.Drawing.Point(43, 60)
        PedidoPorLabel.Name = "PedidoPorLabel"
        PedidoPorLabel.Size = New System.Drawing.Size(62, 13)
        PedidoPorLabel.TabIndex = 3
        PedidoPorLabel.Text = "Pedido Por:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.CtrlDocProcesados1)
        Me.GroupBox1.Controls.Add(Me.cmb_Estado)
        Me.GroupBox1.Controls.Add(Me.N_Pedidos_TiposComboBox)
        Me.GroupBox1.Controls.Add(CodigoLabel)
        Me.GroupBox1.Controls.Add(ReferenciaLabel)
        Me.GroupBox1.Controls.Add(Me.CodigoTextBox)
        Me.GroupBox1.Controls.Add(Me.ReferenciaTextBox)
        Me.GroupBox1.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox1.Controls.Add(FechaLabel)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(832, 108)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'CtrlDocProcesados1
        '
        Me.CtrlDocProcesados1.Location = New System.Drawing.Point(666, 9)
        Me.CtrlDocProcesados1.Name = "CtrlDocProcesados1"
        Me.CtrlDocProcesados1.Size = New System.Drawing.Size(155, 97)
        Me.CtrlDocProcesados1.TabIndex = 88
        '
        'N_PedidosBindingSource
        '
        Me.N_PedidosBindingSource.DataMember = "N_Pedidos"
        Me.N_PedidosBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_Estado
        '
        Me.cmb_Estado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.N_PedidosBindingSource, "ID_Estado", True))
        Me.cmb_Estado.DisplayMember = "ID_Estado"
        Me.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Estado.Location = New System.Drawing.Point(522, 69)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(119, 21)
        Me.cmb_Estado.TabIndex = 84
        Me.cmb_Estado.ValueMember = "ID_Estado"
        '
        'N_Pedidos_TiposComboBox
        '
        Me.N_Pedidos_TiposComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_PedidosBindingSource, "ID_TipoPedido", True))
        Me.N_Pedidos_TiposComboBox.DataSource = Me.N_Pedidos_TiposBindingSource
        Me.N_Pedidos_TiposComboBox.DisplayMember = "Codigo"
        Me.N_Pedidos_TiposComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.N_Pedidos_TiposComboBox.Location = New System.Drawing.Point(129, 17)
        Me.N_Pedidos_TiposComboBox.Name = "N_Pedidos_TiposComboBox"
        Me.N_Pedidos_TiposComboBox.Size = New System.Drawing.Size(40, 21)
        Me.N_Pedidos_TiposComboBox.TabIndex = 3
        Me.N_Pedidos_TiposComboBox.ValueMember = "ID_TipoPedido"
        '
        'N_Pedidos_TiposBindingSource
        '
        Me.N_Pedidos_TiposBindingSource.DataMember = "N_Pedidos_Tipos"
        Me.N_Pedidos_TiposBindingSource.DataSource = Me.CMDataSet
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PedidosBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(173, 18)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(85, 20)
        Me.CodigoTextBox.TabIndex = 3
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PedidosBindingSource, "Referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(522, 44)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(119, 20)
        Me.ReferenciaTextBox.TabIndex = 7
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_PedidosBindingSource, "Fecha", True))
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
        Me.tc_Presupuestos.Location = New System.Drawing.Point(2, 115)
        Me.tc_Presupuestos.Name = "tc_Presupuestos"
        Me.tc_Presupuestos.SelectedIndex = 0
        Me.tc_Presupuestos.Size = New System.Drawing.Size(837, 436)
        Me.tc_Presupuestos.TabIndex = 4
        '
        'tb_Lineas
        '
        Me.tb_Lineas.AutoScroll = True
        Me.tb_Lineas.Controls.Add(Me.bt_ImprimirPedido)
        Me.tb_Lineas.Controls.Add(Me.N_Pedidos_LineasDataGridView)
        Me.tb_Lineas.Controls.Add(Me.btn_Eliminar)
        Me.tb_Lineas.Controls.Add(Me.btn_Editar)
        Me.tb_Lineas.Controls.Add(Me.btn_ValidarLineas)
        Me.tb_Lineas.Controls.Add(Me.btn_NuevaLinea)
        Me.tb_Lineas.Location = New System.Drawing.Point(4, 22)
        Me.tb_Lineas.Name = "tb_Lineas"
        Me.tb_Lineas.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Lineas.Size = New System.Drawing.Size(829, 410)
        Me.tb_Lineas.TabIndex = 0
        Me.tb_Lineas.Text = "Líneas de Detalle"
        Me.tb_Lineas.UseVisualStyleBackColor = True
        '
        'bt_ImprimirPedido
        '
        Me.bt_ImprimirPedido.Location = New System.Drawing.Point(697, 373)
        Me.bt_ImprimirPedido.Name = "bt_ImprimirPedido"
        Me.bt_ImprimirPedido.Size = New System.Drawing.Size(120, 33)
        Me.bt_ImprimirPedido.TabIndex = 8
        Me.bt_ImprimirPedido.Text = "Imprimir Pedido"
        Me.bt_ImprimirPedido.UseVisualStyleBackColor = True
        '
        'N_Pedidos_LineasDataGridView
        '
        Me.N_Pedidos_LineasDataGridView.AllowUserToAddRows = False
        Me.N_Pedidos_LineasDataGridView.AllowUserToDeleteRows = False
        Me.N_Pedidos_LineasDataGridView.AllowUserToResizeRows = False
        Me.N_Pedidos_LineasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_Pedidos_LineasDataGridView.AutoGenerateColumns = False
        Me.N_Pedidos_LineasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.N_Pedidos_LineasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.L, Me.IDPedidoLineasDataGridViewTextBoxColumn, Me.IDPedidoDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.IDArticuloDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.Descuento1DataGridViewTextBoxColumn, Me.Descuento2DataGridViewTextBoxColumn, Me.Descuento3DataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.IDTipoIVADataGridViewTextBoxColumn, Me.IVAIncluidoDataGridViewCheckBoxColumn, Me.ImagenDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.IDAlmacenDataGridViewTextBoxColumn, Me.BultosDataGridViewTextBoxColumn, Me.ValidadoDataGridViewCheckBoxColumn, Me.IDDocOrigenDataGridViewTextBoxColumn, Me.IDTipoDocOrigenDataGridViewTextBoxColumn})
        Me.N_Pedidos_LineasDataGridView.DataSource = Me.N_Pedidos_LineasBindingSource
        Me.N_Pedidos_LineasDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.N_Pedidos_LineasDataGridView.MultiSelect = False
        Me.N_Pedidos_LineasDataGridView.Name = "N_Pedidos_LineasDataGridView"
        Me.N_Pedidos_LineasDataGridView.ReadOnly = True
        Me.N_Pedidos_LineasDataGridView.RowHeadersVisible = False
        Me.N_Pedidos_LineasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_Pedidos_LineasDataGridView.Size = New System.Drawing.Size(814, 348)
        Me.N_Pedidos_LineasDataGridView.TabIndex = 3
        '
        'L
        '
        Me.L.FillWeight = 1.0!
        Me.L.HeaderText = "L"
        Me.L.MinimumWidth = 20
        Me.L.Name = "L"
        Me.L.ReadOnly = True
        '
        'IDPedidoLineasDataGridViewTextBoxColumn
        '
        Me.IDPedidoLineasDataGridViewTextBoxColumn.DataPropertyName = "ID_PedidoLineas"
        Me.IDPedidoLineasDataGridViewTextBoxColumn.HeaderText = "ID_PedidoLineas"
        Me.IDPedidoLineasDataGridViewTextBoxColumn.Name = "IDPedidoLineasDataGridViewTextBoxColumn"
        Me.IDPedidoLineasDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPedidoLineasDataGridViewTextBoxColumn.Visible = False
        '
        'IDPedidoDataGridViewTextBoxColumn
        '
        Me.IDPedidoDataGridViewTextBoxColumn.DataPropertyName = "ID_Pedido"
        Me.IDPedidoDataGridViewTextBoxColumn.HeaderText = "ID_Pedido"
        Me.IDPedidoDataGridViewTextBoxColumn.Name = "IDPedidoDataGridViewTextBoxColumn"
        Me.IDPedidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPedidoDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 65
        '
        'IDArticuloDataGridViewTextBoxColumn
        '
        Me.IDArticuloDataGridViewTextBoxColumn.DataPropertyName = "ID_Articulo"
        Me.IDArticuloDataGridViewTextBoxColumn.HeaderText = "ID_Articulo"
        Me.IDArticuloDataGridViewTextBoxColumn.Name = "IDArticuloDataGridViewTextBoxColumn"
        Me.IDArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDArticuloDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 74
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 62
        '
        'Descuento1DataGridViewTextBoxColumn
        '
        Me.Descuento1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Descuento1DataGridViewTextBoxColumn.DataPropertyName = "Descuento1"
        Me.Descuento1DataGridViewTextBoxColumn.HeaderText = "Dto. 1"
        Me.Descuento1DataGridViewTextBoxColumn.Name = "Descuento1DataGridViewTextBoxColumn"
        Me.Descuento1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Descuento1DataGridViewTextBoxColumn.Width = 61
        '
        'Descuento2DataGridViewTextBoxColumn
        '
        Me.Descuento2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Descuento2DataGridViewTextBoxColumn.DataPropertyName = "Descuento2"
        Me.Descuento2DataGridViewTextBoxColumn.HeaderText = "Dto. 2"
        Me.Descuento2DataGridViewTextBoxColumn.Name = "Descuento2DataGridViewTextBoxColumn"
        Me.Descuento2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Descuento2DataGridViewTextBoxColumn.Width = 61
        '
        'Descuento3DataGridViewTextBoxColumn
        '
        Me.Descuento3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Descuento3DataGridViewTextBoxColumn.DataPropertyName = "Descuento3"
        Me.Descuento3DataGridViewTextBoxColumn.HeaderText = "Dto. 3"
        Me.Descuento3DataGridViewTextBoxColumn.Name = "Descuento3DataGridViewTextBoxColumn"
        Me.Descuento3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Descuento3DataGridViewTextBoxColumn.Width = 61
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 56
        '
        'IDTipoIVADataGridViewTextBoxColumn
        '
        Me.IDTipoIVADataGridViewTextBoxColumn.DataPropertyName = "ID_TipoIVA"
        Me.IDTipoIVADataGridViewTextBoxColumn.HeaderText = "ID_TipoIVA"
        Me.IDTipoIVADataGridViewTextBoxColumn.Name = "IDTipoIVADataGridViewTextBoxColumn"
        Me.IDTipoIVADataGridViewTextBoxColumn.ReadOnly = True
        Me.IDTipoIVADataGridViewTextBoxColumn.Visible = False
        '
        'IVAIncluidoDataGridViewCheckBoxColumn
        '
        Me.IVAIncluidoDataGridViewCheckBoxColumn.DataPropertyName = "IVAIncluido"
        Me.IVAIncluidoDataGridViewCheckBoxColumn.HeaderText = "IVAIncluido"
        Me.IVAIncluidoDataGridViewCheckBoxColumn.Name = "IVAIncluidoDataGridViewCheckBoxColumn"
        Me.IVAIncluidoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IVAIncluidoDataGridViewCheckBoxColumn.Visible = False
        '
        'ImagenDataGridViewTextBoxColumn
        '
        Me.ImagenDataGridViewTextBoxColumn.DataPropertyName = "Imagen"
        Me.ImagenDataGridViewTextBoxColumn.HeaderText = "Imagen"
        Me.ImagenDataGridViewTextBoxColumn.Name = "ImagenDataGridViewTextBoxColumn"
        Me.ImagenDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImagenDataGridViewTextBoxColumn.Visible = False
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Visible = False
        '
        'IDAlmacenDataGridViewTextBoxColumn
        '
        Me.IDAlmacenDataGridViewTextBoxColumn.DataPropertyName = "ID_Almacen"
        Me.IDAlmacenDataGridViewTextBoxColumn.HeaderText = "ID_Almacen"
        Me.IDAlmacenDataGridViewTextBoxColumn.Name = "IDAlmacenDataGridViewTextBoxColumn"
        Me.IDAlmacenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDAlmacenDataGridViewTextBoxColumn.Visible = False
        '
        'BultosDataGridViewTextBoxColumn
        '
        Me.BultosDataGridViewTextBoxColumn.DataPropertyName = "Bultos"
        Me.BultosDataGridViewTextBoxColumn.HeaderText = "Bultos"
        Me.BultosDataGridViewTextBoxColumn.Name = "BultosDataGridViewTextBoxColumn"
        Me.BultosDataGridViewTextBoxColumn.ReadOnly = True
        Me.BultosDataGridViewTextBoxColumn.Visible = False
        '
        'ValidadoDataGridViewCheckBoxColumn
        '
        Me.ValidadoDataGridViewCheckBoxColumn.DataPropertyName = "Validado"
        Me.ValidadoDataGridViewCheckBoxColumn.HeaderText = "Validado"
        Me.ValidadoDataGridViewCheckBoxColumn.Name = "ValidadoDataGridViewCheckBoxColumn"
        Me.ValidadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ValidadoDataGridViewCheckBoxColumn.Visible = False
        '
        'IDDocOrigenDataGridViewTextBoxColumn
        '
        Me.IDDocOrigenDataGridViewTextBoxColumn.DataPropertyName = "ID_DocOrigen"
        Me.IDDocOrigenDataGridViewTextBoxColumn.HeaderText = "ID_DocOrigen"
        Me.IDDocOrigenDataGridViewTextBoxColumn.Name = "IDDocOrigenDataGridViewTextBoxColumn"
        Me.IDDocOrigenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDocOrigenDataGridViewTextBoxColumn.Visible = False
        '
        'IDTipoDocOrigenDataGridViewTextBoxColumn
        '
        Me.IDTipoDocOrigenDataGridViewTextBoxColumn.DataPropertyName = "ID_TipoDocOrigen"
        Me.IDTipoDocOrigenDataGridViewTextBoxColumn.HeaderText = "ID_TipoDocOrigen"
        Me.IDTipoDocOrigenDataGridViewTextBoxColumn.Name = "IDTipoDocOrigenDataGridViewTextBoxColumn"
        Me.IDTipoDocOrigenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDTipoDocOrigenDataGridViewTextBoxColumn.Visible = False
        '
        'N_Pedidos_LineasBindingSource
        '
        Me.N_Pedidos_LineasBindingSource.DataMember = "N_Pedidos_Lineas"
        Me.N_Pedidos_LineasBindingSource.DataSource = Me.CMDataSet
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.Location = New System.Drawing.Point(333, 373)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(104, 31)
        Me.btn_Eliminar.TabIndex = 1
        Me.btn_Eliminar.Text = "Eliminar Línea"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Editar.Enabled = False
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Editar.Location = New System.Drawing.Point(223, 373)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(104, 31)
        Me.btn_Editar.TabIndex = 1
        Me.btn_Editar.Text = "Editar Línea"
        Me.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_ValidarLineas
        '
        Me.btn_ValidarLineas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ValidarLineas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ValidarLineas.Location = New System.Drawing.Point(113, 373)
        Me.btn_ValidarLineas.Name = "btn_ValidarLineas"
        Me.btn_ValidarLineas.Size = New System.Drawing.Size(104, 31)
        Me.btn_ValidarLineas.TabIndex = 1
        Me.btn_ValidarLineas.Text = "Validar Líneas"
        Me.btn_ValidarLineas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ValidarLineas.UseVisualStyleBackColor = True
        '
        'btn_NuevaLinea
        '
        Me.btn_NuevaLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_NuevaLinea.Image = CType(resources.GetObject("btn_NuevaLinea.Image"), System.Drawing.Image)
        Me.btn_NuevaLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NuevaLinea.Location = New System.Drawing.Point(3, 373)
        Me.btn_NuevaLinea.Name = "btn_NuevaLinea"
        Me.btn_NuevaLinea.Size = New System.Drawing.Size(104, 31)
        Me.btn_NuevaLinea.TabIndex = 1
        Me.btn_NuevaLinea.Text = "Nueva Línea"
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
        Me.tb_Totales.Size = New System.Drawing.Size(829, 410)
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
        Me.lbl_Finaciacion.Text = "Financiación"
        Me.lbl_Finaciacion.UseVisualStyleBackColor = False
        '
        'lbl_Suma
        '
        Me.lbl_Suma.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Suma.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.lbl_Suma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Suma.Location = New System.Drawing.Point(77, 152)
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
        Me.lbl_RE.Location = New System.Drawing.Point(358, 152)
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
        Me.lbl_IVA.Location = New System.Drawing.Point(244, 152)
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
        Me.lbl_TOTAL.Location = New System.Drawing.Point(552, 152)
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
        Me.lbl_IRPF.Location = New System.Drawing.Point(455, 152)
        Me.lbl_IRPF.Name = "lbl_IRPF"
        Me.lbl_IRPF.Size = New System.Drawing.Size(91, 23)
        Me.lbl_IRPF.TabIndex = 54
        Me.lbl_IRPF.Text = "IRPF"
        Me.lbl_IRPF.UseVisualStyleBackColor = False
        '
        'IRPFCantidadTextBox
        '
        Me.IRPFCantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PedidosBindingSource, "IRPFCantidad", True))
        Me.IRPFCantidadTextBox.Location = New System.Drawing.Point(493, 183)
        Me.IRPFCantidadTextBox.Name = "IRPFCantidadTextBox"
        Me.IRPFCantidadTextBox.Size = New System.Drawing.Size(54, 20)
        Me.IRPFCantidadTextBox.TabIndex = 47
        Me.IRPFCantidadTextBox.Text = "0"
        Me.IRPFCantidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IRPFPorcientoTextBox
        '
        Me.IRPFPorcientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PedidosBindingSource, "IRPFPorciento", True))
        Me.IRPFPorcientoTextBox.Location = New System.Drawing.Point(456, 183)
        Me.IRPFPorcientoTextBox.Name = "IRPFPorcientoTextBox"
        Me.IRPFPorcientoTextBox.Size = New System.Drawing.Size(33, 20)
        Me.IRPFPorcientoTextBox.TabIndex = 46
        Me.IRPFPorcientoTextBox.Text = "0"
        Me.IRPFPorcientoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Total
        '
        Me.txt_Total.BackColor = System.Drawing.SystemColors.Info
        Me.txt_Total.Location = New System.Drawing.Point(552, 183)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(91, 20)
        Me.txt_Total.TabIndex = 59
        Me.txt_Total.Text = "0"
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PedidosBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(121, 343)
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
        Me.CtrlFormaPago1.DataBindings.Add(New System.Windows.Forms.Binding("ID_FormaPago", Me.N_PedidosBindingSource, "ID_FormaPago", True))
        Me.CtrlFormaPago1.ID_FormaPago = Nothing
        Me.CtrlFormaPago1.Location = New System.Drawing.Point(45, 287)
        Me.CtrlFormaPago1.Name = "CtrlFormaPago1"
        Me.CtrlFormaPago1.Size = New System.Drawing.Size(265, 29)
        Me.CtrlFormaPago1.TabIndex = 0
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(-254, 132)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 4
        '
        'pnl_Totales
        '
        Me.pnl_Totales.Location = New System.Drawing.Point(3, 3)
        Me.pnl_Totales.Name = "pnl_Totales"
        Me.pnl_Totales.Size = New System.Drawing.Size(721, 273)
        Me.pnl_Totales.TabIndex = 8
        '
        'tb_OtrosDatos
        '
        Me.tb_OtrosDatos.AutoScroll = True
        Me.tb_OtrosDatos.Controls.Add(Me.GroupBox2)
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
        Me.tb_OtrosDatos.Size = New System.Drawing.Size(829, 410)
        Me.tb_OtrosDatos.TabIndex = 2
        Me.tb_OtrosDatos.Text = "Otros datos"
        Me.tb_OtrosDatos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(PedidoPorLabel)
        Me.GroupBox2.Controls.Add(Me.PedidoPorTextBox)
        Me.GroupBox2.Controls.Add(Me.CtrlProveedor1)
        Me.GroupBox2.Controls.Add(PlazoEntregaLabel)
        Me.GroupBox2.Controls.Add(Me.PlazoEntregaDateTimePicker)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 122)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Otros Datos"
        '
        'PedidoPorTextBox
        '
        Me.PedidoPorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PedidosBindingSource, "PedidoPor", True))
        Me.PedidoPorTextBox.Location = New System.Drawing.Point(111, 57)
        Me.PedidoPorTextBox.Name = "PedidoPorTextBox"
        Me.PedidoPorTextBox.Size = New System.Drawing.Size(276, 20)
        Me.PedidoPorTextBox.TabIndex = 4
        '
        'CtrlProveedor1
        '
        Me.CtrlProveedor1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Proveedor", Me.N_PedidosBindingSource, "ID_Proveedor", True))
        Me.CtrlProveedor1.ID_Proveedor = Nothing
        Me.CtrlProveedor1.Location = New System.Drawing.Point(35, 22)
        Me.CtrlProveedor1.Name = "CtrlProveedor1"
        Me.CtrlProveedor1.Size = New System.Drawing.Size(265, 29)
        Me.CtrlProveedor1.TabIndex = 2
        '
        'PlazoEntregaDateTimePicker
        '
        Me.PlazoEntregaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_PedidosBindingSource, "PlazoEntrega", True))
        Me.PlazoEntregaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PlazoEntregaDateTimePicker.Location = New System.Drawing.Point(111, 83)
        Me.PlazoEntregaDateTimePicker.Name = "PlazoEntregaDateTimePicker"
        Me.PlazoEntregaDateTimePicker.Size = New System.Drawing.Size(88, 20)
        Me.PlazoEntregaDateTimePicker.TabIndex = 1
        '
        'grpPortes
        '
        Me.grpPortes.Controls.Add(Me.rb_PorteNoPagado)
        Me.grpPortes.Controls.Add(Me.RadioButton1)
        Me.grpPortes.Controls.Add(Me.PorteTextoTextBox)
        Me.grpPortes.Location = New System.Drawing.Point(449, 11)
        Me.grpPortes.Name = "grpPortes"
        Me.grpPortes.Size = New System.Drawing.Size(379, 73)
        Me.grpPortes.TabIndex = 17
        Me.grpPortes.TabStop = False
        Me.grpPortes.Text = "Portes"
        '
        'rb_PorteNoPagado
        '
        Me.rb_PorteNoPagado.AutoSize = True
        Me.rb_PorteNoPagado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.N_PedidosBindingSource, "PorteDebido", True))
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
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.N_PedidosBindingSource, "PortePagado", True))
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
        Me.PorteTextoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PorteTextoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PedidosBindingSource, "PorteTexto", True))
        Me.PorteTextoTextBox.Location = New System.Drawing.Point(15, 45)
        Me.PorteTextoTextBox.Name = "PorteTextoTextBox"
        Me.PorteTextoTextBox.Size = New System.Drawing.Size(349, 20)
        Me.PorteTextoTextBox.TabIndex = 9
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PedidosBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(108, 272)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ComentariosTextBox.Size = New System.Drawing.Size(705, 35)
        Me.ComentariosTextBox.TabIndex = 15
        '
        'DocumentacionAsociadaTextBox
        '
        Me.DocumentacionAsociadaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PedidosBindingSource, "DocumentacionAsociada", True))
        Me.DocumentacionAsociadaTextBox.Location = New System.Drawing.Point(108, 234)
        Me.DocumentacionAsociadaTextBox.Multiline = True
        Me.DocumentacionAsociadaTextBox.Name = "DocumentacionAsociadaTextBox"
        Me.DocumentacionAsociadaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DocumentacionAsociadaTextBox.Size = New System.Drawing.Size(705, 31)
        Me.DocumentacionAsociadaTextBox.TabIndex = 13
        '
        'PrivadoTextBox
        '
        Me.PrivadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PedidosBindingSource, "Privado", True))
        Me.PrivadoTextBox.Location = New System.Drawing.Point(108, 192)
        Me.PrivadoTextBox.Multiline = True
        Me.PrivadoTextBox.Name = "PrivadoTextBox"
        Me.PrivadoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PrivadoTextBox.Size = New System.Drawing.Size(705, 35)
        Me.PrivadoTextBox.TabIndex = 11
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(757, 549)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 7
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_SumaNeta, Me.ToolStripStatusLabel1, Me.tst_TotalNeto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 551)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(835, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tst_SumaNeta
        '
        Me.tst_SumaNeta.Name = "tst_SumaNeta"
        Me.tst_SumaNeta.Size = New System.Drawing.Size(72, 17)
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
        Me.tst_TotalNeto.Size = New System.Drawing.Size(44, 17)
        Me.tst_TotalNeto.Text = "Total: 0"
        '
        'N_Pedidos_TiposTableAdapter
        '
        Me.N_Pedidos_TiposTableAdapter.ClearBeforeFill = True
        '
        'N_PedidosTableAdapter
        '
        Me.N_PedidosTableAdapter.ClearBeforeFill = True
        '
        'N_Pedidos_LineasTableAdapter
        '
        Me.N_Pedidos_LineasTableAdapter.ClearBeforeFill = True
        '
        'frmPedidos_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 573)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tc_Presupuestos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPedidos_ADD"
        Me.Text = "Modificar Pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.N_PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Pedidos_TiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_Presupuestos.ResumeLayout(False)
        Me.tb_Lineas.ResumeLayout(False)
        CType(Me.N_Pedidos_LineasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Pedidos_LineasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_Totales.ResumeLayout(False)
        Me.tb_Totales.PerformLayout()
        Me.tb_OtrosDatos.ResumeLayout(False)
        Me.tb_OtrosDatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpPortes.ResumeLayout(False)
        Me.grpPortes.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Estado As System.Windows.Forms.ComboBox
    Friend WithEvents N_Pedidos_TiposComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents tc_Presupuestos As System.Windows.Forms.TabControl
    Friend WithEvents tb_Lineas As System.Windows.Forms.TabPage
    Friend WithEvents N_Pedidos_LineasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_ValidarLineas As System.Windows.Forms.Button
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
    Friend WithEvents IRPFCantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IRPFPorcientoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CtrlFormaPago1 As ctrlFormaPago
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents pnl_Totales As System.Windows.Forms.Panel
    Friend WithEvents tb_OtrosDatos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpPortes As System.Windows.Forms.GroupBox
    Friend WithEvents rb_PorteNoPagado As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents PorteTextoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DocumentacionAsociadaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrivadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tst_SumaNeta As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tst_TotalNeto As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_Pedidos_TiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Pedidos_TiposTableAdapter As CMDataSetTableAdapters.N_Pedidos_TiposTableAdapter
    Friend WithEvents N_PedidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_PedidosTableAdapter As CMDataSetTableAdapters.N_PedidosTableAdapter
    Friend WithEvents N_Pedidos_LineasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Pedidos_LineasTableAdapter As CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter
    Friend WithEvents L As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPedidoLineasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPedidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTipoIVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVAIncluidoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ImagenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BultosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IDDocOrigenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTipoDocOrigenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlazoEntregaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CtrlProveedor1 As ctrlProveedor
    Friend WithEvents PedidoPorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bt_ImprimirPedido As System.Windows.Forms.Button
    Friend WithEvents CtrlDocProcesados1 As ctrlDocProcesados
End Class
