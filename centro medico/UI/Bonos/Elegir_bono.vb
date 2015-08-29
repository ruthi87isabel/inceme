Public Class Elegir_bono
    Dim _bonos As ICollection(Of Bonos)
    Public bonoSeleccionado As Integer = -1
    Public Sub New(ByRef bonos As ICollection(Of Bonos))

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _bonos = bonos
        CargaDropDown()

    End Sub

    Private Sub CargaDropDown()
        Dim ds As New BindingSource
        ds.DataSource = _bonos
        ComboBox1.DataSource = ds.DataSource
        ComboBox1.DisplayMember = "descripcionConSesionesLibres"
        ComboBox1.ValueMember = "id"
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub

    Private Sub tlsGuardar_Click(sender As Object, e As EventArgs) Handles tlsGuardar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        bonoSeleccionado = ComboBox1.SelectedValue
        Me.Close()

    End Sub

    Private Sub tlsCancelar_Click(sender As Object, e As EventArgs) Handles tlsCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class