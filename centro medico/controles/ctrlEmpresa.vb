Imports Microsoft.ApplicationBlocks.Data
Public Class ctrlEmpresa

    Public EMPRESA As CMDataSet.EMPRESASRow = Nothing
    Private table As CMDataSet.EMPRESASDataTable = New CMDataSet.EMPRESASDataTable()
    Private adapter As CMDataSetTableAdapters.EMPRESASTableAdapter = New CMDataSetTableAdapters.EMPRESASTableAdapter()

    Private _empresaPorDefecto = False
    Private _idpaciente As Nullable(Of Integer)

    Public Event EMPRESASeleccionado(ByVal IdEMPRESAS As Integer, ByVal IsReturnPressed As Boolean)
    Public Event EMPRESAEliminado(ByVal IdEMPRESASAnterior As Integer)
    Public Event EMPRESANoEncontrado()

#Region "Public Function NombreCompleto() As String"
    Public Function NombreCompleto() As String
        Dim nombre As String = "Seleccione EMPRESAS"
        If Not EMPRESA Is Nothing Then
            If Not EMPRESA.IsNOMBRENull Then
                nombre = EMPRESA.NOMBRE
            End If

        End If
        Return nombre
    End Function
#End Region

#Region "Private Sub CargarEMPRESAS(ByVal id As Integer)"
    Private Sub CargarEMPRESAS(ByVal id As Integer, ByVal IsReturnPressed As Boolean)
        Try
            table = adapter.GetEmpresaById(id)
            If table.Count > 0 Then
                EMPRESA = table(0)
                Muestra()
            Else
                txt_Nombre.Text = "EMPRESA no encontrada..."
                RaiseEvent EMPRESANoEncontrado()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando EMPRESAS")
        End Try
    End Sub
#End Region

#Region "Private Sub CargaEMPRESAS()"
    Private Sub CargaEMPRESAS(ByVal IsReturnPressed As Boolean)
        If txt_Codigo.Text.Length > 0 Then
            Try
                Dim id As Integer = txt_Codigo.Text
                CargarEMPRESAS(id, IsReturnPressed)
                Return
            Catch ex As Exception
                CargarEMPRESAS(-1, IsReturnPressed)
            End Try
        End If
    End Sub
#End Region

#Region " Private Sub Muestra()"
    Private Sub Muestra()

        Dim fullName As String = "Nombre es nulo!!"
        If Not EMPRESA.IsNOMBRENull Then
            fullName = EMPRESA.NOMBRE.Trim()
        End If

        If Not EMPRESA.IsEliminadoNull Then
            If EMPRESA.Eliminado = True Then
                fullName = "[ELIMINADA] " & fullName
            End If
        End If

        txt_Codigo.Text = EMPRESA.CEMPRESA
        txt_Nombre.Text = fullName
        'RaiseEvent EMPRESASeleccionado(EMPRESA.CEMPRESA, False)
    End Sub
#End Region

#Region "Public Property IDPACIENTE() As Nullable(Of Integer)"
    <System.ComponentModel.Browsable(True)> _
   Public Property IDPACIENTE() As Nullable(Of Integer)
        Get
            If _idpaciente.HasValue Then
                Return _idpaciente
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                _idpaciente = value
            End If
        End Set
    End Property
