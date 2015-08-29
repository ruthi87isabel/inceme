Public Class form_formas_pago
    Dim fcurrentAcc As Integer
    Dim fId As String
    Dim clickaccept As Boolean = False
    Dim fcodo As String
    Dim fdescripo As String
    Dim cancelClose As Boolean = False

    Private Sub FORMASPAGOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FORMASPAGOBindingSource.EndEdit()
        Me.FORMASPAGOTableAdapter.Update(Me.CMDataSet.FORMASPAGO)

    End Sub
    Private Sub Inicializa()
        Dim _data As CMDataSet.FORMASPAGODataTable = Me.FORMASPAGOTableAdapter.GetFormasPagoById(fId)
        fcodo = _data.Rows(0).Item("CODIGO").ToString()
        fdescripo = _data.Rows(0).Item("DESCRIPCION").ToString()
        tb_cod.Text = fcodo
        tb_descripcion.Text = fdescripo

    End Sub
    Private Sub form_formas_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            inicializa()

        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_cod.ReadOnly = True
            tb_descripcion.ReadOnly = True

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If
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


    Private Sub form_formas_pago_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _cod As String = tb_cod.Text.Trim()
            Dim _descrip As String = tb_descripcion.Text.Trim()
            If _cod <> "" Then
                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.FORMASPAGOTableAdapter.UpdateValores(_cod, _descrip, fcodo)
                    End If
                Else
                    If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.FORMASPAGOTableAdapter.Insert(_cod, _descrip)

                    End If
                End If
                Me.FORMASPAGOTableAdapter.Fill(CMDataSet.FORMASPAGO)
            Else : MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _cod As String = tb_cod.Text.Trim()
            Dim _descrip As String = tb_descripcion.Text.Trim()
            If _cod <> "" Then
                If Me.CurrentAccion = Enums.Accion.Modificar Then

                    Me.FORMASPAGOTableAdapter.UpdateValores(_cod, _descrip, fcodo)

                Else
                    If Not Me.FORMASPAGOTableAdapter.GetFormasPagoById(_cod) Is Nothing AndAlso Me.FORMASPAGOTableAdapter.GetFormasPagoById(_cod).Count = 0 Then
                        Me.FORMASPAGOTableAdapter.Insert(_cod, _descrip)
                    Else
                        MsgBox("El código seleccionado ya existe", vbExclamation)
                        Me.cancelClose = True
                        Exit Sub
                    End If


                End If
                Me.FORMASPAGOTableAdapter.Fill(CMDataSet.FORMASPAGO)
                clickaccept = True
                Me.cancelClose = False
                Me.Close()
            Else : MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_formas_pago_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If cancelClose Then
            e.Cancel = True
        End If
    End Sub
End Class