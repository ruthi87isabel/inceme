<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recibos
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
        Dim REFFORMAPAGOLabel As System.Windows.Forms.Label
        Dim PACIENTELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recibos))
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chb_emision = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chb_cobro = New System.Windows.Forms.CheckBox
        Me.dtp_fcf = New System.Windows.Forms.DateTimePicker
        Me.dtp_fci = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rb_scobrar = New System.Windows.Forms.RadioButton
        Me.rb_cobrados = New System.Windows.Forms.RadioButton
        Me.rb_todos = New System.Windows.Forms.RadioButton
        Me.lb_paciente = New System.Windows.Forms.Label
        Me.bt_forma = New System.Windows.Forms.Button
        Me.bt_paciente = New System.Windows.Forms.Button
        Me.tb_idpaciente = New ctrlTextboxAvanzado
        Me.tb_idforma = New ctrlTextboxAvanzado
        Me.lb_forma = New System.Windows.Forms.Label
        Me.chb_concepto = New System.Windows.Forms.CheckBox
        Me.tb_concepto = New ctrlTextboxAvanzado
        Me.bt_filtrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.dgv_recibos = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.lb_importe = New System.Windows.Forms.Label
        Me.bt_cerrar = New System.Windows.Forms.Button
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.FORMASPAGOTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
        Me.FORMASPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECIBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECIBOSTableAdapter = New centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
        REFFORMAPAGOLabel = New System.Windows.Forms.Label
        PACIENTELabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'REFFORMAPAGOLabel
        '
        REFFORMAPAGOLabel.AutoSize = True
        REFFORMAPAGOLabel.Location = New System.Drawing.Point(413, 117)
        REFFORMAPAGOLabel.Name = "REFFORMAPAGOLabel"
        REFFORMAPAGOLabel.Size = New System.Drawing.Size(66, 13)
        REFFORMAPAGOLabel.TabIndex = 7
        REFFORMAPAGOLabel.Text = "Forma pago:"
        '
        'PACIENTELabel
        '
        PACIENTELabel.AutoSize = True
        PACIENTELabel.Location = New System.Drawing.Point(419, 8)
        PACIENTELabel.Name = "PACIENTELabel"
        PACIENTELabel.Size = New System.Drawing.Size(52, 13)
        PACIENTELabel.TabIndex = 2
        PACIENTELabel.Text = "Paciente:"
        '
        'dtp_ff
        '
        Me.dtp_ff.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_ff.Enabled = False
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(138, 39)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_ff.TabIndex = 2
        '
        'dtp_fi
        '
        Me.dtp_fi.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fi.Enabled = False
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(6, 39)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fi.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chb_emision)
        Me.GroupBox1.Controls.Add(Me.dtp_ff)
        Me.GroupBox1.Controls.Add(Me.dtp_fi)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chb_emision
        '
        Me.chb_emision.AutoSize = True
        Me.chb_emision.Location = New System.Drawing.Point(6, 16)
        Me.chb_emision.Name = "chb_emision"
        Me.chb_emision.Size = New System.Drawing.Size(110, 17)
        Me.chb_emision.TabIndex = 0
        Me.chb_emision.Text = "Fecha de Emisión"
        Me.chb_emision.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chb_cobro)
        Me.GroupBox2.Controls.Add(Me.dtp_fcf)
        Me.GroupBox2.Controls.Add(Me.dtp_fci)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 73)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'chb_cobro
        '
        Me.chb_cobro.AutoSize = True
        Me.chb_cobro.Location = New System.Drawing.Point(6, 17)
        Me.chb_cobro.Name = "chb_cobro"
        Me.chb_cobro.Size = New System.Drawing.Size(102, 17)
        Me.chb_cobro.TabIndex = 56
        Me.chb_cobro.Text = "Fecha de Cobro"
        Me.chb_cobro.UseVisualStyleBackColor = True
        '
        'dtp_fcf
        '
        Me.dtp_fcf.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fcf.Enabled = False
        Me.dtp_fcf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fcf.Location = New System.Drawing.Point(138, 40)
        Me.dtp_fcf.Name = "dtp_fcf"
        Me.dtp_fcf.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fcf.TabIndex = 1
        '
        'dtp_fci
        '
        Me.dtp_fci.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fci.Enabled = False
        Me.dtp_fci.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fci.Location = New System.Drawing.Point(6, 40)
        Me.dtp_fci.Name = "dtp_fci"
        Me.dtp_fci.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fci.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_scobrar)
        Me.GroupBox3.Controls.Add(Me.rb_cobrados)
        Me.GroupBox3.Controls.Add(Me.rb_todos)
        Me.GroupBox3.Location = New System.Drawing.Point(281, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(111, 156)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado"
        '
        'rb_scobrar
        '
        Me.rb_scobrar.AutoSize = True
        Me.rb_scobrar.Location = New System.Drawing.Point(12, 111)
        Me.rb_scobrar.Name = "rb_scobrar"
        Me.rb_scobrar.Size = New System.Drawing.Size(73, 17)
        Me.rb_scobrar.TabIndex = 2
        Me.rb_scobrar.Text = "Sin cobrar"
        Me.rb_scobrar.UseVisualStyleBackColor = True
        '
        'rb_cobrados
        '
        Me.rb_cobrados.AutoSize = True
        Me.rb_cobrados.Location = New System.Drawing.Point(10, 70)
        Me.rb_cobrados.Name = "rb_cobrados"
        Me.rb_cobrados.Size = New System.Drawing.Size(70, 17)
        Me.rb_cobrados.TabIndex = 1
        Me.rb_cobrados.Text = "Cobrados"
        Me.rb_cobrados.UseVisualStyleBackColor = True
        '
        'rb_todos
        '
        Me.rb_todos.AutoSize = True
        Me.rb_todos.Checked = True
        Me.rb_todos.Location = New System.Drawing.Point(12, 28)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(55, 17)
        Me.rb_todos.TabIndex = 0
        Me.rb_todos.TabStop = True
        Me.rb_todos.Text = "Todos"
        Me.rb_todos.UseVisualStyleBackColor = True
        '
        'lb_paciente
        '
        Me.lb_paciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_paciente.Location = New System.Drawing.Point(535, 27)
        Me.lb_paciente.Name = "lb_paciente"
        Me.lb_paciente.Size = New System.Drawing.Size(259, 20)
        Me.lb_paciente.TabIndex = 124
        '
        'bt_forma
        '
        Me.bt_forma.BackgroundImage = CType(resources.GetObject("bt_forma.BackgroundImage"), System.Drawing.Image)
        Me.bt_forma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_forma.Location = New System.Drawing.Point(488, 136)
        Me.bt_forma.Name = "bt_forma"
        Me.bt_forma.Size = New System.Drawing.Size(36, 23)
        Me.bt_forma.TabIndex = 9
        Me.bt_forma.UseVisualStyleBackColor = True
        '
        'bt_paciente
        '
        Me.bt_paciente.BackgroundImage = CType(resources.GetObject("bt_paciente.BackgroundImage"), System.Drawing.Image)
        Me.bt_paciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_paciente.Location = New System.Drawing.Point(492, 24)
        Me.bt_paciente.Name = "bt_paciente"
        Me.bt_paciente.Size = New System.Drawing.Size(36, 23)
        Me.bt_paciente.TabIndex = 4
        Me.bt_paciente.UseVisualStyleBackColor = True
        '
        'tb_idpaciente
        '
        Me.tb_idpaciente.BackColor = System.Drawing.Color.White
        Me.tb_idpaciente.Location = New System.Drawing.Point(417, 24)
        Me.tb_idpaciente.Name = "tb_idpaciente"
        Me.tb_idpaciente.Size = New System.Drawing.Size(75, 20)
        Me.tb_idpaciente.TabIndex = 3
        '
        'tb_idforma
        '
        Me.tb_idforma.BackColor = System.Drawing.Color.White
        Me.tb_idforma.Location = New System.Drawing.Point(413, 138)
        Me.tb_idforma.Name = "tb_idforma"
        Me.tb_idforma.Size = New System.Drawing.Size(75, 20)
        Me.tb_idforma.TabIndex = 8
        '
        'lb_forma
        '
        Me.lb_forma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_forma.Location = New System.Drawing.Point(532, 140)
        Me.lb_forma.Name = "lb_forma"
        Me.lb_forma.Size = New System.Drawing.Size(154, 20)
        Me.lb_forma.TabIndex = 10
        '
        'chb_concepto
        '
        Me.chb_concepto.AutoSize = True
        Me.chb_concepto.Location = New System.Drawing.Point(416, 60)
        Me.chb_concepto.Name = "chb_concepto"
        Me.chb_concepto.Size = New System.Drawing.Size(72, 17)
        Me.chb_concepto.TabIndex = 5
        Me.chb_concepto.Text = "Concepto"
        Me.chb_concepto.UseVisualStyleBackColor = True
        '
        'tb_concepto
        '
        Me.tb_concepto.BackColor = System.Drawing.Color.White
        Me.tb_concepto.Enabled = False
        Me.tb_concepto.Location = New System.Drawing.Point(416, 85)
        Me.tb_concepto.Name = "tb_concepto"
        Me.tb_concepto.Size = New System.Drawing.Size(378, 20)
        Me.tb_concepto.TabIndex = 6
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.ImageIndex = 0
        Me.bt_filtrar.ImageList = Me.ImageList1
        Me.bt_filtrar.Location = New System.Drawing.Point(698, 138)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(93, 23)
        Me.bt_filtrar.TabIndex = 11
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search4doc.ico")
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(632, 471)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 28)
        Me.bt_imprimir.TabIndex = 16
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'dgv_recibos
        '
        Me.dgv_recibos.AllowUserToAddRows = False
        Me.dgv_recibos.AllowUserToDeleteRows = False
        Me.dgv_recibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_recibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_recibos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_recibos.BackgroundColor = System.Drawing.Color.White
        Me.dgv_recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_recibos.Location = New System.Drawing.Point(8, 171)
        Me.dgv_recibos.MultiSelect = False
        Me.dgv_recibos.Name = "dgv_recibos"
        Me.dgv_recibos.ReadOnly = True
        Me.dgv_recibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_recibos.Size = New System.Drawing.Size(783, 244)
        Me.dgv_recibos.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(594, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Importe Recibos:"
        '
        'lb_importe
        '
        Me.lb_importe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_importe.Location = New System.Drawing.Point(688, 427)
        Me.lb_importe.Name = "lb_importe"
        Me.lb_importe.Size = New System.Drawing.Size(100, 23)
        Me.lb_importe.TabIndex = 15
        Me.lb_importe.Text = "0.00  €"
        Me.lb_importe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cerrar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cerrar.Location = New System.Drawing.Point(713, 471)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 28)
        Me.bt_cerrar.TabIndex = 17
        Me.bt_cerrar.Text = "    Cerrar"
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'FORMASPAGOTableAdapter
        '
        Me.FORMASPAGOTableAdapter.ClearBeforeFill = True
        '
        'FORMASPAGOBindingSource
        '
        Me.FORMASPAGOBindingSource.DataMember = "FORMASPAGO"
        Me.FORMASPAGOBindingSource.DataSource = Me.CMDataSet
        '
        'RECIBOSBindingSource
        '
        Me.RECIBOSBindingSource.DataMember = "RECIBOS"
        Me.RECIBOSBindingSource.DataSource = Me.CMDataSet
        '
        'RECIBOSTableAdapter
        '
        Me.RECIBOSTableAdapter.ClearBeforeFill = True
        '
        'Recibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(798, 503)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lb_importe)
        Me.Controls.Add(Me.dgv_recibos)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.bt_filtrar)
        Me.Controls.Add(Me.tb_concepto)
        Me.Controls.Add(Me.chb_concepto)
        Me.Controls.Add(Me.lb_paciente)
        Me.Controls.Add(Me.bt_forma)
        Me.Controls.Add(Me.bt_paciente)
        Me.Controls.Add(Me.tb_idpaciente)
        Me.Controls.Add(REFFORMAPAGOLabel)
        Me.Controls.Add(Me.tb_idforma)
        Me.Controls.Add(Me.lb_forma)
        Me.Controls.Add(PACIENTELabel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Recibos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de recibos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_recibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_emision As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_cobro As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_fcf As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fci As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_scobrar As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cobrados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents lb_paciente As System.Windows.Forms.Label
    Friend WithEvents bt_forma As System.Windows.Forms.Button
    Friend WithEvents bt_paciente As System.Windows.Forms.Button
    Friend WithEvents tb_idpaciente As ctrlTextboxAvanzado
    Friend WithEvents tb_idforma As ctrlTextboxAvanzado
    Friend WithEvents lb_forma As System.Windows.Forms.Label
    Friend WithEvents chb_concepto As System.Windows.Forms.CheckBox
    Friend WithEvents tb_concepto As ctrlTextboxAvanzado
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents dgv_recibos As System.Windows.Forms.DataGridView
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
    Friend WithEvents FORMASPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lb_importe As System.Windows.Forms.Label
    Friend WithEvents RECIBOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECIBOSTableAdapter As centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
