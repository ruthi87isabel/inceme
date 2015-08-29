Public Class form_renumerar
    Dim empezar As Integer = 0

    Sub New(ByVal aconfig As Configuracion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub bt_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cerrar.Click
        Me.Close()
    End Sub

    Private Sub LlenaSerie()
        Dim _data As CMDataSet.SERIESDataTable = Me.SERIESTableAdapter.GetData()
        Dim i As Integer
        For i = 0 To _data.Rows.Count - 1
            Dim _cod As String = _data.Rows(i).Item("CODIGO").ToString()
            cb_serie.Items.Add(_cod)
            cb_origen.Items.Add(_cod)
            cb_destino.Items.Add(_cod)
        Next
    End Sub

    Private Sub CargaFacturas()
        dgv_facturas.Rows.Clear()
        dgv_fact1.Rows.Clear()
        dgv_fact2.Rows.Clear()
        Dim serie As String = cb_serie.Text
        Dim serie1 As String = cb_origen.Text
        Dim serie2 As String = cb_destino.Text
        Dim fecha As Date = dtp_fi.Value
        Dim _data As CMDataSet.FACTURASDataTable = FACTURASTableAdapter.GetDataBySerie(serie)
        Dim _dataf As CMDataSet.FACTURASDataTable = FACTURASTableAdapter.GetDataByFechaSerie(serie1, fecha)
        Dim _datafact As CMDataSet.FACTURASDataTable = FACTURASTableAdapter.GetDataByFechaSerie(serie2, fecha)

        Dim id As Integer
        Dim numero As String
        Dim fechaemision As Date
        Dim importe As Single
        Dim total As Single
        Dim IRPF As Single
        Dim i As Integer
        For i = 0 To _data.Rows.Count - 1
            id = _data.Rows(i).Item("IDFACTURA")
            numero = _data.Rows(i).Item("NUMERO")
            fechaemision = _data.Rows(i).Item("FEMISION")
            total = _data.Rows(i).Item("TOTAL")
            IRPF = _data.Rows(i).Item("PORCENTAJEIRPF")
            IRPF = (total * IRPF) / 100
            importe = total - IRPF
            dgv_facturas.Rows.Add(fechaemision.ToShortDateString(), numero, importe, id)
        Next

        For i = 0 To _dataf.Rows.Count - 1
            id = _dataf.Rows(i).Item("IDFACTURA")
            numero = _dataf.Rows(i).Item("NUMERO")
            fechaemision = _dataf.Rows(i).Item("FEMISION")
            total = _dataf.Rows(i).Item("TOTAL")
            IRPF = _dataf.Rows(i).Item("PORCENTAJEIRPF")
            IRPF = (total * IRPF) / 100
            importe = total - IRPF

            dgv_fact1.Rows.Add(fechaemision.ToShortDateString(), numero, importe, id)
        Next

        For i = 0 To _datafact.Rows.Count - 1
            id = _datafact.Rows(i).Item("IDFACTURA")
            numero = _datafact.Rows(i).Item("NUMERO")
            fechaemision = _datafact.Rows(i).Item("FEMISION")
            total = _datafact.Rows(i).Item("TOTAL")
            IRPF = _datafact.Rows(i).Item("PORCENTAJEIRPF")
            IRPF = (total * IRPF) / 100
            importe = total - IRPF

            dgv_fact2.Rows.Add(fechaemision.ToShortDateString(), numero, importe, id)
        Next
    End Sub

    Private Sub form_renumerar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaSerie()
        cb_serie.Text = "A"
        cb_origen.Text = "A"
        CargaFacturas()
    End Sub

    Private Sub cb_serie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_serie.SelectedIndexChanged
        CargaFacturas()
    End Sub

    Private Sub cb_origen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_origen.SelectedIndexChanged
        CargaFacturas()
    End Sub

    Private Sub cb_destino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_destino.SelectedIndexChanged
        CargaFacturas()
    End Sub

    Private Sub bt_factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_factura.Click
        Me.FACTURASTableAdapter.Fill(Me.CMDataSet.FACTURAS)
        Dim _name As String = "Listado de facturas"
        Dim _listados As form_listados = New form_listados(_name, FACTURASBindingSource, RoleManager.Items.Facturas, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            empezar = _pcodo
            Dim _data As CMDataSet.FACTURASDataTable = FACTURASTableAdapter.GetFacturaById(_pcodo)
            Dim numero As String = _data.Rows(0).Item("NUMERO")
            tb_factura.Text = numero
        End If
    End Sub

    Private Sub bt_renumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_renumerar.Click
        If MessageBox.Show("El proceso de renumerar es irreversible.Esta seguro de querer hacerlo?", "Renumerar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Dim i As Integer
            Dim cant As Integer = nud_inicial.Value
            Dim proceso As String = ""
            For i = 0 To dgv_facturas.Rows.Count - 1
                Dim cod As Integer = dgv_facturas.Rows(i).Cells("Cod").Value
                If cod >= empezar Then
                    Dim _digits As Integer = cant.ToString().Length
                    Dim j As Integer
                    Dim _result As String = cb_serie.Text
                    For j = 0 To 5 - _digits
                        _result = _result + "0"
                    Next
                    _result = _result + cant.ToString()
                    FACTURASTableAdapter.UpdateNumero(cant, _result, cod)
                    cant = cant + 1
                    proceso = proceso + "Procesando la factura " + dgv_facturas.Rows(i).Cells("numero").Value + " a " + _result + Microsoft.VisualBasic.ControlChars.NewLine
                    lb_estado.Text = proceso
                End If
            Next
            Dim _data As CMDataSet.SERIESDataTable = Me.SERIESTableAdapter.GetSerieByCodigo(cb_serie.Text)
            Dim _cantn As Integer = _data.Rows(0).Item("CONTADOR")
            Me.SERIESTableAdapter.Update(cb_serie.Text, cant - 1, cb_serie.Text, _cantn)
            CargaFacturas()
        End If
    End Sub

    Private Sub bt_traspaso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_traspaso.Click
        If cb_destino.Text <> "" Then
            If MessageBox.Show("Esta seguro de querer cambiar la serie?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim i As Integer
                For i = 0 To dgv_fact1.SelectedRows.Count - 1
                    Dim cod As Integer = dgv_fact1.Rows(i).Cells("Codigo").Value
                    Dim _data As CMDataSet.SERIESDataTable = Me.SERIESTableAdapter.GetSerieByCodigo(cb_destino.Text)
                    Dim _cantn As Integer = _data.Rows(0).Item("CONTADOR")
                    Dim _cant As String = (_cantn + 1).ToString()
                    Me.SERIESTableAdapter.Update(cb_serie.Text, _cantn + 1, cb_destino.Text, _cantn)
                    Dim _digits As Integer = _cant.Length
                    Dim j As Integer
                    Dim _result As String = cb_destino.Text
                    For j = 0 To 5 - _digits
                        _result = _result + "0"
                    Next
                    _result = _result + _cant
                    FACTURASTableAdapter.UpdateSerie(_result, cb_destino.Text, cod)
                Next
                CargaFacturas()
            End If
        Else
            MessageBox.Show("Debe escoger una serie destino para cambiar la serie origen", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
    End Sub

    Private Sub dtp_fi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fi.ValueChanged
        CargaFacturas()
    End Sub
End Class