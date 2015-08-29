<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlRichTextboxAvanzado
    Inherits System.Windows.Forms.RichTextBox

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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tstAplicarPlantilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstPegar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstCortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstAplicarPlantilla, Me.tstCopiar, Me.tstPegar, Me.tstCortar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(157, 92)
        '
        'tstAplicarPlantilla
        '
        Me.tstAplicarPlantilla.Name = "tstAplicarPlantilla"
        Me.tstAplicarPlantilla.Size = New System.Drawing.Size(156, 22)
        Me.tstAplicarPlantilla.Text = "Aplicar Plantilla"
        '
        'tstCopiar
        '
        Me.tstCopiar.Name = "tstCopiar"
        Me.tstCopiar.Size = New System.Drawing.Size(156, 22)
        Me.tstCopiar.Text = "Copiar"
        '
        'tstPegar
        '
        Me.tstPegar.Name = "tstPegar"
        Me.tstPegar.Size = New System.Drawing.Size(156, 22)
        Me.tstPegar.Text = "Pegar"
        '
        'tstCortar
        '
        Me.tstCortar.Name = "tstCortar"
        Me.tstCortar.Size = New System.Drawing.Size(156, 22)
        Me.tstCortar.Text = "Cortar"
        '
        'ctrlRichTextboxAvanzado
        '
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tstAplicarPlantilla As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstPegar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstCortar As System.Windows.Forms.ToolStripMenuItem

End Class
