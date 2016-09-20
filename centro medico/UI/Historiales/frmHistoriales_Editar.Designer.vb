<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoriales_Editar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoriales_Editar))
        Dim GridEXLineaAlarma_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXDiagnosticoAntecedente_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim InfoPrimariaGridEX_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXHipoDiag_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXHipoDiag_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage")
        Dim GridEXRecetas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.gb_DatosHistorial = New System.Windows.Forms.GroupBox()
        Me.CtrlMedicoHistorial = New centro_medico.ctrlMedico()
        Me.HISTORIALEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_Paciente = New centro_medico.ctrlTextboxAvanzado()
        Me.dpt_hora = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.lb_Paciente = New System.Windows.Forms.Label()
        Me.lb_Fecha = New System.Windows.Forms.Label()
        Me.lb_Hora = New System.Windows.Forms.Label()
        Me.GridEXLineaAlarma = New Janus.Windows.GridEX.GridEX()
        Me.LINEASALARMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UiTabHistorial = New Janus.Windows.UI.Tab.UITab()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.EditMotivo = New centro_medico.ctrlTextboxAvanzado()
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage()
        Me.EditAntecedentes = New centro_medico.ctrlTextboxAvanzado()
        Me.GridEXDiagnosticoAntecedente = New Janus.Windows.GridEX.GridEX()
        Me.AntecedentesDiagnosticoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InfoPrimariaGridEX = New Janus.Windows.GridEX.GridEX()
        Me.INFORMACIONPRIMARIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.borrar = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage()
        Me.editHistorial = New centro_medico.ctrlTextboxAvanzado()
        Me.UiTabPage4 = New Janus.Windows.UI.Tab.UITabPage()
        Me.editExploracion = New centro_medico.ctrlTextboxAvanzado()
        Me.UiTabPage5 = New Janus.Windows.UI.Tab.UITabPage()
        Me.editPruebas = New centro_medico.ctrlTextboxAvanzado()
        Me.UiTabPage6 = New Janus.Windows.UI.Tab.UITabPage()
        Me.lbl_MSG = New System.Windows.Forms.Label()
        Me.btn_AnnadirAntecentes = New System.Windows.Forms.Button()
        Me.btEditDiagnostico = New System.Windows.Forms.Button()
        Me.btDelDiagnostico = New System.Windows.Forms.Button()
        Me.btAddDiagnostico = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CtrlDiagnosticosPrincipal = New centro_medico.ctrlDiagnosticos()
        Me.GridEXHipoDiag = New Janus.Windows.GridEX.GridEX()
        Me.HistorialesDiagnosticoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.editHipDiagnostica = New centro_medico.ctrlTextboxAvanzado()
        Me.UiTabTratamiento = New Janus.Windows.UI.Tab.UITabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRecetaSelecDescripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.RECETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.editTratamiento = New centro_medico.ctrlTextboxAvanzado()
        Me.GridEXRecetas = New Janus.Windows.GridEX.GridEX()
        Me.UiTabPage8 = New Janus.Windows.UI.Tab.UITabPage()
        Me.editOtrasObservaciones = New centro_medico.ctrlTextboxAvanzado()
        Me.UiTabPage9 = New Janus.Windows.UI.Tab.UITabPage()
        Me.editNotasFinales = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_HtCancelar = New System.Windows.Forms.Button()
        Me.bt_HtAceptar = New System.Windows.Forms.Button()
        Me.bt_HtImprimir = New System.Windows.Forms.Button()
        Me.btnDental = New System.Windows.Forms.Button()
        Me.bt_HtRecetas = New System.Windows.Forms.Button()
        Me.bt_HtAplicarplantilla = New System.Windows.Forms.Button()
        Me.TimerMsg = New System.Windows.Forms.Timer(Me.components)
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.ToolStrip2.SuspendLayout()
        Me.gb_DatosHistorial.SuspendLayout()
        CType(Me.HISTORIALEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXLineaAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASALARMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiTabHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabHistorial.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.GridEXDiagnosticoAntecedente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AntecedentesDiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoPrimariaGridEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFORMACIONPRIMARIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage3.SuspendLayout()
        Me.UiTabPage4.SuspendLayout()
        Me.UiTabPage5.SuspendLayout()
        Me.UiTabPage6.SuspendLayout()
        CType(Me.GridEXHipoDiag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorialesDiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabTratamiento.SuspendLayout()
        CType(Me.RECETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage8.SuspendLayout()
        Me.UiTabPage9.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar, Me.tlbImprimir})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(933, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = CType(resources.GetObject("tlbImprimir.Image"), System.Drawing.Image)
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'gb_DatosHistorial
        '
        Me.gb_DatosHistorial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_DatosHistorial.BackColor = System.Drawing.Color.GhostWhite
        Me.gb_DatosHistorial.Controls.Add(Me.CtrlMedicoHistorial)
        Me.gb_DatosHistorial.Controls.Add(Me.tb_Paciente)
        Me.gb_DatosHistorial.Controls.Add(Me.dpt_hora)
        Me.gb_DatosHistorial.Controls.Add(Me.dtp_Fecha)
        Me.gb_DatosHistorial.Controls.Add(Me.lb_Paciente)
        Me.gb_DatosHistorial.Controls.Add(Me.lb_Fecha)
        Me.gb_DatosHistorial.Controls.Add(Me.lb_Hora)
        Me.gb_DatosHistorial.Location = New System.Drawing.Point(4, 26)
        Me.gb_DatosHistorial.Name = "gb_DatosHistorial"
        Me.gb_DatosHistorial.Size = New System.Drawing.Size(911, 61)
        Me.gb_DatosHistorial.TabIndex = 1
        Me.gb_DatosHistorial.TabStop = False
        '
        'CtrlMedicoHistorial
        '
        Me.CtrlMedicoHistorial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlMedicoHistorial.DataBindings.Add(New System.Windows.Forms.Binding("ID_Medico", Me.HISTORIALEBindingSource, "REFMEDICO", True))
        Me.CtrlMedicoHistorial.ID_Medico = Nothing
        Me.CtrlMedicoHistorial.Location = New System.Drawing.Point(447, 10)
        Me.CtrlMedicoHistorial.Name = "CtrlMedicoHistorial"
        Me.CtrlMedicoHistorial.Size = New System.Drawing.Size(454, 42)
        Me.CtrlMedicoHistorial.TabIndex = 5
        '
        'HISTORIALEBindingSource
        '
        Me.HISTORIALEBindingSource.DataSource = GetType(centro_medico.HISTORIALE)
        '
        'tb_Paciente
        '
        Me.tb_Paciente.AcceptsReturn = True
        Me.tb_Paciente.BackColor = System.Drawing.Color.White
        Me.tb_Paciente.Enabled = False
        Me.tb_Paciente.Location = New System.Drawing.Point(4, 31)
        Me.tb_Paciente.Name = "tb_Paciente"
        Me.tb_Paciente.Size = New System.Drawing.Size(241, 20)
        Me.tb_Paciente.TabIndex = 1
        '
        'dpt_hora
        '
        Me.dpt_hora.CustomFormat = "hh:mm:ss"
        Me.dpt_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpt_hora.Location = New System.Drawing.Point(349, 31)
        Me.dpt_hora.Name = "dpt_hora"
        Me.dpt_hora.ShowUpDown = True
        Me.dpt_hora.Size = New System.Drawing.Size(89, 20)
        Me.dpt_hora.TabIndex = 3
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HISTORIALEBindingSource, "FECHA", True))
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(254, 31)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(89, 20)
        Me.dtp_Fecha.TabIndex = 2
        '
        'lb_Paciente
        '
        Me.lb_Paciente.AutoSize = True
        Me.lb_Paciente.Location = New System.Drawing.Point(1, 10)
        Me.lb_Paciente.Name = "lb_Paciente"
        Me.lb_Paciente.Size = New System.Drawing.Size(49, 13)
        Me.lb_Paciente.TabIndex = 0
        Me.lb_Paciente.Text = "Paciente"
        '
        'lb_Fecha
        '
        Me.lb_Fecha.AutoSize = True
        Me.lb_Fecha.Location = New System.Drawing.Point(251, 16)
        Me.lb_Fecha.Name = "lb_Fecha"
        Me.lb_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lb_Fecha.TabIndex = 0
        Me.lb_Fecha.Text = "Fecha"
        '
        'lb_Hora
        '
        Me.lb_Hora.AutoSize = True
        Me.lb_Hora.Location = New System.Drawing.Point(352, 15)
        Me.lb_Hora.Name = "lb_Hora"
        Me.lb_Hora.Size = New System.Drawing.Size(30, 13)
        Me.lb_Hora.TabIndex = 0
        Me.lb_Hora.Text = "Hora"
        '
        'GridEXLineaAlarma
        '
        Me.GridEXLineaAlarma.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXLineaAlarma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXLineaAlarma.ColumnAutoResize = True
        Me.GridEXLineaAlarma.DataSource = Me.LINEASALARMABindingSource
        GridEXLineaAlarma_DesignTimeLayout.LayoutString = resources.GetString("GridEXLineaAlarma_DesignTimeLayout.LayoutString")
        Me.GridEXLineaAlarma.DesignTimeLayout = GridEXLineaAlarma_DesignTimeLayout
        Me.GridEXLineaAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXLineaAlarma.GroupByBoxVisible = False
        Me.GridEXLineaAlarma.Location = New System.Drawing.Point(4, 93)
        Me.GridEXLineaAlarma.Name = "GridEXLineaAlarma"
        Me.GridEXLineaAlarma.Size = New System.Drawing.Size(911, 104)
        Me.GridEXLineaAlarma.TabIndex = 0
        '
        'LINEASALARMABindingSource
        '
        Me.LINEASALARMABindingSource.DataSource = GetType(centro_medico.LINEASALARMA)
        '
        'UiTabHistorial
        '
        Me.UiTabHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiTabHistorial.FirstTabOffset = 3
        Me.UiTabHistorial.Location = New System.Drawing.Point(4, 216)
        Me.UiTabHistorial.Name = "UiTabHistorial"
        Me.UiTabHistorial.Size = New System.Drawing.Size(911, 270)
        Me.UiTabHistorial.TabIndex = 0
        Me.UiTabHistorial.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage2, Me.UiTabPage3, Me.UiTabPage4, Me.UiTabPage5, Me.UiTabPage6, Me.UiTabTratamiento, Me.UiTabPage8, Me.UiTabPage9})
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.EditMotivo)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(907, 246)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Motivo de Consulta"
        '
        'EditMotivo
        '
        Me.EditMotivo.AcceptsReturn = True
        Me.EditMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditMotivo.Location = New System.Drawing.Point(3, 3)
        Me.EditMotivo.Multiline = True
        Me.EditMotivo.Name = "EditMotivo"
        Me.EditMotivo.Size = New System.Drawing.Size(903, 242)
        Me.EditMotivo.TabIndex = 0
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.EditAntecedentes)
        Me.UiTabPage2.Controls.Add(Me.GridEXDiagnosticoAntecedente)
        Me.UiTabPage2.Controls.Add(Me.InfoPrimariaGridEX)
        Me.UiTabPage2.Controls.Add(Me.borrar)
        Me.UiTabPage2.Controls.Add(Me.Add)
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(907, 246)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Antecedentes"
        '
        'EditAntecedentes
        '
        Me.EditAntecedentes.AcceptsReturn = True
        Me.EditAntecedentes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditAntecedentes.Location = New System.Drawing.Point(3, 151)
        Me.EditAntecedentes.Multiline = True
        Me.EditAntecedentes.Name = "EditAntecedentes"
        Me.EditAntecedentes.Size = New System.Drawing.Size(901, 92)
        Me.EditAntecedentes.TabIndex = 0
        '
        'GridEXDiagnosticoAntecedente
        '
        Me.GridEXDiagnosticoAntecedente.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDiagnosticoAntecedente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXDiagnosticoAntecedente.ColumnAutoResize = True
        Me.GridEXDiagnosticoAntecedente.DataSource = Me.AntecedentesDiagnosticoBindingSource
        GridEXDiagnosticoAntecedente_DesignTimeLayout.LayoutString = resources.GetString("GridEXDiagnosticoAntecedente_DesignTimeLayout.LayoutString")
        Me.GridEXDiagnosticoAntecedente.DesignTimeLayout = GridEXDiagnosticoAntecedente_DesignTimeLayout
        Me.GridEXDiagnosticoAntecedente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXDiagnosticoAntecedente.GroupByBoxVisible = False
        Me.GridEXDiagnosticoAntecedente.Location = New System.Drawing.Point(449, 3)
        Me.GridEXDiagnosticoAntecedente.Name = "GridEXDiagnosticoAntecedente"
        Me.GridEXDiagnosticoAntecedente.Size = New System.Drawing.Size(455, 107)
        Me.GridEXDiagnosticoAntecedente.TabIndex = 236
        '
        'AntecedentesDiagnosticoBindingSource
        '
        Me.AntecedentesDiagnosticoBindingSource.DataSource = GetType(centro_medico.AntecedentesDiagnostico)
        '
        'InfoPrimariaGridEX
        '
        Me.InfoPrimariaGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.InfoPrimariaGridEX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InfoPrimariaGridEX.ColumnAutoResize = True
        Me.InfoPrimariaGridEX.DataSource = Me.INFORMACIONPRIMARIABindingSource
        InfoPrimariaGridEX_DesignTimeLayout.LayoutString = resources.GetString("InfoPrimariaGridEX_DesignTimeLayout.LayoutString")
        Me.InfoPrimariaGridEX.DesignTimeLayout = InfoPrimariaGridEX_DesignTimeLayout
        Me.InfoPrimariaGridEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.InfoPrimariaGridEX.GroupByBoxVisible = False
        Me.InfoPrimariaGridEX.Location = New System.Drawing.Point(3, 3)
        Me.InfoPrimariaGridEX.Name = "InfoPrimariaGridEX"
        Me.InfoPrimariaGridEX.Size = New System.Drawing.Size(434, 107)
        Me.InfoPrimariaGridEX.TabIndex = 0
        '
        'INFORMACIONPRIMARIABindingSource
        '
        Me.INFORMACIONPRIMARIABindingSource.DataSource = GetType(centro_medico.INFORMACIONPRIMARIA)
        '
        'borrar
        '
        Me.borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.borrar.BackColor = System.Drawing.SystemColors.Window
        Me.borrar.FlatAppearance.BorderSize = 0
        Me.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borrar.Image = CType(resources.GetObject("borrar.Image"), System.Drawing.Image)
        Me.borrar.Location = New System.Drawing.Point(45, 117)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(35, 29)
        Me.borrar.TabIndex = 234
        Me.borrar.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Add.BackColor = System.Drawing.SystemColors.Window
        Me.Add.FlatAppearance.BorderSize = 0
        Me.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add.Image = CType(resources.GetObject("Add.Image"), System.Drawing.Image)
        Me.Add.Location = New System.Drawing.Point(14, 116)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(35, 29)
        Me.Add.TabIndex = 233
        Me.Add.UseVisualStyleBackColor = False
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.editHistorial)
        Me.UiTabPage3.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(907, 246)
        Me.UiTabPage3.TabStop = True
        Me.UiTabPage3.Text = "Historial"
        '
        'editHistorial
        '
        Me.editHistorial.AcceptsReturn = True
        Me.editHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editHistorial.Location = New System.Drawing.Point(3, 3)
        Me.editHistorial.Multiline = True
        Me.editHistorial.Name = "editHistorial"
        Me.editHistorial.Size = New System.Drawing.Size(901, 240)
        Me.editHistorial.TabIndex = 1
        '
        'UiTabPage4
        '
        Me.UiTabPage4.Controls.Add(Me.editExploracion)
        Me.UiTabPage4.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage4.Name = "UiTabPage4"
        Me.UiTabPage4.Size = New System.Drawing.Size(907, 246)
        Me.UiTabPage4.TabStop = True
        Me.UiTabPage4.Text = "Exploración"
        '
        'editExploracion
        '
        Me.editExploracion.AcceptsReturn = True
        Me.editExploracion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editExploracion.Location = New System.Drawing.Point(3, 3)
        Me.editExploracion.Multiline = True
        Me.editExploracion.Name = "editExploracion"
        Me.editExploracion.Size = New System.Drawing.Size(901, 240)
        Me.editExploracion.TabIndex = 2
        '
        'UiTabPage5
        '
        Me.UiTabPage5.Controls.Add(Me.editPruebas)
        Me.UiTabPage5.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage5.Name = "UiTabPage5"
        Me.UiTabPage5.Size = New System.Drawing.Size(907, 246)
        Me.UiTabPage5.TabStop = True
        Me.UiTabPage5.Text = "Pruebas Complementarias"
        '
        'editPruebas
        '
        Me.editPruebas.AcceptsReturn = True
        Me.editPruebas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editPruebas.Location = New System.Drawing.Point(3, 3)
        Me.editPruebas.Multiline = True
        Me.editPruebas.Name = "editPruebas"
        Me.editPruebas.Size = New System.Drawing.Size(901, 240)
        Me.editPruebas.TabIndex = 0
        '
        'UiTabPage6
        '
        Me.UiTabPage6.Controls.Add(Me.lbl_MSG)
        Me.UiTabPage6.Controls.Add(Me.btn_AnnadirAntecentes)
        Me.UiTabPage6.Controls.Add(Me.btEditDiagnostico)
        Me.UiTabPage6.Controls.Add(Me.btDelDiagnostico)
        Me.UiTabPage6.Controls.Add(Me.btAddDiagnostico)
        Me.UiTabPage6.Controls.Add(Me.Label1)
        Me.UiTabPage6.Controls.Add(Me.CtrlDiagnosticosPrincipal)
        Me.UiTabPage6.Controls.Add(Me.GridEXHipoDiag)
        Me.UiTabPage6.Controls.Add(Me.editHipDiagnostica)
        Me.UiTabPage6.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage6.Name = "UiTabPage6"
        Me.UiTabPage6.Size = New System.Drawing.Size(907, 246)
        Me.UiTabPage6.TabStop = True
        Me.UiTabPage6.Text = "Hipótesis Diagnóstica"
        '
        'lbl_MSG
        '
        Me.lbl_MSG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_MSG.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_MSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MSG.ForeColor = System.Drawing.Color.Red
        Me.lbl_MSG.Location = New System.Drawing.Point(509, 155)
        Me.lbl_MSG.Name = "lbl_MSG"
        Me.lbl_MSG.Size = New System.Drawing.Size(224, 16)
        Me.lbl_MSG.TabIndex = 239
        Me.lbl_MSG.Text = "¡Añadido a Antecedentes!"
        Me.lbl_MSG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_MSG.Visible = False
        '
        'btn_AnnadirAntecentes
        '
        Me.btn_AnnadirAntecentes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_AnnadirAntecentes.BackColor = System.Drawing.SystemColors.Window
        Me.btn_AnnadirAntecentes.Enabled = False
        Me.btn_AnnadirAntecentes.FlatAppearance.BorderSize = 0
        Me.btn_AnnadirAntecentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AnnadirAntecentes.Image = Global.centro_medico.My.Resources.Resources._24_book_red_add
        Me.btn_AnnadirAntecentes.Location = New System.Drawing.Point(544, 14)
        Me.btn_AnnadirAntecentes.Name = "btn_AnnadirAntecentes"
        Me.btn_AnnadirAntecentes.Size = New System.Drawing.Size(21, 23)
        Me.btn_AnnadirAntecentes.TabIndex = 238
        Me.btn_AnnadirAntecentes.UseVisualStyleBackColor = False
        '
        'btEditDiagnostico
        '
        Me.btEditDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btEditDiagnostico.BackColor = System.Drawing.SystemColors.Window
        Me.btEditDiagnostico.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_book_blue_open
        Me.btEditDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btEditDiagnostico.FlatAppearance.BorderSize = 0
        Me.btEditDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEditDiagnostico.Location = New System.Drawing.Point(32, 152)
        Me.btEditDiagnostico.Name = "btEditDiagnostico"
        Me.btEditDiagnostico.Size = New System.Drawing.Size(23, 23)
        Me.btEditDiagnostico.TabIndex = 237
        Me.btEditDiagnostico.UseVisualStyleBackColor = False
        '
        'btDelDiagnostico
        '
        Me.btDelDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btDelDiagnostico.BackColor = System.Drawing.SystemColors.Window
        Me.btDelDiagnostico.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btDelDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btDelDiagnostico.FlatAppearance.BorderSize = 0
        Me.btDelDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDelDiagnostico.Location = New System.Drawing.Point(59, 152)
        Me.btDelDiagnostico.Name = "btDelDiagnostico"
        Me.btDelDiagnostico.Size = New System.Drawing.Size(23, 23)
        Me.btDelDiagnostico.TabIndex = 236
        Me.btDelDiagnostico.UseVisualStyleBackColor = False
        '
        'btAddDiagnostico
        '
        Me.btAddDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btAddDiagnostico.BackColor = System.Drawing.SystemColors.Window
        Me.btAddDiagnostico.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btAddDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btAddDiagnostico.FlatAppearance.BorderSize = 0
        Me.btAddDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAddDiagnostico.Location = New System.Drawing.Point(3, 152)
        Me.btAddDiagnostico.Name = "btAddDiagnostico"
        Me.btAddDiagnostico.Size = New System.Drawing.Size(23, 23)
        Me.btAddDiagnostico.TabIndex = 235
        Me.btAddDiagnostico.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 234
        Me.Label1.Text = "Diagnóstico"
        '
        'CtrlDiagnosticosPrincipal
        '
        Me.CtrlDiagnosticosPrincipal.DataBindings.Add(New System.Windows.Forms.Binding("ID_DIAGNOSTICOS", Me.HISTORIALEBindingSource, "REFDIAGNOSTICO", True))
        Me.CtrlDiagnosticosPrincipal.ID_DIAGNOSTICOS = Nothing
        Me.CtrlDiagnosticosPrincipal.Location = New System.Drawing.Point(77, 12)
        Me.CtrlDiagnosticosPrincipal.Name = "CtrlDiagnosticosPrincipal"
        Me.CtrlDiagnosticosPrincipal.Size = New System.Drawing.Size(447, 25)
        Me.CtrlDiagnosticosPrincipal.TabIndex = 233
        '
        'GridEXHipoDiag
        '
        Me.GridEXHipoDiag.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXHipoDiag.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXHipoDiag.ColumnAutoResize = True
        Me.GridEXHipoDiag.DataSource = Me.HistorialesDiagnosticoBindingSource
        GridEXHipoDiag_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEXHipoDiag_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEXHipoDiag_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEXHipoDiag_DesignTimeLayout_Reference_0})
        GridEXHipoDiag_DesignTimeLayout.LayoutString = resources.GetString("GridEXHipoDiag_DesignTimeLayout.LayoutString")
        Me.GridEXHipoDiag.DesignTimeLayout = GridEXHipoDiag_DesignTimeLayout
        Me.GridEXHipoDiag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXHipoDiag.GroupByBoxVisible = False
        Me.GridEXHipoDiag.Location = New System.Drawing.Point(-1, 43)
        Me.GridEXHipoDiag.Name = "GridEXHipoDiag"
        Me.GridEXHipoDiag.Size = New System.Drawing.Size(908, 107)
        Me.GridEXHipoDiag.TabIndex = 232
        '
        'HistorialesDiagnosticoBindingSource
        '
        Me.HistorialesDiagnosticoBindingSource.DataSource = GetType(centro_medico.HistorialesDiagnostico)
        '
        'editHipDiagnostica
        '
        Me.editHipDiagnostica.AcceptsReturn = True
        Me.editHipDiagnostica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editHipDiagnostica.Location = New System.Drawing.Point(3, 177)
        Me.editHipDiagnostica.Multiline = True
        Me.editHipDiagnostica.Name = "editHipDiagnostica"
        Me.editHipDiagnostica.Size = New System.Drawing.Size(901, 66)
        Me.editHipDiagnostica.TabIndex = 2
        '
        'UiTabTratamiento
        '
        Me.UiTabTratamiento.Controls.Add(Me.Label3)
        Me.UiTabTratamiento.Controls.Add(Me.txtRecetaSelecDescripcion)
        Me.UiTabTratamiento.Controls.Add(Me.editTratamiento)
        Me.UiTabTratamiento.Controls.Add(Me.GridEXRecetas)
        Me.UiTabTratamiento.Location = New System.Drawing.Point(1, 21)
        Me.UiTabTratamiento.Name = "UiTabTratamiento"
        Me.UiTabTratamiento.Size = New System.Drawing.Size(907, 246)
        Me.UiTabTratamiento.TabStop = True
        Me.UiTabTratamiento.Text = "Tratamiento"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(5, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 242
        Me.Label3.Text = "Notas:"
        '
        'txtRecetaSelecDescripcion
        '
        Me.txtRecetaSelecDescripcion.AcceptsReturn = True
        Me.txtRecetaSelecDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecetaSelecDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "TRATAMIENTO", True))
        Me.txtRecetaSelecDescripcion.Location = New System.Drawing.Point(712, 12)
        Me.txtRecetaSelecDescripcion.Multiline = True
        Me.txtRecetaSelecDescripcion.Name = "txtRecetaSelecDescripcion"
        Me.txtRecetaSelecDescripcion.ReadOnly = True
        Me.txtRecetaSelecDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRecetaSelecDescripcion.Size = New System.Drawing.Size(192, 104)
        Me.txtRecetaSelecDescripcion.TabIndex = 239
        Me.txtRecetaSelecDescripcion.TabStop = False
        '
        'RECETABindingSource
        '
        Me.RECETABindingSource.DataSource = GetType(centro_medico.RECETA)
        '
        'editTratamiento
        '
        Me.editTratamiento.AcceptsReturn = True
        Me.editTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editTratamiento.Location = New System.Drawing.Point(3, 141)
        Me.editTratamiento.Multiline = True
        Me.editTratamiento.Name = "editTratamiento"
        Me.editTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.editTratamiento.Size = New System.Drawing.Size(901, 102)
        Me.editTratamiento.TabIndex = 238
        '
        'GridEXRecetas
        '
        Me.GridEXRecetas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXRecetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXRecetas.ColumnAutoResize = True
        Me.GridEXRecetas.DataSource = Me.RECETABindingSource
        GridEXRecetas_DesignTimeLayout.LayoutString = resources.GetString("GridEXRecetas_DesignTimeLayout.LayoutString")
        Me.GridEXRecetas.DesignTimeLayout = GridEXRecetas_DesignTimeLayout
        Me.GridEXRecetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXRecetas.GroupByBoxVisible = False
        Me.GridEXRecetas.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridEXRecetas.Location = New System.Drawing.Point(0, 12)
        Me.GridEXRecetas.Name = "GridEXRecetas"
        Me.GridEXRecetas.Size = New System.Drawing.Size(706, 104)
        Me.GridEXRecetas.TabIndex = 231
        '
        'UiTabPage8
        '
        Me.UiTabPage8.Controls.Add(Me.editOtrasObservaciones)
        Me.UiTabPage8.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage8.Name = "UiTabPage8"
        Me.UiTabPage8.Size = New System.Drawing.Size(907, 246)
        Me.UiTabPage8.TabStop = True
        Me.UiTabPage8.Text = "Otras Observaciones"
        '
        'editOtrasObservaciones
        '
        Me.editOtrasObservaciones.AcceptsReturn = True
        Me.editOtrasObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editOtrasObservaciones.Location = New System.Drawing.Point(3, 3)
        Me.editOtrasObservaciones.Multiline = True
        Me.editOtrasObservaciones.Name = "editOtrasObservaciones"
        Me.editOtrasObservaciones.Size = New System.Drawing.Size(901, 240)
        Me.editOtrasObservaciones.TabIndex = 1
        '
        'UiTabPage9
        '
        Me.UiTabPage9.Controls.Add(Me.editNotasFinales)
        Me.UiTabPage9.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage9.Name = "UiTabPage9"
        Me.UiTabPage9.Size = New System.Drawing.Size(907, 246)
        Me.UiTabPage9.TabStop = True
        Me.UiTabPage9.Text = "Notas Finales"
        '
        'editNotasFinales
        '
        Me.editNotasFinales.AcceptsReturn = True
        Me.editNotasFinales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editNotasFinales.Location = New System.Drawing.Point(3, 3)
        Me.editNotasFinales.Multiline = True
        Me.editNotasFinales.Name = "editNotasFinales"
        Me.editNotasFinales.Size = New System.Drawing.Size(901, 240)
        Me.editNotasFinales.TabIndex = 1
        '
        'bt_HtCancelar
        '
        Me.bt_HtCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_HtCancelar.Image = CType(resources.GetObject("bt_HtCancelar.Image"), System.Drawing.Image)
        Me.bt_HtCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_HtCancelar.Location = New System.Drawing.Point(840, 522)
        Me.bt_HtCancelar.Name = "bt_HtCancelar"
        Me.bt_HtCancelar.Size = New System.Drawing.Size(75, 28)
        Me.bt_HtCancelar.TabIndex = 9
        Me.bt_HtCancelar.Text = "Cancelar"
        Me.bt_HtCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_HtCancelar.UseVisualStyleBackColor = True
        '
        'bt_HtAceptar
        '
        Me.bt_HtAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_HtAceptar.Image = CType(resources.GetObject("bt_HtAceptar.Image"), System.Drawing.Image)
        Me.bt_HtAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_HtAceptar.Location = New System.Drawing.Point(753, 522)
        Me.bt_HtAceptar.Name = "bt_HtAceptar"
        Me.bt_HtAceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_HtAceptar.TabIndex = 8
        Me.bt_HtAceptar.Text = "Aceptar"
        Me.bt_HtAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_HtAceptar.UseVisualStyleBackColor = True
        '
        'bt_HtImprimir
        '
        Me.bt_HtImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_HtImprimir.Image = CType(resources.GetObject("bt_HtImprimir.Image"), System.Drawing.Image)
        Me.bt_HtImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_HtImprimir.Location = New System.Drawing.Point(663, 522)
        Me.bt_HtImprimir.Name = "bt_HtImprimir"
        Me.bt_HtImprimir.Size = New System.Drawing.Size(75, 28)
        Me.bt_HtImprimir.TabIndex = 7
        Me.bt_HtImprimir.Text = "Imprimir"
        Me.bt_HtImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_HtImprimir.UseVisualStyleBackColor = True
        '
        'btnDental
        '
        Me.btnDental.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDental.BackColor = System.Drawing.SystemColors.Control
        Me.btnDental.BackgroundImage = CType(resources.GetObject("btnDental.BackgroundImage"), System.Drawing.Image)
        Me.btnDental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDental.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDental.Location = New System.Drawing.Point(267, 511)
        Me.btnDental.Name = "btnDental"
        Me.btnDental.Size = New System.Drawing.Size(113, 39)
        Me.btnDental.TabIndex = 6
        Me.btnDental.Text = "Dental"
        Me.btnDental.UseVisualStyleBackColor = False
        '
        'bt_HtRecetas
        '
        Me.bt_HtRecetas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_HtRecetas.BackgroundImage = CType(resources.GetObject("bt_HtRecetas.BackgroundImage"), System.Drawing.Image)
        Me.bt_HtRecetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_HtRecetas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_HtRecetas.Location = New System.Drawing.Point(148, 511)
        Me.bt_HtRecetas.Name = "bt_HtRecetas"
        Me.bt_HtRecetas.Size = New System.Drawing.Size(113, 39)
        Me.bt_HtRecetas.TabIndex = 5
        Me.bt_HtRecetas.Text = "Recetas"
        Me.bt_HtRecetas.UseVisualStyleBackColor = True
        '
        'bt_HtAplicarplantilla
        '
        Me.bt_HtAplicarplantilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_HtAplicarplantilla.BackgroundImage = CType(resources.GetObject("bt_HtAplicarplantilla.BackgroundImage"), System.Drawing.Image)
        Me.bt_HtAplicarplantilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_HtAplicarplantilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_HtAplicarplantilla.Location = New System.Drawing.Point(29, 511)
        Me.bt_HtAplicarplantilla.Name = "bt_HtAplicarplantilla"
        Me.bt_HtAplicarplantilla.Size = New System.Drawing.Size(113, 39)
        Me.bt_HtAplicarplantilla.TabIndex = 4
        Me.bt_HtAplicarplantilla.Text = "Aplicar Plantilla"
        Me.bt_HtAplicarplantilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_HtAplicarplantilla.UseVisualStyleBackColor = True
        '
        'TimerMsg
        '
        Me.TimerMsg.Interval = 3000
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTipo.Location = New System.Drawing.Point(386, 7)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(87, 16)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "HISTORIAL"
        '
        'frmHistoriales_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 573)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.bt_HtCancelar)
        Me.Controls.Add(Me.bt_HtAceptar)
        Me.Controls.Add(Me.bt_HtImprimir)
        Me.Controls.Add(Me.btnDental)
        Me.Controls.Add(Me.bt_HtRecetas)
        Me.Controls.Add(Me.bt_HtAplicarplantilla)
        Me.Controls.Add(Me.UiTabHistorial)
        Me.Controls.Add(Me.GridEXLineaAlarma)
        Me.Controls.Add(Me.gb_DatosHistorial)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(941, 600)
        Me.Name = "frmHistoriales_Editar"
        Me.ShowInTaskbar = False
        Me.Text = "Ficha Historial"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.gb_DatosHistorial.ResumeLayout(False)
        Me.gb_DatosHistorial.PerformLayout()
        CType(Me.HISTORIALEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXLineaAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASALARMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiTabHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabHistorial.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage1.PerformLayout()
        Me.UiTabPage2.ResumeLayout(False)
        Me.UiTabPage2.PerformLayout()
        CType(Me.GridEXDiagnosticoAntecedente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AntecedentesDiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoPrimariaGridEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFORMACIONPRIMARIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage3.ResumeLayout(False)
        Me.UiTabPage3.PerformLayout()
        Me.UiTabPage4.ResumeLayout(False)
        Me.UiTabPage4.PerformLayout()
        Me.UiTabPage5.ResumeLayout(False)
        Me.UiTabPage5.PerformLayout()
        Me.UiTabPage6.ResumeLayout(False)
        Me.UiTabPage6.PerformLayout()
        CType(Me.GridEXHipoDiag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorialesDiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabTratamiento.ResumeLayout(False)
        Me.UiTabTratamiento.PerformLayout()
        CType(Me.RECETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage8.ResumeLayout(False)
        Me.UiTabPage8.PerformLayout()
        Me.UiTabPage9.ResumeLayout(False)
        Me.UiTabPage9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CtrlMedicoHistorial As centro_medico.ctrlMedico
    Friend WithEvents gb_DatosHistorial As System.Windows.Forms.GroupBox
    Friend WithEvents tb_Paciente As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_Paciente As System.Windows.Forms.Label
    Friend WithEvents lb_Fecha As System.Windows.Forms.Label
    Friend WithEvents lb_Hora As System.Windows.Forms.Label
    Friend WithEvents dpt_hora As System.Windows.Forms.DateTimePicker
    Friend WithEvents GridEXLineaAlarma As Janus.Windows.GridEX.GridEX
    Friend WithEvents HISTORIALEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UiTabHistorial As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage5 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage6 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabTratamiento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage8 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage9 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents EditMotivo As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents editHistorial As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents editPruebas As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents editOtrasObservaciones As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents editNotasFinales As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents borrar As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents InfoPrimariaGridEX As Janus.Windows.GridEX.GridEX
    Friend WithEvents INFORMACIONPRIMARIABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridEXDiagnosticoAntecedente As Janus.Windows.GridEX.GridEX
    Friend WithEvents AntecedentesDiagnosticoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EditAntecedentes As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents LINEASALARMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents editHipDiagnostica As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents GridEXRecetas As Janus.Windows.GridEX.GridEX
    Friend WithEvents RECETABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents editTratamiento As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents bt_HtCancelar As System.Windows.Forms.Button
    Friend WithEvents bt_HtAceptar As System.Windows.Forms.Button
    Friend WithEvents bt_HtImprimir As System.Windows.Forms.Button
    Friend WithEvents btnDental As System.Windows.Forms.Button
    Friend WithEvents bt_HtRecetas As System.Windows.Forms.Button
    Friend WithEvents bt_HtAplicarplantilla As System.Windows.Forms.Button
    Friend WithEvents UiTabPage4 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents editExploracion As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CtrlDiagnosticosPrincipal As centro_medico.ctrlDiagnosticos
    Friend WithEvents GridEXHipoDiag As Janus.Windows.GridEX.GridEX
    Friend WithEvents btEditDiagnostico As System.Windows.Forms.Button
    Friend WithEvents btDelDiagnostico As System.Windows.Forms.Button
    Friend WithEvents btAddDiagnostico As System.Windows.Forms.Button
    Friend WithEvents btn_AnnadirAntecentes As System.Windows.Forms.Button
    Friend WithEvents lbl_MSG As System.Windows.Forms.Label
    Friend WithEvents HistorialesDiagnosticoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TimerMsg As System.Windows.Forms.Timer
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtRecetaSelecDescripcion As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
