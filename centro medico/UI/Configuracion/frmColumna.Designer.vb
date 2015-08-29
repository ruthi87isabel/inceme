<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColumna
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtColumn = New ctrlTextboxAvanzado()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRow = New ctrlTextboxAvanzado()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New ctrlTextboxAvanzado()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtColumnSpan = New ctrlTextboxAvanzado()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRowSpan = New ctrlTextboxAvanzado()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(113, 169)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(62, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnGuardar.Location = New System.Drawing.Point(36, 169)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(62, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtColumn
        '
        Me.txtColumn.Location = New System.Drawing.Point(116, 73)
        Me.txtColumn.Name = "txtColumn"
        Me.txtColumn.Size = New System.Drawing.Size(53, 20)
        Me.txtColumn.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Columna"
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(39, 73)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(53, 20)
        Me.txtRow.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fila"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(87, 18)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(82, 20)
        Me.txtNombre.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre:"
        '
        'txtColumnSpan
        '
        Me.txtColumnSpan.Location = New System.Drawing.Point(113, 127)
        Me.txtColumnSpan.Name = "txtColumnSpan"
        Me.txtColumnSpan.Size = New System.Drawing.Size(53, 20)
        Me.txtColumnSpan.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Columna Span"
        '
        'txtRowSpan
        '
        Me.txtRowSpan.Location = New System.Drawing.Point(36, 127)
        Me.txtRowSpan.Name = "txtRowSpan"
        Me.txtRowSpan.Size = New System.Drawing.Size(53, 20)
        Me.txtRowSpan.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Fila Span"
        '
        'frmColumna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 204)
        Me.Controls.Add(Me.txtColumnSpan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRowSpan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtColumn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmColumna"
        Me.ShowIcon = False
        Me.Text = "Columna"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtColumn As ctrlTextboxAvanzado
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRow As ctrlTextboxAvanzado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtColumnSpan As ctrlTextboxAvanzado
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRowSpan As ctrlTextboxAvanzado
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
