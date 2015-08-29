<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado_faltas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listado_faltas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.dgv_faltas = New System.Windows.Forms.DataGridView
        Me.bt_filtrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_cerrar = New System.Windows.Forms.Button
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CITASTableAdapter = New centro_medico.CMDataSetTableAdapters.CITASTableAdapter
        Me.IDCITA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgv_faltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.GhostWhite
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(702, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Datos de filtrado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.GhostWhite
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(715, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Resultados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir.Enabled = False
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(564, 456)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 28)
        Me.bt_imprimir.TabIndex = 7
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(568, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Fecha final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(455, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Fecha Inicial"
        '
        'dtp_ff
        '
        Me.dtp_ff.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(571, 47)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(452, 47)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fi.TabIndex = 0
        '
        'dgv_faltas
        '
        Me.dgv_faltas.AllowUserToAddRows = False
        Me.dgv_faltas.AllowUserToDeleteRows = False
        Me.dgv_faltas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_faltas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_faltas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_faltas.BackgroundColor = System.Drawing.Color.White
        Me.dgv_faltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_faltas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCITA, Me.fecha, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgv_faltas.Location = New System.Drawing.Point(5, 145)
        Me.dgv_faltas.MultiSelect = False
        Me.dgv_faltas.Name = "dgv_faltas"
        Me.dgv_faltas.ReadOnly = True
        Me.dgv_faltas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_faltas.Size = New System.Drawing.Size(716, 294)
        Me.dgv_faltas.TabIndex = 6
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.ImageIndex = 0
        Me.bt_filtrar.ImageList = Me.ImageList1
        Me.bt_filtrar.Location = New System.Drawing.Point(628, 84)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(93, 36)
        Me.bt_filtrar.TabIndex = 5
        Me.bt_filtrar.Text = "Filtrar"
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
        Me.bt_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cerrar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cerrar.Location = New System.Drawing.Point(645, 456)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 28)
        Me.bt_cerrar.TabIndex = 8
        Me.bt_cerrar.Text = "Cancelar"
        Me.bt_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(12, 31)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(385, 50)
        Me.CtrlPaciente1.TabIndex = 65
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'CITASTableAdapter
        '
        Me.CITASTableAdapter.ClearBeforeFill = True
        '
        'IDCITA
        '
        Me.IDCITA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IDCITA.DataPropertyName = "IDCITA"
        Me.IDCITA.HeaderText = "IDCITA"
        Me.IDCITA.Name = "IDCITA"
        Me.IDCITA.ReadOnly = True
        Me.IDCITA.Visible = False
        '
        'fecha
        '
        Me.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.fecha.DataPropertyName = "FECHA"
        DataGridViewCellStyle1.Format = "d"
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 62
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.DataPropertyName = "HORA"
        DataGridViewCellStyle2.Format = "t"
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Hora"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 55
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.DataPropertyName = "REFPACIENTE"
        Me.Column2.HeaderText = "Codigo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 45
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column3.DataPropertyName = "PACIENTE"
        Me.Column3.HeaderText = "Paciente"
        Me.Column3.MinimumWidth = 100
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column4.DataPropertyName = "TUTOR"
        Me.Column4.HeaderText = "Tutor"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 57
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column5.DataPropertyName = "TLFNO"
        Me.Column5.HeaderText = "Tlfono"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 62
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.DataPropertyName = "NOTAS"
        Me.Column6.HeaderText = "Notas"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'listado_faltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(723, 489)
        Me.Controls.Add(Me.CtrlPaciente1)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.dgv_faltas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.bt_filtrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "listado_faltas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Ausencias"
        CType(Me.dgv_faltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_faltas As System.Windows.Forms.DataGridView
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CITASTableAdapter As centro_medico.CMDataSetTableAdapters.CITASTableAdapter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents IDCITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
