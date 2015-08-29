<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pac_ficheros_multimedias
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
        Me.components = New System.ComponentModel.Container
        Me.lb_FiDescripcion = New System.Windows.Forms.Label
        Me.lb_FiFechacreacion = New System.Windows.Forms.Label
        Me.lb_FiNombre = New System.Windows.Forms.Label
        Me.lb_FiUltimamodificacion = New System.Windows.Forms.Label
        Me.lb_FiNotas = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bt_FiBuscar = New System.Windows.Forms.Button
        Me.tb_FiNombre = New ctrlTextboxAvanzado
        Me.dtp_FiUltimamodificacion = New System.Windows.Forms.DateTimePicker
        Me.dtp_FiFechacreacion = New System.Windows.Forms.DateTimePicker
        Me.tb_FiNotas = New ctrlTextboxAvanzado
        Me.tb_FiDescripcion = New ctrlTextboxAvanzado
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.FICHEROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FICHEROSTableAdapter = New centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
        Me.bt_FiCancelar = New System.Windows.Forms.Button
        Me.bt_FiAceptar = New System.Windows.Forms.Button
        Me.lblPathOriginalFIchero = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FICHEROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lb_FiFechacreacion
        '
        Me.lb_FiFechacreacion.AutoSize = True
        Me.lb_FiFechacreacion.Location = New System.Drawing.Point(295, 16)
        Me.lb_FiFechacreacion.Name = "lb_FiFechacreacion"
        Me.lb_FiFechacreacion.Size = New System.Drawing.Size(97, 13)
        Me.lb_FiFechacreacion.TabIndex = 1
        Me.lb_FiFechacreacion.Text = "Fecha de Creación"
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
        'lb_FiUltimamodificacion
        '
        Me.lb_FiUltimamodificacion.AutoSize = True
        Me.lb_FiUltimamodificacion.Location = New System.Drawing.Point(295, 65)
        Me.lb_FiUltimamodificacion.Name = "lb_FiUltimamodificacion"
        Me.lb_FiUltimamodificacion.Size = New System.Drawing.Size(99, 13)
        Me.lb_FiUltimamodificacion.TabIndex = 3
        Me.lb_FiUltimamodificacion.Text = "Ultima Modificación"
        '
        'lb_FiNotas
        '
        Me.lb_FiNotas.AutoSize = True
        Me.lb_FiNotas.Location = New System.Drawing.Point(9, 116)
        Me.lb_FiNotas.Name = "lb_FiNotas"
        Me.lb_FiNotas.Size = New System.Drawing.Size(35, 13)
        Me.lb_FiNotas.TabIndex = 4
        Me.lb_FiNotas.Text = "Notas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
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
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'bt_FiBuscar
        '
        Me.bt_FiBuscar.Location = New System.Drawing.Point(263, 81)
        Me.bt_FiBuscar.Name = "bt_FiBuscar"
        Me.bt_FiBuscar.Size = New System.Drawing.Size(25, 20)
        Me.bt_FiBuscar.TabIndex = 10
        Me.bt_FiBuscar.Text = "Button1"
        Me.bt_FiBuscar.UseVisualStyleBackColor = True
        '
        'tb_FiNombre
        '
        Me.tb_FiNombre.BackColor = System.Drawing.Color.White
        Me.tb_FiNombre.Location = New System.Drawing.Point(12, 81)
        Me.tb_FiNombre.Name = "tb_FiNombre"
        Me.tb_FiNombre.ReadOnly = True
        Me.tb_FiNombre.Size = New System.Drawing.Size(251, 20)
        Me.tb_FiNombre.TabIndex = 1
        '
        'dtp_FiUltimamodificacion
        '
        Me.dtp_FiUltimamodificacion.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_FiUltimamodificacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FiUltimamodificacion.Location = New System.Drawing.Point(298, 81)
        Me.dtp_FiUltimamodificacion.Name = "dtp_FiUltimamodificacion"
        Me.dtp_FiUltimamodificacion.Size = New System.Drawing.Size(102, 20)
        Me.dtp_FiUltimamodificacion.TabIndex = 2
        '
        'dtp_FiFechacreacion
        '
        Me.dtp_FiFechacreacion.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_FiFechacreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FiFechacreacion.Location = New System.Drawing.Point(298, 31)
        Me.dtp_FiFechacreacion.Name = "dtp_FiFechacreacion"
        Me.dtp_FiFechacreacion.Size = New System.Drawing.Size(102, 20)
        Me.dtp_FiFechacreacion.TabIndex = 2
        '
        'tb_FiNotas
        '
        Me.tb_FiNotas.BackColor = System.Drawing.Color.White
        Me.tb_FiNotas.Location = New System.Drawing.Point(12, 132)
        Me.tb_FiNotas.Multiline = True
        Me.tb_FiNotas.Name = "tb_FiNotas"
        Me.tb_FiNotas.Size = New System.Drawing.Size(388, 101)
        Me.tb_FiNotas.TabIndex = 3
        '
        'tb_FiDescripcion
        '
        Me.tb_FiDescripcion.BackColor = System.Drawing.Color.White
        Me.tb_FiDescripcion.Location = New System.Drawing.Point(11, 32)
        Me.tb_FiDescripcion.Name = "tb_FiDescripcion"
        Me.tb_FiDescripcion.Size = New System.Drawing.Size(273, 20)
        Me.tb_FiDescripcion.TabIndex = 1
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FICHEROSBindingSource
        '
        Me.FICHEROSBindingSource.DataMember = "FICHEROS"
        Me.FICHEROSBindingSource.DataSource = Me.CMDataSet
        '
        'FICHEROSTableAdapter
        '
        Me.FICHEROSTableAdapter.ClearBeforeFill = True
        '
        'bt_FiCancelar
        '
        Me.bt_FiCancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_FiCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_FiCancelar.Location = New System.Drawing.Point(324, 256)
        Me.bt_FiCancelar.Name = "bt_FiCancelar"
        Me.bt_FiCancelar.Size = New System.Drawing.Size(89, 27)
        Me.bt_FiCancelar.TabIndex = 2
        Me.bt_FiCancelar.Text = "Cancelar    "
        Me.bt_FiCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_FiCancelar.UseVisualStyleBackColor = True
        '
        'bt_FiAceptar
        '
        Me.bt_FiAceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_FiAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_FiAceptar.Location = New System.Drawing.Point(222, 256)
        Me.bt_FiAceptar.Name = "bt_FiAceptar"
        Me.bt_FiAceptar.Size = New System.Drawing.Size(96, 27)
        Me.bt_FiAceptar.TabIndex = 1
        Me.bt_FiAceptar.Text = "Aceptar     "
        Me.bt_FiAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_FiAceptar.UseVisualStyleBackColor = True
        '
        'lblPathOriginalFIchero
        '
        Me.lblPathOriginalFIchero.AutoSize = True
        Me.lblPathOriginalFIchero.Location = New System.Drawing.Point(88, 104)
        Me.lblPathOriginalFIchero.Name = "lblPathOriginalFIchero"
        Me.lblPathOriginalFIchero.Size = New System.Drawing.Size(118, 13)
        Me.lblPathOriginalFIchero.TabIndex = 11
        Me.lblPathOriginalFIchero.Text = "Ruta original del fichero"
        Me.lblPathOriginalFIchero.Visible = False
        '
        'form_pac_ficheros_multimedias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(418, 285)
        Me.Controls.Add(Me.bt_FiCancelar)
        Me.Controls.Add(Me.bt_FiAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "form_pac_ficheros_multimedias"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fichero"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FICHEROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lb_FiDescripcion As System.Windows.Forms.Label
    Friend WithEvents lb_FiFechacreacion As System.Windows.Forms.Label
    Friend WithEvents lb_FiNombre As System.Windows.Forms.Label
    Friend WithEvents lb_FiUltimamodificacion As System.Windows.Forms.Label
    Friend WithEvents lb_FiNotas As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_FiUltimamodificacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FiFechacreacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_FiNotas As ctrlTextboxAvanzado
    Friend WithEvents tb_FiNombre As ctrlTextboxAvanzado
    Friend WithEvents tb_FiDescripcion As ctrlTextboxAvanzado
    Friend WithEvents bt_FiBuscar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents FICHEROSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FICHEROSTableAdapter As centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
    Friend WithEvents bt_FiCancelar As System.Windows.Forms.Button
    Friend WithEvents bt_FiAceptar As System.Windows.Forms.Button
    Friend WithEvents lblPathOriginalFIchero As System.Windows.Forms.Label
End Class
