<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_grafica_rev_comp
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_grafica_rev_comp))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TChart1 = New Steema.TeeChart.TChart()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lb_fechafinal = New System.Windows.Forms.Label()
        Me.lb_fechainicial = New System.Windows.Forms.Label()
        Me.dtp_fechafinal = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fechainicial = New System.Windows.Forms.DateTimePicker()
        Me.pn_bts = New System.Windows.Forms.Panel()
        Me.bt_ConfiguraGráfica = New System.Windows.Forms.Button()
        Me.bt_cerrar = New System.Windows.Forms.Button()
        Me.bt_Imprimir = New System.Windows.Forms.Button()
        Me.cd_elegirColor = New System.Windows.Forms.ColorDialog()
        Me.sfd_salvagrafica = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pn_bts.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.pn_bts)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 428)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TChart1)
        Me.Panel2.Location = New System.Drawing.Point(3, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(775, 305)
        Me.Panel2.TabIndex = 3
        '
        'TChart1
        '
        Me.TChart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TChart1.Aspect.ApplyZOrder = False
        Me.TChart1.Aspect.ElevationFloat = 345.0R
        Me.TChart1.Aspect.RotationFloat = 345.0R
        Me.TChart1.Aspect.View3D = False
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Bottom.Automatic = True
        '
        '
        '
        Me.TChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TChart1.Axes.Bottom.Grid.ZPosition = 0.0R
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Bottom.Labels.Font.Shadow.Visible = False
        Me.TChart1.Axes.Bottom.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.Bottom.Labels.Shadow.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Bottom.Title.Font.Shadow.Visible = False
        Me.TChart1.Axes.Bottom.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.Bottom.Title.Shadow.Visible = False
        '
        '
        '
        Me.TChart1.Axes.Depth.Automatic = True
        '
        '
        '
        Me.TChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TChart1.Axes.Depth.Grid.ZPosition = 0.0R
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Depth.Labels.Font.Shadow.Visible = False
        Me.TChart1.Axes.Depth.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.Depth.Labels.Shadow.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Depth.Title.Font.Shadow.Visible = False
        Me.TChart1.Axes.Depth.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.Depth.Title.Shadow.Visible = False
        '
        '
        '
        Me.TChart1.Axes.DepthTop.Automatic = True
        '
        '
        '
        Me.TChart1.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TChart1.Axes.DepthTop.Grid.ZPosition = 0.0R
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = False
        Me.TChart1.Axes.DepthTop.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.DepthTop.Labels.Shadow.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.DepthTop.Title.Font.Shadow.Visible = False
        Me.TChart1.Axes.DepthTop.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.DepthTop.Title.Shadow.Visible = False
        '
        '
        '
        Me.TChart1.Axes.Left.Automatic = True
        '
        '
        '
        Me.TChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TChart1.Axes.Left.Grid.ZPosition = 0.0R
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Left.Labels.Font.Shadow.Visible = False
        Me.TChart1.Axes.Left.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.Left.Labels.Shadow.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Left.Title.Font.Shadow.Visible = False
        Me.TChart1.Axes.Left.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.Left.Title.Shadow.Visible = False
        '
        '
        '
        Me.TChart1.Axes.Right.Automatic = True
        '
        '
        '
        Me.TChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TChart1.Axes.Right.Grid.ZPosition = 0.0R
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Right.Labels.Font.Shadow.Visible = False
        Me.TChart1.Axes.Right.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.Right.Labels.Shadow.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Right.Title.Font.Shadow.Visible = False
        Me.TChart1.Axes.Right.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.Right.Title.Shadow.Visible = False
        '
        '
        '
        Me.TChart1.Axes.Top.Automatic = True
        '
        '
        '
        Me.TChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TChart1.Axes.Top.Grid.ZPosition = 0.0R
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Top.Labels.Font.Shadow.Visible = False
        Me.TChart1.Axes.Top.Labels.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.Top.Labels.Shadow.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Top.Title.Font.Shadow.Visible = False
        Me.TChart1.Axes.Top.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Axes.Top.Title.Shadow.Visible = False
        Me.TChart1.BackColor = System.Drawing.Color.GhostWhite
        Me.TChart1.Cursor = System.Windows.Forms.Cursors.Default
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Footer.Font.Shadow.Visible = False
        Me.TChart1.Footer.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Footer.Shadow.Visible = False
        '
        '
        '
        Me.TChart1.Header.Alignment = System.Drawing.StringAlignment.Near
        '
        '
        '
        '
        '
        '
        Me.TChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        '
        '
        Me.TChart1.Header.Font.Shadow.Visible = False
        Me.TChart1.Header.Font.Unit = System.Drawing.GraphicsUnit.World
        Me.TChart1.Header.Lines = New String() {"Gráfica"}
        '
        '
        '
        Me.TChart1.Header.Shadow.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Legend.Font.Shadow.Visible = False
        Me.TChart1.Legend.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        '
        '
        '
        Me.TChart1.Legend.Title.Font.Bold = True
        '
        '
        '
        Me.TChart1.Legend.Title.Font.Shadow.Visible = False
        Me.TChart1.Legend.Title.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.Legend.Title.Pen.Visible = False
        '
        '
        '
        Me.TChart1.Legend.Title.Shadow.Visible = False
        Me.TChart1.Location = New System.Drawing.Point(0, 0)
        Me.TChart1.Name = "TChart1"
        '
        '
        '
        '
        '
        '
        Me.TChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None
        '
        '
        '
        Me.TChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(240, Byte), Integer))
        '
        '
        '
        Me.TChart1.Panel.Gradient.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TChart1.Panel.Gradient.Sigma = True
        Me.TChart1.Panel.Gradient.SigmaFocus = 0.0!
        Me.TChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TChart1.Panel.Gradient.UseMiddle = True
        Me.TChart1.Panel.Gradient.Visible = True
        '
        '
        '
        Me.TChart1.Panel.Pen.Width = 0
        '
        '
        '
        Me.TChart1.Panel.Shadow.Visible = False
        Me.TChart1.Size = New System.Drawing.Size(775, 302)
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.SubFooter.Font.Shadow.Visible = False
        Me.TChart1.SubFooter.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.SubFooter.Shadow.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.SubHeader.Font.Shadow.Visible = False
        Me.TChart1.SubHeader.Font.Unit = System.Drawing.GraphicsUnit.World
        '
        '
        '
        Me.TChart1.SubHeader.Shadow.Visible = False
        Me.TChart1.TabIndex = 0
        '
        '
        '
        '
        '
        '
        Me.TChart1.Walls.Back.AutoHide = False
        '
        '
        '
        Me.TChart1.Walls.Back.Shadow.Visible = False
        '
        '
        '
        Me.TChart1.Walls.Bottom.AutoHide = False
        '
        '
        '
        Me.TChart1.Walls.Bottom.Shadow.Visible = False
        '
        '
        '
        Me.TChart1.Walls.Left.AutoHide = False
        '
        '
        '
        Me.TChart1.Walls.Left.Shadow.Visible = False
        '
        '
        '
        Me.TChart1.Walls.Right.AutoHide = False
        '
        '
        '
        Me.TChart1.Walls.Right.Shadow.Visible = False
        Me.TChart1.Walls.View3D = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(790, 87)
        Me.Panel4.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.bt_filtrar)
        Me.GroupBox1.Controls.Add(Me.lb_fechafinal)
        Me.GroupBox1.Controls.Add(Me.lb_fechainicial)
        Me.GroupBox1.Controls.Add(Me.dtp_fechafinal)
        Me.GroupBox1.Controls.Add(Me.dtp_fechainicial)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fitrar"
        '
        'bt_filtrar
        '
        Me.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_filtrar.ImageIndex = 0
        Me.bt_filtrar.ImageList = Me.ImageList1
        Me.bt_filtrar.Location = New System.Drawing.Point(462, 19)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(75, 27)
        Me.bt_filtrar.TabIndex = 2
        Me.bt_filtrar.Text = "Filtrar  "
        Me.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search4doc.ico")
        '
        'lb_fechafinal
        '
        Me.lb_fechafinal.AutoSize = True
        Me.lb_fechafinal.Location = New System.Drawing.Point(238, 26)
        Me.lb_fechafinal.Name = "lb_fechafinal"
        Me.lb_fechafinal.Size = New System.Drawing.Size(62, 13)
        Me.lb_fechafinal.TabIndex = 3
        Me.lb_fechafinal.Text = "Fecha Final"
        '
        'lb_fechainicial
        '
        Me.lb_fechainicial.AutoSize = True
        Me.lb_fechainicial.Location = New System.Drawing.Point(32, 26)
        Me.lb_fechainicial.Name = "lb_fechainicial"
        Me.lb_fechainicial.Size = New System.Drawing.Size(67, 13)
        Me.lb_fechainicial.TabIndex = 2
        Me.lb_fechainicial.Text = "Fecha Inicial"
        '
        'dtp_fechafinal
        '
        Me.dtp_fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechafinal.Location = New System.Drawing.Point(306, 23)
        Me.dtp_fechafinal.Name = "dtp_fechafinal"
        Me.dtp_fechafinal.Size = New System.Drawing.Size(137, 20)
        Me.dtp_fechafinal.TabIndex = 1
        '
        'dtp_fechainicial
        '
        Me.dtp_fechainicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechainicial.Location = New System.Drawing.Point(105, 23)
        Me.dtp_fechainicial.Name = "dtp_fechainicial"
        Me.dtp_fechainicial.Size = New System.Drawing.Size(115, 20)
        Me.dtp_fechainicial.TabIndex = 0
        '
        'pn_bts
        '
        Me.pn_bts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pn_bts.BackColor = System.Drawing.Color.GhostWhite
        Me.pn_bts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pn_bts.Controls.Add(Me.bt_ConfiguraGráfica)
        Me.pn_bts.Controls.Add(Me.bt_cerrar)
        Me.pn_bts.Controls.Add(Me.bt_Imprimir)
        Me.pn_bts.Location = New System.Drawing.Point(0, 375)
        Me.pn_bts.Name = "pn_bts"
        Me.pn_bts.Size = New System.Drawing.Size(790, 53)
        Me.pn_bts.TabIndex = 1
        '
        'bt_ConfiguraGráfica
        '
        Me.bt_ConfiguraGráfica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_ConfiguraGráfica.Image = Global.centro_medico.My.Resources.Resources.Pie_Chart
        Me.bt_ConfiguraGráfica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_ConfiguraGráfica.Location = New System.Drawing.Point(2, -1)
        Me.bt_ConfiguraGráfica.Name = "bt_ConfiguraGráfica"
        Me.bt_ConfiguraGráfica.Size = New System.Drawing.Size(146, 49)
        Me.bt_ConfiguraGráfica.TabIndex = 2
        Me.bt_ConfiguraGráfica.Text = "Configura Gráfica"
        Me.bt_ConfiguraGráfica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_ConfiguraGráfica.UseVisualStyleBackColor = True
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cerrar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cerrar.Location = New System.Drawing.Point(702, -1)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 49)
        Me.bt_cerrar.TabIndex = 1
        Me.bt_cerrar.Text = "Cancelar"
        Me.bt_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'bt_Imprimir
        '
        Me.bt_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_Imprimir.Image = Global.centro_medico.My.Resources.Resources.Print1
        Me.bt_Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Imprimir.Location = New System.Drawing.Point(154, -1)
        Me.bt_Imprimir.Name = "bt_Imprimir"
        Me.bt_Imprimir.Size = New System.Drawing.Size(78, 49)
        Me.bt_Imprimir.TabIndex = 1
        Me.bt_Imprimir.Text = "Imprimir"
        Me.bt_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Imprimir.UseVisualStyleBackColor = True
        Me.bt_Imprimir.Visible = False
        '
        'form_grafica_rev_comp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(790, 430)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "form_grafica_rev_comp"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gráfica de Revisión Comparativa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pn_bts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pn_bts As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_filtrar As System.Windows.Forms.Button
    Friend WithEvents lb_fechafinal As System.Windows.Forms.Label
    Friend WithEvents lb_fechainicial As System.Windows.Forms.Label
    Friend WithEvents dtp_fechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechainicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents zgc_grafico As ZedGraph.ZedGraphControl
    Friend WithEvents bt_Imprimir As System.Windows.Forms.Button
    Friend WithEvents cd_elegirColor As System.Windows.Forms.ColorDialog
    Friend WithEvents bt_cerrar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents sfd_salvagrafica As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TChart1 As Steema.TeeChart.TChart
    Friend WithEvents bt_ConfiguraGráfica As System.Windows.Forms.Button
End Class
