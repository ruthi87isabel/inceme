Imports centro_medico.UI.Recetas
Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Reportes

Public Class frmRecetas

    Public IDPACIENTE As Integer
    Dim EditarEliminar As Boolean

    Sub New(IDPACIENTE As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IDPACIENTE = IDPACIENTE
    End Sub

    Private Sub frmRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CtrlPacienteReceta.ID_PACIENTE = Me.IDPACIENTE
        EditarEliminar = True

        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Recetas) <= RoleManager.TipoPermisos.Lectura Then
            Me.tst_Editar.Enabled = False
            Me.tstNuevo.Enabled = False
            Me.tst_Eliminar.Enabled = False
            EditarEliminar = False
        End If

        If Globales.Usuario.REFMEDICO.HasValue Then
            CtrlMedico1.ID_Medico = Globales.Usuario.REFMEDICO
            If Not Globales.Usuario.EsAdministrador() Then
                'Si es medico pero no es admin se le bloquea el filtro de medicos
                CtrlMedico1.Enabled = False
            End If
        End If

        CargarDatos()
    End Sub

    Private Sub CargarDatos()
        GridEXRecetas.DataSource = Nothing
        Dim context As New CMLinqDataContext()
        Dim _recetas As IQueryable(Of RECETA) = (From r In context.RECETAs Where r.REFPACIENTE = Me.IDPACIENTE And (Not r.Eliminado.HasValue Or r.Eliminado = False) Select r)

        If Not Me.CtrlMedico1.ID_Medico Is Nothing Then
            _recetas = (From r In _recetas Where r.REFMEDICO = Me.CtrlMedico1.ID_Medico Select r)
        End If

        If fechaAntes.Checked Then
            _recetas = (From r In _recetas Where r.FECHA >= Me.fechaAntes.Value Select r)
        End If
        If fechaDespues.Checked Then
            _recetas = (From r In _recetas Where r.FECHA <= Me.fechaDespues.Value Select r)
        End If


        RECETABindingSource.DataSource = _recetas
        GridEXRecetas.DataSource = RECETABindingSource

    End Sub

    Private Sub GridEXRecetas_SelectionChanged(sender As Object, e As EventArgs) Handles GridEXRecetas.SelectionChanged
        If GridEXRecetas.SelectedItems.Count < 1 Then
            Me.tst_Editar.Enabled = False
            Me.tst_Eliminar.Enabled = False
            Return
        End If
        Me.tst_Editar.Enabled = EditarEliminar
        Me.tst_Eliminar.Enabled = EditarEliminar

        Dim _receta As RECETA = GridEXRecetas.SelectedItems(0).GetRow.DataRow
        Me.tb_reTratamiento.Text = _receta.TRATAMIENTO
    End Sub

    Private Sub tstNuevo_Click(sender As Object, e As EventArgs) Handles tstNuevo.Click


        'La receta se crea oculta, se inserta y se abre para edicion
        'si se salva se desoculta


        Dim newContext As New CMLinqDataContext()

        Dim _receta As New RECETA()
        _receta.Eliminado = False
        _receta.REFPACIENTE = Me.IDPACIENTE
        _receta.Eliminado = True


        newContext.RECETAs.InsertOnSubmit(_receta)
        newContext.SubmitChanges()

        Dim frm As New frmRecetas_Editar(_receta, newContext)
        Dim res As DialogResult
        frm.ShowInTaskbar = False
        frm.CtrlPacienteReceta.Enabled = False
        res = frm.ShowDialog

        If (res = Windows.Forms.DialogResult.OK) Then
            _receta.Eliminado = False
            newContext.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Recetas, "Receta", _receta.IDRECETA.ToString(), " paciente:  " & _receta.PACIENTE.NombreCompleto & " médico" & _receta.MEDICO.NOMBRECOMPLETO & " medicamento principal :" & _receta.MEDICAMENTO.DESCRIPCION)
            CargarDatos()
        Else
            'ocultar
            _receta.TRATAMIENTO = "RECETA CANCELADA POR EL USUARIO"
            _receta.Eliminado = True

            newContext.SubmitChanges()

            'compruebo si hay vinculada una recetaxml y la desvinculo
            'Dim rxml As New recetaXML
            'rxml.DesvinculaReceta(_receta.IDRECETA)
        End If
    End Sub

    Private Sub tst_Editar_Click(sender As Object, e As EventArgs) Handles tst_Editar.Click
        If GridEXRecetas.SelectedItems.Count < 1 Then
            Return
        End If

        Dim _receta As RECETA = GridEXRecetas.SelectedItems(0).GetRow.DataRow

        Dim context As New CMLinqDataContext()
        _receta = (From r In context.RECETAs Where r.IDRECETA = _receta.IDRECETA Select r).First()

        Dim frm As New frmRecetas_Editar(_receta, context)
        frm.ShowInTaskbar = False
        frm.CtrlPacienteReceta.Enabled = False
        If Not _receta.FECHA Is Nothing Then
            frm.DateTimeFecha.Value = _receta.FECHA
        End If
        If Not _receta.HORA Is Nothing Then
            frm.DateTimeHora.Value = _receta.HORA
        End If

        Dim res As DialogResult = frm.ShowDialog
        If (res = Windows.Forms.DialogResult.OK) Then
            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Recetas, "Receta", _receta.IDRECETA.ToString(), " paciente:  " & _receta.PACIENTE.NombreCompleto & " médico" & _receta.MEDICO.NOMBRECOMPLETO & " medicamento principal :" & _receta.MEDICAMENTO.DESCRIPCION)
            CargarDatos()
            Return
        Else
            If (res = Windows.Forms.DialogResult.Cancel) Then

            End If
        End If
    End Sub

    Private Sub tst_Eliminar_Click(sender As Object, e As EventArgs) Handles tst_Eliminar.Click
        If GridEXRecetas.SelectedItems.Count < 1 Then
            Return
        End If

        Dim result As MsgBoxResult = MessageBox.Show("Desea eliminar la receta", "confirmar borrado", MessageBoxButtons.YesNo)
        If result = MsgBoxResult.No Then
            Return
        End If
        Try
            Dim _receta As RECETA = GridEXRecetas.SelectedItems(0).GetRow.DataRow
            Dim context As New CMLinqDataContext()
            _receta = (From r In context.RECETAs Where r.IDRECETA = _receta.IDRECETA Select r).First()

            'context.RECETAs.DeleteOnSubmit(_receta)
            _receta.Eliminado = True
            context.SubmitChanges()
            Try
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Recetas, "Receta", _receta.IDRECETA.ToString(), " paciente:  " & _receta.PACIENTE.NombreCompleto & " médico" & _receta.MEDICO.NOMBRECOMPLETO & " medicamento principal :" & _receta.MEDICAMENTO.DESCRIPCION)
            Catch ex As Exception
                MessageBox.Show("No se pudo auditar correctamente por inconsistencia en los datos de la receta")
            End Try
            CargarDatos()
        Catch
            MessageBox.Show("la receta esta siendo utilizada por otras dependencias en estos momentos")
        End Try
    End Sub


    Private Sub fechaDespues_ValueChanged_1(sender As Object, e As EventArgs) Handles fechaDespues.ValueChanged
        CargarDatos()
    End Sub

    Private Sub fechaAntes_ValueChanged(sender As Object, e As EventArgs) Handles fechaAntes.ValueChanged
        CargarDatos()
    End Sub

    Private Sub GridEXRecetas_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXRecetas.RowDoubleClick
        Me.tst_Editar_Click(Nothing, Nothing)
    End Sub

    Private Sub CtrlMedico1_MEDICOEliminado(ByVal IdMedicoAnterior As Integer) Handles CtrlMedico1.MEDICOEliminado
        CargarDatos()
    End Sub

    Private Sub CtrlMedico1_MEDICOSeleccionado(ByVal IdMedico As System.Int32, ByVal oldMedico As System.Nullable(Of Integer), ByVal IsReturnPressed As System.Boolean) Handles CtrlMedico1.MEDICOSeleccionado
        CargarDatos()
    End Sub

    Private Function Validar(_receta As RECETA) As Boolean
        If _receta.REFMEDICAMENTO Is Nothing Then
            Return False
        End If
        If _receta.REFPACIENTE Is Nothing Then
            Return False
        End If
        If _receta.REFMEDICO Is Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click
        If GridEXRecetas.SelectedItems.Count < 1 Then
            Me.tst_Editar.Enabled = False
            Me.tst_Eliminar.Enabled = False
            Return
        End If

        Dim tmp As RECETA = GridEXRecetas.SelectedItems(0).GetRow.DataRow
        If Not Validar(tmp) Then
            MessageBox.Show("Para ser impresa la receta tiene que tener paciente, médico y un medicamento principal.")
            Return
        End If

        Dim rep As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsPaciente As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsMedico As New Microsoft.Reporting.WinForms.ReportDataSource

        dsPaciente.Name = "dsPaciente"
        rep.Name = "CMDataSet_rpt_Recetas"
        dsMedico.Name = "dsMedico"

        Dim pacientes As New List(Of WRAPPER_PACIENTE)

        Dim recetas As New List(Of WRAPPER_RECETA)
        recetas.Add(New WRAPPER_RECETA(tmp, False))
        rep.Value = recetas

        Dim medicos As New List(Of MEDICO)
        medicos.Add(tmp.MEDICO)
        dsMedico.Value = medicos

        
       
        Dim rayParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        'parametros NombreEmpresa y Mutua

        Dim paciente As WRAPPER_PACIENTE = New WRAPPER_PACIENTE(tmp.PACIENTE)

        Dim frm As New frmRecetas_Imprimir(tmp.PACIENTE)
        frm.ShowInTaskbar = False
        frm.ShowIcon = False

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'paciente = New PACIENTE()
            'paciente.NOMBRE = tmp.PACIENTE.NOMBRE
            'paciente.APELLIDO1 = tmp.PACIENTE.APELLIDO1
            'paciente.APELLIDO2 = tmp.PACIENTE.APELLIDO2

            'If Not rpt_parameters.Item("param_nomMutua") Is Nothing Then
            If frm.UiCheckBoxMutua.Enabled And frm.UiCheckBoxMutua.Checked Then
                If Not tmp.PACIENTE.MUTUA Is Nothing Then
                    If Not tmp.PACIENTE.MUTUA.NOMBRE Is Nothing Then
                        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_nomMutua", tmp.PACIENTE.MUTUA.NOMBRE))
                    End If
                End If
            End If
            'End If
            'If Not rpt_parameters.Item("param_nomEmpresa") Is Nothing Then
            If frm.UiCheckBoxEmpresa.Enabled And frm.UiCheckBoxEmpresa.Checked Then
                If Not tmp.PACIENTE.EMPRESA Is Nothing Then
                    If Not tmp.PACIENTE.EMPRESA.NOMBRE Is Nothing Then
                        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_nomEmpresa", tmp.PACIENTE.EMPRESA.NOMBRE))
                    End If
                End If
            End If
            'End If
        Else
            Return
        End If


        pacientes.Add(paciente)
        dsPaciente.Value = pacientes

        ' If Not rpt_parameters.Item("param_NIE") Is Nothing Then
        If tmp.PACIENTE.NIE Is Nothing Then
            rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_NIE", ""))
        Else
            rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_NIE", tmp.PACIENTE.NIE))
        End If
        'End If

        Dim medico As MEDICO = tmp.MEDICO

        If Not medico Is Nothing Then
            If Not medico.FIRMA Is Nothing Then

                'If Not _print.ReportViewer.LocalReport.GetParameters("FirmaMedicoPath") Is Nothing Then
                Dim myImage As Byte() = medico.FIRMA.ToArray

                Dim imgMemoryStream As New IO.MemoryStream(myImage)
                Dim bitmap As Bitmap = New Bitmap(imgMemoryStream)


                Dim paramLogo As ReportParameter = New ReportParameter()
                paramLogo.Name = "FirmaMedicoPath"
                'paramLogo.Values.Add(@"file:///C:\Users\Mike\AppData\Local\Temp\Logo.png")
                'Salvar la imagen en una direccion temporal

                Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\temp.jpg"

                bitmap.Save(filename)

                paramLogo.Values.Add("file:///" & filename)
                rayParam.Add(paramLogo)
                'End If

            End If
        End If

        If tmp.EsRecetaOficial.HasValue Then
            If Not tmp.EsRecetaOficial.Value Then

                UI.Reportes.ReportesManager.Imprime("Receta.rdlc", {rep, dsPaciente, dsMedico}, rayParam.ToArray)
            Else
                UI.Reportes.ReportesManager.Imprime("RecetaOficial.rdlc", {rep, dsPaciente, dsMedico}, rayParam.ToArray)

            End If
        Else
            UI.Reportes.ReportesManager.Imprime("Receta.rdlc", {rep, dsPaciente, dsMedico}, rayParam.ToArray)
        End If
    End Sub




End Class