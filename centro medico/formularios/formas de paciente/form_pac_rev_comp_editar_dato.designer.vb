<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pac_rev_comp_editar_dato
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
        Me.lb_nombredato = New System.Windows.Forms.Label
        Me.tb_valordato = New ctrlTextboxAvanzado
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.DATOSCOMPARATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DATOSCOMPARATIVATableAdapter = New centro_medico.CMDataSetTableAdapters.DATOSCOMPARATIVATableAdapter
        Me.gb_booleano = New System.Windows.Forms.GroupBox
        Me.rb_no = New System.Windows.Forms.RadioButton
        Me.rb_si = New System.Windows.Forms.RadioButton
        Me.MODELOSDATOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MODELOSDATOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MODELOSDATOSTableAdapter
        Me.bt_Cancelar = New System.Windows.Forms.Button
        Me.bt_Aceptar = New System.Windows.Forms.Button
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATOSCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_booleano.SuspendLayout()
        CType(Me.MODELOSDATOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_nombredato
        '
        Me.lb_nombredato.AutoSize = True
        Me.lb_nombredato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nombredato.Location = New System.Drawing.Point(19, 10)
        Me.lb_nombredato.Name = "lb_nombredato"
        Me.lb_nombredato.Size = New System.Drawing.Size(0, 13)
        Me.lb_nombredato.TabIndex = 14
        '
        'tb_valordato
        '
        Me.tb_valordato.Location = New System.Drawing.Point(12, 31)
        Me.tb_valordato.Name = "tb_valordato"
        Me.tb_valordato.Size = New System.Drawing.Size(318, 20)
        Me.tb_valordato.TabIndex = 1
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DATOSCOMPARATIVABindingSource
        '
        Me.DATOSCOMPARATIVABindingSource.DataMember = "DATOSCOMPARATIVA"
        Me.DATOSCOMPARATIVABindingSource.DataSource = Me.CMDataSet
        '
        'DATOSCOMPARATIVATableAdapter
        '
        Me.DATOSCOMPARATIVATableAdapter.ClearBeforeFill = True
        '
        'gb_booleano
        '
        Me.gb_booleano.Controls.Add(Me.rb_no)
        Me.gb_booleano.Controls.Add(Me.rb_si)
        Me.gb_booleano.Location = New System.Drawing.Point(90, 22)
        Me.gb_booleano.Name = "gb_booleano"
        Me.gb_booleano.Size = New System.Drawing.Size(158, 29)
        Me.gb_booleano.TabIndex = 16
        Me.gb_booleano.TabStop = False
        Me.gb_booleano.Visible = False
        '
        'rb_no
        '
        Me.rb_no.AutoSize = True
        Me.rb_no.Location = New System.Drawing.Point(92, 9)
        Me.rb_no.Name = "rb_no"
        Me.rb_no.Size = New System.Drawing.Size(39, 17)
        Me.rb_no.TabIndex = 1
        Me.rb_no.TabStop = True
        Me.rb_no.Text = "No"
        Me.rb_no.UseVisualStyleBackColor = True
        '
        'rb_si
        '
        Me.rb_si.AutoSize = True
        Me.rb_si.Location = New System.Drawing.Point(18, 9)
        Me.rb_si.Name = "rb_si"
        Me.rb_si.Size = New System.Drawing.Size(36, 17)
        Me.rb_si.TabIndex = 0
        Me.rb_si.TabStop = True
        Me.rb_si.Text = "Sí"
        Me.rb_si.UseVisualStyleBackColor = True
        '
        'MODELOSDATOSBindingSource
        '
        Me.MODELOSDATOSBindingSource.DataMember = "MODELOSDATOS"
        Me.MODELOSDATOSBindingSource.DataSource = Me.CMDataSet
        '
        'MODELOSDATOSTableAdapter
        '
        Me.MODELOSDATOSTableAdapter.ClearBeforeFill = True
        '
        'bt_Cancelar
        '
        Me.bt_Cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Cancelar.Location = New System.Drawing.Point(255, 67)
        Me.bt_Cancelar.Name = "bt_Cancelar"
        Me.bt_Cancelar.Size = New System.Drawing.Size(75, 28)
        Me.bt_Cancelar.TabIndex = 3
        Me.bt_Cancelar.Text = "Cancelar"
        Me.bt_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Cancelar.UseVisualStyleBackColor = True
        '
        'bt_Aceptar
        '
        Me.bt_Aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Aceptar.Location = New System.Drawing.Point(172, 67)
        Me.bt_Aceptar.Name = "bt_Aceptar"
        Me.bt_Aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_Aceptar.TabIndex = 2
        Me.bt_Aceptar.Text = "Aceptar"
        Me.bt_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Aceptar.UseVisualStyleBackColor = True
        '
        'form_pac_rev_comp_editar_dato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 100)
        Me.Controls.Add(Me.bt_Cancelar)
        Me.Controls.Add(Me.bt_Aceptar)
        Me.Controls.Add(Me.gb_booleano)
        Me.Controls.Add(Me.tb_valordato)
        Me.Controls.Add(Me.lb_nombredato)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_pac_rev_comp_editar_dato"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Introduzca un valor para el dato"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATOSCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_booleano.ResumeLayout(False)
        Me.gb_booleano.PerformLayout()
        CType(Me.MODELOSDATOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_nombredato As System.Windows.Forms.Label
    Friend WithEvents tb_valordato As ctrlTextboxAvanzado
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents DATOSCOMPARATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DATOSCOMPARATIVATableAdapter As centro_medico.CMDataSetTableAdapters.DATOSCOMPARATIVATableAdapter
    Friend WithEvents gb_booleano As System.Windows.Forms.GroupBox
    Friend WithEvents rb_no As System.Windows.Forms.RadioButton
    Friend WithEvents rb_si As System.Windows.Forms.RadioButton
    Friend WithEvents MODELOSDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MODELOSDATOSTableAdapter As centro_medico.CMDataSetTableAdapters.MODELOSDATOSTableAdapter
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_Aceptar As System.Windows.Forms.Button
End Class
