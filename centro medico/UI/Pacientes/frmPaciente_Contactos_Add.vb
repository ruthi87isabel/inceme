Public Class frmPaciente_Contactos_Add

    Public context As New CMLinqDataContext()
    Public Contacto As ContactosPaciente

    Public IDPaciente As Long = -1
    Public IDContacto As Long = -1


    Private Sub frmPaciente_Contactos_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IDContacto = -1 Then
            Contacto = ContactosPacienteBindingSource.AddNew()
            Contacto.CPaciente = IDPaciente
            Contacto.Apellidos = ""
            Contacto.CP = ""
            Contacto.Direccion = ""
            Contacto.Email = ""
            Contacto.Fax = ""
            Contacto.Localidad = ""
            Contacto.Movil = ""
            Contacto.Nombre = ""
            Contacto.Notas = ""
            Contacto.Pais = ""
            Contacto.Parentesco = ""
            Contacto.Telefono = ""

            ''
            context.ContactosPacientes.InsertOnSubmit(Contacto)

        Else
            Contacto = (From c In context.ContactosPacientes _
                       Where c.IdContacto = IDContacto _
                       Select c).Single()

            ContactosPacienteBindingSource.Add(Contacto)
            'context.ContactosPacientes.Attach(Contacto)
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ContactosPacienteBindingSource.EndEdit()
        context.SubmitChanges()
        Me.Close()
    End Sub
End Class