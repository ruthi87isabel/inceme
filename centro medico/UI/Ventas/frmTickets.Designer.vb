<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTickets
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.CM2DataSet = New centro_medico.CM2DataSet()
        Me.ListadoTicketsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListadoTicketsTableAdapter = New centro_medico.CM2DataSetTableAdapters.ListadoTicketsTableAdapter()
        Me.ListadoTicketsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnFechaPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tst_Total = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tst_TotalSeleccionado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dt_FC_Ini = New System.Windows.Forms.DateTimePicker()
        Me.dt_FC_Fin = New System.Windows.Forms.DateTimePicker()
        Me.bt_Filtrar = New System.Windows.Forms.Button()
        Me.grp_FechaCreacion = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_FechaCreacion = New System.Windows.Forms.CheckBox()
        Me.chk_FechaPagado = New System.Windows.Forms.CheckBox()
        Me.grp_FechaPagado = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_FP_Ini = New System.Windows.Forms.DateTimePicker()
        Me.dt_FP_Fin = New System.Windows.Forms.DateTimePicker()
        Me.grp_Pagados = New System.Windows.Forms.GroupBox()
        Me.rb_Sinpagar = New System.Windows.Forms.RadioButton()
        Me.rb_Pagados = New System.Windows.Forms.RadioButton()
        Me.rb_Todos = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CM2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoTicketsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoTicketsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.grp_FechaCreacion.SuspendLayout()
        Me.grp_FechaPagado.SuspendLayout()
        Me.grp_Pagados.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(852, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.tst_Eliminar.Size = New System.Drawing.Size(102, 22)
        Me.tst_Eliminar.Text = "&Eliminar ticket"
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
        'CM2DataSet
        '
        Me.CM2DataSet.DataSetName = "CM2DataSet"
        Me.CM2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListadoTicketsBindingSource
        '
        Me.ListadoTicketsBindingSource.DataMember = "ListadoTickets"
        Me.ListadoTicketsBindingSource.DataSource = Me.CM2DataSet
        '
        'ListadoTicketsTableAdapter
        '
        Me.ListadoTicketsTableAdapter.ClearBeforeFill = True
        '
        'ListadoTicketsDataGridView
        '
        Me.ListadoTicketsDataGridView.AllowUserToAddRows = False
        Me.ListadoTicketsDataGridView.AllowUserToDeleteRows = False
        Me.ListadoTicketsDataGridView.AllowUserToResizeRows = False
        Me.ListadoTicketsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoTicketsDataGridView.AutoGenerateColumns = False
        Me.ListadoTicketsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoTicketsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ListadoTicketsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn6, Me.PagadoColumn, Me.ColumnFechaPagado, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.ListadoTicketsDataGridView.DataSource = Me.ListadoTicketsBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListadoTicketsDataGridView.DefaultCellStyle = DataGridViewCellStyle7
        Me.ListadoTicketsDataGridView.Location = New System.Drawing.Point(0, 141)
        Me.ListadoTicketsDataGridView.MultiSelect = False
        Me.ListadoTicketsDataGridView.Name = "ListadoTicketsDataGridView"
        Me.ListadoTicketsDataGridView.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoTicketsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ListadoTicketsDataGridView.RowHeadersVisible = False
        Me.ListadoTicketsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListadoTicketsDataGridView.Size = New System.Drawing.Size(852, 430)
        Me.ListadoTicketsDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Ticket"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod Ticket"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 84
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_TipoTicket"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID_TipoTicket"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Referencia"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 84
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID_Estado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID_Estado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID_Cliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cod Paciente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 96
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NombrePaciente"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nombre Paciente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ID_FormaPago"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cod Forma Pago"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FormaPago"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Forma Pago"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 89
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 62
        '
        'PagadoColumn
        '
        Me.PagadoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PagadoColumn.DataPropertyName = "Pagado"
        Me.PagadoColumn.HeaderText = "Pagado"
        Me.PagadoColumn.Name = "PagadoColumn"
        Me.PagadoColumn.ReadOnly = True
        Me.PagadoColumn.Width = 50
        '
        'ColumnFechaPagado
        '
        Me.ColumnFechaPagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ColumnFechaPagado.DataPropertyName = "FechaPagado"
        Me.ColumnFechaPagado.HeaderText = "Fecha Pagado"
        Me.ColumnFechaPagado.Name = "ColumnFechaPagado"
        Me.ColumnFechaPagado.ReadOnly = True
        Me.ColumnFechaPagado.Width = 102
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Total"
        DataGridViewCellStyle6.Format = "C2"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn12.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 56
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PlazoEntrega"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PlazoEntrega"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "IRPFPorciento"
        Me.DataGridViewTextBoxColumn15.HeaderText = "IRPFPorciento"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "IRPFCantidad"
        Me.DataGridViewTextBoxColumn16.HeaderText = "IRPFCantidad"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Validez"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Validez"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "PortePagado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "PortePagado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "PorteDebido"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "PorteDebido"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PorteTexto"
        Me.DataGridViewTextBoxColumn18.HeaderText = "PorteTexto"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Privado"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Privado"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DocumentacionAsociada"
        Me.DataGridViewTextBoxColumn20.HeaderText = "DocumentacionAsociada"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Comentarios"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Comentarios"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_Total, Me.ToolStripStatusLabel2, Me.tst_TotalSeleccionado, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 574)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(852, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tst_Total
        '
        Me.tst_Total.Name = "tst_Total"
        Me.tst_Total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tst_Total.Size = New System.Drawing.Size(46, 17)
        Me.tst_Total.Text = "Total: 0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(94, 17)
        Me.ToolStripStatusLabel2.Text = "                             "
        '
        'tst_TotalSeleccionado
        '
        Me.tst_TotalSeleccionado.Name = "tst_TotalSeleccionado"
        Me.tst_TotalSeleccionado.RightToLeft = System.Windows.Forms.RightToLeft.No
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
        'dt_FC_Ini
        '
        Me.dt_FC_Ini.Checked = False
        Me.dt_FC_Ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_FC_Ini.Location = New System.Drawing.Point(51, 16)
        Me.dt_FC_Ini.Name = "dt_FC_Ini"
        Me.dt_FC_Ini.Size = New System.Drawing.Size(90, 20)
        Me.dt_FC_Ini.TabIndex = 13
        '
        'dt_FC_Fin
        '
        Me.dt_FC_Fin.Checked = False
        Me.dt_FC_Fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_FC_Fin.Location = New System.Drawing.Point(51, 41)
        Me.dt_FC_Fin.Name = "dt_FC_Fin"
        Me.dt_FC_Fin.Size = New System.Drawing.Size(90, 20)
        Me.dt_FC_Fin.TabIndex = 14
        '
        'bt_Filtrar
        '
        Me.bt_Filtrar.Location = New System.Drawing.Point(765, 97)
        Me.bt_Filtrar.Name = "bt_Filtrar"
        Me.bt_Filtrar.Size = New System.Drawing.Size(75, 39)
        Me.bt_Filtrar.TabIndex = 16
        Me.bt_Filtrar.Text = "Filtrar"
        Me.bt_Filtrar.UseVisualStyleBackColor = True
        '
        'grp_FechaCreacion
        '
        Me.grp_FechaCreacion.Controls.Add(Me.Label2)
        Me.grp_FechaCreacion.Controls.Add(Me.Label1)
        Me.grp_FechaCreacion.Controls.Add(Me.dt_FC_Ini)
        Me.grp_FechaCreacion.Controls.Add(Me.dt_FC_Fin)
        Me.grp_FechaCreacion.Enabled = False
        Me.grp_FechaCreacion.Location = New System.Drawing.Point(445, 67)
        Me.grp_FechaCreacion.Name = "grp_FechaCreacion"
        Me.grp_FechaCreacion.Size = New System.Drawing.Size(151, 70)
        Me.grp_FechaCreacion.TabIndex = 17
        Me.grp_FechaCreacion.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Desde"
        '
        'chk_FechaCreacion
        '
        Me.chk_FechaCreacion.AutoSize = True
        Me.chk_FechaCreacion.Location = New System.Drawing.Point(447, 54)
        Me.chk_FechaCreacion.Name = "chk_FechaCreacion"
        Me.chk_FechaCreacion.Size = New System.Drawing.Size(101, 17)
        Me.chk_FechaCreacion.TabIndex = 18
        Me.chk_FechaCreacion.Text = "Fecha Creación"
        Me.chk_FechaCreacion.UseVisualStyleBackColor = True
        '
        'chk_FechaPagado
        '
        Me.chk_FechaPagado.AutoSize = True
        Me.chk_FechaPagado.Location = New System.Drawing.Point(605, 54)
        Me.chk_FechaPagado.Name = "chk_FechaPagado"
        Me.chk_FechaPagado.Size = New System.Drawing.Size(96, 17)
        Me.chk_FechaPagado.TabIndex = 20
        Me.chk_FechaPagado.Text = "Fecha Pagado"
        Me.chk_FechaPagado.UseVisualStyleBackColor = True
        '
        'grp_FechaPagado
        '
        Me.grp_FechaPagado.Controls.Add(Me.Label3)
        Me.grp_FechaPagado.Controls.Add(Me.Label4)
        Me.grp_FechaPagado.Controls.Add(Me.dt_FP_Ini)
        Me.grp_FechaPagado.Controls.Add(Me.dt_FP_Fin)
        Me.grp_FechaPagado.Enabled = False
        Me.grp_FechaPagado.Location = New System.Drawing.Point(603, 67)
        Me.grp_FechaPagado.Name = "grp_FechaPagado"
        Me.grp_FechaPagado.Size = New System.Drawing.Size(147, 70)
        Me.grp_FechaPagado.TabIndex = 19
        Me.grp_FechaPagado.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Desde"
        '
        'dt_FP_Ini
        '
        Me.dt_FP_Ini.Checked = False
        Me.dt_FP_Ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_FP_Ini.Location = New System.Drawing.Point(48, 16)
        Me.dt_FP_Ini.Name = "dt_FP_Ini"
        Me.dt_FP_Ini.Size = New System.Drawing.Size(90, 20)
        Me.dt_FP_Ini.TabIndex = 13
        '
        'dt_FP_Fin
        '
        Me.dt_FP_Fin.Checked = False
        Me.dt_FP_Fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_FP_Fin.Location = New System.Drawing.Point(48, 41)
        Me.dt_FP_Fin.Name = "dt_FP_Fin"
        Me.dt_FP_Fin.Size = New System.Drawing.Size(90, 20)
        Me.dt_FP_Fin.TabIndex = 14
        '
        'grp_Pagados
        '
        Me.grp_Pagados.Controls.Add(Me.rb_Sinpagar)
        Me.grp_Pagados.Controls.Add(Me.rb_Pagados)
        Me.grp_Pagados.Controls.Add(Me.rb_Todos)
        Me.grp_Pagados.Location = New System.Drawing.Point(53, 100)
        Me.grp_Pagados.Name = "grp_Pagados"
        Me.grp_Pagados.Size = New System.Drawing.Size(231, 35)
        Me.grp_Pagados.TabIndex = 23
        Me.grp_Pagados.TabStop = False
        '
        'rb_Sinpagar
        '
        Me.rb_Sinpagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rb_Sinpagar.AutoSize = True
        Me.rb_Sinpagar.Location = New System.Drawing.Point(140, 13)
        Me.rb_Sinpagar.Name = "rb_Sinpagar"
        Me.rb_Sinpagar.Size = New System.Drawing.Size(70, 17)
        Me.rb_Sinpagar.TabIndex = 0
        Me.rb_Sinpagar.Text = "Sin pagar"
        Me.rb_Sinpagar.UseVisualStyleBackColor = True
        '
        'rb_Pagados
        '
        Me.rb_Pagados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rb_Pagados.AutoSize = True
        Me.rb_Pagados.Location = New System.Drawing.Point(67, 13)
        Me.rb_Pagados.Name = "rb_Pagados"
        Me.rb_Pagados.Size = New System.Drawing.Size(67, 17)
        Me.rb_Pagados.TabIndex = 0
        Me.rb_Pagados.Text = "Pagados"
        Me.rb_Pagados.UseVisualStyleBackColor = True
        '
        'rb_Todos
        '
        Me.rb_Todos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rb_Todos.AutoSize = True
        Me.rb_Todos.Checked = True
        Me.rb_Todos.Location = New System.Drawing.Point(6, 13)
        Me.rb_Todos.Name = "rb_Todos"
        Me.rb_Todos.Size = New System.Drawing.Size(55, 17)
        Me.rb_Todos.TabIndex = 0
        Me.rb_Todos.TabStop = True
        Me.rb_Todos.Text = "Todos"
        Me.rb_Todos.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Pago"
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(8, 38)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(425, 53)
        Me.CtrlPaciente1.TabIndex = 25
        '
        'frmTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 596)
        Me.Controls.Add(Me.CtrlPaciente1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grp_Pagados)
        Me.Controls.Add(Me.chk_FechaPagado)
        Me.Controls.Add(Me.grp_FechaPagado)
        Me.Controls.Add(Me.chk_FechaCreacion)
        Me.Controls.Add(Me.grp_FechaCreacion)
        Me.Controls.Add(Me.bt_Filtrar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListadoTicketsDataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmTickets"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Tickets"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CM2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoTicketsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoTicketsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grp_FechaCreacion.ResumeLayout(False)
        Me.grp_FechaCreacion.PerformLayout()
        Me.grp_FechaPagado.ResumeLayout(False)
        Me.grp_FechaPagado.PerformLayout()
        Me.grp_Pagados.ResumeLayout(False)
        Me.grp_Pagados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CM2DataSet As centro_medico.CM2DataSet
    Friend WithEvents ListadoTicketsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListadoTicketsTableAdapter As centro_medico.CM2DataSetTableAdapters.ListadoTicketsTableAdapter
    Friend WithEvents ListadoTicketsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tst_TotalSeleccionado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tst_Total As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dt_FC_Ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_FC_Fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_Filtrar As System.Windows.Forms.Button
    Friend WithEvents grp_FechaCreacion As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_FechaCreacion As System.Windows.Forms.CheckBox
    Friend WithEvents chk_FechaPagado As System.Windows.Forms.CheckBox
    Friend WithEvents grp_FechaPagado As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_FP_Ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_FP_Fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp_Pagados As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Sinpagar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Pagados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagadoColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColumnFechaPagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
End Class
