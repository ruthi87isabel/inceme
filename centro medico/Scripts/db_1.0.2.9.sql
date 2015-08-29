﻿/* BEGIN Annadir campo Eliminado a Historiales */
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
ALTER TABLE dbo.HISTORIALES ADD
	Eliminado bit NULL
GO
ALTER TABLE dbo.HISTORIALES ADD CONSTRAINT
	DF_HISTORIALES_Eliminado DEFAULT 0 FOR Eliminado
GO
UPDATE HISTORIALES SET Eliminado = 0 WHERE Eliminado Is Null
GO
COMMIT
/* END Annadir campo Eliminado a Historiales */

/* BEGIN Annadir campo Eliminado a RECETAS */
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
ALTER TABLE dbo.RECETAS ADD
	Eliminado bit NULL
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	DF_RECETAS_Eliminado DEFAULT 0 FOR Eliminado
GO
UPDATE RECETAS SET Eliminado = 0 WHERE Eliminado Is Null
GO
COMMIT
/* END Annadir campo Eliminado a RECETAS */

/* BEGIN Annadir campo Eliminado a MUTUAS */
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
ALTER TABLE dbo.MUTUAS ADD
	Eliminado bit NULL
GO
ALTER TABLE dbo.MUTUAS ADD CONSTRAINT
	DF_MUTUAS_Eliminado DEFAULT 0 FOR Eliminado
GO
UPDATE MUTUAS SET Eliminado = 0 WHERE Eliminado Is Null
GO
COMMIT
/* END Annadir campo Eliminado a MUTUAS */


/* BEGIN Annadir campo Eliminado a EMPRESAS */
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
ALTER TABLE dbo.EMPRESAS ADD
	Eliminado bit NULL
GO
ALTER TABLE dbo.EMPRESAS ADD CONSTRAINT
	DF_EMPRESAS_Eliminado DEFAULT 0 FOR Eliminado
GO
UPDATE EMPRESAS SET Eliminado = 0 WHERE Eliminado Is Null
GO
COMMIT
/* END Annadir campo Eliminado a EMPRESAS */



Update VariablesGlobales Set Valor = '1.0.2.9' where Clave = 'DB_Version';
