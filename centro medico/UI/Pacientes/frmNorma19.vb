Imports Microsoft.ApplicationBlocks.Data.SqlHelper

Public Class frmNorma19

    Dim context As New CMLinqDataContext()
    Dim recibos As RECIBO()
    Dim facturas As FACTURA()

    Private Sub frmNorma19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  
        recibos = (From r In context.RECIBOs _
                      Where r.PACIENTE.PAGOBANCO = "S" _
                      And r.TIPO = "P" _
                      Order By r.FECHAEMISION Descending _
                      Select r).ToArray()

        'And r.N19 = "N" _

        facturas = (From f In context.FACTURAs _
                     Where f.PACIENTE1.PAGOBANCO = "S" _
                     And f.FACTURAR = "P" _
                     Order By f.FECHA Descending _
                     Select f).ToArray()

        RECIBOSDataGridView.DataSource = recibos
        FACTURASDataGridView.DataSource = facturas

        Filtrar()
    End Sub

#Region "Private Sub Filtrar()"

    Private Sub Filtrar()
        FiltrarFacturas()
        FiltrarRecibos()
    End Sub

    Private Sub FiltrarRecibos()


        Dim recibosT As RECIBO() = recibos

        If rb_noemitidosN19.Checked Then
            'Me.RECIBOSTableAdapter.FillByNorma19(Me.CMDataSet.RECIBOS, "N")
            recibosT = recibos.Where(Function(recibo) recibo.N19 = "N").ToArray()
        End If

        If rb_emitidosN19.Checked Then
            'Me.RECIBOSTableAdapter.FillByNorma19(Me.CMDataSet.RECIBOS, "S")
            recibosT = recibos.Where(Function(recibo) recibo.N19 = "S").ToArray()
        End If

        If rb_todos.Checked Then
            'Me.RECIBOSTableAdapter.FillByPacientesConPagoBanco(Me.CMDataSet.RECIBOS).
            'recibosT = recibos.Where(Function(recibo) recibo.N19 = "N").ToArray()
        End If

        If dtp_fechainicial.Checked Then
            'filtros.Add("FECHAEMISION >='" & dtp_fechainicial.Value.Date.ToString & "'")
            recibosT = recibosT.Where(Function(recibo) recibo.FECHAEMISION >= dtp_fechainicial.Value.Date).ToArray()
        End If

        If dtp_fechafinal.Checked Then
            'filtros.Add("FECHAEMISION <'" & dtp_fechafinal.Value.Date.AddDays(1).ToString & "'")
            recibosT = recibosT.Where(Function(recibo) recibo.FECHAEMISION <= dtp_fechafinal.Value.AddDays(1).AddMinutes(-1)).ToArray()
        End If

        'Dim fil As String = String.Join(" AND ", filtros.ToArray())
        RECIBOSDataGridView.DataSource = recibosT

        Try

            Me.lblInfoRecibos.Text = Me.RECIBOSDataGridView.Rows.Count & " recibos cargados."
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al Filtrar")
        End Try

    End Sub

    Private Sub FiltrarFacturas()

        Dim facturasT As FACTURA() = facturas

        If rb_noemitidosN19.Checked Then
            'Me.RECIBOSTableAdapter.FillByNorma19(Me.CMDataSet.RECIBOS, "N")
            facturasT = facturas.Where(Function(factura) factura.N19 = "N" Or factura.N19 Is Nothing).ToArray()
        End If

        If rb_emitidosN19.Checked Then
            'Me.RECIBOSTableAdapter.FillByNorma19(Me.CMDataSet.RECIBOS, "S")
            facturasT = facturas.Where(Function(factura) factura.N19 = "S").ToArray()
        End If

        If rb_todos.Checked Then
            'Me.RECIBOSTableAdapter.FillByPacientesConPagoBanco(Me.CMDataSet.RECIBOS).
            'facturasT = facturas.Where(Function(factura) factura.N19 = "N" Or factura.N19 Is Nothing).ToArray()
        End If

        If dtp_fechainicial.Checked Then
            'filtros.Add("FECHAEMISION >='" & dtp_fechainicial.Value.Date.ToString & "'")
            facturasT = facturasT.Where(Function(factura) factura.FECHA >= dtp_fechainicial.Value).ToArray()
        End If

        If dtp_fechafinal.Checked Then
            'filtros.Add("FECHAEMISION <'" & dtp_fechafinal.Value.Date.AddDays(1).ToString & "'")
            facturasT = facturasT.Where(Function(factura) factura.FECHA <= dtp_fechafinal.Value).ToArray()
        End If

        'Dim fil As String = String.Join(" AND ", filtros.ToArray())
        FACTURASDataGridView.DataSource = facturasT

        Try

            Me.lblInfoFacturas.Text = Me.FACTURASDataGridView.Rows.Count & " facturas cargados."
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al Filtrar")
        End Try

    End Sub
