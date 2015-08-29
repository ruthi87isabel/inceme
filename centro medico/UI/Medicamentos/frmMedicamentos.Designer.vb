<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicamentos
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
        Dim GridEXMedicamentos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedicamentos))
        Me.GridEXMedicamentos = New Janus.Windows.GridEX.GridEX()
        Me.MEDICAMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        CType(Me.GridEXMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEXMedicamentos
        '
        Me.GridEXMedicamentos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXMedicamentos.AlternatingColors = True
        Me.GridEXMedicamentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXMedicamentos.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "re una columna aquí para reagrupar</GroupByBoxInfo></LocalizableData>"
        Me.GridEXMedicamentos.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEXMedicamentos.ColumnAutoResize = True
        Me.GridEXMedicamentos.DataSource = Me.MEDICAMENTOBindingSource
        GridEXMedicamentos_DesignTimeLayout.LayoutString = resources.GetString("GridEXMedicamentos_DesignTimeLayout.LayoutString")
        Me.GridEXMedicamentos.DesignTimeLayout = GridEXMedicamentos_DesignTimeLayout
        Me.GridEXMedicamentos.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEXMedicamentos.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridEXMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXMedicamentos.GridLines = Janus.Windows.GridEX.GridLines.RowOutline
        Me.GridEXMedicamentos.GroupByBoxVisible = False
        Me.GridEXMedicamentos.Location = New System.Drawing.Point(1, 27)
        Me.GridEXMedicamentos.Name = "GridEXMedicamentos"
        Me.GridEXMedicamentos.SelectedInactiveFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight
        Me.GridEXMedicamentos.Size = New System.Drawing.Size(799, 499)
        Me.GridEXMedicamentos.TabIndex = 228
        Me.GridEXMedicamentos.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'MEDICAMENTOBindingSource
        '
        Me.MEDICAMENTOBindingSource.DataSource = GetType(centro_medico.MEDICAMENTO)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbModificar, Me.tsbNuevo, Me.tsbEliminar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip2.TabIndex = 229
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbModificar
        '
        Me.tsbModificar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(70, 22)
        Me.tsbModificar.Text = "Modificar"
        Me.tsbModificar.ToolTipText = "&Modificar"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(58, 22)
        Me.tsbNuevo.Text = "&Nuevo"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(63, 22)
        Me.tsbEliminar.Text = "&Eliminar"
        '
        'frmMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 525)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GridEXMedicamentos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMedicamentos"
        Me.Text = "Medicamentos"
        CType(Me.GridEXMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridEXMedicamentos As Janus.Windows.GridEX.GridEX
    Friend WithEvents MEDICAMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
End Class
