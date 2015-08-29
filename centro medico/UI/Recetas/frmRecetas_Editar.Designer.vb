Namespace UI.Recetas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmRecetas_Editar
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
            Me.components = New System.ComponentModel.Container()
            Dim FECHALabel As System.Windows.Forms.Label
            Dim TRATAMIENTOLabel As System.Windows.Forms.Label
            Dim Label2 As System.Windows.Forms.Label
            Dim DiagnosticoAlPacienteLabel As System.Windows.Forms.Label
            Dim NoOrdenDispensacionLabel As System.Windows.Forms.Label
            Dim InfoAlFarmaceuticoLabel As System.Windows.Forms.Label
            Dim FechaPrevistaDispensacionLabel As System.Windows.Forms.Label
            Dim DuracionTratamientoLabel As System.Windows.Forms.Label
            Dim PrescripcionLabel As System.Windows.Forms.Label
            Dim PacienteInfoLabel As System.Windows.Forms.Label
            Dim PosologiaLabel As System.Windows.Forms.Label
            Dim UnidadesLabel As System.Windows.Forms.Label
            Dim PautaLabel As System.Windows.Forms.Label
            Dim InstruccionesAlPacienteLabel As System.Windows.Forms.Label
            Dim PrescriptorLabel As System.Windows.Forms.Label
            Dim Label4 As System.Windows.Forms.Label
            Dim GridExMedicamentos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecetas_Editar))
            Me.bt_AplicarPlantilla = New System.Windows.Forms.Button()
            Me.bt_imprimir = New System.Windows.Forms.Button()
            Me.bt_cancel = New System.Windows.Forms.Button()
            Me.bt_aceptar = New System.Windows.Forms.Button()
            Me.DateTimeFecha = New System.Windows.Forms.DateTimePicker()
            Me.diagnostico = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GridExMedicamentos = New Janus.Windows.GridEX.GridEX()
            Me.RecetasMedicamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.RECETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.btDelMedicamento = New System.Windows.Forms.Button()
            Me.btAddMedicamento = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.DateTimeHora = New System.Windows.Forms.DateTimePicker()
            Me.BtnMutua = New System.Windows.Forms.Button()
            Me.bt_factura = New System.Windows.Forms.Button()
            Me.bt_medicamento = New System.Windows.Forms.Button()
            Me.pnlRegulares = New System.Windows.Forms.Panel()
            Me.editTratamiento = New centro_medico.ctrlTextboxAvanzado()
            Me.rbRegfulares = New System.Windows.Forms.RadioButton()
            Me.rbOficiales = New System.Windows.Forms.RadioButton()
            Me.pnlOficiales = New System.Windows.Forms.Panel()
            Me.chkFechaDispensacion = New System.Windows.Forms.CheckBox()
            Me.ChkUsarPrescriptorInfo = New System.Windows.Forms.CheckBox()
            Me.PrescriptorTextBox = New System.Windows.Forms.TextBox()
            Me.InstruccionesAlPacienteTextBox = New System.Windows.Forms.TextBox()
            Me.PautaTextBox = New System.Windows.Forms.TextBox()
            Me.UnidadesTextBox = New System.Windows.Forms.TextBox()
            Me.PosologiaTextBox = New System.Windows.Forms.TextBox()
            Me.PacienteInfoTextBox = New System.Windows.Forms.TextBox()
            Me.PrescripcionTextBox = New System.Windows.Forms.TextBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.DuracionTratamientoTextBox = New System.Windows.Forms.TextBox()
            Me.FechaPrevistaDispensacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
            Me.InfoAlFarmaceuticoTextBox = New System.Windows.Forms.TextBox()
            Me.NoOrdenDispensacionTextBox = New System.Windows.Forms.TextBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.DiagnosticoAlPacienteTextBox = New System.Windows.Forms.TextBox()
            Me.PLANTILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btAsociarReceta = New System.Windows.Forms.Button()
            Me.lblCVE = New System.Windows.Forms.Label()
            Me.CtrlMedicamentoReceta = New centro_medico.ctrlMedicamento()
            Me.CtrlPacienteReceta = New centro_medico.ctrlPaciente2()
            Me.CtrlMedicoReceta = New centro_medico.ctrlMedico()
            Me.CtrlDiagnosticosReceta = New centro_medico.ctrlDiagnosticos()
            FECHALabel = New System.Windows.Forms.Label()
            TRATAMIENTOLabel = New System.Windows.Forms.Label()
            Label2 = New System.Windows.Forms.Label()
            DiagnosticoAlPacienteLabel = New System.Windows.Forms.Label()
            NoOrdenDispensacionLabel = New System.Windows.Forms.Label()
            InfoAlFarmaceuticoLabel = New System.Windows.Forms.Label()
            FechaPrevistaDispensacionLabel = New System.Windows.Forms.Label()
            DuracionTratamientoLabel = New System.Windows.Forms.Label()
            PrescripcionLabel = New System.Windows.Forms.Label()
            PacienteInfoLabel = New System.Windows.Forms.Label()
            PosologiaLabel = New System.Windows.Forms.Label()
            UnidadesLabel = New System.Windows.Forms.Label()
            PautaLabel = New System.Windows.Forms.Label()
            InstruccionesAlPacienteLabel = New System.Windows.Forms.Label()
            PrescriptorLabel = New System.Windows.Forms.Label()
            Label4 = New System.Windows.Forms.Label()
            CType(Me.GridExMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RecetasMedicamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RECETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlRegulares.SuspendLayout()
            Me.pnlOficiales.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PLANTILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'FECHALabel
            '
            FECHALabel.AutoSize = True
            FECHALabel.Location = New System.Drawing.Point(515, 30)
            FECHALabel.Name = "FECHALabel"
            FECHALabel.Size = New System.Drawing.Size(96, 13)
            FECHALabel.TabIndex = 0
            FECHALabel.Text = "Fecha de emisión :"
            '
            'TRATAMIENTOLabel
            '
            TRATAMIENTOLabel.AutoSize = True
            TRATAMIENTOLabel.Location = New System.Drawing.Point(496, 5)
            TRATAMIENTOLabel.Name = "TRATAMIENTOLabel"
            TRATAMIENTOLabel.Size = New System.Drawing.Size(142, 13)
            TRATAMIENTOLabel.TabIndex = 0
            TRATAMIENTOLabel.Text = "Texto editable por el doctor.:"
            '
            'Label2
            '
            Label2.AutoSize = True
            Label2.Location = New System.Drawing.Point(622, 30)
            Label2.Name = "Label2"
            Label2.Size = New System.Drawing.Size(33, 13)
            Label2.TabIndex = 0
            Label2.Text = "Hora:"
            '
            'DiagnosticoAlPacienteLabel
            '
            DiagnosticoAlPacienteLabel.AutoSize = True
            DiagnosticoAlPacienteLabel.Location = New System.Drawing.Point(510, 133)
            DiagnosticoAlPacienteLabel.Name = "DiagnosticoAlPacienteLabel"
            DiagnosticoAlPacienteLabel.Size = New System.Drawing.Size(277, 13)
            DiagnosticoAlPacienteLabel.TabIndex = 0
            DiagnosticoAlPacienteLabel.Text = "Diagnóstico/s (si procede) , para uso en la Receta Oficial"
            '
            'NoOrdenDispensacionLabel
            '
            NoOrdenDispensacionLabel.AutoSize = True
            NoOrdenDispensacionLabel.Location = New System.Drawing.Point(441, 176)
            NoOrdenDispensacionLabel.Name = "NoOrdenDispensacionLabel"
            NoOrdenDispensacionLabel.Size = New System.Drawing.Size(123, 13)
            NoOrdenDispensacionLabel.TabIndex = 2
            NoOrdenDispensacionLabel.Text = "No Orden Dispensacion:"
            '
            'InfoAlFarmaceuticoLabel
            '
            InfoAlFarmaceuticoLabel.AutoSize = True
            InfoAlFarmaceuticoLabel.Location = New System.Drawing.Point(0, 176)
            InfoAlFarmaceuticoLabel.Name = "InfoAlFarmaceuticoLabel"
            InfoAlFarmaceuticoLabel.Size = New System.Drawing.Size(195, 13)
            InfoAlFarmaceuticoLabel.TabIndex = 4
            InfoAlFarmaceuticoLabel.Text = "Información al farmacéutico (si procede)"
            '
            'FechaPrevistaDispensacionLabel
            '
            FechaPrevistaDispensacionLabel.AutoSize = True
            FechaPrevistaDispensacionLabel.Location = New System.Drawing.Point(440, 224)
            FechaPrevistaDispensacionLabel.Name = "FechaPrevistaDispensacionLabel"
            FechaPrevistaDispensacionLabel.Size = New System.Drawing.Size(148, 13)
            FechaPrevistaDispensacionLabel.TabIndex = 6
            FechaPrevistaDispensacionLabel.Text = "Fecha Prevista Dispensacion:"
            '
            'DuracionTratamientoLabel
            '
            DuracionTratamientoLabel.AutoSize = True
            DuracionTratamientoLabel.Location = New System.Drawing.Point(431, 10)
            DuracionTratamientoLabel.Name = "DuracionTratamientoLabel"
            DuracionTratamientoLabel.Size = New System.Drawing.Size(112, 13)
            DuracionTratamientoLabel.TabIndex = 8
            DuracionTratamientoLabel.Text = "Duracion Tratamiento:"
            '
            'PrescripcionLabel
            '
            PrescripcionLabel.AutoSize = True
            PrescripcionLabel.Location = New System.Drawing.Point(0, 10)
            PrescripcionLabel.Name = "PrescripcionLabel"
            PrescripcionLabel.Size = New System.Drawing.Size(68, 13)
            PrescripcionLabel.TabIndex = 12
            PrescripcionLabel.Text = "Prescripcion:"
            '
            'PacienteInfoLabel
            '
            PacienteInfoLabel.AutoSize = True
            PacienteInfoLabel.Location = New System.Drawing.Point(623, 10)
            PacienteInfoLabel.Name = "PacienteInfoLabel"
            PacienteInfoLabel.Size = New System.Drawing.Size(52, 13)
            PacienteInfoLabel.TabIndex = 14
            PacienteInfoLabel.Text = "Paciente:"
            '
            'PosologiaLabel
            '
            PosologiaLabel.AutoSize = True
            PosologiaLabel.Location = New System.Drawing.Point(431, 55)
            PosologiaLabel.Name = "PosologiaLabel"
            PosologiaLabel.Size = New System.Drawing.Size(56, 13)
            PosologiaLabel.TabIndex = 16
            PosologiaLabel.Text = "Posologia:"
            '
            'UnidadesLabel
            '
            UnidadesLabel.AutoSize = True
            UnidadesLabel.Location = New System.Drawing.Point(432, 105)
            UnidadesLabel.Name = "UnidadesLabel"
            UnidadesLabel.Size = New System.Drawing.Size(55, 13)
            UnidadesLabel.TabIndex = 18
            UnidadesLabel.Text = "Unidades:"
            '
            'PautaLabel
            '
            PautaLabel.AutoSize = True
            PautaLabel.Location = New System.Drawing.Point(505, 105)
            PautaLabel.Name = "PautaLabel"
            PautaLabel.Size = New System.Drawing.Size(38, 13)
            PautaLabel.TabIndex = 20
            PautaLabel.Text = "Pauta:"
            '
            'InstruccionesAlPacienteLabel
            '
            InstruccionesAlPacienteLabel.AutoSize = True
            InstruccionesAlPacienteLabel.Location = New System.Drawing.Point(-3, 288)
            InstruccionesAlPacienteLabel.Name = "InstruccionesAlPacienteLabel"
            InstruccionesAlPacienteLabel.Size = New System.Drawing.Size(129, 13)
            InstruccionesAlPacienteLabel.TabIndex = 21
            InstruccionesAlPacienteLabel.Text = "Instrucciones al Paciente:"
            '
            'PrescriptorLabel
            '
            PrescriptorLabel.AutoSize = True
            PrescriptorLabel.Location = New System.Drawing.Point(623, 176)
            PrescriptorLabel.Name = "PrescriptorLabel"
            PrescriptorLabel.Size = New System.Drawing.Size(60, 13)
            PrescriptorLabel.TabIndex = 22
            PrescriptorLabel.Text = "Prescriptor:"
            '
            'Label4
            '
            Label4.AutoSize = True
            Label4.Location = New System.Drawing.Point(267, 10)
            Label4.Name = "Label4"
            Label4.Size = New System.Drawing.Size(121, 13)
            Label4.TabIndex = 12
            Label4.Text = "No. envases/ unidades:"
            '
            'bt_AplicarPlantilla
            '
            Me.bt_AplicarPlantilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bt_AplicarPlantilla.Location = New System.Drawing.Point(2, 308)
            Me.bt_AplicarPlantilla.Name = "bt_AplicarPlantilla"
            Me.bt_AplicarPlantilla.Size = New System.Drawing.Size(91, 28)
            Me.bt_AplicarPlantilla.TabIndex = 12
            Me.bt_AplicarPlantilla.Text = "Aplicar Plantilla"
            Me.bt_AplicarPlantilla.UseVisualStyleBackColor = True
            '
            'bt_imprimir
            '
            Me.bt_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
            Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bt_imprimir.Location = New System.Drawing.Point(741, 528)
            Me.bt_imprimir.Name = "bt_imprimir"
            Me.bt_imprimir.Size = New System.Drawing.Size(75, 28)
            Me.bt_imprimir.TabIndex = 17
            Me.bt_imprimir.Text = "Imprimir"
            Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bt_imprimir.UseVisualStyleBackColor = True
            '
            'bt_cancel
            '
            Me.bt_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
            Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bt_cancel.Location = New System.Drawing.Point(933, 528)
            Me.bt_cancel.Name = "bt_cancel"
            Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
            Me.bt_cancel.TabIndex = 19
            Me.bt_cancel.Text = "Cancelar"
            Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bt_cancel.UseVisualStyleBackColor = True
            '
            'bt_aceptar
            '
            Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
            Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bt_aceptar.Location = New System.Drawing.Point(839, 528)
            Me.bt_aceptar.Name = "bt_aceptar"
            Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
            Me.bt_aceptar.TabIndex = 18
            Me.bt_aceptar.Text = "Aceptar"
            Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bt_aceptar.UseVisualStyleBackColor = True
            '
            'DateTimeFecha
            '
            Me.DateTimeFecha.CalendarMonthBackground = System.Drawing.Color.White
            Me.DateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimeFecha.Location = New System.Drawing.Point(513, 47)
            Me.DateTimeFecha.Name = "DateTimeFecha"
            Me.DateTimeFecha.Size = New System.Drawing.Size(101, 20)
            Me.DateTimeFecha.TabIndex = 4
            '
            'diagnostico
            '
            Me.diagnostico.AutoSize = True
            Me.diagnostico.Location = New System.Drawing.Point(510, 80)
            Me.diagnostico.Name = "diagnostico"
            Me.diagnostico.Size = New System.Drawing.Size(66, 13)
            Me.diagnostico.TabIndex = 0
            Me.diagnostico.Text = "Diágnostico:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 31)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(52, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Paciente:"
            '
            'GridExMedicamentos
            '
            Me.GridExMedicamentos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
            Me.GridExMedicamentos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.GridExMedicamentos.ColumnAutoResize = True
            Me.GridExMedicamentos.DataSource = Me.RecetasMedicamentosBindingSource
            GridExMedicamentos_DesignTimeLayout.LayoutString = resources.GetString("GridExMedicamentos_DesignTimeLayout.LayoutString")
            Me.GridExMedicamentos.DesignTimeLayout = GridExMedicamentos_DesignTimeLayout
            Me.GridExMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.GridExMedicamentos.GroupByBoxVisible = False
            Me.GridExMedicamentos.Location = New System.Drawing.Point(4, 5)
            Me.GridExMedicamentos.Name = "GridExMedicamentos"
            Me.GridExMedicamentos.Size = New System.Drawing.Size(460, 297)
            Me.GridExMedicamentos.TabIndex = 0
            '
            'RecetasMedicamentosBindingSource
            '
            Me.RecetasMedicamentosBindingSource.DataMember = "RecetasMedicamentos"
            Me.RecetasMedicamentosBindingSource.DataSource = Me.RECETABindingSource
            '
            'RECETABindingSource
            '
            Me.RECETABindingSource.DataSource = GetType(centro_medico.RECETA)
            '
            'btDelMedicamento
            '
            Me.btDelMedicamento.BackColor = System.Drawing.SystemColors.Control
            Me.btDelMedicamento.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_cross
            Me.btDelMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btDelMedicamento.FlatAppearance.BorderSize = 0
            Me.btDelMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btDelMedicamento.Location = New System.Drawing.Point(470, 50)
            Me.btDelMedicamento.Name = "btDelMedicamento"
            Me.btDelMedicamento.Size = New System.Drawing.Size(23, 34)
            Me.btDelMedicamento.TabIndex = 11
            Me.btDelMedicamento.UseVisualStyleBackColor = False
            '
            'btAddMedicamento
            '
            Me.btAddMedicamento.BackColor = System.Drawing.SystemColors.Control
            Me.btAddMedicamento.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_plus
            Me.btAddMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btAddMedicamento.FlatAppearance.BorderSize = 0
            Me.btAddMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btAddMedicamento.Location = New System.Drawing.Point(470, 21)
            Me.btAddMedicamento.Name = "btAddMedicamento"
            Me.btAddMedicamento.Size = New System.Drawing.Size(23, 23)
            Me.btAddMedicamento.TabIndex = 10
            Me.btAddMedicamento.UseVisualStyleBackColor = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 133)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(120, 13)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Medicamento Principal :"
            '
            'DateTimeHora
            '
            Me.DateTimeHora.CustomFormat = "HH:mm"
            Me.DateTimeHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
            Me.DateTimeHora.Location = New System.Drawing.Point(620, 47)
            Me.DateTimeHora.Name = "DateTimeHora"
            Me.DateTimeHora.ShowUpDown = True
            Me.DateTimeHora.Size = New System.Drawing.Size(89, 20)
            Me.DateTimeHora.TabIndex = 5
            '
            'BtnMutua
            '
            Me.BtnMutua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnMutua.BackColor = System.Drawing.SystemColors.Control
            Me.BtnMutua.BackgroundImage = Global.centro_medico.My.Resources.Resources.Mutuas
            Me.BtnMutua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.BtnMutua.FlatAppearance.BorderSize = 0
            Me.BtnMutua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnMutua.Location = New System.Drawing.Point(511, 528)
            Me.BtnMutua.Name = "BtnMutua"
            Me.BtnMutua.Size = New System.Drawing.Size(43, 36)
            Me.BtnMutua.TabIndex = 14
            Me.BtnMutua.UseVisualStyleBackColor = False
            '
            'bt_factura
            '
            Me.bt_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.bt_factura.BackColor = System.Drawing.SystemColors.Control
            Me.bt_factura.BackgroundImage = Global.centro_medico.My.Resources.Resources.Facturas
            Me.bt_factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.bt_factura.FlatAppearance.BorderSize = 0
            Me.bt_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bt_factura.Location = New System.Drawing.Point(560, 528)
            Me.bt_factura.Name = "bt_factura"
            Me.bt_factura.Size = New System.Drawing.Size(40, 38)
            Me.bt_factura.TabIndex = 15
            Me.bt_factura.UseVisualStyleBackColor = False
            Me.bt_factura.Visible = False
            '
            'bt_medicamento
            '
            Me.bt_medicamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bt_medicamento.BackColor = System.Drawing.SystemColors.Control
            Me.bt_medicamento.BackgroundImage = Global.centro_medico.My.Resources.Resources.Partes
            Me.bt_medicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.bt_medicamento.FlatAppearance.BorderSize = 0
            Me.bt_medicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bt_medicamento.Location = New System.Drawing.Point(323, 304)
            Me.bt_medicamento.Name = "bt_medicamento"
            Me.bt_medicamento.Size = New System.Drawing.Size(41, 36)
            Me.bt_medicamento.TabIndex = 13
            Me.bt_medicamento.UseVisualStyleBackColor = False
            '
            'pnlRegulares
            '
            Me.pnlRegulares.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlRegulares.Controls.Add(Me.GridExMedicamentos)
            Me.pnlRegulares.Controls.Add(Me.editTratamiento)
            Me.pnlRegulares.Controls.Add(Me.bt_medicamento)
            Me.pnlRegulares.Controls.Add(Me.bt_AplicarPlantilla)
            Me.pnlRegulares.Controls.Add(TRATAMIENTOLabel)
            Me.pnlRegulares.Controls.Add(Me.btAddMedicamento)
            Me.pnlRegulares.Controls.Add(Me.btDelMedicamento)
            Me.pnlRegulares.Location = New System.Drawing.Point(12, 179)
            Me.pnlRegulares.Name = "pnlRegulares"
            Me.pnlRegulares.Size = New System.Drawing.Size(996, 343)
            Me.pnlRegulares.TabIndex = 20
            Me.pnlRegulares.Visible = False
            '
            'editTratamiento
            '
            Me.editTratamiento.AcceptsReturn = True
            Me.editTratamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.editTratamiento.Location = New System.Drawing.Point(499, 21)
            Me.editTratamiento.Multiline = True
            Me.editTratamiento.Name = "editTratamiento"
            Me.editTratamiento.Size = New System.Drawing.Size(494, 281)
            Me.editTratamiento.TabIndex = 16
            '
            'rbRegfulares
            '
            Me.rbRegfulares.AutoSize = True
            Me.rbRegfulares.BackColor = System.Drawing.Color.Transparent
            Me.rbRegfulares.Location = New System.Drawing.Point(127, 3)
            Me.rbRegfulares.Name = "rbRegfulares"
            Me.rbRegfulares.Size = New System.Drawing.Size(95, 17)
            Me.rbRegfulares.TabIndex = 22
            Me.rbRegfulares.Text = "Receta regular"
            Me.rbRegfulares.UseVisualStyleBackColor = False
            '
            'rbOficiales
            '
            Me.rbOficiales.AutoSize = True
            Me.rbOficiales.BackColor = System.Drawing.Color.Transparent
            Me.rbOficiales.Checked = True
            Me.rbOficiales.Location = New System.Drawing.Point(16, 3)
            Me.rbOficiales.Name = "rbOficiales"
            Me.rbOficiales.Size = New System.Drawing.Size(92, 17)
            Me.rbOficiales.TabIndex = 22
            Me.rbOficiales.TabStop = True
            Me.rbOficiales.Text = "Receta Oficial"
            Me.rbOficiales.UseVisualStyleBackColor = False
            '
            'pnlOficiales
            '
            Me.pnlOficiales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlOficiales.Controls.Add(Me.chkFechaDispensacion)
            Me.pnlOficiales.Controls.Add(Me.ChkUsarPrescriptorInfo)
            Me.pnlOficiales.Controls.Add(PrescriptorLabel)
            Me.pnlOficiales.Controls.Add(Me.PrescriptorTextBox)
            Me.pnlOficiales.Controls.Add(InstruccionesAlPacienteLabel)
            Me.pnlOficiales.Controls.Add(Me.InstruccionesAlPacienteTextBox)
            Me.pnlOficiales.Controls.Add(PautaLabel)
            Me.pnlOficiales.Controls.Add(Me.PautaTextBox)
            Me.pnlOficiales.Controls.Add(UnidadesLabel)
            Me.pnlOficiales.Controls.Add(Me.UnidadesTextBox)
            Me.pnlOficiales.Controls.Add(PosologiaLabel)
            Me.pnlOficiales.Controls.Add(Me.PosologiaTextBox)
            Me.pnlOficiales.Controls.Add(PacienteInfoLabel)
            Me.pnlOficiales.Controls.Add(Me.PacienteInfoTextBox)
            Me.pnlOficiales.Controls.Add(Label4)
            Me.pnlOficiales.Controls.Add(PrescripcionLabel)
            Me.pnlOficiales.Controls.Add(Me.PrescripcionTextBox)
            Me.pnlOficiales.Controls.Add(DuracionTratamientoLabel)
            Me.pnlOficiales.Controls.Add(Me.TextBox1)
            Me.pnlOficiales.Controls.Add(Me.DuracionTratamientoTextBox)
            Me.pnlOficiales.Controls.Add(FechaPrevistaDispensacionLabel)
            Me.pnlOficiales.Controls.Add(Me.FechaPrevistaDispensacionDateTimePicker)
            Me.pnlOficiales.Controls.Add(InfoAlFarmaceuticoLabel)
            Me.pnlOficiales.Controls.Add(Me.InfoAlFarmaceuticoTextBox)
            Me.pnlOficiales.Controls.Add(NoOrdenDispensacionLabel)
            Me.pnlOficiales.Controls.Add(Me.NoOrdenDispensacionTextBox)
            Me.pnlOficiales.Location = New System.Drawing.Point(12, 179)
            Me.pnlOficiales.Name = "pnlOficiales"
            Me.pnlOficiales.Size = New System.Drawing.Size(996, 346)
            Me.pnlOficiales.TabIndex = 23
            '
            'chkFechaDispensacion
            '
            Me.chkFechaDispensacion.AutoSize = True
            Me.chkFechaDispensacion.Location = New System.Drawing.Point(448, 245)
            Me.chkFechaDispensacion.Name = "chkFechaDispensacion"
            Me.chkFechaDispensacion.Size = New System.Drawing.Size(15, 14)
            Me.chkFechaDispensacion.TabIndex = 25
            Me.chkFechaDispensacion.UseVisualStyleBackColor = True
            '
            'ChkUsarPrescriptorInfo
            '
            Me.ChkUsarPrescriptorInfo.AutoSize = True
            Me.ChkUsarPrescriptorInfo.Checked = True
            Me.ChkUsarPrescriptorInfo.CheckState = System.Windows.Forms.CheckState.Checked
            Me.ChkUsarPrescriptorInfo.Location = New System.Drawing.Point(764, 175)
            Me.ChkUsarPrescriptorInfo.Name = "ChkUsarPrescriptorInfo"
            Me.ChkUsarPrescriptorInfo.Size = New System.Drawing.Size(217, 17)
            Me.ChkUsarPrescriptorInfo.TabIndex = 24
            Me.ChkUsarPrescriptorInfo.Text = "No Usar Info Medico (receta preimpresa)"
            Me.ChkUsarPrescriptorInfo.UseVisualStyleBackColor = True
            '
            'PrescriptorTextBox
            '
            Me.PrescriptorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "Prescriptor", True))
            Me.PrescriptorTextBox.Location = New System.Drawing.Point(626, 196)
            Me.PrescriptorTextBox.Multiline = True
            Me.PrescriptorTextBox.Name = "PrescriptorTextBox"
            Me.PrescriptorTextBox.ReadOnly = True
            Me.PrescriptorTextBox.Size = New System.Drawing.Size(355, 140)
            Me.PrescriptorTextBox.TabIndex = 23
            '
            'InstruccionesAlPacienteTextBox
            '
            Me.InstruccionesAlPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "InstruccionesAlPaciente", True))
            Me.InstruccionesAlPacienteTextBox.Location = New System.Drawing.Point(0, 306)
            Me.InstruccionesAlPacienteTextBox.Multiline = True
            Me.InstruccionesAlPacienteTextBox.Name = "InstruccionesAlPacienteTextBox"
            Me.InstruccionesAlPacienteTextBox.Size = New System.Drawing.Size(620, 33)
            Me.InstruccionesAlPacienteTextBox.TabIndex = 8
            '
            'PautaTextBox
            '
            Me.PautaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "Pauta", True))
            Me.PautaTextBox.Location = New System.Drawing.Point(506, 123)
            Me.PautaTextBox.Name = "PautaTextBox"
            Me.PautaTextBox.Size = New System.Drawing.Size(100, 20)
            Me.PautaTextBox.TabIndex = 4
            '
            'UnidadesTextBox
            '
            Me.UnidadesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "Unidades", True))
            Me.UnidadesTextBox.Location = New System.Drawing.Point(434, 123)
            Me.UnidadesTextBox.Name = "UnidadesTextBox"
            Me.UnidadesTextBox.Size = New System.Drawing.Size(63, 20)
            Me.UnidadesTextBox.TabIndex = 3
            '
            'PosologiaTextBox
            '
            Me.PosologiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "Posologia", True))
            Me.PosologiaTextBox.Location = New System.Drawing.Point(433, 73)
            Me.PosologiaTextBox.Name = "PosologiaTextBox"
            Me.PosologiaTextBox.Size = New System.Drawing.Size(169, 20)
            Me.PosologiaTextBox.TabIndex = 2
            '
            'PacienteInfoTextBox
            '
            Me.PacienteInfoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "PacienteInfo", True))
            Me.PacienteInfoTextBox.Location = New System.Drawing.Point(626, 28)
            Me.PacienteInfoTextBox.Multiline = True
            Me.PacienteInfoTextBox.Name = "PacienteInfoTextBox"
            Me.PacienteInfoTextBox.Size = New System.Drawing.Size(355, 115)
            Me.PacienteInfoTextBox.TabIndex = 15
            '
            'PrescripcionTextBox
            '
            Me.PrescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "Prescripcion", True))
            Me.PrescripcionTextBox.Location = New System.Drawing.Point(1, 28)
            Me.PrescripcionTextBox.Multiline = True
            Me.PrescripcionTextBox.Name = "PrescripcionTextBox"
            Me.PrescripcionTextBox.Size = New System.Drawing.Size(424, 142)
            Me.PrescripcionTextBox.TabIndex = 0
            '
            'TextBox1
            '
            Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "NoEnvases_o_Unidades", True))
            Me.TextBox1.Location = New System.Drawing.Point(394, 7)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(31, 20)
            Me.TextBox1.TabIndex = 1
            '
            'DuracionTratamientoTextBox
            '
            Me.DuracionTratamientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "DuracionTratamiento", True))
            Me.DuracionTratamientoTextBox.Location = New System.Drawing.Point(433, 28)
            Me.DuracionTratamientoTextBox.Name = "DuracionTratamientoTextBox"
            Me.DuracionTratamientoTextBox.Size = New System.Drawing.Size(169, 20)
            Me.DuracionTratamientoTextBox.TabIndex = 1
            '
            'FechaPrevistaDispensacionDateTimePicker
            '
            Me.FechaPrevistaDispensacionDateTimePicker.Checked = False
            Me.FechaPrevistaDispensacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RECETABindingSource, "FechaPrevistaDispensacion", True))
            Me.FechaPrevistaDispensacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.FechaPrevistaDispensacionDateTimePicker.Location = New System.Drawing.Point(470, 242)
            Me.FechaPrevistaDispensacionDateTimePicker.Name = "FechaPrevistaDispensacionDateTimePicker"
            Me.FechaPrevistaDispensacionDateTimePicker.Size = New System.Drawing.Size(118, 20)
            Me.FechaPrevistaDispensacionDateTimePicker.TabIndex = 9
            '
            'InfoAlFarmaceuticoTextBox
            '
            Me.InfoAlFarmaceuticoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "InfoAlFarmaceutico", True))
            Me.InfoAlFarmaceuticoTextBox.Location = New System.Drawing.Point(0, 196)
            Me.InfoAlFarmaceuticoTextBox.Multiline = True
            Me.InfoAlFarmaceuticoTextBox.Name = "InfoAlFarmaceuticoTextBox"
            Me.InfoAlFarmaceuticoTextBox.Size = New System.Drawing.Size(425, 20)
            Me.InfoAlFarmaceuticoTextBox.TabIndex = 6
            '
            'NoOrdenDispensacionTextBox
            '
            Me.NoOrdenDispensacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "NoOrdenDispensacion", True))
            Me.NoOrdenDispensacionTextBox.Location = New System.Drawing.Point(437, 196)
            Me.NoOrdenDispensacionTextBox.Name = "NoOrdenDispensacionTextBox"
            Me.NoOrdenDispensacionTextBox.Size = New System.Drawing.Size(169, 20)
            Me.NoOrdenDispensacionTextBox.TabIndex = 5
            '
            'PictureBox1
            '
            Me.PictureBox1.Location = New System.Drawing.Point(56, 42)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(174, 25)
            Me.PictureBox1.TabIndex = 25
            Me.PictureBox1.TabStop = False
            '
            'DiagnosticoAlPacienteTextBox
            '
            Me.DiagnosticoAlPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "DiagnosticoAlPaciente", True))
            Me.DiagnosticoAlPacienteTextBox.Location = New System.Drawing.Point(512, 149)
            Me.DiagnosticoAlPacienteTextBox.Multiline = True
            Me.DiagnosticoAlPacienteTextBox.Name = "DiagnosticoAlPacienteTextBox"
            Me.DiagnosticoAlPacienteTextBox.Size = New System.Drawing.Size(498, 24)
            Me.DiagnosticoAlPacienteTextBox.TabIndex = 7
            '
            'PLANTILLABindingSource
            '
            Me.PLANTILLABindingSource.DataSource = GetType(centro_medico.PLANTILLA)
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.PictureBox1)
            Me.GroupBox1.Controls.Add(Me.btAsociarReceta)
            Me.GroupBox1.Controls.Add(Me.lblCVE)
            Me.GroupBox1.Location = New System.Drawing.Point(728, 2)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(280, 88)
            Me.GroupBox1.TabIndex = 24
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Receta Colegio"
            '
            'btAsociarReceta
            '
            Me.btAsociarReceta.Location = New System.Drawing.Point(10, 19)
            Me.btAsociarReceta.Name = "btAsociarReceta"
            Me.btAsociarReceta.Size = New System.Drawing.Size(266, 23)
            Me.btAsociarReceta.TabIndex = 1
            Me.btAsociarReceta.Text = "Vincular Receta"
            Me.btAsociarReceta.UseVisualStyleBackColor = True
            '
            'lblCVE
            '
            Me.lblCVE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCVE.Location = New System.Drawing.Point(7, 69)
            Me.lblCVE.Name = "lblCVE"
            Me.lblCVE.Size = New System.Drawing.Size(267, 16)
            Me.lblCVE.TabIndex = 0
            Me.lblCVE.Text = "Label5"
            Me.lblCVE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'CtrlMedicamentoReceta
            '
            Me.CtrlMedicamentoReceta.DataBindings.Add(New System.Windows.Forms.Binding("ID_Medicamento", Me.RECETABindingSource, "REFMEDICAMENTO", True))
            Me.CtrlMedicamentoReceta.ID_Medicamento = Nothing
            Me.CtrlMedicamentoReceta.Location = New System.Drawing.Point(12, 149)
            Me.CtrlMedicamentoReceta.Name = "CtrlMedicamentoReceta"
            Me.CtrlMedicamentoReceta.Size = New System.Drawing.Size(466, 24)
            Me.CtrlMedicamentoReceta.TabIndex = 8
            '
            'CtrlPacienteReceta
            '
            Me.CtrlPacienteReceta.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.RECETABindingSource, "REFPACIENTE", True))
            Me.CtrlPacienteReceta.ID_PACIENTE = Nothing
            Me.CtrlPacienteReceta.Location = New System.Drawing.Point(12, 47)
            Me.CtrlPacienteReceta.Name = "CtrlPacienteReceta"
            Me.CtrlPacienteReceta.Size = New System.Drawing.Size(466, 26)
            Me.CtrlPacienteReceta.TabIndex = 2
            '
            'CtrlMedicoReceta
            '
            Me.CtrlMedicoReceta.DataBindings.Add(New System.Windows.Forms.Binding("ID_Medico", Me.RECETABindingSource, "REFMEDICO", True))
            Me.CtrlMedicoReceta.ID_Medico = Nothing
            Me.CtrlMedicoReceta.Location = New System.Drawing.Point(12, 79)
            Me.CtrlMedicoReceta.Name = "CtrlMedicoReceta"
            Me.CtrlMedicoReceta.Size = New System.Drawing.Size(463, 42)
            Me.CtrlMedicoReceta.TabIndex = 3
            '
            'CtrlDiagnosticosReceta
            '
            Me.CtrlDiagnosticosReceta.DataBindings.Add(New System.Windows.Forms.Binding("ID_DIAGNOSTICOS", Me.RECETABindingSource, "REFDIAGNOSTICO", True))
            Me.CtrlDiagnosticosReceta.ID_DIAGNOSTICOS = Nothing
            Me.CtrlDiagnosticosReceta.Location = New System.Drawing.Point(513, 96)
            Me.CtrlDiagnosticosReceta.Name = "CtrlDiagnosticosReceta"
            Me.CtrlDiagnosticosReceta.Size = New System.Drawing.Size(497, 25)
            Me.CtrlDiagnosticosReceta.TabIndex = 7
            '
            'frmRecetas_Editar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1020, 567)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.pnlOficiales)
            Me.Controls.Add(Me.rbOficiales)
            Me.Controls.Add(Me.rbRegfulares)
            Me.Controls.Add(Me.pnlRegulares)
            Me.Controls.Add(Me.bt_factura)
            Me.Controls.Add(Me.BtnMutua)
            Me.Controls.Add(Me.DateTimeHora)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.CtrlMedicamentoReceta)
            Me.Controls.Add(Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.diagnostico)
            Me.Controls.Add(Me.CtrlPacienteReceta)
            Me.Controls.Add(Me.CtrlMedicoReceta)
            Me.Controls.Add(Me.CtrlDiagnosticosReceta)
            Me.Controls.Add(Me.bt_imprimir)
            Me.Controls.Add(Me.bt_cancel)
            Me.Controls.Add(Me.bt_aceptar)
            Me.Controls.Add(FECHALabel)
            Me.Controls.Add(Me.DateTimeFecha)
            Me.Controls.Add(DiagnosticoAlPacienteLabel)
            Me.Controls.Add(Me.DiagnosticoAlPacienteTextBox)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(1022, 600)
            Me.Name = "frmRecetas_Editar"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Recetas"
            CType(Me.GridExMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RecetasMedicamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RECETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlRegulares.ResumeLayout(False)
            Me.pnlRegulares.PerformLayout()
            Me.pnlOficiales.ResumeLayout(False)
            Me.pnlOficiales.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PLANTILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents bt_AplicarPlantilla As System.Windows.Forms.Button
        Friend WithEvents bt_imprimir As System.Windows.Forms.Button
        Friend WithEvents bt_cancel As System.Windows.Forms.Button
        Friend WithEvents bt_aceptar As System.Windows.Forms.Button
        Friend WithEvents DateTimeFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents CtrlDiagnosticosReceta As centro_medico.ctrlDiagnosticos
        Friend WithEvents CtrlMedicoReceta As centro_medico.ctrlMedico
        Friend WithEvents CtrlPacienteReceta As centro_medico.ctrlPaciente2
        Friend WithEvents diagnostico As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GridExMedicamentos As Janus.Windows.GridEX.GridEX
        Friend WithEvents btDelMedicamento As System.Windows.Forms.Button
        Friend WithEvents btAddMedicamento As System.Windows.Forms.Button
        Friend WithEvents CtrlMedicamentoReceta As centro_medico.ctrlMedicamento
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateTimeHora As System.Windows.Forms.DateTimePicker
        Friend WithEvents PLANTILLABindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents BtnMutua As System.Windows.Forms.Button
        Friend WithEvents bt_factura As System.Windows.Forms.Button
        Friend WithEvents bt_medicamento As System.Windows.Forms.Button
        Friend WithEvents editTratamiento As centro_medico.ctrlTextboxAvanzado
        Friend WithEvents pnlRegulares As System.Windows.Forms.Panel
        Friend WithEvents rbRegfulares As System.Windows.Forms.RadioButton
        Friend WithEvents rbOficiales As System.Windows.Forms.RadioButton
        Friend WithEvents pnlOficiales As System.Windows.Forms.Panel
        Friend WithEvents PautaTextBox As System.Windows.Forms.TextBox
        Friend WithEvents UnidadesTextBox As System.Windows.Forms.TextBox
        Friend WithEvents PosologiaTextBox As System.Windows.Forms.TextBox
        Friend WithEvents PacienteInfoTextBox As System.Windows.Forms.TextBox
        Friend WithEvents PrescripcionTextBox As System.Windows.Forms.TextBox
        Friend WithEvents DuracionTratamientoTextBox As System.Windows.Forms.TextBox
        Friend WithEvents FechaPrevistaDispensacionDateTimePicker As System.Windows.Forms.DateTimePicker
        Friend WithEvents InfoAlFarmaceuticoTextBox As System.Windows.Forms.TextBox
        Friend WithEvents NoOrdenDispensacionTextBox As System.Windows.Forms.TextBox
        Friend WithEvents DiagnosticoAlPacienteTextBox As System.Windows.Forms.TextBox
        Friend WithEvents PrescriptorTextBox As System.Windows.Forms.TextBox
        Friend WithEvents InstruccionesAlPacienteTextBox As System.Windows.Forms.TextBox
        Private WithEvents RECETABindingSource As System.Windows.Forms.BindingSource
        Private WithEvents RecetasMedicamentosBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents ChkUsarPrescriptorInfo As System.Windows.Forms.CheckBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btAsociarReceta As System.Windows.Forms.Button
        Friend WithEvents lblCVE As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents chkFechaDispensacion As System.Windows.Forms.CheckBox
    End Class
End Namespace