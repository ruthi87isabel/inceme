<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_generar_recfact
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDiferente = New System.Windows.Forms.CheckBox()
        Me.cmbEntidad = New System.Windows.Forms.ComboBox()
        Me.chkFiltraEntidadBancaria = New System.Windows.Forms.CheckBox()
        Me.lblDesseleccionarTodos = New System.Windows.Forms.LinkLabel()
        Me.lblSeleccionarTodos = New System.Windows.Forms.LinkLabel()
        Me.bt_Filtrar = New System.Windows.Forms.Button()
        Me.cmb_ConceptosFacturables = New System.Windows.Forms.ComboBox()
        Me.chk_FiltrarServicios = New System.Windows.Forms.CheckBox()
        Me.bt_pac = New System.Windows.Forms.Button()
        Me.lb_pac = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_pac = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPropio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Oficina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCONCEPTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFEMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFMUTUA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbFacturas = New System.Windows.Forms.TabPage()
        Me.dgv_Fras = New System.Windows.Forms.DataGridView()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFSERIE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEROFACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFPACIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HISTORIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFEMPRESA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFMUTUA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FACCIDENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FBAJA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FALTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FEMISION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PORCENTAJEIRPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IRPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAGNOSTICO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGADA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MUTUA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECIBO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCALIDAD1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVINCIA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFRECIBO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACOBRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFORMAPAGO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FACTURAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbRecibos = New System.Windows.Forms.TabPage()
        Me.dgvRecibos = New System.Windows.Forms.DataGridView()
        Me.NUMERO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAEMISION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFPACIENTE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COBRADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMITIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCITA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAVENCIMIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUENTABANCO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTIDAD1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OFICINA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DC1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUENTA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONCEPTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACOBRO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFORMAPAGO2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFEMPRESA2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_Iva = New System.Windows.Forms.ComboBox()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.chkRecibo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_serie = New System.Windows.Forms.ComboBox()
        Me.lb_serie = New System.Windows.Forms.Label()
        Me.bt_borrar = New System.Windows.Forms.Button()
        Me.lb_recibos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt_generar = New System.Windows.Forms.Button()
        Me.lb_fechainicial = New System.Windows.Forms.Label()
        Me.dtp_fechaemision = New System.Windows.Forms.DateTimePicker()
        Me.gb_norma = New System.Windows.Forms.GroupBox()
        Me.rb_facturas = New System.Windows.Forms.RadioButton()
        Me.rb_recibos = New System.Windows.Forms.RadioButton()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.bt_Aceptar = New System.Windows.Forms.Button()
        Me.tb_IRPF = New centro_medico.ctrlTextboxAvanzado()
        Me.chkPagoBanco = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_pac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbFacturas.SuspendLayout()
        CType(Me.dgv_Fras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRecibos.SuspendLayout()
        CType(Me.dgvRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.gb_norma.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkPagoBanco)
        Me.GroupBox1.Controls.Add(Me.chkDiferente)
        Me.GroupBox1.Controls.Add(Me.cmbEntidad)
        Me.GroupBox1.Controls.Add(Me.chkFiltraEntidadBancaria)
        Me.GroupBox1.Controls.Add(Me.lblDesseleccionarTodos)
        Me.GroupBox1.Controls.Add(Me.lblSeleccionarTodos)
        Me.GroupBox1.Controls.Add(Me.bt_Filtrar)
        Me.GroupBox1.Controls.Add(Me.cmb_ConceptosFacturables)
        Me.GroupBox1.Controls.Add(Me.chk_FiltrarServicios)
        Me.GroupBox1.Controls.Add(Me.bt_pac)
        Me.GroupBox1.Controls.Add(Me.lb_pac)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgv_pac)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 227)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pacientes con servicios periódicos"
        '
        'chkDiferente
        '
        Me.chkDiferente.AutoSize = True
        Me.chkDiferente.Location = New System.Drawing.Point(343, 34)
        Me.chkDiferente.Name = "chkDiferente"
        Me.chkDiferente.Size = New System.Drawing.Size(38, 17)
        Me.chkDiferente.TabIndex = 141
        Me.chkDiferente.Text = "<>"
        Me.chkDiferente.UseVisualStyleBackColor = True
        '
        'cmbEntidad
        '
        Me.cmbEntidad.FormattingEnabled = True
        Me.cmbEntidad.Location = New System.Drawing.Point(383, 33)
        Me.cmbEntidad.Name = "cmbEntidad"
        Me.cmbEntidad.Size = New System.Drawing.Size(152, 21)
        Me.cmbEntidad.TabIndex = 140
        '
        'chkFiltraEntidadBancaria
        '
        Me.chkFiltraEntidadBancaria.AutoSize = True
        Me.chkFiltraEntidadBancaria.Location = New System.Drawing.Point(343, 16)
        Me.chkFiltraEntidadBancaria.Name = "chkFiltraEntidadBancaria"
        Me.chkFiltraEntidadBancaria.Size = New System.Drawing.Size(153, 17)
        Me.chkFiltraEntidadBancaria.TabIndex = 139
        Me.chkFiltraEntidadBancaria.Text = "Filtrar por Entidad Bancaria"
        Me.chkFiltraEntidadBancaria.UseVisualStyleBackColor = True
        '
        'lblDesseleccionarTodos
        '
        Me.lblDesseleccionarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDesseleccionarTodos.AutoSize = True
        Me.lblDesseleccionarTodos.Location = New System.Drawing.Point(324, 205)
        Me.lblDesseleccionarTodos.Name = "lblDesseleccionarTodos"
        Me.lblDesseleccionarTodos.Size = New System.Drawing.Size(108, 13)
        Me.lblDesseleccionarTodos.TabIndex = 138
        Me.lblDesseleccionarTodos.TabStop = True
        Me.lblDesseleccionarTodos.Text = "Deseleccionar Todos"
        '
        'lblSeleccionarTodos
        '
        Me.lblSeleccionarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeleccionarTodos.AutoSize = True
        Me.lblSeleccionarTodos.Location = New System.Drawing.Point(205, 205)
        Me.lblSeleccionarTodos.Name = "lblSeleccionarTodos"
        Me.lblSeleccionarTodos.Size = New System.Drawing.Size(96, 13)
        Me.lblSeleccionarTodos.TabIndex = 137
        Me.lblSeleccionarTodos.TabStop = True
        Me.lblSeleccionarTodos.Text = "Seleccionar Todos"
        '
        'bt_Filtrar
        '
        Me.bt_Filtrar.Image = Global.centro_medico.My.Resources.Resources.Search1
        Me.bt_Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Filtrar.Location = New System.Drawing.Point(659, 17)
        Me.bt_Filtrar.Name = "bt_Filtrar"
        Me.bt_Filtrar.Size = New System.Drawing.Size(66, 37)
        Me.bt_Filtrar.TabIndex = 37
        Me.bt_Filtrar.Text = "Filtrar"
        Me.bt_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Filtrar.UseVisualStyleBackColor = True
        '
        'cmb_ConceptosFacturables
        '
        Me.cmb_ConceptosFacturables.FormattingEnabled = True
        Me.cmb_ConceptosFacturables.Location = New System.Drawing.Point(12, 33)
        Me.cmb_ConceptosFacturables.Name = "cmb_ConceptosFacturables"
        Me.cmb_ConceptosFacturables.Size = New System.Drawing.Size(237, 21)
        Me.cmb_ConceptosFacturables.TabIndex = 36
        '
        'chk_FiltrarServicios
        '
        Me.chk_FiltrarServicios.AutoSize = True
        Me.chk_FiltrarServicios.Location = New System.Drawing.Point(11, 16)
        Me.chk_FiltrarServicios.Name = "chk_FiltrarServicios"
        Me.chk_FiltrarServicios.Size = New System.Drawing.Size(115, 17)
        Me.chk_FiltrarServicios.TabIndex = 35
        Me.chk_FiltrarServicios.Text = "Filtrar por Servicios"
        Me.chk_FiltrarServicios.UseVisualStyleBackColor = True
        '
        'bt_pac
        '
        Me.bt_pac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_pac.Location = New System.Drawing.Point(596, 200)
        Me.bt_pac.Name = "bt_pac"
        Me.bt_pac.Size = New System.Drawing.Size(130, 23)
        Me.bt_pac.TabIndex = 34
        Me.bt_pac.Text = "Abrir ficha del paciente"
        Me.bt_pac.UseVisualStyleBackColor = True
        '
        'lb_pac
        '
        Me.lb_pac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_pac.AutoSize = True
        Me.lb_pac.Location = New System.Drawing.Point(137, 205)
        Me.lb_pac.Name = "lb_pac"
        Me.lb_pac.Size = New System.Drawing.Size(13, 13)
        Me.lb_pac.TabIndex = 33
        Me.lb_pac.Text = "0"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Total servicios periodicos"
        '
        'dgv_pac
        '
        Me.dgv_pac.AllowUserToAddRows = False
        Me.dgv_pac.AllowUserToDeleteRows = False
        Me.dgv_pac.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_pac.BackgroundColor = System.Drawing.Color.White
        Me.dgv_pac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar, Me.Codigo, Me.CodigoPropio, Me.Nombre, Me.Apellido1, Me.Apellido2, Me.Domicilio, Me.Localidad, Me.Provincia, Me.Entidad, Me.Oficina, Me.DC, Me.Cuenta, Me.Descripcion, Me.RefFormaPago, Me.Importe, Me.CP, Me.DNI, Me.REFCONCEPTO, Me.REFEMPRESA, Me.REFMUTUA})
        Me.dgv_pac.Location = New System.Drawing.Point(11, 60)
        Me.dgv_pac.Name = "dgv_pac"
        Me.dgv_pac.RowHeadersWidth = 15
        Me.dgv_pac.Size = New System.Drawing.Size(715, 138)
        Me.dgv_pac.TabIndex = 31
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Selec"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Width = 40
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "CPaciente"
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 50
        '
        'CodigoPropio
        '
        Me.CodigoPropio.DataPropertyName = "CodigoPropio"
        Me.CodigoPropio.HeaderText = "CodigoPropio"
        Me.CodigoPropio.Name = "CodigoPropio"
        Me.CodigoPropio.ReadOnly = True
        Me.CodigoPropio.Width = 50
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 120
        '
        'Apellido1
        '
        Me.Apellido1.DataPropertyName = "Apellido1"
        Me.Apellido1.HeaderText = "Apellido1"
        Me.Apellido1.Name = "Apellido1"
        Me.Apellido1.ReadOnly = True
        Me.Apellido1.Width = 120
        '
        'Apellido2
        '
        Me.Apellido2.DataPropertyName = "Apellido2"
        Me.Apellido2.HeaderText = "Apellido2"
        Me.Apellido2.Name = "Apellido2"
        Me.Apellido2.ReadOnly = True
        Me.Apellido2.Width = 120
        '
        'Domicilio
        '
        Me.Domicilio.DataPropertyName = "Domicilio"
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.Visible = False
        '
        'Localidad
        '
        Me.Localidad.DataPropertyName = "Localidad"
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.Visible = False
        '
        'Provincia
        '
        Me.Provincia.DataPropertyName = "Provincia"
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Visible = False
        '
        'Entidad
        '
        Me.Entidad.DataPropertyName = "Entidad"
        Me.Entidad.HeaderText = "Entidad"
        Me.Entidad.Name = "Entidad"
        Me.Entidad.Visible = False
        '
        'Oficina
        '
        Me.Oficina.DataPropertyName = "Oficina"
        Me.Oficina.HeaderText = "Oficina"
        Me.Oficina.Name = "Oficina"
        Me.Oficina.Visible = False
        '
        'DC
        '
        Me.DC.DataPropertyName = "DC"
        Me.DC.HeaderText = "DC"
        Me.DC.Name = "DC"
        Me.DC.Visible = False
        '
        'Cuenta
        '
        Me.Cuenta.DataPropertyName = "Cuenta"
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Nombre"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Visible = False
        '
        'RefFormaPago
        '
        Me.RefFormaPago.DataPropertyName = "RefFormaPago"
        Me.RefFormaPago.HeaderText = "RefFormaPago"
        Me.RefFormaPago.Name = "RefFormaPago"
        Me.RefFormaPago.Visible = False
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.Visible = False
        '
        'CP
        '
        Me.CP.DataPropertyName = "CP"
        Me.CP.HeaderText = "CP"
        Me.CP.Name = "CP"
        Me.CP.Visible = False
        '
        'DNI
        '
        Me.DNI.DataPropertyName = "DNI"
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.Visible = False
        '
        'REFCONCEPTO
        '
        Me.REFCONCEPTO.DataPropertyName = "REFCONCEPTO"
        Me.REFCONCEPTO.HeaderText = "REFCONCEPTO"
        Me.REFCONCEPTO.Name = "REFCONCEPTO"
        Me.REFCONCEPTO.Visible = False
        '
        'REFEMPRESA
        '
        Me.REFEMPRESA.DataPropertyName = "REFEMPRESA"
        Me.REFEMPRESA.HeaderText = "REFEMPRESA"
        Me.REFEMPRESA.Name = "REFEMPRESA"
        Me.REFEMPRESA.Visible = False
        '
        'REFMUTUA
        '
        Me.REFMUTUA.DataPropertyName = "REFMUTUA"
        Me.REFMUTUA.HeaderText = "REFMUTUA"
        Me.REFMUTUA.Name = "REFMUTUA"
        Me.REFMUTUA.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.bt_borrar)
        Me.GroupBox2.Controls.Add(Me.lb_recibos)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.bt_generar)
        Me.GroupBox2.Controls.Add(Me.lb_fechainicial)
        Me.GroupBox2.Controls.Add(Me.dtp_fechaemision)
        Me.GroupBox2.Controls.Add(Me.gb_norma)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 251)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generar"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbFacturas)
        Me.TabControl1.Controls.Add(Me.tbRecibos)
        Me.TabControl1.Location = New System.Drawing.Point(7, 47)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(722, 165)
        Me.TabControl1.TabIndex = 137
        '
        'tbFacturas
        '
        Me.tbFacturas.Controls.Add(Me.dgv_Fras)
        Me.tbFacturas.Location = New System.Drawing.Point(4, 22)
        Me.tbFacturas.Name = "tbFacturas"
        Me.tbFacturas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFacturas.Size = New System.Drawing.Size(714, 139)
        Me.tbFacturas.TabIndex = 0
        Me.tbFacturas.Text = "Facturas Generadas"
        Me.tbFacturas.UseVisualStyleBackColor = True
        '
        'dgv_Fras
        '
        Me.dgv_Fras.AllowUserToAddRows = False
        Me.dgv_Fras.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Fras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Fras.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Fras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Fras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.REFSERIE, Me.IDFACTURA, Me.NUMEROFACTURA, Me.REFPACIENTE, Me.PACIENTE, Me.FECHA, Me.HORA, Me.HISTORIAL, Me.REFEMPRESA1, Me.REFMUTUA1, Me.FACCIDENTE, Me.FBAJA, Me.FALTA, Me.FEMISION, Me.PORCENTAJEIRPF, Me.IRPF, Me.TOTAL, Me.DIAGNOSTICO, Me.PAGADA, Me.MUTUA, Me.RECIBO, Me.DIRECCION, Me.LOCALIDAD1, Me.PROVINCIA1, Me.CP1, Me.REFRECIBO, Me.REFCITA, Me.FECHACOBRO, Me.REFFORMAPAGO1, Me.DNI1, Me.EMPRESA, Me.FACTURAR, Me.TIPOIVA})
        Me.dgv_Fras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Fras.Location = New System.Drawing.Point(3, 3)
        Me.dgv_Fras.Name = "dgv_Fras"
        Me.dgv_Fras.ReadOnly = True
        Me.dgv_Fras.RowHeadersVisible = False
        Me.dgv_Fras.Size = New System.Drawing.Size(708, 133)
        Me.dgv_Fras.TabIndex = 42
        '
        'NUMERO
        '
        Me.NUMERO.DataPropertyName = "NUMERO"
        Me.NUMERO.HeaderText = "NUMERO"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        Me.NUMERO.Width = 75
        '
        'REFSERIE
        '
        Me.REFSERIE.DataPropertyName = "REFSERIE"
        Me.REFSERIE.HeaderText = "SERIE"
        Me.REFSERIE.Name = "REFSERIE"
        Me.REFSERIE.ReadOnly = True
        Me.REFSERIE.Width = 50
        '
        'IDFACTURA
        '
        Me.IDFACTURA.DataPropertyName = "IDFACTURA"
        Me.IDFACTURA.HeaderText = "IDFACTURA"
        Me.IDFACTURA.Name = "IDFACTURA"
        Me.IDFACTURA.ReadOnly = True
        Me.IDFACTURA.Visible = False
        '
        'NUMEROFACTURA
        '
        Me.NUMEROFACTURA.DataPropertyName = "NUMEROFACTURA"
        Me.NUMEROFACTURA.HeaderText = "NUMEROFACTURA"
        Me.NUMEROFACTURA.Name = "NUMEROFACTURA"
        Me.NUMEROFACTURA.ReadOnly = True
        Me.NUMEROFACTURA.Visible = False
        '
        'REFPACIENTE
        '
        Me.REFPACIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.REFPACIENTE.DataPropertyName = "REFPACIENTE"
        Me.REFPACIENTE.HeaderText = "COD PAC."
        Me.REFPACIENTE.Name = "REFPACIENTE"
        Me.REFPACIENTE.ReadOnly = True
        Me.REFPACIENTE.Width = 82
        '
        'PACIENTE
        '
        Me.PACIENTE.DataPropertyName = "PACIENTE"
        Me.PACIENTE.HeaderText = "PACIENTE"
        Me.PACIENTE.Name = "PACIENTE"
        Me.PACIENTE.ReadOnly = True
        Me.PACIENTE.Width = 120
        '
        'FECHA
        '
        Me.FECHA.DataPropertyName = "FECHA"
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Visible = False
        '
        'HORA
        '
        Me.HORA.DataPropertyName = "HORA"
        Me.HORA.HeaderText = "HORA"
        Me.HORA.Name = "HORA"
        Me.HORA.ReadOnly = True
        Me.HORA.Visible = False
        '
        'HISTORIAL
        '
        Me.HISTORIAL.DataPropertyName = "HISTORIAL"
        Me.HISTORIAL.HeaderText = "HISTORIAL"
        Me.HISTORIAL.Name = "HISTORIAL"
        Me.HISTORIAL.ReadOnly = True
        Me.HISTORIAL.Visible = False
        '
        'REFEMPRESA1
        '
        Me.REFEMPRESA1.DataPropertyName = "REFEMPRESA"
        Me.REFEMPRESA1.HeaderText = "REFEMPRESA1"
        Me.REFEMPRESA1.Name = "REFEMPRESA1"
        Me.REFEMPRESA1.ReadOnly = True
        Me.REFEMPRESA1.Visible = False
        '
        'REFMUTUA1
        '
        Me.REFMUTUA1.DataPropertyName = "REFMUTUA"
        Me.REFMUTUA1.HeaderText = "REFMUTUA1"
        Me.REFMUTUA1.Name = "REFMUTUA1"
        Me.REFMUTUA1.ReadOnly = True
        Me.REFMUTUA1.Visible = False
        '
        'FACCIDENTE
        '
        Me.FACCIDENTE.DataPropertyName = "FACCIDENTE"
        Me.FACCIDENTE.HeaderText = "FACCIDENTE"
        Me.FACCIDENTE.Name = "FACCIDENTE"
        Me.FACCIDENTE.ReadOnly = True
        Me.FACCIDENTE.Visible = False
        '
        'FBAJA
        '
        Me.FBAJA.DataPropertyName = "FBAJA"
        Me.FBAJA.HeaderText = "FBAJA"
        Me.FBAJA.Name = "FBAJA"
        Me.FBAJA.ReadOnly = True
        Me.FBAJA.Visible = False
        '
        'FALTA
        '
        Me.FALTA.DataPropertyName = "FALTA"
        Me.FALTA.HeaderText = "FALTA"
        Me.FALTA.Name = "FALTA"
        Me.FALTA.ReadOnly = True
        Me.FALTA.Visible = False
        '
        'FEMISION
        '
        Me.FEMISION.DataPropertyName = "FEMISION"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FEMISION.DefaultCellStyle = DataGridViewCellStyle2
        Me.FEMISION.HeaderText = "F.EMI"
        Me.FEMISION.Name = "FEMISION"
        Me.FEMISION.ReadOnly = True
        Me.FEMISION.Width = 75
        '
        'PORCENTAJEIRPF
        '
        Me.PORCENTAJEIRPF.DataPropertyName = "PORCENTAJEIRPF"
        Me.PORCENTAJEIRPF.HeaderText = "%IRPF"
        Me.PORCENTAJEIRPF.Name = "PORCENTAJEIRPF"
        Me.PORCENTAJEIRPF.ReadOnly = True
        Me.PORCENTAJEIRPF.Width = 50
        '
        'IRPF
        '
        Me.IRPF.DataPropertyName = "IRPF"
        Me.IRPF.HeaderText = "IRPF"
        Me.IRPF.Name = "IRPF"
        Me.IRPF.ReadOnly = True
        Me.IRPF.Width = 50
        '
        'TOTAL
        '
        Me.TOTAL.DataPropertyName = "TOTAL"
        DataGridViewCellStyle3.Format = "C"
        Me.TOTAL.DefaultCellStyle = DataGridViewCellStyle3
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Width = 50
        '
        'DIAGNOSTICO
        '
        Me.DIAGNOSTICO.DataPropertyName = "DIAGNOSTICO"
        Me.DIAGNOSTICO.HeaderText = "DIAGNOSTICO"
        Me.DIAGNOSTICO.Name = "DIAGNOSTICO"
        Me.DIAGNOSTICO.ReadOnly = True
        Me.DIAGNOSTICO.Visible = False
        '
        'PAGADA
        '
        Me.PAGADA.DataPropertyName = "PAGADA"
        Me.PAGADA.HeaderText = "PAGADA"
        Me.PAGADA.Name = "PAGADA"
        Me.PAGADA.ReadOnly = True
        Me.PAGADA.Visible = False
        '
        'MUTUA
        '
        Me.MUTUA.DataPropertyName = "MUTUA"
        Me.MUTUA.HeaderText = "MUTUA"
        Me.MUTUA.Name = "MUTUA"
        Me.MUTUA.ReadOnly = True
        Me.MUTUA.Visible = False
        '
        'RECIBO
        '
        Me.RECIBO.DataPropertyName = "RECIBO"
        Me.RECIBO.HeaderText = "RECIBO"
        Me.RECIBO.Name = "RECIBO"
        Me.RECIBO.ReadOnly = True
        Me.RECIBO.Visible = False
        '
        'DIRECCION
        '
        Me.DIRECCION.DataPropertyName = "DIRECCION"
        Me.DIRECCION.HeaderText = "DIRECCION"
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.ReadOnly = True
        Me.DIRECCION.Visible = False
        '
        'LOCALIDAD1
        '
        Me.LOCALIDAD1.DataPropertyName = "LOCALIDAD"
        Me.LOCALIDAD1.HeaderText = "LOCALIDAD"
        Me.LOCALIDAD1.Name = "LOCALIDAD1"
        Me.LOCALIDAD1.ReadOnly = True
        '
        'PROVINCIA1
        '
        Me.PROVINCIA1.DataPropertyName = "PROVINCIA"
        Me.PROVINCIA1.HeaderText = "PROVINCIA"
        Me.PROVINCIA1.Name = "PROVINCIA1"
        Me.PROVINCIA1.ReadOnly = True
        '
        'CP1
        '
        Me.CP1.DataPropertyName = "CP"
        Me.CP1.HeaderText = "CP"
        Me.CP1.Name = "CP1"
        Me.CP1.ReadOnly = True
        Me.CP1.Width = 50
        '
        'REFRECIBO
        '
        Me.REFRECIBO.DataPropertyName = "REFRECIBO"
        Me.REFRECIBO.HeaderText = "REFRECIBO"
        Me.REFRECIBO.Name = "REFRECIBO"
        Me.REFRECIBO.ReadOnly = True
        Me.REFRECIBO.Visible = False
        '
        'REFCITA
        '
        Me.REFCITA.DataPropertyName = "REFCITA"
        Me.REFCITA.HeaderText = "REFCITA"
        Me.REFCITA.Name = "REFCITA"
        Me.REFCITA.ReadOnly = True
        Me.REFCITA.Visible = False
        '
        'FECHACOBRO
        '
        Me.FECHACOBRO.DataPropertyName = "FECHACOBRO"
        Me.FECHACOBRO.HeaderText = "FECHACOBRO"
        Me.FECHACOBRO.Name = "FECHACOBRO"
        Me.FECHACOBRO.ReadOnly = True
        Me.FECHACOBRO.Visible = False
        '
        'REFFORMAPAGO1
        '
        Me.REFFORMAPAGO1.DataPropertyName = "REFFORMAPAGO"
        Me.REFFORMAPAGO1.HeaderText = "REFFORMAPAGO"
        Me.REFFORMAPAGO1.Name = "REFFORMAPAGO1"
        Me.REFFORMAPAGO1.ReadOnly = True
        Me.REFFORMAPAGO1.Visible = False
        '
        'DNI1
        '
        Me.DNI1.DataPropertyName = "DNI"
        Me.DNI1.HeaderText = "DNI"
        Me.DNI1.Name = "DNI1"
        Me.DNI1.ReadOnly = True
        Me.DNI1.Visible = False
        '
        'EMPRESA
        '
        Me.EMPRESA.DataPropertyName = "EMPRESA"
        Me.EMPRESA.HeaderText = "EMPRESA"
        Me.EMPRESA.Name = "EMPRESA"
        Me.EMPRESA.ReadOnly = True
        Me.EMPRESA.Visible = False
        '
        'FACTURAR
        '
        Me.FACTURAR.DataPropertyName = "FACTURAR"
        Me.FACTURAR.HeaderText = "FACTURAR"
        Me.FACTURAR.Name = "FACTURAR"
        Me.FACTURAR.ReadOnly = True
        Me.FACTURAR.Visible = False
        '
        'TIPOIVA
        '
        Me.TIPOIVA.DataPropertyName = "TIPOIVA"
        Me.TIPOIVA.HeaderText = "TIPOIVA"
        Me.TIPOIVA.Name = "TIPOIVA"
        Me.TIPOIVA.ReadOnly = True
        Me.TIPOIVA.Visible = False
        '
        'tbRecibos
        '
        Me.tbRecibos.Controls.Add(Me.dgvRecibos)
        Me.tbRecibos.Location = New System.Drawing.Point(4, 22)
        Me.tbRecibos.Name = "tbRecibos"
        Me.tbRecibos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRecibos.Size = New System.Drawing.Size(714, 139)
        Me.tbRecibos.TabIndex = 1
        Me.tbRecibos.Text = "Recibos Generados"
        Me.tbRecibos.UseVisualStyleBackColor = True
        '
        'dgvRecibos
        '
        Me.dgvRecibos.AllowUserToAddRows = False
        Me.dgvRecibos.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecibos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRecibos.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecibos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO1, Me.FECHAEMISION, Me.REFPACIENTE1, Me.NOMBRE1, Me.COBRADO, Me.EMITIDO, Me.REFCITA1, Me.REFFACTURA, Me.IMPORTE1, Me.FECHAVENCIMIENTO, Me.DIRECCION1, Me.NOTAS, Me.CUENTABANCO, Me.ENTIDAD1, Me.OFICINA1, Me.DC1, Me.CUENTA1, Me.CONCEPTO, Me.FECHACOBRO1, Me.N19, Me.REFFORMAPAGO2, Me.TIPO, Me.REFEMPRESA2})
        Me.dgvRecibos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecibos.Location = New System.Drawing.Point(3, 3)
        Me.dgvRecibos.Name = "dgvRecibos"
        Me.dgvRecibos.ReadOnly = True
        Me.dgvRecibos.RowHeadersVisible = False
        Me.dgvRecibos.Size = New System.Drawing.Size(708, 133)
        Me.dgvRecibos.TabIndex = 43
        '
        'NUMERO1
        '
        Me.NUMERO1.DataPropertyName = "NUMERO"
        Me.NUMERO1.HeaderText = "NUMERO"
        Me.NUMERO1.Name = "NUMERO1"
        Me.NUMERO1.ReadOnly = True
        Me.NUMERO1.Visible = False
        '
        'FECHAEMISION
        '
        Me.FECHAEMISION.DataPropertyName = "FECHAEMISION"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.FECHAEMISION.DefaultCellStyle = DataGridViewCellStyle5
        Me.FECHAEMISION.HeaderText = "F.EMI."
        Me.FECHAEMISION.Name = "FECHAEMISION"
        Me.FECHAEMISION.ReadOnly = True
        '
        'REFPACIENTE1
        '
        Me.REFPACIENTE1.DataPropertyName = "REFPACIENTE"
        Me.REFPACIENTE1.HeaderText = "REFPACIENTE"
        Me.REFPACIENTE1.Name = "REFPACIENTE1"
        Me.REFPACIENTE1.ReadOnly = True
        '
        'NOMBRE1
        '
        Me.NOMBRE1.DataPropertyName = "NOMBRE"
        Me.NOMBRE1.HeaderText = "NOMBRE"
        Me.NOMBRE1.Name = "NOMBRE1"
        Me.NOMBRE1.ReadOnly = True
        Me.NOMBRE1.Width = 150
        '
        'COBRADO
        '
        Me.COBRADO.DataPropertyName = "COBRADO"
        Me.COBRADO.HeaderText = "COBRADO"
        Me.COBRADO.Name = "COBRADO"
        Me.COBRADO.ReadOnly = True
        Me.COBRADO.Visible = False
        '
        'EMITIDO
        '
        Me.EMITIDO.DataPropertyName = "EMITIDO"
        Me.EMITIDO.HeaderText = "EMITIDO"
        Me.EMITIDO.Name = "EMITIDO"
        Me.EMITIDO.ReadOnly = True
        Me.EMITIDO.Visible = False
        '
        'REFCITA1
        '
        Me.REFCITA1.DataPropertyName = "REFCITA"
        Me.REFCITA1.HeaderText = "REFCITA"
        Me.REFCITA1.Name = "REFCITA1"
        Me.REFCITA1.ReadOnly = True
        Me.REFCITA1.Visible = False
        '
        'REFFACTURA
        '
        Me.REFFACTURA.DataPropertyName = "REFFACTURA"
        Me.REFFACTURA.HeaderText = "REFFACTURA"
        Me.REFFACTURA.Name = "REFFACTURA"
        Me.REFFACTURA.ReadOnly = True
        Me.REFFACTURA.Visible = False
        '
        'IMPORTE1
        '
        Me.IMPORTE1.DataPropertyName = "IMPORTE"
        DataGridViewCellStyle6.Format = "C"
        Me.IMPORTE1.DefaultCellStyle = DataGridViewCellStyle6
        Me.IMPORTE1.HeaderText = "IMPORTE"
        Me.IMPORTE1.Name = "IMPORTE1"
        Me.IMPORTE1.ReadOnly = True
        '
        'FECHAVENCIMIENTO
        '
        Me.FECHAVENCIMIENTO.DataPropertyName = "FECHAVENCIMIENTO"
        Me.FECHAVENCIMIENTO.HeaderText = "FECHAVENCIMIENTO"
        Me.FECHAVENCIMIENTO.Name = "FECHAVENCIMIENTO"
        Me.FECHAVENCIMIENTO.ReadOnly = True
        Me.FECHAVENCIMIENTO.Visible = False
        '
        'DIRECCION1
        '
        Me.DIRECCION1.DataPropertyName = "DIRECCION"
        Me.DIRECCION1.HeaderText = "DIRECCION"
        Me.DIRECCION1.Name = "DIRECCION1"
        Me.DIRECCION1.ReadOnly = True
        Me.DIRECCION1.Visible = False
        '
        'NOTAS
        '
        Me.NOTAS.DataPropertyName = "NOTAS"
        Me.NOTAS.HeaderText = "NOTAS"
        Me.NOTAS.Name = "NOTAS"
        Me.NOTAS.ReadOnly = True
        Me.NOTAS.Visible = False
        '
        'CUENTABANCO
        '
        Me.CUENTABANCO.DataPropertyName = "CUENTABANCO"
        Me.CUENTABANCO.HeaderText = "CUENTABANCO"
        Me.CUENTABANCO.Name = "CUENTABANCO"
        Me.CUENTABANCO.ReadOnly = True
        Me.CUENTABANCO.Visible = False
        '
        'ENTIDAD1
        '
        Me.ENTIDAD1.DataPropertyName = "ENTIDAD"
        Me.ENTIDAD1.HeaderText = "ENTIDAD"
        Me.ENTIDAD1.Name = "ENTIDAD1"
        Me.ENTIDAD1.ReadOnly = True
        Me.ENTIDAD1.Visible = False
        '
        'OFICINA1
        '
        Me.OFICINA1.DataPropertyName = "OFICINA"
        Me.OFICINA1.HeaderText = "OFICINA"
        Me.OFICINA1.Name = "OFICINA1"
        Me.OFICINA1.ReadOnly = True
        Me.OFICINA1.Visible = False
        '
        'DC1
        '
        Me.DC1.DataPropertyName = "DC"
        Me.DC1.HeaderText = "DC"
        Me.DC1.Name = "DC1"
        Me.DC1.ReadOnly = True
        Me.DC1.Visible = False
        '
        'CUENTA1
        '
        Me.CUENTA1.DataPropertyName = "CUENTA"
        Me.CUENTA1.HeaderText = "CUENTA"
        Me.CUENTA1.Name = "CUENTA1"
        Me.CUENTA1.ReadOnly = True
        Me.CUENTA1.Visible = False
        '
        'CONCEPTO
        '
        Me.CONCEPTO.DataPropertyName = "CONCEPTO"
        Me.CONCEPTO.HeaderText = "CONCEPTO"
        Me.CONCEPTO.Name = "CONCEPTO"
        Me.CONCEPTO.ReadOnly = True
        Me.CONCEPTO.Visible = False
        '
        'FECHACOBRO1
        '
        Me.FECHACOBRO1.DataPropertyName = "FECHACOBRO"
        Me.FECHACOBRO1.HeaderText = "FECHACOBRO"
        Me.FECHACOBRO1.Name = "FECHACOBRO1"
        Me.FECHACOBRO1.ReadOnly = True
        Me.FECHACOBRO1.Visible = False
        '
        'N19
        '
        Me.N19.DataPropertyName = "N19"
        Me.N19.HeaderText = "N19"
        Me.N19.Name = "N19"
        Me.N19.ReadOnly = True
        Me.N19.Visible = False
        '
        'REFFORMAPAGO2
        '
        Me.REFFORMAPAGO2.DataPropertyName = "REFFORMAPAGO"
        Me.REFFORMAPAGO2.HeaderText = "REFFORMAPAGO"
        Me.REFFORMAPAGO2.Name = "REFFORMAPAGO2"
        Me.REFFORMAPAGO2.ReadOnly = True
        Me.REFFORMAPAGO2.Visible = False
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "TIPO"
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.Visible = False
        '
        'REFEMPRESA2
        '
        Me.REFEMPRESA2.DataPropertyName = "REFEMPRESA"
        Me.REFEMPRESA2.HeaderText = "REFEMPRESA"
        Me.REFEMPRESA2.Name = "REFEMPRESA2"
        Me.REFEMPRESA2.ReadOnly = True
        Me.REFEMPRESA2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_Iva)
        Me.GroupBox3.Controls.Add(Me.lblIva)
        Me.GroupBox3.Controls.Add(Me.chkRecibo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.tb_IRPF)
        Me.GroupBox3.Controls.Add(Me.cb_serie)
        Me.GroupBox3.Controls.Add(Me.lb_serie)
        Me.GroupBox3.Location = New System.Drawing.Point(360, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 36)
        Me.GroupBox3.TabIndex = 136
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Solo válido para Fras"
        Me.GroupBox3.Visible = False
        '
        'cb_Iva
        '
        Me.cb_Iva.DisplayMember = "CODIGO"
        Me.cb_Iva.Items.AddRange(New Object() {"0", "16", "7", "4"})
        Me.cb_Iva.Location = New System.Drawing.Point(146, 13)
        Me.cb_Iva.Name = "cb_Iva"
        Me.cb_Iva.Size = New System.Drawing.Size(58, 21)
        Me.cb_Iva.TabIndex = 139
        Me.cb_Iva.ValueMember = "CODIGO"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(118, 16)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(22, 13)
        Me.lblIva.TabIndex = 140
        Me.lblIva.Text = "Iva"
        '
        'chkRecibo
        '
        Me.chkRecibo.AutoSize = True
        Me.chkRecibo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRecibo.Location = New System.Drawing.Point(306, 14)
        Me.chkRecibo.Name = "chkRecibo"
        Me.chkRecibo.Size = New System.Drawing.Size(60, 17)
        Me.chkRecibo.TabIndex = 138
        Me.chkRecibo.Text = "Recibo"
        Me.chkRecibo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "IRPF (%)"
        '
        'cb_serie
        '
        Me.cb_serie.DisplayMember = "CODIGO"
        Me.cb_serie.Location = New System.Drawing.Point(45, 13)
        Me.cb_serie.Name = "cb_serie"
        Me.cb_serie.Size = New System.Drawing.Size(67, 21)
        Me.cb_serie.TabIndex = 134
        Me.cb_serie.ValueMember = "CODIGO"
        '
        'lb_serie
        '
        Me.lb_serie.AutoSize = True
        Me.lb_serie.Location = New System.Drawing.Point(8, 16)
        Me.lb_serie.Name = "lb_serie"
        Me.lb_serie.Size = New System.Drawing.Size(31, 13)
        Me.lb_serie.TabIndex = 135
        Me.lb_serie.Text = "Serie"
        '
        'bt_borrar
        '
        Me.bt_borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_borrar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.bt_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_borrar.Location = New System.Drawing.Point(605, 218)
        Me.bt_borrar.Name = "bt_borrar"
        Me.bt_borrar.Size = New System.Drawing.Size(121, 28)
        Me.bt_borrar.TabIndex = 40
        Me.bt_borrar.Text = "Borrar generados"
        Me.bt_borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_borrar.UseVisualStyleBackColor = True
        '
        'lb_recibos
        '
        Me.lb_recibos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_recibos.AutoSize = True
        Me.lb_recibos.Location = New System.Drawing.Point(166, 226)
        Me.lb_recibos.Name = "lb_recibos"
        Me.lb_recibos.Size = New System.Drawing.Size(13, 13)
        Me.lb_recibos.TabIndex = 39
        Me.lb_recibos.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Total de documentos a generar"
        '
        'bt_generar
        '
        Me.bt_generar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_generar.Image = Global.centro_medico.My.Resources.Resources.Checked
        Me.bt_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_generar.Location = New System.Drawing.Point(496, 217)
        Me.bt_generar.Name = "bt_generar"
        Me.bt_generar.Size = New System.Drawing.Size(94, 28)
        Me.bt_generar.TabIndex = 37
        Me.bt_generar.Text = "Generar "
        Me.bt_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_generar.UseVisualStyleBackColor = True
        '
        'lb_fechainicial
        '
        Me.lb_fechainicial.AutoSize = True
        Me.lb_fechainicial.Location = New System.Drawing.Point(3, 21)
        Me.lb_fechainicial.Name = "lb_fechainicial"
        Me.lb_fechainicial.Size = New System.Drawing.Size(90, 13)
        Me.lb_fechainicial.TabIndex = 36
        Me.lb_fechainicial.Text = "Fecha de emisión"
        '
        'dtp_fechaemision
        '
        Me.dtp_fechaemision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaemision.Location = New System.Drawing.Point(99, 17)
        Me.dtp_fechaemision.Name = "dtp_fechaemision"
        Me.dtp_fechaemision.Size = New System.Drawing.Size(83, 20)
        Me.dtp_fechaemision.TabIndex = 35
        '
        'gb_norma
        '
        Me.gb_norma.Controls.Add(Me.rb_facturas)
        Me.gb_norma.Controls.Add(Me.rb_recibos)
        Me.gb_norma.Location = New System.Drawing.Point(188, 8)
        Me.gb_norma.Name = "gb_norma"
        Me.gb_norma.Size = New System.Drawing.Size(166, 36)
        Me.gb_norma.TabIndex = 34
        Me.gb_norma.TabStop = False
        Me.gb_norma.Text = "Documentos a generar"
        '
        'rb_facturas
        '
        Me.rb_facturas.AutoSize = True
        Me.rb_facturas.Location = New System.Drawing.Point(92, 14)
        Me.rb_facturas.Name = "rb_facturas"
        Me.rb_facturas.Size = New System.Drawing.Size(66, 17)
        Me.rb_facturas.TabIndex = 1
        Me.rb_facturas.Text = "Facturas"
        Me.rb_facturas.UseVisualStyleBackColor = True
        '
        'rb_recibos
        '
        Me.rb_recibos.AutoSize = True
        Me.rb_recibos.Checked = True
        Me.rb_recibos.Location = New System.Drawing.Point(6, 14)
        Me.rb_recibos.Name = "rb_recibos"
        Me.rb_recibos.Size = New System.Drawing.Size(64, 17)
        Me.rb_recibos.TabIndex = 0
        Me.rb_recibos.TabStop = True
        Me.rb_recibos.Text = "Recibos"
        Me.rb_recibos.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(673, 493)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 30)
        Me.bt_cancelar.TabIndex = 2
        Me.bt_cancelar.Text = "Cerrar  "
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'bt_Aceptar
        '
        Me.bt_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Aceptar.Image = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Aceptar.Location = New System.Drawing.Point(592, 493)
        Me.bt_Aceptar.Name = "bt_Aceptar"
        Me.bt_Aceptar.Size = New System.Drawing.Size(75, 30)
        Me.bt_Aceptar.TabIndex = 3
        Me.bt_Aceptar.Text = "Aceptar"
        Me.bt_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Aceptar.UseVisualStyleBackColor = True
        '
        'tb_IRPF
        '
        Me.tb_IRPF.AcceptsReturn = True
        Me.tb_IRPF.Location = New System.Drawing.Point(265, 13)
        Me.tb_IRPF.Name = "tb_IRPF"
        Me.tb_IRPF.Size = New System.Drawing.Size(39, 20)
        Me.tb_IRPF.TabIndex = 136
        Me.tb_IRPF.Text = "0"
        '
        'chkPagoBanco
        '
        Me.chkPagoBanco.AutoSize = True
        Me.chkPagoBanco.Location = New System.Drawing.Point(522, 16)
        Me.chkPagoBanco.Name = "chkPagoBanco"
        Me.chkPagoBanco.Size = New System.Drawing.Size(130, 17)
        Me.chkPagoBanco.TabIndex = 142
        Me.chkPagoBanco.Text = "Activado Pago Banco"
        Me.chkPagoBanco.UseVisualStyleBackColor = True
        '
        'form_generar_recfact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(756, 527)
        Me.Controls.Add(Me.bt_Aceptar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "form_generar_recfact"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar conceptos mensuales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_pac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbFacturas.ResumeLayout(False)
        CType(Me.dgv_Fras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRecibos.ResumeLayout(False)
        CType(Me.dgvRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gb_norma.ResumeLayout(False)
        Me.gb_norma.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents dgv_pac As System.Windows.Forms.DataGridView
    Friend WithEvents lb_pac As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_pac As System.Windows.Forms.Button
    Friend WithEvents gb_norma As System.Windows.Forms.GroupBox
    Friend WithEvents rb_facturas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recibos As System.Windows.Forms.RadioButton
    Friend WithEvents lb_fechainicial As System.Windows.Forms.Label
    Friend WithEvents dtp_fechaemision As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_generar As System.Windows.Forms.Button
    Friend WithEvents dgv_Fras As System.Windows.Forms.DataGridView
    Friend WithEvents bt_borrar As System.Windows.Forms.Button
    Friend WithEvents lb_recibos As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_serie As System.Windows.Forms.Label
    Friend WithEvents cb_serie As System.Windows.Forms.ComboBox
    Friend WithEvents bt_Filtrar As System.Windows.Forms.Button
    Friend WithEvents cmb_ConceptosFacturables As System.Windows.Forms.ComboBox
    Friend WithEvents chk_FiltrarServicios As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_IRPF As ctrlTextboxAvanzado
    Friend WithEvents chkRecibo As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Iva As System.Windows.Forms.ComboBox
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoPropio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Oficina As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefFormaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCONCEPTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFEMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFMUTUA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_Aceptar As System.Windows.Forms.Button
    Friend WithEvents lblDesseleccionarTodos As System.Windows.Forms.LinkLabel
    Friend WithEvents lblSeleccionarTodos As System.Windows.Forms.LinkLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbFacturas As System.Windows.Forms.TabPage
    Friend WithEvents tbRecibos As System.Windows.Forms.TabPage
    Friend WithEvents dgvRecibos As System.Windows.Forms.DataGridView
    Friend WithEvents NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFSERIE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDFACTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMEROFACTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFPACIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HISTORIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFEMPRESA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFMUTUA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FACCIDENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FBAJA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FALTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FEMISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PORCENTAJEIRPF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IRPF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIAGNOSTICO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAGADA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MUTUA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECIBO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOCALIDAD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROVINCIA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFRECIBO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHACOBRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFORMAPAGO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNI1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FACTURAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMERO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAEMISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFPACIENTE1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COBRADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMITIDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCITA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFACTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAVENCIMIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUENTABANCO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENTIDAD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OFICINA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DC1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUENTA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONCEPTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHACOBRO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFORMAPAGO2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFEMPRESA2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbEntidad As System.Windows.Forms.ComboBox
    Friend WithEvents chkFiltraEntidadBancaria As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiferente As System.Windows.Forms.CheckBox
    Friend WithEvents chkPagoBanco As System.Windows.Forms.CheckBox
End Class
