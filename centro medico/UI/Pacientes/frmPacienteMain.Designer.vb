<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacienteMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPacienteMain))
        Me.NavigationBar1 = New Itchin.Winforms.Controls_F2.NavigationBar()
        Me.nbp_DatosAdministrativos = New Itchin.Winforms.Controls_F2.NavigationBarPane()
        Me.btn_PartesAsistencia = New System.Windows.Forms.Button()
        Me.bt_PartesBajaAlta = New System.Windows.Forms.Button()
        Me.bt_Recibos = New System.Windows.Forms.Button()
        Me.bt_ServiciosPeriodicos = New System.Windows.Forms.Button()
        Me.bt_FicherosMultimedia = New System.Windows.Forms.Button()
        Me.bt_FormaPago = New System.Windows.Forms.Button()
        Me.bt_Facturas = New System.Windows.Forms.Button()
        Me.bt_Citas = New System.Windows.Forms.Button()
        Me.bt_HistorialLaboral = New System.Windows.Forms.Button()
        Me.bt_DatosPersonales = New System.Windows.Forms.Button()
        Me.nbp_DatosMedicos = New Itchin.Winforms.Controls_F2.NavigationBarPane()
        Me.bt_RevComparativa = New System.Windows.Forms.Button()
        Me.bt_Analiticas = New System.Windows.Forms.Button()
        Me.bt_Recetas = New System.Windows.Forms.Button()
        Me.bt_Derivaciones = New System.Windows.Forms.Button()
        Me.bt_HistorialClinico = New System.Windows.Forms.Button()
        Me.bt_Antecedentes = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpDebito = New System.Windows.Forms.GroupBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDebe = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblAlarmas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PACIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New centro_medico.ctrlTextboxAvanzado()
        Me.TextBox2 = New centro_medico.ctrlTextboxAvanzado()
        Me.TextBox3 = New centro_medico.ctrlTextboxAvanzado()
        Me.TextBox7 = New centro_medico.ctrlTextboxAvanzado()
        Me.TextBox5 = New centro_medico.ctrlTextboxAvanzado()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEdad = New centro_medico.ctrlTextboxAvanzado()
        Me.lbl_TeclasAcceso = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CtrlStatusPaciente1 = New centro_medico.ctrlStatusPaciente()
        Me.NavigationBar1.SuspendLayout()
        Me.nbp_DatosAdministrativos.SuspendLayout()
        Me.nbp_DatosMedicos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpDebito.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavigationBar1
        '
        Me.NavigationBar1.AlphaSettings.HoverItemAlpha = 70
        Me.NavigationBar1.AlphaSettings.SelectedItemAlpha = 100
        Me.NavigationBar1.AlphaSettings.UnselectedItemAlpha = 70
        Me.NavigationBar1.AlphaSettings.UseAlphaSettings = False
        Me.NavigationBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NavigationBar1.Controls.Add(Me.nbp_DatosAdministrativos)
        Me.NavigationBar1.Controls.Add(Me.nbp_DatosMedicos)
        Me.NavigationBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.NavigationBar1.DesignTimeEdit = True
        Me.NavigationBar1.HeaderFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NavigationBar1.HeaderForeColor = System.Drawing.Color.White
        Me.NavigationBar1.HeaderTextalignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.NavigationBar1.Location = New System.Drawing.Point(1, 116)
        Me.NavigationBar1.Logo.Alpha = 50
        Me.NavigationBar1.Logo.DisplayLogo = True
        Me.NavigationBar1.Logo.Image = Nothing
        Me.NavigationBar1.LogoImagePosition = System.Drawing.ContentAlignment.BottomRight
        Me.NavigationBar1.Name = "NavigationBar1"
        Me.NavigationBar1.Panels.Add(Me.nbp_DatosAdministrativos)
        Me.NavigationBar1.Panels.Add(Me.nbp_DatosMedicos)
        Me.NavigationBar1.SelectedForecolor = System.Drawing.Color.Red
        Me.NavigationBar1.SelectedItem = Me.nbp_DatosAdministrativos
        Me.NavigationBar1.ShowAddRemoveMenu = True
        Me.NavigationBar1.ShowMenuButton = True
        Me.NavigationBar1.Size = New System.Drawing.Size(156, 516)
        Me.NavigationBar1.TabIndex = 24
        Me.NavigationBar1.Text = "NavigationBar1"
        Me.NavigationBar1.ThemeFormat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.HeaderColorOne = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.HeaderColorTwo = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.HotColorOne = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.HotColorTwo = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.NormalColorOne = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.NormalColorTwo = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.SelectedColorOne = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.SelectedColorTwo = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.SplitterBarColorOne = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.SplitterBarColorTwo = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NavigationBar1.ToolTipTimeOut = 5000
        Me.NavigationBar1.VisibleItems = 2
        '
        'nbp_DatosAdministrativos
        '
        Me.nbp_DatosAdministrativos.BackColor = System.Drawing.SystemColors.Control
        Me.nbp_DatosAdministrativos.Caption = "Datos Administrativos"
        Me.nbp_DatosAdministrativos.Controls.Add(Me.btn_PartesAsistencia)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_PartesBajaAlta)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_Recibos)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_ServiciosPeriodicos)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_FicherosMultimedia)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_FormaPago)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_Facturas)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_Citas)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_HistorialLaboral)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_DatosPersonales)
        Me.nbp_DatosAdministrativos.Hidden = False
        Me.nbp_DatosAdministrativos.Image = CType(resources.GetObject("nbp_DatosAdministrativos.Image"), System.Drawing.Image)
        Me.nbp_DatosAdministrativos.Location = New System.Drawing.Point(1, 26)
        Me.nbp_DatosAdministrativos.MainImagePosition = System.Drawing.ContentAlignment.MiddleLeft
        Me.nbp_DatosAdministrativos.Name = "nbp_DatosAdministrativos"
        Me.nbp_DatosAdministrativos.Selected = True
        Me.nbp_DatosAdministrativos.Size = New System.Drawing.Size(154, 390)
        Me.nbp_DatosAdministrativos.TabIndex = 0
        Me.nbp_DatosAdministrativos.TabStop = True
        Me.nbp_DatosAdministrativos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.nbp_DatosAdministrativos.TextPaddingOffset = New System.Drawing.Point(30, 0)
        '
        'btn_PartesAsistencia
        '
        Me.btn_PartesAsistencia.FlatAppearance.BorderSize = 0
        Me.btn_PartesAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PartesAsistencia.Image = Global.centro_medico.My.Resources.Resources.Documents_small
        Me.btn_PartesAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_PartesAsistencia.Location = New System.Drawing.Point(4, 342)
        Me.btn_PartesAsistencia.Name = "btn_PartesAsistencia"
        Me.btn_PartesAsistencia.Size = New System.Drawing.Size(142, 31)
        Me.btn_PartesAsistencia.TabIndex = 8
        Me.btn_PartesAsistencia.Text = "Partes Asistencia"
        Me.btn_PartesAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_PartesAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_PartesAsistencia.UseVisualStyleBackColor = True
        '
        'bt_PartesBajaAlta
        '
        Me.bt_PartesBajaAlta.FlatAppearance.BorderSize = 0
        Me.bt_PartesBajaAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_PartesBajaAlta.Image = Global.centro_medico.My.Resources.Resources.Documents_small
        Me.bt_PartesBajaAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_PartesBajaAlta.Location = New System.Drawing.Point(4, 305)
        Me.bt_PartesBajaAlta.Name = "bt_PartesBajaAlta"
        Me.bt_PartesBajaAlta.Size = New System.Drawing.Size(142, 31)
        Me.bt_PartesBajaAlta.TabIndex = 8
        Me.bt_PartesBajaAlta.Text = "Partes Baja/Alta"
        Me.bt_PartesBajaAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_PartesBajaAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_PartesBajaAlta.UseVisualStyleBackColor = True
        '
        'bt_Recibos
        '
        Me.bt_Recibos.FlatAppearance.BorderSize = 0
        Me.bt_Recibos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Recibos.Image = Global.centro_medico.My.Resources.Resources.Medical_Bills
        Me.bt_Recibos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Recibos.Location = New System.Drawing.Point(4, 266)
        Me.bt_Recibos.Name = "bt_Recibos"
        Me.bt_Recibos.Size = New System.Drawing.Size(142, 31)
        Me.bt_Recibos.TabIndex = 7
        Me.bt_Recibos.Text = "Recibos"
        Me.bt_Recibos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Recibos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Recibos.UseVisualStyleBackColor = True
        '
        'bt_ServiciosPeriodicos
        '
        Me.bt_ServiciosPeriodicos.FlatAppearance.BorderSize = 0
        Me.bt_ServiciosPeriodicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ServiciosPeriodicos.Image = Global.centro_medico.My.Resources.Resources.clock
        Me.bt_ServiciosPeriodicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_ServiciosPeriodicos.Location = New System.Drawing.Point(4, 228)
        Me.bt_ServiciosPeriodicos.Name = "bt_ServiciosPeriodicos"
        Me.bt_ServiciosPeriodicos.Size = New System.Drawing.Size(142, 31)
        Me.bt_ServiciosPeriodicos.TabIndex = 6
        Me.bt_ServiciosPeriodicos.Text = "Svr Periódicos"
        Me.bt_ServiciosPeriodicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_ServiciosPeriodicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_ServiciosPeriodicos.UseVisualStyleBackColor = True
        '
        'bt_FicherosMultimedia
        '
        Me.bt_FicherosMultimedia.FlatAppearance.BorderSize = 0
        Me.bt_FicherosMultimedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_FicherosMultimedia.Image = Global.centro_medico.My.Resources.Resources._24_book_blue
        Me.bt_FicherosMultimedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_FicherosMultimedia.Location = New System.Drawing.Point(4, 191)
        Me.bt_FicherosMultimedia.Name = "bt_FicherosMultimedia"
        Me.bt_FicherosMultimedia.Size = New System.Drawing.Size(142, 31)
        Me.bt_FicherosMultimedia.TabIndex = 5
        Me.bt_FicherosMultimedia.Text = "Ficheros"
        Me.bt_FicherosMultimedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_FicherosMultimedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_FicherosMultimedia.UseVisualStyleBackColor = True
        '
        'bt_FormaPago
        '
        Me.bt_FormaPago.FlatAppearance.BorderSize = 0
        Me.bt_FormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_FormaPago.Image = Global.centro_medico.My.Resources.Resources.Dollar_Sign
        Me.bt_FormaPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_FormaPago.Location = New System.Drawing.Point(4, 153)
        Me.bt_FormaPago.Name = "bt_FormaPago"
        Me.bt_FormaPago.Size = New System.Drawing.Size(142, 31)
        Me.bt_FormaPago.TabIndex = 4
        Me.bt_FormaPago.Text = "Forma de Pago"
        Me.bt_FormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_FormaPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_FormaPago.UseVisualStyleBackColor = True
        '
        'bt_Facturas
        '
        Me.bt_Facturas.FlatAppearance.BorderSize = 0
        Me.bt_Facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Facturas.Image = Global.centro_medico.My.Resources.Resources._24_tag_manager
        Me.bt_Facturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Facturas.Location = New System.Drawing.Point(4, 113)
        Me.bt_Facturas.Name = "bt_Facturas"
        Me.bt_Facturas.Size = New System.Drawing.Size(142, 31)
        Me.bt_Facturas.TabIndex = 3
        Me.bt_Facturas.Text = "Facturas"
        Me.bt_Facturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Facturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Facturas.UseVisualStyleBackColor = True
        '
        'bt_Citas
        '
        Me.bt_Citas.FlatAppearance.BorderSize = 0
        Me.bt_Citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Citas.Image = Global.centro_medico.My.Resources.Resources.Calendar_Week
        Me.bt_Citas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Citas.Location = New System.Drawing.Point(4, 76)
        Me.bt_Citas.Name = "bt_Citas"
        Me.bt_Citas.Size = New System.Drawing.Size(142, 31)
        Me.bt_Citas.TabIndex = 2
        Me.bt_Citas.Text = "Citas"
        Me.bt_Citas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Citas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Citas.UseVisualStyleBackColor = True
        '
        'bt_HistorialLaboral
        '
        Me.bt_HistorialLaboral.FlatAppearance.BorderSize = 0
        Me.bt_HistorialLaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_HistorialLaboral.Image = Global.centro_medico.My.Resources.Resources._24_settings_blue
        Me.bt_HistorialLaboral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_HistorialLaboral.Location = New System.Drawing.Point(4, 39)
        Me.bt_HistorialLaboral.Name = "bt_HistorialLaboral"
        Me.bt_HistorialLaboral.Size = New System.Drawing.Size(142, 31)
        Me.bt_HistorialLaboral.TabIndex = 1
        Me.bt_HistorialLaboral.Text = "Historial Laboral"
        Me.bt_HistorialLaboral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_HistorialLaboral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_HistorialLaboral.UseVisualStyleBackColor = True
        '
        'bt_DatosPersonales
        '
        Me.bt_DatosPersonales.FlatAppearance.BorderSize = 0
        Me.bt_DatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_DatosPersonales.Image = Global.centro_medico.My.Resources.Resources._24_member
        Me.bt_DatosPersonales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_DatosPersonales.Location = New System.Drawing.Point(4, 3)
        Me.bt_DatosPersonales.Name = "bt_DatosPersonales"
        Me.bt_DatosPersonales.Size = New System.Drawing.Size(142, 31)
        Me.bt_DatosPersonales.TabIndex = 0
        Me.bt_DatosPersonales.Text = "Datos Personales"
        Me.bt_DatosPersonales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_DatosPersonales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_DatosPersonales.UseVisualStyleBackColor = True
        '
        'nbp_DatosMedicos
        '
        Me.nbp_DatosMedicos.BackColor = System.Drawing.SystemColors.Control
        Me.nbp_DatosMedicos.Caption = "Datos Médicos"
        Me.nbp_DatosMedicos.Controls.Add(Me.bt_RevComparativa)
        Me.nbp_DatosMedicos.Controls.Add(Me.bt_Analiticas)
        Me.nbp_DatosMedicos.Controls.Add(Me.bt_Recetas)
        Me.nbp_DatosMedicos.Controls.Add(Me.bt_Derivaciones)
        Me.nbp_DatosMedicos.Controls.Add(Me.bt_HistorialClinico)
        Me.nbp_DatosMedicos.Controls.Add(Me.bt_Antecedentes)
        Me.nbp_DatosMedicos.Hidden = False
        Me.nbp_DatosMedicos.Image = CType(resources.GetObject("nbp_DatosMedicos.Image"), System.Drawing.Image)
        Me.nbp_DatosMedicos.Location = New System.Drawing.Point(1, 26)
        Me.nbp_DatosMedicos.MainImagePosition = System.Drawing.ContentAlignment.MiddleLeft
        Me.nbp_DatosMedicos.Name = "nbp_DatosMedicos"
        Me.nbp_DatosMedicos.Selected = False
        Me.nbp_DatosMedicos.Size = New System.Drawing.Size(154, 390)
        Me.nbp_DatosMedicos.TabIndex = 1
        Me.nbp_DatosMedicos.TabStop = True
        Me.nbp_DatosMedicos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.nbp_DatosMedicos.TextPaddingOffset = New System.Drawing.Point(30, 0)
        '
        'bt_RevComparativa
        '
        Me.bt_RevComparativa.FlatAppearance.BorderSize = 0
        Me.bt_RevComparativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_RevComparativa.Image = Global.centro_medico.My.Resources.Resources.Reflex_Tester
        Me.bt_RevComparativa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_RevComparativa.Location = New System.Drawing.Point(6, 263)
        Me.bt_RevComparativa.Name = "bt_RevComparativa"
        Me.bt_RevComparativa.Size = New System.Drawing.Size(142, 46)
        Me.bt_RevComparativa.TabIndex = 10
        Me.bt_RevComparativa.Text = "Rev Comparativas"
        Me.bt_RevComparativa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_RevComparativa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_RevComparativa.UseVisualStyleBackColor = True
        '
        'bt_Analiticas
        '
        Me.bt_Analiticas.FlatAppearance.BorderSize = 0
        Me.bt_Analiticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Analiticas.Image = Global.centro_medico.My.Resources.Resources.Chemicals
        Me.bt_Analiticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Analiticas.Location = New System.Drawing.Point(6, 211)
        Me.bt_Analiticas.Name = "bt_Analiticas"
        Me.bt_Analiticas.Size = New System.Drawing.Size(142, 46)
        Me.bt_Analiticas.TabIndex = 9
        Me.bt_Analiticas.Text = "Analíticas"
        Me.bt_Analiticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Analiticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Analiticas.UseVisualStyleBackColor = True
        '
        'bt_Recetas
        '
        Me.bt_Recetas.FlatAppearance.BorderSize = 0
        Me.bt_Recetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Recetas.Image = Global.centro_medico.My.Resources.Resources.Allergy_Vials
        Me.bt_Recetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Recetas.Location = New System.Drawing.Point(6, 159)
        Me.bt_Recetas.Name = "bt_Recetas"
        Me.bt_Recetas.Size = New System.Drawing.Size(142, 46)
        Me.bt_Recetas.TabIndex = 8
        Me.bt_Recetas.Text = "Recetas"
        Me.bt_Recetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Recetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Recetas.UseVisualStyleBackColor = True
        '
        'bt_Derivaciones
        '
        Me.bt_Derivaciones.FlatAppearance.BorderSize = 0
        Me.bt_Derivaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Derivaciones.Image = Global.centro_medico.My.Resources.Resources._24_arrow_forward
        Me.bt_Derivaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Derivaciones.Location = New System.Drawing.Point(6, 107)
        Me.bt_Derivaciones.Name = "bt_Derivaciones"
        Me.bt_Derivaciones.Size = New System.Drawing.Size(142, 46)
        Me.bt_Derivaciones.TabIndex = 7
        Me.bt_Derivaciones.Text = "Derivaciones"
        Me.bt_Derivaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Derivaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Derivaciones.UseVisualStyleBackColor = True
        '
        'bt_HistorialClinico
        '
        Me.bt_HistorialClinico.FlatAppearance.BorderSize = 0
        Me.bt_HistorialClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_HistorialClinico.Image = Global.centro_medico.My.Resources.Resources._24_book_green_check
        Me.bt_HistorialClinico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_HistorialClinico.Location = New System.Drawing.Point(6, 55)
        Me.bt_HistorialClinico.Name = "bt_HistorialClinico"
        Me.bt_HistorialClinico.Size = New System.Drawing.Size(142, 46)
        Me.bt_HistorialClinico.TabIndex = 6
        Me.bt_HistorialClinico.Text = "Historial Clínico"
        Me.bt_HistorialClinico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_HistorialClinico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_HistorialClinico.UseVisualStyleBackColor = True
        '
        'bt_Antecedentes
        '
        Me.bt_Antecedentes.FlatAppearance.BorderSize = 0
        Me.bt_Antecedentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Antecedentes.Image = Global.centro_medico.My.Resources.Resources._24_book_red
        Me.bt_Antecedentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Antecedentes.Location = New System.Drawing.Point(6, 3)
        Me.bt_Antecedentes.Name = "bt_Antecedentes"
        Me.bt_Antecedentes.Size = New System.Drawing.Size(142, 46)
        Me.bt_Antecedentes.TabIndex = 5
        Me.bt_Antecedentes.Text = "Antecedentes"
        Me.bt_Antecedentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Antecedentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Antecedentes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.grpDebito)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lblAlarmas)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1031, 90)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'grpDebito
        '
        Me.grpDebito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDebito.Controls.Add(Me.lblSaldo)
        Me.grpDebito.Controls.Add(Me.Label1)
        Me.grpDebito.Controls.Add(Me.lblDebe)
        Me.grpDebito.Controls.Add(Me.Label6)
        Me.grpDebito.Location = New System.Drawing.Point(785, 8)
        Me.grpDebito.Name = "grpDebito"
        Me.grpDebito.Size = New System.Drawing.Size(185, 75)
        Me.grpDebito.TabIndex = 29
        Me.grpDebito.TabStop = False
        Me.grpDebito.Visible = False
        '
        'lblSaldo
        '
        Me.lblSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.Color.Green
        Me.lblSaldo.Location = New System.Drawing.Point(96, 43)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(77, 20)
        Me.lblSaldo.TabIndex = 30
        Me.lblSaldo.Text = "0.00"
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CREDITO:"
        '
        'lblDebe
        '
        Me.lblDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDebe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebe.ForeColor = System.Drawing.Color.Red
        Me.lblDebe.Location = New System.Drawing.Point(96, 19)
        Me.lblDebe.Name = "lblDebe"
        Me.lblDebe.Size = New System.Drawing.Size(77, 20)
        Me.lblDebe.TabIndex = 28
        Me.lblDebe.Text = "0.00"
        Me.lblDebe.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(40, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "DEBE:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.centro_medico.My.Resources.Resources.PacienteDebito2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(976, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 41)
        Me.Button1.TabIndex = 28
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lblAlarmas
        '
        Me.lblAlarmas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlarmas.Location = New System.Drawing.Point(670, 16)
        Me.lblAlarmas.Name = "lblAlarmas"
        Me.lblAlarmas.Size = New System.Drawing.Size(66, 40)
        Me.lblAlarmas.TabIndex = 21
        Me.lblAlarmas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.centro_medico.My.Resources.Resources.pacienteSingular
        Me.PictureBox1.Location = New System.Drawing.Point(10, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PACIENTEBindingSource, "FECHAALTA", True))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(331, 58)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'PACIENTEBindingSource
        '
        Me.PACIENTEBindingSource.DataSource = GetType(centro_medico.PACIENTE)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(114, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Fecha Alta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(81, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Código Propio"
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTEBindingSource, "APELLIDO1", True))
        Me.TextBox1.Location = New System.Drawing.Point(84, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(138, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTEBindingSource, "APELLIDO2", True))
        Me.TextBox2.Location = New System.Drawing.Point(228, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(146, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTEBindingSource, "NOMBRE", True))
        Me.TextBox3.Location = New System.Drawing.Point(380, 15)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(167, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox7
        '
        Me.TextBox7.AcceptsReturn = True
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTEBindingSource, "CPACIENTE", True))
        Me.TextBox7.Location = New System.Drawing.Point(160, 38)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(62, 20)
        Me.TextBox7.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.AcceptsReturn = True
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTEBindingSource, "CODIGOPROPIO", True))
        Me.TextBox5.Location = New System.Drawing.Point(160, 62)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(62, 20)
        Me.TextBox5.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(479, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Edad"
        '
        'txtEdad
        '
        Me.txtEdad.AcceptsReturn = True
        Me.txtEdad.BackColor = System.Drawing.Color.White
        Me.txtEdad.Location = New System.Drawing.Point(517, 58)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(30, 20)
        Me.txtEdad.TabIndex = 11
        '
        'lbl_TeclasAcceso
        '
        Me.lbl_TeclasAcceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TeclasAcceso.AutoSize = True
        Me.lbl_TeclasAcceso.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TeclasAcceso.Location = New System.Drawing.Point(3, 6)
        Me.lbl_TeclasAcceso.Name = "lbl_TeclasAcceso"
        Me.lbl_TeclasAcceso.Size = New System.Drawing.Size(939, 13)
        Me.lbl_TeclasAcceso.TabIndex = 20
        Me.lbl_TeclasAcceso.Text = "Alt+I=Imprimir; F1=Antecedentes Médicos; F2= Datos personales; F3=Servicios Perio" & _
    "dicos; F4=Historial; F5=Citas; F6=Derivaciones; F7=Recetas; F8=Facturas;F9=Anali" & _
    "ticas; F10=Rev. Comparativas"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.centro_medico.My.Resources.Resources.FONDO2
        Me.Panel1.Controls.Add(Me.lbl_TeclasAcceso)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 635)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 19)
        Me.Panel1.TabIndex = 26
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar, Me.tlbImprimir, Me.ToolStripDropDownButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1034, 25)
        Me.ToolStrip2.TabIndex = 29
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(66, 22)
        Me.tsbGuardar.Text = "Gu&ardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(69, 22)
        Me.tsbCancelar.Text = "Can&celar"
        Me.tsbCancelar.Visible = False
        '
        'tlbImprimir
        '
        Me.tlbImprimir.BackColor = System.Drawing.Color.White
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(65, 22)
        Me.tlbImprimir.Text = "Impr&imir"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem, Me.CascadaToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripDropDownButton1.Text = "Organizar Ventanas"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CascadaToolStripMenuItem.Text = "Cascada"
        '
        'CtrlStatusPaciente1
        '
        Me.CtrlStatusPaciente1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlStatusPaciente1.ID_PACIENTE = Nothing
        Me.CtrlStatusPaciente1.Location = New System.Drawing.Point(797, 1)
        Me.CtrlStatusPaciente1.Name = "CtrlStatusPaciente1"
        Me.CtrlStatusPaciente1.Size = New System.Drawing.Size(236, 27)
        Me.CtrlStatusPaciente1.TabIndex = 25
        '
        'frmPacienteMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1034, 654)
        Me.Controls.Add(Me.CtrlStatusPaciente1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NavigationBar1)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "frmPacienteMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha de Paciente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.NavigationBar1.ResumeLayout(False)
        Me.nbp_DatosAdministrativos.ResumeLayout(False)
        Me.nbp_DatosMedicos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDebito.ResumeLayout(False)
        Me.grpDebito.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrlStatusPaciente1 As centro_medico.ctrlStatusPaciente
    Friend WithEvents NavigationBar1 As Itchin.Winforms.Controls_F2.NavigationBar
    Friend WithEvents nbp_DatosAdministrativos As Itchin.Winforms.Controls_F2.NavigationBarPane
    Friend WithEvents btn_PartesAsistencia As System.Windows.Forms.Button
    Friend WithEvents bt_PartesBajaAlta As System.Windows.Forms.Button
    Friend WithEvents bt_Recibos As System.Windows.Forms.Button
    Friend WithEvents bt_ServiciosPeriodicos As System.Windows.Forms.Button
    Friend WithEvents bt_FicherosMultimedia As System.Windows.Forms.Button
    Friend WithEvents bt_FormaPago As System.Windows.Forms.Button
    Friend WithEvents bt_Facturas As System.Windows.Forms.Button
    Friend WithEvents bt_Citas As System.Windows.Forms.Button
    Friend WithEvents bt_HistorialLaboral As System.Windows.Forms.Button
    Friend WithEvents bt_DatosPersonales As System.Windows.Forms.Button
    Friend WithEvents nbp_DatosMedicos As Itchin.Winforms.Controls_F2.NavigationBarPane
    Friend WithEvents bt_RevComparativa As System.Windows.Forms.Button
    Friend WithEvents bt_Analiticas As System.Windows.Forms.Button
    Friend WithEvents bt_Recetas As System.Windows.Forms.Button
    Friend WithEvents bt_Derivaciones As System.Windows.Forms.Button
    Friend WithEvents bt_HistorialClinico As System.Windows.Forms.Button
    Friend WithEvents bt_Antecedentes As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As ctrlTextboxAvanzado
    Friend WithEvents TextBox2 As ctrlTextboxAvanzado
    Friend WithEvents TextBox3 As ctrlTextboxAvanzado
    Friend WithEvents TextBox5 As ctrlTextboxAvanzado
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEdad As ctrlTextboxAvanzado
    Friend WithEvents lblAlarmas As System.Windows.Forms.Label
    Friend WithEvents lbl_TeclasAcceso As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox7 As ctrlTextboxAvanzado
    Friend WithEvents PACIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents VerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grpDebito As System.Windows.Forms.GroupBox
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDebe As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
