<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_concepto
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
        Dim PACIENTELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.tb_idcodigo = New ctrlTextboxAvanzado
        Me.tb_codigo = New ctrlTextboxAvanzado
        Me.bt_codigo = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb_cantidad = New ctrlTextboxAvanzado
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cb_IVA = New System.Windows.Forms.ComboBox
        Me.lb_base = New System.Windows.Forms.Label
        Me.lb_total = New System.Windows.Forms.Label
        Me.tb_importe = New ctrlTextboxAvanzado
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.CONCEPTOSFACTURABLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFACTURABLESTableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFACTURABLESTableAdapter
        Me.LINEASFACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINEASFACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.LINEASFACTURASTableAdapter
        Me.CONCEPTOSFRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFRATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter
        PACIENTELabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSFACTURABLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASFACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PACIENTELabel
        '
        PACIENTELabel.AutoSize = True
        PACIENTELabel.Location = New System.Drawing.Point(12, 9)
        PACIENTELabel.Name = "PACIENTELabel"
        PACIENTELabel.Size = New System.Drawing.Size(43, 13)
        PACIENTELabel.TabIndex = 46
        PACIENTELabel.Text = "Codigo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(151, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 13)
        Label1.TabIndex = 82
        Label1.Text = "Concepto:"
        '
        'tb_idcodigo
        '
        Me.tb_idcodigo.BackColor = System.Drawing.Color.White
        Me.tb_idcodigo.Location = New System.Drawing.Point(5, 25)
        Me.tb_idcodigo.Name = "tb_idcodigo"
        Me.tb_idcodigo.Size = New System.Drawing.Size(91, 20)
        Me.tb_idcodigo.TabIndex = 0
        '
        'tb_codigo
        '
        Me.tb_codigo.BackColor = System.Drawing.Color.White
        Me.tb_codigo.Location = New System.Drawing.Point(144, 25)
        Me.tb_codigo.MaxLength = 90
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(411, 20)
        Me.tb_codigo.TabIndex = 2
        '
        'bt_codigo
        '
        Me.bt_codigo.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_codigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_codigo.Location = New System.Drawing.Point(93, 23)
        Me.bt_codigo.Name = "bt_codigo"
        Me.bt_codigo.Size = New System.Drawing.Size(36, 23)
        Me.bt_codigo.TabIndex = 1
        Me.bt_codigo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Cantidad"
        '
        'tb_cantidad
        '
        Me.tb_cantidad.Location = New System.Drawing.Point(144, 64)
        Me.tb_cantidad.Name = "tb_cantidad"
        Me.tb_cantidad.Size = New System.Drawing.Size(72, 20)
        Me.tb_cantidad.TabIndex = 3
        Me.tb_cantidad.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "IVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Base Imponible"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Importe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(463, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Total"
        '
        'cb_IVA
        '
        Me.cb_IVA.FormattingEnabled = True
        Me.cb_IVA.Items.AddRange(New Object() {"0", "16", "7", "4"})
        Me.cb_IVA.Location = New System.Drawing.Point(222, 64)
        Me.cb_IVA.Name = "cb_IVA"
        Me.cb_IVA.Size = New System.Drawing.Size(69, 21)
        Me.cb_IVA.TabIndex = 4
        Me.cb_IVA.Text = "0,00"
        '
        'lb_base
        '
        Me.lb_base.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_base.Location = New System.Drawing.Point(297, 62)
        Me.lb_base.Name = "lb_base"
        Me.lb_base.Size = New System.Drawing.Size(89, 22)
        Me.lb_base.TabIndex = 5
        Me.lb_base.Text = "0,00"
        Me.lb_base.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_total
        '
        Me.lb_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_total.Location = New System.Drawing.Point(466, 62)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(89, 23)
        Me.lb_total.TabIndex = 7
        Me.lb_total.Text = "0,00"
        Me.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_importe
        '
        Me.tb_importe.Location = New System.Drawing.Point(392, 62)
        Me.tb_importe.Name = "tb_importe"
        Me.tb_importe.Size = New System.Drawing.Size(72, 20)
        Me.tb_importe.TabIndex = 6
        Me.tb_importe.Text = "0,00"
        Me.tb_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(482, 94)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 9
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(401, 94)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 8
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONCEPTOSFACTURABLESBindingSource
        '
        Me.CONCEPTOSFACTURABLESBindingSource.DataMember = "CONCEPTOSFACTURABLES"
        Me.CONCEPTOSFACTURABLESBindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSFACTURABLESTableAdapter
        '
        Me.CONCEPTOSFACTURABLESTableAdapter.ClearBeforeFill = True
        '
        'LINEASFACTURASBindingSource
        '
        Me.LINEASFACTURASBindingSource.DataMember = "LINEASFACTURAS"
        Me.LINEASFACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'LINEASFACTURASTableAdapter
        '
        Me.LINEASFACTURASTableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSFRABindingSource
        '
        Me.CONCEPTOSFRABindingSource.DataMember = "CONCEPTOSFRA"
        Me.CONCEPTOSFRABindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSFRATableAdapter
        '
        Me.CONCEPTOSFRATableAdapter.ClearBeforeFill = True
        '
        'form_concepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 126)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.tb_importe)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.lb_base)
        Me.Controls.Add(Me.cb_IVA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_cantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.bt_codigo)
        Me.Controls.Add(Me.tb_idcodigo)
        Me.Controls.Add(PACIENTELabel)
        Me.Controls.Add(Me.tb_codigo)
        Me.Name = "form_concepto"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Concepto a facturar"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSFACTURABLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASFACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_idcodigo As ctrlTextboxAvanzado
    Friend WithEvents tb_codigo As ctrlTextboxAvanzado
    Friend WithEvents bt_codigo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_cantidad As ctrlTextboxAvanzado
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_IVA As System.Windows.Forms.ComboBox
    Friend WithEvents lb_base As System.Windows.Forms.Label
    Friend WithEvents lb_total As System.Windows.Forms.Label
    Friend WithEvents tb_importe As ctrlTextboxAvanzado
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents CONCEPTOSFACTURABLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFACTURABLESTableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFACTURABLESTableAdapter
    Friend WithEvents LINEASFACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEASFACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.LINEASFACTURASTableAdapter
    Friend WithEvents CONCEPTOSFRABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFRATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter
End Class
