Imports Janus.Windows.UI.Tab
Imports Microsoft.Reporting.WinForms
Imports Janus.Windows.GridEX
Imports centro_medico.UI.Reportes

Public Class frmHistoriales

    Dim Context As CMLinqDataContext
   
    Private Paciente As PACIENTE
    Public IdPaciente As Integer = 744

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Dim permiso As RoleManager.TipoPermisos
    Public Historial As HISTORIALE
    Dim position As Integer = -1
    Private EditarEliminar As Boolean = False


    Private Sub frmHistoriales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaDatos()

        permiso = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Pacientes_Historiales_Actuales)


        If permiso = RoleManager.TipoPermisos.Ninguno Then
            MessageBox.Show("Necesita permiso Pacientes_Historiales_Actuales para acceder a este módulo")
            Me.Close()
        End If

        
        Me.tstNuevo.Enabled = permiso > RoleManager.TipoPermisos.Lectura
        Me.tst_Editar.Enabled = permiso > RoleManager.TipoPermisos.Lectura
        Me.tst_Eliminar.Enabled = permiso > RoleManager.TipoPermisos.Modificar
        Me.EditarEliminar = permiso > RoleManager.TipoPermisos.Lectura

    End Sub

    Private Sub CargaDatos()
        Context = New CMLinqDataContext()
        GridEX1.DataSource = Nothing

        Paciente = (From p In Context.PACIENTEs
                               Where p.CPACIENTE = IdPaciente
                               Select p).SingleOrDefault()

        HISTORIALEBindingSource.DataSource = Paciente.HISTORIALEs.Where(Function(o) o.Eliminado.HasValue And o.Eliminado = False)

        GridEX1.DataSource = HISTORIALEBindingSource
    End Sub
    
    Private Sub GridEX1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = (GridEX1.SelectedItems.Count > 0 And EditarEliminar)
        tst_Eliminar.Enabled = (GridEX1.SelectedItems.Count > 0 And EditarEliminar)

        If Not GridEX1.CurrentRow Is Nothing Then

            If GridEX1.CurrentRow.RowType = Janus.Windows.GridEX.RowType.Record Then
                Historial = GridEX1.CurrentRow.DataRow
                ' AsignaRtf_o_Texto(tb_haHipDiagnostica, Historial.HipotesisDiagnostica)
            

                'Antecedentes
                InfoPrimariaGridEX.DataSource = Historial.PACIENTE.INFORMACIONPRIMARIAs
                GridEXDiagnosticoAntecedente.DataSource = Historial.PACIENTE.AntecedentesDiagnosticos
                tb_haAntecedentes.Text = Globales.TextFromRtf(Historial.ANTECEDENTES)
                If (InfoPrimariaGridEX.RowCount > 0) Or (GridEXDiagnosticoAntecedente.RowCount > 0) Or (tb_haAntecedentes.Text <> String.Empty) Then
                    tab5_Antecedentes.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.True
                Else
                    tab5_Antecedentes.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                End If

                'Historiales diagnosticos
                If Historial.REFDIAGNOSTICO.HasValue Then
                    Dim diag As DIAGNOSTICO = (From c In Context.DIAGNOSTICOs Where c.IDDIAGNOSTICO = Historial.REFDIAGNOSTICO).SingleOrDefault()
                    If Not diag Is Nothing Then
                        txtDiagnoPrincipalCod.Text = diag.CIE10
                        txtDiagnoPrincipalDescrip.Text = diag.DIAGNOSTICO
                    End If
                Else
                    txtDiagnoPrincipalCod.Text = String.Empty
                    txtDiagnoPrincipalDescrip.Text = String.Empty
                End If
                GridEXHipoDiag.DataSource = Historial.HistorialesDiagnosticos
                tb_haHipDiagnostica.Text = Globales.TextFromRtf(Historial.JUICIO)
                If (GridEXHipoDiag.RowCount > 0) Or (Historial.REFDIAGNOSTICO.HasValue) Or (tb_haHipDiagnostica.Text <> String.Empty) Then
                    tab3_HipotesisDiagnostica.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.True
                Else
                    tab3_HipotesisDiagnostica.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                End If

                'Tratamientos / Recetas
                GridEXRecetas.DataSource = (From l In Context.RECETAs Where (l.REFPACIENTE = IdPaciente And l.FECHA.Value.Date = Historial.FECHA.Value.Date And l.Eliminado = False) Select l).ToList()
                tb_haTratamiento.Text = Globales.TextFromRtf(Historial.TRATAMIENTO)
                If (GridEXRecetas.RowCount > 0) Or (tb_haTratamiento.Text <> String.Empty) Then
                    tab3_Tratamiento.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.True
                Else
                    tab3_Tratamiento.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                End If

                'Exploracion
                tb_haExploracion.Text = Globales.TextFromRtf(Historial.EXPLORACION)
                If (tb_haExploracion.Text <> String.Empty) Then
                    tab7_Exploracion.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.True
                Else
                    tab7_Exploracion.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                End If

                'Notas Final
                tb_haNotasfinal.Text = Globales.TextFromRtf(Historial.COMENTARIOS)
                If (tb_haNotasfinal.Text <> String.Empty) Then
                    tab0_NotasFinales.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.True
                Else
                    tab0_NotasFinales.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                End If

                'Historial
                tb_haHistorial.Text = Globales.TextFromRtf(Historial.HISTORIAL)
                If (tb_haHistorial.Text <> String.Empty) Then
                    tab6_Historial.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.True
                Else
                    tab6_Historial.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                End If

                'Otras Observaciones
                tb_haOtrasObserv.Text = Globales.TextFromRtf(Historial.OTROS)
                If (tb_haOtrasObserv.Text <> String.Empty) Then
                    tab8_OtrasObservaciones.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.True
                Else
                    tab8_OtrasObservaciones.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                End If

                'Pruebas comparativas
                tb_haPruebaComp.Text = Globales.TextFromRtf(Historial.COMPLEMENTARIAS)
                If (tb_haPruebaComp.Text <> String.Empty) Then
                    tab1_PruebasComplemen.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.True
                Else
                    tab1_PruebasComplemen.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                End If

                'Motivo
                tb_haMotivoCons.Text = Globales.TextFromRtf(Historial.MOTIVO)
                If (tb_haMotivoCons.Text <> String.Empty) Then
                    tab4_MotivoConsulta.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.True
                Else
                    tab4_MotivoConsulta.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                End If


                If GridEX1.CurrentRow.Parent Is Nothing Then
                    'Es un historial
                    lblTipo.Text = "HISTORIAL"
                    lblTipo.ForeColor = Color.Green
                Else
                    'Es una revision
                    lblTipo.Text = "REVISION"
                    lblTipo.ForeColor = Color.Red
                End If

                'For Each t As UITabPage In UiTab1.TabPages()
                '    If t.Controls.Count > 0 Then
                '        If Not t.Controls(0).Text Is Nothing Then
                '            If t.Controls(0).Text.Trim().Length > 0 Then
                '                t.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.True
                '            Else
                '                t.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                '            End If
                '        Else
                '            t.StateStyles.FormatStyle.FontBold = Janus.Windows.UI.TriState.False
                '        End If
                '    End If
                'Next
            End If
        End If
    End Sub

    Private Function MasDeUnDia(fecha As Nullable(Of Date))
        If fecha.HasValue Then
            Return (Date.Now - fecha.Value).Days > 1
        Else
            Return False
        End If

    End Function

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click

        Dim context As New CMLinqDataContext()
        Dim rev As New HISTORIALE
        rev.REFPACIENTE = IdPaciente


        If Globales.Usuario.REFMEDICO.HasValue Then
            rev.REFMEDICO = Globales.Usuario.REFMEDICO
        Else
            Dim medico As MEDICO = context.MEDICOs.FirstOrDefault()
            If medico Is Nothing Then
                MessageBox.Show("No hay medicos en nomina")
                Return
            End If
            rev.REFMEDICO = medico.CMEDICO
        End If

        rev.ParentHistorial = Nothing
        rev.Eliminado = False
        context.HISTORIALEs.InsertOnSubmit(rev)
        context.SubmitChanges()

        Dim frm As New frmHistoriales_Editar(IdPaciente, rev.PACIENTE.NombreCompleto, rev.CHISTORIAL)
        frm.ShowInTaskbar = False
        frm.HISTORIALEBindingSource.DataSource = rev
        'frm.CtrlMedico1.ID_Medico = rev.REFMEDICO

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            rev.HORA = frm.dpt_hora.Value
            rev.FECHA = frm.dtp_Fecha.Value

            rev.COMPLEMENTARIAS = frm.editPruebas.Text
            rev.TRATAMIENTO = frm.editTratamiento.Text
            rev.JUICIO = frm.editHipDiagnostica.Text
            rev.EXPLORACION = frm.editExploracion.Text
            rev.OTROS = frm.editOtrasObservaciones.Text
            rev.COMENTARIOS = frm.editNotasFinales.Text
            rev.HISTORIAL = frm.editHistorial.Text
            rev.ANTECEDENTES = frm.EditAntecedentes.Text
            rev.MOTIVO = frm.EditMotivo.Text


            context.SubmitChanges()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Historiales_Actuales, "historial", rev.CHISTORIAL, "paciente : " & rev.PACIENTE.NombreCompleto & " médico : " & rev.MEDICO.NOMBRECOMPLETO & " fecha : " & rev.FECHA.ToString())
            CargaDatos()
        Else
            BorrarHistorial(rev)
        End If

    End Sub


    Private Function BorrarHistorial(historial As HISTORIALE) As Boolean

        Try
            Dim Context As New CMLinqDataContext()

            Dim histDiagnosticos As IQueryable(Of HistorialesDiagnostico) = (From h In Context.HistorialesDiagnosticos Where h.CHistorial = historial.CHISTORIAL Select h)
            For Each h As HistorialesDiagnostico In histDiagnosticos
                Context.HistorialesDiagnosticos.DeleteOnSubmit(h)
            Next
            historial = (From h In Context.HISTORIALEs Where h.CHISTORIAL = historial.CHISTORIAL Select h).FirstOrDefault()
            'Context.HISTORIALEs.DeleteOnSubmit(historial)
            historial.Eliminado = True
            Context.SubmitChanges()
            Return True
        Catch
            Return False
        End Try

    End Function

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim frm As New frmOdontograma()
        frm.PacienteActual = Paciente.CPACIENTE
        frm.Text = "Odontograma de " & Paciente.NombreCompleto
        'frm.MdiParent = Me
        frm.ShowDialog()
    End Sub

    Private Sub GridEX1_ColumnButtonClick(sender As System.Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick
        If Not permiso > RoleManager.TipoPermisos.Lectura Then
            MessageBox.Show("usted no tiene permiso para realizar esta acción", "revisión")
            Return
        End If
        Dim textoauxiliar As Boolean = False
        If e.Column.Key = "ColumnAddRev" Then
            Historial = GridEX1.CurrentRow.DataRow

            position = GridEX1.CurrentRow.Position

            Dim parent As HISTORIALE = Historial
            'GridEX1.SelectedItems(0).GetRow().DataRow
            Dim rev As New HISTORIALE
            rev.REFPACIENTE = parent.REFPACIENTE
            rev.REFMEDICO = parent.REFMEDICO
            rev.ParentHistorial = parent.CHISTORIAL
            rev.FECHA = Date.Now
            rev.HORA = Date.Now
            rev.Eliminado = False
            Context.HISTORIALEs.InsertOnSubmit(rev)
            Context.SubmitChanges()
            If textoauxiliar Then
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Historiales_Actuales, "nuevo episodio", rev.CHISTORIAL, " creado por un administrador pese al historial estar bloqueado")
            Else
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Historiales_Actuales, "nuevo episodio", rev.CHISTORIAL, "")
            End If
            CargaDatos()

            GridEX1.EnsureVisible(position)
            If Not GridEX1.CurrentRow Is Nothing Then
                GridEX1.CurrentRow.Expanded = True
            End If
        End If

        If e.Column.Key = "ColumnEliminarRevision" Then
            Try
                If MessageBox.Show("Desea eliminar la revision?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim _hist1 As HISTORIALE = GridEX1.CurrentRow.DataRow

                    Dim _context As New CMLinqDataContext()

                    Dim hist As HISTORIALE = (From h In _context.HISTORIALEs Where h.CHISTORIAL = _hist1.CHISTORIAL Select h).SingleOrDefault()

                    If Not hist Is Nothing Then
                        If hist.FECHA.HasValue Then
                            If MasDeUnDia(hist.FECHA) Then
                                If Not Globales.Usuario.EsAdministrador() Then
                                    MessageBox.Show("No puede editar un historial después de 24 horas de haber sido creado, consulte al administrador", "Editar Historial")
                                    Return
                                Else
                                    textoauxiliar = True
                                    MessageBox.Show("Este historial ha sido creado hace mas de 24 horas,se permite continuar por su rol de administrador  ", "Editar Historial")
                                End If
                            End If

                            Dim esRevision As Boolean = hist.ParentHistorial.HasValue

                            If esRevision Then
                                position = GridEX1.CurrentRow.Parent.Position
                            End If
                            '_context.HISTORIALEs.DeleteOnSubmit(hist)
                            hist.Eliminado = True
                            _context.SubmitChanges()
                            If textoauxiliar Then
                                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Historiales_Actuales, "Nuevo episodio", hist.CHISTORIAL, "realizado por un administrador pese al historial estar bloqueado")
                            Else
                                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Historiales_Actuales, "Nuevo episodio", hist.CHISTORIAL, "")
                            End If

                            CargaDatos()

                            If esRevision Then
                                GridEX1.EnsureVisible(position)
                                If Not GridEX1.CurrentRow Is Nothing Then
                                    'GridEX1.ExpandRecords(GridEX1.CurrentRow.Expanded)
                                    GridEX1.CurrentRow.Expanded = True
                                End If

                            End If
                        Else
                            MessageBox.Show("Fecha es nula!!")
                        End If
                       
                    End If

                   

                End If

            Catch ex As Exception
                MessageBox.Show("Error eliminando revisión, se encuentra en uso por algunas dependencias, eliminelas e intente de nuevo")
            End Try

        End If

        If e.Column.Key = "ColumnPrintHistorial" Then
            Historial = GridEX1.CurrentRow.DataRow

            Dim context As New CMLinqDataContext()
            Dim list As List(Of HISTORIALE) = context.HISTORIALEs.Where(Function(o) o.CHISTORIAL = Historial.CHISTORIAL And o.Eliminado = False).ToList()
            Imprime(list)
            context.Dispose()
        End If



    End Sub

    Private Sub LimpiarRtfs(ByRef historia As HISTORIALE)

        historia.COMENTARIOS = Globales.TextFromRtf(historia.COMENTARIOS)
        historia.COMPLEMENTARIAS = Globales.TextFromRtf(historia.COMPLEMENTARIAS)
        historia.EXPLORACION = Globales.TextFromRtf(historia.EXPLORACION)
        historia.HISTORIAL = Globales.TextFromRtf(historia.HISTORIAL)
        historia.JUICIO = Globales.TextFromRtf(historia.JUICIO)
        historia.MOTIVO = Globales.TextFromRtf(historia.MOTIVO)
        historia.TRATAMIENTO = Globales.TextFromRtf(historia.TRATAMIENTO)
        historia.OTROS = Globales.TextFromRtf(historia.OTROS)
        'historia.HipotesisDiagnostica = Globales.TextFromRtf(historia.HipotesisDiagnostica)
        historia.ANTECEDENTES = Globales.TextFromRtf(historia.ANTECEDENTES)
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click
        If Not GridEX1.CurrentRow Is Nothing Then
            Historial = GridEX1.CurrentRow.DataRow
            position = GridEX1.CurrentRow.Position
            If Not Historial Is Nothing Then
                Dim textoauxiliar As Boolean = False
                If Historial.FECHA.HasValue Then
                    If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Bloquear_historial) = RoleManager.TipoPermisos.Ninguno Then
                        If MasDeUnDia(Historial.FECHA) Then
                            If Not Globales.Usuario.EsAdministrador() Then
                                MessageBox.Show("No puede editar un historial despues de 24 horas de haber sido creado, si es necesario consulte al administrador", "Editar Historial")

                            Else
                                textoauxiliar = True
                                MessageBox.Show("Advertencia: Este historial ha sido creado hace mas de 24 horas,se le permite continuar debido a su rol de administrador", "Editar Historial")
                            End If
                        End If
                    End If
                End If

                Dim frm As New frmHistoriales_Editar(IdPaciente, Paciente.NombreCompleto, Historial.CHISTORIAL)

                Context = New CMLinqDataContext()

                Dim hist As HISTORIALE = (From h In Context.HISTORIALEs Where Historial.CHISTORIAL = h.CHISTORIAL Select h).First()

                LimpiarRtfs(hist)
                frm.HISTORIALEBindingSource.DataSource = hist
                frm.ShowInTaskbar = False
                If Not hist.FECHA Is Nothing Then
                    frm.dtp_Fecha.Value = hist.FECHA
                End If
                If Not hist.HORA Is Nothing Then
                    frm.dpt_hora.Value = hist.HORA
                End If
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                    Context.SubmitChanges()
                    If textoauxiliar Then
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Pacientes_Historiales_Actuales, "historial", hist.CHISTORIAL, "paciente : " & hist.PACIENTE.NombreCompleto & " médico : " & hist.MEDICO.NOMBRECOMPLETO & " fecha : " & hist.FECHA.ToString() & "editado por un administrador pese a estar blooquedo")
                    Else
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Pacientes_Historiales_Actuales, "historial", hist.CHISTORIAL, "paciente : " & hist.PACIENTE.NombreCompleto & " médico : " & hist.MEDICO.NOMBRECOMPLETO & " fecha : " & hist.FECHA.ToString())
                    End If

                    CargaDatos()
                End If

                GridEX1.EnsureVisible(position)
                If Not GridEX1.CurrentRow Is Nothing Then
                    GridEX1.CurrentRow.Expanded = True
                End If

            End If
        End If

    End Sub

    Private Sub TstEliminarClick(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar.Click
        Try

            Dim textoauxiliar As Boolean = False
            If MessageBox.Show("Desea eliminar el Historial/revision?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Historial = GridEX1.CurrentRow.DataRow
                position = GridEX1.CurrentRow.Position

                If Historial.FECHA.HasValue Then
                    If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Bloquear_historial) = RoleManager.TipoPermisos.Ninguno Then
                        If MasDeUnDia(Historial.FECHA) Then
                            If Not Globales.Usuario.EsAdministrador() Then
                                MessageBox.Show("No puede eliminar un historial despues de 24 horas de haber sido creado, consulte al administrador", "Eliminar Historial")
                                Return
                            Else
                                textoauxiliar = True
                                MessageBox.Show("Este historial ha sido creado hace mas de 24 horas,se le permite continuar por su rol de administrador  ", "Eliminar Historial")
                            End If
                        End If
                    End If
                End If
               
                Dim esRevision As Boolean = Historial.ParentHistorial.HasValue
                Context = New CMLinqDataContext()

                Dim hist As HISTORIALE = (From h In Context.HISTORIALEs Where Historial.CHISTORIAL = h.CHISTORIAL Select h).First()

                If Historial.FECHA.HasValue Then
                    If MasDeUnDia(hist.FECHA) And Not Globales.Usuario.EsAdministrador() Then
                        MessageBox.Show("No puede eliminar un historial despues de 24 horas de haber sido creado, consulte al administrador", "Eliminar Historial")
                        Return
                    End If
                End If
                
                If textoauxiliar Then
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Historiales_Actuales, "historial", hist.CHISTORIAL, "paciente : " & hist.PACIENTE.NombreCompleto & " médico : " & hist.MEDICO.NOMBRECOMPLETO & "eliminado por un administrador pese a estar blooquedo")
                Else
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Historiales_Actuales, "historial", hist.CHISTORIAL, "paciente : " & hist.PACIENTE.NombreCompleto & " médico : " & hist.MEDICO.NOMBRECOMPLETO)
                End If


                'Context.HISTORIALEs.DeleteOnSubmit(hist)
                hist.Eliminado = True


                Context.SubmitChanges()
                tst_Editar.Enabled = False
                tst_Eliminar.Enabled = False

                If esRevision Then
                    GridEX1.EnsureVisible(position)
                End If

                CargaDatos()
            End If

        Catch ex As Exception
            MessageBox.Show("Error eliminando historial, se encuentra en uso por algunas dependencias, eliminelas e intente de nuevo")
        End Try
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If Modo = Globales.ModoParaFormas.Edicion Then
            If Me.EditarEliminar Then
                tst_Editar_Click(Nothing, Nothing)
            End If
        Else
            Historial = GridEX1.CurrentRow.DataRow
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Public Sub LimpiaHistorial(ByRef historia As HISTORIALE)

        historia.ANTECEDENTES = Globales.TextFromRtf(historia.ANTECEDENTES)
        If Not historia.ANTECEDENTES Is Nothing Then
            If historia.ANTECEDENTES.Length > 0 Then
                If historia.ANTECEDENTES.Trim().Length > 0 Then
                    historia.ANTECEDENTES = historia.ANTECEDENTES.Trim() + vbCrLf
                End If

            End If
        End If


        'Annadir todos los antecedentes
        For Each an As AntecedentesDiagnostico In historia.PACIENTE.AntecedentesDiagnosticos
            historia.ANTECEDENTES += an.DIAGNOSTICO + ". " + an.OBSERVACIONES + vbCrLf
        Next


        historia.COMENTARIOS = Globales.TextFromRtf(historia.COMENTARIOS)
        historia.COMPLEMENTARIAS = Globales.TextFromRtf(historia.COMPLEMENTARIAS)
        historia.EXPLORACION = Globales.TextFromRtf(historia.EXPLORACION)
        historia.HISTORIAL = Globales.TextFromRtf(historia.HISTORIAL)
        historia.JUICIO = Globales.TextFromRtf(historia.JUICIO)
        historia.MOTIVO = Globales.TextFromRtf(historia.MOTIVO)
        historia.TRATAMIENTO = Globales.TextFromRtf(historia.TRATAMIENTO)
        historia.OTROS = Globales.TextFromRtf(historia.OTROS)
        historia.HipotesisDiagnostica = Globales.TextFromRtf(historia.HipotesisDiagnostica)
    End Sub


    Private Sub Imprime(ByRef historialesRoot As List(Of HISTORIALE))
        Try


            'Imprimir todos los historiales

            Dim dsPaciente As New ReportDataSource()
            Dim pac As PACIENTE = Paciente
            Dim paclist As New List(Of PACIENTE)
            paclist.Add(pac)
            dsPaciente.Name = "CMDataSet_PACIENTES"
            dsPaciente.Value = paclist


            Dim dsHistorial As New ReportDataSource()

            Dim historiales As New List(Of WRAPPER_HISTORIAL)


            For Each historia As HISTORIALE In historialesRoot
                LimpiaHistorial(historia)
                historiales.Add(New WRAPPER_HISTORIAL(historia))
                For Each re As HISTORIALE In historia.HISTORIALEs.Where(Function(o) o.Eliminado = False)
                    LimpiaHistorial(re)
                    historiales.Add(New WRAPPER_HISTORIAL(re))
                Next
            Next

            dsHistorial.Name = "CMDataSet_HISTORIALES"
            dsHistorial.Value = historiales

            UI.Reportes.ReportesManager.Imprime("HistorialesResumen.rdlc", {dsHistorial, dsPaciente})

            'End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error imprimiendo historial(es)")
        End Try
    End Sub


    Private Sub Imprime(historia As HISTORIALE)
        Try
            Dim dsPaciente As New ReportDataSource()
            Dim pac As PACIENTE = Paciente
            Dim paclist As New List(Of PACIENTE)
            paclist.Add(pac)
            dsPaciente.Name = "CMDataSet_PACIENTES"
            dsPaciente.Value = paclist

            Dim dsHistorial As New ReportDataSource()

            Dim historiales As New List(Of WRAPPER_HISTORIAL)

            LimpiaHistorial(historia)
            historiales.Add(New WRAPPER_HISTORIAL(historia))
            For Each re As HISTORIALE In historia.HISTORIALEs
                LimpiaHistorial(re)
                historiales.Add(New WRAPPER_HISTORIAL(re))
            Next

            dsHistorial.Name = "CMDataSet_HISTORIALES"
            dsHistorial.Value = historiales



                Dim rayParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

            ' If Not rpt_parameters.Item("param_DNI") Is Nothing Then
            If Not pac.DNI Is Nothing Then
                rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_DNI", pac.DNI.ToString() & Globales.GetLetter(pac.DNI.ToString())))
            Else
                rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_DNI", ""))
            End If
            ' End If

            'If Not rpt_parameters.Item("param_PASAPORTE") Is Nothing Then
            If Not pac.PASAPORTE Is Nothing Then
                rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_PASAPORTE", pac.PASAPORTE.ToString()))
            Else
                rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_PASAPORTE", ""))
            End If
            'End If

            UI.Reportes.ReportesManager.Imprime("HistorialesResumen.rdlc", {dsHistorial, dsPaciente}, rayParam.ToArray())

            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tlbImprimir_Click(sender As System.Object, e As System.EventArgs) Handles tlbImprimir.Click
        If GridEX1.CurrentRow Is Nothing Then
            Return
        End If

        Historial = GridEX1.CurrentRow.DataRow
        Dim context As New CMLinqDataContext
        'para imprimir a un padre con sus hijos
        'Dim historialesRoot As List(Of HISTORIALE) = (From h As HISTORIALE In context.HISTORIALEs
        '                                            Where h.CHISTORIAL = Historial.CHISTORIAL Select h).ToList()

        'para imprimir todos los historiales
        Dim historialesRoot As New List(Of HISTORIALE)
        For Each h As GridEXRow In GridEX1.GetRows
            historialesRoot.Add(h.DataRow)
        Next

        Imprime(historialesRoot)
        context.Dispose()
    End Sub

    Private Sub GridEXRecetas_SelectionChanged(sender As Object, e As EventArgs) Handles GridEXRecetas.SelectionChanged
        If Not GridEXRecetas.CurrentRow Is Nothing Then
            If GridEXRecetas.CurrentRow.RowType = 0 Then
                Dim selected As RECETA = GridEXRecetas.CurrentRow.DataRow
                If Not selected Is Nothing Then
                    txtRecetaSelecDescripcion.Text = selected.TRATAMIENTO
                Else
                    txtRecetaSelecDescripcion.Text = String.Empty
                End If
            Else
                txtRecetaSelecDescripcion.Text = String.Empty
            End If
        Else
            txtRecetaSelecDescripcion.Text = String.Empty
        End If

    End Sub

 
