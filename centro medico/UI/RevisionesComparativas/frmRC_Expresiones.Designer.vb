<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRC_Expresiones
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
        Dim GridEX_Resultados_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRC_Expresiones))
        Me.txtExpression = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEvaluar = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.GridEX_Resultados = New Janus.Windows.GridEX.GridEX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chkOcultarImpresionCliente = New System.Windows.Forms.CheckBox()
        Me.lblNombreDato = New System.Windows.Forms.Label()
        CType(Me.GridEX_Resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtExpression
        '
        Me.txtExpression.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpression.Location = New System.Drawing.Point(312, 45)
        Me.txtExpression.Multiline = True
        Me.txtExpression.Name = "txtExpression"
        Me.txtExpression.Size = New System.Drawing.Size(311, 110)
        Me.txtExpression.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Defina su expresión (Ej: Peso/TA max * 0.14 )"
        '
        'txtEvaluar
        '
        Me.txtEvaluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEvaluar.Location = New System.Drawing.Point(312, 229)
        Me.txtEvaluar.Name = "txtEvaluar"
        Me.txtEvaluar.Size = New System.Drawing.Size(75, 23)
        Me.txtEvaluar.TabIndex = 2
        Me.txtEvaluar.Text = "Evaluar"
        Me.txtEvaluar.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResult.Location = New System.Drawing.Point(312, 185)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(311, 38)
        Me.txtResult.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Resultado"
        '
        'lblError
        '
        Me.lblError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(465, 226)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(158, 13)
        Me.lblError.TabIndex = 5
        Me.lblError.Text = "Error, debe chequear su sintaxis"
        Me.lblError.Visible = False
        '
        'GridEX_Resultados
        '
        Me.GridEX_Resultados.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX_Resultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX_Resultados.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        Me.GridEX_Resultados.ColumnAutoResize = True
        GridEX_Resultados_DesignTimeLayout.LayoutString = resources.GetString("GridEX_Resultados_DesignTimeLayout.LayoutString")
        Me.GridEX_Resultados.DesignTimeLayout = GridEX_Resultados_DesignTimeLayout
        Me.GridEX_Resultados.FocusCellFormatStyle.BackColor = System.Drawing.Color.Silver
        Me.GridEX_Resultados.FocusCellFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GridEX_Resultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX_Resultados.GroupByBoxVisible = False
        Me.GridEX_Resultados.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEX_Resultados.Location = New System.Drawing.Point(9, 45)
        Me.GridEX_Resultados.Name = "GridEX_Resultados"
        Me.GridEX_Resultados.SelectedFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.GridEX_Resultados.Size = New System.Drawing.Size(288, 249)
        Me.GridEX_Resultados.TabIndex = 13
        Me.GridEX_Resultados.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Campos numéricos del modelo"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Doble clic para insertar campo en la expresión"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(468, 287)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(551, 287)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'chkOcultarImpresionCliente
        '
        Me.chkOcultarImpresionCliente.AutoSize = True
        Me.chkOcultarImpresionCliente.Location = New System.Drawing.Point(9, 316)
        Me.chkOcultarImpresionCliente.Name = "chkOcultarImpresionCliente"
        Me.chkOcultarImpresionCliente.Size = New System.Drawing.Size(174, 17)
        Me.chkOcultarImpresionCliente.TabIndex = 14
        Me.chkOcultarImpresionCliente.Text = "Ocultar en el informe del cliente"
        Me.chkOcultarImpresionCliente.UseVisualStyleBackColor = True
        '
        'lblNombreDato
        '
        Me.lblNombreDato.AutoSize = True
        Me.lblNombreDato.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNombreDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDato.Location = New System.Drawing.Point(6, 9)
        Me.lblNombreDato.Name = "lblNombreDato"
        Me.lblNombreDato.Size = New System.Drawing.Size(19, 13)
        Me.lblNombreDato.TabIndex = 15
        Me.lblNombreDato.Text = "..."
        '
        'frmRC_Expresiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 341)
        Me.Controls.Add(Me.lblNombreDato)
        Me.Controls.Add(Me.chkOcultarImpresionCliente)
        Me.Controls.Add(Me.GridEX_Resultados)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtEvaluar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExpression)
        Me.Name = "frmRC_Expresiones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campo Calculado"
        CType(Me.GridEX_Resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtExpression As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEvaluar As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents GridEX_Resultados As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chkOcultarImpresionCliente As System.Windows.Forms.CheckBox
    Friend WithEvents lblNombreDato As System.Windows.Forms.Label
End Class
