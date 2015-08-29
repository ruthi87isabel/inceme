Public Class ctrlPaciente3

    Public _paciente As PACIENTE
    Public Context As CMLinqDataContext

    Private Sub ctrlPaciente3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Public Property Paciente() As PACIENTE
        Get
            Return _paciente
        End Get
        Set(ByVal value As PACIENTE)
            _paciente = value
            PACIENTEBindingSource.DataSource = _paciente
        End Set
    End Property


End Class
