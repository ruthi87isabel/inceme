Imports Microsoft.Reporting.WinForms

Public Class frmPartes_ADD


    Public ID_Parte As Integer = -1
    Public ID_Proceso As Nullable(Of Long) = Nothing
    Public ID_Paciente As Integer = -1
    Public ID_Empresa As Integer = -1
    Public Mutua As CMDataSet.MUTUASRow

    'Para el parte de Alta
    Public ID_ParteOrigen As Nullable(Of Long) = Nothing
    Public ParteOrigen As CM3DataSet.N_PartesRow


    Public Parte As CM3DataSet.N_PartesRow


    Private Sub frmPartes_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.EMPRESAS' table. You can move, or remove it, as needed.
        Me.EMPRESASTableAdapter.Fill(Me.CMDataSet.EMPRESAS)

        'Combos comunes
        E_TipoComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Tipos))
        E_RegimenComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Regimen))
        E_CaracterComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Caracter))
        E_SituacionComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Situacion))

        If ID_Parte <> -1 Then
            'Cargar el parte

            N_PartesTableAdapter.FillBy(Me.CM3DataSet.N_Partes, ID_Parte)
            Parte = Me.CM3DataSet.N_Partes(0)
            CtrlPaciente21.ID_PACIENTE = Parte.ID_Paciente
            E_TipoComboBox.SelectedItem = CType(Parte.E_Tipo, Globales.Partes_Tipos)
            E_RegimenComboBox.SelectedItem = CType(Parte.E_Regimen, Globales.Partes_Regimen)
            E_CaracterComboBox.SelectedItem = CType(Parte.E_Caracter, Globales.Partes_Caracter)
            E_SituacionComboBox.SelectedItem = CType(Parte.E_Situacion, Globales.Partes_Situacion)

            If Parte.E_Tipo = Globales.Partes_Tipos.Baja Then
                E_Causa_de_bajaComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Causa_de_Baja))
                E_Causa_de_bajaComboBox.SelectedItem = CType(Parte.E_Causa_de_baja, Globales.Partes_Causa_de_Baja)

            Else
                Alta_E_Causa_de_AltaComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Causa_de_Alta))
                Alta_E_Causa_de_AltaComboBox.SelectedItem = CType(Parte.Alta_E_Causa_de_Alta, Globales.Partes_Causa_de_Alta)
            End If

            If Not Parte.IsEntidad_Pago_IT_CPNull Then
                rb_INSS.Checked = Parte.Entidad_Pago_IT_CP
                rb_ISM.Checked = Not rb_INSS.Checked
            Else
                rb_INSS.Checked = True
            End If


            chk_Recaida.Checked = Parte.Recaida
            If Not Parte.IsID_PacienteNull Then
                ID_Paciente = Parte.ID_Paciente
            End If

            If Not Parte.IsID_EmpresaNull Then
                ID_Empresa = Parte.ID_Empresa
            End If

            If Parte.IsID_ProcesoNull() = False Then
                lblCitaProcesoInfo.Text = "Parte vinculado a un proceso."
                btnVerProceso.Enabled = True
            End If
            
        Else
            'Nuevo
            Parte = N_PartesBindingSource.AddNew().Row()
            If ID_Proceso.HasValue Then
                Parte.ID_Proceso = ID_Proceso
            Else
                'btnBuscaPaciente.Visible = True
                CtrlPaciente21.Enabled = True
            End If
            CtrlPaciente21.ID_PACIENTE = ID_Paciente

            Parte.Recaida = False
            Parte.Entidad_Pago_IT_CP = 1
            rb_INSS.Checked = True

            If ID_ParteOrigen.HasValue Then
                'Parte de Alta
                Parte.FechaAlta = Date.Now
                Alta_E_Causa_de_AltaComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Causa_de_Alta))
                Parte.E_Tipo = Globales.Partes_Tipos.Alta
            Else
                Parte.FechaBaja = Date.Now
                E_Causa_de_bajaComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Causa_de_Baja))
                Parte.E_Tipo = Globales.Partes_Tipos.Baja
            End If

            Me.CM3DataSet.N_Partes.AddN_PartesRow(Parte)
        End If


        If Parte.E_Tipo = Globales.Partes_Tipos.Alta Then
            'Significa que proviene de un parte de Baja, es un parte de Alta
            groupBaja.Visible = False
            groupAlta.Visible = True
            groupAlta.Top = groupBaja.Top
            Me.Text = "Nuevo Parte Alta"

            'Copiar los datos basicos, el paciente y la empresa

            If ID_Parte = -1 Then
                CopiarDatosDesdeParteBaja()
            End If

            If ID_Paciente <> -1 Then
                Parte.ID_Paciente = ID_Paciente
                CtrlPaciente21.ID_PACIENTE = ID_Paciente
                CtrlPaciente21.Enabled = False
                'btnBuscaPaciente.Enabled = False
            End If


            btnDardeAlta.Visible = False
            Parte.E_Tipo = Globales.Partes_Tipos.Alta
            E_TipoComboBox.SelectedItem = CType(Parte.E_Tipo, Globales.Partes_Tipos)
        Else

            If ID_Parte = -1 Then
                'Parte de Baja
                If ID_Paciente <> -1 Then
                    ObtenDatosPaciente()
                    Parte.ID_Paciente = ID_Paciente
                    CtrlPaciente21.ID_PACIENTE = ID_Paciente
                    CtrlPaciente21.Enabled = False
                    'btnBuscaPaciente.Enabled = False
                End If


                If ID_Empresa <> -1 Then
                    ObtenDatosEmpresa()
                    Parte.ID_Empresa = ID_Empresa
                End If
            End If
            Parte.E_Tipo = Globales.Partes_Tipos.Baja
        End If


        If Mutua Is Nothing Then
            If CtrlPaciente21.ID_PACIENTE.HasValue Then
                If CtrlPaciente21.Paciente.REFMUTUA.HasValue Then
                    Dim adapter As New CMDataSetTableAdapters.MUTUASTableAdapter
                    Dim mutuasTable As CMDataSet.MUTUASDataTable = adapter.GetMutuaById(CtrlPaciente21.Paciente.REFMUTUA)
                    If mutuasTable.Count > 0 Then
                        Mutua = mutuasTable(0)
                    End If
                    'Mutua = 
                End If
            End If
        End If

    End Sub

