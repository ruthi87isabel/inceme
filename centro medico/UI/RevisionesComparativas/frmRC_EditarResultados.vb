Imports System.Xml.Linq
Public Class frmRC_EditarResultados

    Public Enum TipoDato
        Entero
        Texto
        Booleano
        OpcionesExclusivas
        OpcionesMultiples
        Expresion
    End Enum

    Public Tipo As TipoDato = TipoDato.Entero
    Public NombreDato As String = ""
    Public Valor As Object
    Public DXML As XElement
    Public OcultarImpresionCliente As Boolean = False

    Public ModeloDato As MODELOSDATO


    Private Sub frmRevisionComparativa_EditarResultados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = NombreDato
        tc_Datos.TabPages.Clear()

        'Valor = "<lista>" & _
        '           " <item ischecked='false'>opcion 1</item> " & _
        '           " <item ischecked='true'>opcion 2</item> " & _
        '           " <item ischecked='false'>opcion 3</item> " & _
        '        "</lista>"


        Select Case Tipo
            Case TipoDato.Entero
                tc_Datos.TabPages.Add(tbEntero)
                txt_IntegerValue.Text = Valor.ToString()
                Me.txt_IntegerValue.Focus()
            Case TipoDato.Texto
                tc_Datos.TabPages.Add(tbTexto)
                txt_TextValue.Text = Valor.ToString()
                Me.txt_TextValue.Focus()
            Case TipoDato.Booleano
                tc_Datos.TabPages.Add(tbBoolean)
                If Valor = "S" Then
                    rb_Si.Checked = True
                Else
                    rb_No.Checked = True
                End If

                'Me.rb_Si.Focus()
            Case TipoDato.OpcionesExclusivas
                tc_Datos.TabPages.Add(tabOpcionesUnicas)

                Try

                    If DXML Is Nothing Then
                        If Not Me.ModeloDato.DXML Is Nothing Then
                            DXML = ModeloDato.DXML
                        End If
                    End If


                    If Not DXML Is Nothing Then
                        'xml.Parse(Valor)
                        Dim i = 0
                        tabOpcionesUnicas.Controls.Clear()
                        For Each el As XElement In DXML.<item>
                            Dim ischecked As Boolean = Boolean.Parse(el.Attribute("ischecked").Value)
                            Dim rb As New RadioButton()
                            rb.Text = el.Value
                            rb.Checked = ischecked
                            rb.Location = New Point(20, i * rb.Height + 10)
                            tabOpcionesUnicas.Controls.Add(rb)
                            i = i + 1
                        Next

                    End If

                    Me.tabOpcionesUnicas.Focus()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


            Case TipoDato.OpcionesMultiples
                tc_Datos.TabPages.Add(tabOpcionesMultiples)
                Try

                    If DXML Is Nothing Then
                        If Not Me.ModeloDato.DXML Is Nothing Then
                            DXML = ModeloDato.DXML
                        End If
                    End If


                    If Not DXML Is Nothing Then
                        For Each el As XElement In DXML.<item>
                            Dim ischecked As Boolean = Boolean.Parse(el.Attribute("ischecked").Value)
                            chkListaDeChecks.Items.Add(el.Value, ischecked)
                        Next
                    End If

                    Me.tabOpcionesMultiples.Focus()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Case TipoDato.Expresion
                'tc_Datos.TabPages.Add(tabExpresiones)

                'If DXML Is Nothing Then
                '    If Not Me.ModeloDato.DXML Is Nothing Then
                '        DXML = ModeloDato.DXML
                '    End If
                'End If


                'If Not DXML Is Nothing Then
                '    txtExpression.Text = DXML.Value
                'End If

                'Me.tabExpresiones.Focus()

        End Select

        Me.chkOcultarImpresionCliente.Checked = OcultarImpresionCliente
    End Sub


    Private Sub bt_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Aceptar.Click
        OcultarImpresionCliente=chkOcultarImpresionCliente.Checked 
        

        Select Case Tipo
            Case TipoDato.Entero
                Valor = txt_IntegerValue.Text
            Case TipoDato.Texto
                Valor = txt_TextValue.Text
            Case TipoDato.Booleano
                If rb_Si.Checked Then
                    Valor = "S"
                Else
                    Valor = "N"
                End If


            Case TipoDato.OpcionesExclusivas

                Try
                    Dim xml As New Xml.Linq.XDocument()
                    xml.Add(<lista></lista>)
                    For Each item As RadioButton In tabOpcionesUnicas.Controls
                        Dim ischecked As Boolean = item.Checked
                        xml.Root.Add(<item ischecked=<%= ischecked %>><%= item.Text %></item>)
                    Next
                    'Valor = xml.ToString()
                    DXML = xml.Root

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


            Case TipoDato.OpcionesMultiples
                Try
                    Dim xml As New Xml.Linq.XDocument()
                    xml.Add(<lista></lista>)
                    Dim i As Integer = 0
                    For i = 0 To chkListaDeChecks.Items.Count - 1
                        Dim ischecked As Boolean = chkListaDeChecks.GetItemChecked(i)
                        xml.Root.Add(<item ischecked=<%= ischecked %>><%= chkListaDeChecks.Items(i) %></item>)
                    Next
                    'Valor = xml.ToString()
                    DXML = xml.Root
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Case TipoDato.Expresion
                'Dim xml As New Xml.Linq.XDocument()
                'xml.Add(<Expresion><%= txtExpression.Text %></Expresion>)
                'DXML = xml.Root
        End Select
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txt_IntegerValue_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rb_No.KeyUp, rb_Si.KeyUp, txt_IntegerValue.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.bt_Aceptar.Focus()
        End If
    End Sub

    'Private Sub btnEditarExpresion_Click(sender As Object, e As EventArgs)
    '    Dim frm As New frmRC_Expresiones
    '    frm.Expresion = DXML.Value

    '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        txtExpression.Text = frm.Expresion
    '    End If
    'End Sub

    Private Sub lblCaracteresRestantes_TextChanged(sender As Object, e As EventArgs) Handles lblCaracteresRestantes.TextChanged
        Me.lblCaracteresRestantes.Text = CStr(Me.txt_TextValue.MaxLength - Me.txt_TextValue.TextLength)
    End Sub
End Class