<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasMedicas
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
        Dim Label4 As System.Windows.Forms.Label
        Me.N_Factura_ResumenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_Factura_ResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tst_TotalSeleccionado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tst_Total = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tb_Serie1 = New System.Windows.Forms.TabPage()
        Me.tb_Todos = New System.Windows.Forms.TabPage()
        Me.tc_Presupuestos = New System.Windows.Forms.TabControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_sinpagar = New System.Windows.Forms.RadioButton()
        Me.rb_pagadas = New System.Windows.Forms.RadioButton()
        Me.rb_todascobrar = New System.Windows.Forms.RadioButton()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.tst_Nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.N_Factura_ResumenTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Factura_ResumenTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_FEMISION_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FEMISION_fi = New System.Windows.Forms.DateTimePicker()
        Me.tst_Numero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_Estado = New System.Windows.Forms.ComboBox()
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tst_Referencia = New System.Windows.Forms.TextBox()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.N_Factura_ResumenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Factura_ResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.tc_Presupuestos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'N_Factura_ResumenDataGridView
        '
        Me.N_Factura_ResumenDataGridView.AllowUserToAddRows = False
        Me.N_Factura_ResumenDataGridView.AllowUserToDeleteRows = False
        Me.N_Factura_ResumenDataGridView.AllowUserToResizeRows = False
        Me.N_Factura_ResumenDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_Factura_ResumenDataGridView.AutoGenerateColumns = False
        Me.N_Factura_ResumenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.N_Factura_ResumenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.Paciente, Me.Expr1, Me.DataGridViewTextBoxColumn3, Me.EstadoDataGridViewTextBoxColumn, Me.Pagado, Me.DataGridViewTextBoxColumn7, Me.TotalDataGridViewTextBoxColumn})
        Me.N_Factura_ResumenDataGridView.DataSource = Me.N_Factura_ResumenBindingSource
        Me.N_Factura_ResumenDataGridView.Location = New System.Drawing.Point(0, 157)
        Me.N_Factura_ResumenDataGridView.MultiSelect = False
        Me.N_Factura_ResumenDataGridView.Name = "N_Factura_ResumenDataGridView"
        Me.N_Factura_ResumenDataGridView.ReadOnly = True
        Me.N_Factura_ResumenDataGridView.RowHeadersVisible = False
        Me.N_Factura_ResumenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_Factura_ResumenDataGridView.Size = New System.Drawing.Size(1006, 476)
        Me.N_Factura_ResumenDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Factura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "T-Número"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 79
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 62
        '
        'Paciente
        '
        Me.Paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Paciente.DataPropertyName = "CodigoCliente"
        Me.Paciente.FillWeight = 56.0!
        Me.Paciente.HeaderText = "Cod Paciente"
        Me.Paciente.Name = "Paciente"
        Me.Paciente.ReadOnly = True
        Me.Paciente.Width = 96
        '
        'Expr1
        '
        Me.Expr1.DataPropertyName = "NombreCompleto"
        Me.Expr1.HeaderText = "Nombre Completo"
        Me.Expr1.Name = "Expr1"
        Me.Expr1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Referencia"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 84
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pagado
        '
        Me.Pagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Pagado.DataPropertyName = "Pagado"
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        Me.Pagado.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Forma de Pago"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Forma de Pago"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 104
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
        'N_Factura_ResumenBindingSource
        '
        Me.N_Factura_ResumenBindingSource.DataMember = "N_Factura_Resumen"
        Me.N_Factura_ResumenBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.NewToolStripButton.Text = "&Añadir"
        '
        'tst_Editar
        '
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar.Text = "&Modificar"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar.Text = "&Eliminar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_TotalSeleccionado, Me.ToolStripStatusLabel1, Me.tst_Total})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 634)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tst_TotalSeleccionado
        '
        Me.tst_TotalSeleccionado.Name = "tst_TotalSeleccionado"
        Me.tst_TotalSeleccionado.Size = New System.Drawing.Size(118, 17)
        Me.tst_TotalSeleccionado.Text = "Total seleccionado: 0"
        Me.tst_TotalSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(76, 17)
        Me.ToolStripStatusLabel1.Text = "                       "
        '
        'tst_Total
        '
        Me.tst_Total.Name = "tst_Total"
        Me.tst_Total.Size = New System.Drawing.Size(46, 17)
        Me.tst_Total.Text = "Total: 0"
        '
        'tb_Serie1
        '
        Me.tb_Serie1.Location = New System.Drawing.Point(4, 22)
        Me.tb_Serie1.Name = "tb_Serie1"
        Me.tb_Serie1.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Serie1.Size = New System.Drawing.Size(1000, 78)
        Me.tb_Serie1.TabIndex = 1
        Me.tb_Serie1.Text = "Serie 1"
        Me.tb_Serie1.UseVisualStyleBackColor = True
        '
        'tb_Todos
        '
        Me.tb_Todos.Location = New System.Drawing.Point(4, 22)
        Me.tb_Todos.Name = "tb_Todos"
        Me.tb_Todos.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Todos.Size = New System.Drawing.Size(1000, 78)
        Me.tb_Todos.TabIndex = 0
        Me.tb_Todos.Text = "Todos"
        Me.tb_Todos.UseVisualStyleBackColor = True
        '
        'tc_Presupuestos
        '
        Me.tc_Presupuestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_Presupuestos.Controls.Add(Me.tb_Todos)
        Me.tc_Presupuestos.Controls.Add(Me.tb_Serie1)
        Me.tc_Presupuestos.Location = New System.Drawing.Point(0, 135)
        Me.tc_Presupuestos.Name = "tc_Presupuestos"
        Me.tc_Presupuestos.SelectedIndex = 0
        Me.tc_Presupuestos.Size = New System.Drawing.Size(1008, 104)
        Me.tc_Presupuestos.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmb_Estado)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.tst_Referencia)
        Me.GroupBox1.Controls.Add(Me.tst_Numero)
        Me.GroupBox1.Controls.Add(Me.tst_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CtrlFormaPago21)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 104)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_sinpagar)
        Me.GroupBox3.Controls.Add(Me.rb_pagadas)
        Me.GroupBox3.Controls.Add(Me.rb_todascobrar)
        Me.GroupBox3.Location = New System.Drawing.Point(327, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(107, 85)
        Me.GroupBox3.TabIndex = 118
        Me.GroupBox3.TabStop = False
        '
        'rb_sinpagar
        '
        Me.rb_sinpagar.AutoSize = True
        Me.rb_sinpagar.Location = New System.Drawing.Point(22, 58)
        Me.rb_sinpagar.Name = "rb_sinpagar"
        Me.rb_sinpagar.Size = New System.Drawing.Size(70, 17)
        Me.rb_sinpagar.TabIndex = 8
        Me.rb_sinpagar.Text = "Sin pagar"
        Me.rb_sinpagar.UseVisualStyleBackColor = True
        '
        'rb_pagadas
        '
        Me.rb_pagadas.AutoSize = True
        Me.rb_pagadas.Location = New System.Drawing.Point(22, 38)
        Me.rb_pagadas.Name = "rb_pagadas"
        Me.rb_pagadas.Size = New System.Drawing.Size(67, 17)
        Me.rb_pagadas.TabIndex = 7
        Me.rb_pagadas.Text = "Pagadas"
        Me.rb_pagadas.UseVisualStyleBackColor = True
        '
        'rb_todascobrar
        '
        Me.rb_todascobrar.AutoSize = True
        Me.rb_todascobrar.Checked = True
        Me.rb_todascobrar.Location = New System.Drawing.Point(22, 15)
        Me.rb_todascobrar.Name = "rb_todascobrar"
        Me.rb_todascobrar.Size = New System.Drawing.Size(55, 17)
        Me.rb_todascobrar.TabIndex = 6
        Me.rb_todascobrar.TabStop = True
        Me.rb_todascobrar.Text = "Todas"
        Me.rb_todascobrar.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(906, 30)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(77, 52)
        Me.btnFiltrar.TabIndex = 14
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'tst_Nombre
        '
        Me.tst_Nombre.Location = New System.Drawing.Point(107, 18)
        Me.tst_Nombre.Name = "tst_Nombre"
        Me.tst_Nombre.Size = New System.Drawing.Size(202, 20)
        Me.tst_Nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre completo:"
        '
        'N_Factura_ResumenTableAdapter
        '
        Me.N_Factura_ResumenTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtp_FEMISION_ff)
        Me.GroupBox2.Controls.Add(Me.dtp_FEMISION_fi)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(191, 91)
        Me.GroupBox2.TabIndex = 119
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Desde:"
        '
        'dtp_FEMISION_ff
        '
        Me.dtp_FEMISION_ff.Checked = False
        Me.dtp_FEMISION_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_FEMISION_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FEMISION_ff.Location = New System.Drawing.Point(58, 59)
        Me.dtp_FEMISION_ff.Name = "dtp_FEMISION_ff"
        Me.dtp_FEMISION_ff.ShowCheckBox = True
        Me.dtp_FEMISION_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_FEMISION_ff.TabIndex = 1
        '
        'dtp_FEMISION_fi
        '
        Me.dtp_FEMISION_fi.Checked = False
        Me.dtp_FEMISION_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_FEMISION_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FEMISION_fi.Location = New System.Drawing.Point(58, 33)
        Me.dtp_FEMISION_fi.Name = "dtp_FEMISION_fi"
        Me.dtp_FEMISION_fi.ShowCheckBox = True
        Me.dtp_FEMISION_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_FEMISION_fi.TabIndex = 0
        '
        'tst_Numero
        '
        Me.tst_Numero.Location = New System.Drawing.Point(107, 75)
        Me.tst_Numero.Name = "tst_Numero"
        Me.tst_Numero.Size = New System.Drawing.Size(202, 20)
        Me.tst_Numero.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Número:"
        '
        'cmb_Estado
        '
        Me.cmb_Estado.DisplayMember = "ID_Estado"
        Me.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Estado.Location = New System.Drawing.Point(732, 67)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(119, 21)
        Me.cmb_Estado.TabIndex = 121
        Me.cmb_Estado.ValueMember = "ID_Estado"
        Me.cmb_Estado.Visible = False
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(683, 70)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(43, 13)
        Label4.TabIndex = 120
        Label4.Text = "Estado:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label4.Visible = False
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.BackColor = System.Drawing.Color.Transparent
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(37, 44)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(272, 24)
        Me.CtrlFormaPago21.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(664, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Referencia:"
        '
        'tst_Referencia
        '
        Me.tst_Referencia.Location = New System.Drawing.Point(732, 25)
        Me.tst_Referencia.Name = "tst_Referencia"
        Me.tst_Referencia.Size = New System.Drawing.Size(119, 20)
        Me.tst_Referencia.TabIndex = 1
        '
        'frmFacturasMedicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 656)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.N_Factura_ResumenDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tc_Presupuestos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MinimumSize = New System.Drawing.Size(736, 694)
        Me.Name = "frmFacturasMedicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        CType(Me.N_Factura_ResumenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Factura_ResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tc_Presupuestos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_Factura_ResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Factura_ResumenTableAdapter As CMDataSetTableAdapters.N_Factura_ResumenTableAdapter
    Friend WithEvents N_Factura_ResumenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tst_Total As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tst_TotalSeleccionado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Friend WithEvents tb_Serie1 As System.Windows.Forms.TabPage
    Friend WithEvents tb_Todos As System.Windows.Forms.TabPage
    Friend WithEvents tc_Presupuestos As System.Windows.Forms.TabControl
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents tst_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_sinpagar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pagadas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todascobrar As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pagado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_FEMISION_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FEMISION_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents tst_Numero As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_Estado As System.Windows.Forms.ComboBox
    Friend WithEvents tst_Referencia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
