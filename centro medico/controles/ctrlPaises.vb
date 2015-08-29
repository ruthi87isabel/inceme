Public Class ctrlPaises

    Public PAISES As CMDataSet.PAISESRow = Nothing
    Private table As CMDataSet.PAISESDataTable = New CMDataSet.PAISESDataTable()
    Private adapter As CMDataSetTableAdapters.PAISESTableAdapter = New CMDataSetTableAdapters.PAISESTableAdapter()

    Public Event PAISESeleccionado(ByVal IdPAISES As Integer, ByVal IsReturnPressed As Boolean)
    Public Event PAISESEliminado(ByVal IdPAISESAnterior As Integer)
    Public Event PAISESNoEncontrado()

#Region "Public Function NombreCompleto() As String"
    Public Function NombreCompleto() As String
        Dim nombre As String = "Seleccione PAISES"
        If Not PAISES Is Nothing Then
            If Not PAISES.IsNOMBRENull Then
                nombre = PAISES.NOMBRE
            End If
        End If
        Return nombre
    End Function
#End Region

#Region "Private Sub CargarPAISES(ByVal id As Integer)"
    Private Sub CargarPAISES(ByVal id As Integer, ByVal IsReturnPressed As Boolean)
        Try
            table = adapter.GetPaisById(id)
            If table.Count > 0 Then
                PAISES = table(0)
                Muestra()
                RaiseEvent PAISESeleccionado(id, IsReturnPressed)
            Else
                txt_Nombre.Text = "País no encontrado..."
                RaiseEvent PAISESNoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando país")
        End Try
    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()

        Dim fullName As String = "Nombre es nulo!!"

        If Not PAISES.IsNOMBRENull() Then
            fullName = PAISES.NOMBRE.Trim()
        End If

        txt_Codigo.Text = PAISES.CODIGO
        txt_Nombre.Text = fullName
    End Sub
#End Region

    <System.ComponentModel.Browsable(True)> _
   Public Property ID_PAISES() As Nullable(Of Integer)
        Get
            If PAISES Is Nothing Then
                Return Nothing
            Else
                Return PAISES.CODIGO
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarPAISES(value, False)
            End If
        End Set
    End Property

    Private Sub pb_SeleccionarPAISES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Dim frm As form_PAISESs = New form_PAISESs()
        'If frm.ShowDialog() = DialogResult.OK Then
        '    CargarPAISES(frm.PAISES.CPAISES, False)
        'End If
        Me.PAISESTableAdapter.Fill(Me.CMDataSet.PAISES)
        Dim _name As String = "Listado de empresas"
        Dim _listados As form_listados = New form_listados(_name, PAISESBindingSource, RoleManager.Items.Paises, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            CargarPAISES(_listados.Selected(), False)
        End If
    End Sub

    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click

        If Not PAISES Is Nothing Then
            RaiseEvent PAISESEliminado(Me.ID_PAISES)
        End If

        Me.ID_PAISES = Nothing
        Me.PAISES = Nothing
        Me.txt_Codigo.Text = String.Empty
        Me.txt_Nombre.Text = "Seleccione país"
    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            Try
                CargarPAISES(Integer.Parse(txt_Codigo.Text), True)
            Catch ex As Exception
                txt_Nombre.Text = "País no encontrado..."
                RaiseEvent PAISESNoEncontrado()
            End Try
        End If
    End Sub

    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        Try
            CargarPAISES(Integer.Parse(txt_Codigo.Text), False)
        Catch ex As Exception
            txt_Nombre.Text = "País no encontrado..."
            RaiseEvent PAISESNoEncontrado()
        End Try
    End Sub

End Class

