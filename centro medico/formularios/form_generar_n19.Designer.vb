<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_generar_n19
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_generar_n19))
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.dtg_recibos = New System.Windows.Forms.DataGridView
        Me.lb_fechacargo = New System.Windows.Forms.Label
        Me.lb_fechafichero = New System.Windows.Forms.Label
        Me.lb_fechafinal = New System.Windows.Forms.Label
        Me.lb_fechainicial = New System.Windows.Forms.Label
        Me.dtp_fechacargo = New System.Windows.Forms.DateTimePicker
        Me.dtp_fechafichero = New System.Windows.Forms.DateTimePicker
        Me.dtp_fechafinal = New System.Windows.Forms.DateTimePicker
        Me.dtp_fechainicial = New System.Windows.Forms.DateTimePicker
        Me.bt_filtrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.chb_marcar = New System.Windows.Forms.CheckBox
        Me.bt_generarN19 = New System.Windows.Forms.Button
        Me.gb_norma = New System.Windows.Forms.GroupBox
        Me.rb_todosrecibos = New System.Windows.Forms.RadioButton
        Me.rb_recibosemitidos = New System.Windows.Forms.RadioButton
        Me.rb_recibosnoemitidos = New System.Windows.Forms.RadioButton
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.RECIBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECIBOSTableAdapter = New centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.ofd_GuardarFicheroN19 = New System.Windows.Forms.OpenFileDialog
        Me.lbl_Nota = New System.Windows.Forms.Label
        CType(Me.dtg_recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_norma.SuspendLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(659, 631)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 30)
        Me.bt_cancelar.TabIndex = 9
        Me.bt_cancelar.Text = "Cerrar  "
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'dtg_recibos
        '
        Me.dtg_recibos.AllowUserToAddRows = False
        Me.dtg_recibos.AllowUserToDeleteRows = False
        Me.dtg_recibos.BackgroundColor = System.Drawing.Color.White
        Me.dtg_recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_recibos.Location = New System.Drawing.Point(3, 144)
        Me.dtg_recibos.Name = "dtg_recibos"
        Me.dtg_recibos.ReadOnly = True
        Me.dtg_recibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_recibos.Size = New System.Drawing.Size(758, 481)
        Me.dtg_recibos.TabIndex = 8
        '
        'lb_fechacargo
        '
        Me.lb_fechacargo.AutoSize = True
        Me.lb_fechacargo.Location = New System.Drawing.Point(608, 14)
        Me.lb_fechacargo.Name = "lb_fechacargo"
        Me.lb_fechacargo.Size = New System.Drawing.Size(105, 13)
        Me.lb_fechacargo.TabIndex = 28
        Me.lb_fechacargo.Text = "Fecha de cargo N19"
        '
        'lb_fechafichero
        '
        Me.lb_fechafichero.AutoSize = True
        Me.lb_fechafichero.Location = New System.Drawing.Point(483, 14)
        Me.lb_fechafichero.Name = "lb_fechafichero"
        Me.lb_fechafichero.Size = New System.Drawing.Size(112, 13)
        Me.lb_fechafichero.TabIndex = 27
        Me.lb_fechafichero.Text = "Fecha del fichero N19"
        '
        'lb_fechafinal
        '
        Me.lb_fechafinal.AutoSize = True
        Me.lb_fechafinal.Location = New System.Drawing.Point(140, 14)
        Me.lb_fechafinal.Name = "lb_fechafinal"
        Me.lb_fechafinal.Size = New System.Drawing.Size(62, 13)
        Me.lb_fechafinal.TabIndex = 26
        Me.lb_fechafinal.Text = "Fecha Final"
        '
        'lb_fechainicial
        '
        Me.lb_fechainicial.AutoSize = True
        Me.lb_fechainicial.Location = New System.Drawing.Point(9, 14)
        Me.lb_fechainicial.Name = "lb_fechainicial"
        Me.lb_fechainicial.Size = New System.Drawing.Size(67, 13)
        Me.lb_fechainicial.TabIndex = 25
        Me.lb_fechainicial.Text = "Fecha Inicial"
        '
        'dtp_fechacargo
        '
        Me.dtp_fechacargo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechacargo.Location = New System.Drawing.Point(611, 30)
        Me.dtp_fechacargo.Name = "dtp_fechacargo"
        Me.dtp_fechacargo.Size = New System.Drawing.Size(109, 20)
        Me.dtp_fechacargo.TabIndex = 4
        '
        'dtp_fechafichero
        '
        Me.dtp_fechafichero.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechafichero.Location = New System.Drawing.Point(486, 30)
        Me.dtp_fechafichero.Name = "dtp_fechafichero"
        Me.dtp_fechafichero.Size = New System.Drawing.Size(109, 20)
        Me.dtp_fechafichero.TabIndex = 3
        '
        'dtp_fechafinal
        '
        Me.dtp_fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechafinal.Location = New System.Drawing.Point(143, 30)
        Me.dtp_fechafinal.Name = "dtp_fechafinal"
        Me.dtp_fechafinal.Size = New System.Drawing.Size(86, 20)
        Me.dtp_fechafinal.TabIndex = 1
        '
        'dtp_fechainicial
        '
        Me.dtp_fechainicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechainicial.Location = New System.Drawing.Point(12, 30)
        Me.dtp_fechainicial.Name = "dtp_fechainicial"
        Me.dtp_fechainicial.Size = New System.Drawing.Size(83, 20)
        Me.dtp_fechainicial.TabIndex = 0
        '
        'bt_filtrar
        '
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.ImageIndex = 0
        Me.bt_filtrar.ImageList = Me.ImageList1
        Me.bt_filtrar.Location = New System.Drawing.Point(315, 26)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(75, 32)
        Me.bt_filtrar.TabIndex = 2
        Me.bt_filtrar.Text = "Filtrar   "
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search4doc.ico")
        Me.ImageList1.Images.SetKeyName(1, "Rename.png")
        '
        'chb_marcar
        '
        Me.chb_marcar.AutoSize = True
        Me.chb_marcar.Checked = True
        Me.chb_marcar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_marcar.Location = New System.Drawing.Point(492, 75)
        Me.chb_marcar.Name = "chb_marcar"
        Me.chb_marcar.Size = New System.Drawing.Size(228, 17)
        Me.chb_marcar.TabIndex = 6
        Me.chb_marcar.Text = "Marcar como pagados al generar el fichero"
        Me.chb_marcar.UseVisualStyleBackColor = True
        '
        'bt_generarN19
        '
        Me.bt_generarN19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_generarN19.ImageIndex = 1
        Me.bt_generarN19.ImageList = Me.ImageList1
        Me.bt_generarN19.Location = New System.Drawing.Point(591, 110)
        Me.bt_generarN19.Name = "bt_generarN19"
        Me.bt_generarN19.Size = New System.Drawing.Size(129, 28)
        Me.bt_generarN19.TabIndex = 7
        Me.bt_generarN19.Text = "Generar norma 19"
        Me.bt_generarN19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_generarN19.UseVisualStyleBackColor = True
        '
        'gb_norma
        '
        Me.gb_norma.Controls.Add(Me.rb_todosrecibos)
        Me.gb_norma.Controls.Add(Me.rb_recibosemitidos)
        Me.gb_norma.Controls.Add(Me.rb_recibosnoemitidos)
        Me.gb_norma.Location = New System.Drawing.Point(12, 56)
        Me.gb_norma.Name = "gb_norma"
        Me.gb_norma.Size = New System.Drawing.Size(177, 80)
        Me.gb_norma.TabIndex = 5
        Me.gb_norma.TabStop = False
        Me.gb_norma.Text = "Mostrar"
        '
        'rb_todosrecibos
        '
        Me.rb_todosrecibos.AutoSize = True
        Me.rb_todosrecibos.Location = New System.Drawing.Point(6, 58)
        Me.rb_todosrecibos.Name = "rb_todosrecibos"
        Me.rb_todosrecibos.Size = New System.Drawing.Size(108, 17)
        Me.rb_todosrecibos.TabIndex = 2
        Me.rb_todosrecibos.Text = "Todos los recibos"
        Me.rb_todosrecibos.UseVisualStyleBackColor = True
        '
        'rb_recibosemitidos
        '
        Me.rb_recibosemitidos.AutoSize = True
        Me.rb_recibosemitidos.Location = New System.Drawing.Point(6, 39)
        Me.rb_recibosemitidos.Name = "rb_recibosemitidos"
        Me.rb_recibosemitidos.Size = New System.Drawing.Size(143, 17)
        Me.rb_recibosemitidos.TabIndex = 1
        Me.rb_recibosemitidos.Text = "Recibos emitidos en N19"
        Me.rb_recibosemitidos.UseVisualStyleBackColor = True
        '
        'rb_recibosnoemitidos
        '
        Me.rb_recibosnoemitidos.AutoSize = True
        Me.rb_recibosnoemitidos.Checked = True
        Me.rb_recibosnoemitidos.Location = New System.Drawing.Point(6, 19)
        Me.rb_recibosnoemitidos.Name = "rb_recibosnoemitidos"
        Me.rb_recibosnoemitidos.Size = New System.Drawing.Size(158, 17)
        Me.rb_recibosnoemitidos.TabIndex = 0
        Me.rb_recibosnoemitidos.TabStop = True
        Me.rb_recibosnoemitidos.Text = "Recibos no emitidos en N19"
        Me.rb_recibosnoemitidos.UseVisualStyleBackColor = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'ofd_GuardarFicheroN19
        '
        Me.ofd_GuardarFicheroN19.CheckFileExists = False
        '
        'lbl_Nota
        '
        Me.lbl_Nota.AutoSize = True
        Me.lbl_Nota.BackColor = System.Drawing.Color.Lavender
        Me.lbl_Nota.Location = New System.Drawing.Point(195, 95)
        Me.lbl_Nota.Name = "lbl_Nota"
        Me.lbl_Nota.Size = New System.Drawing.Size(277, 39)
        Me.lbl_Nota.TabIndex = 29
        Me.lbl_Nota.Text = "Nota: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Solo se mostrarán los recibos de aquellos clientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en cuya ficha este ma" & _
            "rcada la opción ""Pago por Banco""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'form_generar_n19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(781, 681)
        Me.Controls.Add(Me.lbl_Nota)
        Me.Controls.Add(Me.gb_norma)
        Me.Controls.Add(Me.bt_generarN19)
        Me.Controls.Add(Me.chb_marcar)
        Me.Controls.Add(Me.dtg_recibos)
        Me.Controls.Add(Me.lb_fechacargo)
        Me.Controls.Add(Me.lb_fechafichero)
        Me.Controls.Add(Me.lb_fechafinal)
        Me.Controls.Add(Me.lb_fechainicial)
        Me.Controls.Add(Me.dtp_fechacargo)
        Me.Controls.Add(Me.dtp_fechafichero)
        Me.Controls.Add(Me.dtp_fechafinal)
        Me.Controls.Add(Me.dtp_fechainicial)
        Me.Controls.Add(Me.bt_filtrar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Name = "form_generar_n19"
        Me.ShowIcon = False
        Me.Text = "Generar Norma 19"
        CType(Me.dtg_recibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_norma.ResumeLayout(False)
        Me.gb_norma.PerformLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents dtg_recibos As System.Windows.Forms.DataGridView
    Friend WithEvents lb_fechacargo As System.Windows.Forms.Label
    Friend WithEvents lb_fechafichero As System.Windows.Forms.Label
    Friend WithEvents lb_fechafinal As System.Windows.Forms.Label
    Friend WithEvents lb_fechainicial As System.Windows.Forms.Label
    Friend WithEvents dtp_fechacargo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechafichero As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechainicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents chb_marcar As System.Windows.Forms.CheckBox
    Friend WithEvents bt_generarN19 As System.Windows.Forms.Button
    Friend WithEvents gb_norma As System.Windows.Forms.GroupBox
    Friend WithEvents rb_recibosnoemitidos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todosrecibos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recibosemitidos As System.Windows.Forms.RadioButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents RECIBOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECIBOSTableAdapter As centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents ofd_GuardarFicheroN19 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_Nota As System.Windows.Forms.Label
End Class
