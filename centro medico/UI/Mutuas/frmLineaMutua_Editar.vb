Public Class frmLineaMutua_Editar
    Dim IDPACIENTE As Integer
    Dim IDLINIEAMUTUA As Integer
    Public TIPO As String

    Sub New(idLineaMutua As Integer, idPaciente As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IDLINIEAMUTUA = idLineaMutua
        Me.IDPACIENTE = idPaciente
    End Sub

    Sub New(idPaciente As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IDPACIENTE = idPaciente

    End Sub

    Private Sub bt_AMAceptar_Click(sender As Object, e As EventArgs) Handles bt_AMAceptar.Click
        If Not cb_AMTipo.Text Is Nothing Then
            If cb_AMTipo.Text <> "" Then
                Me.TIPO = cb_AMTipo.Text(0)
            End If
        End If
        LMUTUASBindingSource.EndEdit()

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bt_AMCancelar_Click(sender As Object, e As EventArgs) Handles bt_AMCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmLineaMutua_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CtrlMutua1.IDPACIENTE = Me.IDPACIENTE

        Dim _lmutua As LMUTUA = LMUTUASBindingSource.DataSource
        If _lmutua.FECHABAJA Is Nothing Then
            FECHABAJADateTimePicker.Enabled = False
        Else
            FECHABAJADateTimePicker.Enabled = True
            FECHABAJADateTimePicker.Value = _lmutua.FECHABAJA
            FECHABAJADateTimePicker.Checked = True

        End If
        If _lmutua.TIPO Is Nothing Or _lmutua.TIPO = "" Then
            Return
        End If
        Dim t As String = _lmutua.TIPO(0)

        If (t = "A" Or t = "a") Then
            cb_AMTipo.Text = "Aseguradora privada"
        Else
            If (t = "C" Or t = "c") Then
                cb_AMTipo.Text = "Compañía de revisión"
            Else
                If (t = "M" Or t = "m") Then
                    cb_AMTipo.Text = "MUTUA asistencial"
                End If
            End If
        End If

     
    End Sub

End Class