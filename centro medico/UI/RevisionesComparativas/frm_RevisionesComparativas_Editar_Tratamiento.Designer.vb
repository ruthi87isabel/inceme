<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RevisionesComparativas_Editar_Tratamiento
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim TratamientoLabel As System.Windows.Forms.Label
        Dim Valor_UnidadLabel As System.Windows.Forms.Label
        Dim UnidadLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TratamientoTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadTextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.NumericEditBox1 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.CtrlConceptoFacturable21 = New centro_medico.ctrlConceptoFacturable2()
        Me.Label2 = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        TratamientoLabel = New System.Windows.Forms.Label()
        Valor_UnidadLabel = New System.Windows.Forms.Label()
        UnidadLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(40, 21)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 7
        FechaLabel.Text = "Fecha:"
        '
        'TratamientoLabel
        '
        TratamientoLabel.AutoSize = True
        TratamientoLabel.Location = New System.Drawing.Point(18, 76)
        TratamientoLabel.Name = "TratamientoLabel"
        TratamientoLabel.Size = New System.Drawing.Size(66, 13)
        TratamientoLabel.TabIndex = 9
        TratamientoLabel.Text = "Tratamiento:"
        '
        'Valor_UnidadLabel
        '
        Valor_UnidadLabel.AutoSize = True
        Valor_UnidadLabel.Location = New System.Drawing.Point(13, 160)
        Valor_UnidadLabel.Name = "Valor_UnidadLabel"
        Valor_UnidadLabel.Size = New System.Drawing.Size(71, 13)
        Valor_UnidadLabel.TabIndex = 11
        Valor_UnidadLabel.Text = "Valor Unidad:"
        '
        'UnidadLabel
        '
        UnidadLabel.AutoSize = True
        UnidadLabel.Location = New System.Drawing.Point(40, 189)
        UnidadLabel.Name = "UnidadLabel"
        UnidadLabel.Size = New System.Drawing.Size(44, 13)
        UnidadLabel.TabIndex = 13
        UnidadLabel.Text = "Unidad:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(18, 215)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(68, 13)
        ComentariosLabel.TabIndex = 15
        ComentariosLabel.Text = "Comentarios:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(163, 189)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 13)
        Label1.TabIndex = 13
        Label1.Text = "cm, ml, kg, etc"
        '
        'LCOMPARATIVAS_TRATAMIENTOsBindingSource
        '
        Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource.DataSource = GetType(System.Data.Linq.EntitySet(Of centro_medico.LCOMPARATIVAS_TRATAMIENTO))
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(93, 15)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(104, 20)
        Me.FechaDateTimePicker.TabIndex = 8
        '
        'TratamientoTextBox
        '
        Me.TratamientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource, "Tratamiento", True))
        Me.TratamientoTextBox.Location = New System.Drawing.Point(93, 76)
        Me.TratamientoTextBox.MaxLength = 200
        Me.TratamientoTextBox.Multiline = True
        Me.TratamientoTextBox.Name = "TratamientoTextBox"
        Me.TratamientoTextBox.Size = New System.Drawing.Size(504, 78)
        Me.TratamientoTextBox.TabIndex = 10
        '
        'UnidadTextBox
        '
        Me.UnidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource, "Unidad", True))
        Me.UnidadTextBox.Location = New System.Drawing.Point(93, 186)
        Me.UnidadTextBox.Name = "UnidadTextBox"
        Me.UnidadTextBox.Size = New System.Drawing.Size(64, 20)
        Me.UnidadTextBox.TabIndex = 14
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(93, 215)
        Me.ComentariosTextBox.MaxLength = 200
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(504, 118)
        Me.ComentariosTextBox.TabIndex = 16
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(522, 342)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'NumericEditBox1
        '
        Me.NumericEditBox1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource, "Valor_Unidad", True))
        Me.NumericEditBox1.Location = New System.Drawing.Point(93, 160)
        Me.NumericEditBox1.Name = "NumericEditBox1"
        Me.NumericEditBox1.Size = New System.Drawing.Size(64, 20)
        Me.NumericEditBox1.TabIndex = 20
        Me.NumericEditBox1.Text = "0.00"
        Me.NumericEditBox1.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'CtrlConceptoFacturable21
        '
        Me.CtrlConceptoFacturable21.DataBindings.Add(New System.Windows.Forms.Binding("ID_ConceptosFra", Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource, "REFCONCEPTOFRA", True))
        Me.CtrlConceptoFacturable21.ID_ConceptosFra = Nothing
        Me.CtrlConceptoFacturable21.Location = New System.Drawing.Point(28, 41)
        Me.CtrlConceptoFacturable21.Name = "CtrlConceptoFacturable21"
        Me.CtrlConceptoFacturable21.Size = New System.Drawing.Size(569, 26)
        Me.CtrlConceptoFacturable21.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(90, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Tratamiento facturada en cita"
        Me.Label2.Visible = False
        '
        'frm_RevisionesComparativas_Editar_Tratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 377)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericEditBox1)
        Me.Controls.Add(Me.CtrlConceptoFacturable21)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(TratamientoLabel)
        Me.Controls.Add(Me.TratamientoTextBox)
        Me.Controls.Add(Valor_UnidadLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(UnidadLabel)
        Me.Controls.Add(Me.UnidadTextBox)
        Me.Controls.Add(ComentariosLabel)
        Me.Controls.Add(Me.ComentariosTextBox)
        Me.Name = "frm_RevisionesComparativas_Editar_Tratamiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir / Modificar Tratamiento"
        CType(Me.LCOMPARATIVAS_TRATAMIENTOsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TratamientoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Public WithEvents LCOMPARATIVAS_TRATAMIENTOsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtrlConceptoFacturable21 As centro_medico.ctrlConceptoFacturable2
    Friend WithEvents NumericEditBox1 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
