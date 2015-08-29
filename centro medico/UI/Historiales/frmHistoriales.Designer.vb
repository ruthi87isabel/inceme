<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoriales
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
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column20.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoriales))
        Dim GridEX1_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column21.ButtonImage")
        Dim GridEX1_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column4.ButtonImage")
        Dim GridEXHipoDiag_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXRecetas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXDiagnosticoAntecedente_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim InfoPrimariaGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.HISTORIALEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument()
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab()
        Me.txtDiagnoPrincipalDescrip = New System.Windows.Forms.TextBox()
        Me.txtDiagnoPrincipalCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridEXHipoDiag = New Janus.Windows.GridEX.GridEX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridEXRecetas = New Janus.Windows.GridEX.GridEX()
        Me.GridEXDiagnosticoAntecedente = New Janus.Windows.GridEX.GridEX()
        Me.InfoPrimariaGridEX = New Janus.Windows.GridEX.GridEX()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.tab1_PruebasComplemen = New Janus.Windows.UI.Tab.UITabPage()
        Me.tb_haPruebaComp = New centro_medico.ctrlTextboxAvanzado()
        Me.tab3_HipotesisDiagnostica = New Janus.Windows.UI.Tab.UITabPage()
        Me.tb_haHipDiagnostica = New centro_medico.ctrlTextboxAvanzado()
        Me.tab3_Tratamiento = New Janus.Windows.UI.Tab.UITabPage()
        Me.txtRecetaSelecDescripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_haTratamiento = New centro_medico.ctrlTextboxAvanzado()
        Me.tab4_MotivoConsulta = New Janus.Windows.UI.Tab.UITabPage()
        Me.tb_haMotivoCons = New centro_medico.ctrlTextboxAvanzado()
        Me.tab5_Antecedentes = New Janus.Windows.UI.Tab.UITabPage()
        Me.tb_haAntecedentes = New centro_medico.ctrlTextboxAvanzado()
        Me.tab7_Exploracion = New Janus.Windows.UI.Tab.UITabPage()
        Me.tb_haExploracion = New centro_medico.ctrlTextboxAvanzado()
        Me.tab0_NotasFinales = New Janus.Windows.UI.Tab.UITabPage()
        Me.tb_haNotasfinal = New centro_medico.ctrlTextboxAvanzado()
        Me.tab6_Historial = New Janus.Windows.UI.Tab.UITabPage()
        Me.tb_haHistorial = New centro_medico.ctrlTextboxAvanzado()
        Me.tab8_OtrasObservaciones = New Janus.Windows.UI.Tab.UITabPage()
        Me.tb_haOtrasObserv = New centro_medico.ctrlTextboxAvanzado()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HISTORIALEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        CType(Me.GridEXHipoDiag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXDiagnosticoAntecedente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoPrimariaGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1_PruebasComplemen.SuspendLayout()
        Me.tab3_HipotesisDiagnostica.SuspendLayout()
        Me.tab3_Tratamiento.SuspendLayout()
        Me.tab4_MotivoConsulta.SuspendLayout()
        Me.tab5_Antecedentes.SuspendLayout()
        Me.tab7_Exploracion.SuspendLayout()
        Me.tab0_NotasFinales.SuspendLayout()
        Me.tab6_Historial.SuspendLayout()
        Me.tab8_OtrasObservaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "re una columna aquí para reagrupar</GroupByBoxInfo></LocalizableData>"
        Me.GridEX1.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEX1.ControlStyle.HoverBaseColor = System.Drawing.Color.Silver
        Me.GridEX1.DataSource = Me.HISTORIALEBindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"), Object)
        GridEX1_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_2.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0, GridEX1_DesignTimeLayout_Reference_1, GridEX1_DesignTimeLayout_Reference_2})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.EditorsControlStyle.HoverBaseColor = System.Drawing.Color.Silver
        Me.GridEX1.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridEX1.FocusCellFormatStyle.BackColor = System.Drawing.Color.Silver
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GridLines = Janus.Windows.GridEX.GridLines.RowOutline
        Me.GridEX1.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.GridEX1.GroupByBoxFormatStyle.BackColorGradient = System.Drawing.Color.Gainsboro
        Me.GridEX1.GroupByBoxFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Horizontal
        Me.GridEX1.GroupRowFormatStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridEX1.GroupRowFormatStyle.BackColorGradient = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GridEX1.GroupRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Horizontal
        Me.GridEX1.GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEX1.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GridEX1.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(2, 29)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.GridEX1.SelectedFormatStyle.BackColorGradient = System.Drawing.Color.Gainsboro
        Me.GridEX1.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GridEX1.SelectedInactiveFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight
        Me.GridEX1.Size = New System.Drawing.Size(495, 427)
        Me.GridEX1.TabIndex = 221
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'HISTORIALEBindingSource
        '
        Me.HISTORIALEBindingSource.DataSource = GetType(centro_medico.HISTORIALE)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 224
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstNuevo
        '
        Me.tstNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNuevo.Name = "tstNuevo"
        Me.tstNuevo.Size = New System.Drawing.Size(58, 22)
        Me.tstNuevo.Text = "&Añadir"
        Me.tstNuevo.ToolTipText = "Nuevo"
        '
        'tst_Editar
        '
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(70, 22)
        Me.tst_Editar.Text = "&Modificar"
        Me.tst_Editar.ToolTipText = "Editar"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(63, 22)
        Me.tst_Eliminar.Text = "&Eliminar"
        Me.tst_Eliminar.ToolTipText = "Borrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.centro_medico.My.Resources.Resources.diente
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton1.Text = "Dental"
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
        Me.tlbImprimir.Size = New System.Drawing.Size(65, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'UiTab1
        '
        Me.UiTab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiTab1.Location = New System.Drawing.Point(503, 28)
        Me.UiTab1.MultiLine = True
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.ShowFocusRectangle = False
        Me.UiTab1.Size = New System.Drawing.Size(493, 428)
        Me.UiTab1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.UiTab1.TabIndex = 225
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tab1_PruebasComplemen, Me.tab3_HipotesisDiagnostica, Me.tab3_Tratamiento, Me.tab4_MotivoConsulta, Me.tab5_Antecedentes, Me.tab7_Exploracion, Me.tab0_NotasFinales, Me.tab6_Historial, Me.tab8_OtrasObservaciones})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal
        '
        'txtDiagnoPrincipalDescrip
        '
        Me.txtDiagnoPrincipalDescrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiagnoPrincipalDescrip.Location = New System.Drawing.Point(141, 10)
        Me.txtDiagnoPrincipalDescrip.Name = "txtDiagnoPrincipalDescrip"
        Me.txtDiagnoPrincipalDescrip.ReadOnly = True
        Me.txtDiagnoPrincipalDescrip.Size = New System.Drawing.Size(431, 20)
        Me.txtDiagnoPrincipalDescrip.TabIndex = 238
        '
        'txtDiagnoPrincipalCod
        '
        Me.txtDiagnoPrincipalCod.Location = New System.Drawing.Point(74, 10)
        Me.txtDiagnoPrincipalCod.Name = "txtDiagnoPrincipalCod"
        Me.txtDiagnoPrincipalCod.ReadOnly = True
        Me.txtDiagnoPrincipalCod.Size = New System.Drawing.Size(64, 20)
        Me.txtDiagnoPrincipalCod.TabIndex = 238
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 237
        Me.Label1.Text = "Diagnóstico"
        '
        'GridEXHipoDiag
        '
        Me.GridEXHipoDiag.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXHipoDiag.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXHipoDiag.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEXHipoDiag.ColumnAutoResize = True
        GridEXHipoDiag_DesignTimeLayout.LayoutString = resources.GetString("GridEXHipoDiag_DesignTimeLayout.LayoutString")
        Me.GridEXHipoDiag.DesignTimeLayout = GridEXHipoDiag_DesignTimeLayout
        Me.GridEXHipoDiag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXHipoDiag.GroupByBoxVisible = False
        Me.GridEXHipoDiag.Location = New System.Drawing.Point(8, 41)
        Me.GridEXHipoDiag.Name = "GridEXHipoDiag"
        Me.GridEXHipoDiag.Size = New System.Drawing.Size(564, 243)
        Me.GridEXHipoDiag.TabIndex = 235
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(3, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 241
        Me.Label3.Text = "Notas:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 241
        Me.Label2.Text = "Tratamiento seleccionado:"
        '
        'GridEXRecetas
        '
        Me.GridEXRecetas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXRecetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXRecetas.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEXRecetas.ColumnAutoResize = True
        GridEXRecetas_DesignTimeLayout.LayoutString = resources.GetString("GridEXRecetas_DesignTimeLayout.LayoutString")
        Me.GridEXRecetas.DesignTimeLayout = GridEXRecetas_DesignTimeLayout
        Me.GridEXRecetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXRecetas.GroupByBoxVisible = False
        Me.GridEXRecetas.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXRecetas.Location = New System.Drawing.Point(6, 15)
        Me.GridEXRecetas.Name = "GridEXRecetas"
        Me.GridEXRecetas.Size = New System.Drawing.Size(566, 138)
        Me.GridEXRecetas.TabIndex = 232
        '
        'GridEXDiagnosticoAntecedente
        '
        Me.GridEXDiagnosticoAntecedente.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDiagnosticoAntecedente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXDiagnosticoAntecedente.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEXDiagnosticoAntecedente.ColumnAutoResize = True
        GridEXDiagnosticoAntecedente_DesignTimeLayout.LayoutString = resources.GetString("GridEXDiagnosticoAntecedente_DesignTimeLayout.LayoutString")
        Me.GridEXDiagnosticoAntecedente.DesignTimeLayout = GridEXDiagnosticoAntecedente_DesignTimeLayout
        Me.GridEXDiagnosticoAntecedente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXDiagnosticoAntecedente.GroupByBoxVisible = False
        Me.GridEXDiagnosticoAntecedente.Location = New System.Drawing.Point(268, 13)
        Me.GridEXDiagnosticoAntecedente.Name = "GridEXDiagnosticoAntecedente"
        Me.GridEXDiagnosticoAntecedente.Size = New System.Drawing.Size(303, 227)
        Me.GridEXDiagnosticoAntecedente.TabIndex = 239
        '
        'InfoPrimariaGridEX
        '
        Me.InfoPrimariaGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.InfoPrimariaGridEX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InfoPrimariaGridEX.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.InfoPrimariaGridEX.ColumnAutoResize = True
        InfoPrimariaGridEX_DesignTimeLayout.LayoutString = resources.GetString("InfoPrimariaGridEX_DesignTimeLayout.LayoutString")
        Me.InfoPrimariaGridEX.DesignTimeLayout = InfoPrimariaGridEX_DesignTimeLayout
        Me.InfoPrimariaGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.InfoPrimariaGridEX.GroupByBoxVisible = False
        Me.InfoPrimariaGridEX.Location = New System.Drawing.Point(11, 13)
        Me.InfoPrimariaGridEX.Name = "InfoPrimariaGridEX"
        Me.InfoPrimariaGridEX.Size = New System.Drawing.Size(251, 227)
        Me.InfoPrimariaGridEX.TabIndex = 238
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTipo.Location = New System.Drawing.Point(684, 6)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(87, 16)
        Me.lblTipo.TabIndex = 226
        Me.lblTipo.Text = "HISTORIAL"
        '
        'tab1_PruebasComplemen
        '
        Me.tab1_PruebasComplemen.Controls.Add(Me.tb_haPruebaComp)
        Me.tab1_PruebasComplemen.Location = New System.Drawing.Point(2, 40)
        Me.tab1_PruebasComplemen.Name = "tab1_PruebasComplemen"
        Me.tab1_PruebasComplemen.Size = New System.Drawing.Size(489, 386)
        Me.tab1_PruebasComplemen.TabStop = True
        Me.tab1_PruebasComplemen.Text = "Prueba Complementarias"
        '
        'tb_haPruebaComp
        '
        Me.tb_haPruebaComp.AcceptsReturn = True
        Me.tb_haPruebaComp.BackColor = System.Drawing.Color.White
        Me.tb_haPruebaComp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_haPruebaComp.Location = New System.Drawing.Point(0, 0)
        Me.tb_haPruebaComp.Multiline = True
        Me.tb_haPruebaComp.Name = "tb_haPruebaComp"
        Me.tb_haPruebaComp.ReadOnly = True
        Me.tb_haPruebaComp.Size = New System.Drawing.Size(489, 386)
        Me.tb_haPruebaComp.TabIndex = 2
        '
        'tab3_HipotesisDiagnostica
        '
        Me.tab3_HipotesisDiagnostica.Controls.Add(Me.txtDiagnoPrincipalDescrip)
        Me.tab3_HipotesisDiagnostica.Controls.Add(Me.txtDiagnoPrincipalCod)
        Me.tab3_HipotesisDiagnostica.Controls.Add(Me.Label1)
        Me.tab3_HipotesisDiagnostica.Controls.Add(Me.GridEXHipoDiag)
        Me.tab3_HipotesisDiagnostica.Controls.Add(Me.tb_haHipDiagnostica)
        Me.tab3_HipotesisDiagnostica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3_HipotesisDiagnostica.Location = New System.Drawing.Point(1, 39)
        Me.tab3_HipotesisDiagnostica.Name = "tab3_HipotesisDiagnostica"
        Me.tab3_HipotesisDiagnostica.Size = New System.Drawing.Size(580, 386)
        Me.tab3_HipotesisDiagnostica.TabStop = True
        Me.tab3_HipotesisDiagnostica.Text = "Hipotesis Diagnostica"
        '
        'tb_haHipDiagnostica
        '
        Me.tb_haHipDiagnostica.AcceptsReturn = True
        Me.tb_haHipDiagnostica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_haHipDiagnostica.BackColor = System.Drawing.Color.White
        Me.tb_haHipDiagnostica.Location = New System.Drawing.Point(8, 290)
        Me.tb_haHipDiagnostica.Multiline = True
        Me.tb_haHipDiagnostica.Name = "tb_haHipDiagnostica"
        Me.tb_haHipDiagnostica.ReadOnly = True
        Me.tb_haHipDiagnostica.Size = New System.Drawing.Size(564, 91)
        Me.tb_haHipDiagnostica.TabIndex = 3
        '
        'tab3_Tratamiento
        '
        Me.tab3_Tratamiento.Controls.Add(Me.Label3)
        Me.tab3_Tratamiento.Controls.Add(Me.Label2)
        Me.tab3_Tratamiento.Controls.Add(Me.txtRecetaSelecDescripcion)
        Me.tab3_Tratamiento.Controls.Add(Me.GridEXRecetas)
        Me.tab3_Tratamiento.Controls.Add(Me.tb_haTratamiento)
        Me.tab3_Tratamiento.Location = New System.Drawing.Point(1, 39)
        Me.tab3_Tratamiento.Name = "tab3_Tratamiento"
        Me.tab3_Tratamiento.Size = New System.Drawing.Size(580, 386)
        Me.tab3_Tratamiento.TabStop = True
        Me.tab3_Tratamiento.Text = "Tratamiento"
        '
        'txtRecetaSelecDescripcion
        '
        Me.txtRecetaSelecDescripcion.AcceptsReturn = True
        Me.txtRecetaSelecDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecetaSelecDescripcion.Location = New System.Drawing.Point(6, 179)
        Me.txtRecetaSelecDescripcion.Multiline = True
        Me.txtRecetaSelecDescripcion.Name = "txtRecetaSelecDescripcion"
        Me.txtRecetaSelecDescripcion.ReadOnly = True
        Me.txtRecetaSelecDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRecetaSelecDescripcion.Size = New System.Drawing.Size(566, 75)
        Me.txtRecetaSelecDescripcion.TabIndex = 240
        Me.txtRecetaSelecDescripcion.TabStop = False
        '
        'tb_haTratamiento
        '
        Me.tb_haTratamiento.AcceptsReturn = True
        Me.tb_haTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_haTratamiento.BackColor = System.Drawing.SystemColors.Control
        Me.tb_haTratamiento.Location = New System.Drawing.Point(6, 282)
        Me.tb_haTratamiento.Multiline = True
        Me.tb_haTratamiento.Name = "tb_haTratamiento"
        Me.tb_haTratamiento.ReadOnly = True
        Me.tb_haTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tb_haTratamiento.Size = New System.Drawing.Size(566, 99)
        Me.tb_haTratamiento.TabIndex = 4
        '
        'tab4_MotivoConsulta
        '
        Me.tab4_MotivoConsulta.Controls.Add(Me.tb_haMotivoCons)
        Me.tab4_MotivoConsulta.Location = New System.Drawing.Point(1, 39)
        Me.tab4_MotivoConsulta.Name = "tab4_MotivoConsulta"
        Me.tab4_MotivoConsulta.Size = New System.Drawing.Size(580, 386)
        Me.tab4_MotivoConsulta.TabStop = True
        Me.tab4_MotivoConsulta.Text = "Motivo Consulta"
        '
        'tb_haMotivoCons
        '
        Me.tb_haMotivoCons.AcceptsReturn = True
        Me.tb_haMotivoCons.BackColor = System.Drawing.Color.White
        Me.tb_haMotivoCons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_haMotivoCons.Location = New System.Drawing.Point(0, 0)
        Me.tb_haMotivoCons.Multiline = True
        Me.tb_haMotivoCons.Name = "tb_haMotivoCons"
        Me.tb_haMotivoCons.ReadOnly = True
        Me.tb_haMotivoCons.Size = New System.Drawing.Size(580, 386)
        Me.tb_haMotivoCons.TabIndex = 1
        '
        'tab5_Antecedentes
        '
        Me.tab5_Antecedentes.Controls.Add(Me.GridEXDiagnosticoAntecedente)
        Me.tab5_Antecedentes.Controls.Add(Me.InfoPrimariaGridEX)
        Me.tab5_Antecedentes.Controls.Add(Me.tb_haAntecedentes)
        Me.tab5_Antecedentes.Location = New System.Drawing.Point(1, 39)
        Me.tab5_Antecedentes.Name = "tab5_Antecedentes"
        Me.tab5_Antecedentes.Size = New System.Drawing.Size(580, 386)
        Me.tab5_Antecedentes.TabStop = True
        Me.tab5_Antecedentes.Text = "Antecedentes"
        '
        'tb_haAntecedentes
        '
        Me.tb_haAntecedentes.AcceptsReturn = True
        Me.tb_haAntecedentes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_haAntecedentes.BackColor = System.Drawing.Color.White
        Me.tb_haAntecedentes.Location = New System.Drawing.Point(11, 258)
        Me.tb_haAntecedentes.Multiline = True
        Me.tb_haAntecedentes.Name = "tb_haAntecedentes"
        Me.tb_haAntecedentes.ReadOnly = True
        Me.tb_haAntecedentes.Size = New System.Drawing.Size(560, 128)
        Me.tb_haAntecedentes.TabIndex = 2
        '
        'tab7_Exploracion
        '
        Me.tab7_Exploracion.Controls.Add(Me.tb_haExploracion)
        Me.tab7_Exploracion.Location = New System.Drawing.Point(1, 39)
        Me.tab7_Exploracion.Name = "tab7_Exploracion"
        Me.tab7_Exploracion.Size = New System.Drawing.Size(489, 386)
        Me.tab7_Exploracion.TabStop = True
        Me.tab7_Exploracion.Text = "Exploración"
        '
        'tb_haExploracion
        '
        Me.tb_haExploracion.AcceptsReturn = True
        Me.tb_haExploracion.BackColor = System.Drawing.Color.White
        Me.tb_haExploracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_haExploracion.Location = New System.Drawing.Point(0, 0)
        Me.tb_haExploracion.Multiline = True
        Me.tb_haExploracion.Name = "tb_haExploracion"
        Me.tb_haExploracion.ReadOnly = True
        Me.tb_haExploracion.Size = New System.Drawing.Size(489, 386)
        Me.tb_haExploracion.TabIndex = 4
        '
        'tab0_NotasFinales
        '
        Me.tab0_NotasFinales.Controls.Add(Me.tb_haNotasfinal)
        Me.tab0_NotasFinales.Location = New System.Drawing.Point(1, 39)
        Me.tab0_NotasFinales.Name = "tab0_NotasFinales"
        Me.tab0_NotasFinales.Size = New System.Drawing.Size(535, 386)
        Me.tab0_NotasFinales.TabStop = True
        Me.tab0_NotasFinales.Text = "Notas Finales"
        '
        'tb_haNotasfinal
        '
        Me.tb_haNotasfinal.AcceptsReturn = True
        Me.tb_haNotasfinal.BackColor = System.Drawing.SystemColors.Control
        Me.tb_haNotasfinal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_haNotasfinal.Location = New System.Drawing.Point(0, 0)
        Me.tb_haNotasfinal.Multiline = True
        Me.tb_haNotasfinal.Name = "tb_haNotasfinal"
        Me.tb_haNotasfinal.ReadOnly = True
        Me.tb_haNotasfinal.Size = New System.Drawing.Size(535, 386)
        Me.tb_haNotasfinal.TabIndex = 4
        '
        'tab6_Historial
        '
        Me.tab6_Historial.Controls.Add(Me.tb_haHistorial)
        Me.tab6_Historial.Location = New System.Drawing.Point(1, 39)
        Me.tab6_Historial.Name = "tab6_Historial"
        Me.tab6_Historial.Size = New System.Drawing.Size(580, 386)
        Me.tab6_Historial.TabStop = True
        Me.tab6_Historial.Text = "Historial"
        '
        'tb_haHistorial
        '
        Me.tb_haHistorial.AcceptsReturn = True
        Me.tb_haHistorial.BackColor = System.Drawing.Color.White
        Me.tb_haHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_haHistorial.Location = New System.Drawing.Point(0, 0)
        Me.tb_haHistorial.Multiline = True
        Me.tb_haHistorial.Name = "tb_haHistorial"
        Me.tb_haHistorial.ReadOnly = True
        Me.tb_haHistorial.Size = New System.Drawing.Size(580, 386)
        Me.tb_haHistorial.TabIndex = 3
        '
        'tab8_OtrasObservaciones
        '
        Me.tab8_OtrasObservaciones.Controls.Add(Me.tb_haOtrasObserv)
        Me.tab8_OtrasObservaciones.Location = New System.Drawing.Point(1, 39)
        Me.tab8_OtrasObservaciones.Name = "tab8_OtrasObservaciones"
        Me.tab8_OtrasObservaciones.Size = New System.Drawing.Size(580, 397)
        Me.tab8_OtrasObservaciones.TabStop = True
        Me.tab8_OtrasObservaciones.Text = "Otras Observaciones"
        '
        'tb_haOtrasObserv
        '
        Me.tb_haOtrasObserv.AcceptsReturn = True
        Me.tb_haOtrasObserv.BackColor = System.Drawing.SystemColors.Control
        Me.tb_haOtrasObserv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_haOtrasObserv.Location = New System.Drawing.Point(0, 0)
        Me.tb_haOtrasObserv.Multiline = True
        Me.tb_haOtrasObserv.Name = "tb_haOtrasObserv"
        Me.tb_haOtrasObserv.ReadOnly = True
        Me.tb_haOtrasObserv.Size = New System.Drawing.Size(580, 397)
        Me.tb_haOtrasObserv.TabIndex = 3
        '
        'frmHistoriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 460)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.UiTab1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "frmHistoriales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historiales"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HISTORIALEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        CType(Me.GridEXHipoDiag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXDiagnosticoAntecedente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoPrimariaGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab1_PruebasComplemen.ResumeLayout(False)
        Me.tab1_PruebasComplemen.PerformLayout()
        Me.tab3_HipotesisDiagnostica.ResumeLayout(False)
        Me.tab3_HipotesisDiagnostica.PerformLayout()
        Me.tab3_Tratamiento.ResumeLayout(False)
        Me.tab3_Tratamiento.PerformLayout()
        Me.tab4_MotivoConsulta.ResumeLayout(False)
        Me.tab4_MotivoConsulta.PerformLayout()
        Me.tab5_Antecedentes.ResumeLayout(False)
        Me.tab5_Antecedentes.PerformLayout()
        Me.tab7_Exploracion.ResumeLayout(False)
        Me.tab7_Exploracion.PerformLayout()
        Me.tab0_NotasFinales.ResumeLayout(False)
        Me.tab0_NotasFinales.PerformLayout()
        Me.tab6_Historial.ResumeLayout(False)
        Me.tab6_Historial.PerformLayout()
        Me.tab8_OtrasObservaciones.ResumeLayout(False)
        Me.tab8_OtrasObservaciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents HISTORIALEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents tab1_PruebasComplemen As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tb_haPruebaComp As ctrlTextboxAvanzado
    Friend WithEvents tab3_HipotesisDiagnostica As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tb_haHipDiagnostica As ctrlTextboxAvanzado
    Friend WithEvents tab3_Tratamiento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tb_haTratamiento As ctrlTextboxAvanzado
    Friend WithEvents tab4_MotivoConsulta As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tb_haMotivoCons As ctrlTextboxAvanzado
    Friend WithEvents tab5_Antecedentes As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tab7_Exploracion As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tb_haExploracion As ctrlTextboxAvanzado
    Friend WithEvents tab0_NotasFinales As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tb_haNotasfinal As ctrlTextboxAvanzado
    Friend WithEvents tab6_Historial As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tb_haHistorial As ctrlTextboxAvanzado
    Friend WithEvents tab8_OtrasObservaciones As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tb_haOtrasObserv As ctrlTextboxAvanzado
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents GridEXDiagnosticoAntecedente As Janus.Windows.GridEX.GridEX
    Friend WithEvents InfoPrimariaGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents tb_haAntecedentes As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents txtDiagnoPrincipalDescrip As System.Windows.Forms.TextBox
    Friend WithEvents txtDiagnoPrincipalCod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridEXHipoDiag As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEXRecetas As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtRecetaSelecDescripcion As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
