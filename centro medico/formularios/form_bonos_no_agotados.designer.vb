<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_bonos_no_agotados
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
        Me.gb_generarRecibos = New System.Windows.Forms.GroupBox()
        Me.dtg_recibos = New System.Windows.Forms.DataGridView()
        Me.PACIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.bt_generar = New System.Windows.Forms.Button()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBonosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesLibresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListadoPacientesTableAdapter1 = New centro_medico.CM2DataSetTableAdapters.ListadoPacientesTableAdapter()
        Me.PACIENTESBONOSTableAdapter = New centro_medico.CM2DataSetTableAdapters.PacientesBonosTableAdapter()
        Me.gb_generarRecibos.SuspendLayout()
        CType(Me.dtg_recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_generarRecibos
        '
        Me.gb_generarRecibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_generarRecibos.Controls.Add(Me.dtg_recibos)
        Me.gb_generarRecibos.Location = New System.Drawing.Point(5, 3)
        Me.gb_generarRecibos.Name = "gb_generarRecibos"
        Me.gb_generarRecibos.Size = New System.Drawing.Size(712, 448)
        Me.gb_generarRecibos.TabIndex = 0
        Me.gb_generarRecibos.TabStop = False
        Me.gb_generarRecibos.Text = "Imprimir pacientes con bonos no agotados"
        '
        'dtg_recibos
        '
        Me.dtg_recibos.AllowUserToAddRows = False
        Me.dtg_recibos.AllowUserToDeleteRows = False
        Me.dtg_recibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_recibos.AutoGenerateColumns = False
        Me.dtg_recibos.BackgroundColor = System.Drawing.Color.White
        Me.dtg_recibos.ColumnHeadersHeight = 28
        Me.dtg_recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtg_recibos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDO1DataGridViewTextBoxColumn, Me.APELLIDO2DataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.FECHANDataGridViewTextBoxColumn, Me.TotalBonosDataGridViewTextBoxColumn, Me.SesionesLibresDataGridViewTextBoxColumn})
        Me.dtg_recibos.DataSource = Me.PACIENTEBindingSource
        Me.dtg_recibos.Location = New System.Drawing.Point(12, 33)
        Me.dtg_recibos.Name = "dtg_recibos"
        Me.dtg_recibos.ReadOnly = True
        Me.dtg_recibos.RowHeadersVisible = False
        Me.dtg_recibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_recibos.Size = New System.Drawing.Size(689, 377)
        Me.dtg_recibos.TabIndex = 4
        '
        'PACIENTEBindingSource
        '
        Me.PACIENTEBindingSource.DataSource = GetType(centro_medico.PACIENTE)
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bt_generar
        '
        Me.bt_generar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_generar.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_generar.Location = New System.Drawing.Point(552, 457)
        Me.bt_generar.Name = "bt_generar"
        Me.bt_generar.Size = New System.Drawing.Size(73, 30)
        Me.bt_generar.TabIndex = 1
        Me.bt_generar.Text = "Imprimir"
        Me.bt_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_generar.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(631, 457)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 30)
        Me.bt_cancelar.TabIndex = 2
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'APELLIDO1DataGridViewTextBoxColumn
        '
        Me.APELLIDO1DataGridViewTextBoxColumn.DataPropertyName = "APELLIDO1"
        Me.APELLIDO1DataGridViewTextBoxColumn.HeaderText = "APELLIDO1"
        Me.APELLIDO1DataGridViewTextBoxColumn.Name = "APELLIDO1DataGridViewTextBoxColumn"
        Me.APELLIDO1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'APELLIDO2DataGridViewTextBoxColumn
        '
        Me.APELLIDO2DataGridViewTextBoxColumn.DataPropertyName = "APELLIDO2"
        Me.APELLIDO2DataGridViewTextBoxColumn.HeaderText = "APELLIDO2"
        Me.APELLIDO2DataGridViewTextBoxColumn.Name = "APELLIDO2DataGridViewTextBoxColumn"
        Me.APELLIDO2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHANDataGridViewTextBoxColumn
        '
        Me.FECHANDataGridViewTextBoxColumn.DataPropertyName = "FECHAN"
        Me.FECHANDataGridViewTextBoxColumn.HeaderText = "FECHA NAC"
        Me.FECHANDataGridViewTextBoxColumn.Name = "FECHANDataGridViewTextBoxColumn"
        Me.FECHANDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalBonosDataGridViewTextBoxColumn
        '
        Me.TotalBonosDataGridViewTextBoxColumn.DataPropertyName = "TotalBonos"
        Me.TotalBonosDataGridViewTextBoxColumn.HeaderText = "BONOS"
        Me.TotalBonosDataGridViewTextBoxColumn.Name = "TotalBonosDataGridViewTextBoxColumn"
        Me.TotalBonosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SesionesLibresDataGridViewTextBoxColumn
        '
        Me.SesionesLibresDataGridViewTextBoxColumn.DataPropertyName = "SesionesLibres"
        Me.SesionesLibresDataGridViewTextBoxColumn.HeaderText = "SESIONES"
        Me.SesionesLibresDataGridViewTextBoxColumn.Name = "SesionesLibresDataGridViewTextBoxColumn"
        Me.SesionesLibresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListadoPacientesTableAdapter1
        '
        Me.ListadoPacientesTableAdapter1.ClearBeforeFill = True
        '
        'form_bonos_no_agotados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(724, 518)
        Me.Controls.Add(Me.bt_generar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.gb_generarRecibos)
        Me.Name = "form_bonos_no_agotados"
        Me.ShowIcon = False
        Me.Text = "Bonos no agotados"
        Me.gb_generarRecibos.ResumeLayout(False)
        CType(Me.dtg_recibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_generar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents gb_generarRecibos As System.Windows.Forms.GroupBox
    Friend WithEvents dtg_recibos As System.Windows.Forms.DataGridView
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PACIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListadoPacientesTableAdapter1 As centro_medico.CM2DataSetTableAdapters.ListadoPacientesTableAdapter
    Friend WithEvents PACIENTESBONOSTableAdapter As centro_medico.CM2DataSetTableAdapters.PacientesBonosTableAdapter
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalBonosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesLibresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
