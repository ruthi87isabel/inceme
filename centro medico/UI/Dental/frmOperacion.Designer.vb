<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperacion))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbxID = New ctrlTextboxAvanzado
        Me.tbxDescripcion = New ctrlTextboxAvanzado
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.LVw_Trat = New System.Windows.Forms.ListView
        Me.columnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnExaminar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.pbxIcono = New System.Windows.Forms.PictureBox
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog
        Me.chbNatural = New System.Windows.Forms.CheckBox
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pbxIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID"
        '
        'tbxID
        '
        Me.tbxID.Enabled = False
        Me.tbxID.Location = New System.Drawing.Point(167, 28)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.Size = New System.Drawing.Size(73, 20)
        Me.tbxID.TabIndex = 18
        '
        'tbxDescripcion
        '
        Me.tbxDescripcion.Location = New System.Drawing.Point(167, 54)
        Me.tbxDescripcion.Name = "tbxDescripcion"
        Me.tbxDescripcion.Size = New System.Drawing.Size(265, 20)
        Me.tbxDescripcion.TabIndex = 19
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(459, 25)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(66, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(69, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'LVw_Trat
        '
        Me.LVw_Trat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader11, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LVw_Trat.HideSelection = False
        Me.LVw_Trat.Location = New System.Drawing.Point(6, 129)
        Me.LVw_Trat.MultiSelect = False
        Me.LVw_Trat.Name = "LVw_Trat"
        Me.LVw_Trat.Size = New System.Drawing.Size(445, 193)
        Me.LVw_Trat.SmallImageList = Me.imgList
        Me.LVw_Trat.TabIndex = 24
        Me.LVw_Trat.UseCompatibleStateImageBehavior = False
        Me.LVw_Trat.View = System.Windows.Forms.View.Details
        '
        'columnHeader11
        '
        Me.columnHeader11.Text = "Descripción"
        Me.columnHeader11.Width = 260
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Importe"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Duracción"
        Me.ColumnHeader2.Width = 80
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.White
        Me.imgList.Images.SetKeyName(0, "file.bmp")
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(263, 80)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(77, 24)
        Me.btnLimpiar.TabIndex = 27
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(167, 80)
        Me.btnExaminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(86, 24)
        Me.btnExaminar.TabIndex = 26
        Me.btnExaminar.Text = "Examinar..."
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Icono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Tratamiento asociados"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(310, 328)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 26)
        Me.btnEliminar.TabIndex = 43
        Me.btnEliminar.Text = "&Eliminar tratamiento"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(152, 328)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(145, 26)
        Me.btnModificar.TabIndex = 42
        Me.btnModificar.Text = "&Modificar tratamiento..."
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(10, 328)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(134, 27)
        Me.btnNuevo.TabIndex = 41
        Me.btnNuevo.Text = "&Nuevo tratamiento..."
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'pbxIcono
        '
        Me.pbxIcono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxIcono.Location = New System.Drawing.Point(13, 34)
        Me.pbxIcono.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxIcono.Name = "pbxIcono"
        Me.pbxIcono.Size = New System.Drawing.Size(60, 60)
        Me.pbxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxIcono.TabIndex = 25
        Me.pbxIcono.TabStop = False
        '
        'chbNatural
        '
        Me.chbNatural.AutoSize = True
        Me.chbNatural.Location = New System.Drawing.Point(277, 32)
        Me.chbNatural.Name = "chbNatural"
        Me.chbNatural.Size = New System.Drawing.Size(107, 17)
        Me.chbNatural.TabIndex = 44
        Me.chbNatural.Text = "De origen natural"
        Me.chbNatural.UseVisualStyleBackColor = True
        '
        'frmOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 367)
        Me.Controls.Add(Me.chbNatural)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.pbxIcono)
        Me.Controls.Add(Me.LVw_Trat)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxID)
        Me.Controls.Add(Me.tbxDescripcion)
        Me.MaximizeBox = False
        Me.Name = "frmOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva operación"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pbxIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxID As ctrlTextboxAvanzado
    Friend WithEvents tbxDescripcion As ctrlTextboxAvanzado
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Private WithEvents LVw_Trat As System.Windows.Forms.ListView
    Private WithEvents columnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pbxIcono As System.Windows.Forms.PictureBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents chbNatural As System.Windows.Forms.CheckBox
End Class
