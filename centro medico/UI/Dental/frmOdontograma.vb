Imports System.IO
Imports System.Math
Imports Microsoft.VisualBasic.FileIO
Imports System.Xml
Imports System.Xml.Linq
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Imports Janus.Windows.GridEX
Imports centro_medico.UI.Reportes

Public Class frmOdontograma
    Inherits Form

    'ESTA ES LA CATEGORIA DENTAL. ESTA PUESTA COMO 1 PERO EN REALIDAD DEBE PASARSELE AL FORMULARIO ANTES DE MOSTRARLO
    Public CategoriaDental As Integer = 1
    'ESTA ES ID DEL PACIENTE ACTUAL. ESTA PUESTO COMO 1 PERO EN REALIDAD DEBE PASARSELE AL FORMULARIO ANTES DE MOSTRARLO

    Public PacienteActual As Integer = 1
    'ESTA VARIABLE LA UTILIZA EL FORMULARIO PARA ESPECIFICAR LOS CUADRANTES

    Public MedicoPreseleccionado As Nullable(Of Integer) = Nothing

    Public cuadrantes As String = ""
    'VARIABLE PARA DECIDIR SI SE PUEDE INSERTAR EN PRIMERA VISITA EN CUALQUIER MOMENTO
    Public PrimeraVisitaFree As Boolean = True

    'LOS COLORES UTILIZADOS PARA REPRESENTAR LOS TRATAMIENTOS EN LOS ODONTOGRAMAS
    Private oColores(4) As Color 'Realizado, Pendiente, Presupuesto, Primera visita, Urgente
    'CUANDO ES UN TRATAMIENTO MULTIPLE ALMACENAR LA PRIMERA PIEZA SELECCIONADA
    Private primeraPieza As Integer
    'LOS ID DE LOS DOS ODONTOGRAMAS ASOCIADOS AL PACIENTE SELECCIONADO
    Private OdontogramaID(1) As Integer
    'DOCTOR SELECCIONADO. SE ACTUALIZA CUANDO SE MODIFICA LA SELECCION EN EL LISTADO DE DOCTORES
    Friend SelDoctor As Integer ' DOCTOR SELECCIONADO
    Private ImporteTotal As Double 'IMPORTE ASOCIADO AL PRESUPUESTO SELECCIONADO
    Private lastkeypressed As Char

    Public MostrarSoloPresupuesto As Boolean = False

    'VARIABLES RELACIONADAS CON EL TRATAMIENTO SELECCIONADO
    Friend currentTratID As String = ""
    Friend currentTratDesc As String
    Friend currentTratImport As Double
    Friend ctMarcar As Boolean = True
    Friend ctCuadrantes As Boolean = False
    Friend ctMultiple As Boolean = False
    Friend currentDescuentoPorciento As Double = 0
    Friend ImportePorPieza As Boolean = False
    Friend ctpiezas(85) As Boolean
    Private SelectingTrat As Boolean = False

    'DEFINIR LAS TECLAS QUE CONJUNTAMENTE CON LA TECLA ALT SE UTILIZARAN PARA ACTIVAR LA PAGINA CON EL ODONTOGRAMA CORRESPONDIENTE
    Public Enum VistaKeys
        Realizado = Keys.O
        Pendiente = Keys.T
        Presupuesto = Keys.P
        PrimeraVisita = Keys.V
    End Enum
    'IMAGE INDEX
    Public Enum imgIndex
        Operacion = 0
        Tratamiento = 1
        Presupuesto = 2
        LineaPresupuesto = 3
        LineaPresupuestoUrgente = 4
        Confirmado = 5
        ConfirmadoUrgente = 6
        Realizado = 7
    End Enum

    Public Sub New()
        InitializeComponent()
    End Sub
    'INICIALIZAR LOS LISTADOS
    Private Sub frmOdontograma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarMedicos()

        If MedicoPreseleccionado.HasValue Then
            For Each item As md_MEDICO In CBx_Doct.Items
                If item.CMEDICO = MedicoPreseleccionado.Value Then
                    CBx_Doct.SelectedItem = item
                    SelDoctor = item.CMEDICO
                End If
            Next
        End If

        CheckImagesOnDisk()
        CargarColores()
        CargarOperaciones()
        CargarTodosTratamientos()
        CargarOdontogramas()
        CargarListaAcciones()
        CargarMutuas()
        CargarPresupuestos()
        CargarListaPendiente()

        CtrlAlarmaPaciente1.ID_Paciente = PacienteActual

        dtpFecha.Value = Date.Today
        If MostrarSoloPresupuesto = True Then
            tbc.SelectedIndex = 2
            tslCasosUrgentes.Visible = False
            chbVerPendientes.Visible = False
            chbVerPresupuesto.Visible = False
            chbHabilitar.Visible = False
            StatusStrip1.Visible = False
            tbc.TabPages.Item(0).TabVisible = False
            tbc.TabPages.Item(1).TabVisible = False
            tbc.TabPages.Item(3).TabVisible = False
        Else
            If lvw1.Items.Count = 0 Then
                If lvw4.Items.Count = 0 Then
                    tbc.SelectedIndex = 3
                Else
                    tbc.SelectedIndex = 2
                End If
            End If
        End If
        AplicaPermisos()



    End Sub
    'CARGAR LOS MEDICOS
    Private Sub CargarMedicos()
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim lmedicos As IEnumerable(Of md_MEDICO) = classOdontograma.GetListadoMedicos()
        For Each medico As md_MEDICO In lmedicos
            CBx_Doct.Items.Add(medico)
        Next
        If CBx_Doct.Items.Count > 0 Then
            CBx_Doct.SelectedIndex = 0

            SelDoctor = TryCast(CBx_Doct.Items(0), md_MEDICO).CMEDICO
        Else
            MsgBox("No hay doctores registrados. Para utilizar el odontograma deben existir doctores")
            Close()
        End If

        'Si el usuario logueado es doctor, preseleccionarlo si esta activada esta opcion
        Try
            If Globales.Usuario.CONFIGURACIONXML.<Medico>.<SiUsuarioMedicoUsarPorDefecto>.Value = True Then
                If Globales.Usuario.REFMEDICO.HasValue Then

                    For Each item As md_MEDICO In CBx_Doct.Items
                        If item.CMEDICO = Globales.Usuario.REFMEDICO Then
                            CBx_Doct.SelectedItem = item
                            SelDoctor = item.CMEDICO
                        End If
                    Next

                End If

            End If
        Catch ex As Exception

        End Try

    End Sub



    Private Sub AplicaPermisos()
        'Presupuestos, ver precios
        'Dim apermiso As Integer = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Dental_Presupuestos)

        Grid3.RootTable.Columns("Importe").Visible = Not (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) = RoleManager.TipoPermisos.Ninguno)

        'Falta desaparecer los botones y la funcionalidad si no tiene permisos

        TsMenu.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)
        'tstOperaciones.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)
        'tslCasosUrgentes.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)

        'oMenu (Historial y ficheros asociados)
        oMenu.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)

        pMenu.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)

        mitEliminarPres.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)
        mitEliminarPres.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)

        mitNuevoPres.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        mitNuevoPres.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        mitFicherosAsociados.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        mitMoverTodoPendiente.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        mitMoverTodoPendiente.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        mitMoverTodoRealizado.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        mitMoverTodoRealizado.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        mitVerReporte.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)
        mitVerReporte.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)


        'TsPresupuestos

        TsPresupuestos.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)

        btnPEliminar.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)
        btnPEliminar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)

        btnPNuevo.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        btnPNuevo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        'btnFi.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        btnPMPendiente.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        btnPMPendiente.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        btnPMRealizado.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        btnPMRealizado.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        btnPReporte.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)
        btnPReporte.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)

        cMenu.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)

        cmEliminar.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)
        cmEliminar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)

        cmNTratamiento.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        cmNTratamiento.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        'btnFi.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        cmAPendiente.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        cmAPendiente.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        cmARealizado.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        cmARealizado.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        cmVerCita.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)
        cmVerCita.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)

        Odontograma1.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        Odontograma2.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        Odontograma3.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        Odontograma4.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        tbcTrat.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        rtb3.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        chbUrgente3.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)


    End Sub

    'ACTUALIZAR LA VARIABLE UTILIZADA PARA LAS INSERCIONES EN EL ODONTOGRAMA
    Private Sub CBx_Doct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBx_Doct.SelectedIndexChanged
        SelDoctor = TryCast(CBx_Doct.SelectedItem, md_MEDICO).CMEDICO
    End Sub
    'CHEQUEAR SI TODAS LAS IMAGENES ESTAN SALVADAS EN EL HDD, SINO SALVARLAS
    Private Sub CheckImagesOnDisk()
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim Imagenes As IEnumerable(Of md_d_Imagen) = classOdontograma.GetImagenes()
        Dim picture As Image
        Dim di As DirectoryInfo = New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Inceme\Images")
        Try
            If di.Exists = False Then
                di.Create()
            End If

            For Each img As md_d_Imagen In Imagenes
                If FileSystem.FileExists(di.FullName + "\I" + img.IDImagen.ToString()) Then
                    If FileSystem.GetFileInfo(di.FullName + "\I" + img.IDImagen.ToString()).CreationTime < img.Crdt Then
                        picture = Image.FromStream(New MemoryStream(img.Imagen.ToArray()))
                        picture.Save(di.FullName + "\I" + img.IDImagen.ToString())
                    End If
                Else
                    picture = Image.FromStream(New MemoryStream(img.Imagen.ToArray()))
                    picture.Save(di.FullName + "\I" + img.IDImagen.ToString())
                End If
            Next
        Catch e As Exception
            MsgBox("Problemas al crear copia de las imágenes: " + e.ToString())
        End Try
    End Sub
    'CARGAR LOS COLORES CON LOS CUALES SE VA A TRABAJAR
    Private Sub CargarColores()
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim colores As md_d_Color = classOdontograma.GetColores
        oColores(0) = Color.FromArgb(colores.clRealizado)
        oColores(1) = Color.FromArgb(colores.clPendiente)
        oColores(2) = Color.FromArgb(colores.clPresupuesto)
        oColores(3) = Color.FromArgb(colores.clPrimeravista)
        oColores(4) = Color.FromArgb(colores.clUrgente)
        Dim img As System.Drawing.Image
        Dim gph As Graphics
        Dim sbh As SolidBrush
        imgListtbC.Images.Clear()
        For i As Integer = 0 To 3
            img = New System.Drawing.Bitmap(12, 12)
            gph = Graphics.FromImage(img)
            sbh = New SolidBrush(oColores(i))
            gph.FillRectangle(sbh, 0, 0, 12, 12)
            imgListtbC.Images.Add(img)
            gph.Dispose()
        Next
        img = New System.Drawing.Bitmap(12, 12)
        gph = Graphics.FromImage(img)
        sbh = New SolidBrush(oColores(4))
        gph.FillRectangle(sbh, 0, 0, 12, 12)
        pbx_urg1.Image = img
        pbx_urg2.Image = img
        gph.Dispose()
        For i As Integer = 0 To 3
            tbc.TabPages.Item(i).ImageIndex = i
        Next
        tbc.Refresh()
    End Sub
    'CARGAR LAS OPERACIONES 
    Private Sub CargarOperaciones()
        LVw_Oper.Items.Clear()
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim cFamilias As IEnumerable(Of md_ConceptoFamilia) = classOdontograma.GetFamiliasDental(CategoriaDental)
        For Each Operacion As md_ConceptoFamilia In cFamilias
            LVw_Oper.Items.Add(Operacion.Descripcion, imgIndex.Operacion)
            LVw_Oper.Items(LVw_Oper.Items.Count - 1).Tag = Operacion
        Next
        If LVw_Oper.Items.Count > 0 Then
            LVw_Oper.SelectedIndices.Add(0)
        End If
    End Sub
    'CARGAR TODOS LOS TRATAMIENTOS
    Private Sub CargarTodosTratamientos()
        LVw_TTrat.Items.Clear()
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim cFra As IEnumerable(Of md_ConceptoFra) = classOdontograma.GetAllCFra(CategoriaDental)
        For Each tratamiento As md_ConceptoFra In cFra
            LVw_TTrat.Items.Add(tratamiento.DESCRIPCION, imgIndex.Tratamiento)
            LVw_TTrat.Items(LVw_TTrat.Items.Count - 1).Tag = tratamiento
        Next
        If LVw_TTrat.Items.Count > 0 Then
            LVw_TTrat.Items(0).Selected = True
        End If
    End Sub
    'CARGAR LOS ID DE LOS DOS ODONTROGRAMAS ASOCIADOS AL PACIENTE. SI NO EXISTEN CREARLOS
    Private Sub CargarOdontogramas()
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim odontogramas As IEnumerable(Of md_d_Odontograma) = classOdontograma.GetOdontogramasByPaciente(PacienteActual)
        OdontogramaID(0) = odontogramas(0).IDOdontograma
        OdontogramaID(1) = odontogramas(1).IDOdontograma
    End Sub
    'CARGAR EL LISTADO DE TODAS LAS ACCIONES ASOCIADAS AL ODONTOGRAMA Y REPRESENTARLAS EN EL ODONTOGRAMA
    Private Sub CargarListaAcciones()
        Dim ID As Integer
        If rbnTemporal.Checked = True Then
            ID = OdontogramaID(0)
        Else
            ID = OdontogramaID(1)
        End If
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim acciones As IEnumerable(Of md_d_Accion) = classOdontograma.GetAccionesByOdontograma(ID)
        lvw1.Items.Clear()
        lvw4.Items.Clear()
        Odontograma1.Reset()
        Odontograma4.Reset()
        For Each accion As md_d_Accion In acciones
            If accion.IDGabinete = -1 Then
                'AddItemAccion(4, accion, accion.md_ConceptoFra.DESCRIPCION)
                AddItemAccion(4, accion, accion.DescripcionGenerada)
                If accion.Cuadrantes <> "" Then
                    For i As Integer = 0 To accion.Cuadrantes.Length - 1
                        RepresentAction(Odontograma4, accion.IDTratamiento, accion.Cuadrantes(i), accion.PiezasInvolucradas, oColores(3))
                        RepresentAction(Odontograma1, accion.IDTratamiento, accion.Cuadrantes(i), accion.PiezasInvolucradas, oColores(3))
                    Next
                Else
                    RepresentAction(Odontograma4, accion.IDTratamiento, "C", accion.PiezasInvolucradas, oColores(3))
                    RepresentAction(Odontograma1, accion.IDTratamiento, "C", accion.PiezasInvolucradas, oColores(3))
                End If
            Else
                'AddItemAccion(1, accion, accion.md_ConceptoFra.DESCRIPCION)
                AddItemAccion(1, accion, accion.DescripcionGenerada)
                If accion.Cuadrantes <> "" Then
                    For i As Integer = 0 To accion.Cuadrantes.Length - 1
                        RepresentAction(Odontograma1, accion.IDTratamiento, accion.Cuadrantes(i), accion.PiezasInvolucradas, oColores(0))
                    Next
                Else
                    RepresentAction(Odontograma1, accion.IDTratamiento, "C", accion.PiezasInvolucradas, oColores(0))
                End If
            End If
        Next
    End Sub
    'CARGAR LOS PRESUPUESTOS ASOCIADOS AL ODONTOGRAMA Y CARGARLOS EN EL LISTADO
    Private Sub CargarPresupuestos()
        tvwPresupuestos.Nodes.Clear()

        'Dim ID As Integer
        'If rbnTemporal.Checked = True Then
        '    ID = OdontogramaID(0)
        'Else
        '    ID = OdontogramaID(1)
        'End If
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim presupuestos As IEnumerable(Of md_d_Presupuesto) = classOdontograma.GetAllPresupuestos(OdontogramaID(0), OdontogramaID(1))
        Dim tnode As TreeNode

        For Each presupuesto As md_d_Presupuesto In presupuestos
            Dim NumPre As Integer = 0
            For Each nodo As TreeNode In tvwPresupuestos.Nodes
                If nodo.Text.Contains(Format(presupuesto.FechaConcepcion, "dd/MM/yyyy")) Then NumPre += 1
            Next
            tnode = tvwPresupuestos.Nodes.Add("P" & NumPre + 1 & " - " & Format(presupuesto.FechaConcepcion, "dd/MM/yyyy"))
            tnode.Tag = presupuesto
        Next
        If tvwPresupuestos.Nodes.Count > 0 Then
            tvwPresupuestos.SelectedNode = tvwPresupuestos.Nodes.Item(tvwPresupuestos.Nodes.Count - 1)
        Else
            LineasPresupuestoTableAdapter.Fill(OdontTrat.LineasPresupuesto, 0)
            Grid3.Refetch()
        End If
    End Sub

    'Cargar Mutuas del Paciente
    Private Sub CargarMutuas()
        'Dim context As New CMLinqDataContext
        'Dim md_context As New ClasesOdontogramaDataContext

        'Dim paciente As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = PacienteActual Select p).SingleOrDefault()
        'For Each lmutua As LMUTUA In paciente.LMUTUAs
        '    Dim mutua As md_MUTUA = (From m In md_context.md_MUTUAs Where m.CMUTUA = lmutua.REFMUTUA Select m).SingleOrDefault()
        '    cb_aseguradora.Items.Add(mutua)
        'Next
        'cb_aseguradora.Enabled = True
    End Sub

    'CARGAR LA LISTA DE LINEAS DE PRESUPUESTOS CONFIRMADOS
    Private Sub CargarListaPendiente()
        'Dim ID As Integer
        'If rbnTemporal.Checked Then
        '    ID = OdontogramaID(0)
        'Else
        '    ID = OdontogramaID(1)
        'End If
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim pendientes As IEnumerable(Of md_d_PresupuestoLinea) = classOdontograma.GetAllLineasPendientes(OdontogramaID(0), OdontogramaID(1))
        Dim TipoDenticio = If(rbnTemporal.Checked, 0, 1)
        lvw2.Items.Clear()
        Odontograma2.Reset()
        Dim aColor As Color

        For Each pendiente As md_d_PresupuestoLinea In pendientes
            If pendiente.TipoDenticion <> TipoDenticio Then Continue For
            If pendiente.Urgencia = 1 Then
                aColor = oColores(4)
            Else
                aColor = oColores(1)
            End If

            AddItemPresupuesto(pendiente, pendiente.DescripcionGenerada)
            If pendiente.Cuadrantes <> "" Then
                For i As Integer = 0 To pendiente.Cuadrantes.Length - 1
                    RepresentAction(Odontograma2, pendiente.IDTratamiento, pendiente.Cuadrantes(i), pendiente.PiezasInvolucradas, aColor)
                Next
            Else
                RepresentAction(Odontograma2, pendiente.IDTratamiento, "C", pendiente.PiezasInvolucradas, aColor)
            End If
        Next
    End Sub
    'CARGAR EL LISTADO DE LINEAS ASOCIADAS AL PRESUPUESTO SELECCIONADO EN EL LISTADO DE PRESUPUESTOS
    Private Sub tvwPresupuestos_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwPresupuestos.AfterSelect
        If e.Node Is Nothing Then
            CtrlMutua1.Enabled = False
            CtrlMutua1.ID_Mutuas = Nothing
        Else
            CtrlMutua1.Enabled = True
        End If

        MostrarLineasPresupuesto(e.Node)

        btnPMPendiente.Enabled = Not (e.Node Is Nothing)
        btnPMRealizado.Enabled = Not (e.Node Is Nothing)
        btnPEliminar.Enabled = Not (e.Node Is Nothing)
        btnPReporte.Enabled = Not (e.Node Is Nothing)
        lblImporte.Text = "Importe total: " + ImporteTotal.ToString("0.00")

        Dim presupuesto As md_d_Presupuesto = TryCast(e.Node.Tag, md_d_Presupuesto)
        If Not presupuesto Is Nothing Then
            CtrlMutua1.ID_Mutuas = presupuesto.IDMutua
        End If
    End Sub

    'Private Function IndexOfMutua(ByVal idMutua As Integer) As Integer
    '    If cb_aseguradora.Items.Count = 0 Then Return -1

    '    Dim i = 0
    '    For i = 0 To cb_aseguradora.Items.Count - 1
    '        If cb_aseguradora.Items(i).CMUTUA = idMutua Then Return i
    '    Next
    '    Return -1
    'End Function

    Private Sub MostrarLineasPresupuesto(ByVal node As TreeNode)
        If node Is Nothing Then
            Exit Sub
        End If

        'Dim classOdontograma As New ClasesOdontogramaDataContext
        'Dim lineas As IEnumerable(Of md_d_PresupuestoLinea) = classOdontograma.GetLineasByPresupuesto(TryCast(node.Tag, md_d_Presupuesto).IDPresupuesto)

        Dim IDPresupuesto = TryCast(node.Tag, md_d_Presupuesto).IDPresupuesto
        LineasPresupuestoTableAdapter.Fill(OdontTrat.LineasPresupuesto, IDPresupuesto)

        If accion = "insertar" Then
            accion = "ver"
            If Grid3.RowCount > 0 Then Grid3.Row = Grid3.RowCount - 1
        End If


    End Sub

    Dim CargarOdontograma As Boolean = True
    'CAMBIAR DENTICION (TEMPORAL | DEFINITIVA)
    Private Sub rbnTemporal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnTemporal.CheckedChanged, rbnDefinitiva.CheckedChanged
        Dim TipoDenticion As Integer = If(rbnTemporal.Checked, 0, 1)
        Dim denticion As RadioButton = DirectCast(sender, RadioButton)
        If denticion.Checked = False Then
            CargarOdontograma = True
            Exit Sub
        End If

        chbVerPendientes.Checked = False
        chbVerPresupuesto.Checked = False
        Odontograma1.temporal_dentition = rbnTemporal.Checked
        Odontograma2.temporal_dentition = rbnTemporal.Checked
        Odontograma3.temporal_dentition = rbnTemporal.Checked
        Odontograma4.temporal_dentition = rbnTemporal.Checked

        CargarListaAcciones()
        'CargarPresupuestos()
        If Grid3.SelectedItems.Count > 0 And CargarOdontograma Then CargarLineaPresupuesto(TipoDenticion)
        CargarListaPendiente()

        CargarOdontograma = True
    End Sub
    'CUANDO CAMBIA LA SELECCION DEL LISTADO DE OPERACIONES ACTUALIZAR LISTA DE TRATAMIENTOS ASOCIADOS
    Private Sub LVw_Oper_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVw_Oper.SelectedIndexChanged
        LVw_Trat.Items.Clear()
        For i As Integer = 0 To 85
            ctpiezas(i) = 0
        Next
        ctMarcar = True
        If LVw_Oper.SelectedItems.Count > 0 Then
            Dim familia As md_ConceptoFamilia = TryCast(LVw_Oper.SelectedItems(0).Tag, md_ConceptoFamilia)
            If familia.IconoName = Nothing Then
                pbxFamilia.Image = Nothing
            Else
                pbxFamilia.Image = Image.FromStream(New MemoryStream(familia.IconoName.ToArray()))
            End If
            lblOperacion.Text = LVw_Oper.SelectedItems(0).Text

            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim cFra As IEnumerable(Of md_ConceptoFra) = classOdontograma.GetCFraByFamilia(familia.IDFamilia)
            LVw_Trat.Items.Clear()
            For Each tratamiento As md_ConceptoFra In cFra
                LVw_Trat.Items.Add(tratamiento.DESCRIPCION, imgIndex.Tratamiento)
                LVw_Trat.Items(LVw_Trat.Items.Count - 1).Tag = tratamiento
            Next
            If LVw_Trat.Items.Count > 0 Then
                LVw_Trat.Items(0).Selected = True
            End If
        Else
            lblOperacion.Text = "Seleccione Operación"
            lblTratamiento.Text = ""
            lblTratInfo.Text = ""
            pbxFamilia.Image = Nothing
        End If
    End Sub
    'CUANDO CAMBIA LA SELECCION DEL LISTADO DE TRATAMIENTO CARGAR DATOS ASOCIADOS AL MISMO
    Private Sub LVw_Trat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVw_Trat.SelectedIndexChanged
        If tbcTrat.SelectedIndex = 1 Then
            UpdateTratData(LVw_Trat, False)
        End If
    End Sub
    'CUANDO SE PULSA UNA TECLA EN EL TEXTBOX ASOCIADO AL LISTADO DE TRATAMIENTO
    Private Sub tbxTrat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxTrat.TextChanged
        If Not SelectingTrat Then
            If tbxTrat.Text = "" Then
                LVw_TTrat.SelectedItems.Clear()
            Else
                For i As Integer = 0 To LVw_TTrat.Items.Count - 1
                    If LVw_TTrat.Items(i).Text.ToUpper().StartsWith(tbxTrat.Text.ToUpper()) Then
                        Dim posit As Integer = tbxTrat.SelectionStart
                        If lastkeypressed <> Chr(8) Then
                            If Not LVw_TTrat.Items(i).Selected Then
                                LVw_TTrat.Items(i).Selected = True
                            Else
                                tbxTrat.Text = LVw_TTrat.Items(i).Text
                            End If
                            LVw_TTrat.Items(i).EnsureVisible()
                            tbxTrat.SelectionStart = posit
                            tbxTrat.SelectionLength = tbxTrat.Text.Length - posit
                        End If
                    End If
                Next
            End If
        End If
    End Sub
    'CONTROLAR SI LA TECLA PULSADA ES EL BORRADO
    Private Sub tbxTrat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxTrat.KeyPress
        lastkeypressed = e.KeyChar
    End Sub
    'CUANDO CAMBIAN LA SELECCION DEL LISTADO CON TODOS LOS TRATAMIENTOS
    Private Sub LVw_TTrat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVw_TTrat.SelectedIndexChanged
        SelectingTrat = True
        UpdateTratData(LVw_TTrat, True)
        SelectingTrat = False
    End Sub
    'CUANDO CAMBIA EL TAB PAGE
    Private Sub tbcTrat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcTrat.SelectedIndexChanged
        If tbcTrat.SelectedIndex = 0 Then
            UpdateTratData(LVw_TTrat, True)
        Else
            UpdateTratData(LVw_Trat, False)
        End If
    End Sub
    'ACTUALIZAR EL ESTADO DE LAS VARIABLES ASOCIADAS AL TRATAMIENTO SELECCIONADO
    Private Sub UpdateTratData(ByRef LVw As ListView, ByVal TTrat As Boolean)
        For i As Integer = 0 To 85
            ctpiezas(i) = 0
        Next
        ctMarcar = True
        primeraPieza = 0
        lblInfo.Text = ""
        If TTrat = False Then
            If LVw_Oper.SelectedItems.Count > 0 Then
                Dim familia As md_ConceptoFamilia = TryCast(LVw_Oper.SelectedItems(0).Tag, md_ConceptoFamilia)
                If familia.IconoName = Nothing Then
                    pbxFamilia.Image = Nothing
                Else
                    pbxFamilia.Image = Image.FromStream(New MemoryStream(familia.IconoName.ToArray()))
                End If
            Else
                pbxFamilia.Image = Nothing
            End If
        Else
            If LVw.SelectedItems.Count Then
                Dim familia As md_ConceptoFamilia = TryCast(LVw.SelectedItems(0).Tag, md_ConceptoFra).md_ConceptoFamilia
                If familia.IconoName = Nothing Then
                    pbxFamilia.Image = Nothing
                Else
                    pbxFamilia.Image = Image.FromStream(New MemoryStream(familia.IconoName.ToArray()))
                End If
            Else
                pbxFamilia.Image = Nothing
            End If
        End If
        If LVw.SelectedItems.Count > 0 Then
            currentTratID = TryCast(LVw.SelectedItems(0).Tag, md_ConceptoFra).CODIGO
            currentTratDesc = LVw.SelectedItems(0).Text
            currentTratImport = TryCast(LVw.SelectedItems(0).Tag, md_ConceptoFra).IMPORTE
            If TTrat Then
                tbxTrat.Text = LVw.SelectedItems(0).Text
            Else
                lblTratamiento.Text = LVw.SelectedItems(0).Text
            End If

            getXML(TryCast(LVw.SelectedItems(0).Tag, md_ConceptoFra))
            If ctMarcar Then
                If ctMultiple = True Then
                    lblTratInfo.Text = "Marcar dos piezas disponibles ubicadas en línea"
                Else
                    lblTratInfo.Text = "Marcar una pieza disponible"
                End If
            Else
                lblTratInfo.Text = "Marcar en cualquier parte del odontograma"
            End If
            If ctCuadrantes = True Then
                lblTratInfo.Text = lblTratInfo.Text + Chr(13) + Chr(10) + "Especificar cuadrantes"
            End If
        Else
            If TTrat Then
                tbxTrat.Text = ""
            Else
                lblTratamiento.Text = "Seleccione Tratamiento"
            End If
            lblTratInfo.Text = ""
            currentTratID = ""
        End If
    End Sub

