INSERT INTO dbo.VariablesGlobales
        ( Clave, Valor )
VALUES  ( 'NumeroColumnaMedico', -- Clave - varchar(500)
          '5'  -- Valor - varchar(max)
          )
          
		  
PRINT 'DB_Version: 1.0.4.6'
Update VariablesGlobales Set Valor = '1.0.4.6' where Clave = 'DB_Version';
GO
  