IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_d_Acciones_CONCEPTOSFRA]') AND parent_object_id = OBJECT_ID(N'[dbo].[d_Acciones]'))
ALTER TABLE [dbo].[d_Acciones] DROP CONSTRAINT [FK_d_Acciones_CONCEPTOSFRA]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_d_Acciones_d_Acciones]') AND parent_object_id = OBJECT_ID(N'[dbo].[d_Acciones]'))
ALTER TABLE [dbo].[d_Acciones] DROP CONSTRAINT [FK_d_Acciones_d_Acciones]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_d_Acciones_d_Odontogramas]') AND parent_object_id = OBJECT_ID(N'[dbo].[d_Acciones]'))
ALTER TABLE [dbo].[d_Acciones] DROP CONSTRAINT [FK_d_Acciones_d_Odontogramas]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CONCEPTOSFRA_ConceptosFra_Imagenes]') AND parent_object_id = OBJECT_ID(N'[dbo].[d_ConceptosFra_Imagenes]'))
ALTER TABLE [dbo].[d_ConceptosFra_Imagenes] DROP CONSTRAINT [FK_CONCEPTOSFRA_ConceptosFra_Imagenes]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Imagenes_ConceptosFra_Imagenes]') AND parent_object_id = OBJECT_ID(N'[dbo].[d_ConceptosFra_Imagenes]'))
ALTER TABLE [dbo].[d_ConceptosFra_Imagenes] DROP CONSTRAINT [FK_Imagenes_ConceptosFra_Imagenes]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_d_Odontogramas_PACIENTES]') AND parent_object_id = OBJECT_ID(N'[dbo].[d_Odontogramas]'))
ALTER TABLE [dbo].[d_Odontogramas] DROP CONSTRAINT [FK_d_Odontogramas_PACIENTES]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_d_Presupuesto_d_Odontogramas]') AND parent_object_id = OBJECT_ID(N'[dbo].[d_Presupuesto]'))
ALTER TABLE [dbo].[d_Presupuesto] DROP CONSTRAINT [FK_d_Presupuesto_d_Odontogramas]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_d_PresupuestoLineas_Citas]') AND parent_object_id = OBJECT_ID(N'[dbo].[d_PresupuestoLineas]'))
ALTER TABLE [dbo].[d_PresupuestoLineas] DROP CONSTRAINT [FK_d_PresupuestoLineas_Citas]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_d_PresupuestoLineas_CONCEPTOSFRA]') AND parent_object_id = OBJECT_ID(N'[dbo].[d_PresupuestoLineas]'))
ALTER TABLE [dbo].[d_PresupuestoLineas] DROP CONSTRAINT [FK_d_PresupuestoLineas_CONCEPTOSFRA]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_d_PresupuestoLineas_d_Presupuesto]') AND parent_object_id = OBJECT_ID(N'[dbo].[d_PresupuestoLineas]'))
ALTER TABLE [dbo].[d_PresupuestoLineas] DROP CONSTRAINT [FK_d_PresupuestoLineas_d_Presupuesto]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LineasCitas_d_PresupuestoLineas]') AND parent_object_id = OBJECT_ID(N'[dbo].[LineasCitas]'))
ALTER TABLE [dbo].[LineasCitas] DROP CONSTRAINT [FK_LineasCitas_d_PresupuestoLineas]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CONCEPTOSFAMILIAS]') AND type in (N'U'))
DROP TABLE [dbo].[CONCEPTOSFAMILIAS]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[d_Dientes]') AND type in (N'U'))
DROP TABLE [dbo].[d_Dientes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[d_Acciones]') AND type in (N'U'))
DROP TABLE [dbo].[d_Acciones]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[d_Colores]') AND type in (N'U'))
DROP TABLE [dbo].[d_Colores]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[d_ConceptosFra_Imagenes]') AND type in (N'U'))
DROP TABLE [dbo].[d_ConceptosFra_Imagenes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[d_Odontogramas]') AND type in (N'U'))
DROP TABLE [dbo].[d_Odontogramas]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[d_Presupuesto]') AND type in (N'U'))
DROP TABLE [dbo].[d_Presupuesto]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[d_PresupuestoLineas]') AND type in (N'U'))
DROP TABLE [dbo].[d_PresupuestoLineas]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[d_Imagenes]') AND type in (N'U'))
DROP TABLE [dbo].[d_Imagenes]


/*BEGIN Creacion de Tabla CONCEPTOSFAMILIAS */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONCEPTOSFAMILIAS](
	[IDFamilia] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Categoria] [int] NULL,
	[IconoName] [image] NULL,
	[Natural] [bit] NOT NULL CONSTRAINT [df_CONCEPTOSFAMILIAS_Natural]  DEFAULT ((0)),
 CONSTRAINT [PK_CONCEPTOSFAMILIAS] PRIMARY KEY CLUSTERED 
(
	[IDFamilia] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/*END Creacion de Tabla CONCEPTOSFAMILIAS */

/* BEGIN Modificación para agregar Campo IDFAMILIA y XMLField en CONCEPTOSFRA*/
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

IF NOT EXISTS (SELECT * FROM information_schema.columns where table_name ='CONCEPTOSFRA'  and column_name='IDFAMILIA')
BEGIN
ALTER TABLE dbo.CONCEPTOSFRA ADD
	IDFAMILIA int NULL,
	XMLCont nvarchar(MAX) NULL
END
GO
/*
ALTER TABLE dbo.CONCEPTOSFRA ADD CONSTRAINT
	FK_CONCEPTOSFRA_CONCEPTOSFAMILIAS FOREIGN KEY
	(
	IDFAMILIA
	) REFERENCES dbo.CONCEPTOSFAMILIAS
	(
	IDFamilia
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
*/	
GO

COMMIT

/* END */

/* BEGIN Creación de tabla d_Dientes, con la definicion de los dientes */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[d_Dientes](
	[IDDiente] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[PosicionOriginal] [int] NULL,
	[Planos] [nvarchar](50) NULL,
	[TipoDenticion] [int] NULL,
 CONSTRAINT [PK_d_Dientes] PRIMARY KEY CLUSTERED 
(
	[IDDiente] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/* END Creación de tabla d_Dientes, con la definicion de los dientes */



/* BEGIN Creación tabla Odontograma*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[d_Odontogramas](
	[IDOdontograma] [int] IDENTITY(1,1) NOT NULL,
	[IDPaciente] [int] NULL,
	[Fecha] [datetime] NULL CONSTRAINT [DF_d_Odontogramas_Fecha]  DEFAULT (getdate()),
	[TipoDenticion] [int] NULL,
 CONSTRAINT [PK_d_Odontogramas] PRIMARY KEY CLUSTERED 
(
	[IDOdontograma] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[d_Odontogramas]  WITH CHECK ADD  CONSTRAINT [FK_d_Odontogramas_PACIENTES] FOREIGN KEY([IDPaciente])
REFERENCES [dbo].[PACIENTES] ([CPACIENTE])
GO
ALTER TABLE [dbo].[d_Odontogramas] CHECK CONSTRAINT [FK_d_Odontogramas_PACIENTES]
GO
/* END Creación tabla Odontograma*/





/* BEGIN Creación tabla d_Acciones */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[d_Acciones](
	[IDOdontograma] [int] NULL,
	[FechaEjecucion] [datetime] NULL,
	[IDMedico] [int] NULL,
	[DescripcionGenerada] [nvarchar](250) NULL,
	[IDGabinete] [int] NULL CONSTRAINT [DF_d_Acciones_IDGabinete]  DEFAULT ((1)),
	[IDTratamiento] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Cuadrantes] [nvarchar](50) NULL,
	[PiezasInvolucradas] [nvarchar](50) NULL,
	[Urgente] [int] NULL CONSTRAINT [DF_d_Acciones_Urgente]  DEFAULT ((0)),
	[IDAccion] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_d_Acciones] PRIMARY KEY CLUSTERED 
(
	[IDAccion] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[d_Acciones]  WITH CHECK ADD  CONSTRAINT [FK_d_Acciones_CONCEPTOSFRA] FOREIGN KEY([IDTratamiento])
REFERENCES [dbo].[CONCEPTOSFRA] ([CODIGO])
GO
ALTER TABLE [dbo].[d_Acciones] CHECK CONSTRAINT [FK_d_Acciones_CONCEPTOSFRA]
GO

ALTER TABLE [dbo].[d_Acciones]  WITH CHECK ADD  CONSTRAINT [FK_d_Acciones_d_Acciones] FOREIGN KEY([IDMedico])
REFERENCES [dbo].[MEDICOS] ([CMEDICO])
GO
ALTER TABLE [dbo].[d_Acciones] CHECK CONSTRAINT [FK_d_Acciones_d_Acciones]
GO

ALTER TABLE [dbo].[d_Acciones]  WITH CHECK ADD  CONSTRAINT [FK_d_Acciones_d_Odontogramas] FOREIGN KEY([IDOdontograma])
REFERENCES [dbo].[d_Odontogramas] ([IDOdontograma])
GO
ALTER TABLE [dbo].[d_Acciones] CHECK CONSTRAINT [FK_d_Acciones_d_Odontogramas]
GO
/* END Creación tabla d_Acciones */




/* 1.0.1.1*/

/* Insertar Familia CONCEPTOSDENTALES por Defecto */ 
INSERT INTO CONCEPTOSFAMILIAS (IDFamilia, Descripcion, Categoria) VALUES (1,'Varios',1)
INSERT INTO CONCEPTOSFAMILIAS (IDFamilia, Descripcion, Categoria) VALUES (2,'Conceptos Dentales',2)


/* 1.0.1.2*/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[d_Colores](
	[IDColor] [int] NOT NULL CONSTRAINT [DF_d_Colores_IDColor]  DEFAULT ((1)),
	[clPendiente] [int] NOT NULL CONSTRAINT [DF_d_Colores_clPendiente]  DEFAULT ((0)),
	[clPrimeravista] [int] NOT NULL CONSTRAINT [DF_d_Colores_clPrimeravista]  DEFAULT ((0)),
	[clPresupuesto] [int] NOT NULL CONSTRAINT [DF_d_Colores_clPresupuesto]  DEFAULT ((0)),
	[clRealizado] [int] NOT NULL CONSTRAINT [DF_d_Colores_clRealizado]  DEFAULT ((0)),
	[clUrgente] [int] NOT NULL CONSTRAINT [DF_d_Colores_clUrgente]  DEFAULT ((0)),
 CONSTRAINT [PK_d_Colores] PRIMARY KEY CLUSTERED 
(
	[IDColor] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[d_Imagenes](
	[IDImagen] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [image] NOT NULL,
	[Descripcion] [varchar](150) NULL,
	[Crdt] [datetime] NOT NULL,
 CONSTRAINT [PK_d_Cfra_Imagen_1] PRIMARY KEY CLUSTERED 
(
	[IDImagen] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[d_ConceptosFra_Imagenes](
	[CodigoCfra] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Cuadrante] [char](1) NOT NULL,
	[IDImagen] [int] NOT NULL,
	[Pintar] [bit] NOT NULL CONSTRAINT [DF_d_ConceptosFra_Imagenes_Pintar]  DEFAULT ((1)),
 CONSTRAINT [PK_d_ConceptosFra_Imagenes_1] PRIMARY KEY CLUSTERED 
(
	[CodigoCfra] ASC,
	[Cuadrante] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[d_ConceptosFra_Imagenes]  WITH CHECK ADD  CONSTRAINT [FK_CONCEPTOSFRA_ConceptosFra_Imagenes] FOREIGN KEY([CodigoCfra])
REFERENCES [dbo].[CONCEPTOSFRA] ([CODIGO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[d_ConceptosFra_Imagenes] CHECK CONSTRAINT [FK_CONCEPTOSFRA_ConceptosFra_Imagenes]
GO

ALTER TABLE [dbo].[d_ConceptosFra_Imagenes]  WITH CHECK ADD  CONSTRAINT [FK_Imagenes_ConceptosFra_Imagenes] FOREIGN KEY([IDImagen])
REFERENCES [dbo].[d_Imagenes] ([IDImagen])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[d_ConceptosFra_Imagenes] CHECK CONSTRAINT [FK_Imagenes_ConceptosFra_Imagenes]
GO


/*1.0.1.3*/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[d_Presupuesto](
	[IDPresupuesto] [int] IDENTITY(1,1) NOT NULL,
	[IDOdontograma] [int] NOT NULL,
	[FechaConcepcion] [datetime] NOT NULL,
 CONSTRAINT [PK_d_Presupuesto] PRIMARY KEY CLUSTERED 
(
	[IDPresupuesto] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[d_Presupuesto]  WITH CHECK ADD  CONSTRAINT [FK_d_Presupuesto_d_Odontogramas] FOREIGN KEY([IDOdontograma])
REFERENCES [dbo].[d_Odontogramas] ([IDOdontograma])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[d_Presupuesto] CHECK CONSTRAINT [FK_d_Presupuesto_d_Odontogramas]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[d_PresupuestoLineas](
	[IDPresupuestoLinea] [bigint] IDENTITY(1,1) NOT NULL,
	[IDPresupuesto] [int] NOT NULL,
	[DescripcionGenerada] [nvarchar](250) NULL,
	[IDTratamiento] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Cuadrantes] [nvarchar](50) NULL,
	[PiezasInvolucradas] [nvarchar](50) NULL,
	[Confirmado] [bit] NOT NULL CONSTRAINT [DF_d_PresupuestoLineas_Confirmado]  DEFAULT ((0)),
	[Realizado] [bit] NOT NULL CONSTRAINT [DF_d_PresupuestoLineas_Realizado]  DEFAULT ((0)),
	[Urgencia] [int] NOT NULL CONSTRAINT [DF_d_PresupuestoLineas_Urgencia]  DEFAULT ((0)),
	[FechaConfirmado] [datetime] NULL,
	[FechaRealizado] [datetime] NULL,
	[Importe] [decimal](10, 2) NOT NULL CONSTRAINT [DF_d_PresupuestoLineas_Importe]  DEFAULT ((0)),
	[IDCITA] [int] NULL,
 CONSTRAINT [PK_d_PresupuestoLineas] PRIMARY KEY CLUSTERED 
(
	[IDPresupuestoLinea] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[d_PresupuestoLineas]  WITH CHECK ADD  CONSTRAINT [FK_d_PresupuestoLineas_CONCEPTOSFRA] FOREIGN KEY([IDTratamiento])
REFERENCES [dbo].[CONCEPTOSFRA] ([CODIGO])
GO
ALTER TABLE [dbo].[d_PresupuestoLineas] CHECK CONSTRAINT [FK_d_PresupuestoLineas_CONCEPTOSFRA]
GO

ALTER TABLE [dbo].[d_PresupuestoLineas]  WITH CHECK ADD  CONSTRAINT [FK_d_PresupuestoLineas_d_Presupuesto] FOREIGN KEY([IDPresupuesto])
REFERENCES [dbo].[d_Presupuesto] ([IDPresupuesto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[d_PresupuestoLineas] CHECK CONSTRAINT [FK_d_PresupuestoLineas_d_Presupuesto]
GO

ALTER TABLE [dbo].[d_PresupuestoLineas]  WITH CHECK ADD  CONSTRAINT [FK_d_PresupuestoLineas_Citas] FOREIGN KEY([IDCITA])
REFERENCES [dbo].[CITAS] ([IDCITA])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[d_PresupuestoLineas] CHECK CONSTRAINT [FK_d_PresupuestoLineas_Citas]
GO

/*BEGIN Modificacion de la tabla Fichero para contener IDseccion, tag1 y tag2 */
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
IF NOT EXISTS (SELECT * FROM information_schema.columns where table_name ='FICHEROS'  and column_name='IDSECCION')
BEGIN
ALTER TABLE dbo.FICHEROS ADD
	IDSECCION int NULL,
	IDSUBSECCION int NULL
END
GO
COMMIT

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
IF NOT EXISTS (SELECT * FROM information_schema.columns where table_name ='FICHEROS'  and column_name='TAG1')
BEGIN
 EXECUTE sp_rename N'dbo.FICHEROS.IDSUBSECCION', N'TAG1', 'COLUMN' 
END
GO
IF NOT EXISTS (SELECT * FROM information_schema.columns where table_name ='FICHEROS'  and column_name='TAG2')
BEGIN
ALTER TABLE dbo.FICHEROS ADD
	TAG2 int NULL
END
GO
COMMIT

/*END Modificacion de la tabla Fichero para contener seccion y subseccion */


/*BEGIN modificar lineacita para añadir referencia a su presupuesto Dental*/
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
BEGIN TRANSACTION
GO
IF NOT EXISTS (SELECT * FROM information_schema.columns where table_name ='LineasCitas'  and column_name='RefLineaPresupuestoDental')
BEGIN
ALTER TABLE dbo.LineasCitas ADD
	RefLineaPresupuestoDental bigint NULL
END
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	FK_LineasCitas_d_PresupuestoLineas FOREIGN KEY
	(
	RefLineaPresupuestoDental
	) REFERENCES dbo.d_PresupuestoLineas
	(
	IDPresupuestoLinea
	) ON UPDATE  NO ACTION 
	 ON DELETE  SET NULL 
	
GO
COMMIT
/*END modificar lineacita para añadir referencia a su presupuesto Dental*/

Update VariablesGlobales Set Valor = '1.0.1.0' where Clave = 'DB_Version';