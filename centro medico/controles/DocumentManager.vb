Option Explicit On
Option Strict On


Imports Microsoft.ApplicationBlocks.Data
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports clsUtils

Public Class DocumentManager


    Private tipoFichero As Globals.TipoDocumento = Globals.TipoDocumento.Presupuesto
    Private _idCategoria As Globals.CategoriaDocumento = Globals.CategoriaDocumento.Ninguno
    Private _queryExcluyente As String = ""
    Private _connectionString As String = ""

    Public Delegate Sub FileAddedEventHandler(ByVal idDoc As Long)
    Public Delegate Sub FileDeletedEventHandler(ByVal idDoc As Long)

    Public Event FileAdded As FileAddedEventHandler
    Public Event FileDeleted As FileAddedEventHandler


    Public Sub DocumentManager()
        'Error si no se setea la connString
        Me.ConnectionString = My.MySettings.Default.FontanalsBDConnectionString

    End Sub


#Region "Private Sub pbAddDocTramite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAddDocTramite.Click"
    Private Sub pbAddDocTramite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAddDocTramite.Click
        Dim diag As OpenFileDialog = New OpenFileDialog()
        Dim res As DialogResult = diag.ShowDialog()
        If res = DialogResult.OK Then
            Dim fileInfo As FileInfo = New FileInfo(diag.FileName)
            Dim stream As FileStream = File.Open(diag.FileName, FileMode.Open)
            Dim arr() As Byte = New Byte(CType(stream.Length, Integer)) {}
            Try
                stream.Read(arr, 0, CType(stream.Length, Integer))
                stream.Close()

                Dim idDoc As Long = GetMaxID() + 1

                ArchivoDigitalTableAdapter.Connection.ConnectionString = _connectionString
                ArchivoDigitalTableAdapter.Insert(idDoc, Me.IdCategoria, fileInfo.Name, Nothing, Nothing, Nothing, Nothing, CInt(Me.Tipo), "", fileInfo.CreationTime, fileInfo.LastWriteTime)
                UpdateFileData(idDoc, arr)

                OnFileAdded(idDoc)

                'Annadir detalles del Fichero
                'Dim frmDetalles As frmDetallesArchivo = New frmDetallesArchivo()
                'frmDetalles.ConnectionString = Me.ConnectionString
                'frmDetalles.idDoc = idDoc
                'frmDetalles.ShowDialog()

                UpdateList()

                

            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
#End Region

#Region "Public Property ConnectionString() As String"
    Public Property ConnectionString() As String
        Get
            Return _connectionString
        End Get
        Set(ByVal value As String)
            _connectionString = value
            ArchivoDigitalTableAdapter.Connection.ConnectionString = value
        End Set
    End Property
#End Region

#Region "Public Property Tipo() As Tipos"
    Public Property Tipo() As Globals.TipoDocumento
        Get
            Return tipoFichero
        End Get
        Set(ByVal value As Globals.TipoDocumento)
            tipoFichero = value
        End Set
    End Property
#End Region

#Region "Public Property IdCategoria() As Integer"
    Public Property IdCategoria() As Globals.CategoriaDocumento
        Get
            Return _idCategoria
        End Get
        Set(ByVal value As Globals.CategoriaDocumento)
            _idCategoria = value
        End Set
    End Property
#End Region
    

#Region "Public Property QueryExcluyente() As String"
    ''' <summary>
    ''' Se usa para filtrar los documentos e involucra idDoc, Ej: SELECT idDoc FROM DocumentosClientes WHERE idCliente=7
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property QueryExcluyente() As String
        Get
            Return _queryExcluyente
        End Get
        Set(ByVal value As String)
            _queryExcluyente = value
        End Set
    End Property
#End Region

