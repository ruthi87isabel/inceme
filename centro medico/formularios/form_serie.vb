Public Class form_serie

    Dim fSerie As String
    Dim fContador As Integer
    Dim fcurrentAcc As Enums.Accion
    Dim fId As String



    Sub New(ByVal aText As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        CurrentAccion = aCurrentAccion
        fId = aId
        Me.Text = aText


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



    Public Property Serie() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fSerie

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fSerie = Value
        End Set
    End Property

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Dim _serie As String = tb_serie.Text
        Dim _contador As Integer = 0

        Try
            _contador = Integer.Parse(Me.tb_contador.Text)
        Catch ex As Exception
            _contador = 0
        End Try
        Try
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                SERIESTableAdapter.Update(_serie, _contador, fSerie, fContador)
            Else
                SERIESTableAdapter.Insert(_serie, _contador)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en los datos introducidos, corríjalos")
            Return
        End Try

        Close()

    End Sub
    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Close()
    End Sub

    Private Sub form_serie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
    End Sub

    Private Sub Inicializa()
        Dim _data As CMDataSet.SERIESDataTable = SERIESTableAdapter.GetSerieByCodigo(fId)
        fSerie = _data.Rows(0).Item("CODIGO").ToString()
        tb_serie.Text = fSerie
        fContador = _data.Rows(0).Item("CONTADOR")
        tb_contador.Text = fContador.ToString()

    End Sub


    Private Sub ChequearTextboxSoloNumero(ByVal aTexbox As TextBox)
        Dim _text As String = aTexbox.Text
        Dim _number As Single
        Dim _texto As String = ""
        Dim modif As Integer = _text.Length
        If _text <> "" And _text <> Nothing Then
            If _text.Length > 0 Then
                Dim i As Integer
                For i = 0 To _text.Length - 1
                    If Not Integer.TryParse(_text(i), _number) Then
                        modif = i
                        Continue For
                    Else
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

    Private Sub tb_contador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_contador.TextChanged
        ChequearTextboxSoloNumero(tb_contador)
    End Sub
End Class