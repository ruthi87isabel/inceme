<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_derivaciones
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
        Dim FECHALabel As System.Windows.Forms.Label
        Dim REFDESTINOLabel As System.Windows.Forms.Label
        Dim MOTIVOLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.DERIVACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_iddestino = New ctrlTextboxAvanzado
        Me.tb_destino = New ctrlTextboxAvanzado
        Me.tb_motivo = New ctrlTextboxAvanzado
        Me.tb_notas = New ctrlTextboxAvanzado
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_destinos = New System.Windows.Forms.Button
        Me.DERIVACIONESTableAdapter = New centro_medico.CMDataSetTableAdapters.DERIVACIONESTableAdapter
        Me.DERIVACIONES_DESTINOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DERIVACIONES_DESTINOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DERIVACIONES_DESTINOSTableAdapter
        Me.CLINICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLINICASTableAdapter = New centro_medico.CMDataSetTableAdapters.CLINICASTableAdapter
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOSTableAdapter = New centro_medico.CMDataSetTableAdapters.USUARIOSTableAdapter
        Me.CtrlMedico1 = New centro_medico.ctrlMedico
        FECHALabel = New System.Windows.Forms.Label
        REFDESTINOLabel = New System.Windows.Forms.Label
        MOTIVOLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.DERIVACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DERIVACIONES_DESTINOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLINICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(10, 11)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(40, 13)
        FECHALabel.TabIndex = 3
        FECHALabel.Text = "Fecha:"
        '
        'REFDESTINOLabel
        '
        REFDESTINOLabel.AutoSize = True
        REFDESTINOLabel.Location = New System.Drawing.Point(143, 11)
        REFDESTINOLabel.Name = "REFDESTINOLabel"
        REFDESTINOLabel.Size = New System.Drawing.Size(46, 13)
        REFDESTINOLabel.TabIndex = 5
        REFDESTINOLabel.Text = "Destino:"
        '
        'MOTIVOLabel
        '
        MOTIVOLabel.AutoSize = True
        MOTIVOLabel.Location = New System.Drawing.Point(10, 100)
        MOTIVOLabel.Name = "MOTIVOLabel"
        MOTIVOLabel.Size = New System.Drawing.Size(42, 13)
        MOTIVOLabel.TabIndex = 9
        MOTIVOLabel.Text = "Motivo:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(15, 139)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(81, 13)
        NOTASLabel.TabIndex = 11
        NOTASLabel.Text = "Observaciones:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DERIVACIONESBindingSource, "FECHA", True))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(13, 27)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(111, 20)
        Me.dtp_fecha.TabIndex = 0
        '
        'DERIVACIONESBindingSource
        '
        Me.DERIVACIONESBindingSource.DataMember = "DERIVACIONES"
        Me.DERIVACIONESBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_iddestino
        '
        Me.tb_iddestino.BackColor = System.Drawing.Color.White
        Me.tb_iddestino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DERIVACIONESBindingSource, "REFDESTINO", True))
        Me.tb_iddestino.Location = New System.Drawing.Point(142, 28)
        Me.tb_iddestino.MaxLength = 12
        Me.tb_iddestino.Name = "tb_iddestino"
        Me.tb_iddestino.Size = New System.Drawing.Size(70, 20)
        Me.tb_iddestino.TabIndex = 1
        '
        'tb_destino
        '
        Me.tb_destino.BackColor = System.Drawing.Color.White
        Me.tb_destino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DERIVACIONESBindingSource, "DESTINO", True))
        Me.tb_destino.Location = New System.Drawing.Point(268, 27)
        Me.tb_destino.MaxLength = 150
        Me.tb_destino.Name = "tb_destino"
        Me.tb_destino.ReadOnly = True
        Me.tb_destino.Size = New System.Drawing.Size(165, 20)
        Me.tb_destino.TabIndex = 3
        '
        'tb_motivo
        '
        Me.tb_motivo.BackColor = System.Drawing.Color.White
        Me.tb_motivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DERIVACIONESBindingSource, "MOTIVO", True))
        Me.tb_motivo.Location = New System.Drawing.Point(13, 116)
        Me.tb_motivo.MaxLength = 150
        Me.tb_motivo.Name = "tb_motivo"
        Me.tb_motivo.Size = New System.Drawing.Size(420, 20)
        Me.tb_motivo.TabIndex = 4
        '
        'tb_notas
        '
        Me.tb_notas.BackColor = System.Drawing.Color.White
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DERIVACIONESBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(13, 155)
        Me.tb_notas.MaxLength = 32000
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_notas.Size = New System.Drawing.Size(422, 105)
        Me.tb_notas.TabIndex = 5
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(358, 270)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancel.TabIndex = 7
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(276, 270)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 6
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'bt_destinos
        '
        Me.bt_destinos.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_destinos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_destinos.Location = New System.Drawing.Point(218, 20)
        Me.bt_destinos.Name = "bt_destinos"
        Me.bt_destinos.Size = New System.Drawing.Size(33, 32)
        Me.bt_destinos.TabIndex = 2
        Me.bt_destinos.UseVisualStyleBackColor = True
        '
        'DERIVACIONESTableAdapter
        '
        Me.DERIVACIONESTableAdapter.ClearBeforeFill = True
        '
        'DERIVACIONES_DESTINOSBindingSource
        '
        Me.DERIVACIONES_DESTINOSBindingSource.DataMember = "DERIVACIONES_DESTINOS"
        Me.DERIVACIONES_DESTINOSBindingSource.DataSource = Me.CMDataSet
        '
        'DERIVACIONES_DESTINOSTableAdapter
        '
        Me.DERIVACIONES_DESTINOSTableAdapter.ClearBeforeFill = True
        '
        'CLINICASBindingSource
        '
        Me.CLINICASBindingSource.DataMember = "CLINICAS"
        Me.CLINICASBindingSource.DataSource = Me.CMDataSet
        '
        'CLINICASTableAdapter
        '
        Me.CLINICASTableAdapter.ClearBeforeFill = True
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(195, 270)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 23)
        Me.bt_imprimir.TabIndex = 12
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'MEDICOSBindingSource
        '
        Me.MEDICOSBindingSource.DataMember = "MEDICOS"
        Me.MEDICOSBindingSource.DataSource = Me.CMDataSet
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'USUARIOSBindingSource
        '
        Me.USUARIOSBindingSource.DataMember = "USUARIOS"
        Me.USUARIOSBindingSource.DataSource = Me.CMDataSet
        '
        'USUARIOSTableAdapter
        '
        Me.USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Medico", Me.DERIVACIONESBindingSource, "REFMEDICO", True))
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(13, 53)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(422, 42)
        Me.CtrlMedico1.TabIndex = 17
        '
        'form_derivaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(468, 298)
        Me.Controls.Add(Me.CtrlMedico1)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.bt_destinos)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(REFDESTINOLabel)
        Me.Controls.Add(Me.tb_iddestino)
        Me.Controls.Add(Me.tb_destino)
        Me.Controls.Add(MOTIVOLabel)
        Me.Controls.Add(Me.tb_motivo)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.tb_notas)
        Me.Name = "form_derivaciones"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Derivación a otras clínicas "
        CType(Me.DERIVACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DERIVACIONES_DESTINOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLINICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents DERIVACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DERIVACIONESTableAdapter As centro_medico.CMDataSetTableAdapters.DERIVACIONESTableAdapter
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_iddestino As ctrlTextboxAvanzado
    Friend WithEvents tb_destino As ctrlTextboxAvanzado
    Friend WithEvents tb_motivo As ctrlTextboxAvanzado
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Public WithEvents bt_destinos As System.Windows.Forms.Button
    Friend WithEvents DERIVACIONES_DESTINOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DERIVACIONES_DESTINOSTableAdapter As centro_medico.CMDataSetTableAdapters.DERIVACIONES_DESTINOSTableAdapter
    Friend WithEvents CLINICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLINICASTableAdapter As centro_medico.CMDataSetTableAdapters.CLINICASTableAdapter
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents MEDICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents USUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USUARIOSTableAdapter As centro_medico.CMDataSetTableAdapters.USUARIOSTableAdapter
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
End Class
