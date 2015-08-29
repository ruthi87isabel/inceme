<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRC_EditarResultados
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
        Me.components = New System.ComponentModel.Container()
        Me.tc_Datos = New System.Windows.Forms.TabControl()
        Me.tbEntero = New System.Windows.Forms.TabPage()
        Me.txt_IntegerValue = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTexto = New System.Windows.Forms.TabPage()
        Me.txt_TextValue = New centro_medico.ctrlTextboxAvanzado()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBoolean = New System.Windows.Forms.TabPage()
        Me.rb_No = New System.Windows.Forms.RadioButton()
        Me.rb_Si = New System.Windows.Forms.RadioButton()
        Me.tabOpcionesUnicas = New System.Windows.Forms.TabPage()
        Me.tabOpcionesMultiples = New System.Windows.Forms.TabPage()
        Me.chkListaDeChecks = New System.Windows.Forms.CheckedListBox()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_Aceptar = New System.Windows.Forms.Button()
        Me.chkOcultarImpresionCliente = New System.Windows.Forms.CheckBox()
        Me.lblNombreDato = New System.Windows.Forms.Label()
        Me.lblCaracteresRestantes = New System.Windows.Forms.Label()
        Me.tc_Datos.SuspendLayout()
        Me.tbEntero.SuspendLayout()
        Me.tbTexto.SuspendLayout()
        Me.tbBoolean.SuspendLayout()
        Me.tabOpcionesMultiples.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_Datos
        '
        Me.tc_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_Datos.Controls.Add(Me.tbEntero)
        Me.tc_Datos.Controls.Add(Me.tbTexto)
        Me.tc_Datos.Controls.Add(Me.tbBoolean)
        Me.tc_Datos.Controls.Add(Me.tabOpcionesUnicas)
        Me.tc_Datos.Controls.Add(Me.tabOpcionesMultiples)
        Me.tc_Datos.Location = New System.Drawing.Point(1, 30)
        Me.tc_Datos.Name = "tc_Datos"
        Me.tc_Datos.SelectedIndex = 0
        Me.tc_Datos.Size = New System.Drawing.Size(537, 212)
        Me.tc_Datos.TabIndex = 1
        '
        'tbEntero
        '
        Me.tbEntero.Controls.Add(Me.txt_IntegerValue)
        Me.tbEntero.Controls.Add(Me.Label1)
        Me.tbEntero.Location = New System.Drawing.Point(4, 22)
        Me.tbEntero.Name = "tbEntero"
        Me.tbEntero.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEntero.Size = New System.Drawing.Size(529, 186)
        Me.tbEntero.TabIndex = 0
        Me.tbEntero.Text = "Entero"
        Me.tbEntero.UseVisualStyleBackColor = True
        '
        'txt_IntegerValue
        '
        Me.txt_IntegerValue.FormatString = "N3"
        Me.txt_IntegerValue.Location = New System.Drawing.Point(154, 63)
        Me.txt_IntegerValue.Name = "txt_IntegerValue"
        Me.txt_IntegerValue.Size = New System.Drawing.Size(100, 20)
        Me.txt_IntegerValue.TabIndex = 2
        Me.txt_IntegerValue.Text = "0,000"
        Me.txt_IntegerValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor"
        '
        'tbTexto
        '
        Me.tbTexto.Controls.Add(Me.lblCaracteresRestantes)
        Me.tbTexto.Controls.Add(Me.txt_TextValue)
        Me.tbTexto.Controls.Add(Me.Label2)
        Me.tbTexto.Location = New System.Drawing.Point(4, 22)
        Me.tbTexto.Name = "tbTexto"
        Me.tbTexto.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTexto.Size = New System.Drawing.Size(529, 186)
        Me.tbTexto.TabIndex = 1
        Me.tbTexto.Text = "Texto"
        Me.tbTexto.UseVisualStyleBackColor = True
        '
        'txt_TextValue
        '
        Me.txt_TextValue.AcceptsReturn = True
        Me.txt_TextValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TextValue.Location = New System.Drawing.Point(8, 18)
        Me.txt_TextValue.MaxLength = 999
        Me.txt_TextValue.Multiline = True
        Me.txt_TextValue.Name = "txt_TextValue"
        Me.txt_TextValue.Size = New System.Drawing.Size(513, 149)
        Me.txt_TextValue.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor"
        '
        'tbBoolean
        '
        Me.tbBoolean.Controls.Add(Me.rb_No)
        Me.tbBoolean.Controls.Add(Me.rb_Si)
        Me.tbBoolean.Location = New System.Drawing.Point(4, 22)
        Me.tbBoolean.Name = "tbBoolean"
        Me.tbBoolean.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBoolean.Size = New System.Drawing.Size(529, 186)
        Me.tbBoolean.TabIndex = 2
        Me.tbBoolean.Text = "Verdadero o Falso"
        Me.tbBoolean.UseVisualStyleBackColor = True
        '
        'rb_No
        '
        Me.rb_No.AutoSize = True
        Me.rb_No.Checked = True
        Me.rb_No.Location = New System.Drawing.Point(95, 48)
        Me.rb_No.Name = "rb_No"
        Me.rb_No.Size = New System.Drawing.Size(39, 17)
        Me.rb_No.TabIndex = 2
        Me.rb_No.TabStop = True
        Me.rb_No.Text = "No"
        Me.rb_No.UseVisualStyleBackColor = True
        '
        'rb_Si
        '
        Me.rb_Si.AutoSize = True
        Me.rb_Si.Location = New System.Drawing.Point(41, 48)
        Me.rb_Si.Name = "rb_Si"
        Me.rb_Si.Size = New System.Drawing.Size(36, 17)
        Me.rb_Si.TabIndex = 2
        Me.rb_Si.Text = "Sí"
        Me.rb_Si.UseVisualStyleBackColor = True
        '
        'tabOpcionesUnicas
        '
        Me.tabOpcionesUnicas.Location = New System.Drawing.Point(4, 22)
        Me.tabOpcionesUnicas.Name = "tabOpcionesUnicas"
        Me.tabOpcionesUnicas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOpcionesUnicas.Size = New System.Drawing.Size(529, 186)
        Me.tabOpcionesUnicas.TabIndex = 3
        Me.tabOpcionesUnicas.Text = "Opciones exclusivas"
        Me.tabOpcionesUnicas.UseVisualStyleBackColor = True
        '
        'tabOpcionesMultiples
        '
        Me.tabOpcionesMultiples.Controls.Add(Me.chkListaDeChecks)
        Me.tabOpcionesMultiples.Location = New System.Drawing.Point(4, 22)
        Me.tabOpcionesMultiples.Name = "tabOpcionesMultiples"
        Me.tabOpcionesMultiples.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOpcionesMultiples.Size = New System.Drawing.Size(529, 186)
        Me.tabOpcionesMultiples.TabIndex = 4
        Me.tabOpcionesMultiples.Text = "Opciones múltiples"
        Me.tabOpcionesMultiples.UseVisualStyleBackColor = True
        '
        'chkListaDeChecks
        '
        Me.chkListaDeChecks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkListaDeChecks.CheckOnClick = True
        Me.chkListaDeChecks.FormattingEnabled = True
        Me.chkListaDeChecks.Location = New System.Drawing.Point(7, 16)
        Me.chkListaDeChecks.Name = "chkListaDeChecks"
        Me.chkListaDeChecks.Size = New System.Drawing.Size(516, 139)
        Me.chkListaDeChecks.TabIndex = 0
        '
        'bt_Cancelar
        '
        Me.bt_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Cancelar.Location = New System.Drawing.Point(463, 244)
        Me.bt_Cancelar.Name = "bt_Cancelar"
        Me.bt_Cancelar.Size = New System.Drawing.Size(75, 28)
        Me.bt_Cancelar.TabIndex = 5
        Me.bt_Cancelar.Text = "Cancelar"
        Me.bt_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Cancelar.UseVisualStyleBackColor = True
        '
        'bt_Aceptar
        '
        Me.bt_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Aceptar.Location = New System.Drawing.Point(382, 244)
        Me.bt_Aceptar.Name = "bt_Aceptar"
        Me.bt_Aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_Aceptar.TabIndex = 4
        Me.bt_Aceptar.Text = "Aceptar"
        Me.bt_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Aceptar.UseVisualStyleBackColor = True
        '
        'chkOcultarImpresionCliente
        '
        Me.chkOcultarImpresionCliente.AutoSize = True
        Me.chkOcultarImpresionCliente.Location = New System.Drawing.Point(5, 249)
        Me.chkOcultarImpresionCliente.Name = "chkOcultarImpresionCliente"
        Me.chkOcultarImpresionCliente.Size = New System.Drawing.Size(174, 17)
        Me.chkOcultarImpresionCliente.TabIndex = 6
        Me.chkOcultarImpresionCliente.Text = "Ocultar en el informe del cliente"
        Me.chkOcultarImpresionCliente.UseVisualStyleBackColor = True
        '
        'lblNombreDato
        '
        Me.lblNombreDato.AutoSize = True
        Me.lblNombreDato.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNombreDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDato.Location = New System.Drawing.Point(1, 11)
        Me.lblNombreDato.Name = "lblNombreDato"
        Me.lblNombreDato.Size = New System.Drawing.Size(19, 13)
        Me.lblNombreDato.TabIndex = 7
        Me.lblNombreDato.Text = "..."
        '
        'lblCaracteresRestantes
        '
        Me.lblCaracteresRestantes.AutoSize = True
        Me.lblCaracteresRestantes.Location = New System.Drawing.Point(7, 170)
        Me.lblCaracteresRestantes.Name = "lblCaracteresRestantes"
        Me.lblCaracteresRestantes.Size = New System.Drawing.Size(13, 13)
        Me.lblCaracteresRestantes.TabIndex = 3
        Me.lblCaracteresRestantes.Text = "0"
        '
        'frmRC_EditarResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 272)
        Me.Controls.Add(Me.lblNombreDato)
        Me.Controls.Add(Me.chkOcultarImpresionCliente)
        Me.Controls.Add(Me.bt_Cancelar)
        Me.Controls.Add(Me.bt_Aceptar)
        Me.Controls.Add(Me.tc_Datos)
        Me.Name = "frmRC_EditarResultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Resultado"
        Me.tc_Datos.ResumeLayout(False)
        Me.tbEntero.ResumeLayout(False)
        Me.tbEntero.PerformLayout()
        Me.tbTexto.ResumeLayout(False)
        Me.tbTexto.PerformLayout()
        Me.tbBoolean.ResumeLayout(False)
        Me.tbBoolean.PerformLayout()
        Me.tabOpcionesMultiples.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_Datos As System.Windows.Forms.TabControl
    Friend WithEvents tbEntero As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbTexto As System.Windows.Forms.TabPage
    Friend WithEvents tbBoolean As System.Windows.Forms.TabPage
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_Aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_TextValue As ctrlTextboxAvanzado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rb_No As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Si As System.Windows.Forms.RadioButton
    Friend WithEvents txt_IntegerValue As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents tabOpcionesUnicas As System.Windows.Forms.TabPage
    Friend WithEvents tabOpcionesMultiples As System.Windows.Forms.TabPage
    Friend WithEvents chkListaDeChecks As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkOcultarImpresionCliente As System.Windows.Forms.CheckBox
    Friend WithEvents lblNombreDato As System.Windows.Forms.Label
    Friend WithEvents lblCaracteresRestantes As System.Windows.Forms.Label
End Class
