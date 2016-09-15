Imports Janus.Windows.GridEX
Imports System.Xml.Linq

Public Class FormConfigurable
    Inherits System.Windows.Forms.Form

   

    Public Overridable Sub Configure()

        Dim frmConfig As New frmConfiguracionColumnasJanusGridEx()
        frmConfig.Columnas = Me.OriginalColumns
        frmConfig.RootTable = Me.GridEX1.RootTable

        If (frmConfig.ShowDialog() = DialogResult.OK) Then
            Me.GridEX1.RootTable = frmConfig.RootTable
            PopulateGrid()
        End If

    End Sub


    Public WithEvents GridEX1 As GridEX

    Protected OriginalColumns As New List(Of GridEXColumn)

    Protected Overridable Sub PopulateGrid()
    End Sub

    Protected Sub UnSerializeXML()

        Dim cm As New CMLinqDataContext()
        Dim currentUser As USUARIO = cm.USUARIOs.SingleOrDefault(Function(u) u.CODIGO = form_new_centro_medico.IDUser)

        If currentUser.CONFIGURACIONXML.<Listados>.Count() = 0 Then Exit Sub
        If GridEX1 Is Nothing Then Exit Sub
        If GridEX1.RootTable Is Nothing Then Exit Sub

        Dim lst As XElement = currentUser.CONFIGURACIONXML.<Listados>.Elements.SingleOrDefault(Function(u) u.Name = GridEX1.RootTable.Key)

        If lst Is Nothing Then Exit Sub

        Dim RootTable As Janus.Windows.GridEX.GridEXTable = GridEX1.RootTable
        RootTable.Columns.Clear()
        RootTable.ColumnSets.Clear()

        'cargar los valores del rootTable
        RootTable.Caption = lst.<Caption>.Value()
        RootTable.Key = lst.<Key>.Value()
        RootTable.CellLayoutMode = [Enum].Parse(GetType(CellLayoutMode), lst.<CellLayoutMode>.Value())

        'Columnas en el XML
        Dim Columns As IEnumerable(Of XElement) = lst.<Columns>.<Column>
        Dim gridColumn As Janus.Windows.GridEX.GridEXColumn

        For Each xmlColumn As XElement In Columns
            Dim col As GridEXColumn = OriginalColumns.SingleOrDefault(Function(m) m.Key = xmlColumn.<Key>.Value())
            gridColumn = frmConfiguracionColumnasJanusGridEx.SetColumnProperties(col, xmlColumn.<Caption>.Value(), GridEX1.RootTable)
        Next

        'cargar los ColumnSets
        Dim columnSets As IEnumerable(Of XElement) = lst.<ColumnsSets>.<ColumnSet>
        Dim gridSets As Janus.Windows.GridEX.GridEXColumnSet
        Dim xmlCol As XElement
        For Each xmlSet As XElement In columnSets
            gridSets = RootTable.ColumnSets.Add()
            gridSets.ColumnCount = xmlSet.<ColumnCount>.Value()
            gridSets.Key = xmlSet.<Key>.Value()


            Dim keys As String() = xmlSet.<ColumnsKey>.Value().Split(", ")
            Dim widths As Integer() = xmlSet.<ColumnWidth>.Value().Split(", ").Select(Function(s) Integer.Parse(s)).ToArray()
            For i As Integer = 0 To widths.Count() - 1
                Dim col As Janus.Windows.GridEX.GridEXColumn = GridEX1.RootTable.Columns(keys(i).Trim())
                xmlCol = Columns.First(Function(c) c.Descendants(XName.Get("Key")).Value = col.Key)
                gridSets.Add(col, xmlCol.<Row>.Value(), xmlCol.<Col>.Value(), xmlCol.<Rowspan>.Value(), xmlCol.<Colspan>.Value())
                gridSets.SetColumnWidth(i, widths(i))
            Next
        Next
    End Sub

    Private Sub FormConfigurable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            UnSerializeXML()
            PopulateGrid()
        End If
    End Sub

    Public Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'FormConfigurable
        '
        Me.GridEX1 = New GridEX()
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Name = "FormConfigurable"
        Me.ResumeLayout(False)


    End Sub
End Class
