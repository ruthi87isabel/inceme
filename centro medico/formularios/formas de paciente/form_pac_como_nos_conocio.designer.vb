<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pac_como_nos_conocio
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
        Dim cmbConocio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_pac_como_nos_conocio))
        Me.PACIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.grpFiltrarPorNombre = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GBfecha = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.ComoConocioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListadoPacientesTableAdapter1 = New centro_medico.CM2DataSetTableAdapters.ListadoPacientesTableAdapter()
        Me.PacientesconocioTableAdapter = New centro_medico.CM2DataSetTableAdapters.PACIENTESCONOCIOTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LbResultados = New System.Windows.Forms.Label()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbConocio = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltrarPorNombre.SuspendLayout()
        Me.GBfecha.SuspendLayout()
        CType(Me.ComoConocioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PACIENTEBindingSource
        '
        Me.PACIENTEBindingSource.DataSource = GetType(centro_medico.PACIENTE)
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.Location = New System.Drawing.Point(732, 632)
        Me.bImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(97, 37)
        Me.bImprimir.TabIndex = 1
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bImprimir.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(837, 632)
        Me.bt_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(100, 37)
        Me.bt_cancelar.TabIndex = 2
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'grpFiltrarPorNombre
        '
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label4)
        Me.grpFiltrarPorNombre.Controls.Add(Me.GBfecha)
        Me.grpFiltrarPorNombre.Controls.Add(Me.cmbConocio)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label1)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtApellido2)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtApellido1)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtNombre)
        Me.grpFiltrarPorNombre.Controls.Add(Me.bt_filtrar)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label8)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label7)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label5)
        Me.grpFiltrarPorNombre.Location = New System.Drawing.Point(24, 7)
        Me.grpFiltrarPorNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFiltrarPorNombre.Name = "grpFiltrarPorNombre"
        Me.grpFiltrarPorNombre.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFiltrarPorNombre.Size = New System.Drawing.Size(917, 93)
        Me.grpFiltrarPorNombre.TabIndex = 220
        Me.grpFiltrarPorNombre.TabStop = False
        Me.grpFiltrarPorNombre.Text = "Filtrar pacientes por:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 217
        Me.Label4.Text = "Fecha:"
        '
        'GBfecha
        '
        Me.GBfecha.Controls.Add(Me.Label2)
        Me.GBfecha.Controls.Add(Me.Label3)
        Me.GBfecha.Controls.Add(Me.dtp_ff)
        Me.GBfecha.Controls.Add(Me.dtp_fi)
        Me.GBfecha.Location = New System.Drawing.Point(439, 11)
        Me.GBfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.GBfecha.Name = "GBfecha"
        Me.GBfecha.Padding = New System.Windows.Forms.Padding(4)
        Me.GBfecha.Size = New System.Drawing.Size(344, 40)
        Me.GBfecha.TabIndex = 216
        Me.GBfecha.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "a"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "De"
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(200, 11)
        Me.dtp_ff.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.ShowCheckBox = True
        Me.dtp_ff.Size = New System.Drawing.Size(136, 22)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(39, 11)
        Me.dtp_fi.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.ShowCheckBox = True
        Me.dtp_fi.Size = New System.Drawing.Size(128, 22)
        Me.dtp_fi.TabIndex = 0
        '
        'ComoConocioBindingSource
        '
        Me.ComoConocioBindingSource.DataSource = GetType(centro_medico.ComoConocio)
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(600, 58)
        Me.txtApellido2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(132, 22)
        Me.txtApellido2.TabIndex = 212
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(348, 58)
        Me.txtApellido1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(132, 22)
        Me.txtApellido1.TabIndex = 211
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(93, 58)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(132, 22)
        Me.txtNombre.TabIndex = 210
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.Location = New System.Drawing.Point(807, 51)
        Me.bt_filtrar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(97, 31)
        Me.bt_filtrar.TabIndex = 209
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(517, 61)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 194
        Me.Label8.Text = "Apellido 2:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(265, 61)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Apellido 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 61)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "Nombre:"
        '
        'ListadoPacientesTableAdapter1
        '
        Me.ListadoPacientesTableAdapter1.ClearBeforeFill = True
        '
        'PacientesconocioTableAdapter
        '
        Me.PacientesconocioTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.LbResultados)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 596)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 85)
        Me.GroupBox1.TabIndex = 225
        Me.GroupBox1.TabStop = False
        '
        'ListBox2
        '
        Me.ListBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(297, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(270, 64)
        Me.ListBox2.TabIndex = 227
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(14, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(270, 64)
        Me.ListBox1.TabIndex = 226
        '
        'LbResultados
        '
        Me.LbResultados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbResultados.AutoSize = True
        Me.LbResultados.Location = New System.Drawing.Point(569, 62)
        Me.LbResultados.Name = "LbResultados"
        Me.LbResultados.Size = New System.Drawing.Size(44, 17)
        Me.LbResultados.TabIndex = 225
        Me.LbResultados.Text = "Total:"
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataSource = Me.PACIENTEBindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Location = New System.Drawing.Point(24, 107)
        Me.GridEX1.Margin = New System.Windows.Forms.Padding(4)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(917, 490)
        Me.GridEX1.TabIndex = 221
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "C�mo nos conoci�:"
        '
        'cmbConocio
        '
        Me.cmbConocio.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cmbConocio_DesignTimeLayout.LayoutString = resources.GetString("cmbConocio_DesignTimeLayout.LayoutString")
        Me.cmbConocio.DesignTimeLayout = cmbConocio_DesignTimeLayout
        Me.cmbConocio.DropDownDataSource = Me.ComoConocioBindingSource
        Me.cmbConocio.DropDownValueMember = "Descripcion"
        Me.cmbConocio.HasImage = False
        Me.cmbConocio.Location = New System.Drawing.Point(155, 24)
        Me.cmbConocio.Name = "cmbConocio"
        Me.cmbConocio.SaveSettings = False
        Me.cmbConocio.Size = New System.Drawing.Size(190, 22)
        Me.cmbConocio.TabIndex = 1
        Me.cmbConocio.ValuesDataMember = Nothing
        '
        'form_pac_como_nos_conocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(961, 687)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.grpFiltrarPorNombre)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "form_pac_como_nos_conocio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes - Com� nos conoci�"
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltrarPorNombre.ResumeLayout(False)
        Me.grpFiltrarPorNombre.PerformLayout()
        Me.GBfecha.ResumeLayout(False)
        Me.GBfecha.PerformLayout()
        CType(Me.ComoConocioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bImprimir As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PACIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListadoPacientesTableAdapter1 As centro_medico.CM2DataSetTableAdapters.ListadoPacientesTableAdapter
    Friend WithEvents grpFiltrarPorNombre As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents ComoConocioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacientesconocioTableAdapter As centro_medico.CM2DataSetTableAdapters.PACIENTESCONOCIOTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LbResultados As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GBfecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents cmbConocio As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
