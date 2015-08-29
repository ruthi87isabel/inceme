Imports centro_medico
Imports System.IO
Imports Microsoft.VisualBasic

Public Class frmFicherosAdjuntos_ADD

    Public CODIGO As Integer = -1

    Public IDPaciente As Integer
    Public IDSeccion As Nullable(Of Integer)
    Public Tag1 As Nullable(Of Integer)
    Public Tag2 As Nullable(Of Integer)


    Private Fichero As FICHERO

    Dim context As CMLinqDataContext

    Private UserCancelled As Boolean = False

    Private Sub frmFicherosAdjuntos_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        context = New CMLinqDataContext()
        Try

        

            If CODIGO = -1 Then
                Fichero = New FICHERO()
                Fichero.REFPACIENTE = IDPaciente
                Fichero.IDSECCION = IDSeccion
                Fichero.TAG1 = Tag1
                Fichero.TAG2 = Tag2
            Else
                Fichero = (From f In context.FICHEROs Where f.CODIGO = CODIGO Select f).SingleOrDefault()
                FICHEROBindingSource.DataSource = Fichero
                bt_FiBuscar.Enabled = False
                tb_FiNombre.Enabled = False
                dtp_FiFechacreacion.Enabled = False
                'dtp_FiUltimamodificacion.Enabled = False

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bt_FiAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_FiAceptar.Click

        If CODIGO = -1 Then context.FICHEROs.InsertOnSubmit(Fichero)

        If tb_FiDescripcion.Text = String.Empty Then
            MessageBox.Show("Descripción del fichero requerida")
            tb_FiDescripcion.Focus()
            Return
        End If

        If tb_FiNombre.Text = String.Empty Then
            MessageBox.Show("Se requiere un fichero")
            tb_FiDescripcion.Focus()
            Return
        End If

        'Aqui debo copiar el fichero de su posicion original a la carpeta compartida

        If CODIGO = -1 Then

            Dim source As New GoltraTools.Origen()
            Dim target As New GoltraTools.Destination()

            Try
                'Si el boton buscar esta activado significa que es nuevo el fichero adjunto
                If bt_FiBuscar.Enabled Then
                    If Me.lblPathOriginalFIchero.Text.Trim.Length > 0 Then



                        source.FileName = lblPathOriginalFIchero.Text & "\" & tb_FiNombre.Text
                        source.UseCredentials = False

                        target.FileName = Globales.Configuracion.dirfiles & "\" & tb_FiNombre.Text
                        target.Username = Globales.Configuracion.CarpetaCompartidaUsuario
                        target.Password = Globales.Configuracion.CarpetaCompartidaPassword
                        target.Domain = Globales.Configuracion.CarpetaCompartidaDominio
                        target.UseCredentials = Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida

                        Dim copier As New GoltraTools.FileCopier()


                        copier.CopiarFicheroAsincrono(source, target, _
                                                      New GoltraTools.FileCopier.CopyingFileResultDelegate(AddressOf CopyTerminated), False)


                    End If

                End If

                If Not UserCancelled Then
                    tb_FiNombre.Text = Path.GetFileName(target.FileName)
                    Fichero.FICHERO = Path.GetFileName(target.FileName)
                    Fichero.FECHA = dtp_FiFechacreacion.Value
                    Fichero.FECHAMODIFICACION = dtp_FiUltimamodificacion.Value
                    If Me.chkConsentimiento.Checked Then
                        Fichero.ESCONSENTIMIENTO = True
                    Else
                        Fichero.ESCONSENTIMIENTO = False
                    End If

                    FICHEROBindingSource.EndEdit()
                    context.SubmitChanges()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If




            Catch ex As Exception
                MessageBox.Show("Error copiando: " & ex.Message)
                Return
            End Try

        Else
            'Fichero.FICHERO = Path.GetFileName(target.FileName)
            FICHEROBindingSource.EndEdit()
            context.SubmitChanges()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If


    End Sub

    Private Sub CopyTerminated(ByVal res As DialogResult)
        If res = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("Copia cancelada por el usuario")
            UserCancelled = True
        Else
            UserCancelled = False
        End If

    End Sub


    Private Sub bt_FiBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_FiBuscar.Click
        Dim fd As New OpenFileDialog()
        If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tb_FiNombre.Text = System.IO.Path.GetFileName(fd.FileName)

            Fichero.DESCRIPCION = System.IO.Path.GetFileNameWithoutExtension(fd.FileName)
            tb_FiDescripcion.Text = Fichero.DESCRIPCION
            Fichero.FICHERO = System.IO.Path.GetFileName(fd.FileName)

            lblPathOriginalFIchero.Text = System.IO.Path.GetDirectoryName(fd.FileName)
            lblPathOriginalFIchero.Visible = True
            Fichero.FECHA = Date.Now
            Fichero.FECHAMODIFICACION = Date.Now
        End If
    End Sub

    Private Sub bt_FiCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_FiCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class