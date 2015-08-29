Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Principal
Imports System.Security.Permissions
Imports centro_medico
Imports Janus.Windows.GridEX
Imports System.IO

Public Class frmFicherosAsociados
    'SI PIEZA = 0 LOS FICHERO ESTAN ASOCIADOS AL ODONTOGRAMA
    'LO CUAL SUCEDE CUANDO SE HACE CLICK EN UNA REGION DEL ODONTOGRAMA
    'DONDE NO HAY PIEZAS
    Public Pieza As Integer
    Public Odontograma As Integer

    'Public IDPaciente As Integer
    Dim context As CMLinqDataContext
    Dim UserCancelled As Boolean = False


    Private Sub frmFicherosAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarDatos()
        AplicaPermisos()
    End Sub

    Private Sub CargarDatos()
        Try
            context = New CMLinqDataContext()
            Dim ficheros As New List(Of FICHEROSGLOBAL)
            If Pieza = 0 Then
                ficheros = (From f In context.FICHEROSGLOBALs Where f.SECCION = "DENTALODONTOGRAMA" And f.REFREGISTRO = Odontograma Select f).ToList()
            Else
                ficheros = (From f In context.FICHEROSGLOBALs Where f.SECCION = "DENTALPIEZA" And f.REFREGISTRO = Pieza Select f).ToList()
            End If

            FICHEROSGLOBALBindingSource.DataSource = ficheros
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tstNuevaCitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstNuevo.Click
        Dim frm As New frmFicheroGlobal_Adjunto_ADD()

        If Pieza = 0 Then
            frm.RefRegistro = Odontograma
            frm.
        Else

        End If

            

        'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

        'End If
        CargarDatos()
    End Sub

#Region "Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.FormattingRow"
    Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.FormattingRow
        Dim fichero As FICHERO = e.Row.DataRow
        Try

            'Impersonar al usuario segun su carpeta compartida
            'If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
            '    Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
            '                                                Globales.Configuracion.CarpetaCompartidaPassword, _
            '                                                Globales.Configuracion.CarpetaCompartidaDominio)
            'End If

            'Encontrar un fichero con el mismo tipo en temp
            Dim files() As String = Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.Temp, "*" & Path.GetExtension(fichero.FICHERO))
            If files.Length > 0 Then
                Dim icon As Icon = System.Drawing.Icon.ExtractAssociatedIcon(files(0))

                'Dim icon As Icon = System.Drawing.Icon.ExtractAssociatedIcon(Globales.Configuracion.dirfiles & "\" & fichero.FICHERO)
                e.Row.Cells("ColumnIcon").Image = icon.ToBitmap().GetThumbnailImage(16, 16, Nothing, IntPtr.Zero)
            Else
                'Dim icon As Icon = System.Drawing.Icon.ExtractAssociatedIcon(Globales.)

                'e.Row.Cells("ColumnIcon").Image = .ToBitmap().GetThumbnailImage(16, 16, Nothing, IntPtr.Zero)

            End If

        Catch ex As Exception
            'e.Row.Cells("ColumnIcon").Image = ImageList1.Images(0)
            'e.Row.Cells("ColumnIcon").ToolTipText = "Fichero no encontrado!"
            'e.Row.RowStyle = New GridEXFormatStyle()
            'e.Row.RowStyle.ForeColor = Color.Red
        Finally
            'Deshacer la impersonacion
            'If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
            '    If Not Globales.Configuracion.UserImpersonation Is Nothing Then
            '        GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
            '    End If
            'End If
        End Try

    End Sub
#End Region


    Private Sub GridEX1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If GridEX1.SelectedItems.Count > 0 Then
            'tstModificar_Click(Nothing, Nothing)
            GridEX1_ColumnButtonClick(Nothing, Nothing)
        End If

    End Sub

#Region "Private Function ShowFile(ByVal path As String) As Boolean"
    Private Function ShowFile(ByVal path As String) As Boolean

        'La idea es impersonar, copiar pa memoria el fichero, desimpersonar, y copiarlo para carpeta temp, y de ahi ejecutarlo



        Dim source As New GoltraTools.Origen()
        source.FileName = Globales.Configuracion.dirfiles & "\" & path
        source.UseCredentials = Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida
        source.Username = Globales.Configuracion.CarpetaCompartidaUsuario
        source.Password = Globales.Configuracion.CarpetaCompartidaPassword
        source.Domain = Globales.Configuracion.CarpetaCompartidaDominio

        Dim target As New GoltraTools.Destination()
        target.FileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\" & path
        target.UseCredentials = False


        Dim copier As New GoltraTools.FileCopier()


        copier.CopiarFicheroAsincrono(source, target, _
                                      New GoltraTools.FileCopier.CopyingFileResultDelegate(AddressOf CopyTerminated), True)

        If Not UserCancelled Then
            Dim s As String = """" & path & """"
            '    'ShellExecute(0, vbNullString, s, vbNullString, vbNullString, 1)

            Dim instance As ProcessStartInfo = New ProcessStartInfo(target.FileName)
            'instance.UseShellExecute = True
            System.Diagnostics.Process.Start(instance)

        End If

        Return Not UserCancelled
    End Function
