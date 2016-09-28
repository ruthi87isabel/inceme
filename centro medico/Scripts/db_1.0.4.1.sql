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
  