/****** Object:  Table [dbo].[CALENDARIO_GLOBAL]    Script Date: 02/17/2012 02:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CALENDARIO_GLOBAL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Anno] [int] NULL,
	[Calendario] [xml] NULL,
 CONSTRAINT [PK_CALENDARIO_GLOBAL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CALENDARIO_USUARIOS]    Script Date: 02/17/2012 02:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CALENDARIO_USUARIOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[Anno] [int] NULL,
	[Calendario] [xml] NULL,
 CONSTRAINT [PK_CALENDARIO_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CALENDARIO_MEDICOS]    Script Date: 02/17/2012 02:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CALENDARIO_MEDICOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_MEDICO] [int] NULL,
	[Anno] [int] NULL,
	[Calendario] [xml] NULL,
 CONSTRAINT [PK_CALENDARIO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_CALENDARIO_MEDICOS_MEDICOS]    Script Date: 02/17/2012 02:16:24 ******/
ALTER TABLE [dbo].[CALENDARIO_MEDICOS]  WITH CHECK ADD  CONSTRAINT [FK_CALENDARIO_MEDICOS_MEDICOS] FOREIGN KEY([ID_MEDICO])
REFERENCES [dbo].[MEDICOS] ([CMEDICO])
GO
ALTER TABLE [dbo].[CALENDARIO_MEDICOS] CHECK CONSTRAINT [FK_CALENDARIO_MEDICOS_MEDICOS]
GO
/****** Object:  ForeignKey [FK_CALENDARIO_USUARIOS_USUARIOS]    Script Date: 02/17/2012 02:16:24 ******/
ALTER TABLE [dbo].[CALENDARIO_USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_CALENDARIO_USUARIOS_USUARIOS] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[USUARIOS] ([CODIGO])
GO
ALTER TABLE [dbo].[CALENDARIO_USUARIOS] CHECK CONSTRAINT [FK_CALENDARIO_USUARIOS_USUARIOS]
GO




/* ANNADIR COLUMNA TipoCita a tabla CITAS*/
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
	TipoCita int NULL
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	DF_CITAS_TipoCita DEFAULT 0 FOR TipoCita
GO
COMMIT



/* Annadir campo ParentHistorial a tabla Historiales*/
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
ALTER TABLE dbo.HISTORIALES ADD
	ParentHistorial int NULL
GO
ALTER TABLE dbo.HISTORIALES ADD CONSTRAINT
	FK_HISTORIALES_HISTORIALES FOREIGN KEY
	(
	ParentHistorial
	) REFERENCES dbo.HISTORIALES
	(
	CHISTORIAL
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
go
COMMIT


/* Agregar Campo Eliminado a Pacientes*/
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
ALTER TABLE dbo.PACIENTES ADD
	Eliminado bit NULL
GO
ALTER TABLE dbo.PACIENTES ADD CONSTRAINT
	DF_PACIENTES_Eliminado DEFAULT 0 FOR Eliminado
GO
COMMIT


/*BEGIN Annadir FechaEnvio a tabla FACTURAS*/
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
ALTER TABLE dbo.FACTURAS ADD
	FECHAENVIO datetime NULL
GO
COMMIT
/*END Annadir FechaEnvio a tabla FACTURAS*/


Update VariablesGlobales Set Valor = '1.0.1.6' where Clave = 'DB_Version';