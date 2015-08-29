<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_ficheros
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
        Dim FECHALabel As System.Windows.Forms.Label
        Dim FICHEROLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Me.dtp_fechafichero = New System.Windows.Forms.DateTimePicker
        Me.FICHEROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet
        Me.tb_nombrefichero = New ctrlTextboxAvanzado
        Me.tb_descripcionfichero = New ctrlTextboxAvanzado
        Me.bt_fichero = New System.Windows.Forms.Button
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FICHEROSTableAdapter = New centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
        FECHALabel = New System.Windows.Forms.Label
        FICHEROLabel = New System.Windows.Forms.Label
        DESCRIPCIONLabel = New System.Windows.Forms.Label
        CType(Me.FICHEROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(298, 10)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(40, 13)
        FECHALabel.TabIndex = 1
        FECHALabel.Text = "Fecha:"
        '
        'FICHEROLabel
        '
        FICHEROLabel.AutoSize = True
        FICHEROLabel.Location = New System.Drawing.Point(12, 50)
        FICHEROLabel.Name = "FICHEROLabel"
        FICHEROLabel.Size = New System.Drawing.Size(45, 13)
        FICHEROLabel.TabIndex = 2
        FICHEROLabel.Text = "Fichero:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(12, 9)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(66, 13)
        DESCRIPCIONLabel.TabIndex = 4
        DESCRIPCIONLabel.Text = "Descripcion:"
        '
        'dtp_fechafichero
        '
        Me.dtp_fechafichero.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FICHEROSBindingSource, "FECHA", True))
        Me.dtp_fechafichero.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechafichero.Location = New System.Drawing.Point(301, 26)
        Me.dtp_fechafichero.Name = "dtp_fechafichero"
        Me.dtp_fechafichero.Size = New System.Drawing.Size(147, 20)
        Me.dtp_fechafichero.TabIndex = 1
        '
        'FICHEROSBindingSource
        '
        Me.FICHEROSBindingSource.DataMember = "FICHEROS"
        Me.FICHEROSBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_nombrefichero
        '
        Me.tb_nombrefichero.BackColor = System.Drawing.Color.White
        Me.tb_nombrefichero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FICHEROSBindingSource, "FICHERO", True))
        Me.tb_nombrefichero.Location = New System.Drawing.Point(15, 66)
        Me.tb_nombrefichero.MaxLength = 255
        Me.tb_nombrefichero.Name = "tb_nombrefichero"
        Me.tb_nombrefichero.ReadOnly = True
        Me.tb_nombrefichero.Size = New System.Drawing.Size(405, 20)
        Me.tb_nombrefichero.TabIndex = 2
        '
        'tb_descripcionfichero
        '
        Me.tb_descripcionfichero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FICHEROSBindingSource, "DESCRIPCION", True))
        Me.tb_descripcionfichero.Location = New System.Drawing.Point(15, 27)
        Me.tb_descripcionfichero.MaxLength = 90
        Me.tb_descripcionfichero.Name = "tb_descripcionfichero"
        Me.tb_descripcionfichero.Size = New System.Drawing.Size(260, 20)
        Me.tb_descripcionfichero.TabIndex = 0
        '
        'bt_fichero
        '
        Me.bt_fichero.BackgroundImage = Global.centro_medico.My.Resources.Resources.search4doc
        Me.bt_fichero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_fichero.Location = New System.Drawing.Point(419, 63)
        Me.bt_fichero.Name = "bt_fichero"
        Me.bt_fichero.Size = New System.Drawing.Size(29, 23)
        Me.bt_fichero.TabIndex = 3
        Me.bt_fichero.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancel.Image = Global.centro_medico.My.Resources.Resources.MISC20
        Me.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cancel.Location = New System.Drawing.Point(373, 97)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(75, 28)
        Me.bt_cancel.TabIndex = 5
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_aceptar
        '
        Me.bt_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(285, 97)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 28)
        Me.bt_aceptar.TabIndex = 4
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FICHEROSTableAdapter
        '
        Me.FICHEROSTableAdapter.ClearBeforeFill = True
        '
        'form_ficheros
        '
        Me.AcceptButton = Me.bt_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancel
        Me.ClientSize = New System.Drawing.Size(455, 130)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.bt_fichero)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.tb_descripcionfichero)
        Me.Controls.Add(FICHEROLabel)
        Me.Controls.Add(Me.tb_nombrefichero)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.dtp_fechafichero)
        Me.Name = "form_ficheros"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_ficheros"
        CType(Me.FICHEROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents FICHEROSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FICHEROSTableAdapter As centro_medico.CMDataSetTableAdapters.FICHEROSTableAdapter
    Friend WithEvents dtp_fechafichero As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_nombrefichero As ctrlTextboxAvanzado
    Friend WithEvents tb_descripcionfichero As ctrlTextboxAvanzado
    Friend WithEvents bt_fichero As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
