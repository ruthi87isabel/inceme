Imports centro_medico
Imports Janus.Windows.GridEX
Imports Microsoft.Reporting.WinForms
Imports System.Diagnostics
Imports centro_medico.UI.Reportes


Public Class frmFacturasM_ADD

    Public Context As CMLinqDataContext

    'Public FacturaContext As CMLinqDataContext
    Public ID_Factura As Integer
    Public Factura As FACTURA
    Public Nuevo As Boolean = False
    Public IDPacienteToFilter As Nullable(Of Integer) = Nothing

    Dim recalcularConceptos As Boolean = False
    Dim cargando As Boolean = True
    Dim asked As Boolean = False

    Dim oldConcepto As String = Nothing

    Dim ListaDesglosesIva As New List(Of centro_medico.DESGLOSEIVAS)

    Dim hash As New Hashtable()


    Dim anteriorserie As String
    Dim anteriornumero As String


    Public FacturadaGeneradaDesdeCita As Boolean = False


  
    Private Sub frmFacturasMedicas_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaDatos()
    End Sub


#Region "Private Sub CargaDatos()"
    Private Sub CargaDatos()
        'If Context Is Nothing Then
        'Context = New CMLinqDataContext()
        ' End If

        SERIESComboBox.DataSource = (From s In Context.SERIES Select s).ToList()

        'GridEXLineas.RootTable.Columns("TIPOIVA").DropDown = New GridEXDropDown()
        'GridEXLineas.RootTable.Columns("TIPOIVA").DropDown.SetDataBinding((From t In context.N_TipoIVAs Select t), "")

        Dim Column As Janus.Windows.GridEX.GridEXColumn = GridEXLineas.RootTable.Columns("TIPOIVA")
        'Set HasValueList property equal to true in order to be able to use the ValueList property
        Column.HasValueList = True
        'Get the ValueList collection associated to this column
        Dim ValueList As Janus.Windows.GridEX.GridEXValueListItemCollection = Column.ValueList

        'Fill the ValueList

        Dim ivas As List(Of N_TipoIVA) = (From t In Context.N_TipoIVAs Select t Order By t.Valor).ToList()
        Dim ceroIva As New N_TipoIVA()
        ceroIva.Nombre = "0"
        ceroIva.Valor = 0
        ivas.Insert(0, ceroIva)

        ValueList.PopulateValueList(ivas, "Valor", "Valor")


        Column.EditType = Janus.Windows.GridEX.EditType.DropDownList

        If Nuevo Then

            Factura.PAGADA = "N"
            If Factura.FACTURAR Is Nothing Then
                Factura.FACTURAR = "P"
            End If

            Factura.TOTAL = 0
            Factura.REFRECIBO = Nothing
            Factura.RECIBO = "N"
            Factura.EMPRESA = String.Empty
            Factura.FEMISION = Date.Now
            Factura.MUTUA = String.Empty
            Factura.Descuento = 0
            If SERIESComboBox.Items.Count > 0 Then
                'Coger la serie por defecto
                'If Factura.REFSERIE Is Nothing Then
                SERIESComboBox.SelectedValue = centro_medico.Globales.Configuracion.serie
                'Factura.REFSERIE = 
                'End If
            End If
            Factura.PORCENTAJEIRPF = Globales.Configuracion.IRPF

            If IDPacienteToFilter.HasValue Then
                CtrlPaciente1.ID_PACIENTE = IDPacienteToFilter
            End If
            CargaDatosPaciente()

            btnFacturaE.Visible = False
            If Not Context.FACTURAs.Contains(Factura) Then
                Context.FACTURAs.InsertOnSubmit(Factura)
                'Context.SubmitChanges()
            End If
        Else
            'Desactivar algunas cosas
            If IDPacienteToFilter.HasValue Then
                CtrlPaciente1.ID_PACIENTE = IDPacienteToFilter
            End If
            'CtrlPaciente1.Enabled = False
            'SERIESComboBox.Enabled = False

            'txtIRPFPorciento.Value = Factura.PORCENTAJEIRPF
            txtIRPFImporte.Value = Factura.IRPF
            txtIRPFPorciento.Value = Factura.PORCENTAJEIRPF
            btnFacturaE.Visible = True

            anteriorserie = Factura.REFSERIE
            anteriornumero = Factura.NUMERO


        End If

        If Factura.FEMISION.HasValue And Not Factura.FECHACOBRO.HasValue Then
            cb_pagada.Value = Factura.FEMISION
        End If

        'Esto es legacy
        For Each linea As LINEASFACTURA In Factura.LINEASFACTURAs
            If linea.ImporteOriginal = 0 And linea.IMPORTE > 0 Then
                linea.ImporteOriginal = linea.IMPORTE
            End If
            If linea.ImporteOriginal Is Nothing And linea.IMPORTE >= 0 Then
                linea.ImporteOriginal = linea.IMPORTE
            End If
        Next

        FACTURABindingSource.DataSource = Factura

        'GridEX2.CollapseGroups()

        'If Not Nuevo Then
        '    For Each row As GridEXRow In GridEXLineas.GetRows()
        '        Dim linea As LINEASFACTURA = row.DataRow

        '        row.BeginEdit()
        '        row.Cells("ColumnImporteOriginal").Value = linea.IMPORTE + linea.Descuento
        '        row.EndEdit()
        '    Next
        'End If

        If Factura.FACTURAR = "P" Then
            cb_tipo.SelectedIndex = 0
        Else
            cb_tipo.SelectedIndex = 1
        End If

        chk_pagada.Checked = (Factura.PAGADA = "S")
        chk_pagada.Enabled = Not (Factura.PAGADA = "S")
        cb_pagada.Enabled = (chk_pagada.Checked = True) And (Factura.PAGADA = "N")

        pb_UndoCobrar.Enabled = (Factura.PAGADA = "S")


        chb_recibo.Checked = Not Factura.REFRECIBO Is Nothing

        'Hacer un ciclo por todas las lineas para mostrar los porcientos
        For Each row As GridEXRow In GridEXLineas.GetRows()
            Dim linea As LINEASFACTURA = row.DataRow

            linea.REFCONCEPTO = VerificaExisteConcepto(linea.REFCONCEPTO)

            Dim percent As Double = 0
            If linea.Descuento > 0 Then
                percent = (linea.Descuento / linea.ImporteOriginal) * 100
            End If
            row.BeginEdit()
            row.Cells("ColumnDtoPercent").Value = percent
            row.EndEdit()
        Next

        SERIESComboBox.SelectedValue = Factura.REFSERIE

        CtrlEmpresa1.ID_EMPRESAS = Factura.REFEMPRESA
        CtrlMutua1.ID_Mutuas = Factura.REFMUTUA
        CtrlFormaPago21.ID_FORMASPAGO = Factura.REFFORMAPAGO
        CtrlPaciente1.ID_PACIENTE = Factura.REFPACIENTE
        'CtrlDiagnosticos1.ID_DIAGNOSTICOS = Factura.

        If Not SERIESComboBox.SelectedValue Is Nothing And Factura.NUMERO Is Nothing Then
            'tb_nro.Text = 
            'Factura.REFSERIE = SERIESComboBox.SelectedValue
            Factura.NUMERO = Number(SERIESComboBox.SelectedItem)
        End If

        CalculaTotalFactura()
        cargando = False

        tb_nro.Enabled = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas) > RoleManager.TipoPermisos.Lectura
        'dtp_fcobro.Enabled = Not (Factura.PAGADA = "S")
        'pb_UndoCobrar.Visible = Globales.Usuario.EsAdministrador()

        'If Factura.PAGADA = "S" Then
        '    DesactivaTodo()
        '    lblEdicionDesactivada.Enabled = True
        '    lblEdicionDesactivada.Visible = True
        '    bt_imprimir.Enabled = True
        '    bt_aceptar.Enabled = True
        'End If

        If Factura.FECHACOBRO.HasValue Then
            cb_pagada.Value = Factura.FECHACOBRO
        End If

        If Not Factura.FECHAENVIO.HasValue Then
            combo_FechaEnvio.Value = Date.Now
        Else
            combo_FechaEnvio.Checked = True
        End If

        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            If Not CtrlPaciente1.Paciente.NIE Is Nothing Then
                txtNie.Text = CtrlPaciente1.Paciente.NIE
            Else
                txtNie.Text = ""
            End If

            If Not CtrlPaciente1.Paciente.PASAPORTE Is Nothing Then
                txtPasaporte.Text = CtrlPaciente1.Paciente.PASAPORTE
            Else
                txtPasaporte.Text = ""
            End If
        End If

        pb_UndoCobrar.Visible = Globales.Usuario.EsAdministrador Or _
          RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas) > RoleManager.TipoPermisos.Modificar

        If Factura.PAGADA = "S" Then
            Me.DesactivaTodo()
        End If
    End Sub

