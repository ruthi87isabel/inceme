Imports Microsoft.Reporting.WinForms

Public Class frmPartesAsistencia_ADD


    Public ID_Parte As Integer = -1
    Public ID_Proceso As Nullable(Of Long) = Nothing
    Public ID_Paciente As Integer = -1
    Public ID_Empresa As Integer = -1
    Public Mutua As CMDataSet.MUTUASRow = Nothing


    Public Parte As CM3DataSet.N_Partes_AsistenciaRow



    Private Sub frmPartes_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.EMPRESASTableAdapter.Fill(Me.CMDataSet.EMPRESAS)
        'Combos comunes

        E_RegimenComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Asistencia_Regimen))
        E_SituacionComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Asistencia_Situacion))
        E_TratamientoComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Asistencia_Tratamiento))
        E_PronosticoComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Asistencia_Pronostico))
        E_TipoComboBox.DataSource = [Enum].GetValues(GetType(Globales.Partes_Tipos))

        E_TipoComboBox.SelectedItem = CType(Globales.Partes_Tipos.Asistencia, Globales.Partes_Tipos)

        If ID_Parte <> -1 Then
            'Cargar el parte
            N_Partes_AsistenciaTableAdapter.FillBy(Me.CM3DataSet.N_Partes_Asistencia, ID_Parte)
            Parte = Me.CM3DataSet.N_Partes_Asistencia(0)

            E_RegimenComboBox.SelectedItem = CType(Parte.E_Regimen, Globales.Partes_Asistencia_Regimen)
            E_SituacionComboBox.SelectedItem = CType(Parte.E_Situacion, Globales.Partes_Asistencia_Situacion)
            E_TratamientoComboBox.SelectedItem = CType(Parte.E_Tratamiento, Globales.Partes_Asistencia_Tratamiento)
            E_PronosticoComboBox.SelectedItem = CType(Parte.E_Pronostico, Globales.Partes_Asistencia_Pronostico)

            If Not Parte.IsID_PacienteNull Then
                ID_Paciente = Parte.ID_Paciente
            End If

            If Not Parte.IsID_EmpresaNull Then
                ID_Empresa = Parte.ID_Empresa
            End If

            If Not Parte.IsID_MedicoNull() Then
                CtrlMedico1.ID_Medico = Parte.ID_Medico
            End If
            
            If Parte.IsID_ProcesoNull() = False Then
                lblCitaProcesoInfo.Text = "Parte vinculado a un proceso."
                btnVerProceso.Enabled = True
            End If


        Else
            'Nuevo
            Parte = N_Partes_AsistenciaBindingSource.AddNew().Row()
            If ID_Proceso.HasValue Then
                Parte.ID_Proceso = ID_Proceso
            Else
                btnBuscaPaciente.Visible = True
            End If


            Parte.Asistido_Previamente = False
            Parte.Era_el_lugar_de_trabajo_habitual = False
            Parte.CausaBaja = False
            Parte.Entidad_Pago_IT_CP = 1

            Parte.FechaAsistencia = Date.Now

            If ID_Paciente <> -1 Then
                ObtenDatosPaciente()
                Parte.ID_Paciente = ID_Paciente
                btnBuscaPaciente.Enabled = False
            End If
            Me.CM3DataSet.N_Partes_Asistencia.AddN_Partes_AsistenciaRow(Parte)

        End If

        If Not Parte.IsEntidad_Pago_IT_CPNull Then
            rb_INSS.Checked = Parte.Entidad_Pago_IT_CP
            rb_ISM.Checked = Not rb_INSS.Checked
        Else
            Parte.Entidad_Pago_IT_CP = 1
            rb_INSS.Checked = True
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

        Dim context As New CMLinqDataContext
        Dim paciente As PACIENTE = context.PACIENTEs.FirstOrDefault(Function(o) o.CPACIENTE = ID_Paciente)
        If Not paciente Is Nothing Then
            ObtenDatosPaciente(paciente)
        End If
    End Sub

    Private Sub ObtenDatosPaciente(ByVal paciente As PACIENTE)

        NombreCompletoPacienteTextBox.Text = paciente.NombreCompleto
        Parte.NombreCompletoPaciente = paciente.NombreCompleto

        If Not String.IsNullOrEmpty(paciente.PUESTO) Then
            Puesto_de_trabajoPacienteTextBox.Text = paciente.PUESTO
            Parte.Puesto_de_trabajoPaciente = paciente.PUESTO

        End If

        If Not String.IsNullOrEmpty(paciente.TLFNO) Then
            TelefonoPacienteTextBox.Text = paciente.TLFNO
            Parte.TelefonoPaciente = paciente.TLFNO
        End If

        If Not String.IsNullOrEmpty(paciente.CP) Then
            Codigo_PostalPacienteTextBox.Text = paciente.CP
            Parte.Codigo_PostalPaciente = paciente.CP
        End If

        If Not String.IsNullOrEmpty(paciente.TARJETASANITARIA) Then
            Num_Tarjeta_sanitariaTextBox.Text = paciente.TARJETASANITARIA
            Parte.Num_Tarjeta_sanitaria = paciente.TARJETASANITARIA
        End If

        'If Not Paciente.IsENTIDADNull Then
        '    Entidad_Pago_IT_CPTextBox.Text = Paciente.ENTIDAD
        '    Parte.Entidad_Pago_IT_CP = Paciente.ENTIDAD
        'End If

        If Not String.IsNullOrEmpty(paciente.NSS) Then
            Num_Afiliacion_Seg_SocialTextBox.Text = paciente.NSS
            Parte.Num_Afiliacion_Seg_Social = paciente.NSS
        End If

        If Not String.IsNullOrEmpty(paciente.DOMICILIO) Then
            DomicilioPacienteTextBox.Text = paciente.DOMICILIO
            Parte.DomicilioPaciente = paciente.DOMICILIO
        End If

        If Not String.IsNullOrEmpty(paciente.LOCALIDAD) Then
            LocalidadPacienteTextBox.Text = paciente.LOCALIDAD
            Parte.LocalidadPaciente = paciente.LOCALIDAD
        End If

        If Not String.IsNullOrEmpty(paciente.PROVINCIA) Then
            ProvinciaPacienteTextBox.Text = paciente.PROVINCIA
            Parte.ProvinciaPaciente = paciente.PROVINCIA
        End If
    End Sub
