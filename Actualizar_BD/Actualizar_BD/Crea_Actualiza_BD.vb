Imports System.IO
Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.ComponentModel
Imports System.Text
Imports System.Configuration
Imports System.Text.RegularExpressions


Public Class Crea_Actualiza_BD

    Dim exception As String = ""
    Dim name As String = ""
    Dim version As String = ""
    Dim newbd As Boolean = True
    Dim ver As String = ""
    Protected configuration As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("CMConnectionString")
    Dim Conn As New SqlConnection(configuration.ConnectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        TbNombre.Focus()
        Initialize()
    End Sub

    Public Sub Initialize()

        TBDireccion.ReadOnly = True
        TBDireccion.BackColor = Color.White
        TbDestino.ReadOnly = True
        TbDestino.BackColor = Color.White
    End Sub

    Private Sub Examinar_Click(sender As Object, e As EventArgs) Handles Examinar.Click

        LbSuccess.Visible = False
        LbError.Visible = False
        PictureBox1.Visible = False

        If RbAct.Checked Then
            If LbVersion.Visible Then
                FolderBrowserDialog1.ShowDialog()
                TBDireccion.Text = FolderBrowserDialog1.SelectedPath

                If TBDireccion.Text <> "" Then
                    Dim fileDir = My.Computer.FileSystem.GetFiles(TBDireccion.Text, FileIO.SearchOption.SearchTopLevelOnly, "db_?.?.?.*.sql")

                    Dim i As Integer = 0
                    ListBScripts.Items.Clear()
                    For Each file As String In fileDir
                        Dim fileNames As String = My.Computer.FileSystem.GetName(file)
                        fileNames = fileNames.Substring(0, fileNames.Length - 4)

                        If i = 1 Then ListBScripts.Items.Add(fileNames)
                        If fileNames.Contains(version) Then i = 1
                    Next
                End If
            Else
                MsgBox("Debe registrar el nombre de BD")
            End If
        Else
            FolderBrowserDialog1.ShowDialog()
            TBDireccion.Text = FolderBrowserDialog1.SelectedPath

            If TBDireccion.Text <> "" Then
                Dim fileDir = My.Computer.FileSystem.GetFiles(TBDireccion.Text, FileIO.SearchOption.SearchTopLevelOnly, "db_?.?.?.*.sql")

                ListBScripts.Items.Clear()
                For Each file As String In fileDir
                    Dim fileNames As String = My.Computer.FileSystem.GetName(file)
                    fileNames = fileNames.Substring(0, fileNames.Length - 4)

                    ListBScripts.Items.Add(fileNames)
                Next
            End If
        End If

    End Sub

    'Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles BtnExecute.Click

    '    While ListBScripts.Items.Count() > 0
    '        Dim name As String = ListBScripts.Items(0).ToString()
    '        Dim cmd As ProcessStartInfo
    '        cmd = New ProcessStartInfo("sqlcmd", "-S localhost -i " + TBDireccion.Text + "\" + name + ".sql")
    '        'cmd = New ProcessStartInfo("sqlcmd", "-S localhost -U sa -P 1234 -i " + TBDireccion.Text + "\" + name + ".sql")
    '        cmd.UseShellExecute = False
    '        cmd.CreateNoWindow = True
    '        cmd.RedirectStandardOutput = True

    '        Dim proc As Process = New Process()
    '        proc.StartInfo = cmd
    '        proc.Start()

    '        Dim exc As String = proc.StandardOutput.ReadToEnd()
    '        proc.WaitForExit()
    '        exception = exc
    '        Label3.Text = "Error Script " + name + ".sql"
    '        Label3.Visible = True
    '        PictureBox1.Visible = True

    '        ListBScripts.Items.Remove(name)

    '    End While
    'End Sub NAME()

    'End Sub

    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles BtnExecute.Click
        If (ListBScripts.Items.Count()) > 0 Then
            If Not BackgroundWorker1.IsBusy Then
                BackgroundWorker1.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        TbDestino.Enabled = False
        ExaminarDestino.Enabled = False
        RbAct.Enabled = False
        RbCrear.Enabled = False
        TbNombre.Enabled = False
        Examinar.Enabled = False

        Dim nombre As String = TbNombre.Text

        If (RbCrear.Checked And nombre <> "" And TbDestino.Text <> "") Or (RbAct.Checked And nombre <> "") Then
            LbSuccess.Visible = False
            LbError.Visible = False
            PictureBox1.Visible = False
            newbd = RbCrear.Checked
            'Dim oConn As New SqlConnection("Data Source=localhost;Integrated Security=SSPI")
            exception = ""

            While (ListBScripts.Items.Count()) > 0 And exception = ""
                Conn.Open()
                Dim str As String
                Dim strArrays() As String

                name = ListBScripts.Items(0).ToString()

                Using sr As New StreamReader(TBDireccion.Text + "\" + name + ".sql", Encoding.Default)
                    str = sr.ReadToEnd()
                End Using

                str = If(newbd, str.Replace("siesta", nombre), "USE " & nombre & " GO " & vbCrLf & str)
                str = If(newbd, str.Replace("Direction", TbDestino.Text), str)
                str = str.Replace("GO", "go")

                'Eliminar comentarios sql
                Dim pattern As String = "/\*([^*]|[\r\n])*\*/"
                Dim rgx As New Regex(pattern)
                str = rgx.Replace(str, "")

                'guardar en un erreglo subquerys determinas por distintos separadores
                Dim separators() As String = {vbCrLf & "go" & vbCrLf & "go" & vbCrLf, vbCrLf & "go" & vbCrLf, " go" & vbCrLf, vbCrLf & "go ", ";" & vbCrLf & "go", " go "}
                strArrays = str.Split(separators, StringSplitOptions.RemoveEmptyEntries)

                For Each strArray In strArrays
                    If Not strArray = "" Then
                        Dim cmd As New SqlCommand(strArray, Conn)
                        ver = strArray
                        cmd.CommandTimeout = 60
                        cmd.ExecuteNonQuery()
                    End If
                Next
                ListBScripts.Items.Remove(name)
                newbd = False
                Conn.Close()
            End While

        Else
            MsgBox("Debe especificar todos los datos", vbExclamation)
        End If

        If RbCrear.Checked Then
            TbDestino.Enabled = True
            ExaminarDestino.Enabled = True
        End If
        RbAct.Enabled = True
        RbCrear.Enabled = True
        TbNombre.Enabled = True
        Examinar.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Conn.Close()

        If ListBScripts.Items.Count() > 0 And ((RbCrear.Checked And TbNombre.Text <> "" And TbDestino.Text <> "") Or (RbAct.Checked And TbNombre.Text <> "")) Then
            If Not e.Error.Message = "" Then
                exception = e.Error.Message & vbCrLf & vbCrLf & "query ejecutada:" & ver
                LbError.Text = "Error Script " + name + ".sql"
                LbError.Visible = True
                PictureBox1.Visible = True

                RbAct.Enabled = True
                RbCrear.Enabled = True
                TbNombre.Enabled = True
                Examinar.Enabled = True
                If RbCrear.Checked Then
                    TbDestino.Enabled = True
                    ExaminarDestino.Enabled = True
                End If
            End If
        End If

        If ListBScripts.Items.Count() = 0 Then
            If RbCrear.Checked Then LbSuccess.Text = "La BD " + TbNombre.Text + " se ha creado con exito"
            If RbAct.Checked Then LbSuccess.Text = "La BD " + TbNombre.Text + " se ha actualizado con exito"
            LbSuccess.Visible = True
            TbNombre.Text = ""
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim form_Exceptio As New Exception
        form_Exceptio.TextBox1.Text = exception
        form_Exceptio.Text = "Exception Error Script " + name + ".sql"
        form_Exceptio.ShowDialog()
    End Sub

    Private Sub TbNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNombre.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) < 122 Or Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) < 90) Or Asc(e.KeyChar) = 95) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TbNombre_LostFocus(sender As Object, e As EventArgs) Handles TbNombre.LostFocus
        CargaVersion()
    End Sub

    Private Sub CargaVersion()
        If RbAct.Checked And Not TbNombre.Text = "" Then

            Dim Dr As SqlDataReader
            'Dim oConn As New SqlConnection("Data Source=localhost; Initial Catalog=" & TbNombre.Text & "; Integrated Security=SSPI")
            Try
                Conn.Open()
                Dim cmd As New SqlCommand("USE " & TbNombre.Text & " SELECT Valor FROM VariablesGlobales where Clave = 'DB_Version'", Conn)
                Dr = cmd.ExecuteReader()
                Dr.Read()
                LbVersion.Visible = True
                version = Dr(0)
                LbVersion.Text = "Versión: " + version
                Dr.Close()
                Conn.Close()
            Catch
                LbVersion.Visible = False
                MsgBox("La BD " & TbNombre.Text & " no existe", vbExclamation)
                TbNombre.Text = ""
            End Try
        Else
            LbVersion.Visible = False
        End If
    End Sub

    Private Sub RbCrear_CheckedChanged(sender As Object, e As EventArgs) Handles RbCrear.CheckedChanged
        If RbCrear.Checked Then
            ExaminarDestino.Enabled = True
            TbDestino.Enabled = True
            TbDestino.Text = ""
            LbVersion.Visible = False
            TbNombre.Text = ""
            TBDireccion.Text = ""
            ListBScripts.Items.Clear()
            LbSuccess.Visible = False
            LbError.Visible = False
            PictureBox1.Visible = False
            BtnExecute.Text = "Crear BD"

        End If
    End Sub

    Private Sub RbAct_CheckedChanged(sender As Object, e As EventArgs) Handles RbAct.CheckedChanged
        If RbAct.Checked Then
            ExaminarDestino.Enabled = False
            TbDestino.Enabled = False
            TbDestino.Text = ""
            TbNombre.Text = ""
            TBDireccion.Text = ""
            ListBScripts.Items.Clear()
            LbSuccess.Visible = False
            LbError.Visible = False
            PictureBox1.Visible = False
            BtnExecute.Text = "Actualizar BD"
            newbd = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExaminarDestino.Click
        FolderBrowserDialog2.ShowDialog()
        TbDestino.Text = FolderBrowserDialog2.SelectedPath
    End Sub
End Class
