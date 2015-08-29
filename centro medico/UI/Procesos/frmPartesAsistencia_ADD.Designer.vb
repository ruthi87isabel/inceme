<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartesAsistencia_ADD
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
        Dim E_SituacionLabel As System.Windows.Forms.Label
        Dim E_RegimenLabel As System.Windows.Forms.Label
        Dim ID_ParteLabel As System.Windows.Forms.Label
        Dim E_TipoLabel As System.Windows.Forms.Label
        Dim ProvinciaEmpresaLabel As System.Windows.Forms.Label
        Dim NombreEmpresaLabel As System.Windows.Forms.Label
        Dim LocalidadEmpresaLabel As System.Windows.Forms.Label
        Dim DomicilioEmpresaLabel As System.Windows.Forms.Label
        Dim Codigo_Postal_EmpresaLabel As System.Windows.Forms.Label
        Dim Actividad_empresaLabel As System.Windows.Forms.Label
        Dim Código_Nacional_Actividad_Económica_CNAELabel As System.Windows.Forms.Label
        Dim ProvinciaPacienteLabel As System.Windows.Forms.Label
        Dim NombreCompletoPacienteLabel As System.Windows.Forms.Label
        Dim Num_Afiliacion_Seg_SocialLabel As System.Windows.Forms.Label
        Dim Num_Tarjeta_sanitariaLabel As System.Windows.Forms.Label
        Dim DomicilioPacienteLabel As System.Windows.Forms.Label
        Dim LocalidadPacienteLabel As System.Windows.Forms.Label
        Dim Codigo_PostalPacienteLabel As System.Windows.Forms.Label
        Dim TelefonoPacienteLabel As System.Windows.Forms.Label
        Dim Puesto_de_trabajoPacienteLabel As System.Windows.Forms.Label
        Dim ID_DiagnosticoLabel As System.Windows.Forms.Label
        Dim CausaBajaLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim Asistido_PreviamenteLabel As System.Windows.Forms.Label
        Dim Era_el_lugar_de_trabajo_habitualLabel As System.Windows.Forms.Label
        Dim Descripcion_del_accidenteLabel As System.Windows.Forms.Label
        Dim Descripcion_DiagnosticoLabel As System.Windows.Forms.Label
        Dim Duracion_estandar_fecha_iniLabel As System.Windows.Forms.Label
        Dim Duracion_estandar_fecha_finLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim E_TratamientoLabel1 As System.Windows.Forms.Label
        Dim E_PronosticoLabel As System.Windows.Forms.Label
        Dim Fecha_accidenteLabel As System.Windows.Forms.Label
        Dim Fecha_Asistencia_previaLabel As System.Windows.Forms.Label
        Dim FechaAsistenciaLabel As System.Windows.Forms.Label
        Dim Lugar_de_accidenteLabel As System.Windows.Forms.Label
        Dim Entidad_Pago_IT_CPLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartesAsistencia_ADD))
        Me.grpDatosBasicos = New System.Windows.Forms.GroupBox()
        Me.FechaAsistenciaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.N_Partes_AsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CM3DataSet = New centro_medico.CM3DataSet()
        Me.CausaBajaCheckBox = New System.Windows.Forms.CheckBox()
        Me.E_SituacionComboBox = New System.Windows.Forms.ComboBox()
        Me.E_RegimenComboBox = New System.Windows.Forms.ComboBox()
        Me.ID_ParteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.E_TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.groupMedico = New System.Windows.Forms.GroupBox()
        Me.CtrlMedico1 = New centro_medico.ctrlMedico()
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
        Me.groupPaciente = New System.Windows.Forms.GroupBox()
        Me.DNITextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.ProvinciaPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.btnBuscaPaciente = New System.Windows.Forms.Button()
        Me.NombreCompletoPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Num_Tarjeta_sanitariaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Num_Afiliacion_Seg_SocialTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DomicilioPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.LocalidadPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Codigo_PostalPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.TelefonoPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Puesto_de_trabajoPacienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Asistido_PreviamenteCheckBox = New System.Windows.Forms.CheckBox()
        Me.Era_el_lugar_de_trabajo_habitualCheckBox = New System.Windows.Forms.CheckBox()
        Me.Descripcion_del_accidenteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Descripcion_DiagnosticoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Duracion_estandar_fecha_iniDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Duracion_estandar_fecha_finDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ObservacionesTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.grpDuracion = New System.Windows.Forms.GroupBox()
        Me.grpDetalles = New System.Windows.Forms.GroupBox()
        Me.Lugar_de_accidenteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.Fecha_Asistencia_previaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_accidenteDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.E_PronosticoComboBox = New System.Windows.Forms.ComboBox()
        Me.E_TratamientoComboBox = New System.Windows.Forms.ComboBox()
        Me.CtrlDiagnosticos1 = New centro_medico.ctrlDiagnosticos()
        Me.N_Partes_AsistenciaTableAdapter = New centro_medico.CM3DataSetTableAdapters.N_Partes_AsistenciaTableAdapter()
        Me.N_Partes_AsistenciaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.N_Partes_AsistenciaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter()
        Me.group_Proceso = New System.Windows.Forms.GroupBox()
        Me.btnVerProceso = New System.Windows.Forms.Button()
        Me.lblCitaProcesoInfo = New System.Windows.Forms.Label()
        Me.btn_HistorialProcesos = New System.Windows.Forms.Button()
        E_SituacionLabel = New System.Windows.Forms.Label()
        E_RegimenLabel = New System.Windows.Forms.Label()
        ID_ParteLabel = New System.Windows.Forms.Label()
        E_TipoLabel = New System.Windows.Forms.Label()
        ProvinciaEmpresaLabel = New System.Windows.Forms.Label()
        NombreEmpresaLabel = New System.Windows.Forms.Label()
        LocalidadEmpresaLabel = New System.Windows.Forms.Label()
        DomicilioEmpresaLabel = New System.Windows.Forms.Label()
        Codigo_Postal_EmpresaLabel = New System.Windows.Forms.Label()
        Actividad_empresaLabel = New System.Windows.Forms.Label()
        Código_Nacional_Actividad_Económica_CNAELabel = New System.Windows.Forms.Label()
        ProvinciaPacienteLabel = New System.Windows.Forms.Label()
        NombreCompletoPacienteLabel = New System.Windows.Forms.Label()
        Num_Afiliacion_Seg_SocialLabel = New System.Windows.Forms.Label()
        Num_Tarjeta_sanitariaLabel = New System.Windows.Forms.Label()
        DomicilioPacienteLabel = New System.Windows.Forms.Label()
        LocalidadPacienteLabel = New System.Windows.Forms.Label()
        Codigo_PostalPacienteLabel = New System.Windows.Forms.Label()
        TelefonoPacienteLabel = New System.Windows.Forms.Label()
        Puesto_de_trabajoPacienteLabel = New System.Windows.Forms.Label()
        ID_DiagnosticoLabel = New System.Windows.Forms.Label()
        CausaBajaLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        Asistido_PreviamenteLabel = New System.Windows.Forms.Label()
        Era_el_lugar_de_trabajo_habitualLabel = New System.Windows.Forms.Label()
        Descripcion_del_accidenteLabel = New System.Windows.Forms.Label()
        Descripcion_DiagnosticoLabel = New System.Windows.Forms.Label()
        Duracion_estandar_fecha_iniLabel = New System.Windows.Forms.Label()
        Duracion_estandar_fecha_finLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        E_TratamientoLabel1 = New System.Windows.Forms.Label()
        E_PronosticoLabel = New System.Windows.Forms.Label()
        Fecha_accidenteLabel = New System.Windows.Forms.Label()
        Fecha_Asistencia_previaLabel = New System.Windows.Forms.Label()
        FechaAsistenciaLabel = New System.Windows.Forms.Label()
        Lugar_de_accidenteLabel = New System.Windows.Forms.Label()
        Entidad_Pago_IT_CPLabel = New System.Windows.Forms.Label()
        Me.grpDatosBasicos.SuspendLayout()
        CType(Me.N_Partes_AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupMedico.SuspendLayout()
        Me.grpEmpresa.SuspendLayout()
        Me.groupPaciente.SuspendLayout()
        Me.grpDuracion.SuspendLayout()
        Me.grpDetalles.SuspendLayout()
        CType(Me.N_Partes_AsistenciaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.N_Partes_AsistenciaBindingNavigator.SuspendLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_Proceso.SuspendLayout()
        Me.SuspendLayout()
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
        'E_RegimenLabel
        '
        E_RegimenLabel.AutoSize = True
        E_RegimenLabel.Location = New System.Drawing.Point(310, 27)
        E_RegimenLabel.Name = "E_RegimenLabel"
        E_RegimenLabel.Size = New System.Drawing.Size(52, 13)
        E_RegimenLabel.TabIndex = 92
        E_RegimenLabel.Text = "Régimen:"
        '
        'ID_ParteLabel
        '
        ID_ParteLabel.AutoSize = True
        ID_ParteLabel.Location = New System.Drawing.Point(91, 27)
        ID_ParteLabel.Name = "ID_ParteLabel"
        ID_ParteLabel.Size = New System.Drawing.Size(43, 13)
        ID_ParteLabel.TabIndex = 1
        ID_ParteLabel.Text = "Codigo:"
        '
        'E_TipoLabel
        '
        E_TipoLabel.AutoSize = True
        E_TipoLabel.Location = New System.Drawing.Point(73, 58)
        E_TipoLabel.Name = "E_TipoLabel"
        E_TipoLabel.Size = New System.Drawing.Size(59, 13)
        E_TipoLabel.TabIndex = 85
        E_TipoLabel.Text = "Tipo Parte:"
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
        'NombreEmpresaLabel
        '
        NombreEmpresaLabel.AutoSize = True
        NombreEmpresaLabel.Location = New System.Drawing.Point(39, 29)
        NombreEmpresaLabel.Name = "NombreEmpresaLabel"
        NombreEmpresaLabel.Size = New System.Drawing.Size(91, 13)
        NombreEmpresaLabel.TabIndex = 57
        NombreEmpresaLabel.Text = "Nombre Empresa:"
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
        'DomicilioEmpresaLabel
        '
        DomicilioEmpresaLabel.AutoSize = True
        DomicilioEmpresaLabel.Location = New System.Drawing.Point(419, 77)
        DomicilioEmpresaLabel.Name = "DomicilioEmpresaLabel"
        DomicilioEmpresaLabel.Size = New System.Drawing.Size(52, 13)
        DomicilioEmpresaLabel.TabIndex = 43
        DomicilioEmpresaLabel.Text = "Domicilio:"
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
        'ProvinciaPacienteLabel
        '
        ProvinciaPacienteLabel.AutoSize = True
        ProvinciaPacienteLabel.Location = New System.Drawing.Point(78, 142)
        ProvinciaPacienteLabel.Name = "ProvinciaPacienteLabel"
        ProvinciaPacienteLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaPacienteLabel.TabIndex = 83
        ProvinciaPacienteLabel.Text = "Provincia:"
        '
        'NombreCompletoPacienteLabel
        '
        NombreCompletoPacienteLabel.AutoSize = True
        NombreCompletoPacienteLabel.Location = New System.Drawing.Point(38, 23)
        NombreCompletoPacienteLabel.Name = "NombreCompletoPacienteLabel"
        NombreCompletoPacienteLabel.Size = New System.Drawing.Size(94, 13)
        NombreCompletoPacienteLabel.TabIndex = 40
        NombreCompletoPacienteLabel.Text = "Nombre Completo:"
        '
        'Num_Afiliacion_Seg_SocialLabel
        '
        Num_Afiliacion_Seg_SocialLabel.AutoSize = True
        Num_Afiliacion_Seg_SocialLabel.Location = New System.Drawing.Point(22, 114)
        Num_Afiliacion_Seg_SocialLabel.Name = "Num_Afiliacion_Seg_SocialLabel"
        Num_Afiliacion_Seg_SocialLabel.Size = New System.Drawing.Size(113, 13)
        Num_Afiliacion_Seg_SocialLabel.TabIndex = 25
        Num_Afiliacion_Seg_SocialLabel.Text = "Nro. Seguridad Social:"
        '
        'Num_Tarjeta_sanitariaLabel
        '
        Num_Tarjeta_sanitariaLabel.AutoSize = True
        Num_Tarjeta_sanitariaLabel.Location = New System.Drawing.Point(22, 83)
        Num_Tarjeta_sanitariaLabel.Name = "Num_Tarjeta_sanitariaLabel"
        Num_Tarjeta_sanitariaLabel.Size = New System.Drawing.Size(110, 13)
        Num_Tarjeta_sanitariaLabel.TabIndex = 23
        Num_Tarjeta_sanitariaLabel.Text = "Nro. Tarjeta Sanitaria:"
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
        Codigo_PostalPacienteLabel.Location = New System.Drawing.Point(404, 53)
        Codigo_PostalPacienteLabel.Name = "Codigo_PostalPacienteLabel"
        Codigo_PostalPacienteLabel.Size = New System.Drawing.Size(75, 13)
        Codigo_PostalPacienteLabel.TabIndex = 35
        Codigo_PostalPacienteLabel.Text = "Codigo Postal:"
        '
        'TelefonoPacienteLabel
        '
        TelefonoPacienteLabel.AutoSize = True
        TelefonoPacienteLabel.Location = New System.Drawing.Point(425, 23)
        TelefonoPacienteLabel.Name = "TelefonoPacienteLabel"
        TelefonoPacienteLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoPacienteLabel.TabIndex = 37
        TelefonoPacienteLabel.Text = "Teléfono:"
        '
        'Puesto_de_trabajoPacienteLabel
        '
        Puesto_de_trabajoPacienteLabel.AutoSize = True
        Puesto_de_trabajoPacienteLabel.Location = New System.Drawing.Point(39, 50)
        Puesto_de_trabajoPacienteLabel.Name = "Puesto_de_trabajoPacienteLabel"
        Puesto_de_trabajoPacienteLabel.Size = New System.Drawing.Size(93, 13)
        Puesto_de_trabajoPacienteLabel.TabIndex = 39
        Puesto_de_trabajoPacienteLabel.Text = "Puesto de trabajo:"
        '
        'ID_DiagnosticoLabel
        '
        ID_DiagnosticoLabel.AutoSize = True
        ID_DiagnosticoLabel.Location = New System.Drawing.Point(13, 328)
        ID_DiagnosticoLabel.Name = "ID_DiagnosticoLabel"
        ID_DiagnosticoLabel.Size = New System.Drawing.Size(66, 13)
        ID_DiagnosticoLabel.TabIndex = 96
        ID_DiagnosticoLabel.Text = "Diagnóstico:"
        '
        'CausaBajaLabel
        '
        CausaBajaLabel.AutoSize = True
        CausaBajaLabel.Location = New System.Drawing.Point(296, 94)
        CausaBajaLabel.Name = "CausaBajaLabel"
        CausaBajaLabel.Size = New System.Drawing.Size(64, 13)
        CausaBajaLabel.TabIndex = 96
        CausaBajaLabel.Text = "Causa Baja:"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(453, 83)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 83
        DNILabel.Text = "DNI:"
        '
        'Asistido_PreviamenteLabel
        '
        Asistido_PreviamenteLabel.AutoSize = True
        Asistido_PreviamenteLabel.Location = New System.Drawing.Point(307, 34)
        Asistido_PreviamenteLabel.Name = "Asistido_PreviamenteLabel"
        Asistido_PreviamenteLabel.Size = New System.Drawing.Size(108, 13)
        Asistido_PreviamenteLabel.TabIndex = 101
        Asistido_PreviamenteLabel.Text = "Asistido Previamente:"
        '
        'Era_el_lugar_de_trabajo_habitualLabel
        '
        Era_el_lugar_de_trabajo_habitualLabel.AutoSize = True
        Era_el_lugar_de_trabajo_habitualLabel.Location = New System.Drawing.Point(16, 67)
        Era_el_lugar_de_trabajo_habitualLabel.Name = "Era_el_lugar_de_trabajo_habitualLabel"
        Era_el_lugar_de_trabajo_habitualLabel.Size = New System.Drawing.Size(153, 13)
        Era_el_lugar_de_trabajo_habitualLabel.TabIndex = 103
        Era_el_lugar_de_trabajo_habitualLabel.Text = "Era el lugar de trabajo habitual:"
        '
        'Descripcion_del_accidenteLabel
        '
        Descripcion_del_accidenteLabel.AutoSize = True
        Descripcion_del_accidenteLabel.Location = New System.Drawing.Point(13, 131)
        Descripcion_del_accidenteLabel.Name = "Descripcion_del_accidenteLabel"
        Descripcion_del_accidenteLabel.Size = New System.Drawing.Size(133, 13)
        Descripcion_del_accidenteLabel.TabIndex = 104
        Descripcion_del_accidenteLabel.Text = "Descripcion del accidente:"
        '
        'Descripcion_DiagnosticoLabel
        '
        Descripcion_DiagnosticoLabel.AutoSize = True
        Descripcion_DiagnosticoLabel.Location = New System.Drawing.Point(9, 361)
        Descripcion_DiagnosticoLabel.Name = "Descripcion_DiagnosticoLabel"
        Descripcion_DiagnosticoLabel.Size = New System.Drawing.Size(125, 13)
        Descripcion_DiagnosticoLabel.TabIndex = 105
        Descripcion_DiagnosticoLabel.Text = "Descripcion Diagnostico:"
        '
        'Duracion_estandar_fecha_iniLabel
        '
        Duracion_estandar_fecha_iniLabel.AutoSize = True
        Duracion_estandar_fecha_iniLabel.Location = New System.Drawing.Point(18, 25)
        Duracion_estandar_fecha_iniLabel.Name = "Duracion_estandar_fecha_iniLabel"
        Duracion_estandar_fecha_iniLabel.Size = New System.Drawing.Size(35, 13)
        Duracion_estandar_fecha_iniLabel.TabIndex = 106
        Duracion_estandar_fecha_iniLabel.Text = "Inicio:"
        '
        'Duracion_estandar_fecha_finLabel
        '
        Duracion_estandar_fecha_finLabel.AutoSize = True
        Duracion_estandar_fecha_finLabel.Location = New System.Drawing.Point(197, 31)
        Duracion_estandar_fecha_finLabel.Name = "Duracion_estandar_fecha_finLabel"
        Duracion_estandar_fecha_finLabel.Size = New System.Drawing.Size(32, 13)
        Duracion_estandar_fecha_finLabel.TabIndex = 107
        Duracion_estandar_fecha_finLabel.Text = "Final:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(11, 524)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 108
        ObservacionesLabel.Text = "Observaciones:"
        '
        'E_TratamientoLabel1
        '
        E_TratamientoLabel1.AutoSize = True
        E_TratamientoLabel1.Location = New System.Drawing.Point(211, 524)
        E_TratamientoLabel1.Name = "E_TratamientoLabel1"
        E_TratamientoLabel1.Size = New System.Drawing.Size(66, 13)
        E_TratamientoLabel1.TabIndex = 113
        E_TratamientoLabel1.Text = "Tratamiento:"
        '
        'E_PronosticoLabel
        '
        E_PronosticoLabel.AutoSize = True
        E_PronosticoLabel.Location = New System.Drawing.Point(255, 131)
        E_PronosticoLabel.Name = "E_PronosticoLabel"
        E_PronosticoLabel.Size = New System.Drawing.Size(60, 13)
        E_PronosticoLabel.TabIndex = 114
        E_PronosticoLabel.Text = "Pronóstico:"
        '
        'Fecha_accidenteLabel
        '
        Fecha_accidenteLabel.AutoSize = True
        Fecha_accidenteLabel.Location = New System.Drawing.Point(73, 34)
        Fecha_accidenteLabel.Name = "Fecha_accidenteLabel"
        Fecha_accidenteLabel.Size = New System.Drawing.Size(90, 13)
        Fecha_accidenteLabel.TabIndex = 115
        Fecha_accidenteLabel.Text = "Fecha accidente:"
        '
        'Fecha_Asistencia_previaLabel
        '
        Fecha_Asistencia_previaLabel.AutoSize = True
        Fecha_Asistencia_previaLabel.Location = New System.Drawing.Point(307, 66)
        Fecha_Asistencia_previaLabel.Name = "Fecha_Asistencia_previaLabel"
        Fecha_Asistencia_previaLabel.Size = New System.Drawing.Size(40, 13)
        Fecha_Asistencia_previaLabel.TabIndex = 116
        Fecha_Asistencia_previaLabel.Text = "Fecha:"
        '
        'FechaAsistenciaLabel
        '
        FechaAsistenciaLabel.AutoSize = True
        FechaAsistenciaLabel.Location = New System.Drawing.Point(41, 91)
        FechaAsistenciaLabel.Name = "FechaAsistenciaLabel"
        FechaAsistenciaLabel.Size = New System.Drawing.Size(91, 13)
        FechaAsistenciaLabel.TabIndex = 97
        FechaAsistenciaLabel.Text = "Fecha Asistencia:"
        '
        'Lugar_de_accidenteLabel
        '
        Lugar_de_accidenteLabel.AutoSize = True
        Lugar_de_accidenteLabel.Location = New System.Drawing.Point(16, 99)
        Lugar_de_accidenteLabel.Name = "Lugar_de_accidenteLabel"
        Lugar_de_accidenteLabel.Size = New System.Drawing.Size(102, 13)
        Lugar_de_accidenteLabel.TabIndex = 117
        Lugar_de_accidenteLabel.Text = "Lugar de accidente:"
        '
        'Entidad_Pago_IT_CPLabel
        '
        Entidad_Pago_IT_CPLabel.AutoSize = True
        Entidad_Pago_IT_CPLabel.Location = New System.Drawing.Point(19, 119)
        Entidad_Pago_IT_CPLabel.Name = "Entidad_Pago_IT_CPLabel"
        Entidad_Pago_IT_CPLabel.Size = New System.Drawing.Size(104, 13)
        Entidad_Pago_IT_CPLabel.TabIndex = 86
        Entidad_Pago_IT_CPLabel.Text = "Entidad Pago IT CP:"
        '
        'grpDatosBasicos
        '
        Me.grpDatosBasicos.Controls.Add(FechaAsistenciaLabel)
        Me.grpDatosBasicos.Controls.Add(Me.FechaAsistenciaDateTimePicker)
        Me.grpDatosBasicos.Controls.Add(CausaBajaLabel)
        Me.grpDatosBasicos.Controls.Add(Me.CausaBajaCheckBox)
        Me.grpDatosBasicos.Controls.Add(E_SituacionLabel)
        Me.grpDatosBasicos.Controls.Add(Me.E_SituacionComboBox)
        Me.grpDatosBasicos.Controls.Add(E_RegimenLabel)
        Me.grpDatosBasicos.Controls.Add(Me.E_RegimenComboBox)
        Me.grpDatosBasicos.Controls.Add(Me.ID_ParteTextBox)
        Me.grpDatosBasicos.Controls.Add(ID_ParteLabel)
        Me.grpDatosBasicos.Controls.Add(Me.E_TipoComboBox)
        Me.grpDatosBasicos.Controls.Add(E_TipoLabel)
        Me.grpDatosBasicos.Location = New System.Drawing.Point(5, 28)
        Me.grpDatosBasicos.Name = "grpDatosBasicos"
        Me.grpDatosBasicos.Size = New System.Drawing.Size(643, 122)
        Me.grpDatosBasicos.TabIndex = 100
        Me.grpDatosBasicos.TabStop = False
        Me.grpDatosBasicos.Text = "Datos básicos"
        '
        'FechaAsistenciaDateTimePicker
        '
        Me.FechaAsistenciaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_Partes_AsistenciaBindingSource, "FechaAsistencia", True))
        Me.FechaAsistenciaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaAsistenciaDateTimePicker.Location = New System.Drawing.Point(138, 88)
        Me.FechaAsistenciaDateTimePicker.Name = "FechaAsistenciaDateTimePicker"
        Me.FechaAsistenciaDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.FechaAsistenciaDateTimePicker.TabIndex = 98
        '
        'N_Partes_AsistenciaBindingSource
        '
        Me.N_Partes_AsistenciaBindingSource.DataMember = "N_Partes_Asistencia"
        Me.N_Partes_AsistenciaBindingSource.DataSource = Me.CM3DataSet
        '
        'CM3DataSet
        '
        Me.CM3DataSet.DataSetName = "CM3DataSet"
        Me.CM3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CausaBajaCheckBox
        '
        Me.CausaBajaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_Partes_AsistenciaBindingSource, "CausaBaja", True))
        Me.CausaBajaCheckBox.Location = New System.Drawing.Point(364, 88)
        Me.CausaBajaCheckBox.Name = "CausaBajaCheckBox"
        Me.CausaBajaCheckBox.Size = New System.Drawing.Size(25, 24)
        Me.CausaBajaCheckBox.TabIndex = 97
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
        Me.ID_ParteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "ID_ParteAsistencia", True))
        Me.ID_ParteTextBox.Location = New System.Drawing.Point(138, 27)
        Me.ID_ParteTextBox.Name = "ID_ParteTextBox"
        Me.ID_ParteTextBox.ReadOnly = True
        Me.ID_ParteTextBox.Size = New System.Drawing.Size(64, 20)
        Me.ID_ParteTextBox.TabIndex = 2
        '
        'E_TipoComboBox
        '
        Me.E_TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.E_TipoComboBox.Enabled = False
        Me.E_TipoComboBox.FormattingEnabled = True
        Me.E_TipoComboBox.Location = New System.Drawing.Point(138, 58)
        Me.E_TipoComboBox.Name = "E_TipoComboBox"
        Me.E_TipoComboBox.Size = New System.Drawing.Size(116, 21)
        Me.E_TipoComboBox.TabIndex = 86
        '
        'groupMedico
        '
        Me.groupMedico.Controls.Add(Me.CtrlMedico1)
        Me.groupMedico.Location = New System.Drawing.Point(7, 517)
        Me.groupMedico.Name = "groupMedico"
        Me.groupMedico.Size = New System.Drawing.Size(456, 87)
        Me.groupMedico.TabIndex = 99
        Me.groupMedico.TabStop = False
        Me.groupMedico.Text = "Datos Médico"
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(11, 23)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(435, 42)
        Me.CtrlMedico1.TabIndex = 115
        '
        'grpEmpresa
        '
        Me.grpEmpresa.Controls.Add(Me.rb_ISM)
        Me.grpEmpresa.Controls.Add(Me.rb_INSS)
        Me.grpEmpresa.Controls.Add(Entidad_Pago_IT_CPLabel)
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
        Me.grpEmpresa.Controls.Add(Código_Nacional_Actividad_Económica_CNAELabel)
        Me.grpEmpresa.Controls.Add(Me.Código_Nacional_Actividad_Económica_CNAETextBox)
        Me.grpEmpresa.Location = New System.Drawing.Point(7, 335)
        Me.grpEmpresa.Name = "grpEmpresa"
        Me.grpEmpresa.Size = New System.Drawing.Size(641, 176)
        Me.grpEmpresa.TabIndex = 98
        Me.grpEmpresa.TabStop = False
        Me.grpEmpresa.Text = "Datos Empresa"
        '
        'rb_ISM
        '
        Me.rb_ISM.AutoSize = True
        Me.rb_ISM.Location = New System.Drawing.Point(190, 118)
        Me.rb_ISM.Name = "rb_ISM"
        Me.rb_ISM.Size = New System.Drawing.Size(44, 17)
        Me.rb_ISM.TabIndex = 87
        Me.rb_ISM.Text = "ISM"
        Me.rb_ISM.UseVisualStyleBackColor = True
        '
        'rb_INSS
        '
        Me.rb_INSS.AutoSize = True
        Me.rb_INSS.Checked = True
        Me.rb_INSS.Location = New System.Drawing.Point(136, 118)
        Me.rb_INSS.Name = "rb_INSS"
        Me.rb_INSS.Size = New System.Drawing.Size(50, 17)
        Me.rb_INSS.TabIndex = 88
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
        Me.ProvinciaEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "ProvinciaEmpresa", True))
        Me.ProvinciaEmpresaTextBox.Location = New System.Drawing.Point(418, 44)
        Me.ProvinciaEmpresaTextBox.Name = "ProvinciaEmpresaTextBox"
        Me.ProvinciaEmpresaTextBox.Size = New System.Drawing.Size(204, 20)
        Me.ProvinciaEmpresaTextBox.TabIndex = 13
        '
        'NombreEmpresaTextBox
        '
        Me.NombreEmpresaTextBox.AcceptsReturn = True
        Me.NombreEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "NombreEmpresa", True))
        Me.NombreEmpresaTextBox.Location = New System.Drawing.Point(136, 29)
        Me.NombreEmpresaTextBox.Name = "NombreEmpresaTextBox"
        Me.NombreEmpresaTextBox.ReadOnly = True
        Me.NombreEmpresaTextBox.Size = New System.Drawing.Size(226, 20)
        Me.NombreEmpresaTextBox.TabIndex = 58
        '
        'LocalidadEmpresaTextBox
        '
        Me.LocalidadEmpresaTextBox.AcceptsReturn = True
        Me.LocalidadEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "LocalidadEmpresa", True))
        Me.LocalidadEmpresaTextBox.Location = New System.Drawing.Point(422, 141)
        Me.LocalidadEmpresaTextBox.Name = "LocalidadEmpresaTextBox"
        Me.LocalidadEmpresaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LocalidadEmpresaTextBox.TabIndex = 15
        '
        'DomicilioEmpresaTextBox
        '
        Me.DomicilioEmpresaTextBox.AcceptsReturn = True
        Me.DomicilioEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "DomicilioEmpresa", True))
        Me.DomicilioEmpresaTextBox.Location = New System.Drawing.Point(418, 93)
        Me.DomicilioEmpresaTextBox.Name = "DomicilioEmpresaTextBox"
        Me.DomicilioEmpresaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DomicilioEmpresaTextBox.TabIndex = 14
        '
        'Codigo_Postal_EmpresaTextBox
        '
        Me.Codigo_Postal_EmpresaTextBox.AcceptsReturn = True
        Me.Codigo_Postal_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Codigo_Postal_Empresa", True))
        Me.Codigo_Postal_EmpresaTextBox.Location = New System.Drawing.Point(136, 145)
        Me.Codigo_Postal_EmpresaTextBox.Name = "Codigo_Postal_EmpresaTextBox"
        Me.Codigo_Postal_EmpresaTextBox.Size = New System.Drawing.Size(124, 20)
        Me.Codigo_Postal_EmpresaTextBox.TabIndex = 12
        '
        'Actividad_empresaTextBox
        '
        Me.Actividad_empresaTextBox.AcceptsReturn = True
        Me.Actividad_empresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Actividad_empresa", True))
        Me.Actividad_empresaTextBox.Location = New System.Drawing.Point(137, 58)
        Me.Actividad_empresaTextBox.Name = "Actividad_empresaTextBox"
        Me.Actividad_empresaTextBox.Size = New System.Drawing.Size(260, 20)
        Me.Actividad_empresaTextBox.TabIndex = 9
        '
        'Código_Nacional_Actividad_Económica_CNAETextBox
        '
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.AcceptsReturn = True
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Código_Nacional_Actividad_Económica_CNAE", True))
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.Location = New System.Drawing.Point(138, 87)
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.Name = "Código_Nacional_Actividad_Económica_CNAETextBox"
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.Size = New System.Drawing.Size(220, 20)
        Me.Código_Nacional_Actividad_Económica_CNAETextBox.TabIndex = 10
        '
        'groupPaciente
        '
        Me.groupPaciente.Controls.Add(DNILabel)
        Me.groupPaciente.Controls.Add(Me.DNITextBox)
        Me.groupPaciente.Controls.Add(ProvinciaPacienteLabel)
        Me.groupPaciente.Controls.Add(Me.ProvinciaPacienteTextBox)
        Me.groupPaciente.Controls.Add(Me.btnBuscaPaciente)
        Me.groupPaciente.Controls.Add(NombreCompletoPacienteLabel)
        Me.groupPaciente.Controls.Add(Me.NombreCompletoPacienteTextBox)
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
        Me.groupPaciente.Location = New System.Drawing.Point(7, 156)
        Me.groupPaciente.Name = "groupPaciente"
        Me.groupPaciente.Size = New System.Drawing.Size(641, 179)
        Me.groupPaciente.TabIndex = 97
        Me.groupPaciente.TabStop = False
        Me.groupPaciente.Text = "Datos Paciente"
        '
        'DNITextBox
        '
        Me.DNITextBox.AcceptsReturn = True
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(488, 80)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(144, 20)
        Me.DNITextBox.TabIndex = 84
        '
        'ProvinciaPacienteTextBox
        '
        Me.ProvinciaPacienteTextBox.AcceptsReturn = True
        Me.ProvinciaPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "ProvinciaPaciente", True))
        Me.ProvinciaPacienteTextBox.Location = New System.Drawing.Point(137, 139)
        Me.ProvinciaPacienteTextBox.Name = "ProvinciaPacienteTextBox"
        Me.ProvinciaPacienteTextBox.Size = New System.Drawing.Size(151, 20)
        Me.ProvinciaPacienteTextBox.TabIndex = 4
        '
        'btnBuscaPaciente
        '
        Me.btnBuscaPaciente.Image = Global.centro_medico.My.Resources.Resources.search16x16
        Me.btnBuscaPaciente.Location = New System.Drawing.Point(352, 17)
        Me.btnBuscaPaciente.Name = "btnBuscaPaciente"
        Me.btnBuscaPaciente.Size = New System.Drawing.Size(36, 23)
        Me.btnBuscaPaciente.TabIndex = 83
        Me.btnBuscaPaciente.UseVisualStyleBackColor = True
        Me.btnBuscaPaciente.Visible = False
        '
        'NombreCompletoPacienteTextBox
        '
        Me.NombreCompletoPacienteTextBox.AcceptsReturn = True
        Me.NombreCompletoPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "NombreCompletoPaciente", True))
        Me.NombreCompletoPacienteTextBox.Location = New System.Drawing.Point(136, 20)
        Me.NombreCompletoPacienteTextBox.Name = "NombreCompletoPacienteTextBox"
        Me.NombreCompletoPacienteTextBox.ReadOnly = True
        Me.NombreCompletoPacienteTextBox.Size = New System.Drawing.Size(218, 20)
        Me.NombreCompletoPacienteTextBox.TabIndex = 0
        '
        'Num_Tarjeta_sanitariaTextBox
        '
        Me.Num_Tarjeta_sanitariaTextBox.AcceptsReturn = True
        Me.Num_Tarjeta_sanitariaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Num_Tarjeta_sanitaria", True))
        Me.Num_Tarjeta_sanitariaTextBox.Location = New System.Drawing.Point(136, 80)
        Me.Num_Tarjeta_sanitariaTextBox.Name = "Num_Tarjeta_sanitariaTextBox"
        Me.Num_Tarjeta_sanitariaTextBox.Size = New System.Drawing.Size(191, 20)
        Me.Num_Tarjeta_sanitariaTextBox.TabIndex = 2
        '
        'Num_Afiliacion_Seg_SocialTextBox
        '
        Me.Num_Afiliacion_Seg_SocialTextBox.AcceptsReturn = True
        Me.Num_Afiliacion_Seg_SocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Num_Afiliacion_Seg_Social", True))
        Me.Num_Afiliacion_Seg_SocialTextBox.Location = New System.Drawing.Point(136, 111)
        Me.Num_Afiliacion_Seg_SocialTextBox.Name = "Num_Afiliacion_Seg_SocialTextBox"
        Me.Num_Afiliacion_Seg_SocialTextBox.Size = New System.Drawing.Size(152, 20)
        Me.Num_Afiliacion_Seg_SocialTextBox.TabIndex = 3
        '
        'DomicilioPacienteTextBox
        '
        Me.DomicilioPacienteTextBox.AcceptsReturn = True
        Me.DomicilioPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "DomicilioPaciente", True))
        Me.DomicilioPacienteTextBox.Location = New System.Drawing.Point(432, 111)
        Me.DomicilioPacienteTextBox.Name = "DomicilioPacienteTextBox"
        Me.DomicilioPacienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DomicilioPacienteTextBox.TabIndex = 7
        '
        'LocalidadPacienteTextBox
        '
        Me.LocalidadPacienteTextBox.AcceptsReturn = True
        Me.LocalidadPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "LocalidadPaciente", True))
        Me.LocalidadPacienteTextBox.Location = New System.Drawing.Point(432, 139)
        Me.LocalidadPacienteTextBox.Name = "LocalidadPacienteTextBox"
        Me.LocalidadPacienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LocalidadPacienteTextBox.TabIndex = 8
        '
        'Codigo_PostalPacienteTextBox
        '
        Me.Codigo_PostalPacienteTextBox.AcceptsReturn = True
        Me.Codigo_PostalPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Codigo_PostalPaciente", True))
        Me.Codigo_PostalPacienteTextBox.Location = New System.Drawing.Point(488, 50)
        Me.Codigo_PostalPacienteTextBox.Name = "Codigo_PostalPacienteTextBox"
        Me.Codigo_PostalPacienteTextBox.Size = New System.Drawing.Size(144, 20)
        Me.Codigo_PostalPacienteTextBox.TabIndex = 6
        '
        'TelefonoPacienteTextBox
        '
        Me.TelefonoPacienteTextBox.AcceptsReturn = True
        Me.TelefonoPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "TelefonoPaciente", True))
        Me.TelefonoPacienteTextBox.Location = New System.Drawing.Point(488, 23)
        Me.TelefonoPacienteTextBox.Name = "TelefonoPacienteTextBox"
        Me.TelefonoPacienteTextBox.Size = New System.Drawing.Size(144, 20)
        Me.TelefonoPacienteTextBox.TabIndex = 5
        '
        'Puesto_de_trabajoPacienteTextBox
        '
        Me.Puesto_de_trabajoPacienteTextBox.AcceptsReturn = True
        Me.Puesto_de_trabajoPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Puesto_de_trabajoPaciente", True))
        Me.Puesto_de_trabajoPacienteTextBox.Location = New System.Drawing.Point(136, 50)
        Me.Puesto_de_trabajoPacienteTextBox.Name = "Puesto_de_trabajoPacienteTextBox"
        Me.Puesto_de_trabajoPacienteTextBox.Size = New System.Drawing.Size(218, 20)
        Me.Puesto_de_trabajoPacienteTextBox.TabIndex = 1
        '
        'Asistido_PreviamenteCheckBox
        '
        Me.Asistido_PreviamenteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_Partes_AsistenciaBindingSource, "Asistido_Previamente", True))
        Me.Asistido_PreviamenteCheckBox.Location = New System.Drawing.Point(421, 29)
        Me.Asistido_PreviamenteCheckBox.Name = "Asistido_PreviamenteCheckBox"
        Me.Asistido_PreviamenteCheckBox.Size = New System.Drawing.Size(19, 24)
        Me.Asistido_PreviamenteCheckBox.TabIndex = 102
        '
        'Era_el_lugar_de_trabajo_habitualCheckBox
        '
        Me.Era_el_lugar_de_trabajo_habitualCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_Partes_AsistenciaBindingSource, "Era_el_lugar_de_trabajo_habitual", True))
        Me.Era_el_lugar_de_trabajo_habitualCheckBox.Location = New System.Drawing.Point(174, 62)
        Me.Era_el_lugar_de_trabajo_habitualCheckBox.Name = "Era_el_lugar_de_trabajo_habitualCheckBox"
        Me.Era_el_lugar_de_trabajo_habitualCheckBox.Size = New System.Drawing.Size(28, 24)
        Me.Era_el_lugar_de_trabajo_habitualCheckBox.TabIndex = 104
        '
        'Descripcion_del_accidenteTextBox
        '
        Me.Descripcion_del_accidenteTextBox.AcceptsReturn = True
        Me.Descripcion_del_accidenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Descripcion_del_accidente", True))
        Me.Descripcion_del_accidenteTextBox.Location = New System.Drawing.Point(13, 155)
        Me.Descripcion_del_accidenteTextBox.Multiline = True
        Me.Descripcion_del_accidenteTextBox.Name = "Descripcion_del_accidenteTextBox"
        Me.Descripcion_del_accidenteTextBox.Size = New System.Drawing.Size(427, 152)
        Me.Descripcion_del_accidenteTextBox.TabIndex = 105
        '
        'Descripcion_DiagnosticoTextBox
        '
        Me.Descripcion_DiagnosticoTextBox.AcceptsReturn = True
        Me.Descripcion_DiagnosticoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Descripcion_Diagnostico", True))
        Me.Descripcion_DiagnosticoTextBox.Location = New System.Drawing.Point(13, 380)
        Me.Descripcion_DiagnosticoTextBox.Multiline = True
        Me.Descripcion_DiagnosticoTextBox.Name = "Descripcion_DiagnosticoTextBox"
        Me.Descripcion_DiagnosticoTextBox.Size = New System.Drawing.Size(428, 46)
        Me.Descripcion_DiagnosticoTextBox.TabIndex = 106
        '
        'Duracion_estandar_fecha_iniDateTimePicker
        '
        Me.Duracion_estandar_fecha_iniDateTimePicker.Checked = False
        Me.Duracion_estandar_fecha_iniDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_Partes_AsistenciaBindingSource, "Duracion_estandar_fecha_ini", True))
        Me.Duracion_estandar_fecha_iniDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Duracion_estandar_fecha_iniDateTimePicker.Location = New System.Drawing.Point(59, 25)
        Me.Duracion_estandar_fecha_iniDateTimePicker.Name = "Duracion_estandar_fecha_iniDateTimePicker"
        Me.Duracion_estandar_fecha_iniDateTimePicker.ShowCheckBox = True
        Me.Duracion_estandar_fecha_iniDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.Duracion_estandar_fecha_iniDateTimePicker.TabIndex = 107
        '
        'Duracion_estandar_fecha_finDateTimePicker
        '
        Me.Duracion_estandar_fecha_finDateTimePicker.Checked = False
        Me.Duracion_estandar_fecha_finDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_Partes_AsistenciaBindingSource, "Duracion_estandar_fecha_fin", True))
        Me.Duracion_estandar_fecha_finDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Duracion_estandar_fecha_finDateTimePicker.Location = New System.Drawing.Point(235, 24)
        Me.Duracion_estandar_fecha_finDateTimePicker.Name = "Duracion_estandar_fecha_finDateTimePicker"
        Me.Duracion_estandar_fecha_finDateTimePicker.ShowCheckBox = True
        Me.Duracion_estandar_fecha_finDateTimePicker.Size = New System.Drawing.Size(84, 20)
        Me.Duracion_estandar_fecha_finDateTimePicker.TabIndex = 108
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.AcceptsReturn = True
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(13, 545)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(427, 76)
        Me.ObservacionesTextBox.TabIndex = 109
        '
        'grpDuracion
        '
        Me.grpDuracion.Controls.Add(Duracion_estandar_fecha_iniLabel)
        Me.grpDuracion.Controls.Add(Me.Duracion_estandar_fecha_iniDateTimePicker)
        Me.grpDuracion.Controls.Add(Duracion_estandar_fecha_finLabel)
        Me.grpDuracion.Controls.Add(Me.Duracion_estandar_fecha_finDateTimePicker)
        Me.grpDuracion.Location = New System.Drawing.Point(14, 448)
        Me.grpDuracion.Name = "grpDuracion"
        Me.grpDuracion.Size = New System.Drawing.Size(339, 64)
        Me.grpDuracion.TabIndex = 111
        Me.grpDuracion.TabStop = False
        Me.grpDuracion.Text = "Duración estándar"
        '
        'grpDetalles
        '
        Me.grpDetalles.Controls.Add(Lugar_de_accidenteLabel)
        Me.grpDetalles.Controls.Add(Me.Lugar_de_accidenteTextBox)
        Me.grpDetalles.Controls.Add(Fecha_Asistencia_previaLabel)
        Me.grpDetalles.Controls.Add(Me.Fecha_Asistencia_previaDateTimePicker)
        Me.grpDetalles.Controls.Add(Fecha_accidenteLabel)
        Me.grpDetalles.Controls.Add(Me.Fecha_accidenteDateTimePicker)
        Me.grpDetalles.Controls.Add(E_PronosticoLabel)
        Me.grpDetalles.Controls.Add(Me.E_PronosticoComboBox)
        Me.grpDetalles.Controls.Add(E_TratamientoLabel1)
        Me.grpDetalles.Controls.Add(Me.E_TratamientoComboBox)
        Me.grpDetalles.Controls.Add(Me.Asistido_PreviamenteCheckBox)
        Me.grpDetalles.Controls.Add(Me.grpDuracion)
        Me.grpDetalles.Controls.Add(Asistido_PreviamenteLabel)
        Me.grpDetalles.Controls.Add(ObservacionesLabel)
        Me.grpDetalles.Controls.Add(Me.ObservacionesTextBox)
        Me.grpDetalles.Controls.Add(Descripcion_DiagnosticoLabel)
        Me.grpDetalles.Controls.Add(Me.Descripcion_DiagnosticoTextBox)
        Me.grpDetalles.Controls.Add(Me.Era_el_lugar_de_trabajo_habitualCheckBox)
        Me.grpDetalles.Controls.Add(Era_el_lugar_de_trabajo_habitualLabel)
        Me.grpDetalles.Controls.Add(Descripcion_del_accidenteLabel)
        Me.grpDetalles.Controls.Add(Me.Descripcion_del_accidenteTextBox)
        Me.grpDetalles.Controls.Add(Me.CtrlDiagnosticos1)
        Me.grpDetalles.Controls.Add(ID_DiagnosticoLabel)
        Me.grpDetalles.Location = New System.Drawing.Point(661, 28)
        Me.grpDetalles.Name = "grpDetalles"
        Me.grpDetalles.Size = New System.Drawing.Size(455, 633)
        Me.grpDetalles.TabIndex = 113
        Me.grpDetalles.TabStop = False
        Me.grpDetalles.Text = "Detalles"
        '
        'Lugar_de_accidenteTextBox
        '
        Me.Lugar_de_accidenteTextBox.AcceptsReturn = True
        Me.Lugar_de_accidenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Partes_AsistenciaBindingSource, "Lugar_de_accidente", True))
        Me.Lugar_de_accidenteTextBox.Location = New System.Drawing.Point(124, 96)
        Me.Lugar_de_accidenteTextBox.Name = "Lugar_de_accidenteTextBox"
        Me.Lugar_de_accidenteTextBox.Size = New System.Drawing.Size(318, 20)
        Me.Lugar_de_accidenteTextBox.TabIndex = 118
        '
        'Fecha_Asistencia_previaDateTimePicker
        '
        Me.Fecha_Asistencia_previaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_Partes_AsistenciaBindingSource, "Fecha_Asistencia_previa", True))
        Me.Fecha_Asistencia_previaDateTimePicker.Enabled = False
        Me.Fecha_Asistencia_previaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_Asistencia_previaDateTimePicker.Location = New System.Drawing.Point(353, 62)
        Me.Fecha_Asistencia_previaDateTimePicker.Name = "Fecha_Asistencia_previaDateTimePicker"
        Me.Fecha_Asistencia_previaDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.Fecha_Asistencia_previaDateTimePicker.TabIndex = 117
        '
        'Fecha_accidenteDateTimePicker
        '
        Me.Fecha_accidenteDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_Partes_AsistenciaBindingSource, "Fecha_accidente", True))
        Me.Fecha_accidenteDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_accidenteDateTimePicker.Location = New System.Drawing.Point(168, 28)
        Me.Fecha_accidenteDateTimePicker.Name = "Fecha_accidenteDateTimePicker"
        Me.Fecha_accidenteDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.Fecha_accidenteDateTimePicker.TabIndex = 116
        '
        'E_PronosticoComboBox
        '
        Me.E_PronosticoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.E_PronosticoComboBox.FormattingEnabled = True
        Me.E_PronosticoComboBox.Location = New System.Drawing.Point(321, 128)
        Me.E_PronosticoComboBox.Name = "E_PronosticoComboBox"
        Me.E_PronosticoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.E_PronosticoComboBox.TabIndex = 115
        '
        'E_TratamientoComboBox
        '
        Me.E_TratamientoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.E_TratamientoComboBox.FormattingEnabled = True
        Me.E_TratamientoComboBox.Location = New System.Drawing.Point(283, 519)
        Me.E_TratamientoComboBox.Name = "E_TratamientoComboBox"
        Me.E_TratamientoComboBox.Size = New System.Drawing.Size(157, 21)
        Me.E_TratamientoComboBox.TabIndex = 114
        '
        'CtrlDiagnosticos1
        '
        Me.CtrlDiagnosticos1.DataBindings.Add(New System.Windows.Forms.Binding("ID_DIAGNOSTICOS", Me.N_Partes_AsistenciaBindingSource, "ID_Diagnostico", True))
        Me.CtrlDiagnosticos1.ID_DIAGNOSTICOS = Nothing
        Me.CtrlDiagnosticos1.Location = New System.Drawing.Point(86, 323)
        Me.CtrlDiagnosticos1.Name = "CtrlDiagnosticos1"
        Me.CtrlDiagnosticos1.Size = New System.Drawing.Size(340, 25)
        Me.CtrlDiagnosticos1.TabIndex = 94
        '
        'N_Partes_AsistenciaTableAdapter
        '
        Me.N_Partes_AsistenciaTableAdapter.ClearBeforeFill = True
        '
        'N_Partes_AsistenciaBindingNavigator
        '
        Me.N_Partes_AsistenciaBindingNavigator.AddNewItem = Nothing
        Me.N_Partes_AsistenciaBindingNavigator.BindingSource = Me.N_Partes_AsistenciaBindingSource
        Me.N_Partes_AsistenciaBindingNavigator.CountItem = Nothing
        Me.N_Partes_AsistenciaBindingNavigator.DeleteItem = Nothing
        Me.N_Partes_AsistenciaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.N_Partes_AsistenciaBindingNavigatorSaveItem, Me.BindingNavigatorSeparator, Me.ts_Imprimir})
        Me.N_Partes_AsistenciaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.N_Partes_AsistenciaBindingNavigator.MoveFirstItem = Nothing
        Me.N_Partes_AsistenciaBindingNavigator.MoveLastItem = Nothing
        Me.N_Partes_AsistenciaBindingNavigator.MoveNextItem = Nothing
        Me.N_Partes_AsistenciaBindingNavigator.MovePreviousItem = Nothing
        Me.N_Partes_AsistenciaBindingNavigator.Name = "N_Partes_AsistenciaBindingNavigator"
        Me.N_Partes_AsistenciaBindingNavigator.PositionItem = Nothing
        Me.N_Partes_AsistenciaBindingNavigator.Size = New System.Drawing.Size(1118, 25)
        Me.N_Partes_AsistenciaBindingNavigator.TabIndex = 114
        Me.N_Partes_AsistenciaBindingNavigator.Text = "BindingNavigator1"
        '
        'N_Partes_AsistenciaBindingNavigatorSaveItem
        '
        Me.N_Partes_AsistenciaBindingNavigatorSaveItem.Image = CType(resources.GetObject("N_Partes_AsistenciaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.N_Partes_AsistenciaBindingNavigatorSaveItem.Name = "N_Partes_AsistenciaBindingNavigatorSaveItem"
        Me.N_Partes_AsistenciaBindingNavigatorSaveItem.Size = New System.Drawing.Size(69, 22)
        Me.N_Partes_AsistenciaBindingNavigatorSaveItem.Text = "Guardar"
        Me.N_Partes_AsistenciaBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ts_Imprimir
        '
        Me.ts_Imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.ts_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Imprimir.Name = "ts_Imprimir"
        Me.ts_Imprimir.Size = New System.Drawing.Size(73, 22)
        Me.ts_Imprimir.Text = "Imprimir"
        Me.ts_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'group_Proceso
        '
        Me.group_Proceso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group_Proceso.Controls.Add(Me.btnVerProceso)
        Me.group_Proceso.Controls.Add(Me.lblCitaProcesoInfo)
        Me.group_Proceso.Controls.Add(Me.btn_HistorialProcesos)
        Me.group_Proceso.Location = New System.Drawing.Point(469, 517)
        Me.group_Proceso.Name = "group_Proceso"
        Me.group_Proceso.Size = New System.Drawing.Size(186, 144)
        Me.group_Proceso.TabIndex = 115
        Me.group_Proceso.TabStop = False
        Me.group_Proceso.Text = "Proceso"
        '
        'btnVerProceso
        '
        Me.btnVerProceso.Enabled = False
        Me.btnVerProceso.Image = Global.centro_medico.My.Resources.Resources._24_image_open
        Me.btnVerProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerProceso.Location = New System.Drawing.Point(97, 85)
        Me.btnVerProceso.Name = "btnVerProceso"
        Me.btnVerProceso.Size = New System.Drawing.Size(85, 44)
        Me.btnVerProceso.TabIndex = 100
        Me.btnVerProceso.Text = "Ver Proceso"
        Me.btnVerProceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerProceso.UseVisualStyleBackColor = True
        '
        'lblCitaProcesoInfo
        '
        Me.lblCitaProcesoInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCitaProcesoInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitaProcesoInfo.Location = New System.Drawing.Point(10, 22)
        Me.lblCitaProcesoInfo.Name = "lblCitaProcesoInfo"
        Me.lblCitaProcesoInfo.Size = New System.Drawing.Size(170, 60)
        Me.lblCitaProcesoInfo.TabIndex = 99
        Me.lblCitaProcesoInfo.Text = "Este parte no se encuentra vinculado a ningun proceso"
        '
        'btn_HistorialProcesos
        '
        Me.btn_HistorialProcesos.Image = Global.centro_medico.My.Resources.Resources._24_imageset
        Me.btn_HistorialProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_HistorialProcesos.Location = New System.Drawing.Point(6, 85)
        Me.btn_HistorialProcesos.Name = "btn_HistorialProcesos"
        Me.btn_HistorialProcesos.Size = New System.Drawing.Size(88, 44)
        Me.btn_HistorialProcesos.TabIndex = 98
        Me.btn_HistorialProcesos.Text = "Historial de Procesos"
        Me.btn_HistorialProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_HistorialProcesos.UseVisualStyleBackColor = True
        '
        'frmPartesAsistencia_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1118, 673)
        Me.Controls.Add(Me.group_Proceso)
        Me.Controls.Add(Me.N_Partes_AsistenciaBindingNavigator)
        Me.Controls.Add(Me.grpDetalles)
        Me.Controls.Add(Me.grpDatosBasicos)
        Me.Controls.Add(Me.groupMedico)
        Me.Controls.Add(Me.grpEmpresa)
        Me.Controls.Add(Me.groupPaciente)
        Me.Name = "frmPartesAsistencia_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parte ASISTENCIA"
        Me.grpDatosBasicos.ResumeLayout(False)
        Me.grpDatosBasicos.PerformLayout()
        CType(Me.N_Partes_AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupMedico.ResumeLayout(False)
        Me.grpEmpresa.ResumeLayout(False)
        Me.grpEmpresa.PerformLayout()
        Me.groupPaciente.ResumeLayout(False)
        Me.groupPaciente.PerformLayout()
        Me.grpDuracion.ResumeLayout(False)
        Me.grpDuracion.PerformLayout()
        Me.grpDetalles.ResumeLayout(False)
        Me.grpDetalles.PerformLayout()
        CType(Me.N_Partes_AsistenciaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.N_Partes_AsistenciaBindingNavigator.ResumeLayout(False)
        Me.N_Partes_AsistenciaBindingNavigator.PerformLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Proceso.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDatosBasicos As System.Windows.Forms.GroupBox
    Friend WithEvents E_SituacionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents E_RegimenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ID_ParteTextBox As ctrlTextboxAvanzado
    Friend WithEvents E_TipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents groupMedico As System.Windows.Forms.GroupBox
    Friend WithEvents CtrlDiagnosticos1 As centro_medico.ctrlDiagnosticos
    Friend WithEvents grpEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents btn_BuscarEmpresa As System.Windows.Forms.Button
    Friend WithEvents ProvinciaEmpresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents NombreEmpresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents LocalidadEmpresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents DomicilioEmpresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents Codigo_Postal_EmpresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents Actividad_empresaTextBox As ctrlTextboxAvanzado
    Friend WithEvents Código_Nacional_Actividad_Económica_CNAETextBox As ctrlTextboxAvanzado
    Friend WithEvents groupPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents ProvinciaPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents btnBuscaPaciente As System.Windows.Forms.Button
    Friend WithEvents NombreCompletoPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents Num_Tarjeta_sanitariaTextBox As ctrlTextboxAvanzado
    Friend WithEvents Num_Afiliacion_Seg_SocialTextBox As ctrlTextboxAvanzado
    Friend WithEvents DomicilioPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents LocalidadPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents Codigo_PostalPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents TelefonoPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents Puesto_de_trabajoPacienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents CausaBajaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DNITextBox As ctrlTextboxAvanzado
    Friend WithEvents Asistido_PreviamenteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Era_el_lugar_de_trabajo_habitualCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Descripcion_del_accidenteTextBox As ctrlTextboxAvanzado
    Friend WithEvents Descripcion_DiagnosticoTextBox As ctrlTextboxAvanzado
    Friend WithEvents Duracion_estandar_fecha_iniDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Duracion_estandar_fecha_finDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ObservacionesTextBox As ctrlTextboxAvanzado
    Friend WithEvents grpDuracion As System.Windows.Forms.GroupBox
    Friend WithEvents grpDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents E_TratamientoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents E_PronosticoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fecha_Asistencia_previaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_accidenteDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CM3DataSet As centro_medico.CM3DataSet
    Friend WithEvents N_Partes_AsistenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Partes_AsistenciaTableAdapter As centro_medico.CM3DataSetTableAdapters.N_Partes_AsistenciaTableAdapter
    Friend WithEvents N_Partes_AsistenciaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents N_Partes_AsistenciaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FechaAsistenciaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents Lugar_de_accidenteTextBox As ctrlTextboxAvanzado
    Friend WithEvents ts_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents rb_ISM As System.Windows.Forms.RadioButton
    Friend WithEvents rb_INSS As System.Windows.Forms.RadioButton
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Friend WithEvents group_Proceso As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerProceso As System.Windows.Forms.Button
    Friend WithEvents lblCitaProcesoInfo As System.Windows.Forms.Label
    Friend WithEvents btn_HistorialProcesos As System.Windows.Forms.Button
End Class
