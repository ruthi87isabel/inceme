<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarMutua
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
        Me.PACIENTESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tst_Codigo = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tst_NombreMutua = New System.Windows.Forms.ToolStripTextBox()
        Me.MUTUABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MUTUADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PACIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PACIENTESBindingNavigator.SuspendLayout()
        CType(Me.MUTUABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PACIENTESBindingNavigator
        '
        Me.PACIENTESBindingNavigator.AddNewItem = Nothing
        Me.PACIENTESBindingNavigator.CountItem = Nothing
        Me.PACIENTESBindingNavigator.DeleteItem = Nothing
        Me.PACIENTESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tst_Codigo, Me.ToolStripLabel3, Me.tst_NombreMutua})
        Me.PACIENTESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PACIENTESBindingNavigator.MoveFirstItem = Nothing
        Me.PACIENTESBindingNavigator.MoveLastItem = Nothing
        Me.PACIENTESBindingNavigator.MoveNextItem = Nothing
        Me.PACIENTESBindingNavigator.MovePreviousItem = Nothing
        Me.PACIENTESBindingNavigator.Name = "PACIENTESBindingNavigator"
        Me.PACIENTESBindingNavigator.PositionItem = Nothing
        Me.PACIENTESBindingNavigator.Size = New System.Drawing.Size(693, 25)
        Me.PACIENTESBindingNavigator.TabIndex = 4
        Me.PACIENTESBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel2.Text = "CODIGO:"
        '
        'tst_Codigo
        '
        Me.tst_Codigo.Name = "tst_Codigo"
        Me.tst_Codigo.Size = New System.Drawing.Size(60, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel3.Text = "Nombre:"
        '
        'tst_NombreMutua
        '
        Me.tst_NombreMutua.Name = "tst_NombreMutua"
        Me.tst_NombreMutua.Size = New System.Drawing.Size(110, 25)
        '
        'MUTUABindingSource
        '
        Me.MUTUABindingSource.DataSource = GetType(centro_medico.MUTUA)
        '
        'MUTUADataGridView
        '
        Me.MUTUADataGridView.AllowUserToAddRows = False
        Me.MUTUADataGridView.AllowUserToDeleteRows = False
        Me.MUTUADataGridView.AutoGenerateColumns = False
        Me.MUTUADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MUTUADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn9})
        Me.MUTUADataGridView.DataSource = Me.MUTUABindingSource
        Me.MUTUADataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MUTUADataGridView.Location = New System.Drawing.Point(0, 25)
        Me.MUTUADataGridView.Name = "MUTUADataGridView"
        Me.MUTUADataGridView.RowHeadersVisible = False
        Me.MUTUADataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MUTUADataGridView.Size = New System.Drawing.Size(693, 481)
        Me.MUTUADataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CMUTUA"
        Me.DataGridViewTextBoxColumn13.HeaderText = "CMUTUA"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DIRECCION"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DIRECCION"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "POBLACION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "POBLACION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PROVINCIA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PROVINCIA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MAIL"
        Me.DataGridViewTextBoxColumn9.HeaderText = "MAIL"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'frmBuscarMutua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 506)
        Me.Controls.Add(Me.MUTUADataGridView)
        Me.Controls.Add(Me.PACIENTESBindingNavigator)
        Me.Name = "frmBuscarMutua"
        Me.Text = "frmBuscarMutua"
        CType(Me.PACIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PACIENTESBindingNavigator.ResumeLayout(False)
        Me.PACIENTESBindingNavigator.PerformLayout()
        CType(Me.MUTUABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PACIENTESBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tst_Codigo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tst_NombreMutua As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents MUTUABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUTUADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
