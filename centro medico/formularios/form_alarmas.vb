Public Class form_alarmas
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim clickaccept As Boolean = False
    Dim fnivelo As String
    Dim falarmao As String
    Dim fdescripciono As String

    


    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName



    End Sub
    Private Function GetPaciente(ByVal aId As Integer) As String

        Dim _data As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(aId)
        Dim _pacientename As String = _data.Rows(0).Item("NOMBRE").ToString()
        Dim _pacienteapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
        Dim _pacienteapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
        Dim _paciente As String = _pacienteapellido1 + " " + _pacienteapellido2 + " , " + _pacientename
        Return _paciente

    End Function
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
    Private Sub ALARMASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ALARMASBindingSource.EndEdit()
        Me.ALARMASTableAdapter.Update(Me.CMDataSet.ALARMAS)

    End Sub
    Private Sub Inicializa()

        Dim _data As CMDataSet.ALARMASDataTable = Me.ALARMASTableAdapter.GetAlarmaById(fId)
        falarmao = _data.Rows(0).Item("ALARMA").ToString()
        fnivelo = _data.Rows(0).Item("NIVEL").ToString()
        fdescripciono = _data.Rows(0).Item("DESCRIPCION").ToString()
        tb_alarma.Text = falarmao
        tb_descripc.Text = fdescripciono.ToString()
        If fnivelo = "B" Then
            rb_baja.Checked = True
            rb_media.Checked = False
            rb_alta.Checked = False
        ElseIf fnivelo = "M" Then
            rb_baja.Checked = False
            rb_media.Checked = True
            rb_alta.Checked = False
        Else
            rb_baja.Checked = False
            rb_media.Checked = False
            rb_alta.Checked = True
        End If
        Dim _dataa As CMDataSet.LINEASALARMADataTable = Me.LINEASALARMATableAdapter.GetPacienteByAlarma(fId)
        Dim i As Integer
        Dim id As Integer

        For i = 0 To _dataa.Rows.Count - 1
            id = _dataa.Rows(i).Item("REFPACIENTE")
            Dim _dataalarm As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(id)
            If _dataalarm.Rows.Count > 0 Then
                Dim activo As String = _dataalarm.Rows(0).Item("ACTIVO").ToString()
                If activo = "S" Then
                    dgv_pacientes.Rows.Add(id, GetPaciente(id))
                End If
            End If

        Next


    End Sub
    Private Sub form_alarmas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv_pacientes.Columns.Add("Cod", "Cod")
        dgv_pacientes.Columns.Add("Nombre", "Nombre")
        dgv_pacientes.Rows.Clear()
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_alarma.ReadOnly = True
            tb_descripc.ReadOnly = True
            rb_baja.Enabled = False
            rb_media.Enabled = False
            rb_alta.Enabled = False

            bt_aceptar.Hide()
            bt_add.Enabled = False
            bt_delete.Enabled = False
            bt_cancel.Text = "Cerrar"

        End If

    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_alarmas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _alarma As String = tb_alarma.Text.Trim()
            Dim _descripcion As String = tb_descripc.Text.Trim()
            Dim _nivel As String
            If (rb_baja.Checked) Then
                _nivel = "B"
            ElseIf (rb_media.Checked) Then
                _nivel = "M"
            Else : _nivel = "A"
            End If
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.ALARMASTableAdapter.Update(_alarma, _nivel, _descripcion, fId, falarmao, fnivelo, fId)
                End If
            Else
                If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.ALARMASTableAdapter.Insert(_alarma, _nivel, _descripcion)

                End If
            End If
            Me.ALARMASTableAdapter.Fill(CMDataSet.ALARMAS)
            AddLinea()

        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _alarma As String = tb_alarma.Text.Trim()
            Dim _descripcion As String = tb_descripc.Text.Trim()
            Dim _nivel As String
            If (rb_baja.Checked) Then
                _nivel = "B"
            ElseIf (rb_media.Checked) Then
                _nivel = "M"
            Else : _nivel = "A"
            End If
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                Me.ALARMASTableAdapter.Update(_alarma, _nivel, _descripcion, fId, falarmao, fnivelo, fId)
            Else : Me.ALARMASTableAdapter.Insert(_alarma, _nivel, _descripcion)
            End If
            Me.ALARMASTableAdapter.Fill(CMDataSet.ALARMAS)
            clickaccept = True
            Me.Close()
            AddLinea()
        End If
    End Sub

    Private Sub bt_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_add.Click
        Me.PACIENTESTableAdapter.Fill(Me.CMDataSet.PACIENTES)
        Dim _name As String = "Listado de pacientes"
        Dim _listados As form_listados = New form_listados(_name, PACIENTESBindingSource, RoleManager.Items.Pacientes, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            Agrega(_pcodo)
        End If
    End Sub
    Private Sub AddLinea()
        LINEASALARMATableAdapter.DeleteVaciar()
        Dim i As Integer
        For i = 0 To dgv_pacientes.Rows.Count - 1
            Dim cod As Integer = dgv_pacientes.Rows(i).Cells("Cod").Value
            Dim _descripcion As String = tb_descripc.Text.Trim()
            LINEASALARMATableAdapter.Insert(cod, fId, _descripcion)
        Next
        LINEASALARMATableAdapter.Fill(CMDataSet.LINEASALARMA)
    End Sub
    Private Sub Agrega(ByVal acod As Integer)
        dgv_pacientes.Rows.Add(acod, GetPaciente(acod))
        Dim _descripcion As String = tb_descripc.Text.Trim()
        LINEASALARMATableAdapter.Insert(acod, fId, _descripcion)
        LINEASALARMATableAdapter.Fill(CMDataSet.LINEASALARMA)
    End Sub

    Private Sub bt_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_delete.Click
        Dim i As Integer
        For i = 0 To dgv_pacientes.SelectedRows.Count - 1
            dgv_pacientes.Rows.RemoveAt(dgv_pacientes.SelectedRows(i).Index())
            LINEASALARMATableAdapter.DeleteLineaAlarmaById(fId)
            LINEASALARMATableAdapter.Fill(CMDataSet.LINEASALARMA)
        Next
    End Sub

    
    Private Sub rb_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_todos.CheckedChanged
        dgv_pacientes.Rows.Clear()
        Dim _dataa As CMDataSet.LINEASALARMADataTable = Me.LINEASALARMATableAdapter.GetPacienteByAlarma(fId)
        Dim i As Integer
        Dim id As Integer

        For i = 0 To _dataa.Rows.Count - 1
            id = _dataa.Rows(i).Item("REFPACIENTE")
            dgv_pacientes.Rows.Add(id, GetPaciente(id))
        Next

    End Sub

    Private Sub rb_inactivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_inactivo.CheckedChanged
        dgv_pacientes.Rows.Clear()
        Dim _dataa As CMDataSet.LINEASALARMADataTable = Me.LINEASALARMATableAdapter.GetPacienteByAlarma(fId)
        Dim i As Integer
        Dim id As Integer

        For i = 0 To _dataa.Rows.Count - 1

            id = _dataa.Rows(i).Item("REFPACIENTE")
            Dim _dataalarm As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(id)
            If _dataalarm.Rows.Count > 0 Then
                Dim activo As String = _dataalarm.Rows(0).Item("ACTIVO").ToString()
                If activo = "N" Then
                    dgv_pacientes.Rows.Add(id, GetPaciente(id))
                End If
            End If

        Next
    End Sub

    Private Sub rb_activo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_activo.CheckedChanged
        dgv_pacientes.Rows.Clear()
        Dim _dataa As CMDataSet.LINEASALARMADataTable = Me.LINEASALARMATableAdapter.GetPacienteByAlarma(fId)
        Dim i As Integer
        Dim id As Integer

        For i = 0 To _dataa.Rows.Count - 1
            id = _dataa.Rows(i).Item("REFPACIENTE")
            Dim _dataalarm As CMDataSet.PACIENTESDataTable = Me.PACIENTESTableAdapter.GetPacienteById(id)
            If _dataalarm.Rows.Count > 0 Then
                Dim activo As String = _dataalarm.Rows(0).Item("ACTIVO").ToString()
                If activo = "S" Then
                    dgv_pacientes.Rows.Add(id, GetPaciente(id))
                End If
            End If

        Next
    End Sub

    Private Sub bt_ficha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ficha.Click
        Dim Id As String = dgv_pacientes.SelectedRows.Item(0).Cells("Cod").Value
        'Dim _nuevo_paciente As form_pacientes = New form_pacientes("Ficha de Paciente-Ver", Enums.Accion.Ver, Id)
        Dim _nuevo_paciente As formPaciente = New formPaciente("Ficha de Paciente-Ver", Enums.Accion.Ver, Id)
        _nuevo_paciente.ShowInTaskbar = False
        _nuevo_paciente.ShowDialog()
    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        'MessageBox.Show("Función no disponible", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim _print As New form_mostrar_reportes_alarma_paciente(fId)
        _print.ShowInTaskbar = False
        _print.ShowDialog()
    End Sub
End Class