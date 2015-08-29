<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartes_AsistenteFacturacion
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartes_AsistenteFacturacion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRemoveLineaSimple = New System.Windows.Forms.Button()
        Me.btn_GenerarNuevaFactura = New System.Windows.Forms.Button()
        Me.btn_Asignar_a_Factura = New System.Windows.Forms.Button()
        Me.rbCitas_Paciente = New System.Windows.Forms.RadioButton()
        Me.rbCitasMutuas = New System.Windows.Forms.RadioButton()
        Me.btn_FacturarSeleccionadas = New System.Windows.Forms.Button()
        Me.lnkTodas = New System.Windows.Forms.LinkLabel()
        Me.lnkNinguna = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_Final = New System.Windows.Forms.CheckBox()
        Me.chk_FechaInicio = New System.Windows.Forms.CheckBox()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_FacturaSimple = New System.Windows.Forms.Button()
        Me.btn_EliminarTodas = New System.Windows.Forms.Button()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.CITABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_SeleccioneMutua = New System.Windows.Forms.Label()
        Me.chkMostrarCero = New System.Windows.Forms.CheckBox()
        Me.GridLineas = New System.Windows.Forms.DataGridView()
        Me.IDLINEAFACTURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCONCEPTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONCEPTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFACTURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteOriginalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONCEPTOSFRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FACTURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CITADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnIDLINEACITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LINEASFACTURABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlMutuaPorPaciente1 = New centro_medico.ctrlMutuaPorPaciente()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASFACTURABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRemoveLineaSimple
        '
        Me.btnRemoveLineaSimple.Image = Global.centro_medico.My.Resources.Resources._24_arrow_previous
        Me.btnRemoveLineaSimple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveLineaSimple.Location = New System.Drawing.Point(531, 344)
        Me.btnRemoveLineaSimple.Name = "btnRemoveLineaSimple"
        Me.btnRemoveLineaSimple.Size = New System.Drawing.Size(71, 42)
        Me.btnRemoveLineaSimple.TabIndex = 4
        Me.btnRemoveLineaSimple.Text = "Eliminar"
        Me.btnRemoveLineaSimple.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemoveLineaSimple.UseVisualStyleBackColor = True
        Me.btnRemoveLineaSimple.Visible = False
        '
        'btn_GenerarNuevaFactura
        '
        Me.btn_GenerarNuevaFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_GenerarNuevaFactura.Location = New System.Drawing.Point(7, 36)
        Me.btn_GenerarNuevaFactura.Name = "btn_GenerarNuevaFactura"
        Me.btn_GenerarNuevaFactura.Size = New System.Drawing.Size(121, 23)
        Me.btn_GenerarNuevaFactura.TabIndex = 21
        Me.btn_GenerarNuevaFactura.Text = "Generar Factura"
        Me.btn_GenerarNuevaFactura.UseVisualStyleBackColor = True
        '
        'btn_Asignar_a_Factura
        '
        Me.btn_Asignar_a_Factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Asignar_a_Factura.Location = New System.Drawing.Point(134, 36)
        Me.btn_Asignar_a_Factura.Name = "btn_Asignar_a_Factura"
        Me.btn_Asignar_a_Factura.Size = New System.Drawing.Size(121, 23)
        Me.btn_Asignar_a_Factura.TabIndex = 21
        Me.btn_Asignar_a_Factura.Text = "Asignar a Factura"
        Me.btn_Asignar_a_Factura.UseVisualStyleBackColor = True
        '
        'rbCitas_Paciente
        '
        Me.rbCitas_Paciente.AutoSize = True
        Me.rbCitas_Paciente.Location = New System.Drawing.Point(16, 46)
        Me.rbCitas_Paciente.Name = "rbCitas_Paciente"
        Me.rbCitas_Paciente.Size = New System.Drawing.Size(94, 17)
        Me.rbCitas_Paciente.TabIndex = 22
        Me.rbCitas_Paciente.Text = "Citas regulares"
        Me.rbCitas_Paciente.UseVisualStyleBackColor = True
        '
        'rbCitasMutuas
        '
        Me.rbCitasMutuas.AutoSize = True
        Me.rbCitasMutuas.Checked = True
        Me.rbCitasMutuas.Location = New System.Drawing.Point(16, 19)
        Me.rbCitasMutuas.Name = "rbCitasMutuas"
        Me.rbCitasMutuas.Size = New System.Drawing.Size(96, 17)
        Me.rbCitasMutuas.TabIndex = 22
        Me.rbCitasMutuas.TabStop = True
        Me.rbCitasMutuas.Text = "Citas de Mutua"
        Me.rbCitasMutuas.UseVisualStyleBackColor = True
        '
        'btn_FacturarSeleccionadas
        '
        Me.btn_FacturarSeleccionadas.Image = Global.centro_medico.My.Resources.Resources._24_arrow_forward
        Me.btn_FacturarSeleccionadas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_FacturarSeleccionadas.Location = New System.Drawing.Point(531, 265)
        Me.btn_FacturarSeleccionadas.Name = "btn_FacturarSeleccionadas"
        Me.btn_FacturarSeleccionadas.Size = New System.Drawing.Size(71, 42)
        Me.btn_FacturarSeleccionadas.TabIndex = 23
        Me.btn_FacturarSeleccionadas.Text = "Añadir todos"
        Me.btn_FacturarSeleccionadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_FacturarSeleccionadas.UseVisualStyleBackColor = True
        Me.btn_FacturarSeleccionadas.Visible = False
        '
        'lnkTodas
        '
        Me.lnkTodas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkTodas.AutoSize = True
        Me.lnkTodas.Location = New System.Drawing.Point(434, 559)
        Me.lnkTodas.Name = "lnkTodas"
        Me.lnkTodas.Size = New System.Drawing.Size(73, 13)
        Me.lnkTodas.TabIndex = 24
        Me.lnkTodas.TabStop = True
        Me.lnkTodas.Text = "Marcar Todas"
        '
        'lnkNinguna
        '
        Me.lnkNinguna.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkNinguna.AutoSize = True
        Me.lnkNinguna.Location = New System.Drawing.Point(513, 559)
        Me.lnkNinguna.Name = "lnkNinguna"
        Me.lnkNinguna.Size = New System.Drawing.Size(47, 13)
        Me.lnkNinguna.TabIndex = 24
        Me.lnkNinguna.TabStop = True
        Me.lnkNinguna.Text = "Ninguna"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCitasMutuas)
        Me.GroupBox1.Controls.Add(Me.rbCitas_Paciente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 73)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de citas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_Final)
        Me.GroupBox2.Controls.Add(Me.chk_FechaInicio)
        Me.GroupBox2.Controls.Add(Me.dtp_ff)
        Me.GroupBox2.Controls.Add(Me.dtp_fi)
        Me.GroupBox2.Location = New System.Drawing.Point(551, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 73)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas"
        '
        'chk_Final
        '
        Me.chk_Final.AutoSize = True
        Me.chk_Final.Location = New System.Drawing.Point(12, 39)
        Me.chk_Final.Name = "chk_Final"
        Me.chk_Final.Size = New System.Drawing.Size(54, 17)
        Me.chk_Final.TabIndex = 2
        Me.chk_Final.Text = "Hasta"
        Me.chk_Final.UseVisualStyleBackColor = True
        '
        'chk_FechaInicio
        '
        Me.chk_FechaInicio.AutoSize = True
        Me.chk_FechaInicio.Location = New System.Drawing.Point(12, 19)
        Me.chk_FechaInicio.Name = "chk_FechaInicio"
        Me.chk_FechaInicio.Size = New System.Drawing.Size(57, 17)
        Me.chk_FechaInicio.TabIndex = 2
        Me.chk_FechaInicio.Text = "Desde"
        Me.chk_FechaInicio.UseVisualStyleBackColor = True
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Enabled = False
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(75, 39)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(98, 20)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Enabled = False
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(75, 16)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(98, 20)
        Me.dtp_fi.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_GenerarNuevaFactura)
        Me.GroupBox3.Controls.Add(Me.btn_Asignar_a_Factura)
        Me.GroupBox3.Location = New System.Drawing.Point(742, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(261, 73)
        Me.GroupBox3.TabIndex = 115
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Facturas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(605, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Lineas de Factura"
        '
        'btn_FacturaSimple
        '
        Me.btn_FacturaSimple.Image = Global.centro_medico.My.Resources.Resources._24_arrow_next
        Me.btn_FacturaSimple.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_FacturaSimple.Location = New System.Drawing.Point(531, 217)
        Me.btn_FacturaSimple.Name = "btn_FacturaSimple"
        Me.btn_FacturaSimple.Size = New System.Drawing.Size(71, 42)
        Me.btn_FacturaSimple.TabIndex = 23
        Me.btn_FacturaSimple.Text = "Añadir "
        Me.btn_FacturaSimple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_FacturaSimple.UseVisualStyleBackColor = True
        Me.btn_FacturaSimple.Visible = False
        '
        'btn_EliminarTodas
        '
        Me.btn_EliminarTodas.Image = Global.centro_medico.My.Resources.Resources._24_arrow_back
        Me.btn_EliminarTodas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_EliminarTodas.Location = New System.Drawing.Point(531, 392)
        Me.btn_EliminarTodas.Name = "btn_EliminarTodas"
        Me.btn_EliminarTodas.Size = New System.Drawing.Size(71, 42)
        Me.btn_EliminarTodas.TabIndex = 116
        Me.btn_EliminarTodas.Text = "Eliminar todos"
        Me.btn_EliminarTodas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EliminarTodas.UseVisualStyleBackColor = True
        Me.btn_EliminarTodas.Visible = False
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataSource = Me.CITABindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(12, 136)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEX1.Size = New System.Drawing.Size(548, 413)
        Me.GridEX1.TabIndex = 117
        '
        'CITABindingSource
        '
        Me.CITABindingSource.DataSource = GetType(centro_medico.CITA)
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 559)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 13)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Marque / desmarque para añadir/eliminar lineas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.CtrlMutuaPorPaciente1)
        Me.GroupBox4.Controls.Add(Me.CtrlPaciente1)
        Me.GroupBox4.Location = New System.Drawing.Point(148, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(394, 103)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtro Paciente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Mutua:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Citas y Lineas de Cita"
        '
        'lbl_SeleccioneMutua
        '
        Me.lbl_SeleccioneMutua.AutoSize = True
        Me.lbl_SeleccioneMutua.ForeColor = System.Drawing.Color.Red
        Me.lbl_SeleccioneMutua.Location = New System.Drawing.Point(70, 84)
        Me.lbl_SeleccioneMutua.Name = "lbl_SeleccioneMutua"
        Me.lbl_SeleccioneMutua.Size = New System.Drawing.Size(72, 13)
        Me.lbl_SeleccioneMutua.TabIndex = 122
        Me.lbl_SeleccioneMutua.Text = "Seleccione ->"
        '
        'chkMostrarCero
        '
        Me.chkMostrarCero.AutoSize = True
        Me.chkMostrarCero.Checked = True
        Me.chkMostrarCero.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarCero.Location = New System.Drawing.Point(411, 116)
        Me.chkMostrarCero.Name = "chkMostrarCero"
        Me.chkMostrarCero.Size = New System.Drawing.Size(149, 17)
        Me.chkMostrarCero.TabIndex = 123
        Me.chkMostrarCero.Text = "Mostrar Citas de Importe 0"
        Me.chkMostrarCero.UseVisualStyleBackColor = True
        Me.chkMostrarCero.Visible = False
        '
        'GridLineas
        '
        Me.GridLineas.AllowUserToAddRows = False
        Me.GridLineas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridLineas.AutoGenerateColumns = False
        Me.GridLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridLineas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridLineas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDLINEAFACTURADataGridViewTextBoxColumn, Me.REFCONCEPTODataGridViewTextBoxColumn, Me.CONCEPTODataGridViewTextBoxColumn, Me.REFFACTURADataGridViewTextBoxColumn, Me.CANTIDADDataGridViewTextBoxColumn, Me.TIPOIVADataGridViewTextBoxColumn, Me.IDCitaDataGridViewTextBoxColumn, Me.DescuentoDataGridViewTextBoxColumn, Me.ImporteOriginalDataGridViewTextBoxColumn, Me.CONCEPTOSFRADataGridViewTextBoxColumn, Me.FACTURADataGridViewTextBoxColumn, Me.CITADataGridViewTextBoxColumn, Me.IMPORTEDataGridViewTextBoxColumn, Me.ColumnIDLINEACITA})
        Me.GridLineas.DataSource = Me.LINEASFACTURABindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridLineas.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridLineas.Location = New System.Drawing.Point(579, 136)
        Me.GridLineas.MultiSelect = False
        Me.GridLineas.Name = "GridLineas"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridLineas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridLineas.RowHeadersVisible = False
        Me.GridLineas.Size = New System.Drawing.Size(427, 410)
        Me.GridLineas.TabIndex = 124
        '
        'IDLINEAFACTURADataGridViewTextBoxColumn
        '
        Me.IDLINEAFACTURADataGridViewTextBoxColumn.DataPropertyName = "IDLINEAFACTURA"
        Me.IDLINEAFACTURADataGridViewTextBoxColumn.HeaderText = "IDLINEAFACTURA"
        Me.IDLINEAFACTURADataGridViewTextBoxColumn.Name = "IDLINEAFACTURADataGridViewTextBoxColumn"
        Me.IDLINEAFACTURADataGridViewTextBoxColumn.Visible = False
        '
        'REFCONCEPTODataGridViewTextBoxColumn
        '
        Me.REFCONCEPTODataGridViewTextBoxColumn.DataPropertyName = "REFCONCEPTO"
        Me.REFCONCEPTODataGridViewTextBoxColumn.FillWeight = 26.85975!
        Me.REFCONCEPTODataGridViewTextBoxColumn.HeaderText = "Cod"
        Me.REFCONCEPTODataGridViewTextBoxColumn.MinimumWidth = 30
        Me.REFCONCEPTODataGridViewTextBoxColumn.Name = "REFCONCEPTODataGridViewTextBoxColumn"
        '
        'CONCEPTODataGridViewTextBoxColumn
        '
        Me.CONCEPTODataGridViewTextBoxColumn.DataPropertyName = "CONCEPTO"
        Me.CONCEPTODataGridViewTextBoxColumn.FillWeight = 91.07771!
        Me.CONCEPTODataGridViewTextBoxColumn.HeaderText = "CONCEPTO"
        Me.CONCEPTODataGridViewTextBoxColumn.Name = "CONCEPTODataGridViewTextBoxColumn"
        '
        'REFFACTURADataGridViewTextBoxColumn
        '
        Me.REFFACTURADataGridViewTextBoxColumn.DataPropertyName = "REFFACTURA"
        Me.REFFACTURADataGridViewTextBoxColumn.HeaderText = "REFFACTURA"
        Me.REFFACTURADataGridViewTextBoxColumn.Name = "REFFACTURADataGridViewTextBoxColumn"
        Me.REFFACTURADataGridViewTextBoxColumn.Visible = False
        '
        'CANTIDADDataGridViewTextBoxColumn
        '
        Me.CANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.FillWeight = 31.48184!
        Me.CANTIDADDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CANTIDADDataGridViewTextBoxColumn.MinimumWidth = 40
        Me.CANTIDADDataGridViewTextBoxColumn.Name = "CANTIDADDataGridViewTextBoxColumn"
        '
        'TIPOIVADataGridViewTextBoxColumn
        '
        Me.TIPOIVADataGridViewTextBoxColumn.DataPropertyName = "TIPOIVA"
        Me.TIPOIVADataGridViewTextBoxColumn.HeaderText = "TIPOIVA"
        Me.TIPOIVADataGridViewTextBoxColumn.Name = "TIPOIVADataGridViewTextBoxColumn"
        Me.TIPOIVADataGridViewTextBoxColumn.Visible = False
        '
        'IDCitaDataGridViewTextBoxColumn
        '
        Me.IDCitaDataGridViewTextBoxColumn.DataPropertyName = "ID_Cita"
        Me.IDCitaDataGridViewTextBoxColumn.HeaderText = "ID_Cita"
        Me.IDCitaDataGridViewTextBoxColumn.Name = "IDCitaDataGridViewTextBoxColumn"
        Me.IDCitaDataGridViewTextBoxColumn.Visible = False
        '
        'DescuentoDataGridViewTextBoxColumn
        '
        Me.DescuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento"
        Me.DescuentoDataGridViewTextBoxColumn.FillWeight = 34.4744!
        Me.DescuentoDataGridViewTextBoxColumn.HeaderText = "Dto"
        Me.DescuentoDataGridViewTextBoxColumn.MinimumWidth = 40
        Me.DescuentoDataGridViewTextBoxColumn.Name = "DescuentoDataGridViewTextBoxColumn"
        '
        'ImporteOriginalDataGridViewTextBoxColumn
        '
        Me.ImporteOriginalDataGridViewTextBoxColumn.DataPropertyName = "ImporteOriginal"
        Me.ImporteOriginalDataGridViewTextBoxColumn.HeaderText = "ImporteOriginal"
        Me.ImporteOriginalDataGridViewTextBoxColumn.Name = "ImporteOriginalDataGridViewTextBoxColumn"
        Me.ImporteOriginalDataGridViewTextBoxColumn.Visible = False
        '
        'CONCEPTOSFRADataGridViewTextBoxColumn
        '
        Me.CONCEPTOSFRADataGridViewTextBoxColumn.DataPropertyName = "CONCEPTOSFRA"
        Me.CONCEPTOSFRADataGridViewTextBoxColumn.HeaderText = "CONCEPTOSFRA"
        Me.CONCEPTOSFRADataGridViewTextBoxColumn.Name = "CONCEPTOSFRADataGridViewTextBoxColumn"
        Me.CONCEPTOSFRADataGridViewTextBoxColumn.Visible = False
        '
        'FACTURADataGridViewTextBoxColumn
        '
        Me.FACTURADataGridViewTextBoxColumn.DataPropertyName = "FACTURA"
        Me.FACTURADataGridViewTextBoxColumn.FillWeight = 101.7259!
        Me.FACTURADataGridViewTextBoxColumn.HeaderText = "FACTURA"
        Me.FACTURADataGridViewTextBoxColumn.Name = "FACTURADataGridViewTextBoxColumn"
        Me.FACTURADataGridViewTextBoxColumn.Visible = False
        '
        'CITADataGridViewTextBoxColumn
        '
        Me.CITADataGridViewTextBoxColumn.DataPropertyName = "CITA"
        Me.CITADataGridViewTextBoxColumn.HeaderText = "CITA"
        Me.CITADataGridViewTextBoxColumn.Name = "CITADataGridViewTextBoxColumn"
        Me.CITADataGridViewTextBoxColumn.Visible = False
        '
        'IMPORTEDataGridViewTextBoxColumn
        '
        Me.IMPORTEDataGridViewTextBoxColumn.DataPropertyName = "IMPORTE"
        DataGridViewCellStyle2.Format = "c2"
        Me.IMPORTEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.IMPORTEDataGridViewTextBoxColumn.FillWeight = 46.85189!
        Me.IMPORTEDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.IMPORTEDataGridViewTextBoxColumn.MinimumWidth = 40
        Me.IMPORTEDataGridViewTextBoxColumn.Name = "IMPORTEDataGridViewTextBoxColumn"
        '
        'ColumnIDLINEACITA
        '
        Me.ColumnIDLINEACITA.HeaderText = "IDLinea"
        Me.ColumnIDLINEACITA.Name = "ColumnIDLINEACITA"
        Me.ColumnIDLINEACITA.ReadOnly = True
        Me.ColumnIDLINEACITA.Visible = False
        '
        'LINEASFACTURABindingSource
        '
        Me.LINEASFACTURABindingSource.DataSource = GetType(centro_medico.LINEASFACTURA)
        '
        'CtrlMutuaPorPaciente1
        '
        Me.CtrlMutuaPorPaciente1.ID_Mutuas = Nothing
        Me.CtrlMutuaPorPaciente1.IDPACIENTE = Nothing
        Me.CtrlMutuaPorPaciente1.Location = New System.Drawing.Point(59, 73)
        Me.CtrlMutuaPorPaciente1.Name = "CtrlMutuaPorPaciente1"
        Me.CtrlMutuaPorPaciente1.Size = New System.Drawing.Size(220, 21)
        Me.CtrlMutuaPorPaciente1.TabIndex = 121
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(8, 14)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(378, 54)
        Me.CtrlPaciente1.TabIndex = 0
        '
        'frmPartes_AsistenteFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1018, 581)
        Me.Controls.Add(Me.GridLineas)
        Me.Controls.Add(Me.chkMostrarCero)
        Me.Controls.Add(Me.lbl_SeleccioneMutua)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.btn_EliminarTodas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lnkNinguna)
        Me.Controls.Add(Me.lnkTodas)
        Me.Controls.Add(Me.btn_FacturaSimple)
        Me.Controls.Add(Me.btn_FacturarSeleccionadas)
        Me.Controls.Add(Me.btnRemoveLineaSimple)
        Me.KeyPreview = True
        Me.Name = "frmPartes_AsistenteFacturacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asistente de Facturación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.GridLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASFACTURABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemoveLineaSimple As System.Windows.Forms.Button
    Friend WithEvents btn_GenerarNuevaFactura As System.Windows.Forms.Button
    Friend WithEvents btn_Asignar_a_Factura As System.Windows.Forms.Button
    Friend WithEvents rbCitas_Paciente As System.Windows.Forms.RadioButton
    Friend WithEvents rbCitasMutuas As System.Windows.Forms.RadioButton
    Friend WithEvents btn_FacturarSeleccionadas As System.Windows.Forms.Button
    Friend WithEvents lnkTodas As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkNinguna As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Final As System.Windows.Forms.CheckBox
    Friend WithEvents chk_FechaInicio As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_FacturaSimple As System.Windows.Forms.Button
    Friend WithEvents btn_EliminarTodas As System.Windows.Forms.Button
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents lbl_SeleccioneMutua As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CtrlMutuaPorPaciente1 As centro_medico.ctrlMutuaPorPaciente
    Friend WithEvents chkMostrarCero As System.Windows.Forms.CheckBox
    Friend WithEvents GridLineas As System.Windows.Forms.DataGridView
    Friend WithEvents LINEASFACTURABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDLINEAFACTURADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCONCEPTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONCEPTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFACTURADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOIVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCitaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteOriginalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONCEPTOSFRADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FACTURADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CITADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnIDLINEACITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CITABindingSource As System.Windows.Forms.BindingSource
End Class
