Imports System.IO


Public Class frmRoles

    Private Sub ROLESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Guardar()
    End Sub

    Private Sub frmRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.PERMISOS' table. You can move, or remove it, as needed.
        Me.PERMISOSTableAdapter.Fill(Me.CMDataSet.PERMISOS)
        Me.ROLESTableAdapter.Fill(Me.CMDataSet.ROLES)
        ROLESDataGridView_CellMouseClick(Nothing, Nothing)

        'For Each row As DataGridViewRow In Me.ROLESDataGridView.Rows
        '    If Me.ROLESDataGridView.Rows(0).Cells(Fixed.Index).Value = True Then
        '        'Me.ROLESDataGridView.Rows(0).Frozen = True
        '        Me.ROLESDataGridView.Rows(0).ReadOnly = True
        '        Me.ROLESDataGridView.Rows(0).DefaultCellStyle.ForeColor = Color.Gray
        '    End If
        'Next

    End Sub

    Private Sub ROLESDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROLESDataGridView.SelectionChanged
        tst_Editar.Enabled = ROLESDataGridView.SelectedRows.Count > 0
        tst_Eliminar.Enabled = ROLESDataGridView.SelectedRows.Count > 0
        If ROLESDataGridView.SelectedRows.Count > 0 Then
            If Not Me.ROLESDataGridView.SelectedRows(0).Cells(Fixed.Index).Value Is DBNull.Value Then

                If Me.ROLESDataGridView.SelectedRows(0).Cells(Fixed.Index).Value = True Then
                    RolesItem_ResumenDataGridView.RowsDefaultCellStyle.ForeColor = Color.Gray
                    RolesItem_ResumenDataGridView.ReadOnly = True

                Else
                    RolesItem_ResumenDataGridView.ReadOnly = False
                    RolesItem_ResumenDataGridView.RowsDefaultCellStyle.ForeColor = Color.Black
                End If
            End If
        End If
    End Sub

#Region "Private Function Guardar() As Boolean"
    Private Function Guardar() As Boolean
        'Try
        'Salvar Roles
        Me.Validate()

        Dim Rolnuevo As CMDataSet.ROLESRow = Me.ROLESBindingSource.Current.Row
        If Rolnuevo.IsNull("Fixed") Then
            Rolnuevo.Fixed = False
        End If

        Me.ROLESBindingSource.EndEdit()
        Me.ROLESTableAdapter.Update(Me.CMDataSet.ROLES)

        'Salvar Permisos
        If ROLESDataGridView.SelectedRows.Count > 0 Then

            Dim ID_ROLE As Integer = ROLESDataGridView.SelectedRows(0).Cells(0).Value
            Dim adapter As CMDataSetTableAdapters.ROLESPERMISOSTableAdapter = New CMDataSetTableAdapters.ROLESPERMISOSTableAdapter()

            For Each row As DataGridViewRow In Me.RolesItem_ResumenDataGridView.Rows
                Dim ID_ROLESITEM As Integer = row.Cells(ID_ROLESITEMDataGridViewTextBoxColumn7.Index).Value
                Dim ID_PERMISO As Integer = row.Cells(ID_PERMISODataGridViewTextBoxColumn6.Index).Value
                Dim n As Integer = adapter.UpdateQuery(ID_ROLE, ID_PERMISO, ID_ROLESITEM, "")
                If n = 0 Then
                    adapter.InsertQuery(ID_ROLE, ID_PERMISO, ID_ROLESITEM, "")
                End If
            Next
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Guardar, RoleManager.Items.Configuracion_Roles_y_permisos, "Roles y Permisos", ID_ROLE.ToString(), "")

            Return True
            'Catch ex As Exception
            ' Globals.ShowError("Error salvando Roles", ex)
            'Return False
            '  End Try
        End If



    End Function
