<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_bonos_no_agotados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_bonos_no_agotados))
        Me.PACIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.ListadoPacientesTableAdapter1 = New centro_medico.CM2DataSetTableAdapters.ListadoPacientesTableAdapter()
        Me.PACIENTESBONOSTableAdapter = New centro_medico.CM2DataSetTableAdapters.PacientesBonosTableAdapter()
        Me.grpFiltrarPorNombre = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltrarPorNombre.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PACIENTEBindingSource
        '
        Me.PACIENTEBindingSource.DataSource = GetType(centro_medico.PACIENTE)
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImprimir.Location = New System.Drawing.Point(552, 474)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(73, 30)
        Me.bImprimir.TabIndex = 1
        Me.bImprimir.Text = "Imprimir"
        Me.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bImprimir.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(631, 474)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 30)
        Me.bt_cancelar.TabIndex = 2
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'ListadoPacientesTableAdapter1
        '
        Me.ListadoPacientesTableAdapter1.ClearBeforeFill = True
        '
        'PACIENTESBONOSTableAdapter
        '
        Me.PACIENTESBONOSTableAdapter.ClearBeforeFill = True
        '
        'grpFiltrarPorNombre
        '
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtApellido2)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtApellido1)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtNombre)
        Me.grpFiltrarPorNombre.Controls.Add(Me.bt_filtrar)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label8)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label7)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label5)
        Me.grpFiltrarPorNombre.Location = New System.Drawing.Point(18, 6)
        Me.grpFiltrarPorNombre.Name = "grpFiltrarPorNombre"
        Me.grpFiltrarPorNombre.Size = New System.Drawing.Size(688, 51)
        Me.grpFiltrarPorNombre.TabIndex = 220
        Me.grpFiltrarPorNombre.TabStop = False
        Me.grpFiltrarPorNombre.Text = "Filtrar pacientes por:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(70, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 210
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.Location = New System.Drawing.Point(590, 17)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(73, 25)
        Me.bt_filtrar.TabIndex = 209
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(385, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 194
        Me.Label8.Text = "Apellido 2:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Apellido 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "Nombre:"
        '
        'GridEX1
        '
        Me.GridEX1.DataSource = Me.PACIENTEBindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Location = New System.Drawing.Point(18, 63)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(688, 405)
        Me.GridEX1.TabIndex = 221
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(258, 22)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido1.TabIndex = 211
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(447, 22)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido2.TabIndex = 212
        '
        'form_bonos_no_agotados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(724, 518)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.grpFiltrarPorNombre)
        Me.Controls.Add(Me.bImprimir)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Name = "form_bonos_no_agotados"
        Me.ShowIcon = False
        Me.Text = "Pacientes con bonos no agotados"
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltrarPorNombre.ResumeLayout(False)
        Me.grpFiltrarPorNombre.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bImprimir As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents PACIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListadoPacientesTableAdapter1 As centro_medico.CM2DataSetTableAdapters.ListadoPacientesTableAdapter
    Friend WithEvents PACIENTESBONOSTableAdapter As centro_medico.CM2DataSetTableAdapters.PacientesBonosTableAdapter
    Friend WithEvents grpFiltrarPorNombre As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
End Class
