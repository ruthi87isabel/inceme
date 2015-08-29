<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidos_Lineas_ADD
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
        Dim Label3 As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Descuento1Label As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim IVAIncluidoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ID_TipoIVALabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim lblComision As System.Windows.Forms.Label
        Me.pb_NuevaSerie = New System.Windows.Forms.PictureBox
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.N_Pedidos_LineasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New CMDataSet
        Me.tb_Ficha = New System.Windows.Forms.TabPage
        Me.N_AlmacenComboBox = New System.Windows.Forms.ComboBox
        Me.N_AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.Descuento3TextBox = New System.Windows.Forms.TextBox
        Me.Descuento2TextBox = New System.Windows.Forms.TextBox
        Me.Descuento1TextBox = New System.Windows.Forms.TextBox
        Me.CantidadTextBox = New System.Windows.Forms.TextBox
        Me.PrecioTextBox = New System.Windows.Forms.TextBox
        Me.pb_Articulo_Delete = New System.Windows.Forms.PictureBox
        Me.pb_SeleccionarArticulo = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tb_Observaciones = New System.Windows.Forms.TabPage
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox
        Me.N_TipoIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Nota = New System.Windows.Forms.Label
        Me.pb_EliminarSerie = New System.Windows.Forms.PictureBox
        Me.N_AlmacenTableAdapter = New CMDataSetTableAdapters.N_AlmacenTableAdapter
        Me.N_Pedidos_LineasTableAdapter = New CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.N_Presupuestos_LotesDataGridView = New System.Windows.Forms.DataGridView
        Me.N_TipoIVAComboBox = New System.Windows.Forms.ComboBox
        Me.CostoTextBox = New System.Windows.Forms.TextBox
        Me.IVAIncluidoCheckBox = New System.Windows.Forms.CheckBox
        Me.btn_Detalles = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Imagen = New System.Windows.Forms.Button
        Me.N_TipoIVATableAdapter = New CMDataSetTableAdapters.N_TipoIVATableAdapter
        Me.txt_comision = New System.Windows.Forms.TextBox
        Label3 = New System.Windows.Forms.Label
        CodigoLabel = New System.Windows.Forms.Label
        TotalLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        CantidadLabel = New System.Windows.Forms.Label
        Descuento1Label = New System.Windows.Forms.Label
        PrecioLabel = New System.Windows.Forms.Label
        ObservacionesLabel = New System.Windows.Forms.Label
        CostoLabel = New System.Windows.Forms.Label
        IVAIncluidoLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        ID_TipoIVALabel = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        lblComision = New System.Windows.Forms.Label
        CType(Me.pb_NuevaSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Pedidos_LineasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_Ficha.SuspendLayout()
        CType(Me.N_AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Articulo_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_SeleccionarArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tb_Observaciones.SuspendLayout()
        CType(Me.N_TipoIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_EliminarSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.N_Presupuestos_LotesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(67, 141)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(51, 13)
        Label3.TabIndex = 42
        Label3.Text = "Almacén:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(18, 18)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(83, 13)
        CodigoLabel.TabIndex = 6
        CodigoLabel.Text = "Código Artículo:"
        '
        'TotalLabel
        '
        TotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(543, 18)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 22
        TotalLabel.Text = "Total:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(121, 18)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 10
        DescripcionLabel.Text = "Descripcion:"
        '
        'CantidadLabel
        '
        CantidadLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(386, 18)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 12
        CantidadLabel.Text = "Cantidad:"
        '
        'Descuento1Label
        '
        Descuento1Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Descuento1Label.AutoSize = True
        Descuento1Label.Location = New System.Drawing.Point(497, 18)
        Descuento1Label.Name = "Descuento1Label"
        Descuento1Label.Size = New System.Drawing.Size(32, 13)
        Descuento1Label.TabIndex = 16
        Descuento1Label.Text = "Dtos:"
        '
        'PrecioLabel
        '
        PrecioLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(444, 18)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 14
        PrecioLabel.Text = "Precio:"
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
        'IVAIncluidoLabel
        '
        IVAIncluidoLabel.AutoSize = True
        IVAIncluidoLabel.Location = New System.Drawing.Point(14, 108)
        IVAIncluidoLabel.Name = "IVAIncluidoLabel"
        IVAIncluidoLabel.Size = New System.Drawing.Size(66, 13)
        IVAIncluidoLabel.TabIndex = 35
        IVAIncluidoLabel.Text = "IVA incluido:"
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
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(211, 19)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(111, 13)
        Label1.TabIndex = 33
        Label1.Text = "Números Serie / Lote:"
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
        'pb_NuevaSerie
        '
        'Me.pb_NuevaSerie.Image = Global.My.Resources.Resources._24_em_plus
        Me.pb_NuevaSerie.Location = New System.Drawing.Point(214, 181)
        Me.pb_NuevaSerie.Name = "pb_NuevaSerie"
        Me.pb_NuevaSerie.Size = New System.Drawing.Size(19, 23)
        Me.pb_NuevaSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_NuevaSerie.TabIndex = 41
        Me.pb_NuevaSerie.TabStop = False
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(21, 34)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.CodigoTextBox.TabIndex = 7
        '
        'N_Pedidos_LineasBindingSource
        '
        Me.N_Pedidos_LineasBindingSource.DataMember = "N_Pedidos_Lineas"
        Me.N_Pedidos_LineasBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_Ficha
        '
        Me.tb_Ficha.Controls.Add(Label4)
        Me.tb_Ficha.Controls.Add(lblComision)
        Me.tb_Ficha.Controls.Add(Me.txt_comision)
        Me.tb_Ficha.Controls.Add(Me.N_AlmacenComboBox)
        Me.tb_Ficha.Controls.Add(Me.CodigoTextBox)
        Me.tb_Ficha.Controls.Add(Label3)
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
        Me.tb_Ficha.Size = New System.Drawing.Size(623, 165)
        Me.tb_Ficha.TabIndex = 0
        Me.tb_Ficha.Text = "Ficha"
        Me.tb_Ficha.UseVisualStyleBackColor = True
        '
        'N_AlmacenComboBox
        '
        Me.N_AlmacenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_Pedidos_LineasBindingSource, "ID_Almacen", True))
        Me.N_AlmacenComboBox.DataSource = Me.N_AlmacenBindingSource
        Me.N_AlmacenComboBox.DisplayMember = "Codigo"
        Me.N_AlmacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.N_AlmacenComboBox.Location = New System.Drawing.Point(124, 138)
        Me.N_AlmacenComboBox.Name = "N_AlmacenComboBox"
        Me.N_AlmacenComboBox.Size = New System.Drawing.Size(174, 21)
        Me.N_AlmacenComboBox.TabIndex = 47
        Me.N_AlmacenComboBox.ValueMember = "ID_Almacen"
        '
        'N_AlmacenBindingSource
        '
        Me.N_AlmacenBindingSource.DataMember = "N_Almacen"
        Me.N_AlmacenBindingSource.DataSource = Me.CMDataSet
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(124, 34)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescripcionTextBox.Size = New System.Drawing.Size(250, 98)
        Me.DescripcionTextBox.TabIndex = 11
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(546, 34)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(68, 20)
        Me.TotalTextBox.TabIndex = 23
        Me.TotalTextBox.Text = "0"
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Descuento3TextBox
        '
        Me.Descuento3TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Descuento3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Descuento3", True))
        Me.Descuento3TextBox.Location = New System.Drawing.Point(500, 86)
        Me.Descuento3TextBox.Name = "Descuento3TextBox"
        Me.Descuento3TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Descuento3TextBox.TabIndex = 21
        Me.Descuento3TextBox.Text = "0"
        Me.Descuento3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Descuento2TextBox
        '
        Me.Descuento2TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Descuento2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Descuento2", True))
        Me.Descuento2TextBox.Location = New System.Drawing.Point(500, 60)
        Me.Descuento2TextBox.Name = "Descuento2TextBox"
        Me.Descuento2TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Descuento2TextBox.TabIndex = 19
        Me.Descuento2TextBox.Text = "0"
        Me.Descuento2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Descuento1TextBox
        '
        Me.Descuento1TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Descuento1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Descuento1", True))
        Me.Descuento1TextBox.Location = New System.Drawing.Point(500, 34)
        Me.Descuento1TextBox.Name = "Descuento1TextBox"
        Me.Descuento1TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Descuento1TextBox.TabIndex = 17
        Me.Descuento1TextBox.Text = "0"
        Me.Descuento1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(389, 34)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(49, 20)
        Me.CantidadTextBox.TabIndex = 13
        Me.CantidadTextBox.Text = "0"
        Me.CantidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(447, 34)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(47, 20)
        Me.PrecioTextBox.TabIndex = 15
        Me.PrecioTextBox.Text = "0"
        Me.PrecioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pb_Articulo_Delete
        '
        'Me.pb_Articulo_Delete.Image = Global.My.Resources.Resources._24_frame_close
        Me.pb_Articulo_Delete.Location = New System.Drawing.Point(100, 52)
        Me.pb_Articulo_Delete.Name = "pb_Articulo_Delete"
        Me.pb_Articulo_Delete.Size = New System.Drawing.Size(19, 23)
        Me.pb_Articulo_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Articulo_Delete.TabIndex = 24
        Me.pb_Articulo_Delete.TabStop = False
        '
        'pb_SeleccionarArticulo
        '
        'Me.pb_SeleccionarArticulo.Image = Global.My.Resources.Resources._24_frame
        Me.pb_SeleccionarArticulo.Location = New System.Drawing.Point(82, 52)
        Me.pb_SeleccionarArticulo.Name = "pb_SeleccionarArticulo"
        Me.pb_SeleccionarArticulo.Size = New System.Drawing.Size(19, 23)
        Me.pb_SeleccionarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_SeleccionarArticulo.TabIndex = 24
        Me.pb_SeleccionarArticulo.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tb_Ficha)
        Me.TabControl1.Controls.Add(Me.tb_Observaciones)
        Me.TabControl1.Location = New System.Drawing.Point(8, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(631, 191)
        Me.TabControl1.TabIndex = 50
        '
        'tb_Observaciones
        '
        Me.tb_Observaciones.Controls.Add(Me.ObservacionesTextBox)
        Me.tb_Observaciones.Controls.Add(ObservacionesLabel)
        Me.tb_Observaciones.Location = New System.Drawing.Point(4, 22)
        Me.tb_Observaciones.Name = "tb_Observaciones"
        Me.tb_Observaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Observaciones.Size = New System.Drawing.Size(623, 165)
        Me.tb_Observaciones.TabIndex = 1
        Me.tb_Observaciones.Text = "Observaciones"
        Me.tb_Observaciones.UseVisualStyleBackColor = True
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(29, 35)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(436, 113)
        Me.ObservacionesTextBox.TabIndex = 40
        '
        'N_TipoIVABindingSource
        '
        Me.N_TipoIVABindingSource.DataMember = "N_TipoIVA"
        Me.N_TipoIVABindingSource.DataSource = Me.CMDataSet
        '
        'lbl_Nota
        '
        Me.lbl_Nota.Location = New System.Drawing.Point(16, 206)
        Me.lbl_Nota.Name = "lbl_Nota"
        Me.lbl_Nota.Size = New System.Drawing.Size(363, 29)
        Me.lbl_Nota.TabIndex = 49
        Me.lbl_Nota.Text = "Notas:"
        '
        'pb_EliminarSerie
        '
        'Me.pb_EliminarSerie.Image = Global.My.Resources.Resources._24_em_cross
        Me.pb_EliminarSerie.Location = New System.Drawing.Point(236, 181)
        Me.pb_EliminarSerie.Name = "pb_EliminarSerie"
        Me.pb_EliminarSerie.Size = New System.Drawing.Size(19, 23)
        Me.pb_EliminarSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_EliminarSerie.TabIndex = 41
        Me.pb_EliminarSerie.TabStop = False
        '
        'N_AlmacenTableAdapter
        '
        Me.N_AlmacenTableAdapter.ClearBeforeFill = True
        '
        'N_Pedidos_LineasTableAdapter
        '
        Me.N_Pedidos_LineasTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.pb_EliminarSerie)
        Me.GroupBox1.Controls.Add(Me.pb_NuevaSerie)
        Me.GroupBox1.Controls.Add(Me.N_Presupuestos_LotesDataGridView)
        Me.GroupBox1.Controls.Add(Me.N_TipoIVAComboBox)
        Me.GroupBox1.Controls.Add(Me.CostoTextBox)
        Me.GroupBox1.Controls.Add(CostoLabel)
        Me.GroupBox1.Controls.Add(Me.IVAIncluidoCheckBox)
        Me.GroupBox1.Controls.Add(IVAIncluidoLabel)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(ID_TipoIVALabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 213)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'N_Presupuestos_LotesDataGridView
        '
        Me.N_Presupuestos_LotesDataGridView.AllowUserToAddRows = False
        Me.N_Presupuestos_LotesDataGridView.AllowUserToDeleteRows = False
        Me.N_Presupuestos_LotesDataGridView.AllowUserToResizeRows = False
        Me.N_Presupuestos_LotesDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.N_Presupuestos_LotesDataGridView.Location = New System.Drawing.Point(214, 35)
        Me.N_Presupuestos_LotesDataGridView.MultiSelect = False
        Me.N_Presupuestos_LotesDataGridView.Name = "N_Presupuestos_LotesDataGridView"
        Me.N_Presupuestos_LotesDataGridView.RowHeadersVisible = False
        Me.N_Presupuestos_LotesDataGridView.Size = New System.Drawing.Size(197, 142)
        Me.N_Presupuestos_LotesDataGridView.TabIndex = 40
        Me.N_Presupuestos_LotesDataGridView.VirtualMode = True
        '
        'N_TipoIVAComboBox
        '
        Me.N_TipoIVAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.N_Pedidos_LineasBindingSource, "ID_TipoIVA", True))
        Me.N_TipoIVAComboBox.DataSource = Me.N_TipoIVABindingSource
        Me.N_TipoIVAComboBox.DisplayMember = "Nombre"
        Me.N_TipoIVAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.N_TipoIVAComboBox.Location = New System.Drawing.Point(86, 76)
        Me.N_TipoIVAComboBox.Name = "N_TipoIVAComboBox"
        Me.N_TipoIVAComboBox.Size = New System.Drawing.Size(104, 21)
        Me.N_TipoIVAComboBox.TabIndex = 40
        Me.N_TipoIVAComboBox.ValueMember = "ID_TipoIVA"
        '
        'CostoTextBox
        '
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(86, 133)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(65, 20)
        Me.CostoTextBox.TabIndex = 38
        Me.CostoTextBox.Text = "0"
        Me.CostoTextBox.Visible = False
        '
        'IVAIncluidoCheckBox
        '
        Me.IVAIncluidoCheckBox.Checked = True
        Me.IVAIncluidoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IVAIncluidoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.N_Pedidos_LineasBindingSource, "IVAIncluido", True))
        Me.IVAIncluidoCheckBox.Location = New System.Drawing.Point(88, 103)
        Me.IVAIncluidoCheckBox.Name = "IVAIncluidoCheckBox"
        Me.IVAIncluidoCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.IVAIncluidoCheckBox.TabIndex = 36
        '
        'btn_Detalles
        '
        Me.btn_Detalles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        'Me.btn_Detalles.Image = Global.My.Resources.Resources._24_em_down
        Me.btn_Detalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Detalles.Location = New System.Drawing.Point(397, 203)
        Me.btn_Detalles.Name = "btn_Detalles"
        Me.btn_Detalles.Size = New System.Drawing.Size(75, 32)
        Me.btn_Detalles.TabIndex = 52
        Me.btn_Detalles.Text = "Detalles"
        Me.btn_Detalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Detalles.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(559, 203)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 32)
        Me.btn_Guardar.TabIndex = 51
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Imagen
        '
        Me.btn_Imagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        'Me.btn_Imagen.Image = Global.My.Resources.Resources._24_image
        Me.btn_Imagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Imagen.Location = New System.Drawing.Point(478, 203)
        Me.btn_Imagen.Name = "btn_Imagen"
        Me.btn_Imagen.Size = New System.Drawing.Size(75, 32)
        Me.btn_Imagen.TabIndex = 53
        Me.btn_Imagen.Text = "Imagen"
        Me.btn_Imagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imagen.UseVisualStyleBackColor = True
        '
        'N_TipoIVATableAdapter
        '
        Me.N_TipoIVATableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(422, 141)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(15, 13)
        Label4.TabIndex = 50
        Label4.Text = "%"
        '
        'lblComision
        '
        lblComision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblComision.AutoSize = True
        lblComision.Location = New System.Drawing.Point(315, 141)
        lblComision.Name = "lblComision"
        lblComision.Size = New System.Drawing.Size(52, 13)
        lblComision.TabIndex = 49
        lblComision.Text = "Comision:"
        '
        'txt_comision
        '
        Me.txt_comision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_comision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_Pedidos_LineasBindingSource, "Comision", True))
        Me.txt_comision.Location = New System.Drawing.Point(373, 138)
        Me.txt_comision.Name = "txt_comision"
        Me.txt_comision.Size = New System.Drawing.Size(49, 20)
        Me.txt_comision.TabIndex = 48
        Me.txt_comision.Text = "0"
        Me.txt_comision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmPedidos_Lineas_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 240)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbl_Nota)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Detalles)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.btn_Imagen)
        Me.Name = "frmPedidos_Lineas_ADD"
        Me.Text = "Modificar Línea de Pedido"
        CType(Me.pb_NuevaSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Pedidos_LineasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_Ficha.ResumeLayout(False)
        Me.tb_Ficha.PerformLayout()
        CType(Me.N_AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Articulo_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_SeleccionarArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tb_Observaciones.ResumeLayout(False)
        Me.tb_Observaciones.PerformLayout()
        CType(Me.N_TipoIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_EliminarSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.N_Presupuestos_LotesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb_NuevaSerie As System.Windows.Forms.PictureBox
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents N_Pedidos_LineasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents tb_Ficha As System.Windows.Forms.TabPage
    Friend WithEvents N_AlmacenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents N_AlmacenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descuento3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descuento2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descuento1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pb_Articulo_Delete As System.Windows.Forms.PictureBox
    Friend WithEvents pb_SeleccionarArticulo As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tb_Observaciones As System.Windows.Forms.TabPage
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents N_TipoIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents pb_EliminarSerie As System.Windows.Forms.PictureBox
    Friend WithEvents N_AlmacenTableAdapter As CMDataSetTableAdapters.N_AlmacenTableAdapter
    Friend WithEvents N_Pedidos_LineasTableAdapter As CMDataSetTableAdapters.N_Pedidos_LineasTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents N_Presupuestos_LotesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents N_TipoIVAComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IVAIncluidoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Detalles As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Imagen As System.Windows.Forms.Button
    Friend WithEvents N_TipoIVATableAdapter As CMDataSetTableAdapters.N_TipoIVATableAdapter
    Friend WithEvents txt_comision As System.Windows.Forms.TextBox
End Class
