Imports Microsoft.ApplicationBlocks.Data.SqlHelper

Public Class form_Add_AntecedentesDiagnostico
    Private CPaciente As Integer
    Private EDITAR As Boolean
    Public idDiagnostico As Integer = -1
    Public Diagnostico As String = ""
    Public Cie10 As String = ""
    Public Observaciones As String = ""

    Public Sub New(ByVal CodigoPaciente As Integer, Optional ByVal oEDITAR As Boolean = False)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CPaciente = CodigoPaciente
        EDITAR = oEDITAR


    End Sub

    Private Sub CreaAntecedenteDiagnostico()
        BuscarDiagnostico()
    End Sub
    Private Sub EditaAntecedenteDiagnostico()
        'Dim data As DataTable
        'data = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(My.Settings.CMConnectionString, CommandType.Text, "Select Diagnostico,Observaciones,Cie10 From AntecedentesDiagnosticos Where idantecedentedx = " & Me.AntDx & " and CPaciente = " & CPaciente).Tables(0)
        'If data.Rows.Count > 0 Then
        Me.txtCIE10.Text = Cie10
        Me.txtDiagnostico.Text = Diagnostico
        Me.txtObservaciones.Text = Observaciones
        'End If
    End Sub
    Private Sub BuscarDiagnostico()

        Dim frm As New frmDiagnosticos()
        frm.Modo = Globales.ModoParaFormas.Seleccion
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Cie10 = frm.Diagnostico.CIE10
            Diagnostico = frm.Diagnostico.DIAGNOSTICO
            Observaciones = frm.Diagnostico.OBSERVACIONES
            idDiagnostico = frm.Diagnostico.IDDIAGNOSTICO
            Me.txtDiagnostico.Text = Diagnostico
            Me.txtCIE10.Text = Cie10
            Me.txtObservaciones.Text = Observaciones
        End If

    End Sub

    Private Sub Guardar()
        Diagnostico = Me.txtDiagnostico.Text.Trim
        Cie10 = Me.txtCIE10.Text.Trim
        Observaciones = Me.txtObservaciones.Text.Trim
    End Sub
  

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Me.Guardar()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BuscarDiagnostico()
        Me.EditaAntecedenteDiagnostico()
    End Sub

    Private Sub form_Add_AntecedentesDiagnostico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not EDITAR = False Then Me.EditaAntecedenteDiagnostico() Else Me.CreaAntecedenteDiagnostico()
    End Sub
End Class