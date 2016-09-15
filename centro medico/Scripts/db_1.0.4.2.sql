print 'add NumeroCita  field to CITAS'
go
ALTER TABLE dbo.CITAS ADD NumeroCita [tinyint] NULL
go
Update VariablesGlobales Set Valor = '1.0.4.2' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.4.2';
GO


