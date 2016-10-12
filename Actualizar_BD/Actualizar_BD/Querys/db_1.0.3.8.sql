print 'add color field to conceptosanalitica'
go
ALTER TABLE dbo.CONCEPTOSANALITICA ADD	COLOR varchar(24) NULL
go
ALTER TABLE dbo.CONCEPTOSANALITICA ADD CONSTRAINT
	DF_CONCEPTOSANALITICA_COLOR DEFAULT '' FOR COLOR
GO
print 'update value field color with empty string'
go
UPDATE CONCEPTOSANALITICA SET COLOR=''
go
Update VariablesGlobales Set Valor = '1.0.3.8' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.3.8';
GO


