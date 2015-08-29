<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecetas_Imprimir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecetas_Imprimir))
        Me.UiCheckBoxMutua = New Janus.Windows.EditControls.UICheckBox()
        Me.UiCheckBoxDNI = New Janus.Windows.EditControls.UICheckBox()
        Me.UiCheckBoxEmpresa = New Janus.Windows.EditControls.UICheckBox()
        Me.UiCheckBoxPasaporte = New Janus.Windows.EditControls.UICheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_HtCancelar = New System.Windows.Forms.Button()
        Me.bt_HtImprimir = New System.Windows.Forms.Button()
        Me.UiCheckBoxNIE = New Janus.Windows.EditControls.UICheckBox()
        Me.SuspendLayout()
        '
        'UiCheckBoxMutua
        '
        Me.UiCheckBoxMutua.Checked = True
        Me.UiCheckBoxMutua.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UiCheckBoxMutua.Location = New System.Drawing.Point(12, 43)
        Me.UiCheckBoxMutua.Name = "UiCheckBoxMutua"
        Me.UiCheckBoxMutua.Size = New System.Drawing.Size(104, 23)
        Me.UiCheckBoxMutua.TabIndex = 0
        Me.UiCheckBoxMutua.Text = "Mutua"
        '
        'UiCheckBoxDNI
        '
        Me.UiCheckBoxDNI.Checked = True
        Me.UiCheckBoxDNI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UiCheckBoxDNI.Location = New System.Drawing.Point(12, 103)
        Me.UiCheckBoxDNI.Name = "UiCheckBoxDNI"
        Me.UiCheckBoxDNI.Size = New System.Drawing.Size(104, 23)
        Me.UiCheckBoxDNI.TabIndex = 2
        Me.UiCheckBoxDNI.Text = "DNI"
        '
        'UiCheckBoxEmpresa
        '
        Me.UiCheckBoxEmpresa.Checked = True
        Me.UiCheckBoxEmpresa.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UiCheckBoxEmpresa.Location = New System.Drawing.Point(12, 72)
        Me.UiCheckBoxEmpresa.Name = "UiCheckBoxEmpresa"
        Me.UiCheckBoxEmpresa.Size = New System.Drawing.Size(104, 23)
        Me.UiCheckBoxEmpresa.TabIndex = 1
        Me.UiCheckBoxEmpresa.Text = "Empresa"
        '
        'UiCheckBoxPasaporte
        '
        Me.UiCheckBoxPasaporte.Checked = True
        Me.UiCheckBoxPasaporte.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UiCheckBoxPasaporte.Location = New System.Drawing.Point(12, 132)
        Me.UiCheckBoxPasaporte.Name = "UiCheckBoxPasaporte"
        Me.UiCheckBoxPasaporte.Size = New System.Drawing.Size(104, 23)
        Me.UiCheckBoxPasaporte.TabIndex = 3
        Me.UiCheckBoxPasaporte.Text = "Pasaporte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mostrar en el reporte:"
        '
        'bt_HtCancelar
        '
        Me.bt_HtCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_HtCancelar.Image = CType(resources.GetObject("bt_HtCancelar.Image"), System.Drawing.Image)
        Me.bt_HtCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_HtCancelar.Location = New System.Drawing.Point(218, 189)
        Me.bt_HtCancelar.Name = "bt_HtCancelar"
        Me.bt_HtCancelar.Size = New System.Drawing.Size(75, 28)
        Me.bt_HtCancelar.TabIndex = 6
        Me.bt_HtCancelar.Text = "Cancelar"
        Me.bt_HtCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_HtCancelar.UseVisualStyleBackColor = True
        '
        'bt_HtImprimir
        '
        Me.bt_HtImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_HtImprimir.Image = CType(resources.GetObject("bt_HtImprimir.Image"), System.Drawing.Image)
        Me.bt_HtImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_HtImprimir.Location = New System.Drawing.Point(137, 189)
        Me.bt_HtImprimir.Name = "bt_HtImprimir"
        Me.bt_HtImprimir.Size = New System.Drawing.Size(75, 28)
        Me.bt_HtImprimir.TabIndex = 5
        Me.bt_HtImprimir.Text = "Imprimir"
        Me.bt_HtImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_HtImprimir.UseVisualStyleBackColor = True
        '
        'UiCheckBoxNIE
        '
        Me.UiCheckBoxNIE.Checked = True
        Me.UiCheckBoxNIE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UiCheckBoxNIE.Location = New System.Drawing.Point(12, 161)
        Me.UiCheckBoxNIE.Name = "UiCheckBoxNIE"
        Me.UiCheckBoxNIE.Size = New System.Drawing.Size(104, 23)
        Me.UiCheckBoxNIE.TabIndex = 4
        Me.UiCheckBoxNIE.Text = "NIE"
        '
        'frmRecetas_Imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 229)
        Me.Controls.Add(Me.UiCheckBoxNIE)
        Me.Controls.Add(Me.bt_HtCancelar)
        Me.Controls.Add(Me.bt_HtImprimir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UiCheckBoxPasaporte)
        Me.Controls.Add(Me.UiCheckBoxEmpresa)
        Me.Controls.Add(Me.UiCheckBoxDNI)
        Me.Controls.Add(Me.UiCheckBoxMutua)
        Me.MaximumSize = New System.Drawing.Size(339, 267)
        Me.MinimumSize = New System.Drawing.Size(339, 267)
        Me.Name = "frmRecetas_Imprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones a imprimir"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UiCheckBoxMutua As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents UiCheckBoxDNI As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents UiCheckBoxEmpresa As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents UiCheckBoxPasaporte As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_HtCancelar As System.Windows.Forms.Button
    Friend WithEvents bt_HtImprimir As System.Windows.Forms.Button
    Friend WithEvents UiCheckBoxNIE As Janus.Windows.EditControls.UICheckBox
End Class