#End Region

    Private Sub pb_UndoCobrar_Click(sender As System.Object, e As System.EventArgs) Handles pb_UndoCobrar.Click
        If Me.chk_pagada.Checked AndAlso MessageBox.Show("Como Administrador puede marcar como no pagada esta factura, pero esto puede traer consecuencias en los pagos/entregas efectuados: Desea continuar?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If citaspagadas() = False Then
                chk_pagada.Checked = False
                chk_pagada.Enabled = True
                CtrlFormaPago21.ID_FORMASPAGO = ""
                If Guardar() Then
                    Factura.MarcarDespagado()
                    Me.Guardar()
                End If
            End If
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Facturas, "Descobrar Factura", Factura.IDFACTURA, String.Format("Descobrada factura [{0}]-{1}-{2} importe {3} ", Factura.NUMERO, Factura.FECHA.Value.ToShortDateString(), Factura.PACIENTE, Factura.TOTAL))

            'Las citas que se dieron como pagadas por pagar la factura las volvemos a despagar. Registramos también en la auditoría el cambio en la cita
            Dim cit As List(Of CITA) = (From c In Context.CITAs Select c Where c.REFFRA = Factura.IDDocumento And c.PagadoDesdeFactura = True And c.Eliminado = False).ToList

            For Each c As CITA In cit
                c.PAGADA = "N"
                c.PagadoDesdeFactura = False
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Citas, "Descobrar Cita", c.IDCITA, String.Format("Descobrada cita {0} por provenir del cobro de la factura {1} y haber sido 'descobrada'.", c.HORA, Factura.NUMERO))
            Next


        End If
    End Sub


    Private Sub DesactivaTodo()
        For Each c As Control In Me.Controls
            c.Enabled = False
            For Each c2 As Control In c.Controls
                c2.Enabled = False
                For Each c3 As Control In c2.Controls
                    c3.Enabled = False
                Next
            Next
        Next
        Me.bt_imprimir.Enabled = True
        Dim modificar As Boolean = ((RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Modificar) _
                                    Or (RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Facturas) = RoleManager.TipoPermisos.Modificar) _
                                    Or (Globales.Usuario.EsAdministrador) _
                                    )

        Me.bt_aceptar.Enabled = modificar
        Me.bt_cancel.Enabled = True
        If Globales.Usuario.EsAdministrador Then
            Me.GroupBox1.Enabled = True
            Me.pb_UndoCobrar.Enabled = Globales.Usuario.EsAdministrador
        End If

    End Sub

#Region "Public Sub CargaDatosPaciente()"
    Public Sub CargaDatosPaciente()
        If CtrlPaciente1.ID_PACIENTE.HasValue Then
            If Not CtrlPaciente1.Paciente.LOCALIDAD Is Nothing Then
                Factura.LOCALIDAD = CtrlPaciente1.Paciente.LOCALIDAD
            Else
                Factura.LOCALIDAD = Nothing
            End If

            If Not CtrlPaciente1.Paciente.PROVINCIA Is Nothing Then
                Factura.PROVINCIA = CtrlPaciente1.Paciente.PROVINCIA
            Else
                Factura.PROVINCIA = Nothing
            End If

            If Not CtrlPaciente1.Paciente.DOMICILIO Is Nothing Then
                Factura.DIRECCION = CtrlPaciente1.Paciente.DOMICILIO
            Else
                Factura.DIRECCION = Nothing
            End If

            If Not CtrlPaciente1.Paciente.DNI Is Nothing Then
                Factura.DNI = CtrlPaciente1.Paciente.DNI
            Else
                Factura.DNI = Nothing
            End If

            If Not CtrlPaciente1.Paciente.CP Is Nothing Then
                Factura.CP = CtrlPaciente1.Paciente.CP
            Else
                Factura.CP = Nothing
            End If

            Factura.PACIENTE = CtrlPaciente1.NombreCompleto
            If Not CtrlPaciente1.Paciente.NIE Is Nothing Then
                txtNie.Text = CtrlPaciente1.Paciente.NIE
            Else
                txtNie.Text = ""
            End If

            If Not CtrlPaciente1.Paciente.PASAPORTE Is Nothing Then
                txtPasaporte.Text = CtrlPaciente1.Paciente.PASAPORTE
            Else
                txtPasaporte.Text = ""
            End If

            'Empresa 
            If Not CtrlPaciente1.Paciente.REFEMPRESA Is Nothing Then
                CtrlEmpresa1.ID_EMPRESAS = CtrlPaciente1.Paciente.REFEMPRESA
            End If

            'Mutua
            If Not CtrlPaciente1.Paciente.REFMUTUA Is Nothing Then
                CtrlMutua1.ID_Mutuas = CtrlPaciente1.Paciente.REFMUTUA
            End If
        End If
    End Sub
#End Region


    Private Function VerificaExisteConcepto(ByVal refconcepto As String) As String
        'Si el concepto existe lo retorna igual sino return nothing
        Dim context2 As New CMLinqDataContext()
        Try
            Dim conceptofra As CONCEPTOSFRA = (From c In context2.CONCEPTOSFRAs Where c.CODIGO = refconcepto).SingleOrDefault
            If conceptofra Is Nothing Then
                Return Nothing
            Else
                Return conceptofra.CODIGO
            End If
        Catch ex As Exception

        End Try
    End Function

#Region "Private Sub CtrlDiagnosticos1_DIAGNOSTICOSSeleccionado_1(ByVal IdDIAGNOSTICOS As System.Int32)"
    Private Sub CtrlDiagnosticos1_DIAGNOSTICOSSeleccionado_1(ByVal IdDIAGNOSTICOS As System.Int32)
        If Not CtrlDiagnosticos1.Diagnostico Is Nothing Then
            Factura.DIAGNOSTICO = CtrlDiagnosticos1.Diagnostico.DIAGNOSTICO
        End If
    End Sub
#End Region


