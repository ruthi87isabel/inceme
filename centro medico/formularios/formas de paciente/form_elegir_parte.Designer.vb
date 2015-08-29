<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_elegir_parte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_Asistencia = New System.Windows.Forms.RadioButton
        Me.rb_Baja = New System.Windows.Forms.RadioButton
        Me.bt_Cancelar = New System.Windows.Forms.Button
        Me.bt_Aceptar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_Asistencia)
        Me.GroupBox1.Controls.Add(Me.rb_Baja)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Parte"
        '
        'rb_Asistencia
        '
        Me.rb_Asistencia.AutoSize = True
        Me.rb_Asistencia.Location = New System.Drawing.Point(160, 22)
        Me.rb_Asistencia.Name = "rb_Asistencia"
        Me.rb_Asistencia.Size = New System.Drawing.Size(80, 19)
        Me.rb_Asistencia.TabIndex = 1
        Me.rb_Asistencia.Text = "Asistencia"
        Me.rb_Asistencia.UseVisualStyleBackColor = True
        '
        'rb_Baja
        '
        Me.rb_Baja.AutoSize = True
        Me.rb_Baja.Checked = True
        Me.rb_Baja.Location = New System.Drawing.Point(20, 22)
        Me.rb_Baja.Name = "rb_Baja"
        Me.rb_Baja.Size = New System.Drawing.Size(73, 19)
        Me.rb_Baja.TabIndex = 0
        Me.rb_Baja.TabStop = True
        Me.rb_Baja.Text = "Baja/Alta"
        Me.rb_Baja.UseVisualStyleBackColor = True
        '
        'bt_Cancelar
        '
        Me.bt_Cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Cancelar.Location = New System.Drawing.Point(201, 69)
        Me.bt_Cancelar.Name = "bt_Cancelar"
        Me.bt_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Cancelar.TabIndex = 2
        Me.bt_Cancelar.Text = "Cancelar"
        Me.bt_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Cancelar.UseVisualStyleBackColor = True
        '
        'bt_Aceptar
        '
        Me.bt_Aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Aceptar.Location = New System.Drawing.Point(120, 69)
        Me.bt_Aceptar.Name = "bt_Aceptar"
        Me.bt_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Aceptar.TabIndex = 1
        Me.bt_Aceptar.Text = "Aceptar"
        Me.bt_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Aceptar.UseVisualStyleBackColor = True
        '
        'form_elegir_parte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 98)
        Me.Controls.Add(Me.bt_Cancelar)
        Me.Controls.Add(Me.bt_Aceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "form_elegir_parte"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nuevo Parte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Asistencia As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Baja As System.Windows.Forms.RadioButton
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_Aceptar As System.Windows.Forms.Button
End Class
