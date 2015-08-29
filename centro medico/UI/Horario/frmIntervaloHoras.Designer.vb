<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntervaloHoras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.txtHoraIni = New System.Windows.Forms.MaskedTextBox()
        Me.txtHoraFin = New System.Windows.Forms.MaskedTextBox()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inicio"
        '
        'lblHoraFin
        '
        Me.lblHoraFin.AutoSize = True
        Me.lblHoraFin.Location = New System.Drawing.Point(172, 15)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(21, 13)
        Me.lblHoraFin.TabIndex = 3
        Me.lblHoraFin.Text = "Fin"
        '
        'txtHoraIni
        '
        Me.txtHoraIni.Location = New System.Drawing.Point(55, 12)
        Me.txtHoraIni.Mask = "00:00"
        Me.txtHoraIni.Name = "txtHoraIni"
        Me.txtHoraIni.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraIni.TabIndex = 4
        Me.txtHoraIni.ValidatingType = GetType(Date)
        '
        'txtHoraFin
        '
        Me.txtHoraFin.Location = New System.Drawing.Point(199, 12)
        Me.txtHoraFin.Mask = "00:00"
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.Size = New System.Drawing.Size(97, 20)
        Me.txtHoraFin.TabIndex = 5
        Me.txtHoraFin.ValidatingType = GetType(Date)
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(65, 58)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 6
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(199, 58)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 7
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'frmIntervaloHoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 93)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.txtHoraFin)
        Me.Controls.Add(Me.txtHoraIni)
        Me.Controls.Add(Me.lblHoraFin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIntervaloHoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Indique la hora inicial y final"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHoraFin As System.Windows.Forms.Label
    Friend WithEvents txtHoraIni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtHoraFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button
End Class
