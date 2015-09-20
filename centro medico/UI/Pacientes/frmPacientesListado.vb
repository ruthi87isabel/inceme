Imports Janus.Windows.GridEX
Imports centro_medico.UI.Reportes

Public Class frmPacientesListado

    Dim ts As New Threading.ThreadStart(AddressOf PreparaImpresion)
    Dim threadPrint As New System.Threading.Thread(ts)

    Dim lista As New List(Of WRAPPER_PACIENTE)

    Public seleccion As Integer = 0
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Paciente As PACIENTE = Nothing
    Public Context As New CMLinqDataContext()

    ''' <summary>
    ''' Libero los recursos ocupados
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPacientesListado_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        If (Not Me.IsDisposed) Then
            Me.Dispose()
        End If
        FreeMemory.FlushMemory()

    End Sub

    Private Sub frmListadoPacientes2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tstNuevo.Visible = Globales.Usuario.Permisos(RoleManager.Items.Pacientes) > RoleManager.TipoPermisos.Lectura
        tst_Editar.Visible = Globales.Usuario.Permisos(RoleManager.Items.Pacientes) > RoleManager.TipoPermisos.Lectura
        tst_Eliminar.Visible = Globales.Usuario.Permisos(RoleManager.Items.Pacientes) > RoleManager.TipoPermisos.Lectura
        tstMsgAll.Visible = Globales.Usuario.Permisos(RoleManager.Items.Comunicaciones) > RoleManager.TipoPermisos.Lectura
        tstMsgSelected.Visible = Globales.Usuario.Permisos(RoleManager.Items.Comunicaciones) > RoleManager.TipoPermisos.Lectura
        grpFiltrosEspeciales.Visible = Globales.Configuracion.FiltroEspecial_Cumplennos

        CrearGridEstrutura()
        AplicarFormato()
        PopulateGrid()
    End Sub

    Private Sub CrearGridEstrutura()
        Dim table As New GridEXTable()
        table.CellLayoutMode = CellLayoutMode.UseColumnSets
        table.Caption = "Listado de Pacientes"
        table.Key = "Listado de Pacientes"
        table.ColumnSetRowCount = 2

        'Columns
        ' Checkbox
        Dim columnCheck As GridEXColumn = table.Columns.Add()
        columnCheck.Key = "Column1"
        columnCheck.AllowSize = False
        columnCheck.Caption = ""
        columnCheck.BoundMode = ColumnBoundMode.UnboundFetch
        columnCheck.ColumnType = ColumnType.CheckBox
        columnCheck.EditType = EditType.CheckBox
        columnCheck.DefaultGroupPrefix = ":"
        columnCheck.ActAsSelector = True
        columnCheck.AllowDrag = False
        'columnCheck.Width = 23

        'Codigo del paciente
        Dim columnCPaciente As GridEXColumn = table.Columns.Add("CPACIENTE", ColumnType.Text, EditType.TextBox)
        columnCPaciente.Caption = "COD"
        columnCPaciente.BoundMode = ColumnBoundMode.Bound
        columnCPaciente.DefaultGroupPrefix = "COD:"
        'columnCPaciente.Width = 59

        'Codigo Propio
        Dim columnCodPaciente As GridEXColumn = table.Columns.Add("CODIGOPROPIO", ColumnType.Text, EditType.TextBox)
        columnCodPaciente.Caption = "C.Propio"
        columnCodPaciente.BoundMode = ColumnBoundMode.Bound
        columnCodPaciente.DefaultGroupPrefix = "C.Propio:"
        'columnCodPaciente.Width = 59

        'Nombre
        Dim columnNombre As GridEXColumn = table.Columns.Add("NOMBRE", ColumnType.Text, EditType.TextBox)
        columnNombre.Caption = "Nombre"
        columnNombre.BoundMode = ColumnBoundMode.Bound
        columnNombre.DefaultGroupPrefix = "Nombre:"
        'columnNombre.Width = 79

        'Apellido1
        Dim columnApellido1 As GridEXColumn = table.Columns.Add("APELLIDO1", ColumnType.Text, EditType.TextBox)
        columnApellido1.Caption = "Apellido1"
        columnApellido1.BoundMode = ColumnBoundMode.Bound
        columnApellido1.DefaultGroupPrefix = "Apellido1:"
        'columnApellido1.Width = 74

        'Apellido2
        Dim columnApellido2 As GridEXColumn = table.Columns.Add("APELLIDO2", ColumnType.Text, EditType.TextBox)
        columnApellido2.Caption = "Apellido2"
        columnApellido2.BoundMode = ColumnBoundMode.Bound
        columnApellido2.DefaultGroupPrefix = "Apellido2:"
        'columnApellido2.Width = 74

        'Empresa
        Dim columnEmpresa As GridEXColumn = table.Columns.Add("EMPRESA", ColumnType.Text, EditType.TextBox)
        columnEmpresa.Caption = "Empresa"
        columnEmpresa.BoundMode = ColumnBoundMode.Bound
        columnEmpresa.DefaultGroupPrefix = "Empresa:"
        'columnEmpresa.Width = 93

        'Mutua
        Dim columnMutua As GridEXColumn = table.Columns.Add("MUTUA", ColumnType.Text, EditType.TextBox)
        columnMutua.Caption = "Mutua"
        columnMutua.BoundMode = ColumnBoundMode.Bound
        columnMutua.DefaultGroupPrefix = "Mutua:"
        'columnMutua.Width = 93

        'Fecha Nac
        Dim columnFechaNac As GridEXColumn = table.Columns.Add("FECHAN", ColumnType.Text, EditType.CalendarCombo)
        columnFechaNac.Caption = "Fecha Nac"
        columnFechaNac.FormatString = "d"
        columnFechaNac.DefaultGroupInterval = GroupInterval.Date
        columnFechaNac.BoundMode = ColumnBoundMode.Bound
        columnFechaNac.DefaultGroupPrefix = "Fecha Nac:"
        'columnFechaNac.Width = 72

        'Fecha Alta
        Dim columnFechaAlta As GridEXColumn = table.Columns.Add("FECHAALTA", ColumnType.Text, EditType.CalendarCombo)
        columnFechaAlta.Caption = "Fecha Alta"
        columnFechaAlta.FormatString = "d"
        columnFechaAlta.DefaultGroupInterval = GroupInterval.Date
        columnFechaAlta.BoundMode = ColumnBoundMode.Bound
        columnFechaAlta.DefaultGroupPrefix = "Fecha Alta:"
        'columnFechaAlta.Width = 66

        'Fecha Baja
        Dim columnFechaBaja As GridEXColumn = table.Columns.Add("FECHABAJA", ColumnType.Text, EditType.CalendarCombo)
        columnFechaBaja.Caption = "Fecha Baja"
        columnFechaBaja.FormatString = "d"
        columnFechaBaja.DefaultGroupInterval = GroupInterval.Date
        columnFechaBaja.BoundMode = ColumnBoundMode.Bound
        columnFechaBaja.DefaultGroupPrefix = "Fecha Baja:"
        'columnFechaBaja.Width = 66

        Dim columnFechaSocio As GridEXColumn = table.Columns.Add("SOCIOVALIDOHASTA", ColumnType.Text, EditType.NoEdit)
        columnFechaBaja.Caption = "Socio Hasta"
        columnFechaBaja.FormatString = "d"
        columnFechaBaja.DefaultGroupInterval = GroupInterval.Date
        columnFechaBaja.BoundMode = ColumnBoundMode.Bound
        columnFechaBaja.DefaultGroupPrefix = "Socio Hasta:"

        'Activo
        Dim columnActivo As GridEXColumn = table.Columns.Add("ACTIVO", ColumnType.Text, EditType.TextBox)
        columnActivo.Caption = "Activo"
        columnActivo.BoundMode = ColumnBoundMode.Bound
        columnActivo.DefaultGroupPrefix = "Activo:"

        'BeneficiarioCodigoSocio
        Dim columnBeneficiarioSocio As GridEXColumn = table.Columns.Add("BENEFICIARIOCODIGOSOCIO", ColumnType.Text, EditType.TextBox)
        columnActivo.Caption = "Beneficiario"
        columnActivo.BoundMode = ColumnBoundMode.Bound
        columnActivo.DefaultGroupPrefix = "Beneficiario:"

        'Socio
        Dim columnSocio As GridEXColumn = table.Columns.Add("SOCIO", ColumnType.Text, EditType.TextBox)
        columnSocio.Caption = "Socio"
        columnSocio.BoundMode = ColumnBoundMode.Bound
        columnSocio.DefaultGroupPrefix = "Socio:"

        'Defuncion
        Dim columnDefuncion As GridEXColumn = table.Columns.Add("DEFUNCION", ColumnType.Text, EditType.TextBox)
        columnDefuncion.Caption = "Defunción"
        columnDefuncion.BoundMode = ColumnBoundMode.Bound
        columnDefuncion.HeaderAlignment = TextAlignment.Center
        columnDefuncion.DefaultGroupPrefix = "Defunción:"
        'columnDefuncion.Width = 64

        'Pago Banco
        Dim columnPagoBanco As GridEXColumn = table.Columns.Add("PAGOBANCO", ColumnType.Text, EditType.TextBox)
        columnPagoBanco.Caption = "Pago Banco"
        columnPagoBanco.BoundMode = ColumnBoundMode.Bound
        columnPagoBanco.DefaultGroupPrefix = "Pago Banco:"

        'Pais
        Dim columnPais As GridEXColumn = table.Columns.Add("PAIS", ColumnType.Text, EditType.TextBox)
        columnPais.Caption = "País"
        columnPais.BoundMode = ColumnBoundMode.Bound
        columnPais.DefaultGroupPrefix = "País:"

        'Importe
        Dim columnImporte As GridEXColumn = table.Columns.Add("IMPORTE", ColumnType.Text, EditType.TextBox)
        columnImporte.Caption = "Importe"
        columnImporte.BoundMode = ColumnBoundMode.Bound
        columnImporte.DefaultGroupPrefix = "Importe:"
        columnImporte.AggregateFunction = AggregateFunction.Sum
        columnImporte.HeaderAlignment = TextAlignment.Center
        columnImporte.HeaderLineAlignment = TextAlignment.Center
        columnImporte.TotalFormatString = "C2"
        columnImporte.FormatString = "C2"

        'Forma de Pago
        Dim columnFormaPago As GridEXColumn = table.Columns.Add("Forma Pago", ColumnType.Text, EditType.TextBox)
        columnFormaPago.Caption = "Forma Pago"
        columnFormaPago.BoundMode = ColumnBoundMode.Bound
        columnImporte.HeaderAlignment = TextAlignment.Center
        columnImporte.HeaderLineAlignment = TextAlignment.Center
        columnFormaPago.DefaultGroupPrefix = "Forma Pago:"

        'Domicilio
        Dim columnDomicilio As GridEXColumn = table.Columns.Add("DOMICILIO", ColumnType.Text, EditType.TextBox)
        columnDomicilio.Caption = "Domicilio"
        columnDomicilio.BoundMode = ColumnBoundMode.Bound
        columnDomicilio.DefaultGroupPrefix = "Domicilio:"
        'columnDomicilio.Width = 158

        'Localidad
        Dim columnLocalidad As GridEXColumn = table.Columns.Add("LOCALIDAD", ColumnType.Text, EditType.TextBox)
        columnLocalidad.Caption = "Localidad"
        columnLocalidad.BoundMode = ColumnBoundMode.Bound
        columnLocalidad.DefaultGroupPrefix = "Localidad:"
        'columnLocalidad.Width = 81

        'Provincia
        Dim columnProv As GridEXColumn = table.Columns.Add("PROVINCIA", ColumnType.Text, EditType.TextBox)
        columnProv.Caption = "Provincia"
        columnProv.BoundMode = ColumnBoundMode.Bound
        columnProv.DefaultGroupPrefix = "Provincia:"
        'columnProv.Width = 77

        'Telef
        Dim columnTelef As GridEXColumn = table.Columns.Add("TLFNO", ColumnType.Text, EditType.TextBox)
        columnTelef.Caption = "Tlfno"
        columnTelef.BoundMode = ColumnBoundMode.Bound
        columnTelef.DefaultGroupPrefix = "Tlfno:"
        ' columnTelef.Width = 78

        'Movil
        Dim columnMovil As GridEXColumn = table.Columns.Add("MOVIL", ColumnType.Text, EditType.TextBox)
        columnMovil.Caption = "Movil"
        columnMovil.BoundMode = ColumnBoundMode.Bound
        columnMovil.DefaultGroupPrefix = "Movil:"
        'columnMovil.Width = 78

        'Email
        Dim columnEmail As GridEXColumn = table.Columns.Add("EMAIL", ColumnType.Text, EditType.TextBox)
        columnEmail.Caption = "Email"
        columnEmail.BoundMode = ColumnBoundMode.Bound
        columnEmail.DefaultGroupPrefix = "Email:"
        ' columnEmail.Width = 80

        'Doc Consentimiento
        Dim columnConsentimiento As GridEXColumn = table.Columns.Add("TieneDocumentoConsentimiento", ColumnType.CheckBox, EditType.NoEdit)
        columnConsentimiento.Caption = "Consentimiento"
        columnConsentimiento.BoundMode = ColumnBoundMode.Bound
        columnConsentimiento.DefaultGroupPrefix = "Consentimiento:"
        ' columnEmail.Width = 80

        'ColumnSets
        Dim columnSet As GridEXColumnSet = table.ColumnSets.Add()
        columnSet.Add(columnCheck, 0, 0, 2, 1)
        columnSet.Add(columnCPaciente, 0, 1, 1, 1)
        columnSet.Add(columnCodPaciente, 1, 1, 1, 1)
        columnSet.SetColumnWidth(0, 23)
        columnSet.SetColumnWidth(1, 59)


        columnSet = table.ColumnSets.Add()
        columnSet.Add(columnNombre, 0, 0, 1, 1)
        columnSet.Add(columnApellido1, 0, 1, 1, 1)
        columnSet.Add(columnApellido2, 1, 1, 1, 1)
        columnSet.SetColumnWidth(0, 79)
        columnSet.SetColumnWidth(1, 74)

        columnSet = table.ColumnSets.Add()
        columnSet.Add(columnEmpresa, 0, 0, 1, 1)
        columnSet.Add(columnMutua, 1, 0, 1, 1)
        columnSet.ColumnCount = 1
        columnSet.Width = 93

        columnSet = table.ColumnSets.Add()
        columnSet.Add(columnFechaNac, 0, 0, 2, 1)
        columnSet.Add(columnFechaAlta, 0, 1, 1, 1)
        columnSet.Add(columnFechaBaja, 1, 1, 1, 1)
        columnSet.SetColumnWidth(0, 72)
        columnSet.SetColumnWidth(1, 66)

        columnSet = table.ColumnSets.Add()
        columnSet.Add(columnDefuncion, 0, 1, 1, 1)
        columnSet.Add(columnSocio, 1, 0, 1, 1)
        columnSet.Add(columnActivo, 0, 0, 1, 1)
        columnSet.Add(columnBeneficiarioSocio, 1, 1, 1, 1)
        columnSet.HeaderAlignment = TextAlignment.Center
        columnSet.SetColumnWidth(0, 43)
        columnSet.SetColumnWidth(1, 64)

        columnSet = table.ColumnSets.Add()
        columnSet.Add(columnPagoBanco, 0, 0, 1, 1)
        columnSet.Add(columnPais, 1, 0, 1, 1)
        columnSet.Add(columnImporte, 1, 1, 1, 1)
        columnSet.Add(columnFormaPago, 0, 1, 1, 1)
        columnSet.SetColumnWidth(0, 64)
        columnSet.SetColumnWidth(1, 87)

        columnSet = table.ColumnSets.Add()
        columnSet.Add(columnDomicilio, 0, 0, 1, 2)
        columnSet.Add(columnLocalidad, 1, 0, 1, 1)
        columnSet.Add(columnProv, 1, 1, 1, 1)
        columnSet.SetColumnWidth(0, 81)
        columnSet.SetColumnWidth(1, 77)

        columnSet = table.ColumnSets.Add()
        columnSet.Add(columnTelef, 0, 0, 1, 1)
        columnSet.Add(columnMovil, 1, 0, 1, 1)
        columnSet.Add(columnEmail, 0, 1, 1, 1)
        columnSet.Add(columnConsentimiento, 1, 1, 1, 1)
        columnSet.SetColumnWidth(0, 78)
        columnSet.SetColumnWidth(1, 80)

        columnSet = table.ColumnSets.Add()
        columnSet.Add(columnFechaSocio, 0, 0, 2, 2)
        columnSet.SetColumnWidth(0, 78)

        table.SortKeys.Add(columnCPaciente, SortOrder.Descending)

        GridEX1.RootTable = table
    End Sub

    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        PopulateGrid()
    End Sub

