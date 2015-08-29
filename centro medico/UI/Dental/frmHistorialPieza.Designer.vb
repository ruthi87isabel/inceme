<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorialPieza
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
        Me.lvw = New System.Windows.Forms.ListView
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.lblPieza = New System.Windows.Forms.Label
        Me.pbx = New System.Windows.Forms.PictureBox
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvw
        '
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader4})
        Me.lvw.FullRowSelect = True
        Me.lvw.HideSelection = False
        Me.lvw.Location = New System.Drawing.Point(79, 33)
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(460, 244)
        Me.lvw.TabIndex = 14
        Me.lvw.Tag = "1"
        Me.lvw.UseCompatibleStateImageBehavior = False
        Me.lvw.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Fecha"
        Me.columnHeader1.Width = 125
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Tratamiento"
        Me.columnHeader2.Width = 225
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Cuadrantes"
        Me.columnHeader4.Width = 80
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(456, 283)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(83, 24)
        Me.btnCerrar.TabIndex = 15
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblPieza
        '
        Me.lblPieza.AutoSize = True
        Me.lblPieza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPieza.Location = New System.Drawing.Point(12, 9)
        Me.lblPieza.Name = "lblPieza"
        Me.lblPieza.Size = New System.Drawing.Size(46, 13)
        Me.lblPieza.TabIndex = 16
        Me.lblPieza.Text = "Pieza: "
        '
        'pbx
        '
        Me.pbx.BackColor = System.Drawing.Color.White
        Me.pbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx.Location = New System.Drawing.Point(13, 33)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(60, 243)
        Me.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbx.TabIndex = 17
        Me.pbx.TabStop = False
        '
        'frmHistorialPieza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 319)
        Me.Controls.Add(Me.pbx)
        Me.Controls.Add(Me.lblPieza)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lvw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHistorialPieza"
        Me.Text = "Historial"
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lvw As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lblPieza As System.Windows.Forms.Label
    Friend WithEvents pbx As System.Windows.Forms.PictureBox
End Class
