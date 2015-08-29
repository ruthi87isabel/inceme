PRINT 'Cambiar longitud de Descripcion de EntregasCuenta a  MAX';
ALTER TABLE EntregasCuenta ALTER COLUMN Descripcion varchar(MAX);

PRINT 'Cambiar collation de campo DESCRIPCION y CODIGO  de la tabla FORMASPAGO'
ALTER TABLE FORMASPAGO ALTER COLUMN DESCRIPCION varchar(90) COLLATE Modern_Spanish_CI_AS;

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.EntregasCuenta
	DROP CONSTRAINT FK_EntregasCuenta_USUARIOS
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT FK_N_Entradas_N_Entradas_Tipos
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT FK_N_PedidosProveedor_N_PedidosProveedor_Tipos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT FK_N_FacturasRecibidas_N_FacturasRecibidas_Tipos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT FK_N_Proveedores_N_Bancos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT FK_N_Factura_N_Factura_Tipos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT FK_CITAS_SALAS
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT FK_FACTURAS_N_Procesos
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT FK_CITAS_N_Procesos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fkfacturasmutua
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT FK_N_Ticket_N_Ticket_Tipos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT FK_N_Ticket_N_Pacientes
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fkfacturaspaciente
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT FK_N_Factura_N_Pacientes
GO
ALTER TABLE dbo.EntregasCuenta
	DROP CONSTRAINT FK_EntregasCuenta_PACIENTES
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fkfrasmeijideempresa
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fkfacturasempresa
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fkdr1frasmeijide
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fkdr2frasmeijide
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT fkmedico
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_FORMASPAGO
	(
	CODIGO varchar(10) NOT NULL,
	DESCRIPCION varchar(90) NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.FORMASPAGO)
	 EXEC('INSERT INTO dbo.Tmp_FORMASPAGO (CODIGO, DESCRIPCION)
		SELECT CODIGO, DESCRIPCION FROM dbo.FORMASPAGO WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fk_frasmeijideformapago
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT FK_N_Ticket_FormasPago
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fk_facturasformapago
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT fk_citas
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT FK_N_Factura_FormasPago
GO
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT FK_N_Proveedores_FormasPago
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT FK_N_FacturasRecibidas_FormasPago
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT FK_N_PedidosProveedor_FormasPago
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT FK_N_Entradas_FormasPago
GO
ALTER TABLE dbo.GASTOS
	DROP CONSTRAINT fk_gastosformapago
GO
ALTER TABLE dbo.EntregasCuenta
	DROP CONSTRAINT FK_EntregasCuenta_FORMASPAGO
GO
DROP TABLE dbo.FORMASPAGO
GO
EXECUTE sp_rename N'dbo.Tmp_FORMASPAGO', N'FORMASPAGO', 'OBJECT' 
GO
ALTER TABLE dbo.FORMASPAGO ADD CONSTRAINT
	PK_FORMASPAGO PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.EntregasCuenta
	DROP CONSTRAINT DF_EntregasCuenta_Fecha
GO
ALTER TABLE dbo.EntregasCuenta
	DROP CONSTRAINT DF_EntregasCuenta_Importe
GO
ALTER TABLE dbo.EntregasCuenta
	DROP CONSTRAINT DF_EntregasCuenta_Eliminado
GO
ALTER TABLE dbo.EntregasCuenta
	DROP CONSTRAINT DF_EntregasCuenta_PagadoConCredito
GO
CREATE TABLE dbo.Tmp_EntregasCuenta
	(
	IDEntregaCuenta bigint NOT NULL IDENTITY (1, 1),
	IDPaciente int NULL,
	Fecha datetime NULL,
	TipoDocumento int NULL,
	CodDocumento nvarchar(50) NULL,
	Descripcion varchar(MAX) NULL,
	Importe float(53) NULL,
	IDUsuarioEfectua int NULL,
	Eliminado bit NULL,
	PagadoConCredito bit NULL,
	IDFormaPago varchar(10) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_EntregasCuenta ADD CONSTRAINT
	DF_EntregasCuenta_Fecha DEFAULT (getdate()) FOR Fecha
GO
ALTER TABLE dbo.Tmp_EntregasCuenta ADD CONSTRAINT
	DF_EntregasCuenta_Importe DEFAULT ((0)) FOR Importe
GO
ALTER TABLE dbo.Tmp_EntregasCuenta ADD CONSTRAINT
	DF_EntregasCuenta_Eliminado DEFAULT ((0)) FOR Eliminado
GO
ALTER TABLE dbo.Tmp_EntregasCuenta ADD CONSTRAINT
	DF_EntregasCuenta_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
SET IDENTITY_INSERT dbo.Tmp_EntregasCuenta ON
GO
IF EXISTS(SELECT * FROM dbo.EntregasCuenta)
	 EXEC('INSERT INTO dbo.Tmp_EntregasCuenta (IDEntregaCuenta, IDPaciente, Fecha, TipoDocumento, CodDocumento, Descripcion, Importe, IDUsuarioEfectua, Eliminado, PagadoConCredito, IDFormaPago)
		SELECT IDEntregaCuenta, IDPaciente, Fecha, TipoDocumento, CodDocumento, Descripcion, Importe, IDUsuarioEfectua, Eliminado, PagadoConCredito, IDFormaPago FROM dbo.EntregasCuenta WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_EntregasCuenta OFF
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT FK_N_Ticket_EntregasCuenta
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT FK_FACTURAS_EntregasCuenta
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT FK_CITAS_EntregasCuenta
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT FK_N_Factura_EntregasCuenta
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT FK_RECIBOS_EntregasCuenta
GO
DROP TABLE dbo.EntregasCuenta
GO
EXECUTE sp_rename N'dbo.Tmp_EntregasCuenta', N'EntregasCuenta', 'OBJECT' 
GO
ALTER TABLE dbo.EntregasCuenta ADD CONSTRAINT
	PK_EntregasCuenta PRIMARY KEY CLUSTERED 
	(
	IDEntregaCuenta
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.EntregasCuenta ADD CONSTRAINT
	FK_EntregasCuenta_PACIENTES FOREIGN KEY
	(
	IDPaciente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.EntregasCuenta ADD CONSTRAINT
	FK_EntregasCuenta_FORMASPAGO FOREIGN KEY
	(
	IDFormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.EntregasCuenta ADD CONSTRAINT
	FK_EntregasCuenta_USUARIOS FOREIGN KEY
	(
	IDUsuarioEfectua
	) REFERENCES dbo.USUARIOS
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fk_frasmeijiderecibo
GO
ALTER TABLE dbo.RECIBOS ADD CONSTRAINT
	FK_RECIBOS_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_GASTOS
	(
	IDGASTO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	CONCEPTO varchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	IMPORTE decimal(18, 2) NULL,
	FECHA datetime NULL,
	REFFORMAPAGO varchar(10) NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_GASTOS ON
GO
IF EXISTS(SELECT * FROM dbo.GASTOS)
	 EXEC('INSERT INTO dbo.Tmp_GASTOS (IDGASTO, CONCEPTO, IMPORTE, FECHA, REFFORMAPAGO)
		SELECT IDGASTO, CONCEPTO, IMPORTE, FECHA, REFFORMAPAGO FROM dbo.GASTOS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_GASTOS OFF
GO
DROP TABLE dbo.GASTOS
GO
EXECUTE sp_rename N'dbo.Tmp_GASTOS', N'GASTOS', 'OBJECT' 
GO
ALTER TABLE dbo.GASTOS ADD CONSTRAINT
	PK_GASTOS PRIMARY KEY CLUSTERED 
	(
	IDGASTO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.GASTOS ADD CONSTRAINT
	fk_gastosformapago FOREIGN KEY
	(
	REFFORMAPAGO
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT DF_N_Proveedores_TipoProveedor
GO
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT DF_N_Proveedores_NombreFiscal
GO
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT DF_N_Proveedores_NombreComercial
GO
CREATE TABLE dbo.Tmp_N_Proveedores
	(
	ID_Proveedor int NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CodigoContabilidad int NULL,
	TipoProveedor int NOT NULL,
	NIF nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NombreFiscal nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NombreComercial nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Domicilio nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ID_Poblacion int NULL,
	CodigoPostal nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Telefono nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Fax nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Movil nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ID_Banco int NULL,
	CCC nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ID_FormaPago varchar(10) NULL,
	DiasPago1 int NULL,
	DiasPago2 int NULL,
	DiasPago3 int NULL,
	AprovisionamientoMeses int NULL,
	AprovisionamientoDias int NULL,
	TarifaEnActivo nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DescuentoFijo1 float(53) NULL,
	DescuentoFijo2 float(53) NULL,
	DescuentoFijo3 float(53) NULL,
	PorcentajeRetension float(53) NULL,
	TipoPorte int NULL,
	Porte nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	RappelFijo float(53) NULL,
	PagoRapels nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	FechaAlta datetime NULL,
	Web nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Email nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Observaciones nvarchar(500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Horario nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	VacacionesDesde nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	VacacionesHasta nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NoVenderArticulos bit NULL,
	NoRealizarPagos bit NULL,
	NoImprimir bit NULL,
	TipoIVA int NULL,
	RE bit NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Proveedores ADD CONSTRAINT
	DF_N_Proveedores_TipoProveedor DEFAULT ((1)) FOR TipoProveedor
GO
ALTER TABLE dbo.Tmp_N_Proveedores ADD CONSTRAINT
	DF_N_Proveedores_NombreFiscal DEFAULT ('') FOR NombreFiscal
GO
ALTER TABLE dbo.Tmp_N_Proveedores ADD CONSTRAINT
	DF_N_Proveedores_NombreComercial DEFAULT ('') FOR NombreComercial
GO
SET IDENTITY_INSERT dbo.Tmp_N_Proveedores ON
GO
IF EXISTS(SELECT * FROM dbo.N_Proveedores)
	 EXEC('INSERT INTO dbo.Tmp_N_Proveedores (ID_Proveedor, Codigo, CodigoContabilidad, TipoProveedor, NIF, NombreFiscal, NombreComercial, Domicilio, ID_Poblacion, CodigoPostal, Telefono, Fax, Movil, ID_Banco, CCC, ID_FormaPago, DiasPago1, DiasPago2, DiasPago3, AprovisionamientoMeses, AprovisionamientoDias, TarifaEnActivo, DescuentoFijo1, DescuentoFijo2, DescuentoFijo3, PorcentajeRetension, TipoPorte, Porte, RappelFijo, PagoRapels, FechaAlta, Web, Email, Observaciones, Horario, VacacionesDesde, VacacionesHasta, NoVenderArticulos, NoRealizarPagos, NoImprimir, TipoIVA, RE)
		SELECT ID_Proveedor, Codigo, CodigoContabilidad, TipoProveedor, NIF, NombreFiscal, NombreComercial, Domicilio, ID_Poblacion, CodigoPostal, Telefono, Fax, Movil, ID_Banco, CCC, ID_FormaPago, DiasPago1, DiasPago2, DiasPago3, AprovisionamientoMeses, AprovisionamientoDias, TarifaEnActivo, DescuentoFijo1, DescuentoFijo2, DescuentoFijo3, PorcentajeRetension, TipoPorte, Porte, RappelFijo, PagoRapels, FechaAlta, Web, Email, Observaciones, Horario, VacacionesDesde, VacacionesHasta, NoVenderArticulos, NoRealizarPagos, NoImprimir, TipoIVA, RE FROM dbo.N_Proveedores WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Proveedores OFF
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT FK_N_FacturasRecibidas_N_Proveedores
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT FK_N_PedidosProveedor_N_Proveedores
GO
ALTER TABLE dbo.N_Articulos_Proveedores
	DROP CONSTRAINT FK_N_Articulos_Proveedores_N_Proveedores
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT FK_N_Entradas_N_Proveedores
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT FK_N_Articulos_N_Proveedores
GO
DROP TABLE dbo.N_Proveedores
GO
EXECUTE sp_rename N'dbo.Tmp_N_Proveedores', N'N_Proveedores', 'OBJECT' 
GO
ALTER TABLE dbo.N_Proveedores ADD CONSTRAINT
	PK_N_Proveedores PRIMARY KEY CLUSTERED 
	(
	ID_Proveedor
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Proveedores ADD CONSTRAINT
	FK_N_Proveedores_N_Bancos FOREIGN KEY
	(
	ID_Banco
	) REFERENCES dbo.BANCOS
	(
	IdBanco
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Proveedores ADD CONSTRAINT
	FK_N_Proveedores_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos ADD CONSTRAINT
	FK_N_Articulos_N_Proveedores FOREIGN KEY
	(
	ID_ProveedorHabitual
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT DF_N_Entradas_REPorciento
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT DF_N_Entradas_ReCantidad
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT DF_N_Entradas_PortePagado
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT DF_N_Entradas_PorteDebido
GO
CREATE TABLE dbo.Tmp_N_Entradas
	(
	ID_Entrada bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ID_TipoEntrada int NULL,
	Referencia nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Fecha datetime NULL,
	ID_Estado int NULL,
	ID_Proveedor int NULL,
	ID_FormaPago varchar(10) NULL,
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
	Imagen image NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Entradas ADD CONSTRAINT
	DF_N_Entradas_REPorciento DEFAULT ((0)) FOR IRPFPorciento
GO
ALTER TABLE dbo.Tmp_N_Entradas ADD CONSTRAINT
	DF_N_Entradas_ReCantidad DEFAULT ((0)) FOR IRPFCantidad
GO
ALTER TABLE dbo.Tmp_N_Entradas ADD CONSTRAINT
	DF_N_Entradas_PortePagado DEFAULT ((1)) FOR PortePagado
GO
ALTER TABLE dbo.Tmp_N_Entradas ADD CONSTRAINT
	DF_N_Entradas_PorteDebido DEFAULT ((0)) FOR PorteDebido
GO
SET IDENTITY_INSERT dbo.Tmp_N_Entradas ON
GO
IF EXISTS(SELECT * FROM dbo.N_Entradas)
	 EXEC('INSERT INTO dbo.Tmp_N_Entradas (ID_Entrada, Codigo, ID_TipoEntrada, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen)
		SELECT ID_Entrada, Codigo, ID_TipoEntrada, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen FROM dbo.N_Entradas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Entradas OFF
GO
ALTER TABLE dbo.N_Entradas_Lineas
	DROP CONSTRAINT FK_N_Entradas_Lineas_N_Entradas
GO
ALTER TABLE dbo.N_Entradas_Totales
	DROP CONSTRAINT FK_N_Entradas_Totales_N_Entradas
GO
DROP TABLE dbo.N_Entradas
GO
EXECUTE sp_rename N'dbo.Tmp_N_Entradas', N'N_Entradas', 'OBJECT' 
GO
ALTER TABLE dbo.N_Entradas ADD CONSTRAINT
	PK_N_Entradas PRIMARY KEY CLUSTERED 
	(
	ID_Entrada
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Entradas ADD CONSTRAINT
	FK_N_Entradas_N_Entradas_Tipos FOREIGN KEY
	(
	ID_TipoEntrada
	) REFERENCES dbo.N_Entradas_Tipos
	(
	ID_TipoEntrada
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Entradas ADD CONSTRAINT
	FK_N_Entradas_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Entradas ADD CONSTRAINT
	FK_N_Entradas_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas_Totales ADD CONSTRAINT
	FK_N_Entradas_Totales_N_Entradas FOREIGN KEY
	(
	ID_Entrada
	) REFERENCES dbo.N_Entradas
	(
	ID_Entrada
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas_Lineas ADD CONSTRAINT
	FK_N_Entradas_Lineas_N_Entradas FOREIGN KEY
	(
	ID_Entrada
	) REFERENCES dbo.N_Entradas
	(
	ID_Entrada
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos_Proveedores ADD CONSTRAINT
	FK_N_Articulos_Proveedores_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT DF_N_PedidosProveedor_REPorciento
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT DF_N_PedidosProveedor_ReCantidad
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT DF_N_PedidosProveedor_PortePagado
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT DF_N_PedidosProveedor_PorteDebido
GO
CREATE TABLE dbo.Tmp_N_PedidosProveedor
	(
	ID_PedidoProveedor bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ID_TipoPedidoProveedor int NULL,
	Referencia nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Fecha datetime NULL,
	ID_Estado int NULL,
	ID_Proveedor int NULL,
	ID_FormaPago varchar(10) NULL,
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
	Imagen image NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_PedidosProveedor ADD CONSTRAINT
	DF_N_PedidosProveedor_REPorciento DEFAULT ((0)) FOR IRPFPorciento
GO
ALTER TABLE dbo.Tmp_N_PedidosProveedor ADD CONSTRAINT
	DF_N_PedidosProveedor_ReCantidad DEFAULT ((0)) FOR IRPFCantidad
GO
ALTER TABLE dbo.Tmp_N_PedidosProveedor ADD CONSTRAINT
	DF_N_PedidosProveedor_PortePagado DEFAULT ((1)) FOR PortePagado
GO
ALTER TABLE dbo.Tmp_N_PedidosProveedor ADD CONSTRAINT
	DF_N_PedidosProveedor_PorteDebido DEFAULT ((0)) FOR PorteDebido
GO
SET IDENTITY_INSERT dbo.Tmp_N_PedidosProveedor ON
GO
IF EXISTS(SELECT * FROM dbo.N_PedidosProveedor)
	 EXEC('INSERT INTO dbo.Tmp_N_PedidosProveedor (ID_PedidoProveedor, Codigo, ID_TipoPedidoProveedor, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen)
		SELECT ID_PedidoProveedor, Codigo, ID_TipoPedidoProveedor, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen FROM dbo.N_PedidosProveedor WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_PedidosProveedor OFF
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas
	DROP CONSTRAINT FK_N_PedidosProveedor_Lineas_N_PedidosProveedor
GO
ALTER TABLE dbo.N_PedidosProveedor_Totales
	DROP CONSTRAINT FK_N_PedidosProveedor_Totales_N_PedidosProveedor
GO
DROP TABLE dbo.N_PedidosProveedor
GO
EXECUTE sp_rename N'dbo.Tmp_N_PedidosProveedor', N'N_PedidosProveedor', 'OBJECT' 
GO
ALTER TABLE dbo.N_PedidosProveedor ADD CONSTRAINT
	PK_N_PedidosProveedor PRIMARY KEY CLUSTERED 
	(
	ID_PedidoProveedor
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_PedidosProveedor ADD CONSTRAINT
	FK_N_PedidosProveedor_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_PedidosProveedor ADD CONSTRAINT
	FK_N_PedidosProveedor_N_PedidosProveedor_Tipos FOREIGN KEY
	(
	ID_TipoPedidoProveedor
	) REFERENCES dbo.N_PedidosProveedor_Tipos
	(
	ID_TipoPedidoProveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_PedidosProveedor ADD CONSTRAINT
	FK_N_PedidosProveedor_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor_Totales ADD CONSTRAINT
	FK_N_PedidosProveedor_Totales_N_PedidosProveedor FOREIGN KEY
	(
	ID_PedidoProveedor
	) REFERENCES dbo.N_PedidosProveedor
	(
	ID_PedidoProveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas ADD CONSTRAINT
	FK_N_PedidosProveedor_Lineas_N_PedidosProveedor FOREIGN KEY
	(
	ID_PedidoProveedor
	) REFERENCES dbo.N_PedidosProveedor
	(
	ID_PedidoProveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT DF_N_FacturasRecibidas_REPorciento
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT DF_N_FacturasRecibidas_ReCantidad
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT DF_N_FacturasRecibidas_PortePagado
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT DF_N_FacturasRecibidas_PorteDebido
GO
CREATE TABLE dbo.Tmp_N_FacturasRecibidas
	(
	ID_FacturaRecibida bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ID_TipoFacturaRecibida int NULL,
	Referencia nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Fecha datetime NULL,
	ID_Estado int NULL,
	ID_Proveedor int NULL,
	ID_FormaPago varchar(10) NULL,
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
	CodigoFacturaRecibida nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_FacturasRecibidas ADD CONSTRAINT
	DF_N_FacturasRecibidas_REPorciento DEFAULT ((0)) FOR IRPFPorciento
GO
ALTER TABLE dbo.Tmp_N_FacturasRecibidas ADD CONSTRAINT
	DF_N_FacturasRecibidas_ReCantidad DEFAULT ((0)) FOR IRPFCantidad
GO
ALTER TABLE dbo.Tmp_N_FacturasRecibidas ADD CONSTRAINT
	DF_N_FacturasRecibidas_PortePagado DEFAULT ((1)) FOR PortePagado
GO
ALTER TABLE dbo.Tmp_N_FacturasRecibidas ADD CONSTRAINT
	DF_N_FacturasRecibidas_PorteDebido DEFAULT ((0)) FOR PorteDebido
GO
SET IDENTITY_INSERT dbo.Tmp_N_FacturasRecibidas ON
GO
IF EXISTS(SELECT * FROM dbo.N_FacturasRecibidas)
	 EXEC('INSERT INTO dbo.Tmp_N_FacturasRecibidas (ID_FacturaRecibida, Codigo, ID_TipoFacturaRecibida, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, CodigoFacturaRecibida)
		SELECT ID_FacturaRecibida, Codigo, ID_TipoFacturaRecibida, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, CodigoFacturaRecibida FROM dbo.N_FacturasRecibidas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_FacturasRecibidas OFF
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas
	DROP CONSTRAINT FK_N_FacturasRecibidas_Lineas_N_FacturasRecibidas
GO
ALTER TABLE dbo.N_FacturasRecibidas_Totales
	DROP CONSTRAINT FK_N_FacturasRecibidas_Totales_N_FacturasRecibidas
GO
DROP TABLE dbo.N_FacturasRecibidas
GO
EXECUTE sp_rename N'dbo.Tmp_N_FacturasRecibidas', N'N_FacturasRecibidas', 'OBJECT' 
GO
ALTER TABLE dbo.N_FacturasRecibidas ADD CONSTRAINT
	PK_N_FacturasRecibidas PRIMARY KEY CLUSTERED 
	(
	ID_FacturaRecibida
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_FacturasRecibidas ADD CONSTRAINT
	FK_N_FacturasRecibidas_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_FacturasRecibidas ADD CONSTRAINT
	FK_N_FacturasRecibidas_N_FacturasRecibidas_Tipos FOREIGN KEY
	(
	ID_TipoFacturaRecibida
	) REFERENCES dbo.N_FacturasRecibidas_Tipos
	(
	ID_TipoFacturaRecibida
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_FacturasRecibidas ADD CONSTRAINT
	FK_N_FacturasRecibidas_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas_Totales ADD CONSTRAINT
	FK_N_FacturasRecibidas_Totales_N_FacturasRecibidas FOREIGN KEY
	(
	ID_FacturaRecibida
	) REFERENCES dbo.N_FacturasRecibidas
	(
	ID_FacturaRecibida
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas ADD CONSTRAINT
	FK_N_FacturasRecibidas_Lineas_N_FacturasRecibidas FOREIGN KEY
	(
	ID_FacturaRecibida
	) REFERENCES dbo.N_FacturasRecibidas
	(
	ID_FacturaRecibida
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
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
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT DF_N_Factura_PagadoConCredito
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
	ID_FormaPago varchar(10) NULL,
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
	FechaPagado datetime NULL,
	IDEntregaCuenta bigint NULL,
	PagadoConCredito bit NULL
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
ALTER TABLE dbo.Tmp_N_Factura ADD CONSTRAINT
	DF_N_Factura_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
SET IDENTITY_INSERT dbo.Tmp_N_Factura ON
GO
IF EXISTS(SELECT * FROM dbo.N_Factura)
	 EXEC('INSERT INTO dbo.Tmp_N_Factura (ID_Factura, Codigo, ID_TipoFactura, Referencia, Fecha, ID_Estado, ID_Cliente, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, Pagado, FechaPagado, IDEntregaCuenta, PagadoConCredito)
		SELECT ID_Factura, Codigo, ID_TipoFactura, Referencia, Fecha, ID_Estado, ID_Cliente, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, Pagado, FechaPagado, IDEntregaCuenta, PagadoConCredito FROM dbo.N_Factura WITH (HOLDLOCK TABLOCKX)')
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
ALTER TABLE dbo.N_Factura ADD CONSTRAINT
	FK_N_Factura_N_Pacientes FOREIGN KEY
	(
	ID_Cliente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Factura ADD CONSTRAINT
	FK_N_Factura_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF__CITAS__CONFIRMAD__108B795B
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF__CITAS__BANCO__117F9D94
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF__CITAS__PAGADA__1273C1CD
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF__CITAS__ATENDIDO__1367E606
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF__CITAS__REFPROCED__145C0A3F
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF_CITAS_Descuento
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF_CITAS_TOTAL
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF_CITAS_TipoCita
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF_CITAS_Eliminado
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF_CITAS_PagadoConCredito
GO
CREATE TABLE dbo.Tmp_CITAS
	(
	IDCITA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPACIENTE int NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	CONFIRMADA varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NOTAS text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFMEDICO int NULL,
	PACIENTE varchar(60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	IMPORTEDR decimal(18, 2) NULL,
	IMPORTECL decimal(18, 2) NULL,
	CONTINUA varchar(7) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	FALTA varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	BANCO varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PAGADA varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFRECIBO int NULL,
	ATENDIDO varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFFRA int NULL,
	REFFORMAPAGO varchar(10) NULL,
	HORAFIN datetime NULL,
	FECHACOBRO datetime NULL,
	REFPROCEDENCIA int NULL,
	ID_Proceso bigint NULL,
	EstadoRecurrencia int NULL,
	FechaUltimoEstadoRecurrencia datetime NULL,
	Descuento float(53) NULL,
	ID_SALA int NULL,
	TOTAL decimal(18, 2) NULL,
	TipoCita int NULL,
	Eliminado bit NULL,
	IDEntregaCuenta bigint NULL,
	PagadoConCredito bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF__CITAS__CONFIRMAD__108B795B DEFAULT ('S') FOR CONFIRMADA
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF__CITAS__BANCO__117F9D94 DEFAULT ('N') FOR BANCO
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF__CITAS__PAGADA__1273C1CD DEFAULT ('N') FOR PAGADA
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF__CITAS__ATENDIDO__1367E606 DEFAULT ('N') FOR ATENDIDO
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF__CITAS__REFPROCED__145C0A3F DEFAULT ((-1)) FOR REFPROCEDENCIA
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF_CITAS_Descuento DEFAULT ((0)) FOR Descuento
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF_CITAS_TOTAL DEFAULT ((0)) FOR TOTAL
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF_CITAS_TipoCita DEFAULT ((0)) FOR TipoCita
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF_CITAS_Eliminado DEFAULT ((0)) FOR Eliminado
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF_CITAS_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
SET IDENTITY_INSERT dbo.Tmp_CITAS ON
GO
IF EXISTS(SELECT * FROM dbo.CITAS)
	 EXEC('INSERT INTO dbo.Tmp_CITAS (IDCITA, REFPACIENTE, FECHA, HORA, CONFIRMADA, NOTAS, REFMEDICO, PACIENTE, IMPORTEDR, IMPORTECL, CONTINUA, FALTA, BANCO, PAGADA, REFRECIBO, ATENDIDO, REFFRA, REFFORMAPAGO, HORAFIN, FECHACOBRO, REFPROCEDENCIA, ID_Proceso, EstadoRecurrencia, FechaUltimoEstadoRecurrencia, Descuento, ID_SALA, TOTAL, TipoCita, Eliminado, IDEntregaCuenta, PagadoConCredito)
		SELECT IDCITA, REFPACIENTE, FECHA, HORA, CONFIRMADA, NOTAS, REFMEDICO, PACIENTE, IMPORTEDR, IMPORTECL, CONTINUA, FALTA, BANCO, PAGADA, REFRECIBO, ATENDIDO, REFFRA, REFFORMAPAGO, HORAFIN, FECHACOBRO, REFPROCEDENCIA, ID_Proceso, EstadoRecurrencia, FechaUltimoEstadoRecurrencia, Descuento, ID_SALA, TOTAL, TipoCita, Eliminado, IDEntregaCuenta, PagadoConCredito FROM dbo.CITAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_CITAS OFF
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS
	DROP CONSTRAINT FK_LCOMPARATIVAS_TRATAMIENTOS_CITAS
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT FK_d_PresupuestoLineas_Citas
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT FK_LINEASFACTURAS_CITAS
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT FK_LineasCitas_Citas
GO
DROP TABLE dbo.CITAS
GO
EXECUTE sp_rename N'dbo.Tmp_CITAS', N'CITAS', 'OBJECT' 
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	PK_CITAS PRIMARY KEY CLUSTERED 
	(
	IDCITA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	fk_citas FOREIGN KEY
	(
	REFFORMAPAGO
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	fkmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	FK_CITAS_SALAS FOREIGN KEY
	(
	ID_SALA
	) REFERENCES dbo.SALAS
	(
	ID_SALA
	) ON UPDATE  CASCADE 
	 ON DELETE  SET NULL 
	
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	FK_CITAS_N_Procesos FOREIGN KEY
	(
	ID_Proceso
	) REFERENCES dbo.N_Procesos
	(
	ID_Proceso
	) ON UPDATE  CASCADE 
	 ON DELETE  SET NULL 
	
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	FK_CITAS_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	FK_LineasCitas_Citas FOREIGN KEY
	(
	IdCita
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_PresupuestoLineas ADD CONSTRAINT
	FK_d_PresupuestoLineas_Citas FOREIGN KEY
	(
	IDCITA
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  SET NULL 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS ADD CONSTRAINT
	FK_LCOMPARATIVAS_TRATAMIENTOS_CITAS FOREIGN KEY
	(
	ID_Cita
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__PAGADA__22AA2996
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__MUTUA__239E4DCF
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__RECIBO__24927208
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__PORCEN__25869641
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__FACTUR__267ABA7A
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__TIPOIV__276EDEB3
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF_FACTURAS_Descuento
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF_FACTURAS_Eliminado
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF_FACTURAS_PagadoConCredito
GO
CREATE TABLE dbo.Tmp_FACTURAS
	(
	IDFACTURA int NOT NULL,
	NUMEROFACTURA int NOT NULL,
	REFPACIENTE int NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	HISTORIAL int NULL,
	REFEMPRESA int NULL,
	REFMUTUA int NULL,
	FACCIDENTE datetime NULL,
	FBAJA datetime NULL,
	FALTA datetime NULL,
	FEMISION datetime NULL,
	TOTAL decimal(18, 2) NULL,
	IRPF decimal(18, 2) NULL,
	DIAGNOSTICO varchar(60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PAGADA varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	MUTUA varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	RECIBO varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DIRECCION varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	LOCALIDAD varchar(35) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PROVINCIA varchar(35) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CP varchar(6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFRECIBO int NULL,
	PACIENTE varchar(90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFCITA int NULL,
	FECHACOBRO datetime NULL,
	PORCENTAJEIRPF real NOT NULL,
	REFFORMAPAGO varchar(10) NULL,
	DNI varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	EMPRESA varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	FACTURAR varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	NUMERO varchar(12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFSERIE varchar(6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	TIPOIVA real NULL,
	ID_Proceso bigint NULL,
	N19 nvarchar(1) NULL,
	Descuento float(53) NULL,
	FECHAENVIO datetime NULL,
	Eliminado bit NULL,
	IDEntregaCuenta bigint NULL,
	PagadoConCredito bit NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__PAGADA__22AA2996 DEFAULT ('N') FOR PAGADA
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__MUTUA__239E4DCF DEFAULT ('N') FOR MUTUA
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__RECIBO__24927208 DEFAULT ('N') FOR RECIBO
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__PORCEN__25869641 DEFAULT ((0)) FOR PORCENTAJEIRPF
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__FACTUR__267ABA7A DEFAULT ('P') FOR FACTURAR
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__TIPOIV__276EDEB3 DEFAULT ((0)) FOR TIPOIVA
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF_FACTURAS_Descuento DEFAULT ((0)) FOR Descuento
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF_FACTURAS_Eliminado DEFAULT ((0)) FOR Eliminado
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF_FACTURAS_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
IF EXISTS(SELECT * FROM dbo.FACTURAS)
	 EXEC('INSERT INTO dbo.Tmp_FACTURAS (IDFACTURA, NUMEROFACTURA, REFPACIENTE, FECHA, HORA, HISTORIAL, REFEMPRESA, REFMUTUA, FACCIDENTE, FBAJA, FALTA, FEMISION, TOTAL, IRPF, DIAGNOSTICO, PAGADA, MUTUA, RECIBO, DIRECCION, LOCALIDAD, PROVINCIA, CP, REFRECIBO, PACIENTE, REFCITA, FECHACOBRO, PORCENTAJEIRPF, REFFORMAPAGO, DNI, EMPRESA, FACTURAR, NUMERO, REFSERIE, TIPOIVA, ID_Proceso, N19, Descuento, FECHAENVIO, Eliminado, IDEntregaCuenta, PagadoConCredito)
		SELECT IDFACTURA, NUMEROFACTURA, REFPACIENTE, FECHA, HORA, HISTORIAL, REFEMPRESA, REFMUTUA, FACCIDENTE, FBAJA, FALTA, FEMISION, TOTAL, IRPF, DIAGNOSTICO, PAGADA, MUTUA, RECIBO, DIRECCION, LOCALIDAD, PROVINCIA, CP, REFRECIBO, PACIENTE, REFCITA, FECHACOBRO, PORCENTAJEIRPF, REFFORMAPAGO, DNI, EMPRESA, FACTURAR, NUMERO, REFSERIE, TIPOIVA, ID_Proceso, N19, Descuento, FECHAENVIO, Eliminado, IDEntregaCuenta, PagadoConCredito FROM dbo.FACTURAS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT fklineasfacturas
GO
DROP TABLE dbo.FACTURAS
GO
EXECUTE sp_rename N'dbo.Tmp_FACTURAS', N'FACTURAS', 'OBJECT' 
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	PK_FACTURAS PRIMARY KEY CLUSTERED 
	(
	IDFACTURA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fkfacturaspaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	FK_FACTURAS_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fk_facturasformapago FOREIGN KEY
	(
	REFFORMAPAGO
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fkfacturasempresa FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fkfacturasmutua FOREIGN KEY
	(
	REFMUTUA
	) REFERENCES dbo.MUTUAS
	(
	CMUTUA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	FK_FACTURAS_N_Procesos FOREIGN KEY
	(
	ID_Proceso
	) REFERENCES dbo.N_Procesos
	(
	ID_Proceso
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	fklineasfacturas FOREIGN KEY
	(
	REFFACTURA
	) REFERENCES dbo.FACTURAS
	(
	IDFACTURA
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	FK_LINEASFACTURAS_CITAS FOREIGN KEY
	(
	ID_Cita
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_Ticket_Fecha
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_REPorciento
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_ReCantidad
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_PortePagado
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_PorteDebido
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_Pagado
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_FechaPagado
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_Eliminado
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_PagadoConCredito
GO
CREATE TABLE dbo.Tmp_N_Ticket
	(
	ID_Ticket bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ID_TipoTicket int NULL,
	Referencia nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Fecha datetime NOT NULL,
	ID_Estado int NULL,
	ID_Cliente int NULL,
	ID_FormaPago varchar(10) NULL,
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
	Pagado bit NOT NULL,
	FechaPagado datetime NULL,
	NombrePaciente nvarchar(50) NULL,
	FormaPago nvarchar(50) NULL,
	Eliminado bit NULL,
	IDEntregaCuenta bigint NULL,
	PagadoConCredito bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_Ticket_Fecha DEFAULT (getdate()) FOR Fecha
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_REPorciento DEFAULT ((0)) FOR IRPFPorciento
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_ReCantidad DEFAULT ((0)) FOR IRPFCantidad
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_PortePagado DEFAULT ((1)) FOR PortePagado
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_PorteDebido DEFAULT ((0)) FOR PorteDebido
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_Pagado DEFAULT ((0)) FOR Pagado
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_FechaPagado DEFAULT (getdate()) FOR FechaPagado
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_Eliminado DEFAULT ((0)) FOR Eliminado
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
SET IDENTITY_INSERT dbo.Tmp_N_Ticket ON
GO
IF EXISTS(SELECT * FROM dbo.N_Ticket)
	 EXEC('INSERT INTO dbo.Tmp_N_Ticket (ID_Ticket, Codigo, ID_TipoTicket, Referencia, Fecha, ID_Estado, ID_Cliente, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, Pagado, FechaPagado, NombrePaciente, FormaPago, Eliminado, IDEntregaCuenta, PagadoConCredito)
		SELECT ID_Ticket, Codigo, ID_TipoTicket, Referencia, Fecha, ID_Estado, ID_Cliente, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, Pagado, FechaPagado, NombrePaciente, FormaPago, Eliminado, IDEntregaCuenta, PagadoConCredito FROM dbo.N_Ticket WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Ticket OFF
GO
ALTER TABLE dbo.N_Ticket_Lineas
	DROP CONSTRAINT FK_N_Ticket_Lineas_N_Ticket
GO
ALTER TABLE dbo.N_Ticket_Totales
	DROP CONSTRAINT FK_N_Ticket_Totales_N_Ticket
GO
DROP TABLE dbo.N_Ticket
GO
EXECUTE sp_rename N'dbo.Tmp_N_Ticket', N'N_Ticket', 'OBJECT' 
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	PK_N_Ticket PRIMARY KEY CLUSTERED 
	(
	ID_Ticket
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	FK_N_Ticket_N_Pacientes FOREIGN KEY
	(
	ID_Cliente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	FK_N_Ticket_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	FK_N_Ticket_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	FK_N_Ticket_N_Ticket_Tipos FOREIGN KEY
	(
	ID_TipoTicket
	) REFERENCES dbo.N_Ticket_Tipos
	(
	ID_TipoTicket
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket_Totales ADD CONSTRAINT
	FK_N_Ticket_Totales_N_Ticket FOREIGN KEY
	(
	ID_Ticket
	) REFERENCES dbo.N_Ticket
	(
	ID_Ticket
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket_Lineas ADD CONSTRAINT
	FK_N_Ticket_Lineas_N_Ticket FOREIGN KEY
	(
	ID_Ticket
	) REFERENCES dbo.N_Ticket
	(
	ID_Ticket
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT DF__FRASMEIJI__MUTUA__2D27B809
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT DF__FRASMEIJI__RECIB__2E1BDC42
GO
CREATE TABLE dbo.Tmp_FRASMEIJIDE
	(
	NUMEROFACTURA int NOT NULL,
	REFPACIENTE int NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	REFEMPRESA int NULL,
	REFMUTUA int NULL,
	FACCIDENTE datetime NULL,
	FBAJA datetime NULL,
	FALTA datetime NULL,
	FEMISION datetime NULL,
	TOTAL decimal(18, 2) NULL,
	IRPF decimal(18, 2) NULL,
	DIAGNOSTICO varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DR1 varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DR2 varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DR1IMPORTE decimal(18, 2) NULL,
	DR2IMPORTE decimal(18, 2) NULL,
	RADIOGRAFIA varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	RADIOGRAFIAIMPORTE decimal(18, 2) NULL,
	EKG varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	EKGIMPORTE decimal(18, 2) NULL,
	ECOGRAFIA varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ECOGRAFIAIMPORTE decimal(18, 2) NULL,
	ANALISIS varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ANALISISIMPORTE decimal(18, 2) NULL,
	MATERIAL varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	MATERIALIMPORTE decimal(18, 2) NULL,
	URGENCIAS varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	URGENCIASIMPORTE decimal(18, 2) NULL,
	CONCEPTO1 varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONCEPTO1IMPORTE decimal(18, 2) NULL,
	CONCEPTO2 varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONCEPTO2IMPORTE decimal(18, 2) NULL,
	PAGADA varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFDR1 int NULL,
	REFDR2 int NULL,
	ANNO varchar(2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	MUTUA varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	FECHACOBRO datetime NULL,
	PACIENTE varchar(90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DOMICILIOPACIENTE varchar(60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	LOCALIDADPACIENTE varchar(40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CPPACIENTE varchar(5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PROVINCIAPACIENTE varchar(40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	RECIBO varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	REFCITA int NULL,
	REFRECIBO int NULL,
	REFFORMAPAGO varchar(10) NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_FRASMEIJIDE ADD CONSTRAINT
	DF__FRASMEIJI__MUTUA__2D27B809 DEFAULT ('N') FOR MUTUA
GO
ALTER TABLE dbo.Tmp_FRASMEIJIDE ADD CONSTRAINT
	DF__FRASMEIJI__RECIB__2E1BDC42 DEFAULT ('N') FOR RECIBO
GO
IF EXISTS(SELECT * FROM dbo.FRASMEIJIDE)
	 EXEC('INSERT INTO dbo.Tmp_FRASMEIJIDE (NUMEROFACTURA, REFPACIENTE, FECHA, HORA, REFEMPRESA, REFMUTUA, FACCIDENTE, FBAJA, FALTA, FEMISION, TOTAL, IRPF, DIAGNOSTICO, DR1, DR2, DR1IMPORTE, DR2IMPORTE, RADIOGRAFIA, RADIOGRAFIAIMPORTE, EKG, EKGIMPORTE, ECOGRAFIA, ECOGRAFIAIMPORTE, ANALISIS, ANALISISIMPORTE, MATERIAL, MATERIALIMPORTE, URGENCIAS, URGENCIASIMPORTE, CONCEPTO1, CONCEPTO1IMPORTE, CONCEPTO2, CONCEPTO2IMPORTE, PAGADA, REFDR1, REFDR2, ANNO, MUTUA, FECHACOBRO, PACIENTE, DOMICILIOPACIENTE, LOCALIDADPACIENTE, CPPACIENTE, PROVINCIAPACIENTE, RECIBO, REFCITA, REFRECIBO, REFFORMAPAGO)
		SELECT NUMEROFACTURA, REFPACIENTE, FECHA, HORA, REFEMPRESA, REFMUTUA, FACCIDENTE, FBAJA, FALTA, FEMISION, TOTAL, IRPF, DIAGNOSTICO, DR1, DR2, DR1IMPORTE, DR2IMPORTE, RADIOGRAFIA, RADIOGRAFIAIMPORTE, EKG, EKGIMPORTE, ECOGRAFIA, ECOGRAFIAIMPORTE, ANALISIS, ANALISISIMPORTE, MATERIAL, MATERIALIMPORTE, URGENCIAS, URGENCIASIMPORTE, CONCEPTO1, CONCEPTO1IMPORTE, CONCEPTO2, CONCEPTO2IMPORTE, PAGADA, REFDR1, REFDR2, ANNO, MUTUA, FECHACOBRO, PACIENTE, DOMICILIOPACIENTE, LOCALIDADPACIENTE, CPPACIENTE, PROVINCIAPACIENTE, RECIBO, REFCITA, REFRECIBO, REFFORMAPAGO FROM dbo.FRASMEIJIDE WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.FRASMEIJIDE
GO
EXECUTE sp_rename N'dbo.Tmp_FRASMEIJIDE', N'FRASMEIJIDE', 'OBJECT' 
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	PK_FRASMEIJIDE PRIMARY KEY CLUSTERED 
	(
	NUMEROFACTURA,
	ANNO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fk_frasmeijideformapago FOREIGN KEY
	(
	REFFORMAPAGO
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fk_frasmeijiderecibo FOREIGN KEY
	(
	REFRECIBO
	) REFERENCES dbo.RECIBOS
	(
	NUMERO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fkdr1frasmeijide FOREIGN KEY
	(
	REFDR1
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fkdr2frasmeijide FOREIGN KEY
	(
	REFDR2
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fkfrasmeijideempresa FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'Annade columna automático a tabla pagospaciente';

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
ALTER TABLE dbo.PagosPaciente ADD
	Automatico bit NOT NULL CONSTRAINT DF_PagosPaciente_Automatico DEFAULT 0
GO

COMMIT

PRINT 'Agregamos los nuevos permisos';
INSERT ROLESITEMS (ID_ROLESITEM,Nombre) values (94,'Informes médicos')
INSERT ROLESITEMS (ID_ROLESITEM,Nombre) values (95,'Reportes Personalizados')
INSERT ROLESITEMS (ID_ROLESITEM,Nombre) values (96,'Médicos Ficheros')
INSERT ROLESITEMS (ID_ROLESITEM,Nombre) values (97,'Entregas a cuenta')
INSERT ROLESITEMS (ID_ROLESITEM,Nombre) values (98,'Revisión Seguimiento')
INSERT ROLESITEMS (ID_ROLESITEM,Nombre) values (99,'Revisión Tratamiento')
INSERT ROLESITEMS (ID_ROLESITEM,Nombre) values(100,'Pago Paciente')
INSERT ROLESITEMS (ID_ROLESITEM,Nombre) values (101,'Pago Paciente Borrar')
INSERT ROLESITEMS (ID_ROLESITEM,Nombre) values (102,'Recetas XML')

GO

PRINT 'CAMBIAR COLLATION DE TABLA ASISTENCIAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.ASISTENCIAS
	DROP CONSTRAINT fkasistenciasmedico
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_ASISTENCIAS
	(
	IDASISTENCIA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPARTE int NULL,
	FECHAACCIDENTE datetime NULL,
	FECHAASISTENCIA datetime NULL,
	OBSERVACIONES text NULL,
	REFMEDICO int NULL,
	FECHAEMISION datetime NULL,
	MEDICO varchar(60) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_ASISTENCIAS ON
GO
IF EXISTS(SELECT * FROM dbo.ASISTENCIAS)
	 EXEC('INSERT INTO dbo.Tmp_ASISTENCIAS (IDASISTENCIA, REFPARTE, FECHAACCIDENTE, FECHAASISTENCIA, OBSERVACIONES, REFMEDICO, FECHAEMISION, MEDICO)
		SELECT IDASISTENCIA, REFPARTE, FECHAACCIDENTE, FECHAASISTENCIA, OBSERVACIONES, REFMEDICO, FECHAEMISION, MEDICO FROM dbo.ASISTENCIAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ASISTENCIAS OFF
GO
DROP TABLE dbo.ASISTENCIAS
GO
EXECUTE sp_rename N'dbo.Tmp_ASISTENCIAS', N'ASISTENCIAS', 'OBJECT' 
GO
ALTER TABLE dbo.ASISTENCIAS ADD CONSTRAINT
	PK_ASISTENCIAS PRIMARY KEY CLUSTERED 
	(
	IDASISTENCIA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ASISTENCIAS ADD CONSTRAINT
	fkasistenciasmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT


PRINT 'CAMBIAR COLLATION DE TABLA N_ARTICULOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT FK_N_Articulos_N_Proveedores
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT FK_N_Articulos_N_TipoIVA
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT FK_N_Articulos_N_Familias
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT FK_N_Articulos_N_Articulos_Tipo
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT DF_N_Articulos_ID_TipoArticulo
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT DF_N_Articulos_PrecioCompra
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT DF_N_Articulos_FechaAltaArticulo
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT DF_N_Articulos_NoImprimirArticuloListado
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT DF_N_Articulos_ID_ArticuloConcatenado
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT DF_N_Articulos_EsArticuloCompuesto
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT DF_N_Articulos_EsEstocable
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT DF_N_Articulos_PrecioVentaRecomendado
GO
CREATE TABLE dbo.Tmp_N_Articulos
	(
	ID_Articulo bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(13) NOT NULL,
	CodigoEAN nvarchar(50) NULL,
	ID_TipoArticulo int NOT NULL,
	Equivalente nvarchar(50) NULL,
	CodigoCorto int NULL,
	ID_Familia int NULL,
	DescripcionGeneral nvarchar(200) NULL,
	DescripcionEtiquetas nvarchar(200) NULL,
	DescripcionTickets nvarchar(200) NULL,
	DescripcionLarga nvarchar(500) NULL,
	ID_TipoIVA int NULL,
	ID_ProveedorHabitual int NULL,
	Referencia nvarchar(50) NULL,
	ID_Fabricante int NULL,
	PrecioCompra float(53) NULL,
	Descuento1 float(53) NULL,
	Descuento2 float(53) NULL,
	Descuento3 nchar(10) NULL,
	FechaAltaArticulo datetime NULL,
	MaximoDescuentoAplicable float(53) NULL,
	ID_Tallaje int NULL,
	UbicacionEnAlmacen nvarchar(50) NULL,
	UnidadesLinea int NULL,
	UnidadesPorPalets int NULL,
	Dimensiones nvarchar(50) NULL,
	NoPermitirUtilzarArticulo bit NULL,
	NoImprimirArticuloListado bit NULL,
	DesactivarMensajesParaEsteArticulo bit NULL,
	ID_ArticuloConcatenado int NULL,
	ReferenciaDelProveedor nchar(10) NULL,
	ImportePortesPorUnid float(53) NULL,
	NumeroCuentaVentas nvarchar(50) NULL,
	NumeroCuentaCompras nvarchar(50) NULL,
	Imagen image NULL,
	FechaUltimaModif datetime NULL,
	PesoArticulo float(53) NULL,
	GarantiaArticulo nvarchar(200) NULL,
	MensajeEmergente nvarchar(50) NULL,
	EsArticuloCompuesto bit NULL,
	EsEstocable bit NULL,
	PrecioVentaRecomendado float(53) NOT NULL,
	Favorito int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Articulos ADD CONSTRAINT
	DF_N_Articulos_ID_TipoArticulo DEFAULT ((1)) FOR ID_TipoArticulo
GO
ALTER TABLE dbo.Tmp_N_Articulos ADD CONSTRAINT
	DF_N_Articulos_PrecioCompra DEFAULT ((0)) FOR PrecioCompra
GO
ALTER TABLE dbo.Tmp_N_Articulos ADD CONSTRAINT
	DF_N_Articulos_FechaAltaArticulo DEFAULT (getdate()) FOR FechaAltaArticulo
GO
ALTER TABLE dbo.Tmp_N_Articulos ADD CONSTRAINT
	DF_N_Articulos_NoImprimirArticuloListado DEFAULT ((0)) FOR NoImprimirArticuloListado
GO
ALTER TABLE dbo.Tmp_N_Articulos ADD CONSTRAINT
	DF_N_Articulos_ID_ArticuloConcatenado DEFAULT ((0)) FOR ID_ArticuloConcatenado
GO
ALTER TABLE dbo.Tmp_N_Articulos ADD CONSTRAINT
	DF_N_Articulos_EsArticuloCompuesto DEFAULT ((0)) FOR EsArticuloCompuesto
GO
ALTER TABLE dbo.Tmp_N_Articulos ADD CONSTRAINT
	DF_N_Articulos_EsEstocable DEFAULT ((1)) FOR EsEstocable
GO
ALTER TABLE dbo.Tmp_N_Articulos ADD CONSTRAINT
	DF_N_Articulos_PrecioVentaRecomendado DEFAULT ((0)) FOR PrecioVentaRecomendado
GO
SET IDENTITY_INSERT dbo.Tmp_N_Articulos ON
GO
IF EXISTS(SELECT * FROM dbo.N_Articulos)
	 EXEC('INSERT INTO dbo.Tmp_N_Articulos (ID_Articulo, Codigo, CodigoEAN, ID_TipoArticulo, Equivalente, CodigoCorto, ID_Familia, DescripcionGeneral, DescripcionEtiquetas, DescripcionTickets, DescripcionLarga, ID_TipoIVA, ID_ProveedorHabitual, Referencia, ID_Fabricante, PrecioCompra, Descuento1, Descuento2, Descuento3, FechaAltaArticulo, MaximoDescuentoAplicable, ID_Tallaje, UbicacionEnAlmacen, UnidadesLinea, UnidadesPorPalets, Dimensiones, NoPermitirUtilzarArticulo, NoImprimirArticuloListado, DesactivarMensajesParaEsteArticulo, ID_ArticuloConcatenado, ReferenciaDelProveedor, ImportePortesPorUnid, NumeroCuentaVentas, NumeroCuentaCompras, Imagen, FechaUltimaModif, PesoArticulo, GarantiaArticulo, MensajeEmergente, EsArticuloCompuesto, EsEstocable, PrecioVentaRecomendado, Favorito)
		SELECT ID_Articulo, Codigo, CodigoEAN, ID_TipoArticulo, Equivalente, CodigoCorto, ID_Familia, DescripcionGeneral, DescripcionEtiquetas, DescripcionTickets, DescripcionLarga, ID_TipoIVA, ID_ProveedorHabitual, Referencia, ID_Fabricante, PrecioCompra, Descuento1, Descuento2, Descuento3, FechaAltaArticulo, MaximoDescuentoAplicable, ID_Tallaje, UbicacionEnAlmacen, UnidadesLinea, UnidadesPorPalets, Dimensiones, NoPermitirUtilzarArticulo, NoImprimirArticuloListado, DesactivarMensajesParaEsteArticulo, ID_ArticuloConcatenado, ReferenciaDelProveedor, ImportePortesPorUnid, NumeroCuentaVentas, NumeroCuentaCompras, Imagen, FechaUltimaModif, PesoArticulo, GarantiaArticulo, MensajeEmergente, EsArticuloCompuesto, EsEstocable, PrecioVentaRecomendado, Favorito FROM dbo.N_Articulos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Articulos OFF
GO
ALTER TABLE dbo.N_Articulos_Proveedores
	DROP CONSTRAINT FK_N_Articulos_Proveedores_N_Articulos
GO
ALTER TABLE dbo.N_Articulos_ConsolidacionStock
	DROP CONSTRAINT FK_N_Articulos_ConsolidacionStock_N_Articulos
GO
ALTER TABLE dbo.N_Articulos_Almacen
	DROP CONSTRAINT FK_N_Articulos_Almacen_N_Articulos
GO
DROP TABLE dbo.N_Articulos
GO
EXECUTE sp_rename N'dbo.Tmp_N_Articulos', N'N_Articulos', 'OBJECT' 
GO
ALTER TABLE dbo.N_Articulos ADD CONSTRAINT
	PK_N_Articulos PRIMARY KEY CLUSTERED 
	(
	ID_Articulo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Articulos ADD CONSTRAINT
	FK_N_Articulos_N_Articulos_Tipo FOREIGN KEY
	(
	ID_TipoArticulo
	) REFERENCES dbo.N_Articulos_Tipo
	(
	ID_TipoArticulo
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Articulos ADD CONSTRAINT
	FK_N_Articulos_N_Familias FOREIGN KEY
	(
	ID_Familia
	) REFERENCES dbo.N_Familias
	(
	ID_Familia
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Articulos ADD CONSTRAINT
	FK_N_Articulos_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Articulos ADD CONSTRAINT
	FK_N_Articulos_N_Proveedores FOREIGN KEY
	(
	ID_ProveedorHabitual
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos_Almacen ADD CONSTRAINT
	FK_N_Articulos_Almacen_N_Articulos FOREIGN KEY
	(
	ID_Articulo
	) REFERENCES dbo.N_Articulos
	(
	ID_Articulo
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos_ConsolidacionStock ADD CONSTRAINT
	FK_N_Articulos_ConsolidacionStock_N_Articulos FOREIGN KEY
	(
	ID_Articulo
	) REFERENCES dbo.N_Articulos
	(
	ID_Articulo
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos_Proveedores ADD CONSTRAINT
	FK_N_Articulos_Proveedores_N_Articulos FOREIGN KEY
	(
	ID_Articulo
	) REFERENCES dbo.N_Articulos
	(
	ID_Articulo
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLANTION DE AUDIOMETRIAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT fk_audiometrias
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OD250__7E6CC920
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OD500__7F60ED59
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OD100__00551192
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OD200__014935CB
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OD300__023D5A04
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OD400__03317E3D
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OD600__0425A276
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OD800__0519C6AF
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OI800__060DEAE8
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OI250__07020F21
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OI500__07F6335A
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OI100__08EA5793
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OI200__09DE7BCC
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OI300__0AD2A005
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OI400__0BC6C43E
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT DF__AUDIOMETR__OI600__0CBAE877
GO
CREATE TABLE dbo.Tmp_AUDIOMETRIAS
	(
	CODIGO int NOT NULL,
	REFPACIENTE int NOT NULL,
	OD250 real NOT NULL,
	OD500 real NOT NULL,
	OD1000 real NOT NULL,
	OD2000 real NOT NULL,
	OD3000 real NOT NULL,
	OD4000 real NOT NULL,
	OD6000 real NOT NULL,
	OD8000 real NOT NULL,
	OI8000 real NOT NULL,
	OI250 real NOT NULL,
	OI500 real NOT NULL,
	OI1000 real NOT NULL,
	OI2000 real NOT NULL,
	OI3000 real NOT NULL,
	OI4000 real NOT NULL,
	OI6000 real NOT NULL,
	FECHA datetime NULL,
	NOTAS text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OD250__7E6CC920 DEFAULT ((0)) FOR OD250
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OD500__7F60ED59 DEFAULT ((0)) FOR OD500
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OD100__00551192 DEFAULT ((0)) FOR OD1000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OD200__014935CB DEFAULT ((0)) FOR OD2000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OD300__023D5A04 DEFAULT ((0)) FOR OD3000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OD400__03317E3D DEFAULT ((0)) FOR OD4000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OD600__0425A276 DEFAULT ((0)) FOR OD6000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OD800__0519C6AF DEFAULT ((0)) FOR OD8000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OI800__060DEAE8 DEFAULT ((0)) FOR OI8000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OI250__07020F21 DEFAULT ((0)) FOR OI250
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OI500__07F6335A DEFAULT ((0)) FOR OI500
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OI100__08EA5793 DEFAULT ((0)) FOR OI1000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OI200__09DE7BCC DEFAULT ((0)) FOR OI2000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OI300__0AD2A005 DEFAULT ((0)) FOR OI3000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OI400__0BC6C43E DEFAULT ((0)) FOR OI4000
GO
ALTER TABLE dbo.Tmp_AUDIOMETRIAS ADD CONSTRAINT
	DF__AUDIOMETR__OI600__0CBAE877 DEFAULT ((0)) FOR OI6000
GO
IF EXISTS(SELECT * FROM dbo.AUDIOMETRIAS)
	 EXEC('INSERT INTO dbo.Tmp_AUDIOMETRIAS (CODIGO, REFPACIENTE, OD250, OD500, OD1000, OD2000, OD3000, OD4000, OD6000, OD8000, OI8000, OI250, OI500, OI1000, OI2000, OI3000, OI4000, OI6000, FECHA, NOTAS)
		SELECT CODIGO, REFPACIENTE, OD250, OD500, OD1000, OD2000, OD3000, OD4000, OD6000, OD8000, OI8000, OI250, OI500, OI1000, OI2000, OI3000, OI4000, OI6000, FECHA, NOTAS FROM dbo.AUDIOMETRIAS WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.AUDIOMETRIAS
GO
EXECUTE sp_rename N'dbo.Tmp_AUDIOMETRIAS', N'AUDIOMETRIAS', 'OBJECT' 
GO
ALTER TABLE dbo.AUDIOMETRIAS ADD CONSTRAINT
	PK_AUDIOMETRIAS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.AUDIOMETRIAS ADD CONSTRAINT
	fk_audiometrias FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATION DE N_FACTURA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
	DROP CONSTRAINT FK_N_Factura_EntregasCuenta
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
	DROP CONSTRAINT FK_N_Factura_N_Factura_Tipos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT FK_N_Factura_FormasPago
GO
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
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT DF_N_Factura_PagadoConCredito
GO
CREATE TABLE dbo.Tmp_N_Factura
	(
	ID_Factura bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	ID_TipoFactura int NULL,
	Referencia nvarchar(50) NULL,
	Fecha datetime NULL,
	ID_Estado int NULL,
	ID_Cliente int NULL,
	ID_FormaPago varchar(10) NULL,
	IRPFPorciento float(53) NULL,
	IRPFCantidad float(53) NULL,
	Total float(53) NULL,
	Observaciones nvarchar(200) NULL,
	PlazoEntrega datetime NULL,
	Validez nvarchar(50) NULL,
	PortePagado bit NULL,
	PorteDebido bit NULL,
	PorteTexto nvarchar(50) NULL,
	Privado nvarchar(200) NULL,
	DocumentacionAsociada nvarchar(200) NULL,
	Comentarios nvarchar(200) NULL,
	Imagen image NULL,
	Pagado bit NULL,
	FechaPagado datetime NULL,
	IDEntregaCuenta bigint NULL,
	PagadoConCredito bit NULL
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
ALTER TABLE dbo.Tmp_N_Factura ADD CONSTRAINT
	DF_N_Factura_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
SET IDENTITY_INSERT dbo.Tmp_N_Factura ON
GO
IF EXISTS(SELECT * FROM dbo.N_Factura)
	 EXEC('INSERT INTO dbo.Tmp_N_Factura (ID_Factura, Codigo, ID_TipoFactura, Referencia, Fecha, ID_Estado, ID_Cliente, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, Pagado, FechaPagado, IDEntregaCuenta, PagadoConCredito)
		SELECT ID_Factura, Codigo, ID_TipoFactura, Referencia, Fecha, ID_Estado, ID_Cliente, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, Pagado, FechaPagado, IDEntregaCuenta, PagadoConCredito FROM dbo.N_Factura WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Factura OFF
GO
ALTER TABLE dbo.N_Factura_Totales
	DROP CONSTRAINT FK_N_Factura_Totales_N_Factura
GO
ALTER TABLE dbo.N_Factura_Lineas
	DROP CONSTRAINT FK_N_Factura_Lineas_N_Factura
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
ALTER TABLE dbo.N_Factura ADD CONSTRAINT
	FK_N_Factura_N_Pacientes FOREIGN KEY
	(
	ID_Cliente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Factura ADD CONSTRAINT
	FK_N_Factura_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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

PRINT 'CAMBIAR COLLATION EN BAJAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.BAJAS
	DROP CONSTRAINT fkbajasmedico
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_BAJAS
	(
	IDBAJA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPARTE int NULL,
	CAUSA varchar(2) NULL,
	GRAVEDAD varchar(1) NULL,
	RECAIDA varchar(1) NULL,
	FECHAAT datetime NULL,
	FECHABAJA datetime NULL,
	DIAGNOSTICO text NULL,
	CIE9MC varchar(5) NULL,
	EMISION datetime NULL,
	REFMEDICO int NULL,
	MEDICO varchar(50) NULL,
	LIMITECF varchar(150) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_BAJAS ON
GO
IF EXISTS(SELECT * FROM dbo.BAJAS)
	 EXEC('INSERT INTO dbo.Tmp_BAJAS (IDBAJA, REFPARTE, CAUSA, GRAVEDAD, RECAIDA, FECHAAT, FECHABAJA, DIAGNOSTICO, CIE9MC, EMISION, REFMEDICO, MEDICO, LIMITECF)
		SELECT IDBAJA, REFPARTE, CAUSA, GRAVEDAD, RECAIDA, FECHAAT, FECHABAJA, DIAGNOSTICO, CIE9MC, EMISION, REFMEDICO, MEDICO, LIMITECF FROM dbo.BAJAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_BAJAS OFF
GO
DROP TABLE dbo.BAJAS
GO
EXECUTE sp_rename N'dbo.Tmp_BAJAS', N'BAJAS', 'OBJECT' 
GO
ALTER TABLE dbo.BAJAS ADD CONSTRAINT
	PK_BAJAS PRIMARY KEY CLUSTERED 
	(
	IDBAJA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.BAJAS ADD CONSTRAINT
	fkbajasmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT


PRINT 'CAMBIAR COLLATION BANCOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_BANCOS
	(
	NOMBRE varchar(60) NULL,
	DIRECCION varchar(150) NULL,
	LOCALIDAD varchar(60) NULL,
	PROVINCIA varchar(60) NULL,
	CP varchar(6) NULL,
	TLFNO1 varchar(12) NULL,
	TLFNO2 varchar(12) NULL,
	FAX varchar(12) NULL,
	ENTIDAD varchar(4) NOT NULL,
	OFICINA varchar(4) NOT NULL,
	NOTAS text NULL,
	EMAIL varchar(100) NULL,
	WEB varchar(100) NULL,
	ID varchar(8) NULL,
	IdBanco int NOT NULL IDENTITY (1, 1)
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_BANCOS ON
GO
IF EXISTS(SELECT * FROM dbo.BANCOS)
	 EXEC('INSERT INTO dbo.Tmp_BANCOS (NOMBRE, DIRECCION, LOCALIDAD, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, ENTIDAD, OFICINA, NOTAS, EMAIL, WEB, ID, IdBanco)
		SELECT NOMBRE, DIRECCION, LOCALIDAD, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, ENTIDAD, OFICINA, NOTAS, EMAIL, WEB, ID, IdBanco FROM dbo.BANCOS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_BANCOS OFF
GO
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT FK_N_Proveedores_N_Bancos
GO
DROP TABLE dbo.BANCOS
GO
EXECUTE sp_rename N'dbo.Tmp_BANCOS', N'BANCOS', 'OBJECT' 
GO
ALTER TABLE dbo.BANCOS ADD CONSTRAINT
	PK_BANCOS_1 PRIMARY KEY CLUSTERED 
	(
	IdBanco
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Proveedores ADD CONSTRAINT
	FK_N_Proveedores_N_Bancos FOREIGN KEY
	(
	ID_Banco
	) REFERENCES dbo.BANCOS
	(
	IdBanco
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLANTION CITAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT FK_CITAS_EntregasCuenta
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT FK_CITAS_N_Procesos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT FK_CITAS_SALAS
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT fkmedico
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT fk_citas
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF__CITAS__CONFIRMAD__108B795B
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF__CITAS__BANCO__117F9D94
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF__CITAS__PAGADA__1273C1CD
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF__CITAS__ATENDIDO__1367E606
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF__CITAS__REFPROCED__145C0A3F
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF_CITAS_Descuento
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF_CITAS_TOTAL
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF_CITAS_TipoCita
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF_CITAS_Eliminado
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT DF_CITAS_PagadoConCredito
GO
CREATE TABLE dbo.Tmp_CITAS
	(
	IDCITA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPACIENTE int NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	CONFIRMADA varchar(1) NULL,
	NOTAS text NULL,
	REFMEDICO int NULL,
	PACIENTE varchar(60) NULL,
	IMPORTEDR decimal(18, 2) NULL,
	IMPORTECL decimal(18, 2) NULL,
	CONTINUA varchar(7) NULL,
	FALTA varchar(1) NULL,
	BANCO varchar(1) NULL,
	PAGADA varchar(1) NULL,
	REFRECIBO int NULL,
	ATENDIDO varchar(1) NULL,
	REFFRA int NULL,
	REFFORMAPAGO varchar(10) NULL,
	HORAFIN datetime NULL,
	FECHACOBRO datetime NULL,
	REFPROCEDENCIA int NULL,
	ID_Proceso bigint NULL,
	EstadoRecurrencia int NULL,
	FechaUltimoEstadoRecurrencia datetime NULL,
	Descuento float(53) NULL,
	ID_SALA int NULL,
	TOTAL decimal(18, 2) NULL,
	TipoCita int NULL,
	Eliminado bit NULL,
	IDEntregaCuenta bigint NULL,
	PagadoConCredito bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF__CITAS__CONFIRMAD__108B795B DEFAULT ('S') FOR CONFIRMADA
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF__CITAS__BANCO__117F9D94 DEFAULT ('N') FOR BANCO
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF__CITAS__PAGADA__1273C1CD DEFAULT ('N') FOR PAGADA
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF__CITAS__ATENDIDO__1367E606 DEFAULT ('N') FOR ATENDIDO
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF__CITAS__REFPROCED__145C0A3F DEFAULT ((-1)) FOR REFPROCEDENCIA
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF_CITAS_Descuento DEFAULT ((0)) FOR Descuento
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF_CITAS_TOTAL DEFAULT ((0)) FOR TOTAL
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF_CITAS_TipoCita DEFAULT ((0)) FOR TipoCita
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF_CITAS_Eliminado DEFAULT ((0)) FOR Eliminado
GO
ALTER TABLE dbo.Tmp_CITAS ADD CONSTRAINT
	DF_CITAS_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
SET IDENTITY_INSERT dbo.Tmp_CITAS ON
GO
IF EXISTS(SELECT * FROM dbo.CITAS)
	 EXEC('INSERT INTO dbo.Tmp_CITAS (IDCITA, REFPACIENTE, FECHA, HORA, CONFIRMADA, NOTAS, REFMEDICO, PACIENTE, IMPORTEDR, IMPORTECL, CONTINUA, FALTA, BANCO, PAGADA, REFRECIBO, ATENDIDO, REFFRA, REFFORMAPAGO, HORAFIN, FECHACOBRO, REFPROCEDENCIA, ID_Proceso, EstadoRecurrencia, FechaUltimoEstadoRecurrencia, Descuento, ID_SALA, TOTAL, TipoCita, Eliminado, IDEntregaCuenta, PagadoConCredito)
		SELECT IDCITA, REFPACIENTE, FECHA, HORA, CONFIRMADA, NOTAS, REFMEDICO, PACIENTE, IMPORTEDR, IMPORTECL, CONTINUA, FALTA, BANCO, PAGADA, REFRECIBO, ATENDIDO, REFFRA, REFFORMAPAGO, HORAFIN, FECHACOBRO, REFPROCEDENCIA, ID_Proceso, EstadoRecurrencia, FechaUltimoEstadoRecurrencia, Descuento, ID_SALA, TOTAL, TipoCita, Eliminado, IDEntregaCuenta, PagadoConCredito FROM dbo.CITAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_CITAS OFF
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT FK_LineasCitas_Citas
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT FK_d_PresupuestoLineas_Citas
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS
	DROP CONSTRAINT FK_LCOMPARATIVAS_TRATAMIENTOS_CITAS
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT FK_LINEASFACTURAS_CITAS
GO
DROP TABLE dbo.CITAS
GO
EXECUTE sp_rename N'dbo.Tmp_CITAS', N'CITAS', 'OBJECT' 
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	PK_CITAS PRIMARY KEY CLUSTERED 
	(
	IDCITA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	fk_citas FOREIGN KEY
	(
	REFFORMAPAGO
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	fkmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	FK_CITAS_SALAS FOREIGN KEY
	(
	ID_SALA
	) REFERENCES dbo.SALAS
	(
	ID_SALA
	) ON UPDATE  CASCADE 
	 ON DELETE  SET NULL 
	
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	FK_CITAS_N_Procesos FOREIGN KEY
	(
	ID_Proceso
	) REFERENCES dbo.N_Procesos
	(
	ID_Proceso
	) ON UPDATE  CASCADE 
	 ON DELETE  SET NULL 
	
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	FK_CITAS_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	FK_LINEASFACTURAS_CITAS FOREIGN KEY
	(
	ID_Cita
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS ADD CONSTRAINT
	FK_LCOMPARATIVAS_TRATAMIENTOS_CITAS FOREIGN KEY
	(
	ID_Cita
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_PresupuestoLineas ADD CONSTRAINT
	FK_d_PresupuestoLineas_Citas FOREIGN KEY
	(
	IDCITA
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  SET NULL 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	FK_LineasCitas_Citas FOREIGN KEY
	(
	IdCita
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATION CLINICAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_CLINICAS
	(
	CODIGO varchar(12) NOT NULL,
	NOMBRE varchar(50) NULL,
	DIRECCION varchar(50) NULL,
	CP varchar(5) NULL,
	POBLACION varchar(50) NULL,
	PROVINCIA varchar(50) NULL,
	TLFNO1 varchar(50) NULL,
	TLFNO2 varchar(50) NULL,
	FAX varchar(50) NULL,
	MAIL varchar(50) NULL,
	WEB varchar(50) NULL,
	PERSONACION varchar(50) NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.CLINICAS)
	 EXEC('INSERT INTO dbo.Tmp_CLINICAS (CODIGO, NOMBRE, DIRECCION, CP, POBLACION, PROVINCIA, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACION)
		SELECT CODIGO, NOMBRE, DIRECCION, CP, POBLACION, PROVINCIA, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACION FROM dbo.CLINICAS WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.CLINICAS
GO
EXECUTE sp_rename N'dbo.Tmp_CLINICAS', N'CLINICAS', 'OBJECT' 
GO
ALTER TABLE dbo.CLINICAS ADD CONSTRAINT
	PK_CLINICAS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

PRINT 'CAMBIAR COLLATION AUDITORIAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_FechaHora
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_NombreUsuario
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_TipoDocumento
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_CodigoDocumento
GO
ALTER TABLE dbo.Auditoria
	DROP CONSTRAINT DF_Auditoria_DetallesDocumento
GO
CREATE TABLE dbo.Tmp_Auditoria
	(
	idLog bigint NOT NULL IDENTITY (1, 1),
	FechaHora datetime NOT NULL,
	idUsuario int NULL,
	NombreUsuario varchar(50) NOT NULL,
	TipoDocumento varchar(50) NOT NULL,
	CodigoDocumento varchar(50) NOT NULL,
	DetallesDocumento varchar(300) NOT NULL,
	eAccion int NOT NULL,
	eLocacion int NOT NULL,
	loginUsuario nvarchar(50) NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_FechaHora DEFAULT (getdate()) FOR FechaHora
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_NombreUsuario DEFAULT ('') FOR NombreUsuario
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_TipoDocumento DEFAULT ('') FOR TipoDocumento
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_CodigoDocumento DEFAULT ('') FOR CodigoDocumento
GO
ALTER TABLE dbo.Tmp_Auditoria ADD CONSTRAINT
	DF_Auditoria_DetallesDocumento DEFAULT ('') FOR DetallesDocumento
GO
SET IDENTITY_INSERT dbo.Tmp_Auditoria ON
GO
IF EXISTS(SELECT * FROM dbo.Auditoria)
	 EXEC('INSERT INTO dbo.Tmp_Auditoria (idLog, FechaHora, idUsuario, NombreUsuario, TipoDocumento, CodigoDocumento, DetallesDocumento, eAccion, eLocacion, loginUsuario)
		SELECT idLog, FechaHora, idUsuario, NombreUsuario, TipoDocumento, CodigoDocumento, DetallesDocumento, eAccion, eLocacion, loginUsuario FROM dbo.Auditoria WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Auditoria OFF
GO
DROP TABLE dbo.Auditoria
GO
EXECUTE sp_rename N'dbo.Tmp_Auditoria', N'Auditoria', 'OBJECT' 
GO
ALTER TABLE dbo.Auditoria ADD CONSTRAINT
	PK_Auditoria PRIMARY KEY CLUSTERED 
	(
	idLog
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

PRINT 'CAMBIO COLLATION COMPARATIVAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LCOMPARATIVAS
	DROP CONSTRAINT FK_LCOMPARATIVAS_MEDICOS
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_MODELOSCOMPARATIVA
	(
	CODIGO varchar(12) NOT NULL,
	MODELO varchar(120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	IMAGEN image NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.MODELOSCOMPARATIVA)
	 EXEC('INSERT INTO dbo.Tmp_MODELOSCOMPARATIVA (CODIGO, MODELO, IMAGEN)
		SELECT CODIGO, MODELO, IMAGEN FROM dbo.MODELOSCOMPARATIVA WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.COMPARATIVAS
	DROP CONSTRAINT fk_comparativasmodelo
GO
ALTER TABLE dbo.LCOMPARATIVAS
	DROP CONSTRAINT FK_LCOMPARATIVAS_MODELOSCOMPARATIVA
GO
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT fk_modelosdatoscomparativas
GO
DROP TABLE dbo.MODELOSCOMPARATIVA
GO
EXECUTE sp_rename N'dbo.Tmp_MODELOSCOMPARATIVA', N'MODELOSCOMPARATIVA', 'OBJECT' 
GO
ALTER TABLE dbo.MODELOSCOMPARATIVA ADD CONSTRAINT
	PK_MODELOSCOMPARATIVA PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT DF__MODELOSDA__TIPOD__4BAC3F29
GO
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT DF_MODELOSDATOS_Repetir
GO
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT DF_MODELOSDATOS_CalcDiferencia
GO
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT DF_MODELOSDATOS_OcultarEnReporte
GO
CREATE TABLE dbo.Tmp_MODELOSDATOS
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	NOMBREDATO varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	TIPODATO varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFMODELOCOMPARATIVA varchar(12) NULL,
	ORDEN int NULL,
	XMLDEF nvarchar(MAX) NULL,
	DXML xml NULL,
	Repetir bit NULL,
	CalcDiferencia bit NULL,
	OcultarEnReporte bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_MODELOSDATOS ADD CONSTRAINT
	DF__MODELOSDA__TIPOD__4BAC3F29 DEFAULT ('F') FOR TIPODATO
GO
ALTER TABLE dbo.Tmp_MODELOSDATOS ADD CONSTRAINT
	DF_MODELOSDATOS_Repetir DEFAULT ((0)) FOR Repetir
GO
ALTER TABLE dbo.Tmp_MODELOSDATOS ADD CONSTRAINT
	DF_MODELOSDATOS_CalcDiferencia DEFAULT ((0)) FOR CalcDiferencia
GO
ALTER TABLE dbo.Tmp_MODELOSDATOS ADD CONSTRAINT
	DF_MODELOSDATOS_OcultarEnReporte DEFAULT ((0)) FOR OcultarEnReporte
GO
SET IDENTITY_INSERT dbo.Tmp_MODELOSDATOS ON
GO
IF EXISTS(SELECT * FROM dbo.MODELOSDATOS)
	 EXEC('INSERT INTO dbo.Tmp_MODELOSDATOS (CODIGO, NOMBREDATO, TIPODATO, REFMODELOCOMPARATIVA, ORDEN, XMLDEF, DXML, Repetir, CalcDiferencia, OcultarEnReporte)
		SELECT CODIGO, NOMBREDATO, TIPODATO, REFMODELOCOMPARATIVA, ORDEN, XMLDEF, DXML, Repetir, CalcDiferencia, OcultarEnReporte FROM dbo.MODELOSDATOS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_MODELOSDATOS OFF
GO
ALTER TABLE dbo.DATOSCOMPARATIVA
	DROP CONSTRAINT fk_datoscomparativamodelodato
GO
DROP TABLE dbo.MODELOSDATOS
GO
EXECUTE sp_rename N'dbo.Tmp_MODELOSDATOS', N'MODELOSDATOS', 'OBJECT' 
GO
ALTER TABLE dbo.MODELOSDATOS ADD CONSTRAINT
	PK_MODELOSDATOS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.MODELOSDATOS ADD CONSTRAINT
	fk_modelosdatoscomparativas FOREIGN KEY
	(
	REFMODELOCOMPARATIVA
	) REFERENCES dbo.MODELOSCOMPARATIVA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_LCOMPARATIVAS
	(
	ID int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFCOMPARATIVA int NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	REFMODELOCOMPARATIVA varchar(12) NULL,
	DESCRIPCION varchar(90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NOTAS text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFMEDICO int NULL,
	NOMBREMEDICO nvarchar(50) NULL,
	ESPECIALIDAD nvarchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_LCOMPARATIVAS ON
GO
IF EXISTS(SELECT * FROM dbo.LCOMPARATIVAS)
	 EXEC('INSERT INTO dbo.Tmp_LCOMPARATIVAS (ID, REFCOMPARATIVA, FECHA, HORA, REFMODELOCOMPARATIVA, DESCRIPCION, NOTAS, REFMEDICO, NOMBREMEDICO, ESPECIALIDAD)
		SELECT ID, REFCOMPARATIVA, FECHA, HORA, REFMODELOCOMPARATIVA, DESCRIPCION, NOTAS, REFMEDICO, NOMBREMEDICO, ESPECIALIDAD FROM dbo.LCOMPARATIVAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LCOMPARATIVAS OFF
GO
ALTER TABLE dbo.DATOSCOMPARATIVA
	DROP CONSTRAINT fk_datoscomparativalcomparativa
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS
	DROP CONSTRAINT FK_LCOMPARATIVAS_TRATAMIENTOS_LCOMPARATIVAS
GO
DROP TABLE dbo.LCOMPARATIVAS
GO
EXECUTE sp_rename N'dbo.Tmp_LCOMPARATIVAS', N'LCOMPARATIVAS', 'OBJECT' 
GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	PK_LCOMPARATIVAS PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	FK_LCOMPARATIVAS_MODELOSCOMPARATIVA FOREIGN KEY
	(
	REFMODELOCOMPARATIVA
	) REFERENCES dbo.MODELOSCOMPARATIVA
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	FK_LCOMPARATIVAS_MEDICOS FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS ADD CONSTRAINT
	FK_LCOMPARATIVAS_TRATAMIENTOS_LCOMPARATIVAS FOREIGN KEY
	(
	ID_LCOMPARATIVA
	) REFERENCES dbo.LCOMPARATIVAS
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DATOSCOMPARATIVA ADD CONSTRAINT
	fk_datoscomparativalcomparativa FOREIGN KEY
	(
	REFLCOMPARATIVA
	) REFERENCES dbo.LCOMPARATIVAS
	(
	ID
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.DATOSCOMPARATIVA ADD CONSTRAINT
	fk_datoscomparativamodelodato FOREIGN KEY
	(
	REFMODELODATO
	) REFERENCES dbo.MODELOSDATOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.COMPARATIVAS
	DROP CONSTRAINT fk_comparativaspaciente
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_COMPARATIVAS
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPACIENTE int NULL,
	DESCRIPCION varchar(100) NULL,
	FECHA datetime NULL,
	NOTAS text NULL,
	REFMODELOCOMPARATIVA varchar(12) NULL,
	FECHATERMINADA datetime NULL,
	IMAGEN varbinary(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_COMPARATIVAS ON
GO
IF EXISTS(SELECT * FROM dbo.COMPARATIVAS)
	 EXEC('INSERT INTO dbo.Tmp_COMPARATIVAS (CODIGO, REFPACIENTE, DESCRIPCION, FECHA, NOTAS, REFMODELOCOMPARATIVA, FECHATERMINADA, IMAGEN)
		SELECT CODIGO, REFPACIENTE, DESCRIPCION, FECHA, NOTAS, REFMODELOCOMPARATIVA, FECHATERMINADA, IMAGEN FROM dbo.COMPARATIVAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_COMPARATIVAS OFF
GO
DROP TABLE dbo.COMPARATIVAS
GO
EXECUTE sp_rename N'dbo.Tmp_COMPARATIVAS', N'COMPARATIVAS', 'OBJECT' 
GO
ALTER TABLE dbo.COMPARATIVAS ADD CONSTRAINT
	PK_COMPARATIVAS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.COMPARATIVAS ADD CONSTRAINT
	fk_comparativaspaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.COMPARATIVAS ADD CONSTRAINT
	fk_comparativasmodelo FOREIGN KEY
	(
	REFMODELOCOMPARATIVA
	) REFERENCES dbo.MODELOSCOMPARATIVA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATION EN CONTACTOS PACIENTES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Nombre
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Apellidos
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Direccion
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Localidad
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_CP
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Pais
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Telefono
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Movil
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Fax
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Email
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Parentesco
GO
ALTER TABLE dbo.ContactosPacientes
	DROP CONSTRAINT DF_ContactosPacientes_Notas
GO
CREATE TABLE dbo.Tmp_ContactosPacientes
	(
	IdContacto int NOT NULL IDENTITY (1, 1),
	CPaciente int NOT NULL,
	Nombre varchar(50) NOT NULL,
	Apellidos varchar(50) NOT NULL,
	Direccion varchar(150) NOT NULL,
	Localidad varchar(150) NOT NULL,
	CP varchar(10) NOT NULL,
	Pais varchar(100) NOT NULL,
	Telefono varchar(50) NOT NULL,
	Movil varchar(50) NOT NULL,
	Fax varchar(50) NOT NULL,
	Email varchar(50) NOT NULL,
	Parentesco varchar(150) NOT NULL,
	Notas text NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Nombre DEFAULT ('') FOR Nombre
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Apellidos DEFAULT ('') FOR Apellidos
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Direccion DEFAULT ('') FOR Direccion
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Localidad DEFAULT ('') FOR Localidad
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_CP DEFAULT ('') FOR CP
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Pais DEFAULT ('') FOR Pais
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Telefono DEFAULT ('') FOR Telefono
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Movil DEFAULT ('') FOR Movil
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Fax DEFAULT ('') FOR Fax
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Email DEFAULT ('') FOR Email
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Parentesco DEFAULT ('') FOR Parentesco
GO
ALTER TABLE dbo.Tmp_ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Notas DEFAULT ('') FOR Notas
GO
SET IDENTITY_INSERT dbo.Tmp_ContactosPacientes ON
GO
IF EXISTS(SELECT * FROM dbo.ContactosPacientes)
	 EXEC('INSERT INTO dbo.Tmp_ContactosPacientes (IdContacto, CPaciente, Nombre, Apellidos, Direccion, Localidad, CP, Pais, Telefono, Movil, Fax, Email, Parentesco, Notas)
		SELECT IdContacto, CPaciente, Nombre, Apellidos, Direccion, Localidad, CP, Pais, Telefono, Movil, Fax, Email, Parentesco, Notas FROM dbo.ContactosPacientes WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ContactosPacientes OFF
GO
DROP TABLE dbo.ContactosPacientes
GO
EXECUTE sp_rename N'dbo.Tmp_ContactosPacientes', N'ContactosPacientes', 'OBJECT' 
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	PK_ContactosPacientes PRIMARY KEY CLUSTERED 
	(
	IdContacto,
	CPaciente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

PRINT 'CAMBIOS COLLATION CONCEPTOSANALITICAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.CONCEPTOSANALITICA
	DROP CONSTRAINT DF__CONCEPTOS__IMPOR__173876EA
GO
CREATE TABLE dbo.Tmp_CONCEPTOSANALITICA
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	CONCEPTO varchar(90) NULL,
	IMPORTE real NOT NULL,
	NOTAS text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_CONCEPTOSANALITICA ADD CONSTRAINT
	DF__CONCEPTOS__IMPOR__173876EA DEFAULT ((0)) FOR IMPORTE
GO
SET IDENTITY_INSERT dbo.Tmp_CONCEPTOSANALITICA ON
GO
IF EXISTS(SELECT * FROM dbo.CONCEPTOSANALITICA)
	 EXEC('INSERT INTO dbo.Tmp_CONCEPTOSANALITICA (CODIGO, CONCEPTO, IMPORTE, NOTAS)
		SELECT CODIGO, CONCEPTO, IMPORTE, NOTAS FROM dbo.CONCEPTOSANALITICA WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_CONCEPTOSANALITICA OFF
GO
DROP TABLE dbo.CONCEPTOSANALITICA
GO
EXECUTE sp_rename N'dbo.Tmp_CONCEPTOSANALITICA', N'CONCEPTOSANALITICA', 'OBJECT' 
GO
ALTER TABLE dbo.CONCEPTOSANALITICA ADD CONSTRAINT
	PK_CONCEPTOSANALITICA PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT


PRINT 'CAMBIO COLLATION CONCEPTOSFACTURABLES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.CONCEPTOSFACTURABLES
	DROP CONSTRAINT DF__CONCEPTOS__IMPOR__1920BF5C
GO
CREATE TABLE dbo.Tmp_CONCEPTOSFACTURABLES
	(
	ID int NOT NULL IDENTITY (1, 1),
	REFPACIENTE int NULL,
	REFCONCEPTO varchar(10) NULL,
	DESCRIPCION varchar(150) NULL,
	IMPORTE real NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_CONCEPTOSFACTURABLES ADD CONSTRAINT
	DF__CONCEPTOS__IMPOR__1920BF5C DEFAULT ((0)) FOR IMPORTE
GO
SET IDENTITY_INSERT dbo.Tmp_CONCEPTOSFACTURABLES ON
GO
IF EXISTS(SELECT * FROM dbo.CONCEPTOSFACTURABLES)
	 EXEC('INSERT INTO dbo.Tmp_CONCEPTOSFACTURABLES (ID, REFPACIENTE, REFCONCEPTO, DESCRIPCION, IMPORTE)
		SELECT ID, REFPACIENTE, REFCONCEPTO, DESCRIPCION, IMPORTE FROM dbo.CONCEPTOSFACTURABLES WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_CONCEPTOSFACTURABLES OFF
GO
DROP TABLE dbo.CONCEPTOSFACTURABLES
GO
EXECUTE sp_rename N'dbo.Tmp_CONCEPTOSFACTURABLES', N'CONCEPTOSFACTURABLES', 'OBJECT' 
GO
ALTER TABLE dbo.CONCEPTOSFACTURABLES ADD CONSTRAINT
	PK_CONCEPTOSFACTURABLES PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

PRINT 'CAMBIAR COLLATION EN CONCEPTOSFRA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LPRESUPUESTOS
	DROP CONSTRAINT fklpresupuestopresupuesto
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ANALITICAS
	DROP CONSTRAINT fk_analiticapaciente
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT fklineasfacturas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT FK_LINEASFACTURAS_CITAS
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT FK_d_PresupuestoLineas_Citas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT FK_d_PresupuestoLineas_d_Presupuesto
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_Acciones
	DROP CONSTRAINT FK_d_Acciones_d_Odontogramas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_Acciones
	DROP CONSTRAINT FK_d_Acciones_d_Acciones
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_ConceptosFra_Imagenes
	DROP CONSTRAINT FK_Imagenes_ConceptosFra_Imagenes
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_CONCEPTOSFRA
	(
	CODIGO varchar(10) NOT NULL,
	DESCRIPCION varchar(150) NOT NULL,
	IMPORTE real NOT NULL,
	Duracion datetime NULL,
	IDFAMILIA int NULL,
	XMLCont nvarchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.CONCEPTOSFRA)
	 EXEC('INSERT INTO dbo.Tmp_CONCEPTOSFRA (CODIGO, DESCRIPCION, IMPORTE, Duracion, IDFAMILIA, XMLCont)
		SELECT CODIGO, DESCRIPCION, IMPORTE, Duracion, IDFAMILIA, XMLCont FROM dbo.CONCEPTOSFRA WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.d_ConceptosFra_Imagenes
	DROP CONSTRAINT FK_CONCEPTOSFRA_ConceptosFra_Imagenes
GO
ALTER TABLE dbo.Tarifas
	DROP CONSTRAINT FK_Tarifas_CONCEPTOSFRA
GO
ALTER TABLE dbo.d_Acciones
	DROP CONSTRAINT FK_d_Acciones_CONCEPTOSFRA
GO
ALTER TABLE dbo.PLANTILLAANALITICAS
	DROP CONSTRAINT FK_PLANTILLAANALITICAS_CONCEPTOSFRA
GO
ALTER TABLE dbo.ANALITICAS
	DROP CONSTRAINT FK_ANALITICAS_CONCEPTOSFRA
GO
ALTER TABLE dbo.LPRESUPUESTOS
	DROP CONSTRAINT fklpresupuestoconcepto
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT fk_lineasfacturas
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT FK_d_PresupuestoLineas_CONCEPTOSFRA
GO
DROP TABLE dbo.CONCEPTOSFRA
GO
EXECUTE sp_rename N'dbo.Tmp_CONCEPTOSFRA', N'CONCEPTOSFRA', 'OBJECT' 
GO
ALTER TABLE dbo.CONCEPTOSFRA ADD CONSTRAINT
	PK_CONCEPTOSFRA PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LPRESUPUESTOS
	DROP CONSTRAINT DF__LPRESUPUE__CANTI__45F365D3
GO
CREATE TABLE dbo.Tmp_LPRESUPUESTOS
	(
	IDPRESUPUESTO int NOT NULL,
	CONCEPTO varchar(90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	IMPORTE decimal(18, 2) NULL,
	REFPRESUPUESTO int NOT NULL,
	REFCONCEPTO varchar(10) NULL,
	CANTIDAD real NOT NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_LPRESUPUESTOS ADD CONSTRAINT
	DF__LPRESUPUE__CANTI__45F365D3 DEFAULT ((1)) FOR CANTIDAD
GO
IF EXISTS(SELECT * FROM dbo.LPRESUPUESTOS)
	 EXEC('INSERT INTO dbo.Tmp_LPRESUPUESTOS (IDPRESUPUESTO, CONCEPTO, IMPORTE, REFPRESUPUESTO, REFCONCEPTO, CANTIDAD)
		SELECT IDPRESUPUESTO, CONCEPTO, IMPORTE, REFPRESUPUESTO, REFCONCEPTO, CANTIDAD FROM dbo.LPRESUPUESTOS WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.LPRESUPUESTOS
GO
EXECUTE sp_rename N'dbo.Tmp_LPRESUPUESTOS', N'LPRESUPUESTOS', 'OBJECT' 
GO
ALTER TABLE dbo.LPRESUPUESTOS ADD CONSTRAINT
	PK_LPRESUPUESTOS PRIMARY KEY CLUSTERED 
	(
	IDPRESUPUESTO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LPRESUPUESTOS ADD CONSTRAINT
	fklpresupuestopresupuesto FOREIGN KEY
	(
	REFPRESUPUESTO
	) REFERENCES dbo.PRESUPUESTOS
	(
	NUMERO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LPRESUPUESTOS ADD CONSTRAINT
	fklpresupuestoconcepto FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ANALITICAS
	DROP CONSTRAINT DF__ANALITICA__IMPOR__79A81403
GO
CREATE TABLE dbo.Tmp_ANALITICAS
	(
	NUMERO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	DESCRIPCION varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	IMPORTE real NULL,
	REFPACIENTE int NULL,
	PACIENTE varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ESTADO varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	FECHA datetime NULL,
	NOTAS text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFFRA int NULL,
	REFCONCEPTO varchar(10) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_ANALITICAS ADD CONSTRAINT
	DF__ANALITICA__IMPOR__79A81403 DEFAULT ((0)) FOR IMPORTE
GO
SET IDENTITY_INSERT dbo.Tmp_ANALITICAS ON
GO
IF EXISTS(SELECT * FROM dbo.ANALITICAS)
	 EXEC('INSERT INTO dbo.Tmp_ANALITICAS (NUMERO, DESCRIPCION, IMPORTE, REFPACIENTE, PACIENTE, ESTADO, FECHA, NOTAS, REFFRA, REFCONCEPTO)
		SELECT NUMERO, DESCRIPCION, IMPORTE, REFPACIENTE, PACIENTE, ESTADO, FECHA, NOTAS, REFFRA, REFCONCEPTO FROM dbo.ANALITICAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ANALITICAS OFF
GO
ALTER TABLE dbo.LINEASANALITICAS
	DROP CONSTRAINT fk_lineasanaliticas
GO
DROP TABLE dbo.ANALITICAS
GO
EXECUTE sp_rename N'dbo.Tmp_ANALITICAS', N'ANALITICAS', 'OBJECT' 
GO
ALTER TABLE dbo.ANALITICAS ADD CONSTRAINT
	PK_ANALITICAS PRIMARY KEY CLUSTERED 
	(
	NUMERO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ANALITICAS ADD CONSTRAINT
	fk_analiticapaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ANALITICAS ADD CONSTRAINT
	FK_ANALITICAS_CONCEPTOSFRA FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASANALITICAS ADD CONSTRAINT
	fk_lineasanaliticas FOREIGN KEY
	(
	REFANALITICA
	) REFERENCES dbo.ANALITICAS
	(
	NUMERO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_PLANTILLAANALITICAS
	(
	CODIGO varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DESCRIPCION varchar(90) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	REFCONCEPTO varchar(10) NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.PLANTILLAANALITICAS)
	 EXEC('INSERT INTO dbo.Tmp_PLANTILLAANALITICAS (CODIGO, DESCRIPCION, REFCONCEPTO)
		SELECT CODIGO, DESCRIPCION, REFCONCEPTO FROM dbo.PLANTILLAANALITICAS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.LPLANTILLAANALITICAS
	DROP CONSTRAINT fk_lplantillaplantilla
GO
DROP TABLE dbo.PLANTILLAANALITICAS
GO
EXECUTE sp_rename N'dbo.Tmp_PLANTILLAANALITICAS', N'PLANTILLAANALITICAS', 'OBJECT' 
GO
ALTER TABLE dbo.PLANTILLAANALITICAS ADD CONSTRAINT
	PK_PLANTILLAANALITICAS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.PLANTILLAANALITICAS ADD CONSTRAINT
	FK_PLANTILLAANALITICAS_CONCEPTOSFRA FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LPLANTILLAANALITICAS ADD CONSTRAINT
	fk_lplantillaplantilla FOREIGN KEY
	(
	REFPLANTILLA
	) REFERENCES dbo.PLANTILLAANALITICAS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_Acciones
	DROP CONSTRAINT DF_d_Acciones_IDGabinete
GO
ALTER TABLE dbo.d_Acciones
	DROP CONSTRAINT DF_d_Acciones_Urgente
GO
CREATE TABLE dbo.Tmp_d_Acciones
	(
	IDOdontograma int NULL,
	FechaEjecucion datetime NULL,
	IDMedico int NULL,
	DescripcionGenerada nvarchar(250) NULL,
	IDGabinete int NULL,
	IDTratamiento varchar(10) NULL,
	Cuadrantes nvarchar(50) NULL,
	PiezasInvolucradas nvarchar(50) NULL,
	Urgente int NULL,
	IDAccion bigint NOT NULL IDENTITY (1, 1)
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_d_Acciones ADD CONSTRAINT
	DF_d_Acciones_IDGabinete DEFAULT ((1)) FOR IDGabinete
GO
ALTER TABLE dbo.Tmp_d_Acciones ADD CONSTRAINT
	DF_d_Acciones_Urgente DEFAULT ((0)) FOR Urgente
GO
SET IDENTITY_INSERT dbo.Tmp_d_Acciones ON
GO
IF EXISTS(SELECT * FROM dbo.d_Acciones)
	 EXEC('INSERT INTO dbo.Tmp_d_Acciones (IDOdontograma, FechaEjecucion, IDMedico, DescripcionGenerada, IDGabinete, IDTratamiento, Cuadrantes, PiezasInvolucradas, Urgente, IDAccion)
		SELECT IDOdontograma, FechaEjecucion, IDMedico, DescripcionGenerada, IDGabinete, IDTratamiento, Cuadrantes, PiezasInvolucradas, Urgente, IDAccion FROM dbo.d_Acciones WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_d_Acciones OFF
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT FK_d_PresupuestoLineas_d_Acciones
GO
DROP TABLE dbo.d_Acciones
GO
EXECUTE sp_rename N'dbo.Tmp_d_Acciones', N'd_Acciones', 'OBJECT' 
GO
ALTER TABLE dbo.d_Acciones ADD CONSTRAINT
	PK_d_Acciones PRIMARY KEY CLUSTERED 
	(
	IDAccion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.d_Acciones ADD CONSTRAINT
	FK_d_Acciones_d_Acciones FOREIGN KEY
	(
	IDMedico
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.d_Acciones ADD CONSTRAINT
	FK_d_Acciones_d_Odontogramas FOREIGN KEY
	(
	IDOdontograma
	) REFERENCES dbo.d_Odontogramas
	(
	IDOdontograma
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.d_Acciones ADD CONSTRAINT
	FK_d_Acciones_CONCEPTOSFRA FOREIGN KEY
	(
	IDTratamiento
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT DF_d_PresupuestoLineas_Confirmado
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT DF_d_PresupuestoLineas_Realizado
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT DF_d_PresupuestoLineas_Urgencia
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT DF_d_PresupuestoLineas_Importe
GO
ALTER TABLE dbo.d_PresupuestoLineas
	DROP CONSTRAINT DF_d_PresupuestoLineas_DescuentoPercent
GO
CREATE TABLE dbo.Tmp_d_PresupuestoLineas
	(
	IDPresupuestoLinea bigint NOT NULL IDENTITY (1, 1),
	IDPresupuesto int NOT NULL,
	DescripcionGenerada nvarchar(250) NULL,
	IDTratamiento varchar(10) NULL,
	Cuadrantes nvarchar(50) NULL,
	PiezasInvolucradas nvarchar(50) NULL,
	Confirmado bit NOT NULL,
	Realizado bit NOT NULL,
	Urgencia int NOT NULL,
	FechaConfirmado datetime NULL,
	FechaRealizado datetime NULL,
	Importe decimal(10, 2) NOT NULL,
	IDCITA int NULL,
	DescuentoPercent float(53) NULL,
	IDAccionOrigen bigint NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_d_PresupuestoLineas ADD CONSTRAINT
	DF_d_PresupuestoLineas_Confirmado DEFAULT ((0)) FOR Confirmado
GO
ALTER TABLE dbo.Tmp_d_PresupuestoLineas ADD CONSTRAINT
	DF_d_PresupuestoLineas_Realizado DEFAULT ((0)) FOR Realizado
GO
ALTER TABLE dbo.Tmp_d_PresupuestoLineas ADD CONSTRAINT
	DF_d_PresupuestoLineas_Urgencia DEFAULT ((0)) FOR Urgencia
GO
ALTER TABLE dbo.Tmp_d_PresupuestoLineas ADD CONSTRAINT
	DF_d_PresupuestoLineas_Importe DEFAULT ((0)) FOR Importe
GO
ALTER TABLE dbo.Tmp_d_PresupuestoLineas ADD CONSTRAINT
	DF_d_PresupuestoLineas_DescuentoPercent DEFAULT ((0)) FOR DescuentoPercent
GO
SET IDENTITY_INSERT dbo.Tmp_d_PresupuestoLineas ON
GO
IF EXISTS(SELECT * FROM dbo.d_PresupuestoLineas)
	 EXEC('INSERT INTO dbo.Tmp_d_PresupuestoLineas (IDPresupuestoLinea, IDPresupuesto, DescripcionGenerada, IDTratamiento, Cuadrantes, PiezasInvolucradas, Confirmado, Realizado, Urgencia, FechaConfirmado, FechaRealizado, Importe, IDCITA, DescuentoPercent, IDAccionOrigen)
		SELECT IDPresupuestoLinea, IDPresupuesto, DescripcionGenerada, IDTratamiento, Cuadrantes, PiezasInvolucradas, Confirmado, Realizado, Urgencia, FechaConfirmado, FechaRealizado, Importe, IDCITA, DescuentoPercent, IDAccionOrigen FROM dbo.d_PresupuestoLineas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_d_PresupuestoLineas OFF
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT FK_LineasCitas_d_PresupuestoLineas
GO
DROP TABLE dbo.d_PresupuestoLineas
GO
EXECUTE sp_rename N'dbo.Tmp_d_PresupuestoLineas', N'd_PresupuestoLineas', 'OBJECT' 
GO
ALTER TABLE dbo.d_PresupuestoLineas ADD CONSTRAINT
	PK_d_PresupuestoLineas PRIMARY KEY CLUSTERED 
	(
	IDPresupuestoLinea
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.d_PresupuestoLineas ADD CONSTRAINT
	FK_d_PresupuestoLineas_d_Presupuesto FOREIGN KEY
	(
	IDPresupuesto
	) REFERENCES dbo.d_Presupuesto
	(
	IDPresupuesto
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.d_PresupuestoLineas ADD CONSTRAINT
	FK_d_PresupuestoLineas_Citas FOREIGN KEY
	(
	IDCITA
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  SET NULL 
	
GO
ALTER TABLE dbo.d_PresupuestoLineas ADD CONSTRAINT
	FK_d_PresupuestoLineas_d_Acciones FOREIGN KEY
	(
	IDAccionOrigen
	) REFERENCES dbo.d_Acciones
	(
	IDAccion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.d_PresupuestoLineas ADD CONSTRAINT
	FK_d_PresupuestoLineas_CONCEPTOSFRA FOREIGN KEY
	(
	IDTratamiento
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT FK_LINEASFACTURAS_LineasCitas
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	FK_LineasCitas_d_PresupuestoLineas FOREIGN KEY
	(
	RefLineaPresupuestoDental
	) REFERENCES dbo.d_PresupuestoLineas
	(
	IDPresupuestoLinea
	) ON UPDATE  NO ACTION 
	 ON DELETE  SET NULL 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT DF__LINEASFAC__CANTI__3C69FB99
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT DF__LINEASFAC__TIPOI__3D5E1FD2
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT DF_LINEASFACTURAS_Descuento
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT DF_LINEASFACTURAS_ImporteOriginal
GO
CREATE TABLE dbo.Tmp_LINEASFACTURAS
	(
	IDLINEAFACTURA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	CONCEPTO nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	IMPORTE decimal(18, 2) NULL,
	REFFACTURA int NOT NULL,
	REFCONCEPTO varchar(10) NULL,
	CANTIDAD real NOT NULL,
	TIPOIVA real NOT NULL,
	ID_Cita int NULL,
	Descuento float(53) NULL,
	ImporteOriginal float(53) NULL,
	RefLineaCita bigint NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_LINEASFACTURAS ADD CONSTRAINT
	DF__LINEASFAC__CANTI__3C69FB99 DEFAULT ((1)) FOR CANTIDAD
GO
ALTER TABLE dbo.Tmp_LINEASFACTURAS ADD CONSTRAINT
	DF__LINEASFAC__TIPOI__3D5E1FD2 DEFAULT ((0)) FOR TIPOIVA
GO
ALTER TABLE dbo.Tmp_LINEASFACTURAS ADD CONSTRAINT
	DF_LINEASFACTURAS_Descuento DEFAULT ((0)) FOR Descuento
GO
ALTER TABLE dbo.Tmp_LINEASFACTURAS ADD CONSTRAINT
	DF_LINEASFACTURAS_ImporteOriginal DEFAULT ((0)) FOR ImporteOriginal
GO
SET IDENTITY_INSERT dbo.Tmp_LINEASFACTURAS ON
GO
IF EXISTS(SELECT * FROM dbo.LINEASFACTURAS)
	 EXEC('INSERT INTO dbo.Tmp_LINEASFACTURAS (IDLINEAFACTURA, CONCEPTO, IMPORTE, REFFACTURA, REFCONCEPTO, CANTIDAD, TIPOIVA, ID_Cita, Descuento, ImporteOriginal, RefLineaCita)
		SELECT IDLINEAFACTURA, CONCEPTO, IMPORTE, REFFACTURA, REFCONCEPTO, CANTIDAD, TIPOIVA, ID_Cita, Descuento, ImporteOriginal, RefLineaCita FROM dbo.LINEASFACTURAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LINEASFACTURAS OFF
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS
	DROP CONSTRAINT FK_LCOMPARATIVAS_TRATAMIENTOS_LINEASFACTURAS
GO
DROP TABLE dbo.LINEASFACTURAS
GO
EXECUTE sp_rename N'dbo.Tmp_LINEASFACTURAS', N'LINEASFACTURAS', 'OBJECT' 
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	PK_LINEASFACTURAS PRIMARY KEY CLUSTERED 
	(
	IDLINEAFACTURA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	FK_LINEASFACTURAS_CITAS FOREIGN KEY
	(
	ID_Cita
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	fklineasfacturas FOREIGN KEY
	(
	REFFACTURA
	) REFERENCES dbo.FACTURAS
	(
	IDFACTURA
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	FK_LINEASFACTURAS_LineasCitas FOREIGN KEY
	(
	RefLineaCita,
	ID_Cita
	) REFERENCES dbo.LineasCitas
	(
	IdLinea,
	IdCita
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	fk_lineasfacturas FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS ADD CONSTRAINT
	FK_LCOMPARATIVAS_TRATAMIENTOS_LINEASFACTURAS FOREIGN KEY
	(
	ID_LineaFactura
	) REFERENCES dbo.LINEASFACTURAS
	(
	IDLINEAFACTURA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Tarifas
	DROP CONSTRAINT DF_Tarifas_DescripcionTarifa
GO
ALTER TABLE dbo.Tarifas
	DROP CONSTRAINT DF_Tarifas_Importe
GO
CREATE TABLE dbo.Tmp_Tarifas
	(
	IdTarifa int NOT NULL,
	DescripcionTarifa varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	IdConceptoFra varchar(10) NOT NULL,
	Importe float(53) NOT NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_Tarifas ADD CONSTRAINT
	DF_Tarifas_DescripcionTarifa DEFAULT ('') FOR DescripcionTarifa
GO
ALTER TABLE dbo.Tmp_Tarifas ADD CONSTRAINT
	DF_Tarifas_Importe DEFAULT ((0)) FOR Importe
GO
IF EXISTS(SELECT * FROM dbo.Tarifas)
	 EXEC('INSERT INTO dbo.Tmp_Tarifas (IdTarifa, DescripcionTarifa, IdConceptoFra, Importe)
		SELECT IdTarifa, DescripcionTarifa, IdConceptoFra, Importe FROM dbo.Tarifas WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.Tarifas
GO
EXECUTE sp_rename N'dbo.Tmp_Tarifas', N'Tarifas', 'OBJECT' 
GO
ALTER TABLE dbo.Tarifas ADD CONSTRAINT
	PK_Tarifas PRIMARY KEY CLUSTERED 
	(
	IdTarifa,
	IdConceptoFra
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Tarifas ADD CONSTRAINT
	FK_Tarifas_CONCEPTOSFRA FOREIGN KEY
	(
	IdConceptoFra
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_ConceptosFra_Imagenes
	DROP CONSTRAINT DF_d_ConceptosFra_Imagenes_Pintar
GO
CREATE TABLE dbo.Tmp_d_ConceptosFra_Imagenes
	(
	CodigoCfra varchar(10) NOT NULL,
	Cuadrante char(1) NOT NULL,
	IDImagen int NOT NULL,
	Pintar bit NOT NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_d_ConceptosFra_Imagenes ADD CONSTRAINT
	DF_d_ConceptosFra_Imagenes_Pintar DEFAULT ((1)) FOR Pintar
GO
IF EXISTS(SELECT * FROM dbo.d_ConceptosFra_Imagenes)
	 EXEC('INSERT INTO dbo.Tmp_d_ConceptosFra_Imagenes (CodigoCfra, Cuadrante, IDImagen, Pintar)
		SELECT CodigoCfra, Cuadrante, IDImagen, Pintar FROM dbo.d_ConceptosFra_Imagenes WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.d_ConceptosFra_Imagenes
GO
EXECUTE sp_rename N'dbo.Tmp_d_ConceptosFra_Imagenes', N'd_ConceptosFra_Imagenes', 'OBJECT' 
GO
ALTER TABLE dbo.d_ConceptosFra_Imagenes ADD CONSTRAINT
	PK_d_ConceptosFra_Imagenes_1 PRIMARY KEY CLUSTERED 
	(
	CodigoCfra,
	Cuadrante
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.d_ConceptosFra_Imagenes ADD CONSTRAINT
	FK_CONCEPTOSFRA_ConceptosFra_Imagenes FOREIGN KEY
	(
	CodigoCfra
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.d_ConceptosFra_Imagenes ADD CONSTRAINT
	FK_Imagenes_ConceptosFra_Imagenes FOREIGN KEY
	(
	IDImagen
	) REFERENCES dbo.d_Imagenes
	(
	IDImagen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATION DATOS COMPARATIVA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.DATOSCOMPARATIVA
	DROP CONSTRAINT fk_datoscomparativamodelodato
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DATOSCOMPARATIVA
	DROP CONSTRAINT fk_datoscomparativalcomparativa
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_DATOSCOMPARATIVA
	(
	ID int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFLCOMPARATIVA int NULL,
	DFLOAT real NULL,
	DBOOLEAN varchar(1) NULL,
	DVARCHAR varchar(90) NULL,
	REFMODELODATO int NULL,
	DXML xml NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_DATOSCOMPARATIVA ON
GO
IF EXISTS(SELECT * FROM dbo.DATOSCOMPARATIVA)
	 EXEC('INSERT INTO dbo.Tmp_DATOSCOMPARATIVA (ID, REFLCOMPARATIVA, DFLOAT, DBOOLEAN, DVARCHAR, REFMODELODATO, DXML)
		SELECT ID, REFLCOMPARATIVA, DFLOAT, DBOOLEAN, DVARCHAR, REFMODELODATO, DXML FROM dbo.DATOSCOMPARATIVA WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_DATOSCOMPARATIVA OFF
GO
DROP TABLE dbo.DATOSCOMPARATIVA
GO
EXECUTE sp_rename N'dbo.Tmp_DATOSCOMPARATIVA', N'DATOSCOMPARATIVA', 'OBJECT' 
GO
ALTER TABLE dbo.DATOSCOMPARATIVA ADD CONSTRAINT
	PK_DATOSCOMPARATIVA PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.DATOSCOMPARATIVA ADD CONSTRAINT
	fk_datoscomparativalcomparativa FOREIGN KEY
	(
	REFLCOMPARATIVA
	) REFERENCES dbo.LCOMPARATIVAS
	(
	ID
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.DATOSCOMPARATIVA ADD CONSTRAINT
	fk_datoscomparativamodelodato FOREIGN KEY
	(
	REFMODELODATO
	) REFERENCES dbo.MODELOSDATOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATION DERIVACIONES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_DERIVACIONES_DESTINOS
	(
	NOMBRE varchar(40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DIRECCION varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	POBLACION varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PROVINCIA varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CP varchar(5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	TLFNO1 varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	TLFNO2 varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	FAX varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	MAIL varchar(40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	WEB varchar(40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PERSONACION varchar(40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NOTAS text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CIF varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CODIGO varchar(12) NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.DERIVACIONES_DESTINOS)
	 EXEC('INSERT INTO dbo.Tmp_DERIVACIONES_DESTINOS (NOMBRE, DIRECCION, POBLACION, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACION, NOTAS, CIF, CODIGO)
		SELECT NOMBRE, DIRECCION, POBLACION, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACION, NOTAS, CIF, CODIGO FROM dbo.DERIVACIONES_DESTINOS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.DERIVACIONES
	DROP CONSTRAINT FK_DERIVACIONES_DERIVACIONES_DESTINOS
GO
DROP TABLE dbo.DERIVACIONES_DESTINOS
GO
EXECUTE sp_rename N'dbo.Tmp_DERIVACIONES_DESTINOS', N'DERIVACIONES_DESTINOS', 'OBJECT' 
GO
ALTER TABLE dbo.DERIVACIONES_DESTINOS ADD CONSTRAINT
	PK_DERIVACIONES_DESTINOS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DERIVACIONES
	DROP CONSTRAINT FK_DERIVACIONES_MEDICOS
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DERIVACIONES
	DROP CONSTRAINT fk_derivacionespaciente
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_DERIVACIONES
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	FECHA datetime NOT NULL,
	REFDESTINO varchar(12) NULL,
	DESTINO varchar(150) NULL,
	MOTIVO varchar(150) NULL,
	NOTAS text NULL,
	REFPACIENTE int NOT NULL,
	REFMEDICO int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_DERIVACIONES ON
GO
IF EXISTS(SELECT * FROM dbo.DERIVACIONES)
	 EXEC('INSERT INTO dbo.Tmp_DERIVACIONES (CODIGO, FECHA, REFDESTINO, DESTINO, MOTIVO, NOTAS, REFPACIENTE, REFMEDICO)
		SELECT CODIGO, FECHA, REFDESTINO, DESTINO, MOTIVO, NOTAS, REFPACIENTE, REFMEDICO FROM dbo.DERIVACIONES WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_DERIVACIONES OFF
GO
DROP TABLE dbo.DERIVACIONES
GO
EXECUTE sp_rename N'dbo.Tmp_DERIVACIONES', N'DERIVACIONES', 'OBJECT' 
GO
ALTER TABLE dbo.DERIVACIONES ADD CONSTRAINT
	PK_DERIVACIONES PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.DERIVACIONES ADD CONSTRAINT
	fk_derivacionespaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DERIVACIONES ADD CONSTRAINT
	FK_DERIVACIONES_MEDICOS FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DERIVACIONES ADD CONSTRAINT
	FK_DERIVACIONES_DERIVACIONES_DESTINOS FOREIGN KEY
	(
	REFDESTINO
	) REFERENCES dbo.DERIVACIONES_DESTINOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATION DERIVACIONES DESTINOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_DERIVACIONES_DESTINOS
	(
	NOMBRE varchar(40) NULL,
	DIRECCION varchar(150) NULL,
	POBLACION varchar(20) NULL,
	PROVINCIA varchar(20) NULL,
	CP varchar(5) NULL,
	TLFNO1 varchar(10) NULL,
	TLFNO2 varchar(10) NULL,
	FAX varchar(10) NULL,
	MAIL varchar(40) NULL,
	WEB varchar(40) NULL,
	PERSONACION varchar(40) NULL,
	NOTAS text NULL,
	CIF varchar(10) NULL,
	CODIGO varchar(12) NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.DERIVACIONES_DESTINOS)
	 EXEC('INSERT INTO dbo.Tmp_DERIVACIONES_DESTINOS (NOMBRE, DIRECCION, POBLACION, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACION, NOTAS, CIF, CODIGO)
		SELECT NOMBRE, DIRECCION, POBLACION, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACION, NOTAS, CIF, CODIGO FROM dbo.DERIVACIONES_DESTINOS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.DERIVACIONES
	DROP CONSTRAINT FK_DERIVACIONES_DERIVACIONES_DESTINOS
GO
DROP TABLE dbo.DERIVACIONES_DESTINOS
GO
EXECUTE sp_rename N'dbo.Tmp_DERIVACIONES_DESTINOS', N'DERIVACIONES_DESTINOS', 'OBJECT' 
GO
ALTER TABLE dbo.DERIVACIONES_DESTINOS ADD CONSTRAINT
	PK_DERIVACIONES_DESTINOS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DERIVACIONES ADD CONSTRAINT
	FK_DERIVACIONES_DERIVACIONES_DESTINOS FOREIGN KEY
	(
	REFDESTINO
	) REFERENCES dbo.DERIVACIONES_DESTINOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIO COLLATION DIAGNOSTICO';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.DIAGNOSTICOS
	DROP CONSTRAINT DF__DIAGNOSTI__FAVOR__1ED998B2
GO
CREATE TABLE dbo.Tmp_DIAGNOSTICOS
	(
	IDDIAGNOSTICO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	DIAGNOSTICO varchar(70) NULL,
	OBSERVACIONES text NULL,
	NIVEL varchar(6) NOT NULL,
	SUBNIVEL varchar(6) NOT NULL,
	CIE varchar(13) NULL,
	FAVORITO varchar(1) NOT NULL,
	CIE10 varchar(12) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_DIAGNOSTICOS ADD CONSTRAINT
	DF__DIAGNOSTI__FAVOR__1ED998B2 DEFAULT ('N') FOR FAVORITO
GO
SET IDENTITY_INSERT dbo.Tmp_DIAGNOSTICOS ON
GO
IF EXISTS(SELECT * FROM dbo.DIAGNOSTICOS)
	 EXEC('INSERT INTO dbo.Tmp_DIAGNOSTICOS (IDDIAGNOSTICO, DIAGNOSTICO, OBSERVACIONES, NIVEL, SUBNIVEL, CIE, FAVORITO, CIE10)
		SELECT IDDIAGNOSTICO, DIAGNOSTICO, OBSERVACIONES, NIVEL, SUBNIVEL, CIE, FAVORITO, CIE10 FROM dbo.DIAGNOSTICOS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_DIAGNOSTICOS OFF
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fk_recetasdiagnostico
GO
ALTER TABLE dbo.N_Partes_Asistencia
	DROP CONSTRAINT FK_N_Partes_Asistencia_DIAGNOSTICOS
GO
ALTER TABLE dbo.AntecedentesDiagnosticos
	DROP CONSTRAINT FK_AntecedentesDiagnosticos_DIAGNOSTICOS
GO
ALTER TABLE dbo.HistorialesDiagnosticos
	DROP CONSTRAINT FK_HistorialesDiagnosticos_DIAGNOSTICOS
GO
ALTER TABLE dbo.N_Partes
	DROP CONSTRAINT FK_N_Partes_DIAGNOSTICOS
GO
DROP TABLE dbo.DIAGNOSTICOS
GO
EXECUTE sp_rename N'dbo.Tmp_DIAGNOSTICOS', N'DIAGNOSTICOS', 'OBJECT' 
GO
ALTER TABLE dbo.DIAGNOSTICOS ADD CONSTRAINT
	PK_DIAGNOSTICOS PRIMARY KEY CLUSTERED 
	(
	IDDIAGNOSTICO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes ADD CONSTRAINT
	FK_N_Partes_DIAGNOSTICOS FOREIGN KEY
	(
	ID_Diagnostico
	) REFERENCES dbo.DIAGNOSTICOS
	(
	IDDIAGNOSTICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HistorialesDiagnosticos ADD CONSTRAINT
	FK_HistorialesDiagnosticos_DIAGNOSTICOS FOREIGN KEY
	(
	IdDiagnostico
	) REFERENCES dbo.DIAGNOSTICOS
	(
	IDDIAGNOSTICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.AntecedentesDiagnosticos ADD CONSTRAINT
	FK_AntecedentesDiagnosticos_DIAGNOSTICOS FOREIGN KEY
	(
	IDDIAGNOSTICO
	) REFERENCES dbo.DIAGNOSTICOS
	(
	IDDIAGNOSTICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes_Asistencia ADD CONSTRAINT
	FK_N_Partes_Asistencia_DIAGNOSTICOS FOREIGN KEY
	(
	ID_Diagnostico
	) REFERENCES dbo.DIAGNOSTICOS
	(
	IDDIAGNOSTICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fk_recetasdiagnostico FOREIGN KEY
	(
	REFDIAGNOSTICO
	) REFERENCES dbo.DIAGNOSTICOS
	(
	IDDIAGNOSTICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATION EMPRESAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.EMPRESAS
	DROP CONSTRAINT DF__EMPRESAS__FECHA__20C1E124
GO
ALTER TABLE dbo.EMPRESAS
	DROP CONSTRAINT DF_EMPRESAS_Eliminado
GO
CREATE TABLE dbo.Tmp_EMPRESAS
	(
	NOMBRE varchar(40) NULL,
	DIRECCION varchar(150) NULL,
	POBLACION varchar(20) NULL,
	PROVINCIA varchar(20) NULL,
	CP varchar(5) NULL,
	TLFNO1 varchar(10) NULL,
	TLFNO2 varchar(10) NULL,
	FAX varchar(10) NULL,
	MAIL varchar(40) NULL,
	WEB varchar(40) NULL,
	PERSONACON varchar(40) NULL,
	NOTAS varchar(150) NULL,
	CNAE varchar(5) NULL,
	ACTIVIDAD varchar(30) NULL,
	CEMPRESA int NOT NULL,
	REFMUTUA int NULL,
	CIF varchar(10) NULL,
	NSS varchar(15) NULL,
	FECHA datetime NULL,
	ENTIDAD varchar(4) NULL,
	OFICINA varchar(4) NULL,
	DC varchar(2) NULL,
	CUENTA varchar(10) NULL,
	TITULAR varchar(40) NULL,
	Eliminado bit NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_EMPRESAS ADD CONSTRAINT
	DF__EMPRESAS__FECHA__20C1E124 DEFAULT (getdate()) FOR FECHA
GO
ALTER TABLE dbo.Tmp_EMPRESAS ADD CONSTRAINT
	DF_EMPRESAS_Eliminado DEFAULT ((0)) FOR Eliminado
GO
IF EXISTS(SELECT * FROM dbo.EMPRESAS)
	 EXEC('INSERT INTO dbo.Tmp_EMPRESAS (NOMBRE, DIRECCION, POBLACION, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACON, NOTAS, CNAE, ACTIVIDAD, CEMPRESA, REFMUTUA, CIF, NSS, FECHA, ENTIDAD, OFICINA, DC, CUENTA, TITULAR, Eliminado)
		SELECT NOMBRE, DIRECCION, POBLACION, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACON, NOTAS, CNAE, ACTIVIDAD, CEMPRESA, REFMUTUA, CIF, NSS, FECHA, ENTIDAD, OFICINA, DC, CUENTA, TITULAR, Eliminado FROM dbo.EMPRESAS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fkfacturasempresa
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fkfrasmeijideempresa
GO
ALTER TABLE dbo.LEMPRESAS
	DROP CONSTRAINT fk_lempresasempresa
GO
ALTER TABLE dbo.LMUTUASEMPRESAS
	DROP CONSTRAINT fk_lmutuasempresasempresas
GO
ALTER TABLE dbo.PRESUPUESTOS
	DROP CONSTRAINT fkpresupuestoempresa
GO
ALTER TABLE dbo.N_Procesos
	DROP CONSTRAINT FK_N_Procesos_EMPRESAS
GO
ALTER TABLE dbo.N_Partes_Asistencia
	DROP CONSTRAINT FK_N_Partes_Asistencia_EMPRESAS
GO
ALTER TABLE dbo.N_Partes
	DROP CONSTRAINT FK_N_Partes_EMPRESAS
GO
DROP TABLE dbo.EMPRESAS
GO
EXECUTE sp_rename N'dbo.Tmp_EMPRESAS', N'EMPRESAS', 'OBJECT' 
GO
ALTER TABLE dbo.EMPRESAS ADD CONSTRAINT
	PK_EMPRESAS PRIMARY KEY CLUSTERED 
	(
	CEMPRESA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes ADD CONSTRAINT
	FK_N_Partes_EMPRESAS FOREIGN KEY
	(
	ID_Empresa
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes_Asistencia ADD CONSTRAINT
	FK_N_Partes_Asistencia_EMPRESAS FOREIGN KEY
	(
	ID_Empresa
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Procesos ADD CONSTRAINT
	FK_N_Procesos_EMPRESAS FOREIGN KEY
	(
	ID_Empresa
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PRESUPUESTOS ADD CONSTRAINT
	fkpresupuestoempresa FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LMUTUASEMPRESAS ADD CONSTRAINT
	fk_lmutuasempresasempresas FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LEMPRESAS ADD CONSTRAINT
	fk_lempresasempresa FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fkfrasmeijideempresa FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fkfacturasempresa FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIA COLLATION FICHEROS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.FICHEROS
	DROP CONSTRAINT fk_ficheros
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_FICHEROS
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPACIENTE int NULL,
	FECHA datetime NULL,
	FECHAMODIFICACION datetime NULL,
	FICHERO varchar(255) NULL,
	NOTAS text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DESCRIPCION varchar(90) NULL,
	IDSECCION int NULL,
	TAG1 int NULL,
	TAG2 int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_FICHEROS ON
GO
IF EXISTS(SELECT * FROM dbo.FICHEROS)
	 EXEC('INSERT INTO dbo.Tmp_FICHEROS (CODIGO, REFPACIENTE, FECHA, FECHAMODIFICACION, FICHERO, NOTAS, DESCRIPCION, IDSECCION, TAG1, TAG2)
		SELECT CODIGO, REFPACIENTE, FECHA, FECHAMODIFICACION, FICHERO, NOTAS, DESCRIPCION, IDSECCION, TAG1, TAG2 FROM dbo.FICHEROS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_FICHEROS OFF
GO
DROP TABLE dbo.FICHEROS
GO
EXECUTE sp_rename N'dbo.Tmp_FICHEROS', N'FICHEROS', 'OBJECT' 
GO
ALTER TABLE dbo.FICHEROS ADD CONSTRAINT
	PK_FICHEROS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.FICHEROS ADD CONSTRAINT
	fk_ficheros FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT ' CAMBIAR COLLATE FICHEROS GLOBAL';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.FICHEROSGLOBAL
	DROP CONSTRAINT DF__FICHEROSG__FECHA__2A4B4B5E
GO
CREATE TABLE dbo.Tmp_FICHEROSGLOBAL
	(
	ID int NOT NULL,
	REFREGISTRO int NOT NULL,
	FICHERO varchar(250) NOT NULL,
	DESCRIPCION varchar(250) NOT NULL,
	FECHA datetime NOT NULL,
	SECCION varchar(1) NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_FICHEROSGLOBAL ADD CONSTRAINT
	DF__FICHEROSG__FECHA__2A4B4B5E DEFAULT getdate() FOR FECHA
GO
IF EXISTS(SELECT * FROM dbo.FICHEROSGLOBAL)
	 EXEC('INSERT INTO dbo.Tmp_FICHEROSGLOBAL (ID, REFREGISTRO, FICHERO, DESCRIPCION, FECHA, SECCION)
		SELECT ID, REFREGISTRO, FICHERO, DESCRIPCION, FECHA, SECCION FROM dbo.FICHEROSGLOBAL WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.FICHEROSGLOBAL
GO
EXECUTE sp_rename N'dbo.Tmp_FICHEROSGLOBAL', N'FICHEROSGLOBAL', 'OBJECT' 
GO
ALTER TABLE dbo.FICHEROSGLOBAL ADD CONSTRAINT
	PK_FICHEROSGLOBAL PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

PRINT 'CAMBIAR COLLATION HFACTURAMEIJIDE';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_HFRASMEIJIDE
	(
	NUMEROFACTURA int NOT NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	FACCIDENTE datetime NULL,
	FBAJA datetime NULL,
	FALTA datetime NULL,
	FEMISION datetime NULL,
	TOTAL decimal(18, 2) NULL,
	IRPF decimal(18, 2) NULL,
	DIAGNOSTICO varchar(70) NULL,
	DR1 varchar(70) NULL,
	DR2 varchar(70) NULL,
	DR1IMPORTE decimal(18, 2) NULL,
	DR2IMPORTE decimal(18, 2) NULL,
	RADIOGRAFIA varchar(70) NULL,
	RADIOGRAFIAIMPORTE decimal(18, 2) NULL,
	EKG varchar(70) NULL,
	EKGIMPORTE decimal(18, 2) NULL,
	ECOGRAFIA varchar(70) NULL,
	ECOGRAFIAIMPORTE decimal(18, 2) NULL,
	ANALISIS varchar(70) NULL,
	ANALISISIMPORTE decimal(18, 2) NULL,
	MATERIAL varchar(70) NULL,
	MATERIALIMPORTE decimal(18, 2) NULL,
	URGENCIAS varchar(70) NULL,
	URGENCIASIMPORTE decimal(18, 2) NULL,
	CONCEPTO1 varchar(70) NULL,
	CONCEPTO1IMPORTE decimal(18, 2) NULL,
	CONCEPTO2 varchar(70) NULL,
	CONCEPTO2IMPORTE decimal(18, 2) NULL,
	PAGADA varchar(1) NULL,
	REFDR1 int NULL,
	REFDR2 int NULL,
	PACIENTE varchar(65) NULL,
	MUTUA varchar(40) NULL,
	MDIRECCION varchar(60) NULL,
	MLOCALIDAD varchar(30) NULL,
	MPROVINCIA varchar(30) NULL,
	MCP varchar(5) NULL,
	EMPRESA varchar(60) NULL,
	ANHO int NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.HFRASMEIJIDE)
	 EXEC('INSERT INTO dbo.Tmp_HFRASMEIJIDE (NUMEROFACTURA, FECHA, HORA, FACCIDENTE, FBAJA, FALTA, FEMISION, TOTAL, IRPF, DIAGNOSTICO, DR1, DR2, DR1IMPORTE, DR2IMPORTE, RADIOGRAFIA, RADIOGRAFIAIMPORTE, EKG, EKGIMPORTE, ECOGRAFIA, ECOGRAFIAIMPORTE, ANALISIS, ANALISISIMPORTE, MATERIAL, MATERIALIMPORTE, URGENCIAS, URGENCIASIMPORTE, CONCEPTO1, CONCEPTO1IMPORTE, CONCEPTO2, CONCEPTO2IMPORTE, PAGADA, REFDR1, REFDR2, PACIENTE, MUTUA, MDIRECCION, MLOCALIDAD, MPROVINCIA, MCP, EMPRESA, ANHO)
		SELECT NUMEROFACTURA, FECHA, HORA, FACCIDENTE, FBAJA, FALTA, FEMISION, TOTAL, IRPF, DIAGNOSTICO, DR1, DR2, DR1IMPORTE, DR2IMPORTE, RADIOGRAFIA, RADIOGRAFIAIMPORTE, EKG, EKGIMPORTE, ECOGRAFIA, ECOGRAFIAIMPORTE, ANALISIS, ANALISISIMPORTE, MATERIAL, MATERIALIMPORTE, URGENCIAS, URGENCIASIMPORTE, CONCEPTO1, CONCEPTO1IMPORTE, CONCEPTO2, CONCEPTO2IMPORTE, PAGADA, REFDR1, REFDR2, PACIENTE, MUTUA, MDIRECCION, MLOCALIDAD, MPROVINCIA, MCP, EMPRESA, ANHO FROM dbo.HFRASMEIJIDE WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.HFRASMEIJIDE
GO
EXECUTE sp_rename N'dbo.Tmp_HFRASMEIJIDE', N'HFRASMEIJIDE', 'OBJECT' 
GO
COMMIT

PRINT 'CAMBIAR COLLATION H_ENTRADALINEAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_Entradas_Lineas
	DROP CONSTRAINT FK_N_Entradas_Lineas_N_Entradas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas_Lineas
	DROP CONSTRAINT FK_N_Entradas_Lineas_N_TipoIVA
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas_Lineas
	DROP CONSTRAINT FK_N_Entradas_Lineas_N_Almacen
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas_Lineas
	DROP CONSTRAINT DF_N_Entradas_Lineas_Validado
GO
CREATE TABLE dbo.Tmp_N_Entradas_Lineas
	(
	ID_EntradaLineas bigint NOT NULL IDENTITY (1, 1),
	ID_Entrada bigint NOT NULL,
	Codigo nvarchar(50) NULL,
	ID_Articulo bigint NULL,
	Descripcion nvarchar(200) NULL,
	Cantidad float(53) NULL,
	Precio float(53) NULL,
	Descuento1 float(53) NULL,
	Descuento2 float(53) NULL,
	Descuento3 float(53) NULL,
	Total float(53) NULL,
	ID_TipoIVA int NULL,
	IVAIncluido bit NOT NULL,
	Costo float(53) NULL,
	Imagen image NULL,
	Observaciones nvarchar(500) NULL,
	ID_Almacen int NULL,
	Validado bit NULL,
	ID_DocOrigen bigint NULL,
	ID_TipoDocOrigen int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Entradas_Lineas ADD CONSTRAINT
	DF_N_Entradas_Lineas_Validado DEFAULT ((0)) FOR Validado
GO
SET IDENTITY_INSERT dbo.Tmp_N_Entradas_Lineas ON
GO
IF EXISTS(SELECT * FROM dbo.N_Entradas_Lineas)
	 EXEC('INSERT INTO dbo.Tmp_N_Entradas_Lineas (ID_EntradaLineas, ID_Entrada, Codigo, ID_Articulo, Descripcion, Cantidad, Precio, Descuento1, Descuento2, Descuento3, Total, ID_TipoIVA, IVAIncluido, Costo, Imagen, Observaciones, ID_Almacen, Validado, ID_DocOrigen, ID_TipoDocOrigen)
		SELECT ID_EntradaLineas, ID_Entrada, Codigo, ID_Articulo, Descripcion, Cantidad, Precio, Descuento1, Descuento2, Descuento3, Total, ID_TipoIVA, IVAIncluido, Costo, Imagen, Observaciones, ID_Almacen, Validado, ID_DocOrigen, ID_TipoDocOrigen FROM dbo.N_Entradas_Lineas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Entradas_Lineas OFF
GO
DROP TABLE dbo.N_Entradas_Lineas
GO
EXECUTE sp_rename N'dbo.Tmp_N_Entradas_Lineas', N'N_Entradas_Lineas', 'OBJECT' 
GO
ALTER TABLE dbo.N_Entradas_Lineas ADD CONSTRAINT
	PK_N_Entradas_Lineas PRIMARY KEY CLUSTERED 
	(
	ID_EntradaLineas
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Entradas_Lineas ADD CONSTRAINT
	FK_N_Entradas_Lineas_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Entradas_Lineas ADD CONSTRAINT
	FK_N_Entradas_Lineas_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Entradas_Lineas ADD CONSTRAINT
	FK_N_Entradas_Lineas_N_Entradas FOREIGN KEY
	(
	ID_Entrada
	) REFERENCES dbo.N_Entradas
	(
	ID_Entrada
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATION ALARMAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_ALARMAS
	(
	CALARMA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	ALARMA varchar(40) NULL,
	NIVEL varchar(1) NULL,
	DESCRIPCION text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_ALARMAS ON
GO
IF EXISTS(SELECT * FROM dbo.ALARMAS)
	 EXEC('INSERT INTO dbo.Tmp_ALARMAS (CALARMA, ALARMA, NIVEL, DESCRIPCION)
		SELECT CALARMA, ALARMA, NIVEL, DESCRIPCION FROM dbo.ALARMAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ALARMAS OFF
GO
ALTER TABLE dbo.LINEASALARMA
	DROP CONSTRAINT fklineasalarmaalarma
GO
ALTER TABLE dbo.LINEASALARMAM
	DROP CONSTRAINT fklineasalarmamalarma
GO
DROP TABLE dbo.ALARMAS
GO
EXECUTE sp_rename N'dbo.Tmp_ALARMAS', N'ALARMAS', 'OBJECT' 
GO
ALTER TABLE dbo.ALARMAS ADD CONSTRAINT
	PK_ALARMAS PRIMARY KEY CLUSTERED 
	(
	CALARMA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASALARMAM ADD CONSTRAINT
	fklineasalarmamalarma FOREIGN KEY
	(
	REFALARMA
	) REFERENCES dbo.ALARMAS
	(
	CALARMA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASALARMA ADD CONSTRAINT
	fklineasalarmaalarma FOREIGN KEY
	(
	REFALARMA
	) REFERENCES dbo.ALARMAS
	(
	CALARMA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

print 'CAMBIAR COLLATION ALTAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.ALTAS
	DROP CONSTRAINT fkaltasmedico
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ALTAS
	DROP CONSTRAINT DF__ALTAS__EXTERNA__77BFCB91
GO
CREATE TABLE dbo.Tmp_ALTAS
	(
	IDALTA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPARTE int NULL,
	FECHAALTA datetime NULL,
	RESULTADORM text NULL,
	CAUSA varchar(2) NULL,
	EMISION datetime NULL,
	REFMEDICO int NULL,
	MEDICO varchar(50) NULL,
	EXTERNA varchar(1) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_ALTAS ADD CONSTRAINT
	DF__ALTAS__EXTERNA__77BFCB91 DEFAULT ('N') FOR EXTERNA
GO
SET IDENTITY_INSERT dbo.Tmp_ALTAS ON
GO
IF EXISTS(SELECT * FROM dbo.ALTAS)
	 EXEC('INSERT INTO dbo.Tmp_ALTAS (IDALTA, REFPARTE, FECHAALTA, RESULTADORM, CAUSA, EMISION, REFMEDICO, MEDICO, EXTERNA)
		SELECT IDALTA, REFPARTE, FECHAALTA, RESULTADORM, CAUSA, EMISION, REFMEDICO, MEDICO, EXTERNA FROM dbo.ALTAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ALTAS OFF
GO
DROP TABLE dbo.ALTAS
GO
EXECUTE sp_rename N'dbo.Tmp_ALTAS', N'ALTAS', 'OBJECT' 
GO
ALTER TABLE dbo.ALTAS ADD CONSTRAINT
	PK_ALTAS PRIMARY KEY CLUSTERED 
	(
	IDALTA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ALTAS ADD CONSTRAINT
	fkaltasmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE ANALITICAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.ANALITICAS
	DROP CONSTRAINT FK_ANALITICAS_CONCEPTOSFRA
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ANALITICAS
	DROP CONSTRAINT fk_analiticapaciente
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ANALITICAS
	DROP CONSTRAINT DF__ANALITICA__IMPOR__79A81403
GO
CREATE TABLE dbo.Tmp_ANALITICAS
	(
	NUMERO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	DESCRIPCION varchar(150) NULL,
	IMPORTE real NULL,
	REFPACIENTE int NULL,
	PACIENTE varchar(150) NULL,
	ESTADO varchar(1) NULL,
	FECHA datetime NULL,
	NOTAS text NULL,
	REFFRA int NULL,
	REFCONCEPTO varchar(10) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_ANALITICAS ADD CONSTRAINT
	DF__ANALITICA__IMPOR__79A81403 DEFAULT ((0)) FOR IMPORTE
GO
SET IDENTITY_INSERT dbo.Tmp_ANALITICAS ON
GO
IF EXISTS(SELECT * FROM dbo.ANALITICAS)
	 EXEC('INSERT INTO dbo.Tmp_ANALITICAS (NUMERO, DESCRIPCION, IMPORTE, REFPACIENTE, PACIENTE, ESTADO, FECHA, NOTAS, REFFRA, REFCONCEPTO)
		SELECT NUMERO, DESCRIPCION, IMPORTE, REFPACIENTE, PACIENTE, ESTADO, FECHA, NOTAS, REFFRA, REFCONCEPTO FROM dbo.ANALITICAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ANALITICAS OFF
GO
ALTER TABLE dbo.LINEASANALITICAS
	DROP CONSTRAINT fk_lineasanaliticas
GO
DROP TABLE dbo.ANALITICAS
GO
EXECUTE sp_rename N'dbo.Tmp_ANALITICAS', N'ANALITICAS', 'OBJECT' 
GO
ALTER TABLE dbo.ANALITICAS ADD CONSTRAINT
	PK_ANALITICAS PRIMARY KEY CLUSTERED 
	(
	NUMERO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ANALITICAS ADD CONSTRAINT
	fk_analiticapaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ANALITICAS ADD CONSTRAINT
	FK_ANALITICAS_CONCEPTOSFRA FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASANALITICAS ADD CONSTRAINT
	fk_lineasanaliticas FOREIGN KEY
	(
	REFANALITICA
	) REFERENCES dbo.ANALITICAS
	(
	NUMERO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIO COLLATE ANTECEDENTES DIAGNOSTIOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.AntecedentesDiagnosticos
	DROP CONSTRAINT FK_AntecedentesDiagnosticos_PACIENTES
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.AntecedentesDiagnosticos
	DROP CONSTRAINT FK_AntecedentesDiagnosticos_DIAGNOSTICOS
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.AntecedentesDiagnosticos
	DROP CONSTRAINT DF_AntecedentesDiagnosticos_DIAGNOSTICO
GO
ALTER TABLE dbo.AntecedentesDiagnosticos
	DROP CONSTRAINT DF_AntecedentesDiagnosticos_OBSERVACIONES
GO
CREATE TABLE dbo.Tmp_AntecedentesDiagnosticos
	(
	IDANTECEDENTEDX int NOT NULL IDENTITY (1, 1),
	IDDIAGNOSTICO int NOT NULL,
	DIAGNOSTICO varchar(70) NOT NULL,
	OBSERVACIONES text NOT NULL,
	CIE10 varchar(12) NOT NULL,
	CPACIENTE int NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_AntecedentesDiagnosticos ADD CONSTRAINT
	DF_AntecedentesDiagnosticos_DIAGNOSTICO DEFAULT ('') FOR DIAGNOSTICO
GO
ALTER TABLE dbo.Tmp_AntecedentesDiagnosticos ADD CONSTRAINT
	DF_AntecedentesDiagnosticos_OBSERVACIONES DEFAULT ('') FOR OBSERVACIONES
GO
SET IDENTITY_INSERT dbo.Tmp_AntecedentesDiagnosticos ON
GO
IF EXISTS(SELECT * FROM dbo.AntecedentesDiagnosticos)
	 EXEC('INSERT INTO dbo.Tmp_AntecedentesDiagnosticos (IDANTECEDENTEDX, IDDIAGNOSTICO, DIAGNOSTICO, OBSERVACIONES, CIE10, CPACIENTE)
		SELECT IDANTECEDENTEDX, IDDIAGNOSTICO, DIAGNOSTICO, OBSERVACIONES, CIE10, CPACIENTE FROM dbo.AntecedentesDiagnosticos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_AntecedentesDiagnosticos OFF
GO
DROP TABLE dbo.AntecedentesDiagnosticos
GO
EXECUTE sp_rename N'dbo.Tmp_AntecedentesDiagnosticos', N'AntecedentesDiagnosticos', 'OBJECT' 
GO
ALTER TABLE dbo.AntecedentesDiagnosticos ADD CONSTRAINT
	PK_AntecedentesDiagnosticos PRIMARY KEY CLUSTERED 
	(
	IDANTECEDENTEDX
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.AntecedentesDiagnosticos ADD CONSTRAINT
	FK_AntecedentesDiagnosticos_DIAGNOSTICOS FOREIGN KEY
	(
	IDDIAGNOSTICO
	) REFERENCES dbo.DIAGNOSTICOS
	(
	IDDIAGNOSTICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.AntecedentesDiagnosticos ADD CONSTRAINT
	FK_AntecedentesDiagnosticos_PACIENTES FOREIGN KEY
	(
	CPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIO COLLATE ARTICULOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.ARTICULOS
	DROP CONSTRAINT fkarticulosproveedor
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_ARTICULOS
	(
	CARTICULO int NOT NULL,
	DESCRIPCION varchar(40) NULL,
	REFPROVEEDOR int NULL,
	STOCK int NULL,
	STOCKMIN int NULL,
	FECHA datetime NULL,
	NOTAS text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.ARTICULOS)
	 EXEC('INSERT INTO dbo.Tmp_ARTICULOS (CARTICULO, DESCRIPCION, REFPROVEEDOR, STOCK, STOCKMIN, FECHA, NOTAS)
		SELECT CARTICULO, DESCRIPCION, REFPROVEEDOR, STOCK, STOCKMIN, FECHA, NOTAS FROM dbo.ARTICULOS WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.ARTICULOS
GO
EXECUTE sp_rename N'dbo.Tmp_ARTICULOS', N'ARTICULOS', 'OBJECT' 
GO
ALTER TABLE dbo.ARTICULOS ADD CONSTRAINT
	PK_ARTICULOS PRIMARY KEY CLUSTERED 
	(
	CARTICULO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ARTICULOS ADD CONSTRAINT
	fkarticulosproveedor FOREIGN KEY
	(
	REFPROVEEDOR
	) REFERENCES dbo.PROVEEDORES
	(
	CPROVEEDOR
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIO COLLATE COMO CONOCIO';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.ComoConocio
	DROP CONSTRAINT DF_ComoConocio_Descripcion
GO
CREATE TABLE dbo.Tmp_ComoConocio
	(
	IDConocio int NOT NULL IDENTITY (1, 1),
	Descripcion varchar(250) NOT NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_ComoConocio ADD CONSTRAINT
	DF_ComoConocio_Descripcion DEFAULT ('') FOR Descripcion
GO
SET IDENTITY_INSERT dbo.Tmp_ComoConocio ON
GO
IF EXISTS(SELECT * FROM dbo.ComoConocio)
	 EXEC('INSERT INTO dbo.Tmp_ComoConocio (IDConocio, Descripcion)
		SELECT IDConocio, Descripcion FROM dbo.ComoConocio WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ComoConocio OFF
GO
DROP TABLE dbo.ComoConocio
GO
EXECUTE sp_rename N'dbo.Tmp_ComoConocio', N'ComoConocio', 'OBJECT' 
GO
ALTER TABLE dbo.ComoConocio ADD CONSTRAINT
	PK_ComoConocio PRIMARY KEY CLUSTERED 
	(
	IDConocio
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

PRINT 'CAMBIAR COLLATE FACTURAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT FK_FACTURAS_N_Procesos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fkfacturasmutua
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fk_facturasformapago
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT FK_FACTURAS_EntregasCuenta
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fkfacturaspaciente
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fkfacturasempresa
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__PAGADA__22AA2996
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__MUTUA__239E4DCF
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__RECIBO__24927208
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__PORCEN__25869641
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__FACTUR__267ABA7A
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF__FACTURAS__TIPOIV__276EDEB3
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF_FACTURAS_Descuento
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF_FACTURAS_Eliminado
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT DF_FACTURAS_PagadoConCredito
GO
CREATE TABLE dbo.Tmp_FACTURAS
	(
	IDFACTURA int NOT NULL,
	NUMEROFACTURA int NOT NULL,
	REFPACIENTE int NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	HISTORIAL int NULL,
	REFEMPRESA int NULL,
	REFMUTUA int NULL,
	FACCIDENTE datetime NULL,
	FBAJA datetime NULL,
	FALTA datetime NULL,
	FEMISION datetime NULL,
	TOTAL decimal(18, 2) NULL,
	IRPF decimal(18, 2) NULL,
	DIAGNOSTICO varchar(60) NULL,
	PAGADA varchar(1) NOT NULL,
	MUTUA varchar(100) NOT NULL,
	RECIBO varchar(1) NOT NULL,
	DIRECCION varchar(150) NULL,
	LOCALIDAD varchar(35) NULL,
	PROVINCIA varchar(35) NULL,
	CP varchar(6) NULL,
	REFRECIBO int NULL,
	PACIENTE varchar(90) NULL,
	REFCITA int NULL,
	FECHACOBRO datetime NULL,
	PORCENTAJEIRPF real NOT NULL,
	REFFORMAPAGO varchar(10) NULL,
	DNI varchar(30) NULL,
	EMPRESA varchar(100) NOT NULL,
	FACTURAR varchar(1) NOT NULL,
	NUMERO varchar(12) NULL,
	REFSERIE varchar(6) NULL,
	TIPOIVA real NULL,
	ID_Proceso bigint NULL,
	N19 nvarchar(1) NULL,
	Descuento float(53) NULL,
	FECHAENVIO datetime NULL,
	Eliminado bit NULL,
	IDEntregaCuenta bigint NULL,
	PagadoConCredito bit NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__PAGADA__22AA2996 DEFAULT ('N') FOR PAGADA
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__MUTUA__239E4DCF DEFAULT ('N') FOR MUTUA
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__RECIBO__24927208 DEFAULT ('N') FOR RECIBO
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__PORCEN__25869641 DEFAULT ((0)) FOR PORCENTAJEIRPF
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__FACTUR__267ABA7A DEFAULT ('P') FOR FACTURAR
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF__FACTURAS__TIPOIV__276EDEB3 DEFAULT ((0)) FOR TIPOIVA
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF_FACTURAS_Descuento DEFAULT ((0)) FOR Descuento
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF_FACTURAS_Eliminado DEFAULT ((0)) FOR Eliminado
GO
ALTER TABLE dbo.Tmp_FACTURAS ADD CONSTRAINT
	DF_FACTURAS_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
IF EXISTS(SELECT * FROM dbo.FACTURAS)
	 EXEC('INSERT INTO dbo.Tmp_FACTURAS (IDFACTURA, NUMEROFACTURA, REFPACIENTE, FECHA, HORA, HISTORIAL, REFEMPRESA, REFMUTUA, FACCIDENTE, FBAJA, FALTA, FEMISION, TOTAL, IRPF, DIAGNOSTICO, PAGADA, MUTUA, RECIBO, DIRECCION, LOCALIDAD, PROVINCIA, CP, REFRECIBO, PACIENTE, REFCITA, FECHACOBRO, PORCENTAJEIRPF, REFFORMAPAGO, DNI, EMPRESA, FACTURAR, NUMERO, REFSERIE, TIPOIVA, ID_Proceso, N19, Descuento, FECHAENVIO, Eliminado, IDEntregaCuenta, PagadoConCredito)
		SELECT IDFACTURA, NUMEROFACTURA, REFPACIENTE, FECHA, HORA, HISTORIAL, REFEMPRESA, REFMUTUA, FACCIDENTE, FBAJA, FALTA, FEMISION, TOTAL, IRPF, DIAGNOSTICO, PAGADA, MUTUA, RECIBO, DIRECCION, LOCALIDAD, PROVINCIA, CP, REFRECIBO, PACIENTE, REFCITA, FECHACOBRO, PORCENTAJEIRPF, REFFORMAPAGO, DNI, EMPRESA, FACTURAR, NUMERO, REFSERIE, TIPOIVA, ID_Proceso, N19, Descuento, FECHAENVIO, Eliminado, IDEntregaCuenta, PagadoConCredito FROM dbo.FACTURAS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT fklineasfacturas
GO
DROP TABLE dbo.FACTURAS
GO
EXECUTE sp_rename N'dbo.Tmp_FACTURAS', N'FACTURAS', 'OBJECT' 
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	PK_FACTURAS PRIMARY KEY CLUSTERED 
	(
	IDFACTURA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fkfacturasempresa FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fkfacturaspaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	FK_FACTURAS_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fk_facturasformapago FOREIGN KEY
	(
	REFFORMAPAGO
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fkfacturasmutua FOREIGN KEY
	(
	REFMUTUA
	) REFERENCES dbo.MUTUAS
	(
	CMUTUA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	FK_FACTURAS_N_Procesos FOREIGN KEY
	(
	ID_Proceso
	) REFERENCES dbo.N_Procesos
	(
	ID_Proceso
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	fklineasfacturas FOREIGN KEY
	(
	REFFACTURA
	) REFERENCES dbo.FACTURAS
	(
	IDFACTURA
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE FICHEROS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.FICHEROS
	DROP CONSTRAINT fk_ficheros
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_FICHEROS
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPACIENTE int NULL,
	FECHA datetime NULL,
	FECHAMODIFICACION datetime NULL,
	FICHERO varchar(255) NULL,
	NOTAS text NULL,
	DESCRIPCION varchar(90) NULL,
	IDSECCION int NULL,
	TAG1 int NULL,
	TAG2 int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_FICHEROS ON
GO
IF EXISTS(SELECT * FROM dbo.FICHEROS)
	 EXEC('INSERT INTO dbo.Tmp_FICHEROS (CODIGO, REFPACIENTE, FECHA, FECHAMODIFICACION, FICHERO, NOTAS, DESCRIPCION, IDSECCION, TAG1, TAG2)
		SELECT CODIGO, REFPACIENTE, FECHA, FECHAMODIFICACION, FICHERO, NOTAS, DESCRIPCION, IDSECCION, TAG1, TAG2 FROM dbo.FICHEROS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_FICHEROS OFF
GO
DROP TABLE dbo.FICHEROS
GO
EXECUTE sp_rename N'dbo.Tmp_FICHEROS', N'FICHEROS', 'OBJECT' 
GO
ALTER TABLE dbo.FICHEROS ADD CONSTRAINT
	PK_FICHEROS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.FICHEROS ADD CONSTRAINT
	fk_ficheros FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE FRASMEIJIDE';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fkdr1frasmeijide
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fkdr2frasmeijide
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fk_frasmeijiderecibo
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fk_frasmeijideformapago
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fkfrasmeijideempresa
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT DF__FRASMEIJI__MUTUA__2D27B809
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT DF__FRASMEIJI__RECIB__2E1BDC42
GO
CREATE TABLE dbo.Tmp_FRASMEIJIDE
	(
	NUMEROFACTURA int NOT NULL,
	REFPACIENTE int NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	REFEMPRESA int NULL,
	REFMUTUA int NULL,
	FACCIDENTE datetime NULL,
	FBAJA datetime NULL,
	FALTA datetime NULL,
	FEMISION datetime NULL,
	TOTAL decimal(18, 2) NULL,
	IRPF decimal(18, 2) NULL,
	DIAGNOSTICO varchar(70) NULL,
	DR1 varchar(70) NULL,
	DR2 varchar(70) NULL,
	DR1IMPORTE decimal(18, 2) NULL,
	DR2IMPORTE decimal(18, 2) NULL,
	RADIOGRAFIA varchar(70) NULL,
	RADIOGRAFIAIMPORTE decimal(18, 2) NULL,
	EKG varchar(70) NULL,
	EKGIMPORTE decimal(18, 2) NULL,
	ECOGRAFIA varchar(70) NULL,
	ECOGRAFIAIMPORTE decimal(18, 2) NULL,
	ANALISIS varchar(70) NULL,
	ANALISISIMPORTE decimal(18, 2) NULL,
	MATERIAL varchar(70) NULL,
	MATERIALIMPORTE decimal(18, 2) NULL,
	URGENCIAS varchar(70) NULL,
	URGENCIASIMPORTE decimal(18, 2) NULL,
	CONCEPTO1 varchar(70) NULL,
	CONCEPTO1IMPORTE decimal(18, 2) NULL,
	CONCEPTO2 varchar(70) NULL,
	CONCEPTO2IMPORTE decimal(18, 2) NULL,
	PAGADA varchar(1) NULL,
	REFDR1 int NULL,
	REFDR2 int NULL,
	ANNO varchar(2) NOT NULL,
	MUTUA varchar(1) NULL,
	FECHACOBRO datetime NULL,
	PACIENTE varchar(90) NULL,
	DOMICILIOPACIENTE varchar(60) NULL,
	LOCALIDADPACIENTE varchar(40) NULL,
	CPPACIENTE varchar(5) NULL,
	PROVINCIAPACIENTE varchar(40) NULL,
	RECIBO varchar(1) NOT NULL,
	REFCITA int NULL,
	REFRECIBO int NULL,
	REFFORMAPAGO varchar(10) NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_FRASMEIJIDE ADD CONSTRAINT
	DF__FRASMEIJI__MUTUA__2D27B809 DEFAULT ('N') FOR MUTUA
GO
ALTER TABLE dbo.Tmp_FRASMEIJIDE ADD CONSTRAINT
	DF__FRASMEIJI__RECIB__2E1BDC42 DEFAULT ('N') FOR RECIBO
GO
IF EXISTS(SELECT * FROM dbo.FRASMEIJIDE)
	 EXEC('INSERT INTO dbo.Tmp_FRASMEIJIDE (NUMEROFACTURA, REFPACIENTE, FECHA, HORA, REFEMPRESA, REFMUTUA, FACCIDENTE, FBAJA, FALTA, FEMISION, TOTAL, IRPF, DIAGNOSTICO, DR1, DR2, DR1IMPORTE, DR2IMPORTE, RADIOGRAFIA, RADIOGRAFIAIMPORTE, EKG, EKGIMPORTE, ECOGRAFIA, ECOGRAFIAIMPORTE, ANALISIS, ANALISISIMPORTE, MATERIAL, MATERIALIMPORTE, URGENCIAS, URGENCIASIMPORTE, CONCEPTO1, CONCEPTO1IMPORTE, CONCEPTO2, CONCEPTO2IMPORTE, PAGADA, REFDR1, REFDR2, ANNO, MUTUA, FECHACOBRO, PACIENTE, DOMICILIOPACIENTE, LOCALIDADPACIENTE, CPPACIENTE, PROVINCIAPACIENTE, RECIBO, REFCITA, REFRECIBO, REFFORMAPAGO)
		SELECT NUMEROFACTURA, REFPACIENTE, FECHA, HORA, REFEMPRESA, REFMUTUA, FACCIDENTE, FBAJA, FALTA, FEMISION, TOTAL, IRPF, DIAGNOSTICO, DR1, DR2, DR1IMPORTE, DR2IMPORTE, RADIOGRAFIA, RADIOGRAFIAIMPORTE, EKG, EKGIMPORTE, ECOGRAFIA, ECOGRAFIAIMPORTE, ANALISIS, ANALISISIMPORTE, MATERIAL, MATERIALIMPORTE, URGENCIAS, URGENCIASIMPORTE, CONCEPTO1, CONCEPTO1IMPORTE, CONCEPTO2, CONCEPTO2IMPORTE, PAGADA, REFDR1, REFDR2, ANNO, MUTUA, FECHACOBRO, PACIENTE, DOMICILIOPACIENTE, LOCALIDADPACIENTE, CPPACIENTE, PROVINCIAPACIENTE, RECIBO, REFCITA, REFRECIBO, REFFORMAPAGO FROM dbo.FRASMEIJIDE WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.FRASMEIJIDE
GO
EXECUTE sp_rename N'dbo.Tmp_FRASMEIJIDE', N'FRASMEIJIDE', 'OBJECT' 
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	PK_FRASMEIJIDE PRIMARY KEY CLUSTERED 
	(
	NUMEROFACTURA,
	ANNO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fkfrasmeijideempresa FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fk_frasmeijideformapago FOREIGN KEY
	(
	REFFORMAPAGO
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fk_frasmeijiderecibo FOREIGN KEY
	(
	REFRECIBO
	) REFERENCES dbo.RECIBOS
	(
	NUMERO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fkdr1frasmeijide FOREIGN KEY
	(
	REFDR1
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fkdr2frasmeijide FOREIGN KEY
	(
	REFDR2
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIO COLLATE GASTOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.GASTOS
	DROP CONSTRAINT fk_gastosformapago
GO
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_GASTOS
	(
	IDGASTO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	CONCEPTO varchar(250) NULL,
	IMPORTE decimal(18, 2) NULL,
	FECHA datetime NULL,
	REFFORMAPAGO varchar(10) NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_GASTOS ON
GO
IF EXISTS(SELECT * FROM dbo.GASTOS)
	 EXEC('INSERT INTO dbo.Tmp_GASTOS (IDGASTO, CONCEPTO, IMPORTE, FECHA, REFFORMAPAGO)
		SELECT IDGASTO, CONCEPTO, IMPORTE, FECHA, REFFORMAPAGO FROM dbo.GASTOS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_GASTOS OFF
GO
DROP TABLE dbo.GASTOS
GO
EXECUTE sp_rename N'dbo.Tmp_GASTOS', N'GASTOS', 'OBJECT' 
GO
ALTER TABLE dbo.GASTOS ADD CONSTRAINT
	PK_GASTOS PRIMARY KEY CLUSTERED 
	(
	IDGASTO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.GASTOS ADD CONSTRAINT
	fk_gastosformapago FOREIGN KEY
	(
	REFFORMAPAGO
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE HISTORIALES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.HISTORIALES
	DROP CONSTRAINT fkhistorialesmedico
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HISTORIALES
	DROP CONSTRAINT fkhistorialespaciente
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HISTORIALES
	DROP CONSTRAINT DF_HISTORIALES_Eliminado
GO
CREATE TABLE dbo.Tmp_HISTORIALES
	(
	REFPACIENTE int NOT NULL,
	REFMEDICO int NOT NULL,
	FECHA datetime NULL,
	MOTIVO text NULL,
	ANTECEDENTES text NULL,
	EXPLORACION text NULL,
	COMPLEMENTARIAS text NULL,
	JUICIO text NULL,
	TRATAMIENTO text NULL,
	HISTORIAL text NULL,
	COMENTARIOS text NULL,
	CHISTORIAL int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	OTROS text NULL,
	HORA datetime NULL,
	REFDIAGNOSTICO int NULL,
	ParentHistorial int NULL,
	Eliminado bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_HISTORIALES ADD CONSTRAINT
	DF_HISTORIALES_Eliminado DEFAULT ((0)) FOR Eliminado
GO
SET IDENTITY_INSERT dbo.Tmp_HISTORIALES ON
GO
IF EXISTS(SELECT * FROM dbo.HISTORIALES)
	 EXEC('INSERT INTO dbo.Tmp_HISTORIALES (REFPACIENTE, REFMEDICO, FECHA, MOTIVO, ANTECEDENTES, EXPLORACION, COMPLEMENTARIAS, JUICIO, TRATAMIENTO, HISTORIAL, COMENTARIOS, CHISTORIAL, OTROS, HORA, REFDIAGNOSTICO, ParentHistorial, Eliminado)
		SELECT REFPACIENTE, REFMEDICO, FECHA, MOTIVO, ANTECEDENTES, EXPLORACION, COMPLEMENTARIAS, JUICIO, TRATAMIENTO, HISTORIAL, COMENTARIOS, CHISTORIAL, OTROS, HORA, REFDIAGNOSTICO, ParentHistorial, Eliminado FROM dbo.HISTORIALES WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_HISTORIALES OFF
GO
ALTER TABLE dbo.HISTORIALES_REVISIONES
	DROP CONSTRAINT FK_HISTORIALES_REVISIONES_HISTORIALES
GO
ALTER TABLE dbo.HISTORIALES
	DROP CONSTRAINT FK_HISTORIALES_HISTORIALES
GO
ALTER TABLE dbo.LHISTORIALES
	DROP CONSTRAINT pk_lhistorialeshistorial
GO
ALTER TABLE dbo.HistorialesDiagnosticos
	DROP CONSTRAINT FK_HistorialesDiagnosticos_HISTORIALES
GO
DROP TABLE dbo.HISTORIALES
GO
EXECUTE sp_rename N'dbo.Tmp_HISTORIALES', N'HISTORIALES', 'OBJECT' 
GO
ALTER TABLE dbo.HISTORIALES ADD CONSTRAINT
	PK_HISTORIALES PRIMARY KEY CLUSTERED 
	(
	CHISTORIAL
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.HISTORIALES ADD CONSTRAINT
	fkhistorialespaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.HISTORIALES ADD CONSTRAINT
	FK_HISTORIALES_HISTORIALES FOREIGN KEY
	(
	ParentHistorial
	) REFERENCES dbo.HISTORIALES
	(
	CHISTORIAL
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.HISTORIALES ADD CONSTRAINT
	fkhistorialesmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HistorialesDiagnosticos ADD CONSTRAINT
	FK_HistorialesDiagnosticos_HISTORIALES FOREIGN KEY
	(
	CHistorial
	) REFERENCES dbo.HISTORIALES
	(
	CHISTORIAL
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LHISTORIALES ADD CONSTRAINT
	pk_lhistorialeshistorial FOREIGN KEY
	(
	REFHISTORIAL
	) REFERENCES dbo.HISTORIALES
	(
	CHISTORIAL
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HISTORIALES_REVISIONES ADD CONSTRAINT
	FK_HISTORIALES_REVISIONES_HISTORIALES FOREIGN KEY
	(
	ID_Historial
	) REFERENCES dbo.HISTORIALES
	(
	CHISTORIAL
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATION HISTORIALES-DIAGNOSTICOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.HistorialesDiagnosticos
	DROP CONSTRAINT FK_HistorialesDiagnosticos_HISTORIALES
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HistorialesDiagnosticos
	DROP CONSTRAINT FK_HistorialesDiagnosticos_DIAGNOSTICOS
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HistorialesDiagnosticos
	DROP CONSTRAINT DF_HistorialesDiagnosticos_OBSERVACIONES
GO
ALTER TABLE dbo.HistorialesDiagnosticos
	DROP CONSTRAINT DF_HistorialesDiagnosticos_DIAGNOSTICO
GO
CREATE TABLE dbo.Tmp_HistorialesDiagnosticos
	(
	IdLineaDiagnostico int NOT NULL IDENTITY (1, 1),
	CHistorial int NOT NULL,
	IdDiagnostico int NOT NULL,
	CIE10 varchar(12) NOT NULL,
	OBSERVACIONES text NOT NULL,
	DIAGNOSTICO varchar(70) NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_HistorialesDiagnosticos ADD CONSTRAINT
	DF_HistorialesDiagnosticos_OBSERVACIONES DEFAULT ('') FOR OBSERVACIONES
GO
ALTER TABLE dbo.Tmp_HistorialesDiagnosticos ADD CONSTRAINT
	DF_HistorialesDiagnosticos_DIAGNOSTICO DEFAULT ('') FOR DIAGNOSTICO
GO
SET IDENTITY_INSERT dbo.Tmp_HistorialesDiagnosticos ON
GO
IF EXISTS(SELECT * FROM dbo.HistorialesDiagnosticos)
	 EXEC('INSERT INTO dbo.Tmp_HistorialesDiagnosticos (IdLineaDiagnostico, CHistorial, IdDiagnostico, CIE10, OBSERVACIONES, DIAGNOSTICO)
		SELECT IdLineaDiagnostico, CHistorial, IdDiagnostico, CIE10, OBSERVACIONES, DIAGNOSTICO FROM dbo.HistorialesDiagnosticos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_HistorialesDiagnosticos OFF
GO
DROP TABLE dbo.HistorialesDiagnosticos
GO
EXECUTE sp_rename N'dbo.Tmp_HistorialesDiagnosticos', N'HistorialesDiagnosticos', 'OBJECT' 
GO
ALTER TABLE dbo.HistorialesDiagnosticos ADD CONSTRAINT
	PK_HistorialesDiagnosticos PRIMARY KEY CLUSTERED 
	(
	IdLineaDiagnostico,
	CHistorial
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.HistorialesDiagnosticos ADD CONSTRAINT
	FK_HistorialesDiagnosticos_DIAGNOSTICOS FOREIGN KEY
	(
	IdDiagnostico
	) REFERENCES dbo.DIAGNOSTICOS
	(
	IDDIAGNOSTICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.HistorialesDiagnosticos ADD CONSTRAINT
	FK_HistorialesDiagnosticos_HISTORIALES FOREIGN KEY
	(
	CHistorial
	) REFERENCES dbo.HISTORIALES
	(
	CHISTORIAL
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIO COLLATE IMAGENES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.IMAGENES
	DROP CONSTRAINT fkimagenespaciente
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_IMAGENES
	(
	IDIMAGEN int NOT NULL,
	REFPACIENTE int NOT NULL,
	FECHA datetime NULL,
	TEXTO text NULL,
	IMAGEN image NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.IMAGENES)
	 EXEC('INSERT INTO dbo.Tmp_IMAGENES (IDIMAGEN, REFPACIENTE, FECHA, TEXTO, IMAGEN)
		SELECT IDIMAGEN, REFPACIENTE, FECHA, TEXTO, IMAGEN FROM dbo.IMAGENES WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.IMAGENES
GO
EXECUTE sp_rename N'dbo.Tmp_IMAGENES', N'IMAGENES', 'OBJECT' 
GO
ALTER TABLE dbo.IMAGENES ADD CONSTRAINT
	PK_IMAGENES PRIMARY KEY CLUSTERED 
	(
	IDIMAGEN
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.IMAGENES ADD CONSTRAINT
	fkimagenespaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE INDICACIONES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_INDICACIONES
	(
	CINDICACIONES int NOT NULL,
	NOMBRE varchar(30) NULL,
	TEXTO text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.INDICACIONES)
	 EXEC('INSERT INTO dbo.Tmp_INDICACIONES (CINDICACIONES, NOMBRE, TEXTO)
		SELECT CINDICACIONES, NOMBRE, TEXTO FROM dbo.INDICACIONES WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.INDICACIONES
GO
EXECUTE sp_rename N'dbo.Tmp_INDICACIONES', N'INDICACIONES', 'OBJECT' 
GO
ALTER TABLE dbo.INDICACIONES ADD CONSTRAINT
	PK_INDICACIONES PRIMARY KEY CLUSTERED 
	(
	CINDICACIONES
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

PRINT 'CAMBIAR COLLATE INFORMACIONPRIMARIA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.INFORMACIONPRIMARIA
	DROP CONSTRAINT fk_informacionprimariapaciente
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_INFORMACIONPRIMARIA
	(
	ID int NOT NULL,
	FECHA datetime NULL,
	DESCRIPCION varchar(150) NULL,
	TEXTO varchar(500) NULL,
	REFPACIENTE int NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.INFORMACIONPRIMARIA)
	 EXEC('INSERT INTO dbo.Tmp_INFORMACIONPRIMARIA (ID, FECHA, DESCRIPCION, TEXTO, REFPACIENTE)
		SELECT ID, FECHA, DESCRIPCION, TEXTO, REFPACIENTE FROM dbo.INFORMACIONPRIMARIA WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.INFORMACIONPRIMARIA
GO
EXECUTE sp_rename N'dbo.Tmp_INFORMACIONPRIMARIA', N'INFORMACIONPRIMARIA', 'OBJECT' 
GO
ALTER TABLE dbo.INFORMACIONPRIMARIA ADD CONSTRAINT
	PK_INFORMACIONPRIMARIA PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.INFORMACIONPRIMARIA ADD CONSTRAINT
	fk_informacionprimariapaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIO COLLATE LCOMPARATIVAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LCOMPARATIVAS
	DROP CONSTRAINT FK_LCOMPARATIVAS_MEDICOS
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS
	DROP CONSTRAINT FK_LCOMPARATIVAS_MODELOSCOMPARATIVA
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_LCOMPARATIVAS
	(
	ID int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFCOMPARATIVA int NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	REFMODELOCOMPARATIVA varchar(12) NULL,
	DESCRIPCION varchar(90) NULL,
	NOTAS text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFMEDICO int NULL,
	NOMBREMEDICO nvarchar(50) NULL,
	ESPECIALIDAD nvarchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_LCOMPARATIVAS ON
GO
IF EXISTS(SELECT * FROM dbo.LCOMPARATIVAS)
	 EXEC('INSERT INTO dbo.Tmp_LCOMPARATIVAS (ID, REFCOMPARATIVA, FECHA, HORA, REFMODELOCOMPARATIVA, DESCRIPCION, NOTAS, REFMEDICO, NOMBREMEDICO, ESPECIALIDAD)
		SELECT ID, REFCOMPARATIVA, FECHA, HORA, REFMODELOCOMPARATIVA, DESCRIPCION, NOTAS, REFMEDICO, NOMBREMEDICO, ESPECIALIDAD FROM dbo.LCOMPARATIVAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LCOMPARATIVAS OFF
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS
	DROP CONSTRAINT FK_LCOMPARATIVAS_TRATAMIENTOS_LCOMPARATIVAS
GO
ALTER TABLE dbo.DATOSCOMPARATIVA
	DROP CONSTRAINT fk_datoscomparativalcomparativa
GO
DROP TABLE dbo.LCOMPARATIVAS
GO
EXECUTE sp_rename N'dbo.Tmp_LCOMPARATIVAS', N'LCOMPARATIVAS', 'OBJECT' 
GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	PK_LCOMPARATIVAS PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	FK_LCOMPARATIVAS_MODELOSCOMPARATIVA FOREIGN KEY
	(
	REFMODELOCOMPARATIVA
	) REFERENCES dbo.MODELOSCOMPARATIVA
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	FK_LCOMPARATIVAS_MEDICOS FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DATOSCOMPARATIVA ADD CONSTRAINT
	fk_datoscomparativalcomparativa FOREIGN KEY
	(
	REFLCOMPARATIVA
	) REFERENCES dbo.LCOMPARATIVAS
	(
	ID
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS ADD CONSTRAINT
	FK_LCOMPARATIVAS_TRATAMIENTOS_LCOMPARATIVAS FOREIGN KEY
	(
	ID_LCOMPARATIVA
	) REFERENCES dbo.LCOMPARATIVAS
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LCOMPARATIVAS
	DROP CONSTRAINT FK_LCOMPARATIVAS_MEDICOS
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS
	DROP CONSTRAINT FK_LCOMPARATIVAS_MODELOSCOMPARATIVA
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_LCOMPARATIVAS
	(
	ID int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFCOMPARATIVA int NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	REFMODELOCOMPARATIVA varchar(12) NULL,
	DESCRIPCION varchar(90) NULL,
	NOTAS text NULL,
	REFMEDICO int NULL,
	NOMBREMEDICO nvarchar(50) NULL,
	ESPECIALIDAD nvarchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_LCOMPARATIVAS ON
GO
IF EXISTS(SELECT * FROM dbo.LCOMPARATIVAS)
	 EXEC('INSERT INTO dbo.Tmp_LCOMPARATIVAS (ID, REFCOMPARATIVA, FECHA, HORA, REFMODELOCOMPARATIVA, DESCRIPCION, NOTAS, REFMEDICO, NOMBREMEDICO, ESPECIALIDAD)
		SELECT ID, REFCOMPARATIVA, FECHA, HORA, REFMODELOCOMPARATIVA, DESCRIPCION, NOTAS, REFMEDICO, NOMBREMEDICO, ESPECIALIDAD FROM dbo.LCOMPARATIVAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LCOMPARATIVAS OFF
GO
ALTER TABLE dbo.DATOSCOMPARATIVA
	DROP CONSTRAINT fk_datoscomparativalcomparativa
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS
	DROP CONSTRAINT FK_LCOMPARATIVAS_TRATAMIENTOS_LCOMPARATIVAS
GO
DROP TABLE dbo.LCOMPARATIVAS
GO
EXECUTE sp_rename N'dbo.Tmp_LCOMPARATIVAS', N'LCOMPARATIVAS', 'OBJECT' 
GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	PK_LCOMPARATIVAS PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	FK_LCOMPARATIVAS_MODELOSCOMPARATIVA FOREIGN KEY
	(
	REFMODELOCOMPARATIVA
	) REFERENCES dbo.MODELOSCOMPARATIVA
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	FK_LCOMPARATIVAS_MEDICOS FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS ADD CONSTRAINT
	FK_LCOMPARATIVAS_TRATAMIENTOS_LCOMPARATIVAS FOREIGN KEY
	(
	ID_LCOMPARATIVA
	) REFERENCES dbo.LCOMPARATIVAS
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DATOSCOMPARATIVA ADD CONSTRAINT
	fk_datoscomparativalcomparativa FOREIGN KEY
	(
	REFLCOMPARATIVA
	) REFERENCES dbo.LCOMPARATIVAS
	(
	ID
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIO COLLATE LEMPRESAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LEMPRESAS
	DROP CONSTRAINT fk_lempresaspacientes
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LEMPRESAS
	DROP CONSTRAINT fk_lempresasempresa
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LEMPRESAS
	DROP CONSTRAINT DF_LEMPRESAS_PUESTOTRABAJO
GO
CREATE TABLE dbo.Tmp_LEMPRESAS
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFEMPRESA int NULL,
	REFPACIENTE int NULL,
	FECHAALTA datetime NULL,
	FECHABAJA datetime NULL,
	NOTAS text NULL,
	PUESTOTRABAJO varchar(50) NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_LEMPRESAS ADD CONSTRAINT
	DF_LEMPRESAS_PUESTOTRABAJO DEFAULT ('') FOR PUESTOTRABAJO
GO
SET IDENTITY_INSERT dbo.Tmp_LEMPRESAS ON
GO
IF EXISTS(SELECT * FROM dbo.LEMPRESAS)
	 EXEC('INSERT INTO dbo.Tmp_LEMPRESAS (CODIGO, REFEMPRESA, REFPACIENTE, FECHAALTA, FECHABAJA, NOTAS, PUESTOTRABAJO)
		SELECT CODIGO, REFEMPRESA, REFPACIENTE, FECHAALTA, FECHABAJA, NOTAS, PUESTOTRABAJO FROM dbo.LEMPRESAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LEMPRESAS OFF
GO
DROP TABLE dbo.LEMPRESAS
GO
EXECUTE sp_rename N'dbo.Tmp_LEMPRESAS', N'LEMPRESAS', 'OBJECT' 
GO
ALTER TABLE dbo.LEMPRESAS ADD CONSTRAINT
	PK_LEMPRESAS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LEMPRESAS ADD CONSTRAINT
	fk_lempresasempresa FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.LEMPRESAS ADD CONSTRAINT
	fk_lempresaspacientes FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE LHISTORIALES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LHISTORIALES
	DROP CONSTRAINT pk_lhistorialeshistorial
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_LHISTORIALES
	(
	ID int NOT NULL,
	REFHISTORIAL int NOT NULL,
	FECHA datetime NULL,
	HORA datetime NULL,
	EXPLORACION text NULL,
	COMPLEMENTARIAS text NULL,
	JUICIO text NULL,
	TRATAMIENTO text NULL,
	NOTAS text NULL,
	OTROS text NULL,
	EVOLUCION text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.LHISTORIALES)
	 EXEC('INSERT INTO dbo.Tmp_LHISTORIALES (ID, REFHISTORIAL, FECHA, HORA, EXPLORACION, COMPLEMENTARIAS, JUICIO, TRATAMIENTO, NOTAS, OTROS, EVOLUCION)
		SELECT ID, REFHISTORIAL, FECHA, HORA, EXPLORACION, COMPLEMENTARIAS, JUICIO, TRATAMIENTO, NOTAS, OTROS, EVOLUCION FROM dbo.LHISTORIALES WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.LHISTORIALES
GO
EXECUTE sp_rename N'dbo.Tmp_LHISTORIALES', N'LHISTORIALES', 'OBJECT' 
GO
ALTER TABLE dbo.LHISTORIALES ADD CONSTRAINT
	PK_LHISTORIALES PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LHISTORIALES ADD CONSTRAINT
	pk_lhistorialeshistorial FOREIGN KEY
	(
	REFHISTORIAL
	) REFERENCES dbo.HISTORIALES
	(
	CHISTORIAL
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE LINEASALARMA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LINEASALARMA
	DROP CONSTRAINT fklineasalarmaalarma
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASALARMA
	DROP CONSTRAINT fklineasalarmapaciente
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_LINEASALARMA
	(
	IDLINEAALARMA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPACIENTE int NULL,
	REFALARMA int NULL,
	DESCRIPCION text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_LINEASALARMA ON
GO
IF EXISTS(SELECT * FROM dbo.LINEASALARMA)
	 EXEC('INSERT INTO dbo.Tmp_LINEASALARMA (IDLINEAALARMA, REFPACIENTE, REFALARMA, DESCRIPCION)
		SELECT IDLINEAALARMA, REFPACIENTE, REFALARMA, DESCRIPCION FROM dbo.LINEASALARMA WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LINEASALARMA OFF
GO
DROP TABLE dbo.LINEASALARMA
GO
EXECUTE sp_rename N'dbo.Tmp_LINEASALARMA', N'LINEASALARMA', 'OBJECT' 
GO
ALTER TABLE dbo.LINEASALARMA ADD CONSTRAINT
	PK_LINEASALARMA PRIMARY KEY CLUSTERED 
	(
	IDLINEAALARMA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LINEASALARMA ADD CONSTRAINT
	fklineasalarmapaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LINEASALARMA ADD CONSTRAINT
	fklineasalarmaalarma FOREIGN KEY
	(
	REFALARMA
	) REFERENCES dbo.ALARMAS
	(
	CALARMA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE LINEASALARM';

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fkrecetasmedico
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fkrecetaspaciente
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fk_recetasdiagnostico
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MEDICAMENTOS
	DROP CONSTRAINT DF__MEDICAMEN__FAVOR__47DBAE45
GO
ALTER TABLE dbo.MEDICAMENTOS
	DROP CONSTRAINT DF_MEDICAMENTOS_CODIGONACIONAL
GO
CREATE TABLE dbo.Tmp_MEDICAMENTOS
	(
	CMEDICAMENTO varchar(5) NOT NULL,
	DESCRIPCION varchar(90) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	POSOLOGIA text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CANTIDADES text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	INDICACION varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	FAVORITOS varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CODIGONACIONAL nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_MEDICAMENTOS ADD CONSTRAINT
	DF__MEDICAMEN__FAVOR__47DBAE45 DEFAULT ('S') FOR FAVORITOS
GO
ALTER TABLE dbo.Tmp_MEDICAMENTOS ADD CONSTRAINT
	DF_MEDICAMENTOS_CODIGONACIONAL DEFAULT ('') FOR CODIGONACIONAL
GO
IF EXISTS(SELECT * FROM dbo.MEDICAMENTOS)
	 EXEC('INSERT INTO dbo.Tmp_MEDICAMENTOS (CMEDICAMENTO, DESCRIPCION, POSOLOGIA, CANTIDADES, INDICACION, FAVORITOS, CODIGONACIONAL)
		SELECT CMEDICAMENTO, DESCRIPCION, POSOLOGIA, CANTIDADES, INDICACION, FAVORITOS, CODIGONACIONAL FROM dbo.MEDICAMENTOS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.LINEASALARMAM
	DROP CONSTRAINT fklineasalarmammedicamento
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fk_recetamedicamento
GO
DROP TABLE dbo.MEDICAMENTOS
GO
EXECUTE sp_rename N'dbo.Tmp_MEDICAMENTOS', N'MEDICAMENTOS', 'OBJECT' 
GO
ALTER TABLE dbo.MEDICAMENTOS ADD CONSTRAINT
	PK_MEDICAMENTOS PRIMARY KEY CLUSTERED 
	(
	CMEDICAMENTO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT DF_RECETAS_Eliminado
GO
CREATE TABLE dbo.Tmp_RECETAS
	(
	IDRECETA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	FECHA datetime NULL,
	REFPACIENTE int NULL,
	TRATAMIENTO text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	REFMEDICO int NULL,
	REFDIAGNOSTICO int NULL,
	REFMEDICAMENTO varchar(5) NULL,
	HORA datetime NULL,
	Eliminado bit NULL,
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
	NoEnvases_o_Unidades int NULL,
	Prescriptor nvarchar(500) NULL,
	InstruccionesAlPaciente nvarchar(500) NULL,
	EsRecetaOficial bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_RECETAS ADD CONSTRAINT
	DF_RECETAS_Eliminado DEFAULT ((0)) FOR Eliminado
GO
SET IDENTITY_INSERT dbo.Tmp_RECETAS ON
GO
IF EXISTS(SELECT * FROM dbo.RECETAS)
	 EXEC('INSERT INTO dbo.Tmp_RECETAS (IDRECETA, FECHA, REFPACIENTE, TRATAMIENTO, REFMEDICO, REFDIAGNOSTICO, REFMEDICAMENTO, HORA, Eliminado, Prescripcion, DuracionTratamiento, PacienteInfo, Posologia, Unidades, Pauta, NoOrdenDispensacion, FechaPrevistaDispensacion, InfoAlFarmaceutico, DiagnosticoAlPaciente, NoEnvases_o_Unidades, Prescriptor, InstruccionesAlPaciente, EsRecetaOficial)
		SELECT IDRECETA, FECHA, REFPACIENTE, TRATAMIENTO, REFMEDICO, REFDIAGNOSTICO, REFMEDICAMENTO, HORA, Eliminado, Prescripcion, DuracionTratamiento, PacienteInfo, Posologia, Unidades, Pauta, NoOrdenDispensacion, FechaPrevistaDispensacion, InfoAlFarmaceutico, DiagnosticoAlPaciente, NoEnvases_o_Unidades, Prescriptor, InstruccionesAlPaciente, EsRecetaOficial FROM dbo.RECETAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_RECETAS OFF
GO
ALTER TABLE dbo.RecetasMedicamentos
	DROP CONSTRAINT FK_RecetasMedicamentos_RECETAS
GO
DROP TABLE dbo.RECETAS
GO
EXECUTE sp_rename N'dbo.Tmp_RECETAS', N'RECETAS', 'OBJECT' 
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	PK_RECETAS PRIMARY KEY CLUSTERED 
	(
	IDRECETA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fk_recetasdiagnostico FOREIGN KEY
	(
	REFDIAGNOSTICO
	) REFERENCES dbo.DIAGNOSTICOS
	(
	IDDIAGNOSTICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fkrecetaspaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fk_recetamedicamento FOREIGN KEY
	(
	REFMEDICAMENTO
	) REFERENCES dbo.MEDICAMENTOS
	(
	CMEDICAMENTO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fkrecetasmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RecetasMedicamentos ADD CONSTRAINT
	FK_RecetasMedicamentos_RECETAS FOREIGN KEY
	(
	IdReceta
	) REFERENCES dbo.RECETAS
	(
	IDRECETA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASALARMAM
	DROP CONSTRAINT fklineasalarmamalarma
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_LINEASALARMAM
	(
	IDLINEAALARMA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFMEDICAMENTO varchar(5) NOT NULL,
	REFALARMA int NOT NULL,
	DESCRIPCION text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_LINEASALARMAM ON
GO
IF EXISTS(SELECT * FROM dbo.LINEASALARMAM)
	 EXEC('INSERT INTO dbo.Tmp_LINEASALARMAM (IDLINEAALARMA, REFMEDICAMENTO, REFALARMA, DESCRIPCION)
		SELECT IDLINEAALARMA, REFMEDICAMENTO, REFALARMA, DESCRIPCION FROM dbo.LINEASALARMAM WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LINEASALARMAM OFF
GO
DROP TABLE dbo.LINEASALARMAM
GO
EXECUTE sp_rename N'dbo.Tmp_LINEASALARMAM', N'LINEASALARMAM', 'OBJECT' 
GO
ALTER TABLE dbo.LINEASALARMAM ADD CONSTRAINT
	PK_LINEASALARMAM PRIMARY KEY CLUSTERED 
	(
	IDLINEAALARMA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LINEASALARMAM ADD CONSTRAINT
	fklineasalarmamalarma FOREIGN KEY
	(
	REFALARMA
	) REFERENCES dbo.ALARMAS
	(
	CALARMA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.LINEASALARMAM ADD CONSTRAINT
	fklineasalarmammedicamento FOREIGN KEY
	(
	REFMEDICAMENTO
	) REFERENCES dbo.MEDICAMENTOS
	(
	CMEDICAMENTO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE LINEASANALITICAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LINEASANALITICAS
	DROP CONSTRAINT fk_lineasanaliticas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASANALITICAS
	DROP CONSTRAINT DF__LINEASANA__PRECI__3A81B327
GO
CREATE TABLE dbo.Tmp_LINEASANALITICAS
	(
	ID int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFANALITICA int NULL,
	REFCONCEPTO varchar(10) NULL,
	CONCEPTO varchar(90) NULL,
	PRECIO real NOT NULL,
	RESULTADO varchar(90) NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_LINEASANALITICAS ADD CONSTRAINT
	DF__LINEASANA__PRECI__3A81B327 DEFAULT ((0)) FOR PRECIO
GO
SET IDENTITY_INSERT dbo.Tmp_LINEASANALITICAS ON
GO
IF EXISTS(SELECT * FROM dbo.LINEASANALITICAS)
	 EXEC('INSERT INTO dbo.Tmp_LINEASANALITICAS (ID, REFANALITICA, REFCONCEPTO, CONCEPTO, PRECIO, RESULTADO)
		SELECT ID, REFANALITICA, REFCONCEPTO, CONCEPTO, PRECIO, RESULTADO FROM dbo.LINEASANALITICAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LINEASANALITICAS OFF
GO
DROP TABLE dbo.LINEASANALITICAS
GO
EXECUTE sp_rename N'dbo.Tmp_LINEASANALITICAS', N'LINEASANALITICAS', 'OBJECT' 
GO
ALTER TABLE dbo.LINEASANALITICAS ADD CONSTRAINT
	PK_LINEASANALITICAS PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LINEASANALITICAS ADD CONSTRAINT
	fk_lineasanaliticas FOREIGN KEY
	(
	REFANALITICA
	) REFERENCES dbo.ANALITICAS
	(
	NUMERO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE LINEAS CITAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT FK_LineasCitas_LCOMPARATIVAS_TRATAMIENTOS
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT FK_LineasCitas_d_PresupuestoLineas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT FK_LineasCitas_Citas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT DF_LineasCitas_DESCRIPCION
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT DF_LineasCitas_Cantidad
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT DF_LineasCitas_ImporteClinica
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT DF_LineasCitas_ImporteDr
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT DF_LineasCitas_DescuentoPercent
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT DF_LineasCitas_Total
GO
ALTER TABLE dbo.LineasCitas
	DROP CONSTRAINT DF_LineasCitas_Liquidada_al_Medico
GO
CREATE TABLE dbo.Tmp_LineasCitas
	(
	IdLinea bigint NOT NULL IDENTITY (1, 1),
	IdCita int NOT NULL,
	RefConcepto varchar(50) NULL,
	DESCRIPCION nvarchar(MAX) NOT NULL,
	Cantidad float(53) NOT NULL,
	ImporteClinica float(53) NOT NULL,
	ImporteDr float(53) NOT NULL,
	Duracion datetime NULL,
	RefLineaPresupuestoDental bigint NULL,
	DescuentoPercent float(53) NULL,
	Total float(53) NULL,
	Liquidada_al_Medico bit NULL,
	RefLineaTratamiento int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

DECLARE @v sql_variant 
SET @v = N'Total incluyendo descuentos'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_LineasCitas', N'COLUMN', N'Total'
GO
ALTER TABLE dbo.Tmp_LineasCitas ADD CONSTRAINT
	DF_LineasCitas_DESCRIPCION DEFAULT ('') FOR DESCRIPCION
GO
ALTER TABLE dbo.Tmp_LineasCitas ADD CONSTRAINT
	DF_LineasCitas_Cantidad DEFAULT ((1)) FOR Cantidad
GO
ALTER TABLE dbo.Tmp_LineasCitas ADD CONSTRAINT
	DF_LineasCitas_ImporteClinica DEFAULT ((0)) FOR ImporteClinica
GO
ALTER TABLE dbo.Tmp_LineasCitas ADD CONSTRAINT
	DF_LineasCitas_ImporteDr DEFAULT ((0)) FOR ImporteDr
GO
ALTER TABLE dbo.Tmp_LineasCitas ADD CONSTRAINT
	DF_LineasCitas_DescuentoPercent DEFAULT ((0)) FOR DescuentoPercent
GO
ALTER TABLE dbo.Tmp_LineasCitas ADD CONSTRAINT
	DF_LineasCitas_Total DEFAULT ((0)) FOR Total
GO
ALTER TABLE dbo.Tmp_LineasCitas ADD CONSTRAINT
	DF_LineasCitas_Liquidada_al_Medico DEFAULT ((0)) FOR Liquidada_al_Medico
GO
SET IDENTITY_INSERT dbo.Tmp_LineasCitas ON
GO
IF EXISTS(SELECT * FROM dbo.LineasCitas)
	 EXEC('INSERT INTO dbo.Tmp_LineasCitas (IdLinea, IdCita, RefConcepto, DESCRIPCION, Cantidad, ImporteClinica, ImporteDr, Duracion, RefLineaPresupuestoDental, DescuentoPercent, Total, Liquidada_al_Medico, RefLineaTratamiento)
		SELECT IdLinea, IdCita, RefConcepto, DESCRIPCION, Cantidad, ImporteClinica, ImporteDr, Duracion, RefLineaPresupuestoDental, DescuentoPercent, Total, Liquidada_al_Medico, RefLineaTratamiento FROM dbo.LineasCitas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LineasCitas OFF
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT FK_LINEASFACTURAS_LineasCitas
GO
DROP TABLE dbo.LineasCitas
GO
EXECUTE sp_rename N'dbo.Tmp_LineasCitas', N'LineasCitas', 'OBJECT' 
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	PK_LineasCitas PRIMARY KEY CLUSTERED 
	(
	IdLinea,
	IdCita
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	FK_LineasCitas_Citas FOREIGN KEY
	(
	IdCita
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	FK_LineasCitas_d_PresupuestoLineas FOREIGN KEY
	(
	RefLineaPresupuestoDental
	) REFERENCES dbo.d_PresupuestoLineas
	(
	IDPresupuestoLinea
	) ON UPDATE  NO ACTION 
	 ON DELETE  SET NULL 
	
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	FK_LineasCitas_LCOMPARATIVAS_TRATAMIENTOS FOREIGN KEY
	(
	RefLineaTratamiento
	) REFERENCES dbo.LCOMPARATIVAS_TRATAMIENTOS
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	FK_LINEASFACTURAS_LineasCitas FOREIGN KEY
	(
	RefLineaCita,
	ID_Cita
	) REFERENCES dbo.LineasCitas
	(
	IdLinea,
	IdCita
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATION LINEAS FACTURAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT fk_lineasfacturas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT FK_LINEASFACTURAS_CITAS
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT fklineasfacturas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT FK_LINEASFACTURAS_LineasCitas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT DF__LINEASFAC__CANTI__3C69FB99
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT DF__LINEASFAC__TIPOI__3D5E1FD2
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT DF_LINEASFACTURAS_Descuento
GO
ALTER TABLE dbo.LINEASFACTURAS
	DROP CONSTRAINT DF_LINEASFACTURAS_ImporteOriginal
GO
CREATE TABLE dbo.Tmp_LINEASFACTURAS
	(
	IDLINEAFACTURA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	CONCEPTO nvarchar(MAX) NULL,
	IMPORTE decimal(18, 2) NULL,
	REFFACTURA int NOT NULL,
	REFCONCEPTO varchar(10) NULL,
	CANTIDAD real NOT NULL,
	TIPOIVA real NOT NULL,
	ID_Cita int NULL,
	Descuento float(53) NULL,
	ImporteOriginal float(53) NULL,
	RefLineaCita bigint NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_LINEASFACTURAS ADD CONSTRAINT
	DF__LINEASFAC__CANTI__3C69FB99 DEFAULT ((1)) FOR CANTIDAD
GO
ALTER TABLE dbo.Tmp_LINEASFACTURAS ADD CONSTRAINT
	DF__LINEASFAC__TIPOI__3D5E1FD2 DEFAULT ((0)) FOR TIPOIVA
GO
ALTER TABLE dbo.Tmp_LINEASFACTURAS ADD CONSTRAINT
	DF_LINEASFACTURAS_Descuento DEFAULT ((0)) FOR Descuento
GO
ALTER TABLE dbo.Tmp_LINEASFACTURAS ADD CONSTRAINT
	DF_LINEASFACTURAS_ImporteOriginal DEFAULT ((0)) FOR ImporteOriginal
GO
SET IDENTITY_INSERT dbo.Tmp_LINEASFACTURAS ON
GO
IF EXISTS(SELECT * FROM dbo.LINEASFACTURAS)
	 EXEC('INSERT INTO dbo.Tmp_LINEASFACTURAS (IDLINEAFACTURA, CONCEPTO, IMPORTE, REFFACTURA, REFCONCEPTO, CANTIDAD, TIPOIVA, ID_Cita, Descuento, ImporteOriginal, RefLineaCita)
		SELECT IDLINEAFACTURA, CONCEPTO, IMPORTE, REFFACTURA, REFCONCEPTO, CANTIDAD, TIPOIVA, ID_Cita, Descuento, ImporteOriginal, RefLineaCita FROM dbo.LINEASFACTURAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LINEASFACTURAS OFF
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS
	DROP CONSTRAINT FK_LCOMPARATIVAS_TRATAMIENTOS_LINEASFACTURAS
GO
DROP TABLE dbo.LINEASFACTURAS
GO
EXECUTE sp_rename N'dbo.Tmp_LINEASFACTURAS', N'LINEASFACTURAS', 'OBJECT' 
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	PK_LINEASFACTURAS PRIMARY KEY CLUSTERED 
	(
	IDLINEAFACTURA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	FK_LINEASFACTURAS_LineasCitas FOREIGN KEY
	(
	RefLineaCita,
	ID_Cita
	) REFERENCES dbo.LineasCitas
	(
	IdLinea,
	IdCita
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	fklineasfacturas FOREIGN KEY
	(
	REFFACTURA
	) REFERENCES dbo.FACTURAS
	(
	IDFACTURA
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	FK_LINEASFACTURAS_CITAS FOREIGN KEY
	(
	ID_Cita
	) REFERENCES dbo.CITAS
	(
	IDCITA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LINEASFACTURAS ADD CONSTRAINT
	fk_lineasfacturas FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS_TRATAMIENTOS ADD CONSTRAINT
	FK_LCOMPARATIVAS_TRATAMIENTOS_LINEASFACTURAS FOREIGN KEY
	(
	ID_LineaFactura
	) REFERENCES dbo.LINEASFACTURAS
	(
	IDLINEAFACTURA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT

PRINT 'CAMBIO COLLATION LINEAS INDICACIONES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_LINEASINDICACIONES
	(
	IDLINEASINDICACIONES int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFMEDICAMENTO varchar(5) NOT NULL,
	REFINDICACION int NOT NULL,
	TEXTO text COLLATE SQL_Latin1_General_CP1_CI_AS NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_LINEASINDICACIONES ON
GO
IF EXISTS(SELECT * FROM dbo.LINEASINDICACIONES)
	 EXEC('INSERT INTO dbo.Tmp_LINEASINDICACIONES (IDLINEASINDICACIONES, REFMEDICAMENTO, REFINDICACION, TEXTO)
		SELECT IDLINEASINDICACIONES, REFMEDICAMENTO, REFINDICACION, TEXTO FROM dbo.LINEASINDICACIONES WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LINEASINDICACIONES OFF
GO
DROP TABLE dbo.LINEASINDICACIONES
GO
EXECUTE sp_rename N'dbo.Tmp_LINEASINDICACIONES', N'LINEASINDICACIONES', 'OBJECT' 
GO
ALTER TABLE dbo.LINEASINDICACIONES ADD CONSTRAINT
	PK_LINEASINDICACIONES PRIMARY KEY CLUSTERED 
	(
	IDLINEASINDICACIONES
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT


/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_LINEASINDICACIONES
	(
	IDLINEASINDICACIONES int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFMEDICAMENTO varchar(5) NOT NULL,
	REFINDICACION int NOT NULL,
	TEXTO text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_LINEASINDICACIONES ON
GO
IF EXISTS(SELECT * FROM dbo.LINEASINDICACIONES)
	 EXEC('INSERT INTO dbo.Tmp_LINEASINDICACIONES (IDLINEASINDICACIONES, REFMEDICAMENTO, REFINDICACION, TEXTO)
		SELECT IDLINEASINDICACIONES, REFMEDICAMENTO, REFINDICACION, TEXTO FROM dbo.LINEASINDICACIONES WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LINEASINDICACIONES OFF
GO
DROP TABLE dbo.LINEASINDICACIONES
GO
EXECUTE sp_rename N'dbo.Tmp_LINEASINDICACIONES', N'LINEASINDICACIONES', 'OBJECT' 
GO
ALTER TABLE dbo.LINEASINDICACIONES ADD CONSTRAINT
	PK_LINEASINDICACIONES PRIMARY KEY CLUSTERED 
	(
	IDLINEASINDICACIONES
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT


PRINT 'CAMBIO COLLATION LMUTUAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LMUTUAS
	DROP CONSTRAINT fk_lmutuas_pacientes
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LMUTUAS
	DROP CONSTRAINT DF__LMUTUAS__TIPO__403A8C7D
GO
CREATE TABLE dbo.Tmp_LMUTUAS
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPACIENTE int NULL,
	REFMUTUA int NULL,
	FECHAALTA datetime NULL,
	FECHABAJA datetime NULL,
	TIPO varchar(1) NULL,
	NOTAS text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_LMUTUAS ADD CONSTRAINT
	DF__LMUTUAS__TIPO__403A8C7D DEFAULT ('A') FOR TIPO
GO
SET IDENTITY_INSERT dbo.Tmp_LMUTUAS ON
GO
IF EXISTS(SELECT * FROM dbo.LMUTUAS)
	 EXEC('INSERT INTO dbo.Tmp_LMUTUAS (CODIGO, REFPACIENTE, REFMUTUA, FECHAALTA, FECHABAJA, TIPO, NOTAS)
		SELECT CODIGO, REFPACIENTE, REFMUTUA, FECHAALTA, FECHABAJA, TIPO, NOTAS FROM dbo.LMUTUAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LMUTUAS OFF
GO
DROP TABLE dbo.LMUTUAS
GO
EXECUTE sp_rename N'dbo.Tmp_LMUTUAS', N'LMUTUAS', 'OBJECT' 
GO
ALTER TABLE dbo.LMUTUAS ADD CONSTRAINT
	PK_LMUTUAS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LMUTUAS ADD CONSTRAINT
	fk_lmutuas_pacientes FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE LMUTUASEMPRESAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LMUTUASEMPRESAS
	DROP CONSTRAINT fk_lmutuasempresasempresas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LMUTUASEMPRESAS
	DROP CONSTRAINT DF__LMUTUASEMP__TIPO__4222D4EF
GO
CREATE TABLE dbo.Tmp_LMUTUASEMPRESAS
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFEMPRESA int NULL,
	FECHAALTA datetime NULL,
	FECHABAJA datetime NULL,
	TIPO varchar(1) NULL,
	REFMUTUA int NULL,
	NOTAS text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_LMUTUASEMPRESAS ADD CONSTRAINT
	DF__LMUTUASEMP__TIPO__4222D4EF DEFAULT ('M') FOR TIPO
GO
SET IDENTITY_INSERT dbo.Tmp_LMUTUASEMPRESAS ON
GO
IF EXISTS(SELECT * FROM dbo.LMUTUASEMPRESAS)
	 EXEC('INSERT INTO dbo.Tmp_LMUTUASEMPRESAS (CODIGO, REFEMPRESA, FECHAALTA, FECHABAJA, TIPO, REFMUTUA, NOTAS)
		SELECT CODIGO, REFEMPRESA, FECHAALTA, FECHABAJA, TIPO, REFMUTUA, NOTAS FROM dbo.LMUTUASEMPRESAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LMUTUASEMPRESAS OFF
GO
DROP TABLE dbo.LMUTUASEMPRESAS
GO
EXECUTE sp_rename N'dbo.Tmp_LMUTUASEMPRESAS', N'LMUTUASEMPRESAS', 'OBJECT' 
GO
ALTER TABLE dbo.LMUTUASEMPRESAS ADD CONSTRAINT
	PK_LMUTUASEMPRESAS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LMUTUASEMPRESAS ADD CONSTRAINT
	fk_lmutuasempresasempresas FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT


PRINT 'CAMBIO COLLATE LPLANTILLAANALITICA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.PLANTILLAANALITICAS
	DROP CONSTRAINT FK_PLANTILLAANALITICAS_CONCEPTOSFRA
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_PLANTILLAANALITICAS
	(
	CODIGO varchar(10) NOT NULL,
	DESCRIPCION varchar(90) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	REFCONCEPTO varchar(10) NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.PLANTILLAANALITICAS)
	 EXEC('INSERT INTO dbo.Tmp_PLANTILLAANALITICAS (CODIGO, DESCRIPCION, REFCONCEPTO)
		SELECT CODIGO, DESCRIPCION, REFCONCEPTO FROM dbo.PLANTILLAANALITICAS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.LPLANTILLAANALITICAS
	DROP CONSTRAINT fk_lplantillaplantilla
GO
DROP TABLE dbo.PLANTILLAANALITICAS
GO
EXECUTE sp_rename N'dbo.Tmp_PLANTILLAANALITICAS', N'PLANTILLAANALITICAS', 'OBJECT' 
GO
ALTER TABLE dbo.PLANTILLAANALITICAS ADD CONSTRAINT
	PK_PLANTILLAANALITICAS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.PLANTILLAANALITICAS ADD CONSTRAINT
	FK_PLANTILLAANALITICAS_CONCEPTOSFRA FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LPLANTILLAANALITICAS
	DROP CONSTRAINT DF__LPLANTILL__PRECI__440B1D61
GO
CREATE TABLE dbo.Tmp_LPLANTILLAANALITICAS
	(
	ID int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPLANTILLA varchar(10) NOT NULL,
	REFCONCEPTO varchar(10) NULL,
	PRECIO real NOT NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_LPLANTILLAANALITICAS ADD CONSTRAINT
	DF__LPLANTILL__PRECI__440B1D61 DEFAULT ((0)) FOR PRECIO
GO
SET IDENTITY_INSERT dbo.Tmp_LPLANTILLAANALITICAS ON
GO
IF EXISTS(SELECT * FROM dbo.LPLANTILLAANALITICAS)
	 EXEC('INSERT INTO dbo.Tmp_LPLANTILLAANALITICAS (ID, REFPLANTILLA, REFCONCEPTO, PRECIO)
		SELECT ID, REFPLANTILLA, REFCONCEPTO, PRECIO FROM dbo.LPLANTILLAANALITICAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LPLANTILLAANALITICAS OFF
GO
DROP TABLE dbo.LPLANTILLAANALITICAS
GO
EXECUTE sp_rename N'dbo.Tmp_LPLANTILLAANALITICAS', N'LPLANTILLAANALITICAS', 'OBJECT' 
GO
ALTER TABLE dbo.LPLANTILLAANALITICAS ADD CONSTRAINT
	PK_LPLANTILLAANALITICAS PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LPLANTILLAANALITICAS ADD CONSTRAINT
	fk_lplantillaplantilla FOREIGN KEY
	(
	REFPLANTILLA
	) REFERENCES dbo.PLANTILLAANALITICAS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIO COLLATE LPRESUPUESTOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.LPRESUPUESTOS
	DROP CONSTRAINT fklpresupuestoconcepto
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LPRESUPUESTOS
	DROP CONSTRAINT fklpresupuestopresupuesto
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LPRESUPUESTOS
	DROP CONSTRAINT DF__LPRESUPUE__CANTI__45F365D3
GO
CREATE TABLE dbo.Tmp_LPRESUPUESTOS
	(
	IDPRESUPUESTO int NOT NULL,
	CONCEPTO varchar(90) NULL,
	IMPORTE decimal(18, 2) NULL,
	REFPRESUPUESTO int NOT NULL,
	REFCONCEPTO varchar(10) NULL,
	CANTIDAD real NOT NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_LPRESUPUESTOS ADD CONSTRAINT
	DF__LPRESUPUE__CANTI__45F365D3 DEFAULT ((1)) FOR CANTIDAD
GO
IF EXISTS(SELECT * FROM dbo.LPRESUPUESTOS)
	 EXEC('INSERT INTO dbo.Tmp_LPRESUPUESTOS (IDPRESUPUESTO, CONCEPTO, IMPORTE, REFPRESUPUESTO, REFCONCEPTO, CANTIDAD)
		SELECT IDPRESUPUESTO, CONCEPTO, IMPORTE, REFPRESUPUESTO, REFCONCEPTO, CANTIDAD FROM dbo.LPRESUPUESTOS WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.LPRESUPUESTOS
GO
EXECUTE sp_rename N'dbo.Tmp_LPRESUPUESTOS', N'LPRESUPUESTOS', 'OBJECT' 
GO
ALTER TABLE dbo.LPRESUPUESTOS ADD CONSTRAINT
	PK_LPRESUPUESTOS PRIMARY KEY CLUSTERED 
	(
	IDPRESUPUESTO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LPRESUPUESTOS ADD CONSTRAINT
	fklpresupuestopresupuesto FOREIGN KEY
	(
	REFPRESUPUESTO
	) REFERENCES dbo.PRESUPUESTOS
	(
	NUMERO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LPRESUPUESTOS ADD CONSTRAINT
	fklpresupuestoconcepto FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIO COLLATION MEDICAMENTOS';

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.MEDICAMENTOS
	DROP CONSTRAINT DF__MEDICAMEN__FAVOR__47DBAE45
GO
ALTER TABLE dbo.MEDICAMENTOS
	DROP CONSTRAINT DF_MEDICAMENTOS_CODIGONACIONAL
GO
CREATE TABLE dbo.Tmp_MEDICAMENTOS
	(
	CMEDICAMENTO varchar(5) NOT NULL,
	DESCRIPCION varchar(90) NULL,
	POSOLOGIA text NULL,
	CANTIDADES text NULL,
	INDICACION varchar(30) NULL,
	FAVORITOS varchar(1) NOT NULL,
	CODIGONACIONAL nchar(10) NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_MEDICAMENTOS ADD CONSTRAINT
	DF__MEDICAMEN__FAVOR__47DBAE45 DEFAULT ('S') FOR FAVORITOS
GO
ALTER TABLE dbo.Tmp_MEDICAMENTOS ADD CONSTRAINT
	DF_MEDICAMENTOS_CODIGONACIONAL DEFAULT ('') FOR CODIGONACIONAL
GO
IF EXISTS(SELECT * FROM dbo.MEDICAMENTOS)
	 EXEC('INSERT INTO dbo.Tmp_MEDICAMENTOS (CMEDICAMENTO, DESCRIPCION, POSOLOGIA, CANTIDADES, INDICACION, FAVORITOS, CODIGONACIONAL)
		SELECT CMEDICAMENTO, DESCRIPCION, POSOLOGIA, CANTIDADES, INDICACION, FAVORITOS, CODIGONACIONAL FROM dbo.MEDICAMENTOS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fk_recetamedicamento
GO
ALTER TABLE dbo.LINEASALARMAM
	DROP CONSTRAINT fklineasalarmammedicamento
GO
DROP TABLE dbo.MEDICAMENTOS
GO
EXECUTE sp_rename N'dbo.Tmp_MEDICAMENTOS', N'MEDICAMENTOS', 'OBJECT' 
GO
ALTER TABLE dbo.MEDICAMENTOS ADD CONSTRAINT
	PK_MEDICAMENTOS PRIMARY KEY CLUSTERED 
	(
	CMEDICAMENTO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASALARMAM ADD CONSTRAINT
	fklineasalarmammedicamento FOREIGN KEY
	(
	REFMEDICAMENTO
	) REFERENCES dbo.MEDICAMENTOS
	(
	CMEDICAMENTO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fk_recetamedicamento FOREIGN KEY
	(
	REFMEDICAMENTO
	) REFERENCES dbo.MEDICAMENTOS
	(
	CMEDICAMENTO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIO COLLATION MEDICO';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.MEDICOS
	DROP CONSTRAINT DF_MEDICOS_PorcientoCita
GO
ALTER TABLE dbo.MEDICOS
	DROP CONSTRAINT DF_MEDICOS_Eliminado
GO
CREATE TABLE dbo.Tmp_MEDICOS
	(
	NOMBRE varchar(25) NULL,
	APELLIDO1 varchar(15) NULL,
	APELLIDO2 varchar(15) NULL,
	DOMICILIO varchar(150) NULL,
	TLFNO varchar(10) NULL,
	MOVIL varchar(10) NULL,
	LOCALIDAD varchar(20) NULL,
	CP varchar(5) NULL,
	DNI varchar(8) NULL,
	PROVINCIA varchar(30) NULL,
	COLEGIADO varchar(12) NULL,
	CMEDICO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	ESPECIALIDAD varchar(50) NULL,
	OBSERVACIONES text NULL,
	FIRMA image NULL,
	PorcientoCita float(53) NULL,
	Eliminado bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_MEDICOS ADD CONSTRAINT
	DF_MEDICOS_PorcientoCita DEFAULT ((0)) FOR PorcientoCita
GO
ALTER TABLE dbo.Tmp_MEDICOS ADD CONSTRAINT
	DF_MEDICOS_Eliminado DEFAULT ((0)) FOR Eliminado
GO
SET IDENTITY_INSERT dbo.Tmp_MEDICOS ON
GO
IF EXISTS(SELECT * FROM dbo.MEDICOS)
	 EXEC('INSERT INTO dbo.Tmp_MEDICOS (NOMBRE, APELLIDO1, APELLIDO2, DOMICILIO, TLFNO, MOVIL, LOCALIDAD, CP, DNI, PROVINCIA, COLEGIADO, CMEDICO, ESPECIALIDAD, OBSERVACIONES, FIRMA, PorcientoCita, Eliminado)
		SELECT NOMBRE, APELLIDO1, APELLIDO2, DOMICILIO, TLFNO, MOVIL, LOCALIDAD, CP, DNI, PROVINCIA, COLEGIADO, CMEDICO, ESPECIALIDAD, OBSERVACIONES, FIRMA, PorcientoCita, Eliminado FROM dbo.MEDICOS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_MEDICOS OFF
GO
ALTER TABLE dbo.CITAS
	DROP CONSTRAINT fkmedico
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fkrecetasmedico
GO
ALTER TABLE dbo.CALENDARIO_MEDICOS
	DROP CONSTRAINT FK_CALENDARIO_MEDICOS_MEDICOS
GO
ALTER TABLE dbo.MEDICOS_FICHEROS
	DROP CONSTRAINT FK_MEDICOS_FICHEROS_MEDICOS
GO
ALTER TABLE dbo.ALTAS
	DROP CONSTRAINT fkaltasmedico
GO
ALTER TABLE dbo.HISTORIALES_REVISIONES
	DROP CONSTRAINT FK_HISTORIALES_REVISIONES_MEDICOS
GO
ALTER TABLE dbo.ASISTENCIAS
	DROP CONSTRAINT fkasistenciasmedico
GO
ALTER TABLE dbo.d_Acciones
	DROP CONSTRAINT FK_d_Acciones_d_Acciones
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fkdr1frasmeijide
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fkdr2frasmeijide
GO
ALTER TABLE dbo.HISTORIALES
	DROP CONSTRAINT fkhistorialesmedico
GO
ALTER TABLE dbo.Liquidacion_Medico
	DROP CONSTRAINT FK_Liquidacion_Medico_MEDICOS
GO
ALTER TABLE dbo.INFORME_MEDICO
	DROP CONSTRAINT FK_INFORME_MEDICO_MEDICOS
GO
ALTER TABLE dbo.N_Partes_Asistencia
	DROP CONSTRAINT FK_N_Partes_Asistencia_MEDICOS
GO
ALTER TABLE dbo.BAJAS
	DROP CONSTRAINT fkbajasmedico
GO
ALTER TABLE dbo.LCOMPARATIVAS
	DROP CONSTRAINT FK_LCOMPARATIVAS_MEDICOS
GO
ALTER TABLE dbo.DERIVACIONES
	DROP CONSTRAINT FK_DERIVACIONES_MEDICOS
GO
ALTER TABLE dbo.N_Partes
	DROP CONSTRAINT FK_N_Partes_MEDICOS
GO
DROP TABLE dbo.MEDICOS
GO
EXECUTE sp_rename N'dbo.Tmp_MEDICOS', N'MEDICOS', 'OBJECT' 
GO
ALTER TABLE dbo.MEDICOS ADD CONSTRAINT
	PK_MEDICOS PRIMARY KEY CLUSTERED 
	(
	CMEDICO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes ADD CONSTRAINT
	FK_N_Partes_MEDICOS FOREIGN KEY
	(
	ID_Medico
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DERIVACIONES ADD CONSTRAINT
	FK_DERIVACIONES_MEDICOS FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	FK_LCOMPARATIVAS_MEDICOS FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.BAJAS ADD CONSTRAINT
	fkbajasmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes_Asistencia ADD CONSTRAINT
	FK_N_Partes_Asistencia_MEDICOS FOREIGN KEY
	(
	ID_Medico
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.INFORME_MEDICO ADD CONSTRAINT
	FK_INFORME_MEDICO_MEDICOS FOREIGN KEY
	(
	RefMedico
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Liquidacion_Medico ADD CONSTRAINT
	FK_Liquidacion_Medico_MEDICOS FOREIGN KEY
	(
	ID_Medico
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HISTORIALES ADD CONSTRAINT
	fkhistorialesmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fkdr1frasmeijide FOREIGN KEY
	(
	REFDR1
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fkdr2frasmeijide FOREIGN KEY
	(
	REFDR2
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_Acciones ADD CONSTRAINT
	FK_d_Acciones_d_Acciones FOREIGN KEY
	(
	IDMedico
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ASISTENCIAS ADD CONSTRAINT
	fkasistenciasmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HISTORIALES_REVISIONES ADD CONSTRAINT
	FK_HISTORIALES_REVISIONES_MEDICOS FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ALTAS ADD CONSTRAINT
	fkaltasmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MEDICOS_FICHEROS ADD CONSTRAINT
	FK_MEDICOS_FICHEROS_MEDICOS FOREIGN KEY
	(
	ID_Medico
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CALENDARIO_MEDICOS ADD CONSTRAINT
	FK_CALENDARIO_MEDICOS_MEDICOS FOREIGN KEY
	(
	ID_MEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fkrecetasmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	fkmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
PRINT 'CAMBIO COLLATE MODELOS COMPARATIVA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_MODELOSCOMPARATIVA
	(
	CODIGO varchar(12) NOT NULL,
	MODELO varchar(120) NULL,
	IMAGEN image NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.MODELOSCOMPARATIVA)
	 EXEC('INSERT INTO dbo.Tmp_MODELOSCOMPARATIVA (CODIGO, MODELO, IMAGEN)
		SELECT CODIGO, MODELO, IMAGEN FROM dbo.MODELOSCOMPARATIVA WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT fk_modelosdatoscomparativas
GO
ALTER TABLE dbo.COMPARATIVAS
	DROP CONSTRAINT fk_comparativasmodelo
GO
ALTER TABLE dbo.LCOMPARATIVAS
	DROP CONSTRAINT FK_LCOMPARATIVAS_MODELOSCOMPARATIVA
GO
DROP TABLE dbo.MODELOSCOMPARATIVA
GO
EXECUTE sp_rename N'dbo.Tmp_MODELOSCOMPARATIVA', N'MODELOSCOMPARATIVA', 'OBJECT' 
GO
ALTER TABLE dbo.MODELOSCOMPARATIVA ADD CONSTRAINT
	PK_MODELOSCOMPARATIVA PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LCOMPARATIVAS ADD CONSTRAINT
	FK_LCOMPARATIVAS_MODELOSCOMPARATIVA FOREIGN KEY
	(
	REFMODELOCOMPARATIVA
	) REFERENCES dbo.MODELOSCOMPARATIVA
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.COMPARATIVAS ADD CONSTRAINT
	fk_comparativasmodelo FOREIGN KEY
	(
	REFMODELOCOMPARATIVA
	) REFERENCES dbo.MODELOSCOMPARATIVA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MODELOSDATOS ADD CONSTRAINT
	fk_modelosdatoscomparativas FOREIGN KEY
	(
	REFMODELOCOMPARATIVA
	) REFERENCES dbo.MODELOSCOMPARATIVA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE MODELOSCOMPARATIVAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT fk_modelosdatoscomparativas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT DF__MODELOSDA__TIPOD__4BAC3F29
GO
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT DF_MODELOSDATOS_Repetir
GO
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT DF_MODELOSDATOS_CalcDiferencia
GO
ALTER TABLE dbo.MODELOSDATOS
	DROP CONSTRAINT DF_MODELOSDATOS_OcultarEnReporte
GO
CREATE TABLE dbo.Tmp_MODELOSDATOS
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	NOMBREDATO varchar(150) NULL,
	TIPODATO varchar(1) NULL,
	REFMODELOCOMPARATIVA varchar(12) NULL,
	ORDEN int NULL,
	XMLDEF nvarchar(MAX) NULL,
	DXML xml NULL,
	Repetir bit NULL,
	CalcDiferencia bit NULL,
	OcultarEnReporte bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_MODELOSDATOS ADD CONSTRAINT
	DF__MODELOSDA__TIPOD__4BAC3F29 DEFAULT ('F') FOR TIPODATO
GO
ALTER TABLE dbo.Tmp_MODELOSDATOS ADD CONSTRAINT
	DF_MODELOSDATOS_Repetir DEFAULT ((0)) FOR Repetir
GO
ALTER TABLE dbo.Tmp_MODELOSDATOS ADD CONSTRAINT
	DF_MODELOSDATOS_CalcDiferencia DEFAULT ((0)) FOR CalcDiferencia
GO
ALTER TABLE dbo.Tmp_MODELOSDATOS ADD CONSTRAINT
	DF_MODELOSDATOS_OcultarEnReporte DEFAULT ((0)) FOR OcultarEnReporte
GO
SET IDENTITY_INSERT dbo.Tmp_MODELOSDATOS ON
GO
IF EXISTS(SELECT * FROM dbo.MODELOSDATOS)
	 EXEC('INSERT INTO dbo.Tmp_MODELOSDATOS (CODIGO, NOMBREDATO, TIPODATO, REFMODELOCOMPARATIVA, ORDEN, XMLDEF, DXML, Repetir, CalcDiferencia, OcultarEnReporte)
		SELECT CODIGO, NOMBREDATO, TIPODATO, REFMODELOCOMPARATIVA, ORDEN, XMLDEF, DXML, Repetir, CalcDiferencia, OcultarEnReporte FROM dbo.MODELOSDATOS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_MODELOSDATOS OFF
GO
ALTER TABLE dbo.DATOSCOMPARATIVA
	DROP CONSTRAINT fk_datoscomparativamodelodato
GO
DROP TABLE dbo.MODELOSDATOS
GO
EXECUTE sp_rename N'dbo.Tmp_MODELOSDATOS', N'MODELOSDATOS', 'OBJECT' 
GO
ALTER TABLE dbo.MODELOSDATOS ADD CONSTRAINT
	PK_MODELOSDATOS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.MODELOSDATOS ADD CONSTRAINT
	fk_modelosdatoscomparativas FOREIGN KEY
	(
	REFMODELOCOMPARATIVA
	) REFERENCES dbo.MODELOSCOMPARATIVA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DATOSCOMPARATIVA ADD CONSTRAINT
	fk_datoscomparativamodelodato FOREIGN KEY
	(
	REFMODELODATO
	) REFERENCES dbo.MODELOSDATOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE MUTUAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.MUTUAS
	DROP CONSTRAINT DF_MUTUAS_Eliminado
GO
CREATE TABLE dbo.Tmp_MUTUAS
	(
	NOMBRE varchar(90) NULL,
	DIRECCION varchar(150) NULL,
	POBLACION varchar(20) NULL,
	PROVINCIA varchar(20) NULL,
	CP varchar(5) NULL,
	TLFNO1 varchar(10) NULL,
	TLFNO2 varchar(10) NULL,
	FAX varchar(10) NULL,
	MAIL varchar(40) NULL,
	WEB varchar(40) NULL,
	PERSONACON varchar(40) NULL,
	NOTAS varchar(8000) NULL,
	CMUTUA int NOT NULL,
	CIF varchar(10) NULL,
	ESPECIALIDAD varchar(50) NULL,
	PARTELSR varchar(30) NULL,
	PARTEMTR varchar(30) NULL,
	IdTarifa int NULL,
	NoContrato nvarchar(50) NULL,
	Logo image NULL,
	Eliminado bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_MUTUAS ADD CONSTRAINT
	DF_MUTUAS_Eliminado DEFAULT ((0)) FOR Eliminado
GO
IF EXISTS(SELECT * FROM dbo.MUTUAS)
	 EXEC('INSERT INTO dbo.Tmp_MUTUAS (NOMBRE, DIRECCION, POBLACION, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACON, NOTAS, CMUTUA, CIF, ESPECIALIDAD, PARTELSR, PARTEMTR, IdTarifa, NoContrato, Logo, Eliminado)
		SELECT NOMBRE, DIRECCION, POBLACION, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACON, NOTAS, CMUTUA, CIF, ESPECIALIDAD, PARTELSR, PARTEMTR, IdTarifa, NoContrato, Logo, Eliminado FROM dbo.MUTUAS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.d_Presupuesto
	DROP CONSTRAINT FK_d_Presupuesto_MUTUAS
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fkfacturasmutua
GO
ALTER TABLE dbo.PRESUPUESTOS
	DROP CONSTRAINT fkpresupuestomutua
GO
ALTER TABLE dbo.N_Procesos
	DROP CONSTRAINT FK_N_Procesos_MUTUAS
GO
DROP TABLE dbo.MUTUAS
GO
EXECUTE sp_rename N'dbo.Tmp_MUTUAS', N'MUTUAS', 'OBJECT' 
GO
ALTER TABLE dbo.MUTUAS ADD CONSTRAINT
	PK_MUTUAS PRIMARY KEY CLUSTERED 
	(
	CMUTUA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Procesos ADD CONSTRAINT
	FK_N_Procesos_MUTUAS FOREIGN KEY
	(
	ID_Mutua
	) REFERENCES dbo.MUTUAS
	(
	CMUTUA
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PRESUPUESTOS ADD CONSTRAINT
	fkpresupuestomutua FOREIGN KEY
	(
	REFMUTUA
	) REFERENCES dbo.MUTUAS
	(
	CMUTUA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fkfacturasmutua FOREIGN KEY
	(
	REFMUTUA
	) REFERENCES dbo.MUTUAS
	(
	CMUTUA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
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

PRINT 'CAMBIAR COLLATE N_ALMACEN';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_N_Almacen
	(
	ID_Almacen int NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	Descripcion nvarchar(200) NULL,
	Observaciones nvarchar(200) NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_N_Almacen ON
GO
IF EXISTS(SELECT * FROM dbo.N_Almacen)
	 EXEC('INSERT INTO dbo.Tmp_N_Almacen (ID_Almacen, Codigo, Descripcion, Observaciones)
		SELECT ID_Almacen, Codigo, Descripcion, Observaciones FROM dbo.N_Almacen WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Almacen OFF
GO
ALTER TABLE dbo.N_Entradas_Lineas
	DROP CONSTRAINT FK_N_Entradas_Lineas_N_Almacen
GO
ALTER TABLE dbo.N_Ticket_Lineas
	DROP CONSTRAINT FK_N_Ticket_Lineas_N_Almacen
GO
ALTER TABLE dbo.N_Factura_Lineas
	DROP CONSTRAINT FK_N_Factura_Lineas_N_Almacen
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas
	DROP CONSTRAINT FK_N_PedidosProveedor_Lineas_N_Almacen
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas
	DROP CONSTRAINT FK_N_FacturasRecibidas_Lineas_N_Almacen
GO
ALTER TABLE dbo.N_Articulos_ConsolidacionStock
	DROP CONSTRAINT FK_N_Articulos_ConsolidacionStock_N_Almacen
GO
ALTER TABLE dbo.N_Articulos_Almacen
	DROP CONSTRAINT FK_N_Articulos_Almacen_N_Almacen
GO
DROP TABLE dbo.N_Almacen
GO
EXECUTE sp_rename N'dbo.Tmp_N_Almacen', N'N_Almacen', 'OBJECT' 
GO
ALTER TABLE dbo.N_Almacen ADD CONSTRAINT
	PK_N_Almacen PRIMARY KEY CLUSTERED 
	(
	ID_Almacen
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos_Almacen ADD CONSTRAINT
	FK_N_Articulos_Almacen_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos_ConsolidacionStock ADD CONSTRAINT
	FK_N_Articulos_ConsolidacionStock_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas ADD CONSTRAINT
	FK_N_FacturasRecibidas_Lineas_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas ADD CONSTRAINT
	FK_N_PedidosProveedor_Lineas_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura_Lineas ADD CONSTRAINT
	FK_N_Factura_Lineas_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket_Lineas ADD CONSTRAINT
	FK_N_Ticket_Lineas_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas_Lineas ADD CONSTRAINT
	FK_N_Entradas_Lineas_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE N_ARTICULOS_PROVEEDORES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_Articulos_Proveedores
	DROP CONSTRAINT FK_N_Articulos_Proveedores_N_Proveedores
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos_Proveedores
	DROP CONSTRAINT FK_N_Articulos_Proveedores_N_Articulos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos_Proveedores
	DROP CONSTRAINT DF_N_Articulos_Proveedores_Precio
GO
ALTER TABLE dbo.N_Articulos_Proveedores
	DROP CONSTRAINT DF_N_Articulos_Proveedores_Descuento1
GO
ALTER TABLE dbo.N_Articulos_Proveedores
	DROP CONSTRAINT DF_N_Articulos_Proveedores_Descuento2
GO
ALTER TABLE dbo.N_Articulos_Proveedores
	DROP CONSTRAINT DF_N_Articulos_Proveedores_Descuento3
GO
ALTER TABLE dbo.N_Articulos_Proveedores
	DROP CONSTRAINT DF_N_Articulos_Proveedores_Resultado
GO
CREATE TABLE dbo.Tmp_N_Articulos_Proveedores
	(
	ID_Articulo bigint NOT NULL,
	ID_Proveedor int NOT NULL,
	Precio float(53) NULL,
	Descuento1 float(53) NULL,
	Descuento2 float(53) NULL,
	Descuento3 float(53) NULL,
	Resultado float(53) NULL,
	Referencia nvarchar(50) NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Articulos_Proveedores ADD CONSTRAINT
	DF_N_Articulos_Proveedores_Precio DEFAULT ((0)) FOR Precio
GO
ALTER TABLE dbo.Tmp_N_Articulos_Proveedores ADD CONSTRAINT
	DF_N_Articulos_Proveedores_Descuento1 DEFAULT ((0)) FOR Descuento1
GO
ALTER TABLE dbo.Tmp_N_Articulos_Proveedores ADD CONSTRAINT
	DF_N_Articulos_Proveedores_Descuento2 DEFAULT ((0)) FOR Descuento2
GO
ALTER TABLE dbo.Tmp_N_Articulos_Proveedores ADD CONSTRAINT
	DF_N_Articulos_Proveedores_Descuento3 DEFAULT ((0)) FOR Descuento3
GO
ALTER TABLE dbo.Tmp_N_Articulos_Proveedores ADD CONSTRAINT
	DF_N_Articulos_Proveedores_Resultado DEFAULT ((0)) FOR Resultado
GO
IF EXISTS(SELECT * FROM dbo.N_Articulos_Proveedores)
	 EXEC('INSERT INTO dbo.Tmp_N_Articulos_Proveedores (ID_Articulo, ID_Proveedor, Precio, Descuento1, Descuento2, Descuento3, Resultado, Referencia)
		SELECT ID_Articulo, ID_Proveedor, Precio, Descuento1, Descuento2, Descuento3, Resultado, Referencia FROM dbo.N_Articulos_Proveedores WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.N_Articulos_Proveedores
GO
EXECUTE sp_rename N'dbo.Tmp_N_Articulos_Proveedores', N'N_Articulos_Proveedores', 'OBJECT' 
GO
ALTER TABLE dbo.N_Articulos_Proveedores ADD CONSTRAINT
	PK_N_Articulos_Proveedores PRIMARY KEY CLUSTERED 
	(
	ID_Articulo,
	ID_Proveedor
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Articulos_Proveedores ADD CONSTRAINT
	FK_N_Articulos_Proveedores_N_Articulos FOREIGN KEY
	(
	ID_Articulo
	) REFERENCES dbo.N_Articulos
	(
	ID_Articulo
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Articulos_Proveedores ADD CONSTRAINT
	FK_N_Articulos_Proveedores_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE N_ARTICULOS_TIPO';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_N_Articulos_Tipo
	(
	ID_TipoArticulo int NOT NULL,
	Nombre nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.N_Articulos_Tipo)
	 EXEC('INSERT INTO dbo.Tmp_N_Articulos_Tipo (ID_TipoArticulo, Nombre)
		SELECT ID_TipoArticulo, Nombre FROM dbo.N_Articulos_Tipo WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT FK_N_Articulos_N_Articulos_Tipo
GO
DROP TABLE dbo.N_Articulos_Tipo
GO
EXECUTE sp_rename N'dbo.Tmp_N_Articulos_Tipo', N'N_Articulos_Tipo', 'OBJECT' 
GO
ALTER TABLE dbo.N_Articulos_Tipo ADD CONSTRAINT
	PK_N_Articulos_Tipo PRIMARY KEY CLUSTERED 
	(
	ID_TipoArticulo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos ADD CONSTRAINT
	FK_N_Articulos_N_Articulos_Tipo FOREIGN KEY
	(
	ID_TipoArticulo
	) REFERENCES dbo.N_Articulos_Tipo
	(
	ID_TipoArticulo
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE N_ENTRADAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT FK_N_Entradas_FormasPago
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT FK_N_Entradas_N_Proveedores
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT FK_N_Entradas_N_Entradas_Tipos
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT DF_N_Entradas_REPorciento
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT DF_N_Entradas_ReCantidad
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT DF_N_Entradas_PortePagado
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT DF_N_Entradas_PorteDebido
GO
CREATE TABLE dbo.Tmp_N_Entradas
	(
	ID_Entrada bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	ID_TipoEntrada int NULL,
	Referencia nvarchar(50) NULL,
	Fecha datetime NULL,
	ID_Estado int NULL,
	ID_Proveedor int NULL,
	ID_FormaPago varchar(10) NULL,
	IRPFPorciento float(53) NULL,
	IRPFCantidad float(53) NULL,
	Total float(53) NULL,
	Observaciones nvarchar(200) NULL,
	PlazoEntrega datetime NULL,
	Validez nvarchar(50) NULL,
	PortePagado bit NULL,
	PorteDebido bit NULL,
	PorteTexto nvarchar(50) NULL,
	Privado nvarchar(200) NULL,
	DocumentacionAsociada nvarchar(200) NULL,
	Comentarios nvarchar(200) NULL,
	Imagen image NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Entradas ADD CONSTRAINT
	DF_N_Entradas_REPorciento DEFAULT ((0)) FOR IRPFPorciento
GO
ALTER TABLE dbo.Tmp_N_Entradas ADD CONSTRAINT
	DF_N_Entradas_ReCantidad DEFAULT ((0)) FOR IRPFCantidad
GO
ALTER TABLE dbo.Tmp_N_Entradas ADD CONSTRAINT
	DF_N_Entradas_PortePagado DEFAULT ((1)) FOR PortePagado
GO
ALTER TABLE dbo.Tmp_N_Entradas ADD CONSTRAINT
	DF_N_Entradas_PorteDebido DEFAULT ((0)) FOR PorteDebido
GO
SET IDENTITY_INSERT dbo.Tmp_N_Entradas ON
GO
IF EXISTS(SELECT * FROM dbo.N_Entradas)
	 EXEC('INSERT INTO dbo.Tmp_N_Entradas (ID_Entrada, Codigo, ID_TipoEntrada, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen)
		SELECT ID_Entrada, Codigo, ID_TipoEntrada, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen FROM dbo.N_Entradas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Entradas OFF
GO
ALTER TABLE dbo.N_Entradas_Lineas
	DROP CONSTRAINT FK_N_Entradas_Lineas_N_Entradas
GO
ALTER TABLE dbo.N_Entradas_Totales
	DROP CONSTRAINT FK_N_Entradas_Totales_N_Entradas
GO
DROP TABLE dbo.N_Entradas
GO
EXECUTE sp_rename N'dbo.Tmp_N_Entradas', N'N_Entradas', 'OBJECT' 
GO
ALTER TABLE dbo.N_Entradas ADD CONSTRAINT
	PK_N_Entradas PRIMARY KEY CLUSTERED 
	(
	ID_Entrada
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Entradas ADD CONSTRAINT
	FK_N_Entradas_N_Entradas_Tipos FOREIGN KEY
	(
	ID_TipoEntrada
	) REFERENCES dbo.N_Entradas_Tipos
	(
	ID_TipoEntrada
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Entradas ADD CONSTRAINT
	FK_N_Entradas_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Entradas ADD CONSTRAINT
	FK_N_Entradas_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas_Totales ADD CONSTRAINT
	FK_N_Entradas_Totales_N_Entradas FOREIGN KEY
	(
	ID_Entrada
	) REFERENCES dbo.N_Entradas
	(
	ID_Entrada
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas_Lineas ADD CONSTRAINT
	FK_N_Entradas_Lineas_N_Entradas FOREIGN KEY
	(
	ID_Entrada
	) REFERENCES dbo.N_Entradas
	(
	ID_Entrada
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIO COLLATE N_ENTRADA_TIPOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_N_Entradas_Tipos
	(
	ID_TipoEntrada int NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	Descripcion nvarchar(50) NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_N_Entradas_Tipos ON
GO
IF EXISTS(SELECT * FROM dbo.N_Entradas_Tipos)
	 EXEC('INSERT INTO dbo.Tmp_N_Entradas_Tipos (ID_TipoEntrada, Codigo, Descripcion)
		SELECT ID_TipoEntrada, Codigo, Descripcion FROM dbo.N_Entradas_Tipos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Entradas_Tipos OFF
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT FK_N_Entradas_N_Entradas_Tipos
GO
DROP TABLE dbo.N_Entradas_Tipos
GO
EXECUTE sp_rename N'dbo.Tmp_N_Entradas_Tipos', N'N_Entradas_Tipos', 'OBJECT' 
GO
ALTER TABLE dbo.N_Entradas_Tipos ADD CONSTRAINT
	PK_N_Entradas_Tipos PRIMARY KEY CLUSTERED 
	(
	ID_TipoEntrada
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas ADD CONSTRAINT
	FK_N_Entradas_N_Entradas_Tipos FOREIGN KEY
	(
	ID_TipoEntrada
	) REFERENCES dbo.N_Entradas_Tipos
	(
	ID_TipoEntrada
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE N_FACTURA-LINEA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_Factura_Lineas
	DROP CONSTRAINT FK_N_Factura_Lineas_N_Almacen
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura_Lineas
	DROP CONSTRAINT FK_N_Factura_Lineas_N_Factura
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura_Lineas
	DROP CONSTRAINT FK_N_Factura_Lineas_N_TipoIVA
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura_Lineas
	DROP CONSTRAINT DF_N_Factura_Lineas_Validado
GO
CREATE TABLE dbo.Tmp_N_Factura_Lineas
	(
	ID_FacturaLineas bigint NOT NULL IDENTITY (1, 1),
	ID_Factura bigint NOT NULL,
	Codigo nvarchar(50) NULL,
	ID_Articulo bigint NULL,
	Descripcion nvarchar(200) NULL,
	Cantidad float(53) NULL,
	Precio float(53) NULL,
	Descuento1 float(53) NULL,
	Descuento2 float(53) NULL,
	Descuento3 float(53) NULL,
	Total float(53) NULL,
	ID_TipoIVA int NULL,
	IVAIncluido bit NOT NULL,
	Costo float(53) NULL,
	Imagen image NULL,
	Observaciones nvarchar(500) NULL,
	ID_Almacen int NULL,
	Validado bit NULL,
	ID_DocOrigen bigint NULL,
	ID_TipoDocOrigen int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Factura_Lineas ADD CONSTRAINT
	DF_N_Factura_Lineas_Validado DEFAULT ((0)) FOR Validado
GO
SET IDENTITY_INSERT dbo.Tmp_N_Factura_Lineas ON
GO
IF EXISTS(SELECT * FROM dbo.N_Factura_Lineas)
	 EXEC('INSERT INTO dbo.Tmp_N_Factura_Lineas (ID_FacturaLineas, ID_Factura, Codigo, ID_Articulo, Descripcion, Cantidad, Precio, Descuento1, Descuento2, Descuento3, Total, ID_TipoIVA, IVAIncluido, Costo, Imagen, Observaciones, ID_Almacen, Validado, ID_DocOrigen, ID_TipoDocOrigen)
		SELECT ID_FacturaLineas, ID_Factura, Codigo, ID_Articulo, Descripcion, Cantidad, Precio, Descuento1, Descuento2, Descuento3, Total, ID_TipoIVA, IVAIncluido, Costo, Imagen, Observaciones, ID_Almacen, Validado, ID_DocOrigen, ID_TipoDocOrigen FROM dbo.N_Factura_Lineas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Factura_Lineas OFF
GO
DROP TABLE dbo.N_Factura_Lineas
GO
EXECUTE sp_rename N'dbo.Tmp_N_Factura_Lineas', N'N_Factura_Lineas', 'OBJECT' 
GO
ALTER TABLE dbo.N_Factura_Lineas ADD CONSTRAINT
	PK_N_Factura_Lineas PRIMARY KEY CLUSTERED 
	(
	ID_FacturaLineas
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Factura_Lineas ADD CONSTRAINT
	FK_N_Factura_Lineas_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
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
ALTER TABLE dbo.N_Factura_Lineas ADD CONSTRAINT
	FK_N_Factura_Lineas_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIO COLLATE N_FACTURA_TIPOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_N_Factura_Tipos
	(
	ID_TipoFactura int NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	Descripcion nvarchar(50) NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_N_Factura_Tipos ON
GO
IF EXISTS(SELECT * FROM dbo.N_Factura_Tipos)
	 EXEC('INSERT INTO dbo.Tmp_N_Factura_Tipos (ID_TipoFactura, Codigo, Descripcion)
		SELECT ID_TipoFactura, Codigo, Descripcion FROM dbo.N_Factura_Tipos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Factura_Tipos OFF
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT FK_N_Factura_N_Factura_Tipos
GO
DROP TABLE dbo.N_Factura_Tipos
GO
EXECUTE sp_rename N'dbo.Tmp_N_Factura_Tipos', N'N_Factura_Tipos', 'OBJECT' 
GO
ALTER TABLE dbo.N_Factura_Tipos ADD CONSTRAINT
	PK_N_Factura_Tipos PRIMARY KEY CLUSTERED 
	(
	ID_TipoFactura
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
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

PRINT 'CAMBIO COLLATE N_FACTURA_RECIBIDA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT FK_N_FacturasRecibidas_N_Proveedores
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT FK_N_FacturasRecibidas_N_FacturasRecibidas_Tipos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT FK_N_FacturasRecibidas_FormasPago
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT DF_N_FacturasRecibidas_REPorciento
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT DF_N_FacturasRecibidas_ReCantidad
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT DF_N_FacturasRecibidas_PortePagado
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT DF_N_FacturasRecibidas_PorteDebido
GO
CREATE TABLE dbo.Tmp_N_FacturasRecibidas
	(
	ID_FacturaRecibida bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	ID_TipoFacturaRecibida int NULL,
	Referencia nvarchar(50) NULL,
	Fecha datetime NULL,
	ID_Estado int NULL,
	ID_Proveedor int NULL,
	ID_FormaPago varchar(10) NULL,
	IRPFPorciento float(53) NULL,
	IRPFCantidad float(53) NULL,
	Total float(53) NULL,
	Observaciones nvarchar(200) NULL,
	PlazoEntrega datetime NULL,
	Validez nvarchar(50) NULL,
	PortePagado bit NULL,
	PorteDebido bit NULL,
	PorteTexto nvarchar(50) NULL,
	Privado nvarchar(200) NULL,
	DocumentacionAsociada nvarchar(200) NULL,
	Comentarios nvarchar(200) NULL,
	Imagen image NULL,
	CodigoFacturaRecibida nvarchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_FacturasRecibidas ADD CONSTRAINT
	DF_N_FacturasRecibidas_REPorciento DEFAULT ((0)) FOR IRPFPorciento
GO
ALTER TABLE dbo.Tmp_N_FacturasRecibidas ADD CONSTRAINT
	DF_N_FacturasRecibidas_ReCantidad DEFAULT ((0)) FOR IRPFCantidad
GO
ALTER TABLE dbo.Tmp_N_FacturasRecibidas ADD CONSTRAINT
	DF_N_FacturasRecibidas_PortePagado DEFAULT ((1)) FOR PortePagado
GO
ALTER TABLE dbo.Tmp_N_FacturasRecibidas ADD CONSTRAINT
	DF_N_FacturasRecibidas_PorteDebido DEFAULT ((0)) FOR PorteDebido
GO
SET IDENTITY_INSERT dbo.Tmp_N_FacturasRecibidas ON
GO
IF EXISTS(SELECT * FROM dbo.N_FacturasRecibidas)
	 EXEC('INSERT INTO dbo.Tmp_N_FacturasRecibidas (ID_FacturaRecibida, Codigo, ID_TipoFacturaRecibida, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, CodigoFacturaRecibida)
		SELECT ID_FacturaRecibida, Codigo, ID_TipoFacturaRecibida, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, CodigoFacturaRecibida FROM dbo.N_FacturasRecibidas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_FacturasRecibidas OFF
GO
ALTER TABLE dbo.N_FacturasRecibidas_Totales
	DROP CONSTRAINT FK_N_FacturasRecibidas_Totales_N_FacturasRecibidas
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas
	DROP CONSTRAINT FK_N_FacturasRecibidas_Lineas_N_FacturasRecibidas
GO
DROP TABLE dbo.N_FacturasRecibidas
GO
EXECUTE sp_rename N'dbo.Tmp_N_FacturasRecibidas', N'N_FacturasRecibidas', 'OBJECT' 
GO
ALTER TABLE dbo.N_FacturasRecibidas ADD CONSTRAINT
	PK_N_FacturasRecibidas PRIMARY KEY CLUSTERED 
	(
	ID_FacturaRecibida
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_FacturasRecibidas ADD CONSTRAINT
	FK_N_FacturasRecibidas_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_FacturasRecibidas ADD CONSTRAINT
	FK_N_FacturasRecibidas_N_FacturasRecibidas_Tipos FOREIGN KEY
	(
	ID_TipoFacturaRecibida
	) REFERENCES dbo.N_FacturasRecibidas_Tipos
	(
	ID_TipoFacturaRecibida
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_FacturasRecibidas ADD CONSTRAINT
	FK_N_FacturasRecibidas_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas ADD CONSTRAINT
	FK_N_FacturasRecibidas_Lineas_N_FacturasRecibidas FOREIGN KEY
	(
	ID_FacturaRecibida
	) REFERENCES dbo.N_FacturasRecibidas
	(
	ID_FacturaRecibida
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas_Totales ADD CONSTRAINT
	FK_N_FacturasRecibidas_Totales_N_FacturasRecibidas FOREIGN KEY
	(
	ID_FacturaRecibida
	) REFERENCES dbo.N_FacturasRecibidas
	(
	ID_FacturaRecibida
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATION N_FACTURAS_RECIBIDAS_LINEAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_FacturasRecibidas_Lineas
	DROP CONSTRAINT FK_N_FacturasRecibidas_Lineas_N_Almacen
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas
	DROP CONSTRAINT FK_N_FacturasRecibidas_Lineas_N_TipoIVA
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas
	DROP CONSTRAINT FK_N_FacturasRecibidas_Lineas_N_FacturasRecibidas
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas
	DROP CONSTRAINT DF_N_FacturasRecibidas_Lineas_Validado
GO
CREATE TABLE dbo.Tmp_N_FacturasRecibidas_Lineas
	(
	ID_FacturaRecibidaLineas bigint NOT NULL IDENTITY (1, 1),
	ID_FacturaRecibida bigint NOT NULL,
	Codigo nvarchar(50) NULL,
	ID_Articulo bigint NULL,
	Descripcion nvarchar(200) NULL,
	Cantidad float(53) NULL,
	Precio float(53) NULL,
	Descuento1 float(53) NULL,
	Descuento2 float(53) NULL,
	Descuento3 float(53) NULL,
	Total float(53) NULL,
	ID_TipoIVA int NULL,
	IVAIncluido bit NOT NULL,
	Costo float(53) NULL,
	Imagen image NULL,
	Observaciones nvarchar(500) NULL,
	ID_Almacen int NULL,
	Validado bit NULL,
	ID_DocOrigen int NULL,
	ID_TipoDocOrigen int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_FacturasRecibidas_Lineas ADD CONSTRAINT
	DF_N_FacturasRecibidas_Lineas_Validado DEFAULT ((0)) FOR Validado
GO
SET IDENTITY_INSERT dbo.Tmp_N_FacturasRecibidas_Lineas ON
GO
IF EXISTS(SELECT * FROM dbo.N_FacturasRecibidas_Lineas)
	 EXEC('INSERT INTO dbo.Tmp_N_FacturasRecibidas_Lineas (ID_FacturaRecibidaLineas, ID_FacturaRecibida, Codigo, ID_Articulo, Descripcion, Cantidad, Precio, Descuento1, Descuento2, Descuento3, Total, ID_TipoIVA, IVAIncluido, Costo, Imagen, Observaciones, ID_Almacen, Validado, ID_DocOrigen, ID_TipoDocOrigen)
		SELECT ID_FacturaRecibidaLineas, ID_FacturaRecibida, Codigo, ID_Articulo, Descripcion, Cantidad, Precio, Descuento1, Descuento2, Descuento3, Total, ID_TipoIVA, IVAIncluido, Costo, Imagen, Observaciones, ID_Almacen, Validado, ID_DocOrigen, ID_TipoDocOrigen FROM dbo.N_FacturasRecibidas_Lineas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_FacturasRecibidas_Lineas OFF
GO
DROP TABLE dbo.N_FacturasRecibidas_Lineas
GO
EXECUTE sp_rename N'dbo.Tmp_N_FacturasRecibidas_Lineas', N'N_FacturasRecibidas_Lineas', 'OBJECT' 
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas ADD CONSTRAINT
	PK_N_FacturasRecibidas_Lineas PRIMARY KEY CLUSTERED 
	(
	ID_FacturaRecibidaLineas
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas ADD CONSTRAINT
	FK_N_FacturasRecibidas_Lineas_N_FacturasRecibidas FOREIGN KEY
	(
	ID_FacturaRecibida
	) REFERENCES dbo.N_FacturasRecibidas
	(
	ID_FacturaRecibida
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas ADD CONSTRAINT
	FK_N_FacturasRecibidas_Lineas_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas ADD CONSTRAINT
	FK_N_FacturasRecibidas_Lineas_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIA COLLATE N_FACTURARECIBIDAS_TIPOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_N_FacturasRecibidas_Tipos
	(
	ID_TipoFacturaRecibida int NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	Descripcion nvarchar(50) NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_N_FacturasRecibidas_Tipos ON
GO
IF EXISTS(SELECT * FROM dbo.N_FacturasRecibidas_Tipos)
	 EXEC('INSERT INTO dbo.Tmp_N_FacturasRecibidas_Tipos (ID_TipoFacturaRecibida, Codigo, Descripcion)
		SELECT ID_TipoFacturaRecibida, Codigo, Descripcion FROM dbo.N_FacturasRecibidas_Tipos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_FacturasRecibidas_Tipos OFF
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT FK_N_FacturasRecibidas_N_FacturasRecibidas_Tipos
GO
DROP TABLE dbo.N_FacturasRecibidas_Tipos
GO
EXECUTE sp_rename N'dbo.Tmp_N_FacturasRecibidas_Tipos', N'N_FacturasRecibidas_Tipos', 'OBJECT' 
GO
ALTER TABLE dbo.N_FacturasRecibidas_Tipos ADD CONSTRAINT
	PK_N_FacturasRecibidas_Tipos PRIMARY KEY CLUSTERED 
	(
	ID_TipoFacturaRecibida
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas ADD CONSTRAINT
	FK_N_FacturasRecibidas_N_FacturasRecibidas_Tipos FOREIGN KEY
	(
	ID_TipoFacturaRecibida
	) REFERENCES dbo.N_FacturasRecibidas_Tipos
	(
	ID_TipoFacturaRecibida
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT


PRINT 'CAMBIA COLLATE N_FAMILIAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_N_Familias
	(
	ID_Familia int NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	Nombre nvarchar(50) NULL,
	ID_Seccion int NULL,
	Texto_predefinido nvarchar(50) NULL,
	CuentaCompras int NULL,
	CuentaVentas nchar(10) NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_N_Familias ON
GO
IF EXISTS(SELECT * FROM dbo.N_Familias)
	 EXEC('INSERT INTO dbo.Tmp_N_Familias (ID_Familia, Codigo, Nombre, ID_Seccion, Texto_predefinido, CuentaCompras, CuentaVentas)
		SELECT ID_Familia, Codigo, Nombre, ID_Seccion, Texto_predefinido, CuentaCompras, CuentaVentas FROM dbo.N_Familias WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Familias OFF
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT FK_N_Articulos_N_Familias
GO
DROP TABLE dbo.N_Familias
GO
EXECUTE sp_rename N'dbo.Tmp_N_Familias', N'N_Familias', 'OBJECT' 
GO
ALTER TABLE dbo.N_Familias ADD CONSTRAINT
	PK_N_Familias PRIMARY KEY CLUSTERED 
	(
	ID_Familia
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos ADD CONSTRAINT
	FK_N_Articulos_N_Familias FOREIGN KEY
	(
	ID_Familia
	) REFERENCES dbo.N_Familias
	(
	ID_Familia
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT ' CAMBIAR COLLATE N_PEDIDOSPROVEEDOR';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT FK_N_PedidosProveedor_N_Proveedores
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT FK_N_PedidosProveedor_N_PedidosProveedor_Tipos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT FK_N_PedidosProveedor_FormasPago
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT DF_N_PedidosProveedor_REPorciento
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT DF_N_PedidosProveedor_ReCantidad
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT DF_N_PedidosProveedor_PortePagado
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT DF_N_PedidosProveedor_PorteDebido
GO
CREATE TABLE dbo.Tmp_N_PedidosProveedor
	(
	ID_PedidoProveedor bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	ID_TipoPedidoProveedor int NULL,
	Referencia nvarchar(50) NULL,
	Fecha datetime NULL,
	ID_Estado int NULL,
	ID_Proveedor int NULL,
	ID_FormaPago varchar(10) NULL,
	IRPFPorciento float(53) NULL,
	IRPFCantidad float(53) NULL,
	Total float(53) NULL,
	Observaciones nvarchar(200) NULL,
	PlazoEntrega datetime NULL,
	Validez nvarchar(50) NULL,
	PortePagado bit NULL,
	PorteDebido bit NULL,
	PorteTexto nvarchar(50) NULL,
	Privado nvarchar(200) NULL,
	DocumentacionAsociada nvarchar(200) NULL,
	Comentarios nvarchar(200) NULL,
	Imagen image NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_PedidosProveedor ADD CONSTRAINT
	DF_N_PedidosProveedor_REPorciento DEFAULT ((0)) FOR IRPFPorciento
GO
ALTER TABLE dbo.Tmp_N_PedidosProveedor ADD CONSTRAINT
	DF_N_PedidosProveedor_ReCantidad DEFAULT ((0)) FOR IRPFCantidad
GO
ALTER TABLE dbo.Tmp_N_PedidosProveedor ADD CONSTRAINT
	DF_N_PedidosProveedor_PortePagado DEFAULT ((1)) FOR PortePagado
GO
ALTER TABLE dbo.Tmp_N_PedidosProveedor ADD CONSTRAINT
	DF_N_PedidosProveedor_PorteDebido DEFAULT ((0)) FOR PorteDebido
GO
SET IDENTITY_INSERT dbo.Tmp_N_PedidosProveedor ON
GO
IF EXISTS(SELECT * FROM dbo.N_PedidosProveedor)
	 EXEC('INSERT INTO dbo.Tmp_N_PedidosProveedor (ID_PedidoProveedor, Codigo, ID_TipoPedidoProveedor, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen)
		SELECT ID_PedidoProveedor, Codigo, ID_TipoPedidoProveedor, Referencia, Fecha, ID_Estado, ID_Proveedor, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen FROM dbo.N_PedidosProveedor WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_PedidosProveedor OFF
GO
ALTER TABLE dbo.N_PedidosProveedor_Totales
	DROP CONSTRAINT FK_N_PedidosProveedor_Totales_N_PedidosProveedor
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas
	DROP CONSTRAINT FK_N_PedidosProveedor_Lineas_N_PedidosProveedor
GO
DROP TABLE dbo.N_PedidosProveedor
GO
EXECUTE sp_rename N'dbo.Tmp_N_PedidosProveedor', N'N_PedidosProveedor', 'OBJECT' 
GO
ALTER TABLE dbo.N_PedidosProveedor ADD CONSTRAINT
	PK_N_PedidosProveedor PRIMARY KEY CLUSTERED 
	(
	ID_PedidoProveedor
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_PedidosProveedor ADD CONSTRAINT
	FK_N_PedidosProveedor_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_PedidosProveedor ADD CONSTRAINT
	FK_N_PedidosProveedor_N_PedidosProveedor_Tipos FOREIGN KEY
	(
	ID_TipoPedidoProveedor
	) REFERENCES dbo.N_PedidosProveedor_Tipos
	(
	ID_TipoPedidoProveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_PedidosProveedor ADD CONSTRAINT
	FK_N_PedidosProveedor_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas ADD CONSTRAINT
	FK_N_PedidosProveedor_Lineas_N_PedidosProveedor FOREIGN KEY
	(
	ID_PedidoProveedor
	) REFERENCES dbo.N_PedidosProveedor
	(
	ID_PedidoProveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor_Totales ADD CONSTRAINT
	FK_N_PedidosProveedor_Totales_N_PedidosProveedor FOREIGN KEY
	(
	ID_PedidoProveedor
	) REFERENCES dbo.N_PedidosProveedor
	(
	ID_PedidoProveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE N_PEDIDOSPROVEEDORES_LINEAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_PedidosProveedor_Lineas
	DROP CONSTRAINT FK_N_PedidosProveedor_Lineas_N_Almacen
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas
	DROP CONSTRAINT FK_N_PedidosProveedor_Lineas_N_TipoIVA
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas
	DROP CONSTRAINT FK_N_PedidosProveedor_Lineas_N_PedidosProveedor
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas
	DROP CONSTRAINT DF_N_PedidosProveedor_Lineas_Validado
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas
	DROP CONSTRAINT DF_N_PedidosProveedor_Lineas_Recibido
GO
CREATE TABLE dbo.Tmp_N_PedidosProveedor_Lineas
	(
	ID_PedidoProveedorLineas bigint NOT NULL IDENTITY (1, 1),
	ID_PedidoProveedor bigint NOT NULL,
	Codigo nvarchar(50) NULL,
	ID_Articulo bigint NULL,
	Descripcion nvarchar(200) NULL,
	Cantidad float(53) NULL,
	Precio float(53) NULL,
	Descuento1 float(53) NULL,
	Descuento2 float(53) NULL,
	Descuento3 float(53) NULL,
	Total float(53) NULL,
	ID_TipoIVA int NULL,
	IVAIncluido bit NOT NULL,
	Costo float(53) NULL,
	Imagen image NULL,
	Observaciones nvarchar(500) NULL,
	ID_Almacen int NULL,
	Validado bit NULL,
	Pendiente bigint NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_PedidosProveedor_Lineas ADD CONSTRAINT
	DF_N_PedidosProveedor_Lineas_Validado DEFAULT ((0)) FOR Validado
GO
ALTER TABLE dbo.Tmp_N_PedidosProveedor_Lineas ADD CONSTRAINT
	DF_N_PedidosProveedor_Lineas_Recibido DEFAULT ((0)) FOR Pendiente
GO
SET IDENTITY_INSERT dbo.Tmp_N_PedidosProveedor_Lineas ON
GO
IF EXISTS(SELECT * FROM dbo.N_PedidosProveedor_Lineas)
	 EXEC('INSERT INTO dbo.Tmp_N_PedidosProveedor_Lineas (ID_PedidoProveedorLineas, ID_PedidoProveedor, Codigo, ID_Articulo, Descripcion, Cantidad, Precio, Descuento1, Descuento2, Descuento3, Total, ID_TipoIVA, IVAIncluido, Costo, Imagen, Observaciones, ID_Almacen, Validado, Pendiente)
		SELECT ID_PedidoProveedorLineas, ID_PedidoProveedor, Codigo, ID_Articulo, Descripcion, Cantidad, Precio, Descuento1, Descuento2, Descuento3, Total, ID_TipoIVA, IVAIncluido, Costo, Imagen, Observaciones, ID_Almacen, Validado, Pendiente FROM dbo.N_PedidosProveedor_Lineas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_PedidosProveedor_Lineas OFF
GO
DROP TABLE dbo.N_PedidosProveedor_Lineas
GO
EXECUTE sp_rename N'dbo.Tmp_N_PedidosProveedor_Lineas', N'N_PedidosProveedor_Lineas', 'OBJECT' 
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas ADD CONSTRAINT
	PK_N_PedidosProveedor_Lineas PRIMARY KEY CLUSTERED 
	(
	ID_PedidoProveedorLineas
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas ADD CONSTRAINT
	FK_N_PedidosProveedor_Lineas_N_PedidosProveedor FOREIGN KEY
	(
	ID_PedidoProveedor
	) REFERENCES dbo.N_PedidosProveedor
	(
	ID_PedidoProveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas ADD CONSTRAINT
	FK_N_PedidosProveedor_Lineas_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas ADD CONSTRAINT
	FK_N_PedidosProveedor_Lineas_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE N_PEDIDOSPROVEEDOR_TIPOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_N_PedidosProveedor_Tipos
	(
	ID_TipoPedidoProveedor int NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	Descripcion nvarchar(50) NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_N_PedidosProveedor_Tipos ON
GO
IF EXISTS(SELECT * FROM dbo.N_PedidosProveedor_Tipos)
	 EXEC('INSERT INTO dbo.Tmp_N_PedidosProveedor_Tipos (ID_TipoPedidoProveedor, Codigo, Descripcion)
		SELECT ID_TipoPedidoProveedor, Codigo, Descripcion FROM dbo.N_PedidosProveedor_Tipos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_PedidosProveedor_Tipos OFF
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT FK_N_PedidosProveedor_N_PedidosProveedor_Tipos
GO
DROP TABLE dbo.N_PedidosProveedor_Tipos
GO
EXECUTE sp_rename N'dbo.Tmp_N_PedidosProveedor_Tipos', N'N_PedidosProveedor_Tipos', 'OBJECT' 
GO
ALTER TABLE dbo.N_PedidosProveedor_Tipos ADD CONSTRAINT
	PK_N_PedidosProveedor_Tipos PRIMARY KEY CLUSTERED 
	(
	ID_TipoPedidoProveedor
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor ADD CONSTRAINT
	FK_N_PedidosProveedor_N_PedidosProveedor_Tipos FOREIGN KEY
	(
	ID_TipoPedidoProveedor
	) REFERENCES dbo.N_PedidosProveedor_Tipos
	(
	ID_TipoPedidoProveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE n_POBLACIONES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_Poblaciones
	DROP CONSTRAINT FK_N_Poblacion_N_Provincias
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_N_Poblaciones
	(
	ID_Poblacion int NOT NULL,
	Nombre nvarchar(50) NULL,
	ID_Provincia int NOT NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.N_Poblaciones)
	 EXEC('INSERT INTO dbo.Tmp_N_Poblaciones (ID_Poblacion, Nombre, ID_Provincia)
		SELECT ID_Poblacion, Nombre, ID_Provincia FROM dbo.N_Poblaciones WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.N_Poblaciones
GO
EXECUTE sp_rename N'dbo.Tmp_N_Poblaciones', N'N_Poblaciones', 'OBJECT' 
GO
ALTER TABLE dbo.N_Poblaciones ADD CONSTRAINT
	PK_N_Poblaciones PRIMARY KEY CLUSTERED 
	(
	ID_Poblacion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Poblaciones ADD CONSTRAINT
	FK_N_Poblacion_N_Provincias FOREIGN KEY
	(
	ID_Provincia
	) REFERENCES dbo.N_Provincias
	(
	ID_Provincias
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE N_PROVEEDORS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT FK_N_Proveedores_N_Bancos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT FK_N_Proveedores_FormasPago
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT DF_N_Proveedores_TipoProveedor
GO
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT DF_N_Proveedores_NombreFiscal
GO
ALTER TABLE dbo.N_Proveedores
	DROP CONSTRAINT DF_N_Proveedores_NombreComercial
GO
CREATE TABLE dbo.Tmp_N_Proveedores
	(
	ID_Proveedor int NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NOT NULL,
	CodigoContabilidad int NULL,
	TipoProveedor int NOT NULL,
	NIF nvarchar(20) NULL,
	NombreFiscal nvarchar(50) NULL,
	NombreComercial nvarchar(50) NULL,
	Domicilio nvarchar(50) NULL,
	ID_Poblacion int NULL,
	CodigoPostal nvarchar(20) NULL,
	Telefono nvarchar(20) NULL,
	Fax nvarchar(20) NULL,
	Movil nvarchar(20) NULL,
	ID_Banco int NULL,
	CCC nvarchar(50) NULL,
	ID_FormaPago varchar(10) NULL,
	DiasPago1 int NULL,
	DiasPago2 int NULL,
	DiasPago3 int NULL,
	AprovisionamientoMeses int NULL,
	AprovisionamientoDias int NULL,
	TarifaEnActivo nvarchar(50) NULL,
	DescuentoFijo1 float(53) NULL,
	DescuentoFijo2 float(53) NULL,
	DescuentoFijo3 float(53) NULL,
	PorcentajeRetension float(53) NULL,
	TipoPorte int NULL,
	Porte nvarchar(50) NULL,
	RappelFijo float(53) NULL,
	PagoRapels nvarchar(100) NULL,
	FechaAlta datetime NULL,
	Web nvarchar(200) NULL,
	Email nvarchar(50) NULL,
	Observaciones nvarchar(500) NULL,
	Horario nvarchar(50) NULL,
	VacacionesDesde nvarchar(50) NULL,
	VacacionesHasta nvarchar(50) NULL,
	NoVenderArticulos bit NULL,
	NoRealizarPagos bit NULL,
	NoImprimir bit NULL,
	TipoIVA int NULL,
	RE bit NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Proveedores ADD CONSTRAINT
	DF_N_Proveedores_TipoProveedor DEFAULT ((1)) FOR TipoProveedor
GO
ALTER TABLE dbo.Tmp_N_Proveedores ADD CONSTRAINT
	DF_N_Proveedores_NombreFiscal DEFAULT ('') FOR NombreFiscal
GO
ALTER TABLE dbo.Tmp_N_Proveedores ADD CONSTRAINT
	DF_N_Proveedores_NombreComercial DEFAULT ('') FOR NombreComercial
GO
SET IDENTITY_INSERT dbo.Tmp_N_Proveedores ON
GO
IF EXISTS(SELECT * FROM dbo.N_Proveedores)
	 EXEC('INSERT INTO dbo.Tmp_N_Proveedores (ID_Proveedor, Codigo, CodigoContabilidad, TipoProveedor, NIF, NombreFiscal, NombreComercial, Domicilio, ID_Poblacion, CodigoPostal, Telefono, Fax, Movil, ID_Banco, CCC, ID_FormaPago, DiasPago1, DiasPago2, DiasPago3, AprovisionamientoMeses, AprovisionamientoDias, TarifaEnActivo, DescuentoFijo1, DescuentoFijo2, DescuentoFijo3, PorcentajeRetension, TipoPorte, Porte, RappelFijo, PagoRapels, FechaAlta, Web, Email, Observaciones, Horario, VacacionesDesde, VacacionesHasta, NoVenderArticulos, NoRealizarPagos, NoImprimir, TipoIVA, RE)
		SELECT ID_Proveedor, Codigo, CodigoContabilidad, TipoProveedor, NIF, NombreFiscal, NombreComercial, Domicilio, ID_Poblacion, CodigoPostal, Telefono, Fax, Movil, ID_Banco, CCC, ID_FormaPago, DiasPago1, DiasPago2, DiasPago3, AprovisionamientoMeses, AprovisionamientoDias, TarifaEnActivo, DescuentoFijo1, DescuentoFijo2, DescuentoFijo3, PorcentajeRetension, TipoPorte, Porte, RappelFijo, PagoRapels, FechaAlta, Web, Email, Observaciones, Horario, VacacionesDesde, VacacionesHasta, NoVenderArticulos, NoRealizarPagos, NoImprimir, TipoIVA, RE FROM dbo.N_Proveedores WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Proveedores OFF
GO
ALTER TABLE dbo.N_Articulos_Proveedores
	DROP CONSTRAINT FK_N_Articulos_Proveedores_N_Proveedores
GO
ALTER TABLE dbo.N_Entradas
	DROP CONSTRAINT FK_N_Entradas_N_Proveedores
GO
ALTER TABLE dbo.N_FacturasRecibidas
	DROP CONSTRAINT FK_N_FacturasRecibidas_N_Proveedores
GO
ALTER TABLE dbo.N_PedidosProveedor
	DROP CONSTRAINT FK_N_PedidosProveedor_N_Proveedores
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT FK_N_Articulos_N_Proveedores
GO
DROP TABLE dbo.N_Proveedores
GO
EXECUTE sp_rename N'dbo.Tmp_N_Proveedores', N'N_Proveedores', 'OBJECT' 
GO
ALTER TABLE dbo.N_Proveedores ADD CONSTRAINT
	PK_N_Proveedores PRIMARY KEY CLUSTERED 
	(
	ID_Proveedor
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Proveedores ADD CONSTRAINT
	FK_N_Proveedores_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Proveedores ADD CONSTRAINT
	FK_N_Proveedores_N_Bancos FOREIGN KEY
	(
	ID_Banco
	) REFERENCES dbo.BANCOS
	(
	IdBanco
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos ADD CONSTRAINT
	FK_N_Articulos_N_Proveedores FOREIGN KEY
	(
	ID_ProveedorHabitual
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor ADD CONSTRAINT
	FK_N_PedidosProveedor_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas ADD CONSTRAINT
	FK_N_FacturasRecibidas_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas ADD CONSTRAINT
	FK_N_Entradas_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos_Proveedores ADD CONSTRAINT
	FK_N_Articulos_Proveedores_N_Proveedores FOREIGN KEY
	(
	ID_Proveedor
	) REFERENCES dbo.N_Proveedores
	(
	ID_Proveedor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE N_PROVINCIAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_Provincias
	DROP CONSTRAINT FK_N_Provincias_PAISES
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_N_Provincias
	(
	ID_Provincias int NOT NULL IDENTITY (1, 1),
	Nombre nvarchar(50) NOT NULL,
	ID_Pais int NOT NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_N_Provincias ON
GO
IF EXISTS(SELECT * FROM dbo.N_Provincias)
	 EXEC('INSERT INTO dbo.Tmp_N_Provincias (ID_Provincias, Nombre, ID_Pais)
		SELECT ID_Provincias, Nombre, ID_Pais FROM dbo.N_Provincias WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Provincias OFF
GO
ALTER TABLE dbo.N_Poblaciones
	DROP CONSTRAINT FK_N_Poblacion_N_Provincias
GO
DROP TABLE dbo.N_Provincias
GO
EXECUTE sp_rename N'dbo.Tmp_N_Provincias', N'N_Provincias', 'OBJECT' 
GO
ALTER TABLE dbo.N_Provincias ADD CONSTRAINT
	PK_N_Provincias PRIMARY KEY CLUSTERED 
	(
	ID_Provincias
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Provincias ADD CONSTRAINT
	FK_N_Provincias_PAISES FOREIGN KEY
	(
	ID_Pais
	) REFERENCES dbo.PAISES
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Poblaciones ADD CONSTRAINT
	FK_N_Poblacion_N_Provincias FOREIGN KEY
	(
	ID_Provincia
	) REFERENCES dbo.N_Provincias
	(
	ID_Provincias
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT


PRINT 'CAMBIAR COLLATE N_TICKET';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT FK_N_Ticket_N_Ticket_Tipos
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT FK_N_Ticket_FormasPago
GO
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT FK_N_Ticket_EntregasCuenta
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT FK_N_Ticket_N_Pacientes
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_Ticket_Fecha
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_REPorciento
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_ReCantidad
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_PortePagado
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_PorteDebido
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_Pagado
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_FechaPagado
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_Eliminado
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT DF_N_Ticket_PagadoConCredito
GO
CREATE TABLE dbo.Tmp_N_Ticket
	(
	ID_Ticket bigint NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	ID_TipoTicket int NULL,
	Referencia nvarchar(50) NULL,
	Fecha datetime NOT NULL,
	ID_Estado int NULL,
	ID_Cliente int NULL,
	ID_FormaPago varchar(10) NULL,
	IRPFPorciento float(53) NULL,
	IRPFCantidad float(53) NULL,
	Total float(53) NULL,
	Observaciones nvarchar(200) NULL,
	PlazoEntrega datetime NULL,
	Validez nvarchar(50) NULL,
	PortePagado bit NULL,
	PorteDebido bit NULL,
	PorteTexto nvarchar(50) NULL,
	Privado nvarchar(200) NULL,
	DocumentacionAsociada nvarchar(200) NULL,
	Comentarios nvarchar(200) NULL,
	Imagen image NULL,
	Pagado bit NOT NULL,
	FechaPagado datetime NULL,
	NombrePaciente nvarchar(50) NULL,
	FormaPago nvarchar(50) NULL,
	Eliminado bit NULL,
	IDEntregaCuenta bigint NULL,
	PagadoConCredito bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_Ticket_Fecha DEFAULT (getdate()) FOR Fecha
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_REPorciento DEFAULT ((0)) FOR IRPFPorciento
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_ReCantidad DEFAULT ((0)) FOR IRPFCantidad
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_PortePagado DEFAULT ((1)) FOR PortePagado
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_PorteDebido DEFAULT ((0)) FOR PorteDebido
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_Pagado DEFAULT ((0)) FOR Pagado
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_FechaPagado DEFAULT (getdate()) FOR FechaPagado
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_Eliminado DEFAULT ((0)) FOR Eliminado
GO
ALTER TABLE dbo.Tmp_N_Ticket ADD CONSTRAINT
	DF_N_Ticket_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
SET IDENTITY_INSERT dbo.Tmp_N_Ticket ON
GO
IF EXISTS(SELECT * FROM dbo.N_Ticket)
	 EXEC('INSERT INTO dbo.Tmp_N_Ticket (ID_Ticket, Codigo, ID_TipoTicket, Referencia, Fecha, ID_Estado, ID_Cliente, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, Pagado, FechaPagado, NombrePaciente, FormaPago, Eliminado, IDEntregaCuenta, PagadoConCredito)
		SELECT ID_Ticket, Codigo, ID_TipoTicket, Referencia, Fecha, ID_Estado, ID_Cliente, ID_FormaPago, IRPFPorciento, IRPFCantidad, Total, Observaciones, PlazoEntrega, Validez, PortePagado, PorteDebido, PorteTexto, Privado, DocumentacionAsociada, Comentarios, Imagen, Pagado, FechaPagado, NombrePaciente, FormaPago, Eliminado, IDEntregaCuenta, PagadoConCredito FROM dbo.N_Ticket WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Ticket OFF
GO
ALTER TABLE dbo.N_Ticket_Totales
	DROP CONSTRAINT FK_N_Ticket_Totales_N_Ticket
GO
ALTER TABLE dbo.N_Ticket_Lineas
	DROP CONSTRAINT FK_N_Ticket_Lineas_N_Ticket
GO
DROP TABLE dbo.N_Ticket
GO
EXECUTE sp_rename N'dbo.Tmp_N_Ticket', N'N_Ticket', 'OBJECT' 
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	PK_N_Ticket PRIMARY KEY CLUSTERED 
	(
	ID_Ticket
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	FK_N_Ticket_N_Pacientes FOREIGN KEY
	(
	ID_Cliente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	FK_N_Ticket_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	FK_N_Ticket_FormasPago FOREIGN KEY
	(
	ID_FormaPago
	) REFERENCES dbo.FORMASPAGO
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	FK_N_Ticket_N_Ticket_Tipos FOREIGN KEY
	(
	ID_TipoTicket
	) REFERENCES dbo.N_Ticket_Tipos
	(
	ID_TipoTicket
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket_Lineas ADD CONSTRAINT
	FK_N_Ticket_Lineas_N_Ticket FOREIGN KEY
	(
	ID_Ticket
	) REFERENCES dbo.N_Ticket
	(
	ID_Ticket
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket_Totales ADD CONSTRAINT
	FK_N_Ticket_Totales_N_Ticket FOREIGN KEY
	(
	ID_Ticket
	) REFERENCES dbo.N_Ticket
	(
	ID_Ticket
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE N_TICKETS_LINEAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
	DROP CONSTRAINT FK_N_Ticket_Lineas_N_Almacen
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket_Lineas
	DROP CONSTRAINT FK_N_Ticket_Lineas_N_Ticket
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket_Lineas
	DROP CONSTRAINT DF_N_Ticket_Lineas_Validado
GO
ALTER TABLE dbo.N_Ticket_Lineas
	DROP CONSTRAINT DF_N_Ticket_Lineas_IVAPorciento
GO
ALTER TABLE dbo.N_Ticket_Lineas
	DROP CONSTRAINT DF_N_Ticket_Lineas_IVAImporte
GO
CREATE TABLE dbo.Tmp_N_Ticket_Lineas
	(
	ID_TicketLineas bigint NOT NULL IDENTITY (1, 1),
	ID_Ticket bigint NOT NULL,
	Codigo nvarchar(50) NULL,
	ID_Articulo bigint NULL,
	Descripcion nvarchar(200) NULL,
	Cantidad float(53) NULL,
	Precio float(53) NULL,
	Descuento1 float(53) NULL,
	Descuento2 float(53) NULL,
	Descuento3 float(53) NULL,
	Total float(53) NULL,
	IVAIncluido bit NOT NULL,
	Costo float(53) NULL,
	Imagen image NULL,
	Observaciones nvarchar(500) NULL,
	ID_Almacen int NULL,
	Validado bit NULL,
	ID_DocOrigen bigint NULL,
	ID_TipoDocOrigen int NULL,
	IVAPorciento float(53) NULL,
	IVAImporte float(53) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_N_Ticket_Lineas ADD CONSTRAINT
	DF_N_Ticket_Lineas_Validado DEFAULT ((0)) FOR Validado
GO
ALTER TABLE dbo.Tmp_N_Ticket_Lineas ADD CONSTRAINT
	DF_N_Ticket_Lineas_IVAPorciento DEFAULT ((0)) FOR IVAPorciento
GO
ALTER TABLE dbo.Tmp_N_Ticket_Lineas ADD CONSTRAINT
	DF_N_Ticket_Lineas_IVAImporte DEFAULT ((0)) FOR IVAImporte
GO
SET IDENTITY_INSERT dbo.Tmp_N_Ticket_Lineas ON
GO
IF EXISTS(SELECT * FROM dbo.N_Ticket_Lineas)
	 EXEC('INSERT INTO dbo.Tmp_N_Ticket_Lineas (ID_TicketLineas, ID_Ticket, Codigo, ID_Articulo, Descripcion, Cantidad, Precio, Descuento1, Descuento2, Descuento3, Total, IVAIncluido, Costo, Imagen, Observaciones, ID_Almacen, Validado, ID_DocOrigen, ID_TipoDocOrigen, IVAPorciento, IVAImporte)
		SELECT ID_TicketLineas, ID_Ticket, Codigo, ID_Articulo, Descripcion, Cantidad, Precio, Descuento1, Descuento2, Descuento3, Total, IVAIncluido, Costo, Imagen, Observaciones, ID_Almacen, Validado, ID_DocOrigen, ID_TipoDocOrigen, IVAPorciento, IVAImporte FROM dbo.N_Ticket_Lineas WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Ticket_Lineas OFF
GO
DROP TABLE dbo.N_Ticket_Lineas
GO
EXECUTE sp_rename N'dbo.Tmp_N_Ticket_Lineas', N'N_Ticket_Lineas', 'OBJECT' 
GO
ALTER TABLE dbo.N_Ticket_Lineas ADD CONSTRAINT
	PK_N_Ticket_Lineas PRIMARY KEY CLUSTERED 
	(
	ID_TicketLineas
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.N_Ticket_Lineas ADD CONSTRAINT
	FK_N_Ticket_Lineas_N_Ticket FOREIGN KEY
	(
	ID_Ticket
	) REFERENCES dbo.N_Ticket
	(
	ID_Ticket
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.N_Ticket_Lineas ADD CONSTRAINT
	FK_N_Ticket_Lineas_N_Almacen FOREIGN KEY
	(
	ID_Almacen
	) REFERENCES dbo.N_Almacen
	(
	ID_Almacen
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE N_TICKET_TIPOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_N_Ticket_Tipos
	(
	ID_TipoTicket int NOT NULL IDENTITY (1, 1),
	Codigo nvarchar(50) NULL,
	Descripcion nvarchar(50) NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_N_Ticket_Tipos ON
GO
IF EXISTS(SELECT * FROM dbo.N_Ticket_Tipos)
	 EXEC('INSERT INTO dbo.Tmp_N_Ticket_Tipos (ID_TipoTicket, Codigo, Descripcion)
		SELECT ID_TipoTicket, Codigo, Descripcion FROM dbo.N_Ticket_Tipos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_Ticket_Tipos OFF
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT FK_N_Ticket_N_Ticket_Tipos
GO
DROP TABLE dbo.N_Ticket_Tipos
GO
EXECUTE sp_rename N'dbo.Tmp_N_Ticket_Tipos', N'N_Ticket_Tipos', 'OBJECT' 
GO
ALTER TABLE dbo.N_Ticket_Tipos ADD CONSTRAINT
	PK_N_Ticket_Tipos PRIMARY KEY CLUSTERED 
	(
	ID_TipoTicket
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	FK_N_Ticket_N_Ticket_Tipos FOREIGN KEY
	(
	ID_TipoTicket
	) REFERENCES dbo.N_Ticket_Tipos
	(
	ID_TipoTicket
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE N_TIPO_IVA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_N_TipoIVA
	(
	ID_TipoIVA int NOT NULL IDENTITY (1, 1),
	Nombre nvarchar(50) NULL,
	Valor float(53) NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_N_TipoIVA ON
GO
IF EXISTS(SELECT * FROM dbo.N_TipoIVA)
	 EXEC('INSERT INTO dbo.Tmp_N_TipoIVA (ID_TipoIVA, Nombre, Valor)
		SELECT ID_TipoIVA, Nombre, Valor FROM dbo.N_TipoIVA WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_N_TipoIVA OFF
GO
ALTER TABLE dbo.N_Factura_Lineas
	DROP CONSTRAINT FK_N_Factura_Lineas_N_TipoIVA
GO
ALTER TABLE dbo.N_Entradas_Lineas
	DROP CONSTRAINT FK_N_Entradas_Lineas_N_TipoIVA
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas
	DROP CONSTRAINT FK_N_FacturasRecibidas_Lineas_N_TipoIVA
GO
ALTER TABLE dbo.N_Ticket_Totales
	DROP CONSTRAINT FK_N_Ticket_Totales_N_TipoIVA
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas
	DROP CONSTRAINT FK_N_PedidosProveedor_Lineas_N_TipoIVA
GO
ALTER TABLE dbo.N_Entradas_Totales
	DROP CONSTRAINT FK_N_Entradas_Totales_N_TipoIVA
GO
ALTER TABLE dbo.N_PedidosProveedor_Totales
	DROP CONSTRAINT FK_N_PedidosProveedor_Totales_N_TipoIVA
GO
ALTER TABLE dbo.N_Articulos
	DROP CONSTRAINT FK_N_Articulos_N_TipoIVA
GO
ALTER TABLE dbo.N_Factura_Totales
	DROP CONSTRAINT FK_N_Factura_Totales_N_TipoIVA
GO
ALTER TABLE dbo.N_FacturasRecibidas_Totales
	DROP CONSTRAINT FK_N_FacturasRecibidas_Totales_N_TipoIVA
GO
DROP TABLE dbo.N_TipoIVA
GO
EXECUTE sp_rename N'dbo.Tmp_N_TipoIVA', N'N_TipoIVA', 'OBJECT' 
GO
ALTER TABLE dbo.N_TipoIVA ADD CONSTRAINT
	PK_N_TipoIVA PRIMARY KEY CLUSTERED 
	(
	ID_TipoIVA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas_Totales ADD CONSTRAINT
	FK_N_FacturasRecibidas_Totales_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura_Totales ADD CONSTRAINT
	FK_N_Factura_Totales_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Articulos ADD CONSTRAINT
	FK_N_Articulos_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor_Totales ADD CONSTRAINT
	FK_N_PedidosProveedor_Totales_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas_Totales ADD CONSTRAINT
	FK_N_Entradas_Totales_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_PedidosProveedor_Lineas ADD CONSTRAINT
	FK_N_PedidosProveedor_Lineas_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket_Totales ADD CONSTRAINT
	FK_N_Ticket_Totales_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_FacturasRecibidas_Lineas ADD CONSTRAINT
	FK_N_FacturasRecibidas_Lineas_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Entradas_Lineas ADD CONSTRAINT
	FK_N_Entradas_Lineas_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura_Lineas ADD CONSTRAINT
	FK_N_Factura_Lineas_N_TipoIVA FOREIGN KEY
	(
	ID_TipoIVA
	) REFERENCES dbo.N_TipoIVA
	(
	ID_TipoIVA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE PACIENTES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.PACIENTES
	DROP CONSTRAINT DF__PACIENTES__PAGOBANCO
GO
ALTER TABLE dbo.PACIENTES
	DROP CONSTRAINT DF__PACIENTES__DEFUN
GO
ALTER TABLE dbo.PACIENTES
	DROP CONSTRAINT DF__PACIENTES__SOCIO
GO
ALTER TABLE dbo.PACIENTES
	DROP CONSTRAINT DF__PACIENTES__ACTIV
GO
ALTER TABLE dbo.PACIENTES
	DROP CONSTRAINT DF_PACIENTES_WEB
GO
ALTER TABLE dbo.PACIENTES
	DROP CONSTRAINT DF_PACIENTES_EMAIL
GO
ALTER TABLE dbo.PACIENTES
	DROP CONSTRAINT DF_PACIENTES_CODIGOPROPIO
GO
ALTER TABLE dbo.PACIENTES
	DROP CONSTRAINT DF_PACIENTES_BENEFICIARIOCODIGOSOCIO
GO
ALTER TABLE dbo.PACIENTES
	DROP CONSTRAINT DF_PACIENTES_BENEFICIARIOPARENTESCO
GO
ALTER TABLE dbo.PACIENTES
	DROP CONSTRAINT DF_PACIENTES_Eliminado
GO
CREATE TABLE dbo.Tmp_PACIENTES
	(
	NOMBRE varchar(255) NULL,
	APELLIDO1 varchar(255) NULL,
	APELLIDO2 varchar(255) NULL,
	DOMICILIO varchar(150) NULL,
	TLFNO nvarchar(200) NULL,
	MOVIL nvarchar(200) NULL,
	PROFESION varchar(30) NULL,
	LOCALIDAD varchar(200) NULL,
	CP varchar(5) NULL,
	REFEMPRESA int NULL,
	DNI varchar(8) NULL,
	FECHAN datetime NULL,
	OBSERVACIONES varchar(500) NULL,
	PROVINCIA varchar(300) NULL,
	NSS varchar(12) NULL,
	PUESTO varchar(30) NULL,
	REGIMEN varchar(1) NULL,
	TARJETASANITARIA varchar(50) NULL,
	REFMUTUA int NULL,
	CPACIENTE int NOT NULL,
	SEXO varchar(1) NULL,
	FECHAALTA datetime NULL,
	TUTOR varchar(90) NULL,
	PAGOBANCO varchar(1) NULL,
	ENTIDAD varchar(4) NULL,
	OFICINA varchar(4) NULL,
	DC varchar(2) NULL,
	TITULAR varchar(90) NULL,
	CUENTA varchar(10) NULL,
	DEFUNCION varchar(1) NULL,
	NIE varchar(15) NULL,
	PASAPORTE varchar(25) NULL,
	REFPAIS int NOT NULL,
	FOTO image NULL,
	FOTOGRAFIA varchar(150) NULL,
	SOCIO varchar(1) NULL,
	ACTIVO varchar(1) NULL,
	REFFORMAPAGO varchar(10) NULL,
	FECHABAJA datetime NULL,
	CONOCIO varchar(250) NULL,
	WEB varchar(250) NOT NULL,
	EMAIL varchar(250) NOT NULL,
	CODIGOPROPIO varchar(50) NOT NULL,
	BENEFICIARIOCODIGOSOCIO int NOT NULL,
	BENEFICIARIOPARENTESCO varchar(150) NOT NULL,
	Eliminado bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_PACIENTES ADD CONSTRAINT
	DF__PACIENTES__PAGOBANCO DEFAULT ('N') FOR PAGOBANCO
GO
ALTER TABLE dbo.Tmp_PACIENTES ADD CONSTRAINT
	DF__PACIENTES__DEFUN DEFAULT ('N') FOR DEFUNCION
GO
ALTER TABLE dbo.Tmp_PACIENTES ADD CONSTRAINT
	DF__PACIENTES__SOCIO DEFAULT ('N') FOR SOCIO
GO
ALTER TABLE dbo.Tmp_PACIENTES ADD CONSTRAINT
	DF__PACIENTES__ACTIV DEFAULT ('S') FOR ACTIVO
GO
ALTER TABLE dbo.Tmp_PACIENTES ADD CONSTRAINT
	DF_PACIENTES_WEB DEFAULT ('') FOR WEB
GO
ALTER TABLE dbo.Tmp_PACIENTES ADD CONSTRAINT
	DF_PACIENTES_EMAIL DEFAULT ('') FOR EMAIL
GO
ALTER TABLE dbo.Tmp_PACIENTES ADD CONSTRAINT
	DF_PACIENTES_CODIGOPROPIO DEFAULT ('') FOR CODIGOPROPIO
GO
ALTER TABLE dbo.Tmp_PACIENTES ADD CONSTRAINT
	DF_PACIENTES_BENEFICIARIOCODIGOSOCIO DEFAULT ('') FOR BENEFICIARIOCODIGOSOCIO
GO
ALTER TABLE dbo.Tmp_PACIENTES ADD CONSTRAINT
	DF_PACIENTES_BENEFICIARIOPARENTESCO DEFAULT ('') FOR BENEFICIARIOPARENTESCO
GO
ALTER TABLE dbo.Tmp_PACIENTES ADD CONSTRAINT
	DF_PACIENTES_Eliminado DEFAULT ((0)) FOR Eliminado
GO
IF EXISTS(SELECT * FROM dbo.PACIENTES)
	 EXEC('INSERT INTO dbo.Tmp_PACIENTES (NOMBRE, APELLIDO1, APELLIDO2, DOMICILIO, TLFNO, MOVIL, PROFESION, LOCALIDAD, CP, REFEMPRESA, DNI, FECHAN, OBSERVACIONES, PROVINCIA, NSS, PUESTO, REGIMEN, TARJETASANITARIA, REFMUTUA, CPACIENTE, SEXO, FECHAALTA, TUTOR, PAGOBANCO, ENTIDAD, OFICINA, DC, TITULAR, CUENTA, DEFUNCION, NIE, PASAPORTE, REFPAIS, FOTO, FOTOGRAFIA, SOCIO, ACTIVO, REFFORMAPAGO, FECHABAJA, CONOCIO, WEB, EMAIL, CODIGOPROPIO, BENEFICIARIOCODIGOSOCIO, BENEFICIARIOPARENTESCO, Eliminado)
		SELECT NOMBRE, APELLIDO1, APELLIDO2, DOMICILIO, TLFNO, MOVIL, PROFESION, LOCALIDAD, CP, REFEMPRESA, DNI, FECHAN, OBSERVACIONES, PROVINCIA, NSS, PUESTO, REGIMEN, TARJETASANITARIA, REFMUTUA, CPACIENTE, SEXO, FECHAALTA, TUTOR, PAGOBANCO, ENTIDAD, OFICINA, DC, TITULAR, CUENTA, DEFUNCION, NIE, PASAPORTE, REFPAIS, FOTO, FOTOGRAFIA, SOCIO, ACTIVO, REFFORMAPAGO, FECHABAJA, CONOCIO, WEB, EMAIL, CODIGOPROPIO, BENEFICIARIOCODIGOSOCIO, BENEFICIARIOPARENTESCO, Eliminado FROM dbo.PACIENTES WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.LINEASALARMA
	DROP CONSTRAINT fklineasalarmapaciente
GO
ALTER TABLE dbo.N_Partes_Asistencia
	DROP CONSTRAINT FK_N_Partes_Asistencia_PACIENTES
GO
ALTER TABLE dbo.PagosPaciente
	DROP CONSTRAINT FK_PagosCliente_PACIENTES
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fkrecetaspaciente
GO
ALTER TABLE dbo.d_Odontogramas
	DROP CONSTRAINT FK_d_Odontogramas_PACIENTES
GO
ALTER TABLE dbo.Asociados
	DROP CONSTRAINT FK_Asociados_PACIENTES
GO
ALTER TABLE dbo.N_Procesos
	DROP CONSTRAINT FK_N_Procesos_PACIENTES
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT FK_RECIBOS_PACIENTES
GO
ALTER TABLE dbo.PRESUPUESTOS
	DROP CONSTRAINT fkpresupuestopaciente
GO
ALTER TABLE dbo.COMPARATIVAS
	DROP CONSTRAINT fk_comparativaspaciente
GO
ALTER TABLE dbo.HISTORIALES_REVISIONES
	DROP CONSTRAINT FK_HISTORIALES_REVISIONES_PACIENTES
GO
ALTER TABLE dbo.ANALITICAS
	DROP CONSTRAINT fk_analiticapaciente
GO
ALTER TABLE dbo.AntecedentesDiagnosticos
	DROP CONSTRAINT FK_AntecedentesDiagnosticos_PACIENTES
GO
ALTER TABLE dbo.LMUTUAS
	DROP CONSTRAINT fk_lmutuas_pacientes
GO
ALTER TABLE dbo.EntregasCuenta
	DROP CONSTRAINT FK_EntregasCuenta_PACIENTES
GO
ALTER TABLE dbo.FACTURAS
	DROP CONSTRAINT fkfacturaspaciente
GO
ALTER TABLE dbo.FICHEROS
	DROP CONSTRAINT fk_ficheros
GO
ALTER TABLE dbo.HISTORIALES
	DROP CONSTRAINT fkhistorialespaciente
GO
ALTER TABLE dbo.AUDIOMETRIAS
	DROP CONSTRAINT fk_audiometrias
GO
ALTER TABLE dbo.N_Ticket
	DROP CONSTRAINT FK_N_Ticket_N_Pacientes
GO
ALTER TABLE dbo.IMAGENES
	DROP CONSTRAINT fkimagenespaciente
GO
ALTER TABLE dbo.INFORMACIONPRIMARIA
	DROP CONSTRAINT fk_informacionprimariapaciente
GO
ALTER TABLE dbo.INFORME_MEDICO
	DROP CONSTRAINT FK_INFORME_MEDICO_PACIENTES
GO
ALTER TABLE dbo.N_Factura
	DROP CONSTRAINT FK_N_Factura_N_Pacientes
GO
ALTER TABLE dbo.Comunicaciones
	DROP CONSTRAINT FK_Comunicaciones_PACIENTES
GO
ALTER TABLE dbo.Asociados
	DROP CONSTRAINT FK_Asociados_PACIENTES1
GO
ALTER TABLE dbo.DERIVACIONES
	DROP CONSTRAINT fk_derivacionespaciente
GO
ALTER TABLE dbo.LEMPRESAS
	DROP CONSTRAINT fk_lempresaspacientes
GO
DROP TABLE dbo.PACIENTES
GO
EXECUTE sp_rename N'dbo.Tmp_PACIENTES', N'PACIENTES', 'OBJECT' 
GO
ALTER TABLE dbo.PACIENTES ADD CONSTRAINT
	PK_PACIENTES PRIMARY KEY CLUSTERED 
	(
	CPACIENTE
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LEMPRESAS ADD CONSTRAINT
	fk_lempresaspacientes FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DERIVACIONES ADD CONSTRAINT
	fk_derivacionespaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comunicaciones ADD CONSTRAINT
	FK_Comunicaciones_PACIENTES FOREIGN KEY
	(
	ID_PacienteDestino
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Factura ADD CONSTRAINT
	FK_N_Factura_N_Pacientes FOREIGN KEY
	(
	ID_Cliente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.INFORME_MEDICO ADD CONSTRAINT
	FK_INFORME_MEDICO_PACIENTES FOREIGN KEY
	(
	RefPaciente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.INFORMACIONPRIMARIA ADD CONSTRAINT
	fk_informacionprimariapaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.IMAGENES ADD CONSTRAINT
	fkimagenespaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Ticket ADD CONSTRAINT
	FK_N_Ticket_N_Pacientes FOREIGN KEY
	(
	ID_Cliente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.AUDIOMETRIAS ADD CONSTRAINT
	fk_audiometrias FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HISTORIALES ADD CONSTRAINT
	fkhistorialespaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FICHEROS ADD CONSTRAINT
	fk_ficheros FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURAS ADD CONSTRAINT
	fkfacturaspaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.EntregasCuenta ADD CONSTRAINT
	FK_EntregasCuenta_PACIENTES FOREIGN KEY
	(
	IDPaciente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LMUTUAS ADD CONSTRAINT
	fk_lmutuas_pacientes FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.AntecedentesDiagnosticos ADD CONSTRAINT
	FK_AntecedentesDiagnosticos_PACIENTES FOREIGN KEY
	(
	CPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ANALITICAS ADD CONSTRAINT
	fk_analiticapaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HISTORIALES_REVISIONES ADD CONSTRAINT
	FK_HISTORIALES_REVISIONES_PACIENTES FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.COMPARATIVAS ADD CONSTRAINT
	fk_comparativaspaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PRESUPUESTOS ADD CONSTRAINT
	fkpresupuestopaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECIBOS ADD CONSTRAINT
	FK_RECIBOS_PACIENTES FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Procesos ADD CONSTRAINT
	FK_N_Procesos_PACIENTES FOREIGN KEY
	(
	ID_Paciente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Asociados ADD CONSTRAINT
	FK_Asociados_PACIENTES FOREIGN KEY
	(
	IDPacienteBeneficiario
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Asociados ADD CONSTRAINT
	FK_Asociados_PACIENTES1 FOREIGN KEY
	(
	IDPacienteOrigen
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.d_Odontogramas ADD CONSTRAINT
	FK_d_Odontogramas_PACIENTES FOREIGN KEY
	(
	IDPaciente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fkrecetaspaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PagosPaciente ADD CONSTRAINT
	FK_PagosCliente_PACIENTES FOREIGN KEY
	(
	IDPaciente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Partes_Asistencia ADD CONSTRAINT
	FK_N_Partes_Asistencia_PACIENTES FOREIGN KEY
	(
	ID_Paciente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LINEASALARMA ADD CONSTRAINT
	fklineasalarmapaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE PAIS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_PAISES
	(
	CODIGO int NOT NULL,
	NOMBRE varchar(90) NULL,
	NOTAS text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.PAISES)
	 EXEC('INSERT INTO dbo.Tmp_PAISES (CODIGO, NOMBRE, NOTAS)
		SELECT CODIGO, NOMBRE, NOTAS FROM dbo.PAISES WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.N_Provincias
	DROP CONSTRAINT FK_N_Provincias_PAISES
GO
DROP TABLE dbo.PAISES
GO
EXECUTE sp_rename N'dbo.Tmp_PAISES', N'PAISES', 'OBJECT' 
GO
ALTER TABLE dbo.PAISES ADD CONSTRAINT
	PK_PAISES PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.N_Provincias ADD CONSTRAINT
	FK_N_Provincias_PAISES FOREIGN KEY
	(
	ID_Pais
	) REFERENCES dbo.PAISES
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE PARENTESCOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.Parentescos
	DROP CONSTRAINT DF_Parentescos_Descripcion
GO
CREATE TABLE dbo.Tmp_Parentescos
	(
	IdParentesco int NOT NULL,
	Descripcion varchar(150) NOT NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_Parentescos ADD CONSTRAINT
	DF_Parentescos_Descripcion DEFAULT ('') FOR Descripcion
GO
IF EXISTS(SELECT * FROM dbo.Parentescos)
	 EXEC('INSERT INTO dbo.Tmp_Parentescos (IdParentesco, Descripcion)
		SELECT IdParentesco, Descripcion FROM dbo.Parentescos WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.Asociados
	DROP CONSTRAINT FK_Asociados_Parentescos
GO
DROP TABLE dbo.Parentescos
GO
EXECUTE sp_rename N'dbo.Tmp_Parentescos', N'Parentescos', 'OBJECT' 
GO
ALTER TABLE dbo.Parentescos ADD CONSTRAINT
	PK_Parentescos PRIMARY KEY CLUSTERED 
	(
	IdParentesco
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Asociados ADD CONSTRAINT
	FK_Asociados_Parentescos FOREIGN KEY
	(
	IDParentesco
	) REFERENCES dbo.Parentescos
	(
	IdParentesco
	) ON UPDATE  SET NULL 
	 ON DELETE  NO ACTION 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE PARTES';

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.PARTES
	DROP CONSTRAINT DF__PARTES__REFFRA__5535A963
GO
CREATE TABLE dbo.Tmp_PARTES
	(
	IDPARTE int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	REFPACIENTE int NULL,
	PACIENTE varchar(50) NULL,
	TARJETA varchar(12) NULL,
	NSS varchar(12) NULL,
	DNI varchar(8) NULL,
	PDOMICILIO varchar(30) NULL,
	PLOCALIDAD varchar(20) NULL,
	PCP varchar(5) NULL,
	PPROVINCIA varchar(20) NULL,
	PTLFNO varchar(10) NULL,
	PUESTO varchar(30) NULL,
	REGIMEN varchar(1) NULL,
	SITUACION varchar(1) NULL,
	REFEMPRESA int NULL,
	EMPRESA varchar(30) NULL,
	EDOMICILIO varchar(30) NULL,
	ELOCALIDAD varchar(20) NULL,
	ECP varchar(5) NULL,
	EPROVINCIA varchar(20) NULL,
	ETLFNO varchar(10) NULL,
	ACTIVIDAD varchar(20) NULL,
	CNAE varchar(5) NULL,
	REFMUTUA int NULL,
	MUTUA varchar(50) NULL,
	COLEGIADO varchar(5) NULL,
	ENSS varchar(20) NULL,
	ECIF varchar(12) NULL,
	FECHA datetime NULL,
	TIPO varchar(15) NULL,
	REFFRA int NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_PARTES ADD CONSTRAINT
	DF__PARTES__REFFRA__5535A963 DEFAULT ((0)) FOR REFFRA
GO
SET IDENTITY_INSERT dbo.Tmp_PARTES ON
GO
IF EXISTS(SELECT * FROM dbo.PARTES)
	 EXEC('INSERT INTO dbo.Tmp_PARTES (IDPARTE, REFPACIENTE, PACIENTE, TARJETA, NSS, DNI, PDOMICILIO, PLOCALIDAD, PCP, PPROVINCIA, PTLFNO, PUESTO, REGIMEN, SITUACION, REFEMPRESA, EMPRESA, EDOMICILIO, ELOCALIDAD, ECP, EPROVINCIA, ETLFNO, ACTIVIDAD, CNAE, REFMUTUA, MUTUA, COLEGIADO, ENSS, ECIF, FECHA, TIPO, REFFRA)
		SELECT IDPARTE, REFPACIENTE, PACIENTE, TARJETA, NSS, DNI, PDOMICILIO, PLOCALIDAD, PCP, PPROVINCIA, PTLFNO, PUESTO, REGIMEN, SITUACION, REFEMPRESA, EMPRESA, EDOMICILIO, ELOCALIDAD, ECP, EPROVINCIA, ETLFNO, ACTIVIDAD, CNAE, REFMUTUA, MUTUA, COLEGIADO, ENSS, ECIF, FECHA, TIPO, REFFRA FROM dbo.PARTES WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_PARTES OFF
GO
DROP TABLE dbo.PARTES
GO
EXECUTE sp_rename N'dbo.Tmp_PARTES', N'PARTES', 'OBJECT' 
GO
ALTER TABLE dbo.PARTES ADD CONSTRAINT
	PK_PARTES PRIMARY KEY CLUSTERED 
	(
	IDPARTE
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT


PRINT 'CAMBIAR COLLATE PERMISOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_PERMISOS
	(
	CODIGO int NOT NULL,
	PERMISO char(12) NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.PERMISOS)
	 EXEC('INSERT INTO dbo.Tmp_PERMISOS (CODIGO, PERMISO)
		SELECT CODIGO, PERMISO FROM dbo.PERMISOS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.PERMISOS_USUARIO
	DROP CONSTRAINT FK_PERMISOS_USUARIO_PERMISOS
GO
ALTER TABLE dbo.ROLESPERMISOS
	DROP CONSTRAINT FK_ROLESPERMISOS_PERMISOS
GO
DROP TABLE dbo.PERMISOS
GO
EXECUTE sp_rename N'dbo.Tmp_PERMISOS', N'PERMISOS', 'OBJECT' 
GO
ALTER TABLE dbo.PERMISOS ADD CONSTRAINT
	PK_PERMISOS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ROLESPERMISOS ADD CONSTRAINT
	FK_ROLESPERMISOS_PERMISOS FOREIGN KEY
	(
	ID_PERMISO
	) REFERENCES dbo.PERMISOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PERMISOS_USUARIO ADD CONSTRAINT
	FK_PERMISOS_USUARIO_PERMISOS FOREIGN KEY
	(
	REFPERMISO
	) REFERENCES dbo.PERMISOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE PERMISOS_USUARIO';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.PERMISOS_USUARIO
	DROP CONSTRAINT FK_PERMISOS_USUARIO_USUARIOS
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PERMISOS_USUARIO
	DROP CONSTRAINT FK_PERMISOS_USUARIO_PERMISOS
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_PERMISOS_USUARIO
	(
	CODIGO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	ITEM char(30) NULL,
	REFUSUARIO int NULL,
	REFPERMISO int NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_PERMISOS_USUARIO ON
GO
IF EXISTS(SELECT * FROM dbo.PERMISOS_USUARIO)
	 EXEC('INSERT INTO dbo.Tmp_PERMISOS_USUARIO (CODIGO, ITEM, REFUSUARIO, REFPERMISO)
		SELECT CODIGO, ITEM, REFUSUARIO, REFPERMISO FROM dbo.PERMISOS_USUARIO WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_PERMISOS_USUARIO OFF
GO
DROP TABLE dbo.PERMISOS_USUARIO
GO
EXECUTE sp_rename N'dbo.Tmp_PERMISOS_USUARIO', N'PERMISOS_USUARIO', 'OBJECT' 
GO
ALTER TABLE dbo.PERMISOS_USUARIO ADD CONSTRAINT
	PK_PERMISOS_USUARIO PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.PERMISOS_USUARIO ADD CONSTRAINT
	FK_PERMISOS_USUARIO_PERMISOS FOREIGN KEY
	(
	REFPERMISO
	) REFERENCES dbo.PERMISOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.PERMISOS_USUARIO ADD CONSTRAINT
	FK_PERMISOS_USUARIO_USUARIOS FOREIGN KEY
	(
	REFUSUARIO
	) REFERENCES dbo.USUARIOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE PLANTILLA HISTORIALES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_PLANTILLA_HISTORIALES
	(
	CODIGO varchar(12) NOT NULL,
	MOTIVO text NULL,
	ANTECEDENTES text NULL,
	EXPLORACION text NULL,
	COMPLEMENTARIAS text NULL,
	JUICIO text NULL,
	TRATAMIENTO text NULL,
	HISTORIAL text NULL,
	COMENTARIOS text NULL,
	OTROS text NULL,
	DESCRIPCION text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.PLANTILLA_HISTORIALES)
	 EXEC('INSERT INTO dbo.Tmp_PLANTILLA_HISTORIALES (CODIGO, MOTIVO, ANTECEDENTES, EXPLORACION, COMPLEMENTARIAS, JUICIO, TRATAMIENTO, HISTORIAL, COMENTARIOS, OTROS, DESCRIPCION)
		SELECT CODIGO, MOTIVO, ANTECEDENTES, EXPLORACION, COMPLEMENTARIAS, JUICIO, TRATAMIENTO, HISTORIAL, COMENTARIOS, OTROS, DESCRIPCION FROM dbo.PLANTILLA_HISTORIALES WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.PLANTILLA_HISTORIALES
GO
EXECUTE sp_rename N'dbo.Tmp_PLANTILLA_HISTORIALES', N'PLANTILLA_HISTORIALES', 'OBJECT' 
GO
ALTER TABLE dbo.PLANTILLA_HISTORIALES ADD CONSTRAINT
	PK_PLANTILLA_HISTORIALES PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

PRINT 'CAMBIAR COLLATE PLANTILLA ANALITICA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.PLANTILLAANALITICAS
	DROP CONSTRAINT FK_PLANTILLAANALITICAS_CONCEPTOSFRA
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_PLANTILLAANALITICAS
	(
	CODIGO varchar(10) NOT NULL,
	DESCRIPCION varchar(90) NOT NULL,
	REFCONCEPTO varchar(10) NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.PLANTILLAANALITICAS)
	 EXEC('INSERT INTO dbo.Tmp_PLANTILLAANALITICAS (CODIGO, DESCRIPCION, REFCONCEPTO)
		SELECT CODIGO, DESCRIPCION, REFCONCEPTO FROM dbo.PLANTILLAANALITICAS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.LPLANTILLAANALITICAS
	DROP CONSTRAINT fk_lplantillaplantilla
GO
DROP TABLE dbo.PLANTILLAANALITICAS
GO
EXECUTE sp_rename N'dbo.Tmp_PLANTILLAANALITICAS', N'PLANTILLAANALITICAS', 'OBJECT' 
GO
ALTER TABLE dbo.PLANTILLAANALITICAS ADD CONSTRAINT
	PK_PLANTILLAANALITICAS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.PLANTILLAANALITICAS ADD CONSTRAINT
	FK_PLANTILLAANALITICAS_CONCEPTOSFRA FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LPLANTILLAANALITICAS ADD CONSTRAINT
	fk_lplantillaplantilla FOREIGN KEY
	(
	REFPLANTILLA
	) REFERENCES dbo.PLANTILLAANALITICAS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE PLANTILLAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.PLANTILLAS
	DROP CONSTRAINT DF__PLANTILLA__SECCI__5812160E
GO
CREATE TABLE dbo.Tmp_PLANTILLAS
	(
	CODIGO int NOT NULL,
	DESCRIPCION varchar(90) NULL,
	SECCION varchar(2) NOT NULL,
	TEXTO text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_PLANTILLAS ADD CONSTRAINT
	DF__PLANTILLA__SECCI__5812160E DEFAULT ('GN') FOR SECCION
GO
IF EXISTS(SELECT * FROM dbo.PLANTILLAS)
	 EXEC('INSERT INTO dbo.Tmp_PLANTILLAS (CODIGO, DESCRIPCION, SECCION, TEXTO)
		SELECT CODIGO, DESCRIPCION, SECCION, TEXTO FROM dbo.PLANTILLAS WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.PLANTILLAS
GO
EXECUTE sp_rename N'dbo.Tmp_PLANTILLAS', N'PLANTILLAS', 'OBJECT' 
GO
ALTER TABLE dbo.PLANTILLAS ADD CONSTRAINT
	PK_PLANTILLAS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

PRINT 'CAMBIAR COLLATE PRESUPUESTOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.PRESUPUESTOS
	DROP CONSTRAINT fkpresupuestomutua
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PRESUPUESTOS
	DROP CONSTRAINT fkpresupuestopaciente
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PRESUPUESTOS
	DROP CONSTRAINT fkpresupuestoempresa
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PRESUPUESTOS
	DROP CONSTRAINT DF__PRESUPUES__MUTUA__5AEE82B9
GO
CREATE TABLE dbo.Tmp_PRESUPUESTOS
	(
	NUMERO int NOT NULL,
	REFPACIENTE int NULL,
	FECHA datetime NULL,
	REFEMPRESA int NULL,
	REFMUTUA int NULL,
	FEMISION datetime NULL,
	TOTAL decimal(18, 2) NULL,
	MUTUA varchar(1) NOT NULL,
	DIRECCION varchar(150) NULL,
	LOCALIDAD varchar(35) NULL,
	PROVINCIA varchar(35) NULL,
	CP varchar(6) NULL,
	PACIENTE varchar(90) NULL,
	DNI varchar(30) NULL,
	EMPRESA varchar(1) NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_PRESUPUESTOS ADD CONSTRAINT
	DF__PRESUPUES__MUTUA__5AEE82B9 DEFAULT ('N') FOR MUTUA
GO
IF EXISTS(SELECT * FROM dbo.PRESUPUESTOS)
	 EXEC('INSERT INTO dbo.Tmp_PRESUPUESTOS (NUMERO, REFPACIENTE, FECHA, REFEMPRESA, REFMUTUA, FEMISION, TOTAL, MUTUA, DIRECCION, LOCALIDAD, PROVINCIA, CP, PACIENTE, DNI, EMPRESA)
		SELECT NUMERO, REFPACIENTE, FECHA, REFEMPRESA, REFMUTUA, FEMISION, TOTAL, MUTUA, DIRECCION, LOCALIDAD, PROVINCIA, CP, PACIENTE, DNI, EMPRESA FROM dbo.PRESUPUESTOS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.LPRESUPUESTOS
	DROP CONSTRAINT fklpresupuestopresupuesto
GO
DROP TABLE dbo.PRESUPUESTOS
GO
EXECUTE sp_rename N'dbo.Tmp_PRESUPUESTOS', N'PRESUPUESTOS', 'OBJECT' 
GO
ALTER TABLE dbo.PRESUPUESTOS ADD CONSTRAINT
	PK_PRESUPUESTOS PRIMARY KEY CLUSTERED 
	(
	NUMERO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.PRESUPUESTOS ADD CONSTRAINT
	fkpresupuestoempresa FOREIGN KEY
	(
	REFEMPRESA
	) REFERENCES dbo.EMPRESAS
	(
	CEMPRESA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PRESUPUESTOS ADD CONSTRAINT
	fkpresupuestopaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PRESUPUESTOS ADD CONSTRAINT
	fkpresupuestomutua FOREIGN KEY
	(
	REFMUTUA
	) REFERENCES dbo.MUTUAS
	(
	CMUTUA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LPRESUPUESTOS ADD CONSTRAINT
	fklpresupuestopresupuesto FOREIGN KEY
	(
	REFPRESUPUESTO
	) REFERENCES dbo.PRESUPUESTOS
	(
	NUMERO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT


PRINT 'CAMBIAR COLLATE PPROVEEDORES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_PROVEEDORES
	(
	NOMBRE varchar(40) NULL,
	DIRECCION varchar(150) NULL,
	POBLACION varchar(20) NULL,
	PROVINCIA varchar(20) NULL,
	CP varchar(5) NULL,
	TLFNO1 varchar(10) NULL,
	TLFNO2 varchar(10) NULL,
	FAX varchar(10) NULL,
	MAIL varchar(40) NULL,
	WEB varchar(40) NULL,
	PERSONACON varchar(40) NULL,
	NOTAS varchar(150) NULL,
	CPROVEEDOR int NOT NULL,
	CIF varchar(9) NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.PROVEEDORES)
	 EXEC('INSERT INTO dbo.Tmp_PROVEEDORES (NOMBRE, DIRECCION, POBLACION, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACON, NOTAS, CPROVEEDOR, CIF)
		SELECT NOMBRE, DIRECCION, POBLACION, PROVINCIA, CP, TLFNO1, TLFNO2, FAX, MAIL, WEB, PERSONACON, NOTAS, CPROVEEDOR, CIF FROM dbo.PROVEEDORES WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.ARTICULOS
	DROP CONSTRAINT fkarticulosproveedor
GO
DROP TABLE dbo.PROVEEDORES
GO
EXECUTE sp_rename N'dbo.Tmp_PROVEEDORES', N'PROVEEDORES', 'OBJECT' 
GO
ALTER TABLE dbo.PROVEEDORES ADD CONSTRAINT
	PK_PROVEEDORES PRIMARY KEY CLUSTERED 
	(
	CPROVEEDOR
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ARTICULOS ADD CONSTRAINT
	fkarticulosproveedor FOREIGN KEY
	(
	REFPROVEEDOR
	) REFERENCES dbo.PROVEEDORES
	(
	CPROVEEDOR
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT


PRINT 'CAMBIAR COLLATE PROVINCIAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
CREATE TABLE dbo.Tmp_PROVINCIAS
	(
	PROVINCIA varchar(30) NULL,
	CPROVINCIA int NOT NULL
	)  ON [PRIMARY]
GO

IF EXISTS(SELECT * FROM dbo.PROVINCIAS)
	 EXEC('INSERT INTO dbo.Tmp_PROVINCIAS (PROVINCIA, CPROVINCIA)
		SELECT PROVINCIA, CPROVINCIA FROM dbo.PROVINCIAS WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.PROVINCIAS
GO
EXECUTE sp_rename N'dbo.Tmp_PROVINCIAS', N'PROVINCIAS', 'OBJECT' 
GO
ALTER TABLE dbo.PROVINCIAS ADD CONSTRAINT
	PK_PROVINCIAS PRIMARY KEY CLUSTERED 
	(
	CPROVINCIA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT

PRINT 'CAMBIAR COLLATE PUESTO TRABAJO';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.PuestoTrabajo
	DROP CONSTRAINT DF_PuestoTrabajo_Descripcion
GO
CREATE TABLE dbo.Tmp_PuestoTrabajo
	(
	idPuestoTrabajo int NOT NULL IDENTITY (1, 1),
	Descripcion varchar(50) NOT NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_PuestoTrabajo ADD CONSTRAINT
	DF_PuestoTrabajo_Descripcion DEFAULT ('') FOR Descripcion
GO
SET IDENTITY_INSERT dbo.Tmp_PuestoTrabajo ON
GO
IF EXISTS(SELECT * FROM dbo.PuestoTrabajo)
	 EXEC('INSERT INTO dbo.Tmp_PuestoTrabajo (idPuestoTrabajo, Descripcion)
		SELECT idPuestoTrabajo, Descripcion FROM dbo.PuestoTrabajo WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_PuestoTrabajo OFF
GO
DROP TABLE dbo.PuestoTrabajo
GO
EXECUTE sp_rename N'dbo.Tmp_PuestoTrabajo', N'PuestoTrabajo', 'OBJECT' 
GO
COMMIT

PRINT 'CAMBIAR COLLATE RECETAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fkrecetasmedico
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fk_recetamedicamento
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fkrecetaspaciente
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT fk_recetasdiagnostico
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECETAS
	DROP CONSTRAINT DF_RECETAS_Eliminado
GO
CREATE TABLE dbo.Tmp_RECETAS
	(
	IDRECETA int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	FECHA datetime NULL,
	REFPACIENTE int NULL,
	TRATAMIENTO text NULL,
	REFMEDICO int NULL,
	REFDIAGNOSTICO int NULL,
	REFMEDICAMENTO varchar(5) NULL,
	HORA datetime NULL,
	Eliminado bit NULL,
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
	NoEnvases_o_Unidades int NULL,
	Prescriptor nvarchar(500) NULL,
	InstruccionesAlPaciente nvarchar(500) NULL,
	EsRecetaOficial bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_RECETAS ADD CONSTRAINT
	DF_RECETAS_Eliminado DEFAULT ((0)) FOR Eliminado
GO
SET IDENTITY_INSERT dbo.Tmp_RECETAS ON
GO
IF EXISTS(SELECT * FROM dbo.RECETAS)
	 EXEC('INSERT INTO dbo.Tmp_RECETAS (IDRECETA, FECHA, REFPACIENTE, TRATAMIENTO, REFMEDICO, REFDIAGNOSTICO, REFMEDICAMENTO, HORA, Eliminado, Prescripcion, DuracionTratamiento, PacienteInfo, Posologia, Unidades, Pauta, NoOrdenDispensacion, FechaPrevistaDispensacion, InfoAlFarmaceutico, DiagnosticoAlPaciente, NoEnvases_o_Unidades, Prescriptor, InstruccionesAlPaciente, EsRecetaOficial)
		SELECT IDRECETA, FECHA, REFPACIENTE, TRATAMIENTO, REFMEDICO, REFDIAGNOSTICO, REFMEDICAMENTO, HORA, Eliminado, Prescripcion, DuracionTratamiento, PacienteInfo, Posologia, Unidades, Pauta, NoOrdenDispensacion, FechaPrevistaDispensacion, InfoAlFarmaceutico, DiagnosticoAlPaciente, NoEnvases_o_Unidades, Prescriptor, InstruccionesAlPaciente, EsRecetaOficial FROM dbo.RECETAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_RECETAS OFF
GO
ALTER TABLE dbo.RecetasMedicamentos
	DROP CONSTRAINT FK_RecetasMedicamentos_RECETAS
GO
DROP TABLE dbo.RECETAS
GO
EXECUTE sp_rename N'dbo.Tmp_RECETAS', N'RECETAS', 'OBJECT' 
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	PK_RECETAS PRIMARY KEY CLUSTERED 
	(
	IDRECETA
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fk_recetasdiagnostico FOREIGN KEY
	(
	REFDIAGNOSTICO
	) REFERENCES dbo.DIAGNOSTICOS
	(
	IDDIAGNOSTICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fkrecetaspaciente FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fk_recetamedicamento FOREIGN KEY
	(
	REFMEDICAMENTO
	) REFERENCES dbo.MEDICAMENTOS
	(
	CMEDICAMENTO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.RECETAS ADD CONSTRAINT
	fkrecetasmedico FOREIGN KEY
	(
	REFMEDICO
	) REFERENCES dbo.MEDICOS
	(
	CMEDICO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RecetasMedicamentos ADD CONSTRAINT
	FK_RecetasMedicamentos_RECETAS FOREIGN KEY
	(
	IdReceta
	) REFERENCES dbo.RECETAS
	(
	IDRECETA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE RECETASMEDICAMENTOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.RecetasMedicamentos
	DROP CONSTRAINT FK_RecetasMedicamentos_RECETAS
GO

COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_RecetasMedicamentos
	(
	IdLineaReceta int NOT NULL IDENTITY (1, 1),
	IdReceta int NOT NULL,
	REFMEDICAMENTO varchar(5) NOT NULL
	)  ON [PRIMARY]
GO

SET IDENTITY_INSERT dbo.Tmp_RecetasMedicamentos ON
GO
IF EXISTS(SELECT * FROM dbo.RecetasMedicamentos)
	 EXEC('INSERT INTO dbo.Tmp_RecetasMedicamentos (IdLineaReceta, IdReceta, REFMEDICAMENTO)
		SELECT IdLineaReceta, IdReceta, REFMEDICAMENTO FROM dbo.RecetasMedicamentos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_RecetasMedicamentos OFF
GO
DROP TABLE dbo.RecetasMedicamentos
GO
EXECUTE sp_rename N'dbo.Tmp_RecetasMedicamentos', N'RecetasMedicamentos', 'OBJECT' 
GO
ALTER TABLE dbo.RecetasMedicamentos ADD CONSTRAINT
	PK_RecetasMedicamentos PRIMARY KEY CLUSTERED 
	(
	IdLineaReceta,
	IdReceta
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.RecetasMedicamentos ADD CONSTRAINT
	FK_RecetasMedicamentos_RECETAS FOREIGN KEY
	(
	IdReceta
	) REFERENCES dbo.RECETAS
	(
	IDRECETA
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT

PRINT 'CAMBIAR COLLATE RECIBOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT FK_RECIBOS_EntregasCuenta
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT FK_RECIBOS_PACIENTES
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT DF__RECIBOS__COBRADO__5FB337D6
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT DF__RECIBOS__EMITIDO__60A75C0F
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT DF__RECIBOS__N19__619B8048
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT DF__RECIBOS__TIPO__628FA481
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT DF_RECIBOS_PagadoConCredito
GO
CREATE TABLE dbo.Tmp_RECIBOS
	(
	FECHAEMISION datetime NULL,
	COBRADO varchar(1) NULL,
	EMITIDO varchar(1) NULL,
	REFCITA int NULL,
	REFFACTURA int NULL,
	IMPORTE decimal(18, 2) NULL,
	REFPACIENTE int NULL,
	FECHAVENCIMIENTO datetime NULL,
	NOMBRE varchar(90) NULL,
	DIRECCION text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NOTAS text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NUMERO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	CUENTABANCO varchar(20) NULL,
	ENTIDAD varchar(4) NULL,
	OFICINA varchar(4) NULL,
	DC varchar(2) NULL,
	CUENTA varchar(10) NULL,
	CONCEPTO varchar(150) NULL,
	FECHACOBRO datetime NULL,
	N19 varchar(1) NULL,
	REFFORMAPAGO varchar(10) NULL,
	TIPO varchar(1) NULL,
	REFEMPRESA int NULL,
	IDEntregaCuenta bigint NULL,
	PagadoConCredito bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_RECIBOS ADD CONSTRAINT
	DF__RECIBOS__COBRADO__5FB337D6 DEFAULT ('N') FOR COBRADO
GO
ALTER TABLE dbo.Tmp_RECIBOS ADD CONSTRAINT
	DF__RECIBOS__EMITIDO__60A75C0F DEFAULT ('N') FOR EMITIDO
GO
ALTER TABLE dbo.Tmp_RECIBOS ADD CONSTRAINT
	DF__RECIBOS__N19__619B8048 DEFAULT ('N') FOR N19
GO
ALTER TABLE dbo.Tmp_RECIBOS ADD CONSTRAINT
	DF__RECIBOS__TIPO__628FA481 DEFAULT ('P') FOR TIPO
GO
ALTER TABLE dbo.Tmp_RECIBOS ADD CONSTRAINT
	DF_RECIBOS_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
SET IDENTITY_INSERT dbo.Tmp_RECIBOS ON
GO
IF EXISTS(SELECT * FROM dbo.RECIBOS)
	 EXEC('INSERT INTO dbo.Tmp_RECIBOS (FECHAEMISION, COBRADO, EMITIDO, REFCITA, REFFACTURA, IMPORTE, REFPACIENTE, FECHAVENCIMIENTO, NOMBRE, DIRECCION, NOTAS, NUMERO, CUENTABANCO, ENTIDAD, OFICINA, DC, CUENTA, CONCEPTO, FECHACOBRO, N19, REFFORMAPAGO, TIPO, REFEMPRESA, IDEntregaCuenta, PagadoConCredito)
		SELECT FECHAEMISION, COBRADO, EMITIDO, REFCITA, REFFACTURA, IMPORTE, REFPACIENTE, FECHAVENCIMIENTO, NOMBRE, DIRECCION, NOTAS, NUMERO, CUENTABANCO, ENTIDAD, OFICINA, DC, CUENTA, CONCEPTO, FECHACOBRO, N19, REFFORMAPAGO, TIPO, REFEMPRESA, IDEntregaCuenta, PagadoConCredito FROM dbo.RECIBOS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_RECIBOS OFF
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fk_frasmeijiderecibo
GO
DROP TABLE dbo.RECIBOS
GO
EXECUTE sp_rename N'dbo.Tmp_RECIBOS', N'RECIBOS', 'OBJECT' 
GO
ALTER TABLE dbo.RECIBOS ADD CONSTRAINT
	PK_RECIBOS PRIMARY KEY CLUSTERED 
	(
	NUMERO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.RECIBOS ADD CONSTRAINT
	FK_RECIBOS_PACIENTES FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.RECIBOS ADD CONSTRAINT
	FK_RECIBOS_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fk_frasmeijiderecibo FOREIGN KEY
	(
	REFRECIBO
	) REFERENCES dbo.RECIBOS
	(
	NUMERO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE RECIBOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT FK_RECIBOS_EntregasCuenta
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT FK_RECIBOS_PACIENTES
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT DF__RECIBOS__COBRADO__5FB337D6
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT DF__RECIBOS__EMITIDO__60A75C0F
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT DF__RECIBOS__N19__619B8048
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT DF__RECIBOS__TIPO__628FA481
GO
ALTER TABLE dbo.RECIBOS
	DROP CONSTRAINT DF_RECIBOS_PagadoConCredito
GO
CREATE TABLE dbo.Tmp_RECIBOS
	(
	FECHAEMISION datetime NULL,
	COBRADO varchar(1) NULL,
	EMITIDO varchar(1) NULL,
	REFCITA int NULL,
	REFFACTURA int NULL,
	IMPORTE decimal(18, 2) NULL,
	REFPACIENTE int NULL,
	FECHAVENCIMIENTO datetime NULL,
	NOMBRE varchar(90) NULL,
	DIRECCION text NULL,
	NOTAS text NULL,
	NUMERO int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	CUENTABANCO varchar(20) NULL,
	ENTIDAD varchar(4) NULL,
	OFICINA varchar(4) NULL,
	DC varchar(2) NULL,
	CUENTA varchar(10) NULL,
	CONCEPTO varchar(150) NULL,
	FECHACOBRO datetime NULL,
	N19 varchar(1) NULL,
	REFFORMAPAGO varchar(10) NULL,
	TIPO varchar(1) NULL,
	REFEMPRESA int NULL,
	IDEntregaCuenta bigint NULL,
	PagadoConCredito bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_RECIBOS ADD CONSTRAINT
	DF__RECIBOS__COBRADO__5FB337D6 DEFAULT ('N') FOR COBRADO
GO
ALTER TABLE dbo.Tmp_RECIBOS ADD CONSTRAINT
	DF__RECIBOS__EMITIDO__60A75C0F DEFAULT ('N') FOR EMITIDO
GO
ALTER TABLE dbo.Tmp_RECIBOS ADD CONSTRAINT
	DF__RECIBOS__N19__619B8048 DEFAULT ('N') FOR N19
GO
ALTER TABLE dbo.Tmp_RECIBOS ADD CONSTRAINT
	DF__RECIBOS__TIPO__628FA481 DEFAULT ('P') FOR TIPO
GO
ALTER TABLE dbo.Tmp_RECIBOS ADD CONSTRAINT
	DF_RECIBOS_PagadoConCredito DEFAULT ((0)) FOR PagadoConCredito
GO
SET IDENTITY_INSERT dbo.Tmp_RECIBOS ON
GO
IF EXISTS(SELECT * FROM dbo.RECIBOS)
	 EXEC('INSERT INTO dbo.Tmp_RECIBOS (FECHAEMISION, COBRADO, EMITIDO, REFCITA, REFFACTURA, IMPORTE, REFPACIENTE, FECHAVENCIMIENTO, NOMBRE, DIRECCION, NOTAS, NUMERO, CUENTABANCO, ENTIDAD, OFICINA, DC, CUENTA, CONCEPTO, FECHACOBRO, N19, REFFORMAPAGO, TIPO, REFEMPRESA, IDEntregaCuenta, PagadoConCredito)
		SELECT FECHAEMISION, COBRADO, EMITIDO, REFCITA, REFFACTURA, IMPORTE, REFPACIENTE, FECHAVENCIMIENTO, NOMBRE, DIRECCION, NOTAS, NUMERO, CUENTABANCO, ENTIDAD, OFICINA, DC, CUENTA, CONCEPTO, FECHACOBRO, N19, REFFORMAPAGO, TIPO, REFEMPRESA, IDEntregaCuenta, PagadoConCredito FROM dbo.RECIBOS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_RECIBOS OFF
GO
ALTER TABLE dbo.FRASMEIJIDE
	DROP CONSTRAINT fk_frasmeijiderecibo
GO
DROP TABLE dbo.RECIBOS
GO
EXECUTE sp_rename N'dbo.Tmp_RECIBOS', N'RECIBOS', 'OBJECT' 
GO
ALTER TABLE dbo.RECIBOS ADD CONSTRAINT
	PK_RECIBOS PRIMARY KEY CLUSTERED 
	(
	NUMERO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.RECIBOS ADD CONSTRAINT
	FK_RECIBOS_PACIENTES FOREIGN KEY
	(
	REFPACIENTE
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.RECIBOS ADD CONSTRAINT
	FK_RECIBOS_EntregasCuenta FOREIGN KEY
	(
	IDEntregaCuenta
	) REFERENCES dbo.EntregasCuenta
	(
	IDEntregaCuenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FRASMEIJIDE ADD CONSTRAINT
	fk_frasmeijiderecibo FOREIGN KEY
	(
	REFRECIBO
	) REFERENCES dbo.RECIBOS
	(
	NUMERO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT

PRINT 'CAMBIAR COLLATE SERIES';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.SERIES
	DROP CONSTRAINT DF__SERIES__CONTADOR__6477ECF3
GO
CREATE TABLE dbo.Tmp_SERIES
	(
	CODIGO varchar(6) NOT NULL,
	CONTADOR int NOT NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_SERIES ADD CONSTRAINT
	DF__SERIES__CONTADOR__6477ECF3 DEFAULT ((0)) FOR CONTADOR
GO
IF EXISTS(SELECT * FROM dbo.SERIES)
	 EXEC('INSERT INTO dbo.Tmp_SERIES (CODIGO, CONTADOR)
		SELECT CODIGO, CONTADOR FROM dbo.SERIES WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.SERIES
GO
EXECUTE sp_rename N'dbo.Tmp_SERIES', N'SERIES', 'OBJECT' 
GO
ALTER TABLE dbo.SERIES ADD CONSTRAINT
	PK_SERIES PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT


PRINT 'CAMBIAR COLLATE TARIFAS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.Tarifas
	DROP CONSTRAINT FK_Tarifas_CONCEPTOSFRA
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Tarifas
	DROP CONSTRAINT DF_Tarifas_DescripcionTarifa
GO
ALTER TABLE dbo.Tarifas
	DROP CONSTRAINT DF_Tarifas_Importe
GO
CREATE TABLE dbo.Tmp_Tarifas
	(
	IdTarifa int NOT NULL,
	DescripcionTarifa varchar(50) NOT NULL,
	IdConceptoFra varchar(10) NOT NULL,
	Importe float(53) NOT NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_Tarifas ADD CONSTRAINT
	DF_Tarifas_DescripcionTarifa DEFAULT ('') FOR DescripcionTarifa
GO
ALTER TABLE dbo.Tmp_Tarifas ADD CONSTRAINT
	DF_Tarifas_Importe DEFAULT ((0)) FOR Importe
GO
IF EXISTS(SELECT * FROM dbo.Tarifas)
	 EXEC('INSERT INTO dbo.Tmp_Tarifas (IdTarifa, DescripcionTarifa, IdConceptoFra, Importe)
		SELECT IdTarifa, DescripcionTarifa, IdConceptoFra, Importe FROM dbo.Tarifas WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.Tarifas
GO
EXECUTE sp_rename N'dbo.Tmp_Tarifas', N'Tarifas', 'OBJECT' 
GO
ALTER TABLE dbo.Tarifas ADD CONSTRAINT
	PK_Tarifas PRIMARY KEY CLUSTERED 
	(
	IdTarifa,
	IdConceptoFra
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Tarifas ADD CONSTRAINT
	FK_Tarifas_CONCEPTOSFRA FOREIGN KEY
	(
	IdConceptoFra
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT


PRINT 'CAMBIAR COLLATE USUARIOS';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.USUARIOS
	DROP CONSTRAINT DF__USUARIOS__ADMINI__66603565
GO
CREATE TABLE dbo.Tmp_USUARIOS
	(
	CODIGO int NOT NULL,
	USUARIO varchar(15) NOT NULL,
	CONTRASENA varchar(15) NULL,
	NIVEL varchar(60) NOT NULL,
	ADMINISTRADOR varchar(1) NOT NULL,
	NOMBRECOMPLETO varchar(90) NULL,
	REFMEDICO int NULL,
	FECHACLAVE datetime NOT NULL,
	CONFIGURACIONXML xml NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE dbo.Tmp_USUARIOS ADD CONSTRAINT
	DF__USUARIOS__ADMINI__66603565 DEFAULT ('N') FOR ADMINISTRADOR
GO
IF EXISTS(SELECT * FROM dbo.USUARIOS)
	 EXEC('INSERT INTO dbo.Tmp_USUARIOS (CODIGO, USUARIO, CONTRASENA, NIVEL, ADMINISTRADOR, NOMBRECOMPLETO, REFMEDICO, FECHACLAVE, CONFIGURACIONXML)
		SELECT CODIGO, USUARIO, CONTRASENA, NIVEL, ADMINISTRADOR, NOMBRECOMPLETO, REFMEDICO, FECHACLAVE, CONFIGURACIONXML FROM dbo.USUARIOS WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.CALENDARIO_USUARIOS
	DROP CONSTRAINT FK_CALENDARIO_USUARIOS_USUARIOS
GO
ALTER TABLE dbo.Comunicaciones
	DROP CONSTRAINT FK_Comunicaciones_USUARIOS
GO
ALTER TABLE dbo.PERMISOS_USUARIO
	DROP CONSTRAINT FK_PERMISOS_USUARIO_USUARIOS
GO
ALTER TABLE dbo.NOTAS
	DROP CONSTRAINT FK_NOTAS_NOTAS
GO
ALTER TABLE dbo.EntregasCuenta
	DROP CONSTRAINT FK_EntregasCuenta_USUARIOS
GO
ALTER TABLE dbo.FILTROS
	DROP CONSTRAINT FK_FILTROS_USUARIOS
GO
ALTER TABLE dbo.PagosPaciente
	DROP CONSTRAINT FK_PagosCliente_USUARIOS
GO
ALTER TABLE dbo.ROLESUSUARIOS
	DROP CONSTRAINT FK_ROLESUSUARIOS_USUARIOS
GO
DROP TABLE dbo.USUARIOS
GO
EXECUTE sp_rename N'dbo.Tmp_USUARIOS', N'USUARIOS', 'OBJECT' 
GO
ALTER TABLE dbo.USUARIOS ADD CONSTRAINT
	PK_USUARIOS PRIMARY KEY CLUSTERED 
	(
	CODIGO
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ROLESUSUARIOS ADD CONSTRAINT
	FK_ROLESUSUARIOS_USUARIOS FOREIGN KEY
	(
	ID_USUARIO
	) REFERENCES dbo.USUARIOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PagosPaciente ADD CONSTRAINT
	FK_PagosCliente_USUARIOS FOREIGN KEY
	(
	IDUsuario
	) REFERENCES dbo.USUARIOS
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FILTROS ADD CONSTRAINT
	FK_FILTROS_USUARIOS FOREIGN KEY
	(
	ID_Usuario
	) REFERENCES dbo.USUARIOS
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.EntregasCuenta ADD CONSTRAINT
	FK_EntregasCuenta_USUARIOS FOREIGN KEY
	(
	IDUsuarioEfectua
	) REFERENCES dbo.USUARIOS
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.NOTAS ADD CONSTRAINT
	FK_NOTAS_NOTAS FOREIGN KEY
	(
	ID_Usuario
	) REFERENCES dbo.USUARIOS
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PERMISOS_USUARIO ADD CONSTRAINT
	FK_PERMISOS_USUARIO_USUARIOS FOREIGN KEY
	(
	REFUSUARIO
	) REFERENCES dbo.USUARIOS
	(
	CODIGO
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Comunicaciones ADD CONSTRAINT
	FK_Comunicaciones_USUARIOS FOREIGN KEY
	(
	ID_UsuarioEmisor
	) REFERENCES dbo.USUARIOS
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CALENDARIO_USUARIOS ADD CONSTRAINT
	FK_CALENDARIO_USUARIOS_USUARIOS FOREIGN KEY
	(
	ID_Usuario
	) REFERENCES dbo.USUARIOS
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

COMMIT


PRINT 'ADD CAMPO A CITAS PAGADODESDEFACTURA';
/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
	PagadoDesdeFactura bit NULL
GO
ALTER TABLE dbo.CITAS ADD CONSTRAINT
	DF_CITAS_PagadoDesdeFactura DEFAULT 0 FOR PagadoDesdeFactura
GO

COMMIT


Update VariablesGlobales Set Valor = '1.0.3.2' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.3.2';

