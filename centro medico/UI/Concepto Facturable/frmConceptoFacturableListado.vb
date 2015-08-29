Imports Janus.Windows.GridEX

Public Class frmConceptoFacturableListado

    Public IdPaciente As Integer
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public ConceptoFacturable As CONCEPTOSFACTURABLE


    Private Sub frmConceptoFacturableListado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateGrid()
        AplicaPermisos()
    End Sub

    Private Sub AplicaPermisos()
        'dtg_cfConceptosFacturables.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > RoleManager.TipoPermisos.Lectura)
        'dtg_cfConceptosFacturables.ReadOnly = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Servicios_Periodicos) > 2)
        'nv_cfConceptosFacturables.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Servicios_Periodicos) > 3)
        tstNuevo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Servicios_Periodicos) > 2)
        tst_Eliminar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Servicios_Periodicos) > 3)
        tst_Editar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Servicios_Periodicos) > 2)
    End Sub

    Public Overrides Sub Configure()

        Dim frmConfig As New frmConfiguracionColumnasJanusGridEx()
        frmConfig.Columnas = Me.OriginalColumns
        frmConfig.RootTable = Me.GridEX1.RootTable

        If (frmConfig.ShowDialog() = DialogResult.OK) Then
            Me.GridEX1.RootTable = frmConfig.RootTable
            PopulateGrid()
        End If

    End Sub

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        'Dim frm As New form_conceptos_facturables("Ficha de Conceptos Facturables-Añadir", Enums.Accion.Insertar)
        'frm.ShowDialog()

        Dim context As New CMLinqDataContext
        Dim conceptoF As New CONCEPTOSFACTURABLE
        conceptoF.REFPACIENTE = IdPaciente

        Dim frm As New frmConceptoFacturable_ADD
        frm.ConceptoFacturable = conceptoF
        frm.CurrentAccion = Enums.Accion.Insertar
        If frm.ShowDialog() = DialogResult.OK Then
            context.CONCEPTOSFACTURABLEs.InsertOnSubmit(conceptoF)
            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Servicios_Periodicos, "Conceptp Facturable", conceptoF.ID, conceptoF.DESCRIPCION)
            PopulateGrid()
        End If
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        Editar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Try
            Dim content As New CMLinqDataContext
            Dim conceptoF As CONCEPTOSFACTURABLE = CType(CONCEPTOSFACTURABLEBindingSource.Current, CONCEPTOSFACTURABLE)
            content.CONCEPTOSFACTURABLEs.DeleteOnSubmit(content.CONCEPTOSFACTURABLEs.FirstOrDefault(Function(m) m.ID = conceptoF.ID))
            content.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Servicios_Periodicos, "Conceptp Facturable", conceptoF.ID, conceptoF.DESCRIPCION)
            PopulateGrid()
        Catch ex As Exception
            MessageBox.Show(String.Format("El concepto {0} no puede ser eliminado pues se encuentra en uso por la aplicación", CType(CONCEPTOSFACTURABLEBindingSource.Current, CONCEPTOSFACTURABLE).DESCRIPCION))
        End Try
    End Sub

   
    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick

        If Modo = Globales.ModoParaFormas.Edicion Then
            Editar()
        Else
            ConceptoFacturable = GridEX1.SelectedItems(0).GetRow().DataRow
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = True
        tst_Eliminar.Enabled = True
    End Sub

    Private Sub Editar()

        If GridEX1.SelectedItems.Count = 0 Then Return
        
        Dim context As New CMLinqDataContext

        Dim cod As Integer = GridEX1.SelectedItems(0).GetRow().DataRow.ID
        Dim conceptoF As CONCEPTOSFACTURABLE = (From c In context.CONCEPTOSFACTURABLEs Where c.ID = cod).SingleOrDefault()

        Dim frm As New frmConceptoFacturable_ADD
        frm.ConceptoFacturable = conceptoF
        frm.CurrentAccion = Enums.Accion.Modificar

        If frm.ShowDialog() = DialogResult.OK Then
            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Pacientes_Servicios_Periodicos, "Conceptp Facturable", conceptoF.ID, conceptoF.DESCRIPCION)
            PopulateGrid()
        End If

    End Sub

    Private Sub PopulateGrid()

        Dim content As New CMLinqDataContext

        Dim query As IQueryable = From c In content.CONCEPTOSFACTURABLEs Where c.REFPACIENTE = IdPaciente Select c

        'If Not String.IsNullOrEmpty(_txtCodeDesde.Text) Then
        '    query = query.Where(Function(m) m.CODIGO.StartsWith(_txtCodeDesde.Text))
        'End If

        'If (Not String.IsNullOrEmpty(txtConcepto.Text)) Then
        '    query = query.Where(Function(m) m.DESCRIPCION.Contains(txtConcepto.Text))
        'End If

        'Dim stockInt As Integer
        'Integer.TryParse(txtImporte.Text, stockInt)

        'If (stockInt <> 0) Then query = query.Where(Function(m) m.IMPORTE <= stockInt)

        CONCEPTOSFACTURABLEBindingSource.DataSource = query

        'GridEX1.RootTable.Columns("Duracion").FormatString = "HH:mm"
        'GridEX1.AllowEdit = InheritableBoolean.False
        '_GridEx = GridEX1


    End Sub



    Private Sub btnConfigGrid_Click(sender As System.Object, e As System.EventArgs) Handles btnConfigGrid.Click
        Configure()
    End Sub


    Public Sub New()
        MyBase.New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each cExt As GridEXColumn In GridEX1.RootTable.Columns
            OriginalColumns.Add(cExt)
        Next
    End Sub

    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click

    End Sub
End Class