#End Region


    Private Sub bt_generarN19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_generarN19.Click

        'Dim frm As New frmRecibos_Add()
        'frm.ID_Recibo = 1
        'frm.ShowDialog()
        'Me.RECIBOSTableAdapter.FillByNorma19(Me.CMDataSet.RECIBOS, "N")
        'Filtrar()
        Try

            If Not Globales.Configuracion.EsValidaConfiguracionFacturas_Recibos() Then
                'MessageBox.Show("Debe corregirse en Configuracion/Opciones/Sección Facturas y Recibos ")
                'TabControl1.SelectedTab = tab_recibosYfacturas
                If (Globales.Usuario.Permisos(RoleManager.Items.Configuracion) > RoleManager.TipoPermisos.Ninguno) Then
                    Dim f As New form_configuracion()
                    f.TabControl1.SelectedTab = f.tab_recibosYfacturas
                    f.ShowDialog()
                End If
                Return
            End If

            Dim doc As GoltraTools.DocumentoN19

            If TabControl1.SelectedTab.Equals(tabRecibos) Then
                'If RECIBOSDataGridView.SelectedRows.Count = 0 Then
                '    MessageBox.Show("No hay recibos seleccionados")
                '    Return
                'End If
                doc = GeneraN19PorRecibos()
            Else
                'If FACTURASDataGridView.SelectedRows.Count = 0 Then
                '    MessageBox.Show("No hay facturas seleccionadas")
                '    Return
                'End If
                doc = GeneraN19PorFacturas()
            End If

            If doc Is Nothing Then
                Return
            End If

            Dim dialog As New SaveFileDialog()
            dialog.DefaultExt = "txt"
            dialog.AddExtension() = True

            dialog.Title = "Seleccione nombre y destino del fichero Norma 19"
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                doc.GeneraFichero(dialog.FileName)
            End If

            'Si la opción esta marcada, doy por pagados todos los recibos co la fecha de cargo.
            'Dim i As Integer = 0
            'Dim sqlparam(1) As SqlClient.SqlParameter
            'Dim strSqlUpdate = "Update Recibos Set COBRADO='S',FECHACOBRO=@FECHACOBRO where NUMERO=@NUMERO"
            'For i = 0 To RECIBOSDataGridView.Rows.Count - 1
            '    If RECIBOSDataGridView.Rows(i).Cells(0).Value = True Then
            '        sqlparam(0) = New SqlClient.SqlParameter("@NUMERO", RECIBOSDataGridView.Rows(i).Cells(1).Value)
            '        sqlparam(1) = New SqlClient.SqlParameter("@FECHACOBRO", Me.dtp_fechacargo.Value.Date)
            '        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, strSqlUpdate, sqlparam)
            '    End If
            'Next
            MsgBox("Operación concluida con éxito", MsgBoxStyle.Information)
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al generar Cuaderno 19")
        End Try
    End Sub

