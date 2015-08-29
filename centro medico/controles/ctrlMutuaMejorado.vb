Public Class ctrlMutuaMejorado

    Public MUTUA As MUTUA = Nothing

    Public Event MUTUASeleccionada(ByVal IdMUTUA As Integer)
    Public Event MUTUAEliminada()
    Public Event MUTUANoEncontrada()

    Public Property ID_MUTUA() As Nullable(Of Integer)
        Get
            If MUTUA Is Nothing Then
                Return Nothing
            Else
                Return MUTUA.CMUTUA
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarMUTUA(value)
            End If
        End Set
    End Property

    Private Sub Muestra()
        If MUTUA Is Nothing Then
            txt_Codigo.Text = ""
            txt_Nombre.Text = ""
            Return
        Else
            txt_Codigo.Text = MUTUA.CMUTUA
        End If
        If MUTUA.NOMBRE Is Nothing Then
            txt_Nombre.Text = ""
        Else

            If MUTUA.Eliminado.HasValue Then
                If MUTUA.Eliminado = True Then
                    txt_Nombre.Text = "[ELIMINADA] " & MUTUA.NOMBRE
                    Return
                End If
            End If
            txt_Nombre.Text = MUTUA.NOMBRE


        End If
    End Sub

    Private Sub CargarMUTUA(value As Nullable(Of Integer), Optional ByVal cambiada As Boolean = False)
        Try
            Dim context As New CMLinqDataContext()
            Me.MUTUA = (From m In context.MUTUAs Where m.CMUTUA = value Select m).FirstOrDefault()
            If Not Me.MUTUA Is Nothing Then
                Muestra()
                If cambiada Then RaiseEvent MUTUASeleccionada(MUTUA.CMUTUA)
            Else
                txt_Nombre.Text = "MUTUA no encontrada..."
                RaiseEvent MUTUANoEncontrada()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando mutua")
        End Try
    End Sub

    Private Sub txt_Codigo_Leave(sender As Object, e As EventArgs) Handles txt_Codigo.Leave
        Try
            Dim cMUTUA As Integer = Integer.Parse(txt_Codigo.Text)
            CargarMUTUA(cMUTUA, True)
        Catch ex As Exception
            MUTUA = Nothing
            Muestra()
        End Try
    End Sub

    Private Sub txt_Codigo_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            txt_Codigo_Leave(Nothing, Nothing)
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Try
            Dim context As New CMLinqDataContext()

            Dim frm As New frmListadoMutua(Globales.ModoParaFormas.Seleccion)
            frm.ShowInTaskbar = False
            If frm.ShowDialog() = DialogResult.OK Then
                CargarMUTUA(frm.IDMUTUASELECCIONADA, True)
            End If
        Catch ex As Exception
            MessageBox.Show("no se pudo cargar la MUTUA")
        End Try
    End Sub

    Public Sub btn_Deseleccionar_Click(sender As Object, e As EventArgs) Handles btn_Deseleccionar.Click
        Me.MUTUA = Nothing
        Muestra()
        RaiseEvent MUTUAEliminada()
    End Sub
End Class
