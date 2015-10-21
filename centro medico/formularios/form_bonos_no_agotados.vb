Imports centro_medico.UI.Reportes
Imports centro_medico.CM2DataSetTableAdapters
Imports Janus.Windows.GridEX

Public Class form_bonos_no_agotados

    Dim _source As CMLinqDataContext
    Dim dView As DataView


    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        _source = New CMLinqDataContext()

    End Sub

    Private Sub form_bonos_no_agotados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicializaPacientesBonos()
    End Sub

    Private Sub InicializaPacientesBonos()
        Dim nombre As String = ""
        Dim pApellido As String = ""
        Dim sApellido As String = ""

        If txtNombre.Text.Length > 0 Then nombre = txtNombre.Text
        If txtApellido1.Text.Length > 0 Then pApellido = txtApellido1.Text
        If txtApellido2.Text.Length > 0 Then sApellido = txtApellido2.Text

        Dim pacientes As List(Of PACIENTE) = New List(Of PACIENTE)()
        For Each p As PACIENTE In _source.PACIENTEs
            If p.TieneBonosNoAgotados Then
                If p.NOMBRE.ToLower().Contains(nombre.ToLower()) And
                    ((p.APELLIDO1 Is Nothing) Or (Not p.APELLIDO1 Is Nothing AndAlso p.APELLIDO1.ToLower().Contains(pApellido.ToLower()))) And
                    ((p.APELLIDO2 Is Nothing) Or (Not p.APELLIDO2 Is Nothing AndAlso p.APELLIDO2.ToLower().Contains(sApellido.ToLower()))) Then
                    pacientes.Add(p)
                End If
            End If
        Next
        PACIENTEBindingSource.DataSource = pacientes

        Dim dTable As New CM2DataSet.PacientesBonosDataTable
        dTable = Me.PACIENTESBONOSTableAdapter.GetDataBy(nombre, pApellido, sApellido)
        dView = dTable.DefaultView

    End Sub


    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource
        rpt.Name = "CM2DataSet_PacientesBonos"
        rpt.Value = dView
        UI.Reportes.ReportesManager.Imprime("PacientesBonosNoAgotados.rdlc", {rpt})
    End Sub

    Private Sub FiltrarPacientesBonos(sender As Object, e As EventArgs) Handles bt_filtrar.Click
        InicializaPacientesBonos()
    End Sub

End Class