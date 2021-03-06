USE [SIESTA]
GO
/****** Object:  StoredProcedure [dbo].[Top10_Tratamiento]    Script Date: 12/08/2015 09:51:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
  
  