#Region "Private Sub ObtenDatosEmpresa()"
    Private Sub ObtenDatosEmpresa()
        Dim ctrl As New ctrlEmpresa()
        ctrl.ID_EMPRESAS = ID_Empresa

        If Not ctrl.EMPRESA Is Nothing Then
            NombreEmpresaTextBox.Text = ctrl.NombreCompleto
            Parte.NombreEmpresa = ctrl.NombreCompleto
            If Not ctrl.EMPRESA.IsACTIVIDADNull Then
                Actividad_empresaTextBox.Text = ctrl.EMPRESA.ACTIVIDAD
                Parte.Actividad_empresa = ctrl.EMPRESA.ACTIVIDAD
            End If

            If Not ctrl.EMPRESA.IsCNAENull Then
                Código_Nacional_Actividad_Económica_CNAETextBox.Text = ctrl.EMPRESA.CNAE
                Parte.Código_Nacional_Actividad_Económica_CNAE = ctrl.EMPRESA.CNAE
            End If

            If Not ctrl.EMPRESA.IsENTIDADNull Then
                'Entidad_Pago_IT_CPTextBox.Text = ctrl.EMPRESA.ENTIDAD
                'Parte.Entidad_Pago_IT_CP = ctrl.EMPRESA.ENTIDAD
            End If

            If Not ctrl.EMPRESA.IsCPNull Then
                Codigo_Postal_EmpresaTextBox.Text = ctrl.EMPRESA.CP
                Parte.Codigo_Postal_Empresa = ctrl.EMPRESA.CP
            End If


            If Not ctrl.EMPRESA.IsPROVINCIANull Then
                ProvinciaEmpresaTextBox.Text = ctrl.EMPRESA.PROVINCIA
                Parte.ProvinciaEmpresa = ctrl.EMPRESA.PROVINCIA
            End If

            If Not ctrl.EMPRESA.IsPOBLACIONNull Then
                LocalidadEmpresaTextBox.Text = ctrl.EMPRESA.POBLACION
                Parte.LocalidadEmpresa = ctrl.EMPRESA.POBLACION
            End If

            If Not ctrl.EMPRESA.IsDIRECCIONNull Then
                DomicilioEmpresaTextBox.Text = ctrl.EMPRESA.DIRECCION
                Parte.DomicilioEmpresa = ctrl.EMPRESA.DIRECCION
            End If
        End If




    End Sub
#End Region

