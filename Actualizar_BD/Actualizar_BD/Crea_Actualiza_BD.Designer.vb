<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crea_Actualiza_BD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crea_Actualiza_BD))
        Me.RbAct = New System.Windows.Forms.RadioButton()
        Me.RbCrear = New System.Windows.Forms.RadioButton()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbSuccess = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbError = New System.Windows.Forms.Label()
        Me.ListBScripts = New System.Windows.Forms.ListBox()
        Me.Examinar = New System.Windows.Forms.Button()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExecute = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LbVersion = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbDestino = New System.Windows.Forms.TextBox()
        Me.ExaminarDestino = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RbAct
        '
        Me.RbAct.AutoSize = True
        Me.RbAct.Location = New System.Drawing.Point(79, 9)
        Me.RbAct.Name = "RbAct"
        Me.RbAct.Size = New System.Drawing.Size(71, 17)
        Me.RbAct.TabIndex = 13
        Me.RbAct.Text = "Actualizar"
        Me.RbAct.UseVisualStyleBackColor = True
        '
        'RbCrear
        '
        Me.RbCrear.AutoSize = True
        Me.RbCrear.Checked = True
        Me.RbCrear.Location = New System.Drawing.Point(21, 9)
        Me.RbCrear.Name = "RbCrear"
        Me.RbCrear.Size = New System.Drawing.Size(50, 17)
        Me.RbCrear.TabIndex = 12
        Me.RbCrear.TabStop = True
        Me.RbCrear.Text = "Crear"
        Me.RbCrear.UseVisualStyleBackColor = True
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(79, 34)
        Me.TbNombre.MaxLength = 30
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(187, 20)
        Me.TbNombre.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nombre BD"
        '
        'LbSuccess
        '
        Me.LbSuccess.AutoSize = True
        Me.LbSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSuccess.ForeColor = System.Drawing.Color.Blue
        Me.LbSuccess.Location = New System.Drawing.Point(28, 317)
        Me.LbSuccess.Name = "LbSuccess"
        Me.LbSuccess.Size = New System.Drawing.Size(55, 13)
        Me.LbSuccess.TabIndex = 21
        Me.LbSuccess.Text = "Success"
        Me.LbSuccess.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Actualizar_BD.My.Resources.Resources.report
        Me.PictureBox1.Location = New System.Drawing.Point(3, 315)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Ver Excepción")
        Me.PictureBox1.Visible = False
        '
        'LbError
        '
        Me.LbError.AutoSize = True
        Me.LbError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbError.Location = New System.Drawing.Point(21, 317)
        Me.LbError.Name = "LbError"
        Me.LbError.Size = New System.Drawing.Size(34, 13)
        Me.LbError.TabIndex = 17
        Me.LbError.Text = "Error"
        Me.LbError.Visible = False
        '
        'ListBScripts
        '
        Me.ListBScripts.FormattingEnabled = True
        Me.ListBScripts.Location = New System.Drawing.Point(16, 156)
        Me.ListBScripts.Name = "ListBScripts"
        Me.ListBScripts.Size = New System.Drawing.Size(250, 121)
        Me.ListBScripts.TabIndex = 16
        '
        'Examinar
        '
        Me.Examinar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Examinar.Location = New System.Drawing.Point(243, 126)
        Me.Examinar.Name = "Examinar"
        Me.Examinar.Size = New System.Drawing.Size(24, 22)
        Me.Examinar.TabIndex = 15
        Me.Examinar.Text = "..."
        Me.Examinar.UseVisualStyleBackColor = True
        '
        'TBDireccion
        '
        Me.TBDireccion.Location = New System.Drawing.Point(16, 127)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(228, 20)
        Me.TBDireccion.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Seleccione el Directorio Contenedor de Scripts"
        '
        'BtnExecute
        '
        Me.BtnExecute.Location = New System.Drawing.Point(74, 282)
        Me.BtnExecute.Name = "BtnExecute"
        Me.BtnExecute.Size = New System.Drawing.Size(138, 29)
        Me.BtnExecute.TabIndex = 12
        Me.BtnExecute.Text = "Crear BD"
        Me.BtnExecute.UseVisualStyleBackColor = True
        '
        'LbVersion
        '
        Me.LbVersion.AutoSize = True
        Me.LbVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVersion.Location = New System.Drawing.Point(169, 11)
        Me.LbVersion.Name = "LbVersion"
        Me.LbVersion.Size = New System.Drawing.Size(49, 13)
        Me.LbVersion.TabIndex = 24
        Me.LbVersion.Text = "Versión"
        Me.LbVersion.Visible = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Seleccione el Directorio Destino de BD"
        '
        'TbDestino
        '
        Me.TbDestino.Location = New System.Drawing.Point(16, 81)
        Me.TbDestino.Name = "TbDestino"
        Me.TbDestino.Size = New System.Drawing.Size(228, 20)
        Me.TbDestino.TabIndex = 26
        '
        'ExaminarDestino
        '
        Me.ExaminarDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExaminarDestino.Location = New System.Drawing.Point(243, 80)
        Me.ExaminarDestino.Name = "ExaminarDestino"
        Me.ExaminarDestino.Size = New System.Drawing.Size(24, 22)
        Me.ExaminarDestino.TabIndex = 27
        Me.ExaminarDestino.Text = "..."
        Me.ExaminarDestino.UseVisualStyleBackColor = True
        '
        'Crea_Actualiza_BD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 336)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbDestino)
        Me.Controls.Add(Me.ExaminarDestino)
        Me.Controls.Add(Me.LbVersion)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.RbAct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RbCrear)
        Me.Controls.Add(Me.ListBScripts)
        Me.Controls.Add(Me.LbSuccess)
        Me.Controls.Add(Me.BtnExecute)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbError)
        Me.Controls.Add(Me.TBDireccion)
        Me.Controls.Add(Me.Examinar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.name = "Crea_Actualiza_BD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear y Actualizar BD"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RbAct As System.Windows.Forms.RadioButton
    Friend WithEvents RbCrear As System.Windows.Forms.RadioButton
    Friend WithEvents BtnExecute As System.Windows.Forms.Button
    Friend WithEvents Examinar As System.Windows.Forms.Button
    Friend WithEvents TBDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ListBScripts As System.Windows.Forms.ListBox
    Friend WithEvents LbError As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LbSuccess As System.Windows.Forms.Label
    Friend WithEvents TbNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LbVersion As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbDestino As System.Windows.Forms.TextBox
    Friend WithEvents ExaminarDestino As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog

End Class
