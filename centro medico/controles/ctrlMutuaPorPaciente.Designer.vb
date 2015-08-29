<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlMutuaPorPaciente
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUASComboBox = New System.Windows.Forms.ComboBox()
        Me.txtCMutua = New centro_medico.ctrlTextboxAvanzado()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MUTUASComboBox
        '
        Me.MUTUASComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MUTUASComboBox.DataSource = Me.MUTUASBindingSource
        Me.MUTUASComboBox.DisplayMember = "NOMBRE"
        Me.MUTUASComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MUTUASComboBox.Location = New System.Drawing.Point(32, 0)
        Me.MUTUASComboBox.Name = "MUTUASComboBox"
        Me.MUTUASComboBox.Size = New System.Drawing.Size(147, 21)
        Me.MUTUASComboBox.TabIndex = 1
        Me.MUTUASComboBox.ValueMember = "CMUTUA"
        '
        'txtCMutua
        '
        Me.txtCMutua.AcceptsReturn = True
        Me.txtCMutua.Location = New System.Drawing.Point(0, 0)
        Me.txtCMutua.Multiline = True
        Me.txtCMutua.Name = "txtCMutua"
        Me.txtCMutua.ReadOnly = True
        Me.txtCMutua.Size = New System.Drawing.Size(30, 21)
        Me.txtCMutua.TabIndex = 124
        '
        'ctrlMutuaPorPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtCMutua)
        Me.Controls.Add(Me.MUTUASComboBox)
        Me.Name = "ctrlMutuaPorPaciente"
        Me.Size = New System.Drawing.Size(182, 24)
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUASComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents txtCMutua As ctrlTextboxAvanzado

End Class
