<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorario_Disponibilidad
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHorario_Disponibilidad))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.lblDiasNoLaborablesQueSIICuentan = New System.Windows.Forms.Label()
        Me.lblDiasNoLaborablesQueNoCuentan = New System.Windows.Forms.Label()
        Me.lblFiestas = New System.Windows.Forms.Label()
        Me.lblNoLaborables = New System.Windows.Forms.Label()
        Me.HorarioEntryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioEntryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "re aqui para agrupar</GroupByBoxInfo></LocalizableData>"
        Me.GridEX1.ColumnAutoResize = True
        Me.GridEX1.DataSource = Me.HorarioEntryBindingSource
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Location = New System.Drawing.Point(4, 46)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(778, 489)
        Me.GridEX1.TabIndex = 0
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(56, 12)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.dtpDesde.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Location = New System.Drawing.Point(707, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 28)
        Me.btnPrint.TabIndex = 37
        Me.btnPrint.Text = "Imprimir"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(319, 12)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.dtpHasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Location = New System.Drawing.Point(550, 12)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 28)
        Me.btnFiltrar.TabIndex = 37
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'lblDiasNoLaborablesQueSIICuentan
        '
        Me.lblDiasNoLaborablesQueSIICuentan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDiasNoLaborablesQueSIICuentan.BackColor = System.Drawing.Color.Red
        Me.lblDiasNoLaborablesQueSIICuentan.ForeColor = System.Drawing.Color.White
        Me.lblDiasNoLaborablesQueSIICuentan.Location = New System.Drawing.Point(344, 538)
        Me.lblDiasNoLaborablesQueSIICuentan.Name = "lblDiasNoLaborablesQueSIICuentan"
        Me.lblDiasNoLaborablesQueSIICuentan.Size = New System.Drawing.Size(160, 34)
        Me.lblDiasNoLaborablesQueSIICuentan.TabIndex = 40
        Me.lblDiasNoLaborablesQueSIICuentan.Text = "Días no laborables generales que cuentan en vacaciones"
        Me.lblDiasNoLaborablesQueSIICuentan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiasNoLaborablesQueNoCuentan
        '
        Me.lblDiasNoLaborablesQueNoCuentan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDiasNoLaborablesQueNoCuentan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDiasNoLaborablesQueNoCuentan.ForeColor = System.Drawing.Color.White
        Me.lblDiasNoLaborablesQueNoCuentan.Location = New System.Drawing.Point(178, 539)
        Me.lblDiasNoLaborablesQueNoCuentan.Name = "lblDiasNoLaborablesQueNoCuentan"
        Me.lblDiasNoLaborablesQueNoCuentan.Size = New System.Drawing.Size(160, 34)
        Me.lblDiasNoLaborablesQueNoCuentan.TabIndex = 41
        Me.lblDiasNoLaborablesQueNoCuentan.Text = "Días no laborables generales que no cuentan en vacaciones"
        Me.lblDiasNoLaborablesQueNoCuentan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFiestas
        '
        Me.lblFiestas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFiestas.BackColor = System.Drawing.Color.Navy
        Me.lblFiestas.ForeColor = System.Drawing.Color.White
        Me.lblFiestas.Location = New System.Drawing.Point(510, 538)
        Me.lblFiestas.Name = "lblFiestas"
        Me.lblFiestas.Size = New System.Drawing.Size(160, 34)
        Me.lblFiestas.TabIndex = 38
        Me.lblFiestas.Text = "Fiestas"
        Me.lblFiestas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoLaborables
        '
        Me.lblNoLaborables.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNoLaborables.BackColor = System.Drawing.Color.Green
        Me.lblNoLaborables.ForeColor = System.Drawing.Color.White
        Me.lblNoLaborables.Location = New System.Drawing.Point(12, 539)
        Me.lblNoLaborables.Name = "lblNoLaborables"
        Me.lblNoLaborables.Size = New System.Drawing.Size(160, 34)
        Me.lblNoLaborables.TabIndex = 39
        Me.lblNoLaborables.Text = "No Laborables"
        Me.lblNoLaborables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HorarioEntryBindingSource
        '
        Me.HorarioEntryBindingSource.DataSource = GetType(centro_medico.HorarioEntry)
        '
        'frmHorario_Disponibilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 582)
        Me.Controls.Add(Me.lblDiasNoLaborablesQueSIICuentan)
        Me.Controls.Add(Me.lblDiasNoLaborablesQueNoCuentan)
        Me.Controls.Add(Me.lblFiestas)
        Me.Controls.Add(Me.lblNoLaborables)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "frmHorario_Disponibilidad"
        Me.Text = "Disponibilidad Por Fecha"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioEntryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents HorarioEntryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents lblDiasNoLaborablesQueSIICuentan As System.Windows.Forms.Label
    Friend WithEvents lblDiasNoLaborablesQueNoCuentan As System.Windows.Forms.Label
    Friend WithEvents lblFiestas As System.Windows.Forms.Label
    Friend WithEvents lblNoLaborables As System.Windows.Forms.Label
End Class
