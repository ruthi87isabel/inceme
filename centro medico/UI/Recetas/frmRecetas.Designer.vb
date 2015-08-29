<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecetas
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
        Dim GridEXRecetas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecetas))
        Me.RECETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEXRecetas = New Janus.Windows.GridEX.GridEX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.grpFiltrarInforme = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fechaDespues = New System.Windows.Forms.DateTimePicker()
        Me.fechaAntes = New System.Windows.Forms.DateTimePicker()
        Me.tb_reTratamiento = New centro_medico.ctrlTextboxAvanzado()
        Me.CtrlPacienteReceta = New centro_medico.ctrlPaciente2()
        Me.CtrlMedico1 = New centro_medico.ctrlMedico()
        CType(Me.RECETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.grpFiltrarInforme.SuspendLayout()
        Me.SuspendLayout()
        '
        'RECETABindingSource
        '
        Me.RECETABindingSource.DataSource = GetType(centro_medico.RECETA)
        '
        'GridEXRecetas
        '
        Me.GridEXRecetas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXRecetas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridEXRecetas.ColumnAutoResize = True
        Me.GridEXRecetas.DataSource = Me.RECETABindingSource
        GridEXRecetas_DesignTimeLayout.LayoutString = resources.GetString("GridEXRecetas_DesignTimeLayout.LayoutString")
        Me.GridEXRecetas.DesignTimeLayout = GridEXRecetas_DesignTimeLayout
        Me.GridEXRecetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXRecetas.GroupByBoxVisible = False
        Me.GridEXRecetas.Location = New System.Drawing.Point(8, 136)
        Me.GridEXRecetas.Name = "GridEXRecetas"
        Me.GridEXRecetas.Size = New System.Drawing.Size(505, 387)
        Me.GridEXRecetas.TabIndex = 3
        Me.GridEXRecetas.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(855, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'grpFiltrarInforme
        '
        Me.grpFiltrarInforme.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltrarInforme.Controls.Add(Me.Label3)
        Me.grpFiltrarInforme.Controls.Add(Me.CtrlPacienteReceta)
        Me.grpFiltrarInforme.Controls.Add(Me.Label1)
        Me.grpFiltrarInforme.Controls.Add(Me.Label2)
        Me.grpFiltrarInforme.Controls.Add(Me.fechaDespues)
        Me.grpFiltrarInforme.Controls.Add(Me.CtrlMedico1)
        Me.grpFiltrarInforme.Controls.Add(Me.fechaAntes)
        Me.grpFiltrarInforme.Location = New System.Drawing.Point(8, 26)
        Me.grpFiltrarInforme.Name = "grpFiltrarInforme"
        Me.grpFiltrarInforme.Size = New System.Drawing.Size(835, 104)
        Me.grpFiltrarInforme.TabIndex = 1
        Me.grpFiltrarInforme.TabStop = False
        Me.grpFiltrarInforme.Text = "Filtrar recetas por:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 239
        Me.Label3.Text = "Paciente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(573, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 238
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(573, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 238
        Me.Label2.Text = "Desde"
        '
        'fechaDespues
        '
        Me.fechaDespues.CalendarMonthBackground = System.Drawing.Color.White
        Me.fechaDespues.Checked = False
        Me.fechaDespues.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDespues.Location = New System.Drawing.Point(615, 66)
        Me.fechaDespues.Name = "fechaDespues"
        Me.fechaDespues.ShowCheckBox = True
        Me.fechaDespues.Size = New System.Drawing.Size(101, 20)
        Me.fechaDespues.TabIndex = 3
        '
        'fechaAntes
        '
        Me.fechaAntes.CalendarMonthBackground = System.Drawing.Color.White
        Me.fechaAntes.Checked = False
        Me.fechaAntes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaAntes.Location = New System.Drawing.Point(615, 40)
        Me.fechaAntes.Name = "fechaAntes"
        Me.fechaAntes.ShowCheckBox = True
        Me.fechaAntes.Size = New System.Drawing.Size(101, 20)
        Me.fechaAntes.TabIndex = 2
        '
        'tb_reTratamiento
        '
        Me.tb_reTratamiento.AcceptsReturn = True
        Me.tb_reTratamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_reTratamiento.BackColor = System.Drawing.SystemColors.Window
        Me.tb_reTratamiento.Location = New System.Drawing.Point(525, 136)
        Me.tb_reTratamiento.Multiline = True
        Me.tb_reTratamiento.Name = "tb_reTratamiento"
        Me.tb_reTratamiento.ReadOnly = True
        Me.tb_reTratamiento.Size = New System.Drawing.Size(318, 387)
        Me.tb_reTratamiento.TabIndex = 4
        '
        'CtrlPacienteReceta
        '
        Me.CtrlPacienteReceta.ID_PACIENTE = Nothing
        Me.CtrlPacienteReceta.Location = New System.Drawing.Point(18, 71)
        Me.CtrlPacienteReceta.Name = "CtrlPacienteReceta"
        Me.CtrlPacienteReceta.Size = New System.Drawing.Size(511, 26)
        Me.CtrlPacienteReceta.TabIndex = 2
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(21, 14)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(502, 42)
        Me.CtrlMedico1.TabIndex = 1
        '
        'frmRecetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 543)
        Me.Controls.Add(Me.tb_reTratamiento)
        Me.Controls.Add(Me.grpFiltrarInforme)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GridEXRecetas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecetas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recetas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RECETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpFiltrarInforme.ResumeLayout(False)
        Me.grpFiltrarInforme.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridEXRecetas As Janus.Windows.GridEX.GridEX
    Friend WithEvents CtrlPacienteReceta As centro_medico.ctrlPaciente2
    Friend WithEvents RECETABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grpFiltrarInforme As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fechaDespues As System.Windows.Forms.DateTimePicker
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Friend WithEvents fechaAntes As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_reTratamiento As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
