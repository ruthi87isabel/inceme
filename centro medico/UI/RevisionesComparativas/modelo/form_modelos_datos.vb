Imports System.Xml.Linq

Public Class form_modelos_datos

    Dim fdescripcion As String
    Dim fTipoDato As String
    Dim fCodigoComparativa As String
    Dim fcurrentAcc As Enums.Accion
    Dim fId As Integer

    Dim context As CMLinqDataContext


    Public ModeloDatos As MODELOSDATO


    'Private Expresion As String = String.Empty



    Sub New(ByVal aCodigoComparativa As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        CurrentAccion = aCurrentAccion
        fCodigoComparativa = aCodigoComparativa
        fId = aId

        context = New CMLinqDataContext()
        If aCurrentAccion = Enums.Accion.Insertar Then
            ModeloDatos = New MODELOSDATO()
            ModeloDatos.REFMODELOCOMPARATIVA = aCodigoComparativa
        Else
            ModeloDatos = (From m As MODELOSDATO In context.MODELOSDATOs _
                          Where m.CODIGO = aId _
                          Select m).SingleOrDefault()

        End If

        MODELOSDATOSBindingSource.DataSource = ModeloDatos

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

    Public Property Descripcion() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fdescripcion

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fdescripcion = Value
        End Set
    End Property

    Public Property TipoDato() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fTipoDato

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fTipoDato = Value
        End Set
    End Property

   
    Private Sub form_modelos_datos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
    End Sub

    Private Sub Inicializa()
        'Dim _data As CMDataSet.MODELOSDATOSDataTable = MODELOSDATOSTableAdapter.GetDataByCodigo(fId)
        'tb_descripcion.Text = _data.Rows(0).Item("NOMBREDATO").ToString()
        'Dim _tipo As String = _data.Rows(0).Item("TIPODATO").ToString()

        tb_descripcion.Text = ModeloDatos.NOMBREDATO
        Dim _tipo As String = ModeloDatos.TIPODATO

        If _tipo = "N" Then
            rb_numerico.Checked = True
        End If

        If _tipo = "T" Then
            rb_numerico.Checked = True
        End If

        If _tipo = "B" Then
            rb_booleano.Checked = True
        End If

        If _tipo = "E" Then
            'Listado Exclusivo
            rb_OpcionesExclusivas.Checked = True
           
        End If

        If _tipo = "M" Then
            rb_OpcionesMultiples.Checked = True
        End If

        If _tipo = "E" Or _tipo = "M" Then
            Try

                If Not ModeloDatos.DXML Is Nothing Then
                    'xml.Parse(Valor)
                    chckListopciones.Items.Clear()
                    For Each el As XElement In ModeloDatos.DXML.<item>
                        Dim ischecked As Boolean = Boolean.Parse(el.Attribute("ischecked").Value)
                        chckListopciones.Items.Add(el.Value, ischecked)
                    Next

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        If _tipo = "X" Then
            rb_Expresiones.Checked = True
            If Not ModeloDatos.DXML Is Nothing Then
                txtExpresion.Text = ModeloDatos.DXML.Value
            End If
        End If

        Me.chkOpcionImpresionCliente.Checked = ModeloDatos.OcultarImpresionCliente

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If tb_descripcion.Text = "" Then
            MessageBox.Show("La descripción es obligatoria")
            tb_descripcion.Focus()
            Return

        End If

        fdescripcion = tb_descripcion.Text

        If rb_numerico.Checked = True Then
            fTipoDato = "N"
        ElseIf rb_texto.Checked = True Then
            fTipoDato = "T"
        Else
            fTipoDato = "B"
        End If


        If rb_OpcionesExclusivas.Checked Then
            fTipoDato = "E"
        End If

        If rb_OpcionesMultiples.Checked Then
            fTipoDato = "M"
        End If

        If rb_OpcionesExclusivas.Checked Or rb_OpcionesMultiples.Checked Then
            Try
                Dim xml As New Xml.Linq.XDocument()
                xml.Add(<lista></lista>)
                Dim i As Integer = 0
                For i = 0 To chckListopciones.Items.Count - 1
                    Dim ischecked As Boolean = chckListopciones.GetItemChecked(i)
                    xml.Root.Add(<item ischecked=<%= ischecked %>><%= chckListopciones.Items(i) %></item>)
                Next
                ModeloDatos.DXML = xml.Root
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        If rb_Expresiones.Checked Then
            fTipoDato = "X"
            Try
                Dim xml As New Xml.Linq.XDocument()
                xml.Add(<Expresion><%= txtExpresion.Text %></Expresion>)
                ModeloDatos.DXML = xml.Root
            Catch ex As Exception

            End Try
        End If


        ModeloDatos.TIPODATO = fTipoDato
        ModeloDatos.NOMBREDATO = fdescripcion
        ModeloDatos.OcultarImpresionCliente = Me.chkOpcionImpresionCliente.Checked

        If CurrentAccion = Enums.Accion.Insertar Then
            context.MODELOSDATOs.InsertOnSubmit(ModeloDatos)
        End If

        context.SubmitChanges()

        'If Me.CurrentAccion = Enums.Accion.Modificar Then
        '    MODELOSDATOSTableAdapter.UpdateValores(fdescripcion, fTipoDato, fCodigoComparativa, fId)
        'Else
        '    MODELOSDATOSTableAdapter.Insert(fdescripcion, fTipoDato, fCodigoComparativa)
        'End If

        Close()

    End Sub
    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub


    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New form_modelo_datos_opcionesADD()

        Dim inserted As Integer = 0
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            inserted = chckListopciones.Items.Add(frm.txtTexto.Text, frm.chkPreseleccionada.Checked)
        End If
        If frm.chkPreseleccionada.Checked Then
            If rb_OpcionesExclusivas.Checked Then
                UncheckAll()
                chckListopciones.SetItemChecked(inserted, True)
            End If
        End If
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        Dim frm As New form_modelo_datos_opcionesADD()
        frm.txtTexto.Text = chckListopciones.SelectedItem
        frm.chkPreseleccionada.Checked = chckListopciones.GetItemChecked(chckListopciones.SelectedIndex)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'chckListopciones.Items(0).  = frm.txtTexto.Value
            chckListopciones.Items(chckListopciones.SelectedIndex) = frm.txtTexto.Text
            chckListopciones.SetItemChecked(chckListopciones.SelectedIndex, frm.chkPreseleccionada.Checked)
        End If

    End Sub


    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If chckListopciones.SelectedIndex > -1 Then
            chckListopciones.Items.RemoveAt(chckListopciones.SelectedIndex)
        End If
    End Sub

    Private Sub rb_OpcionesExclusivas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_OpcionesExclusivas.CheckedChanged
        pnlMultiples.Enabled = rb_OpcionesExclusivas.Checked
        If rb_OpcionesExclusivas.Checked Then
            UncheckAll()
        End If
    End Sub

    Private Sub rb_OpcionesMultiples_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_OpcionesMultiples.CheckedChanged
        pnlMultiples.Enabled = rb_OpcionesMultiples.Checked
    End Sub

    Private Sub chckListopciones_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles chckListopciones.SelectedIndexChanged
        btnEditar.Enabled = chckListopciones.SelectedItems.Count > 0
        btnEliminar.Enabled = chckListopciones.SelectedItems.Count > 0

        If rb_OpcionesExclusivas.Checked Then
            If chckListopciones.SelectedIndex > -1 Then
                UncheckAll()
                chckListopciones.SetItemChecked(chckListopciones.SelectedIndex, True)
            End If
        End If
    End Sub


    Private Sub UncheckAll()
        Dim i As Integer = 0
        For i = 0 To chckListopciones.Items.Count - 1
            chckListopciones.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub chckListopciones_DoubleClick(sender As System.Object, e As System.EventArgs) Handles chckListopciones.DoubleClick
        If chckListopciones.SelectedIndex <> -1 Then
            btnEditar_Click(Nothing, Nothing)
        End If
    End Sub

    
    Private Sub tb_descripcion_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tb_descripcion.KeyUp
        If e.KeyCode = Keys.Enter Then
            bt_aceptar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub rb_Expresiones_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Expresiones.CheckedChanged
        txtExpresion.Enabled = rb_Expresiones.Checked
        btnEditarExpresion.Enabled = rb_Expresiones.Checked
    End Sub

    Private Sub btnEditarExpresion_Click(sender As Object, e As EventArgs) Handles btnEditarExpresion.Click
        Dim frm As New frmRC_Expresiones
        frm.Expresion = txtExpresion.Text

        Dim modelos As List(Of MODELOSDATO) = (From m In context.MODELOSDATOs
                                              Where m.REFMODELOCOMPARATIVA = ModeloDatos.REFMODELOCOMPARATIVA
                                              Select m).ToList
        For Each m As MODELOSDATO In modelos
            If m.TIPODATO = "N" Then
                frm.Campos.Add(New Campo With _
                          {
                              .Nombre = m.NOMBREDATO, _
                              .Tipo = m.TIPODATO
                          })
            End If
        Next

        'frm.Campos = 
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtExpresion.Text = frm.Expresion
        End If
    End Sub
End Class