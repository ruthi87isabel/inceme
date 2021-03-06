/*BEGIN Eliminar la relacion de las lineas de  Ticket con la Tabla NTipos_IVA*/
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
ALTER TABLE dbo.N_Ticket_Lineas
	DROP CONSTRAINT FK_N_Ticket_Lineas_N_TipoIVA
ALTER TABLE dbo.N_Ticket_Lineas
	DROP COLUMN ID_TipoIVA
GO
COMMIT
/*END Eliminar la relacion de las lineas de  Ticket con la Tabla NTipos_IVA*/

/* BEGIN Annadir campos IVAPorciento e IVAImporte en N_TicketLineas */
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
ALTER TABLE dbo.N_Ticket_Lineas ADD
	IVAPorciento float(53) NULL,
	IVAImporte float(53) NULL
GO
ALTER TABLE dbo.N_Ticket_Lineas ADD CONSTRAINT
	DF_N_Ticket_Lineas_IVAPorciento DEFAULT 0 FOR IVAPorciento
GO
ALTER TABLE dbo.N_Ticket_Lineas ADD CONSTRAINT
	DF_N_Ticket_Lineas_IVAImporte DEFAULT 0 FOR IVAImporte
GO

COMMIT
/* END Annadir campos IVAPorciento e IVAImporte en N_TicketLineas */

/*BEGIN INICIALIZAR campos IVAPorciento e IVAImporte en N_TicketLineas en lineas anteriores*/
UPDATE N_Ticket_Lineas SET IVAPorciento = 0,IVAImporte = 0 WHERE N_Ticket_Lineas.IVAPorciento is null
/*END INICIALIZAR campos IVAPorciento e IVAImporte en N_TicketLineas en lineas anteriores*/


/* Begin Annadir campos NombrePaciente, Eliminado y FormaPago a tabla NTicket*/
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
ALTER TABLE dbo.N_Ticket ADD
	NombrePaciente nvarchar(50) NULL,
	FormaPago nvarchar(50) NULL
GO
ALTER TABLE dbo.N_Ticket ADD
	Eliminado bit NULL
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	DF_N_Ticket_Eliminado DEFAULT 0 FOR Eliminado
GO
COMMIT
/* END Annadir campos NombrePaciente y FormaPago a tabla NTicket*/
Update VariablesGlobales Set Valor = '1.0.2.2' where Clave = 'DB_Version';