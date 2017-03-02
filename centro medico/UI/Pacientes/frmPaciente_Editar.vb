Imports CSharpTools
Imports Janus.Windows.GridEX

Public Class frmPaciente_Editar
    Public Const DIST_LEVENSHTEIN As Integer = 2
    Public Const JARO_WINKLER_DISTANCE As Double = 0.85
    Public IDPACIENTE As Integer
    Dim fImagen() As Byte = Nothing
    Dim PacDataDupl As Integer = 0
    Dim context As New CMLinqDataContext()
    'PacDataDupl = 1->DNI
    'PacDataDupl = 2->Pasaporte
    'PacDataDupl = 3->NIE
    'PacDataDupl = 4->Nombre

    ' Public MutuaPrincipal As Nullable(Of Integer)
    ' Public EmpresaPrincipal As Nullable(Of Integer)

    Dim pac As PACIENTE

    Sub New(IDPACIENTE As Integer)

        InitializeComponent()

        Me.IDPACIENTE = IDPACIENTE
    End Sub

    Private Function Validar() As Boolean
        Dim res As Boolean = True
        res = Me.checkCodigoPropio()
        Return res
    End Function

    Function Guardar() As Boolean
        If Not Validar() Then
            Return False
        End If
        'parche necesario para que no de error si el usuario no sale del campo fechanacimiento.
        'por algún motivo da error si intentamos guardar teniendo el foco este control de manera que forzamos a que lo pierda
        Me.lbl_Nombre.Focus()
        'fin parche

        Me.PACIENTESBindingSource.EndEdit()

        pac.FECHAN = Me.dtp_dpFeNac.Value
        If Me.dtp_dpFechaAlta.Checked Then
            pac.FECHAALTA = Me.dtp_dpFechaAlta.Value
        End If
        If Me.dtp_dpFechabaja.Checked Then
            pac.FECHABAJA = Me.dtp_dpFechabaja.Value
        End If
        If Me.cb_dpSexo.SelectedItem = "Mujer" Then
            pac.SEXO = "M"
        Else
            pac.SEXO = "H"
        End If

        If CtrlMutua1.ID_MUTUA.HasValue Then
            pac.REFMUTUA = CtrlMutua1.ID_MUTUA
        Else
            pac.REFMUTUA = Nothing
        End If

        If chb_dpAsociado.Checked Then
            pac.SOCIO = "S"
        Else
            'pac.SOCIO = "N"
            DeleteAsociadoYBeneficiarios(pac)
        End If
        If chb_dpFallecido.Checked Then
            pac.DEFUNCION = "S"
        Else
            pac.DEFUNCION = "N"
        End If

        If chb_dpActivo.Checked Then
            pac.ACTIVO = "S"
        Else
            pac.ACTIVO = "N"
        End If

        ChequeaDatosDuplicados()
        'If ChequeaDatosDuplicados() = True Then
        '    Dim res As MsgBoxResult = MsgBox("Se han encontrado coincidencias con los pacientes mostrados anteriormente, ¿Desea seguir guardando?", MsgBoxStyle.YesNo)
        '    If res = MsgBoxResult.No Then
        '        Exit Function
        '    Else
        '        DescartarPaciente(IDPACIENTE, PacDataDupl)
        '    End If
        'End If

        pac.CONOCIO = Me.cb_comoconocio.SelectedItem
        Me.context.SubmitChanges()
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Pacientes, "nuevo paciente", pac.CPACIENTE.ToString(), "nombre : " & pac.NombreCompleto)
        Return True
    End Function

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CalcularEdad()
        PACIENTESBindingSource.EndEdit()

        tb_dpEdad.Text = PACIENTESBindingSource.Current.Edad
    End Sub

    Private Sub frmPaciente_Editar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FreeMemory.FlushMemory()
    End Sub



    Private Sub frmPaciente_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idPaciente As Integer = Me.IDPACIENTE

        Me.pac = (From p In Me.context.PACIENTEs Where p.CPACIENTE = idPaciente Select p).First()
        Me.PACIENTESBindingSource.DataSource = Me.pac

        pac = Me.pac

        If Not pac.FECHAN Is Nothing Then
            Me.dtp_dpFeNac.Value = pac.FECHAN
        End If
        If Not pac.FECHAALTA Is Nothing Then
            Me.dtp_dpFechaAlta.Value = pac.FECHAALTA
            Me.dtp_dpFechaAlta.Checked = True
        End If
        If Not pac.FECHABAJA Is Nothing Then
            Me.dtp_dpFechabaja.Value = pac.FECHABAJA
            Me.dtp_dpFechabaja.Checked = True
        End If

        If Not pac.FECHAN Is Nothing Then
            CalcularEdad()
        End If

        cb_dpSexo.Items.Add("Hombre")
        cb_dpSexo.Items.Add("Mujer")
        If pac.SEXO.HasValue Then
            If pac.SEXO = "M" Or pac.SEXO = "m" Then
                cb_dpSexo.SelectedItem = "Mujer"
            Else
                cb_dpSexo.SelectedItem = "Hombre"
            End If
        Else
            cb_dpSexo.SelectedItem = "Hombre"
        End If


        If Not pac.ACTIVO Is Nothing Then
            If pac.ACTIVO = "N" Then
                chb_dpActivo.Checked = False
                dtp_dpFechabaja.Enabled = True
            Else
                chb_dpActivo.Checked = True
                dtp_dpFechabaja.Enabled = False
            End If
        End If

        If Not pac.SOCIO Is Nothing Then
            If pac.SOCIO = "N" Then
                chb_dpAsociado.Checked = False
                dtpsociohasta.Visible = False
            Else
                chb_dpAsociado.Checked = True
                dtpsociohasta.Visible = True
            End If
        End If

        If Not pac.DEFUNCION Is Nothing Then
            If pac.DEFUNCION = "N" Then
                chb_dpFallecido.Checked = False
            Else
                chb_dpFallecido.Checked = True
            End If
        End If

        grpAsociados.Visible = chb_dpAsociado.Checked

        If Not pac.FOTO Is Nothing Then
            fImagen = pac.FOTO.ToArray()
            Using stream As New System.IO.MemoryStream(fImagen)
                Dim _imagen As Bitmap = New Bitmap(stream)
                pb_dpImagen.BackgroundImage = _imagen
                pb_dpImagen.BackgroundImageLayout = ImageLayout.Stretch
            End Using
        End If

        Dim asociado As Asociado = DameAsociacion(Me.IDPACIENTE)
        If Not asociado Is Nothing Then
            pnlBeneficiario.Visible = True
            lblSocioBeneficiario.Text = asociado.PACIENTE1.CPACIENTE
            txtNomSocio.Text = asociado.PACIENTE1.NombreCompleto
            txtParentescoSocio.Text = asociado.Parentesco.Descripcion
            If Not (asociado.PACIENTE1.SOCIOVALIDOHASTA Is Nothing) Then
                lblFechaValidoBeneficiario.Text = Format(asociado.PACIENTE1.SOCIOVALIDOHASTA, "dd/MM/yyyy")

            End If
            chb_dpAsociado.Visible = False
        End If

        If Not pac Is Nothing Then
            If pac.Eliminado.HasValue Then
                lblEliminado.Visible = pac.Eliminado
            Else
                lblEliminado.Visible = False
            End If
        End If

        Me.CtrlEmpresa1.ID_EMPRESAS = pac.REFEMPRESA
        Me.CtrlMutua1.ID_MUTUA = pac.REFMUTUA

        CargarAsociados()
        CargarContactos()
        CargarComoNosConocio(pac)
        CargarEmpresas(pac)
        CargarMutuas(pac)
        AplicaPermisos()
        AplicaPermisosAHistorialesLaborales()
    End Sub

    Private Sub AplicaPermisos()

        gb_dpDatPer.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Datos_Personales) > RoleManager.TipoPermisos.Lectura)
        gb_dpDatosadmin.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Datos_Personales) > RoleManager.TipoPermisos.Lectura)
        gb_dpObservaciones.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Datos_Personales) > RoleManager.TipoPermisos.Lectura)
        'gb_Principales.Enabled = (Globals.Usuario.Permisos(RoleManager.Items.Pacientes_Datos_Personales) > RoleManager.TipoPermisos.Lectura)

        'Me.TabControl1.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) = RoleManager.TipoPermisos.Ninguno)
    End Sub

    Private Sub CargarAsociados()
        GridEXSocios.DataSource = Nothing

        AsociadoBindingSource.DataSource = (From a In context.Asociados Where a.IDPacienteOrigen = Me.IDPACIENTE Select a).ToList()

        GridEXSocios.DataSource = AsociadoBindingSource
    End Sub

    Private Sub CargarContactos()
        GridEXContactos.DataSource = Nothing

        Dim contactos As List(Of ContactosPaciente) = (From c In context.ContactosPacientes Where c.CPaciente = Me.IDPACIENTE Select c).ToList()

        ContactosPacienteBindingSource.DataSource = contactos

        GridEXContactos.DataSource = ContactosPacienteBindingSource

    End Sub

    Private Sub CargarComoNosConocio(pac As PACIENTE)

        Dim como As List(Of ComoConocio) = (From c In context.ComoConocios Select c).ToList()

        For Each c As ComoConocio In como
            cb_comoconocio.Items.Add(c.Descripcion)
        Next
        If Not pac.CONOCIO Is Nothing Then
            cb_comoconocio.SelectedItem = pac.CONOCIO
        End If
    End Sub

    Private Sub btn_ADD_Click(sender As Object, e As EventArgs) Handles btn_ADD.Click
        Dim frm As New frmPaciente_Contactos_Add()
        frm.IDPaciente = Me.IDPACIENTE
        frm.ShowDialog()

        CargarContactos()
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If GridEXContactos.SelectedItems.Count > 0 Then

            Dim contacto As ContactosPaciente = GridEXContactos.SelectedItems(0).GetRow().DataRow
            Dim frm As New frmPaciente_Contactos_Add()
            frm.IDPaciente = Me.IDPACIENTE
            frm.IDContacto = contacto.IdContacto
            frm.ShowDialog()

            CargarContactos()
        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If GridEXContactos.SelectedItems.Count > 0 Then
            Dim cont As ContactosPaciente = GridEXContactos.SelectedItems(0).GetRow().DataRow
            Dim contacto As ContactosPaciente = (From c In context.ContactosPacientes _
                                                Where c.IdContacto = cont.IdContacto _
                                                Select c).First()

            context.ContactosPacientes.DeleteOnSubmit(contacto)
            context.SubmitChanges()
            CargarContactos()
        End If
    End Sub

    Private Sub chb_dpAsociado_CheckedChanged(sender As Object, e As EventArgs) Handles chb_dpAsociado.CheckedChanged
        grpAsociados.Visible = chb_dpAsociado.Checked
        dtpsociohasta.Visible = chb_dpAsociado.Checked
        If chb_dpAsociado.Checked Then
            pac.SOCIOVALIDOHASTA = dtpsociohasta.Value
        Else
            pac.SOCIOVALIDOHASTA = Nothing
        End If
    End Sub

    Private Sub btnAddSocio_Click(sender As Object, e As EventArgs) Handles btnAddSocio.Click
        Dim frm As New frmAsociadoAdd()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim aso As New Asociado()
            aso.IDPacienteOrigen = Me.IDPACIENTE
            aso.IDPacienteBeneficiario = frm.CtrlPaciente1.ID_PACIENTE
            aso.IDParentesco = frm.AsociadoComboBox.SelectedItem.IdParentesco

            If aso.IDPacienteBeneficiario = Me.IDPACIENTE Then
                MessageBox.Show("El socio no puede ser el mismo paciente actual")
                Return
            End If

            'Averiguar si ya no es beneficiario de otra persona
            If Not DameAsociacion(aso.IDPacienteBeneficiario) Is Nothing Then
                MessageBox.Show("El paciente seleccionado ya es beneficiario de otro asociado")
                Return
            End If


            Try
                context.Asociados.InsertOnSubmit(aso)


                'Voy a usar el campo de Paciente BENEFICIARIOCODIGOSOCIO para marcar si es beneficiario
                Dim beneficiario As PACIENTE = (From p In context.PACIENTEs _
                                               Where p.CPACIENTE = aso.IDPacienteBeneficiario _
                                               Select p).First()
                beneficiario.BENEFICIARIOCODIGOSOCIO = aso.IDPacienteOrigen
                context.SubmitChanges()
                CargarAsociados()

            Catch ex As Exception
                MessageBox.Show("El socio seleccionado ya existe")
                Return
            End Try
        End If
    End Sub

    Private Sub btnRemoveSocio_Click(sender As Object, e As EventArgs) Handles btnRemoveSocio.Click
        If GridEXSocios.SelectedItems.Count > 0 Then

            Try
                Dim socio As Asociado = GridEXSocios.SelectedItems(0).GetRow().DataRow
                Dim s As Asociado = (From k In context.Asociados _
                                 Where k.IDPacienteBeneficiario = socio.IDPacienteBeneficiario _
                                 And k.IDPacienteOrigen = socio.IDPacienteOrigen _
                                 ).First()

                'context.Asociados.Attach(socio)
                context.Asociados.DeleteOnSubmit(s)

                Dim beneficiario As PACIENTE = (From p In context.PACIENTEs _
                                             Where p.CPACIENTE = s.IDPacienteBeneficiario _
                                             Select p).Single()
                beneficiario.BENEFICIARIOCODIGOSOCIO = Nothing '0 porque asi estan todos grr
                context.SubmitChanges()
                CargarAsociados()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Function DameAsociacion(ByVal idPaciente As Integer) As Asociado
        'Esta funcion revisa a ver si el idPaciente ya esta en la tabla Asociados
        Dim lista As List(Of Asociado) = (From a In context.Asociados _
                                              Where a.IDPacienteBeneficiario = idPaciente _
                                              Select a).ToList()
        If lista.Count > 0 Then
            Return lista(0)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function ConvertToByteArray(ByVal value As Bitmap) As Byte()
        Dim bitmapBytes As Byte()
        Using stream As New System.IO.MemoryStream
            value.Save(stream, value.RawFormat)
            bitmapBytes = stream.ToArray
        End Using
        Return bitmapBytes
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ofd_imagenPaciente As New System.Windows.Forms.OpenFileDialog()
        If ofd_imagenPaciente.ShowDialog() = Windows.Forms.DialogResult.OK And ofd_imagenPaciente.FileName <> "" Then
            Try
                Dim pac As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = Me.IDPACIENTE Select p).First()
                Dim _imagen As Bitmap = New Bitmap(ofd_imagenPaciente.FileName)
                Dim _indice As Integer = ofd_imagenPaciente.FileName.LastIndexOf("\")
                Dim _name As String = ofd_imagenPaciente.FileName.Substring(_indice + 1)
                Dim _bytes() As Byte = ConvertToByteArray(_imagen)
                pac.FOTO() = _bytes
                pac.FOTOGRAFIA = _name

                fImagen = _bytes
                Using stream As New System.IO.MemoryStream(fImagen)
                    Dim _imagenPintar As Bitmap = New Bitmap(stream)
                    pb_dpImagen.BackgroundImage = _imagenPintar
                    pb_dpImagen.BackgroundImageLayout = ImageLayout.Stretch
                End Using
                context.SubmitChanges()
            Catch ex As Exception
                MessageBox.Show("Error al cargar imagen " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not fImagen Is Nothing Then
            Dim pac As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = Me.IDPACIENTE Select p).First()
            pac.FOTO = Nothing
            pac.FOTOGRAFIA = Nothing
            pb_dpImagen.BackgroundImage = Nothing
            context.SubmitChanges()
        End If
    End Sub

    Private Sub chb_dpActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chb_dpActivo.CheckedChanged
        dtp_dpFechabaja.Enabled = Not chb_dpActivo.Checked
    End Sub

    Private Sub dtp_dpFeNac_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dpFeNac.Leave
        CalcularEdad()
    End Sub

    Private Sub CargarMutuas()
        Dim paciente As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = Me.IDPACIENTE Select p).First()

        CargarMutuas(paciente)
    End Sub

    Private Sub CargarMutuas(pac As PACIENTE)
        GridEXMutuas.DataSource = Nothing
        LMUTUABindingSource.DataSource = pac.LMUTUAs
        GridEXMutuas.DataSource = LMUTUABindingSource
        DestacarMutuaPrincipal()
    End Sub

    Private Sub DestacarMutuaPrincipal()
        If Me.CtrlMutua1.ID_MUTUA Is Nothing Then
            Return
        End If
        For Each m As GridEXRow In GridEXMutuas.GetRows
            If m.DataRow.REFMUTUA = Me.CtrlMutua1.ID_MUTUA Then
                m.RowStyle = New Janus.Windows.GridEX.GridEXFormatStyle()
                m.RowStyle.ForeColor = Color.Green
                Exit For
            End If
        Next
    End Sub

    Private Sub CargarEmpresas()
        Dim pac As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = Me.IDPACIENTE Select p).First()
        CargarEmpresas(pac)
    End Sub

    Private Sub CargarEmpresas(pac As PACIENTE)

        GridEXEmpresas.DataSource = Nothing
        LEMPRESABindingSource.DataSource = pac.LEMPRESAs.Where(Function(k) k.EMPRESA.Eliminado.HasValue And k.EMPRESA.Eliminado = False)

        GridEXEmpresas.DataSource = LEMPRESABindingSource
        DestacarEmpresaPrincipal()
    End Sub

    Private Sub DestacarEmpresaPrincipal()
        If Me.CtrlEmpresa1.ID_EMPRESAS Is Nothing Then
            Return
        End If
        Dim m
        For Each m In GridEXEmpresas.GetRows
            If m.DataRow.REFEMPRESA = Me.CtrlEmpresa1.ID_EMPRESAS Then
                m.RowStyle = New Janus.Windows.GridEX.GridEXFormatStyle()
                m.RowStyle.ForeColor = Color.Green
                Exit Sub
            End If
        Next
    End Sub

    Private Sub GridEXMutuas_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXMutuas.RowDoubleClick
        tst_Modificar_Tratamiento_Click(Nothing, Nothing)
    End Sub

    Private Sub GridEXEmpresas_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXEmpresas.RowDoubleClick
        ToolStripButton3_Click(Nothing, Nothing)
    End Sub

    Private Sub GridEXContactos_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXContactos.RowDoubleClick
        btn_Edit_Click(Nothing, Nothing)
    End Sub

    Private Sub AplicaPermisosAHistorialesLaborales()
        tb_hlProfesion.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        tb_hlPuesto.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        cb_hlRegimen.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)

        tstMutuas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        tst_Eliminar_Tratamiento.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 3)

        GridEXEmpresas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)

        tsEmpresas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)
        ToolStripButton4.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 3)
        GridEXMutuas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Historial_Laboral) > 2)

    End Sub


    Private Sub GridEXMutuas_FormattingRow(sender As Object, e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEXMutuas.FormattingRow
        If e.Row.RowType = RowType.Record Then
            Dim lmutua As LMUTUA = e.Row.DataRow
            If lmutua.TIPO = "C" Then e.Row.Cells("columnTipoNombre").Text = "Compañía de Revisión"
            If lmutua.TIPO = "A" Then e.Row.Cells("columnTipoNombre").Text = "Aseguradora Privada"
            If lmutua.TIPO = "M" Then e.Row.Cells("columnTipoNombre").Text = "Mutua asistencial"
        End If
    End Sub



    Private Sub tstAnnadir_Tratamiento_Click(sender As Object, e As EventArgs) Handles tstAnnadir_Tratamiento.Click
        Dim _lmutua As New LMUTUA()

        Dim _annadirMutua As New frmLineaMutua_Editar(Me.IDPACIENTE)
        _annadirMutua.LMUTUASBindingSource.DataSource = _lmutua
        _annadirMutua.ShowInTaskbar = False

        If _annadirMutua.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Chequear si existe la  mutua
            If Globales.Mutua_Existe(_lmutua.REFMUTUA, Me.IDPACIENTE) Then
                MessageBox.Show("La mutua seleccionada ya existe")
                Return
            End If
            _lmutua.TIPO = _annadirMutua.TIPO
            _lmutua.REFPACIENTE = Me.IDPACIENTE
            If _annadirMutua.FECHAALTADateTimePicker.Checked Then
                _lmutua.FECHAALTA = _annadirMutua.FECHAALTADateTimePicker.Value
            End If
            If _annadirMutua.FECHABAJADateTimePicker.Checked Then
                _lmutua.FECHABAJA = _annadirMutua.FECHABAJADateTimePicker.Value
            End If

            context.LMUTUAs.InsertOnSubmit(_lmutua)
            context.SubmitChanges()

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Mutuas, "Mutua asociada a un paciente", _lmutua.CODIGO.ToString(), "mutua :" & _lmutua.REFMUTUA & " paciente : " & Me.IDPACIENTE)

            If MessageBox.Show("Desea establecer esta mutua como la actual para el paciente ", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.CtrlMutua1.ID_MUTUA = _lmutua.REFMUTUA
            End If

            CargarMutuas()
        End If
    End Sub

    Private Sub tst_Modificar_Tratamiento_Click(sender As Object, e As EventArgs) Handles tst_Modificar_Tratamiento.Click
        If GridEXMutuas.SelectedItems.Count < 1 Then
            Return
        End If
        Dim _lmutua As LMUTUA = GridEXMutuas.SelectedItems(0).GetRow.DataRow

        _lmutua = (From l In context.LMUTUAs Where l.CODIGO = _lmutua.CODIGO Select l).First()
        Dim _annadirMutua As New frmLineaMutua_Editar(Me.IDPACIENTE)
        _annadirMutua.LMUTUASBindingSource.DataSource = _lmutua
        If Not _lmutua.FECHAALTA Is Nothing Then
            _annadirMutua.FECHAALTADateTimePicker.Value = _lmutua.FECHAALTA
        End If
        If Not _lmutua.FECHABAJA Is Nothing Then
            _annadirMutua.FECHABAJADateTimePicker.Value = _lmutua.FECHABAJA
        End If
        _annadirMutua.ShowInTaskbar = False

        Dim oldMutua As Integer = _lmutua.REFMUTUA
        If _annadirMutua.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Chequear si existe la  mutua
            If _lmutua.REFMUTUA <> oldMutua And Globales.Mutua_Existe(_lmutua.REFMUTUA, Me.IDPACIENTE) Then
                MessageBox.Show("La mutua seleccionada ya existe")
                Return
            End If
            _lmutua.TIPO = _annadirMutua.TIPO
            If _annadirMutua.FECHAALTADateTimePicker.Checked Then
                _lmutua.FECHAALTA = _annadirMutua.FECHAALTADateTimePicker.Value
            End If
            If _annadirMutua.FECHABAJADateTimePicker.Checked Then
                _lmutua.FECHABAJA = _annadirMutua.FECHABAJADateTimePicker.Value
            End If
            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Mutuas, "Mutua asociada a un paciente", _lmutua.CODIGO.ToString(), "mutua :" & _lmutua.REFMUTUA & " paciente : " & Me.IDPACIENTE)
            CargarMutuas()
        End If

    End Sub

    Private Sub tst_Eliminar_Tratamiento_Click(sender As Object, e As EventArgs) Handles tst_Eliminar_Tratamiento.Click

        If GridEXMutuas.SelectedItems.Count < 1 Then
            Return
        End If

        If MessageBox.Show("Desea eliminar esta mutua?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim _lmutua As LMUTUA = GridEXMutuas.SelectedItems(0).GetRow.DataRow

            _lmutua = (From l In context.LMUTUAs Where l.CODIGO = _lmutua.CODIGO Select l).First()

            If Me.CtrlMutua1.ID_MUTUA = _lmutua.REFMUTUA Then
                Me.CtrlMutua1.ID_MUTUA = Nothing
                Me.CtrlMutua1.btn_Deseleccionar_Click(Nothing, Nothing)
            End If

            context.LMUTUAs.DeleteOnSubmit(_lmutua)
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Mutuas, "Mutua asociada a un paciente", _lmutua.CODIGO.ToString(), "mutua :" & _lmutua.REFMUTUA & " paciente : " & Me.IDPACIENTE)
            context.SubmitChanges()

            CargarMutuas()
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If GridEXMutuas.SelectedItems.Count < 1 Then
            Return
        End If
        Dim _lmutua As LMUTUA = GridEXMutuas.SelectedItems(0).GetRow.DataRow
        Me.CtrlMutua1.ID_MUTUA = _lmutua.REFMUTUA
        DestacarMutuaPrincipal()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim linea As New LEMPRESA()
        linea.REFPACIENTE = Me.IDPACIENTE
        linea.PUESTOTRABAJO = ""

        Dim frm As New frmEmpresa_Paciente()
        frm.LEMPRESABindingSource.DataSource = linea
        If frm.ShowDialog() = DialogResult.OK Then

            If Not Globales.Empresa_Existe(linea.REFEMPRESA, Me.IDPACIENTE) Then
                context.LEMPRESAs.InsertOnSubmit(linea)
            Else
                MessageBox.Show("La empresa seleccionada ya existe")
                Return
            End If

            If MessageBox.Show("Desea establecer esta empresa como la actual para el paciente ", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.CtrlEmpresa1.ID_EMPRESAS = linea.REFEMPRESA
            End If
            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Empresas, "Empresa asociada a paciente", linea.CODIGO.ToString(), "empresa : " & linea.EMPRESA.NOMBRE & " paciente : " & Me.IDPACIENTE)
            CargarEmpresas()

        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If GridEXEmpresas.SelectedItems.Count < 1 Then
            Return
        End If

        Dim linea As LEMPRESA = GridEXEmpresas.SelectedItems(0).GetRow.DataRow
        Dim idlinea = linea.REFEMPRESA
        linea = (From l In context.LEMPRESAs Where l.CODIGO = linea.CODIGO Select l).First()

        Dim frm As New frmEmpresa_Paciente()
        frm.LEMPRESABindingSource.DataSource = linea
        If frm.ShowDialog() = DialogResult.OK Then
            If idlinea <> linea.REFEMPRESA.Value Then
                If Globales.Empresa_Existe(linea.REFEMPRESA, Me.IDPACIENTE) Then
                    MessageBox.Show("La empresa seleccionada ya existe")
                    Return
                End If
            End If
            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Empresas, "Empresa asociada a paciente", linea.CODIGO.ToString(), "empresa : " & linea.EMPRESA.NOMBRE & " paciente : " & Me.IDPACIENTE.ToString())
            CargarEmpresas()
        End If

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If GridEXEmpresas.SelectedItems.Count < 1 Then
            Return
        End If

        Dim linea As LEMPRESA = GridEXEmpresas.SelectedItems(0).GetRow.DataRow

        linea = (From l In context.LEMPRESAs Where l.CODIGO = linea.CODIGO Select l).First()

        If Me.CtrlEmpresa1.ID_EMPRESAS = linea.REFEMPRESA Then
            Me.CtrlEmpresa1.ID_EMPRESAS = Nothing
        End If

        context.LEMPRESAs.DeleteOnSubmit(linea)
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Empresas, "Empresa asociada a paciente", linea.CODIGO.ToString(), "empresa : " & linea.EMPRESA.NOMBRE & " paciente : " & Me.IDPACIENTE.ToString())
        context.SubmitChanges()
        CargarEmpresas()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If GridEXEmpresas.SelectedItems.Count < 1 Then
            Return
        End If

        Dim linea As LEMPRESA = GridEXEmpresas.SelectedItems(0).GetRow.DataRow
        Me.CtrlEmpresa1.ID_EMPRESAS = linea.REFEMPRESA
        DestacarEmpresaPrincipal()
    End Sub

    Private Sub CtrlEmpresa1_EMPRESASeleccionado(IdEMPRESAS As Integer, IsReturnPressed As Boolean) Handles CtrlEmpresa1.EMPRESASeleccionado
        If CtrlMutua1.ID_MUTUA Is Nothing Then
            Dim empresa As EMPRESA = context.EMPRESAs.Single(Function(e) e.CEMPRESA = IdEMPRESAS)
            If Not empresa Is Nothing Then
                If empresa.REFMUTUA.HasValue Then
                    CtrlMutua1.ID_MUTUA = empresa.REFMUTUA
                End If
            End If
        Else
            ' If IsReturnPressed Then
            Dim empresa As EMPRESA = context.EMPRESAs.Single(Function(e) e.CEMPRESA = IdEMPRESAS)
            If Not empresa Is Nothing AndAlso empresa.REFMUTUA.HasValue Then
                If MsgBox("Desea cambiar la mutua del paciente por la de la empresa recien seleccionada?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CtrlMutua1.ID_MUTUA = empresa.REFMUTUA
                End If
            End If
        End If
        CargarEmpresas()
    End Sub


    Private Sub tb_dpDni_TextChanged(sender As Object, e As EventArgs) Handles tb_dpDni.TextChanged
        Dim _letra As String
        If IsNumeric(tb_dpDni.Text) Then
            _letra = Globales.GetLetter(tb_dpDni.Text)
            lb_dpLetradni.Text = _letra
        Else
            lb_dpLetradni.Text = "-"
        End If

    End Sub

    Private Sub tb_dpDni_Leave(sender As Object, e As EventArgs) Handles tb_dpDni.Leave
        ChequeaExisteDNI(tb_dpDni.Text)
    End Sub

    Private Sub tb_dpPasaporte_Leave(sender As Object, e As EventArgs) Handles tb_dpPasaporte.Leave
        ChequeaExistePasaporte(tb_dpPasaporte.Text)
    End Sub


    Private Sub tb_dpNie_Leave(sender As Object, e As EventArgs) Handles tb_dpNie.Leave
        ChequeaExisteNIE(tb_dpNie.Text)
    End Sub

    Public Sub ChequeaDatosDuplicados()
        ChequeaExisteDNI(tb_dpDni.Text)
        ChequeaExistePasaporte(tb_dpPasaporte.Text)
        ChequeaExisteNIE(tb_dpNie.Text)
        ChequeaExisteNombre(tb_Nombre.Text, tb_Apellido1.Text, tb_Apellido2.Text)
        'If ChequeaExisteDNI(tb_dpDni.Text) Or ChequeaExistePasaporte(tb_dpPasaporte.Text) Or ChequeaExisteNIE(tb_dpNie.Text) Or _
        '    ChequeaExisteNombre(tb_Nombre.Text, tb_Apellido1.Text, tb_Apellido2.Text) Then
        '    Return True
        'Else
        '    Return False
        'End If
        'Dim nombreCompleto As String = GetNombreCompleto(tb_Nombre.Text, tb_Apellido1.Text, tb_Apellido2.Text)

    End Sub


    Private Sub ChequeaExisteDNI(ByVal dni As String)
        PacDataDupl = 1
        If Not dni = String.Empty Then
            Dim pacienteOtro As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE <> IDPACIENTE _
                                           And p.DNI = dni And (p.Eliminado Is Nothing Or p.Eliminado = False)
                                           Select p).SingleOrDefault()
            If Not pacienteOtro Is Nothing Then
                Dim DescPas As Descartar_Pacientes_Duplicado = (From p In context.Descartar_Pacientes_Duplicados _
                    Where p.Id_Paciente_Origen = IDPACIENTE And p.Id_Paciente_Descartado = pacienteOtro.CPACIENTE Select p).SingleOrDefault()

                If DescPas Is Nothing Or (Not DescPas Is Nothing AndAlso Not DescPas.DescDNI) Then
                    If tb_dpDni.ForeColor <> Color.Red Then
                        Dim res As MsgBoxResult = MsgBox("El dni: " & dni & " existe ya en el paciente: [" & pacienteOtro.CPACIENTE & "] " & pacienteOtro.NombreCompleto & ", ¿Desea seguir guardando?", MsgBoxStyle.YesNo)

                        If res = MsgBoxResult.No Then
                            Exit Sub
                        Else
                            DescartarPaciente(pacienteOtro.CPACIENTE)
                        End If
                    End If
                    tb_dpDni.ForeColor = Color.Red
                Else
                    ActualizaDescPacientes()
                    tb_dpDni.ForeColor = Color.Black
                End If
            End If
        End If
    End Sub

    Private Sub ChequeaExistePasaporte(ByVal pasaporte As String)
        PacDataDupl = 2
        If Not pasaporte = String.Empty Then
            Dim pacienteOtro As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE <> IDPACIENTE _
                                           And p.PASAPORTE = pasaporte And (p.Eliminado Is Nothing Or p.Eliminado = False)
                                           Select p).SingleOrDefault()
            If Not pacienteOtro Is Nothing Then

                Dim DescPas As Descartar_Pacientes_Duplicado = (From p In context.Descartar_Pacientes_Duplicados _
                    Where p.Id_Paciente_Origen = IDPACIENTE And p.Id_Paciente_Descartado = pacienteOtro.CPACIENTE Select p).SingleOrDefault()

                If DescPas Is Nothing Or (Not DescPas Is Nothing AndAlso Not DescPas.DescPasaporte) Then
                    If tb_dpPasaporte.ForeColor <> Color.Red Then
                        Dim res As MsgBoxResult = MsgBox("El pasaporte: " & pasaporte & " existe ya en el paciente: [" & pacienteOtro.CPACIENTE & "] " & pacienteOtro.NombreCompleto & ", ¿Desea seguir guardando?", MsgBoxStyle.YesNo)
                        If res = MsgBoxResult.No Then
                            Exit Sub
                        Else
                            DescartarPaciente(pacienteOtro.CPACIENTE)
                        End If
                    End If
                    tb_dpPasaporte.ForeColor = Color.Red
                Else
                    ActualizaDescPacientes()
                    tb_dpPasaporte.ForeColor = Color.Black
                End If
            End If
        End If
    End Sub

    Private Sub ChequeaExisteNIE(ByVal nie As String)
        PacDataDupl = 3
        If Not nie.Trim() = String.Empty Then
            Dim pacienteOtro As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE <> IDPACIENTE _
                                           And p.NIE = nie And (p.Eliminado Is Nothing Or p.Eliminado = False)
                                           Select p).SingleOrDefault()
            If Not pacienteOtro Is Nothing Then
                Dim DescPas As Descartar_Pacientes_Duplicado = (From p In context.Descartar_Pacientes_Duplicados _
                   Where p.Id_Paciente_Origen = IDPACIENTE And p.Id_Paciente_Descartado = pacienteOtro.CPACIENTE Select p).SingleOrDefault()

                If DescPas Is Nothing Or (Not DescPas Is Nothing AndAlso Not DescPas.DescNIE) Then
                    If tb_dpNie.ForeColor <> Color.Red Then
                        Dim res As MsgBoxResult = MsgBox("El NIE: " & nie & " existe ya en el paciente: [" & pacienteOtro.CPACIENTE & "] " & pacienteOtro.NombreCompleto & ", ¿Desea seguir guardando?", MsgBoxStyle.YesNo)
                        If res = MsgBoxResult.No Then
                            Exit Sub
                        Else
                            DescartarPaciente(pacienteOtro.CPACIENTE)
                        End If
                    End If
                    tb_dpNie.ForeColor = Color.Red
                Else
                    ActualizaDescPacientes()
                    tb_dpNie.ForeColor = Color.Black
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Checkea si existe nombre parecido.
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="apellido1"></param>
    ''' <param name="apellido2"></param>
    ''' <returns>devuelve true en caso de haber coincidencias y muestra un mensaje.</returns>
    ''' <remarks></remarks>
    Private Sub ChequeaExisteNombre(ByVal nombre As String, ByVal apellido1 As String, ByVal apellido2 As String)
        Dim nombreCompleto As String = GetNombreCompleto(nombre, apellido1, apellido2)
        Dim res As Boolean = False
        Dim idPacOtro As Integer
        PacDataDupl = 4
        If Not nombreCompleto = String.Empty Then
            Dim pacienteOtros As List(Of PACIENTE) = (From p In context.PACIENTEs Where p.CPACIENTE <> IDPACIENTE _
                       And (p.Eliminado Is Nothing Or p.Eliminado = False) Select p).ToList()
            Dim mensaje As String = ""
            'Dim diffMatchPatch As New diff_match_patch()
            For Each p As PACIENTE In pacienteOtros
                Dim tNombre, tApellido1, tApellido2 As String
                If ((Not p.NOMBRE Is Nothing)) Then
                    tNombre = p.NOMBRE
                Else
                    tNombre = ""
                End If
                If ((Not p.APELLIDO1 Is Nothing)) Then
                    tApellido1 = p.APELLIDO1
                Else
                    tApellido1 = ""
                End If
                If ((Not p.APELLIDO2 Is Nothing)) Then
                    tApellido2 = p.APELLIDO2
                Else
                    tApellido2 = ""
                End If

                'Comparacion de nombres segun acentos y espacios en blanco
                Dim pNombreCompleto As String = nombre & " " & apellido1 & " " & apellido2
                Dim dbNombreCompleto As String = tNombre & " " & tApellido1 & " " & tApellido2
                res = CustomNameComparison.CadenasSimilares(pNombreCompleto.ToUpper(), dbNombreCompleto.ToUpper())
                If res Then
                    Dim DescPas As Descartar_Pacientes_Duplicado = (From pac In context.Descartar_Pacientes_Duplicados _
                   Where pac.Id_Paciente_Origen = IDPACIENTE And pac.Id_Paciente_Descartado = p.CPACIENTE Select pac).SingleOrDefault()

                    If DescPas Is Nothing Or (Not DescPas Is Nothing AndAlso Not DescPas.DescNombre) Then
                        If tb_Nombre.ForeColor <> Color.Red Then
                            mensaje = "El nombre: " & pNombreCompleto.ToUpper() & " esta causando coincidencia con el del paciente: [" & p.CPACIENTE & "] " & dbNombreCompleto & ", ¿Desea seguir guardando?"
                            idPacOtro = p.CPACIENTE
                            res = True
                        End If
                        tb_Nombre.ForeColor = Color.Red
                        tb_Apellido1.ForeColor = Color.Red
                        tb_Apellido2.ForeColor = Color.Red
                        Exit For
                    End If
                End If

                'Comparacion de nombres segun otros elementos, hallando la distancia de Jaro-Winkler entre ambos
                Dim jwd As JaroWinklerDistance = New JaroWinklerDistance()
                Dim distancia As Double = 0
                Dim distanciaNombre As Double = 1
                Dim distanciaApellido1 As Double = 1
                Dim distanciaApellido2 As Double = 1
                If tNombre <> String.Empty Or nombre <> String.Empty Then
                    distanciaNombre = jwd.GetDistance(tNombre.ToUpper(), nombre.ToUpper())
                End If
                If tApellido1 <> String.Empty Or apellido1 <> String.Empty Then
                    distanciaApellido1 = jwd.GetDistance(tApellido1.ToUpper(), apellido1.ToUpper())
                End If
                If tApellido2 <> String.Empty Or apellido2 <> String.Empty Then
                    distanciaApellido2 = jwd.GetDistance(tApellido2.ToUpper(), apellido2.ToUpper())
                End If
                'Nos quedamos con la distancia Jaro-Winkler minima
                distancia = Math.Min(distanciaApellido1, distanciaApellido2)
                distancia = Math.Min(distancia, distanciaNombre)

                If (distancia >= JARO_WINKLER_DISTANCE) Then
                    Dim DescPas As Descartar_Pacientes_Duplicado = (From pac In context.Descartar_Pacientes_Duplicados _
                   Where pac.Id_Paciente_Origen = IDPACIENTE And pac.Id_Paciente_Descartado = p.CPACIENTE Select pac).SingleOrDefault()

                    If DescPas Is Nothing Or (Not DescPas Is Nothing AndAlso Not DescPas.DescNombre) Then
                        If tb_Nombre.ForeColor <> Color.Red Then
                            mensaje = "El nombre: " & pNombreCompleto.ToUpper() & " esta causando coincidencia con el del paciente: [" & p.CPACIENTE & "] " & dbNombreCompleto & ", ¿Desea seguir guardando?"
                            idPacOtro = p.CPACIENTE
                            res = True
                        End If
                        tb_Nombre.ForeColor = Color.Red
                        tb_Apellido1.ForeColor = Color.Red
                        tb_Apellido2.ForeColor = Color.Red
                        Exit For
                    Else
                        tb_Nombre.ForeColor = Color.Black
                        tb_Apellido1.ForeColor = Color.Black
                        tb_Apellido2.ForeColor = Color.Black
                    End If
                End If
            Next
            If res Then
                Dim resp As MsgBoxResult = MsgBox(mensaje, MsgBoxStyle.YesNo)
                If resp = MsgBoxResult.No Then
                    Exit Sub
                Else
                    DescartarPaciente(idPacOtro)
                End If
            Else
                ActualizaDescPacientes()
            End If
        End If
    End Sub
    Private Function checkCodigoPropio()
        If Me.tb_CodigoPaciente.Text.Trim.Length = 0 Then Return False

        If Me.tb_CodigoPropio.Text.Trim.Length > 0 Then
            Dim pacCoincidentes As IList(Of PACIENTE) = (From a In context.PACIENTEs Where a.CODIGOPROPIO = tb_CodigoPropio.Text.Trim And a.CPACIENTE <> Me.tb_CodigoPaciente.Text.Trim And (a.Eliminado = False Or a.Eliminado Is Nothing) Select a).ToList

            Dim msg As String = ""
            Dim duplicado As Boolean = False
            If pacCoincidentes.Count > 0 Then
                For Each pac As PACIENTE In pacCoincidentes
                    msg = msg & "Ya existe el paciente " & pac.NombreCompleto & " - " & pac.CPACIENTE & " con ese código propio." & vbCrLf
                Next
                MsgBox("No es posible guardar: " & vbCrLf & msg)
                Return False
            End If
        End If
        Return True
    End Function
    Private Function GetNombreCompleto(nombre As String, apellido1 As String, apellido2 As String) As String
        If Globales.Usuario.CONFIGURACIONXML.<Citas>.<CitaFormatoNombre>.Value = "1" Then
            Return (apellido1 & " " & apellido2 & " " & nombre).Trim()
        Else
            Return (nombre & " " & apellido1 & " " & apellido2).Trim()
        End If
    End Function
    Private Function DeleteAsociadoYBeneficiarios(paciente As PACIENTE)
        paciente.SOCIO = "N"
        Dim asociados As List(Of Asociado) = paciente.Asociados1.ToList()

        For Each asoc As Asociado In asociados
            asoc.PACIENTE.BENEFICIARIOCODIGOSOCIO = 0
        Next

        Me.context.Asociados.DeleteAllOnSubmit(asociados)
        Me.context.SubmitChanges()
    End Function

    Private Sub CtrlEmpresa1_EMPRESANoEncontrado()

    End Sub
    Private Sub CtrlEmpresa1_EMPRESAEliminado(IdEMPRESASAnterior As Integer)

    End Sub
    Private Sub CtrlMutua1_MutuasEliminada(IdMutuas As Integer)

    End Sub
    Private Sub CtrlMutua1_MutuasNoEncontrado()

    End Sub
    Private Sub CtrlMutua1_MutuaSeleccionada(IdMutuas As Integer) Handles CtrlMutua1.MUTUASeleccionada
        Dim _lmutua As New LMUTUA()
        _lmutua.REFMUTUA = IdMutuas
        _lmutua.REFPACIENTE = Me.IDPACIENTE


        Dim _annadirMutua As New frmLineaMutua_Editar(Me.IDPACIENTE)
        _annadirMutua.LMUTUASBindingSource.DataSource = _lmutua
        _annadirMutua.ShowInTaskbar = False
        '_annadirMutua.CtrlMutua1.ID_Mutuas = IdMutuas
        _annadirMutua.CtrlMutua1.Enabled = False

        If _annadirMutua.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Chequear si existe la  mutua

            _lmutua.TIPO = _annadirMutua.TIPO
            _lmutua.REFPACIENTE = Me.IDPACIENTE
            If _annadirMutua.FECHAALTADateTimePicker.Checked Then
                _lmutua.FECHAALTA = _annadirMutua.FECHAALTADateTimePicker.Value
            End If
            If _annadirMutua.FECHABAJADateTimePicker.Checked Then
                _lmutua.FECHABAJA = _annadirMutua.FECHABAJADateTimePicker.Value
            End If
            _lmutua.TIPO = _annadirMutua.TIPO

            If MessageBox.Show("Desea establecer esta mutua como la actual para el paciente ", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.CtrlMutua1.ID_MUTUA = _lmutua.REFMUTUA
            End If

            If Globales.Mutua_Existe(_lmutua.REFMUTUA, Me.IDPACIENTE) Then
                Dim lm As LMUTUA = pac.LMUTUAs.Where(Function(o) o.REFMUTUA = CtrlMutua1.ID_MUTUA).SingleOrDefault
                lm.TIPO = _annadirMutua.TIPO
                context.SubmitChanges()
                'MessageBox.Show("La mutua seleccionada ya existe")
                'Return
            Else
                context.LMUTUAs.InsertOnSubmit(_lmutua)
                context.SubmitChanges()
            End If


            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Mutuas, "Mutua asociada a un paciente", _lmutua.CODIGO.ToString(), "mutua :" & _lmutua.REFMUTUA & " paciente : " & Me.IDPACIENTE)
            CargarMutuas()
        End If
    End Sub
    Private Sub CtrlMutua1_MutuasSeleccionado(IdMutuas As Integer)

    End Sub

    Private Sub webcam_Click(sender As Object, e As EventArgs) Handles webcam.Click
        Dim frm As formPaciente_Captura = New formPaciente_Captura()
        If frm.TestConnection() Then
            frm.IDPAC = IDPACIENTE
            frm.ShowDialog()
            If Not frm.Selected Is Nothing Then
                Dim IMAGEN As Image = frm.Selected
                pb_dpImagen.BackgroundImage = IMAGEN
                pb_dpImagen.BackgroundImageLayout = ImageLayout.Stretch
            End If
            GC.Collect()
        End If
    End Sub

    Private Sub DescartarPaciente(PacienteOtro As Integer)
        If Not PacDataDupl = 0 Then

            ActualizaDescPacientes()

            Dim DescPas As Descartar_Pacientes_Duplicado = (From p In context.Descartar_Pacientes_Duplicados _
                                                            Where p.Id_Paciente_Origen = IDPACIENTE _
                                                            And p.Id_Paciente_Descartado = PacienteOtro _
                                                            Select p).SingleOrDefault()
            If DescPas Is Nothing Then
                Dim NewDescPas As New Descartar_Pacientes_Duplicado With {
                .Id_Paciente_Origen = IDPACIENTE,
                .Id_Paciente_Descartado = PacienteOtro,
                .Fecha_Descarte = Date.Now,
                .DescDNI = False,
                .DescPasaporte = False,
                .DescNIE = False,
                .DescNombre = False
                }
                AsignarValor(NewDescPas, True)

                context.Descartar_Pacientes_Duplicados.InsertOnSubmit(NewDescPas)
                context.SubmitChanges()
            Else
                DescPas.Fecha_Descarte = Date.Now
                AsignarValor(DescPas, True)
                context.SubmitChanges()
            End If
        End If
    End Sub

    Private Sub ActualizaDescPacientes()

        Dim RefreshDesc As Descartar_Pacientes_Duplicado = (From p In context.Descartar_Pacientes_Duplicados.AsEnumerable() _
                                                             Where (p.Id_Paciente_Origen = IDPACIENTE Or p.Id_Paciente_Descartado = IDPACIENTE) _
                                                             And ConcidePaciente(p) _
                                                             Select p).SingleOrDefault()
        If Not RefreshDesc Is Nothing Then
            RefreshDesc.Fecha_Descarte = Date.Now
            AsignarValor(RefreshDesc, False)
            context.SubmitChanges()
        End If

        If Not (RefreshDesc.DescDNI Or RefreshDesc.DescPasaporte Or RefreshDesc.DescNIE Or RefreshDesc.DescNombre) Then
            context.Descartar_Pacientes_Duplicados.DeleteOnSubmit(RefreshDesc)
        End If
    End Sub

    Private Function ConcidePaciente(p As Descartar_Pacientes_Duplicado) As Boolean
        Select Case PacDataDupl
            Case 1
                Return p.DescDNI
            Case 2
                Return p.DescPasaporte
            Case 3
                Return p.DescNIE
            Case 4
                Return p.DescNombre
        End Select
    End Function

    Private Sub AsignarValor(p As Descartar_Pacientes_Duplicado, value As Boolean)
        Select Case PacDataDupl
            Case 1
                p.DescDNI = value
            Case 2
                p.DescPasaporte = value
            Case 3
                p.DescNIE = value
            Case 4
                p.DescNombre = value
        End Select
    End Sub
End Class