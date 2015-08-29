Public Class form_pac_rev_comp_editar_dato

    Dim fId As Integer
    Dim fLComparativaId As Integer
    Dim fcurrentAcc As Integer
    Dim fNumero As Boolean


    Dim fCMDataSet As CMDataSet

    Sub New(ByVal aId As Integer, ByVal aLComparativaId As Integer, ByRef aCMDataSet As CMDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.fId = aId
        Me.fLComparativaId = aLComparativaId

        fCMDataSet = aCMDataSet

    End Sub



    Private Sub form_pac_rev_comp_editar_dato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fNumero = False

        'Dim _data As CMDataSet.DATOSCOMPARATIVADataTable = DATOSCOMPARATIVATableAdapter.GetDataById(fId)

        Dim _data As CMDataSet.DATOSCOMPARATIVADataTable = New CMDataSet.DATOSCOMPARATIVADataTable()
        _data.ImportRow(fCMDataSet.DATOSCOMPARATIVA.FindByID(fId))

        Dim _refmodelodato As Integer = _data.Rows(0).Item("REFMODELODATO")
        Dim _dataModeloDatos As CMDataSet.MODELOSDATOSDataTable = MODELOSDATOSTableAdapter.GetDataByCodigo(_refmodelodato)
        lb_nombredato.Text = _dataModeloDatos.Rows(0).Item("NOMBREDATO").ToString()
        Dim _tipo As String = _dataModeloDatos.Rows(0).Item("TIPODATO").ToString()
        If _tipo = "B" Then
            tb_valordato.Visible = False
            gb_booleano.Visible = True
            Dim _valor As String = _data.Rows(0).Item("DBOOLEAN").ToString()
            If _valor = "S" Then
                rb_si.Checked = True
            Else
                rb_no.Checked = True
            End If
        Else
            tb_valordato.Visible = True
            gb_booleano.Visible = False
            If _tipo = "T" Then
                tb_valordato.Text = _data.Rows(0).Item("DVARCHAR").ToString()
            Else
                fNumero = True
                Dim _valor As Single = _data.Rows(0).Item("DFLOAT").ToString()
                If _valor = 0 Then
                    tb_valordato.Text = ""
                Else
                    tb_valordato.Text = _valor.ToString()
                End If
            End If
        End If

    End Sub

    Private Sub tb_valordato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_valordato.TextChanged
        If fNumero = True Then
            'Try
            Single.Parse(tb_valordato.Text)
            'Catch ex As Exception
            If tb_valordato.Text.Length > 0 Then
                tb_valordato.Text = tb_valordato.Text.Substring(0, tb_valordato.Text.Length - 1)
                tb_valordato.SelectionStart = tb_valordato.Text.Length
            End If
            'End 'Try
        End If
    End Sub

    Private Sub bt_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Aceptar.Click
        If tb_valordato.Visible = True Then
            If fNumero = True Then
                If tb_valordato.Text <> "" Then
                    'DATOSCOMPARATIVATableAdapter.UpdateDFloat(Single.Parse(tb_valordato.Text), fId)
                    fCMDataSet.DATOSCOMPARATIVA.FindByID(fId).DFLOAT() = Single.Parse(tb_valordato.Text)
                End If
            Else
                'DATOSCOMPARATIVATableAdapter.UpdateDVarchar(tb_valordato.Text, fId)
                fCMDataSet.DATOSCOMPARATIVA.FindByID(fId).DVARCHAR() = tb_valordato.Text
            End If
        Else
            Dim _valor As String
            If rb_si.Checked = True Then
                _valor = "S"
            Else
                _valor = "N"
            End If
            'DATOSCOMPARATIVATableAdapter.UpdateDBoolean(_valor, fId)
            fCMDataSet.DATOSCOMPARATIVA.FindByID(fId).DBOOLEAN() = _valor
        End If
        Close()
    End Sub

    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        Close()
    End Sub
End Class