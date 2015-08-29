Imports System.Xml.Linq
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Reportes


Public Class frmRevComparativa_Editar

    Public Revision As COMPARATIVA
    Public CODIGO As String = "3"
    Public ID_Paciente As Integer
    Public context As CMLinqDataContext


    Private Sub frmRevComparativa_Editar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If CODIGO = "-1" Then
            'Insertar una nueva
            context = New CMLinqDataContext
            Revision = New COMPARATIVA()
            Revision.REFPACIENTE = ID_Paciente
            Revision.FECHA = Date.Now
            context.COMPARATIVAs.InsertOnSubmit(Revision)
            context.SubmitChanges()
            CODIGO = Revision.CODIGO
        End If
        CargaDatos()
    End Sub

    Public Sub CargaDatos()
        grid_Revisiones.DataSource = Nothing
        Grid_Tratamientos.DataSource = Nothing
        GridEX_Resultados.DataSource = Nothing
        context = New CMLinqDataContext()
        Revision = (From c As COMPARATIVA In context.COMPARATIVAs Where c.CODIGO = CODIGO Select c).SingleOrDefault
        COMPARATIVABindingSource.DataSource = Revision

        grid_Revisiones.DataSource = LCOMPARATIVAsBindingSource
        Grid_Tratamientos.DataSource = LCOMPARATIVASTRATAMIENTOsBindingSource
        GridEX_Resultados.DataSource = DATOSCOMPARATIVAsBindingSource

        CtrlImageWithStickers1.Clear()

        'Cargar todos los tratamientos de todas las revisiones de esta comparativa
        Dim tratamientos As List(Of LCOMPARATIVAS_TRATAMIENTO) = (From t As LCOMPARATIVAS_TRATAMIENTO In context.LCOMPARATIVAS_TRATAMIENTOs _
                                                                 Where t.LCOMPARATIVA.REFCOMPARATIVA = CODIGO _
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


        'Ver si esta cerrada
        If Not Revision Is Nothing Then
            If Revision.FECHATERMINADA.HasValue Then
                'Esta cerrada
                lblRevisionCerrada.Visible = True

                If Not Globales.Usuario.EsAdministrador() Then
                    'Desactivar la edicion
                    tsSeguimientos.Enabled = False
                    tstTratamientos.Enabled = False
                    tstNuevaCita.Enabled = False
                    CtrlImageWithStickers1.Enabled = False
                    gb_RCDatos.Enabled = False
                    tstGuardar.Enabled = False
                    tstCancelar.Enabled = False
                End If

            End If
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







#Region "Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick"
    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX_Resultados.RowDoubleClick
        If Not tsSeguimientos.Enabled Then
            Return
        End If

        Dim frm As New frmRC_EditarResultados()
        Dim dato As DATOSCOMPARATIVA = e.Row.DataRow

        If ((Now - dato.LCOMPARATIVA.FECHA.Value).Days > 1) And RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Bloquear_historial) = RoleManager.TipoPermisos.Ninguno Then
            MsgBox("No puede editar datos de un seguimiento transcurridos 24h.", MsgBoxStyle.Exclamation)
            Return
        ElseIf ((Now - dato.LCOMPARATIVA.FECHA.Value).Days > 1) Then
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Pacientes_SeguimientoRevision, "Seguimiento de Revisión", dato.LCOMPARATIVA.ID, "Se ha abierto en modo edición un seguimiento que tiene más de 24h (" & dato.LCOMPARATIVA.COMPARATIVA.PACIENTE.NombreCompleto & "(" & dato.LCOMPARATIVA.COMPARATIVA.PACIENTE.CPACIENTE & "). Se ha permitido por la definición del rol del usuario. ")
        End If

        If dato.OcultarImpresionCliente Is Nothing Then
            frm.OcultarImpresionCliente = False
        Else
            frm.OcultarImpresionCliente = dato.OcultarImpresionCliente
        End If

        frm.lblNombreDato.Text = dato.MODELOSDATO.NOMBREDATO

        Select Case dato.MODELOSDATO.TIPODATO
            Case "T"
                frm.Tipo = frmRC_EditarResultados.TipoDato.Texto
                frm.Valor = dato.DVARCHAR
            Case "N"
                frm.Tipo = frmRC_EditarResultados.TipoDato.Entero
                frm.Valor = dato.DFLOAT
            Case "B"
                frm.Tipo = frmRC_EditarResultados.TipoDato.Booleano
                frm.Valor = dato.DBOOLEAN
            Case "E"
                frm.Tipo = frmRC_EditarResultados.TipoDato.OpcionesExclusivas
                frm.Valor = dato.DXML
                frm.DXML = dato.DXML
            Case "M"
                frm.Tipo = frmRC_EditarResultados.TipoDato.OpcionesMultiples
                frm.Valor = dato.DXML
                frm.DXML = dato.DXML
            Case "X"

                Dim frmExpresiones As New frmRC_Expresiones

                frmExpresiones.lblNombreDato.Text = dato.MODELOSDATO.NOMBREDATO
                frmExpresiones.Campos = Globales.DameCampos(dato)
                frmExpresiones.Expresion = dato.DXML.Value
                frmExpresiones.OcultarImpresionCliente = IIf(dato.OcultarImpresionCliente Is Nothing, False, dato.OcultarImpresionCliente)

                If frmExpresiones.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    dato.DXML.Value = frmExpresiones.Expresion
                    dato.OcultarImpresionCliente = frmExpresiones.OcultarImpresionCliente
                    GridEX_Resultados.Refresh()
                    Guardar()
                End If
                Return
        End Select


        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            dato.OcultarImpresionCliente = frm.OcultarImpresionCliente
            Select Case frm.Tipo
                Case frmRC_EditarResultados.TipoDato.Texto
                    dato.DVARCHAR = frm.Valor
                Case frmRC_EditarResultados.TipoDato.Entero
                    dato.DFLOAT = Double.Parse(frm.Valor)
                Case frmRC_EditarResultados.TipoDato.Booleano
                    dato.DBOOLEAN = frm.Valor
                Case frmRC_EditarResultados.TipoDato.OpcionesExclusivas
                    dato.DXML = frm.DXML
                Case frmRC_EditarResultados.TipoDato.OpcionesMultiples
                    dato.DXML = frm.DXML
            End Select

            GridEX_Resultados.Refresh()
            Guardar()
            'CargaDatos()
        End If

    End Sub
