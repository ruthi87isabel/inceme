Imports Janus.Windows.GridEX
Public Class Bonos_form
    Dim bn As New Bonos
    Private context As CMLinqDataContext
    Public desdePaciente As Boolean = False
    Private paciente As PACIENTE

    Public Sub New(ByRef _context As CMLinqDataContext, Optional ByRef _paciente As PACIENTE = Nothing, Optional ByRef _desdePaciente As Boolean = False)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        If Not Globales.Usuario.EsAdministrador And Globales.Usuario.Permisos(RoleManager.Items.Bonos) = RoleManager.TipoPermisos.Ninguno Then
            MsgBox("Su usuario no tiene permisos para acceder a esta parte del programa", MsgBoxStyle.Exclamation)
            Me.Close()
            Me.Dispose()
        End If

        context = _context
        paciente = _paciente
        desdePaciente = _desdePaciente

        AplicaPermisos()
        If Not paciente Is Nothing Then
            Label1.Text = "PACIENTE: " & paciente.NombreCompleto & "(" & paciente.CPACIENTE & ")"
        End If



        bn.context = context
        If desdePaciente = True Then bn.CodigoPaciente = paciente.CPACIENTE
        Me.BindingSource1.DataSource = bn.cargaBonos

    End Sub

    Private Sub AplicaPermisos()
        If Globales.Usuario.EsAdministrador Or Globales.Usuario.Permisos(RoleManager.Items.Bonos) = RoleManager.TipoPermisos.Total Then
            tst_Editar.Enabled = True
            tst_Eliminar.Enabled = True
            tstNuevo.Enabled = True
        End If
        If Globales.Usuario.EsAdministrador Or Globales.Usuario.Permisos(RoleManager.Items.Bonos) = RoleManager.TipoPermisos.Modificar Then
            tst_Editar.Enabled = True
            tstNuevo.Enabled = True
        End If
    End Sub

    Private Sub Guardar()
        Try
            BindingSource1.EndEdit()

            context.SubmitChanges()
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error al guardar")
        End Try
    End Sub

    Private Sub EliminarFilas()
        Dim conf As MsgBoxResult = MsgBox("Se dispone a borrar los elementos seleccionados. Esto no podrá deshacerse, ¿seguro que desea continuar?", MsgBoxStyle.YesNo)

        If conf = MsgBoxResult.Yes Then
            Dim rowsSelected As Janus.Windows.GridEX.GridEXRow()
            rowsSelected = GridEX2.GetCheckedRows()

            If rowsSelected.Count > 0 Then
                For Each r As Janus.Windows.GridEX.GridEXRow In rowsSelected
                    If r.GetChildRows.Count > 0 Then
                        MsgBox("El bono tienen sesiones vinculadas y por ello no es posible eliminarlo")
                        Exit Sub
                    End If
                    r.Delete()
                Next
                Me.Guardar()
            End If
        End If
    End Sub
    Private Sub SeleccionaPaciente()
        If desdePaciente = False Then
            Dim frmPacientes As New frmPacientesListado
            frmPacientes.Modo = Globales.ModoParaFormas.Seleccion
            frmPacientes.ShowDialog()

            If Not frmPacientes.Paciente Is Nothing Then
                Me.paciente = frmPacientes.Paciente
                Label1.Text = "PACIENTE: " & paciente.NombreCompleto & "(" & paciente.CPACIENTE & ")"
            End If
        End If
    End Sub
    Private Sub AddBono()
        If Not paciente Is Nothing Then

            Dim b As Bonos = BindingSource1.AddNew
            b.cpaciente = paciente.CPACIENTE
            b.fecha = Now.Date
            b.Notas = ""
            BindingSource1.Add(b)
            Me.Guardar()
        Else
            SeleccionaPaciente()
            If Not paciente Is Nothing Then
                Me.AddBono()
            End If
        End If
    End Sub
    Private Function SeleccionaFactura(ByRef CodigoPaciente As Integer) As FACTURA
        Dim frmFacturas As New frmFacturasM
        frmFacturas.Modo = Globales.ModoParaFormas.Seleccion
        frmFacturas.Context = context
        frmFacturas.IdPacienteToFilter = CodigoPaciente
        frmFacturas.ShowDialog()

        If Not frmFacturas.Factura Is Nothing Then
            Return frmFacturas.Factura
        Else
            Return Nothing
        End If

    End Function
