Public Class ctrlConceptoFacturable
    Public ConceptosFra As CMDataSet.CONCEPTOSFRARow = Nothing
    Private table As CMDataSet.CONCEPTOSFRADataTable = New CMDataSet.CONCEPTOSFRADataTable()
    Private adapter As CMDataSetTableAdapters.CONCEPTOSFRATableAdapter = New CMDataSetTableAdapters.CONCEPTOSFRATableAdapter()

    Public Event CONCEPTOSFRAEliminado(ByVal IdEliminado As String)
    Public Event CONCEPTOSFRASeleccionado(ByVal IdConceptosFra As String)
    Public Event ConceptosFraNoEncontrado()

#Region "Public Function NombreCompleto() As String"
    Public Function NombreCompleto() As String
        Dim nombre As String = "Seleccione Concepto"
        If Not ConceptosFra Is Nothing Then

            nombre = ConceptosFra.DESCRIPCION
            
        End If
        Return nombre
    End Function
#End Region

#Region "Private Sub CargarConceptosFra(ByVal id As Integer)"
    Private Sub CargarConceptosFra(ByVal id As String)
        Try
            table = adapter.GetConceptoFraById(id)
            If table.Count > 0 Then
                ConceptosFra = table(0)
                Muestra()
                RaiseEvent CONCEPTOSFRASeleccionado(id)
            Else
                txt_Nombre.Text = "ConceptosFra no encontrado..."
                txt_Especialidad.Text = ""
                ConceptosFra = Nothing
                RaiseEvent ConceptosFraNoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando ConceptosFra")
        End Try
    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()
        Dim fullName As String = "Nombre es nulo!!"
        fullName = ConceptosFra.DESCRIPCION.Trim()
        txt_Codigo.Text = ConceptosFra.CODIGO
        txt_Nombre.Text = fullName
        txt_Especialidad.Text = ConceptosFra.IMPORTE.ToString("C2")
    End Sub
#End Region

#Region "Public Property ID_ConceptosFra() As String"
    <System.ComponentModel.Browsable(True)> _
   Public Property ID_ConceptosFra() As String
        Get
            If ConceptosFra Is Nothing Then
                Return Nothing
            Else
                Return ConceptosFra.CODIGO
            End If
        End Get
        Set(ByVal value As String)
            If Not value Is Nothing Then
                CargarConceptosFra(value)
            End If
        End Set
    End Property
#End Region

    Private Sub pb_SeleccionarConceptosFra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Dim frm As frmConceptosFRA = New frmConceptosFRA()
        Dim frm As New frmListadoConceptos()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = DialogResult.OK Then
            CargarConceptosFra(frm.ConceptoFra.CODIGO)
        End If
    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            Try
                CargarConceptosFra(txt_Codigo.Text)
                e.Handled = True
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        CargarConceptosFra(txt_Codigo.Text)
    End Sub

    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click
        Dim old As String = ID_ConceptosFra
        ConceptosFra = Nothing
        txt_Codigo.Text = ""
        txt_Nombre.Text = ""
        txt_Especialidad.Text = ""
        RaiseEvent CONCEPTOSFRAEliminado(old)
    End Sub
End Class