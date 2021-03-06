/*BEGIN La longitud del campo TarjetasSanitarias en Paciente*/
ALTER TABLE PACIENTES ALTER COLUMN TARJETASANITARIA varchar(50)
/*END La longitud del campo TarjetasSanitarias en Paciente*/

/*BEGIN Allow Null a los campos Pagado y FechaPagado de N_Factura */
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
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT FK_N_Factura_N_Factura_Tipos
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT FK_N_Factura_FormasPago
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT FK_N_Factura_N_Pacientes
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT DF_N_Factura_Fecha
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT DF_N_Factura_REPorciento
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT DF_N_Factura_ReCantidad
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT DF_N_Factura_PortePagado
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT DF_N_Factura_PorteDebido
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT DF_N_Factura_Pagado
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT DF_N_Factura_FechaPagado
GO
CREATE TABLE dbo.Tmp_N_Factura
	(
	ID_Factura bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ID_TipoFactura int NULL,
	Referencia nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Fecha datetime NULL,
	ID_Estado int NULL,
	ID_Cliente int NULL,
	ID_FormaPago varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	IRPFPorciento float(53) NULL,
	IRPFCantidad float(53) NULL,
	Total float(53) NULL,
	Observaciones nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PlazoEntrega datetime NULL,
	Validez nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PortePagado bit NULL,
	PorteDebido bit NULL,
	PorteTexto nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Privado nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DocumentacionAsociada nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Comentarios nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Imagen image NULL,
	Pagado bit NULL,
	FechaPagado datetime NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE dbo.Tmp_N_Factura ADD CONSTRAINT
	DF_N_Factura_Fecha DEFAULT (getdate()) FOR Fecha
GO
ALTER TABLE dbo.Tmp_N_Factura ADD CONSTRAINT
	DF_N_Factura_REPorciento DEFAULT ((0)) FOR IRPFPorciento
GO
ALTER TABLE dbo.Tmp_N_Factura ADD CONSTRAINT
	DF_N_Factura_ReCantidad DEFAULT ((0)) FOR IRPFCantidad
GO
ALTER TABLE dbo.Tmp_N_Factura ADD CONSTRAINT
	DF_N_Factura_PortePagado DEFAULT ((1)) FOR PortePagado
GO
ALTER TABLE dbo.Tmp_N_Factura ADD CONSTRAINT
	DF_N_Factura_PorteDebido DEFAULT ((0)) FOR PorteDebido
GO
ALTER TABLE dbo.Tmp_N_Factura ADD CONSTRAINT
	DF_N_Factura_Pagado DEFAULT ((0)) FOR Pagado
GO
ALTER TABLE dbo.Tmp_N_Factura ADD CONSTRAINT
	DF_N_Factura_FechaPagado DEFAULT (getdate()) FOR FechaPagado
GO
SET IDENTITY_INSERT dbo.Tmp_N_Factura ON
GO
IF EXISTS(SELECT * FROM dbo.N_Factura)
	 EXEC('INSERT INTO dbo.Tmp_N_Factura (ID_Factura, Codigo, ID_TipoFactura, Referencia, Fecha, ID_Estado, ID_Cliente, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, Pagado, FechaPagado)
		SELECT ID_Factura, Codigo, ID_TipoFactura, Referencia, Fecha, ID_Estado, ID_Cliente, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, Pagado, FechaPagado FROM dbo.N_Factura WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Factura OFF
GO
ALTER TABLE dbo.N_Factura_Lineas
	DROP CONSTRAINT FK_N_Factura_Lineas_N_Factura
GO
ALTER TABLE dbo.N_Factura_Totales
	DROP CONSTRAINT FK_N_Factura_Totales_N_Factura
GO
DROP TABLE dbo.N_Factura
GO
EXECUTE sp_rename N'dbo.Tmp_N_Factura', N'N_Factura', 'OBJECT' 
GO
ALTER TABLE dbo.N_Factura ADD CONSTRAINT
	PK_N_Factura PRIMARY KEY CLUSTERED 
	(
	ID_Factura
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Factura ADD CONSTRAINT
	FK_N_Factura_N_Pacientes FOREIGN KEY
	(
	ID_Cliente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Factura ADD CONSTRAINT
	FK_N_Factura_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Factura ADD CONSTRAINT
	FK_N_Factura_N_Factura_Tipos FOREIGN KEY
	(
	ID_TipoFactura
	) REFERENCES dbo.N_Factura_Tipos
	(
	ID_TipoFactura
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura_Totales ADD CONSTRAINT
	FK_N_Factura_Totales_N_Factura FOREIGN KEY
	(
	ID_Factura
	) REFERENCES dbo.N_Factura
	(
	ID_Factura
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura_Lineas ADD CONSTRAINT
	FK_N_Factura_Lineas_N_Factura FOREIGN KEY
	(
	ID_Factura
	) REFERENCES dbo.N_Factura
	(
	ID_Factura
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	

GO
COMMIT

/*END Allow Null a los campos Pagado y FechaPagado de N_Factura */



/* BEGIN Anndir campo Eliminado a CITAS */
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
ALTER TABLE dbo.CITAS ADD
	Eliminado bit NULL
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	DF_CITAS_Eliminado DEFAULT 0 FOR Eliminado
GO
COMMIT
GO
UPDATE CITAS SET Eliminado = 0 WHERE Eliminado IS NULL
GO
/* END Anndir campo Eliminado a CITAS */


/* BEGIN Annadir campo Eliminado a FACTURAS*/
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
ALTER TABLE dbo.FACTURAS ADD
	Eliminado bit NULL
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	DF_FACTURAS_Eliminado DEFAULT 0 FOR Eliminado
GO
UPDATE FACTURAS SET Eliminado = 0 where Eliminado IS NULL
GO
COMMIT
/* END Annadir campo Eliminado a FACTURAS*/


/* Poner Eliminado en false para todos los pacientes que lo tienen en null */
GO
UPDATE PACIENTES SET Eliminado = 0 where Eliminado IS NULL
GO

/* BEGIN Annadir campo Eliminado a EntregasCuenta para ocultar los pagos cuando se elimina la cita o la factura  */
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
ALTER TABLE dbo.EntregasCuenta ADD
	Eliminado bit NULL
GO
ALTER TABLE dbo.EntregasCuenta ADD CONSTRAINT
	DF_EntregasCuenta_Eliminado DEFAULT 0 FOR Eliminado
GO
COMMIT
GO
UPDATE EntregasCuenta SET Eliminado = 0 WHERE Eliminado IS NULL;
GO
/* END Annadir campo Eliminado a EntregasCuenta para ocultar los pagos cuando se elimina la cita o la factura  */





/* BEGIN ANNADIR CAMPO Login a la auditoria */
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
ALTER TABLE dbo.Auditoria ADD
	loginUsuario nvarchar(50) NULL
GO
COMMIT
/* END ANNADIR CAMPO Login a la auditoria */

Update VariablesGlobales Set Valor = '1.0.2.0' where Clave = 'DB_Version';