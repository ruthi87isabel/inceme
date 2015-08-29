<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPoblacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UiComboBox1 = New Janus.Windows.EditControls.UIComboBox()
        Me.NPoblacioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.NPoblacioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Población"
        '
        'UiComboBox1
        '
        Me.UiComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiComboBox1.DataSource = Me.NPoblacioneBindingSource
        Me.UiComboBox1.DisplayMember = "Nombre"
        Me.UiComboBox1.Location = New System.Drawing.Point(64, 3)
        Me.UiComboBox1.Name = "UiComboBox1"
        Me.UiComboBox1.SelectInDataSource = True
        Me.UiComboBox1.Size = New System.Drawing.Size(252, 20)
        Me.UiComboBox1.Sorted = True
        Me.UiComboBox1.TabIndex = 84
        Me.UiComboBox1.ValueMember = "ID_Poblacion"
        '
        'NPoblacioneBindingSource
        '
        Me.NPoblacioneBindingSource.DataSource = GetType(centro_medico.N_Poblacione)
        '
        'ctrlPoblacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UiComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ctrlPoblacion"
        Me.Size = New System.Drawing.Size(319, 28)
        CType(Me.NPoblacioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UiComboBox1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents NPoblacioneBindingSource As System.Windows.Forms.BindingSource

End Class