#Region "Private Function Number(ByVal acod As String) As String"
    Private Function Number(ByVal serie As SERIES) As String
        If Not serie Is Nothing Then
            'Dim serie As SERIES = (From s In context.SERIES Where s.CODIGO = acod Select s).SingleOrDefault
            Dim generado As Boolean = False
            Dim _result As String

            Do
                _result = serie.CODIGO
                Dim _cant As String = (serie.CONTADOR + 1).ToString()
                'serie.CONTADOR += 1
                'context.SubmitChanges()

                Dim _digits As Integer = _cant.Length
                Dim i As Integer

                For i = 0 To 5 - _digits
                    _result = _result + "0"
                Next
                _result = _result + _cant

                generado = Not ChequeaSiExisteNumero(_result)
                If Not generado Then
                    'Incrementar el numero de la serie
                    If Not SERIESComboBox.SelectedValue Is Nothing Then
                        Dim serieInc As SERIES = SERIESComboBox.SelectedItem
                        serieInc.CONTADOR += 1
                        'Context.SubmitChanges()
                    End If
                End If

            Loop Until generado

            Return _result

        End If
        Return ""
    End Function
#End Region

#Region "Private Sub SERIESComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SERIESComboBox.SelectedIndexChanged"
    Private Sub SERIESComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SERIESComboBox.SelectedIndexChanged
        If Nuevo Or Factura.NUMERO Is Nothing Then
            If Not SERIESComboBox.SelectedValue Is Nothing Then
                'tb_nro.Text = 
                Factura.SERIES = SERIESComboBox.SelectedItem
                Factura.NUMERO = Number(SERIESComboBox.SelectedItem)
                tb_nro.Text = Factura.NUMERO
            End If

        End If
    End Sub
