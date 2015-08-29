Public Class form_mutua_empresa
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim fempresa As Integer
    Dim clickaccept As Boolean = False
    Dim fidmutuao As Integer
    Dim ffechabajao As Date
    Dim ffechaaltao As Date
    Dim fnotao As String
    Dim ftipoo As String

    Dim tipos As String() = {"Mutua asistencial", "Compañia de revisión", "Aseguradora privada"}
    Dim nomenc As String() = {"M", "C", "A"}
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aempresa As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fempresa = aempresa


    End Sub
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer, ByVal aempresa As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId
        Me.fempresa = aempresa


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
    Private Sub LMUTUASEMPRESASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LMUTUASEMPRESASBindingSource.EndEdit()
        Me.LMUTUASEMPRESASTableAdapter.Update(Me.CMDataSet.LMUTUASEMPRESAS)

    End Sub
    Private Sub Inicializa()
        Dim _data As CMDataSet.LMUTUASEMPRESASDataTable = Me.LMUTUASEMPRESASTableAdapter.GetMutuaEmpresaById(fId)

        fidmutuao = _data.Rows(0).Item("REFMUTUA").ToString()
        ffechaaltao = _data.Rows(0).Item("FECHAALTA").ToString()
        ffechabajao = _data.Rows(0).Item("FECHABAJA").ToString()
        ftipoo = _data.Rows(0).Item("TIPO").ToString()
        fnotao = _data.Rows(0).Item("NOTAS").ToString()

        tb_notas.Text = fnotao
        tb_mutua.Text = fidmutuao
        dtp_alta.Value = ffechaaltao
        dtp_baja.Value = ffechabajao
        lb_mutua.Text = GetMutua(fidmutuao)
        Dim index As Integer = Array.IndexOf(nomenc, ftipoo)
        If index <> -1 Then
            cb_tipo.Text = tipos(index)
        End If
    End Sub
    Private Sub form_mutua_empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then

            Inicializa()

            tb_notas.ReadOnly = True
            tb_mutua.ReadOnly = True
            dtp_alta.Enabled = False
            dtp_baja.Enabled = False
            bt_mutua.Enabled = False
            cb_tipo.Enabled = False

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If

    End Sub
    Private Function GetMutua(ByVal aId As Integer) As String

        Dim _data As CMDataSet.MUTUASDataTable = Me.MUTUASTableAdapter.GetMutuaById(aId)
        Dim _mutua As String = ""
        If _data.Rows.Count Then
            _mutua = _data.Rows(0).Item("NOMBRE").ToString()
        End If
        Return _mutua

    End Function

    Private Sub bt_mutua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mutua.Click
        Me.MUTUASTableAdapter.Fill(Me.CMDataSet.MUTUAS)
        Dim _name As String = "Listado de mutuas"
        Dim _listados As form_listados = New form_listados(_name, MUTUASBindingSource, RoleManager.Items.Mutuas, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            tb_mutua.Text = _pcodo.ToString()
            lb_mutua.Text = GetMutua(_pcodo)
        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_mutua_empresa_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _idmutua As Integer
            If tb_mutua.Text <> "" Then
                _idmutua = Integer.Parse(tb_mutua.Text.Trim())
            Else : Return
            End If
            Dim _fechabaja As Date = dtp_alta.Value
            Dim _fechaalta As Date = dtp_baja.Value
            Dim _nota As String = tb_notas.Text.Trim()
            Dim _tipo As String = cb_tipo.Text
            Dim tipon As String
            Dim index As Integer = Array.IndexOf(tipos, _tipo)
            If index <> -1 Then
                tipon = nomenc(index)
            End If

            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.LMUTUASEMPRESASTableAdapter.UpdateValores(fempresa, _fechaalta, _fechabaja, tipon, _idmutua, _nota, fId)
                End If

            Else
                If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.LMUTUASEMPRESASTableAdapter.Insert(fempresa, _fechaalta, _fechabaja, tipon, _idmutua, _nota)
                End If
            End If

            Me.LMUTUASEMPRESASTableAdapter.Fill(CMDataSet.LMUTUASEMPRESAS)

        End If
    End Sub

    
    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _idmutua As Integer
            If tb_mutua.Text <> "" Then
                _idmutua = Integer.Parse(tb_mutua.Text.Trim())
            Else : Return
            End If
            Dim _fechabaja As Date = dtp_alta.Value
            Dim _fechaalta As Date = dtp_baja.Value
            Dim _nota As String = tb_notas.Text.Trim()
            Dim _tipo As String = cb_tipo.Text
            Dim tipon As String
            Dim index As Integer = Array.IndexOf(tipos, _tipo)
            If index <> -1 Then
                tipon = nomenc(index)
            End If

            If Me.CurrentAccion = Enums.Accion.Modificar Then
                Me.LMUTUASEMPRESASTableAdapter.UpdateValores(fempresa, _fechaalta, _fechabaja, tipon, _idmutua, _nota, fId)
            Else
                Me.LMUTUASEMPRESASTableAdapter.Insert(fempresa, _fechaalta, _fechabaja, tipon, _idmutua, _nota)
            End If
        Me.LMUTUASEMPRESASTableAdapter.Fill(CMDataSet.LMUTUASEMPRESAS)
        clickaccept = True
        Me.Close()
        End If
    End Sub

    Private Sub tb_mutua_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_mutua.Leave
        If tb_mutua.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_mutua.Text)
            Dim data As CMDataSet.MUTUASDataTable = MUTUASTableAdapter.GetMutuaById(_pcodo)
            If data.Rows.Count > 0 Then
                lb_mutua.Text = GetMutua(_pcodo)
            Else
                tb_mutua.Text = ""
                tb_mutua.Focus()
                MessageBox.Show("No existe una mutua con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class