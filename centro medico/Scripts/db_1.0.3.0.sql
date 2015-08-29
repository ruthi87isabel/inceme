
PRINT 'Modificando la tabla RECETAS para annadirle los campos de la receta Oficial'
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
	Prescripcion nvarchar(500) NULL,
	DuracionTratamiento nvarchar(50) NULL,
	PacienteInfo nvarchar(500) NULL,
	Posologia nvarchar(50) NULL,
	Unidades nvarchar(30) NULL,
	Pauta nvarchar(100) NULL,
	NoOrdenDispensacion nvarchar(50) NULL,
	FechaPrevistaDispensacion datetime NULL,
	InfoAlFarmaceutico nvarchar(200) NULL,
	DiagnosticoAlPaciente nvarchar(200) NULL,
	NoEnvases_o_Unidades integer NULL,
	Prescriptor nvarchar(500) NULL,
	InstruccionesAlPaciente nvarchar(500) NULL,
	EsRecetaOficial bit NULL
GO
COMMIT
PRINT 'OK'

PRINT 'Annadiendo campo Eliminado a Tabla MEDICO'
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
ALTER TABLE dbo.MEDICOS ADD
	Eliminado bit NULL
GO
ALTER TABLE dbo.MEDICOS ADD CONSTRAINT
	DF_MEDICOS_Eliminado DEFAULT 0 FOR Eliminado
GO
UPDATE dbo.MEDICOS SET Eliminado = 0 WHERE Eliminado is null
GO
Print 'OK'
GO
COMMIT


Update VariablesGlobales Set Valor = '1.0.3.0' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.3.0'