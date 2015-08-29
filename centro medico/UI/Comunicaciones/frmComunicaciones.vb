Imports Janus.Windows.GridEX

Public Class frmComunicaciones
    Public IDPACIENTE As Nullable(Of Integer)

    Private context As CMLinqDataContext

    Private Sub frmComunicaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()

        tstNuevo.Visible = Globales.Usuario.Permisos(RoleManager.Items.Comunicaciones) > RoleManager.TipoPermisos.Lectura
        tstEliminar.Visible = Globales.Usuario.Permisos(RoleManager.Items.Comunicaciones) > RoleManager.TipoPermisos.Lectura
    End Sub

    Public Sub CargarDatos()

        context = New CMLinqDataContext()

        ComunicacionBindingSource.DataSource = Nothing
        Try
            If IDPACIENTE.HasValue Then
                'tstStrip.Enabled = False
                ComunicacionBindingSource.DataSource = From c In context.Comunicacions
                                                       Where c.ID_PacienteDestino = IDPACIENTE.Value _
                                                       Select c Order By c.FechaEnvio Descending
            Else
                ComunicacionBindingSource.DataSource = From c In context.Comunicacions
                                           Select c Order By c.FechaEnvio Descending

            End If

        Catch ex As Exception

        End Try
        'End If
    End Sub

    Private Sub tstNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstNuevo.Click
        Dim frm As New frmComunicaciones_ADD()

        If IDPACIENTE.HasValue Then
            'Dim item As New ListViewItem()
            Dim paciente As PACIENTE = (From p In context.PACIENTEs _
                                       Where p.CPACIENTE = IDPACIENTE.Value).SingleOrDefault()

            'item.Text = paciente.NombreCompleto & " <" & paciente.EMAIL & ">"
            'item.Tag = paciente

            'frm.listDestinos.Items.Add(item)
            frm.UsarDestinatarioUnico = True
            frm.Destinatarios.Add(paciente)

        End If

        If frm.ShowDialog() Then
            CargarDatos()
        End If

    End Sub

    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        'tstModificar.Enabled = GridEX1.SelectedItems.Count > 0
    End Sub

    Private Sub tstEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstEliminar.Click
        If GridEX1.GetCheckedRows.Count = 0 Then
            MessageBox.Show("Nada seleccionado")
            Return
        End If

        If MessageBox.Show("Desea eliminar estos elemento(s)?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each item As GridEXRow In GridEX1.GetCheckedRows
                Dim com As Comunicacion = item.DataRow
                context.Comunicacions.DeleteOnSubmit(com)
                If com.eTipo = Globales.ComunicacionTipo.EMAIL Then
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Comunicaciones, "EMAIL", com.ID_Comunicacion.ToString(), "De: " & com.NombreUsuarioEmisor & " a " & com.NombrePacienteDestino & " Contenido: " & com.Contenido)
                Else
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Comunicaciones, "SMS", com.ID_Comunicacion.ToString(), "De: " & com.NombreUsuarioEmisor & " a " & com.NombrePacienteDestino & " Contenido: " & com.Contenido)
                End If

            Next
            context.SubmitChanges()
            CargarDatos()
        End If
    End Sub

    Private Sub GridEX1_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridEX1.RowCheckStateChanged
        tstEliminar.Enabled = GridEX1.GetCheckedRows.Count > 0
    End Sub

    Private Sub tstPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstPrint.Click
        GridEXPrintDocument1.DefaultPageSettings.Margins.Top = 15
        GridEXPrintDocument1.DefaultPageSettings.Margins.Bottom = 15
        GridEXPrintDocument1.DefaultPageSettings.Margins.Left = 25
        GridEXPrintDocument1.DefaultPageSettings.Margins.Right = 50

        GridEXPrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub tstEnviarRecordatoriosCita_Click(sender As System.Object, e As System.EventArgs) Handles tstEnviarRecordatoriosCita.Click
        Dim frm As New frmComunicaciones_EnviarRecordatoriosCita
        frm.ShowDialog()
        CargarDatos()
    End Sub
End Class