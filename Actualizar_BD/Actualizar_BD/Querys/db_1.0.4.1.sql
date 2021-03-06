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

print 'actualizar el campo IDFormaPago de la tabla PagosPaciente con sus valores correspondientes'

DECLARE @TB AS TABLE(idEnt int,idP int, idFP VARCHAR(10),imp FLOAT, nota NVARCHAR(200))
DECLARE @ide AS int
DECLARE @idp AS int
DECLARE @idf AS VARCHAR(10)
DECLARE @imp AS FLOAT
DECLARE @not AS NVARCHAR(200) 

INSERT INTO @TB
        ( idEnt, idP, idFP,imp, nota )
SELECT IDEntrega,IDPaciente,IDFormaPago,Importe,Notas FROM dbo.PagosPaciente
WHERE IDFormaPago is NULL AND Importe<0
ORDER BY IDEntrega asc,IDPaciente asc

SELECT TOP (1) @ide=idEnt,@idp=idP,@imp=imp,@not=SUBSTRING(nota,51,(LEN(nota)-50)) FROM @TB

WHILE @ide IS NOT NULL 

BEGIN
	
	SELECT @idf=IDFormaPago FROM dbo.PagosPaciente 
	WHERE IDEntrega<@ide AND Importe=(@imp * -1) AND IDFormaPago IS NOT NULL AND IDPaciente=@idp AND 
	Notas LIKE '%'+@not+'%'

	UPDATE dbo.PagosPaciente
	SET IDFormaPago=@idf
	WHERE IDEntrega=@ide
		
	DELETE @TB WHERE idEnt=@ide 
	SET @ide = null
	SELECT TOP (1) @ide=idEnt,@idp=idP,@imp=imp,@not=SUBSTRING(nota,51,(LEN(nota)-50)) FROM @TB
	
END 
go

PRINT 'DB_Version: 1.0.4.1'
Update VariablesGlobales Set Valor = '1.0.4.1' where Clave = 'DB_Version';
GO
  