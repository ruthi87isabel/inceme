Imports System.Xml
Imports System.IO
Imports Janus.Windows.GridEX
Imports System.Linq
Imports System.Xml.Linq

Public Class frmConfiguracionColumnasJanusGridEx

    Private Enum TipoOrdenamiento As Byte
        None
        Agrupadores
        Columnas
    End Enum

    Private ordenCollection As New GridTipoOrdenCollection

#Region "Propiedades"

    Private _columnas As List(Of Columna)
    Private _gridOriginalExColumns As List(Of GridEXColumn)

    Public Property Columnas As List(Of GridEXColumn)
        Set(ByVal value As List(Of GridEXColumn))
            _gridOriginalExColumns = value
            Dim currentCol As Columna

            _columnas = New List(Of Columna)

            For Each gridExCol As GridEXColumn In value
                currentCol = New Columna()
                currentCol.Caption = gridExCol.Caption
                currentCol.ColSpan = gridExCol.ColSpan
                currentCol.Column = gridExCol.ColumnSetColumn
                currentCol.Row = gridExCol.ColumnSetRow
                currentCol.Key = gridExCol.Key

                _columnas.Add(currentCol)
            Next
        End Set
        Get
            Return _gridOriginalExColumns
        End Get
    End Property

    Private _rootTable As GridEXTable
    Public Property RootTable() As GridEXTable
        Get
            Return _rootTable
        End Get
        Set(ByVal value As GridEXTable)
            _rootTable = value
        End Set
    End Property

#End Region

    Private Sub CreaEstruturaDesdeRootTable()
        If (_rootTable Is Nothing) Then Exit Sub

        Dim currentColumnSet As Agrupador
        Dim currentColumn As Columna

        For Each col As GridEXColumn In RootTable.Columns

            currentColumn = New Columna()
            currentColumn.Caption = col.Caption
            currentColumn.Key = col.Key
            currentColumn.Column = col.ColumnSetColumn
            currentColumn.Row = col.ColumnSetRow
            currentColumn.ColSpan = col.ColSpan
            currentColumn.RowSpan = col.RowSpan

            If col.ColumnSet Is Nothing Then
                ordenCollection.Add(currentColumn)
            Else
                If (Not ordenCollection.ExisteColumnSet(col.ColumnSet.Index)) Then
                    currentColumnSet = New Agrupador()
                    currentColumnSet.Nombre = col.ColumnSet.Caption
                    currentColumnSet.Index = col.ColumnSet.Index
                    currentColumnSet.NoColumnas = col.ColumnSet.ColumnCount
                    currentColumnSet.Filas = RootTable.ColumnSetRowCount

                    For index As Integer = 0 To col.ColumnSet.ColumnCount - 1
                        currentColumnSet.AnchoColumnas.Add(col.ColumnSet.GetColumnWidth(index))
                    Next

                    ordenCollection.Add(currentColumnSet)
                End If
                ordenCollection.AgregaColumnaAgrupador(currentColumn, col.ColumnSet.Index)
            End If
        Next
    End Sub

    Private Sub CreaAgrupador()
        Dim frm As New frmAgrupador()

        If (frm.ShowDialog() = DialogResult.OK) Then
            Dim tn As New TreeNode()
            tn.Text = frm.Agrupador.Nombre
            tn.Tag = frm.Agrupador

            ordenCollection.Add(frm.Agrupador)
            trvOrganizadorGrid.Nodes.Add(tn)
        End If

    End Sub

    Private Sub EliminaAgrupador()
        If (trvOrganizadorGrid.SelectedNode Is Nothing) Then Return

        If (Not TypeOf (trvOrganizadorGrid.SelectedNode.Tag) Is Agrupador) Then Return

        ordenCollection.Remove(CType(trvOrganizadorGrid.SelectedNode.Tag, Agrupador))

        If (trvOrganizadorGrid.SelectedNode.Nodes.Count > 0) Then
            For Each node As TreeNode In trvOrganizadorGrid.SelectedNode.Nodes
                lbxColumnas.Items.Add(node.Tag)
            Next
        End If

        trvOrganizadorGrid.SelectedNode.Remove()
    End Sub

    Private Sub AdicionaColumnaAgrupador(ByVal columna As Columna)
        Dim tNode As New TreeNode()

        tNode.Text = columna.ToString()
        tNode.Tag = columna

        If (trvOrganizadorGrid.SelectedNode Is Nothing) Then
            ordenCollection.Add(columna)
            trvOrganizadorGrid.Nodes.Add(tNode)

            lbxColumnas.Items.Remove(lbxColumnas.SelectedItem)
        Else
            Dim _frmColumna As New frmColumna()
            _frmColumna.Columna = columna

            If (DialogResult.OK = _frmColumna.ShowDialog()) Then

                ordenCollection.AgregaColumnaAgrupador(columna, CType(trvOrganizadorGrid.SelectedNode.Tag, Agrupador).Index)

                tNode.Tag = _frmColumna.Columna

                trvOrganizadorGrid.SelectedNode.Nodes.Add(tNode)
                trvOrganizadorGrid.SelectedNode.Expand()

                lbxColumnas.Items.Remove(lbxColumnas.SelectedItem)
            End If
        End If
    End Sub

    Private Sub AdicionaColumnaRoot(ByVal columna As Object)
        trvOrganizadorGrid.SelectedNode = Nothing
        AdicionaColumnaAgrupador(columna)
    End Sub

