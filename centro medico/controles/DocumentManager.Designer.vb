<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentManager
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentManager))
        Me.ListViewDocs = New System.Windows.Forms.ListView
        Me.SystemImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.pbEditar = New System.Windows.Forms.PictureBox
        Me.pb_Edit = New System.Windows.Forms.PictureBox
        Me.pbDelete = New System.Windows.Forms.PictureBox
        Me.pbAddDocTramite = New System.Windows.Forms.PictureBox
        Me.ArchivoDigitalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GoltDataSet = New CMDataSet
        Me.ArchivoDigitalTableAdapter = New CMDataSetTableAdapters.ArchivoDigitalTableAdapter
        CType(Me.pbEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddDocTramite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchivoDigitalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoltDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListViewDocs
        '
        Me.ListViewDocs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewDocs.FullRowSelect = True
        Me.ListViewDocs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewDocs.HoverSelection = True
        Me.ListViewDocs.Location = New System.Drawing.Point(0, 0)
        Me.ListViewDocs.MultiSelect = False
        Me.ListViewDocs.Name = "ListViewDocs"
        Me.ListViewDocs.ShowGroups = False
        Me.ListViewDocs.ShowItemToolTips = True
        Me.ListViewDocs.Size = New System.Drawing.Size(163, 108)
        Me.ListViewDocs.SmallImageList = Me.SystemImageList
        Me.ListViewDocs.StateImageList = Me.SystemImageList
        Me.ListViewDocs.TabIndex = 133
        Me.ListViewDocs.UseCompatibleStateImageBehavior = False
        Me.ListViewDocs.View = System.Windows.Forms.View.SmallIcon
        '
        'SystemImageList
        '
        Me.SystemImageList.ImageStream = CType(resources.GetObject("SystemImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SystemImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.SystemImageList.Images.SetKeyName(0, "file.gif")
        '
        'pbEditar
        '
        Me.pbEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbEditar.Location = New System.Drawing.Point(60, 110)
        Me.pbEditar.Name = "pbEditar"
        Me.pbEditar.Size = New System.Drawing.Size(27, 24)
        Me.pbEditar.TabIndex = 134
        Me.pbEditar.TabStop = False
        Me.pbEditar.Visible = False
        '
        'pb_Edit
        '
        Me.pb_Edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_Edit.Location = New System.Drawing.Point(133, 110)
        Me.pb_Edit.Name = "pb_Edit"
        Me.pb_Edit.Size = New System.Drawing.Size(27, 25)
        Me.pb_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Edit.TabIndex = 131
        Me.pb_Edit.TabStop = False
        Me.pb_Edit.Visible = False
        '
        'pbDelete
        '
        Me.pbDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ;Me.pbDelete.Image = Global.prjPAF.My.Resources.Resources._24_book_blue_remove
        Me.pbDelete.Location = New System.Drawing.Point(30, 110)
        Me.pbDelete.Name = "pbDelete"
        Me.pbDelete.Size = New System.Drawing.Size(27, 25)
        Me.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDelete.TabIndex = 130
        Me.pbDelete.TabStop = False
        '
        'pbAddDocTramite
        '
        Me.pbAddDocTramite.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        'Me.pbAddDocTramite.Image = Global.prjPAF.My.Resources.Resources._24_book_blue_add
        'Me.pbAddDocTramite.InitialImage = Global.prjPAF.My.Resources.Resources._24_book_blue_add
        Me.pbAddDocTramite.Location = New System.Drawing.Point(0, 110)
        Me.pbAddDocTramite.Name = "pbAddDocTramite"
        Me.pbAddDocTramite.Size = New System.Drawing.Size(27, 25)
        Me.pbAddDocTramite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAddDocTramite.TabIndex = 129
        Me.pbAddDocTramite.TabStop = False
        '
        'ArchivoDigitalBindingSource
        '
        Me.ArchivoDigitalBindingSource.DataMember = "ArchivoDigital"
        Me.ArchivoDigitalBindingSource.DataSource = Me.GoltDataSet
        '
        'GoltDataSet
        '
        Me.GoltDataSet.DataSetName = "GoltDataSet"
        Me.GoltDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArchivoDigitalTableAdapter
        '
        Me.ArchivoDigitalTableAdapter.ClearBeforeFill = True
        '
        'DocumentManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbEditar)
        Me.Controls.Add(Me.ListViewDocs)
        Me.Controls.Add(Me.pb_Edit)
        Me.Controls.Add(Me.pbDelete)
        Me.Controls.Add(Me.pbAddDocTramite)
        Me.Name = "DocumentManager"
        Me.Size = New System.Drawing.Size(163, 135)
        CType(Me.pbEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddDocTramite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchivoDigitalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoltDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb_Edit As System.Windows.Forms.PictureBox
    Friend WithEvents pbDelete As System.Windows.Forms.PictureBox
    Friend WithEvents pbAddDocTramite As System.Windows.Forms.PictureBox
    Friend WithEvents GoltDataSet As CMDataSet
    Friend WithEvents ArchivoDigitalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArchivoDigitalTableAdapter As CMDataSetTableAdapters.ArchivoDigitalTableAdapter
    Friend WithEvents ListViewDocs As System.Windows.Forms.ListView
    Friend WithEvents SystemImageList As System.Windows.Forms.ImageList
    Friend WithEvents pbEditar As System.Windows.Forms.PictureBox

End Class