#End Region



#Region "Private Sub tstAnnadir_Tratamiento_Click(sender As System.Object, e As System.EventArgs) Handles tstAnnadir_Tratamiento.Click"
    Private Sub tstAnnadir_Tratamiento_Click(sender As System.Object, e As System.EventArgs) Handles tstAnnadir_Tratamiento.Click
        Dim frm As New frm_RevisionesComparativas_Editar_Tratamiento

        Dim tratamiento As New LCOMPARATIVAS_TRATAMIENTO
        tratamiento.Fecha = Date.Now
        tratamiento.Facturada = False

        If grid_Revisiones.GetRow() Is Nothing Then
            MessageBox.Show("Se requiere una revision para agregar tratamientos")
            Return
        End If

        Dim currentComparativa As LCOMPARATIVA = grid_Revisiones.GetRow().DataRow

        If (Now - currentComparativa.FECHA.Value).Days >= 1 Then
            MessageBox.Show("Ha transcurrido más de un dia desde la creación de este seguimiento, no puede ser modificado")
            Return
        End If

        tratamiento.ID_LCOMPARATIVA = currentComparativa.ID
        frm.LCOMPARATIVAS_TRATAMIENTOsBindingSource.DataSource = tratamiento

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            context.LCOMPARATIVAS_TRATAMIENTOs.InsertOnSubmit(tratamiento)
            context.SubmitChanges()

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar,
                                       RoleManager.Items.Pacientes_TratamientoSeguimiento, "Tratamiento de Revision",
                                       tratamiento.ID,
                                       String.Format("Tratamiento: [{0}] {1} Paciente:[{2}] {3} Fecha: {2}  ",
                                                     tratamiento.ID,
                                                     tratamiento.Tratamiento,
                                                     Revision.PACIENTE.CPACIENTE,
                                                     Revision.PACIENTE.NombreCompleto,
                                                     tratamiento.Fecha))

            CargaDatos()
        End If

    End Sub
#End Region

#Region "Private Sub tst_Modificar_Tratamiento_Click(sender As System.Object, e As System.EventArgs) Handles tst_Modificar_Tratamiento.Click"
    Private Sub tst_Modificar_Tratamiento_Click(sender As System.Object, e As System.EventArgs) Handles tst_Modificar_Tratamiento.Click
        If Not Grid_Tratamientos.CurrentRow Is Nothing Then


            Dim currentComparativa As LCOMPARATIVA = grid_Revisiones.GetRow().DataRow
            If (Now - currentComparativa.FECHA.Value).Days >= 1 Then
                MessageBox.Show("Ha transcurrido más de un dia desde la creación de este seguimiento, no puede ser modificado")
                If Globales.Usuario.EsAdministrador Then
                    MessageBox.Show("Se le permite continuar por su rol de administrador")
                Else
                    Return
                End If
            End If

            Dim tratamiento As LCOMPARATIVAS_TRATAMIENTO = Grid_Tratamientos.CurrentRow.DataRow


            Dim frm As New frm_RevisionesComparativas_Editar_Tratamiento
            frm.LCOMPARATIVAS_TRATAMIENTOsBindingSource.DataSource = tratamiento

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                context.SubmitChanges()

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar,
                                      RoleManager.Items.Pacientes_TratamientoSeguimiento, "Tratamiento de Revision",
                                      tratamiento.ID,
                                      String.Format("Tratamiento: [{0}] {1} Paciente:[{2}] {3} Fecha: {2}  ",
                                                    tratamiento.ID,
                                                    tratamiento.Tratamiento,
                                                    Revision.PACIENTE.CPACIENTE,
                                                    Revision.PACIENTE.NombreCompleto,
                                                    tratamiento.Fecha))

                CargaDatos()
            End If
        End If
    End Sub
