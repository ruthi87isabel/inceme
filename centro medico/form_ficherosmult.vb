Imports System.IO

Public Class form_ficherosmult
    Dim fId As Integer
    Dim fMesActual As Boolean
    Dim fFicherosOrdenado As String
    Dim fCambios As Boolean = False
    Dim fFicherosRealCount As Integer
    Dim _sepuede As Boolean = True

    Dim borrar As Boolean = False
    Dim ficheroBorrar As String


#Region "Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)"
    Sub New(ByVal aId As Integer)
        fId = aId
        InitializeComponent()

        'RECETASBindingSource.Filter = "refpaciente =" & fId
    End Sub
#End Region

    Private Sub form_ficherosmult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PACIENTESTableAdapter.FillPacienteById(Me.CMDataSet.PACIENTES, fId)
        Me.FICHEROSTableAdapter.FillByPaciente(Me.CMDataSet.FICHEROS, fId)
        AplicaPermisos()
        InicializaFicheros(fFicherosOrdenado)
        ActualizarFechaNac()
    End Sub

    Private Sub AplicaPermisos()
        dtg_fmFicheros.ReadOnly = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 2)
        bt_fmAnnadir.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 2)
        bt_fmEditar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 2)
        tb_fmBorrar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 3)
        WebBrowser1.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 1)
    End Sub


    Private Sub InicializaFicheros(ByVal aOrdenar As String)
        Dim _dataFicheros As CMDataSet.FICHEROSDataTable = New CMDataSet.FICHEROSDataTable()
        Dim k As Integer

        Dim _expression As String = "REFPACIENTE = " + fId.ToString()
        Dim _sortOrder As String = ""

        Dim _sortBy As String = ""

        If aOrdenar = "C" Then
            '_dataFicheros = FICHEROSTableAdapter.GetDataByPacienteOrderFechaCreacion(fId)
            _sortOrder = "FECHA ASC"
        ElseIf aOrdenar = "M" Then
            '_dataFicheros = FICHEROSTableAdapter.GetDataByPacienteOrderFechaModif(fId)
            _sortOrder = "FECHAMODIFICACION ASC"
        Else
            '_dataFicheros = FICHEROSTableAdapter.GetDataByPaciente(fId)
            If aOrdenar = "D" Then
                _sortBy = "Descripción ASC"
            Else
                _sortBy = "Fichero ASC"
            End If
        End If

        Dim _rows() As DataRow = CMDataSet.FICHEROS.Select(_expression, _sortOrder)
        For k = 0 To _rows.Length - 1
            _dataFicheros.ImportRow(_rows(k))
        Next

        Dim _source As DataTable = New DataTable("Tabla")
        _source.Columns.Add("Codigo")
        _source.Columns.Add("F.Creación")
        _source.Columns.Add("F.Modificación")
        _source.Columns.Add("Descripción")
        _source.Columns.Add("Fichero")

        Dim i As Integer
        For i = 0 To _dataFicheros.Rows.Count - 1

            'Dim _rowAded As Boolean = False

            Dim _row() As Object = New Object(4) {}
            _row(0) = _dataFicheros.Rows(i).Item("CODIGO")

            Dim _fecha As DateTime = Nothing
            If _dataFicheros.Rows(i).Item("FECHA").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                _fecha = _dataFicheros.Rows(i).Item("FECHA")
                _row(1) = _fecha.ToShortDateString()
            End If

            If _dataFicheros.Rows(i).Item("FECHAMODIFICACION").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
                Dim _fechaM As DateTime = _dataFicheros.Rows(i).Item("FECHAMODIFICACION")
                _row(2) = _fechaM.ToShortDateString()
            End If

            _row(3) = _dataFicheros.Rows(i).Item("DESCRIPCION").ToString()
            _row(4) = _dataFicheros.Rows(i).Item("FICHERO").ToString()

            _source.Rows.Add(_row)
            '_rowAded = True And _rowAded = True

            If fMesActual = True Then
                If _fecha = Nothing Then
                    _source.Rows.RemoveAt(_source.Rows.Count - 1)
                Else
                    If _fecha.Month <> DateTime.Now.Month Then
                        _source.Rows.RemoveAt(_source.Rows.Count - 1)
                    End If
                End If

            End If

        Next

        fFicherosRealCount = _source.Rows.Count
        FICHEROSBindingSource.DataSource = _source
        dtg_fmFicheros.DataSource = FICHEROSBindingSource

        If _source.Rows.Count > 0 Then
            dtg_fmFicheros.Rows(0).Selected = True
            dtg_fmFicheros.AllowUserToAddRows = False
            dtg_fmFicheros.AllowUserToDeleteRows = False
            FICHEROSBindingSource.Sort() = _sortBy
            dtg_fmFicheros.Columns("Codigo").Visible = False
            dtg_fmFicheros.Columns("F.Creación").Visible = False
        End If
    End Sub

    Private Sub bt_fmAnnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_fmAnnadir.Click
        Dim _cantidadInicial As Integer = dtg_fmFicheros.Rows.Count

        Dim _ficheros As form_pac_ficheros_multimedias = New form_pac_ficheros_multimedias("Ficheros y Multimedias - Añadir", Enums.Accion.Insertar, -1, fId, CMDataSet)
        _ficheros.ShowInTaskbar = False
        If _ficheros.ShowDialog() = Windows.Forms.DialogResult.OK Then
            fCambios = True
            InicializaFicheros(fFicherosOrdenado)
            If dtg_fmFicheros.Rows.Count > 0 And dtg_fmFicheros.Rows.Count <> _cantidadInicial Then
                dtg_fmFicheros.Rows(dtg_fmFicheros.Rows.Count - 1).Selected = True
            End If
        End If
        
    End Sub

    Private Sub bt_fmEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_fmEditar.Click
        If dtg_fmFicheros.SelectedRows.Count > 0 Then
            Dim _index As Integer = dtg_fmFicheros.SelectedRows(0).Index

            Dim _Cod As Integer = Integer.Parse(dtg_fmFicheros.SelectedRows(0).Cells("Codigo").Value.ToString())
            Dim _ficheros As form_pac_ficheros_multimedias = New form_pac_ficheros_multimedias("Ficheros y Multimedias - Editar", Enums.Accion.Modificar, _Cod, fId, CMDataSet)
            _ficheros.ShowInTaskbar = False
            _ficheros.ShowDialog()
            InicializaFicheros(fFicherosOrdenado)
            dtg_fmFicheros.Rows(_index).Selected = True
            fCambios = True
        End If
    End Sub

    Private Sub tb_fmBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_fmBorrar.Click
        If dtg_fmFicheros.SelectedCells.Count > 0 Then

            Try

                Dim _index As Integer = dtg_fmFicheros.SelectedCells(0).RowIndex
                Dim _Cod As Integer = Integer.Parse(dtg_fmFicheros.Rows(_index).Cells("Codigo").Value.ToString())

                Dim _row As CMDataSet.FICHEROSRow = CMDataSet.FICHEROS.FindByCODIGO(_Cod)

                'Impersonar al usuario segun su carpeta compartida
                If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                    Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                                                                Globales.Configuracion.CarpetaCompartidaPassword, _
                                                                Globales.Configuracion.CarpetaCompartidaDominio)
                End If


                If File.Exists(Globales.Configuracion.dirfiles & "\" & _row.FICHERO) Then

                    'Deshacer la impersonacion
                    If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                        If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                            GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                        End If
                    End If

                    Dim res As MsgBoxResult = MsgBox("Esto eliminará el fichero definitivamente, ¿Segudo que desea continuar?", MsgBoxStyle.YesNo)
                    If res = MsgBoxResult.Yes Then

                        'Primero hay que eliminarlo del webBrowser para evitar que de error
                        'Dim url As Uri = New Uri("about:blank")
                        'WebBrowser1.Navigate(url)
                        'System.Diagnostics.Process.GetProcessById(1).`
                        Try

                            'Impersonar al usuario segun su carpeta compartida
                            If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                                Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                                                                            Globales.Configuracion.CarpetaCompartidaPassword, _
                                                                            Globales.Configuracion.CarpetaCompartidaDominio)
                            End If

                            Globales.BorrarFicheroLocked(Globales.Configuracion.dirfiles & "\" & _row.FICHERO)

                        Catch ex As Exception
                            MessageBox.Show("El fichero esta siendo utizado por un proceso externo, cierrelo e intente de nuevo")
                            'MessageBox.Show("Error eliminando fichero " & ex.Message)
                            Return
                        Finally
                            If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                                If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                                    GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                                End If
                            End If
                        End Try
                    Else
                        'Deshacer la impersonacion
                        If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                            If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                                GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                            End If
                        End If
                        Exit Sub
                    End If

                End If

                _row.Delete()
                fCambios = True
                InicializaFicheros(fFicherosOrdenado)
                If dtg_fmFicheros.Rows.Count > 0 Then
                    If _index <> 0 Then
                        _index = _index - 1
                    End If
                    dtg_fmFicheros.Rows(_index).Selected = True

                End If

                dtg_fmFicheros.EndEdit()
                FICHEROSBindingSource.EndEdit()
                FICHEROSTableAdapter.Update(CMDataSet.FICHEROS)
                dtg_fmFicheros_CellClick(Nothing, Nothing)
                ' Dim url As Uri = New Uri("about:blank")
                If dtg_fmFicheros.RowCount = 0 Then
                    WebBrowser1.Visible = False
                End If

            Catch ex As Exception
            Finally
                'Deshacer la impersonacion
                If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                    If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                        GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                    End If
                End If
            End Try

        End If
    End Sub

    Private Sub rb_fmDescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_fmDescripcion.CheckedChanged
        fFicherosOrdenado = "D"
        InicializaFicheros(fFicherosOrdenado)
    End Sub

    Private Sub rb_fmFichero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_fmFichero.CheckedChanged
        fFicherosOrdenado = "F"
        InicializaFicheros(fFicherosOrdenado)
    End Sub

    Private Sub rb_fmModificacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_fmModificacion.CheckedChanged
        fFicherosOrdenado = "M"
        InicializaFicheros(fFicherosOrdenado)
    End Sub

    Private Sub rb_fmCreacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_fmCreacion.CheckedChanged
        fFicherosOrdenado = "C"
        InicializaFicheros(fFicherosOrdenado)
    End Sub

   

    Private Sub dtg_fmFicheros_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_fmFicheros.CellClick
        If _sepuede = True Then

            If dtg_fmFicheros.SelectedRows.Count > 0 Then
                'Impersonar al usuario segun su carpeta compartida
                If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                    Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                                                                Globales.Configuracion.CarpetaCompartidaPassword, _
                                                                Globales.Configuracion.CarpetaCompartidaDominio)
                End If

                Dim _direccion As String = Globales.Configuracion.dirfiles
                Try
                    If File.Exists(_direccion + "\" + dtg_fmFicheros.SelectedRows(0).Cells("FICHERO").Value) Then
                        Me.lblInfoFicherosMultimedia.Visible = False
                        Dim url As Uri = New Uri(_direccion + "\" + dtg_fmFicheros.SelectedRows(0).Cells("FICHERO").Value, UriKind.RelativeOrAbsolute)
                        WebBrowser1.Url = url
                    Else
                        Me.lblInfoFicherosMultimedia.Visible = True
                    End If
                    If Not WebBrowser1.Visible Then
                        WebBrowser1.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 1)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Asegúrese de que la carpeta de ficheros compartidas elegida en Configuración sea la correcta" + "\n" + " o que el fichero seleccionado se encuentre en la misma", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    WebBrowser1.Stop()
                Finally
                    'Deshacer la impersonacion
                    If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                        If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                            GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                        End If
                    End If
                End Try
            End If
        End If
    End Sub


    Private Sub dtg_fmFicheros_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtg_fmFicheros.CellMouseDoubleClick
        'permiso lectura no deja editar
        If (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) = RoleManager.TipoPermisos.Lectura) Then
            Return
        End If
        bt_fmEditar_Click(sender, e)
    End Sub

    Private Sub ActualizarFechaNac()
        Try
            Dim _fechaNac As Date = CMDataSet.PACIENTES.FindByCPACIENTE(fId).FECHAN
            Dim _anno As Integer = _fechaNac.Year
            If _fechaNac.Month > DateTime.Now.Month Then
                tb_dpEdadhactual.Text = (DateTime.Now.Year - _anno - 1).ToString()
            ElseIf _fechaNac.Month < DateTime.Now.Month Then
                tb_dpEdadhactual.Text = (DateTime.Now.Year - _anno).ToString()
            ElseIf _fechaNac.Day >= DateTime.Now.Day Then
                tb_dpEdadhactual.Text = (DateTime.Now.Year - _anno).ToString()
            Else
                tb_dpEdadhactual.Text = (DateTime.Now.Year - _anno - 1).ToString()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        dtg_fmFicheros.EndEdit()
        FICHEROSBindingSource.EndEdit()
        FICHEROSTableAdapter.Update(CMDataSet.FICHEROS)
        Me.Close()
    End Sub

    Private Sub form_ficherosmult_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Globales.TeclasBasicas.Annadir
                bt_fmAnnadir_Click(sender, e)
            Case Globales.TeclasBasicas.Borrar
                tb_fmBorrar_Click(sender, e)
            Case Globales.TeclasBasicas.Editar
                bt_fmEditar_Click(sender, e)
        End Select
    End Sub


    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Dim res As MsgBoxResult
        If fCambios = True Then
            res = MsgBox("Hay cambios sin guardar. Si continua los perderá. ¿Seguro que desea continuar y perderlos?", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

   
End Class