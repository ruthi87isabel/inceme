<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacion_Medicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiquidacion_Medicos))
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column10.ButtonImage")
        Dim GridEXDocs_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.btnPagoAutomatico = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkMostrarCitasImporteCero = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_sincobrar = New System.Windows.Forms.RadioButton()
        Me.rb_cobradas = New System.Windows.Forms.RadioButton()
        Me.rb_todascobrar = New System.Windows.Forms.RadioButton()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.CtrlMedico1 = New centro_medico.ctrlMedico()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSeleccionados = New System.Windows.Forms.Label()
        Me.lblDebe = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_Final = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MEDICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.LiquidacionMedicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btImprimirMedicoDebito = New System.Windows.Forms.Button()
        Me.CITAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEXDocs = New Janus.Windows.GridEX.GridEX()
        Me.pnl_Loading = New System.Windows.Forms.Panel()
        Me.lbl_Loading = New System.Windows.Forms.Label()
        Me.pb_Loading = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MEDICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiquidacionMedicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXDocs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Loading.SuspendLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPagoAutomatico
        '
        Me.btnPagoAutomatico.Enabled = False
        Me.btnPagoAutomatico.FlatAppearance.BorderSize = 0
        Me.btnPagoAutomatico.Image = Global.centro_medico.My.Resources.Resources.euro16x16
        Me.btnPagoAutomatico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagoAutomatico.Location = New System.Drawing.Point(179, 137)
        Me.btnPagoAutomatico.Name = "btnPagoAutomatico"
        Me.btnPagoAutomatico.Size = New System.Drawing.Size(115, 24)
        Me.btnPagoAutomatico.TabIndex = 26
        Me.btnPagoAutomatico.Text = "Pago Automático"
        Me.btnPagoAutomatico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagoAutomatico.UseVisualStyleBackColor = True
        Me.btnPagoAutomatico.Visible = False
        '
        'btnPagar
        '
        Me.btnPagar.FlatAppearance.BorderSize = 0
        Me.btnPagar.Image = Global.centro_medico.My.Resources.Resources.euro16x16
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.Location = New System.Drawing.Point(4, 135)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(131, 26)
        Me.btnPagar.TabIndex = 25
        Me.btnPagar.Text = "Pagar Seleccionados"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.chkMostrarCitasImporteCero)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.CtrlMedico1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblSeleccionados)
        Me.GroupBox1.Controls.Add(Me.lblDebe)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_Final)
        Me.GroupBox1.Controls.Add(Me.dtp_Inicio)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1002, 102)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'chkMostrarCitasImporteCero
        '
        Me.chkMostrarCitasImporteCero.AutoSize = True
        Me.chkMostrarCitasImporteCero.Location = New System.Drawing.Point(366, 75)
        Me.chkMostrarCitasImporteCero.Name = "chkMostrarCitasImporteCero"
        Me.chkMostrarCitasImporteCero.Size = New System.Drawing.Size(132, 17)
        Me.chkMostrarCitasImporteCero.TabIndex = 119
        Me.chkMostrarCitasImporteCero.Text = "Mostrar citas importe 0"
        Me.chkMostrarCitasImporteCero.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_sincobrar)
        Me.GroupBox3.Controls.Add(Me.rb_cobradas)
        Me.GroupBox3.Controls.Add(Me.rb_todascobrar)
        Me.GroupBox3.Location = New System.Drawing.Point(516, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(97, 79)
        Me.GroupBox3.TabIndex = 118
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de cita"
        '
        'rb_sincobrar
        '
        Me.rb_sincobrar.AutoSize = True
        Me.rb_sincobrar.Location = New System.Drawing.Point(6, 57)
        Me.rb_sincobrar.Name = "rb_sincobrar"
        Me.rb_sincobrar.Size = New System.Drawing.Size(73, 17)
        Me.rb_sincobrar.TabIndex = 8
        Me.rb_sincobrar.Text = "Sin cobrar"
        Me.rb_sincobrar.UseVisualStyleBackColor = True
        '
        'rb_cobradas
        '
        Me.rb_cobradas.AutoSize = True
        Me.rb_cobradas.Checked = True
        Me.rb_cobradas.Location = New System.Drawing.Point(6, 37)
        Me.rb_cobradas.Name = "rb_cobradas"
        Me.rb_cobradas.Size = New System.Drawing.Size(70, 17)
        Me.rb_cobradas.TabIndex = 7
        Me.rb_cobradas.TabStop = True
        Me.rb_cobradas.Text = "Cobradas"
        Me.rb_cobradas.UseVisualStyleBackColor = True
        '
        'rb_todascobrar
        '
        Me.rb_todascobrar.AutoSize = True
        Me.rb_todascobrar.Location = New System.Drawing.Point(6, 16)
        Me.rb_todascobrar.Name = "rb_todascobrar"
        Me.rb_todascobrar.Size = New System.Drawing.Size(55, 17)
        Me.rb_todascobrar.TabIndex = 6
        Me.rb_todascobrar.Text = "Todas"
        Me.rb_todascobrar.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(639, 33)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(93, 51)
        Me.btnFiltrar.TabIndex = 19
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(17, 17)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(454, 42)
        Me.CtrlMedico1.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(790, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "SELECCIONADO:"
        '
        'lblSeleccionados
        '
        Me.lblSeleccionados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionados.Location = New System.Drawing.Point(899, 54)
        Me.lblSeleccionados.Name = "lblSeleccionados"
        Me.lblSeleccionados.Size = New System.Drawing.Size(87, 20)
        Me.lblSeleccionados.TabIndex = 17
        Me.lblSeleccionados.Text = "0.00"
        Me.lblSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDebe
        '
        Me.lblDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebe.ForeColor = System.Drawing.Color.Red
        Me.lblDebe.Location = New System.Drawing.Point(893, 23)
        Me.lblDebe.Name = "lblDebe"
        Me.lblDebe.Size = New System.Drawing.Size(93, 20)
        Me.lblDebe.TabIndex = 8
        Me.lblDebe.Text = "0.00"
        Me.lblDebe.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(768, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SE LE DEBE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Inicio:"
        '
        'dtp_Final
        '
        Me.dtp_Final.Checked = False
        Me.dtp_Final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Final.Location = New System.Drawing.Point(218, 74)
        Me.dtp_Final.Name = "dtp_Final"
        Me.dtp_Final.Size = New System.Drawing.Size(110, 20)
        Me.dtp_Final.TabIndex = 6
        '
        'dtp_Inicio
        '
        Me.dtp_Inicio.Checked = False
        Me.dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Inicio.Location = New System.Drawing.Point(55, 74)
        Me.dtp_Inicio.Name = "dtp_Inicio"
        Me.dtp_Inicio.Size = New System.Drawing.Size(102, 20)
        Me.dtp_Inicio.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(43, 642)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(445, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Atención: Solo aparecerán las citas cofirmadas y atendidas, que contengan lineas " & _
    "sin liquidar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1013, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Citas.ico")
        Me.ImageList1.Images.SetKeyName(1, "factura16x16.png")
        Me.ImageList1.Images.SetKeyName(2, "receipt16x16.png")
        Me.ImageList1.Images.SetKeyName(3, "ticket16x16.png")
        Me.ImageList1.Images.SetKeyName(4, "Box50closed32x321.gif")
        '
        'MEDICOBindingSource
        '
        Me.MEDICOBindingSource.DataSource = GetType(centro_medico.MEDICO)
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataSource = Me.LiquidacionMedicosBindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(581, 167)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(432, 460)
        Me.GridEX1.TabIndex = 31
        '
        'btImprimirMedicoDebito
        '
        Me.btImprimirMedicoDebito.FlatAppearance.BorderSize = 0
        Me.btImprimirMedicoDebito.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.btImprimirMedicoDebito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btImprimirMedicoDebito.Location = New System.Drawing.Point(480, 137)
        Me.btImprimirMedicoDebito.Name = "btImprimirMedicoDebito"
        Me.btImprimirMedicoDebito.Size = New System.Drawing.Size(81, 24)
        Me.btImprimirMedicoDebito.TabIndex = 26
        Me.btImprimirMedicoDebito.Text = "Imprimir"
        Me.btImprimirMedicoDebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btImprimirMedicoDebito.UseVisualStyleBackColor = True
        '
        'CITAsBindingSource
        '
        Me.CITAsBindingSource.DataMember = "CITAs"
        Me.CITAsBindingSource.DataSource = Me.MEDICOBindingSource
        '
        'GridEXDocs
        '
        Me.GridEXDocs.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDocs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXDocs.DataSource = Me.CITAsBindingSource
        GridEXDocs_DesignTimeLayout.LayoutString = resources.GetString("GridEXDocs_DesignTimeLayout.LayoutString")
        Me.GridEXDocs.DesignTimeLayout = GridEXDocs_DesignTimeLayout
        Me.GridEXDocs.ExpandableCards = False
        Me.GridEXDocs.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDocs.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridEXDocs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXDocs.GroupByBoxVisible = False
        Me.GridEXDocs.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GridEXDocs.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXDocs.Hierarchical = True
        Me.GridEXDocs.Location = New System.Drawing.Point(0, 167)
        Me.GridEXDocs.Name = "GridEXDocs"
        Me.GridEXDocs.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEXDocs.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXDocs.Size = New System.Drawing.Size(575, 460)
        Me.GridEXDocs.TabIndex = 21
        Me.GridEXDocs.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridEXDocs.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridEXDocs.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEXDocs.TotalRowFormatStyle.FontSize = 9.0!
        Me.GridEXDocs.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEXDocs.TreeLines = False
        '
        'pnl_Loading
        '
        Me.pnl_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Loading.Controls.Add(Me.lbl_Loading)
        Me.pnl_Loading.Controls.Add(Me.pb_Loading)
        Me.pnl_Loading.Location = New System.Drawing.Point(188, 295)
        Me.pnl_Loading.Name = "pnl_Loading"
        Me.pnl_Loading.Size = New System.Drawing.Size(133, 48)
        Me.pnl_Loading.TabIndex = 134
        Me.pnl_Loading.Visible = False
        '
        'lbl_Loading
        '
        Me.lbl_Loading.AutoSize = True
        Me.lbl_Loading.Location = New System.Drawing.Point(51, 15)
        Me.lbl_Loading.Name = "lbl_Loading"
        Me.lbl_Loading.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Loading.TabIndex = 119
        Me.lbl_Loading.Text = "Filtrando..."
        '
        'pb_Loading
        '
        Me.pb_Loading.Image = Global.centro_medico.My.Resources.Resources.ajax_loader
        Me.pb_Loading.Location = New System.Drawing.Point(5, 5)
        Me.pb_Loading.Name = "pb_Loading"
        Me.pb_Loading.Size = New System.Drawing.Size(40, 35)
        Me.pb_Loading.TabIndex = 118
        Me.pb_Loading.TabStop = False
        '
        'frmLiquidacion_Medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 677)
        Me.Controls.Add(Me.pnl_Loading)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.btImprimirMedicoDebito)
        Me.Controls.Add(Me.btnPagoAutomatico)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GridEXDocs)
        Me.Name = "frmLiquidacion_Medicos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidación a Médicos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MEDICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiquidacionMedicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXDocs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Loading.ResumeLayout(False)
        Me.pnl_Loading.PerformLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPagoAutomatico As System.Windows.Forms.Button
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSeleccionados As System.Windows.Forms.Label
    Friend WithEvents lblDebe As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents dtp_Final As System.Windows.Forms.DateTimePicker
    Private WithEvents dtp_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Friend WithEvents MEDICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents LiquidacionMedicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btImprimirMedicoDebito As System.Windows.Forms.Button
    Friend WithEvents CITAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridEXDocs As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_sincobrar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cobradas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todascobrar As System.Windows.Forms.RadioButton
    Friend WithEvents chkMostrarCitasImporteCero As System.Windows.Forms.CheckBox
    Friend WithEvents pnl_Loading As System.Windows.Forms.Panel
    Friend WithEvents lbl_Loading As System.Windows.Forms.Label
    Friend WithEvents pb_Loading As System.Windows.Forms.PictureBox
End Class