#Region "Private Sub CreaXmlPorDefecto(ByRef tratamiento As md_ConceptoFra)"
    Private Sub CreaXmlPorDefecto(ByRef tratamiento As md_ConceptoFra)
        Dim context As New CMLinqDataContext()
        Dim codigo As String = tratamiento.CODIGO
        Dim tratamiento2 As CONCEPTOSFRA = (From t In context.CONCEPTOSFRAs Where t.CODIGO = codigo Select t).SingleOrDefault

        Dim disponibles As XElement = New XElement("Disponibles")
        'For i As Integer = 0 To pnlDefinitivas.Controls.Count - 1
        '    If (pnlDefinitivas.Controls(i).Name.Substring(0, 3) = "chb") Then
        '        If (TryCast(pnlDefinitivas.Controls(i), CheckBox).Checked) Then
        '            disponibles.Add(New XElement("Pieza", pnlDefinitivas.Controls(i).Tag))
        '        End If
        '    End If
        'Next
        'For i As Integer = 0 To pnlTemporales.Controls.Count - 1
        '    If (pnlTemporales.Controls(i).Name.Substring(0, 3) = "chb") Then
        '        If (TryCast(pnlTemporales.Controls(i), CheckBox).Checked) Then
        '            disponibles.Add(New XElement("Pieza", pnlTemporales.Controls(i).Tag))
        '        End If
        '    End If
        'Next

        Dim doc As XDocument = New XDocument(New XElement("Tratamiento", _
                                    New XAttribute("Marcar", "False"), _
                                    New XAttribute("Cuadrantes", "False"), _
                                    New XAttribute("ImportePorPieza", "False"), _
                                    New XAttribute("Multiple", "False"), disponibles))

        tratamiento2.XMLCont = doc.ToString()
        tratamiento.XMLCont = doc.ToString()
        context.SubmitChanges()

    End Sub
