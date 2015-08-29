Imports System.Deployment.Application
Public Class frmNuevaVersionDisponible

    Public Update As CheckForUpdateCompletedEventArgs

    Private Sub frmNuevaVersionDisponible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Actual.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        lbl_Disponible.Text = Update.AvailableVersion.ToString()
        lbl_Tamanno.Text = (Update.UpdateSizeBytes / 1048576).ToString("N2") & " MB"
    End Sub

    Private Sub btn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Actualizar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


End Class