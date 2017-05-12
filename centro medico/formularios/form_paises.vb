Public Class form_paises
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim clickaccept As Boolean = False
    Dim fnameo As String
    Dim fnotaso As String
    Private Sub PAISESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PAISESBindingSource.EndEdit()
        Me.PAISESTableAdapter.Update(Me.CMDataSet.PAISES)

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

    Private Sub Inicializa()
        Dim _data As CMDataSet.PAISESDataTable = Me.PAISESTableAdapter.GetPaisById(fId)
        fnameo = _data.Rows(0).Item("NOMBRE").ToString()
        fnotaso = _data.Rows(0).Item("NOTAS").ToString()
        tb_codigo.Text = fId.ToString()
        tb_nombre.Text = fnameo
        tb_notas.Text = fnotaso
    End Sub
    Private Sub form_paises_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_codigo.ReadOnly = True
            tb_nombre.ReadOnly = True
            tb_notas.ReadOnly = True

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If

    End Sub

    Private Sub form_paises_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _cod As Integer
            If tb_codigo.Text <> "" Then
                'Try
                _cod = Integer.Parse(tb_codigo.Text.Trim())
                'Catch ex As Exception
                MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
                'End 'Try

                If _cod = 0 Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If
            Dim _name As String = tb_nombre.Text.Trim()
            Dim _notas As String = tb_notas.Text.Trim()
            If _cod.ToString() <> "" Then
                Dim _data As CMDataSet.PAISESDataTable = Me.PAISESTableAdapter.GetPaisById(_cod)

                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.PAISESTableAdapter.UpdateValores(_cod, _name, _notas, fId)
                    End If
                Else
                    If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        If _data.Rows.Count = 0 Then
                            Me.PAISESTableAdapter.Insert(_cod, _name, _notas)
                        Else
                            MessageBox.Show("Un pais con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            tb_codigo.Clear()
                            Return
                        End If
                    End If
                End If

                Me.PAISESTableAdapter.Fill(CMDataSet.PAISES)
            Else : MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _cod As Integer
            If tb_codigo.Text <> "" Then
                'Try
                _cod = Integer.Parse(tb_codigo.Text.Trim())
                'Catch ex As Exception
                'MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Return
                ''End 'Try

                If _cod = 0 Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If
            Dim _name As String = tb_nombre.Text.Trim()
            Dim _notas As String = tb_notas.Text.Trim()
            If _cod.ToString() <> "" Then
                Dim _data As CMDataSet.PAISESDataTable = Me.PAISESTableAdapter.GetPaisById(_cod)

                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    Me.PAISESTableAdapter.UpdateValores(_cod, _name, _notas, fId)
                Else
                    If _data.Rows.Count = 0 Then
                        Me.PAISESTableAdapter.Insert(_cod, _name, _notas)
                    Else
                        MessageBox.Show("Un pais con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_codigo.Clear()
                        Return
                    End If
                End If

                Me.PAISESTableAdapter.Fill(CMDataSet.PAISES)
                clickaccept = True
                Me.Close()
            Else : MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
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
    Private Sub tb_codigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_codigo.TextChanged
        ChequearTextboxSoloNumero(tb_codigo)
    End Sub
End Class