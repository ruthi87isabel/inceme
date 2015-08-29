<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_plantilla_historial
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
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Me.tb_codigo = New ctrlTextboxAvanzado
        Me.PLANTILLA_HISTORIALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_descripcion = New ctrlTextboxAvanzado
        Me.tab_historial = New System.Windows.Forms.TabControl
        Me.tab_motivo = New System.Windows.Forms.TabPage
        Me.tc_motivo = New centro_medico.tool_control
        Me.tab_antecedentes = New System.Windows.Forms.TabPage
        Me.tc_antecedentes = New centro_medico.tool_control
        Me.tab_hist = New System.Windows.Forms.TabPage
        Me.tc_historial = New centro_medico.tool_control
        Me.tab_exploracion = New System.Windows.Forms.TabPage
        Me.tc_exploracion = New centro_medico.tool_control
        Me.tab_pruebas = New System.Windows.Forms.TabPage
        Me.tc_pruebas = New centro_medico.tool_control
        Me.tab_hipotesis = New System.Windows.Forms.TabPage
        Me.tc_hipotesis = New centro_medico.tool_control
        Me.tab_tratamiento = New System.Windows.Forms.TabPage
        Me.tc_tratamiento = New centro_medico.tool_control
        Me.tab_otras = New System.Windows.Forms.TabPage
        Me.tc_observaciones = New centro_medico.tool_control
        Me.tab_final = New System.Windows.Forms.TabPage
        Me.tc_notas = New centro_medico.tool_control
        Me.PLANTILLA_HISTORIALESTableAdapter = New centro_medico.CMDataSetTableAdapters.PLANTILLA_HISTORIALESTableAdapter
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        CODIGOLabel = New System.Windows.Forms.Label
        DESCRIPCIONLabel = New System.Windows.Forms.Label
        CType(Me.PLANTILLA_HISTORIALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_historial.SuspendLayout()
        Me.tab_motivo.SuspendLayout()
        Me.tab_antecedentes.SuspendLayout()
        Me.tab_hist.SuspendLayout()
        Me.tab_exploracion.SuspendLayout()
        Me.tab_pruebas.SuspendLayout()
        Me.tab_hipotesis.SuspendLayout()
        Me.tab_tratamiento.SuspendLayout()
        Me.tab_otras.SuspendLayout()
        Me.tab_final.SuspendLayout()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(12, 9)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(43, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "Codigo:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(134, 9)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(66, 13)
        DESCRIPCIONLabel.TabIndex = 3
        DESCRIPCIONLabel.Text = "Descripcion:"
        '
        'tb_codigo
        '
        Me.tb_codigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTILLA_HISTORIALESBindingSource, "CODIGO", True))
        Me.tb_codigo.Location = New System.Drawing.Point(15, 25)
        Me.tb_codigo.MaxLength = 12
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(100, 20)
        Me.tb_codigo.TabIndex = 0
        '
        'PLANTILLA_HISTORIALESBindingSource
        '
        Me.PLANTILLA_HISTORIALESBindingSource.DataMember = "PLANTILLA_HISTORIALES"
        Me.PLANTILLA_HISTORIALESBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_descripcion
        '
        Me.tb_descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTILLA_HISTORIALESBindingSource, "DESCRIPCION", True))
        Me.tb_descripcion.Location = New System.Drawing.Point(137, 25)
        Me.tb_descripcion.MaxLength = 120
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(521, 20)
        Me.tb_descripcion.TabIndex = 1
        '
        'tab_historial
        '
        Me.tab_historial.Controls.Add(Me.tab_motivo)
        Me.tab_historial.Controls.Add(Me.tab_antecedentes)
        Me.tab_historial.Controls.Add(Me.tab_hist)
        Me.tab_historial.Controls.Add(Me.tab_exploracion)
        Me.tab_historial.Controls.Add(Me.tab_pruebas)
        Me.tab_historial.Controls.Add(Me.tab_hipotesis)
        Me.tab_historial.Controls.Add(Me.tab_tratamiento)
        Me.tab_historial.Controls.Add(Me.tab_otras)
        Me.tab_historial.Controls.Add(Me.tab_final)
        Me.tab_historial.Location = New System.Drawing.Point(0, 66)
        Me.tab_historial.Multiline = True
        Me.tab_historial.Name = "tab_historial"
        Me.tab_historial.SelectedIndex = 0
        Me.tab_historial.Size = New System.Drawing.Size(662, 484)
        Me.tab_historial.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tab_historial.TabIndex = 2
        '
        'tab_motivo
        '
        Me.tab_motivo.Controls.Add(Me.tc_motivo)
        Me.tab_motivo.Location = New System.Drawing.Point(4, 40)
        Me.tab_motivo.Name = "tab_motivo"
        Me.tab_motivo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_motivo.Size = New System.Drawing.Size(654, 440)
        Me.tab_motivo.TabIndex = 0
        Me.tab_motivo.Text = "Motivo de consulta"
        Me.tab_motivo.UseVisualStyleBackColor = True
        '
        'tc_motivo
        '
        Me.tc_motivo.AutoScroll = True
        Me.tc_motivo.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
            "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tc_motivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_motivo.Location = New System.Drawing.Point(0, 0)
        Me.tc_motivo.Name = "tc_motivo"
        Me.tc_motivo.Size = New System.Drawing.Size(651, 468)
        Me.tc_motivo.TabIndex = 0
        '
        'tab_antecedentes
        '
        Me.tab_antecedentes.Controls.Add(Me.tc_antecedentes)
        Me.tab_antecedentes.Location = New System.Drawing.Point(4, 40)
        Me.tab_antecedentes.Name = "tab_antecedentes"
        Me.tab_antecedentes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_antecedentes.Size = New System.Drawing.Size(654, 440)
        Me.tab_antecedentes.TabIndex = 1
        Me.tab_antecedentes.Text = "Antecedentes"
        Me.tab_antecedentes.UseVisualStyleBackColor = True
        '
        'tc_antecedentes
        '
        Me.tc_antecedentes.AutoScroll = True
        Me.tc_antecedentes.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
            "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tc_antecedentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_antecedentes.Location = New System.Drawing.Point(2, 1)
        Me.tc_antecedentes.Name = "tc_antecedentes"
        Me.tc_antecedentes.Size = New System.Drawing.Size(651, 468)
        Me.tc_antecedentes.TabIndex = 1
        '
        'tab_hist
        '
        Me.tab_hist.Controls.Add(Me.tc_historial)
        Me.tab_hist.Location = New System.Drawing.Point(4, 40)
        Me.tab_hist.Name = "tab_hist"
        Me.tab_hist.Size = New System.Drawing.Size(654, 440)
        Me.tab_hist.TabIndex = 2
        Me.tab_hist.Text = "Historial"
        Me.tab_hist.UseVisualStyleBackColor = True
        '
        'tc_historial
        '
        Me.tc_historial.AutoScroll = True
        Me.tc_historial.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
            "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tc_historial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_historial.Location = New System.Drawing.Point(2, 1)
        Me.tc_historial.Name = "tc_historial"
        Me.tc_historial.Size = New System.Drawing.Size(651, 468)
        Me.tc_historial.TabIndex = 1
        '
        'tab_exploracion
        '
        Me.tab_exploracion.Controls.Add(Me.tc_exploracion)
        Me.tab_exploracion.Location = New System.Drawing.Point(4, 40)
        Me.tab_exploracion.Name = "tab_exploracion"
        Me.tab_exploracion.Size = New System.Drawing.Size(654, 440)
        Me.tab_exploracion.TabIndex = 3
        Me.tab_exploracion.Text = "Exploracion"
        Me.tab_exploracion.UseVisualStyleBackColor = True
        '
        'tc_exploracion
        '
        Me.tc_exploracion.AutoScroll = True
        Me.tc_exploracion.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
            "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tc_exploracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_exploracion.Location = New System.Drawing.Point(2, 1)
        Me.tc_exploracion.Name = "tc_exploracion"
        Me.tc_exploracion.Size = New System.Drawing.Size(651, 468)
        Me.tc_exploracion.TabIndex = 1
        '
        'tab_pruebas
        '
        Me.tab_pruebas.Controls.Add(Me.tc_pruebas)
        Me.tab_pruebas.Location = New System.Drawing.Point(4, 40)
        Me.tab_pruebas.Name = "tab_pruebas"
        Me.tab_pruebas.Size = New System.Drawing.Size(654, 440)
        Me.tab_pruebas.TabIndex = 4
        Me.tab_pruebas.Text = "Pruebas Complementarias"
        Me.tab_pruebas.UseVisualStyleBackColor = True
        '
        'tc_pruebas
        '
        Me.tc_pruebas.AutoScroll = True
        Me.tc_pruebas.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
            "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tc_pruebas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_pruebas.Location = New System.Drawing.Point(2, 1)
        Me.tc_pruebas.Name = "tc_pruebas"
        Me.tc_pruebas.Size = New System.Drawing.Size(651, 468)
        Me.tc_pruebas.TabIndex = 1
        '
        'tab_hipotesis
        '
        Me.tab_hipotesis.Controls.Add(Me.tc_hipotesis)
        Me.tab_hipotesis.Location = New System.Drawing.Point(4, 40)
        Me.tab_hipotesis.Name = "tab_hipotesis"
        Me.tab_hipotesis.Size = New System.Drawing.Size(654, 440)
        Me.tab_hipotesis.TabIndex = 5
        Me.tab_hipotesis.Text = "Hipotesis Diagnostica"
        Me.tab_hipotesis.UseVisualStyleBackColor = True
        '
        'tc_hipotesis
        '
        Me.tc_hipotesis.AutoScroll = True
        Me.tc_hipotesis.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
            "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tc_hipotesis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_hipotesis.Location = New System.Drawing.Point(2, 1)
        Me.tc_hipotesis.Name = "tc_hipotesis"
        Me.tc_hipotesis.Size = New System.Drawing.Size(651, 468)
        Me.tc_hipotesis.TabIndex = 1
        '
        'tab_tratamiento
        '
        Me.tab_tratamiento.Controls.Add(Me.tc_tratamiento)
        Me.tab_tratamiento.Location = New System.Drawing.Point(4, 40)
        Me.tab_tratamiento.Name = "tab_tratamiento"
        Me.tab_tratamiento.Size = New System.Drawing.Size(654, 440)
        Me.tab_tratamiento.TabIndex = 6
        Me.tab_tratamiento.Text = "Tratamiento"
        Me.tab_tratamiento.UseVisualStyleBackColor = True
        '
        'tc_tratamiento
        '
        Me.tc_tratamiento.AutoScroll = True
        Me.tc_tratamiento.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
            "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tc_tratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_tratamiento.Location = New System.Drawing.Point(2, 1)
        Me.tc_tratamiento.Name = "tc_tratamiento"
        Me.tc_tratamiento.Size = New System.Drawing.Size(651, 468)
        Me.tc_tratamiento.TabIndex = 1
        '
        'tab_otras
        '
        Me.tab_otras.Controls.Add(Me.tc_observaciones)
        Me.tab_otras.Location = New System.Drawing.Point(4, 40)
        Me.tab_otras.Name = "tab_otras"
        Me.tab_otras.Size = New System.Drawing.Size(654, 440)
        Me.tab_otras.TabIndex = 7
        Me.tab_otras.Text = "Otras Observaciones"
        Me.tab_otras.UseVisualStyleBackColor = True
        '
        'tc_observaciones
        '
        Me.tc_observaciones.AutoScroll = True
        Me.tc_observaciones.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
            "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tc_observaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_observaciones.Location = New System.Drawing.Point(2, 1)
        Me.tc_observaciones.Name = "tc_observaciones"
        Me.tc_observaciones.Size = New System.Drawing.Size(651, 468)
        Me.tc_observaciones.TabIndex = 1
        '
        'tab_final
        '
        Me.tab_final.Controls.Add(Me.tc_notas)
        Me.tab_final.Location = New System.Drawing.Point(4, 40)
        Me.tab_final.Name = "tab_final"
        Me.tab_final.Size = New System.Drawing.Size(654, 440)
        Me.tab_final.TabIndex = 8
        Me.tab_final.Text = "Notas Finales"
        Me.tab_final.UseVisualStyleBackColor = True
        '
        'tc_notas
        '
        Me.tc_notas.AutoScroll = True
        Me.tc_notas.ControlText = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
            "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tc_notas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_notas.Location = New System.Drawing.Point(2, 1)
        Me.tc_notas.Name = "tc_notas"
        Me.tc_notas.Size = New System.Drawing.Size(651, 468)
        Me.tc_notas.TabIndex = 1
        '
        'PLANTILLA_HISTORIALESTableAdapter
        '
        Me.PLANTILLA_HISTORIALESTableAdapter.ClearBeforeFill = True
        '
        'bt_cancel
        '
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(581, 559)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 4
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(487, 559)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 3
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'form_plantilla_historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 590)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.tab_historial)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.tb_codigo)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.tb_descripcion)
        Me.Name = "form_plantilla_historial"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_plantilla_historial"
        CType(Me.PLANTILLA_HISTORIALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_historial.ResumeLayout(False)
        Me.tab_motivo.ResumeLayout(False)
        Me.tab_antecedentes.ResumeLayout(False)
        Me.tab_hist.ResumeLayout(False)
        Me.tab_exploracion.ResumeLayout(False)
        Me.tab_pruebas.ResumeLayout(False)
        Me.tab_hipotesis.ResumeLayout(False)
        Me.tab_tratamiento.ResumeLayout(False)
        Me.tab_otras.ResumeLayout(False)
        Me.tab_final.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PLANTILLA_HISTORIALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLANTILLA_HISTORIALESTableAdapter As centro_medico.CMDataSetTableAdapters.PLANTILLA_HISTORIALESTableAdapter
    Friend WithEvents tb_codigo As ctrlTextboxAvanzado
    Friend WithEvents tb_descripcion As ctrlTextboxAvanzado
    Friend WithEvents tab_historial As System.Windows.Forms.TabControl
    Friend WithEvents tab_motivo As System.Windows.Forms.TabPage
    Friend WithEvents tab_antecedentes As System.Windows.Forms.TabPage
    Friend WithEvents tab_hist As System.Windows.Forms.TabPage
    Friend WithEvents tab_exploracion As System.Windows.Forms.TabPage
    Friend WithEvents tab_pruebas As System.Windows.Forms.TabPage
    Friend WithEvents tab_hipotesis As System.Windows.Forms.TabPage
    Friend WithEvents tab_tratamiento As System.Windows.Forms.TabPage
    Friend WithEvents tab_otras As System.Windows.Forms.TabPage
    Friend WithEvents tab_final As System.Windows.Forms.TabPage
    Friend WithEvents tc_motivo As centro_medico.tool_control
    Friend WithEvents tc_antecedentes As centro_medico.tool_control
    Friend WithEvents tc_historial As centro_medico.tool_control
    Friend WithEvents tc_exploracion As centro_medico.tool_control
    Friend WithEvents tc_pruebas As centro_medico.tool_control
    Friend WithEvents tc_hipotesis As centro_medico.tool_control
    Friend WithEvents tc_tratamiento As centro_medico.tool_control
    Friend WithEvents tc_observaciones As centro_medico.tool_control
    Friend WithEvents tc_notas As centro_medico.tool_control
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
End Class
