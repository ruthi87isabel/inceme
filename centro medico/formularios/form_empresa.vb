Imports System.IO
Public Class form_empresa
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim ftlfno1o As String
    Dim fnotao As String
    Dim fnameo As String
    Dim ftlfno2o As String
    Dim ffaxo As String
    Dim fmailo As String
    Dim fdirecciono As String
    Dim fcontactoo As String
    Dim fpoblaciono As String
    Dim fcpo As String
    Dim fCIFo As String
    Dim fprovinciao As String
    Dim fCNAEo As String
    Dim factividado As String
    Dim fidmutuao As Integer
    Dim fNSSo As String
    Dim ffechao As Date
    Dim fentidado As String
    Dim foficinao As String
    Dim fDCo As String
    Dim fcuentao As String
    Dim ftitularo As String
    Dim fwebo As String
    Dim clickaccept As Boolean = False
    Dim creado As Boolean = False
    Dim generado As Boolean = False

    Dim tipos As String() = {"Mutua asistencial", "Compañia de revisión", "Aseguradora privada"}
    Dim nomenc As String() = {"M", "C", "A"}

    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName


    End Sub
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName
        Me.fId = aId


    End Sub

    Public Property CurrentAccion() As Enums.Accion

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return fcurrentAcc

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As Enums.Accion)
            fcurrentAcc = Value
        End Set
    End Property
    Private Sub RefrescaMutua()
        LMUTUASEMPRESASTableAdapter.Fill(CMDataSet.LMUTUASEMPRESAS)
        Dim _datam As CMDataSet.LMUTUASEMPRESASDataTable

        _datam = LMUTUASEMPRESASTableAdapter.GetMutuaEmpresaByEmpresa(fId)

        Dim _respm As DataTable = New DataTable()
        _respm.Columns.Add("Tipo")
        _respm.Columns.Add("Mutua")
        _respm.Columns.Add("Fecha Alta")
        _respm.Columns.Add("Fecha Baja")
        _respm.Columns.Add("IdMutua")
        _respm.Columns.Add("Codigo")
        Dim i As Integer
        For i = 0 To _datam.Rows.Count() - 1


            Dim mutua As Integer = _datam.Rows(i).Item("REFMUTUA").ToString()
            Dim tipo As String = _datam.Rows(i).Item("TIPO").ToString()
            Dim fa As Date = _datam.Rows(i).Item("FECHAALTA")
            Dim fb As Date
            If _datam.Rows(i).Item("FECHABAJA").GetType.ToString <> DBNull.Value.GetType.ToString Then
                fb = _datam.Rows(i).Item("FECHABAJA")
            End If

            Dim _datat As CMDataSet.MUTUASDataTable = MUTUASTableAdapter.GetMutuaById(mutua)
            Dim nombre As String
            If _datat.Rows.Count > 0 Then
                nombre = _datat.Rows(0).Item("NOMBRE").ToString()
            End If

            Dim cod As String = _datam.Rows(i).Item("CODIGO").ToString()
            Dim index As Integer = Array.IndexOf(nomenc, tipo)
            Dim tipon As String
            If index <> -1 Then
                tipon = tipos(index)
            End If

            _respm.Rows.Add(tipon, nombre, fa, fb, mutua, cod)

        Next

        dgv_mutuas.DataSource = _respm
        dgv_mutuas.Columns("IdMutua").Visible = False
        dgv_mutuas.Columns("Codigo").Visible = False
        If dgv_mutuas.Rows.Count > 0 Then
            fidmutuao = Integer.Parse(dgv_mutuas.SelectedRows(0).Cells("IdMutua").Value)
            lb_mutua.Text = GetMutua(fidmutuao)
        End If
    End Sub
    Private Sub Inicializa()
        Dim _data As CMDataSet.EMPRESASDataTable = Me.EMPRESASTableAdapter.GetEmpresaById(fId)
        fnameo = _data.Rows(0).Item("NOMBRE").ToString()
        fdirecciono = _data.Rows(0).Item("DIRECCION").ToString()
        ftlfno1o = _data.Rows(0).Item("TLFNO1").ToString()
        ftlfno2o = _data.Rows(0).Item("TLFNO2").ToString()
        fmailo = _data.Rows(0).Item("MAIL").ToString()
        fcpo = _data.Rows(0).Item("CP").ToString()
        fpoblaciono = _data.Rows(0).Item("POBLACION").ToString()
        fCIFo = _data.Rows(0).Item("CIF").ToString()
        fprovinciao = _data.Rows(0).Item("PROVINCIA").ToString()
        fwebo = _data.Rows(0).Item("WEB").ToString()
        fnotao = _data.Rows(0).Item("NOTAS").ToString()
        ffaxo = _data.Rows(0).Item("FAX").ToString()
        fcontactoo = _data.Rows(0).Item("PERSONACON").ToString()
        fCNAEo = _data.Rows(0).Item("CNAE").ToString()
        factividado = _data.Rows(0).Item("ACTIVIDAD").ToString()

        If _data.Rows(0).Item("REFMUTUA").GetType.ToString <> DBNull.Value.GetType.ToString Then
            fidmutuao = _data.Rows(0).Item("REFMUTUA")
        Else
            fidmutuao = Nothing
        End If


        fNSSo = _data.Rows(0).Item("NSS").ToString()
        If _data.Rows(0).Item("FECHA").GetType.ToString <> DBNull.Value.GetType.ToString Then
            ffechao = _data.Rows(0).Item("FECHA")
        End If
        fentidado = _data.Rows(0).Item("ENTIDAD").ToString()
        foficinao = _data.Rows(0).Item("OFICINA").ToString()
        fDCo = _data.Rows(0).Item("DC").ToString()
        fcuentao = _data.Rows(0).Item("CUENTA").ToString()
        ftitularo = _data.Rows(0).Item("TITULAR").ToString()


        tb_cod.Text = fId
        tb_direccion.Text = fdirecciono
        tb_tel1.Text = ftlfno1o
        tb_tel2.Text = ftlfno2o
        tb_mail.Text = fmailo
        tb_poblacion.Text = fpoblaciono
        tb_provincia.Text = fprovinciao
        tb_CP.Text = fcpo
        tb_CIF.Text = fCIFo
        tb_web.Text = fwebo
        tb_notas.Text = fnotao
        tb_nombre.Text = fnameo
        tb_fax.Text = ffaxo
        tb_contacto.Text = fcontactoo
        tb_CNAE.Text = fCNAEo
        tb_actividad.Text = factividado
        lb_mutua.Text = GetMutua(fidmutuao)
        tb_NSS.Text = fNSSo
        If ffechao = #12:00:00 AM# Then
            dtp_fecha.Value = Date.Today
        Else
            dtp_fecha.Value = ffechao
        End If
        tb_entidad.Text = fentidado
        tb_oficina.Text = foficinao
        tb_DC.Text = fDCo
        tb_cuenta.Text = fcuentao
        tb_titular.Text = ftitularo


        RefrescaMutua()
        If dgv_mutuas.Rows.Count > 0 Then
            bt_borrar.Enabled = True
            bt_actual.Enabled = True
            bt_modificar.Enabled = True
        End If
        Dim _datap As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteByEmpresa(fId)
        Dim _resp As DataTable = New DataTable()
        _resp.Columns.Add("Cod. Paciente")
        _resp.Columns.Add("Nombre")
        Dim i As Integer
        For i = 0 To _datap.Rows.Count() - 1
            Dim nombre As String = _datap.Rows(i).Item("NOMBRE").ToString()
            Dim apellido1 As String = _datap.Rows(i).Item("APELLIDO1").ToString()
            Dim apellido2 As String = _datap.Rows(i).Item("APELLIDO2").ToString()
            Dim cod As Integer = _datap.Rows(i).Item("CPACIENTE").ToString()
            Dim datos As String = apellido1 + " " + apellido2 + "," + nombre
            _resp.Rows.Add(cod, datos)
        Next

        dgv_pacientes.DataSource = _resp
        Dim _dataf As CMDataSet.FACTURASDataTable = FACTURASTableAdapter.GetFacturaByEmpresa(fId)
        Dim _resf As DataTable = New DataTable()
        _resf.Columns.Add("F.Emision")
        _resf.Columns.Add("No")
        _resf.Columns.Add("F.Cobro")
        _resf.Columns.Add("Total")
        _resf.Columns.Add("Cod. Paciente")
        _resf.Columns.Add("Paciente")
        For i = 0 To _dataf.Rows.Count() - 1
            Dim femision As Date = _dataf.Rows(i).Item("FEMISION")
            Dim fcobro As Date
            If Not _dataf.Rows(i).Item("FECHACOBRO") Is DBNull.Value Then
                fcobro = _dataf.Rows(i).Item("FECHACOBRO")
            End If
            Dim total As Single = _dataf.Rows(i).Item("TOTAL")
            Dim cod As Integer = _dataf.Rows(i).Item("REFPACIENTE")
            Dim numero As String = _dataf.Rows(i).Item("NUMEROFACTURA")
            Dim datap As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(cod)
            Dim nombre As String = datap.Rows(0).Item("NOMBRE").ToString()
            Dim apellido1 As String = datap.Rows(0).Item("APELLIDO1").ToString()
            Dim apellido2 As String = datap.Rows(0).Item("APELLIDO2").ToString()
            Dim datos As String = apellido1 + " " + apellido2 + "," + nombre
            _resf.Rows.Add(femision.Date, numero, fcobro.Date, total, cod, datos)
        Next
        dgv_facturas.DataSource = _resf

    End Sub
    Private Function GetMutua(ByVal aId As Integer) As String

        Dim _data As CMDataSet.MUTUASDataTable = Me.MUTUASTableAdapter.GetMutuaById(aId)
        Dim _mutua As String = ""
        If _data.Rows.Count > 0 Then
            _mutua = _data.Rows(0).Item("NOMBRE").ToString()
        End If
        Return _mutua

    End Function
    Private Sub form_empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMDataSet.FICHEROSGLOBAL' table. You can move, or remove it, as needed.
        Me.FICHEROSGLOBALTableAdapter.FillBySeccionReferencia(Me.CMDataSet.FICHEROSGLOBAL, "E", fId)
        Refrescar()
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()

        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then

            Inicializa()
            tb_cod.ReadOnly = True
            tb_direccion.ReadOnly = True
            tb_tel1.ReadOnly = True
            tb_tel2.ReadOnly = True
            tb_mail.ReadOnly = True
            tb_poblacion.ReadOnly = True
            tb_provincia.ReadOnly = True
            tb_CP.ReadOnly = True
            tb_CIF.ReadOnly = True
            tb_web.ReadOnly = True
            tb_notas.ReadOnly = True
            tb_nombre.ReadOnly = True
            tb_fax.ReadOnly = True
            tb_contacto.ReadOnly = True

            tb_CNAE.ReadOnly = True
            tb_actividad.ReadOnly = True
            tb_NSS.ReadOnly = True
            dtp_fecha.Enabled = False
            tb_entidad.ReadOnly = True
            tb_oficina.ReadOnly = True
            tb_DC.ReadOnly = True
            tb_cuenta.ReadOnly = True
            tb_titular.ReadOnly = True

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        If generado = True Then
            Dim _datae As CMDataSet.EMPRESASDataTable
            _datae = EMPRESASTableAdapter.GetEmpresaById(fId)
            If _datae.Rows.Count > 0 Then
                Dim _datam As CMDataSet.LMUTUASEMPRESASDataTable
                _datam = LMUTUASEMPRESASTableAdapter.GetMutuaEmpresaByEmpresa(fId)
                Dim i As Integer
                For i = 0 To _datam.Rows.Count - 1
                    Dim Id As Integer = _datam.Rows(i).Item("CODIGO")
                    LMUTUASEMPRESASTableAdapter.DeleteById(Id)
                Next
                EMPRESASTableAdapter.DeleteEmpresaById(fId)
            End If
        End If

        Me.Close()
    End Sub

    Private Sub bt_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_filtrar.Click
        Dim _resf As DataTable = New DataTable()
        _resf.Columns.Add("F.Emision")
        _resf.Columns.Add("No")
        _resf.Columns.Add("F.Cobro")
        _resf.Columns.Add("Total")
        _resf.Columns.Add("Cod. Paciente")
        _resf.Columns.Add("Paciente")
        Dim _dataf As CMDataSet.FACTURASDataTable
        If rb_femision.Checked Then
            _dataf = FACTURASTableAdapter.GetFacturaByFEmisionEmpresa(dtp_inicial.Value.Date, dtp_fin.Value.Date, fId)

        Else : _dataf = FACTURASTableAdapter.GetFacturaByFCobroEmpresa(dtp_inicial.Value.Date, dtp_fin.Value.Date, fId)
        End If
        Dim i As Integer
        For i = 0 To _dataf.Rows.Count() - 1
            Dim femision As Date = _dataf.Rows(i).Item("FEMISION")
            Dim fcobro As Date = _dataf.Rows(i).Item("FECHACOBRO")
            Dim total As Single = _dataf.Rows(i).Item("TOTAL")
            Dim cod As Integer = _dataf.Rows(i).Item("REFPACIENTE")
            Dim numero As String = _dataf.Rows(i).Item("NUMEROFACTURA")
            Dim datap As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(cod)
            Dim nombre As String = datap.Rows(0).Item("NOMBRE").ToString()
            Dim apellido1 As String = datap.Rows(0).Item("APELLIDO1").ToString()
            Dim apellido2 As String = datap.Rows(0).Item("APELLIDO2").ToString()
            Dim datos As String = apellido1 + " " + apellido2 + "," + nombre
            _resf.Rows.Add(femision.Date, numero, fcobro.Date, total, cod, datos)
        Next

        dgv_facturas.DataSource = _resf
    End Sub

    Private Sub Refrescar()
        Me.FICHEROSGLOBALTableAdapter.FillBySeccionReferencia(CMDataSet.FICHEROSGLOBAL, "E", Me.fId)
        dgv_ficheros.DataSource = FICHEROSGLOBALBindingSource
        dgv_ficheros.Columns("ID").Visible = False
        dgv_ficheros.Columns("REFREGISTRO").Visible = False
        dgv_ficheros.Columns("SECCION").Visible = False
        dgv_ficheros.Columns("FECHA").Name = "Fecha"
        dgv_ficheros.Columns("DESCRIPCION").Name = "Descripcion"
        dgv_ficheros.Columns("FICHERO").Name = "Fichero"

    End Sub

    Private Sub bt_nuevofichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_nuevofichero.Click
        Dim nuevoId As Integer = 0
        If Me.FICHEROSGLOBALTableAdapter.MaxidFicheroGlobal().HasValue = True Then nuevoId = Me.FICHEROSGLOBALTableAdapter.MaxidFicheroGlobal().Value
        nuevoId += 1
        Dim _nuevo_fichero As form_ficheroGlobal = New form_ficheroGlobal("Ficheros-Añadir", Enums.Accion.Insertar, nuevoId, "E", Me.fId)
        _nuevo_fichero.ShowInTaskbar = False
        _nuevo_fichero.ShowDialog()
        Refrescar()
    End Sub

    Private Sub bt_modificarfichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificarfichero.Click
        If dgv_ficheros.Rows.Count > 0 Then
            Dim Id As Integer = dgv_ficheros.SelectedRows.Item(0).Cells("ID").Value
            Dim _nuevo_fichero As form_ficheroGlobal = New form_ficheroGlobal("Ficheros-Editar", Enums.Accion.Modificar, Id, "E", Me.fId)
            _nuevo_fichero.ShowInTaskbar = False
            _nuevo_fichero.ShowDialog()
            Refrescar()
        End If
    End Sub

    Private Sub bt_borrarfichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_borrarfichero.Click

        If dgv_ficheros.Rows.Count > 0 Then
            Dim name As String = ""
            Dim i As Integer
            For i = 0 To dgv_ficheros.SelectedRows.Count - 1
                Dim Id As String = dgv_ficheros.SelectedRows.Item(i).Cells("ID").Value
                name = dgv_ficheros.SelectedRows.Item(i).Cells("FICHERO").Value
                Me.FICHEROSGLOBALTableAdapter.DeleteQueryById(Id)
            Next
            Refrescar()

            'Impersonar al usuario segun su carpeta compartida
            If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                                                            Globales.Configuracion.CarpetaCompartidaPassword, _
                                                            Globales.Configuracion.CarpetaCompartidaDominio)
            End If

            'Operacion a realizar con las credenciales almacenadas
            File.Delete(Globales.Configuracion.dirfiles + "\" + name)

            'Desacher la impersonacion
            If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
                If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                    GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
                End If
            End If

        End If
    End Sub
    Private Sub Crea()
        Dim _Id As Integer
        If tb_cod.Text <> "" Then
            _Id = Integer.Parse(tb_cod.Text.Trim())

        Else
            If EMPRESASTableAdapter.MaximoId.HasValue Then
                Dim _Idt As Integer = EMPRESASTableAdapter.MaximoId().Value
                _Id = _Idt + 1
            End If
        End If

        Dim _tlfno1 As String = tb_tel1.Text.Trim()
        Dim _nota As String = tb_notas.Text.Trim()
        Dim _name As String = tb_nombre.Text.Trim()
        Dim _tlfno2 As String = tb_tel2.Text.Trim()
        Dim _fax As String = tb_fax.Text.Trim()
        Dim _mail As String = tb_mail.Text.Trim()
        Dim _direccion As String = tb_direccion.Text.Trim()
        Dim _contacto As String = tb_contacto.Text.Trim()
        Dim _poblacion As String = tb_poblacion.Text.Trim()
        Dim _cp As String = tb_CP.Text.Trim()
        Dim _CIF As String = tb_CIF.Text.Trim()
        Dim _provincia As String = tb_provincia.Text.Trim()
        Dim _web As String = tb_web.Text.Trim()
        Dim _mutua As String = lb_mutua.Text.Trim()
        Dim _CNAE As String = tb_CNAE.Text.Trim()
        Dim _actividad As String = tb_actividad.Text.Trim()
        Dim _NSS As String = tb_NSS.Text.Trim()
        Dim _fecha As Date = dtp_fecha.Value
        Dim _entidad As String = tb_entidad.Text.Trim()
        Dim _oficina As String = tb_oficina.Text.Trim()
        Dim _DC As String = tb_DC.Text.Trim()
        Dim _cuenta As String = tb_cuenta.Text.Trim()
        Dim _titular As String = tb_titular.Text.Trim()
        Dim _cod As Integer = Nothing
        Dim _dataf As CMDataSet.MUTUASDataTable = MUTUASTableAdapter.GetIdByName(_mutua)
        If _dataf.Rows.Count > 0 Then
            If _dataf.Rows(0).Item("CMUTUA").GetType().ToString() <> DBNull.Value.GetType.ToString() Then
                _cod = Integer.Parse(_dataf.Rows(0).Item("CMUTUA"))
            End If
        Else : _cod = 0
        End If

        If _cod <> 0 Then
            Me.EMPRESASTableAdapter.Insert(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, False)
        Else
            Me.EMPRESASTableAdapter.InsertSinMutua(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular)
        End If

        'Me.EMPRESASTableAdapter.Insert(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular)
        creado = True
        generado = True
        fId = _Id
        tb_cod.Text = fId.ToString()
    End Sub

    Private Sub form_empresa_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If (clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver) Then
            Dim _Id As Integer
            If tb_cod.Text <> "" Then
                'Try
                _Id = Integer.Parse(tb_cod.Text.Trim())
                'Catch ex As Exception
                MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
                'End 'Try

                If _Id = 0 Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Else
                If MessageBox.Show("Esta seguro que desea intoducir los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    MessageBox.Show("Debe entrar un codigo válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                Else
                    Return
                End If
            End If
            Dim _data As CMDataSet.EMPRESASDataTable = Me.EMPRESASTableAdapter.GetEmpresaById(_Id)

            Dim _tlfno1 As String = tb_tel1.Text.Trim()
            Dim _nota As String = tb_notas.Text.Trim()
            Dim _name As String = tb_nombre.Text.Trim()
            Dim _tlfno2 As String = tb_tel2.Text.Trim()
            Dim _fax As String = tb_fax.Text.Trim()
            Dim _mail As String = tb_mail.Text.Trim()
            Dim _direccion As String = tb_direccion.Text.Trim()
            Dim _contacto As String = tb_contacto.Text.Trim()
            Dim _poblacion As String = tb_poblacion.Text.Trim()
            Dim _cp As String = tb_CP.Text.Trim()
            Dim _CIF As String = tb_CIF.Text.Trim()
            Dim _provincia As String = tb_provincia.Text.Trim()
            Dim _web As String = tb_web.Text.Trim()
            Dim _mutua As String = lb_mutua.Text.Trim()
            Dim _CNAE As String = tb_CNAE.Text.Trim()
            Dim _actividad As String = tb_actividad.Text.Trim()
            Dim _NSS As String = tb_NSS.Text.Trim()
            Dim _fecha As Date = dtp_fecha.Value
            Dim _entidad As String = tb_entidad.Text.Trim()
            Dim _oficina As String = tb_oficina.Text.Trim()
            Dim _DC As String = tb_DC.Text.Trim()
            Dim _cuenta As String = tb_cuenta.Text.Trim()
            Dim _titular As String = tb_titular.Text.Trim()
            Dim _cod As Integer = Nothing
            Dim _dataf As CMDataSet.MUTUASDataTable = MUTUASTableAdapter.GetIdByName(_mutua)
            If _dataf.Rows.Count > 0 Then
                If _dataf.Rows(0).Item("CMUTUA").GetType().ToString() <> DBNull.Value.GetType.ToString() Then
                    _cod = Integer.Parse(_dataf.Rows(0).Item("CMUTUA"))
                End If
            Else : _cod = 0
            End If
            If creado = True Or Me.CurrentAccion = Enums.Accion.Modificar Then
                If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If tb_cod.Text <> fId.ToString() Then

                        If _cod <> 0 Then
                            Me.EMPRESASTableAdapter.Update1(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, fId, False)
                        Else
                            Me.EMPRESASTableAdapter.UpdateSinMutua(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, fId)
                        End If

                        'Me.EMPRESASTableAdapter.Update1(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, fId)
                        Dim _datam As CMDataSet.LMUTUASEMPRESASDataTable = LMUTUASEMPRESASTableAdapter.GetMutuaEmpresaByEmpresa(fId)

                        If _datam.Rows.Count > 0 Then
                            Dim i As Integer
                            For i = 0 To _datam.Rows.Count - 1
                                Dim cod = _datam.Rows(i).Item("CODIGO")
                                LMUTUASEMPRESASTableAdapter.UpdateEmpresa(_Id, cod)
                            Next

                        End If

                    ElseIf Me.CurrentAccion = Enums.Accion.Modificar Then

                        If _cod <> 0 Then
                            Me.EMPRESASTableAdapter.Update1(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, False, fId)
                        Else
                            Me.EMPRESASTableAdapter.UpdateSinMutua(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, fId)
                        End If

                        'Me.EMPRESASTableAdapter.Update1(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, fId)
                        Dim _datam As CMDataSet.LMUTUASEMPRESASDataTable = LMUTUASEMPRESASTableAdapter.GetMutuaEmpresaByEmpresa(fId)

                        If _datam.Rows.Count > 0 Then
                            Dim i As Integer
                            For i = 0 To _datam.Rows.Count - 1
                                Dim cod = _datam.Rows(i).Item("CODIGO")
                                LMUTUASEMPRESASTableAdapter.UpdateEmpresa(_Id, cod)
                            Next

                        End If


                    End If
                End If
            ElseIf generado = False Then
                If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If _data.Rows.Count > 0 Then

                        MessageBox.Show("Una empresa con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_cod.Clear()
                        Return
                    End If

                    If _cod <> 0 Then
                        Me.EMPRESASTableAdapter.Insert(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, False)
                    Else
                        Me.EMPRESASTableAdapter.InsertSinMutua(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular)
                    End If

                    Dim _datap As CMDataSet.EMPRESASDataTable = EMPRESASTableAdapter.GetData()
                    fId = _datap.Rows(_datap.Rows.Count - 1).Item("CEMPRESA")
                    Dim _datam As CMDataSet.LMUTUASEMPRESASDataTable = LMUTUASEMPRESASTableAdapter.GetMutuaEmpresaByEmpresa(fId)

                    If _datam.Rows.Count > 0 Then
                        Dim i As Integer
                        For i = 0 To _datam.Rows.Count - 1
                            Dim cod = _datam.Rows(i).Item("CODIGO")
                            LMUTUASEMPRESASTableAdapter.UpdateEmpresa(fId, cod)
                        Next

                    End If

                Else
                    Dim _datae As CMDataSet.EMPRESASDataTable
                    _datae = EMPRESASTableAdapter.GetEmpresaById(fId)
                    If _datae.Rows.Count > 0 Then
                        Dim _datam As CMDataSet.LMUTUASEMPRESASDataTable
                        _datam = LMUTUASEMPRESASTableAdapter.GetMutuaEmpresaByEmpresa(fId)
                        Dim i As Integer
                        For i = 0 To _datam.Rows.Count - 1
                            Dim Id As Integer = _datam.Rows(i).Item("CODIGO")
                            LMUTUASEMPRESASTableAdapter.DeleteById(Id)
                        Next
                        EMPRESASTableAdapter.DeleteEmpresaById(fId)
                    End If

                End If
            End If
            Me.EMPRESASTableAdapter.Fill(CMDataSet.EMPRESAS)

        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _Id As Integer
            If tb_cod.Text <> "" Then
                Try
                    _Id = Integer.Parse(tb_cod.Text.Trim())
                Catch ex As Exception
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                If _Id = 0 Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Else
                MessageBox.Show("Debe entrar un codigo válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim _data As CMDataSet.EMPRESASDataTable = Me.EMPRESASTableAdapter.GetEmpresaById(_Id)
            Dim _tlfno1 As String = tb_tel1.Text.Trim()
            Dim _nota As String = tb_notas.Text.Trim()
            Dim _name As String = tb_nombre.Text.Trim()
            Dim _tlfno2 As String = tb_tel2.Text.Trim()
            Dim _fax As String = tb_fax.Text.Trim()
            Dim _mail As String = tb_mail.Text.Trim()
            Dim _direccion As String = tb_direccion.Text.Trim()
            Dim _contacto As String = tb_contacto.Text.Trim()
            Dim _poblacion As String = tb_poblacion.Text.Trim()
            Dim _cp As String = tb_CP.Text.Trim()
            Dim _CIF As String = tb_CIF.Text.Trim()
            Dim _provincia As String = tb_provincia.Text.Trim()
            Dim _web As String = tb_web.Text.Trim()
            Dim _mutua As String = lb_mutua.Text.Trim()
            Dim _CNAE As String = tb_CNAE.Text.Trim()
            Dim _actividad As String = tb_actividad.Text.Trim()
            Dim _NSS As String = tb_NSS.Text.Trim()
            Dim _fecha As Date = dtp_fecha.Value
            Dim _entidad As String = tb_entidad.Text.Trim()
            Dim _oficina As String = tb_oficina.Text.Trim()
            Dim _DC As String = tb_DC.Text.Trim()
            Dim _cuenta As String = tb_cuenta.Text.Trim()
            Dim _titular As String = tb_titular.Text.Trim()
            Dim _cod As Integer = Nothing
            Dim _dataf As CMDataSet.MUTUASDataTable = MUTUASTableAdapter.GetIdByName(_mutua)
            If _dataf.Rows.Count > 0 Then
                If _dataf.Rows(0).Item("CMUTUA").GetType().ToString() <> DBNull.Value.GetType.ToString() Then
                    _cod = Integer.Parse(_dataf.Rows(0).Item("CMUTUA"))
                End If
            Else : _cod = 0
            End If
            If creado = True Or Me.CurrentAccion = Enums.Accion.Modificar Then
                If tb_cod.Text <> fId.ToString() Then

                    If _cod <> 0 Then
                        Me.EMPRESASTableAdapter.Update1(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, False, fId)
                    Else
                        Me.EMPRESASTableAdapter.UpdateSinMutua(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, fId)
                    End If

                    'Me.EMPRESASTableAdapter.Update1(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, fId)
                    Dim _datam As CMDataSet.LMUTUASEMPRESASDataTable = LMUTUASEMPRESASTableAdapter.GetMutuaEmpresaByEmpresa(fId)

                    If _datam.Rows.Count > 0 Then
                        Dim i As Integer
                        For i = 0 To _datam.Rows.Count - 1
                            Dim cod = _datam.Rows(i).Item("CODIGO")
                            LMUTUASEMPRESASTableAdapter.UpdateEmpresa(_Id, cod)
                        Next

                    End If

                ElseIf Me.CurrentAccion = Enums.Accion.Modificar Then

                    If _cod <> 0 Then
                        Me.EMPRESASTableAdapter.Update1(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, False, fId)
                    Else
                        Me.EMPRESASTableAdapter.UpdateSinMutua(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, fId)
                    End If

                    'Me.EMPRESASTableAdapter.Update1(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, fId)
                    Dim _datam As CMDataSet.LMUTUASEMPRESASDataTable = LMUTUASEMPRESASTableAdapter.GetMutuaEmpresaByEmpresa(fId)

                    If _datam.Rows.Count > 0 Then
                        Dim i As Integer
                        For i = 0 To _datam.Rows.Count - 1
                            Dim cod = _datam.Rows(i).Item("CODIGO")
                            LMUTUASEMPRESASTableAdapter.UpdateEmpresa(_Id, cod)
                        Next

                    End If

                End If


            ElseIf generado = False Then
                If _data.Rows.Count > 0 Then

                    MessageBox.Show("Una empresa con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tb_cod.Clear()
                    Return
                End If

                If _cod <> 0 Then
                    Me.EMPRESASTableAdapter.Insert(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular, False)
                Else
                    Me.EMPRESASTableAdapter.InsertSinMutua(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular)
                End If

                'Me.EMPRESASTableAdapter.Insert(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, _CNAE, _actividad, _Id, _cod, _CIF, _NSS, _fecha, _entidad, _oficina, _DC, _cuenta, _titular)
                Dim _datap As CMDataSet.EMPRESASDataTable = EMPRESASTableAdapter.GetData()
                fId = _datap.Rows(_datap.Rows.Count - 1).Item("CEMPRESA")
                Dim _datam As CMDataSet.LMUTUASEMPRESASDataTable = LMUTUASEMPRESASTableAdapter.GetMutuaEmpresaByEmpresa(fId)

                If _datam.Rows.Count > 0 Then
                    Dim i As Integer
                    For i = 0 To _datam.Rows.Count - 1
                        Dim cod = _datam.Rows(i).Item("CODIGO")
                        LMUTUASEMPRESASTableAdapter.UpdateEmpresa(fId, cod)
                    Next

                End If


            End If
            Me.EMPRESASTableAdapter.Fill(CMDataSet.EMPRESAS)
            clickaccept = True
            Me.Close()
        End If
    End Sub


    Private Sub bt_nueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_nueva.Click
        If fId = 0 Then
            Crea()
        End If
        Dim _nueva_mutua As form_mutua_empresa = New form_mutua_empresa("Ficha de mutuas-Añadir", Enums.Accion.Insertar, fId)
        _nueva_mutua.ShowInTaskbar = False
        _nueva_mutua.ShowDialog()
        RefrescaMutua()
        creado = False
        If dgv_mutuas.Rows.Count > 0 Then
            If MessageBox.Show("Desea utilizar esta como la mutua activa", "Mutua activa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                fidmutuao = Integer.Parse(dgv_mutuas.Rows(dgv_mutuas.Rows.Count - 1).Cells("IdMutua").Value)
                lb_mutua.Text = GetMutua(fidmutuao)
            End If
        End If
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If dgv_mutuas.Rows.Count > 0 Then
            Dim Id As Integer = dgv_mutuas.SelectedRows.Item(0).Cells("Codigo").Value
            Dim _nueva_mutua As form_mutua_empresa = New form_mutua_empresa("Ficha de mutuas-Editar", Enums.Accion.Modificar, Id, fId)
            _nueva_mutua.ShowInTaskbar = False
            _nueva_mutua.ShowDialog()
            RefrescaMutua()
        End If
    End Sub

    Private Sub bt_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_borrar.Click
        If dgv_mutuas.Rows.Count > 0 Then
            Dim Id As Integer = dgv_mutuas.SelectedRows.Item(0).Cells("Codigo").Value
            Dim Idmutua As Integer = dgv_mutuas.SelectedRows.Item(0).Cells("IdMutua").Value
            LMUTUASEMPRESASTableAdapter.DeleteById(Id)
            RefrescaMutua()
            If Idmutua = fidmutuao Then
                MessageBox.Show("Ha borrado la mutua activa correspondiente a esta empresa, si desea no dejar esta en blanco seleccione una mutua activa nueva", "Mutua activa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub bt_actual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_actual.Click
        If dgv_mutuas.Rows.Count > 0 Then
            If MessageBox.Show("Desea utilizar esta como la mutua activa", "Mutua activa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                fidmutuao = Integer.Parse(dgv_mutuas.SelectedRows(0).Cells("IdMutua").Value)
                lb_mutua.Text = GetMutua(fidmutuao)
            End If
        End If
    End Sub

    Private Sub tb_DC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_DC.TextChanged
        If tb_DC.Text.Length > 0 Then
            tb_DC.BackColor = Color.Red
        Else : tb_DC.BackColor = Color.White
        End If
    End Sub

    Private Sub ChequearTextboxSoloNumero(ByVal aTexbox As TextBox)
        Dim _text As String = aTexbox.Text
        Dim _number As Single
        Dim _texto As String = ""
        Dim modif As Integer = _text.Length
        If _text <> "" And _text <> Nothing Then
            If _text.Length > 0 Then
                Dim i As Integer
                For i = 0 To _text.Length - 1
                    If Not Integer.TryParse(_text(i), _number) Then
                        modif = i
                        Continue For
                    Else
                        _texto = _texto + _text(i)
                    End If

                Next
                aTexbox.Text = _texto

            End If
        End If
        If modif <> _text.Length Then
            aTexbox.SelectionStart = modif
        End If
    End Sub

    Private Sub tb_cod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_cod.TextChanged
        ChequearTextboxSoloNumero(tb_cod)
    End Sub

    Private Sub bt_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_view.Click
        Dim _direccion As String = Globales.Configuracion.dirfiles
        _direccion = _direccion + "\"
        Dim url As Uri = New Uri(_direccion + dgv_ficheros.SelectedRows(0).Cells("FICHERO").Value, UriKind.RelativeOrAbsolute)
        'Try

        'Impersonar al usuario segun su carpeta compartida
        If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
            Globales.Configuracion.UserImpersonation = GoltraTools.FileCopier.Impersonate(Globales.Configuracion.CarpetaCompartidaUsuario, _
                                                        Globales.Configuracion.CarpetaCompartidaPassword, _
                                                        Globales.Configuracion.CarpetaCompartidaDominio)
        End If

        'Operacion a realizar con las credenciales almacenadas
        'File.Copy(fcompletename, Globals.Configuracion.dirfiles + "\" + _nombre, True)
        WebBrowser1.Url = url

        'Desacher la impersonacion
        If Globales.Configuracion.UsarCuentaDominioParaCarpetaCompartida Then
            If Not Globales.Configuracion.UserImpersonation Is Nothing Then
                GoltraTools.FileCopier.UndoImpersonate(Globales.Configuracion.UserImpersonation)
            End If
        End If

        'Catch ex As Exception
        ' WebBrowser1.Stop()
        'End 'Try
    End Sub

    Private Sub bt_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_open.Click
        Dim _direccion As String = Globales.Configuracion.dirfiles
        _direccion = _direccion + "\"
        If dgv_ficheros.SelectedRows.Count > 0 Then
            Dim _vista As form_view = New form_view(_direccion, dgv_ficheros.SelectedRows(0).Cells("FICHERO").Value.ToString())
            _vista.ShowInTaskbar = False
            _vista.Show()
        End If


    End Sub
End Class