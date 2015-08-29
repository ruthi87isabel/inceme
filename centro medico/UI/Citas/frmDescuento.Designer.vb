<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescuento
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
        Me.txtPorciento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtCantidad = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.rbPercentual = New System.Windows.Forms.RadioButton()
        Me.rbCantidad = New System.Windows.Forms.RadioButton()
        Me.lblTotalOriginal = New System.Windows.Forms.Label()
        Me.txtImporteOriginal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtResultante = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPorciento
        '
        Me.txtPorciento.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPorciento.Location = New System.Drawing.Point(108, 54)
        Me.txtPorciento.Name = "txtPorciento"
        Me.txtPorciento.Size = New System.Drawing.Size(68, 20)
        Me.txtPorciento.TabIndex = 2
        Me.txtPorciento.Text = "0.00 %"
        Me.txtPorciento.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtCantidad.Location = New System.Drawing.Point(108, 80)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(68, 20)
        Me.txtCantidad.TabIndex = 4
        Me.txtCantidad.Text = "$0.00"
        Me.txtCantidad.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'rbPercentual
        '
        Me.rbPercentual.AutoSize = True
        Me.rbPercentual.Checked = True
        Me.rbPercentual.Location = New System.Drawing.Point(26, 54)
        Me.rbPercentual.Name = "rbPercentual"
        Me.rbPercentual.Size = New System.Drawing.Size(76, 17)
        Me.rbPercentual.TabIndex = 1
        Me.rbPercentual.TabStop = True
        Me.rbPercentual.Text = "Percentual"
        Me.rbPercentual.UseVisualStyleBackColor = True
        '
        'rbCantidad
        '
        Me.rbCantidad.AutoSize = True
        Me.rbCantidad.Location = New System.Drawing.Point(26, 82)
        Me.rbCantidad.Name = "rbCantidad"
        Me.rbCantidad.Size = New System.Drawing.Size(67, 17)
        Me.rbCantidad.TabIndex = 3
        Me.rbCantidad.Text = "Cantidad"
        Me.rbCantidad.UseVisualStyleBackColor = True
        '
        'lblTotalOriginal
        '
        Me.lblTotalOriginal.AutoSize = True
        Me.lblTotalOriginal.Location = New System.Drawing.Point(12, 22)
        Me.lblTotalOriginal.Name = "lblTotalOriginal"
        Me.lblTotalOriginal.Size = New System.Drawing.Size(80, 13)
        Me.lblTotalOriginal.TabIndex = 2
        Me.lblTotalOriginal.Text = "Importe Original"
        '
        'txtImporteOriginal
        '
        Me.txtImporteOriginal.Enabled = False
        Me.txtImporteOriginal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtImporteOriginal.Location = New System.Drawing.Point(108, 19)
        Me.txtImporteOriginal.Name = "txtImporteOriginal"
        Me.txtImporteOriginal.Size = New System.Drawing.Size(68, 20)
        Me.txtImporteOriginal.TabIndex = 0
        Me.txtImporteOriginal.Text = "$0.00"
        Me.txtImporteOriginal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtResultante
        '
        Me.txtResultante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResultante.Enabled = False
        Me.txtResultante.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtResultante.Location = New System.Drawing.Point(108, 116)
        Me.txtResultante.Name = "txtResultante"
        Me.txtResultante.Size = New System.Drawing.Size(68, 20)
        Me.txtResultante.TabIndex = 5
        Me.txtResultante.Text = "$0.00"
        Me.txtResultante.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(41, 119)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(61, 13)
        Me.lblResultado.TabIndex = 3
        Me.lblResultado.Text = "Resultante:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(15, 161)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 28)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(105, 161)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(84, 28)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 201)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblTotalOriginal)
        Me.Controls.Add(Me.rbCantidad)
        Me.Controls.Add(Me.rbPercentual)
        Me.Controls.Add(Me.txtImporteOriginal)
        Me.Controls.Add(Me.txtResultante)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPorciento)
        Me.Name = "frmDescuento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccione Descuento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbPercentual As System.Windows.Forms.RadioButton
    Friend WithEvents rbCantidad As System.Windows.Forms.RadioButton
    Friend WithEvents lblTotalOriginal As System.Windows.Forms.Label
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Public WithEvents txtPorciento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents txtCantidad As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents txtImporteOriginal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents txtResultante As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
