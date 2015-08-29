<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_renumerar
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lb_estado = New System.Windows.Forms.Label
        Me.dgv_facturas = New System.Windows.Forms.DataGridView
        Me.femision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bt_renumerar = New System.Windows.Forms.Button
        Me.nud_inicial = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.bt_factura = New System.Windows.Forms.Button
        Me.tb_factura = New ctrlTextboxAvanzado
        Me.Label1 = New System.Windows.Forms.Label
        Me.cb_serie = New System.Windows.Forms.ComboBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.bt_traspaso = New System.Windows.Forms.Button
        Me.dgv_fact2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codig = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.cb_destino = New System.Windows.Forms.ComboBox
        Me.dgv_fact1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.cb_origen = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
        Me.SERIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERIESTableAdapter = New centro_medico.CMDataSetTableAdapters.SERIESTableAdapter
        Me.bt_cerrar = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_inicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_fact2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_fact1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(807, 443)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dgv_facturas)
        Me.TabPage1.Controls.Add(Me.bt_renumerar)
        Me.TabPage1.Controls.Add(Me.nud_inicial)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.bt_factura)
        Me.TabPage1.Controls.Add(Me.tb_factura)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cb_serie)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(799, 417)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Renumerar facturas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_estado)
        Me.GroupBox1.Location = New System.Drawing.Point(538, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 331)
        Me.GroupBox1.TabIndex = 144
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado del proceso"
        '
        'lb_estado
        '
        Me.lb_estado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_estado.Location = New System.Drawing.Point(6, 20)
        Me.lb_estado.Name = "lb_estado"
        Me.lb_estado.Size = New System.Drawing.Size(246, 308)
        Me.lb_estado.TabIndex = 0
        '
        'dgv_facturas
        '
        Me.dgv_facturas.AllowUserToAddRows = False
        Me.dgv_facturas.AllowUserToDeleteRows = False
        Me.dgv_facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_facturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_facturas.BackgroundColor = System.Drawing.Color.White
        Me.dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.femision, Me.numero, Me.importe, Me.Cod})
        Me.dgv_facturas.Location = New System.Drawing.Point(6, 80)
        Me.dgv_facturas.MultiSelect = False
        Me.dgv_facturas.Name = "dgv_facturas"
        Me.dgv_facturas.ReadOnly = True
        Me.dgv_facturas.RowHeadersWidth = 15
        Me.dgv_facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_facturas.Size = New System.Drawing.Size(525, 331)
        Me.dgv_facturas.TabIndex = 5
        '
        'femision
        '
        Me.femision.HeaderText = "F. Emisión"
        Me.femision.Name = "femision"
        Me.femision.ReadOnly = True
        Me.femision.Width = 80
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Width = 69
        '
        'importe
        '
        Me.importe.HeaderText = "Importe Total"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 94
        '
        'Cod
        '
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Visible = False
        Me.Cod.Width = 65
        '
        'bt_renumerar
        '
        Me.bt_renumerar.Location = New System.Drawing.Point(456, 35)
        Me.bt_renumerar.Name = "bt_renumerar"
        Me.bt_renumerar.Size = New System.Drawing.Size(75, 23)
        Me.bt_renumerar.TabIndex = 4
        Me.bt_renumerar.Text = "Renumerar"
        Me.bt_renumerar.UseVisualStyleBackColor = True
        '
        'nud_inicial
        '
        Me.nud_inicial.Location = New System.Drawing.Point(316, 38)
        Me.nud_inicial.Name = "nud_inicial"
        Me.nud_inicial.Size = New System.Drawing.Size(103, 20)
        Me.nud_inicial.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Nuevo número inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Renumerar desde"
        '
        'bt_factura
        '
        Me.bt_factura.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_factura.Location = New System.Drawing.Point(249, 37)
        Me.bt_factura.Name = "bt_factura"
        Me.bt_factura.Size = New System.Drawing.Size(36, 23)
        Me.bt_factura.TabIndex = 2
        Me.bt_factura.UseVisualStyleBackColor = True
        '
        'tb_factura
        '
        Me.tb_factura.BackColor = System.Drawing.Color.White
        Me.tb_factura.Enabled = False
        Me.tb_factura.Location = New System.Drawing.Point(145, 39)
        Me.tb_factura.Name = "tb_factura"
        Me.tb_factura.ReadOnly = True
        Me.tb_factura.Size = New System.Drawing.Size(107, 20)
        Me.tb_factura.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Serie"
        '
        'cb_serie
        '
        Me.cb_serie.DisplayMember = "CODIGO"
        Me.cb_serie.Location = New System.Drawing.Point(11, 38)
        Me.cb_serie.Name = "cb_serie"
        Me.cb_serie.Size = New System.Drawing.Size(115, 21)
        Me.cb_serie.TabIndex = 0
        Me.cb_serie.ValueMember = "CODIGO"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.bt_traspaso)
        Me.TabPage2.Controls.Add(Me.dgv_fact2)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.cb_destino)
        Me.TabPage2.Controls.Add(Me.dgv_fact1)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.cb_origen)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dtp_fi)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(799, 417)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cambiar Series"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bt_traspaso
        '
        Me.bt_traspaso.Image = Global.centro_medico.My.Resources.Resources._Next
        Me.bt_traspaso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_traspaso.Location = New System.Drawing.Point(347, 388)
        Me.bt_traspaso.Name = "bt_traspaso"
        Me.bt_traspaso.Size = New System.Drawing.Size(122, 23)
        Me.bt_traspaso.TabIndex = 5
        Me.bt_traspaso.Text = "Realizar traspaso"
        Me.bt_traspaso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_traspaso.UseVisualStyleBackColor = True
        '
        'dgv_fact2
        '
        Me.dgv_fact2.AllowUserToAddRows = False
        Me.dgv_fact2.AllowUserToDeleteRows = False
        Me.dgv_fact2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_fact2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_fact2.BackgroundColor = System.Drawing.Color.White
        Me.dgv_fact2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fact2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Codig})
        Me.dgv_fact2.Location = New System.Drawing.Point(414, 128)
        Me.dgv_fact2.MultiSelect = False
        Me.dgv_fact2.Name = "dgv_fact2"
        Me.dgv_fact2.ReadOnly = True
        Me.dgv_fact2.RowHeadersWidth = 15
        Me.dgv_fact2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_fact2.Size = New System.Drawing.Size(382, 258)
        Me.dgv_fact2.TabIndex = 4
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "F. Emisión"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Número"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 69
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Importe Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 94
        '
        'Codig
        '
        Me.Codig.HeaderText = "Código"
        Me.Codig.Name = "Codig"
        Me.Codig.ReadOnly = True
        Me.Codig.Visible = False
        Me.Codig.Width = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(415, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Serie Destino"
        '
        'cb_destino
        '
        Me.cb_destino.DisplayMember = "CODIGO"
        Me.cb_destino.Location = New System.Drawing.Point(414, 86)
        Me.cb_destino.Name = "cb_destino"
        Me.cb_destino.Size = New System.Drawing.Size(115, 21)
        Me.cb_destino.TabIndex = 2
        Me.cb_destino.ValueMember = "CODIGO"
        '
        'dgv_fact1
        '
        Me.dgv_fact1.AllowUserToAddRows = False
        Me.dgv_fact1.AllowUserToDeleteRows = False
        Me.dgv_fact1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_fact1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_fact1.BackgroundColor = System.Drawing.Color.White
        Me.dgv_fact1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fact1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Codigo})
        Me.dgv_fact1.Location = New System.Drawing.Point(6, 128)
        Me.dgv_fact1.Name = "dgv_fact1"
        Me.dgv_fact1.ReadOnly = True
        Me.dgv_fact1.RowHeadersWidth = 15
        Me.dgv_fact1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_fact1.Size = New System.Drawing.Size(384, 258)
        Me.dgv_fact1.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "F. Emisión"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Número"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Importe Total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 94
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        Me.Codigo.Width = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Serie Orígen"
        '
        'cb_origen
        '
        Me.cb_origen.DisplayMember = "CODIGO"
        Me.cb_origen.Location = New System.Drawing.Point(11, 86)
        Me.cb_origen.Name = "cb_origen"
        Me.cb_origen.Size = New System.Drawing.Size(115, 21)
        Me.cb_origen.TabIndex = 1
        Me.cb_origen.ValueMember = "CODIGO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Mostrar a partir de fecha"
        '
        'dtp_fi
        '
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(11, 36)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fi.TabIndex = 0
        '
        'FACTURASBindingSource
        '
        Me.FACTURASBindingSource.DataMember = "FACTURAS"
        Me.FACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FACTURASTableAdapter
        '
        Me.FACTURASTableAdapter.ClearBeforeFill = True
        '
        'SERIESBindingSource
        '
        Me.SERIESBindingSource.DataMember = "SERIES"
        Me.SERIESBindingSource.DataSource = Me.CMDataSet
        '
        'SERIESTableAdapter
        '
        Me.SERIESTableAdapter.ClearBeforeFill = True
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cerrar.Location = New System.Drawing.Point(722, 455)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 28)
        Me.bt_cerrar.TabIndex = 1
        Me.bt_cerrar.Text = "Cerrar"
        Me.bt_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'form_renumerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 491)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "form_renumerar"
        Me.ShowIcon = False
        Me.Text = "Renumerar facturas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_inicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_fact2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_fact1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_serie As System.Windows.Forms.ComboBox
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents SERIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERIESTableAdapter As centro_medico.CMDataSetTableAdapters.SERIESTableAdapter
    Friend WithEvents nud_inicial As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_factura As System.Windows.Forms.Button
    Friend WithEvents tb_factura As ctrlTextboxAvanzado
    Friend WithEvents bt_renumerar As System.Windows.Forms.Button
    Friend WithEvents dgv_facturas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_estado As System.Windows.Forms.Label
    Friend WithEvents dgv_fact2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_destino As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_fact1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_origen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_traspaso As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents femision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codig As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
End Class
