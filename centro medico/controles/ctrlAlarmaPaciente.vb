Public Class ctrlAlarmaPaciente

    Private _idpaciente As Nullable(Of Integer)


    Public Property ID_Paciente() As Nullable(Of Integer)
        Get
            Return _idpaciente
        End Get
        Set(value As Nullable(Of Integer))
            _idpaciente = value
            If Not _idpaciente.HasValue Then
                ClearAlarmas()
            Else
                RefrescaAlarmas()
            End If
        End Set
    End Property

    Public Sub RefrescaAlarmas()

        If Not _idpaciente.HasValue() Then Return

        Dim context As New CMLinqDataContext()
        Dim alarmas As List(Of LINEASALARMA) = (From a In context.LINEASALARMAs Where a.REFPACIENTE = _idpaciente
                                          Select a).ToList()
        If alarmas.Count() = 0 Then
            ClearAlarmas()
        Else

            Dim maxNivelAlarma = 0 'Ninguno

            For Each a As LINEASALARMA In alarmas
                Select Case a.ALARMA.NIVEL
                    Case "A"
                        maxNivelAlarma = 3
                    Case "M"
                        If maxNivelAlarma <> 3 Then
                            maxNivelAlarma = 2
                        End If
                    Case "B"
                        If maxNivelAlarma <> 2 And maxNivelAlarma <> 3 Then
                            maxNivelAlarma = 1
                        End If

                End Select
            Next

            Select Case maxNivelAlarma
                Case 3  ' Alta
                    Me.lblText.BackColor = Color.FromArgb(255, 69, 0)
                    Me.lblText.Text = "¡¡ATENCIÓN!!"
                Case 2
                    Me.lblText.BackColor = Color.FromArgb(249, 247, 186)
                    Me.lblText.Text = "¡PRECAUCIÓN!"
                Case 1
                    Me.lblText.BackColor = Color.FromArgb(255, 174, 0)
                    Me.lblText.Text = "CUIDADO"
                Case 0
                    Me.lblText.BackColor = System.Drawing.Color.Transparent
                    Me.lblText.Text = ""
            End Select

        End If
    End Sub

    Public Sub ClearAlarmas()
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        lblText.Text = ""
    End Sub
End Class
