<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes_ReportesPersonalizados_ADD
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
        Dim DataSourceNameLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim FileNameLabel As System.Windows.Forms.Label
        Dim SeccionLabel As System.Windows.Forms.Label
        Me.DataSourceNameTextBox = New ctrlTextboxAvanzado
        Me.ReportesPersonalizadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionTextBox = New ctrlTextboxAvanzado
        Me.FileNameTextBox = New ctrlTextboxAvanzado
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        DataSourceNameLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        FileNameLabel = New System.Windows.Forms.Label
        SeccionLabel = New System.Windows.Forms.Label
        CType(Me.ReportesPersonalizadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSourceNameLabel
        '
        DataSourceNameLabel.AutoSize = True
        DataSourceNameLabel.Location = New System.Drawing.Point(17, 105)
        DataSourceNameLabel.Name = "DataSourceNameLabel"
        DataSourceNameLabel.Size = New System.Drawing.Size(70, 13)
        DataSourceNameLabel.TabIndex = 1
        DataSourceNameLabel.Text = "Data Source:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(21, 52)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripción:"
        '
        'FileNameLabel
        '
        FileNameLabel.AutoSize = True
        FileNameLabel.Location = New System.Drawing.Point(30, 25)
        FileNameLabel.Name = "FileNameLabel"
        FileNameLabel.Size = New System.Drawing.Size(45, 13)
        FileNameLabel.TabIndex = 7
        FileNameLabel.Text = "Fichero:"
        '
        'SeccionLabel
        '
        SeccionLabel.AutoSize = True
        SeccionLabel.Location = New System.Drawing.Point(34, 131)
        SeccionLabel.Name = "SeccionLabel"
        SeccionLabel.Size = New System.Drawing.Size(49, 13)
        SeccionLabel.TabIndex = 13
        SeccionLabel.Text = "Sección:"
        '
        'DataSourceNameTextBox
        '
        Me.DataSourceNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesPersonalizadoBindingSource, "DataSourceName", True))
        Me.DataSourceNameTextBox.Location = New System.Drawing.Point(89, 102)
        Me.DataSourceNameTextBox.Name = "DataSourceNameTextBox"
        Me.DataSourceNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DataSourceNameTextBox.TabIndex = 2
        '
        'ReportesPersonalizadoBindingSource
        '
        Me.ReportesPersonalizadoBindingSource.DataSource = GetType(centro_medico.ReportesPersonalizado)
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesPersonalizadoBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(89, 49)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(277, 47)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesPersonalizadoBindingSource, "FileName", True))
        Me.FileNameTextBox.Location = New System.Drawing.Point(89, 22)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.ReadOnly = True
        Me.FileNameTextBox.Size = New System.Drawing.Size(248, 20)
        Me.FileNameTextBox.TabIndex = 8
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(336, 20)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(33, 23)
        Me.btnBrowse.TabIndex = 15
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(321, 178)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(SeccionLabel)
        Me.GroupBox1.Controls.Add(DataSourceNameLabel)
        Me.GroupBox1.Controls.Add(Me.FileNameTextBox)
        Me.GroupBox1.Controls.Add(Me.DataSourceNameTextBox)
        Me.GroupBox1.Controls.Add(FileNameLabel)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(4, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 176)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(89, 128)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'frmPacientes_ReportesPersonalizados_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 202)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmPacientes_ReportesPersonalizados_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Reporte Personalizado"
        CType(Me.ReportesPersonalizadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSourceNameTextBox As ctrlTextboxAvanzado
    Friend WithEvents DescripcionTextBox As ctrlTextboxAvanzado
    Friend WithEvents FileNameTextBox As ctrlTextboxAvanzado
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Public WithEvents ReportesPersonalizadoBindingSource As System.Windows.Forms.BindingSource
End Class
