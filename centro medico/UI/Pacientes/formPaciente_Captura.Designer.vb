<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPaciente_Captura
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPaciente_Captura))
        Me.Display = New System.Windows.Forms.PictureBox()
        Me.Visor = New System.Windows.Forms.PictureBox()
        Me.PDelete = New System.Windows.Forms.PictureBox()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Save = New System.Windows.Forms.PictureBox()
        Me.GPicture = New System.Windows.Forms.PictureBox()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Display
        '
        Me.Display.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Display.Location = New System.Drawing.Point(1, 26)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(336, 335)
        Me.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Display.TabIndex = 1
        Me.Display.TabStop = False
        '
        'Visor
        '
        Me.Visor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Visor.Location = New System.Drawing.Point(1, 26)
        Me.Visor.Name = "Visor"
        Me.Visor.Size = New System.Drawing.Size(336, 335)
        Me.Visor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Visor.TabIndex = 3
        Me.Visor.TabStop = False
        Me.Visor.Visible = False
        '
        'PDelete
        '
        Me.PDelete.Image = Global.centro_medico.My.Resources.Resources.delete_picture
        Me.PDelete.Location = New System.Drawing.Point(43, 1)
        Me.PDelete.Name = "PDelete"
        Me.PDelete.Size = New System.Drawing.Size(25, 25)
        Me.PDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PDelete.TabIndex = 6
        Me.PDelete.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PDelete, "Cancelar")
        Me.PDelete.Visible = False
        '
        'Save
        '
        Me.Save.Image = Global.centro_medico.My.Resources.Resources.ok_picture
        Me.Save.Location = New System.Drawing.Point(12, 1)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(25, 25)
        Me.Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Save.TabIndex = 7
        Me.Save.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Save, "Aceptar")
        Me.Save.Visible = False
        '
        'GPicture
        '
        Me.GPicture.Image = Global.centro_medico.My.Resources.Resources.camera
        Me.GPicture.Location = New System.Drawing.Point(12, 1)
        Me.GPicture.Name = "GPicture"
        Me.GPicture.Size = New System.Drawing.Size(25, 25)
        Me.GPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GPicture.TabIndex = 8
        Me.GPicture.TabStop = False
        Me.ToolTip1.SetToolTip(Me.GPicture, "Capturar")
        '
        'formPaciente_Captura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 362)
        Me.Controls.Add(Me.GPicture)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.PDelete)
        Me.Controls.Add(Me.Visor)
        Me.Controls.Add(Me.Display)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(354, 400)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(354, 400)
        Me.Name = "formPaciente_Captura"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura"
        CType(Me.Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Display As System.Windows.Forms.PictureBox
    Friend WithEvents Visor As System.Windows.Forms.PictureBox
    Friend WithEvents PDelete As System.Windows.Forms.PictureBox
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Save As System.Windows.Forms.PictureBox
    Friend WithEvents GPicture As System.Windows.Forms.PictureBox
End Class
