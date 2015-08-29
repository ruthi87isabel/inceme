<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConceptoAnaliticaListado
    Inherits FormConfigurable

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
        Dim GridEx1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConceptoAnaliticaListado))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpFiltrarPorCodigo = New System.Windows.Forms.GroupBox()
        Me.txtCodeDesde = New centro_medico.ctrlTextboxAvanzado()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImporte = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConcepto = New centro_medico.ctrlTextboxAvanzado()
        Me.GridEx1 = New Janus.Windows.GridEX.GridEX()
        Me.CONCEPTOSANALITICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnConfigGrid = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.grpFiltrarPorCodigo.SuspendLayout()
        CType(Me.GridEx1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(524, 25)
        Me.ToolStrip1.TabIndex = 228
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
        Me.tst_Eliminar.Text = "Eliminar"
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
        'grpFiltrarPorCodigo
        '
        Me.grpFiltrarPorCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtCodeDesde)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label4)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtImporte)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.bt_filtrar)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtDescripcion)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label1)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtConcepto)
        Me.grpFiltrarPorCodigo.Location = New System.Drawing.Point(0, 28)
        Me.grpFiltrarPorCodigo.Name = "grpFiltrarPorCodigo"
        Me.grpFiltrarPorCodigo.Size = New System.Drawing.Size(520, 83)
        Me.grpFiltrarPorCodigo.TabIndex = 229
        Me.grpFiltrarPorCodigo.TabStop = False
        Me.grpFiltrarPorCodigo.Text = "Filtrar conceptos de analítica por:"
        '
        'txtCodeDesde
        '
        Me.txtCodeDesde.AcceptsReturn = True
        Me.txtCodeDesde.Location = New System.Drawing.Point(73, 19)
        Me.txtCodeDesde.Name = "txtCodeDesde"
        Me.txtCodeDesde.Size = New System.Drawing.Size(89, 20)
        Me.txtCodeDesde.TabIndex = 235
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 234
        Me.Label4.Text = "Importe:"
        '
        'txtImporte
        '
        Me.txtImporte.AcceptsReturn = True
        Me.txtImporte.Location = New System.Drawing.Point(272, 19)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(60, 20)
        Me.txtImporte.TabIndex = 233
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.Location = New System.Drawing.Point(427, 14)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(75, 31)
        Me.bt_filtrar.TabIndex = 230
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = True
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 54)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(56, 13)
        Me.txtDescripcion.TabIndex = 194
        Me.txtDescripcion.Text = "Concepto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'txtConcepto
        '
        Me.txtConcepto.AcceptsReturn = True
        Me.txtConcepto.Location = New System.Drawing.Point(73, 51)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(127, 20)
        Me.txtConcepto.TabIndex = 3
        '
        'GridEx1
        '
        Me.GridEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEx1.DataSource = Me.CONCEPTOSANALITICABindingSource
        GridEx1_DesignTimeLayout.LayoutString = resources.GetString("GridEx1_DesignTimeLayout.LayoutString")
        Me.GridEx1.DesignTimeLayout = GridEx1_DesignTimeLayout
        Me.GridEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEx1.Location = New System.Drawing.Point(0, 116)
        Me.GridEx1.Name = "GridEx1"
        Me.GridEx1.Size = New System.Drawing.Size(520, 332)
        Me.GridEx1.TabIndex = 230
        '
        'CONCEPTOSANALITICABindingSource
        '
        Me.CONCEPTOSANALITICABindingSource.DataSource = GetType(centro_medico.CONCEPTOSANALITICA)
        '
        'btnConfigGrid
        '
        Me.btnConfigGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfigGrid.Image = Global.centro_medico.My.Resources.Resources._24_settings
        Me.btnConfigGrid.Location = New System.Drawing.Point(476, 4)
        Me.btnConfigGrid.Name = "btnConfigGrid"
        Me.btnConfigGrid.Size = New System.Drawing.Size(44, 24)
        Me.btnConfigGrid.TabIndex = 239
        Me.btnConfigGrid.UseVisualStyleBackColor = True
        '
        'frmConceptoAnaliticaListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 448)
        Me.Controls.Add(Me.btnConfigGrid)
        Me.Controls.Add(Me.GridEx1)
        Me.Controls.Add(Me.grpFiltrarPorCodigo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmConceptoAnaliticaListado"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado Conceptos Analítica"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpFiltrarPorCodigo.ResumeLayout(False)
        Me.grpFiltrarPorCodigo.PerformLayout()
        CType(Me.GridEx1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpFiltrarPorCodigo As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodeDesde As ctrlTextboxAvanzado
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As ctrlTextboxAvanzado
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As ctrlTextboxAvanzado
    Friend WithEvents CONCEPTOSANALITICABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnConfigGrid As System.Windows.Forms.Button
End Class
