<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdaterConfig
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
        Me.tabConfig = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.grpConfirmaciones = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.pnl_Internet = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_UrlServidor = New System.Windows.Forms.TextBox
        Me.pnl_Local = New System.Windows.Forms.Panel
        Me.txt_FolderPath = New System.Windows.Forms.TextBox
        Me.bnt_BrowseFolder = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_Local = New System.Windows.Forms.RadioButton
        Me.rb_Internet = New System.Windows.Forms.RadioButton
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.tabConfig.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpConfirmaciones.SuspendLayout()
        Me.pnl_Internet.SuspendLayout()
        Me.pnl_Local.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabConfig
        '
        Me.tabConfig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabConfig.Controls.Add(Me.TabPage1)
        Me.tabConfig.Location = New System.Drawing.Point(5, 12)
        Me.tabConfig.Name = "tabConfig"
        Me.tabConfig.SelectedIndex = 0
        Me.tabConfig.Size = New System.Drawing.Size(520, 216)
        Me.tabConfig.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpConfirmaciones)
        Me.TabPage1.Controls.Add(Me.pnl_Internet)
        Me.TabPage1.Controls.Add(Me.pnl_Local)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(512, 190)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Configuración"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpConfirmaciones
        '
        Me.grpConfirmaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpConfirmaciones.Controls.Add(Me.RadioButton3)
        Me.grpConfirmaciones.Controls.Add(Me.RadioButton1)
        Me.grpConfirmaciones.Location = New System.Drawing.Point(230, 6)
        Me.grpConfirmaciones.Name = "grpConfirmaciones"
        Me.grpConfirmaciones.Size = New System.Drawing.Size(273, 97)
        Me.grpConfirmaciones.TabIndex = 6
        Me.grpConfirmaciones.TabStop = False
        Me.grpConfirmaciones.Text = "Confirmaciones"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(15, 51)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(158, 17)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.Text = "Descargar automaticamente"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(241, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Preguntar antes de descargar actualizaciones"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'pnl_Internet
        '
        Me.pnl_Internet.Controls.Add(Me.Label1)
        Me.pnl_Internet.Controls.Add(Me.txt_UrlServidor)
        Me.pnl_Internet.Location = New System.Drawing.Point(11, 113)
        Me.pnl_Internet.Name = "pnl_Internet"
        Me.pnl_Internet.Size = New System.Drawing.Size(490, 60)
        Me.pnl_Internet.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Url Servidor de Actualizaciones::"
        '
        'txt_UrlServidor
        '
        Me.txt_UrlServidor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_UrlServidor.Location = New System.Drawing.Point(6, 26)
        Me.txt_UrlServidor.Multiline = True
        Me.txt_UrlServidor.Name = "txt_UrlServidor"
        Me.txt_UrlServidor.Size = New System.Drawing.Size(473, 22)
        Me.txt_UrlServidor.TabIndex = 1
        '
        'pnl_Local
        '
        Me.pnl_Local.Controls.Add(Me.txt_FolderPath)
        Me.pnl_Local.Controls.Add(Me.bnt_BrowseFolder)
        Me.pnl_Local.Controls.Add(Me.Label2)
        Me.pnl_Local.Location = New System.Drawing.Point(9, 113)
        Me.pnl_Local.Name = "pnl_Local"
        Me.pnl_Local.Size = New System.Drawing.Size(491, 61)
        Me.pnl_Local.TabIndex = 4
        Me.pnl_Local.Visible = False
        '
        'txt_FolderPath
        '
        Me.txt_FolderPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FolderPath.Location = New System.Drawing.Point(12, 26)
        Me.txt_FolderPath.Multiline = True
        Me.txt_FolderPath.Name = "txt_FolderPath"
        Me.txt_FolderPath.ReadOnly = True
        Me.txt_FolderPath.Size = New System.Drawing.Size(406, 21)
        Me.txt_FolderPath.TabIndex = 1
        '
        'bnt_BrowseFolder
        '
        Me.bnt_BrowseFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnt_BrowseFolder.Location = New System.Drawing.Point(424, 26)
        Me.bnt_BrowseFolder.Name = "bnt_BrowseFolder"
        Me.bnt_BrowseFolder.Size = New System.Drawing.Size(64, 21)
        Me.bnt_BrowseFolder.TabIndex = 3
        Me.bnt_BrowseFolder.Text = "Buscar"
        Me.bnt_BrowseFolder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Carpeta local:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_Local)
        Me.GroupBox1.Controls.Add(Me.rb_Internet)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origen"
        '
        'rb_Local
        '
        Me.rb_Local.AutoSize = True
        Me.rb_Local.Location = New System.Drawing.Point(23, 51)
        Me.rb_Local.Name = "rb_Local"
        Me.rb_Local.Size = New System.Drawing.Size(91, 17)
        Me.rb_Local.TabIndex = 0
        Me.rb_Local.Text = "Carpeta Local"
        Me.rb_Local.UseVisualStyleBackColor = True
        '
        'rb_Internet
        '
        Me.rb_Internet.AutoSize = True
        Me.rb_Internet.Checked = True
        Me.rb_Internet.Location = New System.Drawing.Point(23, 28)
        Me.rb_Internet.Name = "rb_Internet"
        Me.rb_Internet.Size = New System.Drawing.Size(61, 17)
        Me.rb_Internet.TabIndex = 0
        Me.rb_Internet.TabStop = True
        Me.rb_Internet.Text = "Internet"
        Me.rb_Internet.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(365, 234)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 2
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Location = New System.Drawing.Point(446, 234)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 2
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'frmUpdaterConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 262)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.tabConfig)
        Me.Name = "frmUpdaterConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar actualizaciones automáticas"
        Me.TopMost = True
        Me.tabConfig.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpConfirmaciones.ResumeLayout(False)
        Me.grpConfirmaciones.PerformLayout()
        Me.pnl_Internet.ResumeLayout(False)
        Me.pnl_Internet.PerformLayout()
        Me.pnl_Local.ResumeLayout(False)
        Me.pnl_Local.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabConfig As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_UrlServidor As System.Windows.Forms.TextBox
    Friend WithEvents rb_Local As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Internet As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_FolderPath As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents pnl_Internet As System.Windows.Forms.Panel
    Friend WithEvents pnl_Local As System.Windows.Forms.Panel
    Friend WithEvents bnt_BrowseFolder As System.Windows.Forms.Button
    Friend WithEvents grpConfirmaciones As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
