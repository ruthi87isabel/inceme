Public Class ctrlMedicoLinea

    Public Event MEDICOSeleccionado(ByVal IdMedico As Integer, ByVal IsReturnPressed As Boolean)
    Public Event MedicoNoEncontrado()

    Public Id As Integer

    Private Sub btn_Deseleccionar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Deseleccionar.Click
        Me.txt_Codigo.Text = String.Empty
        Me.txt_Nombre.Text = "Seleccione medico"
        Me.txt_Especialidad.Text = String.Empty
        Me.Id = 0
    End Sub

    Private Sub btn_Buscar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Buscar.Click
        Dim frm As form_medicos = New form_medicos()
        If frm.ShowDialog() = DialogResult.OK Then
            CargarMedico(frm.MEDICO.CMEDICO, False)
        End If
    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            Try
                Dim id As Integer = Integer.Parse(txt_Codigo.Text)
                CargarMedico(id, True)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        Try
            Dim id As Integer = Integer.Parse(txt_Codigo.Text)
            CargarMedico(id, True)
        Catch ex As Exception
        End Try
    End Sub

#Region "Private Sub CargarMedico(ByVal id As Integer)"
    Private Sub CargarMedico(ByVal id As Integer, ByVal IsReturnPressed As Boolean)
        Try
            Dim content As New CMLinqDataContext()
            Dim medico As MEDICO = content.MEDICOs.FirstOrDefault(Function(m) m.CMEDICO = id)

            If Not medico Is Nothing Then
                ActualizaControl(medico)
                Me.Id = medico.CMEDICO
                RaiseEvent MEDICOSeleccionado(id, IsReturnPressed)
            Else
                txt_Nombre.Text = "Medico no encontrado..."
                txt_Especialidad.Text = String.Empty
                RaiseEvent MedicoNoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando Medico")
        End Try
    End Sub
#End Region


#Region " Private Sub Muestra()"

    Private Sub ActualizaControl(medico As MEDICO)
        Dim fullName As String = IIf(String.IsNullOrEmpty(medico.NOMBRE), "Nombre es nulo!!", medico.NOMBRE)

        txt_Codigo.Text = medico.CMEDICO
        txt_Nombre.Text = String.Format("{0} {1} {2}", fullName, medico.APELLIDO1, medico.APELLIDO2)

        txt_Especialidad.Text = medico.ESPECIALIDAD
    End Sub

#End Region

End Class
