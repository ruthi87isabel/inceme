Imports Janus.Windows.GridEX
Imports System.IO
Imports System.Xml.Linq

Public Class frmMedicos_ADD


    Public Context As CMLinqDataContext

    Public Accion As Enums.Accion
    Public idMedico As Integer = -1
    Public Medico As MEDICO

    Private oldMedicoPorciento As Double = 0
    Dim ofdialog As New OpenFileDialog
    Dim UserCancelled As Boolean = False

    Private Sub frmMedicos_ADD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtp_fi.Value = Date.Now.AddMonths(-1)
        CargaDatos()
        AplicaPermisos()
        Me.recetasLibre()
    End Sub

    Private Sub AplicaPermisos()
        'Permisos de acceso
        Dim apermiso As Integer = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Medicos)
        bt_aceptar.Enabled = apermiso > RoleManager.TipoPermisos.Lectura
        tab_medicos.Enabled = apermiso > RoleManager.TipoPermisos.Lectura

        txtMedicos_PorcientoPorCita.Visible = Globales.Configuracion.ModuloLiquidacionMedicos_Activo
        lblPorcientocitasparaMedico.Visible = Globales.Configuracion.ModuloLiquidacionMedicos_Activo
    End Sub
    Public Sub CargaDatos()

        Context = New CMLinqDataContext

        If Accion <> Enums.Accion.Insertar Then
            Medico = (From m As MEDICO In Context.MEDICOs Where m.CMEDICO = idMedico Select m).SingleOrDefault()
        Else
            Medico = New MEDICO()
        End If


        Try
            'GridEXRegulares.DataSource = Nothing
            'GridEXRegulares.DataMember = "MEDICOS_CONCEPTOFRAs"

            MEDICOBindingSource.DataSource = Medico
            'GridEXRegulares.DataSource = MEDICOBindingSource.DataSource

            'GridEX_Recetas.DataSource = Nothing
            'RECETAsBindingSource.DataSource = Medico.RECETAs.Where(Function(o) o.Eliminado.HasValue And o.Eliminado = False).ToList()
            'GridEX_Recetas.DataSource = RECETAsBindingSource.DataSource

            oldMedicoPorciento = IIf((Not Medico.PorcientoCita Is Nothing), Medico.PorcientoCita, 0)

            If Not Medico.FondoReceta Is Nothing AndAlso Medico.FondoReceta.Trim.Length > 0 Then
                Me.lblFondoReceta.Text = Medico.FondoReceta
            End If

            If Not Medico.LogoColegioReceta Is Nothing AndAlso Medico.LogoColegioReceta.Trim.Length > 0 Then
                Me.lblImagenConsejo.Text = Medico.LogoColegioReceta
            End If

            If Not Medico.Logo2Receta Is Nothing AndAlso Medico.Logo2Receta.Trim.Length > 0 Then
                Me.lblImagenColegio.Text = Medico.Logo2Receta
            End If
        Catch ex As Exception
            'MEDICOBindingSource.DataSource = Nothing
            'MEDICOBindingSource.DataSource = Medico
            Globales.ErrorMsg(ex, "Error al cargar el médico" & Medico.CMEDICO)

        End Try


        ApplyFormatConditions()
        If (Not Medico.FIRMA Is Nothing) Then ptbFirma.Image = Image.FromStream(New MemoryStream(Medico.FIRMA.ToArray()))

        If Medico.Eliminado.HasValue Then
            If Medico.Eliminado = True Then
                Me.Text = "MEDICO ELIMINADO"
                'lb_datos.Text = "MEDICO ELIMINADO"
                tab_medicos.Enabled = False
                tab_medicos_citas.Enabled = False
                tab_medicos_datos.Enabled = False
                tab_medicos_recetas.Enabled = False
                tab_medicos_calendarios.Enabled = False
            End If

        End If
    End Sub


