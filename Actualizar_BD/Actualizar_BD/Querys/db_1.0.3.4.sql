CREATE TABLE dbo.HORARIOS_MEDICOS
	(
	id int NOT NULL IDENTITY (1, 1),
	fecha date NOT NULL,
	hora_ini datetime NOT NULL,
	hora_fin datetime NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.HORARIOS_MEDICOS ADD CONSTRAINT
	PK_HORARIOS_MEDICOS PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

ALTER TABLE dbo.HORARIOS_MEDICOS ADD medico_id int not null
GO

ALTER TABLE dbo.HORARIOS_MEDICOS ADD CONSTRAINT
	FK_HORARIOS_MEDICOS_MEDICOS FOREIGN KEY
	(
	medico_id
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 

GO
Print 'Ampliar tamaño del campo Descripcion de auditoria';
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
	NombreUsuario varchar(50) NOT NULL,
	TipoDocumento varchar(50) NOT NULL,
	CodigoDocumento varchar(50) NOT NULL,
	DetallesDocumento varchar(MAX) NOT NULL,
	eAccion int NOT NULL,
	eLocacion int NOT NULL,
	loginUsuario nvarchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
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
	 EXEC('INSERT INTO dbo.Tmp_Auditoria (idLog, FechaHora, idUsuario, NombreUsuario, TipoDocumento, CodigoDocumento, DetallesDocumento, eAccion, eLocacion, loginUsuario)
		SELECT idLog, FechaHora, idUsuario, NombreUsuario, TipoDocumento, CodigoDocumento, CONVERT(varchar(MAX), DetallesDocumento), eAccion, eLocacion, loginUsuario FROM dbo.Auditoria WITH (HOLDLOCK TABLOCKX)')
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

GO



ALTER TABLE dbo.FICHEROS ADD
	ESCONSENTIMIENTO bit NOT NULL CONSTRAINT DF_FICHEROS_ESCONSENTIMIENTO DEFAULT 0
GO
Update VariablesGlobales Set Valor = '1.0.3.4' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.3.4';
