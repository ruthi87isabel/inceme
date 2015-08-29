Imports System.IO
Imports System.Xml.Linq

Public Class frmRevisiones

    Public ID_Paciente As Integer
    Private context As CMLinqDataContext
    Public Revision As COMPARATIVA

    Private Sub frmRevisiones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CtrlImageWithStickers1.tsOpciones.Visible = False
        CargaDatos()
        AplicaPermisos()
        'ActualizarFechaNac()
    End Sub

#Region "Private Sub AplicaPermisos()"
    Private Sub AplicaPermisos()
        tstRevisiones.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > RoleManager.TipoPermisos.Lectura)
        'tstRevisiones.ReadOnly = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 2)
        tstRevisiones.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 3)
        tst_RevisionComparada_ADD.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 2)
        tst_RevisionComparada_Editar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 2)
        tst_RevisionComparada_Eliminar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 3)
        dtp_revDetFecha.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 2)
        tb_revDetDescripcion.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 2)
        'bt_revDetDescripcion.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 2)
        tb_revNotas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 2)
        'dtg_revSeguimientos.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 2)
        'dtg_revResultados.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Revisiones_Comparativas) > 2)

    End Sub
#End Region


    Public Sub CargaDatos()
        Grid_Comparativas.DataSource = Nothing
        grid_Revisiones.DataSource = Nothing
        'Grid_Tratamientos.DataSource = Nothing
        GridEX_Resultados.DataSource = Nothing
        context = New CMLinqDataContext()

        COMPARATIVABindingSource.DataSource = (From c As COMPARATIVA In context.COMPARATIVAs Where c.REFPACIENTE = ID_Paciente Select c).ToList()
        Grid_Comparativas.DataSource = COMPARATIVABindingSource

    End Sub

#Region "Private Sub CargaDetalles()"
    Private Sub CargaDetalles()
        If Grid_Comparativas.CurrentRow Is Nothing Then
            Return
        End If

        Revision = Grid_Comparativas.CurrentRow.DataRow

        grid_Revisiones.DataSource = LCOMPARATIVAsBindingSource
        'Grid_Tratamientos.DataSource = LCOMPARATIVASTRATAMIENTOsBindingSource
        GridEX_Resultados.DataSource = DATOSCOMPARATIVAsBindingSource

        CtrlImageWithStickers1.Clear()

        'Cargar todos los tratamientos de todas las revisiones de esta comparativa
        Dim tratamientos As List(Of LCOMPARATIVAS_TRATAMIENTO) = (From t As LCOMPARATIVAS_TRATAMIENTO In context.LCOMPARATIVAS_TRATAMIENTOs _
                                                                 Where t.LCOMPARATIVA.REFCOMPARATIVA = Revision.CODIGO _
                                                                 Select t).ToList()

        For Each t As LCOMPARATIVAS_TRATAMIENTO In tratamientos
            If Not t.Layout Is Nothing Then
                CtrlImageWithStickers1.AddPointer(t)
            End If
        Next

        If Not grid_Revisiones.CurrentRow Is Nothing Then
            Dim lcomparativa As LCOMPARATIVA = grid_Revisiones.CurrentRow.DataRow
            CtrlImageWithStickers1.ResaltaStickersWithParentID(lcomparativa.ID)
        End If

        'If Not Revision.IMAGEN Is Nothing Then
        '    Dim ms As New MemoryStream(Revision.IMAGEN.ToArray())
        '    CtrlImageWithStickers1.BackIMAGE = Image.FromStream(ms)
        'Else
        '    CtrlImageWithStickers1.BackIMAGE = Nothing
        'End If

    End Sub
