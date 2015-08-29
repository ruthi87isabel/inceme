Imports Janus.Windows.GridEX
Imports System.ComponentModel

Public Class frmChequeoTotalesCitas
    Dim context As CMLinqDataContext
    Dim citas As IQueryable(Of CITA)

    Dim loadingForm As LoadingForm
    Dim fixingLoadingForm As LoadingForm


    Private fixWorker As BackgroundWorker
    Private worker As BackgroundWorker

    Dim cantProblemas As Integer = 0
   
    Private Sub frmChequeoTotalesCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CargaDatos()
        dtp_fi.Value = Date.Now.AddMonths(-1)

        worker = New BackgroundWorker()
        worker.WorkerReportsProgress = True
        worker.WorkerSupportsCancellation = True
        AddHandler worker.DoWork, AddressOf CargaCitas
        AddHandler worker.RunWorkerCompleted, AddressOf CargaCitasCompletada
        


        fixingLoadingForm = New LoadingForm()
        fixWorker = New BackgroundWorker
        fixWorker.WorkerReportsProgress = True
        fixWorker.WorkerSupportsCancellation = True


        AddHandler fixWorker.ProgressChanged, AddressOf ProgresoReparacion
        AddHandler fixWorker.DoWork, AddressOf Reparar
        AddHandler fixWorker.RunWorkerCompleted, AddressOf ReparacionTerminada

        fixingLoadingForm.Worker = fixWorker

    End Sub

    Public Sub CargaCitas()
        
        'GridEX1.DataSource = Nothing

        CITABindingSource.DataSource = citas

    End Sub


    Private Sub CargaCitasCompletada(sender As Object, e As RunWorkerCompletedEventArgs)
        'GridEX1.DataSource = CITABindingSource

        Dim cantTotal As Integer = context.CITAs.Count()

        lblProblemas.Text = String.Format("Con problemas: {0}/{1} [{2}%]", _
                                          cantProblemas, cantTotal, CType((cantProblemas / cantTotal) * 100, Integer))

        'GridEX1.DataSource = citas
        btnCargarCitas.Enabled = True
        btnAplicarCorreccion.Enabled = True
        loadingForm.Close()
    End Sub

    Private Sub btnCargarCitas_Click(sender As Object, e As EventArgs) Handles btnCargarCitas.Click
        CargaDatos()
    End Sub

    Private Sub CargaDatos()

        btnCargarCitas.Enabled = False
        btnAplicarCorreccion.Enabled = False

        loadingForm = New LoadingForm()
        loadingForm.Worker = worker

        context = New CMLinqDataContext
        citas = From c In context.CITAs
                Order By c.FECHA Descending
                Select c


        'Problema
        If chkSoloProblematicas.Checked Then
            citas = citas.Where(Function(c) (c.IMPORTECL + c.IMPORTEDR) - c.Descuento <> c.TOTAL)
        End If

        Dim fi As Date = New Date(dtp_fi.Value.Year, dtp_fi.Value.Month, dtp_fi.Value.Day, 0, 0, 0)
        Dim ff As Date = New Date(dtp_ff.Value.Year, dtp_ff.Value.Month, dtp_ff.Value.Day, 23, 59, 59)

        'Me.BeginInvoke(Sub()

        '               End Sub)s
        If dtp_fi.Checked Then
            citas = citas.Where(Function(o) o.FECHA >= fi)
        End If
        If dtp_ff.Checked Then
            citas = citas.Where(Function(o) o.FECHA <= ff)
        End If

        If chkSololasPrimeras.Checked Then
            Dim value As Integer = Integer.Parse(TextBox1.Text)
            citas = citas.Take(value)
        End If

        cantProblemas = citas.Count

        worker.RunWorkerAsync()
        loadingForm.ShowDialog(Me)
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If e.Row.RowType = RowType.Record Then
            Dim frm As New form_citas("Ver cita", Enums.Accion.Ver, e.Row.DataRow.IDCITA)
            frm.Show()
        End If
    End Sub


    Private Sub btnAplicarCorreccion_Click(sender As Object, e As EventArgs) Handles btnAplicarCorreccion.Click

        If GridEX1.GetCheckedRows().Count = 0 Then
            MessageBox.Show("No hay citas seleccionadas")
            Return
        End If

        If MessageBox.Show("¿Desea corregir los totales de citas? Esta acción no podra desahacerse.", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Return
        End If

        fixWorker.RunWorkerAsync()
        fixingLoadingForm.ShowDialog()
    End Sub
    Private Sub ProgresoReparacion(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs)
        fixingLoadingForm.DisplayMessage = String.Format("Reparando {0} %", e.ProgressPercentage)
    End Sub

    Private Sub Reparar(sender As Object, e As DoWorkEventArgs)

        Dim ncontext As New CMLinqDataContext
        Dim rows() = GridEX1.GetCheckedRows()
        Dim rowCount As Integer = rows.Where(Function(o As GridEXRow) o.Parent Is Nothing).Count

        Dim counter = 0
        For Each citaRow As GridEXRow In rows
            If citaRow.Parent Is Nothing Then
                Dim IDCITA As Integer = citaRow.DataRow.IDCITA
                Dim cita As CITA = (From c In ncontext.CITAs Where c.IDCITA = IDCITA Select c).SingleOrDefault
                'For Each lineaRow As GridEXRow In citaRow.GetChildRows()
                '    Dim linea As LineasCita = lineaRow.DataRow
                '    linea.Total = Globales.CalculaImporteTotalDeLineaCita(linea)
                'Next
                'context.SubmitChanges()
                'Dim res As CITA = Globales.CalculaImporteTotalCitaViaLineasAsCita(cita)
                'cita.IMPORTECL = res.IMPORTECL
                'cita.IMPORTEDR = res.IMPORTEDR
                'cita.Descuento = res.Descuento
                'cita.TOTAL = res.TOTAL
                For Each linea As LineasCita In cita.LineasCitas


                    'If cita.LineasCitas.Count = 1 Then
                    If linea.Total Is Nothing Then linea.Total = 0

                    Dim diff As Decimal = linea.Total / linea.Cantidad - linea.ImporteClinica
                    If Math.Abs(diff) < 0.01 Then
                        'linea.Total = linea.Total / linea.Cantidad
                        linea.ImporteClinica = linea.Total / linea.Cantidad

                        If cita.TOTAL - linea.ImporteClinica < 0.01 Then
                            linea.ImporteClinica = cita.TOTAL
                            linea.Total = cita.TOTAL
                        End If
                    End If
                    'End If


                    If linea.ImporteDr = 0 And (linea.DescuentoPercent = 0 Or Not linea.DescuentoPercent.HasValue) And linea.ImporteClinica <> linea.Total / linea.Cantidad Then
                        linea.ImporteClinica = linea.Total / linea.Cantidad
                    End If

                    cita.IMPORTECL = cita.LineasCitas.Sum(Function(o) o.ImporteClinica * o.Cantidad)

                    If cita.TOTAL - cita.IMPORTECL < 0.01 Then
                        cita.IMPORTECL = cita.TOTAL
                    End If

                Next
                fixWorker.ReportProgress(((counter + 1) / rowCount) * 100)
                counter += 1
            End If
        Next
        ncontext.SubmitChanges()
    End Sub

    Private Sub ReparacionTerminada(sender As Object, e As RunWorkerCompletedEventArgs)
        fixingLoadingForm.Close()
        CargaDatos()
    End Sub

  

End Class

Partial Public Class Cita

    Public ReadOnly Property ReTotal As Double
        Get
            Return Globales.CalculaImporteTotalCitaViaLineasAsCita(Me).TOTAL
        End Get
    End Property
End Class



