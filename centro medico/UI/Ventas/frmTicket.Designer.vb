<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ID_TicketLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim ID_FormaPagoLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim PagadoLabel As System.Windows.Forms.Label
        Dim FechaPagadoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.N_TicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_TicketTableAdapter = New centro_medico.CMDataSetTableAdapters.N_TicketTableAdapter
        Me.ID_TicketTextBox = New ctrlTextboxAvanzado
        Me.ReferenciaTextBox = New ctrlTextboxAvanzado
        Me.N_Ticket_LineasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_Ticket_LineasTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Ticket_LineasTableAdapter
        Me.ID_FormaPagoComboBox = New System.Windows.Forms.ComboBox
        Me.FormasPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalTextBox = New ctrlTextboxAvanzado
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.N_Ticket_LineasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colGuscar = New System.Windows.Forms.DataGridViewImageColumn
        Me.ColIdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDescuento1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDescuento2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDescuento3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColTipoIva = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.NTipoIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColIvaIncluido = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColIdAlmacen = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Almacen_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.N_Ticket_TotalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_Ticket_TotalesTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Ticket_TotalesTableAdapter
        Me.txtInfoIva = New ctrlTextboxAvanzado
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tlsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsb_DebitoPaciente = New System.Windows.Forms.ToolStripButton
        Me.FORMASPAGOTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
        Me.N_TipoIVATableAdapter = New centro_medico.CMDataSetTableAdapters.N_TipoIVATableAdapter
        Me.btAddLinea = New System.Windows.Forms.Button
        Me.btEliminar = New System.Windows.Forms.Button
        Me.N_ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_ArticulosTableAdapter = New centro_medico.CMDataSetTableAdapters.N_ArticulosTableAdapter
        Me.lblIva = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.PagadoCheckBox = New System.Windows.Forms.CheckBox
        Me.FechaPagadoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.N_AlmacenTableAdapter = New centro_medico.CMDataSetTableAdapters.N_AlmacenTableAdapter
        Me.CtrlDocProcesados1 = New centro_medico.ctrlDocProcesados
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente
        Me.grpTodo = New System.Windows.Forms.GroupBox
        Me.btn_EmitirCita = New System.Windows.Forms.Button
        Me.CtrlStatusPaciente1 = New centro_medico.ctrlStatusPaciente
        ID_TicketLabel = New System.Windows.Forms.Label
        ReferenciaLabel = New System.Windows.Forms.Label
        ID_FormaPagoLabel = New System.Windows.Forms.Label
        TotalLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        PagadoLabel = New System.Windows.Forms.Label
        FechaPagadoLabel = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_TicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Ticket_LineasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormasPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Ticket_LineasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NTipoIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Almacen_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Ticket_TotalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.N_ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.grpTodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_TicketLabel
        '
        ID_TicketLabel.AutoSize = True
        ID_TicketLabel.Location = New System.Drawing.Point(8, 95)
        ID_TicketLabel.Name = "ID_TicketLabel"
        ID_TicketLabel.Size = New System.Drawing.Size(54, 13)
        ID_TicketLabel.TabIndex = 3
        ID_TicketLabel.Text = "ID Ticket:"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(8, 121)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(62, 13)
        ReferenciaLabel.TabIndex = 5
        ReferenciaLabel.Text = "Referencia:"
        '
        'ID_FormaPagoLabel
        '
        ID_FormaPagoLabel.AutoSize = True
        ID_FormaPagoLabel.Location = New System.Drawing.Point(203, 121)
        ID_FormaPagoLabel.Name = "ID_FormaPagoLabel"
        ID_FormaPagoLabel.Size = New System.Drawing.Size(67, 13)
        ID_FormaPagoLabel.TabIndex = 8
        ID_FormaPagoLabel.Text = "Forma Pago:"
        '
        'TotalLabel
        '
        TotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(671, 455)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(132, 23)
        TotalLabel.TabIndex = 10
        TotalLabel.Text = "Total:"
        TotalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(498, 46)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 12
        FechaLabel.Text = "Fecha:"
        '
        'PagadoLabel
        '
        PagadoLabel.AutoSize = True
        PagadoLabel.Location = New System.Drawing.Point(223, 95)
        PagadoLabel.Name = "PagadoLabel"
        PagadoLabel.Size = New System.Drawing.Size(47, 13)
        PagadoLabel.TabIndex = 24
        PagadoLabel.Text = "Pagado:"
        '
        'FechaPagadoLabel
        '
        FechaPagadoLabel.AutoSize = True
        FechaPagadoLabel.Location = New System.Drawing.Point(456, 119)
        FechaPagadoLabel.Name = "FechaPagadoLabel"
        FechaPagadoLabel.Size = New System.Drawing.Size(80, 13)
        FechaPagadoLabel.TabIndex = 25
        FechaPagadoLabel.Text = "Fecha Pagado:"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_TicketBindingSource
        '
        Me.N_TicketBindingSource.DataMember = "N_Ticket"
        Me.N_TicketBindingSource.DataSource = Me.CMDataSet
        '
        'N_TicketTableAdapter
        '
        Me.N_TicketTableAdapter.ClearBeforeFill = True
        '
        'ID_TicketTextBox
        '
        Me.ID_TicketTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_TicketBindingSource, "ID_Ticket", True))
        Me.ID_TicketTextBox.Location = New System.Drawing.Point(76, 92)
        Me.ID_TicketTextBox.Name = "ID_TicketTextBox"
        Me.ID_TicketTextBox.ReadOnly = True
        Me.ID_TicketTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_TicketTextBox.TabIndex = 4
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_TicketBindingSource, "Referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(76, 118)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReferenciaTextBox.TabIndex = 6
        '
        'N_Ticket_LineasBindingSource
        '
        Me.N_Ticket_LineasBindingSource.DataMember = "N_Ticket_Lineas"
        Me.N_Ticket_LineasBindingSource.DataSource = Me.CMDataSet
        '
        'N_Ticket_LineasTableAdapter
        '
        Me.N_Ticket_LineasTableAdapter.ClearBeforeFill = True
        '
        'ID_FormaPagoComboBox
        '
        Me.ID_FormaPagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_TicketBindingSource, "ID_FormaPago", True))
        Me.ID_FormaPagoComboBox.DataSource = Me.FormasPagoBindingSource
        Me.ID_FormaPagoComboBox.DisplayMember = "DESCRIPCION"
        Me.ID_FormaPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ID_FormaPagoComboBox.FormattingEnabled = True
        Me.ID_FormaPagoComboBox.Location = New System.Drawing.Point(276, 116)
        Me.ID_FormaPagoComboBox.Name = "ID_FormaPagoComboBox"
        Me.ID_FormaPagoComboBox.Size = New System.Drawing.Size(174, 21)
        Me.ID_FormaPagoComboBox.TabIndex = 9
        Me.ID_FormaPagoComboBox.ValueMember = "CODIGO"
        '
        'FormasPagoBindingSource
        '
        Me.FormasPagoBindingSource.DataMember = "FORMASPAGO"
        Me.FormasPagoBindingSource.DataSource = Me.CMDataSet
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalTextBox.BackColor = System.Drawing.Color.GhostWhite
        Me.TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_TicketBindingSource, "Total", True))
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(671, 477)
        Me.TotalTextBox.Multiline = True
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(132, 45)
        Me.TotalTextBox.TabIndex = 11
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_TicketBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(544, 40)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.FechaDateTimePicker.TabIndex = 13
        '
        'N_Ticket_LineasDataGridView
        '
        Me.N_Ticket_LineasDataGridView.AllowUserToAddRows = False
        Me.N_Ticket_LineasDataGridView.AllowUserToResizeColumns = False
        Me.N_Ticket_LineasDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.N_Ticket_LineasDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.N_Ticket_LineasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_Ticket_LineasDataGridView.AutoGenerateColumns = False
        Me.N_Ticket_LineasDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.N_Ticket_LineasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.N_Ticket_LineasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.colCodigo, Me.colGuscar, Me.ColIdArticulo, Me.ColDescripcion, Me.ColCantidad, Me.ColPrecio, Me.ColDescuento1, Me.ColDescuento2, Me.ColDescuento3, Me.ColTotal, Me.ColTipoIva, Me.ColIvaIncluido, Me.DataGridViewTextBoxColumn13, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn14, Me.ColIdAlmacen, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.N_Ticket_LineasDataGridView.DataSource = Me.N_Ticket_LineasBindingSource
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.N_Ticket_LineasDataGridView.DefaultCellStyle = DataGridViewCellStyle18
        Me.N_Ticket_LineasDataGridView.Location = New System.Drawing.Point(7, 144)
        Me.N_Ticket_LineasDataGridView.Name = "N_Ticket_LineasDataGridView"
        Me.N_Ticket_LineasDataGridView.RowHeadersVisible = False
        Me.N_Ticket_LineasDataGridView.Size = New System.Drawing.Size(795, 305)
        Me.N_Ticket_LineasDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Ticket"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_Ticket"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'colCodigo
        '
        Me.colCodigo.DataPropertyName = "Codigo"
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCodigo.Width = 75
        '
        'colGuscar
        '
        Me.colGuscar.HeaderText = "..."
        Me.colGuscar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.colGuscar.Name = "colGuscar"
        Me.colGuscar.ReadOnly = True
        Me.colGuscar.Width = 30
        '
        'ColIdArticulo
        '
        Me.ColIdArticulo.DataPropertyName = "ID_Articulo"
        Me.ColIdArticulo.HeaderText = "Artículo"
        Me.ColIdArticulo.Name = "ColIdArticulo"
        Me.ColIdArticulo.Visible = False
        Me.ColIdArticulo.Width = 50
        '
        'ColDescripcion
        '
        Me.ColDescripcion.DataPropertyName = "Descripcion"
        Me.ColDescripcion.HeaderText = "Descripcion"
        Me.ColDescripcion.Name = "ColDescripcion"
        Me.ColDescripcion.Width = 250
        '
        'ColCantidad
        '
        Me.ColCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.ColCantidad.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColCantidad.HeaderText = "Uds."
        Me.ColCantidad.Name = "ColCantidad"
        Me.ColCantidad.Width = 50
        '
        'ColPrecio
        '
        Me.ColPrecio.DataPropertyName = "Precio"
        DataGridViewCellStyle13.Format = "C2"
        Me.ColPrecio.DefaultCellStyle = DataGridViewCellStyle13
        Me.ColPrecio.HeaderText = "Precio"
        Me.ColPrecio.Name = "ColPrecio"
        Me.ColPrecio.Width = 50
        '
        'ColDescuento1
        '
        Me.ColDescuento1.DataPropertyName = "Descuento1"
        DataGridViewCellStyle14.Format = "N2"
        Me.ColDescuento1.DefaultCellStyle = DataGridViewCellStyle14
        Me.ColDescuento1.HeaderText = "Dto"
        Me.ColDescuento1.Name = "ColDescuento1"
        Me.ColDescuento1.Width = 50
        '
        'ColDescuento2
        '
        Me.ColDescuento2.DataPropertyName = "Descuento2"
        DataGridViewCellStyle15.Format = "N2"
        Me.ColDescuento2.DefaultCellStyle = DataGridViewCellStyle15
        Me.ColDescuento2.HeaderText = "Dto2"
        Me.ColDescuento2.Name = "ColDescuento2"
        Me.ColDescuento2.Width = 50
        '
        'ColDescuento3
        '
        Me.ColDescuento3.DataPropertyName = "Descuento3"
        DataGridViewCellStyle16.Format = "N2"
        Me.ColDescuento3.DefaultCellStyle = DataGridViewCellStyle16
        Me.ColDescuento3.HeaderText = "Dto3"
        Me.ColDescuento3.Name = "ColDescuento3"
        Me.ColDescuento3.Width = 50
        '
        'ColTotal
        '
        Me.ColTotal.DataPropertyName = "Total"
        DataGridViewCellStyle17.Format = "C2"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.ColTotal.DefaultCellStyle = DataGridViewCellStyle17
        Me.ColTotal.HeaderText = "Total"
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.Width = 75
        '
        'ColTipoIva
        '
        Me.ColTipoIva.DataPropertyName = "ID_TipoIVA"
        Me.ColTipoIva.DataSource = Me.NTipoIVABindingSource
        Me.ColTipoIva.DisplayMember = "Valor"
        Me.ColTipoIva.HeaderText = "IVA"
        Me.ColTipoIva.Name = "ColTipoIva"
        Me.ColTipoIva.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColTipoIva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColTipoIva.ValueMember = "ID_TipoIVA"
        Me.ColTipoIva.Width = 50
        '
        'NTipoIVABindingSource
        '
        Me.NTipoIVABindingSource.DataMember = "N_TipoIVA"
        Me.NTipoIVABindingSource.DataSource = Me.CMDataSet
        '
        'ColIvaIncluido
        '
        Me.ColIvaIncluido.DataPropertyName = "IVAIncluido"
        Me.ColIvaIncluido.HeaderText = "IVAIncluido"
        Me.ColIvaIncluido.Name = "ColIvaIncluido"
        Me.ColIvaIncluido.Width = 50
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Costo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Imagen"
        Me.DataGridViewImageColumn1.HeaderText = "Imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'ColIdAlmacen
        '
        Me.ColIdAlmacen.DataPropertyName = "ID_Almacen"
        Me.ColIdAlmacen.DataSource = Me.Almacen_BindingSource
        Me.ColIdAlmacen.DisplayMember = "Descripcion"
        Me.ColIdAlmacen.HeaderText = "Amacen"
        Me.ColIdAlmacen.Name = "ColIdAlmacen"
        Me.ColIdAlmacen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColIdAlmacen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColIdAlmacen.ValueMember = "ID_Almacen"
        '
        'Almacen_BindingSource
        '
        Me.Almacen_BindingSource.DataMember = "N_Almacen"
        Me.Almacen_BindingSource.DataSource = Me.CMDataSet
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Validado"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Validado"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ID_DocOrigen"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ID_DocOrigen"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ID_TipoDocOrigen"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ID_TipoDocOrigen"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'N_Ticket_TotalesBindingSource
        '
        Me.N_Ticket_TotalesBindingSource.DataMember = "FK_N_Ticket_Totales_N_Ticket"
        Me.N_Ticket_TotalesBindingSource.DataSource = Me.N_TicketBindingSource
        '
        'N_Ticket_TotalesTableAdapter
        '
        Me.N_Ticket_TotalesTableAdapter.ClearBeforeFill = True
        '
        'txtInfoIva
        '
        Me.txtInfoIva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInfoIva.BackColor = System.Drawing.Color.GhostWhite
        Me.txtInfoIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfoIva.Location = New System.Drawing.Point(533, 477)
        Me.txtInfoIva.Multiline = True
        Me.txtInfoIva.Name = "txtInfoIva"
        Me.txtInfoIva.ReadOnly = True
        Me.txtInfoIva.Size = New System.Drawing.Size(131, 45)
        Me.txtInfoIva.TabIndex = 16
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsbNuevo, Me.tsbGuardar, Me.tsbCancelar, Me.tlbImprimir, Me.ToolStripSeparator1, Me.tsb_DebitoPaciente})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(817, 25)
        Me.ToolStrip2.TabIndex = 19
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tlsbNuevo
        '
        Me.tlsbNuevo.Image = Global.centro_medico.My.Resources.Resources._24_book_green
        Me.tlsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbNuevo.Name = "tlsbNuevo"
        Me.tlsbNuevo.Size = New System.Drawing.Size(62, 22)
        Me.tlsbNuevo.Text = "Nuevo"
        Me.tlsbNuevo.Visible = False
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(70, 22)
        Me.tsbCancelar.Text = "Eliminar"
        Me.tsbCancelar.Visible = False
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsb_DebitoPaciente
        '
        Me.tsb_DebitoPaciente.Enabled = False
        Me.tsb_DebitoPaciente.Image = Global.centro_medico.My.Resources.Resources.PacienteDebito
        Me.tsb_DebitoPaciente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_DebitoPaciente.Name = "tsb_DebitoPaciente"
        Me.tsb_DebitoPaciente.Size = New System.Drawing.Size(110, 22)
        Me.tsb_DebitoPaciente.Text = "Débito Paciente"
        '
        'FORMASPAGOTableAdapter
        '
        Me.FORMASPAGOTableAdapter.ClearBeforeFill = True
        '
        'N_TipoIVATableAdapter
        '
        Me.N_TipoIVATableAdapter.ClearBeforeFill = True
        '
        'btAddLinea
        '
        Me.btAddLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btAddLinea.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddLinea.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btAddLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAddLinea.Location = New System.Drawing.Point(6, 455)
        Me.btAddLinea.Name = "btAddLinea"
        Me.btAddLinea.Size = New System.Drawing.Size(129, 62)
        Me.btAddLinea.TabIndex = 20
        Me.btAddLinea.Text = "Añadir"
        Me.btAddLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAddLinea.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btEliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEliminar.Location = New System.Drawing.Point(141, 455)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(129, 62)
        Me.btEliminar.TabIndex = 21
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'N_ArticulosBindingSource
        '
        Me.N_ArticulosBindingSource.DataMember = "N_Articulos"
        Me.N_ArticulosBindingSource.DataSource = Me.CMDataSet
        '
        'N_ArticulosTableAdapter
        '
        Me.N_ArticulosTableAdapter.ClearBeforeFill = True
        '
        'lblIva
        '
        Me.lblIva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIva.Location = New System.Drawing.Point(533, 455)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(131, 23)
        Me.lblIva.TabIndex = 23
        Me.lblIva.Text = "Iva Desglosado"
        Me.lblIva.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 556)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(817, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(451, 17)
        Me.ToolStripStatusLabel1.Text = " Guardar Ticket-> F3 -- Imprimir Ticket-> F4 -- Añadir linea-> F5 -- Borrar linea" & _
            "-> F6"
        '
        'PagadoCheckBox
        '
        Me.PagadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.N_TicketBindingSource, "Pagado", True))
        Me.PagadoCheckBox.Location = New System.Drawing.Point(276, 90)
        Me.PagadoCheckBox.Name = "PagadoCheckBox"
        Me.PagadoCheckBox.Size = New System.Drawing.Size(19, 24)
        Me.PagadoCheckBox.TabIndex = 25
        '
        'FechaPagadoDateTimePicker
        '
        Me.FechaPagadoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_TicketBindingSource, "FechaPagado", True))
        Me.FechaPagadoDateTimePicker.Enabled = False
        Me.FechaPagadoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaPagadoDateTimePicker.Location = New System.Drawing.Point(544, 113)
        Me.FechaPagadoDateTimePicker.Name = "FechaPagadoDateTimePicker"
        Me.FechaPagadoDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.FechaPagadoDateTimePicker.TabIndex = 26
        '
        'N_AlmacenTableAdapter
        '
        Me.N_AlmacenTableAdapter.ClearBeforeFill = True
        '
        'CtrlDocProcesados1
        '
        Me.CtrlDocProcesados1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlDocProcesados1.Location = New System.Drawing.Point(646, 19)
        Me.CtrlDocProcesados1.Name = "CtrlDocProcesados1"
        Me.CtrlDocProcesados1.Size = New System.Drawing.Size(154, 119)
        Me.CtrlDocProcesados1.TabIndex = 27
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CtrlPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.N_TicketBindingSource, "ID_Cliente", True))
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(6, 19)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(471, 64)
        Me.CtrlPaciente1.TabIndex = 28
        '
        'grpTodo
        '
        Me.grpTodo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTodo.Controls.Add(Me.CtrlPaciente1)
        Me.grpTodo.Controls.Add(FechaPagadoLabel)
        Me.grpTodo.Controls.Add(Me.FechaPagadoDateTimePicker)
        Me.grpTodo.Controls.Add(PagadoLabel)
        Me.grpTodo.Controls.Add(Me.PagadoCheckBox)
        Me.grpTodo.Controls.Add(Me.lblIva)
        Me.grpTodo.Controls.Add(Me.btn_EmitirCita)
        Me.grpTodo.Controls.Add(Me.btEliminar)
        Me.grpTodo.Controls.Add(Me.btAddLinea)
        Me.grpTodo.Controls.Add(Me.txtInfoIva)
        Me.grpTodo.Controls.Add(FechaLabel)
        Me.grpTodo.Controls.Add(Me.FechaDateTimePicker)
        Me.grpTodo.Controls.Add(TotalLabel)
        Me.grpTodo.Controls.Add(Me.TotalTextBox)
        Me.grpTodo.Controls.Add(ID_FormaPagoLabel)
        Me.grpTodo.Controls.Add(Me.ID_FormaPagoComboBox)
        Me.grpTodo.Controls.Add(Me.N_Ticket_LineasDataGridView)
        Me.grpTodo.Controls.Add(ReferenciaLabel)
        Me.grpTodo.Controls.Add(Me.ReferenciaTextBox)
        Me.grpTodo.Controls.Add(ID_TicketLabel)
        Me.grpTodo.Controls.Add(Me.ID_TicketTextBox)
        Me.grpTodo.Controls.Add(Me.CtrlDocProcesados1)
        Me.grpTodo.Location = New System.Drawing.Point(5, 29)
        Me.grpTodo.Name = "grpTodo"
        Me.grpTodo.Size = New System.Drawing.Size(811, 524)
        Me.grpTodo.TabIndex = 29
        Me.grpTodo.TabStop = False
        '
        'btn_EmitirCita
        '
        Me.btn_EmitirCita.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_EmitirCita.Enabled = False
        Me.btn_EmitirCita.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_EmitirCita.Image = Global.centro_medico.My.Resources.Resources.Citas
        Me.btn_EmitirCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_EmitirCita.Location = New System.Drawing.Point(276, 454)
        Me.btn_EmitirCita.Name = "btn_EmitirCita"
        Me.btn_EmitirCita.Size = New System.Drawing.Size(129, 63)
        Me.btn_EmitirCita.TabIndex = 21
        Me.btn_EmitirCita.Text = "Emitir  Cita"
        Me.btn_EmitirCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EmitirCita.UseVisualStyleBackColor = True
        '
        'CtrlStatusPaciente1
        '
        Me.CtrlStatusPaciente1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlStatusPaciente1.ID_PACIENTE = Nothing
        Me.CtrlStatusPaciente1.Location = New System.Drawing.Point(581, 0)
        Me.CtrlStatusPaciente1.Name = "CtrlStatusPaciente1"
        Me.CtrlStatusPaciente1.Size = New System.Drawing.Size(236, 28)
        Me.CtrlStatusPaciente1.TabIndex = 101
        '
        'frmTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(817, 578)
        Me.Controls.Add(Me.CtrlStatusPaciente1)
        Me.Controls.Add(Me.grpTodo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.KeyPreview = True
        Me.Name = "frmTicket"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TICKET DE VENTA"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_TicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Ticket_LineasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormasPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Ticket_LineasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NTipoIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Almacen_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Ticket_TotalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.N_ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpTodo.ResumeLayout(False)
        Me.grpTodo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents N_TicketBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_TicketTableAdapter As centro_medico.CMDataSetTableAdapters.N_TicketTableAdapter
    Friend WithEvents ID_TicketTextBox As ctrlTextboxAvanzado
    Friend WithEvents ReferenciaTextBox As ctrlTextboxAvanzado
    Friend WithEvents N_Ticket_LineasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Ticket_LineasTableAdapter As centro_medico.CMDataSetTableAdapters.N_Ticket_LineasTableAdapter
    Friend WithEvents ID_FormaPagoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TotalTextBox As ctrlTextboxAvanzado
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents N_Ticket_LineasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents N_Ticket_TotalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Ticket_TotalesTableAdapter As centro_medico.CMDataSetTableAdapters.N_Ticket_TotalesTableAdapter
    Friend WithEvents txtInfoIva As ctrlTextboxAvanzado
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Private WithEvents tlsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents FormasPagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
    Friend WithEvents NTipoIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_TipoIVATableAdapter As centro_medico.CMDataSetTableAdapters.N_TipoIVATableAdapter
    Friend WithEvents btAddLinea As System.Windows.Forms.Button
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents N_ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_ArticulosTableAdapter As centro_medico.CMDataSetTableAdapters.N_ArticulosTableAdapter
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents PagadoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FechaPagadoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Almacen_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_AlmacenTableAdapter As centro_medico.CMDataSetTableAdapters.N_AlmacenTableAdapter
    Friend WithEvents CtrlDocProcesados1 As centro_medico.ctrlDocProcesados
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGuscar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColIdArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDescuento1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDescuento2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDescuento3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTipoIva As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ColIvaIncluido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColIdAlmacen As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents grpTodo As System.Windows.Forms.GroupBox
    Friend WithEvents btn_EmitirCita As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb_DebitoPaciente As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CtrlStatusPaciente1 As centro_medico.ctrlStatusPaciente

End Class
