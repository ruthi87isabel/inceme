<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoles))
        Me.ROLESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fixed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ROLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.tc_Items = New System.Windows.Forms.TabControl()
        Me.tb_Items = New System.Windows.Forms.TabPage()
        Me.RolesItem_ResumenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PERMISODataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PERMISOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_ROLESITEMDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolesItem_ResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tst_Permisos = New System.Windows.Forms.ToolStripButton()
        Me.lnk_Exportar = New System.Windows.Forms.LinkLabel()
        Me.lnk_GrantALL = New System.Windows.Forms.LinkLabel()
        Me.lnk_DenyAll = New System.Windows.Forms.LinkLabel()
        Me.ROLESTableAdapter = New centro_medico.CMDataSetTableAdapters.ROLESTableAdapter()
        Me.RolesItem_ResumenTableAdapter = New centro_medico.CMDataSetTableAdapters.RolesItem_ResumenTableAdapter()
        Me.PERMISOSTableAdapter = New centro_medico.CMDataSetTableAdapters.PERMISOSTableAdapter()
        Me.lblInfo = New System.Windows.Forms.Label()
        CType(Me.ROLESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_Items.SuspendLayout()
        Me.tb_Items.SuspendLayout()
        CType(Me.RolesItem_ResumenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERMISOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesItem_ResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ROLESDataGridView
        '
        Me.ROLESDataGridView.AllowUserToAddRows = False
        Me.ROLESDataGridView.AllowUserToDeleteRows = False
        Me.ROLESDataGridView.AllowUserToResizeRows = False
        Me.ROLESDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ROLESDataGridView.AutoGenerateColumns = False
        Me.ROLESDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ROLESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Fixed})
        Me.ROLESDataGridView.DataSource = Me.ROLESBindingSource
        Me.ROLESDataGridView.Location = New System.Drawing.Point(4, 27)
        Me.ROLESDataGridView.MultiSelect = False
        Me.ROLESDataGridView.Name = "ROLESDataGridView"
        Me.ROLESDataGridView.RowHeadersVisible = False
        Me.ROLESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ROLESDataGridView.Size = New System.Drawing.Size(260, 509)
        Me.ROLESDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_ROLE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Fixed
        '
        Me.Fixed.DataPropertyName = "Fixed"
        Me.Fixed.HeaderText = "Fixed"
        Me.Fixed.Name = "Fixed"
        Me.Fixed.Visible = False
        '
        'ROLESBindingSource
        '
        Me.ROLESBindingSource.DataMember = "ROLES"
        Me.ROLESBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tc_Items
        '
        Me.tc_Items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_Items.Controls.Add(Me.tb_Items)
        Me.tc_Items.Location = New System.Drawing.Point(270, 27)
        Me.tc_Items.Name = "tc_Items"
        Me.tc_Items.SelectedIndex = 0
        Me.tc_Items.Size = New System.Drawing.Size(404, 509)
        Me.tc_Items.TabIndex = 2
        '
        'tb_Items
        '
        Me.tb_Items.AutoScroll = True
        Me.tb_Items.Controls.Add(Me.RolesItem_ResumenDataGridView)
        Me.tb_Items.Location = New System.Drawing.Point(4, 22)
        Me.tb_Items.Name = "tb_Items"
        Me.tb_Items.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Items.Size = New System.Drawing.Size(396, 483)
        Me.tb_Items.TabIndex = 0
        Me.tb_Items.Text = "Items"
        Me.tb_Items.UseVisualStyleBackColor = True
        '
        'RolesItem_ResumenDataGridView
        '
        Me.RolesItem_ResumenDataGridView.AllowUserToAddRows = False
        Me.RolesItem_ResumenDataGridView.AllowUserToDeleteRows = False
        Me.RolesItem_ResumenDataGridView.AllowUserToResizeRows = False
        Me.RolesItem_ResumenDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RolesItem_ResumenDataGridView.AutoGenerateColumns = False
        Me.RolesItem_ResumenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RolesItem_ResumenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.ID_PERMISODataGridViewTextBoxColumn6, Me.ID_ROLESITEMDataGridViewTextBoxColumn7})
        Me.RolesItem_ResumenDataGridView.DataSource = Me.RolesItem_ResumenBindingSource
        Me.RolesItem_ResumenDataGridView.Location = New System.Drawing.Point(9, 6)
        Me.RolesItem_ResumenDataGridView.Name = "RolesItem_ResumenDataGridView"
        Me.RolesItem_ResumenDataGridView.RowHeadersVisible = False
        Me.RolesItem_ResumenDataGridView.Size = New System.Drawing.Size(384, 460)
        Me.RolesItem_ResumenDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NombreItem"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nombre de Item"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'ID_PERMISODataGridViewTextBoxColumn6
        '
        Me.ID_PERMISODataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ID_PERMISODataGridViewTextBoxColumn6.DataPropertyName = "ID_PERMISO"
        Me.ID_PERMISODataGridViewTextBoxColumn6.DataSource = Me.PERMISOSBindingSource
        Me.ID_PERMISODataGridViewTextBoxColumn6.DisplayMember = "PERMISO"
        Me.ID_PERMISODataGridViewTextBoxColumn6.HeaderText = "Permiso"
        Me.ID_PERMISODataGridViewTextBoxColumn6.Name = "ID_PERMISODataGridViewTextBoxColumn6"
        Me.ID_PERMISODataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ID_PERMISODataGridViewTextBoxColumn6.ValueMember = "CODIGO"
        Me.ID_PERMISODataGridViewTextBoxColumn6.Width = 50
        '
        'PERMISOSBindingSource
        '
        Me.PERMISOSBindingSource.DataMember = "PERMISOS"
        Me.PERMISOSBindingSource.DataSource = Me.CMDataSet
        '
        'ID_ROLESITEMDataGridViewTextBoxColumn7
        '
        Me.ID_ROLESITEMDataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID_ROLESITEMDataGridViewTextBoxColumn7.DataPropertyName = "ID_ROLESITEM"
        Me.ID_ROLESITEMDataGridViewTextBoxColumn7.HeaderText = "ID_ROLESITEM"
        Me.ID_ROLESITEMDataGridViewTextBoxColumn7.Name = "ID_ROLESITEMDataGridViewTextBoxColumn7"
        Me.ID_ROLESITEMDataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID_ROLESITEMDataGridViewTextBoxColumn7.Visible = False
        '
        'RolesItem_ResumenBindingSource
        '
        Me.RolesItem_ResumenBindingSource.DataMember = "RolesItem_Resumen"
        Me.RolesItem_ResumenBindingSource.DataSource = Me.CMDataSet
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(600, 555)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 3
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.tst_Permisos})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(687, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = Global.centro_medico.My.Resources.Resources.MISC18
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&Añadir Rol"
        '
        'tst_Editar
        '
        Me.tst_Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(23, 22)
        Me.tst_Editar.Text = "&Modificar Rol"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(23, 22)
        Me.tst_Eliminar.Text = "&Eliminar Rol"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Guardar Rol"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tst_Permisos
        '
        Me.tst_Permisos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tst_Permisos.Image = Global.centro_medico.My.Resources.Resources.permisos
        Me.tst_Permisos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Permisos.Name = "tst_Permisos"
        Me.tst_Permisos.Size = New System.Drawing.Size(23, 22)
        Me.tst_Permisos.Text = "&Completar Roles"
        '
        'lnk_Exportar
        '
        Me.lnk_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnk_Exportar.AutoSize = True
        Me.lnk_Exportar.Location = New System.Drawing.Point(621, 539)
        Me.lnk_Exportar.Name = "lnk_Exportar"
        Me.lnk_Exportar.Size = New System.Drawing.Size(46, 13)
        Me.lnk_Exportar.TabIndex = 10
        Me.lnk_Exportar.TabStop = True
        Me.lnk_Exportar.Text = "Exportar"
        '
        'lnk_GrantALL
        '
        Me.lnk_GrantALL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnk_GrantALL.AutoSize = True
        Me.lnk_GrantALL.Location = New System.Drawing.Point(520, 29)
        Me.lnk_GrantALL.Name = "lnk_GrantALL"
        Me.lnk_GrantALL.Size = New System.Drawing.Size(69, 13)
        Me.lnk_GrantALL.TabIndex = 11
        Me.lnk_GrantALL.TabStop = True
        Me.lnk_GrantALL.Text = "Permitir Todo"
        '
        'lnk_DenyAll
        '
        Me.lnk_DenyAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnk_DenyAll.AutoSize = True
        Me.lnk_DenyAll.Location = New System.Drawing.Point(597, 28)
        Me.lnk_DenyAll.Name = "lnk_DenyAll"
        Me.lnk_DenyAll.Size = New System.Drawing.Size(76, 13)
        Me.lnk_DenyAll.TabIndex = 12
        Me.lnk_DenyAll.TabStop = True
        Me.lnk_DenyAll.Text = "Denegar Todo"
        '
        'ROLESTableAdapter
        '
        Me.ROLESTableAdapter.ClearBeforeFill = True
        '
        'RolesItem_ResumenTableAdapter
        '
        Me.RolesItem_ResumenTableAdapter.ClearBeforeFill = True
        '
        'PERMISOSTableAdapter
        '
        Me.PERMISOSTableAdapter.ClearBeforeFill = True
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(4, 539)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(590, 44)
        Me.lblInfo.TabIndex = 13
        Me.lblInfo.Text = "Información adicional"
        '
        'frmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 588)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lnk_DenyAll)
        Me.Controls.Add(Me.lnk_GrantALL)
        Me.Controls.Add(Me.lnk_Exportar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.tc_Items)
        Me.Controls.Add(Me.ROLESDataGridView)
        Me.Name = "frmRoles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roles y Permisos"
        CType(Me.ROLESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_Items.ResumeLayout(False)
        Me.tb_Items.ResumeLayout(False)
        CType(Me.RolesItem_ResumenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERMISOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesItem_ResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ROLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ROLESTableAdapter As centro_medico.CMDataSetTableAdapters.ROLESTableAdapter
    Friend WithEvents ROLESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents tc_Items As System.Windows.Forms.TabControl
    Friend WithEvents tb_Items As System.Windows.Forms.TabPage
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents RolesItem_ResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RolesItem_ResumenTableAdapter As centro_medico.CMDataSetTableAdapters.RolesItem_ResumenTableAdapter
    Friend WithEvents PERMISOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERMISOSTableAdapter As centro_medico.CMDataSetTableAdapters.PERMISOSTableAdapter
    Friend WithEvents RolesItem_ResumenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_PERMISODataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ID_ROLESITEMDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lnk_Exportar As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_GrantALL As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_DenyAll As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fixed As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tst_Permisos As System.Windows.Forms.ToolStripButton
End Class
