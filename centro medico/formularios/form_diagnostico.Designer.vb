<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_diagnostico
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
        Dim DIAGNOSTICOLabel As System.Windows.Forms.Label
        Dim OBSERVACIONESLabel As System.Windows.Forms.Label
        Dim CIE10Label As System.Windows.Forms.Label
        Dim FAVORITOLabel As System.Windows.Forms.Label
        Me.tb_diagnostico = New ctrlTextboxAvanzado
        Me.DIAGNOSTICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_obs = New ctrlTextboxAvanzado
        Me.tb_nivel = New ctrlTextboxAvanzado
        Me.tb_subnivel = New ctrlTextboxAvanzado
        Me.tb_c10 = New ctrlTextboxAvanzado
        Me.chb_fav = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.lb_datos = New System.Windows.Forms.Label
        Me.DIAGNOSTICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter
        DIAGNOSTICOLabel = New System.Windows.Forms.Label
        OBSERVACIONESLabel = New System.Windows.Forms.Label
        CIE10Label = New System.Windows.Forms.Label
        FAVORITOLabel = New System.Windows.Forms.Label
        CType(Me.DIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DIAGNOSTICOLabel
        '
        DIAGNOSTICOLabel.AutoSize = True
        DIAGNOSTICOLabel.Location = New System.Drawing.Point(3, 76)
        DIAGNOSTICOLabel.Name = "DIAGNOSTICOLabel"
        DIAGNOSTICOLabel.Size = New System.Drawing.Size(123, 13)
        DIAGNOSTICOLabel.TabIndex = 3
        DIAGNOSTICOLabel.Text = "Descripcion diagnostico:"
        '
        'OBSERVACIONESLabel
        '
        OBSERVACIONESLabel.AutoSize = True
        OBSERVACIONESLabel.Location = New System.Drawing.Point(5, 117)
        OBSERVACIONESLabel.Name = "OBSERVACIONESLabel"
        OBSERVACIONESLabel.Size = New System.Drawing.Size(81, 13)
        OBSERVACIONESLabel.TabIndex = 5
        OBSERVACIONESLabel.Text = "Observaciones:"
        '
        'CIE10Label
        '
        CIE10Label.AutoSize = True
        CIE10Label.Location = New System.Drawing.Point(3, 37)
        CIE10Label.Name = "CIE10Label"
        CIE10Label.Size = New System.Drawing.Size(78, 13)
        CIE10Label.TabIndex = 15
        CIE10Label.Text = "Codigo CIE-10:"
        '
        'FAVORITOLabel
        '
        FAVORITOLabel.AutoSize = True
        FAVORITOLabel.Location = New System.Drawing.Point(238, 91)
        FAVORITOLabel.Name = "FAVORITOLabel"
        FAVORITOLabel.Size = New System.Drawing.Size(53, 13)
        FAVORITOLabel.TabIndex = 4
        FAVORITOLabel.Text = "Favoritos:"
        '
        'tb_diagnostico
        '
        Me.tb_diagnostico.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIAGNOSTICOSBindingSource, "DIAGNOSTICO", True))
        Me.tb_diagnostico.Location = New System.Drawing.Point(6, 90)
        Me.tb_diagnostico.MaxLength = 70
        Me.tb_diagnostico.Name = "tb_diagnostico"
        Me.tb_diagnostico.Size = New System.Drawing.Size(212, 20)
        Me.tb_diagnostico.TabIndex = 3
        '
        'DIAGNOSTICOSBindingSource
        '
        Me.DIAGNOSTICOSBindingSource.DataMember = "DIAGNOSTICOS"
        Me.DIAGNOSTICOSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_obs
        '
        Me.tb_obs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIAGNOSTICOSBindingSource, "OBSERVACIONES", True))
        Me.tb_obs.Location = New System.Drawing.Point(8, 133)
        Me.tb_obs.MaxLength = 120
        Me.tb_obs.Multiline = True
        Me.tb_obs.Name = "tb_obs"
        Me.tb_obs.Size = New System.Drawing.Size(335, 200)
        Me.tb_obs.TabIndex = 6
        '
        'tb_nivel
        '
        Me.tb_nivel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIAGNOSTICOSBindingSource, "NIVEL", True))
        Me.tb_nivel.Location = New System.Drawing.Point(185, 53)
        Me.tb_nivel.MaxLength = 6
        Me.tb_nivel.Name = "tb_nivel"
        Me.tb_nivel.Size = New System.Drawing.Size(79, 20)
        Me.tb_nivel.TabIndex = 1
        Me.tb_nivel.Text = "---"
        '
        'tb_subnivel
        '
        Me.tb_subnivel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIAGNOSTICOSBindingSource, "SUBNIVEL", True))
        Me.tb_subnivel.Location = New System.Drawing.Point(270, 53)
        Me.tb_subnivel.MaxLength = 6
        Me.tb_subnivel.Name = "tb_subnivel"
        Me.tb_subnivel.Size = New System.Drawing.Size(73, 20)
        Me.tb_subnivel.TabIndex = 2
        Me.tb_subnivel.Text = "---"
        '
        'tb_c10
        '
        Me.tb_c10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIAGNOSTICOSBindingSource, "CIE10", True))
        Me.tb_c10.Location = New System.Drawing.Point(6, 53)
        Me.tb_c10.MaxLength = 6
        Me.tb_c10.Name = "tb_c10"
        Me.tb_c10.Size = New System.Drawing.Size(100, 20)
        Me.tb_c10.TabIndex = 0
        '
        'chb_fav
        '
        Me.chb_fav.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DIAGNOSTICOSBindingSource, "FAVORITO", True))
        Me.chb_fav.Location = New System.Drawing.Point(308, 86)
        Me.chb_fav.Name = "chb_fav"
        Me.chb_fav.Size = New System.Drawing.Size(35, 24)
        Me.chb_fav.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Codigo CIE-9"
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(268, 352)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 8
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(187, 352)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 7
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(2, 9)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(341, 19)
        Me.lb_datos.TabIndex = 66
        Me.lb_datos.Text = "Datos del diagnostico"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DIAGNOSTICOSTableAdapter
        '
        Me.DIAGNOSTICOSTableAdapter.ClearBeforeFill = True
        '
        'form_diagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 383)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.lb_datos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(FAVORITOLabel)
        Me.Controls.Add(Me.chb_fav)
        Me.Controls.Add(DIAGNOSTICOLabel)
        Me.Controls.Add(Me.tb_diagnostico)
        Me.Controls.Add(OBSERVACIONESLabel)
        Me.Controls.Add(Me.tb_obs)
        Me.Controls.Add(Me.tb_nivel)
        Me.Controls.Add(Me.tb_subnivel)
        Me.Controls.Add(CIE10Label)
        Me.Controls.Add(Me.tb_c10)
        Me.Name = "form_diagnostico"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_diagnostico"
        CType(Me.DIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents DIAGNOSTICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIAGNOSTICOSTableAdapter As centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter
    Friend WithEvents tb_diagnostico As ctrlTextboxAvanzado
    Friend WithEvents tb_obs As ctrlTextboxAvanzado
    Friend WithEvents tb_nivel As ctrlTextboxAvanzado
    Friend WithEvents tb_subnivel As ctrlTextboxAvanzado
    Friend WithEvents tb_c10 As ctrlTextboxAvanzado
    Friend WithEvents chb_fav As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents lb_datos As System.Windows.Forms.Label
End Class
