<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_indicaciones
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
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim TEXTOLabel As System.Windows.Forms.Label
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.INDICACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDICACIONESTableAdapter = New centro_medico.CMDataSetTableAdapters.INDICACIONESTableAdapter
        Me.tb_nombre = New ctrlTextboxAvanzado
        Me.tb_texto = New ctrlTextboxAvanzado
        Me.bt_medic = New System.Windows.Forms.Button
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.lb_datos = New System.Windows.Forms.Label
        Me.MEDICAMENTOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICAMENTOSTableAdapter
        Me.MEDICAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        NOMBRELabel = New System.Windows.Forms.Label
        TEXTOLabel = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(3, 28)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(75, 13)
        NOMBRELabel.TabIndex = 1
        NOMBRELabel.Text = "Indicado para:"
        '
        'TEXTOLabel
        '
        TEXTOLabel.AutoSize = True
        TEXTOLabel.Location = New System.Drawing.Point(3, 67)
        TEXTOLabel.Name = "TEXTOLabel"
        TEXTOLabel.Size = New System.Drawing.Size(38, 13)
        TEXTOLabel.TabIndex = 2
        TEXTOLabel.Text = "Notas:"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INDICACIONESBindingSource
        '
        Me.INDICACIONESBindingSource.DataMember = "INDICACIONES"
        Me.INDICACIONESBindingSource.DataSource = Me.CMDataSet
        '
        'INDICACIONESTableAdapter
        '
        Me.INDICACIONESTableAdapter.ClearBeforeFill = True
        '
        'tb_nombre
        '
        Me.tb_nombre.BackColor = System.Drawing.Color.White
        Me.tb_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INDICACIONESBindingSource, "NOMBRE", True))
        Me.tb_nombre.Location = New System.Drawing.Point(6, 44)
        Me.tb_nombre.MaxLength = 30
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(208, 20)
        Me.tb_nombre.TabIndex = 0
        '
        'tb_texto
        '
        Me.tb_texto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INDICACIONESBindingSource, "TEXTO", True))
        Me.tb_texto.Location = New System.Drawing.Point(6, 83)
        Me.tb_texto.MaxLength = 150
        Me.tb_texto.Multiline = True
        Me.tb_texto.Name = "tb_texto"
        Me.tb_texto.Size = New System.Drawing.Size(246, 149)
        Me.tb_texto.TabIndex = 2
        '
        'bt_medic
        '
        Me.bt_medic.BackgroundImage = Global.centro_medico.My.Resources.Resources.medicamentos
        Me.bt_medic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_medic.Location = New System.Drawing.Point(222, 42)
        Me.bt_medic.Name = "bt_medic"
        Me.bt_medic.Size = New System.Drawing.Size(30, 23)
        Me.bt_medic.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.bt_medic, "Mostrar listado de medicamentos relacionados")
        Me.bt_medic.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(177, 237)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 4
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(89, 237)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 3
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(0, 2)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(260, 19)
        Me.lb_datos.TabIndex = 66
        Me.lb_datos.Text = "Datos de la Indicacion"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MEDICAMENTOSTableAdapter
        '
        Me.MEDICAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'MEDICAMENTOSBindingSource
        '
        Me.MEDICAMENTOSBindingSource.DataMember = "MEDICAMENTOS"
        Me.MEDICAMENTOSBindingSource.DataSource = Me.CMDataSet
        '
        'form_indicaciones
        '
        Me.AcceptButton = Me.bt_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancel
        Me.ClientSize = New System.Drawing.Size(260, 268)
        Me.Controls.Add(Me.lb_datos)
        Me.Controls.Add(Me.bt_medic)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(TEXTOLabel)
        Me.Controls.Add(Me.tb_texto)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.tb_nombre)
        Me.Name = "form_indicaciones"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_indicaciones"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents INDICACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INDICACIONESTableAdapter As centro_medico.CMDataSetTableAdapters.INDICACIONESTableAdapter
    Friend WithEvents tb_nombre As ctrlTextboxAvanzado
    Friend WithEvents tb_texto As ctrlTextboxAvanzado
    Friend WithEvents bt_medic As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents MEDICAMENTOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICAMENTOSTableAdapter
    Friend WithEvents MEDICAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
