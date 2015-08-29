Imports System.IO
Public Class form_plantilla_historial
    Dim fcurrentAcc As Integer
    Dim fId As String
    Dim clickaccept As Boolean = False
    Dim fmotivoo As String
    Dim fantecedenteso As String
    Dim fexploraciono As String
    Dim fcomplementariaso As String
    Dim fjuicioo As String
    Dim ftratamientoo As String
    Dim fhistorialo As String
    Dim fcomentarioso As String
    Dim fotroso As String
    Dim fdescripciono As String

    Private Sub PLANTILLA_HISTORIALESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PLANTILLA_HISTORIALESBindingSource.EndEdit()
        Me.PLANTILLA_HISTORIALESTableAdapter.Update(Me.CMDataSet.PLANTILLA_HISTORIALES)

    End Sub
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CurrentAccion = aCurrentAccion
        Me.Text = aName


    End Sub
    Sub New(ByVal aName As String, ByVal aCurrentAccion As Enums.Accion, ByVal aId As String)

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
        Dim _data As CMDataSet.PLANTILLA_HISTORIALESDataTable = Me.PLANTILLA_HISTORIALESTableAdapter.GetPlantillaById(fId)
        fmotivoo = _data.Rows(0).Item("MOTIVO").ToString()
        fantecedenteso = _data.Rows(0).Item("ANTECEDENTES").ToString()
        fdescripciono = _data.Rows(0).Item("DESCRIPCION").ToString()
        fcomentarioso = _data.Rows(0).Item("COMENTARIOS").ToString()
        fotroso = _data.Rows(0).Item("OTROS").ToString()
        ftratamientoo = _data.Rows(0).Item("TRATAMIENTO").ToString()
        fhistorialo = _data.Rows(0).Item("HISTORIAL").ToString()
        fcomplementariaso = _data.Rows(0).Item("COMPLEMENTARIAS").ToString()
        fexploraciono = _data.Rows(0).Item("EXPLORACION").ToString()
        fjuicioo = _data.Rows(0).Item("JUICIO").ToString()

        tb_codigo.Text = fId
        tb_descripcion.Text = fdescripciono
        tc_motivo.ControlText = fmotivoo
        tc_antecedentes.ControlText = fantecedenteso
        tc_exploracion.ControlText = fexploraciono
        tc_observaciones.ControlText = fotroso
        tc_tratamiento.ControlText = ftratamientoo
        tc_historial.ControlText = fhistorialo
        tc_pruebas.ControlText = fcomplementariaso
        tc_notas.ControlText = fcomentarioso
        tc_hipotesis.ControlText = fjuicioo



    End Sub

    Private Sub form_plantilla_historial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim array As String() = {Globales.Configuracion.histcampo1, Globales.Configuracion.histcampo2, Globales.Configuracion.histcampo3, Globales.Configuracion.histcampo4, Globales.Configuracion.histcampo5, Globales.Configuracion.histcampo6, Globales.Configuracion.histcampo7, Globales.Configuracion.histcampo8, Globales.Configuracion.histcampo9}
        For i = 0 To Me.tab_historial.TabPages.Count - 1
            Me.tab_historial.TabPages(i).Text = array(i)
        Next
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then
            Inicializa()
            tb_codigo.ReadOnly = True
            tb_descripcion.ReadOnly = True
            tc_motivo.Enabled = False
            tc_antecedentes.Enabled = False
            tc_exploracion.Enabled = False
            tc_observaciones.Enabled = False
            tc_tratamiento.Enabled = False
            tc_historial.Enabled = False
            tc_pruebas.Enabled = False
            tc_notas.Enabled = False
            tc_hipotesis.Enabled = False
            bt_aceptar.Hide()
            bt_cancel.Text = "Cerrar"

        End If

    End Sub

   
    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        clickaccept = True
        Me.Close()
    End Sub

    Private Sub form_plantilla_historial_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If clickaccept = False And Not Me.CurrentAccion = Enums.Accion.Ver Then

            Dim _cod As String = tb_codigo.Text.Trim()
            Dim _descripcion As String = tb_descripcion.Text.Trim()
            Dim _motivo As String = tc_motivo.ControlText
            Dim _antecedentes As String = tc_antecedentes.ControlText
            Dim _exploracion As String = tc_exploracion.ControlText
            Dim _juicio As String = tc_hipotesis.ControlText
            Dim _complementarias As String = tc_pruebas.ControlText
            Dim _comentarios As String = tc_notas.ControlText
            Dim _otros As String = tc_observaciones.ControlText
            Dim _historial As String = tc_historial.ControlText
            Dim _tratamiento As String = tc_tratamiento.ControlText
            If _cod <> "" Then
                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    If MessageBox.Show("Esta seguro que desea modificar los datos ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.PLANTILLA_HISTORIALESTableAdapter.Update(_cod, _motivo, _antecedentes, _exploracion, _complementarias, _juicio, _tratamiento, _historial, _comentarios, _otros, _descripcion, fId)
                    End If
                Else
                    If MessageBox.Show("Esta seguro que desea insertar los datos ", "Insertar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        Me.PLANTILLA_HISTORIALESTableAdapter.Insert(_cod, _motivo, _antecedentes, _exploracion, _complementarias, _juicio, _tratamiento, _historial, _comentarios, _otros, _descripcion)

                    End If
                End If
                Me.PLANTILLA_HISTORIALESTableAdapter.Fill(CMDataSet.PLANTILLA_HISTORIALES)
            Else : MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If Not Me.CurrentAccion = Enums.Accion.Ver Then
            Dim _cod As String = tb_codigo.Text.Trim()
            Dim _descripcion As String = tb_descripcion.Text.Trim()
            Dim _motivo As String = tc_motivo.ControlText
            Dim _antecedentes As String = tc_antecedentes.ControlText
            Dim _exploracion As String = tc_exploracion.ControlText
            Dim _juicio As String = tc_hipotesis.ControlText
            Dim _complementarias As String = tc_pruebas.ControlText
            Dim _comentarios As String = tc_notas.ControlText
            Dim _otros As String = tc_observaciones.ControlText
            Dim _historial As String = tc_historial.ControlText
            Dim _tratamiento As String = tc_tratamiento.ControlText
            If _cod <> "" Then
                If Me.CurrentAccion = Enums.Accion.Modificar Then
                    Me.PLANTILLA_HISTORIALESTableAdapter.Update(_cod, _motivo, _antecedentes, _exploracion, _complementarias, _juicio, _tratamiento, _historial, _comentarios, _otros, _descripcion, fId)
                Else : Me.PLANTILLA_HISTORIALESTableAdapter.Insert(_cod, _motivo, _antecedentes, _exploracion, _complementarias, _juicio, _tratamiento, _historial, _comentarios, _otros, _descripcion)
                End If
                Me.PLANTILLA_HISTORIALESTableAdapter.Fill(CMDataSet.PLANTILLA_HISTORIALES)
                clickaccept = True
                Me.Close()
            Else : MessageBox.Show("Debe tener un codigo para poder ser definido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class