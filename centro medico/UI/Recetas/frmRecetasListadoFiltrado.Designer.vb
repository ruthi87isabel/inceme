<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecetasListadoFiltrado
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
        Dim GridEXRecetas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecetasListadoFiltrado))
        Dim GridMedicamentos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fechaDespues = New System.Windows.Forms.DateTimePicker()
        Me.fechaAntes = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GridEXRecetas = New Janus.Windows.GridEX.GridEX()
        Me.RECETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.bt_imprimir = New System.Windows.Forms.Button()
        Me.pb_EliminarDiagnostico = New System.Windows.Forms.Button()
        Me.pb_AddDiagnostico = New System.Windows.Forms.Button()
        Me.GridMedicamentos = New Janus.Windows.GridEX.GridEX()
        Me.MEDICAMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlMedico1 = New centro_medico.ctrlMedico()
        Me.CtrlMedicamento1 = New centro_medico.ctrlMedicamento()
        Me.CtrlPaciente21 = New centro_medico.ctrlPaciente2()
        Me.CtrlDiagnosticos1 = New centro_medico.ctrlDiagnosticos()
        CType(Me.GridEXRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 242
        Me.Label2.Text = "Desde"
        '
        'fechaDespues
        '
        Me.fechaDespues.CalendarMonthBackground = System.Drawing.Color.White
        Me.fechaDespues.Checked = False
        Me.fechaDespues.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDespues.Location = New System.Drawing.Point(288, 182)
        Me.fechaDespues.Name = "fechaDespues"
        Me.fechaDespues.Size = New System.Drawing.Size(101, 20)
        Me.fechaDespues.TabIndex = 6
        '
        'fechaAntes
        '
        Me.fechaAntes.CalendarMonthBackground = System.Drawing.Color.White
        Me.fechaAntes.Checked = False
        Me.fechaAntes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaAntes.Location = New System.Drawing.Point(56, 182)
        Me.fechaAntes.Name = "fechaAntes"
        Me.fechaAntes.Size = New System.Drawing.Size(101, 20)
        Me.fechaAntes.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 243
        Me.Label3.Text = "Paciente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(495, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 243
        Me.Label4.Text = "Medicamentos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 243
        Me.Label5.Text = "Diagnóstico"
        '
        'GridEXRecetas
        '
        Me.GridEXRecetas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXRecetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXRecetas.DataSource = Me.RECETABindingSource
        GridEXRecetas_DesignTimeLayout.LayoutString = resources.GetString("GridEXRecetas_DesignTimeLayout.LayoutString")
        Me.GridEXRecetas.DesignTimeLayout = GridEXRecetas_DesignTimeLayout
        Me.GridEXRecetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXRecetas.GroupByBoxVisible = False
        Me.GridEXRecetas.Location = New System.Drawing.Point(12, 214)
        Me.GridEXRecetas.Name = "GridEXRecetas"
        Me.GridEXRecetas.Size = New System.Drawing.Size(984, 415)
        Me.GridEXRecetas.TabIndex = 7
        Me.GridEXRecetas.TabStop = False
        '
        'RECETABindingSource
        '
        Me.RECETABindingSource.DataSource = GetType(centro_medico.RECETA)
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.Location = New System.Drawing.Point(842, 180)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(73, 28)
        Me.bt_filtrar.TabIndex = 8
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_imprimir.Location = New System.Drawing.Point(921, 180)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 28)
        Me.bt_imprimir.TabIndex = 9
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'pb_EliminarDiagnostico
        '
        Me.pb_EliminarDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_EliminarDiagnostico.Enabled = False
        Me.pb_EliminarDiagnostico.FlatAppearance.BorderSize = 0
        Me.pb_EliminarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pb_EliminarDiagnostico.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.pb_EliminarDiagnostico.Location = New System.Drawing.Point(971, 42)
        Me.pb_EliminarDiagnostico.Name = "pb_EliminarDiagnostico"
        Me.pb_EliminarDiagnostico.Size = New System.Drawing.Size(25, 25)
        Me.pb_EliminarDiagnostico.TabIndex = 251
        Me.pb_EliminarDiagnostico.UseVisualStyleBackColor = True
        Me.pb_EliminarDiagnostico.Visible = False
        '
        'pb_AddDiagnostico
        '
        Me.pb_AddDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_AddDiagnostico.FlatAppearance.BorderSize = 0
        Me.pb_AddDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pb_AddDiagnostico.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.pb_AddDiagnostico.Location = New System.Drawing.Point(949, 41)
        Me.pb_AddDiagnostico.Name = "pb_AddDiagnostico"
        Me.pb_AddDiagnostico.Size = New System.Drawing.Size(25, 25)
        Me.pb_AddDiagnostico.TabIndex = 252
        Me.pb_AddDiagnostico.UseVisualStyleBackColor = True
        Me.pb_AddDiagnostico.Visible = False
        '
        'GridMedicamentos
        '
        Me.GridMedicamentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMedicamentos.ColumnAutoResize = True
        Me.GridMedicamentos.DataSource = Me.MEDICAMENTOBindingSource
        GridMedicamentos_DesignTimeLayout.LayoutString = resources.GetString("GridMedicamentos_DesignTimeLayout.LayoutString")
        Me.GridMedicamentos.DesignTimeLayout = GridMedicamentos_DesignTimeLayout
        Me.GridMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridMedicamentos.GroupByBoxVisible = False
        Me.GridMedicamentos.Location = New System.Drawing.Point(498, 68)
        Me.GridMedicamentos.Name = "GridMedicamentos"
        Me.GridMedicamentos.Size = New System.Drawing.Size(498, 94)
        Me.GridMedicamentos.TabIndex = 253
        Me.GridMedicamentos.TabStop = False
        Me.GridMedicamentos.Visible = False
        '
        'MEDICAMENTOBindingSource
        '
        Me.MEDICAMENTOBindingSource.DataSource = GetType(centro_medico.MEDICAMENTO)
        '
        'CtrlMedico1
        '
        Me.CtrlMedico1.ID_Medico = Nothing
        Me.CtrlMedico1.Location = New System.Drawing.Point(15, 120)
        Me.CtrlMedico1.Name = "CtrlMedico1"
        Me.CtrlMedico1.Size = New System.Drawing.Size(454, 42)
        Me.CtrlMedico1.TabIndex = 2
        '
        'CtrlMedicamento1
        '
        Me.CtrlMedicamento1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlMedicamento1.ID_Medicamento = Nothing
        Me.CtrlMedicamento1.Location = New System.Drawing.Point(498, 42)
        Me.CtrlMedicamento1.Name = "CtrlMedicamento1"
        Me.CtrlMedicamento1.Size = New System.Drawing.Size(445, 26)
        Me.CtrlMedicamento1.TabIndex = 3
        '
        'CtrlPaciente21
        '
        Me.CtrlPaciente21.ID_PACIENTE = Nothing
        Me.CtrlPaciente21.Location = New System.Drawing.Point(12, 42)
        Me.CtrlPaciente21.Name = "CtrlPaciente21"
        Me.CtrlPaciente21.Size = New System.Drawing.Size(415, 26)
        Me.CtrlPaciente21.TabIndex = 0
        '
        'CtrlDiagnosticos1
        '
        Me.CtrlDiagnosticos1.ID_DIAGNOSTICOS = Nothing
        Me.CtrlDiagnosticos1.Location = New System.Drawing.Point(12, 89)
        Me.CtrlDiagnosticos1.Name = "CtrlDiagnosticos1"
        Me.CtrlDiagnosticos1.Size = New System.Drawing.Size(457, 25)
        Me.CtrlDiagnosticos1.TabIndex = 1
        '
        'frmRecetasListadoFiltrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 641)
        Me.Controls.Add(Me.GridMedicamentos)
        Me.Controls.Add(Me.pb_EliminarDiagnostico)
        Me.Controls.Add(Me.pb_AddDiagnostico)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.CtrlMedico1)
        Me.Controls.Add(Me.bt_filtrar)
        Me.Controls.Add(Me.GridEXRecetas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fechaDespues)
        Me.Controls.Add(Me.fechaAntes)
        Me.Controls.Add(Me.CtrlMedicamento1)
        Me.Controls.Add(Me.CtrlPaciente21)
        Me.Controls.Add(Me.CtrlDiagnosticos1)
        Me.Name = "frmRecetasListadoFiltrado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Recetas / Tratamientos"
        CType(Me.GridEXRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrlDiagnosticos1 As centro_medico.ctrlDiagnosticos
    Friend WithEvents CtrlPaciente21 As centro_medico.ctrlPaciente2
    Friend WithEvents CtrlMedicamento1 As centro_medico.ctrlMedicamento
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fechaDespues As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaAntes As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GridEXRecetas As Janus.Windows.GridEX.GridEX
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents CtrlMedico1 As centro_medico.ctrlMedico
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents pb_EliminarDiagnostico As System.Windows.Forms.Button
    Friend WithEvents pb_AddDiagnostico As System.Windows.Forms.Button
    Friend WithEvents RECETABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridMedicamentos As Janus.Windows.GridEX.GridEX
    Friend WithEvents MEDICAMENTOBindingSource As System.Windows.Forms.BindingSource
End Class
