Imports centro_medico.UI.Reportes

Public Class frmRecetasListadoFiltrado


    Private filterList As New List(Of String)

    Private Sub frmRecetasListadoFiltrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fechaAntes.Value = Date.Now.AddMonths(-12)
        fechaDespues.Value = Date.Now
        Filtrar()
    End Sub



    Private Sub Filtrar()
        filterList.Clear()
        Dim context As New CMLinqDataContext()
        Dim fi As Date = New Date(fechaAntes.Value.Year, fechaAntes.Value.Month, fechaAntes.Value.Day, 0, 0, 0)
        Dim ff As Date = New Date(fechaDespues.Value.Year, fechaDespues.Value.Month, fechaDespues.Value.Day, 23, 59, 59)

        Dim recetas As IQueryable(Of RECETA) = (From c In context.RECETAs Where c.FECHA >= fi And c.FECHA <= ff And (Not c.Eliminado.HasValue Or c.Eliminado = False))

        filterList.Add(String.Format("Desde {0} hasta {1} ", fi.ToShortDateString(), ff.ToShortDateString()))

        If CtrlPaciente21.ID_PACIENTE.HasValue Then
            recetas = recetas.Where(Function(o) o.REFPACIENTE = CtrlPaciente21.ID_PACIENTE)
            filterList.Add(String.Format(" Paciente {0} ", CtrlPaciente21.Paciente.NombreCompleto))
        End If

        If CtrlMedico1.ID_Medico.HasValue Then
            recetas = recetas.Where(Function(o) o.REFMEDICO = CtrlMedico1.ID_Medico)
            filterList.Add(String.Format(" Médico {0} ", CtrlMedico1.Medico.NOMBRECOMPLETO))
        End If

        If CtrlDiagnosticos1.ID_DIAGNOSTICOS.HasValue Then
            recetas = recetas.Where(Function(o) o.REFDIAGNOSTICO = CtrlDiagnosticos1.ID_DIAGNOSTICOS)
            filterList.Add(String.Format(" Diagnóstico {0} ", CtrlDiagnosticos1.Diagnostico.DIAGNOSTICO))
        End If

        If CtrlMedicamento1.ID_Medicamento.HasValue Then
            recetas = recetas.Where(Function(o) o.REFMEDICAMENTO = CtrlMedicamento1.ID_Medicamento)
            filterList.Add(String.Format(" Medicamento {0} ", CtrlMedicamento1.Medicamento.DESCRIPCION))
        End If

        'recetas = recetas.ToList()

        RECETABindingSource.DataSource = recetas

    End Sub

    Private Sub bt_filtrar_Click(sender As Object, e As EventArgs) Handles bt_filtrar.Click
        Filtrar()
    End Sub




    Private Sub pb_AddDiagnostico_Click(sender As Object, e As EventArgs) Handles pb_AddDiagnostico.Click
        If CtrlMedicamento1.ID_Medicamento.HasValue Then
            'If Not GridMedicamentos.Find.Contains(CtrlMedicamento1.Medicamento) Then
            GridMedicamentos.AddItem(CtrlMedicamento1.Medicamento)

            'End If
        End If
    End Sub

    Private Sub pb_EliminarDiagnostico_Click(sender As Object, e As EventArgs) Handles pb_EliminarDiagnostico.Click
        If GridMedicamentos.SelectedItems.Count > 0 Then
            GridMedicamentos.SelectedItems(0).GetRow().Delete()
        End If
    End Sub

    Private Sub GridMedicamentos_SelectionChanged(sender As Object, e As EventArgs) Handles GridMedicamentos.SelectionChanged
        pb_AddDiagnostico.Enabled = GridMedicamentos.SelectedItems.Count > 0
    End Sub

    Private Sub bt_imprimir_Click(sender As Object, e As EventArgs) Handles bt_imprimir.Click

        Dim parametros(0) As Microsoft.Reporting.WinForms.ReportParameter
        Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource()
        rpt.Name = "CMDataSet_rpt_listadorecetas"
        rpt.Value = From c As RECETA In CType(RECETABindingSource.DataSource, IQueryable(Of RECETA))
                    Select New WRAPPER_RECETA(c, True)

        UI.Reportes.ReportesManager.Imprime("RecetasListado.rdlc", {rpt}, parametros)
    End Sub
End Class

'Public Class RecetaItem

'    Private _FECHA As Date
'    Public Property Fecha() As Date?
'        Get
'            Return _FECHA
'        End Get
'        Set(ByVal value As Date?)
'            _FECHA = value
'        End Set
'    End Property

'    Private _CPACIENTE As Integer?
'    Public Property CPACIENTE() As Integer?
'        Get
'            Return _CPACIENTE
'        End Get
'        Set(ByVal value As Integer?)
'            _CPACIENTE = value
'        End Set
'    End Property


'    Private _Tratamiento As String

'    Public Property Tratamiento() As String
'        Get
'            Return _Tratamiento
'        End Get
'        Set(ByVal value As String)
'            _Tratamiento = value
'        End Set
'    End Property

'    Private _CMEDICO As Integer?
'    Public Property CMEDICO() As Integer?
'        Get
'            Return _CMEDICO
'        End Get
'        Set(ByVal value As Integer?)
'            _CMEDICO = value
'        End Set
'    End Property

'    Private _Medico As String
'    Public Property Medico() As String
'        Get
'            Return _Medico
'        End Get
'        Set(ByVal value As String)
'            _Medico = value
'        End Set
'    End Property

'    Private _Paciente As String
'    Public Property Paciente() As String
'        Get
'            Return _Paciente
'        End Get
'        Set(ByVal value As String)
'            _Paciente = value
'        End Set
'    End Property

'    Private _codDiagnostico As Integer?
'    Public Property CodDiagnostico() As Integer?
'        Get
'            Return _codDiagnostico
'        End Get
'        Set(ByVal value As Integer?)
'            _codDiagnostico = value
'        End Set
'    End Property

'    Private _Diagnostico As String
'    Public Property Diagnostico() As String
'        Get
'            Return _Diagnostico
'        End Get
'        Set(ByVal value As String)
'            _Diagnostico = value
'        End Set
'    End Property


'    Private _CodMedicamento As String
'    Public Property CodMedicamento() As String
'        Get
'            Return _CodMedicamento
'        End Get
'        Set(ByVal value As String)
'            _CodMedicamento = value
'        End Set
'    End Property


'    Private _Medicamento As String
'    Public Property Medicamento() As String
'        Get
'            Return _Medicamento
'        End Get
'        Set(ByVal value As String)
'            _Medicamento = value
'        End Set
'    End Property




'End Class