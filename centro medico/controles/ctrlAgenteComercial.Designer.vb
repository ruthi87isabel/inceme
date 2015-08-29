<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlAgenteComercial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlAgenteComercial))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Text = New System.Windows.Forms.TextBox
        Me.pb_Seleccionar = New System.Windows.Forms.PictureBox
        CType(Me.pb_Seleccionar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Agente:"
        '
        'txt_Text
        '
        Me.txt_Text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Text.Location = New System.Drawing.Point(51, 6)
        Me.txt_Text.Name = "txt_Text"
        Me.txt_Text.ReadOnly = True
        Me.txt_Text.Size = New System.Drawing.Size(188, 20)
        Me.txt_Text.TabIndex = 87
        '
        'pb_Seleccionar
        '
        Me.pb_Seleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_Seleccionar.Image = CType(resources.GetObject("pb_Seleccionar.Image"), System.Drawing.Image)
        Me.pb_Seleccionar.Location = New System.Drawing.Point(240, 2)
        Me.pb_Seleccionar.Name = "pb_Seleccionar"
        Me.pb_Seleccionar.Size = New System.Drawing.Size(24, 24)
        Me.pb_Seleccionar.TabIndex = 89
        Me.pb_Seleccionar.TabStop = False
        '
        'ctrlAgenteComercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pb_Seleccionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Text)
        Me.Name = "ctrlAgenteComercial"
        Me.Size = New System.Drawing.Size(265, 29)
        CType(Me.pb_Seleccionar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_Seleccionar As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Text As System.Windows.Forms.TextBox

End Class
