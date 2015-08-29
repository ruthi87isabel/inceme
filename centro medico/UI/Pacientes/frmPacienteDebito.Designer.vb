<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacienteDebito
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
        Dim GridEXDocs_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPacienteDebito))
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX2_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column10.ButtonImage")
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSeleccionados = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDebe = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_Final = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.GridEXDocs = New Janus.Windows.GridEX.GridEX()
        Me.PACIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.PagosPacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_ADD = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnPagoAutomatico = New System.Windows.Forms.Button()
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX()
        Me.EntregasCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenDePagosYEntregasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JustificanteDeEntregaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridEXDocs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosPacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntregasCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.lblSaldo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblSeleccionados)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblDebe)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_Final)
        Me.GroupBox1.Controls.Add(Me.dtp_Inicio)
        Me.GroupBox1.Controls.Add(Me.CtrlPaciente1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(998, 102)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lblSaldo
        '
        Me.lblSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.Color.Green
        Me.lblSaldo.Location = New System.Drawing.Point(856, 47)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(93, 20)
        Me.lblSaldo.TabIndex = 8
        Me.lblSaldo.Text = "0.00"
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(750, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "SELECCIONADO:"
        '
        'lblSeleccionados
        '
        Me.lblSeleccionados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionados.Location = New System.Drawing.Point(859, 71)
        Me.lblSeleccionados.Name = "lblSeleccionados"
        Me.lblSeleccionados.Size = New System.Drawing.Size(87, 20)
        Me.lblSeleccionados.TabIndex = 17
        Me.lblSeleccionados.Text = "0.00"
        Me.lblSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(759, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CREDITO:"
        '
        'lblDebe
        '
        Me.lblDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebe.ForeColor = System.Drawing.Color.Red
        Me.lblDebe.Location = New System.Drawing.Point(856, 23)
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
        Me.Label3.Location = New System.Drawing.Point(790, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DEBE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha Inicio:"
        '
        'dtp_Final
        '
        Me.dtp_Final.Checked = False
        Me.dtp_Final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Final.Location = New System.Drawing.Point(314, 73)
        Me.dtp_Final.Name = "dtp_Final"
        Me.dtp_Final.ShowCheckBox = True
        Me.dtp_Final.Size = New System.Drawing.Size(110, 20)
        Me.dtp_Final.TabIndex = 6
        '
        'dtp_Inicio
        '
        Me.dtp_Inicio.Checked = False
        Me.dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Inicio.Location = New System.Drawing.Point(124, 73)
        Me.dtp_Inicio.Name = "dtp_Inicio"
        Me.dtp_Inicio.ShowCheckBox = True
        Me.dtp_Inicio.Size = New System.Drawing.Size(102, 20)
        Me.dtp_Inicio.TabIndex = 6
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(6, 12)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(482, 55)
        Me.CtrlPaciente1.TabIndex = 1
        '
        'GridEXDocs
        '
        Me.GridEXDocs.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDocs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXDocs.DataSource = Me.PACIENTEBindingSource
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
        Me.GridEXDocs.ImageList = Me.ImageList1
        Me.GridEXDocs.Location = New System.Drawing.Point(-3, 5)
        Me.GridEXDocs.Name = "GridEXDocs"
        Me.GridEXDocs.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEXDocs.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXDocs.Size = New System.Drawing.Size(564, 518)
        Me.GridEXDocs.TabIndex = 0
        Me.GridEXDocs.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridEXDocs.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridEXDocs.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEXDocs.TotalRowFormatStyle.FontSize = 9.0!
        Me.GridEXDocs.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEXDocs.TreeLines = False
        '
        'PACIENTEBindingSource
        '
        Me.PACIENTEBindingSource.DataSource = GetType(centro_medico.PACIENTE)
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
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.DataSource = Me.PagosPacientesBindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(3, 6)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(419, 269)
        Me.GridEX1.TabIndex = 15
        Me.GridEX1.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'PagosPacientesBindingSource
        '
        Me.PagosPacientesBindingSource.DataMember = "PagosPacientes"
        Me.PagosPacientesBindingSource.DataSource = Me.PACIENTEBindingSource
        '
        'btn_ADD
        '
        Me.btn_ADD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_ADD.FlatAppearance.BorderSize = 0
        Me.btn_ADD.Image = Global.centro_medico.My.Resources.Resources.Dollar_Sign
        Me.btn_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ADD.Location = New System.Drawing.Point(880, 133)
        Me.btn_ADD.Name = "btn_ADD"
        Me.btn_ADD.Size = New System.Drawing.Size(116, 28)
        Me.btn_ADD.TabIndex = 16
        Me.btn_ADD.Text = "Agregar Crédito"
        Me.btn_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ADD.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.FlatAppearance.BorderSize = 0
        Me.btnPagar.Image = Global.centro_medico.My.Resources.Resources.euro16x16
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.Location = New System.Drawing.Point(2, 135)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(131, 26)
        Me.btnPagar.TabIndex = 16
        Me.btnPagar.Text = "Pagar Seleccionados"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(139, 143)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(273, 13)
        Me.lblMessage.TabIndex = 18
        Me.lblMessage.Text = "No tiene suficiente crédito para los docs seleccionados. "
        Me.lblMessage.Visible = False
        '
        'btnPagoAutomatico
        '
        Me.btnPagoAutomatico.Enabled = False
        Me.btnPagoAutomatico.FlatAppearance.BorderSize = 0
        Me.btnPagoAutomatico.Image = Global.centro_medico.My.Resources.Resources.euro16x16
        Me.btnPagoAutomatico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagoAutomatico.Location = New System.Drawing.Point(177, 137)
        Me.btnPagoAutomatico.Name = "btnPagoAutomatico"
        Me.btnPagoAutomatico.Size = New System.Drawing.Size(115, 24)
        Me.btnPagoAutomatico.TabIndex = 16
        Me.btnPagoAutomatico.Text = "Pago Automático"
        Me.btnPagoAutomatico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagoAutomatico.UseVisualStyleBackColor = True
        Me.btnPagoAutomatico.Visible = False
        '
        'GridEX2
        '
        Me.GridEX2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX2.ColumnAutoResize = True
        Me.GridEX2.DataSource = Me.EntregasCuentasBindingSource
        GridEX2_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX2_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX2_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX2_DesignTimeLayout_Reference_0})
        GridEX2_DesignTimeLayout.LayoutString = resources.GetString("GridEX2_DesignTimeLayout.LayoutString")
        Me.GridEX2.DesignTimeLayout = GridEX2_DesignTimeLayout
        Me.GridEX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.Hierarchical = True
        Me.GridEX2.Location = New System.Drawing.Point(3, 278)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEX2.Size = New System.Drawing.Size(419, 243)
        Me.GridEX2.TabIndex = 15
        Me.GridEX2.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX2.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX2.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'EntregasCuentasBindingSource
        '
        Me.EntregasCuentasBindingSource.DataMember = "EntregasCuentas"
        Me.EntregasCuentasBindingSource.DataSource = Me.PACIENTEBindingSource
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumenDePagosYEntregasToolStripMenuItem, Me.JustificanteDeEntregaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ReportesToolStripMenuItem.Text = "Listados"
        '
        'ResumenDePagosYEntregasToolStripMenuItem
        '
        Me.ResumenDePagosYEntregasToolStripMenuItem.Name = "ResumenDePagosYEntregasToolStripMenuItem"
        Me.ResumenDePagosYEntregasToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ResumenDePagosYEntregasToolStripMenuItem.Text = "Resumen de Pagos y Entregas"
        '
        'JustificanteDeEntregaToolStripMenuItem
        '
        Me.JustificanteDeEntregaToolStripMenuItem.Name = "JustificanteDeEntregaToolStripMenuItem"
        Me.JustificanteDeEntregaToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.JustificanteDeEntregaToolStripMenuItem.Text = "Justificante de Entrega"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(42, 685)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(439, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Atención: Solo aparecerán las citas marcadas como Atendidas que no hayan sido cob" & _
    "radas"
        '
        'NFacturasBindingSource
        '
        Me.NFacturasBindingSource.DataMember = "N_Facturas"
        Me.NFacturasBindingSource.DataSource = Me.PACIENTEBindingSource
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 161)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridEXDocs)
        Me.SplitContainer1.Panel1MinSize = 100
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridEX1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridEX2)
        Me.SplitContainer1.Size = New System.Drawing.Size(993, 526)
        Me.SplitContainer1.SplitterDistance = 564
        Me.SplitContainer1.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(899, 686)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Pagado del Crédito"
        '
        'frmPacienteDebito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 699)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnPagoAutomatico)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.btn_ADD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPacienteDebito"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Débito Paciente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridEXDocs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosPacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntregasCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridEXDocs As Janus.Windows.GridEX.GridEX
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PACIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents btn_ADD As System.Windows.Forms.Button
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDebe As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSeleccionados As System.Windows.Forms.Label
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnPagoAutomatico As System.Windows.Forms.Button
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Public WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Private WithEvents dtp_Final As System.Windows.Forms.DateTimePicker
    Private WithEvents dtp_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenDePagosYEntregasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JustificanteDeEntregaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NFacturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosPacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EntregasCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
