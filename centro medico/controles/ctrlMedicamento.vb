Public Class ctrlMedicamento
    Public Medicamento As MEDICAMENTO = Nothing


    Public Event MEDICAMENTOSeleccionado(ByVal IdMedicamento As Integer, ByVal oldMedicamento As Nullable(Of Integer), ByVal IsReturnPressed As Boolean)
    Public Event MEDICAMENTOEliminado(ByVal IdMedicamentoAnterior As Nullable(Of Integer))
    Public Event MEDICAMENTONoEncontrado()

    Public Property ID_Medicamento() As Nullable(Of Integer)
        Get
            If Medicamento Is Nothing Then
                Return Nothing
            Else
                Return Medicamento.CMEDICAMENTO
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarMedicamento(value)
            End If
        End Set
    End Property

 

    Private Sub CargarMedicamento(value As Nullable(Of Integer))
        Try
            Dim context As New CMLinqDataContext()
            Medicamento = (From m In context.MEDICAMENTOs Where m.CMEDICAMENTO = value.ToString() Select m).FirstOrDefault()
            If Not Medicamento Is Nothing Then
                Muestra()
            Else
                txt_Nombre.Text = "Medicamento no encontrado..."
                RaiseEvent MEDICAMENTONoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando medicamento")
        End Try
    End Sub

    Private Sub Muestra()

        txt_Codigo.Text = Medicamento.CMEDICAMENTO
        txt_Nombre.Text = Medicamento.DESCRIPCION
        
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click

        Dim frm As New frmMedicamentos(True)
        frm.StartPosition = FormStartPosition.CenterScreen

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.ID_Medicamento = Integer.Parse(frm.idMedicamentos)
            RaiseEvent MEDICAMENTOSeleccionado(Me.ID_Medicamento, Nothing, False)
        End If

    End Sub

    Private Sub btn_Deseleccionar_Click(sender As Object, e As EventArgs) Handles btn_Deseleccionar.Click

        Dim oldMedicamento As Nullable(Of Integer) = Nothing
        If Me.ID_Medicamento.HasValue Then
            oldMedicamento = Me.ID_Medicamento
        End If

        Me.ID_Medicamento = Nothing
        Me.Medicamento = Nothing
        Me.txt_Codigo.Text = String.Empty
        Me.txt_Nombre.Text = "Seleccione medicamento"

        RaiseEvent MEDICAMENTOEliminado(oldMedicamento)
    End Sub

    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        Try
            Dim oldMedicamento As Nullable(Of Integer) = Me.ID_Medicamento
            Dim cmedicamento As Integer = Integer.Parse(txt_Codigo.Text)
            CargarMedicamento(cmedicamento)
            If Not Me.Medicamento Is Nothing Then
                If oldMedicamento = Medicamento.CMEDICAMENTO Then
                    oldMedicamento = Nothing
                End If
                RaiseEvent MEDICAMENTOSeleccionado(cmedicamento, oldMedicamento, False)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            Try
                Dim oldMedicamento As Nullable(Of Integer) = Me.ID_Medicamento
                Dim cmedicamento As Integer = Integer.Parse(txt_Codigo.Text)
                CargarMedicamento(cmedicamento)
                If Not Me.ID_Medicamento Is Nothing Then
                    If oldMedicamento = Medicamento.CMEDICAMENTO Then
                        oldMedicamento = Nothing
                    End If
                    RaiseEvent MEDICAMENTOSeleccionado(cmedicamento, oldMedicamento, False)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class
