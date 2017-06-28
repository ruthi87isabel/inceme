Imports centro_medico.UI.Reportes

Public Class form_derivaciones

    Dim fId As Integer
    Dim fPacienteId As Integer
    Dim fcurrentAcc As Integer
    Dim fDesdePaciente As Boolean

    Dim fCMDataSet As CMDataSet

    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer, ByVal aPacienteId As Integer, ByRef aCMDataSet As CMDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId
        Me.fPacienteId = aPacienteId
        Me.fDesdePaciente = True


        fCMDataSet = aCMDataSet

    End Sub


    Public Property CurrentAccion() As Enums.Accion

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fcurrentAcc

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As Enums.Accion)
            fcurrentAcc = Value
        End Set
    End Property


    Private Sub form_derivaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
        '  Me.USUARIOSTableAdapter.Fill(Me.CMDataSet.USUARIOS)
        'TODO: esta línea de código carga datos en la tabla 'CMDataSet.MEDICOS' Puede moverla o quitarla según sea necesario.
        'Me.MEDICOSTableAdapter.Fill(Me.CMDataSet.MEDICOS)
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Insertar Then

            'Cargar datos del usuario
            Dim Data As CMDataSet.USUARIOSRow
            Dim _idu As Integer = Globales.Usuario.CODIGO
            Dim adapter As CMDataSetTableAdapters.USUARIOSTableAdapter = New CMDataSetTableAdapters.USUARIOSTableAdapter()
            Dim _data As CMDataSet.USUARIOSDataTable = adapter.GetUserById(_idu)
            Data = _data.Rows(0)


            ' Dim _data As CMDataSet.USUARIOSDataTable = New CMDataSet.USUARIOSDataTable
            '_data.ImportRow(fCMDataSet.USUARIOS.FindByCODIGO(_idu))

            If Data.Item("REFMEDICO").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                CtrlMedico1.ID_Medico = Data.Item("REFMEDICO")
                'Dim _datax As CMDataSet.MEDICOSDataTable = MEDICOSTableAdapter.GetMedicoByID(Data.Item("REFMEDICO"))                
                'tb_medico.Text = _datax.Rows(0).Item("NOMBRE").ToString()
            Else
                CtrlMedico1.ID_Medico = Nothing
            End If
            ' tb_idmedico.Text = Globals.Usuario.CODIGO
        End If
        'tb_idmedico.Text = Globals.Usuario.CODIGO
    End Sub

    Private Sub Inicializa()
        'Dim _data As CMDataSet.DERIVACIONESDataTable = DERIVACIONESTableAdapter.GetDataByCodigo(fId)

        Dim _data As CMDataSet.DERIVACIONESDataTable = New CMDataSet.DERIVACIONESDataTable()

        _data.ImportRow(fCMDataSet.DERIVACIONES.FindByCODIGO(fId))

        If _data.Rows(0).Item("FECHA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            dtp_fecha.Value = _data.Rows(0).Item("FECHA")
        Else
            dtp_fecha.Value = DateTime.Now
        End If

        tb_iddestino.Text = _data.Rows(0).Item("REFDESTINO").ToString()
        tb_destino.Text = _data.Rows(0).Item("DESTINO").ToString()
        tb_motivo.Text = _data.Rows(0).Item("MOTIVO").ToString()
        tb_notas.Text = _data.Rows(0).Item("NOTAS").ToString()

        'tb_idmedico.Text = _data.Rows(0).Item("REFMEDICO").ToString()
        CtrlMedico1.ID_Medico = _data.Rows(0).Item("REFMEDICO")

        Dim _datax As CMDataSet.MEDICOSDataTable = MEDICOSTableAdapter.GetMedicoByID(_data.Rows(0).Item("REFMEDICO").ToString())
        ' tb_idmedico.Text = _data.Rows(0).Item("CMEDICO").ToString()
        'tb_medico.Text = _datax.Rows(0).Item("NOMBRE").ToString()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim _fecha As DateTime = dtp_fecha.Value
        Dim _refdestino As String = tb_iddestino.Text
        Dim _destino As String = tb_destino.Text
        If Not CtrlMedico1.ID_Medico.HasValue Then
            MessageBox.Show("Debe Seleccionar un Medico")
            CtrlMedico1.Focus()
            Return
        End If
        Dim _refmedico As String = CtrlMedico1.ID_Medico.Value.ToString() 'tb_idmedico.Text
        Dim _medico As String = CtrlMedico1.Medico.NOMBRECOMPLETO 'tb_medico.Text
        Dim _motivo As String = tb_motivo.Text
        Dim _notas As String = tb_notas.Text
        If Me.CurrentAccion = Enums.Accion.Modificar Then

            Dim _updRow As CMDataSet.DERIVACIONESRow = fCMDataSet.DERIVACIONES.FindByCODIGO(fId)

            _updRow.FECHA() = _fecha

            If _refdestino <> "" Then
                _updRow.REFDESTINO() = _refdestino
                _updRow.DESTINO() = _destino
            End If

            If _refmedico <> "" Then
                _updRow.REFMEDICO = _refmedico
            End If

            _updRow.MOTIVO() = _motivo
            _updRow.NOTAS() = _notas
            _updRow.REFPACIENTE() = fPacienteId


            'If _refdestino = "" Then
            '    DERIVACIONESTableAdapter.UpdateValoresSinDestino(_fecha, _motivo, _notas, fPacienteId, fId)

            'Else
            '    DERIVACIONESTableAdapter.UpdateValores(_fecha, _refdestino, _destino, _motivo, _notas, fPacienteId, fId)
            'End If

            Close()
        Else


            'vamos a sacar rrefmedico
            'si el médico es el usuario no ponemos ninguno
            If Not CtrlMedico1.ID_Medico.HasValue Then
                MessageBox.Show("Debe elegir un médico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CtrlMedico1.Focus()
                Return
            End If


            Dim _newRow As CMDataSet.DERIVACIONESRow = fCMDataSet.DERIVACIONES.NewDERIVACIONESRow()
            Dim _rows() As CMDataSet.DERIVACIONESRow = fCMDataSet.DERIVACIONES.Select("", "CODIGO ASC")

            Dim _maxBD As Integer = 1
            If DERIVACIONESTableAdapter.MaximoId.HasValue Then
                If Integer.TryParse(DERIVACIONESTableAdapter.MaximoId(), _maxBD) Then
                    _maxBD = _maxBD + 1
                End If
            End If


            Dim _maxDS As Integer = 1

            If _rows.Length > 0 Then
                _maxDS = _rows(_rows.Length - 1).CODIGO() + 1
            End If

            _newRow.CODIGO() = Math.Max(_maxDS, _maxBD)


            _newRow.FECHA() = _fecha

            If _refdestino <> "" Then
                _newRow.REFDESTINO() = _refdestino
                _newRow.DESTINO() = _destino
            End If

            _newRow.MOTIVO() = _motivo
            _newRow.NOTAS() = _notas
            _newRow.REFPACIENTE() = fPacienteId


            _newRow.REFMEDICO = _refmedico


            fCMDataSet.DERIVACIONES.AddDERIVACIONESRow(_newRow)


            'If _refdestino = "" Then
            '    DERIVACIONESTableAdapter.InsertSinDestino(_fecha, _motivo, _notas, fPacienteId)
            'Else
            '    DERIVACIONESTableAdapter.Insert(_fecha, _refdestino, _destino, _motivo, _notas, fPacienteId)

            'End If
            Close()

        End If
    End Sub


    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        Close()
    End Sub

    Private Sub bt_destinos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_destinos.Click
        Dim _listados As form_listados = New form_listados("Listado de Derivaciones Destino", DERIVACIONES_DESTINOSBindingSource, RoleManager.Items.Pacientes_Derivaciones, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()

        If _listados.Selected() <> "" Then
            Dim _data As CMDataSet.DERIVACIONES_DESTINOSDataTable = DERIVACIONES_DESTINOSTableAdapter.GetClinicaById(_listados.Selected())
            tb_iddestino.Text = _data.Rows(0).Item("CODIGO").ToString()
            tb_destino.Text = _data.Rows(0).Item("NOMBRE").ToString()
        End If

    End Sub

    Private Sub tb_iddestino_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_iddestino.Leave
        If tb_iddestino.Text <> "" Then
            Dim _data As CMDataSet.DERIVACIONES_DESTINOSDataTable = DERIVACIONES_DESTINOSTableAdapter.GetClinicaById(tb_iddestino.Text)
            If _data.Rows.Count > 0 Then
                tb_destino.Text = _data.Rows(0).Item("NOMBRE").ToString()
            Else
                tb_iddestino.Text = ""
                tb_iddestino.Focus()
                MessageBox.Show("No existe una clínica con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    'Private Sub tb_idmedico_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If tb_idmedico.Text <> "" Then
    '        Dim _pcodo As Integer = Integer.Parse(tb_idmedico.Text)
    '        Dim _data As CMDataSet.MEDICOSDataTable = MEDICOSTableAdapter.GetMedicoByID(_pcodo)
    '        If _data.Rows.Count > 0 Then
    '            tb_medico.Text = _data.Rows(0).Item("NOMBRE").ToString()
    '        Else
    '            tb_idmedico.Text = ""
    '            tb_idmedico.Focus()
    '            MessageBox.Show("No existe un médico con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    End If
    'End Sub


    Private Sub Imprimir()
        Dim NombrePaciente As String = ""
        Dim DatosMedico As String = ""
        Dim FechaNacimiento As String = ""

        Dim rdata As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim tadapacientes As New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
        Dim tadamedicos As New centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
        Dim parametros(6) As Microsoft.Reporting.WinForms.ReportParameter

        'datos del medico
        If CtrlMedico1.ID_Medico.HasValue Then
            'If Not Globals.Usuario.Item("RefMedico").GetType Is GetType(DBNull) Then
            'If Not tadamedicos.GetMedicoByID(Me.tb_idmedico.Text).Rows(0).Item("Nombre").GetType Is GetType(DBNull) Then
            DatosMedico = CtrlMedico1.Medico.NOMBRECOMPLETO ' tadamedicos.GetMedicoByID(Me.tb_idmedico.Text).Rows(0).Item("Nombre").trim
            ' End If
            'If Not tadamedicos.GetMedicoByID(Me.tb_idmedico.Text).Rows(0).Item("Apellido1").GetType Is GetType(DBNull) Then
            '    DatosMedico += " " + tadamedicos.GetMedicoByID(Me.tb_idmedico.Text).Rows(0).Item("Apellido1").trim
            'End If
            'If Not tadamedicos.GetMedicoByID(Me.tb_idmedico.Text).Rows(0).Item("Apellido2").GetType Is GetType(DBNull) Then
            '    DatosMedico += " " + tadamedicos.GetMedicoByID(Me.tb_idmedico.Text).Rows(0).Item("Apellido2").trim
            'End If
            'If Not tadamedicos.GetMedicoByID(Me.tb_idmedico.Text).Rows(0).Item("Colegiado").GetType Is GetType(DBNull) Then
            If Not CtrlMedico1.Medico.COLEGIADO Is Nothing Then
                DatosMedico += " Colegiado: " & CtrlMedico1.Medico.COLEGIADO.Trim
            End If
            'End If
        End If

        'datos del paciente
        If Not tadapacientes.GetPacienteById(Me.fPacienteId).Rows(0).Item("Nombre").GetType Is GetType(DBNull) Then
            NombrePaciente = tadapacientes.GetPacienteById(Me.fPacienteId).Rows(0).Item("Nombre").trim
        End If
        If Not tadapacientes.GetPacienteById(Me.fPacienteId).Rows(0).Item("Apellido1").GetType Is GetType(DBNull) Then
            NombrePaciente += " " + tadapacientes.GetPacienteById(Me.fPacienteId).Rows(0).Item("Apellido1").trim
        End If
        If Not tadapacientes.GetPacienteById(Me.fPacienteId).Rows(0).Item("Apellido2").GetType Is GetType(DBNull) Then
            NombrePaciente += " " + tadapacientes.GetPacienteById(Me.fPacienteId).Rows(0).Item("Apellido2").trim
        End If
        If Not tadapacientes.GetPacienteById(Me.fPacienteId).Rows(0).Item("FECHAN").GetType Is GetType(DBNull) Then
            FechaNacimiento = tadapacientes.GetPacienteById(Me.fPacienteId).Rows(0).Item("FECHAN")
        End If

        parametros(0) = New Microsoft.Reporting.WinForms.ReportParameter
        parametros(0).Name = "NombrePaciente"
        parametros(0).Values.Add(NombrePaciente)
        parametros(1) = New Microsoft.Reporting.WinForms.ReportParameter
        parametros(1).Name = "DatosMedico"
        parametros(1).Values.Add(DatosMedico)
        parametros(2) = New Microsoft.Reporting.WinForms.ReportParameter
        parametros(2).Name = "Fecha"
        parametros(2).Values.Add(Me.dtp_fecha.Text)
        parametros(3) = New Microsoft.Reporting.WinForms.ReportParameter
        parametros(3).Name = "Motivo"
        parametros(3).Values.Add(Me.tb_motivo.Text.Trim)
        parametros(4) = New Microsoft.Reporting.WinForms.ReportParameter
        parametros(4).Name = "NOTAS"
        parametros(4).Values.Add(Me.tb_notas.Text.Trim)
        parametros(5) = New Microsoft.Reporting.WinForms.ReportParameter
        parametros(5).Name = "Destino"
        parametros(5).Values.Add(Me.tb_destino.Text.Trim)
        parametros(6) = New Microsoft.Reporting.WinForms.ReportParameter
        parametros(6).Name = "FechaNacimiento"
        parametros(6).Values.Add(FechaNacimiento)


        ReportesManager.Imprime("Derivacion.rdlc", Nothing, parametros)


    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        Me.Imprimir()
    End Sub

    'Private Sub bt_medicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim _listados As form_listados = New form_listados("Listado de Médicos", MEDICOSBindingSource, RoleManager.Items.Medicos, True)
    '    _listados.ShowInTaskbar = False
    '    _listados.ShowDialog()

    '    If _listados.Selected() <> "" Then
    '        Dim _data As CMDataSet.MEDICOSDataTable = MEDICOSTableAdapter.GetMedicoByID(_listados.Selected())
    '        tb_idmedico.Text = _data.Rows(0).Item("CMEDICO").ToString()
    '        tb_medico.Text = _data.Rows(0).Item("NOMBRE").ToString()
    '    End If
    'End Sub



End Class