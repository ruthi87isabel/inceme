<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConceptoFacturable_ADD
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
        Dim IMPORTELabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.CONCEPTOSFACTURABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtDuracion = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.CtrlConceptoFacturable21 = New centro_medico.ctrlConceptoFacturable2()
        IMPORTELabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.CONCEPTOSFACTURABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMPORTELabel
        '
        IMPORTELabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        IMPORTELabel.AutoSize = True
        IMPORTELabel.Location = New System.Drawing.Point(537, 10)
        IMPORTELabel.Name = "IMPORTELabel"
        IMPORTELabel.Size = New System.Drawing.Size(45, 13)
        IMPORTELabel.TabIndex = 81
        IMPORTELabel.Text = "Importe:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(23, 76)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 13)
        Label2.TabIndex = 81
        Label2.Text = "Descripción:"
        '
        'bt_cancel
        '
        Me.bt_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(507, 156)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 6
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(426, 156)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 5
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'CONCEPTOSFACTURABLEBindingSource
        '
        Me.CONCEPTOSFACTURABLEBindingSource.DataSource = GetType(centro_medico.CONCEPTOSFACTURABLE)
        '
        'txtImporte
        '
        Me.txtImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporte.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CONCEPTOSFACTURABLEBindingSource, "IMPORTE", True))
        Me.txtImporte.Location = New System.Drawing.Point(482, 26)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 2
        Me.txtImporte.Text = "0.00"
        Me.txtImporte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(529, 76)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 13)
        Label1.TabIndex = 80
        Label1.Text = "Duración:"
        '
        'txtDuracion
        '
        Me.txtDuracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDuracion.CustomFormat = "HH:mm"
        Me.txtDuracion.Enabled = False
        Me.txtDuracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDuracion.Location = New System.Drawing.Point(507, 92)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.ShowUpDown = True
        Me.txtDuracion.Size = New System.Drawing.Size(75, 20)
        Me.txtDuracion.TabIndex = 4
        Me.txtDuracion.Value = New Date(2010, 6, 21, 0, 0, 0, 0)
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        Me.txtDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONCEPTOSFACTURABLEBindingSource, "DESCRIPCION", True))
        Me.txtDescripcion.Location = New System.Drawing.Point(95, 76)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(381, 65)
        Me.txtDescripcion.TabIndex = 1
        '
        'CtrlConceptoFacturable21
        '
        Me.CtrlConceptoFacturable21.ID_ConceptosFra = Nothing
        Me.CtrlConceptoFacturable21.Location = New System.Drawing.Point(12, 24)
        Me.CtrlConceptoFacturable21.Name = "CtrlConceptoFacturable21"
        Me.CtrlConceptoFacturable21.Size = New System.Drawing.Size(464, 26)
        Me.CtrlConceptoFacturable21.TabIndex = 0
        '
        'frmConceptoFacturable_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 196)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.CtrlConceptoFacturable21)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(IMPORTELabel)
        Me.Name = "frmConceptoFacturable_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Concepto Facturable"
        CType(Me.CONCEPTOSFACTURABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents CONCEPTOSFACTURABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtrlConceptoFacturable21 As centro_medico.ctrlConceptoFacturable2
    Friend WithEvents txtImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtDescripcion As centro_medico.ctrlTextboxAvanzado
    Friend WithEvents txtDuracion As System.Windows.Forms.DateTimePicker
End Class
