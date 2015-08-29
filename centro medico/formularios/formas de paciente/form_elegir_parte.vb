Public Class form_elegir_parte

    Dim fPacienteId As Integer
    Dim fEmpresaId As Integer


    Dim fCMDataSet As CMDataSet

    Sub New(ByVal aPacienteId As Integer, ByVal aEmpresaId As Integer, ByRef aCMDataSet As CMDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        fPacienteId = aPacienteId
        fEmpresaId = aEmpresaId


        fCMDataSet = aCMDataSet

    End Sub

    Private Sub bt_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Aceptar.Click
        'If rb_Baja.Checked = True Then
        '    Dim _nueva_alta As form_alta_baja_ex = New form_alta_baja_ex("Ficha de alta/baja-Añadir", Enums.Accion.Insertar, -1, False, fPacienteId, fEmpresaId, fCMDataSet)
        '    _nueva_alta.ShowInTaskbar = False
        '    _nueva_alta.ShowDialog()
        'Else
        '    Dim _nueva_asistencia As form_parte_asistencia = New form_parte_asistencia("Ficha de asistencia-Añadir", Enums.Accion.Insertar, -1, fPacienteId, fEmpresaId, fCMDataSet)
        '    _nueva_asistencia.ShowInTaskbar = False
        '    _nueva_asistencia.ShowDialog()
        'End If
        Close()
    End Sub

    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        Me.Close()
    End Sub
End Class