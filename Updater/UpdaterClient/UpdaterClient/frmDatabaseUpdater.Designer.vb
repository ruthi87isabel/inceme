<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseUpdater
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
        Me.btn_Execute = New System.Windows.Forms.Button
        Me.lbl_ScriptFile = New System.Windows.Forms.Label
        Me.lst_Scripts = New System.Windows.Forms.ListView
        Me.lbl_Msg = New System.Windows.Forms.Label
        Me.rt_Log = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'btn_Execute
        '
        Me.btn_Execute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Execute.Location = New System.Drawing.Point(318, 416)
        Me.btn_Execute.Name = "btn_Execute"
        Me.btn_Execute.Size = New System.Drawing.Size(75, 23)
        Me.btn_Execute.TabIndex = 1
        Me.btn_Execute.Text = "Ejecutar"
        Me.btn_Execute.UseVisualStyleBackColor = True
        '
        'lbl_ScriptFile
        '
        Me.lbl_ScriptFile.AutoSize = True
        Me.lbl_ScriptFile.Location = New System.Drawing.Point(0, 9)
        Me.lbl_ScriptFile.Name = "lbl_ScriptFile"
        Me.lbl_ScriptFile.Size = New System.Drawing.Size(137, 13)
        Me.lbl_ScriptFile.TabIndex = 2
        Me.lbl_ScriptFile.Text = "Ficheros script encontrados"
        '
        'lst_Scripts
        '
        Me.lst_Scripts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_Scripts.Location = New System.Drawing.Point(3, 25)
        Me.lst_Scripts.Name = "lst_Scripts"
        Me.lst_Scripts.Size = New System.Drawing.Size(390, 100)
        Me.lst_Scripts.TabIndex = 3
        Me.lst_Scripts.UseCompatibleStateImageBehavior = False
        Me.lst_Scripts.View = System.Windows.Forms.View.List
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.Location = New System.Drawing.Point(0, 128)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(140, 13)
        Me.lbl_Msg.TabIndex = 2
        Me.lbl_Msg.Text = "Progreso de la actualización"
        '
        'rt_Log
        '
        Me.rt_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rt_Log.Location = New System.Drawing.Point(3, 144)
        Me.rt_Log.Name = "rt_Log"
        Me.rt_Log.ReadOnly = True
        Me.rt_Log.Size = New System.Drawing.Size(390, 266)
        Me.rt_Log.TabIndex = 9
        Me.rt_Log.Text = ""
        '
        'frmDatabaseUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 442)
        Me.Controls.Add(Me.rt_Log)
        Me.Controls.Add(Me.lst_Scripts)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.lbl_ScriptFile)
        Me.Controls.Add(Me.btn_Execute)
        Me.Name = "frmDatabaseUpdater"
        Me.Text = "Actualizador de Base de Datos SQL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Execute As System.Windows.Forms.Button
    Public WithEvents lbl_ScriptFile As System.Windows.Forms.Label
    Friend WithEvents lst_Scripts As System.Windows.Forms.ListView
    Public WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents rt_Log As System.Windows.Forms.RichTextBox
End Class
