  print 'En la tabla PACIENTES, sustituir en el campo Eliminado los valores null por 0'

UPDATE dbo.PACIENTES
SET Eliminado=0
WHERE Eliminado IS NULL
go

PRINT 'DB_Version: 1.0.4.2'
Update VariablesGlobales Set Valor = '1.0.4.2' where Clave = 'DB_Version';
GO
  