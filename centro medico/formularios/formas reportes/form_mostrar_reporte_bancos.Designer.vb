<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_mostrar_reporte_bancos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.BANCOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.BANCOSTableAdapter = New centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter
        CType(Me.BANCOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BANCOSBindingSource
        '
        Me.BANCOSBindingSource.DataMember = "BANCOS"
        Me.BANCOSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer
        '
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CMDataSet_BANCOS"
        ReportDataSource1.Value = Me.BANCOSBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "centro_medico.Bancos.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(292, 266)
        Me.ReportViewer.TabIndex = 0
        '
        'BANCOSTableAdapter
        '
        Me.BANCOSTableAdapter.ClearBeforeFill = True
        '
        'form_mostrar_reporte_bancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "form_mostrar_reporte_bancos"
        Me.ShowIcon = False
        Me.Text = "Listado de bancos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BANCOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BANCOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents BANCOSTableAdapter As centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter
End Class