#End Region

#Region "Private Sub Grid_Tratamientos_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles Grid_Tratamientos.SelectionChanged"
    Private Sub Grid_Tratamientos_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles Grid_Tratamientos.SelectionChanged
        tst_Modificar_Tratamiento.Enabled = (Grid_Tratamientos.SelectedItems.Count > 0)
        tst_Eliminar_Tratamiento.Enabled = (Grid_Tratamientos.SelectedItems.Count > 0)
    End Sub
#End Region

#Region "Private Sub tstEliminar_Tratamiento_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar_Tratamiento.Click"
    Private Sub tstEliminar_Tratamiento_Click(sender As System.Object, e As System.EventArgs) Handles tst_Eliminar_Tratamiento.Click

        If Not Grid_Tratamientos.CurrentRow Is Nothing Then
            Try
                If MessageBox.Show("¿Desea eliminar el tratamiento seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim tratamiento As LCOMPARATIVAS_TRATAMIENTO = Grid_Tratamientos.CurrentRow.DataRow
                    context.LCOMPARATIVAS_TRATAMIENTOs.DeleteOnSubmit(tratamiento)
                    context.SubmitChanges()

                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar,
                                     RoleManager.Items.Pacientes_TratamientoSeguimiento, "Tratamiento de Revision",
                                     tratamiento.ID,
                                     String.Format("Tratamiento: [{0}] {1} Paciente:[{2}] {3} Fecha: {2}  ",
                                                   tratamiento.ID,
                                                   tratamiento.Tratamiento,
                                                   Revision.PACIENTE.CPACIENTE,
                                                   Revision.PACIENTE.NombreCompleto,
                                                   tratamiento.Fecha))

                    CargaDatos()
                End If
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End If
    End Sub
#End Region

#Region "Private Sub Grid_Tratamientos_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid_Tratamientos.RowDoubleClick"
    Private Sub Grid_Tratamientos_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid_Tratamientos.RowDoubleClick
        If tstTratamientos.Enabled Then
            If tst_Modificar_Tratamiento.Enabled Then
                tst_Modificar_Tratamiento_Click(Nothing, Nothing)
            End If
        End If
    End Sub
#End Region


    Private Sub grid_Revisiones_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles grid_Revisiones.SelectionChanged
        Grid_Tratamientos.Enabled = grid_Revisiones.SelectedItems.Count > 0
        tstFechaSeg_Modificar.Enabled = grid_Revisiones.SelectedItems.Count > 0
        tstFechaSeg_Eliminar.Enabled = grid_Revisiones.SelectedItems.Count > 0
        tstImprmirSeguimientoPaciente.Enabled = grid_Revisiones.SelectedItems.Count > 0

        If Not grid_Revisiones.CurrentRow Is Nothing Then
            Dim lcomparativa As LCOMPARATIVA = grid_Revisiones.CurrentRow.DataRow
            CtrlImageWithStickers1.ResaltaStickersWithParentID(lcomparativa.ID)

            'carga la imagen asociada a esta revisión 
            If Not (lcomparativa Is Nothing Or lcomparativa.IMAGEN Is Nothing) Then
                Dim ms As New MemoryStream(lcomparativa.IMAGEN.ToArray)

                If ms.Length > 0 Then
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    PictureBox1.Image = Image.FromStream(ms)
                End If

            Else
                PictureBox1.Image = Nothing
            End If

            If (Now - lcomparativa.FECHA.Value).Days >= 1 AndAlso (Not Globales.Usuario.EsAdministrador Or RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Bloquear_historial) = RoleManager.TipoPermisos.Ninguno) Then
                'MessageBox.Show("Ha transcurrido más de un dia desde la creación de este seguimiento, no puede ser modificado")
                CtrlImageWithStickers1.Enabled = False
                Return
            Else
                CtrlImageWithStickers1.Enabled = True
            End If

        End If
    End Sub

