Imports Janus.Windows.GridEX
Imports centro_medico.UI.Reportes

Public Class frmMedicosListado

    Public Shadows WithEvents GridEx1 As GridEX

    Public IDMEDICO As Nullable(Of Integer)

    Dim modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion

    Sub New(modo As Globales.ModoParaFormas)
        '
        InitializeComponent()
        '
        Me.modo = modo
        For Each cExt As GridEXColumn In GridEx1.RootTable.Columns
            OriginalColumns.Add(cExt)
        Next
    End Sub

    Private Sub bt_filtrar_Click(sender As System.Object, e As System.EventArgs) Handles bt_filtrar.Click
        PopulateGrid()
    End Sub


    Protected Overrides Sub PopulateGrid()
        Dim content As New CMLinqDataContext

        Dim query As IQueryable(Of MEDICO) = content.MEDICOs.AsQueryable().Where(Function(m) Not m.Eliminado.HasValue Or m.Eliminado = False)

        If medicoDesde.Id > 0 And medicoHasta.Id > 0 Then
            query = query.Where(Function(m) m.CMEDICO >= medicoDesde.Id And m.CMEDICO <= medicoHasta.Id)
        End If

        If (Not String.IsNullOrEmpty(txtNombre.Text)) Then
            query = query.Where(Function(m) m.NOMBRE.Contains(txtNombre.Text))
        End If

        If (Not String.IsNullOrEmpty(txtEspecialidad.Text)) Then
            query = query.Where(Function(m) m.ESPECIALIDAD.Contains(txtEspecialidad.Text))
        End If

        If (Not String.IsNullOrEmpty(txtNoColegio.Text)) Then
            query = query.Where(Function(m) m.COLEGIADO.Contains(txtNoColegio.Text))
        End If

        MEDICOBindingSource.DataSource = query

        '_GridEx = GridEX1
    End Sub

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        'Dim _nuevo_medico As form_medico = New form_medico("Ficha del Médico-Añadir", Enums.Accion.Insertar)
        '_nuevo_medico.ShowInTaskbar = False
        '_nuevo_medico.ShowDialog()
        'PopulateGrid()

        Dim frm As New frmMedicos_ADD()
        frm.Accion = Enums.Accion.Insertar
        'frm.Medico = New MEDICO()


        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Medicos, "Medico ", frm.Medico.CMEDICO, frm.Medico.NOMBRECOMPLETO)
            Catch ex As Exception
            End Try
            PopulateGrid()
        End If

    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEx1.RowDoubleClick
        If modo = Globales.ModoParaFormas.Seleccion Then
            Me.IDMEDICO = CType(MEDICOBindingSource.Current, MEDICO).CMEDICO
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Return
        End If
        EditarMedico()
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        EditarMedico()
    End Sub

    Private Sub EditarMedico()
        'Dim _nuevo_medico As form_medico = New form_medico("Ficha del Médico-Añadir", Enums.Accion.Modificar, CType(MEDICOBindingSource.Current, MEDICO).CMEDICO)
        '_nuevo_medico.ShowInTaskbar = False
        '_nuevo_medico.ShowDialog()
        'PopulateGrid()

        Try

            If tst_Editar.Enabled And tst_Editar.Visible Then
                Dim frm As New frmMedicos_ADD()
                frm.Accion = Enums.Accion.Modificar
                'frm.Context = Globales.Context
                Dim idmedico As Integer = CType(MEDICOBindingSource.Current, MEDICO).CMEDICO
                frm.idMedico = idmedico
                'frm.Medico = (From m In Context.MEDICOs Where m.CMEDICO = idmedico Select m).SingleOrDefault()
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Try
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Medicos, "Medico ", frm.Medico.CMEDICO, frm.Medico.NOMBRECOMPLETO)
                    Catch ex As Exception
                    End Try


                    PopulateGrid()
                End If
            Else
                MessageBox.Show("No tiene permiso para editar médicos")
                Return
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Try
            If MessageBox.Show("Está seguro eliminar este médico?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim context As New CMLinqDataContext

                Dim idBorrar As Integer = CType(MEDICOBindingSource.Current, MEDICO).CMEDICO
                Dim medico As MEDICO = (From m In context.MEDICOs Where m.CMEDICO = idBorrar Select m).SingleOrDefault


                ''Borrar  calendarios
                Dim calendarios As List(Of CALENDARIO_MEDICO) = (From c In context.CALENDARIO_MEDICOs Where c.ID_MEDICO = idBorrar Select c).ToList()
                context.CALENDARIO_MEDICOs.DeleteAllOnSubmit(calendarios)
                ''context.SubmitChanges()

                'Dim nombre As String = context.MEDICOs.FirstOrDefault(Function(m) m.CMEDICO = idBorrar).NOMBRECOMPLETO
                'context.MEDICOs.DeleteOnSubmit(context.MEDICOs.FirstOrDefault(Function(m) m.CMEDICO = idBorrar))

                medico.Eliminado = True
                context.SubmitChanges()

                Try
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Medicos, "Medico ", idBorrar, medico.NOMBRECOMPLETO)
                Catch ex As Exception
                End Try

                PopulateGrid()
            End If

        Catch ex As Exception
            MessageBox.Show(String.Format("El médico {0} no puede ser eliminado pues se encuentra en uso por la aplicación", CType(MEDICOBindingSource.Current, MEDICO).NOMBRE))
        End Try

    End Sub

    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEx1.SelectionChanged
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True
    End Sub

    Private Sub btnConfigGrid_Click(sender As System.Object, e As System.EventArgs) Handles btnConfigGrid.Click
        Configure()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each cExt As GridEXColumn In GridEx1.RootTable.Columns
            OriginalColumns.Add(cExt)
        Next

    End Sub

    Private Sub frmConceptoFacturableListado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateGrid()
        AplicaPermisos()
    End Sub

    Private Sub AplicaPermisos()
        'Permisos de acceso
        Dim apermiso As Integer = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Medicos)
        tst_Eliminar.Visible = apermiso > RoleManager.TipoPermisos.Lectura
        tstNuevo.Visible = apermiso > RoleManager.TipoPermisos.Lectura
        tst_Editar.Visible = apermiso > RoleManager.TipoPermisos.Lectura
    End Sub

    Private Sub tlbImprimir_Click(sender As System.Object, e As System.EventArgs) Handles tlbImprimir.Click

        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "CMDataSet_MEDICOS"
        ds.Value = MEDICOBindingSource.DataSource

        UI.Reportes.ReportesManager.Imprime("MedicosListado.rdlc", {ds})
        Try
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Imprimir, RoleManager.Items.Medicos, "Listado de Médicos", "", "")
        Catch ex As Exception
        End Try


    End Sub

    Private Sub GridEx1_FormattingRow(sender As Object, e As RowLoadEventArgs) Handles GridEx1.FormattingRow
        If e.Row.RowType = RowType.Record Then
            Dim medico As MEDICO = e.Row.DataRow
            If Not medico.DNI Is Nothing Then
                e.Row.Cells("DNI").Text = medico.DNI & Globales.GetLetter(medico.DNI)
            End If
        End If
    End Sub
End Class