#Region "Private Sub ApplyFormatConditions"

    Private Sub ApplyFormatConditions()

        'Formatear citas en Grid
        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition( _
            GridEXCitas.RootTable.Columns("CONFIRMADA"), _
           Janus.Windows.GridEX.ConditionOperator.Equal, "S")

        fc.FormatStyle.BackColor = Color.Silver
        GridEXCitas.RootTable.FormatConditions.Add(fc)

        Dim fc2 As GridEXFormatCondition
        fc2 = New GridEXFormatCondition( _
            GridEXCitas.RootTable.Columns("ATENDIDO"), _
            Janus.Windows.GridEX.ConditionOperator.Equal, "S")
        fc2.FormatStyle.BackColor = Color.FromArgb(70, 200, 200)
        GridEXCitas.RootTable.FormatConditions.Add(fc2)

        Dim fc3 As GridEXFormatCondition
        fc3 = New GridEXFormatCondition( _
            GridEXCitas.RootTable.Columns("FALTA"), _
            Janus.Windows.GridEX.ConditionOperator.Equal, "S")
        fc3.FormatStyle.BackColor = Color.FromArgb(220, 120, 100)
        GridEXCitas.RootTable.FormatConditions.Add(fc3)

        Dim fc4 As GridEXFormatCondition
        fc4 = New GridEXFormatCondition( _
            GridEXCitas.RootTable.Columns("PAGADA"), _
            Janus.Windows.GridEX.ConditionOperator.Equal, "S")
        fc4.FormatStyle.BackColor = Color.FromArgb(120, 240, 120)
        GridEXCitas.RootTable.FormatConditions.Add(fc4)

    End Sub

#End Region

#Region "Private Sub FiltrarGrid()"

    Private Sub FiltrarGrid()
        Dim condition As New GridEXFilterCondition()


        ' If Calendar1.CurrentDate Then
        condition.AddCondition(Janus.Windows.GridEX.LogicalOperator.And, _
                      New GridEXFilterCondition(GridEXCitas.RootTable.Columns("FECHA"), Janus.Windows.GridEX.ConditionOperator.Equal, Calendar1.SelectionRange.Start))

        ' End If

        If Not GridEXCitas.RootTable Is Nothing Then
            GridEXCitas.RootTable.FilterCondition = Nothing
            GridEXCitas.RootTable.FilterCondition = condition
            'GridEX1.RootTable.ApplyFilter(condition)
        End If


    End Sub
