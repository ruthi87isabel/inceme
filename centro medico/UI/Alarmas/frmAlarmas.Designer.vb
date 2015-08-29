<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlarmas
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
        Dim GridEXAlarma_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlarmas))
        Me.ALARMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEXAlarma = New Janus.Windows.GridEX.GridEX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.ALARMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ALARMABindingSource
        '
        Me.ALARMABindingSource.DataSource = GetType(centro_medico.ALARMA)
        '
        'GridEXAlarma
        '
        Me.GridEXAlarma.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXAlarma.AlternatingColors = True
        Me.GridEXAlarma.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXAlarma.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "re una columna aquí para reagrupar</GroupByBoxInfo></LocalizableData>"
        Me.GridEXAlarma.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEXAlarma.ColumnAutoResize = True
        Me.GridEXAlarma.DataSource = Me.ALARMABindingSource
        GridEXAlarma_DesignTimeLayout.LayoutString = resources.GetString("GridEXAlarma_DesignTimeLayout.LayoutString")
        Me.GridEXAlarma.DesignTimeLayout = GridEXAlarma_DesignTimeLayout
        Me.GridEXAlarma.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEXAlarma.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridEXAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXAlarma.GridLines = Janus.Windows.GridEX.GridLines.RowOutline
        Me.GridEXAlarma.GroupByBoxVisible = False
        Me.GridEXAlarma.Location = New System.Drawing.Point(0, -1)
        Me.GridEXAlarma.Name = "GridEXAlarma"
        Me.GridEXAlarma.SelectedFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight
        Me.GridEXAlarma.SelectedInactiveFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight
        Me.GridEXAlarma.Size = New System.Drawing.Size(647, 409)
        Me.GridEXAlarma.TabIndex = 229
        Me.GridEXAlarma.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(647, 25)
        Me.ToolStrip1.TabIndex = 228
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
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
        Me.tst_Editar.Size = New System.Drawing.Size(78, 22)
        Me.tst_Editar.Text = "&Modificar"
        Me.tst_Editar.ToolTipText = "Editar"
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
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'frmAlarmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 412)
        Me.Controls.Add(Me.GridEXAlarma)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmAlarmas"
        Me.Text = "Alarmas"
        CType(Me.ALARMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ALARMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridEXAlarma As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
