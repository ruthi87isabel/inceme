<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectionDB
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnectionDB))
        Me.lblServidor = New System.Windows.Forms.Label()
        Me.lblBD = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.txtBD = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.ConexionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ConexionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblServidor
        '
        Me.lblServidor.AutoSize = True
        Me.lblServidor.Location = New System.Drawing.Point(24, 18)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(46, 13)
        Me.lblServidor.TabIndex = 0
        Me.lblServidor.Text = "Servidor"
        '
        'lblBD
        '
        Me.lblBD.AutoSize = True
        Me.lblBD.Location = New System.Drawing.Point(24, 39)
        Me.lblBD.Name = "lblBD"
        Me.lblBD.Size = New System.Drawing.Size(77, 13)
        Me.lblBD.TabIndex = 1
        Me.lblBD.Text = "Base de Datos"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(24, 60)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Usuario"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(24, 81)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Contraseña"
        '
        'txtServidor
        '
        Me.txtServidor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConexionBindingSource, "servidor", True))
        Me.txtServidor.Location = New System.Drawing.Point(116, 9)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(174, 20)
        Me.txtServidor.TabIndex = 4
        '
        'txtBD
        '
        Me.txtBD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConexionBindingSource, "basededatos", True))
        Me.txtBD.Location = New System.Drawing.Point(116, 33)
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(174, 20)
        Me.txtBD.TabIndex = 5
        '
        'txtUsuario
        '
        Me.txtUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConexionBindingSource, "usuario", True))
        Me.txtUsuario.Location = New System.Drawing.Point(116, 57)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(174, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'txtPass
        '
        Me.txtPass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConexionBindingSource, "clave", True))
        Me.txtPass.Location = New System.Drawing.Point(116, 81)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(174, 20)
        Me.txtPass.TabIndex = 7
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(26, 118)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 8
        Me.btAceptar.Text = "Guardar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(215, 118)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 9
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'ConexionBindingSource
        '
        Me.ConexionBindingSource.DataSource = GetType(centro_medico.conexion)
        '
        'frmConnectionDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 153)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtBD)
        Me.Controls.Add(Me.txtServidor)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblBD)
        Me.Controls.Add(Me.lblServidor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConnectionDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Base de Datos"
        CType(Me.ConexionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblServidor As System.Windows.Forms.Label
    Friend WithEvents lblBD As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtServidor As System.Windows.Forms.TextBox
    Friend WithEvents txtBD As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents ConexionBindingSource As System.Windows.Forms.BindingSource
End Class
