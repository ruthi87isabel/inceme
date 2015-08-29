<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BancoImag_NuevaImagen
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.RC_Categorias_ImageneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLoadImage = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        DescripcionLabel = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.RC_Categorias_ImageneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(463, 67)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 1
        DescripcionLabel.Text = "Descripcion:"
        '
        'TituloLabel
        '
        TituloLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(463, 15)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(36, 13)
        TituloLabel.TabIndex = 7
        TituloLabel.Text = "Titulo:"
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(463, 237)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 13)
        Label1.TabIndex = 7
        Label1.Text = "Categoría:"
        '
        'RC_Categorias_ImageneBindingSource
        '
        Me.RC_Categorias_ImageneBindingSource.DataSource = GetType(RC_Categorias_Imagene)
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RC_Categorias_ImageneBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(466, 83)
        Me.DescripcionTextBox.MaxLength = 200
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(426, 137)
        Me.DescripcionTextBox.TabIndex = 1
        '
        'TituloTextBox
        '
        Me.TituloTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RC_Categorias_ImageneBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(466, 33)
        Me.TituloTextBox.MaxLength = 50
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(426, 20)
        Me.TituloTextBox.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 368)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnLoadImage
        '
        Me.btnLoadImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoadImage.Location = New System.Drawing.Point(12, 389)
        Me.btnLoadImage.Name = "btnLoadImage"
        Me.btnLoadImage.Size = New System.Drawing.Size(37, 23)
        Me.btnLoadImage.TabIndex = 3
        Me.btnLoadImage.Text = "..."
        Me.btnLoadImage.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(817, 389)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCategoria.Location = New System.Drawing.Point(466, 253)
        Me.txtCategoria.MaxLength = 50
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(426, 20)
        Me.txtCategoria.TabIndex = 2
        '
        'frm_BancoImag_NuevaImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 424)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnLoadImage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Name = "frm_BancoImag_NuevaImagen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Imagen"
        CType(Me.RC_Categorias_ImageneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TituloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLoadImage As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Public WithEvents RC_Categorias_ImageneBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents txtCategoria As System.Windows.Forms.TextBox
End Class
