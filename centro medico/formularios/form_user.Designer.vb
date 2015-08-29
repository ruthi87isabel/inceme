<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_user
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
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim USUARIOLabel As System.Windows.Forms.Label
        Dim CONTRASENALabel As System.Windows.Forms.Label
        Dim NOMBRECOMPLETOLabel As System.Windows.Forms.Label
        Dim ADMINISTRADORLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.tb_cod = New centro_medico.ctrlTextboxAvanzado()
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.tb_user = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_contrasena = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_nombre = New centro_medico.ctrlTextboxAvanzado()
        Me.chb_admin = New System.Windows.Forms.CheckBox()
        Me.tb_rcontrasena = New centro_medico.ctrlTextboxAvanzado()
        Me.lb_medico = New System.Windows.Forms.Label()
        Me.bt_medico = New System.Windows.Forms.Button()
        Me.tb_idmedico = New centro_medico.ctrlTextboxAvanzado()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_clinica = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rb_bancosseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_bancostotal = New System.Windows.Forms.RadioButton()
        Me.rb_bancoslectura = New System.Windows.Forms.RadioButton()
        Me.rb_bancosninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rb_articuloseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_articulototal = New System.Windows.Forms.RadioButton()
        Me.rb_articulolectura = New System.Windows.Forms.RadioButton()
        Me.rb_articuloninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_proveedoresseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_proveedorestotal = New System.Windows.Forms.RadioButton()
        Me.rb_proveedoreslectura = New System.Windows.Forms.RadioButton()
        Me.rb_proveedoresninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_mutuasseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_mutuastotal = New System.Windows.Forms.RadioButton()
        Me.rb_mutuaslectura = New System.Windows.Forms.RadioButton()
        Me.rb_mutuasninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_medicosseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_medicostotal = New System.Windows.Forms.RadioButton()
        Me.rb_medicoslectura = New System.Windows.Forms.RadioButton()
        Me.rb_medicosninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_gastosseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_gastostotal = New System.Windows.Forms.RadioButton()
        Me.rb_gastoslectura = New System.Windows.Forms.RadioButton()
        Me.rb_gastosninguno = New System.Windows.Forms.RadioButton()
        Me.tab_pacientes = New System.Windows.Forms.TabPage()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.rb_revseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_revtotal = New System.Windows.Forms.RadioButton()
        Me.rb_revlectura = New System.Windows.Forms.RadioButton()
        Me.rb_revninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.rb_ficheroseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_ficherototal = New System.Windows.Forms.RadioButton()
        Me.rb_ficherolectura = New System.Windows.Forms.RadioButton()
        Me.rb_ficheroninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.rb_remseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_remtotal = New System.Windows.Forms.RadioButton()
        Me.rb_remlectura = New System.Windows.Forms.RadioButton()
        Me.rb_remninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.rb_genrecseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_genrectotal = New System.Windows.Forms.RadioButton()
        Me.rb_genreclectura = New System.Windows.Forms.RadioButton()
        Me.rb_genrecninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.rb_reciboseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_recibototal = New System.Windows.Forms.RadioButton()
        Me.rb_recibolectura = New System.Windows.Forms.RadioButton()
        Me.rb_reciboninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.rb_analseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_analtotal = New System.Windows.Forms.RadioButton()
        Me.rb_anallectura = New System.Windows.Forms.RadioButton()
        Me.rb_analninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.rb_infoseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_infototal = New System.Windows.Forms.RadioButton()
        Me.rb_infolectura = New System.Windows.Forms.RadioButton()
        Me.rb_infoninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rb_asistseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_asisttotal = New System.Windows.Forms.RadioButton()
        Me.rb_asistlectura = New System.Windows.Forms.RadioButton()
        Me.rb_asistninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rb_bajaseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_bajatotal = New System.Windows.Forms.RadioButton()
        Me.rb_bajalectura = New System.Windows.Forms.RadioButton()
        Me.rb_bajaninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.rb_histseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_histtotal = New System.Windows.Forms.RadioButton()
        Me.rb_histlectura = New System.Windows.Forms.RadioButton()
        Me.rb_histninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.rb_citaseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_citatotal = New System.Windows.Forms.RadioButton()
        Me.rb_citalectura = New System.Windows.Forms.RadioButton()
        Me.rb_citaninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.rb_recetaseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_recetatotal = New System.Windows.Forms.RadioButton()
        Me.rb_recetalectura = New System.Windows.Forms.RadioButton()
        Me.rb_recetaninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.rb_facturaseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_facturatotal = New System.Windows.Forms.RadioButton()
        Me.rb_facturalectura = New System.Windows.Forms.RadioButton()
        Me.rb_facturaninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.rb_empresaseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_empresatotal = New System.Windows.Forms.RadioButton()
        Me.rb_empresaslectura = New System.Windows.Forms.RadioButton()
        Me.rb_empresasninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.rb_pacientesseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_pacientestotal = New System.Windows.Forms.RadioButton()
        Me.rb_pacienteslectura = New System.Windows.Forms.RadioButton()
        Me.rb_pacientesninguno = New System.Windows.Forms.RadioButton()
        Me.tab_mantenimiento = New System.Windows.Forms.TabPage()
        Me.GroupBox28 = New System.Windows.Forms.GroupBox()
        Me.rb_clinicaseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_clinicatotal = New System.Windows.Forms.RadioButton()
        Me.rb_clinicalectura = New System.Windows.Forms.RadioButton()
        Me.rb_clinicaninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.rb_phistseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_phisttotal = New System.Windows.Forms.RadioButton()
        Me.rb_phistlectura = New System.Windows.Forms.RadioButton()
        Me.rb_phistninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.rb_modseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_modtotal = New System.Windows.Forms.RadioButton()
        Me.rb_modlectura = New System.Windows.Forms.RadioButton()
        Me.rb_modninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox31 = New System.Windows.Forms.GroupBox()
        Me.rb_panalseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_panaltotal = New System.Windows.Forms.RadioButton()
        Me.rb_panallectura = New System.Windows.Forms.RadioButton()
        Me.rb_panalninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox32 = New System.Windows.Forms.GroupBox()
        Me.rb_conceptseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_concepttotal = New System.Windows.Forms.RadioButton()
        Me.rb_conceptlectura = New System.Windows.Forms.RadioButton()
        Me.rb_conceptninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox33 = New System.Windows.Forms.GroupBox()
        Me.rb_ptextseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_ptexttotal = New System.Windows.Forms.RadioButton()
        Me.rb_ptextlectura = New System.Windows.Forms.RadioButton()
        Me.rb_ptextninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.rb_paisseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_paistotal = New System.Windows.Forms.RadioButton()
        Me.rb_paislectura = New System.Windows.Forms.RadioButton()
        Me.rb_paisninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.rb_fpseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_fptotal = New System.Windows.Forms.RadioButton()
        Me.rb_fplectura = New System.Windows.Forms.RadioButton()
        Me.rb_fpninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.rb_indseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_indtotal = New System.Windows.Forms.RadioButton()
        Me.rb_indlectura = New System.Windows.Forms.RadioButton()
        Me.rb_indninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.rb_medseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_medtotal = New System.Windows.Forms.RadioButton()
        Me.rb_medlectura = New System.Windows.Forms.RadioButton()
        Me.rb_medninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.rb_diagnosticoseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_diagnosticototal = New System.Windows.Forms.RadioButton()
        Me.rb_diagnosticolectura = New System.Windows.Forms.RadioButton()
        Me.rb_diagnosticoninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.rb_alarmaseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_alarmatotal = New System.Windows.Forms.RadioButton()
        Me.rb_alarmalectura = New System.Windows.Forms.RadioButton()
        Me.rb_alarmaninguno = New System.Windows.Forms.RadioButton()
        Me.tab_utilidades = New System.Windows.Forms.TabPage()
        Me.GroupBox36 = New System.Windows.Forms.GroupBox()
        Me.rb_etiqseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_etiqtotal = New System.Windows.Forms.RadioButton()
        Me.rb_etiqlectura = New System.Windows.Forms.RadioButton()
        Me.rb_etiqninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox37 = New System.Windows.Forms.GroupBox()
        Me.rb_afactseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_afacttotal = New System.Windows.Forms.RadioButton()
        Me.rb_afactlectura = New System.Windows.Forms.RadioButton()
        Me.rb_afactninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox38 = New System.Windows.Forms.GroupBox()
        Me.rb_copyseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_copytotal = New System.Windows.Forms.RadioButton()
        Me.rb_copylectura = New System.Windows.Forms.RadioButton()
        Me.rb_copyninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox39 = New System.Windows.Forms.GroupBox()
        Me.rb_confseleccionar = New System.Windows.Forms.RadioButton()
        Me.rb_conftotal = New System.Windows.Forms.RadioButton()
        Me.rb_conflectura = New System.Windows.Forms.RadioButton()
        Me.rb_confninguno = New System.Windows.Forms.RadioButton()
        Me.tab_listados = New System.Windows.Forms.TabPage()
        Me.GroupBox34 = New System.Windows.Forms.GroupBox()
        Me.rb_librototal = New System.Windows.Forms.RadioButton()
        Me.rb_librolectura = New System.Windows.Forms.RadioButton()
        Me.rb_libroninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox35 = New System.Windows.Forms.GroupBox()
        Me.rb_lcitalectura = New System.Windows.Forms.RadioButton()
        Me.rb_lcitasninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox40 = New System.Windows.Forms.GroupBox()
        Me.rb_lasistlectura = New System.Windows.Forms.RadioButton()
        Me.rb_lasistninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox41 = New System.Windows.Forms.GroupBox()
        Me.rb_lrecetalectura = New System.Windows.Forms.RadioButton()
        Me.rb_lrecetaninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox42 = New System.Windows.Forms.GroupBox()
        Me.rb_lpartelectura = New System.Windows.Forms.RadioButton()
        Me.rb_lpartesninguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox43 = New System.Windows.Forms.GroupBox()
        Me.rb_lfacturalectura = New System.Windows.Forms.RadioButton()
        Me.rb_lfacturaninguno = New System.Windows.Forms.RadioButton()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.USUARIOSTableAdapter = New centro_medico.CMDataSetTableAdapters.USUARIOSTableAdapter()
        Me.MEDICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter()
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERMISOS_USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERMISOS_USUARIOTableAdapter = New centro_medico.CMDataSetTableAdapters.PERMISOS_USUARIOTableAdapter()
        Me.PERMISOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERMISOSTableAdapter = New centro_medico.CMDataSetTableAdapters.PERMISOSTableAdapter()
        Me.tb_certificadoPath = New centro_medico.ctrlTextboxAvanzado()
        CODIGOLabel = New System.Windows.Forms.Label()
        USUARIOLabel = New System.Windows.Forms.Label()
        CONTRASENALabel = New System.Windows.Forms.Label()
        NOMBRECOMPLETOLabel = New System.Windows.Forms.Label()
        ADMINISTRADORLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_clinica.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tab_pacientes.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.tab_mantenimiento.SuspendLayout()
        Me.GroupBox28.SuspendLayout()
        Me.GroupBox29.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        Me.GroupBox31.SuspendLayout()
        Me.GroupBox32.SuspendLayout()
        Me.GroupBox33.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        Me.tab_utilidades.SuspendLayout()
        Me.GroupBox36.SuspendLayout()
        Me.GroupBox37.SuspendLayout()
        Me.GroupBox38.SuspendLayout()
        Me.GroupBox39.SuspendLayout()
        Me.tab_listados.SuspendLayout()
        Me.GroupBox34.SuspendLayout()
        Me.GroupBox35.SuspendLayout()
        Me.GroupBox40.SuspendLayout()
        Me.GroupBox41.SuspendLayout()
        Me.GroupBox42.SuspendLayout()
        Me.GroupBox43.SuspendLayout()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERMISOS_USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERMISOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(12, 43)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(43, 13)
        CODIGOLabel.TabIndex = 0
        CODIGOLabel.Text = "Codigo:"
        '
        'USUARIOLabel
        '
        USUARIOLabel.AutoSize = True
        USUARIOLabel.Location = New System.Drawing.Point(84, 43)
        USUARIOLabel.Name = "USUARIOLabel"
        USUARIOLabel.Size = New System.Drawing.Size(46, 13)
        USUARIOLabel.TabIndex = 2
        USUARIOLabel.Text = "Usuario:"
        '
        'CONTRASENALabel
        '
        CONTRASENALabel.AutoSize = True
        CONTRASENALabel.Location = New System.Drawing.Point(417, 43)
        CONTRASENALabel.Name = "CONTRASENALabel"
        CONTRASENALabel.Size = New System.Drawing.Size(64, 13)
        CONTRASENALabel.TabIndex = 4
        CONTRASENALabel.Text = "Contraseña:"
        '
        'NOMBRECOMPLETOLabel
        '
        NOMBRECOMPLETOLabel.AutoSize = True
        NOMBRECOMPLETOLabel.Location = New System.Drawing.Point(211, 43)
        NOMBRECOMPLETOLabel.Name = "NOMBRECOMPLETOLabel"
        NOMBRECOMPLETOLabel.Size = New System.Drawing.Size(94, 13)
        NOMBRECOMPLETOLabel.TabIndex = 10
        NOMBRECOMPLETOLabel.Text = "Nombre Completo:"
        '
        'ADMINISTRADORLabel
        '
        ADMINISTRADORLabel.AutoSize = True
        ADMINISTRADORLabel.Location = New System.Drawing.Point(421, 115)
        ADMINISTRADORLabel.Name = "ADMINISTRADORLabel"
        ADMINISTRADORLabel.Size = New System.Drawing.Size(73, 13)
        ADMINISTRADORLabel.TabIndex = 8
        ADMINISTRADORLabel.Text = "Administrador:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(563, 43)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(96, 13)
        Label1.TabIndex = 15
        Label1.Text = "Repitir contraseña:"
        '
        'tb_cod
        '
        Me.tb_cod.AcceptsReturn = True
        Me.tb_cod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "CODIGO", True))
        Me.tb_cod.Location = New System.Drawing.Point(12, 59)
        Me.tb_cod.Name = "tb_cod"
        Me.tb_cod.Size = New System.Drawing.Size(69, 20)
        Me.tb_cod.TabIndex = 0
        '
        'USUARIOSBindingSource
        '
        Me.USUARIOSBindingSource.DataMember = "USUARIOS"
        Me.USUARIOSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_user
        '
        Me.tb_user.AcceptsReturn = True
        Me.tb_user.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "USUARIO", True))
        Me.tb_user.Location = New System.Drawing.Point(87, 59)
        Me.tb_user.MaxLength = 15
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(121, 20)
        Me.tb_user.TabIndex = 1
        '
        'tb_contrasena
        '
        Me.tb_contrasena.AcceptsReturn = True
        Me.tb_contrasena.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "CONTRASENA", True))
        Me.tb_contrasena.Location = New System.Drawing.Point(420, 59)
        Me.tb_contrasena.MaxLength = 15
        Me.tb_contrasena.Name = "tb_contrasena"
        Me.tb_contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_contrasena.Size = New System.Drawing.Size(140, 20)
        Me.tb_contrasena.TabIndex = 3
        Me.tb_contrasena.UseSystemPasswordChar = True
        '
        'tb_nombre
        '
        Me.tb_nombre.AcceptsReturn = True
        Me.tb_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "NOMBRECOMPLETO", True))
        Me.tb_nombre.Location = New System.Drawing.Point(214, 59)
        Me.tb_nombre.MaxLength = 90
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(200, 20)
        Me.tb_nombre.TabIndex = 2
        '
        'chb_admin
        '
        Me.chb_admin.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.USUARIOSBindingSource, "ADMINISTRADOR", True))
        Me.chb_admin.Location = New System.Drawing.Point(500, 110)
        Me.chb_admin.Name = "chb_admin"
        Me.chb_admin.Size = New System.Drawing.Size(32, 24)
        Me.chb_admin.TabIndex = 9
        '
        'tb_rcontrasena
        '
        Me.tb_rcontrasena.AcceptsReturn = True
        Me.tb_rcontrasena.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "CONTRASENA", True))
        Me.tb_rcontrasena.Location = New System.Drawing.Point(566, 59)
        Me.tb_rcontrasena.MaxLength = 15
        Me.tb_rcontrasena.Name = "tb_rcontrasena"
        Me.tb_rcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_rcontrasena.Size = New System.Drawing.Size(151, 20)
        Me.tb_rcontrasena.TabIndex = 4
        Me.tb_rcontrasena.UseSystemPasswordChar = True
        '
        'lb_medico
        '
        Me.lb_medico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_medico.Location = New System.Drawing.Point(159, 113)
        Me.lb_medico.Name = "lb_medico"
        Me.lb_medico.Size = New System.Drawing.Size(255, 20)
        Me.lb_medico.TabIndex = 7
        '
        'bt_medico
        '
        Me.bt_medico.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_medico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_medico.Location = New System.Drawing.Point(102, 111)
        Me.bt_medico.Name = "bt_medico"
        Me.bt_medico.Size = New System.Drawing.Size(36, 23)
        Me.bt_medico.TabIndex = 6
        Me.bt_medico.UseVisualStyleBackColor = True
        '
        'tb_idmedico
        '
        Me.tb_idmedico.AcceptsReturn = True
        Me.tb_idmedico.BackColor = System.Drawing.Color.White
        Me.tb_idmedico.Location = New System.Drawing.Point(12, 113)
        Me.tb_idmedico.Name = "tb_idmedico"
        Me.tb_idmedico.Size = New System.Drawing.Size(91, 20)
        Me.tb_idmedico.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.GhostWhite
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(716, 19)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Datos del usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Cod. Medico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Medico"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_clinica)
        Me.TabControl1.Controls.Add(Me.tab_pacientes)
        Me.TabControl1.Controls.Add(Me.tab_mantenimiento)
        Me.TabControl1.Controls.Add(Me.tab_utilidades)
        Me.TabControl1.Controls.Add(Me.tab_listados)
        Me.TabControl1.Location = New System.Drawing.Point(12, 140)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(705, 377)
        Me.TabControl1.TabIndex = 10
        '
        'tab_clinica
        '
        Me.tab_clinica.Controls.Add(Me.GroupBox6)
        Me.tab_clinica.Controls.Add(Me.GroupBox5)
        Me.tab_clinica.Controls.Add(Me.GroupBox4)
        Me.tab_clinica.Controls.Add(Me.GroupBox3)
        Me.tab_clinica.Controls.Add(Me.GroupBox2)
        Me.tab_clinica.Controls.Add(Me.GroupBox1)
        Me.tab_clinica.Location = New System.Drawing.Point(4, 22)
        Me.tab_clinica.Name = "tab_clinica"
        Me.tab_clinica.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_clinica.Size = New System.Drawing.Size(697, 351)
        Me.tab_clinica.TabIndex = 0
        Me.tab_clinica.Text = "Clinicas"
        Me.tab_clinica.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rb_bancosseleccionar)
        Me.GroupBox6.Controls.Add(Me.rb_bancostotal)
        Me.GroupBox6.Controls.Add(Me.rb_bancoslectura)
        Me.GroupBox6.Controls.Add(Me.rb_bancosninguno)
        Me.GroupBox6.Location = New System.Drawing.Point(576, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Bancos"
        '
        'rb_bancosseleccionar
        '
        Me.rb_bancosseleccionar.AutoSize = True
        Me.rb_bancosseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_bancosseleccionar.Name = "rb_bancosseleccionar"
        Me.rb_bancosseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_bancosseleccionar.TabIndex = 3
        Me.rb_bancosseleccionar.Text = "Seleccionar"
        Me.rb_bancosseleccionar.UseVisualStyleBackColor = True
        '
        'rb_bancostotal
        '
        Me.rb_bancostotal.AutoSize = True
        Me.rb_bancostotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_bancostotal.Name = "rb_bancostotal"
        Me.rb_bancostotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_bancostotal.TabIndex = 2
        Me.rb_bancostotal.Text = "Total"
        Me.rb_bancostotal.UseVisualStyleBackColor = True
        '
        'rb_bancoslectura
        '
        Me.rb_bancoslectura.AutoSize = True
        Me.rb_bancoslectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_bancoslectura.Name = "rb_bancoslectura"
        Me.rb_bancoslectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_bancoslectura.TabIndex = 1
        Me.rb_bancoslectura.Text = "Lectura"
        Me.rb_bancoslectura.UseVisualStyleBackColor = True
        '
        'rb_bancosninguno
        '
        Me.rb_bancosninguno.AutoSize = True
        Me.rb_bancosninguno.Checked = True
        Me.rb_bancosninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_bancosninguno.Name = "rb_bancosninguno"
        Me.rb_bancosninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_bancosninguno.TabIndex = 0
        Me.rb_bancosninguno.TabStop = True
        Me.rb_bancosninguno.Text = "Ninguno"
        Me.rb_bancosninguno.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rb_articuloseleccionar)
        Me.GroupBox5.Controls.Add(Me.rb_articulototal)
        Me.GroupBox5.Controls.Add(Me.rb_articulolectura)
        Me.GroupBox5.Controls.Add(Me.rb_articuloninguno)
        Me.GroupBox5.Location = New System.Drawing.Point(462, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Articulos"
        '
        'rb_articuloseleccionar
        '
        Me.rb_articuloseleccionar.AutoSize = True
        Me.rb_articuloseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_articuloseleccionar.Name = "rb_articuloseleccionar"
        Me.rb_articuloseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_articuloseleccionar.TabIndex = 3
        Me.rb_articuloseleccionar.Text = "Seleccionar"
        Me.rb_articuloseleccionar.UseVisualStyleBackColor = True
        '
        'rb_articulototal
        '
        Me.rb_articulototal.AutoSize = True
        Me.rb_articulototal.Location = New System.Drawing.Point(6, 63)
        Me.rb_articulototal.Name = "rb_articulototal"
        Me.rb_articulototal.Size = New System.Drawing.Size(49, 17)
        Me.rb_articulototal.TabIndex = 2
        Me.rb_articulototal.Text = "Total"
        Me.rb_articulototal.UseVisualStyleBackColor = True
        '
        'rb_articulolectura
        '
        Me.rb_articulolectura.AutoSize = True
        Me.rb_articulolectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_articulolectura.Name = "rb_articulolectura"
        Me.rb_articulolectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_articulolectura.TabIndex = 1
        Me.rb_articulolectura.Text = "Lectura"
        Me.rb_articulolectura.UseVisualStyleBackColor = True
        '
        'rb_articuloninguno
        '
        Me.rb_articuloninguno.AutoSize = True
        Me.rb_articuloninguno.Checked = True
        Me.rb_articuloninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_articuloninguno.Name = "rb_articuloninguno"
        Me.rb_articuloninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_articuloninguno.TabIndex = 0
        Me.rb_articuloninguno.TabStop = True
        Me.rb_articuloninguno.Text = "Ninguno"
        Me.rb_articuloninguno.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb_proveedoresseleccionar)
        Me.GroupBox4.Controls.Add(Me.rb_proveedorestotal)
        Me.GroupBox4.Controls.Add(Me.rb_proveedoreslectura)
        Me.GroupBox4.Controls.Add(Me.rb_proveedoresninguno)
        Me.GroupBox4.Location = New System.Drawing.Point(348, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proveedores"
        '
        'rb_proveedoresseleccionar
        '
        Me.rb_proveedoresseleccionar.AutoSize = True
        Me.rb_proveedoresseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_proveedoresseleccionar.Name = "rb_proveedoresseleccionar"
        Me.rb_proveedoresseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_proveedoresseleccionar.TabIndex = 3
        Me.rb_proveedoresseleccionar.Text = "Seleccionar"
        Me.rb_proveedoresseleccionar.UseVisualStyleBackColor = True
        '
        'rb_proveedorestotal
        '
        Me.rb_proveedorestotal.AutoSize = True
        Me.rb_proveedorestotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_proveedorestotal.Name = "rb_proveedorestotal"
        Me.rb_proveedorestotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_proveedorestotal.TabIndex = 2
        Me.rb_proveedorestotal.Text = "Total"
        Me.rb_proveedorestotal.UseVisualStyleBackColor = True
        '
        'rb_proveedoreslectura
        '
        Me.rb_proveedoreslectura.AutoSize = True
        Me.rb_proveedoreslectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_proveedoreslectura.Name = "rb_proveedoreslectura"
        Me.rb_proveedoreslectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_proveedoreslectura.TabIndex = 1
        Me.rb_proveedoreslectura.Text = "Lectura"
        Me.rb_proveedoreslectura.UseVisualStyleBackColor = True
        '
        'rb_proveedoresninguno
        '
        Me.rb_proveedoresninguno.AutoSize = True
        Me.rb_proveedoresninguno.Checked = True
        Me.rb_proveedoresninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_proveedoresninguno.Name = "rb_proveedoresninguno"
        Me.rb_proveedoresninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_proveedoresninguno.TabIndex = 0
        Me.rb_proveedoresninguno.TabStop = True
        Me.rb_proveedoresninguno.Text = "Ninguno"
        Me.rb_proveedoresninguno.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_mutuasseleccionar)
        Me.GroupBox3.Controls.Add(Me.rb_mutuastotal)
        Me.GroupBox3.Controls.Add(Me.rb_mutuaslectura)
        Me.GroupBox3.Controls.Add(Me.rb_mutuasninguno)
        Me.GroupBox3.Location = New System.Drawing.Point(234, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mutuas"
        '
        'rb_mutuasseleccionar
        '
        Me.rb_mutuasseleccionar.AutoSize = True
        Me.rb_mutuasseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_mutuasseleccionar.Name = "rb_mutuasseleccionar"
        Me.rb_mutuasseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_mutuasseleccionar.TabIndex = 3
        Me.rb_mutuasseleccionar.Text = "Seleccionar"
        Me.rb_mutuasseleccionar.UseVisualStyleBackColor = True
        '
        'rb_mutuastotal
        '
        Me.rb_mutuastotal.AutoSize = True
        Me.rb_mutuastotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_mutuastotal.Name = "rb_mutuastotal"
        Me.rb_mutuastotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_mutuastotal.TabIndex = 2
        Me.rb_mutuastotal.Text = "Total"
        Me.rb_mutuastotal.UseVisualStyleBackColor = True
        '
        'rb_mutuaslectura
        '
        Me.rb_mutuaslectura.AutoSize = True
        Me.rb_mutuaslectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_mutuaslectura.Name = "rb_mutuaslectura"
        Me.rb_mutuaslectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_mutuaslectura.TabIndex = 1
        Me.rb_mutuaslectura.Text = "Lectura"
        Me.rb_mutuaslectura.UseVisualStyleBackColor = True
        '
        'rb_mutuasninguno
        '
        Me.rb_mutuasninguno.AutoSize = True
        Me.rb_mutuasninguno.Checked = True
        Me.rb_mutuasninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_mutuasninguno.Name = "rb_mutuasninguno"
        Me.rb_mutuasninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_mutuasninguno.TabIndex = 0
        Me.rb_mutuasninguno.TabStop = True
        Me.rb_mutuasninguno.Text = "Ninguno"
        Me.rb_mutuasninguno.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_medicosseleccionar)
        Me.GroupBox2.Controls.Add(Me.rb_medicostotal)
        Me.GroupBox2.Controls.Add(Me.rb_medicoslectura)
        Me.GroupBox2.Controls.Add(Me.rb_medicosninguno)
        Me.GroupBox2.Location = New System.Drawing.Point(120, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Medicos"
        '
        'rb_medicosseleccionar
        '
        Me.rb_medicosseleccionar.AutoSize = True
        Me.rb_medicosseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_medicosseleccionar.Name = "rb_medicosseleccionar"
        Me.rb_medicosseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_medicosseleccionar.TabIndex = 3
        Me.rb_medicosseleccionar.Text = "Seleccionar"
        Me.rb_medicosseleccionar.UseVisualStyleBackColor = True
        '
        'rb_medicostotal
        '
        Me.rb_medicostotal.AutoSize = True
        Me.rb_medicostotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_medicostotal.Name = "rb_medicostotal"
        Me.rb_medicostotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_medicostotal.TabIndex = 2
        Me.rb_medicostotal.Text = "Total"
        Me.rb_medicostotal.UseVisualStyleBackColor = True
        '
        'rb_medicoslectura
        '
        Me.rb_medicoslectura.AutoSize = True
        Me.rb_medicoslectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_medicoslectura.Name = "rb_medicoslectura"
        Me.rb_medicoslectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_medicoslectura.TabIndex = 1
        Me.rb_medicoslectura.Text = "Lectura"
        Me.rb_medicoslectura.UseVisualStyleBackColor = True
        '
        'rb_medicosninguno
        '
        Me.rb_medicosninguno.AutoSize = True
        Me.rb_medicosninguno.Checked = True
        Me.rb_medicosninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_medicosninguno.Name = "rb_medicosninguno"
        Me.rb_medicosninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_medicosninguno.TabIndex = 0
        Me.rb_medicosninguno.TabStop = True
        Me.rb_medicosninguno.Text = "Ninguno"
        Me.rb_medicosninguno.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_gastosseleccionar)
        Me.GroupBox1.Controls.Add(Me.rb_gastostotal)
        Me.GroupBox1.Controls.Add(Me.rb_gastoslectura)
        Me.GroupBox1.Controls.Add(Me.rb_gastosninguno)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos"
        '
        'rb_gastosseleccionar
        '
        Me.rb_gastosseleccionar.AutoSize = True
        Me.rb_gastosseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_gastosseleccionar.Name = "rb_gastosseleccionar"
        Me.rb_gastosseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_gastosseleccionar.TabIndex = 3
        Me.rb_gastosseleccionar.Text = "Seleccionar"
        Me.rb_gastosseleccionar.UseVisualStyleBackColor = True
        '
        'rb_gastostotal
        '
        Me.rb_gastostotal.AutoSize = True
        Me.rb_gastostotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_gastostotal.Name = "rb_gastostotal"
        Me.rb_gastostotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_gastostotal.TabIndex = 2
        Me.rb_gastostotal.Text = "Total"
        Me.rb_gastostotal.UseVisualStyleBackColor = True
        '
        'rb_gastoslectura
        '
        Me.rb_gastoslectura.AutoSize = True
        Me.rb_gastoslectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_gastoslectura.Name = "rb_gastoslectura"
        Me.rb_gastoslectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_gastoslectura.TabIndex = 1
        Me.rb_gastoslectura.Text = "Lectura"
        Me.rb_gastoslectura.UseVisualStyleBackColor = True
        '
        'rb_gastosninguno
        '
        Me.rb_gastosninguno.AutoSize = True
        Me.rb_gastosninguno.Checked = True
        Me.rb_gastosninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_gastosninguno.Name = "rb_gastosninguno"
        Me.rb_gastosninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_gastosninguno.TabIndex = 0
        Me.rb_gastosninguno.TabStop = True
        Me.rb_gastosninguno.Text = "Ninguno"
        Me.rb_gastosninguno.UseVisualStyleBackColor = True
        '
        'tab_pacientes
        '
        Me.tab_pacientes.Controls.Add(Me.GroupBox13)
        Me.tab_pacientes.Controls.Add(Me.GroupBox14)
        Me.tab_pacientes.Controls.Add(Me.GroupBox15)
        Me.tab_pacientes.Controls.Add(Me.GroupBox16)
        Me.tab_pacientes.Controls.Add(Me.GroupBox17)
        Me.tab_pacientes.Controls.Add(Me.GroupBox18)
        Me.tab_pacientes.Controls.Add(Me.GroupBox22)
        Me.tab_pacientes.Controls.Add(Me.GroupBox7)
        Me.tab_pacientes.Controls.Add(Me.GroupBox8)
        Me.tab_pacientes.Controls.Add(Me.GroupBox23)
        Me.tab_pacientes.Controls.Add(Me.GroupBox9)
        Me.tab_pacientes.Controls.Add(Me.GroupBox)
        Me.tab_pacientes.Controls.Add(Me.GroupBox10)
        Me.tab_pacientes.Controls.Add(Me.GroupBox11)
        Me.tab_pacientes.Controls.Add(Me.GroupBox12)
        Me.tab_pacientes.Location = New System.Drawing.Point(4, 22)
        Me.tab_pacientes.Name = "tab_pacientes"
        Me.tab_pacientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_pacientes.Size = New System.Drawing.Size(697, 351)
        Me.tab_pacientes.TabIndex = 1
        Me.tab_pacientes.Text = "Pacientes"
        Me.tab_pacientes.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.rb_revseleccionar)
        Me.GroupBox13.Controls.Add(Me.rb_revtotal)
        Me.GroupBox13.Controls.Add(Me.rb_revlectura)
        Me.GroupBox13.Controls.Add(Me.rb_revninguno)
        Me.GroupBox13.Location = New System.Drawing.Point(579, 121)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox13.TabIndex = 17
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Rev. Comp."
        '
        'rb_revseleccionar
        '
        Me.rb_revseleccionar.AutoSize = True
        Me.rb_revseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_revseleccionar.Name = "rb_revseleccionar"
        Me.rb_revseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_revseleccionar.TabIndex = 3
        Me.rb_revseleccionar.Text = "Seleccionar"
        Me.rb_revseleccionar.UseVisualStyleBackColor = True
        '
        'rb_revtotal
        '
        Me.rb_revtotal.AutoSize = True
        Me.rb_revtotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_revtotal.Name = "rb_revtotal"
        Me.rb_revtotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_revtotal.TabIndex = 2
        Me.rb_revtotal.Text = "Total"
        Me.rb_revtotal.UseVisualStyleBackColor = True
        '
        'rb_revlectura
        '
        Me.rb_revlectura.AutoSize = True
        Me.rb_revlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_revlectura.Name = "rb_revlectura"
        Me.rb_revlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_revlectura.TabIndex = 1
        Me.rb_revlectura.Text = "Lectura"
        Me.rb_revlectura.UseVisualStyleBackColor = True
        '
        'rb_revninguno
        '
        Me.rb_revninguno.AutoSize = True
        Me.rb_revninguno.Checked = True
        Me.rb_revninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_revninguno.Name = "rb_revninguno"
        Me.rb_revninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_revninguno.TabIndex = 0
        Me.rb_revninguno.TabStop = True
        Me.rb_revninguno.Text = "Ninguno"
        Me.rb_revninguno.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.rb_ficheroseleccionar)
        Me.GroupBox14.Controls.Add(Me.rb_ficherototal)
        Me.GroupBox14.Controls.Add(Me.rb_ficherolectura)
        Me.GroupBox14.Controls.Add(Me.rb_ficheroninguno)
        Me.GroupBox14.Location = New System.Drawing.Point(465, 121)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox14.TabIndex = 16
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Ficheros"
        '
        'rb_ficheroseleccionar
        '
        Me.rb_ficheroseleccionar.AutoSize = True
        Me.rb_ficheroseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_ficheroseleccionar.Name = "rb_ficheroseleccionar"
        Me.rb_ficheroseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_ficheroseleccionar.TabIndex = 3
        Me.rb_ficheroseleccionar.Text = "Seleccionar"
        Me.rb_ficheroseleccionar.UseVisualStyleBackColor = True
        '
        'rb_ficherototal
        '
        Me.rb_ficherototal.AutoSize = True
        Me.rb_ficherototal.Location = New System.Drawing.Point(6, 63)
        Me.rb_ficherototal.Name = "rb_ficherototal"
        Me.rb_ficherototal.Size = New System.Drawing.Size(49, 17)
        Me.rb_ficherototal.TabIndex = 2
        Me.rb_ficherototal.Text = "Total"
        Me.rb_ficherototal.UseVisualStyleBackColor = True
        '
        'rb_ficherolectura
        '
        Me.rb_ficherolectura.AutoSize = True
        Me.rb_ficherolectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_ficherolectura.Name = "rb_ficherolectura"
        Me.rb_ficherolectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_ficherolectura.TabIndex = 1
        Me.rb_ficherolectura.Text = "Lectura"
        Me.rb_ficherolectura.UseVisualStyleBackColor = True
        '
        'rb_ficheroninguno
        '
        Me.rb_ficheroninguno.AutoSize = True
        Me.rb_ficheroninguno.Checked = True
        Me.rb_ficheroninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_ficheroninguno.Name = "rb_ficheroninguno"
        Me.rb_ficheroninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_ficheroninguno.TabIndex = 0
        Me.rb_ficheroninguno.TabStop = True
        Me.rb_ficheroninguno.Text = "Ninguno"
        Me.rb_ficheroninguno.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.rb_remseleccionar)
        Me.GroupBox15.Controls.Add(Me.rb_remtotal)
        Me.GroupBox15.Controls.Add(Me.rb_remlectura)
        Me.GroupBox15.Controls.Add(Me.rb_remninguno)
        Me.GroupBox15.Location = New System.Drawing.Point(351, 121)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox15.TabIndex = 15
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Imprimir remesas"
        '
        'rb_remseleccionar
        '
        Me.rb_remseleccionar.AutoSize = True
        Me.rb_remseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_remseleccionar.Name = "rb_remseleccionar"
        Me.rb_remseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_remseleccionar.TabIndex = 3
        Me.rb_remseleccionar.Text = "Seleccionar"
        Me.rb_remseleccionar.UseVisualStyleBackColor = True
        '
        'rb_remtotal
        '
        Me.rb_remtotal.AutoSize = True
        Me.rb_remtotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_remtotal.Name = "rb_remtotal"
        Me.rb_remtotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_remtotal.TabIndex = 2
        Me.rb_remtotal.Text = "Total"
        Me.rb_remtotal.UseVisualStyleBackColor = True
        '
        'rb_remlectura
        '
        Me.rb_remlectura.AutoSize = True
        Me.rb_remlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_remlectura.Name = "rb_remlectura"
        Me.rb_remlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_remlectura.TabIndex = 1
        Me.rb_remlectura.Text = "Lectura"
        Me.rb_remlectura.UseVisualStyleBackColor = True
        '
        'rb_remninguno
        '
        Me.rb_remninguno.AutoSize = True
        Me.rb_remninguno.Checked = True
        Me.rb_remninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_remninguno.Name = "rb_remninguno"
        Me.rb_remninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_remninguno.TabIndex = 0
        Me.rb_remninguno.TabStop = True
        Me.rb_remninguno.Text = "Ninguno"
        Me.rb_remninguno.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.rb_genrecseleccionar)
        Me.GroupBox16.Controls.Add(Me.rb_genrectotal)
        Me.GroupBox16.Controls.Add(Me.rb_genreclectura)
        Me.GroupBox16.Controls.Add(Me.rb_genrecninguno)
        Me.GroupBox16.Location = New System.Drawing.Point(237, 121)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox16.TabIndex = 14
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Generar recibos"
        '
        'rb_genrecseleccionar
        '
        Me.rb_genrecseleccionar.AutoSize = True
        Me.rb_genrecseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_genrecseleccionar.Name = "rb_genrecseleccionar"
        Me.rb_genrecseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_genrecseleccionar.TabIndex = 3
        Me.rb_genrecseleccionar.Text = "Seleccionar"
        Me.rb_genrecseleccionar.UseVisualStyleBackColor = True
        '
        'rb_genrectotal
        '
        Me.rb_genrectotal.AutoSize = True
        Me.rb_genrectotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_genrectotal.Name = "rb_genrectotal"
        Me.rb_genrectotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_genrectotal.TabIndex = 2
        Me.rb_genrectotal.Text = "Total"
        Me.rb_genrectotal.UseVisualStyleBackColor = True
        '
        'rb_genreclectura
        '
        Me.rb_genreclectura.AutoSize = True
        Me.rb_genreclectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_genreclectura.Name = "rb_genreclectura"
        Me.rb_genreclectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_genreclectura.TabIndex = 1
        Me.rb_genreclectura.Text = "Lectura"
        Me.rb_genreclectura.UseVisualStyleBackColor = True
        '
        'rb_genrecninguno
        '
        Me.rb_genrecninguno.AutoSize = True
        Me.rb_genrecninguno.Checked = True
        Me.rb_genrecninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_genrecninguno.Name = "rb_genrecninguno"
        Me.rb_genrecninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_genrecninguno.TabIndex = 0
        Me.rb_genrecninguno.TabStop = True
        Me.rb_genrecninguno.Text = "Ninguno"
        Me.rb_genrecninguno.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.rb_reciboseleccionar)
        Me.GroupBox17.Controls.Add(Me.rb_recibototal)
        Me.GroupBox17.Controls.Add(Me.rb_recibolectura)
        Me.GroupBox17.Controls.Add(Me.rb_reciboninguno)
        Me.GroupBox17.Location = New System.Drawing.Point(123, 121)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox17.TabIndex = 13
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Recibos"
        '
        'rb_reciboseleccionar
        '
        Me.rb_reciboseleccionar.AutoSize = True
        Me.rb_reciboseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_reciboseleccionar.Name = "rb_reciboseleccionar"
        Me.rb_reciboseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_reciboseleccionar.TabIndex = 3
        Me.rb_reciboseleccionar.Text = "Seleccionar"
        Me.rb_reciboseleccionar.UseVisualStyleBackColor = True
        '
        'rb_recibototal
        '
        Me.rb_recibototal.AutoSize = True
        Me.rb_recibototal.Location = New System.Drawing.Point(6, 63)
        Me.rb_recibototal.Name = "rb_recibototal"
        Me.rb_recibototal.Size = New System.Drawing.Size(49, 17)
        Me.rb_recibototal.TabIndex = 2
        Me.rb_recibototal.Text = "Total"
        Me.rb_recibototal.UseVisualStyleBackColor = True
        '
        'rb_recibolectura
        '
        Me.rb_recibolectura.AutoSize = True
        Me.rb_recibolectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_recibolectura.Name = "rb_recibolectura"
        Me.rb_recibolectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_recibolectura.TabIndex = 1
        Me.rb_recibolectura.Text = "Lectura"
        Me.rb_recibolectura.UseVisualStyleBackColor = True
        '
        'rb_reciboninguno
        '
        Me.rb_reciboninguno.AutoSize = True
        Me.rb_reciboninguno.Checked = True
        Me.rb_reciboninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_reciboninguno.Name = "rb_reciboninguno"
        Me.rb_reciboninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_reciboninguno.TabIndex = 0
        Me.rb_reciboninguno.TabStop = True
        Me.rb_reciboninguno.Text = "Ninguno"
        Me.rb_reciboninguno.UseVisualStyleBackColor = True
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.rb_analseleccionar)
        Me.GroupBox18.Controls.Add(Me.rb_analtotal)
        Me.GroupBox18.Controls.Add(Me.rb_anallectura)
        Me.GroupBox18.Controls.Add(Me.rb_analninguno)
        Me.GroupBox18.Location = New System.Drawing.Point(9, 121)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox18.TabIndex = 12
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Analiticas"
        '
        'rb_analseleccionar
        '
        Me.rb_analseleccionar.AutoSize = True
        Me.rb_analseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_analseleccionar.Name = "rb_analseleccionar"
        Me.rb_analseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_analseleccionar.TabIndex = 3
        Me.rb_analseleccionar.Text = "Seleccionar"
        Me.rb_analseleccionar.UseVisualStyleBackColor = True
        '
        'rb_analtotal
        '
        Me.rb_analtotal.AutoSize = True
        Me.rb_analtotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_analtotal.Name = "rb_analtotal"
        Me.rb_analtotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_analtotal.TabIndex = 2
        Me.rb_analtotal.Text = "Total"
        Me.rb_analtotal.UseVisualStyleBackColor = True
        '
        'rb_anallectura
        '
        Me.rb_anallectura.AutoSize = True
        Me.rb_anallectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_anallectura.Name = "rb_anallectura"
        Me.rb_anallectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_anallectura.TabIndex = 1
        Me.rb_anallectura.Text = "Lectura"
        Me.rb_anallectura.UseVisualStyleBackColor = True
        '
        'rb_analninguno
        '
        Me.rb_analninguno.AutoSize = True
        Me.rb_analninguno.Checked = True
        Me.rb_analninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_analninguno.Name = "rb_analninguno"
        Me.rb_analninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_analninguno.TabIndex = 0
        Me.rb_analninguno.TabStop = True
        Me.rb_analninguno.Text = "Ninguno"
        Me.rb_analninguno.UseVisualStyleBackColor = True
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.rb_infoseleccionar)
        Me.GroupBox22.Controls.Add(Me.rb_infototal)
        Me.GroupBox22.Controls.Add(Me.rb_infolectura)
        Me.GroupBox22.Controls.Add(Me.rb_infoninguno)
        Me.GroupBox22.Location = New System.Drawing.Point(237, 236)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox22.TabIndex = 20
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Inform. Primaria"
        '
        'rb_infoseleccionar
        '
        Me.rb_infoseleccionar.AutoSize = True
        Me.rb_infoseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_infoseleccionar.Name = "rb_infoseleccionar"
        Me.rb_infoseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_infoseleccionar.TabIndex = 3
        Me.rb_infoseleccionar.Text = "Seleccionar"
        Me.rb_infoseleccionar.UseVisualStyleBackColor = True
        '
        'rb_infototal
        '
        Me.rb_infototal.AutoSize = True
        Me.rb_infototal.Location = New System.Drawing.Point(6, 63)
        Me.rb_infototal.Name = "rb_infototal"
        Me.rb_infototal.Size = New System.Drawing.Size(49, 17)
        Me.rb_infototal.TabIndex = 2
        Me.rb_infototal.Text = "Total"
        Me.rb_infototal.UseVisualStyleBackColor = True
        '
        'rb_infolectura
        '
        Me.rb_infolectura.AutoSize = True
        Me.rb_infolectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_infolectura.Name = "rb_infolectura"
        Me.rb_infolectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_infolectura.TabIndex = 1
        Me.rb_infolectura.Text = "Lectura"
        Me.rb_infolectura.UseVisualStyleBackColor = True
        '
        'rb_infoninguno
        '
        Me.rb_infoninguno.AutoSize = True
        Me.rb_infoninguno.Checked = True
        Me.rb_infoninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_infoninguno.Name = "rb_infoninguno"
        Me.rb_infoninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_infoninguno.TabIndex = 0
        Me.rb_infoninguno.TabStop = True
        Me.rb_infoninguno.Text = "Ninguno"
        Me.rb_infoninguno.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rb_asistseleccionar)
        Me.GroupBox7.Controls.Add(Me.rb_asisttotal)
        Me.GroupBox7.Controls.Add(Me.rb_asistlectura)
        Me.GroupBox7.Controls.Add(Me.rb_asistninguno)
        Me.GroupBox7.Location = New System.Drawing.Point(576, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Partes Asistencia"
        '
        'rb_asistseleccionar
        '
        Me.rb_asistseleccionar.AutoSize = True
        Me.rb_asistseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_asistseleccionar.Name = "rb_asistseleccionar"
        Me.rb_asistseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_asistseleccionar.TabIndex = 3
        Me.rb_asistseleccionar.Text = "Seleccionar"
        Me.rb_asistseleccionar.UseVisualStyleBackColor = True
        '
        'rb_asisttotal
        '
        Me.rb_asisttotal.AutoSize = True
        Me.rb_asisttotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_asisttotal.Name = "rb_asisttotal"
        Me.rb_asisttotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_asisttotal.TabIndex = 2
        Me.rb_asisttotal.Text = "Total"
        Me.rb_asisttotal.UseVisualStyleBackColor = True
        '
        'rb_asistlectura
        '
        Me.rb_asistlectura.AutoSize = True
        Me.rb_asistlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_asistlectura.Name = "rb_asistlectura"
        Me.rb_asistlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_asistlectura.TabIndex = 1
        Me.rb_asistlectura.Text = "Lectura"
        Me.rb_asistlectura.UseVisualStyleBackColor = True
        '
        'rb_asistninguno
        '
        Me.rb_asistninguno.AutoSize = True
        Me.rb_asistninguno.Checked = True
        Me.rb_asistninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_asistninguno.Name = "rb_asistninguno"
        Me.rb_asistninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_asistninguno.TabIndex = 0
        Me.rb_asistninguno.TabStop = True
        Me.rb_asistninguno.Text = "Ninguno"
        Me.rb_asistninguno.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rb_bajaseleccionar)
        Me.GroupBox8.Controls.Add(Me.rb_bajatotal)
        Me.GroupBox8.Controls.Add(Me.rb_bajalectura)
        Me.GroupBox8.Controls.Add(Me.rb_bajaninguno)
        Me.GroupBox8.Location = New System.Drawing.Point(462, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Partes Alta/Baja"
        '
        'rb_bajaseleccionar
        '
        Me.rb_bajaseleccionar.AutoSize = True
        Me.rb_bajaseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_bajaseleccionar.Name = "rb_bajaseleccionar"
        Me.rb_bajaseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_bajaseleccionar.TabIndex = 3
        Me.rb_bajaseleccionar.Text = "Seleccionar"
        Me.rb_bajaseleccionar.UseVisualStyleBackColor = True
        '
        'rb_bajatotal
        '
        Me.rb_bajatotal.AutoSize = True
        Me.rb_bajatotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_bajatotal.Name = "rb_bajatotal"
        Me.rb_bajatotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_bajatotal.TabIndex = 2
        Me.rb_bajatotal.Text = "Total"
        Me.rb_bajatotal.UseVisualStyleBackColor = True
        '
        'rb_bajalectura
        '
        Me.rb_bajalectura.AutoSize = True
        Me.rb_bajalectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_bajalectura.Name = "rb_bajalectura"
        Me.rb_bajalectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_bajalectura.TabIndex = 1
        Me.rb_bajalectura.Text = "Lectura"
        Me.rb_bajalectura.UseVisualStyleBackColor = True
        '
        'rb_bajaninguno
        '
        Me.rb_bajaninguno.AutoSize = True
        Me.rb_bajaninguno.Checked = True
        Me.rb_bajaninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_bajaninguno.Name = "rb_bajaninguno"
        Me.rb_bajaninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_bajaninguno.TabIndex = 0
        Me.rb_bajaninguno.TabStop = True
        Me.rb_bajaninguno.Text = "Ninguno"
        Me.rb_bajaninguno.UseVisualStyleBackColor = True
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.rb_histseleccionar)
        Me.GroupBox23.Controls.Add(Me.rb_histtotal)
        Me.GroupBox23.Controls.Add(Me.rb_histlectura)
        Me.GroupBox23.Controls.Add(Me.rb_histninguno)
        Me.GroupBox23.Location = New System.Drawing.Point(123, 236)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox23.TabIndex = 19
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "Historiales"
        '
        'rb_histseleccionar
        '
        Me.rb_histseleccionar.AutoSize = True
        Me.rb_histseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_histseleccionar.Name = "rb_histseleccionar"
        Me.rb_histseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_histseleccionar.TabIndex = 3
        Me.rb_histseleccionar.Text = "Seleccionar"
        Me.rb_histseleccionar.UseVisualStyleBackColor = True
        '
        'rb_histtotal
        '
        Me.rb_histtotal.AutoSize = True
        Me.rb_histtotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_histtotal.Name = "rb_histtotal"
        Me.rb_histtotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_histtotal.TabIndex = 2
        Me.rb_histtotal.Text = "Total"
        Me.rb_histtotal.UseVisualStyleBackColor = True
        '
        'rb_histlectura
        '
        Me.rb_histlectura.AutoSize = True
        Me.rb_histlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_histlectura.Name = "rb_histlectura"
        Me.rb_histlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_histlectura.TabIndex = 1
        Me.rb_histlectura.Text = "Lectura"
        Me.rb_histlectura.UseVisualStyleBackColor = True
        '
        'rb_histninguno
        '
        Me.rb_histninguno.AutoSize = True
        Me.rb_histninguno.Checked = True
        Me.rb_histninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_histninguno.Name = "rb_histninguno"
        Me.rb_histninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_histninguno.TabIndex = 0
        Me.rb_histninguno.TabStop = True
        Me.rb_histninguno.Text = "Ninguno"
        Me.rb_histninguno.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.rb_citaseleccionar)
        Me.GroupBox9.Controls.Add(Me.rb_citatotal)
        Me.GroupBox9.Controls.Add(Me.rb_citalectura)
        Me.GroupBox9.Controls.Add(Me.rb_citaninguno)
        Me.GroupBox9.Location = New System.Drawing.Point(348, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox9.TabIndex = 9
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Citas"
        '
        'rb_citaseleccionar
        '
        Me.rb_citaseleccionar.AutoSize = True
        Me.rb_citaseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_citaseleccionar.Name = "rb_citaseleccionar"
        Me.rb_citaseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_citaseleccionar.TabIndex = 3
        Me.rb_citaseleccionar.Text = "Seleccionar"
        Me.rb_citaseleccionar.UseVisualStyleBackColor = True
        '
        'rb_citatotal
        '
        Me.rb_citatotal.AutoSize = True
        Me.rb_citatotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_citatotal.Name = "rb_citatotal"
        Me.rb_citatotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_citatotal.TabIndex = 2
        Me.rb_citatotal.Text = "Total"
        Me.rb_citatotal.UseVisualStyleBackColor = True
        '
        'rb_citalectura
        '
        Me.rb_citalectura.AutoSize = True
        Me.rb_citalectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_citalectura.Name = "rb_citalectura"
        Me.rb_citalectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_citalectura.TabIndex = 1
        Me.rb_citalectura.Text = "Lectura"
        Me.rb_citalectura.UseVisualStyleBackColor = True
        '
        'rb_citaninguno
        '
        Me.rb_citaninguno.AutoSize = True
        Me.rb_citaninguno.Checked = True
        Me.rb_citaninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_citaninguno.Name = "rb_citaninguno"
        Me.rb_citaninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_citaninguno.TabIndex = 0
        Me.rb_citaninguno.TabStop = True
        Me.rb_citaninguno.Text = "Ninguno"
        Me.rb_citaninguno.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.rb_recetaseleccionar)
        Me.GroupBox.Controls.Add(Me.rb_recetatotal)
        Me.GroupBox.Controls.Add(Me.rb_recetalectura)
        Me.GroupBox.Controls.Add(Me.rb_recetaninguno)
        Me.GroupBox.Location = New System.Drawing.Point(9, 236)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox.TabIndex = 18
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Recetas"
        '
        'rb_recetaseleccionar
        '
        Me.rb_recetaseleccionar.AutoSize = True
        Me.rb_recetaseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_recetaseleccionar.Name = "rb_recetaseleccionar"
        Me.rb_recetaseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_recetaseleccionar.TabIndex = 3
        Me.rb_recetaseleccionar.Text = "Seleccionar"
        Me.rb_recetaseleccionar.UseVisualStyleBackColor = True
        '
        'rb_recetatotal
        '
        Me.rb_recetatotal.AutoSize = True
        Me.rb_recetatotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_recetatotal.Name = "rb_recetatotal"
        Me.rb_recetatotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_recetatotal.TabIndex = 2
        Me.rb_recetatotal.Text = "Total"
        Me.rb_recetatotal.UseVisualStyleBackColor = True
        '
        'rb_recetalectura
        '
        Me.rb_recetalectura.AutoSize = True
        Me.rb_recetalectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_recetalectura.Name = "rb_recetalectura"
        Me.rb_recetalectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_recetalectura.TabIndex = 1
        Me.rb_recetalectura.Text = "Lectura"
        Me.rb_recetalectura.UseVisualStyleBackColor = True
        '
        'rb_recetaninguno
        '
        Me.rb_recetaninguno.AutoSize = True
        Me.rb_recetaninguno.Checked = True
        Me.rb_recetaninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_recetaninguno.Name = "rb_recetaninguno"
        Me.rb_recetaninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_recetaninguno.TabIndex = 0
        Me.rb_recetaninguno.TabStop = True
        Me.rb_recetaninguno.Text = "Ninguno"
        Me.rb_recetaninguno.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.rb_facturaseleccionar)
        Me.GroupBox10.Controls.Add(Me.rb_facturatotal)
        Me.GroupBox10.Controls.Add(Me.rb_facturalectura)
        Me.GroupBox10.Controls.Add(Me.rb_facturaninguno)
        Me.GroupBox10.Location = New System.Drawing.Point(234, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox10.TabIndex = 8
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Facturas"
        '
        'rb_facturaseleccionar
        '
        Me.rb_facturaseleccionar.AutoSize = True
        Me.rb_facturaseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_facturaseleccionar.Name = "rb_facturaseleccionar"
        Me.rb_facturaseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_facturaseleccionar.TabIndex = 3
        Me.rb_facturaseleccionar.Text = "Seleccionar"
        Me.rb_facturaseleccionar.UseVisualStyleBackColor = True
        '
        'rb_facturatotal
        '
        Me.rb_facturatotal.AutoSize = True
        Me.rb_facturatotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_facturatotal.Name = "rb_facturatotal"
        Me.rb_facturatotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_facturatotal.TabIndex = 2
        Me.rb_facturatotal.Text = "Total"
        Me.rb_facturatotal.UseVisualStyleBackColor = True
        '
        'rb_facturalectura
        '
        Me.rb_facturalectura.AutoSize = True
        Me.rb_facturalectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_facturalectura.Name = "rb_facturalectura"
        Me.rb_facturalectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_facturalectura.TabIndex = 1
        Me.rb_facturalectura.Text = "Lectura"
        Me.rb_facturalectura.UseVisualStyleBackColor = True
        '
        'rb_facturaninguno
        '
        Me.rb_facturaninguno.AutoSize = True
        Me.rb_facturaninguno.Checked = True
        Me.rb_facturaninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_facturaninguno.Name = "rb_facturaninguno"
        Me.rb_facturaninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_facturaninguno.TabIndex = 0
        Me.rb_facturaninguno.TabStop = True
        Me.rb_facturaninguno.Text = "Ninguno"
        Me.rb_facturaninguno.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.rb_empresaseleccionar)
        Me.GroupBox11.Controls.Add(Me.rb_empresatotal)
        Me.GroupBox11.Controls.Add(Me.rb_empresaslectura)
        Me.GroupBox11.Controls.Add(Me.rb_empresasninguno)
        Me.GroupBox11.Location = New System.Drawing.Point(120, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox11.TabIndex = 7
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Empresas"
        '
        'rb_empresaseleccionar
        '
        Me.rb_empresaseleccionar.AutoSize = True
        Me.rb_empresaseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_empresaseleccionar.Name = "rb_empresaseleccionar"
        Me.rb_empresaseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_empresaseleccionar.TabIndex = 3
        Me.rb_empresaseleccionar.Text = "Seleccionar"
        Me.rb_empresaseleccionar.UseVisualStyleBackColor = True
        '
        'rb_empresatotal
        '
        Me.rb_empresatotal.AutoSize = True
        Me.rb_empresatotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_empresatotal.Name = "rb_empresatotal"
        Me.rb_empresatotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_empresatotal.TabIndex = 2
        Me.rb_empresatotal.Text = "Total"
        Me.rb_empresatotal.UseVisualStyleBackColor = True
        '
        'rb_empresaslectura
        '
        Me.rb_empresaslectura.AutoSize = True
        Me.rb_empresaslectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_empresaslectura.Name = "rb_empresaslectura"
        Me.rb_empresaslectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_empresaslectura.TabIndex = 1
        Me.rb_empresaslectura.Text = "Lectura"
        Me.rb_empresaslectura.UseVisualStyleBackColor = True
        '
        'rb_empresasninguno
        '
        Me.rb_empresasninguno.AutoSize = True
        Me.rb_empresasninguno.Checked = True
        Me.rb_empresasninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_empresasninguno.Name = "rb_empresasninguno"
        Me.rb_empresasninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_empresasninguno.TabIndex = 0
        Me.rb_empresasninguno.TabStop = True
        Me.rb_empresasninguno.Text = "Ninguno"
        Me.rb_empresasninguno.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.rb_pacientesseleccionar)
        Me.GroupBox12.Controls.Add(Me.rb_pacientestotal)
        Me.GroupBox12.Controls.Add(Me.rb_pacienteslectura)
        Me.GroupBox12.Controls.Add(Me.rb_pacientesninguno)
        Me.GroupBox12.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox12.TabIndex = 6
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Pacientes"
        '
        'rb_pacientesseleccionar
        '
        Me.rb_pacientesseleccionar.AutoSize = True
        Me.rb_pacientesseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_pacientesseleccionar.Name = "rb_pacientesseleccionar"
        Me.rb_pacientesseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_pacientesseleccionar.TabIndex = 3
        Me.rb_pacientesseleccionar.Text = "Seleccionar"
        Me.rb_pacientesseleccionar.UseVisualStyleBackColor = True
        '
        'rb_pacientestotal
        '
        Me.rb_pacientestotal.AutoSize = True
        Me.rb_pacientestotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_pacientestotal.Name = "rb_pacientestotal"
        Me.rb_pacientestotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_pacientestotal.TabIndex = 2
        Me.rb_pacientestotal.Text = "Total"
        Me.rb_pacientestotal.UseVisualStyleBackColor = True
        '
        'rb_pacienteslectura
        '
        Me.rb_pacienteslectura.AutoSize = True
        Me.rb_pacienteslectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_pacienteslectura.Name = "rb_pacienteslectura"
        Me.rb_pacienteslectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_pacienteslectura.TabIndex = 1
        Me.rb_pacienteslectura.Text = "Lectura"
        Me.rb_pacienteslectura.UseVisualStyleBackColor = True
        '
        'rb_pacientesninguno
        '
        Me.rb_pacientesninguno.AutoSize = True
        Me.rb_pacientesninguno.Checked = True
        Me.rb_pacientesninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_pacientesninguno.Name = "rb_pacientesninguno"
        Me.rb_pacientesninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_pacientesninguno.TabIndex = 0
        Me.rb_pacientesninguno.TabStop = True
        Me.rb_pacientesninguno.Text = "Ninguno"
        Me.rb_pacientesninguno.UseVisualStyleBackColor = True
        '
        'tab_mantenimiento
        '
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox28)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox29)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox30)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox31)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox32)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox33)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox19)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox20)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox21)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox25)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox26)
        Me.tab_mantenimiento.Controls.Add(Me.GroupBox27)
        Me.tab_mantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.tab_mantenimiento.Name = "tab_mantenimiento"
        Me.tab_mantenimiento.Size = New System.Drawing.Size(697, 351)
        Me.tab_mantenimiento.TabIndex = 2
        Me.tab_mantenimiento.Text = "Mantenimiento"
        Me.tab_mantenimiento.UseVisualStyleBackColor = True
        '
        'GroupBox28
        '
        Me.GroupBox28.Controls.Add(Me.rb_clinicaseleccionar)
        Me.GroupBox28.Controls.Add(Me.rb_clinicatotal)
        Me.GroupBox28.Controls.Add(Me.rb_clinicalectura)
        Me.GroupBox28.Controls.Add(Me.rb_clinicaninguno)
        Me.GroupBox28.Location = New System.Drawing.Point(579, 121)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox28.TabIndex = 17
        Me.GroupBox28.TabStop = False
        Me.GroupBox28.Text = "Clinicas ext."
        '
        'rb_clinicaseleccionar
        '
        Me.rb_clinicaseleccionar.AutoSize = True
        Me.rb_clinicaseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_clinicaseleccionar.Name = "rb_clinicaseleccionar"
        Me.rb_clinicaseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_clinicaseleccionar.TabIndex = 3
        Me.rb_clinicaseleccionar.Text = "Seleccionar"
        Me.rb_clinicaseleccionar.UseVisualStyleBackColor = True
        '
        'rb_clinicatotal
        '
        Me.rb_clinicatotal.AutoSize = True
        Me.rb_clinicatotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_clinicatotal.Name = "rb_clinicatotal"
        Me.rb_clinicatotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_clinicatotal.TabIndex = 2
        Me.rb_clinicatotal.Text = "Total"
        Me.rb_clinicatotal.UseVisualStyleBackColor = True
        '
        'rb_clinicalectura
        '
        Me.rb_clinicalectura.AutoSize = True
        Me.rb_clinicalectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_clinicalectura.Name = "rb_clinicalectura"
        Me.rb_clinicalectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_clinicalectura.TabIndex = 1
        Me.rb_clinicalectura.Text = "Lectura"
        Me.rb_clinicalectura.UseVisualStyleBackColor = True
        '
        'rb_clinicaninguno
        '
        Me.rb_clinicaninguno.AutoSize = True
        Me.rb_clinicaninguno.Checked = True
        Me.rb_clinicaninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_clinicaninguno.Name = "rb_clinicaninguno"
        Me.rb_clinicaninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_clinicaninguno.TabIndex = 0
        Me.rb_clinicaninguno.TabStop = True
        Me.rb_clinicaninguno.Text = "Ninguno"
        Me.rb_clinicaninguno.UseVisualStyleBackColor = True
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Me.rb_phistseleccionar)
        Me.GroupBox29.Controls.Add(Me.rb_phisttotal)
        Me.GroupBox29.Controls.Add(Me.rb_phistlectura)
        Me.GroupBox29.Controls.Add(Me.rb_phistninguno)
        Me.GroupBox29.Location = New System.Drawing.Point(465, 121)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox29.TabIndex = 16
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "Plantillas hist."
        '
        'rb_phistseleccionar
        '
        Me.rb_phistseleccionar.AutoSize = True
        Me.rb_phistseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_phistseleccionar.Name = "rb_phistseleccionar"
        Me.rb_phistseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_phistseleccionar.TabIndex = 3
        Me.rb_phistseleccionar.Text = "Seleccionar"
        Me.rb_phistseleccionar.UseVisualStyleBackColor = True
        '
        'rb_phisttotal
        '
        Me.rb_phisttotal.AutoSize = True
        Me.rb_phisttotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_phisttotal.Name = "rb_phisttotal"
        Me.rb_phisttotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_phisttotal.TabIndex = 2
        Me.rb_phisttotal.Text = "Total"
        Me.rb_phisttotal.UseVisualStyleBackColor = True
        '
        'rb_phistlectura
        '
        Me.rb_phistlectura.AutoSize = True
        Me.rb_phistlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_phistlectura.Name = "rb_phistlectura"
        Me.rb_phistlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_phistlectura.TabIndex = 1
        Me.rb_phistlectura.Text = "Lectura"
        Me.rb_phistlectura.UseVisualStyleBackColor = True
        '
        'rb_phistninguno
        '
        Me.rb_phistninguno.AutoSize = True
        Me.rb_phistninguno.Checked = True
        Me.rb_phistninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_phistninguno.Name = "rb_phistninguno"
        Me.rb_phistninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_phistninguno.TabIndex = 0
        Me.rb_phistninguno.TabStop = True
        Me.rb_phistninguno.Text = "Ninguno"
        Me.rb_phistninguno.UseVisualStyleBackColor = True
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.rb_modseleccionar)
        Me.GroupBox30.Controls.Add(Me.rb_modtotal)
        Me.GroupBox30.Controls.Add(Me.rb_modlectura)
        Me.GroupBox30.Controls.Add(Me.rb_modninguno)
        Me.GroupBox30.Location = New System.Drawing.Point(351, 121)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox30.TabIndex = 15
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "Modelos revision"
        '
        'rb_modseleccionar
        '
        Me.rb_modseleccionar.AutoSize = True
        Me.rb_modseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_modseleccionar.Name = "rb_modseleccionar"
        Me.rb_modseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_modseleccionar.TabIndex = 3
        Me.rb_modseleccionar.Text = "Seleccionar"
        Me.rb_modseleccionar.UseVisualStyleBackColor = True
        '
        'rb_modtotal
        '
        Me.rb_modtotal.AutoSize = True
        Me.rb_modtotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_modtotal.Name = "rb_modtotal"
        Me.rb_modtotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_modtotal.TabIndex = 2
        Me.rb_modtotal.Text = "Total"
        Me.rb_modtotal.UseVisualStyleBackColor = True
        '
        'rb_modlectura
        '
        Me.rb_modlectura.AutoSize = True
        Me.rb_modlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_modlectura.Name = "rb_modlectura"
        Me.rb_modlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_modlectura.TabIndex = 1
        Me.rb_modlectura.Text = "Lectura"
        Me.rb_modlectura.UseVisualStyleBackColor = True
        '
        'rb_modninguno
        '
        Me.rb_modninguno.AutoSize = True
        Me.rb_modninguno.Checked = True
        Me.rb_modninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_modninguno.Name = "rb_modninguno"
        Me.rb_modninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_modninguno.TabIndex = 0
        Me.rb_modninguno.TabStop = True
        Me.rb_modninguno.Text = "Ninguno"
        Me.rb_modninguno.UseVisualStyleBackColor = True
        '
        'GroupBox31
        '
        Me.GroupBox31.Controls.Add(Me.rb_panalseleccionar)
        Me.GroupBox31.Controls.Add(Me.rb_panaltotal)
        Me.GroupBox31.Controls.Add(Me.rb_panallectura)
        Me.GroupBox31.Controls.Add(Me.rb_panalninguno)
        Me.GroupBox31.Location = New System.Drawing.Point(237, 121)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox31.TabIndex = 14
        Me.GroupBox31.TabStop = False
        Me.GroupBox31.Text = "Plantillas anal."
        '
        'rb_panalseleccionar
        '
        Me.rb_panalseleccionar.AutoSize = True
        Me.rb_panalseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_panalseleccionar.Name = "rb_panalseleccionar"
        Me.rb_panalseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_panalseleccionar.TabIndex = 3
        Me.rb_panalseleccionar.Text = "Seleccionar"
        Me.rb_panalseleccionar.UseVisualStyleBackColor = True
        '
        'rb_panaltotal
        '
        Me.rb_panaltotal.AutoSize = True
        Me.rb_panaltotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_panaltotal.Name = "rb_panaltotal"
        Me.rb_panaltotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_panaltotal.TabIndex = 2
        Me.rb_panaltotal.Text = "Total"
        Me.rb_panaltotal.UseVisualStyleBackColor = True
        '
        'rb_panallectura
        '
        Me.rb_panallectura.AutoSize = True
        Me.rb_panallectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_panallectura.Name = "rb_panallectura"
        Me.rb_panallectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_panallectura.TabIndex = 1
        Me.rb_panallectura.Text = "Lectura"
        Me.rb_panallectura.UseVisualStyleBackColor = True
        '
        'rb_panalninguno
        '
        Me.rb_panalninguno.AutoSize = True
        Me.rb_panalninguno.Checked = True
        Me.rb_panalninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_panalninguno.Name = "rb_panalninguno"
        Me.rb_panalninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_panalninguno.TabIndex = 0
        Me.rb_panalninguno.TabStop = True
        Me.rb_panalninguno.Text = "Ninguno"
        Me.rb_panalninguno.UseVisualStyleBackColor = True
        '
        'GroupBox32
        '
        Me.GroupBox32.Controls.Add(Me.rb_conceptseleccionar)
        Me.GroupBox32.Controls.Add(Me.rb_concepttotal)
        Me.GroupBox32.Controls.Add(Me.rb_conceptlectura)
        Me.GroupBox32.Controls.Add(Me.rb_conceptninguno)
        Me.GroupBox32.Location = New System.Drawing.Point(123, 121)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox32.TabIndex = 13
        Me.GroupBox32.TabStop = False
        Me.GroupBox32.Text = "Conceptos fac."
        '
        'rb_conceptseleccionar
        '
        Me.rb_conceptseleccionar.AutoSize = True
        Me.rb_conceptseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_conceptseleccionar.Name = "rb_conceptseleccionar"
        Me.rb_conceptseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_conceptseleccionar.TabIndex = 3
        Me.rb_conceptseleccionar.Text = "Seleccionar"
        Me.rb_conceptseleccionar.UseVisualStyleBackColor = True
        '
        'rb_concepttotal
        '
        Me.rb_concepttotal.AutoSize = True
        Me.rb_concepttotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_concepttotal.Name = "rb_concepttotal"
        Me.rb_concepttotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_concepttotal.TabIndex = 2
        Me.rb_concepttotal.Text = "Total"
        Me.rb_concepttotal.UseVisualStyleBackColor = True
        '
        'rb_conceptlectura
        '
        Me.rb_conceptlectura.AutoSize = True
        Me.rb_conceptlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_conceptlectura.Name = "rb_conceptlectura"
        Me.rb_conceptlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_conceptlectura.TabIndex = 1
        Me.rb_conceptlectura.Text = "Lectura"
        Me.rb_conceptlectura.UseVisualStyleBackColor = True
        '
        'rb_conceptninguno
        '
        Me.rb_conceptninguno.AutoSize = True
        Me.rb_conceptninguno.Checked = True
        Me.rb_conceptninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_conceptninguno.Name = "rb_conceptninguno"
        Me.rb_conceptninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_conceptninguno.TabIndex = 0
        Me.rb_conceptninguno.TabStop = True
        Me.rb_conceptninguno.Text = "Ninguno"
        Me.rb_conceptninguno.UseVisualStyleBackColor = True
        '
        'GroupBox33
        '
        Me.GroupBox33.Controls.Add(Me.rb_ptextseleccionar)
        Me.GroupBox33.Controls.Add(Me.rb_ptexttotal)
        Me.GroupBox33.Controls.Add(Me.rb_ptextlectura)
        Me.GroupBox33.Controls.Add(Me.rb_ptextninguno)
        Me.GroupBox33.Location = New System.Drawing.Point(9, 121)
        Me.GroupBox33.Name = "GroupBox33"
        Me.GroupBox33.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox33.TabIndex = 12
        Me.GroupBox33.TabStop = False
        Me.GroupBox33.Text = "Plantillas de texto"
        '
        'rb_ptextseleccionar
        '
        Me.rb_ptextseleccionar.AutoSize = True
        Me.rb_ptextseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_ptextseleccionar.Name = "rb_ptextseleccionar"
        Me.rb_ptextseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_ptextseleccionar.TabIndex = 3
        Me.rb_ptextseleccionar.Text = "Seleccionar"
        Me.rb_ptextseleccionar.UseVisualStyleBackColor = True
        '
        'rb_ptexttotal
        '
        Me.rb_ptexttotal.AutoSize = True
        Me.rb_ptexttotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_ptexttotal.Name = "rb_ptexttotal"
        Me.rb_ptexttotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_ptexttotal.TabIndex = 2
        Me.rb_ptexttotal.Text = "Total"
        Me.rb_ptexttotal.UseVisualStyleBackColor = True
        '
        'rb_ptextlectura
        '
        Me.rb_ptextlectura.AutoSize = True
        Me.rb_ptextlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_ptextlectura.Name = "rb_ptextlectura"
        Me.rb_ptextlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_ptextlectura.TabIndex = 1
        Me.rb_ptextlectura.Text = "Lectura"
        Me.rb_ptextlectura.UseVisualStyleBackColor = True
        '
        'rb_ptextninguno
        '
        Me.rb_ptextninguno.AutoSize = True
        Me.rb_ptextninguno.Checked = True
        Me.rb_ptextninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_ptextninguno.Name = "rb_ptextninguno"
        Me.rb_ptextninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_ptextninguno.TabIndex = 0
        Me.rb_ptextninguno.TabStop = True
        Me.rb_ptextninguno.Text = "Ninguno"
        Me.rb_ptextninguno.UseVisualStyleBackColor = True
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.rb_paisseleccionar)
        Me.GroupBox19.Controls.Add(Me.rb_paistotal)
        Me.GroupBox19.Controls.Add(Me.rb_paislectura)
        Me.GroupBox19.Controls.Add(Me.rb_paisninguno)
        Me.GroupBox19.Location = New System.Drawing.Point(576, 12)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox19.TabIndex = 11
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Paises"
        '
        'rb_paisseleccionar
        '
        Me.rb_paisseleccionar.AutoSize = True
        Me.rb_paisseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_paisseleccionar.Name = "rb_paisseleccionar"
        Me.rb_paisseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_paisseleccionar.TabIndex = 3
        Me.rb_paisseleccionar.Text = "Seleccionar"
        Me.rb_paisseleccionar.UseVisualStyleBackColor = True
        '
        'rb_paistotal
        '
        Me.rb_paistotal.AutoSize = True
        Me.rb_paistotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_paistotal.Name = "rb_paistotal"
        Me.rb_paistotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_paistotal.TabIndex = 2
        Me.rb_paistotal.Text = "Total"
        Me.rb_paistotal.UseVisualStyleBackColor = True
        '
        'rb_paislectura
        '
        Me.rb_paislectura.AutoSize = True
        Me.rb_paislectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_paislectura.Name = "rb_paislectura"
        Me.rb_paislectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_paislectura.TabIndex = 1
        Me.rb_paislectura.Text = "Lectura"
        Me.rb_paislectura.UseVisualStyleBackColor = True
        '
        'rb_paisninguno
        '
        Me.rb_paisninguno.AutoSize = True
        Me.rb_paisninguno.Checked = True
        Me.rb_paisninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_paisninguno.Name = "rb_paisninguno"
        Me.rb_paisninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_paisninguno.TabIndex = 0
        Me.rb_paisninguno.TabStop = True
        Me.rb_paisninguno.Text = "Ninguno"
        Me.rb_paisninguno.UseVisualStyleBackColor = True
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.rb_fpseleccionar)
        Me.GroupBox20.Controls.Add(Me.rb_fptotal)
        Me.GroupBox20.Controls.Add(Me.rb_fplectura)
        Me.GroupBox20.Controls.Add(Me.rb_fpninguno)
        Me.GroupBox20.Location = New System.Drawing.Point(462, 12)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox20.TabIndex = 10
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Formas de Pago"
        '
        'rb_fpseleccionar
        '
        Me.rb_fpseleccionar.AutoSize = True
        Me.rb_fpseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_fpseleccionar.Name = "rb_fpseleccionar"
        Me.rb_fpseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_fpseleccionar.TabIndex = 3
        Me.rb_fpseleccionar.Text = "Seleccionar"
        Me.rb_fpseleccionar.UseVisualStyleBackColor = True
        '
        'rb_fptotal
        '
        Me.rb_fptotal.AutoSize = True
        Me.rb_fptotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_fptotal.Name = "rb_fptotal"
        Me.rb_fptotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_fptotal.TabIndex = 2
        Me.rb_fptotal.Text = "Total"
        Me.rb_fptotal.UseVisualStyleBackColor = True
        '
        'rb_fplectura
        '
        Me.rb_fplectura.AutoSize = True
        Me.rb_fplectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_fplectura.Name = "rb_fplectura"
        Me.rb_fplectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_fplectura.TabIndex = 1
        Me.rb_fplectura.Text = "Lectura"
        Me.rb_fplectura.UseVisualStyleBackColor = True
        '
        'rb_fpninguno
        '
        Me.rb_fpninguno.AutoSize = True
        Me.rb_fpninguno.Checked = True
        Me.rb_fpninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_fpninguno.Name = "rb_fpninguno"
        Me.rb_fpninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_fpninguno.TabIndex = 0
        Me.rb_fpninguno.TabStop = True
        Me.rb_fpninguno.Text = "Ninguno"
        Me.rb_fpninguno.UseVisualStyleBackColor = True
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.rb_indseleccionar)
        Me.GroupBox21.Controls.Add(Me.rb_indtotal)
        Me.GroupBox21.Controls.Add(Me.rb_indlectura)
        Me.GroupBox21.Controls.Add(Me.rb_indninguno)
        Me.GroupBox21.Location = New System.Drawing.Point(348, 12)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox21.TabIndex = 9
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Indicaciones"
        '
        'rb_indseleccionar
        '
        Me.rb_indseleccionar.AutoSize = True
        Me.rb_indseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_indseleccionar.Name = "rb_indseleccionar"
        Me.rb_indseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_indseleccionar.TabIndex = 3
        Me.rb_indseleccionar.Text = "Seleccionar"
        Me.rb_indseleccionar.UseVisualStyleBackColor = True
        '
        'rb_indtotal
        '
        Me.rb_indtotal.AutoSize = True
        Me.rb_indtotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_indtotal.Name = "rb_indtotal"
        Me.rb_indtotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_indtotal.TabIndex = 2
        Me.rb_indtotal.Text = "Total"
        Me.rb_indtotal.UseVisualStyleBackColor = True
        '
        'rb_indlectura
        '
        Me.rb_indlectura.AutoSize = True
        Me.rb_indlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_indlectura.Name = "rb_indlectura"
        Me.rb_indlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_indlectura.TabIndex = 1
        Me.rb_indlectura.Text = "Lectura"
        Me.rb_indlectura.UseVisualStyleBackColor = True
        '
        'rb_indninguno
        '
        Me.rb_indninguno.AutoSize = True
        Me.rb_indninguno.Checked = True
        Me.rb_indninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_indninguno.Name = "rb_indninguno"
        Me.rb_indninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_indninguno.TabIndex = 0
        Me.rb_indninguno.TabStop = True
        Me.rb_indninguno.Text = "Ninguno"
        Me.rb_indninguno.UseVisualStyleBackColor = True
        '
        'GroupBox25
        '
        Me.GroupBox25.Controls.Add(Me.rb_medseleccionar)
        Me.GroupBox25.Controls.Add(Me.rb_medtotal)
        Me.GroupBox25.Controls.Add(Me.rb_medlectura)
        Me.GroupBox25.Controls.Add(Me.rb_medninguno)
        Me.GroupBox25.Location = New System.Drawing.Point(234, 12)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox25.TabIndex = 8
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Medicamentos"
        '
        'rb_medseleccionar
        '
        Me.rb_medseleccionar.AutoSize = True
        Me.rb_medseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_medseleccionar.Name = "rb_medseleccionar"
        Me.rb_medseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_medseleccionar.TabIndex = 3
        Me.rb_medseleccionar.Text = "Seleccionar"
        Me.rb_medseleccionar.UseVisualStyleBackColor = True
        '
        'rb_medtotal
        '
        Me.rb_medtotal.AutoSize = True
        Me.rb_medtotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_medtotal.Name = "rb_medtotal"
        Me.rb_medtotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_medtotal.TabIndex = 2
        Me.rb_medtotal.Text = "Total"
        Me.rb_medtotal.UseVisualStyleBackColor = True
        '
        'rb_medlectura
        '
        Me.rb_medlectura.AutoSize = True
        Me.rb_medlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_medlectura.Name = "rb_medlectura"
        Me.rb_medlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_medlectura.TabIndex = 1
        Me.rb_medlectura.Text = "Lectura"
        Me.rb_medlectura.UseVisualStyleBackColor = True
        '
        'rb_medninguno
        '
        Me.rb_medninguno.AutoSize = True
        Me.rb_medninguno.Checked = True
        Me.rb_medninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_medninguno.Name = "rb_medninguno"
        Me.rb_medninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_medninguno.TabIndex = 0
        Me.rb_medninguno.TabStop = True
        Me.rb_medninguno.Text = "Ninguno"
        Me.rb_medninguno.UseVisualStyleBackColor = True
        '
        'GroupBox26
        '
        Me.GroupBox26.Controls.Add(Me.rb_diagnosticoseleccionar)
        Me.GroupBox26.Controls.Add(Me.rb_diagnosticototal)
        Me.GroupBox26.Controls.Add(Me.rb_diagnosticolectura)
        Me.GroupBox26.Controls.Add(Me.rb_diagnosticoninguno)
        Me.GroupBox26.Location = New System.Drawing.Point(120, 12)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox26.TabIndex = 7
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Text = "Diagnostico"
        '
        'rb_diagnosticoseleccionar
        '
        Me.rb_diagnosticoseleccionar.AutoSize = True
        Me.rb_diagnosticoseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_diagnosticoseleccionar.Name = "rb_diagnosticoseleccionar"
        Me.rb_diagnosticoseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_diagnosticoseleccionar.TabIndex = 3
        Me.rb_diagnosticoseleccionar.Text = "Seleccionar"
        Me.rb_diagnosticoseleccionar.UseVisualStyleBackColor = True
        '
        'rb_diagnosticototal
        '
        Me.rb_diagnosticototal.AutoSize = True
        Me.rb_diagnosticototal.Location = New System.Drawing.Point(6, 63)
        Me.rb_diagnosticototal.Name = "rb_diagnosticototal"
        Me.rb_diagnosticototal.Size = New System.Drawing.Size(49, 17)
        Me.rb_diagnosticototal.TabIndex = 2
        Me.rb_diagnosticototal.Text = "Total"
        Me.rb_diagnosticototal.UseVisualStyleBackColor = True
        '
        'rb_diagnosticolectura
        '
        Me.rb_diagnosticolectura.AutoSize = True
        Me.rb_diagnosticolectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_diagnosticolectura.Name = "rb_diagnosticolectura"
        Me.rb_diagnosticolectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_diagnosticolectura.TabIndex = 1
        Me.rb_diagnosticolectura.Text = "Lectura"
        Me.rb_diagnosticolectura.UseVisualStyleBackColor = True
        '
        'rb_diagnosticoninguno
        '
        Me.rb_diagnosticoninguno.AutoSize = True
        Me.rb_diagnosticoninguno.Checked = True
        Me.rb_diagnosticoninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_diagnosticoninguno.Name = "rb_diagnosticoninguno"
        Me.rb_diagnosticoninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_diagnosticoninguno.TabIndex = 0
        Me.rb_diagnosticoninguno.TabStop = True
        Me.rb_diagnosticoninguno.Text = "Ninguno"
        Me.rb_diagnosticoninguno.UseVisualStyleBackColor = True
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.rb_alarmaseleccionar)
        Me.GroupBox27.Controls.Add(Me.rb_alarmatotal)
        Me.GroupBox27.Controls.Add(Me.rb_alarmalectura)
        Me.GroupBox27.Controls.Add(Me.rb_alarmaninguno)
        Me.GroupBox27.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox27.TabIndex = 6
        Me.GroupBox27.TabStop = False
        Me.GroupBox27.Text = "Alarmas"
        '
        'rb_alarmaseleccionar
        '
        Me.rb_alarmaseleccionar.AutoSize = True
        Me.rb_alarmaseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_alarmaseleccionar.Name = "rb_alarmaseleccionar"
        Me.rb_alarmaseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_alarmaseleccionar.TabIndex = 3
        Me.rb_alarmaseleccionar.Text = "Seleccionar"
        Me.rb_alarmaseleccionar.UseVisualStyleBackColor = True
        '
        'rb_alarmatotal
        '
        Me.rb_alarmatotal.AutoSize = True
        Me.rb_alarmatotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_alarmatotal.Name = "rb_alarmatotal"
        Me.rb_alarmatotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_alarmatotal.TabIndex = 2
        Me.rb_alarmatotal.Text = "Total"
        Me.rb_alarmatotal.UseVisualStyleBackColor = True
        '
        'rb_alarmalectura
        '
        Me.rb_alarmalectura.AutoSize = True
        Me.rb_alarmalectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_alarmalectura.Name = "rb_alarmalectura"
        Me.rb_alarmalectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_alarmalectura.TabIndex = 1
        Me.rb_alarmalectura.Text = "Lectura"
        Me.rb_alarmalectura.UseVisualStyleBackColor = True
        '
        'rb_alarmaninguno
        '
        Me.rb_alarmaninguno.AutoSize = True
        Me.rb_alarmaninguno.Checked = True
        Me.rb_alarmaninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_alarmaninguno.Name = "rb_alarmaninguno"
        Me.rb_alarmaninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_alarmaninguno.TabIndex = 0
        Me.rb_alarmaninguno.TabStop = True
        Me.rb_alarmaninguno.Text = "Ninguno"
        Me.rb_alarmaninguno.UseVisualStyleBackColor = True
        '
        'tab_utilidades
        '
        Me.tab_utilidades.Controls.Add(Me.GroupBox36)
        Me.tab_utilidades.Controls.Add(Me.GroupBox37)
        Me.tab_utilidades.Controls.Add(Me.GroupBox38)
        Me.tab_utilidades.Controls.Add(Me.GroupBox39)
        Me.tab_utilidades.Location = New System.Drawing.Point(4, 22)
        Me.tab_utilidades.Name = "tab_utilidades"
        Me.tab_utilidades.Size = New System.Drawing.Size(697, 351)
        Me.tab_utilidades.TabIndex = 3
        Me.tab_utilidades.Text = "Utilidades"
        Me.tab_utilidades.UseVisualStyleBackColor = True
        '
        'GroupBox36
        '
        Me.GroupBox36.Controls.Add(Me.rb_etiqseleccionar)
        Me.GroupBox36.Controls.Add(Me.rb_etiqtotal)
        Me.GroupBox36.Controls.Add(Me.rb_etiqlectura)
        Me.GroupBox36.Controls.Add(Me.rb_etiqninguno)
        Me.GroupBox36.Location = New System.Drawing.Point(345, 12)
        Me.GroupBox36.Name = "GroupBox36"
        Me.GroupBox36.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox36.TabIndex = 9
        Me.GroupBox36.TabStop = False
        Me.GroupBox36.Text = "Etiquetas"
        '
        'rb_etiqseleccionar
        '
        Me.rb_etiqseleccionar.AutoSize = True
        Me.rb_etiqseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_etiqseleccionar.Name = "rb_etiqseleccionar"
        Me.rb_etiqseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_etiqseleccionar.TabIndex = 3
        Me.rb_etiqseleccionar.Text = "Seleccionar"
        Me.rb_etiqseleccionar.UseVisualStyleBackColor = True
        '
        'rb_etiqtotal
        '
        Me.rb_etiqtotal.AutoSize = True
        Me.rb_etiqtotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_etiqtotal.Name = "rb_etiqtotal"
        Me.rb_etiqtotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_etiqtotal.TabIndex = 2
        Me.rb_etiqtotal.Text = "Total"
        Me.rb_etiqtotal.UseVisualStyleBackColor = True
        '
        'rb_etiqlectura
        '
        Me.rb_etiqlectura.AutoSize = True
        Me.rb_etiqlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_etiqlectura.Name = "rb_etiqlectura"
        Me.rb_etiqlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_etiqlectura.TabIndex = 1
        Me.rb_etiqlectura.Text = "Lectura"
        Me.rb_etiqlectura.UseVisualStyleBackColor = True
        '
        'rb_etiqninguno
        '
        Me.rb_etiqninguno.AutoSize = True
        Me.rb_etiqninguno.Checked = True
        Me.rb_etiqninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_etiqninguno.Name = "rb_etiqninguno"
        Me.rb_etiqninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_etiqninguno.TabIndex = 0
        Me.rb_etiqninguno.TabStop = True
        Me.rb_etiqninguno.Text = "Ninguno"
        Me.rb_etiqninguno.UseVisualStyleBackColor = True
        '
        'GroupBox37
        '
        Me.GroupBox37.Controls.Add(Me.rb_afactseleccionar)
        Me.GroupBox37.Controls.Add(Me.rb_afacttotal)
        Me.GroupBox37.Controls.Add(Me.rb_afactlectura)
        Me.GroupBox37.Controls.Add(Me.rb_afactninguno)
        Me.GroupBox37.Location = New System.Drawing.Point(231, 12)
        Me.GroupBox37.Name = "GroupBox37"
        Me.GroupBox37.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox37.TabIndex = 8
        Me.GroupBox37.TabStop = False
        Me.GroupBox37.Text = "Añadir factura"
        '
        'rb_afactseleccionar
        '
        Me.rb_afactseleccionar.AutoSize = True
        Me.rb_afactseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_afactseleccionar.Name = "rb_afactseleccionar"
        Me.rb_afactseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_afactseleccionar.TabIndex = 3
        Me.rb_afactseleccionar.Text = "Seleccionar"
        Me.rb_afactseleccionar.UseVisualStyleBackColor = True
        '
        'rb_afacttotal
        '
        Me.rb_afacttotal.AutoSize = True
        Me.rb_afacttotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_afacttotal.Name = "rb_afacttotal"
        Me.rb_afacttotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_afacttotal.TabIndex = 2
        Me.rb_afacttotal.Text = "Total"
        Me.rb_afacttotal.UseVisualStyleBackColor = True
        '
        'rb_afactlectura
        '
        Me.rb_afactlectura.AutoSize = True
        Me.rb_afactlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_afactlectura.Name = "rb_afactlectura"
        Me.rb_afactlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_afactlectura.TabIndex = 1
        Me.rb_afactlectura.Text = "Lectura"
        Me.rb_afactlectura.UseVisualStyleBackColor = True
        '
        'rb_afactninguno
        '
        Me.rb_afactninguno.AutoSize = True
        Me.rb_afactninguno.Checked = True
        Me.rb_afactninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_afactninguno.Name = "rb_afactninguno"
        Me.rb_afactninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_afactninguno.TabIndex = 0
        Me.rb_afactninguno.TabStop = True
        Me.rb_afactninguno.Text = "Ninguno"
        Me.rb_afactninguno.UseVisualStyleBackColor = True
        '
        'GroupBox38
        '
        Me.GroupBox38.Controls.Add(Me.rb_copyseleccionar)
        Me.GroupBox38.Controls.Add(Me.rb_copytotal)
        Me.GroupBox38.Controls.Add(Me.rb_copylectura)
        Me.GroupBox38.Controls.Add(Me.rb_copyninguno)
        Me.GroupBox38.Location = New System.Drawing.Point(117, 12)
        Me.GroupBox38.Name = "GroupBox38"
        Me.GroupBox38.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox38.TabIndex = 7
        Me.GroupBox38.TabStop = False
        Me.GroupBox38.Text = "Copias  seguridad"
        '
        'rb_copyseleccionar
        '
        Me.rb_copyseleccionar.AutoSize = True
        Me.rb_copyseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_copyseleccionar.Name = "rb_copyseleccionar"
        Me.rb_copyseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_copyseleccionar.TabIndex = 3
        Me.rb_copyseleccionar.Text = "Seleccionar"
        Me.rb_copyseleccionar.UseVisualStyleBackColor = True
        '
        'rb_copytotal
        '
        Me.rb_copytotal.AutoSize = True
        Me.rb_copytotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_copytotal.Name = "rb_copytotal"
        Me.rb_copytotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_copytotal.TabIndex = 2
        Me.rb_copytotal.Text = "Total"
        Me.rb_copytotal.UseVisualStyleBackColor = True
        '
        'rb_copylectura
        '
        Me.rb_copylectura.AutoSize = True
        Me.rb_copylectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_copylectura.Name = "rb_copylectura"
        Me.rb_copylectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_copylectura.TabIndex = 1
        Me.rb_copylectura.Text = "Lectura"
        Me.rb_copylectura.UseVisualStyleBackColor = True
        '
        'rb_copyninguno
        '
        Me.rb_copyninguno.AutoSize = True
        Me.rb_copyninguno.Checked = True
        Me.rb_copyninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_copyninguno.Name = "rb_copyninguno"
        Me.rb_copyninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_copyninguno.TabIndex = 0
        Me.rb_copyninguno.TabStop = True
        Me.rb_copyninguno.Text = "Ninguno"
        Me.rb_copyninguno.UseVisualStyleBackColor = True
        '
        'GroupBox39
        '
        Me.GroupBox39.Controls.Add(Me.rb_confseleccionar)
        Me.GroupBox39.Controls.Add(Me.rb_conftotal)
        Me.GroupBox39.Controls.Add(Me.rb_conflectura)
        Me.GroupBox39.Controls.Add(Me.rb_confninguno)
        Me.GroupBox39.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox39.Name = "GroupBox39"
        Me.GroupBox39.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox39.TabIndex = 6
        Me.GroupBox39.TabStop = False
        Me.GroupBox39.Text = "Configuracion"
        '
        'rb_confseleccionar
        '
        Me.rb_confseleccionar.AutoSize = True
        Me.rb_confseleccionar.Location = New System.Drawing.Point(6, 86)
        Me.rb_confseleccionar.Name = "rb_confseleccionar"
        Me.rb_confseleccionar.Size = New System.Drawing.Size(81, 17)
        Me.rb_confseleccionar.TabIndex = 3
        Me.rb_confseleccionar.Text = "Seleccionar"
        Me.rb_confseleccionar.UseVisualStyleBackColor = True
        '
        'rb_conftotal
        '
        Me.rb_conftotal.AutoSize = True
        Me.rb_conftotal.Location = New System.Drawing.Point(6, 63)
        Me.rb_conftotal.Name = "rb_conftotal"
        Me.rb_conftotal.Size = New System.Drawing.Size(49, 17)
        Me.rb_conftotal.TabIndex = 2
        Me.rb_conftotal.Text = "Total"
        Me.rb_conftotal.UseVisualStyleBackColor = True
        '
        'rb_conflectura
        '
        Me.rb_conflectura.AutoSize = True
        Me.rb_conflectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_conflectura.Name = "rb_conflectura"
        Me.rb_conflectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_conflectura.TabIndex = 1
        Me.rb_conflectura.Text = "Lectura"
        Me.rb_conflectura.UseVisualStyleBackColor = True
        '
        'rb_confninguno
        '
        Me.rb_confninguno.AutoSize = True
        Me.rb_confninguno.Checked = True
        Me.rb_confninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_confninguno.Name = "rb_confninguno"
        Me.rb_confninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_confninguno.TabIndex = 0
        Me.rb_confninguno.TabStop = True
        Me.rb_confninguno.Text = "Ninguno"
        Me.rb_confninguno.UseVisualStyleBackColor = True
        '
        'tab_listados
        '
        Me.tab_listados.Controls.Add(Me.GroupBox34)
        Me.tab_listados.Controls.Add(Me.GroupBox35)
        Me.tab_listados.Controls.Add(Me.GroupBox40)
        Me.tab_listados.Controls.Add(Me.GroupBox41)
        Me.tab_listados.Controls.Add(Me.GroupBox42)
        Me.tab_listados.Controls.Add(Me.GroupBox43)
        Me.tab_listados.Location = New System.Drawing.Point(4, 22)
        Me.tab_listados.Name = "tab_listados"
        Me.tab_listados.Size = New System.Drawing.Size(697, 351)
        Me.tab_listados.TabIndex = 4
        Me.tab_listados.Text = "Listados"
        Me.tab_listados.UseVisualStyleBackColor = True
        '
        'GroupBox34
        '
        Me.GroupBox34.Controls.Add(Me.rb_librototal)
        Me.GroupBox34.Controls.Add(Me.rb_librolectura)
        Me.GroupBox34.Controls.Add(Me.rb_libroninguno)
        Me.GroupBox34.Location = New System.Drawing.Point(577, 3)
        Me.GroupBox34.Name = "GroupBox34"
        Me.GroupBox34.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox34.TabIndex = 11
        Me.GroupBox34.TabStop = False
        Me.GroupBox34.Text = "Libro diario"
        '
        'rb_librototal
        '
        Me.rb_librototal.AutoSize = True
        Me.rb_librototal.Location = New System.Drawing.Point(6, 63)
        Me.rb_librototal.Name = "rb_librototal"
        Me.rb_librototal.Size = New System.Drawing.Size(49, 17)
        Me.rb_librototal.TabIndex = 2
        Me.rb_librototal.Text = "Total"
        Me.rb_librototal.UseVisualStyleBackColor = True
        '
        'rb_librolectura
        '
        Me.rb_librolectura.AutoSize = True
        Me.rb_librolectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_librolectura.Name = "rb_librolectura"
        Me.rb_librolectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_librolectura.TabIndex = 1
        Me.rb_librolectura.Text = "Lectura"
        Me.rb_librolectura.UseVisualStyleBackColor = True
        '
        'rb_libroninguno
        '
        Me.rb_libroninguno.AutoSize = True
        Me.rb_libroninguno.Checked = True
        Me.rb_libroninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_libroninguno.Name = "rb_libroninguno"
        Me.rb_libroninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_libroninguno.TabIndex = 0
        Me.rb_libroninguno.TabStop = True
        Me.rb_libroninguno.Text = "Ninguno"
        Me.rb_libroninguno.UseVisualStyleBackColor = True
        '
        'GroupBox35
        '
        Me.GroupBox35.Controls.Add(Me.rb_lcitalectura)
        Me.GroupBox35.Controls.Add(Me.rb_lcitasninguno)
        Me.GroupBox35.Location = New System.Drawing.Point(463, 3)
        Me.GroupBox35.Name = "GroupBox35"
        Me.GroupBox35.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox35.TabIndex = 10
        Me.GroupBox35.TabStop = False
        Me.GroupBox35.Text = "Citas agrupadas"
        '
        'rb_lcitalectura
        '
        Me.rb_lcitalectura.AutoSize = True
        Me.rb_lcitalectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_lcitalectura.Name = "rb_lcitalectura"
        Me.rb_lcitalectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_lcitalectura.TabIndex = 1
        Me.rb_lcitalectura.Text = "Lectura"
        Me.rb_lcitalectura.UseVisualStyleBackColor = True
        '
        'rb_lcitasninguno
        '
        Me.rb_lcitasninguno.AutoSize = True
        Me.rb_lcitasninguno.Checked = True
        Me.rb_lcitasninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_lcitasninguno.Name = "rb_lcitasninguno"
        Me.rb_lcitasninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_lcitasninguno.TabIndex = 0
        Me.rb_lcitasninguno.TabStop = True
        Me.rb_lcitasninguno.Text = "Ninguno"
        Me.rb_lcitasninguno.UseVisualStyleBackColor = True
        '
        'GroupBox40
        '
        Me.GroupBox40.Controls.Add(Me.rb_lasistlectura)
        Me.GroupBox40.Controls.Add(Me.rb_lasistninguno)
        Me.GroupBox40.Location = New System.Drawing.Point(349, 3)
        Me.GroupBox40.Name = "GroupBox40"
        Me.GroupBox40.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox40.TabIndex = 9
        Me.GroupBox40.TabStop = False
        Me.GroupBox40.Text = "Faltas asistencia"
        '
        'rb_lasistlectura
        '
        Me.rb_lasistlectura.AutoSize = True
        Me.rb_lasistlectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_lasistlectura.Name = "rb_lasistlectura"
        Me.rb_lasistlectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_lasistlectura.TabIndex = 1
        Me.rb_lasistlectura.Text = "Lectura"
        Me.rb_lasistlectura.UseVisualStyleBackColor = True
        '
        'rb_lasistninguno
        '
        Me.rb_lasistninguno.AutoSize = True
        Me.rb_lasistninguno.Checked = True
        Me.rb_lasistninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_lasistninguno.Name = "rb_lasistninguno"
        Me.rb_lasistninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_lasistninguno.TabIndex = 0
        Me.rb_lasistninguno.TabStop = True
        Me.rb_lasistninguno.Text = "Ninguno"
        Me.rb_lasistninguno.UseVisualStyleBackColor = True
        '
        'GroupBox41
        '
        Me.GroupBox41.Controls.Add(Me.rb_lrecetalectura)
        Me.GroupBox41.Controls.Add(Me.rb_lrecetaninguno)
        Me.GroupBox41.Location = New System.Drawing.Point(235, 3)
        Me.GroupBox41.Name = "GroupBox41"
        Me.GroupBox41.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox41.TabIndex = 8
        Me.GroupBox41.TabStop = False
        Me.GroupBox41.Text = "Recetas"
        '
        'rb_lrecetalectura
        '
        Me.rb_lrecetalectura.AutoSize = True
        Me.rb_lrecetalectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_lrecetalectura.Name = "rb_lrecetalectura"
        Me.rb_lrecetalectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_lrecetalectura.TabIndex = 1
        Me.rb_lrecetalectura.Text = "Lectura"
        Me.rb_lrecetalectura.UseVisualStyleBackColor = True
        '
        'rb_lrecetaninguno
        '
        Me.rb_lrecetaninguno.AutoSize = True
        Me.rb_lrecetaninguno.Checked = True
        Me.rb_lrecetaninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_lrecetaninguno.Name = "rb_lrecetaninguno"
        Me.rb_lrecetaninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_lrecetaninguno.TabIndex = 0
        Me.rb_lrecetaninguno.TabStop = True
        Me.rb_lrecetaninguno.Text = "Ninguno"
        Me.rb_lrecetaninguno.UseVisualStyleBackColor = True
        '
        'GroupBox42
        '
        Me.GroupBox42.Controls.Add(Me.rb_lpartelectura)
        Me.GroupBox42.Controls.Add(Me.rb_lpartesninguno)
        Me.GroupBox42.Location = New System.Drawing.Point(121, 3)
        Me.GroupBox42.Name = "GroupBox42"
        Me.GroupBox42.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox42.TabIndex = 7
        Me.GroupBox42.TabStop = False
        Me.GroupBox42.Text = "Partes"
        '
        'rb_lpartelectura
        '
        Me.rb_lpartelectura.AutoSize = True
        Me.rb_lpartelectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_lpartelectura.Name = "rb_lpartelectura"
        Me.rb_lpartelectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_lpartelectura.TabIndex = 1
        Me.rb_lpartelectura.Text = "Lectura"
        Me.rb_lpartelectura.UseVisualStyleBackColor = True
        '
        'rb_lpartesninguno
        '
        Me.rb_lpartesninguno.AutoSize = True
        Me.rb_lpartesninguno.Checked = True
        Me.rb_lpartesninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_lpartesninguno.Name = "rb_lpartesninguno"
        Me.rb_lpartesninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_lpartesninguno.TabIndex = 0
        Me.rb_lpartesninguno.TabStop = True
        Me.rb_lpartesninguno.Text = "Ninguno"
        Me.rb_lpartesninguno.UseVisualStyleBackColor = True
        '
        'GroupBox43
        '
        Me.GroupBox43.Controls.Add(Me.rb_lfacturalectura)
        Me.GroupBox43.Controls.Add(Me.rb_lfacturaninguno)
        Me.GroupBox43.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox43.Name = "GroupBox43"
        Me.GroupBox43.Size = New System.Drawing.Size(108, 109)
        Me.GroupBox43.TabIndex = 6
        Me.GroupBox43.TabStop = False
        Me.GroupBox43.Text = "Facturas"
        '
        'rb_lfacturalectura
        '
        Me.rb_lfacturalectura.AutoSize = True
        Me.rb_lfacturalectura.Location = New System.Drawing.Point(6, 40)
        Me.rb_lfacturalectura.Name = "rb_lfacturalectura"
        Me.rb_lfacturalectura.Size = New System.Drawing.Size(61, 17)
        Me.rb_lfacturalectura.TabIndex = 1
        Me.rb_lfacturalectura.Text = "Lectura"
        Me.rb_lfacturalectura.UseVisualStyleBackColor = True
        '
        'rb_lfacturaninguno
        '
        Me.rb_lfacturaninguno.AutoSize = True
        Me.rb_lfacturaninguno.Checked = True
        Me.rb_lfacturaninguno.Location = New System.Drawing.Point(6, 19)
        Me.rb_lfacturaninguno.Name = "rb_lfacturaninguno"
        Me.rb_lfacturaninguno.Size = New System.Drawing.Size(65, 17)
        Me.rb_lfacturaninguno.TabIndex = 0
        Me.rb_lfacturaninguno.TabStop = True
        Me.rb_lfacturaninguno.Text = "Ninguno"
        Me.rb_lfacturaninguno.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(642, 523)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancel.TabIndex = 90
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(561, 523)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 89
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'USUARIOSTableAdapter
        '
        Me.USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'MEDICOSBindingSource
        '
        Me.MEDICOSBindingSource.DataMember = "MEDICOS"
        Me.MEDICOSBindingSource.DataSource = Me.CMDataSet
        '
        'PERMISOS_USUARIOBindingSource
        '
        Me.PERMISOS_USUARIOBindingSource.DataMember = "PERMISOS_USUARIO"
        Me.PERMISOS_USUARIOBindingSource.DataSource = Me.CMDataSet
        '
        'PERMISOS_USUARIOTableAdapter
        '
        Me.PERMISOS_USUARIOTableAdapter.ClearBeforeFill = True
        '
        'PERMISOSBindingSource
        '
        Me.PERMISOSBindingSource.DataMember = "PERMISOS"
        Me.PERMISOSBindingSource.DataSource = Me.CMDataSet
        '
        'PERMISOSTableAdapter
        '
        Me.PERMISOSTableAdapter.ClearBeforeFill = True
        '
        'tb_certificadoPath
        '
        Me.tb_certificadoPath.AcceptsReturn = True
        Me.tb_certificadoPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "CERTIFICADOPATH", True))
        Me.tb_certificadoPath.Location = New System.Drawing.Point(566, 85)
        Me.tb_certificadoPath.MaxLength = 15
        Me.tb_certificadoPath.Name = "tb_certificadoPath"
        Me.tb_certificadoPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_certificadoPath.Size = New System.Drawing.Size(151, 20)
        Me.tb_certificadoPath.TabIndex = 91
        Me.tb_certificadoPath.UseSystemPasswordChar = True
        '
        'form_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(721, 549)
        Me.Controls.Add(Me.tb_certificadoPath)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_medico)
        Me.Controls.Add(Me.bt_medico)
        Me.Controls.Add(Me.tb_idmedico)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.tb_rcontrasena)
        Me.Controls.Add(ADMINISTRADORLabel)
        Me.Controls.Add(Me.chb_admin)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.tb_cod)
        Me.Controls.Add(USUARIOLabel)
        Me.Controls.Add(Me.tb_user)
        Me.Controls.Add(CONTRASENALabel)
        Me.Controls.Add(Me.tb_contrasena)
        Me.Controls.Add(NOMBRECOMPLETOLabel)
        Me.Controls.Add(Me.tb_nombre)
        Me.Name = "form_user"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Usuarios"
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_clinica.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tab_pacientes.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.tab_mantenimiento.ResumeLayout(False)
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox28.PerformLayout()
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox29.PerformLayout()
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox30.PerformLayout()
        Me.GroupBox31.ResumeLayout(False)
        Me.GroupBox31.PerformLayout()
        Me.GroupBox32.ResumeLayout(False)
        Me.GroupBox32.PerformLayout()
        Me.GroupBox33.ResumeLayout(False)
        Me.GroupBox33.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        Me.GroupBox26.ResumeLayout(False)
        Me.GroupBox26.PerformLayout()
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox27.PerformLayout()
        Me.tab_utilidades.ResumeLayout(False)
        Me.GroupBox36.ResumeLayout(False)
        Me.GroupBox36.PerformLayout()
        Me.GroupBox37.ResumeLayout(False)
        Me.GroupBox37.PerformLayout()
        Me.GroupBox38.ResumeLayout(False)
        Me.GroupBox38.PerformLayout()
        Me.GroupBox39.ResumeLayout(False)
        Me.GroupBox39.PerformLayout()
        Me.tab_listados.ResumeLayout(False)
        Me.GroupBox34.ResumeLayout(False)
        Me.GroupBox34.PerformLayout()
        Me.GroupBox35.ResumeLayout(False)
        Me.GroupBox35.PerformLayout()
        Me.GroupBox40.ResumeLayout(False)
        Me.GroupBox40.PerformLayout()
        Me.GroupBox41.ResumeLayout(False)
        Me.GroupBox41.PerformLayout()
        Me.GroupBox42.ResumeLayout(False)
        Me.GroupBox42.PerformLayout()
        Me.GroupBox43.ResumeLayout(False)
        Me.GroupBox43.PerformLayout()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERMISOS_USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERMISOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents USUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USUARIOSTableAdapter As centro_medico.CMDataSetTableAdapters.USUARIOSTableAdapter
    Friend WithEvents tb_cod As ctrlTextboxAvanzado
    Friend WithEvents tb_user As ctrlTextboxAvanzado
    Friend WithEvents tb_contrasena As ctrlTextboxAvanzado
    Friend WithEvents tb_nombre As ctrlTextboxAvanzado
    Friend WithEvents chb_admin As System.Windows.Forms.CheckBox
    Friend WithEvents tb_rcontrasena As ctrlTextboxAvanzado
    Public WithEvents lb_medico As System.Windows.Forms.Label
    Public WithEvents bt_medico As System.Windows.Forms.Button
    Public WithEvents tb_idmedico As ctrlTextboxAvanzado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_clinica As System.Windows.Forms.TabPage
    Friend WithEvents tab_pacientes As System.Windows.Forms.TabPage
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents tab_mantenimiento As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_gastosseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_gastostotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_gastoslectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_gastosninguno As System.Windows.Forms.RadioButton
    Friend WithEvents tab_utilidades As System.Windows.Forms.TabPage
    Friend WithEvents tab_listados As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_proveedoresseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_proveedorestotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_proveedoreslectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_proveedoresninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_mutuasseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_mutuastotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_mutuaslectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_mutuasninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_medicosseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_medicostotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_medicoslectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_medicosninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_bancosseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_bancostotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_bancoslectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_bancosninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_articuloseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_articulototal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_articulolectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_articuloninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_revseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_revtotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_revlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_revninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_ficheroseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ficherototal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ficherolectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ficheroninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_remseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_remtotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_remlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_remninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_genrecseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_genrectotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_genreclectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_genrecninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_reciboseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recibototal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recibolectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_reciboninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_analseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_analtotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_anallectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_analninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_infoseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_infototal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_infolectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_infoninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_asistseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_asisttotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_asistlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_asistninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_bajaseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_bajatotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_bajalectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_bajaninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_histseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_histtotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_histlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_histninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_citaseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_citatotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_citalectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_citaninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents rb_recetaseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recetatotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recetalectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recetaninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_facturaseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_facturatotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_facturalectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_facturaninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_empresaseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_empresatotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_empresaslectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_empresasninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_pacientesseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pacientestotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pacienteslectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pacientesninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox28 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_clinicaseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_clinicatotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_clinicalectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_clinicaninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox29 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_phistseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_phisttotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_phistlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_phistninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox30 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_modseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_modtotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_modlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_modninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox31 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_panalseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_panaltotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_panallectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_panalninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox32 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_conceptseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_concepttotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_conceptlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_conceptninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox33 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_ptextseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ptexttotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ptextlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ptextninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_paisseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_paistotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_paislectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_paisninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_fpseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fptotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fplectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fpninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_indseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_indtotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_indlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_indninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox25 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_medseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_medtotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_medlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_medninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox26 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_diagnosticoseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_diagnosticototal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_diagnosticolectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_diagnosticoninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox27 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_alarmaseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_alarmatotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_alarmalectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_alarmaninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox36 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_etiqseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_etiqtotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_etiqlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_etiqninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox37 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_afactseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_afacttotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_afactlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_afactninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox38 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_copyseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_copytotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_copylectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_copyninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox39 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_confseleccionar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_conftotal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_conflectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_confninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox34 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_librototal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_librolectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_libroninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox35 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_lcitalectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_lcitasninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox40 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_lasistlectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_lasistninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox41 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_lrecetalectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_lrecetaninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox42 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_lpartelectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_lpartesninguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox43 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_lfacturalectura As System.Windows.Forms.RadioButton
    Friend WithEvents rb_lfacturaninguno As System.Windows.Forms.RadioButton
    Friend WithEvents MEDICOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents MEDICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERMISOS_USUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERMISOS_USUARIOTableAdapter As centro_medico.CMDataSetTableAdapters.PERMISOS_USUARIOTableAdapter
    Friend WithEvents PERMISOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERMISOSTableAdapter As centro_medico.CMDataSetTableAdapters.PERMISOSTableAdapter
    Friend WithEvents tb_certificadoPath As centro_medico.ctrlTextboxAvanzado
End Class