#Region "Public Sub UpdateList()"
    Public Sub UpdateList()


        If Not IsHandleCreated Then
            Return
        End If
        If DesignMode Then
            Return
        End If

        Dim lParam As New List(Of SqlParameter)()

        Dim param As SqlParameter = Nothing
        param = New SqlParameter("@idCategoria", SqlDbType.Int)
        param.Value = _idCategoria
        lParam.Add(param)

        Dim param2 As SqlParameter = Nothing
        param2 = New SqlParameter("@Tipo", SqlDbType.Int)
        param2.Value = tipoFichero
        lParam.Add(param2)

        Dim query As String = "SELECT idDoc, idCategoria, NombreArchivo, Descripcion, PalabrasClave, Fichero, UsrIdCreado, Tipo, codigoTipo, creado, modificado FROM dbo.ArchivoDigital WHERE idCategoria = @idCategoria AND Tipo=@Tipo "
        'AND codigoTipo = '" & _codigoTipo.Trim() & "'"

        If Not _queryExcluyente = "" Then
            query = query & " AND idDoc in (" & _queryExcluyente & ")"
        End If

        SystemImageList.Images.Clear()
        'SystemImageList.TransparentColor = Color.FromArgb(0, 0, 0, 0)


        Dim _imageCount As Integer = 0

        ListViewDocs.Items.Clear()

        Try
            Dim dt As DataTable = SqlHelper.ExecuteDataset(Me.ConnectionString, CommandType.Text, query, lParam.ToArray()).Tables(0)
            For Each row As DataRow In dt.Rows

                'SystemImageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(row("Descripcion").ToString()))

                Dim fileName As String = row("NombreArchivo").ToString()
                Dim extension As String = fileName.Substring(fileName.LastIndexOf(".") + 1).ToLower()
                Dim icon As Icon = IconHandler.IconFromExtension(extension, IconSize.Small)

                If Not icon Is Nothing Then
                    SystemImageList.Images.Add(icon)
                    Dim item As ListViewItem = New ListViewItem(fileName, _imageCount)
                    'item.StateImageIndex = 0
                    item.Tag = row
                    ListViewDocs.Items.Add(item)
                    _imageCount = _imageCount + 1
                Else
                    Dim item As ListViewItem = New ListViewItem(fileName)
                    item.Tag = row
                    ListViewDocs.Items.Add(item)
                End If

            Next

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        End Try

        'ArchivoDigitalTableAdapter.Fill(GoltDataSet.ArchivoDigital, Me.IdCategoria, Me.Tipo, Me.CodigoTipo)
    End Sub
#End Region

#Region "Public Sub ClearList()"
    Public Sub ClearList()

        If Not IsHandleCreated Then
            Return
        End If

        If DesignMode Then
            Return
        End If

        ListViewDocs.Items.Clear()

    End Sub
#End Region

#Region "Private Function GetMaxID() As Integer"
    Private Function GetMaxID() As Integer

        Dim result As Object = SqlHelper.ExecuteScalar(Me.ConnectionString, CommandType.Text, "SELECT MAX(idDoc) FROM ArchivoDigital", Nothing)

        If result Is Convert.DBNull Then
            Return 1
        Else
            Return CType(result, Integer)
        End If


    End Function
#End Region

#Region "Private Function UpdateFileData(ByVal idDoc As Long, ByVal arr As Byte()) As Integer"
    Private Function UpdateFileData(ByVal idDoc As Long, ByVal arr As Byte()) As Integer

        Dim lParam As New List(Of SqlParameter)()

        Dim sqlParam1 As New SqlParameter("@idDoc", SqlDbType.Int)
        sqlParam1.Value = idDoc
        lParam.Add(sqlParam1)

        Dim sqlParam2 As New SqlParameter("@Fichero", SqlDbType.Binary)
        sqlParam2.Value = arr
        lParam.Add(sqlParam2)

        Dim result As Integer = SqlHelper.ExecuteNonQuery(Me.ConnectionString, CommandType.Text, "UPDATE ArchivoDigital SET Fichero = @Fichero WHERE (idDoc = @idDoc)", lParam.ToArray())
        Return result
    End Function
