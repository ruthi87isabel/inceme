Imports System.IO
Imports System.Xml
Public Class form_user
    Dim fadmin As String
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim fusuario As String
    Dim fidmedico As Integer
    Dim fcontrasena As String
    Dim ffecha As Date
    Dim fnivel As String
    Dim fnombre As String
    Dim clickaccept As Boolean = False
    Dim certificadopath As String


    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName



    End Sub

    Private Sub Inicializa()
        Dim _data As CMDataSet.USUARIOSDataTable = Me.USUARIOSTableAdapter.GetUserById(fId)
        fusuario = _data.Rows(0).Item("USUARIO").ToString()
        fcontrasena = _data.Rows(0).Item("CONTRASENA").ToString()
        fadmin = _data.Rows(0).Item("ADMINISTRADOR").ToString()
        If Integer.TryParse(_data.Rows(0).Item("REFMEDICO").ToString(), fidmedico) Then
            fidmedico = _data.Rows(0).Item("REFMEDICO")
        End If
        If _data.Rows(0).Item("FECHACLAVE").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            ffecha = _data.Rows(0).Item("FECHACLAVE")
        Else
            ffecha = Date.Now
        End If
        fnivel = _data.Rows(0).Item("NIVEL").ToString()
        fnombre = _data.Rows(0).Item("NOMBRECOMPLETO").ToString()


        If _data.Rows(0).Item("CERTIFICADOPATH").GetType().ToString() <> DBNull.Value.GetType().ToString() Then
            certificadopath = _data.Rows(0).Item("CERTIFICADOPATH")
        End If
        tb_certificadoPath.Text = certificadopath
        tb_cod.Text = fId.ToString()
        tb_contrasena.Text = fcontrasena
        tb_rcontrasena.Text = fcontrasena
        If fidmedico <> 0 Then
            tb_idmedico.Text = fidmedico.ToString()
            lb_medico.Text = GetMedico(fidmedico)
            tb_nombre.Text = GetMedico(fidmedico)
        Else
            tb_nombre.Text = fnombre
        End If
        tb_user.Text = fusuario
        If fadmin = "S" Then
            chb_admin.Checked = True
        Else
            chb_admin.Checked = False
        End If
        Dim _datap As CMDataSet.PERMISOS_USUARIODataTable = Me.PERMISOS_USUARIOTableAdapter.GetPermisoByUsuario(fId)
        Dim i As Integer
        For i = 0 To _datap.Rows.Count - 1
            Dim _item As String = _datap.Rows(i).Item("ITEM").ToString().Trim()
            Dim _idpermiso As Integer = _datap.Rows(i).Item("REFPERMISO")

            If _item = "Gastos" Then
                If _idpermiso = 1 Then
                    rb_gastosninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_gastoslectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_gastostotal.Checked = True
                Else
                    rb_gastosseleccionar.Checked = True
                End If
            End If

            If _item = "Medicos" Then
                If _idpermiso = 1 Then
                    rb_medicosninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_medicoslectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_medicostotal.Checked = True
                Else
                    rb_medicosseleccionar.Checked = True
                End If
            End If

            If _item = "Mutuas" Then
                If _idpermiso = 1 Then
                    rb_mutuasninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_mutuaslectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_mutuastotal.Checked = True
                Else
                    rb_mutuasseleccionar.Checked = True
                End If
            End If

            If _item = "Proveedores" Then
                If _idpermiso = 1 Then
                    rb_proveedoresninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_proveedoreslectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_proveedorestotal.Checked = True
                Else
                    rb_proveedoresseleccionar.Checked = True
                End If
            End If

            If _item = "Articulos" Then
                If _idpermiso = 1 Then
                    rb_articuloninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_articulolectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_articulototal.Checked = True
                Else
                    rb_articuloseleccionar.Checked = True
                End If
            End If

            If _item = "Bancos" Then
                If _idpermiso = 1 Then
                    rb_bancosninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_bancoslectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_bancostotal.Checked = True
                Else
                    rb_bancosseleccionar.Checked = True
                End If
            End If

            If _item = "Pacientes" Then
                If _idpermiso = 1 Then
                    rb_pacientesninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_pacienteslectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_pacientestotal.Checked = True
                Else
                    rb_pacientesseleccionar.Checked = True
                End If
            End If

            If _item = "Empresas" Then
                If _idpermiso = 1 Then
                    rb_empresasninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_empresaslectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_empresatotal.Checked = True
                Else
                    rb_empresaseleccionar.Checked = True
                End If
            End If

            If _item = "Facturas" Then
                If _idpermiso = 1 Then
                    rb_facturaninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_facturalectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_facturatotal.Checked = True
                Else
                    rb_facturaseleccionar.Checked = True
                End If
            End If

            If _item = "Citas" Then
                If _idpermiso = 1 Then
                    rb_citaninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_citalectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_citatotal.Checked = True
                Else
                    rb_citaseleccionar.Checked = True
                End If
            End If

            If _item = "Bajas" Then
                If _idpermiso = 1 Then
                    rb_bajaninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_bajalectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_bajatotal.Checked = True
                Else
                    rb_bajaseleccionar.Checked = True
                End If
            End If

            If _item = "Asistencia" Then
                If _idpermiso = 1 Then
                    rb_asistninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_asistlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_asisttotal.Checked = True
                Else
                    rb_asistseleccionar.Checked = True
                End If
            End If

            If _item = "Analiticas" Then
                If _idpermiso = 1 Then
                    rb_analninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_anallectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_analtotal.Checked = True
                Else
                    rb_analseleccionar.Checked = True
                End If
            End If

            If _item = "Recibos" Then
                If _idpermiso = 1 Then
                    rb_reciboninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_recibolectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_recibototal.Checked = True
                Else
                    rb_reciboseleccionar.Checked = True
                End If
            End If

            If _item = "Generar Recibos" Then
                If _idpermiso = 1 Then
                    rb_genrecninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_genreclectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_genrectotal.Checked = True
                Else
                    rb_genrecseleccionar.Checked = True
                End If
            End If

            If _item = "Imprimir Remesas" Then
                If _idpermiso = 1 Then
                    rb_remninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_remlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_remtotal.Checked = True
                Else
                    rb_remseleccionar.Checked = True
                End If
            End If

            If _item = "Ficheros" Then
                If _idpermiso = 1 Then
                    rb_ficheroninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_ficherolectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_ficherototal.Checked = True
                Else
                    rb_ficheroseleccionar.Checked = True
                End If
            End If

            If _item = "Rev. Comp." Then
                If _idpermiso = 1 Then
                    rb_revninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_revlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_revtotal.Checked = True
                Else
                    rb_revseleccionar.Checked = True
                End If
            End If

            If _item = "Recetas" Then
                If _idpermiso = 1 Then
                    rb_recetaninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_recetalectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_recetatotal.Checked = True
                Else
                    rb_recetaseleccionar.Checked = True
                End If
            End If

            If _item = "Historiales" Then
                If _idpermiso = 1 Then
                    rb_histninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_histlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_histtotal.Checked = True
                Else
                    rb_histseleccionar.Checked = True
                End If
            End If

            If _item = "Info Primaria" Then
                If _idpermiso = 1 Then
                    rb_infoninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_infolectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_infototal.Checked = True
                Else
                    rb_infoseleccionar.Checked = True
                End If
            End If

            If _item = "Alarmas" Then
                If _idpermiso = 1 Then
                    rb_alarmaninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_alarmalectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_alarmatotal.Checked = True
                Else
                    rb_alarmaseleccionar.Checked = True
                End If
            End If

            If _item = "Diagnostico" Then
                If _idpermiso = 1 Then
                    rb_diagnosticoninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_diagnosticolectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_diagnosticototal.Checked = True
                Else
                    rb_diagnosticoseleccionar.Checked = True
                End If
            End If

            If _item = "Medicamentos" Then
                If _idpermiso = 1 Then
                    rb_medninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_medlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_medtotal.Checked = True
                Else
                    rb_medseleccionar.Checked = True
                End If
            End If

            If _item = "Indicaciones" Then
                If _idpermiso = 1 Then
                    rb_indninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_indlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_indtotal.Checked = True
                Else
                    rb_indseleccionar.Checked = True
                End If
            End If

            If _item = "Formas Pago" Then
                If _idpermiso = 1 Then
                    rb_fpninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_fplectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_fptotal.Checked = True
                Else
                    rb_fpseleccionar.Checked = True
                End If
            End If

            If _item = "Paises" Then
                If _idpermiso = 1 Then
                    rb_paisninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_paislectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_paistotal.Checked = True
                Else
                    rb_paisseleccionar.Checked = True
                End If
            End If

            If _item = "Plantilla de Texto" Then
                If _idpermiso = 1 Then
                    rb_ptextninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_ptextlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_ptexttotal.Checked = True
                Else
                    rb_ptextseleccionar.Checked = True
                End If
            End If

            If _item = "Conceptos" Then
                If _idpermiso = 1 Then
                    rb_conceptninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_conceptlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_concepttotal.Checked = True
                Else
                    rb_conceptseleccionar.Checked = True
                End If
            End If

            If _item = "Plantillas Analiticas" Then
                If _idpermiso = 1 Then
                    rb_panalninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_panallectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_panaltotal.Checked = True
                Else
                    rb_panalseleccionar.Checked = True
                End If
            End If

            If _item = "Modelos" Then
                If _idpermiso = 1 Then
                    rb_modninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_modlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_modtotal.Checked = True
                Else
                    rb_modseleccionar.Checked = True
                End If
            End If

            If _item = "Plantillas Historial" Then
                If _idpermiso = 1 Then
                    rb_phistninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_phistlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_phisttotal.Checked = True
                Else
                    rb_phistseleccionar.Checked = True
                End If
            End If

            If _item = "Clinicas Externas" Then
                If _idpermiso = 1 Then
                    rb_clinicaninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_clinicalectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_clinicatotal.Checked = True
                Else
                    rb_clinicaseleccionar.Checked = True
                End If
            End If

            If _item = "Configuracion" Then
                If _idpermiso = 1 Then
                    rb_confninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_conflectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_conftotal.Checked = True
                Else
                    rb_confseleccionar.Checked = True
                End If
            End If

            If _item = "Copia" Then
                If _idpermiso = 1 Then
                    rb_copyninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_copylectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_copytotal.Checked = True
                Else
                    rb_copyseleccionar.Checked = True
                End If
            End If

            If _item = "Anadir Factura" Then
                If _idpermiso = 1 Then
                    rb_afactninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_afactlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_afacttotal.Checked = True
                Else
                    rb_afactseleccionar.Checked = True
                End If
            End If

            If _item = "Etiquetas" Then
                If _idpermiso = 1 Then
                    rb_etiqninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_etiqlectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_etiqtotal.Checked = True
                Else
                    rb_etiqseleccionar.Checked = True
                End If
            End If

            If _item = "LFacturas" Then
                If _idpermiso = 1 Then
                    rb_lfacturaninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_lfacturalectura.Checked = True

                End If
            End If

            If _item = "LPartes" Then
                If _idpermiso = 1 Then
                    rb_lpartesninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_lpartelectura.Checked = True

                End If
            End If

            If _item = "LRecetas" Then
                If _idpermiso = 1 Then
                    rb_lrecetaninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_lrecetalectura.Checked = True

                End If
            End If

            If _item = "LFaltas" Then
                If _idpermiso = 1 Then
                    rb_lasistninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_lasistlectura.Checked = True

                End If
            End If

            If _item = "LCitas" Then
                If _idpermiso = 1 Then
                    rb_lcitasninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_lcitalectura.Checked = True

                End If
            End If

            If _item = "Libro" Then
                If _idpermiso = 1 Then
                    rb_libroninguno.Checked = True
                ElseIf _idpermiso = 2 Then
                    rb_librolectura.Checked = True
                ElseIf _idpermiso = 3 Then
                    rb_librototal.Checked = True

                End If
            End If
        Next

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

    Private Sub USUARIOSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.USUARIOSBindingSource.EndEdit()
        Me.USUARIOSTableAdapter.Update(Me.CMDataSet.USUARIOS)

    End Sub

    Private Sub form_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
            If chb_admin.Checked = True Then
                For i = 0 To Me.TabControl1.Controls.Count - 1
                    Me.TabControl1.Controls(i).Enabled = False
                Next
            End If

        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            For i = 0 To Me.Controls.Count - 1
                Me.Controls(i).Enabled = False
            Next
            bt_cancel.Enabled = True
            TabControl1.Enabled = True
            For i = 0 To Me.TabControl1.Controls.Count - 1
                Me.TabControl1.Controls(i).Enabled = False
            Next
            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"

        End If
    End Sub

    Private Function GetMedico(ByVal aId As Integer) As String

        Dim _data As CMDataSet.MEDICOSDataTable = Me.MEDICOSTableAdapter.GetMedicoByID(aId)
        Dim _medname As String = _data.Rows(0).Item("NOMBRE").ToString()
        Dim _medapellido1 As String = _data.Rows(0).Item("APELLIDO1").ToString()
        Dim _medapellido2 As String = _data.Rows(0).Item("APELLIDO2").ToString()
        Dim _med As String = _medapellido1 + " " + _medapellido2 + " , " + _medname

        Return _med

    End Function

    Private Sub bt_medico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_medico.Click
        Me.MEDICOSTableAdapter.Fill(Me.CMDataSet.MEDICOS)
        Dim _name As String = "Listado de medicos"
        Dim _listados As form_listados = New form_listados(_name, MEDICOSBindingSource, RoleManager.Items.Medicos, True)
        _listados.ShowInTaskbar = False
        _listados.ShowDialog()
        If _listados.Selected() <> "" Then
            Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
            tb_idmedico.Text = _pcodo.ToString()
            lb_medico.Text = GetMedico(_pcodo)
            tb_nombre.Text = GetMedico(_pcodo)
        End If
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _cod As Integer
            If tb_cod.Text <> "" Then
                'Try
                _cod = Integer.Parse(tb_cod.Text.Trim())
                'Catch ex As Exception
                MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
                'End 'Try

                If _cod = 0 Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Else
                MessageBox.Show("Debe utilizar un codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim _name As String
            Dim _usuario As String = tb_user.Text.Trim()
            Dim _idmedico As Integer
            If tb_idmedico.Text <> "" Then

                _idmedico = Integer.Parse(tb_idmedico.Text.Trim())
                _name = GetMedico(_idmedico)
            Else
                _name = tb_nombre.Text.Trim()
            End If
            Dim _contrasena As String = tb_contrasena.Text.Trim()

            Dim _rcontrasena As String = tb_rcontrasena.Text.Trim()
            Dim _admin As String
            If chb_admin.Checked = True Then
                _admin = "S"
            Else : _admin = "N"
            End If
            If _rcontrasena <> _contrasena Then
                MessageBox.Show("La contraseña no coincide con su verificacion. Intentelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb_rcontrasena.Clear()
                tb_rcontrasena.Focus()
                Return
            End If
            If _cod.ToString() <> "" Then

                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    Me.USUARIOSTableAdapter.UpdateValores(_cod, _usuario, _contrasena, "", _admin, _name, _idmedico, Date.Today(), certificadopath, fId)
                Else
                    Dim _datap As CMDataSet.USUARIOSDataTable = Me.USUARIOSTableAdapter.GetUserByUser(_usuario)
                    If _datap.Rows.Count = 0 Then
                        Dim _data As CMDataSet.USUARIOSDataTable = Me.USUARIOSTableAdapter.GetUserById(_cod)
                        If _data.Rows.Count = 0 Then
                            Me.USUARIOSTableAdapter.Insert(_cod, _usuario, _contrasena, "", _admin, _name, _idmedico, Date.Today(), certificadopath)
                            AgregaConfig(_usuario)
                        Else
                            MessageBox.Show("Un usuario con ese codigo ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            tb_cod.Clear()
                            Return
                        End If
                    Else
                        MessageBox.Show("Un usuario con ese login ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_user.Clear()
                        Return
                    End If
                End If

                Llena(_cod)
                Me.USUARIOSTableAdapter.Fill(CMDataSet.USUARIOS)
                clickaccept = True
                Me.Close()
            Else
                MessageBox.Show("Debe tener un codigo valido para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

    End Sub

    Private Sub AgregaConfig(ByVal userlogin As String)
        Dim dir As String = Application.StartupPath()
        Dim di As DirectoryInfo = Directory.GetParent(dir)
        Dim dip As DirectoryInfo = di.Parent
        Dim direccion As String = dip.FullName
        'wwDim _writer As XmlWriter = New XmlTextWriter(direccion + "\\Config\\configuracion.xml", Nothing)
        Dim _doc As XmlDocument = New XmlDocument()
        _doc.Load(dir + "\\Config\\configuracion.xml")
        Dim node As XmlNode = _doc.ChildNodes(1).FirstChild
        Dim node1 As XmlNode = _doc.CreateNode(XmlNodeType.Element, "USER" + userlogin, _doc.BaseURI)
        Dim i As Integer
        For i = 0 To _doc.ChildNodes(1).ChildNodes(0).ChildNodes.Count - 1
            Dim nod As XmlNode = _doc.ChildNodes(1).ChildNodes(0).ChildNodes(i).CloneNode(True)
            node1.AppendChild(nod)
        Next
        _doc.ChildNodes(1).AppendChild(node1)
        _doc.Save(dir + "\\Config\\configuracion.xml")
    End Sub

    Private Sub Llena(ByVal acod As Integer)
        If Me.CurrentAccion = Enums.Accion.Insertar Then
            LlenaPermisos(acod)
        ElseIf Me.CurrentAccion = Enums.Accion.Modificar Then
            'Dim _datap As CMDataSet.PERMISOS_USUARIODataTable = Me.PERMISOS_USUARIOTableAdapter.GetPermisoByUsuario(acod)
            'Dim i As Integer
            'For i = 0 To _datap.Rows.Count - 1
            '    _datap.Rows(i).Delete()
            'Next
            Me.PERMISOS_USUARIOTableAdapter.DeleteByUser(acod)
            Me.PERMISOS_USUARIOTableAdapter.Fill(CMDataSet.PERMISOS_USUARIO)
            LlenaPermisos(acod)
        End If
    End Sub

    Private Sub LlenaPermisos(ByVal acod As Integer)


        If rb_gastosninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Gastos", acod, 1)
        ElseIf rb_gastoslectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Gastos", acod, 2)
        ElseIf rb_gastostotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Gastos", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Gastos", acod, 4)
        End If



        If rb_medicosninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Medicos", acod, 1)
        ElseIf rb_medicoslectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Medicos", acod, 2)
        ElseIf rb_medicostotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Medicos", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Medicos", acod, 4)
        End If



        If rb_mutuasninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Mutuas", acod, 1)
        ElseIf rb_mutuaslectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Mutuas", acod, 2)
        ElseIf rb_mutuastotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Mutuas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Mutuas", acod, 4)
        End If



        If rb_proveedoresninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Proveedores", acod, 1)
        ElseIf rb_proveedoreslectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Proveedores", acod, 2)
        ElseIf rb_proveedorestotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Proveedores", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Proveedores", acod, 4)
        End If



        If rb_articuloninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Articulos", acod, 1)
        ElseIf rb_articulolectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Articulos", acod, 2)
        ElseIf rb_articulototal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Articulos", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Articulos", acod, 4)
        End If



        If rb_bancosninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Bancos", acod, 1)
        ElseIf rb_bancoslectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Bancos", acod, 2)
        ElseIf rb_bancostotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Bancos", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Bancos", acod, 4)
        End If



        If rb_pacientesninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Pacientes", acod, 1)
        ElseIf rb_pacienteslectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Pacientes", acod, 2)
        ElseIf rb_pacientestotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Pacientes", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Pacientes", acod, 4)
        End If



        If rb_empresasninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Empresas", acod, 1)
        ElseIf rb_empresaslectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Empresas", acod, 2)
        ElseIf rb_empresatotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Empresas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Empresas", acod, 4)
        End If



        If rb_facturaninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Facturas", acod, 1)
        ElseIf rb_facturalectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Facturas", acod, 2)
        ElseIf rb_facturatotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Facturas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Facturas", acod, 4)
        End If



        If rb_citaninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Citas", acod, 1)
        ElseIf rb_citalectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Citas", acod, 2)
        ElseIf rb_citatotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Citas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Citas", acod, 4)
        End If



        If rb_bajaninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Bajas", acod, 1)
        ElseIf rb_bajalectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Bajas", acod, 2)
        ElseIf rb_bajatotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Bajas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Bajas", acod, 4)
        End If


        If rb_asistninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Asistencia", acod, 1)
        ElseIf rb_asistlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Asistencia", acod, 2)
        ElseIf rb_asisttotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Asistencia", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Asistencia", acod, 4)
        End If



        If rb_analninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Analiticas", acod, 1)
        ElseIf rb_anallectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Analiticas", acod, 2)
        ElseIf rb_analtotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Analiticas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Analiticas", acod, 4)
        End If



        If rb_reciboninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Recibos", acod, 1)
        ElseIf rb_recibolectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Recibos", acod, 2)
        ElseIf rb_recibototal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Recibos", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Recibos", acod, 4)
        End If



        If rb_genrecninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Generar Recibos", acod, 1)
        ElseIf rb_genreclectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Generar Recibos", acod, 2)
        ElseIf rb_genrectotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Generar Recibos", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Generar Recibos", acod, 4)
        End If



        If rb_remninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Imprimir Remesas", acod, 1)
        ElseIf rb_remlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Imprimir Remesas", acod, 2)
        ElseIf rb_remtotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Imprimir Remesas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Imprimir Remesas", acod, 4)
        End If



        If rb_ficheroninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Ficheros", acod, 1)
        ElseIf rb_ficherolectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Ficheros", acod, 2)
        ElseIf rb_ficherototal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Ficheros", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Ficheros", acod, 4)
        End If



        If rb_revninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Rev. Comp.", acod, 1)
        ElseIf rb_revlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Rev. Comp.", acod, 2)
        ElseIf rb_revtotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Rev. Comp.", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Rev. Comp.", acod, 4)
        End If



        If rb_recetaninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Recetas", acod, 1)
        ElseIf rb_recetalectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Recetas", acod, 2)
        ElseIf rb_recetatotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Recetas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Recetas", acod, 4)
        End If



        If rb_histninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Historiales", acod, 1)
        ElseIf rb_histlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Historiales", acod, 2)
        ElseIf rb_histtotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Historiales", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Historiales", acod, 4)
        End If



        If rb_infoninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Info Primaria", acod, 1)
        ElseIf rb_infolectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Info Primaria", acod, 2)
        ElseIf rb_infototal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Info Primaria", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Info Primaria", acod, 4)
        End If



        If rb_alarmaninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Alarmas", acod, 1)
        ElseIf rb_alarmalectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Alarmas", acod, 2)
        ElseIf rb_alarmatotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Alarmas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Alarmas", acod, 4)
        End If



        If rb_diagnosticoninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Diagnostico", acod, 1)
        ElseIf rb_diagnosticolectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Diagnostico", acod, 2)
        ElseIf rb_diagnosticototal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Diagnostico", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Diagnostico", acod, 4)
        End If



        If rb_medninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Medicamentos", acod, 1)
        ElseIf rb_medlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Medicamentos", acod, 2)
        ElseIf rb_medtotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Medicamentos", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Medicamentos", acod, 4)
        End If



        If rb_indninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Indicaciones", acod, 1)
        ElseIf rb_indlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Indicaciones", acod, 2)
        ElseIf rb_indtotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Indicaciones", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Indicaciones", acod, 4)
        End If



        If rb_fpninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Formas Pago", acod, 1)
        ElseIf rb_fplectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Formas Pago", acod, 2)
        ElseIf rb_fptotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Formas Pago", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Formas Pago", acod, 4)
        End If



        If rb_paisninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Paises", acod, 1)
        ElseIf rb_paislectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Paises", acod, 2)
        ElseIf rb_paistotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Paises", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Paises", acod, 4)
        End If


        If rb_ptextninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantilla de Texto", acod, 1)
        ElseIf rb_ptextlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantilla de Texto", acod, 2)
        ElseIf rb_ptexttotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantilla de Texto", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantilla de Texto", acod, 4)
        End If



        If rb_conceptninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Conceptos", acod, 1)
        ElseIf rb_conceptlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Conceptos", acod, 2)
        ElseIf rb_concepttotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Conceptos", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Conceptos", acod, 4)
        End If



        If rb_panalninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantillas Analiticas", acod, 1)
        ElseIf rb_panallectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantillas Analiticas", acod, 2)
        ElseIf rb_panaltotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantillas Analiticas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantillas Analiticas", acod, 4)
        End If



        If rb_modninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Modelos", acod, 1)
        ElseIf rb_modlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Modelos", acod, 2)
        ElseIf rb_modtotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Modelos", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Modelos", acod, 4)
        End If



        If rb_phistninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantillas Historial", acod, 1)
        ElseIf rb_phistlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantillas Historial", acod, 2)
        ElseIf rb_phisttotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantillas Historial", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Plantillas Historial", acod, 4)
        End If



        If rb_clinicaninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Clinicas Externas", acod, 1)
        ElseIf rb_clinicalectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Clinicas Externas", acod, 2)
        ElseIf rb_clinicatotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Clinicas Externas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Clinicas Externas", acod, 4)
        End If



        If rb_confninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Configuracion", acod, 1)
        ElseIf rb_conflectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Configuracion", acod, 2)
        ElseIf rb_conftotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Configuracion", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Configuracion", acod, 4)
        End If



        If rb_copyninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Copia", acod, 1)
        ElseIf rb_copylectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Copia", acod, 2)
        ElseIf rb_copytotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Copia", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Copia", acod, 4)
        End If



        If rb_afactninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Anadir Factura", acod, 1)
        ElseIf rb_afactlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Anadir Factura", acod, 2)
        ElseIf rb_afacttotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Anadir Factura", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Anadir Factura", acod, 4)
        End If



        If rb_etiqninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Etiquetas", acod, 1)
        ElseIf rb_etiqlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Etiquetas", acod, 2)
        ElseIf rb_etiqtotal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Etiquetas", acod, 3)
        Else
            Me.PERMISOS_USUARIOTableAdapter.Insert("Etiquetas", acod, 4)
        End If



        If rb_lfacturaninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("LFacturas", acod, 1)
        ElseIf rb_lfacturalectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("LFacturas", acod, 2)

        End If



        If rb_lpartesninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("LPartes", acod, 1)
        ElseIf rb_lpartelectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("LPartes", acod, 2)

        End If



        If rb_lrecetaninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("LRecetas", acod, 1)
        ElseIf rb_lrecetalectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("LRecetas", acod, 2)
        End If



        If rb_lasistninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("LFaltas", acod, 1)
        ElseIf rb_lasistlectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("LFaltas", acod, 2)

        End If



        If rb_lcitasninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("LCitas", acod, 1)
        ElseIf rb_lcitalectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("LCitas", acod, 2)

        End If



        If rb_libroninguno.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Libro", acod, 1)
        ElseIf rb_librolectura.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Libro", acod, 2)
        ElseIf rb_librototal.Checked = True Then
            Me.PERMISOS_USUARIOTableAdapter.Insert("Libro", acod, 3)

        End If



    End Sub

    Private Sub form_user_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _cod As Integer
            If tb_cod.Text <> "" Then
                'Try
                _cod = Integer.Parse(tb_cod.Text.Trim())
                'Catch ex As Exception
                MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
                'End 'Try

                If _cod = 0 Then
                    MessageBox.Show("No puede utilizar ese codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Else
                MessageBox.Show("Debe utilizar un codigo.Utilice numeros enteros mayores que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim _name As String
            Dim _usuario As String = tb_user.Text.Trim()
            Dim _idmedico As Integer
            If tb_idmedico.Text <> "" Then
                _idmedico = Integer.Parse(tb_idmedico.Text.Trim())
                _name = GetMedico(_idmedico)
            Else
                _name = tb_nombre.Text.Trim()
            End If
            Dim _contrasena As String = tb_contrasena.Text.Trim()

            Dim _rcontrasena As String = tb_rcontrasena.Text.Trim()
            Dim _admin As String
            If chb_admin.Checked = True Then
                _admin = "S"
            Else : _admin = "N"
            End If
            If _rcontrasena <> _contrasena Then
                MessageBox.Show("La contraseña no coincide con su verificacion. Intentelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb_rcontrasena.Clear()
                tb_rcontrasena.Focus()
                Return
            End If
            If _cod.ToString() <> "" Then

                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.USUARIOSTableAdapter.UpdateValores(_cod, _usuario, _contrasena, "", _admin, _name, _idmedico, Date.Today(), certificadopath, fId)
                        Llena(_cod)
                    End If
                Else
                    If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Dim _datap As CMDataSet.USUARIOSDataTable = Me.USUARIOSTableAdapter.GetUserByUser(_usuario)
                        If _datap.Rows.Count = 0 Then
                            Dim _data As CMDataSet.USUARIOSDataTable = Me.USUARIOSTableAdapter.GetUserById(_cod)
                            If _data.Rows.Count = 0 Then
                                Me.USUARIOSTableAdapter.Insert(_cod, _usuario, _contrasena, "", _admin, _name, _idmedico, Date.Today(), certificadopath)
                                Llena(_cod)
                            Else
                                MessageBox.Show("Un usuario con ese login ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                tb_user.Clear()
                                Return
                            End If
                        End If
                    End If
                End If
                Me.USUARIOSTableAdapter.Fill(CMDataSet.USUARIOS)
                clickaccept = True
                Me.Close()
            Else
                MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If
    End Sub

    Private Sub chb_admin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_admin.CheckedChanged
        Dim i As Integer
        If chb_admin.Checked = True Then
            rb_gastostotal.Checked = True
            rb_medicostotal.Checked = True
            rb_librototal.Checked = True
            rb_lcitalectura.Checked = True
            rb_lasistlectura.Checked = True
            rb_lrecetalectura.Checked = True
            rb_lpartelectura.Checked = True
            rb_etiqtotal.Checked = True
            rb_lfacturalectura.Checked = True
            rb_afacttotal.Checked = True
            rb_copytotal.Checked = True
            rb_conftotal.Checked = True
            rb_conftotal.Checked = True
            rb_clinicatotal.Checked = True
            rb_phisttotal.Checked = True
            rb_modtotal.Checked = True
            rb_panaltotal.Checked = True
            rb_concepttotal.Checked = True
            rb_ptexttotal.Checked = True
            rb_paistotal.Checked = True
            rb_fptotal.Checked = True
            rb_indtotal.Checked = True
            rb_medtotal.Checked = True
            rb_diagnosticototal.Checked = True
            rb_alarmatotal.Checked = True
            rb_histtotal.Checked = True
            rb_infototal.Checked = True
            rb_recetatotal.Checked = True
            rb_revtotal.Checked = True
            rb_ficherototal.Checked = True
            rb_remtotal.Checked = True
            rb_genrectotal.Checked = True
            rb_recibototal.Checked = True
            rb_analtotal.Checked = True
            rb_asisttotal.Checked = True
            rb_bajatotal.Checked = True
            rb_citatotal.Checked = True
            rb_empresatotal.Checked = True
            rb_pacientestotal.Checked = True
            rb_facturatotal.Checked = True
            rb_bancostotal.Checked = True
            rb_articulototal.Checked = True
            rb_proveedorestotal.Checked = True
            rb_mutuastotal.Checked = True


            For i = 0 To Me.TabControl1.Controls.Count - 1
                Me.TabControl1.Controls(i).Enabled = False
            Next
        Else
            For i = 0 To Me.TabControl1.Controls.Count - 1
                Me.TabControl1.Controls(i).Enabled = True
            Next
        End If
    End Sub

    Private Sub tb_idmedico_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_idmedico.Leave
        If tb_idmedico.Text <> "" Then
            Dim _pcodo As Integer = Integer.Parse(tb_idmedico.Text)
            Dim data As CMDataSet.MEDICOSDataTable = MEDICOSTableAdapter.GetMedicoByID(_pcodo)
            If data.Rows.Count > 0 Then
                lb_medico.Text = GetMedico(_pcodo)
            Else
                tb_idmedico.Text = ""
                tb_idmedico.Focus()
                MessageBox.Show("No existe un médico con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class