<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarApp
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
        Me.pbar = New System.Windows.Forms.ProgressBar
        Me.lbl_Accion = New System.Windows.Forms.Label
        Me.txt_Log = New ctrlRichTextBoxAvanzado
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'pbar
        '
        Me.pbar.Location = New System.Drawing.Point(12, 34)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(278, 23)
        Me.pbar.TabIndex = 0
        '
        'lbl_Accion
        '
        Me.lbl_Accion.AutoSize = True
        Me.lbl_Accion.Location = New System.Drawing.Point(11, 17)
        Me.lbl_Accion.Name = "lbl_Accion"
        Me.lbl_Accion.Size = New System.Drawing.Size(129, 13)
        Me.lbl_Accion.TabIndex = 1
        Me.lbl_Accion.Text = "Buscando actualización..."
        '
        'txt_Log
        '
        Me.txt_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Log.Location = New System.Drawing.Point(12, 63)
        Me.txt_Log.Name = "txt_Log"
        Me.txt_Log.ReadOnly = True
        Me.txt_Log.Size = New System.Drawing.Size(278, 240)
        Me.txt_Log.TabIndex = 2
        Me.txt_Log.TabStop = False
        Me.txt_Log.Text = ""
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Location = New System.Drawing.Point(215, 308)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 0
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'frmActualizarApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(302, 334)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.txt_Log)
        Me.Controls.Add(Me.lbl_Accion)
        Me.Controls.Add(Me.pbar)
        Me.Name = "frmActualizarApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chequeo de Actualizaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbar As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Accion As System.Windows.Forms.Label
    Friend WithEvents txt_Log As ctrlRichTextBoxAvanzado
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
End Class
