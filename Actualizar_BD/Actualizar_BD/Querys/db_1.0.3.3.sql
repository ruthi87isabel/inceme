print 'Crear tabla RECETASXML';
/****** Object:  Table [dbo].[RecetasXML]    Script Date: 01/13/2014 19:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecetasXML](
	[idmedico] [int] NOT NULL,
	[nombre] [nchar](100) NULL,
	[apellido1] [nchar](100) NULL,
	[apellido2] [nchar](100) NULL,
	[numeroLote] [nchar](50) NULL,
	[idioma] [int] NULL,
	[documentoIdentificacionTipo] [nchar](50) NULL,
	[documentoIdentificacion] [nchar](100) NULL,
	[numeroColegiado] [nchar](50) NULL,
	[idColegio] [int] NULL,
	[centroTrabajo] [nchar](200) NULL,
	[cif] [nchar](50) NULL,
	[empleoPrincipal] [nchar](100) NULL,
	[sexo] [nchar](10) NULL,
	[nombreEspecialidad] [nchar](100) NULL,
	[idEspecialidad] [int] NULL,
	[codigoPostal] [nchar](10) NULL,
	[direccionPostal] [nchar](100) NULL,
	[municipio] [nchar](50) NULL,
	[pais] [nchar](10) NULL,
	[provincia] [nchar](50) NULL,
	[tipoVia] [nchar](25) NULL,
	[numero] [nchar](25) NOT NULL,
	[CVE] [nchar](100) NOT NULL,
	[idReceta] [int] NULL,
 CONSTRAINT [PK_RecetasXML] PRIMARY KEY CLUSTERED 
(
	[CVE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Es el codigo del médico en la tabla medicos de inceme' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RecetasXML', @level2type=N'COLUMN',@level2name=N'idmedico'
GO
/****** Object:  ForeignKey [FK_RecetasXML_MEDICOS]    Script Date: 01/13/2014 19:14:04 ******/
ALTER TABLE [dbo].[RecetasXML]  WITH CHECK ADD  CONSTRAINT [FK_RecetasXML_MEDICOS] FOREIGN KEY([idmedico])
REFERENCES [dbo].[MEDICOS] ([CMEDICO])
GO
ALTER TABLE [dbo].[RecetasXML] CHECK CONSTRAINT [FK_RecetasXML_MEDICOS]
GO
/****** Object:  ForeignKey [FK_RecetasXML_RECETAS]    Script Date: 01/13/2014 19:14:04 ******/
ALTER TABLE [dbo].[RecetasXML]  WITH CHECK ADD  CONSTRAINT [FK_RecetasXML_RECETAS] FOREIGN KEY([idReceta])
REFERENCES [dbo].[RECETAS] ([IDRECETA])
GO
ALTER TABLE [dbo].[RecetasXML] CHECK CONSTRAINT [FK_RecetasXML_RECETAS]
GO


PRINT 'Campos en tabla médicos para establecer imagenes necesarias para las receta xml';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.MEDICOS ADD
	FondoReceta nvarchar(MAX) NULL,
	LogoColegioReceta nvarchar(MAX) NULL,
	Logo2Receta nvarchar(MAX) NULL
GO
COMMIT

Update VariablesGlobales Set Valor = '1.0.3.3' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.3.3';
