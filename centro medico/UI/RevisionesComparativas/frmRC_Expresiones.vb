Imports Ciloci.Flee
Public Class frmRC_Expresiones

    Dim context As ExpressionContext

    Public Campos As New List(Of Campo)

    Private expresionValida As Boolean = False

    Public Property Expresion As String
        Get
            If expresionValida Then
                Return txtExpression.Text
            End If
            Throw New Exception("Expresion no válida: " + txtExpression.Text)
        End Get
        Set(value As String)
            txtExpression.Text = value
        End Set
    End Property

    Public Property OcultarImpresionCliente As Boolean
        Get
            Return chkOcultarImpresionCliente.Checked
        End Get
        Set(value As Boolean)
            chkOcultarImpresionCliente.Checked = value
        End Set
    End Property




    Private Sub frmRC_Expresiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        context = New ExpressionContext()
        context.[Imports].AddType(GetType(Math))
        context.[Imports].AddType(GetType(Date))
        context.Options.ParseCulture = New Globalization.CultureInfo("es-ES")

        'If Campos.Count = 0 Then
        '    Campos.Add(New Campo() With {.Nombre = "Peso", .Valor = 100})
        '    Campos.Add(New Campo() With {.Nombre = "TA max", .Valor = 50})
        '    Campos.Add(New Campo() With {.Nombre = "TA min", .Valor = 40})
        'End If
        
        Dim r As New Random()
        r.Next(100)

        For Each c As Campo In Campos
            If c.Tipo = "N" Then
                c.Valor = r.Next(100)
                context.Variables(c.FormattedName) = c.Valor
            End If
        Next


        GridEX_Resultados.DataSource = Campos

    End Sub


    Private Sub Evaluar()
        expresionValida = False
        ' Create a dynamic expression that evaluates to an Object
        Try
            lblError.Visible = False
            txtResult.Clear()

            
            '' Define an int variable
            'context.Variables("Somos los") = 100

            Dim eDynamic As IDynamicExpression = context.CompileDynamic(Parsea(txtExpression.Text))
            '' Create a generic expression that evaluates to a double
            'Dim eGeneric As IGenericExpression(Of Double) = context.CompileGeneric(Of Double)(txtExpression.Text)





            '' Evaluate the expressions
            Dim result As Double = CDbl(eDynamic.Evaluate())
            'result = eGeneric.Evaluate()

            'txtResult.AppendText(result & vbCrLf)

            '' Update the value of our variable
            'context.Variables("a") = 144
            '' Evaluate again to get the updated result
            'result = eGeneric.Evaluate()
            txtResult.AppendText(result & vbCrLf)
            expresionValida = True


        Catch ex As Exception
            lblError.Visible = True
            'If (ex.Reason = CompileExceptionReason.SyntaxError) Then
            '    lblError.Visible = True
            'Else
            '    MessageBox.Show(ex.Message)

            'End If

        End Try
    End Sub

    Private Sub txtEvaluar_Click(sender As Object, e As EventArgs) Handles txtEvaluar.Click
        Evaluar()
    End Sub

    Function Parsea(ByVal texto As String) As String
        Dim str As String = texto
        For Each campo As Campo In Campos
            str = str.Replace(campo.Nombre, campo.FormattedName)
        Next
        'str = str.Replace(".", ",")
        Return str
    End Function



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Evaluar()
        If Not expresionValida Then
            MessageBox.Show("La expresión no es válida")
            Return
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GridEX_Resultados_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX_Resultados.RowDoubleClick

        Dim campo As Campo = e.Row.DataRow
        txtExpression.AppendText(" " & campo.Nombre & " ")

    End Sub
End Class



Public Class Campo
    Public Property Nombre As String
    Public Property Tipo As String
    Public Property Valor As Object

    Public ReadOnly Property FormattedName() As String
        Get
            Return Nombre.Replace(" ", "_").Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u").Replace("ñ", "nn")
        End Get
    End Property

End Class