<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_mostrar_reporte_forma_pagos
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
        Me.FORMASPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.FORMASPAGOTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FORMASPAGOBindingSource
        '
        Me.FORMASPAGOBindingSource.DataMember = "FORMASPAGO"
        Me.FORMASPAGOBindingSource.DataSource = Me.CMDataSet
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
        ReportDataSource1.Name = "CMDataSet_FORMASPAGO"
        ReportDataSource1.Value = Me.FORMASPAGOBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "centro_medico.FormasPago.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(292, 266)
        Me.ReportViewer.TabIndex = 0
        '
        'FORMASPAGOTableAdapter
        '
        Me.FORMASPAGOTableAdapter.ClearBeforeFill = True
        '
        'form_mostrar_reporte_forma_pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "form_mostrar_reporte_forma_pagos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vista Previa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FORMASPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
End Class
