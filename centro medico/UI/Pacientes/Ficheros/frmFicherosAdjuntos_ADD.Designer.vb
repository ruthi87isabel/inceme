<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFicherosAdjuntos_ADD
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFicherosAdjuntos_ADD))
        Me.bt_FiCancelar = New System.Windows.Forms.Button()
        Me.bt_FiAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPathOriginalFIchero = New System.Windows.Forms.Label()
        Me.bt_FiBuscar = New System.Windows.Forms.Button()
        Me.tb_FiNombre = New centro_medico.ctrlTextboxAvanzado()
        Me.FICHEROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtp_FiUltimamodificacion = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FiFechacreacion = New System.Windows.Forms.DateTimePicker()
        Me.tb_FiNotas = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_FiDescripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.lb_FiDescripcion = New System.Windows.Forms.Label()
        Me.lb_FiNotas = New System.Windows.Forms.Label()
        Me.lb_FiFechacreacion = New System.Windows.Forms.Label()
        Me.lb_FiUltimamodificacion = New System.Windows.Forms.Label()
        Me.lb_FiNombre = New System.Windows.Forms.Label()
        Me.chkConsentimiento = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FICHEROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_FiCancelar
        '
        Me.bt_FiCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_FiCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_FiCancelar.Location = New System.Drawing.Point(379, 284)
        Me.bt_FiCancelar.Name = "bt_FiCancelar"
        Me.bt_FiCancelar.Size = New System.Drawing.Size(89, 27)
        Me.bt_FiCancelar.TabIndex = 5
        Me.bt_FiCancelar.Text = "Cancelar    "
        Me.bt_FiCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_FiCancelar.UseVisualStyleBackColor = True
        '
        'bt_FiAceptar
        '
        Me.bt_FiAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_FiAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_FiAceptar.Location = New System.Drawing.Point(277, 284)
        Me.bt_FiAceptar.Name = "bt_FiAceptar"
        Me.bt_FiAceptar.Size = New System.Drawing.Size(96, 27)
        Me.bt_FiAceptar.TabIndex = 4
        Me.bt_FiAceptar.Text = "Aceptar     "
        Me.bt_FiAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_FiAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.chkConsentimiento)
        Me.GroupBox1.Controls.Add(Me.lblPathOriginalFIchero)
        Me.GroupBox1.Controls.Add(Me.bt_FiBuscar)
        Me.GroupBox1.Controls.Add(Me.tb_FiNombre)
        Me.GroupBox1.Controls.Add(Me.dtp_FiUltimamodificacion)
        Me.GroupBox1.Controls.Add(Me.dtp_FiFechacreacion)
        Me.GroupBox1.Controls.Add(Me.tb_FiNotas)
        Me.GroupBox1.Controls.Add(Me.tb_FiDescripcion)
        Me.GroupBox1.Controls.Add(Me.lb_FiDescripcion)
        Me.GroupBox1.Controls.Add(Me.lb_FiNotas)
        Me.GroupBox1.Controls.Add(Me.lb_FiFechacreacion)
        Me.GroupBox1.Controls.Add(Me.lb_FiUltimamodificacion)
        Me.GroupBox1.Controls.Add(Me.lb_FiNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 280)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'lblPathOriginalFIchero
        '
        Me.lblPathOriginalFIchero.AutoSize = True
        Me.lblPathOriginalFIchero.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPathOriginalFIchero.ForeColor = System.Drawing.Color.Gray
        Me.lblPathOriginalFIchero.Location = New System.Drawing.Point(10, 103)
        Me.lblPathOriginalFIchero.Name = "lblPathOriginalFIchero"
        Me.lblPathOriginalFIchero.Size = New System.Drawing.Size(116, 13)
        Me.lblPathOriginalFIchero.TabIndex = 11
        Me.lblPathOriginalFIchero.Text = "Ruta original del fichero"
        Me.lblPathOriginalFIchero.Visible = False
        '
        'bt_FiBuscar
        '
        Me.bt_FiBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_FiBuscar.Location = New System.Drawing.Point(314, 81)
        Me.bt_FiBuscar.Name = "bt_FiBuscar"
        Me.bt_FiBuscar.Size = New System.Drawing.Size(25, 20)
        Me.bt_FiBuscar.TabIndex = 10
        Me.bt_FiBuscar.Text = "Button1"
        Me.bt_FiBuscar.UseVisualStyleBackColor = True
        '
        'tb_FiNombre
        '
        Me.tb_FiNombre.AcceptsReturn = True
        Me.tb_FiNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_FiNombre.BackColor = System.Drawing.Color.White
        Me.tb_FiNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FICHEROBindingSource, "FICHERO", True))
        Me.tb_FiNombre.Location = New System.Drawing.Point(12, 81)
        Me.tb_FiNombre.Name = "tb_FiNombre"
        Me.tb_FiNombre.ReadOnly = True
        Me.tb_FiNombre.Size = New System.Drawing.Size(302, 20)
        Me.tb_FiNombre.TabIndex = 1
        '
        'FICHEROBindingSource
        '
        Me.FICHEROBindingSource.DataSource = GetType(centro_medico.FICHERO)
        '
        'dtp_FiUltimamodificacion
        '
        Me.dtp_FiUltimamodificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_FiUltimamodificacion.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_FiUltimamodificacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FICHEROBindingSource, "FECHAMODIFICACION", True))
        Me.dtp_FiUltimamodificacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FiUltimamodificacion.Location = New System.Drawing.Point(349, 81)
        Me.dtp_FiUltimamodificacion.Name = "dtp_FiUltimamodificacion"
        Me.dtp_FiUltimamodificacion.Size = New System.Drawing.Size(102, 20)
        Me.dtp_FiUltimamodificacion.TabIndex = 2
        '
        'dtp_FiFechacreacion
        '
        Me.dtp_FiFechacreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_FiFechacreacion.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_FiFechacreacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FICHEROBindingSource, "FECHA", True))
        Me.dtp_FiFechacreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FiFechacreacion.Location = New System.Drawing.Point(349, 31)
        Me.dtp_FiFechacreacion.Name = "dtp_FiFechacreacion"
        Me.dtp_FiFechacreacion.Size = New System.Drawing.Size(102, 20)
        Me.dtp_FiFechacreacion.TabIndex = 2
        '
        'tb_FiNotas
        '
        Me.tb_FiNotas.AcceptsReturn = True
        Me.tb_FiNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_FiNotas.BackColor = System.Drawing.Color.White
        Me.tb_FiNotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FICHEROBindingSource, "NOTAS", True))
        Me.tb_FiNotas.Location = New System.Drawing.Point(12, 144)
        Me.tb_FiNotas.Multiline = True
        Me.tb_FiNotas.Name = "tb_FiNotas"
        Me.tb_FiNotas.Size = New System.Drawing.Size(439, 125)
        Me.tb_FiNotas.TabIndex = 3
        '
        'tb_FiDescripcion
        '
        Me.tb_FiDescripcion.AcceptsReturn = True
        Me.tb_FiDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_FiDescripcion.BackColor = System.Drawing.Color.White
        Me.tb_FiDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FICHEROBindingSource, "DESCRIPCION", True))
        Me.tb_FiDescripcion.Location = New System.Drawing.Point(11, 32)
        Me.tb_FiDescripcion.Name = "tb_FiDescripcion"
        Me.tb_FiDescripcion.Size = New System.Drawing.Size(324, 20)
        Me.tb_FiDescripcion.TabIndex = 1
        '
        'lb_FiDescripcion
        '
        Me.lb_FiDescripcion.AutoSize = True
        Me.lb_FiDescripcion.Location = New System.Drawing.Point(9, 16)
        Me.lb_FiDescripcion.Name = "lb_FiDescripcion"
        Me.lb_FiDescripcion.Size = New System.Drawing.Size(118, 13)
        Me.lb_FiDescripcion.TabIndex = 0
        Me.lb_FiDescripcion.Text = "Descripción del Fichero"
        '
        'lb_FiNotas
        '
        Me.lb_FiNotas.AutoSize = True
        Me.lb_FiNotas.Location = New System.Drawing.Point(8, 128)
        Me.lb_FiNotas.Name = "lb_FiNotas"
        Me.lb_FiNotas.Size = New System.Drawing.Size(35, 13)
        Me.lb_FiNotas.TabIndex = 4
        Me.lb_FiNotas.Text = "Notas"
        '
        'lb_FiFechacreacion
        '
        Me.lb_FiFechacreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_FiFechacreacion.AutoSize = True
        Me.lb_FiFechacreacion.Location = New System.Drawing.Point(346, 16)
        Me.lb_FiFechacreacion.Name = "lb_FiFechacreacion"
        Me.lb_FiFechacreacion.Size = New System.Drawing.Size(97, 13)
        Me.lb_FiFechacreacion.TabIndex = 1
        Me.lb_FiFechacreacion.Text = "Fecha de Creación"
        '
        'lb_FiUltimamodificacion
        '
        Me.lb_FiUltimamodificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_FiUltimamodificacion.AutoSize = True
        Me.lb_FiUltimamodificacion.Location = New System.Drawing.Point(346, 65)
        Me.lb_FiUltimamodificacion.Name = "lb_FiUltimamodificacion"
        Me.lb_FiUltimamodificacion.Size = New System.Drawing.Size(99, 13)
        Me.lb_FiUltimamodificacion.TabIndex = 3
        Me.lb_FiUltimamodificacion.Text = "Ultima Modificación"
        '
        'lb_FiNombre
        '
        Me.lb_FiNombre.AutoSize = True
        Me.lb_FiNombre.Location = New System.Drawing.Point(9, 65)
        Me.lb_FiNombre.Name = "lb_FiNombre"
        Me.lb_FiNombre.Size = New System.Drawing.Size(99, 13)
        Me.lb_FiNombre.TabIndex = 2
        Me.lb_FiNombre.Text = "Nombre del Fichero"
        '
        'chkConsentimiento
        '
        Me.chkConsentimiento.AutoSize = True
        Me.chkConsentimiento.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FICHEROBindingSource, "ESCONSENTIMIENTO", True))
        Me.chkConsentimiento.Location = New System.Drawing.Point(280, 121)
        Me.chkConsentimiento.Name = "chkConsentimiento"
        Me.chkConsentimiento.Size = New System.Drawing.Size(171, 17)
        Me.chkConsentimiento.TabIndex = 12
        Me.chkConsentimiento.Text = "Documento de Consentimiento"
        Me.chkConsentimiento.UseVisualStyleBackColor = True
        '
        'frmFicherosAdjuntos_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 314)
        Me.Controls.Add(Me.bt_FiCancelar)
        Me.Controls.Add(Me.bt_FiAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFicherosAdjuntos_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar fichero"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FICHEROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_FiCancelar As System.Windows.Forms.Button
    Friend WithEvents bt_FiAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPathOriginalFIchero As System.Windows.Forms.Label
    Friend WithEvents bt_FiBuscar As System.Windows.Forms.Button
    Friend WithEvents tb_FiNombre As ctrlTextboxAvanzado
    Friend WithEvents dtp_FiUltimamodificacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FiFechacreacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_FiNotas As ctrlTextboxAvanzado
    Friend WithEvents tb_FiDescripcion As ctrlTextboxAvanzado
    Friend WithEvents lb_FiDescripcion As System.Windows.Forms.Label
    Friend WithEvents lb_FiNotas As System.Windows.Forms.Label
    Friend WithEvents lb_FiFechacreacion As System.Windows.Forms.Label
    Friend WithEvents lb_FiUltimamodificacion As System.Windows.Forms.Label
    Friend WithEvents lb_FiNombre As System.Windows.Forms.Label
    Friend WithEvents FICHEROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents chkConsentimiento As System.Windows.Forms.CheckBox
End Class
