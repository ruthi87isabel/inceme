<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado_conocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listado_conocio))
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_cerrar = New System.Windows.Forms.Button
        Me.cb_conocio = New System.Windows.Forms.ComboBox
        Me.ComoConocioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComoConocioTableAdapter = New centro_medico.CMDataSetTableAdapters.ComoConocioTableAdapter
        Me.gb_fecha = New System.Windows.Forms.GroupBox
        Me.chb_filtrarfecha = New System.Windows.Forms.CheckBox
        Me.lb_cbconocio = New System.Windows.Forms.Label
        Me.gb_conocio = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chb_filtrarconocio = New System.Windows.Forms.CheckBox
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComoConocioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_fecha.SuspendLayout()
        Me.gb_conocio.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.GhostWhite
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Datos de filtrado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(82, 148)
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
        Me.Label4.Location = New System.Drawing.Point(138, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Fecha final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Fecha Inicial"
        '
        'dtp_ff
        '
        Me.dtp_ff.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(141, 31)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(9, 31)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fi.TabIndex = 0
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
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.bt_cerrar.Location = New System.Drawing.Point(163, 148)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 28)
        Me.bt_cerrar.TabIndex = 8
        Me.bt_cerrar.Text = "Cancelar"
        Me.bt_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'cb_conocio
        '
        Me.cb_conocio.DataSource = Me.ComoConocioBindingSource
        Me.cb_conocio.DisplayMember = "Descripcion"
        Me.cb_conocio.FormattingEnabled = True
        Me.cb_conocio.Location = New System.Drawing.Point(63, 16)
        Me.cb_conocio.Name = "cb_conocio"
        Me.cb_conocio.Size = New System.Drawing.Size(163, 21)
        Me.cb_conocio.TabIndex = 65
        '
        'ComoConocioBindingSource
        '
        Me.ComoConocioBindingSource.DataMember = "ComoConocio"
        Me.ComoConocioBindingSource.DataSource = Me.CMDataSet
        '
        'ComoConocioTableAdapter
        '
        Me.ComoConocioTableAdapter.ClearBeforeFill = True
        '
        'gb_fecha
        '
        Me.gb_fecha.Controls.Add(Me.dtp_ff)
        Me.gb_fecha.Controls.Add(Me.dtp_fi)
        Me.gb_fecha.Controls.Add(Me.Label3)
        Me.gb_fecha.Controls.Add(Me.Label4)
        Me.gb_fecha.Location = New System.Drawing.Point(5, 24)
        Me.gb_fecha.Name = "gb_fecha"
        Me.gb_fecha.Size = New System.Drawing.Size(261, 54)
        Me.gb_fecha.TabIndex = 67
        Me.gb_fecha.TabStop = False
        Me.gb_fecha.Text = "Fecha"
        '
        'chb_filtrarfecha
        '
        Me.chb_filtrarfecha.AutoSize = True
        Me.chb_filtrarfecha.Location = New System.Drawing.Point(19, 23)
        Me.chb_filtrarfecha.Name = "chb_filtrarfecha"
        Me.chb_filtrarfecha.Size = New System.Drawing.Size(72, 17)
        Me.chb_filtrarfecha.TabIndex = 70
        Me.chb_filtrarfecha.Text = "Por fecha"
        Me.chb_filtrarfecha.UseVisualStyleBackColor = True
        '
        'lb_cbconocio
        '
        Me.lb_cbconocio.AutoSize = True
        Me.lb_cbconocio.Location = New System.Drawing.Point(6, 23)
        Me.lb_cbconocio.Name = "lb_cbconocio"
        Me.lb_cbconocio.Size = New System.Drawing.Size(49, 13)
        Me.lb_cbconocio.TabIndex = 69
        Me.lb_cbconocio.Text = "Conoció:"
        '
        'gb_conocio
        '
        Me.gb_conocio.Controls.Add(Me.lb_cbconocio)
        Me.gb_conocio.Controls.Add(Me.cb_conocio)
        Me.gb_conocio.Location = New System.Drawing.Point(5, 84)
        Me.gb_conocio.Name = "gb_conocio"
        Me.gb_conocio.Size = New System.Drawing.Size(261, 49)
        Me.gb_conocio.TabIndex = 70
        Me.gb_conocio.TabStop = False
        Me.gb_conocio.Text = "Conoció"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chb_filtrarconocio)
        Me.GroupBox1.Controls.Add(Me.chb_filtrarfecha)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 76)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtar"
        '
        'chb_filtrarconocio
        '
        Me.chb_filtrarconocio.AutoSize = True
        Me.chb_filtrarconocio.Location = New System.Drawing.Point(19, 46)
        Me.chb_filtrarconocio.Name = "chb_filtrarconocio"
        Me.chb_filtrarconocio.Size = New System.Drawing.Size(83, 17)
        Me.chb_filtrarconocio.TabIndex = 71
        Me.chb_filtrarconocio.Text = "Por conoció"
        Me.chb_filtrarconocio.UseVisualStyleBackColor = True
        '
        'listado_conocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(390, 188)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_conocio)
        Me.Controls.Add(Me.gb_fecha)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.Label1)
        Me.Name = "listado_conocio"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Como nos Conoció"
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComoConocioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_fecha.ResumeLayout(False)
        Me.gb_fecha.PerformLayout()
        Me.gb_conocio.ResumeLayout(False)
        Me.gb_conocio.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
    Friend WithEvents cb_conocio As System.Windows.Forms.ComboBox
    Friend WithEvents ComoConocioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComoConocioTableAdapter As centro_medico.CMDataSetTableAdapters.ComoConocioTableAdapter
    Friend WithEvents gb_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents chb_filtrarfecha As System.Windows.Forms.CheckBox
    Friend WithEvents lb_cbconocio As System.Windows.Forms.Label
    Friend WithEvents gb_conocio As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_filtrarconocio As System.Windows.Forms.CheckBox
End Class
