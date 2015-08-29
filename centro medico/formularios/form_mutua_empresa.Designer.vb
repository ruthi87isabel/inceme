<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_mutua_empresa
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
        Dim REFMUTUALabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim TIPOLabel As System.Windows.Forms.Label
        Me.dtp_alta = New System.Windows.Forms.DateTimePicker
        Me.LMUTUASEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.dtp_baja = New System.Windows.Forms.DateTimePicker
        Me.tb_mutua = New ctrlTextboxAvanzado
        Me.tb_notas = New ctrlTextboxAvanzado
        Me.cb_tipo = New System.Windows.Forms.ComboBox
        Me.lb_mutua = New System.Windows.Forms.Label
        Me.bt_mutua = New System.Windows.Forms.Button
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.LMUTUASEMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.LMUTUASEMPRESASTableAdapter
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
        FECHAALTALabel = New System.Windows.Forms.Label
        FECHABAJALabel = New System.Windows.Forms.Label
        REFMUTUALabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        TIPOLabel = New System.Windows.Forms.Label
        CType(Me.LMUTUASEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHAALTALabel
        '
        FECHAALTALabel.AutoSize = True
        FECHAALTALabel.Location = New System.Drawing.Point(150, 50)
        FECHAALTALabel.Name = "FECHAALTALabel"
        FECHAALTALabel.Size = New System.Drawing.Size(72, 13)
        FECHAALTALabel.TabIndex = 5
        FECHAALTALabel.Text = "fecha de alta:"
        '
        'FECHABAJALabel
        '
        FECHABAJALabel.AutoSize = True
        FECHABAJALabel.Location = New System.Drawing.Point(301, 50)
        FECHABAJALabel.Name = "FECHABAJALabel"
        FECHABAJALabel.Size = New System.Drawing.Size(75, 13)
        FECHABAJALabel.TabIndex = 7
        FECHABAJALabel.Text = "fecha de baja:"
        '
        'REFMUTUALabel
        '
        REFMUTUALabel.AutoSize = True
        REFMUTUALabel.Location = New System.Drawing.Point(8, 10)
        REFMUTUALabel.Name = "REFMUTUALabel"
        REFMUTUALabel.Size = New System.Drawing.Size(59, 13)
        REFMUTUALabel.TabIndex = 11
        REFMUTUALabel.Text = "Compañía:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(8, 89)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 12
        NOTASLabel.Text = "Notas:"
        '
        'TIPOLabel
        '
        TIPOLabel.AutoSize = True
        TIPOLabel.Location = New System.Drawing.Point(8, 49)
        TIPOLabel.Name = "TIPOLabel"
        TIPOLabel.Size = New System.Drawing.Size(31, 13)
        TIPOLabel.TabIndex = 13
        TIPOLabel.Text = "Tipo:"
        '
        'dtp_alta
        '
        Me.dtp_alta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LMUTUASEMPRESASBindingSource, "FECHAALTA", True))
        Me.dtp_alta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_alta.Location = New System.Drawing.Point(153, 66)
        Me.dtp_alta.Name = "dtp_alta"
        Me.dtp_alta.Size = New System.Drawing.Size(128, 20)
        Me.dtp_alta.TabIndex = 4
        '
        'LMUTUASEMPRESASBindingSource
        '
        Me.LMUTUASEMPRESASBindingSource.DataMember = "LMUTUASEMPRESAS"
        Me.LMUTUASEMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtp_baja
        '
        Me.dtp_baja.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LMUTUASEMPRESASBindingSource, "FECHABAJA", True))
        Me.dtp_baja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_baja.Location = New System.Drawing.Point(304, 66)
        Me.dtp_baja.Name = "dtp_baja"
        Me.dtp_baja.Size = New System.Drawing.Size(139, 20)
        Me.dtp_baja.TabIndex = 5
        '
        'tb_mutua
        '
        Me.tb_mutua.BackColor = System.Drawing.Color.White
        Me.tb_mutua.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LMUTUASEMPRESASBindingSource, "REFMUTUA", True))
        Me.tb_mutua.Location = New System.Drawing.Point(8, 26)
        Me.tb_mutua.Name = "tb_mutua"
        Me.tb_mutua.Size = New System.Drawing.Size(99, 20)
        Me.tb_mutua.TabIndex = 0
        '
        'tb_notas
        '
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LMUTUASEMPRESASBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(11, 105)
        Me.tb_notas.MaxLength = 120
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.Size = New System.Drawing.Size(432, 103)
        Me.tb_notas.TabIndex = 6
        '
        'cb_tipo
        '
        Me.cb_tipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LMUTUASEMPRESASBindingSource, "TIPO", True))
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"Mutua asistencial", "Compañia de revisión", "Aseguradora privada"})
        Me.cb_tipo.Location = New System.Drawing.Point(8, 65)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(121, 21)
        Me.cb_tipo.TabIndex = 3
        '
        'lb_mutua
        '
        Me.lb_mutua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_mutua.Location = New System.Drawing.Point(153, 26)
        Me.lb_mutua.Name = "lb_mutua"
        Me.lb_mutua.Size = New System.Drawing.Size(290, 20)
        Me.lb_mutua.TabIndex = 2
        '
        'bt_mutua
        '
        Me.bt_mutua.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_mutua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_mutua.Location = New System.Drawing.Point(105, 24)
        Me.bt_mutua.Name = "bt_mutua"
        Me.bt_mutua.Size = New System.Drawing.Size(24, 22)
        Me.bt_mutua.TabIndex = 1
        Me.bt_mutua.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(368, 214)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 8
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(274, 214)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 7
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'LMUTUASEMPRESASTableAdapter
        '
        Me.LMUTUASEMPRESASTableAdapter.ClearBeforeFill = True
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
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'EMPRESASTableAdapter
        '
        Me.EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'form_mutua_empresa
        '
        Me.AcceptButton = Me.bt_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancel
        Me.ClientSize = New System.Drawing.Size(449, 244)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.bt_mutua)
        Me.Controls.Add(Me.lb_mutua)
        Me.Controls.Add(TIPOLabel)
        Me.Controls.Add(Me.cb_tipo)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.tb_notas)
        Me.Controls.Add(FECHAALTALabel)
        Me.Controls.Add(Me.dtp_alta)
        Me.Controls.Add(FECHABAJALabel)
        Me.Controls.Add(Me.dtp_baja)
        Me.Controls.Add(REFMUTUALabel)
        Me.Controls.Add(Me.tb_mutua)
        Me.Name = "form_mutua_empresa"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_mutua_empresa"
        CType(Me.LMUTUASEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents LMUTUASEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUASEMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.LMUTUASEMPRESASTableAdapter
    Friend WithEvents dtp_alta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_baja As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_mutua As ctrlTextboxAvanzado
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents cb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents lb_mutua As System.Windows.Forms.Label
    Friend WithEvents bt_mutua As System.Windows.Forms.Button
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
End Class
