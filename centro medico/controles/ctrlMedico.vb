Imports centro_medico.CMDataSet

Public Class ctrlMedico

    Public Medico As MEDICO = Nothing
    'Private table As CMDataSet.MEDICOSDataTable = New CMDataSet.MEDICOSDataTable()
    'Private adapter As CMDataSetTableAdapters.MEDICOSTableAdapter = New CMDataSetTableAdapters.MEDICOSTableAdapter()

    Public Event MEDICOSeleccionado(ByVal IdMedico As Integer, ByVal oldMedico As Nullable(Of Integer), ByVal IsReturnPressed As Boolean)
    Public Event MEDICOEliminado(ByVal IdMedicoAnterior As Nullable(Of Integer))
    Public Event MedicoNoEncontrado()

#Region "Private Sub CargarMedico(ByVal id As Integer)"
    Private Sub CargarMedico(ByVal id As Integer, ByVal IsReturnPressed As Boolean)
        Try
            Dim context As New CMLinqDataContext()
            Medico = (From m In context.MEDICOs Where m.CMEDICO = id Select m).SingleOrDefault
            If Not Medico Is Nothing Then
                Muestra()
            Else
                txt_Nombre.Text = "Medico no encontrado..."
                txt_Especialidad.Text = String.Empty
                RaiseEvent MedicoNoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando Medico")
        End Try
    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()

        txt_Codigo.Text = Medico.CMEDICO
        txt_Nombre.Text = Medico.NOMBRECOMPLETO
        If (Medico.Eliminado = True) Then
            txt_Nombre.Text = "**Eliminado**" & txt_Nombre.Text
        End If
        If Not Medico.ESPECIALIDAD Is Nothing Then
            txt_Especialidad.Text = Medico.ESPECIALIDAD
        End If
    End Sub
#End Region

    <System.ComponentModel.Browsable(True)> _
   Public Property ID_Medico() As Nullable(Of Integer)
        Get
            If Medico Is Nothing Then
                Return Nothing
            Else
                Return Medico.CMedico
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarMedico(value, False)
            End If
        End Set
    End Property

    Private Sub pb_SeleccionarMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Dim oldMedico As Nullable(Of Integer) = Me.ID_Medico
        'Dim frm As form_medicos = New form_medicos()
        'If frm.ShowDialog() = DialogResult.OK Then
        '    CargarMedico(frm.MEDICO.CMEDICO, False)
        '    If Not Me.Medico Is Nothing Then
        '        If oldMedico = Medico.CMEDICO Then
        '            oldMedico = Nothing
        '        End If
        '        RaiseEvent MEDICOSeleccionado(frm.MEDICO.CMEDICO, oldMedico, False)
        '    End If
        'End If

        Dim frm As New frmMedicosListado(Globales.ModoParaFormas.Seleccion)
        If frm.ShowDialog() = DialogResult.OK Then
            If frm.IDMEDICO.HasValue Then
                Dim oldMedico As Nullable(Of Integer) = Me.ID_Medico
                CargarMedico(frm.IDMEDICO, False)
                If Not Me.Medico Is Nothing Then
                    If oldMedico = Medico.CMEDICO Then
                        oldMedico = Nothing
                    End If
                    RaiseEvent MEDICOSeleccionado(frm.IDMEDICO, oldMedico, False)
                End If
            End If
        End If
        GC.Collect()
        If Not frm.IsDisposed Then frm.Dispose()
    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            Try
                Dim oldMedico As Nullable(Of Integer) = Me.ID_Medico
                Dim id As Integer = Integer.Parse(txt_Codigo.Text)
                CargarMedico(id, True)
                If Not Me.Medico Is Nothing Then
                    If oldMedico = Medico.CMEDICO Then
                        oldMedico = Nothing
                    End If
                    RaiseEvent MEDICOSeleccionado(id, oldMedico, False)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        Try
            'Dim oldMedico As Nullable(Of Integer) = ID_Medico
            Dim oldMedico As Nullable(Of Integer) = Me.ID_Medico
            Dim cmedico As Integer = Integer.Parse(txt_Codigo.Text)
            CargarMedico(cmedico, False)
            If Not Me.Medico Is Nothing Then
                If oldMedico = Medico.CMEDICO Then
                    oldMedico = Nothing
                End If
                RaiseEvent MEDICOSeleccionado(cmedico, oldMedico, False)
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click

        Dim oldMEdico As Nullable(Of Integer) = Nothing
        If Me.ID_Medico.HasValue Then
            oldMEdico = Me.ID_Medico
        End If

        Me.ID_Medico = Nothing
        Me.Medico = Nothing
        Me.txt_Codigo.Text = String.Empty
        Me.txt_Nombre.Text = "Seleccione medico"
        Me.txt_Especialidad.Text = String.Empty

        If Not oldMEdico Is Nothing Then
            RaiseEvent MEDICOEliminado(oldMEdico)
        End If

        
    End Sub

   
End Class