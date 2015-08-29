Public Class frmMigrarPacientes
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
       
    End Sub
    
    Public Sub migrar()
        Dim res As Boolean = False
        Dim bajaPaciente As Boolean = Me.chkEliminarPaciente.Checked
        If Not Me.CtrlPaciente1.Paciente Is Nothing And Not CtrlPaciente2.Paciente Is Nothing Then
            Dim codigoOrigen As Integer = CtrlPaciente1.Paciente.CPACIENTE
            Dim codigoDestino As Integer = CtrlPaciente2.Paciente.CPACIENTE
            res = PacienteManager.migrarPaciente(codigoOrigen, codigoDestino, bajaPaciente)
        End If
        If res Then
            MsgBox("Migración completada")
            Me.Close()
        Else
            MsgBox("No se completó la migración")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        migrar()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub
    Private Sub cerrar(sender As Object, e As EventArgs) Handles Me.FormClosed
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub frmMigrarPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.MigrarPacientes) <> RoleManager.TipoPermisos.Total Then
            MsgBox("No tiene permisos para usar esta parte del programa")
            Me.Close()
        End If
    End Sub
End Class