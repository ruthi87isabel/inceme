<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoblaciones
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
        Me.N_PoblacionesFULLDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_PoblacionesFULLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tst_Nombre = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tst_Provincia = New System.Windows.Forms.ToolStripTextBox()
        Me.N_PoblacionesFULLTableAdapter = New centro_medico.CMDataSetTableAdapters.N_PoblacionesFULLTableAdapter()
        CType(Me.N_PoblacionesFULLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_PoblacionesFULLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'N_PoblacionesFULLDataGridView
        '
        Me.N_PoblacionesFULLDataGridView.AllowDrop = True
        Me.N_PoblacionesFULLDataGridView.AllowUserToAddRows = False
        Me.N_PoblacionesFULLDataGridView.AllowUserToDeleteRows = False
        Me.N_PoblacionesFULLDataGridView.AllowUserToResizeRows = False
        Me.N_PoblacionesFULLDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_PoblacionesFULLDataGridView.AutoGenerateColumns = False
        Me.N_PoblacionesFULLDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.N_PoblacionesFULLDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.Provincia, Me.Pais})
        Me.N_PoblacionesFULLDataGridView.DataSource = Me.N_PoblacionesFULLBindingSource
        Me.N_PoblacionesFULLDataGridView.Location = New System.Drawing.Point(4, 25)
        Me.N_PoblacionesFULLDataGridView.MultiSelect = False
        Me.N_PoblacionesFULLDataGridView.Name = "N_PoblacionesFULLDataGridView"
        Me.N_PoblacionesFULLDataGridView.ReadOnly = True
        Me.N_PoblacionesFULLDataGridView.RowHeadersVisible = False
        Me.N_PoblacionesFULLDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_PoblacionesFULLDataGridView.Size = New System.Drawing.Size(541, 510)
        Me.N_PoblacionesFULLDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Poblacion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Poblacion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_Provincia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID_Provincia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_Pais"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID_Pais"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'Provincia
        '
        Me.Provincia.DataPropertyName = "Provincia"
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.ReadOnly = True
        '
        'Pais
        '
        Me.Pais.DataPropertyName = "Pais"
        Me.Pais.HeaderText = "Pais"
        Me.Pais.Name = "Pais"
        Me.Pais.ReadOnly = True
        '
        'N_PoblacionesFULLBindingSource
        '
        Me.N_PoblacionesFULLBindingSource.DataMember = "N_PoblacionesFULL"
        Me.N_PoblacionesFULLBindingSource.DataSource = Me.CMDataSet
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.tst_Nombre, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.tst_Provincia})
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
        Me.tst_Eliminar.Text = "&Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripLabel1.Text = "Por Nombre:"
        '
        'tst_Nombre
        '
        Me.tst_Nombre.Name = "tst_Nombre"
        Me.tst_Nombre.Size = New System.Drawing.Size(140, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel2.Text = "     "
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel3.Text = "Provincia:"
        '
        'tst_Provincia
        '
        Me.tst_Provincia.Name = "tst_Provincia"
        Me.tst_Provincia.Size = New System.Drawing.Size(140, 23)
        '
        'N_PoblacionesFULLTableAdapter
        '
        Me.N_PoblacionesFULLTableAdapter.ClearBeforeFill = True
        '
        'frmPoblaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 559)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.N_PoblacionesFULLDataGridView)
        Me.Name = "frmPoblaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Poblaciones"
        CType(Me.N_PoblacionesFULLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_PoblacionesFULLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_PoblacionesFULLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_PoblacionesFULLTableAdapter As CMDataSetTableAdapters.N_PoblacionesFULLTableAdapter
    Friend WithEvents N_PoblacionesFULLDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pais As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tst_Nombre As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tst_Provincia As System.Windows.Forms.ToolStripTextBox
End Class
