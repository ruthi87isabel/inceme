Imports System.Xml

Namespace UI.Reportes

    Public Class frmReportViewer

        Private fileActual As String
        Private cargandoPrimeraVez As Boolean = True

        Private Sub FrmReportViewerLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.ReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

            tsReportes.Visible = Globales.Usuario.EsAdministrador()

            If tsReportes.Visible Then
                'Cargar la lista de reportes personalizados del xml
                CargaPersonalizados()
            End If

            If System.IO.File.Exists(Globales.Usuario.CERTIFICADOPATH) = True Then
                bt_firmar.Enabled = True
            Else
                bt_firmar.Enabled = False
            End If

        End Sub


        Private Sub CargaPersonalizados()
            Try

                'Obtener el listado de carpetas custom

                Dim path As String = Application.StartupPath & "\rdlc\custom"
                Dim clinicas() As String = System.IO.Directory.GetDirectories(path)

                comboReportes.Items.Add("default")

                For Each clinic As String In clinicas
                    comboReportes.Items.Add(IO.Path.GetFileName(clinic))
                Next


                'Determinar el fichero actual
                fileActual = IO.Path.GetFileName(ReportViewer.LocalReport.ReportPath)
                comboReportes.SelectedIndex = 0

                'Me.Text = Globales.Reportes(fileActual).Info
            Catch ex As Exception

            End Try
        End Sub
        ''' <summary>
        ''' Procedimiento que permite exportar el fichero a pdf simplemente o bien exportarlo con firma digital.
        ''' </summary>
        ''' <param name="firmar"></param>
        ''' <remarks></remarks>
        Private Sub exportar(ByRef firmar As Boolean)
            'Dim a = Me.ReportViewer.LocalReport.ListRenderingExtensions
            Dim f As System.IO.FileStream
            Dim s As String()
            Dim w As Microsoft.Reporting.WinForms.Warning()
            Dim rByte As Byte()

            Dim pathDestino As String
            Dim sfd As New System.Windows.Forms.SaveFileDialog
            sfd.Filter = "pdf | *.pdf"

            Dim dr As DialogResult = sfd.ShowDialog()
            If dr = Windows.Forms.DialogResult.OK Then
                pathDestino = sfd.FileName
                Dim tmpPath As String = System.IO.Path.GetTempPath
                Dim tmpfile As String = Guid.NewGuid.ToString & ".pdf"
                Dim pathOriginal As String
                pathOriginal = System.IO.Path.Combine(tmpPath, tmpfile)


                'Guardo el pdf 
                rByte = Me.ReportViewer.LocalReport.Render("PDF", Nothing, "application/pdf", "UTF-8", "pdf", s, w)

                If firmar Then
                    f = System.IO.File.Create(pathOriginal)
                Else
                    f = System.IO.File.Create(pathDestino)
                End If

                f.Write(rByte, 0, rByte.Length)
                f.Close()
                If firmar Then
                    'pido la clave del certifiado
                    Dim clave As String = InputBox("Seguridad...", " Contraseña del certificado")

                    'firmo el documento y lo paso al directorio seleccionado por el cliente
                    If clave.Length > 0 Then
                        Dim firma As New Firmar(pathOriginal, pathDestino, clave)
                        firma.Firma()
                    End If

                End If
            Else
                Exit Sub
            End If

        End Sub
       

        Private Sub tsButtonVerReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsButtonVerReporte.Click
            If comboReportes.SelectedIndex <> -1 Then
                Dim folder As String = comboReportes.SelectedItem
                If comboReportes.SelectedIndex = 0 Then
                    If Not cargandoPrimeraVez Then
                        Me.ReportViewer.LocalReport.ReportPath = Application.StartupPath & "\rdlc\" & folder & "\" & fileActual
                    End If
                Else
                    Me.ReportViewer.LocalReport.ReportPath = Application.StartupPath & "\rdlc\custom\" & folder & "\" & fileActual
                End If

                If Not cargandoPrimeraVez Then
                    Me.ReportViewer.RefreshReport()
                End If
                cargandoPrimeraVez = False
            End If

        End Sub

        Private Sub comboReportes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboReportes.SelectedIndexChanged
            tsButtonVerReporte_Click(Nothing, Nothing)
        End Sub

        Private Sub tsEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsEditar.Click

            If comboReportes.SelectedIndex <> -1 Then
                Dim folder As String = comboReportes.SelectedItem
                If comboReportes.SelectedIndex = 0 Then
                    Process.Start(Application.StartupPath & "\rdlc\" & folder & "\" & fileActual)
                Else
                    Process.Start(Application.StartupPath & "\rdlc\custom\" & folder & "\" & fileActual)
                End If
            End If

        End Sub

        Private Sub ReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer.Load
            If Not ReportViewer.LocalReport.ReportPath Is Nothing Then
                If Not System.IO.File.Exists(ReportViewer.LocalReport.ReportPath) Then
                    MessageBox.Show("El reporte " + ReportViewer.LocalReport.ReportPath + " no existe. ")
                    Me.Close()
                End If
                ReportViewer.LocalReport.EnableExternalImages = True
            End If

        End Sub

        Private Sub frmReportViewer_2010_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
            Try
                ReportViewer.Dispose()
                Dispose()
            Catch ex As Exception

            End Try

        End Sub

        Private Sub Firmar_Click(sender As Object, e As EventArgs) Handles bt_firmar.Click
            Me.exportar(True)
        End Sub
    End Class

End Namespace