Public Class frmAntecedentes
    Dim IDPACIENTE As Integer

    Sub New(idpaciente As Integer)
        InitializeComponent()
        '
        Me.IDPACIENTE = idpaciente
    End Sub

    Private Sub frmAntecedentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicaPermisos()
        Filtrar_InformacionPrimaria()
        Cargar_AntecedentesDiagnostico()
        Cargar_LineasAlarmas()
    End Sub

    Private Sub AplicaPermisos()
        Dim permiso As RoleManager.TipoPermisos = Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos)

        tst_Annadir_Diagnositco.Enabled = permiso > 2
        tst_Editar_Diagnositco.Enabled = permiso > 2
        tst_Eliminar_Diagnositco.Enabled = permiso > 2

        tst_Annadir_InfoPrimaira.Enabled = permiso > 2
        tst_Editar_InfoPrimaira.Enabled = permiso > 2
        tst_Eliminar_InfoPrimaira.Enabled = permiso > 2

        tstAnnadir_Alarma.Enabled = permiso > 2
        tst_Eliminar_Alarma.Enabled = permiso > 2
        tst_Eliminar_Alarma.Enabled = permiso > 2

        GridEXLineaAlarma.Enabled = permiso > 2
        InfoPrimariaGridEX.Enabled = permiso > 2
        GridEXDiagnosticoAntecedente.Enabled = permiso > 2

        'bt_amMasArriba.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2) 'bt_amMasArriba es añadir alarma
        'bt_amMenosArriba.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 3) 'eliminar alarma
        'bt_amMasAbajo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2)
        'bt_amTrianguloAbajo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2)
        'bt_amMenosAbajo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 3) 'eliminar informacion primaria
        'dtg_amAlarmas.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2) 'grid alarmas
        'dtg_amInfoprimaria.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2) ' grid informes
        'tb_amDescripcion.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2) 'textbox alarma
        'tb_amGrandeabajo.Enabled = (Globales.Usuario.Permisos(RoleManager.Items.Pacientes_Antecedentes_Médicos) > 2) 'textbox info
    End Sub

    Private Sub tst_Annadir_InfoPrimaira_Click(sender As Object, e As EventArgs) Handles tst_Annadir_InfoPrimaira.Click
        Dim frm As New frmInfoprimaria(Enums.Accion.Insertar)
        frm.ShowInTaskbar = False
        Dim context As New CMLinqDataContext()
        Dim info As New INFORMACIONPRIMARIA()
        info.REFPACIENTE = Me.IDPACIENTE
        info.FECHA = Date.Now
        info.ID = context.INFORMACIONPRIMARIAs.Max(Function(o) o.ID) + 1
        frm.INFORMACIONPRIMARIABindingSource.DataSource = info

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            info.FECHA = frm.dtp_IPFecha.Value
            context.INFORMACIONPRIMARIAs.InsertOnSubmit(info)
            context.SubmitChanges()
            Try
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Información primaria", info.ID.ToString(), "fecha : " & info.FECHA.ToString() & " paciente :" & Me.IDPACIENTE.ToString() & " descripción: " & info.DESCRIPCION)
            Catch ex As Exception
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Información primaria", info.ID.ToString(), "paciente :" & Me.IDPACIENTE.ToString())
            End Try
            Filtrar_InformacionPrimaria()
        End If
    End Sub

    Private Sub tst_Editar_InfoPrimaira_Click(sender As Object, e As EventArgs) Handles tst_Editar_InfoPrimaira.Click
        If InfoPrimariaGridEX.SelectedItems.Count < 1 Then
            Return
        End If
        Dim info As INFORMACIONPRIMARIA = InfoPrimariaGridEX.SelectedItems(0).GetRow().DataRow()
        Dim context As New CMLinqDataContext()
        info = (From i In context.INFORMACIONPRIMARIAs Where i.ID = info.ID Select i).First()
        Dim frm As New frmInfoprimaria(Enums.Accion.Insertar)
        frm.ShowInTaskbar = False

        frm.dtp_IPFecha.Value = info.FECHA 
        frm.INFORMACIONPRIMARIABindingSource.DataSource = info

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            info.FECHA = frm.dtp_IPFecha.Value
            context.SubmitChanges()
            Try
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Información primaria", info.ID.ToString(), "fecha : " & info.FECHA.ToString() & " paciente :" & Me.IDPACIENTE.ToString() & " descripción: " & info.DESCRIPCION)
            Catch ex As Exception
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Información primaria", info.ID.ToString(), "paciente :" & Me.IDPACIENTE.ToString())
            End Try
            Filtrar_InformacionPrimaria()
        End If
    End Sub

    Private Sub tst_Eliminar_InfoPrimaira_Click(sender As Object, e As EventArgs) Handles tst_Eliminar_InfoPrimaira.Click
        If InfoPrimariaGridEX.SelectedItems.Count > 0 Then
            Dim info As INFORMACIONPRIMARIA
            info = InfoPrimariaGridEX.SelectedItems(0).GetRow().DataRow()
            Dim context As New CMLinqDataContext()
            Dim Inf = (From i In context.INFORMACIONPRIMARIAs Where i.ID = info.ID Select i).First()
           
            context.INFORMACIONPRIMARIAs.DeleteOnSubmit(Inf)
            context.SubmitChanges()
            Try
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Información primaria", info.ID.ToString(), "fecha : " & info.FECHA.ToString() & " paciente :" & Me.IDPACIENTE.ToString() & " descripción: " & info.DESCRIPCION)
            Catch ex As Exception
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Información primaria", info.ID.ToString(), "paciente :" & Me.IDPACIENTE.ToString())
            End Try
            Filtrar_InformacionPrimaria()
            If InfoPrimariaGridEX.SelectedItems.Count = 0 Then
                EditDescripcionInfPrimaria.Text = ""
            End If
        End If
    End Sub

    Private Sub Filtrar_InformacionPrimaria()
        INFORMACIONPRIMARIABindingSource.DataSource = Nothing
        Dim context As New CMLinqDataContext()
        INFORMACIONPRIMARIABindingSource.DataSource = (From i In context.INFORMACIONPRIMARIAs Where i.REFPACIENTE = Me.IDPACIENTE).ToList()
        InfoPrimariaGridEX.DataSource = INFORMACIONPRIMARIABindingSource.DataSource
    End Sub

    Private Sub Cargar_AntecedentesDiagnostico()
        GridEXDiagnosticoAntecedente.DataSource = Nothing
        Dim context As New CMLinqDataContext()
        Me.AntecedentesDiagnosticoBindingSource.DataSource = (From a In context.AntecedentesDiagnosticos Where a.CPACIENTE = Me.IDPACIENTE Select a).ToList()
        GridEXDiagnosticoAntecedente.DataSource = Me.AntecedentesDiagnosticoBindingSource

    End Sub

    Private Sub Cargar_LineasAlarmas()
        Dim context As New CMLinqDataContext()
        GridEXLineaAlarma.DataSource = Nothing
        LINEASALARMABindingSource.DataSource = (From l In context.LINEASALARMAs Where l.REFPACIENTE = Me.IDPACIENTE Select l).ToList()
        GridEXLineaAlarma.DataSource = LINEASALARMABindingSource
        PonerColorAlarma()
    End Sub
    
   
    Private Sub GridEXLineaAlarma_SelectionChanged(sender As Object, e As EventArgs) Handles GridEXLineaAlarma.SelectionChanged
        If GridEXLineaAlarma.SelectedItems.Count < 1 Then
            EditDescripcionAlarma.Text = ""
            Return
        End If
        Dim _linea As LINEASALARMA = GridEXLineaAlarma.SelectedItems(0).GetRow.DataRow
        EditDescripcionAlarma.Text = Globales.TextFromRtf(_linea.DESCRIPCION)
    End Sub

    Private Sub InfoPrimariaGridEX_SelectionChanged(sender As Object, e As EventArgs) Handles InfoPrimariaGridEX.SelectionChanged
        If InfoPrimariaGridEX.SelectedItems.Count < 1 Then
            EditDescripcionInfPrimaria.Text = ""
            Return
        End If
        Dim _linea As INFORMACIONPRIMARIA = InfoPrimariaGridEX.SelectedItems(0).GetRow.DataRow
        EditDescripcionInfPrimaria.Text = Globales.TextFromRtf(_linea.TEXTO)
    End Sub

    Private Sub InfoPrimariaGridEX_DoubleClick(sender As Object, e As EventArgs) Handles InfoPrimariaGridEX.DoubleClick
        tst_Editar_InfoPrimaira_Click(Nothing, Nothing)
    End Sub

    Private Sub PonerColorAlarma()
        Dim maxNivelAlarma = 0 'Ninguno
        Dim k As Integer = 0

        For Each a As LINEASALARMA In LINEASALARMABindingSource.DataSource
            Select Case a.ALARMA.NIVEL
                Case "A"
                    k = 3
                Case "M"
                    k = 2
                Case "B"
                    k = 1
            End Select

            maxNivelAlarma = Math.Max(maxNivelAlarma, k)
        Next

        'Establezco el valor al lblAlarmas del mdiParent
        'Select Case maxNivelAlarma
        '    Case 3  ' Alta
        '        Me.MdiParent.Controls.Find("lblAlarmas", True)(0).BackColor = Color.FromArgb(255, 69, 0)
        '        Me.MdiParent.Controls.Find("lblAlarmas", True)(0).Text = "¡¡ATENCIÓN!!"
        '    Case 2
        '        Me.MdiParent.Controls.Find("lblAlarmas", True)(0).BackColor = Color.FromArgb(249, 247, 186)
        '        Me.MdiParent.Controls.Find("lblAlarmas", True)(0).Text = "¡PRECAUCIÓN!"
        '    Case 1
        '        Me.MdiParent.Controls.Find("lblAlarmas", True)(0).BackColor = Color.FromArgb(255, 174, 0)
        '        Me.MdiParent.Controls.Find("lblAlarmas", True)(0).Text = "CUIDADO"
        '    Case 0
        '        Me.MdiParent.Controls.Find("lblAlarmas", True)(0).BackColor = System.Drawing.Color.GhostWhite
        '        Me.MdiParent.Controls.Find("lblAlarmas", True)(0).Text = ""
        'End Select
    End Sub

    Private Sub tstAnnadir_Alarma_Click(sender As Object, e As EventArgs) Handles tstAnnadir_Alarma.Click
        Dim context As New CMLinqDataContext()
        Dim linea As New LINEASALARMA()

        Dim frm As New frmLineaAlarma_Editar(Me.IDPACIENTE)
        frm.LINEAALARMABindingSource.DataSource = linea
        If frm.ShowDialog() = DialogResult.OK Then
            context.LINEASALARMAs.InsertOnSubmit(linea)
            context.SubmitChanges()
            Try
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Linea Alarma", linea.IDLINEAALARMA.ToString(), "alarma : " & linea.REFALARMA & " " & linea.ALARMA.ALARMA & " paciente :" & Me.IDPACIENTE.ToString() & " nivel: " & linea.ALARMA.NIVEL)
            Catch ex As Exception
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Linea Alarma", linea.IDLINEAALARMA.ToString(), "alarma : " & linea.REFALARMA & " paciente :" & Me.IDPACIENTE.ToString())
            End Try
            Cargar_LineasAlarmas()
        End If
    End Sub

    
    Private Sub tst_Modificar_Alarma_Click(sender As Object, e As EventArgs) Handles tst_Modificar_Alarma.Click
        If GridEXLineaAlarma.SelectedItems.Count < 1 Then
            Return
        End If
        Dim linea As LINEASALARMA = GridEXLineaAlarma.SelectedItems(0).GetRow.DataRow
        Dim context As New CMLinqDataContext()
        linea = (From l In context.LINEASALARMAs Where l.IDLINEAALARMA = linea.IDLINEAALARMA Select l).First()

        Dim frm As New frmLineaAlarma_Editar(Me.IDPACIENTE)
        frm.LINEAALARMABindingSource.DataSource = linea
        If frm.ShowDialog() = DialogResult.OK Then
            context.SubmitChanges()
            Try
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Linea Alarma", linea.IDLINEAALARMA.ToString(), "alarma : " & linea.REFALARMA & " " & linea.ALARMA.ALARMA & " paciente :" & Me.IDPACIENTE.ToString() & " nivel: " & linea.ALARMA.NIVEL)
            Catch ex As Exception
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Linea Alarma", linea.IDLINEAALARMA.ToString(), "alarma : " & linea.REFALARMA & " paciente :" & Me.IDPACIENTE.ToString())
            End Try
            Cargar_LineasAlarmas()
        End If

    End Sub

    Private Sub tst_Eliminar_Alarma_Click(sender As Object, e As EventArgs) Handles tst_Eliminar_Alarma.Click
        If GridEXLineaAlarma.SelectedItems.Count < 1 Then
            Return
        End If
        Dim linea As LINEASALARMA = GridEXLineaAlarma.SelectedItems(0).GetRow.DataRow
        Dim context As New CMLinqDataContext()
        linea = (From l In context.LINEASALARMAs Where l.IDLINEAALARMA = linea.IDLINEAALARMA Select l).First()
        Try
            context.LINEASALARMAs.DeleteOnSubmit(linea)
            context.SubmitChanges()
            Try
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Linea Alarma", linea.IDLINEAALARMA.ToString(), "alarma : " & linea.REFALARMA & " " & linea.ALARMA.ALARMA & " paciente :" & Me.IDPACIENTE.ToString() & " nivel: " & linea.ALARMA.NIVEL)
            Catch ex As Exception
                Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Linea Alarma", linea.IDLINEAALARMA.ToString(), "alarma : " & linea.REFALARMA & " paciente :" & Me.IDPACIENTE.ToString())
            End Try
            Cargar_LineasAlarmas()
        Catch ex As Exception
        End Try
        If GridEXLineaAlarma.SelectedItems.Count = 0 Then
            EditDescripcionAlarma.Text = ""
        End If
    End Sub

    Private Sub GridEXLineaAlarma_DoubleClick(sender As Object, e As EventArgs) Handles GridEXLineaAlarma.DoubleClick
        tst_Modificar_Alarma_Click(Nothing, Nothing)
    End Sub

    Private Sub tst_Annadir_Diagnositco_Click(sender As Object, e As EventArgs) Handles tst_Annadir_Diagnositco.Click
        Dim antecedente As New AntecedentesDiagnostico()
        antecedente.CPACIENTE = Me.IDPACIENTE

        Dim frm As New frmAntecedentes_Editar(antecedente)
        frm.ShowInTaskbar = False
        'frm.AntecedentesDiagnosticoBindingSource.DataSource = antecedente

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim context As New CMLinqDataContext()
            Try
                context.AntecedentesDiagnosticos.InsertOnSubmit(antecedente)
                context.SubmitChanges()
                Try
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Antecedentes diagnosticos", antecedente.IDDIAGNOSTICO.ToString(), "diagnóstico : " & antecedente.IDDIAGNOSTICO & " " & antecedente.DIAGNOSTICO1.DIAGNOSTICO & " paciente :" & Me.IDPACIENTE.ToString())
                Catch ex As Exception
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Insertar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Antecedentes diagnosticos", antecedente.IDDIAGNOSTICO.ToString(), "diagnóstico : " & antecedente.IDDIAGNOSTICO & " paciente :" & Me.IDPACIENTE.ToString())
                End Try
                Cargar_AntecedentesDiagnostico()
            Catch ex As Exception
                MessageBox.Show("No ha podido cargarse el diagnóstico")
            End Try
        End If

    End Sub

    Private Sub tst_Editar_Diagnositco_Click(sender As Object, e As EventArgs) Handles tst_Editar_Diagnositco.Click
        If GridEXDiagnosticoAntecedente.SelectedItems.Count < 1 Then
            Return
        End If
        Dim antecedente As AntecedentesDiagnostico = GridEXDiagnosticoAntecedente.SelectedItems(0).GetRow.DataRow
        Dim context As New CMLinqDataContext()

        antecedente = (From a In context.AntecedentesDiagnosticos Where a.IDANTECEDENTEDX = antecedente.IDANTECEDENTEDX Select a).First()

        Dim frm As New frmAntecedentes_Editar(antecedente)


        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim d As DIAGNOSTICO = frm.CtrlDiagnosticosPrincipal.Diagnostico
            If d Is Nothing Then
                Return
            End If

            Try
                context.SubmitChanges()
                Try
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Antecedentes diagnosticos", antecedente.IDDIAGNOSTICO.ToString(), "diagnóstico : " & antecedente.IDDIAGNOSTICO & " " & antecedente.DIAGNOSTICO1.DIAGNOSTICO & " paciente :" & Me.IDPACIENTE.ToString())
                Catch ex As Exception
                    Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Modificar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Antecedentes diagnosticos", antecedente.IDDIAGNOSTICO.ToString(), "diagnóstico : " & antecedente.IDDIAGNOSTICO & " paciente :" & Me.IDPACIENTE.ToString())
                End Try
                Cargar_AntecedentesDiagnostico()
            Catch ex As Exception
                MessageBox.Show("no ha podido cargarse el diagnóstico")
            End Try
        End If

    End Sub

    Private Sub tst_Eliminar_Diagnositco_Click(sender As Object, e As EventArgs) Handles tst_Eliminar_Diagnositco.Click
        If GridEXDiagnosticoAntecedente.SelectedItems.Count < 1 Then
            Return
        End If
        Dim antecedente As AntecedentesDiagnostico = GridEXDiagnosticoAntecedente.SelectedItems(0).GetRow.DataRow
        Dim context As New CMLinqDataContext()

        antecedente = (From a In context.AntecedentesDiagnosticos Where a.IDANTECEDENTEDX = antecedente.IDANTECEDENTEDX Select a).First()
        context.AntecedentesDiagnosticos.DeleteOnSubmit(antecedente)
        context.SubmitChanges()
        Try
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Antecedentes diagnosticos", antecedente.IDDIAGNOSTICO.ToString(), "diagnóstico : " & antecedente.IDDIAGNOSTICO & " " & antecedente.DIAGNOSTICO1.DIAGNOSTICO & " paciente :" & Me.IDPACIENTE.ToString())
        Catch ex As Exception
            Globales.AuditoriaInfo.Registra(Globales.AuditoriaInfo.Accion.Borrar, RoleManager.Items.Pacientes_Antecedentes_Médicos, "Antecedentes diagnosticos", antecedente.IDDIAGNOSTICO.ToString(), "diagnóstico : " & antecedente.IDDIAGNOSTICO & " paciente :" & Me.IDPACIENTE.ToString())
        End Try
        Cargar_AntecedentesDiagnostico()
        If GridEXDiagnosticoAntecedente.SelectedItems.Count < 1 Then
            editDiagnosticoObservaciones.Text = ""
        End If
    End Sub

    Private Sub GridEXDiagnosticoAntecedente_DoubleClick(sender As Object, e As EventArgs) Handles GridEXDiagnosticoAntecedente.DoubleClick
        tst_Editar_Diagnositco_Click(Nothing, Nothing)
    End Sub

    Private Sub GridEXDiagnosticoAntecedente_SelectionChanged(sender As Object, e As EventArgs) Handles GridEXDiagnosticoAntecedente.SelectionChanged
        If GridEXDiagnosticoAntecedente.SelectedItems.Count < 1 Then
            editDiagnosticoObservaciones.Text = ""
            Return
        End If
        Dim antecedente As AntecedentesDiagnostico = GridEXDiagnosticoAntecedente.SelectedItems(0).GetRow.DataRow
        editDiagnosticoObservaciones.Text = Globales.TextFromRtf(antecedente.OBSERVACIONES)
    End Sub

    Private Sub CtrlEMPRESAMejorado1_EMPRESAEliminada()
        MessageBox.Show("eliminar empresa")
    End Sub

    Private Sub CtrlEMPRESAMejorado1_EMPRESANoEncontrada()
        MessageBox.Show("no encontrada empresa")
    End Sub

    Private Sub CtrlEMPRESAMejorado1_EMPRESASeleccionada(IdEMPRESA As Integer)
        MessageBox.Show("empresa seleccionada")
    End Sub
End Class