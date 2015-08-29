<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComoConocio
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
        Me.dtg_comoconocio = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComoConocioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsl_descripcion = New System.Windows.Forms.ToolStripLabel()
        Me.tst_Descripcion = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ComoConocioTableAdapter = New centro_medico.CMDataSetTableAdapters.ComoConocioTableAdapter()
        CType(Me.dtg_comoconocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComoConocioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtg_comoconocio
        '
        Me.dtg_comoconocio.AllowDrop = True
        Me.dtg_comoconocio.AllowUserToAddRows = False
        Me.dtg_comoconocio.AllowUserToDeleteRows = False
        Me.dtg_comoconocio.AllowUserToResizeRows = False
        Me.dtg_comoconocio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_comoconocio.AutoGenerateColumns = False
        Me.dtg_comoconocio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_comoconocio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DescripcionDataGridViewTextBoxColumn})
        Me.dtg_comoconocio.DataSource = Me.ComoConocioBindingSource
        Me.dtg_comoconocio.Location = New System.Drawing.Point(4, 25)
        Me.dtg_comoconocio.MultiSelect = False
        Me.dtg_comoconocio.Name = "dtg_comoconocio"
        Me.dtg_comoconocio.ReadOnly = True
        Me.dtg_comoconocio.RowHeadersVisible = False
        Me.dtg_comoconocio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_comoconocio.Size = New System.Drawing.Size(541, 510)
        Me.dtg_comoconocio.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDConocio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDConocio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComoConocioBindingSource
        '
        Me.ComoConocioBindingSource.DataMember = "ComoConocio"
        Me.ComoConocioBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tsl_descripcion, Me.tst_Descripcion, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(550, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = Global.centro_medico.My.Resources.Resources.MISC18
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.NewToolStripButton.Text = "&Añadir"
        '
        'tst_Editar
        '
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar.Text = "&Modificar"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsl_descripcion
        '
        Me.tsl_descripcion.Name = "tsl_descripcion"
        Me.tsl_descripcion.Size = New System.Drawing.Size(93, 22)
        Me.tsl_descripcion.Text = "Por Descripción:"
        '
        'tst_Descripcion
        '
        Me.tst_Descripcion.Name = "tst_Descripcion"
        Me.tst_Descripcion.Size = New System.Drawing.Size(140, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel2.Text = "     "
        '
        'ComoConocioTableAdapter
        '
        Me.ComoConocioTableAdapter.ClearBeforeFill = True
        '
        'frmComoConocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 559)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dtg_comoconocio)
        Me.Name = "frmComoConocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Como nos conoció"
        CType(Me.dtg_comoconocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComoConocioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents dtg_comoconocio As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsl_descripcion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tst_Descripcion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ComoConocioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComoConocioTableAdapter As centro_medico.CMDataSetTableAdapters.ComoConocioTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
