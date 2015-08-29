Imports centro_medico.ClasesOdontogramaDataContext

Public Class frmColores
    'CARGAR LOS COLORES
    Private Sub frmColores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim colores As md_d_Color = classOdontograma.GetColores
        pnlRealizado.BackColor = Color.FromArgb(colores.clRealizado)
        pnlPendiente.BackColor = Color.FromArgb(colores.clPendiente)
        pnlPrimeraVista.BackColor = Color.FromArgb(colores.clPrimeravista)
        pnlPresupuesto.BackColor = Color.FromArgb(colores.clPresupuesto)
        pnlUrgente.BackColor = Color.FromArgb(colores.clUrgente)
    End Sub
    'CAMBIAR UN COLOR PULSANDO SOBRE EL PANEL 
    Private Sub pnlRealizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlRealizado.Click, pnlUrgente.Click, pnlPrimeraVista.Click, pnlPresupuesto.Click, pnlPendiente.Click
        If colorDlg.ShowDialog() = DialogResult.OK Then
            TryCast(sender, Panel).BackColor = colorDlg.Color
        End If
    End Sub
    'SALVAR LOS CAMBIOS REALIZADOS
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim colores As md_d_Color = classOdontograma.GetColores
        Try
            colores.clRealizado = pnlRealizado.BackColor.ToArgb()
            colores.clRealizado = pnlRealizado.BackColor.ToArgb()
            colores.clPendiente = pnlPendiente.BackColor.ToArgb()
            colores.clPrimeravista = pnlPrimeraVista.BackColor.ToArgb()
            colores.clPresupuesto = pnlPresupuesto.BackColor.ToArgb()
            colores.clUrgente = pnlUrgente.BackColor.ToArgb()
            classOdontograma.SubmitChanges()
        Catch ex As Exception
            MsgBox("Error al salvar colores: " + ex.ToString())
        End Try
    End Sub
End Class