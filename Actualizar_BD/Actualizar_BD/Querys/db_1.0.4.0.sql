
CREATE Procedure [dbo].[Top10_Tratamiento]

-- Obtener los id de los nomencladores dela tabla [S_ExpTemSeleccion]
 @Fecha7 DATETIME=NULL,
 @Fecha8 DATETIME=NULL
 
AS
BEGIN		
		;WITH q AS 
		(
			SELECT SUBSTRING(CAST(CAST(FECHA as DATE) AS varchar),0,8) AS FECHA,c.DESCRIPCION AS Tratamiento, COUNT(c.DESCRIPCION) AS CantTratamientos 
			,rn = ROW_NUMBER() 
			OVER (PARTITION BY (SUBSTRING(CAST(CAST(FECHA as DATE) AS varchar),0,8)) ORDER BY COUNT(c.DESCRIPCION) DESC)
			FROM  dbo.CITAS
			INNER JOIN dbo.LineasCitas ON dbo.CITAS.IDCITA = dbo.LineasCitas.IdCita
			INNER JOIN dbo.CONCEPTOSFRA c ON LineasCitas.RefConcepto=c.CODIGO
			WHERE (c.DESCRIPCION IS NOT NULL AND c.DESCRIPCION <> '')AND(
					((@Fecha7 Is NOT NULL AND @Fecha8 Is NOT NULL) AND (FECHA>=@Fecha7 AND FECHA<=@Fecha8))
					 OR 
					(@Fecha7 Is NULL AND @Fecha8 IS NULL))
			GROUP BY SUBSTRING(CAST(CAST(FECHA as DATE) AS varchar),0,8),c.DESCRIPCION
		)
		SELECT FECHA,Tratamiento,CantTratamientos
		FROM  q
		WHERE rn<=10 AND (Tratamiento IS NOT NULL AND Tratamiento <> '')
		ORDER BY FECHA DESC, CantTratamientos DESC
  
  END 
  go



  BEGIN TRANSACTION

-- Add rows to [dbo].[ROLESITEMS]
INSERT INTO [dbo].[ROLESITEMS] ([ID_ROLESITEM], [Nombre]) VALUES (105, N'DashB_Citas por estado')
INSERT INTO [dbo].[ROLESITEMS] ([ID_ROLESITEM], [Nombre]) VALUES (106, N'DashB_Relacion de Altas')
INSERT INTO [dbo].[ROLESITEMS] ([ID_ROLESITEM], [Nombre]) VALUES (107, N'DashB_Citas atendidas por medicos')
INSERT INTO [dbo].[ROLESITEMS] ([ID_ROLESITEM], [Nombre]) VALUES (108, N'DashB_Citas por Especialidad')
INSERT INTO [dbo].[ROLESITEMS] ([ID_ROLESITEM], [Nombre]) VALUES (109, N'DashB_Top 10 Tratamientos')
INSERT INTO [dbo].[ROLESITEMS] ([ID_ROLESITEM], [Nombre]) VALUES (110, N'DashB_Resumen Dental')
-- Operation applied to 6 rows out of 6

-- Add rows to [dbo].[ROLESPERMISOS]
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (1, 4, 105, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (1, 4, 106, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (1, 4, 107, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (1, 4, 108, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (1, 4, 109, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (1, 4, 110, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (2, 1, 105, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (2, 1, 106, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (2, 1, 107, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (2, 1, 108, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (2, 1, 109, N'')
INSERT INTO [dbo].[ROLESPERMISOS] ([ID_ROLES], [ID_PERMISO], [ID_ROLESITEM], [Notas]) VALUES (2, 1, 110, N'')

COMMIT TRANSACTION
GO

  


  Update VariablesGlobales Set Valor = '1.0.4.0' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.4.0';
GO 
  