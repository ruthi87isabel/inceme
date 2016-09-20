/****** Object:  StoredProcedure [dbo].[ImportaDatosExpSeleccion]    Script Date: 08/28/2015 10:32:34 ******/
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
			WHERE (
					((@Fecha7 Is NOT NULL AND @Fecha8 Is NOT NULL) AND (FECHA>=@Fecha7 AND FECHA<=@Fecha8))
					 OR 
					(@Fecha7 Is NULL AND @Fecha8 IS NULL))
			GROUP BY SUBSTRING(CAST(CAST(FECHA as DATE) AS varchar),0,8),c.DESCRIPCION
		)
		SELECT FECHA,Tratamiento,CantTratamientos
		FROM  q
		WHERE rn<=10
		ORDER BY FECHA DESC, CantTratamientos DESC
  
  END 
go

  print 'add NumeroCita  field to CITAS'

ALTER TABLE dbo.CITAS ADD NumeroCita [tinyint] NULL
go

print 'actualizar el campo NumeroCita de la tabla CITAS con sus valores correspondientes'

DECLARE @TB AS TABLE(idcitas int, idpac int, idmed int)
DECLARE @idc AS int
DECLARE @idp AS int
DECLARE @idm AS INT
DECLARE @cant AS INT 

INSERT INTO @TB
        ( idcitas,idpac,idmed )
SELECT IDCITA,REFPACIENTE,REFMEDICO FROM dbo.CITAS
WHERE REFPACIENTE IS NOT NULL AND FALTA='N' AND Eliminado=0 
ORDER BY REFPACIENTE asc,REFMEDICO asc

SELECT TOP (1) @idc=idcitas,@idp=idpac,@idm=idmed FROM @TB

WHILE @idc IS NOT NULL 

BEGIN
	DECLARE @DLT AS TABLE(idcitas INT)
	SELECT @cant=COUNT(*) FROM citas WHERE REFPACIENTE=@idp AND REFMEDICO=@idm AND FALTA='N' AND Eliminado=0 AND IDCITA <= @idc
	IF @cant=1
		UPDATE dbo.CITAS SET NumeroCita=1 WHERE IDCITA=@idc
	ELSE IF @cant=2
		UPDATE dbo.CITAS SET NumeroCita=2 WHERE IDCITA=@idc
	ELSE IF @cant=3
		UPDATE dbo.CITAS SET NumeroCita=3 WHERE IDCITA=@idc
	ELSE IF @cant>3
	BEGIN
		INSERT INTO @DLT
				( idcitas )
		SELECT TOP(3) IDCITA FROM dbo.CITAS WHERE REFPACIENTE=@idp AND REFMEDICO= @idm AND FALTA='N' AND Eliminado=0 AND IDCITA <= @idc ORDER BY IDCITA ASC
			
		DELETE @TB WHERE idpac=@idp AND idmed=@idm AND idcitas NOT IN (SELECT idcitas FROM @DLT)
	END 
		
	DELETE @TB WHERE idcitas=@idc 
	SET @idc = null
	SELECT TOP (1) @idc=idcitas,@idp=idpac,@idm=idmed FROM @TB
	
END 
go

PRINT 'DB_Version: 1.0.4.1'
Update VariablesGlobales Set Valor = '1.0.4.1' where Clave = 'DB_Version';
GO
  