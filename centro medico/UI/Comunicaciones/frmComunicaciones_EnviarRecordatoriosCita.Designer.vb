<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComunicaciones_EnviarRecordatoriosCita
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComunicaciones_EnviarRecordatoriosCita))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.CITABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCantEmails = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCantMoviles = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnl_Loading = New System.Windows.Forms.Panel()
        Me.lnkCancelar = New System.Windows.Forms.LinkLabel()
        Me.lbl_Loading = New System.Windows.Forms.Label()
        Me.pb_Loading = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.comboTipoComunicacion = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPieSms = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDesde = New centro_medico.ctrlTextboxAvanzado()
        Me.txtAsunto = New centro_medico.ctrlTextboxAvanzado()
        Me.txtMessage = New centro_medico.ctrlTextboxAvanzado()
        Me.txtPieSMS = New centro_medico.ctrlTextboxAvanzado()
        Me.btnPlantilla = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Loading.SuspendLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_ff)
        Me.GroupBox1.Controls.Add(Me.dtp_fi)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 53)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde:"
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(227, 21)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(99, 20)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(59, 19)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fi.TabIndex = 0
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.DataSource = Me.CITABindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(12, 97)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(860, 145)
        Me.GridEX1.TabIndex = 114
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'CITABindingSource
        '
        Me.CITABindingSource.DataSource = GetType(centro_medico.CITA)
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.Location = New System.Drawing.Point(781, 19)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 53)
        Me.btnEnviar.TabIndex = 115
        Me.btnEnviar.Text = "ENVIAR"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 643)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(629, 13)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Nota: Solo se enviarán los recordatorios a aquellos pacientes que tengan registra" & _
    "do su email o móvil segun sea el tipo de recordario."
        '
        'lblCantEmails
        '
        Me.lblCantEmails.Location = New System.Drawing.Point(527, 31)
        Me.lblCantEmails.Name = "lblCantEmails"
        Me.lblCantEmails.Size = New System.Drawing.Size(37, 13)
        Me.lblCantEmails.TabIndex = 117
        Me.lblCantEmails.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(422, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Cant. MOVILES:"
        '
        'lblCantMoviles
        '
        Me.lblCantMoviles.Location = New System.Drawing.Point(527, 52)
        Me.lblCantMoviles.Name = "lblCantMoviles"
        Me.lblCantMoviles.Size = New System.Drawing.Size(37, 13)
        Me.lblCantMoviles.TabIndex = 117
        Me.lblCantMoviles.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(599, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "COSTO:"
        '
        'lblCosto
        '
        Me.lblCosto.Location = New System.Drawing.Point(654, 31)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(47, 13)
        Me.lblCosto.TabIndex = 117
        Me.lblCosto.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(431, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Cant. EMAILS:"
        '
        'pnl_Loading
        '
        Me.pnl_Loading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnl_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Loading.Controls.Add(Me.lnkCancelar)
        Me.pnl_Loading.Controls.Add(Me.lbl_Loading)
        Me.pnl_Loading.Controls.Add(Me.pb_Loading)
        Me.pnl_Loading.Location = New System.Drawing.Point(310, 312)
        Me.pnl_Loading.Name = "pnl_Loading"
        Me.pnl_Loading.Size = New System.Drawing.Size(195, 56)
        Me.pnl_Loading.TabIndex = 235
        Me.pnl_Loading.Visible = False
        '
        'lnkCancelar
        '
        Me.lnkCancelar.AutoSize = True
        Me.lnkCancelar.Location = New System.Drawing.Point(49, 30)
        Me.lnkCancelar.Name = "lnkCancelar"
        Me.lnkCancelar.Size = New System.Drawing.Size(49, 13)
        Me.lnkCancelar.TabIndex = 120
        Me.lnkCancelar.TabStop = True
        Me.lnkCancelar.Text = "Cancelar"
        '
        'lbl_Loading
        '
        Me.lbl_Loading.AutoSize = True
        Me.lbl_Loading.Location = New System.Drawing.Point(49, 12)
        Me.lbl_Loading.Name = "lbl_Loading"
        Me.lbl_Loading.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Loading.TabIndex = 119
        Me.lbl_Loading.Text = "Enviando..."
        '
        'pb_Loading
        '
        Me.pb_Loading.Image = Global.centro_medico.My.Resources.Resources.ajax_loader
        Me.pb_Loading.Location = New System.Drawing.Point(6, 11)
        Me.pb_Loading.Name = "pb_Loading"
        Me.pb_Loading.Size = New System.Drawing.Size(40, 35)
        Me.pb_Loading.TabIndex = 118
        Me.pb_Loading.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(655, 316)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 308)
        Me.GroupBox2.TabIndex = 237
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Leyenda"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 217)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(200, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "{MEDICO} : Médico"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 192)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(200, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "{CITAHORA} : Hora de la cita"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 170)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(200, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "{CITAFECHA} : Fecha de la cita"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.Location = New System.Drawing.Point(11, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 48)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nota: En el caso de los EMAIL, las etiquetas pueden usarse también en el Asunto"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(3, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "{APELLIDO2} : Apellido 2  (15)"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(2, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "{APELLIDO1} : Apellido 1  (15)"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 49)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "{NOMBRESMS} : Nombre completo en formato ""Ramón G. H"" para reducir consumo caract" & _
    "eres (25)"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(13, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "{NOMBRE} : Nombre  (15)"
        '
        'lblContador
        '
        Me.lblContador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(71, 622)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(95, 13)
        Me.lblContador.TabIndex = 236
        Me.lblContador.Text = "0 / 200 caracteres"
        '
        'comboTipoComunicacion
        '
        Me.comboTipoComunicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTipoComunicacion.FormattingEnabled = True
        Me.comboTipoComunicacion.Location = New System.Drawing.Point(71, 260)
        Me.comboTipoComunicacion.Name = "comboTipoComunicacion"
        Me.comboTipoComunicacion.Size = New System.Drawing.Size(121, 21)
        Me.comboTipoComunicacion.TabIndex = 233
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 319)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 228
        Me.Label13.Text = "Mensaje:"
        '
        'lblPieSms
        '
        Me.lblPieSms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPieSms.AutoSize = True
        Me.lblPieSms.Location = New System.Drawing.Point(40, 599)
        Me.lblPieSms.Name = "lblPieSms"
        Me.lblPieSms.Size = New System.Drawing.Size(25, 13)
        Me.lblPieSms.TabIndex = 230
        Me.lblPieSms.Text = "Pie:"
        Me.lblPieSms.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 293)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 232
        Me.Label14.Text = "Asunto:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(33, 263)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 229
        Me.Label16.Text = "Tipo:"
        '
        'lblSaldo
        '
        Me.lblSaldo.Location = New System.Drawing.Point(654, 52)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(47, 13)
        Me.lblSaldo.TabIndex = 117
        Me.lblSaldo.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(570, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 118
        Me.Label18.Text = "SALDO SMS:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 232
        Me.Label15.Text = "Citas destino:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(209, 263)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 13)
        Me.Label19.TabIndex = 240
        Me.Label19.Text = "De:"
        '
        'txtDesde
        '
        Me.txtDesde.AcceptsReturn = True
        Me.txtDesde.Location = New System.Drawing.Point(239, 260)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.ReadOnly = True
        Me.txtDesde.Size = New System.Drawing.Size(233, 20)
        Me.txtDesde.TabIndex = 241
        '
        'txtAsunto
        '
        Me.txtAsunto.AcceptsReturn = True
        Me.txtAsunto.Location = New System.Drawing.Point(71, 290)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(450, 20)
        Me.txtAsunto.TabIndex = 239
        '
        'txtMessage
        '
        Me.txtMessage.AcceptsReturn = True
        Me.txtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.Location = New System.Drawing.Point(74, 316)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(568, 274)
        Me.txtMessage.TabIndex = 238
        '
        'txtPieSMS
        '
        Me.txtPieSMS.AcceptsReturn = True
        Me.txtPieSMS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPieSMS.Location = New System.Drawing.Point(71, 596)
        Me.txtPieSMS.Name = "txtPieSMS"
        Me.txtPieSMS.ReadOnly = True
        Me.txtPieSMS.Size = New System.Drawing.Size(494, 20)
        Me.txtPieSMS.TabIndex = 234
        Me.txtPieSMS.Visible = False
        '
        'btnPlantilla
        '
        Me.btnPlantilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlantilla.Location = New System.Drawing.Point(539, 285)
        Me.btnPlantilla.Name = "btnPlantilla"
        Me.btnPlantilla.Size = New System.Drawing.Size(103, 28)
        Me.btnPlantilla.TabIndex = 242
        Me.btnPlantilla.Text = "Usar plantilla"
        Me.btnPlantilla.UseVisualStyleBackColor = True
        '
        'frmComunicaciones_EnviarRecordatoriosCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 662)
        Me.Controls.Add(Me.btnPlantilla)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.pnl_Loading)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.txtPieSMS)
        Me.Controls.Add(Me.comboTipoComunicacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblPieSms)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCosto)
        Me.Controls.Add(Me.lblCantMoviles)
        Me.Controls.Add(Me.lblCantEmails)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmComunicaciones_EnviarRecordatoriosCita"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar recordatorios de cita"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Loading.ResumeLayout(False)
        Me.pnl_Loading.PerformLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents CITABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCantEmails As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCantMoviles As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCosto As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnl_Loading As System.Windows.Forms.Panel
    Friend WithEvents lnkCancelar As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_Loading As System.Windows.Forms.Label
    Friend WithEvents pb_Loading As System.Windows.Forms.PictureBox
    Public WithEvents txtMessage As centro_medico.ctrlTextboxAvanzado
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblContador As System.Windows.Forms.Label
    Friend WithEvents txtPieSMS As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents comboTipoComunicacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblPieSms As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents txtAsunto As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDesde As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Public WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Public WithEvents btnPlantilla As System.Windows.Forms.Button
End Class
