<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BancoImag_NuevaCategoria
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
        Me.RC_Categorias_GaleriaImageneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.txtLocacion = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        DescripcionLabel = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.RC_Categorias_GaleriaImageneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(13, 59)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 0
        DescripcionLabel.Text = "Descripcion:"
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(43, 25)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(36, 13)
        TituloLabel.TabIndex = 2
        TituloLabel.Text = "Titulo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(25, 125)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(54, 13)
        Label1.TabIndex = 0
        Label1.Text = "Locación:"
        '
        'RC_Categorias_GaleriaImageneBindingSource
        '
        Me.RC_Categorias_GaleriaImageneBindingSource.DataSource = GetType(RC_Categorias_GaleriaImagene)
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RC_Categorias_GaleriaImageneBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(85, 59)
        Me.DescripcionTextBox.MaxLength = 200
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(369, 55)
        Me.DescripcionTextBox.TabIndex = 1
        '
        'TituloTextBox
        '
        Me.TituloTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RC_Categorias_GaleriaImageneBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(85, 22)
        Me.TituloTextBox.MaxLength = 50
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(369, 20)
        Me.TituloTextBox.TabIndex = 0
        '
        'txtLocacion
        '
        Me.txtLocacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocacion.Location = New System.Drawing.Point(85, 125)
        Me.txtLocacion.Name = "txtLocacion"
        Me.txtLocacion.ReadOnly = True
        Me.txtLocacion.Size = New System.Drawing.Size(369, 20)
        Me.txtLocacion.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(379, 166)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frm_BancoImag_NuevaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 198)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.txtLocacion)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Name = "frm_BancoImag_NuevaCategoria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar Categoría"
        CType(Me.RC_Categorias_GaleriaImageneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TituloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Public WithEvents RC_Categorias_GaleriaImageneBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents txtLocacion As System.Windows.Forms.TextBox
End Class
