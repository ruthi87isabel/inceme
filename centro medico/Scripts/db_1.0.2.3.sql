/*BEGIN Annadir IDMutua a Presuepuesto Lineas de Dental asi como referencia a mutuas*/
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
ALTER TABLE dbo.d_Presupuesto ADD
	IDMutua int NULL
GO
ALTER TABLE dbo.d_Presupuesto ADD CONSTRAINT
	FK_d_Presupuesto_MUTUAS FOREIGN KEY
	(
	IDMutua
	) REFERENCES dbo.MUTUAS
	(
	CMUTUA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 

GO
COMMIT
/*END Annadir IDMutua a Presuepuesto Lineas de Dental asi como referencia a mutuas*/


Update VariablesGlobales Set Valor = '1.0.2.3' where Clave = 'DB_Version';