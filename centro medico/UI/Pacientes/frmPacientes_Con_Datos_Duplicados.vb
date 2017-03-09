Imports Janus.Windows.GridEX

Public Class frmPacientes_Con_Datos_Duplicados
    Public IDPaciente As Nullable(Of Integer)
    Public context As New CMLinqDataContext()
    Dim OnLoadDuplic As Boolean = False

    Private Sub frmPacientesDuplicados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OnLoadDuplic = True
        txtNombre.Text = DameNombreXid()
        TbCodigo.Text = If(IDPaciente Is Nothing, "", IDPaciente.ToString)
        'GridEX1.rea()
        filtrar()
        OnLoadDuplic = False
    End Sub

    Private Sub filtrar()
        Dim cod As String = TbCodigo.Text
        Dim listaduplicados As List(Of Descartar_Pacientes_Duplicado) = (From p In context.Descartar_Pacientes_Duplicados.ToList _
                                   Where (OnLoadDuplic AndAlso (p.Id_Paciente_Origen = cod Or p.Id_Paciente_Descartado = cod)) _
                                   Or ((Not OnLoadDuplic) AndAlso (
                                        (TbCodigo.Text = "" Or (TbCodigo.Text <> "" AndAlso (p.Id_Paciente_Origen = cod Or p.Id_Paciente_Descartado = cod))) _
                                    And (txtNombre.Text = "" Or (txtNombre.Text <> "" AndAlso ((p.Nombre_Paciente_Origen.Trim.ToLower.Contains(txtNombre.Text.Trim.ToLower)) _
                                                                                            Or (p.Nombre_Paciente_Descartado.Trim.ToLower.Contains(txtNombre.Text.Trim.ToLower))))) _
                                          And ((Not dtp_fi.Checked) Or (dtp_fi.Checked AndAlso p.Fecha_Descarte > dtp_fi.Value.Date)) _
                                          And ((Not dtp_ff.Checked) Or (dtp_ff.Checked AndAlso p.Fecha_Descarte < dtp_ff.Value.Date)))) _
                                   Select p).ToList()

        DuplicadosBindingSource1.DataSource = listaduplicados
    End Sub

    Private Sub bt_filtrar_Click(sender As Object, e As EventArgs) Handles bt_filtrar.Click
        filtrar()
    End Sub

    Private Function DameNombreXid() As String
        Dim NombreCompleto As String = ""
        If Not IDPaciente Is Nothing Then
            Dim Paciente As PACIENTE = (From p In context.PACIENTEs _
                                               Where p.CPACIENTE = IDPaciente And (p.Eliminado Is Nothing Or p.Eliminado = False) _
                                               Select p).SingleOrDefault()
            NombreCompleto = (Paciente.NOMBRE & " " & Paciente.APELLIDO1 & " " & Paciente.APELLIDO2).Trim()
        End If
        Return NombreCompleto
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If GridEX1.GetCheckedRows().Count > 0 Then
            If MessageBox.Show("Esta seguro que desea eliminar este/estos elemento(s)?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                For Each row As GridEXRow In GridEX1.GetCheckedRows()
                    Dim relacion As Descartar_Pacientes_Duplicado
                    Try

                        Dim IdO As Integer = row.DataRow.Id_Paciente_Origen
                        Dim IdD As Integer = row.DataRow.Id_Paciente_Descartado

                        relacion = (From p In context.Descartar_Pacientes_Duplicados _
                                    Where p.Id_Paciente_Origen = IdO And p.Id_Paciente_Descartado = IdD _
                                    Select p).SingleOrDefault()

                        context.Descartar_Pacientes_Duplicados.DeleteOnSubmit(relacion)
                        context.SubmitChanges()

                    Catch ex As Exception
                        MessageBox.Show("No pudo eliminarser la relación")
                    End Try
                Next
            End If
            filtrar()
        End If
    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub
End Class