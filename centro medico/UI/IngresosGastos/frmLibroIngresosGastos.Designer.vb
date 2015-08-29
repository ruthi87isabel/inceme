<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibroIngresosGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroIngresosGastos))
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.grpFiltrar = New System.Windows.Forms.GroupBox()
        Me.chkInclurDocImporte0 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaPagoFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaPagoInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblInfoFechaPago = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.grpFecha = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkTPVFacturasProveedor = New System.Windows.Forms.CheckBox()
        Me.chkGastosVarios = New System.Windows.Forms.CheckBox()
        Me.chkDoctores = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkEntregasACuenta = New System.Windows.Forms.CheckBox()
        Me.chkTickets = New System.Windows.Forms.CheckBox()
        Me.chkCitas = New System.Windows.Forms.CheckBox()
        Me.chkRecibos = New System.Windows.Forms.CheckBox()
        Me.chkTPVFacturas = New System.Windows.Forms.CheckBox()
        Me.chkFacturas = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_sincobrar = New System.Windows.Forms.RadioButton()
        Me.rb_cobradas = New System.Windows.Forms.RadioButton()
        Me.rb_todascobrar = New System.Windows.Forms.RadioButton()
        Me.lblRestringirSemana = New System.Windows.Forms.Label()
        Me.pnl_Loading = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pb_Loading = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPendiente = New System.Windows.Forms.Label()
        Me.bt_cerrar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDiferencia = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblGastos = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblIngresos = New System.Windows.Forms.Label()
        Me.bt_imprimir = New System.Windows.Forms.Button()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.lblCredito = New System.Windows.Forms.Label()
        Me.lblCreditoText = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPagoCuentaCredito = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        Me.grpFiltrar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpFecha.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnl_Loading.SuspendLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpFiltrar
        '
        Me.grpFiltrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltrar.Controls.Add(Me.chkInclurDocImporte0)
        Me.grpFiltrar.Controls.Add(Me.GroupBox1)
        Me.grpFiltrar.Controls.Add(Me.btnFiltrar)
        Me.grpFiltrar.Controls.Add(Me.grpFecha)
        Me.grpFiltrar.Controls.Add(Me.CtrlFormaPago21)
        Me.grpFiltrar.Controls.Add(Me.GroupBox5)
        Me.grpFiltrar.Controls.Add(Me.GroupBox4)
        Me.grpFiltrar.Controls.Add(Me.GroupBox3)
        Me.grpFiltrar.Location = New System.Drawing.Point(0, 16)
        Me.grpFiltrar.Name = "grpFiltrar"
        Me.grpFiltrar.Size = New System.Drawing.Size(982, 199)
        Me.grpFiltrar.TabIndex = 0
        Me.grpFiltrar.TabStop = False
        Me.grpFiltrar.Text = "Filtros"
        '
        'chkInclurDocImporte0
        '
        Me.chkInclurDocImporte0.AutoSize = True
        Me.chkInclurDocImporte0.Checked = True
        Me.chkInclurDocImporte0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInclurDocImporte0.Location = New System.Drawing.Point(376, 170)
        Me.chkInclurDocImporte0.Name = "chkInclurDocImporte0"
        Me.chkInclurDocImporte0.Size = New System.Drawing.Size(177, 17)
        Me.chkInclurDocImporte0.TabIndex = 127
        Me.chkInclurDocImporte0.Text = "Incluir documentos de Importe 0"
        Me.chkInclurDocImporte0.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFechaPagoFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaPagoInicial)
        Me.GroupBox1.Controls.Add(Me.lblInfoFechaPago)
        Me.GroupBox1.Location = New System.Drawing.Point(752, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 110)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha Pago"
        Me.GroupBox1.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Fecha Pago Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Fecha Pago Final"
        '
        'dtpFechaPagoFinal
        '
        Me.dtpFechaPagoFinal.Checked = False
        Me.dtpFechaPagoFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPagoFinal.Location = New System.Drawing.Point(12, 72)
        Me.dtpFechaPagoFinal.Name = "dtpFechaPagoFinal"
        Me.dtpFechaPagoFinal.ShowCheckBox = True
        Me.dtpFechaPagoFinal.Size = New System.Drawing.Size(107, 20)
        Me.dtpFechaPagoFinal.TabIndex = 66
        '
        'dtpFechaPagoInicial
        '
        Me.dtpFechaPagoInicial.Checked = False
        Me.dtpFechaPagoInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPagoInicial.Location = New System.Drawing.Point(12, 32)
        Me.dtpFechaPagoInicial.Name = "dtpFechaPagoInicial"
        Me.dtpFechaPagoInicial.ShowCheckBox = True
        Me.dtpFechaPagoInicial.Size = New System.Drawing.Size(107, 20)
        Me.dtpFechaPagoInicial.TabIndex = 65
        '
        'lblInfoFechaPago
        '
        Me.lblInfoFechaPago.AutoSize = True
        Me.lblInfoFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoFechaPago.Location = New System.Drawing.Point(13, 95)
        Me.lblInfoFechaPago.Name = "lblInfoFechaPago"
        Me.lblInfoFechaPago.Size = New System.Drawing.Size(109, 13)
        Me.lblInfoFechaPago.TabIndex = 69
        Me.lblInfoFechaPago.Text = "No aplicable a gastos"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(749, 144)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 36)
        Me.btnFiltrar.TabIndex = 124
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'grpFecha
        '
        Me.grpFecha.Controls.Add(Me.Label14)
        Me.grpFecha.Controls.Add(Me.dtp_ff)
        Me.grpFecha.Controls.Add(Me.dtpHoraFinal)
        Me.grpFecha.Controls.Add(Me.dtpHoraInicio)
        Me.grpFecha.Controls.Add(Me.dtp_fi)
        Me.grpFecha.Controls.Add(Me.Label11)
        Me.grpFecha.Controls.Add(Me.Label2)
        Me.grpFecha.Controls.Add(Me.Label3)
        Me.grpFecha.Controls.Add(Me.Label4)
        Me.grpFecha.Location = New System.Drawing.Point(482, 18)
        Me.grpFecha.Name = "grpFecha"
        Me.grpFecha.Size = New System.Drawing.Size(264, 111)
        Me.grpFecha.TabIndex = 123
        Me.grpFecha.TabStop = False
        Me.grpFecha.Text = "Fecha"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(149, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 13)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "No aplicable a gastos"
        '
        'dtp_ff
        '
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(17, 73)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.ShowCheckBox = True
        Me.dtp_ff.Size = New System.Drawing.Size(107, 20)
        Me.dtp_ff.TabIndex = 66
        '
        'dtpHoraFinal
        '
        Me.dtpHoraFinal.Checked = False
        Me.dtpHoraFinal.CustomFormat = "HH:mm"
        Me.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFinal.Location = New System.Drawing.Point(162, 73)
        Me.dtpHoraFinal.Name = "dtpHoraFinal"
        Me.dtpHoraFinal.ShowCheckBox = True
        Me.dtpHoraFinal.ShowUpDown = True
        Me.dtpHoraFinal.Size = New System.Drawing.Size(77, 20)
        Me.dtpHoraFinal.TabIndex = 65
        Me.dtpHoraFinal.Value = New Date(2013, 10, 10, 12, 0, 0, 0)
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.Checked = False
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(162, 31)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowCheckBox = True
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(77, 20)
        Me.dtpHoraInicio.TabIndex = 65
        Me.dtpHoraInicio.Value = New Date(2013, 10, 10, 0, 0, 0, 0)
        '
        'dtp_fi
        '
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(17, 33)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.ShowCheckBox = True
        Me.dtp_fi.Size = New System.Drawing.Size(107, 20)
        Me.dtp_fi.TabIndex = 65
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(164, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Hora Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Hora Inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Fecha Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Fecha final"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkTPVFacturasProveedor)
        Me.GroupBox5.Controls.Add(Me.chkGastosVarios)
        Me.GroupBox5.Controls.Add(Me.chkDoctores)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 130)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(354, 63)
        Me.GroupBox5.TabIndex = 121
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Gastos"
        '
        'chkTPVFacturasProveedor
        '
        Me.chkTPVFacturasProveedor.AutoSize = True
        Me.chkTPVFacturasProveedor.Location = New System.Drawing.Point(224, 19)
        Me.chkTPVFacturasProveedor.Name = "chkTPVFacturasProveedor"
        Me.chkTPVFacturasProveedor.Size = New System.Drawing.Size(119, 17)
        Me.chkTPVFacturasProveedor.TabIndex = 5
        Me.chkTPVFacturasProveedor.Text = "TPV Facturas Prov."
        Me.chkTPVFacturasProveedor.UseVisualStyleBackColor = True
        Me.chkTPVFacturasProveedor.Visible = False
        '
        'chkGastosVarios
        '
        Me.chkGastosVarios.AutoSize = True
        Me.chkGastosVarios.Checked = True
        Me.chkGastosVarios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGastosVarios.Location = New System.Drawing.Point(6, 19)
        Me.chkGastosVarios.Name = "chkGastosVarios"
        Me.chkGastosVarios.Size = New System.Drawing.Size(90, 17)
        Me.chkGastosVarios.TabIndex = 3
        Me.chkGastosVarios.Text = "Gastos varios"
        Me.chkGastosVarios.UseVisualStyleBackColor = True
        '
        'chkDoctores
        '
        Me.chkDoctores.AutoSize = True
        Me.chkDoctores.Checked = True
        Me.chkDoctores.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDoctores.Location = New System.Drawing.Point(99, 19)
        Me.chkDoctores.Name = "chkDoctores"
        Me.chkDoctores.Size = New System.Drawing.Size(119, 17)
        Me.chkDoctores.TabIndex = 4
        Me.chkDoctores.Text = "Importes a doctores"
        Me.chkDoctores.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkEntregasACuenta)
        Me.GroupBox4.Controls.Add(Me.chkTickets)
        Me.GroupBox4.Controls.Add(Me.chkCitas)
        Me.GroupBox4.Controls.Add(Me.chkRecibos)
        Me.GroupBox4.Controls.Add(Me.chkTPVFacturas)
        Me.GroupBox4.Controls.Add(Me.chkFacturas)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 111)
        Me.GroupBox4.TabIndex = 119
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingresos"
        '
        'chkEntregasACuenta
        '
        Me.chkEntregasACuenta.AutoSize = True
        Me.chkEntregasACuenta.Checked = True
        Me.chkEntregasACuenta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEntregasACuenta.Location = New System.Drawing.Point(195, 57)
        Me.chkEntregasACuenta.Name = "chkEntregasACuenta"
        Me.chkEntregasACuenta.Size = New System.Drawing.Size(114, 17)
        Me.chkEntregasACuenta.TabIndex = 4
        Me.chkEntregasACuenta.Text = "Entregas a Cuenta"
        Me.chkEntregasACuenta.UseVisualStyleBackColor = True
        '
        'chkTickets
        '
        Me.chkTickets.AutoSize = True
        Me.chkTickets.Checked = True
        Me.chkTickets.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTickets.Location = New System.Drawing.Point(280, 24)
        Me.chkTickets.Name = "chkTickets"
        Me.chkTickets.Size = New System.Drawing.Size(61, 17)
        Me.chkTickets.TabIndex = 3
        Me.chkTickets.Text = "Tickets"
        Me.chkTickets.UseVisualStyleBackColor = True
        '
        'chkCitas
        '
        Me.chkCitas.AutoSize = True
        Me.chkCitas.Checked = True
        Me.chkCitas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCitas.Location = New System.Drawing.Point(195, 24)
        Me.chkCitas.Name = "chkCitas"
        Me.chkCitas.Size = New System.Drawing.Size(49, 17)
        Me.chkCitas.TabIndex = 2
        Me.chkCitas.Text = "Citas"
        Me.chkCitas.UseVisualStyleBackColor = True
        '
        'chkRecibos
        '
        Me.chkRecibos.AutoSize = True
        Me.chkRecibos.Checked = True
        Me.chkRecibos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecibos.Location = New System.Drawing.Point(101, 24)
        Me.chkRecibos.Name = "chkRecibos"
        Me.chkRecibos.Size = New System.Drawing.Size(65, 17)
        Me.chkRecibos.TabIndex = 1
        Me.chkRecibos.Text = "Recibos"
        Me.chkRecibos.UseVisualStyleBackColor = True
        '
        'chkTPVFacturas
        '
        Me.chkTPVFacturas.AutoSize = True
        Me.chkTPVFacturas.Checked = True
        Me.chkTPVFacturas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTPVFacturas.Location = New System.Drawing.Point(8, 57)
        Me.chkTPVFacturas.Name = "chkTPVFacturas"
        Me.chkTPVFacturas.Size = New System.Drawing.Size(91, 17)
        Me.chkTPVFacturas.TabIndex = 0
        Me.chkTPVFacturas.Text = "TPV Facturas"
        Me.chkTPVFacturas.UseVisualStyleBackColor = True
        '
        'chkFacturas
        '
        Me.chkFacturas.AutoSize = True
        Me.chkFacturas.Checked = True
        Me.chkFacturas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFacturas.Location = New System.Drawing.Point(8, 24)
        Me.chkFacturas.Name = "chkFacturas"
        Me.chkFacturas.Size = New System.Drawing.Size(67, 17)
        Me.chkFacturas.TabIndex = 0
        Me.chkFacturas.Text = "Facturas"
        Me.chkFacturas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_sincobrar)
        Me.GroupBox3.Controls.Add(Me.rb_cobradas)
        Me.GroupBox3.Controls.Add(Me.rb_todascobrar)
        Me.GroupBox3.Location = New System.Drawing.Point(366, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(95, 111)
        Me.GroupBox3.TabIndex = 120
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado"
        Me.GroupBox3.Visible = False
        '
        'rb_sincobrar
        '
        Me.rb_sincobrar.AutoSize = True
        Me.rb_sincobrar.Location = New System.Drawing.Point(6, 69)
        Me.rb_sincobrar.Name = "rb_sincobrar"
        Me.rb_sincobrar.Size = New System.Drawing.Size(73, 17)
        Me.rb_sincobrar.TabIndex = 2
        Me.rb_sincobrar.Text = "Sin cobrar"
        Me.rb_sincobrar.UseVisualStyleBackColor = True
        '
        'rb_cobradas
        '
        Me.rb_cobradas.AutoSize = True
        Me.rb_cobradas.Checked = True
        Me.rb_cobradas.Location = New System.Drawing.Point(6, 46)
        Me.rb_cobradas.Name = "rb_cobradas"
        Me.rb_cobradas.Size = New System.Drawing.Size(70, 17)
        Me.rb_cobradas.TabIndex = 1
        Me.rb_cobradas.TabStop = True
        Me.rb_cobradas.Text = "Cobradas"
        Me.rb_cobradas.UseVisualStyleBackColor = True
        '
        'rb_todascobrar
        '
        Me.rb_todascobrar.AutoSize = True
        Me.rb_todascobrar.Location = New System.Drawing.Point(6, 23)
        Me.rb_todascobrar.Name = "rb_todascobrar"
        Me.rb_todascobrar.Size = New System.Drawing.Size(55, 17)
        Me.rb_todascobrar.TabIndex = 0
        Me.rb_todascobrar.Text = "Todas"
        Me.rb_todascobrar.UseVisualStyleBackColor = True
        '
        'lblRestringirSemana
        '
        Me.lblRestringirSemana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRestringirSemana.AutoSize = True
        Me.lblRestringirSemana.ForeColor = System.Drawing.Color.Red
        Me.lblRestringirSemana.Location = New System.Drawing.Point(587, 3)
        Me.lblRestringirSemana.Name = "lblRestringirSemana"
        Me.lblRestringirSemana.Size = New System.Drawing.Size(391, 13)
        Me.lblRestringirSemana.TabIndex = 125
        Me.lblRestringirSemana.Text = "Las fechas han sido restringidas a una semana debido a sus permisos de acceso."
        Me.lblRestringirSemana.Visible = False
        '
        'pnl_Loading
        '
        Me.pnl_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Loading.Controls.Add(Me.Label10)
        Me.pnl_Loading.Controls.Add(Me.pb_Loading)
        Me.pnl_Loading.Location = New System.Drawing.Point(415, 339)
        Me.pnl_Loading.Name = "pnl_Loading"
        Me.pnl_Loading.Size = New System.Drawing.Size(123, 48)
        Me.pnl_Loading.TabIndex = 132
        Me.pnl_Loading.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "Filtrando..."
        '
        'pb_Loading
        '
        Me.pb_Loading.Image = CType(resources.GetObject("pb_Loading.Image"), System.Drawing.Image)
        Me.pb_Loading.Location = New System.Drawing.Point(13, 8)
        Me.pb_Loading.Name = "pb_Loading"
        Me.pb_Loading.Size = New System.Drawing.Size(40, 35)
        Me.pb_Loading.TabIndex = 118
        Me.pb_Loading.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(9, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 60)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "Los documentos cuya Fecha de cobro sea diferente a la fecha de emisión del docume" & _
    "nto, aparecerán en el cuadro de importe pendiente."
        Me.Label8.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(546, 511)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Pendiente"
        Me.Label5.Visible = False
        '
        'lblPendiente
        '
        Me.lblPendiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPendiente.Location = New System.Drawing.Point(549, 528)
        Me.lblPendiente.Name = "lblPendiente"
        Me.lblPendiente.Size = New System.Drawing.Size(100, 23)
        Me.lblPendiente.TabIndex = 130
        Me.lblPendiente.Text = "0.00  € "
        Me.lblPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPendiente.Visible = False
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cerrar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cerrar.Location = New System.Drawing.Point(906, 558)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 28)
        Me.bt_cerrar.TabIndex = 126
        Me.bt_cerrar.Text = "Cancelar"
        Me.bt_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(867, 512)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "Diferencia"
        '
        'lblDiferencia
        '
        Me.lblDiferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiferencia.Location = New System.Drawing.Point(870, 529)
        Me.lblDiferencia.Name = "lblDiferencia"
        Me.lblDiferencia.Size = New System.Drawing.Size(106, 23)
        Me.lblDiferencia.TabIndex = 124
        Me.lblDiferencia.Text = "0.00  €"
        Me.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(761, 511)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Gastos"
        '
        'lblGastos
        '
        Me.lblGastos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGastos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGastos.Location = New System.Drawing.Point(764, 528)
        Me.lblGastos.Name = "lblGastos"
        Me.lblGastos.Size = New System.Drawing.Size(100, 23)
        Me.lblGastos.TabIndex = 123
        Me.lblGastos.Text = "0.00  €"
        Me.lblGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(655, 511)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Ingresos"
        '
        'lblIngresos
        '
        Me.lblIngresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIngresos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIngresos.Location = New System.Drawing.Point(658, 528)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(100, 23)
        Me.lblIngresos.TabIndex = 122
        Me.lblIngresos.Text = "0.00  € "
        Me.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir.Image = CType(resources.GetObject("bt_imprimir.Image"), System.Drawing.Image)
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(824, 558)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(76, 28)
        Me.bt_imprimir.TabIndex = 125
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.ColumnAutoResize = True
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 221)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(981, 287)
        Me.GridEX1.TabIndex = 133
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'lblCredito
        '
        Me.lblCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCredito.Location = New System.Drawing.Point(438, 529)
        Me.lblCredito.Name = "lblCredito"
        Me.lblCredito.Size = New System.Drawing.Size(100, 23)
        Me.lblCredito.TabIndex = 135
        Me.lblCredito.Text = "0.00  € "
        Me.lblCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCreditoText
        '
        Me.lblCreditoText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreditoText.AutoSize = True
        Me.lblCreditoText.Location = New System.Drawing.Point(435, 512)
        Me.lblCreditoText.Name = "lblCreditoText"
        Me.lblCreditoText.Size = New System.Drawing.Size(40, 13)
        Me.lblCreditoText.TabIndex = 134
        Me.lblCreditoText.Text = "Crédito"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(283, 512)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 13)
        Me.Label13.TabIndex = 134
        Me.Label13.Text = "Pagos a cuenta con crédito"
        '
        'lblPagoCuentaCredito
        '
        Me.lblPagoCuentaCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPagoCuentaCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPagoCuentaCredito.Location = New System.Drawing.Point(286, 529)
        Me.lblPagoCuentaCredito.Name = "lblPagoCuentaCredito"
        Me.lblPagoCuentaCredito.Size = New System.Drawing.Size(100, 23)
        Me.lblPagoCuentaCredito.TabIndex = 135
        Me.lblPagoCuentaCredito.Text = "0.00  € "
        Me.lblPagoCuentaCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(984, 589)
        Me.ShapeContainer1.TabIndex = 136
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 652
        Me.LineShape1.X2 = 652
        Me.LineShape1.Y1 = 507
        Me.LineShape1.Y2 = 586
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(372, 135)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(315, 23)
        Me.CtrlFormaPago21.TabIndex = 122
        '
        'frmLibroIngresosGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 589)
        Me.Controls.Add(Me.lblRestringirSemana)
        Me.Controls.Add(Me.lblPagoCuentaCredito)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblCredito)
        Me.Controls.Add(Me.lblCreditoText)
        Me.Controls.Add(Me.lblPendiente)
        Me.Controls.Add(Me.lblDiferencia)
        Me.Controls.Add(Me.lblGastos)
        Me.Controls.Add(Me.lblIngresos)
        Me.Controls.Add(Me.pnl_Loading)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.grpFiltrar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmLibroIngresosGastos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro de Ingresos y Gastos"
        Me.grpFiltrar.ResumeLayout(False)
        Me.grpFiltrar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpFecha.ResumeLayout(False)
        Me.grpFecha.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pnl_Loading.ResumeLayout(False)
        Me.pnl_Loading.PerformLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpFiltrar As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTPVFacturasProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents chkGastosVarios As System.Windows.Forms.CheckBox
    Friend WithEvents chkDoctores As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTickets As System.Windows.Forms.CheckBox
    Friend WithEvents chkCitas As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecibos As System.Windows.Forms.CheckBox
    Friend WithEvents chkTPVFacturas As System.Windows.Forms.CheckBox
    Friend WithEvents chkFacturas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_sincobrar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cobradas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todascobrar As System.Windows.Forms.RadioButton
    Friend WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Friend WithEvents grpFecha As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnl_Loading As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pb_Loading As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPendiente As System.Windows.Forms.Label
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDiferencia As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblGastos As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblIngresos As System.Windows.Forms.Label
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents chkEntregasACuenta As System.Windows.Forms.CheckBox
    Friend WithEvents lblCredito As System.Windows.Forms.Label
    Friend WithEvents lblCreditoText As System.Windows.Forms.Label
    Friend WithEvents lblRestringirSemana As System.Windows.Forms.Label
    Friend WithEvents dtpHoraFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaPagoFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaPagoInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkInclurDocImporte0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblPagoCuentaCredito As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblInfoFechaPago As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
