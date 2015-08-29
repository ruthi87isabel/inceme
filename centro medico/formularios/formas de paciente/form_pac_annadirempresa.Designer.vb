<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pac_annadirempresa
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
        Me.lb_AEEmpresa = New System.Windows.Forms.Label
        Me.lb_AEFechabaja = New System.Windows.Forms.Label
        Me.lb_AEFechaalta = New System.Windows.Forms.Label
        Me.lb_AENotas = New System.Windows.Forms.Label
        Me.tb_AEEmpresa = New ctrlTextboxAvanzado
        Me.tb_AENombre = New ctrlTextboxAvanzado
        Me.tb_AENotas = New ctrlTextboxAvanzado
        Me.dtp_AEFechabaja = New System.Windows.Forms.DateTimePicker
        Me.dtp_AEFechaalta = New System.Windows.Forms.DateTimePicker
        Me.bt_AEListarempresas = New System.Windows.Forms.Button
        Me.bt_AEAceptar = New System.Windows.Forms.Button
        Me.bt_AECancelar = New System.Windows.Forms.Button
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
        Me.LMUTUASEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMUTUASEMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.LMUTUASEMPRESASTableAdapter
        Me.LEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LEMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.LEMPRESASTableAdapter
        Me.txtPuesto = New ctrlTextboxAvanzado
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMUTUASEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_AEEmpresa
        '
        Me.lb_AEEmpresa.AutoSize = True
        Me.lb_AEEmpresa.Location = New System.Drawing.Point(9, 11)
        Me.lb_AEEmpresa.Name = "lb_AEEmpresa"
        Me.lb_AEEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.lb_AEEmpresa.TabIndex = 0
        Me.lb_AEEmpresa.Text = "Empresa"
        '
        'lb_AEFechabaja
        '
        Me.lb_AEFechabaja.AutoSize = True
        Me.lb_AEFechabaja.Location = New System.Drawing.Point(142, 79)
        Me.lb_AEFechabaja.Name = "lb_AEFechabaja"
        Me.lb_AEFechabaja.Size = New System.Drawing.Size(61, 13)
        Me.lb_AEFechabaja.TabIndex = 1
        Me.lb_AEFechabaja.Text = "Fecha Baja"
        '
        'lb_AEFechaalta
        '
        Me.lb_AEFechaalta.AutoSize = True
        Me.lb_AEFechaalta.Location = New System.Drawing.Point(9, 79)
        Me.lb_AEFechaalta.Name = "lb_AEFechaalta"
        Me.lb_AEFechaalta.Size = New System.Drawing.Size(58, 13)
        Me.lb_AEFechaalta.TabIndex = 2
        Me.lb_AEFechaalta.Text = "Fecha Alta"
        '
        'lb_AENotas
        '
        Me.lb_AENotas.AutoSize = True
        Me.lb_AENotas.Location = New System.Drawing.Point(9, 121)
        Me.lb_AENotas.Name = "lb_AENotas"
        Me.lb_AENotas.Size = New System.Drawing.Size(35, 13)
        Me.lb_AENotas.TabIndex = 3
        Me.lb_AENotas.Text = "Notas"
        '
        'tb_AEEmpresa
        '
        Me.tb_AEEmpresa.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_AEEmpresa.Location = New System.Drawing.Point(12, 27)
        Me.tb_AEEmpresa.Name = "tb_AEEmpresa"
        Me.tb_AEEmpresa.Size = New System.Drawing.Size(89, 20)
        Me.tb_AEEmpresa.TabIndex = 0
        '
        'tb_AENombre
        '
        Me.tb_AENombre.Enabled = False
        Me.tb_AENombre.Location = New System.Drawing.Point(145, 27)
        Me.tb_AENombre.Name = "tb_AENombre"
        Me.tb_AENombre.Size = New System.Drawing.Size(251, 20)
        Me.tb_AENombre.TabIndex = 2
        '
        'tb_AENotas
        '
        Me.tb_AENotas.Location = New System.Drawing.Point(12, 137)
        Me.tb_AENotas.MaxLength = 150
        Me.tb_AENotas.Multiline = True
        Me.tb_AENotas.Name = "tb_AENotas"
        Me.tb_AENotas.Size = New System.Drawing.Size(384, 119)
        Me.tb_AENotas.TabIndex = 5
        '
        'dtp_AEFechabaja
        '
        Me.dtp_AEFechabaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_AEFechabaja.Location = New System.Drawing.Point(145, 95)
        Me.dtp_AEFechabaja.Name = "dtp_AEFechabaja"
        Me.dtp_AEFechabaja.Size = New System.Drawing.Size(100, 20)
        Me.dtp_AEFechabaja.TabIndex = 4
        '
        'dtp_AEFechaalta
        '
        Me.dtp_AEFechaalta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_AEFechaalta.Location = New System.Drawing.Point(12, 95)
        Me.dtp_AEFechaalta.Name = "dtp_AEFechaalta"
        Me.dtp_AEFechaalta.Size = New System.Drawing.Size(100, 20)
        Me.dtp_AEFechaalta.TabIndex = 3
        '
        'bt_AEListarempresas
        '
        Me.bt_AEListarempresas.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_AEListarempresas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_AEListarempresas.Location = New System.Drawing.Point(107, 21)
        Me.bt_AEListarempresas.Name = "bt_AEListarempresas"
        Me.bt_AEListarempresas.Size = New System.Drawing.Size(32, 31)
        Me.bt_AEListarempresas.TabIndex = 1
        Me.bt_AEListarempresas.UseVisualStyleBackColor = True
        '
        'bt_AEAceptar
        '
        Me.bt_AEAceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_AEAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AEAceptar.Location = New System.Drawing.Point(215, 272)
        Me.bt_AEAceptar.Name = "bt_AEAceptar"
        Me.bt_AEAceptar.Size = New System.Drawing.Size(80, 26)
        Me.bt_AEAceptar.TabIndex = 6
        Me.bt_AEAceptar.Text = "Aceptar"
        Me.bt_AEAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AEAceptar.UseVisualStyleBackColor = True
        '
        'bt_AECancelar
        '
        Me.bt_AECancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_AECancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_AECancelar.Location = New System.Drawing.Point(316, 272)
        Me.bt_AECancelar.Name = "bt_AECancelar"
        Me.bt_AECancelar.Size = New System.Drawing.Size(80, 26)
        Me.bt_AECancelar.TabIndex = 7
        Me.bt_AECancelar.Text = "Cancelar"
        Me.bt_AECancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_AECancelar.UseVisualStyleBackColor = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'EMPRESASTableAdapter
        '
        Me.EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'LMUTUASEMPRESASBindingSource
        '
        Me.LMUTUASEMPRESASBindingSource.DataMember = "LMUTUASEMPRESAS"
        Me.LMUTUASEMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'LMUTUASEMPRESASTableAdapter
        '
        Me.LMUTUASEMPRESASTableAdapter.ClearBeforeFill = True
        '
        'LEMPRESASBindingSource
        '
        Me.LEMPRESASBindingSource.DataMember = "LEMPRESAS"
        Me.LEMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'LEMPRESASTableAdapter
        '
        Me.LEMPRESASTableAdapter.ClearBeforeFill = True
        '
        'txtPuesto
        '
        Me.txtPuesto.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPuesto.Location = New System.Drawing.Point(145, 55)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(251, 20)
        Me.txtPuesto.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Puesto de Trabajo :"
        '
        'form_pac_annadirempresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(405, 300)
        Me.Controls.Add(Me.txtPuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_AECancelar)
        Me.Controls.Add(Me.bt_AEAceptar)
        Me.Controls.Add(Me.bt_AEListarempresas)
        Me.Controls.Add(Me.dtp_AEFechaalta)
        Me.Controls.Add(Me.dtp_AEFechabaja)
        Me.Controls.Add(Me.tb_AENotas)
        Me.Controls.Add(Me.tb_AENombre)
        Me.Controls.Add(Me.tb_AEEmpresa)
        Me.Controls.Add(Me.lb_AENotas)
        Me.Controls.Add(Me.lb_AEFechaalta)
        Me.Controls.Add(Me.lb_AEFechabaja)
        Me.Controls.Add(Me.lb_AEEmpresa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "form_pac_annadirempresa"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ficha empresa - Añadir"
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMUTUASEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_AEEmpresa As System.Windows.Forms.Label
    Friend WithEvents lb_AEFechabaja As System.Windows.Forms.Label
    Friend WithEvents lb_AEFechaalta As System.Windows.Forms.Label
    Friend WithEvents lb_AENotas As System.Windows.Forms.Label
    Friend WithEvents tb_AEEmpresa As ctrlTextboxAvanzado
    Friend WithEvents tb_AENombre As ctrlTextboxAvanzado
    Friend WithEvents tb_AENotas As ctrlTextboxAvanzado
    Friend WithEvents dtp_AEFechabaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_AEFechaalta As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_AEListarempresas As System.Windows.Forms.Button
    Friend WithEvents bt_AEAceptar As System.Windows.Forms.Button
    Friend WithEvents bt_AECancelar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents LMUTUASEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LMUTUASEMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.LMUTUASEMPRESASTableAdapter
    Friend WithEvents LEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LEMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.LEMPRESASTableAdapter
    Friend WithEvents txtPuesto As ctrlTextboxAvanzado
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
