<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlantillasdeTexto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlantillasdeTexto))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpFiltrarPorCodigo = New System.Windows.Forms.GroupBox()
        Me.txtCode = New centro_medico.ctrlTextboxAvanzado()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.PLANTILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnConfigGrid = New System.Windows.Forms.Button()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.grpFiltrarPorCodigo.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(526, 25)
        Me.ToolStrip1.TabIndex = 230
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
        Me.tst_Eliminar.Text = "&Eliminar"
        Me.tst_Eliminar.ToolTipText = "Borrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'grpFiltrarPorCodigo
        '
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtCode)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.bt_filtrar)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.lblDescripcion)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label1)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtDescripcion)
        Me.grpFiltrarPorCodigo.Location = New System.Drawing.Point(3, 27)
        Me.grpFiltrarPorCodigo.Name = "grpFiltrarPorCodigo"
        Me.grpFiltrarPorCodigo.Size = New System.Drawing.Size(520, 52)
        Me.grpFiltrarPorCodigo.TabIndex = 231
        Me.grpFiltrarPorCodigo.TabStop = False
        Me.grpFiltrarPorCodigo.Text = "Filtrar plantillas de texto por:"
        '
        'txtCode
        '
        Me.txtCode.AcceptsReturn = True
        Me.txtCode.Location = New System.Drawing.Point(62, 19)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(89, 20)
        Me.txtCode.TabIndex = 235
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
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(176, 23)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 194
        Me.lblDescripcion.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        Me.txtDescripcion.Location = New System.Drawing.Point(248, 19)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(154, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataSource = Me.PLANTILLABindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(3, 83)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(520, 386)
        Me.GridEX1.TabIndex = 234
        '
        'PLANTILLABindingSource
        '
        Me.PLANTILLABindingSource.DataSource = GetType(centro_medico.PLANTILLA)
        '
        'btnConfigGrid
        '
        Me.btnConfigGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfigGrid.Image = Global.centro_medico.My.Resources.Resources._24_settings
        Me.btnConfigGrid.Location = New System.Drawing.Point(479, 3)
        Me.btnConfigGrid.Name = "btnConfigGrid"
        Me.btnConfigGrid.Size = New System.Drawing.Size(44, 24)
        Me.btnConfigGrid.TabIndex = 235
        Me.btnConfigGrid.UseVisualStyleBackColor = True
        Me.btnConfigGrid.Visible = False
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tlbImprimir.Text = "Imprimir"
        '
        'frmPlantillasdeTexto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 474)
        Me.Controls.Add(Me.btnConfigGrid)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.grpFiltrarPorCodigo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MinimumSize = New System.Drawing.Size(542, 512)
        Me.Name = "frmPlantillasdeTexto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de plantillas de texto"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpFiltrarPorCodigo.ResumeLayout(False)
        Me.grpFiltrarPorCodigo.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpFiltrarPorCodigo As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As ctrlTextboxAvanzado
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As ctrlTextboxAvanzado
    Friend WithEvents PLANTILLABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnConfigGrid As System.Windows.Forms.Button
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolStripButton
End Class
