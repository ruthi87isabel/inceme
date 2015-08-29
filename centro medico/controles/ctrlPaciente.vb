Public Class ctrlPaciente

    Public Paciente As PACIENTE = Nothing
    Private FechaValidoSocio As String

    Private EmptyFont As Font = New Font("Microsoft Sans Serif", 7.25, FontStyle.Italic, GraphicsUnit.Point)
    Private SelectedFont As Font = New Font("Microsoft Sans Serif", 7.25, FontStyle.Regular, GraphicsUnit.Point)
    Private EmptyColor As Color = Color.DarkGray
    Private SelectedColor As Color = Color.Black



    Public Event PacienteSeleccionadoByBrowser(ByVal IdPaciente As Integer)
    Public Event PacienteSeleccionado(ByVal IdPaciente As Integer, ByVal IsReturnPressed As Boolean)
    Public Event PacienteSeleccionadoDeNuevo(ByVal IdPaciente As Integer)
    Public Event PacienteFichaAbierta(ByVal IdPaciente As Integer)
    Public Event PacienteEliminado(ByVal IdPaciente As Integer)
    Public Event PacienteNoEncontrado()

#Region "Public Function NombreCompleto() As String"
    Public Function NombreCompleto() As String
        Dim nombre As String = "Seleccione paciente"
        If Not Paciente Is Nothing Then
            Return Paciente.NombreCompleto
        End If
        Return nombre
    End Function
#End Region

#Region "Private Sub CargarPaciente(ByVal id As Integer, ByVal IsReturnPressed As Boolean)"
    Private Sub CargarPaciente(ByVal id As Nullable(Of Integer), ByVal codigoPropio As String, ByVal IsReturnPressed As Boolean)
        Try
           
            Dim context As New CMLinqDataContext
            If id.HasValue Then
                Paciente = (From p In context.PACIENTEs Where p.CPACIENTE = id And (Not p.Eliminado.HasValue Or p.Eliminado = False) Select p).SingleOrDefault()
            Else
                Paciente = (From p In context.PACIENTEs Where p.CODIGOPROPIO = codigoPropio And (Not p.Eliminado.HasValue Or p.Eliminado = False) Select p).SingleOrDefault()
            End If

            If Not Paciente Is Nothing Then

                txt_Nombre.Font = SelectedFont
                txt_Nombre.ForeColor = SelectedColor
                If Paciente.BENEFICIARIOCODIGOSOCIO > 0 Then
                    Dim pacienteSocio As PACIENTE
                    pacienteSocio = (From m In context.PACIENTEs Where m.CPACIENTE = Paciente.BENEFICIARIOCODIGOSOCIO).SingleOrDefault
                    If Not pacienteSocio.SOCIOVALIDOHASTA Is Nothing Then FechaValidoSocio = Format(pacienteSocio.SOCIOVALIDOHASTA, "dd/MM/yyyy")

                End If
                Muestra()
                btnVerFicha.Enabled = True
                RaiseEvent PacienteSeleccionado(Paciente.CPACIENTE, IsReturnPressed)
            Else
                txt_Nombre.Text = "Paciente no encontrado..."
                txt_Nombre.Font = EmptyFont
                txt_Nombre.ForeColor = EmptyColor
                btnVerFicha.Enabled = False
                lblAsociado.Visible = False
                lblBeneficiario.Visible = False
                lbl_DNI.Text = "Sin dni, nie ni pasaporte"
                RaiseEvent PacienteNoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando paciente")
            ' btnVerFicha.Enabled = False
        End Try
    End Sub
#End Region

#Region "Private Sub CargaPaciente()"
    Private Sub CargaPaciente(ByVal IsReturnPressed As Boolean)

        If (txt_CP.Text.Length = 0 And txt_Codigo.Text.Length = 0) Then
            RaiseEvent PacienteNoEncontrado()
            txt_Nombre.Text = "Seleccione un paciente.."
            Return
        End If

        'Buscar primero por el Codigo
        'Luego por el codigo propio

        If txt_Codigo.Text.Length > 0 Then
            Try
                Dim id As Integer = txt_Codigo.Text
                If Me.ID_PACIENTE.HasValue Then
                    If id = Me.ID_PACIENTE.Value Then
                        'no recargarlo de nuevo
                        Return
                    End If
                End If
                CargarPaciente(id, Nothing, IsReturnPressed)
                Return
            Catch ex As Exception
            End Try
        End If

        If txt_CP.Text.Length > 0 Then
            CargarPaciente(Nothing, txt_CP.Text, IsReturnPressed)
        End If

    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()

        Dim fullName As String = "Nombre es nulo!!"

        txt_Codigo.Text = Paciente.CPACIENTE
        txt_Nombre.Text = Paciente.NombreCompleto()

        txt_CP.Text = Paciente.CODIGOPROPIO.Trim()

        If Not IsNothing(Paciente.FECHAN) Then lblFechaNacimiento.Text = "F. Nac: " & CDate(Paciente.FECHAN).ToShortDateString
        lblTelefono.Text = "Telfs: " & Paciente.TLFNO & " " & Paciente.MOVIL
        If (Not Paciente.DNI Is Nothing AndAlso Paciente.DNI.Length > 0) Then
            lbl_DNI.Text = "DNI: " & Paciente.DNI & Globales.GetLetter(Paciente.DNI)

        ElseIf (Not Paciente.NIE Is Nothing AndAlso Paciente.NIE.Length > 0) Then
            lbl_DNI.Text = "NIE: " & Paciente.NIE

        ElseIf (Not Paciente.PASAPORTE Is Nothing AndAlso Paciente.PASAPORTE.Length > 0) Then
            lbl_DNI.Text = "PASP: " & Paciente.PASAPORTE
        Else
            lbl_DNI.Text = "No hay dni, nie ni pasaporte def."
        End If

        If (Not Paciente.FOTO Is Nothing) Then
            Dim ms As New IO.MemoryStream(Paciente.FOTO.ToArray)
            pb_Imagen.Image = Image.FromStream(ms)
            ms.Close()
        Else
            pb_Imagen.Image = Global.centro_medico.My.Resources.Resources.pacienteSingular
        End If

        If Not Paciente.SOCIO Is Nothing Then
            lblAsociado.Visible = Paciente.SOCIO = "S"
            lblBeneficiario.Visible = False
            If Not (Paciente.SOCIOVALIDOHASTA Is Nothing) Then
                lblFechaValidoSocio.Visible = True
                lblFechaValidoSocio.Text = "hasta " & Format(Paciente.SOCIOVALIDOHASTA(), "dd-MM-yyyy")
            Else
                lblFechaValidoSocio.Visible = False
            End If

        End If
        If (Paciente.BENEFICIARIOCODIGOSOCIO > 0) Then
            lblAsociado.Visible = False
            lblBeneficiario.Visible = True
            If Not Me.FechaValidoSocio Is Nothing Then
                lblFechaValidoSocio.Visible = True
                lblFechaValidoSocio.Text = "hasta " & Me.FechaValidoSocio
            Else
                lblFechaValidoSocio.Visible = False
            End If


        End If



    End Sub
