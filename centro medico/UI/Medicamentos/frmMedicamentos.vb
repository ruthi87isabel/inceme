Imports Janus.Windows.GridEX
Public Class frmMedicamentos

    Public idMedicamentos As String

    Dim context As New CMLinqDataContext()
    Dim seleccionar As Boolean

    Public Sub New(Optional ByVal forSelect = False)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        seleccionar = forSelect
    End Sub
    Private Sub frmMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Medicamentos) = RoleManager.TipoPermisos.Ninguno Then
            MsgBox("Usted no tiene permiso para acceder a esta funcionalidad del programa")
            Me.Close()
            Exit Sub
        End If

        Me.tsbNuevo.Enabled = False
        Me.tsbEliminar.Enabled = False

        If (RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Medicamentos) = RoleManager.TipoPermisos.Total Or Globales.Usuario.EsAdministrador) Then
            Me.tsbNuevo.Enabled = True
            Me.tsbEliminar.Enabled = True
        End If
        CargarMedicamentos()
    End Sub

    Private Sub CargarMedicamentos()
        
        GridEXMedicamentos.DataSource = Nothing


        Dim _medicamentos = (From m In context.MEDICAMENTOs Select m)
        MEDICAMENTOBindingSource.DataSource = Nothing
        MEDICAMENTOBindingSource.DataSource = _medicamentos
        GridEXMedicamentos.DataSource = MEDICAMENTOBindingSource

    End Sub

    Private Sub GridEXMedicamentos_DoubleClick(sender As Object, e As EventArgs) Handles GridEXMedicamentos.DoubleClick
        If GridEXMedicamentos.SelectedItems.Count < 1 Then
            Return
        End If

        Dim Medicamento As MEDICAMENTO = GridEXMedicamentos.SelectedItems(0).GetRow.DataRow
        If Medicamento Is Nothing Then
            Exit Sub
        End If
        Me.idMedicamentos = Medicamento.CMEDICAMENTO
        If (seleccionar) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Dim frm As New form_medicamento("Edición de Medicamento", Enums.Accion.Modificar, Me.idMedicamentos)
            frm.ShowDialog()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            'Me.CargarMedicamentos()
        End If
    End Sub
    Private Sub CrearNuevo()
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Medicamentos) = RoleManager.TipoPermisos.Total Then
            Dim frm As New form_medicamento("Crear nuevo medicamento.", Enums.Accion.Insertar)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()


            Me.CargarMedicamentos()
        End If
    End Sub

    Private Sub Borrar()
        If Not RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Medicamentos) = RoleManager.TipoPermisos.Total Then
            MsgBox("No tiene permisos para realizar esta acción")
            Exit Sub
        End If
        Dim res As DialogResult = MsgBox("Se dispone a borrar los registros seleccionados. Esta acción no podrá deshacerse ¿Desea continuar?", MsgBoxStyle.YesNo)
        If (res = Windows.Forms.DialogResult.Yes) Then
            For Each item As GridEXRow In GridEXMedicamentos.GetCheckedRows
                'Dim a = item
                If item.DataRow.GetType Is GetType(MEDICAMENTO) Then
                    context.MEDICAMENTOs.DeleteOnSubmit(item.DataRow)
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Medicamentos, "Medicamento", item.DataRow.CMEDICAMENTO, "Se ha borrado un medicamento")
                End If

            Next
            Try
                context.SubmitChanges()
                Me.CargarMedicamentos()
            Catch ex As Exception
                Globales.ErrorMsg(ex, "Error al borrar medicamentos, puede que algunos de los elementos que quiere borrar estén siendo usados en recetas de pacientes")
            End Try
        End If
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        Me.CrearNuevo()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        Me.Borrar()
    End Sub

    Private Sub tsbModificar_Click(sender As Object, e As EventArgs) Handles tsbModificar.Click
        GridEXMedicamentos_DoubleClick(Nothing, Nothing)
    End Sub
End Class