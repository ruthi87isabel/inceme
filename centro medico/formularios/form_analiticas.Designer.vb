<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_analiticas
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
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim IMPORTELabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim REFFRALabel As System.Windows.Forms.Label
        Dim lb_fecha As System.Windows.Forms.Label
        Dim ESTADOLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.tb_descripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.ANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.tb_total = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_notas = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_factura = New centro_medico.ctrlTextboxAvanzado()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chb_estado = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_paciente = New System.Windows.Forms.Button()
        Me.dtp_femision = New System.Windows.Forms.DateTimePicker()
        Me.tb_idpaciente = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_paciente = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_copiar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_buscar = New centro_medico.ctrlTextboxAvanzado()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_disponibles = New System.Windows.Forms.DataGridView()
        Me.bt_izq = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_realizar = New System.Windows.Forms.DataGridView()
        Me.bt_der = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.bt_imprimir = New System.Windows.Forms.Button()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.LINEASANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.ANALITICASTableAdapter()
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSANALITICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSANALITICATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSANALITICATableAdapter()
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter()
        Me.LINEASANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.LINEASANALITICASTableAdapter()
        Me.LPLANTILLAANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLANTILLAANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.PLANTILLAANALITICASTableAdapter()
        Me.PLANTILLAANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LPLANTILLAANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.LPLANTILLAANALITICASTableAdapter()
        Me.ckRecibida = New System.Windows.Forms.CheckBox()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        IMPORTELabel = New System.Windows.Forms.Label()
        NOTASLabel = New System.Windows.Forms.Label()
        REFFRALabel = New System.Windows.Forms.Label()
        lb_fecha = New System.Windows.Forms.Label()
        ESTADOLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.ANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_disponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_realizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(489, 20)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(134, 13)
        DESCRIPCIONLabel.TabIndex = 3
        DESCRIPCIONLabel.Text = "Descripcion de la analitica:"
        '
        'IMPORTELabel
        '
        IMPORTELabel.AutoSize = True
        IMPORTELabel.Location = New System.Drawing.Point(177, 245)
        IMPORTELabel.Name = "IMPORTELabel"
        IMPORTELabel.Size = New System.Drawing.Size(34, 13)
        IMPORTELabel.TabIndex = 5
        IMPORTELabel.Text = "Total:"
        IMPORTELabel.Visible = False
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(5, 390)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 15
        NOTASLabel.Text = "Notas:"
        '
        'REFFRALabel
        '
        REFFRALabel.AutoSize = True
        REFFRALabel.Location = New System.Drawing.Point(10, 64)
        REFFRALabel.Name = "REFFRALabel"
        REFFRALabel.Size = New System.Drawing.Size(46, 13)
        REFFRALabel.TabIndex = 17
        REFFRALabel.Text = "Factura:"
        '
        'lb_fecha
        '
        lb_fecha.AutoSize = True
        lb_fecha.Location = New System.Drawing.Point(371, 20)
        lb_fecha.Name = "lb_fecha"
        lb_fecha.Size = New System.Drawing.Size(40, 13)
        lb_fecha.TabIndex = 85
        lb_fecha.Text = "Fecha:"
        '
        'ESTADOLabel
        '
        ESTADOLabel.AutoSize = True
        ESTADOLabel.Location = New System.Drawing.Point(99, 83)
        ESTADOLabel.Name = "ESTADOLabel"
        ESTADOLabel.Size = New System.Drawing.Size(50, 13)
        ESTADOLabel.TabIndex = 87
        ESTADOLabel.Text = "Cobrada:"
        '
        'tb_descripcion
        '
        Me.tb_descripcion.AcceptsReturn = True
        Me.tb_descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ANALITICASBindingSource, "DESCRIPCION", True))
        Me.tb_descripcion.Location = New System.Drawing.Point(492, 36)
        Me.tb_descripcion.MaxLength = 150
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(217, 20)
        Me.tb_descripcion.TabIndex = 4
        '
        'ANALITICASBindingSource
        '
        Me.ANALITICASBindingSource.DataMember = "ANALITICAS"
        Me.ANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_total
        '
        Me.tb_total.AcceptsReturn = True
        Me.tb_total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ANALITICASBindingSource, "IMPORTE", True))
        Me.tb_total.Location = New System.Drawing.Point(217, 242)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.ReadOnly = True
        Me.tb_total.Size = New System.Drawing.Size(145, 20)
        Me.tb_total.TabIndex = 2
        Me.tb_total.Text = "0,00"
        Me.tb_total.Visible = False
        '
        'tb_notas
        '
        Me.tb_notas.AcceptsReturn = True
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ANALITICASBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(5, 406)
        Me.tb_notas.MaxLength = 120
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.Size = New System.Drawing.Size(728, 62)
        Me.tb_notas.TabIndex = 0
        '
        'tb_factura
        '
        Me.tb_factura.AcceptsReturn = True
        Me.tb_factura.BackColor = System.Drawing.Color.White
        Me.tb_factura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ANALITICASBindingSource, "REFFRA", True))
        Me.tb_factura.Location = New System.Drawing.Point(7, 80)
        Me.tb_factura.Name = "tb_factura"
        Me.tb_factura.ReadOnly = True
        Me.tb_factura.Size = New System.Drawing.Size(85, 20)
        Me.tb_factura.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.ckRecibida)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(ESTADOLabel)
        Me.GroupBox1.Controls.Add(Me.chb_estado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tb_descripcion)
        Me.GroupBox1.Controls.Add(DESCRIPCIONLabel)
        Me.GroupBox1.Controls.Add(Me.bt_paciente)
        Me.GroupBox1.Controls.Add(lb_fecha)
        Me.GroupBox1.Controls.Add(Me.tb_factura)
        Me.GroupBox1.Controls.Add(REFFRALabel)
        Me.GroupBox1.Controls.Add(Me.dtp_femision)
        Me.GroupBox1.Controls.Add(Me.tb_idpaciente)
        Me.GroupBox1.Controls.Add(Me.tb_paciente)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 325)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cabezera de la analitica"
        '
        'chb_estado
        '
        Me.chb_estado.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ANALITICASBindingSource, "ESTADO", True))
        Me.chb_estado.Location = New System.Drawing.Point(153, 77)
        Me.chb_estado.Name = "chb_estado"
        Me.chb_estado.Size = New System.Drawing.Size(26, 24)
        Me.chb_estado.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Paciente"
        '
        'bt_paciente
        '
        Me.bt_paciente.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_paciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_paciente.Location = New System.Drawing.Point(102, 37)
        Me.bt_paciente.Name = "bt_paciente"
        Me.bt_paciente.Size = New System.Drawing.Size(36, 23)
        Me.bt_paciente.TabIndex = 1
        Me.bt_paciente.UseVisualStyleBackColor = True
        '
        'dtp_femision
        '
        Me.dtp_femision.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_femision.Location = New System.Drawing.Point(374, 36)
        Me.dtp_femision.Name = "dtp_femision"
        Me.dtp_femision.Size = New System.Drawing.Size(112, 20)
        Me.dtp_femision.TabIndex = 3
        '
        'tb_idpaciente
        '
        Me.tb_idpaciente.AcceptsReturn = True
        Me.tb_idpaciente.BackColor = System.Drawing.Color.White
        Me.tb_idpaciente.Location = New System.Drawing.Point(5, 37)
        Me.tb_idpaciente.Name = "tb_idpaciente"
        Me.tb_idpaciente.Size = New System.Drawing.Size(91, 20)
        Me.tb_idpaciente.TabIndex = 0
        '
        'tb_paciente
        '
        Me.tb_paciente.AcceptsReturn = True
        Me.tb_paciente.BackColor = System.Drawing.Color.White
        Me.tb_paciente.Location = New System.Drawing.Point(144, 37)
        Me.tb_paciente.MaxLength = 150
        Me.tb_paciente.Name = "tb_paciente"
        Me.tb_paciente.ReadOnly = True
        Me.tb_paciente.Size = New System.Drawing.Size(224, 20)
        Me.tb_paciente.TabIndex = 2
        '
        'bt_copiar
        '
        Me.bt_copiar.Location = New System.Drawing.Point(47, 236)
        Me.bt_copiar.Name = "bt_copiar"
        Me.bt_copiar.Size = New System.Drawing.Size(127, 52)
        Me.bt_copiar.TabIndex = 1
        Me.bt_copiar.Text = "Copiar Analisis desde  plantilla"
        Me.bt_copiar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox2.Controls.Add(Me.tb_buscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgv_disponibles)
        Me.GroupBox2.Controls.Add(Me.bt_izq)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 264)
        Me.GroupBox2.TabIndex = 112
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Analisis disponibles"
        '
        'tb_buscar
        '
        Me.tb_buscar.AcceptsReturn = True
        Me.tb_buscar.Location = New System.Drawing.Point(53, 16)
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(298, 20)
        Me.tb_buscar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar"
        '
        'dgv_disponibles
        '
        Me.dgv_disponibles.AllowUserToAddRows = False
        Me.dgv_disponibles.AllowUserToDeleteRows = False
        Me.dgv_disponibles.BackgroundColor = System.Drawing.Color.White
        Me.dgv_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_disponibles.Location = New System.Drawing.Point(7, 42)
        Me.dgv_disponibles.Name = "dgv_disponibles"
        Me.dgv_disponibles.ReadOnly = True
        Me.dgv_disponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_disponibles.Size = New System.Drawing.Size(344, 189)
        Me.dgv_disponibles.TabIndex = 1
        '
        'bt_izq
        '
        Me.bt_izq.BackgroundImage = Global.centro_medico.My.Resources.Resources._Next
        Me.bt_izq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_izq.Location = New System.Drawing.Point(315, 241)
        Me.bt_izq.Name = "bt_izq"
        Me.bt_izq.Size = New System.Drawing.Size(36, 20)
        Me.bt_izq.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.bt_izq, "Realizar Análisis")
        Me.bt_izq.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox3.Controls.Add(Me.dgv_realizar)
        Me.GroupBox3.Controls.Add(Me.bt_der)
        Me.GroupBox3.Controls.Add(Me.bt_copiar)
        Me.GroupBox3.Controls.Add(IMPORTELabel)
        Me.GroupBox3.Controls.Add(Me.tb_total)
        Me.GroupBox3.Location = New System.Drawing.Point(368, 113)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(365, 290)
        Me.GroupBox3.TabIndex = 113
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Analisis a Realizar"
        '
        'dgv_realizar
        '
        Me.dgv_realizar.AllowUserToAddRows = False
        Me.dgv_realizar.AllowUserToDeleteRows = False
        Me.dgv_realizar.BackgroundColor = System.Drawing.Color.White
        Me.dgv_realizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_realizar.Location = New System.Drawing.Point(11, 19)
        Me.dgv_realizar.Name = "dgv_realizar"
        Me.dgv_realizar.ReadOnly = True
        Me.dgv_realizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_realizar.Size = New System.Drawing.Size(344, 212)
        Me.dgv_realizar.TabIndex = 0
        '
        'bt_der
        '
        Me.bt_der.BackgroundImage = Global.centro_medico.My.Resources.Resources.Back
        Me.bt_der.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_der.Location = New System.Drawing.Point(6, 241)
        Me.bt_der.Name = "bt_der"
        Me.bt_der.Size = New System.Drawing.Size(36, 20)
        Me.bt_der.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.bt_der, "Realizar Análisis")
        Me.bt_der.UseVisualStyleBackColor = True
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(469, 483)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 28)
        Me.bt_imprimir.TabIndex = 2
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        Me.bt_imprimir.Visible = False
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(659, 483)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 4
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(565, 483)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 3
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'LINEASANALITICASBindingSource
        '
        Me.LINEASANALITICASBindingSource.DataMember = "fk_lineasanaliticas"
        Me.LINEASANALITICASBindingSource.DataSource = Me.ANALITICASBindingSource
        '
        'ANALITICASTableAdapter
        '
        Me.ANALITICASTableAdapter.ClearBeforeFill = True
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSANALITICABindingSource
        '
        Me.CONCEPTOSANALITICABindingSource.DataMember = "CONCEPTOSANALITICA"
        Me.CONCEPTOSANALITICABindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSANALITICATableAdapter
        '
        Me.CONCEPTOSANALITICATableAdapter.ClearBeforeFill = True
        '
        'FACTURASBindingSource
        '
        Me.FACTURASBindingSource.DataMember = "FACTURAS"
        Me.FACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'FACTURASTableAdapter
        '
        Me.FACTURASTableAdapter.ClearBeforeFill = True
        '
        'LINEASANALITICASTableAdapter
        '
        Me.LINEASANALITICASTableAdapter.ClearBeforeFill = True
        '
        'LPLANTILLAANALITICASBindingSource
        '
        Me.LPLANTILLAANALITICASBindingSource.DataMember = "LPLANTILLAANALITICAS"
        Me.LPLANTILLAANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'PLANTILLAANALITICASTableAdapter
        '
        Me.PLANTILLAANALITICASTableAdapter.ClearBeforeFill = True
        '
        'PLANTILLAANALITICASBindingSource
        '
        Me.PLANTILLAANALITICASBindingSource.DataMember = "PLANTILLAANALITICAS"
        Me.PLANTILLAANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'LPLANTILLAANALITICASTableAdapter
        '
        Me.LPLANTILLAANALITICASTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(199, 82)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 88
        Label2.Text = "Recibida:"
        '
        'ckRecibida
        '
        Me.ckRecibida.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ANALITICASBindingSource, "ESTADO", True))
        Me.ckRecibida.Location = New System.Drawing.Point(257, 77)
        Me.ckRecibida.Name = "ckRecibida"
        Me.ckRecibida.Size = New System.Drawing.Size(26, 23)
        Me.ckRecibida.TabIndex = 89
        '
        'form_analiticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(742, 518)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.tb_notas)
        Me.Name = "form_analiticas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_analiticas"
        CType(Me.ANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_disponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_realizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.ANALITICASTableAdapter
    Friend WithEvents tb_descripcion As ctrlTextboxAvanzado
    Friend WithEvents tb_total As ctrlTextboxAvanzado
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents tb_factura As ctrlTextboxAvanzado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_paciente As System.Windows.Forms.Button
    Friend WithEvents tb_idpaciente As ctrlTextboxAvanzado
    Friend WithEvents tb_paciente As ctrlTextboxAvanzado
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_femision As System.Windows.Forms.DateTimePicker
    Friend WithEvents chb_estado As System.Windows.Forms.CheckBox
    Friend WithEvents bt_copiar As System.Windows.Forms.Button
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_disponibles As System.Windows.Forms.DataGridView
    Friend WithEvents bt_izq As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_der As System.Windows.Forms.Button
    Friend WithEvents tb_buscar As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CONCEPTOSANALITICABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSANALITICATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSANALITICATableAdapter
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents dgv_realizar As System.Windows.Forms.DataGridView
    Friend WithEvents LINEASANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEASANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.LINEASANALITICASTableAdapter
    Friend WithEvents LPLANTILLAANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLANTILLAANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.PLANTILLAANALITICASTableAdapter
    Friend WithEvents PLANTILLAANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LPLANTILLAANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.LPLANTILLAANALITICASTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ckRecibida As System.Windows.Forms.CheckBox
End Class
