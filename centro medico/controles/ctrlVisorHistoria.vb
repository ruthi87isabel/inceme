Public Class ctrlVisorHistoria
    Public CodigoHistorial As Integer
    

    Public Sub CargarHistorial()

        Dim TBDiagnostico As CMDataSet.DIAGNOSTICOSDataTable
        Dim diagnostico As String = ""
        Dim NombreMedico As String = ""
        Dim NombrePaciente As String = ""
        Dim rtf As New RichTextBox
        Me.HISTORIALESTableAdapter.FillByCHistorial(CMDataSet.HISTORIALES, CodigoHistorial)


        If CMDataSet.HISTORIALES.Rows.Count > 0 Then
            'Obtengo el nombre del médico
            Me.MEDICOSTableAdapter.FillMedicoByID(CMDataSet.MEDICOS, CMDataSet.HISTORIALES.Rows(0).Item("REFMEDICO"))
            If Me.CMDataSet.MEDICOS.Rows.Count > 0 Then
                If Not Me.CMDataSet.MEDICOS.Rows(0).Item("Apellido1").GetType Is GetType(DBNull) Then
                    NombreMedico += Me.CMDataSet.MEDICOS.Rows(0).Item("Apellido1")
                End If
                If Not Me.CMDataSet.MEDICOS.Rows(0).Item("Apellido2").GetType Is GetType(DBNull) Then
                    NombreMedico += " " & Me.CMDataSet.MEDICOS.Rows(0).Item("Apellido2")
                End If
                If Not Me.CMDataSet.MEDICOS.Rows(0).Item("Nombre").GetType Is GetType(DBNull) Then
                    NombreMedico += " " & Me.CMDataSet.MEDICOS.Rows(0).Item("Nombre")
                End If
            End If
            'Obtengo el nombre del paciente
            Me.PACIENTESTableAdapter.FillPacienteById(CMDataSet.PACIENTES, CMDataSet.HISTORIALES.Rows(0).Item("REFPACIENTE"))
            If Me.CMDataSet.PACIENTES.Rows.Count > 0 Then
                If Not Me.CMDataSet.PACIENTES.Rows(0).Item("Apellido1").GetType Is GetType(DBNull) Then
                    NombrePaciente += Me.CMDataSet.PACIENTES.Rows(0).Item("Apellido1")
                End If
                If Not Me.CMDataSet.PACIENTES.Rows(0).Item("Apellido2").GetType Is GetType(DBNull) Then
                    NombrePaciente += " " & Me.CMDataSet.PACIENTES.Rows(0).Item("Apellido2")
                End If
                If Not Me.CMDataSet.PACIENTES.Rows(0).Item("Nombre").GetType Is GetType(DBNull) Then
                    NombrePaciente += " " & Me.CMDataSet.PACIENTES.Rows(0).Item("Nombre")
                End If
            End If

            rtf.AppendText("Historial con Fecha " & CMDataSet.HISTORIALES.Rows(0).Item("FECHA") & "" & vbCrLf)
            rtf.AppendText("Atendido por Dr/Dra: " & LTrim(NombreMedico) & vbCrLf)
            rtf.AppendText("Nombre del Paciente: " & LTrim(NombrePaciente) & vbCrLf)
            rtf.AppendText("--------------------------------" & vbCrLf)
            rtf.AppendText("MOTIVO:" & vbCrLf)
            Me.RichTextBox1.Rtf = rtf.Rtf
            If Not CMDataSet.HISTORIALES.Rows(0).Item("MOTIVO").GetType Is GetType(DBNull) Then
                rtf.Text = Globales.TextFromRtf(CMDataSet.HISTORIALES.Rows(0).Item("MOTIVO").ToString.Trim) & vbCrLf & vbCrLf
                Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            End If
            rtf.Clear()
            rtf.AppendText("ANTECEDENTES:")
            Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            If Not CMDataSet.HISTORIALES.Rows(0).Item("ANTECEDENTES").GetType Is GetType(DBNull) Then
                rtf.Text = Globales.TextFromRtf(CMDataSet.HISTORIALES.Rows(0).Item("ANTECEDENTES").ToString.Trim) & vbCrLf & vbCrLf
                Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            End If
            rtf.Clear()
            rtf.AppendText("HISTORIAL:")
            Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            If Not CMDataSet.HISTORIALES.Rows(0).Item("ANTECEDENTES").GetType Is GetType(DBNull) Then
                rtf.Text = Globales.TextFromRtf(CMDataSet.HISTORIALES.Rows(0).Item("ANTECEDENTES").ToString.Trim) & vbCrLf & vbCrLf
                Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            End If
            rtf.Clear()
            rtf.AppendText("EXPLORACION: ")
            Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            If Not CMDataSet.HISTORIALES.Rows(0).Item("EXPLORACION").GetType Is GetType(DBNull) Then
                rtf.Text = Globales.TextFromRtf(CMDataSet.HISTORIALES.Rows(0).Item("EXPLORACION").ToString.Trim) & vbCrLf & vbCrLf
                Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            End If
            rtf.Clear()
            rtf.AppendText("PRUEBAS COMPLEMENTARIAS: ")
            Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            If Not CMDataSet.HISTORIALES.Rows(0).Item("COMPLEMENTARIAS").GetType Is GetType(DBNull) Then
                rtf.Text = Globales.TextFromRtf(CMDataSet.HISTORIALES.Rows(0).Item("COMPLEMENTARIAS").ToString.Trim) & vbCrLf & vbCrLf
                Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            End If
            rtf.Clear()
            rtf.AppendText("JUICIO CLINICO: ")
            Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            If Not CMDataSet.HISTORIALES.Rows(0).Item("REFDIAGNOSTICO").GetType Is GetType(DBNull) Then
                TBDiagnostico = Me.DIAGNOSTICOSTableAdapter.GetDiagnosticoById(CMDataSet.HISTORIALES.Rows(0).Item("REFDIAGNOSTICO"))
                If TBDiagnostico.Rows.Count > 0 Then diagnostico = TBDiagnostico.Rows(0).Item("Diagnostico").ToString.Trim Else diagnostico = ""
            Else
                diagnostico = ""
            End If
            Me.HistorialesDiagnosticosTableAdapter.FillByCHistorial(CMDataSet.HistorialesDiagnosticos, CodigoHistorial)
            Dim i As Integer = 0
            For i = 0 To Me.CMDataSet.HistorialesDiagnosticos.Rows.Count - 1
                If Not CMDataSet.HistorialesDiagnosticos.Rows(i).Item("Diagnostico").GetType Is GetType(DBNull) Then
                    diagnostico += vbCrLf & CMDataSet.HistorialesDiagnosticos.Rows(i).Item("Diagnostico").ToString.Trim
                End If
            Next
            If Not CMDataSet.HISTORIALES.Rows(0).Item("JUICIO").GetType Is GetType(DBNull) Then
                rtf.Text = Globales.TextFromRtf(CMDataSet.HISTORIALES.Rows(0).Item("JUICIO").ToString.Trim) & vbCrLf & vbCrLf
            Else
                rtf.Text = ""
            End If

            Me.RichTextBox1.AppendText(diagnostico & ". " & rtf.Text & vbCrLf)
            rtf.Clear()
            rtf.AppendText("TRATAMIENTO: ")
            Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            If Not CMDataSet.HISTORIALES.Rows(0).Item("TRATAMIENTO").GetType Is GetType(DBNull) Then
                rtf.Text = Globales.TextFromRtf(CMDataSet.HISTORIALES.Rows(0).Item("TRATAMIENTO").ToString.Trim) & vbCrLf & vbCrLf
                Me.RichTextBox1.AppendText(rtf.Text & vbCrLf)
            End If
            
        End If
    End Sub
End Class
