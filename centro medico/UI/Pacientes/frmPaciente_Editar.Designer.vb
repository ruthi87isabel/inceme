<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaciente_Editar
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
        Dim lb_dpComonosconocio As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim lb_dpFechabaja As System.Windows.Forms.Label
        Dim lb_dpFallecido As System.Windows.Forms.Label
        Dim lb_dpActivo As System.Windows.Forms.Label
        Dim lb_dpNss As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim lbl_Email As System.Windows.Forms.Label
        Dim lb_dpTutorlegal As System.Windows.Forms.Label
        Dim lb_dpNie As System.Windows.Forms.Label
        Dim lb_dpPasaporte As System.Windows.Forms.Label
        Dim lb_dpMovil As System.Windows.Forms.Label
        Dim lb_dpProvincia As System.Windows.Forms.Label
        Dim lb_dpTlfno As System.Windows.Forms.Label
        Dim lb_dpPoblac As System.Windows.Forms.Label
        Dim lb_dpCodigopostal As System.Windows.Forms.Label
        Dim lb_dpSexo As System.Windows.Forms.Label
        Dim lb_dpEdad As System.Windows.Forms.Label
        Dim lb_dpFechanac As System.Windows.Forms.Label
        Dim lb_dpDomicilio As System.Windows.Forms.Label
        Dim lb_dpDni As System.Windows.Forms.Label
        Dim lb_hlRegimen As System.Windows.Forms.Label
        Dim lb_hlPuesto As System.Windows.Forms.Label
        Dim lb_hlProfesion As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaciente_Editar))
        Dim GridEXSocios_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXContactos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXMutuas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXEmpresas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageDetalles = New System.Windows.Forms.TabPage()
        Me.webcam = New System.Windows.Forms.Button()
        Me.gb_dpDatPer = New System.Windows.Forms.GroupBox()
        Me.lb_dpLetradni = New System.Windows.Forms.Label()
        Me.tb_web = New centro_medico.ctrlTextboxAvanzado()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_dpCodigopostal = New centro_medico.ctrlTextboxAvanzado()
        Me.CtrlPaises1 = New centro_medico.ctrlPaises()
        Me.tb_Email = New centro_medico.ctrlTextboxAvanzado()
        Me.dtp_dpFeNac = New System.Windows.Forms.DateTimePicker()
        Me.tb_dpTutorLegal = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_dpNie = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_dpPasaporte = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_dpMovil = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_dpProvincia = New centro_medico.ctrlTextboxAvanzado()
        Me.cb_dpSexo = New System.Windows.Forms.ComboBox()
        Me.tb_dpTlfno = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_dpPoblacion = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_dpEdad = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_dpDni = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_domicilio = New centro_medico.ctrlTextboxAvanzado()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gb_dpObservaciones = New System.Windows.Forms.GroupBox()
        Me.tb_dpObservaciones = New centro_medico.ctrlTextboxAvanzado()
        Me.lblCodigoPaciente = New System.Windows.Forms.Label()
        Me.lbl_Apellido2 = New System.Windows.Forms.Label()
        Me.tb_CodigoPaciente = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_Nombre = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_CodigoPropio = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_Apellido2 = New centro_medico.ctrlTextboxAvanzado()
        Me.lblCodigoPropio = New System.Windows.Forms.Label()
        Me.pb_dpImagen = New System.Windows.Forms.PictureBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.tb_Apellido1 = New centro_medico.ctrlTextboxAvanzado()
        Me.lbl_Apellido1 = New System.Windows.Forms.Label()
        Me.gb_dpDatosadmin = New System.Windows.Forms.GroupBox()
        Me.dtpsociohasta = New System.Windows.Forms.DateTimePicker()
        Me.CtrlMutua1 = New centro_medico.ctrlMutuaMejorado()
        Me.CtrlEmpresa1 = New centro_medico.ctrlEmpresa()
        Me.cb_comoconocio = New System.Windows.Forms.ComboBox()
        Me.pnlBeneficiario = New System.Windows.Forms.Panel()
        Me.lblFechaValidoBeneficiario = New System.Windows.Forms.Label()
        Me.lblValido = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSocioBeneficiario = New System.Windows.Forms.Label()
        Me.txtNomSocio = New centro_medico.ctrlTextboxAvanzado()
        Me.txtParentescoSocio = New centro_medico.ctrlTextboxAvanzado()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_dpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_dpFechabaja = New System.Windows.Forms.DateTimePicker()
        Me.chb_dpFallecido = New System.Windows.Forms.CheckBox()
        Me.chb_dpAsociado = New System.Windows.Forms.CheckBox()
        Me.chb_dpActivo = New System.Windows.Forms.CheckBox()
        Me.tb_dpTarsanit = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_dpNss = New centro_medico.ctrlTextboxAvanzado()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpAsociados = New System.Windows.Forms.GroupBox()
        Me.btnRemoveSocio = New System.Windows.Forms.Button()
        Me.btnAddSocio = New System.Windows.Forms.Button()
        Me.GridEXSocios = New Janus.Windows.GridEX.GridEX()
        Me.AsociadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_ADD = New System.Windows.Forms.Button()
        Me.GridEXContactos = New Janus.Windows.GridEX.GridEX()
        Me.ContactosPacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HClinico = New System.Windows.Forms.TabPage()
        Me.tsEmpresas = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.tstMutuas = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstAnnadir_Tratamiento = New System.Windows.Forms.ToolStripButton()
        Me.tst_Modificar_Tratamiento = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar_Tratamiento = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.cb_hlRegimen = New System.Windows.Forms.ComboBox()
        Me.GridEXMutuas = New Janus.Windows.GridEX.GridEX()
        Me.LMUTUABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEXEmpresas = New Janus.Windows.GridEX.GridEX()
        Me.LEMPRESABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_hlPuesto = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_hlProfesion = New centro_medico.ctrlTextboxAvanzado()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ComoConocioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblEliminado = New System.Windows.Forms.Label()
        lb_dpComonosconocio = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        lb_dpFechabaja = New System.Windows.Forms.Label()
        lb_dpFallecido = New System.Windows.Forms.Label()
        lb_dpActivo = New System.Windows.Forms.Label()
        lb_dpNss = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        lbl_Email = New System.Windows.Forms.Label()
        lb_dpTutorlegal = New System.Windows.Forms.Label()
        lb_dpNie = New System.Windows.Forms.Label()
        lb_dpPasaporte = New System.Windows.Forms.Label()
        lb_dpMovil = New System.Windows.Forms.Label()
        lb_dpProvincia = New System.Windows.Forms.Label()
        lb_dpTlfno = New System.Windows.Forms.Label()
        lb_dpPoblac = New System.Windows.Forms.Label()
        lb_dpCodigopostal = New System.Windows.Forms.Label()
        lb_dpSexo = New System.Windows.Forms.Label()
        lb_dpEdad = New System.Windows.Forms.Label()
        lb_dpFechanac = New System.Windows.Forms.Label()
        lb_dpDomicilio = New System.Windows.Forms.Label()
        lb_dpDni = New System.Windows.Forms.Label()
        lb_hlRegimen = New System.Windows.Forms.Label()
        lb_hlPuesto = New System.Windows.Forms.Label()
        lb_hlProfesion = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPageDetalles.SuspendLayout()
        Me.gb_dpDatPer.SuspendLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_dpObservaciones.SuspendLayout()
        CType(Me.pb_dpImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_dpDatosadmin.SuspendLayout()
        Me.pnlBeneficiario.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpAsociados.SuspendLayout()
        CType(Me.GridEXSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsociadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridEXContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactosPacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HClinico.SuspendLayout()
        Me.tsEmpresas.SuspendLayout()
        Me.tstMutuas.SuspendLayout()
        CType(Me.GridEXMutuas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMUTUABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEMPRESABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.ComoConocioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_dpComonosconocio
        '
        lb_dpComonosconocio.AutoSize = True
        lb_dpComonosconocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpComonosconocio.Location = New System.Drawing.Point(523, 32)
        lb_dpComonosconocio.Name = "lb_dpComonosconocio"
        lb_dpComonosconocio.Size = New System.Drawing.Size(95, 13)
        lb_dpComonosconocio.TabIndex = 17
        lb_dpComonosconocio.Text = "Cómo nos conoció"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(329, 32)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(73, 13)
        Label1.TabIndex = 5
        Label1.Text = "Fecha de Alta"
        '
        'lb_dpFechabaja
        '
        lb_dpFechabaja.AutoSize = True
        lb_dpFechabaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpFechabaja.Location = New System.Drawing.Point(326, 60)
        lb_dpFechabaja.Name = "lb_dpFechabaja"
        lb_dpFechabaja.Size = New System.Drawing.Size(76, 13)
        lb_dpFechabaja.TabIndex = 6
        lb_dpFechabaja.Text = "Fecha de Baja"
        '
        'lb_dpFallecido
        '
        lb_dpFallecido.AutoSize = True
        lb_dpFallecido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpFallecido.Location = New System.Drawing.Point(254, 62)
        lb_dpFallecido.Name = "lb_dpFallecido"
        lb_dpFallecido.Size = New System.Drawing.Size(49, 13)
        lb_dpFallecido.TabIndex = 4
        lb_dpFallecido.Text = "Fallecido"
        '
        'lb_dpActivo
        '
        lb_dpActivo.AutoSize = True
        lb_dpActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpActivo.Location = New System.Drawing.Point(254, 32)
        lb_dpActivo.Name = "lb_dpActivo"
        lb_dpActivo.Size = New System.Drawing.Size(52, 13)
        lb_dpActivo.TabIndex = 3
        lb_dpActivo.Text = "En activo"
        '
        'lb_dpNss
        '
        lb_dpNss.AutoSize = True
        lb_dpNss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpNss.Location = New System.Drawing.Point(46, 36)
        lb_dpNss.Name = "lb_dpNss"
        lb_dpNss.Size = New System.Drawing.Size(41, 13)
        lb_dpNss.TabIndex = 2
        lb_dpNss.Text = "No. SS"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(396, 81)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(33, 13)
        Label3.TabIndex = 35
        Label3.Text = "Web:"
        '
        'lbl_Email
        '
        lbl_Email.AutoSize = True
        lbl_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl_Email.Location = New System.Drawing.Point(237, 81)
        lbl_Email.Name = "lbl_Email"
        lbl_Email.Size = New System.Drawing.Size(35, 13)
        lbl_Email.TabIndex = 33
        lbl_Email.Text = "Email:"
        '
        'lb_dpTutorlegal
        '
        lb_dpTutorlegal.AutoSize = True
        lb_dpTutorlegal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpTutorlegal.Location = New System.Drawing.Point(555, 133)
        lb_dpTutorlegal.Name = "lb_dpTutorlegal"
        lb_dpTutorlegal.Size = New System.Drawing.Size(64, 13)
        lb_dpTutorlegal.TabIndex = 27
        lb_dpTutorlegal.Text = "Tutor Legal:"
        '
        'lb_dpNie
        '
        lb_dpNie.AutoSize = True
        lb_dpNie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpNie.Location = New System.Drawing.Point(435, 132)
        lb_dpNie.Name = "lb_dpNie"
        lb_dpNie.Size = New System.Drawing.Size(37, 13)
        lb_dpNie.TabIndex = 25
        lb_dpNie.Text = "N.I.E.:"
        '
        'lb_dpPasaporte
        '
        lb_dpPasaporte.AutoSize = True
        lb_dpPasaporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpPasaporte.Location = New System.Drawing.Point(297, 133)
        lb_dpPasaporte.Name = "lb_dpPasaporte"
        lb_dpPasaporte.Size = New System.Drawing.Size(58, 13)
        lb_dpPasaporte.TabIndex = 23
        lb_dpPasaporte.Text = "Pasaporte:"
        '
        'lb_dpMovil
        '
        lb_dpMovil.AutoSize = True
        lb_dpMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpMovil.Location = New System.Drawing.Point(128, 81)
        lb_dpMovil.Name = "lb_dpMovil"
        lb_dpMovil.Size = New System.Drawing.Size(35, 13)
        lb_dpMovil.TabIndex = 19
        lb_dpMovil.Text = "Móvil:"
        '
        'lb_dpProvincia
        '
        lb_dpProvincia.AutoSize = True
        lb_dpProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpProvincia.Location = New System.Drawing.Point(396, 30)
        lb_dpProvincia.Name = "lb_dpProvincia"
        lb_dpProvincia.Size = New System.Drawing.Size(54, 13)
        lb_dpProvincia.TabIndex = 17
        lb_dpProvincia.Text = "Provincia:"
        '
        'lb_dpTlfno
        '
        lb_dpTlfno.AutoSize = True
        lb_dpTlfno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpTlfno.Location = New System.Drawing.Point(17, 84)
        lb_dpTlfno.Name = "lb_dpTlfno"
        lb_dpTlfno.Size = New System.Drawing.Size(52, 13)
        lb_dpTlfno.TabIndex = 14
        lb_dpTlfno.Text = "Teléfono:"
        '
        'lb_dpPoblac
        '
        lb_dpPoblac.AutoSize = True
        lb_dpPoblac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpPoblac.Location = New System.Drawing.Point(255, 30)
        lb_dpPoblac.Name = "lb_dpPoblac"
        lb_dpPoblac.Size = New System.Drawing.Size(57, 13)
        lb_dpPoblac.TabIndex = 13
        lb_dpPoblac.Text = "Población:"
        '
        'lb_dpCodigopostal
        '
        lb_dpCodigopostal.AutoSize = True
        lb_dpCodigopostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpCodigopostal.Location = New System.Drawing.Point(545, 30)
        lb_dpCodigopostal.Name = "lb_dpCodigopostal"
        lb_dpCodigopostal.Size = New System.Drawing.Size(52, 13)
        lb_dpCodigopostal.TabIndex = 12
        lb_dpCodigopostal.Text = "C. Postal:"
        '
        'lb_dpSexo
        '
        lb_dpSexo.AutoSize = True
        lb_dpSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpSexo.Location = New System.Drawing.Point(647, 30)
        lb_dpSexo.Name = "lb_dpSexo"
        lb_dpSexo.Size = New System.Drawing.Size(34, 13)
        lb_dpSexo.TabIndex = 11
        lb_dpSexo.Text = "Sexo:"
        '
        'lb_dpEdad
        '
        lb_dpEdad.AutoSize = True
        lb_dpEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpEdad.Location = New System.Drawing.Point(128, 132)
        lb_dpEdad.Name = "lb_dpEdad"
        lb_dpEdad.Size = New System.Drawing.Size(35, 13)
        lb_dpEdad.TabIndex = 7
        lb_dpEdad.Text = "Edad:"
        '
        'lb_dpFechanac
        '
        lb_dpFechanac.AutoSize = True
        lb_dpFechanac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpFechanac.Location = New System.Drawing.Point(17, 132)
        lb_dpFechanac.Name = "lb_dpFechanac"
        lb_dpFechanac.Size = New System.Drawing.Size(63, 13)
        lb_dpFechanac.TabIndex = 5
        lb_dpFechanac.Text = "Fecha Nac:"
        '
        'lb_dpDomicilio
        '
        lb_dpDomicilio.AutoSize = True
        lb_dpDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpDomicilio.Location = New System.Drawing.Point(17, 30)
        lb_dpDomicilio.Name = "lb_dpDomicilio"
        lb_dpDomicilio.Size = New System.Drawing.Size(52, 13)
        lb_dpDomicilio.TabIndex = 16
        lb_dpDomicilio.Text = "Domicilio:"
        '
        'lb_dpDni
        '
        lb_dpDni.AutoSize = True
        lb_dpDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpDni.Location = New System.Drawing.Point(189, 132)
        lb_dpDni.Name = "lb_dpDni"
        lb_dpDni.Size = New System.Drawing.Size(29, 13)
        lb_dpDni.TabIndex = 2
        lb_dpDni.Text = "DNI:"
        '
        'lb_hlRegimen
        '
        lb_hlRegimen.AutoSize = True
        lb_hlRegimen.Location = New System.Drawing.Point(608, 504)
        lb_hlRegimen.Name = "lb_hlRegimen"
        lb_hlRegimen.Size = New System.Drawing.Size(49, 13)
        lb_hlRegimen.TabIndex = 40
        lb_hlRegimen.Text = "Régimen"
        lb_hlRegimen.Visible = False
        '
        'lb_hlPuesto
        '
        lb_hlPuesto.AutoSize = True
        lb_hlPuesto.Location = New System.Drawing.Point(415, 504)
        lb_hlPuesto.Name = "lb_hlPuesto"
        lb_hlPuesto.Size = New System.Drawing.Size(40, 13)
        lb_hlPuesto.TabIndex = 38
        lb_hlPuesto.Text = "Puesto"
        lb_hlPuesto.Visible = False
        '
        'lb_hlProfesion
        '
        lb_hlProfesion.AutoSize = True
        lb_hlProfesion.Location = New System.Drawing.Point(197, 503)
        lb_hlProfesion.Name = "lb_hlProfesion"
        lb_hlProfesion.Size = New System.Drawing.Size(51, 13)
        lb_hlProfesion.TabIndex = 36
        lb_hlProfesion.Text = "Profesión"
        lb_hlProfesion.Visible = False
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(545, 81)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(30, 13)
        Label2.TabIndex = 35
        Label2.Text = "Pais:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageDetalles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.HClinico)
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(930, 558)
        Me.TabControl1.TabIndex = 1
        '
        'TabPageDetalles
        '
        Me.TabPageDetalles.BackColor = System.Drawing.SystemColors.Window
        Me.TabPageDetalles.Controls.Add(Me.webcam)
        Me.TabPageDetalles.Controls.Add(Me.gb_dpDatPer)
        Me.TabPageDetalles.Controls.Add(Me.Button1)
        Me.TabPageDetalles.Controls.Add(Me.Button2)
        Me.TabPageDetalles.Controls.Add(Me.gb_dpObservaciones)
        Me.TabPageDetalles.Controls.Add(Me.lblCodigoPaciente)
        Me.TabPageDetalles.Controls.Add(Me.lbl_Apellido2)
        Me.TabPageDetalles.Controls.Add(Me.tb_CodigoPaciente)
        Me.TabPageDetalles.Controls.Add(Me.tb_Nombre)
        Me.TabPageDetalles.Controls.Add(Me.tb_CodigoPropio)
        Me.TabPageDetalles.Controls.Add(Me.tb_Apellido2)
        Me.TabPageDetalles.Controls.Add(Me.lblCodigoPropio)
        Me.TabPageDetalles.Controls.Add(Me.pb_dpImagen)
        Me.TabPageDetalles.Controls.Add(Me.lbl_Nombre)
        Me.TabPageDetalles.Controls.Add(Me.tb_Apellido1)
        Me.TabPageDetalles.Controls.Add(Me.lbl_Apellido1)
        Me.TabPageDetalles.Controls.Add(Me.gb_dpDatosadmin)
        Me.TabPageDetalles.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDetalles.Name = "TabPageDetalles"
        Me.TabPageDetalles.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDetalles.Size = New System.Drawing.Size(922, 532)
        Me.TabPageDetalles.TabIndex = 0
        Me.TabPageDetalles.Text = "Detalles"
        '
        'webcam
        '
        Me.webcam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.webcam.FlatAppearance.BorderSize = 0
        Me.webcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.webcam.Image = Global.centro_medico.My.Resources.Resources.webcam
        Me.webcam.Location = New System.Drawing.Point(847, 141)
        Me.webcam.Name = "webcam"
        Me.webcam.Size = New System.Drawing.Size(16, 16)
        Me.webcam.TabIndex = 63
        Me.webcam.TabStop = False
        Me.webcam.UseVisualStyleBackColor = True
        '
        'gb_dpDatPer
        '
        Me.gb_dpDatPer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_dpDatPer.BackColor = System.Drawing.SystemColors.Window
        Me.gb_dpDatPer.Controls.Add(Me.lb_dpLetradni)
        Me.gb_dpDatPer.Controls.Add(Me.tb_web)
        Me.gb_dpDatPer.Controls.Add(Me.tb_dpCodigopostal)
        Me.gb_dpDatPer.Controls.Add(Me.CtrlPaises1)
        Me.gb_dpDatPer.Controls.Add(Label2)
        Me.gb_dpDatPer.Controls.Add(Label3)
        Me.gb_dpDatPer.Controls.Add(lbl_Email)
        Me.gb_dpDatPer.Controls.Add(Me.tb_Email)
        Me.gb_dpDatPer.Controls.Add(Me.dtp_dpFeNac)
        Me.gb_dpDatPer.Controls.Add(lb_dpTutorlegal)
        Me.gb_dpDatPer.Controls.Add(Me.tb_dpTutorLegal)
        Me.gb_dpDatPer.Controls.Add(lb_dpNie)
        Me.gb_dpDatPer.Controls.Add(Me.tb_dpNie)
        Me.gb_dpDatPer.Controls.Add(lb_dpPasaporte)
        Me.gb_dpDatPer.Controls.Add(Me.tb_dpPasaporte)
        Me.gb_dpDatPer.Controls.Add(lb_dpMovil)
        Me.gb_dpDatPer.Controls.Add(Me.tb_dpMovil)
        Me.gb_dpDatPer.Controls.Add(lb_dpProvincia)
        Me.gb_dpDatPer.Controls.Add(Me.tb_dpProvincia)
        Me.gb_dpDatPer.Controls.Add(lb_dpSexo)
        Me.gb_dpDatPer.Controls.Add(lb_dpTlfno)
        Me.gb_dpDatPer.Controls.Add(Me.cb_dpSexo)
        Me.gb_dpDatPer.Controls.Add(Me.tb_dpTlfno)
        Me.gb_dpDatPer.Controls.Add(lb_dpFechanac)
        Me.gb_dpDatPer.Controls.Add(lb_dpPoblac)
        Me.gb_dpDatPer.Controls.Add(Me.tb_dpPoblacion)
        Me.gb_dpDatPer.Controls.Add(lb_dpCodigopostal)
        Me.gb_dpDatPer.Controls.Add(lb_dpEdad)
        Me.gb_dpDatPer.Controls.Add(Me.tb_dpEdad)
        Me.gb_dpDatPer.Controls.Add(Me.tb_dpDni)
        Me.gb_dpDatPer.Controls.Add(lb_dpDomicilio)
        Me.gb_dpDatPer.Controls.Add(Me.tb_domicilio)
        Me.gb_dpDatPer.Controls.Add(lb_dpDni)
        Me.gb_dpDatPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_dpDatPer.Location = New System.Drawing.Point(6, 67)
        Me.gb_dpDatPer.Name = "gb_dpDatPer"
        Me.gb_dpDatPer.Size = New System.Drawing.Size(773, 188)
        Me.gb_dpDatPer.TabIndex = 5
        Me.gb_dpDatPer.TabStop = False
        Me.gb_dpDatPer.Tag = ""
        Me.gb_dpDatPer.Text = "Datos de contacto"
        '
        'lb_dpLetradni
        '
        Me.lb_dpLetradni.BackColor = System.Drawing.Color.Silver
        Me.lb_dpLetradni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_dpLetradni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dpLetradni.Location = New System.Drawing.Point(268, 149)
        Me.lb_dpLetradni.Name = "lb_dpLetradni"
        Me.lb_dpLetradni.Size = New System.Drawing.Size(22, 20)
        Me.lb_dpLetradni.TabIndex = 36
        Me.lb_dpLetradni.Text = "-"
        Me.lb_dpLetradni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_web
        '
        Me.tb_web.AcceptsReturn = True
        Me.tb_web.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "WEB", True))
        Me.tb_web.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_web.Location = New System.Drawing.Point(399, 100)
        Me.tb_web.MaxLength = 200
        Me.tb_web.Name = "tb_web"
        Me.tb_web.Size = New System.Drawing.Size(139, 20)
        Me.tb_web.TabIndex = 9
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataSource = GetType(centro_medico.PACIENTE)
        '
        'tb_dpCodigopostal
        '
        Me.tb_dpCodigopostal.AcceptsReturn = True
        Me.tb_dpCodigopostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "CP", True))
        Me.tb_dpCodigopostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpCodigopostal.Location = New System.Drawing.Point(544, 48)
        Me.tb_dpCodigopostal.MaxLength = 5
        Me.tb_dpCodigopostal.Name = "tb_dpCodigopostal"
        Me.tb_dpCodigopostal.Size = New System.Drawing.Size(93, 20)
        Me.tb_dpCodigopostal.TabIndex = 4
        '
        'CtrlPaises1
        '
        Me.CtrlPaises1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PAISES", Me.PACIENTESBindingSource, "REFPAIS", True))
        Me.CtrlPaises1.ID_PAISES = Nothing
        Me.CtrlPaises1.Location = New System.Drawing.Point(509, 97)
        Me.CtrlPaises1.Name = "CtrlPaises1"
        Me.CtrlPaises1.Size = New System.Drawing.Size(258, 25)
        Me.CtrlPaises1.TabIndex = 10
        '
        'tb_Email
        '
        Me.tb_Email.AcceptsReturn = True
        Me.tb_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tb_Email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "EMAIL", True))
        Me.tb_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Email.Location = New System.Drawing.Point(236, 100)
        Me.tb_Email.MaxLength = 200
        Me.tb_Email.Name = "tb_Email"
        Me.tb_Email.Size = New System.Drawing.Size(157, 20)
        Me.tb_Email.TabIndex = 8
        '
        'dtp_dpFeNac
        '
        Me.dtp_dpFeNac.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PACIENTESBindingSource, "FECHAN", True))
        Me.dtp_dpFeNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_dpFeNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dpFeNac.Location = New System.Drawing.Point(20, 149)
        Me.dtp_dpFeNac.Name = "dtp_dpFeNac"
        Me.dtp_dpFeNac.Size = New System.Drawing.Size(92, 20)
        Me.dtp_dpFeNac.TabIndex = 11
        '
        'tb_dpTutorLegal
        '
        Me.tb_dpTutorLegal.AcceptsReturn = True
        Me.tb_dpTutorLegal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "TUTOR", True))
        Me.tb_dpTutorLegal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpTutorLegal.Location = New System.Drawing.Point(553, 149)
        Me.tb_dpTutorLegal.MaxLength = 90
        Me.tb_dpTutorLegal.Name = "tb_dpTutorLegal"
        Me.tb_dpTutorLegal.Size = New System.Drawing.Size(214, 20)
        Me.tb_dpTutorLegal.TabIndex = 16
        '
        'tb_dpNie
        '
        Me.tb_dpNie.AcceptsReturn = True
        Me.tb_dpNie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NIE", True))
        Me.tb_dpNie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpNie.Location = New System.Drawing.Point(438, 148)
        Me.tb_dpNie.MaxLength = 15
        Me.tb_dpNie.Name = "tb_dpNie"
        Me.tb_dpNie.Size = New System.Drawing.Size(97, 20)
        Me.tb_dpNie.TabIndex = 15
        '
        'tb_dpPasaporte
        '
        Me.tb_dpPasaporte.AcceptsReturn = True
        Me.tb_dpPasaporte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "PASAPORTE", True))
        Me.tb_dpPasaporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpPasaporte.Location = New System.Drawing.Point(300, 149)
        Me.tb_dpPasaporte.MaxLength = 25
        Me.tb_dpPasaporte.Name = "tb_dpPasaporte"
        Me.tb_dpPasaporte.Size = New System.Drawing.Size(124, 20)
        Me.tb_dpPasaporte.TabIndex = 14
        '
        'tb_dpMovil
        '
        Me.tb_dpMovil.AcceptsReturn = True
        Me.tb_dpMovil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "MOVIL", True))
        Me.tb_dpMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpMovil.Location = New System.Drawing.Point(129, 100)
        Me.tb_dpMovil.MaxLength = 200
        Me.tb_dpMovil.Name = "tb_dpMovil"
        Me.tb_dpMovil.Size = New System.Drawing.Size(99, 20)
        Me.tb_dpMovil.TabIndex = 7
        '
        'tb_dpProvincia
        '
        Me.tb_dpProvincia.AcceptsReturn = True
        Me.tb_dpProvincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "PROVINCIA", True))
        Me.tb_dpProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpProvincia.Location = New System.Drawing.Point(399, 48)
        Me.tb_dpProvincia.MaxLength = 300
        Me.tb_dpProvincia.Name = "tb_dpProvincia"
        Me.tb_dpProvincia.Size = New System.Drawing.Size(139, 20)
        Me.tb_dpProvincia.TabIndex = 3
        '
        'cb_dpSexo
        '
        Me.cb_dpSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_dpSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_dpSexo.FormattingEnabled = True
        Me.cb_dpSexo.Location = New System.Drawing.Point(650, 47)
        Me.cb_dpSexo.Name = "cb_dpSexo"
        Me.cb_dpSexo.Size = New System.Drawing.Size(95, 21)
        Me.cb_dpSexo.TabIndex = 5
        '
        'tb_dpTlfno
        '
        Me.tb_dpTlfno.AcceptsReturn = True
        Me.tb_dpTlfno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "TLFNO", True))
        Me.tb_dpTlfno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpTlfno.Location = New System.Drawing.Point(20, 100)
        Me.tb_dpTlfno.MaxLength = 200
        Me.tb_dpTlfno.Name = "tb_dpTlfno"
        Me.tb_dpTlfno.Size = New System.Drawing.Size(100, 20)
        Me.tb_dpTlfno.TabIndex = 6
        '
        'tb_dpPoblacion
        '
        Me.tb_dpPoblacion.AcceptsReturn = True
        Me.tb_dpPoblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "LOCALIDAD", True))
        Me.tb_dpPoblacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpPoblacion.Location = New System.Drawing.Point(253, 48)
        Me.tb_dpPoblacion.MaxLength = 200
        Me.tb_dpPoblacion.Name = "tb_dpPoblacion"
        Me.tb_dpPoblacion.Size = New System.Drawing.Size(140, 20)
        Me.tb_dpPoblacion.TabIndex = 2
        '
        'tb_dpEdad
        '
        Me.tb_dpEdad.AcceptsReturn = True
        Me.tb_dpEdad.BackColor = System.Drawing.SystemColors.Info
        Me.tb_dpEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpEdad.Location = New System.Drawing.Point(129, 149)
        Me.tb_dpEdad.Name = "tb_dpEdad"
        Me.tb_dpEdad.ReadOnly = True
        Me.tb_dpEdad.Size = New System.Drawing.Size(39, 20)
        Me.tb_dpEdad.TabIndex = 12
        '
        'tb_dpDni
        '
        Me.tb_dpDni.AcceptsReturn = True
        Me.tb_dpDni.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "DNI", True))
        Me.tb_dpDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpDni.Location = New System.Drawing.Point(185, 148)
        Me.tb_dpDni.MaxLength = 8
        Me.tb_dpDni.Name = "tb_dpDni"
        Me.tb_dpDni.Size = New System.Drawing.Size(80, 20)
        Me.tb_dpDni.TabIndex = 13
        '
        'tb_domicilio
        '
        Me.tb_domicilio.AcceptsReturn = True
        Me.tb_domicilio.AccessibleDescription = "l"
        Me.tb_domicilio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "DOMICILIO", True))
        Me.tb_domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_domicilio.Location = New System.Drawing.Point(19, 48)
        Me.tb_domicilio.MaxLength = 150
        Me.tb_domicilio.Name = "tb_domicilio"
        Me.tb_domicilio.Size = New System.Drawing.Size(228, 20)
        Me.tb_domicilio.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(889, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 16)
        Me.Button1.TabIndex = 9
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(869, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(16, 16)
        Me.Button2.TabIndex = 8
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = True
        '
        'gb_dpObservaciones
        '
        Me.gb_dpObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_dpObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.gb_dpObservaciones.Controls.Add(Me.tb_dpObservaciones)
        Me.gb_dpObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_dpObservaciones.Location = New System.Drawing.Point(6, 430)
        Me.gb_dpObservaciones.Name = "gb_dpObservaciones"
        Me.gb_dpObservaciones.Size = New System.Drawing.Size(910, 94)
        Me.gb_dpObservaciones.TabIndex = 7
        Me.gb_dpObservaciones.TabStop = False
        Me.gb_dpObservaciones.Text = "Observaciones"
        '
        'tb_dpObservaciones
        '
        Me.tb_dpObservaciones.AcceptsReturn = True
        Me.tb_dpObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_dpObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "OBSERVACIONES", True))
        Me.tb_dpObservaciones.Location = New System.Drawing.Point(6, 19)
        Me.tb_dpObservaciones.MaxLength = 2147483647
        Me.tb_dpObservaciones.Multiline = True
        Me.tb_dpObservaciones.Name = "tb_dpObservaciones"
        Me.tb_dpObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_dpObservaciones.Size = New System.Drawing.Size(893, 69)
        Me.tb_dpObservaciones.TabIndex = 0
        '
        'lblCodigoPaciente
        '
        Me.lblCodigoPaciente.AutoSize = True
        Me.lblCodigoPaciente.Location = New System.Drawing.Point(110, 15)
        Me.lblCodigoPaciente.Name = "lblCodigoPaciente"
        Me.lblCodigoPaciente.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigoPaciente.TabIndex = 0
        Me.lblCodigoPaciente.Text = "Código"
        '
        'lbl_Apellido2
        '
        Me.lbl_Apellido2.AutoSize = True
        Me.lbl_Apellido2.Location = New System.Drawing.Point(377, 15)
        Me.lbl_Apellido2.Name = "lbl_Apellido2"
        Me.lbl_Apellido2.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Apellido2.TabIndex = 60
        Me.lbl_Apellido2.Text = "Apellido2"
        '
        'tb_CodigoPaciente
        '
        Me.tb_CodigoPaciente.AcceptsReturn = True
        Me.tb_CodigoPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "CPACIENTE", True))
        Me.tb_CodigoPaciente.Location = New System.Drawing.Point(112, 32)
        Me.tb_CodigoPaciente.Name = "tb_CodigoPaciente"
        Me.tb_CodigoPaciente.ReadOnly = True
        Me.tb_CodigoPaciente.Size = New System.Drawing.Size(47, 20)
        Me.tb_CodigoPaciente.TabIndex = 1
        '
        'tb_Nombre
        '
        Me.tb_Nombre.AcceptsReturn = True
        Me.tb_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NOMBRE", True))
        Me.tb_Nombre.Location = New System.Drawing.Point(544, 32)
        Me.tb_Nombre.MaxLength = 255
        Me.tb_Nombre.Name = "tb_Nombre"
        Me.tb_Nombre.Size = New System.Drawing.Size(147, 20)
        Me.tb_Nombre.TabIndex = 4
        '
        'tb_CodigoPropio
        '
        Me.tb_CodigoPropio.AcceptsReturn = True
        Me.tb_CodigoPropio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "CODIGOPROPIO", True))
        Me.tb_CodigoPropio.Location = New System.Drawing.Point(25, 32)
        Me.tb_CodigoPropio.Name = "tb_CodigoPropio"
        Me.tb_CodigoPropio.Size = New System.Drawing.Size(70, 20)
        Me.tb_CodigoPropio.TabIndex = 0
        '
        'tb_Apellido2
        '
        Me.tb_Apellido2.AcceptsReturn = True
        Me.tb_Apellido2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO2", True))
        Me.tb_Apellido2.Location = New System.Drawing.Point(377, 32)
        Me.tb_Apellido2.MaxLength = 255
        Me.tb_Apellido2.Name = "tb_Apellido2"
        Me.tb_Apellido2.Size = New System.Drawing.Size(147, 20)
        Me.tb_Apellido2.TabIndex = 3
        '
        'lblCodigoPropio
        '
        Me.lblCodigoPropio.AutoSize = True
        Me.lblCodigoPropio.Location = New System.Drawing.Point(22, 15)
        Me.lblCodigoPropio.Name = "lblCodigoPropio"
        Me.lblCodigoPropio.Size = New System.Drawing.Size(53, 13)
        Me.lblCodigoPropio.TabIndex = 56
        Me.lblCodigoPropio.Text = "C. Propio:"
        '
        'pb_dpImagen
        '
        Me.pb_dpImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_dpImagen.BackgroundImage = Global.centro_medico.My.Resources.Resources.male14
        Me.pb_dpImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_dpImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_dpImagen.Location = New System.Drawing.Point(785, 15)
        Me.pb_dpImagen.Name = "pb_dpImagen"
        Me.pb_dpImagen.Size = New System.Drawing.Size(120, 120)
        Me.pb_dpImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_dpImagen.TabIndex = 45
        Me.pb_dpImagen.TabStop = False
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(541, 16)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 62
        Me.lbl_Nombre.Text = "Nombre"
        '
        'tb_Apellido1
        '
        Me.tb_Apellido1.AcceptsReturn = True
        Me.tb_Apellido1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO1", True))
        Me.tb_Apellido1.Location = New System.Drawing.Point(185, 32)
        Me.tb_Apellido1.MaxLength = 255
        Me.tb_Apellido1.Name = "tb_Apellido1"
        Me.tb_Apellido1.Size = New System.Drawing.Size(176, 20)
        Me.tb_Apellido1.TabIndex = 2
        '
        'lbl_Apellido1
        '
        Me.lbl_Apellido1.AutoSize = True
        Me.lbl_Apellido1.Location = New System.Drawing.Point(182, 15)
        Me.lbl_Apellido1.Name = "lbl_Apellido1"
        Me.lbl_Apellido1.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Apellido1.TabIndex = 16
        Me.lbl_Apellido1.Text = "Apellido1:"
        '
        'gb_dpDatosadmin
        '
        Me.gb_dpDatosadmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_dpDatosadmin.BackColor = System.Drawing.SystemColors.Window
        Me.gb_dpDatosadmin.Controls.Add(Me.dtpsociohasta)
        Me.gb_dpDatosadmin.Controls.Add(Me.CtrlMutua1)
        Me.gb_dpDatosadmin.Controls.Add(Me.CtrlEmpresa1)
        Me.gb_dpDatosadmin.Controls.Add(Me.cb_comoconocio)
        Me.gb_dpDatosadmin.Controls.Add(Me.pnlBeneficiario)
        Me.gb_dpDatosadmin.Controls.Add(lb_dpComonosconocio)
        Me.gb_dpDatosadmin.Controls.Add(Label1)
        Me.gb_dpDatosadmin.Controls.Add(lb_dpFechabaja)
        Me.gb_dpDatosadmin.Controls.Add(Me.dtp_dpFechaAlta)
        Me.gb_dpDatosadmin.Controls.Add(Me.dtp_dpFechabaja)
        Me.gb_dpDatosadmin.Controls.Add(lb_dpFallecido)
        Me.gb_dpDatosadmin.Controls.Add(Me.chb_dpFallecido)
        Me.gb_dpDatosadmin.Controls.Add(Me.chb_dpAsociado)
        Me.gb_dpDatosadmin.Controls.Add(lb_dpActivo)
        Me.gb_dpDatosadmin.Controls.Add(Me.chb_dpActivo)
        Me.gb_dpDatosadmin.Controls.Add(Me.tb_dpTarsanit)
        Me.gb_dpDatosadmin.Controls.Add(lb_dpNss)
        Me.gb_dpDatosadmin.Controls.Add(Me.tb_dpNss)
        Me.gb_dpDatosadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_dpDatosadmin.Location = New System.Drawing.Point(7, 261)
        Me.gb_dpDatosadmin.Name = "gb_dpDatosadmin"
        Me.gb_dpDatosadmin.Size = New System.Drawing.Size(910, 163)
        Me.gb_dpDatosadmin.TabIndex = 6
        Me.gb_dpDatosadmin.TabStop = False
        Me.gb_dpDatosadmin.Text = "Datos Administrativos"
        '
        'dtpsociohasta
        '
        Me.dtpsociohasta.AccessibleDescription = "Define hasta que fecha es socio el paciente"
        Me.dtpsociohasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PACIENTESBindingSource, "SOCIOVALIDOHASTA", True))
        Me.dtpsociohasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsociohasta.Location = New System.Drawing.Point(598, 95)
        Me.dtpsociohasta.Name = "dtpsociohasta"
        Me.dtpsociohasta.Size = New System.Drawing.Size(86, 20)
        Me.dtpsociohasta.TabIndex = 66
        Me.dtpsociohasta.Visible = False
        '
        'CtrlMutua1
        '
        Me.CtrlMutua1.ID_MUTUA = Nothing
        Me.CtrlMutua1.Location = New System.Drawing.Point(42, 123)
        Me.CtrlMutua1.Name = "CtrlMutua1"
        Me.CtrlMutua1.Size = New System.Drawing.Size(378, 29)
        Me.CtrlMutua1.TabIndex = 65
        '
        'CtrlEmpresa1
        '
        Me.CtrlEmpresa1.DataBindings.Add(New System.Windows.Forms.Binding("ID_EMPRESAS", Me.PACIENTESBindingSource, "REFEMPRESA", True))
        Me.CtrlEmpresa1.DataBindings.Add(New System.Windows.Forms.Binding("IDPACIENTE", Me.PACIENTESBindingSource, "CPACIENTE", True))
        Me.CtrlEmpresa1.EsEmpresaPorDefecto = True
        Me.CtrlEmpresa1.ID_EMPRESAS = Nothing
        Me.CtrlEmpresa1.IDPACIENTE = Nothing
        Me.CtrlEmpresa1.Location = New System.Drawing.Point(38, 93)
        Me.CtrlEmpresa1.Name = "CtrlEmpresa1"
        Me.CtrlEmpresa1.Size = New System.Drawing.Size(383, 25)
        Me.CtrlEmpresa1.TabIndex = 9
        '
        'cb_comoconocio
        '
        Me.cb_comoconocio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PACIENTESBindingSource, "CONOCIO", True))
        Me.cb_comoconocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_comoconocio.FormattingEnabled = True
        Me.cb_comoconocio.Location = New System.Drawing.Point(526, 51)
        Me.cb_comoconocio.Name = "cb_comoconocio"
        Me.cb_comoconocio.Size = New System.Drawing.Size(158, 21)
        Me.cb_comoconocio.TabIndex = 7
        '
        'pnlBeneficiario
        '
        Me.pnlBeneficiario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBeneficiario.Controls.Add(Me.lblFechaValidoBeneficiario)
        Me.pnlBeneficiario.Controls.Add(Me.lblValido)
        Me.pnlBeneficiario.Controls.Add(Me.Label6)
        Me.pnlBeneficiario.Controls.Add(Me.lblSocioBeneficiario)
        Me.pnlBeneficiario.Controls.Add(Me.txtNomSocio)
        Me.pnlBeneficiario.Controls.Add(Me.txtParentescoSocio)
        Me.pnlBeneficiario.Controls.Add(Me.Label7)
        Me.pnlBeneficiario.Location = New System.Drawing.Point(690, 19)
        Me.pnlBeneficiario.Name = "pnlBeneficiario"
        Me.pnlBeneficiario.Size = New System.Drawing.Size(208, 138)
        Me.pnlBeneficiario.TabIndex = 63
        Me.pnlBeneficiario.Visible = False
        '
        'lblFechaValidoBeneficiario
        '
        Me.lblFechaValidoBeneficiario.AutoSize = True
        Me.lblFechaValidoBeneficiario.Location = New System.Drawing.Point(74, 122)
        Me.lblFechaValidoBeneficiario.Name = "lblFechaValidoBeneficiario"
        Me.lblFechaValidoBeneficiario.Size = New System.Drawing.Size(16, 13)
        Me.lblFechaValidoBeneficiario.TabIndex = 51
        Me.lblFechaValidoBeneficiario.Text = "..."
        '
        'lblValido
        '
        Me.lblValido.AutoSize = True
        Me.lblValido.Location = New System.Drawing.Point(6, 122)
        Me.lblValido.Name = "lblValido"
        Me.lblValido.Size = New System.Drawing.Size(68, 13)
        Me.lblValido.TabIndex = 50
        Me.lblValido.Text = "Válido hasta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Beneficiario del socio:"
        '
        'lblSocioBeneficiario
        '
        Me.lblSocioBeneficiario.Location = New System.Drawing.Point(3, 28)
        Me.lblSocioBeneficiario.Name = "lblSocioBeneficiario"
        Me.lblSocioBeneficiario.Size = New System.Drawing.Size(196, 18)
        Me.lblSocioBeneficiario.TabIndex = 0
        Me.lblSocioBeneficiario.Text = "0000"
        '
        'txtNomSocio
        '
        Me.txtNomSocio.AcceptsReturn = True
        Me.txtNomSocio.Location = New System.Drawing.Point(6, 48)
        Me.txtNomSocio.Name = "txtNomSocio"
        Me.txtNomSocio.ReadOnly = True
        Me.txtNomSocio.Size = New System.Drawing.Size(193, 20)
        Me.txtNomSocio.TabIndex = 1
        '
        'txtParentescoSocio
        '
        Me.txtParentescoSocio.AcceptsReturn = True
        Me.txtParentescoSocio.Location = New System.Drawing.Point(6, 87)
        Me.txtParentescoSocio.Name = "txtParentescoSocio"
        Me.txtParentescoSocio.ReadOnly = True
        Me.txtParentescoSocio.Size = New System.Drawing.Size(193, 20)
        Me.txtParentescoSocio.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Parentesco con el socio:"
        '
        'dtp_dpFechaAlta
        '
        Me.dtp_dpFechaAlta.Checked = False
        Me.dtp_dpFechaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_dpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dpFechaAlta.Location = New System.Drawing.Point(408, 30)
        Me.dtp_dpFechaAlta.Name = "dtp_dpFechaAlta"
        Me.dtp_dpFechaAlta.ShowCheckBox = True
        Me.dtp_dpFechaAlta.Size = New System.Drawing.Size(97, 20)
        Me.dtp_dpFechaAlta.TabIndex = 5
        '
        'dtp_dpFechabaja
        '
        Me.dtp_dpFechabaja.Checked = False
        Me.dtp_dpFechabaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_dpFechabaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dpFechabaja.Location = New System.Drawing.Point(408, 58)
        Me.dtp_dpFechabaja.Name = "dtp_dpFechabaja"
        Me.dtp_dpFechabaja.ShowCheckBox = True
        Me.dtp_dpFechabaja.Size = New System.Drawing.Size(97, 20)
        Me.dtp_dpFechabaja.TabIndex = 6
        '
        'chb_dpFallecido
        '
        Me.chb_dpFallecido.Location = New System.Drawing.Point(234, 57)
        Me.chb_dpFallecido.Name = "chb_dpFallecido"
        Me.chb_dpFallecido.Size = New System.Drawing.Size(18, 24)
        Me.chb_dpFallecido.TabIndex = 4
        '
        'chb_dpAsociado
        '
        Me.chb_dpAsociado.Location = New System.Drawing.Point(526, 93)
        Me.chb_dpAsociado.Name = "chb_dpAsociado"
        Me.chb_dpAsociado.Size = New System.Drawing.Size(78, 24)
        Me.chb_dpAsociado.TabIndex = 10
        Me.chb_dpAsociado.Text = "Asociado"
        Me.chb_dpAsociado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chb_dpActivo
        '
        Me.chb_dpActivo.Location = New System.Drawing.Point(234, 27)
        Me.chb_dpActivo.Name = "chb_dpActivo"
        Me.chb_dpActivo.Size = New System.Drawing.Size(17, 24)
        Me.chb_dpActivo.TabIndex = 3
        Me.chb_dpActivo.Text = "En activo"
        '
        'tb_dpTarsanit
        '
        Me.tb_dpTarsanit.AcceptsReturn = True
        Me.tb_dpTarsanit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "TARJETASANITARIA", True))
        Me.tb_dpTarsanit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpTarsanit.Location = New System.Drawing.Point(93, 64)
        Me.tb_dpTarsanit.MaxLength = 50
        Me.tb_dpTarsanit.Name = "tb_dpTarsanit"
        Me.tb_dpTarsanit.Size = New System.Drawing.Size(120, 20)
        Me.tb_dpTarsanit.TabIndex = 2
        '
        'tb_dpNss
        '
        Me.tb_dpNss.AcceptsReturn = True
        Me.tb_dpNss.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NSS", True))
        Me.tb_dpNss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpNss.Location = New System.Drawing.Point(95, 33)
        Me.tb_dpNss.MaxLength = 12
        Me.tb_dpNss.Name = "tb_dpNss"
        Me.tb_dpNss.Size = New System.Drawing.Size(122, 20)
        Me.tb_dpNss.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Window
        Me.TabPage2.Controls.Add(Me.grpAsociados)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(922, 532)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Otros datos"
        '
        'grpAsociados
        '
        Me.grpAsociados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpAsociados.Controls.Add(Me.btnRemoveSocio)
        Me.grpAsociados.Controls.Add(Me.btnAddSocio)
        Me.grpAsociados.Controls.Add(Me.GridEXSocios)
        Me.grpAsociados.Location = New System.Drawing.Point(9, 277)
        Me.grpAsociados.Name = "grpAsociados"
        Me.grpAsociados.Size = New System.Drawing.Size(396, 190)
        Me.grpAsociados.TabIndex = 3
        Me.grpAsociados.TabStop = False
        Me.grpAsociados.Text = "Socios Beneficiarios"
        Me.grpAsociados.Visible = False
        '
        'btnRemoveSocio
        '
        Me.btnRemoveSocio.BackgroundImage = CType(resources.GetObject("btnRemoveSocio.BackgroundImage"), System.Drawing.Image)
        Me.btnRemoveSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemoveSocio.FlatAppearance.BorderSize = 0
        Me.btnRemoveSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveSocio.Location = New System.Drawing.Point(39, 24)
        Me.btnRemoveSocio.Name = "btnRemoveSocio"
        Me.btnRemoveSocio.Size = New System.Drawing.Size(16, 16)
        Me.btnRemoveSocio.TabIndex = 7
        Me.btnRemoveSocio.UseVisualStyleBackColor = True
        '
        'btnAddSocio
        '
        Me.btnAddSocio.BackgroundImage = CType(resources.GetObject("btnAddSocio.BackgroundImage"), System.Drawing.Image)
        Me.btnAddSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddSocio.FlatAppearance.BorderSize = 0
        Me.btnAddSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSocio.Location = New System.Drawing.Point(17, 24)
        Me.btnAddSocio.Name = "btnAddSocio"
        Me.btnAddSocio.Size = New System.Drawing.Size(16, 16)
        Me.btnAddSocio.TabIndex = 5
        Me.btnAddSocio.UseVisualStyleBackColor = True
        '
        'GridEXSocios
        '
        Me.GridEXSocios.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXSocios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridEXSocios.ColumnAutoResize = True
        Me.GridEXSocios.DataSource = Me.AsociadoBindingSource
        GridEXSocios_DesignTimeLayout.LayoutString = resources.GetString("GridEXSocios_DesignTimeLayout.LayoutString")
        Me.GridEXSocios.DesignTimeLayout = GridEXSocios_DesignTimeLayout
        Me.GridEXSocios.GroupByBoxVisible = False
        Me.GridEXSocios.Location = New System.Drawing.Point(14, 43)
        Me.GridEXSocios.Name = "GridEXSocios"
        Me.GridEXSocios.Size = New System.Drawing.Size(376, 141)
        Me.GridEXSocios.TabIndex = 1
        Me.GridEXSocios.TabStop = False
        '
        'AsociadoBindingSource
        '
        Me.AsociadoBindingSource.DataSource = GetType(centro_medico.Asociado)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_Edit)
        Me.GroupBox1.Controls.Add(Me.btn_ADD)
        Me.GroupBox1.Controls.Add(Me.GridEXContactos)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 239)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contactos del Paciente"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackgroundImage = CType(resources.GetObject("btn_Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Eliminar.FlatAppearance.BorderSize = 0
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Location = New System.Drawing.Point(61, 24)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(16, 16)
        Me.btn_Eliminar.TabIndex = 7
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Edit.FlatAppearance.BorderSize = 0
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Location = New System.Drawing.Point(39, 24)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(16, 16)
        Me.btn_Edit.TabIndex = 6
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_ADD
        '
        Me.btn_ADD.BackgroundImage = CType(resources.GetObject("btn_ADD.BackgroundImage"), System.Drawing.Image)
        Me.btn_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ADD.FlatAppearance.BorderSize = 0
        Me.btn_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ADD.Location = New System.Drawing.Point(17, 24)
        Me.btn_ADD.Name = "btn_ADD"
        Me.btn_ADD.Size = New System.Drawing.Size(16, 16)
        Me.btn_ADD.TabIndex = 5
        Me.btn_ADD.UseVisualStyleBackColor = True
        '
        'GridEXContactos
        '
        Me.GridEXContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXContactos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXContactos.ColumnAutoResize = True
        Me.GridEXContactos.DataSource = Me.ContactosPacienteBindingSource
        GridEXContactos_DesignTimeLayout.LayoutString = resources.GetString("GridEXContactos_DesignTimeLayout.LayoutString")
        Me.GridEXContactos.DesignTimeLayout = GridEXContactos_DesignTimeLayout
        Me.GridEXContactos.GroupByBoxVisible = False
        Me.GridEXContactos.Location = New System.Drawing.Point(14, 43)
        Me.GridEXContactos.Name = "GridEXContactos"
        Me.GridEXContactos.Size = New System.Drawing.Size(879, 178)
        Me.GridEXContactos.TabIndex = 1
        Me.GridEXContactos.TabStop = False
        '
        'ContactosPacienteBindingSource
        '
        Me.ContactosPacienteBindingSource.DataSource = GetType(centro_medico.ContactosPaciente)
        '
        'HClinico
        '
        Me.HClinico.BackColor = System.Drawing.SystemColors.Window
        Me.HClinico.Controls.Add(Me.tsEmpresas)
        Me.HClinico.Controls.Add(Me.tstMutuas)
        Me.HClinico.Controls.Add(lb_hlRegimen)
        Me.HClinico.Controls.Add(Me.cb_hlRegimen)
        Me.HClinico.Controls.Add(lb_hlPuesto)
        Me.HClinico.Controls.Add(lb_hlProfesion)
        Me.HClinico.Controls.Add(Me.GridEXMutuas)
        Me.HClinico.Controls.Add(Me.GridEXEmpresas)
        Me.HClinico.Controls.Add(Me.tb_hlPuesto)
        Me.HClinico.Controls.Add(Me.tb_hlProfesion)
        Me.HClinico.Location = New System.Drawing.Point(4, 22)
        Me.HClinico.Name = "HClinico"
        Me.HClinico.Padding = New System.Windows.Forms.Padding(3)
        Me.HClinico.Size = New System.Drawing.Size(922, 532)
        Me.HClinico.TabIndex = 2
        Me.HClinico.Text = "Historial Laboral"
        '
        'tsEmpresas
        '
        Me.tsEmpresas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsEmpresas.AutoSize = False
        Me.tsEmpresas.Dock = System.Windows.Forms.DockStyle.None
        Me.tsEmpresas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5})
        Me.tsEmpresas.Location = New System.Drawing.Point(8, 244)
        Me.tsEmpresas.Name = "tsEmpresas"
        Me.tsEmpresas.Size = New System.Drawing.Size(908, 25)
        Me.tsEmpresas.TabIndex = 48
        Me.tsEmpresas.Text = "ToolStrip3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel1.Text = "Empresas :"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton2.Text = "&Añadir"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton3.Text = "&Modificar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton4.Text = "&Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.ToolStripButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton5.Text = "Principal"
        Me.ToolStripButton5.ToolTipText = "Marcar como principal"
        '
        'tstMutuas
        '
        Me.tstMutuas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tstMutuas.AutoSize = False
        Me.tstMutuas.Dock = System.Windows.Forms.DockStyle.None
        Me.tstMutuas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator4, Me.tstAnnadir_Tratamiento, Me.tst_Modificar_Tratamiento, Me.tst_Eliminar_Tratamiento, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.tstMutuas.Location = New System.Drawing.Point(8, 13)
        Me.tstMutuas.Name = "tstMutuas"
        Me.tstMutuas.Size = New System.Drawing.Size(908, 25)
        Me.tstMutuas.TabIndex = 47
        Me.tstMutuas.Text = "ToolStrip3"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel2.Text = "Mutuas : "
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tstAnnadir_Tratamiento
        '
        Me.tstAnnadir_Tratamiento.Image = CType(resources.GetObject("tstAnnadir_Tratamiento.Image"), System.Drawing.Image)
        Me.tstAnnadir_Tratamiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstAnnadir_Tratamiento.Name = "tstAnnadir_Tratamiento"
        Me.tstAnnadir_Tratamiento.Size = New System.Drawing.Size(62, 22)
        Me.tstAnnadir_Tratamiento.Text = "&Añadir"
        '
        'tst_Modificar_Tratamiento
        '
        Me.tst_Modificar_Tratamiento.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Modificar_Tratamiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Modificar_Tratamiento.Name = "tst_Modificar_Tratamiento"
        Me.tst_Modificar_Tratamiento.Size = New System.Drawing.Size(78, 22)
        Me.tst_Modificar_Tratamiento.Text = "&Modificar"
        '
        'tst_Eliminar_Tratamiento
        '
        Me.tst_Eliminar_Tratamiento.Image = CType(resources.GetObject("tst_Eliminar_Tratamiento.Image"), System.Drawing.Image)
        Me.tst_Eliminar_Tratamiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar_Tratamiento.Name = "tst_Eliminar_Tratamiento"
        Me.tst_Eliminar_Tratamiento.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar_Tratamiento.Text = "&Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "Principal"
        Me.ToolStripButton1.ToolTipText = "Marcar como principal"
        '
        'cb_hlRegimen
        '
        Me.cb_hlRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_hlRegimen.FormattingEnabled = True
        Me.cb_hlRegimen.Items.AddRange(New Object() {"General", "Agricultura c/ propia", "Agricultura c/ ajena", "Mar", "Minería carbón"})
        Me.cb_hlRegimen.Location = New System.Drawing.Point(663, 497)
        Me.cb_hlRegimen.Name = "cb_hlRegimen"
        Me.cb_hlRegimen.Size = New System.Drawing.Size(130, 21)
        Me.cb_hlRegimen.TabIndex = 2
        Me.cb_hlRegimen.Visible = False
        '
        'GridEXMutuas
        '
        Me.GridEXMutuas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXMutuas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXMutuas.ColumnAutoResize = True
        Me.GridEXMutuas.DataSource = Me.LMUTUABindingSource
        GridEXMutuas_DesignTimeLayout.LayoutString = resources.GetString("GridEXMutuas_DesignTimeLayout.LayoutString")
        Me.GridEXMutuas.DesignTimeLayout = GridEXMutuas_DesignTimeLayout
        Me.GridEXMutuas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXMutuas.GroupByBoxVisible = False
        Me.GridEXMutuas.Location = New System.Drawing.Point(8, 38)
        Me.GridEXMutuas.Name = "GridEXMutuas"
        Me.GridEXMutuas.Size = New System.Drawing.Size(908, 182)
        Me.GridEXMutuas.TabIndex = 13
        Me.GridEXMutuas.TabStop = False
        '
        'LMUTUABindingSource
        '
        Me.LMUTUABindingSource.DataSource = GetType(centro_medico.LMUTUA)
        '
        'GridEXEmpresas
        '
        Me.GridEXEmpresas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXEmpresas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXEmpresas.ColumnAutoResize = True
        Me.GridEXEmpresas.DataSource = Me.LEMPRESABindingSource
        GridEXEmpresas_DesignTimeLayout.LayoutString = resources.GetString("GridEXEmpresas_DesignTimeLayout.LayoutString")
        Me.GridEXEmpresas.DesignTimeLayout = GridEXEmpresas_DesignTimeLayout
        Me.GridEXEmpresas.GroupByBoxVisible = False
        Me.GridEXEmpresas.Location = New System.Drawing.Point(8, 270)
        Me.GridEXEmpresas.Name = "GridEXEmpresas"
        Me.GridEXEmpresas.Size = New System.Drawing.Size(908, 220)
        Me.GridEXEmpresas.TabIndex = 2
        Me.GridEXEmpresas.TabStop = False
        '
        'LEMPRESABindingSource
        '
        Me.LEMPRESABindingSource.DataSource = GetType(centro_medico.LEMPRESA)
        '
        'tb_hlPuesto
        '
        Me.tb_hlPuesto.AcceptsReturn = True
        Me.tb_hlPuesto.Location = New System.Drawing.Point(461, 497)
        Me.tb_hlPuesto.MaxLength = 30
        Me.tb_hlPuesto.Name = "tb_hlPuesto"
        Me.tb_hlPuesto.Size = New System.Drawing.Size(136, 20)
        Me.tb_hlPuesto.TabIndex = 1
        Me.tb_hlPuesto.Visible = False
        '
        'tb_hlProfesion
        '
        Me.tb_hlProfesion.AcceptsReturn = True
        Me.tb_hlProfesion.Location = New System.Drawing.Point(254, 496)
        Me.tb_hlProfesion.MaxLength = 30
        Me.tb_hlProfesion.Name = "tb_hlProfesion"
        Me.tb_hlProfesion.Size = New System.Drawing.Size(148, 20)
        Me.tb_hlProfesion.TabIndex = 0
        Me.tb_hlProfesion.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(938, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Gu&ardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Can&celar"
        '
        'ComoConocioBindingSource
        '
        Me.ComoConocioBindingSource.DataSource = GetType(centro_medico.ComoConocio)
        '
        'lblEliminado
        '
        Me.lblEliminado.AutoSize = True
        Me.lblEliminado.BackColor = System.Drawing.Color.Transparent
        Me.lblEliminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEliminado.ForeColor = System.Drawing.Color.Red
        Me.lblEliminado.Location = New System.Drawing.Point(406, 5)
        Me.lblEliminado.Name = "lblEliminado"
        Me.lblEliminado.Size = New System.Drawing.Size(183, 18)
        Me.lblEliminado.TabIndex = 39
        Me.lblEliminado.Text = "PACIENTE ELIMINADO"
        Me.lblEliminado.Visible = False
        '
        'frmPaciente_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(938, 600)
        Me.Controls.Add(Me.lblEliminado)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.TabControl1)
        Me.MinimumSize = New System.Drawing.Size(946, 627)
        Me.Name = "frmPaciente_Editar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paciente"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageDetalles.ResumeLayout(False)
        Me.TabPageDetalles.PerformLayout()
        Me.gb_dpDatPer.ResumeLayout(False)
        Me.gb_dpDatPer.PerformLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_dpObservaciones.ResumeLayout(False)
        Me.gb_dpObservaciones.PerformLayout()
        CType(Me.pb_dpImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_dpDatosadmin.ResumeLayout(False)
        Me.gb_dpDatosadmin.PerformLayout()
        Me.pnlBeneficiario.ResumeLayout(False)
        Me.pnlBeneficiario.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grpAsociados.ResumeLayout(False)
        CType(Me.GridEXSocios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsociadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridEXContactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactosPacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HClinico.ResumeLayout(False)
        Me.HClinico.PerformLayout()
        Me.tsEmpresas.ResumeLayout(False)
        Me.tsEmpresas.PerformLayout()
        Me.tstMutuas.ResumeLayout(False)
        Me.tstMutuas.PerformLayout()
        CType(Me.GridEXMutuas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMUTUABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEMPRESABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.ComoConocioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDetalles As System.Windows.Forms.TabPage
    Friend WithEvents pnlBeneficiario As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSocioBeneficiario As System.Windows.Forms.Label
    Friend WithEvents txtNomSocio As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents txtParentescoSocio As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblCodigoPaciente As System.Windows.Forms.Label
    Friend WithEvents lbl_Apellido2 As System.Windows.Forms.Label
    Friend WithEvents tb_CodigoPaciente As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_Nombre As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_CodigoPropio As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_Apellido2 As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents lblCodigoPropio As System.Windows.Forms.Label
    Friend WithEvents pb_dpImagen As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tb_Apellido1 As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents lbl_Apellido1 As System.Windows.Forms.Label
    Friend WithEvents gb_dpDatosadmin As System.Windows.Forms.GroupBox
    Friend WithEvents cb_comoconocio As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_dpFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_dpFechabaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents chb_dpFallecido As System.Windows.Forms.CheckBox
    Friend WithEvents chb_dpAsociado As System.Windows.Forms.CheckBox
    Friend WithEvents chb_dpActivo As System.Windows.Forms.CheckBox
    Friend WithEvents tb_dpTarsanit As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_dpNss As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents gb_dpDatPer As System.Windows.Forms.GroupBox
    Friend WithEvents tb_web As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_Email As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents dtp_dpFeNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_dpTutorLegal As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_dpNie As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_dpPasaporte As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_dpMovil As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_dpProvincia As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_dpTlfno As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_dpPoblacion As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_dpCodigopostal As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents cb_dpSexo As System.Windows.Forms.ComboBox
    Friend WithEvents tb_dpEdad As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_dpDni As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_domicilio As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grpAsociados As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemoveSocio As System.Windows.Forms.Button
    Friend WithEvents btnAddSocio As System.Windows.Forms.Button
    Friend WithEvents GridEXSocios As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_ADD As System.Windows.Forms.Button
    Friend WithEvents GridEXContactos As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContactosPacienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComoConocioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AsociadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtrlPaises1 As centro_medico.ctrlPaises
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents HClinico As System.Windows.Forms.TabPage
    Friend WithEvents GridEXMutuas As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEXEmpresas As Janus.Windows.GridEX.GridEX
    Friend WithEvents cb_hlRegimen As System.Windows.Forms.ComboBox
    Friend WithEvents tb_hlPuesto As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_hlProfesion As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents LEMPRESABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gb_dpObservaciones As System.Windows.Forms.GroupBox
    Friend WithEvents tb_dpObservaciones As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tstMutuas As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstAnnadir_Tratamiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Modificar_Tratamiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar_Tratamiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEmpresas As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CtrlEmpresa1 As centro_medico.ctrlEmpresa
    Friend WithEvents lblEliminado As System.Windows.Forms.Label
    Friend WithEvents lb_dpLetradni As System.Windows.Forms.Label
    Friend WithEvents CtrlMutua1 As centro_medico.ctrlMutuaMejorado
    Friend WithEvents dtpsociohasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaValidoBeneficiario As System.Windows.Forms.Label
    Friend WithEvents lblValido As System.Windows.Forms.Label
    Friend WithEvents webcam As System.Windows.Forms.Button
End Class
