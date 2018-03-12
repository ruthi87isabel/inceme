Imports System.Configuration
Imports System.IO

Public Class frmUpdaterConfig

    Dim UpdateType As frmUpdater.UpdateTypeEnum = UpdaterClient.frmUpdater.UpdateTypeEnum.Internet
    'Dim InternetUpdateServer As String
    'Dim LocalUpdateFolder As String

    Dim AppPath As String
    Dim config As System.Configuration.Configuration

    Public Sub New(ByVal AppPath As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.AppPath = AppPath
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label2.Click

    End Sub
    Private Sub txt_UrlServidor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_UrlServidor.TextChanged, txt_FolderPath.TextChanged

    End Sub

    Private Sub frmUpdaterConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub LoadSettings()

        config = ConfigurationManager.OpenExeConfiguration(AppPath & "\UpdaterClient.exe")
        'MessageBox.Show(AppPath)
        UpdateType = [Enum].Parse(GetType(frmUpdater.UpdateTypeEnum), config.AppSettings.Settings("UpdateType").Value)
        txt_UrlServidor.Text = config.AppSettings.Settings("InternetUpdateServer").Value

        txt_FolderPath.Text = New DirectoryInfo(config.AppSettings.Settings("LocalUpdateFolder").Value).FullName

        Select Case UpdateType
            Case frmUpdater.UpdateTypeEnum.Internet
                rb_Internet.Checked = True
                pnl_Internet.Visible = True
                pnl_Local.Visible = False

            Case frmUpdater.UpdateTypeEnum.Local
                rb_Local.Checked = True
                pnl_Internet.Visible = False
                pnl_Local.Visible = True

        End Select
    End Sub

    Private Sub rb_Internet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Local.CheckedChanged, rb_Internet.CheckedChanged
        If rb_Internet.Checked Then
            UpdateType = frmUpdater.UpdateTypeEnum.Internet
        Else
            UpdateType = frmUpdater.UpdateTypeEnum.Local
        End If
        Select Case UpdateType
            Case frmUpdater.UpdateTypeEnum.Internet
                rb_Internet.Checked = True
                pnl_Internet.Visible = True
                pnl_Local.Visible = False

            Case frmUpdater.UpdateTypeEnum.Local
                rb_Local.Checked = True
                pnl_Internet.Visible = False
                pnl_Local.Visible = True
        End Select
    End Sub

    
    Private Sub bnt_BrowseFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnt_BrowseFolder.Click
        FolderBrowserDialog1.SelectedPath = txt_FolderPath.Text
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_FolderPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        config.AppSettings.Settings("UpdateType").Value = UpdateType.ToString()
        config.AppSettings.Settings("InternetUpdateServer").Value = txt_UrlServidor.Text
        config.AppSettings.Settings("LocalUpdateFolder").Value = txt_FolderPath.Text
        config.Save(ConfigurationSaveMode.Modified)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class