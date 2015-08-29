Imports System.IO

Public Class form_generar_n19




    Dim fIntervalo As Boolean = False
    Dim fFiltro As String = "N"

    Sub New(ByVal aconfig As Configuracion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub InicializaRecibos(ByVal aIntervalo As Boolean, ByVal aFiltro As String)
        Dim _dataRecibos As CMDataSet.RECIBOSDataTable = RECIBOSTableAdapter.GetDataByRecibosPacientePagoBanco

        Dim _source As DataTable = New DataTable("Tabla")
        _source.Columns.Add("Numero")
        _source.Columns.Add("RefPaciente")
        _source.Columns.Add("Nombre")
        _source.Columns.Add("Concepto")
        _source.Columns.Add("Importe")
        _source.Columns.Add("Entidad")
        _source.Columns.Add("Oficina")
        _source.Columns.Add("DC")
        _source.Columns.Add("Cuenta")


        Dim i As Integer

        For i = 0 To _dataRecibos.Rows.Count - 1
            Dim _row() As Object = New Object(8) {}

            _row(0) = _dataRecibos.Rows(i).Item("NUMERO")
            _row(1) = _dataRecibos.Rows(i).Item("REFPACIENTE")
            _row(2) = _dataRecibos.Rows(i).Item("NOMBRE")
            _row(3) = _dataRecibos.Rows(i).Item("CONCEPTO").ToString()
            _row(4) = _dataRecibos.Rows(i).Item("IMPORTE").ToString()


            If _dataRecibos.Rows(i).Item("REFPACIENTE").ToString() <> "" Then
                Dim _IdPaciente As Integer = Integer.Parse(_dataRecibos.Rows(i).Item("REFPACIENTE"))
                Dim _dataPaciente As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(_IdPaciente)
                _row(5) = _dataPaciente.Rows(0).Item("ENTIDAD").ToString()
                _row(6) = _dataPaciente.Rows(0).Item("OFICINA").ToString()
                _row(7) = _dataPaciente.Rows(0).Item("DC").ToString()
                _row(8) = _dataPaciente.Rows(0).Item("CUENTA").ToString()
            Else
                _row(5) = ""
                _row(6) = ""
                _row(7) = ""
                _row(8) = ""
            End If

            Dim _fechaE As DateTime
            If _dataRecibos.Rows(i).Item("FECHAEMISION").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _fechaE = _dataRecibos.Rows(i).Item("FECHAEMISION")
            Else
                _fechaE = Date.Now.Date
            End If

            Dim _fechaV As DateTime
            If _dataRecibos.Rows(i).Item("FECHAVENCIMIENTO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _fechaV = _dataRecibos.Rows(i).Item("FECHAVENCIMIENTO")
            Else
                _fechaV = Date.Now.Date
            End If

            If aIntervalo = True Then
                If _fechaE >= dtp_fechainicial.Value And _fechaE <= dtp_fechafinal.Value Then
                    If _dataRecibos.Rows(i).Item("N19").ToString() = "N" Then

                        If aFiltro = "N" And _dataRecibos.Rows(i).Item("EMITIDO").ToString() = "N" Then
                            _source.Rows.Add(_row)
                        ElseIf aFiltro = "E" And _dataRecibos.Rows(i).Item("EMITIDO").ToString() = "S" Then
                            _source.Rows.Add(_row)

                        ElseIf aFiltro = "T" Then
                            _source.Rows.Add(_row)

                        End If

                    End If
                End If
            Else
                If _dataRecibos.Rows(i).Item("N19").ToString() = "N" Then
                    If aFiltro = "N" And _dataRecibos.Rows(i).Item("EMITIDO").ToString() = "N" Then
                        _source.Rows.Add(_row)
                    ElseIf aFiltro = "E" And _dataRecibos.Rows(i).Item("EMITIDO").ToString() = "S" Then
                        _source.Rows.Add(_row)

                    ElseIf aFiltro = "T" Then
                        _source.Rows.Add(_row)

                    End If
                End If
            End If

        Next


        RECIBOSBindingSource.DataSource = _source
        dtg_recibos.AllowUserToAddRows = False
        dtg_recibos.AllowUserToDeleteRows = False
        dtg_recibos.DataSource = RECIBOSBindingSource

        If dtg_recibos.Rows.Count = 0 Then
            dtg_recibos.DataSource = New DataTable()
        End If


    End Sub



    Private Sub form_generar_n19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicializaRecibos(fIntervalo, fFiltro)
    End Sub

    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        fIntervalo = True
        InicializaRecibos(fIntervalo, fFiltro)
    End Sub

    Private Sub bt_generarN19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_generarN19.Click

        'Dim i As Integer
        'Dim _day As Date = Date.Now

        'Dim _textoFichero As String = _
        '"5180" & _
        'Globals.Configuracion.CIFpres & _
        'Globals.Configuracion.sufijopres & _
        '_day.ToString("ddMMyy") & _
        'Microsoft.VisualBasic.ControlChars.Tab

        '_textoFichero = _textoFichero & Globals.Configuracion.nombrepres & Microsoft.VisualBasic.ControlChars.Tab & Globals.Configuracion.entidadpres & Globals.Configuracion.oficinapres & Microsoft.VisualBasic.ControlChars.NewLine
        '_textoFichero = _textoFichero & "5380" & Globals.Configuracion.CIFord & Globals.Configuracion.sufijoord & _day.ToString("ddMMyy") & _day.ToString("ddMMyy")
        '_textoFichero = _textoFichero & Globals.Configuracion.nombreord & Microsoft.VisualBasic.ControlChars.Tab & Globals.Configuracion.entidadord & Globals.Configuracion.oficinaord & Globals.Configuracion.DCord & Globals.Configuracion.cuentaord & Microsoft.VisualBasic.ControlChars.Tab & "01" & Microsoft.VisualBasic.ControlChars.NewLine

        'Dim _importeTotal As Double

        'For i = 0 To dtg_recibos.SelectedRows.Count - 1
        '    Dim _numero As Integer = Integer.Parse(dtg_recibos.SelectedRows(i).Cells("Numero").Value.ToString())
        '    RECIBOSTableAdapter.UpdateN19("S", _numero)
        '    Dim _nombre As String = GetPaciente(dtg_recibos.SelectedRows(i).Cells("RefPaciente").Value.ToString())
        '    Dim _refpac As String = dtg_recibos.SelectedRows(i).Cells("RefPaciente").Value.ToString()


        '    Dim _entidad As String = Globals.Configuracion.entidadord 'dtg_recibos.SelectedRows(i).Cells("Entidad").Value.ToString()
        '    Dim _oficina As String = Globals.Configuracion.oficinaord  'dtg_recibos.SelectedRows(i).Cells("Oficina").Value.ToString()
        '    Dim _dc As String = Globals.Configuracion.DCord 'dtg_recibos.SelectedRows(i).Cells("DC").Value.ToString()
        '    Dim _cuenta As String = Globals.Configuracion.cuentaord 'dtg_recibos.SelectedRows(i).Cells("Cuenta").Value.ToString()
        '    Dim _concepto As String = RECIBOSTableAdapter.GetDataByNumero(_numero).Item(0).CONCEPTO 'dtg_recibos.SelectedRows(i).Cells("Concepto").Value.ToString()
        '    Dim _importeRecibo As String = RECIBOSTableAdapter.GetDataByNumero(_numero).Item(0).IMPORTE 'dtg_recibos.SelectedRows(i).Cells("Importe").Value

        '    _importeTotal = _importeTotal + _importeRecibo

        '    _textoFichero = _textoFichero & "5680" & Globals.Configuracion.CIFord & Globals.Configuracion.sufijoord & _refpac & Microsoft.VisualBasic.ControlChars.Tab & _nombre.ToUpper() & Microsoft.VisualBasic.ControlChars.Tab
        '    _textoFichero = _textoFichero & _entidad & _oficina & _dc & _cuenta
        '    Dim _index As Integer = _importeRecibo.LastIndexOf(",")
        '    Dim _importe As String
        '    _importe = _importeRecibo.Replace(",", "")

        '    If _index = -1 Then
        '        _importe = _importe & "00"
        '    ElseIf _index = _importe.Length - 3 Then
        '        _importe = _importe & "0"
        '    End If

        '    While _importe.Length < 10
        '        _importe = "0" & _importe

        '    End While
        '    _textoFichero = _textoFichero & _importe
        '    _textoFichero = _textoFichero & Microsoft.VisualBasic.ControlChars.Tab & _concepto & Microsoft.VisualBasic.ControlChars.NewLine
        'Next

        '_textoFichero = _textoFichero & " Total del Ordenante : " & _importeTotal.ToString()

        'If ofd_GuardarFicheroN19.ShowDialog() = Windows.Forms.DialogResult.OK Then

        '    Dim _fs As FileStream = File.Create(ofd_GuardarFicheroN19.FileName)
        '    Dim _sw As StreamWriter = New StreamWriter(_fs)
        '    _sw.Write(_textoFichero)
        '    _sw.Flush()
        '    _sw.Close()
        '    _fs.Close()


        'End If

        'InicializaRecibos(fIntervalo, fFiltro)

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub


    Private Function GetPaciente(ByVal aId As Integer) As String

        'Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)

        Dim _data As CMDataSet.PACIENTESDataTable

        _data = Me.PACIENTESTableAdapter.GetPacienteById(aId)

        Dim _paciente As String = ""

        If _data.Rows.Count > 0 Then
            Dim _pacientename As String = _data.Rows(0).Item("NOMBRE").ToString()
            Dim _pacienteapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
            Dim _pacienteapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
            _paciente = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename

        End If

        Return _paciente

    End Function

    Private Sub rb_recibosnoemitidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recibosnoemitidos.CheckedChanged
        fFiltro = "N"
        InicializaRecibos(fIntervalo, fFiltro)
    End Sub

    Private Sub rb_recibosemitidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recibosemitidos.CheckedChanged
        fFiltro = "E"
        InicializaRecibos(fIntervalo, fFiltro)
    End Sub

    Private Sub rb_todosrecibos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_todosrecibos.CheckedChanged
        fFiltro = "T"
        InicializaRecibos(fIntervalo, fFiltro)
    End Sub

    Private Sub dtg_recibos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_recibos.CellDoubleClick
        If dtg_recibos.SelectedRows.Count > 0 Then
            Dim _mostrarrecibo As form_recibos = New form_recibos("Recibos - Modificar", Enums.Accion.Modificar, dtg_recibos.SelectedRows(0).Cells("Numero").Value)
            _mostrarrecibo.ShowInTaskbar = False
            _mostrarrecibo.ShowDialog()
        End If
    End Sub
End Class