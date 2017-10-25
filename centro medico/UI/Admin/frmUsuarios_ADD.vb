Public Class frmUsuarios_ADD

    Public CODIGO As Integer = -1
    Public Usuario As CMDataSet.USUARIOSRow
    Dim Pass As String = ""


    Dim rolesUsuariosAdapter As CMDataSetTableAdapters.ROLESUSUARIOSTableAdapter = New CMDataSetTableAdapters.ROLESUSUARIOSTableAdapter()
    Dim rolesUsuariosTable As CMDataSet.ROLESUSUARIOSDataTable = New CMDataSet.ROLESUSUARIOSDataTable()



    Private Sub frmUsuarios_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.ROLES' table. You can move, or remove it, as needed.
        Me.ROLESTableAdapter.Fill(Me.CMDataSet.ROLES)
        Me.MEDICOSTableAdapter.Fill(Me.CMDataSet.MEDICOS)

        If CODIGO <> -1 Then
            Me.USUARIOSTableAdapter.FillByCODIGO(Me.CMDataSet.USUARIOS, CODIGO)
            Usuario = Me.CMDataSet.USUARIOS(0)
            RepetirContrasenna.Text = Usuario.CONTRASENA

            'Buscar Role al que pertenece
            rolesUsuariosAdapter.FillBy(rolesUsuariosTable, CODIGO)
            ROLESComboBox.SelectedValue = rolesUsuariosTable(0).ID_ROLES
            If Usuario.IsREFMEDICONull Then
                Me.chkEsmedico.Checked = False
            Else
                Me.chkEsmedico.Checked = True
            End If
           
        Else
            Usuario = Me.USUARIOSBindingSource.AddNew().Row()
            Usuario.CODIGO = Globales.ObtenerMaximoValor("USUARIOS", "CODIGO") + 1
            ROLESComboBox.SelectedIndex = 0

            Dim row As CMDataSet.ROLESUSUARIOSRow = rolesUsuariosTable.NewROLESUSUARIOSRow()
            row.ID_ROLES = ROLESComboBox.SelectedValue
            row.ID_USUARIO = Usuario.CODIGO
            rolesUsuariosTable.AddROLESUSUARIOSRow(row)

        End If

        Pass = CONTRASENATextBox.Text
    End Sub


    Private Sub chkEsmedico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEsmedico.CheckedChanged
        grpMedicos.Enabled = chkEsmedico.Checked
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim IdMedico As Integer = Usuario.REFMEDICO

        If CONTRASENATextBox.Text <> RepetirContrasenna.Text Then
            MessageBox.Show("Las contrasennas deben coincidir")
            CONTRASENATextBox.Text = ""
            RepetirContrasenna.Text = ""
            CONTRASENATextBox.Focus()
            Return
        End If

        If chkEsmedico.Checked = False Then
            Usuario.SetREFMEDICONull()
        End If

        'Estos parametros estan aqui para no efectuar cambios en la BD pero NO se USAN y pueden ser eliminados
        Usuario.NIVEL = ""
        Usuario.ADMINISTRADOR = ""

        Usuario.FECHACLAVE = DateTime.Now

        Me.Validate()
        Me.USUARIOSBindingSource.EndEdit()
        Me.USUARIOSTableAdapter.Update(Me.CMDataSet.USUARIOS)

        If chkEsmedico.Checked And Pass <> CONTRASENATextBox.Text Then
            Dim context As New CMLinqDataContext()
            Dim Cita As CITA = (From c In context.CITAs Select c Where c.REFMEDICO = Usuario.REFMEDICO).FirstOrDefault
            If Not Cita Is Nothing Then Cita.UpdateFileNewPassFtp(Cita.REFMEDICO, Cita.MEDICO.NOMBRECOMPLETO)
        End If

        'Salvar Rol
        Me.rolesUsuariosTable(0).ID_ROLES = ROLESComboBox.SelectedValue
        'Me.rolesUsuariosTable.AcceptChanges()
        Dim n As Integer = Me.rolesUsuariosAdapter.Update(rolesUsuariosTable)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Configuracion_Usuarios, "Usuarios", Usuario.CODIGO.ToString(), "")

        Me.Close()
    End Sub

    Private Sub bt_Certificado_Click(sender As Object, e As EventArgs) Handles bt_Certificado.Click
        Dim df As New OpenFileDialog

        If Not Usuario.IsCERTIFICADOPATHNull AndAlso System.IO.Directory.Exists(Usuario.CERTIFICADOPATH) Then
            df.InitialDirectory = Usuario.CERTIFICADOPATH
        End If

        Dim dr As DialogResult = df.ShowDialog()
        If dr = Windows.Forms.DialogResult.OK Then
            Usuario.CERTIFICADOPATH = df.FileName
        End If

    End Sub
    Private Sub bloqueaControlesParaUsuario()
        CONTRASENATextBox.Enabled = False
        RepetirContrasenna.Enabled = False
        ROLESComboBox.Enabled = False
        chkEsmedico.Enabled = False
        grpMedicos.Enabled = False
    End Sub
    'Se usa el parametro loadByUser para detectar si lo llama directamente el usuario y de esa forma limitar la edición de algunos campos.
    Public Sub New(Optional loadByUser As Boolean = False)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If loadByUser = True Then bloqueaControlesParaUsuario()
    End Sub
End Class