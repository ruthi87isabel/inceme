<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemplates_ADD
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
        Me.components = New System.ComponentModel.Container()
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim SECCIONLabel As System.Windows.Forms.Label
        Dim TEXTOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemplates_ADD))
        Me.PLANTILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGOTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.DESCRIPCIONTextBox = New centro_medico.ctrlTextboxAvanzado()
        Me.EditBox1 = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.bt_open = New System.Windows.Forms.Button()
        Me.cb_seccion = New System.Windows.Forms.ComboBox()
        Me.btnLeyenda = New System.Windows.Forms.Button()
        CODIGOLabel = New System.Windows.Forms.Label()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        SECCIONLabel = New System.Windows.Forms.Label()
        TEXTOLabel = New System.Windows.Forms.Label()
        CType(Me.PLANTILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(18, 15)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "CODIGO:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(9, 37)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(83, 13)
        DESCRIPCIONLabel.TabIndex = 3
        DESCRIPCIONLabel.Text = "DESCRIPCION:"
        '
        'SECCIONLabel
        '
        SECCIONLabel.AutoSize = True
        SECCIONLabel.Location = New System.Drawing.Point(222, 14)
        SECCIONLabel.Name = "SECCIONLabel"
        SECCIONLabel.Size = New System.Drawing.Size(57, 13)
        SECCIONLabel.TabIndex = 5
        SECCIONLabel.Text = "SECCION:"
        '
        'TEXTOLabel
        '
        TEXTOLabel.AutoSize = True
        TEXTOLabel.Location = New System.Drawing.Point(12, 100)
        TEXTOLabel.Name = "TEXTOLabel"
        TEXTOLabel.Size = New System.Drawing.Size(46, 13)
        TEXTOLabel.TabIndex = 7
        TEXTOLabel.Text = "TEXTO:"
        '
        'PLANTILLABindingSource
        '
        Me.PLANTILLABindingSource.DataSource = GetType(centro_medico.PLANTILLA)
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.AcceptsReturn = True
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTILLABindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(76, 11)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CODIGOTextBox.TabIndex = 2
        '
        'DESCRIPCIONTextBox
        '
        Me.DESCRIPCIONTextBox.AcceptsReturn = True
        Me.DESCRIPCIONTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DESCRIPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTILLABindingSource, "DESCRIPCION", True))
        Me.DESCRIPCIONTextBox.Location = New System.Drawing.Point(12, 53)
        Me.DESCRIPCIONTextBox.MaxLength = 90
        Me.DESCRIPCIONTextBox.Multiline = True
        Me.DESCRIPCIONTextBox.Name = "DESCRIPCIONTextBox"
        Me.DESCRIPCIONTextBox.Size = New System.Drawing.Size(514, 34)
        Me.DESCRIPCIONTextBox.TabIndex = 4
        Me.DESCRIPCIONTextBox.Text = "012345678901234567890123456789012345678901234567890123456789012345678901234567890" & _
    "123456789"
        '
        'EditBox1
        '
        Me.EditBox1.AcceptsReturn = True
        Me.EditBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTILLABindingSource, "TEXTO", True))
        Me.EditBox1.Location = New System.Drawing.Point(12, 116)
        Me.EditBox1.Multiline = True
        Me.EditBox1.Name = "EditBox1"
        Me.EditBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EditBox1.Size = New System.Drawing.Size(514, 344)
        Me.EditBox1.TabIndex = 9
        '
        'bt_cancel
        '
        Me.bt_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(451, 466)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 13
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(370, 466)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 12
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'bt_open
        '
        Me.bt_open.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_open.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_open.Location = New System.Drawing.Point(334, 469)
        Me.bt_open.Name = "bt_open"
        Me.bt_open.Size = New System.Drawing.Size(30, 23)
        Me.bt_open.TabIndex = 11
        Me.bt_open.UseVisualStyleBackColor = True
        Me.bt_open.Visible = False
        '
        'cb_seccion
        '
        Me.cb_seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_seccion.FormattingEnabled = True
        Me.cb_seccion.Items.AddRange(New Object() {"General", "Historial-Motivo de consulta", "Historial-Antecedentes", "Historial-Historial", "Historial-Exploración", "Historial-Pruebas complementarias", "Historial-Juicio clínico", "Historial-Tratamiento", "Historial-Observaciones", "Recetas", "EMAIL", "SMS"})
        Me.cb_seccion.Location = New System.Drawing.Point(285, 10)
        Me.cb_seccion.Name = "cb_seccion"
        Me.cb_seccion.Size = New System.Drawing.Size(155, 21)
        Me.cb_seccion.TabIndex = 10
        '
        'btnLeyenda
        '
        Me.btnLeyenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLeyenda.Location = New System.Drawing.Point(12, 466)
        Me.btnLeyenda.Name = "btnLeyenda"
        Me.btnLeyenda.Size = New System.Drawing.Size(75, 23)
        Me.btnLeyenda.TabIndex = 14
        Me.btnLeyenda.Text = "Leyenda"
        Me.btnLeyenda.UseVisualStyleBackColor = True
        '
        'frmTemplates_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 495)
        Me.Controls.Add(Me.btnLeyenda)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.bt_open)
        Me.Controls.Add(Me.cb_seccion)
        Me.Controls.Add(Me.EditBox1)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.DESCRIPCIONTextBox)
        Me.Controls.Add(SECCIONLabel)
        Me.Controls.Add(TEXTOLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTemplates_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plantilla"
        CType(Me.PLANTILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CODIGOTextBox As ctrlTextboxAvanzado
    Friend WithEvents DESCRIPCIONTextBox As ctrlTextboxAvanzado
    Friend WithEvents EditBox1 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_open As System.Windows.Forms.Button
    Friend WithEvents cb_seccion As System.Windows.Forms.ComboBox
    Friend WithEvents btnLeyenda As System.Windows.Forms.Button
    Public WithEvents PLANTILLABindingSource As System.Windows.Forms.BindingSource
End Class
