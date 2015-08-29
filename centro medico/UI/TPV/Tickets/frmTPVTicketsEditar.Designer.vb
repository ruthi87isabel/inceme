<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTPVTicketsEditar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FechaPagadoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim ID_FormaPagoLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim GridEXListado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTPVTicketsEditar))
        Me.grpTodo = New System.Windows.Forms.GroupBox()
        Me.pb_UndoCobrar = New System.Windows.Forms.PictureBox()
        Me.chk_pagado = New System.Windows.Forms.CheckBox()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.FechaPagadoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NTicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ID_FormaPagoComboBox = New System.Windows.Forms.ComboBox()
        Me.ReferenciaTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.CtrlTextboxAvanzado1 = New centro_medico.ctrlTextboxAvanzado()
        Me.CtrlDocProcesados1 = New centro_medico.ctrlDocProcesados()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.btn_EmitirCita = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btAddLinea = New System.Windows.Forms.Button()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsb_DebitoPaciente = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GridEXListado = New Janus.Windows.GridEX.GridEX()
        Me.NTicketLineasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NTipoIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtIvaDesglosado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.CtrlStatusPaciente1 = New centro_medico.ctrlStatusPaciente()
        FechaPagadoLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        ID_FormaPagoLabel = New System.Windows.Forms.Label()
        ReferenciaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.grpTodo.SuspendLayout()
        CType(Me.pb_UndoCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NTicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.GridEXListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NTicketLineasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NTipoIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaPagadoLabel
        '
        FechaPagadoLabel.AutoSize = True
        FechaPagadoLabel.Location = New System.Drawing.Point(478, 42)
        FechaPagadoLabel.Name = "FechaPagadoLabel"
        FechaPagadoLabel.Size = New System.Drawing.Size(47, 13)
        FechaPagadoLabel.TabIndex = 25
        FechaPagadoLabel.Text = "Pagado:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(237, 84)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 12
        FechaLabel.Text = "Fecha:"
        '
        'TotalLabel
        '
        TotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(860, 510)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(132, 23)
        TotalLabel.TabIndex = 10
        TotalLabel.Text = "Total:"
        TotalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ID_FormaPagoLabel
        '
        ID_FormaPagoLabel.AutoSize = True
        ID_FormaPagoLabel.Location = New System.Drawing.Point(458, 68)
        ID_FormaPagoLabel.Name = "ID_FormaPagoLabel"
        ID_FormaPagoLabel.Size = New System.Drawing.Size(67, 13)
        ID_FormaPagoLabel.TabIndex = 8
        ID_FormaPagoLabel.Text = "Forma Pago:"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(7, 112)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(62, 13)
        ReferenciaLabel.TabIndex = 5
        ReferenciaLabel.Text = "Referencia:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(26, 84)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(43, 13)
        Label1.TabIndex = 3
        Label1.Text = "Código:"
        '
        'grpTodo
        '
        Me.grpTodo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTodo.Controls.Add(Me.pb_UndoCobrar)
        Me.grpTodo.Controls.Add(Me.chk_pagado)
        Me.grpTodo.Controls.Add(Me.CtrlPaciente1)
        Me.grpTodo.Controls.Add(FechaPagadoLabel)
        Me.grpTodo.Controls.Add(Me.FechaPagadoDateTimePicker)
        Me.grpTodo.Controls.Add(FechaLabel)
        Me.grpTodo.Controls.Add(Me.FechaDateTimePicker)
        Me.grpTodo.Controls.Add(ID_FormaPagoLabel)
        Me.grpTodo.Controls.Add(Me.ID_FormaPagoComboBox)
        Me.grpTodo.Controls.Add(ReferenciaLabel)
        Me.grpTodo.Controls.Add(Me.ReferenciaTextBox)
        Me.grpTodo.Controls.Add(Label1)
        Me.grpTodo.Controls.Add(Me.CtrlTextboxAvanzado1)
        Me.grpTodo.Controls.Add(Me.CtrlDocProcesados1)
        Me.grpTodo.Location = New System.Drawing.Point(5, 24)
        Me.grpTodo.Name = "grpTodo"
        Me.grpTodo.Size = New System.Drawing.Size(991, 140)
        Me.grpTodo.TabIndex = 0
        Me.grpTodo.TabStop = False
        '
        'pb_UndoCobrar
        '
        Me.pb_UndoCobrar.Image = Global.centro_medico.My.Resources.Resources.undo_blue
        Me.pb_UndoCobrar.Location = New System.Drawing.Point(648, 39)
        Me.pb_UndoCobrar.Name = "pb_UndoCobrar"
        Me.pb_UndoCobrar.Size = New System.Drawing.Size(16, 16)
        Me.pb_UndoCobrar.TabIndex = 76
        Me.pb_UndoCobrar.TabStop = False
        '
        'chk_pagado
        '
        Me.chk_pagado.AutoSize = True
        Me.chk_pagado.Location = New System.Drawing.Point(528, 41)
        Me.chk_pagado.Name = "chk_pagado"
        Me.chk_pagado.Size = New System.Drawing.Size(15, 14)
        Me.chk_pagado.TabIndex = 26
        Me.chk_pagado.UseVisualStyleBackColor = True
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(6, 19)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(425, 53)
        Me.CtrlPaciente1.TabIndex = 0
        '
        'FechaPagadoDateTimePicker
        '
        Me.FechaPagadoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.NTicketBindingSource, "Pagado", True))
        Me.FechaPagadoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NTicketBindingSource, "FechaPagado", True))
        Me.FechaPagadoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaPagadoDateTimePicker.Location = New System.Drawing.Point(546, 39)
        Me.FechaPagadoDateTimePicker.Name = "FechaPagadoDateTimePicker"
        Me.FechaPagadoDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.FechaPagadoDateTimePicker.TabIndex = 1
        '
        'NTicketBindingSource
        '
        Me.NTicketBindingSource.DataSource = GetType(centro_medico.N_Ticket)
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NTicketBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(283, 81)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.FechaDateTimePicker.TabIndex = 3
        '
        'ID_FormaPagoComboBox
        '
        Me.ID_FormaPagoComboBox.DisplayMember = "DESCRIPCION"
        Me.ID_FormaPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ID_FormaPagoComboBox.FormattingEnabled = True
        Me.ID_FormaPagoComboBox.Location = New System.Drawing.Point(531, 65)
        Me.ID_FormaPagoComboBox.Name = "ID_FormaPagoComboBox"
        Me.ID_FormaPagoComboBox.Size = New System.Drawing.Size(174, 21)
        Me.ID_FormaPagoComboBox.TabIndex = 4
        Me.ID_FormaPagoComboBox.ValueMember = "CODIGO"
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.AcceptsReturn = True
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NTicketBindingSource, "Referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(75, 109)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(119, 20)
        Me.ReferenciaTextBox.TabIndex = 2
        '
        'CtrlTextboxAvanzado1
        '
        Me.CtrlTextboxAvanzado1.AcceptsReturn = True
        Me.CtrlTextboxAvanzado1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NTicketBindingSource, "Codigo", True))
        Me.CtrlTextboxAvanzado1.Location = New System.Drawing.Point(75, 81)
        Me.CtrlTextboxAvanzado1.Name = "CtrlTextboxAvanzado1"
        Me.CtrlTextboxAvanzado1.ReadOnly = True
        Me.CtrlTextboxAvanzado1.Size = New System.Drawing.Size(119, 20)
        Me.CtrlTextboxAvanzado1.TabIndex = 4
        '
        'CtrlDocProcesados1
        '
        Me.CtrlDocProcesados1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlDocProcesados1.Location = New System.Drawing.Point(766, 19)
        Me.CtrlDocProcesados1.Name = "CtrlDocProcesados1"
        Me.CtrlDocProcesados1.Size = New System.Drawing.Size(214, 119)
        Me.CtrlDocProcesados1.TabIndex = 6
        Me.CtrlDocProcesados1.TabStop = False
        '
        'lblIva
        '
        Me.lblIva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIva.Location = New System.Drawing.Point(722, 510)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(131, 23)
        Me.lblIva.TabIndex = 23
        Me.lblIva.Text = "Iva Desglosado"
        Me.lblIva.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_EmitirCita
        '
        Me.btn_EmitirCita.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_EmitirCita.Enabled = False
        Me.btn_EmitirCita.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_EmitirCita.Image = Global.centro_medico.My.Resources.Resources.Citas
        Me.btn_EmitirCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_EmitirCita.Location = New System.Drawing.Point(202, 510)
        Me.btn_EmitirCita.Name = "btn_EmitirCita"
        Me.btn_EmitirCita.Size = New System.Drawing.Size(104, 54)
        Me.btn_EmitirCita.TabIndex = 4
        Me.btn_EmitirCita.Text = "Emitir  Cita"
        Me.btn_EmitirCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EmitirCita.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btEliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEliminar.Location = New System.Drawing.Point(103, 510)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(90, 54)
        Me.btEliminar.TabIndex = 3
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btAddLinea
        '
        Me.btAddLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btAddLinea.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddLinea.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btAddLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAddLinea.Location = New System.Drawing.Point(7, 511)
        Me.btAddLinea.Name = "btAddLinea"
        Me.btAddLinea.Size = New System.Drawing.Size(90, 53)
        Me.btAddLinea.TabIndex = 2
        Me.btAddLinea.Text = "Añadir"
        Me.btAddLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAddLinea.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tlbImprimir, Me.ToolStripSeparator1, Me.tsb_DebitoPaciente})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip2.TabIndex = 7
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsb_DebitoPaciente
        '
        Me.tsb_DebitoPaciente.Image = Global.centro_medico.My.Resources.Resources.PacienteDebito
        Me.tsb_DebitoPaciente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_DebitoPaciente.Name = "tsb_DebitoPaciente"
        Me.tsb_DebitoPaciente.Size = New System.Drawing.Size(110, 22)
        Me.tsb_DebitoPaciente.Text = "Débito Paciente"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 577)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip1.TabIndex = 103
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(451, 17)
        Me.ToolStripStatusLabel1.Text = " Guardar Ticket-> F3 -- Imprimir Ticket-> F4 -- Añadir linea-> F5 -- Borrar linea" & _
    "-> F6"
        '
        'GridEXListado
        '
        Me.GridEXListado.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXListado.AutoEdit = True
        Me.GridEXListado.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEXListado.DataSource = Me.NTicketLineasBindingSource
        GridEXListado_DesignTimeLayout.LayoutString = resources.GetString("GridEXListado_DesignTimeLayout.LayoutString")
        Me.GridEXListado.DesignTimeLayout = GridEXListado_DesignTimeLayout
        Me.GridEXListado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEXListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXListado.GroupByBoxVisible = False
        Me.GridEXListado.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXListado.Location = New System.Drawing.Point(5, 168)
        Me.GridEXListado.Name = "GridEXListado"
        Me.GridEXListado.Size = New System.Drawing.Size(991, 336)
        Me.GridEXListado.TabIndex = 1
        Me.GridEXListado.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'NTicketLineasBindingSource
        '
        Me.NTicketLineasBindingSource.DataMember = "N_Ticket_Lineas"
        Me.NTicketLineasBindingSource.DataSource = Me.NTicketBindingSource
        '
        'NTipoIVABindingSource
        '
        Me.NTipoIVABindingSource.DataSource = GetType(centro_medico.N_TipoIVA)
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NTicketBindingSource, "Total", True))
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtTotal.Location = New System.Drawing.Point(860, 532)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(132, 32)
        Me.txtTotal.TabIndex = 107
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "0,00 €"
        Me.txtTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtIvaDesglosado
        '
        Me.txtIvaDesglosado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIvaDesglosado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaDesglosado.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtIvaDesglosado.Location = New System.Drawing.Point(722, 532)
        Me.txtIvaDesglosado.Name = "txtIvaDesglosado"
        Me.txtIvaDesglosado.ReadOnly = True
        Me.txtIvaDesglosado.Size = New System.Drawing.Size(131, 32)
        Me.txtIvaDesglosado.TabIndex = 107
        Me.txtIvaDesglosado.TabStop = False
        Me.txtIvaDesglosado.Text = "0,00 €"
        Me.txtIvaDesglosado.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'CtrlStatusPaciente1
        '
        Me.CtrlStatusPaciente1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlStatusPaciente1.ID_PACIENTE = Nothing
        Me.CtrlStatusPaciente1.Location = New System.Drawing.Point(760, 2)
        Me.CtrlStatusPaciente1.Name = "CtrlStatusPaciente1"
        Me.CtrlStatusPaciente1.Size = New System.Drawing.Size(236, 28)
        Me.CtrlStatusPaciente1.TabIndex = 105
        Me.CtrlStatusPaciente1.TabStop = False
        '
        'frmTPVTicketsEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 599)
        Me.Controls.Add(Me.txtIvaDesglosado)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.CtrlStatusPaciente1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GridEXListado)
        Me.Controls.Add(Me.grpTodo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.btn_EmitirCita)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btAddLinea)
        Me.KeyPreview = True
        Me.Name = "frmTPVTicketsEditar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tickets"
        Me.grpTodo.ResumeLayout(False)
        Me.grpTodo.PerformLayout()
        CType(Me.pb_UndoCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NTicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.GridEXListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NTicketLineasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NTipoIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrlStatusPaciente1 As centro_medico.ctrlStatusPaciente
    Friend WithEvents grpTodo As System.Windows.Forms.GroupBox
    Friend WithEvents FechaPagadoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents btn_EmitirCita As System.Windows.Forms.Button
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents btAddLinea As System.Windows.Forms.Button
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ID_FormaPagoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ReferenciaTextBox As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents CtrlDocProcesados1 As centro_medico.ctrlDocProcesados
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb_DebitoPaciente As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents GridEXListado As Janus.Windows.GridEX.GridEX
    Friend WithEvents NTicketBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents NTicketLineasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtrlTextboxAvanzado1 As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents NTipoIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtIvaDesglosado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents chk_pagado As System.Windows.Forms.CheckBox
    Friend WithEvents pb_UndoCobrar As System.Windows.Forms.PictureBox
End Class
