<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaVersionDisponible
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_VersionActual = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_TamannoDescarga = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_Tamanno = New System.Windows.Forms.Label
        Me.lbl_Disponible = New System.Windows.Forms.Label
        Me.lbl_Actual = New System.Windows.Forms.Label
        Me.btn_Actualizar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(41, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nueva versión disponible, se recomienda actualizar inmediatamente."
        '
        'lbl_VersionActual
        '
        Me.lbl_VersionActual.AutoSize = True
        Me.lbl_VersionActual.Location = New System.Drawing.Point(55, 16)
        Me.lbl_VersionActual.Name = "lbl_VersionActual"
        Me.lbl_VersionActual.Size = New System.Drawing.Size(80, 13)
        Me.lbl_VersionActual.TabIndex = 1
        Me.lbl_VersionActual.Text = "Versión actual: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Versión disponible: "
        '
        'lbl_TamannoDescarga
        '
        Me.lbl_TamannoDescarga.AutoSize = True
        Me.lbl_TamannoDescarga.Location = New System.Drawing.Point(16, 61)
        Me.lbl_TamannoDescarga.Name = "lbl_TamannoDescarga"
        Me.lbl_TamannoDescarga.Size = New System.Drawing.Size(119, 13)
        Me.lbl_TamannoDescarga.TabIndex = 1
        Me.lbl_TamannoDescarga.Text = "Tamaño descarga (KB):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_Tamanno)
        Me.GroupBox1.Controls.Add(Me.lbl_Disponible)
        Me.GroupBox1.Controls.Add(Me.lbl_Actual)
        Me.GroupBox1.Controls.Add(Me.lbl_VersionActual)
        Me.GroupBox1.Controls.Add(Me.lbl_TamannoDescarga)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 88)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lbl_Tamanno
        '
        Me.lbl_Tamanno.AutoSize = True
        Me.lbl_Tamanno.Location = New System.Drawing.Point(141, 61)
        Me.lbl_Tamanno.Name = "lbl_Tamanno"
        Me.lbl_Tamanno.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Tamanno.TabIndex = 1
        Me.lbl_Tamanno.Text = "1000"
        '
        'lbl_Disponible
        '
        Me.lbl_Disponible.AutoSize = True
        Me.lbl_Disponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Disponible.Location = New System.Drawing.Point(141, 34)
        Me.lbl_Disponible.Name = "lbl_Disponible"
        Me.lbl_Disponible.Size = New System.Drawing.Size(68, 13)
        Me.lbl_Disponible.TabIndex = 1
        Me.lbl_Disponible.Text = "99.99.99.9"
        '
        'lbl_Actual
        '
        Me.lbl_Actual.AutoSize = True
        Me.lbl_Actual.Location = New System.Drawing.Point(141, 16)
        Me.lbl_Actual.Name = "lbl_Actual"
        Me.lbl_Actual.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Actual.TabIndex = 1
        Me.lbl_Actual.Text = "0.0.0.0"
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.Location = New System.Drawing.Point(44, 148)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Actualizar.TabIndex = 3
        Me.btn_Actualizar.Text = "Actualizar"
        Me.btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Más tarde..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.centro_medico.My.Resources.Resources._24_message_info
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmNuevaVersionDisponible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(259, 183)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Actualizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNuevaVersionDisponible"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva versión"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_VersionActual As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_TamannoDescarga As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Disponible As System.Windows.Forms.Label
    Friend WithEvents lbl_Actual As System.Windows.Forms.Label
    Friend WithEvents lbl_Tamanno As System.Windows.Forms.Label
    Friend WithEvents btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
