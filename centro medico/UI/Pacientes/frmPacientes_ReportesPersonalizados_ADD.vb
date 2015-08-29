Imports centro_medico
Imports System.IO

Public Class frmPacientes_ReportesPersonalizados_ADD

    Public IDReporte As Integer = -1
    Public Reporte As ReportesPersonalizado
    Dim fd As New OpenFileDialog()

    Public Context As CMLinqDataContext

    Public Enum Secciones
        Pacientes = 1
        Facturas = 2
    End Enum

    Private Sub frmPacientes_ReportesPersonalizados_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange([Enum].GetNames(GetType(Secciones)))
        ComboBox1.SelectedIndex = 0
        Context = New CMLinqDataContext()
        If IDReporte = -1 Then
            'Reporte = ReportesPersonalizadoBindingSource.AddNew()
            Reporte = New ReportesPersonalizado()
            Reporte.Seccion = Secciones.Pacientes
            Reporte.FechaAnnadido = Date.Now
            Reporte.PorDefecto = False

        Else
            Reporte = (From r In Context.ReportesPersonalizados Where r.IDReporte = IDReporte Select r).SingleOrDefault()
            ReportesPersonalizadoBindingSource.DataSource = Reporte
            'btnBrowse.Enabled = False
        End If

    End Sub


    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        fd.Filter = " Reportes (RDLC)|*.rdlc"
        fd.InitialDirectory = Globales.Configuracion.impresionfilesdirectory
        If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'Dim fs = New FileStream(fd.FileName, FileMode.Open)
            Try
                Reporte.FileName = System.IO.Path.GetFileName(fd.FileName)
                Reporte.Descripcion = System.IO.Path.GetFileNameWithoutExtension(fd.FileName)
                FileNameTextBox.Text = Reporte.FileName
                DescripcionTextBox.Text = Reporte.Descripcion

                Dim rpt As New Microsoft.Reporting.WinForms.LocalReport()
                rpt.ReportPath = fd.FileName

                'rpt.LoadReportDefinition(fs)

                If rpt.GetDataSourceNames().Count > 0 Then
                    Reporte.DataSourceName = rpt.GetDataSourceNames(0)
                    DataSourceNameTextBox.Text = Reporte.DataSourceName
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                'fs.Close()
            End Try
            
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If IDReporte = -1 Then
            Context.ReportesPersonalizados.InsertOnSubmit(Reporte)
        End If

        If FileNameTextBox.Text = String.Empty Then
            MessageBox.Show("Debe seleccionar un fichero reporte.")
            btnBrowse.Focus()
            Return
        End If

        If DescripcionTextBox.Text = String.Empty Then
            MessageBox.Show("Debe introducir una descripción del reporte.")
            DescripcionTextBox.Focus()
            Return
        End If

        'Ahora hay que tratar de copiar el reporte personalizado para la carpeta definida en Reportes
        'Aqui debo copiar el fichero de su posicion original a la carpeta compartida
        Try
            'Si el boton buscar esta activado significa que es nuevo el fichero adjunto
            'If btnBrowse.Enabled Then
            '    If fd.FileName.Length > 0 Then

            '        Dim fsOrigen As New FileStream(fd.FileName, FileMode.Open)
            '        Dim fsDestino As FileStream = Nothing

            '        Try
            '            Dim arr(fsOrigen.Length) As Byte
            '            fsOrigen.Read(arr, 0, arr.Length - 1)


            '            'Impersonar al usuario segun su carpeta compartida
            '            If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
            '                Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
            '                                                            Globales.Configuracion.CarpetaCompartidaPassword, _
            '                                                            Globales.Configuracion.CarpetaCompartidaDominio)
            '            End If

            '            fsDestino = New FileStream(Globales.Configuracion.impresionfilesdirectory & "\" & Reporte.FileName, FileMode.Create)
            '            fsDestino.Write(arr, 0, arr.Length - 1)

            '        Catch ex As Exception
            '            MessageBox.Show("Error copiando archivo a la carpeta de impresión!")
            '            Return
            '        Finally
            '            fsOrigen.Close()
            '            If Not fsDestino Is Nothing Then
            '                fsDestino.Close()
            '            End If
            '            'Deshacer la impersonación
            '            If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
            '                If Not Globales.Configuracion.UserImpersonation Is Nothing Then
            '                    GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
            '                End If
            '            End If

            '        End Try

            '    End If

            'End If


            ReportesPersonalizadoBindingSource.EndEdit()
            Context.SubmitChanges()

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error insertando: " & ex.Message)
            Return
        End Try

    End Sub
End Class

