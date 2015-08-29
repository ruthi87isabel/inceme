Imports Microsoft.Reporting.WinForms
Imports centro_medico.UI.Reportes

Namespace UI.Recetas

    Public Class frmRecetas_Editar

        Public Receta As RECETA
        Public Context As CMLinqDataContext


        Public Sub New(_receta As RECETA, _context As CMLinqDataContext)
           
            InitializeComponent()
            Me.Receta = _receta
            Me.Context = _context
            Me.chkFechaDispensacion.Checked = Receta.TieneFechaDispensacion
            TieneRecetaAsociada()
        End Sub
        Private Sub TieneRecetaAsociada()
            Dim n As Integer = Receta.RecetasXML.Count
            If n = 1 Then
                Me.btAsociarReceta.Enabled = False
                Me.lblCVE.Text = Receta.RecetasXML(0).CVE
                PictureBox1.Image = Me.Receta.CodigoBarras
            Else
                Me.btAsociarReceta.Enabled = True
                Me.lblCVE.Text = "No hay receta del colegio asociada"
            End If
        End Sub
        Private Sub AsociarReceta()
            Dim rec As New recetaXML
            If Not Me.CtrlMedicoReceta.ID_Medico Is Nothing Then
                'If rec.recetaDisponible(Me.CtrlMedicoReceta.ID_Medico, Me.Receta.IDRECETA) Then TieneRecetaAsociada()
                If rec.recetaDisponible(Receta, Context, CtrlMedicoReceta.ID_Medico) Then
                    TieneRecetaAsociada()
                End If
            End If
        End Sub
        Private Sub FrmRecetasLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            
            RECETABindingSource.DataSource = Receta

            If Not Receta.TRATAMIENTO Is Nothing Then
                Me.editTratamiento.Text = Receta.TRATAMIENTO
            End If

          

            If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Recetas) <= RoleManager.TipoPermisos.Lectura Then
                Me.CtrlMedicoReceta.Enabled = False
                Me.CtrlMedicamentoReceta.Enabled = False
                Me.CtrlPacienteReceta.Enabled = False
                Me.CtrlDiagnosticosReceta.Enabled = False
                Me.btDelMedicamento.Visible = False
                Me.btAddMedicamento.Visible = False
                Me.DateTimeFecha.Enabled = False
                Me.DateTimeHora.Enabled = False
                Me.BtnMutua.Visible = False
                Me.bt_medicamento.Visible = False
                Me.editTratamiento.ReadOnly = True
                Me.bt_aceptar.Visible = False
            End If

            If Globales.Usuario.REFMEDICO.HasValue Then
                CtrlMedicoReceta.ID_Medico = Globales.Usuario.REFMEDICO
                If Not Globales.Usuario.EsAdministrador() Then
                    'Si es medico pero no es admin se le bloquea el filtro de medicos
                    CtrlMedicoReceta.Enabled = False
                End If
            End If

            If Receta.EsRecetaOficial.HasValue Then
                If Receta.EsRecetaOficial Then
                    rbOficiales.Checked = True
                Else
                    rbRegfulares.Checked = True
                End If
            Else
                rbOficiales.Checked = True
            End If

            FillRecetaOficial()

        End Sub

        Private Sub bt_aceptar_Click(sender As Object, e As EventArgs) Handles bt_aceptar.Click
            If Guardar() Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub


        Private Function Guardar() As Boolean
            If EsValido() Then
                Me.RECETABindingSource.EndEdit()
                Receta.EsRecetaOficial = rbOficiales.Checked
                Receta.TRATAMIENTO = editTratamiento.Text
                Receta.FECHA = DateTimeFecha.Value
                Receta.HORA = DateTimeHora.Value
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Function EsValido() As Boolean
            If CtrlPacienteReceta.ID_PACIENTE Is Nothing Then
                MessageBox.Show("Debe insertar un paciente")
                Return False
            End If
            If CtrlMedicoReceta.ID_Medico Is Nothing Then
                MessageBox.Show("Debe insertar un médico")
                Return False
            End If
            'If CtrlDiagnosticosReceta.ID_DIAGNOSTICOS Is Nothing Then
            '    MessageBox.Show("Debe insertar un dignóstico")
            '    Return False
            'End If
            If Not CtrlMedicamentoReceta.ID_Medicamento.HasValue Then
                MessageBox.Show("Debe insertar un medicamento pricinpal")
                Return False
            End If
            Return True
        End Function

        Private Sub CargaListaMedicamentos()
            GridExMedicamentos.DataSource = Nothing
            Dim context As New CMLinqDataContext()

            Dim _medicamentos = (From m In context.RecetasMedicamentos Where m.IdReceta = Me.Receta.IDRECETA Select m).ToList()
            Me.RecetasMedicamentosBindingSource.DataSource = _medicamentos

            GridExMedicamentos.DataSource = RecetasMedicamentosBindingSource

        End Sub

        Private Sub btAddMedicamento_Click(sender As Object, e As EventArgs) Handles btAddMedicamento.Click
            Dim t As Integer = 12
            Dim frm As New frmMedicamentos()

            If frm.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                Return
            End If

            Dim context As New CMLinqDataContext()

            Dim _recetaMedicamento As New RecetasMedicamento()

            _recetaMedicamento.IdReceta = Me.Receta.IDRECETA
            _recetaMedicamento.REFMEDICAMENTO = frm.idMedicamentos

            context.RecetasMedicamentos.InsertOnSubmit(_recetaMedicamento)
            context.SubmitChanges()
            CargaListaMedicamentos()
            If _recetaMedicamento.MEDICAMENTO Is Nothing Or _recetaMedicamento.MEDICAMENTO.DESCRIPCION Is Nothing Then
                Return
            End If
            editTratamiento.Text = editTratamiento.Text + vbCrLf + _recetaMedicamento.MEDICAMENTO.DESCRIPCION
        End Sub

        Private Sub btDelMedicamento_Click(sender As Object, e As EventArgs) Handles btDelMedicamento.Click
            If GridExMedicamentos.SelectedItems.Count < 1 Then
                Return
            End If
            Dim _rect As RecetasMedicamento = GridExMedicamentos.SelectedItems(0).GetRow.DataRow
            Dim context As New CMLinqDataContext()

            Dim idMedicamento As RecetasMedicamento = (From r In context.RecetasMedicamentos Where r.IdLineaReceta = _rect.IdLineaReceta Select r).First()

            context.RecetasMedicamentos.DeleteOnSubmit(idMedicamento)
            context.SubmitChanges()
            CargaListaMedicamentos()
        End Sub

        Private Sub bt_AplicarPlantilla_Click(sender As Object, e As EventArgs) Handles bt_AplicarPlantilla.Click
            Dim frm As New frmPlantillasdeTexto(Globales.ModoParaFormas.Seleccion)
            frm.ShowInTaskbar = False

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                editTratamiento.Text = editTratamiento.Text + Globales.TextFromRtf(frm.Plantilla.TEXTO)
                Return
            End If
        End Sub

        Private Function TodosMedicamentos() As String
            Dim cadena As String = ""
            If CtrlMedicamentoReceta.ID_Medicamento.HasValue Then
                cadena = cadena + CtrlMedicamentoReceta.Medicamento.DESCRIPCION + vbCrLf
            End If
            Try
                Dim m
                For Each m In GridExMedicamentos.GetRows
                    Dim tmp As RecetasMedicamento = m.DataRow
                    cadena = cadena + tmp.MEDICAMENTO.DESCRIPCION
                Next
            Catch
            End Try
            Return cadena
        End Function

        Private Sub bt_imprimir_Click(sender As Object, e As EventArgs) Handles bt_imprimir.Click
            If Not Guardar() Then
                Exit Sub
            End If

            Dim paciente As PACIENTE = Me.CtrlPacienteReceta.Paciente

            'Dim frm As New frmRecetas_Imprimir(paciente)
            'frm.ShowInTaskbar = False
            'frm.ShowIcon = False

            'If frm.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then
            '    Return
            'End If


            Dim tmp As RECETA = Receta


            Dim rep As New Microsoft.Reporting.WinForms.ReportDataSource
            Dim dsPaciente As New Microsoft.Reporting.WinForms.ReportDataSource
            Dim dsMedico As New Microsoft.Reporting.WinForms.ReportDataSource
            Dim dsRecetasXML As New Microsoft.Reporting.WinForms.ReportDataSource

            dsPaciente.Name = "dsPaciente"
            rep.Name = "CMDataSet_rpt_Recetas"
            dsMedico.Name = "dsMedico"
            dsRecetasXML.Name = "dsRecetasXML"

            Dim pacientes As New List(Of WRAPPER_PACIENTE)

            Dim recetas As New List(Of WRAPPER_RECETA)
            recetas.Add(New WRAPPER_RECETA(tmp, Not ChkUsarPrescriptorInfo.Checked))
            rep.Value = recetas

            Dim medicos As New List(Of MEDICO)
            medicos.Add(Me.CtrlMedicoReceta.Medico)
            dsMedico.Value = medicos


            'Dim rpt_parameters As Microsoft.Reporting.WinForms.ReportParameterInfoCollection = _print.ReportViewer.LocalReport.GetParameters

            Dim rayParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
            'parametros NombreEmpresa y Mutua

            'If Not rpt_parameters.Item("param_nomMutua") Is Nothing Then
            If rbRegfulares.Checked Then
                If Not tmp.PACIENTE.MUTUA Is Nothing Then
                    If Not tmp.PACIENTE.MUTUA.NOMBRE Is Nothing Then
                        Dim res As MsgBoxResult = MsgBox("¿Desea mostrar el nombre de la mutua?.", MsgBoxStyle.YesNo)
                        If res = MsgBoxResult.Yes Then rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_nomMutua", tmp.PACIENTE.MUTUA.NOMBRE))
                    End If
                End If

                'End If

                'If Not rpt_parameters.Item("param_nomEmpresa") Is Nothing Then
                If Not tmp.PACIENTE.EMPRESA Is Nothing Then
                    If Not tmp.PACIENTE.EMPRESA.NOMBRE Is Nothing Then
                        Dim res As MsgBoxResult = MsgBox("¿Desea mostrar el nombre de la empresa?.", MsgBoxStyle.YesNo)
                        If res = MsgBoxResult.Yes Then rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("param_nomEmpresa", tmp.PACIENTE.EMPRESA.NOMBRE))
                    End If
                End If
                ' End If
            End If
            pacientes.Add(New WRAPPER_PACIENTE(paciente))
            dsPaciente.Value = pacientes

            Dim lista As New List(Of RecetasXML)
            lista.Add(Receta.RecetasXML.FirstOrDefault)

            dsRecetasXML.Value = lista

            Dim medico As MEDICO = Me.CtrlMedicoReceta.Medico

            If Not medico Is Nothing Then
                If Not medico.FIRMA Is Nothing Then

                    'If Not _print.ReportViewer.LocalReport.GetParameters("FirmaMedicoPath") Is Nothing Then
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
                    rayParam.Add(paramLogo)
                End If

                'End If
            End If



            If rbRegfulares.Checked Then
                UI.Reportes.ReportesManager.Imprime("Receta.rdlc", {rep, dsPaciente, dsMedico}, rayParam.ToArray)
            Else
                If lista.Count = 1 AndAlso Not lista(0) Is Nothing Then
                    Dim codigoProvincia As String = lista(0).provincia.Trim.ToString

                    rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathLogo3", Globales.RecetaImagenes.LogoClinica))

                    Dim strPathFondo As String = Receta.MEDICO.FondoReceta
                    Dim strPathLogo2 As String = Receta.MEDICO.Logo2Receta
                    Dim strPathLogoColegio As String = Receta.MEDICO.LogoColegioReceta

                    If strPathFondo Is Nothing OrElse strPathFondo.Trim.Length = 0 Then
                        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathImgFondo", Globales.RecetaImagenes.RecetaGeneralFondo))
                    Else
                        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathImgFondo", Globales.RecetaImagenes.pathImagenesRecetasXml & "\" & strPathFondo))
                    End If

                    If strPathLogo2 Is Nothing OrElse strPathLogo2.Trim.Length = 0 Then
                        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathLogo2", Globales.RecetaImagenes.ColegioMedicoAlicante))
                    Else
                        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathLogo2", Globales.RecetaImagenes.pathImagenesRecetasXml & "\" & strPathLogo2))
                    End If

                    If strPathLogoColegio Is Nothing OrElse strPathLogoColegio.Trim.Length = 0 Then
                        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathLogoColegio", Globales.RecetaImagenes.ConsejoMedicos))
                    Else
                        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathLogoColegio", Globales.RecetaImagenes.pathImagenesRecetasXml & "\" & strPathLogoColegio))
                    End If

                    'Select Case codigoProvincia
                    '    Case "03"
                    '        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathImgFondo", Globales.RecetaImagenes.RecetaValencianoFondo))
                    '        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathLogoColegio", Globales.RecetaImagenes.ConsejoMedicos))
                    '        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathLogo2", Globales.RecetaImagenes.ColegioMedicoAlicante))
                    '    Case Else
                    '        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathImgFondo", Globales.RecetaImagenes.RecetaGeneralFondo))
                    '        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathLogoColegio", Globales.RecetaImagenes.ConsejoMedicos))
                    '        rayParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("pathLogo2", Globales.RecetaImagenes.ColegioMedicoAlicante))
                    'End Select


                    UI.Reportes.ReportesManager.Imprime("RecetaOficialImpresa.rdlc", {rep, dsPaciente, dsMedico, dsRecetasXML}, rayParam.ToArray)
                Else
                    UI.Reportes.ReportesManager.Imprime("RecetaOficial.rdlc", {rep, dsPaciente, dsMedico}, rayParam.ToArray)
                End If

            End If
        End Sub

        Private Sub BtnMutua_Click(sender As Object, e As EventArgs) Handles BtnMutua.Click

            If CtrlPacienteReceta.ID_PACIENTE.HasValue Then
                Try
                    If Me.Receta.PACIENTE.REFMUTUA.HasValue Then
                        editTratamiento.Text = editTratamiento.Text + vbCrLf + Me.Receta.PACIENTE.MUTUA.NOMBRE
                    End If
                    If Me.Receta.PACIENTE.REFEMPRESA.HasValue Then
                        editTratamiento.Text = editTratamiento.Text + vbCrLf + Me.Receta.PACIENTE.EMPRESA.NOMBRE
                    End If

                Catch ex As Exception
                End Try
            End If
        End Sub

        Private Sub bt_medicamento_Click(sender As Object, e As EventArgs) Handles bt_medicamento.Click
            editTratamiento.Text = editTratamiento.Text + TodosMedicamentos()
        End Sub

        Private Sub CtrlMedicamentoReceta_MEDICAMENTOSeleccionado(IdMedicamento As Integer, oldMedicamento As Nullable(Of Integer), IsReturnPressed As Boolean) Handles CtrlMedicamentoReceta.MEDICAMENTOSeleccionado
            If CtrlMedicamentoReceta.ID_Medicamento Is Nothing Then
                Return
            End If
            If CtrlMedicamentoReceta.Medicamento Is Nothing Or CtrlMedicamentoReceta.Medicamento.DESCRIPCION Is Nothing Then
                Return
            End If
            editTratamiento.Text = editTratamiento.Text + vbCrLf + CtrlMedicamentoReceta.Medicamento.DESCRIPCION

            FillMedicamento()

        End Sub

    

        Private Sub bt_factura_Click(sender As Object, e As EventArgs) Handles bt_factura.Click

        End Sub

        Private Sub rbRegfulares_CheckedChanged(sender As Object, e As EventArgs) Handles rbRegfulares.CheckedChanged
            If rbRegfulares.Checked Then
                pnlRegulares.Visible = True
                pnlOficiales.Visible = False
            Else
                pnlRegulares.Visible = False
                pnlOficiales.Visible = True
            End If
           
        End Sub

        
        Private Sub FillRecetaOficial()
            'pnlRegulares.Visible = False
            'pnlOficiales.Visible = True

            If String.IsNullOrEmpty(Receta.Prescriptor) Then
                If CtrlMedicoReceta.ID_Medico.HasValue() Then
                    FillPrescriptor()
                End If

            End If

            If String.IsNullOrEmpty(Receta.PacienteInfo) Then
                If CtrlPacienteReceta.ID_PACIENTE.HasValue Then
                    FillPaciente()
                End If
            End If

            If String.IsNullOrEmpty(Receta.DiagnosticoAlPaciente) Then
                If CtrlDiagnosticosReceta.ID_DIAGNOSTICOS.HasValue Then
                    FillDiagnostico()
                End If
            End If

            If String.IsNullOrEmpty(Receta.Prescripcion) Then
                If CtrlMedicamentoReceta.ID_Medicamento.HasValue Then
                    FillMedicamento()
                End If
            End If
        End Sub

        Private Sub rbOficiales_Click(sender As Object, e As EventArgs) Handles rbOficiales.Click
            FillRecetaOficial()
        End Sub

        Private Sub FillPrescriptor()

            Dim medico As MEDICO = CtrlMedicoReceta.Medico

            Receta.Prescriptor = String.Format("Dr/Dra {0} " & vbCrLf & _
                                                "Núm. Colegiado / Núm. Collegiat: {1}" & vbCrLf & _
                                                "{2}" & vbCrLf & _
                                                "{3}" & vbCrLf & _
                                                "{4} {5}", _
                                                medico.NOMBRECOMPLETO, _
                                                medico.COLEGIADO, _
                                                medico.ESPECIALIDAD, _
                                                medico.DOMICILIO & " " & medico.LOCALIDAD, _
                                                medico.CP, _
                                                medico.PROVINCIA)
        End Sub

        Private Sub FillPaciente()
            Dim paciente As PACIENTE = Context.PACIENTEs.FirstOrDefault(Function(o) o.CPACIENTE = CtrlPacienteReceta.ID_PACIENTE)

            Receta.PacienteInfo = String.Format("{0} " & vbCrLf & _
                                               "Año Nacimiento: {1}" & vbCrLf & _
                                               "DNI/NIE/Pasaporte : {2}", _
                                               paciente.NombreCompleto, _
                                               paciente.FECHAN.Value.Year, _
                                               GetPacienteID(paciente))
        End Sub


        Private Sub FillDiagnostico()
            Dim diag As DIAGNOSTICO = CtrlDiagnosticosReceta.Diagnostico
            Receta.DiagnosticoAlPaciente = diag.DIAGNOSTICO
        End Sub
        Private Sub FillMedicamento()
            Dim medicamento As MEDICAMENTO = CtrlMedicamentoReceta.Medicamento
            Receta.Prescripcion = medicamento.DESCRIPCION
            Receta.Posologia = medicamento.POSOLOGIA
        End Sub

        Function GetPacienteID(ByRef Paciente As PACIENTE) As String
            Dim identificadores As New List(Of String)

            If Not String.IsNullOrEmpty(Paciente.DNI) Then
                identificadores.Add(Paciente.DniConLetra)
            End If

            If Not String.IsNullOrEmpty(Paciente.NIE) Then
                identificadores.Add(Paciente.NIE)
            End If
            If Not String.IsNullOrEmpty(Paciente.PASAPORTE) Then
                identificadores.Add(Paciente.PASAPORTE)
            End If
            If identificadores.Count = 0 Then
                Return String.Empty
            Else
                Return String.Join(" / ", identificadores.ToArray())
            End If
        End Function

        Private Sub CtrlPacienteReceta_PacienteSeleccionadoByBrowser(IdPaciente As Integer) Handles CtrlPacienteReceta.PacienteSeleccionadoByBrowser
            FillPaciente()
        End Sub

        Private Sub CtrlPacienteReceta_PacienteNoEncontrado() Handles CtrlPacienteReceta.PacienteNoEncontrado
            Receta.PacienteInfo = String.Empty
        End Sub

        Private Sub CtrlPacienteReceta_PacienteEliminado(IdPaciente As Integer) Handles CtrlPacienteReceta.PacienteEliminado
            Receta.PacienteInfo = String.Empty
        End Sub

        Private Sub CtrlMedicoReceta_MEDICOSeleccionado(IdMedico As Integer, oldMedico As System.Nullable(Of Integer), IsReturnPressed As Boolean) Handles CtrlMedicoReceta.MEDICOSeleccionado
            FillPrescriptor()
        End Sub

        Private Sub CtrlMedicoReceta_MedicoNoEncontrado() Handles CtrlMedicoReceta.MedicoNoEncontrado
            Receta.Prescriptor = String.Empty
        End Sub

        Private Sub CtrlMedicoReceta_MEDICOEliminado(IdMedicoAnterior As System.Nullable(Of Integer)) Handles CtrlMedicoReceta.MEDICOEliminado
            Receta.Prescriptor = String.Empty
        End Sub

        Private Sub CtrlDiagnosticosReceta_DIAGNOSTICOSSeleccionado(IdDIAGNOSTICOS As Integer) Handles CtrlDiagnosticosReceta.DIAGNOSTICOSSeleccionado
            FillDiagnostico()
        End Sub

        Private Sub ChkUsarPrescriptorInfo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUsarPrescriptorInfo.CheckedChanged
            PrescriptorTextBox.ReadOnly = ChkUsarPrescriptorInfo.Checked
        End Sub
   
  
    
        Private Sub btAsociarReceta_Click(sender As Object, e As EventArgs) Handles btAsociarReceta.Click
            Me.AsociarReceta()
        End Sub

    
        
    
        Private Sub chkFechaDispensacion_CheckedChanged(sender As Object, e As EventArgs) Handles chkFechaDispensacion.CheckedChanged
            If Not Me.RECETABindingSource.Current Is Nothing Then
                If chkFechaDispensacion.Checked Then
                    Me.RECETABindingSource.Current.FechaPrevistaDispensacion = Now
                Else
                    Me.RECETABindingSource.Current.FechaPrevistaDispensacion = Nothing
                End If
            End If
        End Sub
    End Class


End Namespace