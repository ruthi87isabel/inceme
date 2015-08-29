Imports Janus

Public Class frmConfiguracionColumnasPreview

    Private _rootTable As Windows.GridEX.GridEXTable
    Public Property RootTable() As Windows.GridEX.GridEXTable
        Get
            Return _rootTable
        End Get
        Set(ByVal value As Windows.GridEX.GridEXTable)
            _rootTable = value
        End Set
    End Property

    Private Sub frmConfiguracionColumnasPreview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GridEX1.RootTable = RootTable
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class