<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevComparativa_Nuevo_Seguimiento
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
        Me.tb_dbsHora = New System.Windows.Forms.DateTimePicker()
        Me.LCOMPARATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtp_dbsFecha = New System.Windows.Forms.DateTimePicker()
        Me.lb_dbsDescripcion = New System.Windows.Forms.Label()
        Me.lb_dbsHora = New System.Windows.Forms.Label()
        Me.lb_dbsFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.CtrlMedico1 = New centro_medico.ctrlMedico()
        Me.CtrlModeloRevision1 = New centro_medico.ctrlModeloRevision()
        Me.CtrlTextboxAvanzado1 = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_dbsDescripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.lblSeguimientoDesactivado = New System.Windows.Forms.Label()
        CType(Me.LCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_dbsHora
        '
        Me.tb_dbsHora.CalendarMonthBackground = System.Drawing.Color.White
        Me.tb_dbsHora.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LCOMPARATIVABindingSource, "HORA", True))
        Me.tb_dbsHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tb_dbsHora.Location = New System.Drawing.Point(431, 31)
        Me.tb_dbsHora.Name = "tb_dbsHora"
        Me.tb_dbsHora.Size = New System.Drawing.Size(94, 20)
        Me.tb_dbsHora.TabIndex = 2
        '
        'LCOMPARATIVABindingSource
        '
        Me.LCOMPARATIVABindingSource.DataSource = GetType(centro_medico.LCOMPARATIVA)
        '
        'dtp_dbsFecha
        '
        Me.dtp_dbsFecha.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_dbsFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LCOMPARATIVABindingSource, "FECHA", True))
        Me.dtp_dbsFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dbsFecha.Location = New System.Drawing.Point(319, 31)
        Me.dtp_dbsFecha.Name = "dtp_dbsFecha"
        Me.dtp_dbsFecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_dbsFecha.TabIndex = 1
        '
        'lb_dbsDescripcion
        '
        Me.lb_dbsDescripcion.AutoSize = True
        Me.lb_dbsDescripcion.Location = New System.Drawing.Point(9, 126)
        Me.lb_dbsDescripcion.Name = "lb_dbsDescripcion"
        Me.lb_dbsDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lb_dbsDescripcion.TabIndex = 12
        Me.lb_dbsDescripcion.Text = "Descripción"
        '
        'lb_dbsHora
        '
        Me.lb_dbsHora.AutoSize = True
        Me.lb_dbsHora.Location = New System.Drawing.Point(428, 14)
        Me.lb_dbsHora.Name = "lb_dbsHora"
        Me.lb_dbsHora.Size = New System.Drawing.Size(30, 13)
        Me.lb_dbsHora.TabIndex = 11
        Me.lb_dbsHora.Text = "Hora"
        '
        'lb_dbsFecha
        '
        Me.lb_dbsFecha.AutoSize = True
        Me.lb_dbsFecha.Location = New System.Drawing.Point(316, 15)
        Me.lb_dbsFecha.Name = "lb_dbsFecha"
        Me.lb_dbsFecha.Size = New System.Drawing.Size(37, 13)
        Me.lb_dbsFecha.TabIndex = 10
        Me.lb_dbsFecha.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Modelo de Revisión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Notas"
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAceptar.Location = New System.Drawing.Point(369, 377)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 6
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancelar.Location = New System.Drawing.Point(450, 377)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 7
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Medico", Me.LCOMPARATIVABindingSource, "REFMEDICO", True))
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(12, 65)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(513, 42)
        Me.CtrlMedico1.TabIndex = 3
        '
        'CtrlModeloRevision1
        '
        Me.CtrlModeloRevision1.CODIGO = Nothing
        Me.CtrlModeloRevision1.DataBindings.Add(New System.Windows.Forms.Binding("CODIGO", Me.LCOMPARATIVABindingSource, "REFMODELOCOMPARATIVA", True))
        Me.CtrlModeloRevision1.Location = New System.Drawing.Point(12, 31)
        Me.CtrlModeloRevision1.Name = "CtrlModeloRevision1"
        Me.CtrlModeloRevision1.Size = New System.Drawing.Size(301, 26)
        Me.CtrlModeloRevision1.TabIndex = 0
        '
        'CtrlTextboxAvanzado1
        '
        Me.CtrlTextboxAvanzado1.AcceptsReturn = True
        Me.CtrlTextboxAvanzado1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlTextboxAvanzado1.BackColor = System.Drawing.Color.White
        Me.CtrlTextboxAvanzado1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LCOMPARATIVABindingSource, "NOTAS", True))
        Me.CtrlTextboxAvanzado1.Location = New System.Drawing.Point(10, 197)
        Me.CtrlTextboxAvanzado1.Multiline = True
        Me.CtrlTextboxAvanzado1.Name = "CtrlTextboxAvanzado1"
        Me.CtrlTextboxAvanzado1.Size = New System.Drawing.Size(512, 174)
        Me.CtrlTextboxAvanzado1.TabIndex = 5
        '
        'tb_dbsDescripcion
        '
        Me.tb_dbsDescripcion.AcceptsReturn = True
        Me.tb_dbsDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_dbsDescripcion.BackColor = System.Drawing.Color.White
        Me.tb_dbsDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LCOMPARATIVABindingSource, "DESCRIPCION", True))
        Me.tb_dbsDescripcion.Location = New System.Drawing.Point(11, 142)
        Me.tb_dbsDescripcion.MaxLength = 90
        Me.tb_dbsDescripcion.Name = "tb_dbsDescripcion"
        Me.tb_dbsDescripcion.Size = New System.Drawing.Size(512, 20)
        Me.tb_dbsDescripcion.TabIndex = 4
        '
        'lblSeguimientoDesactivado
        '
        Me.lblSeguimientoDesactivado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeguimientoDesactivado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeguimientoDesactivado.ForeColor = System.Drawing.Color.Red
        Me.lblSeguimientoDesactivado.Location = New System.Drawing.Point(9, 374)
        Me.lblSeguimientoDesactivado.Name = "lblSeguimientoDesactivado"
        Me.lblSeguimientoDesactivado.Size = New System.Drawing.Size(354, 30)
        Me.lblSeguimientoDesactivado.TabIndex = 12
        Me.lblSeguimientoDesactivado.Text = "Transcurridas más de 24 horas desde su creación, el seguimiento está en Solo Lect" & _
    "ura"
        Me.lblSeguimientoDesactivado.Visible = False
        '
        'frmRevComparativa_Nuevo_Seguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 407)
        Me.Controls.Add(Me.CtrlMedico1)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.CtrlModeloRevision1)
        Me.Controls.Add(Me.tb_dbsHora)
        Me.Controls.Add(Me.dtp_dbsFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSeguimientoDesactivado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb_dbsDescripcion)
        Me.Controls.Add(Me.lb_dbsHora)
        Me.Controls.Add(Me.lb_dbsFecha)
        Me.Controls.Add(Me.CtrlTextboxAvanzado1)
        Me.Controls.Add(Me.tb_dbsDescripcion)
        Me.Name = "frmRevComparativa_Nuevo_Seguimiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Seguimiento"
        CType(Me.LCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_dbsHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_dbsFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_dbsDescripcion As System.Windows.Forms.Label
    Friend WithEvents lb_dbsHora As System.Windows.Forms.Label
    Friend WithEvents lb_dbsFecha As System.Windows.Forms.Label
    Friend WithEvents tb_dbsDescripcion As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents CtrlModeloRevision1 As centro_medico.ctrlModeloRevision
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CtrlTextboxAvanzado1 As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Public WithEvents LCOMPARATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Friend WithEvents lblSeguimientoDesactivado As System.Windows.Forms.Label
End Class
