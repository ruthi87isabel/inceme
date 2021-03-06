/*
  Agregar los campos EstadoRecurrencia y Fecha Ultimo Estado Recurrencia
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
ALTER TABLE dbo.CITAS ADD
	EstadoRecurrencia int NULL,
	FechaUltimoEstadoRecurrencia datetime NULL
GO
COMMIT

/* Inserttar duracion por defecto a los conceptos Facturables*/
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
ALTER TABLE dbo.CONCEPTOSFRA ADD
	Duracion datetime NULL
GO
COMMIT

/* */
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
ALTER TABLE dbo.LineasCitas ADD
	Duracion datetime NULL
GO
COMMIT

/* */
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
ALTER TABLE dbo.Parentescos
	DROP CONSTRAINT DF_Parentescos_Descripcion
GO
CREATE TABLE dbo.Tmp_Parentescos
	(
	IdParentesco int NOT NULL,
	Descripcion varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Parentescos ADD CONSTRAINT
	DF_Parentescos_Descripcion DEFAULT ('') FOR Descripcion
GO
IF EXISTS(SELECT * FROM dbo.Parentescos)
	 EXEC('INSERT INTO dbo.Tmp_Parentescos (IdParentesco, Descripcion)
		SELECT IdParentesco, Descripcion FROM dbo.Parentescos WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.Parentescos
GO
EXECUTE sp_rename N'dbo.Tmp_Parentescos', N'Parentescos', 'OBJECT' 
GO
ALTER TABLE dbo.Parentescos ADD CONSTRAINT
	PK_Parentescos PRIMARY KEY CLUSTERED 
	(
	IdParentesco
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT


INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES ( 1,'Padre');
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES ( 2,'Madre');
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES ( 3,'Hermano(a)');
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES ( 4,'Hijo(a)'); 
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES ( 5,'Abuelo(a)'); 
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES ( 6,'Tio(a)'); 
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES ( 7,'Primo(a)'); 
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES ( 8,'Sobrino(a)');;
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES ( 9,'Bisabuelo(a)');
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES (10,'Conyugue');
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES (11,'Cuñado(a)');
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES (12,'Yerno/Nuera');
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES (13,'Nieto(a)');
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES (14,'Bisnieto(a)');
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES (15,'Tío(a) político(a)');
INSERT INTO Parentescos (IdParentesco, Descripcion) VALUES (16,'Primo(a) segundo(a)');




/*Tabla Asociados*/

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
CREATE TABLE dbo.Asociados
	(
	IDPacienteBeneficiario int NOT NULL,
	IDPacienteOrigen int NOT NULL,
	IDParentesco int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Asociados ADD CONSTRAINT
	PK_Asociados PRIMARY KEY CLUSTERED 
	(
	IDPacienteBeneficiario,
	IDPacienteOrigen
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

select Has_Perms_By_Name(N'dbo.Asociados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Asociados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Asociados', 'Object', 'CONTROL') as Contr_Per 



/*Relaciones Asociados con Paciente y Parentesco*/

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
select Has_Perms_By_Name(N'dbo.Parentescos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Parentescos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Parentescos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PACIENTES', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PACIENTES', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PACIENTES', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Asociados ADD CONSTRAINT
	FK_Asociados_PACIENTES FOREIGN KEY
	(
	IDPacienteBeneficiario
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.Asociados ADD CONSTRAINT
	FK_Asociados_PACIENTES1 FOREIGN KEY
	(
	IDPacienteOrigen
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Asociados ADD CONSTRAINT
	FK_Asociados_Parentescos FOREIGN KEY
	(
	IDParentesco
	) REFERENCES dbo.Parentescos
	(
	IdParentesco
	) ON UPDATE  SET NULL 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Asociados', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Asociados', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Asociados', 'Object', 'CONTROL') as Contr_Per 


Update VariablesGlobales Set Valor = '1.0.0.8' where Clave = 'DB_Version';