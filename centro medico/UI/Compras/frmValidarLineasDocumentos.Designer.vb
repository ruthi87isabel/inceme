<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidarLineasDocumentos
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_Documentos = New System.Windows.Forms.ComboBox
        Me.cmb_TipoDocumento = New System.Windows.Forms.ComboBox
        Me.LineasDataGridView = New System.Windows.Forms.DataGridView
        Me.Validar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.id_pedidolineas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID_Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descuento1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descuento2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descuento3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_TipoIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IvaIncluido = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Bultos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_DocOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_TipoDocOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_PresupuestoLineas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Presupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_AlbaranLineas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Albaran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Desmarcar = New System.Windows.Forms.Button
        Me.btn_MarcarTodos = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tb_Lineas = New System.Windows.Forms.TabPage
        Me.N_Entradas_LineasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_Entradas_LineasTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Entradas_LineasTableAdapter
        Me.CMDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_PedidosProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_PedidosProveedorTableAdapter = New centro_medico.CMDataSetTableAdapters.N_PedidosProveedorTableAdapter
        Me.N_PedidosProveedor_LineasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_PedidosProveedor_LineasTableAdapter = New centro_medico.CMDataSetTableAdapters.N_PedidosProveedor_LineasTableAdapter
        Me.N_Ticket_lineasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet1 = New centro_medico.CMDataSet
        Me.N_Ticket_LineasTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Ticket_LineasTableAdapter
        Me.N_TicketTableAdapter = New centro_medico.CMDataSetTableAdapters.N_TicketTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.LineasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tb_Lineas.SuspendLayout()
        CType(Me.N_Entradas_LineasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_PedidosProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_PedidosProveedor_LineasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Ticket_lineasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_Documentos)
        Me.GroupBox1.Controls.Add(Me.cmb_TipoDocumento)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(787, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Documentos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de Documento"
        '
        'cmb_Documentos
        '
        Me.cmb_Documentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Documentos.FormattingEnabled = True
        Me.cmb_Documentos.Location = New System.Drawing.Point(457, 31)
        Me.cmb_Documentos.Name = "cmb_Documentos"
        Me.cmb_Documentos.Size = New System.Drawing.Size(163, 21)
        Me.cmb_Documentos.TabIndex = 1
        '
        'cmb_TipoDocumento
        '
        Me.cmb_TipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDocumento.FormattingEnabled = True
        Me.cmb_TipoDocumento.Location = New System.Drawing.Point(159, 31)
        Me.cmb_TipoDocumento.Name = "cmb_TipoDocumento"
        Me.cmb_TipoDocumento.Size = New System.Drawing.Size(161, 21)
        Me.cmb_TipoDocumento.TabIndex = 0
        '
        'LineasDataGridView
        '
        Me.LineasDataGridView.AllowUserToAddRows = False
        Me.LineasDataGridView.AllowUserToDeleteRows = False
        Me.LineasDataGridView.AllowUserToResizeRows = False
        Me.LineasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineasDataGridView.AutoGenerateColumns = False
        Me.LineasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Validar, Me.id_pedidolineas, Me.ID_Pedido, Me.Codigo, Me.Id_Articulo, Me.Descripcion, Me.Cantidad, Me.Precio, Me.Descuento1, Me.Descuento2, Me.Descuento3, Me.Total, Me.Id_TipoIva, Me.IvaIncluido, Me.Observaciones, Me.Id_Almacen, Me.Bultos, Me.Id_DocOrigen, Me.Id_TipoDocOrigen, Me.Imagen, Me.Costo, Me.Comision, Me.Id_PresupuestoLineas, Me.Id_Presupuesto, Me.Id_AlbaranLineas, Me.Id_Albaran})
        Me.LineasDataGridView.DataSource = Me.CMDataSetBindingSource
        Me.LineasDataGridView.Location = New System.Drawing.Point(1, 0)
        Me.LineasDataGridView.MultiSelect = False
        Me.LineasDataGridView.Name = "LineasDataGridView"
        Me.LineasDataGridView.RowHeadersVisible = False
        Me.LineasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LineasDataGridView.Size = New System.Drawing.Size(776, 260)
        Me.LineasDataGridView.TabIndex = 3
        '
        'Validar
        '
        Me.Validar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Validar.DataPropertyName = "Validado"
        Me.Validar.HeaderText = "Validar"
        Me.Validar.Name = "Validar"
        Me.Validar.Width = 45
        '
        'id_pedidolineas
        '
        Me.id_pedidolineas.DataPropertyName = "id_PedidoLIneas"
        Me.id_pedidolineas.HeaderText = "id_PedidoLIneas"
        Me.id_pedidolineas.Name = "id_pedidolineas"
        Me.id_pedidolineas.Visible = False
        '
        'ID_Pedido
        '
        Me.ID_Pedido.DataPropertyName = "Id_Pedido"
        Me.ID_Pedido.HeaderText = "Id_Pedido"
        Me.ID_Pedido.Name = "ID_Pedido"
        Me.ID_Pedido.Visible = False
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.FillWeight = 177.9947!
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Visible = False
        Me.Codigo.Width = 75
        '
        'Id_Articulo
        '
        Me.Id_Articulo.DataPropertyName = "Id_Articulo"
        Me.Id_Articulo.FillWeight = 263.1579!
        Me.Id_Articulo.HeaderText = "Articulo"
        Me.Id_Articulo.Name = "Id_Articulo"
        Me.Id_Articulo.Width = 75
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.FillWeight = 40.22801!
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 225
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "Precio"
        DataGridViewCellStyle7.Format = "C"
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle7
        Me.Precio.FillWeight = 25.16677!
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 75
        '
        'Descuento1
        '
        Me.Descuento1.DataPropertyName = "Descuento1"
        Me.Descuento1.FillWeight = 37.05155!
        Me.Descuento1.HeaderText = "Desc 1"
        Me.Descuento1.Name = "Descuento1"
        Me.Descuento1.Width = 50
        '
        'Descuento2
        '
        Me.Descuento2.DataPropertyName = "Descuento2"
        Me.Descuento2.FillWeight = 54.7622!
        Me.Descuento2.HeaderText = "Desc 2"
        Me.Descuento2.Name = "Descuento2"
        Me.Descuento2.Width = 50
        '
        'Descuento3
        '
        Me.Descuento3.DataPropertyName = "Descuento3"
        Me.Descuento3.FillWeight = 81.15456!
        Me.Descuento3.HeaderText = "Desc 3"
        Me.Descuento3.Name = "Descuento3"
        Me.Descuento3.Width = 50
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle8.Format = "C"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle8
        Me.Total.FillWeight = 120.4843!
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.Width = 75
        '
        'Id_TipoIva
        '
        Me.Id_TipoIva.DataPropertyName = "Id_TipoIva"
        Me.Id_TipoIva.HeaderText = "Id_TipoIva"
        Me.Id_TipoIva.Name = "Id_TipoIva"
        Me.Id_TipoIva.Visible = False
        '
        'IvaIncluido
        '
        Me.IvaIncluido.DataPropertyName = "IvaIncluido"
        Me.IvaIncluido.HeaderText = "IvaIncluido"
        Me.IvaIncluido.Name = "IvaIncluido"
        Me.IvaIncluido.Visible = False
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Observaciones"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Visible = False
        '
        'Id_Almacen
        '
        Me.Id_Almacen.DataPropertyName = "Id_Almacen"
        Me.Id_Almacen.HeaderText = "Id_Almacen"
        Me.Id_Almacen.Name = "Id_Almacen"
        Me.Id_Almacen.Visible = False
        '
        'Bultos
        '
        Me.Bultos.DataPropertyName = "Bultos"
        Me.Bultos.HeaderText = "Bultos"
        Me.Bultos.Name = "Bultos"
        Me.Bultos.Visible = False
        '
        'Id_DocOrigen
        '
        Me.Id_DocOrigen.DataPropertyName = "Id_DocOrigen"
        Me.Id_DocOrigen.HeaderText = "Id_DocOrigen"
        Me.Id_DocOrigen.Name = "Id_DocOrigen"
        Me.Id_DocOrigen.Visible = False
        '
        'Id_TipoDocOrigen
        '
        Me.Id_TipoDocOrigen.DataPropertyName = "Id_TipoDocOrigen"
        Me.Id_TipoDocOrigen.HeaderText = "Id_TipoDocOrigen"
        Me.Id_TipoDocOrigen.Name = "Id_TipoDocOrigen"
        Me.Id_TipoDocOrigen.Visible = False
        '
        'Imagen
        '
        Me.Imagen.DataPropertyName = "Imagen"
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Imagen.Visible = False
        '
        'Costo
        '
        Me.Costo.DataPropertyName = "Costo"
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.Visible = False
        '
        'Comision
        '
        Me.Comision.DataPropertyName = "Comision"
        Me.Comision.HeaderText = "Comision"
        Me.Comision.Name = "Comision"
        Me.Comision.Visible = False
        '
        'Id_PresupuestoLineas
        '
        Me.Id_PresupuestoLineas.DataPropertyName = "Id_PresupuestoLineas"
        Me.Id_PresupuestoLineas.HeaderText = "Id_PresupuestoLineas"
        Me.Id_PresupuestoLineas.Name = "Id_PresupuestoLineas"
        Me.Id_PresupuestoLineas.Visible = False
        '
        'Id_Presupuesto
        '
        Me.Id_Presupuesto.DataPropertyName = "Id_Presupuesto"
        Me.Id_Presupuesto.HeaderText = "Id_Presupuesto"
        Me.Id_Presupuesto.Name = "Id_Presupuesto"
        Me.Id_Presupuesto.Visible = False
        '
        'Id_AlbaranLineas
        '
        Me.Id_AlbaranLineas.DataPropertyName = "Id_albaranLineas"
        Me.Id_AlbaranLineas.HeaderText = "Id_albaranLineas"
        Me.Id_AlbaranLineas.Name = "Id_AlbaranLineas"
        Me.Id_AlbaranLineas.Visible = False
        '
        'Id_Albaran
        '
        Me.Id_Albaran.DataPropertyName = "Id_Albaran"
        Me.Id_Albaran.HeaderText = "Id_Albaran"
        Me.Id_Albaran.Name = "Id_Albaran"
        Me.Id_Albaran.Visible = False
        '
        'CMDataSetBindingSource
        '
        Me.CMDataSetBindingSource.DataSource = Me.CMDataSet
        Me.CMDataSetBindingSource.Position = 0
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Location = New System.Drawing.Point(626, 362)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(75, 29)
        Me.btn_Validar.TabIndex = 4
        Me.btn_Validar.Text = "Validar"
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Location = New System.Drawing.Point(709, 362)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 29)
        Me.btn_Cancelar.TabIndex = 4
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Desmarcar
        '
        Me.btn_Desmarcar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Desmarcar.Location = New System.Drawing.Point(113, 362)
        Me.btn_Desmarcar.Name = "btn_Desmarcar"
        Me.btn_Desmarcar.Size = New System.Drawing.Size(109, 29)
        Me.btn_Desmarcar.TabIndex = 4
        Me.btn_Desmarcar.Text = "Desmarcar Todos"
        Me.btn_Desmarcar.UseVisualStyleBackColor = True
        '
        'btn_MarcarTodos
        '
        Me.btn_MarcarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_MarcarTodos.Location = New System.Drawing.Point(7, 362)
        Me.btn_MarcarTodos.Name = "btn_MarcarTodos"
        Me.btn_MarcarTodos.Size = New System.Drawing.Size(100, 29)
        Me.btn_MarcarTodos.TabIndex = 4
        Me.btn_MarcarTodos.Text = "Marcar Todos"
        Me.btn_MarcarTodos.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tb_Lineas)
        Me.TabControl1.Location = New System.Drawing.Point(0, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(787, 286)
        Me.TabControl1.TabIndex = 5
        '
        'tb_Lineas
        '
        Me.tb_Lineas.Controls.Add(Me.LineasDataGridView)
        Me.tb_Lineas.Location = New System.Drawing.Point(4, 22)
        Me.tb_Lineas.Name = "tb_Lineas"
        Me.tb_Lineas.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Lineas.Size = New System.Drawing.Size(779, 260)
        Me.tb_Lineas.TabIndex = 0
        Me.tb_Lineas.Text = "Lineas"
        Me.tb_Lineas.UseVisualStyleBackColor = True
        '
        'N_Entradas_LineasBindingSource
        '
        Me.N_Entradas_LineasBindingSource.DataMember = "N_Entradas_Lineas"
        Me.N_Entradas_LineasBindingSource.DataSource = Me.CMDataSet
        '
        'N_Entradas_LineasTableAdapter
        '
        Me.N_Entradas_LineasTableAdapter.ClearBeforeFill = True
        '
        'CMDataSetBindingSource1
        '
        Me.CMDataSetBindingSource1.DataSource = Me.CMDataSet
        Me.CMDataSetBindingSource1.Position = 0
        '
        'N_PedidosProveedorBindingSource
        '
        Me.N_PedidosProveedorBindingSource.DataMember = "N_PedidosProveedor"
        Me.N_PedidosProveedorBindingSource.DataSource = Me.CMDataSet
        '
        'N_PedidosProveedorTableAdapter
        '
        Me.N_PedidosProveedorTableAdapter.ClearBeforeFill = True
        '
        'N_PedidosProveedor_LineasBindingSource
        '
        Me.N_PedidosProveedor_LineasBindingSource.DataMember = "N_PedidosProveedor_Lineas"
        Me.N_PedidosProveedor_LineasBindingSource.DataSource = Me.CMDataSet
        '
        'N_PedidosProveedor_LineasTableAdapter
        '
        Me.N_PedidosProveedor_LineasTableAdapter.ClearBeforeFill = True
        '
        'N_Ticket_lineasBindingSource
        '
        Me.N_Ticket_lineasBindingSource.DataMember = "N_Ticket_Lineas"
        Me.N_Ticket_lineasBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet1
        '
        Me.CMDataSet1.DataSetName = "CMDataSet"
        Me.CMDataSet1.EnforceConstraints = False
        Me.CMDataSet1.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_Ticket_LineasTableAdapter
        '
        Me.N_Ticket_LineasTableAdapter.ClearBeforeFill = True
        '
        'N_TicketTableAdapter
        '
        Me.N_TicketTableAdapter.ClearBeforeFill = True
        '
        'frmValidarLineasDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 397)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_MarcarTodos)
        Me.Controls.Add(Me.btn_Desmarcar)
        Me.Controls.Add(Me.btn_Validar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmValidarLineasDocumentos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validación de Líneas de Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LineasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tb_Lineas.ResumeLayout(False)
        CType(Me.N_Entradas_LineasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_PedidosProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_PedidosProveedor_LineasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Ticket_lineasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Documentos As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_TipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents CMDataSet As CMDataSet
    'Friend WithEvents N_Presupuestos_LineasBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents N_Presupuestos_LineasTableAdapter As CMDataSetTableAdapters.N_Presupuestos_LineasTableAdapter
    Friend WithEvents LineasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Desmarcar As System.Windows.Forms.Button
    Friend WithEvents btn_MarcarTodos As System.Windows.Forms.Button
    'Friend WithEvents N_Pedidos_LineasBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents N_Pedidos_LineasTableAdapter As CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter
    'Friend WithEvents N_Albaranes_LineasBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents N_Albaranes_LineasTableAdapter As CMDataSetTableAdapters.N_Albaranes_LineasTableAdapter
    ' Friend WithEvents N_PedidosProveedor_LineasBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents N_PedidosProveedor_LineasTableAdapter As CMDataSetTableAdapters.N_PedidosProveedor_LineasTableAdapter
    Friend WithEvents N_Entradas_LineasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Entradas_LineasTableAdapter As CMDataSetTableAdapters.N_Entradas_LineasTableAdapter
    'Friend WithEvents N_Devoluciones_LineasBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents N_Devoluciones_LineasTableAdapter As CMDataSetTableAdapters.N_Devoluciones_LineasTableAdapter
    Friend WithEvents N_PartesBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents N_PartesTableAdapter As CMDataSetTableAdapters.N_PartesTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tb_Lineas As System.Windows.Forms.TabPage
    Friend WithEvents CMDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Validar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id_pedidolineas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_Pedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_TipoIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaIncluido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bultos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_DocOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_TipoDocOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Imagen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_PresupuestoLineas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Presupuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_AlbaranLineas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Albaran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents N_PedidosProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_PedidosProveedorTableAdapter As centro_medico.CMDataSetTableAdapters.N_PedidosProveedorTableAdapter
    Friend WithEvents N_PedidosProveedor_LineasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_PedidosProveedor_LineasTableAdapter As centro_medico.CMDataSetTableAdapters.N_PedidosProveedor_LineasTableAdapter
    Friend WithEvents N_Ticket_lineasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet1 As centro_medico.CMDataSet
    Friend WithEvents N_Ticket_LineasTableAdapter As centro_medico.CMDataSetTableAdapters.N_Ticket_LineasTableAdapter
    Friend WithEvents N_TicketTableAdapter As centro_medico.CMDataSetTableAdapters.N_TicketTableAdapter
End Class
