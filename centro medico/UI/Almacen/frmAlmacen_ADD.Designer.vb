<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmacen_ADD
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Me.tab_Detalles = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.CodigoTextBox = New ctrlTextboxAvanzado
        Me.N_AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.DescripcionTextBox = New ctrlTextboxAvanzado
        Me.ObservacionesTextBox = New ctrlTextboxAvanzado
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.N_AlmacenTableAdapter = New centro_medico.CMDataSetTableAdapters.N_AlmacenTableAdapter
        CodigoLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        ObservacionesLabel = New System.Windows.Forms.Label
        Me.tab_Detalles.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.N_AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(10, 18)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 2
        CodigoLabel.Text = "Codigo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(10, 44)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(10, 70)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 6
        ObservacionesLabel.Text = "Observaciones:"
        '
        'tab_Detalles
        '
        Me.tab_Detalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_Detalles.Controls.Add(Me.TabPage1)
        Me.tab_Detalles.Location = New System.Drawing.Point(2, 8)
        Me.tab_Detalles.Name = "tab_Detalles"
        Me.tab_Detalles.SelectedIndex = 0
        Me.tab_Detalles.Size = New System.Drawing.Size(407, 290)
        Me.tab_Detalles.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(CodigoLabel)
        Me.TabPage1.Controls.Add(Me.CodigoTextBox)
        Me.TabPage1.Controls.Add(DescripcionLabel)
        Me.TabPage1.Controls.Add(Me.DescripcionTextBox)
        Me.TabPage1.Controls.Add(ObservacionesLabel)
        Me.TabPage1.Controls.Add(Me.ObservacionesTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(399, 264)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalles"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_AlmacenBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(97, 15)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 3
        '
        'N_AlmacenBindingSource
        '
        Me.N_AlmacenBindingSource.DataMember = "N_Almacen"
        Me.N_AlmacenBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_AlmacenBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(97, 41)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(272, 20)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_AlmacenBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(97, 70)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(272, 175)
        Me.ObservacionesTextBox.TabIndex = 7
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(332, 301)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 1
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'N_AlmacenTableAdapter
        '
        Me.N_AlmacenTableAdapter.ClearBeforeFill = True
        '
        'frmAlmacen_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 329)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.tab_Detalles)
        Me.Name = "frmAlmacen_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Almacen "
        Me.tab_Detalles.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.N_AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_Detalles As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents N_AlmacenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_AlmacenTableAdapter As centro_medico.CMDataSetTableAdapters.N_AlmacenTableAdapter
    Friend WithEvents CodigoTextBox As ctrlTextboxAvanzado
    Friend WithEvents DescripcionTextBox As ctrlTextboxAvanzado
    Friend WithEvents ObservacionesTextBox As ctrlTextboxAvanzado
End Class
