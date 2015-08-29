Imports System.Math

Public Class frmNTratamiento
    Public oform As frmOdontograma
    Public odont As Odontograma
    Public dcbx As ComboBox
    Public tlvw As ListView
    Public dtemporal As Boolean

    Private Sub frmNTratamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFecha.Value = oform.dtpFecha.Value
        For i As Integer = 0 To dcbx.Items.Count - 1
            cbxDoct.Items.Add(dcbx.Items(i))
        Next
        cbxDoct.SelectedIndex = dcbx.SelectedIndex
        For i As Integer = 0 To tlvw.Items.Count - 1
            cbxTrat.Items.Add(tlvw.Items(i).Text)
        Next
        cbxTrat.SelectedIndex = 0
    End Sub
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Dim pieza1 As Integer = 0
        Dim pieza2 As Integer = 0
        If tbxPieza1.Visible = True Then
            If tbxPieza1.Text = "" Then
                MsgBox("Debe especificar un valor en el campo pieza")
                tbxPieza1.Focus()
                Exit Sub
            Else
                pieza1 = Convert.ToInt32(tbxPieza1.Text)
                If ((dtemporal = True) And (((pieza1 \ 10) < 5) Or ((pieza1 \ 10) > 8) Or ((pieza1 Mod 10) = 0) Or ((pieza1 Mod 10) > 5))) Or ((dtemporal = False) And (((pieza1 \ 10) = 0) Or ((pieza1 \ 10) > 4) Or ((pieza1 Mod 10) = 0) Or ((pieza1 Mod 10) > 8))) Then
                    MsgBox("El valor del campo Pieza es incorrecto")
                    tbxPieza1.Focus()
                    Exit Sub
                End If
            End If
        End If

        If tbxPieza2.Visible = True Then
            If tbxPieza2.Text = "" Then
                MsgBox("Debe especificar un valor en el campo Pieza final")
                Exit Sub
            Else
                pieza2 = Convert.ToInt32(tbxPieza2.Text)
                If Not (((pieza2 \ 10) = (pieza1 \ 10)) OrElse (((Min(pieza2 \ 10, pieza1 \ 10) + 1) = Max(pieza2 \ 10, pieza1 \ 10)) And ((Max(pieza2 \ 10, pieza1 \ 10) Mod 2) = 0))) Then
                    MsgBox("El valor del campo Pieza final es incorrecto")
                    tbxPieza2.Focus()
                    Exit Sub
                End If
            End If
        End If
        oform.SelDoctor = TryCast(dcbx.SelectedItem, md_MEDICO).CMEDICO
        If oform.AddAction(odont, dtpFecha.Value, oform.currentTratID, oform.currentTratDesc, oform.currentTratImport, Convert.ToInt32(odont.Tag), pieza1, pieza2) = True Then
            MsgBox("Tratamiento salvado")
            tbxPieza1.Clear()
            tbxPieza2.Clear()
            cbxTrat.Focus()
        End If
    End Sub
    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Close()
    End Sub

    Private Sub cbxTrat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTrat.SelectedIndexChanged
        For i As Integer = 0 To 85
            oform.ctpiezas(i) = 0
        Next
        oform.ctMarcar = True
        oform.currentTratID = TryCast(tlvw.Items(cbxTrat.SelectedIndex).Tag, md_ConceptoFra).CODIGO
        oform.currentTratDesc = cbxTrat.Text
        oform.currentTratImport = TryCast(tlvw.Items(cbxTrat.SelectedIndex).Tag, md_ConceptoFra).IMPORTE

        oform.getXML(TryCast(tlvw.Items(cbxTrat.SelectedIndex).Tag, md_ConceptoFra))
        If oform.ctMarcar Then
            If oform.ctMultiple = True Then
                lblPieza1.Text = "Pieza inicial"
                lblPieza1.Visible = True
                lblPieza2.Visible = True
                tbxPieza1.Visible = True
                tbxPieza2.Visible = True
            Else
                lblPieza1.Text = "Pieza"
                lblPieza1.Visible = True
                lblPieza2.Visible = False
                tbxPieza1.Visible = True
                tbxPieza2.Visible = False
            End If
        Else
            lblPieza1.Visible = False
            lblPieza2.Visible = False
            tbxPieza1.Visible = False
            tbxPieza2.Visible = False
        End If
    End Sub
    Private Sub tbxPieza1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxPieza1.KeyPress, tbxPieza2.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.KeyChar = Chr(0)
        End If
    End Sub
End Class