#End Region

    <System.ComponentModel.Browsable(True)> _
   Public Property ID_EMPRESAS() As Nullable(Of Integer)
        Get
            If EMPRESA Is Nothing Then
                Return Nothing
            Else
                Return EMPRESA.CEMPRESA
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarEMPRESAS(value, False)
            Else
                EMPRESA = Nothing
                txt_Nombre.Text = String.Empty
                txt_Codigo.Text = String.Empty
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
  Public Property EsEmpresaPorDefecto() As Boolean
        Get
            Return _empresaPorDefecto
        End Get
        Set(ByVal value As Boolean)
            _empresaPorDefecto = value
        End Set
    End Property


    Private Sub pb_SeleccionarEMPRESAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click

        If _empresaPorDefecto And IDPACIENTE.HasValue Then

            Dim context As New CMLinqDataContext()

            Dim linea As New LEMPRESA()
            linea.REFPACIENTE = IDPACIENTE
            linea.PUESTOTRABAJO = ""
            Dim frm As New frmEmpresa_Paciente()
            frm.LEMPRESABindingSource.DataSource = linea
            If frm.ShowDialog() = DialogResult.OK Then

                If Not Globales.Empresa_Existe(linea.REFEMPRESA, IDPACIENTE) Then
                    context.LEMPRESAs.InsertOnSubmit(linea)
                Else
                    'MessageBox.Show("La empresa seleccionada ya existe")
                    'Return
                End If
                
                context.SubmitChanges()
                If MessageBox.Show("Desea establecer esta empresa como la actual para el paciente ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Dim _aId As Integer = linea.REFEMPRESA
                    CargarEMPRESAS(_aId, False)
                End If
                RaiseEvent EMPRESASeleccionado(linea.REFEMPRESA, False)
            End If


            'Dim empresaAdapter As New CMDataSetTableAdapters.EMPRESASTableAdapter()
            'empresaAdapter.Fill(CMDataSet.EMPRESAS)

            'Dim _annadirEmpresa As form_pac_annadirempresa = New form_pac_annadirempresa("Ficha empresa - Añadir", Enums.Accion.Insertar, IDPACIENTE.Value, CMDataSet)
            '_annadirEmpresa.ShowInTaskbar = False
            '_annadirEmpresa.ShowDialog()
            'If _annadirEmpresa.IdEmpresa() <> -1 Then

            '    If Not Globales.Empresa_Existe(_annadirEmpresa.IdEmpresa(), IDPACIENTE.Value) Then
            '        Dim sqlparams(3) As SqlClient.SqlParameter
            '        sqlparams(0) = New SqlClient.SqlParameter("@REFEMPRESA", _annadirEmpresa.IdEmpresa)
            '        sqlparams(1) = New SqlClient.SqlParameter("@REFPACIENTE", IDPACIENTE.Value)
            '        sqlparams(2) = New SqlClient.SqlParameter("@FECHAALTA", Now.Date)
            '        sqlparams(3) = New SqlClient.SqlParameter("@PUESTOTRABAJO", _annadirEmpresa.PuestoTrabajo)
            '        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(My.Settings.CMConnectionString, CommandType.Text, "INSERT LEMPRESAS (REFPACIENTE,REFEMPRESA,FECHAALTA,PUESTOTRABAJO) VALUES (@REFPACIENTE,@REFEMPRESA,@FECHAALTA,@PUESTOTRABAJO)", sqlparams)
            '    End If

            '    If MessageBox.Show("Desea establecer esta empresa como la actual para el paciente ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            '        Dim _aId As Integer = _annadirEmpresa.IdEmpresa()
            '        'Dim PACIENTESTableAdapter As New CMDataSetTableAdapters.PACIENTESTableAdapter()
            '        'PACIENTESTableAdapter.UpdateEmpresa(_aId, IDPACIENTE)
            '        'CMDataSet.PACIENTES.FindByCPACIENTE(fId).REFEMPRESA() = _aId
            '        CargarEMPRESAS(_aId, False)

            '        'InicializaEmpresas()
            '    End If
            '    RaiseEvent EMPRESASeleccionado(_annadirEmpresa.IdEmpresa, False)
            'End If

        Else
            If Not _empresaPorDefecto And IDPACIENTE.HasValue Then
                'Me.EMPRESASTableAdapter.FillByPaciente(Me.CMDataSet.EMPRESAS, IDPACIENTE.Value)
                'Dim _name As String = "Listado de empresas"
                'Dim _listados As form_listados = New form_listados(_name, EMPRESASBindingSource, RoleManager.Items.Empresas, True)

                '_listados.ShowInTaskbar = False
                '_listados.ShowDialog()
                'If _listados.Selected() <> "" Then
                '    Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
                '    CargarEMPRESAS(_pcodo, False)
                '    RaiseEvent EMPRESASeleccionado(_pcodo, False)
                'End If
            Else

                Dim frm As New frmEmpresa()
                frm.Modo = Globales.ModoParaFormas.Seleccion
                If frm.ShowDialog = DialogResult.OK Then
                    CargarEMPRESAS(frm.Empresa.CEMPRESA, False)
                    RaiseEvent EMPRESASeleccionado(frm.Empresa.CEMPRESA, False)
                End If

                'Me.EMPRESASTableAdapter.Fill(Me.CMDataSet.EMPRESAS)
                'Dim _name As String = "Listado de empresas"
                'Dim _listados As form_listados = New form_listados(_name, EMPRESASBindingSource, RoleManager.Items.Empresas, True)
                '_listados.ShowInTaskbar = False
                '_listados.ShowDialog()
                'If _listados.Selected() <> "" Then
                '    Dim _pcodo As Integer = Integer.Parse(_listados.Selected())
                '    CargarEMPRESAS(_pcodo, False)
                '    RaiseEvent EMPRESASeleccionado(_pcodo, False)
                'End If
            End If

        End If

    End Sub

    Private Sub txt_Codigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (txt_Codigo.Text.Length > 0) Then
            e.Handled = True
            Try
                Dim id As Integer = Integer.Parse(txt_Codigo.Text)
                CargarEMPRESAS(id, True)
                RaiseEvent EMPRESASeleccionado(id, False)
            Catch ex As Exception
                Globales.ErrorMsg(ex, "Error al cargar Empresa")
            End Try
        End If
    End Sub

    Private Sub txt_Codigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Codigo.Leave
        CargaEMPRESAS(False)
        If IsNumeric(txt_Codigo.Text) Then RaiseEvent EMPRESASeleccionado(txt_Codigo.Text, False)
    End Sub

    Public Sub btn_Deseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deseleccionar.Click

        Dim oldValue As Nullable(Of Integer) = Nothing
        If Me.ID_EMPRESAS.HasValue Then
            oldValue = Me.ID_EMPRESAS
        End If

        Me.ID_EMPRESAS = Nothing
        Me.EMPRESA = Nothing
        Me.txt_Codigo.Text = String.Empty
        Me.txt_Nombre.Text = "Seleccione empresa"
        If oldValue.HasValue Then
            RaiseEvent EMPRESAEliminado(oldValue)
        End If
    End Sub

End Class