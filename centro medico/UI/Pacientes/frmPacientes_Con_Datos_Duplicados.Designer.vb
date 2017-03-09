<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes_Con_Datos_Duplicados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPacientes_Con_Datos_Duplicados))
        Me.grpFiltrarPorNombre = New System.Windows.Forms.GroupBox()
        Me.TbCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.DuplicadosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpFiltrarPorNombre.SuspendLayout()
        CType(Me.DuplicadosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpFiltrarPorNombre
        '
        Me.grpFiltrarPorNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltrarPorNombre.Controls.Add(Me.TbCodigo)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label1)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label2)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label3)
        Me.grpFiltrarPorNombre.Controls.Add(Me.dtp_ff)
        Me.grpFiltrarPorNombre.Controls.Add(Me.dtp_fi)
        Me.grpFiltrarPorNombre.Controls.Add(Me.txtNombre)
        Me.grpFiltrarPorNombre.Controls.Add(Me.bt_filtrar)
        Me.grpFiltrarPorNombre.Controls.Add(Me.Label5)
        Me.grpFiltrarPorNombre.Location = New System.Drawing.Point(8, 2)
        Me.grpFiltrarPorNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFiltrarPorNombre.Name = "grpFiltrarPorNombre"
        Me.grpFiltrarPorNombre.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFiltrarPorNombre.Size = New System.Drawing.Size(657, 93)
        Me.grpFiltrarPorNombre.TabIndex = 223
        Me.grpFiltrarPorNombre.TabStop = False
        Me.grpFiltrarPorNombre.Text = "Filtrar pacientes por:"
        '
        'TbCodigo
        '
        Me.TbCodigo.Location = New System.Drawing.Point(85, 60)
        Me.TbCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.Size = New System.Drawing.Size(75, 22)
        Me.TbCodigo.TabIndex = 212
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "a"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "De"
        '
        'dtp_ff
        '
        Me.dtp_ff.Checked = False
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(218, 25)
        Me.dtp_ff.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.ShowCheckBox = True
        Me.dtp_ff.Size = New System.Drawing.Size(136, 22)
        Me.dtp_ff.TabIndex = 1
        '
        'dtp_fi
        '
        Me.dtp_fi.Checked = False
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(57, 25)
        Me.dtp_fi.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.ShowCheckBox = True
        Me.dtp_fi.Size = New System.Drawing.Size(128, 22)
        Me.dtp_fi.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(251, 60)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(276, 22)
        Me.txtNombre.TabIndex = 210
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_filtrar.Image = Global.centro_medico.My.Resources.Resources._24_zoom
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.Location = New System.Drawing.Point(552, 56)
        Me.bt_filtrar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(97, 31)
        Me.bt_filtrar.TabIndex = 209
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(187, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "Nombre:"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(565, 486)
        Me.bt_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(100, 37)
        Me.bt_cancelar.TabIndex = 222
        Me.bt_cancelar.Text = "Cerrar"
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'DuplicadosBindingSource1
        '
        Me.DuplicadosBindingSource1.DataSource = GetType(centro_medico.Descartar_Pacientes_Duplicado)
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataSource = Me.DuplicadosBindingSource1
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Location = New System.Drawing.Point(8, 102)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(657, 376)
        Me.GridEX1.TabIndex = 224
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.centro_medico.My.Resources.Resources.Checked
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(404, 486)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 37)
        Me.Button1.TabIndex = 225
        Me.Button1.Text = "Activar Control"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPacientesDuplicados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 536)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.grpFiltrarPorNombre)
        Me.Controls.Add(Me.bt_cancelar)
        Me.MinimumSize = New System.Drawing.Size(692, 583)
        Me.Name = "frmPacientesDuplicados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descarte de control con datos duplicados"
        Me.grpFiltrarPorNombre.ResumeLayout(False)
        Me.grpFiltrarPorNombre.PerformLayout()
        CType(Me.DuplicadosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpFiltrarPorNombre As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents DuplicadosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TbCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
