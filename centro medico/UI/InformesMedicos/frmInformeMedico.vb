Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Reportes

Public Class frmInformeMedico
    Public Idpaciente As Integer
    Public Informes
    Dim context As CMLinqDataContext
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion

    Public Sub New(ByVal Id_Paciente As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        IDPACIENTE = Id_Paciente
    End Sub

    Private Sub tstNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstNuevo.Click
        Dim frm As New frmInformeMedico_ADD()
        context = New CMLinqDataContext()
        Dim informe As New INFORME_MEDICO
        informe.RefPaciente = IDPACIENTE
        informe.Fecha = Date.Now

        frm.INFORME_MEDICOBindingSource.DataSource = informe

        If frm.ShowDialog() = DialogResult.OK Then

            context.INFORME_MEDICOs.InsertOnSubmit(informe)
            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Informes_Medico, "Informes Medicos", informe.IdInforme.ToString(), "Informe médico de " & informe.MEDICO.NOMBRECOMPLETO & " Fecha:" & informe.Fecha.ToString() & " Paciente:" & informe.PACIENTE.NombreCompleto)
            Filtrar()
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        If InformesGridEX.SelectedItems.Count > 0 Then
            Dim frm As New frmInformeMedico_ADD()
            Dim informe As INFORME_MEDICO = InformesGridEX.SelectedItems(0).GetRow.DataRow

            Dim context As New CMLinqDataContext()
            informe = (From i In context.INFORME_MEDICOs Where i.IdInforme = informe.IdInforme Select i).First()
            frm.INFORME_MEDICOBindingSource.DataSource = informe

            If frm.ShowDialog() = DialogResult.OK Then
                context.SubmitChanges()
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Informes_Medico, "Informes Medicos", informe.IdInforme.ToString(), "Informe médico de " & informe.MEDICO.NOMBRECOMPLETO & " Fecha:" & informe.Fecha.ToString() & " Paciente:" & informe.PACIENTE.NombreCompleto)
                Filtrar()
            End If
        Else
            MessageBox.Show("Debe seleccionar un reporte")
        End If

    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        If InformesGridEX.SelectedItems.Count > 0 Then
            Dim q As INFORME_MEDICO
            q = InformesGridEX.SelectedItems(0).GetRow().DataRow()
            Dim context As New CMLinqDataContext()
            Dim Inf = (From i In context.INFORME_MEDICOs Where i.IdInforme = q.IdInforme Select i).First()
            context.INFORME_MEDICOs.DeleteOnSubmit(Inf)
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Informes_Medico, "Informes Medicos", q.IdInforme.ToString(), "Informe médico de " & q.MEDICO.NOMBRECOMPLETO & " Fecha:" & q.Fecha.ToString() & " Paciente:" & q.PACIENTE.NombreCompleto)
            context.SubmitChanges()
            Filtrar()
        End If
    End Sub

    Private Sub fechaAntes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaAntes.ValueChanged
        Filtrar()
    End Sub

    Private Sub fechaDespues_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaDespues.ValueChanged
        Filtrar()

        'If fechaDespues.Checked Then
        '    Dim tmp
        '    If fechaAntes.Checked Then
        '        tmp = (From i In context.INFORME_MEDICOs Where (fechaAntes.Value <= i.Fecha And fechaDespues.Value >= i.Fecha) Select i).ToList()
        '    Else
        '        tmp = (From i In context.INFORME_MEDICOs Where (fechaDespues.Value >= i.Fecha) Select i).ToList()
        '    End If
        '    INFORMEMEDICOBindingSource.DataSource = tmp
        '    Return
        'End If
        'informes = (From i In context.INFORME_MEDICOs Select i).ToList()
        'INFORMEMEDICOBindingSource.DataSource = informes
    End Sub


    Private Sub InformesGridEX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformesGridEX.Click
        'Dim i As Integer
        'Dim t = InformesGridEX.SelectedItems
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True

    End Sub

    Sub Filtrar()
        InformesGridEX.DataSource = Nothing
        context = New CMLinqDataContext()
        Dim tmp As IQueryable(Of INFORME_MEDICO)
        If CtrlMedico1.ID_Medico <> 0 Then
            tmp = From i In context.INFORME_MEDICOs Where (i.RefPaciente = IDPACIENTE And i.RefMedico = CtrlMedico1.ID_Medico) Select i
        Else
            tmp = From i In context.INFORME_MEDICOs Where i.RefPaciente = IDPACIENTE Select i
        End If


        If fechaAntes.Checked Then
            Dim fi As New Date(fechaAntes.Value.Year, fechaAntes.Value.Month, fechaAntes.Value.Day, 0, 0, 0)
            tmp = (From i In tmp Where (fi <= i.Fecha) Select i)
        End If
        If fechaDespues.Checked Then
            Dim ff As New Date(fechaDespues.Value.Year, fechaDespues.Value.Month, fechaDespues.Value.Day, 23, 59, 59)
            tmp = From i In tmp Where (ff >= i.Fecha)
        End If
        INFORMEMEDICOBindingSource.DataSource = tmp.ToList()
        InformesGridEX.DataSource = INFORMEMEDICOBindingSource
    End Sub

    Private Sub bt_filtrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Filtrar()
    End Sub


    Private Sub InformesGridEX_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles InformesGridEX.RowDoubleClick
        If Modo = Globales.ModoParaFormas.Edicion Then
            tst_Editar_Click(Nothing, Nothing)
        Else
            'Aqui va la selecion
        End If

    End Sub

    Private Sub frmInformeMedico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filtrar()
    End Sub

    Private Sub InformesGridEX_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformesGridEX.SelectionChanged
        tst_Editar.Enabled = InformesGridEX.SelectedItems.Count > 0
        tst_Eliminar.Enabled = InformesGridEX.SelectedItems.Count > 0
    End Sub

    Private Sub CtrlMedico1_MEDICOSeleccionado(ByVal IdMedico As System.Int32, ByVal oldMedico As System.Nullable(Of Integer), ByVal IsReturnPressed As System.Boolean) Handles CtrlMedico1.MEDICOSeleccionado
        Filtrar()
    End Sub

    Private Sub CtrlMedico1_MEDICOEliminado(ByVal IdMedicoAnterior As Integer) Handles CtrlMedico1.MEDICOEliminado
        Filtrar()
    End Sub

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click

        If InformesGridEX.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un informe")
            Return
        End If

        Dim informeMedico As INFORME_MEDICO = InformesGridEX.GetRow().DataRow

        'Datasources
        Dim dsInformeMedico As New Microsoft.Reporting.WinForms.ReportDataSource
        dsInformeMedico.Name = "dsInformeMedico"

        Dim listInformeMedico As New List(Of INFORME_MEDICO)
        listInformeMedico.Add(informeMedico)
        dsInformeMedico.Value = listInformeMedico

        Dim dsMedico As New Microsoft.Reporting.WinForms.ReportDataSource
        dsMedico.Name = "dsMedico"
        Dim listMedico As New List(Of MEDICO)
        listMedico.Add(informeMedico.MEDICO)
        dsMedico.Value = listMedico

        Dim dsPaciente As New Microsoft.Reporting.WinForms.ReportDataSource
        dsPaciente.Name = "dsPaciente"
        Dim listPaciente As New List(Of WRAPPER_PACIENTE)
        listPaciente.Add(New WRAPPER_PACIENTE(informeMedico.PACIENTE))
        dsPaciente.Value = listPaciente

        'Parametros
        Dim paramsList As List(Of Microsoft.Reporting.WinForms.ReportParameter) = New List(Of ReportParameter)

     
        If Not informeMedico.MEDICO Is Nothing Then
            If Not informeMedico.MEDICO.FIRMA Is Nothing Then
                'If Not frmVisor.ReportViewer.LocalReport.GetParameters("FirmaMedicoPath") Is Nothing Then
                Dim myImage As Byte() = informeMedico.MEDICO.FIRMA.ToArray

                Dim imgMemoryStream As New IO.MemoryStream(myImage)
                Dim bitmap As Bitmap = New Bitmap(imgMemoryStream)


                Dim paramLogo As ReportParameter = New ReportParameter()
                paramLogo.Name = "FirmaMedicoPath"

                'Salvar la imagen en una direccion temporal
                Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\temp.jpg"

                bitmap.Save(filename)


                paramLogo.Values.Add("file:///" & filename)
                'Me.ReportViewer.LocalReport.SetParameters(paramLogo)
                If Not paramsList Is Nothing Then paramsList.Add(paramLogo)
                'End If
            End If
        End If


        UI.Reportes.ReportesManager.Imprime("InformeMedico.rdlc", {dsInformeMedico, dsMedico, dsPaciente}, paramsList.ToArray())


    End Sub
End Class
