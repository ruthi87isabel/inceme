<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidos
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton
        Me.tc_Presupuestos = New System.Windows.Forms.TabControl
        Me.tb_Todos = New System.Windows.Forms.TabPage
        Me.tb_Serie1 = New System.Windows.Forms.TabPage
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tst_Total = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tst_TotalSeleccionado = New System.Windows.Forms.ToolStripStatusLabel
        Me.N_PedidosDataGridView = New System.Windows.Forms.DataGridView
        Me.IDPedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlazoEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FormaDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AgenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.N_Pedidos_ResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New CMDataSet
        Me.N_Pedidos_ResumenTableAdapter = New CMDataSetTableAdapters.N_Pedidos_ResumenTableAdapter
        Me.ToolStrip1.SuspendLayout()
        Me.tc_Presupuestos.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.N_PedidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Pedidos_ResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(820, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        'Me.NewToolStripButton.Image = Global.My.Resources.Resources._24_em_plus
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'tst_Editar
        '
        Me.tst_Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tst_Editar.Enabled = False
        'Me.tst_Editar.Image = Global.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(23, 22)
        Me.tst_Editar.Text = "ToolStripButton2"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tst_Eliminar.Enabled = False
        'Me.tst_Eliminar.Image = Global.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(23, 22)
        Me.tst_Eliminar.Text = "ToolStripButton1"
        '
        'tc_Presupuestos
        '
        Me.tc_Presupuestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_Presupuestos.Controls.Add(Me.tb_Todos)
        Me.tc_Presupuestos.Controls.Add(Me.tb_Serie1)
        Me.tc_Presupuestos.Location = New System.Drawing.Point(0, 28)
        Me.tc_Presupuestos.Name = "tc_Presupuestos"
        Me.tc_Presupuestos.SelectedIndex = 0
        Me.tc_Presupuestos.Size = New System.Drawing.Size(820, 26)
        Me.tc_Presupuestos.TabIndex = 8
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_Total, Me.ToolStripStatusLabel1, Me.tst_TotalSeleccionado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 409)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(820, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tst_Total
        '
        Me.tst_Total.Name = "tst_Total"
        Me.tst_Total.Size = New System.Drawing.Size(44, 17)
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
        Me.tst_TotalSeleccionado.Size = New System.Drawing.Size(108, 17)
        Me.tst_TotalSeleccionado.Text = "Total seleccionado: 0"
        '
        'N_PedidosDataGridView
        '
        Me.N_PedidosDataGridView.AllowUserToAddRows = False
        Me.N_PedidosDataGridView.AllowUserToDeleteRows = False
        Me.N_PedidosDataGridView.AllowUserToResizeRows = False
        Me.N_PedidosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_PedidosDataGridView.AutoGenerateColumns = False
        Me.N_PedidosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.N_PedidosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.N_PedidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPedidoDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.PlazoEntrega, Me.ClienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.FormaDePagoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.AgenteDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.N_PedidosDataGridView.DataSource = Me.N_Pedidos_ResumenBindingSource
        Me.N_PedidosDataGridView.Location = New System.Drawing.Point(0, 53)
        Me.N_PedidosDataGridView.MultiSelect = False
        Me.N_PedidosDataGridView.Name = "N_PedidosDataGridView"
        Me.N_PedidosDataGridView.ReadOnly = True
        Me.N_PedidosDataGridView.RowHeadersVisible = False
        Me.N_PedidosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_PedidosDataGridView.Size = New System.Drawing.Size(818, 356)
        Me.N_PedidosDataGridView.TabIndex = 11
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
        Me.CodigoDataGridViewTextBoxColumn.Width = 66
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 63
        '
        'PlazoEntrega
        '
        Me.PlazoEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PlazoEntrega.DataPropertyName = "PlazoEntrega"
        Me.PlazoEntrega.HeaderText = "Fecha Entrega"
        Me.PlazoEntrega.Name = "PlazoEntrega"
        Me.PlazoEntrega.ReadOnly = True
        Me.PlazoEntrega.Width = 103
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 65
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReferenciaDataGridViewTextBoxColumn.Width = 85
        '
        'FormaDePagoDataGridViewTextBoxColumn
        '
        Me.FormaDePagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FormaDePagoDataGridViewTextBoxColumn.DataPropertyName = "Forma de Pago"
        Me.FormaDePagoDataGridViewTextBoxColumn.HeaderText = "Forma de Pago"
        Me.FormaDePagoDataGridViewTextBoxColumn.Name = "FormaDePagoDataGridViewTextBoxColumn"
        Me.FormaDePagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FormaDePagoDataGridViewTextBoxColumn.Visible = False
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 66
        '
        'AgenteDataGridViewTextBoxColumn
        '
        Me.AgenteDataGridViewTextBoxColumn.DataPropertyName = "Agente"
        Me.AgenteDataGridViewTextBoxColumn.HeaderText = "Agente"
        Me.AgenteDataGridViewTextBoxColumn.Name = "AgenteDataGridViewTextBoxColumn"
        Me.AgenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgenteDataGridViewTextBoxColumn.Visible = False
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 57
        '
        'N_Pedidos_ResumenBindingSource
        '
        Me.N_Pedidos_ResumenBindingSource.DataMember = "N_Pedidos_Resumen"
        Me.N_Pedidos_ResumenBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_Pedidos_ResumenTableAdapter
        '
        Me.N_Pedidos_ResumenTableAdapter.ClearBeforeFill = True
        '
        'frmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 431)
        Me.Controls.Add(Me.N_PedidosDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tc_Presupuestos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tc_Presupuestos.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.N_PedidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Pedidos_ResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tc_Presupuestos As System.Windows.Forms.TabControl
    Friend WithEvents tb_Todos As System.Windows.Forms.TabPage
    Friend WithEvents tb_Serie1 As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tst_Total As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tst_TotalSeleccionado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents N_PedidosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_Pedidos_ResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Pedidos_ResumenTableAdapter As CMDataSetTableAdapters.N_Pedidos_ResumenTableAdapter
    Friend WithEvents IDPedidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlazoEntrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormaDePagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
