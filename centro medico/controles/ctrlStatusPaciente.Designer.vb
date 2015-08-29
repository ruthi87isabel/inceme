<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlStatusPaciente
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_Recibos = New Janus.Windows.EditControls.UIButton()
        Me.btn_Citas = New Janus.Windows.EditControls.UIButton()
        Me.btn_Facturas = New Janus.Windows.EditControls.UIButton()
        Me.btn_Tickets = New Janus.Windows.EditControls.UIButton()
        Me.btn_FacturasTPV = New Janus.Windows.EditControls.UIButton()
        Me.lblDebe = New System.Windows.Forms.Label()
        Me.lblCredito = New System.Windows.Forms.Label()
        Me.JanusSuperTip1 = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.SuspendLayout()
        '
        'btn_Recibos
        '
        Me.btn_Recibos.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.btn_Recibos.Image = Global.centro_medico.My.Resources.Resources.Documents_small
        Me.btn_Recibos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btn_Recibos.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Recibos.Location = New System.Drawing.Point(141, 0)
        Me.btn_Recibos.Name = "btn_Recibos"
        Me.btn_Recibos.ShowFocusRectangle = False
        Me.btn_Recibos.Size = New System.Drawing.Size(46, 26)
        Me.btn_Recibos.TabIndex = 1
        Me.btn_Recibos.Text = "0"
        Me.btn_Recibos.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far
        Me.btn_Recibos.ToolTipText = "Recibos por pagar"
        Me.btn_Recibos.UseThemes = False
        Me.btn_Recibos.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'btn_Citas
        '
        Me.btn_Citas.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.btn_Citas.Image = Global.centro_medico.My.Resources.Resources.Citas
        Me.btn_Citas.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btn_Citas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Citas.Location = New System.Drawing.Point(0, 0)
        Me.btn_Citas.Name = "btn_Citas"
        Me.btn_Citas.ShowFocusRectangle = False
        Me.btn_Citas.Size = New System.Drawing.Size(46, 26)
        Me.btn_Citas.TabIndex = 1
        Me.btn_Citas.Text = "0"
        Me.btn_Citas.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far
        Me.btn_Citas.ToolTipText = "Citas por pagar"
        Me.btn_Citas.UseThemes = False
        Me.btn_Citas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'btn_Facturas
        '
        Me.btn_Facturas.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.btn_Facturas.Image = Global.centro_medico.My.Resources.Resources.Facturas
        Me.btn_Facturas.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btn_Facturas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Facturas.Location = New System.Drawing.Point(47, 0)
        Me.btn_Facturas.Name = "btn_Facturas"
        Me.btn_Facturas.ShowFocusRectangle = False
        Me.btn_Facturas.Size = New System.Drawing.Size(46, 26)
        Me.btn_Facturas.TabIndex = 1
        Me.btn_Facturas.Text = "0"
        Me.btn_Facturas.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far
        Me.btn_Facturas.ToolTipText = "Facturas Médicas a pagar"
        Me.btn_Facturas.UseThemes = False
        Me.btn_Facturas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'btn_Tickets
        '
        Me.btn_Tickets.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.btn_Tickets.Image = Global.centro_medico.My.Resources.Resources.stack_2
        Me.btn_Tickets.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btn_Tickets.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Tickets.Location = New System.Drawing.Point(188, 0)
        Me.btn_Tickets.Name = "btn_Tickets"
        Me.btn_Tickets.ShowFocusRectangle = False
        Me.btn_Tickets.Size = New System.Drawing.Size(46, 26)
        Me.btn_Tickets.TabIndex = 1
        Me.btn_Tickets.Text = "0"
        Me.btn_Tickets.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far
        Me.btn_Tickets.ToolTipText = "Tickets por pagar"
        Me.btn_Tickets.UseThemes = False
        Me.btn_Tickets.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'btn_FacturasTPV
        '
        Me.btn_FacturasTPV.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.btn_FacturasTPV.Image = Global.centro_medico.My.Resources.Resources.Box50closed32x32
        Me.btn_FacturasTPV.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btn_FacturasTPV.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_FacturasTPV.Location = New System.Drawing.Point(94, 0)
        Me.btn_FacturasTPV.Name = "btn_FacturasTPV"
        Me.btn_FacturasTPV.ShowFocusRectangle = False
        Me.btn_FacturasTPV.Size = New System.Drawing.Size(46, 26)
        Me.btn_FacturasTPV.TabIndex = 1
        Me.btn_FacturasTPV.Text = "0"
        Me.btn_FacturasTPV.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Far
        Me.btn_FacturasTPV.ToolTipText = "Facturas TPV a pagar"
        Me.btn_FacturasTPV.UseThemes = False
        Me.btn_FacturasTPV.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'lblDebe
        '
        Me.lblDebe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDebe.ForeColor = System.Drawing.Color.Red
        Me.lblDebe.Location = New System.Drawing.Point(237, 2)
        Me.lblDebe.Name = "lblDebe"
        Me.lblDebe.Padding = New System.Windows.Forms.Padding(2)
        Me.lblDebe.Size = New System.Drawing.Size(77, 23)
        Me.lblDebe.TabIndex = 2
        Me.lblDebe.Text = "9999.99"
        Me.lblDebe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCredito
        '
        Me.lblCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCredito.Location = New System.Drawing.Point(315, 2)
        Me.lblCredito.Name = "lblCredito"
        Me.lblCredito.Padding = New System.Windows.Forms.Padding(2)
        Me.lblCredito.Size = New System.Drawing.Size(74, 23)
        Me.lblCredito.TabIndex = 3
        Me.lblCredito.Text = "9999.99"
        Me.lblCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'JanusSuperTip1
        '
        Me.JanusSuperTip1.AutoPopDelay = 2000
        Me.JanusSuperTip1.ImageList = Nothing
        '
        'ctrlStatusPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCredito)
        Me.Controls.Add(Me.lblDebe)
        Me.Controls.Add(Me.btn_FacturasTPV)
        Me.Controls.Add(Me.btn_Facturas)
        Me.Controls.Add(Me.btn_Citas)
        Me.Controls.Add(Me.btn_Tickets)
        Me.Controls.Add(Me.btn_Recibos)
        Me.Name = "ctrlStatusPaciente"
        Me.Size = New System.Drawing.Size(393, 28)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Recibos As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn_Citas As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn_Facturas As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn_Tickets As Janus.Windows.EditControls.UIButton
    Friend WithEvents btn_FacturasTPV As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDebe As System.Windows.Forms.Label
    Friend WithEvents lblCredito As System.Windows.Forms.Label
    Friend WithEvents JanusSuperTip1 As Janus.Windows.Common.JanusSuperTip

End Class
