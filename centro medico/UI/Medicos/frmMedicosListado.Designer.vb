<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicosListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedicosListado))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tst_Editar = New System.Windows.Forms.ToolStripButton()
        Me.tst_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpFiltrarPorCodigo = New System.Windows.Forms.GroupBox()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.medicoHasta = New centro_medico.ctrlMedicoLinea()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.medicoDesde = New centro_medico.ctrlMedicoLinea()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEspecialidad = New centro_medico.ctrlTextboxAvanzado()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoColegio = New centro_medico.ctrlTextboxAvanzado()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New centro_medico.ctrlTextboxAvanzado()
        Me.MEDICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEx1 = New Janus.Windows.GridEX.GridEX()
        Me.btnConfigGrid = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.grpFiltrarPorCodigo.SuspendLayout()
        CType(Me.MEDICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEx1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tst_Editar, Me.tst_Eliminar, Me.ToolStripSeparator1, Me.tlbImprimir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1005, 25)
        Me.ToolStrip1.TabIndex = 0
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
        Me.grpFiltrarPorCodigo.Controls.Add(Me.bt_filtrar)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label7)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.medicoHasta)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label4)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.medicoDesde)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label3)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtEspecialidad)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label2)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtNoColegio)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.Label1)
        Me.grpFiltrarPorCodigo.Controls.Add(Me.txtNombre)
        Me.grpFiltrarPorCodigo.Location = New System.Drawing.Point(4, 28)
        Me.grpFiltrarPorCodigo.Name = "grpFiltrarPorCodigo"
        Me.grpFiltrarPorCodigo.Size = New System.Drawing.Size(989, 83)
        Me.grpFiltrarPorCodigo.TabIndex = 2
        Me.grpFiltrarPorCodigo.TabStop = False
        Me.grpFiltrarPorCodigo.Text = "Filtrar médicos por:"
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.Location = New System.Drawing.Point(892, 45)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(75, 31)
        Me.bt_filtrar.TabIndex = 5
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(555, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Especialidad:"
        '
        'medicoHasta
        '
        Me.medicoHasta.Location = New System.Drawing.Point(91, 48)
        Me.medicoHasta.Name = "medicoHasta"
        Me.medicoHasta.Size = New System.Drawing.Size(454, 25)
        Me.medicoHasta.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(778, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "Colegiado:"
        '
        'medicoDesde
        '
        Me.medicoDesde.Location = New System.Drawing.Point(91, 17)
        Me.medicoDesde.Name = "medicoDesde"
        Me.medicoDesde.Size = New System.Drawing.Size(454, 25)
        Me.medicoDesde.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(578, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Nombre:"
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.AcceptsReturn = True
        Me.txtEspecialidad.Location = New System.Drawing.Point(631, 51)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(127, 20)
        Me.txtEspecialidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código desde:"
        '
        'txtNoColegio
        '
        Me.txtNoColegio.AcceptsReturn = True
        Me.txtNoColegio.Location = New System.Drawing.Point(840, 19)
        Me.txtNoColegio.Name = "txtNoColegio"
        Me.txtNoColegio.Size = New System.Drawing.Size(127, 20)
        Me.txtNoColegio.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código desde:"
        '
        'txtNombre
        '
        Me.txtNombre.AcceptsReturn = True
        Me.txtNombre.Location = New System.Drawing.Point(631, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(127, 20)
        Me.txtNombre.TabIndex = 2
        '
        'MEDICOBindingSource
        '
        Me.MEDICOBindingSource.DataSource = GetType(centro_medico.MEDICO)
        '
        'GridEx1
        '
        Me.GridEx1.AllowCardSizing = False
        Me.GridEx1.AllowColumnDrag = False
        Me.GridEx1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEx1.DataSource = Me.MEDICOBindingSource
        GridEx1_DesignTimeLayout.LayoutString = resources.GetString("GridEx1_DesignTimeLayout.LayoutString")
        Me.GridEx1.DesignTimeLayout = GridEx1_DesignTimeLayout
        Me.GridEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEx1.Location = New System.Drawing.Point(0, 119)
        Me.GridEx1.Name = "GridEx1"
        Me.GridEx1.Size = New System.Drawing.Size(1002, 507)
        Me.GridEx1.TabIndex = 0
        Me.GridEx1.TabStop = False
        '
        'btnConfigGrid
        '
        Me.btnConfigGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfigGrid.Image = Global.centro_medico.My.Resources.Resources._24_settings
        Me.btnConfigGrid.Location = New System.Drawing.Point(949, 5)
        Me.btnConfigGrid.Name = "btnConfigGrid"
        Me.btnConfigGrid.Size = New System.Drawing.Size(44, 24)
        Me.btnConfigGrid.TabIndex = 1
        Me.btnConfigGrid.UseVisualStyleBackColor = True
        '
        'frmMedicosListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 626)
        Me.Controls.Add(Me.btnConfigGrid)
        Me.Controls.Add(Me.GridEx1)
        Me.Controls.Add(Me.grpFiltrarPorCodigo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMedicosListado"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de médicos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpFiltrarPorCodigo.ResumeLayout(False)
        Me.grpFiltrarPorCodigo.PerformLayout()
        CType(Me.MEDICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEx1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents medicoHasta As centro_medico.ctrlMedicoLinea
    Friend WithEvents medicoDesde As centro_medico.ctrlMedicoLinea
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEspecialidad As ctrlTextboxAvanzado
    Friend WithEvents txtNoColegio As ctrlTextboxAvanzado
    Friend WithEvents txtNombre As ctrlTextboxAvanzado
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents MEDICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnConfigGrid As System.Windows.Forms.Button
End Class
