<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_mutuas
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
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim POBLACIONLabel As System.Windows.Forms.Label
        Dim PROVINCIALabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim TLFNO1Label As System.Windows.Forms.Label
        Dim TLFNO2Label As System.Windows.Forms.Label
        Dim FAXLabel As System.Windows.Forms.Label
        Dim MAILLabel As System.Windows.Forms.Label
        Dim WEBLabel As System.Windows.Forms.Label
        Dim PERSONACONLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim lb_codmutua As System.Windows.Forms.Label
        Dim CIFLabel As System.Windows.Forms.Label
        Dim ESPECIALIDADLabel As System.Windows.Forms.Label
        Dim NoContratoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.tab_mutuas = New System.Windows.Forms.TabControl()
        Me.tab_mutua_datos = New System.Windows.Forms.TabPage()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.txtLogo = New ctrlTextboxAvanzado()
        Me.NoContratoTextBox = New ctrlTextboxAvanzado()
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.CtrlTarifa1 = New centro_medico.ctrlTarifa()
        Me.bt_fichero = New System.Windows.Forms.Button()
        Me.tb_fichero = New ctrlTextboxAvanzado()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nombre = New ctrlTextboxAvanzado()
        Me.tb_direccion = New ctrlTextboxAvanzado()
        Me.tb_poblacion = New ctrlTextboxAvanzado()
        Me.tb_provincia = New ctrlTextboxAvanzado()
        Me.tb_cp = New ctrlTextboxAvanzado()
        Me.tb_tel1 = New ctrlTextboxAvanzado()
        Me.tb_tel2 = New ctrlTextboxAvanzado()
        Me.tb_fax = New ctrlTextboxAvanzado()
        Me.tb_mail = New ctrlTextboxAvanzado()
        Me.tb_web = New ctrlTextboxAvanzado()
        Me.tb_contacto = New ctrlTextboxAvanzado()
        Me.tb_notas = New ctrlTextboxAvanzado()
        Me.tb_codmutua = New ctrlTextboxAvanzado()
        Me.tb_CIF = New ctrlTextboxAvanzado()
        Me.tb_especialidad = New ctrlTextboxAvanzado()
        Me.lb_datos = New System.Windows.Forms.Label()
        Me.tab_mutua_paciente = New System.Windows.Forms.TabPage()
        Me.dgv_pacientes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tab_mutua_facturas = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_fin = New System.Windows.Forms.DateTimePicker()
        Me.dtp_inicial = New System.Windows.Forms.DateTimePicker()
        Me.rb_fcobro = New System.Windows.Forms.RadioButton()
        Me.rb_femision = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_facturas = New System.Windows.Forms.DataGridView()
        Me.tab_mutua_empresas = New System.Windows.Forms.TabPage()
        Me.dgv_empresa = New System.Windows.Forms.DataGridView()
        Me.tab_mutua_ficheros = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.tb_ficherotab = New ctrlTextboxAvanzado()
        Me.bt_open = New System.Windows.Forms.Button()
        Me.bt_view = New System.Windows.Forms.Button()
        Me.bt_borrarfichero = New System.Windows.Forms.Button()
        Me.bt_modificarfichero = New System.Windows.Forms.Button()
        Me.bt_nuevofichero = New System.Windows.Forms.Button()
        Me.dgv_ficheros = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter()
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter()
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter()
        Me.FICHEROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FICHEROSTableAdapter = New centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter()
        Me.openLogoBox = New System.Windows.Forms.OpenFileDialog()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        NOMBRELabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        POBLACIONLabel = New System.Windows.Forms.Label()
        PROVINCIALabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        TLFNO1Label = New System.Windows.Forms.Label()
        TLFNO2Label = New System.Windows.Forms.Label()
        FAXLabel = New System.Windows.Forms.Label()
        MAILLabel = New System.Windows.Forms.Label()
        WEBLabel = New System.Windows.Forms.Label()
        PERSONACONLabel = New System.Windows.Forms.Label()
        NOTASLabel = New System.Windows.Forms.Label()
        lb_codmutua = New System.Windows.Forms.Label()
        CIFLabel = New System.Windows.Forms.Label()
        ESPECIALIDADLabel = New System.Windows.Forms.Label()
        NoContratoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.tab_mutuas.SuspendLayout()
        Me.tab_mutua_datos.SuspendLayout()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_mutua_paciente.SuspendLayout()
        CType(Me.dgv_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_mutua_facturas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_mutua_empresas.SuspendLayout()
        CType(Me.dgv_empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_mutua_ficheros.SuspendLayout()
        CType(Me.dgv_ficheros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FICHEROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(142, 45)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(47, 13)
        NOMBRELabel.TabIndex = 29
        NOMBRELabel.Text = "Nombre:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(12, 100)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(55, 13)
        DIRECCIONLabel.TabIndex = 31
        DIRECCIONLabel.Text = "Dirección:"
        '
        'POBLACIONLabel
        '
        POBLACIONLabel.AutoSize = True
        POBLACIONLabel.Location = New System.Drawing.Point(430, 100)
        POBLACIONLabel.Name = "POBLACIONLabel"
        POBLACIONLabel.Size = New System.Drawing.Size(57, 13)
        POBLACIONLabel.TabIndex = 33
        POBLACIONLabel.Text = "Población:"
        '
        'PROVINCIALabel
        '
        PROVINCIALabel.AutoSize = True
        PROVINCIALabel.Location = New System.Drawing.Point(648, 100)
        PROVINCIALabel.Name = "PROVINCIALabel"
        PROVINCIALabel.Size = New System.Drawing.Size(54, 13)
        PROVINCIALabel.TabIndex = 35
        PROVINCIALabel.Text = "Provincia:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(307, 100)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 37
        CPLabel.Text = "CP:"
        '
        'TLFNO1Label
        '
        TLFNO1Label.AutoSize = True
        TLFNO1Label.Location = New System.Drawing.Point(16, 149)
        TLFNO1Label.Name = "TLFNO1Label"
        TLFNO1Label.Size = New System.Drawing.Size(40, 13)
        TLFNO1Label.TabIndex = 39
        TLFNO1Label.Text = "Tlfno1:"
        '
        'TLFNO2Label
        '
        TLFNO2Label.AutoSize = True
        TLFNO2Label.Location = New System.Drawing.Point(142, 149)
        TLFNO2Label.Name = "TLFNO2Label"
        TLFNO2Label.Size = New System.Drawing.Size(40, 13)
        TLFNO2Label.TabIndex = 41
        TLFNO2Label.Text = "Tlfno2:"
        '
        'FAXLabel
        '
        FAXLabel.AutoSize = True
        FAXLabel.Location = New System.Drawing.Point(272, 149)
        FAXLabel.Name = "FAXLabel"
        FAXLabel.Size = New System.Drawing.Size(27, 13)
        FAXLabel.TabIndex = 43
        FAXLabel.Text = "Fax:"
        '
        'MAILLabel
        '
        MAILLabel.AutoSize = True
        MAILLabel.Location = New System.Drawing.Point(440, 149)
        MAILLabel.Name = "MAILLabel"
        MAILLabel.Size = New System.Drawing.Size(39, 13)
        MAILLabel.TabIndex = 45
        MAILLabel.Text = "E-Mail:"
        '
        'WEBLabel
        '
        WEBLabel.AutoSize = True
        WEBLabel.Location = New System.Drawing.Point(16, 200)
        WEBLabel.Name = "WEBLabel"
        WEBLabel.Size = New System.Drawing.Size(66, 13)
        WEBLabel.TabIndex = 47
        WEBLabel.Text = "Página Web"
        '
        'PERSONACONLabel
        '
        PERSONACONLabel.AutoSize = True
        PERSONACONLabel.Location = New System.Drawing.Point(648, 149)
        PERSONACONLabel.Name = "PERSONACONLabel"
        PERSONACONLabel.Size = New System.Drawing.Size(109, 13)
        PERSONACONLabel.TabIndex = 49
        PERSONACONLabel.Text = "Persona de contacto "
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(261, 313)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 51
        NOTASLabel.Text = "Notas:"
        '
        'lb_codmutua
        '
        lb_codmutua.AutoSize = True
        lb_codmutua.Location = New System.Drawing.Point(12, 45)
        lb_codmutua.Name = "lb_codmutua"
        lb_codmutua.Size = New System.Drawing.Size(43, 13)
        lb_codmutua.TabIndex = 53
        lb_codmutua.Text = "Código:"
        '
        'CIFLabel
        '
        CIFLabel.AutoSize = True
        CIFLabel.Location = New System.Drawing.Point(507, 45)
        CIFLabel.Name = "CIFLabel"
        CIFLabel.Size = New System.Drawing.Size(26, 13)
        CIFLabel.TabIndex = 55
        CIFLabel.Text = "CIF:"
        '
        'ESPECIALIDADLabel
        '
        ESPECIALIDADLabel.AutoSize = True
        ESPECIALIDADLabel.Location = New System.Drawing.Point(261, 252)
        ESPECIALIDADLabel.Name = "ESPECIALIDADLabel"
        ESPECIALIDADLabel.Size = New System.Drawing.Size(70, 13)
        ESPECIALIDADLabel.TabIndex = 57
        ESPECIALIDADLabel.Text = "Especialidad:"
        '
        'NoContratoLabel
        '
        NoContratoLabel.AutoSize = True
        NoContratoLabel.Location = New System.Drawing.Point(648, 45)
        NoContratoLabel.Name = "NoContratoLabel"
        NoContratoLabel.Size = New System.Drawing.Size(67, 13)
        NoContratoLabel.TabIndex = 60
        NoContratoLabel.Text = "No Contrato:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(16, 313)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(34, 13)
        Label3.TabIndex = 62
        Label3.Text = "Logo:"
        '
        'tab_mutuas
        '
        Me.tab_mutuas.Controls.Add(Me.tab_mutua_datos)
        Me.tab_mutuas.Controls.Add(Me.tab_mutua_paciente)
        Me.tab_mutuas.Controls.Add(Me.tab_mutua_facturas)
        Me.tab_mutuas.Controls.Add(Me.tab_mutua_empresas)
        Me.tab_mutuas.Controls.Add(Me.tab_mutua_ficheros)
        Me.tab_mutuas.Location = New System.Drawing.Point(1, 6)
        Me.tab_mutuas.Name = "tab_mutuas"
        Me.tab_mutuas.SelectedIndex = 0
        Me.tab_mutuas.Size = New System.Drawing.Size(855, 523)
        Me.tab_mutuas.TabIndex = 0
        '
        'tab_mutua_datos
        '
        Me.tab_mutua_datos.AutoScroll = True
        Me.tab_mutua_datos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tab_mutua_datos.Controls.Add(Me.ptbLogo)
        Me.tab_mutua_datos.Controls.Add(Me.btnLogo)
        Me.tab_mutua_datos.Controls.Add(Me.txtLogo)
        Me.tab_mutua_datos.Controls.Add(Label3)
        Me.tab_mutua_datos.Controls.Add(NoContratoLabel)
        Me.tab_mutua_datos.Controls.Add(Me.NoContratoTextBox)
        Me.tab_mutua_datos.Controls.Add(Me.CtrlTarifa1)
        Me.tab_mutua_datos.Controls.Add(Me.bt_fichero)
        Me.tab_mutua_datos.Controls.Add(Me.tb_fichero)
        Me.tab_mutua_datos.Controls.Add(Me.Label1)
        Me.tab_mutua_datos.Controls.Add(NOMBRELabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_nombre)
        Me.tab_mutua_datos.Controls.Add(DIRECCIONLabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_direccion)
        Me.tab_mutua_datos.Controls.Add(POBLACIONLabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_poblacion)
        Me.tab_mutua_datos.Controls.Add(PROVINCIALabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_provincia)
        Me.tab_mutua_datos.Controls.Add(CPLabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_cp)
        Me.tab_mutua_datos.Controls.Add(TLFNO1Label)
        Me.tab_mutua_datos.Controls.Add(Me.tb_tel1)
        Me.tab_mutua_datos.Controls.Add(TLFNO2Label)
        Me.tab_mutua_datos.Controls.Add(Me.tb_tel2)
        Me.tab_mutua_datos.Controls.Add(FAXLabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_fax)
        Me.tab_mutua_datos.Controls.Add(MAILLabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_mail)
        Me.tab_mutua_datos.Controls.Add(WEBLabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_web)
        Me.tab_mutua_datos.Controls.Add(PERSONACONLabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_contacto)
        Me.tab_mutua_datos.Controls.Add(NOTASLabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_notas)
        Me.tab_mutua_datos.Controls.Add(lb_codmutua)
        Me.tab_mutua_datos.Controls.Add(Me.tb_codmutua)
        Me.tab_mutua_datos.Controls.Add(CIFLabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_CIF)
        Me.tab_mutua_datos.Controls.Add(ESPECIALIDADLabel)
        Me.tab_mutua_datos.Controls.Add(Me.tb_especialidad)
        Me.tab_mutua_datos.Controls.Add(Me.lb_datos)
        Me.tab_mutua_datos.Location = New System.Drawing.Point(4, 22)
        Me.tab_mutua_datos.Name = "tab_mutua_datos"
        Me.tab_mutua_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_mutua_datos.Size = New System.Drawing.Size(847, 497)
        Me.tab_mutua_datos.TabIndex = 0
        Me.tab_mutua_datos.Text = "Datos Básicos"
        Me.tab_mutua_datos.UseVisualStyleBackColor = True
        '
        'btnLogo
        '
        Me.btnLogo.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogo.Location = New System.Drawing.Point(224, 327)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(33, 23)
        Me.btnLogo.TabIndex = 64
        Me.btnLogo.UseVisualStyleBackColor = True
        '
        'txtLogo
        '
        Me.txtLogo.BackColor = System.Drawing.Color.White
        Me.txtLogo.Location = New System.Drawing.Point(16, 329)
        Me.txtLogo.MaxLength = 30
        Me.txtLogo.Name = "txtLogo"
        Me.txtLogo.ReadOnly = True
        Me.txtLogo.Size = New System.Drawing.Size(209, 20)
        Me.txtLogo.TabIndex = 63
        '
        'NoContratoTextBox
        '
        Me.NoContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "NoContrato", True))
        Me.NoContratoTextBox.Location = New System.Drawing.Point(651, 61)
        Me.NoContratoTextBox.Name = "NoContratoTextBox"
        Me.NoContratoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NoContratoTextBox.TabIndex = 61
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
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CtrlTarifa1
        '
        Me.CtrlTarifa1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Tarifas", Me.MUTUASBindingSource, "IdTarifa", True))
        Me.CtrlTarifa1.ID_Tarifas = Nothing
        Me.CtrlTarifa1.Location = New System.Drawing.Point(510, 267)
        Me.CtrlTarifa1.Name = "CtrlTarifa1"
        Me.CtrlTarifa1.Size = New System.Drawing.Size(317, 22)
        Me.CtrlTarifa1.TabIndex = 60
        '
        'bt_fichero
        '
        Me.bt_fichero.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_fichero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_fichero.Location = New System.Drawing.Point(224, 266)
        Me.bt_fichero.Name = "bt_fichero"
        Me.bt_fichero.Size = New System.Drawing.Size(33, 23)
        Me.bt_fichero.TabIndex = 14
        Me.bt_fichero.UseVisualStyleBackColor = True
        '
        'tb_fichero
        '
        Me.tb_fichero.BackColor = System.Drawing.Color.White
        Me.tb_fichero.Location = New System.Drawing.Point(19, 268)
        Me.tb_fichero.MaxLength = 30
        Me.tb_fichero.Name = "tb_fichero"
        Me.tb_fichero.ReadOnly = True
        Me.tb_fichero.Size = New System.Drawing.Size(209, 20)
        Me.tb_fichero.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Fichero de parte de baja\alta"
        '
        'tb_nombre
        '
        Me.tb_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "NOMBRE", True))
        Me.tb_nombre.Location = New System.Drawing.Point(145, 61)
        Me.tb_nombre.MaxLength = 90
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(330, 20)
        Me.tb_nombre.TabIndex = 1
        '
        'tb_direccion
        '
        Me.tb_direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "DIRECCION", True))
        Me.tb_direccion.Location = New System.Drawing.Point(15, 116)
        Me.tb_direccion.MaxLength = 150
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(279, 20)
        Me.tb_direccion.TabIndex = 3
        '
        'tb_poblacion
        '
        Me.tb_poblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "POBLACION", True))
        Me.tb_poblacion.Location = New System.Drawing.Point(433, 116)
        Me.tb_poblacion.MaxLength = 20
        Me.tb_poblacion.Name = "tb_poblacion"
        Me.tb_poblacion.Size = New System.Drawing.Size(196, 20)
        Me.tb_poblacion.TabIndex = 5
        '
        'tb_provincia
        '
        Me.tb_provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "PROVINCIA", True))
        Me.tb_provincia.Location = New System.Drawing.Point(651, 116)
        Me.tb_provincia.MaxLength = 20
        Me.tb_provincia.Name = "tb_provincia"
        Me.tb_provincia.Size = New System.Drawing.Size(188, 20)
        Me.tb_provincia.TabIndex = 6
        '
        'tb_cp
        '
        Me.tb_cp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "CP", True))
        Me.tb_cp.Location = New System.Drawing.Point(310, 116)
        Me.tb_cp.MaxLength = 5
        Me.tb_cp.Name = "tb_cp"
        Me.tb_cp.Size = New System.Drawing.Size(100, 20)
        Me.tb_cp.TabIndex = 4
        '
        'tb_tel1
        '
        Me.tb_tel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "TLFNO1", True))
        Me.tb_tel1.Location = New System.Drawing.Point(15, 165)
        Me.tb_tel1.MaxLength = 10
        Me.tb_tel1.Name = "tb_tel1"
        Me.tb_tel1.Size = New System.Drawing.Size(100, 20)
        Me.tb_tel1.TabIndex = 7
        '
        'tb_tel2
        '
        Me.tb_tel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "TLFNO2", True))
        Me.tb_tel2.Location = New System.Drawing.Point(145, 165)
        Me.tb_tel2.MaxLength = 10
        Me.tb_tel2.Name = "tb_tel2"
        Me.tb_tel2.Size = New System.Drawing.Size(100, 20)
        Me.tb_tel2.TabIndex = 8
        '
        'tb_fax
        '
        Me.tb_fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "FAX", True))
        Me.tb_fax.Location = New System.Drawing.Point(275, 165)
        Me.tb_fax.MaxLength = 10
        Me.tb_fax.Name = "tb_fax"
        Me.tb_fax.Size = New System.Drawing.Size(150, 20)
        Me.tb_fax.TabIndex = 9
        '
        'tb_mail
        '
        Me.tb_mail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "MAIL", True))
        Me.tb_mail.Location = New System.Drawing.Point(443, 165)
        Me.tb_mail.MaxLength = 40
        Me.tb_mail.Name = "tb_mail"
        Me.tb_mail.Size = New System.Drawing.Size(186, 20)
        Me.tb_mail.TabIndex = 10
        '
        'tb_web
        '
        Me.tb_web.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "WEB", True))
        Me.tb_web.Location = New System.Drawing.Point(15, 216)
        Me.tb_web.MaxLength = 40
        Me.tb_web.Name = "tb_web"
        Me.tb_web.Size = New System.Drawing.Size(824, 20)
        Me.tb_web.TabIndex = 12
        '
        'tb_contacto
        '
        Me.tb_contacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "PERSONACON", True))
        Me.tb_contacto.Location = New System.Drawing.Point(651, 165)
        Me.tb_contacto.MaxLength = 40
        Me.tb_contacto.Name = "tb_contacto"
        Me.tb_contacto.Size = New System.Drawing.Size(188, 20)
        Me.tb_contacto.TabIndex = 11
        '
        'tb_notas
        '
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(264, 329)
        Me.tb_notas.MaxLength = 8000
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.Size = New System.Drawing.Size(575, 148)
        Me.tb_notas.TabIndex = 16
        '
        'tb_codmutua
        '
        Me.tb_codmutua.BackColor = System.Drawing.Color.White
        Me.tb_codmutua.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "CMUTUA", True))
        Me.tb_codmutua.Location = New System.Drawing.Point(15, 61)
        Me.tb_codmutua.Name = "tb_codmutua"
        Me.tb_codmutua.Size = New System.Drawing.Size(100, 20)
        Me.tb_codmutua.TabIndex = 0
        '
        'tb_CIF
        '
        Me.tb_CIF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "CIF", True))
        Me.tb_CIF.Location = New System.Drawing.Point(505, 61)
        Me.tb_CIF.MaxLength = 10
        Me.tb_CIF.Name = "tb_CIF"
        Me.tb_CIF.Size = New System.Drawing.Size(116, 20)
        Me.tb_CIF.TabIndex = 2
        '
        'tb_especialidad
        '
        Me.tb_especialidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MUTUASBindingSource, "ESPECIALIDAD", True))
        Me.tb_especialidad.Location = New System.Drawing.Point(264, 268)
        Me.tb_especialidad.MaxLength = 50
        Me.tb_especialidad.Name = "tb_especialidad"
        Me.tb_especialidad.Size = New System.Drawing.Size(232, 20)
        Me.tb_especialidad.TabIndex = 15
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(3, 3)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(841, 19)
        Me.lb_datos.TabIndex = 29
        Me.lb_datos.Text = "Datos Básicos de la mutua"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_mutua_paciente
        '
        Me.tab_mutua_paciente.AutoScroll = True
        Me.tab_mutua_paciente.Controls.Add(Me.dgv_pacientes)
        Me.tab_mutua_paciente.Controls.Add(Me.Label2)
        Me.tab_mutua_paciente.Location = New System.Drawing.Point(4, 22)
        Me.tab_mutua_paciente.Name = "tab_mutua_paciente"
        Me.tab_mutua_paciente.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_mutua_paciente.Size = New System.Drawing.Size(847, 497)
        Me.tab_mutua_paciente.TabIndex = 1
        Me.tab_mutua_paciente.Text = "Pacientes de la Mutua"
        Me.tab_mutua_paciente.UseVisualStyleBackColor = True
        '
        'dgv_pacientes
        '
        Me.dgv_pacientes.AllowUserToAddRows = False
        Me.dgv_pacientes.AllowUserToDeleteRows = False
        Me.dgv_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_pacientes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_pacientes.Location = New System.Drawing.Point(3, 3)
        Me.dgv_pacientes.Name = "dgv_pacientes"
        Me.dgv_pacientes.ReadOnly = True
        Me.dgv_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pacientes.Size = New System.Drawing.Size(845, 474)
        Me.dgv_pacientes.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(848, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Pacientes asegurados por la mutua"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_mutua_facturas
        '
        Me.tab_mutua_facturas.Controls.Add(Me.GroupBox1)
        Me.tab_mutua_facturas.Controls.Add(Me.Label4)
        Me.tab_mutua_facturas.Controls.Add(Me.dgv_facturas)
        Me.tab_mutua_facturas.Location = New System.Drawing.Point(4, 22)
        Me.tab_mutua_facturas.Name = "tab_mutua_facturas"
        Me.tab_mutua_facturas.Size = New System.Drawing.Size(847, 497)
        Me.tab_mutua_facturas.TabIndex = 2
        Me.tab_mutua_facturas.Text = "Facturas de la Mutua"
        Me.tab_mutua_facturas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_filtrar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtp_fin)
        Me.GroupBox1.Controls.Add(Me.dtp_inicial)
        Me.GroupBox1.Controls.Add(Me.rb_fcobro)
        Me.GroupBox1.Controls.Add(Me.rb_femision)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(839, 82)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar facturas con"
        '
        'bt_filtrar
        '
        Me.bt_filtrar.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_filtrar.Location = New System.Drawing.Point(501, 28)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(35, 34)
        Me.bt_filtrar.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.bt_filtrar, "Filtrar")
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(358, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fecha final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha Inicial"
        '
        'dtp_fin
        '
        Me.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fin.Location = New System.Drawing.Point(361, 42)
        Me.dtp_fin.Name = "dtp_fin"
        Me.dtp_fin.Size = New System.Drawing.Size(104, 20)
        Me.dtp_fin.TabIndex = 5
        '
        'dtp_inicial
        '
        Me.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inicial.Location = New System.Drawing.Point(233, 42)
        Me.dtp_inicial.Name = "dtp_inicial"
        Me.dtp_inicial.Size = New System.Drawing.Size(109, 20)
        Me.dtp_inicial.TabIndex = 3
        '
        'rb_fcobro
        '
        Me.rb_fcobro.AutoSize = True
        Me.rb_fcobro.Location = New System.Drawing.Point(41, 42)
        Me.rb_fcobro.Name = "rb_fcobro"
        Me.rb_fcobro.Size = New System.Drawing.Size(101, 17)
        Me.rb_fcobro.TabIndex = 1
        Me.rb_fcobro.Text = "Fecha de Cobro"
        Me.rb_fcobro.UseVisualStyleBackColor = True
        '
        'rb_femision
        '
        Me.rb_femision.AutoSize = True
        Me.rb_femision.Checked = True
        Me.rb_femision.Location = New System.Drawing.Point(41, 19)
        Me.rb_femision.Name = "rb_femision"
        Me.rb_femision.Size = New System.Drawing.Size(109, 17)
        Me.rb_femision.TabIndex = 0
        Me.rb_femision.TabStop = True
        Me.rb_femision.Text = "Fecha de Emision"
        Me.rb_femision.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(846, 19)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Facturas emitidas a la mutua"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_facturas
        '
        Me.dgv_facturas.AllowUserToAddRows = False
        Me.dgv_facturas.AllowUserToDeleteRows = False
        Me.dgv_facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_facturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_facturas.BackgroundColor = System.Drawing.Color.White
        Me.dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas.Location = New System.Drawing.Point(0, 110)
        Me.dgv_facturas.Name = "dgv_facturas"
        Me.dgv_facturas.ReadOnly = True
        Me.dgv_facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_facturas.Size = New System.Drawing.Size(842, 384)
        Me.dgv_facturas.TabIndex = 0
        '
        'tab_mutua_empresas
        '
        Me.tab_mutua_empresas.Controls.Add(Me.dgv_empresa)
        Me.tab_mutua_empresas.Location = New System.Drawing.Point(4, 22)
        Me.tab_mutua_empresas.Name = "tab_mutua_empresas"
        Me.tab_mutua_empresas.Size = New System.Drawing.Size(847, 497)
        Me.tab_mutua_empresas.TabIndex = 3
        Me.tab_mutua_empresas.Text = "Empresas"
        Me.tab_mutua_empresas.UseVisualStyleBackColor = True
        '
        'dgv_empresa
        '
        Me.dgv_empresa.AllowUserToAddRows = False
        Me.dgv_empresa.AllowUserToDeleteRows = False
        Me.dgv_empresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_empresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_empresa.BackgroundColor = System.Drawing.Color.White
        Me.dgv_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_empresa.Location = New System.Drawing.Point(0, 0)
        Me.dgv_empresa.Name = "dgv_empresa"
        Me.dgv_empresa.ReadOnly = True
        Me.dgv_empresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_empresa.Size = New System.Drawing.Size(847, 497)
        Me.dgv_empresa.TabIndex = 0
        '
        'tab_mutua_ficheros
        '
        Me.tab_mutua_ficheros.Controls.Add(Me.WebBrowser1)
        Me.tab_mutua_ficheros.Controls.Add(Me.tb_ficherotab)
        Me.tab_mutua_ficheros.Controls.Add(Me.bt_open)
        Me.tab_mutua_ficheros.Controls.Add(Me.bt_view)
        Me.tab_mutua_ficheros.Controls.Add(Me.bt_borrarfichero)
        Me.tab_mutua_ficheros.Controls.Add(Me.bt_modificarfichero)
        Me.tab_mutua_ficheros.Controls.Add(Me.bt_nuevofichero)
        Me.tab_mutua_ficheros.Controls.Add(Me.dgv_ficheros)
        Me.tab_mutua_ficheros.Location = New System.Drawing.Point(4, 22)
        Me.tab_mutua_ficheros.Name = "tab_mutua_ficheros"
        Me.tab_mutua_ficheros.Size = New System.Drawing.Size(847, 497)
        Me.tab_mutua_ficheros.TabIndex = 4
        Me.tab_mutua_ficheros.Text = "Ficheros"
        Me.tab_mutua_ficheros.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(425, 4)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(422, 490)
        Me.WebBrowser1.TabIndex = 1
        '
        'tb_ficherotab
        '
        Me.tb_ficherotab.Location = New System.Drawing.Point(423, 3)
        Me.tb_ficherotab.Multiline = True
        Me.tb_ficherotab.Name = "tb_ficherotab"
        Me.tb_ficherotab.Size = New System.Drawing.Size(427, 491)
        Me.tb_ficherotab.TabIndex = 6
        '
        'bt_open
        '
        Me.bt_open.BackgroundImage = Global.centro_medico.My.Resources.Resources.NOTE16
        Me.bt_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_open.Location = New System.Drawing.Point(7, 450)
        Me.bt_open.Name = "bt_open"
        Me.bt_open.Size = New System.Drawing.Size(31, 23)
        Me.bt_open.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.bt_open, "Abrir fichero")
        Me.bt_open.UseVisualStyleBackColor = True
        '
        'bt_view
        '
        Me.bt_view.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_view.Location = New System.Drawing.Point(44, 450)
        Me.bt_view.Name = "bt_view"
        Me.bt_view.Size = New System.Drawing.Size(31, 23)
        Me.bt_view.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.bt_view, "Vista Previa")
        Me.bt_view.UseVisualStyleBackColor = True
        '
        'bt_borrarfichero
        '
        Me.bt_borrarfichero.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_borrarfichero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_borrarfichero.Location = New System.Drawing.Point(387, 450)
        Me.bt_borrarfichero.Name = "bt_borrarfichero"
        Me.bt_borrarfichero.Size = New System.Drawing.Size(31, 23)
        Me.bt_borrarfichero.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.bt_borrarfichero, "Borrar fichero")
        Me.bt_borrarfichero.UseVisualStyleBackColor = True
        '
        'bt_modificarfichero
        '
        Me.bt_modificarfichero.BackgroundImage = Global.centro_medico.My.Resources.Resources.up
        Me.bt_modificarfichero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_modificarfichero.Location = New System.Drawing.Point(350, 450)
        Me.bt_modificarfichero.Name = "bt_modificarfichero"
        Me.bt_modificarfichero.Size = New System.Drawing.Size(31, 23)
        Me.bt_modificarfichero.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.bt_modificarfichero, "Modificar fichero")
        Me.bt_modificarfichero.UseVisualStyleBackColor = True
        '
        'bt_nuevofichero
        '
        Me.bt_nuevofichero.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_nuevofichero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_nuevofichero.Location = New System.Drawing.Point(313, 450)
        Me.bt_nuevofichero.Name = "bt_nuevofichero"
        Me.bt_nuevofichero.Size = New System.Drawing.Size(31, 23)
        Me.bt_nuevofichero.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.bt_nuevofichero, "Agregar fichero")
        Me.bt_nuevofichero.UseVisualStyleBackColor = True
        '
        'dgv_ficheros
        '
        Me.dgv_ficheros.AllowUserToAddRows = False
        Me.dgv_ficheros.AllowUserToDeleteRows = False
        Me.dgv_ficheros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_ficheros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_ficheros.BackgroundColor = System.Drawing.Color.White
        Me.dgv_ficheros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ficheros.Location = New System.Drawing.Point(7, 3)
        Me.dgv_ficheros.MultiSelect = False
        Me.dgv_ficheros.Name = "dgv_ficheros"
        Me.dgv_ficheros.ReadOnly = True
        Me.dgv_ficheros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ficheros.Size = New System.Drawing.Size(411, 441)
        Me.dgv_ficheros.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Reportes de Mutuas|*.rdlc|Todos los ficheros|*.*"
        '
        'bt_cancel
        '
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(769, 535)
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
        Me.bt_aceptar.Location = New System.Drawing.Point(675, 535)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 3
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'MUTUASTableAdapter
        '
        Me.MUTUASTableAdapter.ClearBeforeFill = True
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
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
        'FACTURASBindingSource
        '
        Me.FACTURASBindingSource.DataMember = "FACTURAS"
        Me.FACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'FACTURASTableAdapter
        '
        Me.FACTURASTableAdapter.ClearBeforeFill = True
        '
        'FICHEROSBindingSource
        '
        Me.FICHEROSBindingSource.DataMember = "FICHEROS"
        Me.FICHEROSBindingSource.DataSource = Me.CMDataSet
        '
        'FICHEROSTableAdapter
        '
        Me.FICHEROSTableAdapter.ClearBeforeFill = True
        '
        'openLogoBox
        '
        Me.openLogoBox.FileName = "OpenFileDialog2"
        Me.openLogoBox.Filter = """PNG|*.PNG|GIF|*.GIF|BMP""|*.bmp|JPG|*.JPG|Todos|*.*"
        '
        'ptbLogo
        '
        Me.ptbLogo.Location = New System.Drawing.Point(19, 356)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(238, 121)
        Me.ptbLogo.TabIndex = 65
        Me.ptbLogo.TabStop = False
        '
        'form_mutuas
        '
        Me.AcceptButton = Me.bt_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancel
        Me.ClientSize = New System.Drawing.Size(856, 568)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.tab_mutuas)
        Me.Name = "form_mutuas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_mutuas"
        Me.tab_mutuas.ResumeLayout(False)
        Me.tab_mutua_datos.ResumeLayout(False)
        Me.tab_mutua_datos.PerformLayout()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mutua_paciente.ResumeLayout(False)
        CType(Me.dgv_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mutua_facturas.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mutua_empresas.ResumeLayout(False)
        CType(Me.dgv_empresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mutua_ficheros.ResumeLayout(False)
        Me.tab_mutua_ficheros.PerformLayout()
        CType(Me.dgv_ficheros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FICHEROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_mutuas As System.Windows.Forms.TabControl
    Friend WithEvents tab_mutua_datos As System.Windows.Forms.TabPage
    Friend WithEvents tab_mutua_paciente As System.Windows.Forms.TabPage
    Friend WithEvents tab_mutua_facturas As System.Windows.Forms.TabPage
    Friend WithEvents tab_mutua_empresas As System.Windows.Forms.TabPage
    Friend WithEvents tab_mutua_ficheros As System.Windows.Forms.TabPage
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents tb_nombre As ctrlTextboxAvanzado
    Friend WithEvents tb_direccion As ctrlTextboxAvanzado
    Friend WithEvents tb_poblacion As ctrlTextboxAvanzado
    Friend WithEvents tb_provincia As ctrlTextboxAvanzado
    Friend WithEvents tb_cp As ctrlTextboxAvanzado
    Friend WithEvents tb_tel1 As ctrlTextboxAvanzado
    Friend WithEvents tb_tel2 As ctrlTextboxAvanzado
    Friend WithEvents tb_fax As ctrlTextboxAvanzado
    Friend WithEvents tb_mail As ctrlTextboxAvanzado
    Friend WithEvents tb_web As ctrlTextboxAvanzado
    Friend WithEvents tb_contacto As ctrlTextboxAvanzado
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents tb_codmutua As ctrlTextboxAvanzado
    Friend WithEvents tb_CIF As ctrlTextboxAvanzado
    Friend WithEvents tb_especialidad As ctrlTextboxAvanzado
    Friend WithEvents bt_fichero As System.Windows.Forms.Button
    Friend WithEvents tb_fichero As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents dgv_pacientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents dgv_empresa As System.Windows.Forms.DataGridView
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents dgv_facturas As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents rb_fcobro As System.Windows.Forms.RadioButton
    Friend WithEvents rb_femision As System.Windows.Forms.RadioButton
    Friend WithEvents dgv_ficheros As System.Windows.Forms.DataGridView
    Friend WithEvents tb_ficherotab As ctrlTextboxAvanzado
    Friend WithEvents bt_open As System.Windows.Forms.Button
    Friend WithEvents bt_view As System.Windows.Forms.Button
    Friend WithEvents bt_borrarfichero As System.Windows.Forms.Button
    Friend WithEvents bt_modificarfichero As System.Windows.Forms.Button
    Friend WithEvents bt_nuevofichero As System.Windows.Forms.Button
    Friend WithEvents FICHEROSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FICHEROSTableAdapter As centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents CtrlTarifa1 As centro_medico.ctrlTarifa
    Friend WithEvents NoContratoTextBox As ctrlTextboxAvanzado
    Friend WithEvents btnLogo As System.Windows.Forms.Button
    Friend WithEvents txtLogo As ctrlTextboxAvanzado
    Friend WithEvents openLogoBox As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ptbLogo As System.Windows.Forms.PictureBox
End Class
