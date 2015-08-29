<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColores
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlRealizado = New System.Windows.Forms.Panel
        Me.pnlPendiente = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlPrimeraVista = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnlPresupuesto = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnlUrgente = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.colorDlg = New System.Windows.Forms.ColorDialog
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Trabajo realizado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlRealizado
        '
        Me.pnlRealizado.BackColor = System.Drawing.Color.Blue
        Me.pnlRealizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRealizado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlRealizado.Location = New System.Drawing.Point(118, 14)
        Me.pnlRealizado.Name = "pnlRealizado"
        Me.pnlRealizado.Size = New System.Drawing.Size(86, 26)
        Me.pnlRealizado.TabIndex = 1
        '
        'pnlPendiente
        '
        Me.pnlPendiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlPendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPendiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlPendiente.Location = New System.Drawing.Point(118, 47)
        Me.pnlPendiente.Name = "pnlPendiente"
        Me.pnlPendiente.Size = New System.Drawing.Size(85, 26)
        Me.pnlPendiente.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Trabajo pendiente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlPrimeraVista
        '
        Me.pnlPrimeraVista.BackColor = System.Drawing.Color.Silver
        Me.pnlPrimeraVista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrimeraVista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlPrimeraVista.Location = New System.Drawing.Point(118, 111)
        Me.pnlPrimeraVista.Name = "pnlPrimeraVista"
        Me.pnlPrimeraVista.Size = New System.Drawing.Size(85, 26)
        Me.pnlPrimeraVista.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Primera visita"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlPresupuesto
        '
        Me.pnlPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPresupuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlPresupuesto.Location = New System.Drawing.Point(118, 79)
        Me.pnlPresupuesto.Name = "pnlPresupuesto"
        Me.pnlPresupuesto.Size = New System.Drawing.Size(85, 26)
        Me.pnlPresupuesto.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Presupuesto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlUrgente
        '
        Me.pnlUrgente.BackColor = System.Drawing.Color.Red
        Me.pnlUrgente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUrgente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlUrgente.Location = New System.Drawing.Point(118, 143)
        Me.pnlUrgente.Name = "pnlUrgente"
        Me.pnlUrgente.Size = New System.Drawing.Size(85, 26)
        Me.pnlUrgente.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 147)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Trabajo urgente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(16, 195)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 28)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(118, 195)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 28)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 240)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.pnlUrgente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pnlPresupuesto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlPrimeraVista)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlPendiente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlRealizado)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmColores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colores del odontograma"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlRealizado As System.Windows.Forms.Panel
    Friend WithEvents pnlPendiente As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlPrimeraVista As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlPresupuesto As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlUrgente As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents colorDlg As System.Windows.Forms.ColorDialog
End Class
