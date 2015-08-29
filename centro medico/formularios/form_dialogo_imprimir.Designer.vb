<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_dialogo_imprimir
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.gb_destino = New System.Windows.Forms.GroupBox
        Me.rb_impresora = New System.Windows.Forms.RadioButton
        Me.rb_excel = New System.Windows.Forms.RadioButton
        Me.rb_pdf = New System.Windows.Forms.RadioButton
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.chb_vista_previa = New System.Windows.Forms.CheckBox
        Me.gb_destino.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 19)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Formato de impresión"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_destino
        '
        Me.gb_destino.Controls.Add(Me.rb_pdf)
        Me.gb_destino.Controls.Add(Me.rb_excel)
        Me.gb_destino.Controls.Add(Me.rb_impresora)
        Me.gb_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_destino.ForeColor = System.Drawing.Color.Black
        Me.gb_destino.Location = New System.Drawing.Point(12, 49)
        Me.gb_destino.Name = "gb_destino"
        Me.gb_destino.Size = New System.Drawing.Size(188, 91)
        Me.gb_destino.TabIndex = 97
        Me.gb_destino.TabStop = False
        Me.gb_destino.Text = "Destino :"
        '
        'rb_impresora
        '
        Me.rb_impresora.AutoSize = True
        Me.rb_impresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_impresora.Location = New System.Drawing.Point(15, 18)
        Me.rb_impresora.Name = "rb_impresora"
        Me.rb_impresora.Size = New System.Drawing.Size(71, 17)
        Me.rb_impresora.TabIndex = 0
        Me.rb_impresora.TabStop = True
        Me.rb_impresora.Text = "Impresora"
        Me.rb_impresora.UseVisualStyleBackColor = True
        '
        'rb_excel
        '
        Me.rb_excel.AutoSize = True
        Me.rb_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_excel.Location = New System.Drawing.Point(15, 41)
        Me.rb_excel.Name = "rb_excel"
        Me.rb_excel.Size = New System.Drawing.Size(51, 17)
        Me.rb_excel.TabIndex = 1
        Me.rb_excel.TabStop = True
        Me.rb_excel.Text = "Excel"
        Me.rb_excel.UseVisualStyleBackColor = True
        '
        'rb_pdf
        '
        Me.rb_pdf.AutoSize = True
        Me.rb_pdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_pdf.Location = New System.Drawing.Point(15, 64)
        Me.rb_pdf.Name = "rb_pdf"
        Me.rb_pdf.Size = New System.Drawing.Size(41, 17)
        Me.rb_pdf.TabIndex = 2
        Me.rb_pdf.TabStop = True
        Me.rb_pdf.Text = "Pdf"
        Me.rb_pdf.UseVisualStyleBackColor = True
        '
        'bt_imprimir
        '
        Me.bt_imprimir.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(44, 182)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 28)
        Me.bt_imprimir.TabIndex = 98
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(125, 182)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 99
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'chb_vista_previa
        '
        Me.chb_vista_previa.AutoSize = True
        Me.chb_vista_previa.Location = New System.Drawing.Point(57, 150)
        Me.chb_vista_previa.Name = "chb_vista_previa"
        Me.chb_vista_previa.Size = New System.Drawing.Size(96, 17)
        Me.chb_vista_previa.TabIndex = 100
        Me.chb_vista_previa.Text = "Vista preliminar"
        Me.chb_vista_previa.UseVisualStyleBackColor = True
        '
        'form_dialogo_imprimir
        '
        Me.AcceptButton = Me.bt_imprimir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancel
        Me.ClientSize = New System.Drawing.Size(212, 216)
        Me.Controls.Add(Me.chb_vista_previa)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.gb_destino)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_dialogo_imprimir"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diálogo de impresión"
        Me.gb_destino.ResumeLayout(False)
        Me.gb_destino.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gb_destino As System.Windows.Forms.GroupBox
    Friend WithEvents rb_pdf As System.Windows.Forms.RadioButton
    Friend WithEvents rb_excel As System.Windows.Forms.RadioButton
    Friend WithEvents rb_impresora As System.Windows.Forms.RadioButton
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents chb_vista_previa As System.Windows.Forms.CheckBox
End Class
