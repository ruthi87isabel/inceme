<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor_Nuevo
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
        Dim CodigoLabel1 As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim NombreFiscalLabel As System.Windows.Forms.Label
        Dim NombreComercialLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DiasPago1Label As System.Windows.Forms.Label
        Dim AprovisionamientoMesesLabel As System.Windows.Forms.Label
        Dim AprovisionamientoDiasLabel As System.Windows.Forms.Label
        Dim TarifaEnActivoLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim ID_FormaPagoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DescuentoFijo1Label As System.Windows.Forms.Label
        Dim PorcentajeRetensionLabel As System.Windows.Forms.Label
        Dim CCCLabel As System.Windows.Forms.Label
        Dim ID_BancoLabel As System.Windows.Forms.Label
        Dim MovilLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim FechaAltaLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim HorarioLabel As System.Windows.Forms.Label
        Dim VacacionesDesdeLabel As System.Windows.Forms.Label
        Dim NoVenderArticulosLabel As System.Windows.Forms.Label
        Dim NoRealizarPagosLabel As System.Windows.Forms.Label
        Dim NoImprimirLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim CodClienteLabel As System.Windows.Forms.Label
        Dim RappelFijoLabel As System.Windows.Forms.Label
        Dim PagoRapelsLabel As System.Windows.Forms.Label
        Dim RELabel As System.Windows.Forms.Label
        Dim lblObservaciones As System.Windows.Forms.Label
        Me.grpMainDatos = New System.Windows.Forms.GroupBox()
        Me.grbDocumentos = New System.Windows.Forms.GroupBox()
        Me.NombreFiscalTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.N_ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_Acreedor = New System.Windows.Forms.RadioButton()
        Me.rb_Proveedor = New System.Windows.Forms.RadioButton()
        Me.CodigoContabilidadTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.NombreComercialTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.NIFTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.CodigoTextBox1 = New centro_medico.ctrlTextboxAvanzado()
        Me.tcDatos = New System.Windows.Forms.TabControl()
        Me.tbFicha = New System.Windows.Forms.TabPage()
        Me.CtrlPoblacion1 = New centro_medico.ctrlPoblacion()
        Me.ObservacionesTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.N_BancosComboBox = New System.Windows.Forms.ComboBox()
        Me.N_BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DomicilioTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.TelefonoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.FaxTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.MovilTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.CCCTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.tbComercial = New System.Windows.Forms.TabPage()
        Me.grpIVA = New System.Windows.Forms.GroupBox()
        Me.RECheckBox = New System.Windows.Forms.CheckBox()
        Me.rb_IVA_Importacion = New System.Windows.Forms.RadioButton()
        Me.rb_IVA_Intracomunitarios = New System.Windows.Forms.RadioButton()
        Me.rb_IVA_No = New System.Windows.Forms.RadioButton()
        Me.rb_IVA_Si = New System.Windows.Forms.RadioButton()
        Me.grpPorte = New System.Windows.Forms.GroupBox()
        Me.PorteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.rb_Pagados = New System.Windows.Forms.RadioButton()
        Me.rb_Debidos = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRappels = New System.Windows.Forms.Button()
        Me.N_EscalasRappels_ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.N_EscalasRappels_ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagoRapelsTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.RappelFijoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DescuentoFijo1TextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DescuentoFijo2TextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DescuentoFijo3TextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.PorcentajeRetensionTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.CodClienteTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.N_FormasPagoComboBox = New System.Windows.Forms.ComboBox()
        Me.N_FormasPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiasPago1TextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DiasPago2TextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DiasPago3TextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.AprovisionamientoMesesTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.AprovisionamientoDiasTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.TarifaEnActivoTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.tbOtrosDatos = New System.Windows.Forms.TabPage()
        Me.grpHorario = New System.Windows.Forms.GroupBox()
        Me.HorarioTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.VacacionesDesdeTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.VacacionesHastaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.NoImprimirCheckBox = New System.Windows.Forms.CheckBox()
        Me.NoVenderArticulosCheckBox = New System.Windows.Forms.CheckBox()
        Me.NoRealizarPagosCheckBox = New System.Windows.Forms.CheckBox()
        Me.FechaAltaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WebTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.tbObservaciones = New System.Windows.Forms.TabPage()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.N_ProveedoresTableAdapter = New centro_medico.CMDataSetTableAdapters.N_ProveedoresTableAdapter()
        Me.FormasPagoTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter()
        Me.BancosTableAdapter = New centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter()
        CodigoLabel1 = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        NombreFiscalLabel = New System.Windows.Forms.Label()
        NombreComercialLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        DiasPago1Label = New System.Windows.Forms.Label()
        AprovisionamientoMesesLabel = New System.Windows.Forms.Label()
        AprovisionamientoDiasLabel = New System.Windows.Forms.Label()
        TarifaEnActivoLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        ID_FormaPagoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        DescuentoFijo1Label = New System.Windows.Forms.Label()
        PorcentajeRetensionLabel = New System.Windows.Forms.Label()
        CCCLabel = New System.Windows.Forms.Label()
        ID_BancoLabel = New System.Windows.Forms.Label()
        MovilLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DomicilioLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        FechaAltaLabel = New System.Windows.Forms.Label()
        WebLabel = New System.Windows.Forms.Label()
        HorarioLabel = New System.Windows.Forms.Label()
        VacacionesDesdeLabel = New System.Windows.Forms.Label()
        NoVenderArticulosLabel = New System.Windows.Forms.Label()
        NoRealizarPagosLabel = New System.Windows.Forms.Label()
        NoImprimirLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CodClienteLabel = New System.Windows.Forms.Label()
        RappelFijoLabel = New System.Windows.Forms.Label()
        PagoRapelsLabel = New System.Windows.Forms.Label()
        RELabel = New System.Windows.Forms.Label()
        lblObservaciones = New System.Windows.Forms.Label()
        Me.grpMainDatos.SuspendLayout()
        CType(Me.N_ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tcDatos.SuspendLayout()
        Me.tbFicha.SuspendLayout()
        CType(Me.N_BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbComercial.SuspendLayout()
        Me.grpIVA.SuspendLayout()
        Me.grpPorte.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.N_EscalasRappels_ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_EscalasRappels_ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_FormasPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbOtrosDatos.SuspendLayout()
        Me.grpHorario.SuspendLayout()
        Me.grpFiltros.SuspendLayout()
        Me.tbObservaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel1
        '
        CodigoLabel1.AutoSize = True
        CodigoLabel1.Location = New System.Drawing.Point(72, 22)
        CodigoLabel1.Name = "CodigoLabel1"
        CodigoLabel1.Size = New System.Drawing.Size(43, 13)
        CodigoLabel1.TabIndex = 2
        CodigoLabel1.Text = "Codigo:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Location = New System.Drawing.Point(88, 48)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(27, 13)
        NIFLabel.TabIndex = 8
        NIFLabel.Text = "NIF:"
        '
        'NombreFiscalLabel
        '
        NombreFiscalLabel.AutoSize = True
        NombreFiscalLabel.Location = New System.Drawing.Point(38, 74)
        NombreFiscalLabel.Name = "NombreFiscalLabel"
        NombreFiscalLabel.Size = New System.Drawing.Size(77, 13)
        NombreFiscalLabel.TabIndex = 10
        NombreFiscalLabel.Text = "Nombre Fiscal:"
        '
        'NombreComercialLabel
        '
        NombreComercialLabel.AutoSize = True
        NombreComercialLabel.Location = New System.Drawing.Point(19, 104)
        NombreComercialLabel.Name = "NombreComercialLabel"
        NombreComercialLabel.Size = New System.Drawing.Size(96, 13)
        NombreComercialLabel.TabIndex = 12
        NombreComercialLabel.Text = "Nombre Comercial:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(23, 22)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(43, 13)
        Label1.TabIndex = 2
        Label1.Text = "Codigo:"
        '
        'DiasPago1Label
        '
        DiasPago1Label.AutoSize = True
        DiasPago1Label.Location = New System.Drawing.Point(135, 67)
        DiasPago1Label.Name = "DiasPago1Label"
        DiasPago1Label.Size = New System.Drawing.Size(49, 13)
        DiasPago1Label.TabIndex = 42
        DiasPago1Label.Text = "semanas"
        '
        'AprovisionamientoMesesLabel
        '
        AprovisionamientoMesesLabel.AutoSize = True
        AprovisionamientoMesesLabel.Location = New System.Drawing.Point(3, 67)
        AprovisionamientoMesesLabel.Name = "AprovisionamientoMesesLabel"
        AprovisionamientoMesesLabel.Size = New System.Drawing.Size(93, 13)
        AprovisionamientoMesesLabel.TabIndex = 48
        AprovisionamientoMesesLabel.Text = "Aprovisionamiento"
        '
        'AprovisionamientoDiasLabel
        '
        AprovisionamientoDiasLabel.AutoSize = True
        AprovisionamientoDiasLabel.Location = New System.Drawing.Point(237, 67)
        AprovisionamientoDiasLabel.Name = "AprovisionamientoDiasLabel"
        AprovisionamientoDiasLabel.Size = New System.Drawing.Size(28, 13)
        AprovisionamientoDiasLabel.TabIndex = 50
        AprovisionamientoDiasLabel.Text = "días"
        '
        'TarifaEnActivoLabel
        '
        TarifaEnActivoLabel.AutoSize = True
        TarifaEnActivoLabel.Location = New System.Drawing.Point(10, 93)
        TarifaEnActivoLabel.Name = "TarifaEnActivoLabel"
        TarifaEnActivoLabel.Size = New System.Drawing.Size(86, 13)
        TarifaEnActivoLabel.TabIndex = 52
        TarifaEnActivoLabel.Text = "Tarifa En Activo:"
        TarifaEnActivoLabel.Visible = False
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(30, 18)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 68
        ObservacionesLabel.Text = "Observaciones:"
        '
        'ID_FormaPagoLabel
        '
        ID_FormaPagoLabel.AutoSize = True
        ID_FormaPagoLabel.Location = New System.Drawing.Point(29, 14)
        ID_FormaPagoLabel.Name = "ID_FormaPagoLabel"
        ID_FormaPagoLabel.Size = New System.Drawing.Size(67, 13)
        ID_FormaPagoLabel.TabIndex = 54
        ID_FormaPagoLabel.Text = "Forma Pago:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(20, 41)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(76, 13)
        Label2.TabIndex = 54
        Label2.Text = "Días de Pago:"
        '
        'DescuentoFijo1Label
        '
        DescuentoFijo1Label.AutoSize = True
        DescuentoFijo1Label.Location = New System.Drawing.Point(10, 119)
        DescuentoFijo1Label.Name = "DescuentoFijo1Label"
        DescuentoFijo1Label.Size = New System.Drawing.Size(91, 13)
        DescuentoFijo1Label.TabIndex = 55
        DescuentoFijo1Label.Text = "Descuentos Fijos:"
        '
        'PorcentajeRetensionLabel
        '
        PorcentajeRetensionLabel.AutoSize = True
        PorcentajeRetensionLabel.Location = New System.Drawing.Point(286, 119)
        PorcentajeRetensionLabel.Name = "PorcentajeRetensionLabel"
        PorcentajeRetensionLabel.Size = New System.Drawing.Size(70, 13)
        PorcentajeRetensionLabel.TabIndex = 61
        PorcentajeRetensionLabel.Text = "% Retención:"
        '
        'CCCLabel
        '
        CCCLabel.AutoSize = True
        CCCLabel.Location = New System.Drawing.Point(271, 180)
        CCCLabel.Name = "CCCLabel"
        CCCLabel.Size = New System.Drawing.Size(31, 13)
        CCCLabel.TabIndex = 26
        CCCLabel.Text = "CCC:"
        '
        'ID_BancoLabel
        '
        ID_BancoLabel.AutoSize = True
        ID_BancoLabel.Location = New System.Drawing.Point(44, 180)
        ID_BancoLabel.Name = "ID_BancoLabel"
        ID_BancoLabel.Size = New System.Drawing.Size(41, 13)
        ID_BancoLabel.TabIndex = 24
        ID_BancoLabel.Text = "Banco:"
        '
        'MovilLabel
        '
        MovilLabel.AutoSize = True
        MovilLabel.Location = New System.Drawing.Point(45, 144)
        MovilLabel.Name = "MovilLabel"
        MovilLabel.Size = New System.Drawing.Size(35, 13)
        MovilLabel.TabIndex = 22
        MovilLabel.Text = "Movil:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(263, 109)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 20
        FaxLabel.Text = "Fax:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(43, 113)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 18
        TelefonoLabel.Text = "Telefono:"
        '
        'DomicilioLabel
        '
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Location = New System.Drawing.Point(43, 48)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(52, 13)
        DomicilioLabel.TabIndex = 14
        DomicilioLabel.Text = "Domicilio:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(263, 148)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 80
        EmailLabel.Text = "Email:"
        '
        'FechaAltaLabel
        '
        FechaAltaLabel.AutoSize = True
        FechaAltaLabel.Location = New System.Drawing.Point(35, 27)
        FechaAltaLabel.Name = "FechaAltaLabel"
        FechaAltaLabel.Size = New System.Drawing.Size(61, 13)
        FechaAltaLabel.TabIndex = 74
        FechaAltaLabel.Text = "Fecha Alta:"
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.Location = New System.Drawing.Point(63, 56)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(33, 13)
        WebLabel.TabIndex = 76
        WebLabel.Text = "Web:"
        '
        'HorarioLabel
        '
        HorarioLabel.AutoSize = True
        HorarioLabel.Location = New System.Drawing.Point(20, 24)
        HorarioLabel.Name = "HorarioLabel"
        HorarioLabel.Size = New System.Drawing.Size(44, 13)
        HorarioLabel.TabIndex = 78
        HorarioLabel.Text = "Horario:"
        '
        'VacacionesDesdeLabel
        '
        VacacionesDesdeLabel.AutoSize = True
        VacacionesDesdeLabel.Location = New System.Drawing.Point(12, 51)
        VacacionesDesdeLabel.Name = "VacacionesDesdeLabel"
        VacacionesDesdeLabel.Size = New System.Drawing.Size(63, 13)
        VacacionesDesdeLabel.TabIndex = 80
        VacacionesDesdeLabel.Text = "Vacaciones"
        '
        'NoVenderArticulosLabel
        '
        NoVenderArticulosLabel.AutoSize = True
        NoVenderArticulosLabel.Location = New System.Drawing.Point(27, 16)
        NoVenderArticulosLabel.Name = "NoVenderArticulosLabel"
        NoVenderArticulosLabel.Size = New System.Drawing.Size(104, 13)
        NoVenderArticulosLabel.TabIndex = 84
        NoVenderArticulosLabel.Text = "No Vender Articulos:"
        '
        'NoRealizarPagosLabel
        '
        NoRealizarPagosLabel.AutoSize = True
        NoRealizarPagosLabel.Location = New System.Drawing.Point(33, 46)
        NoRealizarPagosLabel.Name = "NoRealizarPagosLabel"
        NoRealizarPagosLabel.Size = New System.Drawing.Size(98, 13)
        NoRealizarPagosLabel.TabIndex = 86
        NoRealizarPagosLabel.Text = "No Realizar Pagos:"
        '
        'NoImprimirLabel
        '
        NoImprimirLabel.AutoSize = True
        NoImprimirLabel.Location = New System.Drawing.Point(69, 76)
        NoImprimirLabel.Name = "NoImprimirLabel"
        NoImprimirLabel.Size = New System.Drawing.Size(62, 13)
        NoImprimirLabel.TabIndex = 88
        NoImprimirLabel.Text = "No Imprimir:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(37, 70)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(23, 13)
        Label3.TabIndex = 80
        Label3.Text = "Del"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(140, 70)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(33, 13)
        Label4.TabIndex = 80
        Label4.Text = "hasta"
        '
        'CodClienteLabel
        '
        CodClienteLabel.AutoSize = True
        CodClienteLabel.Location = New System.Drawing.Point(18, 145)
        CodClienteLabel.Name = "CodClienteLabel"
        CodClienteLabel.Size = New System.Drawing.Size(78, 13)
        CodClienteLabel.TabIndex = 63
        CodClienteLabel.Text = "Código Cliente:"
        CodClienteLabel.Visible = False
        '
        'RappelFijoLabel
        '
        RappelFijoLabel.AutoSize = True
        RappelFijoLabel.Location = New System.Drawing.Point(29, 25)
        RappelFijoLabel.Name = "RappelFijoLabel"
        RappelFijoLabel.Size = New System.Drawing.Size(63, 13)
        RappelFijoLabel.TabIndex = 66
        RappelFijoLabel.Text = "Rappel Fijo:"
        '
        'PagoRapelsLabel
        '
        PagoRapelsLabel.AutoSize = True
        PagoRapelsLabel.Location = New System.Drawing.Point(9, 49)
        PagoRapelsLabel.Name = "PagoRapelsLabel"
        PagoRapelsLabel.Size = New System.Drawing.Size(83, 13)
        PagoRapelsLabel.TabIndex = 68
        PagoRapelsLabel.Text = "Pago de Rapels"
        '
        'RELabel
        '
        RELabel.AutoSize = True
        RELabel.Location = New System.Drawing.Point(39, 113)
        RELabel.Name = "RELabel"
        RELabel.Size = New System.Drawing.Size(25, 13)
        RELabel.TabIndex = 4
        RELabel.Text = "RE:"
        '
        'lblObservaciones
        '
        lblObservaciones.AutoSize = True
        lblObservaciones.Location = New System.Drawing.Point(43, 212)
        lblObservaciones.Name = "lblObservaciones"
        lblObservaciones.Size = New System.Drawing.Size(81, 13)
        lblObservaciones.TabIndex = 83
        lblObservaciones.Text = "Observaciones:"
        '
        'grpMainDatos
        '
        Me.grpMainDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMainDatos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpMainDatos.Controls.Add(Me.grbDocumentos)
        Me.grpMainDatos.Controls.Add(NombreFiscalLabel)
        Me.grpMainDatos.Controls.Add(NIFLabel)
        Me.grpMainDatos.Controls.Add(Me.NombreFiscalTextBox)
        Me.grpMainDatos.Controls.Add(NombreComercialLabel)
        Me.grpMainDatos.Controls.Add(Me.GroupBox1)
        Me.grpMainDatos.Controls.Add(Me.NombreComercialTextBox)
        Me.grpMainDatos.Controls.Add(Me.NIFTextBox)
        Me.grpMainDatos.Controls.Add(CodigoLabel1)
        Me.grpMainDatos.Controls.Add(Me.CodigoTextBox1)
        Me.grpMainDatos.Location = New System.Drawing.Point(4, 1)
        Me.grpMainDatos.Name = "grpMainDatos"
        Me.grpMainDatos.Size = New System.Drawing.Size(657, 131)
        Me.grpMainDatos.TabIndex = 1
        Me.grpMainDatos.TabStop = False
        '
        'grbDocumentos
        '
        Me.grbDocumentos.Location = New System.Drawing.Point(502, 11)
        Me.grbDocumentos.Name = "grbDocumentos"
        Me.grbDocumentos.Size = New System.Drawing.Size(157, 114)
        Me.grbDocumentos.TabIndex = 23
        Me.grbDocumentos.TabStop = False
        Me.grbDocumentos.Text = "Documentos Adjuntos"
        Me.grbDocumentos.Visible = False
        '
        'NombreFiscalTextBox
        '
        Me.NombreFiscalTextBox.AcceptsReturn = True
        Me.NombreFiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "NombreFiscal", True))
        Me.NombreFiscalTextBox.Location = New System.Drawing.Point(121, 71)
        Me.NombreFiscalTextBox.Name = "NombreFiscalTextBox"
        Me.NombreFiscalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreFiscalTextBox.TabIndex = 11
        '
        'N_ProveedoresBindingSource
        '
        Me.N_ProveedoresBindingSource.DataMember = "N_Proveedores"
        Me.N_ProveedoresBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rb_Acreedor)
        Me.GroupBox1.Controls.Add(Me.rb_Proveedor)
        Me.GroupBox1.Controls.Add(Me.CodigoContabilidadTextBox)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(327, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 114)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contabilidad"
        Me.GroupBox1.Visible = False
        '
        'rb_Acreedor
        '
        Me.rb_Acreedor.AutoSize = True
        Me.rb_Acreedor.Location = New System.Drawing.Point(36, 68)
        Me.rb_Acreedor.Name = "rb_Acreedor"
        Me.rb_Acreedor.Size = New System.Drawing.Size(68, 17)
        Me.rb_Acreedor.TabIndex = 7
        Me.rb_Acreedor.Text = "Acreedor"
        Me.rb_Acreedor.UseVisualStyleBackColor = True
        '
        'rb_Proveedor
        '
        Me.rb_Proveedor.AutoSize = True
        Me.rb_Proveedor.Checked = True
        Me.rb_Proveedor.Location = New System.Drawing.Point(36, 45)
        Me.rb_Proveedor.Name = "rb_Proveedor"
        Me.rb_Proveedor.Size = New System.Drawing.Size(74, 17)
        Me.rb_Proveedor.TabIndex = 7
        Me.rb_Proveedor.TabStop = True
        Me.rb_Proveedor.Text = "Proveedor"
        Me.rb_Proveedor.UseVisualStyleBackColor = True
        '
        'CodigoContabilidadTextBox
        '
        Me.CodigoContabilidadTextBox.AcceptsReturn = True
        Me.CodigoContabilidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "CodigoContabilidad", True))
        Me.CodigoContabilidadTextBox.Location = New System.Drawing.Point(72, 19)
        Me.CodigoContabilidadTextBox.Name = "CodigoContabilidadTextBox"
        Me.CodigoContabilidadTextBox.Size = New System.Drawing.Size(72, 20)
        Me.CodigoContabilidadTextBox.TabIndex = 5
        '
        'NombreComercialTextBox
        '
        Me.NombreComercialTextBox.AcceptsReturn = True
        Me.NombreComercialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "NombreComercial", True))
        Me.NombreComercialTextBox.Location = New System.Drawing.Point(121, 97)
        Me.NombreComercialTextBox.Name = "NombreComercialTextBox"
        Me.NombreComercialTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreComercialTextBox.TabIndex = 13
        '
        'NIFTextBox
        '
        Me.NIFTextBox.AcceptsReturn = True
        Me.NIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "NIF", True))
        Me.NIFTextBox.Location = New System.Drawing.Point(121, 45)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.Size = New System.Drawing.Size(108, 20)
        Me.NIFTextBox.TabIndex = 9
        '
        'CodigoTextBox1
        '
        Me.CodigoTextBox1.AcceptsReturn = True
        Me.CodigoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "Codigo", True))
        Me.CodigoTextBox1.Location = New System.Drawing.Point(121, 19)
        Me.CodigoTextBox1.Name = "CodigoTextBox1"
        Me.CodigoTextBox1.Size = New System.Drawing.Size(108, 20)
        Me.CodigoTextBox1.TabIndex = 3
        '
        'tcDatos
        '
        Me.tcDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcDatos.Controls.Add(Me.tbFicha)
        Me.tcDatos.Controls.Add(Me.tbComercial)
        Me.tcDatos.Controls.Add(Me.tbOtrosDatos)
        Me.tcDatos.Controls.Add(Me.tbObservaciones)
        Me.tcDatos.Location = New System.Drawing.Point(4, 135)
        Me.tcDatos.Name = "tcDatos"
        Me.tcDatos.SelectedIndex = 0
        Me.tcDatos.Size = New System.Drawing.Size(657, 337)
        Me.tcDatos.TabIndex = 2
        '
        'tbFicha
        '
        Me.tbFicha.AutoScroll = True
        Me.tbFicha.Controls.Add(Me.CtrlPoblacion1)
        Me.tbFicha.Controls.Add(lblObservaciones)
        Me.tbFicha.Controls.Add(Me.ObservacionesTextBox)
        Me.tbFicha.Controls.Add(Me.N_BancosComboBox)
        Me.tbFicha.Controls.Add(EmailLabel)
        Me.tbFicha.Controls.Add(Me.EmailTextBox)
        Me.tbFicha.Controls.Add(DomicilioLabel)
        Me.tbFicha.Controls.Add(Me.DomicilioTextBox)
        Me.tbFicha.Controls.Add(TelefonoLabel)
        Me.tbFicha.Controls.Add(Me.TelefonoTextBox)
        Me.tbFicha.Controls.Add(FaxLabel)
        Me.tbFicha.Controls.Add(Me.FaxTextBox)
        Me.tbFicha.Controls.Add(MovilLabel)
        Me.tbFicha.Controls.Add(Me.MovilTextBox)
        Me.tbFicha.Controls.Add(ID_BancoLabel)
        Me.tbFicha.Controls.Add(CCCLabel)
        Me.tbFicha.Controls.Add(Me.CCCTextBox)
        Me.tbFicha.Location = New System.Drawing.Point(4, 22)
        Me.tbFicha.Name = "tbFicha"
        Me.tbFicha.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFicha.Size = New System.Drawing.Size(649, 311)
        Me.tbFicha.TabIndex = 0
        Me.tbFicha.Text = "Ficha"
        Me.tbFicha.UseVisualStyleBackColor = True
        '
        'CtrlPoblacion1
        '
        Me.CtrlPoblacion1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Poblacion", Me.N_ProveedoresBindingSource, "ID_Poblacion", True))
        Me.CtrlPoblacion1.ID_Poblacion = Nothing
        Me.CtrlPoblacion1.Location = New System.Drawing.Point(37, 11)
        Me.CtrlPoblacion1.Name = "CtrlPoblacion1"
        Me.CtrlPoblacion1.Size = New System.Drawing.Size(319, 28)
        Me.CtrlPoblacion1.TabIndex = 84
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.AcceptsReturn = True
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(46, 228)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(573, 74)
        Me.ObservacionesTextBox.TabIndex = 82
        '
        'N_BancosComboBox
        '
        Me.N_BancosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_ProveedoresBindingSource, "ID_Banco", True))
        Me.N_BancosComboBox.DataSource = Me.N_BancosBindingSource
        Me.N_BancosComboBox.DisplayMember = "NOMBRE"
        Me.N_BancosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.N_BancosComboBox.Location = New System.Drawing.Point(103, 177)
        Me.N_BancosComboBox.Name = "N_BancosComboBox"
        Me.N_BancosComboBox.Size = New System.Drawing.Size(162, 21)
        Me.N_BancosComboBox.TabIndex = 81
        Me.N_BancosComboBox.ValueMember = "ID_Banco"
        '
        'N_BancosBindingSource
        '
        Me.N_BancosBindingSource.DataMember = "BANCOS"
        Me.N_BancosBindingSource.DataSource = Me.CMDataSet
        '
        'EmailTextBox
        '
        Me.EmailTextBox.AcceptsReturn = True
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(304, 141)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(163, 20)
        Me.EmailTextBox.TabIndex = 81
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.AcceptsReturn = True
        Me.DomicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "Domicilio", True))
        Me.DomicilioTextBox.Location = New System.Drawing.Point(103, 45)
        Me.DomicilioTextBox.Multiline = True
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(364, 47)
        Me.DomicilioTextBox.TabIndex = 15
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.AcceptsReturn = True
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(103, 106)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(154, 20)
        Me.TelefonoTextBox.TabIndex = 19
        '
        'FaxTextBox
        '
        Me.FaxTextBox.AcceptsReturn = True
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(304, 106)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(163, 20)
        Me.FaxTextBox.TabIndex = 21
        '
        'MovilTextBox
        '
        Me.MovilTextBox.AcceptsReturn = True
        Me.MovilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "Movil", True))
        Me.MovilTextBox.Location = New System.Drawing.Point(103, 141)
        Me.MovilTextBox.Name = "MovilTextBox"
        Me.MovilTextBox.Size = New System.Drawing.Size(154, 20)
        Me.MovilTextBox.TabIndex = 23
        '
        'CCCTextBox
        '
        Me.CCCTextBox.AcceptsReturn = True
        Me.CCCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "CCC", True))
        Me.CCCTextBox.Location = New System.Drawing.Point(304, 178)
        Me.CCCTextBox.Name = "CCCTextBox"
        Me.CCCTextBox.Size = New System.Drawing.Size(163, 20)
        Me.CCCTextBox.TabIndex = 27
        '
        'tbComercial
        '
        Me.tbComercial.AutoScroll = True
        Me.tbComercial.Controls.Add(Me.grpIVA)
        Me.tbComercial.Controls.Add(Me.grpPorte)
        Me.tbComercial.Controls.Add(Me.GroupBox2)
        Me.tbComercial.Controls.Add(DescuentoFijo1Label)
        Me.tbComercial.Controls.Add(Me.DescuentoFijo1TextBox)
        Me.tbComercial.Controls.Add(Me.DescuentoFijo2TextBox)
        Me.tbComercial.Controls.Add(Me.DescuentoFijo3TextBox)
        Me.tbComercial.Controls.Add(PorcentajeRetensionLabel)
        Me.tbComercial.Controls.Add(Me.PorcentajeRetensionTextBox)
        Me.tbComercial.Controls.Add(CodClienteLabel)
        Me.tbComercial.Controls.Add(Me.CodClienteTextBox)
        Me.tbComercial.Controls.Add(Me.N_FormasPagoComboBox)
        Me.tbComercial.Controls.Add(Label2)
        Me.tbComercial.Controls.Add(ID_FormaPagoLabel)
        Me.tbComercial.Controls.Add(DiasPago1Label)
        Me.tbComercial.Controls.Add(Me.DiasPago1TextBox)
        Me.tbComercial.Controls.Add(Me.DiasPago2TextBox)
        Me.tbComercial.Controls.Add(Me.DiasPago3TextBox)
        Me.tbComercial.Controls.Add(AprovisionamientoMesesLabel)
        Me.tbComercial.Controls.Add(Me.AprovisionamientoMesesTextBox)
        Me.tbComercial.Controls.Add(AprovisionamientoDiasLabel)
        Me.tbComercial.Controls.Add(Me.AprovisionamientoDiasTextBox)
        Me.tbComercial.Controls.Add(TarifaEnActivoLabel)
        Me.tbComercial.Controls.Add(Me.TarifaEnActivoTextBox)
        Me.tbComercial.Location = New System.Drawing.Point(4, 22)
        Me.tbComercial.Name = "tbComercial"
        Me.tbComercial.Padding = New System.Windows.Forms.Padding(3)
        Me.tbComercial.Size = New System.Drawing.Size(649, 311)
        Me.tbComercial.TabIndex = 1
        Me.tbComercial.Text = "Comercial"
        Me.tbComercial.UseVisualStyleBackColor = True
        '
        'grpIVA
        '
        Me.grpIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpIVA.Controls.Add(RELabel)
        Me.grpIVA.Controls.Add(Me.RECheckBox)
        Me.grpIVA.Controls.Add(Me.rb_IVA_Importacion)
        Me.grpIVA.Controls.Add(Me.rb_IVA_Intracomunitarios)
        Me.grpIVA.Controls.Add(Me.rb_IVA_No)
        Me.grpIVA.Controls.Add(Me.rb_IVA_Si)
        Me.grpIVA.Location = New System.Drawing.Point(425, 6)
        Me.grpIVA.Name = "grpIVA"
        Me.grpIVA.Size = New System.Drawing.Size(138, 132)
        Me.grpIVA.TabIndex = 67
        Me.grpIVA.TabStop = False
        Me.grpIVA.Text = "IVA"
        '
        'RECheckBox
        '
        Me.RECheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_ProveedoresBindingSource, "RE", True))
        Me.RECheckBox.Location = New System.Drawing.Point(15, 108)
        Me.RECheckBox.Name = "RECheckBox"
        Me.RECheckBox.Size = New System.Drawing.Size(18, 24)
        Me.RECheckBox.TabIndex = 5
        '
        'rb_IVA_Importacion
        '
        Me.rb_IVA_Importacion.AutoSize = True
        Me.rb_IVA_Importacion.Location = New System.Drawing.Point(15, 84)
        Me.rb_IVA_Importacion.Name = "rb_IVA_Importacion"
        Me.rb_IVA_Importacion.Size = New System.Drawing.Size(80, 17)
        Me.rb_IVA_Importacion.TabIndex = 3
        Me.rb_IVA_Importacion.Text = "Importación"
        Me.rb_IVA_Importacion.UseVisualStyleBackColor = True
        '
        'rb_IVA_Intracomunitarios
        '
        Me.rb_IVA_Intracomunitarios.AutoSize = True
        Me.rb_IVA_Intracomunitarios.Location = New System.Drawing.Point(15, 61)
        Me.rb_IVA_Intracomunitarios.Name = "rb_IVA_Intracomunitarios"
        Me.rb_IVA_Intracomunitarios.Size = New System.Drawing.Size(105, 17)
        Me.rb_IVA_Intracomunitarios.TabIndex = 3
        Me.rb_IVA_Intracomunitarios.Text = "Intracomunitarios"
        Me.rb_IVA_Intracomunitarios.UseVisualStyleBackColor = True
        '
        'rb_IVA_No
        '
        Me.rb_IVA_No.AutoSize = True
        Me.rb_IVA_No.Location = New System.Drawing.Point(15, 38)
        Me.rb_IVA_No.Name = "rb_IVA_No"
        Me.rb_IVA_No.Size = New System.Drawing.Size(39, 17)
        Me.rb_IVA_No.TabIndex = 2
        Me.rb_IVA_No.Text = "No"
        Me.rb_IVA_No.UseVisualStyleBackColor = True
        '
        'rb_IVA_Si
        '
        Me.rb_IVA_Si.AutoSize = True
        Me.rb_IVA_Si.Checked = True
        Me.rb_IVA_Si.Location = New System.Drawing.Point(15, 15)
        Me.rb_IVA_Si.Name = "rb_IVA_Si"
        Me.rb_IVA_Si.Size = New System.Drawing.Size(34, 17)
        Me.rb_IVA_Si.TabIndex = 1
        Me.rb_IVA_Si.TabStop = True
        Me.rb_IVA_Si.Text = "Si"
        Me.rb_IVA_Si.UseVisualStyleBackColor = True
        '
        'grpPorte
        '
        Me.grpPorte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPorte.Controls.Add(Me.PorteTextBox)
        Me.grpPorte.Controls.Add(Me.rb_Pagados)
        Me.grpPorte.Controls.Add(Me.rb_Debidos)
        Me.grpPorte.Location = New System.Drawing.Point(272, 6)
        Me.grpPorte.Name = "grpPorte"
        Me.grpPorte.Size = New System.Drawing.Size(134, 104)
        Me.grpPorte.TabIndex = 66
        Me.grpPorte.TabStop = False
        Me.grpPorte.Text = "Porte"
        '
        'PorteTextBox
        '
        Me.PorteTextBox.AcceptsReturn = True
        Me.PorteTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PorteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "Porte", True))
        Me.PorteTextBox.Location = New System.Drawing.Point(19, 67)
        Me.PorteTextBox.Multiline = True
        Me.PorteTextBox.Name = "PorteTextBox"
        Me.PorteTextBox.Size = New System.Drawing.Size(106, 25)
        Me.PorteTextBox.TabIndex = 70
        '
        'rb_Pagados
        '
        Me.rb_Pagados.AutoSize = True
        Me.rb_Pagados.Location = New System.Drawing.Point(18, 42)
        Me.rb_Pagados.Name = "rb_Pagados"
        Me.rb_Pagados.Size = New System.Drawing.Size(67, 17)
        Me.rb_Pagados.TabIndex = 0
        Me.rb_Pagados.TabStop = True
        Me.rb_Pagados.Text = "Pagados"
        Me.rb_Pagados.UseVisualStyleBackColor = True
        '
        'rb_Debidos
        '
        Me.rb_Debidos.AutoSize = True
        Me.rb_Debidos.Location = New System.Drawing.Point(18, 19)
        Me.rb_Debidos.Name = "rb_Debidos"
        Me.rb_Debidos.Size = New System.Drawing.Size(64, 17)
        Me.rb_Debidos.TabIndex = 0
        Me.rb_Debidos.TabStop = True
        Me.rb_Debidos.Text = "Debidos"
        Me.rb_Debidos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRappels)
        Me.GroupBox2.Controls.Add(Me.N_EscalasRappels_ProveedorDataGridView)
        Me.GroupBox2.Controls.Add(Me.PagoRapelsTextBox)
        Me.GroupBox2.Controls.Add(PagoRapelsLabel)
        Me.GroupBox2.Controls.Add(Me.RappelFijoTextBox)
        Me.GroupBox2.Controls.Add(RappelFijoLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 115)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rappels"
        Me.GroupBox2.Visible = False
        '
        'btnRappels
        '
        Me.btnRappels.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRappels.Location = New System.Drawing.Point(191, 15)
        Me.btnRappels.Name = "btnRappels"
        Me.btnRappels.Size = New System.Drawing.Size(23, 23)
        Me.btnRappels.TabIndex = 70
        Me.btnRappels.Text = ">"
        Me.btnRappels.UseVisualStyleBackColor = True
        '
        'N_EscalasRappels_ProveedorDataGridView
        '
        Me.N_EscalasRappels_ProveedorDataGridView.AllowUserToAddRows = False
        Me.N_EscalasRappels_ProveedorDataGridView.AllowUserToDeleteRows = False
        Me.N_EscalasRappels_ProveedorDataGridView.AllowUserToOrderColumns = True
        Me.N_EscalasRappels_ProveedorDataGridView.AllowUserToResizeColumns = False
        Me.N_EscalasRappels_ProveedorDataGridView.AllowUserToResizeRows = False
        Me.N_EscalasRappels_ProveedorDataGridView.AutoGenerateColumns = False
        Me.N_EscalasRappels_ProveedorDataGridView.DataSource = Me.N_EscalasRappels_ProveedorBindingSource
        Me.N_EscalasRappels_ProveedorDataGridView.Location = New System.Drawing.Point(219, 13)
        Me.N_EscalasRappels_ProveedorDataGridView.MultiSelect = False
        Me.N_EscalasRappels_ProveedorDataGridView.Name = "N_EscalasRappels_ProveedorDataGridView"
        Me.N_EscalasRappels_ProveedorDataGridView.ReadOnly = True
        Me.N_EscalasRappels_ProveedorDataGridView.RowHeadersVisible = False
        Me.N_EscalasRappels_ProveedorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_EscalasRappels_ProveedorDataGridView.Size = New System.Drawing.Size(186, 95)
        Me.N_EscalasRappels_ProveedorDataGridView.TabIndex = 69
        '
        'N_EscalasRappels_ProveedorBindingSource
        '
        Me.N_EscalasRappels_ProveedorBindingSource.DataSource = Me.CMDataSet
        Me.N_EscalasRappels_ProveedorBindingSource.Position = 0
        '
        'PagoRapelsTextBox
        '
        Me.PagoRapelsTextBox.AcceptsReturn = True
        Me.PagoRapelsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "PagoRapels", True))
        Me.PagoRapelsTextBox.Location = New System.Drawing.Point(12, 65)
        Me.PagoRapelsTextBox.Multiline = True
        Me.PagoRapelsTextBox.Name = "PagoRapelsTextBox"
        Me.PagoRapelsTextBox.Size = New System.Drawing.Size(139, 36)
        Me.PagoRapelsTextBox.TabIndex = 69
        '
        'RappelFijoTextBox
        '
        Me.RappelFijoTextBox.AcceptsReturn = True
        Me.RappelFijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "RappelFijo", True))
        Me.RappelFijoTextBox.Location = New System.Drawing.Point(89, 22)
        Me.RappelFijoTextBox.Name = "RappelFijoTextBox"
        Me.RappelFijoTextBox.Size = New System.Drawing.Size(62, 20)
        Me.RappelFijoTextBox.TabIndex = 67
        Me.RappelFijoTextBox.Text = "0"
        '
        'DescuentoFijo1TextBox
        '
        Me.DescuentoFijo1TextBox.AcceptsReturn = True
        Me.DescuentoFijo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "DescuentoFijo1", True))
        Me.DescuentoFijo1TextBox.Location = New System.Drawing.Point(102, 116)
        Me.DescuentoFijo1TextBox.Name = "DescuentoFijo1TextBox"
        Me.DescuentoFijo1TextBox.Size = New System.Drawing.Size(55, 20)
        Me.DescuentoFijo1TextBox.TabIndex = 56
        Me.DescuentoFijo1TextBox.Text = "0"
        '
        'DescuentoFijo2TextBox
        '
        Me.DescuentoFijo2TextBox.AcceptsReturn = True
        Me.DescuentoFijo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "DescuentoFijo2", True))
        Me.DescuentoFijo2TextBox.Location = New System.Drawing.Point(163, 116)
        Me.DescuentoFijo2TextBox.Name = "DescuentoFijo2TextBox"
        Me.DescuentoFijo2TextBox.Size = New System.Drawing.Size(49, 20)
        Me.DescuentoFijo2TextBox.TabIndex = 58
        Me.DescuentoFijo2TextBox.Text = "0"
        '
        'DescuentoFijo3TextBox
        '
        Me.DescuentoFijo3TextBox.AcceptsReturn = True
        Me.DescuentoFijo3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "DescuentoFijo3", True))
        Me.DescuentoFijo3TextBox.Location = New System.Drawing.Point(218, 116)
        Me.DescuentoFijo3TextBox.Name = "DescuentoFijo3TextBox"
        Me.DescuentoFijo3TextBox.Size = New System.Drawing.Size(51, 20)
        Me.DescuentoFijo3TextBox.TabIndex = 60
        Me.DescuentoFijo3TextBox.Text = "0"
        '
        'PorcentajeRetensionTextBox
        '
        Me.PorcentajeRetensionTextBox.AcceptsReturn = True
        Me.PorcentajeRetensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "PorcentajeRetension", True))
        Me.PorcentajeRetensionTextBox.Location = New System.Drawing.Point(362, 116)
        Me.PorcentajeRetensionTextBox.Name = "PorcentajeRetensionTextBox"
        Me.PorcentajeRetensionTextBox.Size = New System.Drawing.Size(42, 20)
        Me.PorcentajeRetensionTextBox.TabIndex = 62
        Me.PorcentajeRetensionTextBox.Text = "0"
        '
        'CodClienteTextBox
        '
        Me.CodClienteTextBox.AcceptsReturn = True
        Me.CodClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "CodCliente", True))
        Me.CodClienteTextBox.Location = New System.Drawing.Point(102, 142)
        Me.CodClienteTextBox.Name = "CodClienteTextBox"
        Me.CodClienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CodClienteTextBox.TabIndex = 64
        Me.CodClienteTextBox.Visible = False
        '
        'N_FormasPagoComboBox
        '
        Me.N_FormasPagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_ProveedoresBindingSource, "ID_FormaPago", True))
        Me.N_FormasPagoComboBox.DataSource = Me.N_FormasPagoBindingSource
        Me.N_FormasPagoComboBox.DisplayMember = "Codigo"
        Me.N_FormasPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.N_FormasPagoComboBox.Location = New System.Drawing.Point(102, 11)
        Me.N_FormasPagoComboBox.Name = "N_FormasPagoComboBox"
        Me.N_FormasPagoComboBox.Size = New System.Drawing.Size(167, 21)
        Me.N_FormasPagoComboBox.TabIndex = 54
        Me.N_FormasPagoComboBox.ValueMember = "ID_FormaPago"
        '
        'N_FormasPagoBindingSource
        '
        Me.N_FormasPagoBindingSource.DataMember = "FORMASPAGO"
        Me.N_FormasPagoBindingSource.DataSource = Me.CMDataSet
        '
        'DiasPago1TextBox
        '
        Me.DiasPago1TextBox.AcceptsReturn = True
        Me.DiasPago1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "DiasPago1", True))
        Me.DiasPago1TextBox.Location = New System.Drawing.Point(102, 38)
        Me.DiasPago1TextBox.Name = "DiasPago1TextBox"
        Me.DiasPago1TextBox.Size = New System.Drawing.Size(26, 20)
        Me.DiasPago1TextBox.TabIndex = 43
        Me.DiasPago1TextBox.Text = "0"
        '
        'DiasPago2TextBox
        '
        Me.DiasPago2TextBox.AcceptsReturn = True
        Me.DiasPago2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "DiasPago2", True))
        Me.DiasPago2TextBox.Location = New System.Drawing.Point(134, 38)
        Me.DiasPago2TextBox.Name = "DiasPago2TextBox"
        Me.DiasPago2TextBox.Size = New System.Drawing.Size(26, 20)
        Me.DiasPago2TextBox.TabIndex = 45
        Me.DiasPago2TextBox.Text = "0"
        '
        'DiasPago3TextBox
        '
        Me.DiasPago3TextBox.AcceptsReturn = True
        Me.DiasPago3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "DiasPago3", True))
        Me.DiasPago3TextBox.Location = New System.Drawing.Point(165, 38)
        Me.DiasPago3TextBox.Name = "DiasPago3TextBox"
        Me.DiasPago3TextBox.Size = New System.Drawing.Size(26, 20)
        Me.DiasPago3TextBox.TabIndex = 47
        Me.DiasPago3TextBox.Text = "0"
        '
        'AprovisionamientoMesesTextBox
        '
        Me.AprovisionamientoMesesTextBox.AcceptsReturn = True
        Me.AprovisionamientoMesesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "AprovisionamientoMeses", True))
        Me.AprovisionamientoMesesTextBox.Location = New System.Drawing.Point(102, 64)
        Me.AprovisionamientoMesesTextBox.Name = "AprovisionamientoMesesTextBox"
        Me.AprovisionamientoMesesTextBox.Size = New System.Drawing.Size(31, 20)
        Me.AprovisionamientoMesesTextBox.TabIndex = 49
        Me.AprovisionamientoMesesTextBox.Text = "0"
        '
        'AprovisionamientoDiasTextBox
        '
        Me.AprovisionamientoDiasTextBox.AcceptsReturn = True
        Me.AprovisionamientoDiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "AprovisionamientoDias", True))
        Me.AprovisionamientoDiasTextBox.Location = New System.Drawing.Point(204, 64)
        Me.AprovisionamientoDiasTextBox.Name = "AprovisionamientoDiasTextBox"
        Me.AprovisionamientoDiasTextBox.Size = New System.Drawing.Size(31, 20)
        Me.AprovisionamientoDiasTextBox.TabIndex = 51
        Me.AprovisionamientoDiasTextBox.Text = "0"
        '
        'TarifaEnActivoTextBox
        '
        Me.TarifaEnActivoTextBox.AcceptsReturn = True
        Me.TarifaEnActivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "TarifaEnActivo", True))
        Me.TarifaEnActivoTextBox.Location = New System.Drawing.Point(102, 90)
        Me.TarifaEnActivoTextBox.Name = "TarifaEnActivoTextBox"
        Me.TarifaEnActivoTextBox.Size = New System.Drawing.Size(133, 20)
        Me.TarifaEnActivoTextBox.TabIndex = 53
        Me.TarifaEnActivoTextBox.Visible = False
        '
        'tbOtrosDatos
        '
        Me.tbOtrosDatos.Controls.Add(Me.grpHorario)
        Me.tbOtrosDatos.Controls.Add(Me.grpFiltros)
        Me.tbOtrosDatos.Controls.Add(FechaAltaLabel)
        Me.tbOtrosDatos.Controls.Add(Me.FechaAltaDateTimePicker)
        Me.tbOtrosDatos.Controls.Add(WebLabel)
        Me.tbOtrosDatos.Controls.Add(Me.WebTextBox)
        Me.tbOtrosDatos.Location = New System.Drawing.Point(4, 22)
        Me.tbOtrosDatos.Name = "tbOtrosDatos"
        Me.tbOtrosDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOtrosDatos.Size = New System.Drawing.Size(649, 311)
        Me.tbOtrosDatos.TabIndex = 2
        Me.tbOtrosDatos.Text = "Otros Datos"
        Me.tbOtrosDatos.UseVisualStyleBackColor = True
        '
        'grpHorario
        '
        Me.grpHorario.Controls.Add(Me.HorarioTextBox)
        Me.grpHorario.Controls.Add(HorarioLabel)
        Me.grpHorario.Controls.Add(Me.VacacionesDesdeTextBox)
        Me.grpHorario.Controls.Add(Label3)
        Me.grpHorario.Controls.Add(Label4)
        Me.grpHorario.Controls.Add(VacacionesDesdeLabel)
        Me.grpHorario.Controls.Add(Me.VacacionesHastaTextBox)
        Me.grpHorario.Location = New System.Drawing.Point(323, 23)
        Me.grpHorario.Name = "grpHorario"
        Me.grpHorario.Size = New System.Drawing.Size(233, 100)
        Me.grpHorario.TabIndex = 91
        Me.grpHorario.TabStop = False
        Me.grpHorario.Text = "Horario"
        '
        'HorarioTextBox
        '
        Me.HorarioTextBox.AcceptsReturn = True
        Me.HorarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "Horario", True))
        Me.HorarioTextBox.Location = New System.Drawing.Point(70, 21)
        Me.HorarioTextBox.Name = "HorarioTextBox"
        Me.HorarioTextBox.Size = New System.Drawing.Size(150, 20)
        Me.HorarioTextBox.TabIndex = 79
        '
        'VacacionesDesdeTextBox
        '
        Me.VacacionesDesdeTextBox.AcceptsReturn = True
        Me.VacacionesDesdeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "VacacionesDesde", True))
        Me.VacacionesDesdeTextBox.Location = New System.Drawing.Point(66, 67)
        Me.VacacionesDesdeTextBox.Name = "VacacionesDesdeTextBox"
        Me.VacacionesDesdeTextBox.Size = New System.Drawing.Size(49, 20)
        Me.VacacionesDesdeTextBox.TabIndex = 81
        Me.VacacionesDesdeTextBox.Text = "0"
        '
        'VacacionesHastaTextBox
        '
        Me.VacacionesHastaTextBox.AcceptsReturn = True
        Me.VacacionesHastaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "VacacionesHasta", True))
        Me.VacacionesHastaTextBox.Location = New System.Drawing.Point(179, 67)
        Me.VacacionesHastaTextBox.Name = "VacacionesHastaTextBox"
        Me.VacacionesHastaTextBox.Size = New System.Drawing.Size(41, 20)
        Me.VacacionesHastaTextBox.TabIndex = 83
        Me.VacacionesHastaTextBox.Text = "0"
        '
        'grpFiltros
        '
        Me.grpFiltros.Controls.Add(NoVenderArticulosLabel)
        Me.grpFiltros.Controls.Add(Me.NoImprimirCheckBox)
        Me.grpFiltros.Controls.Add(Me.NoVenderArticulosCheckBox)
        Me.grpFiltros.Controls.Add(NoImprimirLabel)
        Me.grpFiltros.Controls.Add(NoRealizarPagosLabel)
        Me.grpFiltros.Controls.Add(Me.NoRealizarPagosCheckBox)
        Me.grpFiltros.Location = New System.Drawing.Point(38, 90)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Size = New System.Drawing.Size(175, 100)
        Me.grpFiltros.TabIndex = 90
        Me.grpFiltros.TabStop = False
        Me.grpFiltros.Text = "Filtros"
        '
        'NoImprimirCheckBox
        '
        Me.NoImprimirCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_ProveedoresBindingSource, "NoImprimir", True))
        Me.NoImprimirCheckBox.Location = New System.Drawing.Point(137, 71)
        Me.NoImprimirCheckBox.Name = "NoImprimirCheckBox"
        Me.NoImprimirCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.NoImprimirCheckBox.TabIndex = 89
        '
        'NoVenderArticulosCheckBox
        '
        Me.NoVenderArticulosCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_ProveedoresBindingSource, "NoVenderArticulos", True))
        Me.NoVenderArticulosCheckBox.Location = New System.Drawing.Point(137, 11)
        Me.NoVenderArticulosCheckBox.Name = "NoVenderArticulosCheckBox"
        Me.NoVenderArticulosCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.NoVenderArticulosCheckBox.TabIndex = 85
        '
        'NoRealizarPagosCheckBox
        '
        Me.NoRealizarPagosCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_ProveedoresBindingSource, "NoRealizarPagos", True))
        Me.NoRealizarPagosCheckBox.Location = New System.Drawing.Point(137, 41)
        Me.NoRealizarPagosCheckBox.Name = "NoRealizarPagosCheckBox"
        Me.NoRealizarPagosCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.NoRealizarPagosCheckBox.TabIndex = 87
        '
        'FechaAltaDateTimePicker
        '
        Me.FechaAltaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_ProveedoresBindingSource, "FechaAlta", True))
        Me.FechaAltaDateTimePicker.Location = New System.Drawing.Point(102, 23)
        Me.FechaAltaDateTimePicker.Name = "FechaAltaDateTimePicker"
        Me.FechaAltaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaAltaDateTimePicker.TabIndex = 75
        '
        'WebTextBox
        '
        Me.WebTextBox.AcceptsReturn = True
        Me.WebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_ProveedoresBindingSource, "Web", True))
        Me.WebTextBox.Location = New System.Drawing.Point(102, 49)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WebTextBox.TabIndex = 77
        '
        'tbObservaciones
        '
        Me.tbObservaciones.Controls.Add(ObservacionesLabel)
        Me.tbObservaciones.Location = New System.Drawing.Point(4, 22)
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tbObservaciones.Size = New System.Drawing.Size(649, 311)
        Me.tbObservaciones.TabIndex = 3
        Me.tbObservaciones.Text = "Observaciones"
        Me.tbObservaciones.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Contacto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Contacto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreContacto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombreEmpresa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Empresa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cargo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Telefono1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Movil"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Movil"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fax"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fax"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(586, 474)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'N_ProveedoresTableAdapter
        '
        Me.N_ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'FormasPagoTableAdapter
        '
        Me.FormasPagoTableAdapter.ClearBeforeFill = True
        '
        'BancosTableAdapter
        '
        Me.BancosTableAdapter.ClearBeforeFill = True
        '
        'frmProveedor_Nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 501)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.tcDatos)
        Me.Controls.Add(Me.grpMainDatos)
        Me.Name = "frmProveedor_Nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Proveedor"
        Me.grpMainDatos.ResumeLayout(False)
        Me.grpMainDatos.PerformLayout()
        CType(Me.N_ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tcDatos.ResumeLayout(False)
        Me.tbFicha.ResumeLayout(False)
        Me.tbFicha.PerformLayout()
        CType(Me.N_BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbComercial.ResumeLayout(False)
        Me.tbComercial.PerformLayout()
        Me.grpIVA.ResumeLayout(False)
        Me.grpIVA.PerformLayout()
        Me.grpPorte.ResumeLayout(False)
        Me.grpPorte.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.N_EscalasRappels_ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_EscalasRappels_ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_FormasPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbOtrosDatos.ResumeLayout(False)
        Me.tbOtrosDatos.PerformLayout()
        Me.grpHorario.ResumeLayout(False)
        Me.grpHorario.PerformLayout()
        Me.grpFiltros.ResumeLayout(False)
        Me.grpFiltros.PerformLayout()
        Me.tbObservaciones.ResumeLayout(False)
        Me.tbObservaciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMainDatos As System.Windows.Forms.GroupBox
    Friend WithEvents tcDatos As System.Windows.Forms.TabControl
    Friend WithEvents tbComercial As System.Windows.Forms.TabPage
    Friend WithEvents tbOtrosDatos As System.Windows.Forms.TabPage
    Friend WithEvents tbObservaciones As System.Windows.Forms.TabPage
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_ProveedoresTableAdapter As CMDataSetTableAdapters.N_ProveedoresTableAdapter
    Friend WithEvents CodigoContabilidadTextBox As ctrlTextboxAvanzado
    Friend WithEvents CodigoTextBox1 As ctrlTextboxAvanzado
    Friend WithEvents NIFTextBox As ctrlTextboxAvanzado
    Friend WithEvents NombreFiscalTextBox As ctrlTextboxAvanzado
    Friend WithEvents NombreComercialTextBox As ctrlTextboxAvanzado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Acreedor As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Proveedor As System.Windows.Forms.RadioButton
    Friend WithEvents DiasPago1TextBox As ctrlTextboxAvanzado
    Friend WithEvents DiasPago2TextBox As ctrlTextboxAvanzado
    Friend WithEvents DiasPago3TextBox As ctrlTextboxAvanzado
    Friend WithEvents AprovisionamientoMesesTextBox As ctrlTextboxAvanzado
    Friend WithEvents AprovisionamientoDiasTextBox As ctrlTextboxAvanzado
    Friend WithEvents TarifaEnActivoTextBox As ctrlTextboxAvanzado
    Friend WithEvents N_FormasPagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FormasPagoTableAdapter As CMDataSetTableAdapters.FORMASPAGOTableAdapter
    Friend WithEvents N_FormasPagoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescuentoFijo1TextBox As ctrlTextboxAvanzado
    Friend WithEvents DescuentoFijo2TextBox As ctrlTextboxAvanzado
    Friend WithEvents DescuentoFijo3TextBox As ctrlTextboxAvanzado
    Friend WithEvents PorcentajeRetensionTextBox As ctrlTextboxAvanzado
    Friend WithEvents tbFicha As System.Windows.Forms.TabPage
    Friend WithEvents EmailTextBox As ctrlTextboxAvanzado
    Friend WithEvents DomicilioTextBox As ctrlTextboxAvanzado
    Friend WithEvents TelefonoTextBox As ctrlTextboxAvanzado
    Friend WithEvents FaxTextBox As ctrlTextboxAvanzado
    Friend WithEvents MovilTextBox As ctrlTextboxAvanzado
    Friend WithEvents CCCTextBox As ctrlTextboxAvanzado
    Friend WithEvents grpHorario As System.Windows.Forms.GroupBox
    Friend WithEvents grpFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents NoImprimirCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NoVenderArticulosCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NoRealizarPagosCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FechaAltaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents WebTextBox As ctrlTextboxAvanzado
    Friend WithEvents HorarioTextBox As ctrlTextboxAvanzado
    Friend WithEvents VacacionesDesdeTextBox As ctrlTextboxAvanzado
    Friend WithEvents VacacionesHastaTextBox As ctrlTextboxAvanzado
    Friend WithEvents N_BancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancosTableAdapter As CMDataSetTableAdapters.BANCOSTableAdapter
    Friend WithEvents N_BancosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents N_EscalasRappels_ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDEscalaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcientoRappelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents N_Contactos_ProveedorFULLBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents N_Contactos_ProveedorFULLTableAdapter As CMDataSetTableAdapters.N_Contactos_ProveedorFULLTableAdapter
    'Friend WithEvents N_Contactos_ProveedorFULLDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grbDocumentos As System.Windows.Forms.GroupBox
    Friend WithEvents grpIVA As System.Windows.Forms.GroupBox
    Friend WithEvents RECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents rb_IVA_Importacion As System.Windows.Forms.RadioButton
    Friend WithEvents rb_IVA_Intracomunitarios As System.Windows.Forms.RadioButton
    Friend WithEvents rb_IVA_No As System.Windows.Forms.RadioButton
    Friend WithEvents rb_IVA_Si As System.Windows.Forms.RadioButton
    Friend WithEvents grpPorte As System.Windows.Forms.GroupBox
    Friend WithEvents PorteTextBox As ctrlTextboxAvanzado
    Friend WithEvents rb_Pagados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Debidos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRappels As System.Windows.Forms.Button
    Friend WithEvents N_EscalasRappels_ProveedorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PagoRapelsTextBox As ctrlTextboxAvanzado
    Friend WithEvents RappelFijoTextBox As ctrlTextboxAvanzado
    Friend WithEvents CodClienteTextBox As ctrlTextboxAvanzado
    Friend WithEvents ObservacionesTextBox As ctrlTextboxAvanzado
    Friend WithEvents CtrlPoblacion1 As centro_medico.ctrlPoblacion
    'Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
    ' Friend WithEvents BANCOSTableAdapter As centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter
    'Friend WithEvents DocumentManager1 As DocumentManager
    'Friend WithEvents DocumentosBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents DocumentosProveedoresTableAdapter As CMDataSetTableAdapters.DocumentosProveedoresTableAdapter
End Class
