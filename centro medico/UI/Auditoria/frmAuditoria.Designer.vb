<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditoria
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuditoria))
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AuditoriaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AuditoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tstImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tstExportar = New System.Windows.Forms.ToolStripButton()
        Me.tstVaciar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VaciarIntervaloSeleccionadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VaciarloTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.pnl_Loading = New System.Windows.Forms.Panel()
        Me.lnkCancelar = New System.Windows.Forms.LinkLabel()
        Me.lbl_Loading = New System.Windows.Forms.Label()
        Me.pb_Loading = New System.Windows.Forms.PictureBox()
        CType(Me.AuditoriaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AuditoriaBindingNavigator.SuspendLayout()
        CType(Me.AuditoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Loading.SuspendLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AuditoriaBindingNavigator
        '
        Me.AuditoriaBindingNavigator.AddNewItem = Nothing
        Me.AuditoriaBindingNavigator.BindingSource = Me.AuditoriaBindingSource
        Me.AuditoriaBindingNavigator.CountItem = Nothing
        Me.AuditoriaBindingNavigator.DeleteItem = Nothing
        Me.AuditoriaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstImprimir, Me.tstExportar, Me.ToolStripSeparator1, Me.tstVaciar})
        Me.AuditoriaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AuditoriaBindingNavigator.MoveFirstItem = Nothing
        Me.AuditoriaBindingNavigator.MoveLastItem = Nothing
        Me.AuditoriaBindingNavigator.MoveNextItem = Nothing
        Me.AuditoriaBindingNavigator.MovePreviousItem = Nothing
        Me.AuditoriaBindingNavigator.Name = "AuditoriaBindingNavigator"
        Me.AuditoriaBindingNavigator.PositionItem = Nothing
        Me.AuditoriaBindingNavigator.Size = New System.Drawing.Size(1008, 25)
        Me.AuditoriaBindingNavigator.TabIndex = 0
        Me.AuditoriaBindingNavigator.Text = "BindingNavigator1"
        '
        'AuditoriaBindingSource
        '
        Me.AuditoriaBindingSource.DataSource = GetType(centro_medico.Auditoria)
        '
        'tstImprimir
        '
        Me.tstImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tstImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstImprimir.Name = "tstImprimir"
        Me.tstImprimir.Size = New System.Drawing.Size(65, 22)
        Me.tstImprimir.Text = "Imprimir"
        '
        'tstExportar
        '
        Me.tstExportar.Image = Global.centro_medico.My.Resources.Resources.Excel_icon
        Me.tstExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstExportar.Name = "tstExportar"
        Me.tstExportar.Size = New System.Drawing.Size(69, 22)
        Me.tstExportar.Text = "Exportar"
        '
        'tstVaciar
        '
        Me.tstVaciar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VaciarIntervaloSeleccionadoToolStripMenuItem, Me.VaciarloTodoToolStripMenuItem})
        Me.tstVaciar.Image = Global.centro_medico.My.Resources.Resources._24_frame_close
        Me.tstVaciar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstVaciar.Name = "tstVaciar"
        Me.tstVaciar.Size = New System.Drawing.Size(105, 22)
        Me.tstVaciar.Text = "Vaciar registro"
        '
        'VaciarIntervaloSeleccionadoToolStripMenuItem
        '
        Me.VaciarIntervaloSeleccionadoToolStripMenuItem.Name = "VaciarIntervaloSeleccionadoToolStripMenuItem"
        Me.VaciarIntervaloSeleccionadoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.VaciarIntervaloSeleccionadoToolStripMenuItem.Text = "Vaciar intervalo mostrado"
        '
        'VaciarloTodoToolStripMenuItem
        '
        Me.VaciarloTodoToolStripMenuItem.Name = "VaciarloTodoToolStripMenuItem"
        Me.VaciarloTodoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.VaciarloTodoToolStripMenuItem.Text = "Vaciarlo todo"
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.ColumnHeader
        Me.GridEX1.DataSource = Me.AuditoriaBindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX1.Location = New System.Drawing.Point(6, 53)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.GridEX1.Size = New System.Drawing.Size(996, 403)
        Me.GridEX1.TabIndex = 2
        '
        'dtpDesde
        '
        Me.dtpDesde.Checked = False
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(53, 29)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.ShowCheckBox = True
        Me.dtpDesde.Size = New System.Drawing.Size(113, 20)
        Me.dtpDesde.TabIndex = 4
        '
        'dtpHasta
        '
        Me.dtpHasta.Checked = False
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(230, 28)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.ShowCheckBox = True
        Me.dtpHasta.Size = New System.Drawing.Size(113, 20)
        Me.dtpHasta.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(378, 24)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(84, 28)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        Me.btnFiltrar.Visible = False
        '
        'pnl_Loading
        '
        Me.pnl_Loading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnl_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Loading.Controls.Add(Me.lnkCancelar)
        Me.pnl_Loading.Controls.Add(Me.lbl_Loading)
        Me.pnl_Loading.Controls.Add(Me.pb_Loading)
        Me.pnl_Loading.Location = New System.Drawing.Point(365, 213)
        Me.pnl_Loading.Name = "pnl_Loading"
        Me.pnl_Loading.Size = New System.Drawing.Size(195, 56)
        Me.pnl_Loading.TabIndex = 223
        Me.pnl_Loading.Visible = False
        '
        'lnkCancelar
        '
        Me.lnkCancelar.AutoSize = True
        Me.lnkCancelar.Location = New System.Drawing.Point(49, 30)
        Me.lnkCancelar.Name = "lnkCancelar"
        Me.lnkCancelar.Size = New System.Drawing.Size(49, 13)
        Me.lnkCancelar.TabIndex = 120
        Me.lnkCancelar.TabStop = True
        Me.lnkCancelar.Text = "Cancelar"
        Me.lnkCancelar.Visible = False
        '
        'lbl_Loading
        '
        Me.lbl_Loading.AutoSize = True
        Me.lbl_Loading.Location = New System.Drawing.Point(49, 22)
        Me.lbl_Loading.Name = "lbl_Loading"
        Me.lbl_Loading.Size = New System.Drawing.Size(70, 13)
        Me.lbl_Loading.TabIndex = 119
        Me.lbl_Loading.Text = "Exportando..."
        '
        'pb_Loading
        '
        Me.pb_Loading.Image = Global.centro_medico.My.Resources.Resources.ajax_loader
        Me.pb_Loading.Location = New System.Drawing.Point(6, 11)
        Me.pb_Loading.Name = "pb_Loading"
        Me.pb_Loading.Size = New System.Drawing.Size(40, 35)
        Me.pb_Loading.TabIndex = 118
        Me.pb_Loading.TabStop = False
        '
        'frmAuditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 483)
        Me.Controls.Add(Me.pnl_Loading)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.AuditoriaBindingNavigator)
        Me.Name = "frmAuditoria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditorías"
        CType(Me.AuditoriaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AuditoriaBindingNavigator.ResumeLayout(False)
        Me.AuditoriaBindingNavigator.PerformLayout()
        CType(Me.AuditoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Loading.ResumeLayout(False)
        Me.pnl_Loading.PerformLayout()
        CType(Me.pb_Loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AuditoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AuditoriaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents tstImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents tstExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_Loading As System.Windows.Forms.Panel
    Friend WithEvents lnkCancelar As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_Loading As System.Windows.Forms.Label
    Friend WithEvents pb_Loading As System.Windows.Forms.PictureBox
    Friend WithEvents tstVaciar As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents VaciarIntervaloSeleccionadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VaciarloTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
