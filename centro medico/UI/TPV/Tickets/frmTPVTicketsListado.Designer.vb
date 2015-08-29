<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTPVTicketsListado
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
        Dim GridEXListado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTPVTicketsListado))
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.grp_Pagados = New System.Windows.Forms.GroupBox()
        Me.rb_Sinpagar = New System.Windows.Forms.RadioButton()
        Me.rb_Pagados = New System.Windows.Forms.RadioButton()
        Me.rb_Todos = New System.Windows.Forms.RadioButton()
        Me.grp_FechaPagado = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_FP_Ini = New System.Windows.Forms.DateTimePicker()
        Me.dt_FP_Fin = New System.Windows.Forms.DateTimePicker()
        Me.grp_FechaCreacion = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_FC_Ini = New System.Windows.Forms.DateTimePicker()
        Me.dt_FC_Fin = New System.Windows.Forms.DateTimePicker()
        Me.bt_Filtrar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.GridEXListado = New Janus.Windows.GridEX.GridEX()
        Me.NTicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkSolo100primeros = New System.Windows.Forms.CheckBox()
        Me.grp_Pagados.SuspendLayout()
        Me.grp_FechaPagado.SuspendLayout()
        Me.grp_FechaCreacion.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridEXListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NTicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(6, 27)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(425, 53)
        Me.CtrlPaciente1.TabIndex = 34
        '
        'grp_Pagados
        '
        Me.grp_Pagados.Controls.Add(Me.rb_Sinpagar)
        Me.grp_Pagados.Controls.Add(Me.rb_Pagados)
        Me.grp_Pagados.Controls.Add(Me.rb_Todos)
        Me.grp_Pagados.Location = New System.Drawing.Point(448, 15)
        Me.grp_Pagados.Name = "grp_Pagados"
        Me.grp_Pagados.Size = New System.Drawing.Size(90, 83)
        Me.grp_Pagados.TabIndex = 32
        Me.grp_Pagados.TabStop = False
        Me.grp_Pagados.Text = "Pago"
        '
        'rb_Sinpagar
        '
        Me.rb_Sinpagar.AutoSize = True
        Me.rb_Sinpagar.Location = New System.Drawing.Point(6, 61)
        Me.rb_Sinpagar.Name = "rb_Sinpagar"
        Me.rb_Sinpagar.Size = New System.Drawing.Size(70, 17)
        Me.rb_Sinpagar.TabIndex = 0
        Me.rb_Sinpagar.Text = "Sin pagar"
        Me.rb_Sinpagar.UseVisualStyleBackColor = True
        '
        'rb_Pagados
        '
        Me.rb_Pagados.AutoSize = True
        Me.rb_Pagados.Location = New System.Drawing.Point(6, 40)
        Me.rb_Pagados.Name = "rb_Pagados"
        Me.rb_Pagados.Size = New System.Drawing.Size(67, 17)
        Me.rb_Pagados.TabIndex = 0
        Me.rb_Pagados.Text = "Pagados"
        Me.rb_Pagados.UseVisualStyleBackColor = True
        '
        'rb_Todos
        '
        Me.rb_Todos.AutoSize = True
        Me.rb_Todos.Checked = True
        Me.rb_Todos.Location = New System.Drawing.Point(6, 18)
        Me.rb_Todos.Name = "rb_Todos"
        Me.rb_Todos.Size = New System.Drawing.Size(55, 17)
        Me.rb_Todos.TabIndex = 0
        Me.rb_Todos.TabStop = True
        Me.rb_Todos.Text = "Todos"
        Me.rb_Todos.UseVisualStyleBackColor = True
        '
        'grp_FechaPagado
        '
        Me.grp_FechaPagado.Controls.Add(Me.Label3)
        Me.grp_FechaPagado.Controls.Add(Me.Label4)
        Me.grp_FechaPagado.Controls.Add(Me.dt_FP_Ini)
        Me.grp_FechaPagado.Controls.Add(Me.dt_FP_Fin)
        Me.grp_FechaPagado.Location = New System.Drawing.Point(714, 15)
        Me.grp_FechaPagado.Name = "grp_FechaPagado"
        Me.grp_FechaPagado.Size = New System.Drawing.Size(162, 83)
        Me.grp_FechaPagado.TabIndex = 30
        Me.grp_FechaPagado.TabStop = False
        Me.grp_FechaPagado.Text = "Fecha Pagado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Desde"
        '
        'dt_FP_Ini
        '
        Me.dt_FP_Ini.Checked = False
        Me.dt_FP_Ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_FP_Ini.Location = New System.Drawing.Point(47, 25)
        Me.dt_FP_Ini.Name = "dt_FP_Ini"
        Me.dt_FP_Ini.ShowCheckBox = True
        Me.dt_FP_Ini.Size = New System.Drawing.Size(99, 20)
        Me.dt_FP_Ini.TabIndex = 13
        '
        'dt_FP_Fin
        '
        Me.dt_FP_Fin.Checked = False
        Me.dt_FP_Fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_FP_Fin.Location = New System.Drawing.Point(47, 50)
        Me.dt_FP_Fin.Name = "dt_FP_Fin"
        Me.dt_FP_Fin.ShowCheckBox = True
        Me.dt_FP_Fin.Size = New System.Drawing.Size(99, 20)
        Me.dt_FP_Fin.TabIndex = 14
        '
        'grp_FechaCreacion
        '
        Me.grp_FechaCreacion.Controls.Add(Me.Label2)
        Me.grp_FechaCreacion.Controls.Add(Me.Label1)
        Me.grp_FechaCreacion.Controls.Add(Me.dt_FC_Ini)
        Me.grp_FechaCreacion.Controls.Add(Me.dt_FC_Fin)
        Me.grp_FechaCreacion.Location = New System.Drawing.Point(556, 15)
        Me.grp_FechaCreacion.Name = "grp_FechaCreacion"
        Me.grp_FechaCreacion.Size = New System.Drawing.Size(151, 83)
        Me.grp_FechaCreacion.TabIndex = 28
        Me.grp_FechaCreacion.TabStop = False
        Me.grp_FechaCreacion.Text = "Fecha Creación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Desde"
        '
        'dt_FC_Ini
        '
        Me.dt_FC_Ini.Checked = False
        Me.dt_FC_Ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_FC_Ini.Location = New System.Drawing.Point(51, 25)
        Me.dt_FC_Ini.Name = "dt_FC_Ini"
        Me.dt_FC_Ini.Size = New System.Drawing.Size(90, 20)
        Me.dt_FC_Ini.TabIndex = 13
        '
        'dt_FC_Fin
        '
        Me.dt_FC_Fin.Checked = False
        Me.dt_FC_Fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_FC_Fin.Location = New System.Drawing.Point(51, 50)
        Me.dt_FC_Fin.Name = "dt_FC_Fin"
        Me.dt_FC_Fin.Size = New System.Drawing.Size(90, 20)
        Me.dt_FC_Fin.TabIndex = 14
        '
        'bt_Filtrar
        '
        Me.bt_Filtrar.Location = New System.Drawing.Point(882, 28)
        Me.bt_Filtrar.Name = "bt_Filtrar"
        Me.bt_Filtrar.Size = New System.Drawing.Size(75, 60)
        Me.bt_Filtrar.TabIndex = 27
        Me.bt_Filtrar.Text = "Filtrar"
        Me.bt_Filtrar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(967, 25)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.NewToolStripButton.Text = "&Añadir"
        '
        'tst_Editar
        '
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar.Text = "&Modificar"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(102, 22)
        Me.tst_Eliminar.Text = "&Eliminar ticket"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'GridEXListado
        '
        Me.GridEXListado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXListado.ColumnAutoResize = True
        Me.GridEXListado.DataSource = Me.NTicketBindingSource
        GridEXListado_DesignTimeLayout.LayoutString = resources.GetString("GridEXListado_DesignTimeLayout.LayoutString")
        Me.GridEXListado.DesignTimeLayout = GridEXListado_DesignTimeLayout
        Me.GridEXListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXListado.GroupByBoxVisible = False
        Me.GridEXListado.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXListado.Location = New System.Drawing.Point(6, 112)
        Me.GridEXListado.Name = "GridEXListado"
        Me.GridEXListado.Size = New System.Drawing.Size(951, 439)
        Me.GridEXListado.TabIndex = 35
        Me.GridEXListado.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXListado.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'NTicketBindingSource
        '
        Me.NTicketBindingSource.DataSource = GetType(centro_medico.N_Ticket)
        '
        'chkSolo100primeros
        '
        Me.chkSolo100primeros.AutoSize = True
        Me.chkSolo100primeros.Checked = True
        Me.chkSolo100primeros.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSolo100primeros.Location = New System.Drawing.Point(269, 81)
        Me.chkSolo100primeros.Name = "chkSolo100primeros"
        Me.chkSolo100primeros.Size = New System.Drawing.Size(162, 17)
        Me.chkSolo100primeros.TabIndex = 36
        Me.chkSolo100primeros.Text = "Mostrar solo los 100 primeros"
        Me.chkSolo100primeros.UseVisualStyleBackColor = True
        '
        'frmTPVTicketsListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 563)
        Me.Controls.Add(Me.chkSolo100primeros)
        Me.Controls.Add(Me.GridEXListado)
        Me.Controls.Add(Me.CtrlPaciente1)
        Me.Controls.Add(Me.grp_Pagados)
        Me.Controls.Add(Me.grp_FechaPagado)
        Me.Controls.Add(Me.grp_FechaCreacion)
        Me.Controls.Add(Me.bt_Filtrar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmTPVTicketsListado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tickets"
        Me.grp_Pagados.ResumeLayout(False)
        Me.grp_Pagados.PerformLayout()
        Me.grp_FechaPagado.ResumeLayout(False)
        Me.grp_FechaPagado.PerformLayout()
        Me.grp_FechaCreacion.ResumeLayout(False)
        Me.grp_FechaCreacion.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridEXListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NTicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents grp_Pagados As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Sinpagar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Pagados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents grp_FechaPagado As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_FP_Ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_FP_Fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp_FechaCreacion As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_FC_Ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_FC_Fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_Filtrar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridEXListado As Janus.Windows.GridEX.GridEX
    Friend WithEvents NTicketBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents chkSolo100primeros As System.Windows.Forms.CheckBox
End Class