#Region "Private Sub tstFechaSeg_Annadir_Click(sender As System.Object, e As System.EventArgs) Handles tstFechaSeg_Annadir.Click"
    Private Sub tstFechaSeg_Annadir_Click(sender As System.Object, e As System.EventArgs) Handles tstFechaSeg_Annadir.Click
        If CtrlModeloRevision1.CODIGO Is Nothing Then
            MessageBox.Show("Debe seleccionar un modelo de revisión")
            CtrlModeloRevision1.Focus()
            Return
        End If
        If Guardar() Then
            'Localizar la minima y maxima fecha entre los seguimientos existentes
            Dim previousDate As Date = Revision.FECHA
            Dim nextDate As Date = Date.Now
            Dim nRevisionesPrevias As Integer = grid_Revisiones.RowCount
            If nRevisionesPrevias < 1 Then nRevisionesPrevias = 1
            'If dtg_RCFechasSeguimiento.Rows.Count > 0 Then
            'previousDate = LCOMPARATIVASBindingSource.Item(LCOMPARATIVASBindingSource.Count - 1).Row.FECHA
            ' End If


            Dim nuevaRevision As New LCOMPARATIVA
            nuevaRevision.COMPARATIVA = COMPARATIVABindingSource.Current
            nuevaRevision.FECHA = nextDate
            nuevaRevision.HORA = nextDate.AddSeconds(1)
            nuevaRevision.REFMODELOCOMPARATIVA = CtrlModeloRevision1.CODIGO
            nuevaRevision.DESCRIPCION = nRevisionesPrevias & " SEGUIMIENTO."

            Dim frm As frmRevComparativa_Nuevo_Seguimiento = New frmRevComparativa_Nuevo_Seguimiento()
            frm.LCOMPARATIVABindingSource.DataSource = nuevaRevision

            Dim insertedID As Integer = 0

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                nuevaRevision.REFMODELOCOMPARATIVA = frm.CtrlModeloRevision1.CODIGO
                context.LCOMPARATIVAs.InsertOnSubmit(nuevaRevision)


                If Guardar() Then
                    'Insertar todos los datos comparativa asociados
                    For Each campo As MODELOSDATO In nuevaRevision.MODELOSCOMPARATIVA.MODELOSDATOs
                        Dim dato As New DATOSCOMPARATIVA
                        Dim datoAnterior As New DATOSCOMPARATIVA

                        dato.LCOMPARATIVA = nuevaRevision
                        dato.REFMODELODATO = campo.CODIGO

                        Dim repetir As Boolean = False
                        If campo.Repetir.HasValue Then
                            If campo.Repetir.Value = True Then
                                repetir = True

                                'Buscar la LComparativa anterior
                                Dim lcompList As List(Of LCOMPARATIVA) = (From l In context.LCOMPARATIVAs
                                                                         Where l.REFCOMPARATIVA = nuevaRevision.REFCOMPARATIVA And l.FECHA < nuevaRevision.FECHA
                                                                         Select l).ToList()


                                If lcompList.Count = 0 Then
                                    datoAnterior = dato
                                Else
                                    datoAnterior = lcompList(lcompList.Count - 1).DATOSCOMPARATIVAs.Where(Function(o) o.REFMODELODATO = dato.REFMODELODATO).SingleOrDefault()
                                    If datoAnterior Is Nothing Then
                                        datoAnterior = dato
                                    End If
                                End If

                            End If
                        End If
                        If campo.OcultarImpresionCliente Is Nothing Then
                            dato.OcultarImpresionCliente = False
                        Else
                            dato.OcultarImpresionCliente = campo.OcultarImpresionCliente
                        End If

                        Select Case campo.TIPODATO
                            Case "T"
                                dato.DVARCHAR = ""
                            Case "N"
                                dato.DFLOAT = 0
                            Case "B"
                                dato.DBOOLEAN = "N"
                            Case "E"
                                dato.DXML = campo.DXML
                            Case "M"
                                dato.DXML = campo.DXML
                            Case "X"
                                dato.DXML = campo.DXML
                        End Select

                        If repetir Then
                            Select Case campo.TIPODATO
                                Case "T"
                                    dato.DVARCHAR = datoAnterior.DVARCHAR
                                Case "N"
                                    dato.DFLOAT = datoAnterior.DFLOAT
                                Case "B"
                                    dato.DBOOLEAN = datoAnterior.DBOOLEAN
                                Case "E"
                                    dato.DXML = datoAnterior.DXML
                                Case "M"
                                    dato.DXML = datoAnterior.DXML
                                Case "X"
                                    dato.DXML = datoAnterior.DXML
                            End Select
                        End If




                        context.DATOSCOMPARATIVAs.InsertOnSubmit(dato)
                        context.SubmitChanges()
                    Next

                    If Guardar() Then
                        insertedID = nuevaRevision.ID
                        CargaDatos()
                        LCOMPARATIVAsBindingSource.MoveLast()
                    End If

                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar,
                                      RoleManager.Items.Pacientes_SeguimientoRevision, "Seguimiento",
                                      nuevaRevision.ID,
                                      String.Format("Paciente: [{0}] {1} Fecha: {2} Medico: {3} ",
                                        Revision.PACIENTE.CPACIENTE,
                                        Revision.PACIENTE.NombreCompleto,
                                        nuevaRevision.FECHA,
                                        nuevaRevision.MEDICO.NOMBRECOMPLETO
                                    ))

                End If

            End If

        End If

    End Sub
