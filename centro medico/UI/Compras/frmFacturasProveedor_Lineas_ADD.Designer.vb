<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasProveedor_Lineas_ADD
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim Descuento1Label As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim ID_TipoIVALabel As System.Windows.Forms.Label
        Dim IVAIncluidoLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CMDataSet = New CMDataSet
        Me.N_FacturasRecibidas_LineasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_FacturasRecibidas_LineasTableAdapter = New CMDataSetTableAdapters.N_FacturasRecibidas_LineasTableAdapter
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.CantidadTextBox = New System.Windows.Forms.TextBox
        Me.PrecioTextBox = New System.Windows.Forms.TextBox
        Me.Descuento1TextBox = New System.Windows.Forms.TextBox
        Me.Descuento2TextBox = New System.Windows.Forms.TextBox
        Me.Descuento3TextBox = New System.Windows.Forms.TextBox
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tb_Ficha = New System.Windows.Forms.TabPage
        Me.pb_Articulo_Delete = New System.Windows.Forms.PictureBox
        Me.pb_SeleccionarArticulo = New System.Windows.Forms.PictureBox
        Me.tb_Observaciones = New System.Windows.Forms.TabPage
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox
        Me.IVAIncluidoCheckBox = New System.Windows.Forms.CheckBox
        Me.CostoTextBox = New System.Windows.Forms.TextBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Detalles = New System.Windows.Forms.Button
        Me.N_TipoIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_TipoIVATableAdapter = New CMDataSetTableAdapters.N_TipoIVATableAdapter
        Me.N_TipoIVAComboBox = New System.Windows.Forms.ComboBox
        Me.btn_Imagen = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pb_EliminarSerie = New System.Windows.Forms.PictureBox
        Me.pb_NuevaSerie = New System.Windows.Forms.PictureBox
        Me.N_FacturasRecibidas_LotesDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.N_FacturasRecibidas_LotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_FacturasRecibidas_LotesTableAdapter = New CMDataSetTableAdapters.N_FacturasRecibidas_LotesTableAdapter
        Me.N_AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_AlmacenTableAdapter = New CMDataSetTableAdapters.N_AlmacenTableAdapter
        Me.N_AlmacenComboBox = New System.Windows.Forms.ComboBox
        CodigoLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        CantidadLabel = New System.Windows.Forms.Label
        PrecioLabel = New System.Windows.Forms.Label
        Descuento1Label = New System.Windows.Forms.Label
        TotalLabel = New System.Windows.Forms.Label
        ID_TipoIVALabel = New System.Windows.Forms.Label
        IVAIncluidoLabel = New System.Windows.Forms.Label
        CostoLabel = New System.Windows.Forms.Label
        ObservacionesLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_FacturasRecibidas_LineasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tb_Ficha.SuspendLayout()
        CType(Me.pb_Articulo_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_SeleccionarArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_Observaciones.SuspendLayout()
        CType(Me.N_TipoIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pb_EliminarSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_NuevaSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_FacturasRecibidas_LotesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_FacturasRecibidas_LotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(18, 20)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(83, 13)
        CodigoLabel.TabIndex = 6
        CodigoLabel.Text = "Código Artículo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(121, 20)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 10
        DescripcionLabel.Text = "Descripcion:"
        '
        'CantidadLabel
        '
        CantidadLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(484, 20)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 12
        CantidadLabel.Text = "Cantidad:"
        '
        'PrecioLabel
        '
        PrecioLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(542, 20)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 14
        PrecioLabel.Text = "Precio:"
        '
        'Descuento1Label
        '
        Descuento1Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Descuento1Label.AutoSize = True
        Descuento1Label.Location = New System.Drawing.Point(595, 20)
        Descuento1Label.Name = "Descuento1Label"
        Descuento1Label.Size = New System.Drawing.Size(32, 13)
        Descuento1Label.TabIndex = 16
        Descuento1Label.Text = "Dtos:"
        '
        'TotalLabel
        '
        TotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(641, 20)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 22
        TotalLabel.Text = "Total:"
        '
        'ID_TipoIVALabel
        '
        ID_TipoIVALabel.AutoSize = True
        ID_TipoIVALabel.Location = New System.Drawing.Point(29, 80)
        ID_TipoIVALabel.Name = "ID_TipoIVALabel"
        ID_TipoIVALabel.Size = New System.Drawing.Size(51, 13)
        ID_TipoIVALabel.TabIndex = 33
        ID_TipoIVALabel.Text = "Tipo IVA:"
        '
        'IVAIncluidoLabel
        '
        IVAIncluidoLabel.AutoSize = True
        IVAIncluidoLabel.Location = New System.Drawing.Point(14, 108)
        IVAIncluidoLabel.Name = "IVAIncluidoLabel"
        IVAIncluidoLabel.Size = New System.Drawing.Size(66, 13)
        IVAIncluidoLabel.TabIndex = 35
        IVAIncluidoLabel.Text = "IVA incluido:"
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(43, 136)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(37, 13)
        CostoLabel.TabIndex = 37
        CostoLabel.Text = "Costo:"
        CostoLabel.Visible = False
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(26, 19)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 39
        ObservacionesLabel.Text = "Observaciones:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(211, 19)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(111, 13)
        Label1.TabIndex = 33
        Label1.Text = "Números Serie / Lote:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(23, 19)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 13)
        Label2.TabIndex = 33
        Label2.Text = "Otros Datos:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(83, 192)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(51, 13)
        Label3.TabIndex = 6
        Label3.Text = "Almacén:"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_FacturasRecibidas_LineasBindingSource
        '
        Me.N_FacturasRecibidas_LineasBindingSource.DataMember = "N_FacturasRecibidas_Lineas"
        Me.N_FacturasRecibidas_LineasBindingSource.DataSource = Me.CMDataSet
        '
        'N_FacturasRecibidas_LineasTableAdapter
        '
        Me.N_FacturasRecibidas_LineasTableAdapter.ClearBeforeFill = True
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturasRecibidas_LineasBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(21, 36)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.CodigoTextBox.TabIndex = 7
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturasRecibidas_LineasBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(124, 36)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescripcionTextBox.Size = New System.Drawing.Size(348, 93)
        Me.DescripcionTextBox.TabIndex = 11
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturasRecibidas_LineasBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(487, 36)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(49, 20)
        Me.CantidadTextBox.TabIndex = 13
        Me.CantidadTextBox.Text = "0"
        Me.CantidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturasRecibidas_LineasBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(545, 36)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(47, 20)
        Me.PrecioTextBox.TabIndex = 15
        Me.PrecioTextBox.Text = "0"
        Me.PrecioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Descuento1TextBox
        '
        Me.Descuento1TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Descuento1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturasRecibidas_LineasBindingSource, "Descuento1", True))
        Me.Descuento1TextBox.Location = New System.Drawing.Point(598, 36)
        Me.Descuento1TextBox.Name = "Descuento1TextBox"
        Me.Descuento1TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Descuento1TextBox.TabIndex = 17
        Me.Descuento1TextBox.Text = "0"
        Me.Descuento1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Descuento2TextBox
        '
        Me.Descuento2TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Descuento2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturasRecibidas_LineasBindingSource, "Descuento2", True))
        Me.Descuento2TextBox.Location = New System.Drawing.Point(598, 62)
        Me.Descuento2TextBox.Name = "Descuento2TextBox"
        Me.Descuento2TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Descuento2TextBox.TabIndex = 19
        Me.Descuento2TextBox.Text = "0"
        Me.Descuento2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Descuento3TextBox
        '
        Me.Descuento3TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Descuento3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturasRecibidas_LineasBindingSource, "Descuento3", True))
        Me.Descuento3TextBox.Location = New System.Drawing.Point(598, 88)
        Me.Descuento3TextBox.Name = "Descuento3TextBox"
        Me.Descuento3TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Descuento3TextBox.TabIndex = 21
        Me.Descuento3TextBox.Text = "0"
        Me.Descuento3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturasRecibidas_LineasBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(644, 36)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(68, 20)
        Me.TotalTextBox.TabIndex = 23
        Me.TotalTextBox.Text = "0"
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tb_Ficha)
        Me.TabControl1.Controls.Add(Me.tb_Observaciones)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(729, 171)
        Me.TabControl1.TabIndex = 32
        '
        'tb_Ficha
        '
        Me.tb_Ficha.Controls.Add(Me.CodigoTextBox)
        Me.tb_Ficha.Controls.Add(Me.DescripcionTextBox)
        Me.tb_Ficha.Controls.Add(CodigoLabel)
        Me.tb_Ficha.Controls.Add(Me.TotalTextBox)
        Me.tb_Ficha.Controls.Add(TotalLabel)
        Me.tb_Ficha.Controls.Add(DescripcionLabel)
        Me.tb_Ficha.Controls.Add(Me.Descuento3TextBox)
        Me.tb_Ficha.Controls.Add(Me.Descuento2TextBox)
        Me.tb_Ficha.Controls.Add(CantidadLabel)
        Me.tb_Ficha.Controls.Add(Me.Descuento1TextBox)
        Me.tb_Ficha.Controls.Add(Me.CantidadTextBox)
        Me.tb_Ficha.Controls.Add(Descuento1Label)
        Me.tb_Ficha.Controls.Add(PrecioLabel)
        Me.tb_Ficha.Controls.Add(Me.PrecioTextBox)
        Me.tb_Ficha.Controls.Add(Me.pb_Articulo_Delete)
        Me.tb_Ficha.Controls.Add(Me.pb_SeleccionarArticulo)
        Me.tb_Ficha.Location = New System.Drawing.Point(4, 22)
        Me.tb_Ficha.Name = "tb_Ficha"
        Me.tb_Ficha.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Ficha.Size = New System.Drawing.Size(721, 145)
        Me.tb_Ficha.TabIndex = 0
        Me.tb_Ficha.Text = "Ficha"
        Me.tb_Ficha.UseVisualStyleBackColor = True
        '
        'pb_Articulo_Delete
        '
        Me.pb_Articulo_Delete.Image = Global.centro_medico.My.Resources._24_frame_close
        Me.pb_Articulo_Delete.Location = New System.Drawing.Point(100, 54)
        Me.pb_Articulo_Delete.Name = "pb_Articulo_Delete"
        Me.pb_Articulo_Delete.Size = New System.Drawing.Size(19, 23)
        Me.pb_Articulo_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Articulo_Delete.TabIndex = 24
        Me.pb_Articulo_Delete.TabStop = False
        '
        'pb_SeleccionarArticulo
        '
        Me.pb_SeleccionarArticulo.Image = Global.centro_medico.My.Resources.Resources._24_frame
        Me.pb_SeleccionarArticulo.Location = New System.Drawing.Point(82, 54)
        Me.pb_SeleccionarArticulo.Name = "pb_SeleccionarArticulo"
        Me.pb_SeleccionarArticulo.Size = New System.Drawing.Size(19, 23)
        Me.pb_SeleccionarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_SeleccionarArticulo.TabIndex = 24
        Me.pb_SeleccionarArticulo.TabStop = False
        '
        'tb_Observaciones
        '
        Me.tb_Observaciones.Controls.Add(Me.ObservacionesTextBox)
        Me.tb_Observaciones.Controls.Add(ObservacionesLabel)
        Me.tb_Observaciones.Location = New System.Drawing.Point(4, 22)
        Me.tb_Observaciones.Name = "tb_Observaciones"
        Me.tb_Observaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Observaciones.Size = New System.Drawing.Size(721, 145)
        Me.tb_Observaciones.TabIndex = 1
        Me.tb_Observaciones.Text = "Observaciones"
        Me.tb_Observaciones.UseVisualStyleBackColor = True
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturasRecibidas_LineasBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(29, 35)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(640, 86)
        Me.ObservacionesTextBox.TabIndex = 40
        '
        'IVAIncluidoCheckBox
        '
        Me.IVAIncluidoCheckBox.Checked = True
        Me.IVAIncluidoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IVAIncluidoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_FacturasRecibidas_LineasBindingSource, "IVAIncluido", True))
        Me.IVAIncluidoCheckBox.Location = New System.Drawing.Point(88, 103)
        Me.IVAIncluidoCheckBox.Name = "IVAIncluidoCheckBox"
        Me.IVAIncluidoCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.IVAIncluidoCheckBox.TabIndex = 36
        Me.IVAIncluidoCheckBox.TabStop = False
        '
        'CostoTextBox
        '
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_FacturasRecibidas_LineasBindingSource, "Costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(86, 133)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(65, 20)
        Me.CostoTextBox.TabIndex = 38
        Me.CostoTextBox.TabStop = False
        Me.CostoTextBox.Text = "0"
        Me.CostoTextBox.Visible = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(665, 185)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 32)
        Me.btn_Guardar.TabIndex = 25
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Detalles
        '
        Me.btn_Detalles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Detalles.Image = Global.centro_medico.My.Resources.Resources._24_em_down
        Me.btn_Detalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Detalles.Location = New System.Drawing.Point(503, 185)
        Me.btn_Detalles.Name = "btn_Detalles"
        Me.btn_Detalles.Size = New System.Drawing.Size(75, 32)
        Me.btn_Detalles.TabIndex = 30
        Me.btn_Detalles.TabStop = False
        Me.btn_Detalles.Text = "Detalles"
        Me.btn_Detalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Detalles.UseVisualStyleBackColor = True
        '
        'N_TipoIVABindingSource
        '
        Me.N_TipoIVABindingSource.DataMember = "N_TipoIVA"
        Me.N_TipoIVABindingSource.DataSource = Me.CMDataSet
        '
        'N_TipoIVATableAdapter
        '
        Me.N_TipoIVATableAdapter.ClearBeforeFill = True
        '
        'N_TipoIVAComboBox
        '
        Me.N_TipoIVAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_FacturasRecibidas_LineasBindingSource, "ID_TipoIVA", True))
        Me.N_TipoIVAComboBox.DataSource = Me.N_TipoIVABindingSource
        Me.N_TipoIVAComboBox.DisplayMember = "Nombre"
        Me.N_TipoIVAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.N_TipoIVAComboBox.Location = New System.Drawing.Point(86, 76)
        Me.N_TipoIVAComboBox.Name = "N_TipoIVAComboBox"
        Me.N_TipoIVAComboBox.Size = New System.Drawing.Size(104, 21)
        Me.N_TipoIVAComboBox.TabIndex = 40
        Me.N_TipoIVAComboBox.TabStop = False
        Me.N_TipoIVAComboBox.ValueMember = "ID_TipoIVA"
        '
        'btn_Imagen
        '
        Me.btn_Imagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Imagen.Image = Global.centro_medico.My.Resources.Resources._24_image
        Me.btn_Imagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Imagen.Location = New System.Drawing.Point(584, 185)
        Me.btn_Imagen.Name = "btn_Imagen"
        Me.btn_Imagen.Size = New System.Drawing.Size(75, 32)
        Me.btn_Imagen.TabIndex = 31
        Me.btn_Imagen.TabStop = False
        Me.btn_Imagen.Text = "Imagen"
        Me.btn_Imagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imagen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.pb_EliminarSerie)
        Me.GroupBox1.Controls.Add(Me.pb_NuevaSerie)
        Me.GroupBox1.Controls.Add(Me.N_FacturasRecibidas_LotesDataGridView)
        Me.GroupBox1.Controls.Add(Me.N_TipoIVAComboBox)
        Me.GroupBox1.Controls.Add(Me.CostoTextBox)
        Me.GroupBox1.Controls.Add(CostoLabel)
        Me.GroupBox1.Controls.Add(Me.IVAIncluidoCheckBox)
        Me.GroupBox1.Controls.Add(IVAIncluidoLabel)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(ID_TipoIVALabel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(725, 213)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'pb_EliminarSerie
        '
        Me.pb_EliminarSerie.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.pb_EliminarSerie.Location = New System.Drawing.Point(239, 181)
        Me.pb_EliminarSerie.Name = "pb_EliminarSerie"
        Me.pb_EliminarSerie.Size = New System.Drawing.Size(19, 23)
        Me.pb_EliminarSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_EliminarSerie.TabIndex = 41
        Me.pb_EliminarSerie.TabStop = False
        '
        'pb_NuevaSerie
        '
        Me.pb_NuevaSerie.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.pb_NuevaSerie.Location = New System.Drawing.Point(214, 181)
        Me.pb_NuevaSerie.Name = "pb_NuevaSerie"
        Me.pb_NuevaSerie.Size = New System.Drawing.Size(19, 23)
        Me.pb_NuevaSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_NuevaSerie.TabIndex = 41
        Me.pb_NuevaSerie.TabStop = False
        '
        'N_FacturasRecibidas_LotesDataGridView
        '
        Me.N_FacturasRecibidas_LotesDataGridView.AllowUserToAddRows = False
        Me.N_FacturasRecibidas_LotesDataGridView.AllowUserToDeleteRows = False
        Me.N_FacturasRecibidas_LotesDataGridView.AllowUserToResizeRows = False
        Me.N_FacturasRecibidas_LotesDataGridView.AutoGenerateColumns = False
        Me.N_FacturasRecibidas_LotesDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.N_FacturasRecibidas_LotesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.N_FacturasRecibidas_LotesDataGridView.DataSource = Me.N_FacturasRecibidas_LotesBindingSource
        Me.N_FacturasRecibidas_LotesDataGridView.Location = New System.Drawing.Point(214, 35)
        Me.N_FacturasRecibidas_LotesDataGridView.MultiSelect = False
        Me.N_FacturasRecibidas_LotesDataGridView.Name = "N_FacturasRecibidas_LotesDataGridView"
        Me.N_FacturasRecibidas_LotesDataGridView.RowHeadersVisible = False
        Me.N_FacturasRecibidas_LotesDataGridView.Size = New System.Drawing.Size(197, 140)
        Me.N_FacturasRecibidas_LotesDataGridView.TabIndex = 40
        Me.N_FacturasRecibidas_LotesDataGridView.TabStop = False
        Me.N_FacturasRecibidas_LotesDataGridView.VirtualMode = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Lote"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Lote"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_FacturaRecibida_Linea"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_FacturaRecibida_Linea"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Unidades"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unidades"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'N_FacturasRecibidas_LotesBindingSource
        '
        Me.N_FacturasRecibidas_LotesBindingSource.DataMember = "N_FacturasRecibidas_Lotes"
        Me.N_FacturasRecibidas_LotesBindingSource.DataSource = Me.CMDataSet
        '
        'N_FacturasRecibidas_LotesTableAdapter
        '
        Me.N_FacturasRecibidas_LotesTableAdapter.ClearBeforeFill = True
        '
        'N_AlmacenBindingSource
        '
        Me.N_AlmacenBindingSource.DataMember = "N_Almacen"
        Me.N_AlmacenBindingSource.DataSource = Me.CMDataSet
        '
        'N_AlmacenTableAdapter
        '
        Me.N_AlmacenTableAdapter.ClearBeforeFill = True
        '
        'N_AlmacenComboBox
        '
        Me.N_AlmacenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_FacturasRecibidas_LineasBindingSource, "ID_Almacen", True))
        Me.N_AlmacenComboBox.DataSource = Me.N_AlmacenBindingSource
        Me.N_AlmacenComboBox.DisplayMember = "Descripcion"
        Me.N_AlmacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.N_AlmacenComboBox.Location = New System.Drawing.Point(140, 189)
        Me.N_AlmacenComboBox.Name = "N_AlmacenComboBox"
        Me.N_AlmacenComboBox.Size = New System.Drawing.Size(174, 21)
        Me.N_AlmacenComboBox.TabIndex = 24
        Me.N_AlmacenComboBox.ValueMember = "ID_Almacen"
        '
        'frmFacturasRecibidas_Lineas_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(752, 224)
        Me.Controls.Add(Me.N_AlmacenComboBox)
        Me.Controls.Add(Me.btn_Imagen)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.btn_Detalles)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmFacturasRecibidas_Lineas_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Linea FacturaRecibida"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_FacturasRecibidas_LineasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tb_Ficha.ResumeLayout(False)
        Me.tb_Ficha.PerformLayout()
        CType(Me.pb_Articulo_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_SeleccionarArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_Observaciones.ResumeLayout(False)
        Me.tb_Observaciones.PerformLayout()
        CType(Me.N_TipoIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pb_EliminarSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_NuevaSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_FacturasRecibidas_LotesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_FacturasRecibidas_LotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_FacturasRecibidas_LineasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_FacturasRecibidas_LineasTableAdapter As CMDataSetTableAdapters.N_FacturasRecibidas_LineasTableAdapter
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descuento1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descuento2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descuento3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tb_Ficha As System.Windows.Forms.TabPage
    Friend WithEvents tb_Observaciones As System.Windows.Forms.TabPage
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IVAIncluidoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pb_SeleccionarArticulo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents pb_Articulo_Delete As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Detalles As System.Windows.Forms.Button
    Friend WithEvents N_TipoIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_TipoIVATableAdapter As CMDataSetTableAdapters.N_TipoIVATableAdapter
    Friend WithEvents N_TipoIVAComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Imagen As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents N_FacturasRecibidas_LotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_FacturasRecibidas_LotesTableAdapter As CMDataSetTableAdapters.N_FacturasRecibidas_LotesTableAdapter
    Friend WithEvents N_FacturasRecibidas_LotesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents pb_NuevaSerie As System.Windows.Forms.PictureBox
    Friend WithEvents pb_EliminarSerie As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N_AlmacenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_AlmacenTableAdapter As CMDataSetTableAdapters.N_AlmacenTableAdapter
    Friend WithEvents N_AlmacenComboBox As System.Windows.Forms.ComboBox
End Class