#End Region

    Private Sub CopyTerminated(ByVal res As DialogResult)
        If res = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("Copia cancelada por el usuario")
            UserCancelled = True
        Else
            UserCancelled = False
        End If

    End Sub



#Region " Public Function GetRegisteredApplication(ByVal ParamFileName As String, ByVal FileExtension As String, _"

    ''' <summary>
    ''' Return registered application by file's extension
    ''' </summary>
    ''' <param name="ParamFileName">Parameter for ShellAppName</param>
    ''' <param name="FileExtension">File extension</param>
    ''' <param name="AppName">Returns application name if any</param>
    ''' <param name="ShellAppName">Returns a string with application name and file name as its parameter</param>
    ''' <returns>True if the default application for this file type was found</returns>
    ''' <remarks>This function is Windows XP and Vista compatible</remarks>
    Public Function GetRegisteredApplication(ByVal ParamFileName As String, ByVal FileExtension As String, _
     ByRef AppName As String, ByRef ShellAppName As String) As Boolean
        '
        ' Return registered application by file's extension
        '
        Dim StrExt As String
        Dim StrProgID As String
        Dim StrExe As String
        Dim oHKCR As RegistryKey ' HKEY_CLASSES_ROOT
        Dim oProgID As RegistryKey
        Dim oOpenCmd As RegistryKey
        Dim TempPos As Integer

        Try
            ' Add starting dot to extension
            StrExt = "." & FileExtension
            ' Get Programmatic Identifier for this extension
            Try
                oHKCR = Registry.ClassesRoot
                oProgID = oHKCR.OpenSubKey(StrExt)
                StrProgID = oProgID.GetValue(Nothing).ToString
                oProgID.Close()
            Catch
                ' No ProgID, return false
                Return False
            End Try
            ' Get associated application
            Try
                oOpenCmd = oHKCR.OpenSubKey(StrProgID & "\shell\open\command")
                StrExe = oOpenCmd.GetValue(Nothing).ToString
                oOpenCmd.Close()
            Catch
                ' Missing default application
                Return False
            End Try
            TempPos = StrExe.IndexOf(" %1")
            If TempPos > 0 Then
                ' Replace %1 placeholder with ParamFileName
                StrExe = StrExe.Substring(0, TempPos)
                AppName = StrExe
                StrExe = StrExe & " " & Convert.ToChar(34) & ParamFileName & Convert.ToChar(34)
                ShellAppName = StrExe
            Else
                ' No %1 placeholder found, append ParamFileName
                AppName = StrExe
                ShellAppName = StrExe & " " & Convert.ToChar(34) & ParamFileName & Convert.ToChar(34)
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long

    Private Sub AplicaPermisos()
        'tstNuevo.ReadOnly = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 2)
        tstNuevo.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 2)
        tstModificar.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 2)
        tstEliminar.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 3)
    End Sub



    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        tstModificar.Enabled = GridEX1.SelectedItems.Count > 0
        tstEliminar.Enabled = GridEX1.SelectedItems.Count > 0
    End Sub

    Private Sub tstModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridEX1.SelectedItems.Count > 0 Then
            If GridEX1.SelectedItems(0).RowType = RowType.Record Then
                'Dim fichero As FICHERO = GridEX1.SelectedItems(0).GetRow().DataRow
                'Dim frm As New frmFicherosAdjuntos_ADD()
                'frm.IDPaciente = IDPaciente
                'frm.CODIGO = fichero.CODIGO
                'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                '    CargarDatos()
                'End If
            End If
        End If
    End Sub

    Private Sub tstEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridEX1.SelectedItems.Count > 0 Then
            If GridEX1.SelectedItems(0).RowType = RowType.Record Then
                Dim fichero As FICHERO = GridEX1.SelectedItems(0).GetRow().DataRow

                If MessageBox.Show("¿Confirma que desea eliminar el fichero adjunto '" & fichero.FICHERO & "'", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    'Eliminar el fichero
                    Try
                        'Impersonar al usuario segun su carpeta compartida
                        If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                            Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                                                                        Globales.Configuracion.CarpetaCompartidaPassword, _
                                                                        Globales.Configuracion.CarpetaCompartidaDominio)
                        End If

                        'Tratar de eliminar el archivo
                        System.IO.File.Delete(Globales.Configuracion.dirfiles & "\" & fichero.FICHERO)

                        'Desimpersonar
                        If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                            If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                                GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                            End If
                        End If

                        'Eliminar de la bd
                        context.FICHEROs.DeleteOnSubmit(fichero)
                        context.SubmitChanges()
                        CargarDatos()
                    Catch ex As Exception
                        MessageBox.Show("Error eliminando el archivo")
                        Return
                    Finally
                        'Deshacer la impersonacion
                        If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                            If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                                GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                            End If
                        End If

                    End Try
                End If

            End If
        End If
    End Sub

    Private Sub GridEX1_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick
        Dim fichero As FICHEROSGLOBAL = GridEX1.SelectedItems(0).GetRow().DataRow
        ShowFile(fichero.FICHERO)
    End Sub

    
End Class