#End Region

    'LEER EL XML ASOCIADO AL TRATAMIENTO ACTUAL Y ACTUALIZAR VARIABLES
    Public Sub getXML(ByVal tratamiento As md_ConceptoFra)
        If tratamiento.XMLCont Is Nothing Then
            CreaXmlPorDefecto(tratamiento)
        End If
        Dim doc As XDocument = XDocument.Parse(tratamiento.XMLCont)
        Dim tratNode As XElement = doc.Element("Tratamiento")
        ctMarcar = tratNode.Attribute("Marcar")
        ctCuadrantes = tratNode.Attribute("Cuadrantes")
        ctMultiple = tratNode.Attribute("Multiple")



        If tratNode.Attribute("ImportePorPieza") Is Nothing Then
            'Agregarlo y salvar el Tratamiento
            Dim context As New CMLinqDataContext()
            Dim tratamiento2 As CONCEPTOSFRA = (From t In context.CONCEPTOSFRAs Where t.CODIGO = tratamiento.CODIGO Select t).SingleOrDefault
            'tratamiento.XMLCont = 
            tratNode.Add(New XAttribute("ImportePorPieza", "False"))
            tratamiento2.XMLCont = doc.ToString()
            tratamiento.XMLCont = doc.ToString()
            context.SubmitChanges()
            ImportePorPieza = False
        Else
            ImportePorPieza = tratNode.Attribute("ImportePorPieza")
        End If

        Dim dispNode As XElement = tratNode.Element("Disponibles")
        For Each piece As XElement In dispNode.Elements("Pieza")
            ctpiezas(piece.Value) = True
        Next
    End Sub
    'SABER SI SE PUEDE SELECCIONAR O NO UNA PIEZA EN EL ODONTOGRAMA
    Private Sub Odontograma1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Odontograma1.MouseMove, Odontograma4.MouseMove, Odontograma3.MouseMove, Odontograma2.MouseMove
        Dim odont As Odontograma = TryCast(sender, Odontograma)
        Dim odontNumber As Integer = Convert.ToInt32(TryCast(sender, Control).Tag)
        Dim Bloquear As Boolean = ((odontNumber = 1) And (chbHabilitar.Checked = False)) Or (odontNumber = 2)
        Bloquear = Bloquear OrElse ((odontNumber = 4) And (PrimeraVisitaFree = False) And (lvw1.Items.Count > 0))
        Bloquear = Bloquear OrElse ((odontNumber = 3) And ((tvwPresupuestos.Nodes.Count = 0))) 'OrElse (Not (tvwPresupuestos.SelectedNode Is tvwPresupuestos.Nodes.Item(tvwPresupuestos.Nodes.Count - 1)))))
        If odont.HOverPiece > 0 Then
            lblPieza.Text = "Pieza: " + odont.HOverPiece.ToString()
        Else
            lblPieza.Text = ""
        End If
        If (Bloquear = False) And ((ctMarcar = False) OrElse ((odont.HOverPiece > 0) And (ctpiezas(odont.HOverPiece) = True))) Then
            odont.Cursor = Cursors.Hand
        Else
            odont.Cursor = Cursors.No
        End If
    End Sub
    'CUANDO SE SELECCIONA UNA PIEZA EN EL ODONTOGRAMA INSERTAR O ESPERAR A MARCAR LA SEGUNDA SI ES MULTIPLE EL TRATAMIENTO SELECCIONADO
    Private Sub Odontograma1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Odontograma1.MouseDown, Odontograma4.MouseDown, Odontograma3.MouseDown, Odontograma2.MouseDown
        currentDescuentoPorciento = 0
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim odontNumber As Integer = Convert.ToInt32(TryCast(sender, Control).Tag)
            Dim Bloquear As Boolean = ((odontNumber = 1) And (chbHabilitar.Checked = False)) Or (odontNumber = 2)
            Bloquear = Bloquear OrElse ((odontNumber = 4) And (PrimeraVisitaFree = False) And (lvw1.Items.Count > 0))
            Bloquear = Bloquear OrElse ((odontNumber = 3) And ((tvwPresupuestos.Nodes.Count = 0))) 'OrElse (Not (tvwPresupuestos.SelectedNode Is tvwPresupuestos.Nodes.Item(tvwPresupuestos.Nodes.Count - 1)))))
            If (Bloquear = False) Then
                Dim odont As Odontograma = TryCast(sender, Odontograma)
                Dim odont_concepto As Integer = Convert.ToInt32(odont.Tag)
                If currentTratID <> "" Then

                    'Leer el importe por defecto del tratamiento
                    Dim context As New ClasesOdontogramaDataContext
                    currentTratImport = (From t In context.md_ConceptoFras Where t.CODIGO = currentTratID Select t).SingleOrDefault().IMPORTE

                    'SE PUEDE MARCAR CUALQUIER PIEZA
                    If ctMarcar = False Then
                        'Mostrar un form de confirmacion
                        If GetAccionData(currentTratID, currentTratDesc, currentTratImport, 1, currentDescuentoPorciento, True) = Windows.Forms.DialogResult.OK Then
                            AddAction(odont, dtpFecha.Value, currentTratID, currentTratDesc, currentTratImport, odont_concepto, 0)
                            'CargarPresupuestos()
                            accion = "insertar"
                            MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
                        End If

                        'SE MARCO UNA PIEZA DISPONIBLE
                    ElseIf (odont.ClickedPiece > 0) And (ctpiezas(odont.ClickedPiece) = True) Then
                        If ctMultiple = True Then
                            If primeraPieza = 0 Then
                                primeraPieza = odont.ClickedPiece
                                lblInfo.Text = "Pieza incial: " + primeraPieza.ToString()
                                'ESTAN EN LA MISMA LINEA
                            ElseIf ((odont.ClickedPiece \ 10) = (primeraPieza \ 10)) OrElse (((Min(odont.ClickedPiece \ 10, primeraPieza \ 10) + 1) = Max(odont.ClickedPiece \ 10, primeraPieza \ 10)) And ((Max(odont.ClickedPiece \ 10, primeraPieza \ 10) Mod 2) = 0)) Then


                                If GetAccionData(currentTratID, currentTratDesc, currentTratImport, CantidadPiezas(getPiezas(primeraPieza, odont.ClickedPiece)), currentDescuentoPorciento, True) = Windows.Forms.DialogResult.OK Then
                                    AddAction(odont, dtpFecha.Value, currentTratID, currentTratDesc, currentTratImport, odont_concepto, primeraPieza, odont.ClickedPiece)
                                    'CargarPresupuestos()
                                    accion = "insertar"
                                    MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
                                End If
                                lblInfo.Text = ""
                                primeraPieza = 0
                            End If
                        Else

                            If GetAccionData(currentTratID, currentTratDesc, currentTratImport, CantidadPiezas(getPiezas(primeraPieza, odont.ClickedPiece)), currentDescuentoPorciento, True) = Windows.Forms.DialogResult.OK Then
                                AddAction(odont, dtpFecha.Value, currentTratID, currentTratDesc, currentTratImport, odont_concepto, odont.ClickedPiece)
                                'CargarPresupuestos()
                                accion = "insertar"
                                MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
                            End If

                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Function GetAccionData(ByVal idtratamiento As String, ByRef descripcion As String, ByRef importe As Double, ByVal cantPiezas As Integer, ByRef descPercent As Double, ByVal esNuevo As Boolean) As DialogResult
        'Return DialogResult.OK
        Dim frm As New frmEditarAccion(cantPiezas, esNuevo)
        'frm.TratamientoTextBox.Text = 
        frm.IDTratamiento = idtratamiento
        frm.DescripcionGeneradaTextBox.Text = descripcion

        frm.ImporteTextBox.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) > RoleManager.TipoPermisos.Lectura)
        'frm.ImporteLabel.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental_Presupuestos) > RoleManager.TipoPermisos.Lectura)

        frm.ImporteTextBox.Value = importe + descPercent
        frm.txtDescuentoImporte.Value = descPercent

        If esNuevo Then
            If CtrlMutua1.ID_Mutuas.HasValue Then
                'El importe debe aplicarsele la tarifa de mutua si corresponde
                frm.ImporteTextBox.Value = Globales.ObtenImporteConceptoSegunTarifaMutua(idtratamiento, CtrlMutua1.ID_Mutuas, importe) _
                                           + descPercent
                frm.lblTarifa.Visible = True
            End If

        End If

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            descripcion = frm.DescripcionGeneradaTextBox.Text
            importe = frm.txtTotal.Value
            descPercent = frm.txtDescuentoImporte.Value

            Return DialogResult.OK
        End If
        Return DialogResult.Cancel
    End Function

    'ADICIONAR UNA ACCION AL ODONTOGRAMA COMO CONSECUENCIA DE UN TRATAMIENTO EJECUTADO
    Public Function AddAction(ByRef odont As Odontograma, ByVal Fecha As DateTime, ByVal CodigoTrat As String, ByVal DescTrat As String, ByVal ImporteTrat As Double, ByVal concepto As Integer, ByVal pieza1 As Integer, Optional ByVal pieza2 As Integer = 0) As Boolean
        Dim piezas As String = getPiezas(pieza1, pieza2)
        Dim cColor As Color = oColores(Convert.ToInt32(odont.Tag) - 1)
        Dim fResult As Boolean = False
        If (concepto = 3) And (Grid3.SelectedItems.Count = 0) And (chbUrgente3.Checked = True) Then
            cColor = oColores(4)
        End If
        'CUADRANTES
        If (ctMarcar = True) And (ctCuadrantes = True) Then
            Dim f2 As New frmCuadrantes()
            f2.pform = Me
            f2.Pieza = pieza1
            Dim result As DialogResult = f2.ShowDialog(Me)
            If (result = DialogResult.OK) AndAlso (cuadrantes <> "") Then
                fResult = AddConcreteAction(odont, CodigoTrat, ImporteTrat, concepto, piezas, cColor, DescTrat, Fecha)
                cuadrantes = ""
            Else
                fResult = False
            End If
            ' NO CUADRANTES
        Else
            fResult = AddConcreteAction(odont, CodigoTrat, ImporteTrat, concepto, piezas, cColor, DescTrat, Fecha)
        End If
        Return fResult
    End Function
    Private Function AddConcreteAction(ByRef odont As Odontograma, ByVal CodigoTrat As String, ByVal ImporteTrat As Double, ByVal concepto As Integer, ByVal piezas As String, ByVal cColor As Color, ByVal TratDesc As String, ByVal Fecha As DateTime) As Boolean
        Dim CuadARepresentar As String = cuadrantes
        Dim fResult As Boolean = True
        If cuadrantes = "" Then
            CuadARepresentar = "C"
        End If
        Dim PresupuestoLinea As md_d_PresupuestoLinea
        'ACCION
        If (concepto = 1) Or (concepto = 4) Then
            Dim accion As md_d_Accion = AddActionOnDB(concepto, Fecha, CodigoTrat, TratDesc, piezas, cuadrantes, SelDoctor)
            If concepto = 1 Then
                Dim idpresupuesto As Integer = getPresupuestoDate(Fecha)
                PresupuestoLinea = AddPresupuestoLineaOnDB(idpresupuesto, CodigoTrat, TratDesc, piezas, cuadrantes, True, ImporteTrat, True, Fecha, accion.IDAccion)
                If Not (PresupuestoLinea Is Nothing) Then
                    ImporteTotal = ImporteTotal + PresupuestoLinea.Importe
                    lblImporte.Text = "Importe total: " + ImporteTotal.ToString("0.00")
                    'ACTUALIZAR GRID
                End If
            End If
            If Not (accion Is Nothing) Then
                AddItemAccion(concepto, accion, TratDesc)
                For i As Integer = 0 To CuadARepresentar.Length - 1
                    RepresentAction(odont, CodigoTrat, CuadARepresentar(i), piezas, cColor)
                    If concepto = 1 Then
                        RepresentAction(Odontograma3, CodigoTrat, CuadARepresentar(i), piezas, oColores(0))
                    End If
                Next
                'ACTUALIZAR EL ODONTOGRAMA 1 SI SE INSERTA EN PRIMERA VISITA
                If concepto = 4 Then
                    ActualizaOdontogramaDesdeLista(Odontograma1, lvw1)
                End If
                cuadrantes = ""
            Else
                fResult = False
            End If
        Else
            'PRESUPUESTO (ESTA SELECCIONADO EL ULTIMO PRESUPUESTO)
            Dim Presupuesto As md_d_Presupuesto = TryCast(tvwPresupuestos.SelectedNode.Tag, md_d_Presupuesto)
            PresupuestoLinea = AddPresupuestoLineaOnDB(Presupuesto.IDPresupuesto, CodigoTrat, TratDesc, piezas, cuadrantes, (Grid3.SelectedItems.Count = 0) And (chbUrgente3.Checked = True), ImporteTrat, False, Fecha, Nothing)
            If Not (PresupuestoLinea Is Nothing) Then
                ImporteTotal = ImporteTotal + PresupuestoLinea.Importe
                lblImporte.Text = "Importe total: " + ImporteTotal.ToString("0.00")
                'ACTUALIZAR GRID
                For i As Integer = 0 To CuadARepresentar.Length - 1
                    RepresentAction(odont, CodigoTrat, CuadARepresentar(i), piezas, cColor)
                    If chbVerPresupuesto.Checked = True Then
                        RepresentAction(Odontograma1, CodigoTrat, CuadARepresentar(i), piezas, cColor)
                    End If
                Next
                cuadrantes = ""
            Else
                fResult = False
            End If
        End If
        Return fResult
    End Function
    'GENERA EL STRING CON LAS PIEZAS, DEPENDIENDO DE SI ES MULTIPLE, LA PIEZA DE INICIO Y FIN, Y LAS PIEZAS ASOCIADAS AL TRATAMIENTO
    Private Function getPiezas(ByVal pieza1 As Integer, ByVal pieza2 As Integer) As String
        Dim piezas As String = ""
        If (pieza2 = 0) And (pieza1 > 0) Then 'UNA UNICA PIEZA
            piezas = pieza1.ToString()
        ElseIf pieza2 > 0 Then 'RANGO DE PIEZAS, PUEDEN HABER PIEZAS INTERMEDIAS NO DISPONIBLES
            If (pieza1 \ 10) = (pieza2 \ 10) Then 'LAS DOS PIEZAS ESTAN EN EL MISMO CUADRANTE
                Dim primeraPieza As Integer = Min(pieza1, pieza2)
                Dim nuevoRango As Boolean = False
                For i As Integer = Min(pieza1, pieza2) To Max(pieza1, pieza2)
                    If (ctpiezas(i) = False) And (nuevoRango = False) Then
                        If primeraPieza <> (i - 1) Then
                            piezas = piezas + primeraPieza.ToString() + "-" + (i - 1).ToString() + ","
                        Else
                            piezas = primeraPieza.ToString() + ","
                        End If
                        primeraPieza = 0
                        nuevoRango = True
                    ElseIf (ctpiezas(i) = True) And (nuevoRango = True) Then
                        primeraPieza = i
                        nuevoRango = False
                    End If
                Next
                If primeraPieza <> Max(pieza1, pieza2) Then
                    piezas = piezas + primeraPieza.ToString() + "-" + Max(pieza1, pieza2).ToString()
                Else
                    piezas = primeraPieza.ToString()
                End If
            Else 'LAS DOS PIEZAS ESTAN EN CUADRANTES DIFERENTES

                'PRIMER CUADRANTE
                Dim primeraPieza As Integer = pieza1
                Dim nuevoRango As Boolean = False
                For i As Integer = pieza1 To (pieza1 \ 10) * 10 + 1 Step -1
                    If (ctpiezas(i) = False) And (nuevoRango = False) Then
                        If primeraPieza <> (i + 1) Then
                            piezas = piezas + primeraPieza.ToString() + "-" + (i + 1).ToString() + ","
                        Else
                            piezas = primeraPieza.ToString() + ","
                        End If
                        primeraPieza = 0
                        nuevoRango = True
                    ElseIf (ctpiezas(i) = True) And (nuevoRango = True) Then
                        primeraPieza = i
                        nuevoRango = False
                    End If
                Next

                'ENLACE
                If (ctpiezas((pieza2 \ 10) * 10 + 1) = False) Then
                    If primeraPieza <> ((pieza1 \ 10) * 10 + 1) Then
                        piezas = piezas + primeraPieza.ToString() + "-" + Max(pieza1, pieza2).ToString() + ","
                    Else
                        piezas = primeraPieza.ToString() + ","
                    End If
                    primeraPieza = 0
                    nuevoRango = True
                End If

                'SEGUNDO CUADRANTE
                For i As Integer = (pieza2 \ 10) * 10 + 1 To pieza2
                    If (ctpiezas(i) = False) And (nuevoRango = False) Then
                        If primeraPieza <> (i - 1) Then
                            piezas = piezas + primeraPieza.ToString() + "-" + (i - 1).ToString() + ","
                        Else
                            piezas = primeraPieza.ToString() + ","
                        End If
                        primeraPieza = 0
                        nuevoRango = True
                    ElseIf (ctpiezas(i) = True) And (nuevoRango = True) Then
                        primeraPieza = i
                        nuevoRango = False
                    End If
                Next

                'FIN
                If primeraPieza <> pieza2 Then
                    piezas = piezas + primeraPieza.ToString() + "-" + pieza2.ToString()
                Else
                    piezas = primeraPieza.ToString()
                End If
            End If
        End If
        Return piezas
    End Function


