<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_medicamento
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
        Dim FAVORITOSLabel As System.Windows.Forms.Label
        Dim CANTIDADESLabel As System.Windows.Forms.Label
        Dim POSOLOGIALabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim CMEDICAMENTOLabel As System.Windows.Forms.Label
        Dim INDICACIONLabel1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab_med = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CodigoNacional = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreMedicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Laboratorio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaAutorizacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoPresentacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comercializacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FichaTecnica = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Prospecto = New System.Windows.Forms.DataGridViewLinkColumn
        Me.lblFichaTecnica = New System.Windows.Forms.LinkLabel
        Me.cb_indicaciones = New System.Windows.Forms.ComboBox
        Me.MEDICAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_cod = New ctrlTextboxAvanzado
        Me.tb_descripc = New ctrlTextboxAvanzado
        Me.tb_posologia = New ctrlTextboxAvanzado
        Me.tb_cantidades = New ctrlTextboxAvanzado
        Me.chb_fav = New System.Windows.Forms.CheckBox
        Me.lb_datos = New System.Windows.Forms.Label
        Me.tab_alarmas = New System.Windows.Forms.TabPage
        Me.tb_alarmas = New ctrlTextboxAvanzado
        Me.dgv_alarmas = New System.Windows.Forms.DataGridView
        Me.bt_quitar = New System.Windows.Forms.Button
        Me.bt_agregar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.tab_ind = New System.Windows.Forms.TabPage
        Me.tb_indicaciones = New ctrlTextboxAvanzado
        Me.dgv_indicaciones = New System.Windows.Forms.DataGridView
        Me.bt_delete = New System.Windows.Forms.Button
        Me.bt_add = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.MEDICAMENTOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICAMENTOSTableAdapter
        Me.LINEASALARMAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINEASALARMAMTableAdapter = New centro_medico.CMDataSetTableAdapters.LINEASALARMAMTableAdapter
        Me.LINEASINDICACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINEASINDICACIONESTableAdapter = New centro_medico.CMDataSetTableAdapters.LINEASINDICACIONESTableAdapter
        Me.ALARMASTableAdapter = New centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter
        Me.ALARMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICACIONESTableAdapter = New centro_medico.CMDataSetTableAdapters.INDICACIONESTableAdapter
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New ctrlTextboxAvanzado
        Me.TextBox2 = New ctrlTextboxAvanzado
        Me.TextBox3 = New ctrlTextboxAvanzado
        Me.TextBox4 = New ctrlTextboxAvanzado
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        FAVORITOSLabel = New System.Windows.Forms.Label
        CANTIDADESLabel = New System.Windows.Forms.Label
        POSOLOGIALabel = New System.Windows.Forms.Label
        DESCRIPCIONLabel = New System.Windows.Forms.Label
        CMEDICAMENTOLabel = New System.Windows.Forms.Label
        INDICACIONLabel1 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tab_med.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_alarmas.SuspendLayout()
        CType(Me.dgv_alarmas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_ind.SuspendLayout()
        CType(Me.dgv_indicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASALARMAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASINDICACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FAVORITOSLabel
        '
        FAVORITOSLabel.AutoSize = True
        FAVORITOSLabel.Location = New System.Drawing.Point(272, 119)
        FAVORITOSLabel.Name = "FAVORITOSLabel"
        FAVORITOSLabel.Size = New System.Drawing.Size(53, 13)
        FAVORITOSLabel.TabIndex = 42
        FAVORITOSLabel.Text = "Favoritos:"
        '
        'CANTIDADESLabel
        '
        CANTIDADESLabel.AutoSize = True
        CANTIDADESLabel.Location = New System.Drawing.Point(368, 120)
        CANTIDADESLabel.Name = "CANTIDADESLabel"
        CANTIDADESLabel.Size = New System.Drawing.Size(89, 13)
        CANTIDADESLabel.TabIndex = 38
        CANTIDADESLabel.Text = "Posologia\pesos:"
        '
        'POSOLOGIALabel
        '
        POSOLOGIALabel.AutoSize = True
        POSOLOGIALabel.Location = New System.Drawing.Point(20, 120)
        POSOLOGIALabel.Name = "POSOLOGIALabel"
        POSOLOGIALabel.Size = New System.Drawing.Size(96, 13)
        POSOLOGIALabel.TabIndex = 36
        POSOLOGIALabel.Text = "Posologia habitual:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(169, 37)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(66, 13)
        DESCRIPCIONLabel.TabIndex = 34
        DESCRIPCIONLabel.Text = "Descripcion:"
        '
        'CMEDICAMENTOLabel
        '
        CMEDICAMENTOLabel.AutoSize = True
        CMEDICAMENTOLabel.Location = New System.Drawing.Point(20, 37)
        CMEDICAMENTOLabel.Name = "CMEDICAMENTOLabel"
        CMEDICAMENTOLabel.Size = New System.Drawing.Size(43, 13)
        CMEDICAMENTOLabel.TabIndex = 32
        CMEDICAMENTOLabel.Text = "Codigo:"
        '
        'INDICACIONLabel1
        '
        INDICACIONLabel1.AutoSize = True
        INDICACIONLabel1.Location = New System.Drawing.Point(20, 76)
        INDICACIONLabel1.Name = "INDICACIONLabel1"
        INDICACIONLabel1.Size = New System.Drawing.Size(101, 13)
        INDICACIONLabel1.TabIndex = 43
        INDICACIONLabel1.Text = "Indicacion principal:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(20, 76)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(101, 13)
        Label3.TabIndex = 43
        Label3.Text = "Indicacion principal:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(20, 37)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(43, 13)
        Label4.TabIndex = 32
        Label4.Text = "Codigo:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(169, 37)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(66, 13)
        Label5.TabIndex = 34
        Label5.Text = "Descripcion:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(20, 137)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(96, 13)
        Label6.TabIndex = 36
        Label6.Text = "Posologia habitual:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(204, 137)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(89, 13)
        Label7.TabIndex = 38
        Label7.Text = "Posologia\pesos:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(272, 119)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(53, 13)
        Label8.TabIndex = 42
        Label8.Text = "Favoritos:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_med)
        Me.TabControl1.Controls.Add(Me.tab_alarmas)
        Me.TabControl1.Controls.Add(Me.tab_ind)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(700, 399)
        Me.TabControl1.TabIndex = 0
        '
        'tab_med
        '
        Me.tab_med.AutoScroll = True
        Me.tab_med.Controls.Add(Me.DataGridView1)
        Me.tab_med.Controls.Add(Me.lblFichaTecnica)
        Me.tab_med.Controls.Add(INDICACIONLabel1)
        Me.tab_med.Controls.Add(Me.cb_indicaciones)
        Me.tab_med.Controls.Add(CMEDICAMENTOLabel)
        Me.tab_med.Controls.Add(Me.tb_cod)
        Me.tab_med.Controls.Add(DESCRIPCIONLabel)
        Me.tab_med.Controls.Add(Me.tb_descripc)
        Me.tab_med.Controls.Add(POSOLOGIALabel)
        Me.tab_med.Controls.Add(Me.tb_posologia)
        Me.tab_med.Controls.Add(CANTIDADESLabel)
        Me.tab_med.Controls.Add(Me.tb_cantidades)
        Me.tab_med.Controls.Add(FAVORITOSLabel)
        Me.tab_med.Controls.Add(Me.chb_fav)
        Me.tab_med.Controls.Add(Me.lb_datos)
        Me.tab_med.Location = New System.Drawing.Point(4, 22)
        Me.tab_med.Name = "tab_med"
        Me.tab_med.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_med.Size = New System.Drawing.Size(692, 373)
        Me.tab_med.TabIndex = 0
        Me.tab_med.Text = "Medicamento"
        Me.tab_med.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoNacional, Me.NombreMedicamento, Me.Laboratorio, Me.FechaAutorizacion, Me.EstadoPresentacion, Me.Comercializacion, Me.FichaTecnica, Me.Prospecto})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(24, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(657, 115)
        Me.DataGridView1.TabIndex = 46
        '
        'CodigoNacional
        '
        Me.CodigoNacional.DataPropertyName = "CodigoNacional"
        Me.CodigoNacional.HeaderText = "CodigoNacional"
        Me.CodigoNacional.Name = "CodigoNacional"
        Me.CodigoNacional.ReadOnly = True
        '
        'NombreMedicamento
        '
        Me.NombreMedicamento.DataPropertyName = "NombreMedicamento"
        Me.NombreMedicamento.HeaderText = "Nombre "
        Me.NombreMedicamento.Name = "NombreMedicamento"
        Me.NombreMedicamento.ReadOnly = True
        Me.NombreMedicamento.Width = 200
        '
        'Laboratorio
        '
        Me.Laboratorio.DataPropertyName = "Laboratorio"
        Me.Laboratorio.HeaderText = "Laboratorio"
        Me.Laboratorio.Name = "Laboratorio"
        Me.Laboratorio.ReadOnly = True
        Me.Laboratorio.Width = 150
        '
        'FechaAutorizacion
        '
        Me.FechaAutorizacion.DataPropertyName = "FechaAutorizacion"
        Me.FechaAutorizacion.HeaderText = "FechaAutorizacion"
        Me.FechaAutorizacion.Name = "FechaAutorizacion"
        Me.FechaAutorizacion.ReadOnly = True
        Me.FechaAutorizacion.Visible = False
        '
        'EstadoPresentacion
        '
        Me.EstadoPresentacion.DataPropertyName = "EstadoPresentacion"
        Me.EstadoPresentacion.HeaderText = "EstadoPresentacion"
        Me.EstadoPresentacion.Name = "EstadoPresentacion"
        Me.EstadoPresentacion.ReadOnly = True
        Me.EstadoPresentacion.Visible = False
        '
        'Comercializacion
        '
        Me.Comercializacion.DataPropertyName = "Comercializacion"
        Me.Comercializacion.HeaderText = "Comercializacion"
        Me.Comercializacion.Name = "Comercializacion"
        Me.Comercializacion.ReadOnly = True
        Me.Comercializacion.Visible = False
        '
        'FichaTecnica
        '
        Me.FichaTecnica.DataPropertyName = "FichaTecnica"
        Me.FichaTecnica.HeaderText = "FichaTecnica"
        Me.FichaTecnica.Name = "FichaTecnica"
        Me.FichaTecnica.ReadOnly = True
        Me.FichaTecnica.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FichaTecnica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Prospecto
        '
        Me.Prospecto.DataPropertyName = "Prospecto"
        Me.Prospecto.HeaderText = "Prospecto"
        Me.Prospecto.Name = "Prospecto"
        Me.Prospecto.ReadOnly = True
        Me.Prospecto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Prospecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'lblFichaTecnica
        '
        Me.lblFichaTecnica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFichaTecnica.AutoSize = True
        Me.lblFichaTecnica.Location = New System.Drawing.Point(20, 231)
        Me.lblFichaTecnica.Name = "lblFichaTecnica"
        Me.lblFichaTecnica.Size = New System.Drawing.Size(277, 13)
        Me.lblFichaTecnica.TabIndex = 44
        Me.lblFichaTecnica.TabStop = True
        Me.lblFichaTecnica.Text = "Consultar AGEMED (Agencia española del medicamento)"
        '
        'cb_indicaciones
        '
        Me.cb_indicaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOSBindingSource, "INDICACION", True))
        Me.cb_indicaciones.FormattingEnabled = True
        Me.cb_indicaciones.Location = New System.Drawing.Point(23, 92)
        Me.cb_indicaciones.Name = "cb_indicaciones"
        Me.cb_indicaciones.Size = New System.Drawing.Size(389, 21)
        Me.cb_indicaciones.TabIndex = 7
        '
        'MEDICAMENTOSBindingSource
        '
        Me.MEDICAMENTOSBindingSource.DataMember = "MEDICAMENTOS"
        Me.MEDICAMENTOSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_cod
        '
        Me.tb_cod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOSBindingSource, "CMEDICAMENTO", True))
        Me.tb_cod.Location = New System.Drawing.Point(23, 53)
        Me.tb_cod.MaxLength = 5
        Me.tb_cod.Name = "tb_cod"
        Me.tb_cod.ReadOnly = True
        Me.tb_cod.Size = New System.Drawing.Size(120, 20)
        Me.tb_cod.TabIndex = 5
        '
        'tb_descripc
        '
        Me.tb_descripc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOSBindingSource, "DESCRIPCION", True))
        Me.tb_descripc.Location = New System.Drawing.Point(172, 53)
        Me.tb_descripc.MaxLength = 90
        Me.tb_descripc.Name = "tb_descripc"
        Me.tb_descripc.Size = New System.Drawing.Size(240, 20)
        Me.tb_descripc.TabIndex = 6
        '
        'tb_posologia
        '
        Me.tb_posologia.AcceptsReturn = True
        Me.tb_posologia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_posologia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOSBindingSource, "POSOLOGIA", True))
        Me.tb_posologia.Location = New System.Drawing.Point(23, 141)
        Me.tb_posologia.MaxLength = 150
        Me.tb_posologia.Multiline = True
        Me.tb_posologia.Name = "tb_posologia"
        Me.tb_posologia.Size = New System.Drawing.Size(322, 84)
        Me.tb_posologia.TabIndex = 9
        '
        'tb_cantidades
        '
        Me.tb_cantidades.AcceptsReturn = True
        Me.tb_cantidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_cantidades.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOSBindingSource, "CANTIDADES", True))
        Me.tb_cantidades.Location = New System.Drawing.Point(371, 142)
        Me.tb_cantidades.MaxLength = 150
        Me.tb_cantidades.Multiline = True
        Me.tb_cantidades.Name = "tb_cantidades"
        Me.tb_cantidades.Size = New System.Drawing.Size(310, 83)
        Me.tb_cantidades.TabIndex = 10
        '
        'chb_fav
        '
        Me.chb_fav.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MEDICAMENTOSBindingSource, "FAVORITOS", True))
        Me.chb_fav.Location = New System.Drawing.Point(331, 114)
        Me.chb_fav.Name = "chb_fav"
        Me.chb_fav.Size = New System.Drawing.Size(81, 24)
        Me.chb_fav.TabIndex = 8
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.GhostWhite
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(3, 3)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(678, 19)
        Me.lb_datos.TabIndex = 32
        Me.lb_datos.Text = "Datos del medicamento"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_alarmas
        '
        Me.tab_alarmas.AutoScroll = True
        Me.tab_alarmas.Controls.Add(Me.tb_alarmas)
        Me.tab_alarmas.Controls.Add(Me.dgv_alarmas)
        Me.tab_alarmas.Controls.Add(Me.bt_quitar)
        Me.tab_alarmas.Controls.Add(Me.bt_agregar)
        Me.tab_alarmas.Controls.Add(Me.Label1)
        Me.tab_alarmas.Location = New System.Drawing.Point(4, 22)
        Me.tab_alarmas.Name = "tab_alarmas"
        Me.tab_alarmas.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_alarmas.Size = New System.Drawing.Size(692, 373)
        Me.tab_alarmas.TabIndex = 1
        Me.tab_alarmas.Text = "Alarmas"
        Me.tab_alarmas.UseVisualStyleBackColor = True
        '
        'tb_alarmas
        '
        Me.tb_alarmas.BackColor = System.Drawing.Color.White
        Me.tb_alarmas.Location = New System.Drawing.Point(227, 33)
        Me.tb_alarmas.Multiline = True
        Me.tb_alarmas.Name = "tb_alarmas"
        Me.tb_alarmas.ReadOnly = True
        Me.tb_alarmas.Size = New System.Drawing.Size(189, 234)
        Me.tb_alarmas.TabIndex = 1
        '
        'dgv_alarmas
        '
        Me.dgv_alarmas.AllowUserToAddRows = False
        Me.dgv_alarmas.AllowUserToDeleteRows = False
        Me.dgv_alarmas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_alarmas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_alarmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_alarmas.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_alarmas.Location = New System.Drawing.Point(5, 33)
        Me.dgv_alarmas.Name = "dgv_alarmas"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_alarmas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_alarmas.RowHeadersVisible = False
        Me.dgv_alarmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_alarmas.Size = New System.Drawing.Size(216, 234)
        Me.dgv_alarmas.TabIndex = 0
        '
        'bt_quitar
        '
        Me.bt_quitar.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_quitar.Location = New System.Drawing.Point(186, 273)
        Me.bt_quitar.Name = "bt_quitar"
        Me.bt_quitar.Size = New System.Drawing.Size(35, 23)
        Me.bt_quitar.TabIndex = 3
        Me.bt_quitar.UseVisualStyleBackColor = True
        '
        'bt_agregar
        '
        Me.bt_agregar.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_agregar.Location = New System.Drawing.Point(145, 273)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(35, 23)
        Me.bt_agregar.TabIndex = 2
        Me.bt_agregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Alarmas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_ind
        '
        Me.tab_ind.Controls.Add(Me.tb_indicaciones)
        Me.tab_ind.Controls.Add(Me.dgv_indicaciones)
        Me.tab_ind.Controls.Add(Me.bt_delete)
        Me.tab_ind.Controls.Add(Me.bt_add)
        Me.tab_ind.Controls.Add(Me.Label2)
        Me.tab_ind.Location = New System.Drawing.Point(4, 22)
        Me.tab_ind.Name = "tab_ind"
        Me.tab_ind.Size = New System.Drawing.Size(692, 373)
        Me.tab_ind.TabIndex = 2
        Me.tab_ind.Text = "Indicaciones"
        Me.tab_ind.UseVisualStyleBackColor = True
        '
        'tb_indicaciones
        '
        Me.tb_indicaciones.BackColor = System.Drawing.Color.White
        Me.tb_indicaciones.Location = New System.Drawing.Point(232, 33)
        Me.tb_indicaciones.Multiline = True
        Me.tb_indicaciones.Name = "tb_indicaciones"
        Me.tb_indicaciones.ReadOnly = True
        Me.tb_indicaciones.Size = New System.Drawing.Size(185, 234)
        Me.tb_indicaciones.TabIndex = 1
        '
        'dgv_indicaciones
        '
        Me.dgv_indicaciones.AllowUserToAddRows = False
        Me.dgv_indicaciones.AllowUserToDeleteRows = False
        Me.dgv_indicaciones.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_indicaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_indicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_indicaciones.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_indicaciones.Location = New System.Drawing.Point(5, 33)
        Me.dgv_indicaciones.Name = "dgv_indicaciones"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_indicaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_indicaciones.RowHeadersVisible = False
        Me.dgv_indicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_indicaciones.Size = New System.Drawing.Size(221, 234)
        Me.dgv_indicaciones.TabIndex = 0
        '
        'bt_delete
        '
        Me.bt_delete.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_delete.Location = New System.Drawing.Point(190, 273)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(35, 23)
        Me.bt_delete.TabIndex = 3
        Me.bt_delete.UseVisualStyleBackColor = True
        '
        'bt_add
        '
        Me.bt_add.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_add.Location = New System.Drawing.Point(149, 273)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(35, 23)
        Me.bt_add.TabIndex = 2
        Me.bt_add.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(428, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Indicaciones"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_cancel
        '
        Me.bt_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(355, 410)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 2
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(274, 410)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 1
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'MEDICAMENTOSTableAdapter
        '
        Me.MEDICAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'LINEASALARMAMBindingSource
        '
        Me.LINEASALARMAMBindingSource.DataMember = "LINEASALARMAM"
        Me.LINEASALARMAMBindingSource.DataSource = Me.CMDataSet
        '
        'LINEASALARMAMTableAdapter
        '
        Me.LINEASALARMAMTableAdapter.ClearBeforeFill = True
        '
        'LINEASINDICACIONESBindingSource
        '
        Me.LINEASINDICACIONESBindingSource.DataMember = "LINEASINDICACIONES"
        Me.LINEASINDICACIONESBindingSource.DataSource = Me.CMDataSet
        '
        'LINEASINDICACIONESTableAdapter
        '
        Me.LINEASINDICACIONESTableAdapter.ClearBeforeFill = True
        '
        'ALARMASTableAdapter
        '
        Me.ALARMASTableAdapter.ClearBeforeFill = True
        '
        'ALARMASBindingSource
        '
        Me.ALARMASBindingSource.DataMember = "ALARMAS"
        Me.ALARMASBindingSource.DataSource = Me.CMDataSet
        '
        'INDICACIONESBindingSource
        '
        Me.INDICACIONESBindingSource.DataMember = "INDICACIONES"
        Me.INDICACIONESBindingSource.DataSource = Me.CMDataSet
        '
        'INDICACIONESTableAdapter
        '
        Me.INDICACIONESTableAdapter.ClearBeforeFill = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(23, 117)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(94, 13)
        Me.LinkLabel1.TabIndex = 44
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver Ficha Técnica"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOSBindingSource, "INDICACION", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(23, 92)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(389, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOSBindingSource, "CMEDICAMENTO", True))
        Me.TextBox1.Location = New System.Drawing.Point(23, 53)
        Me.TextBox1.MaxLength = 5
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOSBindingSource, "DESCRIPCION", True))
        Me.TextBox2.Location = New System.Drawing.Point(172, 53)
        Me.TextBox2.MaxLength = 90
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOSBindingSource, "POSOLOGIA", True))
        Me.TextBox3.Location = New System.Drawing.Point(23, 152)
        Me.TextBox3.MaxLength = 150
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(178, 170)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOSBindingSource, "CANTIDADES", True))
        Me.TextBox4.Location = New System.Drawing.Point(207, 153)
        Me.TextBox4.MaxLength = 150
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(205, 169)
        Me.TextBox4.TabIndex = 10
        '
        'CheckBox1
        '
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MEDICAMENTOSBindingSource, "FAVORITOS", True))
        Me.CheckBox1.Location = New System.Drawing.Point(331, 114)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 24)
        Me.CheckBox1.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(413, 19)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Datos del historial"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'form_medicamento
        '
        Me.AcceptButton = Me.bt_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancel
        Me.ClientSize = New System.Drawing.Size(712, 450)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "form_medicamento"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_medicamento"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_med.ResumeLayout(False)
        Me.tab_med.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_alarmas.ResumeLayout(False)
        Me.tab_alarmas.PerformLayout()
        CType(Me.dgv_alarmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_ind.ResumeLayout(False)
        Me.tab_ind.PerformLayout()
        CType(Me.dgv_indicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASALARMAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASINDICACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_alarmas As System.Windows.Forms.TabPage
    Friend WithEvents tab_ind As System.Windows.Forms.TabPage
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents MEDICAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICAMENTOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICAMENTOSTableAdapter
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_indicaciones As System.Windows.Forms.DataGridView
    Friend WithEvents bt_delete As System.Windows.Forms.Button
    Friend WithEvents bt_add As System.Windows.Forms.Button
    Friend WithEvents dgv_alarmas As System.Windows.Forms.DataGridView
    Friend WithEvents bt_quitar As System.Windows.Forms.Button
    Friend WithEvents bt_agregar As System.Windows.Forms.Button
    Friend WithEvents LINEASALARMAMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEASALARMAMTableAdapter As centro_medico.CMDataSetTableAdapters.LINEASALARMAMTableAdapter
    Friend WithEvents LINEASINDICACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEASINDICACIONESTableAdapter As centro_medico.CMDataSetTableAdapters.LINEASINDICACIONESTableAdapter
    Friend WithEvents ALARMASTableAdapter As centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter
    Friend WithEvents ALARMASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INDICACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INDICACIONESTableAdapter As centro_medico.CMDataSetTableAdapters.INDICACIONESTableAdapter
    Friend WithEvents tb_indicaciones As ctrlTextboxAvanzado
    Friend WithEvents tb_alarmas As ctrlTextboxAvanzado
    Friend WithEvents tab_med As System.Windows.Forms.TabPage
    Friend WithEvents lblFichaTecnica As System.Windows.Forms.LinkLabel
    Friend WithEvents cb_indicaciones As System.Windows.Forms.ComboBox
    Friend WithEvents tb_cod As ctrlTextboxAvanzado
    Friend WithEvents tb_descripc As ctrlTextboxAvanzado
    Friend WithEvents tb_posologia As ctrlTextboxAvanzado
    Friend WithEvents tb_cantidades As ctrlTextboxAvanzado
    Friend WithEvents chb_fav As System.Windows.Forms.CheckBox
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As ctrlTextboxAvanzado
    Friend WithEvents TextBox2 As ctrlTextboxAvanzado
    Friend WithEvents TextBox3 As ctrlTextboxAvanzado
    Friend WithEvents TextBox4 As ctrlTextboxAvanzado
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoNacional As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreMedicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Laboratorio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAutorizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoPresentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comercializacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FichaTecnica As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Prospecto As System.Windows.Forms.DataGridViewLinkColumn
End Class
