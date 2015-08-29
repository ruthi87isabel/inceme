<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlCliente
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlCliente))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Cliente = New ctrlTextboxAvanzado
        Me.pb_SeleccionarCliente = New System.Windows.Forms.PictureBox
        Me.PacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        CType(Me.pb_SeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Cliente:"
        '
        'txt_Cliente
        '
        Me.txt_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cliente.Location = New System.Drawing.Point(43, 4)
        Me.txt_Cliente.Name = "txt_Cliente"
        Me.txt_Cliente.ReadOnly = True
        Me.txt_Cliente.Size = New System.Drawing.Size(196, 20)
        Me.txt_Cliente.TabIndex = 84
        '
        'pb_SeleccionarCliente
        '
        Me.pb_SeleccionarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_SeleccionarCliente.Image = CType(resources.GetObject("pb_SeleccionarCliente.Image"), System.Drawing.Image)
        Me.pb_SeleccionarCliente.Location = New System.Drawing.Point(240, 0)
        Me.pb_SeleccionarCliente.Name = "pb_SeleccionarCliente"
        Me.pb_SeleccionarCliente.Size = New System.Drawing.Size(24, 24)
        Me.pb_SeleccionarCliente.TabIndex = 86
        Me.pb_SeleccionarCliente.TabStop = False
        '
        'PacienteBindingSource
        '
        Me.PacienteBindingSource.DataMember = "PACIENTES"
        Me.PacienteBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'ctrlCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pb_SeleccionarCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Cliente)
        Me.Name = "ctrlCliente"
        Me.Size = New System.Drawing.Size(265, 29)
        CType(Me.pb_SeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_SeleccionarCliente As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Cliente As ctrlTextboxAvanzado
    Friend WithEvents PacienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter

End Class
