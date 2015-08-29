<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImagen
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
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbxDescripcion = New ctrlTextboxAvanzado
        Me.btnExaminar = New System.Windows.Forms.Button
        Me.pbxImagen = New System.Windows.Forms.PictureBox
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(422, 390)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 26)
        Me.btnCancelar.TabIndex = 34
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(322, 390)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 26)
        Me.btnAceptar.TabIndex = 33
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Descripción"
        '
        'tbxDescripcion
        '
        Me.tbxDescripcion.Location = New System.Drawing.Point(77, 10)
        Me.tbxDescripcion.Name = "tbxDescripcion"
        Me.tbxDescripcion.Size = New System.Drawing.Size(344, 20)
        Me.tbxDescripcion.TabIndex = 42
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(439, 9)
        Me.btnExaminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(70, 24)
        Me.btnExaminar.TabIndex = 44
        Me.btnExaminar.Text = "Examinar..."
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'pbxImagen
        '
        Me.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxImagen.Location = New System.Drawing.Point(10, 38)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(500, 346)
        Me.pbxImagen.TabIndex = 45
        Me.pbxImagen.TabStop = False
        '
        'frmImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 424)
        Me.Controls.Add(Me.pbxImagen)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxDescripcion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmImagen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva imagen asociada a tratamiento"
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxDescripcion As ctrlTextboxAvanzado
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents pbxImagen As System.Windows.Forms.PictureBox
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
End Class
