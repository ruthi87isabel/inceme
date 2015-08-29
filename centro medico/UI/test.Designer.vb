<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(test))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tlsBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tlsNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tlsBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tlsImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsCerrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsBuscar, Me.tlsNuevo, Me.tlsBorrar, Me.tlsImprimir, Me.ToolStripSeparator1, Me.tlsCerrar})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(674, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlsBuscar
        '
        Me.tlsBuscar.Image = Global.centro_medico.My.Resources.Resources._24_frame
        Me.tlsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsBuscar.Name = "tlsBuscar"
        Me.tlsBuscar.Size = New System.Drawing.Size(59, 22)
        Me.tlsBuscar.Text = "Buscar"
        '
        'tlsNuevo
        '
        Me.tlsNuevo.Image = Global.centro_medico.My.Resources.Resources._24_em_plus
        Me.tlsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsNuevo.Name = "tlsNuevo"
        Me.tlsNuevo.Size = New System.Drawing.Size(58, 22)
        Me.tlsNuevo.Text = "Nuevo"
        '
        'tlsBorrar
        '
        Me.tlsBorrar.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.tlsBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsBorrar.Name = "tlsBorrar"
        Me.tlsBorrar.Size = New System.Drawing.Size(57, 22)
        Me.tlsBorrar.Text = "Borrar"
        '
        'tlsImprimir
        '
        Me.tlsImprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.tlsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsImprimir.Name = "tlsImprimir"
        Me.tlsImprimir.Size = New System.Drawing.Size(65, 22)
        Me.tlsImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlsCerrar
        '
        Me.tlsCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlsCerrar.Image = CType(resources.GetObject("tlsCerrar.Image"), System.Drawing.Image)
        Me.tlsCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsCerrar.Name = "tlsCerrar"
        Me.tlsCerrar.Size = New System.Drawing.Size(42, 22)
        Me.tlsCerrar.Text = "Cerrar"
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 424)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "test"
        Me.Text = "test"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