#End Region


    Private Sub Grid_Comparativas_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles Grid_Comparativas.SelectionChanged
        tst_RevisionComparada_Editar.Enabled = Grid_Comparativas.SelectedItems.Count > 0
        tst_RevisionComparada_Eliminar.Enabled = Grid_Comparativas.SelectedItems.Count > 0
        tstDuplicarRevision.Enabled = Grid_Comparativas.SelectedItems.Count > 0
        tstConsultarGrafica.Enabled = Grid_Comparativas.SelectedItems.Count > 0
        CargaDetalles()
    End Sub


    Private Sub grid_Revisiones_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles grid_Revisiones.SelectionChanged
    
        If Not grid_Revisiones.CurrentRow Is Nothing Then
            Dim lcomparativa As LCOMPARATIVA = grid_Revisiones.CurrentRow.DataRow
            If (Not lcomparativa.MODELOSCOMPARATIVA.IMAGEN Is Nothing) Then
                Dim ms As New MemoryStream(lcomparativa.MODELOSCOMPARATIVA.IMAGEN.ToArray())
                CtrlImageWithStickers1.BackIMAGE = Image.FromStream(ms)
            Else
                CtrlImageWithStickers1.BackIMAGE = Nothing
            End If
            CtrlImageWithStickers1.ResaltaStickersWithParentID(lcomparativa.ID)
        End If
    End Sub


