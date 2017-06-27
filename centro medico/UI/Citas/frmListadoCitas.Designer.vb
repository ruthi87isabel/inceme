<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoCitas
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition2.FormatStyle.BackgroundImag" & _
        "e")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoCitas))
        Dim GridEX1_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition3.FormatStyle.BackgroundImag" & _
        "e")
        Dim GridEX1_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition4.FormatStyle.BackgroundImag" & _
        "e")
        Me.bt_cerrar = New System.Windows.Forms.Button()
        Me.bt_ver = New System.Windows.Forms.Button()
        Me.bt_modificar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_sincobrar = New System.Windows.Forms.RadioButton()
        Me.rb_cobradas = New System.Windows.Forms.RadioButton()
        Me.rb_todascobrar = New System.Windows.Forms.RadioButton()
        Me.chb_importe = New System.Windows.Forms.CheckBox()
        Me.bt_imprimir = New System.Windows.Forms.Button()
        Me.GBfecha_cita = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.bt_Filtrar = New System.Windows.Forms.Button()
        Me.bt_Borrar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tlsAtendida = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsConfirmada = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsFalta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsCobrada = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPagadaFalta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsBeneficiario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbFalta = New System.Windows.Forms.RadioButton()
        Me.rb_noatendidas = New System.Windows.Forms.RadioButton()
        Me.rb_AtendidasTodas = New System.Windows.Forms.RadioButton()
        Me.rb_atendidas = New System.Windows.Forms.RadioButton()
        Me.btnAnnadirCita = New System.Windows.Forms.Button()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.CITABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument()
        Me.GroupBoxFacturacion = New System.Windows.Forms.GroupBox()
        Me.rb_NoFacturadas = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rb_Facturadas = New System.Windows.Forms.RadioButton()
        Me.btn_FacturarSeleccionadas = New System.Windows.Forms.Button()
        Me.btnComunicaciones = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_SoloPrivados = New System.Windows.Forms.RadioButton()
        Me.rb_SoloMutuas = New System.Windows.Forms.RadioButton()
        Me.rb_MutuasTodas = New System.Windows.Forms.RadioButton()
        Me.pnl_Loading = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pb_Loading = New System.Windows.Forms.PictureBox()
        Me.btnImprimirJustificante = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkFalta0 = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CBcitas = New System.Windows.Forms.ComboBox()
        Me.LineasCitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GBfecha_cobro = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_fcf = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fci = New System.Windows.Forms.DateTimePicker()
        Me.txtDni = New centro_medico.ctrlTextboxAvanzado()
        Me.txtApellido2 = New centro_medico.ctrlTextboxAvanzado()
        Me.txtApellido1 = New centro_medico.ctrlTextboxAvanzado()
        Me.txtNombre = New centro_medico.ctrlTextboxAvanzado()
        Me.CtrlConceptoFacturable1 = New centro_medico.ctrlConceptoFacturable()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.CtrlMedico1 = New centro_medico.ctrlMedico()
        Me.CtrlMutua1 = New centro_medico.ctrlMutua()
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        Me.GroupBox3.SuspendLayout()
        Me.GBfecha_cita.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxFacturacion.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnl_Loading.SuspendLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineasCitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBfecha_cobro.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_cerrar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cerrar.Location = New System.Drawing.Point(868, 548)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 37)
        Me.bt_cerrar.TabIndex = 111
        Me.bt_cerrar.Text = "Cerrar"
        Me.bt_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'bt_ver
        '
        Me.bt_ver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_ver.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_ver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_ver.Location = New System.Drawing.Point(6, 547)
        Me.bt_ver.Name = "bt_ver"
        Me.bt_ver.Size = New System.Drawing.Size(73, 37)
        Me.bt_ver.TabIndex = 104
        Me.bt_ver.Text = "Ver cita"
        Me.bt_ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_ver.UseVisualStyleBackColor = True
        '
        'bt_modificar
        '
        Me.bt_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_modificar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.bt_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_modificar.Location = New System.Drawing.Point(164, 546)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(82, 37)
        Me.bt_modificar.TabIndex = 105
        Me.bt_modificar.Text = "Modificar"
        Me.bt_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_modificar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_sincobrar)
        Me.GroupBox3.Controls.Add(Me.rb_cobradas)
        Me.GroupBox3.Controls.Add(Me.rb_todascobrar)
        Me.GroupBox3.Location = New System.Drawing.Point(310, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(95, 79)
        Me.GroupBox3.TabIndex = 117
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de cita"
        '
        'rb_sincobrar
        '
        Me.rb_sincobrar.AutoSize = True
        Me.rb_sincobrar.Location = New System.Drawing.Point(6, 56)
        Me.rb_sincobrar.Name = "rb_sincobrar"
        Me.rb_sincobrar.Size = New System.Drawing.Size(73, 17)
        Me.rb_sincobrar.TabIndex = 8
        Me.rb_sincobrar.Text = "Sin cobrar"
        Me.rb_sincobrar.UseVisualStyleBackColor = True
        '
        'rb_cobradas
        '
        Me.rb_cobradas.AutoSize = True
        Me.rb_cobradas.Location = New System.Drawing.Point(7, 34)
        Me.rb_cobradas.Name = "rb_cobradas"
        Me.rb_cobradas.Size = New System.Drawing.Size(70, 17)
        Me.rb_cobradas.TabIndex = 7
        Me.rb_cobradas.Text = "Cobradas"
        Me.rb_cobradas.UseVisualStyleBackColor = True
        '
        'rb_todascobrar
        '
        Me.rb_todascobrar.AutoSize = True
        Me.rb_todascobrar.Checked = True
        Me.rb_todascobrar.Location = New System.Drawing.Point(6, 16)
        Me.rb_todascobrar.Name = "rb_todascobrar"
        Me.rb_todascobrar.Size = New System.Drawing.Size(55, 17)
        Me.rb_todascobrar.TabIndex = 6
        Me.rb_todascobrar.TabStop = True
        Me.rb_todascobrar.Text = "Todas"
        Me.rb_todascobrar.UseVisualStyleBackColor = True
        '
        'chb_importe
        '
        Me.chb_importe.AutoSize = True
        Me.chb_importe.Checked = True
        Me.chb_importe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_importe.Location = New System.Drawing.Point(638, 188)
        Me.chb_importe.Name = "chb_importe"
        Me.chb_importe.Size = New System.Drawing.Size(147, 17)
        Me.chb_importe.TabIndex = 9
        Me.chb_importe.Text = "Mostrar citas de importe 0"
        Me.chb_importe.UseVisualStyleBackColor = True
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(373, 546)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(99, 37)
        Me.bt_imprimir.TabIndex = 108
        Me.bt_imprimir.Text = "     Imprimir"
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'GBfecha_cita
        '
        Me.GBfecha_cita.Controls.Add(Me.Label2)
        Me.GBfecha_cita.Controls.Add(Me.Label1)
        Me.GBfecha_cita.Controls.Add(Me.dtp_ff)
        Me.GBfecha_cita.Controls.Add(Me.dtp_fi)
        Me.GBfecha_cita.Location = New System.Drawing.Point(12, 7)
        Me.GBfecha_cita.Name = "GBfecha_cita"
        Me.GBfecha_cita.Size = New System.Drawing.Size(288, 38)
        Me.GBfecha_cita.TabIndex = 112
        Me.GBfecha_cita.TabStop = False
        Me.GBfecha_cita.Text = "Fecha Cita"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "a"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "De"
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(172, 15)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.ShowCheckBox = True
        Me.dtp_ff.Size = New System.Drawing.Size(102, 20)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(51, 15)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.ShowCheckBox = True
        Me.dtp_fi.Size = New System.Drawing.Size(97, 20)
        Me.dtp_fi.TabIndex = 0
        '
        'bt_Filtrar
        '
        Me.bt_Filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom_actual
        Me.bt_Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Filtrar.Location = New System.Drawing.Point(865, 191)
        Me.bt_Filtrar.Name = "bt_Filtrar"
        Me.bt_Filtrar.Size = New System.Drawing.Size(80, 27)
        Me.bt_Filtrar.TabIndex = 124
        Me.bt_Filtrar.Text = "Filtrar"
        Me.bt_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Filtrar.UseVisualStyleBackColor = True
        '
        'bt_Borrar
        '
        Me.bt_Borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_Borrar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.bt_Borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Borrar.Location = New System.Drawing.Point(252, 546)
        Me.bt_Borrar.Name = "bt_Borrar"
        Me.bt_Borrar.Size = New System.Drawing.Size(69, 37)
        Me.bt_Borrar.TabIndex = 125
        Me.bt_Borrar.Text = "Borrar"
        Me.bt_Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Borrar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsAtendida, Me.tlsConfirmada, Me.tlsFalta, Me.tlsCobrada, Me.lblPagadaFalta, Me.ToolStripStatusLabel2, Me.tsBeneficiario, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 581)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(948, 22)
        Me.StatusStrip1.TabIndex = 127
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tlsAtendida
        '
        Me.tlsAtendida.Name = "tlsAtendida"
        Me.tlsAtendida.Size = New System.Drawing.Size(55, 17)
        Me.tlsAtendida.Text = "Atendida"
        '
        'tlsConfirmada
        '
        Me.tlsConfirmada.Name = "tlsConfirmada"
        Me.tlsConfirmada.Size = New System.Drawing.Size(70, 17)
        Me.tlsConfirmada.Text = "Confirmada"
        '
        'tlsFalta
        '
        Me.tlsFalta.Name = "tlsFalta"
        Me.tlsFalta.Size = New System.Drawing.Size(81, 17)
        Me.tlsFalta.Text = "Anulada/Falta"
        '
        'tlsCobrada
        '
        Me.tlsCobrada.Name = "tlsCobrada"
        Me.tlsCobrada.Size = New System.Drawing.Size(52, 17)
        Me.tlsCobrada.Text = "Cobrada"
        '
        'lblPagadaFalta
        '
        Me.lblPagadaFalta.Name = "lblPagadaFalta"
        Me.lblPagadaFalta.Size = New System.Drawing.Size(76, 17)
        Me.lblPagadaFalta.Text = "Pagada-Falta"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Purple
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatusLabel2.Text = "Asociado"
        '
        'tsBeneficiario
        '
        Me.tsBeneficiario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tsBeneficiario.ForeColor = System.Drawing.Color.Blue
        Me.tsBeneficiario.Name = "tsBeneficiario"
        Me.tsBeneficiario.Size = New System.Drawing.Size(74, 17)
        Me.tsBeneficiario.Text = "Beneficiario"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(82, 17)
        Me.ToolStripStatusLabel3.Text = "Alt+E-> Editar"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(85, 17)
        Me.ToolStripStatusLabel4.Text = "Alt+B-> Borrar"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(95, 17)
        Me.ToolStripStatusLabel5.Text = "Alt+I-> Imprimir"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(70, 17)
        Me.ToolStripStatusLabel7.Text = "Alt+V-> Ver"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatusLabel8.Text = "Alt+C-> Cerrar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbFalta)
        Me.GroupBox2.Controls.Add(Me.rb_noatendidas)
        Me.GroupBox2.Controls.Add(Me.rb_AtendidasTodas)
        Me.GroupBox2.Controls.Add(Me.rb_atendidas)
        Me.GroupBox2.Location = New System.Drawing.Point(416, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 79)
        Me.GroupBox2.TabIndex = 128
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Atendidas"
        '
        'rbFalta
        '
        Me.rbFalta.AutoSize = True
        Me.rbFalta.Location = New System.Drawing.Point(106, 16)
        Me.rbFalta.Name = "rbFalta"
        Me.rbFalta.Size = New System.Drawing.Size(48, 17)
        Me.rbFalta.TabIndex = 1
        Me.rbFalta.Text = "Falta"
        Me.rbFalta.UseVisualStyleBackColor = True
        '
        'rb_noatendidas
        '
        Me.rb_noatendidas.AutoSize = True
        Me.rb_noatendidas.Location = New System.Drawing.Point(14, 56)
        Me.rb_noatendidas.Name = "rb_noatendidas"
        Me.rb_noatendidas.Size = New System.Drawing.Size(88, 17)
        Me.rb_noatendidas.TabIndex = 1
        Me.rb_noatendidas.Text = "No atendidas"
        Me.rb_noatendidas.UseVisualStyleBackColor = True
        '
        'rb_AtendidasTodas
        '
        Me.rb_AtendidasTodas.AutoSize = True
        Me.rb_AtendidasTodas.Checked = True
        Me.rb_AtendidasTodas.Location = New System.Drawing.Point(14, 16)
        Me.rb_AtendidasTodas.Name = "rb_AtendidasTodas"
        Me.rb_AtendidasTodas.Size = New System.Drawing.Size(55, 17)
        Me.rb_AtendidasTodas.TabIndex = 0
        Me.rb_AtendidasTodas.TabStop = True
        Me.rb_AtendidasTodas.Text = "Todas"
        Me.rb_AtendidasTodas.UseVisualStyleBackColor = True
        '
        'rb_atendidas
        '
        Me.rb_atendidas.AutoSize = True
        Me.rb_atendidas.Location = New System.Drawing.Point(14, 35)
        Me.rb_atendidas.Name = "rb_atendidas"
        Me.rb_atendidas.Size = New System.Drawing.Size(72, 17)
        Me.rb_atendidas.TabIndex = 0
        Me.rb_atendidas.Text = "Atendidas"
        Me.rb_atendidas.UseVisualStyleBackColor = True
        '
        'btnAnnadirCita
        '
        Me.btnAnnadirCita.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnnadirCita.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btnAnnadirCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnnadirCita.Location = New System.Drawing.Point(85, 546)
        Me.btnAnnadirCita.Name = "btnAnnadirCita"
        Me.btnAnnadirCita.Size = New System.Drawing.Size(73, 37)
        Me.btnAnnadirCita.TabIndex = 105
        Me.btnAnnadirCita.Text = "Añadir"
        Me.btnAnnadirCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnnadirCita.UseVisualStyleBackColor = True
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.AllCells
        Me.GridEX1.DataSource = Me.CITABindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"), Object)
        GridEX1_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_2.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0, GridEX1_DesignTimeLayout_Reference_1, GridEX1_DesignTimeLayout_Reference_2})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(5, 231)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEX1.Size = New System.Drawing.Size(931, 299)
        Me.GridEX1.TabIndex = 129
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'CITABindingSource
        '
        Me.CITABindingSource.DataSource = GetType(centro_medico.CITA)
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.GridEX1
        '
        'GroupBoxFacturacion
        '
        Me.GroupBoxFacturacion.Controls.Add(Me.rb_NoFacturadas)
        Me.GroupBoxFacturacion.Controls.Add(Me.RadioButton2)
        Me.GroupBoxFacturacion.Controls.Add(Me.rb_Facturadas)
        Me.GroupBoxFacturacion.Location = New System.Drawing.Point(594, 7)
        Me.GroupBoxFacturacion.Name = "GroupBoxFacturacion"
        Me.GroupBoxFacturacion.Size = New System.Drawing.Size(168, 79)
        Me.GroupBoxFacturacion.TabIndex = 128
        Me.GroupBoxFacturacion.TabStop = False
        Me.GroupBoxFacturacion.Text = "Facturación"
        '
        'rb_NoFacturadas
        '
        Me.rb_NoFacturadas.AutoSize = True
        Me.rb_NoFacturadas.Location = New System.Drawing.Point(14, 54)
        Me.rb_NoFacturadas.Name = "rb_NoFacturadas"
        Me.rb_NoFacturadas.Size = New System.Drawing.Size(95, 17)
        Me.rb_NoFacturadas.TabIndex = 1
        Me.rb_NoFacturadas.Text = "No Facturadas"
        Me.rb_NoFacturadas.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(14, 16)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Todas"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rb_Facturadas
        '
        Me.rb_Facturadas.AutoSize = True
        Me.rb_Facturadas.Location = New System.Drawing.Point(14, 35)
        Me.rb_Facturadas.Name = "rb_Facturadas"
        Me.rb_Facturadas.Size = New System.Drawing.Size(78, 17)
        Me.rb_Facturadas.TabIndex = 0
        Me.rb_Facturadas.Text = "Facturadas"
        Me.rb_Facturadas.UseVisualStyleBackColor = True
        '
        'btn_FacturarSeleccionadas
        '
        Me.btn_FacturarSeleccionadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_FacturarSeleccionadas.Enabled = False
        Me.btn_FacturarSeleccionadas.Image = Global.centro_medico.My.Resources.Resources.Facturas
        Me.btn_FacturarSeleccionadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_FacturarSeleccionadas.Location = New System.Drawing.Point(764, 548)
        Me.btn_FacturarSeleccionadas.Name = "btn_FacturarSeleccionadas"
        Me.btn_FacturarSeleccionadas.Size = New System.Drawing.Size(90, 35)
        Me.btn_FacturarSeleccionadas.TabIndex = 124
        Me.btn_FacturarSeleccionadas.Text = "Facturar"
        Me.btn_FacturarSeleccionadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_FacturarSeleccionadas.UseVisualStyleBackColor = True
        '
        'btnComunicaciones
        '
        Me.btnComunicaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnComunicaciones.Image = Global.centro_medico.My.Resources.Resources.communication
        Me.btnComunicaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComunicaciones.Location = New System.Drawing.Point(597, 546)
        Me.btnComunicaciones.Name = "btnComunicaciones"
        Me.btnComunicaciones.Size = New System.Drawing.Size(152, 37)
        Me.btnComunicaciones.TabIndex = 108
        Me.btnComunicaciones.Text = "     Enviar recordatorio"
        Me.btnComunicaciones.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(231, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 204
        Me.Label10.Text = "DNI:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 200
        Me.Label8.Text = "Apellido 2:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 201
        Me.Label7.Text = "Apellido 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Nombre:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb_SoloPrivados)
        Me.GroupBox4.Controls.Add(Me.rb_SoloMutuas)
        Me.GroupBox4.Controls.Add(Me.rb_MutuasTodas)
        Me.GroupBox4.Location = New System.Drawing.Point(772, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(173, 79)
        Me.GroupBox4.TabIndex = 205
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mutuas / Privadas"
        '
        'rb_SoloPrivados
        '
        Me.rb_SoloPrivados.AutoSize = True
        Me.rb_SoloPrivados.Location = New System.Drawing.Point(17, 54)
        Me.rb_SoloPrivados.Name = "rb_SoloPrivados"
        Me.rb_SoloPrivados.Size = New System.Drawing.Size(129, 17)
        Me.rb_SoloPrivados.TabIndex = 0
        Me.rb_SoloPrivados.Text = "Solo citas de privados"
        Me.rb_SoloPrivados.UseVisualStyleBackColor = True
        '
        'rb_SoloMutuas
        '
        Me.rb_SoloMutuas.AutoSize = True
        Me.rb_SoloMutuas.Location = New System.Drawing.Point(17, 35)
        Me.rb_SoloMutuas.Name = "rb_SoloMutuas"
        Me.rb_SoloMutuas.Size = New System.Drawing.Size(118, 17)
        Me.rb_SoloMutuas.TabIndex = 0
        Me.rb_SoloMutuas.Text = "Solo citas de mutua"
        Me.rb_SoloMutuas.UseVisualStyleBackColor = True
        '
        'rb_MutuasTodas
        '
        Me.rb_MutuasTodas.AutoSize = True
        Me.rb_MutuasTodas.Checked = True
        Me.rb_MutuasTodas.Location = New System.Drawing.Point(17, 16)
        Me.rb_MutuasTodas.Name = "rb_MutuasTodas"
        Me.rb_MutuasTodas.Size = New System.Drawing.Size(55, 17)
        Me.rb_MutuasTodas.TabIndex = 0
        Me.rb_MutuasTodas.TabStop = True
        Me.rb_MutuasTodas.Text = "Todas"
        Me.rb_MutuasTodas.UseVisualStyleBackColor = True
        '
        'pnl_Loading
        '
        Me.pnl_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Loading.Controls.Add(Me.Label3)
        Me.pnl_Loading.Controls.Add(Me.pb_Loading)
        Me.pnl_Loading.Location = New System.Drawing.Point(422, 361)
        Me.pnl_Loading.Name = "pnl_Loading"
        Me.pnl_Loading.Size = New System.Drawing.Size(123, 48)
        Me.pnl_Loading.TabIndex = 206
        Me.pnl_Loading.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Filtrando..."
        '
        'pb_Loading
        '
        Me.pb_Loading.Image = Global.centro_medico.My.Resources.Resources.ajax_loader
        Me.pb_Loading.Location = New System.Drawing.Point(13, 8)
        Me.pb_Loading.Name = "pb_Loading"
        Me.pb_Loading.Size = New System.Drawing.Size(40, 35)
        Me.pb_Loading.TabIndex = 118
        Me.pb_Loading.TabStop = False
        '
        'btnImprimirJustificante
        '
        Me.btnImprimirJustificante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirJustificante.Enabled = False
        Me.btnImprimirJustificante.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.btnImprimirJustificante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimirJustificante.Location = New System.Drawing.Point(478, 546)
        Me.btnImprimirJustificante.Name = "btnImprimirJustificante"
        Me.btnImprimirJustificante.Size = New System.Drawing.Size(98, 37)
        Me.btnImprimirJustificante.TabIndex = 108
        Me.btnImprimirJustificante.Text = "Impr. Justi."
        Me.btnImprimirJustificante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimirJustificante.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(772, 554)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 207
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'chkFalta0
        '
        Me.chkFalta0.AutoSize = True
        Me.chkFalta0.Location = New System.Drawing.Point(638, 208)
        Me.chkFalta0.Name = "chkFalta0"
        Me.chkFalta0.Size = New System.Drawing.Size(216, 17)
        Me.chkFalta0.TabIndex = 208
        Me.chkFalta0.Text = "Poner a 0 las citas con el estado ""Falta"""
        Me.chkFalta0.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(495, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 210
        Me.Label17.Text = "Tipo de Cita"
        '
        'CBcitas
        '
        Me.CBcitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBcitas.FormattingEnabled = True
        Me.CBcitas.Items.AddRange(New Object() {"", "1ra Cita", "2da Cita", "3ra Cita"})
        Me.CBcitas.Location = New System.Drawing.Point(495, 203)
        Me.CBcitas.Name = "CBcitas"
        Me.CBcitas.Size = New System.Drawing.Size(121, 21)
        Me.CBcitas.TabIndex = 209
        '
        'LineasCitaBindingSource
        '
        Me.LineasCitaBindingSource.DataSource = GetType(centro_medico.LineasCita)
        '
        'GBfecha_cobro
        '
        Me.GBfecha_cobro.Controls.Add(Me.Label4)
        Me.GBfecha_cobro.Controls.Add(Me.Label6)
        Me.GBfecha_cobro.Controls.Add(Me.dtp_fcf)
        Me.GBfecha_cobro.Controls.Add(Me.dtp_fci)
        Me.GBfecha_cobro.Enabled = False
        Me.GBfecha_cobro.Location = New System.Drawing.Point(12, 48)
        Me.GBfecha_cobro.Name = "GBfecha_cobro"
        Me.GBfecha_cobro.Size = New System.Drawing.Size(288, 38)
        Me.GBfecha_cobro.TabIndex = 113
        Me.GBfecha_cobro.TabStop = False
        Me.GBfecha_cobro.Text = "Fecha Cobro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "a"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "De"
        '
        'dtp_fcf
        '
        Me.dtp_fcf.Checked = False
        Me.dtp_fcf.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fcf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fcf.Location = New System.Drawing.Point(172, 15)
        Me.dtp_fcf.Name = "dtp_fcf"
        Me.dtp_fcf.ShowCheckBox = True
        Me.dtp_fcf.Size = New System.Drawing.Size(102, 20)
        Me.dtp_fcf.TabIndex = 1
        '
        'dtp_fci
        '
        Me.dtp_fci.Checked = False
        Me.dtp_fci.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fci.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fci.Location = New System.Drawing.Point(51, 15)
        Me.dtp_fci.Name = "dtp_fci"
        Me.dtp_fci.ShowCheckBox = True
        Me.dtp_fci.Size = New System.Drawing.Size(97, 20)
        Me.dtp_fci.TabIndex = 0
        '
        'txtDni
        '
        Me.txtDni.AcceptsReturn = True
        Me.txtDni.Location = New System.Drawing.Point(264, 146)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(142, 20)
        Me.txtDni.TabIndex = 203
        '
        'txtApellido2
        '
        Me.txtApellido2.AcceptsReturn = True
        Me.txtApellido2.Location = New System.Drawing.Point(78, 203)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(107, 20)
        Me.txtApellido2.TabIndex = 199
        '
        'txtApellido1
        '
        Me.txtApellido1.AcceptsReturn = True
        Me.txtApellido1.Location = New System.Drawing.Point(78, 175)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(107, 20)
        Me.txtApellido1.TabIndex = 198
        '
        'txtNombre
        '
        Me.txtNombre.AcceptsReturn = True
        Me.txtNombre.Location = New System.Drawing.Point(78, 146)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(107, 20)
        Me.txtNombre.TabIndex = 197
        '
        'CtrlConceptoFacturable1
        '
        Me.CtrlConceptoFacturable1.ID_ConceptosFra = Nothing
        Me.CtrlConceptoFacturable1.Location = New System.Drawing.Point(478, 135)
        Me.CtrlConceptoFacturable1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlConceptoFacturable1.Name = "CtrlConceptoFacturable1"
        Me.CtrlConceptoFacturable1.Size = New System.Drawing.Size(402, 53)
        Me.CtrlConceptoFacturable1.TabIndex = 130
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(12, 89)
        Me.CtrlPaciente1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(460, 53)
        Me.CtrlPaciente1.TabIndex = 126
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(483, 88)
        Me.CtrlMedico1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(413, 42)
        Me.CtrlMedico1.TabIndex = 123
        '
        'CtrlMutua1
        '
        Me.CtrlMutua1.EscogerViaLineaMutua = False
        Me.CtrlMutua1.FiltrarMutuasPorPAciente = False
        Me.CtrlMutua1.ID_Mutuas = Nothing
        Me.CtrlMutua1.IDPACIENTE = Nothing
        Me.CtrlMutua1.Location = New System.Drawing.Point(223, 202)
        Me.CtrlMutua1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlMutua1.Name = "CtrlMutua1"
        Me.CtrlMutua1.Size = New System.Drawing.Size(253, 21)
        Me.CtrlMutua1.TabIndex = 122
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(195, 172)
        Me.CtrlFormaPago21.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(279, 23)
        Me.CtrlFormaPago21.TabIndex = 121
        '
        'frmListadoCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(948, 603)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_FacturarSeleccionadas)
        Me.Controls.Add(Me.GBfecha_cobro)
        Me.Controls.Add(Me.GBfecha_cita)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.CBcitas)
        Me.Controls.Add(Me.chkFalta0)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnl_Loading)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.chb_importe)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.bt_Filtrar)
        Me.Controls.Add(Me.CtrlConceptoFacturable1)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.GroupBoxFacturacion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CtrlPaciente1)
        Me.Controls.Add(Me.bt_Borrar)
        Me.Controls.Add(Me.CtrlMedico1)
        Me.Controls.Add(Me.CtrlMutua1)
        Me.Controls.Add(Me.CtrlFormaPago21)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.bt_ver)
        Me.Controls.Add(Me.btnAnnadirCita)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnComunicaciones)
        Me.Controls.Add(Me.btnImprimirJustificante)
        Me.Controls.Add(Me.bt_imprimir)
        Me.KeyPreview = True
        Me.Name = "frmListadoCitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Citas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GBfecha_cita.ResumeLayout(False)
        Me.GBfecha_cita.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxFacturacion.ResumeLayout(False)
        Me.GroupBoxFacturacion.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.pnl_Loading.ResumeLayout(False)
        Me.pnl_Loading.PerformLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineasCitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBfecha_cobro.ResumeLayout(False)
        Me.GBfecha_cobro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
    Friend WithEvents bt_ver As System.Windows.Forms.Button
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_importe As System.Windows.Forms.CheckBox
    Friend WithEvents rb_sincobrar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cobradas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todascobrar As System.Windows.Forms.RadioButton
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents GBfecha_cita As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Friend WithEvents CtrlMutua1 As centro_medico.ctrlMutua
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Friend WithEvents bt_Filtrar As System.Windows.Forms.Button
    Friend WithEvents bt_Borrar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tlsAtendida As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tlsConfirmada As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tlsFalta As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsBeneficiario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_noatendidas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_AtendidasTodas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_atendidas As System.Windows.Forms.RadioButton
    Public WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents btnAnnadirCita As System.Windows.Forms.Button
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents CITABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineasCitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents GroupBoxFacturacion As System.Windows.Forms.GroupBox
    Friend WithEvents rb_NoFacturadas As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Facturadas As System.Windows.Forms.RadioButton
    Friend WithEvents btn_FacturarSeleccionadas As System.Windows.Forms.Button
    Friend WithEvents CtrlConceptoFacturable1 As centro_medico.ctrlConceptoFacturable
    Friend WithEvents tlsCobrada As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnComunicaciones As System.Windows.Forms.Button
    Friend WithEvents rbFalta As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDni As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents txtApellido1 As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents txtNombre As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_SoloPrivados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_SoloMutuas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_MutuasTodas As System.Windows.Forms.RadioButton
    Friend WithEvents pnl_Loading As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pb_Loading As System.Windows.Forms.PictureBox
    Friend WithEvents btnImprimirJustificante As System.Windows.Forms.Button
    Friend WithEvents lblPagadaFalta As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkFalta0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CBcitas As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GBfecha_cobro As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_fcf As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fci As System.Windows.Forms.DateTimePicker
End Class
