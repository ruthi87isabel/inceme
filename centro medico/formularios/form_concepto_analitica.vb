Public Class form_concepto_analitica
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim clickaccept As Boolean = False
    Dim fconceptoo As String
    Dim fimporteo As Single
    Dim fnotaso As String
    Dim fcolor As String
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

    Sub aplicaPermisos()
        IMPORTELabel.Visible = (RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) <> RoleManager.TipoPermisos.Ninguno)
        tb_importe.Visible = (RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.ImporteCitas) <> RoleManager.TipoPermisos.Ninguno)
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
    Private Sub CONCEPTOSANALITICABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CONCEPTOSANALITICABindingSource.EndEdit()
        Me.CONCEPTOSANALITICATableAdapter.Update(Me.CMDataSet.CONCEPTOSANALITICA)

    End Sub
    Public Sub Inicializa()
        Dim _data As CMDataSet.CONCEPTOSANALITICADataTable = Me.CONCEPTOSANALITICATableAdapter.GetConceptosAnaliticaById(fId)
        fconceptoo = _data.Rows(0).Item("CONCEPTO").ToString()
        fnotaso = _data.Rows(0).Item("NOTAS").ToString()
        If _data.Rows(0).Item("IMPORTE").GetType.ToString() <> DBNull.Value.GetType.ToString Then
            fimporteo = _data.Rows(0).Item("IMPORTE")
            fcolor = _data.Rows(0).Item("COLOR")
        End If
        tb_concepto.Text = fconceptoo
        tb_importe.Text = String.Format("{0:N}", (fimporteo))
        tb_notas.Text = fnotaso
        Dim readcolor As Color = ColorTranslator.FromHtml(fcolor)
        UiColorButton1.ColorPicker.SelectedColor = readcolor
        aplicaPermisos()
    End Sub
    Private Sub form_concepto_analitica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()


        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_concepto.ReadOnly = True
            tb_importe.ReadOnly = True
            tb_notas.ReadOnly = True

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"

        End If

    End Sub

    Private Sub form_concepto_analitica_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _concepto As String = tb_concepto.Text.Trim()
            Dim _importe As Single
            If tb_importe.Text <> "" Then
                _importe = Single.Parse(tb_importe.Text.Trim())
            End If
            Dim _notas As String = tb_notas.Text.Trim()
            'Dim _color As String = UiColorButton1.SelectedColor.ToArgb.ToString()
            Dim _color As String = System.Drawing.ColorTranslator.ToHtml(UiColorButton1.SelectedColor)

            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.CONCEPTOSANALITICATableAdapter.UpdateValores(_concepto, _importe, _notas, _color, fId)
                End If
            Else
                If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.CONCEPTOSANALITICATableAdapter.Insert(_concepto, _importe, _notas, _color)

                End If
            End If
            Me.CONCEPTOSANALITICATableAdapter.Fill(CMDataSet.CONCEPTOSANALITICA)

        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub ActualizaPrecioLineasPlantillas(ByVal id As Integer, ByVal precio As Single)
        Dim context As New CMLinqDataContext

        Dim lineasplantillas As IQueryable(Of LPLANTILLAANALITICAS) = context.LPLANTILLAANALITICAS.AsQueryable
        lineasplantillas = lineasplantillas.Where(Function(m) m.REFCONCEPTO = id)
        For Each e As LPLANTILLAANALITICAS In lineasplantillas
            e.PRECIO = precio
        Next
        context.SubmitChanges()
    End Sub


    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _concepto As String = tb_concepto.Text.Trim()
            Dim _importe As Single
            If tb_importe.Text <> "" Then
                _importe = Single.Parse(tb_importe.Text.Trim())
            End If
            Dim _notas As String = tb_notas.Text.Trim()
            'Dim _color As String = UiColorButton1.SelectedColor.ToArgb.ToString()
            Dim _color As String = System.Drawing.ColorTranslator.ToHtml(UiColorButton1.SelectedColor)
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                Me.CONCEPTOSANALITICATableAdapter.UpdateValores(_concepto, _importe, _notas, _color, fId)
                Me.ActualizaPrecioLineasPlantillas(fId, _importe)
            Else : Me.CONCEPTOSANALITICATableAdapter.Insert(_concepto, _importe, _notas, _color)
            End If
            Me.CONCEPTOSANALITICATableAdapter.Fill(CMDataSet.CONCEPTOSANALITICA)
            clickaccept = True
            Me.Close()
        End If
    End Sub
    Private Sub ChequearTextboxSoloNumero(ByVal aTexbox As TextBox)
        Dim _text As String = aTexbox.Text
        Dim _number As Single
        Dim _texto As String = ""
        Dim modif As Integer = _text.Length
        Dim cant As Integer = 0
        If _text <> "" And _text <> Nothing Then
            If _text.Length > 0 Then
                Dim i As Integer
                For i = 0 To _text.Length - 1
                    If Not Single.TryParse(_text(i), _number) And _text(i) <> "," Then
                        modif = i
                        Continue For
                    Else
                        If _text(i) = "," And cant = 1 Then
                            modif = i
                            Continue For
                        ElseIf _text(i) = "," Then
                            cant = 1
                        End If
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
    Private Sub tb_importe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_importe.TextChanged
        ChequearTextboxSoloNumero(tb_importe)
    End Sub
End Class