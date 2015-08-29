Imports System.IO

Public Class form_mutuas
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim ftlfno1o As String
    Dim fnotao As String
    Dim fnameo As String
    Dim ftlfno2o As String
    Dim ffaxo As String
    Dim _mailo As String
    Dim fdirecciono As String
    Dim fcontactoo As String
    Dim fpoblaciono As String
    Dim fcpo As String
    Dim fCIFo As String
    Dim fprovinciao As String
    Dim fwebo As String
    Dim fespecialidado As String
    Dim fficheroo As String
    Dim clickaccept As Boolean = False

    Private Sub MUTUASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MUTUASBindingSource.EndEdit()
        Me.MUTUASTableAdapter.Update(Me.CMDataSet.MUTUAS)

    End Sub

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

    Private Sub MUTUASBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MUTUASBindingSource.EndEdit()
        Me.MUTUASTableAdapter.Update(Me.CMDataSet.MUTUAS)

    End Sub

    Private Sub Inicializa()
        Me.MUTUASTableAdapter.FillMutuaById(CMDataSet.MUTUAS, fId)
        Dim _data As CMDataSet.MUTUASDataTable = Me.MUTUASTableAdapter.GetMutuaById(fId)
        fnameo = _data.Rows(0).Item("NOMBRE").ToString()
        fdirecciono = _data.Rows(0).Item("DIRECCION").ToString()
        ftlfno1o = _data.Rows(0).Item("TLFNO1").ToString()
        ftlfno2o = _data.Rows(0).Item("TLFNO2").ToString()
        _mailo = _data.Rows(0).Item("MAIL").ToString()
        fcpo = _data.Rows(0).Item("CP").ToString()
        fpoblaciono = _data.Rows(0).Item("POBLACION").ToString()
        fCIFo = _data.Rows(0).Item("CIF").ToString()
        fprovinciao = _data.Rows(0).Item("PROVINCIA").ToString()
        fwebo = _data.Rows(0).Item("WEB").ToString()
        fespecialidado = _data.Rows(0).Item("ESPECIALIDAD").ToString()
        fnotao = _data.Rows(0).Item("NOTAS").ToString()
        ffaxo = _data.Rows(0).Item("FAX").ToString()
        fcontactoo = _data.Rows(0).Item("PERSONACON").ToString()
        If Not _data.Rows(0).Item("PARTELSR") Is Nothing Then
            fficheroo = _data.Rows(0).Item("PARTELSR").ToString()
        End If

        If Not _data(0).IsIdTarifaNull() Then
            CtrlTarifa1.ID_Tarifas = _data(0).IdTarifa
        End If

        Dim m As MUTUA = Globales.Context.MUTUAs.SingleOrDefault(Function(mu) mu.CMUTUA = fId)

        If (Not m.Logo Is Nothing) Then ptbLogo.Image = Image.FromStream(New MemoryStream(m.Logo.ToArray()))

        tb_direccion.Text = fdirecciono
        tb_tel1.Text = ftlfno1o
        tb_tel2.Text = ftlfno2o
        tb_mail.Text = _mailo
        tb_poblacion.Text = fpoblaciono
        tb_provincia.Text = fprovinciao
        tb_cp.Text = fcpo
        tb_CIF.Text = fCIFo
        tb_web.Text = fwebo
        tb_especialidad.Text = fespecialidado
        tb_notas.Text = fnotao
        tb_nombre.Text = fnameo
        tb_fax.Text = ffaxo
        tb_fichero.Text = fficheroo
        tb_contacto.Text = fcontactoo
        tb_codmutua.Text = fId.ToString()
        Dim _datap As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteByMutua(fId)
        Dim _resp As DataTable = New DataTable()
        _resp.Columns.Add("Cod. Paciente")
        _resp.Columns.Add("Nombre")
        Dim _datae As CMDataSet.EMPRESASDataTable = EMPRESASTableAdapter.GetEmpresaByMutua(fId)
        Dim _rese As DataTable = New DataTable()
        _rese.Columns.Add("Codigo")
        _rese.Columns.Add("Empresa")
        _rese.Columns.Add("Actividad")
        Dim _dataf As CMDataSet.FACTURASDataTable = FACTURASTableAdapter.GetFacturaByMutua(fId)
        Dim _resf As DataTable = New DataTable()
        _resf.Columns.Add("F.Emision")
        _resf.Columns.Add("No")
        _resf.Columns.Add("F.Cobro")
        _resf.Columns.Add("Total")
        _resf.Columns.Add("Cod. Paciente")
        _resf.Columns.Add("Paciente")
        Dim i As Integer
        For i = 0 To _datap.Rows.Count() - 1
            Dim nombre As String = _datap.Rows(i).Item("NOMBRE").ToString()
            Dim apellido1 As String = _datap.Rows(i).Item("APELLIDO1").ToString()
            Dim apellido2 As String = _datap.Rows(i).Item("APELLIDO2").ToString()
            Dim cod As Integer = _datap.Rows(i).Item("CPACIENTE").ToString()
            Dim datos As String = apellido1 + " " + apellido2 + "," + nombre
            _resp.Rows.Add(cod, datos)
        Next
        For i = 0 To _datae.Rows.Count() - 1
            Dim code As Integer = _datae.Rows(i).Item("CEMPRESA")
            Dim empresa As String = _datae.Rows(i).Item("NOMBRE").ToString()
            Dim actividad As String = _datae.Rows(i).Item("ACTIVIDAD").ToString()
            _rese.Rows.Add(code, empresa, actividad)
        Next
        For i = 0 To _dataf.Rows.Count() - 1
            Dim femision As Date
            If Not _dataf.Rows(i).Item("FEMISION") Is DBNull.Value Then
                femision = _dataf.Rows(i).Item("FEMISION")
            End If
            Dim fcobro As Date
            If Not _dataf.Rows(i).Item("FECHACOBRO") Is DBNull.Value Then
                fcobro = _dataf.Rows(i).Item("FECHACOBRO")
            End If
            Dim total As Single = _dataf.Rows(i).Item("TOTAL")
            Dim cod As Integer = _dataf.Rows(i).Item("REFPACIENTE")
            Dim numero As String = _dataf.Rows(i).Item("NUMERO").ToString()
            Dim datap As CMDataSet.PACIENTESDataTable = PACIENTESTableAdapter.GetPacienteById(cod)
            Dim nombre As String = datap.Rows(0).Item("NOMBRE").ToString()
            Dim apellido1 As String = datap.Rows(0).Item("APELLIDO1").ToString()
            Dim apellido2 As String = datap.Rows(0).Item("APELLIDO2").ToString()
            Dim datos As String = apellido1 + " " + apellido2 + "," + nombre
            _resf.Rows.Add(femision.Date, numero, fcobro.Date, total, cod, datos)
        Next

        dgv_pacientes.DataSource = _resp
        dgv_empresa.DataSource = _rese
        dgv_facturas.DataSource = _resf
    End Sub

    Private Sub form_mutuas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Refrescar()
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()

        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then

            Inicializa()
            tb_direccion.ReadOnly = True
            tb_tel1.ReadOnly = True
            tb_tel2.ReadOnly = True
            tb_mail.ReadOnly = True
            tb_poblacion.ReadOnly = True
            tb_provincia.ReadOnly = True
            tb_fichero.ReadOnly = True
            tb_cp.ReadOnly = True
            tb_CIF.ReadOnly = True
            tb_web.ReadOnly = True
            tb_especialidad.ReadOnly = True
            tb_notas.ReadOnly = True
            tb_nombre.ReadOnly = True
            tb_fax.ReadOnly = True
            tb_contacto.ReadOnly = True
            tb_codmutua.ReadOnly = True

            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"
        End If

    End Sub


    Private Sub bt_fichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_fichero.Click
        Dim dir As String = Globales.Configuracion.impresionfilesdirectory
        OpenFileDialog1.InitialDirectory = dir
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim _indice As Integer = OpenFileDialog1.FileName.LastIndexOf("\")
            Dim _dir As String = OpenFileDialog1.FileName.Substring(_indice + 1)
            tb_fichero.Text = _dir
        End If

    End Sub


    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub



    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _tlfno1 As String = tb_tel1.Text.Trim()
            Dim _nota As String = tb_notas.Text.Trim()
            Dim _name As String = tb_nombre.Text.Trim()
            Dim _tlfno2 As String = tb_tel2.Text.Trim()
            Dim _fax As String = tb_fax.Text.Trim()
            Dim _mail As String = tb_mail.Text.Trim()
            Dim _direccion As String = tb_direccion.Text.Trim()
            Dim _contacto As String = tb_contacto.Text.Trim()
            Dim _poblacion As String = tb_poblacion.Text.Trim()
            Dim _cp As String = tb_cp.Text.Trim()
            Dim _CIF As String = tb_CIF.Text.Trim()
            Dim _provincia As String = tb_provincia.Text.Trim()
            Dim _fichero As String = tb_fichero.Text.Trim()
            Dim _web As String = tb_web.Text.Trim()
            Dim _especialidad As String = tb_especialidad.Text.Trim()
            Dim _cod As String = ""
            Dim _codigo As Integer
            If tb_codmutua.Text <> "" Then
                Try
                    _codigo = Integer.Parse(tb_codmutua.Text.Trim())
                    _cod = tb_codmutua.Text.Trim()
                Catch ex As Exception
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                If _cod = "0" Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Else
                MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If _cod <> "" Then
                Dim _data As CMDataSet.MUTUASDataTable = Me.MUTUASTableAdapter.GetMutuaById(_codigo)

                If Me.CurrentAccion = Enums.Accion.Modificar Then

                    Try
                        'Me.MUTUASTableAdapter.UpdateValores(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, Integer.Parse(_cod), _CIF, _especialidad, _fichero, "", fId)
                        Dim m As MUTUA = Globales.Context.MUTUAs.SingleOrDefault((Function(mu) mu.CMUTUA = Integer.Parse(_cod)))
                        m.CIF = _CIF
                        m.CP = _cp
                        m.DIRECCION = _direccion
                        m.ESPECIALIDAD = _especialidad
                        m.FAX = _fax
                        m.IdTarifa = CtrlTarifa1.ID_Tarifas
                        m.MAIL = _mail
                        m.NOMBRE = _name
                        m.NOTAS = _nota
                        m.NoContrato = NoContratoTextBox.Text
                        m.POBLACION = _poblacion
                        m.PROVINCIA = _provincia
                        m.TLFNO1 = _tlfno1
                        m.TLFNO2 = _tlfno2
                        m.WEB = _web

                        If (Not String.IsNullOrEmpty(txtLogo.Text)) Then m.Logo = File.ReadAllBytes(txtLogo.Text)

                        Globales.Context.SubmitChanges()

                    Catch ex As Exception
                        MessageBox.Show("Error! el codigo de mutua ya existe")
                    End Try

                    Me.MUTUASBindingSource.EndEdit()
                    Try
                        Dim n As Integer = Me.MUTUASTableAdapter.Update(CMDataSet.MUTUAS)
                    Catch ex As Exception
                    End Try

                    Dim a As Integer = 0

                Else
                    If _data.Rows.Count = 0 Then
                        Try
                            'Me.MUTUASTableAdapter.Insert(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, Integer.Parse(_cod), _CIF, _especialidad, _fichero, "", CtrlTarifa1.ID_Tarifas, NoContratoTextBox.Text)
                            Dim m As New MUTUA
                            m.CIF = _CIF
                            m.CP = _cp
                            m.CMUTUA = Integer.Parse(_cod)
                            m.DIRECCION = _direccion
                            m.ESPECIALIDAD = _especialidad
                            m.FAX = _fax
                            m.IdTarifa = CtrlTarifa1.ID_Tarifas
                            m.MAIL = _mail
                            m.NOMBRE = _name
                            m.NOTAS = _nota
                            m.NoContrato = NoContratoTextBox.Text
                            m.POBLACION = _poblacion
                            m.PROVINCIA = _provincia
                            m.TLFNO1 = _tlfno1
                            m.TLFNO2 = _tlfno2
                            m.WEB = _web

                            If (Not String.IsNullOrEmpty(txtLogo.Text)) Then m.Logo = File.ReadAllBytes(txtLogo.Text)

                            Globales.Context.MUTUAs.InsertOnSubmit(m)
                            Globales.Context.SubmitChanges()

                        Catch ex As Exception
                        End Try

                    Else
                        MessageBox.Show("Una mutua con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_codmutua.Clear()
                        Return
                    End If
                End If

                Me.MUTUASTableAdapter.Fill(CMDataSet.MUTUAS)
                clickaccept = True
                Me.Close()
            End If
        End If
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
            _dataf = FACTURASTableAdapter.GetFacturasByFEmision(dtp_inicial.Value.Date, dtp_fin.Value.Date)

        Else : _dataf = FACTURASTableAdapter.GetFacturasByFCobro(dtp_inicial.Value.Date, dtp_fin.Value.Date)
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
        Me.FICHEROSTableAdapter.Fill(CMDataSet.FICHEROS)
        dgv_ficheros.DataSource = FICHEROSBindingSource
        dgv_ficheros.Columns("CODIGO").Visible = False
        dgv_ficheros.Columns("REFPACIENTE").Visible = False
        dgv_ficheros.Columns("FECHAMODIFICACION").Visible = False
        dgv_ficheros.Columns("NOTAS").Visible = False
        dgv_ficheros.Columns("FECHA").Name = "Fecha"
        dgv_ficheros.Columns("DESCRIPCION").Name = "Descripcion"
        dgv_ficheros.Columns("FICHERO").Name = "Fichero"

    End Sub

    Private Sub bt_nuevofichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_nuevofichero.Click
        Dim _nuevo_fichero As form_ficheros = New form_ficheros("Ficheros-Añadir", Enums.Accion.Insertar)
        _nuevo_fichero.ShowInTaskbar = False
        _nuevo_fichero.ShowDialog()
        Refrescar()
    End Sub

    Private Sub bt_modificarfichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificarfichero.Click
        If dgv_ficheros.Rows.Count > 0 Then
            Dim Id As Integer = dgv_ficheros.SelectedRows.Item(0).Cells("CODIGO").Value
            Dim _nuevo_fichero As form_ficheros = New form_ficheros("Ficheros-Editar", Enums.Accion.Modificar, Id)
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
                Dim Id As String = dgv_ficheros.SelectedRows.Item(i).Cells("CODIGO").Value
                name = dgv_ficheros.SelectedRows.Item(i).Cells("FICHERO").Value
                Me.FICHEROSTableAdapter.DeleteFicheroById(Id)
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

    Private Sub tb_codmutua_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_codmutua.TextChanged
        ChequearTextboxSoloNumero(tb_codmutua)
    End Sub

    Private Sub bt_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_view.Click
        Dim _direccion As String = Globales.Configuracion.dirfiles
        _direccion = _direccion + "\"
        Dim url As Uri = New Uri(_direccion + dgv_ficheros.SelectedRows(0).Cells("FICHERO").Value, UriKind.RelativeOrAbsolute)
        'Try
        WebBrowser1.Url = url
        'Catch ex As Exception
        WebBrowser1.Stop()
        'End 'Try
    End Sub

    Private Sub bt_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_open.Click
        Dim _direccion As String = Globales.Configuracion.dirfiles
        _direccion = _direccion + "\"
        Dim _vista As form_view = New form_view(_direccion, dgv_ficheros.SelectedRows(0).Cells("FICHERO").Value.ToString())
        _vista.ShowInTaskbar = False
        _vista.Show()
    End Sub


    Private Sub form_mutuas_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _tlfno1 As String = tb_tel1.Text.Trim()
            Dim _nota As String = tb_notas.Text.Trim()
            Dim _name As String = tb_nombre.Text.Trim()
            Dim _tlfno2 As String = tb_tel2.Text.Trim()
            Dim _fax As String = tb_fax.Text.Trim()
            Dim _mail As String = tb_mail.Text.Trim()
            Dim _direccion As String = tb_direccion.Text.Trim()
            Dim _contacto As String = tb_contacto.Text.Trim()
            Dim _poblacion As String = tb_poblacion.Text.Trim()
            Dim _cp As String = tb_cp.Text.Trim()
            Dim _CIF As String = tb_CIF.Text.Trim()
            Dim _provincia As String = tb_provincia.Text.Trim()
            Dim _web As String = tb_web.Text.Trim()
            Dim _especialidad As String = tb_especialidad.Text.Trim()
            Dim _fichero As String = tb_fichero.Text.Trim()
            Dim _cod As String = ""
            Dim _codigo As Integer
            If tb_codmutua.Text <> "" Then
                Try
                    _codigo = Integer.Parse(tb_codmutua.Text.Trim())
                    _cod = tb_codmutua.Text.Trim()
                Catch ex As Exception
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Cancel = True
                    Return

                End Try

                If _cod = "0" Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Cancel = True
                    Return
                End If
            End If

            If _cod <> "" Then
                Dim _data As CMDataSet.MUTUASDataTable = Me.MUTUASTableAdapter.GetMutuaById(_codigo)
                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.MUTUASTableAdapter.UpdateValores(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, Integer.Parse(_cod), _CIF, _especialidad, "", "", fId)
                    End If
                Else
                    If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        If _data.Rows.Count = 0 Then

                            Me.MUTUASTableAdapter.Insert(_name, _direccion, _poblacion, _provincia, _cp, _tlfno1, _tlfno2, _fax, _mail, _web, _contacto, _nota, Integer.Parse(_cod), _CIF, _especialidad, _fichero, "", Nothing, NoContratoTextBox.Text, Nothing, False)
                        Else
                            MessageBox.Show("Una mutua con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            tb_codmutua.Clear()
                            e.Cancel = True
                            Return
                        End If
                    End If
                End If

                Me.MUTUASTableAdapter.Fill(CMDataSet.MUTUAS)
            Else
                If MessageBox.Show("Esta seguro que desea intoducir los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    MessageBox.Show("Debe entrar un codigo válido para poder ser definido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    e.Cancel = True
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub btnLogo_Click(sender As System.Object, e As System.EventArgs) Handles btnLogo.Click

        If (DialogResult.OK = openLogoBox.ShowDialog()) Then
            txtLogo.Text = openLogoBox.FileName
            ptbLogo.Image = Image.FromFile(txtLogo.Text)
        End If

    End Sub

    Private Sub txtLogo_Leave(sender As System.Object, e As System.EventArgs) Handles txtLogo.Leave

        If (Not File.Exists(txtLogo.Text)) Then

            MsgBox("El logo no representa un fichero válido")

            txtLogo.Focus()

        End If

        ptbLogo.Image = Image.FromFile(txtLogo.Text)

    End Sub

End Class