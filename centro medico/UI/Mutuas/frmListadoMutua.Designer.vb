<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoMutua
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoMutua))
        Me.grpFiltrarPorCodigo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpFiltrarPorNombre = New System.Windows.Forms.GroupBox()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefono = New centro_medico.ctrlTextboxAvanzado()
        Me.txtNombre = New centro_medico.ctrlTextboxAvanzado()
        Me.txtEspecialidad = New centro_medico.ctrlTextboxAvanzado()
        Me.MUTUABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.btnConfigGrid = New System.Windows.Forms.Button()
        Me.CtrlMutuaDesde = New centro_medico.ctrlMutuaMejorado()
        Me.CtrlMutuaMejoradoHasta = New centro_medico.ctrlMutuaMejorado()
        Me.grpFiltrarPorCodigo.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.grpFiltrarPorNombre.SuspendLayout()
        CType(Me.MUTUABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpFiltrarPorCodigo
        '
        Me.grpFiltrarPorCodigo.Controls.Add(Me.CtrlMutuaMejoradoHasta)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.CtrlMutuaDesde)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label2)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label1)
        Me.grpFiltrarPorCodigo.Location = New System.Drawing.Point(4, 28)
        Me.grpFiltrarPorCodigo.Name = "grpFiltrarPorCodigo"
        Me.grpFiltrarPorCodigo.Size = New System.Drawing.Size(355, 84)
        Me.grpFiltrarPorCodigo.TabIndex = 197
        Me.grpFiltrarPorCodigo.TabStop = False
        Me.grpFiltrarPorCodigo.Text = "Filtrar mutua por código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(849, 25)
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
        'grpFiltrarPorNombre
        '
        Me.grpFiltrarPorNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltrarPorNombre.Controls.Add(Me.bt_filtrar)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label6)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label3)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label5)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtTelefono)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtNombre)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtEspecialidad)
        Me.grpFiltrarPorNombre.Location = New System.Drawing.Point(365, 28)
        Me.grpFiltrarPorNombre.Name = "grpFiltrarPorNombre"
        Me.grpFiltrarPorNombre.Size = New System.Drawing.Size(469, 84)
        Me.grpFiltrarPorNombre.TabIndex = 225
        Me.grpFiltrarPorNombre.TabStop = False
        Me.grpFiltrarPorNombre.Text = "Filtrar mutua por"
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.Location = New System.Drawing.Point(375, 52)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(86, 29)
        Me.bt_filtrar.TabIndex = 229
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "Especialidad:"
        '
        'txtTelefono
        '
        Me.txtTelefono.AcceptsReturn = True
        Me.txtTelefono.Location = New System.Drawing.Point(310, 26)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(134, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.AcceptsReturn = True
        Me.txtNombre.Location = New System.Drawing.Point(90, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(142, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.AcceptsReturn = True
        Me.txtEspecialidad.Location = New System.Drawing.Point(90, 50)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(142, 20)
        Me.txtEspecialidad.TabIndex = 3
        '
        'MUTUABindingSource
        '
        Me.MUTUABindingSource.DataSource = GetType(centro_medico.MUTUA)
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataSource = Me.MUTUABindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Location = New System.Drawing.Point(4, 118)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(841, 388)
        Me.GridEX1.TabIndex = 228
        '
        'btnConfigGrid
        '
        Me.btnConfigGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfigGrid.Image = Global.centro_medico.My.Resources.Resources._24_settings
        Me.btnConfigGrid.Location = New System.Drawing.Point(790, 4)
        Me.btnConfigGrid.Name = "btnConfigGrid"
        Me.btnConfigGrid.Size = New System.Drawing.Size(44, 24)
        Me.btnConfigGrid.TabIndex = 237
        Me.btnConfigGrid.UseVisualStyleBackColor = True
        '
        'CtrlMutuaDesde
        '
        Me.CtrlMutuaDesde.ID_MUTUA = Nothing
        Me.CtrlMutuaDesde.Location = New System.Drawing.Point(58, 23)
        Me.CtrlMutuaDesde.Name = "CtrlMutuaDesde"
        Me.CtrlMutuaDesde.Size = New System.Drawing.Size(291, 21)
        Me.CtrlMutuaDesde.TabIndex = 7
        '
        'CtrlMutuaMejoradoHasta
        '
        Me.CtrlMutuaMejoradoHasta.ID_MUTUA = Nothing
        Me.CtrlMutuaMejoradoHasta.Location = New System.Drawing.Point(58, 52)
        Me.CtrlMutuaMejoradoHasta.Name = "CtrlMutuaMejoradoHasta"
        Me.CtrlMutuaMejoradoHasta.Size = New System.Drawing.Size(291, 21)
        Me.CtrlMutuaMejoradoHasta.TabIndex = 8
        '
        'frmListadoMutua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 510)
        Me.Controls.Add(Me.btnConfigGrid)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.grpFiltrarPorNombre)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grpFiltrarPorCodigo)
        Me.Name = "frmListadoMutua"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado Mutuas"
        Me.grpFiltrarPorCodigo.ResumeLayout(False)
        Me.grpFiltrarPorCodigo.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpFiltrarPorNombre.ResumeLayout(False)
        Me.grpFiltrarPorNombre.PerformLayout()
        CType(Me.MUTUABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents grpFiltrarPorNombre As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As ctrlTextboxAvanzado
    Friend WithEvents txtNombre As ctrlTextboxAvanzado
    Friend WithEvents txtEspecialidad As ctrlTextboxAvanzado
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents MUTUABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnConfigGrid As System.Windows.Forms.Button
    Friend WithEvents CtrlMutuaMejoradoHasta As centro_medico.ctrlMutuaMejorado
    Friend WithEvents CtrlMutuaDesde As centro_medico.ctrlMutuaMejorado

End Class
