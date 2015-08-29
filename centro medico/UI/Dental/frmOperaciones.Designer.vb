<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperaciones))
        Me.LVw_Oper = New System.Windows.Forms.ListView
        Me.columnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVw_Oper
        '
        Me.LVw_Oper.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader6})
        Me.LVw_Oper.FullRowSelect = True
        Me.LVw_Oper.HideSelection = False
        Me.LVw_Oper.Location = New System.Drawing.Point(7, 34)
        Me.LVw_Oper.MultiSelect = False
        Me.LVw_Oper.Name = "LVw_Oper"
        Me.LVw_Oper.Size = New System.Drawing.Size(330, 337)
        Me.LVw_Oper.SmallImageList = Me.imgList
        Me.LVw_Oper.TabIndex = 10
        Me.LVw_Oper.UseCompatibleStateImageBehavior = False
        Me.LVw_Oper.View = System.Windows.Forms.View.Details
        '
        'columnHeader6
        '
        Me.columnHeader6.Text = "Descripción"
        Me.columnHeader6.Width = 300
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.White
        Me.imgList.Images.SetKeyName(0, "folder.bmp")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbModificar, Me.tsbEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(346, 25)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(58, 22)
        Me.tsbNuevo.Text = "&Nuevo"
        '
        'tsbModificar
        '
        Me.tsbModificar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.tsbModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(70, 22)
        Me.tsbModificar.Text = "&Modificar"
        Me.tsbModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(63, 22)
        Me.tsbEliminar.Text = "&Eliminar"
        '
        'frmOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 382)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LVw_Oper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOperaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operaciones dentales"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents LVw_Oper As System.Windows.Forms.ListView
    Private WithEvents columnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
End Class
