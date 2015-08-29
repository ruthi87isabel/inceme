<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_modelo_rev_comparativoas
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
        Me.bt_annadirdato = New System.Windows.Forms.Button()
        Me.bt_editardato = New System.Windows.Forms.Button()
        Me.bt_eliminardato = New System.Windows.Forms.Button()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.dtg_modelodatos = New System.Windows.Forms.DataGridView()
        Me.lb_codigo = New System.Windows.Forms.Label()
        Me.lb_descripcion = New System.Windows.Forms.Label()
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.MODELOSCOMPARATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MODELOSCOMPARATIVATableAdapter = New centro_medico.CMDataSetTableAdapters.MODELOSCOMPARATIVATableAdapter()
        Me.MODELOSDATOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MODELOSDATOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MODELOSDATOSTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSeleccionarImage = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.tb_descripcion = New centro_medico.ctrlTextboxAvanzado()
        Me.tb_codigo = New centro_medico.ctrlTextboxAvanzado()
        Me.btQuitarImagen = New System.Windows.Forms.Button()
        CType(Me.dtg_modelodatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODELOSCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODELOSDATOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_annadirdato
        '
        Me.bt_annadirdato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_annadirdato.Image = Global.centro_medico.My.Resources.Resources.MISC18
        Me.bt_annadirdato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_annadirdato.Location = New System.Drawing.Point(10, 448)
        Me.bt_annadirdato.Name = "bt_annadirdato"
        Me.bt_annadirdato.Size = New System.Drawing.Size(97, 27)
        Me.bt_annadirdato.TabIndex = 3
        Me.bt_annadirdato.Text = "Añadir datos"
        Me.bt_annadirdato.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_annadirdato.UseVisualStyleBackColor = True
        '
        'bt_editardato
        '
        Me.bt_editardato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_editardato.Image = Global.centro_medico.My.Resources.Resources.up
        Me.bt_editardato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_editardato.Location = New System.Drawing.Point(113, 448)
        Me.bt_editardato.Name = "bt_editardato"
        Me.bt_editardato.Size = New System.Drawing.Size(97, 27)
        Me.bt_editardato.TabIndex = 4
        Me.bt_editardato.Text = "Editar datos   "
        Me.bt_editardato.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_editardato.UseVisualStyleBackColor = True
        '
        'bt_eliminardato
        '
        Me.bt_eliminardato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_eliminardato.Image = Global.centro_medico.My.Resources.Resources.MISC19
        Me.bt_eliminardato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_eliminardato.Location = New System.Drawing.Point(216, 448)
        Me.bt_eliminardato.Name = "bt_eliminardato"
        Me.bt_eliminardato.Size = New System.Drawing.Size(97, 27)
        Me.bt_eliminardato.TabIndex = 5
        Me.bt_eliminardato.Text = "Eliminar datos"
        Me.bt_eliminardato.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_eliminardato.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(587, 448)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(97, 27)
        Me.bt_aceptar.TabIndex = 6
        Me.bt_aceptar.Text = "Aceptar      "
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancelar.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancelar.Location = New System.Drawing.Point(690, 448)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(97, 27)
        Me.bt_cancelar.TabIndex = 7
        Me.bt_cancelar.Text = "Cancelar     "
        Me.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'dtg_modelodatos
        '
        Me.dtg_modelodatos.AllowUserToAddRows = False
        Me.dtg_modelodatos.AllowUserToDeleteRows = False
        Me.dtg_modelodatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_modelodatos.BackgroundColor = System.Drawing.Color.White
        Me.dtg_modelodatos.Location = New System.Drawing.Point(6, 61)
        Me.dtg_modelodatos.Name = "dtg_modelodatos"
        Me.dtg_modelodatos.ReadOnly = True
        Me.dtg_modelodatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_modelodatos.Size = New System.Drawing.Size(416, 381)
        Me.dtg_modelodatos.TabIndex = 2
        '
        'lb_codigo
        '
        Me.lb_codigo.AutoSize = True
        Me.lb_codigo.Location = New System.Drawing.Point(7, 17)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(40, 13)
        Me.lb_codigo.TabIndex = 10
        Me.lb_codigo.Text = "Código"
        '
        'lb_descripcion
        '
        Me.lb_descripcion.AutoSize = True
        Me.lb_descripcion.Location = New System.Drawing.Point(139, 14)
        Me.lb_descripcion.Name = "lb_descripcion"
        Me.lb_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lb_descripcion.TabIndex = 11
        Me.lb_descripcion.Text = "Descripción"
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MODELOSCOMPARATIVABindingSource
        '
        Me.MODELOSCOMPARATIVABindingSource.DataMember = "MODELOSCOMPARATIVA"
        Me.MODELOSCOMPARATIVABindingSource.DataSource = Me.CMDataSet
        '
        'MODELOSCOMPARATIVATableAdapter
        '
        Me.MODELOSCOMPARATIVATableAdapter.ClearBeforeFill = True
        '
        'MODELOSDATOSBindingSource
        '
        Me.MODELOSDATOSBindingSource.DataMember = "MODELOSDATOS"
        Me.MODELOSDATOSBindingSource.DataSource = Me.CMDataSet
        '
        'MODELOSDATOSTableAdapter
        '
        Me.MODELOSDATOSTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(460, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 351)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(461, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Imagen de plantilla"
        '
        'btnSeleccionarImage
        '
        Me.btnSeleccionarImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarImage.Location = New System.Drawing.Point(712, 32)
        Me.btnSeleccionarImage.Name = "btnSeleccionarImage"
        Me.btnSeleccionarImage.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionarImage.TabIndex = 14
        Me.btnSeleccionarImage.Text = "Seleccionar"
        Me.btnSeleccionarImage.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUp.Enabled = False
        Me.btnUp.Image = Global.centro_medico.My.Resources.Resources._24_em_up
        Me.btnUp.Location = New System.Drawing.Point(426, 61)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(28, 35)
        Me.btnUp.TabIndex = 15
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDown.Enabled = False
        Me.btnDown.Image = Global.centro_medico.My.Resources.Resources._24_em_down
        Me.btnDown.Location = New System.Drawing.Point(426, 102)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(28, 35)
        Me.btnDown.TabIndex = 15
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'tb_descripcion
        '
        Me.tb_descripcion.AcceptsReturn = True
        Me.tb_descripcion.Location = New System.Drawing.Point(142, 33)
        Me.tb_descripcion.MaxLength = 120
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(312, 20)
        Me.tb_descripcion.TabIndex = 1
        '
        'tb_codigo
        '
        Me.tb_codigo.AcceptsReturn = True
        Me.tb_codigo.Location = New System.Drawing.Point(7, 33)
        Me.tb_codigo.MaxLength = 12
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(100, 20)
        Me.tb_codigo.TabIndex = 0
        '
        'btQuitarImagen
        '
        Me.btQuitarImagen.Location = New System.Drawing.Point(631, 33)
        Me.btQuitarImagen.Name = "btQuitarImagen"
        Me.btQuitarImagen.Size = New System.Drawing.Size(75, 23)
        Me.btQuitarImagen.TabIndex = 16
        Me.btQuitarImagen.Text = "Eliminar"
        Me.btQuitarImagen.UseVisualStyleBackColor = True
        '
        'form_modelo_rev_comparativoas
        '
        Me.AcceptButton = Me.bt_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancelar
        Me.ClientSize = New System.Drawing.Size(795, 481)
        Me.Controls.Add(Me.btQuitarImagen)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnSeleccionarImage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.lb_descripcion)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.lb_codigo)
        Me.Controls.Add(Me.tb_descripcion)
        Me.Controls.Add(Me.dtg_modelodatos)
        Me.Controls.Add(Me.tb_codigo)
        Me.Controls.Add(Me.bt_eliminardato)
        Me.Controls.Add(Me.bt_editardato)
        Me.Controls.Add(Me.bt_annadirdato)
        Me.Name = "form_modelo_rev_comparativoas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_modelo_rev_comparativoas"
        CType(Me.dtg_modelodatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODELOSCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODELOSDATOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents MODELOSCOMPARATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MODELOSCOMPARATIVATableAdapter As centro_medico.CMDataSetTableAdapters.MODELOSCOMPARATIVATableAdapter
    Friend WithEvents bt_annadirdato As System.Windows.Forms.Button
    Friend WithEvents bt_editardato As System.Windows.Forms.Button
    Friend WithEvents bt_eliminardato As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents tb_codigo As ctrlTextboxAvanzado
    Friend WithEvents dtg_modelodatos As System.Windows.Forms.DataGridView
    Friend WithEvents tb_descripcion As ctrlTextboxAvanzado
    Friend WithEvents lb_codigo As System.Windows.Forms.Label
    Friend WithEvents lb_descripcion As System.Windows.Forms.Label
    Friend WithEvents MODELOSDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MODELOSDATOSTableAdapter As centro_medico.CMDataSetTableAdapters.MODELOSDATOSTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionarImage As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btQuitarImagen As System.Windows.Forms.Button
End Class
