<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComunicaciones
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
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ValueList.Item0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComunicaciones))
        Dim GridEX1_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ValueList.Item1.Image")
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.ComunicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tstStrip = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tstEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tstPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstEnviarRecordatoriosCita = New System.Windows.Forms.ToolStripButton()
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComunicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
            "re una columna aqui para agrupar</GroupByBoxInfo></LocalizableData>"
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.DataSource = Me.ComunicacionBindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0, GridEX1_DesignTimeLayout_Reference_1})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEX1.Location = New System.Drawing.Point(3, 28)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(706, 483)
        Me.GridEX1.TabIndex = 0
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'ComunicacionBindingSource
        '
        Me.ComunicacionBindingSource.DataSource = GetType(centro_medico.Comunicacion)
        '
        'tstStrip
        '
        Me.tstStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tstEliminar, Me.tstPrint, Me.ToolStripSeparator1, Me.tstEnviarRecordatoriosCita})
        Me.tstStrip.Location = New System.Drawing.Point(0, 0)
        Me.tstStrip.Name = "tstStrip"
        Me.tstStrip.Size = New System.Drawing.Size(709, 25)
        Me.tstStrip.TabIndex = 4
        Me.tstStrip.Text = "ToolStrip1"
        '
        'tstNuevo
        '
        Me.tstNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNuevo.Name = "tstNuevo"
        Me.tstNuevo.Size = New System.Drawing.Size(62, 22)
        Me.tstNuevo.Text = "&Nuevo"
        '
        'tstEliminar
        '
        Me.tstEliminar.Enabled = False
        Me.tstEliminar.Image = CType(resources.GetObject("tstEliminar.Image"), System.Drawing.Image)
        Me.tstEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstEliminar.Name = "tstEliminar"
        Me.tstEliminar.Size = New System.Drawing.Size(59, 22)
        Me.tstEliminar.Text = "&Borrar"
        '
        'tstPrint
        '
        Me.tstPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tstPrint.Image = CType(resources.GetObject("tstPrint.Image"), System.Drawing.Image)
        Me.tstPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstPrint.Name = "tstPrint"
        Me.tstPrint.Size = New System.Drawing.Size(23, 22)
        Me.tstPrint.Text = "&Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tstEnviarRecordatoriosCita
        '
        Me.tstEnviarRecordatoriosCita.Image = Global.centro_medico.My.Resources.Resources.communication
        Me.tstEnviarRecordatoriosCita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstEnviarRecordatoriosCita.Name = "tstEnviarRecordatoriosCita"
        Me.tstEnviarRecordatoriosCita.Size = New System.Drawing.Size(170, 22)
        Me.tstEnviarRecordatoriosCita.Text = "Enviar recordatorios de cita"
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.CardColumnsPerPage = 1
        Me.GridEXPrintDocument1.DocumentName = "Comunicaciones"
        Me.GridEXPrintDocument1.FitColumns = Janus.Windows.GridEX.FitColumnsMode.SizingColumns
        Me.GridEXPrintDocument1.GridEX = Me.GridEX1
        Me.GridEXPrintDocument1.OriginAtMargins = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.GridEXPrintDocument1
        '
        'frmComunicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 532)
        Me.Controls.Add(Me.tstStrip)
        Me.Controls.Add(Me.GridEX1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmComunicaciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comunicaciones"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComunicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstStrip.ResumeLayout(False)
        Me.tstStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents ComunicacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tstStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents tstPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstEnviarRecordatoriosCita As System.Windows.Forms.ToolStripButton
End Class
