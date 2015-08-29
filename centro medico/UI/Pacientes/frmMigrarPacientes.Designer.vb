<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMigrarPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMigrarPacientes))
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CtrlPaciente2 = New centro_medico.ctrlPaciente()
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.chkEliminarPaciente = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(17, 188)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 2
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Origen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Destino"
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(349, 188)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 9
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(14, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 41)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'CtrlPaciente2
        '
        Me.CtrlPaciente2.ID_PACIENTE = Nothing
        Me.CtrlPaciente2.Location = New System.Drawing.Point(17, 114)
        Me.CtrlPaciente2.Name = "CtrlPaciente2"
        Me.CtrlPaciente2.Size = New System.Drawing.Size(407, 61)
        Me.CtrlPaciente2.TabIndex = 6
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(17, 37)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(407, 61)
        Me.CtrlPaciente1.TabIndex = 5
        '
        'chkEliminarPaciente
        '
        Me.chkEliminarPaciente.AutoSize = True
        Me.chkEliminarPaciente.Location = New System.Drawing.Point(142, 192)
        Me.chkEliminarPaciente.Name = "chkEliminarPaciente"
        Me.chkEliminarPaciente.Size = New System.Drawing.Size(136, 17)
        Me.chkEliminarPaciente.TabIndex = 11
        Me.chkEliminarPaciente.Text = "Dar de baja el paciente"
        Me.chkEliminarPaciente.UseVisualStyleBackColor = True
        '
        'frmMigrarPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkEliminarPaciente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CtrlPaciente2)
        Me.Controls.Add(Me.CtrlPaciente1)
        Me.Controls.Add(Me.btAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMigrarPacientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente para migrar pacientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents CtrlPaciente2 As centro_medico.ctrlPaciente
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkEliminarPaciente As System.Windows.Forms.CheckBox
End Class
