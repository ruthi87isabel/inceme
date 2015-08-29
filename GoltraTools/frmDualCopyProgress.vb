Imports System.IO
Imports System.Windows.Forms
Imports System.Threading

Public Class frmDualCopyProgress

    Dim thread As Threading.Thread
    Dim ts As Threading.ThreadStart

    Dim source As Origen
    Dim target As Destination
    Dim override As Boolean = False
    'Dim copyMonitor As CopyMonitor

    Dim bufferSize As Long = 10 * 1024
    Dim total As Long = 1
    Dim bytesread As Long = 0
    Dim subTotalRead As Long = 0
    Dim subTotalWritten As Long = 0
    Dim userCanceled As Boolean = False

    'Public UseCredentials As Boolean = True

    Public UserImpersonation As System.Security.Principal.WindowsImpersonationContext = Nothing

    Public Sub New(ByRef source As Origen, ByRef target As Destination, ByVal override As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.source = source
        Me.target = target
        Me.override = override
        'Me.copyMonitor = copyMonitor
    End Sub



    Private Sub frmDualCopyProgress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Copiar()
    End Sub

    Private Sub Copiar()
        'Verificar que el destino no exista ya

        If target.UseCredentials Then
            'Impersonar al usuario en el destino
            UserImpersonation = FileCopier.Impersonate(target.Username, _
                                                      target.Password, _
                                                      target.Domain)
        End If

      
        Dim exito As Boolean = False
        Dim fsDestino As FileStream = Nothing
        While Not exito
            Try
                If override Then
                    fsDestino = New FileStream(target.FileName, FileMode.Create, FileAccess.Write)
                Else
                    fsDestino = New FileStream(target.FileName, FileMode.CreateNew, FileAccess.Write)
                End If

                exito = True
            Catch ex As Exception
                'Ocurrio una excepcion 

                If ex.GetHashCode() = 54674917 Then
                    MessageBox.Show(ex.Message)
                    Cancel()
                    Me.Close()
                    Return
                End If



                If TypeOf (ex) Is IOException Then
                    Dim frm As New frmFileExists()
                    'frm.Text = ex.Message

                    frm.FileName = target.FileName
                    If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        If Not frm.Sobrescribir Then
                            target.FileName = frm.FileName
                        Else
                            'fsDestino = New FileStream(target.FileName, FileMode.Create, FileAccess.Write)
                            exito = True
                        End If
                    Else

                        If target.UseCredentials Then
                            'Revertir
                            If Not UserImpersonation Is Nothing Then
                                FileCopier.UndoImpersonate(UserImpersonation)
                            End If
                        End If
                        Cancel()
                        Me.Close()
                        Return
                    End If

                Else
                    'Una excepcion de otro tipo, cancelar
                    MessageBox.Show("Error")
                    If target.UseCredentials Then
                        'Revertir
                        If Not UserImpersonation Is Nothing Then
                            FileCopier.UndoImpersonate(UserImpersonation)
                        End If
                    End If
                    Cancel()
                    Me.Close()
                    Return
                End If
            Finally

                If Not fsDestino Is Nothing Then
                    fsDestino.Close()
                End If


            End Try
        End While


        If target.UseCredentials Then
            'Revertir
            If Not UserImpersonation Is Nothing Then
                FileCopier.UndoImpersonate(UserImpersonation)
            End If
        End If


        ts = New Threading.ThreadStart(AddressOf asyncCopy)
        thread = New Threading.Thread(ts)
        thread.Start()
        Timer1.Start()

    End Sub



    Private Sub asyncCopy()

        Try
            'Si el botosn buscar esta activado significa que es nuevo el fichero adjunto

            If source.UseCredentials Then
                UserImpersonation = FileCopier.Impersonate(source.Username, _
                                                          source.Password, _
                                                          source.Domain)
            End If
          
            Dim fsOrigen As New FileStream(source.FileName, FileMode.Open)
            total = fsOrigen.Length

            bufferSize = 0.1 * fsOrigen.Length

            If source.UseCredentials Then
                'Revertir
                If Not UserImpersonation Is Nothing Then
                    FileCopier.UndoImpersonate(UserImpersonation)
                End If
            End If


            If target.UseCredentials Then
                'Impersonar al usuario en el destino
                UserImpersonation = FileCopier.Impersonate(target.Username, _
                                                          target.Password, _
                                                          target.Domain)
            End If


            Dim fsDestino As FileStream = New FileStream(target.FileName, FileMode.Create, FileAccess.Write)

            If target.UseCredentials Then
                'Revertir
                If Not UserImpersonation Is Nothing Then
                    FileCopier.UndoImpersonate(UserImpersonation)
                End If
            End If


            Dim arr(bufferSize) As Byte

            Try
                Dim terminado As Boolean = False
                Do While Not terminado

                    If source.UseCredentials Then
                        'Impersonar al usuario en el origen
                        UserImpersonation = FileCopier.Impersonate(source.Username, _
                                                                   source.Password, _
                                                                   source.Domain)
                    End If


                    bytesread = fsOrigen.Read(arr, 0, bufferSize)
                    subTotalRead += bytesread

                    If source.UseCredentials Then
                        'Revertir
                        If Not UserImpersonation Is Nothing Then
                            FileCopier.UndoImpersonate(UserImpersonation)
                        End If
                    End If


                    If target.UseCredentials Then
                        'Impersonar al usuario en el destino
                        UserImpersonation = FileCopier.Impersonate(target.Username, _
                                                                  target.Password, _
                                                                  target.Domain)
                    End If

                    fsDestino.Write(arr, 0, bytesread)
                    subTotalWritten += bytesread
                    'pbarWriting.BeginInvoke(New ChangeReadPercentDelegate(AddressOf ChangeWritePercent), New Object() {subTotalWritten})
                    terminado = (bytesread = 0) Or userCanceled
                    fsDestino.Flush()

                    If target.UseCredentials Then
                        'Revertir
                        If Not UserImpersonation Is Nothing Then
                            FileCopier.UndoImpersonate(UserImpersonation)
                        End If
                    End If


                Loop

                If userCanceled Then
                    

                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.BeginInvoke(New CancelDelegate(AddressOf Me.Close))
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.BeginInvoke(New CancelDelegate(AddressOf Me.Close))
                End If


            Catch ex As Exception

                MessageBox.Show("Error copiando archivo!")

                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.BeginInvoke(New CancelDelegate(AddressOf Me.Close))
            Finally
                Timer1.Stop()
                If Not fsOrigen Is Nothing Then
                    If source.UseCredentials Then
                        'Impersonar al usuario en el origen
                        UserImpersonation = FileCopier.Impersonate(source.Username, _
                                                                   source.Password, _
                                                                   source.Domain)
                    End If

                    fsOrigen.Close()


                    If source.UseCredentials Then
                        'Revertir
                        If Not UserImpersonation Is Nothing Then
                            FileCopier.UndoImpersonate(UserImpersonation)
                        End If
                    End If

                End If
                If Not fsDestino Is Nothing Then
                    If target.UseCredentials Then
                        'Impersonar al usuario en el destino
                        UserImpersonation = FileCopier.Impersonate(target.Username, _
                                                                  target.Password, _
                                                                  target.Domain)
                    End If

                    fsDestino.Close()

                    'Tratar de eliminar el fichero copiadose si se cancelo
                    Try
                        If userCanceled Then
                            File.Delete(target.FileName)
                        End If
                    Catch ex As Exception
                    End Try

                    If target.UseCredentials Then
                        'Revertir
                        If Not UserImpersonation Is Nothing Then
                            FileCopier.UndoImpersonate(UserImpersonation)
                        End If
                    End If
                End If
                'If UseCredentials Then
                '    If Not UserImpersonation Is Nothing Then
                '        FileCopier.UndoImpersonate(UserImpersonation)
                '    End If
                'End If
            End Try

        Catch ex As Exception

            MessageBox.Show("Error copiando archivo!")

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.BeginInvoke(New CancelDelegate(AddressOf Me.Close))
        End Try

    End Sub

    Private Delegate Sub ChangeReadPercentDelegate(ByVal percent As Double)

    Private Sub ChangeReadPercent(ByVal current As Long)
        pbarReading.Value = current / total * 100
        lblReadAmount.Text = "(" & FormatFileSize(current) & "/" & FormatFileSize(total) & ")"

    End Sub

    Private Sub ChangeWritePercent(ByVal current As Long)
        pbarWriting.Value = current / total * 100
        lblWrittenAmount.Text = "(" & FormatFileSize(current) & "/" & FormatFileSize(total) & ")"
    End Sub

#Region "public Shared Function FormatFileSize(ByVal fileSize As Long) As String"
    Public Shared Function FormatFileSize(ByVal fileSize As Long) As String

        Dim suffixes() As String = {"B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}
        Dim s As Integer = 0
        Dim _size As Double = fileSize
        While (_size >= 1024)
            s = s + 1
            _size = _size / 1024
        End While
        Return String.Format("{0:N1} {1}", _size, suffixes(s))
    End Function
#End Region





    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pbarReading.Value = subTotalRead / total * 100
        lblReadAmount.Text = "(" & FormatFileSize(subTotalRead) & "/" & FormatFileSize(total) & ")"
        pbarWriting.Value = subTotalWritten / total * 100
        lblWrittenAmount.Text = "(" & FormatFileSize(subTotalWritten) & "/" & FormatFileSize(total) & ")"

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'thread.Abort()

        Me.BeginInvoke(New CancelDelegate(AddressOf Cancel))

    End Sub

    Private Delegate Sub CancelDelegate()

    Private Sub Cancel()
        userCanceled = True
        'Timer1.Stop()
        'Me.Close()
    End Sub


End Class