#Region "Eventos"
    Private Sub tst_Editar_Click(sender As Object, e As EventArgs) Handles tst_Editar.Click
        Me.Guardar()
    End Sub

    Private Sub tst_Eliminar_Click(sender As Object, e As EventArgs) Handles tst_Eliminar.Click
        Me.EliminarFilas()
    End Sub

    Private Sub GridEX2_ColumnButtonClick(sender As Object, e As ColumnActionEventArgs) Handles GridEX2.ColumnButtonClick

        Dim conf As MsgBoxResult

        If e.Column.Key = "Facturar" Then
            Dim data As Bonos = GridEX2.CurrentRow.DataRow
            If Globales.Usuario.EsAdministrador Or Not (Globales.Usuario.Permisos(RoleManager.Items.Bonos) = RoleManager.TipoPermisos.Ninguno) Then

                Dim fc As FACTURA
                Dim pac As PACIENTE = GridEX2.CurrentRow.DataRow.paciente


                If data.FACTURA Is Nothing Then
                    If Not pac Is Nothing Then
                        fc = SeleccionaFactura(pac.CPACIENTE)
                    Else
                        Exit Sub
                    End If

                    If Not fc Is Nothing Then
                        Dim fc_tmp As FACTURA = (From a As FACTURA In context.FACTURAs Where a.IDFACTURA = fc.IDFACTURA Select a).SingleOrDefault
                        data.FACTURA = fc_tmp
                        Me.Guardar()
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Bonos, "Bonos/Factura", data.id, _
                                                        "Se ha vinculado la factura " & fc_tmp.NUMERO & " al bono " & data.id & " por el usuario " & Globales.Usuario.NOMBRECOMPLETO & ".")
                    End If

                Else
                    'si tiene factura asociada entonces el botón sirve para desasociar
                    Dim msg As MsgBoxResult = MsgBox("Va a desvincular la factura del bono, esta operación no podrá deshacerse, ¿Seguro que desea continuar?", vbYesNo)
                    If msg = MsgBoxResult.Yes Then
                        Dim idf As String = data.FACTURA.NUMERO
                        data.FACTURA = Nothing
                        Me.Guardar()
                        Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Bonos, "Bonos/Factura", data.id, _
                                                        "Se ha desvinculado la factura " & idf & " del bono " & data.id & " por el usuario " & Globales.Usuario.NOMBRECOMPLETO & ".")
                    End If
                End If

            Else
                MsgBox("Su usuario no tiene permisos para asociar los bonos a facturas")
            End If
        End If



        If e.Column.Key = "BorrarSesion" Then
            If Globales.Usuario.EsAdministrador Or Globales.Usuario.Permisos(RoleManager.Items.Bonos) = RoleManager.TipoPermisos.Total Then
                'Elimino así la sesión porque si lo hago con el metodo delete de la grid da error de restricción del FK entre los bonos y las sesiones.
                conf = MsgBox("Va a borrar esta sesión y no podrá deshacer la acción. ¿Seguro que desea continuar?", MsgBoxStyle.YesNo)
                If conf = MsgBoxResult.Yes Then
                    context.Sesiones.DeleteOnSubmit(GridEX2.CurrentRow.DataRow)
                    GridEX2.Refetch()
                    Me.Guardar()
                End If
            Else
                MsgBox("Su usuario no tiene permisos para borrar sesiones")
            End If
        End If
    End Sub

    Private Sub tls_addBono_Click(sender As Object, e As EventArgs)
        Me.AddBono()
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        SeleccionaPaciente()
    End Sub


    Private Sub GridEX2_DoubleClick(sender As Object, e As EventArgs) Handles GridEX2.DoubleClick
        Dim cc As GridEXColumn = GridEX2.CurrentColumn

        If cc.Key = "FacturaNumero" Then
            Dim numero As String = GridEX2.CurrentRow.Cells(cc).Value.ToString

            Dim factura As FACTURA = (From a In context.FACTURAs Where a.NUMERO = numero And a.Eliminado = False Select a).SingleOrDefault
            Dim facturaform As New frmFacturasM_ADD

            facturaform.Factura = factura
            facturaform.Context = context
            facturaform.ShowDialog()

        End If
    End Sub

    Private Sub tstNuevo_Click(sender As Object, e As EventArgs) Handles tstNuevo.Click
        Me.AddBono()
    End Sub
#End Region

    

   

    
   
End Class