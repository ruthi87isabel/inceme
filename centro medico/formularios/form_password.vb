
Public Class form_password
    Dim cant As Integer = 0
    Public _Idusuario As Integer = -1
    Public diaNoValido As Boolean = False
    Dim mouse_is_down As Boolean = False
    Dim mouse_pos As Point

    Private Sub form_password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tb_user.Focus()
        cant = 0
        lbl_Version.Text = Application.ProductVersion
        Dim a As New CMLinqDataContext

        lbl_Version.Parent = PictureBox1
        Label1.Parent = PictureBox1
        LbUsuario.Parent = PictureBox1
        LbContraseña.Parent = PictureBox1
        Label2.Parent = PictureBox1

        Try
            a.Connection.Open()
            a.Connection.Close()
        Catch ex As SqlClient.SqlException
            Dim frmConexion As New frmConnectionDB
            If frmConexion.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                MsgBox("La aplicación se cerrará para aplicar los cambios. Vuelva a entrar en la aplicación", MsgBoxStyle.Information & vbOK)
                Application.Exit()
            End If
        End Try
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        'Try
        lbl_Contrasenna.Visible = False

        Dim user As String
        Dim contrasena As String
        user = tb_user.Text.Trim()
        contrasena = tb_contrasena.Text.Trim()

        Dim context As New CMLinqDataContext()

       
        Try
            Dim usuario As USUARIO = (From u In context.USUARIOs _
                                     Where u.USUARIO = user _
                                     And u.CONTRASENA = contrasena
                                     Select u).SingleOrDefault()
            If Not usuario Is Nothing Then
                _Idusuario = usuario.CODIGO

                If usuario.REFMEDICO.HasValue Then

                    If CalendarioManager.DameTipoDiaDe(usuario.REFMEDICO, Now) <> ctrlHorarios.TipoFecha.DiasLaborables Then
                        If usuario.EsAdministrador() Then
                            'MessageBox.Show("Este dia es no laborable para este usuario. Podrá acceder solo debido a su rol de administrador")
                        Else

                            diaNoValido = True
                            'Return
                        End If
                    End If
                Else
                    'No es medico revisemos su calendario de USUARIO
                    If CalendarioManager.DameTipoDiaDeUsuario(usuario.CODIGO, Now) <> ctrlHorarios.TipoFecha.DiasLaborables Then
                        If usuario.EsAdministrador() Then
                            'MessageBox.Show("Este dia es no laborable para este usuario. Podrá acceder solo debido a su rol de administrador")
                        Else

                            dianovalido = True
                            'Return
                        End If
                    End If

                End If
               


                lbl_Contrasenna.Visible = False
                'System.Threading.Thread.Sleep(1000)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                lbl_Contrasenna.Visible = True
                cant = cant + 1
                If cant > 3 Then
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            Globales.ShowError("Error accediendo a la Base de Datos: ", ex)
            Return
        End Try
        


    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub tb_contrasena_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_contrasena.KeyUp
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            bt_aceptar_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        mouse_pos.X = e.X
        mouse_pos.Y = e.Y
        mouse_is_down = True
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If mouse_is_down Then
            Dim current_pos As Point = Control.MousePosition
            current_pos.X = current_pos.X - mouse_pos.X
            current_pos.Y = current_pos.Y - mouse_pos.Y
            Me.Location = current_pos
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        mouse_is_down = False
    End Sub
End Class