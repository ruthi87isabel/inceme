Imports System.IO

Public Class ctrlFicherosAdjuntos

    Private _idpaciente As Nullable(Of Integer)


#Region "Public Property IDPACIENTE() As Nullable(Of Integer)"
    <System.ComponentModel.Browsable(True)> _
   Public Property IDPACIENTE() As Nullable(Of Integer)
        Get
            If _idpaciente.HasValue Then
                Return _idpaciente
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                _idpaciente = value
                FICHEROSTableAdapter.FillByPaciente(CMDataSet.FICHEROS, value)
                Me.Enabled = True
            Else
                CMDataSet.FICHEROS.Clear()
                Me.Enabled = False
            End If

            If Me.IsHandleCreated Then
                AplicaPermisos()
            End If

        End Set
    End Property
#End Region


    Private Sub btn_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ADD.Click
        Dim _ficheros As form_pac_ficheros_multimedias = New form_pac_ficheros_multimedias("Ficheros y Multimedias - Añadir", Enums.Accion.Insertar, -1, _idpaciente, CMDataSet)
        _ficheros.ShowInTaskbar = False
        _ficheros.ShowDialog()
        FICHEROSBindingSource1.EndEdit()
        FICHEROSTableAdapter.Update(CMDataSet.FICHEROS)
        'FICHEROSTableAdapter.FillByPaciente(CMDataSet.FICHEROS, _idpaciente)
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim fichero As CMDataSet.FICHEROSRow = FICHEROSDataGridView.SelectedRows(0).DataBoundItem.Row
        Dim _ficheros As form_pac_ficheros_multimedias = New form_pac_ficheros_multimedias("Ficheros y Multimedias - Añadir", Enums.Accion.Modificar, fichero.CODIGO, _idpaciente, CMDataSet)
        _ficheros.ShowInTaskbar = False
        _ficheros.ShowDialog()
        FICHEROSBindingSource1.EndEdit()
        FICHEROSTableAdapter.Update(CMDataSet.FICHEROS)
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Dim fichero As CMDataSet.FICHEROSRow = FICHEROSDataGridView.SelectedRows(0).DataBoundItem.Row
        fichero.Delete()
        FICHEROSBindingSource1.EndEdit()
        FICHEROSTableAdapter.Update(CMDataSet.FICHEROS)
    End Sub

    Private Sub FICHEROSDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FICHEROSDataGridView.SelectionChanged
        btn_Edit.Enabled = FICHEROSDataGridView.SelectedRows.Count > 0
        'If Not btn_Edit.Enabled Then
        '    btn_Edit.BackgroundImage = ConvertToGrayscale(My.Resources.Resources._24_tag_pencil)
        'Else
        '    btn_Edit.BackgroundImage = My.Resources.Resources._24_tag_pencil
        'End If
        btn_Eliminar.Enabled = FICHEROSDataGridView.SelectedRows.Count > 0
    End Sub

    Public Function ConvertToGrayscale(ByVal source As Bitmap) As Bitmap
        Dim bm As New Bitmap(source.Width, source.Height)
        Dim x
        Dim y
        For y = 0 To bm.Height - 1
            For x = 0 To bm.Width - 1
                Dim c As Color = source.GetPixel(x, y)
                Dim luma As Integer = CInt(c.R * 0.3 + c.G * 0.59 + c.B * 0.11)
                bm.SetPixel(x, y, Color.FromArgb(luma, luma, luma))
            Next
        Next
        bm.MakeTransparent(source.GetPixel(0, 0))
        Return bm
    End Function

    Private Sub FICHEROSDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FICHEROSDataGridView.CellDoubleClick
        If FICHEROSDataGridView.SelectedRows.Count > 0 Then

            'Impersonar al usuario segun su carpeta compartida
            If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                                                            Globales.Configuracion.CarpetaCompartidaPassword, _
                                                            Globales.Configuracion.CarpetaCompartidaDominio)
            End If

            'Operacion a realizar con las credenciales almacenadas
            'File.Copy(fcompletename, Globals.Configuracion.dirfiles + "\" + _nombre, True)
            Dim fichero As CMDataSet.FICHEROSRow = FICHEROSDataGridView.SelectedRows(0).DataBoundItem.Row
            If File.Exists(Globales.Configuracion.dirfiles & "\" & fichero.FICHERO) Then

                ShowFile(Globales.Configuracion.dirfiles & "\" & fichero.FICHERO)
            End If

            'Deshacer la impersonacion
            If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                    GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                End If
            End If


        End If
    End Sub



    Private Sub ShowFile(ByVal path As String)
        Dim s As String = """" & path & """"
        'ShellExecute(0, vbNullString, s, vbNullString, vbNullString, 1)

        Dim instance As ProcessStartInfo = New ProcessStartInfo(path)
        'instance.UseShellExecute = True
        System.Diagnostics.Process.Start(instance)

    End Sub


    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long

    Private Sub AplicaPermisos()
        FICHEROSDataGridView.ReadOnly = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 2)
        btn_ADD.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 2)
        btn_Edit.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 2)
        btn_Eliminar.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Ficheros_y_Multimedia) > 3)
    End Sub



End Class
