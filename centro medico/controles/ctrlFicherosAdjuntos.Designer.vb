<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlFicherosAdjuntos
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
        Me.FICHEROSDataGridView = New System.Windows.Forms.DataGridView
        Me.CODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REFPACIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECHAMODIFICACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FICHERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOTASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCRIPCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FICHEROSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.FICHEROSTableAdapter = New centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Edit = New System.Windows.Forms.Button
        Me.btn_ADD = New System.Windows.Forms.Button
        CType(Me.FICHEROSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FICHEROSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FICHEROSDataGridView
        '
        Me.FICHEROSDataGridView.AllowUserToAddRows = False
        Me.FICHEROSDataGridView.AllowUserToDeleteRows = False
        Me.FICHEROSDataGridView.AllowUserToResizeRows = False
        Me.FICHEROSDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FICHEROSDataGridView.AutoGenerateColumns = False
        Me.FICHEROSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FICHEROSDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.FICHEROSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGODataGridViewTextBoxColumn, Me.REFPACIENTEDataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn, Me.FECHAMODIFICACIONDataGridViewTextBoxColumn, Me.FICHERODataGridViewTextBoxColumn, Me.NOTASDataGridViewTextBoxColumn, Me.DESCRIPCIONDataGridViewTextBoxColumn})
        Me.FICHEROSDataGridView.DataSource = Me.FICHEROSBindingSource1
        Me.FICHEROSDataGridView.Location = New System.Drawing.Point(0, 18)
        Me.FICHEROSDataGridView.MultiSelect = False
        Me.FICHEROSDataGridView.Name = "FICHEROSDataGridView"
        Me.FICHEROSDataGridView.ReadOnly = True
        Me.FICHEROSDataGridView.RowHeadersVisible = False
        Me.FICHEROSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FICHEROSDataGridView.Size = New System.Drawing.Size(271, 123)
        Me.FICHEROSDataGridView.TabIndex = 1
        '
        'CODIGODataGridViewTextBoxColumn
        '
        Me.CODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO"
        Me.CODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.CODIGODataGridViewTextBoxColumn.Name = "CODIGODataGridViewTextBoxColumn"
        Me.CODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CODIGODataGridViewTextBoxColumn.Visible = False
        '
        'REFPACIENTEDataGridViewTextBoxColumn
        '
        Me.REFPACIENTEDataGridViewTextBoxColumn.DataPropertyName = "REFPACIENTE"
        Me.REFPACIENTEDataGridViewTextBoxColumn.HeaderText = "REFPACIENTE"
        Me.REFPACIENTEDataGridViewTextBoxColumn.Name = "REFPACIENTEDataGridViewTextBoxColumn"
        Me.REFPACIENTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.REFPACIENTEDataGridViewTextBoxColumn.Visible = False
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHADataGridViewTextBoxColumn.Visible = False
        '
        'FECHAMODIFICACIONDataGridViewTextBoxColumn
        '
        Me.FECHAMODIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "FECHAMODIFICACION"
        Me.FECHAMODIFICACIONDataGridViewTextBoxColumn.HeaderText = "FECHAMODIFICACION"
        Me.FECHAMODIFICACIONDataGridViewTextBoxColumn.Name = "FECHAMODIFICACIONDataGridViewTextBoxColumn"
        Me.FECHAMODIFICACIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAMODIFICACIONDataGridViewTextBoxColumn.Visible = False
        '
        'FICHERODataGridViewTextBoxColumn
        '
        Me.FICHERODataGridViewTextBoxColumn.DataPropertyName = "FICHERO"
        Me.FICHERODataGridViewTextBoxColumn.HeaderText = "Fichero"
        Me.FICHERODataGridViewTextBoxColumn.Name = "FICHERODataGridViewTextBoxColumn"
        Me.FICHERODataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOTASDataGridViewTextBoxColumn
        '
        Me.NOTASDataGridViewTextBoxColumn.DataPropertyName = "NOTAS"
        Me.NOTASDataGridViewTextBoxColumn.HeaderText = "NOTAS"
        Me.NOTASDataGridViewTextBoxColumn.Name = "NOTASDataGridViewTextBoxColumn"
        Me.NOTASDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOTASDataGridViewTextBoxColumn.Visible = False
        '
        'DESCRIPCIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Name = "DESCRIPCIONDataGridViewTextBoxColumn"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FICHEROSBindingSource1
        '
        Me.FICHEROSBindingSource1.DataMember = "FICHEROS"
        Me.FICHEROSBindingSource1.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FICHEROSTableAdapter
        '
        Me.FICHEROSTableAdapter.ClearBeforeFill = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.FlatAppearance.BorderSize = 0
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Location = New System.Drawing.Point(255, 0)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(16, 16)
        Me.btn_Eliminar.TabIndex = 4
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Edit.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Edit.Enabled = False
        Me.btn_Edit.FlatAppearance.BorderSize = 0
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Location = New System.Drawing.Point(233, 0)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(16, 16)
        Me.btn_Edit.TabIndex = 3
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_ADD
        '
        Me.btn_ADD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ADD.BackgroundImage = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btn_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ADD.FlatAppearance.BorderSize = 0
        Me.btn_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ADD.Location = New System.Drawing.Point(211, 0)
        Me.btn_ADD.Name = "btn_ADD"
        Me.btn_ADD.Size = New System.Drawing.Size(16, 16)
        Me.btn_ADD.TabIndex = 2
        Me.btn_ADD.UseVisualStyleBackColor = True
        '
        'ctrlFicherosAdjuntos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_ADD)
        Me.Controls.Add(Me.FICHEROSDataGridView)
        Me.Name = "ctrlFicherosAdjuntos"
        Me.Size = New System.Drawing.Size(271, 142)
        CType(Me.FICHEROSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FICHEROSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FICHEROSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FICHEROSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents FICHEROSTableAdapter As centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_ADD As System.Windows.Forms.Button
    Friend WithEvents CODIGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFPACIENTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAMODIFICACIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FICHERODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
