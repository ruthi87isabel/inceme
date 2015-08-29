Imports System.IO

Public Class form_pac_ficheros_multimedias

    Dim fcurrentAcc As Integer
    Dim fId As String
    Dim fcodo As String
    Dim fdescripo As String
    Dim fficheroo As String
    Dim fcreaciono As DateTime
    Dim fultimamodifo As DateTime
    Dim PathFichero As String
    Dim fnotaso As String

    Dim fPacienteId As Integer = 0
    Dim fDesdePaciente As Boolean = False


    Dim fCMDataSet As CMDataSet

    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As String, ByVal aPacienteId As Integer, ByRef aCMDataSet As CMDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId

        fDesdePaciente = True
        fPacienteId = aPacienteId
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


    Private Sub bt_FiBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_FiBuscar.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim _indice As Integer = OpenFileDialog1.FileName.LastIndexOf("\")
            Dim _name As String = OpenFileDialog1.FileName
            Me.lblPathOriginalFIchero.Text = ""
            PathFichero = Path.GetDirectoryName(_name)
            Me.lblPathOriginalFIchero.Text = PathFichero
            tb_FiNombre.Text = Path.GetFileName(_name)
        End If
    End Sub

    Private Sub form_pac_ficheros_multimedias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.lblPathOriginalFIchero.Text = ""
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_FiDescripcion.ReadOnly = True
            tb_FiNombre.ReadOnly = True
            tb_FiNotas.ReadOnly = True
            dtp_FiFechacreacion.Enabled = False
            dtp_FiUltimamodificacion.Enabled = False
            bt_FiBuscar.Enabled = False

        End If
    End Sub

    Private Sub Inicializa()
        'Dim _data As CMDataSet.FICHEROSDataTable = FICHEROSTableAdapter.GetFicheroById(fId)
        Dim _data As CMDataSet.FICHEROSDataTable = New CMDataSet.FICHEROSDataTable()

        _data.ImportRow(fCMDataSet.FICHEROS.FindByCODIGO(fId))

        tb_FiDescripcion.Text = _data.Rows(0).Item("DESCRIPCION").ToString()
        tb_FiNombre.Text = _data.Rows(0).Item("FICHERO").ToString()
        tb_FiNotas.Text = _data.Rows(0).Item("NOTAS").ToString()

        If _data.Rows(0).Item("FECHA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            dtp_FiFechacreacion.Value = _data.Rows(0).Item("FECHA")
        Else
            dtp_FiFechacreacion.Value = DateTime.Now
        End If

        If _data.Rows(0).Item("FECHAMODIFICACION").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            dtp_FiUltimamodificacion.Value = _data.Rows(0).Item("FECHAMODIFICACION")
        Else
            dtp_FiUltimamodificacion.Value = DateTime.Now
        End If

    End Sub

    Private Sub bt_FiAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_FiAceptar.Click
        If tb_FiDescripcion.Text = "" Or tb_FiNombre.Text = "" Then
            MessageBox.Show("Los siguientes datos son obligatorios:" + Microsoft.VisualBasic.ControlChars.NewLine + "- Descripción del fichero" + Microsoft.VisualBasic.ControlChars.NewLine + "- Ruta del fichero" + Microsoft.VisualBasic.ControlChars.NewLine + "- Fechas de creación y modificación" + Microsoft.VisualBasic.ControlChars.NewLine + "Comprueba que ha cubierto todos los datos o pulse CANCELAR", "!ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim rutafich As String = Globales.Configuracion.dirfiles

    
        Try
            If Me.lblPathOriginalFIchero.Text.Trim.Length > 0 Then

                Dim fsOrigen As New FileStream(lblPathOriginalFIchero.Text & "\" & tb_FiNombre.Text, FileMode.Open)
                Dim fsDestino As FileStream
                Try
                    Dim arr(fsOrigen.Length) As Byte
                    fsOrigen.Read(arr, 0, arr.Length)


                    'Impersonar al usuario segun su carpeta compartida
                    If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                        Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                                                                    Globales.Configuracion.CarpetaCompartidaPassword, _
                                                                    Globales.Configuracion.CarpetaCompartidaDominio)
                    End If

                    fsDestino = New FileStream(Globales.Configuracion.dirfiles & "\" & tb_FiNombre.Text, FileMode.Create)
                    fsDestino.Write(arr, 0, arr.Length)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return
                Finally
                    fsOrigen.Close()
                    If Not fsDestino Is Nothing Then
                        fsDestino.Close()
                    End If
                    'Desacher la impersonacion
                    If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                        If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                            GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                        End If
                    End If

                End Try

            End If
        Catch ex As Exception
            MessageBox.Show("Error copiando: " & ex.Message)
            Return
        End Try
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            'FICHEROSTableAdapter.UpdateValores(fPacienteId, dtp_FiFechacreacion.Value, dtp_FiUltimamodificacion.Value, Path.GetFileName(tb_FiNombre.Text), tb_FiNotas.Text, tb_FiDescripcion.Text, fId)
            Dim _updRow As CMDataSet.FICHEROSRow = fCMDataSet.FICHEROS.FindByCODIGO(fId)

            _updRow.REFPACIENTE() = fPacienteId
            _updRow.FECHA() = dtp_FiFechacreacion.Value
            _updRow.FECHAMODIFICACION() = dtp_FiUltimamodificacion.Value
            _updRow.FICHERO() = tb_FiNombre.Text
            _updRow.NOTAS() = tb_FiNotas.Text
            _updRow.DESCRIPCION() = tb_FiDescripcion.Text

        ElseIf Me.CurrentAccion = Enums.Accion.Insertar Then


            'FICHEROSTableAdapter.InsertNuevo(fPacienteId, dtp_FiFechacreacion.Value, dtp_FiUltimamodificacion.Value, Path.GetFileName(tb_FiNombre.Text), tb_FiNotas.Text, tb_FiDescripcion.Text)

            Dim _newRow As CMDataSet.FICHEROSRow = fCMDataSet.FICHEROS.NewFICHEROSRow()

            Dim _rows() As CMDataSet.FICHEROSRow = fCMDataSet.FICHEROS.Select("", "CODIGO ASC")

            Dim _maxBD As Integer = 1
            If FICHEROSTableAdapter.MaximoId.HasValue Then
                If Integer.TryParse(FICHEROSTableAdapter.MaximoId(), _maxBD) Then
                    _maxBD = _maxBD + 1
                End If
            End If

            Dim _maxDS As Integer = 1

            If _rows.Length > 0 Then
                _maxDS = _rows(_rows.Length - 1).CODIGO() + 1
            End If

            _newRow.CODIGO() = Math.Max(_maxDS, _maxBD)

            _newRow.REFPACIENTE() = fPacienteId
            _newRow.FECHA() = dtp_FiFechacreacion.Value
            _newRow.FECHAMODIFICACION() = dtp_FiUltimamodificacion.Value
            _newRow.FICHERO() = tb_FiNombre.Text
            _newRow.NOTAS() = tb_FiNotas.Text
            _newRow.DESCRIPCION() = tb_FiDescripcion.Text

            fCMDataSet.FICHEROS.AddFICHEROSRow(_newRow)
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub bt_FiCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_FiCancelar.Click
        Close()
    End Sub
End Class