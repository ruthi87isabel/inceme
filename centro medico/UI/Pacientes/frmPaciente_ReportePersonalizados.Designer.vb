<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaciente_ReportePersonalizados
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
        Me.components = New System.ComponentModel.Container
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaciente_ReportePersonalizados))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.ReportesPersonalizadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.ReportesPersonalizadoComboBox = New System.Windows.Forms.ComboBox
        Me.ReportesPersonalizadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesPersonalizadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesPersonalizadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.DataSource = Me.ReportesPersonalizadoBindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.ImageList = Me.ImageList1
        Me.GridEX1.Location = New System.Drawing.Point(12, 29)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(689, 402)
        Me.GridEX1.TabIndex = 0
        '
        'ReportesPersonalizadoBindingSource
        '
        Me.ReportesPersonalizadoBindingSource.DataSource = GetType(centro_medico.ReportesPersonalizado)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "24-zoom.png")
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Image = Global.centro_medico.My.Resources.Resources._16_em_cross
        Me.btnDelete.Location = New System.Drawing.Point(40, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(29, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.centro_medico.My.Resources.Resources.plus16x16
        Me.btnAdd.Location = New System.Drawing.Point(12, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(29, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ReportesPersonalizadoComboBox
        '
        Me.ReportesPersonalizadoComboBox.DataSource = Me.ReportesPersonalizadoBindingSource1
        Me.ReportesPersonalizadoComboBox.DisplayMember = "Descripcion"
        Me.ReportesPersonalizadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReportesPersonalizadoComboBox.FormattingEnabled = True
        Me.ReportesPersonalizadoComboBox.Location = New System.Drawing.Point(127, 453)
        Me.ReportesPersonalizadoComboBox.Name = "ReportesPersonalizadoComboBox"
        Me.ReportesPersonalizadoComboBox.Size = New System.Drawing.Size(300, 21)
        Me.ReportesPersonalizadoComboBox.TabIndex = 3
        Me.ReportesPersonalizadoComboBox.ValueMember = "IDReporte"
        Me.ReportesPersonalizadoComboBox.Visible = False
        '
        'ReportesPersonalizadoBindingSource1
        '
        Me.ReportesPersonalizadoBindingSource1.DataSource = GetType(centro_medico.ReportesPersonalizado)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Reporte Por Defecto:"
        Me.Label1.Visible = False
        '
        'frmPaciente_ReportePersonalizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 486)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportesPersonalizadoComboBox)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "frmPaciente_ReportePersonalizados"
        Me.Text = "Reportes Personalizados"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesPersonalizadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesPersonalizadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents ReportesPersonalizadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ReportesPersonalizadoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportesPersonalizadoBindingSource1 As System.Windows.Forms.BindingSource

End Class
