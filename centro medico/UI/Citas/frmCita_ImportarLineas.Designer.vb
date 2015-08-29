<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCita_ImportarLineas
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
        Dim GridEXRevisiones_Layout_0 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCita_ImportarLineas))
        Dim GridEXDentales_Layout_0 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.PACIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEXRevisiones = New Janus.Windows.GridEX.GridEX()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabRevisionesComparativas = New System.Windows.Forms.TabPage()
        Me.TabDental = New System.Windows.Forms.TabPage()
        Me.chkRealizado = New System.Windows.Forms.CheckBox()
        Me.chkConfirmado = New System.Windows.Forms.CheckBox()
        Me.GridEXDentales = New Janus.Windows.GridEX.GridEX()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEXRevisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabRevisionesComparativas.SuspendLayout()
        Me.TabDental.SuspendLayout()
        CType(Me.GridEXDentales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PACIENTEBindingSource
        '
        Me.PACIENTEBindingSource.DataSource = GetType(centro_medico.PACIENTE)
        '
        'GridEXRevisiones
        '
        Me.GridEXRevisiones.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXRevisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXRevisiones.DataSource = Me.PACIENTEBindingSource
        Me.GridEXRevisiones.ExpandableCards = False
        Me.GridEXRevisiones.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXRevisiones.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridEXRevisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXRevisiones.GroupByBoxVisible = False
        Me.GridEXRevisiones.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GridEXRevisiones.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXRevisiones.Hierarchical = True
        GridEXRevisiones_Layout_0.DataSource = Me.PACIENTEBindingSource
        GridEXRevisiones_Layout_0.IsCurrentLayout = True
        GridEXRevisiones_Layout_0.Key = "Joder"
        GridEXRevisiones_Layout_0.LayoutString = resources.GetString("GridEXRevisiones_Layout_0.LayoutString")
        Me.GridEXRevisiones.Layouts.AddRange(New Janus.Windows.GridEX.GridEXLayout() {GridEXRevisiones_Layout_0})
        Me.GridEXRevisiones.Location = New System.Drawing.Point(6, 6)
        Me.GridEXRevisiones.Name = "GridEXRevisiones"
        Me.GridEXRevisiones.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEXRevisiones.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXRevisiones.Size = New System.Drawing.Size(739, 435)
        Me.GridEXRevisiones.TabIndex = 1
        Me.GridEXRevisiones.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridEXRevisiones.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridEXRevisiones.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEXRevisiones.TotalRowFormatStyle.FontSize = 9.0!
        Me.GridEXRevisiones.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEXRevisiones.TreeLines = False
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Location = New System.Drawing.Point(604, 491)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 2
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(685, 491)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabDental)
        Me.TabControl1.Controls.Add(Me.TabRevisionesComparativas)
        Me.TabControl1.Location = New System.Drawing.Point(7, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(758, 473)
        Me.TabControl1.TabIndex = 3
        '
        'TabRevisionesComparativas
        '
        Me.TabRevisionesComparativas.Controls.Add(Me.GridEXRevisiones)
        Me.TabRevisionesComparativas.Location = New System.Drawing.Point(4, 22)
        Me.TabRevisionesComparativas.Name = "TabRevisionesComparativas"
        Me.TabRevisionesComparativas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRevisionesComparativas.Size = New System.Drawing.Size(750, 447)
        Me.TabRevisionesComparativas.TabIndex = 0
        Me.TabRevisionesComparativas.Text = "Revisiones comparativas"
        Me.TabRevisionesComparativas.UseVisualStyleBackColor = True
        '
        'TabDental
        '
        Me.TabDental.Controls.Add(Me.chkRealizado)
        Me.TabDental.Controls.Add(Me.chkConfirmado)
        Me.TabDental.Controls.Add(Me.GridEXDentales)
        Me.TabDental.Location = New System.Drawing.Point(4, 22)
        Me.TabDental.Name = "TabDental"
        Me.TabDental.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDental.Size = New System.Drawing.Size(750, 447)
        Me.TabDental.TabIndex = 1
        Me.TabDental.Text = "Presupuestos dentales"
        Me.TabDental.UseVisualStyleBackColor = True
        '
        'chkRealizado
        '
        Me.chkRealizado.AutoSize = True
        Me.chkRealizado.Location = New System.Drawing.Point(91, 6)
        Me.chkRealizado.Name = "chkRealizado"
        Me.chkRealizado.Size = New System.Drawing.Size(73, 17)
        Me.chkRealizado.TabIndex = 4
        Me.chkRealizado.Text = "Realizado"
        Me.chkRealizado.UseVisualStyleBackColor = True
        '
        'chkConfirmado
        '
        Me.chkConfirmado.AutoSize = True
        Me.chkConfirmado.Location = New System.Drawing.Point(6, 6)
        Me.chkConfirmado.Name = "chkConfirmado"
        Me.chkConfirmado.Size = New System.Drawing.Size(79, 17)
        Me.chkConfirmado.TabIndex = 3
        Me.chkConfirmado.Text = "Confirmado"
        Me.chkConfirmado.UseVisualStyleBackColor = True
        '
        'GridEXDentales
        '
        Me.GridEXDentales.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDentales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEXDentales.DataSource = Me.PACIENTEBindingSource
        Me.GridEXDentales.ExpandableCards = False
        Me.GridEXDentales.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXDentales.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridEXDentales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXDentales.GroupByBoxVisible = False
        Me.GridEXDentales.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GridEXDentales.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXDentales.Hierarchical = True
        GridEXDentales_Layout_0.DataSource = Me.PACIENTEBindingSource
        GridEXDentales_Layout_0.IsCurrentLayout = True
        GridEXDentales_Layout_0.Key = "Joder"
        GridEXDentales_Layout_0.LayoutString = resources.GetString("GridEXDentales_Layout_0.LayoutString")
        Me.GridEXDentales.Layouts.AddRange(New Janus.Windows.GridEX.GridEXLayout() {GridEXDentales_Layout_0})
        Me.GridEXDentales.Location = New System.Drawing.Point(6, 40)
        Me.GridEXDentales.Name = "GridEXDentales"
        Me.GridEXDentales.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.GridEXDentales.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEXDentales.Size = New System.Drawing.Size(739, 401)
        Me.GridEXDentales.TabIndex = 2
        Me.GridEXDentales.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridEXDentales.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridEXDentales.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEXDentales.TotalRowFormatStyle.FontSize = 9.0!
        Me.GridEXDentales.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEXDentales.TreeLines = False
        '
        'frmCita_ImportarLineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 518)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnImportar)
        Me.Name = "frmCita_ImportarLineas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Lineas de conceptos facturables"
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEXRevisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabRevisionesComparativas.ResumeLayout(False)
        Me.TabDental.ResumeLayout(False)
        Me.TabDental.PerformLayout()
        CType(Me.GridEXDentales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridEXRevisiones As Janus.Windows.GridEX.GridEX
    Friend WithEvents PACIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabRevisionesComparativas As System.Windows.Forms.TabPage
    Friend WithEvents TabDental As System.Windows.Forms.TabPage
    Friend WithEvents GridEXDentales As Janus.Windows.GridEX.GridEX
    Friend WithEvents chkRealizado As System.Windows.Forms.CheckBox
    Friend WithEvents chkConfirmado As System.Windows.Forms.CheckBox
End Class
