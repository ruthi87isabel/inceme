<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlEmpresa2
    Inherits System.Windows.Forms.UserControl

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
        Dim comboEmpresas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlEmpresa2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EMPRESABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Deseleccionar = New System.Windows.Forms.Button()
        Me.comboEmpresas = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        CType(Me.EMPRESABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Empresa:"
        '
        'EMPRESABindingSource
        '
        Me.EMPRESABindingSource.DataSource = GetType(centro_medico.EMPRESA)
        '
        'btn_Deseleccionar
        '
        Me.btn_Deseleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Deseleccionar.FlatAppearance.BorderSize = 0
        Me.btn_Deseleccionar.Image = My.Resources.Resources._16_em_cross
        Me.btn_Deseleccionar.Location = New System.Drawing.Point(234, -1)
        Me.btn_Deseleccionar.Name = "btn_Deseleccionar"
        Me.btn_Deseleccionar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Deseleccionar.TabIndex = 15
        Me.btn_Deseleccionar.UseVisualStyleBackColor = True
        '
        'comboEmpresas
        '
        Me.comboEmpresas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboEmpresas.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.comboEmpresas.DataSource = Me.EMPRESABindingSource
        comboEmpresas_DesignTimeLayout.LayoutString = resources.GetString("comboEmpresas_DesignTimeLayout.LayoutString")
        Me.comboEmpresas.DesignTimeLayout = comboEmpresas_DesignTimeLayout
        Me.comboEmpresas.DisplayMember = "NOMBRE"
        Me.comboEmpresas.Location = New System.Drawing.Point(49, 1)
        Me.comboEmpresas.Name = "comboEmpresas"
        Me.comboEmpresas.SelectedIndex = -1
        Me.comboEmpresas.SelectedItem = Nothing
        Me.comboEmpresas.SelectInDataSource = True
        Me.comboEmpresas.Size = New System.Drawing.Size(184, 20)
        Me.comboEmpresas.TabIndex = 18
        Me.comboEmpresas.Text = "Seleccione empresa"
        Me.comboEmpresas.ValueMember = "CEMPRESA"
        '
        'ctrlEmpresa2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.comboEmpresas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Deseleccionar)
        Me.Name = "ctrlEmpresa2"
        Me.Size = New System.Drawing.Size(256, 22)
        CType(Me.EMPRESABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Deseleccionar As System.Windows.Forms.Button
    Friend WithEvents EMPRESABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comboEmpresas As Janus.Windows.GridEX.EditControls.MultiColumnCombo

End Class
