<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalas_ADD
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ID_SALALabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Me.SALABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionTextBox = New ctrlTextboxAvanzado()
        Me.ID_SALATextBox = New ctrlTextboxAvanzado()
        Me.NombreTextBox = New ctrlTextboxAvanzado()
        Me.btnGuardar = New System.Windows.Forms.Button()
        DescripcionLabel = New System.Windows.Forms.Label()
        ID_SALALabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.SALABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SALABindingSource
        '
        Me.SALABindingSource.DataSource = GetType(centro_medico.SALA)
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(7, 76)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 1
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALABindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(75, 76)
        Me.DescripcionTextBox.MaxLength = 200
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(342, 165)
        Me.DescripcionTextBox.TabIndex = 1
        '
        'ID_SALALabel
        '
        ID_SALALabel.AutoSize = True
        ID_SALALabel.Location = New System.Drawing.Point(18, 15)
        ID_SALALabel.Name = "ID_SALALabel"
        ID_SALALabel.Size = New System.Drawing.Size(43, 13)
        ID_SALALabel.TabIndex = 5
        ID_SALALabel.Text = "Código:"
        '
        'ID_SALATextBox
        '
        Me.ID_SALATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALABindingSource, "ID_SALA", True))
        Me.ID_SALATextBox.Location = New System.Drawing.Point(75, 12)
        Me.ID_SALATextBox.Name = "ID_SALATextBox"
        Me.ID_SALATextBox.ReadOnly = True
        Me.ID_SALATextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_SALATextBox.TabIndex = 6
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(18, 45)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 7
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALABindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(75, 38)
        Me.NombreTextBox.Multiline = True
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(342, 20)
        Me.NombreTextBox.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(342, 247)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmSalas_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 282)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(ID_SALALabel)
        Me.Controls.Add(Me.ID_SALATextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Name = "frmSalas_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar Sala"
        CType(Me.SALABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DescripcionTextBox As ctrlTextboxAvanzado
    Friend WithEvents ID_SALATextBox As ctrlTextboxAvanzado
    Friend WithEvents NombreTextBox As ctrlTextboxAvanzado
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Public WithEvents SALABindingSource As System.Windows.Forms.BindingSource
End Class
