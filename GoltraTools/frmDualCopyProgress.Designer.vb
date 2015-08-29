<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDualCopyProgress
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
        Me.components = New System.ComponentModel.Container
        Me.lblReading = New System.Windows.Forms.Label
        Me.pbarReading = New System.Windows.Forms.ProgressBar
        Me.pbarWriting = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblReadAmount = New System.Windows.Forms.Label
        Me.lblWrittenAmount = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblReading
        '
        Me.lblReading.AutoSize = True
        Me.lblReading.Location = New System.Drawing.Point(12, 16)
        Me.lblReading.Name = "lblReading"
        Me.lblReading.Size = New System.Drawing.Size(54, 13)
        Me.lblReading.TabIndex = 0
        Me.lblReading.Text = "Leyendo: "
        '
        'pbarReading
        '
        Me.pbarReading.Location = New System.Drawing.Point(15, 32)
        Me.pbarReading.Name = "pbarReading"
        Me.pbarReading.Size = New System.Drawing.Size(330, 19)
        Me.pbarReading.TabIndex = 1
        '
        'pbarWriting
        '
        Me.pbarWriting.Location = New System.Drawing.Point(15, 81)
        Me.pbarWriting.Name = "pbarWriting"
        Me.pbarWriting.Size = New System.Drawing.Size(330, 19)
        Me.pbarWriting.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Escribiendo: "
        '
        'lblReadAmount
        '
        Me.lblReadAmount.Location = New System.Drawing.Point(174, 14)
        Me.lblReadAmount.Name = "lblReadAmount"
        Me.lblReadAmount.Size = New System.Drawing.Size(171, 15)
        Me.lblReadAmount.TabIndex = 4
        Me.lblReadAmount.Text = "(0 KB / 500 KB)"
        Me.lblReadAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblWrittenAmount
        '
        Me.lblWrittenAmount.Location = New System.Drawing.Point(174, 63)
        Me.lblWrittenAmount.Name = "lblWrittenAmount"
        Me.lblWrittenAmount.Size = New System.Drawing.Size(171, 15)
        Me.lblWrittenAmount.TabIndex = 5
        Me.lblWrittenAmount.Text = "(0 KB / 500 KB)"
        Me.lblWrittenAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(135, 130)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmDualCopyProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblWrittenAmount)
        Me.Controls.Add(Me.lblReadAmount)
        Me.Controls.Add(Me.pbarWriting)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbarReading)
        Me.Controls.Add(Me.lblReading)
        Me.Name = "frmDualCopyProgress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copiando fichero (R / W)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReading As System.Windows.Forms.Label
    Friend WithEvents pbarReading As System.Windows.Forms.ProgressBar
    Friend WithEvents pbarWriting As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblReadAmount As System.Windows.Forms.Label
    Friend WithEvents lblWrittenAmount As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
