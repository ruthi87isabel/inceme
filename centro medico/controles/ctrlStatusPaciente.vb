Imports Microsoft.ApplicationBlocks.Data

Public Class ctrlStatusPaciente

    Private _ID_Paciente As Nullable(Of Integer) = Nothing

    'Private debitoAdapter As New CM3DataSetTableAdapters.DebitoPacienteTableAdapter()
    'Private debitoTable As New CM3DataSet.DebitoPacienteDataTable()

    Public Event CitaPagada(ByVal id As Integer)
    Public Event FacturaPagada(ByVal id As Integer)
    Public Event ReciboPagado(ByVal id As Integer)
    Public Event TicketPagado(ByVal idFactura As Integer)
    Public Event FacturasTPVPagado(ByVal idFactura As Integer)

    Public Credito As Double = 0
    Public Debe As Double = 0


    Dim WithEvents frmDebito As New frmPacienteDebito

    Private Sub ctrlStatusPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCredito.Text = 0.ToString("C2")
        lblDebe.Text = 0.ToString("C2")
       

    End Sub


    'Eventos que propagan los eventos internos del frmPacienteDebito

    Private Sub CitaPagadaHandler(ByVal id As Integer) Handles frmDebito.CitaPagada
        RaiseEvent CitaPagada(id)
    End Sub

    Private Sub FacturaPagadaHandler(ByVal id As Integer) Handles frmDebito.FacturaPagada
        RaiseEvent FacturaPagada(id)
    End Sub

    Private Sub ReciboPaagadoHandler(ByVal id As Integer) Handles frmDebito.ReciboPagado
        RaiseEvent ReciboPagado(id)
    End Sub

    Private Sub TicketPagadoHandler(ByVal id As Integer) Handles frmDebito.TicketPagado
        RaiseEvent TicketPagado(id)
    End Sub

    Private Sub FacturasTPVHandler(ByVal id As Integer) Handles frmDebito.FacturasTPVPagado
        RaiseEvent FacturasTPVPagado(id)
    End Sub



    <System.ComponentModel.Browsable(True)> _
    Public Property ID_PACIENTE() As Nullable(Of Integer)
        Get
            Return _ID_Paciente
        End Get
        Set(ByVal value As Nullable(Of Integer))

            _ID_Paciente = value
            If Me.IsHandleCreated Then
                If value.HasValue Then
                    CargaDatos()
                Else
                    'Limpiar datos
                    MuestraDato(btn_Citas, 0)
                    MuestraDato(btn_Facturas, 0)
                    MuestraDato(btn_FacturasTPV, 0)
                    MuestraDato(btn_Recibos, 0)
                    MuestraDato(btn_Tickets, 0)
                End If
                Me.Enabled = Not (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Datos_Personales) = RoleManager.TipoPermisos.Ninguno)

            End If


        End Set
    End Property

    Public Sub CargaDatos()
        Try
            Dim context As New CMLinqDataContext()

            Dim citas As List(Of CITA) = CitasManager.ListadoCitasDebitoPaciente(context,
                                                                         New FiltroListadoCitas With {
                                                                             .CPACIENTE = ID_PACIENTE
                                                                             }).ToList()

            'Dim citas As List(Of CITA) = (From c In context.CITAs _
            '                     Where (c.ATENDIDO = "S" And c.PAGADA = "N") _
            '                     And (c.Eliminado = False Or c.Eliminado Is Nothing) _
            '                     And Not c.REFFRA.HasValue _
            '                     And (c.IMPORTEDR + c.IMPORTECL) > 0 _
            '                     And c.REFPACIENTE = ID_PACIENTE _
            '                     Select c).ToList()

            Dim facturas As List(Of FACTURA) = (From f As FACTURA In context.FACTURAs _
                                                Where f.PAGADA = "N" And f.REFPACIENTE = ID_PACIENTE And f.REFRECIBO Is Nothing _
                                                And (f.Eliminado = False) And f.TOTAL > 0 _
                                                Select f).ToList()

            Dim recibos As List(Of RECIBO) = (From f As RECIBO In context.RECIBOs _
                                                Where f.COBRADO = "N" And f.REFPACIENTE = ID_PACIENTE And f.IMPORTE > 0
                                                Select f).ToList()

            Dim tickets As List(Of N_Ticket) = (From f As N_Ticket In context.N_Tickets _
                                                Where f.Pagado = False And f.ID_Cliente = ID_PACIENTE _
                                                And (Not f.Eliminado.HasValue Or f.Eliminado = False) And f.Total > 0 _
                                                Select f).ToList()

            Dim facturasTPV As List(Of N_Factura) = (From f As N_Factura In context.N_Facturas _
                                               Where f.Pagado = False And f.ID_Cliente = ID_PACIENTE And f.Total > 0 _
                                               Select f).ToList()
            

            Credito = PacienteDebitoManager.DameCreditoPaciente(ID_PACIENTE, context)

            lblCredito.Text = Credito.ToString("C2")

            Dim totalCitas As Double = citas.Sum(Function(o) Globales.CalculaImporteTotalCita(o))
            Dim totalFacturas As Double = facturas.Sum(Function(o) o.TOTAL)
            Dim totalRecibos As Double = recibos.Sum(Function(o) o.IMPORTE)
            Dim totalTickets As Double = tickets.Sum(Function(o) o.Total)
            Dim totalFacturasTPV As Double = facturasTPV.Sum(Function(o) o.Total)

            Debe = totalCitas + totalFacturas + totalRecibos + totalTickets + totalFacturasTPV
            lblDebe.Text = Debe.ToString("C2")

            MuestraDato(btn_Citas, citas.Count)
            MuestraDato(btn_Facturas, facturas.Count)
            MuestraDato(btn_FacturasTPV, facturasTPV.Count)
            MuestraDato(btn_Recibos, recibos.Count)
            MuestraDato(btn_Tickets, tickets.Count)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub MuestraDato(ByVal btn As Janus.Windows.EditControls.UIButton, ByVal value As Integer)
        If value = 0 Then
            btn.StateStyles.FormatStyle.ForeColor = Color.Green
        Else
            btn.StateStyles.FormatStyle.ForeColor = Color.Red
        End If
        btn.Text = value
    End Sub


    Private Sub btn_Citas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Citas.Click

        frmDebito.CtrlPaciente1.ID_PACIENTE = _ID_Paciente
        'frm.TabSeleccionado = form_pacientes_debito.Conceptos_a_Pagar.Citas
        'frm.MostrarTodas = True
        frmDebito.ShowDialog()
        CargaDatos()
    End Sub

    Private Sub btn_Facturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Facturas.Click

        frmDebito.CtrlPaciente1.ID_PACIENTE = _ID_Paciente
        'frm.TabSeleccionado = form_pacientes_debito.Conceptos_a_Pagar.Facturas
        'frm.MostrarTodas = True
        frmDebito.ShowDialog()
        CargaDatos()
    End Sub

    Private Sub btn_Recibos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recibos.Click

        frmDebito.CtrlPaciente1.ID_PACIENTE = _ID_Paciente
        'frm.TabSeleccionado = form_pacientes_debito.Conceptos_a_Pagar.Recibos
        'frm.MostrarTodas = True
        frmDebito.ShowDialog()
        CargaDatos()
    End Sub

    Private Sub btn_Tickets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Tickets.Click

        frmDebito.CtrlPaciente1.ID_PACIENTE = _ID_Paciente
        'frm.TabSeleccionado = form_pacientes_debito.Conceptos_a_Pagar.Tickets
        'frm.MostrarTodas = True
        frmDebito.ShowDialog()
        CargaDatos()
    End Sub

    Private Sub btn_FacturasTPV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FacturasTPV.Click
        frmDebito.CtrlPaciente1.ID_PACIENTE = _ID_Paciente
        frmDebito.ShowDialog()
        CargaDatos()
    End Sub

   

    Private Sub lblDebe_MouseHover(sender As System.Object, e As System.EventArgs) Handles lblDebe.MouseHover, lblCredito.MouseHover
        Dim setting As New Janus.Windows.Common.SuperTipSettings()
        setting.Text = "   DEBE: " & Debe.ToString("C2") & vbCrLf & _
                       "CREDITO: " & Credito.ToString("C2") & vbCrLf

        JanusSuperTip1.Show(setting, sender)
    End Sub
End Class