#Region "Private Function CantidadPiezas(ByVal pieceNumbers As String) As Integer"
    'CUENTA LA CANTIDAD DE PIEZAS QUE HAY EN EL CAMPO PIEZAS (STRING)
    Private Function CantidadPiezas(ByVal pieceNumbers As String) As Integer
        If (pieceNumbers = "") Or (pieceNumbers = Nothing) Then
            Return 1
        Else
            Dim totalPiezas As Integer = 0
            Dim lastIndex As Integer = 0 'ULTIMO INDEX EN LA CADENA
            Dim lastPiece As Integer = 0 'ULTIMA PIEZA CUANDO ES MULTIPLES
            Dim actualPiece As Integer = 0 'PIEZA ACTUAL
            For i As Integer = 0 To pieceNumbers.Length
                If (i = pieceNumbers.Length) OrElse (pieceNumbers(i) = ",") Then
                    If lastPiece > 0 Then
                        actualPiece = Convert.ToInt32(pieceNumbers.Substring(lastIndex, i - lastIndex))
                        If (actualPiece \ 10) = (lastPiece \ 10) Then
                            totalPiezas = totalPiezas + Abs(actualPiece - lastPiece) + 1
                        Else
                            totalPiezas = totalPiezas + (lastPiece Mod 10) + (actualPiece Mod 10)
                        End If
                    Else
                        totalPiezas = totalPiezas + 1
                    End If
                    lastPiece = 0
                    lastIndex = i + 1
                ElseIf pieceNumbers(i) = "-" Then
                    lastPiece = Convert.ToInt32(pieceNumbers.Substring(lastIndex, i - lastIndex))
                    lastIndex = i + 1
                End If
            Next
            Return totalPiezas
        End If
    End Function