#End Region

    Private Sub SERIESComboBox_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles SERIESComboBox.SelectionChangeCommitted
        If Nuevo Or Factura.NUMERO Is Nothing Then
            If Not SERIESComboBox.SelectedValue Is Nothing Then
                'tb_nro.Text = 
                Factura.SERIES = SERIESComboBox.SelectedItem
                Factura.NUMERO = Number(SERIESComboBox.SelectedItem)
                tb_nro.Text = Factura.NUMERO
            End If
        Else
            If MessageBox.Show("¿Desea cambiar el numero de la factura existente basado en la serie seleccionada?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                'Factura.REFSERIE = SERIESComboBox.SelectedValue
                Factura.SERIES = SERIESComboBox.SelectedItem
                Factura.NUMERO = Number(SERIESComboBox.SelectedItem)
            End If
        End If
    End Sub


    Private Sub cb_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_tipo.SelectedIndexChanged
        CtrlMutua1.Enabled = (cb_tipo.SelectedItem = "Mutua")
        If Not CtrlMutua1.Enabled Then
            Try
                Factura.REFMUTUA = Nothing
                CtrlMutua1.ID_Mutuas = Nothing
                FACTURABindingSource.EndEdit()
                Factura.REFMUTUA = Nothing
            Catch ex As Exception
            End Try
        Else
            ConfirmaRecalculo()
            ChequeaTarifasEnLineas()
            CalculaTotalFactura()
        End If
    End Sub

    Private Sub CtrlMutua1_MutuasSeleccionado(ByVal IdMutuas As System.Int32) Handles CtrlMutua1.MutuasSeleccionado


    End Sub

    Private Sub CtrlMutua1_MutuasSeleccionadoManualmente(ByVal IdMutuas As System.Int32) Handles CtrlMutua1.MutuasSeleccionadoManualmente
        ConfirmaRecalculo()
        ChequeaTarifasEnLineas()
        CalculaTotalFactura()
    End Sub

    Public Sub ConfirmaRecalculo()
        If GridEXLineas.GetRows().Count > 0 And Not cargando And cb_tipo.SelectedItem = "Mutua" And CtrlMutua1.ID_Mutuas.HasValue And Not asked Then
            If Globales.Usuario.Permisos(RoleManager.Items.ImporteCitas) > RoleManager.TipoPermisos.Ninguno Then
                Dim res As DialogResult = MessageBox.Show("Desea recalcular los importes con la tarifa de la mutua seleccionada si procede?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If res = Windows.Forms.DialogResult.Yes Then
                    recalcularConceptos = True
                Else
                    recalcularConceptos = False
                End If
                asked = True
            End If
        Else
            'Se recalcula obligatoriamente
            recalcularConceptos = True
        End If
    End Sub

    Private Sub CtrlMutua1_MutuasEliminada(ByVal IdMutuas As System.Int32) Handles CtrlMutua1.MutuasEliminada
        If GridEXLineas.GetRows().Count > 0 Then
            'Significa que habia antes una mutua aplicada y se le ha eliminado
            'se deben restaurar los valores originales
            'Si el usuario puede ver los importes se le preguntara antes de efectuar esta operacion
            If Globales.Usuario.Permisos(RoleManager.Items.ImporteCitas) > RoleManager.TipoPermisos.Ninguno Then
                Dim res As DialogResult = MessageBox.Show("Desea restaurar los importes de los conceptos a sus valores originales?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If res = Windows.Forms.DialogResult.Yes Then
                    RestauraValoresConceptos()
                End If
            Else
                'Si no tiene permiso de ver importes, se recalcula obligatoriamente
                RestauraValoresConceptos()
            End If

        End If
        'Factura.MUTUA = ""
        Factura.REFMUTUA = Nothing
    End Sub

    Private Sub RestauraValoresConceptos()
        For Each row As GridEXRow In GridEXLineas.GetRows()
            row.BeginEdit()
            row.Cells("ImporteOriginal").Value = ObtieneImporteConceptoFacturable(row.Cells("REFCONCEPTO").Value)
            row.DataRow.ImporteOriginal = row.Cells("ImporteOriginal").Value
            row.EndEdit()
            CalculaFila(row)
        Next
        'GetConceptos(fId)
    End Sub



#Region "Private Function ObtenImporteConceptoSegunTarifa(ByVal idConcepto As String,Byval descripcion as String, ByVal importeDefecto As Double) As Double"
    Private Function ObtenImporteConceptoSegunTarifa(ByVal idConcepto As String, ByVal descripcion As String, ByVal importeDefecto As Double) As Double

        'Pasos
        'Obtener la tarifa de la mutua seleccionada si hay una seleccionada

        Dim importe As Double = importeDefecto

        'Verificar si hay una mutua seleccionada


        If CtrlMutua1.ID_Mutuas.HasValue Then
            Dim mutua As CMDataSet.MUTUASRow = CtrlMutua1.Mutuas

            Dim tarifaAdapter As New CMDataSetTableAdapters.TarifasTableAdapter()
            Dim tarifaTable As New CMDataSet.TarifasDataTable()

            'Si tiene tarifa
            If Not mutua.IsIdTarifaNull() Then
                'Cargarla
                tarifaAdapter.FillBy(tarifaTable, mutua.IdTarifa)
                If (tarifaTable.Count > 0) Then
                    For Each tarifa As CMDataSet.TarifasRow In tarifaTable.Rows
                        If tarifa.IdConceptoFra = idConcepto And tarifa.Importe <> importeDefecto And recalcularConceptos Then
                            Return tarifa.Importe
                        End If
                    Next
                End If
            End If
        End If

        Return importe
    End Function
#End Region

#Region "Private Function ObtieneImporteConceptoFacturable(ByVal idConcepto As String) As Double"
    Private Function ObtieneImporteConceptoFacturable(ByVal idConcepto As String) As Double
        Dim concepto As CONCEPTOSFRA = (From c In context.CONCEPTOSFRAs Where c.CODIGO = idConcepto).SingleOrDefault
        If concepto Is Nothing Then
            Return 0
        Else
            Return concepto.IMPORTE
        End If
    End Function
#End Region

#Region "Private Sub GridEXLineas_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEXLineas.ColumnButtonClick"
    Private Sub GridEXLineas_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEXLineas.ColumnButtonClick
        If e.Column.Index = GridEXLineas.RootTable.Columns("REFCONCEPTO").Index Then
            Dim frmConcepto As New frmListadoConceptos()
            frmConcepto.Modo = centro_medico.Globales.ModoParaFormas.Seleccion

            frmConcepto.tstAnnadirSeleccionados.Visible = False



            If frmConcepto.ShowDialog() = DialogResult.OK Then

                Dim row As GridEXRow = GridEXLineas.SelectedItems(0).GetRow()

                If frmConcepto.ConceptosSeleccionados.Count = 0 Then
                    Dim linea As LINEASFACTURA = row.DataRow
                    linea.REFCONCEPTO = frmConcepto.ConceptoFra.CODIGO
                    linea.CONCEPTO = frmConcepto.ConceptoFra.DESCRIPCION
                    linea.ImporteOriginal = frmConcepto.ConceptoFra.IMPORTE

                    row.BeginEdit()
                    row.Cells("REFCONCEPTO").Value = frmConcepto.ConceptoFra.CODIGO

                    row.Cells("ColumnDtoPercent").Value = 0
                    row.EndEdit()
                Else
                    AnnadeMultiplesLineas(row, frmConcepto.ConceptosSeleccionados)
                End If

            End If
        End If
    End Sub
#End Region

    Private Sub AnnadeMultiplesLineas(ByRef startingRow As GridEXRow, ByRef conceptos As List(Of CONCEPTOSFRA))

        Dim newRow As GridEXRow = startingRow
        For i As Integer = 0 To conceptos.Count - 1

            Dim filaConcepto As CONCEPTOSFRA = conceptos(i)

            Dim linea As LINEASFACTURA = newRow.DataRow
            linea.REFCONCEPTO = filaConcepto.CODIGO
            linea.CONCEPTO = filaConcepto.DESCRIPCION
            linea.ImporteOriginal = filaConcepto.IMPORTE

            GridEXLineas.UpdateData()
            GridEXLineas.Update()


            newRow.BeginEdit()
            newRow.Cells("REFCONCEPTO").Value = filaConcepto.CODIGO

            newRow.Cells("ColumnDtoPercent").Value = 0
            newRow.EndEdit()

            If i < conceptos.Count - 1 Then

                'Dim newlinea As New LINEASFACTURA()
                'newlinea.REFFACTURA = Factura.IDFACTURA
                'newlinea.CANTIDAD = 1
                'newlinea.Descuento = 0
                'newlinea.TIPOIVA = 0
                'newlinea.ImporteOriginal = 0

                'Dim j As Integer = LINEASFACTURAsBindingSource.Add(newlinea)

                'LINEASFACTURAsBindingSource.MoveLast()

                'GridEXLineas.Focus()
                'GridEXLineas.GetRow(j).BeginEdit()
                'GridEXLineas.GetRow(j).Cells("ColumnDtoPercent").Value = 0
                'GridEXLineas.GetRow(j).EndEdit()
                'newRow = GridEXLineas.GetRow(j)
                ''GridEXLineas.CurrentColumn = GridEXLineas.RootTable.Columns("REFCONCEPTO")
                ''GridEXLineas.SelectCurrentCellText()

                'LINEASFACTURAsBindingSource.EndEdit()
                'FACTURABindingSource.EndEdit()
                ''GridEXLineas.EnsureVisible(newRow.RowIndex)

                'GridEXLineas.UpdateData()
                'GridEXLineas.Update()
                btn_ADD_Click(Nothing, Nothing)
                newRow = GridEXLineas.CurrentRow
            End If

            CalculaFila(newRow)
        Next
        GridEXLineas.Refresh()
        LINEASFACTURAsBindingSource.EndEdit()
        CalculaTotalFactura()
    End Sub


#Region "Private Sub ChequeaTarifasEnLineas()"
    Private Sub ChequeaTarifasEnLineas()

        'No recalcular si viene desde Cita
        If FacturadaGeneradaDesdeCita Then Return



        Dim total As Double = 0
        For Each row As GridEXRow In GridEXLineas.GetRows()
            Dim linea As LINEASFACTURA = row.DataRow
            If Not linea Is Nothing Then
                If Not linea.ImporteOriginal Is Nothing Then
                    linea.ImporteOriginal = ObtenImporteConceptoSegunTarifa(linea.REFCONCEPTO, linea.CONCEPTO, linea.ImporteOriginal)
                Else
                    linea.ImporteOriginal = ObtenImporteConceptoSegunTarifa(linea.REFCONCEPTO, linea.CONCEPTO, linea.IMPORTE)
                End If
                row.BeginEdit()
                row.Cells("ImporteOriginal").Value = linea.ImporteOriginal
                row.EndEdit()
                'linea.IMPORTE = linea.ImporteOriginal * linea.CANTIDAD - linea.Descuento
                CalculaFila(row)
            End If

        Next

    End Sub
#End Region

#Region "Private Sub btn_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ADD.Click"
    Private Sub btn_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ADD.Click
        Try


            Dim linea As New LINEASFACTURA()
            linea.REFFACTURA = Factura.IDFACTURA
            linea.CANTIDAD = 1
            linea.Descuento = 0
            linea.TIPOIVA = 0
            linea.ImporteOriginal = 0
            linea.IMPORTE = 0

            Dim i As Integer = LINEASFACTURAsBindingSource.Add(linea)

            LINEASFACTURAsBindingSource.MoveLast()

            GridEXLineas.Focus()
            GridEXLineas.GetRow(i).BeginEdit()
            GridEXLineas.GetRow(i).Cells("ColumnDtoPercent").Value = 0
            GridEXLineas.GetRow(i).EndEdit()

            GridEXLineas.CurrentColumn = GridEXLineas.RootTable.Columns("REFCONCEPTO")
            GridEXLineas.SelectCurrentCellText()

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Private Sub GridEXLineas_CellEdited(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEXLineas.CellEdited"
    Private Sub GridEXLineas_CellEdited(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEXLineas.CellEdited
        If Not e.Column Is Nothing Then
            If e.Column.Index = GridEXLineas.RootTable.Columns("ColumnDtoPercent").Index Then
                If Not GridEXLineas.SelectedItems(0).GetRow().Cells("ColumnDtoPercent").Value Is Nothing Then
                    Dim percent As Double = Double.Parse(GridEXLineas.SelectedItems(0).GetRow().Cells("ColumnDtoPercent").Value)
                    Dim cantidad As Short = CType(GridEXLineas.SelectedItems(0).GetRow().Cells("CANTIDAD").Value, Short)

                    Dim importeOriginal As Double = Double.Parse(GridEXLineas.SelectedItems(0).GetRow().Cells("ImporteOriginal").Value)

                    'GridEXLineas.CurrentRow.BeginEdit()
                    'GridEXLineas.CurrentRow.Cells("Descuento").Value = (percent / 100) * importeOriginal * cantidad
                    Dim linea As LINEASFACTURA = GridEXLineas.SelectedItems(0).GetRow().DataRow
                    linea.Descuento = (percent / 100) * importeOriginal * cantidad
                    'GridEXLineas.CurrentRow.EndEdit()

                End If
            End If

            If e.Column.Index = GridEXLineas.RootTable.Columns("Descuento").Index Then
                Dim cantidad As Short = CType(GridEXLineas.SelectedItems(0).GetRow().Cells("CANTIDAD").Value, Short)
                Dim ImporteOriginal As Double = CType(GridEXLineas.SelectedItems(0).GetRow().Cells("ImporteOriginal").Value, Double)
                Dim dtoImporte As Double = CType(GridEXLineas.SelectedItems(0).GetRow().Cells("Descuento").Value, Double)

                If ImporteOriginal * cantidad > 0 Then
                    GridEXLineas.SelectedItems(0).GetRow().BeginEdit()
                    GridEXLineas.SelectedItems(0).GetRow().Cells("ColumnDtoPercent").Value = (dtoImporte / (ImporteOriginal * cantidad)) * 100
                    Dim linea As LINEASFACTURA = GridEXLineas.SelectedItems(0).GetRow().DataRow
                    linea.Descuento = dtoImporte
                    linea.CANTIDAD = cantidad
                    GridEXLineas.SelectedItems(0).GetRow().Cells("ImporteOriginal").Value = ImporteOriginal
                    GridEXLineas.SelectedItems(0).GetRow().EndEdit()
                End If

            End If

            If e.Column.Index = GridEXLineas.RootTable.Columns("REFCONCEPTO").Index Then
                'Se cambio el codigo a mano cargar el importe y demas
                CargaConcepto(GridEXLineas.SelectedItems(0).GetRow().Cells("REFCONCEPTO").Value, GridEXLineas.SelectedItems(0).GetRow())
            End If

            'If e.Column.Index = GridEXLineas.RootTable.Columns("ImporteOriginal").Index Then
            '    'Se cambio el codigo a mano cargar el importe y demas
            '    Dim linea As LINEASFACTURA = GridEXLineas.SelectedItems(0).GetRow().DataRow
            '    Dim percent As Double = Double.Parse(GridEXLineas.SelectedItems(0).GetRow().Cells("ColumnDtoPercent").Value)

            '    linea.Descuento = (percent / 100) * linea.CANTIDAD * linea.ImporteOriginal
            'End If

        End If

        CalculaFila(GridEXLineas.SelectedItems(0).GetRow())
    End Sub
#End Region

#Region "Private Sub CargaConcepto(ByVal cod As String, ByRef row As GridEXRow)"
    Private Sub CargaConcepto(ByVal cod As String, ByRef row As GridEXRow)
        Dim context2 As New CMLinqDataContext()
        Try
            Dim conceptofra As CONCEPTOSFRA

            'If Globales.Configuracion.Dental_ModuloActivo Then
            conceptofra = (From c In context2.CONCEPTOSFRAs Where c.CODIGO = cod).SingleOrDefault
            'Else
            'conceptofra = (From c In context2.CONCEPTOSFRAs Where c.CODIGO = cod And c.CONCEPTOSFAMILIA.Categoria <> 1).SingleOrDefault
            'End If


            If conceptofra Is Nothing Then
                row.Cells("REFCONCEPTO").Value = Nothing
                Return
            End If
            If Not oldConcepto Is Nothing Then
                If oldConcepto = conceptofra.CODIGO Then
                    Return
                End If
            End If

            Dim linea As LINEASFACTURA = row.DataRow
            linea.REFCONCEPTO = conceptofra.CODIGO
            linea.CONCEPTO = conceptofra.DESCRIPCION
            linea.ImporteOriginal = conceptofra.IMPORTE

            row.BeginEdit()
            row.Cells("REFCONCEPTO").Value = conceptofra.CODIGO
            row.Cells("ColumnDtoPercent").Value = 0
            row.EndEdit()
            oldConcepto = conceptofra.CODIGO
            ConfirmaRecalculo()
            ChequeaTarifasEnLineas()
        Catch ex As Exception
            Dim a = 20
        End Try
    End Sub
#End Region

    '#Region "Private Sub GridEXLineas_LoadingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEXLineas.LoadingRow"
    '    Private Sub GridEXLineas_LoadingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEXLineas.LoadingRow
    '        If e.Row.RowType = RowType.Record Then
    '            'CalculaFila(e.Row)
    '        End If
    '    End Sub
    '#End Region

#Region "Private Sub CalculaFila(ByRef Row As GridEXRow)"
    Private Sub CalculaFila(ByRef row As GridEXRow)
        Try
            'GridEXLineas.Validate()
            LINEASFACTURAsBindingSource.EndEdit()
            GridEXLineas.UpdateData()

            Dim linea As LINEASFACTURA = row.DataRow
            Dim percent As Double = 0

            If Not GridEXLineas.SelectedItems(0).GetRow().Cells("ColumnDtoPercent").Value Is Nothing Then
                percent = Double.Parse(GridEXLineas.SelectedItems(0).GetRow().Cells("ColumnDtoPercent").Value)
            Else

            End If

            linea.Descuento = (percent / 100) * linea.CANTIDAD * linea.ImporteOriginal
            linea.IMPORTE = linea.CANTIDAD * linea.ImporteOriginal - linea.Descuento

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        CalculaTotalFactura()
    End Sub
#End Region

#Region "Private Sub CalculaTotalFactura()"
    Private Sub CalculaTotalFactura()
        Try

        
            LINEASFACTURAsBindingSource.EndEdit()
            GridEXLineas.UpdateData()
            GridEXLineas.Refresh()

            Factura.Descuento = CType(GridEXLineas.GetTotal(GridEXLineas.RootTable.Columns("Descuento"), Janus.Windows.GridEX.AggregateFunction.Sum), Double)

            


            'Calcular el desglose del IVA

            hash.Clear()

            'Dim totalIva As Double = 0

            For Each row As GridEXRow In GridEXLineas.GetRows()
                Dim linea As LINEASFACTURA = row.DataRow
                
                If hash(linea.TIPOIVA) Is Nothing Then
                    Dim desglose As New DESGLOSEIVAS()
                    desglose.TIPOIVA = linea.TIPOIVA
                    desglose.BASE = (linea.IMPORTE) / ((1) + (linea.TIPOIVA / 100))
                    desglose.IMPORTE = linea.IMPORTE - desglose.BASE
                    hash(linea.TIPOIVA) = desglose
                    'totalIva += desglose.IMPORTE
                Else
                    Dim desglose As DESGLOSEIVAS = hash(linea.TIPOIVA)

                    Dim base As Double = ((linea.IMPORTE) / ((1) + (linea.TIPOIVA / 100)))
                    desglose.BASE += base
                    desglose.IMPORTE += (linea.IMPORTE - base)
                    'totalIva += desglose.IMPORTE
                End If
            Next

            ListaDesglosesIva.Clear()
            For Each key As Object In hash.Keys
                Dim desglose As DESGLOSEIVAS = hash(key)
                ListaDesglosesIva.Add(desglose)
            Next


            Dim totalIva As Decimal = ListaDesglosesIva.Sum(Function(o) o.IMPORTE)
            txtTotalIVA.Value = totalIva

            Dim neto As Decimal = GridEXLineas.GetTotal(GridEXLineas.RootTable.Columns("IMPORTE"), Janus.Windows.GridEX.AggregateFunction.Sum)
            Dim baseImponible As Decimal = ListaDesglosesIva.Sum(Function(o) o.BASE)


            Dim irpf As Decimal = txtIRPFPorciento.Value * baseImponible
            txtIRPFImporte.Value = irpf

            txtTotal.Value = neto
            Factura.TOTAL = baseImponible + totalIva - irpf

            txtImporteLiquido.Value = Factura.TOTAL

            GridEXDesglose.DataSource = ListaDesglosesIva
            GridEXDesglose.Refetch()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try

    End Sub
#End Region



    Private Sub txtIRPFPorciento_Validated(sender As Object, e As EventArgs) Handles txtIRPFPorciento.Validated
        CalculaTotalFactura()
        'If Factura.TOTAL > 0 Then

        '    Dim baseimponible As Double = ListaDesglosesIva.Sum(Function(o) o.BASE)

        '    txtIRPFImporte.Value = txtIRPFPorciento.Value * baseimponible
        '    'Factura.IRPF = Factura.PORCENTAJEIRPF * Factura.TOTAL
        '    'txtIRPFImporte.Value = Factura.IRPF
        'End If
        'CalculaTotalFactura()
    End Sub

    
    Private Sub txtIRPFImporte_Validated(sender As Object, e As EventArgs) Handles txtIRPFImporte.Validated
        ' CalculaTotalFactura()
        If Factura.TOTAL > 0 Then
            If Factura.TOTAL > 0 Then
                Dim baseimponible As Double = ListaDesglosesIva.Sum(Function(o) o.BASE)
                If baseimponible > 0 Then
                    txtIRPFPorciento.Value = txtIRPFImporte.Value / (baseimponible)
                    Factura.PORCENTAJEIRPF = txtIRPFImporte.Value / (baseimponible)

                End If
                'txtIRPFPorciento.Value = Factura.PORCENTAJEIRPF
            End If

        End If
        CalculaTotalFactura()

    End Sub




    Private Sub GridEXLineas_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridEXLineas.EditingCell
        If e.Column.Index = GridEXLineas.RootTable.Columns("REFCONCEPTO").Index Then
            oldConcepto = e.Value
        Else
            oldConcepto = Nothing
        End If


        If Not GridEXLineas.CurrentRow Is Nothing Then
            If EsLineaFacturaPagada(GridEXLineas.CurrentRow) Then
                If Globales.Usuario.EsAdministrador Then
                    'MessageBox.Show("Esta linea proviene de una linea de cita pagada, modifiquela a riesgo de ")
                Else
                    MessageBox.Show("Esta linea no puede ser modificada pues proviene de una cita pagada")
                    e.Cancel = True
                End If
            End If
        End If
        
    End Sub


    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If Not GridEXLineas.CurrentRow Is Nothing Then
            Try
                'GridEXLineas.UpdateData()
                'GridEXLineas.Delete()
                'GridEXLineas.Refetch()
                If Nuevo Then
                    GridEXLineas.Delete()
                    CalculaTotalFactura()
                    Return
                End If


                Try
                    Context.LINEASFACTURAs.DeleteOnSubmit(GridEXLineas.CurrentRow.DataRow)
                    Context.SubmitChanges()
                    CargaDatos()
                Catch ex As Exception
                End Try

                GridEXLineas.Delete()

                'Factura.LINEASFACTURAs.Remove(GridEXLineas.CurrentRow.DataRow)

                'Dim idlinea As Integer = GridEXLineas.CurrentRow.DataRow.IDLINEAFACTURA
                'Dim linea As LINEASFACTURA = (From l As LINEASFACTURA In Context.LINEASFACTURAs Where l.IDLINEAFACTURA = idlinea Select l).SingleOrDefault
                'Context.LINEASFACTURAs.DeleteOnSubmit(linea)

                'FACTURABindingSource.EndEdit()


                CalculaTotalFactura()
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub GridEXLineas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEXLineas.SelectionChanged
        btn_Eliminar.Enabled = GridEXLineas.SelectedItems.Count > 0
    End Sub

#Region "Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click"
    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click

        If Not Guardar() Then
            Return
        End If

       


        Dim PlantillaReporte As String = ""
        If cb_tipo.Text = "Mutua" Then
            PlantillaReporte = "FacturaMutua.rdlc"
            'frmVisor.Seccion = "facturas_mutua"
        Else
            PlantillaReporte = "Factura.rdlc"
            'frmVisor.Seccion = "facturas_paciente"
        End If

        'Datasources
        Dim dsFacturas As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsFacturasLineas As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsPaciente As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim dsDesglose As New Microsoft.Reporting.WinForms.ReportDataSource

        dsFacturas.Name = "dsFactura"
        dsFacturasLineas.Name = "dsLineas"
        dsPaciente.Name = "dsPacientes"
        dsDesglose.Name = "dsDesglose"

        Dim listFactura As New List(Of WRAPPER_FACTURA)
        listFactura.Add(New WRAPPER_FACTURA(Factura))
        Dim listPaciente As New List(Of PACIENTE)
        listPaciente.Add(Factura.PACIENTE1)

        dsFacturas.Value = listFactura
        dsFacturasLineas.Value = Factura.LINEASFACTURAs
        dsPaciente.Value = listPaciente
        dsDesglose.Value = ListaDesglosesIva


        'Parametros
        Dim _params_list As List(Of Microsoft.Reporting.WinForms.ReportParameter) = New List(Of ReportParameter)

        Dim _LetraDni As String = Me.lb_dpLetradni.Text.Trim
        _params_list.Add(New ReportParameter("params_LetraDNI", _LetraDni))

        Dim dsMutuas As New Microsoft.Reporting.WinForms.ReportDataSource
        dsMutuas.Name = "dsMutuas"

        If cb_tipo.SelectedItem = "Mutua" Then
            'Agregar la mutua como datasource

            If CtrlMutua1.ID_Mutuas.HasValue Then
                

                Dim mutua As MUTUA = (From m In context.MUTUAs Where m.CMUTUA = CtrlMutua1.ID_Mutuas).SingleOrDefault
                Dim listMutua As New List(Of MUTUA)
                listMutua.Add(mutua)
                dsMutuas.Value = listMutua
                'frmVisor.ReportViewer.LocalReport.DataSources.Add(dsMutuas)
            Else
                MessageBox.Show("Esta factura es de mutua pero no tiene mutua asignada.")
                Return
            End If
        End If


        UI.Reportes.ReportesManager.Imprime(PlantillaReporte, {dsFacturas, dsFacturasLineas, dsPaciente, dsDesglose, dsMutuas}, _params_list.ToArray)

        'Si Imprimo ya guardo y es oficial, por tanto la factura existe y cierro esta ventana para evitar inconsistencias
        'Me.DialogResult = Windows.Forms.DialogResult.OK
        'Me.Close()


    End Sub

#End Region


    Private Sub MaskedEditBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNI.TextChanged
        Me.lb_dpLetradni.Text = centro_medico.Globales.GetLetter(txtDNI.UnmaskedText)

    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        FACTURABindingSource.CancelEdit()
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function ChequeaSiExisteNumero(ByVal numero As String) As Boolean
        Try
            Dim fac As FACTURA = (From f In Context.FACTURAs _
                                  Where f.NUMERO = numero And f.IDFACTURA <> Factura.IDFACTURA And f.Eliminado = False
                           Select f).SingleOrDefault
            If fac Is Nothing Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Return True
        End Try
    End Function



    Private Function Guardar() As Boolean
        'Validaciones
        If Not CtrlPaciente1.ID_PACIENTE.HasValue Then
            MessageBox.Show("Se requiere un paciente")
            CtrlPaciente1.Focus()
            Return False

        End If

        If tb_nro.Text = String.Empty Then
            MessageBox.Show("Debe especificarse un numero de factura")
            tb_nro.Focus()
            Return False
        End If

        If tb_nro.Text.Trim() = String.Empty Then
            MessageBox.Show("Debe especificarse un numero de factura")
            tb_nro.Focus()
            Return False
        End If

        If ChequeaSiExisteNumero(tb_nro.Text) Then
            MessageBox.Show("El numero de Factura ya existe en otra factura, modifiquelo")
            tb_nro.Focus()
            Return False
        End If

       
        Try
            'Factura.REFFORMAPAGO = CtrlFormaPago21.ID_FORMASPAGO
            FACTURABindingSource.EndEdit()

            'Factura.FORMASPAGO = (From f In context.FORMASPAGOs Where f.CODIGO = CtrlFormaPago21.ID_FORMASPAGO Select f).SingleOrDefault

            Factura.PORCENTAJEIRPF = txtIRPFPorciento.Value
            Factura.IRPF = txtIRPFImporte.Value

            If chk_pagada.Checked Then
                Factura.FECHACOBRO = cb_pagada.Value
                Factura.PAGADA = "S"
            Else
                Factura.PAGADA = "N"
                Factura.FECHACOBRO = Nothing
            End If

            If combo_FechaEnvio.Checked Then
                Factura.FECHAENVIO = combo_FechaEnvio.Value
                'Factura.PAGADA = "S"
            Else
                'Factura.PAGADA = "N"
                Factura.FECHAENVIO = Nothing
            End If

            If cb_tipo.SelectedIndex = 0 Then
                Factura.FACTURAR = "P"
            Else
                Factura.FACTURAR = "M"
            End If

            If Not dtp_falta.Checked Then
                Factura.FALTA = Nothing
            End If

            If Not dtp_fbaja.Checked Then
                Factura.FBAJA = Nothing
            End If

            If Not dtp_fasistencia.Checked Then
                Factura.FACCIDENTE = Nothing
            End If

            If CtrlMutua1.ID_Mutuas.HasValue Then
                Factura.REFMUTUA = CtrlMutua1.ID_Mutuas
                Factura.MUTUA = CtrlMutua1.NombreCompleto
            Else
                Factura.REFMUTUA = Nothing
                Factura.MUTUA = ""
            End If

            If CtrlEmpresa1.ID_EMPRESAS.HasValue Then
                Factura.REFEMPRESA = CtrlEmpresa1.ID_EMPRESAS
                Factura.EMPRESA = CtrlEmpresa1.NombreCompleto
            Else
                Factura.REFEMPRESA = Nothing
                Factura.EMPRESA = ""
            End If

            If Not CtrlFormaPago21.ID_FORMASPAGO Is Nothing Then
                Factura.FORMASPAGO = Context.FORMASPAGOs().Single(Function(f) f.CODIGO = CtrlFormaPago21.ID_FORMASPAGO)
            Else
                Factura.FORMASPAGO = Nothing
                Factura.REFFORMAPAGO = Nothing
            End If

            If CtrlPaciente1.ID_PACIENTE.HasValue Then
                Factura.REFPACIENTE = CtrlPaciente1.ID_PACIENTE
                Factura.PACIENTE = CtrlPaciente1.Paciente.NombreCompleto
            End If


            Factura.DNI = txtDNI.UnmaskedText
            Factura.REFSERIE = SERIESComboBox.SelectedValue

            If Nuevo Then
                'Factura.REFSERIE = SERIESComboBox.SelectedValue
                If Not SERIESComboBox.SelectedValue Is Nothing Then
                    Dim serie As SERIES = SERIESComboBox.SelectedItem
                    serie.CONTADOR += 1
                End If

                'Para mantener compatibilidad
                Factura.NUMEROFACTURA = Factura.IDFACTURA
                Factura.FECHA = Date.Now
                Factura.HORA = dtp_Hora.Value
                Factura.TIPOIVA = 0 'Esto por si acaso se coge por linea

                If Not Context.FACTURAs.Contains(Factura) Then
                    Context.FACTURAs.InsertOnSubmit(Factura)
                End If
                Nuevo = False

            Else

                If anteriorserie <> Factura.REFSERIE Then
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Facturas, "FACTURASM", Factura.IDFACTURA, "[" & Factura.NUMERO & "] " & "MODIFICADA SERIE (" & anteriorserie & " a " & Factura.REFSERIE & ") - PACIENTE :" & Factura.PACIENTE)

                End If

                If anteriornumero <> Factura.NUMERO Then
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Facturas, "FACTURASM", Factura.IDFACTURA, "[" & Factura.NUMERO & "] " & "MODIFICADO NUMERO Factura (" & anteriornumero & " a " & Factura.NUMERO & ") - PACIENTE :" & Factura.PACIENTE)
                End If



            End If

            GeneraRecibo()
            'Este context solo salva el incremento de la serie, no la factura.
            Context.SubmitChanges()

            'If Factura.PAGADA = "S" Then
            '    Dim citas As List(Of CITA) = (From c As CITA In Context.CITAs _
            '                        Where c.REFFRA = Factura.IDFACTURA _
            '                        Select c).ToList()

            '    For Each c As CITA In citas
            '        c.PAGADA = "S"
            '        Context.SubmitChanges()
            '        'RaiseEvent CitaPagada(c.IDCITA)
            '    Next
            'End If

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
            Return False

        End Try
        Return True
    End Function
#Region "Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click"
    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
#End Region

#Region "Private Sub GeneraRecibo()"
    Private Sub GeneraRecibo()
        If chb_recibo.Checked Then
            Dim recibo As RECIBO
            If Nuevo Then
                'Generar Recibo
                recibo = New RECIBO()
                recibo.FECHAEMISION = Date.Now
                context.RECIBOs.InsertOnSubmit(recibo)
            Else
                'Actualizar recibo
                If Not Factura.REFRECIBO Is Nothing Then
                    recibo = (From r In context.RECIBOs Where r.NUMERO = Factura.REFRECIBO).SingleOrDefault
                    If recibo Is Nothing Then
                        'recibo invalido
                        Return
                    End If
                Else
                    recibo = New RECIBO()
                    recibo.FECHAEMISION = Date.Now
                    context.RECIBOs.InsertOnSubmit(recibo)
                End If
            End If

            recibo.CONCEPTO = "Cobro Fra. " & Factura.NUMERO
            recibo.REFFORMAPAGO = Factura.REFFORMAPAGO
            recibo.REFFACTURA = Factura.IDFACTURA
            If Not CtrlPaciente1.Paciente.DOMICILIO Is Nothing Then
                recibo.DIRECCION = CtrlPaciente1.Paciente.DOMICILIO
            End If

            If Not CtrlPaciente1.Paciente.ENTIDAD Is Nothing Then
                recibo.ENTIDAD = CtrlPaciente1.Paciente.ENTIDAD
            End If

            If Not CtrlPaciente1.Paciente.OFICINA Is Nothing Then
                recibo.OFICINA = CtrlPaciente1.Paciente.OFICINA
            End If

            If Not CtrlPaciente1.Paciente.DC Is Nothing Then
                recibo.DC = CtrlPaciente1.Paciente.DC
            End If

            If Not CtrlPaciente1.Paciente.CUENTA Is Nothing Then
                recibo.CUENTA = CtrlPaciente1.Paciente.CUENTA
            End If

            recibo.TIPO = "G" 'Generado
            recibo.COBRADO = "N"
            recibo.EMITIDO = "N"
            recibo.CUENTABANCO = ""
            recibo.FECHACOBRO = Nothing
            recibo.FECHAVENCIMIENTO = Nothing
            recibo.IMPORTE = Factura.TOTAL
            recibo.N19 = "N"
            recibo.NOMBRE = CtrlPaciente1.NombreCompleto
            recibo.NOTAS = ""
            recibo.REFEMPRESA = Factura.REFEMPRESA
            recibo.REFPACIENTE = Factura.REFPACIENTE


            'context.SubmitChanges() ' Actualiza / crea el recibo
            Factura.REFRECIBO = recibo.NUMERO
        Else
            'No esta marcado el checkbox
            'significa eliminar el recibo si tiene y es es de tipo (G)enerado

            Dim recibo As RECIBO

            If Not Factura.REFRECIBO Is Nothing Then
                recibo = (From r In context.RECIBOs Where r.NUMERO = Factura.REFRECIBO).SingleOrDefault
                If recibo Is Nothing Then
                    'recibo invalido
                    Return
                Else
                    If recibo.TIPO = "G" Then
                        Try
                            context.RECIBOs.DeleteOnSubmit(recibo)
                            'context.SubmitChanges()
                        Catch ex As Exception
                        End Try
                        Factura.REFRECIBO = Nothing
                    End If
                End If
            End If
        End If
        'Globales.CobroEnCascada(Factura.IDFACTURA)
    End Sub
#End Region




    'Private Sub CtrlEmpresa1_EMPRESAEliminado(ByVal IdEMPRESASAnterior As System.Int32) Handles CtrlEmpresa1.EMPRESAEliminado
    '    Factura.EMPRESA = ""
    '    'Factura.REFEMPRESA = Nothing
    'End Sub

    'Private Sub CtrlEmpresa1_EMPRESASeleccionado(ByVal IdEMPRESAS As System.Int32, ByVal IsReturnPressed As System.Boolean) Handles CtrlEmpresa1.EMPRESASeleccionado
    '    'Factura.REFEMPRESA = CtrlEmpresa1.ID_EMPRESAS
    '    Factura.EMPRESA = CtrlEmpresa1.EMPRESA.NOMBRE
    '    If Factura.EMPRESA Is Nothing Then
    '        Factura.EMPRESA = ""
    '    End If
    'End Sub

    'Private Sub CtrlPaciente1_PacienteSeleccionadoDeNuevo(IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteSeleccionadoDeNuevo
    '    If Me.IsHandleCreated Then
    '        If MessageBox.Show("¿Desea actualizar los datos del paciente en la factura?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
    '            CargaDatosPaciente()
    '        End If
    '    End If
    'End Sub

    Private Sub CtrlPaciente1_PacienteFichaAbierta(IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteFichaAbierta
        If MessageBox.Show("¿Desea actualizar los datos del paciente en la factura?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            CargaDatosPaciente()
        End If
    End Sub

    Private Sub CtrlPaciente1_PacienteSeleccionadoByBrowser(IdPaciente As System.Int32) Handles CtrlPaciente1.PacienteSeleccionadoByBrowser
        If Me.IsHandleCreated Then
            If MessageBox.Show("¿Desea cargar los datos del paciente en la factura?", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CargaDatosPaciente()
            End If
        End If
    End Sub


    Dim estadoAnteriorAlClick
    Private Sub dtp_fcobro_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub dtp_fcobro_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
      
    End Sub

    Private Sub FacturaPagada(ByVal idFactura As Integer)
        'dtp_fcobro.Enabled = False
        Factura.PAGADA = "S"
        Guardar()
        'DesactivaTodo()
        '    lblEdicionDesactivada.Enabled = True
        '    lblEdicionDesactivada.Visible = True
        '    bt_aceptar.Enabled = True
        '    bt_imprimir.Enabled = True
    End Sub

    Private Sub GridEXLineas_LoadingRow(sender As System.Object, e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEXLineas.LoadingRow
        If Not e.Row.DataRow Is Nothing Then
            If EsLineaFacturaPagada(e.Row) Then
                e.Row.Cells("ColumnPagada").Value = True
            Else
                e.Row.Cells("ColumnPagada").Value = False
            End If
        End If
    End Sub


    Function EsLineaFacturaPagada(row As GridEXRow) As Boolean
        Try
            Dim lineaFactura As LINEASFACTURA = row.DataRow
            If Not lineaFactura Is Nothing Then
                If Not lineaFactura.IMPORTE.HasValue Then
                    lineaFactura.IMPORTE = 0
                End If
                If lineaFactura.RefLineaCita.HasValue Then
                    Dim lineaCita As LineasCita = (From c In Context.LineasCitas Where c.IdLinea = lineaFactura.RefLineaCita Select c).SingleOrDefault()
                    If Not lineaCita.CITA Is Nothing Then
                        If lineaCita.CITA.PAGADA = "S" AndAlso (lineaCita.CITA.PagadoDesdeFactura Is Nothing Or lineaCita.CITA.PagadoDesdeFactura <> True) Then
                            row.Cells("ColumnInfo").Text = "Importe pagado en la cita " & lineaCita.CITA.FECHA.Value.ToShortDateString() & " a las " & lineaCita.CITA.HORA.Value.ToShortTimeString()

                            Return True
                        ElseIf (lineaCita.CITA.PAGADA = "S" AndAlso lineaCita.CITA.PagadoDesdeFactura = True) Then
                            row.Cells("ColumnInfo").Text = "Pagada al dar por pagada esta factura"
                            Return True
                        End If
                    End If

                End If
            End If
            Return False
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al cargar información sobre el pago de la cita")
        End Try
    End Function

    'Private Sub pb_UndoCobrar_Click(sender As System.Object, e As System.EventArgs)
    '    cb_pagada.Enabled = True
    'End Sub


    Function TodasCitasAsociadasPagadas() As Boolean
        Dim citas As List(Of CITA) = (From c In Context.CITAs
                                     Where c.REFFRA = Factura.IDFACTURA
                                     Select c).ToList()
        For Each c As CITA In citas
            If c.PAGADA = "N" Then Return False
        Next
        Return True

    End Function
    Private Function citaspagadas() As Boolean
        'compruebo si las lineas vienen de citas y han sido pagadas previamente para no cargar el débito
        Dim rows = GridEXLineas.GetRows()
        Dim r As GridEXRow
        Dim citapagada As Boolean = True
        For Each r In rows
            If r.RowType = RowType.Record Then
                If r.Cells("ColumnPagada").Value = False Then
                    citapagada = False
                End If
            End If
        Next
        Return citapagada
    End Function

    Private Sub cb_pagada_Click(sender As System.Object, e As System.EventArgs) Handles chk_pagada.Click

        If citaspagadas() = False And CInt(Me.txtTotal.Text) > 0 Then

            chk_pagada.Checked = False

            If Not Guardar() Then

                Return
            End If

            Dim pdm As New PacienteDebitoManager(CtrlPaciente1.Paciente, Context, Nothing)

            If pdm.PagarDocumentos({Factura},
                                    New frmPagarDocumentos(Me.cb_pagada.Value),
                                    CtrlFormaPago21.ID_FORMASPAGO,
                                    Globales.Usuario.CODIGO,
                                   Context) = Windows.Forms.DialogResult.OK Then
                chk_pagada.Checked = True
                chk_pagada.Enabled = False
                cb_pagada.Value = Factura.FECHACOBRO
                CtrlFormaPago21.ID_FORMASPAGO = Factura.IDFormaPago
                Me.DesactivaTodo()
            End If

            pagaCitasVinculadas()

        End If
    End Sub
    Private Sub pagaCitasVinculadas()
        Dim citas As List(Of CITA) = (From c In Context.CITAs Select c Where c.REFFRA = Factura.IDDocumento And c.Eliminado = False).ToList

        For Each c As CITA In citas
            If c.PAGADA = "N" OrElse c.PAGADA Is Nothing Then
                c.PAGADA = "S"
                If Not Factura.REFFORMAPAGO Is Nothing Then
                    c.REFFORMAPAGO = Factura.REFFORMAPAGO
                End If
                c.FECHACOBRO = Factura.FECHACOBRO
                c.NOTAS = IIf(Trim(c.NOTAS).Length > 0, c.NOTAS & vbCrLf, "")
                c.NOTAS = c.NOTAS & "Pagado a través de factura " & Factura.NUMERO
                c.PagadoDesdeFactura = True
            End If
        Next
    End Sub

    Private Sub frmFacturasM_ADD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Nuevo Then Guardar()
    End Sub

    Private Sub btnFacturaE_Click(sender As Object, e As EventArgs) Handles btnFacturaE.Click
        If (Not Nuevo) Then
            FacturasManager.ExportarAFacturaE(Context, Factura)
        End If
    End Sub

End Class