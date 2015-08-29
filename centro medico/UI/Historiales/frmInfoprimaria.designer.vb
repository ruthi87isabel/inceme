<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoprimaria
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
        Me.dtp_IPFecha = New System.Windows.Forms.DateTimePicker()
        Me.INFORMACIONPRIMARIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lb_IPFecha = New System.Windows.Forms.Label()
        Me.lb_IPDescrip = New System.Windows.Forms.Label()
        Me.lb_IPDetalle = New System.Windows.Forms.Label()
        Me.tb_IPDescrip = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_IPDetalle = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_IPAceptar = New System.Windows.Forms.Button()
        Me.bt_IPCancelar = New System.Windows.Forms.Button()
        CType(Me.INFORMACIONPRIMARIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_IPFecha
        '
        Me.dtp_IPFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INFORMACIONPRIMARIABindingSource, "FECHA", True))
        Me.dtp_IPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_IPFecha.Location = New System.Drawing.Point(13, 32)
        Me.dtp_IPFecha.Name = "dtp_IPFecha"
        Me.dtp_IPFecha.Size = New System.Drawing.Size(87, 20)
        Me.dtp_IPFecha.TabIndex = 0
        '
        'INFORMACIONPRIMARIABindingSource
        '
        Me.INFORMACIONPRIMARIABindingSource.DataSource = GetType(centro_medico.INFORMACIONPRIMARIA)
        '
        'lb_IPFecha
        '
        Me.lb_IPFecha.AutoSize = True
        Me.lb_IPFecha.Location = New System.Drawing.Point(10, 12)
        Me.lb_IPFecha.Name = "lb_IPFecha"
        Me.lb_IPFecha.Size = New System.Drawing.Size(37, 13)
        Me.lb_IPFecha.TabIndex = 1
        Me.lb_IPFecha.Text = "Fecha"
        '
        'lb_IPDescrip
        '
        Me.lb_IPDescrip.AutoSize = True
        Me.lb_IPDescrip.Location = New System.Drawing.Point(134, 12)
        Me.lb_IPDescrip.Name = "lb_IPDescrip"
        Me.lb_IPDescrip.Size = New System.Drawing.Size(63, 13)
        Me.lb_IPDescrip.TabIndex = 2
        Me.lb_IPDescrip.Text = "Descripción"
        '
        'lb_IPDetalle
        '
        Me.lb_IPDetalle.AutoSize = True
        Me.lb_IPDetalle.Location = New System.Drawing.Point(10, 65)
        Me.lb_IPDetalle.Name = "lb_IPDetalle"
        Me.lb_IPDetalle.Size = New System.Drawing.Size(40, 13)
        Me.lb_IPDetalle.TabIndex = 3
        Me.lb_IPDetalle.Text = "Detalle"
        '
        'tb_IPDescrip
        '
        Me.tb_IPDescrip.AcceptsReturn = True
        Me.tb_IPDescrip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INFORMACIONPRIMARIABindingSource, "DESCRIPCION", True))
        Me.tb_IPDescrip.Location = New System.Drawing.Point(137, 33)
        Me.tb_IPDescrip.MaxLength = 150
        Me.tb_IPDescrip.Name = "tb_IPDescrip"
        Me.tb_IPDescrip.Size = New System.Drawing.Size(260, 20)
        Me.tb_IPDescrip.TabIndex = 1
        '
        'tb_IPDetalle
        '
        Me.tb_IPDetalle.AcceptsReturn = True
        Me.tb_IPDetalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INFORMACIONPRIMARIABindingSource, "TEXTO", True))
        Me.tb_IPDetalle.Location = New System.Drawing.Point(13, 81)
        Me.tb_IPDetalle.MaxLength = 500
        Me.tb_IPDetalle.Multiline = True
        Me.tb_IPDetalle.Name = "tb_IPDetalle"
        Me.tb_IPDetalle.Size = New System.Drawing.Size(384, 153)
        Me.tb_IPDetalle.TabIndex = 2
        '
        'bt_IPAceptar
        '
        Me.bt_IPAceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_IPAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_IPAceptar.Location = New System.Drawing.Point(241, 246)
        Me.bt_IPAceptar.Name = "bt_IPAceptar"
        Me.bt_IPAceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_IPAceptar.TabIndex = 5
        Me.bt_IPAceptar.Text = "Aceptar"
        Me.bt_IPAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_IPAceptar.UseVisualStyleBackColor = True
        '
        'bt_IPCancelar
        '
        Me.bt_IPCancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_IPCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_IPCancelar.Location = New System.Drawing.Point(322, 246)
        Me.bt_IPCancelar.Name = "bt_IPCancelar"
        Me.bt_IPCancelar.Size = New System.Drawing.Size(75, 28)
        Me.bt_IPCancelar.TabIndex = 4
        Me.bt_IPCancelar.Text = "Cancelar"
        Me.bt_IPCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_IPCancelar.UseVisualStyleBackColor = True
        '
        'frmInfoprimaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 279)
        Me.Controls.Add(Me.bt_IPCancelar)
        Me.Controls.Add(Me.bt_IPAceptar)
        Me.Controls.Add(Me.tb_IPDetalle)
        Me.Controls.Add(Me.tb_IPDescrip)
        Me.Controls.Add(Me.lb_IPDetalle)
        Me.Controls.Add(Me.lb_IPDescrip)
        Me.Controls.Add(Me.lb_IPFecha)
        Me.Controls.Add(Me.dtp_IPFecha)
        Me.Name = "frmInfoprimaria"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Información Primaria"
        CType(Me.INFORMACIONPRIMARIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_IPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_IPFecha As System.Windows.Forms.Label
    Friend WithEvents lb_IPDescrip As System.Windows.Forms.Label
    Friend WithEvents lb_IPDetalle As System.Windows.Forms.Label
    Friend WithEvents tb_IPDescrip As ctrlTextboxAvanzado
    Friend WithEvents tb_IPDetalle As ctrlTextboxAvanzado
    Friend WithEvents bt_IPAceptar As System.Windows.Forms.Button
    Friend WithEvents bt_IPCancelar As System.Windows.Forms.Button
    Friend WithEvents INFORMACIONPRIMARIABindingSource As System.Windows.Forms.BindingSource
End Class
