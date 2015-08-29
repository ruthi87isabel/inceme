Imports Janus.Windows.GridEX

Public Class frmFamiliaSelector
    Dim context As CMLinqDataContext
    Public Categorias As ctrlFamilia.MostrarCategorias = ctrlFamilia.MostrarCategorias.Todos

    Public Familia As CONCEPTOSFAMILIA = Nothing
    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Seleccion

    Private Sub frmFamiliaSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaDatos()
    End Sub

    Private Sub CargaDatos()
        context = New CMLinqDataContext()
        Select Case Categorias
            Case ctrlFamilia.MostrarCategorias.Todos : CONCEPTOSFAMILIABindingSource.DataSource = From f In context.CONCEPTOSFAMILIAs Select f
                Me.Text = "Familias por categorias (TODAS)"




            Case ctrlFamilia.MostrarCategorias.Dentales : CONCEPTOSFAMILIABindingSource.DataSource = From f In context.CONCEPTOSFAMILIAs Where f.Categoria = 1 Select f
                Me.Text = "Familias por categorias (DENTALES)"
            Case ctrlFamilia.MostrarCategorias.Regulares : CONCEPTOSFAMILIABindingSource.DataSource = From f In context.CONCEPTOSFAMILIAs Where f.Categoria Is Nothing Or f.Categoria <> 1 Select f
                Me.Text = "Familias por categorias (REGULARES)"
        End Select
    End Sub

    Private Sub GridEX1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick
        If GridEX1.SelectedItems.Count > 0 Then
            If GridEX1.SelectedItems(0).RowType = RowType.Record Then
                Familia = GridEX1.SelectedItems(0).GetRow().DataRow
                If Modo = Globales.ModoParaFormas.Seleccion Then
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    tst_Editar_Click(Nothing, Nothing)
                End If
            End If
        End If

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click

        Dim frm As New frmFamilia_ADD()
        frm.Familia = New CONCEPTOSFAMILIA()
        frm.Familia.IDFamilia = DameIDFamilia()
        frm.Categorias = Me.Categorias

        If frm.ShowDialog() = DialogResult.OK Then
            context.CONCEPTOSFAMILIAs.InsertOnSubmit(frm.Familia)
            context.SubmitChanges()
        End If

        CargaDatos()

    End Sub

    Function DameIDFamilia()
        Try
            Dim id As Integer = (From f In context.CONCEPTOSFAMILIAs
                            Select f.IDFamilia).Max()
            Return id + 1

            End
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click

        If GridEX1.SelectedItems(0).RowType = RowType.Record Then
            Familia = GridEX1.SelectedItems(0).GetRow().DataRow
            Dim frm As New frmFamilia_ADD()
            frm.Familia = Familia
            If Familia.Categoria = 1 Then
                frm.Categorias = ctrlFamilia.MostrarCategorias.Dentales
            End If
            frm.ShowDialog()
            context.SubmitChanges()
            CargaDatos()
        End If

    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        If GridEX1.SelectedItems(0).RowType = RowType.Record Then
            Familia = GridEX1.SelectedItems(0).GetRow().DataRow

            context.CONCEPTOSFAMILIAs.DeleteOnSubmit(Familia)
            context.SubmitChanges()
            CargaDatos()
        End If
    End Sub

    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = GridEX1.SelectedItems.Count > 0
        tst_Eliminar.Enabled = GridEX1.SelectedItems.Count > 0

    End Sub

    Private Sub GridEX1_LoadingRow(sender As System.Object, e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.LoadingRow
        If e.Row.RowType = RowType.GroupHeader Then
            'MessageBox.Show("Aqui")
            If Not e.Row.GroupValue Is System.DBNull.Value Then
                If e.Row.GroupValue.ToString() = "1" Then
                    e.Row.GroupCaption = "Dental"
                End If

            End If
        End If
    End Sub
End Class