<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicos_ADD
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
        Dim Label5 As System.Windows.Forms.Label
        Dim OBSERVACIONESLabel As System.Windows.Forms.Label
        Dim lb_nombre As System.Windows.Forms.Label
        Dim APELLIDO1Label As System.Windows.Forms.Label
        Dim APELLIDO2Label As System.Windows.Forms.Label
        Dim DOMICILIOLabel As System.Windows.Forms.Label
        Dim TLFNOLabel As System.Windows.Forms.Label
        Dim MOVILLabel As System.Windows.Forms.Label
        Dim LOCALIDADLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim PROVINCIALabel As System.Windows.Forms.Label
        Dim COLEGIADOLabel As System.Windows.Forms.Label
        Dim ESPECIALIDADLabel As System.Windows.Forms.Label
        Dim GridEXCitas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedicos_ADD))
        Dim GridEX_Recetas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXRegulares_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Me.tab_medicos = New System.Windows.Forms.TabControl()
        Me.tab_medicos_datos = New System.Windows.Forms.TabPage()
        Me.txtMedicos_PorcientoPorCita = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.MEDICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPorcientocitasparaMedico = New System.Windows.Forms.Label()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_ADD = New System.Windows.Forms.Button()
        Me.ptbFirma = New System.Windows.Forms.PictureBox()
        Me.lb_letra = New System.Windows.Forms.Label()
        Me.tb_observaciones = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_nombre = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_apellido1 = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_apellido2 = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_direccion = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_telefono = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_movil = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_poblacion = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_cp = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_DNI = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_provincia = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_colegiado = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_especialidad = New centro_medico.ctrlTextboxAvanzado()
        Me.tab_medicos_citas = New System.Windows.Forms.TabPage()
        Me.Calendar1 = New Janus.Windows.Schedule.Calendar()
        Me.GridEXCitas = New Janus.Windows.GridEX.GridEX()
        Me.CITAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_modificar = New System.Windows.Forms.Button()
        Me.bt_borrar = New System.Windows.Forms.Button()
        Me.bt_añadir = New System.Windows.Forms.Button()
        Me.tb_obs = New centro_medico.ctrlTextboxAvanzado()
        Me.tab_medicos_recetas = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CtrlVisorDefaultApp3 = New centro_medico.ctrlVisorDefaultApp()
        Me.CtrlVisorDefaultApp2 = New centro_medico.ctrlVisorDefaultApp()
        Me.CtrlVisorDefaultApp1 = New centro_medico.ctrlVisorDefaultApp()
        Me.bt_imagencolegio = New System.Windows.Forms.Button()
        Me.bt_imagenconsejo = New System.Windows.Forms.Button()
        Me.bt_fondoreceta = New System.Windows.Forms.Button()
        Me.lblImagenColegio = New System.Windows.Forms.Label()
        Me.lblImagenConsejo = New System.Windows.Forms.Label()
        Me.lblFondoReceta = New System.Windows.Forms.Label()
        Me.lblInfoRecetas = New System.Windows.Forms.Label()
        Me.btImportarRecetas = New System.Windows.Forms.Button()
        Me.GridEX_Recetas = New Janus.Windows.GridEX.GridEX()
        Me.RECETAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_borrarreceta = New System.Windows.Forms.Button()
        Me.bt_modificarreceta = New System.Windows.Forms.Button()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.bt_ver = New System.Windows.Forms.Button()
        Me.gb_filtrar = New System.Windows.Forms.GroupBox()
        Me.CtrlDiagnosticos1 = New centro_medico.ctrlDiagnosticos()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.gb_ordenar = New System.Windows.Forms.GroupBox()
        Me.rb_diagnostico = New System.Windows.Forms.RadioButton()
        Me.rb_paciente = New System.Windows.Forms.RadioButton()
        Me.rb_fecha = New System.Windows.Forms.RadioButton()
        Me.tb_receta = New centro_medico.ctrlTextboxAvanzado()
        Me.tab_medicos_conceptosfacturables = New System.Windows.Forms.TabPage()
        Me.GridEXRegulares = New Janus.Windows.GridEX.GridEX()
        Me.MEDICOSCONCEPTOFRAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnConceptoFRA_REMOVE = New System.Windows.Forms.Button()
        Me.btnConceptoFRA_TODOS = New System.Windows.Forms.Button()
        Me.btnConceptoFRA_ADD = New System.Windows.Forms.Button()
        Me.tab_medicos_calendarios = New System.Windows.Forms.TabPage()
        Me.CtrlHorarios1 = New centro_medico.ctrlHorarios()
        Me.tab_medicos_ficheros = New System.Windows.Forms.TabPage()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.FICHEROBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.tstNuevoFichero = New System.Windows.Forms.ToolStripButton()
        Me.tstModificarFichero = New System.Windows.Forms.ToolStripButton()
        Me.tstEliminarFichero = New System.Windows.Forms.ToolStripButton()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.MEDICOSFICHEROsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Label5 = New System.Windows.Forms.Label()
        OBSERVACIONESLabel = New System.Windows.Forms.Label()
        lb_nombre = New System.Windows.Forms.Label()
        APELLIDO1Label = New System.Windows.Forms.Label()
        APELLIDO2Label = New System.Windows.Forms.Label()
        DOMICILIOLabel = New System.Windows.Forms.Label()
        TLFNOLabel = New System.Windows.Forms.Label()
        MOVILLabel = New System.Windows.Forms.Label()
        LOCALIDADLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        PROVINCIALabel = New System.Windows.Forms.Label()
        COLEGIADOLabel = New System.Windows.Forms.Label()
        ESPECIALIDADLabel = New System.Windows.Forms.Label()
        Me.tab_medicos.SuspendLayout()
        Me.tab_medicos_datos.SuspendLayout()
        CType(Me.MEDICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_medicos_citas.SuspendLayout()
        CType(Me.Calendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_medicos_recetas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridEX_Recetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECETAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_filtrar.SuspendLayout()
        Me.gb_ordenar.SuspendLayout()
        Me.tab_medicos_conceptosfacturables.SuspendLayout()
        CType(Me.GridEXRegulares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSCONCEPTOFRAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_medicos_calendarios.SuspendLayout()
        Me.tab_medicos_ficheros.SuspendLayout()
        CType(Me.FICHEROBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FICHEROBindingNavigator.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSFICHEROsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(735, 248)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(32, 13)
        Label5.TabIndex = 66
        Label5.Text = "Firma"
        '
        'OBSERVACIONESLabel
        '
        OBSERVACIONESLabel.AutoSize = True
        OBSERVACIONESLabel.Location = New System.Drawing.Point(16, 248)
        OBSERVACIONESLabel.Name = "OBSERVACIONESLabel"
        OBSERVACIONESLabel.Size = New System.Drawing.Size(81, 13)
        OBSERVACIONESLabel.TabIndex = 26
        OBSERVACIONESLabel.Text = "Observaciones:"
        '
        'lb_nombre
        '
        lb_nombre.AutoSize = True
        lb_nombre.Location = New System.Drawing.Point(473, 23)
        lb_nombre.Name = "lb_nombre"
        lb_nombre.Size = New System.Drawing.Size(47, 13)
        lb_nombre.TabIndex = 0
        lb_nombre.Text = "Nombre:"
        '
        'APELLIDO1Label
        '
        APELLIDO1Label.AutoSize = True
        APELLIDO1Label.Location = New System.Drawing.Point(16, 23)
        APELLIDO1Label.Name = "APELLIDO1Label"
        APELLIDO1Label.Size = New System.Drawing.Size(53, 13)
        APELLIDO1Label.TabIndex = 2
        APELLIDO1Label.Text = "Apellido1:"
        '
        'APELLIDO2Label
        '
        APELLIDO2Label.AutoSize = True
        APELLIDO2Label.Location = New System.Drawing.Point(231, 23)
        APELLIDO2Label.Name = "APELLIDO2Label"
        APELLIDO2Label.Size = New System.Drawing.Size(53, 13)
        APELLIDO2Label.TabIndex = 4
        APELLIDO2Label.Text = "Apellido2:"
        '
        'DOMICILIOLabel
        '
        DOMICILIOLabel.AutoSize = True
        DOMICILIOLabel.Location = New System.Drawing.Point(478, 78)
        DOMICILIOLabel.Name = "DOMICILIOLabel"
        DOMICILIOLabel.Size = New System.Drawing.Size(55, 13)
        DOMICILIOLabel.TabIndex = 6
        DOMICILIOLabel.Text = "Dirección:"
        '
        'TLFNOLabel
        '
        TLFNOLabel.AutoSize = True
        TLFNOLabel.Location = New System.Drawing.Point(185, 78)
        TLFNOLabel.Name = "TLFNOLabel"
        TLFNOLabel.Size = New System.Drawing.Size(52, 13)
        TLFNOLabel.TabIndex = 8
        TLFNOLabel.Text = "Teléfono:"
        '
        'MOVILLabel
        '
        MOVILLabel.AutoSize = True
        MOVILLabel.Location = New System.Drawing.Point(335, 78)
        MOVILLabel.Name = "MOVILLabel"
        MOVILLabel.Size = New System.Drawing.Size(35, 13)
        MOVILLabel.TabIndex = 10
        MOVILLabel.Text = "Móvil:"
        '
        'LOCALIDADLabel
        '
        LOCALIDADLabel.AutoSize = True
        LOCALIDADLabel.Location = New System.Drawing.Point(185, 137)
        LOCALIDADLabel.Name = "LOCALIDADLabel"
        LOCALIDADLabel.Size = New System.Drawing.Size(57, 13)
        LOCALIDADLabel.TabIndex = 12
        LOCALIDADLabel.Text = "Población:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(16, 137)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(52, 13)
        CPLabel.TabIndex = 14
        CPLabel.Text = "C. Postal:"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(16, 78)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 16
        DNILabel.Text = "DNI:"
        '
        'PROVINCIALabel
        '
        PROVINCIALabel.AutoSize = True
        PROVINCIALabel.Location = New System.Drawing.Point(473, 137)
        PROVINCIALabel.Name = "PROVINCIALabel"
        PROVINCIALabel.Size = New System.Drawing.Size(54, 13)
        PROVINCIALabel.TabIndex = 18
        PROVINCIALabel.Text = "Provincia:"
        '
        'COLEGIADOLabel
        '
        COLEGIADOLabel.AutoSize = True
        COLEGIADOLabel.Location = New System.Drawing.Point(185, 192)
        COLEGIADOLabel.Name = "COLEGIADOLabel"
        COLEGIADOLabel.Size = New System.Drawing.Size(82, 13)
        COLEGIADOLabel.TabIndex = 20
        COLEGIADOLabel.Text = "# de Colegiado:"
        '
        'ESPECIALIDADLabel
        '
        ESPECIALIDADLabel.AutoSize = True
        ESPECIALIDADLabel.Location = New System.Drawing.Point(14, 192)
        ESPECIALIDADLabel.Name = "ESPECIALIDADLabel"
        ESPECIALIDADLabel.Size = New System.Drawing.Size(67, 13)
        ESPECIALIDADLabel.TabIndex = 24
        ESPECIALIDADLabel.Text = "Especialidad"
        '
        'tab_medicos
        '
        Me.tab_medicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_medicos.Controls.Add(Me.tab_medicos_datos)
        Me.tab_medicos.Controls.Add(Me.tab_medicos_citas)
        Me.tab_medicos.Controls.Add(Me.tab_medicos_recetas)
        Me.tab_medicos.Controls.Add(Me.tab_medicos_conceptosfacturables)
        Me.tab_medicos.Controls.Add(Me.tab_medicos_calendarios)
        Me.tab_medicos.Controls.Add(Me.tab_medicos_ficheros)
        Me.tab_medicos.Location = New System.Drawing.Point(3, 2)
        Me.tab_medicos.Name = "tab_medicos"
        Me.tab_medicos.SelectedIndex = 0
        Me.tab_medicos.Size = New System.Drawing.Size(994, 525)
        Me.tab_medicos.TabIndex = 1
        '
        'tab_medicos_datos
        '
        Me.tab_medicos_datos.AutoScroll = True
        Me.tab_medicos_datos.Controls.Add(Me.txtMedicos_PorcientoPorCita)
        Me.tab_medicos_datos.Controls.Add(Me.lblPorcientocitasparaMedico)
        Me.tab_medicos_datos.Controls.Add(Me.btn_Eliminar)
        Me.tab_medicos_datos.Controls.Add(Me.btn_ADD)
        Me.tab_medicos_datos.Controls.Add(Me.ptbFirma)
        Me.tab_medicos_datos.Controls.Add(Label5)
        Me.tab_medicos_datos.Controls.Add(Me.lb_letra)
        Me.tab_medicos_datos.Controls.Add(Me.tb_observaciones)
        Me.tab_medicos_datos.Controls.Add(OBSERVACIONESLabel)
        Me.tab_medicos_datos.Controls.Add(lb_nombre)
        Me.tab_medicos_datos.Controls.Add(Me.tb_nombre)
        Me.tab_medicos_datos.Controls.Add(APELLIDO1Label)
        Me.tab_medicos_datos.Controls.Add(Me.tb_apellido1)
        Me.tab_medicos_datos.Controls.Add(APELLIDO2Label)
        Me.tab_medicos_datos.Controls.Add(Me.tb_apellido2)
        Me.tab_medicos_datos.Controls.Add(DOMICILIOLabel)
        Me.tab_medicos_datos.Controls.Add(Me.tb_direccion)
        Me.tab_medicos_datos.Controls.Add(TLFNOLabel)
        Me.tab_medicos_datos.Controls.Add(Me.tb_telefono)
        Me.tab_medicos_datos.Controls.Add(MOVILLabel)
        Me.tab_medicos_datos.Controls.Add(Me.tb_movil)
        Me.tab_medicos_datos.Controls.Add(LOCALIDADLabel)
        Me.tab_medicos_datos.Controls.Add(Me.tb_poblacion)
        Me.tab_medicos_datos.Controls.Add(CPLabel)
        Me.tab_medicos_datos.Controls.Add(Me.tb_cp)
        Me.tab_medicos_datos.Controls.Add(DNILabel)
        Me.tab_medicos_datos.Controls.Add(Me.tb_DNI)
        Me.tab_medicos_datos.Controls.Add(PROVINCIALabel)
        Me.tab_medicos_datos.Controls.Add(Me.tb_provincia)
        Me.tab_medicos_datos.Controls.Add(COLEGIADOLabel)
        Me.tab_medicos_datos.Controls.Add(Me.tb_colegiado)
        Me.tab_medicos_datos.Controls.Add(ESPECIALIDADLabel)
        Me.tab_medicos_datos.Controls.Add(Me.tb_especialidad)
        Me.tab_medicos_datos.Location = New System.Drawing.Point(4, 22)
        Me.tab_medicos_datos.Name = "tab_medicos_datos"
        Me.tab_medicos_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_medicos_datos.Size = New System.Drawing.Size(986, 499)
        Me.tab_medicos_datos.TabIndex = 0
        Me.tab_medicos_datos.Text = "Datos Básicos"
        Me.tab_medicos_datos.UseVisualStyleBackColor = True
        '
        'txtMedicos_PorcientoPorCita
        '
        Me.txtMedicos_PorcientoPorCita.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MEDICOBindingSource, "PorcientoCita", True))
        Me.txtMedicos_PorcientoPorCita.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtMedicos_PorcientoPorCita.Location = New System.Drawing.Point(184, 460)
        Me.txtMedicos_PorcientoPorCita.Name = "txtMedicos_PorcientoPorCita"
        Me.txtMedicos_PorcientoPorCita.Size = New System.Drawing.Size(49, 20)
        Me.txtMedicos_PorcientoPorCita.TabIndex = 75
        Me.txtMedicos_PorcientoPorCita.Text = "0,00 %"
        Me.txtMedicos_PorcientoPorCita.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'MEDICOBindingSource
        '
        Me.MEDICOBindingSource.DataSource = GetType(centro_medico.MEDICO)
        '
        'lblPorcientocitasparaMedico
        '
        Me.lblPorcientocitasparaMedico.Location = New System.Drawing.Point(15, 463)
        Me.lblPorcientocitasparaMedico.Name = "lblPorcientocitasparaMedico"
        Me.lblPorcientocitasparaMedico.Size = New System.Drawing.Size(175, 20)
        Me.lblPorcientocitasparaMedico.TabIndex = 74
        Me.lblPorcientocitasparaMedico.Text = "Porciento citas para este médico"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackgroundImage = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Eliminar.FlatAppearance.BorderSize = 0
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Location = New System.Drawing.Point(957, 248)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(16, 16)
        Me.btn_Eliminar.TabIndex = 73
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_ADD
        '
        Me.btn_ADD.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.btn_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ADD.FlatAppearance.BorderSize = 0
        Me.btn_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ADD.Location = New System.Drawing.Point(938, 248)
        Me.btn_ADD.Name = "btn_ADD"
        Me.btn_ADD.Size = New System.Drawing.Size(16, 16)
        Me.btn_ADD.TabIndex = 72
        Me.btn_ADD.UseVisualStyleBackColor = True
        '
        'ptbFirma
        '
        Me.ptbFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbFirma.Location = New System.Drawing.Point(735, 264)
        Me.ptbFirma.Name = "ptbFirma"
        Me.ptbFirma.Size = New System.Drawing.Size(238, 121)
        Me.ptbFirma.TabIndex = 69
        Me.ptbFirma.TabStop = False
        '
        'lb_letra
        '
        Me.lb_letra.BackColor = System.Drawing.Color.Silver
        Me.lb_letra.Location = New System.Drawing.Point(151, 96)
        Me.lb_letra.Name = "lb_letra"
        Me.lb_letra.Size = New System.Drawing.Size(23, 20)
        Me.lb_letra.TabIndex = 4
        Me.lb_letra.Text = "-"
        Me.lb_letra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_observaciones
        '
        Me.tb_observaciones.AcceptsReturn = True
        Me.tb_observaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "OBSERVACIONES", True))
        Me.tb_observaciones.Location = New System.Drawing.Point(18, 267)
        Me.tb_observaciones.MaxLength = 120
        Me.tb_observaciones.Multiline = True
        Me.tb_observaciones.Name = "tb_observaciones"
        Me.tb_observaciones.Size = New System.Drawing.Size(698, 174)
        Me.tb_observaciones.TabIndex = 13
        '
        'tb_nombre
        '
        Me.tb_nombre.AcceptsReturn = True
        Me.tb_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "NOMBRE", True))
        Me.tb_nombre.Location = New System.Drawing.Point(476, 40)
        Me.tb_nombre.MaxLength = 25
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(219, 20)
        Me.tb_nombre.TabIndex = 2
        '
        'tb_apellido1
        '
        Me.tb_apellido1.AcceptsReturn = True
        Me.tb_apellido1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "APELLIDO1", True))
        Me.tb_apellido1.Location = New System.Drawing.Point(18, 40)
        Me.tb_apellido1.MaxLength = 15
        Me.tb_apellido1.Name = "tb_apellido1"
        Me.tb_apellido1.Size = New System.Drawing.Size(195, 20)
        Me.tb_apellido1.TabIndex = 0
        '
        'tb_apellido2
        '
        Me.tb_apellido2.AcceptsReturn = True
        Me.tb_apellido2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "APELLIDO2", True))
        Me.tb_apellido2.Location = New System.Drawing.Point(234, 40)
        Me.tb_apellido2.MaxLength = 15
        Me.tb_apellido2.Name = "tb_apellido2"
        Me.tb_apellido2.Size = New System.Drawing.Size(224, 20)
        Me.tb_apellido2.TabIndex = 1
        '
        'tb_direccion
        '
        Me.tb_direccion.AcceptsReturn = True
        Me.tb_direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "DOMICILIO", True))
        Me.tb_direccion.Location = New System.Drawing.Point(476, 96)
        Me.tb_direccion.MaxLength = 150
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(483, 20)
        Me.tb_direccion.TabIndex = 7
        '
        'tb_telefono
        '
        Me.tb_telefono.AcceptsReturn = True
        Me.tb_telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "TLFNO", True))
        Me.tb_telefono.Location = New System.Drawing.Point(188, 96)
        Me.tb_telefono.MaxLength = 10
        Me.tb_telefono.Name = "tb_telefono"
        Me.tb_telefono.Size = New System.Drawing.Size(134, 20)
        Me.tb_telefono.TabIndex = 5
        '
        'tb_movil
        '
        Me.tb_movil.AcceptsReturn = True
        Me.tb_movil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "MOVIL", True))
        Me.tb_movil.Location = New System.Drawing.Point(338, 96)
        Me.tb_movil.MaxLength = 10
        Me.tb_movil.Name = "tb_movil"
        Me.tb_movil.Size = New System.Drawing.Size(120, 20)
        Me.tb_movil.TabIndex = 6
        '
        'tb_poblacion
        '
        Me.tb_poblacion.AcceptsReturn = True
        Me.tb_poblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "LOCALIDAD", True))
        Me.tb_poblacion.Location = New System.Drawing.Point(188, 155)
        Me.tb_poblacion.MaxLength = 20
        Me.tb_poblacion.Name = "tb_poblacion"
        Me.tb_poblacion.Size = New System.Drawing.Size(270, 20)
        Me.tb_poblacion.TabIndex = 9
        '
        'tb_cp
        '
        Me.tb_cp.AcceptsReturn = True
        Me.tb_cp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "CP", True))
        Me.tb_cp.Location = New System.Drawing.Point(18, 155)
        Me.tb_cp.MaxLength = 5
        Me.tb_cp.Name = "tb_cp"
        Me.tb_cp.Size = New System.Drawing.Size(156, 20)
        Me.tb_cp.TabIndex = 8
        '
        'tb_DNI
        '
        Me.tb_DNI.AcceptsReturn = True
        Me.tb_DNI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "DNI", True))
        Me.tb_DNI.Location = New System.Drawing.Point(19, 96)
        Me.tb_DNI.MaxLength = 8
        Me.tb_DNI.Name = "tb_DNI"
        Me.tb_DNI.Size = New System.Drawing.Size(134, 20)
        Me.tb_DNI.TabIndex = 3
        '
        'tb_provincia
        '
        Me.tb_provincia.AcceptsReturn = True
        Me.tb_provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "PROVINCIA", True))
        Me.tb_provincia.Location = New System.Drawing.Point(476, 155)
        Me.tb_provincia.MaxLength = 30
        Me.tb_provincia.Name = "tb_provincia"
        Me.tb_provincia.Size = New System.Drawing.Size(187, 20)
        Me.tb_provincia.TabIndex = 10
        '
        'tb_colegiado
        '
        Me.tb_colegiado.AcceptsReturn = True
        Me.tb_colegiado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "COLEGIADO", True))
        Me.tb_colegiado.Location = New System.Drawing.Point(188, 210)
        Me.tb_colegiado.MaxLength = 12
        Me.tb_colegiado.Name = "tb_colegiado"
        Me.tb_colegiado.Size = New System.Drawing.Size(208, 20)
        Me.tb_colegiado.TabIndex = 11
        '
        'tb_especialidad
        '
        Me.tb_especialidad.AcceptsReturn = True
        Me.tb_especialidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "ESPECIALIDAD", True))
        Me.tb_especialidad.Location = New System.Drawing.Point(18, 210)
        Me.tb_especialidad.MaxLength = 50
        Me.tb_especialidad.Name = "tb_especialidad"
        Me.tb_especialidad.Size = New System.Drawing.Size(156, 20)
        Me.tb_especialidad.TabIndex = 12
        '
        'tab_medicos_citas
        '
        Me.tab_medicos_citas.Controls.Add(Me.Calendar1)
        Me.tab_medicos_citas.Controls.Add(Me.GridEXCitas)
        Me.tab_medicos_citas.Controls.Add(Me.Label2)
        Me.tab_medicos_citas.Controls.Add(Me.bt_modificar)
        Me.tab_medicos_citas.Controls.Add(Me.bt_borrar)
        Me.tab_medicos_citas.Controls.Add(Me.bt_añadir)
        Me.tab_medicos_citas.Controls.Add(Me.tb_obs)
        Me.tab_medicos_citas.Location = New System.Drawing.Point(4, 22)
        Me.tab_medicos_citas.Name = "tab_medicos_citas"
        Me.tab_medicos_citas.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_medicos_citas.Size = New System.Drawing.Size(986, 499)
        Me.tab_medicos_citas.TabIndex = 1
        Me.tab_medicos_citas.Text = "Citas"
        Me.tab_medicos_citas.UseVisualStyleBackColor = True
        '
        'Calendar1
        '
        Me.Calendar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Calendar1.Location = New System.Drawing.Point(806, 16)
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.Size = New System.Drawing.Size(148, 136)
        Me.Calendar1.TabIndex = 132
        '
        'GridEXCitas
        '
        Me.GridEXCitas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXCitas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXCitas.ColumnAutoResize = True
        Me.GridEXCitas.DataSource = Me.CITAsBindingSource
        GridEXCitas_DesignTimeLayout.LayoutString = resources.GetString("GridEXCitas_DesignTimeLayout.LayoutString")
        Me.GridEXCitas.DesignTimeLayout = GridEXCitas_DesignTimeLayout
        Me.GridEXCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXCitas.GroupByBoxVisible = False
        Me.GridEXCitas.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridEXCitas.Hierarchical = True
        Me.GridEXCitas.Location = New System.Drawing.Point(6, 16)
        Me.GridEXCitas.Name = "GridEXCitas"
        Me.GridEXCitas.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXCitas.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEXCitas.Size = New System.Drawing.Size(794, 474)
        Me.GridEXCitas.TabIndex = 131
        Me.GridEXCitas.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXCitas.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(709, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Observaciones"
        '
        'bt_modificar
        '
        Me.bt_modificar.Enabled = False
        Me.bt_modificar.Image = Global.centro_medico.My.Resources.Resources.up
        Me.bt_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_modificar.Location = New System.Drawing.Point(732, 238)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(104, 23)
        Me.bt_modificar.TabIndex = 4
        Me.bt_modificar.Text = "Modificar cita"
        Me.bt_modificar.UseVisualStyleBackColor = True
        Me.bt_modificar.Visible = False
        '
        'bt_borrar
        '
        Me.bt_borrar.Enabled = False
        Me.bt_borrar.Image = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_borrar.Location = New System.Drawing.Point(732, 209)
        Me.bt_borrar.Name = "bt_borrar"
        Me.bt_borrar.Size = New System.Drawing.Size(104, 23)
        Me.bt_borrar.TabIndex = 3
        Me.bt_borrar.Text = "Borrar cita"
        Me.bt_borrar.UseVisualStyleBackColor = True
        Me.bt_borrar.Visible = False
        '
        'bt_añadir
        '
        Me.bt_añadir.Image = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_añadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_añadir.Location = New System.Drawing.Point(732, 180)
        Me.bt_añadir.Name = "bt_añadir"
        Me.bt_añadir.Size = New System.Drawing.Size(104, 23)
        Me.bt_añadir.TabIndex = 2
        Me.bt_añadir.Text = "Añadir cita"
        Me.bt_añadir.UseVisualStyleBackColor = True
        Me.bt_añadir.Visible = False
        '
        'tb_obs
        '
        Me.tb_obs.AcceptsReturn = True
        Me.tb_obs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_obs.Location = New System.Drawing.Point(809, 368)
        Me.tb_obs.Multiline = True
        Me.tb_obs.Name = "tb_obs"
        Me.tb_obs.Size = New System.Drawing.Size(158, 122)
        Me.tb_obs.TabIndex = 5
        '
        'tab_medicos_recetas
        '
        Me.tab_medicos_recetas.Controls.Add(Me.GroupBox1)
        Me.tab_medicos_recetas.Controls.Add(Me.GridEX_Recetas)
        Me.tab_medicos_recetas.Controls.Add(Me.bt_borrarreceta)
        Me.tab_medicos_recetas.Controls.Add(Me.bt_modificarreceta)
        Me.tab_medicos_recetas.Controls.Add(Me.bt_agregar)
        Me.tab_medicos_recetas.Controls.Add(Me.bt_ver)
        Me.tab_medicos_recetas.Controls.Add(Me.gb_filtrar)
        Me.tab_medicos_recetas.Controls.Add(Me.tb_receta)
        Me.tab_medicos_recetas.Location = New System.Drawing.Point(4, 22)
        Me.tab_medicos_recetas.Name = "tab_medicos_recetas"
        Me.tab_medicos_recetas.Size = New System.Drawing.Size(986, 499)
        Me.tab_medicos_recetas.TabIndex = 2
        Me.tab_medicos_recetas.Text = "Recetas"
        Me.tab_medicos_recetas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CtrlVisorDefaultApp3)
        Me.GroupBox1.Controls.Add(Me.CtrlVisorDefaultApp2)
        Me.GroupBox1.Controls.Add(Me.CtrlVisorDefaultApp1)
        Me.GroupBox1.Controls.Add(Me.bt_imagencolegio)
        Me.GroupBox1.Controls.Add(Me.bt_imagenconsejo)
        Me.GroupBox1.Controls.Add(Me.bt_fondoreceta)
        Me.GroupBox1.Controls.Add(Me.lblImagenColegio)
        Me.GroupBox1.Controls.Add(Me.lblImagenConsejo)
        Me.GroupBox1.Controls.Add(Me.lblFondoReceta)
        Me.GroupBox1.Controls.Add(Me.lblInfoRecetas)
        Me.GroupBox1.Controls.Add(Me.btImportarRecetas)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(940, 101)
        Me.GroupBox1.TabIndex = 133
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recetas Xml"
        '
        'CtrlVisorDefaultApp3
        '
        Me.CtrlVisorDefaultApp3.Location = New System.Drawing.Point(268, 46)
        Me.CtrlVisorDefaultApp3.Name = "CtrlVisorDefaultApp3"
        Me.CtrlVisorDefaultApp3.Size = New System.Drawing.Size(28, 27)
        Me.CtrlVisorDefaultApp3.TabIndex = 25
        '
        'CtrlVisorDefaultApp2
        '
        Me.CtrlVisorDefaultApp2.Location = New System.Drawing.Point(122, 47)
        Me.CtrlVisorDefaultApp2.Name = "CtrlVisorDefaultApp2"
        Me.CtrlVisorDefaultApp2.Size = New System.Drawing.Size(28, 27)
        Me.CtrlVisorDefaultApp2.TabIndex = 24
        '
        'CtrlVisorDefaultApp1
        '
        Me.CtrlVisorDefaultApp1.Location = New System.Drawing.Point(406, 47)
        Me.CtrlVisorDefaultApp1.Name = "CtrlVisorDefaultApp1"
        Me.CtrlVisorDefaultApp1.Size = New System.Drawing.Size(28, 27)
        Me.CtrlVisorDefaultApp1.TabIndex = 23
        '
        'bt_imagencolegio
        '
        Me.bt_imagencolegio.Location = New System.Drawing.Point(302, 46)
        Me.bt_imagencolegio.Name = "bt_imagencolegio"
        Me.bt_imagencolegio.Size = New System.Drawing.Size(97, 23)
        Me.bt_imagencolegio.TabIndex = 22
        Me.bt_imagencolegio.Text = "Imagen Colegio"
        Me.bt_imagencolegio.UseVisualStyleBackColor = True
        '
        'bt_imagenconsejo
        '
        Me.bt_imagenconsejo.Location = New System.Drawing.Point(157, 46)
        Me.bt_imagenconsejo.Name = "bt_imagenconsejo"
        Me.bt_imagenconsejo.Size = New System.Drawing.Size(105, 23)
        Me.bt_imagenconsejo.TabIndex = 21
        Me.bt_imagenconsejo.Text = "Imagen Consejo"
        Me.bt_imagenconsejo.UseVisualStyleBackColor = True
        '
        'bt_fondoreceta
        '
        Me.bt_fondoreceta.Location = New System.Drawing.Point(19, 46)
        Me.bt_fondoreceta.Name = "bt_fondoreceta"
        Me.bt_fondoreceta.Size = New System.Drawing.Size(97, 23)
        Me.bt_fondoreceta.TabIndex = 20
        Me.bt_fondoreceta.Text = "Fondo Receta"
        Me.bt_fondoreceta.UseVisualStyleBackColor = True
        '
        'lblImagenColegio
        '
        Me.lblImagenColegio.AutoSize = True
        Me.lblImagenColegio.Location = New System.Drawing.Point(300, 72)
        Me.lblImagenColegio.Name = "lblImagenColegio"
        Me.lblImagenColegio.Size = New System.Drawing.Size(105, 13)
        Me.lblImagenColegio.TabIndex = 19
        Me.lblImagenColegio.Text = "Ruta imagen Colegio"
        Me.lblImagenColegio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblImagenConsejo
        '
        Me.lblImagenConsejo.AutoSize = True
        Me.lblImagenConsejo.Location = New System.Drawing.Point(157, 72)
        Me.lblImagenConsejo.Name = "lblImagenConsejo"
        Me.lblImagenConsejo.Size = New System.Drawing.Size(108, 13)
        Me.lblImagenConsejo.TabIndex = 17
        Me.lblImagenConsejo.Text = "Ruta imagen Consejo"
        Me.lblImagenConsejo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFondoReceta
        '
        Me.lblFondoReceta.AutoSize = True
        Me.lblFondoReceta.Location = New System.Drawing.Point(19, 72)
        Me.lblFondoReceta.Name = "lblFondoReceta"
        Me.lblFondoReceta.Size = New System.Drawing.Size(100, 13)
        Me.lblFondoReceta.TabIndex = 15
        Me.lblFondoReceta.Text = "Ruta imagen Fondo"
        Me.lblFondoReceta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfoRecetas
        '
        Me.lblInfoRecetas.AutoSize = True
        Me.lblInfoRecetas.Location = New System.Drawing.Point(19, 23)
        Me.lblInfoRecetas.Name = "lblInfoRecetas"
        Me.lblInfoRecetas.Size = New System.Drawing.Size(230, 13)
        Me.lblInfoRecetas.TabIndex = 13
        Me.lblInfoRecetas.Text = "Actualmente no tiene ninguna receta importada"
        '
        'btImportarRecetas
        '
        Me.btImportarRecetas.Location = New System.Drawing.Point(732, 47)
        Me.btImportarRecetas.Name = "btImportarRecetas"
        Me.btImportarRecetas.Size = New System.Drawing.Size(202, 24)
        Me.btImportarRecetas.TabIndex = 12
        Me.btImportarRecetas.Text = "Importar Recetas XML"
        Me.btImportarRecetas.UseVisualStyleBackColor = True
        '
        'GridEX_Recetas
        '
        Me.GridEX_Recetas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX_Recetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX_Recetas.ColumnAutoResize = True
        Me.GridEX_Recetas.DataSource = Me.RECETAsBindingSource
        GridEX_Recetas_DesignTimeLayout.LayoutString = resources.GetString("GridEX_Recetas_DesignTimeLayout.LayoutString")
        Me.GridEX_Recetas.DesignTimeLayout = GridEX_Recetas_DesignTimeLayout
        Me.GridEX_Recetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX_Recetas.GroupByBoxVisible = False
        Me.GridEX_Recetas.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridEX_Recetas.Hierarchical = True
        Me.GridEX_Recetas.Location = New System.Drawing.Point(6, 241)
        Me.GridEX_Recetas.Name = "GridEX_Recetas"
        Me.GridEX_Recetas.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX_Recetas.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEX_Recetas.Size = New System.Drawing.Size(749, 255)
        Me.GridEX_Recetas.TabIndex = 132
        Me.GridEX_Recetas.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'bt_borrarreceta
        '
        Me.bt_borrarreceta.Image = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_borrarreceta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_borrarreceta.Location = New System.Drawing.Point(665, 402)
        Me.bt_borrarreceta.Name = "bt_borrarreceta"
        Me.bt_borrarreceta.Size = New System.Drawing.Size(109, 23)
        Me.bt_borrarreceta.TabIndex = 5
        Me.bt_borrarreceta.Text = "Borrar receta"
        Me.bt_borrarreceta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_borrarreceta.UseVisualStyleBackColor = True
        Me.bt_borrarreceta.Visible = False
        '
        'bt_modificarreceta
        '
        Me.bt_modificarreceta.Image = Global.centro_medico.My.Resources.Resources.up
        Me.bt_modificarreceta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_modificarreceta.Location = New System.Drawing.Point(540, 402)
        Me.bt_modificarreceta.Name = "bt_modificarreceta"
        Me.bt_modificarreceta.Size = New System.Drawing.Size(98, 23)
        Me.bt_modificarreceta.TabIndex = 4
        Me.bt_modificarreceta.Text = "Modificar receta"
        Me.bt_modificarreceta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_modificarreceta.UseVisualStyleBackColor = True
        Me.bt_modificarreceta.Visible = False
        '
        'bt_agregar
        '
        Me.bt_agregar.Image = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_agregar.Location = New System.Drawing.Point(421, 402)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(104, 23)
        Me.bt_agregar.TabIndex = 3
        Me.bt_agregar.Text = "Agregar receta"
        Me.bt_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_agregar.UseVisualStyleBackColor = True
        Me.bt_agregar.Visible = False
        '
        'bt_ver
        '
        Me.bt_ver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_ver.Location = New System.Drawing.Point(328, 402)
        Me.bt_ver.Name = "bt_ver"
        Me.bt_ver.Size = New System.Drawing.Size(75, 23)
        Me.bt_ver.TabIndex = 2
        Me.bt_ver.Text = "Ver receta"
        Me.bt_ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_ver.UseVisualStyleBackColor = True
        Me.bt_ver.Visible = False
        '
        'gb_filtrar
        '
        Me.gb_filtrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_filtrar.Controls.Add(Me.CtrlDiagnosticos1)
        Me.gb_filtrar.Controls.Add(Me.CtrlPaciente1)
        Me.gb_filtrar.Controls.Add(Me.bt_filtrar)
        Me.gb_filtrar.Controls.Add(Me.Label4)
        Me.gb_filtrar.Controls.Add(Me.Label6)
        Me.gb_filtrar.Controls.Add(Me.Label3)
        Me.gb_filtrar.Controls.Add(Me.dtp_ff)
        Me.gb_filtrar.Controls.Add(Me.dtp_fi)
        Me.gb_filtrar.Controls.Add(Me.gb_ordenar)
        Me.gb_filtrar.Location = New System.Drawing.Point(3, 4)
        Me.gb_filtrar.Name = "gb_filtrar"
        Me.gb_filtrar.Size = New System.Drawing.Size(940, 129)
        Me.gb_filtrar.TabIndex = 0
        Me.gb_filtrar.TabStop = False
        Me.gb_filtrar.Text = "Filtrar"
        '
        'CtrlDiagnosticos1
        '
        Me.CtrlDiagnosticos1.ID_DIAGNOSTICOS = Nothing
        Me.CtrlDiagnosticos1.Location = New System.Drawing.Point(414, 88)
        Me.CtrlDiagnosticos1.Name = "CtrlDiagnosticos1"
        Me.CtrlDiagnosticos1.Size = New System.Drawing.Size(402, 25)
        Me.CtrlDiagnosticos1.TabIndex = 11
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(6, 73)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(376, 50)
        Me.CtrlPaciente1.TabIndex = 10
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.Location = New System.Drawing.Point(841, 88)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(93, 31)
        Me.bt_filtrar.TabIndex = 9
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(415, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Diagnóstico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Inicial"
        '
        'dtp_ff
        '
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(135, 42)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.ShowCheckBox = True
        Me.dtp_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(9, 42)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.ShowCheckBox = True
        Me.dtp_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fi.TabIndex = 0
        '
        'gb_ordenar
        '
        Me.gb_ordenar.Controls.Add(Me.rb_diagnostico)
        Me.gb_ordenar.Controls.Add(Me.rb_paciente)
        Me.gb_ordenar.Controls.Add(Me.rb_fecha)
        Me.gb_ordenar.Location = New System.Drawing.Point(271, 19)
        Me.gb_ordenar.Name = "gb_ordenar"
        Me.gb_ordenar.Size = New System.Drawing.Size(545, 43)
        Me.gb_ordenar.TabIndex = 2
        Me.gb_ordenar.TabStop = False
        Me.gb_ordenar.Text = "Ordenar por"
        '
        'rb_diagnostico
        '
        Me.rb_diagnostico.AutoSize = True
        Me.rb_diagnostico.Location = New System.Drawing.Point(298, 19)
        Me.rb_diagnostico.Name = "rb_diagnostico"
        Me.rb_diagnostico.Size = New System.Drawing.Size(130, 17)
        Me.rb_diagnostico.TabIndex = 2
        Me.rb_diagnostico.Text = "Codigo de diagnostico"
        Me.rb_diagnostico.UseVisualStyleBackColor = True
        '
        'rb_paciente
        '
        Me.rb_paciente.AutoSize = True
        Me.rb_paciente.Location = New System.Drawing.Point(161, 19)
        Me.rb_paciente.Name = "rb_paciente"
        Me.rb_paciente.Size = New System.Drawing.Size(117, 17)
        Me.rb_paciente.TabIndex = 1
        Me.rb_paciente.Text = "Codigo de paciente"
        Me.rb_paciente.UseVisualStyleBackColor = True
        '
        'rb_fecha
        '
        Me.rb_fecha.AutoSize = True
        Me.rb_fecha.Checked = True
        Me.rb_fecha.Location = New System.Drawing.Point(24, 19)
        Me.rb_fecha.Name = "rb_fecha"
        Me.rb_fecha.Size = New System.Drawing.Size(87, 17)
        Me.rb_fecha.TabIndex = 0
        Me.rb_fecha.TabStop = True
        Me.rb_fecha.Text = "Fecha y hora"
        Me.rb_fecha.UseVisualStyleBackColor = True
        '
        'tb_receta
        '
        Me.tb_receta.AcceptsReturn = True
        Me.tb_receta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_receta.Location = New System.Drawing.Point(761, 241)
        Me.tb_receta.Multiline = True
        Me.tb_receta.Name = "tb_receta"
        Me.tb_receta.ReadOnly = True
        Me.tb_receta.Size = New System.Drawing.Size(184, 255)
        Me.tb_receta.TabIndex = 1
        '
        'tab_medicos_conceptosfacturables
        '
        Me.tab_medicos_conceptosfacturables.Controls.Add(Me.GridEXRegulares)
        Me.tab_medicos_conceptosfacturables.Controls.Add(Me.btnConceptoFRA_REMOVE)
        Me.tab_medicos_conceptosfacturables.Controls.Add(Me.btnConceptoFRA_TODOS)
        Me.tab_medicos_conceptosfacturables.Controls.Add(Me.btnConceptoFRA_ADD)
        Me.tab_medicos_conceptosfacturables.Location = New System.Drawing.Point(4, 22)
        Me.tab_medicos_conceptosfacturables.Name = "tab_medicos_conceptosfacturables"
        Me.tab_medicos_conceptosfacturables.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_medicos_conceptosfacturables.Size = New System.Drawing.Size(986, 499)
        Me.tab_medicos_conceptosfacturables.TabIndex = 3
        Me.tab_medicos_conceptosfacturables.Text = "Conceptos Facturables"
        Me.tab_medicos_conceptosfacturables.UseVisualStyleBackColor = True
        '
        'GridEXRegulares
        '
        Me.GridEXRegulares.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXRegulares.AutoEdit = True
        Me.GridEXRegulares.ColumnAutoResize = True
        Me.GridEXRegulares.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.ColumnHeader
        Me.GridEXRegulares.DataSource = Me.MEDICOSCONCEPTOFRAsBindingSource
        GridEXRegulares_DesignTimeLayout.LayoutString = resources.GetString("GridEXRegulares_DesignTimeLayout.LayoutString")
        Me.GridEXRegulares.DesignTimeLayout = GridEXRegulares_DesignTimeLayout
        Me.GridEXRegulares.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEXRegulares.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEXRegulares.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridEXRegulares.GroupByBoxVisible = False
        Me.GridEXRegulares.Hierarchical = True
        Me.GridEXRegulares.Location = New System.Drawing.Point(6, 28)
        Me.GridEXRegulares.Name = "GridEXRegulares"
        Me.GridEXRegulares.Size = New System.Drawing.Size(960, 465)
        Me.GridEXRegulares.TabIndex = 4
        Me.GridEXRegulares.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXRegulares.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEXRegulares.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        '
        'btnConceptoFRA_REMOVE
        '
        Me.btnConceptoFRA_REMOVE.BackgroundImage = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.btnConceptoFRA_REMOVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConceptoFRA_REMOVE.Enabled = False
        Me.btnConceptoFRA_REMOVE.FlatAppearance.BorderSize = 0
        Me.btnConceptoFRA_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConceptoFRA_REMOVE.Location = New System.Drawing.Point(28, 6)
        Me.btnConceptoFRA_REMOVE.Name = "btnConceptoFRA_REMOVE"
        Me.btnConceptoFRA_REMOVE.Size = New System.Drawing.Size(16, 16)
        Me.btnConceptoFRA_REMOVE.TabIndex = 40
        Me.btnConceptoFRA_REMOVE.UseVisualStyleBackColor = True
        '
        'btnConceptoFRA_TODOS
        '
        Me.btnConceptoFRA_TODOS.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_imageset
        Me.btnConceptoFRA_TODOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConceptoFRA_TODOS.FlatAppearance.BorderSize = 0
        Me.btnConceptoFRA_TODOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConceptoFRA_TODOS.Location = New System.Drawing.Point(74, 3)
        Me.btnConceptoFRA_TODOS.Name = "btnConceptoFRA_TODOS"
        Me.btnConceptoFRA_TODOS.Size = New System.Drawing.Size(103, 24)
        Me.btnConceptoFRA_TODOS.TabIndex = 39
        Me.btnConceptoFRA_TODOS.Text = "Insertar todos "
        Me.btnConceptoFRA_TODOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConceptoFRA_TODOS.UseVisualStyleBackColor = True
        '
        'btnConceptoFRA_ADD
        '
        Me.btnConceptoFRA_ADD.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btnConceptoFRA_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConceptoFRA_ADD.FlatAppearance.BorderSize = 0
        Me.btnConceptoFRA_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConceptoFRA_ADD.Location = New System.Drawing.Point(6, 6)
        Me.btnConceptoFRA_ADD.Name = "btnConceptoFRA_ADD"
        Me.btnConceptoFRA_ADD.Size = New System.Drawing.Size(16, 16)
        Me.btnConceptoFRA_ADD.TabIndex = 39
        Me.btnConceptoFRA_ADD.UseVisualStyleBackColor = True
        '
        'tab_medicos_calendarios
        '
        Me.tab_medicos_calendarios.Controls.Add(Me.CtrlHorarios1)
        Me.tab_medicos_calendarios.Location = New System.Drawing.Point(4, 22)
        Me.tab_medicos_calendarios.Name = "tab_medicos_calendarios"
        Me.tab_medicos_calendarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_medicos_calendarios.Size = New System.Drawing.Size(986, 499)
        Me.tab_medicos_calendarios.TabIndex = 4
        Me.tab_medicos_calendarios.Text = "Calendario"
        Me.tab_medicos_calendarios.UseVisualStyleBackColor = True
        '
        'CtrlHorarios1
        '
        Me.CtrlHorarios1.Anno = 2012
        Me.CtrlHorarios1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlHorarios1.CalendarioXML = Nothing
        Me.CtrlHorarios1.Location = New System.Drawing.Point(6, 6)
        Me.CtrlHorarios1.Name = "CtrlHorarios1"
        Me.CtrlHorarios1.Size = New System.Drawing.Size(862, 529)
        Me.CtrlHorarios1.TabIndex = 0
        '
        'tab_medicos_ficheros
        '
        Me.tab_medicos_ficheros.Controls.Add(Me.lblMsg)
        Me.tab_medicos_ficheros.Controls.Add(Me.FICHEROBindingNavigator)
        Me.tab_medicos_ficheros.Controls.Add(Me.GridEX1)
        Me.tab_medicos_ficheros.Location = New System.Drawing.Point(4, 22)
        Me.tab_medicos_ficheros.Name = "tab_medicos_ficheros"
        Me.tab_medicos_ficheros.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_medicos_ficheros.Size = New System.Drawing.Size(986, 499)
        Me.tab_medicos_ficheros.TabIndex = 5
        Me.tab_medicos_ficheros.Text = "Ficheros"
        Me.tab_medicos_ficheros.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(6, 474)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(637, 13)
        Me.lblMsg.TabIndex = 4
        Me.lblMsg.Text = "NOTA: Los ficheros adjuntos, visualizados y luego editados desde aqui no conserva" & _
    "ran los cambios realizados."
        '
        'FICHEROBindingNavigator
        '
        Me.FICHEROBindingNavigator.AddNewItem = Nothing
        Me.FICHEROBindingNavigator.CountItem = Nothing
        Me.FICHEROBindingNavigator.DeleteItem = Nothing
        Me.FICHEROBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevoFichero, Me.tstModificarFichero, Me.tstEliminarFichero})
        Me.FICHEROBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.FICHEROBindingNavigator.MoveFirstItem = Nothing
        Me.FICHEROBindingNavigator.MoveLastItem = Nothing
        Me.FICHEROBindingNavigator.MoveNextItem = Nothing
        Me.FICHEROBindingNavigator.MovePreviousItem = Nothing
        Me.FICHEROBindingNavigator.Name = "FICHEROBindingNavigator"
        Me.FICHEROBindingNavigator.PositionItem = Nothing
        Me.FICHEROBindingNavigator.Size = New System.Drawing.Size(980, 25)
        Me.FICHEROBindingNavigator.TabIndex = 3
        Me.FICHEROBindingNavigator.Text = "BindingNavigator1"
        '
        'tstNuevoFichero
        '
        Me.tstNuevoFichero.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstNuevoFichero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNuevoFichero.Name = "tstNuevoFichero"
        Me.tstNuevoFichero.Size = New System.Drawing.Size(62, 22)
        Me.tstNuevoFichero.Text = "&Nuevo"
        '
        'tstModificarFichero
        '
        Me.tstModificarFichero.Enabled = False
        Me.tstModificarFichero.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tstModificarFichero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstModificarFichero.Name = "tstModificarFichero"
        Me.tstModificarFichero.Size = New System.Drawing.Size(78, 22)
        Me.tstModificarFichero.Text = "&Modificar"
        '
        'tstEliminarFichero
        '
        Me.tstEliminarFichero.Enabled = False
        Me.tstEliminarFichero.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tstEliminarFichero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstEliminarFichero.Name = "tstEliminarFichero"
        Me.tstEliminarFichero.Size = New System.Drawing.Size(59, 22)
        Me.tstEliminarFichero.Text = "&Borrar"
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "re aquí una columna para agrupar</GroupByBoxInfo></LocalizableData>"
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.ColumnHeader
        Me.GridEX1.DataSource = Me.MEDICOSFICHEROsBindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(5, 31)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(991, 430)
        Me.GridEX1.TabIndex = 2
        '
        'bt_cancel
        '
        Me.bt_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(922, 533)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 4
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(828, 533)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 3
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'frmMedicos_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 571)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.tab_medicos)
        Me.Name = "frmMedicos_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Médico"
        Me.tab_medicos.ResumeLayout(False)
        Me.tab_medicos_datos.ResumeLayout(False)
        Me.tab_medicos_datos.PerformLayout()
        CType(Me.MEDICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbFirma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_medicos_citas.ResumeLayout(False)
        Me.tab_medicos_citas.PerformLayout()
        CType(Me.Calendar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXCitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_medicos_recetas.ResumeLayout(False)
        Me.tab_medicos_recetas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridEX_Recetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECETAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_filtrar.ResumeLayout(False)
        Me.gb_filtrar.PerformLayout()
        Me.gb_ordenar.ResumeLayout(False)
        Me.gb_ordenar.PerformLayout()
        Me.tab_medicos_conceptosfacturables.ResumeLayout(False)
        CType(Me.GridEXRegulares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSCONCEPTOFRAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_medicos_calendarios.ResumeLayout(False)
        Me.tab_medicos_ficheros.ResumeLayout(False)
        Me.tab_medicos_ficheros.PerformLayout()
        CType(Me.FICHEROBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FICHEROBindingNavigator.ResumeLayout(False)
        Me.FICHEROBindingNavigator.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSFICHEROsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_medicos As System.Windows.Forms.TabControl
    Friend WithEvents tab_medicos_datos As System.Windows.Forms.TabPage
    Friend WithEvents ptbFirma As System.Windows.Forms.PictureBox
    Friend WithEvents lb_letra As System.Windows.Forms.Label
    Friend WithEvents tb_observaciones As ctrlTextboxAvanzado
    Friend WithEvents tb_nombre As ctrlTextboxAvanzado
    Friend WithEvents tb_apellido1 As ctrlTextboxAvanzado
    Friend WithEvents tb_apellido2 As ctrlTextboxAvanzado
    Friend WithEvents tb_direccion As ctrlTextboxAvanzado
    Friend WithEvents tb_telefono As ctrlTextboxAvanzado
    Friend WithEvents tb_movil As ctrlTextboxAvanzado
    Friend WithEvents tb_poblacion As ctrlTextboxAvanzado
    Friend WithEvents tb_cp As ctrlTextboxAvanzado
    Friend WithEvents tb_DNI As ctrlTextboxAvanzado
    Friend WithEvents tb_provincia As ctrlTextboxAvanzado
    Friend WithEvents tb_colegiado As ctrlTextboxAvanzado
    Friend WithEvents tb_especialidad As ctrlTextboxAvanzado
    Friend WithEvents tab_medicos_citas As System.Windows.Forms.TabPage
    Friend WithEvents tb_obs As ctrlTextboxAvanzado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents bt_borrar As System.Windows.Forms.Button
    Friend WithEvents bt_añadir As System.Windows.Forms.Button
    Friend WithEvents tab_medicos_recetas As System.Windows.Forms.TabPage
    Friend WithEvents bt_borrarreceta As System.Windows.Forms.Button
    Friend WithEvents bt_modificarreceta As System.Windows.Forms.Button
    Friend WithEvents bt_agregar As System.Windows.Forms.Button
    Friend WithEvents bt_ver As System.Windows.Forms.Button
    Friend WithEvents tb_receta As ctrlTextboxAvanzado
    Friend WithEvents gb_filtrar As System.Windows.Forms.GroupBox
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents gb_ordenar As System.Windows.Forms.GroupBox
    Friend WithEvents rb_diagnostico As System.Windows.Forms.RadioButton
    Friend WithEvents rb_paciente As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fecha As System.Windows.Forms.RadioButton
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents Calendar1 As Janus.Windows.Schedule.Calendar
    Friend WithEvents GridEXCitas As Janus.Windows.GridEX.GridEX
    Friend WithEvents MEDICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridEX_Recetas As Janus.Windows.GridEX.GridEX
    Friend WithEvents CtrlDiagnosticos1 As centro_medico.ctrlDiagnosticos
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_ADD As System.Windows.Forms.Button
    Friend WithEvents txtMedicos_PorcientoPorCita As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcientocitasparaMedico As System.Windows.Forms.Label
    Friend WithEvents tab_medicos_conceptosfacturables As System.Windows.Forms.TabPage
    Friend WithEvents GridEXRegulares As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConceptoFRA_REMOVE As System.Windows.Forms.Button
    Friend WithEvents btnConceptoFRA_ADD As System.Windows.Forms.Button
    Friend WithEvents btnConceptoFRA_TODOS As System.Windows.Forms.Button
    Friend WithEvents tab_medicos_calendarios As System.Windows.Forms.TabPage
    Friend WithEvents CtrlHorarios1 As centro_medico.ctrlHorarios
    Friend WithEvents tab_medicos_ficheros As System.Windows.Forms.TabPage
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents RECETAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CITAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FICHEROBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents tstNuevoFichero As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstModificarFichero As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstEliminarFichero As System.Windows.Forms.ToolStripButton
    Friend WithEvents MEDICOSCONCEPTOFRAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICOSFICHEROsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btImportarRecetas As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblInfoRecetas As System.Windows.Forms.Label
    Friend WithEvents lblImagenColegio As System.Windows.Forms.Label
    Friend WithEvents lblImagenConsejo As System.Windows.Forms.Label
    Friend WithEvents lblFondoReceta As System.Windows.Forms.Label
    Friend WithEvents bt_imagencolegio As System.Windows.Forms.Button
    Friend WithEvents bt_imagenconsejo As System.Windows.Forms.Button
    Friend WithEvents bt_fondoreceta As System.Windows.Forms.Button
    Friend WithEvents CtrlVisorDefaultApp3 As centro_medico.ctrlVisorDefaultApp
    Friend WithEvents CtrlVisorDefaultApp2 As centro_medico.ctrlVisorDefaultApp
    Friend WithEvents CtrlVisorDefaultApp1 As centro_medico.ctrlVisorDefaultApp
End Class
