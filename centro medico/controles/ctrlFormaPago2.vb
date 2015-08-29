Public Class ctrlFormaPago2

    Public FORMASPAGO As FORMASPAGO = Nothing
    Private context As New CMLinqDataContext

    Public Event FORMASPAGOeleccionado(ByVal IdFORMASPAGO As String, ByVal IsReturnPressed As Boolean)
    Public Event FORMASPAGOEliminado(ByVal IdFORMASPAGOAnterior As String)
    Public Event FORMASPAGONoEncontrado()

#Region "Public Function NombreCompleto() As String"
    Public Function NombreCompleto() As String
        Dim nombre As String = "Seleccione FORMASPAGO"
        If Not FORMASPAGO Is Nothing Then
            nombre = FORMASPAGO.DESCRIPCION
        End If
        Return nombre
    End Function
#End Region

#Region "Private Sub CargarFORMASPAGO(ByVal id As String)"
    Private Sub CargarFORMASPAGO(ByVal id As String, ByVal IsReturnPressed As Boolean)
        Try
            FORMASPAGO = (From f In context.FORMASPAGOs Where f.CODIGO = id Select f).SingleOrDefault

            If Not FORMASPAGO Is Nothing Then
                Muestra()
                RaiseEvent FORMASPAGOeleccionado(id, IsReturnPressed)
            Else
                txt_Nombre.Text = "FORMASPAGO no encontrada..."
                RaiseEvent FORMASPAGONoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando FORMASPAGO")
        End Try
    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()

        Dim fullName As String = "Nombre es nulo!!"

        fullName = FORMASPAGO.DESCRIPCION.Trim()

        txt_Codigo.Text = FORMASPAGO.CODIGO
        txt_Nombre.Text = fullName

    End Sub
#End Region

    <System.ComponentModel.Browsable(True)> _
   Public Property ID_FORMASPAGO() As String
        Get
            If FORMASPAGO Is Nothing Then
                Return Nothing
            Else
                Return FORMASPAGO.CODIGO
            End If
        End Get
        Set(ByVal value As String)
            If Not value Is Nothing Then
                If value.Length > 0 Then
                    CargarFORMASPAGO(value, False)
                End If
            Else
                FORMASPAGO = Nothing
            End If
        End Set
    End Property

    Private Sub pb_SeleccionarFORMASPAGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
    
        Dim frm As New frmFormasDePago
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = DialogResult.OK Then
            CargarFORMASPAGO(frm.FormaPago.CODIGO, False)
        End If
    End Sub

    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click

        Dim oldValue As String = Me.ID_FORMASPAGO

        Me.ID_FORMASPAGO = Nothing
        Me.FORMASPAGO = Nothing
        Me.txt_Codigo.Text = String.Empty
        Me.txt_Nombre.Text = "Seleccione forma de pago"

        If Not oldValue Is Nothing Then
            RaiseEvent FORMASPAGOEliminado(oldValue)
        End If
    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            Try
                CargarFORMASPAGO(txt_Codigo.Text, True)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        CargarFORMASPAGO(txt_Codigo.Text, False)
    End Sub

End Class