#Region "Private Sub ObtenDatosPaciente()"
    Private Sub ObtenDatosPaciente()
        'Dim adapter As New CMDataSetTableAdapters.PACIENTESTableAdapter()
        'Dim table As New CMDataSet.PACIENTESDataTable()
        'adapter.FillPacienteById(table, ID_Paciente)


        'If table.Count > 0 Then
        ObtenDatosPaciente(CtrlPaciente21.Paciente)
        'End If
    End Sub

    Public Sub ObtenDatosPaciente(ByVal Paciente As PACIENTE)


        'NombreCompletoPacienteTextBox.Text = nombre
        Parte.NombreCompletoPaciente = Paciente.NombreCompleto

        If Not Paciente.PUESTO Is Nothing Then
            Puesto_de_trabajoPacienteTextBox.Text = Paciente.PUESTO
            Parte.Puesto_de_trabajoPaciente = Paciente.PUESTO

        End If

        If Not Paciente.TLFNO Is Nothing Then
            TelefonoPacienteTextBox.Text = Paciente.TLFNO
            Parte.TelefonoPaciente = Paciente.TLFNO
        End If

        If Not Paciente.CP Is Nothing Then
            Codigo_PostalPacienteTextBox.Text = Paciente.CP
            Parte.Codigo_PostalPaciente = Paciente.CP
        End If

        If Not Paciente.TARJETASANITARIA Is Nothing Then
            Num_Tarjeta_sanitariaTextBox.Text = Paciente.TARJETASANITARIA
            Parte.Num_Tarjeta_sanitaria = Paciente.TARJETASANITARIA
        End If

        'If Not Paciente.IsENTIDADNull Then
        '    rb_INSS.Checked = Pac
        '    Entidad_Pago_IT_CPTextBox.Text = Paciente.ENTIDAD
        '    Parte.Entidad_Pago_IT_CP = Paciente.ENTIDAD
        'End If

        If Not Paciente.NSS Is Nothing Then
            Num_Afiliacion_Seg_SocialTextBox.Text = Paciente.NSS
            Parte.Num_Afiliacion_Seg_Social = Paciente.NSS
        End If

        If Not Paciente.DOMICILIO Is Nothing Then
            DomicilioPacienteTextBox.Text = Paciente.DOMICILIO
            Parte.DomicilioPaciente = Paciente.DOMICILIO
        End If

        If Not Paciente.LOCALIDAD Is Nothing Then
            LocalidadPacienteTextBox.Text = Paciente.LOCALIDAD
            Parte.LocalidadPaciente = Paciente.LOCALIDAD
        End If

        If Not Paciente.PROVINCIA Is Nothing Then
            ProvinciaPacienteTextBox.Text = Paciente.PROVINCIA
            Parte.ProvinciaPaciente = Paciente.PROVINCIA
        End If


        If Mutua Is Nothing Then
            If Paciente.REFMUTUA.HasValue Then
                Dim adapter As New CMDataSetTableAdapters.MUTUASTableAdapter
                Dim mutuasTable As CMDataSet.MUTUASDataTable = adapter.GetMutuaById(Paciente.REFMUTUA)
                If mutuasTable.Count > 0 Then
                    Mutua = mutuasTable(0)
                End If
                'Mutua = 
            End If
        End If
    End Sub
#End Region

