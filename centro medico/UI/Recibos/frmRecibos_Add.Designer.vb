<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibos_Add
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
        Dim FECHAEMISIONLabel As System.Windows.Forms.Label
        Dim IMPORTELabel As System.Windows.Forms.Label
        Dim FECHAVENCIMIENTOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim NUMEROLabel As System.Windows.Forms.Label
        Dim CONCEPTOLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.FECHAEMISIONDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RECIBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.FECHAVENCIMIENTODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NOMBRETextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DIRECCIONTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.NOTASTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.NUMEROTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.CONCEPTOTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.FECHACOBRODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumericEditBox1 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.UiCheckBox1 = New Janus.Windows.EditControls.UICheckBox()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.chkNorma19 = New Janus.Windows.EditControls.UICheckBox()
        Me.chkCobrado = New Janus.Windows.EditControls.UICheckBox()
        Me.RECIBOSTableAdapter = New centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter()
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        Me.CtrlCuentaBancaria1 = New centro_medico.ctrlCuentaBancaria()
        Me.CtrlEmpresa1 = New centro_medico.ctrlEmpresa()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.CtrlStatusPaciente1 = New centro_medico.ctrlStatusPaciente()
        FECHAEMISIONLabel = New System.Windows.Forms.Label()
        IMPORTELabel = New System.Windows.Forms.Label()
        FECHAVENCIMIENTOLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        NOTASLabel = New System.Windows.Forms.Label()
        NUMEROLabel = New System.Windows.Forms.Label()
        CONCEPTOLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHAEMISIONLabel
        '
        FECHAEMISIONLabel.AutoSize = True
        FECHAEMISIONLabel.Location = New System.Drawing.Point(136, 41)
        FECHAEMISIONLabel.Name = "FECHAEMISIONLabel"
        FECHAEMISIONLabel.Size = New System.Drawing.Size(79, 13)
        FECHAEMISIONLabel.TabIndex = 22
        FECHAEMISIONLabel.Text = "Fecha Emisión:"
        '
        'IMPORTELabel
        '
        IMPORTELabel.AutoSize = True
        IMPORTELabel.Location = New System.Drawing.Point(24, 100)
        IMPORTELabel.Name = "IMPORTELabel"
        IMPORTELabel.Size = New System.Drawing.Size(45, 13)
        IMPORTELabel.TabIndex = 32
        IMPORTELabel.Text = "Importe:"
        '
        'FECHAVENCIMIENTOLabel
        '
        FECHAVENCIMIENTOLabel.AutoSize = True
        FECHAVENCIMIENTOLabel.Location = New System.Drawing.Point(270, 41)
        FECHAVENCIMIENTOLabel.Name = "FECHAVENCIMIENTOLabel"
        FECHAVENCIMIENTOLabel.Size = New System.Drawing.Size(101, 13)
        FECHAVENCIMIENTOLabel.TabIndex = 36
        FECHAVENCIMIENTOLabel.Text = "Fecha Vencimiento:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(14, 221)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(93, 13)
        NOMBRELabel.TabIndex = 38
        NOMBRELabel.Text = "Titular del Recibo:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(52, 247)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(55, 13)
        DIRECCIONLabel.TabIndex = 40
        DIRECCIONLabel.Text = "Dirección:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(70, 419)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 42
        NOTASLabel.Text = "Notas:"
        '
        'NUMEROLabel
        '
        NUMEROLabel.AutoSize = True
        NUMEROLabel.Location = New System.Drawing.Point(22, 41)
        NUMEROLabel.Name = "NUMEROLabel"
        NUMEROLabel.Size = New System.Drawing.Size(47, 13)
        NUMEROLabel.TabIndex = 44
        NUMEROLabel.Text = "Número:"
        '
        'CONCEPTOLabel
        '
        CONCEPTOLabel.AutoSize = True
        CONCEPTOLabel.Location = New System.Drawing.Point(52, 321)
        CONCEPTOLabel.Name = "CONCEPTOLabel"
        CONCEPTOLabel.Size = New System.Drawing.Size(56, 13)
        CONCEPTOLabel.TabIndex = 56
        CONCEPTOLabel.Text = "Concepto:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(24, 155)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(68, 13)
        Label1.TabIndex = 74
        Label1.Text = "Recibo para:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(20, 372)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(87, 13)
        Label2.TabIndex = 56
        Label2.Text = "Datos bancarios:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tlbImprimir})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(557, 25)
        Me.ToolStrip2.TabIndex = 21
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'FECHAEMISIONDateTimePicker
        '
        Me.FECHAEMISIONDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RECIBOSBindingSource, "FECHAEMISION", True))
        Me.FECHAEMISIONDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHAEMISIONDateTimePicker.Location = New System.Drawing.Point(139, 57)
        Me.FECHAEMISIONDateTimePicker.Name = "FECHAEMISIONDateTimePicker"
        Me.FECHAEMISIONDateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.FECHAEMISIONDateTimePicker.TabIndex = 23
        '
        'RECIBOSBindingSource
        '
        Me.RECIBOSBindingSource.DataMember = "RECIBOS"
        Me.RECIBOSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FECHAVENCIMIENTODateTimePicker
        '
        Me.FECHAVENCIMIENTODateTimePicker.Checked = False
        Me.FECHAVENCIMIENTODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RECIBOSBindingSource, "FECHAVENCIMIENTO", True))
        Me.FECHAVENCIMIENTODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHAVENCIMIENTODateTimePicker.Location = New System.Drawing.Point(268, 57)
        Me.FECHAVENCIMIENTODateTimePicker.Name = "FECHAVENCIMIENTODateTimePicker"
        Me.FECHAVENCIMIENTODateTimePicker.ShowCheckBox = True
        Me.FECHAVENCIMIENTODateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.FECHAVENCIMIENTODateTimePicker.TabIndex = 37
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.AcceptsReturn = True
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(113, 218)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRETextBox.TabIndex = 39
        '
        'DIRECCIONTextBox
        '
        Me.DIRECCIONTextBox.AcceptsReturn = True
        Me.DIRECCIONTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIRECCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "DIRECCION", True))
        Me.DIRECCIONTextBox.Location = New System.Drawing.Point(113, 244)
        Me.DIRECCIONTextBox.Multiline = True
        Me.DIRECCIONTextBox.Name = "DIRECCIONTextBox"
        Me.DIRECCIONTextBox.Size = New System.Drawing.Size(431, 58)
        Me.DIRECCIONTextBox.TabIndex = 41
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.AcceptsReturn = True
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(113, 419)
        Me.NOTASTextBox.Multiline = True
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(431, 92)
        Me.NOTASTextBox.TabIndex = 43
        '
        'NUMEROTextBox
        '
        Me.NUMEROTextBox.AcceptsReturn = True
        Me.NUMEROTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "NUMERO", True))
        Me.NUMEROTextBox.Location = New System.Drawing.Point(25, 57)
        Me.NUMEROTextBox.Name = "NUMEROTextBox"
        Me.NUMEROTextBox.ReadOnly = True
        Me.NUMEROTextBox.Size = New System.Drawing.Size(83, 20)
        Me.NUMEROTextBox.TabIndex = 45
        '
        'CONCEPTOTextBox
        '
        Me.CONCEPTOTextBox.AcceptsReturn = True
        Me.CONCEPTOTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CONCEPTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "CONCEPTO", True))
        Me.CONCEPTOTextBox.Location = New System.Drawing.Point(113, 321)
        Me.CONCEPTOTextBox.Name = "CONCEPTOTextBox"
        Me.CONCEPTOTextBox.Size = New System.Drawing.Size(431, 20)
        Me.CONCEPTOTextBox.TabIndex = 57
        '
        'FECHACOBRODateTimePicker
        '
        Me.FECHACOBRODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RECIBOSBindingSource, "FECHACOBRO", True))
        Me.FECHACOBRODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHACOBRODateTimePicker.Location = New System.Drawing.Point(139, 116)
        Me.FECHACOBRODateTimePicker.Name = "FECHACOBRODateTimePicker"
        Me.FECHACOBRODateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.FECHACOBRODateTimePicker.TabIndex = 59
        '
        'NumericEditBox1
        '
        Me.NumericEditBox1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RECIBOSBindingSource, "IMPORTE", True))
        Me.NumericEditBox1.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.NumericEditBox1.Location = New System.Drawing.Point(25, 116)
        Me.NumericEditBox1.Name = "NumericEditBox1"
        Me.NumericEditBox1.Size = New System.Drawing.Size(83, 20)
        Me.NumericEditBox1.TabIndex = 69
        Me.NumericEditBox1.Text = "$0.00"
        Me.NumericEditBox1.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'UiCheckBox1
        '
        Me.UiCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UiCheckBox1.CheckedValue = "S"
        Me.UiCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("BindableValue", Me.RECIBOSBindingSource, "EMITIDO", True))
        Me.UiCheckBox1.Location = New System.Drawing.Point(484, 44)
        Me.UiCheckBox1.Name = "UiCheckBox1"
        Me.UiCheckBox1.Size = New System.Drawing.Size(60, 23)
        Me.UiCheckBox1.TabIndex = 70
        Me.UiCheckBox1.Text = "Emitido:"
        Me.UiCheckBox1.UncheckedValue = "N"
        '
        'cb_tipo
        '
        Me.cb_tipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECIBOSBindingSource, "TIPO", True))
        Me.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"Paciente", "Empresa"})
        Me.cb_tipo.Location = New System.Drawing.Point(27, 171)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(97, 21)
        Me.cb_tipo.TabIndex = 73
        '
        'chkNorma19
        '
        Me.chkNorma19.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNorma19.CheckedValue = "S"
        Me.chkNorma19.DataBindings.Add(New System.Windows.Forms.Binding("BindableValue", Me.RECIBOSBindingSource, "N19", True))
        Me.chkNorma19.Location = New System.Drawing.Point(447, 73)
        Me.chkNorma19.Name = "chkNorma19"
        Me.chkNorma19.Size = New System.Drawing.Size(97, 23)
        Me.chkNorma19.TabIndex = 70
        Me.chkNorma19.Text = "Generado N19:"
        Me.chkNorma19.UncheckedValue = "N"
        '
        'chkCobrado
        '
        Me.chkCobrado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCobrado.CheckedValue = "S"
        Me.chkCobrado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RECIBOSBindingSource, "COBRADO", True))
        Me.chkCobrado.Location = New System.Drawing.Point(139, 95)
        Me.chkCobrado.Name = "chkCobrado"
        Me.chkCobrado.Size = New System.Drawing.Size(68, 23)
        Me.chkCobrado.TabIndex = 70
        Me.chkCobrado.Text = "Cobrado:"
        Me.chkCobrado.UncheckedValue = "N"
        '
        'RECIBOSTableAdapter
        '
        Me.RECIBOSTableAdapter.ClearBeforeFill = True
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.DataBindings.Add(New System.Windows.Forms.Binding("ID_FORMASPAGO", Me.RECIBOSBindingSource, "REFFORMAPAGO", True))
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(268, 113)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(276, 23)
        Me.CtrlFormaPago21.TabIndex = 76
        '
        'CtrlCuentaBancaria1
        '
        Me.CtrlCuentaBancaria1.Cuenta = "0000000000"
        Me.CtrlCuentaBancaria1.CUENTABANCO = "00000000000000000000"
        Me.CtrlCuentaBancaria1.DataBindings.Add(New System.Windows.Forms.Binding("Cuenta", Me.RECIBOSBindingSource, "CUENTA", True))
        Me.CtrlCuentaBancaria1.DataBindings.Add(New System.Windows.Forms.Binding("CUENTABANCO", Me.RECIBOSBindingSource, "CUENTABANCO", True))
        Me.CtrlCuentaBancaria1.DataBindings.Add(New System.Windows.Forms.Binding("DC", Me.RECIBOSBindingSource, "DC", True))
        Me.CtrlCuentaBancaria1.DataBindings.Add(New System.Windows.Forms.Binding("Entidad", Me.RECIBOSBindingSource, "ENTIDAD", True))
        Me.CtrlCuentaBancaria1.DataBindings.Add(New System.Windows.Forms.Binding("Oficina", Me.RECIBOSBindingSource, "OFICINA", True))
        Me.CtrlCuentaBancaria1.DC = "00"
        Me.CtrlCuentaBancaria1.Entidad = "0000"
        Me.CtrlCuentaBancaria1.Location = New System.Drawing.Point(113, 356)
        Me.CtrlCuentaBancaria1.Name = "CtrlCuentaBancaria1"
        Me.CtrlCuentaBancaria1.Oficina = "0000"
        Me.CtrlCuentaBancaria1.Size = New System.Drawing.Size(231, 39)
        Me.CtrlCuentaBancaria1.TabIndex = 71
        '
        'CtrlEmpresa1
        '
        Me.CtrlEmpresa1.DataBindings.Add(New System.Windows.Forms.Binding("ID_EMPRESAS", Me.RECIBOSBindingSource, "REFEMPRESA", True))
        Me.CtrlEmpresa1.EsEmpresaPorDefecto = False
        Me.CtrlEmpresa1.ID_EMPRESAS = Nothing
        Me.CtrlEmpresa1.IDPACIENTE = Nothing
        Me.CtrlEmpresa1.Location = New System.Drawing.Point(139, 167)
        Me.CtrlEmpresa1.Name = "CtrlEmpresa1"
        Me.CtrlEmpresa1.Size = New System.Drawing.Size(383, 25)
        Me.CtrlEmpresa1.TabIndex = 75
        Me.CtrlEmpresa1.Visible = False
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.RECIBOSBindingSource, "REFPACIENTE", True))
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(142, 155)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(380, 50)
        Me.CtrlPaciente1.TabIndex = 68
        '
        'CtrlStatusPaciente1
        '
        Me.CtrlStatusPaciente1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlStatusPaciente1.DataBindings.Add(New System.Windows.Forms.Binding("ID_PACIENTE", Me.RECIBOSBindingSource, "REFPACIENTE", True))
        Me.CtrlStatusPaciente1.ID_PACIENTE = Nothing
        Me.CtrlStatusPaciente1.Location = New System.Drawing.Point(321, 0)
        Me.CtrlStatusPaciente1.Name = "CtrlStatusPaciente1"
        Me.CtrlStatusPaciente1.Size = New System.Drawing.Size(236, 28)
        Me.CtrlStatusPaciente1.TabIndex = 102
        '
        'frmRecibos_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 527)
        Me.Controls.Add(Me.CtrlStatusPaciente1)
        Me.Controls.Add(Me.FECHAEMISIONDateTimePicker)
        Me.Controls.Add(Me.FECHAVENCIMIENTODateTimePicker)
        Me.Controls.Add(Me.NUMEROTextBox)
        Me.Controls.Add(Me.CtrlFormaPago21)
        Me.Controls.Add(Me.CtrlCuentaBancaria1)
        Me.Controls.Add(Me.CtrlEmpresa1)
        Me.Controls.Add(Me.FECHACOBRODateTimePicker)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cb_tipo)
        Me.Controls.Add(Me.chkCobrado)
        Me.Controls.Add(Me.chkNorma19)
        Me.Controls.Add(Me.UiCheckBox1)
        Me.Controls.Add(Me.NumericEditBox1)
        Me.Controls.Add(Me.CtrlPaciente1)
        Me.Controls.Add(FECHAEMISIONLabel)
        Me.Controls.Add(IMPORTELabel)
        Me.Controls.Add(FECHAVENCIMIENTOLabel)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(DIRECCIONLabel)
        Me.Controls.Add(Me.DIRECCIONTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Controls.Add(NUMEROLabel)
        Me.Controls.Add(Label2)
        Me.Controls.Add(CONCEPTOLabel)
        Me.Controls.Add(Me.CONCEPTOTextBox)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "frmRecibos_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Recibo"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents RECIBOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECIBOSTableAdapter As centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
    Friend WithEvents FECHAEMISIONDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FECHAVENCIMIENTODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOMBRETextBox As ctrlTextboxAvanzado
    Friend WithEvents DIRECCIONTextBox As ctrlTextboxAvanzado
    Friend WithEvents NOTASTextBox As ctrlTextboxAvanzado
    Friend WithEvents NUMEROTextBox As ctrlTextboxAvanzado
    Friend WithEvents CONCEPTOTextBox As ctrlTextboxAvanzado
    Friend WithEvents FECHACOBRODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents NumericEditBox1 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents UiCheckBox1 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CtrlCuentaBancaria1 As centro_medico.ctrlCuentaBancaria
    Friend WithEvents cb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents chkNorma19 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkCobrado As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CtrlEmpresa1 As centro_medico.ctrlEmpresa
    Friend WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Friend WithEvents CtrlStatusPaciente1 As centro_medico.ctrlStatusPaciente
End Class
