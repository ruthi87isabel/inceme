Imports iTextSharpSign
Public Class Firmar
    Dim docOriginal As String
    Dim docDestino As String
    Dim clave As String

    Dim cert As iTextSharpSign.Cert
    Dim pdf As PDFSigner
    Dim meta As MetaData
    Dim certificadoValido As Boolean = True
    Public Sub New(ByRef _docOriginal As String, ByRef _docDestino As String, ByRef _clave As String)
        docOriginal = _docOriginal
        docDestino = _docDestino
        clave = _clave
        If System.IO.File.Exists(Globales.Usuario.CERTIFICADOPATH) = True Then
            cert = New Cert(Globales.Usuario.CERTIFICADOPATH, clave)
        Else
            certificadoValido = False
        End If

        meta = New MetaData

        meta.Author = Globales.Usuario.NOMBRECOMPLETO


    End Sub
    Public Sub Firma()
        'compruebo qeu existe el cetificado, si no aviso del error.
        If certificadoValido = True Then
            pdf = New PDFSigner(docOriginal, docDestino, cert, meta)
            pdf.Sign("Firma del Documento", meta.Author, Globales.Configuracion.nombrecomercial, True)

            'auditoria
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Configuracion_Usuarios, "Firma de Doc", "", Globales.Usuario.NOMBRECOMPLETO & " ha firmado digitalmente un documento guardado en " & docDestino)

            If System.IO.File.Exists(docDestino) Then
                Process.Start(docDestino)
            Else
                MsgBox("No se ha encontrado el pdf firmado", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("No se puede firmar porque no existe una firma adecuada", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
