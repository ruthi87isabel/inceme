Imports System.Windows.Forms
Imports System.IO

Public Class frmFileExists

    Public FileName As String
    Public Sobrescribir As Boolean = False

    Dim ext As String
    Dim filenameSingle As String
    Dim pathbase As String


    Private Sub frmFileExists_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ext = Path.GetExtension(FileName)
        filenameSingle = Path.GetFileNameWithoutExtension(FileName)
        pathbase = Path.GetDirectoryName(FileName) & "\"
        lblMsg.Text = "ATENCION: El fichero '" & filenameSingle + ext & "' existe o esta en uso. ¿que desea hacer?"
        txtNuevoNombre.Text = filenameSingle + ext
        txtGenerado.Text = Path.GetFileName(GeneraFicheroAutomatico())
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If rbManual.Checked Then
            If txtNuevoNombre.Text.Length = 0 Then
                MessageBox.Show("Debe introducir un nuevo nombre de fichero")
                txtNuevoNombre.Focus()
                Return
            End If
            FileName = pathbase & txtNuevoNombre.Text
            If Not txtNuevoNombre.Text.EndsWith(ext) Then
                FileName += ext
            End If
        End If

        If rbAutomatico.Checked Then
            FileName = GeneraFicheroAutomatico()
        End If

        If rbSobrescribir.Checked Then
            Sobrescribir = True
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Function GeneraFicheroAutomatico() As String
        'Return pathbase & filenameSingle & "_[" & Today.Year & "-" & Today.Month & "-" & Today.Day & "]__" & Guid.NewGuid().ToString("N") & ext
        Return pathbase & filenameSingle & "_[" & Today.Year & "-" & Today.Month & "-" & Today.Day & "]_" & Date.Now.Ticks & ext
    End Function

End Class