#End Region

#Region "Private Function GetFile() As Integer"
    Private Function GetFile(ByVal idDoc As Integer) As Byte()

        Dim lParam As New List(Of SqlParameter)()

        Dim sqlParam1 As New SqlParameter("@idDoc", SqlDbType.Int)
        sqlParam1.Value = idDoc
        lParam.Add(sqlParam1)

        Dim ds As DataSet = SqlHelper.ExecuteDataset(Me.ConnectionString, CommandType.Text, "SELECT Fichero FROM ArchivoDigital WHERE idDoc=@idDoc", lParam.ToArray())

        Return CType(ds.Tables(0).Rows(0).ItemArray(0), Byte())

    End Function
#End Region


#Region "Public Sub InsertarDocumentos(ByVal idDoc As Integer, ByVal tabla As String, ByVal columnName As String, ByVal valor As String)"
    Public Sub InsertarDocumentos(ByVal idDoc As Integer, ByVal tabla As String, ByVal columnName As String, ByVal valor As Object)

        Dim lParam As New List(Of SqlParameter)()

        Dim sqlParam1 As New SqlParameter("@idDoc", SqlDbType.Int)
        sqlParam1.Value = idDoc
        lParam.Add(sqlParam1)

        Dim sqlParam2 As New SqlParameter("@" & columnName, SqlDbType.Char)
        sqlParam2.Value = valor
        lParam.Add(sqlParam2)

        SqlHelper.ExecuteNonQuery(My.MySettings.Default.FontanalsBDConnectionString, CommandType.Text, "INSERT INTO " & tabla & " (idDoc, " & columnName & ") VALUES (@idDoc, @" & columnName & ") ", lParam.ToArray())

    End Sub
#End Region



#Region "Public Function DeleteDocument(ByVal idDoc As Integer) As Integer"
    Public Function DeleteDocument(ByVal idDoc As Integer) As Integer

        Dim lParam As New List(Of SqlParameter)()
        Dim sqlParam As New SqlParameter("@idDoc", SqlDbType.Int)
        sqlParam.Value = idDoc
        lParam.Add(sqlParam)

        Dim ds As DataSet = New DataSet()
        Return SqlHelper.ExecuteNonQuery(Me.ConnectionString, CommandType.Text, "DELETE FROM ArchivoDigital WHERE idDoc=@idDoc", lParam.ToArray())

    End Function
#End Region


#Region "Public Shared Function DeleteRelatedDocument(ByVal tableName as string, Byval columnName as String ) As Integer"
    Public Shared Function DeleteRelatedDocument(ByVal tableName As String, ByVal columnName As String, Byval columnValue as String) As Integer

        Dim lParam As New List(Of SqlParameter)()
        Dim sqlParam As New SqlParameter("@" & columnName, SqlDbType.Char)
        sqlParam.Value = columnValue
        lParam.Add(sqlParam)

        Dim ds As DataSet = New DataSet()
        Return SqlHelper.ExecuteNonQuery(My.MySettings.Default.FontanalsBDConnectionString, CommandType.Text, "DELETE FROM ArchivoDigital WHERE idDoc in (SELECT idDoc FROM " & tableName & " WHERE " & columnName & "=" & sqlParam.ParameterName & ")", lParam.ToArray())


    End Function
#End Region

#Region "Private Sub OnFileAdded(ByVal idDoc As Long)"
    Private Sub OnFileAdded(ByVal idDoc As Long)
        RaiseEvent FileAdded(idDoc)
    End Sub
#End Region

#Region "Private Sub OnFileDeleted(ByVal idDoc As Long)"
    Private Sub OnFileDeleted(ByVal idDoc As Long)
        RaiseEvent FileDeleted(idDoc)
    End Sub
