<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Partes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Partes))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.lb_paciente = New System.Windows.Forms.Label
        Me.tb_idpaciente = New ctrlTextboxAvanzado
        Me.tb_mutua = New ctrlTextboxAvanzado
        Me.lb_mutua = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgv_partes = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chb_asist = New System.Windows.Forms.CheckBox
        Me.chb_bajacalta = New System.Windows.Forms.CheckBox
        Me.chb_bajasalta = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chb_sinfacturar = New System.Windows.Forms.CheckBox
        Me.chb_facturado = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chb_sincobrar = New System.Windows.Forms.CheckBox
        Me.chb_cobrado = New System.Windows.Forms.CheckBox
        Me.chb_altasext = New System.Windows.Forms.CheckBox
        Me.PARTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PARTESTableAdapter
        Me.PARTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.ASISTENCIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASISTENCIASTableAdapter = New centro_medico.CMDataSetTableAdapters.ASISTENCIASTableAdapter
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAJASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAJASTableAdapter = New centro_medico.CMDataSetTableAdapters.BAJASTableAdapter
        Me.ALTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALTASTableAdapter = New centro_medico.CMDataSetTableAdapters.ALTASTableAdapter
        Me.bt_mutua = New System.Windows.Forms.Button
        Me.bt_paciente = New System.Windows.Forms.Button
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.bt_filtrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_cerrar = New System.Windows.Forms.Button
        CType(Me.dgv_partes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PARTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAJASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.GhostWhite
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(636, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Partes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Fecha final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Fecha Inicial"
        '
        'dtp_ff
        '
        Me.dtp_ff.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(136, 46)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(4, 46)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fi.TabIndex = 0
        '
        'lb_paciente
        '
        Me.lb_paciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_paciente.Location = New System.Drawing.Point(423, 126)
        Me.lb_paciente.Name = "lb_paciente"
        Me.lb_paciente.Size = New System.Drawing.Size(208, 20)
        Me.lb_paciente.TabIndex = 11
        '
        'tb_idpaciente
        '
        Me.tb_idpaciente.BackColor = System.Drawing.Color.White
        Me.tb_idpaciente.Location = New System.Drawing.Point(326, 124)
        Me.tb_idpaciente.Name = "tb_idpaciente"
        Me.tb_idpaciente.Size = New System.Drawing.Size(62, 20)
        Me.tb_idpaciente.TabIndex = 9
        '
        'tb_mutua
        '
        Me.tb_mutua.BackColor = System.Drawing.Color.White
        Me.tb_mutua.Location = New System.Drawing.Point(326, 86)
        Me.tb_mutua.Name = "tb_mutua"
        Me.tb_mutua.Size = New System.Drawing.Size(62, 20)
        Me.tb_mutua.TabIndex = 6
        '
        'lb_mutua
        '
        Me.lb_mutua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_mutua.Location = New System.Drawing.Point(423, 88)
        Me.lb_mutua.Name = "lb_mutua"
        Me.lb_mutua.Size = New System.Drawing.Size(208, 20)
        Me.lb_mutua.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Filtrar Paciente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Filtrar Mutua"
        '
        'dgv_partes
        '
        Me.dgv_partes.AllowUserToAddRows = False
        Me.dgv_partes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_partes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_partes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_partes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_partes.Location = New System.Drawing.Point(4, 163)
        Me.dgv_partes.MultiSelect = False
        Me.dgv_partes.Name = "dgv_partes"
        Me.dgv_partes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_partes.Size = New System.Drawing.Size(627, 284)
        Me.dgv_partes.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chb_asist)
        Me.GroupBox1.Controls.Add(Me.chb_bajacalta)
        Me.GroupBox1.Controls.Add(Me.chb_bajasalta)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(101, 87)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'chb_asist
        '
        Me.chb_asist.AutoSize = True
        Me.chb_asist.Checked = True
        Me.chb_asist.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_asist.Location = New System.Drawing.Point(6, 60)
        Me.chb_asist.Name = "chb_asist"
        Me.chb_asist.Size = New System.Drawing.Size(74, 17)
        Me.chb_asist.TabIndex = 4
        Me.chb_asist.Text = "Asistencia"
        Me.chb_asist.UseVisualStyleBackColor = True
        '
        'chb_bajacalta
        '
        Me.chb_bajacalta.AutoSize = True
        Me.chb_bajacalta.Checked = True
        Me.chb_bajacalta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_bajacalta.Location = New System.Drawing.Point(6, 39)
        Me.chb_bajacalta.Name = "chb_bajacalta"
        Me.chb_bajacalta.Size = New System.Drawing.Size(88, 17)
        Me.chb_bajacalta.TabIndex = 3
        Me.chb_bajacalta.Text = "Baja con alta"
        Me.chb_bajacalta.UseVisualStyleBackColor = True
        '
        'chb_bajasalta
        '
        Me.chb_bajasalta.AutoSize = True
        Me.chb_bajasalta.Checked = True
        Me.chb_bajasalta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_bajasalta.Location = New System.Drawing.Point(6, 19)
        Me.chb_bajasalta.Name = "chb_bajasalta"
        Me.chb_bajasalta.Size = New System.Drawing.Size(83, 17)
        Me.chb_bajasalta.TabIndex = 2
        Me.chb_bajasalta.Text = "Baja sin alta"
        Me.chb_bajasalta.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chb_sinfacturar)
        Me.GroupBox2.Controls.Add(Me.chb_facturado)
        Me.GroupBox2.Location = New System.Drawing.Point(115, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(110, 61)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado de factura"
        '
        'chb_sinfacturar
        '
        Me.chb_sinfacturar.AutoSize = True
        Me.chb_sinfacturar.Checked = True
        Me.chb_sinfacturar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_sinfacturar.Location = New System.Drawing.Point(12, 35)
        Me.chb_sinfacturar.Name = "chb_sinfacturar"
        Me.chb_sinfacturar.Size = New System.Drawing.Size(80, 17)
        Me.chb_sinfacturar.TabIndex = 3
        Me.chb_sinfacturar.Text = "Sin facturar"
        Me.chb_sinfacturar.UseVisualStyleBackColor = True
        '
        'chb_facturado
        '
        Me.chb_facturado.AutoSize = True
        Me.chb_facturado.Checked = True
        Me.chb_facturado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_facturado.Location = New System.Drawing.Point(12, 17)
        Me.chb_facturado.Name = "chb_facturado"
        Me.chb_facturado.Size = New System.Drawing.Size(74, 17)
        Me.chb_facturado.TabIndex = 2
        Me.chb_facturado.Text = "Facturado"
        Me.chb_facturado.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chb_sincobrar)
        Me.GroupBox3.Controls.Add(Me.chb_cobrado)
        Me.GroupBox3.Location = New System.Drawing.Point(231, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(89, 61)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado cobro"
        '
        'chb_sincobrar
        '
        Me.chb_sincobrar.AutoSize = True
        Me.chb_sincobrar.Checked = True
        Me.chb_sincobrar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_sincobrar.Location = New System.Drawing.Point(6, 37)
        Me.chb_sincobrar.Name = "chb_sincobrar"
        Me.chb_sincobrar.Size = New System.Drawing.Size(74, 17)
        Me.chb_sincobrar.TabIndex = 1
        Me.chb_sincobrar.Text = "Sin cobrar"
        Me.chb_sincobrar.UseVisualStyleBackColor = True
        '
        'chb_cobrado
        '
        Me.chb_cobrado.AutoSize = True
        Me.chb_cobrado.Checked = True
        Me.chb_cobrado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_cobrado.Location = New System.Drawing.Point(6, 19)
        Me.chb_cobrado.Name = "chb_cobrado"
        Me.chb_cobrado.Size = New System.Drawing.Size(66, 17)
        Me.chb_cobrado.TabIndex = 0
        Me.chb_cobrado.Text = "Cobrado"
        Me.chb_cobrado.UseVisualStyleBackColor = True
        '
        'chb_altasext
        '
        Me.chb_altasext.AutoSize = True
        Me.chb_altasext.Checked = True
        Me.chb_altasext.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_altasext.Location = New System.Drawing.Point(127, 139)
        Me.chb_altasext.Name = "chb_altasext"
        Me.chb_altasext.Size = New System.Drawing.Size(92, 17)
        Me.chb_altasext.TabIndex = 128
        Me.chb_altasext.Text = "Altas externas"
        Me.chb_altasext.UseVisualStyleBackColor = True
        '
        'PARTESTableAdapter
        '
        Me.PARTESTableAdapter.ClearBeforeFill = True
        '
        'PARTESBindingSource
        '
        Me.PARTESBindingSource.DataMember = "PARTES"
        Me.PARTESBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ASISTENCIASBindingSource
        '
        Me.ASISTENCIASBindingSource.DataMember = "ASISTENCIAS"
        Me.ASISTENCIASBindingSource.DataSource = Me.CMDataSet
        '
        'ASISTENCIASTableAdapter
        '
        Me.ASISTENCIASTableAdapter.ClearBeforeFill = True
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
        'MUTUASBindingSource
        '
        Me.MUTUASBindingSource.DataMember = "MUTUAS"
        Me.MUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'MUTUASTableAdapter
        '
        Me.MUTUASTableAdapter.ClearBeforeFill = True
        '
        'FACTURASTableAdapter
        '
        Me.FACTURASTableAdapter.ClearBeforeFill = True
        '
        'FACTURASBindingSource
        '
        Me.FACTURASBindingSource.DataMember = "FACTURAS"
        Me.FACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'BAJASBindingSource
        '
        Me.BAJASBindingSource.DataMember = "BAJAS"
        Me.BAJASBindingSource.DataSource = Me.CMDataSet
        '
        'BAJASTableAdapter
        '
        Me.BAJASTableAdapter.ClearBeforeFill = True
        '
        'ALTASBindingSource
        '
        Me.ALTASBindingSource.DataMember = "ALTAS"
        Me.ALTASBindingSource.DataSource = Me.CMDataSet
        '
        'ALTASTableAdapter
        '
        Me.ALTASTableAdapter.ClearBeforeFill = True
        '
        'bt_mutua
        '
        Me.bt_mutua.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_mutua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_mutua.Location = New System.Drawing.Point(384, 83)
        Me.bt_mutua.Name = "bt_mutua"
        Me.bt_mutua.Size = New System.Drawing.Size(33, 23)
        Me.bt_mutua.TabIndex = 7
        Me.bt_mutua.UseVisualStyleBackColor = True
        '
        'bt_paciente
        '
        Me.bt_paciente.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_paciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_paciente.Location = New System.Drawing.Point(384, 122)
        Me.bt_paciente.Name = "bt_paciente"
        Me.bt_paciente.Size = New System.Drawing.Size(33, 23)
        Me.bt_paciente.TabIndex = 10
        Me.bt_paciente.UseVisualStyleBackColor = True
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Enabled = False
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(475, 461)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 28)
        Me.bt_imprimir.TabIndex = 15
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'bt_filtrar
        '
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.ImageIndex = 0
        Me.bt_filtrar.ImageList = Me.ImageList1
        Me.bt_filtrar.Location = New System.Drawing.Point(394, 461)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(75, 28)
        Me.bt_filtrar.TabIndex = 13
        Me.bt_filtrar.Text = "         Filtrar"
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search4doc.ico")
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cerrar.Location = New System.Drawing.Point(556, 461)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 28)
        Me.bt_cerrar.TabIndex = 16
        Me.bt_cerrar.Text = "Cancelar"
        Me.bt_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'Partes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(637, 491)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.chb_altasext)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_partes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lb_paciente)
        Me.Controls.Add(Me.bt_mutua)
        Me.Controls.Add(Me.bt_paciente)
        Me.Controls.Add(Me.tb_idpaciente)
        Me.Controls.Add(Me.tb_mutua)
        Me.Controls.Add(Me.lb_mutua)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.bt_filtrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Partes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Partes"
        CType(Me.dgv_partes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PARTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAJASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents lb_paciente As System.Windows.Forms.Label
    Friend WithEvents bt_mutua As System.Windows.Forms.Button
    Friend WithEvents bt_paciente As System.Windows.Forms.Button
    Friend WithEvents tb_idpaciente As ctrlTextboxAvanzado
    Friend WithEvents tb_mutua As ctrlTextboxAvanzado
    Friend WithEvents lb_mutua As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgv_partes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_asist As System.Windows.Forms.CheckBox
    Friend WithEvents chb_bajacalta As System.Windows.Forms.CheckBox
    Friend WithEvents chb_bajasalta As System.Windows.Forms.CheckBox
    Friend WithEvents chb_sinfacturar As System.Windows.Forms.CheckBox
    Friend WithEvents chb_facturado As System.Windows.Forms.CheckBox
    Friend WithEvents chb_sincobrar As System.Windows.Forms.CheckBox
    Friend WithEvents chb_cobrado As System.Windows.Forms.CheckBox
    Friend WithEvents chb_altasext As System.Windows.Forms.CheckBox
    Friend WithEvents PARTESTableAdapter As centro_medico.CMDataSetTableAdapters.PARTESTableAdapter
    Friend WithEvents PARTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ASISTENCIASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASISTENCIASTableAdapter As centro_medico.CMDataSetTableAdapters.ASISTENCIASTableAdapter
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BAJASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BAJASTableAdapter As centro_medico.CMDataSetTableAdapters.BAJASTableAdapter
    Friend WithEvents ALTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALTASTableAdapter As centro_medico.CMDataSetTableAdapters.ALTASTableAdapter
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
