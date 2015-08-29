Public Class frmChequeoIntegridad



    Dim context As New CMLinqDataContext()

    Dim lineasAReparar As New List(Of LineasFacturaReparar)


    Private Sub frmChequeoIntegridad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub


    Private Sub IniciaChequeo()
        'Empieza el chequeo
        pbar.Value = 10
        Chequeo()
        pbar.Value = 100
        lbl_Proceso.Text = "Completado"
        lbl_SubProceso.Text = "100%"

        txtLog.ScrollToCaret()
    End Sub

    Private Sub Chequeo()
        Dim sqlConn As New Data.SqlClient.SqlConnection(My.Settings.CMConnectionString)

        Try
            txtLog.AppendText("Chequeando Facturas No pagadas con FECHA de cobro y poniendo a null la fecha de cobro" & vbCrLf)
            txtLog.AppendText(vbCrLf)
            sqlConn.Open()
            Dim command As New Data.SqlClient.SqlCommand(" UPDATE FACTURAS SET FECHACOBRO=NULL  WHERE PAGADA='N'", sqlConn)
            Dim res As Integer = command.ExecuteNonQuery()
            'Dim res As Integer = Microsoft.ApplicationBlocks.Data.SqlHelper.(My.Settings.CMConnectionString, CommandType.Text, , Nothing)
            txtLog.AppendText("Modificadas " & res & " factura(s)" & vbCrLf)
            txtLog.AppendText(vbCrLf)

            txtLog.AppendText("Chequeando CITAS con TOTAL = NULL y cambiandolos a 0" & vbCrLf)
            txtLog.AppendText(vbCrLf)

            Dim command2 As New Data.SqlClient.SqlCommand(" UPDATE CITAS SET TOTAL=0 WHERE TOTAL IS NULL", sqlConn)
            Dim res2 As Integer = command2.ExecuteNonQuery()
            'Dim res As Integer = Microsoft.ApplicationBlocks.Data.SqlHelper.(My.Settings.CMConnectionString, CommandType.Text, , Nothing)
            txtLog.AppendText("Modificadas " & res2 & " cita(s)" & vbCrLf)
            txtLog.AppendText(vbCrLf)

        Catch ex As Exception

        Finally
            sqlConn.Close()
        End Try


        ChequeoLineasFacturasYaPagadas()


        If lineasAReparar.Count = 0 Then
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            'Me.Close()
        End If


    End Sub

    Private Class LineasFacturaReparar
        Public Linea As LINEASFACTURA
        Public LineaCita As LineasCita
        Public Entrega As EntregasCuenta
    End Class

    Private Sub ChequeoLineasFacturasYaPagadas()
        txtLog.AppendText("Chequeando lineas de facturas que debian estar como pagadas ya que sus lineas de cita lo están..." & vbCrLf)
        txtLog.AppendText(vbCrLf)
        Dim lineas As List(Of LINEASFACTURA) = (From l In context.LINEASFACTURAs _
                                               Where l.FACTURA.PAGADA = "N" And Not l.RefLineaCita.HasValue
                                               Select l).ToList()



        For Each linea As LINEASFACTURA In lineas
            'txtLog.AppendText(String.Format("- Linea ID: {0}, Fecha: {1}, Concepto: {2}, Importe: {3} ", linea.IDLINEAFACTURA, _
            '                                                                                            linea.FACTURA.FECHA, _
            '                                                                                            linea.CONCEPTO, _
            '                                                                                            linea.IMPORTE) & vbCrLf)

            'Por cada una de ellas trataremos de encontrarle una entrega asociada
            'para lo cual, primero intentaremos con la cita

            Dim factura As FACTURA = linea.FACTURA
            Dim importeLinea As Double = linea.IMPORTE
            'If importeLinea = 75 Then
            Dim entregas As List(Of EntregasCuenta) = (From e As EntregasCuenta In context.EntregasCuentas _
                                  Where e.TipoDocumento = 1 _
                                  And e.IDPaciente = factura.REFPACIENTE _
                                  And e.Importe = importeLinea
                                  Select e).ToList()
            If entregas.Count > 0 Then
                'txtLog.AppendText("Coincidencia!!" + vbCrLf + vbCrLf)
                For Each ent As EntregasCuenta In entregas
                    If linea.CONCEPTO.Contains(ent.Fecha.Value.ToString("dd/MM/yyyy")) Then
                        txtLog.AppendText("Posible Coincidencia de paciente, fecha e importe:" & vbCrLf)
                        txtLog.AppendText("  Paciente: " & factura.PACIENTE & ", (" & factura.PACIENTE1.CPACIENTE & ")" & vbCrLf)
                        txtLog.AppendText(String.Format("  - Linea Factura: {0} {1} {2}", linea.REFCONCEPTO, linea.CONCEPTO, linea.IMPORTE.Value.ToString("c2")) & vbCrLf)
                        txtLog.AppendText(String.Format("  - Entrega      : {0} {1}", ent.Descripcion, ent.Importe.Value.ToString("c2")) & vbCrLf)


                        Try
                            Dim idCita As Integer = Integer.Parse(ent.CodDocumento)
                            Dim cita As CITA = (From c In context.CITAs _
                                           Where c.IDCITA = idCita _
                                           Select c).SingleOrDefault()

                            If Not cita Is Nothing Then
                                For Each lineaCita As LineasCita In cita.LineasCitas
                                    If lineaCita.RefConcepto = linea.REFCONCEPTO Then
                                        Dim reparar As New LineasFacturaReparar
                                        reparar.Linea = linea
                                        reparar.LineaCita = lineaCita
                                        reparar.Entrega = ent
                                        lineasAReparar.Add(reparar)
                                        txtLog.AppendText(String.Format("== Linea cita encontrada! ") & vbCrLf)

                                    End If
                                Next

                            End If
                            txtLog.AppendText(vbCrLf)

                            
                        Catch ex As Exception

                        End Try
                        
                    End If
                Next
            End If

            'End If



        Next


        txtLog.AppendText("Encontradas " & lineasAReparar.Count & " posibles lineas de factura por pagar" & vbCrLf & vbCrLf)
        txtLog.AppendText("Presione 'Reparar' para corregir estos errores" & vbCrLf)


    End Sub

   
    Private Sub btnReparar_Click(sender As System.Object, e As System.EventArgs) Handles btnReparar.Click
        For Each lineaRep As LineasFacturaReparar In lineasAReparar
            lineaRep.Linea.LineasCita = lineaRep.LineaCita
        Next
        context.SubmitChanges()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmChequeoIntegridad_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        IniciaChequeo()
    End Sub
End Class