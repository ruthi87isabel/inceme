Imports centro_medico.UI.Reportes

Public Class form_bonos_no_agotados

    Dim _source As CMLinqDataContext

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        _source = New CMLinqDataContext()

    End Sub

    Private Sub form_bonos_no_agotados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicializaPacientesBonos()
    End Sub

    Private Sub InicializaPacientesBonos()
        Dim pacientes As List(Of PACIENTE) = New List(Of PACIENTE)()
        For Each p As PACIENTE In _source.PACIENTEs
            If p.TieneBonosNoAgotados Then
                pacientes.Add(p)
            End If
        Next
        PACIENTEBindingSource.DataSource = pacientes
    End Sub

    
    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub
End Class