#End Region

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click

        Dim ID_ROLE As Integer = Globales.ObtenerMaximoValor("ROLES", "ID_ROLE") + 1

        Dim row As CMDataSet.ROLESRow = Me.ROLESBindingSource.AddNew().Row
        row.ID_ROLE = ID_ROLE
        row.Nombre = "NUEVOROL"
        row.Fixed = False

        Me.RolesItem_ResumenTableAdapter.FillNew(Me.CMDataSet.RolesItem_Resumen, ID_ROLE)

        Guardar()
    End Sub

    Private Sub ROLESDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ROLESDataGridView.CellMouseClick
        If ROLESDataGridView.SelectedRows.Count > 0 Then
            Dim ID_ROLE As Integer = ROLESDataGridView.SelectedRows(0).Cells(0).Value
            Me.RolesItem_ResumenTableAdapter.Fill(Me.CMDataSet.RolesItem_Resumen, ID_ROLE)
            RolesItem_ResumenDataGridView.ClearSelection()
            btn_Guardar.Enabled = True
            'ROLESBindingNavigatorSaveItem.Enabled = True
        Else
            btn_Guardar.Enabled = False
        End If
    End Sub

    Private Sub tst_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Editar.Click
        'ROLESDataGridView.SelectedRows(0).Cells(0).Selected = True
        ROLESDataGridView.BeginEdit(True)

    End Sub

    Private Sub tst_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tst_Eliminar.Click
        Dim row As CMDataSet.ROLESRow = ROLESBindingSource.Current.Row
        If row.Fixed Then
            MessageBox.Show("Este ROL no se puede eliminar")
            Return
        Else
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Configuracion_Roles_y_permisos, "Roles y Permisos", ROLESBindingSource.ToString(), "")
            ROLESBindingSource.RemoveCurrent()

        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Guardar()
    End Sub

    Private Sub lnk_Exportar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_Exportar.LinkClicked

        'Crear el script de insercion

        Dim script As String = "/* ROL " & ROLESDataGridView.SelectedRows(0).Cells(1).Value & " */" & vbCrLf
        Dim ID_ROLE As Integer = ROLESDataGridView.SelectedRows(0).Cells(0).Value

        For Each row As DataGridViewRow In Me.RolesItem_ResumenDataGridView.Rows
            Dim ID_ROLESITEM As Integer = row.Cells(ID_ROLESITEMDataGridViewTextBoxColumn7.Index).Value
            Dim ID_PERMISO As Integer = row.Cells(ID_PERMISODataGridViewTextBoxColumn6.Index).Value
            script = script & "INSERT INTO ROLESPERMISOS (ID_ROLES,ID_PERMISO, ID_ROLESITEM) VALUES (" _
                     & ID_ROLE & ", " & ID_PERMISO & ", " & ID_ROLESITEM & ");" & vbCrLf
        Next

        Dim diag As SaveFileDialog = New SaveFileDialog()
        If diag.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Salvar el script en un fichero
            Try
                Dim stream As StreamWriter = File.CreateText(diag.FileName)
                stream.Write(script)
                stream.Close()
            Catch ex As Exception
                Globales.ShowError(ex)
            End Try
        End If

    End Sub

    Private Sub lnk_GrantALL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_GrantALL.LinkClicked
        For Each row As DataGridViewRow In Me.RolesItem_ResumenDataGridView.Rows
            row.Cells(ID_PERMISODataGridViewTextBoxColumn6.Index).Value = RoleManager.TipoPermisos.Total
        Next
    End Sub

    Private Sub lnk_DenyAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_DenyAll.LinkClicked
        For Each row As DataGridViewRow In Me.RolesItem_ResumenDataGridView.Rows
            row.Cells(ID_PERMISODataGridViewTextBoxColumn6.Index).Value = RoleManager.TipoPermisos.Ninguno
        Next
    End Sub

    Private Sub RolesItem_ResumenDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RolesItem_ResumenDataGridView.SelectionChanged
        Dim a As New Object

        If sender.selectedcells.count > 0 Then

            a = sender.selectedcells(0)
            Select Case Me.RolesItem_ResumenDataGridView.Rows(a.RowIndex).Cells(0).Value
                Case "Bloquear_historial"
                    Me.lblInfo.Text = "Bloquear_historial -> Valor Ninguno: evita que el historial sea editado transcurrido 1 dia. " & vbCrLf & _
                    "Cualquier otro valor: permite la edición/modificación del historial aunque haya transcurrido un dia."
                Case "Libro_Ingresos_Gastos"
                    Me.lblInfo.Text = "Libro_Ingresos_Gastos -> Procede sólo al estar activa la opción de la configuración 'Activar control de Libro de Ingresos y gastos'. " & _
                                      "Valor Total: Permite la selección libre de fechas en el Libro de Ingresos y Gastos. " & vbCrLf & "Cualquier otro valor: Limita dicha selección de fechas a una semana hacia atras."

                Case Else
                    Me.lblInfo.Text = "Información adicional."
            End Select

        End If
    End Sub

    Private Sub completaRoles()
        Dim db As New CMLinqDataContext

        Dim roles As List(Of ROLE)
        Dim items As New RoleManager
        Dim i As Integer

        roles = db.ROLEs.ToList
        Dim r As ROLE
        Dim esta As Boolean = False
        Dim log As String = ""
        For Each r In roles
            Dim id As Integer = r.ID_ROLE
            Dim rper As IQueryable(Of ROLESPERMISO)
            rper = db.ROLESPERMISOs.Where(Function(o) o.ID_ROLES = id)

            For Each i In [Enum].GetValues(GetType(centro_medico.RoleManager.Items))
                Dim tmp As Integer = rper.Where(Function(o) o.ID_ROLESITEM = i).Count
                Dim name As String = CType(i, centro_medico.RoleManager.Items).ToString()
                If tmp > 0 Then
                    esta = True
                Else
                    If Not db.ROLESITEMs.Where(Function(o) o.ID_ROLESITEM = i).Count() > 0 Then
                        Dim ROLESITEMS As New ROLESITEM With {
                        .ID_ROLESITEM = i,
                        .Nombre = name
                                }
                        db.ROLESITEMs.InsertOnSubmit(ROLESITEMS)
                    End If

                    Dim rolepermision As New ROLESPERMISO With {
                                .ID_ROLES = id,
                                .ID_ROLESITEM = i,
                                .ID_PERMISO = (IIf(id = 1, RoleManager.TipoPermisos.Total, RoleManager.TipoPermisos.Ninguno)),
                                .Notas = ""
                            }
                    db.ROLESPERMISOs.InsertOnSubmit(rolepermision)
                    log += "ROL: " & r.Nombre & " - PERMISO: " & i & vbCrLf
                End If
            Next

            Try
                db.SubmitChanges()

            Catch ex As Exception
                Globales.ErrorMsg(ex, "Error al completar los permisos. Contacte con su administrador")
            End Try

        Next
        log = vbCrLf & log
        MsgBox("Roles Completados: " & log)
    End Sub


    Private Sub tst_Permisos_Click(sender As Object, e As EventArgs) Handles tst_Permisos.Click
        Dim res As MsgBoxResult
        If (Globales.Usuario.EsAdministrador) Then
            res = MsgBox("Se dispone a completar los permisos de todos los roles, no continue si no sabe lo que está haciendo. ¿Desea continuar?", MsgBoxStyle.YesNo)

            If res = MsgBoxResult.Yes Then completaRoles()
        End If
    End Sub
End Class