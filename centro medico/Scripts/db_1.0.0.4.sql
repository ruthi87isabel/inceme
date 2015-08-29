/*
Creacion de las Tablas 

- N_Procesos
- N_Partes
- N_Partes_Asistencia
*/

/****** Object:  Table [dbo].[N_Partes]    Script Date: 03/08/2010 15:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[N_Partes](
	[ID_Parte] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_Proceso] [bigint] NULL,
	[ID_Paciente] [int] NULL,
	[E_Tipo] [int] NULL,
	[FechaBaja] [datetime] NULL,
	[FechaAlta] [datetime] NULL,
	[ID_ParteOrigen] [bigint] NULL,
	[Alta_Descripcion_Resultado_Reconocimiento] [nvarchar](max) NULL,
	[Alta_E_Causa_de_Alta] [int] NULL,
	[FechaAT] [datetime] NULL,
	[E_Regimen] [int] NULL,
	[E_Situacion] [int] NULL,
	[Num_Tarjeta_sanitaria] [nvarchar](50) NULL,
	[Num_Afiliacion_Seg_Social] [nvarchar](50) NULL,
	[NombreCompletoPaciente] [nvarchar](50) NULL,
	[DomicilioPaciente] [nvarchar](100) NULL,
	[LocalidadPaciente] [nvarchar](100) NULL,
	[ProvinciaPaciente] [nvarchar](50) NULL,
	[Codigo_PostalPaciente] [nvarchar](50) NULL,
	[TelefonoPaciente] [nvarchar](50) NULL,
	[Puesto_de_trabajoPaciente] [nchar](10) NULL,
	[ID_Empresa] [int] NULL,
	[NombreEmpresa] [nvarchar](50) NULL,
	[DomicilioEmpresa] [nvarchar](50) NULL,
	[LocalidadEmpresa] [nvarchar](50) NULL,
	[ProvinciaEmpresa] [nvarchar](50) NULL,
	[Codigo_Postal_Empresa] [nvarchar](50) NULL,
	[Actividad_empresa] [nvarchar](max) NULL,
	[Código_Nacional_Actividad_Económica_CNAE] [nvarchar](50) NULL,
	[Entidad_Pago_IT_CP] [int] NULL,
	[DescripcionLimitacion] [nvarchar](max) NULL,
	[ID_Diagnostico] [int] NULL,
	[Descripcion_Diagnostico] [nvarchar](max) NULL,
	[Duracion_probable_baja_dias] [int] NULL,
	[Duracion_probable_baja_meses] [int] NULL,
	[Duracion_estandar_fecha_inicio] [datetime] NULL,
	[Duracion_estandar_fecha_final] [datetime] NULL,
	[E_Caracter] [int] NULL,
	[Recaida] [bit] NULL,
	[E_Causa_de_baja] [int] NULL,
	[ID_Medico] [int] NULL,
	[NombreMedico] [nvarchar](50) NULL,
	[No_de_ColegiadoMedico] [nvarchar](50) NULL,
 CONSTRAINT [PK_N_ParteBaja] PRIMARY KEY CLUSTERED 
(
	[ID_Parte] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[N_Partes_Asistencia]    Script Date: 03/08/2010 15:41:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[N_Partes_Asistencia](
	[ID_ParteAsistencia] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_Proceso] [bigint] NULL,
	[FechaAsistencia] [datetime] NULL,
	[E_Pronostico] [int] NULL,
	[CausaBaja] [bit] NULL,
	[E_Regimen] [int] NULL,
	[E_Situacion] [int] NULL,
	[ID_Paciente] [int] NULL,
	[Num_Tarjeta_sanitaria] [nvarchar](50) NULL,
	[Num_Afiliacion_Seg_Social] [nvarchar](50) NULL,
	[DNI] [nvarchar](50) NULL,
	[NombreCompletoPaciente] [nvarchar](50) NULL,
	[DomicilioPaciente] [nvarchar](100) NULL,
	[LocalidadPaciente] [nvarchar](100) NULL,
	[ProvinciaPaciente] [nvarchar](50) NULL,
	[Codigo_PostalPaciente] [nvarchar](50) NULL,
	[TelefonoPaciente] [nvarchar](50) NULL,
	[Puesto_de_trabajoPaciente] [nvarchar](50) NULL,
	[ID_Empresa] [int] NULL,
	[NombreEmpresa] [nvarchar](50) NULL,
	[DomicilioEmpresa] [nvarchar](50) NULL,
	[LocalidadEmpresa] [nvarchar](50) NULL,
	[ProvinciaEmpresa] [nvarchar](50) NULL,
	[Codigo_Postal_Empresa] [nvarchar](50) NULL,
	[Actividad_empresa] [nvarchar](50) NULL,
	[Código_Nacional_Actividad_Económica_CNAE] [nvarchar](50) NULL,
	[Entidad_Pago_IT_CP] [int] NULL,
	[Fecha_accidente] [datetime] NULL,
	[Asistido_Previamente] [bit] NULL,
	[Fecha_Asistencia_previa] [datetime] NULL,
	[Era_el_lugar_de_trabajo_habitual] [bit] NULL,
	[Lugar_de_accidente] [nvarchar](200) NULL,
	[Descripcion_del_accidente] [nvarchar](max) NULL,
	[Descripcion_Diagnostico] [nvarchar](50) NULL,
	[ID_Diagnostico] [int] NULL,
	[Duracion_estandar_fecha_ini] [datetime] NULL,
	[Duracion_estandar_fecha_fin] [datetime] NULL,
	[Observaciones] [nvarchar](max) NULL,
	[ID_Medico] [int] NULL,
	[NombreCompletoMedico] [nvarchar](50) NULL,
	[No_de_Colegiado] [nvarchar](50) NULL,
	[E_Tratamiento] [int] NULL,
 CONSTRAINT [PK_N_Partes_Asistencia] PRIMARY KEY CLUSTERED 
(
	[ID_ParteAsistencia] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[N_Procesos]    Script Date: 03/08/2010 15:41:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[N_Procesos](
	[ID_Proceso] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_Paciente] [int] NOT NULL,
	[FechaInicio] [datetime] NOT NULL CONSTRAINT [DF_N_Procesos_FechaInicio]  DEFAULT (getdate()),
	[FechaFinal] [datetime] NULL,
	[Finalizado] [bit] NOT NULL CONSTRAINT [DF_N_Procesos_Finalizado]  DEFAULT ((0)),
	[ID_Empresa] [int] NULL,
	[ID_Mutua] [int] NULL,
	[ID_UsuarioCreador] [int] NULL,
 CONSTRAINT [PK_N_Procesos] PRIMARY KEY CLUSTERED 
(
	[ID_Proceso] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_N_Procesos_EMPRESAS]    Script Date: 03/08/2010 15:41:17 ******/
