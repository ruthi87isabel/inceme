<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlVisorHistoria
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.RichTextBox1 = New ctrlRichTextBoxAvanzado
        Me.Historial_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.HISTORIALESTableAdapter = New centro_medico.CMDataSetTableAdapters.HISTORIALESTableAdapter
        Me.Diagnostico_BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIAGNOSTICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter
        Me.Medicos_BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Paciente_BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Me.MEDICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
        Me.HISTORIALESDIAGNOSTICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistorialesDiagnosticosTableAdapter = New centro_medico.CMDataSetTableAdapters.HistorialesDiagnosticosTableAdapter
        CType(Me.Historial_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diagnostico_BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medicos_BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paciente_BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HISTORIALESDIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(424, 625)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Historial_BindingSource
        '
        Me.Historial_BindingSource.DataMember = "HISTORIALES"
        Me.Historial_BindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HISTORIALESTableAdapter
        '
        Me.HISTORIALESTableAdapter.ClearBeforeFill = True
        '
        'Diagnostico_BindingSource1
        '
        Me.Diagnostico_BindingSource1.DataMember = "DIAGNOSTICOS"
        Me.Diagnostico_BindingSource1.DataSource = Me.CMDataSet
        '
        'DIAGNOSTICOSTableAdapter
        '
        Me.DIAGNOSTICOSTableAdapter.ClearBeforeFill = True
        '
        'Medicos_BindingSource1
        '
        Me.Medicos_BindingSource1.DataMember = "MEDICOS"
        Me.Medicos_BindingSource1.DataSource = Me.CMDataSet
        '
        'Paciente_BindingSource1
        '
        Me.Paciente_BindingSource1.DataMember = "PACIENTES"
        Me.Paciente_BindingSource1.DataSource = Me.CMDataSet
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'HISTORIALESDIAGNOSTICOSBindingSource
        '
        Me.HISTORIALESDIAGNOSTICOSBindingSource.DataMember = "HistorialesDiagnosticos"
        Me.HISTORIALESDIAGNOSTICOSBindingSource.DataSource = Me.CMDataSet
        '
        'HistorialesDiagnosticosTableAdapter
        '
        Me.HistorialesDiagnosticosTableAdapter.ClearBeforeFill = True
        '
        'ctrlVisorHistoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "ctrlVisorHistoria"
        Me.Size = New System.Drawing.Size(430, 631)
        CType(Me.Historial_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diagnostico_BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medicos_BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paciente_BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HISTORIALESDIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As ctrlRichTextBoxAvanzado
    Friend WithEvents Historial_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents HISTORIALESTableAdapter As centro_medico.CMDataSetTableAdapters.HISTORIALESTableAdapter
    Friend WithEvents Diagnostico_BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DIAGNOSTICOSTableAdapter As centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter
    Friend WithEvents Medicos_BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Paciente_BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents MEDICOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents HISTORIALESDIAGNOSTICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HistorialesDiagnosticosTableAdapter As centro_medico.CMDataSetTableAdapters.HistorialesDiagnosticosTableAdapter

End Class
