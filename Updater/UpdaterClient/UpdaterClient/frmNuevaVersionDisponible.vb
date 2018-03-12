Imports System.Deployment.Application
Public Class frmNuevaVersionDisponible

    Public CurrentVersion As Version = Nothing
    Public Info As UpdatesServer.UpdateInfo

    Private Sub frmNuevaVersionDisponible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Actual.Text = CurrentVersion.ToString
        lbl_Disponible.Text = Info.PublishedVersion
        lbl_Tamanno.Text = UpdaterCommonLibrary.Utils.FormatFileSize(Info.SizeInBytes)

        For Each file As UpdaterClient.UpdatesServer.FileItem In Info.Files
            rt_Log.AppendText(file.FileName & vbCrLf)
        Next

    End Sub

    Private Sub btn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Actualizar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class