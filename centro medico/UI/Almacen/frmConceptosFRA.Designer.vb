<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConceptosFRA
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.CONCEPTOSFRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFRATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter
        Me.CONCEPTOSFRADataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSFRADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(397, 25)
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
        Me.NewToolStripButton.Text = "&New"
        Me.NewToolStripButton.Visible = False
        '
        'tst_Editar
        '
        Me.tst_Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(23, 22)
        Me.tst_Editar.Text = "ToolStripButton2"
        Me.tst_Editar.Visible = False
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(23, 22)
        Me.tst_Eliminar.Text = "ToolStripButton1"
        Me.tst_Eliminar.Visible = False
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CONCEPTOSFRADataGridView
        '
        Me.CONCEPTOSFRADataGridView.AllowUserToAddRows = False
        Me.CONCEPTOSFRADataGridView.AllowUserToDeleteRows = False
        Me.CONCEPTOSFRADataGridView.AllowUserToResizeRows = False
        Me.CONCEPTOSFRADataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CONCEPTOSFRADataGridView.AutoGenerateColumns = False
        Me.CONCEPTOSFRADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CONCEPTOSFRADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CONCEPTOSFRADataGridView.DataSource = Me.CONCEPTOSFRABindingSource
        Me.CONCEPTOSFRADataGridView.Location = New System.Drawing.Point(0, 28)
        Me.CONCEPTOSFRADataGridView.MultiSelect = False
        Me.CONCEPTOSFRADataGridView.Name = "CONCEPTOSFRADataGridView"
        Me.CONCEPTOSFRADataGridView.ReadOnly = True
        Me.CONCEPTOSFRADataGridView.RowHeadersVisible = False
        Me.CONCEPTOSFRADataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CONCEPTOSFRADataGridView.Size = New System.Drawing.Size(397, 570)
        Me.CONCEPTOSFRADataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CODIGO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 74
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IMPORTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IMPORTE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 81
        '
        'frmConceptosFRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 599)
        Me.Controls.Add(Me.CONCEPTOSFRADataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmConceptosFRA"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSFRADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CONCEPTOSFRABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFRATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter
    Friend WithEvents CONCEPTOSFRADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
