<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlHorarios1 = New centro_medico.ctrlHorarios()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(171, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GridEX1
        '
        Me.GridEX1.DataSource = Me.BindingSource1
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Location = New System.Drawing.Point(0, 492)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(510, 121)
        Me.GridEX1.TabIndex = 2
        '
        'CtrlHorarios1
        '
        Me.CtrlHorarios1.Anno = 2014
        Me.CtrlHorarios1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlHorarios1.CalendarioXML = Nothing
        Me.CtrlHorarios1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlHorarios1.medicoid = 0
        Me.CtrlHorarios1.Name = "CtrlHorarios1"
        Me.CtrlHorarios1.Size = New System.Drawing.Size(1014, 503)
        Me.CtrlHorarios1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 643)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CtrlHorarios1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlHorarios1 As centro_medico.ctrlHorarios
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
