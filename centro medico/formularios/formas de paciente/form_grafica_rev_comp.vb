Imports ZedGraph
Imports Steema.TeeChart
Imports Microsoft.ApplicationBlocks.Data

Public Class form_grafica_rev_comp

    'Posicion inicial de los checkbox (12,6)

  
    Dim fId As Integer
    Dim nomPaciente As String = ""

    Sub New(ByVal aSeguimientoId As Integer, Optional ByVal oNomPaciente As String = "")

        InitializeComponent()

        dtp_fechainicial.Value = New DateTime(DateTime.Now.Year, 1, 1)
        dtp_fechafinal.Value = New DateTime(DateTime.Now.Year, 12, 31)

        fId = aSeguimientoId
        nomPaciente = oNomPaciente
    End Sub


    Private Sub form_grafica_rev_comp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'InicializaColores()

        Try
            Dim context As New CMLinqDataContext

            Dim lineas As List(Of LCOMPARATIVA) = (From l As LCOMPARATIVA In context.LCOMPARATIVAs Where l.COMPARATIVA.CODIGO = fId
                                                  Order By l.FECHA Ascending
                                                  Select l).ToList()
            If lineas.Count > 0 Then
                Dim fecha1 As Date? = lineas.First().FECHA
                Dim fecha2 As Date? = lineas.Last().FECHA
                dtp_fechainicial.Value = fecha1
                dtp_fechafinal.Value = fecha2
            End If

            ConfiguraGrafica()

            FillDatos()

        Catch ex As Exception
        End Try



    End Sub

    Private Sub ConfiguraGrafica()
        Me.TChart1.Header.Lines(0) = "Paciente: " & nomPaciente '& " Revisión: " & fCMDataSet.MODELOSCOMPARATIVA.Rows(0).Item("Modelo")
        Me.TChart1.Legend.LegendStyle = LegendStyles.Series
    End Sub

    Private Sub FillDatos()
        TChart1.Series.Clear()
        Dim context As New CMLinqDataContext
     
        Dim comparativa As COMPARATIVA = context.COMPARATIVAs.SingleOrDefault(Function(o) o.CODIGO = fId)

        If Not comparativa Is Nothing Then
            For Each linea As LCOMPARATIVA In comparativa.LCOMPARATIVAs
                For Each datos As DATOSCOMPARATIVA In linea.DATOSCOMPARATIVAs

                    Dim valor As Object = Globales.ValorModelo(datos)

                    If Not datos.MODELOSDATO.OcultarEnReporte.Value And IsNumeric(valor) Then
                        If Me.TChart1.Series.WithTitle(datos.MODELOSDATO.NOMBREDATO) Is Nothing Then
                            Me.TChart1.Series.Add(New Styles.Line)
                            Me.TChart1.Series(Me.TChart1.Series.Count - 1).Title = datos.MODELOSDATO.NOMBREDATO
                        End If
                        If Not valor Is Nothing Then
                            Me.TChart1.Series.WithTitle(datos.MODELOSDATO.NOMBREDATO).Add(CType(valor, Double), linea.FECHA.Value.Date)
                        End If
                    End If

                    'If datos.MODELOSDATO.TIPODATO = "N" Then
                    '    If Me.TChart1.Series.WithTitle(datos.MODELOSDATO.NOMBREDATO) Is Nothing Then
                    '        Me.TChart1.Series.Add(New Styles.Line)
                    '        Me.TChart1.Series(Me.TChart1.Series.Count - 1).Title = datos.MODELOSDATO.NOMBREDATO
                    '    End If
                    '    If datos.DFLOAT.HasValue Then
                    '        Me.TChart1.Series.WithTitle(datos.MODELOSDATO.NOMBREDATO).Add(datos.DFLOAT, linea.FECHA.Value.Date)
                    '    End If
                    'End If
                Next
            Next
        End If

    End Sub
  



    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        FillDatos()
        Me.Refresh()
    End Sub

    Private Sub bt_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cerrar.Click
        Close()
    End Sub

   
    'Private Sub InicializaColores()
    '    fListaColores.Add(Color.Blue)
    '    fListaColores.Add(Color.Red)
    '    fListaColores.Add(Color.Green)
    '    fListaColores.Add(Color.Yellow)
    '    fListaColores.Add(Color.Black)
    '    fListaColores.Add(Color.Brown)
    '    fListaColores.Add(Color.Violet)
    '    fListaColores.Add(Color.Silver)
    '    fListaColores.Add(Color.Pink)
    '    fListaColores.Add(Color.Orange)
    '    fListaColores.Add(Color.Maroon)
    '    fListaColores.Add(Color.Gray)
    '    fListaColores.Add(Color.Chocolate)
    '    fListaColores.Add(Color.Beige)
    '    fListaColores.Add(Color.LightBlue)
    '    fListaColores.Add(Color.LightGray)
    '    fListaColores.Add(Color.LightGreen)
    '    fListaColores.Add(Color.LightPink)
    '    fListaColores.Add(Color.LightYellow)
    '    fListaColores.Add(Color.DarkBlue)
    '    fListaColores.Add(Color.DarkRed)
    '    fListaColores.Add(Color.DarkViolet)
    '    fListaColores.Add(Color.DarkGreen)
    '    fListaColores.Add(Color.DarkOrange)
    '    fListaColores.Add(Color.DarkViolet)
    '    fListaColores.Add(Color.MediumAquamarine)
    '    fListaColores.Add(Color.MediumBlue)
    '    fListaColores.Add(Color.MediumOrchid)
    '    fListaColores.Add(Color.MediumPurple)
    '    fListaColores.Add(Color.MediumSeaGreen)
    '    fListaColores.Add(Color.MediumSlateBlue)
    '    fListaColores.Add(Color.MediumVioletRed)
    '    fListaColores.Add(Color.OrangeRed)
    '    fListaColores.Add(Color.Gold)
    '    fListaColores.Add(Color.DeepPink)
    '    fListaColores.Add(Color.GreenYellow)
    '    fListaColores.Add(Color.IndianRed)
    '    fListaColores.Add(Color.Purple)
    '    fListaColores.Add(Color.Aquamarine)
    '    fListaColores.Add(Color.DeepSkyBlue)
    '    fListaColores.Add(Color.Lavender)


    'End Sub


    Private Sub bt_ConfiguraGráfica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ConfiguraGráfica.Click
        Me.TChart1.ShowEditor()
    End Sub
End Class