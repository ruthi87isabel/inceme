Public Class form_articulos
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim clickaccept As Boolean = False
    Dim fdescripciono As String
    Dim fpcodo As Integer
    Dim fprovo As String
    Dim fstocko As Integer
    Dim fminstocko As Integer
    Dim fnotaso As String
    Dim ffechao As Date

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

    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName


    End Sub
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer)

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
    Private Sub ARTICULOSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ARTICULOSBindingSource.EndEdit()
        Me.ARTICULOSTableAdapter.Update(Me.CMDataSet.ARTICULOS)

    End Sub
    Private Function GetProveedor(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PROVEEDORESDataTable = Me.PROVEEDORESTableAdapter.GetProveedorById(aId)
        Dim _proveedor As String = _data.Rows(0).Item("NOMBRE").ToString()
        Return _proveedor

    End Function
    Private Sub Inicializa()
        Dim _data As CMDataSet.ARTICULOSDataTable = Me.ARTICULOSTableAdapter.GetArticuloById(fId)
        fdescripciono = _data.Rows(0).Item("DESCRIPCION").ToString()
        If _data.Rows(0).Item("REFPROVEEDOR").GetType.ToString() <> DBNull.Value.GetType.ToString Then
            fpcodo = _data.Rows(0).Item("REFPROVEEDOR")
            tb_pcod.Text = fpcodo.ToString()
            tb_proveedor.Text = GetProveedor(fpcodo)
        End If
        If _data.Rows(0).Item("STOCK").GetType.ToString() <> DBNull.Value.GetType.ToString Then
            fstocko = _data.Rows(0).Item("STOCK")
        End If
        If _data.Rows(0).Item("STOCKMIN").GetType.ToString() <> DBNull.Value.GetType.ToString Then
            fminstocko = _data.Rows(0).Item("STOCKMIN")
        End If
        fnotaso = _data.Rows(0).Item("NOTAS").ToString()
        If _data.Rows(0).Item("FECHA").GetType.ToString() <> DBNull.Value.GetType.ToString Then
            ffechao = _data.Rows(0).Item("FECHA")
        Else
            ffechao = Date.Now
        End If
        tb_cod.Text = fId.ToString()
        tb_descipc.Text = fdescripciono.ToString()
        tb_stock.Text = fstocko.ToString()
        tb_minstock.Text = fminstocko.ToString()
        tb_notas.Text = fnotaso
        dtp_fecha.Value = ffechao


    End Sub

    Private Sub form_articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()

        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_cod.ReadOnly = True
            tb_descipc.ReadOnly = True
            tb_stock.ReadOnly = True
            tb_minstock.ReadOnly = True
            tb_notas.ReadOnly = True
            bt_proveedor.Enabled = False
            tb_pcod.ReadOnly = True
            dtp_fecha.Enabled = False
            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"

        End If

    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_articulos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _cod As Integer
            Dim _pcod As Integer
            Dim _stock As Integer
            Dim _minstock As Integer
            If tb_cod.Text <> "" Then
                'Try
                _cod = Integer.Parse(tb_cod.Text.Trim())
                'Catch ex As Exception
                MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
                'End 'Try

                If _cod = 0 Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If
            Dim _descripcion As String = tb_descipc.Text.Trim()

            If tb_stock.Text <> "" Then
                _stock = Integer.Parse(tb_stock.Text.Trim())

            End If
            If tb_minstock.Text <> "" Then
                _minstock = Integer.Parse(tb_minstock.Text.Trim())

            End If
            Dim _notas As String = tb_notas.Text.Trim()
            Dim _fecha As Date = dtp_fecha.Value.Date
            If _cod.ToString() <> "" Then
                Dim _data As CMDataSet.ARTICULOSDataTable = Me.ARTICULOSTableAdapter.GetArticuloById(_cod)

                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        If tb_pcod.Text <> "" Then
                            _pcod = Integer.Parse(tb_pcod.Text.Trim())
                            Me.ARTICULOSTableAdapter.UpdateValores(_cod, _descripcion, _pcod, _stock, _minstock, _fecha, _notas, fId)
                        Else
                            Me.ARTICULOSTableAdapter.UpdateSinProv(_cod, _descripcion, _stock, _minstock, _fecha, _notas, fId)

                        End If
                    Else
                        If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                            If _data.Rows.Count = 0 Then
                                If tb_pcod.Text <> "" Then
                                    _pcod = Integer.Parse(tb_pcod.Text.Trim())
                                    Me.ARTICULOSTableAdapter.Insert(_cod, _descripcion, _pcod, _stock, _minstock, _fecha, _notas)
                                Else
                                    Me.ARTICULOSTableAdapter.InsertSinProv(_cod, _descripcion, _stock, _minstock, _fecha, _notas)
                                End If

                            Else
                                MessageBox.Show("Un articulo con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                tb_cod.Clear()
                                Return
                            End If
                        End If
                    End If

                    Me.ARTICULOSTableAdapter.Fill(CMDataSet.ARTICULOS)

                Else
                    If MessageBox.Show("Esta seguro que desea introducir los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        MessageBox.Show("Debe introducir un codigo para poder definir el articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _cod As Integer
            Dim _pcod As Integer
            Dim _stock As Integer
            Dim _minstock As Integer
            If tb_cod.Text <> "" Then
                Try
                    _cod = Integer.Parse(tb_cod.Text.Trim())
                Catch ex As Exception
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                If _cod = 0 Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If
            Dim _descripcion As String = tb_descipc.Text.Trim()

            If tb_stock.Text <> "" Then
                _stock = Integer.Parse(tb_stock.Text.Trim())
            End If
            If tb_minstock.Text <> "" Then
                _minstock = Integer.Parse(tb_minstock.Text.Trim())
            End If
            Dim _notas As String = tb_notas.Text.Trim()
            Dim _fecha As Date = dtp_fecha.Value.Date
            If tb_cod.Text.ToString() <> "" Then
                Dim _data As CMDataSet.ARTICULOSDataTable = Me.ARTICULOSTableAdapter.GetArticuloById(_cod)

                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If tb_pcod.Text <> "" Then
                        _pcod = Integer.Parse(tb_pcod.Text.Trim())
                        Me.ARTICULOSTableAdapter.UpdateValores(_cod, _descripcion, _pcod, _stock, _minstock, _fecha, _notas, fId)
                    Else
                        Me.ARTICULOSTableAdapter.UpdateSinProv(_cod, _descripcion, _stock, _minstock, _fecha, _notas, fId)

                    End If

                Else
                    If _data.Rows.Count = 0 Then
                        If tb_pcod.Text <> "" Then
                            _pcod = Integer.Parse(tb_pcod.Text.Trim())
                            Me.ARTICULOSTableAdapter.Insert(_cod, _descripcion, _pcod, _stock, _minstock, _fecha, _notas)
                        Else
                            Me.ARTICULOSTableAdapter.InsertSinProv(_cod, _descripcion, _stock, _minstock, _fecha, _notas)
                        End If

                    Else
                        MessageBox.Show("Un articulo con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_cod.Clear()
                        Return
                    End If
                End If

                Me.ARTICULOSTableAdapter.Fill(CMDataSet.ARTICULOS)
                clickaccept = True
                Me.Close()
            Else
                MessageBox.Show("Debe introducir un codigo para poder definir el articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub


    Private Sub bt_aceptar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_stock.Enter, tb_proveedor.Enter, tb_pcod.Enter, tb_notas.Enter, tb_minstock.Enter, tb_descipc.Enter, tb_cod.Enter, dtp_fecha.Enter, bt_aceptar.Enter
        If tb_pcod.Text <> Nothing And tb_pcod.Text <> "" Then
            Dim _id As Integer = Integer.Parse(tb_pcod.Text.Trim())
            tb_proveedor.Text = GetProveedor(_id)
        End If
    End Sub

    Private Sub bt_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_proveedor.Click
        Me.PROVEEDORESTableAdapter.Fill(Me.CMDataSet.PROVEEDORES)
        Dim _name As String = "Listado de proveedores"
        Dim _listados As form_listados = New form_listados(_name, PROVEEDORESBindingSource, RoleManager.Items.Proveedores, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            tb_pcod.Text = _pcodo
            tb_proveedor.Text = GetProveedor(_pcodo)

        End If
    End Sub

    Private Sub tb_cod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_cod.TextChanged
        ChequearTextboxSoloNumero(tb_cod)
    End Sub

    Private Sub tb_stock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_stock.TextChanged
        ChequearTextboxSoloNumero(tb_stock)
    End Sub

    Private Sub tb_minstock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_minstock.TextChanged
        ChequearTextboxSoloNumero(tb_minstock)
    End Sub

    Private Sub tb_pcod_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_pcod.Leave
        If tb_pcod.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_pcod.Text)
            Dim data As CMDataSet.PROVEEDORESDataTable = PROVEEDORESTableAdapter.GetProveedorById(_pcodo)
            If data.Rows.Count > 0 Then
                tb_proveedor.Text = GetProveedor(_pcodo)
            Else
                tb_pcod.Text = ""
                tb_pcod.Focus()
                MessageBox.Show("No existe un proveedor con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class