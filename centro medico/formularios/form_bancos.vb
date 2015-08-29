Public Class form_bancos
    Dim fcurrentAcc As Integer
    Dim fId As String
    Dim clickaccept As Boolean = False
    Dim ftlfno1o As String
    Dim fnotao As String
    Dim fnameo As String
    Dim ftlfno2o As String
    Dim ffaxo As String
    Dim fmailo As String
    Dim fdirecciono As String
    Dim fentidado As String
    Dim flocalidado As String
    Dim fcpo As String
    Dim foficinao As String
    Dim fprovinciao As String
    Dim fwebo As String
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName


    End Sub
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aEntity As String, ByVal aOffice As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fentidado = aEntity
        Me.foficinao = aOffice


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
    Private Sub BANCOSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BANCOSBindingSource.EndEdit()
        Me.BANCOSTableAdapter.Update(Me.CMDataSet.BANCOS)

    End Sub
    Private Sub Inicializa()
        Dim _data As CMDataSet.BANCOSDataTable = Me.BANCOSTableAdapter.GetBancoByKey(fentidado, foficinao)
        fnameo = _data.Rows(0).Item("NOMBRE").ToString()
        fdirecciono = _data.Rows(0).Item("DIRECCION").ToString()
        fentidado = _data.Rows(0).Item("ENTIDAD").ToString()
        ftlfno1o = _data.Rows(0).Item("TLFNO1").ToString()
        ftlfno2o = _data.Rows(0).Item("TLFNO2").ToString()
        fmailo = _data.Rows(0).Item("EMAIL").ToString()
        fcpo = _data.Rows(0).Item("CP").ToString()
        flocalidado = _data.Rows(0).Item("LOCALIDAD").ToString()
        foficinao = _data.Rows(0).Item("OFICINA").ToString()
        fprovinciao = _data.Rows(0).Item("PROVINCIA").ToString()
        fwebo = _data.Rows(0).Item("WEB").ToString()
        fnotao = _data.Rows(0).Item("NOTAS").ToString()
        ffaxo = _data.Rows(0).Item("FAX").ToString()
        fId = _data.Rows(0).Item("ID").ToString()

        tb_direccion.Text = fdirecciono
        tb_tel1.Text = ftlfno1o
        tb_tel2.Text = ftlfno2o
        tb_mail.Text = fmailo
        tb_localidad.Text = flocalidado
        tb_provincia.Text = fprovinciao
        tb_cp.Text = fcpo
        tb_oficina.Text = foficinao
        tb_web.Text = fwebo
        tb_notas.Text = fnotao
        tb_nombre.Text = fnameo
        tb_fax.Text = ffaxo
        tb_entidad.Text = fentidado

    End Sub
    Private Sub form_bancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then

            Inicializa()
            tb_direccion.ReadOnly = True
            tb_tel1.ReadOnly = True
            tb_tel2.ReadOnly = True
            tb_mail.ReadOnly = True
            tb_localidad.ReadOnly = True
            tb_provincia.ReadOnly = True
            tb_cp.ReadOnly = True
            tb_oficina.ReadOnly = True
            tb_web.ReadOnly = True
            tb_entidad.ReadOnly = True
            tb_notas.ReadOnly = True
            tb_nombre.ReadOnly = True
            tb_fax.ReadOnly = True

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_bancos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _tlfno1 As String = tb_tel1.Text.Trim()
            Dim _nota As String = tb_notas.Text.Trim()
            Dim _name As String = tb_nombre.Text.Trim()
            Dim _tlfno2 As String = tb_tel2.Text.Trim()
            Dim _fax As String = tb_fax.Text.Trim()
            Dim _mail As String = tb_mail.Text.Trim()
            Dim _direccion As String = tb_direccion.Text.Trim()
            Dim _oficina As String = tb_oficina.Text.Trim()
            Dim _localidad As String = tb_localidad.Text.Trim()
            Dim _cp As String = tb_cp.Text.Trim()
            Dim _entidad As String = tb_entidad.Text.Trim()
            Dim _provincia As String = tb_provincia.Text.Trim()
            Dim _web As String = tb_web.Text.Trim()
            If _oficina <> "" And _entidad <> "" Then
                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.BANCOSTableAdapter.Update1(_name, _direccion, _localidad, _provincia, _cp, _tlfno1, _tlfno2, _fax, _entidad, _oficina, _nota, _mail, _web, fId, fentidado, foficinao)
                    End If
                Else
                    If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.BANCOSTableAdapter.Insert(_name, _direccion, _localidad, _provincia, _cp, _tlfno1, _tlfno2, _fax, _entidad, _oficina, _nota, _mail, _web, fId)

                    End If
                End If
                Me.BANCOSTableAdapter.Fill(CMDataSet.BANCOS)
            Else
                MessageBox.Show("Debe introducir una oficina y entidad para definir el banco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _tlfno1 As String = tb_tel1.Text.Trim()
            Dim _nota As String = tb_notas.Text.Trim()
            Dim _name As String = tb_nombre.Text.Trim()
            Dim _tlfno2 As String = tb_tel2.Text.Trim()
            Dim _fax As String = tb_fax.Text.Trim()
            Dim _mail As String = tb_mail.Text.Trim()
            Dim _direccion As String = tb_direccion.Text.Trim()
            Dim _oficina As String = tb_oficina.Text.Trim()
            Dim _localidad As String = tb_localidad.Text.Trim()
            Dim _cp As String = tb_cp.Text.Trim()
            Dim _entidad As String = tb_entidad.Text.Trim()
            Dim _provincia As String = tb_provincia.Text.Trim()
            Dim _web As String = tb_web.Text.Trim()
            If _entidad <> "" And _oficina <> "" Then
                If Me.CurrentAccion = Enums.Accion.Modificar Then

                    Me.BANCOSTableAdapter.Update1(_name, _direccion, _localidad, _provincia, _cp, _tlfno1, _tlfno2, _fax, _entidad, _oficina, _nota, _mail, _web, fId, fentidado, foficinao)

                Else

                    Me.BANCOSTableAdapter.Insert(_name, _direccion, _localidad, _provincia, _cp, _tlfno1, _tlfno2, _fax, _entidad, _oficina, _nota, _mail, _web, fId)


                End If
                Me.BANCOSTableAdapter.Fill(CMDataSet.BANCOS)
                clickaccept = True
                Me.Close()
            Else
                MessageBox.Show("Debe introducir una oficina y entidad para poder definir el banco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class