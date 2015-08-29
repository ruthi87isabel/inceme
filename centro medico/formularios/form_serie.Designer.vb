<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_serie
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
        Me.tb_serie = New ctrlTextboxAvanzado
        Me.tb_contador = New ctrlTextboxAvanzado
        Me.lb_serie = New System.Windows.Forms.Label
        Me.lb_contador = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.SERIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERIESTableAdapter = New centro_medico.CMDataSetTableAdapters.SERIESTableAdapter
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_serie
        '
        Me.tb_serie.Location = New System.Drawing.Point(6, 22)
        Me.tb_serie.MaxLength = 6
        Me.tb_serie.Name = "tb_serie"
        Me.tb_serie.Size = New System.Drawing.Size(100, 20)
        Me.tb_serie.TabIndex = 0
        '
        'tb_contador
        '
        Me.tb_contador.Location = New System.Drawing.Point(116, 22)
        Me.tb_contador.Name = "tb_contador"
        Me.tb_contador.Size = New System.Drawing.Size(100, 20)
        Me.tb_contador.TabIndex = 1
        '
        'lb_serie
        '
        Me.lb_serie.AutoSize = True
        Me.lb_serie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_serie.Location = New System.Drawing.Point(6, 6)
        Me.lb_serie.Name = "lb_serie"
        Me.lb_serie.Size = New System.Drawing.Size(36, 13)
        Me.lb_serie.TabIndex = 2
        Me.lb_serie.Text = "Serie"
        '
        'lb_contador
        '
        Me.lb_contador.AutoSize = True
        Me.lb_contador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_contador.Location = New System.Drawing.Point(113, 6)
        Me.lb_contador.Name = "lb_contador"
        Me.lb_contador.Size = New System.Drawing.Size(58, 13)
        Me.lb_contador.TabIndex = 3
        Me.lb_contador.Text = "Contador"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(141, 69)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 3
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.aceptar_icon
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(60, 69)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 2
        Me.bt_aceptar.Text = "Aceptar  "
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SERIESBindingSource
        '
        Me.SERIESBindingSource.DataMember = "SERIES"
        Me.SERIESBindingSource.DataSource = Me.CMDataSet
        '
        'SERIESTableAdapter
        '
        Me.SERIESTableAdapter.ClearBeforeFill = True
        '
        'form_serie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 95)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.lb_contador)
        Me.Controls.Add(Me.lb_serie)
        Me.Controls.Add(Me.tb_contador)
        Me.Controls.Add(Me.tb_serie)
        Me.Name = "form_serie"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_serie"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_serie As ctrlTextboxAvanzado
    Friend WithEvents tb_contador As ctrlTextboxAvanzado
    Friend WithEvents lb_serie As System.Windows.Forms.Label
    Friend WithEvents lb_contador As System.Windows.Forms.Label
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents SERIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERIESTableAdapter As centro_medico.CMDataSetTableAdapters.SERIESTableAdapter
End Class
