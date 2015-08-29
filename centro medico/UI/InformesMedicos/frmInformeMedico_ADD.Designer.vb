<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeMedico_ADD
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
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_salvar = New System.Windows.Forms.Button()
        Me.descripcionTextBox = New System.Windows.Forms.TextBox()
        Me.INFORME_MEDICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CtrlMedico1 = New centro_medico.ctrlMedico()
        CType(Me.INFORME_MEDICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_cancel
        '
        Me.bt_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(440, 482)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 4
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_salvar
        '
        Me.bt_salvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_salvar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_salvar.Location = New System.Drawing.Point(359, 482)
        Me.bt_salvar.Name = "bt_salvar"
        Me.bt_salvar.Size = New System.Drawing.Size(75, 28)
        Me.bt_salvar.TabIndex = 3
        Me.bt_salvar.Text = "Guardar"
        Me.bt_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_salvar.UseVisualStyleBackColor = True
        '
        'descripcionTextBox
        '
        Me.descripcionTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.descripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INFORME_MEDICOBindingSource, "Descripcion", True))
        Me.descripcionTextBox.Location = New System.Drawing.Point(7, 118)
        Me.descripcionTextBox.Multiline = True
        Me.descripcionTextBox.Name = "descripcionTextBox"
        Me.descripcionTextBox.Size = New System.Drawing.Size(508, 358)
        Me.descripcionTextBox.TabIndex = 2
        '
        'INFORME_MEDICOBindingSource
        '
        Me.INFORME_MEDICOBindingSource.DataSource = GetType(centro_medico.INFORME_MEDICO)
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INFORME_MEDICOBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(55, 68)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechaDateTimePicker.TabIndex = 1
        Me.FechaDateTimePicker.Value = New Date(2012, 9, 16, 1, 6, 54, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Informe:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fecha"
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.DataBindings.Add(New System.Windows.Forms.Binding("ID_Medico", Me.INFORME_MEDICOBindingSource, "RefMedico", True))
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(11, 7)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(498, 42)
        Me.CtrlMedico1.TabIndex = 0
        '
        'frmInformeMedico_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(521, 511)
        Me.Controls.Add(Me.CtrlMedico1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.descripcionTextBox)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_salvar)
        Me.Name = "frmInformeMedico_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Nuevo Informe Mèdico"
        CType(Me.INFORME_MEDICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_salvar As System.Windows.Forms.Button
    Friend WithEvents descripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Public WithEvents INFORME_MEDICOBindingSource As System.Windows.Forms.BindingSource
End Class
