﻿/* BEGIN Agregar campo OcultarEnReporte a MODELOSDATOS*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MODELOSDATOS ADD
	OcultarEnReporte bit NULL
GO
ALTER TABLE dbo.MODELOSDATOS ADD CONSTRAINT
	DF_MODELOSDATOS_OcultarEnReporte DEFAULT 0 FOR OcultarEnReporte
GO
UPDATE MODELOSDATOS set OcultarEnReporte = 0 where OcultarEnReporte is null
COMMIT

/* END Agregar campo OcultarEnReporte a MODELOSDATOS*/

Update VariablesGlobales Set Valor = '1.0.2.8' where Clave = 'DB_Version';