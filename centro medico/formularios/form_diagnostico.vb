Public Class form_diagnostico

    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim clickaccept As Boolean = False
    Dim fdiagnosticoo As String
    Dim fnivelo As String
    Dim fsnivelo As String
    Dim ffavoritoo As String
    Dim fobservacioneso As String
    Dim fcieo As String
    Dim fcie10o As String
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
        Dim _data As CMDataSet.DIAGNOSTICOSDataTable = Me.DIAGNOSTICOSTableAdapter.GetDiagnosticoById(fId)
        fdiagnosticoo = _data.Rows(0).Item("DIAGNOSTICO").ToString()
        fobservacioneso = _data.Rows(0).Item("OBSERVACIONES").ToString()
        ffavoritoo = _data.Rows(0).Item("FAVORITO").ToString()
        fnivelo = _data.Rows(0).Item("NIVEL").ToString()
        fsnivelo = _data.Rows(0).Item("SUBNIVEL").ToString()
        fcieo = _data.Rows(0).Item("CIE").ToString()
        fcie10o = _data.Rows(0).Item("CIE10").ToString()
        tb_diagnostico.Text = fdiagnosticoo.ToString()
        tb_obs.Text = fobservacioneso
        tb_nivel.Text = fnivelo
        tb_subnivel.Text = fsnivelo
        tb_c10.Text = fcie10o.ToString()
        If ffavoritoo = "N" Then
            chb_fav.Checked = False
        Else
            chb_fav.Checked = True
        End If


    End Sub
    Private Sub DIAGNOSTICOSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DIAGNOSTICOSBindingSource.EndEdit()
        Me.DIAGNOSTICOSTableAdapter.Update(Me.CMDataSet.DIAGNOSTICOS)

    End Sub

    Private Sub form_diagnostico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_diagnostico.ReadOnly = True
            tb_obs.ReadOnly = True
            tb_nivel.ReadOnly = True
            tb_subnivel.ReadOnly = True
            tb_c10.ReadOnly = True
            chb_fav.Enabled = False

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"

        End If


    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_diagnostico_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _diagnostico As String = tb_diagnostico.Text.Trim()
            Dim _nivel As String = tb_nivel.Text.Trim()
            Dim _snivel As String = tb_subnivel.Text.Trim()
            Dim _observaciones As String = tb_obs.Text.Trim()
            Dim _cie10 As String = tb_c10.Text.Trim()
            Dim _fav As String
            If (chb_fav.Checked) Then
                _fav = "S"
            Else : _fav = "A"
            End If
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.DIAGNOSTICOSTableAdapter.UpdateValores(_diagnostico, _observaciones, _nivel, _snivel, "---", _fav, _cie10, fId)
                End If
            Else
                If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.DIAGNOSTICOSTableAdapter.Insert(_diagnostico, _observaciones, _nivel, _snivel, "---", _fav, _cie10)

                End If
            End If
            Me.DIAGNOSTICOSTableAdapter.Fill(CMDataSet.DIAGNOSTICOS)

        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _diagnostico As String = tb_diagnostico.Text.Trim()
            Dim _nivel As String = tb_nivel.Text.Trim()
            Dim _snivel As String = tb_subnivel.Text.Trim()
            Dim _observaciones As String = tb_obs.Text.Trim()
            Dim _cie10 As String = tb_c10.Text.Trim()
            Dim _fav As String
            If (chb_fav.Checked) Then
                _fav = "S"
            Else : _fav = "A"
            End If
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                Me.DIAGNOSTICOSTableAdapter.UpdateValores(_diagnostico, _observaciones, _nivel, _snivel, "---", _fav, _cie10, fId)

            Else : Me.DIAGNOSTICOSTableAdapter.Insert(_diagnostico, _observaciones, _nivel, _snivel, "---", _fav, _cie10)
            End If
            Me.DIAGNOSTICOSTableAdapter.Fill(CMDataSet.DIAGNOSTICOS)

            clickaccept = True
            Me.Close()
        End If
    End Sub
End Class