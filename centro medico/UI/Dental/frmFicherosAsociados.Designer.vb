<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFicherosAsociados
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
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFicherosAsociados))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.FICHEROSGLOBALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FICHEROBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton
        Me.tstModificar = New System.Windows.Forms.ToolStripButton
        Me.tstEliminar = New System.Windows.Forms.ToolStripButton
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FICHEROSGLOBALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FICHEROBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FICHEROBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
            "re aquí una columna para agrupar</GroupByBoxInfo></LocalizableData>"
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.ColumnHeader
        Me.GridEX1.DataSource = Me.FICHEROSGLOBALBindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(5, 29)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(731, 428)
        Me.GridEX1.TabIndex = 3
        '
        'FICHEROSGLOBALBindingSource
        '
        Me.FICHEROSGLOBALBindingSource.DataSource = GetType(centro_medico.FICHEROSGLOBAL)
        '
        'FICHEROBindingNavigator
        '
        Me.FICHEROBindingNavigator.AddNewItem = Nothing
        Me.FICHEROBindingNavigator.BindingSource = Me.FICHEROSGLOBALBindingSource
        Me.FICHEROBindingNavigator.CountItem = Nothing
        Me.FICHEROBindingNavigator.DeleteItem = Nothing
        Me.FICHEROBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNuevo, Me.tstModificar, Me.tstEliminar})
        Me.FICHEROBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FICHEROBindingNavigator.MoveFirstItem = Nothing
        Me.FICHEROBindingNavigator.MoveLastItem = Nothing
        Me.FICHEROBindingNavigator.MoveNextItem = Nothing
        Me.FICHEROBindingNavigator.MovePreviousItem = Nothing
        Me.FICHEROBindingNavigator.Name = "FICHEROBindingNavigator"
        Me.FICHEROBindingNavigator.PositionItem = Nothing
        Me.FICHEROBindingNavigator.Size = New System.Drawing.Size(738, 25)
        Me.FICHEROBindingNavigator.TabIndex = 4
        Me.FICHEROBindingNavigator.Text = "BindingNavigator1"
        '
        'tstNuevo
        '
        Me.tstNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNuevo.Name = "tstNuevo"
        Me.tstNuevo.Size = New System.Drawing.Size(62, 22)
        Me.tstNuevo.Text = "&Nuevo"
        '
        'tstModificar
        '
        Me.tstModificar.Enabled = False
        Me.tstModificar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tstModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstModificar.Name = "tstModificar"
        Me.tstModificar.Size = New System.Drawing.Size(78, 22)
        Me.tstModificar.Text = "&Modificar"
        '
        'tstEliminar
        '
        Me.tstEliminar.Enabled = False
        Me.tstEliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tstEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstEliminar.Name = "tstEliminar"
        Me.tstEliminar.Size = New System.Drawing.Size(59, 22)
        Me.tstEliminar.Text = "&Borrar"
        '
        'frmFicherosAsociados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 458)
        Me.Controls.Add(Me.FICHEROBindingNavigator)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "frmFicherosAsociados"
        Me.Text = "Ficheros Asociados"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FICHEROSGLOBALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FICHEROBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FICHEROBindingNavigator.ResumeLayout(False)
        Me.FICHEROBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents FICHEROSGLOBALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FICHEROBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstEliminar As System.Windows.Forms.ToolStripButton
End Class
