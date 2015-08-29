Public Class frmProveedor_Nuevo

    Dim actual As CMDataSet.N_ProveedoresRow

    Public ID_Proveedor As Integer = -1


    Private Sub frmProveedor_Nuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.BANCOS' table. You can move, or remove it, as needed.
        Me.BANCOSTableAdapter.Fill(Me.CMDataSet.BANCOS)
        'TODO: This line of code loads data into the 'CMDataSet.FORMASPAGO' table. You can move, or remove it, as needed.
        Me.FORMASPAGOTableAdapter.Fill(Me.CMDataSet.FORMASPAGO)

        tcDatos.TabPages.Clear()
        tcDatos.TabPages.Add(tbFicha)
        tcDatos.TabPages.Add(Me.tbObservaciones)
        'permisos
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Lectura Then
            Me.btnGuardar.Enabled = False
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Modificar Then
            Me.btnGuardar.Enabled = True
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Ninguno Then
            Globales.MsgboxErrorPermisoNoAutorizado()
            Me.Close()
        End If
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Proveedores) = RoleManager.TipoPermisos.Total Then
            Me.btnGuardar.Enabled = True
        End If

        'TODO: This line of code loads data into the 'CMDataSet.DocumentosProveedores' table. You can move, or remove it, as needed.
        'Me.DocumentosProveedoresTableAdapter.Fill(Me.CMDataSet.DocumentosProveedores)
        'TODO: This line of code loads data into the 'CMDataSet.N_Bancos' table. You can move, or remove it, as needed.
        Me.BANCOSTableAdapter.Fill(Me.CMDataSet.BANCOS)
        Me.FORMASPAGOTableAdapter.Fill(Me.CMDataSet.FORMASPAGO)


        If ID_Proveedor = -1 Then
            'Nuevo proveedor
            actual = CType(N_ProveedoresBindingSource.AddNew(), DataRowView).Row
            'N_Contactos_ProveedorFULLDataGridView.DataSource = Nothing
        Else
            Me.N_ProveedoresTableAdapter.FillBy(Me.CMDataSet.N_Proveedores, ID_Proveedor)
            actual = CType(N_ProveedoresBindingSource.Current(), DataRowView).Row
            'N_Contactos_ProveedorFULLTableAdapter.Fill(CMDataSet.N_Contactos_ProveedorFULL, ID_Proveedor)
        End If

        'carga documentos adjuntos
        'Me.DocumentManager1.ConnectionString = My.MySettings.Default.FontanalsBDConnectionString
        'Me.DocumentManager1.IdCategoria = Globals.CategoriaDocumento.DocsProveedores
        'Me.DocumentManager1.QueryExcluyente = "Select idDoc From DocumentosProveedores Where idProveedor=" & actual.ID_Proveedor
        'Me.DocumentManager1.UpdateList()
    End Sub
    'Private Sub documentmanager1_FileDeleted(ByVal iddoc As System.Int64) Handles DocumentManager1.FileDeleted
    '    If Not actual Is Nothing Then
    '        Me.DocumentosProveedoresTableAdapter.Delete(iddoc, actual.ID_Proveedor)
    '        Me.DocumentManager1.UpdateList()
    '    End If
    'End Sub
    'Private Sub documentmanager1_FileAdded(ByVal iddoc As System.Int64) Handles DocumentManager1.FileAdded
    '    If Not actual Is Nothing Then
    '        Me.DocumentosProveedoresTableAdapter.Insert(iddoc, actual.ID_Proveedor)
    '        Me.DocumentManager1.UpdateList()
    '    End If
    'End Sub

    'Private Sub btnRappels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRappels.Click
    '    Dim frm As frmEscalasRappels_Proveedor = New frmEscalasRappels_Proveedor()
    '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        N_EscalasRappels_ProveedorDataGridView.DataSource = frm.N_EscalasRappels_ProveedorDataGridView.DataSource
    '    End If
    'End Sub


    Private Sub pb_AnnadirUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'Dim frm As frmContactos = New frmContactos()
        'If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then

        '    Dim values() As Object = {frm.Contacto.ID_Contacto, frm.Contacto.NombreContacto, frm.Contacto.NombreEmpresa, frm.Contacto.Cargo, frm.Contacto.Telefono1, frm.Contacto.Movil, frm.Contacto.Fax, frm.Contacto.Email}

        '    Dim nuevo As CMDataSet.N_Contactos_ProveedorFULLRow = N_Contactos_ProveedorFULLBindingSource.AddNew().Row

        '    nuevo.ID_Contacto = frm.ID_Contacto
        '    nuevo.NombreContacto = frm.Contacto.NombreContacto
        '    nuevo.NombreEmpresa = frm.Contacto.NombreEmpresa


        'End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        'Validacion de datos

        If CodigoTextBox1.Text = "" Or CodigoTextBox1.Text Is Nothing Then
            MessageBox.Show("El codigo no puede estar vacio!!")
            CodigoTextBox1.Focus()
            Return
        End If

        If NombreFiscalTextBox.Text = "" Then
            MessageBox.Show("El Nombre Fiscal no puede estar vacio!!")
            NombreFiscalTextBox.Focus()
            Return
        End If

        If NombreComercialTextBox.Text = "" Then
            MessageBox.Show("El Nombre Comercial no puede estar vacio!!")
            NombreComercialTextBox.Focus()
            Return
        End If


        Dim TipoProveedor As Integer = Globales.TipoProveedor.Proveedor
        If rb_Acreedor.Checked Then
            TipoProveedor = Globales.TipoProveedor.Acreedor
        End If

        Dim TipoPorte As Integer = Globales.TipoPorte.Debidos
        If rb_Pagados.Checked Then
            TipoPorte = Globales.TipoPorte.Pagados
        End If

        Dim TipoIva As Integer = Globales.ProveedorIVA.Si
        If rb_IVA_No.Checked Then TipoIva = Globales.ProveedorIVA.No
        If rb_IVA_Importacion.Checked Then TipoIva = Globales.ProveedorIVA.Importacion
        If rb_IVA_Intracomunitarios.Checked Then TipoIva = Globales.ProveedorIVA.Intracomunitarios

        actual.TipoProveedor = TipoProveedor
        actual.TipoIVA = TipoIva
        actual.TipoPorte = TipoPorte

        Me.Validate()
        N_ProveedoresBindingSource.EndEdit()
        N_ProveedoresTableAdapter.Update(CMDataSet.N_Proveedores)


        ID_Proveedor = actual.ID_Proveedor

        'Dim CAdapter As CMDataSetTableAdapters.N_Contactos_ProveedorTableAdapter = New CMDataSetTableAdapters.N_Contactos_ProveedorTableAdapter()

        'Ahora los contactos
        'For Each row As DataGridViewRow In N_Contactos_ProveedorFULLDataGridView.Rows
        '    Dim cRow As CMDataSet.N_Contactos_ProveedorFULLRow = CType(row.DataBoundItem.Row, CMDataSet.N_Contactos_ProveedorFULLRow)

        '    'Hay que borrar todos los contactos'

        '    'Annadirlos de nuevo
        '    CAdapter.Insert(ID_Proveedor, cRow.ID_Contacto)
        'Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

        'Contactos
        'Dim adapter As CMDataSetTableAdapters.N_Contactos_ProveedorTableAdapter = New CMDataSetTableAdapters.N_Contactos_ProveedorTableAdapter()
        'adapter.Insert(ID_Proveedor, frm.ID_Contacto)

    End Sub

    Private Sub CodigoTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoTextBox1.TextChanged

    End Sub
End Class