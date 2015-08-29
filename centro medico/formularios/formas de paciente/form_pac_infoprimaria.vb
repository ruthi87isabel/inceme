Public Class form_pac_infoprimaria

    Dim fFecha As DateTime
    Dim fDescripcion As String
    Dim fDetalle As String
    Dim fAceptar As Boolean
    Dim fCurrentAccion As Enums.Accion


    Sub New(ByVal aCurrentAccion As Enums.Accion)

        InitializeComponent()
        fCurrentAccion = aCurrentAccion

    End Sub

    Public Property Fecha() As DateTime

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fFecha

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As DateTime)
            fFecha = Value
        End Set
    End Property

    Public Property Descripcion() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fDescripcion

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fDescripcion = Value
        End Set
    End Property


    Public Property Detalle() As String

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fDetalle

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As String)
            fDetalle = Value
        End Set
    End Property


    Public Property Aceptar() As Boolean

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fAceptar

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As Boolean)
            fAceptar = Value
        End Set
    End Property


    Private Sub bt_IPAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_IPAceptar.Click
        fFecha = dtp_IPFecha.Value()
        fDescripcion = tb_IPDescrip.Text()
        fDetalle = tb_IPDetalle.Text()
        fAceptar = True
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bt_IPCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_IPCancelar.Click
        fFecha = Nothing
        fDescripcion = ""
        fDetalle = ""
        fAceptar = False
        Me.Close()
    End Sub

    Private Sub form_pac_infoprimaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fCurrentAccion <> Enums.Accion.Insertar Then
            dtp_IPFecha.Value = fFecha
            tb_IPDescrip.Text = fDescripcion
            tb_IPDetalle.Text = fDetalle
        End If

    End Sub
End Class