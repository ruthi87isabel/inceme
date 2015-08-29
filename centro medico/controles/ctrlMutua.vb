Imports Microsoft.ApplicationBlocks.Data



Public Class ctrlMutua
    Public Mutuas As CMDataSet.MUTUASRow = Nothing
    Private table As CMDataSet.MUTUASDataTable = New CMDataSet.MUTUASDataTable()
    Private adapter As CMDataSetTableAdapters.MUTUASTableAdapter = New CMDataSetTableAdapters.MUTUASTableAdapter()
    Private _escogerViaLinea As Boolean = False
    Private _idpaciente As Nullable(Of Integer)

    Public Event MutuasSeleccionado(ByVal IdMutuas As Integer)
    Public Event MutuasSeleccionadoManualmente(ByVal IdMutuas As Integer)
    Public Event MutuasNoEncontrado()
    Public Event MutuasEliminada(ByVal IdMutuas As Integer)


    Private _filtrarMutuaPorPaciente As Boolean = False


#Region "Public Property ID_Mutuas() As String"
    <System.ComponentModel.Browsable(True)> _
    Public Property FiltrarMutuasPorPAciente() As Boolean
        Get
            Return _filtrarMutuaPorPaciente
        End Get
        Set(ByVal value As Boolean)
            _filtrarMutuaPorPaciente = value
        End Set
    End Property
#End Region


#Region "Public Function NombreCompleto() As String"
    Public Function NombreCompleto() As String
        Dim nombre As String = ""
        If Not Mutuas Is Nothing Then
            If Not Mutuas.IsNOMBRENull Then
                nombre = Mutuas.NOMBRE
            End If
        End If
        Return nombre
    End Function
#End Region

#Region "Private Sub CargarMutuas(ByVal id As Integer)"
    Private Sub CargarMutuas(ByVal id As Integer)
        Try
            table = adapter.GetMutuaById(id)
            If table.Count > 0 Then
                Mutuas = table(0)
                Muestra()
                RaiseEvent MutuasSeleccionado(id)
            Else
                txt_Nombre.Text = "Mutua no encontrada..."
                'txt_Especialidad.Text = ""
                ID_Mutuas = Nothing
                RaiseEvent MutuasNoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando Mutuas")
        End Try
    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()
        Dim fullName As String = "Nombre es nulo!!"
        If Not Mutuas.IsNOMBRENull Then

            fullName = Mutuas.NOMBRE.Trim()
            If Not Mutuas.IsEliminadoNull Then
                If Mutuas.Eliminado = True Then
                    fullName = "[ELIMINADA] " & fullName
                End If
            End If
        End If
        txt_Codigo.Text = Mutuas.CMUTUA
        txt_Nombre.Text = fullName
        'txt_Especialidad.Text = Mutuas.Importe.ToString("C2")
    End Sub
#End Region

#Region "Public Property ID_Mutuas() As String"
    <System.ComponentModel.Browsable(True)> _
    Public Property ID_Mutuas() As Nullable(Of Integer)
        Get
            If Mutuas Is Nothing Then
                Return Nothing
            Else
                Return Mutuas.CMUTUA
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarMutuas(value)
            Else
                'ID_Mutuas = Nothing
                Mutuas = Nothing
                txt_Codigo.Text = String.Empty
                txt_Nombre.Text = String.Empty
            End If
        End Set
    End Property
#End Region

#Region "Public Property EscogerViaLineaMutua() As String"
    <System.ComponentModel.Browsable(True)> _
    Public Property EscogerViaLineaMutua() As Boolean
        Get
            Return _escogerViaLinea
        End Get
        Set(ByVal value As Boolean)
            _escogerViaLinea = value
        End Set
    End Property
#End Region

#Region "Public Property IDPACIENTE() As String"
    <System.ComponentModel.Browsable(True)> _
    Public Property IDPACIENTE() As Nullable(Of Integer)
        Get
            If _idpaciente.HasValue Then
                Return _idpaciente
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                _idpaciente = value
            End If
        End Set
    End Property
