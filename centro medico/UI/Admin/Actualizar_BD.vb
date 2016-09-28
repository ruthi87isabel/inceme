Imports System.IO

Public Class form_Actualizar_BD

    Private Sub Actualizar_BD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
        
    End Sub

    Public Sub Initialize()
        'Obtiene la version almacenada en la BD 
        Dim strSql As String = "Select Valor from VariablesGlobales WHERE Clave = 'DB_Version'"
        Dim res As Object = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(My.Settings.CMConnectionString, CommandType.Text, strSql)

        If Not res Is DBNull.Value Then
            'versión bd actual
            Dim versionActual As Version = New Version(res.ToString())
            LbVersionBD.Text = "Versión Actual de Base de Datos: " & versionActual.ToString()
        End If


        Dim fileDir = My.Computer.FileSystem.GetFiles(Convert.ToString("D:\Work\GitRepo\centro medico\Scripts"), FileIO.SearchOption.SearchTopLevelOnly, "db_?.?.?.?.sql")

        Dim i As Integer = 0
        Dim f As String = ""
        For Each file As String In fileDir
            Dim fileNames As String = My.Computer.FileSystem.GetName(file)
            fileNames = fileNames.Substring(0, fileNames.Length - 4)

            If i = 1 Then
                f = fileNames
                i = 0
            End If
            If fileNames.Contains(res.ToString()) Then i = 1

            Label2.Text = "Ultima Versión Disponible: " & fileNames.Substring(3, fileNames.Length - 3)

            ListScripts.Items.Add(fileNames)
        Next
        ListScripts.SelectedItem = f
        'Dim fullname As String = Convert.ToString("D:\Work\GitRepo\centro medico\Scripts")
        'ListScripts.DataSource = New DirectoryInfo(fullname).GetFiles()
    End Sub
End Class