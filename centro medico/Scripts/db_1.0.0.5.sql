/*
Modificacion de Citas y Facturas para incluir ID_Proceso

*/

/*
   Monday, March 08, 20103:33:28 PM
   User: 
   Server: ARWEN
   Database: CM_OBESMEDICA
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
COMMIT
GO
ALTER TABLE dbo.CITAS ADD
	ID_Proceso bigint NULL
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	FK_CITAS_N_Procesos FOREIGN KEY
	(
	ID_Proceso
	) REFERENCES dbo.N_Procesos
	(
	ID_Proceso
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO


/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
COMMIT
GO
ALTER TABLE dbo.FACTURAS ADD
	ID_Proceso bigint NULL
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	FK_FACTURAS_N_Procesos FOREIGN KEY
	(
	ID_Proceso
	) REFERENCES dbo.N_Procesos
	(
	ID_Proceso
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

/* 
	Annadir el ID_Cita a las LINEASFACTURAS
*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
COMMIT
GO
ALTER TABLE dbo.LINEASFACTURAS ADD
	ID_Cita int NULL
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	FK_LINEASFACTURAS_CITAS FOREIGN KEY
	(
	ID_Cita
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

/*Cambiar la longitud a Puesto de Trabajo paciente en N_Partes*/
/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes
	DROP CONSTRAINT FK_N_Partes_MEDICOS
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes
	DROP CONSTRAINT FK_N_Partes_DIAGNOSTICOS
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes
	DROP CONSTRAINT FK_N_Partes_EMPRESAS
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes
	DROP CONSTRAINT FK_N_Partes_Baja_N_Procesos
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_N_Partes
	(
	ID_Parte bigint NOT NULL IDENTITY (1, 1),
	ID_Proceso bigint NULL,
	ID_Paciente int NULL,
	E_Tipo int NULL,
	FechaBaja datetime NULL,
	FechaAlta datetime NULL,
	ID_ParteOrigen bigint NULL,
	Alta_Descripcion_Resultado_Reconocimiento nvarchar(MAX) NULL,
	Alta_E_Causa_de_Alta int NULL,
	FechaAT datetime NULL,
	E_Regimen int NULL,
	E_Situacion int NULL,
	Num_Tarjeta_sanitaria nvarchar(50) NULL,
	Num_Afiliacion_Seg_Social nvarchar(50) NULL,
	NombreCompletoPaciente nvarchar(50) NULL,
	DomicilioPaciente nvarchar(100) NULL,
	LocalidadPaciente nvarchar(100) NULL,
	ProvinciaPaciente nvarchar(50) NULL,
	Codigo_PostalPaciente nvarchar(50) NULL,
	TelefonoPaciente nvarchar(50) NULL,
	Puesto_de_trabajoPaciente nvarchar(MAX) NULL,
	ID_Empresa int NULL,
	NombreEmpresa nvarchar(50) NULL,
	DomicilioEmpresa nvarchar(50) NULL,
	LocalidadEmpresa nvarchar(50) NULL,
	ProvinciaEmpresa nvarchar(50) NULL,
	Codigo_Postal_Empresa nvarchar(50) NULL,
	Actividad_empresa nvarchar(MAX) NULL,
	Código_Nacional_Actividad_Económica_CNAE nvarchar(50) NULL,
	Entidad_Pago_IT_CP int NULL,
	DescripcionLimitacion nvarchar(MAX) NULL,
	ID_Diagnostico int NULL,
	Descripcion_Diagnostico nvarchar(MAX) NULL,
	Duracion_probable_baja_dias int NULL,
	Duracion_probable_baja_meses int NULL,
	Duracion_estandar_fecha_inicio datetime NULL,
	Duracion_estandar_fecha_final datetime NULL,
	E_Caracter int NULL,
	Recaida bit NULL,
	E_Causa_de_baja int NULL,
	ID_Medico int NULL,
	NombreMedico nvarchar(50) NULL,
	No_de_ColegiadoMedico nvarchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_N_Partes ON
GO
IF EXISTS(SELECT * FROM dbo.N_Partes)
	 EXEC('INSERT INTO dbo.Tmp_N_Partes (ID_Parte, ID_Proceso, ID_Paciente, E_Tipo, FechaBaja, FechaAlta, ID_ParteOrigen, Alta_Descripcion_Resultado_Reconocimiento, Alta_E_Causa_de_Alta, FechaAT, E_Regimen, E_Situacion, Num_Tarjeta_sanitaria, Num_Afiliacion_Seg_Social, NombreCompletoPaciente, DomicilioPaciente, LocalidadPaciente, ProvinciaPaciente, Codigo_PostalPaciente, TelefonoPaciente, Puesto_de_trabajoPaciente, ID_Empresa, NombreEmpresa, DomicilioEmpresa, LocalidadEmpresa, ProvinciaEmpresa, Codigo_Postal_Empresa, Actividad_empresa, Código_Nacional_Actividad_Económica_CNAE, Entidad_Pago_IT_CP, DescripcionLimitacion, ID_Diagnostico, Descripcion_Diagnostico, Duracion_probable_baja_dias, Duracion_probable_baja_meses, Duracion_estandar_fecha_inicio, Duracion_estandar_fecha_final, E_Caracter, Recaida, E_Causa_de_baja, ID_Medico, NombreMedico, No_de_ColegiadoMedico)
		SELECT ID_Parte, ID_Proceso, ID_Paciente, E_Tipo, FechaBaja, FechaAlta, ID_ParteOrigen, Alta_Descripcion_Resultado_Reconocimiento, Alta_E_Causa_de_Alta, FechaAT, E_Regimen, E_Situacion, Num_Tarjeta_sanitaria, Num_Afiliacion_Seg_Social, NombreCompletoPaciente, DomicilioPaciente, LocalidadPaciente, ProvinciaPaciente, Codigo_PostalPaciente, TelefonoPaciente, CONVERT(nvarchar(MAX), Puesto_de_trabajoPaciente), ID_Empresa, NombreEmpresa, DomicilioEmpresa, LocalidadEmpresa, ProvinciaEmpresa, Codigo_Postal_Empresa, Actividad_empresa, Código_Nacional_Actividad_Económica_CNAE, Entidad_Pago_IT_CP, DescripcionLimitacion, ID_Diagnostico, Descripcion_Diagnostico, Duracion_probable_baja_dias, Duracion_probable_baja_meses, Duracion_estandar_fecha_inicio, Duracion_estandar_fecha_final, E_Caracter, Recaida, E_Causa_de_baja, ID_Medico, NombreMedico, No_de_ColegiadoMedico FROM dbo.N_Partes WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Partes OFF
GO
ALTER TABLE dbo.N_Partes
	DROP CONSTRAINT FK_N_Partes_N_Partes
GO
DROP TABLE dbo.N_Partes
GO
EXECUTE sp_rename N'dbo.Tmp_N_Partes', N'N_Partes', 'OBJECT' 
GO
ALTER TABLE dbo.N_Partes ADD CONSTRAINT
	PK_N_ParteBaja PRIMARY KEY CLUSTERED 
	(
	ID_Parte
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Partes ADD CONSTRAINT
	FK_N_Partes_Baja_N_Procesos FOREIGN KEY
	(
	ID_Proceso
	) REFERENCES dbo.N_Procesos
	(
	ID_Proceso
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Partes ADD CONSTRAINT
	FK_N_Partes_N_Partes FOREIGN KEY
	(
	ID_ParteOrigen
	) REFERENCES dbo.N_Partes
	(
	ID_Parte
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Partes ADD CONSTRAINT
	FK_N_Partes_EMPRESAS FOREIGN KEY
	(
	ID_Empresa
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Partes ADD CONSTRAINT
	FK_N_Partes_DIAGNOSTICOS FOREIGN KEY
	(
	ID_Diagnostico
	) REFERENCES dbo.DIAGNOSTICOS
	(
	IDDIAGNOSTICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Partes ADD CONSTRAINT
	FK_N_Partes_MEDICOS FOREIGN KEY
	(
	ID_Medico
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
/*ENDS*/


/*Update VariablesGlobales Set Valor = '1.0.0.5' where Clave = 'vBdNecesaria';*/
Update VariablesGlobales Set Valor = '1.0.0.5' where Clave = 'DB_Version';