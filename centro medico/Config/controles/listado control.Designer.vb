<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado_control
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listado_control))
        Me.panel_rigth = New System.Windows.Forms.Panel
        Me.bt_seleccionar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_cerrar = New System.Windows.Forms.Button
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.bt_ver = New System.Windows.Forms.Button
        Me.bt_borrar = New System.Windows.Forms.Button
        Me.bt_modificar = New System.Windows.Forms.Button
        Me.bt_nuevo = New System.Windows.Forms.Button
        Me.bt_refrescar = New System.Windows.Forms.Button
        Me.panel_bottom = New System.Windows.Forms.Panel
        Me.bt_configcolums = New System.Windows.Forms.Button
        Me.nav_listado = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.panel_left = New System.Windows.Forms.Panel
        Me.gv_listado = New System.Windows.Forms.DataGridView
        Me.panel_top = New System.Windows.Forms.Panel
        Me.bt_filtro_avanzado = New System.Windows.Forms.Button
        Me.bt_ultima = New System.Windows.Forms.Button
        Me.bt_primer_registro = New System.Windows.Forms.Button
        Me.gb_ordenar = New System.Windows.Forms.GroupBox
        Me.bt_ordenar = New System.Windows.Forms.Button
        Me.cb_ordenar = New System.Windows.Forms.ComboBox
        Me.gb_intervalo_fechas = New System.Windows.Forms.GroupBox
        Me.dtp_fecha_max = New System.Windows.Forms.DateTimePicker
        Me.dtp_fecha_min = New System.Windows.Forms.DateTimePicker
        Me.cb_tipo_fecha = New System.Windows.Forms.ComboBox
        Me.chb_intervalo = New System.Windows.Forms.CheckBox
        Me.gb_filtrado = New System.Windows.Forms.GroupBox
        Me.lb_hasta = New System.Windows.Forms.Label
        Me.lb_desde = New System.Windows.Forms.Label
        Me.lb_campo = New System.Windows.Forms.Label
        Me.bt_filtrar = New System.Windows.Forms.Button
        Me.tb_hasta = New System.Windows.Forms.TextBox
        Me.tb_desde = New System.Windows.Forms.TextBox
        Me.cb_campos_filtro = New System.Windows.Forms.ComboBox
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
        Me.FORMASPAGOTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
        Me.FORMASPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROVEEDORESTableAdapter = New centro_medico.CMDataSetTableAdapters.PROVEEDORESTableAdapter
        Me.BANCOSTableAdapter = New centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter
        Me.BANCOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFACTURABLESTableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFACTURABLESTableAdapter
        Me.CONCEPTOSFACTURABLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAISESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAISESTableAdapter = New centro_medico.CMDataSetTableAdapters.PAISESTableAdapter
        Me.CONCEPTOSANALITICATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSANALITICATableAdapter
        Me.CONCEPTOSANALITICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLINICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLINICASTableAdapter = New centro_medico.CMDataSetTableAdapters.CLINICASTableAdapter
        Me.ALARMASTableAdapter = New centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter
        Me.ALARMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARTICULOSTableAdapter = New centro_medico.CMDataSetTableAdapters.ARTICULOSTableAdapter
        Me.ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICAMENTOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICAMENTOSTableAdapter
        Me.MEDICAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLANTILLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLANTILLASTableAdapter = New centro_medico.CMDataSetTableAdapters.PLANTILLASTableAdapter
        Me.DIAGNOSTICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIAGNOSTICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter
        Me.GASTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GASTOSTableAdapter = New centro_medico.CMDataSetTableAdapters.GASTOSTableAdapter
        Me.INDICACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICACIONESTableAdapter = New centro_medico.CMDataSetTableAdapters.INDICACIONESTableAdapter
        Me.PLANTILLA_HISTORIALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLANTILLA_HISTORIALESTableAdapter = New centro_medico.CMDataSetTableAdapters.PLANTILLA_HISTORIALESTableAdapter
        Me.BAJASTableAdapter = New centro_medico.CMDataSetTableAdapters.BAJASTableAdapter
        Me.BAJASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALTASTableAdapter = New centro_medico.CMDataSetTableAdapters.ALTASTableAdapter
        Me.PARTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PARTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PARTESTableAdapter
        Me.ASISTENCIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASISTENCIASTableAdapter = New centro_medico.CMDataSetTableAdapters.ASISTENCIASTableAdapter
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
        Me.LMUTUASEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMUTUASEMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.LMUTUASEMPRESASTableAdapter
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
        Me.ANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.ANALITICASTableAdapter
        Me.ANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLANTILLAANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.PLANTILLAANALITICASTableAdapter
        Me.PLANTILLAANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFRATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOSTableAdapter = New centro_medico.CMDataSetTableAdapters.USUARIOSTableAdapter
        Me.RECIBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECIBOSTableAdapter = New centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
        Me.MODELOSCOMPARATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MODELOSCOMPARATIVATableAdapter = New centro_medico.CMDataSetTableAdapters.MODELOSCOMPARATIVATableAdapter
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.DERIVACIONES_DESTINOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DERIVACIONES_DESTINOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DERIVACIONES_DESTINOSTableAdapter
        Me.panel_rigth.SuspendLayout()
        Me.panel_bottom.SuspendLayout()
        CType(Me.nav_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav_listado.SuspendLayout()
        Me.panel_left.SuspendLayout()
        CType(Me.gv_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_top.SuspendLayout()
        Me.gb_ordenar.SuspendLayout()
        Me.gb_intervalo_fechas.SuspendLayout()
        Me.gb_filtrado.SuspendLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BANCOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSFACTURABLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAISESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLINICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTILLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GASTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTILLA_HISTORIALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAJASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PARTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMUTUASEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODELOSCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DERIVACIONES_DESTINOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_rigth
        '
        Me.panel_rigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_rigth.Controls.Add(Me.bt_seleccionar)
        Me.panel_rigth.Controls.Add(Me.bt_cerrar)
        Me.panel_rigth.Controls.Add(Me.bt_imprimir)
        Me.panel_rigth.Controls.Add(Me.bt_ver)
        Me.panel_rigth.Controls.Add(Me.bt_borrar)
        Me.panel_rigth.Controls.Add(Me.bt_modificar)
        Me.panel_rigth.Controls.Add(Me.bt_nuevo)
        Me.panel_rigth.Controls.Add(Me.bt_refrescar)
        Me.panel_rigth.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_rigth.Location = New System.Drawing.Point(735, 83)
        Me.panel_rigth.Name = "panel_rigth"
        Me.panel_rigth.Size = New System.Drawing.Size(106, 434)
        Me.panel_rigth.TabIndex = 7
        '
        'bt_seleccionar
        '
        Me.bt_seleccionar.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.bt_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_seleccionar.ImageIndex = 7
        Me.bt_seleccionar.ImageList = Me.ImageList1
        Me.bt_seleccionar.Location = New System.Drawing.Point(8, 116)
        Me.bt_seleccionar.Name = "bt_seleccionar"
        Me.bt_seleccionar.Size = New System.Drawing.Size(90, 32)
        Me.bt_seleccionar.TabIndex = 1
        Me.bt_seleccionar.Text = "  &Abrir"
        Me.tooltip.SetToolTip(Me.bt_seleccionar, "Seleccionar")
        Me.bt_seleccionar.UseVisualStyleBackColor = False
        Me.bt_seleccionar.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Refresh.png")
        Me.ImageList1.Images.SetKeyName(1, "Document.png")
        Me.ImageList1.Images.SetKeyName(2, "Edit.png")
        Me.ImageList1.Images.SetKeyName(3, "Recyclebin-Full.png")
        Me.ImageList1.Images.SetKeyName(4, "Search.png")
        Me.ImageList1.Images.SetKeyName(5, "Netprinter Connected.ico")
        Me.ImageList1.Images.SetKeyName(6, "Thumbs_Up.ico")
        Me.ImageList1.Images.SetKeyName(7, "Checked.png")
        Me.ImageList1.Images.SetKeyName(8, "Exit.png")
        Me.ImageList1.Images.SetKeyName(9, "Arrow-Left.ico")
        Me.ImageList1.Images.SetKeyName(10, "Arrow-Right.ico")
        Me.ImageList1.Images.SetKeyName(11, "Zoom-in.png")
        Me.ImageList1.Images.SetKeyName(12, "Settings.png")
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.bt_cerrar.Image = Global.centro_medico.My.Resources.Resources.Exit2
        Me.bt_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cerrar.Location = New System.Drawing.Point(8, 321)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(90, 32)
        Me.bt_cerrar.TabIndex = 7
        Me.bt_cerrar.Text = "      &Cerrar"
        Me.tooltip.SetToolTip(Me.bt_cerrar, "Cerrar (alt+C)")
        Me.bt_cerrar.UseVisualStyleBackColor = False
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.ImageIndex = 5
        Me.bt_imprimir.ImageList = Me.ImageList1
        Me.bt_imprimir.Location = New System.Drawing.Point(8, 288)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(90, 32)
        Me.bt_imprimir.TabIndex = 6
        Me.bt_imprimir.Text = "         &Imprimir"
        Me.tooltip.SetToolTip(Me.bt_imprimir, "Imprimir listado (alt+I)")
        Me.bt_imprimir.UseVisualStyleBackColor = False
        '
        'bt_ver
        '
        Me.bt_ver.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.bt_ver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_ver.ImageIndex = 4
        Me.bt_ver.ImageList = Me.ImageList1
        Me.bt_ver.Location = New System.Drawing.Point(8, 252)
        Me.bt_ver.Name = "bt_ver"
        Me.bt_ver.Size = New System.Drawing.Size(90, 32)
        Me.bt_ver.TabIndex = 5
        Me.bt_ver.Text = "    &Ver"
        Me.tooltip.SetToolTip(Me.bt_ver, "Ver el elemento seleccionado (alt+V)")
        Me.bt_ver.UseVisualStyleBackColor = False
        '
        'bt_borrar
        '
        Me.bt_borrar.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.bt_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_borrar.ImageIndex = 3
        Me.bt_borrar.ImageList = Me.ImageList1
        Me.bt_borrar.Location = New System.Drawing.Point(8, 218)
        Me.bt_borrar.Name = "bt_borrar"
        Me.bt_borrar.Size = New System.Drawing.Size(90, 32)
        Me.bt_borrar.TabIndex = 4
        Me.bt_borrar.Text = "      &Borrar"
        Me.tooltip.SetToolTip(Me.bt_borrar, "Borrar el elemento seleccionado (alt+B)")
        Me.bt_borrar.UseVisualStyleBackColor = False
        '
        'bt_modificar
        '
        Me.bt_modificar.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.bt_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_modificar.ImageIndex = 2
        Me.bt_modificar.ImageList = Me.ImageList1
        Me.bt_modificar.Location = New System.Drawing.Point(8, 185)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(90, 32)
        Me.bt_modificar.TabIndex = 3
        Me.bt_modificar.Text = "&Modificar"
        Me.bt_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tooltip.SetToolTip(Me.bt_modificar, "Editar elemento seleccionado (alt+E)")
        Me.bt_modificar.UseVisualStyleBackColor = False
        '
        'bt_nuevo
        '
        Me.bt_nuevo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.bt_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_nuevo.ImageIndex = 1
        Me.bt_nuevo.ImageList = Me.ImageList1
        Me.bt_nuevo.Location = New System.Drawing.Point(8, 152)
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Size = New System.Drawing.Size(90, 32)
        Me.bt_nuevo.TabIndex = 2
        Me.bt_nuevo.Text = "     &Nuevo"
        Me.tooltip.SetToolTip(Me.bt_nuevo, "Añadir un nuevo elemento (alt+N)")
        Me.bt_nuevo.UseVisualStyleBackColor = False
        '
        'bt_refrescar
        '
        Me.bt_refrescar.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.bt_refrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_refrescar.ImageIndex = 0
        Me.bt_refrescar.ImageList = Me.ImageList1
        Me.bt_refrescar.Location = New System.Drawing.Point(8, 81)
        Me.bt_refrescar.Name = "bt_refrescar"
        Me.bt_refrescar.Size = New System.Drawing.Size(90, 32)
        Me.bt_refrescar.TabIndex = 0
        Me.bt_refrescar.Text = "&Refrescar"
        Me.bt_refrescar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tooltip.SetToolTip(Me.bt_refrescar, "Refrescar en red (alt+R)")
        Me.bt_refrescar.UseVisualStyleBackColor = False
        '
        'panel_bottom
        '
        Me.panel_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_bottom.Controls.Add(Me.bt_configcolums)
        Me.panel_bottom.Controls.Add(Me.nav_listado)
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 517)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(841, 53)
        Me.panel_bottom.TabIndex = 8
        '
        'bt_configcolums
        '
        Me.bt_configcolums.BackColor = System.Drawing.Color.Transparent
        Me.bt_configcolums.BackgroundImage = CType(resources.GetObject("bt_configcolums.BackgroundImage"), System.Drawing.Image)
        Me.bt_configcolums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_configcolums.Location = New System.Drawing.Point(3, 9)
        Me.bt_configcolums.Name = "bt_configcolums"
        Me.bt_configcolums.Size = New System.Drawing.Size(51, 37)
        Me.bt_configcolums.TabIndex = 20
        Me.bt_configcolums.UseVisualStyleBackColor = False
        '
        'nav_listado
        '
        Me.nav_listado.AddNewItem = Nothing
        Me.nav_listado.AutoSize = False
        Me.nav_listado.BackColor = System.Drawing.Color.Transparent
        Me.nav_listado.CountItem = Me.ToolStripLabel1
        Me.nav_listado.DeleteItem = Nothing
        Me.nav_listado.Dock = System.Windows.Forms.DockStyle.None
        Me.nav_listado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3})
        Me.nav_listado.Location = New System.Drawing.Point(57, 9)
        Me.nav_listado.MoveFirstItem = Me.ToolStripButton1
        Me.nav_listado.MoveLastItem = Me.ToolStripButton4
        Me.nav_listado.MoveNextItem = Me.ToolStripButton3
        Me.nav_listado.MovePreviousItem = Me.ToolStripButton2
        Me.nav_listado.Name = "nav_listado"
        Me.nav_listado.PositionItem = Me.ToolStripTextBox1
        Me.nav_listado.Size = New System.Drawing.Size(286, 39)
        Me.nav_listado.TabIndex = 1
        Me.nav_listado.Text = "nav_listado"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 36)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 36)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 36)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 36)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'panel_left
        '
        Me.panel_left.AutoScroll = True
        Me.panel_left.Controls.Add(Me.gv_listado)
        Me.panel_left.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_left.Location = New System.Drawing.Point(0, 83)
        Me.panel_left.Name = "panel_left"
        Me.panel_left.Size = New System.Drawing.Size(841, 434)
        Me.panel_left.TabIndex = 9
        '
        'gv_listado
        '
        Me.gv_listado.AllowUserToAddRows = False
        Me.gv_listado.AllowUserToDeleteRows = False
        Me.gv_listado.BackgroundColor = System.Drawing.Color.White
        Me.gv_listado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gv_listado.Location = New System.Drawing.Point(0, 0)
        Me.gv_listado.Name = "gv_listado"
        Me.gv_listado.ReadOnly = True
        Me.gv_listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gv_listado.Size = New System.Drawing.Size(841, 434)
        Me.gv_listado.TabIndex = 0
        '
        'panel_top
        '
        Me.panel_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_top.Controls.Add(Me.bt_filtro_avanzado)
        Me.panel_top.Controls.Add(Me.bt_ultima)
        Me.panel_top.Controls.Add(Me.bt_primer_registro)
        Me.panel_top.Controls.Add(Me.gb_ordenar)
        Me.panel_top.Controls.Add(Me.gb_intervalo_fechas)
        Me.panel_top.Controls.Add(Me.gb_filtrado)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(841, 83)
        Me.panel_top.TabIndex = 6
        '
        'bt_filtro_avanzado
        '
        Me.bt_filtro_avanzado.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.bt_filtro_avanzado.Image = Global.centro_medico.My.Resources.Resources.BINOCULR
        Me.bt_filtro_avanzado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtro_avanzado.Location = New System.Drawing.Point(679, 55)
        Me.bt_filtro_avanzado.Name = "bt_filtro_avanzado"
        Me.bt_filtro_avanzado.Size = New System.Drawing.Size(110, 23)
        Me.bt_filtro_avanzado.TabIndex = 2
        Me.bt_filtro_avanzado.Text = "Filtro avanzado"
        Me.bt_filtro_avanzado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tooltip.SetToolTip(Me.bt_filtro_avanzado, "Filtro avanzado (F3)")
        Me.bt_filtro_avanzado.UseVisualStyleBackColor = False
        '
        'bt_ultima
        '
        Me.bt_ultima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_ultima.ImageIndex = 9
        Me.bt_ultima.ImageList = Me.ImageList1
        Me.bt_ultima.Location = New System.Drawing.Point(789, 55)
        Me.bt_ultima.Name = "bt_ultima"
        Me.bt_ultima.Size = New System.Drawing.Size(33, 23)
        Me.bt_ultima.TabIndex = 2
        Me.tooltip.SetToolTip(Me.bt_ultima, "Ir al último registro ordenado")
        Me.bt_ultima.UseVisualStyleBackColor = False
        '
        'bt_primer_registro
        '
        Me.bt_primer_registro.AccessibleDescription = ""
        Me.bt_primer_registro.AccessibleName = ""
        Me.bt_primer_registro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_primer_registro.ImageIndex = 10
        Me.bt_primer_registro.ImageList = Me.ImageList1
        Me.bt_primer_registro.Location = New System.Drawing.Point(646, 55)
        Me.bt_primer_registro.Name = "bt_primer_registro"
        Me.bt_primer_registro.Size = New System.Drawing.Size(33, 23)
        Me.bt_primer_registro.TabIndex = 2
        Me.tooltip.SetToolTip(Me.bt_primer_registro, "Ir al primer registro ordenado")
        Me.bt_primer_registro.UseVisualStyleBackColor = False
        '
        'gb_ordenar
        '
        Me.gb_ordenar.Controls.Add(Me.bt_ordenar)
        Me.gb_ordenar.Controls.Add(Me.cb_ordenar)
        Me.gb_ordenar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ordenar.ForeColor = System.Drawing.Color.Black
        Me.gb_ordenar.Location = New System.Drawing.Point(646, 3)
        Me.gb_ordenar.Name = "gb_ordenar"
        Me.gb_ordenar.Size = New System.Drawing.Size(176, 49)
        Me.gb_ordenar.TabIndex = 2
        Me.gb_ordenar.TabStop = False
        Me.gb_ordenar.Text = "Ordenar por :"
        '
        'bt_ordenar
        '
        Me.bt_ordenar.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_ordenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_ordenar.ImageIndex = 11
        Me.bt_ordenar.Location = New System.Drawing.Point(135, 12)
        Me.bt_ordenar.Name = "bt_ordenar"
        Me.bt_ordenar.Size = New System.Drawing.Size(33, 32)
        Me.bt_ordenar.TabIndex = 1
        Me.tooltip.SetToolTip(Me.bt_ordenar, "Reordenar")
        Me.bt_ordenar.UseVisualStyleBackColor = False
        '
        'cb_ordenar
        '
        Me.cb_ordenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ordenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_ordenar.FormattingEnabled = True
        Me.cb_ordenar.Location = New System.Drawing.Point(10, 18)
        Me.cb_ordenar.Name = "cb_ordenar"
        Me.cb_ordenar.Size = New System.Drawing.Size(121, 21)
        Me.cb_ordenar.TabIndex = 0
        '
        'gb_intervalo_fechas
        '
        Me.gb_intervalo_fechas.Controls.Add(Me.dtp_fecha_max)
        Me.gb_intervalo_fechas.Controls.Add(Me.dtp_fecha_min)
        Me.gb_intervalo_fechas.Controls.Add(Me.cb_tipo_fecha)
        Me.gb_intervalo_fechas.Controls.Add(Me.chb_intervalo)
        Me.gb_intervalo_fechas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_intervalo_fechas.ForeColor = System.Drawing.Color.Black
        Me.gb_intervalo_fechas.Location = New System.Drawing.Point(392, 3)
        Me.gb_intervalo_fechas.Name = "gb_intervalo_fechas"
        Me.gb_intervalo_fechas.Size = New System.Drawing.Size(248, 75)
        Me.gb_intervalo_fechas.TabIndex = 1
        Me.gb_intervalo_fechas.TabStop = False
        Me.gb_intervalo_fechas.Visible = False
        '
        'dtp_fecha_max
        '
        Me.dtp_fecha_max.Enabled = False
        Me.dtp_fecha_max.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_max.Location = New System.Drawing.Point(126, 46)
        Me.dtp_fecha_max.Name = "dtp_fecha_max"
        Me.dtp_fecha_max.Size = New System.Drawing.Size(115, 20)
        Me.dtp_fecha_max.TabIndex = 3
        '
        'dtp_fecha_min
        '
        Me.dtp_fecha_min.Enabled = False
        Me.dtp_fecha_min.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_min.Location = New System.Drawing.Point(8, 46)
        Me.dtp_fecha_min.Name = "dtp_fecha_min"
        Me.dtp_fecha_min.Size = New System.Drawing.Size(115, 20)
        Me.dtp_fecha_min.TabIndex = 2
        '
        'cb_tipo_fecha
        '
        Me.cb_tipo_fecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo_fecha.Enabled = False
        Me.cb_tipo_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tipo_fecha.FormattingEnabled = True
        Me.cb_tipo_fecha.Location = New System.Drawing.Point(8, 20)
        Me.cb_tipo_fecha.Name = "cb_tipo_fecha"
        Me.cb_tipo_fecha.Size = New System.Drawing.Size(234, 21)
        Me.cb_tipo_fecha.TabIndex = 1
        '
        'chb_intervalo
        '
        Me.chb_intervalo.AutoSize = True
        Me.chb_intervalo.Location = New System.Drawing.Point(8, 0)
        Me.chb_intervalo.Name = "chb_intervalo"
        Me.chb_intervalo.Size = New System.Drawing.Size(137, 18)
        Me.chb_intervalo.TabIndex = 0
        Me.chb_intervalo.Text = "Intervalo de fechas :"
        Me.chb_intervalo.UseVisualStyleBackColor = True
        '
        'gb_filtrado
        '
        Me.gb_filtrado.Controls.Add(Me.lb_hasta)
        Me.gb_filtrado.Controls.Add(Me.lb_desde)
        Me.gb_filtrado.Controls.Add(Me.lb_campo)
        Me.gb_filtrado.Controls.Add(Me.bt_filtrar)
        Me.gb_filtrado.Controls.Add(Me.tb_hasta)
        Me.gb_filtrado.Controls.Add(Me.tb_desde)
        Me.gb_filtrado.Controls.Add(Me.cb_campos_filtro)
        Me.gb_filtrado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_filtrado.ForeColor = System.Drawing.Color.Black
        Me.gb_filtrado.Location = New System.Drawing.Point(3, 3)
        Me.gb_filtrado.Name = "gb_filtrado"
        Me.gb_filtrado.Size = New System.Drawing.Size(383, 75)
        Me.gb_filtrado.TabIndex = 0
        Me.gb_filtrado.TabStop = False
        Me.gb_filtrado.Text = "Filtrar"
        '
        'lb_hasta
        '
        Me.lb_hasta.AutoSize = True
        Me.lb_hasta.Location = New System.Drawing.Point(237, 19)
        Me.lb_hasta.Name = "lb_hasta"
        Me.lb_hasta.Size = New System.Drawing.Size(37, 14)
        Me.lb_hasta.TabIndex = 6
        Me.lb_hasta.Text = "Hasta"
        '
        'lb_desde
        '
        Me.lb_desde.AutoSize = True
        Me.lb_desde.Location = New System.Drawing.Point(130, 19)
        Me.lb_desde.Name = "lb_desde"
        Me.lb_desde.Size = New System.Drawing.Size(42, 14)
        Me.lb_desde.TabIndex = 5
        Me.lb_desde.Text = "Desde"
        '
        'lb_campo
        '
        Me.lb_campo.AutoSize = True
        Me.lb_campo.Location = New System.Drawing.Point(6, 19)
        Me.lb_campo.Name = "lb_campo"
        Me.lb_campo.Size = New System.Drawing.Size(46, 14)
        Me.lb_campo.TabIndex = 4
        Me.lb_campo.Text = "Campo"
        '
        'bt_filtrar
        '
        Me.bt_filtrar.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_filtrar.Location = New System.Drawing.Point(342, 28)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(33, 32)
        Me.bt_filtrar.TabIndex = 3
        Me.tooltip.SetToolTip(Me.bt_filtrar, "Mostrar resultados (F5)")
        Me.bt_filtrar.UseVisualStyleBackColor = False
        '
        'tb_hasta
        '
        Me.tb_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_hasta.Location = New System.Drawing.Point(240, 36)
        Me.tb_hasta.Name = "tb_hasta"
        Me.tb_hasta.Size = New System.Drawing.Size(100, 20)
        Me.tb_hasta.TabIndex = 2
        '
        'tb_desde
        '
        Me.tb_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_desde.Location = New System.Drawing.Point(133, 36)
        Me.tb_desde.Name = "tb_desde"
        Me.tb_desde.Size = New System.Drawing.Size(100, 20)
        Me.tb_desde.TabIndex = 1
        '
        'cb_campos_filtro
        '
        Me.cb_campos_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_campos_filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_campos_filtro.FormattingEnabled = True
        Me.cb_campos_filtro.Location = New System.Drawing.Point(6, 35)
        Me.cb_campos_filtro.Name = "cb_campos_filtro"
        Me.cb_campos_filtro.Size = New System.Drawing.Size(121, 21)
        Me.cb_campos_filtro.TabIndex = 0
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'MEDICOSBindingSource
        '
        Me.MEDICOSBindingSource.DataMember = "MEDICOS"
        Me.MEDICOSBindingSource.DataSource = Me.CMDataSet
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'MUTUASBindingSource
        '
        Me.MUTUASBindingSource.DataMember = "MUTUAS"
        Me.MUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'MUTUASTableAdapter
        '
        Me.MUTUASTableAdapter.ClearBeforeFill = True
        '
        'FORMASPAGOTableAdapter
        '
        Me.FORMASPAGOTableAdapter.ClearBeforeFill = True
        '
        'FORMASPAGOBindingSource
        '
        Me.FORMASPAGOBindingSource.DataMember = "FORMASPAGO"
        Me.FORMASPAGOBindingSource.DataSource = Me.CMDataSet
        '
        'PROVEEDORESBindingSource
        '
        Me.PROVEEDORESBindingSource.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource.DataSource = Me.CMDataSet
        '
        'PROVEEDORESTableAdapter
        '
        Me.PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'BANCOSTableAdapter
        '
        Me.BANCOSTableAdapter.ClearBeforeFill = True
        '
        'BANCOSBindingSource
        '
        Me.BANCOSBindingSource.DataMember = "BANCOS"
        Me.BANCOSBindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSFACTURABLESTableAdapter
        '
        Me.CONCEPTOSFACTURABLESTableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSFACTURABLESBindingSource
        '
        Me.CONCEPTOSFACTURABLESBindingSource.DataMember = "CONCEPTOSFACTURABLES"
        Me.CONCEPTOSFACTURABLESBindingSource.DataSource = Me.CMDataSet
        '
        'PAISESBindingSource
        '
        Me.PAISESBindingSource.DataMember = "PAISES"
        Me.PAISESBindingSource.DataSource = Me.CMDataSet
        '
        'PAISESTableAdapter
        '
        Me.PAISESTableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSANALITICATableAdapter
        '
        Me.CONCEPTOSANALITICATableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSANALITICABindingSource
        '
        Me.CONCEPTOSANALITICABindingSource.DataMember = "CONCEPTOSANALITICA"
        Me.CONCEPTOSANALITICABindingSource.DataSource = Me.CMDataSet
        '
        'CLINICASBindingSource
        '
        Me.CLINICASBindingSource.DataMember = "CLINICAS"
        Me.CLINICASBindingSource.DataSource = Me.CMDataSet
        '
        'CLINICASTableAdapter
        '
        Me.CLINICASTableAdapter.ClearBeforeFill = True
        '
        'ALARMASTableAdapter
        '
        Me.ALARMASTableAdapter.ClearBeforeFill = True
        '
        'ALARMASBindingSource
        '
        Me.ALARMASBindingSource.DataMember = "ALARMAS"
        Me.ALARMASBindingSource.DataSource = Me.CMDataSet
        '
        'ARTICULOSTableAdapter
        '
        Me.ARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'ARTICULOSBindingSource
        '
        Me.ARTICULOSBindingSource.DataMember = "ARTICULOS"
        Me.ARTICULOSBindingSource.DataSource = Me.CMDataSet
        '
        'MEDICAMENTOSTableAdapter
        '
        Me.MEDICAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'MEDICAMENTOSBindingSource
        '
        Me.MEDICAMENTOSBindingSource.DataMember = "MEDICAMENTOS"
        Me.MEDICAMENTOSBindingSource.DataSource = Me.CMDataSet
        '
        'PLANTILLASBindingSource
        '
        Me.PLANTILLASBindingSource.DataMember = "PLANTILLAS"
        Me.PLANTILLASBindingSource.DataSource = Me.CMDataSet
        '
        'PLANTILLASTableAdapter
        '
        Me.PLANTILLASTableAdapter.ClearBeforeFill = True
        '
        'DIAGNOSTICOSBindingSource
        '
        Me.DIAGNOSTICOSBindingSource.DataMember = "DIAGNOSTICOS"
        Me.DIAGNOSTICOSBindingSource.DataSource = Me.CMDataSet
        '
        'DIAGNOSTICOSTableAdapter
        '
        Me.DIAGNOSTICOSTableAdapter.ClearBeforeFill = True
        '
        'GASTOSBindingSource
        '
        Me.GASTOSBindingSource.DataMember = "GASTOS"
        Me.GASTOSBindingSource.DataSource = Me.CMDataSet
        '
        'GASTOSTableAdapter
        '
        Me.GASTOSTableAdapter.ClearBeforeFill = True
        '
        'INDICACIONESBindingSource
        '
        Me.INDICACIONESBindingSource.DataMember = "INDICACIONES"
        Me.INDICACIONESBindingSource.DataSource = Me.CMDataSet
        '
        'INDICACIONESTableAdapter
        '
        Me.INDICACIONESTableAdapter.ClearBeforeFill = True
        '
        'PLANTILLA_HISTORIALESBindingSource
        '
        Me.PLANTILLA_HISTORIALESBindingSource.DataMember = "PLANTILLA_HISTORIALES"
        Me.PLANTILLA_HISTORIALESBindingSource.DataSource = Me.CMDataSet
        '
        'PLANTILLA_HISTORIALESTableAdapter
        '
        Me.PLANTILLA_HISTORIALESTableAdapter.ClearBeforeFill = True
        '
        'BAJASTableAdapter
        '
        Me.BAJASTableAdapter.ClearBeforeFill = True
        '
        'BAJASBindingSource
        '
        Me.BAJASBindingSource.DataMember = "BAJAS"
        Me.BAJASBindingSource.DataSource = Me.CMDataSet
        '
        'ALTASBindingSource
        '
        Me.ALTASBindingSource.DataMember = "ALTAS"
        Me.ALTASBindingSource.DataSource = Me.CMDataSet
        '
        'ALTASTableAdapter
        '
        Me.ALTASTableAdapter.ClearBeforeFill = True
        '
        'PARTESBindingSource
        '
        Me.PARTESBindingSource.DataMember = "PARTES"
        Me.PARTESBindingSource.DataSource = Me.CMDataSet
        '
        'PARTESTableAdapter
        '
        Me.PARTESTableAdapter.ClearBeforeFill = True
        '
        'ASISTENCIASBindingSource
        '
        Me.ASISTENCIASBindingSource.DataMember = "ASISTENCIAS"
        Me.ASISTENCIASBindingSource.DataSource = Me.CMDataSet
        '
        'ASISTENCIASTableAdapter
        '
        Me.ASISTENCIASTableAdapter.ClearBeforeFill = True
        '
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'EMPRESASTableAdapter
        '
        Me.EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'LMUTUASEMPRESASBindingSource
        '
        Me.LMUTUASEMPRESASBindingSource.DataMember = "LMUTUASEMPRESAS"
        Me.LMUTUASEMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'LMUTUASEMPRESASTableAdapter
        '
        Me.LMUTUASEMPRESASTableAdapter.ClearBeforeFill = True
        '
        'FACTURASBindingSource
        '
        Me.FACTURASBindingSource.DataMember = "FACTURAS"
        Me.FACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'FACTURASTableAdapter
        '
        Me.FACTURASTableAdapter.ClearBeforeFill = True
        '
        'ANALITICASTableAdapter
        '
        Me.ANALITICASTableAdapter.ClearBeforeFill = True
        '
        'ANALITICASBindingSource
        '
        Me.ANALITICASBindingSource.DataMember = "ANALITICAS"
        Me.ANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'PLANTILLAANALITICASTableAdapter
        '
        Me.PLANTILLAANALITICASTableAdapter.ClearBeforeFill = True
        '
        'PLANTILLAANALITICASBindingSource
        '
        Me.PLANTILLAANALITICASBindingSource.DataMember = "PLANTILLAANALITICAS"
        Me.PLANTILLAANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSFRABindingSource
        '
        Me.CONCEPTOSFRABindingSource.DataMember = "CONCEPTOSFRA"
        Me.CONCEPTOSFRABindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSFRATableAdapter
        '
        Me.CONCEPTOSFRATableAdapter.ClearBeforeFill = True
        '
        'USUARIOSBindingSource
        '
        Me.USUARIOSBindingSource.DataMember = "USUARIOS"
        Me.USUARIOSBindingSource.DataSource = Me.CMDataSet
        '
        'USUARIOSTableAdapter
        '
        Me.USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'RECIBOSBindingSource
        '
        Me.RECIBOSBindingSource.DataMember = "RECIBOS"
        Me.RECIBOSBindingSource.DataSource = Me.CMDataSet
        '
        'RECIBOSTableAdapter
        '
        Me.RECIBOSTableAdapter.ClearBeforeFill = True
        '
        'MODELOSCOMPARATIVABindingSource
        '
        Me.MODELOSCOMPARATIVABindingSource.DataMember = "MODELOSCOMPARATIVA"
        Me.MODELOSCOMPARATIVABindingSource.DataSource = Me.CMDataSet
        '
        'MODELOSCOMPARATIVATableAdapter
        '
        Me.MODELOSCOMPARATIVATableAdapter.ClearBeforeFill = True
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'DERIVACIONES_DESTINOSBindingSource
        '
        Me.DERIVACIONES_DESTINOSBindingSource.DataMember = "DERIVACIONES_DESTINOS"
        Me.DERIVACIONES_DESTINOSBindingSource.DataSource = Me.CMDataSet
        '
        'DERIVACIONES_DESTINOSTableAdapter
        '
        Me.DERIVACIONES_DESTINOSTableAdapter.ClearBeforeFill = True
        '
        'listado_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel_rigth)
        Me.Controls.Add(Me.panel_left)
        Me.Controls.Add(Me.panel_top)
        Me.Controls.Add(Me.panel_bottom)
        Me.Name = "listado_control"
        Me.Size = New System.Drawing.Size(841, 570)
        Me.panel_rigth.ResumeLayout(False)
        Me.panel_bottom.ResumeLayout(False)
        CType(Me.nav_listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav_listado.ResumeLayout(False)
        Me.nav_listado.PerformLayout()
        Me.panel_left.ResumeLayout(False)
        CType(Me.gv_listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_top.ResumeLayout(False)
        Me.gb_ordenar.ResumeLayout(False)
        Me.gb_intervalo_fechas.ResumeLayout(False)
        Me.gb_intervalo_fechas.PerformLayout()
        Me.gb_filtrado.ResumeLayout(False)
        Me.gb_filtrado.PerformLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BANCOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSFACTURABLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAISESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLINICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTILLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GASTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTILLA_HISTORIALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAJASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PARTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMUTUASEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODELOSCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DERIVACIONES_DESTINOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents bt_refrescar As System.Windows.Forms.Button
    Friend WithEvents panel_rigth As System.Windows.Forms.Panel
    Friend WithEvents panel_bottom As System.Windows.Forms.Panel
    Friend WithEvents panel_left As System.Windows.Forms.Panel
    Friend WithEvents panel_top As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents MEDICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
    Friend WithEvents FORMASPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROVEEDORESTableAdapter As centro_medico.CMDataSetTableAdapters.PROVEEDORESTableAdapter
    Friend WithEvents BANCOSTableAdapter As centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter
    Friend WithEvents BANCOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFACTURABLESTableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFACTURABLESTableAdapter
    Friend WithEvents CONCEPTOSFACTURABLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PAISESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PAISESTableAdapter As centro_medico.CMDataSetTableAdapters.PAISESTableAdapter
    Friend WithEvents CONCEPTOSANALITICATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSANALITICATableAdapter
    Friend WithEvents CONCEPTOSANALITICABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLINICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLINICASTableAdapter As centro_medico.CMDataSetTableAdapters.CLINICASTableAdapter
    Friend WithEvents ALARMASTableAdapter As centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter
    Friend WithEvents ALARMASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOSTableAdapter As centro_medico.CMDataSetTableAdapters.ARTICULOSTableAdapter
    Friend WithEvents ARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents bt_seleccionar As System.Windows.Forms.Button
    Friend WithEvents MEDICAMENTOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICAMENTOSTableAdapter
    Friend WithEvents MEDICAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLANTILLASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLANTILLASTableAdapter As centro_medico.CMDataSetTableAdapters.PLANTILLASTableAdapter
    Friend WithEvents DIAGNOSTICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIAGNOSTICOSTableAdapter As centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter
    Friend WithEvents GASTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GASTOSTableAdapter As centro_medico.CMDataSetTableAdapters.GASTOSTableAdapter
    Friend WithEvents INDICACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INDICACIONESTableAdapter As centro_medico.CMDataSetTableAdapters.INDICACIONESTableAdapter
    Friend WithEvents PLANTILLA_HISTORIALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLANTILLA_HISTORIALESTableAdapter As centro_medico.CMDataSetTableAdapters.PLANTILLA_HISTORIALESTableAdapter
    Friend WithEvents BAJASTableAdapter As centro_medico.CMDataSetTableAdapters.BAJASTableAdapter
    Friend WithEvents BAJASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALTASTableAdapter As centro_medico.CMDataSetTableAdapters.ALTASTableAdapter
    Friend WithEvents PARTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PARTESTableAdapter As centro_medico.CMDataSetTableAdapters.PARTESTableAdapter
    Friend WithEvents ASISTENCIASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASISTENCIASTableAdapter As centro_medico.CMDataSetTableAdapters.ASISTENCIASTableAdapter
    Friend WithEvents gb_intervalo_fechas As System.Windows.Forms.GroupBox
    Friend WithEvents gb_filtrado As System.Windows.Forms.GroupBox
    Friend WithEvents gb_ordenar As System.Windows.Forms.GroupBox
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents tb_hasta As System.Windows.Forms.TextBox
    Friend WithEvents tb_desde As System.Windows.Forms.TextBox
    Friend WithEvents cb_campos_filtro As System.Windows.Forms.ComboBox
    Friend WithEvents lb_hasta As System.Windows.Forms.Label
    Friend WithEvents lb_desde As System.Windows.Forms.Label
    Friend WithEvents lb_campo As System.Windows.Forms.Label
    Friend WithEvents chb_intervalo As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_fecha_max As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_min As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_tipo_fecha As System.Windows.Forms.ComboBox
    Friend WithEvents bt_ordenar As System.Windows.Forms.Button
    Friend WithEvents cb_ordenar As System.Windows.Forms.ComboBox
    Friend WithEvents bt_filtro_avanzado As System.Windows.Forms.Button
    Friend WithEvents bt_ultima As System.Windows.Forms.Button
    Friend WithEvents bt_primer_registro As System.Windows.Forms.Button
    Friend WithEvents tooltip As System.Windows.Forms.ToolTip
    Friend WithEvents nav_listado As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents LMUTUASEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUASEMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.LMUTUASEMPRESASTableAdapter
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents ANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.ANALITICASTableAdapter
    Friend WithEvents ANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLANTILLAANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.PLANTILLAANALITICASTableAdapter
    Friend WithEvents PLANTILLAANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFRABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFRATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter
    Friend WithEvents USUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USUARIOSTableAdapter As centro_medico.CMDataSetTableAdapters.USUARIOSTableAdapter
    Friend WithEvents RECIBOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECIBOSTableAdapter As centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
    Friend WithEvents MODELOSCOMPARATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MODELOSCOMPARATIVATableAdapter As centro_medico.CMDataSetTableAdapters.MODELOSCOMPARATIVATableAdapter
    Public WithEvents bt_ver As System.Windows.Forms.Button
    Public WithEvents bt_borrar As System.Windows.Forms.Button
    Public WithEvents bt_modificar As System.Windows.Forms.Button
    Public WithEvents bt_nuevo As System.Windows.Forms.Button
    Friend WithEvents bt_configcolums As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DERIVACIONES_DESTINOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DERIVACIONES_DESTINOSTableAdapter As centro_medico.CMDataSetTableAdapters.DERIVACIONES_DESTINOSTableAdapter
    Friend WithEvents gv_listado As System.Windows.Forms.DataGridView

End Class