#Region "Private Function GeneraN19PorRecibos() As GoltraTools.DocumentoN19"
    Private Function GeneraN19PorRecibos() As GoltraTools.DocumentoN19
        Dim doc As New GoltraTools.DocumentoN19()


        Dim adapterPaciente As New CMDataSetTableAdapters.PACIENTESTableAdapter()
        Dim adapterEmpresa As New CMDataSetTableAdapters.EMPRESASTableAdapter()

        'Cabecera presentador
        doc.CabeceraPresentador.B1_NIF = Globales.Configuracion.CIFpres
        doc.CabeceraPresentador.B1_Sufijo = Globales.Configuracion.sufijopres
        doc.CabeceraPresentador.B2 = dtp_fechafichero.Value.ToString("ddMMyy")

        doc.CabeceraPresentador.C = Globales.Configuracion.nombrepres
        doc.CabeceraPresentador.E1 = Globales.Configuracion.entidadpres
        doc.CabeceraPresentador.E2 = Globales.Configuracion.oficinapres


        'Cabecera ordenante
        doc.CabeceraOrdenante.B1_NIF = Globales.Configuracion.CIFord
        doc.CabeceraOrdenante.B1_Sufijo = Globales.Configuracion.sufijoord
        doc.CabeceraOrdenante.B2 = dtp_fechafichero.Value.ToString("ddMMyy")
        doc.CabeceraOrdenante.B3 = dtp_fechacargo.Value.ToString("ddMMyy")

        doc.CabeceraOrdenante.C = Globales.Configuracion.nombreord
        doc.CabeceraOrdenante.D1 = Globales.Configuracion.entidadord
        doc.CabeceraOrdenante.D2 = Globales.Configuracion.oficinaord
        doc.CabeceraOrdenante.D3 = Globales.Configuracion.DCord
        doc.CabeceraOrdenante.D4 = Globales.Configuracion.cuentaord
        doc.CabeceraOrdenante.E2 = "01"


        Dim _importeTotal As Double = 0
        Dim _contador As Integer = 0
        For Each row As DataGridViewRow In RECIBOSDataGridView.Rows
            If row.Cells(columnReciboCheck.Index).Value = True Then

                _contador = _contador + 1
                Dim recibo As RECIBO = row.DataBoundItem

                'Datos del paciente o de la empresa

                Dim cuenta As String = ""
                If Not recibo.CUENTA Is Nothing Then
                    cuenta = recibo.CUENTA
                End If
                Dim entidad As String = ""
                Dim Oficina As String = ""
                Dim DC As String = ""

                Dim domicilio As String = ""
                Dim provincia As String = ""
                Dim cp As String = ""
                Dim codigo As String = ""



                'Obtener paciente / empresa

                If Not recibo.REFPACIENTE Is Nothing Then
                    Dim paciente As PACIENTE = recibo.PACIENTE
                    codigo = paciente.CPACIENTE
                    If Not paciente.CUENTA Is Nothing Then
                        If GoltraTools.DocumentoN19.VerificaCuenta(paciente.CUENTA) Then
                            cuenta = Trim(paciente.CUENTA)
                        Else
                            MessageBox.Show("La cuenta del paciente No." & paciente.CPACIENTE & "(" & paciente.CUENTA & ") es incorrecta, generacion N19 se cancelará")
                            Return Nothing
                        End If

                    End If
                    If Not paciente.DC Is Nothing Then
                        DC = Trim(paciente.DC)
                    Else
                        MsgBox("El Digito de Control del paciente Nº " & paciente.CPACIENTE & ", no es correcto, la operación se cancelará.")
                        Return Nothing
                    End If

                    If Not paciente.ENTIDAD Is Nothing Then
                        entidad = paciente.ENTIDAD.Trim
                    Else
                        MsgBox("La entidad del paciente Nº " & paciente.CPACIENTE & ", no es correcto, la operación se cancelará.")
                        Return Nothing
                    End If

                    If Not paciente.OFICINA Is Nothing Then
                        Oficina = paciente.OFICINA.Trim
                    Else
                        MsgBox("La oficina del paciente Nº " & paciente.CPACIENTE & ", no es correcto, la operación se cancelará.")
                        Return Nothing
                    End If

                    If Not paciente.DOMICILIO Is Nothing Then
                        domicilio = paciente.DOMICILIO.Trim
                    End If
                    If Not paciente.PROVINCIA Is Nothing Then
                        provincia = paciente.PROVINCIA.Trim
                    End If
                    If Not paciente.CP Is Nothing Then
                        cp = paciente.CP.Trim
                    End If
                Else
                    If Not recibo.REFEMPRESA Is Nothing Then
                        Dim empresa As EMPRESA = recibo.EMPRESA
                        If Not empresa.DC Is Nothing Then
                            DC = Trim(empresa.DC)
                        Else
                            MsgBox("El Digito de Control del empresa Nº " & empresa.CEMPRESA & ", no es correcto, la operación se cancelará.")
                            Return Nothing
                        End If

                        If Not empresa.ENTIDAD Is Nothing Then
                            entidad = empresa.ENTIDAD.Trim
                        Else
                            MsgBox("La entidad del empresa Nº " & empresa.CEMPRESA & ", no es correcto, la operación se cancelará.")
                            Return Nothing
                        End If

                        If Not empresa.OFICINA Is Nothing Then
                            Oficina = empresa.OFICINA.Trim
                        Else
                            MsgBox("La oficina del empresa Nº " & empresa.CEMPRESA & ", no es correcto, la operación se cancelará.")
                            Return Nothing
                        End If
                        codigo = empresa.CEMPRESA
                        If Not empresa.CUENTA Is Nothing Then
                            cuenta = empresa.CUENTA
                        End If
                        If Not empresa.DIRECCION Is Nothing Then
                            domicilio = empresa.DIRECCION
                        End If
                        If Not empresa.PROVINCIA Is Nothing Then
                            provincia = empresa.PROVINCIA
                        End If
                        If Not empresa.CP Is Nothing Then
                            cp = empresa.CP
                        End If
                    End If

                End If

                If cuenta.Replace("0", " ").Trim() = "" Then
                    MessageBox.Show("El numero de cuenta de " & codigo & " no puede ser todo ceros ni vacia")
                    Return Nothing
                End If

                'Los individuales obligatorios
                Dim individual As New GoltraTools.IndividualObligatorio()

                individual.B1_NIF = Globales.Configuracion.CIFord
                individual.B1_Sufijo = Globales.Configuracion.sufijoord
                individual.B2 = codigo
                individual.C = recibo.NOMBRE
                individual.D1 = entidad 'Globals.Configuracion.entidadord
                individual.D2 = Oficina 'Globals.Configuracion.oficinaord
                individual.D3 = DC 'Globals.Configuracion.DCord
                individual.D4 = cuenta
                individual.E = recibo.IMPORTE
                individual.G = recibo.CONCEPTO
                _importeTotal = _importeTotal + recibo.IMPORTE
                doc.RegistrosIndividuales.Add(individual)

                'Opcional
                Dim opcional As New GoltraTools.Opcional()
                opcional.B1_NIF = Globales.Configuracion.CIFord
                opcional.B1_Sufijo = Globales.Configuracion.sufijoord
                opcional.B2 = codigo

                If Not recibo.NOMBRE Is Nothing Then
                    opcional.C = recibo.NOMBRE
                End If


                opcional.D = domicilio
                opcional.E1 = provincia
                opcional.E2 = cp
                doc.Opcionales.Add(opcional)

                recibo.N19 = "S"
                If chb_marcar.Checked Then
                    recibo.COBRADO = "S"
                    If recibo.FECHACOBRO.ToString.Length = 0 Then recibo.FECHACOBRO = Me.dtp_fechacargo.Value
                End If
                context.SubmitChanges()

                'RECIBOSTableAdapter.UpdateN19("S", recibo.NUMERO)

            End If
        Next

        If _contador = 0 Then
            MessageBox.Show("No hay recibos marcados")
            Return Nothing
        End If
        'Total Ordenante
        doc.TotalOrdenante.B1_NIF = Globales.Configuracion.CIFord
        doc.TotalOrdenante.B1_Sufijo = Globales.Configuracion.sufijoord
        doc.TotalOrdenante.E1 = _importeTotal
        doc.TotalOrdenante.F1 = _contador
        doc.TotalOrdenante.F2 = 1 + _contador + 1


        'Total General
        doc.Total_General.B1_NIF = Globales.Configuracion.CIFpres
        doc.Total_General.B1_Sufijo = Globales.Configuracion.sufijopres
        doc.Total_General.D1 = 1
        doc.Total_General.E1 = _importeTotal
        doc.Total_General.F1 = _contador
        doc.Total_General.F2 = 2 + _contador + 2

        Return doc

    End Function
