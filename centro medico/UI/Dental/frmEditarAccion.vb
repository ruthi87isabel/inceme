Imports System.Xml.Linq

Public Class frmEditarAccion

    Public IDTratamiento As String = String.Empty

    Public CantPiezas As Integer = 1
    Private esNuevo As Boolean = False


    Public Sub New(ByVal cantPiezas As Integer, ByVal esNuevo As Boolean)

        Me.CantPiezas = cantPiezas
        Me.esNuevo = esNuevo
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.D_PresupuestoLineasBindingSource.EndEdit()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmEditarAccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim context As New CMLinqDataContext()
            Dim tratamiento As CONCEPTOSFRA = (From t In context.CONCEPTOSFRAs Where t.CODIGO = IDTratamiento Select t).SingleOrDefault
            TratamientoTextBox.Text = tratamiento.DESCRIPCION

            'Extraer datos del XML
            Dim doc As XDocument = XDocument.Parse(tratamiento.XMLCont)
            Dim tratNode As XElement = doc.Element("Tratamiento")

            Dim ctMarcar As Boolean = tratNode.Attribute("Marcar")
            Dim ctCuadrantes As Boolean = tratNode.Attribute("Cuadrantes")
            Dim ctMultiple As Boolean = tratNode.Attribute("Multiple")

            Dim ImportePorPieza As Boolean

            If tratNode.Attribute("ImportePorPieza") Is Nothing Then
                'Agregarlo y salvar el Tratamiento
                Dim tratamiento2 As CONCEPTOSFRA = (From t In context.CONCEPTOSFRAs Where t.CODIGO = tratamiento.CODIGO Select t).SingleOrDefault
                'tratamiento.XMLCont = 
                tratNode.Add(New XAttribute("ImportePorPieza", "False"))
                tratamiento2.XMLCont = doc.ToString()
                tratamiento.XMLCont = doc.ToString()
                context.SubmitChanges()
                ImportePorPieza = False
            Else
                ImportePorPieza = tratNode.Attribute("ImportePorPieza")
            End If

            If ImportePorPieza Then
                lblNota.Visible = True
                lblNota.Text = "Se facturan " & CantPiezas & " piezas"

                If ImporteTextBox.Visible Then
                    lblNota.Text += " x " & tratamiento.IMPORTE.ToString("C2") & " = " & (CantPiezas * tratamiento.IMPORTE).ToString("C2")
                End If

                If esNuevo Then
                    ImporteTextBox.Value = tratamiento.IMPORTE * CantPiezas
                End If
            Else
                lblNota.Visible = False
            End If
           
        Catch ex As Exception

        End Try

    End Sub

    
    Private Sub txtDescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescuento.TextChanged
        'If IsHandleCreated Then
        txtDescuentoImporte.Value = txtDescuento.Value * ImporteTextBox.Value
        'End If

        Calcula()
    End Sub

    Private Sub ImporteTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImporteTextBox.TextChanged
        
        Calcula()
    End Sub

  
    Private Sub txtDescuentoImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescuentoImporte.TextChanged
        'If IsHandleCreated Then
        If txtDescuentoImporte.Value > 0 And ImporteTextBox.Value > 0 Then
            txtDescuento.Value = (txtDescuentoImporte.Value / ImporteTextBox.Value)
        End If
        'End If

        Calcula()
    End Sub


    Private Sub Calcula()
        'If IsHandleCreated Then
        If ImporteTextBox.Value > 0 Then
            txtTotal.Value = ImporteTextBox.Value - txtDescuentoImporte.Value
        Else
            txtTotal.Value = 0
        End If
        'End If


    End Sub

    
End Class