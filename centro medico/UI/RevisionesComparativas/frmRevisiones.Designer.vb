<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevisiones
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
        Dim lb_revDetNotas As System.Windows.Forms.Label
        Dim lb_revDetDescripcion As System.Windows.Forms.Label
        Dim lb_revDetFecha As System.Windows.Forms.Label
        Dim grid_Revisiones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRevisiones))
        Dim GridEX_Resultados_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim Grid_Comparativas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim Grid_Comparativas_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition0.FormatStyle.BackgroundImag" & _
        "e")
        Me.grid_Revisiones = New Janus.Windows.GridEX.GridEX()
        Me.LCOMPARATIVAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPARATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEX_Resultados = New Janus.Windows.GridEX.GridEX()
        Me.DATOSCOMPARATIVAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tstRevisiones = New System.Windows.Forms.ToolStrip()
        Me.tst_RevisionComparada_ADD = New System.Windows.Forms.ToolStripButton()
        Me.tstDuplicarRevision = New System.Windows.Forms.ToolStripButton()
        Me.tst_RevisionComparada_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_RevisionComparada_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstConsultarGrafica = New System.Windows.Forms.ToolStripButton()
        Me.Grid_Comparativas = New Janus.Windows.GridEX.GridEX()
        Me.dtp_revDetFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tb_revNotas = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_revDetDescripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.CtrlImageWithStickers1 = New centro_medico.ctrlImageWithStickers()
        lb_revDetNotas = New System.Windows.Forms.Label()
        lb_revDetDescripcion = New System.Windows.Forms.Label()
        lb_revDetFecha = New System.Windows.Forms.Label()
        CType(Me.grid_Revisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCOMPARATIVAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX_Resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATOSCOMPARATIVAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstRevisiones.SuspendLayout()
        CType(Me.Grid_Comparativas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_revDetNotas
        '
        lb_revDetNotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        lb_revDetNotas.AutoSize = True
        lb_revDetNotas.Location = New System.Drawing.Point(6, 540)
        lb_revDetNotas.Name = "lb_revDetNotas"
        lb_revDetNotas.Size = New System.Drawing.Size(35, 13)
        lb_revDetNotas.TabIndex = 31
        lb_revDetNotas.Text = "Notas"
        '
        'lb_revDetDescripcion
        '
        lb_revDetDescripcion.AutoSize = True
        lb_revDetDescripcion.Location = New System.Drawing.Point(340, 23)
        lb_revDetDescripcion.Name = "lb_revDetDescripcion"
        lb_revDetDescripcion.Size = New System.Drawing.Size(63, 13)
        lb_revDetDescripcion.TabIndex = 35
        lb_revDetDescripcion.Text = "Descripción"
        '
        'lb_revDetFecha
        '
        lb_revDetFecha.AutoSize = True
        lb_revDetFecha.Location = New System.Drawing.Point(209, 23)
        lb_revDetFecha.Name = "lb_revDetFecha"
        lb_revDetFecha.Size = New System.Drawing.Size(37, 13)
        lb_revDetFecha.TabIndex = 32
        lb_revDetFecha.Text = "Fecha"
        '
        'grid_Revisiones
        '
        Me.grid_Revisiones.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grid_Revisiones.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.grid_Revisiones.ColumnAutoResize = True
        Me.grid_Revisiones.DataMember = Nothing
        Me.grid_Revisiones.DataSource = Me.LCOMPARATIVAsBindingSource
        grid_Revisiones_DesignTimeLayout.LayoutString = resources.GetString("grid_Revisiones_DesignTimeLayout.LayoutString")
        Me.grid_Revisiones.DesignTimeLayout = grid_Revisiones_DesignTimeLayout
        Me.grid_Revisiones.FocusCellFormatStyle.BackColor = System.Drawing.Color.Silver
        Me.grid_Revisiones.FocusCellFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.grid_Revisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grid_Revisiones.GroupByBoxVisible = False
        Me.grid_Revisiones.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.grid_Revisiones.Location = New System.Drawing.Point(6, 23)
        Me.grid_Revisiones.Name = "grid_Revisiones"
        Me.grid_Revisiones.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grid_Revisiones.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.grid_Revisiones.Size = New System.Drawing.Size(197, 244)
        Me.grid_Revisiones.TabIndex = 20
        Me.grid_Revisiones.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'LCOMPARATIVAsBindingSource
        '
        Me.LCOMPARATIVAsBindingSource.DataMember = "LCOMPARATIVAs"
        Me.LCOMPARATIVAsBindingSource.DataSource = Me.COMPARATIVABindingSource
        '
        'COMPARATIVABindingSource
        '
        Me.COMPARATIVABindingSource.DataSource = GetType(centro_medico.COMPARATIVA)
        '
        'GridEX_Resultados
        '
        Me.GridEX_Resultados.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX_Resultados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridEX_Resultados.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEX_Resultados.ColumnAutoResize = True
        Me.GridEX_Resultados.DataSource = Me.DATOSCOMPARATIVAsBindingSource
        GridEX_Resultados_DesignTimeLayout.LayoutString = resources.GetString("GridEX_Resultados_DesignTimeLayout.LayoutString")
        Me.GridEX_Resultados.DesignTimeLayout = GridEX_Resultados_DesignTimeLayout
        Me.GridEX_Resultados.FocusCellFormatStyle.BackColor = System.Drawing.Color.Silver
        Me.GridEX_Resultados.FocusCellFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GridEX_Resultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX_Resultados.GroupByBoxVisible = False
        Me.GridEX_Resultados.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEX_Resultados.Location = New System.Drawing.Point(6, 273)
        Me.GridEX_Resultados.Name = "GridEX_Resultados"
        Me.GridEX_Resultados.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.GridEX_Resultados.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GridEX_Resultados.Size = New System.Drawing.Size(197, 260)
        Me.GridEX_Resultados.TabIndex = 21
        Me.GridEX_Resultados.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'DATOSCOMPARATIVAsBindingSource
        '
        Me.DATOSCOMPARATIVAsBindingSource.DataMember = "DATOSCOMPARATIVAs"
        Me.DATOSCOMPARATIVAsBindingSource.DataSource = Me.LCOMPARATIVAsBindingSource
        '
        'tstRevisiones
        '
        Me.tstRevisiones.AutoSize = False
        Me.tstRevisiones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_RevisionComparada_ADD, Me.tstDuplicarRevision, Me.tst_RevisionComparada_Editar, Me.tst_RevisionComparada_Eliminar, Me.ToolStripSeparator1, Me.tstConsultarGrafica})
        Me.tstRevisiones.Location = New System.Drawing.Point(0, 0)
        Me.tstRevisiones.Name = "tstRevisiones"
        Me.tstRevisiones.Size = New System.Drawing.Size(884, 36)
        Me.tstRevisiones.TabIndex = 27
        Me.tstRevisiones.Text = "ToolStrip1"
        '
        'tst_RevisionComparada_ADD
        '
        Me.tst_RevisionComparada_ADD.Image = Global.centro_medico.My.Resources.Resources.MISC18
        Me.tst_RevisionComparada_ADD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_RevisionComparada_ADD.Name = "tst_RevisionComparada_ADD"
        Me.tst_RevisionComparada_ADD.Size = New System.Drawing.Size(101, 33)
        Me.tst_RevisionComparada_ADD.Text = "&Nueva Revisión"
        '
        'tstDuplicarRevision
        '
        Me.tstDuplicarRevision.Enabled = False
        Me.tstDuplicarRevision.Image = Global.centro_medico.My.Resources.Resources._24_imageset_add
        Me.tstDuplicarRevision.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstDuplicarRevision.Name = "tstDuplicarRevision"
        Me.tstDuplicarRevision.Size = New System.Drawing.Size(108, 33)
        Me.tstDuplicarRevision.Text = "&Duplicar Revisión"
        '
        'tst_RevisionComparada_Editar
        '
        Me.tst_RevisionComparada_Editar.Enabled = False
        Me.tst_RevisionComparada_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_RevisionComparada_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_RevisionComparada_Editar.Name = "tst_RevisionComparada_Editar"
        Me.tst_RevisionComparada_Editar.Size = New System.Drawing.Size(113, 33)
        Me.tst_RevisionComparada_Editar.Text = "&Modificar Revisión"
        '
        'tst_RevisionComparada_Eliminar
        '
        Me.tst_RevisionComparada_Eliminar.Enabled = False
        Me.tst_RevisionComparada_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_RevisionComparada_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_RevisionComparada_Eliminar.Name = "tst_RevisionComparada_Eliminar"
        Me.tst_RevisionComparada_Eliminar.Size = New System.Drawing.Size(106, 33)
        Me.tst_RevisionComparada_Eliminar.Text = "&Eliminar Revisión"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'tstConsultarGrafica
        '
        Me.tstConsultarGrafica.Enabled = False
        Me.tstConsultarGrafica.Image = Global.centro_medico.My.Resources.Resources.Line_Chart
        Me.tstConsultarGrafica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstConsultarGrafica.Name = "tstConsultarGrafica"
        Me.tstConsultarGrafica.Size = New System.Drawing.Size(110, 33)
        Me.tstConsultarGrafica.Text = "&Consultar Gráfica"
        '
        'Grid_Comparativas
        '
        Me.Grid_Comparativas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid_Comparativas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid_Comparativas.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.Grid_Comparativas.ColumnAutoResize = True
        Me.Grid_Comparativas.DataMember = Nothing
        Me.Grid_Comparativas.DataSource = Me.COMPARATIVABindingSource
        Grid_Comparativas_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_Comparativas_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_Comparativas_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_Comparativas_DesignTimeLayout_Reference_0})
        Grid_Comparativas_DesignTimeLayout.LayoutString = resources.GetString("Grid_Comparativas_DesignTimeLayout.LayoutString")
        Me.Grid_Comparativas.DesignTimeLayout = Grid_Comparativas_DesignTimeLayout
        Me.Grid_Comparativas.FocusCellFormatStyle.BackColor = System.Drawing.Color.Silver
        Me.Grid_Comparativas.FocusCellFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.Grid_Comparativas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Grid_Comparativas.GroupByBoxVisible = False
        Me.Grid_Comparativas.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.Grid_Comparativas.Location = New System.Drawing.Point(10, 39)
        Me.Grid_Comparativas.Name = "Grid_Comparativas"
        Me.Grid_Comparativas.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.Grid_Comparativas.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.Grid_Comparativas.Size = New System.Drawing.Size(223, 598)
        Me.Grid_Comparativas.TabIndex = 28
        Me.Grid_Comparativas.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'dtp_revDetFecha
        '
        Me.dtp_revDetFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.COMPARATIVABindingSource, "FECHA", True))
        Me.dtp_revDetFecha.Enabled = False
        Me.dtp_revDetFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_revDetFecha.Location = New System.Drawing.Point(247, 20)
        Me.dtp_revDetFecha.Name = "dtp_revDetFecha"
        Me.dtp_revDetFecha.Size = New System.Drawing.Size(87, 20)
        Me.dtp_revDetFecha.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.grid_Revisiones)
        Me.GroupBox1.Controls.Add(lb_revDetNotas)
        Me.GroupBox1.Controls.Add(lb_revDetDescripcion)
        Me.GroupBox1.Controls.Add(Me.tb_revNotas)
        Me.GroupBox1.Controls.Add(Me.GridEX_Resultados)
        Me.GroupBox1.Controls.Add(Me.tb_revDetDescripcion)
        Me.GroupBox1.Controls.Add(Me.CtrlImageWithStickers1)
        Me.GroupBox1.Controls.Add(lb_revDetFecha)
        Me.GroupBox1.Controls.Add(Me.dtp_revDetFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(239, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 598)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de la Revisión Seleccionada"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(884, 22)
        Me.StatusStrip1.TabIndex = 37
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = Global.centro_medico.My.Resources.Resources.lock
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(116, 17)
        Me.ToolStripStatusLabel2.Text = "Revisión Terminada"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(276, 17)
        Me.ToolStripStatusLabel1.Text = "Alt N=Añadir; Alt M=Borrar; Alt E=Eliminar; Alt F=Filtrar"
        '
        'tb_revNotas
        '
        Me.tb_revNotas.AcceptsReturn = True
        Me.tb_revNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_revNotas.BackColor = System.Drawing.Color.White
        Me.tb_revNotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPARATIVABindingSource, "NOTAS", True))
        Me.tb_revNotas.Location = New System.Drawing.Point(6, 556)
        Me.tb_revNotas.Multiline = True
        Me.tb_revNotas.Name = "tb_revNotas"
        Me.tb_revNotas.ReadOnly = True
        Me.tb_revNotas.Size = New System.Drawing.Size(627, 36)
        Me.tb_revNotas.TabIndex = 30
        '
        'tb_revDetDescripcion
        '
        Me.tb_revDetDescripcion.AcceptsReturn = True
        Me.tb_revDetDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_revDetDescripcion.BackColor = System.Drawing.Color.White
        Me.tb_revDetDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPARATIVABindingSource, "DESCRIPCION", True))
        Me.tb_revDetDescripcion.Location = New System.Drawing.Point(409, 19)
        Me.tb_revDetDescripcion.Name = "tb_revDetDescripcion"
        Me.tb_revDetDescripcion.ReadOnly = True
        Me.tb_revDetDescripcion.Size = New System.Drawing.Size(224, 20)
        Me.tb_revDetDescripcion.TabIndex = 34
        '
        'CtrlImageWithStickers1
        '
        Me.CtrlImageWithStickers1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlImageWithStickers1.BackColor = System.Drawing.Color.White
        Me.CtrlImageWithStickers1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CtrlImageWithStickers1.BackIMAGE = Nothing
        Me.CtrlImageWithStickers1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CtrlImageWithStickers1.Enabled = False
        Me.CtrlImageWithStickers1.Location = New System.Drawing.Point(212, 46)
        Me.CtrlImageWithStickers1.Name = "CtrlImageWithStickers1"
        Me.CtrlImageWithStickers1.Size = New System.Drawing.Size(424, 487)
        Me.CtrlImageWithStickers1.TabIndex = 29
        '
        'frmRevisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 662)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grid_Comparativas)
        Me.Controls.Add(Me.tstRevisiones)
        Me.Name = "frmRevisiones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revisiones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid_Revisiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCOMPARATIVAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX_Resultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATOSCOMPARATIVAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstRevisiones.ResumeLayout(False)
        Me.tstRevisiones.PerformLayout()
        CType(Me.Grid_Comparativas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_Revisiones As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEX_Resultados As Janus.Windows.GridEX.GridEX
    Friend WithEvents tstRevisiones As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_RevisionComparada_ADD As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstDuplicarRevision As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_RevisionComparada_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_RevisionComparada_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Grid_Comparativas As Janus.Windows.GridEX.GridEX
    Friend WithEvents COMPARATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LCOMPARATIVAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DATOSCOMPARATIVAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtrlImageWithStickers1 As centro_medico.ctrlImageWithStickers
    Friend WithEvents tb_revNotas As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_revDetDescripcion As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents dtp_revDetFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstConsultarGrafica As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
