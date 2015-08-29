Imports centro_medico.UI.Citas

Public Class frmPacienteMain

    Public IdPaciente As Nullable(Of Integer)
    Public Paciente As PACIENTE
    Public WithEvents Context As New CMLinqDataContext()

    Private Sub frmPacienteMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaPaciente()
    End Sub

    Public Sub CargaPaciente()

        If IdPaciente.HasValue Then
            If Paciente Is Nothing Then
                Paciente = (From p In context.PACIENTEs _
                    Where p.CPACIENTE = IdPaciente _
                    Select p).SingleOrDefault()
            End If
        End If

        If Paciente Is Nothing Then
            MessageBox.Show("Este paciente no existe!")
            Me.Close()
            Return
        End If

        PACIENTEBindingSource.DataSource = Paciente

        If Not Paciente.FECHAN Is Nothing Then
            txtEdad.Text = (DateTime.Now - Paciente.FECHAN).Value.TotalDays \ 365
        End If
        'tsbGuardar.Visible = True
    End Sub

    Private Sub bt_DatosPersonales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_DatosPersonales.Click
        'Dim frm As New frmPaciente_Editar()
        'frm.Paciente = Paciente
        'frm.PACIENTEBindingSource.DataSource = Me.PACIENTEBindingSource.DataSource
        'frm.StartPosition = FormStartPosition.Manual
        'frm.Location = New Point(170, 130)
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub bt_FormaPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_FormaPago.Click
        Dim frm As New frmPaciente_FormasPago()
        frm.PACIENTEBindingSource.DataSource = Me.PACIENTEBindingSource.DataSource
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(170, 130)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsbGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Me.Validate()
        PACIENTEBindingSource.EndEdit()
        context.SubmitChanges()
    End Sub


    Private Sub bt_Citas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Citas.Click
        Dim frm As New frmCalendarioCitas()
        frm.IdPaciente = Paciente.CPACIENTE
        frm.ShowDialog()
    End Sub

    Private Sub bt_Facturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Facturas.Click
        Dim frm As New frmFacturasM()
        frm.IDPacienteToFilter = Paciente.CPACIENTE
        'frm.FACTURABindingSource.DataSource = Paciente.FACTURAs
        frm.ShowDialog()
    End Sub

    
End Class