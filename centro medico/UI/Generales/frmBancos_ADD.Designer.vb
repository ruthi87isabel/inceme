<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBancos_ADD
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim IBANLabel As System.Windows.Forms.Label
        Dim SWIFTLabel As System.Windows.Forms.Label
        Me.grpDetalles = New System.Windows.Forms.GroupBox
        Me.CtrlPoblacion1 = New centro_medico.ctrlPoblacion
        Me.N_BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox
        Me.IBANTextBox = New System.Windows.Forms.TextBox
        Me.SWIFTTextBox = New System.Windows.Forms.TextBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.N_BancosTableAdapter = New centro_medico.CMDataSetTableAdapters.N_BancosTableAdapter
        CodigoLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        DomicilioLabel = New System.Windows.Forms.Label
        IBANLabel = New System.Windows.Forms.Label
        SWIFTLabel = New System.Windows.Forms.Label
        Me.grpDetalles.SuspendLayout()
        CType(Me.N_BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(39, 30)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 11
        CodigoLabel.Text = "Codigo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(29, 60)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'DomicilioLabel
        '
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Location = New System.Drawing.Point(297, 53)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(52, 13)
        DomicilioLabel.TabIndex = 6
        DomicilioLabel.Text = "Domicilio:"
        '
        'IBANLabel
        '
        IBANLabel.AutoSize = True
        IBANLabel.Location = New System.Drawing.Point(41, 91)
        IBANLabel.Name = "IBANLabel"
        IBANLabel.Size = New System.Drawing.Size(35, 13)
        IBANLabel.TabIndex = 8
        IBANLabel.Text = "IBAN:"
        '
        'SWIFTLabel
        '
        SWIFTLabel.AutoSize = True
        SWIFTLabel.Location = New System.Drawing.Point(32, 117)
        SWIFTLabel.Name = "SWIFTLabel"
        SWIFTLabel.Size = New System.Drawing.Size(44, 13)
        SWIFTLabel.TabIndex = 10
        SWIFTLabel.Text = "SWIFT:"
        '
        'grpDetalles
        '
        Me.grpDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetalles.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpDetalles.Controls.Add(Me.CtrlPoblacion1)
        Me.grpDetalles.Controls.Add(CodigoLabel)
        Me.grpDetalles.Controls.Add(Me.CodigoTextBox)
        Me.grpDetalles.Controls.Add(NombreLabel)
        Me.grpDetalles.Controls.Add(Me.NombreTextBox)
        Me.grpDetalles.Controls.Add(DomicilioLabel)
        Me.grpDetalles.Controls.Add(Me.DomicilioTextBox)
        Me.grpDetalles.Controls.Add(IBANLabel)
        Me.grpDetalles.Controls.Add(Me.IBANTextBox)
        Me.grpDetalles.Controls.Add(SWIFTLabel)
        Me.grpDetalles.Controls.Add(Me.SWIFTTextBox)
        Me.grpDetalles.Location = New System.Drawing.Point(2, 1)
        Me.grpDetalles.Name = "grpDetalles"
        Me.grpDetalles.Size = New System.Drawing.Size(608, 157)
        Me.grpDetalles.TabIndex = 3
        Me.grpDetalles.TabStop = False
        Me.grpDetalles.Text = "Detalles"
        '
        'CtrlPoblacion1
        '
        Me.CtrlPoblacion1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Poblacion", Me.N_BancosBindingSource, "ID_Poblacion", True))
        Me.CtrlPoblacion1.ID_Poblacion = Nothing
        Me.CtrlPoblacion1.Location = New System.Drawing.Point(296, 19)
        Me.CtrlPoblacion1.Name = "CtrlPoblacion1"
        Me.CtrlPoblacion1.Size = New System.Drawing.Size(294, 27)
        Me.CtrlPoblacion1.TabIndex = 13
        '
        'N_BancosBindingSource
        '
        Me.N_BancosBindingSource.DataMember = "N_Bancos"
        Me.N_BancosBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_BancosBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(88, 27)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(80, 20)
        Me.CodigoTextBox.TabIndex = 12
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_BancosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(88, 57)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(176, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_BancosBindingSource, "Domicilio", True))
        Me.DomicilioTextBox.Location = New System.Drawing.Point(355, 53)
        Me.DomicilioTextBox.Multiline = True
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(234, 42)
        Me.DomicilioTextBox.TabIndex = 7
        '
        'IBANTextBox
        '
        Me.IBANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_BancosBindingSource, "IBAN", True))
        Me.IBANTextBox.Location = New System.Drawing.Point(88, 88)
        Me.IBANTextBox.Name = "IBANTextBox"
        Me.IBANTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IBANTextBox.TabIndex = 9
        '
        'SWIFTTextBox
        '
        Me.SWIFTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.N_BancosBindingSource, "SWIFT", True))
        Me.SWIFTTextBox.Location = New System.Drawing.Point(88, 114)
        Me.SWIFTTextBox.Name = "SWIFTTextBox"
        Me.SWIFTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SWIFTTextBox.TabIndex = 11
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(535, 159)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 4
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'N_BancosTableAdapter
        '
        Me.N_BancosTableAdapter.ClearBeforeFill = True
        '
        'frmBancos_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 184)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.grpDetalles)
        Me.Name = "frmBancos_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Banco"
        Me.grpDetalles.ResumeLayout(False)
        Me.grpDetalles.PerformLayout()
        CType(Me.N_BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DomicilioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IBANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SWIFTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents CtrlPoblacion1 As ctrlPoblacion
    Friend WithEvents CMDataSet As CMDataSet
    Friend WithEvents N_BancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_BancosTableAdapter As CMDataSetTableAdapters.N_BancosTableAdapter
End Class
