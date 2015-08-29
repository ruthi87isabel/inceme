Public Class ctrlAlarma

    Public ALARMA As ALARMA = Nothing


    Public Event alarmaSeleccionada(ByVal Idalarma As Integer)
    Public Event alarmaEliminada()
    Public Event alarmaNoEncontrada()

    Public Property ID_ALARMA() As Nullable(Of Integer)
        Get
            If Alarma Is Nothing Then
                Return Nothing
            Else
                Return Alarma.CALARMA
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                Cargaralarma(value)
            End If
        End Set
    End Property

    Private Sub btn_Deseleccionar_Click(sender As Object, e As EventArgs) Handles btn_Deseleccionar.Click
        Me.ALARMA = Nothing
        Muestra()
        RaiseEvent alarmaEliminada()
    End Sub


    Private Sub CargarAlarma(value As Nullable(Of Integer))
        Try
            Dim context As New CMLinqDataContext()
            Me.ALARMA = (From m In context.ALARMAs Where m.CALARMA = value Select m).FirstOrDefault()
            If Not Me.ALARMA Is Nothing Then
                Muestra()
                RaiseEvent alarmaSeleccionada(ALARMA.CALARMA)
            Else
                txt_Nombre.Text = "Alarma no encontrada..."
                RaiseEvent alarmaNoEncontrada()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando alarma")
        End Try
    End Sub


    Private Sub Muestra()
        If ALARMA Is Nothing Then
            txt_Codigo.Text = ""
            txt_Nombre.Text = ""
            Return
        Else
            txt_Codigo.Text = ALARMA.CALARMA
        End If
        If ALARMA.ALARMA Is Nothing Then
            txt_Nombre.Text = ""
        Else
            txt_Nombre.Text = ALARMA.ALARMA

        End If


    End Sub

    Private Sub txt_Codigo_Leave(sender As Object, e As EventArgs) Handles txt_Codigo.Leave
        Try
            Dim calarma As Integer = Integer.Parse(txt_Codigo.Text)
            CargarAlarma(calarma)
        Catch ex As Exception
            ALARMA = Nothing
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

            Dim frm As New frmAlarmas()
            frm.ShowInTaskbar = False
            If frm.ShowDialog() = DialogResult.OK Then
                CargarAlarma(frm.IDALARMA)
            End If
        Catch ex As Exception
            MessageBox.Show("no se pudo cargar la alarma")
        End Try
    End Sub
End Class