#Region "Private Sub CopiarDatosDesdeParteBaja()"
    Private Sub CopiarDatosDesdeParteBaja()

        If Not ParteOrigen.IsID_PacienteNull Then
            Parte.ID_Paciente = ParteOrigen.ID_Paciente
        End If

        If Not ParteOrigen.IsID_EmpresaNull Then
            Parte.ID_Empresa = ParteOrigen.ID_Empresa
        End If

        If Not ParteOrigen.IsNombreCompletoPacienteNull Then
            Parte.NombreCompletoPaciente = ParteOrigen.NombreCompletoPaciente
        End If

        If Not ParteOrigen.IsPuesto_de_trabajoPacienteNull Then
            Parte.Puesto_de_trabajoPaciente = ParteOrigen.Puesto_de_trabajoPaciente
        End If

        If Not ParteOrigen.IsTelefonoPacienteNull Then
            Parte.TelefonoPaciente = ParteOrigen.TelefonoPaciente
        End If

        If Not ParteOrigen.IsCodigo_PostalPacienteNull Then
            Parte.Codigo_PostalPaciente = ParteOrigen.Codigo_PostalPaciente
        End If

        If Not ParteOrigen.IsNum_Tarjeta_sanitariaNull Then
            Parte.Num_Tarjeta_sanitaria = ParteOrigen.Num_Tarjeta_sanitaria
        End If

        If Not ParteOrigen.IsEntidad_Pago_IT_CPNull Then
            Parte.Entidad_Pago_IT_CP = ParteOrigen.Entidad_Pago_IT_CP
            rb_ISM.Checked = Not rb_INSS.Checked
        End If

        If Not ParteOrigen.IsNum_Afiliacion_Seg_SocialNull Then
            Parte.Num_Afiliacion_Seg_Social = ParteOrigen.Num_Afiliacion_Seg_Social
        End If

        If Not ParteOrigen.IsDomicilioPacienteNull Then
            Parte.DomicilioPaciente = ParteOrigen.DomicilioPaciente
        End If

        If Not ParteOrigen.IsLocalidadPacienteNull Then
            Parte.LocalidadPaciente = ParteOrigen.LocalidadPaciente
        End If

        If Not ParteOrigen.IsProvinciaPacienteNull Then
            Parte.ProvinciaPaciente = ParteOrigen.ProvinciaPaciente
        End If

        'Datos de la empresa
        If Not ParteOrigen.IsNombreEmpresaNull Then
            Parte.NombreEmpresa = ParteOrigen.NombreEmpresa
        End If

        If Not ParteOrigen.IsActividad_empresaNull Then
            Parte.Actividad_empresa = ParteOrigen.Actividad_empresa
        End If

        If Not ParteOrigen.IsCódigo_Nacional_Actividad_Económica_CNAENull Then
            Parte.Código_Nacional_Actividad_Económica_CNAE = ParteOrigen.Código_Nacional_Actividad_Económica_CNAE
        End If

        If Not ParteOrigen.IsCodigo_Postal_EmpresaNull Then
            Parte.Codigo_Postal_Empresa = ParteOrigen.Codigo_Postal_Empresa
        End If


        If Not ParteOrigen.IsProvinciaEmpresaNull Then
            Parte.ProvinciaEmpresa = ParteOrigen.ProvinciaEmpresa
        End If

        If Not ParteOrigen.IsLocalidadEmpresaNull Then
            Parte.LocalidadEmpresa = ParteOrigen.LocalidadEmpresa
        End If

        If Not ParteOrigen.IsDomicilioEmpresaNull Then
            Parte.DomicilioEmpresa = ParteOrigen.DomicilioEmpresa
        End If

    End Sub
#End Region



    Private Sub ts_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_Guardar.Click
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

