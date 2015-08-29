<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHorarios))
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Me.tabControl = New Janus.Windows.UI.Tab.UITab()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisponibilidadPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VaciarCalendarioActivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VaciarTodosMenosGlobalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VaciarTODOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_addHorario = New System.Windows.Forms.Button()
        Me.btConsultarHoras = New System.Windows.Forms.Button()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.FirstTabOffset = 3
        Me.tabControl.Location = New System.Drawing.Point(11, 27)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.Size = New System.Drawing.Size(1012, 520)
        Me.tabControl.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Año"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.tstGuardar, Me.ToolStripSeparator2, Me.ToolStripDropDownButton2, Me.ToolStripSeparator3, Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1035, 25)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(100, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tstGuardar
        '
        Me.tstGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstGuardar.Name = "tstGuardar"
        Me.tstGuardar.Size = New System.Drawing.Size(103, 22)
        Me.tstGuardar.Text = "Guardar Cambios"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiasToolStripMenuItem, Me.DisponibilidadPorFechaToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripDropDownButton2.Text = "Reportes"
        '
        'DiasToolStripMenuItem
        '
        Me.DiasToolStripMenuItem.Name = "DiasToolStripMenuItem"
        Me.DiasToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.DiasToolStripMenuItem.Text = "Resumen por Médico"
        '
        'DisponibilidadPorFechaToolStripMenuItem
        '
        Me.DisponibilidadPorFechaToolStripMenuItem.Name = "DisponibilidadPorFechaToolStripMenuItem"
        Me.DisponibilidadPorFechaToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.DisponibilidadPorFechaToolStripMenuItem.Text = "Disponibilidad por Fecha"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VaciarCalendarioActivoToolStripMenuItem, Me.VaciarTodosMenosGlobalToolStripMenuItem, Me.VaciarTODOToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripDropDownButton1.Text = "Vaciar"
        '
        'VaciarCalendarioActivoToolStripMenuItem
        '
        Me.VaciarCalendarioActivoToolStripMenuItem.Name = "VaciarCalendarioActivoToolStripMenuItem"
        Me.VaciarCalendarioActivoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.VaciarCalendarioActivoToolStripMenuItem.Text = "Vaciar calendario activo"
        Me.VaciarCalendarioActivoToolStripMenuItem.Visible = False
        '
        'VaciarTodosMenosGlobalToolStripMenuItem
        '
        Me.VaciarTodosMenosGlobalToolStripMenuItem.Name = "VaciarTodosMenosGlobalToolStripMenuItem"
        Me.VaciarTodosMenosGlobalToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.VaciarTodosMenosGlobalToolStripMenuItem.Text = "Vaciar todos menos global"
        Me.VaciarTodosMenosGlobalToolStripMenuItem.Visible = False
        '
        'VaciarTODOToolStripMenuItem
        '
        Me.VaciarTODOToolStripMenuItem.Name = "VaciarTODOToolStripMenuItem"
        Me.VaciarTODOToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.VaciarTODOToolStripMenuItem.Text = "Vaciar TODO"
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(46, 3)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(57, 20)
        Me.dtpYear.TabIndex = 32
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataSource = Me.BindingSource1
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(11, 552)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(565, 122)
        Me.GridEX1.TabIndex = 36
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'bt_addHorario
        '
        Me.bt_addHorario.Location = New System.Drawing.Point(582, 552)
        Me.bt_addHorario.Name = "bt_addHorario"
        Me.bt_addHorario.Size = New System.Drawing.Size(113, 23)
        Me.bt_addHorario.TabIndex = 37
        Me.bt_addHorario.Text = "Añadir intervalo"
        Me.bt_addHorario.UseVisualStyleBackColor = True
        '
        'btConsultarHoras
        '
        Me.btConsultarHoras.Location = New System.Drawing.Point(582, 581)
        Me.btConsultarHoras.Name = "btConsultarHoras"
        Me.btConsultarHoras.Size = New System.Drawing.Size(113, 23)
        Me.btConsultarHoras.TabIndex = 38
        Me.btConsultarHoras.Text = "Consultar horas (F5)"
        Me.btConsultarHoras.UseVisualStyleBackColor = True
        '
        'frmHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 679)
        Me.Controls.Add(Me.btConsultarHoras)
        Me.Controls.Add(Me.bt_addHorario)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpYear)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmHorarios"
        Me.Text = "Horarios"
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabControl As Janus.Windows.UI.Tab.UITab
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents VaciarCalendarioActivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VaciarTodosMenosGlobalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VaciarTODOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents DiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DisponibilidadPorFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents bt_addHorario As System.Windows.Forms.Button
    Friend WithEvents btConsultarHoras As System.Windows.Forms.Button

End Class
