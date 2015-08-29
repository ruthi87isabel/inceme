Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms


Public Class ctrlCliente

    Public Cliente As CMDataSet.PACIENTESRow = Nothing
    Public Event ClienteSeleccionado()
    Private table As CMDataSet.PacientesDataTable = New CMDataSet.PacientesDataTable()
    Private adapter As CMDataSetTableAdapters.PACIENTESTableAdapter = New CMDataSetTableAdapters.PACIENTESTableAdapter()

    Private Sub CargarCliente(ByVal id As Integer)
        Try
            adapter.FillPacienteById(table, id)
            If table.Count > 0 Then
                Cliente = table(0)
                Muestra()
            End If
        Catch ex As Exception
            Globales.ErrorMsg(ex, "Error cargando cliente")
        End Try
    End Sub

    Private Sub Muestra()
        If Not Cliente.IsNOMBRENull Then
            txt_Cliente.Text = "(" & Cliente.CPACIENTE & ") - " & Cliente.NOMBRE
        End If
        If Not Cliente.IsAPELLIDO1Null Then
            txt_Cliente.Text += " " & Cliente.APELLIDO1
        End If
        If Not Cliente.IsAPELLIDO2Null Then
            txt_Cliente.Text += " " & Cliente.APELLIDO2
        End If

        'txt_Cliente.Text = "(" & Cliente.CPACIENTE & ") - " & Cliente.NOMBRE & " " & Cliente.APELLIDO1 & " " & Cliente.APELLIDO2
    End Sub

    <Browsable(True)> _
    Public Property ID_Cliente() As Nullable(Of Integer)
        Get
            If Cliente Is Nothing Then
                Return Nothing
            Else
                Return Cliente.CPACIENTE
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                CargarCliente(value)
            Else
                txt_Cliente.Text = "Cliente No definido."
            End If
        End Set
    End Property

    Private Sub pb_SeleccionarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SeleccionarCliente.Click
        Me.PACIENTESTableAdapter.Fill(Me.CMDataSet.PACIENTES)
        Dim frm As New form_listados("Selecciones un Cliente / Paciente", Me.PacienteBindingSource, RoleManager.Items.Pacientes, True)
        frm.ShowDialog()
        If Not frm.Selected Is Nothing Then
            If frm.Selected.Trim.Length > 0 Then
                CargarCliente(frm.Selected)
                ID_Cliente = Cliente.CPACIENTE
                RaiseEvent ClienteSeleccionado()
            End If
        End If
        '    Dim frm As frmClientes = New frmClientes()
        '    frm.Modo = Globals.ModoParaFormas.Seleccion
        '    If frm.ShowDialog() = DialogResult.OK Then
        '        CargarCliente(frm.Cliente.ID_Cliente)
        '        ID_Cliente = Cliente.ID_Cliente
        '    End If
    End Sub

   
End Class
