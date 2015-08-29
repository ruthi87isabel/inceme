<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios_ADD
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
        Me.components = New System.ComponentModel.Container()
        Dim USUARIOLabel As System.Windows.Forms.Label
        Dim CONTRASENALabel As System.Windows.Forms.Label
        Dim NOMBRECOMPLETOLabel As System.Windows.Forms.Label
        Dim REFMEDICOLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim lblCertificado As System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tb_Ficha = New System.Windows.Forms.TabPage()
        Me.tb_CertificadoPath = New centro_medico.ctrlTextboxAvanzado()
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.bt_Certificado = New System.Windows.Forms.Button()
        Me.ROLESComboBox = New System.Windows.Forms.ComboBox()
        Me.ROLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkEsmedico = New System.Windows.Forms.CheckBox()
        Me.grpMedicos = New System.Windows.Forms.GroupBox()
        Me.MEDICOSComboBox = New System.Windows.Forms.ComboBox()
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.RepetirContrasenna = New centro_medico.ctrlTextboxAvanzado()
        Me.CONTRASENATextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.NOMBRECOMPLETOTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.USUARIOSTableAdapter = New centro_medico.CMDataSetTableAdapters.USUARIOSTableAdapter()
        Me.MEDICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter()
        Me.ROLESTableAdapter = New centro_medico.CMDataSetTableAdapters.ROLESTableAdapter()
        USUARIOLabel = New System.Windows.Forms.Label()
        CONTRASENALabel = New System.Windows.Forms.Label()
        NOMBRECOMPLETOLabel = New System.Windows.Forms.Label()
        REFMEDICOLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        lblCertificado = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tb_Ficha.SuspendLayout()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMedicos.SuspendLayout()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USUARIOLabel
        '
        USUARIOLabel.AutoSize = True
        USUARIOLabel.Location = New System.Drawing.Point(61, 27)
        USUARIOLabel.Name = "USUARIOLabel"
        USUARIOLabel.Size = New System.Drawing.Size(46, 13)
        USUARIOLabel.TabIndex = 2
        USUARIOLabel.Text = "Usuario:"
        '
        'CONTRASENALabel
        '
        CONTRASENALabel.AutoSize = True
        CONTRASENALabel.Location = New System.Drawing.Point(51, 53)
        CONTRASENALabel.Name = "CONTRASENALabel"
        CONTRASENALabel.Size = New System.Drawing.Size(56, 13)
        CONTRASENALabel.TabIndex = 4
        CONTRASENALabel.Text = "Password:"
        '
        'NOMBRECOMPLETOLabel
        '
        NOMBRECOMPLETOLabel.AutoSize = True
        NOMBRECOMPLETOLabel.Location = New System.Drawing.Point(14, 118)
        NOMBRECOMPLETOLabel.Name = "NOMBRECOMPLETOLabel"
        NOMBRECOMPLETOLabel.Size = New System.Drawing.Size(93, 13)
        NOMBRECOMPLETOLabel.TabIndex = 10
        NOMBRECOMPLETOLabel.Text = "Nombre completo:"
        '
        'REFMEDICOLabel
        '
        REFMEDICOLabel.AutoSize = True
        REFMEDICOLabel.Location = New System.Drawing.Point(34, 22)
        REFMEDICOLabel.Name = "REFMEDICOLabel"
        REFMEDICOLabel.Size = New System.Drawing.Size(45, 13)
        REFMEDICOLabel.TabIndex = 12
        REFMEDICOLabel.Text = "Medico:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(14, 79)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(93, 13)
        Label1.TabIndex = 4
        Label1.Text = "Repetir Password:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(28, 169)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(77, 13)
        Label2.TabIndex = 10
        Label2.Text = "Rol de Acceso"
        '
        'lblCertificado
        '
        lblCertificado.AutoSize = True
        lblCertificado.Location = New System.Drawing.Point(17, 144)
        lblCertificado.Name = "lblCertificado"
        lblCertificado.Size = New System.Drawing.Size(92, 13)
        lblCertificado.TabIndex = 15
        lblCertificado.Text = "Certificado Digital:"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Location = New System.Drawing.Point(322, 350)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tb_Ficha)
        Me.TabControl1.Location = New System.Drawing.Point(4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(393, 341)
        Me.TabControl1.TabIndex = 1
        '
        'tb_Ficha
        '
        Me.tb_Ficha.AutoScroll = True
        Me.tb_Ficha.Controls.Add(Me.tb_CertificadoPath)
        Me.tb_Ficha.Controls.Add(Me.bt_Certificado)
        Me.tb_Ficha.Controls.Add(lblCertificado)
        Me.tb_Ficha.Controls.Add(Me.ROLESComboBox)
        Me.tb_Ficha.Controls.Add(Me.chkEsmedico)
        Me.tb_Ficha.Controls.Add(Me.grpMedicos)
        Me.tb_Ficha.Controls.Add(USUARIOLabel)
        Me.tb_Ficha.Controls.Add(Me.USUARIOTextBox)
        Me.tb_Ficha.Controls.Add(Label1)
        Me.tb_Ficha.Controls.Add(CONTRASENALabel)
        Me.tb_Ficha.Controls.Add(Me.RepetirContrasenna)
        Me.tb_Ficha.Controls.Add(Me.CONTRASENATextBox)
        Me.tb_Ficha.Controls.Add(Label2)
        Me.tb_Ficha.Controls.Add(NOMBRECOMPLETOLabel)
        Me.tb_Ficha.Controls.Add(Me.NOMBRECOMPLETOTextBox)
        Me.tb_Ficha.Location = New System.Drawing.Point(4, 22)
        Me.tb_Ficha.Name = "tb_Ficha"
        Me.tb_Ficha.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Ficha.Size = New System.Drawing.Size(385, 315)
        Me.tb_Ficha.TabIndex = 0
        Me.tb_Ficha.Text = "Ficha"
        Me.tb_Ficha.UseVisualStyleBackColor = True
        '
        'tb_CertificadoPath
        '
        Me.tb_CertificadoPath.AcceptsReturn = True
        Me.tb_CertificadoPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "CERTIFICADOPATH", True))
        Me.tb_CertificadoPath.Location = New System.Drawing.Point(113, 140)
        Me.tb_CertificadoPath.Name = "tb_CertificadoPath"
        Me.tb_CertificadoPath.Size = New System.Drawing.Size(175, 20)
        Me.tb_CertificadoPath.TabIndex = 17
        '
        'USUARIOSBindingSource
        '
        Me.USUARIOSBindingSource.DataMember = "USUARIOS"
        Me.USUARIOSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("es")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bt_Certificado
        '
        Me.bt_Certificado.Location = New System.Drawing.Point(294, 139)
        Me.bt_Certificado.Name = "bt_Certificado"
        Me.bt_Certificado.Size = New System.Drawing.Size(32, 22)
        Me.bt_Certificado.TabIndex = 16
        Me.bt_Certificado.Text = "..."
        Me.bt_Certificado.UseVisualStyleBackColor = True
        '
        'ROLESComboBox
        '
        Me.ROLESComboBox.DataSource = Me.ROLESBindingSource
        Me.ROLESComboBox.DisplayMember = "Nombre"
        Me.ROLESComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ROLESComboBox.Location = New System.Drawing.Point(113, 166)
        Me.ROLESComboBox.Name = "ROLESComboBox"
        Me.ROLESComboBox.Size = New System.Drawing.Size(214, 21)
        Me.ROLESComboBox.TabIndex = 14
        Me.ROLESComboBox.ValueMember = "ID_ROLE"
        '
        'ROLESBindingSource
        '
        Me.ROLESBindingSource.DataMember = "ROLES"
        Me.ROLESBindingSource.DataSource = Me.CMDataSet
        '
        'chkEsmedico
        '
        Me.chkEsmedico.AutoSize = True
        Me.chkEsmedico.Location = New System.Drawing.Point(37, 219)
        Me.chkEsmedico.Name = "chkEsmedico"
        Me.chkEsmedico.Size = New System.Drawing.Size(82, 17)
        Me.chkEsmedico.TabIndex = 7
        Me.chkEsmedico.Text = "Es Médico?"
        Me.chkEsmedico.UseVisualStyleBackColor = True
        '
        'grpMedicos
        '
        Me.grpMedicos.Controls.Add(Me.MEDICOSComboBox)
        Me.grpMedicos.Controls.Add(REFMEDICOLabel)
        Me.grpMedicos.Enabled = False
        Me.grpMedicos.Location = New System.Drawing.Point(31, 242)
        Me.grpMedicos.Name = "grpMedicos"
        Me.grpMedicos.Size = New System.Drawing.Size(296, 56)
        Me.grpMedicos.TabIndex = 14
        Me.grpMedicos.TabStop = False
        '
        'MEDICOSComboBox
        '
        Me.MEDICOSComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.USUARIOSBindingSource, "REFMEDICO", True))
        Me.MEDICOSComboBox.DataSource = Me.MEDICOSBindingSource
        Me.MEDICOSComboBox.DisplayMember = "NOMBRE"
        Me.MEDICOSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MEDICOSComboBox.Location = New System.Drawing.Point(85, 19)
        Me.MEDICOSComboBox.Name = "MEDICOSComboBox"
        Me.MEDICOSComboBox.Size = New System.Drawing.Size(149, 21)
        Me.MEDICOSComboBox.TabIndex = 13
        Me.MEDICOSComboBox.ValueMember = "CMEDICO"
        '
        'MEDICOSBindingSource
        '
        Me.MEDICOSBindingSource.DataMember = "MEDICOS"
        Me.MEDICOSBindingSource.DataSource = Me.CMDataSet
        '
        'USUARIOTextBox
        '
        Me.USUARIOTextBox.AcceptsReturn = True
        Me.USUARIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "USUARIO", True))
        Me.USUARIOTextBox.Location = New System.Drawing.Point(113, 24)
        Me.USUARIOTextBox.Name = "USUARIOTextBox"
        Me.USUARIOTextBox.Size = New System.Drawing.Size(214, 20)
        Me.USUARIOTextBox.TabIndex = 3
        '
        'RepetirContrasenna
        '
        Me.RepetirContrasenna.AcceptsReturn = True
        Me.RepetirContrasenna.Location = New System.Drawing.Point(113, 76)
        Me.RepetirContrasenna.Name = "RepetirContrasenna"
        Me.RepetirContrasenna.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RepetirContrasenna.Size = New System.Drawing.Size(214, 20)
        Me.RepetirContrasenna.TabIndex = 5
        '
        'CONTRASENATextBox
        '
        Me.CONTRASENATextBox.AcceptsReturn = True
        Me.CONTRASENATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "CONTRASENA", True))
        Me.CONTRASENATextBox.Location = New System.Drawing.Point(113, 50)
        Me.CONTRASENATextBox.Name = "CONTRASENATextBox"
        Me.CONTRASENATextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CONTRASENATextBox.Size = New System.Drawing.Size(214, 20)
        Me.CONTRASENATextBox.TabIndex = 4
        '
        'NOMBRECOMPLETOTextBox
        '
        Me.NOMBRECOMPLETOTextBox.AcceptsReturn = True
        Me.NOMBRECOMPLETOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "NOMBRECOMPLETO", True))
        Me.NOMBRECOMPLETOTextBox.Location = New System.Drawing.Point(113, 115)
        Me.NOMBRECOMPLETOTextBox.Name = "NOMBRECOMPLETOTextBox"
        Me.NOMBRECOMPLETOTextBox.Size = New System.Drawing.Size(214, 20)
        Me.NOMBRECOMPLETOTextBox.TabIndex = 6
        '
        'USUARIOSTableAdapter
        '
        Me.USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'ROLESTableAdapter
        '
        Me.ROLESTableAdapter.ClearBeforeFill = True
        '
        'frmUsuarios_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 376)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Name = "frmUsuarios_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar usuario"
        Me.TabControl1.ResumeLayout(False)
        Me.tb_Ficha.ResumeLayout(False)
        Me.tb_Ficha.PerformLayout()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMedicos.ResumeLayout(False)
        Me.grpMedicos.PerformLayout()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tb_Ficha As System.Windows.Forms.TabPage
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents USUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USUARIOSTableAdapter As centro_medico.CMDataSetTableAdapters.USUARIOSTableAdapter
    Friend WithEvents USUARIOTextBox As ctrlTextboxAvanzado
    Friend WithEvents CONTRASENATextBox As ctrlTextboxAvanzado
    Friend WithEvents NOMBRECOMPLETOTextBox As ctrlTextboxAvanzado
    Friend WithEvents RepetirContrasenna As ctrlTextboxAvanzado
    Friend WithEvents MEDICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents grpMedicos As System.Windows.Forms.GroupBox
    Friend WithEvents MEDICOSComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents chkEsmedico As System.Windows.Forms.CheckBox
    Friend WithEvents ROLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ROLESTableAdapter As centro_medico.CMDataSetTableAdapters.ROLESTableAdapter
    Friend WithEvents ROLESComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents tb_CertificadoPath As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents bt_Certificado As System.Windows.Forms.Button
End Class