#End Region

#Region "Private Sub tstFechaSeg_Modificar_Click(sender As System.Object, e As System.EventArgs) Handles tstFechaSeg_Modificar.Click"
    Private Sub tstFechaSeg_Modificar_Click(sender As System.Object, e As System.EventArgs) Handles tstFechaSeg_Modificar.Click
        Dim lcomparativa As LCOMPARATIVA = grid_Revisiones.CurrentRow.DataRow
        Dim frm As frmRevComparativa_Nuevo_Seguimiento = New frmRevComparativa_Nuevo_Seguimiento()
        frm.LCOMPARATIVABindingSource.DataSource = lcomparativa

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Guardar()

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar,
                              RoleManager.Items.Pacientes_SeguimientoRevision, "Seguimiento",
                              lcomparativa.ID,
                              String.Format("Paciente: [{0}] {1} Fecha: {2} Medico: {3} ",
                                Revision.PACIENTE.CPACIENTE,
                                Revision.PACIENTE.NombreCompleto,
                                lcomparativa.FECHA,
                                lcomparativa.MEDICO.NOMBRECOMPLETO
                            ))
        End If
    End Sub
#End Region

#Region "Private Sub tstGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tstGuardar.Click"
    Private Sub tstGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tstGuardar.Click
        If CtrlModeloRevision1.CODIGO Is Nothing Then
            MessageBox.Show("Debe seleccionar un modelo")
            CtrlModeloRevision1.Focus()
            Return
        End If
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar,
                                        RoleManager.Items.Pacientes_Revisiones_Comparativas, "Revision Comparativa",
                                        Revision.CODIGO,
                                        String.Format("Paciente: [{0}] {1}  Fecha: {2}  ",
                                                      Revision.PACIENTE.CPACIENTE,
                                                      Revision.PACIENTE.NombreCompleto,
                                                      Revision.FECHA))

            Me.Close()
        End If
    End Sub
#End Region

#Region "Private Function Guardar() As Boolean"
    Private Function Guardar() As Boolean
        Try

            'Dim comp As COMPARATIVA = COMPARATIVABindingSource.Current
            'If Not comp Is Nothing Then
            '    comp.IMAGEN = New Data.Linq.Binary(CtrlModeloRevision1.ModeloRevision.IMAGEN.ToArray())
            'End If

            Dim comp As COMPARATIVA = COMPARATIVABindingSource.Current
            If Not comp Is Nothing Then
                If Not CtrlModeloRevision1.ModeloRevision.IMAGEN Is Nothing Then
                    comp.IMAGEN = New Data.Linq.Binary(CtrlModeloRevision1.ModeloRevision.IMAGEN.ToArray())
                End If
            End If

            Me.COMPARATIVABindingSource.EndEdit()

            Dim lcomp As LCOMPARATIVA = LCOMPARATIVAsBindingSource.Current
            If Not lcomp Is Nothing Then
                If Not PictureBox1.Image Is Nothing Then
                    Dim ms As New MemoryStream
                    PictureBox1.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                    lcomp.IMAGEN = New Data.Linq.Binary(ms.ToArray)
                Else
                    Dim b(0) As Byte
                    lcomp.IMAGEN = Nothing
                End If
            End If

            Me.LCOMPARATIVAsBindingSource.EndEdit()

            If Not context Is Nothing Then
                context.SubmitChanges()
            End If


            Return True
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
            Dim sqlEx As SqlClient.SqlException = ex
            MessageBox.Show(sqlEx.Errors(0).Message)
            Return False
        End Try
    End Function
