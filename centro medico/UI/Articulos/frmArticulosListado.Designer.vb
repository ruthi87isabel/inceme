<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulosListado
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulosListado))
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.grpFiltrarPorCodigo = New System.Windows.Forms.GroupBox()
        Me.txtMenorQue = New ctrlTextboxAvanzado()
        Me.txtMayorQue = New ctrlTextboxAvanzado()
        Me.txtDescripcion = New ctrlTextboxAvanzado()
        Me.txtCodigo = New ctrlTextboxAvanzado()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.ARTICULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnConfigGrid = New System.Windows.Forms.Button()
        Me.grpFiltrarPorCodigo.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.Location = New System.Drawing.Point(407, 19)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(83, 29)
        Me.bt_filtrar.TabIndex = 229
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'grpFiltrarPorCodigo
        '
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtMenorQue)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtMayorQue)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtDescripcion)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtCodigo)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label4)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label3)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.bt_filtrar)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label2)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label1)
        Me.grpFiltrarPorCodigo.Location = New System.Drawing.Point(4, 28)
        Me.grpFiltrarPorCodigo.Name = "grpFiltrarPorCodigo"
        Me.grpFiltrarPorCodigo.Size = New System.Drawing.Size(502, 90)
        Me.grpFiltrarPorCodigo.TabIndex = 226
        Me.grpFiltrarPorCodigo.TabStop = False
        Me.grpFiltrarPorCodigo.Text = "Filtrar artículos"
        '
        'txtMenorQue
        '
        Me.txtMenorQue.Enabled = False
        Me.txtMenorQue.Location = New System.Drawing.Point(328, 58)
        Me.txtMenorQue.Name = "txtMenorQue"
        Me.txtMenorQue.Size = New System.Drawing.Size(55, 20)
        Me.txtMenorQue.TabIndex = 235
        '
        'txtMayorQue
        '
        Me.txtMayorQue.Location = New System.Drawing.Point(328, 23)
        Me.txtMayorQue.Name = "txtMayorQue"
        Me.txtMayorQue.Size = New System.Drawing.Size(55, 20)
        Me.txtMayorQue.TabIndex = 234
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(85, 58)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(111, 20)
        Me.txtDescripcion.TabIndex = 233
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(85, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(89, 20)
        Me.txtCodigo.TabIndex = 232
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 231
        Me.Label4.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 230
        Me.Label3.Text = "Stock menor que:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Stock mayor que:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(512, 25)
        Me.ToolStrip1.TabIndex = 227
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstNuevo
        '
        Me.tstNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tstNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNuevo.Name = "tstNuevo"
        Me.tstNuevo.Size = New System.Drawing.Size(23, 22)
        Me.tstNuevo.Text = "&Añadir"
        Me.tstNuevo.ToolTipText = "Nuevo"
        '
        'tst_Editar
        '
        Me.tst_Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tst_Editar.Enabled = False
        Me.tst_Editar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tst_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Editar.Name = "tst_Editar"
        Me.tst_Editar.Size = New System.Drawing.Size(23, 22)
        Me.tst_Editar.Text = "&Modificar"
        Me.tst_Editar.ToolTipText = "Editar"
        '
        'tst_Eliminar
        '
        Me.tst_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tst_Eliminar.Enabled = False
        Me.tst_Eliminar.Image = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.tst_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_Eliminar.Name = "tst_Eliminar"
        Me.tst_Eliminar.Size = New System.Drawing.Size(23, 22)
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
        'GridEX1
        '
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataSource = Me.ARTICULOBindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Location = New System.Drawing.Point(4, 124)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(502, 418)
        Me.GridEX1.TabIndex = 230
        '
        'ARTICULOBindingSource
        '
        Me.ARTICULOBindingSource.DataSource = GetType(centro_medico.ARTICULO)
        '
        'btnConfigGrid
        '
        Me.btnConfigGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfigGrid.Image = Global.centro_medico.My.Resources.Resources._24_settings
        Me.btnConfigGrid.Location = New System.Drawing.Point(462, 4)
        Me.btnConfigGrid.Name = "btnConfigGrid"
        Me.btnConfigGrid.Size = New System.Drawing.Size(44, 24)
        Me.btnConfigGrid.TabIndex = 236
        Me.btnConfigGrid.UseVisualStyleBackColor = True
        '
        'frmArticulosListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 546)
        Me.Controls.Add(Me.btnConfigGrid)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grpFiltrarPorCodigo)
        Me.Name = "frmArticulosListado"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de artículos"
        Me.grpFiltrarPorCodigo.ResumeLayout(False)
        Me.grpFiltrarPorCodigo.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents grpFiltrarPorCodigo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

    Friend WithEvents ARTICULOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtMenorQue As ctrlTextboxAvanzado
    Friend WithEvents txtMayorQue As ctrlTextboxAvanzado
    Friend WithEvents txtDescripcion As ctrlTextboxAvanzado
    Friend WithEvents txtCodigo As ctrlTextboxAvanzado
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConfigGrid As System.Windows.Forms.Button
End Class
