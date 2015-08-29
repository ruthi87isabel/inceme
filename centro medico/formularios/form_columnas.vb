Imports System.IO
Imports System.Xml

Public Class form_columnas
    Dim currentlistar As Integer
    Dim columnas As New ArrayList()

  
    Public Property CurrentList() As RoleManager.Items

        ' la parte Get es la que devuelve el valor de la propiedad
        Get
            Return currentlistar

        End Get
        ' la parte Set es la que se usa al asignar el nuevo valor
        Set(ByVal Value As RoleManager.Items)
            currentlistar = Value
        End Set
    End Property
    Sub VerificaXML(ByVal aTable As String)
        Dim posx As Integer = 0
        Dim posy As Integer = 0
        Columnas1.Controls.Clear()

        Dim dir As String = Application.StartupPath()
        Dim di As DirectoryInfo = Directory.GetParent(dir)
        Dim dip As DirectoryInfo = di.Parent
        Dim direccion As String = dip.FullName
        Dim _reader As XmlReader = New XmlTextReader(dir + "\\Config\\componente.xml")
        While _reader.Read = True
            If _reader.Name = "TABLA" Then
                Dim tabla As String = _reader.GetAttribute("Name")
                If aTable = tabla Then
                    Dim headerlistv As New List(Of String)
                    Dim posListv As New List(Of Integer)
                    Dim headerlistf As New List(Of String)
                    Dim posListf As New List(Of Integer)
                    While _reader.Read And _reader.Name <> "TABLA"
                        If _reader.Name <> "" Then
                            Dim Visible As String = _reader.GetAttribute("Visible")
                            Dim columname As String = _reader.GetAttribute("FieldName")
                            Dim pos As Integer = Integer.Parse(_reader.GetAttribute("Posicion"))
                            Dim ancho As Integer = Integer.Parse(_reader.GetAttribute("Ancho"))
                            Dim header As String = _reader.GetAttribute("Campo")
                            Dim posfilt As Integer = Integer.Parse(_reader.GetAttribute("PosicionOrden"))

                            If Visible = "TRUE" And posfilt <> -1 Then
                                Dim x As New columna_simple(header, True, True)
                                AddHandler x.VisibleChecked, AddressOf Columnas1.Visible_Change
                                AddHandler x.FiltradoChecked, AddressOf Columnas1.Filter_Change
                                Columnas1.Controls.Add(x)
                                If pos <= ordenar_visibles.lbx_columnas.Items.Count Then
                                    ordenar_visibles.lbx_columnas.Items.Insert(pos, header)
                                Else
                                    headerlistv.Add(header)
                                    posListv.Add(pos)
                                End If
                                If posfilt <= ordenar_filtros.lbx_columnas.Items.Count Then
                                    ordenar_filtros.lbx_columnas.Items.Insert(posfilt, header)
                                Else
                                    headerlistf.Add(header)
                                    posListf.Add(posfilt)
                                End If

                            ElseIf Visible = "TRUE" Then
                                Dim x As New columna_simple(header, True, False)
                                AddHandler x.VisibleChecked, AddressOf Columnas1.Visible_Change
                                AddHandler x.FiltradoChecked, AddressOf Columnas1.Filter_Change
                                Columnas1.Controls.Add(x)
                                If pos <= ordenar_visibles.lbx_columnas.Items.Count Then
                                    ordenar_visibles.lbx_columnas.Items.Insert(pos, header)
                                Else
                                    headerlistv.Add(header)
                                    posListv.Add(pos)
                                End If

                            ElseIf posfilt <> -1 Then
                                Dim x As New columna_simple(header, False, True)
                                AddHandler x.VisibleChecked, AddressOf Columnas1.Visible_Change
                                AddHandler x.FiltradoChecked, AddressOf Columnas1.Filter_Change
                                Columnas1.Controls.Add(x)
                                If posfilt <= ordenar_filtros.lbx_columnas.Items.Count Then
                                    ordenar_filtros.lbx_columnas.Items.Insert(posfilt, header)
                                Else
                                    headerlistf.Add(header)
                                    posListf.Add(posfilt)
                                End If

                            Else
                                Dim x As New columna_simple(header, False, False)
                                AddHandler x.VisibleChecked, AddressOf Columnas1.Visible_Change
                                AddHandler x.FiltradoChecked, AddressOf Columnas1.Filter_Change
                                Columnas1.Controls.Add(x)

                            End If

                            Columnas1.Controls(Columnas1.Controls.Count - 1).Location = New Point(posx, posy)
                            posy = posy + 30
                        End If
                    End While
                    Dim headerv As String() = headerlistv.ToArray()
                    Dim headerf As String() = headerlistf.ToArray()
                    Dim posv As Integer() = posListv.ToArray()
                    Dim posf As Integer() = posListf.ToArray()
                    Array.Sort(posv, headerv)
                    Array.Sort(posf, headerf)
                    Dim i As Integer
                    For i = 0 To posv.Length - 1
                        ordenar_visibles.lbx_columnas.Items.Insert(posv(i), headerv(i))
                    Next
                    For i = 0 To posf.Length - 1
                        ordenar_filtros.lbx_columnas.Items.Insert(posf(i), headerf(i))
                    Next
                    Return
                End If
            End If
        End While
    End Sub
    Sub New(ByVal aconfig As Configuracion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Public ReadOnly Property VisibleControl() As ordenar_columnas
        Get
            Return ordenar_visibles
        End Get
    End Property
    Public ReadOnly Property FiltrarControl() As ordenar_columnas
        Get
            Return ordenar_filtros
        End Get
    End Property
    Private Sub form_columnas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ordenar_visibles.lb_titulo.Text = "Visibles"
        ordenar_filtros.lb_titulo.Text = "Filtro/Orden"
        ordenar_filtros.NombresColumnas.Clear()
        ordenar_visibles.NombresColumnas.Clear()
        Verifica()
        VerificaAprox()
    End Sub
    Sub Verifica()
        Select Case Me.CurrentList
            Case RoleManager.Items.Medicos
                VerificaXML("Medicos")

            Case RoleManager.Items.Mutuas
                VerificaXML("Mutuas")

            Case RoleManager.Items.Formas_de_Pago
                VerificaXML("FormasPago")

            Case RoleManager.Items.Proveedores
                VerificaXML("Proveedores")

            Case RoleManager.Items.Bancos
                VerificaXML("Bancos")

            Case RoleManager.Items.Conceptos_Facturables
                VerificaXML("ConceptosFra")

            Case RoleManager.Items.Paises
                VerificaXML("Paises")

            Case RoleManager.Items.Conceptos_de_Analiticas
                VerificaXML("ConceptosAnalitica")

            Case RoleManager.Items.Pacientes_Derivaciones
                VerificaXML("Derivaciones_Destinos")
                'gv_listado.Columns("CODIGO").Visible = True
                'gv_listado.Columns("NOMBRE").Visible = True
                'gv_listado.Columns("PROVINCIA").Visible = True
                'gv_listado.Columns("DIRECCION").Visible = True
                'gv_listado.Columns("POBLACION").Visible = True
                'gv_listado.Columns("TLFNO1").Visible = True
                'gv_listado.Columns("DIRECCION").HeaderText = "Direccion"
                'gv_listado.Columns("POBLACION").HeaderText = "Poblacion"
                'gv_listado.Columns("PROVINCIA").HeaderText = "Provincia"
                'gv_listado.Columns("PROVINCIA").DisplayIndex = 4
                'gv_listado.Columns("POBLACION").DisplayIndex = 3
                'gv_listado.Columns("CODIGO").HeaderText = "Código"
                'gv_listado.Columns("CODIGO").DisplayIndex = 0
                'gv_listado.Columns("NOMBRE").HeaderText = "Nombre"
                'gv_listado.Columns("NOMBRE").DisplayIndex = 1
                'gv_listado.Columns("TLFNO1").HeaderText = "Tlfno1"
                'gv_listado.Columns("TLFNO1").DisplayIndex = 5

            Case RoleManager.Items.Alarmas
                VerificaXML("Alarmas")

            Case RoleManager.Items.Articulos
                VerificaXML("Articulos")

            Case RoleManager.Items.Medicamentos
                VerificaXML("Medicamentos")

            Case RoleManager.Items.Plantillas_de_texto
                VerificaXML("Plantillas")

            Case RoleManager.Items.Diagnosticos
                VerificaXML("Diagnosticos")

            Case RoleManager.Items.Gastos
                VerificaXML("Gastos")

            Case RoleManager.Items.Indicaciones
                VerificaXML("Indicaciones")

            Case RoleManager.Items.Plantilla_de_Historial
                VerificaXML("PlantillaHistoriales")
                'gv_listado.Columns("CODIGO").Visible = True
                'gv_listado.Columns("DESCRIPCION").Visible = True
                'gv_listado.Columns("CODIGO").HeaderText = "Código"
                'gv_listado.Columns("DESCRIPCION").HeaderText = "Descripcion"
                'gv_listado.Columns("CODIGO").DisplayIndex = 0

            Case RoleManager.Items.Partes_Asistencia
                VerificaXML("Partes")

            Case RoleManager.Items.Partes_Altas_Bajas
                VerificaXML("Partes")

            Case RoleManager.Items.Empresas
                VerificaXML("Empresas")

            Case RoleManager.Items.Pacientes
                VerificaXML("Pacientes")

            Case RoleManager.Items.Facturas
                VerificaXML("Facturas")

            Case RoleManager.Items.Analiticas
                VerificaXML("Analiticas")


            Case RoleManager.Items.Plantillas_para_Analiticas
                VerificaXML("PlantillaAnaliticas")
                'gv_listado.Columns("CODIGO").HeaderText = "Código"
                'gv_listado.Columns("DESCRIPCION").HeaderText = "Descripcion"
                'gv_listado.Columns("CODIGO").DisplayIndex = 0
                'gv_listado.Columns("DESCRIPCION").DisplayIndex = 1

                'Case RoleManager.Items.Usuarios
                '    VerificaXML("Usuarios")

            Case RoleManager.Items.Modelos_Revisiones_Comparativas
                VerificaXML("ModelosComparativa")

            Case RoleManager.Items.Recibos
                VerificaXML("Recibos")
        End Select
    End Sub

    Sub Valida(ByVal aTable As String)
        Dim dir As String = Application.StartupPath()
        Dim di As DirectoryInfo = Directory.GetParent(dir)
        Dim dip As DirectoryInfo = di.Parent
        Dim direccion As String = dip.FullName
        Dim _reader As XmlReader = New XmlTextReader(dir + "\\Config\\componente.xml")
        Dim _doc As XmlDocument = New XmlDocument()
        _doc.Load(dir + "\\Config\\componente.xml")
        Dim nodelist As XmlNodeList = _doc.ChildNodes.Item(1).ChildNodes
        For Each node As XmlNode In nodelist
            If node.Attributes("Name").Value = aTable Then
                Dim rows As XmlNodeList = node.ChildNodes
                For Each row As XmlNode In rows
                    Dim index As Integer
                    index = ordenar_visibles.lbx_columnas.Items.IndexOf(row.Attributes("Campo").Value)
                    Dim indexf As Integer
                    indexf = ordenar_filtros.lbx_columnas.Items.IndexOf(row.Attributes("Campo").Value)
                    If index <> -1 Then
                        row.Attributes("Visible").Value = "TRUE"
                        row.Attributes("Posicion").Value = index.ToString()
                    Else
                        row.Attributes("Visible").Value = "FALSE"
                        row.Attributes("Posicion").Value = "-1"
                    End If
                    If indexf <> -1 Then
                        row.Attributes("PosicionOrden").Value = indexf.ToString()
                    Else
                        row.Attributes("PosicionOrden").Value = "-1"
                    End If
                Next
            End If
        Next
        'Try
        _doc.Save(dir + "\\Config\\componente.xml")
        'Catch ex As Exception

        'End 'Try

    End Sub

    Sub VerificaAprox()
        Select Case Me.CurrentList
            Case RoleManager.Items.Medicos

                If Globales.Configuracion.medaprox = "S" Then
                    chb_aprox.Checked = True
                End If


            Case RoleManager.Items.Mutuas

                If Globales.Configuracion.mutuaaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Formas_de_Pago
                If Globales.Configuracion.formaaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Proveedores

                If Globales.Configuracion.proveedoraprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Bancos
                If Globales.Configuracion.bancoaprox = "S" Then
                    chb_aprox.Checked = True
                End If


            Case RoleManager.Items.Conceptos_Facturables
                If Globales.Configuracion.conceptoaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Paises
                If Globales.Configuracion.paisesaprox = "S" Then
                    chb_aprox.Checked = True
                End If


            Case RoleManager.Items.Conceptos_de_Analiticas

                If Globales.Configuracion.conceptanalaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Pacientes_Derivaciones
                If Globales.Configuracion.derivacionesaprox = "S" Then
                    chb_aprox.Checked = True
                End If
            Case RoleManager.Items.Alarmas
                If Globales.Configuracion.alarmaaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Articulos
                If Globales.Configuracion.articuloaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Medicamentos
                If Globales.Configuracion.medicamentoaprox = "S" Then
                    chb_aprox.Checked = True
                End If
            Case RoleManager.Items.Plantillas_de_texto

                If Globales.Configuracion.platillatextoaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Diagnosticos
                If Globales.Configuracion.diagnosticoaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Gastos
                If Globales.Configuracion.gastosaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Indicaciones
                If Globales.Configuracion.indicacionesaprox = "S" Then
                    chb_aprox.Checked = True
                End If
            Case RoleManager.Items.Plantilla_de_Historial
                If Globales.Configuracion.historialaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Partes_Asistencia
                If Globales.Configuracion.asistaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Partes_Altas_Bajas
                If Globales.Configuracion.bajaaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Empresas
                If Globales.Configuracion.empaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Pacientes
                If Globales.Configuracion.pacaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Facturas

                If Globales.Configuracion.facturasaprox = "S" Then
                    chb_aprox.Checked = True
                End If
            Case RoleManager.Items.Analiticas
                If Globales.Configuracion.analaprox = "S" Then
                    chb_aprox.Checked = True
                End If

            Case RoleManager.Items.Plantillas_para_Analiticas
                If Globales.Configuracion.plantillaanalaprox = "S" Then
                    chb_aprox.Checked = True
                End If
                'Case RoleManager.Items.Usuarios
                '    If Globals.Configuracion.usuarioaprox = "S" Then
                '        chb_aprox.Checked = True
                '    End If

            Case RoleManager.Items.Modelos_Revisiones_Comparativas
                If Globales.Configuracion.revaprox = "S" Then
                    chb_aprox.Checked = True
                End If
            Case RoleManager.Items.Recibos
                If Globales.Configuracion.recibosaprox = "S" Then
                    chb_aprox.Checked = True
                End If
        End Select
    End Sub

    Private Sub Salva()
        Select Case Me.CurrentList
            Case RoleManager.Items.Medicos

                Globales.Configuracion.medaprox = "S"

            Case RoleManager.Items.Mutuas

                Globales.Configuracion.mutuaaprox = "S"

            Case RoleManager.Items.Formas_de_Pago
                Globales.Configuracion.formaaprox = "S"

            Case RoleManager.Items.Proveedores

                Globales.Configuracion.proveedoraprox = "S"
            Case RoleManager.Items.Bancos
                Globales.Configuracion.bancoaprox = "S"

            Case RoleManager.Items.Conceptos_Facturables
                Globales.Configuracion.conceptoaprox = "S"

            Case RoleManager.Items.Paises
                Globales.Configuracion.paisesaprox = "S"

            Case RoleManager.Items.Conceptos_de_Analiticas

                Globales.Configuracion.conceptanalaprox = "S"
            Case RoleManager.Items.Pacientes_Derivaciones
                Globales.Configuracion.derivacionesaprox = "S"
            Case RoleManager.Items.Alarmas
                Globales.Configuracion.alarmaaprox = "S"

            Case RoleManager.Items.Articulos
                Globales.Configuracion.articuloaprox = "S"

            Case RoleManager.Items.Medicamentos
                Globales.Configuracion.medicamentoaprox = "S"
            Case RoleManager.Items.Plantillas_de_texto

                Globales.Configuracion.platillatextoaprox = "S"

            Case RoleManager.Items.Diagnosticos
                Globales.Configuracion.diagnosticoaprox = "S"

            Case RoleManager.Items.Gastos
                Globales.Configuracion.gastosaprox = "S"

            Case RoleManager.Items.Indicaciones
                Globales.Configuracion.indicacionesaprox = "S"
            Case RoleManager.Items.Plantilla_de_Historial
                Globales.Configuracion.historialaprox = "S"

            Case RoleManager.Items.Partes_Asistencia
                Globales.Configuracion.asistaprox = "S"

            Case RoleManager.Items.Partes_Altas_Bajas
                Globales.Configuracion.bajaaprox = "S"

            Case RoleManager.Items.Empresas
                Globales.Configuracion.empaprox = "S"

            Case RoleManager.Items.Pacientes
                Globales.Configuracion.pacaprox = "S"

            Case RoleManager.Items.Facturas

                Globales.Configuracion.facturasaprox = "S"
            Case RoleManager.Items.Analiticas
                Globales.Configuracion.analaprox = "S"

            Case RoleManager.Items.Plantillas_para_Analiticas
                Globales.Configuracion.plantillaanalaprox = "S"
            Case RoleManager.Items.Configuracion_Usuarios
                Globales.Configuracion.usuarioaprox = "S"

            Case RoleManager.Items.Modelos_Revisiones_Comparativas
                Globales.Configuracion.revaprox = "S"
            Case RoleManager.Items.Recibos
                Globales.Configuracion.recibosaprox = "S"
        End Select
        Globales.Configuracion.GuardarConfBD()
    End Sub

    Private Sub Niega()
        Select Case Me.CurrentList
            Case RoleManager.Items.Medicos

                Globales.Configuracion.medaprox = "N"

            Case RoleManager.Items.Mutuas

                Globales.Configuracion.mutuaaprox = "N"

            Case RoleManager.Items.Formas_de_Pago
                Globales.Configuracion.formaaprox = "N"

            Case RoleManager.Items.Proveedores

                Globales.Configuracion.proveedoraprox = "N"
            Case RoleManager.Items.Bancos
                Globales.Configuracion.bancoaprox = "N"

            Case RoleManager.Items.Conceptos_Facturables
                Globales.Configuracion.conceptoaprox = "N"

            Case RoleManager.Items.Paises
                Globales.Configuracion.paisesaprox = "N"

            Case RoleManager.Items.Conceptos_de_Analiticas

                Globales.Configuracion.conceptanalaprox = "N"
            Case RoleManager.Items.Pacientes_Derivaciones
                Globales.Configuracion.derivacionesaprox = "N"
            Case RoleManager.Items.Alarmas
                Globales.Configuracion.alarmaaprox = "N"

            Case RoleManager.Items.Articulos
                Globales.Configuracion.articuloaprox = "N"

            Case RoleManager.Items.Medicamentos
                Globales.Configuracion.medicamentoaprox = "N"
            Case RoleManager.Items.Plantillas_de_texto

                Globales.Configuracion.platillatextoaprox = "N"

            Case RoleManager.Items.Diagnosticos
                Globales.Configuracion.diagnosticoaprox = "N"

            Case RoleManager.Items.Gastos
                Globales.Configuracion.gastosaprox = "N"

            Case RoleManager.Items.Indicaciones
                Globales.Configuracion.indicacionesaprox = "N"
            Case RoleManager.Items.Plantilla_de_Historial
                Globales.Configuracion.historialaprox = "N"

            Case RoleManager.Items.Partes_Asistencia
                Globales.Configuracion.asistaprox = "N"

            Case RoleManager.Items.Partes_Altas_Bajas
                Globales.Configuracion.bajaaprox = "N"

            Case RoleManager.Items.Empresas
                Globales.Configuracion.empaprox = "N"

            Case RoleManager.Items.Pacientes
                Globales.Configuracion.pacaprox = "N"

            Case RoleManager.Items.Facturas

                Globales.Configuracion.facturasaprox = "N"
            Case RoleManager.Items.Analiticas
                Globales.Configuracion.analaprox = "N"

            Case RoleManager.Items.Plantillas_para_Analiticas
                Globales.Configuracion.plantillaanalaprox = "N"

                'Case RoleManager.Items.Usuarios
                '    Globals.Configuracion.usuarioaprox = "N"

            Case RoleManager.Items.Modelos_Revisiones_Comparativas
                Globales.Configuracion.revaprox = "N"
            Case RoleManager.Items.Recibos
                Globales.Configuracion.recibosaprox = "N"
        End Select
        Globales.Configuracion.GuardarConfBD()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Select Case Me.CurrentList
            Case RoleManager.Items.Medicos
                Valida("Medicos")



            Case RoleManager.Items.Mutuas
                Valida("Mutuas")


            Case RoleManager.Items.Formas_de_Pago
                Valida("FormasPago")


            Case RoleManager.Items.Proveedores
                Valida("Proveedores")


            Case RoleManager.Items.Bancos
                Valida("Bancos")


            Case RoleManager.Items.Conceptos_Facturables
                Valida("ConceptosFra")


            Case RoleManager.Items.Paises
                Valida("Paises")

            Case RoleManager.Items.Conceptos_de_Analiticas
                Valida("ConceptosAnalitica")


            Case RoleManager.Items.Pacientes_Derivaciones
                Valida("Derivaciones_Destinos")


            Case RoleManager.Items.Alarmas
                Valida("Alarmas")


            Case RoleManager.Items.Articulos
                Valida("Articulos")


            Case RoleManager.Items.Medicamentos
                Valida("Medicamentos")

            Case RoleManager.Items.Plantillas_de_texto
                Valida("Plantillas")


            Case RoleManager.Items.Diagnosticos
                Valida("Diagnosticos")


            Case RoleManager.Items.Gastos
                Valida("Gastos")


            Case RoleManager.Items.Indicaciones
                Valida("Indicaciones")


            Case RoleManager.Items.Plantilla_de_Historial
                Valida("PlantillaHistoriales")

            Case RoleManager.Items.Partes_Asistencia
                Valida("Partes")


            Case RoleManager.Items.Partes_Altas_Bajas
                Valida("Partes")


            Case RoleManager.Items.Empresas
                Valida("Empresas")


            Case RoleManager.Items.Pacientes
                Valida("Pacientes")


            Case RoleManager.Items.Facturas
                Valida("Facturas")


            Case RoleManager.Items.Analiticas
                Valida("Analiticas")



            Case RoleManager.Items.Plantillas_para_Analiticas
                Valida("PlantillaAnaliticas")


                'Case RoleManager.Items.Usuarios
                '    Valida("Usuarios")


            Case RoleManager.Items.Modelos_Revisiones_Comparativas
                Valida("ModelosComparativa")


            Case RoleManager.Items.Recibos
                Valida("Recibos")

        End Select

        If chb_aprox.Checked = True Then
            Salva()
        Else
            Niega()
        End If
        Me.Close()
    End Sub

    Private Sub Visible_Change(ByVal sender As Object, ByVal e As VisibleEventArgs) Handles Columnas1.VisibleColumnsChecked
        If e.Visible = True Then
            ordenar_visibles.AdicionaColumna = e.Name
        Else
            ordenar_visibles.lbx_columnas.Items.Remove(e.Name)
        End If
    End Sub

    Private Sub Filter_Change(ByVal sender As Object, ByVal e As FilterEventArgs) Handles Columnas1.FiltradoColumnsChecked
        If e.Filtrado = True Then
            ordenar_filtros.AdicionaColumna = e.Name
        Else
            ordenar_filtros.lbx_columnas.Items.Remove(e.Name)
        End If
    End Sub
End Class