Public Class ctrlMutuaPorPaciente

    Private _idpaciente As Nullable(Of Integer)
    Public Mutuas As MUTUA = Nothing
    Public Context As CMLinqDataContext

    Public Event MutuasSeleccionado(ByVal IdMutuas As Integer)


#Region "Public Property IDPACIENTE() As String"
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
                CargaDatos()
            Else
                Mutuas = Nothing
                txtCMutua.Text = String.Empty
                MUTUASBindingSource.Clear()
            End If
        End Set
    End Property
#End Region

#Region "Public PropertyID_Mutuas() As Nullable(Of Integer)"
    <System.ComponentModel.Browsable(True)> _
    Public Property ID_Mutuas() As Nullable(Of Integer)
        Get
            If MUTUASComboBox.SelectedIndex = -1 Then
                Return Nothing
            Else
                Mutuas = MUTUASComboBox.SelectedItem
                txtCMutua.Text = Mutuas.CMUTUA
                Return MUTUASComboBox.SelectedItem.CMUTUA
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                MUTUASComboBox.SelectedIndex = BuscaMutua(value)
                Mutuas = MUTUASComboBox.SelectedItem
                txtCMutua.Text = Mutuas.CMUTUA
            Else
                Mutuas = Nothing
                txtCMutua.Text = String.Empty
                MUTUASBindingSource.Clear()
            End If
        End Set
    End Property
#End Region

    Private Function BuscaMutua(ByVal cmutua As Integer) As Integer
        Dim i As Integer = 0
        For i = 0 To MUTUASComboBox.Items.Count - 1
            Dim mutua As MUTUA = MUTUASComboBox.Items(i)
            If mutua.CMUTUA = cmutua Then
                Return i
            End If
        Next
        Return -1
    End Function


    Private Sub CargaDatos()
        Context = New CMLinqDataContext
        Dim ids As List(Of Integer?) = (From id In Context.LMUTUAs Where id.REFPACIENTE = _idpaciente Select id.REFMUTUA).ToList()
        Dim mutuas As List(Of MUTUA) = (From m As MUTUA In Context.MUTUAs Where ids.Contains(m.CMUTUA) Select m).ToList()
        MUTUASBindingSource.DataSource = mutuas
    End Sub

    Private Sub MUTUASComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUTUASComboBox.SelectedIndexChanged
        If MUTUASComboBox.SelectedIndex <> -1 Then
            Mutuas = MUTUASComboBox.SelectedItem
            txtCMutua.Text = Mutuas.CMUTUA
            RaiseEvent MutuasSeleccionado(Mutuas.CMUTUA)
        Else
            Mutuas = Nothing
            txtCMutua.Text = String.Empty
        End If

    End Sub
End Class
