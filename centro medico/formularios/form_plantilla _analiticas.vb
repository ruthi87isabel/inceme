Public Class form_plantilla__analiticas
    Dim fcurrentAcc As Integer
    Dim fId As String
    Dim clickaccept As Boolean = False
    Dim fdescripciono As String
    Dim fimporte As Single


    Private Sub PLANTILLAANALITICASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PLANTILLAANALITICASBindingSource.EndEdit()
        Me.PLANTILLAANALITICASTableAdapter.Update(Me.CMDataSet.PLANTILLAANALITICAS)

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
    Private Sub Borra()
        Dim i As Integer
        For i = 0 To dgv_disponibles.Columns.Count - 1
            dgv_disponibles.Columns(i).Visible = False
        Next
    End Sub
    Private Sub Agregar(ByVal aRefPlantilla As String)
        Dim i As Integer
        For i = 0 To dgv_realizar.Rows.Count - 1
            If dgv_realizar.Rows(i).Cells("Id").Value = -1 Then
                Dim refconcepto As Integer = dgv_realizar.Rows(i).Cells("RefConcepto").Value
                Dim precio As Single = dgv_realizar.Rows(i).Cells("Precio").Value
                LPLANTILLAANALITICASTableAdapter.Insert(aRefPlantilla, refconcepto.ToString(), precio)
            End If
        Next

        For i = 0 To dgv_disponibles.Rows.Count - 1
            If dgv_disponibles.Rows(i).Cells("Id").Value <> -1 Then
                LPLANTILLAANALITICASTableAdapter.DeleteById(dgv_disponibles.Rows(i).Cells("Id").Value)
            End If
        Next
    End Sub
    Private Sub Inicializa()
        Dim _data As CMDataSet.PLANTILLAANALITICASDataTable = Me.PLANTILLAANALITICASTableAdapter.GetPlantillaAnaliticaById(fId)
        fdescripciono = _data.Rows(0).Item("DESCRIPCION").ToString()
        tb_codigo.Text = fId
        tb_descripcion.Text = fdescripciono.ToString()

        Dim _dataf As CMDataSet.LPLANTILLAANALITICASDataTable = Me.LPLANTILLAANALITICASTableAdapter.GetLPlantillaByPlantilla(fId)
        Dim _datac As CMDataSet.CONCEPTOSANALITICADataTable = Me.CONCEPTOSANALITICATableAdapter.GetData()
        dgv_disponibles.Columns.Add("Concepto", "Concepto")
        dgv_disponibles.Columns.Add("Precio", "Precio")
        dgv_disponibles.Columns.Add("Codigo", "Codigo")
        dgv_disponibles.Columns.Add("Id", "Id")
        dgv_realizar.Columns.Add("Concepto", "Concepto")
        dgv_realizar.Columns.Add("Precio", "Precio")
        dgv_realizar.Columns.Add("Realizado", "Realizado")
        dgv_realizar.Columns.Add("RefConcepto", "RefConcepto")
        dgv_realizar.Columns.Add("Id", "Id")
        dgv_disponibles.Rows.Clear()
        dgv_realizar.Rows.Clear()

        Dim id As Integer
        Dim idc As Integer
        Dim idconcepto As Integer
        Dim concepto As String
        Dim conceptoc As String
        Dim precio As Single
        Dim precioc As Single
        Dim i As Integer
        Dim j As Integer

        For j = 0 To _datac.Rows.Count - 1
            idc = _datac.Rows(j).Item("CODIGO")
            conceptoc = _datac.Rows(j).Item("CONCEPTO")
            precioc = _datac.Rows(j).Item("IMPORTE")
            Dim cojido As Boolean = False
            For i = 0 To _dataf.Rows.Count - 1

                idconcepto = Integer.Parse(_dataf.Rows(i).Item("REFCONCEPTO"))
                If idconcepto = idc Then
                    cojido = True
                    id = _dataf.Rows(i).Item("ID")
                    concepto = CONCEPTOSANALITICATableAdapter.GetConceptosAnaliticaById(idconcepto).Rows(0).Item("CONCEPTO")
                    precio = _dataf.Rows(i).Item("PRECIO")
                    dgv_realizar.Rows.Add(concepto, precio, "", idconcepto, id)
                    fimporte = fimporte + precio
                    tb_total.Text = fimporte
                End If

            Next
            If cojido = False Then
                dgv_disponibles.Rows.Add(conceptoc, precioc, idc, -1)
            End If

        Next

        dgv_realizar.Columns("Id").Visible = False
        dgv_realizar.Columns("RefConcepto").Visible = False
        dgv_realizar.Columns("Precio").Visible = (RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) <> RoleManager.TipoPermisos.Ninguno)
        dgv_disponibles.Columns("Codigo").Visible = False
        dgv_disponibles.Columns("Id").Visible = False
        dgv_disponibles.Columns("Precio").Visible = (RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) <> RoleManager.TipoPermisos.Ninguno)

        Me.tb_total.Visible = (RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) <> RoleManager.TipoPermisos.Ninguno)
        Me.IMPORTELabel.Visible = Me.tb_total.Visible


    End Sub
    Private Sub GetConceptos()
        If Me.CurrentAccion = Enums.Accion.Insertar Then

            dgv_disponibles.Columns.Add("Concepto", "Concepto")
            dgv_disponibles.Columns.Add("Precio", "Precio")
            dgv_disponibles.Columns.Add("Codigo", "Codigo")
            dgv_disponibles.Columns.Add("Id", "Id")
            Me.CONCEPTOSANALITICATableAdapter.Fill(CMDataSet.CONCEPTOSANALITICA)
            Dim _datac As CMDataSet.CONCEPTOSANALITICADataTable = Me.CONCEPTOSANALITICATableAdapter.GetData()
            Dim idc As Integer
            Dim conceptoc As String
            Dim precioc As Single
            Dim j As Integer
            For j = 0 To _datac.Rows.Count - 1
                idc = _datac.Rows(j).Item("CODIGO")
                conceptoc = _datac.Rows(j).Item("CONCEPTO")
                precioc = _datac.Rows(j).Item("IMPORTE")
                dgv_disponibles.Rows.Add(conceptoc, precioc, idc, -1)
            Next

            dgv_disponibles.Columns("Codigo").Visible = False
            dgv_disponibles.Columns("Id").Visible = False
            dgv_realizar.Columns.Add("Concepto", "Concepto")
            dgv_realizar.Columns.Add("Precio", "Precio")
            dgv_realizar.Columns.Add("Realizado", "Realizado")
            dgv_realizar.Columns.Add("RefConcepto", "RefConcepto")
            dgv_realizar.Columns.Add("Id", "Id")
            dgv_realizar.Columns("RefConcepto").Visible = False
            dgv_realizar.Columns("Id").Visible = False

        End If
    End Sub
    Private Sub form_plantilla__analiticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()

            bt_izq.Enabled = False
            bt_der.Enabled = False
            tb_descripcion.ReadOnly = True
            tb_codigo.ReadOnly = True
            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"

        End If
        GetConceptos()
        dgv_disponibles.Columns(0).SortMode() = DataGridViewColumnSortMode.Automatic
        dgv_realizar.Columns(0).SortMode() = DataGridViewColumnSortMode.Automatic

    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        Me.Close()
    End Sub
    Private Sub bt_izq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_izq.Click
        Dim i As Integer
        For i = 0 To dgv_disponibles.SelectedRows.Count - 1
            Dim concepto As String
            Dim importe As Single
            Dim id As Integer
            concepto = dgv_disponibles.SelectedRows(i).Cells("Concepto").Value
            importe = dgv_disponibles.SelectedRows(i).Cells("Precio").Value
            id = dgv_disponibles.SelectedRows(i).Cells("Codigo").Value
            dgv_realizar.Rows.Add(concepto, importe, "", id, -1)
            dgv_disponibles.Rows.RemoveAt(dgv_disponibles.SelectedRows(i).Index())
            fimporte = fimporte + importe
            tb_total.Text = fimporte.ToString()

        Next
    End Sub

    Private Sub bt_der_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_der.Click
        Dim i As Integer
        For i = 0 To dgv_realizar.SelectedRows.Count - 1
            Dim concepto As String
            Dim importe As Single
            Dim id As Integer
            Dim ida As Integer
            concepto = dgv_realizar.SelectedRows(i).Cells("Concepto").Value
            importe = dgv_realizar.SelectedRows(i).Cells("Precio").Value
            id = dgv_realizar.SelectedRows(i).Cells("RefConcepto").Value
            ida = dgv_realizar.SelectedRows(i).Cells("Id").Value
            dgv_disponibles.Rows.Add(concepto, importe, id, ida)
            dgv_realizar.Rows.RemoveAt(dgv_realizar.SelectedRows(i).Index())
            fimporte = fimporte - importe
            tb_total.Text = fimporte.ToString()

        Next
    End Sub
    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
       
        Dim _descripcion As String = tb_descripcion.Text
        Dim _cod As String = tb_codigo.Text.Trim()
        If _cod <> "" Then
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                PLANTILLAANALITICASTableAdapter.UpdateValores(_cod, _descripcion, fId)
                Agregar(_cod)
            ElseIf Me.CurrentAccion = Enums.Accion.Insertar Then
                PLANTILLAANALITICASTableAdapter.Insert(_cod, _descripcion)
                PLANTILLAANALITICASTableAdapter.Fill(CMDataSet.PLANTILLAANALITICAS)
                Dim _anal As String = PLANTILLAANALITICASTableAdapter.GetData().Rows(PLANTILLAANALITICASTableAdapter.GetData().Rows.Count - 1).Item("CODIGO")
                Agregar(_anal)
            End If
            Me.Close()
        Else : MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class