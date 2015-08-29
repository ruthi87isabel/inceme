Public Class form_indicaciones
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim clickaccept As Boolean = False
    Dim fnameo As String
    Dim ftextoo As String
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
    Private Sub INDICACIONESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.INDICACIONESBindingSource.EndEdit()
        Me.INDICACIONESTableAdapter.Update(Me.CMDataSet.INDICACIONES)

    End Sub
    Private Sub Inicializa()
        Dim _data As CMDataSet.INDICACIONESDataTable = Me.INDICACIONESTableAdapter.GetIndicacionById(fId)
        fnameo = _data.Rows(0).Item("NOMBRE").ToString()
        ftextoo = _data.Rows(0).Item("TEXTO").ToString()
        tb_texto.Text = ftextoo
        tb_nombre.Text = fnameo

    End Sub

    Private Sub form_indicaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()

        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_nombre.ReadOnly = True
            tb_texto.ReadOnly = True

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If
    End Sub

    Private Sub form_indicaciones_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _nombre As String = tb_nombre.Text.Trim()
            Dim _texto As String = tb_texto.Text.Trim()
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.INDICACIONESTableAdapter.UpdateValores(_nombre, _texto, fId)
                End If
            Else
                If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Dim id As Integer = 1
                    If INDICACIONESTableAdapter.MaxCindicacionesId.HasValue Then
                        id = Me.INDICACIONESTableAdapter.MaxCindicacionesId
                        id += 1
                    End If
                    Me.INDICACIONESTableAdapter.Insert(id + 1, _nombre, _texto)

                End If
            End If
            Me.INDICACIONESTableAdapter.Fill(CMDataSet.INDICACIONES)

        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _nombre As String = tb_nombre.Text.Trim()
            Dim _texto As String = tb_texto.Text.Trim()
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                Me.INDICACIONESTableAdapter.UpdateValores(_nombre, _texto, fId)
            Else
                Dim id As Integer = 1
                If INDICACIONESTableAdapter.MaxCindicacionesId.HasValue Then
                    id = Me.INDICACIONESTableAdapter.MaxCindicacionesId
                    id += 1
                End If
                Me.INDICACIONESTableAdapter.Insert(id, _nombre, _texto)
            End If
            Me.INDICACIONESTableAdapter.Fill(CMDataSet.INDICACIONES)
            clickaccept = True
            Me.Close()
        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub bt_medic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_medic.Click
        Dim ind As String = tb_nombre.Text.Trim()
        Dim _data As CMDataSet.MEDICAMENTOSDataTable = Me.MEDICAMENTOSTableAdapter.GetMedicamentoByIndicacion(ind)
        Dim _med As String
        Dim _text As String = ""
        Dim i As Integer
        For i = 0 To _data.Rows.Count - 1
            _med = _data.Rows(i).Item("DESCRIPCION").ToString()
            _text = _text + " " + _med
        Next
        If _text = "" Then
            _text = "Ninguno"
        End If
        MessageBox.Show("Medicamentos para este supuesto: " + _text, "Centro Medico", MessageBoxButtons.OK)
    End Sub
End Class