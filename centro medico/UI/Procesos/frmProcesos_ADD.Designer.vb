<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesos_ADD
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
        Dim ID_ProcesoLabel As System.Windows.Forms.Label
        Dim FechaInicioLabel As System.Windows.Forms.Label
        Dim FechaFinalLabel As System.Windows.Forms.Label
        Dim FinalizadoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcesos_ADD))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ID_ProcesoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.N_ProcesosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CM3DataSet = New centro_medico.CM3DataSet()
        Me.FechaInicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaFinalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FinalizadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MUTUASComboBox = New System.Windows.Forms.ComboBox()
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.EMPRESASComboBox = New System.Windows.Forms.ComboBox()
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Asistente_Facturacion = New System.Windows.Forms.Button()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.bt_Partes_Add = New System.Windows.Forms.Button()
        Me.bt_Partes_Edit = New System.Windows.Forms.Button()
        Me.bt_Partes_Delete = New System.Windows.Forms.Button()
        Me.grpPartes = New System.Windows.Forms.GroupBox()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.N_PartesPorProcesoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CM3DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Cita_ADD = New System.Windows.Forms.Button()
        Me.btn_Cita_Edit = New System.Windows.Forms.Button()
        Me.btn_Cita_Eliminar = New System.Windows.Forms.Button()
        Me.grpCitas = New System.Windows.Forms.GroupBox()
        Me.CITASDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCitaFacturada = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CITASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Facturas_Add = New System.Windows.Forms.Button()
        Me.btn_Factura_Edit = New System.Windows.Forms.Button()
        Me.btn_Factura_Del = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FACTURASDataGridView = New System.Windows.Forms.DataGridView()
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ts_Guardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CtrlFicherosAdjuntos1 = New centro_medico.ctrlFicherosAdjuntos()
        Me.CITASTableAdapter = New centro_medico.CMDataSetTableAdapters.CITASTableAdapter()
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter()
        Me.N_ProcesosTableAdapter = New centro_medico.CM3DataSetTableAdapters.N_ProcesosTableAdapter()
        Me.N_PartesPorProcesoTableAdapter = New centro_medico.CM3DataSetTableAdapters.N_PartesPorProcesoTableAdapter()
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter()
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter()
        Me.btn_ParteAsistencia_ADD = New System.Windows.Forms.Button()
        Me.NPartesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_PartesTableAdapter = New centro_medico.CM3DataSetTableAdapters.N_PartesTableAdapter()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAENVIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGADA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ID_ProcesoLabel = New System.Windows.Forms.Label()
        FechaInicioLabel = New System.Windows.Forms.Label()
        FechaFinalLabel = New System.Windows.Forms.Label()
        FinalizadoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.N_ProcesosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPartes.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_PartesPorProcesoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM3DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCitas.SuspendLayout()
        CType(Me.CITASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FACTURASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NPartesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_ProcesoLabel
        '
        ID_ProcesoLabel.AutoSize = True
        ID_ProcesoLabel.Location = New System.Drawing.Point(20, 22)
        ID_ProcesoLabel.Name = "ID_ProcesoLabel"
        ID_ProcesoLabel.Size = New System.Drawing.Size(43, 13)
        ID_ProcesoLabel.TabIndex = 1
        ID_ProcesoLabel.Text = "Código:"
        '
        'FechaInicioLabel
        '
        FechaInicioLabel.AutoSize = True
        FechaInicioLabel.Location = New System.Drawing.Point(436, 22)
        FechaInicioLabel.Name = "FechaInicioLabel"
        FechaInicioLabel.Size = New System.Drawing.Size(68, 13)
        FechaInicioLabel.TabIndex = 5
        FechaInicioLabel.Text = "Fecha Inicio:"
        '
        'FechaFinalLabel
        '
        FechaFinalLabel.AutoSize = True
        FechaFinalLabel.Location = New System.Drawing.Point(550, 22)
        FechaFinalLabel.Name = "FechaFinalLabel"
        FechaFinalLabel.Size = New System.Drawing.Size(65, 13)
        FechaFinalLabel.TabIndex = 7
        FechaFinalLabel.Text = "Fecha Final:"
        '
        'FinalizadoLabel
        '
        FinalizadoLabel.AutoSize = True
        FinalizadoLabel.Location = New System.Drawing.Point(435, 69)
        FinalizadoLabel.Name = "FinalizadoLabel"
        FinalizadoLabel.Size = New System.Drawing.Size(57, 13)
        FinalizadoLabel.TabIndex = 9
        FinalizadoLabel.Text = "Finalizado:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 119)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 13)
        Label1.TabIndex = 1
        Label1.Text = "Empresa:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(18, 149)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(45, 13)
        Label2.TabIndex = 1
        Label2.Text = "Mutuas:"
        '
        'ID_ProcesoTextBox
        '
        Me.ID_ProcesoTextBox.AcceptsReturn = True
        Me.ID_ProcesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProcesosBindingSource, "ID_Proceso", True))
        Me.ID_ProcesoTextBox.Location = New System.Drawing.Point(69, 19)
        Me.ID_ProcesoTextBox.Name = "ID_ProcesoTextBox"
        Me.ID_ProcesoTextBox.ReadOnly = True
        Me.ID_ProcesoTextBox.Size = New System.Drawing.Size(55, 20)
        Me.ID_ProcesoTextBox.TabIndex = 2
        '
        'N_ProcesosBindingSource
        '
        Me.N_ProcesosBindingSource.DataMember = "N_Procesos"
        Me.N_ProcesosBindingSource.DataSource = Me.CM3DataSet
        '
        'CM3DataSet
        '
        Me.CM3DataSet.DataSetName = "CM3DataSet"
        Me.CM3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FechaInicioDateTimePicker
        '
        Me.FechaInicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_ProcesosBindingSource, "FechaInicio", True))
        Me.FechaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicioDateTimePicker.Location = New System.Drawing.Point(439, 39)
        Me.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker"
        Me.FechaInicioDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechaInicioDateTimePicker.TabIndex = 6
        '
        'FechaFinalDateTimePicker
        '
        Me.FechaFinalDateTimePicker.Checked = False
        Me.FechaFinalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_ProcesosBindingSource, "FechaFinal", True))
        Me.FechaFinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFinalDateTimePicker.Location = New System.Drawing.Point(553, 38)
        Me.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker"
        Me.FechaFinalDateTimePicker.ShowCheckBox = True
        Me.FechaFinalDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechaFinalDateTimePicker.TabIndex = 8
        '
        'FinalizadoCheckBox
        '
        Me.FinalizadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_ProcesosBindingSource, "Finalizado", True))
        Me.FinalizadoCheckBox.Location = New System.Drawing.Point(498, 64)
        Me.FinalizadoCheckBox.Name = "FinalizadoCheckBox"
        Me.FinalizadoCheckBox.Size = New System.Drawing.Size(29, 24)
        Me.FinalizadoCheckBox.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MUTUASComboBox)
        Me.GroupBox1.Controls.Add(Me.EMPRESASComboBox)
        Me.GroupBox1.Controls.Add(Me.btn_Asistente_Facturacion)
        Me.GroupBox1.Controls.Add(Me.CtrlPaciente1)
        Me.GroupBox1.Controls.Add(FinalizadoLabel)
        Me.GroupBox1.Controls.Add(FechaInicioLabel)
        Me.GroupBox1.Controls.Add(Me.FinalizadoCheckBox)
        Me.GroupBox1.Controls.Add(Me.ID_ProcesoTextBox)
        Me.GroupBox1.Controls.Add(Me.FechaInicioDateTimePicker)
        Me.GroupBox1.Controls.Add(FechaFinalLabel)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(ID_ProcesoLabel)
        Me.GroupBox1.Controls.Add(Me.FechaFinalDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 174)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'MUTUASComboBox
        '
        Me.MUTUASComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_ProcesosBindingSource, "ID_Mutua", True))
        Me.MUTUASComboBox.DataSource = Me.MUTUASBindingSource
        Me.MUTUASComboBox.DisplayMember = "NOMBRE"
        Me.MUTUASComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MUTUASComboBox.Location = New System.Drawing.Point(69, 145)
        Me.MUTUASComboBox.Name = "MUTUASComboBox"
        Me.MUTUASComboBox.Size = New System.Drawing.Size(241, 21)
        Me.MUTUASComboBox.TabIndex = 18
        Me.MUTUASComboBox.ValueMember = "CMUTUA"
        '
        'MUTUASBindingSource
        '
        Me.MUTUASBindingSource.DataMember = "MUTUAS"
        Me.MUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPRESASComboBox
        '
        Me.EMPRESASComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_ProcesosBindingSource, "ID_Empresa", True))
        Me.EMPRESASComboBox.DataSource = Me.EMPRESASBindingSource
        Me.EMPRESASComboBox.DisplayMember = "NOMBRE"
        Me.EMPRESASComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EMPRESASComboBox.Location = New System.Drawing.Point(69, 116)
        Me.EMPRESASComboBox.Name = "EMPRESASComboBox"
        Me.EMPRESASComboBox.Size = New System.Drawing.Size(241, 21)
        Me.EMPRESASComboBox.TabIndex = 18
        Me.EMPRESASComboBox.ValueMember = "CEMPRESA"
        '
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'btn_Asistente_Facturacion
        '
        Me.btn_Asistente_Facturacion.Location = New System.Drawing.Point(438, 119)
        Me.btn_Asistente_Facturacion.Name = "btn_Asistente_Facturacion"
        Me.btn_Asistente_Facturacion.Size = New System.Drawing.Size(148, 37)
        Me.btn_Asistente_Facturacion.TabIndex = 18
        Me.btn_Asistente_Facturacion.Text = "Asistente de Facturación"
        Me.btn_Asistente_Facturacion.UseVisualStyleBackColor = True
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.N_ProcesosBindingSource, "ID_Paciente", True))
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(18, 46)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(385, 52)
        Me.CtrlPaciente1.TabIndex = 18
        '
        'bt_Partes_Add
        '
        Me.bt_Partes_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_Partes_Add.FlatAppearance.BorderSize = 0
        Me.bt_Partes_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Partes_Add.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.bt_Partes_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Partes_Add.Location = New System.Drawing.Point(4, 530)
        Me.bt_Partes_Add.Name = "bt_Partes_Add"
        Me.bt_Partes_Add.Size = New System.Drawing.Size(113, 24)
        Me.bt_Partes_Add.TabIndex = 0
        Me.bt_Partes_Add.Text = "Parte Baja/Alta"
        Me.bt_Partes_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Partes_Add.UseVisualStyleBackColor = True
        '
        'bt_Partes_Edit
        '
        Me.bt_Partes_Edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_Partes_Edit.Enabled = False
        Me.bt_Partes_Edit.FlatAppearance.BorderSize = 0
        Me.bt_Partes_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Partes_Edit.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.bt_Partes_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Partes_Edit.Location = New System.Drawing.Point(139, 531)
        Me.bt_Partes_Edit.Name = "bt_Partes_Edit"
        Me.bt_Partes_Edit.Size = New System.Drawing.Size(113, 23)
        Me.bt_Partes_Edit.TabIndex = 0
        Me.bt_Partes_Edit.Text = "Modificar parte"
        Me.bt_Partes_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Partes_Edit.UseVisualStyleBackColor = True
        '
        'bt_Partes_Delete
        '
        Me.bt_Partes_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_Partes_Delete.Enabled = False
        Me.bt_Partes_Delete.FlatAppearance.BorderSize = 0
        Me.bt_Partes_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Partes_Delete.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.bt_Partes_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Partes_Delete.Location = New System.Drawing.Point(248, 530)
        Me.bt_Partes_Delete.Name = "bt_Partes_Delete"
        Me.bt_Partes_Delete.Size = New System.Drawing.Size(78, 24)
        Me.bt_Partes_Delete.TabIndex = 0
        Me.bt_Partes_Delete.Text = "Eliminar"
        Me.bt_Partes_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Partes_Delete.UseVisualStyleBackColor = True
        '
        'grpPartes
        '
        Me.grpPartes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpPartes.Controls.Add(Me.GridEX1)
        Me.grpPartes.Location = New System.Drawing.Point(5, 206)
        Me.grpPartes.Name = "grpPartes"
        Me.grpPartes.Size = New System.Drawing.Size(336, 319)
        Me.grpPartes.TabIndex = 18
        Me.grpPartes.TabStop = False
        Me.grpPartes.Text = "PARTES"
        '
        'GridEX1
        '
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.DataSource = Me.N_PartesPorProcesoBindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(12, 19)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(309, 288)
        Me.GridEX1.TabIndex = 1
        '
        'N_PartesPorProcesoBindingSource
        '
        Me.N_PartesPorProcesoBindingSource.DataMember = "N_PartesPorProceso"
        Me.N_PartesPorProcesoBindingSource.DataSource = Me.CM3DataSet
        '
        'CM3DataSetBindingSource
        '
        Me.CM3DataSetBindingSource.DataSource = Me.CM3DataSet
        Me.CM3DataSetBindingSource.Position = 0
        '
        'btn_Cita_ADD
        '
        Me.btn_Cita_ADD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cita_ADD.FlatAppearance.BorderSize = 0
        Me.btn_Cita_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cita_ADD.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btn_Cita_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cita_ADD.Location = New System.Drawing.Point(358, 527)
        Me.btn_Cita_ADD.Name = "btn_Cita_ADD"
        Me.btn_Cita_ADD.Size = New System.Drawing.Size(92, 24)
        Me.btn_Cita_ADD.TabIndex = 0
        Me.btn_Cita_ADD.Text = "Nueva cita"
        Me.btn_Cita_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cita_ADD.UseVisualStyleBackColor = True
        '
        'btn_Cita_Edit
        '
        Me.btn_Cita_Edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cita_Edit.Enabled = False
        Me.btn_Cita_Edit.FlatAppearance.BorderSize = 0
        Me.btn_Cita_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cita_Edit.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.btn_Cita_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cita_Edit.Location = New System.Drawing.Point(456, 528)
        Me.btn_Cita_Edit.Name = "btn_Cita_Edit"
        Me.btn_Cita_Edit.Size = New System.Drawing.Size(89, 23)
        Me.btn_Cita_Edit.TabIndex = 0
        Me.btn_Cita_Edit.Text = "Modificar"
        Me.btn_Cita_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cita_Edit.UseVisualStyleBackColor = True
        '
        'btn_Cita_Eliminar
        '
        Me.btn_Cita_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cita_Eliminar.Enabled = False
        Me.btn_Cita_Eliminar.FlatAppearance.BorderSize = 0
        Me.btn_Cita_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cita_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btn_Cita_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cita_Eliminar.Location = New System.Drawing.Point(551, 526)
        Me.btn_Cita_Eliminar.Name = "btn_Cita_Eliminar"
        Me.btn_Cita_Eliminar.Size = New System.Drawing.Size(78, 26)
        Me.btn_Cita_Eliminar.TabIndex = 0
        Me.btn_Cita_Eliminar.Text = "Eliminar"
        Me.btn_Cita_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cita_Eliminar.UseVisualStyleBackColor = True
        '
        'grpCitas
        '
        Me.grpCitas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCitas.Controls.Add(Me.CITASDataGridView)
        Me.grpCitas.Location = New System.Drawing.Point(347, 206)
        Me.grpCitas.Name = "grpCitas"
        Me.grpCitas.Size = New System.Drawing.Size(339, 319)
        Me.grpCitas.TabIndex = 18
        Me.grpCitas.TabStop = False
        Me.grpCitas.Text = "CITAS"
        '
        'CITASDataGridView
        '
        Me.CITASDataGridView.AllowUserToAddRows = False
        Me.CITASDataGridView.AllowUserToDeleteRows = False
        Me.CITASDataGridView.AllowUserToResizeRows = False
        Me.CITASDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CITASDataGridView.AutoGenerateColumns = False
        Me.CITASDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CITASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.columnCitaFacturada})
        Me.CITASDataGridView.DataSource = Me.CITASBindingSource
        Me.CITASDataGridView.Location = New System.Drawing.Point(11, 19)
        Me.CITASDataGridView.MultiSelect = False
        Me.CITASDataGridView.Name = "CITASDataGridView"
        Me.CITASDataGridView.ReadOnly = True
        Me.CITASDataGridView.RowHeadersVisible = False
        Me.CITASDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CITASDataGridView.Size = New System.Drawing.Size(322, 288)
        Me.CITASDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDCITA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FECHA"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn6.FillWeight = 127.1574!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "HORA"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.FillWeight = 127.1574!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'columnCitaFacturada
        '
        Me.columnCitaFacturada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(2)
        Me.columnCitaFacturada.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnCitaFacturada.FillWeight = 45.68528!
        Me.columnCitaFacturada.HeaderText = "Facturada"
        Me.columnCitaFacturada.Image = Global.centro_medico.My.Resources.Resources.spacer
        Me.columnCitaFacturada.MinimumWidth = 30
        Me.columnCitaFacturada.Name = "columnCitaFacturada"
        Me.columnCitaFacturada.ReadOnly = True
        Me.columnCitaFacturada.Width = 30
        '
        'CITASBindingSource
        '
        Me.CITASBindingSource.DataMember = "CITAS"
        Me.CITASBindingSource.DataSource = Me.CMDataSet
        '
        'btn_Facturas_Add
        '
        Me.btn_Facturas_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Facturas_Add.FlatAppearance.BorderSize = 0
        Me.btn_Facturas_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Facturas_Add.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btn_Facturas_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Facturas_Add.Location = New System.Drawing.Point(762, 527)
        Me.btn_Facturas_Add.Name = "btn_Facturas_Add"
        Me.btn_Facturas_Add.Size = New System.Drawing.Size(112, 28)
        Me.btn_Facturas_Add.TabIndex = 0
        Me.btn_Facturas_Add.Text = "Nueva Factura"
        Me.btn_Facturas_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Facturas_Add.UseVisualStyleBackColor = True
        '
        'btn_Factura_Edit
        '
        Me.btn_Factura_Edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Factura_Edit.Enabled = False
        Me.btn_Factura_Edit.FlatAppearance.BorderSize = 0
        Me.btn_Factura_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Factura_Edit.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.btn_Factura_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Factura_Edit.Location = New System.Drawing.Point(880, 525)
        Me.btn_Factura_Edit.Name = "btn_Factura_Edit"
        Me.btn_Factura_Edit.Size = New System.Drawing.Size(88, 28)
        Me.btn_Factura_Edit.TabIndex = 0
        Me.btn_Factura_Edit.Text = "Modificar"
        Me.btn_Factura_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Factura_Edit.UseVisualStyleBackColor = True
        '
        'btn_Factura_Del
        '
        Me.btn_Factura_Del.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Factura_Del.Enabled = False
        Me.btn_Factura_Del.FlatAppearance.BorderSize = 0
        Me.btn_Factura_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Factura_Del.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btn_Factura_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Factura_Del.Location = New System.Drawing.Point(974, 524)
        Me.btn_Factura_Del.Name = "btn_Factura_Del"
        Me.btn_Factura_Del.Size = New System.Drawing.Size(75, 27)
        Me.btn_Factura_Del.TabIndex = 0
        Me.btn_Factura_Del.Text = "Eliminar"
        Me.btn_Factura_Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Factura_Del.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.FACTURASDataGridView)
        Me.GroupBox3.Location = New System.Drawing.Point(692, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(378, 319)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FACTURAS"
        '
        'FACTURASDataGridView
        '
        Me.FACTURASDataGridView.AllowUserToAddRows = False
        Me.FACTURASDataGridView.AllowUserToDeleteRows = False
        Me.FACTURASDataGridView.AllowUserToResizeRows = False
        Me.FACTURASDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FACTURASDataGridView.AutoGenerateColumns = False
        Me.FACTURASDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FACTURASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.NUMERO, Me.DataGridViewTextBoxColumn10, Me.FECHAENVIO, Me.PAGADA, Me.TOTAL})
        Me.FACTURASDataGridView.DataSource = Me.FACTURASBindingSource
        Me.FACTURASDataGridView.Location = New System.Drawing.Point(9, 19)
        Me.FACTURASDataGridView.MultiSelect = False
        Me.FACTURASDataGridView.Name = "FACTURASDataGridView"
        Me.FACTURASDataGridView.ReadOnly = True
        Me.FACTURASDataGridView.RowHeadersVisible = False
        Me.FACTURASDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FACTURASDataGridView.Size = New System.Drawing.Size(363, 288)
        Me.FACTURASDataGridView.TabIndex = 0
        '
        'FACTURASBindingSource
        '
        Me.FACTURASBindingSource.DataMember = "FACTURAS"
        Me.FACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Guardar, Me.ToolStripSeparator1, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1076, 25)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ts_Guardar
        '
        Me.ts_Guardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.ts_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Guardar.Name = "ts_Guardar"
        Me.ts_Guardar.Size = New System.Drawing.Size(69, 22)
        Me.ts_Guardar.Text = "&Guardar"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CtrlFicherosAdjuntos1)
        Me.GroupBox2.Location = New System.Drawing.Point(718, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 166)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documentos adjuntos"
        '
        'CtrlFicherosAdjuntos1
        '
        Me.CtrlFicherosAdjuntos1.IDPACIENTE = Nothing
        Me.CtrlFicherosAdjuntos1.Location = New System.Drawing.Point(9, 14)
        Me.CtrlFicherosAdjuntos1.Name = "CtrlFicherosAdjuntos1"
        Me.CtrlFicherosAdjuntos1.Size = New System.Drawing.Size(337, 148)
        Me.CtrlFicherosAdjuntos1.TabIndex = 0
        '
        'CITASTableAdapter
        '
        Me.CITASTableAdapter.ClearBeforeFill = True
        '
        'FACTURASTableAdapter
        '
        Me.FACTURASTableAdapter.ClearBeforeFill = True
        '
        'N_ProcesosTableAdapter
        '
        Me.N_ProcesosTableAdapter.ClearBeforeFill = True
        '
        'N_PartesPorProcesoTableAdapter
        '
        Me.N_PartesPorProcesoTableAdapter.ClearBeforeFill = True
        '
        'EMPRESASTableAdapter
        '
        Me.EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'MUTUASTableAdapter
        '
        Me.MUTUASTableAdapter.ClearBeforeFill = True
        '
        'btn_ParteAsistencia_ADD
        '
        Me.btn_ParteAsistencia_ADD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ParteAsistencia_ADD.FlatAppearance.BorderSize = 0
        Me.btn_ParteAsistencia_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ParteAsistencia_ADD.Image = Global.centro_medico.My.Resources.Resources._24_tab_add
        Me.btn_ParteAsistencia_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ParteAsistencia_ADD.Location = New System.Drawing.Point(5, 554)
        Me.btn_ParteAsistencia_ADD.Name = "btn_ParteAsistencia_ADD"
        Me.btn_ParteAsistencia_ADD.Size = New System.Drawing.Size(116, 24)
        Me.btn_ParteAsistencia_ADD.TabIndex = 0
        Me.btn_ParteAsistencia_ADD.Text = "Parte Asistencia"
        Me.btn_ParteAsistencia_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ParteAsistencia_ADD.UseVisualStyleBackColor = True
        '
        'NPartesBindingSource
        '
        Me.NPartesBindingSource.DataMember = "N_Partes"
        Me.NPartesBindingSource.DataSource = Me.CM3DataSet
        '
        'N_PartesTableAdapter
        '
        Me.N_PartesTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IDFACTURA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IDFACTURA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'NUMERO
        '
        Me.NUMERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NUMERO.DataPropertyName = "NUMERO"
        Me.NUMERO.HeaderText = "Num Fra."
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        Me.NUMERO.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FECHA"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'FECHAENVIO
        '
        Me.FECHAENVIO.DataPropertyName = "FECHAENVIO"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.FECHAENVIO.DefaultCellStyle = DataGridViewCellStyle5
        Me.FECHAENVIO.HeaderText = "Fecha Envio"
        Me.FECHAENVIO.Name = "FECHAENVIO"
        Me.FECHAENVIO.ReadOnly = True
        '
        'PAGADA
        '
        Me.PAGADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PAGADA.DataPropertyName = "PAGADA"
        Me.PAGADA.HeaderText = "Pagada"
        Me.PAGADA.Name = "PAGADA"
        Me.PAGADA.ReadOnly = True
        Me.PAGADA.Width = 69
        '
        'TOTAL
        '
        Me.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TOTAL.DataPropertyName = "TOTAL"
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.TOTAL.DefaultCellStyle = DataGridViewCellStyle6
        Me.TOTAL.HeaderText = "Importe"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Width = 67
        '
        'frmProcesos_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 581)
        Me.Controls.Add(Me.bt_Partes_Edit)
        Me.Controls.Add(Me.bt_Partes_Add)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_Factura_Del)
        Me.Controls.Add(Me.grpCitas)
        Me.Controls.Add(Me.btn_Cita_Eliminar)
        Me.Controls.Add(Me.btn_Factura_Edit)
        Me.Controls.Add(Me.grpPartes)
        Me.Controls.Add(Me.btn_Cita_Edit)
        Me.Controls.Add(Me.btn_Facturas_Add)
        Me.Controls.Add(Me.bt_Partes_Delete)
        Me.Controls.Add(Me.btn_Cita_ADD)
        Me.Controls.Add(Me.btn_ParteAsistencia_ADD)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmProcesos_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Proceso"
        CType(Me.N_ProcesosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPartes.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_PartesPorProcesoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM3DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCitas.ResumeLayout(False)
        CType(Me.CITASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.FACTURASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NPartesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CM3DataSet As centro_medico.CM3DataSet
    Friend WithEvents N_ProcesosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_ProcesosTableAdapter As centro_medico.CM3DataSetTableAdapters.N_ProcesosTableAdapter
    Friend WithEvents ID_ProcesoTextBox As ctrlTextboxAvanzado
    Friend WithEvents FechaInicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaFinalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FinalizadoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Asistente_Facturacion As System.Windows.Forms.Button
    Friend WithEvents bt_Partes_Add As System.Windows.Forms.Button
    Friend WithEvents bt_Partes_Delete As System.Windows.Forms.Button
    Friend WithEvents bt_Partes_Edit As System.Windows.Forms.Button
    Friend WithEvents grpPartes As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cita_ADD As System.Windows.Forms.Button
    Friend WithEvents btn_Cita_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Cita_Eliminar As System.Windows.Forms.Button
    Friend WithEvents grpCitas As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Facturas_Add As System.Windows.Forms.Button
    Friend WithEvents btn_Factura_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Factura_Del As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents N_PartesPorProcesoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_PartesPorProcesoTableAdapter As centro_medico.CM3DataSetTableAdapters.N_PartesPorProcesoTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CITASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CITASTableAdapter As centro_medico.CMDataSetTableAdapters.CITASTableAdapter
    Friend WithEvents CITASDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents FACTURASDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CtrlFicherosAdjuntos1 As centro_medico.ctrlFicherosAdjuntos
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents EMPRESASComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents MUTUASComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btn_ParteAsistencia_ADD As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCitaFacturada As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NPartesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_PartesTableAdapter As centro_medico.CM3DataSetTableAdapters.N_PartesTableAdapter
    Friend WithEvents CM3DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Public WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAENVIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAGADA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
