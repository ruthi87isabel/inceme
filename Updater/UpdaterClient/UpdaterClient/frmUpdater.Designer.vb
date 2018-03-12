<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdater
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
        Me.rt_Log = New System.Windows.Forms.RichTextBox
        Me.lbl_Msg = New System.Windows.Forms.Label
        Me.pBar = New System.Windows.Forms.ProgressBar
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.btn_Configurar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'rt_Log
        '
        Me.rt_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rt_Log.Location = New System.Drawing.Point(5, 56)
        Me.rt_Log.Name = "rt_Log"
        Me.rt_Log.ReadOnly = True
        Me.rt_Log.Size = New System.Drawing.Size(355, 187)
        Me.rt_Log.TabIndex = 8
        Me.rt_Log.Text = ""
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.Location = New System.Drawing.Point(2, 9)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(152, 13)
        Me.lbl_Msg.TabIndex = 7
        Me.lbl_Msg.Text = "No iniciada, presione ""Buscar"""
        '
        'pBar
        '
        Me.pBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pBar.Location = New System.Drawing.Point(5, 27)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(355, 23)
        Me.pBar.TabIndex = 6
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Location = New System.Drawing.Point(267, 249)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(93, 23)
        Me.btn_Cancelar.TabIndex = 4
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Location = New System.Drawing.Point(5, 249)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(140, 23)
        Me.btn_Buscar.TabIndex = 5
        Me.btn_Buscar.Text = "Buscar actualizaciones"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Configurar
        '
        Me.btn_Configurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Configurar.Location = New System.Drawing.Point(151, 249)
        Me.btn_Configurar.Name = "btn_Configurar"
        Me.btn_Configurar.Size = New System.Drawing.Size(101, 23)
        Me.btn_Configurar.TabIndex = 5
        Me.btn_Configurar.Text = "Configurar"
        Me.btn_Configurar.UseVisualStyleBackColor = True
        '
        'frmUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(364, 275)
        Me.Controls.Add(Me.rt_Log)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.pBar)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Configurar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Name = "frmUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rt_Log As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Configurar As System.Windows.Forms.Button

End Class
