<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_ConfiguracionUsuario
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
        Me.gb_datoscitavisual = New System.Windows.Forms.GroupBox()
        Me.chb_CodigoPropioPaciente = New System.Windows.Forms.CheckBox()
        Me.chb_datosCitaVisualEspecialidad = New System.Windows.Forms.CheckBox()
        Me.chb_datosCitaVisualNotas = New System.Windows.Forms.CheckBox()
        Me.chb_datosCitaVisualMedico = New System.Windows.Forms.CheckBox()
        Me.chb_datosCitaVisualNombrePaciente = New System.Windows.Forms.CheckBox()
        Me.gb_estilopordefecto = New System.Windows.Forms.GroupBox()
        Me.rb_vistaclasica = New System.Windows.Forms.RadioButton()
        Me.rb_vistagrafica = New System.Windows.Forms.RadioButton()
        Me.chkMostrarListaMedicos = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chbFiltrarElPrimerFacultativo = New System.Windows.Forms.RadioButton()
        Me.chb_FiltrarMisCitas = New System.Windows.Forms.RadioButton()
        Me.chbNoFiltrar = New System.Windows.Forms.RadioButton()
        Me.grpPacienteFocus = New System.Windows.Forms.GroupBox()
        Me.rb_Pacientes_CodigoPropio = New System.Windows.Forms.RadioButton()
        Me.rb_Paciente_CodPaciente = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTamanoTexto = New System.Windows.Forms.Label()
        Me.nudTamanoTexto = New System.Windows.Forms.NumericUpDown()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCitas = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbAp1Ap1No = New System.Windows.Forms.RadioButton()
        Me.rbNomApe1Ape2 = New System.Windows.Forms.RadioButton()
        Me.grpMedicos = New System.Windows.Forms.GroupBox()
        Me.chkSiUsuarioMedicoUsarPorDefecto = New System.Windows.Forms.CheckBox()
        Me.tabComunicaciones = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblSMSVerificado = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCheckSMS = New System.Windows.Forms.Button()
        Me.txtSMS_Password = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtSMS_user = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtSMS_Server = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtSMS_Remitente = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpEMAIL = New System.Windows.Forms.GroupBox()
        Me.lblEmailVerificado = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chk_EMAIL_SSL = New System.Windows.Forms.CheckBox()
        Me.txtSMTP_Port = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnComprobarEMAIL = New System.Windows.Forms.Button()
        Me.txtSMTP_Password = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtSMTP_User = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtSMTP_Server = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForzarV = New System.Windows.Forms.CheckBox()
        Me.gb_datoscitavisual.SuspendLayout()
        Me.gb_estilopordefecto.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpPacienteFocus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudTamanoTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabCitas.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpMedicos.SuspendLayout()
        Me.tabComunicaciones.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpEMAIL.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_datoscitavisual
        '
        Me.gb_datoscitavisual.Controls.Add(Me.chb_CodigoPropioPaciente)
        Me.gb_datoscitavisual.Controls.Add(Me.chb_datosCitaVisualEspecialidad)
        Me.gb_datoscitavisual.Controls.Add(Me.chb_datosCitaVisualNotas)
        Me.gb_datoscitavisual.Controls.Add(Me.chb_datosCitaVisualMedico)
        Me.gb_datoscitavisual.Controls.Add(Me.chb_datosCitaVisualNombrePaciente)
        Me.gb_datoscitavisual.Location = New System.Drawing.Point(249, 162)
        Me.gb_datoscitavisual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_datoscitavisual.Name = "gb_datoscitavisual"
        Me.gb_datoscitavisual.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_datoscitavisual.Size = New System.Drawing.Size(273, 191)
        Me.gb_datoscitavisual.TabIndex = 35
        Me.gb_datoscitavisual.TabStop = False
        Me.gb_datoscitavisual.Text = "Datos a mostrar en las citas"
        '
        'chb_CodigoPropioPaciente
        '
        Me.chb_CodigoPropioPaciente.AutoSize = True
        Me.chb_CodigoPropioPaciente.Location = New System.Drawing.Point(23, 73)
        Me.chb_CodigoPropioPaciente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chb_CodigoPropioPaciente.Name = "chb_CodigoPropioPaciente"
        Me.chb_CodigoPropioPaciente.Size = New System.Drawing.Size(178, 21)
        Me.chb_CodigoPropioPaciente.TabIndex = 9
        Me.chb_CodigoPropioPaciente.Text = "Codigo Propio Paciente"
        Me.chb_CodigoPropioPaciente.UseVisualStyleBackColor = True
        '
        'chb_datosCitaVisualEspecialidad
        '
        Me.chb_datosCitaVisualEspecialidad.AutoSize = True
        Me.chb_datosCitaVisualEspecialidad.Location = New System.Drawing.Point(23, 113)
        Me.chb_datosCitaVisualEspecialidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chb_datosCitaVisualEspecialidad.Name = "chb_datosCitaVisualEspecialidad"
        Me.chb_datosCitaVisualEspecialidad.Size = New System.Drawing.Size(110, 21)
        Me.chb_datosCitaVisualEspecialidad.TabIndex = 8
        Me.chb_datosCitaVisualEspecialidad.Text = "Especialidad"
        Me.chb_datosCitaVisualEspecialidad.UseVisualStyleBackColor = True
        '
        'chb_datosCitaVisualNotas
        '
        Me.chb_datosCitaVisualNotas.AutoSize = True
        Me.chb_datosCitaVisualNotas.Location = New System.Drawing.Point(23, 154)
        Me.chb_datosCitaVisualNotas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chb_datosCitaVisualNotas.Name = "chb_datosCitaVisualNotas"
        Me.chb_datosCitaVisualNotas.Size = New System.Drawing.Size(120, 21)
        Me.chb_datosCitaVisualNotas.TabIndex = 10
        Me.chb_datosCitaVisualNotas.Text = "Lineas de Cita"
        Me.chb_datosCitaVisualNotas.UseVisualStyleBackColor = True
        '
        'chb_datosCitaVisualMedico
        '
        Me.chb_datosCitaVisualMedico.AutoSize = True
        Me.chb_datosCitaVisualMedico.Location = New System.Drawing.Point(153, 33)
        Me.chb_datosCitaVisualMedico.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chb_datosCitaVisualMedico.Name = "chb_datosCitaVisualMedico"
        Me.chb_datosCitaVisualMedico.Size = New System.Drawing.Size(75, 21)
        Me.chb_datosCitaVisualMedico.TabIndex = 7
        Me.chb_datosCitaVisualMedico.Text = "Médico"
        Me.chb_datosCitaVisualMedico.UseVisualStyleBackColor = True
        '
        'chb_datosCitaVisualNombrePaciente
        '
        Me.chb_datosCitaVisualNombrePaciente.AutoSize = True
        Me.chb_datosCitaVisualNombrePaciente.Location = New System.Drawing.Point(23, 33)
        Me.chb_datosCitaVisualNombrePaciente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chb_datosCitaVisualNombrePaciente.Name = "chb_datosCitaVisualNombrePaciente"
        Me.chb_datosCitaVisualNombrePaciente.Size = New System.Drawing.Size(85, 21)
        Me.chb_datosCitaVisualNombrePaciente.TabIndex = 6
        Me.chb_datosCitaVisualNombrePaciente.Text = "Paciente"
        Me.chb_datosCitaVisualNombrePaciente.UseVisualStyleBackColor = True
        '
        'gb_estilopordefecto
        '
        Me.gb_estilopordefecto.Controls.Add(Me.rb_vistaclasica)
        Me.gb_estilopordefecto.Controls.Add(Me.rb_vistagrafica)
        Me.gb_estilopordefecto.Controls.Add(Me.chkMostrarListaMedicos)
        Me.gb_estilopordefecto.Location = New System.Drawing.Point(8, 23)
        Me.gb_estilopordefecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_estilopordefecto.Name = "gb_estilopordefecto"
        Me.gb_estilopordefecto.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_estilopordefecto.Size = New System.Drawing.Size(233, 191)
        Me.gb_estilopordefecto.TabIndex = 36
        Me.gb_estilopordefecto.TabStop = False
        Me.gb_estilopordefecto.Text = "Estilo por defecto"
        '
        'rb_vistaclasica
        '
        Me.rb_vistaclasica.AutoSize = True
        Me.rb_vistaclasica.Location = New System.Drawing.Point(29, 71)
        Me.rb_vistaclasica.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_vistaclasica.Name = "rb_vistaclasica"
        Me.rb_vistaclasica.Size = New System.Drawing.Size(109, 21)
        Me.rb_vistaclasica.TabIndex = 1
        Me.rb_vistaclasica.TabStop = True
        Me.rb_vistaclasica.Text = "Vista Clásica"
        Me.rb_vistaclasica.UseVisualStyleBackColor = True
        '
        'rb_vistagrafica
        '
        Me.rb_vistagrafica.AutoSize = True
        Me.rb_vistagrafica.Location = New System.Drawing.Point(29, 32)
        Me.rb_vistagrafica.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_vistagrafica.Name = "rb_vistagrafica"
        Me.rb_vistagrafica.Size = New System.Drawing.Size(107, 21)
        Me.rb_vistagrafica.TabIndex = 0
        Me.rb_vistagrafica.TabStop = True
        Me.rb_vistagrafica.Text = "Vista gráfica"
        Me.rb_vistagrafica.UseVisualStyleBackColor = True
        '
        'chkMostrarListaMedicos
        '
        Me.chkMostrarListaMedicos.Location = New System.Drawing.Point(12, 114)
        Me.chkMostrarListaMedicos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMostrarListaMedicos.Name = "chkMostrarListaMedicos"
        Me.chkMostrarListaMedicos.Size = New System.Drawing.Size(213, 47)
        Me.chkMostrarListaMedicos.TabIndex = 2
        Me.chkMostrarListaMedicos.Text = "En Calendario, mostrar lista de médicos por defecto"
        Me.chkMostrarListaMedicos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chbFiltrarElPrimerFacultativo)
        Me.GroupBox2.Controls.Add(Me.chb_FiltrarMisCitas)
        Me.GroupBox2.Controls.Add(Me.chbNoFiltrar)
        Me.GroupBox2.Location = New System.Drawing.Point(1001, 23)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(304, 191)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros del Calendario Citas"
        Me.GroupBox2.Visible = False
        '
        'chbFiltrarElPrimerFacultativo
        '
        Me.chbFiltrarElPrimerFacultativo.AutoSize = True
        Me.chbFiltrarElPrimerFacultativo.Location = New System.Drawing.Point(36, 114)
        Me.chbFiltrarElPrimerFacultativo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbFiltrarElPrimerFacultativo.Name = "chbFiltrarElPrimerFacultativo"
        Me.chbFiltrarElPrimerFacultativo.Size = New System.Drawing.Size(198, 21)
        Me.chbFiltrarElPrimerFacultativo.TabIndex = 6
        Me.chbFiltrarElPrimerFacultativo.Text = "Filtrar por el 1er facultativo"
        Me.chbFiltrarElPrimerFacultativo.UseVisualStyleBackColor = True
        '
        'chb_FiltrarMisCitas
        '
        Me.chb_FiltrarMisCitas.AutoSize = True
        Me.chb_FiltrarMisCitas.Location = New System.Drawing.Point(36, 73)
        Me.chb_FiltrarMisCitas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chb_FiltrarMisCitas.Name = "chb_FiltrarMisCitas"
        Me.chb_FiltrarMisCitas.Size = New System.Drawing.Size(237, 21)
        Me.chb_FiltrarMisCitas.TabIndex = 6
        Me.chb_FiltrarMisCitas.Text = "Filtrar mis Citas (Usuario Médico)"
        Me.chb_FiltrarMisCitas.UseVisualStyleBackColor = True
        '
        'chbNoFiltrar
        '
        Me.chbNoFiltrar.AutoSize = True
        Me.chbNoFiltrar.Checked = True
        Me.chbNoFiltrar.Location = New System.Drawing.Point(36, 32)
        Me.chbNoFiltrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbNoFiltrar.Name = "chbNoFiltrar"
        Me.chbNoFiltrar.Size = New System.Drawing.Size(87, 21)
        Me.chbNoFiltrar.TabIndex = 6
        Me.chbNoFiltrar.TabStop = True
        Me.chbNoFiltrar.Text = "No Filtrar"
        Me.chbNoFiltrar.UseVisualStyleBackColor = True
        '
        'grpPacienteFocus
        '
        Me.grpPacienteFocus.Controls.Add(Me.rb_Pacientes_CodigoPropio)
        Me.grpPacienteFocus.Controls.Add(Me.rb_Paciente_CodPaciente)
        Me.grpPacienteFocus.Location = New System.Drawing.Point(249, 23)
        Me.grpPacienteFocus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPacienteFocus.Name = "grpPacienteFocus"
        Me.grpPacienteFocus.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPacienteFocus.Size = New System.Drawing.Size(273, 132)
        Me.grpPacienteFocus.TabIndex = 39
        Me.grpPacienteFocus.TabStop = False
        Me.grpPacienteFocus.Text = "En pacientes enfocar por defecto"
        '
        'rb_Pacientes_CodigoPropio
        '
        Me.rb_Pacientes_CodigoPropio.AutoSize = True
        Me.rb_Pacientes_CodigoPropio.Checked = True
        Me.rb_Pacientes_CodigoPropio.Location = New System.Drawing.Point(37, 23)
        Me.rb_Pacientes_CodigoPropio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_Pacientes_CodigoPropio.Name = "rb_Pacientes_CodigoPropio"
        Me.rb_Pacientes_CodigoPropio.Size = New System.Drawing.Size(118, 21)
        Me.rb_Pacientes_CodigoPropio.TabIndex = 4
        Me.rb_Pacientes_CodigoPropio.TabStop = True
        Me.rb_Pacientes_CodigoPropio.Text = "Código Propio"
        Me.rb_Pacientes_CodigoPropio.UseVisualStyleBackColor = True
        '
        'rb_Paciente_CodPaciente
        '
        Me.rb_Paciente_CodPaciente.AutoSize = True
        Me.rb_Paciente_CodPaciente.Location = New System.Drawing.Point(37, 52)
        Me.rb_Paciente_CodPaciente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_Paciente_CodPaciente.Name = "rb_Paciente_CodPaciente"
        Me.rb_Paciente_CodPaciente.Size = New System.Drawing.Size(132, 21)
        Me.rb_Paciente_CodPaciente.TabIndex = 5
        Me.rb_Paciente_CodPaciente.Text = "Código Paciente"
        Me.rb_Paciente_CodPaciente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTamanoTexto)
        Me.GroupBox1.Controls.Add(Me.nudTamanoTexto)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 222)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(233, 132)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historiales"
        '
        'lblTamanoTexto
        '
        Me.lblTamanoTexto.AutoSize = True
        Me.lblTamanoTexto.Location = New System.Drawing.Point(7, 54)
        Me.lblTamanoTexto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTamanoTexto.Name = "lblTamanoTexto"
        Me.lblTamanoTexto.Size = New System.Drawing.Size(94, 17)
        Me.lblTamanoTexto.TabIndex = 1
        Me.lblTamanoTexto.Text = "Tamaño texto"
        '
        'nudTamanoTexto
        '
        Me.nudTamanoTexto.Location = New System.Drawing.Point(131, 52)
        Me.nudTamanoTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudTamanoTexto.Name = "nudTamanoTexto"
        Me.nudTamanoTexto.Size = New System.Drawing.Size(56, 22)
        Me.nudTamanoTexto.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(869, 27)
        Me.ToolStrip1.TabIndex = 38
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources.Checked
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(82, 24)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(86, 24)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabCitas)
        Me.TabControl1.Controls.Add(Me.tabComunicaciones)
        Me.TabControl1.Location = New System.Drawing.Point(4, 37)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(863, 425)
        Me.TabControl1.TabIndex = 0
        '
        'tabCitas
        '
        Me.tabCitas.Controls.Add(Me.GroupBox4)
        Me.tabCitas.Controls.Add(Me.grpMedicos)
        Me.tabCitas.Controls.Add(Me.GroupBox2)
        Me.tabCitas.Controls.Add(Me.grpPacienteFocus)
        Me.tabCitas.Controls.Add(Me.gb_estilopordefecto)
        Me.tabCitas.Controls.Add(Me.GroupBox1)
        Me.tabCitas.Controls.Add(Me.gb_datoscitavisual)
        Me.tabCitas.Location = New System.Drawing.Point(4, 25)
        Me.tabCitas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabCitas.Name = "tabCitas"
        Me.tabCitas.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabCitas.Size = New System.Drawing.Size(855, 396)
        Me.tabCitas.TabIndex = 0
        Me.tabCitas.Text = "Citas"
        Me.tabCitas.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbAp1Ap1No)
        Me.GroupBox4.Controls.Add(Me.rbNomApe1Ape2)
        Me.GroupBox4.Location = New System.Drawing.Point(531, 23)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(311, 135)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Formato de nombre de paciente"
        '
        'rbAp1Ap1No
        '
        Me.rbAp1Ap1No.AutoSize = True
        Me.rbAp1Ap1No.Checked = True
        Me.rbAp1Ap1No.Location = New System.Drawing.Point(24, 32)
        Me.rbAp1Ap1No.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbAp1Ap1No.Name = "rbAp1Ap1No"
        Me.rbAp1Ap1No.Size = New System.Drawing.Size(235, 21)
        Me.rbAp1Ap1No.TabIndex = 11
        Me.rbAp1Ap1No.TabStop = True
        Me.rbAp1Ap1No.Text = "Apellido 1 + Apellido 2 + Nombre"
        Me.rbAp1Ap1No.UseVisualStyleBackColor = True
        '
        'rbNomApe1Ape2
        '
        Me.rbNomApe1Ape2.AutoSize = True
        Me.rbNomApe1Ape2.Location = New System.Drawing.Point(24, 73)
        Me.rbNomApe1Ape2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbNomApe1Ape2.Name = "rbNomApe1Ape2"
        Me.rbNomApe1Ape2.Size = New System.Drawing.Size(235, 21)
        Me.rbNomApe1Ape2.TabIndex = 11
        Me.rbNomApe1Ape2.Text = "Nombre + Apellido 1 + Apellido 2"
        Me.rbNomApe1Ape2.UseVisualStyleBackColor = True
        '
        'grpMedicos
        '
        Me.grpMedicos.Controls.Add(Me.chkSiUsuarioMedicoUsarPorDefecto)
        Me.grpMedicos.Location = New System.Drawing.Point(531, 166)
        Me.grpMedicos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMedicos.Name = "grpMedicos"
        Me.grpMedicos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMedicos.Size = New System.Drawing.Size(311, 187)
        Me.grpMedicos.TabIndex = 41
        Me.grpMedicos.TabStop = False
        Me.grpMedicos.Text = "Médicos"
        '
        'chkSiUsuarioMedicoUsarPorDefecto
        '
        Me.chkSiUsuarioMedicoUsarPorDefecto.Location = New System.Drawing.Point(12, 23)
        Me.chkSiUsuarioMedicoUsarPorDefecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSiUsuarioMedicoUsarPorDefecto.Name = "chkSiUsuarioMedicoUsarPorDefecto"
        Me.chkSiUsuarioMedicoUsarPorDefecto.Size = New System.Drawing.Size(283, 50)
        Me.chkSiUsuarioMedicoUsarPorDefecto.TabIndex = 9
        Me.chkSiUsuarioMedicoUsarPorDefecto.Text = "Si el usuario es medico, seleccionarlo como médico por defecto"
        Me.chkSiUsuarioMedicoUsarPorDefecto.UseVisualStyleBackColor = True
        '
        'tabComunicaciones
        '
        Me.tabComunicaciones.Controls.Add(Me.GroupBox3)
        Me.tabComunicaciones.Controls.Add(Me.grpEMAIL)
        Me.tabComunicaciones.Location = New System.Drawing.Point(4, 25)
        Me.tabComunicaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabComunicaciones.Name = "tabComunicaciones"
        Me.tabComunicaciones.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabComunicaciones.Size = New System.Drawing.Size(855, 396)
        Me.tabComunicaciones.TabIndex = 1
        Me.tabComunicaciones.Text = "Comunicaciones"
        Me.tabComunicaciones.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSMSVerificado)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.btnCheckSMS)
        Me.GroupBox3.Controls.Add(Me.txtSMS_Password)
        Me.GroupBox3.Controls.Add(Me.txtSMS_user)
        Me.GroupBox3.Controls.Add(Me.txtSMS_Server)
        Me.GroupBox3.Controls.Add(Me.txtSMS_Remitente)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(434, 7)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(413, 381)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SMS"
        '
        'lblSMSVerificado
        '
        Me.lblSMSVerificado.AutoSize = True
        Me.lblSMSVerificado.ForeColor = System.Drawing.Color.Red
        Me.lblSMSVerificado.Location = New System.Drawing.Point(86, 346)
        Me.lblSMSVerificado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSMSVerificado.Name = "lblSMSVerificado"
        Me.lblSMSVerificado.Size = New System.Drawing.Size(91, 17)
        Me.lblSMSVerificado.TabIndex = 12
        Me.lblSMSVerificado.Text = "No verificado"
        Me.lblSMSVerificado.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 346)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Estado:"
        Me.Label12.Visible = False
        '
        'btnCheckSMS
        '
        Me.btnCheckSMS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCheckSMS.Location = New System.Drawing.Point(264, 340)
        Me.btnCheckSMS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheckSMS.Name = "btnCheckSMS"
        Me.btnCheckSMS.Size = New System.Drawing.Size(141, 28)
        Me.btnCheckSMS.TabIndex = 8
        Me.btnCheckSMS.Text = "Comprobar Saldo"
        Me.btnCheckSMS.UseVisualStyleBackColor = True
        '
        'txtSMS_Password
        '
        Me.txtSMS_Password.Location = New System.Drawing.Point(227, 141)
        Me.txtSMS_Password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSMS_Password.Name = "txtSMS_Password"
        Me.txtSMS_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSMS_Password.Size = New System.Drawing.Size(148, 22)
        Me.txtSMS_Password.TabIndex = 7
        '
        'txtSMS_user
        '
        Me.txtSMS_user.Location = New System.Drawing.Point(32, 141)
        Me.txtSMS_user.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSMS_user.Name = "txtSMS_user"
        Me.txtSMS_user.Size = New System.Drawing.Size(187, 22)
        Me.txtSMS_user.TabIndex = 5
        '
        'txtSMS_Server
        '
        Me.txtSMS_Server.Location = New System.Drawing.Point(27, 224)
        Me.txtSMS_Server.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSMS_Server.Name = "txtSMS_Server"
        Me.txtSMS_Server.Size = New System.Drawing.Size(229, 22)
        Me.txtSMS_Server.TabIndex = 3
        Me.txtSMS_Server.Visible = False
        '
        'txtSMS_Remitente
        '
        Me.txtSMS_Remitente.Location = New System.Drawing.Point(27, 54)
        Me.txtSMS_Remitente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSMS_Remitente.Name = "txtSMS_Remitente"
        Me.txtSMS_Remitente.Size = New System.Drawing.Size(229, 22)
        Me.txtSMS_Remitente.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "SMS password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 121)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "SMS usuario (email)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "SMS Server"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Móvil remitente:"
        '
        'grpEMAIL
        '
        Me.grpEMAIL.Controls.Add(Me.ForzarV)
        Me.grpEMAIL.Controls.Add(Me.lblEmailVerificado)
        Me.grpEMAIL.Controls.Add(Me.Label10)
        Me.grpEMAIL.Controls.Add(Me.chk_EMAIL_SSL)
        Me.grpEMAIL.Controls.Add(Me.txtSMTP_Port)
        Me.grpEMAIL.Controls.Add(Me.btnComprobarEMAIL)
        Me.grpEMAIL.Controls.Add(Me.txtSMTP_Password)
        Me.grpEMAIL.Controls.Add(Me.txtSMTP_User)
        Me.grpEMAIL.Controls.Add(Me.txtSMTP_Server)
        Me.grpEMAIL.Controls.Add(Me.txtEmail)
        Me.grpEMAIL.Controls.Add(Me.Label4)
        Me.grpEMAIL.Controls.Add(Me.Label3)
        Me.grpEMAIL.Controls.Add(Me.Label9)
        Me.grpEMAIL.Controls.Add(Me.Label2)
        Me.grpEMAIL.Controls.Add(Me.Label1)
        Me.grpEMAIL.Location = New System.Drawing.Point(9, 7)
        Me.grpEMAIL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpEMAIL.Name = "grpEMAIL"
        Me.grpEMAIL.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpEMAIL.Size = New System.Drawing.Size(417, 381)
        Me.grpEMAIL.TabIndex = 0
        Me.grpEMAIL.TabStop = False
        Me.grpEMAIL.Text = "Email"
        '
        'lblEmailVerificado
        '
        Me.lblEmailVerificado.AutoSize = True
        Me.lblEmailVerificado.ForeColor = System.Drawing.Color.Red
        Me.lblEmailVerificado.Location = New System.Drawing.Point(83, 328)
        Me.lblEmailVerificado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmailVerificado.Name = "lblEmailVerificado"
        Me.lblEmailVerificado.Size = New System.Drawing.Size(91, 17)
        Me.lblEmailVerificado.TabIndex = 10
        Me.lblEmailVerificado.Text = "No verificada"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 328)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Estado:"
        '
        'chk_EMAIL_SSL
        '
        Me.chk_EMAIL_SSL.AutoSize = True
        Me.chk_EMAIL_SSL.Checked = True
        Me.chk_EMAIL_SSL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_EMAIL_SSL.Location = New System.Drawing.Point(27, 256)
        Me.chk_EMAIL_SSL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chk_EMAIL_SSL.Name = "chk_EMAIL_SSL"
        Me.chk_EMAIL_SSL.Size = New System.Drawing.Size(90, 21)
        Me.chk_EMAIL_SSL.TabIndex = 9
        Me.chk_EMAIL_SSL.Text = "Usar SSL"
        Me.chk_EMAIL_SSL.UseVisualStyleBackColor = True
        '
        'txtSMTP_Port
        '
        Me.txtSMTP_Port.DecimalDigits = 0
        Me.txtSMTP_Port.Location = New System.Drawing.Point(301, 141)
        Me.txtSMTP_Port.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSMTP_Port.Name = "txtSMTP_Port"
        Me.txtSMTP_Port.Size = New System.Drawing.Size(61, 22)
        Me.txtSMTP_Port.TabIndex = 2
        Me.txtSMTP_Port.Text = "25"
        Me.txtSMTP_Port.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'btnComprobarEMAIL
        '
        Me.btnComprobarEMAIL.Location = New System.Drawing.Point(309, 323)
        Me.btnComprobarEMAIL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnComprobarEMAIL.Name = "btnComprobarEMAIL"
        Me.btnComprobarEMAIL.Size = New System.Drawing.Size(100, 28)
        Me.btnComprobarEMAIL.TabIndex = 8
        Me.btnComprobarEMAIL.Text = "Comprobar"
        Me.btnComprobarEMAIL.UseVisualStyleBackColor = True
        '
        'txtSMTP_Password
        '
        Me.txtSMTP_Password.Location = New System.Drawing.Point(205, 224)
        Me.txtSMTP_Password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSMTP_Password.Name = "txtSMTP_Password"
        Me.txtSMTP_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSMTP_Password.Size = New System.Drawing.Size(157, 22)
        Me.txtSMTP_Password.TabIndex = 7
        '
        'txtSMTP_User
        '
        Me.txtSMTP_User.Location = New System.Drawing.Point(27, 224)
        Me.txtSMTP_User.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSMTP_User.Name = "txtSMTP_User"
        Me.txtSMTP_User.Size = New System.Drawing.Size(157, 22)
        Me.txtSMTP_User.TabIndex = 5
        '
        'txtSMTP_Server
        '
        Me.txtSMTP_Server.Location = New System.Drawing.Point(27, 141)
        Me.txtSMTP_Server.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSMTP_Server.Name = "txtSMTP_Server"
        Me.txtSMTP_Server.Size = New System.Drawing.Size(267, 22)
        Me.txtSMTP_Server.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(27, 54)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(339, 22)
        Me.txtEmail.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 205)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SMTP password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 205)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SMTP user"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(312, 121)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Puerto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SMTP Server"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dirección de correo:"
        '
        'ForzarV
        '
        Me.ForzarV.AutoSize = True
        Me.ForzarV.Location = New System.Drawing.Point(27, 353)
        Me.ForzarV.Name = "ForzarV"
        Me.ForzarV.Size = New System.Drawing.Size(138, 21)
        Me.ForzarV.TabIndex = 11
        Me.ForzarV.Text = "Forzar validación"
        Me.ForzarV.UseVisualStyleBackColor = True
        '
        'form_ConfiguracionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(869, 470)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "form_ConfiguracionUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_ConfiguracionUsuario"
        Me.gb_datoscitavisual.ResumeLayout(False)
        Me.gb_datoscitavisual.PerformLayout()
        Me.gb_estilopordefecto.ResumeLayout(False)
        Me.gb_estilopordefecto.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpPacienteFocus.ResumeLayout(False)
        Me.grpPacienteFocus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudTamanoTexto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabCitas.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpMedicos.ResumeLayout(False)
        Me.tabComunicaciones.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpEMAIL.ResumeLayout(False)
        Me.grpEMAIL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_datoscitavisual As System.Windows.Forms.GroupBox
    Friend WithEvents chb_datosCitaVisualEspecialidad As System.Windows.Forms.CheckBox
    Friend WithEvents chb_datosCitaVisualNotas As System.Windows.Forms.CheckBox
    Friend WithEvents chb_datosCitaVisualMedico As System.Windows.Forms.CheckBox
    Friend WithEvents chb_datosCitaVisualNombrePaciente As System.Windows.Forms.CheckBox
    Friend WithEvents gb_estilopordefecto As System.Windows.Forms.GroupBox
    Friend WithEvents rb_vistaclasica As System.Windows.Forms.RadioButton
    Friend WithEvents rb_vistagrafica As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents chb_CodigoPropioPaciente As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTamanoTexto As System.Windows.Forms.Label
    Friend WithEvents nudTamanoTexto As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpPacienteFocus As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Pacientes_CodigoPropio As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Paciente_CodPaciente As System.Windows.Forms.RadioButton
    Friend WithEvents chkMostrarListaMedicos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chbFiltrarElPrimerFacultativo As System.Windows.Forms.RadioButton
    Friend WithEvents chb_FiltrarMisCitas As System.Windows.Forms.RadioButton
    Friend WithEvents chbNoFiltrar As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabCitas As System.Windows.Forms.TabPage
    Friend WithEvents tabComunicaciones As System.Windows.Forms.TabPage
    Friend WithEvents grpEMAIL As System.Windows.Forms.GroupBox
    Friend WithEvents txtSMTP_Password As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtSMTP_User As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtSMTP_Server As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSMS_Password As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtSMS_user As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtSMS_Server As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtSMS_Remitente As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCheckSMS As System.Windows.Forms.Button
    Friend WithEvents btnComprobarEMAIL As System.Windows.Forms.Button
    Friend WithEvents txtSMTP_Port As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chk_EMAIL_SSL As System.Windows.Forms.CheckBox
    Friend WithEvents lblEmailVerificado As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblSMSVerificado As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpMedicos As System.Windows.Forms.GroupBox
    Friend WithEvents chkSiUsuarioMedicoUsarPorDefecto As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAp1Ap1No As System.Windows.Forms.RadioButton
    Friend WithEvents rbNomApe1Ape2 As System.Windows.Forms.RadioButton
    Friend WithEvents ForzarV As System.Windows.Forms.CheckBox
End Class
