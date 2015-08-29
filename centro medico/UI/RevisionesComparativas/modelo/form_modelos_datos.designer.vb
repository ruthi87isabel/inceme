<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_modelos_datos
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
        Me.lb_descripcion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEditarExpresion = New System.Windows.Forms.Button()
        Me.txtExpresion = New System.Windows.Forms.TextBox()
        Me.pnlMultiples = New System.Windows.Forms.Panel()
        Me.chckListopciones = New System.Windows.Forms.CheckedListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.rb_OpcionesMultiples = New System.Windows.Forms.RadioButton()
        Me.rb_OpcionesExclusivas = New System.Windows.Forms.RadioButton()
        Me.rb_Expresiones = New System.Windows.Forms.RadioButton()
        Me.rb_booleano = New System.Windows.Forms.RadioButton()
        Me.rb_texto = New System.Windows.Forms.RadioButton()
        Me.rb_numerico = New System.Windows.Forms.RadioButton()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.chkRepetir = New System.Windows.Forms.CheckBox()
        Me.MODELOSDATOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_descripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.chkCalcDiferencia = New System.Windows.Forms.CheckBox()
        Me.chckOcultarResumenReporte = New System.Windows.Forms.CheckBox()
        Me.chkOpcionImpresionCliente = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.pnlMultiples.SuspendLayout()
        CType(Me.MODELOSDATOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_descripcion
        '
        Me.lb_descripcion.AutoSize = True
        Me.lb_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_descripcion.Location = New System.Drawing.Point(2, 7)
        Me.lb_descripcion.Name = "lb_descripcion"
        Me.lb_descripcion.Size = New System.Drawing.Size(78, 13)
        Me.lb_descripcion.TabIndex = 1
        Me.lb_descripcion.Text = "Descripción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnEditarExpresion)
        Me.GroupBox1.Controls.Add(Me.txtExpresion)
        Me.GroupBox1.Controls.Add(Me.pnlMultiples)
        Me.GroupBox1.Controls.Add(Me.rb_OpcionesMultiples)
        Me.GroupBox1.Controls.Add(Me.rb_OpcionesExclusivas)
        Me.GroupBox1.Controls.Add(Me.rb_Expresiones)
        Me.GroupBox1.Controls.Add(Me.rb_booleano)
        Me.GroupBox1.Controls.Add(Me.rb_texto)
        Me.GroupBox1.Controls.Add(Me.rb_numerico)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 285)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de dato"
        '
        'btnEditarExpresion
        '
        Me.btnEditarExpresion.Enabled = False
        Me.btnEditarExpresion.Location = New System.Drawing.Point(302, 66)
        Me.btnEditarExpresion.Name = "btnEditarExpresion"
        Me.btnEditarExpresion.Size = New System.Drawing.Size(49, 23)
        Me.btnEditarExpresion.TabIndex = 8
        Me.btnEditarExpresion.Text = "Editar"
        Me.btnEditarExpresion.UseVisualStyleBackColor = True
        '
        'txtExpresion
        '
        Me.txtExpresion.Location = New System.Drawing.Point(83, 68)
        Me.txtExpresion.Name = "txtExpresion"
        Me.txtExpresion.ReadOnly = True
        Me.txtExpresion.Size = New System.Drawing.Size(216, 20)
        Me.txtExpresion.TabIndex = 7
        '
        'pnlMultiples
        '
        Me.pnlMultiples.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMultiples.Controls.Add(Me.chckListopciones)
        Me.pnlMultiples.Controls.Add(Me.btnAdd)
        Me.pnlMultiples.Controls.Add(Me.btnEliminar)
        Me.pnlMultiples.Controls.Add(Me.btnEditar)
        Me.pnlMultiples.Enabled = False
        Me.pnlMultiples.Location = New System.Drawing.Point(6, 128)
        Me.pnlMultiples.Name = "pnlMultiples"
        Me.pnlMultiples.Size = New System.Drawing.Size(380, 151)
        Me.pnlMultiples.TabIndex = 6
        '
        'chckListopciones
        '
        Me.chckListopciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chckListopciones.CheckOnClick = True
        Me.chckListopciones.FormattingEnabled = True
        Me.chckListopciones.Location = New System.Drawing.Point(3, 3)
        Me.chckListopciones.Name = "chckListopciones"
        Me.chckListopciones.Size = New System.Drawing.Size(347, 124)
        Me.chckListopciones.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Image = Global.centro_medico.My.Resources.Resources.plus16x16
        Me.btnAdd.Location = New System.Drawing.Point(352, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(28, 24)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Image = Global.centro_medico.My.Resources.Resources.cancel
        Me.btnEliminar.Location = New System.Drawing.Point(352, 53)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(28, 24)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.Enabled = False
        Me.btnEditar.Image = Global.centro_medico.My.Resources.Resources.edit
        Me.btnEditar.Location = New System.Drawing.Point(352, 28)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(28, 24)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'rb_OpcionesMultiples
        '
        Me.rb_OpcionesMultiples.AutoSize = True
        Me.rb_OpcionesMultiples.Location = New System.Drawing.Point(144, 105)
        Me.rb_OpcionesMultiples.Name = "rb_OpcionesMultiples"
        Me.rb_OpcionesMultiples.Size = New System.Drawing.Size(114, 17)
        Me.rb_OpcionesMultiples.TabIndex = 2
        Me.rb_OpcionesMultiples.Text = "Opciones Multiples"
        Me.rb_OpcionesMultiples.UseVisualStyleBackColor = True
        '
        'rb_OpcionesExclusivas
        '
        Me.rb_OpcionesExclusivas.AutoSize = True
        Me.rb_OpcionesExclusivas.Location = New System.Drawing.Point(9, 105)
        Me.rb_OpcionesExclusivas.Name = "rb_OpcionesExclusivas"
        Me.rb_OpcionesExclusivas.Size = New System.Drawing.Size(123, 17)
        Me.rb_OpcionesExclusivas.TabIndex = 2
        Me.rb_OpcionesExclusivas.Text = "Opciones Exclusivas"
        Me.rb_OpcionesExclusivas.UseVisualStyleBackColor = True
        '
        'rb_Expresiones
        '
        Me.rb_Expresiones.AutoSize = True
        Me.rb_Expresiones.Location = New System.Drawing.Point(6, 68)
        Me.rb_Expresiones.Name = "rb_Expresiones"
        Me.rb_Expresiones.Size = New System.Drawing.Size(71, 17)
        Me.rb_Expresiones.TabIndex = 2
        Me.rb_Expresiones.Text = "Expresión"
        Me.rb_Expresiones.UseVisualStyleBackColor = True
        '
        'rb_booleano
        '
        Me.rb_booleano.AutoSize = True
        Me.rb_booleano.Location = New System.Drawing.Point(185, 28)
        Me.rb_booleano.Name = "rb_booleano"
        Me.rb_booleano.Size = New System.Drawing.Size(70, 17)
        Me.rb_booleano.TabIndex = 2
        Me.rb_booleano.Text = "Booleano"
        Me.rb_booleano.UseVisualStyleBackColor = True
        '
        'rb_texto
        '
        Me.rb_texto.AutoSize = True
        Me.rb_texto.Location = New System.Drawing.Point(104, 28)
        Me.rb_texto.Name = "rb_texto"
        Me.rb_texto.Size = New System.Drawing.Size(52, 17)
        Me.rb_texto.TabIndex = 1
        Me.rb_texto.Text = "Texto"
        Me.rb_texto.UseVisualStyleBackColor = True
        '
        'rb_numerico
        '
        Me.rb_numerico.AutoSize = True
        Me.rb_numerico.Checked = True
        Me.rb_numerico.Location = New System.Drawing.Point(7, 28)
        Me.rb_numerico.Name = "rb_numerico"
        Me.rb_numerico.Size = New System.Drawing.Size(70, 17)
        Me.rb_numerico.TabIndex = 0
        Me.rb_numerico.TabStop = True
        Me.rb_numerico.Text = "Numérico"
        Me.rb_numerico.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(322, 408)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancelar.TabIndex = 4
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(238, 408)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 3
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'chkRepetir
        '
        Me.chkRepetir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkRepetir.AutoSize = True
        Me.chkRepetir.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.MODELOSDATOSBindingSource, "Repetir", True))
        Me.chkRepetir.Location = New System.Drawing.Point(14, 353)
        Me.chkRepetir.Name = "chkRepetir"
        Me.chkRepetir.Size = New System.Drawing.Size(278, 17)
        Me.chkRepetir.TabIndex = 5
        Me.chkRepetir.Text = "Repetir  (tomar valores de la revision anterior si existe)"
        Me.chkRepetir.UseVisualStyleBackColor = True
        '
        'MODELOSDATOSBindingSource
        '
        Me.MODELOSDATOSBindingSource.DataSource = GetType(centro_medico.MODELOSDATO)
        '
        'tb_descripcion
        '
        Me.tb_descripcion.AcceptsReturn = True
        Me.tb_descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_descripcion.Location = New System.Drawing.Point(5, 23)
        Me.tb_descripcion.MaxLength = 150
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(392, 20)
        Me.tb_descripcion.TabIndex = 0
        '
        'chkCalcDiferencia
        '
        Me.chkCalcDiferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkCalcDiferencia.AutoSize = True
        Me.chkCalcDiferencia.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.MODELOSDATOSBindingSource, "CalcDiferencia", True))
        Me.chkCalcDiferencia.Location = New System.Drawing.Point(14, 375)
        Me.chkCalcDiferencia.Name = "chkCalcDiferencia"
        Me.chkCalcDiferencia.Size = New System.Drawing.Size(320, 17)
        Me.chkCalcDiferencia.TabIndex = 5
        Me.chkCalcDiferencia.Text = "Calcular diferencia (con el valor de la revisión anterior si existe)"
        Me.chkCalcDiferencia.UseVisualStyleBackColor = True
        '
        'chckOcultarResumenReporte
        '
        Me.chckOcultarResumenReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chckOcultarResumenReporte.AutoSize = True
        Me.chckOcultarResumenReporte.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.MODELOSDATOSBindingSource, "OcultarEnReporte", True))
        Me.chckOcultarResumenReporte.Location = New System.Drawing.Point(14, 398)
        Me.chckOcultarResumenReporte.Name = "chckOcultarResumenReporte"
        Me.chckOcultarResumenReporte.Size = New System.Drawing.Size(169, 17)
        Me.chckOcultarResumenReporte.TabIndex = 5
        Me.chckOcultarResumenReporte.Text = "Ocultar en resumen de reporte"
        Me.chckOcultarResumenReporte.UseVisualStyleBackColor = True
        '
        'chkOpcionImpresionCliente
        '
        Me.chkOpcionImpresionCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkOpcionImpresionCliente.AutoSize = True
        Me.chkOpcionImpresionCliente.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.MODELOSDATOSBindingSource, "OcultarEnReporte", True))
        Me.chkOpcionImpresionCliente.Location = New System.Drawing.Point(14, 419)
        Me.chkOpcionImpresionCliente.Name = "chkOpcionImpresionCliente"
        Me.chkOpcionImpresionCliente.Size = New System.Drawing.Size(171, 17)
        Me.chkOpcionImpresionCliente.TabIndex = 6
        Me.chkOpcionImpresionCliente.Text = "Ocultar en impresion de cliente"
        Me.chkOpcionImpresionCliente.UseVisualStyleBackColor = True
        '
        'form_modelos_datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 439)
        Me.Controls.Add(Me.chkOpcionImpresionCliente)
        Me.Controls.Add(Me.chckOcultarResumenReporte)
        Me.Controls.Add(Me.chkCalcDiferencia)
        Me.Controls.Add(Me.chkRepetir)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tb_descripcion)
        Me.Controls.Add(Me.lb_descripcion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_modelos_datos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modelo de dato"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlMultiples.ResumeLayout(False)
        CType(Me.MODELOSDATOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_descripcion As System.Windows.Forms.Label
    Friend WithEvents tb_descripcion As ctrlTextboxAvanzado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_booleano As System.Windows.Forms.RadioButton
    Friend WithEvents rb_texto As System.Windows.Forms.RadioButton
    Friend WithEvents rb_numerico As System.Windows.Forms.RadioButton
    Friend WithEvents MODELOSDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents rb_OpcionesMultiples As System.Windows.Forms.RadioButton
    Friend WithEvents rb_OpcionesExclusivas As System.Windows.Forms.RadioButton
    Friend WithEvents chckListopciones As System.Windows.Forms.CheckedListBox
    Friend WithEvents pnlMultiples As System.Windows.Forms.Panel
    Friend WithEvents rb_Expresiones As System.Windows.Forms.RadioButton
    Friend WithEvents btnEditarExpresion As System.Windows.Forms.Button
    Friend WithEvents txtExpresion As System.Windows.Forms.TextBox
    Friend WithEvents chkRepetir As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDiferencia As System.Windows.Forms.CheckBox
    Friend WithEvents chckOcultarResumenReporte As System.Windows.Forms.CheckBox
    Friend WithEvents chkOpcionImpresionCliente As System.Windows.Forms.CheckBox
End Class
