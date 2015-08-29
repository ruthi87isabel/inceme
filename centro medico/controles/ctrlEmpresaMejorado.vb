Public Class ctrlEMPRESAMejorado
    Public EMPRESA As EMPRESA = Nothing

    Public Event EMPRESASeleccionada(ByVal IdEMPRESA As Integer)
    Public Event EMPRESAEliminada()
    Public Event EMPRESANoEncontrada()

    Public Property ID_EMPRESA() As Nullable(Of Integer)
        Get
            If EMPRESA Is Nothing Then
                Return Nothing
            Else
                Return Me.EMPRESA.CEMPRESA
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarEMPRESA(value)
            End If
        End Set
    End Property

    Private Sub Muestra()
        If EMPRESA Is Nothing Then
            txt_Codigo.Text = ""
            txt_Nombre.Text = ""
            Return
        Else
            txt_Codigo.Text = EMPRESA.CEMPRESA
        End If
        If EMPRESA.NOMBRE Is Nothing Then
            txt_Nombre.Text = ""
        Else
            txt_Nombre.Text = EMPRESA.NOMBRE
            If EMPRESA.Eliminado.HasValue Then
                If EMPRESA.Eliminado = True Then
                    txt_Nombre.Text = "[ELIMINADA] " & EMPRESA.NOMBRE
                End If
            End If
        End If

       
    End Sub

    Private Sub CargarEMPRESA(value As Nullable(Of Integer))
        Try
            Dim context As New CMLinqDataContext()
            Me.EMPRESA = (From m In context.EMPRESAs Where m.CEMPRESA = value Select m).FirstOrDefault()
            If Not Me.EMPRESA Is Nothing Then
                Muestra()
                RaiseEvent EMPRESASeleccionada(EMPRESA.CEMPRESA)
            Else
                txt_Nombre.Text = "EMPRESA no encontrada..."
                RaiseEvent EMPRESANoEncontrada()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando EMPRESA")
        End Try
    End Sub

    Private Sub txt_Codigo_Leave(sender As Object, e As EventArgs) Handles txt_Codigo.Leave
        Try
            Dim cEMPRESA As Integer = Integer.Parse(txt_Codigo.Text)
            CargarEMPRESA(cEMPRESA)
        Catch ex As Exception
            Me.EMPRESA = Nothing
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

            Dim frm As New frmEmpresa()
            frm.Modo = Globales.ModoParaFormas.Seleccion
            frm.ShowInTaskbar = False
            If frm.ShowDialog() = DialogResult.OK Then
                CargarEMPRESA(frm.Empresa.CEMPRESA)
            End If
        Catch ex As Exception
            MessageBox.Show("no se pudo cargar la EMPRESA")
        End Try
    End Sub

    Private Sub btn_Deseleccionar_Click(sender As Object, e As EventArgs) Handles btn_Deseleccionar.Click
        Me.EMPRESA = Nothing
        Muestra()
        RaiseEvent EMPRESAEliminada()
    End Sub
End Class
