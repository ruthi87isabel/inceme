Public Class form_modelo_rev_comparativoas

    Dim fId As String
    Dim fcurrentAcc As Enums.Accion
    Dim fCancelar As Boolean

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

    Private Sub form_modelo_rev_comparativoas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.CurrentAccion = Enums.Accion.Insertar Then
            fId = "-1"
            MODELOSCOMPARATIVATableAdapter.Insert(fId, " ")

            fCancelar = False
        End If
        If Me.CurrentAccion = Enums.Accion.Modificar Then
            Inicializa()
        End If
        If Me.CurrentAccion = Enums.Accion.Ver Then

            Inicializa()
            tb_codigo.ReadOnly = True
            tb_descripcion.ReadOnly = True
            bt_aceptar.Hide()
            bt_annadirdato.Hide()
            bt_editardato.Hide()
            bt_eliminardato.Hide()
            bt_cancelar.Text = "Cerrar   "
        End If

    End Sub

    Private Sub Inicializa()
        Dim _data As CMDataSet.MODELOSCOMPARATIVADataTable = MODELOSCOMPARATIVATableAdapter.GetDataByCodigo(fId)

        tb_codigo.Text = _data.Rows(0).Item("CODIGO")
        tb_descripcion.Text = _data.Rows(0).Item("MODELO")
        GetDatos()

        Dim context As New CMLinqDataContext()
        Dim modelo As MODELOSCOMPARATIVA = (From m In context.MODELOSCOMPARATIVAs _
                                           Where m.CODIGO = tb_codigo.Text
                                           Select m).SingleOrDefault
        If Not modelo Is Nothing Then
            If Not modelo.IMAGEN Is Nothing Then
                Dim ms As New IO.MemoryStream(modelo.IMAGEN.ToArray())
                PictureBox1.Image = Image.FromStream(ms)
            End If
        End If

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If tb_descripcion.Text = "" Then
            MessageBox.Show("Se requiere una descripción")
            tb_descripcion.Focus()
            Return
        End If

        Dim _codModCom As String = tb_codigo.Text
        Dim _descripicion As String = tb_descripcion.Text

        If _codModCom <> "" Then
            If Me.CurrentAccion = Enums.Accion.Modificar Then
                MODELOSCOMPARATIVATableAdapter.UpdateValores(_codModCom, _descripicion, fId)

            End If
            Close()
        Else
            MessageBox.Show("El campo código debe tener valor", "Centro Médico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim context As New CMLinqDataContext()
        Dim modelo As MODELOSCOMPARATIVA = (From m In context.MODELOSCOMPARATIVAs _
                                           Where m.CODIGO = _codModCom
                                           Select m).SingleOrDefault
        Dim arr() As Byte
        If Not modelo Is Nothing Then
            If Not PictureBox1.Image Is Nothing Then
                Dim ms As New IO.MemoryStream()
                Dim tempImage As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\" & Date.Now.Ticks & ".jpg"

                PictureBox1.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                Dim img As Image = Image.FromStream(ms)
                img.Save(tempImage)

                Dim fs As New System.IO.FileStream(tempImage, IO.FileMode.Open, IO.FileAccess.Read)
                ReDim arr(fs.Length)
                fs.Read(arr, 0, fs.Length)
                fs.Close()
                modelo.IMAGEN = arr
            Else
                modelo.IMAGEN = Nothing
            End If
            'PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

            context.SubmitChanges()

        End If

        'Salvar los Ordenes
        For Each row As DataGridViewRow In dtg_modelodatos.Rows
            Dim id As Integer = row.Cells("CODIGO").Value
            Dim datosModelo As MODELOSDATO = (From d As MODELOSDATO In context.MODELOSDATOs _
                                              Where d.CODIGO = id
                                              Select d).SingleOrDefault()
            If Not datosModelo Is Nothing Then
                datosModelo.ORDEN = Integer.Parse(row.Cells("ORDEN").Value)
            End If
            context.SubmitChanges()
        Next
    End Sub

    Private Sub GetDatos()


        Dim _dataDatos As CMDataSet.MODELOSDATOSDataTable = MODELOSDATOSTableAdapter.GetDataByComparativa(fId)
        Dim tabla As DataTable = New DataTable("Tabla")
        tabla.Columns.Add("Codigo")
        tabla.Columns.Add("Descripción")
        tabla.Columns.Add("Tipo de dato")
        tabla.Columns.Add("ORDEN")


        Dim i As Integer
        For i = 0 To _dataDatos.Rows.Count() - 1
            Dim _row() As Object = New Object(3) {}
            _row(0) = _dataDatos.Rows(i).Item("CODIGO")
            _row(1) = _dataDatos.Rows(i).Item("NOMBREDATO")
            _row(2) = _dataDatos.Rows(i).Item("TIPODATO")
            _row(3) = _dataDatos.Rows(i).Item("ORDEN")
            If _row(3) Is DBNull.Value Then
                _row(3) = i
            End If
            tabla.Rows.Add(_row)
        Next


        dtg_modelodatos.DataSource = tabla
        dtg_modelodatos.Columns.Item("Codigo").Visible = False
        dtg_modelodatos.Columns.Item("ORDEN").Visible = False
        dtg_modelodatos.Sort(dtg_modelodatos.Columns("ORDEN"), System.ComponentModel.ListSortDirection.Ascending)


    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        If Me.CurrentAccion = Enums.Accion.Insertar Then
            fCancelar = True
        End If
        Close()
    End Sub

    Private Sub bt_annadirdato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_annadirdato.Click
        If tb_codigo.Text = "" Then
            MessageBox.Show("Debe entrar un Código válido para Añadirle Datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim _nuevo_modelo_datos As form_modelos_datos = New form_modelos_datos(tb_codigo.Text, Enums.Accion.Insertar, -1)
            '_nuevo_modelo_datos.ModeloDatos = 

            _nuevo_modelo_datos.ShowInTaskbar = False
            _nuevo_modelo_datos.ShowDialog()
            GetDatos()
        End If
    End Sub

    Private Sub bt_editardato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_editardato.Click
        If dtg_modelodatos.SelectedRows.Count > 0 Then
            Dim Id As Integer = dtg_modelodatos.SelectedRows.Item(0).Cells("CODIGO").Value
            Dim _nuevo_modelo_datos As form_modelos_datos = New form_modelos_datos(tb_codigo.Text, Enums.Accion.Modificar, Id)
            _nuevo_modelo_datos.ShowInTaskbar = False
            _nuevo_modelo_datos.ShowDialog()
            GetDatos()
        End If
    End Sub

    Private Sub bt_eliminardato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminardato.Click
        If dtg_modelodatos.SelectedRows.Count > 0 Then
            Dim Id As Integer = dtg_modelodatos.SelectedRows.Item(0).Cells("CODIGO").Value
            MODELOSDATOSTableAdapter.DeleteByCodigo(Id)
            GetDatos()
        End If
    End Sub

    Private Sub tb_codigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_codigo.TextChanged
        Dim _codModCom As String = tb_codigo.Text
        Dim _descripicion As String = tb_descripcion.Text
        If Me.CurrentAccion = Enums.Accion.Insertar Then
            Try
                MODELOSCOMPARATIVATableAdapter.UpdateValores(_codModCom, _descripicion, fId)
                fId = _codModCom
            Catch
                MessageBox.Show("Error insertando Valores, datos incorrectos")
            End Try
        End If

    End Sub

    Private Sub tb_descripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_descripcion.TextChanged
        Dim _codModCom As String = tb_codigo.Text
        Dim _descripicion As String = tb_descripcion.Text
        If Me.CurrentAccion = Enums.Accion.Insertar Then
            MODELOSCOMPARATIVATableAdapter.UpdateValores(_codModCom, _descripicion, fId)
        End If
    End Sub

    Private Sub form_modelo_rev_comparativoas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Me.CurrentAccion = Enums.Accion.Insertar And fCancelar = True Then
            MODELOSCOMPARATIVATableAdapter.DeleteByCodigo(fId)
        End If
    End Sub

    Private Sub btnSeleccionarImage_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionarImage.Click
        Dim frm As New frm_BancoImag_Galeria
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(frm.SelectedImagePath)
        End If

    End Sub

    Private Sub dtg_modelodatos_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dtg_modelodatos.SelectionChanged
        If dtg_modelodatos.SelectedRows.Count > 0 Then
            btnUp.Enabled = dtg_modelodatos.SelectedRows.Count > 0 And dtg_modelodatos.SelectedRows(0).Index > 0
            btnDown.Enabled = dtg_modelodatos.SelectedRows.Count > 0 And dtg_modelodatos.SelectedRows(0).Index < dtg_modelodatos.Rows.Count - 1
        End If
        
    End Sub

    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles btnUp.Click

        Dim currentIndex = dtg_modelodatos.SelectedRows(0).Index
        Dim prevIndex = dtg_modelodatos.SelectedRows(0).Index - 1

        dtg_modelodatos.Rows(currentIndex).Cells("ORDEN").Value = prevIndex
        dtg_modelodatos.Rows(prevIndex).Cells("ORDEN").Value = currentIndex

        'Dim _codDato As Integer = dtg_modelodatos.SelectedRows(0).Cells("CODIGO").Value
        'Dim context As New CMLinqDataContext()
        'Dim modeloDato As MODELOSDATO = (From m In context.MODELOSDATOs _
        '                                   Where m.CODIGO = _codDato
        '                                   Select m).SingleOrDefault

        'modeloDato.ORDEN = dtg_modelodatos.SelectedRows(0).Index - 1
        'context.SubmitChanges()
        'dtg_modelodatos.SelectedRows(0). = dtg_modelodatos.SelectedRows(0).Index - 1

        'GetDatos()
        dtg_modelodatos.ClearSelection()
        dtg_modelodatos.Rows(prevIndex).Selected = True
        dtg_modelodatos.Sort(dtg_modelodatos.Columns("ORDEN"), System.ComponentModel.ListSortDirection.Ascending)


    End Sub

    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles btnDown.Click
        Dim currentIndex = dtg_modelodatos.SelectedRows(0).Index
        Dim nextIndex = dtg_modelodatos.SelectedRows(0).Index + 1

        dtg_modelodatos.Rows(currentIndex).Cells("ORDEN").Value = nextIndex
        dtg_modelodatos.Rows(nextIndex).Cells("ORDEN").Value = currentIndex

        'Dim _codDato As Integer = dtg_modelodatos.SelectedRows(0).Cells("CODIGO").Value
        'Dim context As New CMLinqDataContext()
        'Dim modeloDato As MODELOSDATO = (From m In context.MODELOSDATOs _
        '                                   Where m.CODIGO = _codDato
        '                                   Select m).SingleOrDefault

        'modeloDato.ORDEN = dtg_modelodatos.SelectedRows(0).Index + 1
        'context.SubmitChanges()
        'dtg_modelodatos.SelectedRows(0). = dtg_modelodatos.SelectedRows(0).Index - 1

        'GetDatos()
        dtg_modelodatos.ClearSelection()
        dtg_modelodatos.Rows(nextIndex).Selected = True
        dtg_modelodatos.Sort(dtg_modelodatos.Columns("ORDEN"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub dtg_modelodatos_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_modelodatos.CellDoubleClick
        bt_editardato_Click(Nothing, Nothing)
    End Sub

    Private Sub btQuitarImagen_Click(sender As Object, e As EventArgs) Handles btQuitarImagen.Click
        Me.PictureBox1.Image = Nothing
    End Sub
End Class