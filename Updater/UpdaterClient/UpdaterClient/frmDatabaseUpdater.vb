Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports UpdaterCommonLibrary
Imports System.IO

Public Class frmDatabaseUpdater

    Public AppName As String
    Public Scripts As UpdaterCommonLibrary.FileItemSet
    Public NewScripts As List(Of UpdaterCommonLibrary.FileItem) = New List(Of UpdaterCommonLibrary.FileItem)


    Public ConnString As String
    Dim versionStr As String

    Private Delegate Sub SetProgresbarDelegate(ByVal value As Integer)
    Private Delegate Sub ChangeTextValueDelegate(ByRef control As Control, ByVal text As String)

    Public Sub New(ByVal _appName As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        AppName = _appName

    End Sub

    Private Sub frmDatabaseUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each file As UpdaterCommonLibrary.FileItem In Scripts.Items.Values
            lst_Scripts.Items.Add(file.FileName)
        Next
        ConnectToDB()
    End Sub

#Region "Private Sub ShowLog(ByVal msg As String)"
    Private Sub ShowLog(ByVal msg As String)
        'lbl_Msg.BeginInvoke(New ChangeTextValueDelegate(AddressOf ChangeTextValue), New Object() {lbl_Msg, msg})
        rt_Log.BeginInvoke(New ChangeTextValueDelegate(AddressOf AppendTextValue), New Object() {rt_Log, msg & vbCrLf})
    End Sub

    Private Sub AppendTextValue(ByRef control As Control, ByVal text As String)
        control.Text = control.Text + text
    End Sub
#End Region

    Private Sub ConnectToDB()
        Try
            ShowLog("Buscando connectionString...")
            Dim conStrFile As String = IO.Path.GetTempPath() & "\" & AppName & ".conn"

            If Not File.Exists(conStrFile) Then
                ShowLog("ConnectionString no encontrado, actualizacion del la BD imposible..")
                Return
            End If

            Dim streamReader As StreamReader = File.OpenText(conStrFile)
            ConnString = streamReader.ReadLine()
            streamReader.Close()
            ShowLog("Verificando conexión con la BD")
            ShowLog("-------------------------------")
            versionStr = GetDBVersion()
            If versionStr = "" Then
                Return
            End If

            ShowLog("Version de la BD:" & versionStr)
            FindVersionSuperiors()

        Catch ex As Exception
            ShowLog(ex.Message)
            btn_Execute.Enabled = False
        End Try
    End Sub

#Region "Private Function GetDBVersion() As String"
    Private Function GetDBVersion() As String

        Dim query As String = "SELECT Valor FROM VariablesGlobales WHERE Clave='DB_Version'"
        If Not ConnString = "" Then
            Try
                versionStr = SqlHelper.ExecuteScalar(ConnString, CommandType.Text, query)
                If versionStr Is Nothing Then
                    ShowLog("No encontrada clave 'DB_Version' en la base de datos, asignado 0.0.0.0 ")
                    Return "0.0.0.0"
                Else
                    'ShowLog("Version de la BD:" & versionStr)
                    Return versionStr
                End If
            Catch ex As Exception
                ShowLog("Error accediendo a la BD")
                ShowLog(ex.Message)
                Return ""
            End Try
        End If
    End Function
#End Region

#Region "Private Sub FindVersionSuperiors()"
    Private Sub FindVersionSuperiors()
        'Este metodo recorre los scripts y extrae aquellos que son de version mayor

        ShowLog("Ficheros con versiones superiores")
        Dim CurrentVersion As Version = New Version(versionStr)
        For Each file As FileItem In Scripts.Items.Values
            If IO.Path.GetFileName(file.FileName).StartsWith("db_") Then
                Dim fileVersionStr As String = (file.FileName.Substring(file.FileName.IndexOf("_") + 1))
                fileVersionStr = fileVersionStr.Remove(fileVersionStr.IndexOf(".sql"), 4)
                Dim fileVersion = New Version(fileVersionStr)
                If fileVersion > CurrentVersion Then
                    NewScripts.Add(file)
                    ShowLog(file.FileName)
                End If
            End If
        Next
        If NewScripts.Count = 0 Then
            ShowLog("No encontrados, la BD se encuentra actualizada...")
            btn_Execute.Text = "Cerrar"
        End If
    End Sub
#End Region

    Private Sub btn_Execute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Execute.Click

        If btn_Execute.Text = "Cerrar" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            ShowLog("")
            ShowLog("Cargando scripts")
            ShowLog("--------------------------------")


            Dim conn As SqlConnection = New SqlConnection(ConnString)
            Dim transaction As SqlTransaction

            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each file As FileItem In NewScripts
                    Dim query As String = GetQuery(file)
                    For Each line As String In query.Split(New Char() {";", "GO"})
                        Dim script As String = line.Remove(line.IndexOf("GO"))
                        Dim sqlCommand As SqlCommand = New SqlCommand(script, conn, transaction)
                        ShowLog(sqlCommand.ExecuteNonQuery() & " afectadas")
                    Next
                    'AddHandler sqlCommand.StatementCompleted, New StatementCompletedEventHandler(AddressOf SqlCommandCompleted)

                    'ShowLog(query)

                Next
                transaction.Commit()
                ShowLog("-----------------------------------------")
                ShowLog("Actualización llevada a cabo sin errores")
                ShowLog("Version de la BD: " & GetDBVersion())

                btn_Execute.Text = "Cerrar"
            Catch ex As Exception
                ShowLog(ex.Message)
                If Not transaction Is Nothing Then
                    transaction.Rollback()
                End If
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub SqlCommandCompleted(ByVal sender As Object, ByVal e As Data.StatementCompletedEventArgs)

    End Sub

    

    Private Function GetQuery(ByVal file As FileItem) As String
        Dim fs As StreamReader = IO.File.OpenText(Scripts.BaseDirectory & "\" & file.FileName)
        Dim str As String = fs.ReadToEnd()
        fs.Close()
        Return str
    End Function

End Class