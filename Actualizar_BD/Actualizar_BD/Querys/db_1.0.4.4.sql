PRINT 'Nueva Variable Global'
 INSERT INTO dbo.VariablesGlobales
        ( Clave, Valor )
VALUES  ( 'SincCalendCitaFtp', -- Clave - varchar(500)
          'True'  -- Valor - varchar(max)
          )
INSERT INTO dbo.VariablesGlobales
        ( Clave, Valor )
VALUES  ( 'IdentificadorClinica', -- Clave - varchar(500)
          ''  -- Valor - varchar(max)
          )
		  
PRINT 'DB_Version: 1.0.4.4'
Update VariablesGlobales Set Valor = '1.0.4.4' where Clave = 'DB_Version';
GO
  