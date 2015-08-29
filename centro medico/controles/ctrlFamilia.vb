Public Class ctrlFamilia
    Public CONCEPTOSFAMILIA As CONCEPTOSFAMILIA = Nothing
   
    Public Event CONCEPTOFAMILIAeleccionado(ByVal IdCONCEPTOFAMILIA As String, ByVal IsReturnPressed As Boolean)
    Public Event CONCEPTOFAMILIAEliminado(ByVal IdCONCEPTOFAMILIAAnterior As String)
    Public Event CONCEPTOFAMILIANoEncontrado()


    Public Enum MostrarCategorias
        Todos
        Regulares
        Dentales
    End Enum

    Public Categorias As MostrarCategorias = MostrarCategorias.Todos


    Dim context As CMLinqDataContext

#Region "Public Function NombreCompleto() As String"
    Public Function NombreCompleto() As String
        Dim nombre As String = "Seleccione Familia"
        If Not CONCEPTOSFAMILIA Is Nothing Then
            nombre = CONCEPTOSFAMILIA.Descripcion
        End If
        Return nombre
    End Function
#End Region

#Region "Private Sub CargarCONCEPTOFAMILIA(ByVal id As Integer)"
    Private Sub CargarCONCEPTOFAMILIA(ByVal id As Integer, ByVal IsReturnPressed As Boolean)
        Try
            'table = adapter.GetCONCEPTOFAMILIAById(id)
            context = New CMLinqDataContext()
            CONCEPTOSFAMILIA = (From c In context.CONCEPTOSFAMILIAs Where c.IDFamilia = id Select c).SingleOrDefault

            If Not CONCEPTOSFAMILIA Is Nothing Then
                Muestra()
                RaiseEvent CONCEPTOFAMILIAeleccionado(id, IsReturnPressed)
            Else
                txt_Nombre.Text = "Familia no encontrada..."
                RaiseEvent CONCEPTOFAMILIANoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando familia")
        End Try
    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()

        Dim fullName As String = "Nombre es nulo!!"

        fullName = CONCEPTOSFAMILIA.Descripcion.Trim()

        txt_Codigo.Text = CONCEPTOSFAMILIA.IDFamilia
        txt_Nombre.Text = fullName

    End Sub
#End Region

    <System.ComponentModel.Browsable(True)> _
    Public Property ID_CONCEPTOFAMILIA() As Nullable(Of Integer)
        Get
            If CONCEPTOSFAMILIA Is Nothing Then
                Return Nothing
            Else
                Return CONCEPTOSFAMILIA.IDFamilia
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If Not value Is Nothing Then
                CargarCONCEPTOFAMILIA(value, False)
            End If
        End Set
    End Property

    Private Sub pb_SeleccionarCONCEPTOFAMILIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Dim frm As New frmFamiliaSelector()
        frm.Categorias = Me.Categorias

        If frm.ShowDialog() = DialogResult.OK Then
            CargarCONCEPTOFAMILIA(frm.Familia.IDFamilia, False)
        End If
    End Sub

    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click

        Dim oldValue As Nullable(Of Integer) = Me.ID_CONCEPTOFAMILIA

        Me.ID_CONCEPTOFAMILIA = Nothing
        Me.CONCEPTOSFAMILIA = Nothing
        Me.txt_Codigo.Text = String.Empty
        Me.txt_Nombre.Text = "Seleccione familia"

        If Not oldValue Is Nothing Then
            RaiseEvent CONCEPTOFAMILIAEliminado(oldValue)
        End If
    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            Try
                CargarCONCEPTOFAMILIA(Integer.Parse(txt_Codigo.Text), True)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        CargarCONCEPTOFAMILIA(Integer.Parse(txt_Codigo.Text), False)
    End Sub

End Class