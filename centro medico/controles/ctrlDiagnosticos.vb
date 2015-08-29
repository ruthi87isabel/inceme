Public Class ctrlDiagnosticos
    Public Diagnostico As DIAGNOSTICO = Nothing

    Public Event DIAGNOSTICOSSeleccionado(ByVal IdDIAGNOSTICOS As Integer)
    Public Event DIAGNOSTICOSNoEncontrado()
    Public Event DIAGNOSTICOSEliminada(ByVal IdDIAGNOSTICOS As Integer)

    Public Context As CMLinqDataContext

#Region "Public Function NombreCompleto() As String"
    Public Function NombreCompleto() As String
        Dim nombre As String = "Seleccione diagnóstico"
        If Not Diagnostico Is Nothing And Not Diagnostico.DIAGNOSTICO Is Nothing Then
            nombre = Diagnostico.DIAGNOSTICO
        End If
        Return nombre
    End Function
#End Region

#Region "Private Sub CargarDIAGNOSTICOS(ByVal id As Integer)"
    Private Sub CargarDIAGNOSTICOS(ByVal id As Integer)
        Try
            Context = New CMLinqDataContext

            Diagnostico = Context.DIAGNOSTICOs.Where(Function(o) o.IDDIAGNOSTICO = id).SingleOrDefault()

            If Not Diagnostico Is Nothing Then
                Muestra()
                RaiseEvent DIAGNOSTICOSSeleccionado(id)
            Else

                txt_Nombre.Text = "Diagnóstico no encontrado..."
                'txt_Especialidad.Text = ""
                ID_DIAGNOSTICOS = Nothing
                RaiseEvent DIAGNOSTICOSNoEncontrado()
            End If

        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando DIAGNOSTICOS")
        End Try
    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()
        Dim fullName As String = "Nombre es nulo!!"

        txt_Codigo.Text = Diagnostico.IDDIAGNOSTICO
        txt_Nombre.Text = NombreCompleto()
        'txt_Especialidad.Text = DIAGNOSTICOS.Importe.ToString("C2")
    End Sub
#End Region

#Region "Public Property ID_DIAGNOSTICOS() As String"
    <System.ComponentModel.Browsable(True)> _
   Public Property ID_DIAGNOSTICOS() As Nullable(Of Integer)
        Get
            If Diagnostico Is Nothing Then
                Return Nothing
            Else
                Return Diagnostico.IDDIAGNOSTICO
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarDIAGNOSTICOS(value)
            End If
        End Set
    End Property
#End Region

    Private Sub pb_SeleccionarDIAGNOSTICOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Dim frm As frmDIAGNOSTICOS = New frmDIAGNOSTICOS()
        'frm.Modo = Globals.ModoParaFormas.Seleccion
        'If frm.ShowDialog() = DialogResult.OK Then
        '    CargarDIAGNOSTICOS(frm.Mutua.IdMutua)
        'End If

        Dim frm As New frmDiagnosticos()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CargarDIAGNOSTICOS(frm.Diagnostico.IDDIAGNOSTICO)
        End If



    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            Try
                CargarDIAGNOSTICOS(Integer.Parse(txt_Codigo.Text))
                e.Handled = True
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        Try
            CargarDIAGNOSTICOS(Integer.Parse(txt_Codigo.Text))
        Catch ex As Exception
            'CargarDIAGNOSTICOS(-1)
        End Try
    End Sub

    Private Sub ctrlDIAGNOSTICOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Codigo.Focus()
    End Sub

    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click

        If ID_DIAGNOSTICOS.HasValue Then
            RaiseEvent DIAGNOSTICOSEliminada(ID_DIAGNOSTICOS)
        End If

        ID_DIAGNOSTICOS = Nothing
        Diagnostico = Nothing
        txt_Codigo.Text = String.Empty
        txt_Nombre.Text = String.Empty
        'txt_Especialidad.Text = ""

    End Sub


   
End Class