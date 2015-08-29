<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFicherosAdjuntos
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
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFicherosAdjuntos))
        Me.FICHEROBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.FICHEROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tstNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tstModificar = New System.Windows.Forms.ToolStripButton()
        Me.tstEliminar = New System.Windows.Forms.ToolStripButton()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblMsg = New System.Windows.Forms.Label()
        CType(Me.FICHEROBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FICHEROBindingNavigator.SuspendLayout()
        CType(Me.FICHEROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FICHEROBindingNavigator
        '
        Me.FICHEROBindingNavigator.AddNewItem = Nothing
        Me.FICHEROBindingNavigator.BindingSource = Me.FICHEROBindingSource
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
        Me.FICHEROBindingNavigator.Size = New System.Drawing.Size(741, 25)
        Me.FICHEROBindingNavigator.TabIndex = 0
        Me.FICHEROBindingNavigator.Text = "BindingNavigator1"
        '
        'FICHEROBindingSource
        '
        Me.FICHEROBindingSource.DataSource = GetType(centro_medico.FICHERO)
        '
        'tstNuevo
        '
        Me.tstNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tstNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNuevo.Name = "tstNuevo"
        Me.tstNuevo.Size = New System.Drawing.Size(58, 22)
        Me.tstNuevo.Text = "&Nuevo"
        '
        'tstModificar
        '
        Me.tstModificar.Enabled = False
        Me.tstModificar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tstModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstModificar.Name = "tstModificar"
        Me.tstModificar.Size = New System.Drawing.Size(70, 22)
        Me.tstModificar.Text = "&Modificar"
        '
        'tstEliminar
        '
        Me.tstEliminar.Enabled = False
        Me.tstEliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tstEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstEliminar.Name = "tstEliminar"
        Me.tstEliminar.Size = New System.Drawing.Size(57, 22)
        Me.tstEliminar.Text = "&Borrar"
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
        Me.GridEX1.DataSource = Me.FICHEROBindingSource
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(5, 28)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(731, 428)
        Me.GridEX1.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "16x16_missing-image.png")
        Me.ImageList1.Images.SetKeyName(1, "Procesos_Finalizado.png")
        '
        'lblMsg
        '
        Me.lblMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(5, 463)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(637, 13)
        Me.lblMsg.TabIndex = 2
        Me.lblMsg.Text = "NOTA: Los ficheros adjuntos, visualizados y luego editados desde aqui no conserva" & _
    "ran los cambios realizados."
        '
        'frmFicherosAdjuntos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 481)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.FICHEROBindingNavigator)
        Me.Name = "frmFicherosAdjuntos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficheros Multimedia"
        CType(Me.FICHEROBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FICHEROBindingNavigator.ResumeLayout(False)
        Me.FICHEROBindingNavigator.PerformLayout()
        CType(Me.FICHEROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FICHEROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FICHEROBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents tstNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblMsg As System.Windows.Forms.Label
End Class
