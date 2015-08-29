<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartesAsistencia
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartesAsistencia))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_Final = New System.Windows.Forms.CheckBox()
        Me.chk_FechaInicio = New System.Windows.Forms.CheckBox()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.btn_Filtrar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CM3DataSet = New centro_medico.CM3DataSet()
        Me.N_Partes_AsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_Partes_AsistenciaTableAdapter = New centro_medico.CM3DataSetTableAdapters.N_Partes_AsistenciaTableAdapter()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.NPartesAsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CM3DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlPaciente1 = New centro_medico.ctrlPaciente()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Partes_AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPartesAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM3DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(822, 25)
        Me.ToolStrip1.TabIndex = 116
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.NewToolStripButton.Text = "&Añadir"
        '
        'tst_Editar
        '
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar.Text = "&Modificar"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar.Text = "&Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_Final)
        Me.GroupBox2.Controls.Add(Me.chk_FechaInicio)
        Me.GroupBox2.Controls.Add(Me.dtp_ff)
        Me.GroupBox2.Controls.Add(Me.dtp_fi)
        Me.GroupBox2.Location = New System.Drawing.Point(431, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 66)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas"
        '
        'chk_Final
        '
        Me.chk_Final.AutoSize = True
        Me.chk_Final.Location = New System.Drawing.Point(144, 20)
        Me.chk_Final.Name = "chk_Final"
        Me.chk_Final.Size = New System.Drawing.Size(54, 17)
        Me.chk_Final.TabIndex = 2
        Me.chk_Final.Text = "Hasta"
        Me.chk_Final.UseVisualStyleBackColor = True
        '
        'chk_FechaInicio
        '
        Me.chk_FechaInicio.AutoSize = True
        Me.chk_FechaInicio.Location = New System.Drawing.Point(12, 19)
        Me.chk_FechaInicio.Name = "chk_FechaInicio"
        Me.chk_FechaInicio.Size = New System.Drawing.Size(57, 17)
        Me.chk_FechaInicio.TabIndex = 2
        Me.chk_FechaInicio.Text = "Desde"
        Me.chk_FechaInicio.UseVisualStyleBackColor = True
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Enabled = False
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(144, 39)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(113, 20)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Enabled = False
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(12, 39)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(113, 20)
        Me.dtp_fi.TabIndex = 0
        '
        'btn_Filtrar
        '
        Me.btn_Filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom_actual
        Me.btn_Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Filtrar.Location = New System.Drawing.Point(703, 45)
        Me.btn_Filtrar.Name = "btn_Filtrar"
        Me.btn_Filtrar.Size = New System.Drawing.Size(75, 40)
        Me.btn_Filtrar.TabIndex = 115
        Me.btn_Filtrar.Text = "Filtrar"
        Me.btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Filtrar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 573)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(822, 22)
        Me.StatusStrip1.TabIndex = 117
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'CM3DataSet
        '
        Me.CM3DataSet.DataSetName = "CM3DataSet"
        Me.CM3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_Partes_AsistenciaBindingSource
        '
        Me.N_Partes_AsistenciaBindingSource.DataMember = "N_Partes_Asistencia"
        Me.N_Partes_AsistenciaBindingSource.DataSource = Me.CM3DataSet
        '
        'N_Partes_AsistenciaTableAdapter
        '
        Me.N_Partes_AsistenciaTableAdapter.ClearBeforeFill = True
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataMember = Nothing
        Me.GridEX1.DataSource = Me.N_Partes_AsistenciaBindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.[Default]
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 91)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(822, 479)
        Me.GridEX1.TabIndex = 120
        '
        'NPartesAsistenciaBindingSource
        '
        Me.NPartesAsistenciaBindingSource.DataMember = "N_Partes_Asistencia"
        Me.NPartesAsistenciaBindingSource.DataSource = Me.CM3DataSet
        '
        'CM3DataSetBindingSource
        '
        Me.CM3DataSetBindingSource.DataSource = Me.CM3DataSet
        Me.CM3DataSetBindingSource.Position = 0
        '
        'CtrlPaciente1
        '
        Me.CtrlPaciente1.ID_PACIENTE = Nothing
        Me.CtrlPaciente1.Location = New System.Drawing.Point(12, 28)
        Me.CtrlPaciente1.Name = "CtrlPaciente1"
        Me.CtrlPaciente1.Size = New System.Drawing.Size(370, 53)
        Me.CtrlPaciente1.TabIndex = 114
        '
        'frmPartesAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 595)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_Filtrar)
        Me.Controls.Add(Me.CtrlPaciente1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.KeyPreview = True
        Me.Name = "frmPartesAsistencia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Partes Asistencia"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Partes_AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPartesAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM3DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Final As System.Windows.Forms.CheckBox
    Friend WithEvents chk_FechaInicio As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Filtrar As System.Windows.Forms.Button
    Friend WithEvents CtrlPaciente1 As centro_medico.ctrlPaciente
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CM3DataSet As centro_medico.CM3DataSet
    Friend WithEvents N_Partes_AsistenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Partes_AsistenciaTableAdapter As centro_medico.CM3DataSetTableAdapters.N_Partes_AsistenciaTableAdapter
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents NPartesAsistenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CM3DataSetBindingSource As System.Windows.Forms.BindingSource
End Class