#End Region

    Private Function Guardar() As Boolean
        Try
            MEDICOBindingSource.EndEdit()
            If Accion = Enums.Accion.Insertar Then
                Context.MEDICOs.InsertOnSubmit(Medico)
            End If

            If oldMedicoPorciento <> Medico.PorcientoCita Then
                Try
                    If Accion <> Enums.Accion.Insertar Then
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Medicos, _
                                                    "Modificado % Dto de " & oldMedicoPorciento & " a " & Medico.PorcientoCita, _
                                                    Medico.CMEDICO, Medico.NOMBRECOMPLETO)
                    End If
                Catch ex As Exception

                End Try
            End If

            Context.SubmitChanges()

            If Accion = Enums.Accion.Insertar Then
                Accion = Enums.Accion.Modificar
                idMedico = Medico.CMEDICO
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub bt_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles bt_aceptar.Click
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub bt_cancel_Click(sender As System.Object, e As System.EventArgs) Handles bt_cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub btn_ADD_Click(sender As System.Object, e As System.EventArgs) Handles btn_ADD.Click
        Dim dialog As New OpenFileDialog()
        If (DialogResult.OK = dialog.ShowDialog()) Then
            'txtFirma.Text = dialog.FileName
            ptbFirma.Image = Image.FromFile(dialog.FileName)
            Medico.FIRMA = File.ReadAllBytes(dialog.FileName)
        End If
    End Sub


    Private Sub btn_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Eliminar.Click
        Medico.FIRMA = Nothing
        ptbFirma.Image = Nothing
    End Sub


    Private Sub Calendar1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles Calendar1.SelectionChanged
        FiltrarGrid()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnConceptoFRA_ADD.Click
        If Guardar() Then

            Dim frm As New frmListadoConceptos
            frm.Modo = Globales.ModoParaFormas.Seleccion

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If Not frm.ConceptoFra Is Nothing Then
                    If ExisteConceptoFRA(frm.ConceptoFra.CODIGO) Then
                        MessageBox.Show("Este concepto " + frm.ConceptoFra.DESCRIPCION + " ya está incluido!!")
                    Else

                        Dim item As New MEDICOS_CONCEPTOFRA()
                        item.CMEDICO = Medico.CMEDICO
                        item.CODIGO = frm.ConceptoFra.CODIGO
                        item.ImporteDto = 0
                        item.ImportePorciento = 0
                        Dim t1 = item.CONCEPTOSFRA
                        Medico.MEDICOS_CONCEPTOFRAs.Add(item)
                    End If
                End If


                For Each con As CONCEPTOSFRA In frm.ConceptosSeleccionados
                    If ExisteConceptoFRA(con.CODIGO) Then
                        MessageBox.Show("Este concepto " + con.DESCRIPCION + " ya está incluido!!")
                    Else
                        Dim item As New MEDICOS_CONCEPTOFRA()
                        item.CMEDICO = Medico.CMEDICO
                        item.CODIGO = con.CODIGO
                        item.ImporteDto = 0
                        item.ImportePorciento = 0
                        Dim t1 = item.CONCEPTOSFRA
                        Medico.MEDICOS_CONCEPTOFRAs.Add(item)
                    End If
                Next
                Guardar()

                'Context.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, Medico)
                'Context.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, Medico.MEDICOS_CONCEPTOFRAs)
                'MEDICOBindingSource.ResetCurrentItem()
                CargaDatos()
                CargaCONCEPTOFRAs()
            End If
        End If
    End Sub

    Private Sub btnConceptoFRA_REMOVE_Click(sender As System.Object, e As System.EventArgs) Handles btnConceptoFRA_REMOVE.Click

        Guardar()

        If GridEXRegulares.GetCheckedRows().Count = 0 Then
            If Not GridEXRegulares.CurrentRow Is Nothing Then
                If GridEXRegulares.CurrentRow.RowType = RowType.Record Then
                    If Not GridEXRegulares.CurrentRow.DataRow Is Nothing Then
                        'DeleteConceptoRow(GridEXRegulares.CurrentRow)
                        GridEXRegulares.UpdateData()
                        GridEXRegulares.Delete()
                        GridEXRegulares.Refetch()
                        Dim mc As MEDICOS_CONCEPTOFRA = GridEXRegulares.CurrentRow.DataRow
                        Medico.MEDICOS_CONCEPTOFRAs.Remove(mc)
                        Guardar()
                    End If
                End If
            End If
        Else
            For Each row As GridEXRow In GridEXRegulares.GetCheckedRows()
                If row.RowType = RowType.Record Then
                    If Not row.DataRow Is Nothing Then
                        Medico.MEDICOS_CONCEPTOFRAs.Remove(row.DataRow)
                    End If
                End If
            Next
        End If


        Guardar()
        CargaDatos()
        CargaCONCEPTOFRAs()

    End Sub

    Private Sub DeleteConceptoRow(ByRef row As GridEXRow)

        'Dim content As New CMLinqDataContext

        If Not row Is Nothing Then
            If row.RowType = RowType.Record Then
                If Not row Is Nothing Then
                    Try

                        Dim mc As MEDICOS_CONCEPTOFRA = row.DataRow
                        'Dim item As MEDICOS_CONCEPTOFRA = (From c As MEDICOS_CONCEPTOFRA In content.MEDICOS_CONCEPTOFRAs Where c.CODIGO = mc.CODIGO And c.CMEDICO = Medico.CMEDICO Select c).SingleOrDefault()

                        'content.MEDICOS_CONCEPTOFRAs.DeleteOnSubmit(item)
                        'content.SubmitChanges()
                        row.Delete()
                        Medico.MEDICOS_CONCEPTOFRAs.Remove(mc)
                        Guardar()
                    Catch ex As Exception

                    End Try

                End If
            End If
        End If
    End Sub

    Private Sub GridEXRegulares_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEXRegulares.SelectionChanged
        btnConceptoFRA_REMOVE.Enabled = True
        'GridEXRegulares.SelectedItems.Count > 0 Or GridEXRegulares.GetCheckedRows().Count > 0
    End Sub

    Private Sub btnConceptoFRA_TODOS_Click(sender As System.Object, e As System.EventArgs) Handles btnConceptoFRA_TODOS.Click
        Guardar()
        For Each c As CONCEPTOSFRA In Context.CONCEPTOSFRAs
            If Not ExisteConceptoFRA(c.CODIGO) Then
                Dim item As New MEDICOS_CONCEPTOFRA()
                item.CMEDICO = Medico.CMEDICO
                item.CODIGO = c.CODIGO
                item.ImporteDto = 0
                item.ImportePorciento = 0
                Dim t1 = item.CONCEPTOSFRA
                Context.MEDICOS_CONCEPTOFRAs.InsertOnSubmit(item)
            End If
        Next
        Context.SubmitChanges()
        CargaCONCEPTOFRAs()
        
    End Sub

    Function ExisteConceptoFRA(ByVal cod As String)
        Dim context As New CMLinqDataContext
        Return context.MEDICOS_CONCEPTOFRAs.Any(Function(mc) mc.CMEDICO = Medico.CMEDICO And mc.CODIGO = cod)
    End Function

    Private Sub GridEXRegulares_CellEdited(sender As System.Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEXRegulares.CellEdited


        Dim mf As MEDICOS_CONCEPTOFRA = GridEXRegulares.CurrentRow.DataRow

        If mf Is Nothing Then
            Return
        End If

        If mf.CONCEPTOSFRA Is Nothing Then
            Return
        End If

        'MEDICOBindingSource.EndEdit()
        'GridEXRegulares.CurrentRow.BeginEdit()

        If e.Column.Key = "ImporteDto" Then
            If mf.CONCEPTOSFRA.IMPORTE > 0 Then
                mf.ImportePorciento = mf.ImporteDto / mf.CONCEPTOSFRA.IMPORTE
                GridEXRegulares.CurrentRow.Cells("ImportePorciento").Value = mf.ImporteDto / mf.CONCEPTOSFRA.IMPORTE
                'GridEXRegulares.SelectedItems(0).GetRow().EndEdit()
                'MEDICOBindingSource.EndEdit()
                'GridEXRegulares.Invalidate()


            Else
                mf.ImporteDto = 0
                mf.ImportePorciento = 0
            End If
        End If

        If e.Column.Key = "ImportePorciento" Then
            If mf.CONCEPTOSFRA.IMPORTE > 0 Then
                mf.ImporteDto = mf.ImportePorciento * mf.CONCEPTOSFRA.IMPORTE
                'GridEXRegulares.CurrentRow.Cells("ImporteDto").Text = mf.ImportePorciento * mf.CONCEPTOSFRA.IMPORTE
            Else
                mf.ImporteDto = 0
                mf.ImportePorciento = 0
            End If
        End If
    End Sub

    Private Sub GridEXRegulares_RecordUpdated(sender As System.Object, e As System.EventArgs) Handles GridEXRegulares.RecordUpdated

    End Sub

    Private Sub GridEXRegulares_Click(sender As System.Object, e As System.EventArgs) Handles GridEXRegulares.Click

    End Sub

    Private PosibleModificacionDtoMedico As Boolean = False

    Private Sub txtMedicos_PorcientoPorCita_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtMedicos_PorcientoPorCita.KeyUp
        If e.KeyCode <> Keys.Tab Then
            PosibleModificacionDtoMedico = True
        End If
    End Sub

    Private Sub CargaCitas()
        Dim citas As IQueryable = From c In Context.CITAs _
                                  Where c.REFMEDICO = Medico.CMEDICO And c.Eliminado = False
                                  Order By c.FECHA Descending _
                                  Take 100
                                  Select c


        CITAsBindingSource.DataSource = citas


    End Sub

    Private Sub CargaRecetas()
        Dim recetas As IQueryable(Of RECETA) = From c In Context.RECETAs _
                                  Where c.REFMEDICO = Medico.CMEDICO And c.Eliminado = False
                                  Select c

        Dim fi As Date = New Date(dtp_fi.Value.Year, dtp_fi.Value.Month, dtp_fi.Value.Day, 0, 0, 0)
        Dim ff As Date = New Date(dtp_ff.Value.Year, dtp_ff.Value.Month, dtp_ff.Value.Day, 23, 59, 59)

        If dtp_fi.Checked Then
            recetas = recetas.Where(Function(o) o.FECHA >= fi)
        End If

        If dtp_ff.Checked Then
            recetas = recetas.Where(Function(o) o.FECHA <= ff)
        End If

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            recetas = recetas.Where(Function(o) o.REFPACIENTE = CtrlPaciente1.ID_PACIENTE)
        End If

        If CtrlDiagnosticos1.ID_DIAGNOSTICOS.HasValue Then
            recetas = recetas.Where(Function(o) o.REFDIAGNOSTICO = CtrlDiagnosticos1.ID_DIAGNOSTICOS)
        End If

        If rb_diagnostico.Checked Then
            recetas = recetas.OrderBy(Function(o) o.REFDIAGNOSTICO)
        End If

        If rb_fecha.Checked Then
            recetas = recetas.OrderByDescending(Function(o) o.FECHA)
        End If

        If rb_paciente.Checked Then
            recetas = recetas.OrderBy(Function(o) o.REFPACIENTE)
        End If

        RECETAsBindingSource.DataSource = recetas
    End Sub

    Private Sub CargaCONCEPTOFRAs()
        Dim conceptos As IQueryable = From c In Context.MEDICOS_CONCEPTOFRAs _
                                  Where c.CMEDICO = Medico.CMEDICO
                                  Select c

        MEDICOSCONCEPTOFRAsBindingSource.DataSource = conceptos
    End Sub

    Private Sub CargaFicheros()
        Dim ficheros As IQueryable = From c In Context.MEDICOS_FICHEROs _
                                  Where c.ID_Medico = Medico.CMEDICO
                                  Order By c.FechaModificado Descending
                                  Select c

        MEDICOSFICHEROsBindingSource.DataSource = ficheros
    End Sub

    Private Sub tab_medicos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tab_medicos.SelectedIndexChanged

        If tab_medicos.SelectedTab.Equals(tab_medicos_citas) Then
            CargaCitas()
        End If

        If tab_medicos.SelectedTab.Equals(tab_medicos_recetas) Then
            CargaRecetas()
        End If

        If tab_medicos.SelectedTab.Equals(tab_medicos_conceptosfacturables) Then
            CargaCONCEPTOFRAs()
        End If

        If tab_medicos.SelectedTab.Equals(tab_medicos_conceptosfacturables) Then
            CargaCONCEPTOFRAs()
        End If

        If tab_medicos.SelectedTab.Equals(tab_medicos_ficheros) Then
            CargaFicheros()
        End If


        If tab_medicos.SelectedTab.Equals(tab_medicos_calendarios) Then
            CtrlHorarios1.lblTituloCalendario.Text = Medico.NOMBRECOMPLETO + ".  " + Medico.ESPECIALIDAD
            'AddHandler ctrlHora.SeleccionarRangoEnTodosLosCalendarios, AddressOf SeleccionarRangoTodosLosCalendarios
            'AddHandler ctrlHora.PropagarATodosLosCalendarios, AddressOf PropagarATodosCalendarios
            'AddHandler ctrlHora.PropagarTipoFechaATodosLosCalendarios, AddressOf PropagarTipoFechaATodosLosCalendarios
            'AddHandler ctrlHora.ClearSeleccionEvent, AddressOf ClearSeleccionEvent


            CtrlHorarios1.Anno = Date.Now.Year

            Guardar()

            Dim calendario As CALENDARIO_MEDICO = (From c In Context.CALENDARIO_MEDICOs _
                                                  Where c.ID_MEDICO = Medico.CMEDICO And c.Anno = Date.Now.Year _
                                                  Select c).SingleOrDefault()

            If calendario Is Nothing Then
                'No tiene para este medico y anno, crearlo
                calendario = New CALENDARIO_MEDICO()
                calendario.ID_MEDICO = Medico.CMEDICO
                calendario.Anno = Date.Now.Year
                calendario.Calendario = New XElement("Calendario")
                Context.CALENDARIO_MEDICOs.InsertOnSubmit(calendario)
                Context.SubmitChanges()
            Else
                CtrlHorarios1.CalendarioXML = calendario.Calendario.ToString()
            End If
            CtrlHorarios1.Tag = calendario
            CtrlHorarios1.ActivarSoloLectura()
        End If
    End Sub

    Private Sub tstNuevoFichero_Click(sender As Object, e As EventArgs) Handles tstNuevoFichero.Click
        Dim fichero As New MEDICOS_FICHERO
        fichero.ID_Medico = idMedico

        Dim frm As New frmMedicos_Ficheros_ADD
        frm.MEDICOSFICHEROBindingSource.DataSource = fichero
        If frm.ShowDialog() = DialogResult.OK Then
            Context.MEDICOS_FICHEROs.InsertOnSubmit(fichero)
            Context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Enums.Accion.Insertar, RoleManager.Items.Medicos_Ficheros, "Ficheros de Medico", _
                                            fichero.ID_Fichero, _
                                            String.Format("Insertado fichero {0} a médico [{1}] {2}", fichero.NombreFichero, Medico.CMEDICO, Medico.NOMBRECOMPLETO))
        End If
        CargaDatos()
        CargaFicheros()

    End Sub

    Private Sub tstModificarFichero_Click(sender As Object, e As EventArgs) Handles tstModificarFichero.Click
        Dim fichero As MEDICOS_FICHERO = GridEX1.SelectedItems(0).GetRow().DataRow
        Dim frm As New frmMedicos_Ficheros_ADD
        frm.MEDICOSFICHEROBindingSource.DataSource = fichero
        If frm.ShowDialog() = DialogResult.OK Then
            Context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Medicos_Ficheros, "Ficheros de Medico", _
                                         fichero.ID_Fichero, _
                                         String.Format("Modificado fichero {0} a médico [{1}] {2}", fichero.NombreFichero, Medico.CMEDICO, Medico.NOMBRECOMPLETO))

        End If
        CargaDatos()
        CargaFicheros()
    End Sub

    Private Sub tstEliminarFichero_Click(sender As Object, e As EventArgs) Handles tstEliminarFichero.Click
        Dim fichero As MEDICOS_FICHERO = GridEX1.SelectedItems(0).GetRow().DataRow
        If MessageBox.Show("¿Esta seguro de eliminar este fichero?", "Conformación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Context.MEDICOS_FICHEROs.DeleteOnSubmit(fichero)
            Context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Medicos_Ficheros, "Ficheros de Medico", _
                                       fichero.ID_Fichero, _
                                       String.Format("Eliminado fichero {0} a médico [{1}] {2}", fichero.NombreFichero, Medico.CMEDICO, Medico.NOMBRECOMPLETO))

            CargaDatos()
            CargaFicheros()
        End If
    End Sub

    Private Sub GridEX1_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick
        Dim fichero As MEDICOS_FICHERO = GridEX1.SelectedItems(0).GetRow().DataRow

        Dim pathFile As String = Path.GetTempPath() & "/" & fichero.NombreFichero
        Try
            Dim fs As New FileStream(pathFile, FileMode.Create)
            fs.Write(fichero.Fichero.ToArray(), 0, fichero.Fichero.Length)
            fs.Close()

            Dim instance As ProcessStartInfo = New ProcessStartInfo(pathFile)
            'instance.UseShellExecute = True
            System.Diagnostics.Process.Start(pathFile)

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Medicos_Ficheros, "Ficheros de Medico", _
                                     fichero.ID_Fichero, _
                                     String.Format("Abierto fichero {0} de médico [{1}] {2}", fichero.NombreFichero, Medico.CMEDICO, Medico.NOMBRECOMPLETO))


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