#Region "Public Sub AplicarFormato()"
    Public Sub AplicarFormato()

        If Not GridEX1.RootTable.Columns("SOCIO") Is Nothing Then
            Dim fc1 As GridEXFormatCondition = New GridEXFormatCondition( _
                        GridEX1.RootTable.Columns("SOCIO"), _
                        ConditionOperator.Equal, "S")

            fc1.FormatStyle.ForeColor = Color.Purple
            GridEX1.RootTable.FormatConditions.Add(fc1)
        End If

        If Not GridEX1.RootTable.Columns("BENEFICIARIOCODIGOSOCIO") Is Nothing Then
            Dim fc2 As GridEXFormatCondition = New GridEXFormatCondition( _
                        GridEX1.RootTable.Columns("BENEFICIARIOCODIGOSOCIO"), _
                        ConditionOperator.GreaterThan, 0)

            fc2.FormatStyle.ForeColor = Color.Blue
            GridEX1.RootTable.FormatConditions.Add(fc2)
        End If

        If Not GridEX1.RootTable.Columns("DEFUNCION") Is Nothing Then
            Dim fc3 As GridEXFormatCondition = New GridEXFormatCondition( _
                        GridEX1.RootTable.Columns("DEFUNCION"), _
                        ConditionOperator.Equal, "S")

            fc3.FormatStyle.BackColor = Color.LightGray
            GridEX1.RootTable.FormatConditions.Add(fc3)
        End If

        'Dim fc4 As New GridEXFormatCondition(GridEX1.RootTable.Columns("TieneDocumentoConsentimiento"), ConditionOperator.Equal, False)
        'fc4.TargetColumn = GridEX1.RootTable.Columns("Column1")
        'fc4.FormatStyle.BackColor = Color.Red
        'GridEX1.RootTable.FormatConditions.Add(fc4)
    End Sub
