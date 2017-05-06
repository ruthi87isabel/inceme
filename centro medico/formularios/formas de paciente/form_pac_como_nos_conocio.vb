Imports centro_medico.UI.Reportes
Imports centro_medico.CM2DataSetTableAdapters
Imports Janus.Windows.GridEX

Public Class form_pac_como_nos_conocio

    Dim context As CMLinqDataContext
    Dim dView As DataView
    Dim ListResult As List(Of String) = New List(Of String)



    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        context = New CMLinqDataContext()

    End Sub

    Private Sub form_conocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtp_ff.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 23, 59, 59)
        Dim di As Date = Date.Now.AddMonths(-1)
        dtp_fi.Value = New Date(di.Year, di.Month, di.Day, 0, 0, 0)

        InicializaPacientesConocio()
        CargarResultados()
        ComoConocioBindingSource.DataSource = (From c In context.ComoConocios Select c Order By c.Descripcion).ToList()

    End Sub

    Private Sub InicializaPacientesConocio()
        Dim nombre As String = ""
        Dim pApellido As String = ""
        Dim sApellido As String = ""
        Dim FechaIni As String = ""
        Dim FechaFin As String = ""

        If txtNombre.Text.Length > 0 Then nombre = txtNombre.Text
        If txtApellido1.Text.Length > 0 Then pApellido = txtApellido1.Text
        If txtApellido2.Text.Length > 0 Then sApellido = txtApellido2.Text
        If dtp_fi.Checked Then FechaIni = dtp_fi.Value.ToString("d")
        If dtp_ff.Checked Then FechaFin = dtp_ff.Value.ToString("d")

        Dim pacientes As List(Of PACIENTE) = New List(Of PACIENTE)()
        If Not cmbConocio.CheckedItems Is Nothing Then
            If cmbConocio.CheckedItems.Length > 0 Then
                For Each c As ComoConocio In cmbConocio.CheckedItems
                    For Each p As PACIENTE In context.PACIENTEs
                        If Not p.CONOCIO Is Nothing Then
                            If p.NOMBRE.ToLower().Contains(nombre.ToLower()) And
                                ((p.APELLIDO1 Is Nothing) Or (Not p.APELLIDO1 Is Nothing AndAlso p.APELLIDO1.ToLower().Contains(pApellido.ToLower()))) And
                                ((p.APELLIDO2 Is Nothing) Or (Not p.APELLIDO2 Is Nothing AndAlso p.APELLIDO2.ToLower().Contains(sApellido.ToLower()))) And
                                (Not p.CONOCIO Is Nothing AndAlso p.CONOCIO.ToLower().Contains(c.Descripcion.ToLower())) And
                                ((FechaIni = "") Or (FechaIni <> "" AndAlso p.FECHAALTA >= FechaIni)) And
                                ((FechaFin = "") Or (FechaFin <> "" AndAlso p.FECHAALTA <= FechaFin)) Then
                                pacientes.Add(p)
                            End If
                        End If
                    Next
                Next
            End If
        Else
            For Each p As PACIENTE In context.PACIENTEs
                If Not p.CONOCIO Is Nothing Then
                    If p.NOMBRE.ToLower().Contains(nombre.ToLower()) And
                        ((p.APELLIDO1 Is Nothing) Or (Not p.APELLIDO1 Is Nothing AndAlso p.APELLIDO1.ToLower().Contains(pApellido.ToLower()))) And
                        ((p.APELLIDO2 Is Nothing) Or (Not p.APELLIDO2 Is Nothing AndAlso p.APELLIDO2.ToLower().Contains(sApellido.ToLower()))) And
                        ((FechaIni = "") Or (FechaIni <> "" AndAlso p.FECHAALTA >= FechaIni)) And
                        ((FechaFin = "") Or (FechaFin <> "" AndAlso p.FECHAALTA <= FechaFin)) Then
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
                    dTable = Me.PacientesconocioTableAdapter.GetData(nombre, If(pApellido <> "", pApellido, Nothing), If(sApellido <> "", sApellido, Nothing), c.Descripcion, If(dtp_fi.Checked, FechaIni, Nothing), If(dtp_ff.Checked, FechaFin, Nothing))
                    ListResult.Add("[" & dTable.Count & "] " & c.Descripcion)
                    dTable1.Merge(dTable, True)
                Next
            End If
        Else
            For Each a As ComoConocio In (From c In context.ComoConocios Select c Order By c.Descripcion).ToList()
                dTable = Me.PacientesconocioTableAdapter.GetData(nombre, If(pApellido <> "", pApellido, Nothing), If(sApellido <> "", sApellido, Nothing), a.Descripcion, If(dtp_fi.Checked, FechaIni, Nothing), If(dtp_ff.Checked, FechaFin, Nothing))
                ListResult.Add("[" & dTable.Count & "] " & a.Descripcion)
                dTable1.Merge(dTable, True)
            Next
        End If

        dView = dTable1.DefaultView
        LbResultados.Text = "Total: " & dTable1.Count()

    End Sub

    Private Sub CargarResultados()

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim list1 As Integer = 0
        If (ListResult.Count Mod 2) = 1 Then
            list1 = (ListResult.Count + 1) / 2
        Else
            list1 = ListResult.Count / 2
        End If
        For r As Integer = 0 To ListResult.Count - 1
            If r <= list1 - 1 Then
                ListBox1.Items.Add(ListResult.Item(r))
            Else
                ListBox2.Items.Add(ListResult.Item(r))
            End If
        Next
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
        If ListResult.Count > 0 Then ListResult.Clear()
        InicializaPacientesConocio()
        CargarResultados()
    End Sub

End Class