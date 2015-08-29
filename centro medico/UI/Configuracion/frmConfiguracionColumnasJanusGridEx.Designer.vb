<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracionColumnasJanusGridEx
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
        Me.trvOrganizadorGrid = New System.Windows.Forms.TreeView()
        Me.btnInsertarColumna = New System.Windows.Forms.Button()
        Me.lbxColumnas = New System.Windows.Forms.ListBox()
        Me.btnEliminarColumna = New System.Windows.Forms.Button()
        Me.btnEliminarAgrupador = New System.Windows.Forms.Button()
        Me.btnNuevoAgrupador = New System.Windows.Forms.Button()
        Me.btnModificarAgrupador = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lb_datos = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.bt_down = New System.Windows.Forms.Button()
        Me.bt_up = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'trvOrganizadorGrid
        '
        Me.trvOrganizadorGrid.FullRowSelect = True
        Me.trvOrganizadorGrid.HideSelection = False
        Me.trvOrganizadorGrid.Location = New System.Drawing.Point(19, 81)
        Me.trvOrganizadorGrid.Name = "trvOrganizadorGrid"
        Me.trvOrganizadorGrid.Size = New System.Drawing.Size(166, 226)
        Me.trvOrganizadorGrid.TabIndex = 0
        '
        'btnInsertarColumna
        '
        Me.btnInsertarColumna.Image = Global.centro_medico.My.Resources.Resources._24_arrow_back
        Me.btnInsertarColumna.Location = New System.Drawing.Point(193, 88)
        Me.btnInsertarColumna.Name = "btnInsertarColumna"
        Me.btnInsertarColumna.Size = New System.Drawing.Size(31, 31)
        Me.btnInsertarColumna.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnInsertarColumna, "Insertar columna")
        Me.btnInsertarColumna.UseVisualStyleBackColor = True
        '
        'lbxColumnas
        '
        Me.lbxColumnas.FormattingEnabled = True
        Me.lbxColumnas.Location = New System.Drawing.Point(233, 82)
        Me.lbxColumnas.Name = "lbxColumnas"
        Me.lbxColumnas.Size = New System.Drawing.Size(166, 225)
        Me.lbxColumnas.TabIndex = 3
        '
        'btnEliminarColumna
        '
        Me.btnEliminarColumna.Image = Global.centro_medico.My.Resources.Resources._24_arrow_forward
        Me.btnEliminarColumna.Location = New System.Drawing.Point(194, 125)
        Me.btnEliminarColumna.Name = "btnEliminarColumna"
        Me.btnEliminarColumna.Size = New System.Drawing.Size(31, 29)
        Me.btnEliminarColumna.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnEliminarColumna, "Eliminar columna")
        Me.btnEliminarColumna.UseVisualStyleBackColor = True
        '
        'btnEliminarAgrupador
        '
        Me.btnEliminarAgrupador.Enabled = False
        Me.btnEliminarAgrupador.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btnEliminarAgrupador.Location = New System.Drawing.Point(147, 52)
        Me.btnEliminarAgrupador.Name = "btnEliminarAgrupador"
        Me.btnEliminarAgrupador.Size = New System.Drawing.Size(37, 28)
        Me.btnEliminarAgrupador.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnEliminarAgrupador, "Eliminar Agrupador")
        Me.btnEliminarAgrupador.UseVisualStyleBackColor = True
        '
        'btnNuevoAgrupador
        '
        Me.btnNuevoAgrupador.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btnNuevoAgrupador.Location = New System.Drawing.Point(73, 52)
        Me.btnNuevoAgrupador.Name = "btnNuevoAgrupador"
        Me.btnNuevoAgrupador.Size = New System.Drawing.Size(37, 28)
        Me.btnNuevoAgrupador.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnNuevoAgrupador, "Adicionar agrupador")
        Me.btnNuevoAgrupador.UseVisualStyleBackColor = True
        '
        'btnModificarAgrupador
        '
        Me.btnModificarAgrupador.Enabled = False
        Me.btnModificarAgrupador.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.btnModificarAgrupador.Location = New System.Drawing.Point(110, 52)
        Me.btnModificarAgrupador.Name = "btnModificarAgrupador"
        Me.btnModificarAgrupador.Size = New System.Drawing.Size(37, 28)
        Me.btnModificarAgrupador.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnModificarAgrupador, "Modificar agrupador")
        Me.btnModificarAgrupador.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.Image = Global.centro_medico.My.Resources.Resources._24_zoom_in
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(19, 347)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 30)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Vista previa"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(233, 60)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(166, 19)
        Me.lb_datos.TabIndex = 65
        Me.lb_datos.Text = "Columnas disponibles"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(324, 347)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 67
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(243, 347)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 30)
        Me.btnAceptar.TabIndex = 66
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 31)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Modifique las columnas de los listados a su gusto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_down
        '
        Me.bt_down.Image = Global.centro_medico.My.Resources.Resources.down
        Me.bt_down.Location = New System.Drawing.Point(187, 280)
        Me.bt_down.Name = "bt_down"
        Me.bt_down.Size = New System.Drawing.Size(23, 27)
        Me.bt_down.TabIndex = 70
        Me.bt_down.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bt_down.UseVisualStyleBackColor = True
        '
        'bt_up
        '
        Me.bt_up.Image = Global.centro_medico.My.Resources.Resources.up
        Me.bt_up.Location = New System.Drawing.Point(187, 254)
        Me.bt_up.Name = "bt_up"
        Me.bt_up.Size = New System.Drawing.Size(23, 27)
        Me.bt_up.TabIndex = 69
        Me.bt_up.UseVisualStyleBackColor = True
        '
        'frmConfiguracionColumnasJanusGridEx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 387)
        Me.Controls.Add(Me.bt_down)
        Me.Controls.Add(Me.bt_up)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lb_datos)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnModificarAgrupador)
        Me.Controls.Add(Me.btnNuevoAgrupador)
        Me.Controls.Add(Me.btnEliminarAgrupador)
        Me.Controls.Add(Me.btnEliminarColumna)
        Me.Controls.Add(Me.lbxColumnas)
        Me.Controls.Add(Me.btnInsertarColumna)
        Me.Controls.Add(Me.trvOrganizadorGrid)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracionColumnasJanusGridEx"
        Me.ShowIcon = False
        Me.Text = "Configurar listados"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvOrganizadorGrid As System.Windows.Forms.TreeView
    Friend WithEvents btnInsertarColumna As System.Windows.Forms.Button
    Friend WithEvents lbxColumnas As System.Windows.Forms.ListBox
    Friend WithEvents btnEliminarColumna As System.Windows.Forms.Button
    Friend WithEvents btnEliminarAgrupador As System.Windows.Forms.Button
    Friend WithEvents btnNuevoAgrupador As System.Windows.Forms.Button
    Friend WithEvents btnModificarAgrupador As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents bt_down As System.Windows.Forms.Button
    Friend WithEvents bt_up As System.Windows.Forms.Button
End Class
