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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_Actualizar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_Tamanno = New System.Windows.Forms.Label
        Me.lbl_Disponible = New System.Windows.Forms.Label
        Me.lbl_Actual = New System.Windows.Forms.Label
        Me.lbl_VersionActual = New System.Windows.Forms.Label
        Me.lbl_TamannoDescarga = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.rt_Log = New System.Windows.Forms.RichTextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(263, 175)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(255, 149)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Nueva Version"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rt_Log)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(255, 149)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalles"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(190, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Más tarde..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Actualizar.Location = New System.Drawing.Point(98, 184)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Actualizar.TabIndex = 6
        Me.btn_Actualizar.Text = "Actualizar"
        Me.btn_Actualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_Tamanno)
        Me.GroupBox1.Controls.Add(Me.lbl_Disponible)
        Me.GroupBox1.Controls.Add(Me.lbl_Actual)
        Me.GroupBox1.Controls.Add(Me.lbl_VersionActual)
        Me.GroupBox1.Controls.Add(Me.lbl_TamannoDescarga)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 88)
        Me.GroupBox1.TabIndex = 7
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
        'lbl_VersionActual
        '
        Me.lbl_VersionActual.AutoSize = True
        Me.lbl_VersionActual.Location = New System.Drawing.Point(55, 16)
        Me.lbl_VersionActual.Name = "lbl_VersionActual"
        Me.lbl_VersionActual.Size = New System.Drawing.Size(80, 13)
        Me.lbl_VersionActual.TabIndex = 1
        Me.lbl_VersionActual.Text = "Versión actual: "
        '
        'lbl_TamannoDescarga
        '
        Me.lbl_TamannoDescarga.AutoSize = True
        Me.lbl_TamannoDescarga.Location = New System.Drawing.Point(37, 61)
        Me.lbl_TamannoDescarga.Name = "lbl_TamannoDescarga"
        Me.lbl_TamannoDescarga.Size = New System.Drawing.Size(96, 13)
        Me.lbl_TamannoDescarga.TabIndex = 1
        Me.lbl_TamannoDescarga.Text = "Tamaño descarga:"
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
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(36, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nueva versión disponible, se recomienda actualizar inmediatamente."
        '
        'rt_Log
        '
        Me.rt_Log.Location = New System.Drawing.Point(7, 7)
        Me.rt_Log.Name = "rt_Log"
        Me.rt_Log.Size = New System.Drawing.Size(240, 136)
        Me.rt_Log.TabIndex = 0
        Me.rt_Log.Text = ""
        '
        'frmNuevaVersionDisponible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(269, 212)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Actualizar)
        Me.Name = "frmNuevaVersionDisponible"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva versión"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents lbl_Tamanno As System.Windows.Forms.Label
    Public WithEvents lbl_Disponible As System.Windows.Forms.Label
    Public WithEvents lbl_Actual As System.Windows.Forms.Label
    Friend WithEvents lbl_VersionActual As System.Windows.Forms.Label
    Friend WithEvents lbl_TamannoDescarga As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rt_Log As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Actualizar As System.Windows.Forms.Button
End Class
