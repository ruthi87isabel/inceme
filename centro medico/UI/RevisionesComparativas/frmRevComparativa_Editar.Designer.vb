<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevComparativa_Editar
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
        Dim grid_Revisiones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRevComparativa_Editar))
        Dim Grid_Tratamientos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX_Resultados_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.gb_RCDatos = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.COMPARATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CtrlModeloRevision1 = New centro_medico.ctrlModeloRevision()
        Me.dtp_RCFechainicio = New System.Windows.Forms.DateTimePicker()
        Me.tb_RCNotasRevision = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_RCDescripcionRevision = New centro_medico.ctrlTextboxAvanzado()
        Me.lb_RCNotasModelo = New System.Windows.Forms.Label()
        Me.lb_RCDescripcionModelo = New System.Windows.Forms.Label()
        Me.lb_RCFechainicio = New System.Windows.Forms.Label()
        Me.lb_RCModelorevision = New System.Windows.Forms.Label()
        Me.grid_Revisiones = New Janus.Windows.GridEX.GridEX()
        Me.LCOMPARATIVAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tstTratamientos = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstAnnadir_Tratamiento = New System.Windows.Forms.ToolStripButton()
        Me.tst_Modificar_Tratamiento = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar_Tratamiento = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Grid_Tratamientos = New Janus.Windows.GridEX.GridEX()
        Me.LCOMPARATIVASTRATAMIENTOsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gb_RCResultados = New System.Windows.Forms.GroupBox()
        Me.GridEX_Resultados = New Janus.Windows.GridEX.GridEX()
        Me.DATOSCOMPARATIVAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lb_RCNotasResultados = New System.Windows.Forms.Label()
        Me.tsSeguimientos = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstFechaSeg_Annadir = New System.Windows.Forms.ToolStripButton()
        Me.tstFechaSeg_Modificar = New System.Windows.Forms.ToolStripButton()
        Me.tstFechaSeg_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstImprmirSeguimientoPaciente = New System.Windows.Forms.ToolStripButton()
        Me.tstImprimirSeguimientoClinica = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tstGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tstCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstConsultarGrafica = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstNuevaCita = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstImprimir = New System.Windows.Forms.ToolStripDropDownButton()
        Me.RevisionComparativaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisiónComparativaClinicaPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRevisionCerrada = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btAbriImagen = New System.Windows.Forms.Button()
        Me.btLoadImage = New System.Windows.Forms.Button()
        Me.btDeleteImage = New System.Windows.Forms.Button()
        Me.CtrlImageWithStickers1 = New centro_medico.ctrlImageWithStickers()
        Me.tb_RCNotasSeguimientos = New centro_medico.ctrlTextboxAvanzado()
        Me.gb_RCDatos.SuspendLayout()
        CType(Me.COMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_Revisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCOMPARATIVAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstTratamientos.SuspendLayout()
        CType(Me.Grid_Tratamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCOMPARATIVASTRATAMIENTOsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_RCResultados.SuspendLayout()
        CType(Me.GridEX_Resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATOSCOMPARATIVAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsSeguimientos.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_RCDatos
        '
        Me.gb_RCDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_RCDatos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb_RCDatos.Controls.Add(Me.DateTimePicker1)
        Me.gb_RCDatos.Controls.Add(Me.Label3)
        Me.gb_RCDatos.Controls.Add(Me.CtrlModeloRevision1)
        Me.gb_RCDatos.Controls.Add(Me.dtp_RCFechainicio)
        Me.gb_RCDatos.Controls.Add(Me.tb_RCNotasRevision)
        Me.gb_RCDatos.Controls.Add(Me.tb_RCDescripcionRevision)
        Me.gb_RCDatos.Controls.Add(Me.lb_RCNotasModelo)
        Me.gb_RCDatos.Controls.Add(Me.lb_RCDescripcionModelo)
        Me.gb_RCDatos.Controls.Add(Me.lb_RCFechainicio)
        Me.gb_RCDatos.Controls.Add(Me.lb_RCModelorevision)
        Me.gb_RCDatos.Location = New System.Drawing.Point(7, 24)
        Me.gb_RCDatos.Name = "gb_RCDatos"
        Me.gb_RCDatos.Size = New System.Drawing.Size(545, 148)
        Me.gb_RCDatos.TabIndex = 5
        Me.gb_RCDatos.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.COMPARATIVABindingSource, "FECHATERMINADA", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(11, 121)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(127, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'COMPARATIVABindingSource
        '
        Me.COMPARATIVABindingSource.DataSource = GetType(centro_medico.COMPARATIVA)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha final"
        '
        'CtrlModeloRevision1
        '
        Me.CtrlModeloRevision1.CODIGO = Nothing
        Me.CtrlModeloRevision1.DataBindings.Add(New System.Windows.Forms.Binding("CODIGO", Me.COMPARATIVABindingSource, "REFMODELOCOMPARATIVA", True))
        Me.CtrlModeloRevision1.Location = New System.Drawing.Point(10, 27)
        Me.CtrlModeloRevision1.Name = "CtrlModeloRevision1"
        Me.CtrlModeloRevision1.Size = New System.Drawing.Size(481, 26)
        Me.CtrlModeloRevision1.TabIndex = 1
        '
        'dtp_RCFechainicio
        '
        Me.dtp_RCFechainicio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.COMPARATIVABindingSource, "FECHA", True))
        Me.dtp_RCFechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_RCFechainicio.Location = New System.Drawing.Point(11, 79)
        Me.dtp_RCFechainicio.Name = "dtp_RCFechainicio"
        Me.dtp_RCFechainicio.Size = New System.Drawing.Size(127, 20)
        Me.dtp_RCFechainicio.TabIndex = 4
        '
        'tb_RCNotasRevision
        '
        Me.tb_RCNotasRevision.AcceptsReturn = True
        Me.tb_RCNotasRevision.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_RCNotasRevision.BackColor = System.Drawing.Color.White
        Me.tb_RCNotasRevision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPARATIVABindingSource, "NOTAS", True))
        Me.tb_RCNotasRevision.Location = New System.Drawing.Point(329, 75)
        Me.tb_RCNotasRevision.MaxLength = 150
        Me.tb_RCNotasRevision.Multiline = True
        Me.tb_RCNotasRevision.Name = "tb_RCNotasRevision"
        Me.tb_RCNotasRevision.Size = New System.Drawing.Size(210, 63)
        Me.tb_RCNotasRevision.TabIndex = 6
        '
        'tb_RCDescripcionRevision
        '
        Me.tb_RCDescripcionRevision.AcceptsReturn = True
        Me.tb_RCDescripcionRevision.BackColor = System.Drawing.Color.White
        Me.tb_RCDescripcionRevision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPARATIVABindingSource, "DESCRIPCION", True))
        Me.tb_RCDescripcionRevision.Location = New System.Drawing.Point(147, 75)
        Me.tb_RCDescripcionRevision.MaxLength = 90
        Me.tb_RCDescripcionRevision.Multiline = True
        Me.tb_RCDescripcionRevision.Name = "tb_RCDescripcionRevision"
        Me.tb_RCDescripcionRevision.Size = New System.Drawing.Size(174, 63)
        Me.tb_RCDescripcionRevision.TabIndex = 5
        Me.tb_RCDescripcionRevision.Text = " "
        '
        'lb_RCNotasModelo
        '
        Me.lb_RCNotasModelo.AutoSize = True
        Me.lb_RCNotasModelo.Location = New System.Drawing.Point(329, 56)
        Me.lb_RCNotasModelo.Name = "lb_RCNotasModelo"
        Me.lb_RCNotasModelo.Size = New System.Drawing.Size(161, 13)
        Me.lb_RCNotasModelo.TabIndex = 3
        Me.lb_RCNotasModelo.Text = "Notas de la revision comparativa"
        '
        'lb_RCDescripcionModelo
        '
        Me.lb_RCDescripcionModelo.AutoSize = True
        Me.lb_RCDescripcionModelo.Location = New System.Drawing.Point(158, 56)
        Me.lb_RCDescripcionModelo.Name = "lb_RCDescripcionModelo"
        Me.lb_RCDescripcionModelo.Size = New System.Drawing.Size(63, 13)
        Me.lb_RCDescripcionModelo.TabIndex = 2
        Me.lb_RCDescripcionModelo.Text = "Descripción"
        '
        'lb_RCFechainicio
        '
        Me.lb_RCFechainicio.AutoSize = True
        Me.lb_RCFechainicio.Location = New System.Drawing.Point(8, 63)
        Me.lb_RCFechainicio.Name = "lb_RCFechainicio"
        Me.lb_RCFechainicio.Size = New System.Drawing.Size(80, 13)
        Me.lb_RCFechainicio.TabIndex = 1
        Me.lb_RCFechainicio.Text = "Fecha de Inicio"
        '
        'lb_RCModelorevision
        '
        Me.lb_RCModelorevision.AutoSize = True
        Me.lb_RCModelorevision.Location = New System.Drawing.Point(7, 11)
        Me.lb_RCModelorevision.Name = "lb_RCModelorevision"
        Me.lb_RCModelorevision.Size = New System.Drawing.Size(164, 13)
        Me.lb_RCModelorevision.TabIndex = 0
        Me.lb_RCModelorevision.Text = "Modelo de Revisión (por defecto)"
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
        Me.grid_Revisiones.Location = New System.Drawing.Point(7, 204)
        Me.grid_Revisiones.Name = "grid_Revisiones"
        Me.grid_Revisiones.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grid_Revisiones.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.grid_Revisiones.Size = New System.Drawing.Size(290, 156)
        Me.grid_Revisiones.TabIndex = 11
        Me.grid_Revisiones.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'LCOMPARATIVAsBindingSource
        '
        Me.LCOMPARATIVAsBindingSource.DataMember = "LCOMPARATIVAs"
        Me.LCOMPARATIVAsBindingSource.DataSource = Me.COMPARATIVABindingSource
        '
        'tstTratamientos
        '
        Me.tstTratamientos.AutoSize = False
        Me.tstTratamientos.Dock = System.Windows.Forms.DockStyle.None
        Me.tstTratamientos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator4, Me.tstAnnadir_Tratamiento, Me.tst_Modificar_Tratamiento, Me.tst_Eliminar_Tratamiento, Me.ToolStripSeparator1})
        Me.tstTratamientos.Location = New System.Drawing.Point(7, 444)
        Me.tstTratamientos.Name = "tstTratamientos"
        Me.tstTratamientos.Size = New System.Drawing.Size(549, 25)
        Me.tstTratamientos.TabIndex = 14
        Me.tstTratamientos.Text = "ToolStrip3"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripLabel2.Text = "Tratamientos:"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tstAnnadir_Tratamiento
        '
        Me.tstAnnadir_Tratamiento.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstAnnadir_Tratamiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstAnnadir_Tratamiento.Name = "tstAnnadir_Tratamiento"
        Me.tstAnnadir_Tratamiento.Size = New System.Drawing.Size(58, 22)
        Me.tstAnnadir_Tratamiento.Text = "&Añadir"
        '
        'tst_Modificar_Tratamiento
        '
        Me.tst_Modificar_Tratamiento.Enabled = False
        Me.tst_Modificar_Tratamiento.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Modificar_Tratamiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Modificar_Tratamiento.Name = "tst_Modificar_Tratamiento"
        Me.tst_Modificar_Tratamiento.Size = New System.Drawing.Size(70, 22)
        Me.tst_Modificar_Tratamiento.Text = "&Modificar"
        '
        'tst_Eliminar_Tratamiento
        '
        Me.tst_Eliminar_Tratamiento.Enabled = False
        Me.tst_Eliminar_Tratamiento.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar_Tratamiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar_Tratamiento.Name = "tst_Eliminar_Tratamiento"
        Me.tst_Eliminar_Tratamiento.Size = New System.Drawing.Size(63, 22)
        Me.tst_Eliminar_Tratamiento.Text = "&Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Grid_Tratamientos
        '
        Me.Grid_Tratamientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid_Tratamientos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid_Tratamientos.ColumnAutoResize = True
        Me.Grid_Tratamientos.DataSource = Me.LCOMPARATIVASTRATAMIENTOsBindingSource
        Grid_Tratamientos_DesignTimeLayout.LayoutString = resources.GetString("Grid_Tratamientos_DesignTimeLayout.LayoutString")
        Me.Grid_Tratamientos.DesignTimeLayout = Grid_Tratamientos_DesignTimeLayout
        Me.Grid_Tratamientos.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.Grid_Tratamientos.FocusCellFormatStyle.BackColor = System.Drawing.Color.Silver
        Me.Grid_Tratamientos.FocusCellFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.Grid_Tratamientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Grid_Tratamientos.GroupByBoxVisible = False
        Me.Grid_Tratamientos.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.Grid_Tratamientos.Location = New System.Drawing.Point(7, 471)
        Me.Grid_Tratamientos.Name = "Grid_Tratamientos"
        Me.Grid_Tratamientos.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.Grid_Tratamientos.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.Grid_Tratamientos.Size = New System.Drawing.Size(552, 199)
        Me.Grid_Tratamientos.TabIndex = 13
        Me.Grid_Tratamientos.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'LCOMPARATIVASTRATAMIENTOsBindingSource
        '
        Me.LCOMPARATIVASTRATAMIENTOsBindingSource.DataMember = "LCOMPARATIVAS_TRATAMIENTOs"
        Me.LCOMPARATIVASTRATAMIENTOsBindingSource.DataSource = Me.LCOMPARATIVAsBindingSource
        '
        'gb_RCResultados
        '
        Me.gb_RCResultados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_RCResultados.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb_RCResultados.Controls.Add(Me.GridEX_Resultados)
        Me.gb_RCResultados.Location = New System.Drawing.Point(303, 201)
        Me.gb_RCResultados.Name = "gb_RCResultados"
        Me.gb_RCResultados.Size = New System.Drawing.Size(693, 159)
        Me.gb_RCResultados.TabIndex = 16
        Me.gb_RCResultados.TabStop = False
        Me.gb_RCResultados.Text = "Resultados"
        '
        'GridEX_Resultados
        '
        Me.GridEX_Resultados.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX_Resultados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GridEX_Resultados.Location = New System.Drawing.Point(6, 19)
        Me.GridEX_Resultados.Name = "GridEX_Resultados"
        Me.GridEX_Resultados.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.GridEX_Resultados.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GridEX_Resultados.Size = New System.Drawing.Size(681, 129)
        Me.GridEX_Resultados.TabIndex = 12
        Me.GridEX_Resultados.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'DATOSCOMPARATIVAsBindingSource
        '
        Me.DATOSCOMPARATIVAsBindingSource.DataMember = "DATOSCOMPARATIVAs"
        Me.DATOSCOMPARATIVAsBindingSource.DataSource = Me.LCOMPARATIVAsBindingSource
        '
        'lb_RCNotasResultados
        '
        Me.lb_RCNotasResultados.AutoSize = True
        Me.lb_RCNotasResultados.Location = New System.Drawing.Point(4, 365)
        Me.lb_RCNotasResultados.Name = "lb_RCNotasResultados"
        Me.lb_RCNotasResultados.Size = New System.Drawing.Size(111, 13)
        Me.lb_RCNotasResultados.TabIndex = 1
        Me.lb_RCNotasResultados.Text = "Notas del seguimiento"
        '
        'tsSeguimientos
        '
        Me.tsSeguimientos.AutoSize = False
        Me.tsSeguimientos.Dock = System.Windows.Forms.DockStyle.None
        Me.tsSeguimientos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator3, Me.tstFechaSeg_Annadir, Me.tstFechaSeg_Modificar, Me.tstFechaSeg_Eliminar, Me.ToolStripSeparator2, Me.tstImprmirSeguimientoPaciente, Me.tstImprimirSeguimientoClinica})
        Me.tsSeguimientos.Location = New System.Drawing.Point(1, 176)
        Me.tsSeguimientos.Name = "tsSeguimientos"
        Me.tsSeguimientos.Size = New System.Drawing.Size(552, 25)
        Me.tsSeguimientos.TabIndex = 17
        Me.tsSeguimientos.Text = "ToolStrip3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripLabel1.Text = "Fechas de Seguimiento:"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tstFechaSeg_Annadir
        '
        Me.tstFechaSeg_Annadir.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstFechaSeg_Annadir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstFechaSeg_Annadir.Name = "tstFechaSeg_Annadir"
        Me.tstFechaSeg_Annadir.Size = New System.Drawing.Size(58, 22)
        Me.tstFechaSeg_Annadir.Text = "&Añadir"
        '
        'tstFechaSeg_Modificar
        '
        Me.tstFechaSeg_Modificar.Enabled = False
        Me.tstFechaSeg_Modificar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tstFechaSeg_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstFechaSeg_Modificar.Name = "tstFechaSeg_Modificar"
        Me.tstFechaSeg_Modificar.Size = New System.Drawing.Size(70, 22)
        Me.tstFechaSeg_Modificar.Text = "&Modificar"
        '
        'tstFechaSeg_Eliminar
        '
        Me.tstFechaSeg_Eliminar.Enabled = False
        Me.tstFechaSeg_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tstFechaSeg_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstFechaSeg_Eliminar.Name = "tstFechaSeg_Eliminar"
        Me.tstFechaSeg_Eliminar.Size = New System.Drawing.Size(63, 22)
        Me.tstFechaSeg_Eliminar.Text = "&Eliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tstImprmirSeguimientoPaciente
        '
        Me.tstImprmirSeguimientoPaciente.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tstImprmirSeguimientoPaciente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstImprmirSeguimientoPaciente.Name = "tstImprmirSeguimientoPaciente"
        Me.tstImprmirSeguimientoPaciente.Size = New System.Drawing.Size(105, 22)
        Me.tstImprmirSeguimientoPaciente.Text = "Parcial  Paciente"
        Me.tstImprmirSeguimientoPaciente.ToolTipText = "Imprimir parciales selecc. Paciente"
        '
        'tstImprimirSeguimientoClinica
        '
        Me.tstImprimirSeguimientoClinica.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tstImprimirSeguimientoClinica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstImprimirSeguimientoClinica.Name = "tstImprimirSeguimientoClinica"
        Me.tstImprimirSeguimientoClinica.Size = New System.Drawing.Size(91, 22)
        Me.tstImprimirSeguimientoClinica.Text = "Parcial Clinica"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstGuardar, Me.tstCancelar, Me.ToolStripSeparator5, Me.tstConsultarGrafica, Me.ToolStripSeparator6, Me.tstNuevaCita, Me.ToolStripSeparator7, Me.tstImprimir})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1007, 25)
        Me.ToolStrip2.TabIndex = 18
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tstGuardar
        '
        Me.tstGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tstGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstGuardar.Name = "tstGuardar"
        Me.tstGuardar.Size = New System.Drawing.Size(66, 22)
        Me.tstGuardar.Text = "Guardar"
        '
        'tstCancelar
        '
        Me.tstCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tstCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstCancelar.Name = "tstCancelar"
        Me.tstCancelar.Size = New System.Drawing.Size(69, 22)
        Me.tstCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tstConsultarGrafica
        '
        Me.tstConsultarGrafica.Image = Global.centro_medico.My.Resources.Resources.Line_Chart
        Me.tstConsultarGrafica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstConsultarGrafica.Name = "tstConsultarGrafica"
        Me.tstConsultarGrafica.Size = New System.Drawing.Size(110, 22)
        Me.tstConsultarGrafica.Text = "Consultar Gráfica"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tstNuevaCita
        '
        Me.tstNuevaCita.Image = Global.centro_medico.My.Resources.Resources.Citas
        Me.tstNuevaCita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNuevaCita.Name = "tstNuevaCita"
        Me.tstNuevaCita.Size = New System.Drawing.Size(80, 22)
        Me.tstNuevaCita.Text = "Nueva Cita"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tstImprimir
        '
        Me.tstImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RevisionComparativaToolStripMenuItem, Me.RevisiónComparativaClinicaPacienteToolStripMenuItem})
        Me.tstImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tstImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstImprimir.Name = "tstImprimir"
        Me.tstImprimir.Size = New System.Drawing.Size(74, 22)
        Me.tstImprimir.Text = "Imprimir"
        '
        'RevisionComparativaToolStripMenuItem
        '
        Me.RevisionComparativaToolStripMenuItem.Name = "RevisionComparativaToolStripMenuItem"
        Me.RevisionComparativaToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.RevisionComparativaToolStripMenuItem.Text = "Revisión Comparativa Clinica"
        '
        'RevisiónComparativaClinicaPacienteToolStripMenuItem
        '
        Me.RevisiónComparativaClinicaPacienteToolStripMenuItem.Name = "RevisiónComparativaClinicaPacienteToolStripMenuItem"
        Me.RevisiónComparativaClinicaPacienteToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.RevisiónComparativaClinicaPacienteToolStripMenuItem.Text = "Revisión Comparativa Clinica Paciente"
        '
        'lblRevisionCerrada
        '
        Me.lblRevisionCerrada.AutoSize = True
        Me.lblRevisionCerrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevisionCerrada.ForeColor = System.Drawing.Color.Red
        Me.lblRevisionCerrada.Location = New System.Drawing.Point(548, 8)
        Me.lblRevisionCerrada.Name = "lblRevisionCerrada"
        Me.lblRevisionCerrada.Size = New System.Drawing.Size(420, 13)
        Me.lblRevisionCerrada.TabIndex = 20
        Me.lblRevisionCerrada.Text = "REVISION CERRADA, SOLO LECTURA, EXCEPTO ADMINISTRADORES"
        Me.lblRevisionCerrada.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(559, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(436, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btAbriImagen
        '
        Me.btAbriImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAbriImagen.FlatAppearance.BorderSize = 0
        Me.btAbriImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAbriImagen.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.btAbriImagen.Location = New System.Drawing.Point(950, 171)
        Me.btAbriImagen.Name = "btAbriImagen"
        Me.btAbriImagen.Size = New System.Drawing.Size(28, 28)
        Me.btAbriImagen.TabIndex = 22
        Me.btAbriImagen.UseVisualStyleBackColor = True
        '
        'btLoadImage
        '
        Me.btLoadImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLoadImage.FlatAppearance.BorderSize = 0
        Me.btLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLoadImage.Image = Global.centro_medico.My.Resources.Resources.add
        Me.btLoadImage.Location = New System.Drawing.Point(576, 171)
        Me.btLoadImage.Name = "btLoadImage"
        Me.btLoadImage.Size = New System.Drawing.Size(28, 28)
        Me.btLoadImage.TabIndex = 23
        Me.btLoadImage.UseVisualStyleBackColor = True
        '
        'btDeleteImage
        '
        Me.btDeleteImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btDeleteImage.FlatAppearance.BorderSize = 0
        Me.btDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDeleteImage.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btDeleteImage.Location = New System.Drawing.Point(610, 171)
        Me.btDeleteImage.Name = "btDeleteImage"
        Me.btDeleteImage.Size = New System.Drawing.Size(28, 28)
        Me.btDeleteImage.TabIndex = 24
        Me.btDeleteImage.UseVisualStyleBackColor = True
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
        Me.CtrlImageWithStickers1.Location = New System.Drawing.Point(576, 366)
        Me.CtrlImageWithStickers1.Name = "CtrlImageWithStickers1"
        Me.CtrlImageWithStickers1.Size = New System.Drawing.Size(419, 308)
        Me.CtrlImageWithStickers1.TabIndex = 19
        '
        'tb_RCNotasSeguimientos
        '
        Me.tb_RCNotasSeguimientos.AcceptsReturn = True
        Me.tb_RCNotasSeguimientos.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_RCNotasSeguimientos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LCOMPARATIVAsBindingSource, "NOTAS", True))
        Me.tb_RCNotasSeguimientos.Location = New System.Drawing.Point(7, 383)
        Me.tb_RCNotasSeguimientos.Multiline = True
        Me.tb_RCNotasSeguimientos.Name = "tb_RCNotasSeguimientos"
        Me.tb_RCNotasSeguimientos.ReadOnly = True
        Me.tb_RCNotasSeguimientos.Size = New System.Drawing.Size(549, 53)
        Me.tb_RCNotasSeguimientos.TabIndex = 12
        '
        'frmRevComparativa_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1007, 682)
        Me.Controls.Add(Me.btDeleteImage)
        Me.Controls.Add(Me.btLoadImage)
        Me.Controls.Add(Me.btAbriImagen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblRevisionCerrada)
        Me.Controls.Add(Me.CtrlImageWithStickers1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.tsSeguimientos)
        Me.Controls.Add(Me.tstTratamientos)
        Me.Controls.Add(Me.lb_RCNotasResultados)
        Me.Controls.Add(Me.tb_RCNotasSeguimientos)
        Me.Controls.Add(Me.gb_RCResultados)
        Me.Controls.Add(Me.Grid_Tratamientos)
        Me.Controls.Add(Me.grid_Revisiones)
        Me.Controls.Add(Me.gb_RCDatos)
        Me.Name = "frmRevComparativa_Editar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revisión Comparativa (Editar)"
        Me.gb_RCDatos.ResumeLayout(False)
        Me.gb_RCDatos.PerformLayout()
        CType(Me.COMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_Revisiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCOMPARATIVAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstTratamientos.ResumeLayout(False)
        Me.tstTratamientos.PerformLayout()
        CType(Me.Grid_Tratamientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCOMPARATIVASTRATAMIENTOsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_RCResultados.ResumeLayout(False)
        CType(Me.GridEX_Resultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATOSCOMPARATIVAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsSeguimientos.ResumeLayout(False)
        Me.tsSeguimientos.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrlModeloRevision1 As centro_medico.ctrlModeloRevision
    Friend WithEvents gb_RCDatos As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_RCFechainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_RCNotasRevision As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents tb_RCDescripcionRevision As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents lb_RCNotasModelo As System.Windows.Forms.Label
    Friend WithEvents lb_RCDescripcionModelo As System.Windows.Forms.Label
    Friend WithEvents lb_RCFechainicio As System.Windows.Forms.Label
    Friend WithEvents lb_RCModelorevision As System.Windows.Forms.Label
    Friend WithEvents grid_Revisiones As Janus.Windows.GridEX.GridEX
    Friend WithEvents tstTratamientos As System.Windows.Forms.ToolStrip
    Friend WithEvents tstAnnadir_Tratamiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Modificar_Tratamiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar_Tratamiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Grid_Tratamientos As Janus.Windows.GridEX.GridEX
    Friend WithEvents gb_RCResultados As System.Windows.Forms.GroupBox
    Friend WithEvents tb_RCNotasSeguimientos As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents lb_RCNotasResultados As System.Windows.Forms.Label
    Friend WithEvents tsSeguimientos As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstFechaSeg_Annadir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstFechaSeg_Modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstFechaSeg_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstConsultarGrafica As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstNuevaCita As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridEX_Resultados As Janus.Windows.GridEX.GridEX
    Friend WithEvents COMPARATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LCOMPARATIVAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LCOMPARATIVASTRATAMIENTOsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DATOSCOMPARATIVAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtrlImageWithStickers1 As centro_medico.ctrlImageWithStickers
    Friend WithEvents lblRevisionCerrada As System.Windows.Forms.Label
    Friend WithEvents tstImprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents RevisionComparativaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevisiónComparativaClinicaPacienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstImprmirSeguimientoPaciente As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btAbriImagen As System.Windows.Forms.Button
    Friend WithEvents btLoadImage As System.Windows.Forms.Button
    Friend WithEvents btDeleteImage As System.Windows.Forms.Button
    Friend WithEvents tstImprimirSeguimientoClinica As System.Windows.Forms.ToolStripButton
End Class
