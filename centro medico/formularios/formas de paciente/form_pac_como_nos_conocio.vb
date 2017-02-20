Imports centro_medico.UI.Reportes
Imports centro_medico.CM2DataSetTableAdapters
Imports Janus.Windows.GridEX

Public Class form_pac_como_nos_conocio

    Dim _source As CMLinqDataContext
    Dim dView As DataView


    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        _source = New CMLinqDataContext()

    End Sub

    Private Sub form_conocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicializaPacientesConocio()
        CargarComoNosConocio()

    End Sub

    Private Sub InicializaPacientesConocio()
        Dim nombre As String = ""
        Dim pApellido As String = ""
        Dim sApellido As String = ""

        If txtNombre.Text.Length > 0 Then nombre = txtNombre.Text
        If txtApellido1.Text.Length > 0 Then pApellido = txtApellido1.Text
        If txtApellido2.Text.Length > 0 Then sApellido = txtApellido2.Text

        Dim pacientes As List(Of PACIENTE) = New List(Of PACIENTE)()
        If Not cmbConocio.CheckedItems Is Nothing Then
            If cmbConocio.CheckedItems.Length > 0 Then
                For Each c As ComoConocio In cmbConocio.CheckedItems
                    For Each p As PACIENTE In _source.PACIENTEs
                        If Not p.CONOCIO Is Nothing Then
                            If p.NOMBRE.ToLower().Contains(nombre.ToLower()) And
                                ((p.APELLIDO1 Is Nothing) Or (Not p.APELLIDO1 Is Nothing AndAlso p.APELLIDO1.ToLower().Contains(pApellido.ToLower()))) And
                                ((p.APELLIDO2 Is Nothing) Or (Not p.APELLIDO2 Is Nothing AndAlso p.APELLIDO2.ToLower().Contains(sApellido.ToLower()))) And
                                (Not p.CONOCIO Is Nothing AndAlso p.CONOCIO.ToLower().Contains(c.Descripcion.ToLower())) Then
                                pacientes.Add(p)
                            End If
                        End If
                    Next
                Next
            End If
        Else
            For Each p As PACIENTE In _source.PACIENTEs
                If Not p.CONOCIO Is Nothing Then
                    If p.NOMBRE.ToLower().Contains(nombre.ToLower()) And
                        ((p.APELLIDO1 Is Nothing) Or (Not p.APELLIDO1 Is Nothing AndAlso p.APELLIDO1.ToLower().Contains(pApellido.ToLower()))) And
                        ((p.APELLIDO2 Is Nothing) Or (Not p.APELLIDO2 Is Nothing AndAlso p.APELLIDO2.ToLower().Contains(sApellido.ToLower()))) Then
                        pacientes.Add(p)
                    End If
                End If
            Next

        End If

        PACIENTEBindingSource.DataSource = pacientes
        GridEX1.MoveTo(0)

        Dim dTable As New CM2DataSet.PACIENTESCONOCIODataTable
        Dim dTable1 As New CM2DataSet.PACIENTESCONOCIODataTable
        If Not cmbConocio.CheckedItems Is Nothing Then
            If cmbConocio.CheckedItems.Length > 0 Then
                For Each c As ComoConocio In cmbConocio.CheckedItems
                    dTable = Me.PacientesconocioTableAdapter.GetData(nombre, If(pApellido.Length > 0, pApellido, Nothing), If(sApellido.Length > 0, sApellido, Nothing), c.Descripcion)
                    dTable1.Merge(dTable, True)
                Next
            End If
        Else
            dTable = Me.PacientesconocioTableAdapter.GetData(nombre, If(pApellido.Length > 0, pApellido, Nothing), If(sApellido.Length > 0, sApellido, Nothing), Nothing)
        End If
        dView = dTable1.DefaultView
        LbResultados.Text = "Resultados: " & pacientes.Count()

    End Sub

    Private Sub CargarComoNosConocio()
        Dim context As New CMLinqDataContext()
        ComoConocioBindingSource.DataSource = (From c In context.ComoConocios Select c).ToList()
    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource
        rpt.Name = "PacientesComoConocio"
        rpt.Value = dView
        UI.Reportes.ReportesManager.Imprime("PacientesComoNosConocio.rdlc", {rpt})
    End Sub

    Private Sub FiltrarPacientesBonos(sender As Object, e As EventArgs) Handles bt_filtrar.Click
        InicializaPacientesConocio()
    End Sub

End Class