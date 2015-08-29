<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicos_Ficheros_ADD
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
        Me.bt_FiCancelar = New System.Windows.Forms.Button()
        Me.bt_FiAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_FiBuscar = New System.Windows.Forms.Button()
        Me.dtp_FiUltimamodificacion = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FiFechacreacion = New System.Windows.Forms.DateTimePicker()
        Me.lb_FiDescripcion = New System.Windows.Forms.Label()
        Me.lb_FiFechacreacion = New System.Windows.Forms.Label()
        Me.lb_FiUltimamodificacion = New System.Windows.Forms.Label()
        Me.lb_FiNombre = New System.Windows.Forms.Label()
        Me.MEDICOSFICHEROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_FiNombre = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_FiNotas = New centro_medico.ctrlTextboxAvanzado()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MEDICOSFICHEROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_FiCancelar
        '
        Me.bt_FiCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_FiCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_FiCancelar.Location = New System.Drawing.Point(425, 335)
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
        Me.bt_FiAceptar.Location = New System.Drawing.Point(323, 335)
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
        Me.GroupBox1.Controls.Add(Me.bt_FiBuscar)
        Me.GroupBox1.Controls.Add(Me.tb_FiNombre)
        Me.GroupBox1.Controls.Add(Me.dtp_FiUltimamodificacion)
        Me.GroupBox1.Controls.Add(Me.dtp_FiFechacreacion)
        Me.GroupBox1.Controls.Add(Me.tb_FiNotas)
        Me.GroupBox1.Controls.Add(Me.lb_FiDescripcion)
        Me.GroupBox1.Controls.Add(Me.lb_FiFechacreacion)
        Me.GroupBox1.Controls.Add(Me.lb_FiUltimamodificacion)
        Me.GroupBox1.Controls.Add(Me.lb_FiNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 327)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'bt_FiBuscar
        '
        Me.bt_FiBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_FiBuscar.Location = New System.Drawing.Point(312, 46)
        Me.bt_FiBuscar.Name = "bt_FiBuscar"
        Me.bt_FiBuscar.Size = New System.Drawing.Size(67, 21)
        Me.bt_FiBuscar.TabIndex = 0
        Me.bt_FiBuscar.Text = "Buscar"
        Me.bt_FiBuscar.UseVisualStyleBackColor = True
        '
        'dtp_FiUltimamodificacion
        '
        Me.dtp_FiUltimamodificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_FiUltimamodificacion.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_FiUltimamodificacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MEDICOSFICHEROBindingSource, "FechaModificado", True))
        Me.dtp_FiUltimamodificacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FiUltimamodificacion.Location = New System.Drawing.Point(410, 81)
        Me.dtp_FiUltimamodificacion.Name = "dtp_FiUltimamodificacion"
        Me.dtp_FiUltimamodificacion.Size = New System.Drawing.Size(102, 20)
        Me.dtp_FiUltimamodificacion.TabIndex = 2
        '
        'dtp_FiFechacreacion
        '
        Me.dtp_FiFechacreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_FiFechacreacion.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_FiFechacreacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MEDICOSFICHEROBindingSource, "FechaSubido", True))
        Me.dtp_FiFechacreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FiFechacreacion.Location = New System.Drawing.Point(410, 31)
        Me.dtp_FiFechacreacion.Name = "dtp_FiFechacreacion"
        Me.dtp_FiFechacreacion.Size = New System.Drawing.Size(102, 20)
        Me.dtp_FiFechacreacion.TabIndex = 1
        '
        'lb_FiDescripcion
        '
        Me.lb_FiDescripcion.AutoSize = True
        Me.lb_FiDescripcion.Location = New System.Drawing.Point(14, 88)
        Me.lb_FiDescripcion.Name = "lb_FiDescripcion"
        Me.lb_FiDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lb_FiDescripcion.TabIndex = 0
        Me.lb_FiDescripcion.Text = "Descripción"
        '
        'lb_FiFechacreacion
        '
        Me.lb_FiFechacreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_FiFechacreacion.AutoSize = True
        Me.lb_FiFechacreacion.Location = New System.Drawing.Point(407, 16)
        Me.lb_FiFechacreacion.Name = "lb_FiFechacreacion"
        Me.lb_FiFechacreacion.Size = New System.Drawing.Size(97, 13)
        Me.lb_FiFechacreacion.TabIndex = 1
        Me.lb_FiFechacreacion.Text = "Fecha de Creación"
        '
        'lb_FiUltimamodificacion
        '
        Me.lb_FiUltimamodificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_FiUltimamodificacion.AutoSize = True
        Me.lb_FiUltimamodificacion.Location = New System.Drawing.Point(407, 65)
        Me.lb_FiUltimamodificacion.Name = "lb_FiUltimamodificacion"
        Me.lb_FiUltimamodificacion.Size = New System.Drawing.Size(99, 13)
        Me.lb_FiUltimamodificacion.TabIndex = 3
        Me.lb_FiUltimamodificacion.Text = "Ultima Modificación"
        '
        'lb_FiNombre
        '
        Me.lb_FiNombre.AutoSize = True
        Me.lb_FiNombre.Location = New System.Drawing.Point(15, 31)
        Me.lb_FiNombre.Name = "lb_FiNombre"
        Me.lb_FiNombre.Size = New System.Drawing.Size(99, 13)
        Me.lb_FiNombre.TabIndex = 2
        Me.lb_FiNombre.Text = "Nombre del Fichero"
        '
        'MEDICOSFICHEROBindingSource
        '
        Me.MEDICOSFICHEROBindingSource.DataSource = GetType(centro_medico.MEDICOS_FICHERO)
        '
        'tb_FiNombre
        '
        Me.tb_FiNombre.AcceptsReturn = True
        Me.tb_FiNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_FiNombre.BackColor = System.Drawing.Color.White
        Me.tb_FiNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSFICHEROBindingSource, "NombreFichero", True))
        Me.tb_FiNombre.Location = New System.Drawing.Point(18, 47)
        Me.tb_FiNombre.Name = "tb_FiNombre"
        Me.tb_FiNombre.ReadOnly = True
        Me.tb_FiNombre.Size = New System.Drawing.Size(288, 20)
        Me.tb_FiNombre.TabIndex = 0
        Me.tb_FiNombre.TabStop = False
        '
        'tb_FiNotas
        '
        Me.tb_FiNotas.AcceptsReturn = True
        Me.tb_FiNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_FiNotas.BackColor = System.Drawing.Color.White
        Me.tb_FiNotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSFICHEROBindingSource, "Descripcion", True))
        Me.tb_FiNotas.Location = New System.Drawing.Point(17, 107)
        Me.tb_FiNotas.Multiline = True
        Me.tb_FiNotas.Name = "tb_FiNotas"
        Me.tb_FiNotas.Size = New System.Drawing.Size(495, 209)
        Me.tb_FiNotas.TabIndex = 3
        '
        'frmMedicos_Ficheros_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 365)
        Me.Controls.Add(Me.bt_FiCancelar)
        Me.Controls.Add(Me.bt_FiAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMedicos_Ficheros_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Fichero Médico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MEDICOSFICHEROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_FiCancelar As System.Windows.Forms.Button
    Friend WithEvents bt_FiAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_FiBuscar As System.Windows.Forms.Button
    Friend WithEvents tb_FiNombre As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents dtp_FiUltimamodificacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FiFechacreacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_FiNotas As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents lb_FiDescripcion As System.Windows.Forms.Label
    Friend WithEvents lb_FiFechacreacion As System.Windows.Forms.Label
    Friend WithEvents lb_FiUltimamodificacion As System.Windows.Forms.Label
    Friend WithEvents lb_FiNombre As System.Windows.Forms.Label
    Public WithEvents MEDICOSFICHEROBindingSource As System.Windows.Forms.BindingSource
End Class