#End Region

#Region "Private Function GeneraN19PorFacturas() As GoltraTools.DocumentoN19"
    Private Function GeneraN19PorFacturas() As GoltraTools.DocumentoN19
        Dim doc As New GoltraTools.DocumentoN19()


        Dim adapterPaciente As New CMDataSetTableAdapters.PACIENTESTableAdapter()
        Dim adapterEmpresa As New CMDataSetTableAdapters.EMPRESASTableAdapter()

        'Cabecera presentador
        doc.CabeceraPresentador.B1_NIF = Globales.Configuracion.CIFpres
        doc.CabeceraPresentador.B1_Sufijo = Globales.Configuracion.sufijopres
        doc.CabeceraPresentador.B2 = dtp_fechafichero.Value.ToString("ddMMyy")

        doc.CabeceraPresentador.C = Globales.Configuracion.nombrepres
        doc.CabeceraPresentador.E1 = Globales.Configuracion.entidadpres
        doc.CabeceraPresentador.E2 = Globales.Configuracion.oficinapres


        'Cabecera ordenante
        doc.CabeceraOrdenante.B1_NIF = Globales.Configuracion.CIFord
        doc.CabeceraOrdenante.B1_Sufijo = Globales.Configuracion.sufijoord
        doc.CabeceraOrdenante.B2 = dtp_fechafichero.Value.ToString("ddMMyy")
        doc.CabeceraOrdenante.B3 = dtp_fechacargo.Value.ToString("ddMMyy")

        doc.CabeceraOrdenante.C = Globales.Configuracion.nombreord
        doc.CabeceraOrdenante.D1 = Globales.Configuracion.entidadord
        doc.CabeceraOrdenante.D2 = Globales.Configuracion.oficinaord
        doc.CabeceraOrdenante.D3 = Globales.Configuracion.DCord
        doc.CabeceraOrdenante.D4 = Globales.Configuracion.cuentaord
        doc.CabeceraOrdenante.E2 = "01"


        Dim _importeTotal As Double = 0
        Dim _contador As Integer = 0
        For Each row As DataGridViewRow In FACTURASDataGridView.Rows
            If row.Cells(columnFacturaCheck.Index).Value = True Then

                _contador = _contador + 1
                Dim factura As FACTURA = row.DataBoundItem

                'Datos del paciente o de la empresa

                Dim cuenta As String = ""
                'If Not factura.iscueIsCUENTANull Then
                '    cuenta = factura.CUENTA
                'End If

                Dim domicilio As String = ""
                Dim provincia As String = ""
                Dim cp As String = ""
                Dim codigo As String = ""

                'Obtener paciente / empresa

                If Not factura.REFPACIENTE Is Nothing Then
                    Dim paciente As PACIENTE = factura.PACIENTE1
                    codigo = paciente.CPACIENTE
                    If Not paciente.CUENTA Is Nothing Then
                        If GoltraTools.DocumentoN19.VerificaCuenta(paciente.CUENTA) Then
                            cuenta = paciente.CUENTA
                        Else
                            MessageBox.Show("La cuenta del paciente No." & paciente.CPACIENTE & "(" & paciente.CUENTA & ") es incorrecta, generacion N19 se cancelará")
                            Return Nothing
                        End If

                    End If
                    If Not paciente.DOMICILIO Is Nothing Then
                        domicilio = paciente.DOMICILIO
                    End If
                    If Not paciente.PROVINCIA Is Nothing Then
                        provincia = paciente.PROVINCIA
                    End If
                    If Not paciente.CP Is Nothing Then
                        cp = paciente.CP
                    End If
                Else
                    If Not factura.REFEMPRESA Is Nothing Then
                        Dim empresa As EMPRESA
                        codigo = empresa.CEMPRESA
                        If Not empresa.CUENTA Is Nothing Then
                            cuenta = empresa.CUENTA
                        End If
                        If Not empresa.DIRECCION Is Nothing Then
                            domicilio = empresa.DIRECCION
                        End If
                        If Not empresa.PROVINCIA Is Nothing Then
                            provincia = empresa.PROVINCIA
                        End If
                        If Not empresa.CP Is Nothing Then
                            cp = empresa.CP
                        End If
                    End If

                End If

                If cuenta.Replace("0", " ").Trim() = "" Then
                    MessageBox.Show("El numero de cuenta de " & codigo & " no puede ser todo ceros ni vacia")
                    Return Nothing
                End If

                'Los individuales obligatorios
                Dim individual As New GoltraTools.IndividualObligatorio()

                individual.B1_NIF = Globales.Configuracion.CIFord
                individual.B1_Sufijo = Globales.Configuracion.sufijoord
                individual.B2 = codigo
                individual.C = factura.PACIENTE
                individual.D1 = Globales.Configuracion.entidadord
                individual.D2 = Globales.Configuracion.oficinaord
                individual.D3 = Globales.Configuracion.DCord
                individual.D4 = cuenta
                individual.E = factura.TOTAL
                If Not factura.DIAGNOSTICO Is Nothing Then
                    individual.G = factura.DIAGNOSTICO
                End If
                _importeTotal = _importeTotal + factura.TOTAL
                doc.RegistrosIndividuales.Add(individual)

                factura.N19 = "S"
                If chb_marcar.Checked Then
                    factura.PAGADA = "S"
                End If
                context.SubmitChanges()

                'Opcional
                Dim opcional As New GoltraTools.Opcional()
                opcional.B1_NIF = Globales.Configuracion.CIFord
                opcional.B1_Sufijo = Globales.Configuracion.sufijoord
                opcional.B2 = codigo

                If Not factura.PACIENTE Is Nothing Then
                    opcional.C = factura.PACIENTE
                End If


                opcional.D = domicilio
                opcional.E1 = provincia
                opcional.E2 = cp
                doc.Opcionales.Add(opcional)
            End If
        Next

        If _contador = 0 Then
            MessageBox.Show("No hay facturas marcados")
            Return Nothing
        End If
        'Total Ordenante
        doc.TotalOrdenante.B1_NIF = Globales.Configuracion.CIFord
        doc.TotalOrdenante.B1_Sufijo = Globales.Configuracion.sufijoord
        doc.TotalOrdenante.E1 = _importeTotal
        doc.TotalOrdenante.F1 = _contador
        doc.TotalOrdenante.F2 = 1 + _contador + 1


        'Total General
        doc.Total_General.B1_NIF = Globales.Configuracion.CIFpres
        doc.Total_General.B1_Sufijo = Globales.Configuracion.sufijopres
        doc.Total_General.D1 = 1
        doc.Total_General.E1 = _importeTotal
        doc.Total_General.F1 = _contador
        doc.Total_General.F2 = 2 + _contador + 2

        Return doc

    End Function
#End Region

    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        Filtrar()
    End Sub

    Private Sub MarcaTodos(ByVal marcar As Boolean)
        Dim i As Integer = 0

        If TabControl1.SelectedTab.Equals(tabRecibos) Then
            For i = 0 To RECIBOSDataGridView.Rows.Count - 1
                RECIBOSDataGridView.Rows(i).Cells(0).Value = marcar
            Next
            If marcar = True Then Me.lblInfoRecibos.Text = i & " recibos seleccionados." Else _
                                            lblInfoRecibos.Text = "Ningún recibo seleccionado."
        Else
            For i = 0 To FACTURASDataGridView.Rows.Count - 1
                FACTURASDataGridView.Rows(i).Cells(0).Value = marcar
            Next
            If marcar = True Then Me.lblInfoFacturas.Text = i & " facturas seleccionados." Else _
                                            lblInfoFacturas.Text = "Ninguna factura seleccionada."

        End If

    End Sub


    Private Sub llblMarcarTodos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblMarcarTodos.LinkClicked
        Me.MarcaTodos(True)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.MarcaTodos(False)
    End Sub
End Class