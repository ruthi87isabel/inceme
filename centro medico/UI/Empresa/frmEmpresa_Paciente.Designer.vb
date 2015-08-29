<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresa_Paciente
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
        Me.txtPuesto = New centro_medico.ctrlTextboxAvanzado()
        Me.LEMPRESABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_AECancelar = New System.Windows.Forms.Button()
        Me.bt_AEAceptar = New System.Windows.Forms.Button()
        Me.dtp_AEFechaalta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_AEFechabaja = New System.Windows.Forms.DateTimePicker()
        Me.tb_AENotas = New centro_medico.ctrlTextboxAvanzado()
        Me.lb_AENotas = New System.Windows.Forms.Label()
        Me.lb_AEFechaalta = New System.Windows.Forms.Label()
        Me.lb_AEFechabaja = New System.Windows.Forms.Label()
        Me.CtrlEmpresa1 = New centro_medico.ctrlEmpresa()
        CType(Me.LEMPRESABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPuesto
        '
        Me.txtPuesto.AcceptsReturn = True
        Me.txtPuesto.BackColor = System.Drawing.Color.White
        Me.txtPuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LEMPRESABindingSource, "PUESTOTRABAJO", True))
        Me.txtPuesto.Location = New System.Drawing.Point(112, 50)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(279, 20)
        Me.txtPuesto.TabIndex = 1
        '
        'LEMPRESABindingSource
        '
        Me.LEMPRESABindingSource.DataSource = GetType(centro_medico.LEMPRESA)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Puesto de Trabajo :"
        '
        'bt_AECancelar
        '
        Me.bt_AECancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_AECancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_AECancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AECancelar.Location = New System.Drawing.Point(313, 274)
        Me.bt_AECancelar.Name = "bt_AECancelar"
        Me.bt_AECancelar.Size = New System.Drawing.Size(80, 26)
        Me.bt_AECancelar.TabIndex = 6
        Me.bt_AECancelar.Text = "Cancelar"
        Me.bt_AECancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AECancelar.UseVisualStyleBackColor = True
        '
        'bt_AEAceptar
        '
        Me.bt_AEAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_AEAceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_AEAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AEAceptar.Location = New System.Drawing.Point(227, 274)
        Me.bt_AEAceptar.Name = "bt_AEAceptar"
        Me.bt_AEAceptar.Size = New System.Drawing.Size(80, 26)
        Me.bt_AEAceptar.TabIndex = 5
        Me.bt_AEAceptar.Text = "Aceptar"
        Me.bt_AEAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AEAceptar.UseVisualStyleBackColor = True
        '
        'dtp_AEFechaalta
        '
        Me.dtp_AEFechaalta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LEMPRESABindingSource, "FECHAALTA", True))
        Me.dtp_AEFechaalta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_AEFechaalta.Location = New System.Drawing.Point(9, 97)
        Me.dtp_AEFechaalta.Name = "dtp_AEFechaalta"
        Me.dtp_AEFechaalta.Size = New System.Drawing.Size(100, 20)
        Me.dtp_AEFechaalta.TabIndex = 2
        '
        'dtp_AEFechabaja
        '
        Me.dtp_AEFechabaja.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LEMPRESABindingSource, "FECHABAJA", True))
        Me.dtp_AEFechabaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_AEFechabaja.Location = New System.Drawing.Point(142, 97)
        Me.dtp_AEFechabaja.Name = "dtp_AEFechabaja"
        Me.dtp_AEFechabaja.Size = New System.Drawing.Size(100, 20)
        Me.dtp_AEFechabaja.TabIndex = 3
        '
        'tb_AENotas
        '
        Me.tb_AENotas.AcceptsReturn = True
        Me.tb_AENotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_AENotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LEMPRESABindingSource, "NOTAS", True))
        Me.tb_AENotas.Location = New System.Drawing.Point(9, 139)
        Me.tb_AENotas.MaxLength = 150
        Me.tb_AENotas.Multiline = True
        Me.tb_AENotas.Name = "tb_AENotas"
        Me.tb_AENotas.Size = New System.Drawing.Size(384, 129)
        Me.tb_AENotas.TabIndex = 4
        '
        'lb_AENotas
        '
        Me.lb_AENotas.AutoSize = True
        Me.lb_AENotas.Location = New System.Drawing.Point(6, 123)
        Me.lb_AENotas.Name = "lb_AENotas"
        Me.lb_AENotas.Size = New System.Drawing.Size(35, 13)
        Me.lb_AENotas.TabIndex = 16
        Me.lb_AENotas.Text = "Notas"
        '
        'lb_AEFechaalta
        '
        Me.lb_AEFechaalta.AutoSize = True
        Me.lb_AEFechaalta.Location = New System.Drawing.Point(6, 81)
        Me.lb_AEFechaalta.Name = "lb_AEFechaalta"
        Me.lb_AEFechaalta.Size = New System.Drawing.Size(58, 13)
        Me.lb_AEFechaalta.TabIndex = 14
        Me.lb_AEFechaalta.Text = "Fecha Alta"
        '
        'lb_AEFechabaja
        '
        Me.lb_AEFechabaja.AutoSize = True
        Me.lb_AEFechabaja.Location = New System.Drawing.Point(139, 81)
        Me.lb_AEFechabaja.Name = "lb_AEFechabaja"
        Me.lb_AEFechabaja.Size = New System.Drawing.Size(61, 13)
        Me.lb_AEFechabaja.TabIndex = 13
        Me.lb_AEFechabaja.Text = "Fecha Baja"
        '
        'CtrlEmpresa1
        '
        Me.CtrlEmpresa1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlEmpresa1.DataBindings.Add(New System.Windows.Forms.Binding("ID_EMPRESAS", Me.LEMPRESABindingSource, "REFEMPRESA", True))
        Me.CtrlEmpresa1.EsEmpresaPorDefecto = False
        Me.CtrlEmpresa1.ID_EMPRESAS = Nothing
        Me.CtrlEmpresa1.IDPACIENTE = Nothing
        Me.CtrlEmpresa1.Location = New System.Drawing.Point(10, 12)
        Me.CtrlEmpresa1.Name = "CtrlEmpresa1"
        Me.CtrlEmpresa1.Size = New System.Drawing.Size(383, 25)
        Me.CtrlEmpresa1.TabIndex = 0
        '
        'frmEmpresa_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 311)
        Me.Controls.Add(Me.CtrlEmpresa1)
        Me.Controls.Add(Me.txtPuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_AECancelar)
        Me.Controls.Add(Me.bt_AEAceptar)
        Me.Controls.Add(Me.dtp_AEFechaalta)
        Me.Controls.Add(Me.dtp_AEFechabaja)
        Me.Controls.Add(Me.tb_AENotas)
        Me.Controls.Add(Me.lb_AENotas)
        Me.Controls.Add(Me.lb_AEFechaalta)
        Me.Controls.Add(Me.lb_AEFechabaja)
        Me.Name = "frmEmpresa_Paciente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresas del paciente"
        CType(Me.LEMPRESABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPuesto As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_AECancelar As System.Windows.Forms.Button
    Friend WithEvents bt_AEAceptar As System.Windows.Forms.Button
    Friend WithEvents dtp_AEFechaalta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_AEFechabaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_AENotas As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents lb_AENotas As System.Windows.Forms.Label
    Friend WithEvents lb_AEFechaalta As System.Windows.Forms.Label
    Friend WithEvents lb_AEFechabaja As System.Windows.Forms.Label
    Friend WithEvents CtrlEmpresa1 As centro_medico.ctrlEmpresa
    Public WithEvents LEMPRESABindingSource As System.Windows.Forms.BindingSource
End Class
