<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_empresa
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
        Me.components = New System.ComponentModel.Container
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
        Dim CNAELabel As System.Windows.Forms.Label
        Dim ACTIVIDADLabel As System.Windows.Forms.Label
        Dim CEMPRESALabel As System.Windows.Forms.Label
        Dim CIFLabel As System.Windows.Forms.Label
        Dim NSSLabel As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim ENTIDADLabel As System.Windows.Forms.Label
        Dim OFICINALabel As System.Windows.Forms.Label
        Dim DCLabel As System.Windows.Forms.Label
        Dim CUENTALabel As System.Windows.Forms.Label
        Dim TITULARLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab_datos = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bt_borrar = New System.Windows.Forms.Button
        Me.bt_actual = New System.Windows.Forms.Button
        Me.bt_nueva = New System.Windows.Forms.Button
        Me.bt_modificar = New System.Windows.Forms.Button
        Me.dgv_mutuas = New System.Windows.Forms.DataGridView
        Me.lb_mutua = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_CIF = New ctrlTextboxAvanzado
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_NSS = New ctrlTextboxAvanzado
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.tb_entidad = New ctrlTextboxAvanzado
        Me.tb_oficina = New ctrlTextboxAvanzado
        Me.tb_DC = New ctrlTextboxAvanzado
        Me.tb_cuenta = New ctrlTextboxAvanzado
        Me.tb_titular = New ctrlTextboxAvanzado
        Me.tb_nombre = New ctrlTextboxAvanzado
        Me.tb_direccion = New ctrlTextboxAvanzado
        Me.tb_poblacion = New ctrlTextboxAvanzado
        Me.tb_provincia = New ctrlTextboxAvanzado
        Me.tb_CP = New ctrlTextboxAvanzado
        Me.tb_tel1 = New ctrlTextboxAvanzado
        Me.tb_tel2 = New ctrlTextboxAvanzado
        Me.tb_fax = New ctrlTextboxAvanzado
        Me.tb_mail = New ctrlTextboxAvanzado
        Me.tb_web = New ctrlTextboxAvanzado
        Me.tb_contacto = New ctrlTextboxAvanzado
        Me.tb_notas = New ctrlTextboxAvanzado
        Me.tb_CNAE = New ctrlTextboxAvanzado
        Me.tb_actividad = New ctrlTextboxAvanzado
        Me.tb_cod = New ctrlTextboxAvanzado
        Me.lb_datos = New System.Windows.Forms.Label
        Me.tab_trabajadores = New System.Windows.Forms.TabPage
        Me.gb_mostrar = New System.Windows.Forms.GroupBox
        Me.rb_inactivos = New System.Windows.Forms.RadioButton
        Me.rb_activos = New System.Windows.Forms.RadioButton
        Me.rb_todos = New System.Windows.Forms.RadioButton
        Me.dgv_pacientes = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.tab_facturas = New System.Windows.Forms.TabPage
        Me.dgv_facturas = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bt_filtrar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtp_fin = New System.Windows.Forms.DateTimePicker
        Me.dtp_inicial = New System.Windows.Forms.DateTimePicker
        Me.rb_fcobro = New System.Windows.Forms.RadioButton
        Me.rb_femision = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.tab_ficheros = New System.Windows.Forms.TabPage
        Me.dgv_ficheros = New System.Windows.Forms.DataGridView
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.tb_ficherotab = New ctrlTextboxAvanzado
        Me.bt_open = New System.Windows.Forms.Button
        Me.bt_view = New System.Windows.Forms.Button
        Me.bt_borrarfichero = New System.Windows.Forms.Button
        Me.bt_modificarfichero = New System.Windows.Forms.Button
        Me.bt_nuevofichero = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
        Me.FICHEROSTableAdapter = New centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
        Me.FICHEROSGLOBALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
        Me.LMUTUASEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMUTUASEMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.LMUTUASEMPRESASTableAdapter
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FICHEROSGLOBALTableAdapter = New centro_medico.CMDataSetTableAdapters.FICHEROSGLOBALTableAdapter
        NOMBRELabel = New System.Windows.Forms.Label
        DIRECCIONLabel = New System.Windows.Forms.Label
        POBLACIONLabel = New System.Windows.Forms.Label
        PROVINCIALabel = New System.Windows.Forms.Label
        CPLabel = New System.Windows.Forms.Label
        TLFNO1Label = New System.Windows.Forms.Label
        TLFNO2Label = New System.Windows.Forms.Label
        FAXLabel = New System.Windows.Forms.Label
        MAILLabel = New System.Windows.Forms.Label
        WEBLabel = New System.Windows.Forms.Label
        PERSONACONLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CNAELabel = New System.Windows.Forms.Label
        ACTIVIDADLabel = New System.Windows.Forms.Label
        CEMPRESALabel = New System.Windows.Forms.Label
        CIFLabel = New System.Windows.Forms.Label
        NSSLabel = New System.Windows.Forms.Label
        FECHALabel = New System.Windows.Forms.Label
        ENTIDADLabel = New System.Windows.Forms.Label
        OFICINALabel = New System.Windows.Forms.Label
        DCLabel = New System.Windows.Forms.Label
        CUENTALabel = New System.Windows.Forms.Label
        TITULARLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tab_datos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_mutuas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_trabajadores.SuspendLayout()
        Me.gb_mostrar.SuspendLayout()
        CType(Me.dgv_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_facturas.SuspendLayout()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tab_ficheros.SuspendLayout()
        CType(Me.dgv_ficheros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FICHEROSGLOBALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMUTUASEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(154, 32)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(47, 13)
        NOMBRELabel.TabIndex = 1
        NOMBRELabel.Text = "Nombre:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(15, 71)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(55, 13)
        DIRECCIONLabel.TabIndex = 32
        DIRECCIONLabel.Text = "Dirección:"
        '
        'POBLACIONLabel
        '
        POBLACIONLabel.AutoSize = True
        POBLACIONLabel.Location = New System.Drawing.Point(379, 71)
        POBLACIONLabel.Name = "POBLACIONLabel"
        POBLACIONLabel.Size = New System.Drawing.Size(57, 13)
        POBLACIONLabel.TabIndex = 34
        POBLACIONLabel.Text = "Población:"
        '
        'PROVINCIALabel
        '
        PROVINCIALabel.AutoSize = True
        PROVINCIALabel.Location = New System.Drawing.Point(556, 71)
        PROVINCIALabel.Name = "PROVINCIALabel"
        PROVINCIALabel.Size = New System.Drawing.Size(54, 13)
        PROVINCIALabel.TabIndex = 36
        PROVINCIALabel.Text = "Provincia:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(261, 71)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 38
        CPLabel.Text = "CP:"
        '
        'TLFNO1Label
        '
        TLFNO1Label.AutoSize = True
        TLFNO1Label.Location = New System.Drawing.Point(19, 110)
        TLFNO1Label.Name = "TLFNO1Label"
        TLFNO1Label.Size = New System.Drawing.Size(40, 13)
        TLFNO1Label.TabIndex = 40
        TLFNO1Label.Text = "Tlfno1:"
        '
        'TLFNO2Label
        '
        TLFNO2Label.AutoSize = True
        TLFNO2Label.Location = New System.Drawing.Point(150, 110)
        TLFNO2Label.Name = "TLFNO2Label"
        TLFNO2Label.Size = New System.Drawing.Size(40, 13)
        TLFNO2Label.TabIndex = 42
        TLFNO2Label.Text = "Tlfno2:"
        '
        'FAXLabel
        '
        FAXLabel.AutoSize = True
        FAXLabel.Location = New System.Drawing.Point(278, 110)
        FAXLabel.Name = "FAXLabel"
        FAXLabel.Size = New System.Drawing.Size(27, 13)
        FAXLabel.TabIndex = 44
        FAXLabel.Text = "Fax:"
        '
        'MAILLabel
        '
        MAILLabel.AutoSize = True
        MAILLabel.Location = New System.Drawing.Point(556, 110)
        MAILLabel.Name = "MAILLabel"
        MAILLabel.Size = New System.Drawing.Size(38, 13)
        MAILLabel.TabIndex = 46
        MAILLabel.Text = "E-mail:"
        '
        'WEBLabel
        '
        WEBLabel.AutoSize = True
        WEBLabel.Location = New System.Drawing.Point(19, 149)
        WEBLabel.Name = "WEBLabel"
        WEBLabel.Size = New System.Drawing.Size(66, 13)
        WEBLabel.TabIndex = 48
        WEBLabel.Text = "Página web:"
        '
        'PERSONACONLabel
        '
        PERSONACONLabel.AutoSize = True
        PERSONACONLabel.Location = New System.Drawing.Point(388, 110)
        PERSONACONLabel.Name = "PERSONACONLabel"
        PERSONACONLabel.Size = New System.Drawing.Size(94, 13)
        PERSONACONLabel.TabIndex = 50
        PERSONACONLabel.Text = "Persona contacto:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(563, 186)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 52
        NOTASLabel.Text = "Notas:"
        '
        'CNAELabel
        '
        CNAELabel.AutoSize = True
        CNAELabel.Location = New System.Drawing.Point(457, 149)
        CNAELabel.Name = "CNAELabel"
        CNAELabel.Size = New System.Drawing.Size(39, 13)
        CNAELabel.TabIndex = 54
        CNAELabel.Text = "CNAE:"
        '
        'ACTIVIDADLabel
        '
        ACTIVIDADLabel.AutoSize = True
        ACTIVIDADLabel.Location = New System.Drawing.Point(261, 149)
        ACTIVIDADLabel.Name = "ACTIVIDADLabel"
        ACTIVIDADLabel.Size = New System.Drawing.Size(54, 13)
        ACTIVIDADLabel.TabIndex = 56
        ACTIVIDADLabel.Text = "Actividad:"
        '
        'CEMPRESALabel
        '
        CEMPRESALabel.AutoSize = True
        CEMPRESALabel.Location = New System.Drawing.Point(15, 32)
        CEMPRESALabel.Name = "CEMPRESALabel"
        CEMPRESALabel.Size = New System.Drawing.Size(43, 13)
        CEMPRESALabel.TabIndex = 58
        CEMPRESALabel.Text = "Código:"
        '
        'CIFLabel
        '
        CIFLabel.AutoSize = True
        CIFLabel.Location = New System.Drawing.Point(388, 32)
        CIFLabel.Name = "CIFLabel"
        CIFLabel.Size = New System.Drawing.Size(26, 13)
        CIFLabel.TabIndex = 78
        CIFLabel.Text = "CIF:"
        '
        'NSSLabel
        '
        NSSLabel.AutoSize = True
        NSSLabel.Location = New System.Drawing.Point(562, 149)
        NSSLabel.Name = "NSSLabel"
        NSSLabel.Size = New System.Drawing.Size(122, 13)
        NSSLabel.TabIndex = 80
        NSSLabel.Text = "No de Seguridad Social:"
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(556, 32)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(40, 13)
        FECHALabel.TabIndex = 82
        FECHALabel.Text = "Fecha:"
        '
        'ENTIDADLabel
        '
        ENTIDADLabel.AutoSize = True
        ENTIDADLabel.Location = New System.Drawing.Point(19, 186)
        ENTIDADLabel.Name = "ENTIDADLabel"
        ENTIDADLabel.Size = New System.Drawing.Size(46, 13)
        ENTIDADLabel.TabIndex = 84
        ENTIDADLabel.Text = "Entidad:"
        '
        'OFICINALabel
        '
        OFICINALabel.AutoSize = True
        OFICINALabel.Location = New System.Drawing.Point(127, 186)
        OFICINALabel.Name = "OFICINALabel"
        OFICINALabel.Size = New System.Drawing.Size(43, 13)
        OFICINALabel.TabIndex = 86
        OFICINALabel.Text = "Oficina:"
        '
        'DCLabel
        '
        DCLabel.AutoSize = True
        DCLabel.Location = New System.Drawing.Point(234, 186)
        DCLabel.Name = "DCLabel"
        DCLabel.Size = New System.Drawing.Size(25, 13)
        DCLabel.TabIndex = 88
        DCLabel.Text = "DC:"
        '
        'CUENTALabel
        '
        CUENTALabel.AutoSize = True
        CUENTALabel.Location = New System.Drawing.Point(370, 186)
        CUENTALabel.Name = "CUENTALabel"
        CUENTALabel.Size = New System.Drawing.Size(44, 13)
        CUENTALabel.TabIndex = 90
        CUENTALabel.Text = "Cuenta:"
        '
        'TITULARLabel
        '
        TITULARLabel.AutoSize = True
        TITULARLabel.Location = New System.Drawing.Point(19, 225)
        TITULARLabel.Name = "TITULARLabel"
        TITULARLabel.Size = New System.Drawing.Size(39, 13)
        TITULARLabel.TabIndex = 92
        TITULARLabel.Text = "Titular:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_datos)
        Me.TabControl1.Controls.Add(Me.tab_trabajadores)
        Me.TabControl1.Controls.Add(Me.tab_facturas)
        Me.TabControl1.Controls.Add(Me.tab_ficheros)
        Me.TabControl1.Location = New System.Drawing.Point(3, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(815, 474)
        Me.TabControl1.TabIndex = 0
        '
        'tab_datos
        '
        Me.tab_datos.AutoScroll = True
        Me.tab_datos.Controls.Add(Me.GroupBox2)
        Me.tab_datos.Controls.Add(CIFLabel)
        Me.tab_datos.Controls.Add(Me.tb_CIF)
        Me.tab_datos.Controls.Add(NSSLabel)
        Me.tab_datos.Controls.Add(Me.tb_NSS)
        Me.tab_datos.Controls.Add(FECHALabel)
        Me.tab_datos.Controls.Add(Me.dtp_fecha)
        Me.tab_datos.Controls.Add(ENTIDADLabel)
        Me.tab_datos.Controls.Add(Me.tb_entidad)
        Me.tab_datos.Controls.Add(OFICINALabel)
        Me.tab_datos.Controls.Add(Me.tb_oficina)
        Me.tab_datos.Controls.Add(DCLabel)
        Me.tab_datos.Controls.Add(Me.tb_DC)
        Me.tab_datos.Controls.Add(CUENTALabel)
        Me.tab_datos.Controls.Add(Me.tb_cuenta)
        Me.tab_datos.Controls.Add(TITULARLabel)
        Me.tab_datos.Controls.Add(Me.tb_titular)
        Me.tab_datos.Controls.Add(NOMBRELabel)
        Me.tab_datos.Controls.Add(Me.tb_nombre)
        Me.tab_datos.Controls.Add(DIRECCIONLabel)
        Me.tab_datos.Controls.Add(Me.tb_direccion)
        Me.tab_datos.Controls.Add(POBLACIONLabel)
        Me.tab_datos.Controls.Add(Me.tb_poblacion)
        Me.tab_datos.Controls.Add(PROVINCIALabel)
        Me.tab_datos.Controls.Add(Me.tb_provincia)
        Me.tab_datos.Controls.Add(CPLabel)
        Me.tab_datos.Controls.Add(Me.tb_CP)
        Me.tab_datos.Controls.Add(TLFNO1Label)
        Me.tab_datos.Controls.Add(Me.tb_tel1)
        Me.tab_datos.Controls.Add(TLFNO2Label)
        Me.tab_datos.Controls.Add(Me.tb_tel2)
        Me.tab_datos.Controls.Add(FAXLabel)
        Me.tab_datos.Controls.Add(Me.tb_fax)
        Me.tab_datos.Controls.Add(MAILLabel)
        Me.tab_datos.Controls.Add(Me.tb_mail)
        Me.tab_datos.Controls.Add(WEBLabel)
        Me.tab_datos.Controls.Add(Me.tb_web)
        Me.tab_datos.Controls.Add(PERSONACONLabel)
        Me.tab_datos.Controls.Add(Me.tb_contacto)
        Me.tab_datos.Controls.Add(NOTASLabel)
        Me.tab_datos.Controls.Add(Me.tb_notas)
        Me.tab_datos.Controls.Add(CNAELabel)
        Me.tab_datos.Controls.Add(Me.tb_CNAE)
        Me.tab_datos.Controls.Add(ACTIVIDADLabel)
        Me.tab_datos.Controls.Add(Me.tb_actividad)
        Me.tab_datos.Controls.Add(CEMPRESALabel)
        Me.tab_datos.Controls.Add(Me.tb_cod)
        Me.tab_datos.Controls.Add(Me.lb_datos)
        Me.tab_datos.Location = New System.Drawing.Point(4, 22)
        Me.tab_datos.Name = "tab_datos"
        Me.tab_datos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_datos.Size = New System.Drawing.Size(807, 448)
        Me.tab_datos.TabIndex = 0
        Me.tab_datos.Text = "Datos Básicos"
        Me.tab_datos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bt_borrar)
        Me.GroupBox2.Controls.Add(Me.bt_actual)
        Me.GroupBox2.Controls.Add(Me.bt_nueva)
        Me.GroupBox2.Controls.Add(Me.bt_modificar)
        Me.GroupBox2.Controls.Add(Me.dgv_mutuas)
        Me.GroupBox2.Controls.Add(Me.lb_mutua)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 171)
        Me.GroupBox2.TabIndex = 94
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mutuas/aseguradoras/Compañias de revisión"
        '
        'bt_borrar
        '
        Me.bt_borrar.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_borrar.Location = New System.Drawing.Point(484, 113)
        Me.bt_borrar.Name = "bt_borrar"
        Me.bt_borrar.Size = New System.Drawing.Size(26, 23)
        Me.bt_borrar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.bt_borrar, "Borrar mutua")
        Me.bt_borrar.UseVisualStyleBackColor = True
        '
        'bt_actual
        '
        Me.bt_actual.BackgroundImage = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_actual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_actual.Location = New System.Drawing.Point(484, 142)
        Me.bt_actual.Name = "bt_actual"
        Me.bt_actual.Size = New System.Drawing.Size(26, 23)
        Me.bt_actual.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.bt_actual, "Seleccionar como mutua activa")
        Me.bt_actual.UseVisualStyleBackColor = True
        '
        'bt_nueva
        '
        Me.bt_nueva.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_nueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_nueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_nueva.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_nueva.Location = New System.Drawing.Point(484, 52)
        Me.bt_nueva.Name = "bt_nueva"
        Me.bt_nueva.Size = New System.Drawing.Size(26, 26)
        Me.bt_nueva.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.bt_nueva, "Añadir mutua")
        Me.bt_nueva.UseVisualStyleBackColor = True
        '
        'bt_modificar
        '
        Me.bt_modificar.BackgroundImage = Global.centro_medico.My.Resources.Resources.up
        Me.bt_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_modificar.Location = New System.Drawing.Point(484, 84)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(26, 23)
        Me.bt_modificar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.bt_modificar, "Modificar mutua")
        Me.bt_modificar.UseVisualStyleBackColor = True
        '
        'dgv_mutuas
        '
        Me.dgv_mutuas.AllowUserToAddRows = False
        Me.dgv_mutuas.AllowUserToDeleteRows = False
        Me.dgv_mutuas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_mutuas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_mutuas.BackgroundColor = System.Drawing.Color.White
        Me.dgv_mutuas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mutuas.Location = New System.Drawing.Point(11, 52)
        Me.dgv_mutuas.Name = "dgv_mutuas"
        Me.dgv_mutuas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_mutuas.Size = New System.Drawing.Size(467, 113)
        Me.dgv_mutuas.TabIndex = 1
        '
        'lb_mutua
        '
        Me.lb_mutua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_mutua.Location = New System.Drawing.Point(9, 29)
        Me.lb_mutua.Name = "lb_mutua"
        Me.lb_mutua.Size = New System.Drawing.Size(387, 20)
        Me.lb_mutua.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mutua Activa"
        '
        'tb_CIF
        '
        Me.tb_CIF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "CIF", True))
        Me.tb_CIF.Location = New System.Drawing.Point(382, 48)
        Me.tb_CIF.MaxLength = 9
        Me.tb_CIF.Name = "tb_CIF"
        Me.tb_CIF.Size = New System.Drawing.Size(163, 20)
        Me.tb_CIF.TabIndex = 3
        '
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_NSS
        '
        Me.tb_NSS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "NSS", True))
        Me.tb_NSS.Location = New System.Drawing.Point(559, 165)
        Me.tb_NSS.MaxLength = 15
        Me.tb_NSS.Name = "tb_NSS"
        Me.tb_NSS.Size = New System.Drawing.Size(200, 20)
        Me.tb_NSS.TabIndex = 17
        '
        'dtp_fecha
        '
        Me.dtp_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EMPRESASBindingSource, "FECHA", True))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(559, 48)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha.TabIndex = 4
        '
        'tb_entidad
        '
        Me.tb_entidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "ENTIDAD", True))
        Me.tb_entidad.Location = New System.Drawing.Point(18, 202)
        Me.tb_entidad.MaxLength = 4
        Me.tb_entidad.Name = "tb_entidad"
        Me.tb_entidad.Size = New System.Drawing.Size(79, 20)
        Me.tb_entidad.TabIndex = 18
        '
        'tb_oficina
        '
        Me.tb_oficina.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "OFICINA", True))
        Me.tb_oficina.Location = New System.Drawing.Point(118, 202)
        Me.tb_oficina.MaxLength = 4
        Me.tb_oficina.Name = "tb_oficina"
        Me.tb_oficina.Size = New System.Drawing.Size(94, 20)
        Me.tb_oficina.TabIndex = 19
        '
        'tb_DC
        '
        Me.tb_DC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "DC", True))
        Me.tb_DC.Location = New System.Drawing.Point(237, 202)
        Me.tb_DC.MaxLength = 2
        Me.tb_DC.Name = "tb_DC"
        Me.tb_DC.Size = New System.Drawing.Size(109, 20)
        Me.tb_DC.TabIndex = 20
        '
        'tb_cuenta
        '
        Me.tb_cuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "CUENTA", True))
        Me.tb_cuenta.Location = New System.Drawing.Point(371, 202)
        Me.tb_cuenta.MaxLength = 10
        Me.tb_cuenta.Name = "tb_cuenta"
        Me.tb_cuenta.Size = New System.Drawing.Size(174, 20)
        Me.tb_cuenta.TabIndex = 21
        '
        'tb_titular
        '
        Me.tb_titular.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "TITULAR", True))
        Me.tb_titular.Location = New System.Drawing.Point(18, 241)
        Me.tb_titular.MaxLength = 40
        Me.tb_titular.Name = "tb_titular"
        Me.tb_titular.Size = New System.Drawing.Size(527, 20)
        Me.tb_titular.TabIndex = 22
        '
        'tb_nombre
        '
        Me.tb_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "NOMBRE", True))
        Me.tb_nombre.Location = New System.Drawing.Point(146, 48)
        Me.tb_nombre.MaxLength = 40
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(200, 20)
        Me.tb_nombre.TabIndex = 2
        '
        'tb_direccion
        '
        Me.tb_direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "DIRECCION", True))
        Me.tb_direccion.Location = New System.Drawing.Point(18, 87)
        Me.tb_direccion.MaxLength = 150
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(225, 20)
        Me.tb_direccion.TabIndex = 5
        '
        'tb_poblacion
        '
        Me.tb_poblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "POBLACION", True))
        Me.tb_poblacion.Location = New System.Drawing.Point(382, 87)
        Me.tb_poblacion.MaxLength = 20
        Me.tb_poblacion.Name = "tb_poblacion"
        Me.tb_poblacion.Size = New System.Drawing.Size(163, 20)
        Me.tb_poblacion.TabIndex = 7
        '
        'tb_provincia
        '
        Me.tb_provincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "PROVINCIA", True))
        Me.tb_provincia.Location = New System.Drawing.Point(559, 87)
        Me.tb_provincia.MaxLength = 20
        Me.tb_provincia.Name = "tb_provincia"
        Me.tb_provincia.Size = New System.Drawing.Size(200, 20)
        Me.tb_provincia.TabIndex = 8
        '
        'tb_CP
        '
        Me.tb_CP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "CP", True))
        Me.tb_CP.Location = New System.Drawing.Point(264, 87)
        Me.tb_CP.MaxLength = 5
        Me.tb_CP.Name = "tb_CP"
        Me.tb_CP.Size = New System.Drawing.Size(82, 20)
        Me.tb_CP.TabIndex = 6
        '
        'tb_tel1
        '
        Me.tb_tel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "TLFNO1", True))
        Me.tb_tel1.Location = New System.Drawing.Point(18, 126)
        Me.tb_tel1.MaxLength = 10
        Me.tb_tel1.Name = "tb_tel1"
        Me.tb_tel1.Size = New System.Drawing.Size(107, 20)
        Me.tb_tel1.TabIndex = 9
        '
        'tb_tel2
        '
        Me.tb_tel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "TLFNO2", True))
        Me.tb_tel2.Location = New System.Drawing.Point(146, 126)
        Me.tb_tel2.MaxLength = 10
        Me.tb_tel2.Name = "tb_tel2"
        Me.tb_tel2.Size = New System.Drawing.Size(98, 20)
        Me.tb_tel2.TabIndex = 10
        '
        'tb_fax
        '
        Me.tb_fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "FAX", True))
        Me.tb_fax.Location = New System.Drawing.Point(264, 126)
        Me.tb_fax.MaxLength = 10
        Me.tb_fax.Name = "tb_fax"
        Me.tb_fax.Size = New System.Drawing.Size(102, 20)
        Me.tb_fax.TabIndex = 11
        '
        'tb_mail
        '
        Me.tb_mail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "MAIL", True))
        Me.tb_mail.Location = New System.Drawing.Point(559, 126)
        Me.tb_mail.MaxLength = 40
        Me.tb_mail.Name = "tb_mail"
        Me.tb_mail.Size = New System.Drawing.Size(200, 20)
        Me.tb_mail.TabIndex = 13
        '
        'tb_web
        '
        Me.tb_web.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "WEB", True))
        Me.tb_web.Location = New System.Drawing.Point(18, 165)
        Me.tb_web.MaxLength = 40
        Me.tb_web.Name = "tb_web"
        Me.tb_web.Size = New System.Drawing.Size(225, 20)
        Me.tb_web.TabIndex = 14
        '
        'tb_contacto
        '
        Me.tb_contacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "PERSONACON", True))
        Me.tb_contacto.Location = New System.Drawing.Point(382, 126)
        Me.tb_contacto.MaxLength = 40
        Me.tb_contacto.Name = "tb_contacto"
        Me.tb_contacto.Size = New System.Drawing.Size(163, 20)
        Me.tb_contacto.TabIndex = 12
        '
        'tb_notas
        '
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(559, 202)
        Me.tb_notas.MaxLength = 150
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.Size = New System.Drawing.Size(200, 223)
        Me.tb_notas.TabIndex = 23
        '
        'tb_CNAE
        '
        Me.tb_CNAE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "CNAE", True))
        Me.tb_CNAE.Location = New System.Drawing.Point(445, 165)
        Me.tb_CNAE.MaxLength = 5
        Me.tb_CNAE.Name = "tb_CNAE"
        Me.tb_CNAE.Size = New System.Drawing.Size(100, 20)
        Me.tb_CNAE.TabIndex = 16
        '
        'tb_actividad
        '
        Me.tb_actividad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "ACTIVIDAD", True))
        Me.tb_actividad.Location = New System.Drawing.Point(257, 165)
        Me.tb_actividad.MaxLength = 30
        Me.tb_actividad.Name = "tb_actividad"
        Me.tb_actividad.Size = New System.Drawing.Size(167, 20)
        Me.tb_actividad.TabIndex = 15
        '
        'tb_cod
        '
        Me.tb_cod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPRESASBindingSource, "CEMPRESA", True))
        Me.tb_cod.Location = New System.Drawing.Point(18, 48)
        Me.tb_cod.MaxLength = 11
        Me.tb_cod.Name = "tb_cod"
        Me.tb_cod.Size = New System.Drawing.Size(94, 20)
        Me.tb_cod.TabIndex = 0
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.GhostWhite
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(3, 3)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(796, 19)
        Me.lb_datos.TabIndex = 30
        Me.lb_datos.Text = "Datos Básicos de la empresa"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_trabajadores
        '
        Me.tab_trabajadores.Controls.Add(Me.gb_mostrar)
        Me.tab_trabajadores.Controls.Add(Me.dgv_pacientes)
        Me.tab_trabajadores.Controls.Add(Me.Label1)
        Me.tab_trabajadores.Location = New System.Drawing.Point(4, 22)
        Me.tab_trabajadores.Name = "tab_trabajadores"
        Me.tab_trabajadores.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_trabajadores.Size = New System.Drawing.Size(807, 448)
        Me.tab_trabajadores.TabIndex = 1
        Me.tab_trabajadores.Text = "Trabajadores"
        Me.tab_trabajadores.UseVisualStyleBackColor = True
        '
        'gb_mostrar
        '
        Me.gb_mostrar.Controls.Add(Me.rb_inactivos)
        Me.gb_mostrar.Controls.Add(Me.rb_activos)
        Me.gb_mostrar.Controls.Add(Me.rb_todos)
        Me.gb_mostrar.Location = New System.Drawing.Point(6, 25)
        Me.gb_mostrar.Name = "gb_mostrar"
        Me.gb_mostrar.Size = New System.Drawing.Size(229, 36)
        Me.gb_mostrar.TabIndex = 0
        Me.gb_mostrar.TabStop = False
        Me.gb_mostrar.Text = "Mostrar"
        '
        'rb_inactivos
        '
        Me.rb_inactivos.AutoSize = True
        Me.rb_inactivos.Location = New System.Drawing.Point(141, 13)
        Me.rb_inactivos.Name = "rb_inactivos"
        Me.rb_inactivos.Size = New System.Drawing.Size(68, 17)
        Me.rb_inactivos.TabIndex = 2
        Me.rb_inactivos.Text = "Inactivos"
        Me.rb_inactivos.UseVisualStyleBackColor = True
        '
        'rb_activos
        '
        Me.rb_activos.AutoSize = True
        Me.rb_activos.Location = New System.Drawing.Point(80, 13)
        Me.rb_activos.Name = "rb_activos"
        Me.rb_activos.Size = New System.Drawing.Size(60, 17)
        Me.rb_activos.TabIndex = 1
        Me.rb_activos.Text = "Activos"
        Me.rb_activos.UseVisualStyleBackColor = True
        '
        'rb_todos
        '
        Me.rb_todos.AutoSize = True
        Me.rb_todos.Checked = True
        Me.rb_todos.Location = New System.Drawing.Point(7, 13)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(55, 17)
        Me.rb_todos.TabIndex = 0
        Me.rb_todos.TabStop = True
        Me.rb_todos.Text = "Todos"
        Me.rb_todos.UseVisualStyleBackColor = True
        '
        'dgv_pacientes
        '
        Me.dgv_pacientes.AllowUserToAddRows = False
        Me.dgv_pacientes.AllowUserToDeleteRows = False
        Me.dgv_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_pacientes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pacientes.Location = New System.Drawing.Point(0, 68)
        Me.dgv_pacientes.Name = "dgv_pacientes"
        Me.dgv_pacientes.ReadOnly = True
        Me.dgv_pacientes.Size = New System.Drawing.Size(800, 380)
        Me.dgv_pacientes.StandardTab = True
        Me.dgv_pacientes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.GhostWhite
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(807, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Pacientes que trabajan en esta empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_facturas
        '
        Me.tab_facturas.Controls.Add(Me.dgv_facturas)
        Me.tab_facturas.Controls.Add(Me.GroupBox1)
        Me.tab_facturas.Controls.Add(Me.Label2)
        Me.tab_facturas.Location = New System.Drawing.Point(4, 22)
        Me.tab_facturas.Name = "tab_facturas"
        Me.tab_facturas.Size = New System.Drawing.Size(807, 448)
        Me.tab_facturas.TabIndex = 2
        Me.tab_facturas.Text = "Facturas"
        Me.tab_facturas.UseVisualStyleBackColor = True
        '
        'dgv_facturas
        '
        Me.dgv_facturas.AllowUserToAddRows = False
        Me.dgv_facturas.AllowUserToDeleteRows = False
        Me.dgv_facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_facturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_facturas.BackgroundColor = System.Drawing.Color.White
        Me.dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas.Location = New System.Drawing.Point(3, 110)
        Me.dgv_facturas.Name = "dgv_facturas"
        Me.dgv_facturas.ReadOnly = True
        Me.dgv_facturas.Size = New System.Drawing.Size(800, 335)
        Me.dgv_facturas.TabIndex = 1
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
        Me.GroupBox1.Size = New System.Drawing.Size(800, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar facturas con"
        '
        'bt_filtrar
        '
        Me.bt_filtrar.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_filtrar.Location = New System.Drawing.Point(507, 33)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(39, 43)
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
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Inicial"
        '
        'dtp_fin
        '
        Me.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fin.Location = New System.Drawing.Point(361, 42)
        Me.dtp_fin.Name = "dtp_fin"
        Me.dtp_fin.Size = New System.Drawing.Size(104, 20)
        Me.dtp_fin.TabIndex = 3
        '
        'dtp_inicial
        '
        Me.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inicial.Location = New System.Drawing.Point(233, 42)
        Me.dtp_inicial.Name = "dtp_inicial"
        Me.dtp_inicial.Size = New System.Drawing.Size(109, 20)
        Me.dtp_inicial.TabIndex = 2
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.GhostWhite
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(801, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Facturas emitidas a la empresa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_ficheros
        '
        Me.tab_ficheros.Controls.Add(Me.dgv_ficheros)
        Me.tab_ficheros.Controls.Add(Me.WebBrowser1)
        Me.tab_ficheros.Controls.Add(Me.tb_ficherotab)
        Me.tab_ficheros.Controls.Add(Me.bt_open)
        Me.tab_ficheros.Controls.Add(Me.bt_view)
        Me.tab_ficheros.Controls.Add(Me.bt_borrarfichero)
        Me.tab_ficheros.Controls.Add(Me.bt_modificarfichero)
        Me.tab_ficheros.Controls.Add(Me.bt_nuevofichero)
        Me.tab_ficheros.Location = New System.Drawing.Point(4, 22)
        Me.tab_ficheros.Name = "tab_ficheros"
        Me.tab_ficheros.Size = New System.Drawing.Size(807, 448)
        Me.tab_ficheros.TabIndex = 3
        Me.tab_ficheros.Text = "Ficheros"
        Me.tab_ficheros.UseVisualStyleBackColor = True
        '
        'dgv_ficheros
        '
        Me.dgv_ficheros.AllowUserToAddRows = False
        Me.dgv_ficheros.AllowUserToDeleteRows = False
        Me.dgv_ficheros.BackgroundColor = System.Drawing.Color.White
        Me.dgv_ficheros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ficheros.Location = New System.Drawing.Point(3, 3)
        Me.dgv_ficheros.MultiSelect = False
        Me.dgv_ficheros.Name = "dgv_ficheros"
        Me.dgv_ficheros.ReadOnly = True
        Me.dgv_ficheros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ficheros.Size = New System.Drawing.Size(463, 413)
        Me.dgv_ficheros.TabIndex = 7
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(472, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(335, 416)
        Me.WebBrowser1.TabIndex = 1
        '
        'tb_ficherotab
        '
        Me.tb_ficherotab.Location = New System.Drawing.Point(472, 0)
        Me.tb_ficherotab.Multiline = True
        Me.tb_ficherotab.Name = "tb_ficherotab"
        Me.tb_ficherotab.Size = New System.Drawing.Size(330, 416)
        Me.tb_ficherotab.TabIndex = 12
        '
        'bt_open
        '
        Me.bt_open.BackgroundImage = Global.centro_medico.My.Resources.Resources.NOTE16
        Me.bt_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_open.Location = New System.Drawing.Point(4, 422)
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
        Me.bt_view.Location = New System.Drawing.Point(41, 422)
        Me.bt_view.Name = "bt_view"
        Me.bt_view.Size = New System.Drawing.Size(31, 23)
        Me.bt_view.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.bt_view, "Vista previa")
        Me.bt_view.UseVisualStyleBackColor = True
        '
        'bt_borrarfichero
        '
        Me.bt_borrarfichero.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_borrarfichero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_borrarfichero.Location = New System.Drawing.Point(440, 422)
        Me.bt_borrarfichero.Name = "bt_borrarfichero"
        Me.bt_borrarfichero.Size = New System.Drawing.Size(31, 23)
        Me.bt_borrarfichero.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.bt_borrarfichero, "Borrar fichero")
        Me.bt_borrarfichero.UseVisualStyleBackColor = True
        '
        'bt_modificarfichero
        '
        Me.bt_modificarfichero.Image = Global.centro_medico.My.Resources.Resources.up
        Me.bt_modificarfichero.Location = New System.Drawing.Point(403, 422)
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
        Me.bt_nuevofichero.Location = New System.Drawing.Point(366, 422)
        Me.bt_nuevofichero.Name = "bt_nuevofichero"
        Me.bt_nuevofichero.Size = New System.Drawing.Size(31, 23)
        Me.bt_nuevofichero.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.bt_nuevofichero, "Agregar fichero")
        Me.bt_nuevofichero.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        'FICHEROSTableAdapter
        '
        Me.FICHEROSTableAdapter.ClearBeforeFill = True
        '
        'FICHEROSGLOBALBindingSource
        '
        Me.FICHEROSGLOBALBindingSource.DataMember = "FICHEROSGLOBAL"
        Me.FICHEROSGLOBALBindingSource.DataSource = Me.CMDataSet
        '
        'MUTUASBindingSource
        '
        Me.MUTUASBindingSource.DataMember = "MUTUAS"
        Me.MUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'MUTUASTableAdapter
        '
        Me.MUTUASTableAdapter.ClearBeforeFill = True
        '
        'LMUTUASEMPRESASBindingSource
        '
        Me.LMUTUASEMPRESASBindingSource.DataMember = "LMUTUASEMPRESAS"
        Me.LMUTUASEMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'LMUTUASEMPRESASTableAdapter
        '
        Me.LMUTUASEMPRESASTableAdapter.ClearBeforeFill = True
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(735, 477)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 2
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(654, 477)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 1
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'FICHEROSGLOBALTableAdapter
        '
        Me.FICHEROSGLOBALTableAdapter.ClearBeforeFill = True
        '
        'form_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 508)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "form_empresa"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_empresa"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_datos.ResumeLayout(False)
        Me.tab_datos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_mutuas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_trabajadores.ResumeLayout(False)
        Me.gb_mostrar.ResumeLayout(False)
        Me.gb_mostrar.PerformLayout()
        CType(Me.dgv_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_facturas.ResumeLayout(False)
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tab_ficheros.ResumeLayout(False)
        Me.tab_ficheros.PerformLayout()
        CType(Me.dgv_ficheros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FICHEROSGLOBALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMUTUASEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_datos As System.Windows.Forms.TabPage
    Friend WithEvents tab_trabajadores As System.Windows.Forms.TabPage
    Friend WithEvents tab_facturas As System.Windows.Forms.TabPage
    Friend WithEvents tab_ficheros As System.Windows.Forms.TabPage
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents rb_fcobro As System.Windows.Forms.RadioButton
    Friend WithEvents rb_femision As System.Windows.Forms.RadioButton
    Friend WithEvents dgv_facturas As System.Windows.Forms.DataGridView
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents FICHEROSTableAdapter As centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
    Friend WithEvents FICHEROSGLOBALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bt_open As System.Windows.Forms.Button
    Friend WithEvents bt_view As System.Windows.Forms.Button
    Friend WithEvents bt_borrarfichero As System.Windows.Forms.Button
    Friend WithEvents bt_modificarfichero As System.Windows.Forms.Button
    Friend WithEvents bt_nuevofichero As System.Windows.Forms.Button
    Friend WithEvents tb_ficherotab As ctrlTextboxAvanzado
    Friend WithEvents dgv_pacientes As System.Windows.Forms.DataGridView
    Friend WithEvents gb_mostrar As System.Windows.Forms.GroupBox
    Friend WithEvents rb_inactivos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_activos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents tb_CIF As ctrlTextboxAvanzado
    Friend WithEvents tb_NSS As ctrlTextboxAvanzado
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_entidad As ctrlTextboxAvanzado
    Friend WithEvents tb_oficina As ctrlTextboxAvanzado
    Friend WithEvents tb_DC As ctrlTextboxAvanzado
    Friend WithEvents tb_cuenta As ctrlTextboxAvanzado
    Friend WithEvents tb_titular As ctrlTextboxAvanzado
    Friend WithEvents tb_nombre As ctrlTextboxAvanzado
    Friend WithEvents tb_direccion As ctrlTextboxAvanzado
    Friend WithEvents tb_poblacion As ctrlTextboxAvanzado
    Friend WithEvents tb_provincia As ctrlTextboxAvanzado
    Friend WithEvents tb_CP As ctrlTextboxAvanzado
    Friend WithEvents tb_tel1 As ctrlTextboxAvanzado
    Friend WithEvents tb_tel2 As ctrlTextboxAvanzado
    Friend WithEvents tb_fax As ctrlTextboxAvanzado
    Friend WithEvents tb_mail As ctrlTextboxAvanzado
    Friend WithEvents tb_web As ctrlTextboxAvanzado
    Friend WithEvents tb_contacto As ctrlTextboxAvanzado
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents tb_CNAE As ctrlTextboxAvanzado
    Friend WithEvents tb_actividad As ctrlTextboxAvanzado
    Friend WithEvents tb_cod As ctrlTextboxAvanzado
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_mutua As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_borrar As System.Windows.Forms.Button
    Friend WithEvents bt_actual As System.Windows.Forms.Button
    Friend WithEvents bt_nueva As System.Windows.Forms.Button
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents dgv_mutuas As System.Windows.Forms.DataGridView
    Friend WithEvents LMUTUASEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUASEMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.LMUTUASEMPRESASTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents dgv_ficheros As System.Windows.Forms.DataGridView
    Friend WithEvents FICHEROSGLOBALTableAdapter As centro_medico.CMDataSetTableAdapters.FICHEROSGLOBALTableAdapter
End Class
