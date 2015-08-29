Imports centro_medico

Public Class ctrlEmpresa2

    Private _Empresa As centro_medico.EMPRESA
    Private _idpaciente As Nullable(Of Integer)


#Region "Public Property IDPACIENTE() As Nullable(Of Integer)"
    <System.ComponentModel.Browsable(True)> _
    Public Property IDPACIENTE() As Nullable(Of Integer)
        Get
            If _idpaciente.HasValue Then
                Return _idpaciente
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                _idpaciente = value
                Dim context As New centro_medico.CMLinqDataContext()
                EMPRESABindingSource.DataSource = From em In context.EMPRESAs _
                                         Join l In context.LEMPRESAs
                                         On l.REFEMPRESA Equals em.CEMPRESA
                                         Where l.REFPACIENTE = IDPACIENTE.Value And em.Eliminado.HasValue And em.Eliminado = False _
                                         Select em
            End If
        End Set
    End Property
#End Region

    <System.ComponentModel.Browsable(True)> _
    Public Property ID_Empresa() As Nullable(Of Integer)
        Get
            If Not comboEmpresas.SelectedItem Is Nothing Then
                Return comboEmpresas.SelectedItem.CEMPRESA
            Else
                Return Nothing
            End If

        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                comboEmpresas.SelectedItem = FindById(value.Value)
            Else
                comboEmpresas.SelectedItem = Nothing
            End If
        End Set
    End Property

    Public Function FindById(ByVal idEmpresa As Integer) As EMPRESA
        For Each item As EMPRESA In EMPRESABindingSource.List
            If item.CEMPRESA = idEmpresa Then
                Return item
            End If
        Next
        Return Nothing
    End Function
    '<System.ComponentModel.Browsable(True)> _
    'Public Property Empresa As EMPRESA
    '    Get
    '        Return _Empresa
    '    End Get

    '    Set(ByVal value As EMPRESA)
    '        _Empresa = value
    '        If Not value Is Nothing Then
    '            comboEmpresas.SelectedItem = value
    '        Else
    '            comboEmpresas.SelectedItem = Nothing
    '        End If
    '    End Set
    'End Property




    Private Sub ctrlEmpresa2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click
        comboEmpresas.SelectedItem = Nothing
        comboEmpresas.Text = "Seleccione empresa"
        ID_Empresa = Nothing
        _Empresa = Nothing
    End Sub
End Class
