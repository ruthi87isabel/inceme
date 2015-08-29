Public Class frmAlarmas
    Dim modo As Globales.ModoParaFormas
    Public IDALARMA As Nullable(Of Integer)

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.modo = Globales.ModoParaFormas.Seleccion
    End Sub

    Sub New(modo As Globales.ModoParaFormas)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.modo = modo
    End Sub

    Private Sub frmAlarmas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Filtrar_Alarmas()

    End Sub

    Private Sub Filtrar_Alarmas()
        GridEXAlarma.DataSource = Nothing
        Dim context As New CMLinqDataContext()
        Dim alarmas As IQueryable(Of ALARMA) = (From a In context.ALARMAs Select a)

        ALARMABindingSource.DataSource = alarmas
        GridEXAlarma.DataSource = ALARMABindingSource
    End Sub

    Private Sub GridEXAlarma_DoubleClick_1(sender As Object, e As EventArgs) Handles GridEXAlarma.DoubleClick
        If Me.modo = Globales.ModoParaFormas.Seleccion Then
            Me.IDALARMA = GridEXAlarma.SelectedItems(0).GetRow.DataRow.CALARMA
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class