#Region "Private Function Guardar() As Boolean"
    Private Function Guardar() As Boolean
        Try


            If ID_Paciente = -1 Then
                MessageBox.Show("Debe seleccionar un paciente")
                Return False
            End If

            Parte.E_Tipo = E_TipoComboBox.SelectedItem
            Parte.E_Regimen = E_RegimenComboBox.SelectedItem
            Parte.E_Caracter = E_CaracterComboBox.SelectedItem
            Parte.E_Situacion = E_SituacionComboBox.SelectedItem
            If ID_ParteOrigen.HasValue Then
                Parte.ID_ParteOrigen = ID_ParteOrigen
            End If

            Parte.ID_Paciente = CtrlPaciente21.ID_PACIENTE

            If Parte.E_Tipo = Globales.Partes_Tipos.Baja Then
                Parte.E_Causa_de_baja = E_Causa_de_bajaComboBox.SelectedItem
            Else
                Parte.Alta_E_Causa_de_Alta = Alta_E_Causa_de_AltaComboBox.SelectedItem
            End If

            If Not Duracion_estandar_fecha_inicioDateTimePicker.Checked Then
                Parte.SetDuracion_estandar_fecha_inicioNull()
            End If

            If Not Duracion_estandar_fecha_finalDateTimePicker.Checked Then
                Parte.SetDuracion_estandar_fecha_finalNull()
            End If

            If CtrlDiagnosticos1.ID_DIAGNOSTICOS.HasValue Then
                Parte.Descripcion_Diagnostico = CtrlDiagnosticos1.NombreCompleto
            End If

            Parte.Recaida = chk_Recaida.Checked

            'Me.Validate()
            Me.N_PartesBindingSource.EndEdit()

            If Parte.IsID_ProcesoNull() Then
                'Verificacion del Proceso

                Dim context As New CMLinqDataContext
                Dim procesos As List(Of N_Proceso) = (From p In context.N_Procesos
                                                     Where p.ID_Paciente = Parte.ID_Paciente And p.Finalizado = False
                                                     Select p).ToList()

                'Dim procesos As CM3DataSet.N_Procesos_ResumenDataTable = ProcesosDePaciente(CtrlPaciente1.ID_PACIENTE.Value)
                If procesos.Count > 0 Then
                    If MessageBox.Show("Este paciente tiene proceso(s) abierto(s). ¿Desea vincular este parte algun proceso?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Dim frm As New frmProcesos_Seleccionar()
                        frm.ID_Paciente = Parte.ID_Paciente
                        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            If Not frm.SelectedProceso() Is Nothing Then
                                Parte.ID_Proceso = frm.SelectedProceso().ID_Proceso
                                lblCitaProcesoInfo.Text = "Parte vinculado a un proceso. Guardar para hacerlo permanente"
                            Else
                                'Desmarco todo, significa eliminar el parte del proceso
                                Parte.SetID_ProcesoNull()
                            End If
                        End If
                    Else
                        Parte.SetID_ProcesoNull()
                    End If
                End If
            End If


            Me.CM3DataSet.EnforceConstraints = False
            Dim n As Integer = Me.N_PartesTableAdapter.Update(Me.CM3DataSet.N_Partes)
            Me.CM3DataSet.EnforceConstraints = True

            ID_Parte = Parte.ID_Parte
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Return True
    End Function
#End Region

    Private Sub btn_HistorialProcesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HistorialProcesos.Click

        If Parte.IsID_PacienteNull() Then
            MessageBox.Show("Debe seleccionar un paciente")
            Return
        End If
        Dim frm As New frmProcesos_Seleccionar()
        If Not Parte.IsID_ProcesoNull() Then
            frm.IDProcesoPreseleccionado = Parte.ID_Proceso
        End If

        frm.ID_Paciente = Parte.ID_Paciente
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Not frm.SelectedProceso() Is Nothing Then
                Parte.ID_Proceso = frm.SelectedProceso().ID_Proceso
                lblCitaProcesoInfo.Text = "Parte vinculado a un proceso. Debe Guardar para hacer permanente este cambio"
            Else
                'Desmarco todo, significa eliminar cita de proceso
                Parte.SetID_ProcesoNull()
            End If
        End If
        btnVerProceso.Enabled = Parte.IsID_ProcesoNull()
    End Sub


    Private Sub btnVerProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerProceso.Click
        Dim frm As New frmProcesos_ADD()
        frm.ID_Proceso = Parte.ID_Proceso
        frm.ShowDialog()
    End Sub



#Region "Private Sub btnBuscaPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPaciente.Click"
    Private Sub btnBuscaPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Buscar datos de paciente

        Dim frm As New frmPacientesListado
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ID_Paciente = frm.Paciente.CPACIENTE
            Parte.ID_Paciente = ID_Paciente
            'ObtenDatosPaciente(frm.Paciente)
        End If
    End Sub
#End Region


    Private Sub btn_BuscarEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarEmpresa.Click

        Dim _listados As form_listados = New form_listados("Listado de Empresas", EMPRESASBindingSource, RoleManager.Items.Empresas, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            ID_Empresa = Integer.Parse(_listados.Selected())
            ObtenDatosEmpresa()
        End If

    End Sub

    Private Sub btn_BuscarMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarMedico.Click
        Dim frm As form_medicos = New form_medicos()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Parte.ID_Medico = frm.MEDICO.CMEDICO
            Dim nombre As String = ""

            If Not frm.MEDICO.IsNOMBRENull() Then
                nombre = frm.MEDICO.NOMBRE
            End If

            If Not frm.MEDICO.IsAPELLIDO1Null() Then
                nombre = nombre & " " & frm.MEDICO.APELLIDO1
            End If

            If Not frm.MEDICO.IsAPELLIDO2Null() Then
                nombre = nombre & " " & frm.MEDICO.APELLIDO2
            End If

            NombreMedicoTextBox.Text = nombre

            If Not frm.MEDICO.IsCOLEGIADONull Then
                No_de_ColegiadoMedicoTextBox.Text = frm.MEDICO.COLEGIADO
            End If
        End If
    End Sub

    Private Sub btnDardeAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDardeAlta.Click

        If Guardar() Then
            Dim frm As New frmPartes_ADD()
            frm.ID_Paciente = ID_Paciente
            frm.ID_Empresa = ID_Empresa
            frm.ID_ParteOrigen = Me.ID_Parte
            frm.ParteOrigen = Parte

            If ID_Proceso.HasValue Then
                frm.ID_Proceso = ID_Proceso
            End If
            Me.Hide()
            frm.ShowDialog()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub




    Private Sub tlbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbImprimir.Click
        Try

       
        If Guardar() Then
            Dim parte_url As String = "ParteBajaAlta.rdlc" 'Parte por defecto

            Dim origen2 As Object

            Dim parameterList As New List(Of ReportParameter)

            Dim rdatasourcePartes As New Microsoft.Reporting.WinForms.ReportDataSource
            rdatasourcePartes.Name = "CM3DataSet_N_Partes"
            rdatasourcePartes.Value = CM3DataSet.N_Partes

            Dim parte As CM3DataSet.N_PartesRow = CM3DataSet.N_Partes(0)

                'rpGenerico = New form_ReporteGenerico(rdatasourcePartes, Globales.Configuracion.impresionfilesdirectory & "\" & parte_url, "Parte Alta / Baja")
                'rpGenerico.ReportViewer.LocalReport.DataSources.Add(rdatasourcePartes)

                'rpGenerico.ReportViewer.LocalReport.EnableExternalImages = True





         

            If Not Mutua Is Nothing Then
                If Not Mutua.IsPARTELSRNull Then
                    If System.IO.File.Exists(Globales.Configuracion.impresionfilesdirectory & "\" & Mutua.PARTELSR) Then
                        parte_url = Mutua.PARTELSR
                    Else
                        'MessageBox.Show("El fichero de reporte " & Mutua.PARTELSR & " asociado a la mutua '" & Mutua.NOMBRE & "' no puede ser encontrado en " & Globals.Configuracion.impresionfilesdirectory & "\. Se usara un reporte genérico")
                    End If
                End If

                    If Not Mutua.IsLogoNull Then


                        'If Not rpGenerico.ReportViewer.LocalReport.GetParameters("MutuaLogoPath") Is Nothing Then
                        Dim myImage As Byte() = Mutua.Logo.ToArray

                        Dim imgMemoryStream As New IO.MemoryStream(myImage)
                        Dim bitmap As Bitmap = New Bitmap(imgMemoryStream)


                        Dim paramLogo As ReportParameter = New ReportParameter()
                        paramLogo.Name = "MutuaLogoPath"
                        'paramLogo.Values.Add(@"file:///C:\Users\Mike\AppData\Local\Temp\Logo.png")
                        'Salvar la imagen en una direccion temporal

                        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\mutualogo.jpg"

                        bitmap.Save(filename)


                        paramLogo.Values.Add("file:///" & filename)
                        parameterList.Add(paramLogo)
                        'rpGenerico.ReportViewer.LocalReport.SetParameters(paramLogo)
                        'End If

                    End If
                End If
                If Not parte.IsID_MedicoNull Then
                    Dim medico As MEDICO = (From p In Globales.Context.MEDICOs
                                           Where p.CMEDICO = parte.ID_Medico
                                           Select p).SingleOrDefault()

                    If Not medico Is Nothing Then
                        If Not medico.FIRMA Is Nothing Then


                            'If Not rpGenerico.ReportViewer.LocalReport.GetParameters("FirmaMedicoPath") Is Nothing Then
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
                            parameterList.Add(paramLogo)
                            'rpGenerico.ReportViewer.LocalReport.SetParameters(paramLogo)
                            'End If

                        End If
                    End If
                End If

                UI.Reportes.ReportesManager.Imprime("ParteBajaAlta.rdlc", {rdatasourcePartes}, parameterList.ToArray)

            End If
        Catch ex As Exception
            Dim msg As String = ex.Message
            If Not ex.InnerException Is Nothing Then
                msg = msg & "." & ex.InnerException.Message
            End If
            MessageBox.Show(msg)
        End Try
    End Sub

    Private Sub CtrlPaciente21_PacienteSeleccionado(IdPaciente As System.Int32, IsReturnPressed As System.Boolean) Handles CtrlPaciente21.PacienteSeleccionado
       
    End Sub

    Private Sub CtrlPaciente21_PacienteEliminado(IdPaciente As System.Int32) Handles CtrlPaciente21.PacienteEliminado

    End Sub

    Private Sub CtrlPaciente21_PacienteNoEncontrado() Handles CtrlPaciente21.PacienteNoEncontrado

    End Sub

    Private Sub CtrlPaciente21_PacienteSeleccionadoByBrowser(IdPaciente As System.Int32) Handles CtrlPaciente21.PacienteSeleccionadoByBrowser
        ID_Paciente = IdPaciente
        Parte.ID_Paciente = IdPaciente
        ObtenDatosPaciente(CtrlPaciente21.Paciente)
    End Sub
End Class