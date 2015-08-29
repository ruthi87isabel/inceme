<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComoConocio_ADD
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbFicha = New System.Windows.Forms.TabPage
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.DescripcionTextBox = New ctrlTextboxAvanzado
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.ComoConocioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComoConocioTableAdapter = New centro_medico.CMDataSetTableAdapters.ComoConocioTableAdapter
        DescripcionLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tbFicha.SuspendLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComoConocioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(21, 27)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(63, 13)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripción"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbFicha)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(342, 136)
        Me.TabControl1.TabIndex = 0
        '
        'tbFicha
        '
        Me.tbFicha.AutoScroll = True
        Me.tbFicha.Controls.Add(DescripcionLabel)
        Me.tbFicha.Controls.Add(Me.DescripcionTextBox)
        Me.tbFicha.Location = New System.Drawing.Point(4, 22)
        Me.tbFicha.Name = "tbFicha"
        Me.tbFicha.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFicha.Size = New System.Drawing.Size(334, 110)
        Me.tbFicha.TabIndex = 0
        Me.tbFicha.Text = "Ficha"
        Me.tbFicha.UseVisualStyleBackColor = True
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComoConocioBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(24, 43)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(272, 20)
        Me.DescripcionTextBox.TabIndex = 3
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(268, 140)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 1
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'ComoConocioBindingSource
        '
        Me.ComoConocioBindingSource.DataMember = "ComoConocio"
        Me.ComoConocioBindingSource.DataSource = Me.CMDataSet
        '
        'ComoConocioTableAdapter
        '
        Me.ComoConocioTableAdapter.ClearBeforeFill = True
        '
        'frmPoblaciones_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 169)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmPoblaciones_ADD"
        Me.Text = "Modificar ComoConocio"
        Me.TabControl1.ResumeLayout(False)
        Me.tbFicha.ResumeLayout(False)
        Me.tbFicha.PerformLayout()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComoConocioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbFicha As System.Windows.Forms.TabPage
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents DescripcionTextBox As ctrlTextboxAvanzado
    Friend WithEvents ComoConocioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComoConocioTableAdapter As centro_medico.CMDataSetTableAdapters.ComoConocioTableAdapter
End Class

