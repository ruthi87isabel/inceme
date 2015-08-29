Namespace UI.Reportes
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReportViewer
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewer))
            Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
            Me.tsReportes = New System.Windows.Forms.ToolStrip()
            Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
            Me.comboReportes = New System.Windows.Forms.ToolStripComboBox()
            Me.tsButtonVerReporte = New System.Windows.Forms.ToolStripButton()
            Me.tsEditar = New System.Windows.Forms.ToolStripButton()
            Me.bt_firmar = New System.Windows.Forms.Button()
            Me.tsReportes.SuspendLayout()
            Me.SuspendLayout()
            '
            'ReportViewer
            '
            Me.ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ReportViewer.LocalReport.EnableExternalImages = True
            Me.ReportViewer.LocalReport.EnableHyperlinks = True
            Me.ReportViewer.Location = New System.Drawing.Point(1, 27)
            Me.ReportViewer.Name = "ReportViewer"
            Me.ReportViewer.Size = New System.Drawing.Size(655, 476)
            Me.ReportViewer.TabIndex = 0
            Me.ReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            '
            'tsReportes
            '
            Me.tsReportes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.comboReportes, Me.tsButtonVerReporte, Me.tsEditar})
            Me.tsReportes.Location = New System.Drawing.Point(0, 0)
            Me.tsReportes.Name = "tsReportes"
            Me.tsReportes.Size = New System.Drawing.Size(655, 25)
            Me.tsReportes.TabIndex = 1
            Me.tsReportes.Text = "ToolStrip1"
            Me.tsReportes.Visible = False
            '
            'ToolStripLabel1
            '
            Me.ToolStripLabel1.Name = "ToolStripLabel1"
            Me.ToolStripLabel1.Size = New System.Drawing.Size(125, 22)
            Me.ToolStripLabel1.Text = "Reportes Personalizados"
            '
            'comboReportes
            '
            Me.comboReportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboReportes.Name = "comboReportes"
            Me.comboReportes.Size = New System.Drawing.Size(160, 25)
            '
            'tsButtonVerReporte
            '
            Me.tsButtonVerReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.tsButtonVerReporte.Image = CType(resources.GetObject("tsButtonVerReporte.Image"), System.Drawing.Image)
            Me.tsButtonVerReporte.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsButtonVerReporte.Name = "tsButtonVerReporte"
            Me.tsButtonVerReporte.Size = New System.Drawing.Size(27, 22)
            Me.tsButtonVerReporte.Text = "Ver"
            '
            'tsEditar
            '
            Me.tsEditar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
            Me.tsEditar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsEditar.Name = "tsEditar"
            Me.tsEditar.Size = New System.Drawing.Size(55, 22)
            Me.tsEditar.Text = "Editar"
            '
            'bt_firmar
            '
            Me.bt_firmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.bt_firmar.Location = New System.Drawing.Point(580, 2)
            Me.bt_firmar.Name = "bt_firmar"
            Me.bt_firmar.Size = New System.Drawing.Size(75, 23)
            Me.bt_firmar.TabIndex = 2
            Me.bt_firmar.Text = "E-Firma"
            Me.bt_firmar.UseVisualStyleBackColor = True
            '
            'frmReportViewer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(655, 504)
            Me.Controls.Add(Me.bt_firmar)
            Me.Controls.Add(Me.ReportViewer)
            Me.Controls.Add(Me.tsReportes)
            Me.Name = "frmReportViewer"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Visor de Reportes"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.tsReportes.ResumeLayout(False)
            Me.tsReportes.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
        Friend WithEvents tsReportes As System.Windows.Forms.ToolStrip
        Friend WithEvents comboReportes As System.Windows.Forms.ToolStripComboBox
        Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
        Friend WithEvents tsButtonVerReporte As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsEditar As System.Windows.Forms.ToolStripButton
        Friend WithEvents bt_firmar As System.Windows.Forms.Button
    End Class
End Namespace