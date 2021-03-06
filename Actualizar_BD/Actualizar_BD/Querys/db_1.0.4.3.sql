  print 'Crear la tabla Recordatorio'

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



PRINT 'DB_Version: 1.0.4.3'
Update VariablesGlobales Set Valor = '1.0.4.3' where Clave = 'DB_Version';
GO
  