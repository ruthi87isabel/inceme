Imports System.Net.Mail
Imports GoltraTools
Imports System.Threading

Module Main
    Public Sub Main()

        'AddHandler Application.ThreadException, New ThreadExceptionEventHandler()
        ''Application.ThreadException += New ThreadExceptionEventHandler(New ThreadExceptionHandler().ApplicationThreadException)
        'Dim mainForm As form_centro_medico = Nothing
        'Try
        '    'Dim splash As New SplashScreen()
        '    'splash.Show()
        '    'DoLongRunningSetUpStuff()

        '    ' Instantiate and initialize our main form here - we have exception handling in place
        '    mainForm = New form_centro_medico()
        '    mainForm.Initialize()

        '    'splash.Close()
        'Catch e As Exception
        '    ' You probably want something a little more sophisticated than this
        '    MessageBox.Show(e.Message, "An exception occurred:", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        '    System.Environment.[Exit](0)
        'End Try

        'Application.Run(mainForm)


        Dim res As DialogResult = DialogResult.No

        Do Until res = DialogResult.OK Or res = DialogResult.Cancel
            Dim frmPassword As form_password = New form_password()
            res = frmPassword.ShowDialog()
            If res = DialogResult.OK Then

                Dim centromedico As form_centro_medico = New form_centro_medico(frmPassword._Idusuario, frmPassword.diaNoValido)
                res = centromedico.ShowDialog()
            End If
        Loop
    End Sub
End Module