#End Region

#Region "Private Function Guardar() As Boolean"
    Private Function Guardar() As Boolean
        Try

            If ID_Paciente = -1 Then
                MessageBox.Show("Debe seleccionar un paciente")
                Return False
            End If


            Parte.CausaBaja = CausaBajaCheckBox.Checked
            Parte.Asistido_Previamente = Asistido_PreviamenteCheckBox.Checked
            Parte.Era_el_lugar_de_trabajo_habitual = Era_el_lugar_de_trabajo_habitualCheckBox.Checked
            Parte.Entidad_Pago_IT_CP = rb_INSS.Checked

            Parte.E_Regimen = E_RegimenComboBox.SelectedItem
            Parte.E_Tratamiento = E_TratamientoComboBox.SelectedItem
            Parte.E_Situacion = E_SituacionComboBox.SelectedItem
            Parte.E_Pronostico = E_PronosticoComboBox.SelectedItem

            If CtrlMedico1.ID_Medico.HasValue Then
                Parte.ID_Medico = CtrlMedico1.ID_Medico
                If Not CtrlMedico1.Medico.NOMBRE Is Nothing Then
                    Parte.NombreCompletoMedico = CtrlMedico1.Medico.NOMBRECOMPLETO
                    
                End If

                If Not CtrlMedico1.Medico.COLEGIADO Is Nothing Then
                    Parte.No_de_Colegiado = CtrlMedico1.Medico.COLEGIADO
                End If

            Else
                Parte.SetID_MedicoNull()
            End If

            'Parte.FechaAsistencia = FechaAsistenciaDateTimePicker.Value
            'Parte.Fecha_Asistencia_previa = Fecha_Asistencia_previaDateTimePicker.Value

            Me.Validate()
            Me.N_Partes_AsistenciaBindingSource.EndEdit()

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

            Dim n As Integer = Me.N_Partes_AsistenciaTableAdapter.Update(CM3DataSet.N_Partes_Asistencia)

            ID_Parte = Parte.ID_ParteAsistencia
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
    Private Sub btnBuscaPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPaciente.Click
        'Buscar datos de paciente

        Dim frm As New frmPacientesListado
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ID_Paciente = frm.Paciente.CPACIENTE
            Parte.ID_Paciente = ID_Paciente
            ObtenDatosPaciente(frm.Paciente)
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

    'Private Sub btn_BuscarMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As form_medicos = New form_medicos()
    '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        Parte.ID_Medico = frm.MEDICO.CMEDICO
    '        Dim nombre As String = ""

    '        If Not frm.MEDICO.IsNOMBRENull() Then
    '            nombre = frm.MEDICO.NOMBRE
    '        End If

    '        If Not frm.MEDICO.IsAPELLIDO1Null() Then
    '            nombre = nombre & " " & frm.MEDICO.APELLIDO1
    '        End If

    '        If Not frm.MEDICO.IsAPELLIDO2Null() Then
    '            nombre = nombre & " " & frm.MEDICO.APELLIDO2
    '        End If
    '        NombreMedicoTextBox.Text = nombre

    '        If Not frm.MEDICO.IsCOLEGIADONull Then
    '            No_de_ColegiadoMedicoTextBox.Text = frm.MEDICO.COLEGIADO
    '        End If
    '    End If
    'End Sub


    Private Sub N_Partes_AsistenciaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Partes_AsistenciaBindingNavigatorSaveItem.Click

        '    Me.Validate()
        '    Me.N_Partes_AsistenciaBindingSource.EndEdit()
        '    Me.N_Partes_AsistenciaTableAdapter.Update(Me.CM3DataSet.N_Partes_Asistencia)
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            'End Sub
        End If
    End Sub





    Private Sub Asistido_PreviamenteCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asistido_PreviamenteCheckBox.CheckedChanged
        Fecha_Asistencia_previaDateTimePicker.Enabled = Asistido_PreviamenteCheckBox.Checked
        'If Not Asistido_PreviamenteCheckBox.Checked Then
        '    Parte.SetFecha_Asistencia_previaNull()
        'End If
    End Sub

    Private Sub ts_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_Imprimir.Click

        If Guardar() Then

            Dim rdatasourcePartes As New Microsoft.Reporting.WinForms.ReportDataSource
            rdatasourcePartes.Name = "CM3DataSet_N_Partes_Asistencia"
            rdatasourcePartes.Value = CM3DataSet.N_Partes_Asistencia


            'Dim parte_url As String = "ParteAsistencia.rdlc" 'Parte por defecto

           
          
            Dim paramLogo As ReportParameter = New ReportParameter()

            If Not Parte.IsID_MedicoNull Then
                Dim medico As MEDICO = (From p In Globales.Context.MEDICOs
                                       Where p.CMEDICO = Parte.ID_Medico
                                       Select p).SingleOrDefault()

                If Not medico Is Nothing Then
                    If Not medico.FIRMA Is Nothing Then


                        'If Not rpGenerico.ReportViewer.LocalReport.GetParameters("FirmaMedicoPath") Is Nothing Then
                        Dim myImage As Byte() = medico.FIRMA.ToArray

                        Dim imgMemoryStream As New IO.MemoryStream(myImage)
                        Dim bitmap As Bitmap = New Bitmap(imgMemoryStream)



                        paramLogo.Name = "FirmaMedicoPath"
                        'paramLogo.Values.Add(@"file:///C:\Users\Mike\AppData\Local\Temp\Logo.png")
                        'Salvar la imagen en una direccion temporal

                        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\temp.jpg"

                        bitmap.Save(filename)


                        paramLogo.Values.Add("file:///" & filename)

                        'End If

                    End If
                End If
            End If

            If Not Mutua Is Nothing Then
                If Not Mutua.IsPARTELSRNull Then
                    If System.IO.File.Exists(Globales.Configuracion.impresionfilesdirectory & "\" & Mutua.PARTEMTR) Then
                        'parte_url = Mutua.PARTEMTR
                    Else
                        'MessageBox.Show("El fichero de reporte " & Mutua.PARTEMTR & " asociado a la mutua '" & Mutua.NOMBRE & "' no puede ser encontrado en " & Globals.Configuracion.impresionfilesdirectory & "\. Se usara un reporte genérico")
                    End If
                End If
            End If

            UI.Reportes.ReportesManager.Imprime("ParteAsistencia.rdlc", {rdatasourcePartes}, {paramLogo})

        End If
    End Sub

    
End Class