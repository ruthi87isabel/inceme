Public Class form_proveedores

    Dim fcurrentAcc As Integer
    Dim fId As String
    Dim ftlfno1o As String
    Dim fnotao As String
    Dim fnameo As String
    Dim ftlfno2o As String
    Dim ffaxo As String
    Dim fmailo As String
    Dim fdirecciono As String
    Dim fcontactoo As String
    Dim fpoblaciono As String
    Dim fcpo As String
    Dim fCIFo As String
    Dim fprovinciao As String
    Dim fwebo As String
    Dim clickaccept As Boolean = False
    Private Sub PROVEEDORESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PROVEEDORESBindingSource.EndEdit()
        Me.PROVEEDORESTableAdapter.Update(Me.CMDataSet.PROVEEDORES)

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
    Private Sub Inicializa()
        Dim _data As CMDataSet.PROVEEDORESDataTable = Me.PROVEEDORESTableAdapter.GetProveedorById(fId)
        fnameo = _data.Rows(0).Item("NOMBRE").ToString()
        fdirecciono = _data.Rows(0).Item("DIRECCION").ToString()
        ftlfno1o = _data.Rows(0).Item("TLFNO1").ToString()
        ftlfno2o = _data.Rows(0).Item("TLFNO2").ToString()
        fmailo = _data.Rows(0).Item("MAIL").ToString()
        fcpo = _data.Rows(0).Item("CP").ToString()
        fpoblaciono = _data.Rows(0).Item("POBLACION").ToString()
        fCIFo = _data.Rows(0).Item("CIF").ToString()
        fprovinciao = _data.Rows(0).Item("PROVINCIA").ToString()
        fwebo = _data.Rows(0).Item("WEB").ToString()
        fnotao = _data.Rows(0).Item("NOTAS").ToString()
        ffaxo = _data.Rows(0).Item("FAX").ToString()
        fcontactoo = _data.Rows(0).Item("PERSONACON").ToString()

        tb_direccion.Text = fdirecciono
        tb_tel1.Text = ftlfno1o
        tb_tel2.Text = ftlfno2o
        tb_mail.Text = fmailo
        tb_poblacion.Text = fpoblaciono
        tb_provincia.Text = fprovinciao
        tb_cp.Text = fcpo
        tb_CIF.Text = fCIFo
        tb_web.Text = fwebo
        tb_notas.Text = fnotao
        tb_nombre.Text = fnameo
        tb_fax.Text = ffaxo
        tb_contacto.Text = fcontactoo
        tb_cod.Text = fId.ToString()

    End Sub
    Private Sub form_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            tb_provincia.ReadOnly = True
            tb_cp.ReadOnly = True
            tb_CIF.ReadOnly = True
            tb_web.ReadOnly = True
            tb_notas.ReadOnly = True
            tb_nombre.ReadOnly = True
            tb_fax.ReadOnly = True
            tb_contacto.ReadOnly = True
            tb_cod.ReadOnly = True

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If

    End Sub

    Private Sub form_proveedores_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _tlfno1 As String = tb_tel1.Text.Trim()
            Dim _nota As String = tb_notas.Text.Trim()
            Dim _name As String = tb_nombre.Text.Trim()
            Dim _tlfno2 As String = tb_tel2.Text.Trim()
            Dim _fax As String = tb_fax.Text.Trim()
            Dim _mail As String = tb_mail.Text.Trim()
            Dim _direccion As String = tb_direccion.Text.Trim()
            Dim _contacto As String = tb_contacto.Text.Trim()
            Dim _poblacion As String = tb_poblacion.Text.Trim()
            Dim _cp As String = tb_cp.Text.Trim()
            Dim _CIF As String = tb_CIF.Text.Trim()
            Dim _provincia As String = tb_provincia.Text.Trim()
            Dim _web As String = tb_web.Text.Trim()
            Dim _cod As String = tb_cod.Text.Trim()
            Dim tId As Integer
            If _cod <> "" Then
                'Try
                tId = Integer.Parse(tb_cod.Text.Trim())
                'Catch ex As Exception
                MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
                'End 'Try

                If _cod = 0 Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If
            Dim tId1 As Integer = 0

            If fId <> Nothing Then
                Integer.TryParse(fId, tId1)
            End If
            If _cod <> "" Then
                Dim _data As CMDataSet.PROVEEDORESDataTable = Me.PROVEEDORESTableAdapter.GetProveedorById(tId)

                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.PROVEEDORESTableAdapter.UpdateValores(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, tId, _CIF, tId1)
                    End If
                Else
                    If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        If _data.Rows.Count = 0 Then
                            Me.PROVEEDORESTableAdapter.Insert(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, tId, _CIF)
                        Else
                            MessageBox.Show("Un proveedor con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            tb_cod.Clear()
                            Return
                        End If
                    End If
                End If

                Me.PROVEEDORESTableAdapter.Fill(CMDataSet.PROVEEDORES)
            Else
                If MessageBox.Show("Esta seguro que desea intoducir los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    MessageBox.Show("Debe entrar un codigo válido para poder ser definido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
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
            Dim _contacto As String = tb_contacto.Text.Trim()
            Dim _poblacion As String = tb_poblacion.Text.Trim()
            Dim _cp As String = tb_cp.Text.Trim()
            Dim _CIF As String = tb_CIF.Text.Trim()
            Dim _provincia As String = tb_provincia.Text.Trim()
            Dim _web As String = tb_web.Text.Trim()
            Dim _cod As String = tb_cod.Text.Trim()
            Dim tId As Integer
            If _cod <> "" Then
                tId = Integer.Parse(_cod)
            End If
            Dim tId1 As Integer = 0
            If fId <> Nothing Then
                Integer.TryParse(fId, tId1)
            End If
            If _cod <> "" Then
                Dim _data As CMDataSet.PROVEEDORESDataTable = Me.PROVEEDORESTableAdapter.GetProveedorById(tId)

                If Me.CurrentAccion = Enums.Accion.Modificar Then

                    Me.PROVEEDORESTableAdapter.UpdateValores(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, tId, _CIF, tId1)

                Else
                    If _data.Rows.Count = 0 Then
                        Me.PROVEEDORESTableAdapter.Insert(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, tId, _CIF)
                    Else
                        MessageBox.Show("Un proveedor con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_cod.Clear()
                        Return
                    End If
                End If

                Me.PROVEEDORESTableAdapter.Fill(CMDataSet.PROVEEDORES)
                clickaccept = True
                Me.Close()
            Else : MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub
    Private Sub ChequearTextboxSoloNumero(ByVal aTexbox As TextBox)
        Dim _text As String = aTexbox.Text
        Dim _number As Single
        Dim _texto As String = ""
        Dim modif As Integer = _text.Length
        If _text <> "" And _text <> Nothing Then
            If _text.Length > 0 Then
                Dim i As Integer
                For i = 0 To _text.Length - 1
                    If Not Integer.TryParse(_text(i), _number) Then
                        modif = i
                        Continue For
                    Else
                        _texto = _texto + _text(i)
                    End If

                Next
                aTexbox.Text = _texto

            End If
        End If
        If modif <> _text.Length Then
            aTexbox.SelectionStart = modif
        End If
    End Sub
    Private Sub tb_cod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_cod.TextChanged
        ChequearTextboxSoloNumero(tb_cod)
    End Sub
End Class