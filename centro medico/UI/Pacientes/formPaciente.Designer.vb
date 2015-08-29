<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPaciente))
        Me.NavigationBar1 = New Itchin.Winforms.Controls_F2.NavigationBar()
        Me.nbp_DatosAdministrativos = New Itchin.Winforms.Controls_F2.NavigationBarPane()
        Me.btBonos = New System.Windows.Forms.Button()
        Me.btProcesos = New System.Windows.Forms.Button()
        Me.btnComunicaciones = New System.Windows.Forms.Button()
        Me.btnReportesPersonalizados = New System.Windows.Forms.Button()
        Me.btn_PartesAsistencia = New System.Windows.Forms.Button()
        Me.bt_PartesBajaAlta = New System.Windows.Forms.Button()
        Me.bt_Recibos = New System.Windows.Forms.Button()
        Me.bt_ServiciosPeriodicos = New System.Windows.Forms.Button()
        Me.bt_FicherosMultimedia = New System.Windows.Forms.Button()
        Me.bt_FormaPago = New System.Windows.Forms.Button()
        Me.bt_Facturas = New System.Windows.Forms.Button()
        Me.bt_Citas = New System.Windows.Forms.Button()
        Me.bt_DatosPersonales = New System.Windows.Forms.Button()
        Me.nbp_DatosMedicos = New Itchin.Winforms.Controls_F2.NavigationBarPane()
        Me.bt_informesMedicos = New System.Windows.Forms.Button()
        Me.bt_RevComparativa = New System.Windows.Forms.Button()
        Me.bt_Analiticas = New System.Windows.Forms.Button()
        Me.bt_Recetas = New System.Windows.Forms.Button()
        Me.bt_Derivaciones = New System.Windows.Forms.Button()
        Me.bt_HistorialClinico = New System.Windows.Forms.Button()
        Me.bt_Antecedentes = New System.Windows.Forms.Button()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.lblCodigoPaciente = New System.Windows.Forms.Label()
        Me.lblCodigoPropio = New System.Windows.Forms.Label()
        Me.lbl_Apellido1 = New System.Windows.Forms.Label()
        Me.lbl_Apellido2 = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Edad = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_TeclasAcceso = New System.Windows.Forms.Label()
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblConsentimiento = New System.Windows.Forms.Label()
        Me.CtrlStatusPaciente1 = New centro_medico.ctrlStatusPaciente()
        Me.dtp_FechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAlarmas = New System.Windows.Forms.Label()
        Me.bt_Factura = New System.Windows.Forms.Button()
        Me.bt_Cita = New System.Windows.Forms.Button()
        Me.tb_CodigoPaciente = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_CodigoPropio = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_Apellido1 = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_Edad = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_Apellido2 = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_Nombre = New centro_medico.ctrlTextboxAvanzado()
        Me.ALARMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALARMASTableAdapter = New centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter()
        Me.LINEASALARMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINEASALARMATableAdapter = New centro_medico.CMDataSetTableAdapters.LINEASALARMATableAdapter()
        Me.NavigationBar1.SuspendLayout()
        Me.nbp_DatosAdministrativos.SuspendLayout()
        Me.nbp_DatosMedicos.SuspendLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASALARMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavigationBar1
        '
        Me.NavigationBar1.AlphaSettings.HoverItemAlpha = 70
        Me.NavigationBar1.AlphaSettings.SelectedItemAlpha = 100
        Me.NavigationBar1.AlphaSettings.UnselectedItemAlpha = 70
        Me.NavigationBar1.AlphaSettings.UseAlphaSettings = False
        Me.NavigationBar1.Controls.Add(Me.nbp_DatosAdministrativos)
        Me.NavigationBar1.Controls.Add(Me.nbp_DatosMedicos)
        Me.NavigationBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.NavigationBar1.DesignTimeEdit = True
        Me.NavigationBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavigationBar1.HeaderFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NavigationBar1.HeaderForeColor = System.Drawing.Color.White
        Me.NavigationBar1.HeaderTextalignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.NavigationBar1.Location = New System.Drawing.Point(0, 25)
        Me.NavigationBar1.Logo.Alpha = 50
        Me.NavigationBar1.Logo.DisplayLogo = True
        Me.NavigationBar1.Logo.Image = Nothing
        Me.NavigationBar1.LogoImagePosition = System.Drawing.ContentAlignment.BottomRight
        Me.NavigationBar1.Name = "NavigationBar1"
        Me.NavigationBar1.Panels.Add(Me.nbp_DatosAdministrativos)
        Me.NavigationBar1.Panels.Add(Me.nbp_DatosMedicos)
        Me.NavigationBar1.SelectedForecolor = System.Drawing.Color.Red
        Me.NavigationBar1.SelectedItem = Me.nbp_DatosMedicos
        Me.NavigationBar1.ShowAddRemoveMenu = True
        Me.NavigationBar1.ShowMenuButton = True
        Me.NavigationBar1.Size = New System.Drawing.Size(161, 587)
        Me.NavigationBar1.TabIndex = 0
        Me.NavigationBar1.Text = "NavigationBar1"
        Me.NavigationBar1.ThemeFormat.BorderColor = System.Drawing.Color.CadetBlue
        Me.NavigationBar1.ThemeFormat.HeaderColorOne = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.HeaderColorTwo = System.Drawing.SystemColors.Highlight
        Me.NavigationBar1.ThemeFormat.HotColorOne = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.HotColorTwo = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.NormalColorOne = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.NormalColorTwo = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.SelectedColorOne = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.SelectedColorTwo = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.SplitterBarColorOne = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NavigationBar1.ThemeFormat.SplitterBarColorTwo = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.NavigationBar1.ToolTipTimeOut = 5000
        Me.NavigationBar1.VisibleItems = 2
        '
        'nbp_DatosAdministrativos
        '
        Me.nbp_DatosAdministrativos.BackColor = System.Drawing.SystemColors.Control
        Me.nbp_DatosAdministrativos.Caption = "Datos Administrativos"
        Me.nbp_DatosAdministrativos.Controls.Add(Me.btBonos)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.btProcesos)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.btnComunicaciones)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.btnReportesPersonalizados)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.btn_PartesAsistencia)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_PartesBajaAlta)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_Recibos)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_ServiciosPeriodicos)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_FicherosMultimedia)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_FormaPago)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_Facturas)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_Citas)
        Me.nbp_DatosAdministrativos.Controls.Add(Me.bt_DatosPersonales)
        Me.nbp_DatosAdministrativos.Hidden = False
        Me.nbp_DatosAdministrativos.Image = CType(resources.GetObject("nbp_DatosAdministrativos.Image"), System.Drawing.Image)
        Me.nbp_DatosAdministrativos.Location = New System.Drawing.Point(1, 26)
        Me.nbp_DatosAdministrativos.MainImagePosition = System.Drawing.ContentAlignment.MiddleLeft
        Me.nbp_DatosAdministrativos.Name = "nbp_DatosAdministrativos"
        Me.nbp_DatosAdministrativos.Selected = False
        Me.nbp_DatosAdministrativos.Size = New System.Drawing.Size(159, 461)
        Me.nbp_DatosAdministrativos.TabIndex = 0
        Me.nbp_DatosAdministrativos.TabStop = True
        Me.nbp_DatosAdministrativos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.nbp_DatosAdministrativos.TextPaddingOffset = New System.Drawing.Point(30, 0)
        '
        'btBonos
        '
        Me.btBonos.FlatAppearance.BorderSize = 0
        Me.btBonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBonos.Image = Global.centro_medico.My.Resources.Resources._24_tag_hot
        Me.btBonos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBonos.Location = New System.Drawing.Point(5, 434)
        Me.btBonos.Name = "btBonos"
        Me.btBonos.Size = New System.Drawing.Size(126, 35)
        Me.btBonos.TabIndex = 12
        Me.btBonos.Text = "Bonos y Sesiones"
        Me.btBonos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBonos.UseVisualStyleBackColor = True
        '
        'btProcesos
        '
        Me.btProcesos.FlatAppearance.BorderSize = 0
        Me.btProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btProcesos.Image = Global.centro_medico.My.Resources.Resources.Procesos_Finalizado
        Me.btProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btProcesos.Location = New System.Drawing.Point(5, 365)
        Me.btProcesos.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
        Me.btProcesos.Name = "btProcesos"
        Me.btProcesos.Size = New System.Drawing.Size(142, 36)
        Me.btProcesos.TabIndex = 8
        Me.btProcesos.Text = "Procesos"
        Me.btProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btProcesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btProcesos.UseVisualStyleBackColor = False
        '
        'btnComunicaciones
        '
        Me.btnComunicaciones.FlatAppearance.BorderSize = 0
        Me.btnComunicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComunicaciones.Image = Global.centro_medico.My.Resources.Resources.communication
        Me.btnComunicaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComunicaciones.Location = New System.Drawing.Point(5, 396)
        Me.btnComunicaciones.Name = "btnComunicaciones"
        Me.btnComunicaciones.Size = New System.Drawing.Size(141, 35)
        Me.btnComunicaciones.TabIndex = 11
        Me.btnComunicaciones.Text = "Comunicaciones   "
        Me.btnComunicaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnComunicaciones.UseVisualStyleBackColor = True
        '
        'btnReportesPersonalizados
        '
        Me.btnReportesPersonalizados.AutoSize = True
        Me.btnReportesPersonalizados.FlatAppearance.BorderSize = 0
        Me.btnReportesPersonalizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportesPersonalizados.Image = Global.centro_medico.My.Resources.Resources.custom_report24x24
        Me.btnReportesPersonalizados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportesPersonalizados.Location = New System.Drawing.Point(4, 335)
        Me.btnReportesPersonalizados.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
        Me.btnReportesPersonalizados.Name = "btnReportesPersonalizados"
        Me.btnReportesPersonalizados.Size = New System.Drawing.Size(154, 36)
        Me.btnReportesPersonalizados.TabIndex = 8
        Me.btnReportesPersonalizados.Text = "Rptes Personalizados"
        Me.btnReportesPersonalizados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReportesPersonalizados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportesPersonalizados.UseVisualStyleBackColor = False
        '
        'btn_PartesAsistencia
        '
        Me.btn_PartesAsistencia.FlatAppearance.BorderSize = 0
        Me.btn_PartesAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PartesAsistencia.Image = Global.centro_medico.My.Resources.Resources.Documents_small
        Me.btn_PartesAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_PartesAsistencia.Location = New System.Drawing.Point(4, 298)
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
        Me.bt_PartesBajaAlta.Location = New System.Drawing.Point(4, 261)
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
        Me.bt_Recibos.Location = New System.Drawing.Point(4, 227)
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
        Me.bt_ServiciosPeriodicos.Location = New System.Drawing.Point(4, 192)
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
        Me.bt_FicherosMultimedia.Location = New System.Drawing.Point(4, 155)
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
        Me.bt_FormaPago.Location = New System.Drawing.Point(4, 117)
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
        Me.bt_Facturas.Location = New System.Drawing.Point(4, 77)
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
        Me.bt_Citas.Location = New System.Drawing.Point(4, 40)
        Me.bt_Citas.Name = "bt_Citas"
        Me.bt_Citas.Size = New System.Drawing.Size(142, 31)
        Me.bt_Citas.TabIndex = 2
        Me.bt_Citas.Text = "Citas"
        Me.bt_Citas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Citas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Citas.UseVisualStyleBackColor = True
        '
        'bt_DatosPersonales
        '
        Me.bt_DatosPersonales.FlatAppearance.BorderSize = 0
        Me.bt_DatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_DatosPersonales.Image = Global.centro_medico.My.Resources.Resources._24_member
        Me.bt_DatosPersonales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_DatosPersonales.Location = New System.Drawing.Point(4, 6)
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
        Me.nbp_DatosMedicos.Controls.Add(Me.bt_informesMedicos)
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
        Me.nbp_DatosMedicos.Selected = True
        Me.nbp_DatosMedicos.Size = New System.Drawing.Size(159, 461)
        Me.nbp_DatosMedicos.TabIndex = 1
        Me.nbp_DatosMedicos.TabStop = True
        Me.nbp_DatosMedicos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.nbp_DatosMedicos.TextPaddingOffset = New System.Drawing.Point(30, 0)
        '
        'bt_informesMedicos
        '
        Me.bt_informesMedicos.FlatAppearance.BorderSize = 0
        Me.bt_informesMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_informesMedicos.Image = Global.centro_medico.My.Resources.Resources.Document_New
        Me.bt_informesMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_informesMedicos.Location = New System.Drawing.Point(6, 320)
        Me.bt_informesMedicos.Name = "bt_informesMedicos"
        Me.bt_informesMedicos.Size = New System.Drawing.Size(142, 46)
        Me.bt_informesMedicos.TabIndex = 12
        Me.bt_informesMedicos.Text = "Informes Médicos   "
        Me.bt_informesMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_informesMedicos.UseVisualStyleBackColor = True
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
        Me.bt_RevComparativa.Text = " Rev Comparativas"
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
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCodigoPaciente
        '
        Me.lblCodigoPaciente.AutoSize = True
        Me.lblCodigoPaciente.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoPaciente.Location = New System.Drawing.Point(16, 10)
        Me.lblCodigoPaciente.Name = "lblCodigoPaciente"
        Me.lblCodigoPaciente.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigoPaciente.TabIndex = 2
        Me.lblCodigoPaciente.Text = "Código"
        '
        'lblCodigoPropio
        '
        Me.lblCodigoPropio.AutoSize = True
        Me.lblCodigoPropio.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoPropio.Location = New System.Drawing.Point(81, 10)
        Me.lblCodigoPropio.Name = "lblCodigoPropio"
        Me.lblCodigoPropio.Size = New System.Drawing.Size(73, 13)
        Me.lblCodigoPropio.TabIndex = 4
        Me.lblCodigoPropio.Text = "Código Propio"
        '
        'lbl_Apellido1
        '
        Me.lbl_Apellido1.AutoSize = True
        Me.lbl_Apellido1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Apellido1.Location = New System.Drawing.Point(156, 10)
        Me.lbl_Apellido1.Name = "lbl_Apellido1"
        Me.lbl_Apellido1.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Apellido1.TabIndex = 6
        Me.lbl_Apellido1.Text = "Apellido1"
        '
        'lbl_Apellido2
        '
        Me.lbl_Apellido2.AutoSize = True
        Me.lbl_Apellido2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Apellido2.Location = New System.Drawing.Point(329, 10)
        Me.lbl_Apellido2.Name = "lbl_Apellido2"
        Me.lbl_Apellido2.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Apellido2.TabIndex = 8
        Me.lbl_Apellido2.Text = "Apellido2"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Nombre.Location = New System.Drawing.Point(502, 10)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 10
        Me.lbl_Nombre.Text = "Nombre"
        '
        'lbl_Edad
        '
        Me.lbl_Edad.AutoSize = True
        Me.lbl_Edad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Edad.Location = New System.Drawing.Point(679, 10)
        Me.lbl_Edad.Name = "lbl_Edad"
        Me.lbl_Edad.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Edad.TabIndex = 12
        Me.lbl_Edad.Text = "Edad"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar, Me.tlbImprimir, Me.ToolStripDropDownButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(980, 25)
        Me.ToolStrip2.TabIndex = 21
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(66, 22)
        Me.tsbGuardar.Text = "Gu&ardar"
        Me.tsbGuardar.Visible = False
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
        'lbl_TeclasAcceso
        '
        Me.lbl_TeclasAcceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TeclasAcceso.AutoSize = True
        Me.lbl_TeclasAcceso.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TeclasAcceso.Location = New System.Drawing.Point(3, 87)
        Me.lbl_TeclasAcceso.Name = "lbl_TeclasAcceso"
        Me.lbl_TeclasAcceso.Size = New System.Drawing.Size(939, 13)
        Me.lbl_TeclasAcceso.TabIndex = 20
        Me.lbl_TeclasAcceso.Text = "Alt+I=Imprimir; F1=Antecedentes Médicos; F2= Datos personales; F3=Servicios Perio" & _
    "dicos; F4=Historial; F5=Citas; F6=Derivaciones; F7=Recetas; F8=Facturas;F9=Anali" & _
    "ticas; F10=Rev. Comparativas"
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.centro_medico.My.Resources.Resources.FONDO2
        Me.Panel1.Controls.Add(Me.lblConsentimiento)
        Me.Panel1.Controls.Add(Me.CtrlStatusPaciente1)
        Me.Panel1.Controls.Add(Me.dtp_FechaAlta)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblAlarmas)
        Me.Panel1.Controls.Add(Me.lbl_TeclasAcceso)
        Me.Panel1.Controls.Add(Me.bt_Factura)
        Me.Panel1.Controls.Add(Me.bt_Cita)
        Me.Panel1.Controls.Add(Me.lblCodigoPaciente)
        Me.Panel1.Controls.Add(Me.tb_CodigoPaciente)
        Me.Panel1.Controls.Add(Me.tb_CodigoPropio)
        Me.Panel1.Controls.Add(Me.lblCodigoPropio)
        Me.Panel1.Controls.Add(Me.lbl_Edad)
        Me.Panel1.Controls.Add(Me.tb_Apellido1)
        Me.Panel1.Controls.Add(Me.tb_Edad)
        Me.Panel1.Controls.Add(Me.lbl_Apellido1)
        Me.Panel1.Controls.Add(Me.lbl_Nombre)
        Me.Panel1.Controls.Add(Me.tb_Apellido2)
        Me.Panel1.Controls.Add(Me.tb_Nombre)
        Me.Panel1.Controls.Add(Me.lbl_Apellido2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(161, 512)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 100)
        Me.Panel1.TabIndex = 23
        '
        'lblConsentimiento
        '
        Me.lblConsentimiento.AutoSize = True
        Me.lblConsentimiento.ForeColor = System.Drawing.Color.DarkRed
        Me.lblConsentimiento.Location = New System.Drawing.Point(574, 57)
        Me.lblConsentimiento.Name = "lblConsentimiento"
        Me.lblConsentimiento.Size = New System.Drawing.Size(175, 13)
        Me.lblConsentimiento.TabIndex = 26
        Me.lblConsentimiento.Text = "CONSENTIMIENTO NO FIRMADO"
        Me.lblConsentimiento.Visible = False
        '
        'CtrlStatusPaciente1
        '
        Me.CtrlStatusPaciente1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CtrlStatusPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.PACIENTESBindingSource, "CPACIENTE", True))
        Me.CtrlStatusPaciente1.ID_PACIENTE = Nothing
        Me.CtrlStatusPaciente1.Location = New System.Drawing.Point(332, 50)
        Me.CtrlStatusPaciente1.Name = "CtrlStatusPaciente1"
        Me.CtrlStatusPaciente1.Size = New System.Drawing.Size(236, 27)
        Me.CtrlStatusPaciente1.TabIndex = 25
        '
        'dtp_FechaAlta
        '
        Me.dtp_FechaAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtp_FechaAlta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PACIENTESBindingSource, "FECHAALTA", True))
        Me.dtp_FechaAlta.Enabled = False
        Me.dtp_FechaAlta.Location = New System.Drawing.Point(84, 53)
        Me.dtp_FechaAlta.Name = "dtp_FechaAlta"
        Me.dtp_FechaAlta.Size = New System.Drawing.Size(200, 20)
        Me.dtp_FechaAlta.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Fecha Alta:"
        '
        'lblAlarmas
        '
        Me.lblAlarmas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlarmas.Location = New System.Drawing.Point(758, 30)
        Me.lblAlarmas.Name = "lblAlarmas"
        Me.lblAlarmas.Size = New System.Drawing.Size(68, 40)
        Me.lblAlarmas.TabIndex = 21
        Me.lblAlarmas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_Factura
        '
        Me.bt_Factura.BackgroundImage = Global.centro_medico.My.Resources.Resources.Facturas
        Me.bt_Factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_Factura.Location = New System.Drawing.Point(725, 29)
        Me.bt_Factura.Name = "bt_Factura"
        Me.bt_Factura.Size = New System.Drawing.Size(31, 22)
        Me.bt_Factura.TabIndex = 14
        Me.bt_Factura.UseVisualStyleBackColor = True
        Me.bt_Factura.Visible = False
        '
        'bt_Cita
        '
        Me.bt_Cita.BackgroundImage = Global.centro_medico.My.Resources.Resources.Citas
        Me.bt_Cita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_Cita.Location = New System.Drawing.Point(725, 3)
        Me.bt_Cita.Name = "bt_Cita"
        Me.bt_Cita.Size = New System.Drawing.Size(31, 21)
        Me.bt_Cita.TabIndex = 13
        Me.bt_Cita.UseVisualStyleBackColor = True
        Me.bt_Cita.Visible = False
        '
        'tb_CodigoPaciente
        '
        Me.tb_CodigoPaciente.AcceptsReturn = True
        Me.tb_CodigoPaciente.BackColor = System.Drawing.Color.White
        Me.tb_CodigoPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "CPACIENTE", True))
        Me.tb_CodigoPaciente.Location = New System.Drawing.Point(19, 29)
        Me.tb_CodigoPaciente.Name = "tb_CodigoPaciente"
        Me.tb_CodigoPaciente.ReadOnly = True
        Me.tb_CodigoPaciente.Size = New System.Drawing.Size(59, 20)
        Me.tb_CodigoPaciente.TabIndex = 1
        '
        'tb_CodigoPropio
        '
        Me.tb_CodigoPropio.AcceptsReturn = True
        Me.tb_CodigoPropio.BackColor = System.Drawing.Color.White
        Me.tb_CodigoPropio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "CODIGOPROPIO", True))
        Me.tb_CodigoPropio.Enabled = False
        Me.tb_CodigoPropio.Location = New System.Drawing.Point(84, 29)
        Me.tb_CodigoPropio.Name = "tb_CodigoPropio"
        Me.tb_CodigoPropio.Size = New System.Drawing.Size(58, 20)
        Me.tb_CodigoPropio.TabIndex = 3
        '
        'tb_Apellido1
        '
        Me.tb_Apellido1.AcceptsReturn = True
        Me.tb_Apellido1.BackColor = System.Drawing.Color.White
        Me.tb_Apellido1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO1", True))
        Me.tb_Apellido1.Enabled = False
        Me.tb_Apellido1.Location = New System.Drawing.Point(159, 29)
        Me.tb_Apellido1.Name = "tb_Apellido1"
        Me.tb_Apellido1.Size = New System.Drawing.Size(167, 20)
        Me.tb_Apellido1.TabIndex = 5
        '
        'tb_Edad
        '
        Me.tb_Edad.AcceptsReturn = True
        Me.tb_Edad.BackColor = System.Drawing.Color.White
        Me.tb_Edad.Enabled = False
        Me.tb_Edad.Location = New System.Drawing.Point(679, 29)
        Me.tb_Edad.Name = "tb_Edad"
        Me.tb_Edad.Size = New System.Drawing.Size(41, 20)
        Me.tb_Edad.TabIndex = 11
        '
        'tb_Apellido2
        '
        Me.tb_Apellido2.AcceptsReturn = True
        Me.tb_Apellido2.BackColor = System.Drawing.Color.White
        Me.tb_Apellido2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO2", True))
        Me.tb_Apellido2.Enabled = False
        Me.tb_Apellido2.Location = New System.Drawing.Point(332, 29)
        Me.tb_Apellido2.Name = "tb_Apellido2"
        Me.tb_Apellido2.Size = New System.Drawing.Size(167, 20)
        Me.tb_Apellido2.TabIndex = 7
        '
        'tb_Nombre
        '
        Me.tb_Nombre.AcceptsReturn = True
        Me.tb_Nombre.BackColor = System.Drawing.Color.White
        Me.tb_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NOMBRE", True))
        Me.tb_Nombre.Enabled = False
        Me.tb_Nombre.Location = New System.Drawing.Point(505, 29)
        Me.tb_Nombre.Name = "tb_Nombre"
        Me.tb_Nombre.Size = New System.Drawing.Size(167, 20)
        Me.tb_Nombre.TabIndex = 9
        '
        'ALARMASBindingSource
        '
        Me.ALARMASBindingSource.DataMember = "ALARMAS"
        Me.ALARMASBindingSource.DataSource = Me.CMDataSet
        '
        'ALARMASTableAdapter
        '
        Me.ALARMASTableAdapter.ClearBeforeFill = True
        '
        'LINEASALARMABindingSource
        '
        Me.LINEASALARMABindingSource.DataMember = "LINEASALARMA"
        Me.LINEASALARMABindingSource.DataSource = Me.CMDataSet
        '
        'LINEASALARMATableAdapter
        '
        Me.LINEASALARMATableAdapter.ClearBeforeFill = True
        '
        'formPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 612)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NavigationBar1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "formPaciente"
        Me.ShowInTaskbar = False
        Me.Text = "Ficha de Paciente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.NavigationBar1.ResumeLayout(False)
        Me.nbp_DatosAdministrativos.ResumeLayout(False)
        Me.nbp_DatosAdministrativos.PerformLayout()
        Me.nbp_DatosMedicos.ResumeLayout(False)
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASALARMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NavigationBar1 As Itchin.Winforms.Controls_F2.NavigationBar
    Friend WithEvents nbp_DatosAdministrativos As Itchin.Winforms.Controls_F2.NavigationBarPane
    Friend WithEvents nbp_DatosMedicos As Itchin.Winforms.Controls_F2.NavigationBarPane
    Friend WithEvents bt_DatosPersonales As System.Windows.Forms.Button
    Friend WithEvents bt_FormaPago As System.Windows.Forms.Button
    Friend WithEvents bt_Facturas As System.Windows.Forms.Button
    Friend WithEvents bt_Citas As System.Windows.Forms.Button
    Friend WithEvents bt_PartesBajaAlta As System.Windows.Forms.Button
    Friend WithEvents bt_Recibos As System.Windows.Forms.Button
    Friend WithEvents bt_ServiciosPeriodicos As System.Windows.Forms.Button
    Friend WithEvents bt_FicherosMultimedia As System.Windows.Forms.Button
    Friend WithEvents bt_Analiticas As System.Windows.Forms.Button
    Friend WithEvents bt_Recetas As System.Windows.Forms.Button
    Friend WithEvents bt_Derivaciones As System.Windows.Forms.Button
    Friend WithEvents bt_HistorialClinico As System.Windows.Forms.Button
    Friend WithEvents bt_Antecedentes As System.Windows.Forms.Button
    Friend WithEvents bt_RevComparativa As System.Windows.Forms.Button
    Friend WithEvents tb_CodigoPaciente As ctrlTextboxAvanzado
    Friend WithEvents lblCodigoPaciente As System.Windows.Forms.Label
    Friend WithEvents lblCodigoPropio As System.Windows.Forms.Label
    Friend WithEvents tb_CodigoPropio As ctrlTextboxAvanzado
    Friend WithEvents lbl_Apellido1 As System.Windows.Forms.Label
    Friend WithEvents tb_Apellido1 As ctrlTextboxAvanzado
    Friend WithEvents lbl_Apellido2 As System.Windows.Forms.Label
    Friend WithEvents tb_Apellido2 As ctrlTextboxAvanzado
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tb_Nombre As ctrlTextboxAvanzado
    Friend WithEvents lbl_Edad As System.Windows.Forms.Label
    Friend WithEvents tb_Edad As ctrlTextboxAvanzado
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_TeclasAcceso As System.Windows.Forms.Label
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ALARMASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALARMASTableAdapter As centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter
    Friend WithEvents LINEASALARMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEASALARMATableAdapter As centro_medico.CMDataSetTableAdapters.LINEASALARMATableAdapter
    Friend WithEvents bt_Factura As System.Windows.Forms.Button
    Friend WithEvents bt_Cita As System.Windows.Forms.Button
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents VerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAlarmas As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_PartesAsistencia As System.Windows.Forms.Button
    Friend WithEvents CtrlStatusPaciente1 As centro_medico.ctrlStatusPaciente
    Friend WithEvents btnReportesPersonalizados As System.Windows.Forms.Button
    Friend WithEvents btnComunicaciones As System.Windows.Forms.Button
    Friend WithEvents bt_informesMedicos As System.Windows.Forms.Button
    Friend WithEvents btProcesos As System.Windows.Forms.Button
    Friend WithEvents lblConsentimiento As System.Windows.Forms.Label
    Friend WithEvents btBonos As System.Windows.Forms.Button
End Class
