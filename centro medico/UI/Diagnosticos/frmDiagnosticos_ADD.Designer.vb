<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiagnosticos_ADD
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
        Dim CIE10Label As System.Windows.Forms.Label
        Dim NIVELLabel As System.Windows.Forms.Label
        Dim OBSERVACIONESLabel As System.Windows.Forms.Label
        Dim DIAGNOSTICOLabel As System.Windows.Forms.Label
        Me.DIAGNOSTICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIE10TextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.NIVELTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.OBSERVACIONESTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.SUBNIVELTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.lb_datos = New System.Windows.Forms.Label()
        Me.DIAGNOSTICOTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.FAVORITOCheckBox = New System.Windows.Forms.CheckBox()
        CIE10Label = New System.Windows.Forms.Label()
        NIVELLabel = New System.Windows.Forms.Label()
        OBSERVACIONESLabel = New System.Windows.Forms.Label()
        DIAGNOSTICOLabel = New System.Windows.Forms.Label()
        CType(Me.DIAGNOSTICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CIE10Label
        '
        CIE10Label.AutoSize = True
        CIE10Label.Location = New System.Drawing.Point(4, 31)
        CIE10Label.Name = "CIE10Label"
        CIE10Label.Size = New System.Drawing.Size(78, 13)
        CIE10Label.TabIndex = 3
        CIE10Label.Text = "Código CIE 10:"
        '
        'NIVELLabel
        '
        NIVELLabel.AutoSize = True
        NIVELLabel.Location = New System.Drawing.Point(117, 31)
        NIVELLabel.Name = "NIVELLabel"
        NIVELLabel.Size = New System.Drawing.Size(69, 13)
        NIVELLabel.TabIndex = 9
        NIVELLabel.Text = "Código CIE 9"
        '
        'OBSERVACIONESLabel
        '
        OBSERVACIONESLabel.AutoSize = True
        OBSERVACIONESLabel.Location = New System.Drawing.Point(4, 285)
        OBSERVACIONESLabel.Name = "OBSERVACIONESLabel"
        OBSERVACIONESLabel.Size = New System.Drawing.Size(101, 13)
        OBSERVACIONESLabel.TabIndex = 11
        OBSERVACIONESLabel.Text = "OBSERVACIONES:"
        '
        'DIAGNOSTICOLabel
        '
        DIAGNOSTICOLabel.AutoSize = True
        DIAGNOSTICOLabel.Location = New System.Drawing.Point(4, 81)
        DIAGNOSTICOLabel.Name = "DIAGNOSTICOLabel"
        DIAGNOSTICOLabel.Size = New System.Drawing.Size(84, 13)
        DIAGNOSTICOLabel.TabIndex = 67
        DIAGNOSTICOLabel.Text = "DIAGNOSTICO:"
        '
        'DIAGNOSTICOBindingSource
        '
        Me.DIAGNOSTICOBindingSource.DataSource = GetType(centro_medico.DIAGNOSTICO)
        '
        'CIE10TextBox
        '
        Me.CIE10TextBox.AcceptsReturn = True
        Me.CIE10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIAGNOSTICOBindingSource, "CIE10", True))
        Me.CIE10TextBox.Location = New System.Drawing.Point(7, 47)
        Me.CIE10TextBox.Name = "CIE10TextBox"
        Me.CIE10TextBox.Size = New System.Drawing.Size(100, 20)
        Me.CIE10TextBox.TabIndex = 0
        '
        'NIVELTextBox
        '
        Me.NIVELTextBox.AcceptsReturn = True
        Me.NIVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIAGNOSTICOBindingSource, "NIVEL", True))
        Me.NIVELTextBox.Location = New System.Drawing.Point(120, 47)
        Me.NIVELTextBox.Name = "NIVELTextBox"
        Me.NIVELTextBox.Size = New System.Drawing.Size(66, 20)
        Me.NIVELTextBox.TabIndex = 1
        Me.NIVELTextBox.Text = "---"
        '
        'OBSERVACIONESTextBox
        '
        Me.OBSERVACIONESTextBox.AcceptsReturn = True
        Me.OBSERVACIONESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIAGNOSTICOBindingSource, "OBSERVACIONES", True))
        Me.OBSERVACIONESTextBox.Location = New System.Drawing.Point(7, 301)
        Me.OBSERVACIONESTextBox.Multiline = True
        Me.OBSERVACIONESTextBox.Name = "OBSERVACIONESTextBox"
        Me.OBSERVACIONESTextBox.Size = New System.Drawing.Size(450, 111)
        Me.OBSERVACIONESTextBox.TabIndex = 5
        '
        'SUBNIVELTextBox
        '
        Me.SUBNIVELTextBox.AcceptsReturn = True
        Me.SUBNIVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIAGNOSTICOBindingSource, "SUBNIVEL", True))
        Me.SUBNIVELTextBox.Location = New System.Drawing.Point(192, 47)
        Me.SUBNIVELTextBox.Name = "SUBNIVELTextBox"
        Me.SUBNIVELTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SUBNIVELTextBox.TabIndex = 2
        Me.SUBNIVELTextBox.Text = "---"
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(-3, -1)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(478, 19)
        Me.lb_datos.TabIndex = 67
        Me.lb_datos.Text = "Datos del diagnostico"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DIAGNOSTICOTextBox
        '
        Me.DIAGNOSTICOTextBox.AcceptsReturn = True
        Me.DIAGNOSTICOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIAGNOSTICOBindingSource, "DIAGNOSTICO", True))
        Me.DIAGNOSTICOTextBox.Location = New System.Drawing.Point(7, 97)
        Me.DIAGNOSTICOTextBox.Multiline = True
        Me.DIAGNOSTICOTextBox.Name = "DIAGNOSTICOTextBox"
        Me.DIAGNOSTICOTextBox.Size = New System.Drawing.Size(451, 174)
        Me.DIAGNOSTICOTextBox.TabIndex = 8
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(383, 418)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 7
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(302, 418)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 6
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'FAVORITOCheckBox
        '
        Me.FAVORITOCheckBox.Location = New System.Drawing.Point(302, 47)
        Me.FAVORITOCheckBox.Name = "FAVORITOCheckBox"
        Me.FAVORITOCheckBox.Size = New System.Drawing.Size(75, 24)
        Me.FAVORITOCheckBox.TabIndex = 3
        Me.FAVORITOCheckBox.Text = "Favorito"
        Me.FAVORITOCheckBox.UseVisualStyleBackColor = True
        '
        'frmDiagnosticos_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 448)
        Me.Controls.Add(Me.FAVORITOCheckBox)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(DIAGNOSTICOLabel)
        Me.Controls.Add(Me.DIAGNOSTICOTextBox)
        Me.Controls.Add(Me.lb_datos)
        Me.Controls.Add(CIE10Label)
        Me.Controls.Add(Me.CIE10TextBox)
        Me.Controls.Add(NIVELLabel)
        Me.Controls.Add(Me.NIVELTextBox)
        Me.Controls.Add(OBSERVACIONESLabel)
        Me.Controls.Add(Me.OBSERVACIONESTextBox)
        Me.Controls.Add(Me.SUBNIVELTextBox)
        Me.Name = "frmDiagnosticos_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diagnóstico"
        CType(Me.DIAGNOSTICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DIAGNOSTICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CIE10TextBox As ctrlTextboxAvanzado
    Friend WithEvents NIVELTextBox As ctrlTextboxAvanzado
    Friend WithEvents OBSERVACIONESTextBox As ctrlTextboxAvanzado
    Friend WithEvents SUBNIVELTextBox As ctrlTextboxAvanzado
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents DIAGNOSTICOTextBox As ctrlTextboxAvanzado
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents FAVORITOCheckBox As System.Windows.Forms.CheckBox
End Class