#Region "Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.FormattingRow"
    Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.FormattingRow
        Dim fichero As MEDICOS_FICHERO = e.Row.DataRow
        Try
            'Encontrar un fichero con el mismo tipo en temp
            Dim files() As String = Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.Temp, "*" & Path.GetExtension(fichero.NombreFichero))
            If files.Length > 0 Then
                Dim icon As Icon = System.Drawing.Icon.ExtractAssociatedIcon(files(0))

                'Dim icon As Icon = System.Drawing.Icon.ExtractAssociatedIcon(Globales.Configuracion.dirfiles & "\" & fichero.FICHERO)
                e.Row.Cells("ColumnIcon").Image = icon.ToBitmap().GetThumbnailImage(16, 16, Nothing, IntPtr.Zero)
            Else
                'Dim icon As Icon = System.Drawing.Icon.ExtractAssociatedIcon(Globales.)

                'e.Row.Cells("ColumnIcon").Image = .ToBitmap().GetThumbnailImage(16, 16, Nothing, IntPtr.Zero)

            End If

        Catch ex As Exception

        End Try

    End Sub
#End Region

    Private Sub GridEX1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If GridEX1.SelectedItems.Count > 0 Then
            'tstModificar_Click(Nothing, Nothing)
            GridEX1_ColumnButtonClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        tstModificarFichero.Enabled = GridEX1.SelectedItems.Count > 0
        tstEliminarFichero.Enabled = GridEX1.SelectedItems.Count > 0
    End Sub

    Private Sub tb_DNI_TextChanged(sender As Object, e As EventArgs) Handles tb_DNI.TextChanged
        If IsNumeric(tb_DNI.Text) Then
            lb_letra.Text = Globales.GetLetter(tb_DNI.Text)
        Else
            lb_letra.Text = "-"
        End If
    End Sub

    Private Sub bt_filtrar_Click(sender As Object, e As EventArgs) Handles bt_filtrar.Click
        CargaRecetas()
    End Sub
    Sub recetasLibre()
        Dim tmp As New recetaXML
        Dim n As Integer = tmp.recetasLibresPorMedico(Medico.CMEDICO)
        If n > 0 Then
            Me.lblInfoRecetas.ForeColor = Color.Green
            Me.lblInfoRecetas.Text = "Dispone de " & n & " recetas sin usar."
        Else
            Me.lblInfoRecetas.ForeColor = Color.Red
            Me.lblInfoRecetas.Text = "No dispone de recetas libres. Adquieralas en su colegio"
        End If
    End Sub
    
    Private Sub btIimportarRecetas_Click(sender As Object, e As EventArgs) Handles btImportarRecetas.Click
        Dim f As New OpenFileDialog
        f.Multiselect = False
        f.Filter = "Fichero XML|*.xml"
        Dim res As DialogResult = f.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            Medico.importarRecetas(f.FileName)
            Me.recetasLibre()
        End If

    End Sub

    Private Function seleccionaImagenParaReceta() As String
        Dim path As String = ""
        ofdialog.Filter = "Fichero jpg|*.jpg"

        If Directory.Exists(Globales.Configuracion.imagedirectory) Then
            If Not Directory.Exists(Globales.Configuracion.imagedirectory & "\imgRecetasxml") Then
                Directory.CreateDirectory(Globales.Configuracion.imagedirectory & "\imgRecetasxml")
            End If
            ofdialog.InitialDirectory = Globales.Configuracion.imagedirectory & "\imgRecetasxml"
            path = ofdialog.InitialDirectory
        Else
            MsgBox("No existe el directorio definido para guardar imagenes usadas por el programa por lo que no es posible continuar", MsgBoxStyle.Critical)
            Return ""
        End If


        Dim res As DialogResult = ofdialog.ShowDialog
        Dim tmpFilename As String = ""


        If res = Windows.Forms.DialogResult.OK Then
            tmpFilename = ofdialog.SafeFileName
            If Not System.IO.Path.GetDirectoryName(ofdialog.FileName) = path Then
                If Not File.Exists(path & "\" & tmpFilename) Then
                    FileCopy(ofdialog.FileName, path & "\" & tmpFilename)
                End If

            End If
        End If
        resetofdialog()

        Return tmpFilename
    End Function

    Private Sub bt_imagenfondo(sender As Object, e As EventArgs) Handles bt_fondoreceta.Click, bt_imagencolegio.Click, bt_imagenconsejo.Click
        Dim str As String = seleccionaImagenParaReceta()
        Dim bt As Button = sender
        If str.Trim.Length > 0 Then
            If bt.Text = "Fondo Receta" Then
                Me.MEDICOBindingSource.Current.fondoreceta = str
                lblFondoReceta.Text = str
            End If
            If bt.Text = "Imagen Consejo" Then
                Me.MEDICOBindingSource.Current.LogoColegioReceta = str
                lblImagenConsejo.Text = str
            End If
            If bt.Text = "Imagen Colegio" Then
                Me.MEDICOBindingSource.Current.Logo2Receta = str
                lblImagenColegio.Text = str
            End If
        End If
    End Sub

    Private Sub resetofdialog()
        ofdialog.FileName = ""
        ofdialog.InitialDirectory = ""
        ofdialog.Filter = ""
    End Sub

    
    Private Sub CtrlVisorDefaultApp2_Click(sender As Object, e As EventArgs) Handles CtrlVisorDefaultApp2.Click
        CtrlVisorDefaultApp2.abreAplicacion(Globales.Configuracion.imagedirectory & "\imgRecetasxml\" & lblFondoReceta.Text)
    End Sub

    Private Sub CtrlVisorDefaultApp3_click(sender As Object, e As EventArgs) Handles CtrlVisorDefaultApp3.Click
        CtrlVisorDefaultApp3.abreAplicacion(Globales.Configuracion.imagedirectory & "\imgRecetasxml\" & lblImagenConsejo.Text)
    End Sub

    Private Sub CtrlVisorDefaultApp1_click(sender As Object, e As EventArgs) Handles CtrlVisorDefaultApp1.Click
        CtrlVisorDefaultApp3.abreAplicacion(Globales.Configuracion.imagedirectory & "\imgRecetasxml\" & lblImagenColegio.Text)
    End Sub
End Class