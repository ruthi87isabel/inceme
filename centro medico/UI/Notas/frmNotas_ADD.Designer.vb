<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotas_ADD
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim NOMBRECOMPLETOLabel As System.Windows.Forms.Label
        Dim NOTALabel As System.Windows.Forms.Label
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NOTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NOMBRECOMPLETOTextBox = New System.Windows.Forms.TextBox()
        Me.NOTATextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        FechaLabel = New System.Windows.Forms.Label()
        NOMBRECOMPLETOLabel = New System.Windows.Forms.Label()
        NOTALabel = New System.Windows.Forms.Label()
        CType(Me.NOTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(9, 41)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 3
        FechaLabel.Text = "Fecha:"
        '
        'NOMBRECOMPLETOLabel
        '
        NOMBRECOMPLETOLabel.AutoSize = True
        NOMBRECOMPLETOLabel.Location = New System.Drawing.Point(9, 15)
        NOMBRECOMPLETOLabel.Name = "NOMBRECOMPLETOLabel"
        NOMBRECOMPLETOLabel.Size = New System.Drawing.Size(35, 13)
        NOMBRECOMPLETOLabel.TabIndex = 21
        NOMBRECOMPLETOLabel.Text = "Autor:"
        '
        'NOTALabel
        '
        NOTALabel.AutoSize = True
        NOTALabel.Location = New System.Drawing.Point(9, 69)
        NOTALabel.Name = "NOTALabel"
        NOTALabel.Size = New System.Drawing.Size(40, 13)
        NOTALabel.TabIndex = 26
        NOTALabel.Text = "NOTA:"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NOTABindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(55, 38)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(164, 20)
        Me.FechaDateTimePicker.TabIndex = 2
        '
        'NOTABindingSource
        '
        Me.NOTABindingSource.DataSource = GetType(centro_medico.NOTA)
        '
        'NOMBRECOMPLETOTextBox
        '
        Me.NOMBRECOMPLETOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOTABindingSource, "USUARIO.NOMBRECOMPLETO", True))
        Me.NOMBRECOMPLETOTextBox.Location = New System.Drawing.Point(55, 12)
        Me.NOMBRECOMPLETOTextBox.Name = "NOMBRECOMPLETOTextBox"
        Me.NOMBRECOMPLETOTextBox.ReadOnly = True
        Me.NOMBRECOMPLETOTextBox.Size = New System.Drawing.Size(271, 20)
        Me.NOMBRECOMPLETOTextBox.TabIndex = 0
        '
        'NOTATextBox
        '
        Me.NOTATextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NOTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOTABindingSource, "NOTA", True))
        Me.NOTATextBox.Location = New System.Drawing.Point(55, 69)
        Me.NOTATextBox.Multiline = True
        Me.NOTATextBox.Name = "NOTATextBox"
        Me.NOTATextBox.Size = New System.Drawing.Size(382, 102)
        Me.NOTATextBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(124, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(218, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmNotas_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 217)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NOTALabel)
        Me.Controls.Add(Me.NOTATextBox)
        Me.Controls.Add(NOMBRECOMPLETOLabel)
        Me.Controls.Add(Me.NOMBRECOMPLETOTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Name = "frmNotas_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar nota"
        CType(Me.NOTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOTATextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents NOTABindingSource As System.Windows.Forms.BindingSource
    Public WithEvents NOMBRECOMPLETOTextBox As System.Windows.Forms.TextBox
End Class
