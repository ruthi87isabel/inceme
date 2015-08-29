<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilia_ADD
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
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Me.CONCEPTOSFAMILIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTextBox = New ctrlTextboxAvanzado()
        Me.DescripcionTextBox = New ctrlTextboxAvanzado()
        Me.NaturalCheckBox = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.chkDental = New System.Windows.Forms.CheckBox()
        Me.grpDental = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        CategoriaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.CONCEPTOSFAMILIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDental.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(25, 62)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 1
        CategoriaLabel.Text = "Categoria:"
        CategoriaLabel.Visible = False
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(14, 32)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'CONCEPTOSFAMILIABindingSource
        '
        Me.CONCEPTOSFAMILIABindingSource.DataSource = GetType(centro_medico.CONCEPTOSFAMILIA)
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSFAMILIABindingSource, "Categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(86, 55)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(42, 20)
        Me.CategoriaTextBox.TabIndex = 1
        Me.CategoriaTextBox.Text = "2"
        Me.CategoriaTextBox.Visible = False
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSFAMILIABindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(86, 29)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(233, 20)
        Me.DescripcionTextBox.TabIndex = 0
        '
        'NaturalCheckBox
        '
        Me.NaturalCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NaturalCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CONCEPTOSFAMILIABindingSource, "Natural", True))
        Me.NaturalCheckBox.Location = New System.Drawing.Point(18, 19)
        Me.NaturalCheckBox.Name = "NaturalCheckBox"
        Me.NaturalCheckBox.Size = New System.Drawing.Size(60, 24)
        Me.NaturalCheckBox.TabIndex = 3
        Me.NaturalCheckBox.Text = "Natural"
        Me.NaturalCheckBox.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(364, 186)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'chkDental
        '
        Me.chkDental.AutoSize = True
        Me.chkDental.Location = New System.Drawing.Point(28, 96)
        Me.chkDental.Name = "chkDental"
        Me.chkDental.Size = New System.Drawing.Size(92, 17)
        Me.chkDental.TabIndex = 2
        Me.chkDental.Text = "Familia Dental"
        Me.chkDental.UseVisualStyleBackColor = True
        '
        'grpDental
        '
        Me.grpDental.Controls.Add(Me.NaturalCheckBox)
        Me.grpDental.Enabled = False
        Me.grpDental.Location = New System.Drawing.Point(28, 119)
        Me.grpDental.Name = "grpDental"
        Me.grpDental.Size = New System.Drawing.Size(308, 63)
        Me.grpDental.TabIndex = 11
        Me.grpDental.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CONCEPTOSFAMILIABindingSource, "IconoName", True))
        Me.PictureBox1.Location = New System.Drawing.Point(353, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 84)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(418, 111)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(21, 23)
        Me.btnBrowse.TabIndex = 13
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'frmFamilia_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 214)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpDental)
        Me.Controls.Add(Me.chkDental)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Name = "frmFamilia_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar Familia"
        CType(Me.CONCEPTOSFAMILIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDental.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CONCEPTOSFAMILIABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTextBox As ctrlTextboxAvanzado
    Friend WithEvents DescripcionTextBox As ctrlTextboxAvanzado
    Friend WithEvents NaturalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents chkDental As System.Windows.Forms.CheckBox
    Friend WithEvents grpDental As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
End Class
