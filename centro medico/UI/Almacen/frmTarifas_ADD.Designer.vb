<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifas_ADD
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
        Dim IdTarifaLabel As System.Windows.Forms.Label
        Dim DescripcionTarifaLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabDetalles = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDelConcepto = New System.Windows.Forms.Button
        Me.btnAddConcepto = New System.Windows.Forms.Button
        Me.TarifasResumenDataGridView = New System.Windows.Forms.DataGridView
        Me.IdTarifaTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTarifaTextBox = New System.Windows.Forms.TextBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TarifasResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.TarifasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TarifasTableAdapter = New centro_medico.CMDataSetTableAdapters.TarifasTableAdapter
        Me.TarifasResumenTableAdapter = New centro_medico.CMDataSetTableAdapters.TarifasResumenTableAdapter
        IdTarifaLabel = New System.Windows.Forms.Label
        DescripcionTarifaLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tabDetalles.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TarifasResumenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarifasResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdTarifaLabel
        '
        IdTarifaLabel.AutoSize = True
        IdTarifaLabel.Location = New System.Drawing.Point(26, 23)
        IdTarifaLabel.Name = "IdTarifaLabel"
        IdTarifaLabel.Size = New System.Drawing.Size(49, 13)
        IdTarifaLabel.TabIndex = 8
        IdTarifaLabel.Text = "Id Tarifa:"
        '
        'DescripcionTarifaLabel
        '
        DescripcionTarifaLabel.AutoSize = True
        DescripcionTarifaLabel.Location = New System.Drawing.Point(23, 53)
        DescripcionTarifaLabel.Name = "DescripcionTarifaLabel"
        DescripcionTarifaLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionTarifaLabel.TabIndex = 2
        DescripcionTarifaLabel.Text = "Descripcion:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabDetalles)
        Me.TabControl1.Location = New System.Drawing.Point(1, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(526, 410)
        Me.TabControl1.TabIndex = 0
        '
        'tabDetalles
        '
        Me.tabDetalles.AutoScroll = True
        Me.tabDetalles.Controls.Add(Me.GroupBox1)
        Me.tabDetalles.Controls.Add(IdTarifaLabel)
        Me.tabDetalles.Controls.Add(Me.IdTarifaTextBox)
        Me.tabDetalles.Controls.Add(DescripcionTarifaLabel)
        Me.tabDetalles.Controls.Add(Me.DescripcionTarifaTextBox)
        Me.tabDetalles.Location = New System.Drawing.Point(4, 22)
        Me.tabDetalles.Name = "tabDetalles"
        Me.tabDetalles.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalles.Size = New System.Drawing.Size(518, 384)
        Me.tabDetalles.TabIndex = 0
        Me.tabDetalles.Text = "Detalles"
        Me.tabDetalles.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnDelConcepto)
        Me.GroupBox1.Controls.Add(Me.btnAddConcepto)
        Me.GroupBox1.Controls.Add(Me.TarifasResumenDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 240)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conceptos para la Tarifa"
        '
        'btnDelConcepto
        '
        Me.btnDelConcepto.Enabled = False
        Me.btnDelConcepto.FlatAppearance.BorderSize = 0
        Me.btnDelConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelConcepto.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btnDelConcepto.Location = New System.Drawing.Point(42, 23)
        Me.btnDelConcepto.Name = "btnDelConcepto"
        Me.btnDelConcepto.Size = New System.Drawing.Size(30, 27)
        Me.btnDelConcepto.TabIndex = 10
        Me.btnDelConcepto.UseVisualStyleBackColor = True
        '
        'btnAddConcepto
        '
        Me.btnAddConcepto.FlatAppearance.BorderSize = 0
        Me.btnAddConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddConcepto.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btnAddConcepto.Location = New System.Drawing.Point(12, 23)
        Me.btnAddConcepto.Name = "btnAddConcepto"
        Me.btnAddConcepto.Size = New System.Drawing.Size(30, 27)
        Me.btnAddConcepto.TabIndex = 10
        Me.btnAddConcepto.UseVisualStyleBackColor = True
        '
        'TarifasResumenDataGridView
        '
        Me.TarifasResumenDataGridView.AllowUserToAddRows = False
        Me.TarifasResumenDataGridView.AllowUserToDeleteRows = False
        Me.TarifasResumenDataGridView.AllowUserToResizeRows = False
        Me.TarifasResumenDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TarifasResumenDataGridView.AutoGenerateColumns = False
        Me.TarifasResumenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TarifasResumenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4})
        Me.TarifasResumenDataGridView.DataSource = Me.TarifasResumenBindingSource
        Me.TarifasResumenDataGridView.Location = New System.Drawing.Point(12, 52)
        Me.TarifasResumenDataGridView.MultiSelect = False
        Me.TarifasResumenDataGridView.Name = "TarifasResumenDataGridView"
        Me.TarifasResumenDataGridView.ReadOnly = True
        Me.TarifasResumenDataGridView.RowHeadersVisible = False
        Me.TarifasResumenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TarifasResumenDataGridView.Size = New System.Drawing.Size(464, 182)
        Me.TarifasResumenDataGridView.TabIndex = 9
        '
        'IdTarifaTextBox
        '
        Me.IdTarifaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "IdTarifa", True))
        Me.IdTarifaTextBox.Location = New System.Drawing.Point(81, 20)
        Me.IdTarifaTextBox.Name = "IdTarifaTextBox"
        Me.IdTarifaTextBox.ReadOnly = True
        Me.IdTarifaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTarifaTextBox.TabIndex = 9
        '
        'DescripcionTarifaTextBox
        '
        Me.DescripcionTarifaTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionTarifaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "DescripcionTarifa", True))
        Me.DescripcionTarifaTextBox.Location = New System.Drawing.Point(26, 69)
        Me.DescripcionTarifaTextBox.Multiline = True
        Me.DescripcionTarifaTextBox.Name = "DescripcionTarifaTextBox"
        Me.DescripcionTarifaTextBox.Size = New System.Drawing.Size(483, 49)
        Me.DescripcionTarifaTextBox.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(450, 423)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdTarifa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdTarifa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DescripcionTarifa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DescripcionTarifa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdConceptoFra"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdConceptoFra"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CODIGO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 74
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Importe"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 67
        '
        'TarifasResumenBindingSource
        '
        Me.TarifasResumenBindingSource.DataMember = "TarifasResumen"
        Me.TarifasResumenBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TarifasBindingSource
        '
        Me.TarifasBindingSource.DataMember = "Tarifas"
        Me.TarifasBindingSource.DataSource = Me.CMDataSet
        '
        'TarifasTableAdapter
        '
        Me.TarifasTableAdapter.ClearBeforeFill = True
        '
        'TarifasResumenTableAdapter
        '
        Me.TarifasResumenTableAdapter.ClearBeforeFill = True
        '
        'frmTarifas_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 448)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmTarifas_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Tarifa"
        Me.TabControl1.ResumeLayout(False)
        Me.tabDetalles.ResumeLayout(False)
        Me.tabDetalles.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TarifasResumenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarifasResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabDetalles As System.Windows.Forms.TabPage
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents TarifasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TarifasTableAdapter As centro_medico.CMDataSetTableAdapters.TarifasTableAdapter
    Friend WithEvents IdTarifaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTarifaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TarifasResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TarifasResumenTableAdapter As centro_medico.CMDataSetTableAdapters.TarifasResumenTableAdapter
    Friend WithEvents TarifasResumenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelConcepto As System.Windows.Forms.Button
    Friend WithEvents btnAddConcepto As System.Windows.Forms.Button
End Class
