/* Modificar tabla Auditoria*/

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
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_FechaHora
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_NombreUsuario
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_TipoDocumento
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_CodigoDocumento
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_DetallesDocumento
GO
CREATE TABLE dbo.Tmp_Auditoria
	(
	idLog bigint NOT NULL IDENTITY (1, 1),
	FechaHora datetime NOT NULL,
	NombreUsuario varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	TipoDocumento varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CodigoDocumento varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DetallesDocumento varchar(300) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	eAccion int NOT NULL,
	eLocacion int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_FechaHora DEFAULT (getdate()) FOR FechaHora
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_NombreUsuario DEFAULT ('') FOR NombreUsuario
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_TipoDocumento DEFAULT ('') FOR TipoDocumento
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_CodigoDocumento DEFAULT ('') FOR CodigoDocumento
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_DetallesDocumento DEFAULT ('') FOR DetallesDocumento
GO
SET IDENTITY_INSERT dbo.Tmp_Auditoria ON
GO
IF EXISTS(SELECT * FROM dbo.Auditoria)
	 EXEC('INSERT INTO dbo.Tmp_Auditoria (idLog, FechaHora, NombreUsuario, TipoDocumento, CodigoDocumento, DetallesDocumento)
		SELECT CONVERT(bigint, idLog), FechaHora, NombreUsuario, TipoDocumento, CodigoDocumento, DetallesDocumento FROM dbo.Auditoria WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Auditoria OFF
GO
DROP TABLE dbo.Auditoria
GO
EXECUTE sp_rename N'dbo.Tmp_Auditoria', N'Auditoria', 'OBJECT' 
GO
ALTER TABLE dbo.Auditoria ADD CONSTRAINT
	PK_Auditoria PRIMARY KEY CLUSTERED 
	(
	idLog
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

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
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_FechaHora
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_NombreUsuario
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_TipoDocumento
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_CodigoDocumento
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_DetallesDocumento
GO
CREATE TABLE dbo.Tmp_Auditoria
	(
	idLog bigint NOT NULL IDENTITY (1, 1),
	FechaHora datetime NOT NULL,
	idUsuario int NULL,
	NombreUsuario varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	TipoDocumento varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CodigoDocumento varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DetallesDocumento varchar(300) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	eAccion int NOT NULL,
	eLocacion int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_FechaHora DEFAULT (getdate()) FOR FechaHora
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_NombreUsuario DEFAULT ('') FOR NombreUsuario
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_TipoDocumento DEFAULT ('') FOR TipoDocumento
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_CodigoDocumento DEFAULT ('') FOR CodigoDocumento
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_DetallesDocumento DEFAULT ('') FOR DetallesDocumento
GO
SET IDENTITY_INSERT dbo.Tmp_Auditoria ON
GO
IF EXISTS(SELECT * FROM dbo.Auditoria)
	 EXEC('INSERT INTO dbo.Tmp_Auditoria (idLog, FechaHora, NombreUsuario, TipoDocumento, CodigoDocumento, DetallesDocumento, eAccion, eLocacion)
		SELECT idLog, FechaHora, NombreUsuario, TipoDocumento, CodigoDocumento, DetallesDocumento, eAccion, eLocacion FROM dbo.Auditoria WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Auditoria OFF
GO
DROP TABLE dbo.Auditoria
GO
EXECUTE sp_rename N'dbo.Tmp_Auditoria', N'Auditoria', 'OBJECT' 
GO
ALTER TABLE dbo.Auditoria ADD CONSTRAINT
	PK_Auditoria PRIMARY KEY CLUSTERED 
	(
	idLog
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Auditoria ADD CONSTRAINT
	FK_Auditoria_Auditoria FOREIGN KEY
	(
	idLog
	) REFERENCES dbo.Auditoria
	(
	idLog
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

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
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT FK_Auditoria_Auditoria
GO
COMMIT


Update VariablesGlobales Set Valor = '1.0.0.7' where Clave = 'DB_Version';