#End Region

    <System.ComponentModel.Browsable(True)> _
   Public Property ID_PACIENTE() As Nullable(Of Integer)
        Get
            If Paciente Is Nothing Then
                Return Nothing
            Else
                Return Paciente.CPACIENTE
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarPaciente(value, Nothing, False)
            End If
        End Set
    End Property

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            Try
                Dim id As Integer = Integer.Parse(txt_Codigo.Text)
                CargarPaciente(id, Nothing, True)
                If ID_PACIENTE.HasValue Then
                    'Tiene valor
                    RaiseEvent PacienteSeleccionadoByBrowser(ID_PACIENTE)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txt_CP_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CP.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And ((txt_CP.Text.Length > 0) Or txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            CargaPaciente(True)
            If ID_PACIENTE.HasValue Then
                'Tiene valor
                RaiseEvent PacienteSeleccionadoByBrowser(ID_PACIENTE)
            End If
        End If
    End Sub


    'Private Sub txt_CP_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CP.Leave
    '    txt_Codigo.Text = String.Empty
    '    CargaPaciente(False)
    'End Sub

    'Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
    '    CargaPaciente(False)
    'End Sub

    Private Sub ctrlPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Globales.Configuracion.EnfocarCodigoPropioPaciente Then
            txt_CP.TabIndex = 90
            txt_Codigo.TabIndex = 91
        Else
            txt_CP.TabIndex = 91
            txt_Codigo.TabIndex = 90
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
       
        Dim frm As New frmPacientesListado()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = DialogResult.OK Then
            If Me.ID_PACIENTE.HasValue Then
                If frm.Paciente.CPACIENTE = Me.ID_PACIENTE.Value Then
                    'no recargarlo de nuevo, pero actualizar sus datos
                    'Globales.Context.Refresh(Data.Linq.RefreshMode.KeepCurrentValues, Paciente)
                    RaiseEvent PacienteSeleccionadoDeNuevo(frm.Paciente.CPACIENTE)
                    Return
                End If
            End If

            CargarPaciente(frm.Paciente.CPACIENTE, Nothing, False)
            RaiseEvent PacienteSeleccionadoByBrowser(frm.Paciente.CPACIENTE)

        End If
        If Not frm.IsDisposed Then
            frm.Dispose()
            frm = Nothing
        End If

        FreeMemory.FlushMemory()

    End Sub




    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click

        Dim idEliminado As Nullable(Of Integer) = Me.ID_PACIENTE

        Me.ID_PACIENTE = Nothing
        Me.Paciente = Nothing
        txt_Nombre.Text = "Seleccione paciente..."
        txt_Nombre.Font = EmptyFont
        txt_Nombre.ForeColor = EmptyColor
        txt_Codigo.Text = String.Empty
        txt_CP.Text = String.Empty
        lbl_DNI.Text = String.Empty
        btnVerFicha.Enabled = False
        lblAsociado.Visible = False
        lblBeneficiario.Visible = False
        If idEliminado.HasValue Then
            RaiseEvent PacienteEliminado(idEliminado)
        End If
    End Sub

    Private Sub btnVerFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFicha.Click

        If ID_PACIENTE.HasValue Then
            Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Editar", Enums.Accion.Modificar, ID_PACIENTE.Value)
            _nuevo_paciente.ShowInTaskbar = False
            _nuevo_paciente.ShowDialog()
            'Globales.Context.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, Paciente)
            'Paciente = (From p In Globales.Context.PACIENTEs Where p.CPACIENTE = ID_PACIENTE.Value Select p).SingleOrDefault()

            _nuevo_paciente.Dispose()
            _nuevo_paciente = Nothing
            FreeMemory.FlushMemory()
            Muestra()
            RaiseEvent PacienteFichaAbierta(ID_PACIENTE.Value)
        End If
    End Sub
    Public Sub abrirFicha()
        btnVerFicha_Click(Nothing, Nothing)
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lbl_DNI.Text = "Sin dni, nie ni pasaporte"
    End Sub
End Class
