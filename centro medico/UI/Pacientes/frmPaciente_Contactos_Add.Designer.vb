<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaciente_Contactos_Add
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
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim MovilLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim ParentescoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Me.ContactosPacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApellidosTextBox = New ctrlTextboxAvanzado
        Me.CPTextBox = New ctrlTextboxAvanzado
        Me.DireccionTextBox = New ctrlTextboxAvanzado
        Me.EmailTextBox = New ctrlTextboxAvanzado
        Me.FaxTextBox = New ctrlTextboxAvanzado
        Me.LocalidadTextBox = New ctrlTextboxAvanzado
        Me.MovilTextBox = New ctrlTextboxAvanzado
        Me.NombreTextBox = New ctrlTextboxAvanzado
        Me.NotasTextBox = New ctrlTextboxAvanzado
        Me.PaisTextBox = New ctrlTextboxAvanzado
        Me.ParentescoTextBox = New ctrlTextboxAvanzado
        Me.TelefonoTextBox = New ctrlTextboxAvanzado
        Me.btnGuardar = New System.Windows.Forms.Button
        ApellidosLabel = New System.Windows.Forms.Label
        CPLabel = New System.Windows.Forms.Label
        DireccionLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        FaxLabel = New System.Windows.Forms.Label
        LocalidadLabel = New System.Windows.Forms.Label
        MovilLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        NotasLabel = New System.Windows.Forms.Label
        PaisLabel = New System.Windows.Forms.Label
        ParentescoLabel = New System.Windows.Forms.Label
        TelefonoLabel = New System.Windows.Forms.Label
        CType(Me.ContactosPacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(26, 49)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(52, 13)
        ApellidosLabel.TabIndex = 1
        ApellidosLabel.Text = "Apellidos:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(205, 167)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 3
        CPLabel.Text = "CP:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(23, 115)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 7
        DireccionLabel.Text = "Direccion:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(43, 207)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(52, 262)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 11
        FaxLabel.Text = "Fax:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(26, 141)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(56, 13)
        LocalidadLabel.TabIndex = 15
        LocalidadLabel.Text = "Localidad:"
        '
        'MovilLabel
        '
        MovilLabel.AutoSize = True
        MovilLabel.Location = New System.Drawing.Point(259, 236)
        MovilLabel.Name = "MovilLabel"
        MovilLabel.Size = New System.Drawing.Size(35, 13)
        MovilLabel.TabIndex = 17
        MovilLabel.Text = "Movil:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(31, 23)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 19
        NombreLabel.Text = "Nombre:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Location = New System.Drawing.Point(39, 298)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(38, 13)
        NotasLabel.TabIndex = 21
        NotasLabel.Text = "Notas:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(48, 167)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 23
        PaisLabel.Text = "Pais:"
        '
        'ParentescoLabel
        '
        ParentescoLabel.AutoSize = True
        ParentescoLabel.Location = New System.Drawing.Point(13, 75)
        ParentescoLabel.Name = "ParentescoLabel"
        ParentescoLabel.Size = New System.Drawing.Size(64, 13)
        ParentescoLabel.TabIndex = 25
        ParentescoLabel.Text = "Parentesco:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(27, 236)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 27
        TelefonoLabel.Text = "Telefono:"
        '
        'ContactosPacienteBindingSource
        '
        Me.ContactosPacienteBindingSource.DataSource = GetType(centro_medico.ContactosPaciente)
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(84, 46)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(150, 20)
        Me.ApellidosTextBox.TabIndex = 1
        '
        'CPTextBox
        '
        Me.CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "CP", True))
        Me.CPTextBox.Location = New System.Drawing.Point(235, 164)
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPTextBox.TabIndex = 6
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(84, 112)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(318, 20)
        Me.DireccionTextBox.TabIndex = 3
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(84, 204)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(193, 20)
        Me.EmailTextBox.TabIndex = 7
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(85, 259)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(150, 20)
        Me.FaxTextBox.TabIndex = 10
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(84, 138)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(226, 20)
        Me.LocalidadTextBox.TabIndex = 4
        '
        'MovilTextBox
        '
        Me.MovilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Movil", True))
        Me.MovilTextBox.Location = New System.Drawing.Point(300, 233)
        Me.MovilTextBox.Name = "MovilTextBox"
        Me.MovilTextBox.Size = New System.Drawing.Size(126, 20)
        Me.MovilTextBox.TabIndex = 9
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(84, 20)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(150, 20)
        Me.NombreTextBox.TabIndex = 0
        '
        'NotasTextBox
        '
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Notas", True))
        Me.NotasTextBox.Location = New System.Drawing.Point(83, 295)
        Me.NotasTextBox.Multiline = True
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(343, 107)
        Me.NotasTextBox.TabIndex = 11
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(84, 164)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 5
        '
        'ParentescoTextBox
        '
        Me.ParentescoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Parentesco", True))
        Me.ParentescoTextBox.Location = New System.Drawing.Point(84, 72)
        Me.ParentescoTextBox.Name = "ParentescoTextBox"
        Me.ParentescoTextBox.Size = New System.Drawing.Size(182, 20)
        Me.ParentescoTextBox.TabIndex = 2
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosPacienteBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(85, 233)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(351, 413)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmPaciente_Contactos_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(446, 448)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(CPLabel)
        Me.Controls.Add(Me.CPTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextBox)
        Me.Controls.Add(LocalidadLabel)
        Me.Controls.Add(Me.LocalidadTextBox)
        Me.Controls.Add(MovilLabel)
        Me.Controls.Add(Me.MovilTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(NotasLabel)
        Me.Controls.Add(Me.NotasTextBox)
        Me.Controls.Add(PaisLabel)
        Me.Controls.Add(Me.PaisTextBox)
        Me.Controls.Add(ParentescoLabel)
        Me.Controls.Add(Me.ParentescoTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Name = "frmPaciente_Contactos_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Contacto"
        CType(Me.ContactosPacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactosPacienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApellidosTextBox As ctrlTextboxAvanzado
    Friend WithEvents CPTextBox As ctrlTextboxAvanzado
    Friend WithEvents DireccionTextBox As ctrlTextboxAvanzado
    Friend WithEvents EmailTextBox As ctrlTextboxAvanzado
    Friend WithEvents FaxTextBox As ctrlTextboxAvanzado
    Friend WithEvents LocalidadTextBox As ctrlTextboxAvanzado
    Friend WithEvents MovilTextBox As ctrlTextboxAvanzado
    Friend WithEvents NombreTextBox As ctrlTextboxAvanzado
    Friend WithEvents NotasTextBox As ctrlTextboxAvanzado
    Friend WithEvents PaisTextBox As ctrlTextboxAvanzado
    Friend WithEvents ParentescoTextBox As ctrlTextboxAvanzado
    Friend WithEvents TelefonoTextBox As ctrlTextboxAvanzado
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
