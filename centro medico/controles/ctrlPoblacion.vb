Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Public Class ctrlPoblacion
    Public Poblacion As N_Poblacione = Nothing
    Public Context As New CMLinqDataContext
    'Public Poblaciones As New List(Of N_Poblacione)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'Poblaciones = ().ToList()

        NPoblacioneBindingSource.DataSource = From p As N_Poblacione In Context.N_Poblaciones Select p Order By Name Ascending

    End Sub

    'Private Sub CargarPoblacion(ByVal id As Integer)
    '    Try
    '        adapter.FillByID_Poblacion(table, id)
    '        If table.Count > 0 Then
    '            Poblacion = table(0)
    '            Muestra()
    '        End If
    '    Catch ex As Exception
    '        Globales.ErrorMsg(ex, "Error cargando poblacion")
    '    End Try
    'End Sub

    'Private Sub Muestra()
    '    'txt_Poblacion.Text = Poblacion.Nombre & ", " & Poblacion.Provincia
    'End Sub

    <Browsable(True)> _
    Public Property ID_Poblacion() As Nullable(Of Integer)
        Get
            'If Poblacion Is Nothing Then
            '    Return Nothing
            'Else
            '    Return Poblacion.ID_Poblacion
            'End If
            If Not NPoblacioneBindingSource.Current Is Nothing Then
                Return NPoblacioneBindingSource.Current.ID_Poblacion
            Else
                Return Nothing
            End If

        End Get
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                UiComboBox1.SelectedValue = value
                'NPoblacioneBindingSource.Position = NPoblacioneBindingSource.Find("ID_Poblacion", value)
            End If
        End Set
    End Property


    'Private Sub pb_SeleccionarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As frmPoblaciones = New frmPoblaciones()
    '    If frm.ShowDialog() = DialogResult.OK Then
    '        CargarPoblacion(frm.Poblacion.ID_Poblacion)
    '        ID_Poblacion = Poblacion.ID_Poblacion
    '    End If
    'End Sub

    Private Sub btn_Deseleccionar_Click(sender As System.Object, e As System.EventArgs)
        'NPoblacioneBindingSource.Current = Nothing
    End Sub

    Private Sub ctrlPoblacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub UiComboBox1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles UiComboBox1.KeyUp
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            'Me.SelectNextControl(Me, True, False, False, True)
            'Me.UiComboBox1.SelectedItem = Me.UiComboBox1.SelectedItem
            'Me.UiComboBox1.SelectNextControl(Me, True, False, False, False)
            'e.Handled = True
        End If
    End Sub
End Class
