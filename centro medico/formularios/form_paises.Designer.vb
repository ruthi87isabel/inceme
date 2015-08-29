<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_paises
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
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.PAISESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAISESTableAdapter = New centro_medico.CMDataSetTableAdapters.PAISESTableAdapter
        Me.tb_codigo = New ctrlTextboxAvanzado
        Me.tb_nombre = New ctrlTextboxAvanzado
        Me.tb_notas = New ctrlTextboxAvanzado
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        CODIGOLabel = New System.Windows.Forms.Label
        NOMBRELabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAISESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(8, 18)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(43, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "Código:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(142, 18)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(32, 13)
        NOMBRELabel.TabIndex = 3
        NOMBRELabel.Text = "País:"
        '
        'NOTASLabel
        '
        NOTASLabel.AutoSize = True
        NOTASLabel.Location = New System.Drawing.Point(13, 67)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(38, 13)
        NOTASLabel.TabIndex = 5
        NOTASLabel.Text = "Notas:"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PAISESBindingSource
        '
        Me.PAISESBindingSource.DataMember = "PAISES"
        Me.PAISESBindingSource.DataSource = Me.CMDataSet
        '
        'PAISESTableAdapter
        '
        Me.PAISESTableAdapter.ClearBeforeFill = True
        '
        'tb_codigo
        '
        Me.tb_codigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAISESBindingSource, "CODIGO", True))
        Me.tb_codigo.Location = New System.Drawing.Point(11, 34)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(100, 20)
        Me.tb_codigo.TabIndex = 0
        '
        'tb_nombre
        '
        Me.tb_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAISESBindingSource, "NOMBRE", True))
        Me.tb_nombre.Location = New System.Drawing.Point(134, 34)
        Me.tb_nombre.MaxLength = 90
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(181, 20)
        Me.tb_nombre.TabIndex = 1
        '
        'tb_notas
        '
        Me.tb_notas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAISESBindingSource, "NOTAS", True))
        Me.tb_notas.Location = New System.Drawing.Point(11, 83)
        Me.tb_notas.MaxLength = 150
        Me.tb_notas.Multiline = True
        Me.tb_notas.Name = "tb_notas"
        Me.tb_notas.Size = New System.Drawing.Size(304, 98)
        Me.tb_notas.TabIndex = 2
        '
        'bt_cancel
        '
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(237, 191)
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
        Me.bt_aceptar.Location = New System.Drawing.Point(143, 191)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 3
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'form_paises
        '
        Me.AcceptButton = Me.bt_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancel
        Me.ClientSize = New System.Drawing.Size(321, 223)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.tb_codigo)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.tb_nombre)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.tb_notas)
        Me.Name = "form_paises"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_paises"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAISESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PAISESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PAISESTableAdapter As centro_medico.CMDataSetTableAdapters.PAISESTableAdapter
    Friend WithEvents tb_codigo As ctrlTextboxAvanzado
    Friend WithEvents tb_nombre As ctrlTextboxAvanzado
    Friend WithEvents tb_notas As ctrlTextboxAvanzado
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
End Class