End Class



Partial Public Class MEDICO


    Public ReadOnly Property NOMBRECOMPLETO As String
        Get
            Return (Me.NOMBRE & " " & Me.APELLIDO1 & " " & Me.APELLIDO2).Trim()
        End Get
    End Property

End Class



Partial Public Class HISTORIALE

    'Public Property Diagnosticos As String
    '    Get

    '    End Get
    '    Set(value As String)

    '    End Set
    'End Property


    Public Property HipotesisDiagnostica() As String
        Get
            Dim res As String = ""

            ' Me.HistorialesDiagnosticos.Load()
            If Not Me.REFDIAGNOSTICO Is Nothing Then
                Dim diagnostigo As DIAGNOSTICO = (From d In Globales.Context.DIAGNOSTICOs
                                                 Where d.IDDIAGNOSTICO = Me.REFDIAGNOSTICO
                                                 Select d).SingleOrDefault()
                If Not diagnostigo Is Nothing Then
                    res = res & Globales.TextFromRtf(diagnostigo.DIAGNOSTICO) & vbCrLf
                End If

            End If

            For Each h As HistorialesDiagnostico In Me.HistorialesDiagnosticos
                res = res & Globales.TextFromRtf(h.DIAGNOSTICO) & vbCrLf
            Next

            If Not Me.JUICIO Is Nothing Then
                res = res & Globales.TextFromRtf(Me.JUICIO) & vbCrLf
            End If
            Return res & vbCrLf
        End Get
        Set(value As String)

        End Set
    End Property


    
End Class