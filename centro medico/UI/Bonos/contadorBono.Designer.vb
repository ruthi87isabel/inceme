<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contadorBono
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblContador = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btAsociar = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblContador
        '
        Me.lblContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContador.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblContador.Location = New System.Drawing.Point(3, 15)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(241, 25)
        Me.lblContador.TabIndex = 0
        Me.lblContador.Text = "Label1"
        Me.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(4, 41)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(240, 16)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Label1"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblInfo.Visible = False
        '
        'btAsociar
        '
        Me.btAsociar.Location = New System.Drawing.Point(3, 59)
        Me.btAsociar.Name = "btAsociar"
        Me.btAsociar.Size = New System.Drawing.Size(241, 19)
        Me.btAsociar.TabIndex = 2
        Me.btAsociar.Text = "Usar una sesión"
        Me.btAsociar.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(0, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(247, 15)
        Me.lbl.TabIndex = 3
        Me.lbl.Text = "Bonos"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'contadorBono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btAsociar)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblContador)
        Me.Name = "contadorBono"
        Me.Size = New System.Drawing.Size(247, 78)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblContador As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btAsociar As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label

End Class
