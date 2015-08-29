Public Class frmPagarDocumentos
    Implements IFormDocumentosPendientes

    Public Sub New(ByRef FechaPago As Date)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dtp_Fecha.Value = FechaPago

    End Sub


    Private Sub frmPagarDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DocumentosPendientes Is Nothing Then
            If DocumentosPendientes.Count = 0 Then
                MessageBox.Show("No hay documentos que pagar")
                Return
            End If
        End If

        chkUtilizarCredito.Enabled = DocumentosPendientes.Sum(Function(o) o.Importe) <= txtCredito.Value
        chkUtilizarCredito.Checked = chkUtilizarCredito.Enabled
        GridEXDocs.DataSource = DocumentosPendientes
    End Sub

    Public Property DocumentosPendientes As ICollection(Of IDocumentoPagable) Implements IFormDocumentosPendientes.DocumentosPendientes


    Public Property IdFormaPagoPreseleccionada As String Implements IFormDocumentosPendientes.IdFormaPagoPreseleccionada
        Set(value As String)
            CtrlFormaPago21.ID_FORMASPAGO = value
        End Set
        Get
            Return CtrlFormaPago21.ID_FORMASPAGO
        End Get
    End Property

    Public Property IdFormaPagoSeleccionada As String Implements IFormDocumentosPendientes.IdFormaPagoSeleccionada
        Get
            Return CtrlFormaPago21.ID_FORMASPAGO
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Importe As Double Implements IFormDocumentosPendientes.Importe
        Get
            Return txtImporte.Value
        End Get
        Set(value As Double)
            txtImporte.Value = value
        End Set
    End Property

    Public ReadOnly Property UsarCredito As Boolean Implements IFormDocumentosPendientes.UsarCredito
        Get
            Return chkUtilizarCredito.Checked
        End Get
    End Property

    Public ReadOnly Property FechaPago As Date Implements IFormDocumentosPendientes.FechaPago
        Get
            Return Me.dtp_Fecha.Value
        End Get
    End Property

    Private Sub chkUtilizarCredito_CheckedChanged(sender As Object, e As EventArgs) Handles chkUtilizarCredito.CheckedChanged
        CtrlFormaPago21.Visible = Not chkUtilizarCredito.Checked
        If chkUtilizarCredito.Checked Then
            CtrlFormaPago21.ID_FORMASPAGO = Nothing
            CtrlFormaPago21.txt_Nombre.Text = ""
            CtrlFormaPago21.txt_Codigo.Text = ""
        End If

    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Public Property Credito As Double Implements IFormDocumentosPendientes.Credito

    Public Function Muestra(credito As Double) As DialogResult Implements IFormDocumentosPendientes.Muestra
        txtImporte.Value = DocumentosPendientes.Sum(Function(o) o.Importe)
        txtCredito.Value = credito
        Return Me.ShowDialog()
    End Function
End Class