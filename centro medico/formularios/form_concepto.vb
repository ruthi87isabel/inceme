Public Class form_concepto
    Dim fcurrentAcc As Integer
    Dim fId As String
    Dim clickaccept As Boolean = False
    Dim fcodo As String
    Dim ffrao As String
    Dim fconceptoo As String
    Dim fimporteo As Single
    Dim fcantidado As Single
    Dim ftipoivao As Single

    Dim fCMDataSet As CMDataSet
    Dim fDesdePaciente As Boolean = False


    Public IdMutua As Integer = -1
    Public AplicarTarifa As Boolean = True


    Sub New(ByVal aCurrentAccion As Enums.Accion, ByVal afactura As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.ffrao = afactura

    End Sub
    Sub New(ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer, ByVal afactura As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.fId = aId
        Me.ffrao = afactura


    End Sub

    Sub New(ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer, ByVal afactura As Integer, ByRef aCMDataSet As CMDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.fId = aId
        Me.ffrao = afactura

        fCMDataSet = aCMDataSet
        fDesdePaciente = True

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
        Dim _data As CMDataSet.LINEASFACTURASDataTable

        'If fDesdePaciente Then
        '    _data = New CMDataSet.LINEASFACTURASDataTable()
        '    _data.ImportRow(CMDataSet.LINEASFACTURAS.FindByIDLINEAFACTURA(fId))
        'Else
        _data = Me.LINEASFACTURASTableAdapter.GetLineaFraById(fId)
        '  End If

        fcodo = _data.Rows(0).Item("REFCONCEPTO").ToString()
        fconceptoo = _data.Rows(0).Item("CONCEPTO").ToString()
        fimporteo = _data.Rows(0).Item("IMPORTE")
        If _data.Rows(0).Item("REFFACTURA").GetType().ToString() <> DBNull.Value.GetType.ToString() Then
            ffrao = _data.Rows(0).Item("REFFACTURA")
        Else : ffrao = 0
        End If

        ftipoivao = _data.Rows(0).Item("TIPOIVA").ToString()
        fcantidado = _data.Rows(0).Item("CANTIDAD")
        tb_idcodigo.Text = fcodo
        tb_codigo.Text = fconceptoo
        tb_importe.Text = fimporteo
        tb_cantidad.Text = fcantidado
        lb_total.Text = fcantidado * fimporteo
        cb_IVA.Text = ftipoivao
        Dim tipo As Single = _data.Rows(0).Item("TIPOIVA")
        Dim base As Single = (fimporteo) / ((1) + (tipo / 100))
        If tipo <> 0 Then
            lb_base.Text = base
        End If


    End Sub


#Region "Private Function ObtenImporteConceptoSegunTarifa(ByVal idConcepto As String,Byval descripcion as String, ByVal importeDefecto As Double) As Double"
    Private Function ObtenImporteConceptoSegunTarifa(ByVal idConcepto As String, ByVal descripcion As String, ByVal importeDefecto As Double, ByVal aplicarTarifa As Boolean) As Double

        'Pasos
        'Obtener la tarifa de la mutua seleccionada si hay una seleccionada

        Dim importe As Double = importeDefecto

        Try
            If IdMutua <> -1 Then
                Dim mutuaAdapter As New CMDataSetTableAdapters.MUTUASTableAdapter()
                Dim mutua As CMDataSet.MUTUASRow = mutuaAdapter.GetMutuaById(IdMutua)(0)

                Dim tarifaAdapter As New CMDataSetTableAdapters.TarifasTableAdapter()
                Dim tarifaTable As New CMDataSet.TarifasDataTable()

                'Si tiene tarifa
                If Not mutua.IsIdTarifaNull() Then
                    'Cargarla
                    tarifaAdapter.FillBy(tarifaTable, mutua.IdTarifa)
                    If (tarifaTable.Count > 0) Then
                        For Each tarifa As CMDataSet.TarifasRow In tarifaTable
                            If tarifa.IdConceptoFra = idConcepto And tarifa.Importe <> importeDefecto And aplicarTarifa Then
                                Return tarifa.Importe
                            End If
                        Next
                    End If
                End If
            End If
        Catch ex As Exception
            Return importe
        End Try

        Return importe
    End Function
#End Region


    Private Function GetConcepto(ByVal aId As String) As String
        Dim _data As CMDataSet.CONCEPTOSFRADataTable = Me.CONCEPTOSFRATableAdapter.GetConceptoFraById(aId)
        Dim _concepto As String = _data.Rows(0).Item("DESCRIPCION").ToString()
        Dim _importe As Double = ObtenImporteConceptoSegunTarifa(aId, _concepto, _data.Rows(0).Item("IMPORTE"), Me.AplicarTarifa)
        tb_importe.Text = _importe
        Dim _cant As Integer = Integer.Parse(tb_cantidad.Text.Trim())
        Dim _total As Double = _cant * _importe
        lb_total.Text = _total
        Dim tipo As Double = Double.Parse(cb_IVA.Text)
        Dim base As Double = (fimporteo) / ((1) + (tipo / 100))
        If tipo <> 0 Then
            lb_base.Text = base
        End If
        'Falta segunIVA Base
        Return _concepto
    End Function
    Private Sub bt_codigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_codigo.Click
        Me.CONCEPTOSFRATableAdapter.Fill(Me.CMDataSet.CONCEPTOSFRA)
        Dim _name As String = "Listado de conceptos facturables"
        Dim _listados As form_listados = New form_listados(_name, CONCEPTOSFRABindingSource, RoleManager.Items.Conceptos_Facturables, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As String = _listados.Selected()
            tb_idcodigo.Text = _pcodo
            tb_codigo.Text = GetConcepto(_pcodo)
        End If
    End Sub

    Private Sub CONCEPTOSFACTURABLESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CONCEPTOSFRABindingSource.EndEdit()
        Me.CONCEPTOSFRATableAdapter.Update(Me.CMDataSet.CONCEPTOSFRA)

    End Sub

    Private Sub form_concepto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
            tb_cantidad.Select()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_idcodigo.ReadOnly = True
            tb_codigo.ReadOnly = True
            tb_importe.ReadOnly = True
            tb_cantidad.ReadOnly = True
            cb_IVA.Enabled = False

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If


    End Sub
    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_concepto_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'If tb_idcodigo.Text <> "" Then
        '    bt_aceptar_Click(sender, e)
        'End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _cod As String
            If tb_idcodigo.Text <> "" Then
                _cod = tb_idcodigo.Text.Trim()
            Else : _cod = Nothing
            End If
            Dim _concepto As String = tb_codigo.Text.Trim()
            Dim _importe As Single = Single.Parse(tb_importe.Text.Trim())
            Dim _cantidad As Single = Single.Parse(tb_cantidad.Text.Trim())
            Dim _tipo As Single = Single.Parse(cb_IVA.Text.Trim())

            If Me.CurrentAccion = Enums.Accion.Modificar Then

         
                Me.LINEASFACTURASTableAdapter.UpdateValores(_concepto, _importe, ffrao, _cod, _cantidad, _tipo, fId)


            Else

           
                Me.LINEASFACTURASTableAdapter.Insert(_concepto, _importe, ffrao, _cod, _cantidad, _tipo, Nothing, 0, _importe, Nothing)


            End If
        clickaccept = True
        Me.Close()

        End If
    End Sub

    Private Sub cb_IVA_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_importe.Enter, lb_total.Enter, lb_base.Enter, cb_IVA.Enter, bt_aceptar.Enter
        Dim _cant As Double = Double.Parse(tb_cantidad.Text.Trim())
        Dim _importe As Double = Double.Parse(tb_importe.Text.Trim())
        Dim _total As Double = _cant * _importe
        Dim _tipo As Double = Double.Parse(cb_IVA.Text.Trim())
        lb_total.Text = _total
        Dim tipo As Double = Double.Parse(cb_IVA.Text)
        Dim base As Double = (fimporteo) / ((1) + (tipo / 100))
        If tipo <> 0 Then
            lb_base.Text = base
        End If
        'Falta segunIVA Base
    End Sub

    

    Private Sub tb_cantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_cantidad.Leave
        'ChequearTextboxSoloNumero(tb_cantidad)
    End Sub

    Private Sub tb_importe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_importe.Leave
        'ChequearTextboxSoloNumero(tb_importe)

    End Sub

    Private Sub lb_total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_total.Click

    End Sub

    Private Sub lb_base_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_base.Click

    End Sub

    Private Sub cb_IVA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_IVA.SelectedIndexChanged

    End Sub

   

    Private Sub tb_idcodigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_idcodigo.Leave
        If tb_idcodigo.Text <> "" Then
            Dim _pcodo As String = tb_idcodigo.Text
            Dim data As CMDataSet.CONCEPTOSFRADataTable = CONCEPTOSFRATableAdapter.GetConceptoFraById(_pcodo)
            If data.Rows.Count > 0 Then
                tb_codigo.Text = GetConcepto(_pcodo)
            Else
                tb_idcodigo.Text = ""
                tb_idcodigo.Focus()
                MessageBox.Show("No existe un concepto con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub tb_cantidad_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_importe.TextChanged, tb_cantidad.TextChanged, cb_IVA.TextChanged

        If tb_idcodigo.Text.Length > 0 Then
            Try
                Dim _importe As Double = Double.Parse(tb_importe.Text)
                Dim _cant As Integer = Integer.Parse(tb_cantidad.Text.Trim())
                Dim _total As Double = _cant * _importe
                lb_total.Text = _total
                Dim tipo As Double = Double.Parse(cb_IVA.Text)
                Dim base As Double = (fimporteo) / ((1) + (tipo / 100))
                If tipo <> 0 Then
                    lb_base.Text = base
                End If
            Catch ex As Exception

            End Try
            
        End If
    End Sub
End Class