#End Region


    'REPRESENTAR UNA ACCION O LINEA DE PRESUPUESTO EN EL ODONTOGRAMA
    Private Sub RepresentAction(ByRef odont As Odontograma, ByVal CodigoTrat As String, ByVal cCuad As Char, ByVal Piezas As String, ByVal pColor As Color)
        Dim classOdontograma As New ClasesOdontogramaDataContext
        If (cCuad = "") Or (cCuad = Nothing) Then
            cCuad = "C"
        ElseIf cCuad = "O" Then
            cCuad = "I"
        End If
        Dim img_cfra As md_d_ConceptoFra_Imagen = classOdontograma.GetSingleImgCFra(CodigoTrat, cCuad)
        If Not (img_cfra Is Nothing) Then
            odont.AddOperation(Piezas, img_cfra.IDImagen, img_cfra.Pintar, pColor)  'img_cfra..d_Imagen.Imagen.ToArray()
        End If
    End Sub
    'ADICIONA UNA ACCION (EN EL ODONTOGRAMA REALIZADOS O EN PRIMERA VISITA) A LA BASE DE DATOS
    Private Function AddActionOnDB(ByVal Concepto As Integer, ByVal Fecha As DateTime, ByVal IDTratamiento As String, ByVal DescTratamiento As String, ByVal Piezas As String, ByVal Cuadrantes As String, ByVal Doctor As Integer) As md_d_Accion
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim accion As md_d_Accion = New md_d_Accion()
        If rbnTemporal.Checked = True Then
            accion.IDOdontograma = OdontogramaID(0)
        Else
            accion.IDOdontograma = OdontogramaID(1)
        End If
        accion.FechaEjecucion = Fecha
        accion.IDMedico = Doctor
        If Concepto = 1 Then
            accion.IDGabinete = 1
        Else
            accion.IDGabinete = -1
        End If
        accion.IDTratamiento = IDTratamiento
        accion.Cuadrantes = Cuadrantes
        accion.PiezasInvolucradas = Piezas
        Dim texto As String = DescTratamiento
        If Piezas <> "" Then
            texto = texto + ", Piezas: " + Piezas
        End If
        If Cuadrantes <> "" Then
            texto = texto + ", Cuadrantes: " + Cuadrantes
        End If
        texto = texto + ", Fecha: " + Format(Fecha, "dd/MM/yyyy")
        If texto.Length > 250 Then
            texto = texto.Substring(1, 250)
        End If
        accion.DescripcionGenerada = texto
        classOdontograma.md_d_Accions.InsertOnSubmit(accion)
        Try
            classOdontograma.SubmitChanges()
            Return accion
        Catch e As Exception
            MsgBox("Error al adicionar acción: " + e.ToString())
            Return Nothing
        End Try
    End Function
    'VERIFICA SI EL ULTIMO PRESUPUESTO ES DE LA FECHA ESPECIFICADO, EN CASO CONTRARIO CREA UNO
    Private Function getPresupuestoDate(ByVal Fecha As DateTime) As Integer
        Dim Presupuesto As md_d_Presupuesto
        If tvwPresupuestos.Nodes.Count > 0 Then
            For i As Integer = 0 To tvwPresupuestos.Nodes.Count - 1
                Presupuesto = TryCast(tvwPresupuestos.Nodes.Item(i).Tag, md_d_Presupuesto)
                If Presupuesto.FechaConcepcion = Fecha Then
                    tvwPresupuestos.SelectedNode = tvwPresupuestos.Nodes.Item(i)
                    Return Presupuesto.IDPresupuesto
                    Exit Function
                End If
            Next
        End If
        Presupuesto = AddPresupuestoOnDB(Fecha)

        Dim NumPre As Integer = 0
        For Each nodo As TreeNode In tvwPresupuestos.Nodes
            If nodo.Text.Contains(Format(Presupuesto.FechaConcepcion, "dd/MM/yyyy")) Then NumPre += 1
        Next
        Dim tnode As TreeNode = tvwPresupuestos.Nodes.Add("P" & NumPre + 1 & " - " & Format(Presupuesto.FechaConcepcion, "dd/MM/yyyy"))
        tnode.Tag = Presupuesto
        tvwPresupuestos.SelectedNode = tvwPresupuestos.Nodes.Item(tvwPresupuestos.Nodes.Count - 1)
        Return Presupuesto.IDPresupuesto
    End Function
    'ADICIONA UN PRESUPUESTO EN LA BASE DE DATOS
    Private Function AddPresupuestoOnDB(ByVal Fecha As DateTime) As md_d_Presupuesto
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim Presupuesto As md_d_Presupuesto = New md_d_Presupuesto()
        If rbnTemporal.Checked = True Then
            Presupuesto.IDOdontograma = OdontogramaID(0)
        Else
            Presupuesto.IDOdontograma = OdontogramaID(1)
        End If
        Presupuesto.FechaConcepcion = Fecha

        CtrlMutua1.ID_Mutuas = Nothing
        
        classOdontograma.md_d_Presupuestos.InsertOnSubmit(Presupuesto)
        Try
            classOdontograma.SubmitChanges()
            Return Presupuesto
        Catch e As Exception
            MsgBox("Error al adicionar presupuesto: " + e.ToString())
            Return Nothing
        End Try
    End Function

    Private Function UsarImportePorPieza(ByVal idTratamiento As String)
        Try
            Dim context As New CMLinqDataContext
            Dim tratamiento As CONCEPTOSFRA = (From c In context.CONCEPTOSFRAs Where c.CODIGO = idTratamiento Select c).SingleOrDefault

            Dim doc As XDocument = XDocument.Parse(tratamiento.XMLCont)
            Dim tratNode As XElement = doc.Element("Tratamiento")

            If tratNode.Attribute("ImportePorPieza") Is Nothing Then
                Return False
            Else
                Return tratNode.Attribute("ImportePorPieza").Value
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function


    'ADICIONA UNA LINEA DE PRESUPUESTO A LA BD (NUNCA SE PUEDE INSERTAR DIRECTAMENTE EN PENDIENTES)
    Private Function AddPresupuestoLineaOnDB(ByVal Presupuesto As Integer, ByVal IDTratamiento As String, ByVal DescTratamiento As String, ByVal Piezas As String, ByVal Cuadrantes As String, ByVal Urgente As Boolean, ByVal Importe As Double, ByVal realizado As Boolean, ByVal Fecha As DateTime, ByVal IDAccionOrigen As Nullable(Of Integer)) As md_d_PresupuestoLinea
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim PresupuestoLinea As md_d_PresupuestoLinea = New md_d_PresupuestoLinea()
        PresupuestoLinea.IDPresupuesto = Presupuesto
        PresupuestoLinea.IDTratamiento = IDTratamiento
        Dim texto As String = DescTratamiento
        If Piezas <> "" Then
            texto = texto + ", Piezas: " + Piezas
        End If
        If Cuadrantes <> "" Then
            texto = texto + ", Cuadrantes: " + Cuadrantes
        End If
        texto = texto + ", Fecha: " + Format(Fecha, "dd/MM/yyyy")
        If texto.Length > 250 Then
            texto = texto.Substring(1, 250)
        End If
        PresupuestoLinea.DescripcionGenerada = texto
        PresupuestoLinea.Cuadrantes = Cuadrantes
        PresupuestoLinea.PiezasInvolucradas = Piezas
        PresupuestoLinea.Realizado = realizado
        PresupuestoLinea.Confirmado = realizado
        PresupuestoLinea.DescuentoPercent = currentDescuentoPorciento
        If realizado Then
            PresupuestoLinea.FechaConfirmado = Fecha
            PresupuestoLinea.FechaRealizado = Fecha
        End If
        PresupuestoLinea.TipoDenticion = If(rbnTemporal.Checked, 0, 1)
       

        'Hay que ver si el presupuesto tiene ImportePorPiezas
        'If UsarImportePorPieza(IDTratamiento) Then
        '    PresupuestoLinea.Importe = Importe * Convert.ToSingle(CantidadPiezas(Piezas))
        'Else
        PresupuestoLinea.Importe = Importe
        'End If

        If Urgente = True Then
            PresupuestoLinea.Urgencia = 1
            PresupuestoLinea.IDAccionOrigen = IDAccionOrigen
        Else
            PresupuestoLinea.Urgencia = 0
        End If
        classOdontograma.md_d_PresupuestoLineas.InsertOnSubmit(PresupuestoLinea)
        Try
            classOdontograma.SubmitChanges()
            Return PresupuestoLinea
        Catch e As Exception
            MsgBox("Error al adicionar línea de presupuesto: " + e.ToString())
            Return Nothing
        End Try
    End Function
    'ADICIONAR UNA ACCION A CUALQUIERA DE LOS DOS LISTADOS 
    Private Function AddItemAccion(ByVal Concepto As Integer, ByVal Accion As md_d_Accion, ByVal DesTratamiento As String) As ListViewItem
        Dim LI As ListViewItem
        If Concepto = 1 Then
            LI = lvw1.Items.Add(Format(Accion.FechaEjecucion, "dd/MM/yyyy"))
        Else
            LI = lvw4.Items.Add(Format(Accion.FechaEjecucion, "dd/MM/yyyy"))
        End If
        LI.SubItems.Add(DesTratamiento)
        LI.SubItems.Add(Accion.PiezasInvolucradas)
        LI.SubItems.Add(Accion.Cuadrantes)
        LI.SubItems.Add(Accion.IDMedico.ToString())
        LI.ImageIndex = imgIndex.Realizado

        LI.Tag = Accion
        Return LI
    End Function
    'ADICIONAR UN PRESUPUESTO AL LISTADO DE PENDIENTES
    Private Function AddItemPresupuesto(ByVal Presupuesto As md_d_PresupuestoLinea, ByVal DesTratamiento As String) As ListViewItem
        Dim LI As ListViewItem
        LI = lvw2.Items.Add(Format(Presupuesto.FechaConfirmado, "dd/MM/yyyy"))
        LI.SubItems.Add(DesTratamiento)
        LI.SubItems.Add(Presupuesto.PiezasInvolucradas)
        LI.SubItems.Add(Presupuesto.Cuadrantes)
        If Presupuesto.Urgencia = 1 Then
            LI.ImageIndex = imgIndex.ConfirmadoUrgente
        Else
            LI.ImageIndex = imgIndex.Confirmado
        End If

        If Presupuesto.Urgencia = 1 Then
            LI.UseItemStyleForSubItems = True
            LI.ForeColor = Color.Red
            LI.Font = New Font(LI.Font, FontStyle.Bold)
        End If
        LI.Tag = Presupuesto
        Return LI
    End Function
    'CARGAR LOS TRATAMIENTOS DE UN LISTADO EN UN ODONTOGRAMA
    Private Sub ActualizaOdontogramaDesdeLista(ByRef odont As Odontograma, ByRef lvw As ListView)
        Dim cuad As String
        Dim cColor As Color
        Dim idx_list As Integer = Convert.ToInt32(lvw.Tag)
        Dim idx_odont As Integer = Convert.ToInt32(odont.Tag)
        Dim accion As md_d_Accion
        Dim presupuesto As md_d_PresupuestoLinea
        Dim IDTrat As String

        If (idx_odont = idx_list) Then
            odont.Reset()
        End If

        If (idx_odont = 1) And (idx_list = 1) Then 'SI ES EL ODONTOGRAMA1 HAY QUE CARGAR PRIMERO LA PRIMERA VISITA
            ActualizaOdontogramaDesdeLista(Odontograma1, lvw4)
        End If

        If (idx_odont = 1) And (idx_list = 3) Then
            ActualizaOdontogramaPendienteSinConfirmar()
        Else
            Dim idxcol As Integer = 3
            If idx_list = 3 Then
                idxcol = 2
            End If
            For i As Integer = 0 To lvw.Items.Count - 1
                cuad = lvw.Items(i).SubItems(idxcol).Text
                cColor = oColores(idx_list - 1)
                If idx_list = 3 Then
                    Select Case lvw.Items(i).ImageIndex
                        Case imgIndex.Realizado
                            cColor = oColores(0)
                        Case imgIndex.Confirmado
                            cColor = oColores(1)
                        Case imgIndex.ConfirmadoUrgente
                            cColor = oColores(4)
                        Case imgIndex.LineaPresupuesto
                            cColor = oColores(2)
                        Case imgIndex.LineaPresupuestoUrgente
                            cColor = oColores(4)
                    End Select
                End If

                If (idx_list = 1) Or (idx_list = 4) Then
                    accion = TryCast(lvw.Items(i).Tag, md_d_Accion)
                    IDTrat = accion.IDTratamiento
                Else
                    presupuesto = TryCast(lvw.Items(i).Tag, md_d_PresupuestoLinea)
                    IDTrat = presupuesto.IDTratamiento
                    If (idx_list = 2) And (presupuesto.Urgencia = 1) Then
                        cColor = oColores(4)
                    End If
                End If

                If cuad <> "" Then
                    For j As Integer = 0 To cuad.Length - 1
                        RepresentAction(odont, IDTrat, cuad(j), lvw.Items(i).SubItems(idxcol - 1).Text, cColor)
                    Next
                Else
                    RepresentAction(odont, IDTrat, "C", lvw.Items(i).SubItems(idxcol - 1).Text, cColor)
                End If
            Next
        End If

        If (idx_odont = 1) And (idx_list = 1) And (chbVerPendientes.Checked = True) Then
            ActualizaOdontogramaDesdeLista(Odontograma1, lvw2)
        End If

        If (idx_odont = 1) And (idx_list = 1) And (chbVerPresupuesto.Checked = True) Then
            ActualizaOdontogramaPendienteSinConfirmar()
        End If
    End Sub
    'CARGAR LOS TRATAMIENTOS DE UN GRID EN UN ODONTOGRAMA
    Private Sub ActualizaOdontogramaDesdeGrid(ByRef odont As Odontograma, ByRef lvw As ListView)
        Dim cuad As String
        Dim cColor As Color
        Dim idx_list As Integer = Convert.ToInt32(lvw.Tag)
        Dim idx_odont As Integer = Convert.ToInt32(odont.Tag)
        Dim accion As md_d_Accion
        Dim presupuesto As md_d_PresupuestoLinea
        Dim IDTrat As String

        If (idx_odont = idx_list) Then
            odont.Reset()
        End If

        If (idx_odont = 1) And (idx_list = 1) Then 'SI ES EL ODONTOGRAMA1 HAY QUE CARGAR PRIMERO LA PRIMERA VISITA
            ActualizaOdontogramaDesdeLista(Odontograma1, lvw4)
        End If


        Dim idxcol As Integer = 3

        For i As Integer = 0 To lvw.Items.Count - 1
            cuad = lvw.Items(i).SubItems(idxcol).Text
            cColor = oColores(idx_list - 1)

            If (idx_list = 1) Or (idx_list = 4) Then
                accion = TryCast(lvw.Items(i).Tag, md_d_Accion)
                IDTrat = accion.IDTratamiento
            Else
                presupuesto = TryCast(lvw.Items(i).Tag, md_d_PresupuestoLinea)
                IDTrat = presupuesto.IDTratamiento
                If (idx_list = 2) And (presupuesto.Urgencia = 1) Then
                    cColor = oColores(4)
                End If
            End If

            If cuad <> "" Then
                For j As Integer = 0 To cuad.Length - 1
                    RepresentAction(odont, IDTrat, cuad(j), lvw.Items(i).SubItems(idxcol - 1).Text, cColor)
                Next
            Else
                RepresentAction(odont, IDTrat, "C", lvw.Items(i).SubItems(idxcol - 1).Text, cColor)
            End If
        Next


        If (idx_odont = 1) And (idx_list = 1) And (chbVerPendientes.Checked = True) Then
            ActualizaOdontogramaDesdeLista(Odontograma1, lvw2)
        End If

        If (idx_odont = 1) And (idx_list = 1) And (chbVerPresupuesto.Checked = True) Then
            ActualizaOdontogramaPendienteSinConfirmar()
        End If
    End Sub
    Private Sub ActualizaOdontogramaPendienteSinConfirmar()
        Dim ID As Integer
        If rbnTemporal.Checked = True Then
            ID = OdontogramaID(0)
        Else
            ID = OdontogramaID(1)
        End If
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim sinconfirmar As IEnumerable(Of md_d_PresupuestoLinea) = classOdontograma.GetLineasSinConfirmar(ID)
        Dim aColor As Color
        For Each linea As md_d_PresupuestoLinea In sinconfirmar
            If linea.Urgencia = 1 Then
                aColor = oColores(4)
            Else
                aColor = oColores(2)
            End If
            If linea.Cuadrantes <> "" Then
                For i As Integer = 0 To linea.Cuadrantes.Length - 1
                    RepresentAction(Odontograma1, linea.IDTratamiento, linea.Cuadrantes(i), linea.PiezasInvolucradas, aColor)
                Next
            Else
                RepresentAction(Odontograma1, linea.IDTratamiento, "C", linea.PiezasInvolucradas, aColor)
            End If
        Next
    End Sub
    'ELIMINAR UNA ACCION O PRESUPUESTO
    Private Sub cmEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmEliminar.Click
        If MsgBox("La operación es irreversible ¿Desea continuar?", MsgBoxStyle.YesNo, "Confirmación de borrado") = MsgBoxResult.Yes Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim accion As md_d_Accion
            Dim presupuesto As md_d_PresupuestoLinea

            Try
                Select Case tbc.SelectedIndex
                    Case 0
                        For i As Integer = lvw1.SelectedItems.Count - 1 To 0 Step -1
                            accion = classOdontograma.GetAccionByID(TryCast(lvw1.SelectedItems(i).Tag, md_d_Accion).IDAccion)

                            Try
                                'Hay que borrar la linea de presupuesto asociada
                                Dim lineap As md_d_PresupuestoLinea = (From l In classOdontograma.md_d_PresupuestoLineas Where l.IDAccionOrigen = accion.IDAccion _
                                                                      Select l).SingleOrDefault()
                                If Not lineap Is Nothing Then
                                    classOdontograma.md_d_PresupuestoLineas.DeleteOnSubmit(lineap)
                                    classOdontograma.SubmitChanges()
                                    CargarPresupuestos()
                                End If
                            Catch ex As Exception

                            End Try


                            classOdontograma.md_d_Accions.DeleteOnSubmit(accion)

                        Next
                    Case 1
                        For i As Integer = lvw2.SelectedItems.Count - 1 To 0 Step -1
                            presupuesto = classOdontograma.GetLineaPresupuestoByID(TryCast(lvw2.SelectedItems(i).Tag, md_d_PresupuestoLinea).IDPresupuestoLinea)
                            classOdontograma.md_d_PresupuestoLineas.DeleteOnSubmit(presupuesto)
                        Next
                    Case 2
                        For i As Integer = Grid3.SelectedItems.Count - 1 To 0 Step -1
                            presupuesto = classOdontograma.GetLineaPresupuestoByID(CType(Grid3.SelectedItems(i).GetRow().Cells("IDPresupuestoLinea").Value, Integer))
                            classOdontograma.md_d_PresupuestoLineas.DeleteOnSubmit(presupuesto)
                        Next
                    Case 3
                        For i As Integer = lvw4.SelectedItems.Count - 1 To 0 Step -1
                            accion = classOdontograma.GetAccionByID(TryCast(lvw4.SelectedItems(i).Tag, md_d_Accion).IDAccion)
                            classOdontograma.md_d_Accions.DeleteOnSubmit(accion)
                        Next
                End Select
                classOdontograma.SubmitChanges()
                Select Case tbc.SelectedIndex
                    Case 0
                        For i As Integer = lvw1.SelectedItems.Count - 1 To 0 Step -1
                            lvw1.SelectedItems(i).Remove()
                        Next
                        ActualizaOdontogramaDesdeLista(Odontograma1, lvw1)
                    Case 1
                        For i As Integer = lvw2.SelectedItems.Count - 1 To 0 Step -1
                            lvw2.SelectedItems(i).Remove()
                        Next
                        ActualizaOdontogramaDesdeLista(Odontograma2, lvw2)
                        MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
                    Case 2
                        MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
                    Case 3
                        For i As Integer = lvw4.SelectedItems.Count - 1 To 0 Step -1
                            lvw4.SelectedItems(i).Remove()
                        Next
                        ActualizaOdontogramaDesdeLista(Odontograma4, lvw4)
                        ActualizaOdontogramaDesdeLista(Odontograma1, lvw1)
                End Select
            Catch ex As Exception
                MsgBox("Error al eliminar: " + ex.ToString())
            End Try
        End If
    End Sub
    'MOVER A PENDIENTE DESDE UNA LINEA DE PRESUPUESTO
    Private Sub cmAPendiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmAPendiente.Click
        If MsgBox("La operación es irreversible ¿Desea continuar?", MsgBoxStyle.YesNo, "Confirmación de movimiento") = MsgBoxResult.Yes Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim presupuestoLinea As md_d_PresupuestoLinea
            Dim aColor As Color

            Try
                For i As Integer = Grid3.SelectedItems.Count - 1 To 0 Step -1
                    presupuestoLinea = classOdontograma.GetLineaPresupuestoByID(CType(Grid3.SelectedItems(i).GetRow().Cells("IDPresupuestoLinea").Value, Integer))
                    If (presupuestoLinea.Realizado = False) And (presupuestoLinea.Confirmado = False) Then
                        presupuestoLinea.Confirmado = True
                        presupuestoLinea.FechaConfirmado = dtpFecha.Value
                        classOdontograma.SubmitChanges()
                        If presupuestoLinea.Urgencia = 1 Then
                            aColor = oColores(4)
                            Grid3.SelectedItems(i).GetRow().Cells("icon").ImageIndex = imgIndex.ConfirmadoUrgente
                        Else
                            aColor = oColores(1)
                            Grid3.SelectedItems(i).GetRow().Cells("icon").ImageIndex = imgIndex.Confirmado
                        End If

                        AddItemPresupuesto(presupuestoLinea, presupuestoLinea.DescripcionGenerada)
                        If presupuestoLinea.Cuadrantes <> "" Then
                            For j As Integer = 0 To presupuestoLinea.Cuadrantes.Length - 1
                                RepresentAction(Odontograma2, presupuestoLinea.IDTratamiento, presupuestoLinea.Cuadrantes(j), presupuestoLinea.PiezasInvolucradas, aColor)
                            Next
                        Else
                            RepresentAction(Odontograma2, presupuestoLinea.IDTratamiento, "C", presupuestoLinea.PiezasInvolucradas, aColor)
                        End If
                    End If
                Next
                MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
            Catch ex As Exception
                MsgBox("Error al mover a pendiente: " + ex.ToString())
            End Try
        End If
    End Sub
    'MOVER A REALIZADO DESDE UNA LINEA DE PRESUPUESTO O PENDIENTE
    Private Sub cmARealizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmARealizado.Click
        If MsgBox("La operación es irreversible ¿Desea continuar?", MsgBoxStyle.YesNo, "Confirmación de movimiento") = MsgBoxResult.Yes Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim presupuestoLinea As md_d_PresupuestoLinea
            Dim accion As md_d_Accion
            Dim lvw As ListView = lvw2
            Dim desTrat As String
            Dim desTratIndex As Integer = 0

            Try
                If tbc.SelectedIndex = 1 Then
                    desTratIndex = 1

                    For i As Integer = lvw.SelectedItems.Count - 1 To 0 Step -1
                        presupuestoLinea = classOdontograma.GetLineaPresupuestoByID(TryCast(lvw.SelectedItems(i).Tag, md_d_PresupuestoLinea).IDPresupuestoLinea)
                        If presupuestoLinea.Realizado = False Then
                            presupuestoLinea.Realizado = True
                            presupuestoLinea.FechaRealizado = dtpFecha.Value
                            classOdontograma.SubmitChanges()
                            desTrat = lvw.SelectedItems(i).SubItems(desTratIndex).Text
                            lvw.SelectedItems(i).Remove()
                            accion = AddActionOnDB(1, dtpFecha.Value, presupuestoLinea.IDTratamiento, presupuestoLinea.DescripcionGenerada, presupuestoLinea.PiezasInvolucradas, presupuestoLinea.Cuadrantes, SelDoctor)
                            If Not (accion Is Nothing) Then
                                AddItemAccion(1, accion, desTrat)
                                If accion.Cuadrantes <> "" Then
                                    For j As Integer = 0 To accion.Cuadrantes.Length - 1
                                        RepresentAction(Odontograma1, accion.IDTratamiento, accion.Cuadrantes(j), accion.PiezasInvolucradas, oColores(0))
                                    Next
                                Else
                                    RepresentAction(Odontograma1, accion.IDTratamiento, "C", accion.PiezasInvolucradas, oColores(0))
                                End If
                            End If
                        End If
                    Next
                Else
                    For i As Integer = Grid3.SelectedItems.Count - 1 To 0 Step -1
                        presupuestoLinea = classOdontograma.GetLineaPresupuestoByID(CType(Grid3.SelectedItems(i).GetRow().Cells("IDPresupuestoLinea").Value, Integer))
                        If presupuestoLinea.Realizado = False Then
                            presupuestoLinea.Realizado = True
                            presupuestoLinea.FechaRealizado = dtpFecha.Value
                            classOdontograma.SubmitChanges()
                            desTrat = presupuestoLinea.DescripcionGenerada
                            Grid3.SelectedItems(i).GetRow().Cells("icon").ImageIndex = imgIndex.Realizado
                            accion = AddActionOnDB(1, dtpFecha.Value, presupuestoLinea.IDTratamiento, presupuestoLinea.DescripcionGenerada, presupuestoLinea.PiezasInvolucradas, presupuestoLinea.Cuadrantes, SelDoctor)
                            If Not (accion Is Nothing) Then
                                AddItemAccion(1, accion, desTrat)
                                If accion.Cuadrantes <> "" Then
                                    For j As Integer = 0 To accion.Cuadrantes.Length - 1
                                        RepresentAction(Odontograma1, accion.IDTratamiento, accion.Cuadrantes(j), accion.PiezasInvolucradas, oColores(0))
                                    Next
                                Else
                                    RepresentAction(Odontograma1, accion.IDTratamiento, "C", accion.PiezasInvolucradas, oColores(0))
                                End If
                            End If
                        End If
                    Next
                End If
                CargarListaPendiente()
                MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
            Catch ex As Exception
                MsgBox("Error al mover a realizado: " + ex.ToString())
            End Try
        End If
    End Sub
    'CUANDO SE EL MENU ASOCIADO A LOS LISTADOS ES MOSTRAR ACTUALIZAR EL ESTADO DE SUS ITEMS
    Private Sub cMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cMenu.Opening
        Dim iindex As Integer
        Select Case tbc.SelectedIndex
            Case 0
                cmEliminar.Enabled = (lvw1.SelectedItems.Count > 0)
                cmAPendiente.Visible = False
                cmARealizado.Visible = False
                cmNTratamiento.Enabled = chbHabilitar.Checked
                cmVerCita.Visible = False
            Case 1
                cmEliminar.Enabled = (lvw2.SelectedItems.Count > 0)
                cmAPendiente.Visible = False
                cmARealizado.Visible = True
                cmARealizado.Enabled = (lvw2.SelectedItems.Count > 0)
                cmNTratamiento.Enabled = False
                cmVerCita.Visible = False
            Case 2
                If Grid3.SelectedItems.Count > 0 Then
                    iindex = Grid3.SelectedItems(0).GetRow().Cells("icon").ImageIndex
                End If
                cmEliminar.Enabled = (Grid3.SelectedItems.Count > 0)
                cmAPendiente.Visible = True
                cmARealizado.Visible = True
                cmAPendiente.Enabled = (Grid3.SelectedItems.Count > 0) AndAlso ((iindex = imgIndex.LineaPresupuesto) Or (iindex = imgIndex.LineaPresupuestoUrgente))
                cmARealizado.Enabled = (Grid3.SelectedItems.Count > 0) AndAlso ((iindex = imgIndex.LineaPresupuesto) Or (iindex = imgIndex.LineaPresupuestoUrgente) Or (iindex = imgIndex.Confirmado) Or (iindex = imgIndex.ConfirmadoUrgente))
                cmNTratamiento.Enabled = Not (tvwPresupuestos.SelectedNode Is Nothing)
                cmVerCita.Visible = True
                Try
                    cmVerCita.Enabled = (Grid3.SelectedItems.Count > 0) AndAlso (CInt(Grid3.SelectedItems(0).GetRow().Cells("IDCITA").Value) > 0)
                Catch ex As Exception
                    cmVerCita.Enabled = False
                End Try

            Case 3
                cmEliminar.Enabled = (lvw4.SelectedItems.Count > 0)
                cmAPendiente.Visible = False
                cmARealizado.Visible = False
                cmNTratamiento.Enabled = (PrimeraVisitaFree = True) Or (lvw1.Items.Count = 0)
                cmVerCita.Visible = False
        End Select

        cMenu.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)
        cmEliminar.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)
        cmEliminar.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Modificar)

        cmNTratamiento.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        cmNTratamiento.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        'btnFi.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        cmAPendiente.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        cmAPendiente.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        cmARealizado.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)
        cmARealizado.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        cmVerCita.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)
        cmVerCita.Visible = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Ninguno)

        chbUrgente3.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)


    End Sub
    'CUANDO SE SELECCIONA EL BOTON OPERACIONES MOSTRAR LA INTERFAZ 
    Private Sub tstOperaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstOperaciones.Click
        Dim foperaciones As New frmOperaciones()
        foperaciones.catDental = CategoriaDental
        foperaciones.ShowDialog(Me)
        'ESTAS SENTENCIAS NO SE TIENEN EN CUENTA SI NO SE LLAMA EL FORM DESDE EL ODONTROGRAMA
        CheckImagesOnDisk()
        CargarOperaciones()
        CargarTodosTratamientos()
        ActualizaOdontogramaDesdeLista(Odontograma1, lvw1)
        ActualizaOdontogramaDesdeLista(Odontograma2, lvw2)
        MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
        ActualizaOdontogramaDesdeLista(Odontograma4, lvw4)
    End Sub
    'CUANDO SE SELECCIONA EL BOTON COLORES MOSTRAR LA INTERFAZ 
    Private Sub tstColores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstColores.Click
        Dim fcolor As New frmColores()
        If fcolor.ShowDialog(Me) = DialogResult.OK Then
            'ESTAS SENTENCIAS NO SE TIENEN EN CUENTA SI NO SE LLAMA EL FORM DESDE EL ODONTROGRAMA
            CargarColores()
            ActualizaOdontogramaDesdeLista(Odontograma1, lvw1)
            ActualizaOdontogramaDesdeLista(Odontograma2, lvw2)
            MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
            ActualizaOdontogramaDesdeLista(Odontograma4, lvw4)
        End If
    End Sub
    'SALIR
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub
    'CUANDO CAMBIA LA SELECCION DE LA ACCION SELECCIONADA, MOSTRAR SU DESCRIPCION
    Private Sub lvw1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw1.SelectedIndexChanged
        rtb1.Enabled = lvw1.SelectedItems.Count > 0
        If lvw1.SelectedItems.Count > 0 Then
            Dim accion As md_d_Accion = TryCast(lvw1.SelectedItems(0).Tag, md_d_Accion)
            rtb1.Text = accion.DescripcionGenerada
        Else
            rtb1.Clear()
        End If
    End Sub
    'CUANDO CAMBIA LA SELECCION DEL PENDIENTE SELECCIONADO, MOSTRAR SU DESCRIPCION
    Private Sub lvw2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw2.SelectedIndexChanged
        rtb2.Enabled = lvw2.SelectedItems.Count > 0
        If lvw2.SelectedItems.Count > 0 Then
            Dim presupuestoLinea As md_d_PresupuestoLinea = TryCast(lvw2.SelectedItems(0).Tag, md_d_PresupuestoLinea)
            chbUrgente2.Checked = (presupuestoLinea.Urgencia = 1)
            rtb2.Text = presupuestoLinea.DescripcionGenerada
        Else
            chbUrgente2.Checked = False
            rtb2.Clear()
        End If
    End Sub

    Dim accion As String = "ver"
    'CUANDO CAMBIA LA SELECCION DE LA LINEA DE PRESUPUESTO SELECCIONADA, MOSTRAR SU DESCRIPCION
    Private Sub Grid3_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid3.SelectionChanged
        If Not Grid3.SelectedItems.Count > 0 Or accion = "insertar" Then Exit Sub
        rtb3.Enabled = Grid3.SelectedItems.Count > 0
        chbUrgente3.Enabled = (Grid3.SelectedItems.Count = 0) Or ((Grid3.SelectedItems.Count > 0) AndAlso ((Grid3.SelectedItems(0).GetRow().Cells("icon").ImageIndex = imgIndex.LineaPresupuesto) Or (Grid3.SelectedItems(0).GetRow().Cells("icon").ImageIndex = imgIndex.LineaPresupuestoUrgente)))
        If Grid3.SelectedItems.Count > 0 Then
            chbUrgente3.Checked = CType(Grid3.SelectedItems(0).GetRow().Cells("Urgencia").Value, Integer) = 1
            'If Not (Grid3.SelectedItems(0).GetRow().Cells("DescripcionGenerada").Value Is Nothing) Then
            '    rtb3.Text = CType(Grid3.SelectedItems(0).GetRow().Cells("DescripcionGenerada").Value, String)
            'Else
            '    rtb3.Clear()
            'End If
        Else
            chbUrgente3.Checked = False
            rtb3.Clear()
        End If
        chbUrgente3.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Dental) > RoleManager.TipoPermisos.Lectura)

        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim TipoDenticionLinea As Integer? = classOdontograma.GetTipoDenticioLineaPresupuestoByID(CType(Grid3.SelectedItems(0).GetRow().Cells("IDPresupuestoLinea").Value, Integer))

        CargarLineaPresupuesto(TipoDenticionLinea)

    End Sub

    Private Sub CargarLineaPresupuesto(TipoDenticionLinea As Integer)
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim IdSeleccionado As Integer = CType(Grid3.SelectedItems(0).GetRow().Cells("IDPresupuestoLinea").Value, Integer)
        Dim Lineas As IEnumerable(Of md_d_PresupuestoLinea) = classOdontograma.GetLineaPresupuestoByIDLinea(IdSeleccionado)
        Dim aColor As Color

        Odontograma1.temporal_dentition = (TipoDenticionLinea = 0)
        Odontograma2.temporal_dentition = (TipoDenticionLinea = 0)
        Odontograma3.temporal_dentition = (TipoDenticionLinea = 0)
        Odontograma4.temporal_dentition = (TipoDenticionLinea = 0)

        CargarOdontograma = False
        rbnTemporal.Checked = (TipoDenticionLinea = 0)
        rbnDefinitiva.Checked = (TipoDenticionLinea = 1)

        Odontograma3.Reset()
        ImporteTotal = 0
        For Each linea As md_d_PresupuestoLinea In Lineas
            ImporteTotal = ImporteTotal + linea.Importe
            If linea.TipoDenticion <> TipoDenticionLinea Then Continue For
            If linea.Realizado Then
                aColor = oColores(0)
            ElseIf linea.Confirmado And (linea.Urgencia = 0) Then
                aColor = oColores(1)
            ElseIf linea.Urgencia = 1 Then
                aColor = oColores(4)
            Else
                aColor = oColores(2)
            End If

            If linea.Cuadrantes <> "" Then
                For i As Integer = 0 To linea.Cuadrantes.Length - 1
                    RepresentAction(Odontograma3, linea.IDTratamiento, linea.Cuadrantes(i), linea.PiezasInvolucradas, aColor)
                Next
            Else
                RepresentAction(Odontograma3, linea.IDTratamiento, "C", linea.PiezasInvolucradas, aColor)
            End If
        Next
    End Sub

    'CUANDO CAMBIA LA SELECCION DE LA ACCION DE LA PRIMERA VISITA SELECCIONADA, MOSTRAR SU DESCRIPCION
    Private Sub lvw4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw4.SelectedIndexChanged
        rtb4.Enabled = lvw4.SelectedItems.Count > 0
        If lvw4.SelectedItems.Count > 0 Then
            Dim accion As md_d_Accion = TryCast(lvw4.SelectedItems(0).Tag, md_d_Accion)
            rtb4.Text = accion.DescripcionGenerada
        Else
            rtb4.Clear()
        End If
    End Sub
    'CUANDO SE CAMBIA EL ESTADO DEL CHECKBOX URGENTE DE PENDIENTES ESTANDO SELECCIONADO UNA LINEA CAMBIAR SU ESTADO
    Private Sub chbUrgente2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbUrgente2.Click
        If lvw2.SelectedItems.Count > 0 Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim presupuestoLinea As md_d_PresupuestoLinea = classOdontograma.GetLineaPresupuestoByID(TryCast(lvw2.SelectedItems(0).Tag, md_d_PresupuestoLinea).IDPresupuestoLinea)
            If chbUrgente2.Checked = True Then
                presupuestoLinea.Urgencia = 1
            Else
                presupuestoLinea.Urgencia = 0
            End If
            Try
                classOdontograma.SubmitChanges()
                If chbUrgente2.Checked = True Then
                    lvw2.SelectedItems(0).UseItemStyleForSubItems = True
                    lvw2.SelectedItems(0).ForeColor = Color.Red
                    lvw2.SelectedItems(0).Font = New Font(lvw2.SelectedItems(0).Font, FontStyle.Bold)
                    lvw2.SelectedItems(0).ImageIndex = imgIndex.ConfirmadoUrgente
                    TryCast(lvw2.SelectedItems(0).Tag, md_d_PresupuestoLinea).Urgencia = 1
                Else
                    lvw2.SelectedItems(0).UseItemStyleForSubItems = True
                    lvw2.SelectedItems(0).ForeColor = SystemColors.WindowText
                    lvw2.SelectedItems(0).Font = New Font(lvw2.SelectedItems(0).Font, FontStyle.Regular)
                    lvw2.SelectedItems(0).ImageIndex = imgIndex.Confirmado
                    TryCast(lvw2.SelectedItems(0).Tag, md_d_PresupuestoLinea).Urgencia = 0
                End If
                ActualizaOdontogramaDesdeLista(Odontograma2, lvw2)
                MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
            Catch ex As Exception
                MsgBox("Error al cambiar de estado: " + ex.ToString())
            End Try
        End If
    End Sub
    'CUANDO SE CAMBIA EL ESTADO DEL CHECKBOX URGENTE DE UNA LINEA DE PRESUPUESTO ESTANDO SELECCIONADO UNA LINEA CAMBIAR SU ESTADO
    Private Sub chbUrgente3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbUrgente3.Click
        If Grid3.SelectedItems.Count > 0 Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim presupuestoLinea As md_d_PresupuestoLinea = classOdontograma.GetLineaPresupuestoByID(CType(Grid3.SelectedItems(0).GetRow().Cells("IDPresupuestoLinea").Value, Integer))
            If chbUrgente3.Checked = True Then
                presupuestoLinea.Urgencia = 1
            Else
                presupuestoLinea.Urgencia = 0
            End If
            Try
                classOdontograma.SubmitChanges()
                If chbUrgente3.Checked = True Then
                    Grid3.SelectedItems(0).GetRow().Cells("icon").ImageIndex = imgIndex.LineaPresupuestoUrgente
                Else
                    Grid3.SelectedItems(0).GetRow().Cells("icon").ImageIndex = imgIndex.LineaPresupuesto
                End If
                MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
            Catch ex As Exception
                MsgBox("Error al cambiar de estado: " + ex.ToString())
            End Try
        End If
    End Sub
    'CUANDO SE SALE DEL EDITOR DE DESCRIPCION ASOCIADO AL LISTADO DE ACCIONES REALIZADAS, SALVAR LOS CAMBIOS
    Private Sub rtb1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb1.Leave
        If lvw1.SelectedItems.Count > 0 Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim accion As md_d_Accion = classOdontograma.GetAccionByID(TryCast(lvw1.SelectedItems(0).Tag, md_d_Accion).IDAccion)
            accion.DescripcionGenerada = rtb1.Text.Trim()
            Try
                classOdontograma.SubmitChanges()
                TryCast(lvw1.SelectedItems(0).Tag, md_d_Accion).DescripcionGenerada = rtb1.Text.Trim()
            Catch ex As Exception
                MsgBox("Error al salvar observaciones: " + ex.ToString())
            End Try
        End If
    End Sub
    'CUANDO SE SALE DEL EDITOR DE DESCRIPCION ASOCIADO AL LISTADO DE LINEAS DE PRESUPUESTOS CONFIRMADAS, SALVAR LOS CAMBIOS
    Private Sub rtb2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb2.Leave
        If lvw2.SelectedItems.Count > 0 Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim presupuestoLinea As md_d_PresupuestoLinea = classOdontograma.GetLineaPresupuestoByID(TryCast(lvw2.SelectedItems(0).Tag, md_d_PresupuestoLinea).IDPresupuestoLinea)
            presupuestoLinea.DescripcionGenerada = rtb2.Text.Trim()
            Try
                classOdontograma.SubmitChanges()
                TryCast(lvw2.SelectedItems(0).Tag, md_d_PresupuestoLinea).DescripcionGenerada = rtb2.Text.Trim()
            Catch ex As Exception
                MsgBox("Error al salvar observaciones: " + ex.ToString())
            End Try
        End If
    End Sub
    'CUANDO SE SALE DEL EDITOR DE DESCRIPCION ASOCIADO AL LISTADO DE LINEAS DE PRESUPUESTOS, SALVAR LOS CAMBIOS
    Private Sub rtb3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb3.Leave
        If Grid3.SelectedItems.Count > 0 Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim presupuestoLinea As md_d_PresupuestoLinea = classOdontograma.GetLineaPresupuestoByID(CType(Grid3.SelectedItems(0).GetRow().Cells("IDPresupuestoLinea").Value, Integer))

            presupuestoLinea.DescripcionGenerada = rtb3.Text.Trim()
            Try
                classOdontograma.SubmitChanges()
                LineasPresupuestoTableAdapter.Fill(OdontTrat.LineasPresupuesto, TryCast(tvwPresupuestos.SelectedNode.Tag, md_d_Presupuesto).IDPresupuesto)
                Grid3.Refetch()
            Catch ex As Exception
                MsgBox("Error al salvar observaciones: " + ex.ToString())
            End Try
        End If
    End Sub
    'CUANDO SE SALE DEL EDITOR DE DESCRIPCION ASOCIADO AL LISTADO DE ACCIONES DE LA PRIMERA VISITA, SALVAR LOS CAMBIOS
    Private Sub rtb4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb4.Leave
        If lvw4.SelectedItems.Count > 0 Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim accion As md_d_Accion = classOdontograma.GetAccionByID(TryCast(lvw4.SelectedItems(0).Tag, md_d_Accion).IDAccion)
            accion.DescripcionGenerada = rtb4.Text.Trim()
            Try
                classOdontograma.SubmitChanges()
                TryCast(lvw4.SelectedItems(0).Tag, md_d_Accion).DescripcionGenerada = rtb4.Text.Trim()
            Catch ex As Exception
                MsgBox("Error al salvar observaciones: " + ex.ToString())
            End Try
        End If
    End Sub
    'CUANDO SE CAMBIA EL ESTADO DEL CHECKBOX VER PENDIENTES MOSTRAR O OCULTAR ESTOS TRATAMIENTOS EN EL ODONTOGRAMA REALIZADO
    Private Sub chbVerPendientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbVerPendientes.Click
        If (chbVerPendientes.Checked = True) And (chbVerPresupuesto.Checked = False) Then
            ActualizaOdontogramaDesdeLista(Odontograma1, lvw2)
        Else
            ActualizaOdontogramaDesdeLista(Odontograma1, lvw1)
        End If
    End Sub
    'CUANDO SE CAMBIA EL ESTADO DEL CHECKBOX VER PRESUPUESTO MOSTRAR O OCULTAR ESTOS TRATAMIENTOS EN EL ODONTOGRAMA REALIZADO
    Private Sub chbVerPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbVerPresupuesto.Click
        If chbVerPresupuesto.Checked = True Then
            ActualizaOdontogramaPendienteSinConfirmar()
        Else
            ActualizaOdontogramaDesdeLista(Odontograma1, lvw1)
        End If
    End Sub
    'CUANDO SE CAMBIA LA PAGINA ACTIVA DEL TAB CONTROL MOSTRAR EL EDITOR DE DESCRIPCIONES CORRESPONDIENTE
    Private Sub tbc_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tbc.SelectedTabChanged
        chbVerPendientes.Visible = (e.Page.Index = 0)
        chbVerPresupuesto.Visible = (e.Page.Index = 0)

        Select Case e.Page.Index
            Case 0 : rtb1.Visible = True
                rtb2.Visible = False
                rtb3.Visible = False
                rtb4.Visible = False
            Case 1 : rtb1.Visible = False
                rtb2.Visible = True
                rtb3.Visible = False
                rtb4.Visible = False
            Case 2 : rtb1.Visible = False
                rtb2.Visible = False
                rtb3.Visible = True
                rtb4.Visible = False
            Case 3 : rtb1.Visible = False
                rtb2.Visible = False
                rtb3.Visible = False
                rtb4.Visible = True
        End Select
    End Sub
    'CUANDO SE PRESIONA UNA TECLA EN EL FORMULARIO QUE CAMBIA LA PAGINA  ACTIVA
    Private Sub frmOdontograma_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If MostrarSoloPresupuesto = False Then
            If e.Alt Then
                Select Case e.KeyCode
                    Case VistaKeys.Realizado
                        tbc.SelectedIndex = 0
                    Case VistaKeys.Pendiente
                        tbc.SelectedIndex = 1
                    Case VistaKeys.Presupuesto
                        tbc.SelectedIndex = 2
                    Case VistaKeys.PrimeraVisita
                        tbc.SelectedIndex = 3
                End Select
            End If
        End If
    End Sub
    'CUANDO SE LLAMA AL MENU CONTEXTUAL ASOCIADO A LOS ODONTOGRAMAS ESTANDO SOBRE UNA REGION QUE NO ESTA ASOCIADA A NINGUNA PIEZA NO MOSTRARLO
    Private Sub oMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles oMenu.Opening
        Dim num_pieza As Integer = TryCast(oMenu.SourceControl, Odontograma).HOverPiece
        If num_pieza = 0 Then
            mitHistorial.Visible = False
            'mitFicherosAsociados.Text = "Ficheros asociados al odontograma"
            mitFicherosAsociados.Visible = False
        Else
            mitHistorial.Visible = True
            mitFicherosAsociados.Visible = True
            mitFicherosAsociados.Text = "Ficheros asociados a la pieza " + num_pieza.ToString()
        End If
    End Sub
    'AL INVOCAR AL MENU CONTEXTUAL ASOCIADO AL LISTADO DE PRESUPEUSTOS
    Private Sub pMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles pMenu.Opening
        mitEliminarPres.Visible = Not (tvwPresupuestos.SelectedNode Is Nothing)
        mitMoverTodoPendiente.Visible = Not (tvwPresupuestos.SelectedNode Is Nothing)
        mitMoverTodoRealizado.Visible = Not (tvwPresupuestos.SelectedNode Is Nothing)
        mitVerReporte.Visible = Not (tvwPresupuestos.SelectedNode Is Nothing)
        'GenerarCitaParaEstePresupuestoToolStripMenuItem.Visible = Not (tvwPresupuestos.SelectedNode Is Nothing)
    End Sub
    'NUEVO PRESUPUESTO
    Private Sub mitNuevoPres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitNuevoPres.Click, btnPNuevo.Click, ToolStripButton1.Click
        Dim Presupuesto As md_d_Presupuesto
        If tvwPresupuestos.Nodes.Count > 0 Then
            Presupuesto = TryCast(tvwPresupuestos.Nodes.Item(tvwPresupuestos.Nodes.Count - 1).Tag, md_d_Presupuesto)
            'If dtpFecha.Value <= Presupuesto.FechaConcepcion Then
            '    MsgBox("La fecha seleccionada es menor o igual que la del último presupuesto", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim IDPresupuesto As Integer = TryCast(tvwPresupuestos.SelectedNode.Tag, md_d_Presupuesto).IDPresupuesto
            Dim lineas As IEnumerable(Of md_d_PresupuestoLinea) = classOdontograma.GetLineasByPresupuesto(IDPresupuesto)
            If lineas.Count() = 0 Then
                MsgBox("El último presupuesto no contiene ninguna línea, debe eliminarlo para crear un nuevo presupuesto.", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

        Presupuesto = AddPresupuestoOnDB(dtpFecha.Value)

        Dim NumPre As Integer = 0
        For Each nodo As TreeNode In tvwPresupuestos.Nodes
            If nodo.Text.Contains(Format(Presupuesto.FechaConcepcion, "dd/MM/yyyy")) Then NumPre += 1
        Next
        Dim tnode As TreeNode = tvwPresupuestos.Nodes.Add("P" & NumPre + 1 & " - " & Format(Presupuesto.FechaConcepcion, "dd/MM/yyyy"))
        tnode.Tag = Presupuesto
        tvwPresupuestos.SelectedNode = tvwPresupuestos.Nodes.Item(tvwPresupuestos.Nodes.Count - 1)
    End Sub
    'ELIMINAR PRESUPUESTO
    Private Sub mitEliminarPres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitEliminarPres.Click, btnPEliminar.Click, ToolStripButton4.Click
        Dim ID As Integer
        If rbnTemporal.Checked = True Then
            ID = OdontogramaID(0)
        Else
            ID = OdontogramaID(1)
        End If
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim IDPresupuesto As Integer = TryCast(tvwPresupuestos.SelectedNode.Tag, md_d_Presupuesto).IDPresupuesto
        Dim lineas As IEnumerable(Of md_d_PresupuestoLinea) = classOdontograma.GetLineasByPresupuesto(IDPresupuesto)
        For Each linea As md_d_PresupuestoLinea In lineas
            If (linea.Confirmado = True) Or (linea.Realizado = True) Then
                MsgBox("El presupuesto seleccionado contiene líneas confirmadas o realizadas. Imposible eliminar", MsgBoxStyle.Information)
                Exit Sub
            End If
        Next
        If MsgBox("Se eliminarán todas las líneas de presupuestos asociadas ¿Desea continuar?", MsgBoxStyle.YesNo, "Confirmación de borrado") = MsgBoxResult.Yes Then
            Dim presupuesto As md_d_Presupuesto = classOdontograma.GetPresupuestoByID(IDPresupuesto)
            Try
                classOdontograma.md_d_Presupuestos.DeleteOnSubmit(presupuesto)
                classOdontograma.SubmitChanges()
                tvwPresupuestos.SelectedNode.Remove()
                If tvwPresupuestos.Nodes.Count = 0 Then
                    Odontograma3.Reset()
                    LineasPresupuestoTableAdapter.Fill(OdontTrat.LineasPresupuesto, 0)
                    Grid3.Refetch()
                    ImporteTotal = 0
                    lblImporte.Text = "Importe total: "
                    btnPMPendiente.Enabled = False
                    btnPMRealizado.Enabled = False
                    btnPEliminar.Enabled = False
                    btnPReporte.Enabled = False
                End If
            Catch ex As Exception
                MsgBox("Error al eliminar: " + ex.ToString())
            End Try
        End If
    End Sub
    'VER HISTORIAL
    Private Sub mitHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitHistorial.Click
        Dim fhist As New frmHistorialPieza()
        If rbnTemporal.Checked = True Then
            fhist.Odontograma = OdontogramaID(0)
        Else
            fhist.Odontograma = OdontogramaID(1)
        End If
        fhist.oForm = Me
        fhist.Pieza = TryCast(oMenu.SourceControl, Odontograma).ClickedPiece
        fhist.Show(Me)
    End Sub
    'MOVER TODAS LAS LINEAS DEL PRESUPUESTO SELECCIONADO A PENDIENTES
    Private Sub mitMoverTodoPendiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitMoverTodoPendiente.Click, btnPMPendiente.Click, ToolStripButton2.Click
        If MsgBox("La operación es irreversible ¿Desea continuar?", MsgBoxStyle.YesNo, "Confirmación de movimiento") = MsgBoxResult.Yes Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim presupuestoLinea As md_d_PresupuestoLinea
            Dim aColor As Color

            Try
                For i As Integer = 0 To Grid3.RowCount - 1
                    presupuestoLinea = classOdontograma.GetLineaPresupuestoByID(CType(Grid3.GetRow(i).Cells("IDPresupuestoLinea").Value, Integer))
                    If (presupuestoLinea.Realizado = False) And (presupuestoLinea.Confirmado = False) Then
                        presupuestoLinea.Confirmado = True
                        presupuestoLinea.FechaConfirmado = dtpFecha.Value
                        classOdontograma.SubmitChanges()
                        If presupuestoLinea.Urgencia = 1 Then
                            aColor = oColores(4)
                            Grid3.GetRow(i).Cells("icon").ImageIndex = imgIndex.ConfirmadoUrgente
                        Else
                            aColor = oColores(1)
                            Grid3.GetRow(i).Cells("icon").ImageIndex = imgIndex.Confirmado
                        End If

                        AddItemPresupuesto(presupuestoLinea, presupuestoLinea.DescripcionGenerada)
                        If presupuestoLinea.Cuadrantes <> "" Then
                            For j As Integer = 0 To presupuestoLinea.Cuadrantes.Length - 1
                                RepresentAction(Odontograma2, presupuestoLinea.IDTratamiento, presupuestoLinea.Cuadrantes(j), presupuestoLinea.PiezasInvolucradas, aColor)
                            Next
                        Else
                            RepresentAction(Odontograma2, presupuestoLinea.IDTratamiento, "C", presupuestoLinea.PiezasInvolucradas, aColor)
                        End If
                    End If
                Next
                MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)
            Catch ex As Exception
                MsgBox("Error al mover a pendiente: " + ex.ToString())
            End Try
        End If
    End Sub
    'MOVER TODOS LAS LINEAS DEL PRESUPUESTO SELECCIONADO A REALIZADO
    Private Sub mitMoverTodoRealizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitMoverTodoRealizado.Click, btnPMRealizado.Click, ToolStripButton3.Click
        If MsgBox("La operación es irreversible ¿Desea continuar?", MsgBoxStyle.YesNo, "Confirmación de movimiento") = MsgBoxResult.Yes Then
            Dim classOdontograma As New ClasesOdontogramaDataContext
            Dim presupuestoLinea As md_d_PresupuestoLinea
            Dim accion As md_d_Accion
            Dim desTrat As String


            Try
                'Aqui voy a generar la cita asociada
                Dim context As New CMLinqDataContext()
                Dim cit As New CITA()
                cit.ATENDIDO = "S"
                cit.CONFIRMADA = "S"
                cit.CONTINUA = "N"
                cit.FECHA = Date.Now
                cit.HORA = Date.Now
                cit.HORAFIN = Date.Now.AddHours(1)
                cit.REFPACIENTE = PacienteActual

                Dim pac As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = PacienteActual Select p).SingleOrDefault()
                cit.PACIENTE = pac.NOMBRE & " " & pac.APELLIDO1 & " " & pac.APELLIDO2
                cit.PAGADA = "N"
                cit.REFMEDICO = SelDoctor

                context.CITAs.InsertOnSubmit(cit)
                context.SubmitChanges()
                Dim suma As Double = 0

                For i As Integer = 0 To Grid3.RowCount - 1
                    presupuestoLinea = classOdontograma.GetLineaPresupuestoByID(CType(Grid3.GetRow(i).Cells("IDPresupuestoLinea").Value, Integer))

                    If presupuestoLinea.Realizado = False Then
                        presupuestoLinea.Realizado = True
                        presupuestoLinea.FechaRealizado = dtpFecha.Value


                        classOdontograma.SubmitChanges()
                        Grid3.GetRow(i).Cells("icon").ImageIndex = imgIndex.Realizado
                        accion = AddActionOnDB(1, dtpFecha.Value, presupuestoLinea.IDTratamiento, presupuestoLinea.DescripcionGenerada, presupuestoLinea.PiezasInvolucradas, presupuestoLinea.Cuadrantes, SelDoctor)
                        If Not (accion Is Nothing) Then
                            AddItemAccion(1, accion, presupuestoLinea.md_ConceptoFra.DESCRIPCION)
                            If accion.Cuadrantes <> "" Then
                                For j As Integer = 0 To accion.Cuadrantes.Length - 1
                                    RepresentAction(Odontograma1, accion.IDTratamiento, accion.Cuadrantes(j), accion.PiezasInvolucradas, oColores(0))
                                Next
                            Else
                                RepresentAction(Odontograma1, accion.IDTratamiento, "C", accion.PiezasInvolucradas, oColores(0))
                            End If
                        End If
                    End If

                    Dim lineaCita As New LineasCita()
                    lineaCita.IdCita = cit.IDCITA
                    lineaCita.Cantidad = 1
                    lineaCita.DESCRIPCION = presupuestoLinea.DescripcionGenerada
                    lineaCita.ImporteClinica = presupuestoLinea.Importe
                    lineaCita.ImporteDr = 0
                    lineaCita.RefConcepto = presupuestoLinea.IDTratamiento
                    cit.LineasCitas.Add(lineaCita)

                    suma = suma + presupuestoLinea.Importe

                Next
                CargarListaPendiente()
                MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)

                cit.IMPORTECL = suma
                cit.IMPORTEDR = 0
                context.SubmitChanges()

            Catch ex As Exception
                MsgBox("Error al mover a realizado: " + ex.ToString())
            End Try
        End If
    End Sub
    'VENTANA PARA INSERTAR NUEVO TRATAMIENTO
    Private Sub cmNTratamientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmNTratamiento.Click
        Dim ntrat As New frmNTratamiento()
        ntrat.oform = Me
        ntrat.dcbx = Me.CBx_Doct
        ntrat.tlvw = Me.LVw_TTrat
        ntrat.dtemporal = rbnTemporal.Checked
        Select Case tbc.SelectedIndex
            Case 0 : rtb1.Visible = True
                ntrat.odont = Me.Odontograma1
            Case 2 : rtb1.Visible = False
                ntrat.odont = Me.Odontograma3
            Case 3 : rtb1.Visible = False
                ntrat.odont = Me.Odontograma4
        End Select
        ntrat.ShowDialog()
        tbcTrat_SelectedIndexChanged(tbcTrat, Nothing)
        SelDoctor = TryCast(CBx_Doct.SelectedItem, md_MEDICO).CMEDICO
        CargarPresupuestos()
    End Sub
    'REPORTE ODONTOGRAMA
    Private Sub tstRptOdontograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstRptOdontograma.Click

        Try
            'Salvar la imagen
            Dim tmpFileName As String = System.IO.Path.GetTempFileName()
            Dim FileName As String = tmpFileName.Substring(0, tmpFileName.Length - 4) + ".png"
            Kill(tmpFileName)
            Dim img As Image = Odontograma1.getImage(rbnTemporal.Checked)
            img.Save(FileName)

            Dim IDOdontograma As Integer
            If rbnTemporal.Checked = True Then
                IDOdontograma = OdontogramaID(0)
            Else
                IDOdontograma = OdontogramaID(1)
            End If
            
            Dim dataset As New OdontTrat.TratamientosXOdontogramaDataTable
            Dim adapter As New OdontTratTableAdapters.TratamientosXOdontogramaTableAdapter
            adapter.Fill(dataset, IDOdontograma)


            Dim ds As New ReportDataSource()

            ds.Name = "OdontTrat_TratamientosXOdontograma"
            ds.Value = dataset

            Dim imgPath As Uri = New Uri(FileName)
            Dim PathParam As ReportParameter = New ReportParameter("Path", imgPath.AbsoluteUri)

            UI.Reportes.ReportesManager.Imprime("DentalOdontograma.rdlc", {ds}, {PathParam})

            Kill(FileName)
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        End Try

    End Sub
    'VER REPORTE DE PRESUPUESTO
    Private Sub mitVerReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitVerReporte.Click, tstRptPresupuesto.Click, btnPReporte.Click, ToolStripButton5.Click

        Dim idPresupuesto = TryCast(tvwPresupuestos.SelectedNode.Tag, md_d_Presupuesto).IDPresupuesto

        Dim dataset As New OdontTrat.LineasPresupuestoDataTable()
        Dim adapter As New OdontTratTableAdapters.LineasPresupuestoTableAdapter()

        adapter.Fill(dataset, idPresupuesto)

        Dim ds As New ReportDataSource()
        ds.Name = "OdontTrat_LineasPresupuesto"
        ds.Value = dataset

        UI.Reportes.ReportesManager.Imprime("DentalPresupuesto.rdlc", {ds})

    End Sub

    'VENTANA DE FICHEROS ASOCIADOS
    Private Sub mitFicherosAsociados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitFicherosAsociados.Click
        Dim frmFicheros As frmFicherosAdjuntos = New frmFicherosAdjuntos()
        frmFicheros.IDPaciente = PacienteActual

        If rbnTemporal.Checked = True Then
            frmFicheros.Tag1 = OdontogramaID(0)
        Else
            frmFicheros.Tag1 = OdontogramaID(1)
        End If
        frmFicheros.Tag2 = TryCast(oMenu.SourceControl, Odontograma).ClickedPiece
        frmFicheros.IDSeccion = frmFicherosAdjuntos.Secciones.Dental_Diente
        frmFicheros.Text = "Ficheros adjuntos a la pieza " & frmFicheros.Tag2

        frmFicheros.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        'Ficheros Asociados al Odontograma
        Dim frmFicheros As frmFicherosAdjuntos = New frmFicherosAdjuntos()
        frmFicheros.IDPaciente = PacienteActual

        If rbnTemporal.Checked = True Then
            frmFicheros.Tag1 = OdontogramaID(0)
            frmFicheros.Text = "Ficheros adjuntos al Odontograma Permamente del Paciente"
        Else
            frmFicheros.Tag1 = OdontogramaID(1)
            frmFicheros.Text = "Ficheros adjuntos al Odontograma Temporal del Paciente"
        End If

        'frmFicheros.Tag2 = TryCast(oMenu.SourceControl, Odontograma.Odontograma).ClickedPiece
        'If frmFicheros.Tag2 = 0 Then frmFicheros.Tag2 = Nothing

        frmFicheros.IDSeccion = frmFicherosAdjuntos.Secciones.Dental_Odontograma

        frmFicheros.ShowDialog(Me)
    End Sub

    'Private Sub GenerarCitaParaEstePresupuestoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'If MsgBox("La operación es irreversible ¿Desea continuar?", MsgBoxStyle.YesNo, "Confirmación de movimiento") = MsgBoxResult.Yes Then
    '    Dim classOdontograma As New ClasesOdontogramaDataContext
    '    Dim presupuestoLinea As md_d_PresupuestoLinea
    '    '   Dim accion As md_d_Accion
    '    '   Dim desTrat As String


    '    Try
    '        'Aqui voy a generar la cita asociada
    '        Dim context As New CMLinqDataContext()
    '        Dim cit As New CITA()
    '        'cit.ATENDIDO = "S"
    '        cit.CONFIRMADA = "S"
    '        'cit.CONTINUA = "N"
    '        cit.FECHA = Date.Now
    '        cit.HORA = Date.Now
    '        cit.HORAFIN = Date.Now.AddMinutes(1)
    '        cit.REFPACIENTE = PacienteActual

    '        Dim pac As PACIENTE = (From p In context.PACIENTEs Where p.CPACIENTE = PacienteActual Select p).SingleOrDefault()
    '        cit.PACIENTE = pac.NOMBRE & " " & pac.APELLIDO1 & " " & pac.APELLIDO2
    '        cit.PAGADA = "N"
    '        cit.REFMEDICO = SelDoctor

    '        context.CITAs.InsertOnSubmit(cit)
    '        context.SubmitChanges()
    '        Dim suma As Double = 0

    '        For i As Integer = 0 To lvw3.Items.Count - 1
    '            presupuestoLinea = classOdontograma.GetLineaPresupuestoByID(TryCast(lvw3.Items(i).Tag, md_d_PresupuestoLinea).IDPresupuestoLinea)
    '            'If presupuestoLinea.Realizado = False Then
    '            '    presupuestoLinea.Realizado = True
    '            presupuestoLinea.FechaRealizado = dtpFecha.Value

    '            '   classOdontograma.SubmitChanges()
    '            '    desTrat = lvw3.Items(i).SubItems(0).Text
    '            '    lvw3.Items(i).ImageIndex = imgIndex.Realizado
    '            '    accion = AddActionOnDB(1, dtpFecha.Value, presupuestoLinea.IDTratamiento, presupuestoLinea.DescripcionGenerada, presupuestoLinea.PiezasInvolucradas, presupuestoLinea.Cuadrantes, SelDoctor)
    '            '    If Not (accion Is Nothing) Then
    '            '        AddItemAccion(1, accion, desTrat)
    '            '        If accion.Cuadrantes <> "" Then
    '            '            For j As Integer = 0 To accion.Cuadrantes.Length - 1
    '            '                RepresentAction(Odontograma1, accion.IDTratamiento, accion.Cuadrantes(j), accion.PiezasInvolucradas, oColores(0))
    '            '            Next
    '            '        Else
    '            '            RepresentAction(Odontograma1, accion.IDTratamiento, "C", accion.PiezasInvolucradas, oColores(0))
    '            '        End If
    '            '    End If
    '            'End If

    '            Dim lineaCita As New LineasCita()
    '            lineaCita.IdCita = cit.IDCITA
    '            lineaCita.Cantidad = 1
    '            lineaCita.DESCRIPCION = presupuestoLinea.DescripcionGenerada
    '            lineaCita.ImporteClinica = presupuestoLinea.Importe
    '            lineaCita.ImporteDr = 0
    '            lineaCita.RefConcepto = presupuestoLinea.IDTratamiento

    '            cit.LineasCitas.Add(lineaCita)

    '            suma = suma + presupuestoLinea.Importe

    '        Next
    '        'CargarListaPendiente()
    '        'MostrarLineasPresupuesto(tvwPresupuestos.SelectedNode)

    '        cit.IMPORTECL = suma
    '        cit.IMPORTEDR = 0
    '        context.SubmitChanges()

    '        MsgBox("La cita correspondiente a este presupuesto ha sido creada")
    '    Catch ex As Exception
    '        MsgBox("Error al generar cita: " + ex.ToString())
    '    End Try
    '    'End If
    'End Sub

    Private Sub tstReportes_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstReportes.DropDownOpening
        tstRptPresupuesto.Enabled = (tbc.SelectedIndex = 2) AndAlso Not (tvwPresupuestos.SelectedNode Is Nothing)
    End Sub

    Private Sub mit_VerCita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmVerCita.Click
        Dim classOdontograma As New ClasesOdontogramaDataContext
        Dim presupuestoLinea As md_d_PresupuestoLinea = classOdontograma.GetLineaPresupuestoByID(CType(Grid3.SelectedItems(0).GetRow().Cells("IDPresupuestoLinea").Value, Integer))

        Try
            Dim apermiso As Integer = RoleManager.PermisoPorItem(Globales.Usuario.CODIGO, RoleManager.Items.Citas)
            If Not presupuestoLinea.IDCITA.HasValue Then
                MessageBox.Show("La linea no tiene cita asociada")
                Return
            End If
            If apermiso > RoleManager.TipoPermisos.Lectura Then
                Dim frm As New form_citas("Editar cita", Enums.Accion.Modificar, presupuestoLinea.IDCITA)
                frm.ShowDialog()
            Else
                Dim frm As New form_citas("Ver cita", Enums.Accion.Ver, presupuestoLinea.IDCITA)
                frm.ShowDialog()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Grid3_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid3.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If CType(e.Row.Cells("Realizado").Value, Boolean) Then
                e.Row.Cells("icon").ImageIndex = imgIndex.Realizado
            ElseIf CType(e.Row.Cells("Confirmado").Value, Boolean) Then
                If CType(e.Row.Cells("Urgencia").Value, Integer) = 1 Then
                    e.Row.Cells("icon").ImageIndex = imgIndex.ConfirmadoUrgente
                Else
                    e.Row.Cells("icon").ImageIndex = imgIndex.Confirmado
                End If
            Else
                If CType(e.Row.Cells("Urgencia").Value, Integer) = 1 Then
                    e.Row.Cells("icon").ImageIndex = imgIndex.LineaPresupuestoUrgente
                Else
                    e.Row.Cells("icon").ImageIndex = imgIndex.LineaPresupuesto
                End If
            End If
        End If
    End Sub


    Private Sub Grid3_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid3.RowDoubleClick
        'Editar el presupuesto

        'If btnPNuevo.Visible Then
        'Significa que tiene permiso de edicion de presupuestos
        Dim presupuesto As OdontTrat.LineasPresupuestoRow = Grid3.SelectedItems(0).GetRow().DataRow.Row

        If GetAccionData(presupuesto.IDTratamiento, presupuesto.DescripcionGenerada, presupuesto.Importe, CantidadPiezas(presupuesto.PiezasInvolucradas), presupuesto.DescuentoPercent, False) = Windows.Forms.DialogResult.OK Then
            'Actualizare usando linq
            Dim context As New CMLinqDataContext()
            Dim prep As d_PresupuestoLinea = (From linea In context.d_PresupuestoLineas _
                                              Where linea.IDPresupuestoLinea = presupuesto.IDPresupuestoLinea _
                                              Select linea).SingleOrDefault()
            prep.DescripcionGenerada = presupuesto.DescripcionGenerada
            prep.Importe = presupuesto.Importe
            prep.DescuentoPercent = presupuesto.DescuentoPercent
            context.SubmitChanges()

            CargarPresupuestos()
        End If
        'End If


    End Sub

    
    'Private Sub chb_aseguradora_CheckedChanged(sender As Object, e As EventArgs)

    '    If chb_aseguradora.Checked = True And cb_aseguradora.Items.Count = 0 Then
    '        MessageBox.Show("Este paciente no tiene mutuas asignadas")
    '        chb_aseguradora.Checked = False
    '    End If
    '    cb_aseguradora.Enabled = chb_aseguradora.Checked
    'End Sub

    Private Sub CtrlMutua1_MutuasSeleccionadoManualmente(IdMutuas As Integer) Handles CtrlMutua1.MutuasSeleccionadoManualmente
        If Not tvwPresupuestos.SelectedNode Is Nothing Then
            Dim currentPresupuesto As md_d_Presupuesto = tvwPresupuestos.SelectedNode.Tag

            Dim context As New ClasesOdontogramaDataContext

            Dim presupuesto As md_d_Presupuesto = (From p In context.md_d_Presupuestos Where p.IDPresupuesto = currentPresupuesto.IDPresupuesto Select p).SingleOrDefault()
            If Not presupuesto Is Nothing Then
                presupuesto.IDMutua = IdMutuas
            End If
            context.SubmitChanges()
            currentPresupuesto.IDMutua = IdMutuas

            If MessageBox.Show("¿Desea recalcular los importes de acuerdo a las tarifas de la mutua seleccionada si procede?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                RecalculaImportes(IdMutuas)
            End If

        End If
    End Sub

    Private Sub RecalculaImportes(ByVal idMutuas As Integer?)

        'Recalcular
        Dim context As New ClasesOdontogramaDataContext
        For Each row As GridEXRow In Grid3.GetRows()
            If row.RowType = RowType.Record Then
                Dim lineaold As OdontTrat.LineasPresupuestoRow = row.DataRow.Row
                Dim nuevaLinea As md_d_PresupuestoLinea = (From l In context.md_d_PresupuestoLineas Where l.IDPresupuestoLinea = lineaold.IDPresupuestoLinea Select l).SingleOrDefault()
                If Not nuevaLinea Is Nothing Then
                    nuevaLinea.Importe = Globales.ObtenImporteConceptoSegunTarifaMutua(lineaold.IDTratamiento, idMutuas, lineaold.Importe)
                End If
            End If
        Next
        context.SubmitChanges()
        CargarPresupuestos()
    End Sub

    Private Sub CtrlMutua1_MutuasEliminada(IdMutuas As Integer) Handles CtrlMutua1.MutuasEliminada
        Dim currentPresupuesto As md_d_Presupuesto = tvwPresupuestos.SelectedNode.Tag
        Dim context As New ClasesOdontogramaDataContext
        Dim presupuesto As md_d_Presupuesto = (From p In context.md_d_Presupuestos Where p.IDPresupuesto = currentPresupuesto.IDPresupuesto Select p).SingleOrDefault()
        If Not presupuesto Is Nothing Then
            presupuesto.IDMutua = Nothing
        End If
        context.SubmitChanges()

        currentPresupuesto.IDMutua = Nothing
        If MessageBox.Show("¿Desea recalcular los importes de acuerdo a las tarifas de la mutua seleccionada si procede?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            For Each row As GridEXRow In Grid3.GetRows()
                If row.RowType = RowType.Record Then
                    Dim lineaold As OdontTrat.LineasPresupuestoRow = row.DataRow.Row
                    Dim nuevaLinea As md_d_PresupuestoLinea = (From l In context.md_d_PresupuestoLineas Where l.IDPresupuestoLinea = lineaold.IDPresupuestoLinea Select l).SingleOrDefault()
                    If Not nuevaLinea Is Nothing Then
                        Dim tratamiento As md_ConceptoFra = (From t In context.md_ConceptoFras Where t.CODIGO = nuevaLinea.IDTratamiento Select t).SingleOrDefault()
                        If Not tratamiento Is Nothing Then
                            nuevaLinea.Importe = Globales.ObtenImporteConceptoSegunTarifaMutua(lineaold.IDTratamiento, Nothing, tratamiento.IMPORTE)
                        End If
                    End If
                End If
            Next
            context.SubmitChanges()
            CargarPresupuestos()
        End If
    End Sub
End Class

Partial Public Class md_MEDICO
    Public Overrides Function ToString() As String
        Return NOMBRE & " " & APELLIDO1 & " " & APELLIDO2
    End Function
End Class