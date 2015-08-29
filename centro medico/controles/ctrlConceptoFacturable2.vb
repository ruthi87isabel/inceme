Public Class ctrlConceptoFacturable2

    Public ConceptosFra As CONCEPTOSFRA = Nothing

    Public Event CONCEPTOSFRAEliminado(ByVal IdEliminado As String)
    Public Event CONCEPTOSFRASeleccionado(ByVal IdConceptosFra As String)
    Public Event ConceptosFraNoEncontrado()
    Public Event ConceptosSeleccionadoManualmente(ByVal IdConceptosFra As String)


    Private Sub ctrlConceptoFacturable2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


#Region " Private Sub Muestra()"
    Private Sub Muestra()
        Dim fullName As String = "Nombre es nulo!!"
        If Not ConceptosFra Is Nothing Then
            fullName = ConceptosFra.DESCRIPCION.Trim()
            txt_Codigo.Text = ConceptosFra.CODIGO
        End If
        txt_Nombre.Text = fullName
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
                If Not value.Trim Is "" Then
                    CargarConceptosFra(value)
                End If
            End If
        End Set
    End Property
#End Region


    Private Sub CargarConceptosFra(ByVal id As String)
        Dim context As New CMLinqDataContext()
        ConceptosFra = (From c In context.CONCEPTOSFRAs Where c.CODIGO = id Select c).SingleOrDefault
        If Not ConceptosFra Is Nothing Then
            Muestra()
            RaiseEvent CONCEPTOSFRASeleccionado(id)
           
        Else
            ConceptosFra = Nothing
            txt_Codigo.Text = String.Empty
            txt_Nombre.Text = String.Empty
            RaiseEvent ConceptosFraNoEncontrado()
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Dim frm As New frmListadoConceptos()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = DialogResult.OK Then
            CargarConceptosFra(frm.ConceptoFra.CODIGO)
            RaiseEvent ConceptosSeleccionadoManualmente(frm.ConceptoFra.CODIGO)
        End If
    End Sub


    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click
        Dim old As String = Nothing
        If Not ConceptosFra Is Nothing Then
            old = ConceptosFra.CODIGO

        End If
        ID_ConceptosFra = Nothing
        ConceptosFra = Nothing
        txt_Codigo.Text = String.Empty
        txt_Nombre.Text = String.Empty
        RaiseEvent CONCEPTOSFRAEliminado(old)
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

End Class
