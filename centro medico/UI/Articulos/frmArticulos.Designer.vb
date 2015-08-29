<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstImprimir = New System.Windows.Forms.ToolStripButton()
        Me.N_ArticulosResumenDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionGeneralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Familia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTipoIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFamiliaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorNombreFiscalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockPrevisto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Favorito = New System.Windows.Forms.DataGridViewImageColumn()
        Me.N_ArticulosResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabTodos = New System.Windows.Forms.TabPage()
        Me.TabFavoritos = New System.Windows.Forms.TabPage()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.N_ArticulosResumenTableAdapter = New centro_medico.CMDataSetTableAdapters.N_ArticulosResumenTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.N_ArticulosResumenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_ArticulosResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabTodos.SuspendLayout()
        Me.TabFavoritos.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tstImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(786, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = Global.centro_medico.My.Resources.Resources.MISC18
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tstImprimir
        '
        Me.tstImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tstImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstImprimir.Name = "tstImprimir"
        Me.tstImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tstImprimir.Text = "Imprimir"
        '
        'N_ArticulosResumenDataGridView
        '
        Me.N_ArticulosResumenDataGridView.AllowUserToAddRows = False
        Me.N_ArticulosResumenDataGridView.AllowUserToDeleteRows = False
        Me.N_ArticulosResumenDataGridView.AllowUserToOrderColumns = True
        Me.N_ArticulosResumenDataGridView.AllowUserToResizeRows = False
        Me.N_ArticulosResumenDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_ArticulosResumenDataGridView.AutoGenerateColumns = False
        Me.N_ArticulosResumenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDArticuloDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionGeneralDataGridViewTextBoxColumn, Me.Familia, Me.PrecioCompraDataGridViewTextBoxColumn, Me.IDTipoIVADataGridViewTextBoxColumn, Me.IDFamiliaDataGridViewTextBoxColumn, Me.ProveedorNombreFiscalDataGridViewTextBoxColumn, Me.StockReal, Me.StockPrevisto, Me.Favorito})
        Me.N_ArticulosResumenDataGridView.DataSource = Me.N_ArticulosResumenBindingSource
        Me.N_ArticulosResumenDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.N_ArticulosResumenDataGridView.MultiSelect = False
        Me.N_ArticulosResumenDataGridView.Name = "N_ArticulosResumenDataGridView"
        Me.N_ArticulosResumenDataGridView.ReadOnly = True
        Me.N_ArticulosResumenDataGridView.RowHeadersVisible = False
        Me.N_ArticulosResumenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_ArticulosResumenDataGridView.Size = New System.Drawing.Size(754, 453)
        Me.N_ArticulosResumenDataGridView.TabIndex = 9
        '
        'IDArticuloDataGridViewTextBoxColumn
        '
        Me.IDArticuloDataGridViewTextBoxColumn.DataPropertyName = "ID_Articulo"
        Me.IDArticuloDataGridViewTextBoxColumn.HeaderText = "ID_Articulo"
        Me.IDArticuloDataGridViewTextBoxColumn.Name = "IDArticuloDataGridViewTextBoxColumn"
        Me.IDArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDArticuloDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionGeneralDataGridViewTextBoxColumn
        '
        Me.DescripcionGeneralDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionGeneralDataGridViewTextBoxColumn.DataPropertyName = "DescripcionGeneral"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.Name = "DescripcionGeneralDataGridViewTextBoxColumn"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Familia
        '
        Me.Familia.DataPropertyName = "Familia"
        Me.Familia.HeaderText = "Familia"
        Me.Familia.Name = "Familia"
        Me.Familia.ReadOnly = True
        '
        'PrecioCompraDataGridViewTextBoxColumn
        '
        Me.PrecioCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioCompra"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "C2"
        Me.PrecioCompraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrecioCompraDataGridViewTextBoxColumn.HeaderText = "Precio Compra"
        Me.PrecioCompraDataGridViewTextBoxColumn.Name = "PrecioCompraDataGridViewTextBoxColumn"
        Me.PrecioCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDTipoIVADataGridViewTextBoxColumn
        '
        Me.IDTipoIVADataGridViewTextBoxColumn.DataPropertyName = "ID_TipoIVA"
        Me.IDTipoIVADataGridViewTextBoxColumn.HeaderText = "ID_TipoIVA"
        Me.IDTipoIVADataGridViewTextBoxColumn.Name = "IDTipoIVADataGridViewTextBoxColumn"
        Me.IDTipoIVADataGridViewTextBoxColumn.ReadOnly = True
        Me.IDTipoIVADataGridViewTextBoxColumn.Visible = False
        '
        'IDFamiliaDataGridViewTextBoxColumn
        '
        Me.IDFamiliaDataGridViewTextBoxColumn.DataPropertyName = "ID_Familia"
        Me.IDFamiliaDataGridViewTextBoxColumn.HeaderText = "ID_Familia"
        Me.IDFamiliaDataGridViewTextBoxColumn.Name = "IDFamiliaDataGridViewTextBoxColumn"
        Me.IDFamiliaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDFamiliaDataGridViewTextBoxColumn.Visible = False
        '
        'ProveedorNombreFiscalDataGridViewTextBoxColumn
        '
        Me.ProveedorNombreFiscalDataGridViewTextBoxColumn.DataPropertyName = "ProveedorNombreFiscal"
        Me.ProveedorNombreFiscalDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorNombreFiscalDataGridViewTextBoxColumn.Name = "ProveedorNombreFiscalDataGridViewTextBoxColumn"
        Me.ProveedorNombreFiscalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockReal
        '
        Me.StockReal.DataPropertyName = "StockReal"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.StockReal.DefaultCellStyle = DataGridViewCellStyle2
        Me.StockReal.HeaderText = "Stock Real"
        Me.StockReal.Name = "StockReal"
        Me.StockReal.ReadOnly = True
        '
        'StockPrevisto
        '
        Me.StockPrevisto.DataPropertyName = "StockPrevisto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.StockPrevisto.DefaultCellStyle = DataGridViewCellStyle3
        Me.StockPrevisto.HeaderText = "Stock Previsto"
        Me.StockPrevisto.Name = "StockPrevisto"
        Me.StockPrevisto.ReadOnly = True
        '
        'Favorito
        '
        Me.Favorito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Favorito.DefaultCellStyle = DataGridViewCellStyle4
        Me.Favorito.HeaderText = "Favorito"
        Me.Favorito.MinimumWidth = 50
        Me.Favorito.Name = "Favorito"
        Me.Favorito.ReadOnly = True
        Me.Favorito.Width = 50
        '
        'N_ArticulosResumenBindingSource
        '
        Me.N_ArticulosResumenBindingSource.DataMember = "N_ArticulosResumen"
        Me.N_ArticulosResumenBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabTodos)
        Me.TabControl1.Controls.Add(Me.TabFavoritos)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(774, 507)
        Me.TabControl1.TabIndex = 10
        '
        'tabTodos
        '
        Me.tabTodos.Controls.Add(Me.N_ArticulosResumenDataGridView)
        Me.tabTodos.Location = New System.Drawing.Point(4, 22)
        Me.tabTodos.Name = "tabTodos"
        Me.tabTodos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTodos.Size = New System.Drawing.Size(766, 481)
        Me.tabTodos.TabIndex = 0
        Me.tabTodos.Text = "Todos"
        Me.tabTodos.UseVisualStyleBackColor = True
        '
        'TabFavoritos
        '
        Me.TabFavoritos.Controls.Add(Me.GridEX1)
        Me.TabFavoritos.Location = New System.Drawing.Point(4, 22)
        Me.TabFavoritos.Name = "TabFavoritos"
        Me.TabFavoritos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFavoritos.Size = New System.Drawing.Size(766, 481)
        Me.TabFavoritos.TabIndex = 1
        Me.TabFavoritos.Text = "Favoritos"
        Me.TabFavoritos.UseVisualStyleBackColor = True
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.DataSource = Me.N_ArticulosResumenBindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(3, 6)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(757, 469)
        Me.GridEX1.TabIndex = 0
        '
        'N_ArticulosResumenTableAdapter
        '
        Me.N_ArticulosResumenTableAdapter.ClearBeforeFill = True
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 540)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.N_ArticulosResumenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_ArticulosResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabTodos.ResumeLayout(False)
        Me.TabFavoritos.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents N_ArticulosResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_ArticulosResumenTableAdapter As centro_medico.CMDataSetTableAdapters.N_ArticulosResumenTableAdapter
    Friend WithEvents N_ArticulosResumenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabTodos As System.Windows.Forms.TabPage
    Friend WithEvents TabFavoritos As System.Windows.Forms.TabPage
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents IDArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionGeneralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Familia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTipoIVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDFamiliaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorNombreFiscalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockReal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockPrevisto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Favorito As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstImprimir As System.Windows.Forms.ToolStripButton
End Class
