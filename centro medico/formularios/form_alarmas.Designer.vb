<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_alarmas
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
        Dim CALARMALabel As System.Windows.Forms.Label
        Dim ALARMALabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab_alarma = New System.Windows.Forms.TabPage
        Me.lb_datos = New System.Windows.Forms.Label
        Me.gb_niveles = New System.Windows.Forms.GroupBox
        Me.rb_baja = New System.Windows.Forms.RadioButton
        Me.ALARMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.rb_alta = New System.Windows.Forms.RadioButton
        Me.rb_media = New System.Windows.Forms.RadioButton
        Me.tb_descripc = New ctrlTextboxAvanzado
        Me.tb_cod = New ctrlTextboxAvanzado
        Me.tb_alarma = New ctrlTextboxAvanzado
        Me.pacientes_alarma = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_todos = New System.Windows.Forms.RadioButton
        Me.rb_activo = New System.Windows.Forms.RadioButton
        Me.rb_inactivo = New System.Windows.Forms.RadioButton
        Me.bt_imprimir = New System.Windows.Forms.Button
        Me.bt_ficha = New System.Windows.Forms.Button
        Me.dgv_pacientes = New System.Windows.Forms.DataGridView
        Me.bt_delete = New System.Windows.Forms.Button
        Me.bt_add = New System.Windows.Forms.Button
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.LINEASALARMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALARMASTableAdapter = New centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.LINEASALARMATableAdapter = New centro_medico.CMDataSetTableAdapters.LINEASALARMATableAdapter
        CALARMALabel = New System.Windows.Forms.Label
        ALARMALabel = New System.Windows.Forms.Label
        DESCRIPCIONLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tab_alarma.SuspendLayout()
        Me.gb_niveles.SuspendLayout()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pacientes_alarma.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEASALARMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CALARMALabel
        '
        CALARMALabel.AutoSize = True
        CALARMALabel.Location = New System.Drawing.Point(17, 31)
        CALARMALabel.Name = "CALARMALabel"
        CALARMALabel.Size = New System.Drawing.Size(43, 13)
        CALARMALabel.TabIndex = 0
        CALARMALabel.Text = "Codigo:"
        '
        'ALARMALabel
        '
        ALARMALabel.AutoSize = True
        ALARMALabel.Location = New System.Drawing.Point(152, 31)
        ALARMALabel.Name = "ALARMALabel"
        ALARMALabel.Size = New System.Drawing.Size(42, 13)
        ALARMALabel.TabIndex = 2
        ALARMALabel.Text = "Alarma:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(17, 172)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(66, 13)
        DESCRIPCIONLabel.TabIndex = 6
        DESCRIPCIONLabel.Text = "Descripcion:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_alarma)
        Me.TabControl1.Controls.Add(Me.pacientes_alarma)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(670, 415)
        Me.TabControl1.TabIndex = 0
        '
        'tab_alarma
        '
        Me.tab_alarma.BackColor = System.Drawing.Color.Transparent
        Me.tab_alarma.Controls.Add(Me.lb_datos)
        Me.tab_alarma.Controls.Add(Me.gb_niveles)
        Me.tab_alarma.Controls.Add(DESCRIPCIONLabel)
        Me.tab_alarma.Controls.Add(Me.tb_descripc)
        Me.tab_alarma.Controls.Add(CALARMALabel)
        Me.tab_alarma.Controls.Add(Me.tb_cod)
        Me.tab_alarma.Controls.Add(ALARMALabel)
        Me.tab_alarma.Controls.Add(Me.tb_alarma)
        Me.tab_alarma.Location = New System.Drawing.Point(4, 22)
        Me.tab_alarma.Name = "tab_alarma"
        Me.tab_alarma.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_alarma.Size = New System.Drawing.Size(662, 389)
        Me.tab_alarma.TabIndex = 0
        Me.tab_alarma.Text = "Datos de la Alarma"
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(8, 3)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(648, 19)
        Me.lb_datos.TabIndex = 62
        Me.lb_datos.Text = "Alarma"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_niveles
        '
        Me.gb_niveles.Controls.Add(Me.rb_baja)
        Me.gb_niveles.Controls.Add(Me.rb_alta)
        Me.gb_niveles.Controls.Add(Me.rb_media)
        Me.gb_niveles.Location = New System.Drawing.Point(18, 83)
        Me.gb_niveles.Name = "gb_niveles"
        Me.gb_niveles.Size = New System.Drawing.Size(457, 74)
        Me.gb_niveles.TabIndex = 12
        Me.gb_niveles.TabStop = False
        Me.gb_niveles.Text = "Nivel de atencion"
        '
        'rb_baja
        '
        Me.rb_baja.Checked = True
        Me.rb_baja.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ALARMASBindingSource, "NIVEL", True))
        Me.rb_baja.Location = New System.Drawing.Point(313, 33)
        Me.rb_baja.Name = "rb_baja"
        Me.rb_baja.Size = New System.Drawing.Size(104, 24)
        Me.rb_baja.TabIndex = 2
        Me.rb_baja.TabStop = True
        Me.rb_baja.Text = "Baja"
        '
        'ALARMASBindingSource
        '
        Me.ALARMASBindingSource.DataMember = "ALARMAS"
        Me.ALARMASBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rb_alta
        '
        Me.rb_alta.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ALARMASBindingSource, "NIVEL", True))
        Me.rb_alta.Location = New System.Drawing.Point(19, 33)
        Me.rb_alta.Name = "rb_alta"
        Me.rb_alta.Size = New System.Drawing.Size(104, 24)
        Me.rb_alta.TabIndex = 0
        Me.rb_alta.Text = "Alta"
        '
        'rb_media
        '
        Me.rb_media.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ALARMASBindingSource, "NIVEL", True))
        Me.rb_media.Location = New System.Drawing.Point(158, 33)
        Me.rb_media.Name = "rb_media"
        Me.rb_media.Size = New System.Drawing.Size(104, 24)
        Me.rb_media.TabIndex = 1
        Me.rb_media.Text = "Media"
        '
        'tb_descripc
        '
        Me.tb_descripc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALARMASBindingSource, "DESCRIPCION", True))
        Me.tb_descripc.Location = New System.Drawing.Point(18, 188)
        Me.tb_descripc.MaxLength = 120
        Me.tb_descripc.Multiline = True
        Me.tb_descripc.Name = "tb_descripc"
        Me.tb_descripc.Size = New System.Drawing.Size(638, 197)
        Me.tb_descripc.TabIndex = 3
        '
        'tb_cod
        '
        Me.tb_cod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALARMASBindingSource, "CALARMA", True))
        Me.tb_cod.Enabled = False
        Me.tb_cod.Location = New System.Drawing.Point(18, 57)
        Me.tb_cod.Name = "tb_cod"
        Me.tb_cod.ReadOnly = True
        Me.tb_cod.Size = New System.Drawing.Size(104, 20)
        Me.tb_cod.TabIndex = 1
        '
        'tb_alarma
        '
        Me.tb_alarma.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALARMASBindingSource, "ALARMA", True))
        Me.tb_alarma.Location = New System.Drawing.Point(155, 57)
        Me.tb_alarma.MaxLength = 40
        Me.tb_alarma.Name = "tb_alarma"
        Me.tb_alarma.Size = New System.Drawing.Size(306, 20)
        Me.tb_alarma.TabIndex = 2
        '
        'pacientes_alarma
        '
        Me.pacientes_alarma.AutoScroll = True
        Me.pacientes_alarma.Controls.Add(Me.GroupBox1)
        Me.pacientes_alarma.Controls.Add(Me.bt_imprimir)
        Me.pacientes_alarma.Controls.Add(Me.bt_ficha)
        Me.pacientes_alarma.Controls.Add(Me.dgv_pacientes)
        Me.pacientes_alarma.Controls.Add(Me.bt_delete)
        Me.pacientes_alarma.Controls.Add(Me.bt_add)
        Me.pacientes_alarma.Location = New System.Drawing.Point(4, 22)
        Me.pacientes_alarma.Name = "pacientes_alarma"
        Me.pacientes_alarma.Padding = New System.Windows.Forms.Padding(3)
        Me.pacientes_alarma.Size = New System.Drawing.Size(662, 389)
        Me.pacientes_alarma.TabIndex = 1
        Me.pacientes_alarma.Text = "Pacientes con alarma activada"
        Me.pacientes_alarma.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_todos)
        Me.GroupBox1.Controls.Add(Me.rb_activo)
        Me.GroupBox1.Controls.Add(Me.rb_inactivo)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 59)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado"
        '
        'rb_todos
        '
        Me.rb_todos.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ALARMASBindingSource, "NIVEL", True))
        Me.rb_todos.Location = New System.Drawing.Point(298, 29)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(69, 24)
        Me.rb_todos.TabIndex = 2
        Me.rb_todos.Text = "Todos"
        '
        'rb_activo
        '
        Me.rb_activo.Checked = True
        Me.rb_activo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ALARMASBindingSource, "NIVEL", True))
        Me.rb_activo.Location = New System.Drawing.Point(6, 29)
        Me.rb_activo.Name = "rb_activo"
        Me.rb_activo.Size = New System.Drawing.Size(58, 24)
        Me.rb_activo.TabIndex = 0
        Me.rb_activo.TabStop = True
        Me.rb_activo.Text = "Activo"
        '
        'rb_inactivo
        '
        Me.rb_inactivo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ALARMASBindingSource, "NIVEL", True))
        Me.rb_inactivo.Location = New System.Drawing.Point(144, 29)
        Me.rb_inactivo.Name = "rb_inactivo"
        Me.rb_inactivo.Size = New System.Drawing.Size(68, 24)
        Me.rb_inactivo.TabIndex = 1
        Me.rb_inactivo.Text = "Inactivo"
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(429, 29)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(90, 32)
        Me.bt_imprimir.TabIndex = 0
        Me.bt_imprimir.Text = "      &Imprimir"
        Me.bt_imprimir.UseVisualStyleBackColor = False
        '
        'bt_ficha
        '
        Me.bt_ficha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_ficha.Image = Global.centro_medico.My.Resources.Resources.folderopen
        Me.bt_ficha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_ficha.Location = New System.Drawing.Point(8, 351)
        Me.bt_ficha.Name = "bt_ficha"
        Me.bt_ficha.Size = New System.Drawing.Size(136, 32)
        Me.bt_ficha.TabIndex = 2
        Me.bt_ficha.Text = "Ficha del Paciente"
        Me.bt_ficha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_ficha.UseVisualStyleBackColor = False
        '
        'dgv_pacientes
        '
        Me.dgv_pacientes.AllowUserToAddRows = False
        Me.dgv_pacientes.AllowUserToDeleteRows = False
        Me.dgv_pacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_pacientes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pacientes.Location = New System.Drawing.Point(3, 73)
        Me.dgv_pacientes.Name = "dgv_pacientes"
        Me.dgv_pacientes.RowHeadersVisible = False
        Me.dgv_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pacientes.Size = New System.Drawing.Size(652, 272)
        Me.dgv_pacientes.TabIndex = 1
        '
        'bt_delete
        '
        Me.bt_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_delete.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_delete.Location = New System.Drawing.Point(620, 360)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(35, 23)
        Me.bt_delete.TabIndex = 4
        Me.bt_delete.UseVisualStyleBackColor = True
        '
        'bt_add
        '
        Me.bt_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_add.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_add.Location = New System.Drawing.Point(579, 360)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(35, 23)
        Me.bt_add.TabIndex = 3
        Me.bt_add.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(592, 426)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 1
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(498, 426)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 0
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'LINEASALARMABindingSource
        '
        Me.LINEASALARMABindingSource.DataMember = "fklineasalarmaalarma"
        Me.LINEASALARMABindingSource.DataSource = Me.ALARMASBindingSource
        '
        'ALARMASTableAdapter
        '
        Me.ALARMASTableAdapter.ClearBeforeFill = True
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'LINEASALARMATableAdapter
        '
        Me.LINEASALARMATableAdapter.ClearBeforeFill = True
        '
        'form_alarmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 459)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Name = "form_alarmas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_alarmas"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_alarma.ResumeLayout(False)
        Me.tab_alarma.PerformLayout()
        Me.gb_niveles.ResumeLayout(False)
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pacientes_alarma.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEASALARMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_alarma As System.Windows.Forms.TabPage
    Friend WithEvents pacientes_alarma As System.Windows.Forms.TabPage
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ALARMASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALARMASTableAdapter As centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter
    Friend WithEvents tb_cod As ctrlTextboxAvanzado
    Friend WithEvents tb_alarma As ctrlTextboxAvanzado
    Friend WithEvents tb_descripc As ctrlTextboxAvanzado
    Friend WithEvents gb_niveles As System.Windows.Forms.GroupBox
    Friend WithEvents rb_baja As System.Windows.Forms.RadioButton
    Friend WithEvents rb_alta As System.Windows.Forms.RadioButton
    Friend WithEvents rb_media As System.Windows.Forms.RadioButton
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents LINEASALARMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEASALARMATableAdapter As centro_medico.CMDataSetTableAdapters.LINEASALARMATableAdapter
    Friend WithEvents dgv_pacientes As System.Windows.Forms.DataGridView
    Friend WithEvents bt_delete As System.Windows.Forms.Button
    Friend WithEvents bt_add As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_todos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_activo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_inactivo As System.Windows.Forms.RadioButton
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents bt_ficha As System.Windows.Forms.Button
End Class
