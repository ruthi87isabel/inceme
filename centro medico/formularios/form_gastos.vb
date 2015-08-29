Public Class form_gastos
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim clickaccept As Boolean = False
    Dim fconceptoo As String
    Dim fimporteo As Single
    Dim ffechao As Date
    Dim ffcodo As String

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
    Private Function GetFormaPago(ByVal aId As String) As String

        Dim _data As CMDataSet.FORMASPAGODataTable = Me.FORMASPAGOTableAdapter.GetFormasPagoById(aId)
        Dim _proveedor As String = ""
        If _data.Rows.Count > 0 Then
            _proveedor = _data.Rows(0).Item("DESCRIPCION").ToString()
        End If

        Return _proveedor

    End Function
    Private Sub Inicializa()
        Dim _data As CMDataSet.GASTOSDataTable = Me.GASTOSTableAdapter.GetGastoById(fId)
        fconceptoo = _data.Rows(0).Item("CONCEPTO").ToString()
        If _data.Rows(0).Item("REFFORMAPAGO").GetType().ToString() <> DBNull.Value.GetType.ToString() Then
            ffcodo = _data.Rows(0).Item("REFFORMAPAGO")
            tb_idforma.Text = ffcodo.ToString()
            tb_forma.Text = GetFormaPago(ffcodo)
        End If
        If _data.Rows(0).Item("IMPORTE").GetType().ToString() <> DBNull.Value.GetType.ToString() Then
            fimporteo = _data.Rows(0).Item("IMPORTE")
        End If
        If _data.Rows(0).Item("FECHA").GetType().ToString() <> DBNull.Value.GetType.ToString() Then
            ffechao = _data.Rows(0).Item("FECHA")
        Else
            ffechao = Date.Now
        End If

        tb_concepto.Text = fconceptoo.ToString()
        tb_importe.Text = String.Format("{0:N}", (fimporteo))
        dtp_fecha.Value = ffechao


    End Sub
    Private Sub GASTOSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GASTOSBindingSource.EndEdit()
        Me.GASTOSTableAdapter.Update(Me.CMDataSet.GASTOS)

    End Sub

    Private Sub form_gastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()

        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_idforma.ReadOnly = True
            tb_concepto.ReadOnly = True
            tb_importe.ReadOnly = True
            bt_forma.Enabled = False
            tb_forma.ReadOnly = True
            dtp_fecha.Enabled = False
            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"

        End If


    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub dtp_fecha_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_importe.Enter, tb_forma.Enter, tb_concepto.Enter, dtp_fecha.Enter, bt_aceptar.Enter
        If tb_idforma.Text <> Nothing And tb_idforma.Text <> "" Then
            Dim _id As String = tb_idforma.Text.Trim()
            tb_forma.Text = GetFormaPago(_id)
        End If
    End Sub

    Private Sub bt_forma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_forma.Click
        Me.FORMASPAGOTableAdapter.Fill(Me.CMDataSet.FORMASPAGO)
        Dim _name As String = "Listado de Formas de pago"
        Dim _listados As form_listados = New form_listados(_name, FORMASPAGOBindingSource, RoleManager.Items.Formas_de_Pago, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _fcodo As String = _listados.Selected()
            tb_idforma.Text = _fcodo.ToString()
            tb_forma.Text = GetFormaPago(_fcodo)
        End If
    End Sub

    Private Sub form_gastos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _importe As Single
            If tb_importe.Text <> "" Then
                _importe = Single.Parse(tb_importe.Text.Trim())
            End If
            Dim _concepto As String = tb_concepto.Text.Trim()
            Dim _fcod As String = tb_idforma.Text.Trim()
            Dim _fecha As Date = dtp_fecha.Value.Date
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If _fcod <> "" Then
                        Me.GASTOSTableAdapter.UpdateValores(_concepto, _importe, _fecha, _fcod, fId)
                    Else
                        Me.GASTOSTableAdapter.UpdateSinForma(_concepto, _importe, _fecha, fId)
                    End If
                End If
            Else
                If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If _fcod <> "" Then
                        Me.GASTOSTableAdapter.Insert(_concepto, _importe, _fecha, _fcod)
                    Else
                        Me.GASTOSTableAdapter.InsertSinForma(_concepto, _importe, _fecha)
                    End If

                End If
            End If
            Me.GASTOSTableAdapter.Fill(CMDataSet.GASTOS)

        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _importe As Single
            If tb_importe.Text <> "" Then
                _importe = Single.Parse(tb_importe.Text.Trim())
            End If
            Dim _concepto As String = tb_concepto.Text.Trim()
            Dim _fcod As String = tb_idforma.Text.Trim()
            Dim _fecha As Date = dtp_fecha.Value.Date
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If _fcod <> "" Then
                    Me.GASTOSTableAdapter.UpdateValores(_concepto, _importe, _fecha, _fcod, fId)
                Else
                    Me.GASTOSTableAdapter.UpdateSinForma(_concepto, _importe, _fecha, fId)
                End If
            Else
                If _fcod <> "" Then
                    Me.GASTOSTableAdapter.Insert(_concepto, _importe, _fecha, _fcod)
                Else
                    Me.GASTOSTableAdapter.InsertSinForma(_concepto, _importe, _fecha)
                End If

            End If
            Me.GASTOSTableAdapter.Fill(CMDataSet.GASTOS)
            clickaccept = True
            Me.Close()
        End If
    End Sub
    Private Sub ChequearTextboxSoloNumero(ByVal aTexbox As TextBox)
        Dim _text As String = aTexbox.Text
        Dim _number As Single
        Dim _texto As String = ""
        Dim modif As Integer = _text.Length
        Dim cant As Integer = 0
        If _text <> "" And _text <> Nothing Then
            If _text.Length > 0 Then
                Dim i As Integer
                For i = 0 To _text.Length - 1
                    If Not Single.TryParse(_text(i), _number) And _text(i) <> "," Then
                        modif = i
                        Continue For
                    Else
                        If _text(i) = "," And cant = 1 Then
                            modif = i
                            Continue For
                        ElseIf _text(i) = "," Then
                            cant = 1
                        End If
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
    Private Sub tb_importe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_importe.TextChanged
        ChequearTextboxSoloNumero(tb_importe)
    End Sub

    Private Sub tb_idforma_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_idforma.Leave
        If tb_idforma.Text <> "" Then
            Dim _pcodo As String = tb_idforma.Text
            Dim data As CMDataSet.FORMASPAGODataTable = FORMASPAGOTableAdapter.GetFormasPagoById(_pcodo)
            If data.Rows.Count > 0 Then
                tb_forma.Text = GetFormaPago(_pcodo)
            Else
                tb_idforma.Text = ""
                tb_idforma.Focus()
                MessageBox.Show("No existe una forma de pago con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class