Imports Janus.Windows.GridEX
Imports centro_medico.UI.Reportes
Imports Microsoft.Reporting.WinForms

Public Class frmDiagnosticos
    Inherits FormConfigurable

    Public Modo As Globales.ModoParaFormas = Globales.ModoParaFormas.Edicion
    Public Diagnostico As DIAGNOSTICO
    Private Context As New CMLinqDataContext



    Private Sub frmDiagnosticos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tstNuevo.Visible = Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) > RoleManager.TipoPermisos.Lectura
        tst_Editar.Visible = Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) > RoleManager.TipoPermisos.Lectura
        tst_Eliminar.Visible = Globales.Usuario.Permisos(RoleManager.Items.Diagnosticos) > RoleManager.TipoPermisos.Lectura
        PopulateGrid()

    End Sub

    Protected Overrides Sub PopulateGrid()

        Context = New CMLinqDataContext()
        Dim diagnosticos

        If txtDiagnostico.Text <> String.Empty And txtCIE10.Text <> String.Empty Then
            diagnosticos = From g In Context.DIAGNOSTICOs
                           Where g.DIAGNOSTICO.Contains(txtDiagnostico.Text) And g.CIE10.Contains(txtCIE10.Text)
                           Order By g.DIAGNOSTICO
                           Select g
        ElseIf txtDiagnostico.Text <> String.Empty Then
            diagnosticos = From g In Context.DIAGNOSTICOs
                      Where g.DIAGNOSTICO.Contains(txtDiagnostico.Text)
                      Order By g.DIAGNOSTICO

        ElseIf txtCIE10.Text <> String.Empty Then
            diagnosticos = From g In Context.DIAGNOSTICOs
                      Where g.CIE10.Contains(txtCIE10.Text)
                      Order By g.DIAGNOSTICO

        Else
            diagnosticos = From g In Context.DIAGNOSTICOs
                           Where g.FAVORITO = "S"
                           Order By g.DIAGNOSTICO
                           Select g
        End If




        DIAGNOSTICOBindingSource.DataSource = diagnosticos

    End Sub

    Private Sub tstNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tstNuevo.Click
        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Diagnosticos, "Insertar ", "Nuevo", "En listado control")

        'Dim _nuevo_diagnostico As form_diagnostico = New form_diagnostico("Ficha de diagnostico-Añadir", Enums.Accion.Insertar)
        '_nuevo_diagnostico.ShowInTaskbar = False
        '_nuevo_diagnostico.ShowDialog()

        Dim frm As New frmDiagnosticos_ADD
        frm.Diagnostico = New DIAGNOSTICO()
        frm.Diagnostico.NIVEL = "---"
        frm.Diagnostico.SUBNIVEL = "---"
        frm.Diagnostico.CIE = "---"


        frm.DIAGNOSTICOBindingSource.DataSource = frm.Diagnostico

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Not Context.DIAGNOSTICOs.Contains(frm.Diagnostico) Then
                Context.DIAGNOSTICOs.InsertOnSubmit(frm.Diagnostico)
            End If

            Context.SubmitChanges()
            'DIAGNOSTICOBindingSource.Add(frm.Diagnostico)
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Diagnosticos, "Diagnostico ADD", frm.Diagnostico.IDDIAGNOSTICO, frm.Diagnostico.DIAGNOSTICO)

            PopulateGrid()
        End If

    End Sub

    Private Sub tst_Editar_Click(sender As System.Object, e As System.EventArgs) Handles tst_Editar.Click

        If GridEX1.SelectedItems.Count > 0 Then
            If tst_Editar.Visible Then
                Dim Id As Integer = GridEX1.SelectedItems(0).GetRow().DataRow.IDDIAGNOSTICO
                'Dim diag As DIAGNOSTICO = (From d In Context.DIAGNOSTICOs
                '                          Where d.IDDIAGNOSTICO = Id
                '                          Select d).SingleOrDefault
                Dim frm As New frmDiagnosticos_ADD
                frm.Diagnostico = GridEX1.SelectedItems(0).GetRow().DataRow
                frm.DIAGNOSTICOBindingSource.DataSource = frm.Diagnostico
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Context.SubmitChanges()
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Diagnosticos, "Diagnostico: ", Id, " " & frm.Diagnostico.DIAGNOSTICO)
                End If

                'PopulateGrid()
            Else
                MessageBox.Show("Usted no tiene permisos para editar diagnosticos")
                Return
            End If
        End If

    End Sub

    Private Sub GridEX1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEX1.RowDoubleClick

        If Modo = Globales.ModoParaFormas.Edicion Then
            tst_Editar_Click(Nothing, Nothing)
        Else
            If GridEX1.SelectedItems.Count > 0 Then
                Dim Id As Integer = GridEX1.SelectedItems(0).GetRow().DataRow.IDDIAGNOSTICO
                Diagnostico = (From p In Context.DIAGNOSTICOs Where p.IDDIAGNOSTICO = Id Select p).SingleOrDefault()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub GridEX1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEX1.SelectionChanged
        tst_Editar.Enabled = GridEX1.SelectedItems.Count > 0
        tst_Eliminar.Enabled = GridEX1.SelectedItems.Count > 0
    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Dim context As New CMLinqDataContext()
        Dim diag As DIAGNOSTICO = Nothing
        If GridEX1.GetCheckedRows().Count > 0 Then
            If MessageBox.Show("Esta seguro que desea eliminar este/estos elemento(s)?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                For Each row As GridEXRow In GridEX1.GetCheckedRows()
                    Try
                        Dim Id As Integer = row.DataRow.IDDIAGNOSTICO
                        diag = (From p In context.DIAGNOSTICOs Where p.IDDIAGNOSTICO = Id _
                                                   Select p).SingleOrDefault()
                        context.DIAGNOSTICOs.DeleteOnSubmit(diag)
                        context.SubmitChanges()
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Diagnosticos, "DIAGNOSTICOS", Id, "Nombre:  " & diag.DIAGNOSTICO)

                    Catch ex As Exception
                        MessageBox.Show("No pudo eliminarser el diagnostico (" & diag.DIAGNOSTICO & ")")
                    End Try
                Next

            End If
            PopulateGrid()
        Else
            MessageBox.Show("No hay diagnosticos seleccionados")
        End If


    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        PopulateGrid()
    End Sub


    Private Sub tlbImprimir_Click(sender As Object, e As EventArgs) Handles tlbImprimir.Click
        Dim ds As New ReportDataSource
        ds.Name = "CMDataSet_DIAGNOSTICOS"
        ds.Value = DIAGNOSTICOBindingSource.DataSource

        ReportesManager.Imprime("DiagnosticosListado.rdlc", {ds})
    End Sub

    Private Sub txtDiagnostico_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDiagnostico.KeyUp, txtCIE10.KeyUp
        If e.KeyCode = Keys.Enter Then
            PopulateGrid()
        End If
    End Sub
End Class