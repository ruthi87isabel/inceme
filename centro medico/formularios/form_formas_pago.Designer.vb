<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_formas_pago
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
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Me.tb_cod = New centro_medico.ctrlTextboxAvanzado()
        Me.FORMASPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.tb_descripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.FORMASPAGOTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter()
        CODIGOLabel = New System.Windows.Forms.Label()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(6, 15)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(43, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "Código:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(184, 15)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(66, 13)
        DESCRIPCIONLabel.TabIndex = 3
        DESCRIPCIONLabel.Text = "Descripción:"
        '
        'tb_cod
        '
        Me.tb_cod.AcceptsReturn = True
        Me.tb_cod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FORMASPAGOBindingSource, "CODIGO", True))
        Me.tb_cod.Location = New System.Drawing.Point(55, 12)
        Me.tb_cod.MaxLength = 10
        Me.tb_cod.Name = "tb_cod"
        Me.tb_cod.Size = New System.Drawing.Size(100, 20)
        Me.tb_cod.TabIndex = 0
        '
        'FORMASPAGOBindingSource
        '
        Me.FORMASPAGOBindingSource.DataMember = "FORMASPAGO"
        Me.FORMASPAGOBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_descripcion
        '
        Me.tb_descripcion.AcceptsReturn = True
        Me.tb_descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FORMASPAGOBindingSource, "DESCRIPCION", True))
        Me.tb_descripcion.Location = New System.Drawing.Point(256, 12)
        Me.tb_descripcion.MaxLength = 90
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(200, 20)
        Me.tb_descripcion.TabIndex = 1
        '
        'bt_cancel
        '
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(380, 56)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 3
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(284, 56)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 2
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'FORMASPAGOTableAdapter
        '
        Me.FORMASPAGOTableAdapter.ClearBeforeFill = True
        '
        'form_formas_pago
        '
        Me.AcceptButton = Me.bt_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancel
        Me.ClientSize = New System.Drawing.Size(465, 89)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.tb_cod)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.tb_descripcion)
        Me.Name = "form_formas_pago"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_formas_pago"
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents FORMASPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
    Friend WithEvents tb_cod As ctrlTextboxAvanzado
    Friend WithEvents tb_descripcion As ctrlTextboxAvanzado
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
End Class
