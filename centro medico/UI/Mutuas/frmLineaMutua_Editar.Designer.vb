<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineaMutua_Editar
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
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim FECHAALTALabel As System.Windows.Forms.Label
        Dim FECHABAJALabel As System.Windows.Forms.Label
        Me.cb_AMTipo = New System.Windows.Forms.ComboBox()
        Me.LMUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_AMCancelar = New System.Windows.Forms.Button()
        Me.bt_AMAceptar = New System.Windows.Forms.Button()
        Me.CtrlMutua1 = New centro_medico.ctrlMutua()
        Me.FECHAALTADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FECHABAJADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NOTASTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.lb_AMTipo = New System.Windows.Forms.Label()
        NOTASLabel = New System.Windows.Forms.Label()
        FECHAALTALabel = New System.Windows.Forms.Label()
        FECHABAJALabel = New System.Windows.Forms.Label()
        CType(Me.LMUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(12, 105)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 23
        NOTASLabel.Text = "Notas:"
        '
        'FECHAALTALabel
        '
        FECHAALTALabel.AutoSize = True
        FECHAALTALabel.Location = New System.Drawing.Point(15, 44)
        FECHAALTALabel.Name = "FECHAALTALabel"
        FECHAALTALabel.Size = New System.Drawing.Size(61, 13)
        FECHAALTALabel.TabIndex = 29
        FECHAALTALabel.Text = "Fecha Alta:"
        '
        'FECHABAJALabel
        '
        FECHABAJALabel.AutoSize = True
        FECHABAJALabel.Location = New System.Drawing.Point(12, 69)
        FECHABAJALabel.Name = "FECHABAJALabel"
        FECHABAJALabel.Size = New System.Drawing.Size(64, 13)
        FECHABAJALabel.TabIndex = 30
        FECHABAJALabel.Text = "Fecha Baja:"
        '
        'cb_AMTipo
        '
        Me.cb_AMTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_AMTipo.FormattingEnabled = True
        Me.cb_AMTipo.Items.AddRange(New Object() {"Mutua asistencial", "Compañía de revisión", "Aseguradora privada"})
        Me.cb_AMTipo.Location = New System.Drawing.Point(236, 43)
        Me.cb_AMTipo.Name = "cb_AMTipo"
        Me.cb_AMTipo.Size = New System.Drawing.Size(179, 21)
        Me.cb_AMTipo.TabIndex = 28
        '
        'LMUTUASBindingSource
        '
        Me.LMUTUASBindingSource.DataSource = GetType(centro_medico.LMUTUA)
        '
        'bt_AMCancelar
        '
        Me.bt_AMCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_AMCancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_AMCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AMCancelar.Location = New System.Drawing.Point(344, 291)
        Me.bt_AMCancelar.Name = "bt_AMCancelar"
        Me.bt_AMCancelar.Size = New System.Drawing.Size(75, 29)
        Me.bt_AMCancelar.TabIndex = 27
        Me.bt_AMCancelar.Text = "Cancelar"
        Me.bt_AMCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AMCancelar.UseVisualStyleBackColor = True
        '
        'bt_AMAceptar
        '
        Me.bt_AMAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_AMAceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_AMAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AMAceptar.Location = New System.Drawing.Point(263, 291)
        Me.bt_AMAceptar.Name = "bt_AMAceptar"
        Me.bt_AMAceptar.Size = New System.Drawing.Size(75, 29)
        Me.bt_AMAceptar.TabIndex = 26
        Me.bt_AMAceptar.Text = "Aceptar"
        Me.bt_AMAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AMAceptar.UseVisualStyleBackColor = True
        '
        'CtrlMutua1
        '
        Me.CtrlMutua1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Mutuas", Me.LMUTUASBindingSource, "REFMUTUA", True))
        Me.CtrlMutua1.EscogerViaLineaMutua = False
        Me.CtrlMutua1.FiltrarMutuasPorPAciente = False
        Me.CtrlMutua1.ID_Mutuas = Nothing
        Me.CtrlMutua1.IDPACIENTE = Nothing
        Me.CtrlMutua1.Location = New System.Drawing.Point(8, 7)
        Me.CtrlMutua1.Name = "CtrlMutua1"
        Me.CtrlMutua1.Size = New System.Drawing.Size(407, 21)
        Me.CtrlMutua1.TabIndex = 25
        '
        'FECHAALTADateTimePicker
        '
        Me.FECHAALTADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHAALTADateTimePicker.Location = New System.Drawing.Point(79, 43)
        Me.FECHAALTADateTimePicker.Name = "FECHAALTADateTimePicker"
        Me.FECHAALTADateTimePicker.ShowCheckBox = True
        Me.FECHAALTADateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.FECHAALTADateTimePicker.TabIndex = 21
        '
        'FECHABAJADateTimePicker
        '
        Me.FECHABAJADateTimePicker.Checked = False
        Me.FECHABAJADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHABAJADateTimePicker.Location = New System.Drawing.Point(79, 69)
        Me.FECHABAJADateTimePicker.Name = "FECHABAJADateTimePicker"
        Me.FECHABAJADateTimePicker.ShowCheckBox = True
        Me.FECHABAJADateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.FECHABAJADateTimePicker.TabIndex = 22
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.AcceptsReturn = True
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LMUTUASBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(12, 121)
        Me.NOTASTextBox.Multiline = True
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(407, 165)
        Me.NOTASTextBox.TabIndex = 24
        '
        'lb_AMTipo
        '
        Me.lb_AMTipo.AutoSize = True
        Me.lb_AMTipo.Location = New System.Drawing.Point(199, 43)
        Me.lb_AMTipo.Name = "lb_AMTipo"
        Me.lb_AMTipo.Size = New System.Drawing.Size(31, 13)
        Me.lb_AMTipo.TabIndex = 31
        Me.lb_AMTipo.Text = "Tipo:"
        '
        'frmLineaMutua_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 324)
        Me.Controls.Add(Me.lb_AMTipo)
        Me.Controls.Add(FECHAALTALabel)
        Me.Controls.Add(FECHABAJALabel)
        Me.Controls.Add(Me.cb_AMTipo)
        Me.Controls.Add(Me.bt_AMCancelar)
        Me.Controls.Add(Me.bt_AMAceptar)
        Me.Controls.Add(Me.CtrlMutua1)
        Me.Controls.Add(Me.FECHAALTADateTimePicker)
        Me.Controls.Add(Me.FECHABAJADateTimePicker)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.MaximumSize = New System.Drawing.Size(443, 362)
        Me.MinimumSize = New System.Drawing.Size(443, 362)
        Me.Name = "frmLineaMutua_Editar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mutua"
        CType(Me.LMUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cb_AMTipo As System.Windows.Forms.ComboBox
    Friend WithEvents bt_AMCancelar As System.Windows.Forms.Button
    Friend WithEvents bt_AMAceptar As System.Windows.Forms.Button
    Friend WithEvents CtrlMutua1 As centro_medico.ctrlMutua
    Friend WithEvents FECHAALTADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FECHABAJADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOTASTextBox As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents lb_AMTipo As System.Windows.Forms.Label
    Friend WithEvents LMUTUASBindingSource As System.Windows.Forms.BindingSource
End Class
