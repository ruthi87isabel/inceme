<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeMedico
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
        Dim InformesGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformeMedico))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.grpFiltrarPorCodigo = New System.Windows.Forms.GroupBox()
        Me.CtrlPacienteHasta = New centro_medico.ctrlPaciente2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CtrlPacienteDesde = New centro_medico.ctrlPaciente2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chb_ingreso = New System.Windows.Forms.CheckBox()
        Me.InformesGridEX = New Janus.Windows.GridEX.GridEX()
        Me.INFORMEMEDICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.grpFiltrarInforme = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fechaDespues = New System.Windows.Forms.DateTimePicker()
        Me.CtrlMedico1 = New centro_medico.ctrlMedico()
        Me.fechaAntes = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1.SuspendLayout()
        Me.grpFiltrarPorCodigo.SuspendLayout()
        CType(Me.InformesGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORMEMEDICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltrarInforme.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator2, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(802, 25)
        Me.ToolStrip1.TabIndex = 225
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstNuevo
        '
        Me.tstNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNuevo.Name = "tstNuevo"
        Me.tstNuevo.Size = New System.Drawing.Size(62, 22)
        Me.tstNuevo.Text = "&Añadir"
        Me.tstNuevo.ToolTipText = "Nuevo"
        '
        'tst_Editar
        '
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar.Text = "&Modificar"
        Me.tst_Editar.ToolTipText = "Editar"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar.Text = "&Eliminar"
        Me.tst_Eliminar.ToolTipText = "Borrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'grpFiltrarPorCodigo
        '
        Me.grpFiltrarPorCodigo.Controls.Add(Me.CtrlPacienteHasta)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label2)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.CtrlPacienteDesde)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label1)
        Me.grpFiltrarPorCodigo.Location = New System.Drawing.Point(-67, -93)
        Me.grpFiltrarPorCodigo.Name = "grpFiltrarPorCodigo"
        Me.grpFiltrarPorCodigo.Size = New System.Drawing.Size(328, 84)
        Me.grpFiltrarPorCodigo.TabIndex = 229
        Me.grpFiltrarPorCodigo.TabStop = False
        Me.grpFiltrarPorCodigo.Text = "Filtrar pacientes por código"
        '
        'CtrlPacienteHasta
        '
        Me.CtrlPacienteHasta.ID_PACIENTE = Nothing
        Me.CtrlPacienteHasta.Location = New System.Drawing.Point(53, 51)
        Me.CtrlPacienteHasta.Name = "CtrlPacienteHasta"
        Me.CtrlPacienteHasta.Size = New System.Drawing.Size(267, 26)
        Me.CtrlPacienteHasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta"
        '
        'CtrlPacienteDesde
        '
        Me.CtrlPacienteDesde.ID_PACIENTE = Nothing
        Me.CtrlPacienteDesde.Location = New System.Drawing.Point(53, 19)
        Me.CtrlPacienteDesde.Name = "CtrlPacienteDesde"
        Me.CtrlPacienteDesde.Size = New System.Drawing.Size(267, 26)
        Me.CtrlPacienteDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde"
        '
        'chb_ingreso
        '
        Me.chb_ingreso.AutoSize = True
        Me.chb_ingreso.Location = New System.Drawing.Point(-59, -108)
        Me.chb_ingreso.Name = "chb_ingreso"
        Me.chb_ingreso.Size = New System.Drawing.Size(136, 17)
        Me.chb_ingreso.TabIndex = 227
        Me.chb_ingreso.Text = "Fecha de Ingreso entre"
        Me.chb_ingreso.UseVisualStyleBackColor = True
        '
        'InformesGridEX
        '
        Me.InformesGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.InformesGridEX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InformesGridEX.ColumnAutoResize = True
        Me.InformesGridEX.DataSource = Me.INFORMEMEDICOBindingSource
        InformesGridEX_DesignTimeLayout.LayoutString = resources.GetString("InformesGridEX_DesignTimeLayout.LayoutString")
        Me.InformesGridEX.DesignTimeLayout = InformesGridEX_DesignTimeLayout
        Me.InformesGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.InformesGridEX.GroupByBoxVisible = False
        Me.InformesGridEX.Location = New System.Drawing.Point(12, 104)
        Me.InformesGridEX.Name = "InformesGridEX"
        Me.InformesGridEX.Size = New System.Drawing.Size(778, 376)
        Me.InformesGridEX.TabIndex = 232
        '
        'INFORMEMEDICOBindingSource
        '
        Me.INFORMEMEDICOBindingSource.DataSource = GetType(centro_medico.INFORME_MEDICO)
        '
        'dtp_ff
        '
        Me.dtp_ff.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_ff.Enabled = False
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(59, -88)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(101, 20)
        Me.dtp_ff.TabIndex = 226
        '
        'dtp_fi
        '
        Me.dtp_fi.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fi.Enabled = False
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(-59, -88)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(101, 20)
        Me.dtp_fi.TabIndex = 228
        '
        'grpFiltrarInforme
        '
        Me.grpFiltrarInforme.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltrarInforme.Controls.Add(Me.Label3)
        Me.grpFiltrarInforme.Controls.Add(Me.Label4)
        Me.grpFiltrarInforme.Controls.Add(Me.fechaDespues)
        Me.grpFiltrarInforme.Controls.Add(Me.CtrlMedico1)
        Me.grpFiltrarInforme.Controls.Add(Me.fechaAntes)
        Me.grpFiltrarInforme.Location = New System.Drawing.Point(12, 28)
        Me.grpFiltrarInforme.Name = "grpFiltrarInforme"
        Me.grpFiltrarInforme.Size = New System.Drawing.Size(778, 70)
        Me.grpFiltrarInforme.TabIndex = 231
        Me.grpFiltrarInforme.TabStop = False
        Me.grpFiltrarInforme.Text = "Filtrar informes por:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(514, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(514, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 238
        Me.Label4.Text = "Desde"
        '
        'fechaDespues
        '
        Me.fechaDespues.CalendarMonthBackground = System.Drawing.Color.White
        Me.fechaDespues.Checked = False
        Me.fechaDespues.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDespues.Location = New System.Drawing.Point(556, 45)
        Me.fechaDespues.Name = "fechaDespues"
        Me.fechaDespues.ShowCheckBox = True
        Me.fechaDespues.Size = New System.Drawing.Size(101, 20)
        Me.fechaDespues.TabIndex = 235
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(21, 14)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(454, 42)
        Me.CtrlMedico1.TabIndex = 0
        '
        'fechaAntes
        '
        Me.fechaAntes.CalendarMonthBackground = System.Drawing.Color.White
        Me.fechaAntes.Checked = False
        Me.fechaAntes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaAntes.Location = New System.Drawing.Point(556, 19)
        Me.fechaAntes.Name = "fechaAntes"
        Me.fechaAntes.ShowCheckBox = True
        Me.fechaAntes.Size = New System.Drawing.Size(101, 20)
        Me.fechaAntes.TabIndex = 237
        '
        'frmInformeMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 492)
        Me.Controls.Add(Me.grpFiltrarPorCodigo)
        Me.Controls.Add(Me.chb_ingreso)
        Me.Controls.Add(Me.InformesGridEX)
        Me.Controls.Add(Me.grpFiltrarInforme)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmInformeMedico"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes Médicos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpFiltrarPorCodigo.ResumeLayout(False)
        Me.grpFiltrarPorCodigo.PerformLayout()
        CType(Me.InformesGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORMEMEDICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltrarInforme.ResumeLayout(False)
        Me.grpFiltrarInforme.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grpFiltrarPorCodigo As System.Windows.Forms.GroupBox
    Friend WithEvents CtrlPacienteHasta As centro_medico.ctrlPaciente2
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CtrlPacienteDesde As centro_medico.ctrlPaciente2
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chb_ingreso As System.Windows.Forms.CheckBox
    Friend WithEvents InformesGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpFiltrarInforme As System.Windows.Forms.GroupBox
    Friend WithEvents fechaDespues As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaAntes As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Friend WithEvents INFORMEMEDICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
