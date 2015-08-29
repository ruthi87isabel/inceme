<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeoIntegridad
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
        Me.pbar = New System.Windows.Forms.ProgressBar()
        Me.lbl_Proceso = New System.Windows.Forms.Label()
        Me.lbl_SubProceso = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.RichTextBox()
        Me.btnReparar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(695, 436)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'pbar
        '
        Me.pbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbar.Location = New System.Drawing.Point(12, 28)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(758, 23)
        Me.pbar.TabIndex = 1
        '
        'lbl_Proceso
        '
        Me.lbl_Proceso.AutoSize = True
        Me.lbl_Proceso.Location = New System.Drawing.Point(12, 11)
        Me.lbl_Proceso.Name = "lbl_Proceso"
        Me.lbl_Proceso.Size = New System.Drawing.Size(187, 13)
        Me.lbl_Proceso.TabIndex = 2
        Me.lbl_Proceso.Text = "Comenzando chequeo de integridad..."
        '
        'lbl_SubProceso
        '
        Me.lbl_SubProceso.AutoSize = True
        Me.lbl_SubProceso.Location = New System.Drawing.Point(12, 53)
        Me.lbl_SubProceso.Name = "lbl_SubProceso"
        Me.lbl_SubProceso.Size = New System.Drawing.Size(19, 13)
        Me.lbl_SubProceso.TabIndex = 3
        Me.lbl_SubProceso.Text = "...."
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.Location = New System.Drawing.Point(12, 75)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(758, 355)
        Me.txtLog.TabIndex = 4
        Me.txtLog.Text = ""
        '
        'btnReparar
        '
        Me.btnReparar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReparar.Location = New System.Drawing.Point(12, 436)
        Me.btnReparar.Name = "btnReparar"
        Me.btnReparar.Size = New System.Drawing.Size(94, 23)
        Me.btnReparar.TabIndex = 0
        Me.btnReparar.Text = "Reparar"
        Me.btnReparar.UseVisualStyleBackColor = True
        '
        'frmChequeoIntegridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 463)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.lbl_SubProceso)
        Me.Controls.Add(Me.lbl_Proceso)
        Me.Controls.Add(Me.pbar)
        Me.Controls.Add(Me.btnReparar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "frmChequeoIntegridad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chequeo Integridad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents pbar As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Proceso As System.Windows.Forms.Label
    Friend WithEvents lbl_SubProceso As System.Windows.Forms.Label
    Friend WithEvents txtLog As System.Windows.Forms.RichTextBox
    Public WithEvents btnReparar As System.Windows.Forms.Button
End Class
