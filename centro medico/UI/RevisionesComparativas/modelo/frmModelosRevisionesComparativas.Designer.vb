<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModelosRevisionesComparativas
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tstDuplicarModelo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstModelo = New System.Windows.Forms.ToolStripTextBox()
        Me.MODELOSCOMPARATIVADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELOSCOMPARATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.MODELOSCOMPARATIVATableAdapter = New centro_medico.CMDataSetTableAdapters.MODELOSCOMPARATIVATableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.MODELOSCOMPARATIVADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODELOSCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tstDuplicarModelo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir, Me.ToolStripLabel1, Me.tstModelo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(757, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(58, 22)
        Me.NewToolStripButton.Text = "&Añadir"
        '
        'tstDuplicarModelo
        '
        Me.tstDuplicarModelo.Image = Global.centro_medico.My.Resources.Resources._24_imageset_add
        Me.tstDuplicarModelo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstDuplicarModelo.Name = "tstDuplicarModelo"
        Me.tstDuplicarModelo.Size = New System.Drawing.Size(102, 22)
        Me.tstDuplicarModelo.Text = "Duplicar modelo"
        '
        'tst_Editar
        '
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(70, 22)
        Me.tst_Editar.Text = "&Modificar"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(63, 22)
        Me.tst_Eliminar.Text = "&Eliminar"
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
        Me.tlbImprimir.Size = New System.Drawing.Size(65, 22)
        Me.tlbImprimir.Text = "Imprimir"
        Me.tlbImprimir.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel1.Text = "Modelo:"
        '
        'tstModelo
        '
        Me.tstModelo.Name = "tstModelo"
        Me.tstModelo.Size = New System.Drawing.Size(100, 25)
        '
        'MODELOSCOMPARATIVADataGridView
        '
        Me.MODELOSCOMPARATIVADataGridView.AllowUserToAddRows = False
        Me.MODELOSCOMPARATIVADataGridView.AllowUserToDeleteRows = False
        Me.MODELOSCOMPARATIVADataGridView.AllowUserToResizeRows = False
        Me.MODELOSCOMPARATIVADataGridView.AutoGenerateColumns = False
        Me.MODELOSCOMPARATIVADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MODELOSCOMPARATIVADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.MODELOSCOMPARATIVADataGridView.DataSource = Me.MODELOSCOMPARATIVABindingSource
        Me.MODELOSCOMPARATIVADataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MODELOSCOMPARATIVADataGridView.Location = New System.Drawing.Point(0, 25)
        Me.MODELOSCOMPARATIVADataGridView.Name = "MODELOSCOMPARATIVADataGridView"
        Me.MODELOSCOMPARATIVADataGridView.ReadOnly = True
        Me.MODELOSCOMPARATIVADataGridView.RowHeadersVisible = False
        Me.MODELOSCOMPARATIVADataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MODELOSCOMPARATIVADataGridView.Size = New System.Drawing.Size(757, 414)
        Me.MODELOSCOMPARATIVADataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CODIGO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MODELO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MODELO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'MODELOSCOMPARATIVABindingSource
        '
        Me.MODELOSCOMPARATIVABindingSource.DataMember = "MODELOSCOMPARATIVA"
        Me.MODELOSCOMPARATIVABindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MODELOSCOMPARATIVATableAdapter
        '
        Me.MODELOSCOMPARATIVATableAdapter.ClearBeforeFill = True
        '
        'frmModelosRevisionesComparativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 439)
        Me.Controls.Add(Me.MODELOSCOMPARATIVADataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmModelosRevisionesComparativas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modelos de Comparativas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.MODELOSCOMPARATIVADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODELOSCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents MODELOSCOMPARATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MODELOSCOMPARATIVATableAdapter As centro_medico.CMDataSetTableAdapters.MODELOSCOMPARATIVATableAdapter
    Friend WithEvents MODELOSCOMPARATIVADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents tstDuplicarModelo As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstModelo As System.Windows.Forms.ToolStripTextBox
End Class
