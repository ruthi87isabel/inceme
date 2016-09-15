<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientesListado
    Inherits FormConfigurable

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPacientesListado))
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition0.FormatStyle.BackgroundImag" & _
        "e")
        Me.ListadoPacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbTodosEMail = New System.Windows.Forms.RadioButton()
        Me.rbSinEmail = New System.Windows.Forms.RadioButton()
        Me.rbConEMail = New System.Windows.Forms.RadioButton()
        Me.grpFiltrosEspeciales = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_CantDias = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.rbCumple_Dias = New System.Windows.Forms.RadioButton()
        Me.rbCumple_Hoy = New System.Windows.Forms.RadioButton()
        Me.chkFiltroCumple = New System.Windows.Forms.CheckBox()
        Me.btnConfigGrid = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsImporte = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsTotalPacientes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstMsgSelected = New System.Windows.Forms.ToolStripButton()
        Me.tstMsgAll = New System.Windows.Forms.ToolStripButton()
        Me.txtTop100 = New System.Windows.Forms.CheckBox()
        Me.grpFiltrarPorNombre = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDni = New centro_medico.ctrlTextboxAvanzado()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New centro_medico.ctrlTextboxAvanzado()
        Me.txtApellido1 = New centro_medico.ctrlTextboxAvanzado()
        Me.txtMovil = New centro_medico.ctrlTextboxAvanzado()
        Me.txtTelefono = New centro_medico.ctrlTextboxAvanzado()
        Me.txtDireccion = New centro_medico.ctrlTextboxAvanzado()
        Me.txtCodigoPropio = New centro_medico.ctrlTextboxAvanzado()
        Me.txtNombre = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chb_fallecidos = New System.Windows.Forms.CheckBox()
        Me.rb_fallecno = New System.Windows.Forms.RadioButton()
        Me.rb_fallecsi = New System.Windows.Forms.RadioButton()
        Me.pnl_Loading = New System.Windows.Forms.Panel()
        Me.lnkCancelar = New System.Windows.Forms.LinkLabel()
        Me.lbl_Loading = New System.Windows.Forms.Label()
        Me.pb_Loading = New System.Windows.Forms.PictureBox()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.CtrlMutua1 = New centro_medico.ctrlMutua()
        Me.CtrlPaises1 = New centro_medico.ctrlPaises()
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        Me.CtrlEmpresa1 = New centro_medico.ctrlEmpresa()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rb_srec = New System.Windows.Forms.RadioButton()
        Me.rb_crec = New System.Windows.Forms.RadioButton()
        Me.rb_todascobrar = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkSocioActivo = New System.Windows.Forms.CheckBox()
        Me.chb_asoc = New System.Windows.Forms.CheckBox()
        Me.rb_asocno = New System.Windows.Forms.RadioButton()
        Me.rb_asocsi = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chb_activo = New System.Windows.Forms.CheckBox()
        Me.rb_activono = New System.Windows.Forms.RadioButton()
        Me.rb_activosi = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chb_baja = New System.Windows.Forms.CheckBox()
        Me.dtp_ffb = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fib = New System.Windows.Forms.DateTimePicker()
        Me.grpFiltrarPorCodigo = New System.Windows.Forms.GroupBox()
        Me.CtrlPacienteHasta = New centro_medico.ctrlPaciente2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CtrlPacienteDesde = New centro_medico.ctrlPaciente2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chb_ingreso = New System.Windows.Forms.CheckBox()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chb_nac = New System.Windows.Forms.CheckBox()
        Me.dtp_ffn = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fin = New System.Windows.Forms.DateTimePicker()
        CType(Me.ListadoPacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpFiltrosEspeciales.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.grpFiltrarPorNombre.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.pnl_Loading.SuspendLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpFiltrarPorCodigo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 25)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1008, 25)
        Me.BindingNavigator1.TabIndex = 228
        Me.BindingNavigator1.Text = "BindingNavigator1"
        Me.BindingNavigator1.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbTodosEMail)
        Me.Panel1.Controls.Add(Me.rbSinEmail)
        Me.Panel1.Controls.Add(Me.rbConEMail)
        Me.Panel1.Location = New System.Drawing.Point(757, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 32)
        Me.Panel1.TabIndex = 227
        '
        'rbTodosEMail
        '
        Me.rbTodosEMail.AutoSize = True
        Me.rbTodosEMail.Checked = True
        Me.rbTodosEMail.Location = New System.Drawing.Point(168, 10)
        Me.rbTodosEMail.Name = "rbTodosEMail"
        Me.rbTodosEMail.Size = New System.Drawing.Size(51, 17)
        Me.rbTodosEMail.TabIndex = 2
        Me.rbTodosEMail.TabStop = True
        Me.rbTodosEMail.Text = "todos"
        Me.rbTodosEMail.UseVisualStyleBackColor = True
        '
        'rbSinEmail
        '
        Me.rbSinEmail.AutoSize = True
        Me.rbSinEmail.Location = New System.Drawing.Point(92, 10)
        Me.rbSinEmail.Name = "rbSinEmail"
        Me.rbSinEmail.Size = New System.Drawing.Size(66, 17)
        Me.rbSinEmail.TabIndex = 1
        Me.rbSinEmail.Text = "sin Email"
        Me.rbSinEmail.UseVisualStyleBackColor = True
        '
        'rbConEMail
        '
        Me.rbConEMail.AutoSize = True
        Me.rbConEMail.Location = New System.Drawing.Point(15, 10)
        Me.rbConEMail.Name = "rbConEMail"
        Me.rbConEMail.Size = New System.Drawing.Size(71, 17)
        Me.rbConEMail.TabIndex = 0
        Me.rbConEMail.Text = "con Email"
        Me.rbConEMail.UseVisualStyleBackColor = True
        '
        'grpFiltrosEspeciales
        '
        Me.grpFiltrosEspeciales.Controls.Add(Me.Label11)
        Me.grpFiltrosEspeciales.Controls.Add(Me.tb_CantDias)
        Me.grpFiltrosEspeciales.Controls.Add(Me.rbCumple_Dias)
        Me.grpFiltrosEspeciales.Controls.Add(Me.rbCumple_Hoy)
        Me.grpFiltrosEspeciales.Controls.Add(Me.chkFiltroCumple)
        Me.grpFiltrosEspeciales.Location = New System.Drawing.Point(453, 209)
        Me.grpFiltrosEspeciales.Name = "grpFiltrosEspeciales"
        Me.grpFiltrosEspeciales.Size = New System.Drawing.Size(271, 44)
        Me.grpFiltrosEspeciales.TabIndex = 226
        Me.grpFiltrosEspeciales.TabStop = False
        Me.grpFiltrosEspeciales.Text = "Filtro Cumpleannos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(231, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "días"
        '
        'tb_CantDias
        '
        Me.tb_CantDias.DecimalDigits = 0
        Me.tb_CantDias.Enabled = False
        Me.tb_CantDias.Location = New System.Drawing.Point(200, 19)
        Me.tb_CantDias.Name = "tb_CantDias"
        Me.tb_CantDias.Size = New System.Drawing.Size(25, 20)
        Me.tb_CantDias.TabIndex = 2
        Me.tb_CantDias.Text = "7"
        Me.tb_CantDias.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'rbCumple_Dias
        '
        Me.rbCumple_Dias.AutoSize = True
        Me.rbCumple_Dias.Enabled = False
        Me.rbCumple_Dias.Location = New System.Drawing.Point(150, 19)
        Me.rbCumple_Dias.Name = "rbCumple_Dias"
        Me.rbCumple_Dias.Size = New System.Drawing.Size(56, 17)
        Me.rbCumple_Dias.TabIndex = 1
        Me.rbCumple_Dias.Text = "Hoy + "
        Me.rbCumple_Dias.UseVisualStyleBackColor = True
        '
        'rbCumple_Hoy
        '
        Me.rbCumple_Hoy.AutoSize = True
        Me.rbCumple_Hoy.Checked = True
        Me.rbCumple_Hoy.Enabled = False
        Me.rbCumple_Hoy.Location = New System.Drawing.Point(108, 19)
        Me.rbCumple_Hoy.Name = "rbCumple_Hoy"
        Me.rbCumple_Hoy.Size = New System.Drawing.Size(44, 17)
        Me.rbCumple_Hoy.TabIndex = 1
        Me.rbCumple_Hoy.TabStop = True
        Me.rbCumple_Hoy.Text = "Hoy"
        Me.rbCumple_Hoy.UseVisualStyleBackColor = True
        '
        'chkFiltroCumple
        '
        Me.chkFiltroCumple.Location = New System.Drawing.Point(11, 15)
        Me.chkFiltroCumple.Name = "chkFiltroCumple"
        Me.chkFiltroCumple.Size = New System.Drawing.Size(105, 28)
        Me.chkFiltroCumple.TabIndex = 0
        Me.chkFiltroCumple.Text = "Aniversarios de:"
        Me.chkFiltroCumple.UseVisualStyleBackColor = True
        '
        'btnConfigGrid
        '
        Me.btnConfigGrid.Image = Global.centro_medico.My.Resources.Resources._24_settings
        Me.btnConfigGrid.Location = New System.Drawing.Point(908, 1)
        Me.btnConfigGrid.Name = "btnConfigGrid"
        Me.btnConfigGrid.Size = New System.Drawing.Size(31, 24)
        Me.btnConfigGrid.TabIndex = 225
        Me.btnConfigGrid.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.tsImporte, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel6, Me.tsTotalPacientes})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 660)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.StatusStrip1.TabIndex = 224
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Purple
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 19)
        Me.ToolStripStatusLabel1.Text = "Asociado"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(69, 19)
        Me.ToolStripStatusLabel2.Text = "Beneficiario"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.AutoSize = False
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(200, 19)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(222, 19)
        Me.ToolStripStatusLabel5.Text = "Total importe por conceptos facturables:"
        '
        'tsImporte
        '
        Me.tsImporte.AutoSize = False
        Me.tsImporte.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsImporte.Name = "tsImporte"
        Me.tsImporte.Size = New System.Drawing.Size(100, 19)
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.AutoSize = False
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(40, 19)
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(90, 19)
        Me.ToolStripStatusLabel6.Text = "Total pacientes:"
        '
        'tsTotalPacientes
        '
        Me.tsTotalPacientes.AutoSize = False
        Me.tsTotalPacientes.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsTotalPacientes.Name = "tsTotalPacientes"
        Me.tsTotalPacientes.Size = New System.Drawing.Size(100, 19)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir, Me.ToolStripSeparator2, Me.tstMsgSelected, Me.tstMsgAll})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 223
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tstMsgSelected
        '
        Me.tstMsgSelected.Image = Global.centro_medico.My.Resources.Resources.Email
        Me.tstMsgSelected.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstMsgSelected.Name = "tstMsgSelected"
        Me.tstMsgSelected.Size = New System.Drawing.Size(157, 22)
        Me.tstMsgSelected.Text = "Mensaje a seleccionados"
        '
        'tstMsgAll
        '
        Me.tstMsgAll.Image = Global.centro_medico.My.Resources.Resources.Email
        Me.tstMsgAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstMsgAll.Name = "tstMsgAll"
        Me.tstMsgAll.Size = New System.Drawing.Size(122, 22)
        Me.tstMsgAll.Text = "Mensaje a TODOS"
        '
        'txtTop100
        '
        Me.txtTop100.AutoSize = True
        Me.txtTop100.Checked = True
        Me.txtTop100.CheckState = System.Windows.Forms.CheckState.Checked
        Me.txtTop100.Location = New System.Drawing.Point(758, 236)
        Me.txtTop100.Name = "txtTop100"
        Me.txtTop100.Size = New System.Drawing.Size(162, 17)
        Me.txtTop100.TabIndex = 222
        Me.txtTop100.Text = "Mostrar solo los primeros 100"
        Me.txtTop100.UseVisualStyleBackColor = True
        '
        'grpFiltrarPorNombre
        '
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label10)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtDni)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label8)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label7)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label9)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label6)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label4)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label3)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label5)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtApellido2)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtApellido1)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtMovil)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtTelefono)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtDireccion)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtCodigoPropio)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtNombre)
        Me.grpFiltrarPorNombre.Location = New System.Drawing.Point(4, 121)
        Me.grpFiltrarPorNombre.Name = "grpFiltrarPorNombre"
        Me.grpFiltrarPorNombre.Size = New System.Drawing.Size(443, 134)
        Me.grpFiltrarPorNombre.TabIndex = 219
        Me.grpFiltrarPorNombre.TabStop = False
        Me.grpFiltrarPorNombre.Text = "Filtrar pacientes por:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(231, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 196
        Me.Label10.Text = "DNI:"
        '
        'txtDni
        '
        Me.txtDni.AcceptsReturn = True
        Me.txtDni.Location = New System.Drawing.Point(266, 26)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(142, 20)
        Me.txtDni.TabIndex = 195
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 194
        Me.Label8.Text = "Apellido 2:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Apellido 1:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(225, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 194
        Me.Label9.Text = "Móvil:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "Teléfono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "C. Propio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "Nombre:"
        '
        'txtApellido2
        '
        Me.txtApellido2.AcceptsReturn = True
        Me.txtApellido2.Location = New System.Drawing.Point(81, 102)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(107, 20)
        Me.txtApellido2.TabIndex = 5
        '
        'txtApellido1
        '
        Me.txtApellido1.AcceptsReturn = True
        Me.txtApellido1.Location = New System.Drawing.Point(81, 76)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(107, 20)
        Me.txtApellido1.TabIndex = 4
        '
        'txtMovil
        '
        Me.txtMovil.AcceptsReturn = True
        Me.txtMovil.Location = New System.Drawing.Point(266, 103)
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(162, 20)
        Me.txtMovil.TabIndex = 3
        '
        'txtTelefono
        '
        Me.txtTelefono.AcceptsReturn = True
        Me.txtTelefono.Location = New System.Drawing.Point(266, 77)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(162, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.AcceptsReturn = True
        Me.txtDireccion.Location = New System.Drawing.Point(266, 51)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(162, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'txtCodigoPropio
        '
        Me.txtCodigoPropio.AcceptsReturn = True
        Me.txtCodigoPropio.Location = New System.Drawing.Point(81, 25)
        Me.txtCodigoPropio.Name = "txtCodigoPropio"
        Me.txtCodigoPropio.Size = New System.Drawing.Size(107, 20)
        Me.txtCodigoPropio.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.AcceptsReturn = True
        Me.txtNombre.Location = New System.Drawing.Point(81, 50)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(107, 20)
        Me.txtNombre.TabIndex = 3
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.Location = New System.Drawing.Point(922, 231)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(73, 25)
        Me.bt_filtrar.TabIndex = 208
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chb_fallecidos)
        Me.GroupBox8.Controls.Add(Me.rb_fallecno)
        Me.GroupBox8.Controls.Add(Me.rb_fallecsi)
        Me.GroupBox8.Location = New System.Drawing.Point(908, 28)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(84, 60)
        Me.GroupBox8.TabIndex = 199
        Me.GroupBox8.TabStop = False
        '
        'chb_fallecidos
        '
        Me.chb_fallecidos.AutoSize = True
        Me.chb_fallecidos.Location = New System.Drawing.Point(3, 12)
        Me.chb_fallecidos.Name = "chb_fallecidos"
        Me.chb_fallecidos.Size = New System.Drawing.Size(73, 17)
        Me.chb_fallecidos.TabIndex = 68
        Me.chb_fallecidos.Text = "Fallecidos"
        Me.chb_fallecidos.UseVisualStyleBackColor = True
        '
        'rb_fallecno
        '
        Me.rb_fallecno.AutoSize = True
        Me.rb_fallecno.Enabled = False
        Me.rb_fallecno.Location = New System.Drawing.Point(41, 30)
        Me.rb_fallecno.Name = "rb_fallecno"
        Me.rb_fallecno.Size = New System.Drawing.Size(37, 17)
        Me.rb_fallecno.TabIndex = 1
        Me.rb_fallecno.Text = "no"
        Me.rb_fallecno.UseVisualStyleBackColor = True
        '
        'rb_fallecsi
        '
        Me.rb_fallecsi.AutoSize = True
        Me.rb_fallecsi.Checked = True
        Me.rb_fallecsi.Enabled = False
        Me.rb_fallecsi.Location = New System.Drawing.Point(3, 30)
        Me.rb_fallecsi.Name = "rb_fallecsi"
        Me.rb_fallecsi.Size = New System.Drawing.Size(32, 17)
        Me.rb_fallecsi.TabIndex = 0
        Me.rb_fallecsi.TabStop = True
        Me.rb_fallecsi.Text = "si"
        Me.rb_fallecsi.UseVisualStyleBackColor = True
        '
        'pnl_Loading
        '
        Me.pnl_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Loading.Controls.Add(Me.lnkCancelar)
        Me.pnl_Loading.Controls.Add(Me.lbl_Loading)
        Me.pnl_Loading.Controls.Add(Me.pb_Loading)
        Me.pnl_Loading.Location = New System.Drawing.Point(365, 427)
        Me.pnl_Loading.Name = "pnl_Loading"
        Me.pnl_Loading.Size = New System.Drawing.Size(195, 56)
        Me.pnl_Loading.TabIndex = 221
        Me.pnl_Loading.Visible = False
        '
        'lnkCancelar
        '
        Me.lnkCancelar.AutoSize = True
        Me.lnkCancelar.Location = New System.Drawing.Point(49, 30)
        Me.lnkCancelar.Name = "lnkCancelar"
        Me.lnkCancelar.Size = New System.Drawing.Size(49, 13)
        Me.lnkCancelar.TabIndex = 120
        Me.lnkCancelar.TabStop = True
        Me.lnkCancelar.Text = "Cancelar"
        '
        'lbl_Loading
        '
        Me.lbl_Loading.AutoSize = True
        Me.lbl_Loading.Location = New System.Drawing.Point(49, 12)
        Me.lbl_Loading.Name = "lbl_Loading"
        Me.lbl_Loading.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Loading.TabIndex = 119
        Me.lbl_Loading.Text = "Preparando..."
        '
        'pb_Loading
        '
        Me.pb_Loading.Image = Global.centro_medico.My.Resources.Resources.ajax_loader
        Me.pb_Loading.Location = New System.Drawing.Point(6, 11)
        Me.pb_Loading.Name = "pb_Loading"
        Me.pb_Loading.Size = New System.Drawing.Size(40, 35)
        Me.pb_Loading.TabIndex = 118
        Me.pb_Loading.TabStop = False
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "re una columna aquí para reagrupar</GroupByBoxInfo></LocalizableData>"
        Me.GridEX1.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.DataSource = Me.ListadoPacientesBindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GridLines = Janus.Windows.GridEX.GridLines.RowOutline
        Me.GridEX1.Location = New System.Drawing.Point(4, 258)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.SelectedInactiveFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight
        Me.GridEX1.Size = New System.Drawing.Size(999, 399)
        Me.GridEX1.TabIndex = 220
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'CtrlMutua1
        '
        Me.CtrlMutua1.EscogerViaLineaMutua = False
        Me.CtrlMutua1.FiltrarMutuasPorPAciente = False
        Me.CtrlMutua1.ID_Mutuas = Nothing
        Me.CtrlMutua1.IDPACIENTE = Nothing
        Me.CtrlMutua1.Location = New System.Drawing.Point(724, 147)
        Me.CtrlMutua1.Name = "CtrlMutua1"
        Me.CtrlMutua1.Size = New System.Drawing.Size(268, 21)
        Me.CtrlMutua1.TabIndex = 207
        '
        'CtrlPaises1
        '
        Me.CtrlPaises1.ID_PAISES = Nothing
        Me.CtrlPaises1.Location = New System.Drawing.Point(728, 170)
        Me.CtrlPaises1.Name = "CtrlPaises1"
        Me.CtrlPaises1.Size = New System.Drawing.Size(264, 25)
        Me.CtrlPaises1.TabIndex = 206
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(695, 96)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(297, 23)
        Me.CtrlFormaPago21.TabIndex = 205
        '
        'CtrlEmpresa1
        '
        Me.CtrlEmpresa1.EsEmpresaPorDefecto = False
        Me.CtrlEmpresa1.ID_EMPRESAS = Nothing
        Me.CtrlEmpresa1.IDPACIENTE = Nothing
        Me.CtrlEmpresa1.Location = New System.Drawing.Point(707, 121)
        Me.CtrlEmpresa1.Name = "CtrlEmpresa1"
        Me.CtrlEmpresa1.Size = New System.Drawing.Size(288, 25)
        Me.CtrlEmpresa1.TabIndex = 204
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rb_srec)
        Me.GroupBox5.Controls.Add(Me.rb_crec)
        Me.GroupBox5.Controls.Add(Me.rb_todascobrar)
        Me.GroupBox5.Location = New System.Drawing.Point(338, 28)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(109, 90)
        Me.GroupBox5.TabIndex = 201
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pago por banco"
        '
        'rb_srec
        '
        Me.rb_srec.AutoSize = True
        Me.rb_srec.Location = New System.Drawing.Point(6, 67)
        Me.rb_srec.Name = "rb_srec"
        Me.rb_srec.Size = New System.Drawing.Size(72, 17)
        Me.rb_srec.TabIndex = 2
        Me.rb_srec.Text = "Sin recibo"
        Me.rb_srec.UseVisualStyleBackColor = True
        '
        'rb_crec
        '
        Me.rb_crec.AutoSize = True
        Me.rb_crec.Location = New System.Drawing.Point(6, 44)
        Me.rb_crec.Name = "rb_crec"
        Me.rb_crec.Size = New System.Drawing.Size(103, 17)
        Me.rb_crec.TabIndex = 1
        Me.rb_crec.Text = "Recibo bancario"
        Me.rb_crec.UseVisualStyleBackColor = True
        '
        'rb_todascobrar
        '
        Me.rb_todascobrar.AutoSize = True
        Me.rb_todascobrar.Checked = True
        Me.rb_todascobrar.Location = New System.Drawing.Point(6, 19)
        Me.rb_todascobrar.Name = "rb_todascobrar"
        Me.rb_todascobrar.Size = New System.Drawing.Size(55, 17)
        Me.rb_todascobrar.TabIndex = 0
        Me.rb_todascobrar.TabStop = True
        Me.rb_todascobrar.Text = "Todos"
        Me.rb_todascobrar.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkSocioActivo)
        Me.GroupBox6.Controls.Add(Me.chb_asoc)
        Me.GroupBox6.Controls.Add(Me.rb_asocno)
        Me.GroupBox6.Controls.Add(Me.rb_asocsi)
        Me.GroupBox6.Location = New System.Drawing.Point(707, 28)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(84, 67)
        Me.GroupBox6.TabIndex = 203
        Me.GroupBox6.TabStop = False
        '
        'chkSocioActivo
        '
        Me.chkSocioActivo.AutoSize = True
        Me.chkSocioActivo.Location = New System.Drawing.Point(4, 47)
        Me.chkSocioActivo.Name = "chkSocioActivo"
        Me.chkSocioActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkSocioActivo.TabIndex = 2
        Me.chkSocioActivo.Text = "Activo"
        Me.chkSocioActivo.ThreeState = True
        Me.chkSocioActivo.UseVisualStyleBackColor = True
        '
        'chb_asoc
        '
        Me.chb_asoc.AutoSize = True
        Me.chb_asoc.Location = New System.Drawing.Point(3, 12)
        Me.chb_asoc.Name = "chb_asoc"
        Me.chb_asoc.Size = New System.Drawing.Size(75, 17)
        Me.chb_asoc.TabIndex = 0
        Me.chb_asoc.Text = "Asociados"
        Me.chb_asoc.UseVisualStyleBackColor = True
        '
        'rb_asocno
        '
        Me.rb_asocno.AutoSize = True
        Me.rb_asocno.Enabled = False
        Me.rb_asocno.Location = New System.Drawing.Point(41, 30)
        Me.rb_asocno.Name = "rb_asocno"
        Me.rb_asocno.Size = New System.Drawing.Size(37, 17)
        Me.rb_asocno.TabIndex = 1
        Me.rb_asocno.Text = "no"
        Me.rb_asocno.UseVisualStyleBackColor = True
        '
        'rb_asocsi
        '
        Me.rb_asocsi.AutoSize = True
        Me.rb_asocsi.Checked = True
        Me.rb_asocsi.Enabled = False
        Me.rb_asocsi.Location = New System.Drawing.Point(3, 30)
        Me.rb_asocsi.Name = "rb_asocsi"
        Me.rb_asocsi.Size = New System.Drawing.Size(32, 17)
        Me.rb_asocsi.TabIndex = 0
        Me.rb_asocsi.TabStop = True
        Me.rb_asocsi.Text = "si"
        Me.rb_asocsi.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chb_activo)
        Me.GroupBox7.Controls.Add(Me.rb_activono)
        Me.GroupBox7.Controls.Add(Me.rb_activosi)
        Me.GroupBox7.Location = New System.Drawing.Point(806, 28)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(92, 60)
        Me.GroupBox7.TabIndex = 198
        Me.GroupBox7.TabStop = False
        '
        'chb_activo
        '
        Me.chb_activo.AutoSize = True
        Me.chb_activo.Location = New System.Drawing.Point(3, 12)
        Me.chb_activo.Name = "chb_activo"
        Me.chb_activo.Size = New System.Drawing.Size(61, 17)
        Me.chb_activo.TabIndex = 0
        Me.chb_activo.Text = "Activos"
        Me.chb_activo.UseVisualStyleBackColor = True
        '
        'rb_activono
        '
        Me.rb_activono.AutoSize = True
        Me.rb_activono.Enabled = False
        Me.rb_activono.Location = New System.Drawing.Point(43, 30)
        Me.rb_activono.Name = "rb_activono"
        Me.rb_activono.Size = New System.Drawing.Size(37, 17)
        Me.rb_activono.TabIndex = 2
        Me.rb_activono.Text = "no"
        Me.rb_activono.UseVisualStyleBackColor = True
        '
        'rb_activosi
        '
        Me.rb_activosi.AutoSize = True
        Me.rb_activosi.Checked = True
        Me.rb_activosi.Enabled = False
        Me.rb_activosi.Location = New System.Drawing.Point(5, 30)
        Me.rb_activosi.Name = "rb_activosi"
        Me.rb_activosi.Size = New System.Drawing.Size(32, 17)
        Me.rb_activosi.TabIndex = 1
        Me.rb_activosi.TabStop = True
        Me.rb_activosi.Text = "si"
        Me.rb_activosi.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chb_baja)
        Me.GroupBox4.Controls.Add(Me.dtp_ffb)
        Me.GroupBox4.Controls.Add(Me.dtp_fib)
        Me.GroupBox4.Location = New System.Drawing.Point(452, 146)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(239, 60)
        Me.GroupBox4.TabIndex = 202
        Me.GroupBox4.TabStop = False
        '
        'chb_baja
        '
        Me.chb_baja.AutoSize = True
        Me.chb_baja.Location = New System.Drawing.Point(12, 13)
        Me.chb_baja.Name = "chb_baja"
        Me.chb_baja.Size = New System.Drawing.Size(121, 17)
        Me.chb_baja.TabIndex = 0
        Me.chb_baja.Text = "Fecha de baja entre"
        Me.chb_baja.UseVisualStyleBackColor = True
        '
        'dtp_ffb
        '
        Me.dtp_ffb.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_ffb.Enabled = False
        Me.dtp_ffb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ffb.Location = New System.Drawing.Point(130, 34)
        Me.dtp_ffb.Name = "dtp_ffb"
        Me.dtp_ffb.Size = New System.Drawing.Size(101, 20)
        Me.dtp_ffb.TabIndex = 2
        '
        'dtp_fib
        '
        Me.dtp_fib.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fib.Enabled = False
        Me.dtp_fib.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fib.Location = New System.Drawing.Point(12, 31)
        Me.dtp_fib.Name = "dtp_fib"
        Me.dtp_fib.Size = New System.Drawing.Size(101, 20)
        Me.dtp_fib.TabIndex = 1
        '
        'grpFiltrarPorCodigo
        '
        Me.grpFiltrarPorCodigo.Controls.Add(Me.CtrlPacienteHasta)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label2)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.CtrlPacienteDesde)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label1)
        Me.grpFiltrarPorCodigo.Location = New System.Drawing.Point(4, 28)
        Me.grpFiltrarPorCodigo.Name = "grpFiltrarPorCodigo"
        Me.grpFiltrarPorCodigo.Size = New System.Drawing.Size(328, 84)
        Me.grpFiltrarPorCodigo.TabIndex = 196
        Me.grpFiltrarPorCodigo.TabStop = False
        Me.grpFiltrarPorCodigo.Text = "Filtrar pacientes por código"
        '
        'CtrlPacienteHasta
        '
        Me.CtrlPacienteHasta.ID_PACIENTE = Nothing
        Me.CtrlPacienteHasta.Location = New System.Drawing.Point(53, 51)
        Me.CtrlPacienteHasta.Name = "CtrlPacienteHasta"
        Me.CtrlPacienteHasta.Size = New System.Drawing.Size(267, 26)
        Me.CtrlPacienteHasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta"
        '
        'CtrlPacienteDesde
        '
        Me.CtrlPacienteDesde.ID_PACIENTE = Nothing
        Me.CtrlPacienteDesde.Location = New System.Drawing.Point(53, 19)
        Me.CtrlPacienteDesde.Name = "CtrlPacienteDesde"
        Me.CtrlPacienteDesde.Size = New System.Drawing.Size(267, 26)
        Me.CtrlPacienteDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chb_ingreso)
        Me.GroupBox1.Controls.Add(Me.dtp_ff)
        Me.GroupBox1.Controls.Add(Me.dtp_fi)
        Me.GroupBox1.Location = New System.Drawing.Point(452, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 60)
        Me.GroupBox1.TabIndex = 197
        Me.GroupBox1.TabStop = False
        '
        'chb_ingreso
        '
        Me.chb_ingreso.AutoSize = True
        Me.chb_ingreso.Location = New System.Drawing.Point(12, 13)
        Me.chb_ingreso.Name = "chb_ingreso"
        Me.chb_ingreso.Size = New System.Drawing.Size(136, 17)
        Me.chb_ingreso.TabIndex = 1
        Me.chb_ingreso.Text = "Fecha de Ingreso entre"
        Me.chb_ingreso.UseVisualStyleBackColor = True
        '
        'dtp_ff
        '
        Me.dtp_ff.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_ff.Enabled = False
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(130, 33)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(101, 20)
        Me.dtp_ff.TabIndex = 0
        '
        'dtp_fi
        '
        Me.dtp_fi.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fi.Enabled = False
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(12, 33)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(101, 20)
        Me.dtp_fi.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chb_nac)
        Me.GroupBox3.Controls.Add(Me.dtp_ffn)
        Me.GroupBox3.Controls.Add(Me.dtp_fin)
        Me.GroupBox3.Location = New System.Drawing.Point(452, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 60)
        Me.GroupBox3.TabIndex = 200
        Me.GroupBox3.TabStop = False
        '
        'chb_nac
        '
        Me.chb_nac.AutoSize = True
        Me.chb_nac.Location = New System.Drawing.Point(12, 14)
        Me.chb_nac.Name = "chb_nac"
        Me.chb_nac.Size = New System.Drawing.Size(152, 17)
        Me.chb_nac.TabIndex = 0
        Me.chb_nac.Text = "Fecha de nacimiento entre"
        Me.chb_nac.UseVisualStyleBackColor = True
        '
        'dtp_ffn
        '
        Me.dtp_ffn.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_ffn.Enabled = False
        Me.dtp_ffn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ffn.Location = New System.Drawing.Point(130, 31)
        Me.dtp_ffn.Name = "dtp_ffn"
        Me.dtp_ffn.Size = New System.Drawing.Size(101, 20)
        Me.dtp_ffn.TabIndex = 2
        '
        'dtp_fin
        '
        Me.dtp_fin.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fin.Enabled = False
        Me.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fin.Location = New System.Drawing.Point(12, 32)
        Me.dtp_fin.Name = "dtp_fin"
        Me.dtp_fin.Size = New System.Drawing.Size(101, 20)
        Me.dtp_fin.TabIndex = 1
        '
        'frmPacientesListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 684)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpFiltrosEspeciales)
        Me.Controls.Add(Me.btnConfigGrid)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtTop100)
        Me.Controls.Add(Me.grpFiltrarPorNombre)
        Me.Controls.Add(Me.bt_filtrar)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.pnl_Loading)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.CtrlMutua1)
        Me.Controls.Add(Me.CtrlPaises1)
        Me.Controls.Add(Me.CtrlFormaPago21)
        Me.Controls.Add(Me.CtrlEmpresa1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpFiltrarPorCodigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmPacientesListado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Pacientes"
        CType(Me.ListadoPacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpFiltrosEspeciales.ResumeLayout(False)
        Me.grpFiltrosEspeciales.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpFiltrarPorNombre.ResumeLayout(False)
        Me.grpFiltrarPorNombre.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.pnl_Loading.ResumeLayout(False)
        Me.pnl_Loading.PerformLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpFiltrarPorCodigo.ResumeLayout(False)
        Me.grpFiltrarPorCodigo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpFiltrarPorNombre As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As ctrlTextboxAvanzado
    Friend WithEvents txtApellido1 As ctrlTextboxAvanzado
    Friend WithEvents txtNombre As ctrlTextboxAvanzado
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents CtrlPacienteHasta As centro_medico.ctrlPaciente2
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_fallecidos As System.Windows.Forms.CheckBox
    Friend WithEvents rb_fallecno As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fallecsi As System.Windows.Forms.RadioButton
    Friend WithEvents pnl_Loading As System.Windows.Forms.Panel
    Friend WithEvents lnkCancelar As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_Loading As System.Windows.Forms.Label
    Friend WithEvents pb_Loading As System.Windows.Forms.PictureBox
    Friend WithEvents ListadoPacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtrlMutua1 As centro_medico.ctrlMutua
    Friend WithEvents CtrlPaises1 As centro_medico.ctrlPaises
    Friend WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Friend WithEvents CtrlEmpresa1 As centro_medico.ctrlEmpresa
    Friend WithEvents chb_activo As System.Windows.Forms.CheckBox
    Friend WithEvents chb_asoc As System.Windows.Forms.CheckBox
    Friend WithEvents rb_activono As System.Windows.Forms.RadioButton
    Friend WithEvents rb_asocno As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rb_asocsi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_srec As System.Windows.Forms.RadioButton
    Friend WithEvents rb_crec As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todascobrar As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_activosi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_nac As System.Windows.Forms.CheckBox
    Friend WithEvents chb_ingreso As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_ffn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_baja As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_ffb As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fib As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpFiltrarPorCodigo As System.Windows.Forms.GroupBox
    Friend WithEvents CtrlPacienteDesde As centro_medico.ctrlPaciente2
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTop100 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsImporte As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsTotalPacientes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstMsgAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPropio As ctrlTextboxAvanzado
    Friend WithEvents tstMsgSelected As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMovil As ctrlTextboxAvanzado
    Friend WithEvents txtTelefono As ctrlTextboxAvanzado
    Friend WithEvents txtDireccion As ctrlTextboxAvanzado
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDni As ctrlTextboxAvanzado
    Friend WithEvents btnConfigGrid As System.Windows.Forms.Button
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltrosEspeciales As System.Windows.Forms.GroupBox
    Friend WithEvents rbCumple_Hoy As System.Windows.Forms.RadioButton
    Friend WithEvents chkFiltroCumple As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_CantDias As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents rbCumple_Dias As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbTodosEMail As System.Windows.Forms.RadioButton
    Friend WithEvents rbSinEmail As System.Windows.Forms.RadioButton
    Friend WithEvents rbConEMail As System.Windows.Forms.RadioButton
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkSocioActivo As System.Windows.Forms.CheckBox
End Class
