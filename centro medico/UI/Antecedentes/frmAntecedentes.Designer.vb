<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAntecedentes
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
        Dim GridEXLineaAlarma_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAntecedentes))
        Dim InfoPrimariaGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXDiagnosticoAntecedente_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.tstAlarmas = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstAnnadir_Alarma = New System.Windows.Forms.ToolStripButton()
        Me.tst_Modificar_Alarma = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar_Alarma = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GridEXLineaAlarma = New Janus.Windows.GridEX.GridEX()
        Me.LINEASALARMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tstInfoPrimaria = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tst_Annadir_InfoPrimaira = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar_InfoPrimaira = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar_InfoPrimaira = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfoPrimariaGridEX = New Janus.Windows.GridEX.GridEX()
        Me.INFORMACIONPRIMARIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tstDiagnosticos = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tst_Annadir_Diagnositco = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar_Diagnositco = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar_Diagnositco = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.GridEXDiagnosticoAntecedente = New Janus.Windows.GridEX.GridEX()
        Me.AntecedentesDiagnosticoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.editDiagnosticoObservaciones = New centro_medico.ctrlTextboxAvanzado()
        Me.EditDescripcionInfPrimaria = New centro_medico.ctrlTextboxAvanzado()
        Me.EditDescripcionAlarma = New centro_medico.ctrlTextboxAvanzado()
        Me.tstAlarmas.SuspendLayout()
        CType(Me.GridEXLineaAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASALARMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstInfoPrimaria.SuspendLayout()
        CType(Me.InfoPrimariaGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORMACIONPRIMARIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstDiagnosticos.SuspendLayout()
        CType(Me.GridEXDiagnosticoAntecedente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AntecedentesDiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tstAlarmas
        '
        Me.tstAlarmas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tstAlarmas.AutoSize = False
        Me.tstAlarmas.Dock = System.Windows.Forms.DockStyle.None
        Me.tstAlarmas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator4, Me.tstAnnadir_Alarma, Me.tst_Modificar_Alarma, Me.tst_Eliminar_Alarma, Me.ToolStripSeparator1})
        Me.tstAlarmas.Location = New System.Drawing.Point(3, 2)
        Me.tstAlarmas.Name = "tstAlarmas"
        Me.tstAlarmas.Size = New System.Drawing.Size(854, 25)
        Me.tstAlarmas.TabIndex = 0
        Me.tstAlarmas.Text = "ToolStrip3"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel2.Text = "Alarmas"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tstAnnadir_Alarma
        '
        Me.tstAnnadir_Alarma.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstAnnadir_Alarma.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstAnnadir_Alarma.Name = "tstAnnadir_Alarma"
        Me.tstAnnadir_Alarma.Size = New System.Drawing.Size(62, 22)
        Me.tstAnnadir_Alarma.Text = "&Añadir"
        '
        'tst_Modificar_Alarma
        '
        Me.tst_Modificar_Alarma.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Modificar_Alarma.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Modificar_Alarma.Name = "tst_Modificar_Alarma"
        Me.tst_Modificar_Alarma.Size = New System.Drawing.Size(78, 22)
        Me.tst_Modificar_Alarma.Text = "&Modificar"
        '
        'tst_Eliminar_Alarma
        '
        Me.tst_Eliminar_Alarma.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar_Alarma.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar_Alarma.Name = "tst_Eliminar_Alarma"
        Me.tst_Eliminar_Alarma.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar_Alarma.Text = "&Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'GridEXLineaAlarma
        '
        Me.GridEXLineaAlarma.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXLineaAlarma.ColumnAutoResize = True
        Me.GridEXLineaAlarma.DataSource = Me.LINEASALARMABindingSource
        GridEXLineaAlarma_DesignTimeLayout.LayoutString = resources.GetString("GridEXLineaAlarma_DesignTimeLayout.LayoutString")
        Me.GridEXLineaAlarma.DesignTimeLayout = GridEXLineaAlarma_DesignTimeLayout
        Me.GridEXLineaAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXLineaAlarma.GroupByBoxVisible = False
        Me.GridEXLineaAlarma.Location = New System.Drawing.Point(5, 30)
        Me.GridEXLineaAlarma.Name = "GridEXLineaAlarma"
        Me.GridEXLineaAlarma.Size = New System.Drawing.Size(493, 125)
        Me.GridEXLineaAlarma.TabIndex = 48
        Me.GridEXLineaAlarma.TabStop = False
        '
        'LINEASALARMABindingSource
        '
        Me.LINEASALARMABindingSource.DataSource = GetType(centro_medico.LINEASALARMA)
        '
        'tstInfoPrimaria
        '
        Me.tstInfoPrimaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tstInfoPrimaria.AutoSize = False
        Me.tstInfoPrimaria.Dock = System.Windows.Forms.DockStyle.None
        Me.tstInfoPrimaria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.tst_Annadir_InfoPrimaira, Me.tst_Editar_InfoPrimaira, Me.tst_Eliminar_InfoPrimaira, Me.ToolStripSeparator3})
        Me.tstInfoPrimaria.Location = New System.Drawing.Point(3, 170)
        Me.tstInfoPrimaria.Name = "tstInfoPrimaria"
        Me.tstInfoPrimaria.Size = New System.Drawing.Size(854, 25)
        Me.tstInfoPrimaria.TabIndex = 2
        Me.tstInfoPrimaria.Text = "ToolStrip3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripLabel1.Text = "Información Primaria"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tst_Annadir_InfoPrimaira
        '
        Me.tst_Annadir_InfoPrimaira.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tst_Annadir_InfoPrimaira.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Annadir_InfoPrimaira.Name = "tst_Annadir_InfoPrimaira"
        Me.tst_Annadir_InfoPrimaira.Size = New System.Drawing.Size(62, 22)
        Me.tst_Annadir_InfoPrimaira.Text = "&Añadir"
        '
        'tst_Editar_InfoPrimaira
        '
        Me.tst_Editar_InfoPrimaira.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar_InfoPrimaira.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar_InfoPrimaira.Name = "tst_Editar_InfoPrimaira"
        Me.tst_Editar_InfoPrimaira.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar_InfoPrimaira.Text = "&Modificar"
        '
        'tst_Eliminar_InfoPrimaira
        '
        Me.tst_Eliminar_InfoPrimaira.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar_InfoPrimaira.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar_InfoPrimaira.Name = "tst_Eliminar_InfoPrimaira"
        Me.tst_Eliminar_InfoPrimaira.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar_InfoPrimaira.Text = "&Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'InfoPrimariaGridEX
        '
        Me.InfoPrimariaGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.InfoPrimariaGridEX.ColumnAutoResize = True
        Me.InfoPrimariaGridEX.DataSource = Me.INFORMACIONPRIMARIABindingSource
        InfoPrimariaGridEX_DesignTimeLayout.LayoutString = resources.GetString("InfoPrimariaGridEX_DesignTimeLayout.LayoutString")
        Me.InfoPrimariaGridEX.DesignTimeLayout = InfoPrimariaGridEX_DesignTimeLayout
        Me.InfoPrimariaGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoPrimariaGridEX.GroupByBoxVisible = False
        Me.InfoPrimariaGridEX.Location = New System.Drawing.Point(4, 199)
        Me.InfoPrimariaGridEX.Name = "InfoPrimariaGridEX"
        Me.InfoPrimariaGridEX.Size = New System.Drawing.Size(494, 128)
        Me.InfoPrimariaGridEX.TabIndex = 50
        Me.InfoPrimariaGridEX.TabStop = False
        '
        'INFORMACIONPRIMARIABindingSource
        '
        Me.INFORMACIONPRIMARIABindingSource.DataSource = GetType(centro_medico.INFORMACIONPRIMARIA)
        '
        'tstDiagnosticos
        '
        Me.tstDiagnosticos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tstDiagnosticos.AutoSize = False
        Me.tstDiagnosticos.Dock = System.Windows.Forms.DockStyle.None
        Me.tstDiagnosticos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator5, Me.tst_Annadir_Diagnositco, Me.tst_Editar_Diagnositco, Me.tst_Eliminar_Diagnositco, Me.ToolStripSeparator6})
        Me.tstDiagnosticos.Location = New System.Drawing.Point(5, 343)
        Me.tstDiagnosticos.Name = "tstDiagnosticos"
        Me.tstDiagnosticos.Size = New System.Drawing.Size(852, 25)
        Me.tstDiagnosticos.TabIndex = 4
        Me.tstDiagnosticos.Text = "ToolStrip3"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripLabel3.Text = "Antecedentes"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tst_Annadir_Diagnositco
        '
        Me.tst_Annadir_Diagnositco.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tst_Annadir_Diagnositco.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Annadir_Diagnositco.Name = "tst_Annadir_Diagnositco"
        Me.tst_Annadir_Diagnositco.Size = New System.Drawing.Size(62, 22)
        Me.tst_Annadir_Diagnositco.Text = "&Añadir"
        '
        'tst_Editar_Diagnositco
        '
        Me.tst_Editar_Diagnositco.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar_Diagnositco.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar_Diagnositco.Name = "tst_Editar_Diagnositco"
        Me.tst_Editar_Diagnositco.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar_Diagnositco.Text = "&Modificar"
        '
        'tst_Eliminar_Diagnositco
        '
        Me.tst_Eliminar_Diagnositco.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar_Diagnositco.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar_Diagnositco.Name = "tst_Eliminar_Diagnositco"
        Me.tst_Eliminar_Diagnositco.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar_Diagnositco.Text = "&Eliminar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'GridEXDiagnosticoAntecedente
        '
        Me.GridEXDiagnosticoAntecedente.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDiagnosticoAntecedente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridEXDiagnosticoAntecedente.ColumnAutoResize = True
        Me.GridEXDiagnosticoAntecedente.DataSource = Me.AntecedentesDiagnosticoBindingSource
        GridEXDiagnosticoAntecedente_DesignTimeLayout.LayoutString = resources.GetString("GridEXDiagnosticoAntecedente_DesignTimeLayout.LayoutString")
        Me.GridEXDiagnosticoAntecedente.DesignTimeLayout = GridEXDiagnosticoAntecedente_DesignTimeLayout
        Me.GridEXDiagnosticoAntecedente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXDiagnosticoAntecedente.GroupByBoxVisible = False
        Me.GridEXDiagnosticoAntecedente.Location = New System.Drawing.Point(5, 370)
        Me.GridEXDiagnosticoAntecedente.Name = "GridEXDiagnosticoAntecedente"
        Me.GridEXDiagnosticoAntecedente.Size = New System.Drawing.Size(493, 131)
        Me.GridEXDiagnosticoAntecedente.TabIndex = 52
        Me.GridEXDiagnosticoAntecedente.TabStop = False
        '
        'AntecedentesDiagnosticoBindingSource
        '
        Me.AntecedentesDiagnosticoBindingSource.DataSource = GetType(centro_medico.AntecedentesDiagnostico)
        '
        'editDiagnosticoObservaciones
        '
        Me.editDiagnosticoObservaciones.AcceptsReturn = True
        Me.editDiagnosticoObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editDiagnosticoObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.editDiagnosticoObservaciones.Location = New System.Drawing.Point(504, 370)
        Me.editDiagnosticoObservaciones.Multiline = True
        Me.editDiagnosticoObservaciones.Name = "editDiagnosticoObservaciones"
        Me.editDiagnosticoObservaciones.ReadOnly = True
        Me.editDiagnosticoObservaciones.Size = New System.Drawing.Size(339, 131)
        Me.editDiagnosticoObservaciones.TabIndex = 5
        '
        'EditDescripcionInfPrimaria
        '
        Me.EditDescripcionInfPrimaria.AcceptsReturn = True
        Me.EditDescripcionInfPrimaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditDescripcionInfPrimaria.BackColor = System.Drawing.SystemColors.Window
        Me.EditDescripcionInfPrimaria.Location = New System.Drawing.Point(504, 199)
        Me.EditDescripcionInfPrimaria.Multiline = True
        Me.EditDescripcionInfPrimaria.Name = "EditDescripcionInfPrimaria"
        Me.EditDescripcionInfPrimaria.ReadOnly = True
        Me.EditDescripcionInfPrimaria.Size = New System.Drawing.Size(339, 128)
        Me.EditDescripcionInfPrimaria.TabIndex = 3
        '
        'EditDescripcionAlarma
        '
        Me.EditDescripcionAlarma.AcceptsReturn = True
        Me.EditDescripcionAlarma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditDescripcionAlarma.BackColor = System.Drawing.SystemColors.Window
        Me.EditDescripcionAlarma.Location = New System.Drawing.Point(504, 30)
        Me.EditDescripcionAlarma.Multiline = True
        Me.EditDescripcionAlarma.Name = "EditDescripcionAlarma"
        Me.EditDescripcionAlarma.ReadOnly = True
        Me.EditDescripcionAlarma.Size = New System.Drawing.Size(342, 125)
        Me.EditDescripcionAlarma.TabIndex = 6
        '
        'frmAntecedentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 546)
        Me.Controls.Add(Me.editDiagnosticoObservaciones)
        Me.Controls.Add(Me.EditDescripcionInfPrimaria)
        Me.Controls.Add(Me.EditDescripcionAlarma)
        Me.Controls.Add(Me.tstDiagnosticos)
        Me.Controls.Add(Me.GridEXDiagnosticoAntecedente)
        Me.Controls.Add(Me.tstInfoPrimaria)
        Me.Controls.Add(Me.InfoPrimariaGridEX)
        Me.Controls.Add(Me.tstAlarmas)
        Me.Controls.Add(Me.GridEXLineaAlarma)
        Me.MinimumSize = New System.Drawing.Size(871, 584)
        Me.Name = "frmAntecedentes"
        Me.Text = "Antecedentes"
        Me.tstAlarmas.ResumeLayout(False)
        Me.tstAlarmas.PerformLayout()
        CType(Me.GridEXLineaAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASALARMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstInfoPrimaria.ResumeLayout(False)
        Me.tstInfoPrimaria.PerformLayout()
        CType(Me.InfoPrimariaGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORMACIONPRIMARIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstDiagnosticos.ResumeLayout(False)
        Me.tstDiagnosticos.PerformLayout()
        CType(Me.GridEXDiagnosticoAntecedente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AntecedentesDiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tstAlarmas As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstAnnadir_Alarma As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Modificar_Alarma As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar_Alarma As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridEXLineaAlarma As Janus.Windows.GridEX.GridEX
    Friend WithEvents tstInfoPrimaria As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tst_Annadir_InfoPrimaira As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar_InfoPrimaira As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar_InfoPrimaira As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InfoPrimariaGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents tstDiagnosticos As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tst_Annadir_Diagnositco As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar_Diagnositco As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar_Diagnositco As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridEXDiagnosticoAntecedente As Janus.Windows.GridEX.GridEX
    Friend WithEvents EditDescripcionAlarma As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents EditDescripcionInfPrimaria As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents INFORMACIONPRIMARIABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AntecedentesDiagnosticoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEASALARMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents editDiagnosticoObservaciones As centro_medico.ctrlTextboxAvanzado
End Class
