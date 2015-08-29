Imports System.Deployment.Application
Imports System.ComponentModel

Public Class frmActualizarApp

    Private Shared n As Integer = 0

    Dim WithEvents deploy As ApplicationDeployment
    Delegate Function ShowDelegate() As DialogResult


    Private Sub frmActualizarApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Chequear si hay versiones nuevas de la app
        deploy = ApplicationDeployment.CurrentDeployment
        txt_Log.Text = "Verificando actualizaciones..." & ControlChars.CrLf
        deploy.CheckForUpdateAsync()
    End Sub

#Region "Private Sub CheckForUpdate(ByVal sender As Object, ByVal e As DeploymentProgressChangedEventArgs) Handles deploy.CheckForUpdateProgressChanged"
    Private Sub CheckForUpdate(ByVal sender As Object, ByVal e As DeploymentProgressChangedEventArgs) Handles deploy.CheckForUpdateProgressChanged
        lbl_Accion.Text = "Verificando (" & (e.BytesCompleted / 1024).ToString("N2") & " KB de " & (e.BytesTotal / 1024).ToString("N2") & " KB)"
        pbar.Value = e.ProgressPercentage()
    End Sub
#End Region

#Region "Private Sub CheckForUpdateCompleted(ByVal sender As Object, ByVal e As CheckForUpdateCompletedEventArgs) Handles deploy.CheckForUpdateCompleted"
    Private Sub CheckForUpdateCompleted(ByVal sender As Object, ByVal e As CheckForUpdateCompletedEventArgs) Handles deploy.CheckForUpdateCompleted
        If (e.Error IsNot Nothing) Then
            txt_Log.Text = txt_Log.Text & "ERROR: No se pudo obtener información de la nueva versión, Razón: " + ControlChars.Lf + e.Error.Message + ControlChars.Lf + "Reporte esto a su administrador."
            MessageBox.Show(("ERROR: No se pudo obtener información de la nueva versión, Razón: " + ControlChars.Lf + e.Error.Message + ControlChars.Lf + "Reporte esto a su administrador."))
            Return
        Else
            lbl_Accion.Text = "Completado. "
            If Not e.Cancelled Then
                If e.UpdateAvailable Then
                    If e.IsUpdateRequired Then
                        'Update mandatorio
                        MessageBox.Show("Update mandatorio")
                    Else
                        'Update normal
                        Dim frm As frmNuevaVersionDisponible = New frmNuevaVersionDisponible()
                        frm.Update = e
                        'MessageBox.Show(n)
                        ' n = n + 1
                        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            pbar.Value = 0
                            deploy = ApplicationDeployment.CurrentDeployment
                            deploy.UpdateAsync()
                        End If
                    End If

                Else
                    txt_Log.Text = txt_Log.Text & "No hay actualizaciones disponibles..." & ControlChars.CrLf
                End If
            End If
        End If
    End Sub
#End Region

#Region "Private Sub UpdateProgressChanged(ByVal sender As Object, ByVal e As DeploymentProgressChangedEventArgs) Handles deploy.UpdateProgressChanged"
    Private Sub UpdateProgressChanged(ByVal sender As Object, ByVal e As DeploymentProgressChangedEventArgs) Handles deploy.UpdateProgressChanged
        lbl_Accion.Text = "Verificando (" & (e.BytesCompleted / 1024).ToString("N2") & " KB de " & (e.BytesTotal / 1024).ToString("N2") & " KB)"
        pbar.Value = e.ProgressPercentage
    End Sub
#End Region

#Region "Private Sub UpdateCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles deploy.UpdateCompleted"
    Private Sub UpdateCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles deploy.UpdateCompleted
        If (e.Cancelled) Then
            MessageBox.Show("La actualizacion ha sido cancelada.")
            Exit Sub
        Else
            If (e.Error IsNot Nothing) Then
                MessageBox.Show("ERROR: No se pudo instalar nueva versión, Razón: " + ControlChars.Lf + e.Error.Message + ControlChars.Lf + "Favor de reportar al administrador.")
                Exit Sub
            End If
        End If

        'Dim res As IAsyncResult = Me.BeginInvoke(New ShowDelegate(AddressOf frm.ShowDialog))
        'While Not res.IsCompleted
        '    'Esperar por la ventana que se cierre
        'End While

        'If frm.DialogResult = Windows.Forms.DialogResult.OK Then

        Dim dr As DialogResult = MessageBox.Show("La aplicación ha sido actualizada, Reiniciar? (Los cambios no serán aplicados hasta que no se reinicie la aplicación)", "Reiniciar", MessageBoxButtons.OKCancel)
        If (dr = System.Windows.Forms.DialogResult.OK) Then
            Application.Restart()
        End If
    End Sub
#End Region


    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        deploy.CheckForUpdateAsyncCancel()
        deploy.UpdateAsyncCancel()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class