#End Region


    Private Sub DocumentManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'UpdateList()
    End Sub

    Private Sub pbDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDelete.Click
        If ListViewDocs.SelectedItems.Count > 0 Then
            Dim row As DataRow = CType(ListViewDocs.SelectedItems(0).Tag, DataRow)
            Dim idDoc As Integer = CType(row(0), Integer)
            Me.DeleteDocument(idDoc)
            OnFileDeleted(idDoc)
            UpdateList()
        Else
            MessageBox.Show("Debe seleccionar un documento")
        End If


    End Sub

    Private Sub ListViewDocs_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewDocs.DoubleClick
        SaveFileInTempAndShow()
    End Sub



#Region "How Open a file with default opener"


    'Put this at the top of your form or module

    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long

    'Magical function


    'Your button click
    'Private Sub Command1_Click()

    '    If OpenLocation("notepad.exe", "c:\myfile.txt", "", 1) < 32 Then
    '        'Failed to open
    '    Else
    '        'Opened
    '    End If

    'End Sub


    Private Sub ShowFile(ByVal path As String)
        Dim s As String = """" & path & """"
        'ShellExecute(0, vbNullString, s, vbNullString, vbNullString, 1)

        Dim instance As ProcessStartInfo = New ProcessStartInfo(path)
        'instance.UseShellExecute = True
        System.Diagnostics.Process.Start(instance)

    End Sub


#End Region

    Private Sub pb_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Edit.Click
        SaveFileAsDialog()
    End Sub

#Region "Private Sub SaveFileInTempAndShow()"

    Private Sub SaveFileInTempAndShow()

        If ListViewDocs.SelectedItems.Count > 0 Then
            Dim row As DataRow = CType(ListViewDocs.SelectedItems(0).Tag, DataRow)
            Dim idDoc As Integer = CType(row(0), Integer)
            Dim fileName As String = CType(row("NombreArchivo"), String)

            Try

                Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)

                path = path & "\" & fileName

                Dim arr() As Byte = GetFile(idDoc)
                Dim fs As FileStream = New FileStream(path, FileMode.Create, FileAccess.ReadWrite)
                fs.Write(arr, 0, arr.Length - 1)
                fs.Close()

                ShowFile(path)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Debe seleccionar un documento")
        End If

    End Sub
#End Region

#Region "Private Sub SaveFileAsDialog()"

    Private Sub SaveFileAsDialog()

        If ListViewDocs.SelectedItems.Count = 1 Then

            Dim row As DataRow = CType(ListViewDocs.SelectedItems(0).Tag, DataRow)
            Dim idDoc As Integer = CType(row(0), Integer)
            Dim fileName As String = CType(row("NombreArchivo"), String)

            Dim fd As SaveFileDialog = New SaveFileDialog()
            fd.FileName = fileName

            Dim res As DialogResult = fd.ShowDialog()

            If res = DialogResult.OK Then
                Try
                    Dim arr() As Byte = GetFile(idDoc)
                    Dim fs As FileStream = New FileStream(fd.FileName, FileMode.Create, FileAccess.ReadWrite)
                    fs.Write(arr, 0, arr.Length - 1)
                    fs.Close()

                    ShowFile(fd.FileName)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        End If


    End Sub
#End Region

    Private Sub pbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEditar.Click
        'If ListViewDocs.SelectedItems.Count > 0 Then
        '    Dim row As DataRow = CType(ListViewDocs.SelectedItems(0).Tag, DataRow)
        '    Dim idDoc As Integer = CType(row(0), Integer)

        '    Dim frmDetalles As frmDetallesArchivo = New frmDetallesArchivo()
        '    frmDetalles.ConnectionString = Me.ConnectionString
        '    frmDetalles.idDoc = idDoc
        '    frmDetalles.ShowDialog()
        'Else
        '    MessageBox.Show("Debe seleccionar un documento")
        'End If
    End Sub
End Class
