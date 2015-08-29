Imports System.IO
Public Class form_plantilla_texto
    Dim fcurrentAcc As Integer
    Dim fId As Integer
    Dim clickaccept As Boolean = False
    Dim fsecciono As String
    Dim fsecciontexto As String
    Dim ftextoo As String
    Dim fdescripciono As String
    Dim fnomencladores As String() = {"GN", "HM", "HA", "HH", "HE", "HP", "HJ", "HT", "HO", "RC"}
    Dim fseccionarray As String() = {"General", "Historial-Motivo de consulta", "Historial-Antecedentes ", "Historial-Historial", "Historial-Exploración", "Historial-Pruebas complementarias", "Historial-Juicio clínico", " Historial-Tratamiento", "Historial-Observaciones", "Recetas"}

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

    Private Sub Inicializa()
        Dim _data As CMDataSet.PLANTILLASDataTable = Me.PLANTILLASTableAdapter.GetPlantillaById(fId)
        fsecciono = _data.Rows(0).Item("SECCION").ToString()
        ftextoo = _data.Rows(0).Item("TEXTO").ToString()
        fdescripciono = _data.Rows(0).Item("DESCRIPCION").ToString()


        Dim rtf As New RichTextBox()
        Try
            rtf.Rtf = ftextoo
            ftextoo = rtf.Text
        Catch ex As Exception
            'rtf.Text = ftextoo
        End Try

        tb_text.Text = ftextoo
        tb_descripc.Text = fdescripciono.ToString()
        Dim _index As Integer
        _index = Array.IndexOf(fnomencladores, fsecciono)
        If _index <> -1 Then
            fsecciontexto = fseccionarray(_index)
        End If
        cb_seccion.Text = fsecciontexto


    End Sub
    Private Sub PLANTILLASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PLANTILLASBindingSource.EndEdit()
        Me.PLANTILLASTableAdapter.Update(Me.CMDataSet.PLANTILLAS)

    End Sub

    Private Sub form_plantilla_texto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_text.ReadOnly = True
            tb_descripc.ReadOnly = True
            cb_seccion.Enabled = False
            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"

        End If

    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_plantilla_texto_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _texto As String = tb_text.Text.Trim()
            Dim _descripcion As String = tb_descripc.Text.Trim()
            Dim _secciontext As String = cb_seccion.Text.Trim()
            Dim _seccion As String
            Dim _index As Integer
            _index = Array.IndexOf(fseccionarray, _secciontext)
            If _index <> -1 Then
                _seccion = fnomencladores(_index)
            End If

            If Me.CurrentAccion = Enums.Accion.Modificar Then
                If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.PLANTILLASTableAdapter.UpdateValores(_descripcion, _seccion, _texto, fId)
                End If
            Else
                If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.PLANTILLASTableAdapter.Insert(NuevoId, _descripcion, _seccion, _texto)

                End If
            End If
            Me.PLANTILLASTableAdapter.Fill(CMDataSet.PLANTILLAS)

        End If
    End Sub
    Private Function NuevoId() As Integer
        Dim id As Integer = 1
        If Me.PLANTILLASTableAdapter.MaxCodigoId.HasValue Then
            id = Me.PLANTILLASTableAdapter.MaxCodigoId
            id += 1
        End If
        Return id
    End Function
    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _texto As String = tb_text.Text.Trim()
            Dim _descripcion As String = tb_descripc.Text.Trim()
            Dim _secciontext As String = cb_seccion.Text.Trim()
            Dim _seccion As String
            Dim _index As Integer
            _index = Array.IndexOf(fseccionarray, _secciontext)
            If _index <> -1 Then
                _seccion = fnomencladores(_index)
            End If
            If _seccion Is Nothing Then
                _seccion = ""
            End If
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                Me.PLANTILLASTableAdapter.UpdateValores(_descripcion, _seccion, _texto, fId)

            Else : Me.PLANTILLASTableAdapter.Insert(NuevoId, _descripcion, _seccion, _texto)
            End If
            Me.PLANTILLASTableAdapter.Fill(CMDataSet.PLANTILLAS)
            clickaccept = True
            Me.Close()
        End If
    End Sub

    Private Sub bt_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_open.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim _doc As String = OpenFileDialog1.FileName
            Dim _Sr As StreamReader = New StreamReader(_doc)
            Dim _texto As String = _Sr.ReadToEnd()
            tb_text.Text = _texto.Trim()
        End If
    End Sub
End Class