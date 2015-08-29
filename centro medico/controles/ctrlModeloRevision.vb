Public Class ctrlModeloRevision

    Public ModeloRevision As MODELOSCOMPARATIVA = Nothing

    Private EmptyFont As Font = New Font("Microsoft Sans Serif", 7.25, FontStyle.Italic, GraphicsUnit.Point)
    Private SelectedFont As Font = New Font("Microsoft Sans Serif", 7.25, FontStyle.Regular, GraphicsUnit.Point)
    Private EmptyColor As Color = Color.DarkGray
    Private SelectedColor As Color = Color.Black



    Public Event ModeloRevisionSeleccionadoByBrowser(ByVal IdModeloRevision As String)
    Public Event ModeloRevisionSeleccionado(ByVal IdModeloRevision As String, ByVal IsReturnPressed As Boolean)
    Public Event ModeloRevisionSeleccionadoDeNuevo(ByVal IdModeloRevision As String)
    Public Event ModeloRevisionFichaAbierta(ByVal IdModeloRevision As String)
    Public Event ModeloRevisionEliminado(ByVal IdModeloRevision As String)
    Public Event ModeloRevisionNoEncontrado()

    Dim context As CMLinqDataContext


#Region "Private Sub CargarModeloRevision(ByVal id As Integer, ByVal IsReturnPressed As Boolean)"
    Private Sub CargarModeloRevision(ByVal id As String, ByVal IsReturnPressed As Boolean)
        Try

            context = New CMLinqDataContext()

            If Not id Is Nothing And Not id = "" Then
                ModeloRevision = (From m In context.MODELOSCOMPARATIVAs Where m.CODIGO = id Select m).SingleOrDefault()
            Else
                Return
            End If

            If Not ModeloRevision Is Nothing Then

                txt_Nombre.Font = SelectedFont
                txt_Nombre.ForeColor = SelectedColor
                Muestra()

                RaiseEvent ModeloRevisionSeleccionado(ModeloRevision.CODIGO, IsReturnPressed)
            Else
                txt_Nombre.Text = "Modelo Revision no encontrado..."
                txt_Nombre.Font = EmptyFont
                txt_Nombre.ForeColor = EmptyColor


                RaiseEvent ModeloRevisionNoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando Modelo revision")
        End Try
    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()

        'Dim fullName As String = "Nombre es nulo!!"

        txt_Codigo.Text = ModeloRevision.CODIGO
        txt_Nombre.Text = ModeloRevision.MODELO

    End Sub
#End Region

    <System.ComponentModel.Browsable(True)> _
    Public Property CODIGO() As String
        Get
            If ModeloRevision Is Nothing Then
                Return Nothing
            Else
                Return ModeloRevision.CODIGO
            End If
        End Get
        Set(ByVal value As String)
            If Not value Is Nothing Then
                CargarModeloRevision(value, False)
            End If
        End Set
    End Property

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            Try

                CargarModeloRevision(txt_Codigo.Text, True)
                If Not ModeloRevision Is Nothing Then
                    'Tiene valor
                    RaiseEvent ModeloRevisionSeleccionadoByBrowser(txt_Codigo.Text)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    'Private Sub txt_CP_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CP.KeyUp
    '    If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And ((txt_CP.Text.Length > 0) Or txt_Codigo.Text.Length > 0) Then
    '        e.Handled = True
    '        CargaModeloRevision(True)
    '        If ID_PACIENTE.HasValue Then
    '            'Tiene valor
    '            RaiseEvent ModeloRevisionSeleccionadoByBrowser(ID_PACIENTE)
    '        End If
    '    End If
    'End Sub


    'Private Sub txt_CP_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CP.Leave
    '    CargaModeloRevision(False)

    'End Sub

    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        CargarModeloRevision(txt_Codigo.Text, False)

    End Sub

    Private Sub ctrlModeloRevision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click

        Dim frm As New frmModelosRevisionesComparativas
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = DialogResult.OK Then
            CargarModeloRevision(frm.Modelo.CODIGO, False)
            RaiseEvent ModeloRevisionSeleccionadoByBrowser(frm.Modelo.CODIGO)
            Return
        End If

    End Sub




    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click

        Dim idEliminado As Nullable(Of Integer) = Me.CODIGO
        Me.CODIGO = Nothing
        Me.ModeloRevision = Nothing
        txt_Nombre.Text = "Seleccione paciente..."
        txt_Nombre.Font = EmptyFont
        txt_Nombre.ForeColor = EmptyColor
        txt_Codigo.Text = String.Empty
        'txt_CP.Text = String.Empty
        'lbl_DNI.Text = String.Empty
                'lblAsociado.Visible = False
        'lblBeneficiario.Visible = False
        If idEliminado.HasValue Then
            RaiseEvent ModeloRevisionEliminado(idEliminado)
        End If
    End Sub


End Class
