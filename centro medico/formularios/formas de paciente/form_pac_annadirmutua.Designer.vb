<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pac_annadirmutua
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
        Me.lb_AMCompañía = New System.Windows.Forms.Label()
        Me.lb_AMTipo = New System.Windows.Forms.Label()
        Me.lb_AMFechaalta = New System.Windows.Forms.Label()
        Me.lb_AMFechabaja = New System.Windows.Forms.Label()
        Me.lb_AMNotas = New System.Windows.Forms.Label()
        Me.tb_AMCompannia = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_AMNombreComp = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_AMNotas = New centro_medico.ctrlTextboxAvanzado()
        Me.dtp_AMFechaalta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_AMFechabaja = New System.Windows.Forms.DateTimePicker()
        Me.cb_AMTipo = New System.Windows.Forms.ComboBox()
        Me.bt_AMBuscarComp = New System.Windows.Forms.Button()
        Me.bt_AMAceptar = New System.Windows.Forms.Button()
        Me.bt_AMCancelar = New System.Windows.Forms.Button()
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter()
        Me.LMUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.LMUTUASTableAdapter()
        Me.chkFBaja = New System.Windows.Forms.CheckBox()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_AMCompañía
        '
        Me.lb_AMCompañía.AutoSize = True
        Me.lb_AMCompañía.Location = New System.Drawing.Point(12, 9)
        Me.lb_AMCompañía.Name = "lb_AMCompañía"
        Me.lb_AMCompañía.Size = New System.Drawing.Size(56, 13)
        Me.lb_AMCompañía.TabIndex = 0
        Me.lb_AMCompañía.Text = "Compañía"
        '
        'lb_AMTipo
        '
        Me.lb_AMTipo.AutoSize = True
        Me.lb_AMTipo.Location = New System.Drawing.Point(12, 62)
        Me.lb_AMTipo.Name = "lb_AMTipo"
        Me.lb_AMTipo.Size = New System.Drawing.Size(28, 13)
        Me.lb_AMTipo.TabIndex = 1
        Me.lb_AMTipo.Text = "Tipo"
        '
        'lb_AMFechaalta
        '
        Me.lb_AMFechaalta.AutoSize = True
        Me.lb_AMFechaalta.Location = New System.Drawing.Point(195, 62)
        Me.lb_AMFechaalta.Name = "lb_AMFechaalta"
        Me.lb_AMFechaalta.Size = New System.Drawing.Size(58, 13)
        Me.lb_AMFechaalta.TabIndex = 2
        Me.lb_AMFechaalta.Text = "Fecha Alta"
        '
        'lb_AMFechabaja
        '
        Me.lb_AMFechabaja.AutoSize = True
        Me.lb_AMFechabaja.Location = New System.Drawing.Point(333, 62)
        Me.lb_AMFechabaja.Name = "lb_AMFechabaja"
        Me.lb_AMFechabaja.Size = New System.Drawing.Size(61, 13)
        Me.lb_AMFechabaja.TabIndex = 3
        Me.lb_AMFechabaja.Text = "Fecha Baja"
        '
        'lb_AMNotas
        '
        Me.lb_AMNotas.AutoSize = True
        Me.lb_AMNotas.Location = New System.Drawing.Point(12, 114)
        Me.lb_AMNotas.Name = "lb_AMNotas"
        Me.lb_AMNotas.Size = New System.Drawing.Size(35, 13)
        Me.lb_AMNotas.TabIndex = 4
        Me.lb_AMNotas.Text = "Notas"
        '
        'tb_AMCompannia
        '
        Me.tb_AMCompannia.AcceptsReturn = True
        Me.tb_AMCompannia.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_AMCompannia.Location = New System.Drawing.Point(15, 25)
        Me.tb_AMCompannia.Name = "tb_AMCompannia"
        Me.tb_AMCompannia.Size = New System.Drawing.Size(76, 20)
        Me.tb_AMCompannia.TabIndex = 0
        '
        'tb_AMNombreComp
        '
        Me.tb_AMNombreComp.AcceptsReturn = True
        Me.tb_AMNombreComp.Enabled = False
        Me.tb_AMNombreComp.Location = New System.Drawing.Point(149, 25)
        Me.tb_AMNombreComp.Name = "tb_AMNombreComp"
        Me.tb_AMNombreComp.Size = New System.Drawing.Size(271, 20)
        Me.tb_AMNombreComp.TabIndex = 2
        '
        'tb_AMNotas
        '
        Me.tb_AMNotas.AcceptsReturn = True
        Me.tb_AMNotas.Location = New System.Drawing.Point(15, 130)
        Me.tb_AMNotas.MaxLength = 150
        Me.tb_AMNotas.Multiline = True
        Me.tb_AMNotas.Name = "tb_AMNotas"
        Me.tb_AMNotas.Size = New System.Drawing.Size(405, 149)
        Me.tb_AMNotas.TabIndex = 6
        '
        'dtp_AMFechaalta
        '
        Me.dtp_AMFechaalta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_AMFechaalta.Location = New System.Drawing.Point(198, 78)
        Me.dtp_AMFechaalta.Name = "dtp_AMFechaalta"
        Me.dtp_AMFechaalta.Size = New System.Drawing.Size(97, 20)
        Me.dtp_AMFechaalta.TabIndex = 4
        '
        'dtp_AMFechabaja
        '
        Me.dtp_AMFechabaja.Enabled = False
        Me.dtp_AMFechabaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_AMFechabaja.Location = New System.Drawing.Point(322, 78)
        Me.dtp_AMFechabaja.Name = "dtp_AMFechabaja"
        Me.dtp_AMFechabaja.Size = New System.Drawing.Size(98, 20)
        Me.dtp_AMFechabaja.TabIndex = 5
        '
        'cb_AMTipo
        '
        Me.cb_AMTipo.FormattingEnabled = True
        Me.cb_AMTipo.Items.AddRange(New Object() {"Mutua asistencial", "Compañía de revisión", "Aseguradora privada"})
        Me.cb_AMTipo.Location = New System.Drawing.Point(15, 79)
        Me.cb_AMTipo.Name = "cb_AMTipo"
        Me.cb_AMTipo.Size = New System.Drawing.Size(163, 21)
        Me.cb_AMTipo.TabIndex = 3
        Me.cb_AMTipo.Text = "Mutua asistencial"
        '
        'bt_AMBuscarComp
        '
        Me.bt_AMBuscarComp.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_AMBuscarComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_AMBuscarComp.Location = New System.Drawing.Point(97, 19)
        Me.bt_AMBuscarComp.Name = "bt_AMBuscarComp"
        Me.bt_AMBuscarComp.Size = New System.Drawing.Size(32, 31)
        Me.bt_AMBuscarComp.TabIndex = 1
        Me.bt_AMBuscarComp.UseVisualStyleBackColor = True
        '
        'bt_AMAceptar
        '
        Me.bt_AMAceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_AMAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AMAceptar.Location = New System.Drawing.Point(260, 290)
        Me.bt_AMAceptar.Name = "bt_AMAceptar"
        Me.bt_AMAceptar.Size = New System.Drawing.Size(75, 29)
        Me.bt_AMAceptar.TabIndex = 7
        Me.bt_AMAceptar.Text = "Aceptar"
        Me.bt_AMAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AMAceptar.UseVisualStyleBackColor = True
        '
        'bt_AMCancelar
        '
        Me.bt_AMCancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_AMCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AMCancelar.Location = New System.Drawing.Point(345, 290)
        Me.bt_AMCancelar.Name = "bt_AMCancelar"
        Me.bt_AMCancelar.Size = New System.Drawing.Size(75, 29)
        Me.bt_AMCancelar.TabIndex = 8
        Me.bt_AMCancelar.Text = "Cancelar"
        Me.bt_AMCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AMCancelar.UseVisualStyleBackColor = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'LMUTUASBindingSource
        '
        Me.LMUTUASBindingSource.DataMember = "LMUTUAS"
        Me.LMUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'LMUTUASTableAdapter
        '
        Me.LMUTUASTableAdapter.ClearBeforeFill = True
        '
        'chkFBaja
        '
        Me.chkFBaja.AutoSize = True
        Me.chkFBaja.Location = New System.Drawing.Point(305, 82)
        Me.chkFBaja.Name = "chkFBaja"
        Me.chkFBaja.Size = New System.Drawing.Size(15, 14)
        Me.chkFBaja.TabIndex = 9
        Me.chkFBaja.UseVisualStyleBackColor = True
        '
        'form_pac_annadirmutua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 324)
        Me.Controls.Add(Me.chkFBaja)
        Me.Controls.Add(Me.bt_AMCancelar)
        Me.Controls.Add(Me.bt_AMAceptar)
        Me.Controls.Add(Me.bt_AMBuscarComp)
        Me.Controls.Add(Me.cb_AMTipo)
        Me.Controls.Add(Me.dtp_AMFechabaja)
        Me.Controls.Add(Me.dtp_AMFechaalta)
        Me.Controls.Add(Me.tb_AMNotas)
        Me.Controls.Add(Me.tb_AMNombreComp)
        Me.Controls.Add(Me.tb_AMCompannia)
        Me.Controls.Add(Me.lb_AMNotas)
        Me.Controls.Add(Me.lb_AMFechabaja)
        Me.Controls.Add(Me.lb_AMFechaalta)
        Me.Controls.Add(Me.lb_AMTipo)
        Me.Controls.Add(Me.lb_AMCompañía)
        Me.Name = "form_pac_annadirmutua"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ficha mutua - Añadir"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_AMCompañía As System.Windows.Forms.Label
    Friend WithEvents lb_AMTipo As System.Windows.Forms.Label
    Friend WithEvents lb_AMFechaalta As System.Windows.Forms.Label
    Friend WithEvents lb_AMFechabaja As System.Windows.Forms.Label
    Friend WithEvents lb_AMNotas As System.Windows.Forms.Label
    Friend WithEvents tb_AMNotas As ctrlTextboxAvanzado
    Friend WithEvents dtp_AMFechaalta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_AMFechabaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_AMBuscarComp As System.Windows.Forms.Button
    Friend WithEvents bt_AMAceptar As System.Windows.Forms.Button
    Friend WithEvents bt_AMCancelar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents LMUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.LMUTUASTableAdapter
    Private WithEvents cb_AMTipo As System.Windows.Forms.ComboBox
    Friend WithEvents chkFBaja As System.Windows.Forms.CheckBox
    Public WithEvents tb_AMCompannia As centro_medico.ctrlTextboxAvanzado
    Public WithEvents tb_AMNombreComp As centro_medico.ctrlTextboxAvanzado
End Class
