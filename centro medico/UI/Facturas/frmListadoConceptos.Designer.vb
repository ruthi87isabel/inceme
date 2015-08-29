<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoConceptos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoConceptos))
        Dim GridEXDental_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEXDental_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition0.FormatStyle.BackgroundImag" & _
        "e")
        Dim GridEXDental_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.FormatConditions.Condition1.FormatStyle.BackgroundImag" & _
        "e")
        Me.ContextMenuFamilia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarFamiliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarFamiliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DENTALCONCEPTOSFRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tstStripDental = New System.Windows.Forms.ToolStrip()
        Me.tstNuevoDental = New System.Windows.Forms.ToolStripButton()
        Me.tstModificarDental = New System.Windows.Forms.ToolStripButton()
        Me.tstEliminarDental = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstAnnadirSeleccionados = New System.Windows.Forms.ToolStripButton()
        Me.GridEXDental = New Janus.Windows.GridEX.GridEX()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbRegulares = New System.Windows.Forms.RadioButton()
        Me.rbDentales = New System.Windows.Forms.RadioButton()
        Me.ContextMenuFamilia.SuspendLayout()
        CType(Me.DENTALCONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.tstStripDental.SuspendLayout()
        CType(Me.GridEXDental, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuFamilia
        '
        Me.ContextMenuFamilia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarFamiliaToolStripMenuItem, Me.EliminarFamiliaToolStripMenuItem})
        Me.ContextMenuFamilia.Name = "ContextMenuFamilia"
        Me.ContextMenuFamilia.Size = New System.Drawing.Size(167, 48)
        '
        'ModificarFamiliaToolStripMenuItem
        '
        Me.ModificarFamiliaToolStripMenuItem.Name = "ModificarFamiliaToolStripMenuItem"
        Me.ModificarFamiliaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ModificarFamiliaToolStripMenuItem.Text = "Modificar Familia"
        '
        'EliminarFamiliaToolStripMenuItem
        '
        Me.EliminarFamiliaToolStripMenuItem.Name = "EliminarFamiliaToolStripMenuItem"
        Me.EliminarFamiliaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EliminarFamiliaToolStripMenuItem.Text = "Eliminar Familia"
        '
        'DENTALCONCEPTOSFRABindingSource
        '
        Me.DENTALCONCEPTOSFRABindingSource.DataSource = GetType(centro_medico.CONCEPTOSFRA)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 502)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(807, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(318, 17)
        Me.ToolStripStatusLabel1.Text = "Click Derecho sobre un elemento para modificar su Familia"
        '
        'tstStripDental
        '
        Me.tstStripDental.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevoDental, Me.tstModificarDental, Me.tstEliminarDental, Me.ToolStripSeparator1, Me.tstAnnadirSeleccionados})
        Me.tstStripDental.Location = New System.Drawing.Point(0, 0)
        Me.tstStripDental.Name = "tstStripDental"
        Me.tstStripDental.Size = New System.Drawing.Size(807, 25)
        Me.tstStripDental.TabIndex = 5
        Me.tstStripDental.Text = "ToolStrip1"
        '
        'tstNuevoDental
        '
        Me.tstNuevoDental.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstNuevoDental.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNuevoDental.Name = "tstNuevoDental"
        Me.tstNuevoDental.Size = New System.Drawing.Size(62, 22)
        Me.tstNuevoDental.Text = "&Añadir"
        '
        'tstModificarDental
        '
        Me.tstModificarDental.Enabled = False
        Me.tstModificarDental.Image = CType(resources.GetObject("tstModificarDental.Image"), System.Drawing.Image)
        Me.tstModificarDental.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstModificarDental.Name = "tstModificarDental"
        Me.tstModificarDental.Size = New System.Drawing.Size(78, 22)
        Me.tstModificarDental.Text = "&Modificar"
        '
        'tstEliminarDental
        '
        Me.tstEliminarDental.Enabled = False
        Me.tstEliminarDental.Image = CType(resources.GetObject("tstEliminarDental.Image"), System.Drawing.Image)
        Me.tstEliminarDental.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstEliminarDental.Name = "tstEliminarDental"
        Me.tstEliminarDental.Size = New System.Drawing.Size(70, 22)
        Me.tstEliminarDental.Text = "&Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tstAnnadirSeleccionados
        '
        Me.tstAnnadirSeleccionados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tstAnnadirSeleccionados.Image = CType(resources.GetObject("tstAnnadirSeleccionados.Image"), System.Drawing.Image)
        Me.tstAnnadirSeleccionados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstAnnadirSeleccionados.Name = "tstAnnadirSeleccionados"
        Me.tstAnnadirSeleccionados.Size = New System.Drawing.Size(124, 22)
        Me.tstAnnadirSeleccionados.Text = "Añadir Seleccionados"
        '
        'GridEXDental
        '
        Me.GridEXDental.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDental.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXDental.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "re encabezado de columna para agrupar</GroupByBoxInfo></LocalizableData>"
        Me.GridEXDental.ColumnAutoResize = True
        Me.GridEXDental.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.ColumnHeader
        Me.GridEXDental.ContextMenuStrip = Me.ContextMenuFamilia
        Me.GridEXDental.DataSource = Me.DENTALCONCEPTOSFRABindingSource
        GridEXDental_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEXDental_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEXDental_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridEXDental_DesignTimeLayout_Reference_1.Instance"), Object)
        GridEXDental_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEXDental_DesignTimeLayout_Reference_0, GridEXDental_DesignTimeLayout_Reference_1})
        GridEXDental_DesignTimeLayout.LayoutString = resources.GetString("GridEXDental_DesignTimeLayout.LayoutString")
        Me.GridEXDental.DesignTimeLayout = GridEXDental_DesignTimeLayout
        Me.GridEXDental.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEXDental.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEXDental.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridEXDental.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXDental.Hierarchical = True
        Me.GridEXDental.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter
        Me.GridEXDental.Location = New System.Drawing.Point(6, 28)
        Me.GridEXDental.Name = "GridEXDental"
        Me.GridEXDental.Size = New System.Drawing.Size(795, 471)
        Me.GridEXDental.TabIndex = 6
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(387, 5)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 7
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbRegulares
        '
        Me.rbRegulares.AutoSize = True
        Me.rbRegulares.Location = New System.Drawing.Point(449, 5)
        Me.rbRegulares.Name = "rbRegulares"
        Me.rbRegulares.Size = New System.Drawing.Size(73, 17)
        Me.rbRegulares.TabIndex = 8
        Me.rbRegulares.TabStop = True
        Me.rbRegulares.Text = "Regulares"
        Me.rbRegulares.UseVisualStyleBackColor = True
        '
        'rbDentales
        '
        Me.rbDentales.AutoSize = True
        Me.rbDentales.Location = New System.Drawing.Point(528, 5)
        Me.rbDentales.Name = "rbDentales"
        Me.rbDentales.Size = New System.Drawing.Size(67, 17)
        Me.rbDentales.TabIndex = 8
        Me.rbDentales.TabStop = True
        Me.rbDentales.Text = "Dentales"
        Me.rbDentales.UseVisualStyleBackColor = True
        '
        'frmListadoConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 524)
        Me.Controls.Add(Me.rbDentales)
        Me.Controls.Add(Me.rbRegulares)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.GridEXDental)
        Me.Controls.Add(Me.tstStripDental)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmListadoConceptos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Conceptos Facturables"
        Me.ContextMenuFamilia.ResumeLayout(False)
        CType(Me.DENTALCONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tstStripDental.ResumeLayout(False)
        Me.tstStripDental.PerformLayout()
        CType(Me.GridEXDental, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DENTALCONCEPTOSFRABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuFamilia As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModificarFamiliaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstStripDental As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNuevoDental As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstModificarDental As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstEliminarDental As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstAnnadirSeleccionados As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridEXDental As Janus.Windows.GridEX.GridEX
    Friend WithEvents EliminarFamiliaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbRegulares As System.Windows.Forms.RadioButton
    Friend WithEvents rbDentales As System.Windows.Forms.RadioButton
End Class
