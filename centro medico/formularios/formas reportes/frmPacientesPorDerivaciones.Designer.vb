<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientesPorDerivaciones
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
        Me.DERIVACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkFiltroFechas = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbmDerivaciones = New System.Windows.Forms.ComboBox
        Me.DERIVACIONESDESTINOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDiagnostico = New System.Windows.Forms.Label
        Me.btFiltrar = New System.Windows.Forms.Button
        Me.chkFiltroDiagnostico = New System.Windows.Forms.CheckBox
        Me.DERIVACIONESTableAdapter = New centro_medico.CMDataSetTableAdapters.DERIVACIONESTableAdapter
        Me.RptPacientesPorDerivacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptPacientesPorDerivacionTableAdapter = New centro_medico.CMDataSetTableAdapters.rptPacientesPorDerivacionTableAdapter
        Me.DERIVACIONES_DESTINOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DERIVACIONES_DESTINOSTableAdapter
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rb_FechaDesc = New System.Windows.Forms.RadioButton
        Me.rb_FechaAsc = New System.Windows.Forms.RadioButton
        Me.chk_OrdenarFecha = New System.Windows.Forms.CheckBox
        Me.chk_OrdenarDiagnostico = New System.Windows.Forms.CheckBox
        CType(Me.DERIVACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DERIVACIONESDESTINOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptPacientesPorDerivacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Location = New System.Drawing.Point(34, 19)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(101, 13)
        Me.lbldesde.TabIndex = 0
        Me.lbldesde.Text = "Derivaciones desde"
        '
        'lblhasta
        '
        Me.lblhasta.AutoSize = True
        Me.lblhasta.Location = New System.Drawing.Point(275, 19)
        Me.lblhasta.Name = "lblhasta"
        Me.lblhasta.Size = New System.Drawing.Size(33, 13)
        Me.lblhasta.TabIndex = 1
        Me.lblhasta.Text = "hasta"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(161, 15)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(98, 20)
        Me.dtpDesde.TabIndex = 2
        '
        'DERIVACIONESBindingSource
        '
        Me.DERIVACIONESBindingSource.DataMember = "DERIVACIONES"
        Me.DERIVACIONESBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(323, 15)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbmDerivaciones)
        Me.GroupBox2.Controls.Add(Me.lblDiagnostico)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 44)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar por Destino"
        '
        'cbmDerivaciones
        '
        Me.cbmDerivaciones.DataSource = Me.DERIVACIONESDESTINOSBindingSource
        Me.cbmDerivaciones.DisplayMember = "NOMBRE"
        Me.cbmDerivaciones.FormattingEnabled = True
        Me.cbmDerivaciones.Location = New System.Drawing.Point(73, 15)
        Me.cbmDerivaciones.Name = "cbmDerivaciones"
        Me.cbmDerivaciones.Size = New System.Drawing.Size(352, 21)
        Me.cbmDerivaciones.TabIndex = 1
        Me.cbmDerivaciones.ValueMember = "CODIGO"
        '
        'DERIVACIONESDESTINOSBindingSource
        '
        Me.DERIVACIONESDESTINOSBindingSource.DataMember = "DERIVACIONES_DESTINOS"
        Me.DERIVACIONESDESTINOSBindingSource.DataSource = Me.CMDataSet
        '
        'lblDiagnostico
        '
        Me.lblDiagnostico.AutoSize = True
        Me.lblDiagnostico.Location = New System.Drawing.Point(15, 18)
        Me.lblDiagnostico.Name = "lblDiagnostico"
        Me.lblDiagnostico.Size = New System.Drawing.Size(43, 13)
        Me.lblDiagnostico.TabIndex = 0
        Me.lblDiagnostico.Text = "Destino"
        '
        'btFiltrar
        '
        Me.btFiltrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.btFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btFiltrar.Location = New System.Drawing.Point(401, 112)
        Me.btFiltrar.Name = "btFiltrar"
        Me.btFiltrar.Size = New System.Drawing.Size(75, 44)
        Me.btFiltrar.TabIndex = 8
        Me.btFiltrar.Text = "Filtrar"
        Me.btFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btFiltrar.UseVisualStyleBackColor = True
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
        'DERIVACIONESTableAdapter
        '
        Me.DERIVACIONESTableAdapter.ClearBeforeFill = True
        '
        'RptPacientesPorDerivacionBindingSource
        '
        Me.RptPacientesPorDerivacionBindingSource.DataMember = "rptPacientesPorDerivacion"
        Me.RptPacientesPorDerivacionBindingSource.DataSource = Me.CMDataSet
        '
        'RptPacientesPorDerivacionTableAdapter
        '
        Me.RptPacientesPorDerivacionTableAdapter.ClearBeforeFill = True
        '
        'DERIVACIONES_DESTINOSTableAdapter
        '
        Me.DERIVACIONES_DESTINOSTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_FechaDesc)
        Me.GroupBox3.Controls.Add(Me.rb_FechaAsc)
        Me.GroupBox3.Controls.Add(Me.chk_OrdenarFecha)
        Me.GroupBox3.Controls.Add(Me.chk_OrdenarDiagnostico)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(329, 108)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'rb_FechaDesc
        '
        Me.rb_FechaDesc.AutoSize = True
        Me.rb_FechaDesc.Location = New System.Drawing.Point(40, 67)
        Me.rb_FechaDesc.Name = "rb_FechaDesc"
        Me.rb_FechaDesc.Size = New System.Drawing.Size(89, 17)
        Me.rb_FechaDesc.TabIndex = 13
        Me.rb_FechaDesc.Text = "Descendente"
        Me.rb_FechaDesc.UseVisualStyleBackColor = True
        '
        'rb_FechaAsc
        '
        Me.rb_FechaAsc.AutoSize = True
        Me.rb_FechaAsc.Checked = True
        Me.rb_FechaAsc.Location = New System.Drawing.Point(40, 44)
        Me.rb_FechaAsc.Name = "rb_FechaAsc"
        Me.rb_FechaAsc.Size = New System.Drawing.Size(82, 17)
        Me.rb_FechaAsc.TabIndex = 13
        Me.rb_FechaAsc.TabStop = True
        Me.rb_FechaAsc.Text = "Ascendente"
        Me.rb_FechaAsc.UseVisualStyleBackColor = True
        '
        'chk_OrdenarFecha
        '
        Me.chk_OrdenarFecha.AutoSize = True
        Me.chk_OrdenarFecha.Checked = True
        Me.chk_OrdenarFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_OrdenarFecha.Location = New System.Drawing.Point(14, 19)
        Me.chk_OrdenarFecha.Name = "chk_OrdenarFecha"
        Me.chk_OrdenarFecha.Size = New System.Drawing.Size(115, 17)
        Me.chk_OrdenarFecha.TabIndex = 12
        Me.chk_OrdenarFecha.Text = "Ordenar por Fecha"
        Me.chk_OrdenarFecha.UseVisualStyleBackColor = True
        '
        'chk_OrdenarDiagnostico
        '
        Me.chk_OrdenarDiagnostico.AutoSize = True
        Me.chk_OrdenarDiagnostico.Checked = True
        Me.chk_OrdenarDiagnostico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_OrdenarDiagnostico.Location = New System.Drawing.Point(158, 19)
        Me.chk_OrdenarDiagnostico.Name = "chk_OrdenarDiagnostico"
        Me.chk_OrdenarDiagnostico.Size = New System.Drawing.Size(147, 17)
        Me.chk_OrdenarDiagnostico.TabIndex = 12
        Me.chk_OrdenarDiagnostico.Text = "Ordenar por Derivaciones"
        Me.chk_OrdenarDiagnostico.UseVisualStyleBackColor = True
        '
        'frmPacientesPorDerivaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 233)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chkFiltroDiagnostico)
        Me.Controls.Add(Me.btFiltrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkFiltroFechas)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPacientesPorDerivaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes Por Derivaciones"
        CType(Me.DERIVACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DERIVACIONESDESTINOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptPacientesPorDerivacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldesde As System.Windows.Forms.Label
    Friend WithEvents lblhasta As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFiltroFechas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbmDerivaciones As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiagnostico As System.Windows.Forms.Label
    Friend WithEvents btFiltrar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents chkFiltroDiagnostico As System.Windows.Forms.CheckBox
    Friend WithEvents DERIVACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DERIVACIONESTableAdapter As centro_medico.CMDataSetTableAdapters.DERIVACIONESTableAdapter
    Friend WithEvents RptPacientesPorDerivacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RptPacientesPorDerivacionTableAdapter As centro_medico.CMDataSetTableAdapters.rptPacientesPorDerivacionTableAdapter
    Friend WithEvents DERIVACIONESDESTINOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DERIVACIONES_DESTINOSTableAdapter As centro_medico.CMDataSetTableAdapters.DERIVACIONES_DESTINOSTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_FechaDesc As System.Windows.Forms.RadioButton
    Friend WithEvents rb_FechaAsc As System.Windows.Forms.RadioButton
    Friend WithEvents chk_OrdenarFecha As System.Windows.Forms.CheckBox
    Friend WithEvents chk_OrdenarDiagnostico As System.Windows.Forms.CheckBox
End Class
