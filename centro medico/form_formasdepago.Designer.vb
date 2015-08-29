<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_formasdepago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim lb_fpCodigo As System.Windows.Forms.Label
        Dim lb_dpEdadhlaboral As System.Windows.Forms.Label
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.pn_fpCodigo = New System.Windows.Forms.Panel
        Me.tb_fpCodigo = New ctrlTextboxAvanzado
        Me.bt_fpBuscarcodigo = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CtrlCuentaBancaria1 = New centro_medico.ctrlCuentaBancaria
        Me.tb_fpEntidadbancaria = New ctrlTextboxAvanzado
        Me.lb_fpEntidadbancaria = New System.Windows.Forms.Label
        Me.tb_fpTitularCuentaORecibo = New ctrlTextboxAvanzado
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lb_fpTitularCuentaORecibo = New System.Windows.Forms.Label
        Me.bt_fpCuenta = New System.Windows.Forms.Button
        Me.chb_fpPagobanco = New System.Windows.Forms.CheckBox
        Me.tb_fpDescrip = New ctrlTextboxAvanzado
        Me.FORMASPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FORMASPAGOTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
        Me.BANCOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BANCOSTableAdapter = New centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.gb_Principales = New System.Windows.Forms.GroupBox
        Me.tb_dpEdadhactual = New ctrlTextboxAvanzado
        Me.bt_Factura = New System.Windows.Forms.Button
        Me.tb_Nombre = New ctrlTextboxAvanzado
        Me.tb_SegundoAp = New ctrlTextboxAvanzado
        Me.tb_PrimerAp = New ctrlTextboxAvanzado
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker
        Me.lb_FechaIngreso = New System.Windows.Forms.Label
        Me.lb_Nombre = New System.Windows.Forms.Label
        Me.lb_SegundoAp = New System.Windows.Forms.Label
        Me.lb_PrimerAp = New System.Windows.Forms.Label
        lb_fpCodigo = New System.Windows.Forms.Label
        lb_dpEdadhlaboral = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.pn_fpCodigo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BANCOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Principales.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_fpCodigo
        '
        lb_fpCodigo.AutoSize = True
        lb_fpCodigo.Location = New System.Drawing.Point(37, 124)
        lb_fpCodigo.Name = "lb_fpCodigo"
        lb_fpCodigo.Size = New System.Drawing.Size(84, 13)
        lb_fpCodigo.TabIndex = 22
        lb_fpCodigo.Text = "Formas de Pago"
        '
        'lb_dpEdadhlaboral
        '
        lb_dpEdadhlaboral.AutoSize = True
        lb_dpEdadhlaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_dpEdadhlaboral.Location = New System.Drawing.Point(585, 9)
        lb_dpEdadhlaboral.Name = "lb_dpEdadhlaboral"
        lb_dpEdadhlaboral.Size = New System.Drawing.Size(35, 13)
        lb_dpEdadhlaboral.TabIndex = 37
        lb_dpEdadhlaboral.Text = "Edad:"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(855, 25)
        Me.ToolStrip2.TabIndex = 21
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Gu&ardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Can&celar"
        '
        'pn_fpCodigo
        '
        Me.pn_fpCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_fpCodigo.Controls.Add(Me.tb_fpCodigo)
        Me.pn_fpCodigo.Controls.Add(Me.bt_fpBuscarcodigo)
        Me.pn_fpCodigo.Location = New System.Drawing.Point(40, 140)
        Me.pn_fpCodigo.Name = "pn_fpCodigo"
        Me.pn_fpCodigo.Size = New System.Drawing.Size(179, 25)
        Me.pn_fpCodigo.TabIndex = 25
        '
        'tb_fpCodigo
        '
        Me.tb_fpCodigo.BackColor = System.Drawing.Color.White
        Me.tb_fpCodigo.Location = New System.Drawing.Point(1, 1)
        Me.tb_fpCodigo.Name = "tb_fpCodigo"
        Me.tb_fpCodigo.Size = New System.Drawing.Size(146, 20)
        Me.tb_fpCodigo.TabIndex = 0
        '
        'bt_fpBuscarcodigo
        '
        Me.bt_fpBuscarcodigo.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_fpBuscarcodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_fpBuscarcodigo.Location = New System.Drawing.Point(146, -1)
        Me.bt_fpBuscarcodigo.Name = "bt_fpBuscarcodigo"
        Me.bt_fpBuscarcodigo.Size = New System.Drawing.Size(29, 23)
        Me.bt_fpBuscarcodigo.TabIndex = 1
        Me.bt_fpBuscarcodigo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CtrlCuentaBancaria1)
        Me.Panel1.Controls.Add(Me.tb_fpEntidadbancaria)
        Me.Panel1.Controls.Add(Me.lb_fpEntidadbancaria)
        Me.Panel1.Controls.Add(Me.tb_fpTitularCuentaORecibo)
        Me.Panel1.Controls.Add(Me.lb_fpTitularCuentaORecibo)
        Me.Panel1.Controls.Add(Me.bt_fpCuenta)
        Me.Panel1.Controls.Add(Me.chb_fpPagobanco)
        Me.Panel1.Location = New System.Drawing.Point(40, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(731, 118)
        Me.Panel1.TabIndex = 24
        '
        'CtrlCuentaBancaria1
        '
        Me.CtrlCuentaBancaria1.Cuenta = "0000000000"
        Me.CtrlCuentaBancaria1.CUENTABANCO = "000000000000000000"
        Me.CtrlCuentaBancaria1.DataBindings.Add(New System.Windows.Forms.Binding("Cuenta", Me.PACIENTESBindingSource, "CUENTA", True))
        Me.CtrlCuentaBancaria1.DataBindings.Add(New System.Windows.Forms.Binding("DC", Me.PACIENTESBindingSource, "DC", True))
        Me.CtrlCuentaBancaria1.DataBindings.Add(New System.Windows.Forms.Binding("Entidad", Me.PACIENTESBindingSource, "ENTIDAD", True))
        Me.CtrlCuentaBancaria1.DataBindings.Add(New System.Windows.Forms.Binding("Oficina", Me.PACIENTESBindingSource, "OFICINA", True))
        Me.CtrlCuentaBancaria1.DC = ""
        Me.CtrlCuentaBancaria1.Entidad = "0000"
        Me.CtrlCuentaBancaria1.Location = New System.Drawing.Point(147, 13)
        Me.CtrlCuentaBancaria1.Name = "CtrlCuentaBancaria1"
        Me.CtrlCuentaBancaria1.Oficina = "0000"
        Me.CtrlCuentaBancaria1.Size = New System.Drawing.Size(231, 39)
        Me.CtrlCuentaBancaria1.TabIndex = 14
        '
        'tb_fpEntidadbancaria
        '
        Me.tb_fpEntidadbancaria.BackColor = System.Drawing.Color.White
        Me.tb_fpEntidadbancaria.Location = New System.Drawing.Point(418, 84)
        Me.tb_fpEntidadbancaria.MaxLength = 10
        Me.tb_fpEntidadbancaria.Name = "tb_fpEntidadbancaria"
        Me.tb_fpEntidadbancaria.ReadOnly = True
        Me.tb_fpEntidadbancaria.Size = New System.Drawing.Size(285, 20)
        Me.tb_fpEntidadbancaria.TabIndex = 13
        '
        'lb_fpEntidadbancaria
        '
        Me.lb_fpEntidadbancaria.AutoSize = True
        Me.lb_fpEntidadbancaria.Location = New System.Drawing.Point(415, 68)
        Me.lb_fpEntidadbancaria.Name = "lb_fpEntidadbancaria"
        Me.lb_fpEntidadbancaria.Size = New System.Drawing.Size(88, 13)
        Me.lb_fpEntidadbancaria.TabIndex = 12
        Me.lb_fpEntidadbancaria.Text = "Entidad Bancaria"
        '
        'tb_fpTitularCuentaORecibo
        '
        Me.tb_fpTitularCuentaORecibo.BackColor = System.Drawing.Color.White
        Me.tb_fpTitularCuentaORecibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "TITULAR", True))
        Me.tb_fpTitularCuentaORecibo.Location = New System.Drawing.Point(15, 84)
        Me.tb_fpTitularCuentaORecibo.MaxLength = 90
        Me.tb_fpTitularCuentaORecibo.Name = "tb_fpTitularCuentaORecibo"
        Me.tb_fpTitularCuentaORecibo.Size = New System.Drawing.Size(385, 20)
        Me.tb_fpTitularCuentaORecibo.TabIndex = 12
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'lb_fpTitularCuentaORecibo
        '
        Me.lb_fpTitularCuentaORecibo.AutoSize = True
        Me.lb_fpTitularCuentaORecibo.Location = New System.Drawing.Point(12, 68)
        Me.lb_fpTitularCuentaORecibo.Name = "lb_fpTitularCuentaORecibo"
        Me.lb_fpTitularCuentaORecibo.Size = New System.Drawing.Size(195, 13)
        Me.lb_fpTitularCuentaORecibo.TabIndex = 10
        Me.lb_fpTitularCuentaORecibo.Text = "Titular de la cuenta / titular para recibos"
        '
        'bt_fpCuenta
        '
        Me.bt_fpCuenta.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_fpCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_fpCuenta.Location = New System.Drawing.Point(381, 25)
        Me.bt_fpCuenta.Name = "bt_fpCuenta"
        Me.bt_fpCuenta.Size = New System.Drawing.Size(29, 23)
        Me.bt_fpCuenta.TabIndex = 11
        Me.bt_fpCuenta.UseVisualStyleBackColor = True
        '
        'chb_fpPagobanco
        '
        Me.chb_fpPagobanco.AutoSize = True
        Me.chb_fpPagobanco.Location = New System.Drawing.Point(15, 25)
        Me.chb_fpPagobanco.Name = "chb_fpPagobanco"
        Me.chb_fpPagobanco.Size = New System.Drawing.Size(84, 17)
        Me.chb_fpPagobanco.TabIndex = 6
        Me.chb_fpPagobanco.Text = "Pago banco"
        Me.chb_fpPagobanco.UseVisualStyleBackColor = True
        '
        'tb_fpDescrip
        '
        Me.tb_fpDescrip.BackColor = System.Drawing.Color.White
        Me.tb_fpDescrip.Location = New System.Drawing.Point(275, 144)
        Me.tb_fpDescrip.Name = "tb_fpDescrip"
        Me.tb_fpDescrip.ReadOnly = True
        Me.tb_fpDescrip.Size = New System.Drawing.Size(496, 20)
        Me.tb_fpDescrip.TabIndex = 23
        '
        'FORMASPAGOBindingSource
        '
        Me.FORMASPAGOBindingSource.DataMember = "FORMASPAGO"
        Me.FORMASPAGOBindingSource.DataSource = Me.CMDataSet
        '
        'FORMASPAGOTableAdapter
        '
        Me.FORMASPAGOTableAdapter.ClearBeforeFill = True
        '
        'BANCOSBindingSource
        '
        Me.BANCOSBindingSource.DataMember = "BANCOS"
        Me.BANCOSBindingSource.DataSource = Me.CMDataSet
        '
        'BANCOSTableAdapter
        '
        Me.BANCOSTableAdapter.ClearBeforeFill = True
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'gb_Principales
        '
        Me.gb_Principales.Controls.Add(Me.tb_dpEdadhactual)
        Me.gb_Principales.Controls.Add(lb_dpEdadhlaboral)
        Me.gb_Principales.Controls.Add(Me.bt_Factura)
        Me.gb_Principales.Controls.Add(Me.tb_Nombre)
        Me.gb_Principales.Controls.Add(Me.tb_SegundoAp)
        Me.gb_Principales.Controls.Add(Me.tb_PrimerAp)
        Me.gb_Principales.Controls.Add(Me.dtp_FechaIngreso)
        Me.gb_Principales.Controls.Add(Me.lb_FechaIngreso)
        Me.gb_Principales.Controls.Add(Me.lb_Nombre)
        Me.gb_Principales.Controls.Add(Me.lb_SegundoAp)
        Me.gb_Principales.Controls.Add(Me.lb_PrimerAp)
        Me.gb_Principales.Location = New System.Drawing.Point(103, 41)
        Me.gb_Principales.Name = "gb_Principales"
        Me.gb_Principales.Size = New System.Drawing.Size(649, 47)
        Me.gb_Principales.TabIndex = 42
        Me.gb_Principales.TabStop = False
        Me.gb_Principales.Visible = False
        '
        'tb_dpEdadhactual
        '
        Me.tb_dpEdadhactual.Enabled = False
        Me.tb_dpEdadhactual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dpEdadhactual.Location = New System.Drawing.Point(588, 22)
        Me.tb_dpEdadhactual.Name = "tb_dpEdadhactual"
        Me.tb_dpEdadhactual.ReadOnly = True
        Me.tb_dpEdadhactual.Size = New System.Drawing.Size(39, 20)
        Me.tb_dpEdadhactual.TabIndex = 36
        '
        'bt_Factura
        '
        Me.bt_Factura.BackgroundImage = Global.centro_medico.My.Resources.Resources.Facturas
        Me.bt_Factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_Factura.Location = New System.Drawing.Point(813, 51)
        Me.bt_Factura.Name = "bt_Factura"
        Me.bt_Factura.Size = New System.Drawing.Size(35, 29)
        Me.bt_Factura.TabIndex = 12
        Me.bt_Factura.UseVisualStyleBackColor = True
        '
        'tb_Nombre
        '
        Me.tb_Nombre.BackColor = System.Drawing.SystemColors.Info
        Me.tb_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NOMBRE", True))
        Me.tb_Nombre.Location = New System.Drawing.Point(319, 23)
        Me.tb_Nombre.MaxLength = 25
        Me.tb_Nombre.Name = "tb_Nombre"
        Me.tb_Nombre.ReadOnly = True
        Me.tb_Nombre.Size = New System.Drawing.Size(152, 20)
        Me.tb_Nombre.TabIndex = 9
        '
        'tb_SegundoAp
        '
        Me.tb_SegundoAp.BackColor = System.Drawing.Color.White
        Me.tb_SegundoAp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO2", True))
        Me.tb_SegundoAp.Location = New System.Drawing.Point(171, 23)
        Me.tb_SegundoAp.MaxLength = 15
        Me.tb_SegundoAp.Name = "tb_SegundoAp"
        Me.tb_SegundoAp.ReadOnly = True
        Me.tb_SegundoAp.Size = New System.Drawing.Size(144, 20)
        Me.tb_SegundoAp.TabIndex = 8
        '
        'tb_PrimerAp
        '
        Me.tb_PrimerAp.BackColor = System.Drawing.Color.White
        Me.tb_PrimerAp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "APELLIDO1", True))
        Me.tb_PrimerAp.Location = New System.Drawing.Point(46, 23)
        Me.tb_PrimerAp.MaxLength = 15
        Me.tb_PrimerAp.Name = "tb_PrimerAp"
        Me.tb_PrimerAp.ReadOnly = True
        Me.tb_PrimerAp.Size = New System.Drawing.Size(121, 20)
        Me.tb_PrimerAp.TabIndex = 7
        '
        'dtp_FechaIngreso
        '
        Me.dtp_FechaIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PACIENTESBindingSource, "FECHAALTA", True))
        Me.dtp_FechaIngreso.Enabled = False
        Me.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaIngreso.Location = New System.Drawing.Point(485, 23)
        Me.dtp_FechaIngreso.Name = "dtp_FechaIngreso"
        Me.dtp_FechaIngreso.Size = New System.Drawing.Size(94, 20)
        Me.dtp_FechaIngreso.TabIndex = 11
        Me.dtp_FechaIngreso.Value = New Date(2009, 6, 10, 0, 0, 0, 0)
        '
        'lb_FechaIngreso
        '
        Me.lb_FechaIngreso.AutoSize = True
        Me.lb_FechaIngreso.Location = New System.Drawing.Point(483, 9)
        Me.lb_FechaIngreso.Name = "lb_FechaIngreso"
        Me.lb_FechaIngreso.Size = New System.Drawing.Size(75, 13)
        Me.lb_FechaIngreso.TabIndex = 4
        Me.lb_FechaIngreso.Text = "Fecha Ingreso"
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.Location = New System.Drawing.Point(318, 9)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lb_Nombre.TabIndex = 3
        Me.lb_Nombre.Text = "Nombre"
        '
        'lb_SegundoAp
        '
        Me.lb_SegundoAp.AutoSize = True
        Me.lb_SegundoAp.Location = New System.Drawing.Point(173, 8)
        Me.lb_SegundoAp.Name = "lb_SegundoAp"
        Me.lb_SegundoAp.Size = New System.Drawing.Size(90, 13)
        Me.lb_SegundoAp.TabIndex = 2
        Me.lb_SegundoAp.Text = "Segundo Apellido"
        '
        'lb_PrimerAp
        '
        Me.lb_PrimerAp.AutoSize = True
        Me.lb_PrimerAp.Location = New System.Drawing.Point(47, 8)
        Me.lb_PrimerAp.Name = "lb_PrimerAp"
        Me.lb_PrimerAp.Size = New System.Drawing.Size(76, 13)
        Me.lb_PrimerAp.TabIndex = 1
        Me.lb_PrimerAp.Text = "Primer Apellido"
        '
        'form_formasdepago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(855, 492)
        Me.Controls.Add(Me.gb_Principales)
        Me.Controls.Add(Me.pn_fpCodigo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tb_fpDescrip)
        Me.Controls.Add(lb_fpCodigo)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "form_formasdepago"
        Me.ShowInTaskbar = False
        Me.Text = "FORMAS DE PAGO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.pn_fpCodigo.ResumeLayout(False)
        Me.pn_fpCodigo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BANCOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Principales.ResumeLayout(False)
        Me.gb_Principales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pn_fpCodigo As System.Windows.Forms.Panel
    Friend WithEvents tb_fpCodigo As ctrlTextboxAvanzado
    Friend WithEvents bt_fpBuscarcodigo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tb_fpEntidadbancaria As ctrlTextboxAvanzado
    Friend WithEvents lb_fpEntidadbancaria As System.Windows.Forms.Label
    Friend WithEvents tb_fpTitularCuentaORecibo As ctrlTextboxAvanzado
    Friend WithEvents lb_fpTitularCuentaORecibo As System.Windows.Forms.Label
    Friend WithEvents bt_fpCuenta As System.Windows.Forms.Button
    Friend WithEvents chb_fpPagobanco As System.Windows.Forms.CheckBox
    Friend WithEvents tb_fpDescrip As ctrlTextboxAvanzado
    Friend WithEvents FORMASPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
    Friend WithEvents BANCOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BANCOSTableAdapter As centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents gb_Principales As System.Windows.Forms.GroupBox
    Friend WithEvents tb_dpEdadhactual As ctrlTextboxAvanzado
    Friend WithEvents bt_Factura As System.Windows.Forms.Button
    Friend WithEvents tb_Nombre As ctrlTextboxAvanzado
    Friend WithEvents tb_SegundoAp As ctrlTextboxAvanzado
    Friend WithEvents tb_PrimerAp As ctrlTextboxAvanzado
    Friend WithEvents dtp_FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_FechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lb_Nombre As System.Windows.Forms.Label
    Friend WithEvents lb_SegundoAp As System.Windows.Forms.Label
    Friend WithEvents lb_PrimerAp As System.Windows.Forms.Label
    Friend WithEvents CtrlCuentaBancaria1 As centro_medico.ctrlCuentaBancaria
End Class
