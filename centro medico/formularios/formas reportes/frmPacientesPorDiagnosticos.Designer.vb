<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientesPorDiagnosticos
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
        Me.components = New System.ComponentModel.Container
        Me.lbldesde = New System.Windows.Forms.Label
        Me.lblhasta = New System.Windows.Forms.Label
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkFiltroFechas = New System.Windows.Forms.CheckBox
        Me.groupDiagnosticos = New System.Windows.Forms.GroupBox
        Me.pb_EliminarDiagnostico = New System.Windows.Forms.Button
        Me.pb_AddDiagnostico = New System.Windows.Forms.Button
        Me.lst_Diagnosticos = New System.Windows.Forms.ListView
        Me.cHeaderDiag = New System.Windows.Forms.ColumnHeader
        Me.cbmDiagnosticos = New System.Windows.Forms.ComboBox
        Me.DIAGNOSTICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.lblDiagnostico = New System.Windows.Forms.Label
        Me.btFiltrar = New System.Windows.Forms.Button
        Me.DIAGNOSTICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter
        Me.RPTPACIENTESPORDIAGNOSTICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptPacientesPorDiagnosticoTableAdapter = New centro_medico.CMDataSetTableAdapters.rptPacientesPorDiagnosticoTableAdapter
        Me.chkFiltroDiagnostico = New System.Windows.Forms.CheckBox
        Me.chk_DiagnosticoPorTermino = New System.Windows.Forms.CheckBox
        Me.grp_FiltroTermino = New System.Windows.Forms.GroupBox
        Me.txt_FiltroDiagnostico = New ctrlTextboxAvanzado
        Me.chk_OrdenarDiagnostico = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rb_FechaDesc = New System.Windows.Forms.RadioButton
        Me.rb_FechaAsc = New System.Windows.Forms.RadioButton
        Me.chk_OrdenarFecha = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.groupDiagnosticos.SuspendLayout()
        CType(Me.DIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RPTPACIENTESPORDIAGNOSTICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_FiltroTermino.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Location = New System.Drawing.Point(4, 19)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(153, 13)
        Me.lbldesde.TabIndex = 0
        Me.lbldesde.Text = "Pacientes dados de alta desde"
        '
        'lblhasta
        '
        Me.lblhasta.AutoSize = True
        Me.lblhasta.Location = New System.Drawing.Point(277, 19)
        Me.lblhasta.Name = "lblhasta"
        Me.lblhasta.Size = New System.Drawing.Size(33, 13)
        Me.lblhasta.TabIndex = 1
        Me.lblhasta.Text = "hasta"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(163, 15)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(98, 20)
        Me.dtpDesde.TabIndex = 2
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(325, 15)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(100, 20)
        Me.dtpHasta.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbldesde)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.lblhasta)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 44)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por Fechas"
        '
        'chkFiltroFechas
        '
        Me.chkFiltroFechas.AutoSize = True
        Me.chkFiltroFechas.Location = New System.Drawing.Point(15, 30)
        Me.chkFiltroFechas.Name = "chkFiltroFechas"
        Me.chkFiltroFechas.Size = New System.Drawing.Size(15, 14)
        Me.chkFiltroFechas.TabIndex = 5
        Me.chkFiltroFechas.UseVisualStyleBackColor = True
        '
        'groupDiagnosticos
        '
        Me.groupDiagnosticos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupDiagnosticos.Controls.Add(Me.pb_EliminarDiagnostico)
        Me.groupDiagnosticos.Controls.Add(Me.pb_AddDiagnostico)
        Me.groupDiagnosticos.Controls.Add(Me.lst_Diagnosticos)
        Me.groupDiagnosticos.Controls.Add(Me.cbmDiagnosticos)
        Me.groupDiagnosticos.Controls.Add(Me.lblDiagnostico)
        Me.groupDiagnosticos.Enabled = False
        Me.groupDiagnosticos.Location = New System.Drawing.Point(36, 62)
        Me.groupDiagnosticos.Name = "groupDiagnosticos"
        Me.groupDiagnosticos.Size = New System.Drawing.Size(448, 260)
        Me.groupDiagnosticos.TabIndex = 6
        Me.groupDiagnosticos.TabStop = False
        Me.groupDiagnosticos.Text = "Filtrar por Diagnóstico"
        '
        'pb_EliminarDiagnostico
        '
        Me.pb_EliminarDiagnostico.Enabled = False
        Me.pb_EliminarDiagnostico.FlatAppearance.BorderSize = 0
        Me.pb_EliminarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pb_EliminarDiagnostico.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.pb_EliminarDiagnostico.Location = New System.Drawing.Point(400, 13)
        Me.pb_EliminarDiagnostico.Name = "pb_EliminarDiagnostico"
        Me.pb_EliminarDiagnostico.Size = New System.Drawing.Size(25, 25)
        Me.pb_EliminarDiagnostico.TabIndex = 4
        Me.pb_EliminarDiagnostico.UseVisualStyleBackColor = True
        '
        'pb_AddDiagnostico
        '
        Me.pb_AddDiagnostico.Enabled = False
        Me.pb_AddDiagnostico.FlatAppearance.BorderSize = 0
        Me.pb_AddDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pb_AddDiagnostico.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.pb_AddDiagnostico.Location = New System.Drawing.Point(373, 13)
        Me.pb_AddDiagnostico.Name = "pb_AddDiagnostico"
        Me.pb_AddDiagnostico.Size = New System.Drawing.Size(25, 25)
        Me.pb_AddDiagnostico.TabIndex = 4
        Me.pb_AddDiagnostico.UseVisualStyleBackColor = True
        '
        'lst_Diagnosticos
        '
        Me.lst_Diagnosticos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_Diagnosticos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cHeaderDiag})
        Me.lst_Diagnosticos.GridLines = True
        Me.lst_Diagnosticos.Location = New System.Drawing.Point(73, 42)
        Me.lst_Diagnosticos.Name = "lst_Diagnosticos"
        Me.lst_Diagnosticos.Size = New System.Drawing.Size(366, 208)
        Me.lst_Diagnosticos.TabIndex = 3
        Me.lst_Diagnosticos.UseCompatibleStateImageBehavior = False
        Me.lst_Diagnosticos.View = System.Windows.Forms.View.Details
        '
        'cHeaderDiag
        '
        Me.cHeaderDiag.Text = ""
        Me.cHeaderDiag.Width = 357
        '
        'cbmDiagnosticos
        '
        Me.cbmDiagnosticos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbmDiagnosticos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbmDiagnosticos.DataSource = Me.DIAGNOSTICOSBindingSource
        Me.cbmDiagnosticos.DisplayMember = "DIAGNOSTICO"
        Me.cbmDiagnosticos.FormattingEnabled = True
        Me.cbmDiagnosticos.Location = New System.Drawing.Point(73, 15)
        Me.cbmDiagnosticos.Name = "cbmDiagnosticos"
        Me.cbmDiagnosticos.Size = New System.Drawing.Size(297, 21)
        Me.cbmDiagnosticos.TabIndex = 1
        Me.cbmDiagnosticos.ValueMember = "IDDIAGNOSTICO"
        '
        'DIAGNOSTICOSBindingSource
        '
        Me.DIAGNOSTICOSBindingSource.DataMember = "DIAGNOSTICOS"
        Me.DIAGNOSTICOSBindingSource.DataSource = Me.CMDataSet
        Me.DIAGNOSTICOSBindingSource.Sort = "DIAGNOSTICO ASC"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblDiagnostico
        '
        Me.lblDiagnostico.AutoSize = True
        Me.lblDiagnostico.Location = New System.Drawing.Point(4, 19)
        Me.lblDiagnostico.Name = "lblDiagnostico"
        Me.lblDiagnostico.Size = New System.Drawing.Size(63, 13)
        Me.lblDiagnostico.TabIndex = 0
        Me.lblDiagnostico.Text = "Diagnostico"
        '
        'btFiltrar
        '
        Me.btFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btFiltrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.btFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btFiltrar.Location = New System.Drawing.Point(576, 12)
        Me.btFiltrar.Name = "btFiltrar"
        Me.btFiltrar.Size = New System.Drawing.Size(75, 44)
        Me.btFiltrar.TabIndex = 8
        Me.btFiltrar.Text = "Filtrar"
        Me.btFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btFiltrar.UseVisualStyleBackColor = True
        '
        'DIAGNOSTICOSTableAdapter
        '
        Me.DIAGNOSTICOSTableAdapter.ClearBeforeFill = True
        '
        'RPTPACIENTESPORDIAGNOSTICOBindingSource
        '
        Me.RPTPACIENTESPORDIAGNOSTICOBindingSource.DataMember = "rptPacientesPorDiagnostico"
        Me.RPTPACIENTESPORDIAGNOSTICOBindingSource.DataSource = Me.CMDataSet
        '
        'RptPacientesPorDiagnosticoTableAdapter
        '
        Me.RptPacientesPorDiagnosticoTableAdapter.ClearBeforeFill = True
        '
        'chkFiltroDiagnostico
        '
        Me.chkFiltroDiagnostico.AutoSize = True
        Me.chkFiltroDiagnostico.Location = New System.Drawing.Point(15, 77)
        Me.chkFiltroDiagnostico.Name = "chkFiltroDiagnostico"
        Me.chkFiltroDiagnostico.Size = New System.Drawing.Size(15, 14)
        Me.chkFiltroDiagnostico.TabIndex = 9
        Me.chkFiltroDiagnostico.UseVisualStyleBackColor = True
        '
        'chk_DiagnosticoPorTermino
        '
        Me.chk_DiagnosticoPorTermino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chk_DiagnosticoPorTermino.AutoSize = True
        Me.chk_DiagnosticoPorTermino.Location = New System.Drawing.Point(15, 346)
        Me.chk_DiagnosticoPorTermino.Name = "chk_DiagnosticoPorTermino"
        Me.chk_DiagnosticoPorTermino.Size = New System.Drawing.Size(15, 14)
        Me.chk_DiagnosticoPorTermino.TabIndex = 10
        Me.chk_DiagnosticoPorTermino.UseVisualStyleBackColor = True
        '
        'grp_FiltroTermino
        '
        Me.grp_FiltroTermino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_FiltroTermino.Controls.Add(Me.txt_FiltroDiagnostico)
        Me.grp_FiltroTermino.Location = New System.Drawing.Point(36, 338)
        Me.grp_FiltroTermino.Name = "grp_FiltroTermino"
        Me.grp_FiltroTermino.Size = New System.Drawing.Size(539, 56)
        Me.grp_FiltroTermino.TabIndex = 11
        Me.grp_FiltroTermino.TabStop = False
        Me.grp_FiltroTermino.Text = "Filtrar por término Diagnóstico"
        '
        'txt_FiltroDiagnostico
        '
        Me.txt_FiltroDiagnostico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FiltroDiagnostico.Location = New System.Drawing.Point(7, 19)
        Me.txt_FiltroDiagnostico.Name = "txt_FiltroDiagnostico"
        Me.txt_FiltroDiagnostico.Size = New System.Drawing.Size(517, 20)
        Me.txt_FiltroDiagnostico.TabIndex = 0
        '
        'chk_OrdenarDiagnostico
        '
        Me.chk_OrdenarDiagnostico.AutoSize = True
        Me.chk_OrdenarDiagnostico.Checked = True
        Me.chk_OrdenarDiagnostico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_OrdenarDiagnostico.Location = New System.Drawing.Point(11, 30)
        Me.chk_OrdenarDiagnostico.Name = "chk_OrdenarDiagnostico"
        Me.chk_OrdenarDiagnostico.Size = New System.Drawing.Size(141, 17)
        Me.chk_OrdenarDiagnostico.TabIndex = 12
        Me.chk_OrdenarDiagnostico.Text = "Ordenar por Diagnóstico"
        Me.chk_OrdenarDiagnostico.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_FechaDesc)
        Me.GroupBox2.Controls.Add(Me.rb_FechaAsc)
        Me.GroupBox2.Controls.Add(Me.chk_OrdenarFecha)
        Me.GroupBox2.Controls.Add(Me.chk_OrdenarDiagnostico)
        Me.GroupBox2.Location = New System.Drawing.Point(490, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 260)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'rb_FechaDesc
        '
        Me.rb_FechaDesc.AutoSize = True
        Me.rb_FechaDesc.Location = New System.Drawing.Point(36, 112)
        Me.rb_FechaDesc.Name = "rb_FechaDesc"
        Me.rb_FechaDesc.Size = New System.Drawing.Size(89, 17)
        Me.rb_FechaDesc.TabIndex = 13
        Me.rb_FechaDesc.Text = "Descendente"
        Me.rb_FechaDesc.UseVisualStyleBackColor = True
        Me.rb_FechaDesc.Visible = False
        '
        'rb_FechaAsc
        '
        Me.rb_FechaAsc.AutoSize = True
        Me.rb_FechaAsc.Checked = True
        Me.rb_FechaAsc.Location = New System.Drawing.Point(36, 89)
        Me.rb_FechaAsc.Name = "rb_FechaAsc"
        Me.rb_FechaAsc.Size = New System.Drawing.Size(82, 17)
        Me.rb_FechaAsc.TabIndex = 13
        Me.rb_FechaAsc.TabStop = True
        Me.rb_FechaAsc.Text = "Ascendente"
        Me.rb_FechaAsc.UseVisualStyleBackColor = True
        Me.rb_FechaAsc.Visible = False
        '
        'chk_OrdenarFecha
        '
        Me.chk_OrdenarFecha.AutoSize = True
        Me.chk_OrdenarFecha.Checked = True
        Me.chk_OrdenarFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_OrdenarFecha.Location = New System.Drawing.Point(11, 66)
        Me.chk_OrdenarFecha.Name = "chk_OrdenarFecha"
        Me.chk_OrdenarFecha.Size = New System.Drawing.Size(115, 17)
        Me.chk_OrdenarFecha.TabIndex = 12
        Me.chk_OrdenarFecha.Text = "Ordenar por Fecha"
        Me.chk_OrdenarFecha.UseVisualStyleBackColor = True
        Me.chk_OrdenarFecha.Visible = False
        '
        'frmPacientesPorDiagnosticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 406)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grp_FiltroTermino)
        Me.Controls.Add(Me.chk_DiagnosticoPorTermino)
        Me.Controls.Add(Me.chkFiltroDiagnostico)
        Me.Controls.Add(Me.btFiltrar)
        Me.Controls.Add(Me.groupDiagnosticos)
        Me.Controls.Add(Me.chkFiltroFechas)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPacientesPorDiagnosticos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes Por Diagnosticos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupDiagnosticos.ResumeLayout(False)
        Me.groupDiagnosticos.PerformLayout()
        CType(Me.DIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RPTPACIENTESPORDIAGNOSTICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_FiltroTermino.ResumeLayout(False)
        Me.grp_FiltroTermino.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldesde As System.Windows.Forms.Label
    Friend WithEvents lblhasta As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFiltroFechas As System.Windows.Forms.CheckBox
    Friend WithEvents cbmDiagnosticos As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiagnostico As System.Windows.Forms.Label
    Friend WithEvents btFiltrar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents DIAGNOSTICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIAGNOSTICOSTableAdapter As centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter
    Friend WithEvents RPTPACIENTESPORDIAGNOSTICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RptPacientesPorDiagnosticoTableAdapter As centro_medico.CMDataSetTableAdapters.rptPacientesPorDiagnosticoTableAdapter
    Friend WithEvents chkFiltroDiagnostico As System.Windows.Forms.CheckBox
    Friend WithEvents lst_Diagnosticos As System.Windows.Forms.ListView
    Friend WithEvents cHeaderDiag As System.Windows.Forms.ColumnHeader
    Friend WithEvents pb_AddDiagnostico As System.Windows.Forms.Button
    Friend WithEvents pb_EliminarDiagnostico As System.Windows.Forms.Button
    Friend WithEvents groupDiagnosticos As System.Windows.Forms.GroupBox
    Friend WithEvents chk_DiagnosticoPorTermino As System.Windows.Forms.CheckBox
    Friend WithEvents grp_FiltroTermino As System.Windows.Forms.GroupBox
    Friend WithEvents txt_FiltroDiagnostico As ctrlTextboxAvanzado
    Friend WithEvents chk_OrdenarDiagnostico As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_FechaDesc As System.Windows.Forms.RadioButton
    Friend WithEvents rb_FechaAsc As System.Windows.Forms.RadioButton
    Friend WithEvents chk_OrdenarFecha As System.Windows.Forms.CheckBox
End Class
