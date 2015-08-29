Public Class form_filtro_avanzado
    Dim fwhere As String = ""
    Dim fName As List(Of String) = New List(Of String)
    Dim fDBName As List(Of String) = New List(Of String)
    Dim fType As List(Of Type) = New List(Of Type)

    Dim aproximada As String = "N"
    Dim table As String

    Sub New(ByVal aName As List(Of String), ByVal aDBName As List(Of String), ByVal aType As List(Of Type), ByVal atable As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        fName = aName
        fDBName = aDBName
        fType = aType

        table = atable
    End Sub

    Private Sub bt_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel.Click
        Me.Close()
    End Sub

    Public ReadOnly Property Where() As String
        Get
            Return fwhere
        End Get
    End Property

    Private Sub form_filtro_avanzado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Carga()
    End Sub

    Private Sub Save()
        fwhere = ""
        Dim i As Integer
        For i = 0 To fName.Count - 1
            If fType(i).Name <> Type.GetType("System.DateTime").Name Then
                Dim index As Integer = Me.panel_filtros.Controls.IndexOfKey("tb_" + fName(i))
                If index <> -1 Then
                    If Me.panel_filtros.Controls(index).Text <> "" Then
                        If fType(i).Name = Type.GetType("System.String").Name Then
                            Dim _valor As String = Me.panel_filtros.Controls(index).Text
                            Dim indice As Integer = Me.panel_filtros.Controls.IndexOfKey("chb_" + fName(i))
                            Dim aprox As Boolean = False
                            If indice <> -1 Then
                                Dim check As CheckBox = Me.panel_filtros.Controls(indice)
                                If check.Checked = True Then
                                    aprox = True
                                End If
                            End If
                            If Where <> "" Then
                                If aprox = True Then
                                    fwhere = fwhere + "And (" + fDBName.Item(i) + " Like '%" + _valor.ToString() + "%') "
                                Else
                                    fwhere = fwhere + "And (" + fDBName.Item(i) + " Like '" + _valor.ToString() + "%') "
                                End If
                            Else
                                If aprox = True Then
                                    fwhere = " Where (" + fDBName.Item(i) + " Like '%" + _valor.ToString() + "%') "
                                Else
                                    fwhere = " Where (" + fDBName.Item(i) + " Like '" + _valor.ToString() + "%') "
                                End If
                            End If

                        ElseIf fType(i).Name = Type.GetType("System.Int32").Name Then
                            Dim _valor As Integer
                            'Try
                            _valor = Integer.Parse(Me.panel_filtros.Controls(index).Text)
                            'Catch ex As Exception
                            ' MessageBox.Show("El valor de el campo " + fName(i) + " debe ser de tipo entero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'End 'Try
                            If fwhere <> "" Then
                                fwhere = fwhere + "And (" + fDBName.Item(i) + " = " + _valor.ToString() + ") "
                            Else
                                fwhere = " Where (" + fDBName.Item(i) + " = " + _valor.ToString() + ") "
                            End If

                        ElseIf fType(i).Name = Type.GetType("System.Decimal").Name Then
                            Dim _valor As Decimal
                            'Try
                            _valor = Decimal.Parse(Me.panel_filtros.Controls(index).Text)
                            'Catch ex As Exception
                            ' MessageBox.Show("El valor de el campo " + fName(i) + " debe ser de tipo decimal", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'End 'Try
                            If fwhere <> "" Then
                                fwhere = fwhere + "And (" + fDBName.Item(i) + " = " + _valor.ToString().Replace(",", ".") + ") "
                            Else
                                fwhere = " Where (" + fDBName.Item(i) + " = " + _valor.ToString().Replace(",", ".") + ") "
                            End If
                        End If

                    End If
                End If
            End If
        Next
    End Sub

    Private Sub VerificaAprox()
        Select Case Me.table
            Case "Médicos"

                aproximada = Globales.Configuracion.medaprox
            Case "Mutuas"

                aproximada = Globales.Configuracion.mutuaaprox
            Case "Formas_Pago"
                aproximada = Globales.Configuracion.formaaprox

            Case "Proveedores"

                aproximada = Globales.Configuracion.proveedoraprox
            Case "Bancos"
                aproximada = Globales.Configuracion.bancoaprox

            Case "Conceptos_Facturables"
                aproximada = Globales.Configuracion.conceptoaprox

            Case "Paises"
                aproximada = Globales.Configuracion.paisesaprox

            Case "Conceptos_Analiticas"

                aproximada = Globales.Configuracion.conceptanalaprox
            Case "Derivaciones_Destinos"
                aproximada = Globales.Configuracion.derivacionesaprox
            Case "Alarma"
                aproximada = Globales.Configuracion.alarmaaprox

            Case "Articulos"
                aproximada = Globales.Configuracion.articuloaprox

            Case "Medicamentos"
                aproximada = Globales.Configuracion.medicamentoaprox
            Case "Plantilla_Texto"

                aproximada = Globales.Configuracion.platillatextoaprox

            Case "Diagnostico"
                aproximada = Globales.Configuracion.diagnosticoaprox

            Case "Gastos"
                aproximada = Globales.Configuracion.gastosaprox

            Case "Indicaciones"
                aproximada = Globales.Configuracion.indicacionesaprox
            Case "Plantilla_Historial"
                aproximada = Globales.Configuracion.historialaprox

            Case "Partes"
                aproximada = Globales.Configuracion.asistaprox

            Case "Empresas"
                aproximada = Globales.Configuracion.empaprox

            Case "RoleManager.Items.Pacientes"
                aproximada = Globales.Configuracion.pacaprox

            Case "Facturas"

                aproximada = Globales.Configuracion.facturasaprox
            Case "Analiticas"
                aproximada = Globales.Configuracion.analaprox

            Case "Plantillas_Analiticas"
                aproximada = Globales.Configuracion.plantillaanalaprox
            Case "Usuarios"
                aproximada = Globales.Configuracion.usuarioaprox

            Case "Modelo_Revisiones_Comparativas"
                aproximada = Globales.Configuracion.revaprox
            Case "Recibos"
                aproximada = Globales.Configuracion.recibosaprox
        End Select
    End Sub

    Private Sub Carga()
        VerificaAprox()
        Dim i As Integer
        Dim cant As Integer
        For i = 0 To fName.Count - 1
            If fType(i).Name <> Type.GetType("System.DateTime").Name Then

                Dim _label As Label = New Label()
                _label.Text = fName(i)
                _label.Name = "label_" + fName(i)
                _label.Height = 15
                _label.Width = 150
                panel_filtros.Controls.Add(_label)
                _label.Location = New Point(5, 40 * cant + 5)

                Dim _textbox As TextBox = New TextBox()
                _textbox.Name = "tb_" + fName(i)
                _textbox.Height = 20
                _textbox.Width = 150
                panel_filtros.Controls.Add(_textbox)
                _textbox.Location = New Point(5, 40 * cant + 20)

                If fType(i).Name = Type.GetType("System.String").Name Then
                    Dim _checkbox As New CheckBox()
                    _checkbox.Name = "chb_" + fName(i)
                    _checkbox.Height = 20
                    _checkbox.Width = 60
                    _checkbox.Text = "Aprox"
                    If aproximada = "S" Then
                        _checkbox.Checked = True
                    Else
                        _checkbox.Checked = False
                    End If
                    panel_filtros.Controls.Add(_checkbox)
                    _checkbox.Location = New Point(180, 40 * cant + 20)
                End If
                cant = cant + 1
            End If
        Next
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Save()
    End Sub
End Class