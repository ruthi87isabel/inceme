<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesos_Seleccionar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_Partes_Edit = New System.Windows.Forms.Button
        Me.CM3DataSet = New centro_medico.CM3DataSet
        Me.N_Procesos_ResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N_Procesos_ResumenTableAdapter = New centro_medico.CM3DataSetTableAdapters.N_Procesos_ResumenTableAdapter
        Me.N_Procesos_ResumenDataGridView = New System.Windows.Forms.DataGridView
        Me.ChkCol = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.columnEstado = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Procesos_ResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Procesos_ResumenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Procesos del Paciente"
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Aceptar.Enabled = False
        Me.btn_Aceptar.Image = Global.centro_medico.My.Resources.Resources._24_em_check
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.Location = New System.Drawing.Point(554, 24)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 34)
        Me.btn_Aceptar.TabIndex = 102
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.centro_medico.My.Resources.Resources._24_em_cross
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(554, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 34)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(529, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 112)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leyenda Estado"
        '
        'Label3
        '
        Me.Label3.Image = Global.centro_medico.My.Resources.Resources.Procesos_Finalizado
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(7, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Finalizado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Image = Global.centro_medico.My.Resources.Resources.Procesos_Cerrado
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cerrado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Image = Global.centro_medico.My.Resources.Resources.Procesos_Abierto
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Abierto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bt_Partes_Edit
        '
        Me.bt_Partes_Edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_Partes_Edit.FlatAppearance.BorderSize = 0
        Me.bt_Partes_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Partes_Edit.Image = Global.centro_medico.My.Resources.Resources._24_tag_pencil
        Me.bt_Partes_Edit.Location = New System.Drawing.Point(0, 312)
        Me.bt_Partes_Edit.Name = "bt_Partes_Edit"
        Me.bt_Partes_Edit.Size = New System.Drawing.Size(25, 31)
        Me.bt_Partes_Edit.TabIndex = 105
        Me.bt_Partes_Edit.UseVisualStyleBackColor = True
        '
        'CM3DataSet
        '
        Me.CM3DataSet.DataSetName = "CM3DataSet"
        Me.CM3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_Procesos_ResumenBindingSource
        '
        Me.N_Procesos_ResumenBindingSource.DataMember = "N_Procesos_Resumen"
        Me.N_Procesos_ResumenBindingSource.DataSource = Me.CM3DataSet
        '
        'N_Procesos_ResumenTableAdapter
        '
        Me.N_Procesos_ResumenTableAdapter.ClearBeforeFill = True
        '
        'N_Procesos_ResumenDataGridView
        '
        Me.N_Procesos_ResumenDataGridView.AllowUserToAddRows = False
        Me.N_Procesos_ResumenDataGridView.AllowUserToDeleteRows = False
        Me.N_Procesos_ResumenDataGridView.AllowUserToResizeRows = False
        Me.N_Procesos_ResumenDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_Procesos_ResumenDataGridView.AutoGenerateColumns = False
        Me.N_Procesos_ResumenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.N_Procesos_ResumenDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.N_Procesos_ResumenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChkCol, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.columnEstado, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.N_Procesos_ResumenDataGridView.DataSource = Me.N_Procesos_ResumenBindingSource
        Me.N_Procesos_ResumenDataGridView.Location = New System.Drawing.Point(6, 24)
        Me.N_Procesos_ResumenDataGridView.MultiSelect = False
        Me.N_Procesos_ResumenDataGridView.Name = "N_Procesos_ResumenDataGridView"
        Me.N_Procesos_ResumenDataGridView.RowHeadersVisible = False
        Me.N_Procesos_ResumenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.N_Procesos_ResumenDataGridView.Size = New System.Drawing.Size(517, 282)
        Me.N_Procesos_ResumenDataGridView.TabIndex = 105
        '
        'ChkCol
        '
        Me.ChkCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ChkCol.HeaderText = "Sel"
        Me.ChkCol.MinimumWidth = 35
        Me.ChkCol.Name = "ChkCol"
        Me.ChkCol.Width = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Proceso"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Proceso"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Paciente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_Paciente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaInicio"
        DataGridViewCellStyle1.Format = "d"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Inicio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FechaFinal"
        DataGridViewCellStyle2.Format = "d"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Final"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 87
        '
        'columnEstado
        '
        Me.columnEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.columnEstado.HeaderText = "Estado"
        Me.columnEstado.MinimumWidth = 45
        Me.columnEstado.Name = "columnEstado"
        Me.columnEstado.Width = 45
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Finalizado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Finalizado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID_Empresa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID_Empresa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_Mutua"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID_Mutua"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID_UsuarioCreador"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID_UsuarioCreador"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NOMBREPACIENTE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NOMBREPACIENTE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Empresa"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Empresa"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MUTUA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Mutua"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmProcesos_Seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 343)
        Me.Controls.Add(Me.N_Procesos_ResumenDataGridView)
        Me.Controls.Add(Me.bt_Partes_Edit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.Label7)
        Me.KeyPreview = True
        Me.Name = "frmProcesos_Seleccionar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione un proceso para ser vinculado"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CM3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Procesos_ResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Procesos_ResumenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_Partes_Edit As System.Windows.Forms.Button
    Friend WithEvents CM3DataSet As centro_medico.CM3DataSet
    Friend WithEvents N_Procesos_ResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents N_Procesos_ResumenTableAdapter As centro_medico.CM3DataSetTableAdapters.N_Procesos_ResumenTableAdapter
    Friend WithEvents N_Procesos_ResumenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ChkCol As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEstado As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
