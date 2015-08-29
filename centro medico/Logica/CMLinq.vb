Imports System.Data.Linq
Imports System.Data.Linq.Mapping

Partial Class CMLinqDataContext
#Region "PAGOSPACIENTE"
    Private Sub DeletePagosPaciente(instance As PagosPaciente)
        Dim mensaje As String
        mensaje = Globales.Usuario.NOMBRECOMPLETO & " elimina el pago del paciente " & instance.PACIENTE.NombreCompleto & " de " & instance.Importe & "Euros"
        If mensaje.Length > 299 Then
            mensaje = Mid(mensaje, 0, 299)
        End If

        Me.ExecuteDynamicDelete(instance)
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.PagosPaciente, "Eliminacion Entrega Dinero", instance.IDEntrega, mensaje)
    End Sub
#End Region

#Region "HORARIOS_MEDICOS"
    Private Sub InsertHORARIOS_MEDICOS(instance As HORARIOS_MEDICOS)
        'forzamos la fecha de la horaini y fin a la misma que el campo fecha.
        instance.hora_ini = New Date(instance.fecha.Year, instance.fecha.Month, instance.fecha.Day, instance.hora_ini.Hour, instance.hora_ini.Minute, 0)
        instance.hora_fin = New Date(instance.fecha.Year, instance.fecha.Month, instance.fecha.Day, instance.hora_fin.Hour, instance.hora_fin.Minute, 0)
        Me.ExecuteDynamicInsert(instance)
    End Sub
#End Region

#Region "N_TICKETS"
    Private Sub InsertN_Ticket(instance As N_Ticket)
        'cuando se crea un nuevo ticket el total debe ser 0 y no NULL
        If instance.Total Is Nothing Then
            instance.Total = 0
        End If

        Me.ExecuteDynamicInsert(instance)
    End Sub
#End Region

#Region "CITAS"

    Private Sub UpdateCITA(instance As CITA)
        'COMPROBAMOS SI ATENDIDA ESTA MARCADA, EN CASO AFIRMATIVO MARCAMOS TAMBIÉN CONFIRMADA
        If instance.ATENDIDO = "S" Then
            instance.CONFIRMADA = "S"
        End If

        Me.ExecuteDynamicUpdate(instance)
    End Sub
#End Region

#Region "BONOS"
    Private Sub InsertBonos(instance As Bonos)
        'Registramos en auditoria la creación de bonos



        Me.ExecuteDynamicInsert(instance)
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Bonos, "Bonos", instance.id, "Creación de un bono por el usuario " & Globales.Usuario.NOMBRECOMPLETO & "(" & Globales.Usuario.CODIGO & ")")
    End Sub

    Private Sub UpdateBonos(instance As Bonos)
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Bonos, "Bonos", instance.id, "Actualización de un bono por el usuario " & Globales.Usuario.NOMBRECOMPLETO & "(" & Globales.Usuario.CODIGO & ")")

        Me.ExecuteDynamicUpdate(instance)
    End Sub

    Private Sub DeleteBonos(instance As Bonos)
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Bonos, "Bonos", instance.id, "Borrado de un bono por el usuario " & Globales.Usuario.NOMBRECOMPLETO & "(" & Globales.Usuario.CODIGO & ")")

        Me.ExecuteDynamicDelete(instance)
    End Sub

#End Region
#Region "SESIONES"

    Private Sub InsertSesiones(instance As Sesiones)

        Me.ExecuteDynamicInsert(instance)
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Bonos, "Bonos/Sesion", instance.id, "Añadida una sesión al bono " & instance.refbono & " en la cita " & instance.CITA.HORA & " del paciente " & instance.CITA.PACIENTE & "   por el usuario " & Globales.Usuario.NOMBRECOMPLETO & "(" & Globales.Usuario.CODIGO & ")")
    End Sub

    Private Sub DeleteSesiones(instance As Sesiones)
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Bonos, "Bonos/Sesion", instance.id, "Borrado de una sesión del bono " & instance.refbono & " por el usuario " & Globales.Usuario.NOMBRECOMPLETO & "(" & Globales.Usuario.CODIGO & ")")
        Me.ExecuteDynamicDelete(instance)
    End Sub
#End Region

#Region "CITA"
   
#End Region

#Region "PACIENTES"
    Private Sub UpdatePACIENTE(instance As PACIENTE)
        Dim pacienteOld As PACIENTE
        Dim beneficiarios As IEnumerable(Of Asociado)
        Dim cn As New CMLinqDataContext

        If (instance.SOCIO = "N"c) Then
            pacienteOld = (From m In cn.PACIENTEs Where m.CPACIENTE = instance.CPACIENTE).SingleOrDefault
            If pacienteOld.SOCIO = "S"c Then
                beneficiarios = (From b In cn.Asociados Where b.IDPacienteOrigen = instance.CPACIENTE).AsEnumerable
                For Each item As Asociado In beneficiarios
                    cn.Asociados.DeleteOnSubmit(item)
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes, "Beneficiario", item.IDPacienteBeneficiario, "Borrando paciente beneficiario " & item.IDPacienteBeneficiario & " al dejar de ser socio el paciente " & item.IDPacienteOrigen)
                Next
                cn.SubmitChanges()
            End If
        End If
        beneficiarios = Nothing
        pacienteOld = Nothing
        cn.Dispose()
        cn = Nothing

        Me.ExecuteDynamicUpdate(instance)
    End Sub
#End Region

    
End Class