#End Region

#Region "Public Sub Filtrar2()"

    Protected Overrides Sub PopulateGrid()

        If Not Me.IsHandleCreated Then
            Return
        End If

        Dim condition As New List(Of String)

        'Dim condition As New GridEXFilterCondition()
        'condition.LogicalOperator = LogicalOperator.And


        If Not grpFiltrarPorCodigo.Enabled Then

            If txtCodigoPropio.Text.Length > 0 Then condition.Add(" PACIENTES.CODIGOPROPIO LIKE '" & txtCodigoPropio.Text & "%'")

            If txtNombre.Text.Length > 0 Then condition.Add(" PACIENTES.NOMBRE LIKE '" & txtNombre.Text & "%'")

            If txtApellido1.Text.Length > 0 Then condition.Add(" PACIENTES.APELLIDO1 LIKE '" & txtApellido1.Text & "%'")

            If txtApellido2.Text.Length > 0 Then condition.Add(" PACIENTES.APELLIDO2 LIKE '" & txtApellido2.Text & "%'")

            If txtDni.Text.Length > 0 Then condition.Add("PACIENTES.DNI LIKE '" & txtDni.Text & "%'")

        Else
            If CtrlPacienteDesde.ID_PACIENTE.HasValue Then
                condition.Add("PACIENTES.CPACIENTE >=" & CtrlPacienteDesde.ID_PACIENTE)
            End If
            If CtrlPacienteHasta.ID_PACIENTE.HasValue Then
                condition.Add("PACIENTES.CPACIENTE <=" & CtrlPacienteHasta.ID_PACIENTE)
            End If
        End If

        If txtDireccion.Text.Length > 0 Then
            condition.Add(" PACIENTES.DOMICILIO LIKE '%" & txtDireccion.Text & "%'")
        End If

        If txtTelefono.Text.Length > 0 Then
            condition.Add(" PACIENTES.TLFNO LIKE '" & txtTelefono.Text & "%'")
        End If

        If txtMovil.Text.Length > 0 Then
            condition.Add(" PACIENTES.MOVIL LIKE '" & txtMovil.Text & "%'")
        End If



        If Not CtrlFormaPago21.ID_FORMASPAGO Is Nothing Then
            condition.Add("PACIENTES.REFFORMAPAGO ='" & CtrlFormaPago21.ID_FORMASPAGO & "'")
        End If

        If CtrlEmpresa1.ID_EMPRESAS.HasValue Then
            condition.Add("PACIENTES.REFEMPRESA =" & CtrlEmpresa1.ID_EMPRESAS.Value)
        End If

        If CtrlMutua1.ID_Mutuas.HasValue Then
            condition.Add("PACIENTES.REFMUTUA=" & CtrlMutua1.ID_Mutuas.Value)
        End If

        If CtrlPaises1.ID_PAISES.HasValue Then
            condition.Add("PACIENTES.REFPAIS=" & CtrlPaises1.ID_PAISES.Value)
        End If

        If chb_ingreso.Checked Then
            condition.Add("PACIENTES.FECHAALTA >='" & dtp_fi.Value.ToShortDateString() & "' AND PACIENTES.FECHAALTA<='" & dtp_ff.Value.ToShortDateString() & "'")
            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FECHAALTA"), _
            '                                                ConditionOperator.Between, dtp_fi.Value, dtp_ff.Value))

        End If

        If chb_nac.Checked Then
            condition.Add("PACIENTES.FECHAN >='" & dtp_fin.Value.ToShortDateString() & "' AND PACIENTES.FECHAN<='" & dtp_ffn.Value.ToShortDateString() & "'")
            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FECHAN"), _
            '                                              ConditionOperator.Between, dtp_fin.Value, dtp_ffn.Value))

        End If

        If chb_baja.Checked Then
            condition.Add("PACIENTES.FECHABAJA >='" & dtp_fib.Value.ToShortDateString() & "' AND PACIENTES.FECHABAJA<='" & dtp_ffb.Value.ToShortDateString() & "'")
            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("FECHABAJA"), _
            '                                               ConditionOperator.Between, dtp_fib.Value, dtp_ffb.Value))

        End If

        If chb_asoc.Checked Then
            If rb_asocsi.Checked Then
                condition.Add("PACIENTES.SOCIO='S'")

                If (Me.chkSocioActivo.CheckState = CheckState.Checked) Then
                    condition.Add("PACIENTES.SOCIOVALIDOHASTA>=" & "'" & Now.ToShortDateString() & "'")
                ElseIf Me.chkSocioActivo.CheckState = CheckState.Unchecked Then
                    condition.Add("PACIENTES.SOCIOVALIDOHASTA<" & "'" & Now.ToShortDateString() & "'")
                End If


                'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("SOCIO"), ConditionOperator.Equal, "S"))

            Else
                condition.Add("PACIENTES.SOCIO='N'")
                'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("SOCIO"), ConditionOperator.Equal, "N"))
            End If
        End If

        If chb_activo.Checked Then
            If rb_activosi.Checked Then
                condition.Add("PACIENTES.ACTIVO='S'")
                'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ACTIVO"), ConditionOperator.Equal, "S"))
            Else
                condition.Add("PACIENTES.ACTIVO='N'")
                'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("ACTIVO"), ConditionOperator.Equal, "N"))
            End If
        End If

        If chb_fallecidos.Checked Then
            If rb_fallecsi.Checked Then
                condition.Add("PACIENTES.DEFUNCION='S'")
                'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("DEFUNCION"), ConditionOperator.Equal, "S"))
            Else
                condition.Add("PACIENTES.DEFUNCION='N' OR PACIENTES.DEFUNCION IS NULL")
                'Dim fc As GridEXFilterCondition
                'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("DEFUNCION"), ConditionOperator.Equal, "N"))
                'condition.AddCondition(LogicalOperator.Or, New GridEXFilterCondition(GridEX1.RootTable.Columns("DEFUNCION"), ConditionOperator.IsNull, "N"))
            End If
        End If

        If rb_crec.Checked Then
            condition.Add("PACIENTES.PAGOBANCO='S'")
            'condition.AddCondition(LogicalOperator.And, New GridEXFilterCondition(GridEX1.RootTable.Columns("PAGOBANCO"), ConditionOperator.Equal, "S"))

        End If

        If rb_srec.Checked Then
            condition.Add("PACIENTES.PAGOBANCO='N'")
            'condition.AddCondition(New GridEXFilterCondition(GridEX1.RootTable.Columns("PAGOBANCO"), ConditionOperator.Equal, "N"))

        End If

        If chkFiltroCumple.Checked Then
            If rbCumple_Hoy.Checked Then
                condition.Add("datepart(d, PACIENTES.FECHAN) = datepart(d, getdate()) and datepart(m, PACIENTES.FECHAN) = datepart(m, getdate())")
            End If

            If rbCumple_Dias.Checked Then
                Dim dias As Integer = tb_CantDias.Value
                Dim con As String = "(1 = (FLOOR(DATEDIFF(dd,PACIENTES.FECHAN,GETDATE()+@DIAS) / 365.25)) - (FLOOR(DATEDIFF(dd,PACIENTES.FECHAN,GETDATE()-1) / 365.25)))".Replace("@DIAS", dias.ToString())
                condition.Add(con)
            End If
        End If

        If rbConEMail.Checked = True Then
            condition.Add("(not email is null and email<>'')")
        End If
        If rbSinEmail.Checked = True Then
            condition.Add("(email is null or email='')")
        End If
        'If rbTodosEMail.Checked = True Then
        '    condition.Add("email is null or email like '%'")
        'End If

        Try


            Dim query As String = My.Resources.queryListadoPacientes
            Dim c As New CMLinqDataContext

            If txtTop100.Checked Then
                query = My.Resources.queryListadoPacientesTop100
            End If



            If condition.Count > 0 Then

                query = query.Insert(query.IndexOf("GROUP"), _
                             " WHERE " & String.Join(" AND ", condition.ToArray()) & " ")


            End If
            If query.Contains("WHERE") Then
                query = query.Insert(query.IndexOf("WHERE") + 5, _
                             " (PACIENTES.Eliminado is NULL or PACIENTES.Eliminado = 0) AND ")
            Else
                query = query.Insert(query.IndexOf("GROUP"), _
                             " WHERE (PACIENTES.Eliminado is NULL or PACIENTES.Eliminado = 0) ")
            End If

            query += " ORDER BY PACIENTES.CPACIENTE DESC "


            Dim dt As DataTable = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(My.Settings.CMConnectionString, CommandType.Text, query).Tables(0)

            Dim listapacientes As New List(Of PACIENTE)
            Dim contextemp As New CMLinqDataContext

            For Each row As DataRow In dt.AsEnumerable
                listapacientes.Add((From o In contextemp.PACIENTEs Where o.CPACIENTE = row.Field(Of Integer)("CPACIENTE") Select o).SingleOrDefault)
            Next

            'GridEX1.DataSource = dt
            If Not ListadoPacientesBindingSource.DataSource Is Nothing Then ListadoPacientesBindingSource.DataSource = Nothing
            ListadoPacientesBindingSource.DataSource = listapacientes 'dt

            Dim a As Integer = GridEX1.RowCount
            Dim i As Integer

            For i = 0 To GridEX1.RowCount - 1

                If GridEX1.GetRow(i).DataRow.cpaciente = seleccion Then
                    GridEX1.MoveTo(i)

                End If

            Next


            tsTotalPacientes.Text = GridEX1.RowCount
            Dim total As Object = dt.Compute("SUM(IMPORTE)", Nothing)
            If Not total Is DBNull.Value Then
                tsImporte.Text = CType(total, Double).ToString("C2")
            Else
                tsImporte.Text = 0
            End If

            'Globales.Context.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, Globales.Context.PACIENTEs)
            'CType(Me.Parent, FormConfigurable).GridEx1 = Me.GridEX1

            dt.Dispose()
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Ocurrio un error al intentar listar los pacientes")
        End Try

    End Sub

