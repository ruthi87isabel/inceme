<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citas_Por_Especialista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Citas_Por_Especialista))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.bt_filtrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lb_medico2 = New System.Windows.Forms.Label
        Me.bt_medico2 = New System.Windows.Forms.Button
        Me.tb_medico2 = New ctrlTextboxAvanzado
        Me.lb_medico1 = New System.Windows.Forms.Label
        Me.bt_medico1 = New System.Windows.Forms.Button
        Me.tb_medico1 = New ctrlTextboxAvanzado
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgv_citas = New System.Windows.Forms.DataGridView
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lb_medico = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lb_clinica = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lb_total = New System.Windows.Forms.Label
        Me.CITASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_cerrar = New System.Windows.Forms.Button
        Me.CITASTableAdapter = New centro_medico.CMDataSetTableAdapters.CITASTableAdapter
        Me.MEDICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_citas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Fecha final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Fecha Inicial"
        '
        'dtp_ff
        '
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(144, 39)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_ff.TabIndex = 2
        '
        'dtp_fi
        '
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(12, 39)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fi.TabIndex = 1
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.ImageIndex = 0
        Me.bt_filtrar.ImageList = Me.ImageList1
        Me.bt_filtrar.Location = New System.Drawing.Point(570, 149)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(93, 23)
        Me.bt_filtrar.TabIndex = 9
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search4doc.ico")
        '
        'lb_medico2
        '
        Me.lb_medico2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_medico2.Enabled = False
        Me.lb_medico2.Location = New System.Drawing.Point(94, 93)
        Me.lb_medico2.Name = "lb_medico2"
        Me.lb_medico2.Size = New System.Drawing.Size(269, 20)
        Me.lb_medico2.TabIndex = 8
        '
        'bt_medico2
        '
        Me.bt_medico2.BackgroundImage = CType(resources.GetObject("bt_medico2.BackgroundImage"), System.Drawing.Image)
        Me.bt_medico2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_medico2.Location = New System.Drawing.Point(56, 90)
        Me.bt_medico2.Name = "bt_medico2"
        Me.bt_medico2.Size = New System.Drawing.Size(31, 23)
        Me.bt_medico2.TabIndex = 6
        Me.bt_medico2.UseVisualStyleBackColor = True
        '
        'tb_medico2
        '
        Me.tb_medico2.BackColor = System.Drawing.Color.White
        Me.tb_medico2.Location = New System.Drawing.Point(16, 92)
        Me.tb_medico2.Name = "tb_medico2"
        Me.tb_medico2.Size = New System.Drawing.Size(44, 20)
        Me.tb_medico2.TabIndex = 5
        '
        'lb_medico1
        '
        Me.lb_medico1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_medico1.Enabled = False
        Me.lb_medico1.Location = New System.Drawing.Point(94, 39)
        Me.lb_medico1.Name = "lb_medico1"
        Me.lb_medico1.Size = New System.Drawing.Size(269, 20)
        Me.lb_medico1.TabIndex = 7
        '
        'bt_medico1
        '
        Me.bt_medico1.BackgroundImage = CType(resources.GetObject("bt_medico1.BackgroundImage"), System.Drawing.Image)
        Me.bt_medico1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_medico1.Location = New System.Drawing.Point(57, 37)
        Me.bt_medico1.Name = "bt_medico1"
        Me.bt_medico1.Size = New System.Drawing.Size(31, 23)
        Me.bt_medico1.TabIndex = 4
        Me.bt_medico1.UseVisualStyleBackColor = True
        '
        'tb_medico1
        '
        Me.tb_medico1.BackColor = System.Drawing.Color.White
        Me.tb_medico1.Location = New System.Drawing.Point(16, 39)
        Me.tb_medico1.Name = "tb_medico1"
        Me.tb_medico1.Size = New System.Drawing.Size(44, 20)
        Me.tb_medico1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Hasta"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.dtp_ff)
        Me.GroupBox1.Controls.Add(Me.dtp_fi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 65)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox2.Controls.Add(Me.lb_medico2)
        Me.GroupBox2.Controls.Add(Me.tb_medico1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.bt_medico1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lb_medico1)
        Me.GroupBox2.Controls.Add(Me.tb_medico2)
        Me.GroupBox2.Controls.Add(Me.bt_medico2)
        Me.GroupBox2.Location = New System.Drawing.Point(294, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 131)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Códigos de Médico"
        '
        'dgv_citas
        '
        Me.dgv_citas.AllowUserToAddRows = False
        Me.dgv_citas.AllowUserToDeleteRows = False
        Me.dgv_citas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_citas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_citas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_citas.BackgroundColor = System.Drawing.Color.White
        Me.dgv_citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_citas.Location = New System.Drawing.Point(10, 178)
        Me.dgv_citas.MultiSelect = False
        Me.dgv_citas.Name = "dgv_citas"
        Me.dgv_citas.ReadOnly = True
        Me.dgv_citas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_citas.Size = New System.Drawing.Size(653, 279)
        Me.dgv_citas.TabIndex = 10
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(506, 519)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 28)
        Me.bt_imprimir.TabIndex = 14
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 478)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Totales:"
        '
        'lb_medico
        '
        Me.lb_medico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_medico.BackColor = System.Drawing.Color.GhostWhite
        Me.lb_medico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_medico.Location = New System.Drawing.Point(351, 478)
        Me.lb_medico.Name = "lb_medico"
        Me.lb_medico.Size = New System.Drawing.Size(100, 23)
        Me.lb_medico.TabIndex = 11
        Me.lb_medico.Text = "0.00  € "
        Me.lb_medico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(348, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Médico:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(454, 465)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Clínica:"
        '
        'lb_clinica
        '
        Me.lb_clinica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_clinica.BackColor = System.Drawing.Color.GhostWhite
        Me.lb_clinica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_clinica.Location = New System.Drawing.Point(457, 478)
        Me.lb_clinica.Name = "lb_clinica"
        Me.lb_clinica.Size = New System.Drawing.Size(100, 23)
        Me.lb_clinica.TabIndex = 12
        Me.lb_clinica.Text = "0.00  €"
        Me.lb_clinica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(560, 466)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Totales:"
        '
        'lb_total
        '
        Me.lb_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_total.BackColor = System.Drawing.Color.GhostWhite
        Me.lb_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_total.Location = New System.Drawing.Point(563, 479)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(100, 23)
        Me.lb_total.TabIndex = 13
        Me.lb_total.Text = "0.00  €"
        Me.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CITASBindingSource
        '
        Me.CITASBindingSource.DataMember = "CITAS"
        '
        'MEDICOSBindingSource
        '
        Me.MEDICOSBindingSource.DataMember = "MEDICOS"
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cerrar.Location = New System.Drawing.Point(588, 519)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 28)
        Me.bt_cerrar.TabIndex = 15
        Me.bt_cerrar.Text = "Cancelar"
        Me.bt_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'CITASTableAdapter
        '
        Me.CITASTableAdapter.ClearBeforeFill = True
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Citas_Por_Especialista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(673, 555)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lb_clinica)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lb_medico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.dgv_citas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_filtrar)
        Me.Name = "Citas_Por_Especialista"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de citas facturadas agrupadas por colegiado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_citas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents lb_medico2 As System.Windows.Forms.Label
    Friend WithEvents bt_medico2 As System.Windows.Forms.Button
    Friend WithEvents tb_medico2 As ctrlTextboxAvanzado
    Friend WithEvents lb_medico1 As System.Windows.Forms.Label
    Friend WithEvents bt_medico1 As System.Windows.Forms.Button
    Friend WithEvents tb_medico1 As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_citas As System.Windows.Forms.DataGridView
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lb_medico As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lb_clinica As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents CITASTableAdapter As centro_medico.CMDataSetTableAdapters.CITASTableAdapter
    Friend WithEvents CITASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents MEDICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
End Class
