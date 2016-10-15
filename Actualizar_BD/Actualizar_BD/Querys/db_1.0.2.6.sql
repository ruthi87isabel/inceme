﻿/* BEGIN Agregar campo repetido a MODELOSDATOS*/
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
	Repetir bit NULL
GO
ALTER TABLE dbo.MODELOSDATOS ADD CONSTRAINT
	DF_MODELOSDATOS_Repetir DEFAULT 0 FOR Repetir
GO
UPDATE MODELOSDATOS set Repetir = 0 where Repetir is null
COMMIT

/* END Agregar campo repetido a MODELOSDATOS*/

Update VariablesGlobales Set Valor = '1.0.2.6' where Clave = 'DB_Version';