Public Class frmPacientesListado2

    Public Seccion As String
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Seleccion
    Public Plantilla As PLANTILLA = Nothing
    Dim pacientemgr As New PacienteManager

    Private Sub frmTemplates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaDatos()
    End Sub

    Private Sub CargaDatos()
        Dim filtro As New pacienteFiltro
        If txtNombre.Text.Trim.Length > 0 Then
            filtro.nombre = txtNombre.Text.Trim
        End If
        PLANTILLABindingSource.DataSource = Nothing
        PLANTILLABindingSource.DataSource = pacientemgr.listadoPacientes(filtro, 100)
    End Sub

    Private Sub GridEX1_RowDoubleClick(sender As System.Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        Try
            If Modo = Globales.ModoParaFormas.Edicion Then
                tst_Editar_Click(Nothing, Nothing)
            Else
                Plantilla = GridEX1.SelectedItems(0).GetRow().DataRow
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click

    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        Dim tpl As New PLANTILLA()
        tpl.SECCION = Seccion

        Dim frm As New frmTemplates_ADD()
        frm.PLANTILLABindingSource.DataSource = tpl

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Globales.Context.PLANTILLAs.InsertOnSubmit(tpl)
            Globales.Context.SubmitChanges()
            CargaDatos()
        End If
    End Sub

    Private Sub btFiltrar_Click(sender As Object, e As EventArgs) Handles btFiltrar.Click
        Me.CargaDatos()
    End Sub
End Class