#Region "Eventos TreeView"

    Private Sub btnNuevoAgrupador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoAgrupador.Click
        CreaAgrupador()
    End Sub

    Private Sub btnEliminarAgrupador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarAgrupador.Click
        EliminaAgrupador()
    End Sub

    Private Sub btnModificarAgrupador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarAgrupador.Click
        If (trvOrganizadorGrid.SelectedNode Is Nothing) Then Return

        If (TypeOf (trvOrganizadorGrid.SelectedNode.Tag) Is Agrupador) Then ModificaAgrupador(CType(trvOrganizadorGrid.SelectedNode.Tag, Agrupador))
    End Sub

#End Region

#Region "Eventos Columnas"

    Private Sub btnInsertarColumna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertarColumna.Click
        If (lbxColumnas.SelectedItem Is Nothing) Then
            If lbxColumnas.Items.Count = 0 Then
                Return
            Else
                lbxColumnas.SelectedIndex = 0
            End If
        End If

        If (trvOrganizadorGrid.SelectedNode Is Nothing) Then
            AdicionaColumnaRoot(lbxColumnas.SelectedItem)
            Exit Sub
        ElseIf (TypeOf (trvOrganizadorGrid.SelectedNode.Tag) Is Columna) Then
            AdicionaColumnaRoot(lbxColumnas.SelectedItem)
            Exit Sub
        End If

        AdicionaColumnaAgrupador(lbxColumnas.SelectedItem)
    End Sub

    Private Sub btnEliminarColumna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarColumna.Click

        If (trvOrganizadorGrid.SelectedNode Is Nothing) Then Return

        If (TypeOf (trvOrganizadorGrid.SelectedNode.Tag) Is Agrupador) Then Return

        Dim currentCol As Columna = CType(trvOrganizadorGrid.SelectedNode.Tag, Columna)
        ordenCollection.EliminaColumna(currentCol.Key)
        trvOrganizadorGrid.SelectedNode.Remove()

        ActualizaColumnas()
    End Sub

