Imports Janus.Windows.GridEX

Public Class frmListadoConceptos

    Public ConceptoFra As CONCEPTOSFRA
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion

    Public ConceptosSeleccionados As New List(Of CONCEPTOSFRA)


    Dim context As New CMLinqDataContext()

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CONCEPTOSFAMILIABindingSource.DataSource = From f In context.CONCEPTOSFAMILIAs Select f
        CargaDatos()
        AplicaPermisos()

        GridEXDental.RootTable.Columns("Duracion").FormatString = "HH:mm"
        GridEXDental.AllowEdit = InheritableBoolean.False

        'GridEXRegulares.RootTable.Columns("Duracion").FormatString = "HH:mm"
        'GridEXRegulares.AllowEdit = InheritableBoolean.False

        'GridEXDental.RootTable.Columns(0).Filter = FilterEditType.Custom

        Filtrar()
    End Sub

    Private Sub AplicaPermisos()
        Dim apermisoDental As Integer = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Conceptos_Facturables)
        Dim apermisoRegular As Integer = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Conceptos_Facturables)

        tstNuevoDental.Visible = apermisoDental > RoleManager.TipoPermisos.Modificar
        tstEliminarDental.Visible = apermisoDental > RoleManager.TipoPermisos.Lectura
        tstModificarDental.Visible = apermisoDental > RoleManager.TipoPermisos.Lectura
        GridEXDental.RootTable.Columns("IMPORTE").Visible = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Dental_Presupuestos) > RoleManager.TipoPermisos.Ninguno


        If Not Globales.Configuracion.Dental_ModuloActivo Then
            rbDentales.Visible = False
            rbTodos.Visible = False
            rbRegulares.Checked = True
            rbRegulares.Visible = False
        End If
        

        'tstNuevoRegular.Visible = apermisoRegular > RoleManager.TipoPermisos.Modificar
        'tstEliminarRegulares.Visible = apermisoRegular > RoleManager.TipoPermisos.Lectura
        'tstModificarRegulares.Visible = apermisoRegular > RoleManager.TipoPermisos.Lectura

        ' GridEXRegulares.RootTable.Columns("IMPORTE").Visible = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pacientes_Debito) > RoleManager.TipoPermisos.Ninguno

    End Sub

    Public Sub CargaDatos()
        context = New CMLinqDataContext()
        GridEXDental.DataSource = Nothing
        DENTALCONCEPTOSFRABindingSource.DataSource = (From f In context.CONCEPTOSFRAs Select f).ToList()
        GridEXDental.DataSource = DENTALCONCEPTOSFRABindingSource.DataSource

    End Sub