#Region "Private Sub GridEX1_FormattingRow(sender As System.Object, e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX_Resultados.FormattingRow"
    Private Sub GridEX1_FormattingRow(sender As System.Object, e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX_Resultados.FormattingRow
        Dim dato As DATOSCOMPARATIVA = e.Row.DataRow

        Dim valor As Object = Globales.ValorModelo(dato)

        If IsNumeric(valor) Then
            e.Row.Cells("ColumnValue").Text = CType(valor, Double).ToString("N3")
        Else
            e.Row.Cells("ColumnValue").Text = valor
        End If


    End Sub
#End Region


    Private Sub tst_RevisionComparada_ADD_Click(sender As System.Object, e As System.EventArgs) Handles tst_RevisionComparada_ADD.Click

        Dim frm As New frmRevComparativa_Editar()
        frm.ID_Paciente = ID_Paciente
        frm.CODIGO = "-1"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar,
                                            RoleManager.Items.Pacientes_Revisiones_Comparativas, "Revision Comparativa",
                                            frm.Revision.CODIGO,
                                            String.Format("Paciente: [{0}] {1}  Fecha: {2}  ",
                                                          frm.Revision.PACIENTE.CPACIENTE,
                                                          frm.Revision.PACIENTE.NombreCompleto,
                                                          frm.Revision.FECHA))





            CargaDatos()
        Else
            'Aqui hay que borrar la comparativa
            BorrarComparativa(frm.CODIGO)
        End If
    End Sub


    Private Sub BorrarComparativa(ByVal codigo As String)
        Try
            Dim context As New CMLinqDataContext
            Dim comp As COMPARATIVA = (From c As COMPARATIVA In context.COMPARATIVAs Where c.CODIGO = codigo Select c).SingleOrDefault()
            If Not comp Is Nothing Then


                For Each linea As LCOMPARATIVA In comp.LCOMPARATIVAs
                    'Borrar los datos por lineas
                    context.DATOSCOMPARATIVAs.DeleteAllOnSubmit(linea.DATOSCOMPARATIVAs)
                    context.SubmitChanges()

                    context.LCOMPARATIVAS_TRATAMIENTOs.DeleteAllOnSubmit(linea.LCOMPARATIVAS_TRATAMIENTOs)
                    context.SubmitChanges()
                Next

                'Borrar los seguimientos
                context.LCOMPARATIVAs.DeleteAllOnSubmit(comp.LCOMPARATIVAs)
                context.SubmitChanges()

                context.COMPARATIVAs.DeleteOnSubmit(comp)
                context.SubmitChanges()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub tstDuplicarRevision_Click(sender As System.Object, e As System.EventArgs) Handles tstDuplicarRevision.Click
        
        Dim comparativaOriginal As COMPARATIVA = COMPARATIVABindingSource.Current
        If comparativaOriginal Is Nothing Then
            Return
        End If
       
        'Duplicar la comparativa

        Dim nuevaComparativa As COMPARATIVA = New COMPARATIVA()

        If comparativaOriginal.REFPACIENTE.HasValue Then
            nuevaComparativa.REFPACIENTE = comparativaOriginal.REFPACIENTE
        End If

        If Not comparativaOriginal.DESCRIPCION Is Nothing Then
            nuevaComparativa.DESCRIPCION = comparativaOriginal.DESCRIPCION
        End If

        If comparativaOriginal.FECHA.HasValue Then
            nuevaComparativa.FECHA = comparativaOriginal.FECHA
        End If

        If Not comparativaOriginal.NOTAS Is Nothing Then
            nuevaComparativa.NOTAS = nuevaComparativa.NOTAS
        End If

        If Not comparativaOriginal.REFMODELOCOMPARATIVA Is Nothing Then
            nuevaComparativa.REFMODELOCOMPARATIVA = comparativaOriginal.REFMODELOCOMPARATIVA
        End If

        nuevaComparativa.IMAGEN = comparativaOriginal.IMAGEN
        nuevaComparativa.FECHATERMINADA = comparativaOriginal.FECHATERMINADA


        context.COMPARATIVAs.InsertOnSubmit(nuevaComparativa)
        context.SubmitChanges()

        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar,
                                          RoleManager.Items.Pacientes_Revisiones_Comparativas, "Revision Comparativa Duplicada",
                                          nuevaComparativa.CODIGO,
                                          String.Format("Duplicada rev [{3}]->[{4}]: [{0}] Paciente: [{1}]  Fecha: {2}  ",
                                                        nuevaComparativa.PACIENTE.CPACIENTE,
                                                        nuevaComparativa.PACIENTE.NombreCompleto,
                                                        nuevaComparativa.FECHA,
                                                        comparativaOriginal.CODIGO,
                                                        nuevaComparativa.CODIGO
                                                        ))


        'Ahora replicar las lineascomparativas

        For Each lineaOriginal As LCOMPARATIVA In comparativaOriginal.LCOMPARATIVAs
            Dim nuevaLinea As New LCOMPARATIVA()
            nuevaLinea.REFCOMPARATIVA = nuevaComparativa.CODIGO

            If lineaOriginal.FECHA.HasValue Then
                nuevaLinea.FECHA = lineaOriginal.FECHA
            End If

            If lineaOriginal.HORA.HasValue Then
                nuevaLinea.HORA = lineaOriginal.HORA
            End If

            If Not lineaOriginal.REFMODELOCOMPARATIVA Is Nothing Then
                nuevaLinea.REFMODELOCOMPARATIVA = lineaOriginal.REFMODELOCOMPARATIVA
            End If

            If Not lineaOriginal.DESCRIPCION Is Nothing Then
                nuevaLinea.DESCRIPCION = lineaOriginal.DESCRIPCION
            End If

            If Not lineaOriginal.NOTAS Is Nothing Then
                nuevaLinea.NOTAS = lineaOriginal.NOTAS
            End If

            context.LCOMPARATIVAs.InsertOnSubmit(nuevaLinea)
            context.SubmitChanges()

            'Ahora los datos de la comparativa

            For Each datoOriginal As DATOSCOMPARATIVA In lineaOriginal.DATOSCOMPARATIVAs
                Dim datoNuevo As New DATOSCOMPARATIVA()

                datoNuevo.REFLCOMPARATIVA = nuevaLinea.ID

                If datoOriginal.DFLOAT.HasValue Then
                    datoNuevo.DFLOAT = datoOriginal.DFLOAT
                End If

                If Not datoOriginal.DBOOLEAN Is Nothing Then
                    datoNuevo.DBOOLEAN = datoOriginal.DBOOLEAN
                End If
                If Not datoOriginal.DVARCHAR Is Nothing Then
                    datoNuevo.DVARCHAR = datoOriginal.DVARCHAR
                End If

                If Not datoOriginal.DXML Is Nothing Then
                    datoNuevo.DXML = datoOriginal.DXML

                End If

                datoNuevo.REFMODELODATO = datoOriginal.REFMODELODATO

                context.DATOSCOMPARATIVAs.InsertOnSubmit(datoNuevo)
                context.SubmitChanges()
            Next


            'Clonar los tratamientos
            For Each ori_trat As LCOMPARATIVAS_TRATAMIENTO In lineaOriginal.LCOMPARATIVAS_TRATAMIENTOs
                Dim nuevoTrat As New LCOMPARATIVAS_TRATAMIENTO
                nuevoTrat.Comentarios = ori_trat.Comentarios
                nuevoTrat.Fecha = ori_trat.Fecha
                nuevoTrat.ID_LCOMPARATIVA = nuevaLinea.ID
                nuevoTrat.REFCONCEPTOFRA = ori_trat.REFCONCEPTOFRA
                nuevoTrat.Tratamiento = ori_trat.Tratamiento
                nuevoTrat.Unidad = ori_trat.Unidad
                nuevoTrat.Valor_Unidad = ori_trat.Valor_Unidad
                nuevoTrat.Layout = ori_trat.Layout
                context.LCOMPARATIVAS_TRATAMIENTOs.InsertOnSubmit(nuevoTrat)
                context.SubmitChanges()
            Next
        Next
        CargaDatos()
    End Sub

    

    Private Sub tst_RevisionComparada_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_RevisionComparada_Editar.Click
        If Grid_Comparativas.SelectedItems.Count > 0 Then
            If Not COMPARATIVABindingSource.Current Is Nothing Then
                Dim _Cod As String = COMPARATIVABindingSource.Current.CODIGO

                'Dim frm As frmRevisionComparativa_ADD2 = New frmRevisionComparativa_ADD2(Me.CMDataSet, fId)
                'frm.Codigo = dtg_revComparativas.SelectedRows(0).Cells(CODIGODREVISIONdatagridColumn.Name).Value
                Dim frm As New frmRevComparativa_Editar()
                frm.ID_Paciente = ID_Paciente
                frm.CODIGO = _Cod

                'Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir,
                '                          RoleManager.Items.Pacientes_Revisiones_Comparativas, "Revision Comparativa",
                '                          frm.Revision.CODIGO,
                '                          String.Format("Paciente: [{0}] {1}  Fecha: {2}",
                '                                        frm.Revision.PACIENTE.CPACIENTE,
                '                                        frm.Revision.PACIENTE.NombreCompleto,
                '                                        frm.Revision.FECHA))

                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    CargaDatos()
                End If
            End If
        End If
    End Sub

    Private Sub tst_RevisionComparada_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tst_RevisionComparada_Eliminar.Click
        If Grid_Comparativas.SelectedItems.Count > 0 Then
            If Not COMPARATIVABindingSource.Current Is Nothing Then
                If MessageBox.Show("¿Está seguro que desea eliminar la Revisión y sus datos asociados?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                    Dim comparativa As COMPARATIVA = COMPARATIVABindingSource.Current
                    BorrarComparativa(comparativa.CODIGO)

                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar,
                                        RoleManager.Items.Pacientes_Revisiones_Comparativas, "Revision Comparativa",
                                        comparativa.CODIGO,
                                        String.Format("Paciente: [{0}] {1}  Fecha: {2}",
                                                     comparativa.PACIENTE.CPACIENTE,
                                                     comparativa.PACIENTE.NombreCompleto,
                                                     comparativa.FECHA))
                    CargaDatos()
                End If
            End If
        End If
    End Sub

    Private Sub tstConsultarGrafica_Click(sender As System.Object, e As System.EventArgs) Handles tstConsultarGrafica.Click
        If Grid_Comparativas.SelectedItems.Count > 0 Then
            If Not COMPARATIVABindingSource.Current Is Nothing Then
                Dim comparativa As COMPARATIVA = COMPARATIVABindingSource.Current

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir,
                                          RoleManager.Items.Pacientes_Revisiones_Comparativas, "Gráfico Revision Comparativa",
                                          comparativa.CODIGO,
                                          String.Format("Paciente: [{0}] {1}  Fecha: {2} ",
                                                        comparativa.PACIENTE.CPACIENTE,
                                                        comparativa.PACIENTE.NombreCompleto,
                                                        comparativa.FECHA))

                Dim _grafico As form_grafica_rev_comp = New form_grafica_rev_comp(comparativa.CODIGO, comparativa.PACIENTE.NombreCompleto)
                _grafico.ShowInTaskbar = False
                _grafico.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Grid_Comparativas_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid_Comparativas.RowDoubleClick
        tst_RevisionComparada_Editar_Click(Nothing, Nothing)
    End Sub
End Class