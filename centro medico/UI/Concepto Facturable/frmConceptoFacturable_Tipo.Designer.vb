<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConceptoFacturable_Tipo
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
        Me.rbRegular = New System.Windows.Forms.RadioButton()
        Me.rbDental = New System.Windows.Forms.RadioButton()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbRegular
        '
        Me.rbRegular.AutoSize = True
        Me.rbRegular.Checked = True
        Me.rbRegular.Location = New System.Drawing.Point(45, 33)
        Me.rbRegular.Name = "rbRegular"
        Me.rbRegular.Size = New System.Drawing.Size(62, 17)
        Me.rbRegular.TabIndex = 0
        Me.rbRegular.Text = "Regular"
        Me.rbRegular.UseVisualStyleBackColor = True
        '
        'rbDental
        '
        Me.rbDental.AutoSize = True
        Me.rbDental.Location = New System.Drawing.Point(45, 78)
        Me.rbDental.Name = "rbDental"
        Me.rbDental.Size = New System.Drawing.Size(56, 17)
        Me.rbDental.TabIndex = 0
        Me.rbDental.Text = "Dental"
        Me.rbDental.UseVisualStyleBackColor = True
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(12, 132)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 1
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(108, 132)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 1
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'frmConceptoFacturable_Tipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.rbDental)
        Me.Controls.Add(Me.rbRegular)
        Me.Name = "frmConceptoFacturable_Tipo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Tipo de Concepto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents rbRegular As System.Windows.Forms.RadioButton
    Public WithEvents rbDental As System.Windows.Forms.RadioButton
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button
End Class
