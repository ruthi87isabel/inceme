<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagarDocumentos
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
        Dim GridEXDocs_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagarDocumentos))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCredito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTextoTotalAPagar = New System.Windows.Forms.Label()
        Me.chkUtilizarCredito = New System.Windows.Forms.CheckBox()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridEXDocs = New Janus.Windows.GridEX.GridEX()
        Me.IDocumentoPagableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlFormaPago21 = New centro_medico.ctrlFormaPago2()
        CType(Me.GridEXDocs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDocumentoPagableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(438, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Crédito:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCredito
        '
        Me.txtCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCredito.BackColor = System.Drawing.Color.LightYellow
        Me.txtCredito.Enabled = False
        Me.txtCredito.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtCredito.FormatString = "C2"
        Me.txtCredito.Location = New System.Drawing.Point(491, 11)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.ReadOnly = True
        Me.txtCredito.Size = New System.Drawing.Size(75, 20)
        Me.txtCredito.TabIndex = 28
        Me.txtCredito.Text = "0,00 €"
        Me.txtCredito.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.LightYellow
        Me.txtImporte.Enabled = False
        Me.txtImporte.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtImporte.FormatString = "C2"
        Me.txtImporte.Location = New System.Drawing.Point(55, 12)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(101, 20)
        Me.txtImporte.TabIndex = 27
        Me.txtImporte.Text = "0,00 €"
        Me.txtImporte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTextoTotalAPagar
        '
        Me.lblTextoTotalAPagar.Location = New System.Drawing.Point(-1, 15)
        Me.lblTextoTotalAPagar.Name = "lblTextoTotalAPagar"
        Me.lblTextoTotalAPagar.Size = New System.Drawing.Size(53, 17)
        Me.lblTextoTotalAPagar.TabIndex = 24
        Me.lblTextoTotalAPagar.Text = "Importe:"
        Me.lblTextoTotalAPagar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkUtilizarCredito
        '
        Me.chkUtilizarCredito.AutoSize = True
        Me.chkUtilizarCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkUtilizarCredito.Location = New System.Drawing.Point(203, 14)
        Me.chkUtilizarCredito.Name = "chkUtilizarCredito"
        Me.chkUtilizarCredito.Size = New System.Drawing.Size(207, 17)
        Me.chkUtilizarCredito.TabIndex = 30
        Me.chkUtilizarCredito.Text = "PAGAR CON CRÉDITO DISPONIBLE"
        Me.chkUtilizarCredito.UseVisualStyleBackColor = False
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(55, 43)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(101, 20)
        Me.dtp_Fecha.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Documentos Pendientes"
        '
        'ButtonOk
        '
        Me.ButtonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOk.Location = New System.Drawing.Point(590, 12)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(106, 59)
        Me.ButtonOk.TabIndex = 36
        Me.ButtonOk.Text = "Efectuar Pago"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Fecha:"
        '
        'GridEXDocs
        '
        Me.GridEXDocs.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDocs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXDocs.ColumnAutoResize = True
        Me.GridEXDocs.DataSource = Me.IDocumentoPagableBindingSource
        GridEXDocs_DesignTimeLayout.LayoutString = resources.GetString("GridEXDocs_DesignTimeLayout.LayoutString")
        Me.GridEXDocs.DesignTimeLayout = GridEXDocs_DesignTimeLayout
        Me.GridEXDocs.ExpandableCards = False
        Me.GridEXDocs.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDocs.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridEXDocs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXDocs.GroupByBoxVisible = False
        Me.GridEXDocs.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GridEXDocs.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXDocs.Hierarchical = True
        Me.GridEXDocs.Location = New System.Drawing.Point(12, 91)
        Me.GridEXDocs.Name = "GridEXDocs"
        Me.GridEXDocs.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEXDocs.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXDocs.Size = New System.Drawing.Size(684, 330)
        Me.GridEXDocs.TabIndex = 38
        Me.GridEXDocs.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridEXDocs.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridEXDocs.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEXDocs.TotalRowFormatStyle.FontSize = 9.0!
        Me.GridEXDocs.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEXDocs.TreeLines = False
        '
        'IDocumentoPagableBindingSource
        '
        Me.IDocumentoPagableBindingSource.DataSource = GetType(centro_medico.IDocumentoPagable)
        '
        'CtrlFormaPago21
        '
        Me.CtrlFormaPago21.ID_FORMASPAGO = Nothing
        Me.CtrlFormaPago21.Location = New System.Drawing.Point(203, 40)
        Me.CtrlFormaPago21.Name = "CtrlFormaPago21"
        Me.CtrlFormaPago21.Size = New System.Drawing.Size(363, 23)
        Me.CtrlFormaPago21.TabIndex = 29
        '
        'frmPagarDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 446)
        Me.Controls.Add(Me.GridEXDocs)
        Me.Controls.Add(Me.CtrlFormaPago21)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCredito)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.lblTextoTotalAPagar)
        Me.Controls.Add(Me.chkUtilizarCredito)
        Me.Controls.Add(Me.dtp_Fecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmPagarDocumentos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagar documentos"
        CType(Me.GridEXDocs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDocumentoPagableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents CtrlFormaPago21 As centro_medico.ctrlFormaPago2
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtCredito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents txtImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Public WithEvents lblTextoTotalAPagar As System.Windows.Forms.Label
    Public WithEvents chkUtilizarCredito As System.Windows.Forms.CheckBox
    Public WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridEXDocs As Janus.Windows.GridEX.GridEX
    Friend WithEvents IDocumentoPagableBindingSource As System.Windows.Forms.BindingSource
End Class
