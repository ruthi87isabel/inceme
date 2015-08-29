<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos_ADD
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim EsEstocableLabel As System.Windows.Forms.Label
        Dim PrecioCompraLabel As System.Windows.Forms.Label
        Dim ID_FamiliaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos_ADD))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_Details = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New centro_medico.ctrlTextboxAvanzado()
        Me.N_ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.combo_Familia = New System.Windows.Forms.ComboBox()
        Me.N_FamiliasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlProveedor1 = New centro_medico.ctrlProveedor()
        Me.Combo_TipoIVA = New System.Windows.Forms.ComboBox()
        Me.N_TipoIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DescripcionTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.EsEstocableCheckBox = New System.Windows.Forms.CheckBox()
        Me.PrecioCompraTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_Almacen = New System.Windows.Forms.TabPage()
        Me.grp_Almacen = New System.Windows.Forms.GroupBox()
        Me.pb_Almacen_Articulo_ADD = New System.Windows.Forms.PictureBox()
        Me.N_Articulos_Almacen_ResumenDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_Articulos_Almacen_ResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.N_ArticulosTableAdapter = New centro_medico.CMDataSetTableAdapters.N_ArticulosTableAdapter()
        Me.N_TipoIVATableAdapter = New centro_medico.CMDataSetTableAdapters.N_TipoIVATableAdapter()
        Me.N_FamiliasTableAdapter = New centro_medico.CMDataSetTableAdapters.N_FamiliasTableAdapter()
        Me.N_Articulos_Almacen_ResumenTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Articulos_Almacen_ResumenTableAdapter()
        CodigoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        EsEstocableLabel = New System.Windows.Forms.Label()
        PrecioCompraLabel = New System.Windows.Forms.Label()
        ID_FamiliaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tab_Details.SuspendLayout()
        CType(Me.N_ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_FamiliasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_TipoIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_Almacen.SuspendLayout()
        Me.grp_Almacen.SuspendLayout()
        CType(Me.pb_Almacen_Articulo_ADD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Articulos_Almacen_ResumenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Articulos_Almacen_ResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(66, 27)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 2
        CodigoLabel.Text = "Codigo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(43, 82)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'EsEstocableLabel
        '
        EsEstocableLabel.AutoSize = True
        EsEstocableLabel.Location = New System.Drawing.Point(37, 139)
        EsEstocableLabel.Name = "EsEstocableLabel"
        EsEstocableLabel.Size = New System.Drawing.Size(72, 13)
        EsEstocableLabel.TabIndex = 8
        EsEstocableLabel.Text = "Es Estocable:"
        '
        'PrecioCompraLabel
        '
        PrecioCompraLabel.AutoSize = True
        PrecioCompraLabel.Location = New System.Drawing.Point(30, 194)
        PrecioCompraLabel.Name = "PrecioCompraLabel"
        PrecioCompraLabel.Size = New System.Drawing.Size(79, 13)
        PrecioCompraLabel.TabIndex = 10
        PrecioCompraLabel.Text = "Precio Compra:"
        '
        'ID_FamiliaLabel
        '
        ID_FamiliaLabel.AutoSize = True
        ID_FamiliaLabel.Location = New System.Drawing.Point(66, 53)
        ID_FamiliaLabel.Name = "ID_FamiliaLabel"
        ID_FamiliaLabel.Size = New System.Drawing.Size(42, 13)
        ID_FamiliaLabel.TabIndex = 16
        ID_FamiliaLabel.Text = "Familia:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(82, 170)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(27, 13)
        Label1.TabIndex = 4
        Label1.Text = "IVA:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(30, 223)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(59, 13)
        Label2.TabIndex = 21
        Label2.Text = "P. V. Rec.:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_Details)
        Me.TabControl1.Controls.Add(Me.tb_Almacen)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(505, 330)
        Me.TabControl1.TabIndex = 0
        '
        'tab_Details
        '
        Me.tab_Details.AutoScroll = True
        Me.tab_Details.Controls.Add(Label2)
        Me.tab_Details.Controls.Add(Me.TextBox1)
        Me.tab_Details.Controls.Add(Me.combo_Familia)
        Me.tab_Details.Controls.Add(Me.CtrlProveedor1)
        Me.tab_Details.Controls.Add(Me.Combo_TipoIVA)
        Me.tab_Details.Controls.Add(CodigoLabel)
        Me.tab_Details.Controls.Add(Me.CodigoTextBox)
        Me.tab_Details.Controls.Add(Label1)
        Me.tab_Details.Controls.Add(DescripcionLabel)
        Me.tab_Details.Controls.Add(Me.DescripcionTextBox)
        Me.tab_Details.Controls.Add(EsEstocableLabel)
        Me.tab_Details.Controls.Add(Me.CheckBox1)
        Me.tab_Details.Controls.Add(Me.EsEstocableCheckBox)
        Me.tab_Details.Controls.Add(PrecioCompraLabel)
        Me.tab_Details.Controls.Add(Me.PrecioCompraTextBox)
        Me.tab_Details.Controls.Add(ID_FamiliaLabel)
        Me.tab_Details.Location = New System.Drawing.Point(4, 22)
        Me.tab_Details.Name = "tab_Details"
        Me.tab_Details.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Details.Size = New System.Drawing.Size(497, 304)
        Me.tab_Details.TabIndex = 0
        Me.tab_Details.Text = "Ficha"
        Me.tab_Details.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ArticulosBindingSource, "PrecioVentaRecomendado", True))
        Me.TextBox1.Location = New System.Drawing.Point(115, 220)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "0"
        '
        'N_ArticulosBindingSource
        '
        Me.N_ArticulosBindingSource.DataMember = "N_Articulos"
        Me.N_ArticulosBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'combo_Familia
        '
        Me.combo_Familia.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_ArticulosBindingSource, "ID_Familia", True))
        Me.combo_Familia.DataSource = Me.N_FamiliasBindingSource
        Me.combo_Familia.DisplayMember = "Nombre"
        Me.combo_Familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Familia.FormattingEnabled = True
        Me.combo_Familia.Location = New System.Drawing.Point(115, 50)
        Me.combo_Familia.Name = "combo_Familia"
        Me.combo_Familia.Size = New System.Drawing.Size(203, 21)
        Me.combo_Familia.TabIndex = 20
        Me.combo_Familia.ValueMember = "ID_Familia"
        '
        'N_FamiliasBindingSource
        '
        Me.N_FamiliasBindingSource.DataMember = "N_Familias"
        Me.N_FamiliasBindingSource.DataSource = Me.CMDataSet
        '
        'CtrlProveedor1
        '
        Me.CtrlProveedor1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Proveedor", Me.N_ArticulosBindingSource, "ID_ProveedorHabitual", True))
        Me.CtrlProveedor1.ID_Proveedor = Nothing
        Me.CtrlProveedor1.Location = New System.Drawing.Point(52, 107)
        Me.CtrlProveedor1.Name = "CtrlProveedor1"
        Me.CtrlProveedor1.Size = New System.Drawing.Size(387, 29)
        Me.CtrlProveedor1.TabIndex = 19
        '
        'Combo_TipoIVA
        '
        Me.Combo_TipoIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_ArticulosBindingSource, "ID_TipoIVA", True))
        Me.Combo_TipoIVA.DataSource = Me.N_TipoIVABindingSource
        Me.Combo_TipoIVA.DisplayMember = "Nombre"
        Me.Combo_TipoIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_TipoIVA.FormattingEnabled = True
        Me.Combo_TipoIVA.Location = New System.Drawing.Point(115, 164)
        Me.Combo_TipoIVA.Name = "Combo_TipoIVA"
        Me.Combo_TipoIVA.Size = New System.Drawing.Size(165, 21)
        Me.Combo_TipoIVA.TabIndex = 18
        Me.Combo_TipoIVA.ValueMember = "ID_TipoIVA"
        '
        'N_TipoIVABindingSource
        '
        Me.N_TipoIVABindingSource.DataMember = "N_TipoIVA"
        Me.N_TipoIVABindingSource.DataSource = Me.CMDataSet
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.AcceptsReturn = True
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ArticulosBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(115, 24)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CodigoTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.AcceptsReturn = True
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ArticulosBindingSource, "DescripcionGeneral", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(115, 79)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(311, 20)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Image = Global.centro_medico.My.Resources.Resources.Button_Favorite_icon
        Me.CheckBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(39, 250)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(91, 33)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Favorito"
        '
        'EsEstocableCheckBox
        '
        Me.EsEstocableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_ArticulosBindingSource, "EsEstocable", True))
        Me.EsEstocableCheckBox.Location = New System.Drawing.Point(115, 134)
        Me.EsEstocableCheckBox.Name = "EsEstocableCheckBox"
        Me.EsEstocableCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EsEstocableCheckBox.TabIndex = 9
        '
        'PrecioCompraTextBox
        '
        Me.PrecioCompraTextBox.AcceptsReturn = True
        Me.PrecioCompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ArticulosBindingSource, "PrecioCompra", True))
        Me.PrecioCompraTextBox.Location = New System.Drawing.Point(115, 191)
        Me.PrecioCompraTextBox.Name = "PrecioCompraTextBox"
        Me.PrecioCompraTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PrecioCompraTextBox.TabIndex = 11
        '
        'tb_Almacen
        '
        Me.tb_Almacen.Controls.Add(Me.grp_Almacen)
        Me.tb_Almacen.Location = New System.Drawing.Point(4, 22)
        Me.tb_Almacen.Name = "tb_Almacen"
        Me.tb_Almacen.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Almacen.Size = New System.Drawing.Size(497, 304)
        Me.tb_Almacen.TabIndex = 1
        Me.tb_Almacen.Text = "Almacen"
        Me.tb_Almacen.UseVisualStyleBackColor = True
        '
        'grp_Almacen
        '
        Me.grp_Almacen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grp_Almacen.Controls.Add(Me.pb_Almacen_Articulo_ADD)
        Me.grp_Almacen.Controls.Add(Me.N_Articulos_Almacen_ResumenDataGridView)
        Me.grp_Almacen.Location = New System.Drawing.Point(31, 37)
        Me.grp_Almacen.Name = "grp_Almacen"
        Me.grp_Almacen.Size = New System.Drawing.Size(427, 225)
        Me.grp_Almacen.TabIndex = 93
        Me.grp_Almacen.TabStop = False
        Me.grp_Almacen.Text = "Almacenes"
        '
        'pb_Almacen_Articulo_ADD
        '
        Me.pb_Almacen_Articulo_ADD.Image = CType(resources.GetObject("pb_Almacen_Articulo_ADD.Image"), System.Drawing.Image)
        Me.pb_Almacen_Articulo_ADD.Location = New System.Drawing.Point(15, 191)
        Me.pb_Almacen_Articulo_ADD.Name = "pb_Almacen_Articulo_ADD"
        Me.pb_Almacen_Articulo_ADD.Size = New System.Drawing.Size(24, 24)
        Me.pb_Almacen_Articulo_ADD.TabIndex = 82
        Me.pb_Almacen_Articulo_ADD.TabStop = False
        '
        'N_Articulos_Almacen_ResumenDataGridView
        '
        Me.N_Articulos_Almacen_ResumenDataGridView.AllowUserToAddRows = False
        Me.N_Articulos_Almacen_ResumenDataGridView.AllowUserToDeleteRows = False
        Me.N_Articulos_Almacen_ResumenDataGridView.AllowUserToResizeRows = False
        Me.N_Articulos_Almacen_ResumenDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_Articulos_Almacen_ResumenDataGridView.AutoGenerateColumns = False
        Me.N_Articulos_Almacen_ResumenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.N_Articulos_Almacen_ResumenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.IDAlmacenDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.IDArticuloDataGridViewTextBoxColumn, Me.StockMinimoDataGridViewTextBoxColumn, Me.StockMaximoDataGridViewTextBoxColumn})
        Me.N_Articulos_Almacen_ResumenDataGridView.DataSource = Me.N_Articulos_Almacen_ResumenBindingSource
        Me.N_Articulos_Almacen_ResumenDataGridView.Location = New System.Drawing.Point(15, 30)
        Me.N_Articulos_Almacen_ResumenDataGridView.MultiSelect = False
        Me.N_Articulos_Almacen_ResumenDataGridView.Name = "N_Articulos_Almacen_ResumenDataGridView"
        Me.N_Articulos_Almacen_ResumenDataGridView.ReadOnly = True
        Me.N_Articulos_Almacen_ResumenDataGridView.RowHeadersVisible = False
        Me.N_Articulos_Almacen_ResumenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_Articulos_Almacen_ResumenDataGridView.Size = New System.Drawing.Size(394, 159)
        Me.N_Articulos_Almacen_ResumenDataGridView.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDAlmacenDataGridViewTextBoxColumn
        '
        Me.IDAlmacenDataGridViewTextBoxColumn.DataPropertyName = "ID_Almacen"
        Me.IDAlmacenDataGridViewTextBoxColumn.HeaderText = "ID_Almacen"
        Me.IDAlmacenDataGridViewTextBoxColumn.Name = "IDAlmacenDataGridViewTextBoxColumn"
        Me.IDAlmacenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDAlmacenDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDArticuloDataGridViewTextBoxColumn
        '
        Me.IDArticuloDataGridViewTextBoxColumn.DataPropertyName = "ID_Articulo"
        Me.IDArticuloDataGridViewTextBoxColumn.HeaderText = "ID_Articulo"
        Me.IDArticuloDataGridViewTextBoxColumn.Name = "IDArticuloDataGridViewTextBoxColumn"
        Me.IDArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDArticuloDataGridViewTextBoxColumn.Visible = False
        '
        'StockMinimoDataGridViewTextBoxColumn
        '
        Me.StockMinimoDataGridViewTextBoxColumn.DataPropertyName = "StockMinimo"
        Me.StockMinimoDataGridViewTextBoxColumn.HeaderText = "StockMinimo"
        Me.StockMinimoDataGridViewTextBoxColumn.Name = "StockMinimoDataGridViewTextBoxColumn"
        Me.StockMinimoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockMaximoDataGridViewTextBoxColumn
        '
        Me.StockMaximoDataGridViewTextBoxColumn.DataPropertyName = "StockMaximo"
        Me.StockMaximoDataGridViewTextBoxColumn.HeaderText = "StockMaximo"
        Me.StockMaximoDataGridViewTextBoxColumn.Name = "StockMaximoDataGridViewTextBoxColumn"
        Me.StockMaximoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'N_Articulos_Almacen_ResumenBindingSource
        '
        Me.N_Articulos_Almacen_ResumenBindingSource.DataMember = "N_Articulos_Almacen_Resumen"
        Me.N_Articulos_Almacen_ResumenBindingSource.DataSource = Me.CMDataSet
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(442, 348)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 1
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'N_ArticulosTableAdapter
        '
        Me.N_ArticulosTableAdapter.ClearBeforeFill = True
        '
        'N_TipoIVATableAdapter
        '
        Me.N_TipoIVATableAdapter.ClearBeforeFill = True
        '
        'N_FamiliasTableAdapter
        '
        Me.N_FamiliasTableAdapter.ClearBeforeFill = True
        '
        'N_Articulos_Almacen_ResumenTableAdapter
        '
        Me.N_Articulos_Almacen_ResumenTableAdapter.ClearBeforeFill = True
        '
        'frmArticulos_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 376)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmArticulos_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_Details.ResumeLayout(False)
        Me.tab_Details.PerformLayout()
        CType(Me.N_ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_FamiliasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_TipoIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_Almacen.ResumeLayout(False)
        Me.grp_Almacen.ResumeLayout(False)
        CType(Me.pb_Almacen_Articulo_ADD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Articulos_Almacen_ResumenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Articulos_Almacen_ResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tab_Details As System.Windows.Forms.TabPage
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents N_ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_ArticulosTableAdapter As centro_medico.CMDataSetTableAdapters.N_ArticulosTableAdapter
    Friend WithEvents CodigoTextBox As ctrlTextboxAvanzado
    Friend WithEvents DescripcionTextBox As ctrlTextboxAvanzado
    Friend WithEvents EsEstocableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PrecioCompraTextBox As ctrlTextboxAvanzado
    Friend WithEvents N_TipoIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_TipoIVATableAdapter As centro_medico.CMDataSetTableAdapters.N_TipoIVATableAdapter
    Friend WithEvents Combo_TipoIVA As System.Windows.Forms.ComboBox
    Friend WithEvents CtrlProveedor1 As centro_medico.ctrlProveedor
    Friend WithEvents N_FamiliasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_FamiliasTableAdapter As centro_medico.CMDataSetTableAdapters.N_FamiliasTableAdapter
    Friend WithEvents combo_Familia As System.Windows.Forms.ComboBox
    Friend WithEvents tb_Almacen As System.Windows.Forms.TabPage
    Friend WithEvents grp_Almacen As System.Windows.Forms.GroupBox
    Friend WithEvents pb_Almacen_Articulo_ADD As System.Windows.Forms.PictureBox
    Friend WithEvents N_Articulos_Almacen_ResumenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents N_Articulos_Almacen_ResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Articulos_Almacen_ResumenTableAdapter As centro_medico.CMDataSetTableAdapters.N_Articulos_Almacen_ResumenTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockMinimoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockMaximoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As ctrlTextboxAvanzado
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
