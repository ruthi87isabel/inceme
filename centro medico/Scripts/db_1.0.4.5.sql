  print 'add TipoDenticion field to d_PresupuestoLineas'

ALTER TABLE dbo.d_PresupuestoLineas ADD TipoDenticion [int] NULL
go

print 'actualizar el campo TipoDenticion de la tabla d_PresupuestoLineas con sus valores correspondientes'

UPDATE dbo.d_PresupuestoLineas 
SET TipoDenticion=1
WHERE IDPresupuestoLinea IN (SELECT distinct IDPresupuestoLinea FROM dbo.d_PresupuestoLineas dl 
INNER JOIN dbo.d_Presupuesto p ON dl.IDPresupuesto = p.IDPresupuesto
INNER JOIN dbo.d_Odontogramas o ON p.IDOdontograma = o.IDOdontograma
WHERE o.TipoDenticion=1)

UPDATE dbo.d_PresupuestoLineas 
SET TipoDenticion=0
WHERE IDPresupuestoLinea IN (SELECT distinct IDPresupuestoLinea FROM dbo.d_PresupuestoLineas dl 
INNER JOIN dbo.d_Presupuesto p ON dl.IDPresupuesto = p.IDPresupuesto
INNER JOIN dbo.d_Odontogramas o ON p.IDOdontograma = o.IDOdontograma
WHERE o.TipoDenticion=0)

INSERT INTO dbo.VariablesGlobales
        ( Clave, Valor )
VALUES  ( 'VincularCitaMutua ', -- Clave - varchar(500)
          'False'  -- Valor - varchar(max)
          )
		  
PRINT 'DB_Version: 1.0.4.5'
Update VariablesGlobales Set Valor = '1.0.4.5' where Clave = 'DB_Version';
GO
  