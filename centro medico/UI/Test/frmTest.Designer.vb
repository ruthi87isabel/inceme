<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Dim GridEXListado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTest))
        Me.GridEXListado = New Janus.Windows.GridEX.GridEX()
        Me.PacienteDebitoManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridEXListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacienteDebitoManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridEXListado
        '
        Me.GridEXListado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXListado.ColumnAutoResize = True
        Me.GridEXListado.DataSource = Me.PacienteDebitoManagerBindingSource
        GridEXListado_DesignTimeLayout.LayoutString = resources.GetString("GridEXListado_DesignTimeLayout.LayoutString")
        Me.GridEXListado.DesignTimeLayout = GridEXListado_DesignTimeLayout
        Me.GridEXListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXListado.GroupByBoxVisible = False
        Me.GridEXListado.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXListado.Hierarchical = True
        Me.GridEXListado.Location = New System.Drawing.Point(11, 49)
        Me.GridEXListado.Name = "GridEXListado"
        Me.GridEXListado.Size = New System.Drawing.Size(701, 386)
        Me.GridEXListado.TabIndex = 2
        Me.GridEXListado.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXListado.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'PacienteDebitoManagerBindingSource
        '
        Me.PacienteDebitoManagerBindingSource.DataSource = GetType(centro_medico.PacienteDebitoManager)
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 475)
        Me.Controls.Add(Me.GridEXListado)
        Me.Name = "frmTest"
        Me.Text = "frmTest"
        CType(Me.GridEXListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacienteDebitoManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridEXListado As Janus.Windows.GridEX.GridEX
    Friend WithEvents PacienteDebitoManagerBindingSource As System.Windows.Forms.BindingSource
End Class
