<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartes_ADD
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
        Dim ID_ParteLabel As System.Windows.Forms.Label
        Dim FechaBajaLabel As System.Windows.Forms.Label
        Dim FechaATLabel As System.Windows.Forms.Label
        Dim Num_Tarjeta_sanitariaLabel As System.Windows.Forms.Label
        Dim Num_Afiliacion_Seg_SocialLabel As System.Windows.Forms.Label
        Dim DomicilioPacienteLabel As System.Windows.Forms.Label
        Dim LocalidadPacienteLabel As System.Windows.Forms.Label
        Dim Codigo_PostalPacienteLabel As System.Windows.Forms.Label
        Dim TelefonoPacienteLabel As System.Windows.Forms.Label
        Dim Puesto_de_trabajoPacienteLabel As System.Windows.Forms.Label
        Dim DomicilioEmpresaLabel As System.Windows.Forms.Label
        Dim LocalidadEmpresaLabel As System.Windows.Forms.Label
        Dim Codigo_Postal_EmpresaLabel As System.Windows.Forms.Label
        Dim Actividad_empresaLabel As System.Windows.Forms.Label
        Dim Código_Nacional_Actividad_Económica_CNAELabel As System.Windows.Forms.Label
        Dim Entidad_Pago_IT_CPLabel As System.Windows.Forms.Label
        Dim DescripcionLimitacionLabel As System.Windows.Forms.Label
        Dim No_de_ColegiadoMedicoLabel As System.Windows.Forms.Label
        Dim E_TipoLabel As System.Windows.Forms.Label
        Dim Alta_Descripcion_Resultado_ReconocimientoLabel As System.Windows.Forms.Label
        Dim E_RegimenLabel As System.Windows.Forms.Label
        Dim E_SituacionLabel As System.Windows.Forms.Label
        Dim E_CaracterLabel As System.Windows.Forms.Label
        Dim E_Causa_de_bajaLabel As System.Windows.Forms.Label
        Dim Alta_E_Causa_de_AltaLabel As System.Windows.Forms.Label
        Dim FechaAltaLabel As System.Windows.Forms.Label
        Dim NombreCompletoPacienteLabel As System.Windows.Forms.Label
        Dim NombreEmpresaLabel As System.Windows.Forms.Label
        Dim NombreMedicoLabel As System.Windows.Forms.Label
        Dim ID_DiagnosticoLabel As System.Windows.Forms.Label
        Dim Duracion_estandar_fecha_finalLabel As System.Windows.Forms.Label
        Dim Duracion_estandar_fecha_inicioLabel As System.Windows.Forms.Label
        Dim Duracion_probable_baja_mesesLabel As System.Windows.Forms.Label
        Dim Duracion_probable_baja_diasLabel As System.Windows.Forms.Label
        Dim ProvinciaPacienteLabel As System.Windows.Forms.Label
        Dim ProvinciaEmpresaLabel As System.Windows.Forms.Label
        Me.N_PartesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CM3DataSet = New centro_medico.CM3DataSet()
        Me.FechaBajaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaATDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ts_Guardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.E_TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaAltaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnDardeAlta = New System.Windows.Forms.Button()
        Me.groupPaciente = New System.Windows.Forms.GroupBox()
        Me.CtrlPaciente21 = New centro_medico.ctrlPaciente2()
        Me.ProvinciaPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Num_Tarjeta_sanitariaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Num_Afiliacion_Seg_SocialTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DomicilioPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.LocalidadPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Codigo_PostalPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.TelefonoPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Puesto_de_trabajoPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.grpEmpresa = New System.Windows.Forms.GroupBox()
        Me.rb_ISM = New System.Windows.Forms.RadioButton()
        Me.rb_INSS = New System.Windows.Forms.RadioButton()
        Me.btn_BuscarEmpresa = New System.Windows.Forms.Button()
        Me.ProvinciaEmpresaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.NombreEmpresaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.LocalidadEmpresaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DomicilioEmpresaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Codigo_Postal_EmpresaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Actividad_empresaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Código_Nacional_Actividad_Económica_CNAETextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.groupMedico = New System.Windows.Forms.GroupBox()
        Me.btn_BuscarMedico = New System.Windows.Forms.Button()
        Me.NombreMedicoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.No_de_ColegiadoMedicoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.grpDatosBasicos = New System.Windows.Forms.GroupBox()
        Me.E_CaracterComboBox = New System.Windows.Forms.ComboBox()
        Me.E_SituacionComboBox = New System.Windows.Forms.ComboBox()
        Me.E_RegimenComboBox = New System.Windows.Forms.ComboBox()
        Me.ID_ParteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.E_Causa_de_bajaComboBox = New System.Windows.Forms.ComboBox()
        Me.Alta_E_Causa_de_AltaComboBox = New System.Windows.Forms.ComboBox()
        Me.groupAlta = New System.Windows.Forms.GroupBox()
        Me.Alta_Descripcion_Resultado_ReconocimientoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.groupBaja = New System.Windows.Forms.GroupBox()
        Me.chk_Recaida = New System.Windows.Forms.CheckBox()
        Me.groupDuracion = New System.Windows.Forms.GroupBox()
        Me.Duracion_probable_baja_diasTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Duracion_estandar_fecha_finalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Duracion_estandar_fecha_inicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Duracion_probable_baja_mesesTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DescripcionLimitacionTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter()
        Me.N_PartesTableAdapter = New centro_medico.CM3DataSetTableAdapters.N_PartesTableAdapter()
        Me.group_Proceso = New System.Windows.Forms.GroupBox()
        Me.btnVerProceso = New System.Windows.Forms.Button()
        Me.lblCitaProcesoInfo = New System.Windows.Forms.Label()
        Me.btn_HistorialProcesos = New System.Windows.Forms.Button()
        Me.CtrlDiagnosticos1 = New centro_medico.ctrlDiagnosticos()
        ID_ParteLabel = New System.Windows.Forms.Label()
        FechaBajaLabel = New System.Windows.Forms.Label()
        FechaATLabel = New System.Windows.Forms.Label()
        Num_Tarjeta_sanitariaLabel = New System.Windows.Forms.Label()
        Num_Afiliacion_Seg_SocialLabel = New System.Windows.Forms.Label()
        DomicilioPacienteLabel = New System.Windows.Forms.Label()
        LocalidadPacienteLabel = New System.Windows.Forms.Label()
        Codigo_PostalPacienteLabel = New System.Windows.Forms.Label()
        TelefonoPacienteLabel = New System.Windows.Forms.Label()
        Puesto_de_trabajoPacienteLabel = New System.Windows.Forms.Label()
        DomicilioEmpresaLabel = New System.Windows.Forms.Label()
        LocalidadEmpresaLabel = New System.Windows.Forms.Label()
        Codigo_Postal_EmpresaLabel = New System.Windows.Forms.Label()
        Actividad_empresaLabel = New System.Windows.Forms.Label()
        Código_Nacional_Actividad_Económica_CNAELabel = New System.Windows.Forms.Label()
        Entidad_Pago_IT_CPLabel = New System.Windows.Forms.Label()
        DescripcionLimitacionLabel = New System.Windows.Forms.Label()
        No_de_ColegiadoMedicoLabel = New System.Windows.Forms.Label()
        E_TipoLabel = New System.Windows.Forms.Label()
        Alta_Descripcion_Resultado_ReconocimientoLabel = New System.Windows.Forms.Label()
        E_RegimenLabel = New System.Windows.Forms.Label()
        E_SituacionLabel = New System.Windows.Forms.Label()
        E_CaracterLabel = New System.Windows.Forms.Label()
        E_Causa_de_bajaLabel = New System.Windows.Forms.Label()
        Alta_E_Causa_de_AltaLabel = New System.Windows.Forms.Label()
        FechaAltaLabel = New System.Windows.Forms.Label()
        NombreCompletoPacienteLabel = New System.Windows.Forms.Label()
        NombreEmpresaLabel = New System.Windows.Forms.Label()
        NombreMedicoLabel = New System.Windows.Forms.Label()
        ID_DiagnosticoLabel = New System.Windows.Forms.Label()
        Duracion_estandar_fecha_finalLabel = New System.Windows.Forms.Label()
        Duracion_estandar_fecha_inicioLabel = New System.Windows.Forms.Label()
        Duracion_probable_baja_mesesLabel = New System.Windows.Forms.Label()
        Duracion_probable_baja_diasLabel = New System.Windows.Forms.Label()
        ProvinciaPacienteLabel = New System.Windows.Forms.Label()
        ProvinciaEmpresaLabel = New System.Windows.Forms.Label()
        CType(Me.N_PartesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.groupPaciente.SuspendLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmpresa.SuspendLayout()
        Me.groupMedico.SuspendLayout()
        Me.grpDatosBasicos.SuspendLayout()
        Me.groupAlta.SuspendLayout()
        Me.groupBaja.SuspendLayout()
        Me.groupDuracion.SuspendLayout()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_Proceso.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_ParteLabel
        '
        ID_ParteLabel.AutoSize = True
        ID_ParteLabel.Location = New System.Drawing.Point(24, 28)
        ID_ParteLabel.Name = "ID_ParteLabel"
        ID_ParteLabel.Size = New System.Drawing.Size(43, 13)
        ID_ParteLabel.TabIndex = 1
        ID_ParteLabel.Text = "Codigo:"
        '
        'FechaBajaLabel
        '
        FechaBajaLabel.AutoSize = True
        FechaBajaLabel.Location = New System.Drawing.Point(43, 24)
        FechaBajaLabel.Name = "FechaBajaLabel"
        FechaBajaLabel.Size = New System.Drawing.Size(64, 13)
        FechaBajaLabel.TabIndex = 7
        FechaBajaLabel.Text = "Fecha Baja:"
        '
        'FechaATLabel
        '
        FechaATLabel.AutoSize = True
        FechaATLabel.Location = New System.Drawing.Point(10, 92)
        FechaATLabel.Name = "FechaATLabel"
        FechaATLabel.Size = New System.Drawing.Size(57, 13)
        FechaATLabel.TabIndex = 17
        FechaATLabel.Text = "Fecha AT:"
        '
        'Num_Tarjeta_sanitariaLabel
        '
        Num_Tarjeta_sanitariaLabel.AutoSize = True
        Num_Tarjeta_sanitariaLabel.Location = New System.Drawing.Point(9, 83)
        Num_Tarjeta_sanitariaLabel.Name = "Num_Tarjeta_sanitariaLabel"
        Num_Tarjeta_sanitariaLabel.Size = New System.Drawing.Size(110, 13)
        Num_Tarjeta_sanitariaLabel.TabIndex = 23
        Num_Tarjeta_sanitariaLabel.Text = "Nro. Tarjeta Sanitaria:"
        '
        'Num_Afiliacion_Seg_SocialLabel
        '
        Num_Afiliacion_Seg_SocialLabel.AutoSize = True
        Num_Afiliacion_Seg_SocialLabel.Location = New System.Drawing.Point(9, 114)
        Num_Afiliacion_Seg_SocialLabel.Name = "Num_Afiliacion_Seg_SocialLabel"
        Num_Afiliacion_Seg_SocialLabel.Size = New System.Drawing.Size(113, 13)
        Num_Afiliacion_Seg_SocialLabel.TabIndex = 25
        Num_Afiliacion_Seg_SocialLabel.Text = "Nro. Seguridad Social:"
        '
        'DomicilioPacienteLabel
        '
        DomicilioPacienteLabel.AutoSize = True
        DomicilioPacienteLabel.Location = New System.Drawing.Point(375, 114)
        DomicilioPacienteLabel.Name = "DomicilioPacienteLabel"
        DomicilioPacienteLabel.Size = New System.Drawing.Size(52, 13)
        DomicilioPacienteLabel.TabIndex = 29
        DomicilioPacienteLabel.Text = "Domicilio:"
        '
        'LocalidadPacienteLabel
        '
        LocalidadPacienteLabel.AutoSize = True
        LocalidadPacienteLabel.Location = New System.Drawing.Point(375, 142)
        LocalidadPacienteLabel.Name = "LocalidadPacienteLabel"
        LocalidadPacienteLabel.Size = New System.Drawing.Size(56, 13)
        LocalidadPacienteLabel.TabIndex = 31
        LocalidadPacienteLabel.Text = "Localidad:"
        '
        'Codigo_PostalPacienteLabel
        '
        Codigo_PostalPacienteLabel.AutoSize = True
        Codigo_PostalPacienteLabel.Location = New System.Drawing.Point(435, 57)
        Codigo_PostalPacienteLabel.Name = "Codigo_PostalPacienteLabel"
        Codigo_PostalPacienteLabel.Size = New System.Drawing.Size(75, 13)
        Codigo_PostalPacienteLabel.TabIndex = 35
        Codigo_PostalPacienteLabel.Text = "Codigo Postal:"
        '
        'TelefonoPacienteLabel
        '
        TelefonoPacienteLabel.AutoSize = True
        TelefonoPacienteLabel.Location = New System.Drawing.Point(458, 26)
        TelefonoPacienteLabel.Name = "TelefonoPacienteLabel"
        TelefonoPacienteLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoPacienteLabel.TabIndex = 37
        TelefonoPacienteLabel.Text = "Teléfono:"
        '
        'Puesto_de_trabajoPacienteLabel
        '
        Puesto_de_trabajoPacienteLabel.AutoSize = True
        Puesto_de_trabajoPacienteLabel.Location = New System.Drawing.Point(26, 50)
        Puesto_de_trabajoPacienteLabel.Name = "Puesto_de_trabajoPacienteLabel"
        Puesto_de_trabajoPacienteLabel.Size = New System.Drawing.Size(93, 13)
        Puesto_de_trabajoPacienteLabel.TabIndex = 39
        Puesto_de_trabajoPacienteLabel.Text = "Puesto de trabajo:"
        '
        'DomicilioEmpresaLabel
        '
        DomicilioEmpresaLabel.AutoSize = True
        DomicilioEmpresaLabel.Location = New System.Drawing.Point(419, 77)
        DomicilioEmpresaLabel.Name = "DomicilioEmpresaLabel"
        DomicilioEmpresaLabel.Size = New System.Drawing.Size(52, 13)
        DomicilioEmpresaLabel.TabIndex = 43
        DomicilioEmpresaLabel.Text = "Domicilio:"
        '
        'LocalidadEmpresaLabel
        '
        LocalidadEmpresaLabel.AutoSize = True
        LocalidadEmpresaLabel.Location = New System.Drawing.Point(419, 125)
        LocalidadEmpresaLabel.Name = "LocalidadEmpresaLabel"
        LocalidadEmpresaLabel.Size = New System.Drawing.Size(56, 13)
        LocalidadEmpresaLabel.TabIndex = 45
        LocalidadEmpresaLabel.Text = "Localidad:"
        '
        'Codigo_Postal_EmpresaLabel
        '
        Codigo_Postal_EmpresaLabel.AutoSize = True
        Codigo_Postal_EmpresaLabel.Location = New System.Drawing.Point(47, 151)
        Codigo_Postal_EmpresaLabel.Name = "Codigo_Postal_EmpresaLabel"
        Codigo_Postal_EmpresaLabel.Size = New System.Drawing.Size(75, 13)
        Codigo_Postal_EmpresaLabel.TabIndex = 49
        Codigo_Postal_EmpresaLabel.Text = "Codigo Postal:"
        '
        'Actividad_empresaLabel
        '
        Actividad_empresaLabel.AutoSize = True
        Actividad_empresaLabel.Location = New System.Drawing.Point(28, 62)
        Actividad_empresaLabel.Name = "Actividad_empresaLabel"
        Actividad_empresaLabel.Size = New System.Drawing.Size(97, 13)
        Actividad_empresaLabel.TabIndex = 51
        Actividad_empresaLabel.Text = "Actividad empresa:"
        '
        'Código_Nacional_Actividad_Económica_CNAELabel
        '
        Código_Nacional_Actividad_Económica_CNAELabel.AutoSize = True
        Código_Nacional_Actividad_Económica_CNAELabel.Location = New System.Drawing.Point(84, 93)
        Código_Nacional_Actividad_Económica_CNAELabel.Name = "Código_Nacional_Actividad_Económica_CNAELabel"
        Código_Nacional_Actividad_Económica_CNAELabel.Size = New System.Drawing.Size(39, 13)
        Código_Nacional_Actividad_Económica_CNAELabel.TabIndex = 53
        Código_Nacional_Actividad_Económica_CNAELabel.Text = "CNAE:"
        '
        'Entidad_Pago_IT_CPLabel
        '
        Entidad_Pago_IT_CPLabel.AutoSize = True
        Entidad_Pago_IT_CPLabel.Location = New System.Drawing.Point(19, 122)
        Entidad_Pago_IT_CPLabel.Name = "Entidad_Pago_IT_CPLabel"
        Entidad_Pago_IT_CPLabel.Size = New System.Drawing.Size(104, 13)
        Entidad_Pago_IT_CPLabel.TabIndex = 55
        Entidad_Pago_IT_CPLabel.Text = "Entidad Pago IT CP:"
        '
        'DescripcionLimitacionLabel
        '
        DescripcionLimitacionLabel.AutoSize = True
        DescripcionLimitacionLabel.Location = New System.Drawing.Point(23, 108)
        DescripcionLimitacionLabel.Name = "DescripcionLimitacionLabel"
        DescripcionLimitacionLabel.Size = New System.Drawing.Size(116, 13)
        DescripcionLimitacionLabel.TabIndex = 57
        DescripcionLimitacionLabel.Text = "Descripcion Limitación:"
        '
        'No_de_ColegiadoMedicoLabel
        '
        No_de_ColegiadoMedicoLabel.AutoSize = True
        No_de_ColegiadoMedicoLabel.Location = New System.Drawing.Point(29, 57)
        No_de_ColegiadoMedicoLabel.Name = "No_de_ColegiadoMedicoLabel"
        No_de_ColegiadoMedicoLabel.Size = New System.Drawing.Size(89, 13)
        No_de_ColegiadoMedicoLabel.TabIndex = 79
        No_de_ColegiadoMedicoLabel.Text = "No de Colegiado:"
        '
        'E_TipoLabel
        '
        E_TipoLabel.AutoSize = True
        E_TipoLabel.Location = New System.Drawing.Point(6, 59)
        E_TipoLabel.Name = "E_TipoLabel"
        E_TipoLabel.Size = New System.Drawing.Size(59, 13)
        E_TipoLabel.TabIndex = 85
        E_TipoLabel.Text = "Tipo Parte:"
        '
        'Alta_Descripcion_Resultado_ReconocimientoLabel
        '
        Alta_Descripcion_Resultado_ReconocimientoLabel.AutoSize = True
        Alta_Descripcion_Resultado_ReconocimientoLabel.Location = New System.Drawing.Point(6, 83)
        Alta_Descripcion_Resultado_ReconocimientoLabel.Name = "Alta_Descripcion_Resultado_ReconocimientoLabel"
        Alta_Descripcion_Resultado_ReconocimientoLabel.Size = New System.Drawing.Size(214, 13)
        Alta_Descripcion_Resultado_ReconocimientoLabel.TabIndex = 95
        Alta_Descripcion_Resultado_ReconocimientoLabel.Text = "Descripción Resultado del Reconocimiento:"
        '
        'E_RegimenLabel
        '
        E_RegimenLabel.AutoSize = True
        E_RegimenLabel.Location = New System.Drawing.Point(310, 27)
        E_RegimenLabel.Name = "E_RegimenLabel"
        E_RegimenLabel.Size = New System.Drawing.Size(52, 13)
        E_RegimenLabel.TabIndex = 92
        E_RegimenLabel.Text = "Régimen:"
        '
        'E_SituacionLabel
        '
        E_SituacionLabel.AutoSize = True
        E_SituacionLabel.Location = New System.Drawing.Point(308, 54)
        E_SituacionLabel.Name = "E_SituacionLabel"
        E_SituacionLabel.Size = New System.Drawing.Size(54, 13)
        E_SituacionLabel.TabIndex = 93
        E_SituacionLabel.Text = "Situación:"
        '
        'E_CaracterLabel
        '
        E_CaracterLabel.AutoSize = True
        E_CaracterLabel.Location = New System.Drawing.Point(310, 81)
        E_CaracterLabel.Name = "E_CaracterLabel"
        E_CaracterLabel.Size = New System.Drawing.Size(50, 13)
        E_CaracterLabel.TabIndex = 94
        E_CaracterLabel.Text = "Carácter:"
        '
        'E_Causa_de_bajaLabel
        '
        E_Causa_de_bajaLabel.AutoSize = True
        E_Causa_de_bajaLabel.Location = New System.Drawing.Point(19, 50)
        E_Causa_de_bajaLabel.Name = "E_Causa_de_bajaLabel"
        E_Causa_de_bajaLabel.Size = New System.Drawing.Size(89, 13)
        E_Causa_de_bajaLabel.TabIndex = 95
        E_Causa_de_bajaLabel.Text = "Causa de la baja:"
        '
        'Alta_E_Causa_de_AltaLabel
        '
        Alta_E_Causa_de_AltaLabel.AutoSize = True
        Alta_E_Causa_de_AltaLabel.Location = New System.Drawing.Point(20, 57)
        Alta_E_Causa_de_AltaLabel.Name = "Alta_E_Causa_de_AltaLabel"
        Alta_E_Causa_de_AltaLabel.Size = New System.Drawing.Size(87, 13)
        Alta_E_Causa_de_AltaLabel.TabIndex = 96
        Alta_E_Causa_de_AltaLabel.Text = "Causa de la Alta:"
        '
        'FechaAltaLabel
        '
        FechaAltaLabel.AutoSize = True
        FechaAltaLabel.Location = New System.Drawing.Point(43, 27)
        FechaAltaLabel.Name = "FechaAltaLabel"
        FechaAltaLabel.Size = New System.Drawing.Size(61, 13)
        FechaAltaLabel.TabIndex = 98
        FechaAltaLabel.Text = "Fecha Alta:"
        '
        'NombreCompletoPacienteLabel
        '
        NombreCompletoPacienteLabel.AutoSize = True
        NombreCompletoPacienteLabel.Location = New System.Drawing.Point(65, 26)
        NombreCompletoPacienteLabel.Name = "NombreCompletoPacienteLabel"
        NombreCompletoPacienteLabel.Size = New System.Drawing.Size(52, 13)
        NombreCompletoPacienteLabel.TabIndex = 40
        NombreCompletoPacienteLabel.Text = "Paciente:"
        '
        'NombreEmpresaLabel
        '
        NombreEmpresaLabel.AutoSize = True
        NombreEmpresaLabel.Location = New System.Drawing.Point(39, 29)
        NombreEmpresaLabel.Name = "NombreEmpresaLabel"
        NombreEmpresaLabel.Size = New System.Drawing.Size(91, 13)
        NombreEmpresaLabel.TabIndex = 57
        NombreEmpresaLabel.Text = "Nombre Empresa:"
        '
        'NombreMedicoLabel
        '
        NombreMedicoLabel.AutoSize = True
        NombreMedicoLabel.Location = New System.Drawing.Point(33, 30)
        NombreMedicoLabel.Name = "NombreMedicoLabel"
        NombreMedicoLabel.Size = New System.Drawing.Size(84, 13)
        NombreMedicoLabel.TabIndex = 80
        NombreMedicoLabel.Text = "Nombre médico:"
        '
        'ID_DiagnosticoLabel
        '
        ID_DiagnosticoLabel.AutoSize = True
        ID_DiagnosticoLabel.Location = New System.Drawing.Point(17, 617)
        ID_DiagnosticoLabel.Name = "ID_DiagnosticoLabel"
        ID_DiagnosticoLabel.Size = New System.Drawing.Size(66, 13)
        ID_DiagnosticoLabel.TabIndex = 59
        ID_DiagnosticoLabel.Text = "Diagnóstico:"
        '
        'Duracion_estandar_fecha_finalLabel
        '
        Duracion_estandar_fecha_finalLabel.AutoSize = True
        Duracion_estandar_fecha_finalLabel.Location = New System.Drawing.Point(12, 101)
        Duracion_estandar_fecha_finalLabel.Name = "Duracion_estandar_fecha_finalLabel"
        Duracion_estandar_fecha_finalLabel.Size = New System.Drawing.Size(149, 13)
        Duracion_estandar_fecha_finalLabel.TabIndex = 67
        Duracion_estandar_fecha_finalLabel.Text = "Duracion estandar fecha final:"
        '
        'Duracion_estandar_fecha_inicioLabel
        '
        Duracion_estandar_fecha_inicioLabel.AutoSize = True
        Duracion_estandar_fecha_inicioLabel.Location = New System.Drawing.Point(12, 75)
        Duracion_estandar_fecha_inicioLabel.Name = "Duracion_estandar_fecha_inicioLabel"
        Duracion_estandar_fecha_inicioLabel.Size = New System.Drawing.Size(154, 13)
        Duracion_estandar_fecha_inicioLabel.TabIndex = 65
        Duracion_estandar_fecha_inicioLabel.Text = "Duracion estandar fecha inicio:"
        '
        'Duracion_probable_baja_mesesLabel
        '
        Duracion_probable_baja_mesesLabel.AutoSize = True
        Duracion_probable_baja_mesesLabel.Location = New System.Drawing.Point(12, 48)
        Duracion_probable_baja_mesesLabel.Name = "Duracion_probable_baja_mesesLabel"
        Duracion_probable_baja_mesesLabel.Size = New System.Drawing.Size(153, 13)
        Duracion_probable_baja_mesesLabel.TabIndex = 63
        Duracion_probable_baja_mesesLabel.Text = "Duracion probable baja meses:"
        '
        'Duracion_probable_baja_diasLabel
        '
        Duracion_probable_baja_diasLabel.AutoSize = True
        Duracion_probable_baja_diasLabel.Location = New System.Drawing.Point(12, 22)
        Duracion_probable_baja_diasLabel.Name = "Duracion_probable_baja_diasLabel"
        Duracion_probable_baja_diasLabel.Size = New System.Drawing.Size(142, 13)
        Duracion_probable_baja_diasLabel.TabIndex = 61
        Duracion_probable_baja_diasLabel.Text = "Duracion probable baja dias:"
        '
        'ProvinciaPacienteLabel
        '
        ProvinciaPacienteLabel.AutoSize = True
        ProvinciaPacienteLabel.Location = New System.Drawing.Point(65, 142)
        ProvinciaPacienteLabel.Name = "ProvinciaPacienteLabel"
        ProvinciaPacienteLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaPacienteLabel.TabIndex = 83
        ProvinciaPacienteLabel.Text = "Provincia:"
        '
        'ProvinciaEmpresaLabel
        '
        ProvinciaEmpresaLabel.AutoSize = True
        ProvinciaEmpresaLabel.Location = New System.Drawing.Point(417, 28)
        ProvinciaEmpresaLabel.Name = "ProvinciaEmpresaLabel"
        ProvinciaEmpresaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaEmpresaLabel.TabIndex = 58
        ProvinciaEmpresaLabel.Text = "Provincia:"
        '
        'N_PartesBindingSource
        '
        Me.N_PartesBindingSource.DataMember = "N_Partes"
        Me.N_PartesBindingSource.DataSource = Me.CM3DataSet
        '
        'CM3DataSet
        '
        Me.CM3DataSet.DataSetName = "CM3DataSet"
        Me.CM3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FechaBajaDateTimePicker
        '
        Me.FechaBajaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_PartesBindingSource, "FechaBaja", True))
        Me.FechaBajaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaBajaDateTimePicker.Location = New System.Drawing.Point(113, 19)
        Me.FechaBajaDateTimePicker.Name = "FechaBajaDateTimePicker"
        Me.FechaBajaDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.FechaBajaDateTimePicker.TabIndex = 8
        '
        'FechaATDateTimePicker
        '
        Me.FechaATDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_PartesBindingSource, "FechaAT", True))
        Me.FechaATDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaATDateTimePicker.Location = New System.Drawing.Point(69, 92)
        Me.FechaATDateTimePicker.Name = "FechaATDateTimePicker"
        Me.FechaATDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.FechaATDateTimePicker.TabIndex = 18
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Guardar, Me.ToolStripSeparator1, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1083, 25)
        Me.ToolStrip1.TabIndex = 18
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
        'E_TipoComboBox
        '
        Me.E_TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.N_PartesBindingSource, "E_Tipo", True))
        Me.E_TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.E_TipoComboBox.Enabled = False
        Me.E_TipoComboBox.FormattingEnabled = True
        Me.E_TipoComboBox.Location = New System.Drawing.Point(71, 59)
        Me.E_TipoComboBox.Name = "E_TipoComboBox"
        Me.E_TipoComboBox.Size = New System.Drawing.Size(116, 21)
        Me.E_TipoComboBox.TabIndex = 86
        '
        'FechaAltaDateTimePicker
        '
        Me.FechaAltaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_PartesBindingSource, "FechaAlta", True))
        Me.FechaAltaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaAltaDateTimePicker.Location = New System.Drawing.Point(113, 23)
        Me.FechaAltaDateTimePicker.Name = "FechaAltaDateTimePicker"
        Me.FechaAltaDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.FechaAltaDateTimePicker.TabIndex = 99
        '
        'btnDardeAlta
        '
        Me.btnDardeAlta.Location = New System.Drawing.Point(190, 58)
        Me.btnDardeAlta.Name = "btnDardeAlta"
        Me.btnDardeAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnDardeAlta.TabIndex = 88
        Me.btnDardeAlta.Text = "Parte Alta"
        Me.btnDardeAlta.UseVisualStyleBackColor = True
        '
        'groupPaciente
        '
        Me.groupPaciente.Controls.Add(Me.CtrlPaciente21)
        Me.groupPaciente.Controls.Add(ProvinciaPacienteLabel)
        Me.groupPaciente.Controls.Add(Me.ProvinciaPacienteTextBox)
        Me.groupPaciente.Controls.Add(NombreCompletoPacienteLabel)
        Me.groupPaciente.Controls.Add(Me.Num_Tarjeta_sanitariaTextBox)
        Me.groupPaciente.Controls.Add(Me.Num_Afiliacion_Seg_SocialTextBox)
        Me.groupPaciente.Controls.Add(Num_Afiliacion_Seg_SocialLabel)
        Me.groupPaciente.Controls.Add(Num_Tarjeta_sanitariaLabel)
        Me.groupPaciente.Controls.Add(Me.DomicilioPacienteTextBox)
        Me.groupPaciente.Controls.Add(DomicilioPacienteLabel)
        Me.groupPaciente.Controls.Add(LocalidadPacienteLabel)
        Me.groupPaciente.Controls.Add(Me.LocalidadPacienteTextBox)
        Me.groupPaciente.Controls.Add(Codigo_PostalPacienteLabel)
        Me.groupPaciente.Controls.Add(Me.Codigo_PostalPacienteTextBox)
        Me.groupPaciente.Controls.Add(TelefonoPacienteLabel)
        Me.groupPaciente.Controls.Add(Me.TelefonoPacienteTextBox)
        Me.groupPaciente.Controls.Add(Puesto_de_trabajoPacienteLabel)
        Me.groupPaciente.Controls.Add(Me.Puesto_de_trabajoPacienteTextBox)
        Me.groupPaciente.Location = New System.Drawing.Point(7, 152)
        Me.groupPaciente.Name = "groupPaciente"
        Me.groupPaciente.Size = New System.Drawing.Size(643, 173)
        Me.groupPaciente.TabIndex = 89
        Me.groupPaciente.TabStop = False
        Me.groupPaciente.Text = "Datos Paciente"
        '
        'CtrlPaciente21
        '
        Me.CtrlPaciente21.ID_PACIENTE = Nothing
        Me.CtrlPaciente21.Location = New System.Drawing.Point(123, 18)
        Me.CtrlPaciente21.Name = "CtrlPaciente21"
        Me.CtrlPaciente21.Size = New System.Drawing.Size(308, 26)
        Me.CtrlPaciente21.TabIndex = 84
        '
        'ProvinciaPacienteTextBox
        '
        Me.ProvinciaPacienteTextBox.AcceptsReturn = True
        Me.ProvinciaPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "ProvinciaPaciente", True))
        Me.ProvinciaPacienteTextBox.Location = New System.Drawing.Point(124, 139)
        Me.ProvinciaPacienteTextBox.Name = "ProvinciaPacienteTextBox"
        Me.ProvinciaPacienteTextBox.Size = New System.Drawing.Size(151, 20)
        Me.ProvinciaPacienteTextBox.TabIndex = 4
        '
        'Num_Tarjeta_sanitariaTextBox
        '
        Me.Num_Tarjeta_sanitariaTextBox.AcceptsReturn = True
        Me.Num_Tarjeta_sanitariaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "Num_Tarjeta_sanitaria", True))
        Me.Num_Tarjeta_sanitariaTextBox.Location = New System.Drawing.Point(123, 80)
        Me.Num_Tarjeta_sanitariaTextBox.Name = "Num_Tarjeta_sanitariaTextBox"
        Me.Num_Tarjeta_sanitariaTextBox.Size = New System.Drawing.Size(191, 20)
        Me.Num_Tarjeta_sanitariaTextBox.TabIndex = 2
        '
        'Num_Afiliacion_Seg_SocialTextBox
        '
        Me.Num_Afiliacion_Seg_SocialTextBox.AcceptsReturn = True
        Me.Num_Afiliacion_Seg_SocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "Num_Afiliacion_Seg_Social", True))
        Me.Num_Afiliacion_Seg_SocialTextBox.Location = New System.Drawing.Point(123, 111)
        Me.Num_Afiliacion_Seg_SocialTextBox.Name = "Num_Afiliacion_Seg_SocialTextBox"
        Me.Num_Afiliacion_Seg_SocialTextBox.Size = New System.Drawing.Size(152, 20)
        Me.Num_Afiliacion_Seg_SocialTextBox.TabIndex = 3
        '
        'DomicilioPacienteTextBox
        '
        Me.DomicilioPacienteTextBox.AcceptsReturn = True
        Me.DomicilioPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "DomicilioPaciente", True))
        Me.DomicilioPacienteTextBox.Location = New System.Drawing.Point(432, 111)
        Me.DomicilioPacienteTextBox.Name = "DomicilioPacienteTextBox"
        Me.DomicilioPacienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DomicilioPacienteTextBox.TabIndex = 7
        '
        'LocalidadPacienteTextBox
        '
        Me.LocalidadPacienteTextBox.AcceptsReturn = True
        Me.LocalidadPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "LocalidadPaciente", True))
        Me.LocalidadPacienteTextBox.Location = New System.Drawing.Point(432, 139)
        Me.LocalidadPacienteTextBox.Name = "LocalidadPacienteTextBox"
        Me.LocalidadPacienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LocalidadPacienteTextBox.TabIndex = 8
        '
        'Codigo_PostalPacienteTextBox
        '
        Me.Codigo_PostalPacienteTextBox.AcceptsReturn = True
        Me.Codigo_PostalPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "Codigo_PostalPaciente", True))
        Me.Codigo_PostalPacienteTextBox.Location = New System.Drawing.Point(516, 50)
        Me.Codigo_PostalPacienteTextBox.Name = "Codigo_PostalPacienteTextBox"
        Me.Codigo_PostalPacienteTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Codigo_PostalPacienteTextBox.TabIndex = 6
        '
        'TelefonoPacienteTextBox
        '
        Me.TelefonoPacienteTextBox.AcceptsReturn = True
        Me.TelefonoPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "TelefonoPaciente", True))
        Me.TelefonoPacienteTextBox.Location = New System.Drawing.Point(516, 23)
        Me.TelefonoPacienteTextBox.Name = "TelefonoPacienteTextBox"
        Me.TelefonoPacienteTextBox.Size = New System.Drawing.Size(106, 20)
        Me.TelefonoPacienteTextBox.TabIndex = 5
        '
        'Puesto_de_trabajoPacienteTextBox
        '
        Me.Puesto_de_trabajoPacienteTextBox.AcceptsReturn = True
        Me.Puesto_de_trabajoPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "Puesto_de_trabajoPaciente", True))
        Me.Puesto_de_trabajoPacienteTextBox.Location = New System.Drawing.Point(123, 50)
        Me.Puesto_de_trabajoPacienteTextBox.Name = "Puesto_de_trabajoPacienteTextBox"
        Me.Puesto_de_trabajoPacienteTextBox.Size = New System.Drawing.Size(218, 20)
        Me.Puesto_de_trabajoPacienteTextBox.TabIndex = 1
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpEmpresa
        '
        Me.grpEmpresa.Controls.Add(Me.rb_ISM)
        Me.grpEmpresa.Controls.Add(Me.rb_INSS)
        Me.grpEmpresa.Controls.Add(Me.btn_BuscarEmpresa)
        Me.grpEmpresa.Controls.Add(ProvinciaEmpresaLabel)
        Me.grpEmpresa.Controls.Add(Me.ProvinciaEmpresaTextBox)
        Me.grpEmpresa.Controls.Add(NombreEmpresaLabel)
        Me.grpEmpresa.Controls.Add(Me.NombreEmpresaTextBox)
        Me.grpEmpresa.Controls.Add(LocalidadEmpresaLabel)
        Me.grpEmpresa.Controls.Add(Me.LocalidadEmpresaTextBox)
        Me.grpEmpresa.Controls.Add(Me.DomicilioEmpresaTextBox)
        Me.grpEmpresa.Controls.Add(DomicilioEmpresaLabel)
        Me.grpEmpresa.Controls.Add(Codigo_Postal_EmpresaLabel)
        Me.grpEmpresa.Controls.Add(Me.Codigo_Postal_EmpresaTextBox)
        Me.grpEmpresa.Controls.Add(Actividad_empresaLabel)
        Me.grpEmpresa.Controls.Add(Me.Actividad_empresaTextBox)
        Me.grpEmpresa.Controls.Add(Entidad_Pago_IT_CPLabel)
        Me.grpEmpresa.Controls.Add(Código_Nacional_Actividad_Económica_CNAELabel)
        Me.grpEmpresa.Controls.Add(Me.Código_Nacional_Actividad_Económica_CNAETextBox)
        Me.grpEmpresa.Location = New System.Drawing.Point(7, 331)
        Me.grpEmpresa.Name = "grpEmpresa"
        Me.grpEmpresa.Size = New System.Drawing.Size(641, 176)
        Me.grpEmpresa.TabIndex = 90
        Me.grpEmpresa.TabStop = False
        Me.grpEmpresa.Text = "Datos Empresa"
        '
        'rb_ISM
        '
        Me.rb_ISM.AutoSize = True
        Me.rb_ISM.Location = New System.Drawing.Point(190, 121)
        Me.rb_ISM.Name = "rb_ISM"
        Me.rb_ISM.Size = New System.Drawing.Size(44, 17)
        Me.rb_ISM.TabIndex = 85
        Me.rb_ISM.Text = "ISM"
        Me.rb_ISM.UseVisualStyleBackColor = True
        '
        'rb_INSS
        '
        Me.rb_INSS.AutoSize = True
        Me.rb_INSS.Checked = True
        Me.rb_INSS.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.N_PartesBindingSource, "Entidad_Pago_IT_CP", True))
        Me.rb_INSS.Location = New System.Drawing.Point(136, 121)
        Me.rb_INSS.Name = "rb_INSS"
        Me.rb_INSS.Size = New System.Drawing.Size(50, 17)
        Me.rb_INSS.TabIndex = 85
        Me.rb_INSS.TabStop = True
        Me.rb_INSS.Text = "INSS"
        Me.rb_INSS.UseVisualStyleBackColor = True
        '
        'btn_BuscarEmpresa
        '
        Me.btn_BuscarEmpresa.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btn_BuscarEmpresa.Location = New System.Drawing.Point(363, 27)
        Me.btn_BuscarEmpresa.Name = "btn_BuscarEmpresa"
        Me.btn_BuscarEmpresa.Size = New System.Drawing.Size(36, 23)
        Me.btn_BuscarEmpresa.TabIndex = 84
        Me.btn_BuscarEmpresa.UseVisualStyleBackColor = True
        '
        'ProvinciaEmpresaTextBox
        '
        Me.ProvinciaEmpresaTextBox.AcceptsReturn = True
        Me.ProvinciaEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "ProvinciaEmpresa", True))
        Me.ProvinciaEmpresaTextBox.Location = New System.Drawing.Point(418, 44)
        Me.ProvinciaEmpresaTextBox.Name = "ProvinciaEmpresaTextBox"
        Me.ProvinciaEmpresaTextBox.Size = New System.Drawing.Size(204, 20)
        Me.ProvinciaEmpresaTextBox.TabIndex = 13
        '
        'NombreEmpresaTextBox
        '
        Me.NombreEmpresaTextBox.AcceptsReturn = True
        Me.NombreEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "NombreEmpresa", True))
        Me.NombreEmpresaTextBox.Location = New System.Drawing.Point(136, 29)
        Me.NombreEmpresaTextBox.Name = "NombreEmpresaTextBox"
        Me.NombreEmpresaTextBox.ReadOnly = True
        Me.NombreEmpresaTextBox.Size = New System.Drawing.Size(226, 20)
        Me.NombreEmpresaTextBox.TabIndex = 58
        '
        'LocalidadEmpresaTextBox
        '
        Me.LocalidadEmpresaTextBox.AcceptsReturn = True
        Me.LocalidadEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "LocalidadEmpresa", True))
        Me.LocalidadEmpresaTextBox.Location = New System.Drawing.Point(418, 141)
        Me.LocalidadEmpresaTextBox.Name = "LocalidadEmpresaTextBox"
        Me.LocalidadEmpresaTextBox.Size = New System.Drawing.Size(204, 20)
        Me.LocalidadEmpresaTextBox.TabIndex = 15
        '
        'DomicilioEmpresaTextBox
        '
        Me.DomicilioEmpresaTextBox.AcceptsReturn = True
        Me.DomicilioEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "DomicilioEmpresa", True))
        Me.DomicilioEmpresaTextBox.Location = New System.Drawing.Point(418, 93)
        Me.DomicilioEmpresaTextBox.Name = "DomicilioEmpresaTextBox"
        Me.DomicilioEmpresaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DomicilioEmpresaTextBox.TabIndex = 14
        '
        'Codigo_Postal_EmpresaTextBox
        '
        Me.Codigo_Postal_EmpresaTextBox.AcceptsReturn = True
        Me.Codigo_Postal_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "Codigo_Postal_Empresa", True))
        Me.Codigo_Postal_EmpresaTextBox.Location = New System.Drawing.Point(136, 145)
        Me.Codigo_Postal_EmpresaTextBox.Name = "Codigo_Postal_EmpresaTextBox"
        Me.Codigo_Postal_EmpresaTextBox.Size = New System.Drawing.Size(124, 20)
        Me.Codigo_Postal_EmpresaTextBox.TabIndex = 12
        '
        'Actividad_empresaTextBox
        '
        Me.Actividad_empresaTextBox.AcceptsReturn = True
        Me.Actividad_empresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "Actividad_empresa", True))
        Me.Actividad_empresaTextBox.Location = New System.Drawing.Point(137, 58)
        Me.Actividad_empresaTextBox.Name = "Actividad_empresaTextBox"
        Me.Actividad_empresaTextBox.Size = New System.Drawing.Size(260, 20)
        Me.Actividad_empresaTextBox.TabIndex = 9
        '
        'Código_Nacional_Actividad_Económica_CNAETextBox
        '
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.AcceptsReturn = True
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "Código_Nacional_Actividad_Económica_CNAE", True))
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.Location = New System.Drawing.Point(138, 87)
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.Name = "Código_Nacional_Actividad_Económica_CNAETextBox"
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.Size = New System.Drawing.Size(220, 20)
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.TabIndex = 10
        '
        'groupMedico
        '
        Me.groupMedico.Controls.Add(Me.btn_BuscarMedico)
        Me.groupMedico.Controls.Add(NombreMedicoLabel)
        Me.groupMedico.Controls.Add(Me.NombreMedicoTextBox)
        Me.groupMedico.Controls.Add(No_de_ColegiadoMedicoLabel)
        Me.groupMedico.Controls.Add(Me.No_de_ColegiadoMedicoTextBox)
        Me.groupMedico.Location = New System.Drawing.Point(11, 510)
        Me.groupMedico.Name = "groupMedico"
        Me.groupMedico.Size = New System.Drawing.Size(395, 87)
        Me.groupMedico.TabIndex = 92
        Me.groupMedico.TabStop = False
        Me.groupMedico.Text = "Datos Médico"
        '
        'btn_BuscarMedico
        '
        Me.btn_BuscarMedico.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btn_BuscarMedico.Location = New System.Drawing.Point(348, 25)
        Me.btn_BuscarMedico.Name = "btn_BuscarMedico"
        Me.btn_BuscarMedico.Size = New System.Drawing.Size(36, 23)
        Me.btn_BuscarMedico.TabIndex = 82
        Me.btn_BuscarMedico.UseVisualStyleBackColor = True
        '
        'NombreMedicoTextBox
        '
        Me.NombreMedicoTextBox.AcceptsReturn = True
        Me.NombreMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "NombreMedico", True))
        Me.NombreMedicoTextBox.Location = New System.Drawing.Point(125, 27)
        Me.NombreMedicoTextBox.Name = "NombreMedicoTextBox"
        Me.NombreMedicoTextBox.ReadOnly = True
        Me.NombreMedicoTextBox.Size = New System.Drawing.Size(225, 20)
        Me.NombreMedicoTextBox.TabIndex = 81
        '
        'No_de_ColegiadoMedicoTextBox
        '
        Me.No_de_ColegiadoMedicoTextBox.AcceptsReturn = True
        Me.No_de_ColegiadoMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "No_de_ColegiadoMedico", True))
        Me.No_de_ColegiadoMedicoTextBox.Location = New System.Drawing.Point(125, 54)
        Me.No_de_ColegiadoMedicoTextBox.Name = "No_de_ColegiadoMedicoTextBox"
        Me.No_de_ColegiadoMedicoTextBox.Size = New System.Drawing.Size(131, 20)
        Me.No_de_ColegiadoMedicoTextBox.TabIndex = 16
        '
        'grpDatosBasicos
        '
        Me.grpDatosBasicos.Controls.Add(E_CaracterLabel)
        Me.grpDatosBasicos.Controls.Add(Me.E_CaracterComboBox)
        Me.grpDatosBasicos.Controls.Add(E_SituacionLabel)
        Me.grpDatosBasicos.Controls.Add(Me.E_SituacionComboBox)
        Me.grpDatosBasicos.Controls.Add(E_RegimenLabel)
        Me.grpDatosBasicos.Controls.Add(Me.E_RegimenComboBox)
        Me.grpDatosBasicos.Controls.Add(Me.ID_ParteTextBox)
        Me.grpDatosBasicos.Controls.Add(ID_ParteLabel)
        Me.grpDatosBasicos.Controls.Add(Me.btnDardeAlta)
        Me.grpDatosBasicos.Controls.Add(Me.E_TipoComboBox)
        Me.grpDatosBasicos.Controls.Add(E_TipoLabel)
        Me.grpDatosBasicos.Controls.Add(Me.FechaATDateTimePicker)
        Me.grpDatosBasicos.Controls.Add(FechaATLabel)
        Me.grpDatosBasicos.Location = New System.Drawing.Point(7, 28)
        Me.grpDatosBasicos.Name = "grpDatosBasicos"
        Me.grpDatosBasicos.Size = New System.Drawing.Size(643, 122)
        Me.grpDatosBasicos.TabIndex = 93
        Me.grpDatosBasicos.TabStop = False
        Me.grpDatosBasicos.Text = "Datos básicos"
        '
        'E_CaracterComboBox
        '
        Me.E_CaracterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.E_CaracterComboBox.FormattingEnabled = True
        Me.E_CaracterComboBox.Location = New System.Drawing.Point(364, 78)
        Me.E_CaracterComboBox.Name = "E_CaracterComboBox"
        Me.E_CaracterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.E_CaracterComboBox.TabIndex = 95
        '
        'E_SituacionComboBox
        '
        Me.E_SituacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.E_SituacionComboBox.FormattingEnabled = True
        Me.E_SituacionComboBox.Location = New System.Drawing.Point(364, 51)
        Me.E_SituacionComboBox.Name = "E_SituacionComboBox"
        Me.E_SituacionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.E_SituacionComboBox.TabIndex = 94
        '
        'E_RegimenComboBox
        '
        Me.E_RegimenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.E_RegimenComboBox.FormattingEnabled = True
        Me.E_RegimenComboBox.Location = New System.Drawing.Point(364, 24)
        Me.E_RegimenComboBox.Name = "E_RegimenComboBox"
        Me.E_RegimenComboBox.Size = New System.Drawing.Size(138, 21)
        Me.E_RegimenComboBox.TabIndex = 93
        '
        'ID_ParteTextBox
        '
        Me.ID_ParteTextBox.AcceptsReturn = True
        Me.ID_ParteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "ID_Parte", True))
        Me.ID_ParteTextBox.Location = New System.Drawing.Point(71, 28)
        Me.ID_ParteTextBox.Name = "ID_ParteTextBox"
        Me.ID_ParteTextBox.ReadOnly = True
        Me.ID_ParteTextBox.Size = New System.Drawing.Size(64, 20)
        Me.ID_ParteTextBox.TabIndex = 2
        '
        'E_Causa_de_bajaComboBox
        '
        Me.E_Causa_de_bajaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.E_Causa_de_bajaComboBox.FormattingEnabled = True
        Me.E_Causa_de_bajaComboBox.Location = New System.Drawing.Point(113, 47)
        Me.E_Causa_de_bajaComboBox.Name = "E_Causa_de_bajaComboBox"
        Me.E_Causa_de_bajaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.E_Causa_de_bajaComboBox.TabIndex = 96
        '
        'Alta_E_Causa_de_AltaComboBox
        '
        Me.Alta_E_Causa_de_AltaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Alta_E_Causa_de_AltaComboBox.FormattingEnabled = True
        Me.Alta_E_Causa_de_AltaComboBox.Location = New System.Drawing.Point(113, 52)
        Me.Alta_E_Causa_de_AltaComboBox.Name = "Alta_E_Causa_de_AltaComboBox"
        Me.Alta_E_Causa_de_AltaComboBox.Size = New System.Drawing.Size(231, 21)
        Me.Alta_E_Causa_de_AltaComboBox.TabIndex = 97
        '
        'groupAlta
        '
        Me.groupAlta.Controls.Add(Me.FechaAltaDateTimePicker)
        Me.groupAlta.Controls.Add(FechaAltaLabel)
        Me.groupAlta.Controls.Add(Me.Alta_E_Causa_de_AltaComboBox)
        Me.groupAlta.Controls.Add(Alta_Descripcion_Resultado_ReconocimientoLabel)
        Me.groupAlta.Controls.Add(Alta_E_Causa_de_AltaLabel)
        Me.groupAlta.Controls.Add(Me.Alta_Descripcion_Resultado_ReconocimientoTextBox)
        Me.groupAlta.Location = New System.Drawing.Point(660, 510)
        Me.groupAlta.Name = "groupAlta"
        Me.groupAlta.Size = New System.Drawing.Size(358, 299)
        Me.groupAlta.TabIndex = 98
        Me.groupAlta.TabStop = False
        Me.groupAlta.Text = "Datos Parte ALTA"
        Me.groupAlta.Visible = False
        '
        'Alta_Descripcion_Resultado_ReconocimientoTextBox
        '
        Me.Alta_Descripcion_Resultado_ReconocimientoTextBox.AcceptsReturn = True
        Me.Alta_Descripcion_Resultado_ReconocimientoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Alta_Descripcion_Resultado_ReconocimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "Alta_Descripcion_Resultado_Reconocimiento", True))
        Me.Alta_Descripcion_Resultado_ReconocimientoTextBox.Location = New System.Drawing.Point(9, 99)
        Me.Alta_Descripcion_Resultado_ReconocimientoTextBox.Multiline = True
        Me.Alta_Descripcion_Resultado_ReconocimientoTextBox.Name = "Alta_Descripcion_Resultado_ReconocimientoTextBox"
        Me.Alta_Descripcion_Resultado_ReconocimientoTextBox.Size = New System.Drawing.Size(343, 188)
        Me.Alta_Descripcion_Resultado_ReconocimientoTextBox.TabIndex = 96
        '
        'groupBaja
        '
        Me.groupBaja.Controls.Add(Me.chk_Recaida)
        Me.groupBaja.Controls.Add(Me.groupDuracion)
        Me.groupBaja.Controls.Add(E_Causa_de_bajaLabel)
        Me.groupBaja.Controls.Add(Me.E_Causa_de_bajaComboBox)
        Me.groupBaja.Controls.Add(Me.FechaBajaDateTimePicker)
        Me.groupBaja.Controls.Add(FechaBajaLabel)
        Me.groupBaja.Controls.Add(DescripcionLimitacionLabel)
        Me.groupBaja.Controls.Add(Me.DescripcionLimitacionTextBox)
        Me.groupBaja.Location = New System.Drawing.Point(660, 28)
        Me.groupBaja.Name = "groupBaja"
        Me.groupBaja.Size = New System.Drawing.Size(358, 472)
        Me.groupBaja.TabIndex = 99
        Me.groupBaja.TabStop = False
        Me.groupBaja.Text = "Datos Parte BAJA"
        '
        'chk_Recaida
        '
        Me.chk_Recaida.AutoSize = True
        Me.chk_Recaida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_Recaida.Location = New System.Drawing.Point(63, 80)
        Me.chk_Recaida.Name = "chk_Recaida"
        Me.chk_Recaida.Size = New System.Drawing.Size(66, 17)
        Me.chk_Recaida.TabIndex = 98
        Me.chk_Recaida.Text = "Recaida"
        Me.chk_Recaida.UseVisualStyleBackColor = True
        '
        'groupDuracion
        '
        Me.groupDuracion.Controls.Add(Me.Duracion_probable_baja_diasTextBox)
        Me.groupDuracion.Controls.Add(Me.Duracion_estandar_fecha_finalDateTimePicker)
        Me.groupDuracion.Controls.Add(Duracion_estandar_fecha_finalLabel)
        Me.groupDuracion.Controls.Add(Me.Duracion_estandar_fecha_inicioDateTimePicker)
        Me.groupDuracion.Controls.Add(Duracion_estandar_fecha_inicioLabel)
        Me.groupDuracion.Controls.Add(Me.Duracion_probable_baja_mesesTextBox)
        Me.groupDuracion.Controls.Add(Duracion_probable_baja_mesesLabel)
        Me.groupDuracion.Controls.Add(Duracion_probable_baja_diasLabel)
        Me.groupDuracion.Location = New System.Drawing.Point(9, 317)
        Me.groupDuracion.Name = "groupDuracion"
        Me.groupDuracion.Size = New System.Drawing.Size(343, 138)
        Me.groupDuracion.TabIndex = 97
        Me.groupDuracion.TabStop = False
        Me.groupDuracion.Text = "Duración"
        '
        'Duracion_probable_baja_diasTextBox
        '
        Me.Duracion_probable_baja_diasTextBox.AcceptsReturn = True
        Me.Duracion_probable_baja_diasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "Duracion_probable_baja_dias", True))
        Me.Duracion_probable_baja_diasTextBox.Location = New System.Drawing.Point(169, 19)
        Me.Duracion_probable_baja_diasTextBox.Name = "Duracion_probable_baja_diasTextBox"
        Me.Duracion_probable_baja_diasTextBox.Size = New System.Drawing.Size(36, 20)
        Me.Duracion_probable_baja_diasTextBox.TabIndex = 62
        '
        'Duracion_estandar_fecha_finalDateTimePicker
        '
        Me.Duracion_estandar_fecha_finalDateTimePicker.Checked = False
        Me.Duracion_estandar_fecha_finalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_PartesBindingSource, "Duracion_estandar_fecha_final", True))
        Me.Duracion_estandar_fecha_finalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Duracion_estandar_fecha_finalDateTimePicker.Location = New System.Drawing.Point(169, 97)
        Me.Duracion_estandar_fecha_finalDateTimePicker.Name = "Duracion_estandar_fecha_finalDateTimePicker"
        Me.Duracion_estandar_fecha_finalDateTimePicker.ShowCheckBox = True
        Me.Duracion_estandar_fecha_finalDateTimePicker.Size = New System.Drawing.Size(105, 20)
        Me.Duracion_estandar_fecha_finalDateTimePicker.TabIndex = 68
        '
        'Duracion_estandar_fecha_inicioDateTimePicker
        '
        Me.Duracion_estandar_fecha_inicioDateTimePicker.Checked = False
        Me.Duracion_estandar_fecha_inicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_PartesBindingSource, "Duracion_estandar_fecha_inicio", True))
        Me.Duracion_estandar_fecha_inicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Duracion_estandar_fecha_inicioDateTimePicker.Location = New System.Drawing.Point(169, 71)
        Me.Duracion_estandar_fecha_inicioDateTimePicker.Name = "Duracion_estandar_fecha_inicioDateTimePicker"
        Me.Duracion_estandar_fecha_inicioDateTimePicker.ShowCheckBox = True
        Me.Duracion_estandar_fecha_inicioDateTimePicker.Size = New System.Drawing.Size(105, 20)
        Me.Duracion_estandar_fecha_inicioDateTimePicker.TabIndex = 66
        '
        'Duracion_probable_baja_mesesTextBox
        '
        Me.Duracion_probable_baja_mesesTextBox.AcceptsReturn = True
        Me.Duracion_probable_baja_mesesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "Duracion_probable_baja_meses", True))
        Me.Duracion_probable_baja_mesesTextBox.Location = New System.Drawing.Point(169, 45)
        Me.Duracion_probable_baja_mesesTextBox.Name = "Duracion_probable_baja_mesesTextBox"
        Me.Duracion_probable_baja_mesesTextBox.Size = New System.Drawing.Size(36, 20)
        Me.Duracion_probable_baja_mesesTextBox.TabIndex = 64
        '
        'DescripcionLimitacionTextBox
        '
        Me.DescripcionLimitacionTextBox.AcceptsReturn = True
        Me.DescripcionLimitacionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionLimitacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_PartesBindingSource, "DescripcionLimitacion", True))
        Me.DescripcionLimitacionTextBox.Location = New System.Drawing.Point(9, 125)
        Me.DescripcionLimitacionTextBox.Multiline = True
        Me.DescripcionLimitacionTextBox.Name = "DescripcionLimitacionTextBox"
        Me.DescripcionLimitacionTextBox.Size = New System.Drawing.Size(343, 186)
        Me.DescripcionLimitacionTextBox.TabIndex = 58
        '
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'EMPRESASTableAdapter
        '
        Me.EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'N_PartesTableAdapter
        '
        Me.N_PartesTableAdapter.ClearBeforeFill = True
        '
        'group_Proceso
        '
        Me.group_Proceso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group_Proceso.Controls.Add(Me.btnVerProceso)
        Me.group_Proceso.Controls.Add(Me.lblCitaProcesoInfo)
        Me.group_Proceso.Controls.Add(Me.btn_HistorialProcesos)
        Me.group_Proceso.Location = New System.Drawing.Point(361, 512)
        Me.group_Proceso.Name = "group_Proceso"
        Me.group_Proceso.Size = New System.Drawing.Size(236, 122)
        Me.group_Proceso.TabIndex = 100
        Me.group_Proceso.TabStop = False
        Me.group_Proceso.Text = "Proceso"
        '
        'btnVerProceso
        '
        Me.btnVerProceso.Enabled = False
        Me.btnVerProceso.Image = Global.centro_medico.My.Resources.Resources._24_image_open
        Me.btnVerProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerProceso.Location = New System.Drawing.Point(129, 64)
        Me.btnVerProceso.Name = "btnVerProceso"
        Me.btnVerProceso.Size = New System.Drawing.Size(84, 44)
        Me.btnVerProceso.TabIndex = 100
        Me.btnVerProceso.Text = "Ver Proceso"
        Me.btnVerProceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerProceso.UseVisualStyleBackColor = True
        '
        'lblCitaProcesoInfo
        '
        Me.lblCitaProcesoInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitaProcesoInfo.Location = New System.Drawing.Point(10, 22)
        Me.lblCitaProcesoInfo.Name = "lblCitaProcesoInfo"
        Me.lblCitaProcesoInfo.Size = New System.Drawing.Size(217, 33)
        Me.lblCitaProcesoInfo.TabIndex = 99
        Me.lblCitaProcesoInfo.Text = "Este parte no se encuentra vinculado a ningun proceso"
        '
        'btn_HistorialProcesos
        '
        Me.btn_HistorialProcesos.Image = Global.centro_medico.My.Resources.Resources._24_imageset
        Me.btn_HistorialProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_HistorialProcesos.Location = New System.Drawing.Point(13, 65)
        Me.btn_HistorialProcesos.Name = "btn_HistorialProcesos"
        Me.btn_HistorialProcesos.Size = New System.Drawing.Size(90, 43)
        Me.btn_HistorialProcesos.TabIndex = 98
        Me.btn_HistorialProcesos.Text = "Historial de Procesos"
        Me.btn_HistorialProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_HistorialProcesos.UseVisualStyleBackColor = True
        '
        'CtrlDiagnosticos1
        '
        Me.CtrlDiagnosticos1.DataBindings.Add(New System.Windows.Forms.Binding("ID_DIAGNOSTICOS", Me.N_PartesBindingSource, "ID_Diagnostico", True))
        Me.CtrlDiagnosticos1.ID_DIAGNOSTICOS = Nothing
        Me.CtrlDiagnosticos1.Location = New System.Drawing.Point(86, 609)
        Me.CtrlDiagnosticos1.Name = "CtrlDiagnosticos1"
        Me.CtrlDiagnosticos1.Size = New System.Drawing.Size(320, 25)
        Me.CtrlDiagnosticos1.TabIndex = 17
        '
        'frmPartes_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1100, 647)
        Me.Controls.Add(Me.group_Proceso)
        Me.Controls.Add(Me.groupBaja)
        Me.Controls.Add(Me.groupAlta)
        Me.Controls.Add(Me.grpDatosBasicos)
        Me.Controls.Add(Me.groupMedico)
        Me.Controls.Add(Me.CtrlDiagnosticos1)
        Me.Controls.Add(Me.grpEmpresa)
        Me.Controls.Add(Me.groupPaciente)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(ID_DiagnosticoLabel)
        Me.KeyPreview = True
        Me.Name = "frmPartes_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Parte Alta / Baja"
        CType(Me.N_PartesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupPaciente.ResumeLayout(False)
        Me.groupPaciente.PerformLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmpresa.ResumeLayout(False)
        Me.grpEmpresa.PerformLayout()
        Me.groupMedico.ResumeLayout(False)
        Me.groupMedico.PerformLayout()
        Me.grpDatosBasicos.ResumeLayout(False)
        Me.grpDatosBasicos.PerformLayout()
        Me.groupAlta.ResumeLayout(False)
        Me.groupAlta.PerformLayout()
        Me.groupBaja.ResumeLayout(False)
        Me.groupBaja.PerformLayout()
        Me.groupDuracion.ResumeLayout(False)
        Me.groupDuracion.PerformLayout()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Proceso.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CM3DataSet As centro_medico.CM3DataSet
    Friend WithEvents N_PartesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_PartesTableAdapter As centro_medico.CM3DataSetTableAdapters.N_PartesTableAdapter
    Friend WithEvents ID_ParteTextBox As ctrlTextboxAvanzado
    Friend WithEvents FechaBajaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaATDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_Tarjeta_sanitariaTextBox As ctrlTextboxAvanzado
    Friend WithEvents Num_Afiliacion_Seg_SocialTextBox As ctrlTextboxAvanzado
    Friend WithEvents DomicilioPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents LocalidadPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents Codigo_PostalPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents TelefonoPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents Puesto_de_trabajoPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents DomicilioEmpresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents LocalidadEmpresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents Codigo_Postal_EmpresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents Actividad_empresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents Código_Nacional_Actividad_Económica_CNAETextBox As ctrlTextboxAvanzado
    Friend WithEvents DescripcionLimitacionTextBox As ctrlTextboxAvanzado
    Friend WithEvents No_de_ColegiadoMedicoTextBox As ctrlTextboxAvanzado
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents E_TipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnDardeAlta As System.Windows.Forms.Button
    Friend WithEvents groupPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents grpEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents groupMedico As System.Windows.Forms.GroupBox
    Friend WithEvents grpDatosBasicos As System.Windows.Forms.GroupBox
    Friend WithEvents Alta_Descripcion_Resultado_ReconocimientoTextBox As ctrlTextboxAvanzado
    Friend WithEvents E_RegimenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents E_SituacionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents E_Causa_de_bajaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents E_CaracterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Alta_E_Causa_de_AltaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents groupAlta As System.Windows.Forms.GroupBox
    Friend WithEvents FechaAltaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents groupBaja As System.Windows.Forms.GroupBox
    Friend WithEvents NombreEmpresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents btn_BuscarMedico As System.Windows.Forms.Button
    Friend WithEvents NombreMedicoTextBox As ctrlTextboxAvanzado
    Friend WithEvents CtrlDiagnosticos1 As centro_medico.ctrlDiagnosticos
    Friend WithEvents groupDuracion As System.Windows.Forms.GroupBox
    Friend WithEvents Duracion_probable_baja_diasTextBox As ctrlTextboxAvanzado
    Friend WithEvents Duracion_estandar_fecha_finalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Duracion_estandar_fecha_inicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Duracion_probable_baja_mesesTextBox As ctrlTextboxAvanzado
    Friend WithEvents ProvinciaPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents btn_BuscarEmpresa As System.Windows.Forms.Button
    Friend WithEvents ProvinciaEmpresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents chk_Recaida As System.Windows.Forms.CheckBox
    Friend WithEvents rb_ISM As System.Windows.Forms.RadioButton
    Friend WithEvents rb_INSS As System.Windows.Forms.RadioButton
    Friend WithEvents CtrlPaciente21 As centro_medico.ctrlPaciente2
    Friend WithEvents group_Proceso As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerProceso As System.Windows.Forms.Button
    Friend WithEvents lblCitaProcesoInfo As System.Windows.Forms.Label
    Friend WithEvents btn_HistorialProcesos As System.Windows.Forms.Button
End Class
