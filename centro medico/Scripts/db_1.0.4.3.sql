ALTER TABLE dbo.CITAS ADD NumeroCita tinyint NULL
go
UPDATE dbo.CITAS SET NumeroCita=null
 GO
Update VariablesGlobales Set Valor = '1.0.4.3' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.4.3';
GO 