  print 'En la tabla PACIENTES, sustituir en el campo Eliminado los valores null por 0'

UPDATE dbo.PACIENTES
SET Eliminado=0
WHERE Eliminado IS NULL
go

/****** Object:  Table [dbo].[Descartar_Pacientes_Duplicados]    Script Date: 02/03/2017 9:10:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Descartar_Pacientes_Duplicados](
	[Id_Paciente_Origen] [int] NOT NULL,
	[Id_Paciente_Descartado] [int] NOT NULL,
	[Fecha_Descarte] [datetime] NULL,
 CONSTRAINT [PK_Descartar_Pacientes_Duplicados] PRIMARY KEY CLUSTERED 
(
	[Id_Paciente_Origen] ASC,
	[Id_Paciente_Descartado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Descartar_Pacientes_Duplicados]  WITH CHECK ADD  CONSTRAINT [FK_PacienteDescartado] FOREIGN KEY([Id_Paciente_Descartado])
REFERENCES [dbo].[PACIENTES] ([CPACIENTE])
GO

ALTER TABLE [dbo].[Descartar_Pacientes_Duplicados] CHECK CONSTRAINT [FK_PacienteDescartado]
GO

ALTER TABLE [dbo].[Descartar_Pacientes_Duplicados]  WITH CHECK ADD  CONSTRAINT [FK_PacienteOrigen] FOREIGN KEY([Id_Paciente_Origen])
REFERENCES [dbo].[PACIENTES] ([CPACIENTE])
GO

ALTER TABLE [dbo].[Descartar_Pacientes_Duplicados] CHECK CONSTRAINT [FK_PacienteOrigen]
GO

/****** Object:  Table [dbo].[Recordatorio]    Script Date: 15/03/2017 13:08:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Recordatorio](
	[IdRecordatorio] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
	[Asunto] [nvarchar](50) NOT NULL,
	[Anotación] [nvarchar](500) NULL,
 CONSTRAINT [PK_Recordatorio] PRIMARY KEY CLUSTERED 
(
	[IdRecordatorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



PRINT 'DB_Version: 1.0.4.2'
Update VariablesGlobales Set Valor = '1.0.4.2' where Clave = 'DB_Version';
GO
  