#End Region

    Private Sub chb_ingreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_ingreso.CheckedChanged
        dtp_fi.Enabled = chb_ingreso.Checked
        dtp_ff.Enabled = chb_ingreso.Checked
    End Sub

    Private Sub chb_nac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_nac.CheckedChanged
        dtp_fin.Enabled = chb_nac.Checked
        dtp_ffn.Enabled = chb_nac.Checked
    End Sub

    Private Sub chb_baja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_baja.CheckedChanged
        dtp_fib.Enabled = chb_baja.Checked
        dtp_ffb.Enabled = chb_baja.Checked
    End Sub

    Private Sub chb_asoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_asoc.CheckedChanged
        rb_asocsi.Enabled = chb_asoc.Checked
        rb_asocno.Enabled = chb_asoc.Checked
    End Sub

    Private Sub chb_activo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_activo.CheckedChanged
        rb_activosi.Enabled = chb_activo.Checked
        rb_activono.Enabled = chb_activo.Checked
    End Sub

    Private Sub chb_fallecidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_fallecidos.CheckedChanged
        rb_fallecsi.Enabled = chb_fallecidos.Checked
        rb_fallecno.Enabled = chb_fallecidos.Checked
    End Sub

    Private Sub PreparaImpresion()

        lista.Clear()
        Dim contex As New CMLinqDataContext()
        Dim count As Integer = 1
        Try


            For Each row As GridEXRow In GridEX1.GetDataRows
                If row.IsVisible Then
                    Dim id As Integer = row.DataRow.cpaciente
                    Dim paciente As PACIENTE = (From p In contex.PACIENTEs Where p.CPACIENTE = id Select p).SingleOrDefault
                    paciente.IMPORTE = row.DataRow.IMPORTE

                    lista.Add(New WRAPPER_PACIENTE(paciente))
                    GridEX1.BeginInvoke(New BeginInvokeDelegate2(AddressOf Progreso), New Object() {"Procesando... " & count & "/" & GridEX1.RowCount})
                    count = count + 1
                End If
            Next
        Catch ex As Exception

        End Try
        GridEX1.BeginInvoke(New BeginInvokeDelegate(AddressOf Imprimir))
    End Sub

    Public Sub SetEnabled(ByVal enabled As Boolean)
        For Each control As Control In Me.Controls
            control.Enabled = enabled
        Next
        pnl_Loading.Enabled = Not enabled
        lnkCancelar.Enabled = Not enabled
    End Sub

    Delegate Sub BeginInvokeDelegate()
    Delegate Sub BeginInvokeDelegate2(ByVal msg As String)
    Delegate Sub BeginInvokeDelegate3(ByVal enabled As Boolean)

    Private Sub Progreso(ByVal msg As String)
        lbl_Loading.Text = msg
    End Sub

    Private Sub Imprimir()


        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        ds.Name = "CM2DataSet_ListadoPacientes"
        ds.Value = lista

        SetEnabled(True)
        pnl_Loading.Visible = False
        lbl_Loading.Text = "Preparando..."

        UI.Reportes.ReportesManager.Imprime("PacientesListado.rdlc", {ds})

    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnl_Loading.Visible = True
        lbl_Loading.Text = "Procesando..."
        SetEnabled(False)
        threadPrint = New Threading.Thread(ts)
        threadPrint.Start()
    End Sub

    Private Sub bt_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnVerPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim Id As Integer = ListadoPacientesDataGridView.SelectedRows(0).DataBoundItem.Row.CPACIENTE
        If GridEX1.SelectedItems.Count > 0 Then
            Dim Id As Integer = GridEX1.SelectedItems(0).GetRow().DataRow.cpaciente
            Dim frm As formPaciente = New formPaciente("Ficha de pacientes -Ver", Enums.Accion.Ver, Id)
            frm.ShowInTaskbar = False
            frm.ShowDialog()
        End If

    End Sub

    Private Sub btnEditarPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click

        If GridEX1.SelectedItems.Count > 0 Then
            If tst_Editar.Visible Then
                Dim Id As Integer = GridEX1.SelectedItems(0).GetRow().DataRow.cpaciente
                Dim frm As formPaciente = New formPaciente("Ficha de pacientes -Modificar", Enums.Accion.Modificar, Id)
                seleccion = Id

                Dim paciente As PACIENTE = (From p In Globales.Context.PACIENTEs Where p.CPACIENTE = Id _
                                            Select p).SingleOrDefault()

                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Abrir, RoleManager.Items.Pacientes, "PACIENTE", Id, "Nombre: " & paciente.NombreCompleto())

                frm.ShowInTaskbar = False
                frm.ShowDialog()
                PopulateGrid()
            Else
                MessageBox.Show("Usted no tiene permisos para editar pacientes")
                Return
            End If
        End If


    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged, txtApellido2.TextChanged, txtApellido1.TextChanged, txtCodigoPropio.TextChanged, txtTelefono.TextChanged, txtDireccion.TextChanged, txtMovil.TextChanged, txtDni.TextChanged

        If txtNombre.Text = String.Empty And _
            txtCodigoPropio.Text = String.Empty And _
            txtDni.Text = String.Empty And _
            txtApellido1.Text = String.Empty And _
            txtApellido2.Text = String.Empty Then

            grpFiltrarPorCodigo.Enabled = True
        Else
            grpFiltrarPorCodigo.Enabled = False

        End If
    End Sub

    Private Sub GridEX1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick

        If Modo = Globales.ModoParaFormas.Edicion Then
            btnEditarPaciente_Click(Nothing, Nothing)
        Else
            If GridEX1.SelectedItems.Count > 0 Then
                Dim Id As Integer = GridEX1.SelectedItems(0).GetRow().DataRow.cpaciente
                Paciente = (From p In Globales.Context.PACIENTEs Where p.CPACIENTE = Id Select p).SingleOrDefault()
                seleccion = Id
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = GridEX1.SelectedItems.Count > 0
        tst_Eliminar.Enabled = GridEX1.SelectedItems.Count > 0
        If GridEX1.SelectedItems.Count > 0 And seleccion = 0 Then
            seleccion = GridEX1.SelectedItems(0).GetRow().DataRow.cpaciente
        End If
    End Sub

    Private Sub lnkCancelar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCancelar.LinkClicked
        Try
            threadPrint.Abort()
        Catch ex As Exception

        Finally
            GridEX1.BeginInvoke(New BeginInvokeDelegate3(AddressOf SetEnabled), New Object() {True})
            GridEX1.BeginInvoke(New BeginInvokeDelegate(AddressOf GridEX1.Update))
            'SetEnabled(True)
            pnl_Loading.Visible = False
        End Try
    End Sub

    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click
        pnl_Loading.Visible = True
        lbl_Loading.Text = "Procesando..."
        SetEnabled(False)
        threadPrint = New Threading.Thread(ts)
        threadPrint.Start()
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstNuevo.Click

        Dim frm As New formPaciente("Nuevo Paciente", centro_medico.Enums.Accion.Insertar)
        If frm.ShowDialog() = DialogResult.OK Then
            'Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.In, RoleManager.Items.Comunicaciones, "EMAIL", com.ID_Comunicacion.ToString(), "De: " & com.NombreUsuarioEmisor & " a " & com.NombrePacienteDestino & " Contenido: " & com.Contenido)

        End If
        PopulateGrid()
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Dim context As New CMLinqDataContext()
        If GridEX1.GetCheckedRows().Count > 0 Then
            If MessageBox.Show("Esta seguro que desea eliminar este/estos elemento(s)?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                For Each row As GridEXRow In GridEX1.GetCheckedRows()
                    Dim paciente As PACIENTE
                    Try
                        Dim Id As Integer = row.DataRow.cpaciente

                        paciente = (From p In context.PACIENTEs Where p.CPACIENTE = Id _
                                                   Select p).SingleOrDefault()

                        paciente.Eliminado = True

                        context.SubmitChanges()
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes, "PACIENTE", Id, "Nombre:  " & paciente.NombreCompleto)

                    Catch ex As Exception
                        MessageBox.Show("No pudo eliminarser el paciente (" & paciente.CPACIENTE & ") " & paciente.NOMBRE & " " & paciente.APELLIDO1 & " por tener información relacionada en vigencia")
                    End Try
                Next

            End If
            PopulateGrid()
        End If


    End Sub

    Private Sub tstMsgSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstMsgSelected.Click

        If GridEX1.GetCheckedRows().Count = 0 Then
            MessageBox.Show("Ningun paciente seleccionado")
            Return
        End If
        Dim frm As New frmComunicaciones_ADD()
        'frm.listDestinos.Items.AddRange(listacorreos.ToArray())

        'Dim listacorreos As New List(Of ListViewItem)

        'For Each row As GridEXRow In GridEX1.GetCheckedRows()
        '    If Not row.DataRow("EMAIL") Is Nothing Then
        '        If row.DataRow("EMAIL").ToString().Trim().Length > 0 Then
        '            Dim nombre As String = """" & row.DataRow("NOMBRE") & " " & row.DataRow("APELLIDO1") & """"
        '            Dim correo As String = row.DataRow("EMAIL")
        '            Dim item As New ListViewItem(nombre & " <" & correo & ">")
        '            Dim idpaciente As Integer = Integer.Parse(row.DataRow("CPACIENTE"))

        '            Dim paciente As PACIENTE = (From p In Globales.Context.PACIENTEs _
        '                                       Where p.CPACIENTE = idpaciente).SingleOrDefault()
        '            item.Tag = paciente
        '            listacorreos.Add(item)
        '        End If
        '    End If

        '    If Not row.DataRow("EMAIL") Is Nothing Then
        '        If row.DataRow("EMAIL").ToString().Trim().Length > 0 Then
        '            Dim nombre As String = """" & row.DataRow("NOMBRE") & " " & row.DataRow("APELLIDO1") & """"
        '            Dim correo As String = row.DataRow("EMAIL")
        '            Dim item As New ListViewItem(nombre & " <" & correo & ">")
        '            Dim idpaciente As Integer = Integer.Parse(row.DataRow("CPACIENTE"))

        '            Dim paciente As PACIENTE = (From p In Globales.Context.PACIENTEs _
        '                                       Where p.CPACIENTE = idpaciente).SingleOrDefault()
        '            item.Tag = paciente
        '            listacorreos.Add(item)
        '        End If
        '    End If
        'Next
        frm.Destinatarios.Clear()
        For Each row As GridEXRow In GridEX1.GetCheckedRows()
            Dim idpaciente As Integer = Integer.Parse(row.DataRow.cpaciente)

            Dim paciente As PACIENTE = (From p In Globales.Context.PACIENTEs _
                                             Where p.CPACIENTE = idpaciente).SingleOrDefault()

            frm.Destinatarios.Add(paciente)
            'If Not row.DataRow("EMAIL") Is Nothing Then
            '    If row.DataRow("EMAIL").ToString().Trim().Length > 0 Then
            '        Dim nombre As String = """" & row.DataRow("NOMBRE") & " " & row.DataRow("APELLIDO1") & """"
            '        Dim correo As String = row.DataRow("EMAIL")
            '        Dim item As New ListViewItem(nombre & " <" & correo & ">")
            '        item.Tag = paciente
            '        listacorreos.Add(item)
            '    End If
            'End If

            'If Not row.DataRow("EMAIL") Is Nothing Then
            '    If row.DataRow("EMAIL").ToString().Trim().Length > 0 Then
            '        Dim nombre As String = """" & row.DataRow("NOMBRE") & " " & row.DataRow("APELLIDO1") & """"
            '        Dim correo As String = row.DataRow("EMAIL")
            '        Dim item As New ListViewItem(nombre & " <" & correo & ">")
            '        Dim idpaciente As Integer = Integer.Parse(row.DataRow("CPACIENTE"))

            '        Dim paciente As PACIENTE = (From p In Globales.Context.PACIENTEs _
            '                                   Where p.CPACIENTE = idpaciente).SingleOrDefault()
            '        item.Tag = paciente
            '        listacorreos.Add(item)
            '    End If
            'End If
        Next


        frm.ShowDialog()
    End Sub

    Private Sub tstMsgAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstMsgAll.Click

        Dim pacientes As List(Of PACIENTE) = (From p In Globales.Context.PACIENTEs Select p).ToList()

        Dim frm As New frmComunicaciones_ADD()
        frm.Destinatarios.AddRange(pacientes)

        frm.ShowDialog()

    End Sub

    Private Sub btnConfigGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigGrid.Click
        ' CType(Me.Parent, FormConfigurable).GridEX1 = Me.GridEX1
        MyBase.GridEX1 = Me.GridEX1
        Configure()
    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each cExt As GridEXColumn In GridEX1.RootTable.Columns
            OriginalColumns.Add(cExt)
        Next
    End Sub

    Private Sub chkFiltroCumple_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFiltroCumple.CheckedChanged
        rbCumple_Hoy.Enabled = chkFiltroCumple.Checked
        rbCumple_Dias.Enabled = chkFiltroCumple.Checked
        tb_CantDias.Enabled = chkFiltroCumple.Checked
    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub
End Class

Partial Public Class Paciente
    Private _IMPORTE As Double = 0
    Public Property IMPORTE
        Get
            Return _IMPORTE
        End Get
        Set(ByVal value)
            _IMPORTE = value
        End Set
    End Property
End Class