Imports System.Runtime.InteropServices

Public Class formPaciente_Captura
    Public direccion As String
    Dim DATOS As IDataObject
    Dim IMAGEN As Image
    Dim CARPETA As String
    Dim FECHA As String = DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_")
    Dim DIRECTORIO As String = "C:\Users\SALVADOR\Desktop\" ' AQUI COLOCA LA RUTA A TU ESCRITORIO
    Dim DESTINO As String
    Dim CONTADOR As Integer = 1
    Dim CARPETAS_DIARIAS As String
    Public Const WM_CAP As Short = &H400S
    Public Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP + 41
    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_SEQUENCE As Integer = WM_CAP + 62
    Public Const WM_CAP_FILE_SAVEAS As Integer = WM_CAP + 23
    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1
    Public Const WM_CAP_STOP As Integer = WM_CAP + 68

    Public iDevice As Integer = 0 ' Current device ID
    Public hHwnd As Integer ' Handle to preview window

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean




    Private Sub formPaciente_Captura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenPreviewWindow()
    End Sub

    'Open View
    Public Sub OpenPreviewWindow()

        ' Open Preview window in picturebox
        '
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
           480, Display.Handle.ToInt32, 0)

        ' Connect to device
        '
        SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            '
            'Set the preview scale

            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            'Set the preview rate in milliseconds
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            'Start previewing the image from the camera
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            ' Resize window to fit in picturebox
            '
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, Display.Width, Display.Height, _
                    SWP_NOMOVE Or SWP_NOZORDER)

        Else
            ' Error connecting to device close window
            ' 
            DestroyWindow(hHwnd)

        End If
    End Sub

    Private Sub GPicture_Click(sender As Object, e As EventArgs) Handles GPicture.Click
        ' Copy image to clipboard
        '
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        ' Get image from clipboard and convert it to a bitmap
        '
        DATOS = Clipboard.GetDataObject()

        IMAGEN = CType(DATOS.GetData(GetType(System.Drawing.Bitmap)), Image)
        Display.Visible = False
        GPicture.Visible = False
        Visor.Visible = True
        Save.Visible = True
        PDelete.Visible = True
        Visor.Image = IMAGEN
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PDelete.Click
        Display.Visible = True
        GPicture.Visible = True
        Visor.Visible = False
        Save.Visible = False
        PDelete.Visible = False
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        SFD.FileName = FECHA
        SFD.Title = "GUARDAR IMAGEN"

        SFD.Filter = "Jpeg|*.jpg"
        If SFD.ShowDialog = DialogResult.OK Then IMAGEN.Save(SFD.FileName, Imaging.ImageFormat.Jpeg)
        direccion = SFD.FileName

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Public ReadOnly Property Selected() As String
        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return direccion
        End Get

    End Property

    Public Function TestConnection() As Boolean
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
           480, Display.Handle.ToInt32, 0)

        ' Connect to device
        '
        SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            DestroyWindow(hHwnd)
            Return True
        Else
            DestroyWindow(hHwnd)
            Return False
        End If
    End Function

End Class