#End Region

    Private Sub pb_SeleccionarMutuas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Dim frm As frmMutuas = New frmMutuas()
        'frm.Modo = Globals.ModoParaFormas.Seleccion
        'If frm.ShowDialog() = DialogResult.OK Then
        '    CargarMutuas(frm.Mutua.IdMutua)
        'End If

        If Not _escogerViaLinea Then
            Me.MUTUASTableAdapter.Fill(Me.CMDataSet.MUTUAS)
            'Dim _name As String = "Listado de mutuas"
            'Dim _listados As form_listados
            Dim _listados As New frmListadoMutua(Globales.ModoParaFormas.Seleccion)

            'If _filtrarMutuaPorPaciente And IDPACIENTE.HasValue Then
            '    '_listados = New form_listados(_name, MUTUASBindingSource, RoleManager.Items.Mutuas, True, "MUTUAS", " WHERE (CMUTUA IN (SELECT REFMUTUA FROM LMUTUAS WHERE (REFPACIENTE=" & IDPACIENTE.Value & ")))", "")
            '    _listados = New form_listados(_name, MUTUASBindingSource, RoleManager.Items.Mutuas, True)
            'Else
            '    _listados = New form_listados(_name, MUTUASBindingSource, RoleManager.Items.Mutuas, True)
            'End If

            _listados.ShowInTaskbar = False
            _listados.ShowDialog()

            If Not _listados.IDMUTUASELECCIONADA Is Nothing Then
                Dim _pcodo As Integer = _listados.IDMUTUASELECCIONADA
                CargarMutuas(_pcodo)
                RaiseEvent MutuasSeleccionadoManualmente(_pcodo)
            End If
        Else
            'Usar el id de la linea ademas de insertar la linea si no existe
            Dim _annadirMutua As form_pac_annadirmutua = New form_pac_annadirmutua("Ficha mutua - Añadir", Enums.Accion.Insertar, IDPACIENTE, CMDataSet)
            _annadirMutua.ShowInTaskbar = False
            _annadirMutua.ShowDialog()
            If _annadirMutua.IdMutua() <> -1 Then

                If Not Globales.Mutua_Existe(_annadirMutua.IdMutua, Me.IDPACIENTE) Then
                    Dim sqlparams(3) As SqlClient.SqlParameter
                    sqlparams(0) = New SqlClient.SqlParameter("@REFMUTUA", _annadirMutua.IdMutua)
                    sqlparams(1) = New SqlClient.SqlParameter("@REFPACIENTE", Me.IDPACIENTE)
                    sqlparams(2) = New SqlClient.SqlParameter("@FECHAALTA", Now.Date)
                    sqlparams(3) = New SqlClient.SqlParameter("@TIPO", _annadirMutua.Tipo)
                    Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, "INSERT LMUTUAS (REFPACIENTE,REFMUTUA,FECHAALTA,TIPO) VALUES (@REFPACIENTE,@REFMUTUA,@FECHAALTA,@TIPO)", sqlparams)
                End If

                If MessageBox.Show("Desea establecer esta mutua como la actual para el paciente ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    CargarMutuas(_annadirMutua.IdMutua())
                    RaiseEvent MutuasSeleccionadoManualmente(_annadirMutua.IdMutua())
                End If
            End If

        End If




    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        'If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0)  Then
        Try
            ' CargarMutuas(Integer.Parse(txt_Codigo.Text))
            ' e.Handled = True
        Catch ex As Exception
        End Try
        'End If
    End Sub


    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        Try
            Dim id As Integer = -1
            Try
                id = Integer.Parse(txt_Codigo.Text)
            Catch ex As Exception
                Return
            End Try
            If _escogerViaLinea Then
                'Dim _annadirMutua As form_pac_annadirmutua = New form_pac_annadirmutua("Ficha mutua - Añadir", Enums.Accion.Insertar, IDPACIENTE, CMDataSet)
                '_annadirMutua.ShowInTaskbar = False
                '_annadirMutua.PreCargaMutua(id)
                '_annadirMutua.ShowDialog()
                'If _annadirMutua.IdMutua() <> -1 Then

                '    If Not Globales.Mutua_Existe(_annadirMutua.IdMutua, Me.IDPACIENTE) Then
                '        Dim sqlparams(3) As SqlClient.SqlParameter
                '        sqlparams(0) = New SqlClient.SqlParameter("@REFMUTUA", _annadirMutua.IdMutua)
                '        sqlparams(1) = New SqlClient.SqlParameter("@REFPACIENTE", Me.IDPACIENTE)
                '        sqlparams(2) = New SqlClient.SqlParameter("@FECHAALTA", Now.Date)
                '        sqlparams(3) = New SqlClient.SqlParameter("@TIPO", _annadirMutua.Tipo)
                '        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, "INSERT LMUTUAS (REFPACIENTE,REFMUTUA,FECHAALTA,TIPO) VALUES (@REFPACIENTE,@REFMUTUA,@FECHAALTA,@TIPO)", sqlparams)
                '    End If
                Try
                    Dim context As New CMLinqDataContext
                    Dim mutua As MUTUA = (From m In context.MUTUAs Where m.CMUTUA = id Select m).SingleOrDefault
                    If mutua Is Nothing Then
                        CargarMutuas(id)
                        Return
                    End If

                    If MessageBox.Show("Desea establecer esta mutua como la actual para el paciente ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

                        Dim lmutua As New LMUTUA
                        lmutua.REFMUTUA = mutua.CMUTUA
                        lmutua.FECHAALTA = Date.Now
                        lmutua.NOTAS = ""
                        lmutua.REFPACIENTE = IDPACIENTE
                        lmutua.TIPO = "M"

                        If Not Globales.Mutua_Existe(lmutua.REFMUTUA, Me.IDPACIENTE) Then
                            context.LMUTUAs.InsertOnSubmit(lmutua)
                            context.SubmitChanges()
                        End If

                        CargarMutuas(id)
                        RaiseEvent MutuasSeleccionadoManualmente(id)
                        'End If
                    End If
                Catch ex As Exception

                End Try


            Else
                CargarMutuas(Integer.Parse(txt_Codigo.Text))
            End If

        Catch ex As Exception
            CargarMutuas(-1)
        End Try
    End Sub

    Private Sub ctrlMutuas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Codigo.Focus()
    End Sub

    Public Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click

        If ID_Mutuas.HasValue Then

            'If EscogerViaLineaMutua And IDPACIENTE.HasValue Then
            '    'Borrar esta mutua de las lineas
            '    Dim sqlparams(1) As SqlClient.SqlParameter
            '    sqlparams(0) = New SqlClient.SqlParameter("@REFMUTUA", ID_Mutuas)
            '    sqlparams(1) = New SqlClient.SqlParameter("@REFPACIENTE", Me.IDPACIENTE)
            '    Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, "DELETE FROM LMUTUAS WHERE (REFPACIENTE=@REFPACIENTE AND REFMUTUA=@REFMUTUA)", sqlparams)
            'End If

            'End Select
            Dim oldValue As Integer = ID_Mutuas.Value

            ID_Mutuas = Nothing
            Mutuas = Nothing
            txt_Codigo.Text = String.Empty
            txt_Nombre.Text = String.Empty
            'txt_Especialidad.Text = ""
            RaiseEvent MutuasEliminada(oldValue)

        End If


    End Sub


End Class