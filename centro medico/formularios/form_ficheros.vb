Imports System.IO
Public Class form_ficheros

    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim clickaccept As Boolean = False
    Dim fnombreo As String
    Dim ffechao As Date
    Dim fcompletename As String
    Dim fdescripo As String

    Private Sub FICHEROSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FICHEROSBindingSource.EndEdit()
        Me.FICHEROSTableAdapter.Update(Me.CMDataSet.FICHEROS)

    End Sub
    Private Sub Inicializa()
        Dim _data As CMDataSet.FICHEROSDataTable = Me.FICHEROSTableAdapter.GetFicheroById(fId)
        fnombreo = _data.Rows(0).Item("FICHERO").ToString()
        ffechao = _data.Rows(0).Item("FECHA")
        fdescripo = _data.Rows(0).Item("DESCRIPCION").ToString()
        tb_nombrefichero.Text = fnombreo
        dtp_fechafichero.Value = ffechao
        tb_descripcionfichero.Text = fdescripo

    End Sub

    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName


    End Sub
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId


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

    Private Sub form_ficheros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()

        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_nombrefichero.ReadOnly = True
            tb_descripcionfichero.ReadOnly = True
            dtp_fechafichero.Enabled = False
            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If

    End Sub

    Private Sub bt_fichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_fichero.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim _indice As Integer = OpenFileDialog1.FileName.LastIndexOf("\")
            Dim _dir As String = OpenFileDialog1.FileName.Substring(_indice + 1)
            tb_nombrefichero.Text = _dir
            fcompletename = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub form_ficheros_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _nombre As String = tb_nombrefichero.Text.Trim()
            Dim _fecha As Date = dtp_fechafichero.Value.Date
            Dim _descrip As String = tb_descripcionfichero.Text.Trim()
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.FICHEROSTableAdapter.UpdateFicheroValues(_fecha, _nombre, _descrip, fId)
                    If _nombre <> fnombreo Then

                        ''Impersonar al usuario segun su carpeta compartida
                        'If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                        '    Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                        '                                                Globales.Configuracion.CarpetaCompartidaPassword, _
                        '                                                Globales.Configuracion.CarpetaCompartidaDominio)
                        'End If

                        ''Operacion a realizar con las credenciales almacenadas
                        'File.Copy(fcompletename, Globales.Configuracion.dirfiles + "\" + _nombre, True)
                        ''Desacher la impersonacion
                        'If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                        '    If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                        '        GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                        '    End If
                        'End If


                        Dim fsOrigen As New FileStream(fcompletename, FileMode.Open)
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

                            fsDestino = New FileStream(Globales.Configuracion.dirfiles + "\" + _nombre, FileMode.Create)
                            fsDestino.Write(arr, 0, arr.Length)

                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
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


                        'fs.rea()

                    End If
                End If
            Else
                If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.FICHEROSTableAdapter.InsertFichero(_fecha, _nombre, _descrip)

                    ''Impersonar al usuario segun su carpeta compartida
                    'If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                    '    Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                    '                                                Globales.Configuracion.CarpetaCompartidaPassword, _
                    '                                                Globales.Configuracion.CarpetaCompartidaDominio)
                    'End If

                    ''Operacion a realizar con las credenciales almacenadas

                    'File.Copy(fcompletename, Globales.Configuracion.dirfiles + "\" + _nombre, True)

                    ''Desacher la impersonacion
                    'If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                    '    If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                    '        GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                    '    End If
                    'End If


                    Dim fsOrigen As New FileStream(fcompletename, FileMode.Open)
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

                        fsDestino = New FileStream(Globales.Configuracion.dirfiles + "\" + _nombre, FileMode.Create)
                        fsDestino.Write(arr, 0, arr.Length)

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
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


                    'fs.rea()

                End If
            End If
            Me.FICHEROSTableAdapter.Fill(CMDataSet.FICHEROS)


        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _nombre As String = tb_nombrefichero.Text.Trim()
            Dim _fecha As Date = dtp_fechafichero.Value.Date
            Dim _descrip As String = tb_descripcionfichero.Text.Trim()
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                Me.FICHEROSTableAdapter.UpdateFicheroValues(_fecha, _nombre, _descrip, fId)
                If _nombre <> fnombreo Then
                    ''Impersonar al usuario segun su carpeta compartida
                    'If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                    '    Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                    '                                                Globales.Configuracion.CarpetaCompartidaPassword, _
                    '                                                Globales.Configuracion.CarpetaCompartidaDominio)
                    'End If

                    ''Operacion a realizar con las credenciales almacenadas
                    'File.Copy(fcompletename, Globales.Configuracion.dirfiles + "\" + _nombre, True)
                    ''Desacher la impersonacion
                    'If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                    '    If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                    '        GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                    '    End If
                    'End If


                    Dim fsOrigen As New FileStream(fcompletename, FileMode.Open)
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

                        fsDestino = New FileStream(Globales.Configuracion.dirfiles + "\" + _nombre, FileMode.Create)
                        fsDestino.Write(arr, 0, arr.Length)

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
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


                    'fs.rea()
                End If
            Else
                Me.FICHEROSTableAdapter.InsertFichero(_fecha, _nombre, _descrip)
                ''Impersonar al usuario segun su carpeta compartida
                'If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                '    Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                '                                                Globales.Configuracion.CarpetaCompartidaPassword, _
                '                                                Globales.Configuracion.CarpetaCompartidaDominio)
                'End If

                ''Operacion a realizar con las credenciales almacenadas
                'File.Copy(fcompletename, Globales.Configuracion.dirfiles + "\" + _nombre, True)
                ''Desacher la impersonacion
                'If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                '    If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                '        GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                '    End If
                'End If

                Dim fsOrigen As New FileStream(fcompletename, FileMode.Open)
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

                    fsDestino = New FileStream(Globales.Configuracion.dirfiles + "\" + _nombre, FileMode.Create)
                    fsDestino.Write(arr, 0, arr.Length)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
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


                'fs.rea()

            End If
            Me.FICHEROSTableAdapter.Fill(CMDataSet.FICHEROS)
            clickaccept = True
            Me.Close()
        End If
    End Sub
End Class