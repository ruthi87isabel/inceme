Public Class ctrlDocProcesados
    Public id_Doc As Integer = -1
    Public tipoDoc As Globales.TipoDocumento
    Dim rayDocRelacionados(,) As String

    Public Sub CargaDocumentosRelacionados()
        Dim tipo As Globales.TipoDocumento
        Dim nodos As TreeNode
        Dim nodoHijo As TreeNode
        Dim i As Integer = 0
        rayDocRelacionados = Globales.DocumentosRelacionados(tipoDoc, id_Doc)
        If Not rayDocRelacionados Is Nothing Then
            For i = 0 To rayDocRelacionados.GetUpperBound(1)
                tipo = rayDocRelacionados(0, i)
                nodos = New TreeNode(tipo.ToString)
                nodos.Name = nodos.Text

                'compruebo si existe el nodo
                If Me.TreeView1.Nodes.Contains(nodos) Then
                    nodoHijo = New TreeNode(rayDocRelacionados(1, i))
                    nodoHijo.Name = nodoHijo.Text
                    Me.TreeView1.Nodes(nodos.Text).Nodes.Add(nodoHijo)
                Else
                    TreeView1.Nodes.Add(nodos)
                    nodoHijo = New TreeNode(rayDocRelacionados(1, i))
                    nodoHijo.Name = nodoHijo.Text
                    Me.TreeView1.Nodes(nodos.Text).Nodes.Add(nodoHijo)
                End If

            Next
        End If
    End Sub

End Class