#End Region


    Private Sub grid_Revisiones_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles grid_Revisiones.RowDoubleClick
        If tsSeguimientos.Enabled Then
            tstFechaSeg_Modificar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tstFechaSeg_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles tstFechaSeg_Eliminar.Click
        Dim lcomparativa As LCOMPARATIVA = grid_Revisiones.CurrentRow.DataRow

        If (Now - lcomparativa.FECHA.Value).Days >= 1 Then

            If Globales.Usuario.EsAdministrador Then
                If MessageBox.Show("Ha transcurrido más de un dia desde la creación de este seguimiento, desea continuar la eliminación (Administrador)?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    Return
                End If

            Else
                MessageBox.Show("Ha transcurrido más de un dia desde la creación de este seguimiento, no puede ser eliminado")
                Return
            End If

        End If

        If MessageBox.Show("Desea eliminar este seguimiento y sus datos asociados?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                'Eliminar tratamientos
                If lcomparativa.LCOMPARATIVAS_TRATAMIENTOs.Count > 0 Then context.LCOMPARATIVAS_TRATAMIENTOs.DeleteAllOnSubmit(lcomparativa.LCOMPARATIVAS_TRATAMIENTOs)
                context.LCOMPARATIVAs.DeleteOnSubmit(lcomparativa)
                context.SubmitChanges()

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar,
                              RoleManager.Items.Pacientes_SeguimientoRevision, "Seguimiento",
                              lcomparativa.ID,
                              String.Format("Paciente: [{0}] {1} Fecha: {2} ",
                                Revision.PACIENTE.CPACIENTE,
                                Revision.PACIENTE.NombreCompleto,
                                lcomparativa.FECHA
                            ))

                CargaDatos()
            Catch ex As Exception
                MessageBox.Show("No pudo eliminarse el seguimiento por estar sus datos relacionados con otras dependencias del paciente")
            End Try
        End If
    End Sub




    Private Sub CtrlImageWithStickers1_Sticker_BeforeInsert(ByRef tratamiento As LCOMPARATIVAS_TRATAMIENTO, ByRef cancel As System.Boolean) Handles CtrlImageWithStickers1.Sticker_BeforeInsert
        ' tratamiento.ID_LCOMPARATIVA = currentComparativa.ID
        If LCOMPARATIVAsBindingSource.Current Is Nothing Then
            MessageBox.Show("Debe crear una fecha de seguimiento antes")
            cancel = True
            Return
        End If

        Dim currentComparativa As LCOMPARATIVA = LCOMPARATIVAsBindingSource.Current

        'Dim tratamiento As New LCOMPARATIVAS_TRATAMIENTO()
        tratamiento.ID_LCOMPARATIVA = currentComparativa.ID
        tratamiento.Fecha = Date.Now()
        tratamiento.Facturada = False

        Dim frm As New frm_RevisionesComparativas_Editar_Tratamiento
        frm.LCOMPARATIVAS_TRATAMIENTOsBindingSource.DataSource = tratamiento

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            context.LCOMPARATIVAS_TRATAMIENTOs.InsertOnSubmit(tratamiento)
            context.SubmitChanges()
            'CargaDatos()
        Else
            cancel = True
        End If

    End Sub

    Private Sub CtrlImageWithStickers1_Sticker_Inserted(ByRef data As LCOMPARATIVAS_TRATAMIENTO) Handles CtrlImageWithStickers1.Sticker_Inserted

        'context.LCOMPARATIVAS_TRATAMIENTOs.InsertOnSubmit(data)
        context.SubmitChanges()
        CargaDatos()
    End Sub

    Private Sub CtrlImageWithStickers1_StickerUpdated(ByVal sticker As ctrlSticker) Handles CtrlImageWithStickers1.StickerUpdated

        sticker.ContainerClass.Tratamiento.Layout = sticker.ContainerClass.SaveLayout()
        context.SubmitChanges()

    End Sub

    Private Sub CtrlImageWithStickers1_StickerDeleted(ByVal sticker As ctrlSticker) Handles CtrlImageWithStickers1.StickerDeleted
        'context.LCOMPARATIVAS_TRATAMIENTOs.DeleteOnSubmit(sticker.ContainerClass.Tratamiento)

        'sticker.ContainerClass.Dispose()
        'Stickers.Remove(SelectedSticker.ContainerClass)
        'SelectedSticker = Nothing
        'btnEliminar.Enabled = False

        sticker.ContainerClass.Tratamiento.Layout = Nothing
        'If MessageBox.Show("Se eliminará el marcador visual, desea eliminar tambien el Tratamiento de la Base de Datos?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        context.LCOMPARATIVAS_TRATAMIENTOs.DeleteOnSubmit(sticker.ContainerClass.Tratamiento)
        'End If
        context.SubmitChanges()
        CargaDatos()
    End Sub

    Private Sub CtrlImageWithStickers1_ImageChanged(ByVal img() As Byte) Handles CtrlImageWithStickers1.ImageChanged

        'COMPARATIVA.IMAGEN = New System.Data.Linq.Binary(img)
        'context.SubmitChanges()
    End Sub




    Private Sub CtrlModeloRevision1_ModeloRevisionSeleccionadoByBrowser(IdModeloRevision As System.String) Handles CtrlModeloRevision1.ModeloRevisionSeleccionadoByBrowser
        If Not CtrlModeloRevision1.ModeloRevision.IMAGEN Is Nothing Then

            'If Guardar() Then
            Dim ms As New MemoryStream(CtrlModeloRevision1.ModeloRevision.IMAGEN.ToArray())
            CtrlImageWithStickers1.BackIMAGE = Image.FromStream(ms)

            'End If

        End If
    End Sub

    Private Sub CtrlModeloRevision1_ModeloRevisionEliminado(IdModeloRevision As System.String) Handles CtrlModeloRevision1.ModeloRevisionEliminado
        CtrlImageWithStickers1.BackIMAGE = Nothing

    End Sub

    Private Sub CtrlModeloRevision1_ModeloRevisionSeleccionado(IdModeloRevision As System.String, isReturnPresess As Boolean) Handles CtrlModeloRevision1.ModeloRevisionSeleccionado

        If Not CtrlModeloRevision1.ModeloRevision.IMAGEN Is Nothing Then
            Dim ms As New MemoryStream(CtrlModeloRevision1.ModeloRevision.IMAGEN.ToArray())
            CtrlImageWithStickers1.BackIMAGE = Image.FromStream(ms)
        End If
    End Sub

    Private Sub tstConsultarGrafica_Click(sender As System.Object, e As System.EventArgs) Handles tstConsultarGrafica.Click

        If Not COMPARATIVABindingSource.Current Is Nothing Then
            Dim comparativa As COMPARATIVA = COMPARATIVABindingSource.Current
            Dim _grafico As form_grafica_rev_comp = New form_grafica_rev_comp(comparativa.CODIGO, comparativa.PACIENTE.NombreCompleto)
            _grafico.ShowInTaskbar = False
            _grafico.ShowDialog()
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir,
                                        RoleManager.Items.Pacientes_Revisiones_Comparativas, "Grafico Revision Comparativa",
                                        Revision.CODIGO,
                                        String.Format("Paciente: [{0}] {1}  Fecha: {2}  ",
                                                      Revision.PACIENTE.CPACIENTE,
                                                      Revision.PACIENTE.NombreCompleto,
                                                      Revision.FECHA))

        End If

    End Sub

    Private Sub tstNuevaCita_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevaCita.Click
        Dim frmCita As New form_citas("Añadir Cita", Enums.Accion.Insertar, Now.Date, Nothing)
        frmCita.CtrlPaciente1.ID_PACIENTE = Me.ID_Paciente
        frmCita.tb_notas.Text = "Cita Generada desde la revisión comparativa " & CtrlModeloRevision1.CODIGO & " con fecha " & Me.dtp_RCFechainicio.Value
        frmCita.ShowDialog()
    End Sub


    Private Sub Imprimir(ByVal titulo As String, ByVal reporte As String, ByRef Rows() As Janus.Windows.GridEX.GridEXRow)
        If Rows.Count = 0 Then
            MessageBox.Show("No hay seguimientos seleccionados")
            Return
        End If


        'Antes que todo hay que salvar
        If Not Guardar() Then
            Return
        End If


        Try

            Dim listSeguimientos As New List(Of RC_Seguimiento)
            Dim listaLComparativas As New List(Of LCOMPARATIVA)

            For Each rowGrid As Janus.Windows.GridEX.GridEXRow In Rows
                Dim seguimiento As LCOMPARATIVA = rowGrid.DataRow
                listaLComparativas.Add(seguimiento)

                For Each dato As DATOSCOMPARATIVA In seguimiento.DATOSCOMPARATIVAs

                    Dim seg As New RC_Seguimiento With
                                        {
                                            .Descripcion_SEGUIMIENTO = seguimiento.DESCRIPCION,
                                            .Fecha = seguimiento.FECHA,
                                            .Medico_NombreCompleto = seguimiento.MEDICO.NOMBRECOMPLETO,
                                            .NotaSeguimiento = seguimiento.NOTAS & "",
                                            .NOMBREDATO = dato.MODELOSDATO.NOMBREDATO,
                                            .TIPODATO = dato.MODELOSDATO.TIPODATO,
                                            .VALOR = Globales.ValorModelo(dato),
                                            .OcultarEnReporte = IIf(dato.MODELOSDATO.OcultarEnReporte Is Nothing, False, dato.MODELOSDATO.OcultarEnReporte),
                                            .OcultarImpresionCliente = IIf(dato.OcultarImpresionCliente Is Nothing, False, dato.OcultarImpresionCliente)
                                        }



                    If dato.MODELOSDATO.CalcDiferencia.HasValue Then
                        If dato.MODELOSDATO.CalcDiferencia.Value = True And listaLComparativas.Count > 1 Then
                            Dim previa As LCOMPARATIVA = listaLComparativas(listaLComparativas.Count - 2)

                            If dato.MODELOSDATO.TIPODATO = "N" Or dato.MODELOSDATO.TIPODATO = "X" Then
                                seg.DiffAnterior = Globales.DiffValores(dato, previa)
                            End If

                        End If
                    End If
                    listSeguimientos.Add(seg)

                Next

            Next


            'Cabecera

            Dim header As New RC_ParcialHeader With
                {
                    .Paciente_Nombre = Revision.PACIENTE.NOMBRE,
                    .Paciente_Apellido1 = Revision.PACIENTE.APELLIDO1,
                    .Paciente_Apellido2 = Revision.PACIENTE.APELLIDO2,
                    .Paciente_FechaNacimiento = Revision.PACIENTE.FECHAN,
                    .Paciente_Sexo = Revision.PACIENTE.SEXO,
                    .Revision_Descripcion = Revision.DESCRIPCION,
                    .Revision_FechaInicio = Revision.FECHA,
                    .RevisionCodigo = Revision.CODIGO,
                    .RevisionModelo = Revision.MODELOSCOMPARATIVA.MODELO
                 }

            If listSeguimientos.Count > 0 Then
                header.Revision_FechaInicio = listSeguimientos(0).Fecha
                'header.
            End If

            Dim dsRC_ParcialHeader As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
            dsRC_ParcialHeader.Name = "dsRC_ParcialHeader"
            dsRC_ParcialHeader.Value = New List(Of RC_ParcialHeader)({header})

            Dim dsRC_Seguimiento As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
            dsRC_Seguimiento.Name = "dsRC_Seguimiento"
            dsRC_Seguimiento.Value = listSeguimientos

            Dim dsTratamientos As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
            dsTratamientos.Name = "dsTratamientos"

            Dim context2 As New CMLinqDataContext
            Dim tratamientos As List(Of LCOMPARATIVAS_TRATAMIENTO) = (From t In context2.LCOMPARATIVAS_TRATAMIENTOs _
                                                                     Where t.LCOMPARATIVA.COMPARATIVA.CODIGO = CODIGO
                                                                     Select t).ToList()
            dsTratamientos.Value = tratamientos


            Dim paramLogo As New ReportParameter()
            paramLogo.Name = "RevCompa_ImagePath"

            If Not CtrlImageWithStickers1.BackIMAGE Is Nothing Then
                Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\revcomp.jpg"
                CtrlImageWithStickers1.SaveToBitmap().Save(path, Imaging.ImageFormat.Jpeg)

                paramLogo.Values.Add("file:///" & path)

            End If


            UI.Reportes.ReportesManager.Imprime(reporte, {dsRC_ParcialHeader, dsRC_Seguimiento, dsTratamientos}, {paramLogo})

            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Imprimir,
                                        RoleManager.Items.Pacientes_Revisiones_Comparativas, reporte,
                                        Revision.CODIGO,
                                        String.Format("Paciente: [{0}] {1}  Fecha: {2}  ",
                                                      Revision.PACIENTE.CPACIENTE,
                                                      Revision.PACIENTE.NombreCompleto,
                                                      Revision.FECHA))



        Catch ex As Exception
            'Para evitar posibles errores
            Dim msg = ex.Message
            If Not ex.InnerException Is Nothing Then
                msg = msg & "." & ex.InnerException.Message
                If Not ex.InnerException.InnerException Is Nothing Then
                    msg = msg & "." & ex.InnerException.InnerException.Message
                End If
            End If
            MessageBox.Show(msg)
        End Try

    End Sub



    Private Sub tstCancelar_Click(sender As System.Object, e As System.EventArgs) Handles tstCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RevisionComparativaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevisionComparativaToolStripMenuItem.Click
        Imprimir("Revision Comparativa Completa", "RevisionComparativaClinica.rdlc", grid_Revisiones.GetRows)
    End Sub

    Private Sub RevisiónComparativaClinicaPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevisiónComparativaClinicaPacienteToolStripMenuItem.Click
        Imprimir("Revision Comparativa Completa", "RevisionComparativaPaciente.rdlc", grid_Revisiones.GetRows)
    End Sub

    Private Sub tstImprmirSeguimiento_Click(sender As Object, e As EventArgs) Handles tstImprmirSeguimientoPaciente.Click
        Imprimir("Revision Comparativa Parcial", "RevisionComparativaPaciente.rdlc", grid_Revisiones.GetCheckedRows)
    End Sub

    Private Sub tstImprimirSeguimientoClinica_Click(sender As Object, e As EventArgs) Handles tstImprimirSeguimientoClinica.Click
        Imprimir("Revision Comparativa Parcial", "RevisionComparativaClinica.rdlc", grid_Revisiones.GetCheckedRows)
    End Sub

    Private Sub btLoadImage_Click(sender As Object, e As EventArgs) Handles btLoadImage.Click
        Dim fd As New OpenFileDialog
        Dim pathFile As String = ""

        fd.Filter = "jpg|*.jpg"
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathFile = fd.FileName
            If File.Exists(pathFile) Then

                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

                PictureBox1.Image = Image.FromFile(pathFile)
                Guardar()
            End If
        End If

    End Sub

    Private Sub btAbriImagen_Click(sender As Object, e As EventArgs) Handles btAbriImagen.Click
        Dim pathfile As String = Environment.SpecialFolder.ApplicationData & "rev.jpg"
        PictureBox1.Image.Save(pathfile)
        Process.Start(pathfile)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btDeleteImage.Click
        PictureBox1.Image = Nothing
        Guardar()
    End Sub

    
    
   
End Class