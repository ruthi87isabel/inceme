<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_medicos
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_medicos))
        Me.PACIENTESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.tst_Codigo = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.tst_NombreMEDICO = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tst_Apellido1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.tst_Apellido2 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.tst_Especialidad = New System.Windows.Forms.ToolStripTextBox
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
        Me.MEDICOSDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PACIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PACIENTESBindingNavigator.SuspendLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PACIENTESBindingNavigator
        '
        Me.PACIENTESBindingNavigator.AddNewItem = Nothing
        Me.PACIENTESBindingNavigator.CountItem = Nothing
        Me.PACIENTESBindingNavigator.DeleteItem = Nothing
        Me.PACIENTESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tst_Codigo, Me.ToolStripLabel3, Me.tst_NombreMEDICO, Me.ToolStripLabel1, Me.tst_Apellido1, Me.ToolStripLabel5, Me.tst_Apellido2, Me.ToolStripLabel4, Me.tst_Especialidad})
        Me.PACIENTESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PACIENTESBindingNavigator.MoveFirstItem = Nothing
        Me.PACIENTESBindingNavigator.MoveLastItem = Nothing
        Me.PACIENTESBindingNavigator.MoveNextItem = Nothing
        Me.PACIENTESBindingNavigator.MovePreviousItem = Nothing
        Me.PACIENTESBindingNavigator.Name = "PACIENTESBindingNavigator"
        Me.PACIENTESBindingNavigator.PositionItem = Nothing
        Me.PACIENTESBindingNavigator.Size = New System.Drawing.Size(917, 25)
        Me.PACIENTESBindingNavigator.TabIndex = 3
        Me.PACIENTESBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel2.Text = "CODIGO:"
        '
        'tst_Codigo
        '
        Me.tst_Codigo.Name = "tst_Codigo"
        Me.tst_Codigo.Size = New System.Drawing.Size(60, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel3.Text = "Nombre:"
        '
        'tst_NombreMEDICO
        '
        Me.tst_NombreMEDICO.Name = "tst_NombreMEDICO"
        Me.tst_NombreMEDICO.Size = New System.Drawing.Size(110, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel1.Text = "Apellido 1:"
        '
        'tst_Apellido1
        '
        Me.tst_Apellido1.Name = "tst_Apellido1"
        Me.tst_Apellido1.Size = New System.Drawing.Size(120, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel5.Text = "Apellido 2:"
        '
        'tst_Apellido2
        '
        Me.tst_Apellido2.Name = "tst_Apellido2"
        Me.tst_Apellido2.Size = New System.Drawing.Size(120, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripLabel4.Text = "Especialidad:"
        '
        'tst_Especialidad
        '
        Me.tst_Especialidad.Name = "tst_Especialidad"
        Me.tst_Especialidad.Size = New System.Drawing.Size(130, 25)
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MEDICOSDataGridView
        '
        Me.MEDICOSDataGridView.AllowUserToAddRows = False
        Me.MEDICOSDataGridView.AllowUserToDeleteRows = False
        Me.MEDICOSDataGridView.AutoGenerateColumns = False
        Me.MEDICOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MEDICOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.MEDICOSDataGridView.DataSource = Me.MEDICOSBindingSource
        Me.MEDICOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MEDICOSDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.MEDICOSDataGridView.MultiSelect = False
        Me.MEDICOSDataGridView.Name = "MEDICOSDataGridView"
        Me.MEDICOSDataGridView.ReadOnly = True
        Me.MEDICOSDataGridView.RowHeadersVisible = False
        Me.MEDICOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MEDICOSDataGridView.Size = New System.Drawing.Size(917, 591)
        Me.MEDICOSDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CMEDICO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 74
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "APELLIDO1"
        Me.DataGridViewTextBoxColumn2.HeaderText = "APELLIDO1"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "APELLIDO2"
        Me.DataGridViewTextBoxColumn3.HeaderText = "APELLIDO2"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DOMICILIO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DOMICILIO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TLFNO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TLFNO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MOVIL"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MOVIL"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LOCALIDAD"
        Me.DataGridViewTextBoxColumn7.HeaderText = "LOCALIDAD"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CP"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CP"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PROVINCIA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PROVINCIA"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "COLEGIADO"
        Me.DataGridViewTextBoxColumn11.HeaderText = "COLEGIADO"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ESPECIALIDAD"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ESPECIALIDAD"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "OBSERVACIONES"
        Me.DataGridViewTextBoxColumn14.HeaderText = "OBSERVACIONES"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'form_medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 616)
        Me.Controls.Add(Me.MEDICOSDataGridView)
        Me.Controls.Add(Me.PACIENTESBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_medicos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Médicos"
        CType(Me.PACIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PACIENTESBindingNavigator.ResumeLayout(False)
        Me.PACIENTESBindingNavigator.PerformLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PACIENTESBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tst_Codigo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tst_NombreMEDICO As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tst_Apellido1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tst_Apellido2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tst_Especialidad As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents MEDICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MEDICOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
