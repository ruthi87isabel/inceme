<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Odontograma
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Odontograma))
        Me.picture = New System.Windows.Forms.PictureBox
        Me.dent_definitiva = New System.Windows.Forms.PictureBox
        Me.dent_temporal = New System.Windows.Forms.PictureBox
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dent_definitiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dent_temporal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picture
        '
        Me.picture.Image = CType(resources.GetObject("picture.Image"), System.Drawing.Image)
        Me.picture.Location = New System.Drawing.Point(0, 0)
        Me.picture.Margin = New System.Windows.Forms.Padding(0)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(500, 346)
        Me.picture.TabIndex = 1
        Me.picture.TabStop = False
        '
        'dent_definitiva
        '
        Me.dent_definitiva.Image = CType(resources.GetObject("dent_definitiva.Image"), System.Drawing.Image)
        Me.dent_definitiva.Location = New System.Drawing.Point(0, 0)
        Me.dent_definitiva.Margin = New System.Windows.Forms.Padding(0)
        Me.dent_definitiva.Name = "dent_definitiva"
        Me.dent_definitiva.Size = New System.Drawing.Size(500, 346)
        Me.dent_definitiva.TabIndex = 2
        Me.dent_definitiva.TabStop = False
        Me.dent_definitiva.Visible = False
        '
        'dent_temporal
        '
        Me.dent_temporal.Image = CType(resources.GetObject("dent_temporal.Image"), System.Drawing.Image)
        Me.dent_temporal.Location = New System.Drawing.Point(0, 0)
        Me.dent_temporal.Margin = New System.Windows.Forms.Padding(0)
        Me.dent_temporal.Name = "dent_temporal"
        Me.dent_temporal.Size = New System.Drawing.Size(500, 346)
        Me.dent_temporal.TabIndex = 3
        Me.dent_temporal.TabStop = False
        Me.dent_temporal.Visible = False
        '
        'Odontograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picture)
        Me.Controls.Add(Me.dent_definitiva)
        Me.Controls.Add(Me.dent_temporal)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "Odontograma"
        Me.Size = New System.Drawing.Size(500, 346)
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dent_definitiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dent_temporal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents picture As System.Windows.Forms.PictureBox
    Private WithEvents dent_definitiva As System.Windows.Forms.PictureBox
    Private WithEvents dent_temporal As System.Windows.Forms.PictureBox

End Class
