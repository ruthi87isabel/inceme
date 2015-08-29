<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeoTotalesCitas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeoTotalesCitas))
        Me.CITABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCargarCitas = New System.Windows.Forms.Button()
        Me.btnAplicarCorreccion = New System.Windows.Forms.Button()
        Me.lblProblemas = New System.Windows.Forms.Label()
        Me.chkSololasPrimeras = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkSoloProblematicas = New System.Windows.Forms.CheckBox()
        CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CITABindingSource
        '
        Me.CITABindingSource.DataSource = GetType(centro_medico.CITA)
        '
        'btnCargarCitas
        '
        Me.btnCargarCitas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCargarCitas.Location = New System.Drawing.Point(3, 528)
        Me.btnCargarCitas.Name = "btnCargarCitas"
        Me.btnCargarCitas.Size = New System.Drawing.Size(75, 28)
        Me.btnCargarCitas.TabIndex = 132
        Me.btnCargarCitas.Text = "Cargar citas"
        Me.btnCargarCitas.UseVisualStyleBackColor = True
        '
        'btnAplicarCorreccion
        '
        Me.btnAplicarCorreccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAplicarCorreccion.Location = New System.Drawing.Point(84, 528)
        Me.btnAplicarCorreccion.Name = "btnAplicarCorreccion"
        Me.btnAplicarCorreccion.Size = New System.Drawing.Size(200, 28)
        Me.btnAplicarCorreccion.TabIndex = 132
        Me.btnAplicarCorreccion.Text = "Aplicar Correción a Seleccionadas"
        Me.btnAplicarCorreccion.UseVisualStyleBackColor = True
        '
        'lblProblemas
        '
        Me.lblProblemas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProblemas.ForeColor = System.Drawing.Color.Red
        Me.lblProblemas.Location = New System.Drawing.Point(531, 533)
        Me.lblProblemas.Name = "lblProblemas"
        Me.lblProblemas.Size = New System.Drawing.Size(369, 23)
        Me.lblProblemas.TabIndex = 133
        Me.lblProblemas.Text = "Con problemas en Totales: 0"
        Me.lblProblemas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkSololasPrimeras
        '
        Me.chkSololasPrimeras.AutoSize = True
        Me.chkSololasPrimeras.Checked = True
        Me.chkSololasPrimeras.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSololasPrimeras.Location = New System.Drawing.Point(694, 15)
        Me.chkSololasPrimeras.Name = "chkSololasPrimeras"
        Me.chkSololasPrimeras.Size = New System.Drawing.Size(141, 17)
        Me.chkSololasPrimeras.TabIndex = 134
        Me.chkSololasPrimeras.Text = "Mostrar sólo las primeras"
        Me.chkSololasPrimeras.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(841, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(54, 20)
        Me.TextBox1.TabIndex = 135
        Me.TextBox1.Text = "100"
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.DataSource = Me.CITABindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(5, 37)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEX1.Size = New System.Drawing.Size(895, 487)
        Me.GridEX1.TabIndex = 131
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'dtp_ff
        '
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(259, 9)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.ShowCheckBox = True
        Me.dtp_ff.Size = New System.Drawing.Size(107, 20)
        Me.dtp_ff.TabIndex = 137
        '
        'dtp_fi
        '
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(84, 9)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.ShowCheckBox = True
        Me.dtp_fi.Size = New System.Drawing.Size(107, 20)
        Me.dtp_fi.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Fecha Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Fecha final"
        '
        'chkSoloProblematicas
        '
        Me.chkSoloProblematicas.AutoSize = True
        Me.chkSoloProblematicas.Checked = True
        Me.chkSoloProblematicas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSoloProblematicas.Location = New System.Drawing.Point(518, 15)
        Me.chkSoloProblematicas.Name = "chkSoloProblematicas"
        Me.chkSoloProblematicas.Size = New System.Drawing.Size(152, 17)
        Me.chkSoloProblematicas.TabIndex = 134
        Me.chkSoloProblematicas.Text = "Mostrar sólo Problemáticas"
        Me.chkSoloProblematicas.UseVisualStyleBackColor = True
        '
        'frmChequeoTotalesCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 559)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblProblemas)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chkSoloProblematicas)
        Me.Controls.Add(Me.chkSololasPrimeras)
        Me.Controls.Add(Me.btnAplicarCorreccion)
        Me.Controls.Add(Me.btnCargarCitas)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "frmChequeoTotalesCitas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chequeo de Totales en Citas"
        CType(Me.CITABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CITABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnCargarCitas As System.Windows.Forms.Button
    Friend WithEvents btnAplicarCorreccion As System.Windows.Forms.Button
    Friend WithEvents lblProblemas As System.Windows.Forms.Label
    Friend WithEvents chkSololasPrimeras As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkSoloProblematicas As System.Windows.Forms.CheckBox
End Class
