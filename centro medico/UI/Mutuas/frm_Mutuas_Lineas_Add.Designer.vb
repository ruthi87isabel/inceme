<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mutuas_Lineas_Add
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
        Dim FECHAALTALabel As System.Windows.Forms.Label
        Dim FECHABAJALabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.LMUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.LMUTUASTableAdapter
        Me.FECHAALTADateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.FECHABAJADateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NOTASTextBox = New ctrlTextboxAvanzado
        Me.CtrlMutua1 = New centro_medico.ctrlMutua
        Me.bt_AMCancelar = New System.Windows.Forms.Button
        Me.bt_AMAceptar = New System.Windows.Forms.Button
        Me.lb_AMTipo = New System.Windows.Forms.Label
        Me.cb_AMTipo = New System.Windows.Forms.ComboBox
        FECHAALTALabel = New System.Windows.Forms.Label
        FECHABAJALabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHAALTALabel
        '
        FECHAALTALabel.AutoSize = True
        FECHAALTALabel.Location = New System.Drawing.Point(45, 79)
        FECHAALTALabel.Name = "FECHAALTALabel"
        FECHAALTALabel.Size = New System.Drawing.Size(61, 13)
        FECHAALTALabel.TabIndex = 7
        FECHAALTALabel.Text = "Fecha Alta:"
        '
        'FECHABAJALabel
        '
        FECHABAJALabel.AutoSize = True
        FECHABAJALabel.Location = New System.Drawing.Point(179, 79)
        FECHABAJALabel.Name = "FECHABAJALabel"
        FECHABAJALabel.Size = New System.Drawing.Size(64, 13)
        FECHABAJALabel.TabIndex = 9
        FECHABAJALabel.Text = "Fecha Baja:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(45, 128)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 13
        NOTASLabel.Text = "Notas:"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'FECHAALTADateTimePicker
        '
        Me.FECHAALTADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LMUTUASBindingSource, "FECHAALTA", True))
        Me.FECHAALTADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHAALTADateTimePicker.Location = New System.Drawing.Point(48, 95)
        Me.FECHAALTADateTimePicker.Name = "FECHAALTADateTimePicker"
        Me.FECHAALTADateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.FECHAALTADateTimePicker.TabIndex = 8
        '
        'FECHABAJADateTimePicker
        '
        Me.FECHABAJADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LMUTUASBindingSource, "FECHABAJA", True))
        Me.FECHABAJADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHABAJADateTimePicker.Location = New System.Drawing.Point(182, 95)
        Me.FECHABAJADateTimePicker.Name = "FECHABAJADateTimePicker"
        Me.FECHABAJADateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.FECHABAJADateTimePicker.TabIndex = 10
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LMUTUASBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(48, 144)
        Me.NOTASTextBox.Multiline = True
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(371, 150)
        Me.NOTASTextBox.TabIndex = 14
        '
        'CtrlMutua1
        '
        Me.CtrlMutua1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Mutuas", Me.LMUTUASBindingSource, "REFMUTUA", True))
        Me.CtrlMutua1.ID_Mutuas = Nothing
        Me.CtrlMutua1.Location = New System.Drawing.Point(8, 12)
        Me.CtrlMutua1.Name = "CtrlMutua1"
        Me.CtrlMutua1.Size = New System.Drawing.Size(349, 21)
        Me.CtrlMutua1.TabIndex = 15
        '
        'bt_AMCancelar
        '
        Me.bt_AMCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_AMCancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_AMCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AMCancelar.Location = New System.Drawing.Point(344, 299)
        Me.bt_AMCancelar.Name = "bt_AMCancelar"
        Me.bt_AMCancelar.Size = New System.Drawing.Size(75, 29)
        Me.bt_AMCancelar.TabIndex = 19
        Me.bt_AMCancelar.Text = "Cancelar"
        Me.bt_AMCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AMCancelar.UseVisualStyleBackColor = True
        '
        'bt_AMAceptar
        '
        Me.bt_AMAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_AMAceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_AMAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AMAceptar.Location = New System.Drawing.Point(263, 299)
        Me.bt_AMAceptar.Name = "bt_AMAceptar"
        Me.bt_AMAceptar.Size = New System.Drawing.Size(75, 29)
        Me.bt_AMAceptar.TabIndex = 18
        Me.bt_AMAceptar.Text = "Aceptar"
        Me.bt_AMAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AMAceptar.UseVisualStyleBackColor = True
        '
        'lb_AMTipo
        '
        Me.lb_AMTipo.AutoSize = True
        Me.lb_AMTipo.Location = New System.Drawing.Point(14, 49)
        Me.lb_AMTipo.Name = "lb_AMTipo"
        Me.lb_AMTipo.Size = New System.Drawing.Size(31, 13)
        Me.lb_AMTipo.TabIndex = 17
        Me.lb_AMTipo.Text = "Tipo:"
        '
        'cb_AMTipo
        '
        Me.cb_AMTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_AMTipo.FormattingEnabled = True
        Me.cb_AMTipo.Items.AddRange(New Object() {"Mutua asistencial", "Compañía de revisión", "Aseguradora privada"})
        Me.cb_AMTipo.Location = New System.Drawing.Point(48, 46)
        Me.cb_AMTipo.Name = "cb_AMTipo"
        Me.cb_AMTipo.Size = New System.Drawing.Size(163, 21)
        Me.cb_AMTipo.TabIndex = 20
        '
        'frm_Mutuas_Lineas_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 329)
        Me.Controls.Add(Me.cb_AMTipo)
        Me.Controls.Add(Me.bt_AMCancelar)
        Me.Controls.Add(Me.bt_AMAceptar)
        Me.Controls.Add(Me.lb_AMTipo)
        Me.Controls.Add(Me.CtrlMutua1)
        Me.Controls.Add(FECHAALTALabel)
        Me.Controls.Add(Me.FECHAALTADateTimePicker)
        Me.Controls.Add(FECHABAJALabel)
        Me.Controls.Add(Me.FECHABAJADateTimePicker)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "frm_Mutuas_Lineas_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lineas de Mutuas"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents LMUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.LMUTUASTableAdapter
    Friend WithEvents FECHAALTADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FECHABAJADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOTASTextBox As ctrlTextboxAvanzado
    Friend WithEvents CtrlMutua1 As centro_medico.ctrlMutua
    Friend WithEvents bt_AMCancelar As System.Windows.Forms.Button
    Friend WithEvents bt_AMAceptar As System.Windows.Forms.Button
    Friend WithEvents lb_AMTipo As System.Windows.Forms.Label
    Private WithEvents cb_AMTipo As System.Windows.Forms.ComboBox
End Class