ALTER TABLE [dbo].[N_Procesos]  WITH CHECK ADD  CONSTRAINT [FK_N_Procesos_EMPRESAS] FOREIGN KEY([ID_Empresa])
REFERENCES [dbo].[EMPRESAS] ([CEMPRESA])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Procesos] CHECK CONSTRAINT [FK_N_Procesos_EMPRESAS]
GO
/****** Object:  ForeignKey [FK_N_Procesos_MUTUAS]    Script Date: 03/08/2010 15:41:17 ******/
ALTER TABLE [dbo].[N_Procesos]  WITH CHECK ADD  CONSTRAINT [FK_N_Procesos_MUTUAS] FOREIGN KEY([ID_Mutua])
REFERENCES [dbo].[MUTUAS] ([CMUTUA])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Procesos] CHECK CONSTRAINT [FK_N_Procesos_MUTUAS]
GO
/****** Object:  ForeignKey [FK_N_Procesos_PACIENTES]    Script Date: 03/08/2010 15:41:18 ******/
ALTER TABLE [dbo].[N_Procesos]  WITH CHECK ADD  CONSTRAINT [FK_N_Procesos_PACIENTES] FOREIGN KEY([ID_Paciente])
REFERENCES [dbo].[PACIENTES] ([CPACIENTE])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Procesos] CHECK CONSTRAINT [FK_N_Procesos_PACIENTES]
GO
/****** Object:  ForeignKey [FK_N_Partes_Baja_N_Procesos]    Script Date: 03/08/2010 15:41:30 ******/
ALTER TABLE [dbo].[N_Partes]  WITH CHECK ADD  CONSTRAINT [FK_N_Partes_Baja_N_Procesos] FOREIGN KEY([ID_Proceso])
REFERENCES [dbo].[N_Procesos] ([ID_Proceso])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Partes] CHECK CONSTRAINT [FK_N_Partes_Baja_N_Procesos]
GO
/****** Object:  ForeignKey [FK_N_Partes_DIAGNOSTICOS]    Script Date: 03/08/2010 15:41:30 ******/
ALTER TABLE [dbo].[N_Partes]  WITH CHECK ADD  CONSTRAINT [FK_N_Partes_DIAGNOSTICOS] FOREIGN KEY([ID_Diagnostico])
REFERENCES [dbo].[DIAGNOSTICOS] ([IDDIAGNOSTICO])
GO
ALTER TABLE [dbo].[N_Partes] CHECK CONSTRAINT [FK_N_Partes_DIAGNOSTICOS]
GO
/****** Object:  ForeignKey [FK_N_Partes_EMPRESAS]    Script Date: 03/08/2010 15:41:31 ******/
ALTER TABLE [dbo].[N_Partes]  WITH CHECK ADD  CONSTRAINT [FK_N_Partes_EMPRESAS] FOREIGN KEY([ID_Empresa])
REFERENCES [dbo].[EMPRESAS] ([CEMPRESA])
GO
ALTER TABLE [dbo].[N_Partes] CHECK CONSTRAINT [FK_N_Partes_EMPRESAS]
GO
/****** Object:  ForeignKey [FK_N_Partes_MEDICOS]    Script Date: 03/08/2010 15:41:31 ******/
ALTER TABLE [dbo].[N_Partes]  WITH CHECK ADD  CONSTRAINT [FK_N_Partes_MEDICOS] FOREIGN KEY([ID_Medico])
REFERENCES [dbo].[MEDICOS] ([CMEDICO])
GO
ALTER TABLE [dbo].[N_Partes] CHECK CONSTRAINT [FK_N_Partes_MEDICOS]
GO
/****** Object:  ForeignKey [FK_N_Partes_N_Partes]    Script Date: 03/08/2010 15:41:31 ******/
ALTER TABLE [dbo].[N_Partes]  WITH CHECK ADD  CONSTRAINT [FK_N_Partes_N_Partes] FOREIGN KEY([ID_ParteOrigen])
REFERENCES [dbo].[N_Partes] ([ID_Parte])
GO
ALTER TABLE [dbo].[N_Partes] CHECK CONSTRAINT [FK_N_Partes_N_Partes]
GO
/****** Object:  ForeignKey [FK_N_Partes_Asistencia_DIAGNOSTICOS]    Script Date: 03/08/2010 15:41:43 ******/
ALTER TABLE [dbo].[N_Partes_Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_N_Partes_Asistencia_DIAGNOSTICOS] FOREIGN KEY([ID_Diagnostico])
REFERENCES [dbo].[DIAGNOSTICOS] ([IDDIAGNOSTICO])
GO
ALTER TABLE [dbo].[N_Partes_Asistencia] CHECK CONSTRAINT [FK_N_Partes_Asistencia_DIAGNOSTICOS]
GO
/****** Object:  ForeignKey [FK_N_Partes_Asistencia_EMPRESAS]    Script Date: 03/08/2010 15:41:44 ******/
ALTER TABLE [dbo].[N_Partes_Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_N_Partes_Asistencia_EMPRESAS] FOREIGN KEY([ID_Empresa])
REFERENCES [dbo].[EMPRESAS] ([CEMPRESA])
GO
ALTER TABLE [dbo].[N_Partes_Asistencia] CHECK CONSTRAINT [FK_N_Partes_Asistencia_EMPRESAS]
GO
/****** Object:  ForeignKey [FK_N_Partes_Asistencia_MEDICOS]    Script Date: 03/08/2010 15:41:44 ******/
ALTER TABLE [dbo].[N_Partes_Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_N_Partes_Asistencia_MEDICOS] FOREIGN KEY([ID_Medico])
REFERENCES [dbo].[MEDICOS] ([CMEDICO])
GO
ALTER TABLE [dbo].[N_Partes_Asistencia] CHECK CONSTRAINT [FK_N_Partes_Asistencia_MEDICOS]
GO
/****** Object:  ForeignKey [FK_N_Partes_Asistencia_N_Procesos]    Script Date: 03/08/2010 15:41:44 ******/
ALTER TABLE [dbo].[N_Partes_Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_N_Partes_Asistencia_N_Procesos] FOREIGN KEY([ID_Proceso])
REFERENCES [dbo].[N_Procesos] ([ID_Proceso])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Partes_Asistencia] CHECK CONSTRAINT [FK_N_Partes_Asistencia_N_Procesos]
GO
/****** Object:  ForeignKey [FK_N_Partes_Asistencia_PACIENTES]    Script Date: 03/08/2010 15:41:44 ******/
ALTER TABLE [dbo].[N_Partes_Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_N_Partes_Asistencia_PACIENTES] FOREIGN KEY([ID_Paciente])
REFERENCES [dbo].[PACIENTES] ([CPACIENTE])
GO
ALTER TABLE [dbo].[N_Partes_Asistencia] CHECK CONSTRAINT [FK_N_Partes_Asistencia_PACIENTES]
GO

Update VariablesGlobales Set Valor = '1.0.0.4' where Clave = 'DB_Version'