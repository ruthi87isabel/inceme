<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Actualizar_BD
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
        Me.LbVersionBD = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListScripts = New System.Windows.Forms.ComboBox()
        Me.BtnActualiza = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'LbVersionBD
        '
        Me.LbVersionBD.AutoSize = True
        Me.LbVersionBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVersionBD.Location = New System.Drawing.Point(12, 19)
        Me.LbVersionBD.Name = "LbVersionBD"
        Me.LbVersionBD.Size = New System.Drawing.Size(187, 15)
        Me.LbVersionBD.TabIndex = 0
        Me.LbVersionBD.Text = "Versión Actual de Base de Datos "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ultima Versión Disponible"
        '
        'ListScripts
        '
        Me.ListScripts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListScripts.FormattingEnabled = True
        Me.ListScripts.Location = New System.Drawing.Point(19, 126)
        Me.ListScripts.Name = "ListScripts"
        Me.ListScripts.Size = New System.Drawing.Size(121, 21)
        Me.ListScripts.Sorted = True
        Me.ListScripts.TabIndex = 3
        '
        'BtnActualiza
        '
        Me.BtnActualiza.Location = New System.Drawing.Point(59, 174)
        Me.BtnActualiza.Name = "BtnActualiza"
        Me.BtnActualiza.Size = New System.Drawing.Size(170, 68)
        Me.BtnActualiza.TabIndex = 4
        Me.BtnActualiza.Text = "Actualizar BD"
        Me.BtnActualiza.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(19, 82)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(103, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Script de Partida"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(19, 102)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(151, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.Text = "Correr Script Seleccionado"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'form_Actualizar_BD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.BtnActualiza)
        Me.Controls.Add(Me.ListScripts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbVersionBD)
        Me.Name = "form_Actualizar_BD"
        Me.Text = "Actualizar_BD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbVersionBD As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListScripts As System.Windows.Forms.ComboBox
    Friend WithEvents BtnActualiza As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class
