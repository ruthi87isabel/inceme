<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileExists
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
        Me.lblMsg = New System.Windows.Forms.Label
        Me.rbManual = New System.Windows.Forms.RadioButton
        Me.txtNuevoNombre = New System.Windows.Forms.TextBox
        Me.rbAutomatico = New System.Windows.Forms.RadioButton
        Me.rbSobrescribir = New System.Windows.Forms.RadioButton
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.txtGenerado = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(23, 9)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(524, 26)
        Me.lblMsg.TabIndex = 0
        Me.lblMsg.Text = "ATENCION: El fichero ""tal.doc"" existe o está en uso, ¿que desea hacer?"
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.Checked = True
        Me.rbManual.Location = New System.Drawing.Point(42, 39)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(154, 17)
        Me.rbManual.TabIndex = 1
        Me.rbManual.TabStop = True
        Me.rbManual.Text = "Renombrarlo manualmente:"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'txtNuevoNombre
        '
        Me.txtNuevoNombre.Location = New System.Drawing.Point(218, 38)
        Me.txtNuevoNombre.Name = "txtNuevoNombre"
        Me.txtNuevoNombre.Size = New System.Drawing.Size(262, 20)
        Me.txtNuevoNombre.TabIndex = 2
        '
        'rbAutomatico
        '
        Me.rbAutomatico.AutoSize = True
        Me.rbAutomatico.Location = New System.Drawing.Point(42, 65)
        Me.rbAutomatico.Name = "rbAutomatico"
        Me.rbAutomatico.Size = New System.Drawing.Size(169, 17)
        Me.rbAutomatico.TabIndex = 1
        Me.rbAutomatico.Text = "Renombrarlo automaticamente"
        Me.rbAutomatico.UseVisualStyleBackColor = True
        '
        'rbSobrescribir
        '
        Me.rbSobrescribir.AutoSize = True
        Me.rbSobrescribir.Location = New System.Drawing.Point(42, 88)
        Me.rbSobrescribir.Name = "rbSobrescribir"
        Me.rbSobrescribir.Size = New System.Drawing.Size(179, 17)
        Me.rbSobrescribir.TabIndex = 1
        Me.rbSobrescribir.Text = "Sobrescribirlo (No recomendado)"
        Me.rbSobrescribir.UseVisualStyleBackColor = True
        Me.rbSobrescribir.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(42, 111)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtGenerado
        '
        Me.txtGenerado.Location = New System.Drawing.Point(218, 62)
        Me.txtGenerado.Name = "txtGenerado"
        Me.txtGenerado.ReadOnly = True
        Me.txtGenerado.Size = New System.Drawing.Size(329, 20)
        Me.txtGenerado.TabIndex = 2
        '
        'frmFileExists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 140)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtGenerado)
        Me.Controls.Add(Me.txtNuevoNombre)
        Me.Controls.Add(Me.rbSobrescribir)
        Me.Controls.Add(Me.rbAutomatico)
        Me.Controls.Add(Me.rbManual)
        Me.Controls.Add(Me.lblMsg)
        Me.Name = "frmFileExists"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Advertencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents rbManual As System.Windows.Forms.RadioButton
    Friend WithEvents rbAutomatico As System.Windows.Forms.RadioButton
    Friend WithEvents rbSobrescribir As System.Windows.Forms.RadioButton
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Public WithEvents txtNuevoNombre As System.Windows.Forms.TextBox
    Public WithEvents txtGenerado As System.Windows.Forms.TextBox
End Class