#End Region

    'Llenar listbox de columnas no visibles en el grid
    Private Sub ActualizaColumnas()

        lbxColumnas.Items.Clear()

        For Each c As Columna In _columnas
            If (Not ordenCollection.ExisteColumna(c.Key)) Then
                lbxColumnas.Items.Add(c)
            End If
        Next

    End Sub

    'Mostrar estructura del grid en forma de árbol
    Private Sub ActualizaTree()

        Dim currentNode, currentColumnSetNode As TreeNode
        Dim currentCol As Columna
        Dim currentColSet As Agrupador
        Dim i As Integer

        For Each item As IGridTipoOrden In ordenCollection

            If (TypeOf (item) Is Columna) Then
                currentCol = CType(item, Columna)
                currentNode = New TreeNode()
                currentNode.Text = IIf(String.IsNullOrEmpty(currentCol.Caption), currentCol.Key, currentCol.Caption)
                currentNode.Tag = currentCol

            Else
                currentColSet = CType(item, Agrupador)
                currentNode = New TreeNode()
                i += 1
                currentNode.Text = IIf(String.IsNullOrEmpty(currentColSet.Nombre), String.Format("Agrupador {0}", i), currentColSet.Nombre)
                currentNode.Tag = currentColSet

                For Each col As Columna In currentColSet.Columnas
                    currentColumnSetNode = New TreeNode()
                    currentColumnSetNode.Text = col.ToString()
                    currentColumnSetNode.Tag = col
                    currentNode.Nodes.Add(currentColumnSetNode)
                Next
            End If

            trvOrganizadorGrid.Nodes.Add(currentNode)

        Next

        trvOrganizadorGrid.ExpandAll()
    End Sub

    Private Sub frmConfiguracionColumnasJanusGridEx_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreaEstruturaDesdeRootTable()

        ActualizaColumnas()

        ActualizaTree()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ModificaAgrupador(ByVal agrupador As Agrupador)

        Dim fr As New frmAgrupador()
        fr.Agrupador = agrupador

        If (DialogResult.OK = fr.ShowDialog()) Then
            trvOrganizadorGrid.SelectedNode.Text = fr.Agrupador.Nombre

            Dim index As Integer = ordenCollection.IndexOf(trvOrganizadorGrid.SelectedNode.Tag)
            CType(ordenCollection(index), Agrupador).Filas = fr.Agrupador.Filas
            CType(ordenCollection(index), Agrupador).NoColumnas = fr.Agrupador.NoColumnas
            CType(ordenCollection(index), Agrupador).Nombre = fr.Agrupador.Nombre
        End If

    End Sub

    Private Sub bt_down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_down.Click
        If (trvOrganizadorGrid.SelectedNode Is Nothing Or trvOrganizadorGrid.SelectedNode.Index = 0) Then Return

        Dim current As TreeNode = trvOrganizadorGrid.SelectedNode

        If (TypeOf (trvOrganizadorGrid.SelectedNode.Tag) Is Agrupador) Then
            ordenCollection.MoveColumnSet(CType(trvOrganizadorGrid.SelectedNode.Tag, Agrupador).Index, 1)

            trvOrganizadorGrid.Nodes.RemoveAt(trvOrganizadorGrid.SelectedNode.Index)
            trvOrganizadorGrid.Nodes.Insert(current.Index + 1, current)
        Else
            Dim i As Integer = trvOrganizadorGrid.SelectedNode.Index

            If trvOrganizadorGrid.SelectedNode.Parent Is Nothing Then
                trvOrganizadorGrid.SelectedNode.Nodes.RemoveAt(trvOrganizadorGrid.SelectedNode.Index)
                trvOrganizadorGrid.SelectedNode.Nodes.Insert(i + 1, current)
            Else
                trvOrganizadorGrid.SelectedNode.Parent.Nodes.RemoveAt(trvOrganizadorGrid.SelectedNode.Index)
                trvOrganizadorGrid.SelectedNode.Parent.Nodes.Insert(i + 1, current)
            End If

            ordenCollection.MoveColumn(CType(trvOrganizadorGrid.SelectedNode.Tag, Columna).Key, 1)

        End If

        trvOrganizadorGrid.SelectedNode = current
    End Sub

    Private Sub bt_up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_up.Click
        If (trvOrganizadorGrid.SelectedNode Is Nothing Or trvOrganizadorGrid.SelectedNode.Index = 0) Then Return

        Dim current As TreeNode = trvOrganizadorGrid.SelectedNode

        If (TypeOf (trvOrganizadorGrid.SelectedNode.Tag) Is Agrupador) Then
            ordenCollection.MoveColumnSet(CType(trvOrganizadorGrid.SelectedNode.Tag, Agrupador).Index, -1)

            trvOrganizadorGrid.Nodes.RemoveAt(trvOrganizadorGrid.SelectedNode.Index)
            trvOrganizadorGrid.Nodes.Insert(current.Index - 1, current)

        Else
            Dim i As Integer = trvOrganizadorGrid.SelectedNode.Index

            If trvOrganizadorGrid.SelectedNode.Parent Is Nothing Then
                trvOrganizadorGrid.SelectedNode.Nodes.RemoveAt(trvOrganizadorGrid.SelectedNode.Index)
                trvOrganizadorGrid.SelectedNode.Nodes.Insert(i - 1, current)
            Else
                trvOrganizadorGrid.SelectedNode.Parent.Nodes.RemoveAt(trvOrganizadorGrid.SelectedNode.Index)
                trvOrganizadorGrid.SelectedNode.Parent.Nodes.Insert(i - 1, current)
            End If

            ordenCollection.MoveColumn(CType(trvOrganizadorGrid.SelectedNode.Tag, Columna).Key, -1)
        End If

        trvOrganizadorGrid.SelectedNode = current

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim frm As New frmConfiguracionColumnasPreview()
        frm.RootTable = GetCurrentRootTable()
        frm.ShowDialog()
    End Sub

    Private Sub trvOrganizadorGrid_BeforeSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trvOrganizadorGrid.BeforeSelect
        Dim result As Boolean = TypeOf (e.Node.Tag) Is Agrupador
        btnEliminarAgrupador.Enabled = result
        btnModificarAgrupador.Enabled = result
    End Sub


    Private Function GetCurrentRootTable() As GridEXTable
        Dim rootTable As New GridEXTable()

        rootTable.Caption = _rootTable.Caption
        rootTable.Key = _rootTable.Key

        If (ordenCollection.ContieneAgrupadores()) Then
            rootTable.CellLayoutMode = CellLayoutMode.UseColumnSets
            rootTable.ColumnSetRowCount = ordenCollection.MaxRow
        Else
            rootTable.CellLayoutMode = CellLayoutMode.UseColumns
        End If

        For Each item As IGridTipoOrden In ordenCollection
            If (TypeOf (item) Is Columna) Then
                Dim col As Columna = CType(item, Columna)
                Dim tmpGridExColumn As GridEXColumn = Me._gridOriginalExColumns.SingleOrDefault(Function(u) u.Key = col.Key)

                If (tmpGridExColumn Is Nothing) Then Continue For

                Dim t As GridEXColumn = SetColumnProperties(tmpGridExColumn, col.Caption, rootTable)

            Else
                Dim ag As Agrupador = CType(item, Agrupador)

                Dim currentColumnSet As GridEXColumnSet = rootTable.ColumnSets.Add()
                currentColumnSet.ColumnCount = ag.NoColumnas

                For Each columnAg As Columna In ag.Columnas

                    Dim colColSet As Columna = CType(columnAg, Columna)

                    Dim tmpGridExColumn As GridEXColumn = _rootTable.Columns(colColSet.Key)
                    If (tmpGridExColumn Is Nothing) Then Continue For

                    Dim t As GridEXColumn = SetColumnProperties(tmpGridExColumn, colColSet.Caption, rootTable)

                    currentColumnSet.SetColumnWidth(colColSet.Column, t.Width)
                    currentColumnSet.Add(t, colColSet.Row, colColSet.Column, IIf(colColSet.RowSpan = 0, 1, colColSet.RowSpan), IIf(colColSet.ColSpan = 0, 1, colColSet.ColSpan))
                Next

            End If
        Next

        Return rootTable
    End Function

    Public Shared Function SetColumnProperties(ByVal tmpGridExColumn As GridEXColumn, ByVal colName As String, ByRef rootTable As GridEXTable) As GridEXColumn
        Dim t As GridEXColumn = rootTable.Columns.Add()
        t.Key = tmpGridExColumn.Key

        t.Caption = colName

        t.ActAsSelector = tmpGridExColumn.ActAsSelector
        t.AllowDrag = tmpGridExColumn.AllowDrag
        t.AllowGroup = tmpGridExColumn.AllowGroup
        t.AllowRemove = tmpGridExColumn.AllowRemove
        t.AllowSize = tmpGridExColumn.AllowSize
        t.AllowSort = tmpGridExColumn.AllowSort
        t.AutoComplete = tmpGridExColumn.AutoComplete
        t.AutoSizeMode = tmpGridExColumn.AutoSizeMode

        t.BottomMargin = tmpGridExColumn.BottomMargin
        t.BoundImageMaskColor = tmpGridExColumn.BoundImageMaskColor
        t.BoundImageSize = tmpGridExColumn.BoundImageSize
        t.BoundMode = tmpGridExColumn.BoundMode
        t.ButtonDisplayMode = tmpGridExColumn.ButtonDisplayMode
        t.ButtonImage = tmpGridExColumn.ButtonImage
        t.ButtonStyle = tmpGridExColumn.ButtonStyle
        t.ButtonText = tmpGridExColumn.ButtonText
        t.ButtonToolTipText = tmpGridExColumn.ButtonToolTipText

        t.CalendarNoneButtonVisible = tmpGridExColumn.CalendarNoneButtonVisible
        t.CalendarTodayButtonVisible = tmpGridExColumn.CalendarTodayButtonVisible
        t.CardCaption = tmpGridExColumn.CardCaption
        t.CardIcon = tmpGridExColumn.CardIcon
        t.CardViewCaptionVisible = tmpGridExColumn.CardViewCaptionVisible
        t.CharacterCasing = tmpGridExColumn.CharacterCasing
        t.CheckBoxAlignment = tmpGridExColumn.CheckBoxAlignment
        t.CheckBoxFalseValue = tmpGridExColumn.CheckBoxFalseValue
        t.CheckBoxNullValue = tmpGridExColumn.CheckBoxNullValue
        t.CheckBoxTriState = tmpGridExColumn.CheckBoxTriState
        t.CheckBoxTrueValue = tmpGridExColumn.CheckBoxTrueValue
        t.ColumnType = tmpGridExColumn.ColumnType
        t.CompareIgnoreCase = tmpGridExColumn.CompareIgnoreCase
        t.CompareTarget = tmpGridExColumn.CompareTarget
        t.CustomGroup = tmpGridExColumn.CustomGroup

        If (tmpGridExColumn.BoundMode = ColumnBoundMode.Unbound) Then t.DataTypeCode = tmpGridExColumn.DataTypeCode

        t.DataMember = tmpGridExColumn.DataMember
        t.DefaultFilterRowComparison = tmpGridExColumn.DefaultFilterRowComparison
        t.DefaultGroupFormatMode = tmpGridExColumn.DefaultFilterRowComparison
        t.DefaultGroupFormatString = tmpGridExColumn.DefaultGroupFormatString
        t.DefaultGroupInterval = tmpGridExColumn.DefaultGroupInterval
        t.DefaultGroupPrefix = tmpGridExColumn.DefaultGroupPrefix
        t.DefaultValue = tmpGridExColumn.DefaultValue
        t.DropDown = tmpGridExColumn.DropDown

        t.EditButtonDisplayMode = tmpGridExColumn.EditButtonDisplayMode
        t.EditTarget = tmpGridExColumn.EditTarget
        t.EditType = tmpGridExColumn.EditType
        t.EditValueList = tmpGridExColumn.EditValueList
        t.EmptyStringValue = tmpGridExColumn.EmptyStringValue

        t.FilterEditType = tmpGridExColumn.FilterEditType
        t.FilterRowButtonStyle = tmpGridExColumn.FilterRowButtonStyle
        t.FilterRowComparison = tmpGridExColumn.FilterRowComparison
        t.FormatMode = tmpGridExColumn.FormatMode
        t.FormatString = tmpGridExColumn.FormatString

        t.GroupComparer = tmpGridExColumn.GroupComparer
        t.GroupEmptyString = tmpGridExColumn.GroupEmptyString

        t.HasValueList = tmpGridExColumn.HasValueList
        t.HeaderAlignment = tmpGridExColumn.HeaderAlignment
        t.HeaderImage = tmpGridExColumn.HeaderImage
        t.HeaderImageIndex = tmpGridExColumn.HeaderImageIndex
        t.HeaderImageKey = tmpGridExColumn.HeaderImageKey
        t.HeaderLineAlignment = tmpGridExColumn.HeaderLineAlignment
        t.HideWhenGrouped = tmpGridExColumn.HideWhenGrouped

        t.Image = tmpGridExColumn.Image
        t.ImageIndex = tmpGridExColumn.ImageIndex
        t.ImageKey = tmpGridExColumn.ImageKey
        t.IncludeLiterals = tmpGridExColumn.IncludeLiterals
        t.InputMask = tmpGridExColumn.InputMask
        t.InvalidValueAction = tmpGridExColumn.InvalidValueAction

        t.LeftMargin = tmpGridExColumn.LeftMargin
        t.LimitToList = tmpGridExColumn.LimitToList
        t.LineAlignment = tmpGridExColumn.LineAlignment

        t.MaskPrompt = tmpGridExColumn.MaskPrompt
        t.MaxLength = tmpGridExColumn.MaxLength
        t.MaxLines = tmpGridExColumn.MaxLength
        t.MinLines = tmpGridExColumn.MinLines
        t.MultipleValueDataMember = tmpGridExColumn.MultipleValueDataMember
        t.MultipleValues = tmpGridExColumn.MultipleValues

        t.NullText = tmpGridExColumn.NullText

        t.OwnerDrawnMode = tmpGridExColumn.OwnerDrawnMode

        t.PasswordChar = tmpGridExColumn.PasswordChar
        t.PrintMode = tmpGridExColumn.PrintMode

        t.RightMargin = tmpGridExColumn.RightMargin
        t.RightToLeft = tmpGridExColumn.RightToLeft

        t.SortComparer = tmpGridExColumn.SortComparer
        t.ShowInFieldChooser = tmpGridExColumn.ShowInFieldChooser
        t.ShowRowSelector = tmpGridExColumn.ShowRowSelector
        t.SortIndicator = tmpGridExColumn.SortIndicator

        t.Tag = tmpGridExColumn.Tag
        t.TextAlignment = tmpGridExColumn.TextAlignment
        t.TopMargin = tmpGridExColumn.TopMargin
        t.TotalFormatMode = tmpGridExColumn.TotalFormatMode
        t.TotalFormatString = tmpGridExColumn.TotalFormatString
        t.Trimming = tmpGridExColumn.Trimming

        t.UpDownIncrement = tmpGridExColumn.UpDownIncrement
        t.UpDownMaximum = tmpGridExColumn.UpDownMaximum
        t.UpDownMinimum = tmpGridExColumn.UpDownMinimum
        t.UseHeaderSelector = tmpGridExColumn.UseHeaderSelector

        t.Visible = tmpGridExColumn.Visible

        t.Width = tmpGridExColumn.Width
        t.WordWrap = tmpGridExColumn.WordWrap

        Return t
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        RootTable = GetCurrentRootTable()
        SerializeXML()

        Me.Close()
    End Sub

    Private Sub SerializeXML()
        'Dim columns As List(Of XElement)
        'Dim columnSets As List(Of XElement)
        'Dim currentColumn As XElement
        'Dim currentColumnSet As XElement

        Dim config As XElement = New XElement(Globales.Usuario.CONFIGURACIONXML)

        If (config.<Listados>.Count() = 0) Then
            config.Add(<Listados></Listados>)
        End If

        Dim cElement As XElement
        If (config.<Listados>.Elements.Count(Function(l) l.Name = RootTable.Key) = 0) Then
            cElement = XElement.Parse(String.Format("<{0}></{0}>", RootTable.Key))
            config.<Listados>.First().Add(cElement)
        Else
            cElement = config.<Listados>.Elements.First(Function(l) l.Name = RootTable.Key)
        End If

        'borrar la configuracion anterior existente para incluir la nueva
        cElement.RemoveNodes()


        cElement.Add(<Columns></Columns>)

        cElement.Add(<ColumnsSets></ColumnsSets>)

        cElement.Add(<Key></Key>)

        cElement.Add(<Caption></Caption>)

        cElement.Add(<CellLayoutMode></CellLayoutMode>)


        'guardar los valores de la rootTable
        With cElement
            .<CellLayoutMode>.First().SetValue(RootTable.CellLayoutMode)
            .<Key>.First().SetValue(RootTable.Key)
            .<Caption>.First.SetValue(RootTable.Caption)
        End With

        For Each item As IGridTipoOrden In ordenCollection
            If TypeOf item Is Agrupador Then
                cElement.<ColumnsSets>.First().Add(CreateColumnSet(item))
                For Each column As Columna In CType(item, Agrupador).Columnas
                    cElement.<Columns>.First().Add(CreateColumn(column))
                Next
            Else
                cElement.<Columns>.First().Add(CreateColumn(CType(item, Columna)))
            End If
        Next

        'guardar los cambios

        

        Globales.Usuario.CONFIGURACIONXML = config
        Globales.Context.SubmitChanges()
    End Sub
    Private Function CreateColumnSet(ByVal columnSet As Agrupador) As XElement
        Dim result As XElement = _
            <ColumnSet>
                <Key></Key>
                <ColumnWidth></ColumnWidth>
                <ColumnCount></ColumnCount>
                <ColumnsKey></ColumnsKey>
            </ColumnSet>
        result.<Key>.First().SetValue(columnSet.Nombre)
        result.<ColumnWidth>.First().SetValue(String.Join(", ", columnSet.AnchoColumnas.Select(Function(c) c.ToString()).ToArray()))
        result.<ColumnCount>.First().SetValue(columnSet.NoColumnas)
        result.<ColumnsKey>.First().SetValue(String.Join(", ", columnSet.Columnas.Select(Function(c) c.Key).ToArray()))

        Return result
    End Function
    Private Function CreateColumn(ByVal column As Columna) As XElement
        Dim result As XElement = _
            <Column>
                <Key></Key>
                <Row></Row>
                <Col></Col>
                <Rowspan></Rowspan>
                <Colspan></Colspan>
                <Caption></Caption>
            </Column>
        result.<Key>.First().SetValue(column.Key)
        result.<Row>.First().SetValue(column.Row)
        result.<Col>.First().SetValue(column.Column)
        result.<Rowspan>.First().SetValue(column.RowSpan)
        result.<Colspan>.First().SetValue(column.ColSpan)
        result.<Caption>.First().SetValue(column.Caption)

        Return result
    End Function

    Private Sub UnSerializeXML()
        Dim lstPacientes As XElement = Globales.Usuario.CONFIGURACIONXML.<Listados>.<Pacientes>
        'cargar los valores del rootTable
        RootTable.Caption = lstPacientes.<Caption>.Value()
        RootTable.Key = lstPacientes.<Key>.Value()
        RootTable.CellLayoutMode = lstPacientes.<CellLayoutMode>.Value()

        'Columnas en el XML
        Dim Columns As IEnumerable(Of XElement) = lstPacientes.<Columns>.<Column>


        'cargar los ColumnSets
        Dim columnSets As IEnumerable(Of XElement) = lstPacientes.<ColumnsSets>.<ColumnsSet>
        For Each cSet As XElement In columnSets
            Dim grupo As Agrupador = New Agrupador()
            grupo.AnchoColumnas = New List(Of Integer)(cSet.<ColumnWidth>.First().Value.Split(", "))
            grupo.NoColumnas = cSet.<ColumnCount>.First().Value

            Dim keys As String() = cSet.<ColumnsKey>.First().Value.Split(", ")
            For Each key As String In keys
                grupo.Columnas.Add(CreateColumna(Columns.Single(Function(e) e.<Key>.Value() = key)))
                Columns = Columns.Where(Function(c) c.<Key>.First().Value <> key)
            Next
            ordenCollection.Add(grupo)
        Next

        'agregar las columnas que no son partes de ningun agrupador
        For Each col As XElement In Columns
            ordenCollection.Add(CreateColumna(col))
        Next

    End Sub

    Private Function CreateColumna(ByVal xmlColumn As XElement) As Columna
        Dim columna As Columna = New Columna()
        With columna
            .Key = xmlColumn.<Key>.Value()
            .Row = xmlColumn.<Row>.Value()
            .Column = xmlColumn.<Col>.Value()
            .RowSpan = xmlColumn.<Rowspan>.Value()
            .ColSpan = xmlColumn.<Colspan>.Value()
            .Caption = xmlColumn.<Caption>.Value()
        End With
    End Function


End Class