#Region "Dentales"
    Private Sub tstNuevoDental_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstNuevoDental.Click


        Dim frmDiag As New frmConceptoFacturable_Tipo()

        Dim result As DialogResult = Windows.Forms.DialogResult.OK
        If (Globales.Configuracion.Dental_ModuloActivo) Then
            result = frmDiag.ShowDialog()
        Else
            frmDiag.rbRegular.Checked = True
        End If

        Dim resultNueva As DialogResult = Windows.Forms.DialogResult.Cancel
        Dim id As String = ""

        If result = Windows.Forms.DialogResult.OK Then
            If frmDiag.rbRegular.Checked Then
                Dim _nueva_cf As form_conceptos_facturables = New form_conceptos_facturables("Ficha -Editar", Enums.Accion.Insertar, "")
                _nueva_cf.ShowInTaskbar = False
                resultNueva = _nueva_cf.ShowDialog()
                id = _nueva_cf.fId
            Else
                'Dim frmOperaciones As New frmOperaciones()
                'frmOperaciones.Text = "Seleccione Operacion (Familia) a la que pertenecerá"
                'frmOperaciones.catDental = 1
                'frmOperaciones.Modo = Globales.ModoParaFormas.Seleccion
                ' ''frm.EdicionDirecta = True
                Dim frmFamilia As New frmFamiliaSelector()
                frmFamilia.Categorias = ctrlFamilia.MostrarCategorias.Dentales
                frmFamilia.Modo = Globales.ModoParaFormas.Seleccion

                If frmFamilia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim ftratamiento As New frmTratamientos()
                    ftratamiento.catDental = 1
                    ftratamiento.Nuevo = True
                    ftratamiento.IDFamilia = frmFamilia.Familia.IDFamilia
                    'Convert.ToInt32(tbxID.Text)
                    resultNueva = ftratamiento.ShowDialog(Me)
                    id = ftratamiento.currentCODIGO
                End If
            End If
            CargaDatos()
            If resultNueva = Windows.Forms.DialogResult.OK Then
                EnsureVisible(id)
            End If
        End If


    End Sub

    Private Sub tstModificarDental_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstModificarDental.Click
        If GridEXDental.SelectedItems.Count > 0 Then
            If GridEXDental.SelectedItems(0).RowType = Janus.Windows.GridEX.RowType.Record Then
                ConceptoFra = GridEXDental.SelectedItems(0).GetRow().DataRow
                'Sacar el editar
                If Not tstModificarDental.Visible Then
                    MessageBox.Show("Usted no tiene permiso para editar conceptos facturables")
                    Return
                End If
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Conceptos_Facturables, "Abrir ", ConceptoFra.CODIGO.ToString(), "En Listado Conceptos")

                ' Try
                If Not ConceptoFra.CONCEPTOSFAMILIA Is Nothing Then
                    If ConceptoFra.CONCEPTOSFAMILIA.Categoria = 1 Then
                        Dim frm As New frmTratamientos()
                        frm.catDental = 1
                        frm.currentCODIGO = ConceptoFra.CODIGO
                        frm.IDFamilia = ConceptoFra.IDFAMILIA
                        frm.EdicionDirecta = True
                        Dim id As String = ConceptoFra.CODIGO
                        frm.ShowDialog()
                        CargaDatos()
                        EnsureVisible(id)
                        Return
                    End If
                End If
                'Catch ex As Exception

                'End Try

                Dim _nueva_cf As form_conceptos_facturables = New form_conceptos_facturables("Ficha -Editar", Enums.Accion.Modificar, ConceptoFra.CODIGO.ToString())
                _nueva_cf.ShowInTaskbar = False
                Dim id2 As String = ConceptoFra.CODIGO
                _nueva_cf.ShowDialog()
                CargaDatos()
                EnsureVisible(id2)
            End If
        End If

    End Sub

    Private Sub tstEliminarDental_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstEliminarDental.Click

        If GridEXDental.GetCheckedRows().Count = 0 Then
            MessageBox.Show("No hay conceptops seleccionados")
            Return
        End If

        If MessageBox.Show("¿Seguro desea eliminar los concepto(s) facturable(s) seleccionados? (S/N)", "Confirmacion", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        For Each row As GridEXRow In GridEXDental.GetCheckedRows
            ConceptoFra = row.DataRow
            Globales.ConceptoFRA_EliminarCorrectamente(ConceptoFra.CODIGO, True)
        Next
        CargaDatos()
    End Sub

    Private Sub GridEXDental_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEXDental.SelectionChanged
        tstModificarDental.Enabled = GridEXDental.SelectedItems.Count > 0
        tstEliminarDental.Enabled = GridEXDental.SelectedItems.Count > 0
        ModificarFamiliaToolStripMenuItem.Enabled = GridEXDental.SelectedItems.Count > 0
    End Sub

    Private Sub GridEXDental_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEXDental.RowDoubleClick
        If GridEXDental.SelectedItems.Count > 0 Then
            If GridEXDental.SelectedItems(0).RowType = Janus.Windows.GridEX.RowType.Record Then
                ConceptoFra = GridEXDental.SelectedItems(0).GetRow().DataRow
                If Modo = Globales.ModoParaFormas.Seleccion Then
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    tstModificarDental_Click(Nothing, Nothing)
                End If

            End If
        End If
    End Sub
#End Region

    Private Sub UiTab1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs)
        CargaDatos()
    End Sub

    Private Sub ModificarFamiliaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarFamiliaToolStripMenuItem.Click


        If GridEXDental.SelectedItems.Count = 0 Then
            Return
        End If

        If GridEXDental.SelectedItems(0).RowType <> RowType.Record Then
            Return
        End If
        ConceptoFra = GridEXDental.SelectedItems(0).GetRow().DataRow

        Dim frm As New frmFamiliaSelector()
        If frm.ShowDialog() = DialogResult.OK Then

            'Dim context2 As New CMLinqDataContext()
            'Dim concepto As CONCEPTOSFRA = (From f In context2.CONCEPTOSFRAs Where f.CODIGO = ConceptoFra.CODIGO Select f).SingleOrDefault()
            ConceptoFra.CONCEPTOSFAMILIA = Nothing
            Dim nuevaFamilia As CONCEPTOSFAMILIA = (From f As CONCEPTOSFAMILIA In context.CONCEPTOSFAMILIAs
                                                   Where f.IDFamilia = frm.Familia.IDFamilia
                                                   Select f).SingleOrDefault()

            Dim id As String = ConceptoFra.CODIGO
            ConceptoFra.CONCEPTOSFAMILIA = nuevaFamilia
            context.SubmitChanges()
            CargaDatos()
            EnsureVisible(id)
        End If


    End Sub

    Private Sub EnsureVisible(ByVal cod As String)
        For Each row As GridEXRow In GridEXDental.GetRows()
            If row.RowType = RowType.Record Then
                If Not row.DataRow Is Nothing Then
                    If row.DataRow.CODIGO = cod Then
                        GridEXDental.SelectedItems.Clear()
                        GridEXDental.SelectedItems.Add(row.RowIndex)
                        GridEXDental.EnsureVisible(row.RowIndex)
                        Return
                    End If
                End If
            End If

            If row.RowType = RowType.GroupHeader Then
                For Each row2 As GridEXRow In row.GetChildRows()
                    If Not row2.DataRow Is Nothing Then
                        If row2.DataRow.CODIGO = cod Then

                            
                            GridEXDental.EnsureVisible(row2.Position)
                            GridEXDental.SelectedItems.Clear()
                            GridEXDental.SelectedItems.Add(row2.Position)
                            Return
                        End If
                    End If
                Next
            End If

        Next
    End Sub

    Private Sub tstAnnadirSeleccionados_Click(sender As System.Object, e As System.EventArgs) Handles tstAnnadirSeleccionados.Click
        ConceptosSeleccionados.Clear()

        For Each row As GridEXRow In GridEXDental.GetCheckedRows
            If row.RowType = RowType.Record Then
                If Not row.DataRow Is Nothing Then
                    Try
                        Dim concepto As CONCEPTOSFRA = row.DataRow
                        ConceptosSeleccionados.Add(concepto)
                    Catch ex As Exception
                    End Try

                End If
            End If
        Next
        If ConceptosSeleccionados.Count = 0 Then
            MessageBox.Show("No hay conceptos seleccionados")
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub EliminarFamiliaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarFamiliaToolStripMenuItem.Click

        If GridEXDental.SelectedItems.Count = 0 Then
            Return
        End If

        If GridEXDental.SelectedItems(0).RowType <> RowType.Record Then
            Return
        End If
        Try
            ConceptoFra = GridEXDental.SelectedItems(0).GetRow().DataRow
            Dim id As String = ConceptoFra.CODIGO
            ConceptoFra.CONCEPTOSFAMILIA = Nothing
            context.SubmitChanges()
            CargaDatos()
            EnsureVisible(id)
        Catch ex As Exception

        End Try
    
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbTodos.CheckedChanged
        Filtrar()
    End Sub

    Private Sub rbRegulares_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbRegulares.CheckedChanged
        Filtrar()
    End Sub

    Private Sub rbDentales_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbDentales.CheckedChanged
        Filtrar()
    End Sub

    Private Sub Filtrar()
        Dim filter As GridEXFilterCondition = Nothing

        If rbDentales.Checked Then
            filter = New GridEXFilterCondition(GridEXDental.RootTable.Columns("CONCEPTOSFAMILIA.Categoria"), ConditionOperator.Equal, 1)
        End If

        If rbRegulares.Checked Then
            filter = New GridEXFilterCondition(GridEXDental.RootTable.Columns("CONCEPTOSFAMILIA.Categoria"), ConditionOperator.NotEqual, 1)
        End If

        GridEXDental.RootTable.FilterCondition = filter


    End Sub

    
    Private Sub GridEXDental_GroupsChanged(sender As System.Object, e As Janus.Windows.GridEX.GroupsChangedEventArgs) Handles GridEXDental.GroupsChanged
        GridEXDental.RootTable.Columns("CONCEPTOSFAMILIA.Descripcion").Visible = (GridEXDental.RootTable.Groups("CONCEPTOSFAMILIA.Descripcion") Is Nothing)
    End Sub
End Class