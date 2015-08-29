<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsolidacionStock_ADD
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim StockActualLabel As System.Windows.Forms.Label
        Dim UnidadesContadasLabel As System.Windows.Forms.Label
        Dim RestarAUnidadesContadasLabel As System.Windows.Forms.Label
        Dim DisponiblesLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.tc_Ficha = New System.Windows.Forms.TabControl
        Me.tb_Ficha = New System.Windows.Forms.TabPage
        Me.btn_CalcularStock = New System.Windows.Forms.Button
        Me.N_AlmacenComboBox = New System.Windows.Forms.ComboBox
        Me.N_Articulos_ConsolidacionStockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.N_AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlArticulo1 = New centro_medico.ctrlArticulo
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.StockActualTextBox = New ctrlTextboxAvanzado
        Me.UnidadesContadasTextBox = New ctrlTextboxAvanzado
        Me.RestarAUnidadesContadasCheckBox = New System.Windows.Forms.CheckBox
        Me.DisponiblesTextBox = New ctrlTextboxAvanzado
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.N_Articulos_ConsolidacionStockTableAdapter = New centro_medico.CMDataSetTableAdapters.N_Articulos_ConsolidacionStockTableAdapter
        Me.N_AlmacenTableAdapter = New centro_medico.CMDataSetTableAdapters.N_AlmacenTableAdapter
        FechaLabel = New System.Windows.Forms.Label
        StockActualLabel = New System.Windows.Forms.Label
        UnidadesContadasLabel = New System.Windows.Forms.Label
        RestarAUnidadesContadasLabel = New System.Windows.Forms.Label
        DisponiblesLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Me.tc_Ficha.SuspendLayout()
        Me.tb_Ficha.SuspendLayout()
        CType(Me.N_Articulos_ConsolidacionStockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(83, 103)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 6
        FechaLabel.Text = "Fecha:"
        '
        'StockActualLabel
        '
        StockActualLabel.AutoSize = True
        StockActualLabel.Location = New System.Drawing.Point(52, 141)
        StockActualLabel.Name = "StockActualLabel"
        StockActualLabel.Size = New System.Drawing.Size(71, 13)
        StockActualLabel.TabIndex = 8
        StockActualLabel.Text = "Stock Actual:"
        '
        'UnidadesContadasLabel
        '
        UnidadesContadasLabel.AutoSize = True
        UnidadesContadasLabel.Location = New System.Drawing.Point(20, 182)
        UnidadesContadasLabel.Name = "UnidadesContadasLabel"
        UnidadesContadasLabel.Size = New System.Drawing.Size(103, 13)
        UnidadesContadasLabel.TabIndex = 10
        UnidadesContadasLabel.Text = "Unidades Contadas:"
        '
        'RestarAUnidadesContadasLabel
        '
        RestarAUnidadesContadasLabel.Location = New System.Drawing.Point(331, 117)
        RestarAUnidadesContadasLabel.Name = "RestarAUnidadesContadasLabel"
        RestarAUnidadesContadasLabel.Size = New System.Drawing.Size(164, 41)
        RestarAUnidadesContadasLabel.TabIndex = 12
        RestarAUnidadesContadasLabel.Text = "Restar a las ""UnidadesContadas"" los pedidos de clientes pendientes a enviar"
        RestarAUnidadesContadasLabel.Visible = False
        '
        'DisponiblesLabel
        '
        DisponiblesLabel.Location = New System.Drawing.Point(211, 182)
        DisponiblesLabel.Name = "DisponiblesLabel"
        DisponiblesLabel.Size = New System.Drawing.Size(129, 13)
        DisponiblesLabel.TabIndex = 14
        DisponiblesLabel.Text = "Disponibles a Consolidar:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(72, 39)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 13)
        Label1.TabIndex = 10
        Label1.Text = "Almacen:"
        '
        'tc_Ficha
        '
        Me.tc_Ficha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_Ficha.Controls.Add(Me.tb_Ficha)
        Me.tc_Ficha.Location = New System.Drawing.Point(2, 12)
        Me.tc_Ficha.Name = "tc_Ficha"
        Me.tc_Ficha.SelectedIndex = 0
        Me.tc_Ficha.Size = New System.Drawing.Size(503, 265)
        Me.tc_Ficha.TabIndex = 0
        '
        'tb_Ficha
        '
        Me.tb_Ficha.AutoScroll = True
        Me.tb_Ficha.Controls.Add(Me.btn_CalcularStock)
        Me.tb_Ficha.Controls.Add(Me.N_AlmacenComboBox)
        Me.tb_Ficha.Controls.Add(Me.CtrlArticulo1)
        Me.tb_Ficha.Controls.Add(FechaLabel)
        Me.tb_Ficha.Controls.Add(Me.FechaDateTimePicker)
        Me.tb_Ficha.Controls.Add(StockActualLabel)
        Me.tb_Ficha.Controls.Add(Me.StockActualTextBox)
        Me.tb_Ficha.Controls.Add(Label1)
        Me.tb_Ficha.Controls.Add(UnidadesContadasLabel)
        Me.tb_Ficha.Controls.Add(Me.UnidadesContadasTextBox)
        Me.tb_Ficha.Controls.Add(RestarAUnidadesContadasLabel)
        Me.tb_Ficha.Controls.Add(Me.RestarAUnidadesContadasCheckBox)
        Me.tb_Ficha.Controls.Add(DisponiblesLabel)
        Me.tb_Ficha.Controls.Add(Me.DisponiblesTextBox)
        Me.tb_Ficha.Location = New System.Drawing.Point(4, 22)
        Me.tb_Ficha.Name = "tb_Ficha"
        Me.tb_Ficha.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Ficha.Size = New System.Drawing.Size(495, 239)
        Me.tb_Ficha.TabIndex = 0
        Me.tb_Ficha.Text = "Ficha"
        Me.tb_Ficha.UseVisualStyleBackColor = True
        '
        'btn_CalcularStock
        '
        Me.btn_CalcularStock.Image = Global.centro_medico.My.Resources.Resources._24_book_blue
        Me.btn_CalcularStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CalcularStock.Location = New System.Drawing.Point(202, 133)
        Me.btn_CalcularStock.Name = "btn_CalcularStock"
        Me.btn_CalcularStock.Size = New System.Drawing.Size(74, 29)
        Me.btn_CalcularStock.TabIndex = 17
        Me.btn_CalcularStock.Text = "Calcular"
        Me.btn_CalcularStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CalcularStock.UseVisualStyleBackColor = True
        Me.btn_CalcularStock.Visible = False
        '
        'N_AlmacenComboBox
        '
        Me.N_AlmacenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_Articulos_ConsolidacionStockBindingSource, "ID_Almacen", True))
        Me.N_AlmacenComboBox.DataSource = Me.N_AlmacenBindingSource
        Me.N_AlmacenComboBox.DisplayMember = "Descripcion"
        Me.N_AlmacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.N_AlmacenComboBox.Location = New System.Drawing.Point(129, 37)
        Me.N_AlmacenComboBox.Name = "N_AlmacenComboBox"
        Me.N_AlmacenComboBox.Size = New System.Drawing.Size(197, 21)
        Me.N_AlmacenComboBox.TabIndex = 16
        Me.N_AlmacenComboBox.ValueMember = "ID_Almacen"
        '
        'N_Articulos_ConsolidacionStockBindingSource
        '
        Me.N_Articulos_ConsolidacionStockBindingSource.DataMember = "N_Articulos_ConsolidacionStock"
        Me.N_Articulos_ConsolidacionStockBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_AlmacenBindingSource
        '
        Me.N_AlmacenBindingSource.DataMember = "N_Almacen"
        Me.N_AlmacenBindingSource.DataSource = Me.CMDataSet
        '
        'CtrlArticulo1
        '
        Me.CtrlArticulo1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Articulo", Me.N_Articulos_ConsolidacionStockBindingSource, "ID_Articulo", True))
        Me.CtrlArticulo1.ID_Articulo = Nothing
        Me.CtrlArticulo1.Location = New System.Drawing.Point(74, 64)
        Me.CtrlArticulo1.Name = "CtrlArticulo1"
        Me.CtrlArticulo1.Size = New System.Drawing.Size(370, 29)
        Me.CtrlArticulo1.TabIndex = 16
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.N_Articulos_ConsolidacionStockBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(129, 99)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(81, 20)
        Me.FechaDateTimePicker.TabIndex = 7
        '
        'StockActualTextBox
        '
        Me.StockActualTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.StockActualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Articulos_ConsolidacionStockBindingSource, "StockActual", True))
        Me.StockActualTextBox.Location = New System.Drawing.Point(129, 138)
        Me.StockActualTextBox.Name = "StockActualTextBox"
        Me.StockActualTextBox.ReadOnly = True
        Me.StockActualTextBox.Size = New System.Drawing.Size(67, 20)
        Me.StockActualTextBox.TabIndex = 9
        '
        'UnidadesContadasTextBox
        '
        Me.UnidadesContadasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Articulos_ConsolidacionStockBindingSource, "UnidadesContadas", True))
        Me.UnidadesContadasTextBox.Location = New System.Drawing.Point(129, 179)
        Me.UnidadesContadasTextBox.Name = "UnidadesContadasTextBox"
        Me.UnidadesContadasTextBox.Size = New System.Drawing.Size(67, 20)
        Me.UnidadesContadasTextBox.TabIndex = 11
        '
        'RestarAUnidadesContadasCheckBox
        '
        Me.RestarAUnidadesContadasCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_Articulos_ConsolidacionStockBindingSource, "RestarAUnidadesContadas", True))
        Me.RestarAUnidadesContadasCheckBox.Location = New System.Drawing.Point(317, 130)
        Me.RestarAUnidadesContadasCheckBox.Name = "RestarAUnidadesContadasCheckBox"
        Me.RestarAUnidadesContadasCheckBox.Size = New System.Drawing.Size(21, 24)
        Me.RestarAUnidadesContadasCheckBox.TabIndex = 13
        Me.RestarAUnidadesContadasCheckBox.Visible = False
        '
        'DisponiblesTextBox
        '
        Me.DisponiblesTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.DisponiblesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Articulos_ConsolidacionStockBindingSource, "Disponibles", True))
        Me.DisponiblesTextBox.Location = New System.Drawing.Point(346, 179)
        Me.DisponiblesTextBox.Name = "DisponiblesTextBox"
        Me.DisponiblesTextBox.ReadOnly = True
        Me.DisponiblesTextBox.Size = New System.Drawing.Size(67, 20)
        Me.DisponiblesTextBox.TabIndex = 15
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(430, 283)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 1
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'N_Articulos_ConsolidacionStockTableAdapter
        '
        Me.N_Articulos_ConsolidacionStockTableAdapter.ClearBeforeFill = True
        '
        'N_AlmacenTableAdapter
        '
        Me.N_AlmacenTableAdapter.ClearBeforeFill = True
        '
        'frmConsolidacionStock_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 310)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.tc_Ficha)
        Me.Name = "frmConsolidacionStock_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consolidación de Inventario"
        Me.tc_Ficha.ResumeLayout(False)
        Me.tb_Ficha.ResumeLayout(False)
        Me.tb_Ficha.PerformLayout()
        CType(Me.N_Articulos_ConsolidacionStockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tc_Ficha As System.Windows.Forms.TabControl
    Friend WithEvents tb_Ficha As System.Windows.Forms.TabPage
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_Articulos_ConsolidacionStockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Articulos_ConsolidacionStockTableAdapter As CMDataSetTableAdapters.N_Articulos_ConsolidacionStockTableAdapter
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StockActualTextBox As ctrlTextboxAvanzado
    Friend WithEvents UnidadesContadasTextBox As ctrlTextboxAvanzado
    Friend WithEvents RestarAUnidadesContadasCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DisponiblesTextBox As ctrlTextboxAvanzado
    Friend WithEvents CtrlArticulo1 As ctrlArticulo
    Friend WithEvents N_AlmacenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_AlmacenTableAdapter As CMDataSetTableAdapters.N_AlmacenTableAdapter
    Friend WithEvents N_AlmacenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btn_CalcularStock As System.Windows.Forms.Button
End Class
