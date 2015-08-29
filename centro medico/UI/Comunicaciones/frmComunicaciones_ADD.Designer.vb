<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComunicaciones_ADD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listDestinos = New System.Windows.Forms.ListView()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_ADD = New System.Windows.Forms.Button()
        Me.comboTipoComunicacion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl_Loading = New System.Windows.Forms.Panel()
        Me.lnkCancelar = New System.Windows.Forms.LinkLabel()
        Me.lbl_Loading = New System.Windows.Forms.Label()
        Me.pb_Loading = New System.Windows.Forms.PictureBox()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.lblPieSms = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDestinatariosTotal = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btnPlantilla = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMessage = New centro_medico.ctrlTextboxAvanzado()
        Me.txtPieSMS = New centro_medico.ctrlTextboxAvanzado()
        Me.txtAsunto = New centro_medico.ctrlTextboxAvanzado()
        Me.txtDesde = New centro_medico.ctrlTextboxAvanzado()
        Me.pnl_Loading.SuspendLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "De:"
        '
        'listDestinos
        '
        Me.listDestinos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listDestinos.Location = New System.Drawing.Point(63, 76)
        Me.listDestinos.Name = "listDestinos"
        Me.listDestinos.Size = New System.Drawing.Size(704, 100)
        Me.listDestinos.TabIndex = 0
        Me.listDestinos.UseCompatibleStateImageBehavior = False
        Me.listDestinos.View = System.Windows.Forms.View.List
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackgroundImage = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Eliminar.FlatAppearance.BorderSize = 0
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Location = New System.Drawing.Point(748, 54)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(16, 16)
        Me.btn_Eliminar.TabIndex = 40
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_ADD
        '
        Me.btn_ADD.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btn_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ADD.FlatAppearance.BorderSize = 0
        Me.btn_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ADD.Location = New System.Drawing.Point(726, 54)
        Me.btn_ADD.Name = "btn_ADD"
        Me.btn_ADD.Size = New System.Drawing.Size(16, 16)
        Me.btn_ADD.TabIndex = 7
        Me.btn_ADD.UseVisualStyleBackColor = True
        '
        'comboTipoComunicacion
        '
        Me.comboTipoComunicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTipoComunicacion.FormattingEnabled = True
        Me.comboTipoComunicacion.Location = New System.Drawing.Point(63, 23)
        Me.comboTipoComunicacion.Name = "comboTipoComunicacion"
        Me.comboTipoComunicacion.Size = New System.Drawing.Size(121, 21)
        Me.comboTipoComunicacion.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mensaje:"
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.Location = New System.Drawing.Point(665, 562)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(99, 23)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Asunto:"
        '
        'pnl_Loading
        '
        Me.pnl_Loading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnl_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Loading.Controls.Add(Me.lnkCancelar)
        Me.pnl_Loading.Controls.Add(Me.lbl_Loading)
        Me.pnl_Loading.Controls.Add(Me.pb_Loading)
        Me.pnl_Loading.Location = New System.Drawing.Point(299, 252)
        Me.pnl_Loading.Name = "pnl_Loading"
        Me.pnl_Loading.Size = New System.Drawing.Size(195, 56)
        Me.pnl_Loading.TabIndex = 222
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
        'lblContador
        '
        Me.lblContador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(60, 562)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(95, 13)
        Me.lblContador.TabIndex = 223
        Me.lblContador.Text = "0 / 200 caracteres"
        '
        'lblPieSms
        '
        Me.lblPieSms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPieSms.AutoSize = True
        Me.lblPieSms.Location = New System.Drawing.Point(29, 539)
        Me.lblPieSms.Name = "lblPieSms"
        Me.lblPieSms.Size = New System.Drawing.Size(25, 13)
        Me.lblPieSms.TabIndex = 0
        Me.lblPieSms.Text = "Pie:"
        Me.lblPieSms.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(206, 562)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Destinatarios:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDestinatariosTotal
        '
        Me.lblDestinatariosTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDestinatariosTotal.Location = New System.Drawing.Point(287, 563)
        Me.lblDestinatariosTotal.Name = "lblDestinatariosTotal"
        Me.lblDestinatariosTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblDestinatariosTotal.TabIndex = 0
        Me.lblDestinatariosTotal.Text = "0"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(311, 54)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(37, 13)
        Me.lblSaldo.TabIndex = 224
        Me.lblSaldo.Text = "Saldo:"
        Me.lblSaldo.Visible = False
        '
        'btnPlantilla
        '
        Me.btnPlantilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlantilla.Location = New System.Drawing.Point(588, 182)
        Me.btnPlantilla.Name = "btnPlantilla"
        Me.btnPlantilla.Size = New System.Drawing.Size(103, 34)
        Me.btnPlantilla.TabIndex = 3
        Me.btnPlantilla.Text = "Usar plantilla"
        Me.btnPlantilla.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(561, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 308)
        Me.GroupBox1.TabIndex = 226
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leyenda"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.Location = New System.Drawing.Point(13, 251)
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
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(13, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "{NOMBRE} : Nombre  (15)"
        '
        'txtMessage
        '
        Me.txtMessage.AcceptsReturn = True
        Me.txtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.Location = New System.Drawing.Point(63, 205)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(491, 325)
        Me.txtMessage.TabIndex = 2
        '
        'txtPieSMS
        '
        Me.txtPieSMS.AcceptsReturn = True
        Me.txtPieSMS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPieSMS.Location = New System.Drawing.Point(60, 536)
        Me.txtPieSMS.Name = "txtPieSMS"
        Me.txtPieSMS.ReadOnly = True
        Me.txtPieSMS.Size = New System.Drawing.Size(494, 20)
        Me.txtPieSMS.TabIndex = 3
        Me.txtPieSMS.Visible = False
        '
        'txtAsunto
        '
        Me.txtAsunto.AcceptsReturn = True
        Me.txtAsunto.Location = New System.Drawing.Point(61, 182)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(494, 20)
        Me.txtAsunto.TabIndex = 1
        '
        'txtDesde
        '
        Me.txtDesde.AcceptsReturn = True
        Me.txtDesde.Location = New System.Drawing.Point(63, 50)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.ReadOnly = True
        Me.txtDesde.Size = New System.Drawing.Size(233, 20)
        Me.txtDesde.TabIndex = 1
        '
        'frmComunicaciones_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 591)
        Me.Controls.Add(Me.pnl_Loading)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPlantilla)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.txtPieSMS)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.comboTipoComunicacion)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_ADD)
        Me.Controls.Add(Me.listDestinos)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPieSms)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDestinatariosTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmComunicaciones_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva comunicación"
        Me.pnl_Loading.ResumeLayout(False)
        Me.pnl_Loading.PerformLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboTipoComunicacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnl_Loading As System.Windows.Forms.Panel
    Friend WithEvents lnkCancelar As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_Loading As System.Windows.Forms.Label
    Friend WithEvents pb_Loading As System.Windows.Forms.PictureBox
    Friend WithEvents lblContador As System.Windows.Forms.Label
    Friend WithEvents txtPieSMS As ctrlTextboxAvanzado
    Friend WithEvents lblPieSms As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDestinatariosTotal As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents listDestinos As System.Windows.Forms.ListView
    Public WithEvents btn_Eliminar As System.Windows.Forms.Button
    Public WithEvents btn_ADD As System.Windows.Forms.Button
    Public WithEvents txtAsunto As centro_medico.ctrlTextboxAvanzado
    Public WithEvents btnPlantilla As System.Windows.Forms.Button
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtMessage As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents txtDesde As centro_medico.ctrlTextboxAvanzado
End Class
