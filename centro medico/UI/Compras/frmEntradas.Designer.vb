<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradas
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tc_Entradas = New System.Windows.Forms.TabControl()
        Me.tb_Todos = New System.Windows.Forms.TabPage()
        Me.tb_Serie1 = New System.Windows.Forms.TabPage()
        Me.N_EntradasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_Entradas_ResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.N_Entradas_ResumenTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Entradas_ResumenTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tst_Total = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tst_TotalSeleccionado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.tc_Entradas.SuspendLayout()
        CType(Me.N_EntradasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Entradas_ResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(820, 25)
        Me.ToolStrip1.TabIndex = 6
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
        'tc_Entradas
        '
        Me.tc_Entradas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_Entradas.Controls.Add(Me.tb_Todos)
        Me.tc_Entradas.Controls.Add(Me.tb_Serie1)
        Me.tc_Entradas.Location = New System.Drawing.Point(0, 28)
        Me.tc_Entradas.Name = "tc_Entradas"
        Me.tc_Entradas.SelectedIndex = 0
        Me.tc_Entradas.Size = New System.Drawing.Size(820, 26)
        Me.tc_Entradas.TabIndex = 7
        '
        'tb_Todos
        '
        Me.tb_Todos.Location = New System.Drawing.Point(4, 22)
        Me.tb_Todos.Name = "tb_Todos"
        Me.tb_Todos.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Todos.Size = New System.Drawing.Size(812, 0)
        Me.tb_Todos.TabIndex = 0
        Me.tb_Todos.Text = "Todos"
        Me.tb_Todos.UseVisualStyleBackColor = True
        '
        'tb_Serie1
        '
        Me.tb_Serie1.Location = New System.Drawing.Point(4, 22)
        Me.tb_Serie1.Name = "tb_Serie1"
        Me.tb_Serie1.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Serie1.Size = New System.Drawing.Size(812, 0)
        Me.tb_Serie1.TabIndex = 1
        Me.tb_Serie1.Text = "Serie 1"
        Me.tb_Serie1.UseVisualStyleBackColor = True
        '
        'N_EntradasDataGridView
        '
        Me.N_EntradasDataGridView.AllowUserToAddRows = False
        Me.N_EntradasDataGridView.AllowUserToDeleteRows = False
        Me.N_EntradasDataGridView.AllowUserToResizeRows = False
        Me.N_EntradasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_EntradasDataGridView.AutoGenerateColumns = False
        Me.N_EntradasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.N_EntradasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.N_EntradasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDEntradaDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.Proveedor, Me.NombreProveedor, Me.ReferenciaDataGridViewTextBoxColumn, Me.FormaDePagoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.N_EntradasDataGridView.DataSource = Me.N_Entradas_ResumenBindingSource
        Me.N_EntradasDataGridView.Location = New System.Drawing.Point(0, 53)
        Me.N_EntradasDataGridView.MultiSelect = False
        Me.N_EntradasDataGridView.Name = "N_EntradasDataGridView"
        Me.N_EntradasDataGridView.ReadOnly = True
        Me.N_EntradasDataGridView.RowHeadersVisible = False
        Me.N_EntradasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_EntradasDataGridView.Size = New System.Drawing.Size(818, 356)
        Me.N_EntradasDataGridView.TabIndex = 8
        '
        'IDEntradaDataGridViewTextBoxColumn
        '
        Me.IDEntradaDataGridViewTextBoxColumn.DataPropertyName = "ID_Entrada"
        Me.IDEntradaDataGridViewTextBoxColumn.HeaderText = "ID_Entrada"
        Me.IDEntradaDataGridViewTextBoxColumn.Name = "IDEntradaDataGridViewTextBoxColumn"
        Me.IDEntradaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDEntradaDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "T-Número"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 79
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 62
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        '
        'NombreProveedor
        '
        Me.NombreProveedor.DataPropertyName = "NombreProveedor"
        Me.NombreProveedor.HeaderText = "Nombre"
        Me.NombreProveedor.Name = "NombreProveedor"
        Me.NombreProveedor.ReadOnly = True
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormaDePagoDataGridViewTextBoxColumn
        '
        Me.FormaDePagoDataGridViewTextBoxColumn.DataPropertyName = "Forma de Pago"
        Me.FormaDePagoDataGridViewTextBoxColumn.HeaderText = "Forma de Pago"
        Me.FormaDePagoDataGridViewTextBoxColumn.Name = "FormaDePagoDataGridViewTextBoxColumn"
        Me.FormaDePagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 65
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'N_Entradas_ResumenBindingSource
        '
        Me.N_Entradas_ResumenBindingSource.DataMember = "N_Entradas_Resumen"
        Me.N_Entradas_ResumenBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_Entradas_ResumenTableAdapter
        '
        Me.N_Entradas_ResumenTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_Total, Me.ToolStripStatusLabel1, Me.tst_TotalSeleccionado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 409)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(820, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tst_Total
        '
        Me.tst_Total.Name = "tst_Total"
        Me.tst_Total.Size = New System.Drawing.Size(46, 17)
        Me.tst_Total.Text = "Total: 0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(76, 17)
        Me.ToolStripStatusLabel1.Text = "                       "
        '
        'tst_TotalSeleccionado
        '
        Me.tst_TotalSeleccionado.Name = "tst_TotalSeleccionado"
        Me.tst_TotalSeleccionado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tst_TotalSeleccionado.Size = New System.Drawing.Size(118, 17)
        Me.tst_TotalSeleccionado.Text = "Total seleccionado: 0"
        '
        'frmEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 431)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.N_EntradasDataGridView)
        Me.Controls.Add(Me.tc_Entradas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmEntradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entradas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tc_Entradas.ResumeLayout(False)
        CType(Me.N_EntradasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Entradas_ResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tc_Entradas As System.Windows.Forms.TabControl
    Friend WithEvents tb_Todos As System.Windows.Forms.TabPage
    Friend WithEvents tb_Serie1 As System.Windows.Forms.TabPage
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_EntradasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents N_Entradas_ResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Entradas_ResumenTableAdapter As CMDataSetTableAdapters.N_Entradas_ResumenTableAdapter
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tst_Total As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tst_TotalSeleccionado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents IDEntradaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormaDePagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
