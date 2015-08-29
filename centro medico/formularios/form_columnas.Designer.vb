<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_columnas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ordenar_visibles = New centro_medico.ordenar_columnas()
        Me.ordenar_filtros = New centro_medico.ordenar_columnas()
        Me.bt_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chb_activo = New System.Windows.Forms.CheckBox()
        Me.chb_autofiltrar = New System.Windows.Forms.CheckBox()
        Me.chb_aprox = New System.Windows.Forms.CheckBox()
        Me.PACIENTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMDataSet = New centro_medico.CMDataSet()
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter()
        Me.MUTUASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FORMASPAGOTableAdapter = New centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter()
        Me.MUTUASTableAdapter = New centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter()
        Me.FORMASPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROVEEDORESTableAdapter = New centro_medico.CMDataSetTableAdapters.PROVEEDORESTableAdapter()
        Me.PAISESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFACTURABLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFACTURABLESTableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFACTURABLESTableAdapter()
        Me.BANCOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BANCOSTableAdapter = New centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter()
        Me.PAISESTableAdapter = New centro_medico.CMDataSetTableAdapters.PAISESTableAdapter()
        Me.CONCEPTOSANALITICATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSANALITICATableAdapter()
        Me.DERIVACIONES_DESTINOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DERIVACIONES_DESTINOSTableAdapter()
        Me.DERIVACIONES_DESTINOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSANALITICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALARMASTableAdapter = New centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter()
        Me.MEDICAMENTOSTableAdapter = New centro_medico.CMDataSetTableAdapters.MEDICAMENTOSTableAdapter()
        Me.ALARMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARTICULOSTableAdapter = New centro_medico.CMDataSetTableAdapters.ARTICULOSTableAdapter()
        Me.PLANTILLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLANTILLA_HISTORIALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLANTILLASTableAdapter = New centro_medico.CMDataSetTableAdapters.PLANTILLASTableAdapter()
        Me.GASTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIAGNOSTICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GASTOSTableAdapter = New centro_medico.CMDataSetTableAdapters.GASTOSTableAdapter()
        Me.PLANTILLA_HISTORIALESTableAdapter = New centro_medico.CMDataSetTableAdapters.PLANTILLA_HISTORIALESTableAdapter()
        Me.INDICACIONESTableAdapter = New centro_medico.CMDataSetTableAdapters.INDICACIONESTableAdapter()
        Me.INDICACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIAGNOSTICOSTableAdapter = New centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter()
        Me.PARTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PARTESTableAdapter = New centro_medico.CMDataSetTableAdapters.PARTESTableAdapter()
        Me.BAJASTableAdapter = New centro_medico.CMDataSetTableAdapters.BAJASTableAdapter()
        Me.ASISTENCIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAJASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALTASTableAdapter = New centro_medico.CMDataSetTableAdapters.ALTASTableAdapter()
        Me.ALTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASISTENCIASTableAdapter = New centro_medico.CMDataSetTableAdapters.ASISTENCIASTableAdapter()
        Me.EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter()
        Me.LMUTUASEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.ANALITICASTableAdapter()
        Me.PLANTILLAANALITICASTableAdapter = New centro_medico.CMDataSetTableAdapters.PLANTILLAANALITICASTableAdapter()
        Me.LMUTUASEMPRESASTableAdapter = New centro_medico.CMDataSetTableAdapters.LMUTUASEMPRESASTableAdapter()
        Me.FACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURASTableAdapter = New centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter()
        Me.CONCEPTOSFRATableAdapter = New centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter()
        Me.PLANTILLAANALITICASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONCEPTOSFRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOSTableAdapter = New centro_medico.CMDataSetTableAdapters.USUARIOSTableAdapter()
        Me.RECIBOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MODELOSCOMPARATIVATableAdapter = New centro_medico.CMDataSetTableAdapters.MODELOSCOMPARATIVATableAdapter()
        Me.MODELOSCOMPARATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECIBOSTableAdapter = New centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter()
        Me.lb_datos = New System.Windows.Forms.Label()
        Me.Columnas1 = New centro_medico.columnas()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAISESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSFACTURABLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BANCOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DERIVACIONES_DESTINOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTILLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTILLA_HISTORIALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GASTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PARTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAJASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMUTUASEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODELOSCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ordenar_visibles
        '
        Me.ordenar_visibles.Location = New System.Drawing.Point(347, 12)
        Me.ordenar_visibles.Name = "ordenar_visibles"
        Me.ordenar_visibles.Size = New System.Drawing.Size(161, 233)
        Me.ordenar_visibles.TabIndex = 3
        '
        'ordenar_filtros
        '
        Me.ordenar_filtros.Location = New System.Drawing.Point(347, 251)
        Me.ordenar_filtros.Name = "ordenar_filtros"
        Me.ordenar_filtros.Size = New System.Drawing.Size(161, 232)
        Me.ordenar_filtros.TabIndex = 4
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Image = Global.centro_medico.My.Resources.Resources.CHECKMRK
        Me.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_aceptar.Location = New System.Drawing.Point(433, 538)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 5
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chb_activo)
        Me.GroupBox1.Controls.Add(Me.chb_autofiltrar)
        Me.GroupBox1.Controls.Add(Me.chb_aprox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 489)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 43)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personalización del filtro"
        '
        'chb_activo
        '
        Me.chb_activo.AutoSize = True
        Me.chb_activo.Checked = True
        Me.chb_activo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_activo.Location = New System.Drawing.Point(335, 19)
        Me.chb_activo.Name = "chb_activo"
        Me.chb_activo.Size = New System.Drawing.Size(113, 17)
        Me.chb_activo.TabIndex = 2
        Me.chb_activo.Text = "Activo por defecto"
        Me.chb_activo.UseVisualStyleBackColor = True
        '
        'chb_autofiltrar
        '
        Me.chb_autofiltrar.AutoSize = True
        Me.chb_autofiltrar.Location = New System.Drawing.Point(174, 19)
        Me.chb_autofiltrar.Name = "chb_autofiltrar"
        Me.chb_autofiltrar.Size = New System.Drawing.Size(135, 17)
        Me.chb_autofiltrar.TabIndex = 1
        Me.chb_autofiltrar.Text = "Filtrar automáticamente"
        Me.chb_autofiltrar.UseVisualStyleBackColor = True
        '
        'chb_aprox
        '
        Me.chb_aprox.AutoSize = True
        Me.chb_aprox.Location = New System.Drawing.Point(16, 19)
        Me.chb_aprox.Name = "chb_aprox"
        Me.chb_aprox.Size = New System.Drawing.Size(131, 17)
        Me.chb_aprox.TabIndex = 0
        Me.chb_aprox.Text = "Búsqueda aproximada"
        Me.chb_aprox.UseVisualStyleBackColor = True
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.CMDataSet
        '
        'CMDataSet
        '
        Me.CMDataSet.DataSetName = "CMDataSet"
        Me.CMDataSet.EnforceConstraints = False
        Me.CMDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICOSBindingSource
        '
        Me.MEDICOSBindingSource.DataMember = "MEDICOS"
        Me.MEDICOSBindingSource.DataSource = Me.CMDataSet
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'MUTUASBindingSource
        '
        Me.MUTUASBindingSource.DataMember = "MUTUAS"
        Me.MUTUASBindingSource.DataSource = Me.CMDataSet
        '
        'FORMASPAGOTableAdapter
        '
        Me.FORMASPAGOTableAdapter.ClearBeforeFill = True
        '
        'MUTUASTableAdapter
        '
        Me.MUTUASTableAdapter.ClearBeforeFill = True
        '
        'FORMASPAGOBindingSource
        '
        Me.FORMASPAGOBindingSource.DataMember = "FORMASPAGO"
        Me.FORMASPAGOBindingSource.DataSource = Me.CMDataSet
        '
        'PROVEEDORESBindingSource
        '
        Me.PROVEEDORESBindingSource.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource.DataSource = Me.CMDataSet
        '
        'PROVEEDORESTableAdapter
        '
        Me.PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'PAISESBindingSource
        '
        Me.PAISESBindingSource.DataMember = "PAISES"
        Me.PAISESBindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSFACTURABLESBindingSource
        '
        Me.CONCEPTOSFACTURABLESBindingSource.DataMember = "CONCEPTOSFACTURABLES"
        Me.CONCEPTOSFACTURABLESBindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSFACTURABLESTableAdapter
        '
        Me.CONCEPTOSFACTURABLESTableAdapter.ClearBeforeFill = True
        '
        'BANCOSBindingSource
        '
        Me.BANCOSBindingSource.DataMember = "BANCOS"
        Me.BANCOSBindingSource.DataSource = Me.CMDataSet
        '
        'BANCOSTableAdapter
        '
        Me.BANCOSTableAdapter.ClearBeforeFill = True
        '
        'PAISESTableAdapter
        '
        Me.PAISESTableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSANALITICATableAdapter
        '
        Me.CONCEPTOSANALITICATableAdapter.ClearBeforeFill = True
        '
        'DERIVACIONES_DESTINOSTableAdapter
        '
        Me.DERIVACIONES_DESTINOSTableAdapter.ClearBeforeFill = True
        '
        'DERIVACIONES_DESTINOSBindingSource
        '
        Me.DERIVACIONES_DESTINOSBindingSource.DataMember = "DERIVACIONES_DESTINOS"
        Me.DERIVACIONES_DESTINOSBindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSANALITICABindingSource
        '
        Me.CONCEPTOSANALITICABindingSource.DataMember = "CONCEPTOSANALITICA"
        Me.CONCEPTOSANALITICABindingSource.DataSource = Me.CMDataSet
        '
        'ALARMASTableAdapter
        '
        Me.ALARMASTableAdapter.ClearBeforeFill = True
        '
        'MEDICAMENTOSTableAdapter
        '
        Me.MEDICAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'ALARMASBindingSource
        '
        Me.ALARMASBindingSource.DataMember = "ALARMAS"
        Me.ALARMASBindingSource.DataSource = Me.CMDataSet
        '
        'MEDICAMENTOSBindingSource
        '
        Me.MEDICAMENTOSBindingSource.DataMember = "MEDICAMENTOS"
        Me.MEDICAMENTOSBindingSource.DataSource = Me.CMDataSet
        '
        'ARTICULOSTableAdapter
        '
        Me.ARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'PLANTILLASBindingSource
        '
        Me.PLANTILLASBindingSource.DataMember = "PLANTILLAS"
        Me.PLANTILLASBindingSource.DataSource = Me.CMDataSet
        '
        'ARTICULOSBindingSource
        '
        Me.ARTICULOSBindingSource.DataMember = "ARTICULOS"
        Me.ARTICULOSBindingSource.DataSource = Me.CMDataSet
        '
        'PLANTILLA_HISTORIALESBindingSource
        '
        Me.PLANTILLA_HISTORIALESBindingSource.DataMember = "PLANTILLA_HISTORIALES"
        Me.PLANTILLA_HISTORIALESBindingSource.DataSource = Me.CMDataSet
        '
        'PLANTILLASTableAdapter
        '
        Me.PLANTILLASTableAdapter.ClearBeforeFill = True
        '
        'GASTOSBindingSource
        '
        Me.GASTOSBindingSource.DataMember = "GASTOS"
        Me.GASTOSBindingSource.DataSource = Me.CMDataSet
        '
        'DIAGNOSTICOSBindingSource
        '
        Me.DIAGNOSTICOSBindingSource.DataMember = "DIAGNOSTICOS"
        Me.DIAGNOSTICOSBindingSource.DataSource = Me.CMDataSet
        '
        'GASTOSTableAdapter
        '
        Me.GASTOSTableAdapter.ClearBeforeFill = True
        '
        'PLANTILLA_HISTORIALESTableAdapter
        '
        Me.PLANTILLA_HISTORIALESTableAdapter.ClearBeforeFill = True
        '
        'INDICACIONESTableAdapter
        '
        Me.INDICACIONESTableAdapter.ClearBeforeFill = True
        '
        'INDICACIONESBindingSource
        '
        Me.INDICACIONESBindingSource.DataMember = "INDICACIONES"
        Me.INDICACIONESBindingSource.DataSource = Me.CMDataSet
        '
        'DIAGNOSTICOSTableAdapter
        '
        Me.DIAGNOSTICOSTableAdapter.ClearBeforeFill = True
        '
        'PARTESBindingSource
        '
        Me.PARTESBindingSource.DataMember = "PARTES"
        Me.PARTESBindingSource.DataSource = Me.CMDataSet
        '
        'PARTESTableAdapter
        '
        Me.PARTESTableAdapter.ClearBeforeFill = True
        '
        'BAJASTableAdapter
        '
        Me.BAJASTableAdapter.ClearBeforeFill = True
        '
        'ASISTENCIASBindingSource
        '
        Me.ASISTENCIASBindingSource.DataMember = "ASISTENCIAS"
        Me.ASISTENCIASBindingSource.DataSource = Me.CMDataSet
        '
        'BAJASBindingSource
        '
        Me.BAJASBindingSource.DataMember = "BAJAS"
        Me.BAJASBindingSource.DataSource = Me.CMDataSet
        '
        'ALTASTableAdapter
        '
        Me.ALTASTableAdapter.ClearBeforeFill = True
        '
        'ALTASBindingSource
        '
        Me.ALTASBindingSource.DataMember = "ALTAS"
        Me.ALTASBindingSource.DataSource = Me.CMDataSet
        '
        'ASISTENCIASTableAdapter
        '
        Me.ASISTENCIASTableAdapter.ClearBeforeFill = True
        '
        'EMPRESASBindingSource
        '
        Me.EMPRESASBindingSource.DataMember = "EMPRESAS"
        Me.EMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'EMPRESASTableAdapter
        '
        Me.EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'LMUTUASEMPRESASBindingSource
        '
        Me.LMUTUASEMPRESASBindingSource.DataMember = "LMUTUASEMPRESAS"
        Me.LMUTUASEMPRESASBindingSource.DataSource = Me.CMDataSet
        '
        'ANALITICASBindingSource
        '
        Me.ANALITICASBindingSource.DataMember = "ANALITICAS"
        Me.ANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'ANALITICASTableAdapter
        '
        Me.ANALITICASTableAdapter.ClearBeforeFill = True
        '
        'PLANTILLAANALITICASTableAdapter
        '
        Me.PLANTILLAANALITICASTableAdapter.ClearBeforeFill = True
        '
        'LMUTUASEMPRESASTableAdapter
        '
        Me.LMUTUASEMPRESASTableAdapter.ClearBeforeFill = True
        '
        'FACTURASBindingSource
        '
        Me.FACTURASBindingSource.DataMember = "FACTURAS"
        Me.FACTURASBindingSource.DataSource = Me.CMDataSet
        '
        'FACTURASTableAdapter
        '
        Me.FACTURASTableAdapter.ClearBeforeFill = True
        '
        'CONCEPTOSFRATableAdapter
        '
        Me.CONCEPTOSFRATableAdapter.ClearBeforeFill = True
        '
        'PLANTILLAANALITICASBindingSource
        '
        Me.PLANTILLAANALITICASBindingSource.DataMember = "PLANTILLAANALITICAS"
        Me.PLANTILLAANALITICASBindingSource.DataSource = Me.CMDataSet
        '
        'CONCEPTOSFRABindingSource
        '
        Me.CONCEPTOSFRABindingSource.DataMember = "CONCEPTOSFRA"
        Me.CONCEPTOSFRABindingSource.DataSource = Me.CMDataSet
        '
        'USUARIOSBindingSource
        '
        Me.USUARIOSBindingSource.DataMember = "USUARIOS"
        Me.USUARIOSBindingSource.DataSource = Me.CMDataSet
        '
        'USUARIOSTableAdapter
        '
        Me.USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'RECIBOSBindingSource
        '
        Me.RECIBOSBindingSource.DataMember = "RECIBOS"
        Me.RECIBOSBindingSource.DataSource = Me.CMDataSet
        '
        'MODELOSCOMPARATIVATableAdapter
        '
        Me.MODELOSCOMPARATIVATableAdapter.ClearBeforeFill = True
        '
        'MODELOSCOMPARATIVABindingSource
        '
        Me.MODELOSCOMPARATIVABindingSource.DataMember = "MODELOSCOMPARATIVA"
        Me.MODELOSCOMPARATIVABindingSource.DataSource = Me.CMDataSet
        '
        'RECIBOSTableAdapter
        '
        Me.RECIBOSTableAdapter.ClearBeforeFill = True
        '
        'lb_datos
        '
        Me.lb_datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lb_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datos.Location = New System.Drawing.Point(6, 12)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(327, 19)
        Me.lb_datos.TabIndex = 64
        Me.lb_datos.Text = "Columnas disponibles"
        Me.lb_datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Columnas1
        '
        Me.Columnas1.AutoScroll = True
        Me.Columnas1.Location = New System.Drawing.Point(6, 35)
        Me.Columnas1.Name = "Columnas1"
        Me.Columnas1.Size = New System.Drawing.Size(327, 402)
        Me.Columnas1.TabIndex = 0
        '
        'form_columnas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 564)
        Me.Controls.Add(Me.Columnas1)
        Me.Controls.Add(Me.lb_datos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.ordenar_filtros)
        Me.Controls.Add(Me.ordenar_visibles)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_columnas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar columnas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MUTUASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMASPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAISESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSFACTURABLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BANCOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DERIVACIONES_DESTINOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSANALITICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALARMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTILLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTILLA_HISTORIALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GASTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIAGNOSTICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PARTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAJASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMUTUASEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTILLAANALITICASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONCEPTOSFRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECIBOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODELOSCOMPARATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_activo As System.Windows.Forms.CheckBox
    Friend WithEvents chb_autofiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents chb_aprox As System.Windows.Forms.CheckBox
    Public WithEvents ordenar_visibles As centro_medico.ordenar_columnas
    Public WithEvents ordenar_filtros As centro_medico.ordenar_columnas
    Friend WithEvents PACIENTESTableAdapter As centro_medico.CMDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents PACIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMDataSet As centro_medico.CMDataSet
    Friend WithEvents MEDICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents MUTUASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FORMASPAGOTableAdapter As centro_medico.CMDataSetTableAdapters.FORMASPAGOTableAdapter
    Friend WithEvents MUTUASTableAdapter As centro_medico.CMDataSetTableAdapters.MUTUASTableAdapter
    Friend WithEvents FORMASPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROVEEDORESTableAdapter As centro_medico.CMDataSetTableAdapters.PROVEEDORESTableAdapter
    Friend WithEvents PAISESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFACTURABLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFACTURABLESTableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFACTURABLESTableAdapter
    Friend WithEvents BANCOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BANCOSTableAdapter As centro_medico.CMDataSetTableAdapters.BANCOSTableAdapter
    Friend WithEvents PAISESTableAdapter As centro_medico.CMDataSetTableAdapters.PAISESTableAdapter
    Friend WithEvents CONCEPTOSANALITICATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSANALITICATableAdapter
    Friend WithEvents DERIVACIONES_DESTINOSTableAdapter As centro_medico.CMDataSetTableAdapters.DERIVACIONES_DESTINOSTableAdapter
    Friend WithEvents DERIVACIONES_DESTINOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSANALITICABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALARMASTableAdapter As centro_medico.CMDataSetTableAdapters.ALARMASTableAdapter
    Friend WithEvents MEDICAMENTOSTableAdapter As centro_medico.CMDataSetTableAdapters.MEDICAMENTOSTableAdapter
    Friend WithEvents ALARMASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOSTableAdapter As centro_medico.CMDataSetTableAdapters.ARTICULOSTableAdapter
    Friend WithEvents PLANTILLASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLANTILLA_HISTORIALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLANTILLASTableAdapter As centro_medico.CMDataSetTableAdapters.PLANTILLASTableAdapter
    Friend WithEvents GASTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIAGNOSTICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GASTOSTableAdapter As centro_medico.CMDataSetTableAdapters.GASTOSTableAdapter
    Friend WithEvents PLANTILLA_HISTORIALESTableAdapter As centro_medico.CMDataSetTableAdapters.PLANTILLA_HISTORIALESTableAdapter
    Friend WithEvents INDICACIONESTableAdapter As centro_medico.CMDataSetTableAdapters.INDICACIONESTableAdapter
    Friend WithEvents INDICACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIAGNOSTICOSTableAdapter As centro_medico.CMDataSetTableAdapters.DIAGNOSTICOSTableAdapter
    Friend WithEvents PARTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PARTESTableAdapter As centro_medico.CMDataSetTableAdapters.PARTESTableAdapter
    Friend WithEvents BAJASTableAdapter As centro_medico.CMDataSetTableAdapters.BAJASTableAdapter
    Friend WithEvents ASISTENCIASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BAJASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALTASTableAdapter As centro_medico.CMDataSetTableAdapters.ALTASTableAdapter
    Friend WithEvents ALTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASISTENCIASTableAdapter As centro_medico.CMDataSetTableAdapters.ASISTENCIASTableAdapter
    Friend WithEvents EMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.EMPRESASTableAdapter
    Friend WithEvents LMUTUASEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.ANALITICASTableAdapter
    Friend WithEvents PLANTILLAANALITICASTableAdapter As centro_medico.CMDataSetTableAdapters.PLANTILLAANALITICASTableAdapter
    Friend WithEvents LMUTUASEMPRESASTableAdapter As centro_medico.CMDataSetTableAdapters.LMUTUASEMPRESASTableAdapter
    Friend WithEvents FACTURASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURASTableAdapter As centro_medico.CMDataSetTableAdapters.FACTURASTableAdapter
    Friend WithEvents CONCEPTOSFRATableAdapter As centro_medico.CMDataSetTableAdapters.CONCEPTOSFRATableAdapter
    Friend WithEvents PLANTILLAANALITICASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONCEPTOSFRABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USUARIOSTableAdapter As centro_medico.CMDataSetTableAdapters.USUARIOSTableAdapter
    Friend WithEvents RECIBOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MODELOSCOMPARATIVATableAdapter As centro_medico.CMDataSetTableAdapters.MODELOSCOMPARATIVATableAdapter
    Friend WithEvents MODELOSCOMPARATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECIBOSTableAdapter As centro_medico.CMDataSetTableAdapters.RECIBOSTableAdapter
    Friend WithEvents lb_datos As System.Windows.Forms.Label
    Friend WithEvents Columnas1 As centro_medico.columnas
End Class
