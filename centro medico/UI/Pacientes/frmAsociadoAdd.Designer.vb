<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsociadoAdd
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
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente
        Me.AsociadoComboBox = New System.Windows.Forms.ComboBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ParentescoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ParentescoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(36, 19)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(407, 50)
        Me.CtrlPaciente1.TabIndex = 0
        '
        'AsociadoComboBox
        '
        Me.AsociadoComboBox.DataSource = Me.ParentescoBindingSource
        Me.AsociadoComboBox.DisplayMember = "Descripcion"
        Me.AsociadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AsociadoComboBox.FormattingEnabled = True
        Me.AsociadoComboBox.Location = New System.Drawing.Point(91, 87)
        Me.AsociadoComboBox.Name = "AsociadoComboBox"
        Me.AsociadoComboBox.Size = New System.Drawing.Size(235, 21)
        Me.AsociadoComboBox.TabIndex = 2
        Me.AsociadoComboBox.ValueMember = "IdParentesco"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(407, 147)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CtrlPaciente1)
        Me.GroupBox1.Controls.Add(Me.AsociadoComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 129)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Parentesco"
        '
        'ParentescoBindingSource
        '
        Me.ParentescoBindingSource.DataSource = GetType(centro_medico.Parentesco)
        '
        'frmAsociadoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 182)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmAsociadoAdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione paciente socio y parentesco"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ParentescoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Public WithEvents AsociadoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ParentescoBindingSource As System.Windows.Forms.BindingSource
End Class
