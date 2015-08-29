<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalas
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
        Dim GridEXListado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalas))
        Me.CITABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEXListado = New Janus.Windows.GridEX.GridEX()
        Me.SALABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CITABindingSource
        '
        Me.CITABindingSource.DataSource = GetType(centro_medico.CITA)
        '
        'GridEXListado
        '
        Me.GridEXListado.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXListado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXListado.ColumnAutoResize = True
        Me.GridEXListado.DataSource = Me.SALABindingSource
        GridEXListado_DesignTimeLayout.LayoutString = resources.GetString("GridEXListado_DesignTimeLayout.LayoutString")
        Me.GridEXListado.DesignTimeLayout = GridEXListado_DesignTimeLayout
        Me.GridEXListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXListado.GroupByBoxVisible = False
        Me.GridEXListado.Location = New System.Drawing.Point(5, 3)
        Me.GridEXListado.Name = "GridEXListado"
        Me.GridEXListado.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridEXListado.Size = New System.Drawing.Size(791, 549)
        Me.GridEXListado.TabIndex = 2
        Me.GridEXListado.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEXListado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        '
        'SALABindingSource
        '
        Me.SALABindingSource.DataSource = GetType(centro_medico.SALA)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(809, 25)
        Me.ToolStrip1.TabIndex = 224
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstNuevo
        '
        Me.tstNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNuevo.Name = "tstNuevo"
        Me.tstNuevo.Size = New System.Drawing.Size(62, 22)
        Me.tstNuevo.Text = "&Añadir"
        Me.tstNuevo.ToolTipText = "Nuevo"
        '
        'tst_Editar
        '
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(102, 22)
        Me.tst_Editar.Text = "&Modificar Cita"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.tst_Eliminar.Text = "&Eliminar"
        Me.tst_Eliminar.ToolTipText = "Borrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UiTab1
        '
        Me.UiTab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiTab1.Location = New System.Drawing.Point(0, 28)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(809, 582)
        Me.UiTab1.TabIndex = 225
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.GridEXListado)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(805, 558)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Listado"
        '
        'frmSalas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 613)
        Me.Controls.Add(Me.UiTab1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmSalas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salas / Consultas"
        CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridEXListado As Janus.Windows.GridEX.GridEX
    Friend WithEvents SALABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents CITABindingSource As System.Windows.Forms.BindingSource
End Class
