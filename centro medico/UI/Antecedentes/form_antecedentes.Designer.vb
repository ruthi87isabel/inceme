<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_antecedentes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lb_amDescripcion As System.Windows.Forms.Label
        Dim lb_dpEdadhlaboral As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.lb_teclas = New System.Windows.Forms.Label()
        Me.bg_amAlarmas = New System.Windows.Forms.GroupBox()
        Me.bt_alarma = New System.Windows.Forms.Button()
        Me.dtg_amAlarmas = New System.Windows.Forms.DataGridView()
        Me.bt_amMenosArriba = New System.Windows.Forms.Button()
        Me.bt_amMasArriba = New System.Windows.Forms.Button()
        Me.tb_amDescripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.gb_amInfoprimaria = New System.Windows.Forms.GroupBox()
        Me.bt_EditaDiagnostico = New System.Windows.Forms.Button()
        Me.bt_QuitaDiagnostico = New System.Windows.Forms.Button()
        Me.btAddDiagnostico = New System.Windows.Forms.Button()
        Me.dtg_Diagnosticos = New System.Windows.Forms.DataGridView()
        Me.IDDIAGNOSTICO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAGNOSTICO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIE10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPACIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AntecedentesDiagnosticosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtg_amInfoprimaria = New System.Windows.Forms.DataGridView()
        Me.bt_amTrianguloAbajo = New System.Windows.Forms.Button()
        Me.bt_amMenosAbajo = New System.Windows.Forms.Button()
        Me.bt_amMasAbajo = New System.Windows.Forms.Button()
        Me.tb_amGrandeabajo = New centro_medico.ctrlTextboxAvanzado()
        Me.DIAGNOSTICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALARMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALARMASTableAdapter = New centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter()
        Me.LINEASALARMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINEASALARMATableAdapter = New centro_medico.CMDataSetTableAdapters.LINEASALARMATableAdapter()
        Me.INFORMACIONPRIMARIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INFORMACIONPRIMARIATableAdapter = New centro_medico.CMDataSetTableAdapters.INFORMACIONPRIMARIATableAdapter()
        Me.DIAGNOSTICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter()
        Me.gb_Principales = New System.Windows.Forms.GroupBox()
        Me.tb_dpEdadhactual = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_Factura = New System.Windows.Forms.Button()
        Me.tb_Nombre = New centro_medico.ctrlTextboxAvanzado()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_SegundoAp = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_PrimerAp = New centro_medico.ctrlTextboxAvanzado()
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.lb_FechaIngreso = New System.Windows.Forms.Label()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.lb_SegundoAp = New System.Windows.Forms.Label()
        Me.lb_PrimerAp = New System.Windows.Forms.Label()
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter()
        Me.AntecedentesDiagnosticosTableAdapter = New centro_medico.CMDataSetTableAdapters.AntecedentesDiagnosticosTableAdapter()
        lb_amDescripcion = New System.Windows.Forms.Label()
        lb_dpEdadhlaboral = New System.Windows.Forms.Label()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.bg_amAlarmas.SuspendLayout()
        CType(Me.dtg_amAlarmas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_amInfoprimaria.SuspendLayout()
        CType(Me.dtg_Diagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AntecedentesDiagnosticosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_amInfoprimaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASALARMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORMACIONPRIMARIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Principales.SuspendLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_amDescripcion
        '
        lb_amDescripcion.AutoSize = True
        lb_amDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_amDescripcion.Location = New System.Drawing.Point(512, 1)
        lb_amDescripcion.Name = "lb_amDescripcion"
        lb_amDescripcion.Size = New System.Drawing.Size(63, 13)
        lb_amDescripcion.TabIndex = 2
        lb_amDescripcion.Text = "Descripción"
        '
        'lb_dpEdadhlaboral
        '
        lb_dpEdadhlaboral.AutoSize = True
        lb_dpEdadhlaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpEdadhlaboral.Location = New System.Drawing.Point(585, 9)
        lb_dpEdadhlaboral.Name = "lb_dpEdadhlaboral"
        lb_dpEdadhlaboral.Size = New System.Drawing.Size(35, 13)
        lb_dpEdadhlaboral.TabIndex = 37
        lb_dpEdadhlaboral.Text = "Edad:"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(855, 25)
        Me.ToolStrip2.TabIndex = 21
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "&Guardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Can&celar"
        '
        'lb_teclas
        '
        Me.lb_teclas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_teclas.AutoSize = True
        Me.lb_teclas.Location = New System.Drawing.Point(35, 531)
        Me.lb_teclas.Name = "lb_teclas"
        Me.lb_teclas.Size = New System.Drawing.Size(156, 13)
        Me.lb_teclas.TabIndex = 23
        Me.lb_teclas.Text = "Alt+G=Guardar; Alt+C=Cancelar"
        '
        'bg_amAlarmas
        '
        Me.bg_amAlarmas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bg_amAlarmas.BackColor = System.Drawing.Color.GhostWhite
        Me.bg_amAlarmas.Controls.Add(Me.bt_alarma)
        Me.bg_amAlarmas.Controls.Add(Me.dtg_amAlarmas)
        Me.bg_amAlarmas.Controls.Add(Me.bt_amMenosArriba)
        Me.bg_amAlarmas.Controls.Add(lb_amDescripcion)
        Me.bg_amAlarmas.Controls.Add(Me.bt_amMasArriba)
        Me.bg_amAlarmas.Controls.Add(Me.tb_amDescripcion)
        Me.bg_amAlarmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bg_amAlarmas.Location = New System.Drawing.Point(5, 74)
        Me.bg_amAlarmas.Name = "bg_amAlarmas"
        Me.bg_amAlarmas.Size = New System.Drawing.Size(845, 181)
        Me.bg_amAlarmas.TabIndex = 25
        Me.bg_amAlarmas.TabStop = False
        Me.bg_amAlarmas.Text = "Alarmas"
        '
        'bt_alarma
        '
        Me.bt_alarma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_alarma.BackgroundImage = Global.centro_medico.My.Resources.Resources.up
        Me.bt_alarma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_alarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_alarma.Location = New System.Drawing.Point(807, 93)
        Me.bt_alarma.Name = "bt_alarma"
        Me.bt_alarma.Size = New System.Drawing.Size(30, 25)
        Me.bt_alarma.TabIndex = 11
        Me.bt_alarma.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_alarma.UseVisualStyleBackColor = True
        '
        'dtg_amAlarmas
        '
        Me.dtg_amAlarmas.AllowUserToAddRows = False
        Me.dtg_amAlarmas.AllowUserToDeleteRows = False
        Me.dtg_amAlarmas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_amAlarmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_amAlarmas.BackgroundColor = System.Drawing.Color.White
        Me.dtg_amAlarmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_amAlarmas.Location = New System.Drawing.Point(6, 17)
        Me.dtg_amAlarmas.MultiSelect = False
        Me.dtg_amAlarmas.Name = "dtg_amAlarmas"
        Me.dtg_amAlarmas.ReadOnly = True
        Me.dtg_amAlarmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_amAlarmas.Size = New System.Drawing.Size(500, 148)
        Me.dtg_amAlarmas.TabIndex = 7
        '
        'bt_amMenosArriba
        '
        Me.bt_amMenosArriba.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_amMenosArriba.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_amMenosArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_amMenosArriba.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_amMenosArriba.Location = New System.Drawing.Point(807, 124)
        Me.bt_amMenosArriba.Name = "bt_amMenosArriba"
        Me.bt_amMenosArriba.Size = New System.Drawing.Size(30, 25)
        Me.bt_amMenosArriba.TabIndex = 6
        Me.bt_amMenosArriba.UseVisualStyleBackColor = True
        '
        'bt_amMasArriba
        '
        Me.bt_amMasArriba.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_amMasArriba.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_amMasArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_amMasArriba.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_amMasArriba.Location = New System.Drawing.Point(807, 58)
        Me.bt_amMasArriba.Name = "bt_amMasArriba"
        Me.bt_amMasArriba.Size = New System.Drawing.Size(30, 29)
        Me.bt_amMasArriba.TabIndex = 5
        Me.bt_amMasArriba.UseVisualStyleBackColor = True
        '
        'tb_amDescripcion
        '
        Me.tb_amDescripcion.AcceptsReturn = True
        Me.tb_amDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_amDescripcion.BackColor = System.Drawing.Color.White
        Me.tb_amDescripcion.Location = New System.Drawing.Point(515, 17)
        Me.tb_amDescripcion.Multiline = True
        Me.tb_amDescripcion.Name = "tb_amDescripcion"
        Me.tb_amDescripcion.ReadOnly = True
        Me.tb_amDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_amDescripcion.Size = New System.Drawing.Size(286, 149)
        Me.tb_amDescripcion.TabIndex = 3
        '
        'gb_amInfoprimaria
        '
        Me.gb_amInfoprimaria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_amInfoprimaria.BackColor = System.Drawing.Color.GhostWhite
        Me.gb_amInfoprimaria.Controls.Add(Me.bt_EditaDiagnostico)
        Me.gb_amInfoprimaria.Controls.Add(Me.bt_QuitaDiagnostico)
        Me.gb_amInfoprimaria.Controls.Add(Me.btAddDiagnostico)
        Me.gb_amInfoprimaria.Controls.Add(Me.dtg_Diagnosticos)
        Me.gb_amInfoprimaria.Controls.Add(Me.dtg_amInfoprimaria)
        Me.gb_amInfoprimaria.Controls.Add(Me.bt_amTrianguloAbajo)
        Me.gb_amInfoprimaria.Controls.Add(Me.bt_amMenosAbajo)
        Me.gb_amInfoprimaria.Controls.Add(Me.bt_amMasAbajo)
        Me.gb_amInfoprimaria.Controls.Add(Me.tb_amGrandeabajo)
        Me.gb_amInfoprimaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_amInfoprimaria.Location = New System.Drawing.Point(5, 259)
        Me.gb_amInfoprimaria.Name = "gb_amInfoprimaria"
        Me.gb_amInfoprimaria.Size = New System.Drawing.Size(845, 255)
        Me.gb_amInfoprimaria.TabIndex = 24
        Me.gb_amInfoprimaria.TabStop = False
        Me.gb_amInfoprimaria.Text = "Información primaria del paciente"
        '
        'bt_EditaDiagnostico
        '
        Me.bt_EditaDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_EditaDiagnostico.BackgroundImage = Global.centro_medico.My.Resources.Resources.up
        Me.bt_EditaDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_EditaDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_EditaDiagnostico.Location = New System.Drawing.Point(807, 163)
        Me.bt_EditaDiagnostico.Name = "bt_EditaDiagnostico"
        Me.bt_EditaDiagnostico.Size = New System.Drawing.Size(30, 25)
        Me.bt_EditaDiagnostico.TabIndex = 10
        Me.bt_EditaDiagnostico.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_EditaDiagnostico.UseVisualStyleBackColor = True
        '
        'bt_QuitaDiagnostico
        '
        Me.bt_QuitaDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_QuitaDiagnostico.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_QuitaDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_QuitaDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_QuitaDiagnostico.Location = New System.Drawing.Point(807, 194)
        Me.bt_QuitaDiagnostico.Name = "bt_QuitaDiagnostico"
        Me.bt_QuitaDiagnostico.Size = New System.Drawing.Size(30, 25)
        Me.bt_QuitaDiagnostico.TabIndex = 9
        Me.bt_QuitaDiagnostico.UseVisualStyleBackColor = True
        '
        'btAddDiagnostico
        '
        Me.btAddDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAddDiagnostico.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.btAddDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btAddDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddDiagnostico.Location = New System.Drawing.Point(807, 132)
        Me.btAddDiagnostico.Name = "btAddDiagnostico"
        Me.btAddDiagnostico.Size = New System.Drawing.Size(30, 25)
        Me.btAddDiagnostico.TabIndex = 8
        Me.btAddDiagnostico.UseVisualStyleBackColor = True
        '
        'dtg_Diagnosticos
        '
        Me.dtg_Diagnosticos.AllowUserToAddRows = False
        Me.dtg_Diagnosticos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtg_Diagnosticos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_Diagnosticos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_Diagnosticos.AutoGenerateColumns = False
        Me.dtg_Diagnosticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_Diagnosticos.BackgroundColor = System.Drawing.Color.White
        Me.dtg_Diagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_Diagnosticos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDIAGNOSTICO, Me.DIAGNOSTICO, Me.OBSERVACIONES, Me.CIE10, Me.CPACIENTE})
        Me.dtg_Diagnosticos.DataSource = Me.AntecedentesDiagnosticosBindingSource
        Me.dtg_Diagnosticos.Location = New System.Drawing.Point(6, 132)
        Me.dtg_Diagnosticos.MultiSelect = False
        Me.dtg_Diagnosticos.Name = "dtg_Diagnosticos"
        Me.dtg_Diagnosticos.ReadOnly = True
        Me.dtg_Diagnosticos.RowHeadersVisible = False
        Me.dtg_Diagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Diagnosticos.Size = New System.Drawing.Size(795, 107)
        Me.dtg_Diagnosticos.TabIndex = 6
        '
        'IDDIAGNOSTICO
        '
        Me.IDDIAGNOSTICO.DataPropertyName = "IDDIAGNOSTICO"
        Me.IDDIAGNOSTICO.HeaderText = "IDDIAGNOSTICO"
        Me.IDDIAGNOSTICO.Name = "IDDIAGNOSTICO"
        Me.IDDIAGNOSTICO.ReadOnly = True
        Me.IDDIAGNOSTICO.Visible = False
        '
        'DIAGNOSTICO
        '
        Me.DIAGNOSTICO.DataPropertyName = "DIAGNOSTICO"
        Me.DIAGNOSTICO.HeaderText = "DIAGNOSTICO"
        Me.DIAGNOSTICO.Name = "DIAGNOSTICO"
        Me.DIAGNOSTICO.ReadOnly = True
        '
        'OBSERVACIONES
        '
        Me.OBSERVACIONES.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONES.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONES.Name = "OBSERVACIONES"
        Me.OBSERVACIONES.ReadOnly = True
        '
        'CIE10
        '
        Me.CIE10.DataPropertyName = "CIE10"
        Me.CIE10.HeaderText = "CIE10"
        Me.CIE10.Name = "CIE10"
        Me.CIE10.ReadOnly = True
        Me.CIE10.Visible = False
        '
        'CPACIENTE
        '
        Me.CPACIENTE.HeaderText = "CPACIENTE"
        Me.CPACIENTE.Name = "CPACIENTE"
        Me.CPACIENTE.ReadOnly = True
        Me.CPACIENTE.Visible = False
        '
        'AntecedentesDiagnosticosBindingSource
        '
        Me.AntecedentesDiagnosticosBindingSource.DataMember = "AntecedentesDiagnosticos"
        Me.AntecedentesDiagnosticosBindingSource.DataSource = Me.CMDataSet
        '
        'dtg_amInfoprimaria
        '
        Me.dtg_amInfoprimaria.AllowUserToAddRows = False
        Me.dtg_amInfoprimaria.AllowUserToDeleteRows = False
        Me.dtg_amInfoprimaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_amInfoprimaria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_amInfoprimaria.BackgroundColor = System.Drawing.Color.White
        Me.dtg_amInfoprimaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_amInfoprimaria.Location = New System.Drawing.Point(6, 16)
        Me.dtg_amInfoprimaria.MultiSelect = False
        Me.dtg_amInfoprimaria.Name = "dtg_amInfoprimaria"
        Me.dtg_amInfoprimaria.ReadOnly = True
        Me.dtg_amInfoprimaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_amInfoprimaria.Size = New System.Drawing.Size(500, 107)
        Me.dtg_amInfoprimaria.TabIndex = 5
        '
        'bt_amTrianguloAbajo
        '
        Me.bt_amTrianguloAbajo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_amTrianguloAbajo.BackgroundImage = Global.centro_medico.My.Resources.Resources.up
        Me.bt_amTrianguloAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_amTrianguloAbajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_amTrianguloAbajo.Location = New System.Drawing.Point(807, 47)
        Me.bt_amTrianguloAbajo.Name = "bt_amTrianguloAbajo"
        Me.bt_amTrianguloAbajo.Size = New System.Drawing.Size(30, 25)
        Me.bt_amTrianguloAbajo.TabIndex = 4
        Me.bt_amTrianguloAbajo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_amTrianguloAbajo.UseVisualStyleBackColor = True
        '
        'bt_amMenosAbajo
        '
        Me.bt_amMenosAbajo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_amMenosAbajo.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_amMenosAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_amMenosAbajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_amMenosAbajo.Location = New System.Drawing.Point(807, 78)
        Me.bt_amMenosAbajo.Name = "bt_amMenosAbajo"
        Me.bt_amMenosAbajo.Size = New System.Drawing.Size(30, 25)
        Me.bt_amMenosAbajo.TabIndex = 3
        Me.bt_amMenosAbajo.UseVisualStyleBackColor = True
        '
        'bt_amMasAbajo
        '
        Me.bt_amMasAbajo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_amMasAbajo.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_amMasAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_amMasAbajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_amMasAbajo.Location = New System.Drawing.Point(807, 16)
        Me.bt_amMasAbajo.Name = "bt_amMasAbajo"
        Me.bt_amMasAbajo.Size = New System.Drawing.Size(30, 25)
        Me.bt_amMasAbajo.TabIndex = 2
        Me.bt_amMasAbajo.UseVisualStyleBackColor = True
        '
        'tb_amGrandeabajo
        '
        Me.tb_amGrandeabajo.AcceptsReturn = True
        Me.tb_amGrandeabajo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_amGrandeabajo.BackColor = System.Drawing.Color.White
        Me.tb_amGrandeabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_amGrandeabajo.Location = New System.Drawing.Point(515, 16)
        Me.tb_amGrandeabajo.Multiline = True
        Me.tb_amGrandeabajo.Name = "tb_amGrandeabajo"
        Me.tb_amGrandeabajo.ReadOnly = True
        Me.tb_amGrandeabajo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_amGrandeabajo.Size = New System.Drawing.Size(286, 107)
        Me.tb_amGrandeabajo.TabIndex = 1
        '
        'DIAGNOSTICOSBindingSource
        '
        Me.DIAGNOSTICOSBindingSource.DataMember = "DIAGNOSTICOS"
        Me.DIAGNOSTICOSBindingSource.DataSource = Me.CMDataSet
        '
        'ALARMASBindingSource
        '
        Me.ALARMASBindingSource.DataMember = "ALARMAS"
        Me.ALARMASBindingSource.DataSource = Me.CMDataSet
        '
        'ALARMASTableAdapter
        '
        Me.ALARMASTableAdapter.ClearBeforeFill = True
        '
        'LINEASALARMABindingSource
        '
        Me.LINEASALARMABindingSource.DataMember = "LINEASALARMA"
        Me.LINEASALARMABindingSource.DataSource = Me.CMDataSet
        '
        'LINEASALARMATableAdapter
        '
        Me.LINEASALARMATableAdapter.ClearBeforeFill = True
        '
        'INFORMACIONPRIMARIABindingSource
        '
        Me.INFORMACIONPRIMARIABindingSource.DataMember = "INFORMACIONPRIMARIA"
        Me.INFORMACIONPRIMARIABindingSource.DataSource = Me.CMDataSet
        '
        'INFORMACIONPRIMARIATableAdapter
        '
        Me.INFORMACIONPRIMARIATableAdapter.ClearBeforeFill = True
        '
        'DIAGNOSTICOSTableAdapter
        '
        Me.DIAGNOSTICOSTableAdapter.ClearBeforeFill = True
        '
        'gb_Principales
        '
        Me.gb_Principales.Controls.Add(Me.tb_dpEdadhactual)
        Me.gb_Principales.Controls.Add(lb_dpEdadhlaboral)
        Me.gb_Principales.Controls.Add(Me.bt_Factura)
        Me.gb_Principales.Controls.Add(Me.tb_Nombre)
        Me.gb_Principales.Controls.Add(Me.tb_SegundoAp)
        Me.gb_Principales.Controls.Add(Me.tb_PrimerAp)
        Me.gb_Principales.Controls.Add(Me.dtp_FechaIngreso)
        Me.gb_Principales.Controls.Add(Me.lb_FechaIngreso)
        Me.gb_Principales.Controls.Add(Me.lb_Nombre)
        Me.gb_Principales.Controls.Add(Me.lb_SegundoAp)
        Me.gb_Principales.Controls.Add(Me.lb_PrimerAp)
        Me.gb_Principales.Location = New System.Drawing.Point(103, 25)
        Me.gb_Principales.Name = "gb_Principales"
        Me.gb_Principales.Size = New System.Drawing.Size(649, 47)
        Me.gb_Principales.TabIndex = 41
        Me.gb_Principales.TabStop = False
        Me.gb_Principales.Visible = False
        '
        'tb_dpEdadhactual
        '
        Me.tb_dpEdadhactual.AcceptsReturn = True
        Me.tb_dpEdadhactual.Enabled = False
        Me.tb_dpEdadhactual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpEdadhactual.Location = New System.Drawing.Point(588, 22)
        Me.tb_dpEdadhactual.Name = "tb_dpEdadhactual"
        Me.tb_dpEdadhactual.ReadOnly = True
        Me.tb_dpEdadhactual.Size = New System.Drawing.Size(39, 20)
        Me.tb_dpEdadhactual.TabIndex = 36
        '
        'bt_Factura
        '
        Me.bt_Factura.BackgroundImage = Global.centro_medico.My.Resources.Resources.Facturas
        Me.bt_Factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_Factura.Location = New System.Drawing.Point(813, 51)
        Me.bt_Factura.Name = "bt_Factura"
        Me.bt_Factura.Size = New System.Drawing.Size(35, 29)
        Me.bt_Factura.TabIndex = 12
        Me.bt_Factura.UseVisualStyleBackColor = True
        '
        'tb_Nombre
        '
        Me.tb_Nombre.AcceptsReturn = True
        Me.tb_Nombre.BackColor = System.Drawing.SystemColors.Info
        Me.tb_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NOMBRE", True))
        Me.tb_Nombre.Location = New System.Drawing.Point(319, 23)
        Me.tb_Nombre.MaxLength = 25
        Me.tb_Nombre.Name = "tb_Nombre"
        Me.tb_Nombre.ReadOnly = True
        Me.tb_Nombre.Size = New System.Drawing.Size(152, 20)
        Me.tb_Nombre.TabIndex = 9
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'tb_SegundoAp
        '
        Me.tb_SegundoAp.AcceptsReturn = True
        Me.tb_SegundoAp.BackColor = System.Drawing.Color.White
        Me.tb_SegundoAp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO2", True))
        Me.tb_SegundoAp.Location = New System.Drawing.Point(171, 23)
        Me.tb_SegundoAp.MaxLength = 15
        Me.tb_SegundoAp.Name = "tb_SegundoAp"
        Me.tb_SegundoAp.ReadOnly = True
        Me.tb_SegundoAp.Size = New System.Drawing.Size(144, 20)
        Me.tb_SegundoAp.TabIndex = 8
        '
        'tb_PrimerAp
        '
        Me.tb_PrimerAp.AcceptsReturn = True
        Me.tb_PrimerAp.BackColor = System.Drawing.Color.White
        Me.tb_PrimerAp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO1", True))
        Me.tb_PrimerAp.Location = New System.Drawing.Point(46, 23)
        Me.tb_PrimerAp.MaxLength = 15
        Me.tb_PrimerAp.Name = "tb_PrimerAp"
        Me.tb_PrimerAp.ReadOnly = True
        Me.tb_PrimerAp.Size = New System.Drawing.Size(121, 20)
        Me.tb_PrimerAp.TabIndex = 7
        '
        'dtp_FechaIngreso
        '
        Me.dtp_FechaIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PACIENTESBindingSource, "FECHAALTA", True))
        Me.dtp_FechaIngreso.Enabled = False
        Me.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaIngreso.Location = New System.Drawing.Point(485, 23)
        Me.dtp_FechaIngreso.Name = "dtp_FechaIngreso"
        Me.dtp_FechaIngreso.Size = New System.Drawing.Size(94, 20)
        Me.dtp_FechaIngreso.TabIndex = 11
        Me.dtp_FechaIngreso.Value = New Date(2009, 6, 10, 0, 0, 0, 0)
        '
        'lb_FechaIngreso
        '
        Me.lb_FechaIngreso.AutoSize = True
        Me.lb_FechaIngreso.Location = New System.Drawing.Point(483, 9)
        Me.lb_FechaIngreso.Name = "lb_FechaIngreso"
        Me.lb_FechaIngreso.Size = New System.Drawing.Size(75, 13)
        Me.lb_FechaIngreso.TabIndex = 4
        Me.lb_FechaIngreso.Text = "Fecha Ingreso"
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.Location = New System.Drawing.Point(318, 9)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lb_Nombre.TabIndex = 3
        Me.lb_Nombre.Text = "Nombre"
        '
        'lb_SegundoAp
        '
        Me.lb_SegundoAp.AutoSize = True
        Me.lb_SegundoAp.Location = New System.Drawing.Point(173, 8)
        Me.lb_SegundoAp.Name = "lb_SegundoAp"
        Me.lb_SegundoAp.Size = New System.Drawing.Size(90, 13)
        Me.lb_SegundoAp.TabIndex = 2
        Me.lb_SegundoAp.Text = "Segundo Apellido"
        '
        'lb_PrimerAp
        '
        Me.lb_PrimerAp.AutoSize = True
        Me.lb_PrimerAp.Location = New System.Drawing.Point(47, 8)
        Me.lb_PrimerAp.Name = "lb_PrimerAp"
        Me.lb_PrimerAp.Size = New System.Drawing.Size(76, 13)
        Me.lb_PrimerAp.TabIndex = 1
        Me.lb_PrimerAp.Text = "Primer Apellido"
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'AntecedentesDiagnosticosTableAdapter
        '
        Me.AntecedentesDiagnosticosTableAdapter.ClearBeforeFill = True
        '
        'form_antecedentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(855, 546)
        Me.Controls.Add(Me.gb_Principales)
        Me.Controls.Add(Me.bg_amAlarmas)
        Me.Controls.Add(Me.gb_amInfoprimaria)
        Me.Controls.Add(Me.lb_teclas)
        Me.Controls.Add(Me.ToolStrip2)
        Me.KeyPreview = True
        Me.Name = "form_antecedentes"
        Me.ShowInTaskbar = False
        Me.Text = "ANTECEDENTES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.bg_amAlarmas.ResumeLayout(False)
        Me.bg_amAlarmas.PerformLayout()
        CType(Me.dtg_amAlarmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_amInfoprimaria.ResumeLayout(False)
        Me.gb_amInfoprimaria.PerformLayout()
        CType(Me.dtg_Diagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AntecedentesDiagnosticosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_amInfoprimaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASALARMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORMACIONPRIMARIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Principales.ResumeLayout(False)
        Me.gb_Principales.PerformLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lb_teclas As System.Windows.Forms.Label
    Friend WithEvents bg_amAlarmas As System.Windows.Forms.GroupBox
    Friend WithEvents dtg_amAlarmas As System.Windows.Forms.DataGridView
    Friend WithEvents bt_amMenosArriba As System.Windows.Forms.Button
    Friend WithEvents bt_amMasArriba As System.Windows.Forms.Button
    Friend WithEvents tb_amDescripcion As ctrlTextboxAvanzado
    Friend WithEvents gb_amInfoprimaria As System.Windows.Forms.GroupBox
    Friend WithEvents bt_EditaDiagnostico As System.Windows.Forms.Button
    Friend WithEvents bt_QuitaDiagnostico As System.Windows.Forms.Button
    Friend WithEvents btAddDiagnostico As System.Windows.Forms.Button
    Friend WithEvents dtg_Diagnosticos As System.Windows.Forms.DataGridView
    Friend WithEvents dtg_amInfoprimaria As System.Windows.Forms.DataGridView
    Friend WithEvents bt_amTrianguloAbajo As System.Windows.Forms.Button
    Friend WithEvents bt_amMenosAbajo As System.Windows.Forms.Button
    Friend WithEvents bt_amMasAbajo As System.Windows.Forms.Button
    Friend WithEvents tb_amGrandeabajo As ctrlTextboxAvanzado
    Friend WithEvents ALARMASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALARMASTableAdapter As centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter
    Friend WithEvents LINEASALARMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEASALARMATableAdapter As centro_medico.CMDataSetTableAdapters.LINEASALARMATableAdapter
    Friend WithEvents INFORMACIONPRIMARIABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INFORMACIONPRIMARIATableAdapter As centro_medico.CMDataSetTableAdapters.INFORMACIONPRIMARIATableAdapter
    Friend WithEvents DIAGNOSTICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIAGNOSTICOSTableAdapter As centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter
    Friend WithEvents IDDIAGNOSTICO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIAGNOSTICO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIE10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPACIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gb_Principales As System.Windows.Forms.GroupBox
    Friend WithEvents tb_dpEdadhactual As ctrlTextboxAvanzado
    Friend WithEvents bt_Factura As System.Windows.Forms.Button
    Friend WithEvents tb_Nombre As ctrlTextboxAvanzado
    Friend WithEvents tb_SegundoAp As ctrlTextboxAvanzado
    Friend WithEvents tb_PrimerAp As ctrlTextboxAvanzado
    Friend WithEvents dtp_FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_FechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lb_Nombre As System.Windows.Forms.Label
    Friend WithEvents lb_SegundoAp As System.Windows.Forms.Label
    Friend WithEvents lb_PrimerAp As System.Windows.Forms.Label
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents AntecedentesDiagnosticosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AntecedentesDiagnosticosTableAdapter As centro_medico.CMDataSetTableAdapters.AntecedentesDiagnosticosTableAdapter
    Friend WithEvents bt_alarma As System.Windows.Forms.Button
End Class
