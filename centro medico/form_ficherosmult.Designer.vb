<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_ficherosmult
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
        Dim lb_dpEdadhlaboral As System.Windows.Forms.Label
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.lb_teclas = New System.Windows.Forms.Label
        Me.dtg_fmFicheros = New System.Windows.Forms.DataGridView
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.gb_fmOrdenarpor = New System.Windows.Forms.GroupBox
        Me.rb_fmCreacion = New System.Windows.Forms.RadioButton
        Me.rb_fmModificacion = New System.Windows.Forms.RadioButton
        Me.rb_fmFichero = New System.Windows.Forms.RadioButton
        Me.rb_fmDescripcion = New System.Windows.Forms.RadioButton
        Me.tb_fmBorrar = New System.Windows.Forms.Button
        Me.bt_fmEditar = New System.Windows.Forms.Button
        Me.bt_fmAnnadir = New System.Windows.Forms.Button
        Me.lblInfoFicherosMultimedia = New System.Windows.Forms.Label
        Me.FICHEROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FICHEROSTableAdapter = New centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        lb_dpEdadhlaboral = New System.Windows.Forms.Label
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dtg_fmFicheros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_fmOrdenarpor.SuspendLayout()
        CType(Me.FICHEROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Principales.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tsbGuardar.Text = "&Guardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Can&celar"
        '
        'lb_teclas
        '
        Me.lb_teclas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_teclas.AutoSize = True
        Me.lb_teclas.Location = New System.Drawing.Point(35, 494)
        Me.lb_teclas.Name = "lb_teclas"
        Me.lb_teclas.Size = New System.Drawing.Size(343, 13)
        Me.lb_teclas.TabIndex = 23
        Me.lb_teclas.Text = "Alt A=Añadir; Alt B=Borrar; Alt E=Editar; Alt+G=Guardar; Alt+C=Cancelar"
        '
        'dtg_fmFicheros
        '
        Me.dtg_fmFicheros.AllowUserToAddRows = False
        Me.dtg_fmFicheros.AllowUserToDeleteRows = False
        Me.dtg_fmFicheros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtg_fmFicheros.BackgroundColor = System.Drawing.Color.White
        Me.dtg_fmFicheros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_fmFicheros.Location = New System.Drawing.Point(5, 147)
        Me.dtg_fmFicheros.MultiSelect = False
        Me.dtg_fmFicheros.Name = "dtg_fmFicheros"
        Me.dtg_fmFicheros.ReadOnly = True
        Me.dtg_fmFicheros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_fmFicheros.Size = New System.Drawing.Size(325, 284)
        Me.dtg_fmFicheros.TabIndex = 29
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(337, 78)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(513, 383)
        Me.WebBrowser1.TabIndex = 28
        '
        'gb_fmOrdenarpor
        '
        Me.gb_fmOrdenarpor.Controls.Add(Me.rb_fmCreacion)
        Me.gb_fmOrdenarpor.Controls.Add(Me.rb_fmModificacion)
        Me.gb_fmOrdenarpor.Controls.Add(Me.rb_fmFichero)
        Me.gb_fmOrdenarpor.Controls.Add(Me.rb_fmDescripcion)
        Me.gb_fmOrdenarpor.Location = New System.Drawing.Point(5, 70)
        Me.gb_fmOrdenarpor.Name = "gb_fmOrdenarpor"
        Me.gb_fmOrdenarpor.Size = New System.Drawing.Size(326, 71)
        Me.gb_fmOrdenarpor.TabIndex = 24
        Me.gb_fmOrdenarpor.TabStop = False
        Me.gb_fmOrdenarpor.Text = "Ordenar por:"
        '
        'rb_fmCreacion
        '
        Me.rb_fmCreacion.AutoSize = True
        Me.rb_fmCreacion.Location = New System.Drawing.Point(177, 44)
        Me.rb_fmCreacion.Name = "rb_fmCreacion"
        Me.rb_fmCreacion.Size = New System.Drawing.Size(67, 17)
        Me.rb_fmCreacion.TabIndex = 4
        Me.rb_fmCreacion.TabStop = True
        Me.rb_fmCreacion.Text = "Creación"
        Me.rb_fmCreacion.UseVisualStyleBackColor = True
        '
        'rb_fmModificacion
        '
        Me.rb_fmModificacion.AutoSize = True
        Me.rb_fmModificacion.Location = New System.Drawing.Point(177, 19)
        Me.rb_fmModificacion.Name = "rb_fmModificacion"
        Me.rb_fmModificacion.Size = New System.Drawing.Size(85, 17)
        Me.rb_fmModificacion.TabIndex = 3
        Me.rb_fmModificacion.TabStop = True
        Me.rb_fmModificacion.Text = "Modificación"
        Me.rb_fmModificacion.UseVisualStyleBackColor = True
        '
        'rb_fmFichero
        '
        Me.rb_fmFichero.AutoSize = True
        Me.rb_fmFichero.Location = New System.Drawing.Point(9, 44)
        Me.rb_fmFichero.Name = "rb_fmFichero"
        Me.rb_fmFichero.Size = New System.Drawing.Size(60, 17)
        Me.rb_fmFichero.TabIndex = 2
        Me.rb_fmFichero.TabStop = True
        Me.rb_fmFichero.Text = "Fichero"
        Me.rb_fmFichero.UseVisualStyleBackColor = True
        '
        'rb_fmDescripcion
        '
        Me.rb_fmDescripcion.AutoSize = True
        Me.rb_fmDescripcion.Location = New System.Drawing.Point(9, 19)
        Me.rb_fmDescripcion.Name = "rb_fmDescripcion"
        Me.rb_fmDescripcion.Size = New System.Drawing.Size(81, 17)
        Me.rb_fmDescripcion.TabIndex = 1
        Me.rb_fmDescripcion.TabStop = True
        Me.rb_fmDescripcion.Text = "Descripción"
        Me.rb_fmDescripcion.UseVisualStyleBackColor = True
        '
        'tb_fmBorrar
        '
        Me.tb_fmBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tb_fmBorrar.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC19
        Me.tb_fmBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tb_fmBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fmBorrar.Location = New System.Drawing.Point(268, 437)
        Me.tb_fmBorrar.Name = "tb_fmBorrar"
        Me.tb_fmBorrar.Size = New System.Drawing.Size(38, 26)
        Me.tb_fmBorrar.TabIndex = 27
        Me.tb_fmBorrar.UseVisualStyleBackColor = True
        '
        'bt_fmEditar
        '
        Me.bt_fmEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_fmEditar.BackgroundImage = Global.centro_medico.My.Resources.Resources.up
        Me.bt_fmEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_fmEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_fmEditar.Location = New System.Drawing.Point(217, 437)
        Me.bt_fmEditar.Name = "bt_fmEditar"
        Me.bt_fmEditar.Size = New System.Drawing.Size(38, 26)
        Me.bt_fmEditar.TabIndex = 26
        Me.bt_fmEditar.UseVisualStyleBackColor = True
        '
        'bt_fmAnnadir
        '
        Me.bt_fmAnnadir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_fmAnnadir.BackgroundImage = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_fmAnnadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_fmAnnadir.Location = New System.Drawing.Point(166, 437)
        Me.bt_fmAnnadir.Name = "bt_fmAnnadir"
        Me.bt_fmAnnadir.Size = New System.Drawing.Size(38, 26)
        Me.bt_fmAnnadir.TabIndex = 25
        Me.bt_fmAnnadir.UseVisualStyleBackColor = True
        '
        'lblInfoFicherosMultimedia
        '
        Me.lblInfoFicherosMultimedia.AutoSize = True
        Me.lblInfoFicherosMultimedia.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblInfoFicherosMultimedia.Location = New System.Drawing.Point(462, 239)
        Me.lblInfoFicherosMultimedia.Name = "lblInfoFicherosMultimedia"
        Me.lblInfoFicherosMultimedia.Size = New System.Drawing.Size(271, 13)
        Me.lblInfoFicherosMultimedia.TabIndex = 30
        Me.lblInfoFicherosMultimedia.Text = "NO SE ENCUENTRA EL FICHERO SELECCIONADO..."
        Me.lblInfoFicherosMultimedia.Visible = False
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
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
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
        Me.gb_Principales.Location = New System.Drawing.Point(103, 25)
        Me.gb_Principales.Name = "gb_Principales"
        Me.gb_Principales.Size = New System.Drawing.Size(649, 47)
        Me.gb_Principales.TabIndex = 40
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
        'form_ficherosmult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(855, 509)
        Me.Controls.Add(Me.gb_Principales)
        Me.Controls.Add(Me.lblInfoFicherosMultimedia)
        Me.Controls.Add(Me.dtg_fmFicheros)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.gb_fmOrdenarpor)
        Me.Controls.Add(Me.tb_fmBorrar)
        Me.Controls.Add(Me.bt_fmEditar)
        Me.Controls.Add(Me.bt_fmAnnadir)
        Me.Controls.Add(Me.lb_teclas)
        Me.Controls.Add(Me.ToolStrip2)
        Me.KeyPreview = True
        Me.Name = "form_ficherosmult"
        Me.ShowInTaskbar = False
        Me.Text = "FICHEROS MULTIMEDIA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dtg_fmFicheros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_fmOrdenarpor.ResumeLayout(False)
        Me.gb_fmOrdenarpor.PerformLayout()
        CType(Me.FICHEROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Principales.ResumeLayout(False)
        Me.gb_Principales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lb_teclas As System.Windows.Forms.Label
    Friend WithEvents dtg_fmFicheros As System.Windows.Forms.DataGridView
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents gb_fmOrdenarpor As System.Windows.Forms.GroupBox
    Friend WithEvents rb_fmCreacion As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fmModificacion As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fmFichero As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fmDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents tb_fmBorrar As System.Windows.Forms.Button
    Friend WithEvents bt_fmEditar As System.Windows.Forms.Button
    Friend WithEvents bt_fmAnnadir As System.Windows.Forms.Button
    Friend WithEvents lblInfoFicherosMultimedia As System.Windows.Forms.Label
    Friend WithEvents FICHEROSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FICHEROSTableAdapter As centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
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
End Class
