Public Class form_clinicas

    Dim fcurrentAcc As Integer
    Dim fId As String
    Dim ftlfno1o As String
    Dim fdescripco As String
    Dim ftlfno2o As String
    Dim ffaxo As String
    Dim fmailo As String
    Dim fdirecciono As String
    Dim fcontactoo As String
    Dim fpoblaciono As String
    Dim fcpo As String
    Dim fprovinciao As String
    Dim fwebo As String
    Dim clickaccept As Boolean = False
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

    Private Sub Inicializa()
        Dim _data As CMDataSet.DERIVACIONES_DESTINOSDataTable = Me.DERIVACIONES_DESTINOSTableAdapter.GetClinicaById(fId)
        fdescripco = _data.Rows(0).Item("NOMBRE").ToString()
        fdirecciono = _data.Rows(0).Item("DIRECCION").ToString()
        ftlfno1o = _data.Rows(0).Item("TLFNO1").ToString()
        ftlfno2o = _data.Rows(0).Item("TLFNO2").ToString()
        fmailo = _data.Rows(0).Item("MAIL").ToString()
        fcpo = _data.Rows(0).Item("CP").ToString()
        fpoblaciono = _data.Rows(0).Item("POBLACION").ToString()
        fprovinciao = _data.Rows(0).Item("PROVINCIA").ToString()
        fcontactoo = _data.Rows(0).Item("PERSONACION").ToString()
        fwebo = _data.Rows(0).Item("WEB").ToString()
        ffaxo = _data.Rows(0).Item("FAX").ToString()

        tb_direccion.Text = fdirecciono
        tb_tel1.Text = ftlfno1o
        tb_tel2.Text = ftlfno2o
        tb_mail.Text = fmailo
        tb_poblacion.Text = fpoblaciono
        tb_provincia.Text = fprovinciao
        tb_cp.Text = fcpo
        tb_contacto.Text = fcontactoo
        tb_web.Text = fwebo
        tb_descrip.Text = fdescripco
        tb_fax.Text = ffaxo
        tb_codigo.Text = fId
    End Sub

    Private Sub form_clinicas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()

        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_direccion.ReadOnly = True
            tb_tel1.ReadOnly = True
            tb_tel2.ReadOnly = True
            tb_mail.ReadOnly = True
            tb_poblacion.ReadOnly = True
            tb_cp.ReadOnly = True
            tb_descrip.ReadOnly = True
            tb_provincia.ReadOnly = True
            tb_web.ReadOnly = True
            tb_fax.ReadOnly = True
            tb_contacto.ReadOnly = True
            tb_codigo.ReadOnly = True


            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If
    End Sub

   
    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_clinicas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _tlfno1 As String = tb_tel1.Text.Trim()
            Dim _descripc As String = tb_descrip.Text.Trim()
            Dim _tlfno2 As String = tb_tel2.Text.Trim()
            Dim _fax As String = tb_fax.Text.Trim()
            Dim _mail As String = tb_mail.Text.Trim()
            Dim _direccion As String = tb_direccion.Text.Trim()
            Dim _contacto As String = tb_contacto.Text.Trim()
            Dim _poblacion As String = tb_poblacion.Text.Trim()
            Dim _cp As String = tb_cp.Text.Trim()
            Dim _provincia As String = tb_provincia.Text.Trim()
            Dim _web As String = tb_web.Text.Trim()
            Dim _cod As String = tb_codigo.Text.Trim()
            If _cod <> "" Then
                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.DERIVACIONES_DESTINOSTableAdapter.UpdateValores(_descripc, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, "", "", _cod, fId)
                    End If
                Else
                    If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.DERIVACIONES_DESTINOSTableAdapter.Insert(_descripc, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, "", "", _cod)

                    End If
                End If
                Me.DERIVACIONES_DESTINOSTableAdapter.Fill(CMDataSet.DERIVACIONES_DESTINOS)
            Else : MessageBox.Show("Debe introducir un codigo para definir la clinica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _tlfno1 As String = tb_tel1.Text.Trim()
            Dim _descripc As String = tb_descrip.Text.Trim()
            Dim _tlfno2 As String = tb_tel2.Text.Trim()
            Dim _fax As String = tb_fax.Text.Trim()
            Dim _mail As String = tb_mail.Text.Trim()
            Dim _direccion As String = tb_direccion.Text.Trim()
            Dim _contacto As String = tb_contacto.Text.Trim()
            Dim _poblacion As String = tb_poblacion.Text.Trim()
            Dim _cp As String = tb_cp.Text.Trim()
            Dim _provincia As String = tb_provincia.Text.Trim()
            Dim _web As String = tb_web.Text.Trim()
            Dim _cod As String = tb_codigo.Text.Trim()
            If _cod <> "" Then
                If Me.CurrentAccion = Enums.Accion.Modificar Then

                    Me.DERIVACIONES_DESTINOSTableAdapter.UpdateValores(_descripc, _direccion, _cp, _poblacion, _provincia, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, "", "", _cod, fId)

                Else : Me.DERIVACIONES_DESTINOSTableAdapter.Insert(_descripc, _direccion, _cp, _poblacion, _provincia, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, "", "", _cod)

                End If
                Me.DERIVACIONES_DESTINOSTableAdapter.Fill(CMDataSet.DERIVACIONES_DESTINOS)
                clickaccept = True
                Me.Close()
            Else : MessageBox.Show("Debe introducir un codigo para definir la clinica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class