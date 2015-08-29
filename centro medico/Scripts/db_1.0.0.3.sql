SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Articulos_Tipo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Articulos_Tipo](
	[ID_TipoArticulo] [int] NOT NULL,
	[Nombre] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_N_Articulos_Tipo] PRIMARY KEY CLUSTERED 
(
	[ID_TipoArticulo] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Entradas_Tipos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Entradas_Tipos](
	[ID_TipoEntrada] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Descripcion] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_N_Entradas_Tipos] PRIMARY KEY CLUSTERED 
(
	[ID_TipoEntrada] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor_Tipos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_PedidosProveedor_Tipos](
	[ID_TipoPedidoProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Descripcion] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
 CONSTRAINT [PK_N_PedidosProveedor_Tipos] PRIMARY KEY CLUSTERED 
(
	[ID_TipoPedidoProveedor] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_TipoIVA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_TipoIVA](
	[ID_TipoIVA] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Valor] [float] NULL,
 CONSTRAINT [PK_N_TipoIVA] PRIMARY KEY CLUSTERED 
(
	[ID_TipoIVA] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas_Tipos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_FacturasRecibidas_Tipos](
	[ID_TipoFacturaRecibida] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Descripcion] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
 CONSTRAINT [PK_N_FacturasRecibidas_Tipos] PRIMARY KEY CLUSTERED 
(
	[ID_TipoFacturaRecibida] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Almacen]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Almacen](
	[ID_Almacen] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Descripcion] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Observaciones] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
 CONSTRAINT [PK_N_Almacen] PRIMARY KEY CLUSTERED 
(
	[ID_Almacen] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Articulos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Articulos](
	[ID_Articulo] [bigint] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](13)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CodigoEAN] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_TipoArticulo] [int] NOT NULL CONSTRAINT [DF_N_Articulos_ID_TipoArticulo]  DEFAULT ((1)),
	[Equivalente] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[CodigoCorto] [int] NULL,
	[ID_Familia] [int] NULL,
	[DescripcionGeneral] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[DescripcionEtiquetas] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[DescripcionTickets] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[DescripcionLarga] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_TipoIVA] [int] NULL,
	[ID_ProveedorHabitual] [int] NULL,
	[Referencia] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_Fabricante] [int] NULL,
	[PrecioCompra] [float] NULL CONSTRAINT [DF_N_Articulos_PrecioCompra]  DEFAULT ((0)),
	[Descuento1] [float] NULL,
	[Descuento2] [float] NULL,
	[Descuento3] [nchar](10)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FechaAltaArticulo] [datetime] NULL CONSTRAINT [DF_N_Articulos_FechaAltaArticulo]  DEFAULT (getdate()),
	[MaximoDescuentoAplicable] [float] NULL,
	[ID_Tallaje] [int] NULL,
	[UbicacionEnAlmacen] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UnidadesLinea] [int] NULL,
	[UnidadesPorPalets] [int] NULL,
	[Dimensiones] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[NoPermitirUtilzarArticulo] [bit] NULL,
	[NoImprimirArticuloListado] [bit] NULL CONSTRAINT [DF_N_Articulos_NoImprimirArticuloListado]  DEFAULT ((0)),
	[DesactivarMensajesParaEsteArticulo] [bit] NULL,
	[ID_ArticuloConcatenado] [int] NULL CONSTRAINT [DF_N_Articulos_ID_ArticuloConcatenado]  DEFAULT ((0)),
	[ReferenciaDelProveedor] [nchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ImportePortesPorUnid] [float] NULL,
	[NumeroCuentaVentas] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NumeroCuentaCompras] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Imagen] [image] NULL,
	[FechaUltimaModif] [datetime] NULL,
	[PesoArticulo] [float] NULL,
	[GarantiaArticulo] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[MensajeEmergente] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[EsArticuloCompuesto] [bit] NULL CONSTRAINT [DF_N_Articulos_EsArticuloCompuesto]  DEFAULT ((0)),
	[EsEstocable] [bit] NULL CONSTRAINT [DF_N_Articulos_EsEstocable]  DEFAULT ((1)),
	[PrecioVentaRecomendado] [float] NOT NULL CONSTRAINT [DF_N_Articulos_PrecioVentaRecomendado] DEFAULT ((0)),
 CONSTRAINT [PK_N_Articulos] PRIMARY KEY CLUSTERED 
(
	[ID_Articulo] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Entradas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Entradas](
	[ID_Entrada] [bigint] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_TipoEntrada] [int] NULL,
	[Referencia] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Fecha] [datetime] NULL,
	[ID_Estado] [int] NULL,
	[ID_Proveedor] [int] NULL,
	[ID_FormaPago] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IRPFPorciento] [float] NULL CONSTRAINT [DF_N_Entradas_REPorciento]  DEFAULT ((0)),
	[IRPFCantidad] [float] NULL CONSTRAINT [DF_N_Entradas_ReCantidad]  DEFAULT ((0)),
	[Total] [float] NULL,
	[Observaciones] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[PlazoEntrega] [datetime] NULL,
	[Validez] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PortePagado] [bit] NULL CONSTRAINT [DF_N_Entradas_PortePagado]  DEFAULT ((1)),
	[PorteDebido] [bit] NULL CONSTRAINT [DF_N_Entradas_PorteDebido]  DEFAULT ((0)),
	[PorteTexto] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Privado] [nvarchar](200)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DocumentacionAsociada] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Comentarios] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Imagen] [image] NULL,
 CONSTRAINT [PK_N_Entradas] PRIMARY KEY CLUSTERED 
(
	[ID_Entrada] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Entradas_Totales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Entradas_Totales](
	[ID_Entrada] [bigint] NOT NULL,
	[ID_TipoIVA] [int] NOT NULL,
	[DescuentoPorciento] [float] NULL,
	[DescuentoCantidad] [float] NULL,
	[ProntoPagoPorciento] [float] NULL,
	[ProntoPagoCantidad] [float] NULL,
	[PortesPorciento] [float] NULL,
	[PortesCantidad] [float] NULL,
	[FinanciacionPorciento] [float] NULL,
	[FinanciacionCantidad] [float] NULL,
	[ImporteNeto] [float] NULL,
	[SubTotal] [float] NULL,
	[IVAPorciento] [float] NULL,
	[IVACantidad] [float] NULL,
	[REPorciento] [float] NULL,
	[RECantidad] [float] NULL,
 CONSTRAINT [PK_N_Entradas_Totales] PRIMARY KEY CLUSTERED 
(
	[ID_Entrada] ASC,
	[ID_TipoIVA] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Entradas_Lineas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Entradas_Lineas](
	[ID_EntradaLineas] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_Entrada] [bigint] NOT NULL,
	[Codigo] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_Articulo] [bigint] NULL,
	[Descripcion] [nvarchar](200)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Cantidad] [float] NULL,
	[Precio] [float] NULL,
	[Descuento1] [float] NULL,
	[Descuento2] [float] NULL,
	[Descuento3] [float] NULL,
	[Total] [float] NULL,
	[ID_TipoIVA] [int] NULL,
	[IVAIncluido] [bit] NOT NULL,
	[Costo] [float] NULL,
	[Imagen] [image] NULL,
	[Observaciones] [nvarchar](500)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_Almacen] [int] NULL,
	[Validado] [bit] NULL CONSTRAINT [DF_N_Entradas_Lineas_Validado]  DEFAULT ((0)),
	[ID_DocOrigen] [bigint] NULL,
	[ID_TipoDocOrigen] [int] NULL,
 CONSTRAINT [PK_N_Entradas_Lineas] PRIMARY KEY CLUSTERED 
(
	[ID_EntradaLineas] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor_Totales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_PedidosProveedor_Totales](
	[ID_PedidoProveedor] [bigint] NOT NULL,
	[ID_TipoIVA] [int] NOT NULL,
	[DescuentoPorciento] [float] NULL,
	[DescuentoCantidad] [float] NULL,
	[ProntoPagoPorciento] [float] NULL,
	[ProntoPagoCantidad] [float] NULL,
	[PortesPorciento] [float] NULL,
	[PortesCantidad] [float] NULL,
	[FinanciacionPorciento] [float] NULL,
	[FinanciacionCantidad] [float] NULL,
	[ImporteNeto] [float] NULL,
	[SubTotal] [float] NULL,
	[IVAPorciento] [float] NULL,
	[IVACantidad] [float] NULL,
	[REPorciento] [float] NULL,
	[RECantidad] [float] NULL,
 CONSTRAINT [PK_N_PedidosProveedor_Totales] PRIMARY KEY CLUSTERED 
(
	[ID_PedidoProveedor] ASC,
	[ID_TipoIVA] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor_Lineas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_PedidosProveedor_Lineas](
	[ID_PedidoProveedorLineas] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_PedidoProveedor] [bigint] NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_Articulo] [bigint] NULL,
	[Descripcion] [nvarchar](200)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Cantidad] [float] NULL,
	[Precio] [float] NULL,
	[Descuento1] [float] NULL,
	[Descuento2] [float] NULL,
	[Descuento3] [float] NULL,
	[Total] [float] NULL,
	[ID_TipoIVA] [int] NULL,
	[IVAIncluido] [bit] NOT NULL,
	[Costo] [float] NULL,
	[Imagen] [image] NULL,
	[Observaciones] [nvarchar](500)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_Almacen] [int] NULL,
	[Validado] [bit] NULL CONSTRAINT [DF_N_PedidosProveedor_Lineas_Validado]  DEFAULT ((0)),
	[Pendiente] [bigint] NULL CONSTRAINT [DF_N_PedidosProveedor_Lineas_Recibido]  DEFAULT ((0)),
 CONSTRAINT [PK_N_PedidosProveedor_Lineas] PRIMARY KEY CLUSTERED 
(
	[ID_PedidoProveedorLineas] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas_Totales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_FacturasRecibidas_Totales](
	[ID_FacturaRecibida] [bigint] NOT NULL,
	[ID_TipoIVA] [int] NOT NULL,
	[DescuentoPorciento] [float] NULL,
	[DescuentoCantidad] [float] NULL,
	[ProntoPagoPorciento] [float] NULL,
	[ProntoPagoCantidad] [float] NULL,
	[PortesPorciento] [float] NULL,
	[PortesCantidad] [float] NULL,
	[FinanciacionPorciento] [float] NULL,
	[FinanciacionCantidad] [float] NULL,
	[ImporteNeto] [float] NULL,
	[SubTotal] [float] NULL,
	[IVAPorciento] [float] NULL,
	[IVACantidad] [float] NULL,
	[REPorciento] [float] NULL,
	[RECantidad] [float] NULL,
 CONSTRAINT [PK_N_FacturasRecibidas_Totales] PRIMARY KEY CLUSTERED 
(
	[ID_FacturaRecibida] ASC,
	[ID_TipoIVA] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas_Lineas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_FacturasRecibidas_Lineas](
	[ID_FacturaRecibidaLineas] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_FacturaRecibida] [bigint] NOT NULL,
	[Codigo] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_Articulo] [bigint] NULL,
	[Descripcion] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Cantidad] [float] NULL,
	[Precio] [float] NULL,
	[Descuento1] [float] NULL,
	[Descuento2] [float] NULL,
	[Descuento3] [float] NULL,
	[Total] [float] NULL,
	[ID_TipoIVA] [int] NULL,
	[IVAIncluido] [bit] NOT NULL,
	[Costo] [float] NULL,
	[Imagen] [image] NULL,
	[Observaciones] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_Almacen] [int] NULL,
	[Validado] [bit] NULL CONSTRAINT [DF_N_FacturasRecibidas_Lineas_Validado]  DEFAULT ((0)),
	[ID_DocOrigen] [int] NULL,
	[ID_TipoDocOrigen] [int] NULL,
 CONSTRAINT [PK_N_FacturasRecibidas_Lineas] PRIMARY KEY CLUSTERED 
(
	[ID_FacturaRecibidaLineas] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Proveedores]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Proveedores](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
	[CodigoContabilidad] [int] NULL,
	[TipoProveedor] [int] NOT NULL CONSTRAINT [DF_N_Proveedores_TipoProveedor]  DEFAULT ((1)),
	[NIF] [nvarchar](20)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NombreFiscal] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL CONSTRAINT [DF_N_Proveedores_NombreFiscal]  DEFAULT (''),
	[NombreComercial] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL CONSTRAINT [DF_N_Proveedores_NombreComercial]  DEFAULT (''),
	[Domicilio] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_Poblacion] [int] NULL,
	[CodigoPostal] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Telefono] [nvarchar](20)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Fax] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Movil] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_Banco] [int] NULL,
	[CCC] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_FormaPago] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DiasPago1] [int] NULL,
	[DiasPago2] [int] NULL,
	[DiasPago3] [int] NULL,
	[AprovisionamientoMeses] [int] NULL,
	[AprovisionamientoDias] [int] NULL,
	[TarifaEnActivo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[DescuentoFijo1] [float] NULL,
	[DescuentoFijo2] [float] NULL,
	[DescuentoFijo3] [float] NULL,
	[PorcentajeRetension] [float] NULL,
	[TipoPorte] [int] NULL,
	[Porte] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[RappelFijo] [float] NULL,
	[PagoRapels] [nvarchar](100)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FechaAlta] [datetime] NULL,
	[Web] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Email] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Observaciones] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Horario] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[VacacionesDesde] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[VacacionesHasta] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[NoVenderArticulos] [bit] NULL,
	[NoRealizarPagos] [bit] NULL,
	[NoImprimir] [bit] NULL,
	[TipoIVA] [int] NULL,
	[RE] [bit] NULL,
 CONSTRAINT [PK_N_Proveedores] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Articulos_Proveedores]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Articulos_Proveedores](
	[ID_Articulo] [bigint] NOT NULL,
	[ID_Proveedor] [int] NOT NULL,
	[Precio] [float] NULL CONSTRAINT [DF_N_Articulos_Proveedores_Precio]  DEFAULT ((0)),
	[Descuento1] [float] NULL CONSTRAINT [DF_N_Articulos_Proveedores_Descuento1]  DEFAULT ((0)),
	[Descuento2] [float] NULL CONSTRAINT [DF_N_Articulos_Proveedores_Descuento2]  DEFAULT ((0)),
	[Descuento3] [float] NULL CONSTRAINT [DF_N_Articulos_Proveedores_Descuento3]  DEFAULT ((0)),
	[Resultado] [float] NULL CONSTRAINT [DF_N_Articulos_Proveedores_Resultado]  DEFAULT ((0)),
	[Referencia] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
 CONSTRAINT [PK_N_Articulos_Proveedores] PRIMARY KEY CLUSTERED 
(
	[ID_Articulo] ASC,
	[ID_Proveedor] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_PedidosProveedor](
	[ID_PedidoProveedor] [bigint] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_TipoPedidoProveedor] [int] NULL,
	[Referencia] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Fecha] [datetime] NULL,
	[ID_Estado] [int] NULL,
	[ID_Proveedor] [int] NULL,
	[ID_FormaPago] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IRPFPorciento] [float] NULL CONSTRAINT [DF_N_PedidosProveedor_REPorciento]  DEFAULT ((0)),
	[IRPFCantidad] [float] NULL CONSTRAINT [DF_N_PedidosProveedor_ReCantidad]  DEFAULT ((0)),
	[Total] [float] NULL,
	[Observaciones] [nvarchar](200)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PlazoEntrega] [datetime] NULL,
	[Validez] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PortePagado] [bit] NULL CONSTRAINT [DF_N_PedidosProveedor_PortePagado]  DEFAULT ((1)),
	[PorteDebido] [bit] NULL CONSTRAINT [DF_N_PedidosProveedor_PorteDebido]  DEFAULT ((0)),
	[PorteTexto] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Privado] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[DocumentacionAsociada] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Comentarios] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Imagen] [image] NULL,
 CONSTRAINT [PK_N_PedidosProveedor] PRIMARY KEY CLUSTERED 
(
	[ID_PedidoProveedor] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_FacturasRecibidas](
	[ID_FacturaRecibida] [bigint] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_TipoFacturaRecibida] [int] NULL,
	[Referencia] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Fecha] [datetime] NULL,
	[ID_Estado] [int] NULL,
	[ID_Proveedor] [int] NULL,
	[ID_FormaPago] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IRPFPorciento] [float] NULL CONSTRAINT [DF_N_FacturasRecibidas_REPorciento]  DEFAULT ((0)),
	[IRPFCantidad] [float] NULL CONSTRAINT [DF_N_FacturasRecibidas_ReCantidad]  DEFAULT ((0)),
	[Total] [float] NULL,
	[Observaciones] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[PlazoEntrega] [datetime] NULL,
	[Validez] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PortePagado] [bit] NULL CONSTRAINT [DF_N_FacturasRecibidas_PortePagado]  DEFAULT ((1)),
	[PorteDebido] [bit] NULL CONSTRAINT [DF_N_FacturasRecibidas_PorteDebido]  DEFAULT ((0)),
	[PorteTexto] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Privado] [nvarchar](200)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DocumentacionAsociada] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Comentarios] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[Imagen] [image] NULL,
	[CodigoFacturaRecibida] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_N_FacturasRecibidas] PRIMARY KEY CLUSTERED 
(
	[ID_FacturaRecibida] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Articulos_ConsolidacionStock]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Articulos_ConsolidacionStock](
	[ID_Consolidacion] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_Articulo] [bigint] NULL,
	[ID_Almacen] [int] NULL,
	[Fecha] [datetime] NULL CONSTRAINT [DF_N_Articulos_ConsolidacionStock_Fecha]  DEFAULT (getdate()),
	[StockActual] [float] NULL,
	[UnidadesContadas] [float] NULL,
	[RestarAUnidadesContadas] [bit] NULL CONSTRAINT [DF_N_Articulos_ConsolidacionStock_RestarAUnidadesContadas]  DEFAULT ((1)),
	[Disponibles] [float] NULL,
 CONSTRAINT [PK_N_Articulos_ConsolidacionStock] PRIMARY KEY CLUSTERED 
(
	[ID_Consolidacion] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Restar a las "UnidadesContadas" los pedidos de clientes pendientes a enviar' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'N_Articulos_ConsolidacionStock', @level2type=N'COLUMN', @level2name=N'RestarAUnidadesContadas'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Articulos_Almacen]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Articulos_Almacen](
	[ID_Articulo] [bigint] NULL,
	[ID_Almacen] [int] NULL,
	[StockMinimo] [int] NOT NULL CONSTRAINT [DF_N_Articulos_Almacen_StockMinimo]  DEFAULT ((0)),
	[StockMaximo] [int] NOT NULL CONSTRAINT [DF_N_Articulos_Almacen_StockMaximo]  DEFAULT ((0))
) ON [PRIMARY]
END
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Provincias]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Provincias](
	[ID_Provincias] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
	[ID_Pais] [int] NOT NULL,
 CONSTRAINT [PK_N_Provincias] PRIMARY KEY CLUSTERED 
(
	[ID_Provincias] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Familias]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Familias](
	[ID_Familia] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Nombre] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_Seccion] [int] NULL,
	[Texto_predefinido] [nvarchar](50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CuentaCompras] [int] NULL,
	[CuentaVentas] [nchar](10)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_N_Familias] PRIMARY KEY CLUSTERED 
(
	[ID_Familia] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER TABLE dbo.BANCOS ADD
	IdBanco int NOT NULL IDENTITY (1, 1)
GO
ALTER TABLE dbo.BANCOS
	DROP CONSTRAINT PK_BANCOS
GO
ALTER TABLE dbo.BANCOS ADD CONSTRAINT
	PK_BANCOS_1 PRIMARY KEY CLUSTERED 
	(
	IdBanco
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[N_Poblaciones]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[N_Poblaciones](
	[ID_Poblacion] [int] NOT NULL,
	[Nombre] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
	[ID_Provincia] [int] NOT NULL,
 CONSTRAINT [PK_N_Poblaciones] PRIMARY KEY CLUSTERED 
(
	[ID_Poblacion] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Articulos_N_Articulos_Tipo]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Articulos]'))
ALTER TABLE [dbo].[N_Articulos]  WITH CHECK ADD  CONSTRAINT [FK_N_Articulos_N_Articulos_Tipo] FOREIGN KEY([ID_TipoArticulo])
REFERENCES [dbo].[N_Articulos_Tipo] ([ID_TipoArticulo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Articulos_N_Familias]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Articulos]'))
ALTER TABLE [dbo].[N_Articulos]  WITH CHECK ADD  CONSTRAINT [FK_N_Articulos_N_Familias] FOREIGN KEY([ID_Familia])
REFERENCES [dbo].[N_Familias] ([ID_Familia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Articulos_N_Proveedores]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Articulos]'))
ALTER TABLE [dbo].[N_Articulos]  WITH CHECK ADD  CONSTRAINT [FK_N_Articulos_N_Proveedores] FOREIGN KEY([ID_ProveedorHabitual])
REFERENCES [dbo].[N_Proveedores] ([ID_Proveedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Articulos_N_TipoIVA]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Articulos]'))
ALTER TABLE [dbo].[N_Articulos]  WITH CHECK ADD  CONSTRAINT [FK_N_Articulos_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Entradas_N_Entradas_Tipos]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Entradas]'))
ALTER TABLE [dbo].[N_Entradas]  WITH CHECK ADD  CONSTRAINT [FK_N_Entradas_N_Entradas_Tipos] FOREIGN KEY([ID_TipoEntrada])
REFERENCES [dbo].[N_Entradas_Tipos] ([ID_TipoEntrada])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Entradas_N_Proveedores]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Entradas]'))
ALTER TABLE [dbo].[N_Entradas]  WITH CHECK ADD  CONSTRAINT [FK_N_Entradas_N_Proveedores] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[N_Proveedores] ([ID_Proveedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Entradas_Totales_N_Entradas]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Entradas_Totales]'))
ALTER TABLE [dbo].[N_Entradas_Totales]  WITH CHECK ADD  CONSTRAINT [FK_N_Entradas_Totales_N_Entradas] FOREIGN KEY([ID_Entrada])
REFERENCES [dbo].[N_Entradas] ([ID_Entrada])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Entradas_Totales_N_TipoIVA]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Entradas_Totales]'))
ALTER TABLE [dbo].[N_Entradas_Totales]  WITH CHECK ADD  CONSTRAINT [FK_N_Entradas_Totales_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Entradas_Lineas_N_Almacen]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Entradas_Lineas]'))
ALTER TABLE [dbo].[N_Entradas_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_Entradas_Lineas_N_Almacen] FOREIGN KEY([ID_Almacen])
REFERENCES [dbo].[N_Almacen] ([ID_Almacen])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Entradas_Lineas_N_Entradas]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Entradas_Lineas]'))
ALTER TABLE [dbo].[N_Entradas_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_Entradas_Lineas_N_Entradas] FOREIGN KEY([ID_Entrada])
REFERENCES [dbo].[N_Entradas] ([ID_Entrada])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Entradas_Lineas_N_TipoIVA]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Entradas_Lineas]'))
ALTER TABLE [dbo].[N_Entradas_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_Entradas_Lineas_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_PedidosProveedor_Totales_N_PedidosProveedor]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor_Totales]'))
ALTER TABLE [dbo].[N_PedidosProveedor_Totales]  WITH CHECK ADD  CONSTRAINT [FK_N_PedidosProveedor_Totales_N_PedidosProveedor] FOREIGN KEY([ID_PedidoProveedor])
REFERENCES [dbo].[N_PedidosProveedor] ([ID_PedidoProveedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_PedidosProveedor_Totales_N_TipoIVA]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor_Totales]'))
ALTER TABLE [dbo].[N_PedidosProveedor_Totales]  WITH CHECK ADD  CONSTRAINT [FK_N_PedidosProveedor_Totales_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_PedidosProveedor_Lineas_N_Almacen]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor_Lineas]'))
ALTER TABLE [dbo].[N_PedidosProveedor_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_PedidosProveedor_Lineas_N_Almacen] FOREIGN KEY([ID_Almacen])
REFERENCES [dbo].[N_Almacen] ([ID_Almacen])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_PedidosProveedor_Lineas_N_PedidosProveedor]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor_Lineas]'))
ALTER TABLE [dbo].[N_PedidosProveedor_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_PedidosProveedor_Lineas_N_PedidosProveedor] FOREIGN KEY([ID_PedidoProveedor])
REFERENCES [dbo].[N_PedidosProveedor] ([ID_PedidoProveedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_PedidosProveedor_Lineas_N_TipoIVA]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor_Lineas]'))
ALTER TABLE [dbo].[N_PedidosProveedor_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_PedidosProveedor_Lineas_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_FacturasRecibidas_Totales_N_FacturasRecibidas]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas_Totales]'))
ALTER TABLE [dbo].[N_FacturasRecibidas_Totales]  WITH CHECK ADD  CONSTRAINT [FK_N_FacturasRecibidas_Totales_N_FacturasRecibidas] FOREIGN KEY([ID_FacturaRecibida])
REFERENCES [dbo].[N_FacturasRecibidas] ([ID_FacturaRecibida])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_FacturasRecibidas_Totales_N_TipoIVA]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas_Totales]'))
ALTER TABLE [dbo].[N_FacturasRecibidas_Totales]  WITH CHECK ADD  CONSTRAINT [FK_N_FacturasRecibidas_Totales_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_FacturasRecibidas_Lineas_N_Almacen]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas_Lineas]'))
ALTER TABLE [dbo].[N_FacturasRecibidas_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_FacturasRecibidas_Lineas_N_Almacen] FOREIGN KEY([ID_Almacen])
REFERENCES [dbo].[N_Almacen] ([ID_Almacen])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_FacturasRecibidas_Lineas_N_FacturasRecibidas]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas_Lineas]'))
ALTER TABLE [dbo].[N_FacturasRecibidas_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_FacturasRecibidas_Lineas_N_FacturasRecibidas] FOREIGN KEY([ID_FacturaRecibida])
REFERENCES [dbo].[N_FacturasRecibidas] ([ID_FacturaRecibida])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_FacturasRecibidas_Lineas_N_TipoIVA]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas_Lineas]'))
ALTER TABLE [dbo].[N_FacturasRecibidas_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_FacturasRecibidas_Lineas_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Proveedores_Bancos]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Proveedores]'))
ALTER TABLE [dbo].[N_Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_N_Proveedores_N_Bancos] FOREIGN KEY([ID_Banco])
REFERENCES [dbo].[Bancos] ([IdBanco])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Proveedores_FormasPago]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Proveedores]'))
ALTER TABLE [dbo].[N_Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_N_Proveedores_FormasPago] FOREIGN KEY([ID_FormaPago])
REFERENCES [dbo].[FormasPago] ([CODIGO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Entradas_FormasPago]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Entradas]'))
ALTER TABLE [dbo].[N_Entradas]  WITH CHECK ADD  CONSTRAINT [FK_N_Entradas_FormasPago] FOREIGN KEY([ID_FormaPago])
REFERENCES [dbo].[FormasPago] ([CODIGO])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_PedidosProveedor_FormasPago]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor]'))
ALTER TABLE [dbo].[N_PedidosProveedor]  WITH CHECK ADD  CONSTRAINT [FK_N_PedidosProveedor_FormasPago] FOREIGN KEY([ID_FormaPago])
REFERENCES [dbo].[FormasPago] ([CODIGO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_FacturasRecibidas_FormasPago]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas]'))
ALTER TABLE [dbo].[N_FacturasRecibidas]  WITH CHECK ADD  CONSTRAINT [FK_N_FacturasRecibidas_FormasPago] FOREIGN KEY([ID_FormaPago])
REFERENCES [dbo].[FormasPago] ([CODIGO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Articulos_Proveedores_N_Articulos]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Articulos_Proveedores]'))
ALTER TABLE [dbo].[N_Articulos_Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_N_Articulos_Proveedores_N_Articulos] FOREIGN KEY([ID_Articulo])
REFERENCES [dbo].[N_Articulos] ([ID_Articulo])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Articulos_Proveedores_N_Proveedores]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Articulos_Proveedores]'))
ALTER TABLE [dbo].[N_Articulos_Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_N_Articulos_Proveedores_N_Proveedores] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[N_Proveedores] ([ID_Proveedor])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_PedidosProveedor_N_PedidosProveedor_Tipos]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor]'))
ALTER TABLE [dbo].[N_PedidosProveedor]  WITH CHECK ADD  CONSTRAINT [FK_N_PedidosProveedor_N_PedidosProveedor_Tipos] FOREIGN KEY([ID_TipoPedidoProveedor])
REFERENCES [dbo].[N_PedidosProveedor_Tipos] ([ID_TipoPedidoProveedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_PedidosProveedor_N_Proveedores]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_PedidosProveedor]'))
ALTER TABLE [dbo].[N_PedidosProveedor]  WITH CHECK ADD  CONSTRAINT [FK_N_PedidosProveedor_N_Proveedores] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[N_Proveedores] ([ID_Proveedor])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_FacturasRecibidas_N_FacturasRecibidas_Tipos]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas]'))
ALTER TABLE [dbo].[N_FacturasRecibidas]  WITH CHECK ADD  CONSTRAINT [FK_N_FacturasRecibidas_N_FacturasRecibidas_Tipos] FOREIGN KEY([ID_TipoFacturaRecibida])
REFERENCES [dbo].[N_FacturasRecibidas_Tipos] ([ID_TipoFacturaRecibida])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_FacturasRecibidas_N_Proveedores]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_FacturasRecibidas]'))
ALTER TABLE [dbo].[N_FacturasRecibidas]  WITH CHECK ADD  CONSTRAINT [FK_N_FacturasRecibidas_N_Proveedores] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[N_Proveedores] ([ID_Proveedor])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Articulos_ConsolidacionStock_N_Almacen]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Articulos_ConsolidacionStock]'))
ALTER TABLE [dbo].[N_Articulos_ConsolidacionStock]  WITH CHECK ADD  CONSTRAINT [FK_N_Articulos_ConsolidacionStock_N_Almacen] FOREIGN KEY([ID_Almacen])
REFERENCES [dbo].[N_Almacen] ([ID_Almacen])
ON UPDATE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Articulos_ConsolidacionStock_N_Articulos]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Articulos_ConsolidacionStock]'))
ALTER TABLE [dbo].[N_Articulos_ConsolidacionStock]  WITH CHECK ADD  CONSTRAINT [FK_N_Articulos_ConsolidacionStock_N_Articulos] FOREIGN KEY([ID_Articulo])
REFERENCES [dbo].[N_Articulos] ([ID_Articulo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Articulos_Almacen_N_Almacen]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Articulos_Almacen]'))
ALTER TABLE [dbo].[N_Articulos_Almacen]  WITH CHECK ADD  CONSTRAINT [FK_N_Articulos_Almacen_N_Almacen] FOREIGN KEY([ID_Almacen])
REFERENCES [dbo].[N_Almacen] ([ID_Almacen])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Articulos_Almacen_N_Articulos]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Articulos_Almacen]'))
ALTER TABLE [dbo].[N_Articulos_Almacen]  WITH CHECK ADD  CONSTRAINT [FK_N_Articulos_Almacen_N_Articulos] FOREIGN KEY([ID_Articulo])
REFERENCES [dbo].[N_Articulos] ([ID_Articulo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Provincias_Paises]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Provincias]'))
ALTER TABLE [dbo].[N_Provincias]  WITH CHECK ADD  CONSTRAINT [FK_N_Provincias_PAISES] FOREIGN KEY([ID_Pais])
REFERENCES [dbo].[PAISES] ([CODIGO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_N_Poblacion_N_Provincias]') AND parent_object_id = OBJECT_ID(N'[dbo].[N_Poblaciones]'))
ALTER TABLE [dbo].[N_Poblaciones]  WITH CHECK ADD  CONSTRAINT [FK_N_Poblacion_N_Provincias] FOREIGN KEY([ID_Provincia])
REFERENCES [dbo].[N_Provincias] ([ID_Provincias])
ON UPDATE CASCADE
ON DELETE CASCADE
GO


/*BEGIN Insercion de N_Provincias*/

DELETE FROM N_Provincias
DBCC CHECKIDENT (N_Provincias, RESEED, 1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Álava',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Albacete',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Alicante',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Almería',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Ávila',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Badajoz',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Baleares (Illes)',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Barcelona',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Burgos',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Cáceres',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Cádiz',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Castellón',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Ciudad Real',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Córdoba',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('A Coruña',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Cuenca',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Girona',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Granada',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Guadalajara',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Guipúzcoa',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Huelva',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Huesca',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Jaén',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('León',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Lleida',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('La Rioja',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Lugo',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Madrid',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Málaga',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Murcia',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Navarra',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Ourense',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Asturias',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Palencia',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Las Palmas',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Pontevedra',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Salamanca',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Santa Cruz de Tenerife',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Cantabria',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Segovia',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Sevilla',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Soria',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Tarragona',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Teruel',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Toledo',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Valencia',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Valladolid',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Vizcaya',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Zamora',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Zaragoza',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Ceuta',1);
INSERT INTO N_Provincias (Nombre, ID_Pais) VALUES ('Melilla',1);
/*END Insercion de Provincias*/

/*BEGIN Insercion de las poblaciones de Espanna*/
DELETE FROM N_Poblaciones
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (1, 1, 'Alegría-Dulantzi');
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES(2, 1, 'Amurrio'); 
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3, 1, 'Añana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4, 1, 'Aramaio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5, 1, 'Armiñón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6, 1, 'Arraia-Maeztu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7, 1, 'Arrazua-Ubarrundia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8, 1, 'Artziniega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(9, 1, 'Asparrena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(10, 1, 'Ayala/Aiara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(11, 1, 'Baños de Ebro/Mañueta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(12, 1, 'Alegría-Dulantzi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(13, 1, 'Amurrio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(14, 1, 'Añana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(15, 1, 'Aramaio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(16, 1, 'Armiñón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(17, 1, 'Arraia-Maeztu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(18, 1, 'Arrazua-Ubarrundia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(19, 1, 'Artziniega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(20, 1, 'Asparrena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(21, 1, 'Ayala/Aiara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(41, 1, 'Laudio/Llodio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(42, 1, 'Legutiano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(43, 1, 'Leza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(22, 1, 'Baños de Ebro/Mañueta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(23, 1, 'Barrundia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(24, 1, 'Berantevilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(25, 1, 'Bernedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(26, 1, 'Campezo/Kanpezu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(27, 1, 'Elburgo/Burgelu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(28, 1, 'Elciego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(29, 1, 'Elvillar/Bilar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(30, 1, 'Harana/Valle de Arana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(31, 1, 'Iruña Oka/Iruña de Oca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(32, 1, 'Iruraiz-Gauna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(33, 1, 'Kripan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(34, 1, 'Kuartango'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(35, 1, 'Labastida/Bastida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(36, 1, 'Lagrán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(37, 1, 'Laguardia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(38, 1, 'Lanciego/Lantziego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(39, 1, 'Lantarón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(40, 1, 'Lapuebla de Labarca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(44, 1, 'Moreda de Álava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(45, 1, 'Navaridas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(46, 1, 'Okondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(47, 1, 'Oyón-Oion'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(48, 1, 'Peñacerrada-Urizaharra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(49, 1, 'Ribera Alta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(50, 1, 'Ribera Baja/Erribera Beitia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(51, 1, 'Salvatierra/Agurain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(52, 1, 'Samaniego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(53, 1, 'San Millán/Donemiliaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(54, 1, 'Urkabustaiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(55, 1, 'Valdegovía/Gaubea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(56, 1, 'Villabuena de Álava/Eskuernaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(57, 1, 'Vitoria-Gasteiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(58, 1, 'Yécora/Iekora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(59, 1, 'Zalduondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(60, 1, 'Zambrana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(61, 1, 'Zigoitia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(62, 1, 'Zuia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(102, 2, 'Hoya-Gonzalo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(103, 2, 'Jorquera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(104, 2, 'Letur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(105, 2, 'Lezuza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(106, 2, 'Liétor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(107, 2, 'Madrigueras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(108, 2, 'Mahora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(83, 2, 'Casas de Juan Núñez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(84, 2, 'Casas de Lázaro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(85, 2, 'Casas de Ves'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(86, 2, 'Casas-Ibáñez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(87, 2, 'Caudete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(88, 2, 'Cenizate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(89, 2, 'Chinchilla de Monte-Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(90, 2, 'Corral-Rubio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(91, 2, 'Cotillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(92, 2, 'Elche de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(93, 2, 'Férez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(94, 2, 'Fuensanta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(95, 2, 'Fuente-Álamo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(96, 2, 'Fuentealbilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(97, 2, 'Gineta (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(98, 2, 'Golosalvo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(99, 2, 'Hellín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(100, 2, 'Herrera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(101, 2, 'Higueruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(63, 2, 'Abengibre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(64, 2, 'Alatoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(65, 2, 'Albacete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(66, 2, 'Albatana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(67, 2, 'Alborea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(68, 2, 'Alcadozo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(69, 2, 'Alcalá del Júcar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(70, 2, 'Alcaraz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(71, 2, 'Almansa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(72, 2, 'Alpera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(73, 2, 'Ayna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(74, 2, 'Balazote'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(75, 2, 'Ballestero (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(76, 2, 'Balsa de Ves'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(77, 2, 'Barrax'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(78, 2, 'Bienservida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(79, 2, 'Bogarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(80, 2, 'Bonete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(81, 2, 'Bonillo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(82, 2, 'Carcelén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(109, 2, 'Masegoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(110, 2, 'Minaya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(111, 2, 'Molinicos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(112, 2, 'Montalvos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(113, 2, 'Montealegre del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(114, 2, 'Motilleja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(115, 2, 'Munera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(116, 2, 'Navas de Jorquera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(117, 2, 'Nerpio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(118, 2, 'Ontur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(119, 2, 'Ossa de Montiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(120, 2, 'Paterna del Madera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(121, 2, 'Peñas de San Pedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(122, 2, 'Peñascosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(123, 2, 'Pétrola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(124, 2, 'Povedilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(125, 2, 'Pozo Cañada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(126, 2, 'Pozohondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(127, 2, 'Pozo-Lorente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(166, 3, 'Alqueria d''Asnar (l'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(167, 3, 'Altea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(168, 3, 'Aspe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(169, 3, 'Balones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(170, 3, 'Banyeres de Mariola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(171, 3, 'Benasau'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(172, 3, 'Beneixama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(147, 2, 'Villaverde de Guadalimar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(148, 2, 'Viveros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(149, 2, 'Yeste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(150, 3, 'Adsubia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(151, 3, 'Agost'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(152, 3, 'Agres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(153, 3, 'Aigües'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(154, 3, 'Albatera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(155, 3, 'Alcalalí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(156, 3, 'Alcocer de Planes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(157, 3, 'Alcoleja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(158, 3, 'Alcoy/Alcoi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(159, 3, 'Alfafara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(160, 3, 'Alfàs del Pi (l'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(161, 3, 'Algorfa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(162, 3, 'Algueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(163, 3, 'Alicante/Alacant'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(164, 3, 'Almoradí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(165, 3, 'Almudaina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(128, 2, 'Pozuelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(129, 2, 'Recueja (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(130, 2, 'Riópar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(131, 2, 'Robledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(132, 2, 'Roda (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(133, 2, 'Salobre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(134, 2, 'San Pedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(135, 2, 'Socovos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(136, 2, 'Tarazona de la Mancha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(137, 2, 'Tobarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(138, 2, 'Valdeganga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(139, 2, 'Vianos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(140, 2, 'Villa de Ves'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(141, 2, 'Villalgordo del Júcar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(142, 2, 'Villamalea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(143, 2, 'Villapalacios'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(144, 2, 'Villarrobledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(145, 2, 'Villatoya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(146, 2, 'Villavaliente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(173, 3, 'Benejúzar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(174, 3, 'Benferri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(175, 3, 'Beniarbeig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(176, 3, 'Beniardá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(177, 3, 'Beniarrés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(178, 3, 'Benidoleig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(179, 3, 'Benidorm'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(180, 3, 'Benifallim'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(181, 3, 'Benifato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(182, 3, 'Benigembla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(183, 3, 'Benijófar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(184, 3, 'Benilloba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(185, 3, 'Benillup'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(186, 3, 'Benimantell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(187, 3, 'Benimarfull'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(188, 3, 'Benimassot'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(189, 3, 'Benimeli'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(190, 3, 'Benissa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(191, 3, 'Benitachell/Poble Nou de Benitatxell (el)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(230, 3, 'Jávea/Xàbia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(231, 3, 'Jijona/Xixona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(232, 3, 'Llíber'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(233, 3, 'Lorcha/Orxa (l'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(234, 3, 'Millena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(235, 3, 'Monforte del Cid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(211, 3, 'Daya Vieja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(212, 3, 'Dénia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(213, 3, 'Dolores'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(214, 3, 'Elche/Elx'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(215, 3, 'Elda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(216, 3, 'Facheca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(217, 3, 'Famorca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(218, 3, 'Finestrat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(219, 3, 'Fondó de les Neus (el)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(220, 3, 'Formentera del Segura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(221, 3, 'Gaianes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(222, 3, 'Gata de Gorgos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(223, 3, 'Gorga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(224, 3, 'Granja de Rocamora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(225, 3, 'Guardamar del Segura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(226, 3, 'Hondón de los Frailes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(227, 3, 'Ibi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(228, 3, 'Jacarilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(229, 3, 'Jalón/Xaló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(192, 3, 'Biar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(193, 3, 'Bigastro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(194, 3, 'Bolulla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(195, 3, 'Busot'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(196, 3, 'Callosa de Segura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(197, 3, 'Callosa d''En Sarrià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(198, 3, 'Calpe/Calp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(199, 3, 'Campello (el)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(200, 3, 'Campo de Mirra/Camp de Mirra (el)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(201, 3, 'Cañada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(202, 3, 'Castalla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(203, 3, 'Castell de Castells'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(204, 3, 'Castell de Guadalest (el)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(205, 3, 'Catral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(206, 3, 'Cocentaina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(207, 3, 'Confrides'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(208, 3, 'Cox'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(209, 3, 'Crevillent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(210, 3, 'Daya Nueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(236, 3, 'Monóvar/Monòver'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(237, 3, 'Montesinos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(238, 3, 'Murla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(239, 3, 'Muro de Alcoy'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(240, 3, 'Mutxamel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(241, 3, 'Novelda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(242, 3, 'Nucia (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(243, 3, 'Ondara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(244, 3, 'Onil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(245, 3, 'Orba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(246, 3, 'Orihuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(247, 3, 'Orxeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(248, 3, 'Parcent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(249, 3, 'Pedreguer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(250, 3, 'Pego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(251, 3, 'Penàguila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(252, 3, 'Petrer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(253, 3, 'Pilar de la Horadada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(254, 3, 'Pinós (el)/Pinoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(255, 3, 'Planes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(294, 4, 'Albánchez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(295, 4, 'Alboloduy'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(296, 4, 'Albox'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(297, 4, 'Alcolea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(298, 4, 'Alcóntar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(275, 3, 'Sella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(276, 3, 'Senija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(277, 3, 'Tàrbena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(278, 3, 'Teulada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(279, 3, 'Tibi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(280, 3, 'Tollos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(281, 3, 'Tormos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(282, 3, 'Torremanzanas/Torre de les Maçanes (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(283, 3, 'Torrevieja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(284, 3, 'Vall d''Alcalà (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(285, 3, 'Vall de Ebo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(286, 3, 'Vall de Gallinera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(287, 3, 'Vall de Laguar (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(288, 3, 'Verger (el)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(289, 3, 'Villajoyosa/Vila Joiosa (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(290, 3, 'Villena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(291, 4, 'Abla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(292, 4, 'Abrucena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(293, 4, 'Adra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(256, 3, 'Poblets (els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(257, 3, 'Polop'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(258, 3, 'Quatretondeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(259, 3, 'Rafal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(260, 3, 'Ràfol d''Almúnia (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(261, 3, 'Redován'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(262, 3, 'Relleu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(263, 3, 'Rojales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(264, 3, 'Romana (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(265, 3, 'Sagra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(266, 3, 'Salinas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(267, 3, 'San Fulgencio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(268, 3, 'San Isidro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(269, 3, 'San Miguel de Salinas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(270, 3, 'San Vicente del Raspeig/Sant Vicent del Raspeig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(271, 3, 'Sanet y Negrals'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(272, 3, 'Sant Joan d''Alacant'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(273, 3, 'Santa Pola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(274, 3, 'Sax'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(299, 4, 'Alcudia de Monteagud'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(300, 4, 'Alhabia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(301, 4, 'Alhama de Almería'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(302, 4, 'Alicún'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(303, 4, 'Almería'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(304, 4, 'Almócita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(305, 4, 'Alsodux'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(306, 4, 'Antas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(307, 4, 'Arboleas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(308, 4, 'Armuña de Almanzora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(309, 4, 'Bacares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(310, 4, 'Bayárcal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(311, 4, 'Bayarque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(312, 4, 'Bédar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(313, 4, 'Beires'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(314, 4, 'Benahadux'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(315, 4, 'Benitagla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(316, 4, 'Benizalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(317, 4, 'Bentarique'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(318, 4, 'Berja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(359, 4, 'Padules'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(360, 4, 'Partaloa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(361, 4, 'Paterna del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(362, 4, 'Pechina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(363, 4, 'Pulpí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(364, 4, 'Purchena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(365, 4, 'Rágol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(366, 4, 'Rioja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(339, 4, 'Huércal de Almería'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(340, 4, 'Huércal-Overa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(341, 4, 'Illar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(342, 4, 'Instinción'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(343, 4, 'Laroya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(344, 4, 'Láujar de Andarax'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(345, 4, 'Líjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(346, 4, 'Lubrín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(347, 4, 'Lucainena de las Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(348, 4, 'Lúcar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(349, 4, 'Macael'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(350, 4, 'María'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(351, 4, 'Mojácar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(352, 4, 'Mojonera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(353, 4, 'Nacimiento'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(354, 4, 'Níjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(355, 4, 'Ohanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(356, 4, 'Olula de Castro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(357, 4, 'Olula del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(358, 4, 'Oria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(319, 4, 'Canjáyar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(320, 4, 'Cantoria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(321, 4, 'Carboneras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(322, 4, 'Castro de Filabres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(323, 4, 'Chercos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(324, 4, 'Chirivel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(325, 4, 'Cóbdar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(326, 4, 'Cuevas del Almanzora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(327, 4, 'Dalías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(328, 4, 'Ejido (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(329, 4, 'Enix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(330, 4, 'Felix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(331, 4, 'Fines'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(332, 4, 'Fiñana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(333, 4, 'Fondón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(334, 4, 'Gádor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(335, 4, 'Gallardos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(336, 4, 'Garrucha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(337, 4, 'Gérgal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(338, 4, 'Huécija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(367, 4, 'Roquetas de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(368, 4, 'Santa Cruz de Marchena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(369, 4, 'Santa Fe de Mondújar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(370, 4, 'Senés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(371, 4, 'Serón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(372, 4, 'Sierro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(373, 4, 'Somontín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(374, 4, 'Sorbas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(375, 4, 'Suflí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(376, 4, 'Tabernas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(377, 4, 'Taberno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(378, 4, 'Tahal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(379, 4, 'Terque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(380, 4, 'Tíjola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(381, 4, 'Tres Villas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(382, 4, 'Turre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(383, 4, 'Turrillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(384, 4, 'Uleila del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(385, 4, 'Urrácal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(386, 4, 'Velefique'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(426, 5, 'Cabezas del Pozo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(427, 5, 'Cabezas del Villar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(428, 5, 'Cabizuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(429, 5, 'Canales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(407, 5, 'Barco de Ávila (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(408, 5, 'Barraco (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(409, 5, 'Barromán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(410, 5, 'Becedas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(411, 5, 'Becedillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(412, 5, 'Bercial de Zapardiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(413, 5, 'Berlanas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(414, 5, 'Bernuy-Zapardiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(415, 5, 'Berrocalejo de Aragona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(416, 5, 'Blascomillán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(417, 5, 'Blasconuño de Matacabras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(418, 5, 'Blascosancho'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(419, 5, 'Bohodón (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(420, 5, 'Bohoyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(421, 5, 'Bonilla de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(422, 5, 'Brabos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(423, 5, 'Bularros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(424, 5, 'Burgohondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(425, 5, 'Cabezas de Alambre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(387, 4, 'Vélez-Blanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(388, 4, 'Vélez-Rubio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(389, 4, 'Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(390, 4, 'Viator'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(391, 4, 'Vícar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(392, 4, 'Zurgena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(393, 5, 'Adanero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(394, 5, 'Adrada (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(395, 5, 'Albornos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(396, 5, 'Aldeanueva de Santa Cruz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(397, 5, 'Aldeaseca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(398, 5, 'Aldehuela (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(399, 5, 'Amavida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(400, 5, 'Arenal (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(401, 5, 'Arenas de San Pedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(402, 5, 'Arevalillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(403, 5, 'Arévalo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(404, 5, 'Aveinte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(405, 5, 'Avellaneda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(406, 5, 'Ávila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(430, 5, 'Candeleda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(431, 5, 'Cantiveros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(432, 5, 'Cardeñosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(433, 5, 'Carrera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(434, 5, 'Casas del Puerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(435, 5, 'Casasola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(436, 5, 'Casavieja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(437, 5, 'Casillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(438, 5, 'Castellanos de Zapardiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(439, 5, 'Cebreros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(440, 5, 'Cepeda la Mora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(441, 5, 'Chamartín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(442, 5, 'Cillán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(443, 5, 'Cisla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(444, 5, 'Colilla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(445, 5, 'Collado de Contreras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(446, 5, 'Collado del Mirón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(447, 5, 'Constanzana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(448, 5, 'Crespos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(486, 5, 'Hurtumpascual'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(487, 5, 'Junciana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(488, 5, 'Langa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(468, 5, 'Gotarrendura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(469, 5, 'Grandes y San Martín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(470, 5, 'Guisando'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(471, 5, 'Gutierre-Muñoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(472, 5, 'Hernansancho'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(473, 5, 'Herradón de Pinares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(474, 5, 'Herreros de Suso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(475, 5, 'Higuera de las Dueñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(476, 5, 'Hija de Dios (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(477, 5, 'Horcajada (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(478, 5, 'Horcajo de las Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(479, 5, 'Hornillo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(480, 5, 'Hoyo de Pinares (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(481, 5, 'Hoyocasero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(482, 5, 'Hoyorredondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(483, 5, 'Hoyos de Miguel Muñoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(484, 5, 'Hoyos del Collado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(485, 5, 'Hoyos del Espino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(449, 5, 'Cuevas del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(450, 5, 'Diego del Carpio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(451, 5, 'Donjimeno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(452, 5, 'Donvidas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(453, 5, 'Espinosa de los Caballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(454, 5, 'Flores de Ávila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(455, 5, 'Fontiveros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(456, 5, 'Fresnedilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(457, 5, 'Fresno (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(458, 5, 'Fuente el Saúz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(459, 5, 'Fuentes de Año'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(460, 5, 'Gallegos de Altamiros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(461, 5, 'Gallegos de Sobrinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(462, 5, 'Garganta del Villar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(463, 5, 'Gavilanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(464, 5, 'Gemuño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(465, 5, 'Gil García'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(466, 5, 'Gilbuena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(467, 5, 'Gimialcón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(489, 5, 'Lanzahíta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(490, 5, 'Llanos de Tormes (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(491, 5, 'Losar del Barco (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(492, 5, 'Madrigal de las Altas Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(493, 5, 'Maello'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(494, 5, 'Malpartida de Corneja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(495, 5, 'Mamblas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(496, 5, 'Mancera de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(497, 5, 'Manjabálago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(498, 5, 'Marlín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(499, 5, 'Martiherrero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(500, 5, 'Martínez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(501, 5, 'Mediana de Voltoya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(502, 5, 'Medinilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(503, 5, 'Mengamuñoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(504, 5, 'Mesegar de Corneja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(505, 5, 'Mijares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(506, 5, 'Mingorría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(507, 5, 'Mirón (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(546, 5, 'Neila de San Miguel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(527, 5, 'Nava del Barco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(528, 5, 'Navacepedilla de Corneja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(529, 5, 'Navadijos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(530, 5, 'Navaescurial'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(531, 5, 'Navahondilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(532, 5, 'Navalacruz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(533, 5, 'Navalmoral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(534, 5, 'Navalonguilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(535, 5, 'Navalosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(536, 5, 'Navalperal de Pinares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(537, 5, 'Navalperal de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(538, 5, 'Navaluenga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(539, 5, 'Navaquesera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(540, 5, 'Navarredonda de Gredos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(541, 5, 'Navarredondilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(542, 5, 'Navarrevisca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(543, 5, 'Navas del Marqués (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(544, 5, 'Navatalgordo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(545, 5, 'Navatejares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(508, 5, 'Mironcillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(509, 5, 'Mirueña de los Infanzones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(510, 5, 'Mombeltrán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(511, 5, 'Monsalupe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(512, 5, 'Moraleja de Matacabras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(513, 5, 'Muñana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(514, 5, 'Muñico'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(515, 5, 'Muñogalindo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(516, 5, 'Muñogrande'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(517, 5, 'Muñomer del Peco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(518, 5, 'Muñopepe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(519, 5, 'Muñosancho'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(520, 5, 'Muñotello'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(521, 5, 'Narrillos del Álamo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(522, 5, 'Narrillos del Rebollar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(523, 5, 'Narros de Saldueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(524, 5, 'Narros del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(525, 5, 'Narros del Puerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(526, 5, 'Nava de Arévalo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(547, 5, 'Niharra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(548, 5, 'Ojos-Albos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(549, 5, 'Orbita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(550, 5, 'Oso (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(551, 5, 'Padiernos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(552, 5, 'Pajares de Adaja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(553, 5, 'Palacios de Goda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(554, 5, 'Papatrigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(555, 5, 'Parral (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(556, 5, 'Pascualcobo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(557, 5, 'Pedro Bernardo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(558, 5, 'Pedro-Rodríguez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(559, 5, 'Peguerinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(560, 5, 'Peñalba de Ávila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(561, 5, 'Piedrahíta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(562, 5, 'Piedralaves'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(563, 5, 'Poveda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(564, 5, 'Poyales del Hoyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(565, 5, 'Pozanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(584, 5, 'San Juan del Molinillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(585, 5, 'San Juan del Olmo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(586, 5, 'San Lorenzo de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(587, 5, 'San Martín de la Vega del Alberche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(588, 5, 'San Martín del Pimpollar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(589, 5, 'San Miguel de Corneja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(590, 5, 'San Miguel de Serrezuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(591, 5, 'San Pascual'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(592, 5, 'San Pedro del Arroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(593, 5, 'San Vicente de Arévalo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(594, 5, 'Sanchidrián'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(595, 5, 'Sanchorreja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(596, 5, 'Santa Cruz de Pinares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(597, 5, 'Santa Cruz del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(598, 5, 'Santa María de los Caballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(599, 5, 'Santa María del Arroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(600, 5, 'Santa María del Berrocal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(566, 5, 'Pradosegar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(567, 5, 'Puerto Castilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(568, 5, 'Rasueros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(569, 5, 'Riocabado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(570, 5, 'Riofrío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(571, 5, 'Rivilla de Barajas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(572, 5, 'Salobral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(573, 5, 'Salvadiós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(574, 5, 'San Bartolomé de Béjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(575, 5, 'San Bartolomé de Corneja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(576, 5, 'San Bartolomé de Pinares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(577, 5, 'San Esteban de los Patos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(578, 5, 'San Esteban de Zapardiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(579, 5, 'San Esteban del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(580, 5, 'San García de Ingelmos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(581, 5, 'San Juan de Gredos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(582, 5, 'San Juan de la Encinilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(583, 5, 'San Juan de la Nava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(601, 5, 'Santa María del Cubillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(602, 5, 'Santa María del Tiétar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(603, 5, 'Santiago del Collado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(604, 5, 'Santiago del Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(605, 5, 'Santo Domingo de las Posadas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(606, 5, 'Santo Tomé de Zabarcos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(607, 5, 'Serrada (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(608, 5, 'Serranillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(609, 5, 'Sigeres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(610, 5, 'Sinlabajos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(611, 5, 'Solana de Ávila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(612, 5, 'Solana de Rioalmar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(613, 5, 'Solosancho'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(614, 5, 'Sotalbo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(615, 5, 'Sotillo de la Adrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(616, 5, 'Tiemblo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(617, 5, 'Tiñosillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(618, 5, 'Tolbaños'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(619, 5, 'Tormellas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(658, 6, 'Benquerencia de la Serena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(659, 6, 'Berlanga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(639, 5, 'Zapardiel de la Cañada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(640, 5, 'Zapardiel de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(641, 6, 'Acedera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(642, 6, 'Aceuchal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(643, 6, 'Ahillones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(644, 6, 'Alange'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(645, 6, 'Albuera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(646, 6, 'Alburquerque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(647, 6, 'Alconchel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(648, 6, 'Alconera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(649, 6, 'Aljucén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(650, 6, 'Almendral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(651, 6, 'Almendralejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(652, 6, 'Arroyo de San Serván'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(653, 6, 'Atalaya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(654, 6, 'Azuaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(655, 6, 'Badajoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(656, 6, 'Barcarrota'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(657, 6, 'Baterno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(620, 5, 'Tornadizos de Ávila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(621, 5, 'Torre (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(622, 5, 'Tórtoles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(623, 5, 'Umbrías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(624, 5, 'Vadillo de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(625, 5, 'Valdecasa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(626, 5, 'Vega de Santa María'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(627, 5, 'Velayos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(628, 5, 'Villaflor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(629, 5, 'Villafranca de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(630, 5, 'Villanueva de Ávila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(631, 5, 'Villanueva de Gómez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(632, 5, 'Villanueva del Aceral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(633, 5, 'Villanueva del Campillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(634, 5, 'Villar de Corneja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(635, 5, 'Villarejo del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(636, 5, 'Villatoro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(637, 5, 'Viñegra de Moraña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(638, 5, 'Vita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(660, 6, 'Bienvenida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(661, 6, 'Bodonal de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(662, 6, 'Burguillos del Cerro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(663, 6, 'Cabeza del Buey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(664, 6, 'Cabeza la Vaca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(665, 6, 'Calamonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(666, 6, 'Calera de León'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(667, 6, 'Calzadilla de los Barros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(668, 6, 'Campanario'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(669, 6, 'Campillo de Llerena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(670, 6, 'Capilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(671, 6, 'Carmonita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(672, 6, 'Carrascalejo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(673, 6, 'Casas de Don Pedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(674, 6, 'Casas de Reina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(675, 6, 'Castilblanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(676, 6, 'Castuera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(677, 6, 'Cheles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(678, 6, 'Codosera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(717, 6, 'Malcocinado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(698, 6, 'Garrovilla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(699, 6, 'Granja de Torrehermosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(700, 6, 'Guareña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(701, 6, 'Haba (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(702, 6, 'Helechosa de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(703, 6, 'Herrera del Duque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(704, 6, 'Higuera de la Serena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(705, 6, 'Higuera de Llerena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(706, 6, 'Higuera de Vargas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(707, 6, 'Higuera la Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(708, 6, 'Hinojosa del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(709, 6, 'Hornachos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(710, 6, 'Jerez de los Caballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(711, 6, 'Lapa (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(712, 6, 'Llera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(713, 6, 'Llerena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(714, 6, 'Lobón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(715, 6, 'Magacela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(716, 6, 'Maguilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(679, 6, 'Cordobilla de Lácara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(680, 6, 'Coronada (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(681, 6, 'Corte de Peleas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(682, 6, 'Cristina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(683, 6, 'Don Álvaro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(684, 6, 'Don Benito'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(685, 6, 'Entrín Bajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(686, 6, 'Esparragalejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(687, 6, 'Esparragosa de la Serena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(688, 6, 'Esparragosa de Lares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(689, 6, 'Feria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(690, 6, 'Fregenal de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(691, 6, 'Fuenlabrada de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(692, 6, 'Fuente de Cantos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(693, 6, 'Fuente del Arco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(694, 6, 'Fuente del Maestre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(695, 6, 'Fuentes de León'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(696, 6, 'Garbayuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(697, 6, 'Garlitos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(718, 6, 'Malpartida de la Serena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(719, 6, 'Manchita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(720, 6, 'Medellín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(721, 6, 'Medina de las Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(722, 6, 'Mengabril'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(723, 6, 'Mérida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(724, 6, 'Mirandilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(725, 6, 'Monesterio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(726, 6, 'Montemolín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(727, 6, 'Monterrubio de la Serena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(728, 6, 'Montijo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(729, 6, 'Morera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(730, 6, 'Nava de Santiago (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(731, 6, 'Navalvillar de Pela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(732, 6, 'Nogales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(733, 6, 'Oliva de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(734, 6, 'Oliva de Mérida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(735, 6, 'Olivenza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(736, 6, 'Orellana de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(756, 6, 'Roca de la Sierra (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(757, 6, 'Salvaleón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(758, 6, 'Salvatierra de los Barros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(759, 6, 'San Pedro de Mérida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(760, 6, 'San Vicente de Alcántara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(761, 6, 'Sancti-Spíritus'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(762, 6, 'Santa Amalia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(763, 6, 'Santa Marta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(764, 6, 'Santos de Maimona (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(765, 6, 'Segura de León'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(766, 6, 'Siruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(767, 6, 'Solana de los Barros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(768, 6, 'Talarrubias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(769, 6, 'Talavera la Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(770, 6, 'Táliga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(771, 6, 'Tamurejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(772, 6, 'Torre de Miguel Sesmero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(773, 6, 'Torremayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(774, 6, 'Torremejía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(737, 6, 'Orellana la Vieja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(738, 6, 'Palomas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(739, 6, 'Parra (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(740, 6, 'Peñalsordo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(741, 6, 'Peraleda del Zaucejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(742, 6, 'Puebla de Alcocer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(743, 6, 'Puebla de la Calzada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(744, 6, 'Puebla de la Reina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(745, 6, 'Puebla de Obando'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(746, 6, 'Puebla de Sancho Pérez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(747, 6, 'Puebla del Maestre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(748, 6, 'Puebla del Prior'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(749, 6, 'Pueblonuevo del Guadiana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(750, 6, 'Quintana de la Serena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(751, 6, 'Reina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(752, 6, 'Rena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(753, 6, 'Retamal de Llerena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(754, 6, 'Ribera del Fresno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(755, 6, 'Risco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(775, 6, 'Trasierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(776, 6, 'Trujillanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(777, 6, 'Usagre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(778, 6, 'Valdecaballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(779, 6, 'Valdelacalzada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(780, 6, 'Valdetorres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(781, 6, 'Valencia de las Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(782, 6, 'Valencia del Mombuey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(783, 6, 'Valencia del Ventoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(784, 6, 'Valle de la Serena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(785, 6, 'Valle de Matamoros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(786, 6, 'Valle de Santa Ana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(787, 6, 'Valverde de Burguillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(788, 6, 'Valverde de Leganés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(789, 6, 'Valverde de Llerena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(790, 6, 'Valverde de Mérida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(791, 6, 'Villafranca de los Barros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(792, 6, 'Villagarcía de la Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(832, 7, 'Fornalutx'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(833, 7, 'Inca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(834, 7, 'Lloret de Vistalegre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(835, 7, 'Lloseta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(812, 7, 'Banyalbufar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(813, 7, 'Binissalem'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(814, 7, 'Búger'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(815, 7, 'Bunyola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(816, 7, 'Calvià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(817, 7, 'Campanet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(818, 7, 'Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(819, 7, 'Capdepera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(820, 7, 'Castell (Es)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(821, 7, 'Ciutadella de Menorca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(822, 7, 'Consell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(823, 7, 'Costitx'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(824, 7, 'Deyá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(825, 7, 'Eivissa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(826, 7, 'Escorca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(827, 7, 'Esporles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(828, 7, 'Estellencs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(829, 7, 'Felanitx'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(830, 7, 'Ferreries'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(831, 7, 'Formentera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(793, 6, 'Villagonzalo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(794, 6, 'Villalba de los Barros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(795, 6, 'Villanueva de la Serena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(796, 6, 'Villanueva del Fresno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(797, 6, 'Villar de Rena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(798, 6, 'Villar del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(799, 6, 'Villarta de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(800, 6, 'Zafra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(801, 6, 'Zahínos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(802, 6, 'Zalamea de la Serena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(803, 6, 'Zarza (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(804, 6, 'Zarza-Capilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(805, 7, 'Alaior'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(806, 7, 'Alaró'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(807, 7, 'Alcúdia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(808, 7, 'Algaida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(809, 7, 'Andratx'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(810, 7, 'Ariany'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(811, 7, 'Artà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(836, 7, 'Llubí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(837, 7, 'Llucmajor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(838, 7, 'Manacor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(839, 7, 'Mancor de la Vall'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(840, 7, 'Maó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(841, 7, 'Maria de la Salut'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(842, 7, 'Marratxí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(843, 7, 'Mercadal (Es)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(844, 7, 'Migjorn Gran (Es)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(845, 7, 'Montuïri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(846, 7, 'Muro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(847, 7, 'Palma de Mallorca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(848, 7, 'Petra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(849, 7, 'Pobla (Sa)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(850, 7, 'Pollença'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(851, 7, 'Porreres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(852, 7, 'Puigpunyent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(853, 7, 'Salines (Ses)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(854, 7, 'Sant Antoni de Portmany'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(893, 8, 'Begues'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(894, 8, 'Bellprat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(895, 8, 'Berga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(896, 8, 'Bigues i Riells'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(897, 8, 'Borredà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(898, 8, 'Bruc (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(874, 8, 'Aiguafreda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(875, 8, 'Alella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(876, 8, 'Alpens'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(877, 8, 'Ametlla del Vallès (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(878, 8, 'Arenys de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(879, 8, 'Arenys de Munt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(880, 8, 'Argençola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(881, 8, 'Argentona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(882, 8, 'Artés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(883, 8, 'Avià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(884, 8, 'Avinyó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(885, 8, 'Avinyonet del Penedès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(886, 8, 'Badalona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(887, 8, 'Badia del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(888, 8, 'Bagà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(889, 8, 'Balenyà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(890, 8, 'Balsareny'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(891, 8, 'Barberà del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(892, 8, 'Barcelona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(855, 7, 'Sant Joan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(856, 7, 'Sant Joan de Labritja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(857, 7, 'Sant Josep de sa Talaia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(858, 7, 'Sant Llorenç des Cardassar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(859, 7, 'Sant Lluís'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(860, 7, 'Santa Eugènia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(861, 7, 'Santa Eulalia del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(862, 7, 'Santa Margalida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(863, 7, 'Santa María del Camí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(864, 7, 'Santanyí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(865, 7, 'Selva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(866, 7, 'Sencelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(867, 7, 'Sineu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(868, 7, 'Sóller'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(869, 7, 'Son Servera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(870, 7, 'Valldemossa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(871, 7, 'Vilafranca de Bonany'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(872, 8, 'Abrera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(873, 8, 'Aguilar de Segarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(899, 8, 'Brull (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(900, 8, 'Cabanyes (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(901, 8, 'Cabrera de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(902, 8, 'Cabrera d''Igualada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(903, 8, 'Cabrils'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(904, 8, 'Calaf'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(905, 8, 'Calders'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(906, 8, 'Caldes de Montbui'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(907, 8, 'Caldes d''Estrac'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(908, 8, 'Calella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(909, 8, 'Calldetenes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(910, 8, 'Callús'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(911, 8, 'Calonge de Segarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(912, 8, 'Campins'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(913, 8, 'Canet de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(914, 8, 'Canovelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(915, 8, 'Cànoves i Samalús'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(916, 8, 'Canyelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(917, 8, 'Capellades'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(956, 8, 'Fígols'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(957, 8, 'Fogars de la Selva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(937, 8, 'Castellterçol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(938, 8, 'Castellví de la Marca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(939, 8, 'Castellví de Rosanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(940, 8, 'Centelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(941, 8, 'Cercs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(942, 8, 'Cerdanyola del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(943, 8, 'Cervelló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(944, 8, 'Collbató'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(945, 8, 'Collsuspina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(946, 8, 'Copons'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(947, 8, 'Corbera de Llobregat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(948, 8, 'Cornellà de Llobregat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(949, 8, 'Cubelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(950, 8, 'Dosrius'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(951, 8, 'Esparreguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(952, 8, 'Esplugues de Llobregat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(953, 8, 'Espunyola (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(954, 8, 'Estany (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(955, 8, 'Figaró-Montmany'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(918, 8, 'Capolat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(919, 8, 'Cardedeu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(920, 8, 'Cardona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(921, 8, 'Carme'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(922, 8, 'Casserres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(923, 8, 'Castell de l''Areny'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(924, 8, 'Castellar de n''Hug'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(925, 8, 'Castellar del Riu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(926, 8, 'Castellar del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(927, 8, 'Castellbell i el Vilar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(928, 8, 'Castellbisbal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(929, 8, 'Castellcir'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(930, 8, 'Castelldefels'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(931, 8, 'Castellet i la Gornal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(932, 8, 'Castellfollit de Riubregós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(933, 8, 'Castellfollit del Boix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(934, 8, 'Castellgalí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(935, 8, 'Castellnou de Bages'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(936, 8, 'Castellolí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(958, 8, 'Fogars de Montclús'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(959, 8, 'Folgueroles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(960, 8, 'Fonollosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(961, 8, 'Font-rubí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(962, 8, 'Franqueses del Vallès (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(963, 8, 'Gaià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(964, 8, 'Gallifa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(965, 8, 'Garriga (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(966, 8, 'Gavà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(967, 8, 'Gelida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(968, 8, 'Gironella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(969, 8, 'Gisclareny'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(970, 8, 'Granada (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(971, 8, 'Granera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(972, 8, 'Granollers'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(973, 8, 'Gualba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(974, 8, 'Guardiola de Berguedà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(975, 8, 'Gurb'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(976, 8, 'Hospitalet de Llobregat (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1015, 8, 'Mura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1016, 8, 'Navarcles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1017, 8, 'Navàs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1018, 8, 'Nou de Berguedà (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1019, 8, 'Òdena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(996, 8, 'Masquefa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(997, 8, 'Matadepera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(998, 8, 'Mataró'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(999, 8, 'Mediona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1000, 8, 'Moià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1001, 8, 'Molins de Rei'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1002, 8, 'Mollet del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1003, 8, 'Monistrol de Calders'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1004, 8, 'Monistrol de Montserrat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1005, 8, 'Montcada i Reixac'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1006, 8, 'Montclar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1007, 8, 'Montesquiu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1008, 8, 'Montgat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1009, 8, 'Montmajor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1010, 8, 'Montmaneu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1011, 8, 'Montmeló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1012, 8, 'Montornès del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1013, 8, 'Montseny'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1014, 8, 'Muntanyola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(977, 8, 'Hostalets de Pierola (Els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(978, 8, 'Igualada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(979, 8, 'Jorba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(980, 8, 'Llacuna (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(981, 8, 'Llagosta (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(982, 8, 'Lliçà d''Amunt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(983, 8, 'Lliçà de Vall'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(984, 8, 'Llinars del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(985, 8, 'Lluçà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(986, 8, 'Malgrat de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(987, 8, 'Malla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(988, 8, 'Manlleu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(989, 8, 'Manresa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(990, 8, 'Marganell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(991, 8, 'Martorell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(992, 8, 'Martorelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(993, 8, 'Masies de Roda (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(994, 8, 'Masies de Voltregà (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(995, 8, 'Masnou (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1020, 8, 'Olèrdola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1021, 8, 'Olesa de Bonesvalls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1022, 8, 'Olesa de Montserrat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1023, 8, 'Olivella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1024, 8, 'Olost'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1025, 8, 'Olvan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1026, 8, 'Orís'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1027, 8, 'Oristà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1028, 8, 'Orpí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1029, 8, 'Òrrius'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1030, 8, 'Pacs del Penedès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1031, 8, 'Palafolls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1032, 8, 'Palau-solità i Plegamans'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1033, 8, 'Pallejà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1034, 8, 'Palma de Cervelló (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1035, 8, 'Papiol (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1036, 8, 'Parets del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1037, 8, 'Perafita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1038, 8, 'Piera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1076, 8, 'Sant Celoni'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1058, 8, 'Roca del Vallès (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1059, 8, 'Roda de Ter'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1060, 8, 'Rubí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1061, 8, 'Rubió'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1062, 8, 'Rupit i Pruit'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1063, 8, 'Sabadell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1064, 8, 'Sagàs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1065, 8, 'Saldes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1066, 8, 'Sallent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1067, 8, 'Sant Adrià de Besòs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1068, 8, 'Sant Agustí de Lluçanès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1069, 8, 'Sant Andreu de la Barca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1070, 8, 'Sant Andreu de Llavaneres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1071, 8, 'Sant Antoni de Vilamajor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1072, 8, 'Sant Bartomeu del Grau'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1073, 8, 'Sant Boi de Llobregat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1074, 8, 'Sant Boi de Lluçanès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1075, 8, 'Sant Cebrià de Vallalta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1039, 8, 'Pineda de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1040, 8, 'Pla del Penedès (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1041, 8, 'Pobla de Claramunt (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1042, 8, 'Pobla de Lillet (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1043, 8, 'Polinyà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1044, 8, 'Pont de Vilomara i Rocafort (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1045, 8, 'Pontons'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1046, 8, 'Prat de Llobregat (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1047, 8, 'Prats de Lluçanès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1048, 8, 'Prats de Rei (Els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1049, 8, 'Premià de Dalt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1050, 8, 'Premià de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1051, 8, 'Puigdàlber'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1052, 8, 'Puig-reig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1053, 8, 'Pujalt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1054, 8, 'Quar (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1055, 8, 'Rajadell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1056, 8, 'Rellinars'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1057, 8, 'Ripollet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1077, 8, 'Sant Climent de Llobregat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1078, 8, 'Sant Cugat del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1079, 8, 'Sant Cugat Sesgarrigues'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1080, 8, 'Sant Esteve de Palautordera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1081, 8, 'Sant Esteve Sesrovires'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1082, 8, 'Sant Feliu de Codines'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1083, 8, 'Sant Feliu de Llobregat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1084, 8, 'Sant Feliu Sasserra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1085, 8, 'Sant Fost de Campsentelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1086, 8, 'Sant Fruitós de Bages'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1087, 8, 'Sant Hipòlit de Voltregà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1088, 8, 'Sant Iscle de Vallalta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1089, 8, 'Sant Jaume de Frontanyà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1090, 8, 'Sant Joan de Vilatorrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1091, 8, 'Sant Joan Despí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1092, 8, 'Sant Julià de Cerdanyola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1093, 8, 'Sant Julià de Vilatorta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1111, 8, 'Sant Quirze del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1112, 8, 'Sant Quirze Safaja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1113, 8, 'Sant Sadurní d''Anoia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1114, 8, 'Sant Sadurní d''Osormort'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1115, 8, 'Sant Salvador de Guardiola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1116, 8, 'Sant Vicenç de Castellet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1117, 8, 'Sant Vicenç de Montalt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1118, 8, 'Sant Vicenç de Torelló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1119, 8, 'Sant Vicenç dels Horts'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1120, 8, 'Santa Cecília de Voltregà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1121, 8, 'Santa Coloma de Cervelló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1122, 8, 'Santa Coloma de Gramenet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1094, 8, 'Sant Just Desvern'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1095, 8, 'Sant Llorenç d''Hortons'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1096, 8, 'Sant Llorenç Savall'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1097, 8, 'Sant Martí d''Albars'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1098, 8, 'Sant Martí de Centelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1099, 8, 'Sant Martí de Tous'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1100, 8, 'Sant Martí Sarroca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1101, 8, 'Sant Martí Sesgueioles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1102, 8, 'Sant Mateu de Bages'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1103, 8, 'Sant Pere de Ribes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1104, 8, 'Sant Pere de Riudebitlles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1105, 8, 'Sant Pere de Torelló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1106, 8, 'Sant Pere de Vilamajor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1107, 8, 'Sant Pere Sallavinera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1108, 8, 'Sant Pol de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1109, 8, 'Sant Quintí de Mediona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1110, 8, 'Sant Quirze de Besora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1123, 8, 'Santa Eugènia de Berga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1124, 8, 'Santa Eulàlia de Riuprimer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1125, 8, 'Santa Eulàlia de Ronçana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1126, 8, 'Santa Fe del Penedès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1127, 8, 'Santa Margarida de Montbui'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1128, 8, 'Santa Margarida i els Monjos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1129, 8, 'Santa Maria de Besora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1130, 8, 'Santa Maria de Corcó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1131, 8, 'Santa Maria de Martorelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1132, 8, 'Santa Maria de Merlès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1133, 8, 'Santa Maria de Miralles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1134, 8, 'Santa Maria de Palautordera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1135, 8, 'Santa Maria d''Oló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1136, 8, 'Santa Perpètua de Mogoda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1137, 8, 'Santa Susanna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1138, 8, 'Santpedor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1139, 8, 'Sentmenat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1140, 8, 'Seva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1160, 8, 'Torrelles de Llobregat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1161, 8, 'Ullastrell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1162, 8, 'Vacarisses'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1163, 8, 'Vallbona d''Anoia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1164, 8, 'Vallcebre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1165, 8, 'Vallgorguina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1166, 8, 'Vallirana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1167, 8, 'Vallromanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1168, 8, 'Veciana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1169, 8, 'Vic'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1170, 8, 'Vilada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1171, 8, 'Viladecans'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1172, 8, 'Viladecavalls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1173, 8, 'Vilafranca del Penedès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1174, 8, 'Vilalba Sasserra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1175, 8, 'Vilanova de Sau'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1176, 8, 'Vilanova del Camí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1177, 8, 'Vilanova del Vallès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1178, 8, 'Vilanova i la Geltrú'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1141, 8, 'Sitges'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1142, 8, 'Sobremunt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1143, 8, 'Sora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1144, 8, 'Subirats'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1145, 8, 'Súria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1146, 8, 'Tagamanent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1147, 8, 'Talamanca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1148, 8, 'Taradell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1149, 8, 'Tavèrnoles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1150, 8, 'Tavertet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1151, 8, 'Teià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1152, 8, 'Terrassa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1153, 8, 'Tiana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1154, 8, 'Tona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1155, 8, 'Tordera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1156, 8, 'Torelló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1157, 8, 'Torre de Claramunt (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1158, 8, 'Torrelavit'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1159, 8, 'Torrelles de Foix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1179, 8, 'Vilassar de Dalt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1180, 8, 'Vilassar de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1181, 8, 'Vilobí del Penedès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1182, 8, 'Viver i Serrateix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1183, 9, 'Abajas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1184, 9, 'Adrada de Haza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1185, 9, 'Aguas Cándidas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1186, 9, 'Aguilar de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1187, 9, 'Albillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1188, 9, 'Alcocero de Mola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1189, 9, 'Alfoz de Bricia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1190, 9, 'Alfoz de Quintanadueñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1191, 9, 'Alfoz de Santa Gadea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1192, 9, 'Altable'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1193, 9, 'Altos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1194, 9, 'Ameyugo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1195, 9, 'Anguix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1196, 9, 'Aranda de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1197, 9, 'Arandilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1235, 9, 'Caleruega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1216, 9, 'Barrio de Muñó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1217, 9, 'Barrios de Bureba (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1218, 9, 'Barrios de Colina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1219, 9, 'Basconcillos del Tozo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1220, 9, 'Bascuñana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1221, 9, 'Belbimbre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1222, 9, 'Belorado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1223, 9, 'Berberana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1224, 9, 'Berlangas de Roa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1225, 9, 'Berzosa de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1226, 9, 'Bozoó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1227, 9, 'Brazacorta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1228, 9, 'Briviesca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1229, 9, 'Bugedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1230, 9, 'Buniel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1231, 9, 'Burgos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1232, 9, 'Busto de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1233, 9, 'Cabañes de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1234, 9, 'Cabezón de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1198, 9, 'Arauzo de Miel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1199, 9, 'Arauzo de Salce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1200, 9, 'Arauzo de Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1201, 9, 'Arcos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1202, 9, 'Arenillas de Riopisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1203, 9, 'Arija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1204, 9, 'Arlanzón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1205, 9, 'Arraya de Oca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1206, 9, 'Atapuerca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1207, 9, 'Ausines (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1208, 9, 'Avellanosa de Muñó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1209, 9, 'Bahabón de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1210, 9, 'Balbases (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1211, 9, 'Baños de Valdearados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1212, 9, 'Bañuelos de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1213, 9, 'Barbadillo de Herreros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1214, 9, 'Barbadillo del Mercado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1215, 9, 'Barbadillo del Pez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1236, 9, 'Campillo de Aranda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1237, 9, 'Campolara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1238, 9, 'Canicosa de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1239, 9, 'Cantabrana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1240, 9, 'Carazo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1241, 9, 'Carcedo de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1242, 9, 'Carcedo de Burgos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1243, 9, 'Cardeñadijo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1244, 9, 'Cardeñajimeno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1245, 9, 'Cardeñuela Riopico'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1246, 9, 'Carrias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1247, 9, 'Cascajares de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1248, 9, 'Cascajares de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1249, 9, 'Castellanos de Castro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1250, 9, 'Castil de Peones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1251, 9, 'Castildelgado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1252, 9, 'Castrillo de la Reina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1253, 9, 'Castrillo de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1272, 9, 'Coruña del Conde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1273, 9, 'Covarrubias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1274, 9, 'Cubillo del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1275, 9, 'Cubo de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1276, 9, 'Cueva de Roa (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1277, 9, 'Cuevas de San Clemente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1278, 9, 'Encío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1279, 9, 'Espinosa de Cervera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1280, 9, 'Espinosa de los Monteros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1281, 9, 'Espinosa del Camino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1282, 9, 'Estépar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1283, 9, 'Fontioso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1284, 9, 'Frandovínez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1285, 9, 'Fresneda de la Sierra Tirón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1286, 9, 'Fresneña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1287, 9, 'Fresnillo de las Dueñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1288, 9, 'Fresno de Río Tirón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1289, 9, 'Fresno de Rodilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1254, 9, 'Castrillo de Riopisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1255, 9, 'Castrillo del Val'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1256, 9, 'Castrillo Matajudíos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1257, 9, 'Castrojeriz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1258, 9, 'Cavia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1259, 9, 'Cayuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1260, 9, 'Cebrecos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1261, 9, 'Celada del Camino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1262, 9, 'Cerezo de Río Tirón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1263, 9, 'Cerratón de Juarros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1264, 9, 'Ciadoncha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1265, 9, 'Cillaperlata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1266, 9, 'Cilleruelo de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1267, 9, 'Cilleruelo de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1268, 9, 'Ciruelos de Cervera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1269, 9, 'Cogollos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1270, 9, 'Condado de Treviño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1271, 9, 'Contreras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1290, 9, 'Frías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1291, 9, 'Fuentebureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1292, 9, 'Fuentecén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1293, 9, 'Fuentelcésped'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1294, 9, 'Fuentelisendo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1295, 9, 'Fuentemolinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1296, 9, 'Fuentenebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1297, 9, 'Fuentespina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1298, 9, 'Galbarros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1299, 9, 'Gallega (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1300, 9, 'Grijalba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1301, 9, 'Grisaleña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1302, 9, 'Gumiel de Izán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1303, 9, 'Gumiel de Mercado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1304, 9, 'Hacinas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1305, 9, 'Haza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1306, 9, 'Hontanas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1307, 9, 'Hontangas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1308, 9, 'Hontoria de la Cantera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1346, 9, 'Merindad de Cuesta-Urria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1328, 9, 'Jaramillo Quemado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1329, 9, 'Junta de Traslaloma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1330, 9, 'Junta de Villalba de Losa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1331, 9, 'Jurisdicción de Lara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1332, 9, 'Jurisdicción de San Zadornil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1333, 9, 'Lerma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1334, 9, 'Llano de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1335, 9, 'Madrigal del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1336, 9, 'Madrigalejo del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1337, 9, 'Mahamud'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1338, 9, 'Mambrilla de Castrejón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1339, 9, 'Mambrillas de Lara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1340, 9, 'Mamolar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1341, 9, 'Manciles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1342, 9, 'Mazuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1343, 9, 'Mecerreyes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1344, 9, 'Medina de Pomar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1345, 9, 'Melgar de Fernamental'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1309, 9, 'Hontoria de Valdearados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1310, 9, 'Hontoria del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1311, 9, 'Hormazas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1312, 9, 'Hornillos del Camino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1313, 9, 'Horra (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1314, 9, 'Hortigüela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1315, 9, 'Hoyales de Roa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1316, 9, 'Huérmeces'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1317, 9, 'Huerta de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1318, 9, 'Huerta de Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1319, 9, 'Humada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1320, 9, 'Hurones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1321, 9, 'Ibeas de Juarros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1322, 9, 'Ibrillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1323, 9, 'Iglesiarrubia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1324, 9, 'Iglesias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1325, 9, 'Isar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1326, 9, 'Itero del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1327, 9, 'Jaramillo de la Fuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1347, 9, 'Merindad de Montija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1348, 9, 'Merindad de Río Ubierna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1349, 9, 'Merindad de Sotoscueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1350, 9, 'Merindad de Valdeporres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1351, 9, 'Merindad de Valdivielso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1352, 9, 'Milagros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1353, 9, 'Miranda de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1354, 9, 'Miraveche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1355, 9, 'Modúbar de la Emparedada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1356, 9, 'Monasterio de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1357, 9, 'Monasterio de Rodilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1358, 9, 'Moncalvillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1359, 9, 'Monterrubio de la Demanda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1360, 9, 'Montorio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1361, 9, 'Moradillo de Roa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1362, 9, 'Nava de Roa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1363, 9, 'Navas de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1364, 9, 'Nebreda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1383, 9, 'Pedrosa de Río Úrbel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1384, 9, 'Pedrosa del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1385, 9, 'Pedrosa del Príncipe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1386, 9, 'Peñaranda de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1387, 9, 'Peral de Arlanza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1388, 9, 'Piérnigas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1389, 9, 'Pineda de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1390, 9, 'Pineda Trasmonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1391, 9, 'Pinilla de los Barruecos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1392, 9, 'Pinilla de los Moros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1393, 9, 'Pinilla Trasmonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1394, 9, 'Poza de la Sal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1395, 9, 'Prádanos de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1396, 9, 'Pradoluengo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1397, 9, 'Presencio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1398, 9, 'Puebla de Arganzón (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1399, 9, 'Puentedura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1365, 9, 'Neila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1366, 9, 'Olmedillo de Roa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1367, 9, 'Olmillos de Muñó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1368, 9, 'Oña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1369, 9, 'Oquillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1370, 9, 'Orbaneja Riopico'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1371, 9, 'Padilla de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1372, 9, 'Padilla de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1373, 9, 'Padrones de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1374, 9, 'Palacios de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1375, 9, 'Palacios de Riopisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1376, 9, 'Palazuelos de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1377, 9, 'Palazuelos de Muñó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1378, 9, 'Pampliega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1379, 9, 'Pancorbo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1380, 9, 'Pardilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1381, 9, 'Partido de la Sierra en Tobalina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1382, 9, 'Pedrosa de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1400, 9, 'Quemada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1401, 9, 'Quintana del Pidio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1402, 9, 'Quintanabureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1403, 9, 'Quintanaélez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1404, 9, 'Quintanaortuño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1405, 9, 'Quintanapalla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1406, 9, 'Quintanar de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1407, 9, 'Quintanavides'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1408, 9, 'Quintanilla de la Mata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1409, 9, 'Quintanilla del Agua y Tordueles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1410, 9, 'Quintanilla del Coco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1411, 9, 'Quintanilla San García'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1412, 9, 'Quintanilla Vivar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1413, 9, 'Quintanillas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1414, 9, 'Rabanera del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1415, 9, 'Rábanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1416, 9, 'Rabé de las Calzadas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1417, 9, 'Rebolledo de la Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1437, 9, 'Saldaña de Burgos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1438, 9, 'Salinillas de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1439, 9, 'San Adrián de Juarros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1440, 9, 'San Juan del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1441, 9, 'San Mamés de Burgos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1442, 9, 'San Martín de Rubiales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1443, 9, 'San Millán de Lara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1444, 9, 'San Vicente del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1445, 9, 'Santa Cecilia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1446, 9, 'Santa Cruz de la Salceda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1447, 9, 'Santa Cruz del Valle Urbión'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1448, 9, 'Santa Gadea del Cid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1449, 9, 'Santa Inés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1450, 9, 'Santa María del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1451, 9, 'Santa María del Invierno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1418, 9, 'Redecilla del Camino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1419, 9, 'Redecilla del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1420, 9, 'Regumiel de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1421, 9, 'Reinoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1422, 9, 'Retuerta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1423, 9, 'Revilla del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1424, 9, 'Revilla Vallejera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1425, 9, 'Revilla y Ahedo (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1426, 9, 'Revillarruz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1427, 9, 'Rezmondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1428, 9, 'Riocavado de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1429, 9, 'Roa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1430, 9, 'Rojas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1431, 9, 'Royuela de Río Franco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1432, 9, 'Rubena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1433, 9, 'Rublacedo de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1434, 9, 'Rucandio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1435, 9, 'Salas de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1436, 9, 'Salas de los Infantes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1452, 9, 'Santa María del Mercadillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1453, 9, 'Santa María Rivarredonda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1454, 9, 'Santa Olalla de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1455, 9, 'Santibáñez de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1456, 9, 'Santibáñez del Val'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1457, 9, 'Santo Domingo de Silos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1458, 9, 'Sargentes de la Lora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1459, 9, 'Sarracín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1460, 9, 'Sasamón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1461, 9, 'Sequera de Haza (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1462, 9, 'Solarana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1463, 9, 'Sordillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1464, 9, 'Sotillo de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1465, 9, 'Sotragero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1466, 9, 'Sotresgudo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1467, 9, 'Susinos del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1468, 9, 'Tamarón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1469, 9, 'Tardajos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1489, 9, 'Valdorros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1490, 9, 'Vallarta de Bureba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1491, 9, 'Valle de las Navas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1492, 9, 'Valle de Losa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1493, 9, 'Valle de Manzanedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1494, 9, 'Valle de Mena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1495, 9, 'Valle de Oca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1496, 9, 'Valle de Santibáñez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1497, 9, 'Valle de Sedano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1498, 9, 'Valle de Tobalina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1499, 9, 'Valle de Valdebezana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1500, 9, 'Valle de Valdelaguna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1501, 9, 'Valle de Valdelucio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1502, 9, 'Valle de Zamanzas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1503, 9, 'Vallejera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1504, 9, 'Valles de Palenzuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1505, 9, 'Valluércanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1506, 9, 'Valmala'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1470, 9, 'Tejada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1471, 9, 'Terradillos de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1472, 9, 'Tinieblas de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1473, 9, 'Tobar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1474, 9, 'Tordómar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1475, 9, 'Torrecilla del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1476, 9, 'Torregalindo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1477, 9, 'Torrelara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1478, 9, 'Torrepadre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1479, 9, 'Torresandino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1480, 9, 'Tórtoles de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1481, 9, 'Tosantos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1482, 9, 'Trespaderne'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1483, 9, 'Tubilla del Agua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1484, 9, 'Tubilla del Lago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1485, 9, 'Úrbel del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1486, 9, 'Vadocondes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1487, 9, 'Valdeande'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1488, 9, 'Valdezate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1507, 9, 'Vid de Bureba (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1508, 9, 'Vid y Barrios (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1509, 9, 'Vileña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1510, 9, 'Villadiego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1511, 9, 'Villaescusa de Roa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1512, 9, 'Villaescusa la Sombría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1513, 9, 'Villaespasa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1514, 9, 'Villafranca Montes de Oca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1515, 9, 'Villafruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1516, 9, 'Villagalijo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1517, 9, 'Villagonzalo Pedernales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1518, 9, 'Villahoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1519, 9, 'Villalba de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1520, 9, 'Villalbilla de Burgos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1521, 9, 'Villalbilla de Gumiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1522, 9, 'Villaldemiro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1523, 9, 'Villalmanzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1524, 9, 'Villamayor de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1543, 9, 'Villayerno Morquillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1544, 9, 'Villazopeque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1545, 9, 'Villegas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1546, 9, 'Villoruebo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1547, 9, 'Viloria de Rioja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1548, 9, 'Vilviestre del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1549, 9, 'Vizcaínos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1550, 9, 'Zael'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1551, 9, 'Zarzosa de Río Pisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1552, 9, 'Zazuar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1553, 9, 'Zuñeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1554, 10, 'Abadía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1555, 10, 'Abertura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1556, 10, 'Acebo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1557, 10, 'Acehúche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1558, 10, 'Aceituna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1559, 10, 'Ahigal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1560, 10, 'Albalá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1525, 9, 'Villamayor de Treviño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1526, 9, 'Villambistia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1527, 9, 'Villamedianilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1528, 9, 'Villamiel de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1529, 9, 'Villangómez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1530, 9, 'Villanueva de Argaño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1531, 9, 'Villanueva de Carazo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1532, 9, 'Villanueva de Gumiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1533, 9, 'Villanueva de Teba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1534, 9, 'Villaquirán de la Puebla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1535, 9, 'Villaquirán de los Infantes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1536, 9, 'Villarcayo de Merindad de Castilla la Vieja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1537, 9, 'Villariezo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1538, 9, 'Villasandino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1539, 9, 'Villasur de Herreros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1540, 9, 'Villatuelda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1541, 9, 'Villaverde del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1542, 9, 'Villaverde-Mogina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1561, 10, 'Alcántara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1562, 10, 'Alcollarín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1563, 10, 'Alcuéscar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1564, 10, 'Aldea del Cano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1565, 10, 'Aldea del Obispo (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1566, 10, 'Aldeacentenera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1567, 10, 'Aldeanueva de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1568, 10, 'Aldeanueva del Camino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1569, 10, 'Aldehuela de Jerte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1570, 10, 'Alía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1571, 10, 'Aliseda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1572, 10, 'Almaraz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1573, 10, 'Almoharín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1574, 10, 'Arroyo de la Luz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1575, 10, 'Arroyomolinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1576, 10, 'Arroyomolinos de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1577, 10, 'Baños de Montemayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1578, 10, 'Barrado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1616, 10, 'Cerezo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1598, 10, 'Cañaveral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1599, 10, 'Carbajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1600, 10, 'Carcaboso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1601, 10, 'Carrascalejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1602, 10, 'Casar de Cáceres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1603, 10, 'Casar de Palomero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1604, 10, 'Casares de las Hurdes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1605, 10, 'Casas de Don Antonio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1606, 10, 'Casas de Don Gómez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1607, 10, 'Casas de Millán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1608, 10, 'Casas de Miravete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1609, 10, 'Casas del Castañar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1610, 10, 'Casas del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1611, 10, 'Casatejada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1612, 10, 'Casillas de Coria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1613, 10, 'Castañar de Ibor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1614, 10, 'Ceclavín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1615, 10, 'Cedillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1579, 10, 'Belvís de Monroy'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1580, 10, 'Benquerencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1581, 10, 'Berrocalejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1582, 10, 'Berzocana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1583, 10, 'Bohonal de Ibor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1584, 10, 'Botija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1585, 10, 'Brozas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1586, 10, 'Cabañas del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1587, 10, 'Cabezabellosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1588, 10, 'Cabezuela del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1589, 10, 'Cabrero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1590, 10, 'Cáceres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1591, 10, 'Cachorrilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1592, 10, 'Cadalso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1593, 10, 'Calzadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1594, 10, 'Caminomorisco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1595, 10, 'Campillo de Deleitosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1596, 10, 'Campo Lugar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1597, 10, 'Cañamero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1617, 10, 'Cilleros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1618, 10, 'Collado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1619, 10, 'Conquista de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1620, 10, 'Coria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1621, 10, 'Cuacos de Yuste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1622, 10, 'Cumbre (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1623, 10, 'Deleitosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1624, 10, 'Descargamaría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1625, 10, 'Eljas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1626, 10, 'Escurial'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1627, 10, 'Fresnedoso de Ibor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1628, 10, 'Galisteo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1629, 10, 'Garciaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1630, 10, 'Garganta (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1631, 10, 'Garganta la Olla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1632, 10, 'Gargantilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1633, 10, 'Gargüera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1634, 10, 'Garrovillas de Alconétar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1635, 10, 'Garvín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1674, 10, 'Millanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1675, 10, 'Mirabel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1655, 10, 'Jaraicejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1656, 10, 'Jaraíz de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1657, 10, 'Jarandilla de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1658, 10, 'Jarilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1659, 10, 'Jerte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1660, 10, 'Ladrillar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1661, 10, 'Logrosán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1662, 10, 'Losar de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1663, 10, 'Madrigal de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1664, 10, 'Madrigalejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1665, 10, 'Madroñera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1666, 10, 'Majadas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1667, 10, 'Malpartida de Cáceres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1668, 10, 'Malpartida de Plasencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1669, 10, 'Marchagaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1670, 10, 'Mata de Alcántara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1671, 10, 'Membrío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1672, 10, 'Mesas de Ibor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1673, 10, 'Miajadas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1636, 10, 'Gata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1637, 10, 'Gordo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1638, 10, 'Granja (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1639, 10, 'Guadalupe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1640, 10, 'Guijo de Coria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1641, 10, 'Guijo de Galisteo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1642, 10, 'Guijo de Granadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1643, 10, 'Guijo de Santa Bárbara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1644, 10, 'Herguijuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1645, 10, 'Hernán-Pérez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1646, 10, 'Herrera de Alcántara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1647, 10, 'Herreruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1648, 10, 'Hervás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1649, 10, 'Higuera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1650, 10, 'Hinojal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1651, 10, 'Holguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1652, 10, 'Hoyos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1653, 10, 'Huélaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1654, 10, 'Ibahernando'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1676, 10, 'Mohedas de Granadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1677, 10, 'Monroy'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1678, 10, 'Montánchez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1679, 10, 'Montehermoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1680, 10, 'Moraleja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1681, 10, 'Morcillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1682, 10, 'Navaconcejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1683, 10, 'Navalmoral de la Mata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1684, 10, 'Navalvillar de Ibor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1685, 10, 'Navas del Madroño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1686, 10, 'Navezuelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1687, 10, 'Nuñomoral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1688, 10, 'Oliva de Plasencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1689, 10, 'Palomero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1690, 10, 'Pasarón de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1691, 10, 'Pedroso de Acim'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1692, 10, 'Peraleda de la Mata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1693, 10, 'Peraleda de San Román'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1713, 10, 'Rosalejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1714, 10, 'Ruanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1715, 10, 'Salorino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1716, 10, 'Salvatierra de Santiago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1717, 10, 'San Martín de Trevejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1718, 10, 'Santa Ana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1719, 10, 'Santa Cruz de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1720, 10, 'Santa Cruz de Paniagua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1721, 10, 'Santa Marta de Magasca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1722, 10, 'Santiago de Alcántara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1723, 10, 'Santiago del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1724, 10, 'Santibáñez el Alto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1725, 10, 'Santibáñez el Bajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1726, 10, 'Saucedilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1727, 10, 'Segura de Toro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1728, 10, 'Serradilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1729, 10, 'Serrejón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1730, 10, 'Sierra de Fuentes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1694, 10, 'Perales del Puerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1695, 10, 'Pescueza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1696, 10, 'Pesga (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1697, 10, 'Piedras Albas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1698, 10, 'Pinofranqueado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1699, 10, 'Piornal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1700, 10, 'Plasencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1701, 10, 'Plasenzuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1702, 10, 'Portaje'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1703, 10, 'Portezuelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1704, 10, 'Pozuelo de Zarzón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1705, 10, 'Puerto de Santa Cruz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1706, 10, 'Rebollar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1707, 10, 'Riolobos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1708, 10, 'Robledillo de Gata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1709, 10, 'Robledillo de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1710, 10, 'Robledillo de Trujillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1711, 10, 'Robledollano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1712, 10, 'Romangordo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1731, 10, 'Talaván'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1732, 10, 'Talaveruela de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1733, 10, 'Talayuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1734, 10, 'Tejeda de Tiétar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1735, 10, 'Toril'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1736, 10, 'Tornavacas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1737, 10, 'Torno (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1738, 10, 'Torre de Don Miguel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1739, 10, 'Torre de Santa María'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1740, 10, 'Torrecilla de los Ángeles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1741, 10, 'Torrecillas de la Tiesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1742, 10, 'Torrejón el Rubio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1743, 10, 'Torrejoncillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1744, 10, 'Torremenga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1745, 10, 'Torremocha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1746, 10, 'Torreorgaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1747, 10, 'Torrequemada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1748, 10, 'Trujillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1767, 10, 'Villar del Pedroso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1768, 10, 'Villasbuenas de Gata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1769, 10, 'Zarza de Granadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1770, 10, 'Zarza de Montánchez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1771, 10, 'Zarza la Mayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1772, 10, 'Zorita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1773, 11, 'Alcalá de los Gazules'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1774, 11, 'Alcalá del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1775, 11, 'Algar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1776, 11, 'Algeciras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1777, 11, 'Algodonales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1778, 11, 'Arcos de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1779, 11, 'Barbate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1780, 11, 'Barrios (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1781, 11, 'Benalup-Casas Viejas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1782, 11, 'Benaocaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1783, 11, 'Bornos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1784, 11, 'Bosque (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1749, 10, 'Valdastillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1750, 10, 'Valdecañas de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1751, 10, 'Valdefuentes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1752, 10, 'Valdehúncar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1753, 10, 'Valdelacasa de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1754, 10, 'Valdemorales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1755, 10, 'Valdeobispo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1756, 10, 'Valencia de Alcántara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1757, 10, 'Valverde de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1758, 10, 'Valverde del Fresno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1759, 10, 'Viandar de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1760, 10, 'Villa del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1761, 10, 'Villa del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1762, 10, 'Villamesías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1763, 10, 'Villamiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1764, 10, 'Villanueva de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1765, 10, 'Villanueva de la Vera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1766, 10, 'Villar de Plasencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1785, 11, 'Cádiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1786, 11, 'Castellar de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1787, 11, 'Chiclana de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1788, 11, 'Chipiona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1789, 11, 'Conil de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1790, 11, 'Espera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1791, 11, 'Gastor (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1792, 11, 'Grazalema'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1793, 11, 'Jerez de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1794, 11, 'Jimena de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1795, 11, 'Línea de la Concepción (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1796, 11, 'Medina-Sidonia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1797, 11, 'Olvera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1798, 11, 'Paterna de Rivera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1799, 11, 'Prado del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1800, 11, 'Puerto de Santa María (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1801, 11, 'Puerto Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1802, 11, 'Puerto Serrano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1822, 12, 'Alfondeguilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1823, 12, 'Algimia de Almonacid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1824, 12, 'Almazora/Almassora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1825, 12, 'Almedíjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1826, 12, 'Almenara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1827, 12, 'Alquerías del Niño Perdido'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1828, 12, 'Altura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1829, 12, 'Arañuel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1830, 12, 'Ares del Maestre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1831, 12, 'Argelita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1832, 12, 'Artana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1833, 12, 'Atzeneta del Maestrat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1834, 12, 'Ayódar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1835, 12, 'Azuébar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1836, 12, 'Barracas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1837, 12, 'Bejís'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1838, 12, 'Benafer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1839, 12, 'Benafigos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1840, 12, 'Benasal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1803, 11, 'Rota'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1804, 11, 'San Fernando'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1805, 11, 'San José del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1806, 11, 'San Roque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1807, 11, 'Sanlúcar de Barrameda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1808, 11, 'Setenil de las Bodegas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1809, 11, 'Tarifa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1810, 11, 'Torre Alháquime'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1811, 11, 'Trebujena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1812, 11, 'Ubrique'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1813, 11, 'Vejer de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1814, 11, 'Villaluenga del Rosario'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1815, 11, 'Villamartín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1816, 11, 'Zahara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1817, 12, 'Aín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1818, 12, 'Albocàsser'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1819, 12, 'Alcalà de Xivert'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1820, 12, 'Alcora (l'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1821, 12, 'Alcudia de Veo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1841, 12, 'Benicarló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1842, 12, 'Benicasim/Benicàssim'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1843, 12, 'Benlloch'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1844, 12, 'Betxí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1845, 12, 'Borriol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1846, 12, 'Burriana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1847, 12, 'Cabanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1848, 12, 'Càlig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1849, 12, 'Canet lo Roig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1850, 12, 'Castell de Cabres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1851, 12, 'Castellfort'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1852, 12, 'Castellnovo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1853, 12, 'Castellón de la Plana/Castelló de la Plana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1854, 12, 'Castillo de Villamalefa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1855, 12, 'Catí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1856, 12, 'Caudiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1857, 12, 'Cervera del Maestre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1858, 12, 'Chert/Xert'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1859, 12, 'Chilches/Xilxes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1898, 12, 'Pina de Montalgrao'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1899, 12, 'Pobla de Benifassà (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1879, 12, 'Jana (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1880, 12, 'Jérica'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1881, 12, 'Llosa (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1882, 12, 'Lucena del Cid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1883, 12, 'Ludiente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1884, 12, 'Mata de Morella (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1885, 12, 'Matet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1886, 12, 'Moncofa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1887, 12, 'Montán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1888, 12, 'Montanejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1889, 12, 'Morella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1890, 12, 'Navajas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1891, 12, 'Nules'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1892, 12, 'Olocau del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1893, 12, 'Onda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1894, 12, 'Oropesa del Mar/Orpesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1895, 12, 'Palanques'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1896, 12, 'Pavías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1897, 12, 'Peñíscola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1860, 12, 'Chodos/Xodos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1861, 12, 'Chóvar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1862, 12, 'Cinctorres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1863, 12, 'Cirat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1864, 12, 'Cortes de Arenoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1865, 12, 'Costur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1866, 12, 'Coves de Vinromà (les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1867, 12, 'Culla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1868, 12, 'Eslida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1869, 12, 'Espadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1870, 12, 'Fanzara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1871, 12, 'Figueroles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1872, 12, 'Forcall'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1873, 12, 'Fuente la Reina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1874, 12, 'Fuentes de Ayódar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1875, 12, 'Gaibiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1876, 12, 'Geldo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1877, 12, 'Herbés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1878, 12, 'Higueras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1900, 12, 'Pobla Tornesa (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1901, 12, 'Portell de Morella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1902, 12, 'Puebla de Arenoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1903, 12, 'Ribesalbes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1904, 12, 'Rossell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1905, 12, 'Sacañet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1906, 12, 'Salzadella (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1907, 12, 'San Rafael del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1908, 12, 'Sant Joan de Moró'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1909, 12, 'Sant Jordi/San Jorge'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1910, 12, 'Sant Mateu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1911, 12, 'Santa Magdalena de Pulpis'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1912, 12, 'Sarratella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1913, 12, 'Segorbe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1914, 12, 'Sierra Engarcerán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1915, 12, 'Soneja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1916, 12, 'Sot de Ferrer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1917, 12, 'Sueras/Suera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1937, 12, 'Vilafamés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1938, 12, 'Vilanova d''Alcolea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1939, 12, 'Vilar de Canes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1940, 12, 'Vila-real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1941, 12, 'Vilavella (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1942, 12, 'Villafranca del Cid/Vilafranca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1943, 12, 'Villahermosa del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1944, 12, 'Villamalur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1945, 12, 'Villanueva de Viver'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1946, 12, 'Villores'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1947, 12, 'Vinaròs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1948, 12, 'Vistabella del Maestrazgo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1949, 12, 'Viver'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1950, 12, 'Zorita del Maestrazgo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1951, 12, 'Zucaina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1952, 13, 'Abenójar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1953, 13, 'Agudo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1954, 13, 'Alamillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1918, 12, 'Tales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1919, 12, 'Teresa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1920, 12, 'Tírig'); 
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (1921, 12, 'Todolella');
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (1922, 12, 'Toga'); 
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (1923, 12, 'Torás'); 
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1924, 12, 'Toro (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1925, 12, 'Torralba del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1926, 12, 'Torre d''En Besora (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1927, 12, 'Torre Endoménech'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1928, 12, 'Torreblanca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1929, 12, 'Torrechiva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1930, 12, 'Traiguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1931, 12, 'Useras/Useres (les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1932, 12, 'Vall d''Alba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1933, 12, 'Vall de Almonacid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1934, 12, 'Vall d''Uixó (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1935, 12, 'Vallat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1936, 12, 'Vallibona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1955, 13, 'Albaladejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1956, 13, 'Alcázar de San Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1957, 13, 'Alcoba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1958, 13, 'Alcolea de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1959, 13, 'Alcubillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1960, 13, 'Aldea del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1961, 13, 'Alhambra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1962, 13, 'Almadén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1963, 13, 'Almadenejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1964, 13, 'Almagro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1965, 13, 'Almedina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1966, 13, 'Almodóvar del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1967, 13, 'Almuradiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1968, 13, 'Anchuras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1969, 13, 'Arenales de San Gregorio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1970, 13, 'Arenas de San Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1971, 13, 'Argamasilla de Alba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1972, 13, 'Argamasilla de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1991, 13, 'Daimiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1992, 13, 'Fernán Caballero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1993, 13, 'Fontanarejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1994, 13, 'Fuencaliente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1995, 13, 'Fuenllana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1996, 13, 'Fuente el Fresno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1997, 13, 'Granátula de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1998, 13, 'Guadalmez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1999, 13, 'Herencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2000, 13, 'Hinojosas de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2001, 13, 'Horcajo de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2002, 13, 'Labores (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2003, 13, 'Llanos del Caudillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2004, 13, 'Luciana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2005, 13, 'Malagón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2006, 13, 'Manzanares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2007, 13, 'Membrilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2008, 13, 'Mestanza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2009, 13, 'Miguelturra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1973, 13, 'Arroba de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1974, 13, 'Ballesteros de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1975, 13, 'Bolaños de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1976, 13, 'Brazatortas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1977, 13, 'Cabezarados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1978, 13, 'Cabezarrubias del Puerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1979, 13, 'Calzada de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1980, 13, 'Campo de Criptana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1981, 13, 'Cañada de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1982, 13, 'Caracuel de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1983, 13, 'Carrión de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1984, 13, 'Carrizosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1985, 13, 'Castellar de Santiago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1986, 13, 'Chillón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1987, 13, 'Ciudad Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1988, 13, 'Corral de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1989, 13, 'Cortijos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(1990, 13, 'Cózar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2010, 13, 'Montiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2011, 13, 'Moral de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2012, 13, 'Navalpino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2013, 13, 'Navas de Estena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2014, 13, 'Pedro Muñoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2015, 13, 'Picón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2016, 13, 'Piedrabuena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2017, 13, 'Poblete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2018, 13, 'Porzuna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2019, 13, 'Pozuelo de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2020, 13, 'Pozuelos de Calatrava (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2021, 13, 'Puebla de Don Rodrigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2022, 13, 'Puebla del Príncipe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2023, 13, 'Puerto Lápice'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2024, 13, 'Puertollano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2025, 13, 'Retuerta del Bullaque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2026, 13, 'Robledo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2027, 13, 'Ruidera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2028, 13, 'Saceruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2047, 13, 'Villanueva de la Fuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2048, 13, 'Villanueva de los Infantes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2049, 13, 'Villanueva de San Carlos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2050, 13, 'Villar del Pozo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2051, 13, 'Villarrubia de los Ojos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2052, 13, 'Villarta de San Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2053, 13, 'Viso del Marqués'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2054, 14, 'Adamuz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2055, 14, 'Aguilar de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2056, 14, 'Alcaracejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2057, 14, 'Almedinilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2058, 14, 'Almodóvar del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2059, 14, 'Añora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2060, 14, 'Baena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2061, 14, 'Belalcázar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2062, 14, 'Belmez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2029, 13, 'San Carlos del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2030, 13, 'San Lorenzo de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2031, 13, 'Santa Cruz de los Cáñamos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2032, 13, 'Santa Cruz de Mudela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2033, 13, 'Socuéllamos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2034, 13, 'Solana (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2035, 13, 'Solana del Pino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2036, 13, 'Terrinches'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2037, 13, 'Tomelloso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2038, 13, 'Torralba de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2039, 13, 'Torre de Juan Abad'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2040, 13, 'Torrenueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2041, 13, 'Valdemanco del Esteras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2042, 13, 'Valdepeñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2043, 13, 'Valenzuela de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2044, 13, 'Villahermosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2045, 13, 'Villamanrique'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2046, 13, 'Villamayor de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2063, 14, 'Benamejí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2064, 14, 'Blázquez (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2065, 14, 'Bujalance'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2066, 14, 'Cabra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2067, 14, 'Cañete de las Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2068, 14, 'Carcabuey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2069, 14, 'Cardeña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2070, 14, 'Carlota (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2071, 14, 'Carpio (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2072, 14, 'Castro del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2073, 14, 'Conquista'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2074, 14, 'Córdoba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2075, 14, 'Doña Mencía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2076, 14, 'Dos Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2077, 14, 'Encinas Reales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2078, 14, 'Espejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2079, 14, 'Espiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2080, 14, 'Fernán-Núñez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2081, 14, 'Fuente la Lancha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2120, 14, 'Villafranca de Córdoba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2121, 14, 'Villaharta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2101, 14, 'Palenciana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2102, 14, 'Palma del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2103, 14, 'Pedro Abad'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2104, 14, 'Pedroche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2105, 14, 'Peñarroya-Pueblonuevo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2106, 14, 'Posadas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2107, 14, 'Pozoblanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2108, 14, 'Priego de Córdoba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2109, 14, 'Puente Genil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2110, 14, 'Rambla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2111, 14, 'Rute'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2112, 14, 'San Sebastián de los Ballesteros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2113, 14, 'Santa Eufemia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2114, 14, 'Santaella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2115, 14, 'Torrecampo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2116, 14, 'Valenzuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2117, 14, 'Valsequillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2118, 14, 'Victoria (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2119, 14, 'Villa del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2082, 14, 'Fuente Obejuna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2083, 14, 'Fuente Palmera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2084, 14, 'Fuente-Tójar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2085, 14, 'Granjuela (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2086, 14, 'Guadalcázar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2087, 14, 'Guijo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2088, 14, 'Hinojosa del Duque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2089, 14, 'Hornachuelos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2090, 14, 'Iznájar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2091, 14, 'Lucena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2092, 14, 'Luque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2093, 14, 'Montalbán de Córdoba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2094, 14, 'Montemayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2095, 14, 'Montilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2096, 14, 'Montoro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2097, 14, 'Monturque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2098, 14, 'Moriles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2099, 14, 'Nueva Carteya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2100, 14, 'Obejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2122, 14, 'Villanueva de Córdoba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2123, 14, 'Villanueva del Duque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2124, 14, 'Villanueva del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2125, 14, 'Villaralto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2126, 14, 'Villaviciosa de Córdoba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2127, 14, 'Viso (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2128, 14, 'Zuheros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2129, 15, 'Abegondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2130, 15, 'Ames'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2131, 15, 'Aranga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2132, 15, 'Ares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2133, 15, 'Arteixo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2134, 15, 'Arzúa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2135, 15, 'Baña (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2136, 15, 'Bergondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2137, 15, 'Betanzos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2138, 15, 'Boimorto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2139, 15, 'Boiro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2140, 15, 'Boqueixón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2180, 15, 'Mugardos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2181, 15, 'Muros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2182, 15, 'Muxía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2183, 15, 'Narón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2184, 15, 'Neda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2185, 15, 'Negreira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2186, 15, 'Noia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2160, 15, 'Culleredo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2161, 15, 'Curtis'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2162, 15, 'Dodro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2163, 15, 'Dumbría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2164, 15, 'Fene'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2165, 15, 'Ferrol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2166, 15, 'Fisterra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2167, 15, 'Frades'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2168, 15, 'Irixoa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2169, 15, 'Laracha (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2170, 15, 'Laxe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2171, 15, 'Lousame'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2172, 15, 'Malpica de Bergantiños'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2173, 15, 'Mañón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2174, 15, 'Mazaricos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2175, 15, 'Melide'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2176, 15, 'Mesía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2177, 15, 'Miño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2178, 15, 'Moeche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2179, 15, 'Monfero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2141, 15, 'Brión'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2142, 15, 'Cabana de Bergantiños'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2143, 15, 'Cabanas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2144, 15, 'Camariñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2145, 15, 'Cambre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2146, 15, 'Capela (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2147, 15, 'Carballo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2148, 15, 'Cariño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2149, 15, 'Carnota'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2150, 15, 'Carral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2151, 15, 'Cedeira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2152, 15, 'Cee'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2153, 15, 'Cerceda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2154, 15, 'Cerdido'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2155, 15, 'Cesuras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2156, 15, 'Coirós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2157, 15, 'Corcubión'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2158, 15, 'Coristanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2159, 15, 'Coruña (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2187, 15, 'Oleiros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2188, 15, 'Ordes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2189, 15, 'Oroso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2190, 15, 'Ortigueira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2191, 15, 'Outes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2192, 15, 'Oza dos Ríos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2193, 15, 'Paderne'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2194, 15, 'Padrón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2195, 15, 'Pino (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2196, 15, 'Pobra do Caramiñal (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2197, 15, 'Ponteceso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2198, 15, 'Pontedeume'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2199, 15, 'Pontes de García Rodríguez (As)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2200, 15, 'Porto do Son'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2201, 15, 'Rianxo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2202, 15, 'Ribeira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2203, 15, 'Rois'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2204, 15, 'Sada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2205, 15, 'San Sadurniño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2243, 16, 'Arcas del Villar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2244, 16, 'Arcos de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2245, 16, 'Arguisuelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2225, 16, 'Alarcón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2226, 16, 'Albaladejo del Cuende'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2227, 16, 'Albalate de las Nogueras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2228, 16, 'Albendea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2229, 16, 'Alberca de Záncara (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2230, 16, 'Alcalá de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2231, 16, 'Alcantud'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2232, 16, 'Alcázar del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2233, 16, 'Alcohujate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2234, 16, 'Alconchel de la Estrella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2235, 16, 'Algarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2236, 16, 'Aliaguilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2237, 16, 'Almarcha (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2238, 16, 'Almendros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2239, 16, 'Almodóvar del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2240, 16, 'Almonacid del Marquesado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2241, 16, 'Altarejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2242, 16, 'Arandilla del Arroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2206, 15, 'Santa Comba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2207, 15, 'Santiago de Compostela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2208, 15, 'Santiso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2209, 15, 'Sobrado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2210, 15, 'Somozas (As)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2211, 15, 'Teo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2212, 15, 'Toques'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2213, 15, 'Tordoia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2214, 15, 'Touro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2215, 15, 'Trazo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2216, 15, 'Val do Dubra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2217, 15, 'Valdoviño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2218, 15, 'Vedra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2219, 15, 'Vilarmaior'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2220, 15, 'Vilasantar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2221, 15, 'Vimianzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2222, 15, 'Zas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2223, 16, 'Abia de la Obispalía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2224, 16, 'Acebrón (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2246, 16, 'Arrancacepas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2247, 16, 'Atalaya del Cañavate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2248, 16, 'Barajas de Melo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2249, 16, 'Barchín del Hoyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2250, 16, 'Bascuñana de San Pedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2251, 16, 'Beamud'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2252, 16, 'Belinchón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2253, 16, 'Belmonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2254, 16, 'Belmontejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2255, 16, 'Beteta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2256, 16, 'Boniches'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2257, 16, 'Buciegas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2258, 16, 'Buenache de Alarcón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2259, 16, 'Buenache de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2260, 16, 'Buendía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2261, 16, 'Campillo de Altobuey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2262, 16, 'Campillos-Paravientos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2263, 16, 'Campillos-Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2282, 16, 'Casas de Haro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2283, 16, 'Casas de los Pinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2284, 16, 'Casasimarro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2285, 16, 'Castejón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2286, 16, 'Castillejo de Iniesta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2287, 16, 'Castillejo-Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2288, 16, 'Castillo de Garcimuñoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2289, 16, 'Castillo-Albaráñez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2290, 16, 'Cervera del Llano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2291, 16, 'Chillarón de Cuenca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2292, 16, 'Chumillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2293, 16, 'Cierva (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2294, 16, 'Cuenca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2295, 16, 'Cueva del Hierro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2296, 16, 'Enguídanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2297, 16, 'Fresneda de Altarejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2298, 16, 'Fresneda de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2299, 16, 'Frontera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2264, 16, 'Campos del Paraíso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2265, 16, 'Canalejas del Arroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2266, 16, 'Cañada del Hoyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2267, 16, 'Cañada Juncosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2268, 16, 'Cañamares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2269, 16, 'Cañavate (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2270, 16, 'Cañaveras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2271, 16, 'Cañaveruelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2272, 16, 'Cañete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2273, 16, 'Cañizares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2274, 16, 'Carboneras de Guadazaón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2275, 16, 'Cardenete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2276, 16, 'Carrascosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2277, 16, 'Carrascosa de Haro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2278, 16, 'Casas de Benítez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2279, 16, 'Casas de Fernando Alonso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2280, 16, 'Casas de Garcimolina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2281, 16, 'Casas de Guijarro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2300, 16, 'Fuente de Pedro Naharro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2301, 16, 'Fuentelespino de Haro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2302, 16, 'Fuentelespino de Moya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2303, 16, 'Fuentenava de Jábaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2304, 16, 'Fuentes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2305, 16, 'Fuertescusa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2306, 16, 'Gabaldón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2307, 16, 'Garaballa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2308, 16, 'Gascueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2309, 16, 'Graja de Campalbo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2310, 16, 'Graja de Iniesta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2311, 16, 'Henarejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2312, 16, 'Herrumblar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2313, 16, 'Hinojosa (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2314, 16, 'Hinojosos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2315, 16, 'Hito (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2316, 16, 'Honrubia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2317, 16, 'Hontanaya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2318, 16, 'Hontecillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2338, 16, 'Monreal del Llano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2339, 16, 'Montalbanejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2340, 16, 'Montalbo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2341, 16, 'Monteagudo de las Salinas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2342, 16, 'Mota de Altarejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2343, 16, 'Mota del Cuervo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2344, 16, 'Motilla del Palancar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2345, 16, 'Moya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2346, 16, 'Narboneta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2347, 16, 'Olivares de Júcar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2348, 16, 'Olmeda de la Cuesta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2349, 16, 'Olmeda del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2350, 16, 'Olmedilla de Alarcón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2351, 16, 'Olmedilla de Eliz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2352, 16, 'Osa de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2353, 16, 'Pajarón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2354, 16, 'Pajaroncillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2355, 16, 'Palomares del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2319, 16, 'Horcajo de Santiago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2320, 16, 'Huélamo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2321, 16, 'Huelves'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2322, 16, 'Huérguina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2323, 16, 'Huerta de la Obispalía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2324, 16, 'Huerta del Marquesado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2325, 16, 'Huete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2326, 16, 'Iniesta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2327, 16, 'Laguna del Marquesado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2328, 16, 'Lagunaseca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2329, 16, 'Landete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2330, 16, 'Ledaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2331, 16, 'Leganiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2332, 16, 'Majadas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2333, 16, 'Mariana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2334, 16, 'Masegosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2335, 16, 'Mesas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2336, 16, 'Minglanilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2337, 16, 'Mira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2356, 16, 'Palomera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2357, 16, 'Paracuellos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2358, 16, 'Paredes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2359, 16, 'Parra de las Vegas (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2360, 16, 'Pedernoso (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2361, 16, 'Pedroñeras (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2362, 16, 'Peral (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2363, 16, 'Peraleja (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2364, 16, 'Pesquera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2365, 16, 'Picazo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2366, 16, 'Pinarejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2367, 16, 'Pineda de Gigüela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2368, 16, 'Piqueras del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2369, 16, 'Portalrubio de Guadamejud'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2370, 16, 'Portilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2371, 16, 'Poyatos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2372, 16, 'Pozoamargo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2373, 16, 'Pozorrubielos de la Mancha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2392, 16, 'San Martín de Boniches'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2393, 16, 'San Pedro Palmiches'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2394, 16, 'Santa Cruz de Moya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2395, 16, 'Santa María de los Llanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2396, 16, 'Santa María del Campo Rus'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2397, 16, 'Santa María del Val'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2398, 16, 'Sisante'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2399, 16, 'Solera de Gabaldón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2400, 16, 'Sotorribas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2401, 16, 'Talayuelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2402, 16, 'Tarancón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2403, 16, 'Tébar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2404, 16, 'Tejadillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2405, 16, 'Tinajas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2406, 16, 'Torralba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2407, 16, 'Torrejoncillo del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2408, 16, 'Torrubia del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2409, 16, 'Torrubia del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2374, 16, 'Pozorrubio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2375, 16, 'Pozuelo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2376, 16, 'Priego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2377, 16, 'Provencio (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2378, 16, 'Puebla de Almenara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2379, 16, 'Puebla de Don Francisco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2380, 16, 'Puebla del Salvador'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2381, 16, 'Quintanar del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2382, 16, 'Rada de Haro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2383, 16, 'Reíllo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2384, 16, 'Rozalén del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2385, 16, 'Saceda-Trasierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2386, 16, 'Saelices'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2387, 16, 'Salinas del Manzano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2388, 16, 'Salmeroncillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2389, 16, 'Salvacañete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2390, 16, 'San Clemente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2391, 16, 'San Lorenzo de la Parrilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2410, 16, 'Tragacete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2411, 16, 'Tresjuncos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2412, 16, 'Tribaldos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2413, 16, 'Uclés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2414, 16, 'Uña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2415, 16, 'Valdecolmenas (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2416, 16, 'Valdemeca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2417, 16, 'Valdemorillo de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2418, 16, 'Valdemoro-Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2419, 16, 'Valdeolivas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2420, 16, 'Valdetórtola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2421, 16, 'Valeras (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2422, 16, 'Valhermoso de la Fuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2423, 16, 'Valsalobre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2424, 16, 'Valverde de Júcar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2425, 16, 'Valverdejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2426, 16, 'Vara de Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2427, 16, 'Vega del Codorno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2428, 16, 'Vellisca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2446, 16, 'Villarejo de Fuentes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2447, 16, 'Villarejo de la Peñuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2448, 16, 'Villarejo-Periesteban'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2449, 16, 'Villares del Saz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2450, 16, 'Villarrubio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2451, 16, 'Villarta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2452, 16, 'Villas de la Ventosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2453, 16, 'Villaverde y Pasaconsol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2454, 16, 'Víllora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2455, 16, 'Vindel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2456, 16, 'Yémeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2457, 16, 'Zafra de Záncara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2458, 16, 'Zafrilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2459, 16, 'Zarza de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2460, 16, 'Zarzuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2461, 17, 'Agullana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2462, 17, 'Aiguaviva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2429, 16, 'Villaconejos de Trabaque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2430, 16, 'Villaescusa de Haro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2431, 16, 'Villagarcía del Llano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2432, 16, 'Villalba de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2433, 16, 'Villalba del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2434, 16, 'Villalgordo del Marquesado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2435, 16, 'Villalpardo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2436, 16, 'Villamayor de Santiago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2437, 16, 'Villanueva de Guadamejud'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2438, 16, 'Villanueva de la Jara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2439, 16, 'Villar de Cañas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2440, 16, 'Villar de Domingo García'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2441, 16, 'Villar de la Encina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2442, 16, 'Villar de Olalla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2443, 16, 'Villar del Humo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2444, 16, 'Villar del Infantado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2445, 16, 'Villar y Velasco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2463, 17, 'Albanyà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2464, 17, 'Albons'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2465, 17, 'Alp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2466, 17, 'Amer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2467, 17, 'Anglès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2468, 17, 'Arbúcies'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2469, 17, 'Argelaguer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2470, 17, 'Armentera (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2471, 17, 'Avinyonet de Puigventós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2472, 17, 'Banyoles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2473, 17, 'Bàscara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2474, 17, 'Begur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2475, 17, 'Bellcaire d''Empordà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2476, 17, 'Besalú'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2477, 17, 'Bescanó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2478, 17, 'Beuda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2479, 17, 'Bisbal d''Empordà (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2480, 17, 'Biure'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2481, 17, 'Blanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2519, 17, 'Espolla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2520, 17, 'Esponellà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2521, 17, 'Far d''Empordà (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2522, 17, 'Figueres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2501, 17, 'Cassà de la Selva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2502, 17, 'Castellfollit de la Roca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2503, 17, 'Castelló d''Empúries'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2504, 17, 'Castell-Platja d''Aro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2505, 17, 'Cellera de Ter (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2506, 17, 'Celrà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2507, 17, 'Cervià de Ter'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2508, 17, 'Cistella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2509, 17, 'Colera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2510, 17, 'Colomers'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2511, 17, 'Corçà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2512, 17, 'Cornellà del Terri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2513, 17, 'Crespià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2514, 17, 'Cruïlles, Monells i Sant Sadurní de l''Heura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2515, 17, 'Darnius'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2516, 17, 'Das'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2517, 17, 'Escala (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2518, 17, 'Espinelves'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2482, 17, 'Boadella i les Escaules'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2483, 17, 'Bolvir'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2484, 17, 'Bordils'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2485, 17, 'Borrassà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2486, 17, 'Breda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2487, 17, 'Brunyola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2488, 17, 'Cabanelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2489, 17, 'Cabanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2490, 17, 'Cadaqués'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2491, 17, 'Caldes de Malavella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2492, 17, 'Calonge'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2493, 17, 'Camós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2494, 17, 'Campdevànol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2495, 17, 'Campelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2496, 17, 'Campllong'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2497, 17, 'Camprodon'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2498, 17, 'Canet d''Adri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2499, 17, 'Cantallops'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2500, 17, 'Capmany'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2523, 17, 'Flaçà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2524, 17, 'Foixà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2525, 17, 'Fontanals de Cerdanya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2526, 17, 'Fontanilles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2527, 17, 'Fontcoberta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2528, 17, 'Forallac'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2529, 17, 'Fornells de la Selva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2530, 17, 'Fortià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2531, 17, 'Garrigàs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2532, 17, 'Garrigoles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2533, 17, 'Garriguella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2534, 17, 'Ger'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2535, 17, 'Girona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2536, 17, 'Gombrèn'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2537, 17, 'Gualta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2538, 17, 'Guils de Cerdanya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2539, 17, 'Hostalric'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2540, 17, 'Isòvol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2541, 17, 'Jafre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2580, 17, 'Pedret i Marzà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2581, 17, 'Pera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2582, 17, 'Peralada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2583, 17, 'Planes d''Hostoles (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2584, 17, 'Planoles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2561, 17, 'Mollet de Peralada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2562, 17, 'Molló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2563, 17, 'Montagut i Oix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2564, 17, 'Mont-ras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2565, 17, 'Navata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2566, 17, 'Ogassa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2567, 17, 'Olot'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2568, 17, 'Ordis'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2569, 17, 'Osor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2570, 17, 'Palafrugell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2571, 17, 'Palamós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2572, 17, 'Palau de Santa Eulàlia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2573, 17, 'Palau-sator'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2574, 17, 'Palau-saverdera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2575, 17, 'Palol de Revardit'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2576, 17, 'Pals'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2577, 17, 'Pardines'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2578, 17, 'Parlavà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2579, 17, 'Pau'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2542, 17, 'Jonquera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2543, 17, 'Juià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2544, 17, 'Lladó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2545, 17, 'Llagostera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2546, 17, 'Llambilles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2547, 17, 'Llanars'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2548, 17, 'Llançà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2549, 17, 'Llers'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2550, 17, 'Llívia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2551, 17, 'Lloret de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2552, 17, 'Llosses (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2553, 17, 'Maçanet de Cabrenys'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2554, 17, 'Maçanet de la Selva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2555, 17, 'Madremanya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2556, 17, 'Maià de Montcal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2557, 17, 'Masarac'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2558, 17, 'Massanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2559, 17, 'Meranges'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2560, 17, 'Mieres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2585, 17, 'Pont de Molins'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2586, 17, 'Pontós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2587, 17, 'Porqueres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2588, 17, 'Port de la Selva (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2589, 17, 'Portbou'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2590, 17, 'Preses (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2591, 17, 'Puigcerdà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2592, 17, 'Quart'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2593, 17, 'Queralbs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2594, 17, 'Rabós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2595, 17, 'Regencós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2596, 17, 'Ribes de Freser'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2597, 17, 'Riells i Viabrea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2598, 17, 'Ripoll'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2599, 17, 'Riudarenes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2600, 17, 'Riudaura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2601, 17, 'Riudellots de la Selva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2602, 17, 'Riumors'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2603, 17, 'Roses'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2622, 17, 'Sant Julià del Llor i Bonmatí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2623, 17, 'Sant Llorenç de la Muga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2624, 17, 'Sant Martí de Llémena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2625, 17, 'Sant Martí Vell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2626, 17, 'Sant Miquel de Campmajor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2627, 17, 'Sant Miquel de Fluvià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2628, 17, 'Sant Mori'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2629, 17, 'Sant Pau de Segúries'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2630, 17, 'Sant Pere Pescador'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2631, 17, 'Santa Coloma de Farners'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2632, 17, 'Santa Cristina d''Aro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2633, 17, 'Santa Llogaia d''Àlguema'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2634, 17, 'Santa Pau'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2635, 17, 'Sarrià de Ter'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2636, 17, 'Saus, Camallera i Llampaies'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2604, 17, 'Rupià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2605, 17, 'Sales de Llierca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2606, 17, 'Salt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2607, 17, 'Sant Andreu Salou'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2608, 17, 'Sant Aniol de Finestres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2609, 17, 'Sant Climent Sescebes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2610, 17, 'Sant Feliu de Buixalleu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2611, 17, 'Sant Feliu de Guíxols'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2612, 17, 'Sant Feliu de Pallerols'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2613, 17, 'Sant Ferriol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2614, 17, 'Sant Gregori'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2615, 17, 'Sant Hilari Sacalm'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2616, 17, 'Sant Jaume de Llierca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2617, 17, 'Sant Joan de les Abadesses'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2618, 17, 'Sant Joan de Mollet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2619, 17, 'Sant Joan les Fonts'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2620, 17, 'Sant Jordi Desvalls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2621, 17, 'Sant Julià de Ramis'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2637, 17, 'Selva de Mar (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2638, 17, 'Serinyà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2639, 17, 'Serra de Daró'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2640, 17, 'Setcases'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2641, 17, 'Sils'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2642, 17, 'Siurana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2643, 17, 'Susqueda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2644, 17, 'Tallada d''Empordà (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2645, 17, 'Terrades'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2646, 17, 'Torrent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2647, 17, 'Torroella de Fluvià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2648, 17, 'Torroella de Montgrí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2649, 17, 'Tortellà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2650, 17, 'Toses'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2651, 17, 'Tossa de Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2652, 17, 'Ullà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2653, 17, 'Ullastret'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2654, 17, 'Ultramort'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2655, 17, 'Urús'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2694, 18, 'Alicún de Ortega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2695, 18, 'Almegíjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2696, 18, 'Almuñécar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2675, 17, 'Vilamalla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2676, 17, 'Vilamaniscle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2677, 17, 'Vilanant'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2678, 17, 'Vila-sacra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2679, 17, 'Vilaür'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2680, 17, 'Vilobí d''Onyar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2681, 17, 'Vilopriu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2682, 18, 'Agrón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2683, 18, 'Alamedilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2684, 18, 'Albolote'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2685, 18, 'Albondón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2686, 18, 'Albuñán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2687, 18, 'Albuñol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2688, 18, 'Albuñuelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2689, 18, 'Aldeire'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2690, 18, 'Alfacar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2691, 18, 'Algarinejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2692, 18, 'Alhama de Granada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2693, 18, 'Alhendín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2656, 17, 'Vajol (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2657, 17, 'Vall de Bianya (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2658, 17, 'Vall d''en Bas (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2659, 17, 'Vallfogona de Ripollès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2660, 17, 'Vall-llobrega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2661, 17, 'Ventalló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2662, 17, 'Verges'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2663, 17, 'Vidrà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2664, 17, 'Vidreres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2665, 17, 'Vilabertran'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2666, 17, 'Vilablareix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2667, 17, 'Viladamat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2668, 17, 'Viladasens'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2669, 17, 'Vilademuls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2670, 17, 'Viladrau'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2671, 17, 'Vilafant'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2672, 17, 'Vilajuïga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2673, 17, 'Vilallonga de Ter'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2674, 17, 'Vilamacolum'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2697, 18, 'Alpujarra de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2698, 18, 'Alquife'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2699, 18, 'Arenas del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2700, 18, 'Armilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2701, 18, 'Atarfe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2702, 18, 'Baza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2703, 18, 'Beas de Granada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2704, 18, 'Beas de Guadix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2705, 18, 'Benalúa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2706, 18, 'Benalúa de las Villas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2707, 18, 'Benamaurel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2708, 18, 'Bérchules'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2709, 18, 'Bubión'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2710, 18, 'Busquístar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2711, 18, 'Cacín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2712, 18, 'Cádiar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2713, 18, 'Cájar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2714, 18, 'Calahorra (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2715, 18, 'Calicasas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2755, 18, 'Gorafe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2756, 18, 'Granada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2757, 18, 'Guadahortuna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2758, 18, 'Guadix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2735, 18, 'Cúllar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2736, 18, 'Cúllar Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2737, 18, 'Darro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2738, 18, 'Dehesas de Guadix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2739, 18, 'Deifontes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2740, 18, 'Diezma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2741, 18, 'Dílar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2742, 18, 'Dólar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2743, 18, 'Dúdar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2744, 18, 'Dúrcal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2745, 18, 'Escúzar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2746, 18, 'Ferreira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2747, 18, 'Fonelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2748, 18, 'Freila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2749, 18, 'Fuente Vaqueros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2750, 18, 'Gabias (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2751, 18, 'Galera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2752, 18, 'Gobernador'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2753, 18, 'Gójar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2754, 18, 'Gor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2716, 18, 'Campotéjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2717, 18, 'Caniles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2718, 18, 'Cáñar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2719, 18, 'Capileira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2720, 18, 'Carataunas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2721, 18, 'Cástaras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2722, 18, 'Castilléjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2723, 18, 'Castril'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2724, 18, 'Cenes de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2725, 18, 'Chauchina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2726, 18, 'Chimeneas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2727, 18, 'Churriana de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2728, 18, 'Cijuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2729, 18, 'Cogollos de Guadix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2730, 18, 'Cogollos de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2731, 18, 'Colomera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2732, 18, 'Cortes de Baza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2733, 18, 'Cortes y Graena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2734, 18, 'Cuevas del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2759, 18, 'Guajares (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2760, 18, 'Gualchos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2761, 18, 'Güejar Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2762, 18, 'Güevéjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2763, 18, 'Huélago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2764, 18, 'Huéneja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2765, 18, 'Huéscar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2766, 18, 'Huétor de Santillán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2767, 18, 'Huétor Tájar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2768, 18, 'Huétor Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2769, 18, 'Illora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2770, 18, 'Itrabo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2771, 18, 'Iznalloz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2772, 18, 'Jayena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2773, 18, 'Jerez del Marquesado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2774, 18, 'Jete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2775, 18, 'Jun'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2776, 18, 'Juviles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2777, 18, 'Láchar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2817, 18, 'Polopos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2818, 18, 'Pórtugos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2819, 18, 'Puebla de Don Fadrique'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2820, 18, 'Pulianas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2821, 18, 'Purullena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2822, 18, 'Quéntar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2797, 18, 'Motril'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2798, 18, 'Murtas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2799, 18, 'Nevada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2800, 18, 'Nigüelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2801, 18, 'Nívar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2802, 18, 'Ogíjares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2803, 18, 'Orce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2804, 18, 'Órgiva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2805, 18, 'Otívar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2806, 18, 'Otura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2807, 18, 'Padul'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2808, 18, 'Pampaneira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2809, 18, 'Pedro Martínez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2810, 18, 'Peligros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2811, 18, 'Peza (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2812, 18, 'Pinar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2813, 18, 'Pinos Genil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2814, 18, 'Pinos Puente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2815, 18, 'Píñar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2816, 18, 'Polícar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2778, 18, 'Lanjarón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2779, 18, 'Lanteira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2780, 18, 'Lecrín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2781, 18, 'Lentegí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2782, 18, 'Lobras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2783, 18, 'Loja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2784, 18, 'Lugros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2785, 18, 'Lújar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2786, 18, 'Malahá (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2787, 18, 'Maracena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2788, 18, 'Marchal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2789, 18, 'Moclín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2790, 18, 'Molvízar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2791, 18, 'Monachil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2792, 18, 'Montefrío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2793, 18, 'Montejícar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2794, 18, 'Montillana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2795, 18, 'Moraleda de Zafayona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2796, 18, 'Morelábor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2823, 18, 'Rubite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2824, 18, 'Salar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2825, 18, 'Salobreña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2826, 18, 'Santa Cruz del Comercio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2827, 18, 'Santa Fe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2828, 18, 'Soportújar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2829, 18, 'Sorvilán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2830, 18, 'Taha (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2831, 18, 'Torre-Cardela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2832, 18, 'Torvizcón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2833, 18, 'Trevélez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2834, 18, 'Turón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2835, 18, 'Ugíjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2836, 18, 'Valle (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2837, 18, 'Valle del Zalabí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2838, 18, 'Válor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2839, 18, 'Vegas del Genil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2840, 18, 'Vélez de Benaudalla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2841, 18, 'Ventas de Huelma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2880, 19, 'Argecilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2881, 19, 'Armallones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2882, 19, 'Armuña de Tajuña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2861, 19, 'Alcoroches'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2862, 19, 'Aldeanueva de Guadalajara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2863, 19, 'Algar de Mesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2864, 19, 'Algora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2865, 19, 'Alhóndiga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2866, 19, 'Alique'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2867, 19, 'Almadrones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2868, 19, 'Almoguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2869, 19, 'Almonacid de Zorita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2870, 19, 'Alocén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2871, 19, 'Alovera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2872, 19, 'Alustante'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2873, 19, 'Angón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2874, 19, 'Anguita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2875, 19, 'Anquela del Ducado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2876, 19, 'Anquela del Pedregal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2877, 19, 'Aranzueque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2878, 19, 'Arbancón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2879, 19, 'Arbeteta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2842, 18, 'Villamena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2843, 18, 'Villanueva de las Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2844, 18, 'Villanueva Mesía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2845, 18, 'Víznar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2846, 18, 'Zafarraya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2847, 18, 'Zagra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2848, 18, 'Zubia (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2849, 18, 'Zújar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2850, 19, 'Abánades'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2851, 19, 'Ablanque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2852, 19, 'Adobes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2853, 19, 'Alaminos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2854, 19, 'Alarilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2855, 19, 'Albalate de Zorita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2856, 19, 'Albares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2857, 19, 'Albendiego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2858, 19, 'Alcocer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2859, 19, 'Alcolea de las Peñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2860, 19, 'Alcolea del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2883, 19, 'Arroyo de las Fraguas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2884, 19, 'Atanzón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2885, 19, 'Atienza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2886, 19, 'Auñón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2887, 19, 'Azuqueca de Henares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2888, 19, 'Baides'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2889, 19, 'Baños de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2890, 19, 'Bañuelos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2891, 19, 'Barriopedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2892, 19, 'Berninches'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2893, 19, 'Bodera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2894, 19, 'Brihuega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2895, 19, 'Budia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2896, 19, 'Bujalaro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2897, 19, 'Bustares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2898, 19, 'Cabanillas del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2899, 19, 'Campillo de Dueñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2900, 19, 'Campillo de Ranas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2901, 19, 'Campisábalos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2939, 19, 'Escopete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2940, 19, 'Espinosa de Henares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2920, 19, 'Chiloeches'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2921, 19, 'Cifuentes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2922, 19, 'Cincovillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2923, 19, 'Ciruelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2924, 19, 'Ciruelos del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2925, 19, 'Cobeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2926, 19, 'Cogollor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2927, 19, 'Cogolludo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2928, 19, 'Condemios de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2929, 19, 'Condemios de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2930, 19, 'Congostrina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2931, 19, 'Copernal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2932, 19, 'Corduente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2933, 19, 'Cubillo de Uceda (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2934, 19, 'Driebes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2935, 19, 'Durón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2936, 19, 'Embid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2937, 19, 'Escamilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2938, 19, 'Escariche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2902, 19, 'Canredondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2903, 19, 'Cantalojas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2904, 19, 'Cañizar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2905, 19, 'Cardoso de la Sierra (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2906, 19, 'Casa de Uceda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2907, 19, 'Casar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2908, 19, 'Casas de San Galindo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2909, 19, 'Caspueñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2910, 19, 'Castejón de Henares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2911, 19, 'Castellar de la Muela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2912, 19, 'Castilforte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2913, 19, 'Castilnuevo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2914, 19, 'Cendejas de Enmedio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2915, 19, 'Cendejas de la Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2916, 19, 'Centenera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2917, 19, 'Checa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2918, 19, 'Chequilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2919, 19, 'Chillarón del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2941, 19, 'Esplegares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2942, 19, 'Establés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2943, 19, 'Estriégana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2944, 19, 'Fontanar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2945, 19, 'Fuembellida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2946, 19, 'Fuencemillán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2947, 19, 'Fuentelahiguera de Albatages'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2948, 19, 'Fuentelencina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2949, 19, 'Fuentelsaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2950, 19, 'Fuentelviejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2951, 19, 'Fuentenovilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2952, 19, 'Gajanejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2953, 19, 'Galápagos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2954, 19, 'Galve de Sorbe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2955, 19, 'Gascueña de Bornova'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2956, 19, 'Guadalajara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2957, 19, 'Henche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2958, 19, 'Heras de Ayuso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2959, 19, 'Herrería'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2998, 19, 'Miedes de Atienza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2999, 19, 'Mierla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3000, 19, 'Millana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3001, 19, 'Milmarcos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2979, 19, 'Loranca de Tajuña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2980, 19, 'Lupiana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2981, 19, 'Luzaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2982, 19, 'Luzón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2983, 19, 'Majaelrayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2984, 19, 'Málaga del Fresno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2985, 19, 'Malaguilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2986, 19, 'Mandayona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2987, 19, 'Mantiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2988, 19, 'Maranchón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2989, 19, 'Marchamalo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2990, 19, 'Masegoso de Tajuña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2991, 19, 'Matarrubia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2992, 19, 'Matillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2993, 19, 'Mazarete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2994, 19, 'Mazuecos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2995, 19, 'Medranda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2996, 19, 'Megina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2997, 19, 'Membrillera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2960, 19, 'Hiendelaencina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2961, 19, 'Hijes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2962, 19, 'Hita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2963, 19, 'Hombrados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2964, 19, 'Hontoba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2965, 19, 'Horche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2966, 19, 'Hortezuela de Océn'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2967, 19, 'Huerce (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2968, 19, 'Huérmeces del Cerro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2969, 19, 'Huertahernando'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2970, 19, 'Hueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2971, 19, 'Humanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2972, 19, 'Illana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2973, 19, 'Iniéstola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2974, 19, 'Inviernas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2975, 19, 'Irueste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2976, 19, 'Jadraque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2977, 19, 'Jirueque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(2978, 19, 'Ledanca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3002, 19, 'Miñosa (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3003, 19, 'Mirabueno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3004, 19, 'Miralrío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3005, 19, 'Mochales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3006, 19, 'Mohernando'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3007, 19, 'Molina de Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3008, 19, 'Monasterio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3009, 19, 'Mondéjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3010, 19, 'Montarrón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3011, 19, 'Moratilla de los Meleros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3012, 19, 'Morenilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3013, 19, 'Muduex'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3014, 19, 'Navas de Jadraque (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3015, 19, 'Negredo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3016, 19, 'Ocentejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3017, 19, 'Olivar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3018, 19, 'Olmeda de Cobeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3019, 19, 'Olmeda de Jadraque (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3020, 19, 'Ordial (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3040, 19, 'Prádena de Atienza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3041, 19, 'Prados Redondos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3042, 19, 'Puebla de Beleña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3043, 19, 'Puebla de Valles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3044, 19, 'Quer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3045, 19, 'Rebollosa de Jadraque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3046, 19, 'Recuenco (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3047, 19, 'Renera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3048, 19, 'Retiendas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3049, 19, 'Riba de Saelices'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3050, 19, 'Rillo de Gallo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3051, 19, 'Riofrío del Llano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3052, 19, 'Robledillo de Mohernando'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3053, 19, 'Robledo de Corpes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3054, 19, 'Romanillos de Atienza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3055, 19, 'Romanones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3056, 19, 'Rueda de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3057, 19, 'Sacecorbo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3021, 19, 'Orea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3022, 19, 'Pálmaces de Jadraque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3023, 19, 'Pardos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3024, 19, 'Paredes de Sigüenza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3025, 19, 'Pareja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3026, 19, 'Pastrana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3027, 19, 'Pedregal (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3028, 19, 'Peñalén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3029, 19, 'Peñalver'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3030, 19, 'Peralejos de las Truchas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3031, 19, 'Peralveche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3032, 19, 'Pinilla de Jadraque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3033, 19, 'Pinilla de Molina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3034, 19, 'Pioz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3035, 19, 'Piqueras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3036, 19, 'Pobo de Dueñas (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3037, 19, 'Poveda de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3038, 19, 'Pozo de Almoguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3039, 19, 'Pozo de Guadalajara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3058, 19, 'Sacedón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3059, 19, 'Saelices de la Sal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3060, 19, 'Salmerón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3061, 19, 'San Andrés del Congosto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3062, 19, 'San Andrés del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3063, 19, 'Santiuste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3064, 19, 'Saúca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3065, 19, 'Sayatón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3066, 19, 'Selas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3067, 19, 'Semillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3068, 19, 'Setiles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3069, 19, 'Sienes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3070, 19, 'Sigüenza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3071, 19, 'Solanillos del Extremo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3072, 19, 'Somolinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3073, 19, 'Sotillo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3074, 19, 'Sotodosos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3075, 19, 'Tamajón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3076, 19, 'Taragudo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3115, 19, 'Valdesotos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3116, 19, 'Valfermoso de Tajuña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3096, 19, 'Tórtola de Henares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3097, 19, 'Tortuera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3098, 19, 'Tortuero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3099, 19, 'Traíd'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3100, 19, 'Trijueque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3101, 19, 'Trillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3102, 19, 'Uceda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3103, 19, 'Ujados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3104, 19, 'Utande'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3105, 19, 'Valdarachas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3106, 19, 'Valdearenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3107, 19, 'Valdeavellano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3108, 19, 'Valdeaveruelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3109, 19, 'Valdeconcha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3110, 19, 'Valdegrudas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3111, 19, 'Valdelcubo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3112, 19, 'Valdenuño Fernández'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3113, 19, 'Valdepeñas de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3114, 19, 'Valderrebollo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3077, 19, 'Taravilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3078, 19, 'Tartanedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3079, 19, 'Tendilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3080, 19, 'Terzaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3081, 19, 'Tierzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3082, 19, 'Toba (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3083, 19, 'Tordellego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3084, 19, 'Tordelrábano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3085, 19, 'Tordesilos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3086, 19, 'Torija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3087, 19, 'Torre del Burgo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3088, 19, 'Torrecuadrada de Molina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3089, 19, 'Torrecuadradilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3090, 19, 'Torrejón del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3091, 19, 'Torremocha de Jadraque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3092, 19, 'Torremocha del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3093, 19, 'Torremocha del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3094, 19, 'Torremochuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3095, 19, 'Torrubia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3117, 19, 'Valhermoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3118, 19, 'Valtablado del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3119, 19, 'Valverde de los Arroyos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3120, 19, 'Viana de Jadraque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3121, 19, 'Villanueva de Alcorón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3122, 19, 'Villanueva de Argecilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3123, 19, 'Villanueva de la Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3124, 19, 'Villares de Jadraque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3125, 19, 'Villaseca de Henares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3126, 19, 'Villaseca de Uceda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3127, 19, 'Villel de Mesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3128, 19, 'Viñuelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3129, 19, 'Yebes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3130, 19, 'Yebra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3131, 19, 'Yélamos de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3132, 19, 'Yélamos de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3133, 19, 'Yunquera de Henares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3134, 19, 'Yunta (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3173, 20, 'Errenteria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3174, 20, 'Errezil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3175, 20, 'Eskoriatza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3176, 20, 'Ezkio-Itsaso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3154, 20, 'Asteasu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3155, 20, 'Astigarraga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3156, 20, 'Ataun'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3157, 20, 'Azkoitia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3158, 20, 'Azpeitia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3159, 20, 'Baliarrain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3160, 20, 'Beasain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3161, 20, 'Beizama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3162, 20, 'Belauntza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3163, 20, 'Berastegi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3164, 20, 'Bergara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3165, 20, 'Berrobi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3166, 20, 'Bidegoian'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3167, 20, 'Deba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3168, 20, 'Donostia-San Sebastián'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3169, 20, 'Eibar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3170, 20, 'Elduain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3171, 20, 'Elgeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3172, 20, 'Elgoibar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3135, 19, 'Zaorejas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3136, 19, 'Zarzuela de Jadraque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3137, 19, 'Zorita de los Canes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3138, 20, 'Abaltzisketa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3139, 20, 'Aduna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3140, 20, 'Aia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3141, 20, 'Aizarnazabal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3142, 20, 'Albiztur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3143, 20, 'Alegia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3144, 20, 'Alkiza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3145, 20, 'Altzaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3146, 20, 'Altzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3147, 20, 'Amezketa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3148, 20, 'Andoain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3149, 20, 'Anoeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3150, 20, 'Antzuola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3151, 20, 'Arama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3152, 20, 'Aretxabaleta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3153, 20, 'Arrasate/Mondragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3177, 20, 'Gabiria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3178, 20, 'Gaintza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3179, 20, 'Gaztelu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3180, 20, 'Getaria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3181, 20, 'Hernani'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3182, 20, 'Hernialde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3183, 20, 'Hondarribia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3184, 20, 'Ibarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3185, 20, 'Idiazabal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3186, 20, 'Ikaztegieta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3187, 20, 'Irun'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3188, 20, 'Irura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3189, 20, 'Itsasondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3190, 20, 'Larraul'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3191, 20, 'Lasarte-Oria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3192, 20, 'Lazkao'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3193, 20, 'Leaburu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3194, 20, 'Legazpi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3195, 20, 'Legorreta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3234, 21, 'Arroyomolinos de León'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3235, 21, 'Ayamonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3236, 21, 'Beas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3237, 21, 'Berrocal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3238, 21, 'Bollullos Par del Condado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3239, 21, 'Bonares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3240, 21, 'Cabezas Rubias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3215, 20, 'Urretxu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3216, 20, 'Usurbil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3217, 20, 'Villabona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3218, 20, 'Zaldibia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3219, 20, 'Zarautz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3220, 20, 'Zegama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3221, 20, 'Zerain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3222, 20, 'Zestoa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3223, 20, 'Zizurkil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3224, 20, 'Zumaia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3225, 20, 'Zumarraga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3226, 21, 'Alájar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3227, 21, 'Aljaraque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3228, 21, 'Almendro (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3229, 21, 'Almonaster la Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3230, 21, 'Almonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3231, 21, 'Alosno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3232, 21, 'Aracena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3233, 21, 'Aroche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3196, 20, 'Leintz-Gatzaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3197, 20, 'Lezo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3198, 20, 'Lizartza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3199, 20, 'Mendaro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3200, 20, 'Mutiloa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3201, 20, 'Mutriku'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3202, 20, 'Oiartzun'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3203, 20, 'Olaberria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3204, 20, 'Oñati'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3205, 20, 'Ordizia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3206, 20, 'Orendain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3207, 20, 'Orexa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3208, 20, 'Orio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3209, 20, 'Ormaiztegi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3210, 20, 'Pasaia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3211, 20, 'Segura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3212, 20, 'Soraluze/Placencia de las Armas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3213, 20, 'Tolosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3214, 20, 'Urnieta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3241, 21, 'Cala'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3242, 21, 'Calañas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3243, 21, 'Campillo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3244, 21, 'Campofrío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3245, 21, 'Cañaveral de León'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3246, 21, 'Cartaya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3247, 21, 'Castaño del Robledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3248, 21, 'Cerro de Andévalo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3249, 21, 'Chucena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3250, 21, 'Corteconcepción'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3251, 21, 'Cortegana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3252, 21, 'Cortelazor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3253, 21, 'Cumbres de Enmedio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3254, 21, 'Cumbres de San Bartolomé'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3255, 21, 'Cumbres Mayores'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3256, 21, 'Encinasola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3257, 21, 'Escacena del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3258, 21, 'Fuenteheridos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3259, 21, 'Galaroza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3279, 21, 'Palma del Condado (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3280, 21, 'Palos de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3281, 21, 'Paterna del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3282, 21, 'Paymogo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3283, 21, 'Puebla de Guzmán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3284, 21, 'Puerto Moral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3285, 21, 'Punta Umbría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3286, 21, 'Rociana del Condado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3287, 21, 'Rosal de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3288, 21, 'San Bartolomé de la Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3289, 21, 'San Juan del Puerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3290, 21, 'San Silvestre de Guzmán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3291, 21, 'Sanlúcar de Guadiana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3292, 21, 'Santa Ana la Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3293, 21, 'Santa Bárbara de Casa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3294, 21, 'Santa Olalla del Cala'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3295, 21, 'Trigueros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3260, 21, 'Gibraleón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3261, 21, 'Granada de Río-Tinto (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3262, 21, 'Granado (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3263, 21, 'Higuera de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3264, 21, 'Hinojales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3265, 21, 'Hinojos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3266, 21, 'Huelva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3267, 21, 'Isla Cristina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3268, 21, 'Jabugo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3269, 21, 'Lepe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3270, 21, 'Linares de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3271, 21, 'Lucena del Puerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3272, 21, 'Manzanilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3273, 21, 'Marines (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3274, 21, 'Minas de Riotinto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3275, 21, 'Moguer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3276, 21, 'Nava (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3277, 21, 'Nerva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3278, 21, 'Niebla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3296, 21, 'Valdelarco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3297, 21, 'Valverde del Camino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3298, 21, 'Villablanca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3299, 21, 'Villalba del Alcor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3300, 21, 'Villanueva de las Cruces'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3301, 21, 'Villanueva de los Castillejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3302, 21, 'Villarrasa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3303, 21, 'Zalamea la Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3304, 21, 'Zufre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3305, 22, 'Abiego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3306, 22, 'Abizanda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3307, 22, 'Adahuesca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3308, 22, 'Agüero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3309, 22, 'Aínsa-Sobrarbe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3310, 22, 'Aisa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3311, 22, 'Albalate de Cinca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3312, 22, 'Albalatillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3313, 22, 'Albelda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3314, 22, 'Albero Alto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3353, 22, 'Bielsa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3354, 22, 'Bierge'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3355, 22, 'Biescas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3356, 22, 'Binaced'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3334, 22, 'Argavieso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3335, 22, 'Arguis'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3336, 22, 'Ayerbe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3337, 22, 'Azanuy-Alins'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3338, 22, 'Azara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3339, 22, 'Azlor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3340, 22, 'Baélls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3341, 22, 'Bailo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3342, 22, 'Baldellou'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3343, 22, 'Ballobar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3344, 22, 'Banastás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3345, 22, 'Barbastro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3346, 22, 'Barbués'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3347, 22, 'Barbuñales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3348, 22, 'Bárcabo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3349, 22, 'Belver de Cinca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3350, 22, 'Benabarre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3351, 22, 'Benasque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3352, 22, 'Berbegal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3315, 22, 'Albero Bajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3316, 22, 'Alberuela de Tubo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3317, 22, 'Alcalá de Gurrea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3318, 22, 'Alcalá del Obispo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3319, 22, 'Alcampell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3320, 22, 'Alcolea de Cinca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3321, 22, 'Alcubierre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3322, 22, 'Alerre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3323, 22, 'Alfántega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3324, 22, 'Almudévar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3325, 22, 'Almunia de San Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3326, 22, 'Almuniente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3327, 22, 'Alquézar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3328, 22, 'Altorricón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3329, 22, 'Angüés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3330, 22, 'Ansó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3331, 22, 'Antillón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3332, 22, 'Aragüés del Puerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3333, 22, 'Arén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3357, 22, 'Binéfar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3358, 22, 'Bisaurri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3359, 22, 'Biscarrués'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3360, 22, 'Blecua y Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3361, 22, 'Boltaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3362, 22, 'Bonansa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3363, 22, 'Borau'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3364, 22, 'Broto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3365, 22, 'Caldearenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3366, 22, 'Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3367, 22, 'Camporrélls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3368, 22, 'Canal de Berdún'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3369, 22, 'Candasnos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3370, 22, 'Canfranc'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3371, 22, 'Capdesaso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3372, 22, 'Capella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3373, 22, 'Casbas de Huesca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3374, 22, 'Castejón de Monegros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3375, 22, 'Castejón de Sos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3415, 22, 'Lanaja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3416, 22, 'Laperdiguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3417, 22, 'Lascellas-Ponzano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3418, 22, 'Lascuarre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3395, 22, 'Fraga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3396, 22, 'Fueva (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3397, 22, 'Gistaín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3398, 22, 'Grado (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3399, 22, 'Grañén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3400, 22, 'Graus'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3401, 22, 'Gurrea de Gállego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3402, 22, 'Hoz de Jaca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3403, 22, 'Hoz y Costean'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3404, 22, 'Huerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3405, 22, 'Huesca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3406, 22, 'Ibieca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3407, 22, 'Igriés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3408, 22, 'Ilche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3409, 22, 'Isábena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3410, 22, 'Jaca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3411, 22, 'Jasa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3412, 22, 'Labuerda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3413, 22, 'Laluenga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3414, 22, 'Lalueza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3376, 22, 'Castejón del Puente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3377, 22, 'Castelflorite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3378, 22, 'Castiello de Jaca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3379, 22, 'Castigaleu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3380, 22, 'Castillazuelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3381, 22, 'Castillonroy'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3382, 22, 'Chalamera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3383, 22, 'Chía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3384, 22, 'Chimillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3385, 22, 'Colungo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3386, 22, 'Esplús'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3387, 22, 'Estada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3388, 22, 'Estadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3389, 22, 'Estopiñán del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3390, 22, 'Fago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3391, 22, 'Fanlo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3392, 22, 'Fiscal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3393, 22, 'Fonz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3394, 22, 'Foradada del Toscar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3419, 22, 'Laspaúles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3420, 22, 'Laspuña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3421, 22, 'Loarre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3422, 22, 'Loporzano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3423, 22, 'Loscorrales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3424, 22, 'Lupiñén-Ortilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3425, 22, 'Monesma y Cajigar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3426, 22, 'Monflorite-Lascasas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3427, 22, 'Montanuy'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3428, 22, 'Monzón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3429, 22, 'Naval'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3430, 22, 'Novales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3431, 22, 'Nueno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3432, 22, 'Olvena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3433, 22, 'Ontiñena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3434, 22, 'Osso de Cinca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3435, 22, 'Palo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3436, 22, 'Panticosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3437, 22, 'Peñalba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3476, 22, 'Sesué'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3457, 22, 'Sahún'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3458, 22, 'Salas Altas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3459, 22, 'Salas Bajas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3460, 22, 'Salillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3461, 22, 'Sallent de Gállego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3462, 22, 'San Esteban de Litera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3463, 22, 'San Juan de Plan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3464, 22, 'San Miguel del Cinca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3465, 22, 'Sangarrén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3466, 22, 'Santa Cilia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3467, 22, 'Santa Cruz de la Serós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3468, 22, 'Santa María de Dulcis'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3469, 22, 'Santaliestra y San Quílez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3470, 22, 'Sariñena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3471, 22, 'Secastilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3472, 22, 'Seira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3473, 22, 'Sena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3474, 22, 'Senés de Alcubierre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3475, 22, 'Sesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3438, 22, 'Peñas de Riglos (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3439, 22, 'Peralta de Alcofea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3440, 22, 'Peralta de Calasanz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3441, 22, 'Peraltilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3442, 22, 'Perarrúa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3443, 22, 'Pertusa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3444, 22, 'Piracés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3445, 22, 'Plan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3446, 22, 'Poleñino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3447, 22, 'Pozán de Vero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3448, 22, 'Puebla de Castro (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3449, 22, 'Puente de Montañana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3450, 22, 'Puente la Reina de Jaca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3451, 22, 'Puértolas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3452, 22, 'Pueyo de Araguás (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3453, 22, 'Pueyo de Santa Cruz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3454, 22, 'Quicena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3455, 22, 'Robres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3456, 22, 'Sabiñánigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3477, 22, 'Siétamo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3478, 22, 'Sopeira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3479, 22, 'Sotonera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3480, 22, 'Tamarite de Litera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3481, 22, 'Tardienta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3482, 22, 'Tella-Sin'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3483, 22, 'Tierz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3484, 22, 'Tolva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3485, 22, 'Torla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3486, 22, 'Torralba de Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3487, 22, 'Torre la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3488, 22, 'Torrente de Cinca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3489, 22, 'Torres de Alcanadre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3490, 22, 'Torres de Barbués'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3491, 22, 'Tramaced'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3492, 22, 'Valfarta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3493, 22, 'Valle de Bardají'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3494, 22, 'Valle de Hecho'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3495, 22, 'Valle de Lierp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3534, 23, 'Cazorla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3515, 23, 'Arroyo del Ojanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3516, 23, 'Baeza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3517, 23, 'Bailén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3518, 23, 'Baños de la Encina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3519, 23, 'Beas de Segura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3520, 23, 'Bedmar y Garcíez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3521, 23, 'Begíjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3522, 23, 'Bélmez de la Moraleda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3523, 23, 'Benatae'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3524, 23, 'Cabra del Santo Cristo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3525, 23, 'Cambil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3526, 23, 'Campillo de Arenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3527, 23, 'Canena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3528, 23, 'Carboneros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3529, 23, 'Cárcheles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3530, 23, 'Carolina (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3531, 23, 'Castellar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3532, 23, 'Castillo de Locubín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3533, 23, 'Cazalilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3496, 22, 'Velilla de Cinca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3497, 22, 'Vencillón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3498, 22, 'Veracruz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3499, 22, 'Viacamp y Litera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3500, 22, 'Vicién'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3501, 22, 'Villanova'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3502, 22, 'Villanúa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3503, 22, 'Villanueva de Sigena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3504, 22, 'Yebra de Basa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3505, 22, 'Yésero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3506, 22, 'Zaidín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3507, 23, 'Albanchez de Mágina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3508, 23, 'Alcalá la Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3509, 23, 'Alcaudete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3510, 23, 'Aldeaquemada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3511, 23, 'Andújar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3512, 23, 'Arjona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3513, 23, 'Arjonilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3514, 23, 'Arquillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3535, 23, 'Chiclana de Segura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3536, 23, 'Chilluévar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3537, 23, 'Escañuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3538, 23, 'Espelúy'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3539, 23, 'Frailes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3540, 23, 'Fuensanta de Martos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3541, 23, 'Fuerte del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3542, 23, 'Génave'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3543, 23, 'Guardia de Jaén (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3544, 23, 'Guarromán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3545, 23, 'Higuera de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3546, 23, 'Hinojares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3547, 23, 'Hornos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3548, 23, 'Huelma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3549, 23, 'Huesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3550, 23, 'Ibros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3551, 23, 'Iruela (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3552, 23, 'Iznatoraf'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3553, 23, 'Jabalquinto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3591, 23, 'Torreperogil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3592, 23, 'Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3593, 23, 'Torres de Albánchez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3594, 23, 'Úbeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3573, 23, 'Porcuna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3574, 23, 'Pozo Alcón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3575, 23, 'Puente de Génave'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3576, 23, 'Puerta de Segura (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3577, 23, 'Quesada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3578, 23, 'Rus'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3579, 23, 'Sabiote'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3580, 23, 'Santa Elena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3581, 23, 'Santiago de Calatrava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3582, 23, 'Santiago-Pontones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3583, 23, 'Santisteban del Puerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3584, 23, 'Santo Tomé'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3585, 23, 'Segura de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3586, 23, 'Siles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3587, 23, 'Sorihuela del Guadalimar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3588, 23, 'Torre del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3589, 23, 'Torreblascopedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3590, 23, 'Torredonjimeno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3554, 23, 'Jaén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3555, 23, 'Jamilena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3556, 23, 'Jimena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3557, 23, 'Jódar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3558, 23, 'Lahiguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3559, 23, 'Larva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3560, 23, 'Linares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3561, 23, 'Lopera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3562, 23, 'Lupión'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3563, 23, 'Mancha Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3564, 23, 'Marmolejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3565, 23, 'Martos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3566, 23, 'Mengíbar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3567, 23, 'Montizón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3568, 23, 'Navas de San Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3569, 23, 'Noalejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3570, 23, 'Orcera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3571, 23, 'Peal de Becerro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3572, 23, 'Pegalajar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3595, 23, 'Valdepeñas de Jaén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3596, 23, 'Vilches'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3597, 23, 'Villacarrillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3598, 23, 'Villanueva de la Reina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3599, 23, 'Villanueva del Arzobispo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3600, 23, 'Villardompardo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3601, 23, 'Villares (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3602, 23, 'Villarrodrigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3603, 23, 'Villatorres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3604, 24, 'Acebedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3605, 24, 'Algadefe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3606, 24, 'Alija del Infantado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3607, 24, 'Almanza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3608, 24, 'Antigua (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3609, 24, 'Ardón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3610, 24, 'Arganza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3611, 24, 'Astorga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3612, 24, 'Balboa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3613, 24, 'Bañeza (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3633, 24, 'Calzada del Coto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3634, 24, 'Campazas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3635, 24, 'Campo de Villavidel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3636, 24, 'Camponaraya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3637, 24, 'Candín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3638, 24, 'Cármenes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3639, 24, 'Carracedelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3640, 24, 'Carrizo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3641, 24, 'Carrocera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3642, 24, 'Carucedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3643, 24, 'Castilfalé'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3644, 24, 'Castrillo de Cabrera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3645, 24, 'Castrillo de la Valduerna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3646, 24, 'Castrocalbón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3647, 24, 'Castrocontrigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3648, 24, 'Castropodame'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3649, 24, 'Castrotierra de Valmadrigal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3650, 24, 'Cea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3651, 24, 'Cebanico'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3614, 24, 'Barjas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3615, 24, 'Barrios de Luna (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3616, 24, 'Bembibre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3617, 24, 'Benavides'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3618, 24, 'Benuza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3619, 24, 'Bercianos del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3620, 24, 'Bercianos del Real Camino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3621, 24, 'Berlanga del Bierzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3622, 24, 'Boca de Huérgano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3623, 24, 'Boñar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3624, 24, 'Borrenes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3625, 24, 'Brazuelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3626, 24, 'Burgo Ranero (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3627, 24, 'Burón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3628, 24, 'Bustillo del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3629, 24, 'Cabañas Raras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3630, 24, 'Cabreros del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3631, 24, 'Cabrillanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3632, 24, 'Cacabelos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3652, 24, 'Cebrones del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3653, 24, 'Chozas de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3654, 24, 'Cimanes de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3655, 24, 'Cimanes del Tejar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3656, 24, 'Cistierna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3657, 24, 'Congosto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3658, 24, 'Corbillos de los Oteros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3659, 24, 'Corullón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3660, 24, 'Crémenes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3661, 24, 'Cuadros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3662, 24, 'Cubillas de los Oteros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3663, 24, 'Cubillas de Rueda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3664, 24, 'Cubillos del Sil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3665, 24, 'Destriana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3666, 24, 'Encinedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3667, 24, 'Ercina (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3668, 24, 'Escobar de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3669, 24, 'Fabero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3706, 24, 'Páramo del Sil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3688, 24, 'Luyego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3689, 24, 'Magaz de Cepeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3690, 24, 'Mansilla de las Mulas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3691, 24, 'Mansilla Mayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3692, 24, 'Maraña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3693, 24, 'Matadeón de los Oteros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3694, 24, 'Matallana de Torío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3695, 24, 'Matanza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3696, 24, 'Molinaseca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3697, 24, 'Murias de Paredes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3698, 24, 'Noceda del Bierzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3699, 24, 'Oencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3700, 24, 'Omañas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3701, 24, 'Onzonilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3702, 24, 'Oseja de Sajambre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3703, 24, 'Pajares de los Oteros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3704, 24, 'Palacios de la Valduerna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3705, 24, 'Palacios del Sil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3670, 24, 'Folgoso de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3671, 24, 'Fresno de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3672, 24, 'Fuentes de Carbajal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3673, 24, 'Garrafe de Torío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3674, 24, 'Gordaliza del Pino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3675, 24, 'Gordoncillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3676, 24, 'Gradefes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3677, 24, 'Grajal de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3678, 24, 'Gusendos de los Oteros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3679, 24, 'Hospital de Órbigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3680, 24, 'Igüeña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3681, 24, 'Izagre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3682, 24, 'Joarilla de las Matas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3683, 24, 'Laguna Dalga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3684, 24, 'Laguna de Negrillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3685, 24, 'León'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3686, 24, 'Llamas de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3687, 24, 'Lucillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3707, 24, 'Peranzanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3708, 24, 'Pobladura de Pelayo García'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3709, 24, 'Pola de Gordón (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3710, 24, 'Ponferrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3711, 24, 'Posada de Valdeón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3712, 24, 'Pozuelo del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3713, 24, 'Prado de la Guzpeña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3714, 24, 'Priaranza del Bierzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3715, 24, 'Prioro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3716, 24, 'Puebla de Lillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3717, 24, 'Puente de Domingo Flórez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3718, 24, 'Quintana del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3719, 24, 'Quintana del Marco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3720, 24, 'Quintana y Congosto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3721, 24, 'Regueras de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3722, 24, 'Reyero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3723, 24, 'Riaño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3724, 24, 'Riego de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3743, 24, 'Santa Elena de Jamuz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3744, 24, 'Santa María de la Isla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3745, 24, 'Santa María de Ordás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3746, 24, 'Santa María del Monte de Cea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3747, 24, 'Santa María del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3748, 24, 'Santa Marina del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3749, 24, 'Santas Martas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3750, 24, 'Santiago Millas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3751, 24, 'Santovenia de la Valdoncina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3752, 24, 'Sariegos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3753, 24, 'Sena de Luna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3754, 24, 'Sobrado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3755, 24, 'Soto de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3756, 24, 'Soto y Amío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3725, 24, 'Riello'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3726, 24, 'Rioseco de Tapia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3727, 24, 'Robla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3728, 24, 'Roperuelos del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3729, 24, 'Sabero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3730, 24, 'Sahagún'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3731, 24, 'San Adrián del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3732, 24, 'San Andrés del Rabanedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3733, 24, 'San Cristóbal de la Polantera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3734, 24, 'San Emiliano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3735, 24, 'San Esteban de Nogales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3736, 24, 'San Justo de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3737, 24, 'San Millán de los Caballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3738, 24, 'San Pedro Bercianos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3739, 24, 'Sancedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3740, 24, 'Santa Colomba de Curueño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3741, 24, 'Santa Colomba de Somoza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3742, 24, 'Santa Cristina de Valmadrigal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3757, 24, 'Toral de los Guzmanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3758, 24, 'Toreno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3759, 24, 'Torre del Bierzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3760, 24, 'Trabadelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3761, 24, 'Truchas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3762, 24, 'Turcia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3763, 24, 'Urdiales del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3764, 24, 'Val de San Lorenzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3765, 24, 'Valdefresno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3766, 24, 'Valdefuentes del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3767, 24, 'Valdelugueros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3768, 24, 'Valdemora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3769, 24, 'Valdepiélago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3770, 24, 'Valdepolo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3771, 24, 'Valderas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3772, 24, 'Valderrey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3773, 24, 'Valderrueda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3774, 24, 'Valdesamario'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3775, 24, 'Valdevimbre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3794, 24, 'Villamandos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3795, 24, 'Villamanín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3796, 24, 'Villamañán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3797, 24, 'Villamartín de Don Sancho'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3798, 24, 'Villamejil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3799, 24, 'Villamol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3800, 24, 'Villamontán de la Valduerna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3801, 24, 'Villamoratiel de las Matas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3802, 24, 'Villanueva de las Manzanas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3803, 24, 'Villaobispo de Otero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3804, 24, 'Villaornate y Castro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3805, 24, 'Villaquejida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3806, 24, 'Villaquilambre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3807, 24, 'Villarejo de Órbigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3808, 24, 'Villares de Órbigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3809, 24, 'Villasabariego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3810, 24, 'Villaselán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3776, 24, 'Valencia de Don Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3777, 24, 'Vallecillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3778, 24, 'Valverde de la Virgen'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3779, 24, 'Valverde-Enrique'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3780, 24, 'Vecilla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3781, 24, 'Vega de Espinareda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3782, 24, 'Vega de Infanzones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3783, 24, 'Vega de Valcarce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3784, 24, 'Vegacervera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3785, 24, 'Vegaquemada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3786, 24, 'Vegas del Condado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3787, 24, 'Villablino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3788, 24, 'Villabraz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3789, 24, 'Villadangos del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3790, 24, 'Villadecanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3791, 24, 'Villademor de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3792, 24, 'Villafranca del Bierzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3793, 24, 'Villagatón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3811, 24, 'Villaturiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3812, 24, 'Villazala'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3813, 24, 'Villazanzo de Valderaduey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3814, 24, 'Zotes del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3815, 25, 'Abella de la Conca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3816, 25, 'Àger'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3817, 25, 'Agramunt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3818, 25, 'Aitona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3819, 25, 'Alamús (Els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3820, 25, 'Alàs i Cerc'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3821, 25, 'Albagés (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3822, 25, 'Albatàrrec'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3823, 25, 'Albesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3824, 25, 'Albi (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3825, 25, 'Alcanó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3826, 25, 'Alcarràs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3827, 25, 'Alcoletge'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3828, 25, 'Alfarràs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3829, 25, 'Alfés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3868, 25, 'Cabó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3849, 25, 'Barbens'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3850, 25, 'Baronia de Rialb (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3851, 25, 'Bassella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3852, 25, 'Bausen'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3853, 25, 'Belianes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3854, 25, 'Bellaguarda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3855, 25, 'Bellcaire d''Urgell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3856, 25, 'Bell-lloc d''Urgell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3857, 25, 'Bellmunt d''Urgell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3858, 25, 'Bellpuig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3859, 25, 'Bellver de Cerdanya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3860, 25, 'Bellvís'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3861, 25, 'Benavent de Segrià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3862, 25, 'Biosca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3863, 25, 'Bòrdes (Es)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3864, 25, 'Borges Blanques (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3865, 25, 'Bossòst'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3866, 25, 'Bovera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3867, 25, 'Cabanabona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3830, 25, 'Algerri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3831, 25, 'Alguaire'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3832, 25, 'Alins'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3833, 25, 'Almacelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3834, 25, 'Almatret'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3835, 25, 'Almenar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3836, 25, 'Alós de Balaguer');
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (3837, 25, 'Alpicat'); 
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3838, 25, 'Alt Àneu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3839, 25, 'Anglesola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3840, 25, 'Arbeca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3841, 25, 'Arres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3842, 25, 'Arsèguel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3843, 25, 'Artesa de Lleida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3844, 25, 'Artesa de Segre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3845, 25, 'Aspa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3846, 25, 'Avellanes i Santa Linya (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3847, 25, 'Baix Pallars'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3848, 25, 'Balaguer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3869, 25, 'Camarasa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3870, 25, 'Canejan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3871, 25, 'Castell de Mur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3872, 25, 'Castellar de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3873, 25, 'Castelldans'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3874, 25, 'Castellnou de Seana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3875, 25, 'Castelló de Farfanya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3876, 25, 'Castellserà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3877, 25, 'Cava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3878, 25, 'Cervera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3879, 25, 'Cervià de les Garrigues'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3880, 25, 'Ciutadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3881, 25, 'Clariana de Cardener'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3882, 25, 'Cogul (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3883, 25, 'Coll de Nargó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3884, 25, 'Coma i la Pedra (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3885, 25, 'Conca de Dalt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3886, 25, 'Corbins'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3887, 25, 'Cubells'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3907, 25, 'Granyanella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3908, 25, 'Granyena de les Garrigues'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3909, 25, 'Granyena de Segarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3910, 25, 'Guimerà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3911, 25, 'Guingueta d''Àneu (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3912, 25, 'Guissona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3913, 25, 'Guixers'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3914, 25, 'Isona i Conca Dellà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3915, 25, 'Ivars de Noguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3916, 25, 'Ivars d''Urgell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3917, 25, 'Ivorra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3918, 25, 'Josa i Tuixén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3919, 25, 'Juncosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3920, 25, 'Juneda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3921, 25, 'Les'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3922, 25, 'Linyola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3923, 25, 'Lladorre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3924, 25, 'Lladurs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3925, 25, 'Llardecans'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3888, 25, 'Espluga Calba (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3889, 25, 'Espot'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3890, 25, 'Estamariu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3891, 25, 'Estaràs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3892, 25, 'Esterri d''Àneu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3893, 25, 'Esterri de Cardós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3894, 25, 'Farrera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3895, 25, 'Fígols i Alinyà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3896, 25, 'Floresta (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3897, 25, 'Fondarella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3898, 25, 'Foradada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3899, 25, 'Fuliola (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3900, 25, 'Fulleda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3901, 25, 'Gavet de la Conca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3902, 25, 'Gimenells i el Pla de la Font'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3903, 25, 'Golmés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3904, 25, 'Gósol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3905, 25, 'Granadella (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3906, 25, 'Granja d''Escarp (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3926, 25, 'Llavorsí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3927, 25, 'Lleida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3928, 25, 'Lles de Cerdanya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3929, 25, 'Llimiana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3930, 25, 'Llobera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3931, 25, 'Maials'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3932, 25, 'Maldà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3933, 25, 'Massalcoreig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3934, 25, 'Massoteres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3935, 25, 'Menàrguens'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3936, 25, 'Miralcamp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3937, 25, 'Mollerussa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3938, 25, 'Molsosa (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3939, 25, 'Montellà i Martinet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3940, 25, 'Montferrer i Castellbò'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3941, 25, 'Montgai'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3942, 25, 'Montoliu de Lleida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3943, 25, 'Montoliu de Segarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3944, 25, 'Montornès de Segarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3983, 25, 'Rosselló'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3964, 25, 'Poal (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3965, 25, 'Pobla de Cérvoles (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3966, 25, 'Pobla de Segur (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3967, 25, 'Pont de Bar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3968, 25, 'Pont de Suert (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3969, 25, 'Ponts'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3970, 25, 'Portella (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3971, 25, 'Prats i Sansor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3972, 25, 'Preixana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3973, 25, 'Preixens'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3974, 25, 'Prullans'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3975, 25, 'Puiggròs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3976, 25, 'Puigverd d''Agramunt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3977, 25, 'Puigverd de Lleida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3978, 25, 'Rialp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3979, 25, 'Ribera d''Ondara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3980, 25, 'Ribera d''Urgellet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3981, 25, 'Riner'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3982, 25, 'Riu de Cerdanya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3945, 25, 'Nalec'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3946, 25, 'Naut Aran'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3947, 25, 'Navès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3948, 25, 'Odèn'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3949, 25, 'Oliana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3950, 25, 'Oliola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3951, 25, 'Olius'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3952, 25, 'Oluges (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3953, 25, 'Omellons (Els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3954, 25, 'Omells de na Gaia (Els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3955, 25, 'Organyà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3956, 25, 'Os de Balaguer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3957, 25, 'Ossó de Sió'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3958, 25, 'Palau d''Anglesola (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3959, 25, 'Penelles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3960, 25, 'Peramola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3961, 25, 'Pinell de Solsonès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3962, 25, 'Pinós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3963, 25, 'Plans de Sió (Els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3984, 25, 'Salàs de Pallars'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3985, 25, 'Sanaüja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3986, 25, 'Sant Esteve de la Sarga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3987, 25, 'Sant Guim de Freixenet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3988, 25, 'Sant Guim de la Plana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3989, 25, 'Sant Llorenç de Morunys'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3990, 25, 'Sant Martí de Riucorb'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3991, 25, 'Sant Ramon'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3992, 25, 'Sarroca de Bellera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3993, 25, 'Sarroca de Lleida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3994, 25, 'Senterada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3995, 25, 'Sentiu de Sió (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3996, 25, 'Seròs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3997, 25, 'Seu d''Urgell (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3998, 25, 'Sidamon'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(3999, 25, 'Soleràs (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4000, 25, 'Solsona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4001, 25, 'Soriguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4039, 25, 'Vilanova de la Barca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4021, 25, 'Torregrossa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4022, 25, 'Torrelameu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4023, 25, 'Torres de Segre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4024, 25, 'Torre-serona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4025, 25, 'Tremp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4026, 25, 'Vall de Boí (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4027, 25, 'Vall de Cardós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4028, 25, 'Vallbona de les Monges'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4029, 25, 'Vallfogona de Balaguer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4030, 25, 'Valls d''Aguilar (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4031, 25, 'Valls de Valira (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4032, 25, 'Vansa i Fórnols (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4033, 25, 'Verdú'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4034, 25, 'Vielha e Mijaran'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4035, 25, 'Vilagrassa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4036, 25, 'Vilaller'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4037, 25, 'Vilamòs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4038, 25, 'Vilanova de Bellpuig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4002, 25, 'Sort'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4003, 25, 'Soses'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4004, 25, 'Sudanell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4005, 25, 'Sunyer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4006, 25, 'Talarn'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4007, 25, 'Talavera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4008, 25, 'Tàrrega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4009, 25, 'Tarrés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4010, 25, 'Tarroja de Segarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4011, 25, 'Térmens'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4012, 25, 'Tírvia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4013, 25, 'Tiurana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4014, 25, 'Torà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4015, 25, 'Torms (Els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4016, 25, 'Tornabous'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4017, 25, 'Torre de Cabdella (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4018, 25, 'Torrebesses'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4019, 25, 'Torrefarrera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4020, 25, 'Torrefeta i Florejacs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4040, 25, 'Vilanova de l''Aguda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4041, 25, 'Vilanova de Meià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4042, 25, 'Vilanova de Segrià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4043, 25, 'Vila-sana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4044, 25, 'Vilosell (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4045, 25, 'Vinaixa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4046, 26, 'Ábalos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4047, 26, 'Agoncillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4048, 26, 'Aguilar del Río Alhama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4049, 26, 'Ajamil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4050, 26, 'Albelda de Iregua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4051, 26, 'Alberite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4052, 26, 'Alcanadre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4053, 26, 'Aldeanueva de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4054, 26, 'Alesanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4055, 26, 'Alesón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4056, 26, 'Alfaro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4057, 26, 'Almarza de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4058, 26, 'Anguciana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4097, 26, 'Cordovín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4098, 26, 'Corera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4099, 26, 'Cornago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4078, 26, 'Briñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4079, 26, 'Briones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4080, 26, 'Cabezón de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4081, 26, 'Calahorra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4082, 26, 'Camprovín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4083, 26, 'Canales de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4084, 26, 'Canillas de Río Tuerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4085, 26, 'Cañas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4086, 26, 'Cárdenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4087, 26, 'Casalarreina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4088, 26, 'Castañares de Rioja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4089, 26, 'Castroviejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4090, 26, 'Cellorigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4091, 26, 'Cenicero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4092, 26, 'Cervera del Río Alhama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4093, 26, 'Cidamón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4094, 26, 'Cihuri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4095, 26, 'Cirueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4096, 26, 'Clavijo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4059, 26, 'Anguiano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4060, 26, 'Arenzana de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4061, 26, 'Arenzana de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4062, 26, 'Arnedillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4063, 26, 'Arnedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4064, 26, 'Arrúbal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4065, 26, 'Ausejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4066, 26, 'Autol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4067, 26, 'Azofra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4068, 26, 'Badarán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4069, 26, 'Bañares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4070, 26, 'Baños de Río Tobía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4071, 26, 'Baños de Rioja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4072, 26, 'Berceo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4073, 26, 'Bergasa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4074, 26, 'Bergasillas Bajera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4075, 26, 'Bezares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4076, 26, 'Bobadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4077, 26, 'Brieva de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4100, 26, 'Corporales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4101, 26, 'Cuzcurrita de Río Tirón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4102, 26, 'Daroca de Rioja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4103, 26, 'Enciso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4104, 26, 'Entrena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4105, 26, 'Estollo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4106, 26, 'Ezcaray'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4107, 26, 'Foncea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4108, 26, 'Fonzaleche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4109, 26, 'Fuenmayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4110, 26, 'Galbárruli'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4111, 26, 'Galilea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4112, 26, 'Gallinero de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4113, 26, 'Gimileo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4114, 26, 'Grañón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4115, 26, 'Grávalos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4116, 26, 'Haro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4117, 26, 'Herce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4118, 26, 'Herramélluri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4157, 26, 'Pinillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4158, 26, 'Pradejón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4159, 26, 'Pradillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4138, 26, 'Matute'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4139, 26, 'Medrano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4140, 26, 'Munilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4141, 26, 'Murillo de Río Leza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4142, 26, 'Muro de Aguas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4143, 26, 'Muro en Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4144, 26, 'Nájera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4145, 26, 'Nalda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4146, 26, 'Navajún'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4147, 26, 'Navarrete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4148, 26, 'Nestares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4149, 26, 'Nieva de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4150, 26, 'Ochánduri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4151, 26, 'Ocón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4152, 26, 'Ojacastro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4153, 26, 'Ollauri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4154, 26, 'Ortigosa de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4155, 26, 'Pazuengos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4156, 26, 'Pedroso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4119, 26, 'Hervías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4120, 26, 'Hormilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4121, 26, 'Hormilleja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4122, 26, 'Hornillos de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4123, 26, 'Hornos de Moncalvillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4124, 26, 'Huércanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4125, 26, 'Igea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4126, 26, 'Jalón de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4127, 26, 'Laguna de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4128, 26, 'Lagunilla del Jubera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4129, 26, 'Lardero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4130, 26, 'Ledesma de la Cogolla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4131, 26, 'Leiva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4132, 26, 'Leza de Río Leza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4133, 26, 'Logroño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4134, 26, 'Lumbreras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4135, 26, 'Manjarrés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4136, 26, 'Mansilla de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4137, 26, 'Manzanares de Rioja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4160, 26, 'Préjano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4161, 26, 'Quel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4162, 26, 'Rabanera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4163, 26, 'Rasillo de Cameros (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4164, 26, 'Redal (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4165, 26, 'Ribafrecha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4166, 26, 'Rincón de Soto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4167, 26, 'Robres del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4168, 26, 'Rodezno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4169, 26, 'Sajazarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4170, 26, 'San Asensio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4171, 26, 'San Millán de la Cogolla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4172, 26, 'San Millán de Yécora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4173, 26, 'San Román de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4174, 26, 'San Torcuato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4175, 26, 'San Vicente de la Sonsierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4176, 26, 'Santa Coloma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4177, 26, 'Santa Engracia del Jubera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4197, 26, 'Uruñuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4198, 26, 'Valdemadera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4199, 26, 'Valgañón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4200, 26, 'Ventosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4201, 26, 'Ventrosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4202, 26, 'Viguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4203, 26, 'Villalba de Rioja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4204, 26, 'Villalobar de Rioja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4205, 26, 'Villamediana de Iregua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4206, 26, 'Villanueva de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4207, 26, 'Villar de Arnedo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4208, 26, 'Villar de Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4209, 26, 'Villarejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4210, 26, 'Villarroya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4211, 26, 'Villarta-Quintana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4212, 26, 'Villavelayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4213, 26, 'Villaverde de Rioja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4214, 26, 'Villoslada de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4178, 26, 'Santa Eulalia Bajera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4179, 26, 'Santo Domingo de la Calzada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4180, 26, 'Santurde de Rioja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4181, 26, 'Santurdejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4182, 26, 'Sojuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4183, 26, 'Sorzano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4184, 26, 'Sotés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4185, 26, 'Soto en Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4186, 26, 'Terroba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4187, 26, 'Tirgo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4188, 26, 'Tobía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4189, 26, 'Tormantos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4190, 26, 'Torre en Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4191, 26, 'Torrecilla en Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4192, 26, 'Torrecilla sobre Alesanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4193, 26, 'Torremontalbo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4194, 26, 'Treviana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4195, 26, 'Tricio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4196, 26, 'Tudelilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4215, 26, 'Viniegra de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4216, 26, 'Viniegra de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4217, 26, 'Zarratón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4218, 26, 'Zarzosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4219, 26, 'Zorraquín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4220, 27, 'Abadín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4221, 27, 'Alfoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4222, 27, 'Antas de Ulla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4223, 27, 'Baleira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4224, 27, 'Baralla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4225, 27, 'Barreiros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4226, 27, 'Becerreá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4227, 27, 'Begonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4228, 27, 'Bóveda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4229, 27, 'Burela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4230, 27, 'Carballedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4231, 27, 'Castro de Rei'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4232, 27, 'Castroverde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4233, 27, 'Cervantes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4272, 27, 'Ribeira de Piquín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4273, 27, 'Riotorto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4274, 27, 'Samos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4275, 27, 'Sarria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4276, 27, 'Saviñao (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4253, 27, 'Navia de Suarna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4254, 27, 'Negueira de Muñiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4255, 27, 'Nogais (As)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4256, 27, 'Ourol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4257, 27, 'Outeiro de Rei'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4258, 27, 'Palas de Rei'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4259, 27, 'Pantón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4260, 27, 'Paradela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4261, 27, 'Páramo (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4262, 27, 'Pastoriza (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4263, 27, 'Pedrafita do Cebreiro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4264, 27, 'Pobra do Brollón (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4265, 27, 'Pol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4266, 27, 'Pontenova (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4267, 27, 'Portomarín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4268, 27, 'Quiroga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4269, 27, 'Rábade'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4270, 27, 'Ribadeo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4271, 27, 'Ribas de Sil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4234, 27, 'Cervo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4235, 27, 'Chantada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4236, 27, 'Corgo (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4237, 27, 'Cospeito'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4238, 27, 'Folgoso do Courel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4239, 27, 'Fonsagrada (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4240, 27, 'Foz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4241, 27, 'Friol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4242, 27, 'Guitiriz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4243, 27, 'Guntín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4244, 27, 'Incio (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4245, 27, 'Láncara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4246, 27, 'Lourenzá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4247, 27, 'Lugo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4248, 27, 'Meira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4249, 27, 'Mondoñedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4250, 27, 'Monforte de Lemos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4251, 27, 'Monterroso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4252, 27, 'Muras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4277, 27, 'Sober'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4278, 27, 'Taboada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4279, 27, 'Trabada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4280, 27, 'Triacastela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4281, 27, 'Valadouro (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4282, 27, 'Vicedo (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4283, 27, 'Vilalba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4284, 27, 'Viveiro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4285, 27, 'Xermade'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4286, 27, 'Xove'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4287, 28, 'Acebeda (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4288, 28, 'Ajalvir'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4289, 28, 'Alameda del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4290, 28, 'Álamo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4291, 28, 'Alcalá de Henares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4292, 28, 'Alcobendas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4293, 28, 'Alcorcón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4294, 28, 'Aldea del Fresno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4295, 28, 'Algete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4333, 28, 'Colmenar del Arroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4334, 28, 'Colmenar Viejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4315, 28, 'Cabanillas de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4316, 28, 'Cabrera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4317, 28, 'Cadalso de los Vidrios'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4318, 28, 'Camarma de Esteruelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4319, 28, 'Campo Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4320, 28, 'Canencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4321, 28, 'Carabaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4322, 28, 'Casarrubuelos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4323, 28, 'Cenicientos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4324, 28, 'Cercedilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4325, 28, 'Cervera de Buitrago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4326, 28, 'Chapinería'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4327, 28, 'Chinchón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4328, 28, 'Ciempozuelos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4329, 28, 'Cobeña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4330, 28, 'Collado Mediano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4331, 28, 'Collado Villalba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4332, 28, 'Colmenar de Oreja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4296, 28, 'Alpedrete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4297, 28, 'Ambite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4298, 28, 'Anchuelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4299, 28, 'Aranjuez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4300, 28, 'Arganda del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4301, 28, 'Arroyomolinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4302, 28, 'Atazar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4303, 28, 'Batres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4304, 28, 'Becerril de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4305, 28, 'Belmonte de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4306, 28, 'Berrueco (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4307, 28, 'Berzosa del Lozoya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4308, 28, 'Boadilla del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4309, 28, 'Boalo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4310, 28, 'Braojos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4311, 28, 'Brea de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4312, 28, 'Brunete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4313, 28, 'Buitrago del Lozoya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4314, 28, 'Bustarviejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4335, 28, 'Colmenarejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4336, 28, 'Corpa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4337, 28, 'Coslada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4338, 28, 'Cubas de la Sagra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4339, 28, 'Daganzo de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4340, 28, 'Escorial (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4341, 28, 'Estremera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4342, 28, 'Fresnedillas de la Oliva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4343, 28, 'Fresno de Torote'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4344, 28, 'Fuenlabrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4345, 28, 'Fuente el Saz de Jarama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4346, 28, 'Fuentidueña de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4347, 28, 'Galapagar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4348, 28, 'Garganta de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4349, 28, 'Gargantilla del Lozoya y Pinilla de Buitrago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4350, 28, 'Gascones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4351, 28, 'Getafe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4352, 28, 'Griñón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4371, 28, 'Molar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4372, 28, 'Molinos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4373, 28, 'Montejo de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4374, 28, 'Moraleja de Enmedio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4375, 28, 'Moralzarzal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4376, 28, 'Morata de Tajuña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4377, 28, 'Móstoles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4378, 28, 'Navacerrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4379, 28, 'Navalafuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4380, 28, 'Navalagamella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4381, 28, 'Navalcarnero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4382, 28, 'Navarredonda y San Mamés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4383, 28, 'Navas del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4384, 28, 'Nuevo Baztán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4385, 28, 'Olmeda de las Fuentes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4386, 28, 'Orusco de Tajuña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4387, 28, 'Paracuellos de Jarama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4388, 28, 'Parla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4353, 28, 'Guadalix de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4354, 28, 'Guadarrama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4355, 28, 'Hiruela (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4356, 28, 'Horcajo de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4357, 28, 'Horcajuelo de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4358, 28, 'Hoyo de Manzanares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4359, 28, 'Humanes de Madrid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4360, 28, 'Leganés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4361, 28, 'Loeches'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4362, 28, 'Lozoya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4363, 28, 'Lozoyuela-Navas-Sieteiglesias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4364, 28, 'Madarcos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4365, 28, 'Madrid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4366, 28, 'Majadahonda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4367, 28, 'Manzanares el Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4368, 28, 'Meco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4369, 28, 'Mejorada del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4370, 28, 'Miraflores de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4389, 28, 'Patones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4390, 28, 'Pedrezuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4391, 28, 'Pelayos de la Presa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4392, 28, 'Perales de Tajuña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4393, 28, 'Pezuela de las Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4394, 28, 'Pinilla del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4395, 28, 'Pinto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4396, 28, 'Piñuécar-Gandullas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4397, 28, 'Pozuelo de Alarcón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4398, 28, 'Pozuelo del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4399, 28, 'Prádena del Rincón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4400, 28, 'Puebla de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4401, 28, 'Puentes Viejas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4402, 28, 'Quijorna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4403, 28, 'Rascafría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4404, 28, 'Redueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4405, 28, 'Ribatejada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4406, 28, 'Rivas-Vaciamadrid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4424, 28, 'Somosierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4425, 28, 'Soto del Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4426, 28, 'Talamanca de Jarama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4427, 28, 'Tielmes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4428, 28, 'Titulcia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4429, 28, 'Torrejón de Ardoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4430, 28, 'Torrejón de la Calzada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4431, 28, 'Torrejón de Velasco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4432, 28, 'Torrelaguna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4433, 28, 'Torrelodones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4434, 28, 'Torremocha de Jarama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4435, 28, 'Torres de la Alameda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4436, 28, 'Tres Cantos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4437, 28, 'Valdaracete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4438, 28, 'Valdeavero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4439, 28, 'Valdelaguna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4440, 28, 'Valdemanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4407, 28, 'Robledillo de la Jara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4408, 28, 'Robledo de Chavela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4409, 28, 'Robregordo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4410, 28, 'Rozas de Madrid (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4411, 28, 'Rozas de Puerto Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4412, 28, 'San Agustín del Guadalix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4413, 28, 'San Fernando de Henares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4414, 28, 'San Lorenzo de El Escorial'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4415, 28, 'San Martín de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4416, 28, 'San Martín de Valdeiglesias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4417, 28, 'San Sebastián de los Reyes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4418, 28, 'Santa María de la Alameda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4419, 28, 'Santorcaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4420, 28, 'Santos de la Humosa (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4421, 28, 'Serna del Monte (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4422, 28, 'Serranillos del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4423, 28, 'Sevilla la Nueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4441, 28, 'Valdemaqueda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4442, 28, 'Valdemorillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4443, 28, 'Valdemoro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4444, 28, 'Valdeolmos-Alalpardo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4445, 28, 'Valdepiélagos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4446, 28, 'Valdetorres de Jarama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4447, 28, 'Valdilecha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4448, 28, 'Valverde de Alcalá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4449, 28, 'Velilla de San Antonio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4450, 28, 'Vellón (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4451, 28, 'Venturada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4452, 28, 'Villa del Prado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4453, 28, 'Villaconejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4454, 28, 'Villalbilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4455, 28, 'Villamanrique de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4456, 28, 'Villamanta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4457, 28, 'Villamantilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4458, 28, 'Villanueva de la Cañada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4497, 29, 'Campillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4478, 29, 'Alozaina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4479, 29, 'Alpandeire'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4480, 29, 'Antequera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4481, 29, 'Árchez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4482, 29, 'Archidona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4483, 29, 'Ardales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4484, 29, 'Arenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4485, 29, 'Arriate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4486, 29, 'Atajate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4487, 29, 'Benadalid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4488, 29, 'Benahavís'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4489, 29, 'Benalauría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4490, 29, 'Benalmádena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4491, 29, 'Benamargosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4492, 29, 'Benamocarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4493, 29, 'Benaoján'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4494, 29, 'Benarrabá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4495, 29, 'Borge (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4496, 29, 'Burgo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4459, 28, 'Villanueva de Perales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4460, 28, 'Villanueva del Pardillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4461, 28, 'Villar del Olmo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4462, 28, 'Villarejo de Salvanés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4463, 28, 'Villaviciosa de Odón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4464, 28, 'Villavieja del Lozoya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4465, 28, 'Zarzalejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4466, 29, 'Alameda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4467, 29, 'Alcaucín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4468, 29, 'Alfarnate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4469, 29, 'Alfarnatejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4470, 29, 'Algarrobo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4471, 29, 'Algatocín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4472, 29, 'Alhaurín de la Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4473, 29, 'Alhaurín el Grande'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4474, 29, 'Almáchar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4475, 29, 'Almargen'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4476, 29, 'Almogía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4477, 29, 'Álora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4498, 29, 'Canillas de Aceituno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4499, 29, 'Canillas de Albaida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4500, 29, 'Cañete la Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4501, 29, 'Carratraca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4502, 29, 'Cartajima'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4503, 29, 'Cártama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4504, 29, 'Casabermeja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4505, 29, 'Casarabonela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4506, 29, 'Casares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4507, 29, 'Coín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4508, 29, 'Colmenar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4509, 29, 'Comares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4510, 29, 'Cómpeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4511, 29, 'Cortes de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4512, 29, 'Cuevas Bajas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4513, 29, 'Cuevas de San Marcos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4514, 29, 'Cuevas del Becerro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4515, 29, 'Cútar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4516, 29, 'Estepona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4555, 29, 'Torremolinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4556, 29, 'Torrox'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4557, 29, 'Totalán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4558, 29, 'Valle de Abdalajís'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4559, 29, 'Vélez-Málaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4536, 29, 'Moclinejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4537, 29, 'Mollina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4538, 29, 'Monda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4539, 29, 'Montejaque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4540, 29, 'Nerja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4541, 29, 'Ojén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4542, 29, 'Parauta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4543, 29, 'Periana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4544, 29, 'Pizarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4545, 29, 'Pujerra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4546, 29, 'Rincón de la Victoria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4547, 29, 'Riogordo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4548, 29, 'Ronda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4549, 29, 'Salares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4550, 29, 'Sayalonga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4551, 29, 'Sedella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4552, 29, 'Sierra de Yeguas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4553, 29, 'Teba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4554, 29, 'Tolox'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4517, 29, 'Faraján'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4518, 29, 'Frigiliana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4519, 29, 'Fuengirola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4520, 29, 'Fuente de Piedra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4521, 29, 'Gaucín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4522, 29, 'Genalguacil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4523, 29, 'Guaro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4524, 29, 'Humilladero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4525, 29, 'Igualeja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4526, 29, 'Istán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4527, 29, 'Iznate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4528, 29, 'Jimera de Líbar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4529, 29, 'Jubrique'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4530, 29, 'Júzcar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4531, 29, 'Macharaviaya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4532, 29, 'Málaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4533, 29, 'Manilva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4534, 29, 'Marbella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4535, 29, 'Mijas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4560, 29, 'Villanueva de Algaidas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4561, 29, 'Villanueva de Tapia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4562, 29, 'Villanueva del Rosario'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4563, 29, 'Villanueva del Trabuco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4564, 29, 'Viñuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4565, 29, 'Yunquera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4566, 30, 'Abanilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4567, 30, 'Abarán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4568, 30, 'Águilas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4569, 30, 'Albudeite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4570, 30, 'Alcantarilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4571, 30, 'Alcázares (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4572, 30, 'Aledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4573, 30, 'Alguazas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4574, 30, 'Alhama de Murcia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4575, 30, 'Archena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4576, 30, 'Beniel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4577, 30, 'Blanca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4578, 30, 'Bullas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4617, 31, 'Adiós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4618, 31, 'Aguilar de Codés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4619, 31, 'Aibar/Oibar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4598, 30, 'Pliego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4599, 30, 'Puerto Lumbreras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4600, 30, 'Ricote'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4601, 30, 'San Javier'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4602, 30, 'San Pedro del Pinatar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4603, 30, 'Santomera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4604, 30, 'Torre-Pacheco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4605, 30, 'Torres de Cotillas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4606, 30, 'Totana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4607, 30, 'Ulea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4608, 30, 'Unión (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4609, 30, 'Villanueva del Río Segura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4610, 30, 'Yecla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4611, 31, 'Abáigar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4612, 31, 'Abárzuza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4613, 31, 'Abaurregaina/Abaurrea Alta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4614, 31, 'Abaurrepea/Abaurrea Baja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4615, 31, 'Aberin'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4616, 31, 'Ablitas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4579, 30, 'Calasparra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4580, 30, 'Campos del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4581, 30, 'Caravaca de la Cruz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4582, 30, 'Cartagena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4583, 30, 'Cehegín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4584, 30, 'Ceutí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4585, 30, 'Cieza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4586, 30, 'Fortuna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4587, 30, 'Fuente Álamo de Murcia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4588, 30, 'Jumilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4589, 30, 'Librilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4590, 30, 'Lorca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4591, 30, 'Lorquí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4592, 30, 'Mazarrón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4593, 30, 'Molina de Segura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4594, 30, 'Moratalla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4595, 30, 'Mula'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4596, 30, 'Murcia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4597, 30, 'Ojós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4620, 31, 'Allín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4621, 31, 'Allo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4622, 31, 'Altsasu/Alsasua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4623, 31, 'Améscoa Baja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4624, 31, 'Ancín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4625, 31, 'Andosilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4626, 31, 'Ansoáin'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4627, 31, 'Anue'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4628, 31, 'Añorbe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4629, 31, 'Aoiz/Agoitz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4630, 31, 'Araitz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4631, 31, 'Arakil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4632, 31, 'Aranarache'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4633, 31, 'Aranguren'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4634, 31, 'Arano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4635, 31, 'Arantza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4636, 31, 'Aras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4637, 31, 'Arbizu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4638, 31, 'Arce/Artzi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4639, 31, 'Arcos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4679, 31, 'Cabanillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4680, 31, 'Cabredo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4681, 31, 'Cadreita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4682, 31, 'Caparroso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4683, 31, 'Cárcar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4684, 31, 'Carcastillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4660, 31, 'Barillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4661, 31, 'Basaburua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4662, 31, 'Baztan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4663, 31, 'Beintza-Labaien'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4664, 31, 'Beire'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4665, 31, 'Belascoáin'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4666, 31, 'Bera/Vera de Bidasoa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4667, 31, 'Berbinzana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4668, 31, 'Beriáin'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4669, 31, 'Berrioplano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4670, 31, 'Berriozar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4671, 31, 'Bertizarana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4672, 31, 'Betelu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4673, 31, 'Bidaurreta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4674, 31, 'Biurrun-Olcoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4675, 31, 'Buñuel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4676, 31, 'Burgui/Burgi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4677, 31, 'Burlada/Burlata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4678, 31, 'Busto (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4640, 31, 'Arellano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4641, 31, 'Areso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4642, 31, 'Arguedas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4643, 31, 'Aria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4644, 31, 'Aribe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4645, 31, 'Armañanzas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4646, 31, 'Arróniz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4647, 31, 'Arruazu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4648, 31, 'Artajona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4649, 31, 'Artazu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4650, 31, 'Atez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4651, 31, 'Auritz/Burguete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4652, 31, 'Ayegui'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4653, 31, 'Azagra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4654, 31, 'Azuelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4655, 31, 'Bakaiku'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4656, 31, 'Barañain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4657, 31, 'Barásoain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4658, 31, 'Barbarin'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4659, 31, 'Bargota'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4685, 31, 'Cascante'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4686, 31, 'Cáseda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4687, 31, 'Castejón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4688, 31, 'Castillonuevo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4689, 31, 'Cendea de Olza/Oltza Zendea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4690, 31, 'Cintruénigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4691, 31, 'Cirauqui'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4692, 31, 'Ciriza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4693, 31, 'Cizur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4694, 31, 'Corella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4695, 31, 'Cortes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4696, 31, 'Desojo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4697, 31, 'Dicastillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4698, 31, 'Donamaria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4699, 31, 'Doneztebe/Santesteban'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4700, 31, 'Echarri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4701, 31, 'Egüés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4702, 31, 'Elgorriaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4703, 31, 'Enériz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4742, 31, 'Igantzi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4743, 31, 'Igúzquiza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4744, 31, 'Imotz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4745, 31, 'Irañeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4746, 31, 'Irurtzun'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4723, 31, 'Fontellas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4724, 31, 'Funes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4725, 31, 'Fustiñana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4726, 31, 'Galar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4727, 31, 'Gallipienzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4728, 31, 'Gallués/Galoze'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4729, 31, 'Garaioa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4730, 31, 'Garde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4731, 31, 'Garínoain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4732, 31, 'Garralda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4733, 31, 'Genevilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4734, 31, 'Goizueta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4735, 31, 'Goñi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4736, 31, 'Güesa/Gorza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4737, 31, 'Guesálaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4738, 31, 'Guirguillano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4739, 31, 'Hiriberri/Villanueva de Aezkoa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4740, 31, 'Huarte/Uharte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4741, 31, 'Ibargoiti'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4704, 31, 'Eratsun'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4705, 31, 'Ergoiena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4706, 31, 'Erro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4707, 31, 'Eslava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4708, 31, 'Esparza de Salazar/Espartza Zaraitzu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4709, 31, 'Espronceda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4710, 31, 'Estella/Lizarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4711, 31, 'Esteribar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4712, 31, 'Etayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4713, 31, 'Etxalar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4714, 31, 'Etxarri-Aranatz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4715, 31, 'Etxauri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4716, 31, 'Eulate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4717, 31, 'Ezcabarte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4718, 31, 'Ezcároz/Ezkaroze'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4719, 31, 'Ezkurra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4720, 31, 'Ezprogui'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4721, 31, 'Falces'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4722, 31, 'Fitero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4747, 31, 'Isaba/Izaba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4748, 31, 'Ituren'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4749, 31, 'Iturmendi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4750, 31, 'Iza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4751, 31, 'Izagaondoa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4752, 31, 'Izalzu/Itzaltzu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4753, 31, 'Jaurrieta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4754, 31, 'Javier'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4755, 31, 'Juslapeña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4756, 31, 'Lakuntza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4757, 31, 'Lana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4758, 31, 'Lantz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4759, 31, 'Lapoblación'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4760, 31, 'Larraga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4761, 31, 'Larraona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4762, 31, 'Larraun'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4763, 31, 'Lazagurría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4764, 31, 'Leache'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4765, 31, 'Legarda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4805, 31, 'Ochagavía/Otsagabia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4806, 31, 'Oco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4807, 31, 'Odieta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4808, 31, 'Oitz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4809, 31, 'Olaibar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4810, 31, 'Olazti/Olazagutía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4786, 31, 'Mendaza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4787, 31, 'Mendigorría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4788, 31, 'Metauten'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4789, 31, 'Milagro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4790, 31, 'Mirafuentes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4791, 31, 'Miranda de Arga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4792, 31, 'Monreal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4793, 31, 'Monteagudo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4794, 31, 'Morentin'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4795, 31, 'Mues'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4796, 31, 'Murchante'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4797, 31, 'Murieta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4798, 31, 'Murillo el Cuende'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4799, 31, 'Murillo el Fruto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4800, 31, 'Muruzábal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4801, 31, 'Navascués'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4802, 31, 'Nazar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4803, 31, 'Noáin (Valle de Elorz)/Noain (Elortzibar)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4804, 31, 'Obanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4766, 31, 'Legaria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4767, 31, 'Leitza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4768, 31, 'Lekunberri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4769, 31, 'Leoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4770, 31, 'Lerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4771, 31, 'Lerín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4772, 31, 'Lesaka'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4773, 31, 'Lezáun'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4774, 31, 'Liédena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4775, 31, 'Lizoáin'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4776, 31, 'Lodosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4777, 31, 'Lónguida/Longida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4778, 31, 'Lumbier'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4779, 31, 'Luquin'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4780, 31, 'Luzaide/Valcarlos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4781, 31, 'Mañeru'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4782, 31, 'Marañón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4783, 31, 'Marcilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4784, 31, 'Mélida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4785, 31, 'Mendavia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4811, 31, 'Olejua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4812, 31, 'Olite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4813, 31, 'Ollo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4814, 31, 'Olóriz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4815, 31, 'Orbaitzeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4816, 31, 'Orbara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4817, 31, 'Orísoain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4818, 31, 'Orkoien'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4819, 31, 'Oronz/Orontze'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4820, 31, 'Oroz-Betelu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4821, 31, 'Orreaga/Roncesvalles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4822, 31, 'Oteiza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4823, 31, 'Pamplona/Iruña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4824, 31, 'Peralta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4825, 31, 'Petilla de Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4826, 31, 'Piedramillera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4827, 31, 'Pitillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4828, 31, 'Puente la Reina/Gares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4829, 31, 'Pueyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4868, 31, 'Valle de Yerri/Deierri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4869, 31, 'Valtierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4870, 31, 'Viana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4871, 31, 'Vidángoz/Bidankoze'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4849, 31, 'Torralba del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4850, 31, 'Torres del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4851, 31, 'Tudela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4852, 31, 'Tulebras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4853, 31, 'Ucar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4854, 31, 'Uharte-Arakil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4855, 31, 'Ujué'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4856, 31, 'Ultzama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4857, 31, 'Unciti'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4858, 31, 'Unzué'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4859, 31, 'Urdazubi/Urdax'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4860, 31, 'Urdiain'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4861, 31, 'Urraul Alto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4862, 31, 'Urraul Bajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4863, 31, 'Urrotz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4864, 31, 'Urroz-Villa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4865, 31, 'Urzainqui/Urzainki'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4866, 31, 'Uterga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4867, 31, 'Uztárroz/Uztarroze'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4830, 31, 'Ribaforada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4831, 31, 'Romanzado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4832, 31, 'Roncal/Erronkari'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4833, 31, 'Sada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4834, 31, 'Saldías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4835, 31, 'Salinas de Oro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4836, 31, 'San Adrián'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4837, 31, 'San Martín de Unx'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4838, 31, 'Sangüesa/Zangoza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4839, 31, 'Sansol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4840, 31, 'Santacara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4841, 31, 'Sarriés/Sartze'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4842, 31, 'Sartaguda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4843, 31, 'Sesma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4844, 31, 'Sorlada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4845, 31, 'Sunbilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4846, 31, 'Tafalla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4847, 31, 'Tiebas-Muruarte de Reta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4848, 31, 'Tirapu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4872, 31, 'Villafranca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4873, 31, 'Villamayor de Monjardín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4874, 31, 'Villatuerta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4875, 31, 'Villava/Atarrabia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4876, 31, 'Yesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4877, 31, 'Zabalza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4878, 31, 'Ziordia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4879, 31, 'Zizur Mayor/Zizur Nagusia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4880, 31, 'Zubieta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4881, 31, 'Zugarramurdi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4882, 31, 'Zúñiga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4883, 32, 'Allariz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4884, 32, 'Amoeiro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4885, 32, 'Arnoia (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4886, 32, 'Avión'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4887, 32, 'Baltar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4888, 32, 'Bande'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4889, 32, 'Baños de Molgas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4890, 32, 'Barbadás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4930, 32, 'Muíños'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4931, 32, 'Nogueira de Ramuín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4932, 32, 'Oímbra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4910, 32, 'Cortegada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4911, 32, 'Cualedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4912, 32, 'Entrimo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4913, 32, 'Esgos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4914, 32, 'Gomesende'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4915, 32, 'Gudiña (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4916, 32, 'Irixo (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4917, 32, 'Larouco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4918, 32, 'Laza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4919, 32, 'Leiro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4920, 32, 'Lobeira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4921, 32, 'Lobios'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4922, 32, 'Maceda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4923, 32, 'Manzaneda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4924, 32, 'Maside'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4925, 32, 'Melón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4926, 32, 'Merca (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4927, 32, 'Mezquita (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4928, 32, 'Montederramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4929, 32, 'Monterrei'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4891, 32, 'Barco de Valdeorras (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4892, 32, 'Beade'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4893, 32, 'Beariz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4894, 32, 'Blancos (Os)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4895, 32, 'Boborás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4896, 32, 'Bola (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4897, 32, 'Bolo (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4898, 32, 'Calvos de Randín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4899, 32, 'Carballeda de Avia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4900, 32, 'Carballeda de Valdeorras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4901, 32, 'Carballiño (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4902, 32, 'Cartelle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4903, 32, 'Castrelo de Miño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4904, 32, 'Castrelo do Val'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4905, 32, 'Castro Caldelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4906, 32, 'Celanova'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4907, 32, 'Cenlle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4908, 32, 'Chandrexa de Queixa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4909, 32, 'Coles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4933, 32, 'Ourense'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4934, 32, 'Paderne de Allariz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4935, 32, 'Padrenda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4936, 32, 'Parada de Sil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4937, 32, 'Pereiro de Aguiar (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4938, 32, 'Peroxa (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4939, 32, 'Petín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4940, 32, 'Piñor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4941, 32, 'Pobra de Trives (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4942, 32, 'Pontedeva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4943, 32, 'Porqueira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4944, 32, 'Punxín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4945, 32, 'Quintela de Leirado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4946, 32, 'Rairiz de Veiga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4947, 32, 'Ramirás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4948, 32, 'Ribadavia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4949, 32, 'Riós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4950, 32, 'Rúa (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4951, 32, 'Rubiá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4990, 33, 'Castrillón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4991, 33, 'Castropol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4992, 33, 'Coaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4971, 32, 'Vilariño de Conso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4972, 32, 'Xinzo de Limia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4973, 32, 'Xunqueira de Ambía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4974, 32, 'Xunqueira de Espadanedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4975, 33, 'Allande'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4976, 33, 'Aller'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4977, 33, 'Amieva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4978, 33, 'Avilés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4979, 33, 'Belmonte de Miranda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4980, 33, 'Bimenes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4981, 33, 'Boal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4982, 33, 'Cabrales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4983, 33, 'Cabranes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4984, 33, 'Candamo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4985, 33, 'Cangas de Onís'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4986, 33, 'Cangas del Narcea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4987, 33, 'Caravia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4988, 33, 'Carreño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4989, 33, 'Caso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4952, 32, 'San Amaro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4953, 32, 'San Cibrao das Viñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4954, 32, 'San Cristovo de Cea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4955, 32, 'San Xoán de Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4956, 32, 'Sandiás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4957, 32, 'Sarreaus'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4958, 32, 'Taboadela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4959, 32, 'Teixeira (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4960, 32, 'Toén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4961, 32, 'Trasmiras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4962, 32, 'Veiga (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4963, 32, 'Verea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4964, 32, 'Verín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4965, 32, 'Viana do Bolo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4966, 32, 'Vilamarín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4967, 32, 'Vilamartín de Valdeorras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4968, 32, 'Vilar de Barrio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4969, 32, 'Vilar de Santos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4970, 32, 'Vilardevós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4993, 33, 'Colunga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4994, 33, 'Corvera de Asturias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4995, 33, 'Cudillero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4996, 33, 'Degaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4997, 33, 'Franco (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4998, 33, 'Gijón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(4999, 33, 'Gozón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5000, 33, 'Grado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5001, 33, 'Grandas de Salime'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5002, 33, 'Ibias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5003, 33, 'Illano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5004, 33, 'Illas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5005, 33, 'Langreo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5006, 33, 'Laviana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5007, 33, 'Lena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5008, 33, 'Llanera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5009, 33, 'Llanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5010, 33, 'Mieres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5011, 33, 'Morcín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5050, 33, 'Villaviciosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5051, 33, 'Villayón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5052, 33, 'Yernes y Tameza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5053, 34, 'Abarca de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5054, 34, 'Abia de las Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5031, 33, 'Riosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5032, 33, 'Salas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5033, 33, 'San Martín de Oscos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5034, 33, 'San Martín del Rey Aurelio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5035, 33, 'San Tirso de Abres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5036, 33, 'Santa Eulalia de Oscos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5037, 33, 'Santo Adriano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5038, 33, 'Sariego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5039, 33, 'Siero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5040, 33, 'Sobrescobio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5041, 33, 'Somiedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5042, 33, 'Soto del Barco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5043, 33, 'Tapia de Casariego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5044, 33, 'Taramundi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5045, 33, 'Teverga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5046, 33, 'Tineo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5047, 33, 'Valdés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5048, 33, 'Vegadeo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5049, 33, 'Villanueva de Oscos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5012, 33, 'Muros de Nalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5013, 33, 'Nava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5014, 33, 'Navia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5015, 33, 'Noreña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5016, 33, 'Onís'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5017, 33, 'Oviedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5018, 33, 'Parres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5019, 33, 'Peñamellera Alta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5020, 33, 'Peñamellera Baja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5021, 33, 'Pesoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5022, 33, 'Piloña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5023, 33, 'Ponga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5024, 33, 'Pravia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5025, 33, 'Proaza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5026, 33, 'Quirós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5027, 33, 'Regueras (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5028, 33, 'Ribadedeva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5029, 33, 'Ribadesella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5030, 33, 'Ribera de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5055, 34, 'Aguilar de Campoo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5056, 34, 'Alar del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5057, 34, 'Alba de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5058, 34, 'Amayuelas de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5059, 34, 'Ampudia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5060, 34, 'Amusco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5061, 34, 'Antigüedad'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5062, 34, 'Arconada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5063, 34, 'Astudillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5064, 34, 'Autilla del Pino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5065, 34, 'Autillo de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5066, 34, 'Ayuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5067, 34, 'Baltanás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5068, 34, 'Baquerín de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5069, 34, 'Bárcena de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5070, 34, 'Barruelo de Santullán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5071, 34, 'Báscones de Ojeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5072, 34, 'Becerril de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5091, 34, 'Castrillo de Villavega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5092, 34, 'Castromocho'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5093, 34, 'Cervatos de la Cueza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5094, 34, 'Cervera de Pisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5095, 34, 'Cevico de la Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5096, 34, 'Cevico Navero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5097, 34, 'Cisneros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5098, 34, 'Cobos de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5099, 34, 'Collazos de Boedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5100, 34, 'Congosto de Valdavia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5101, 34, 'Cordovilla la Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5102, 34, 'Cubillas de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5103, 34, 'Dehesa de Montejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5104, 34, 'Dehesa de Romanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5105, 34, 'Dueñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5106, 34, 'Espinosa de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5073, 34, 'Belmonte de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5074, 34, 'Berzosilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5075, 34, 'Boada de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5076, 34, 'Boadilla de Rioseco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5077, 34, 'Boadilla del Camino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5078, 34, 'Brañosera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5079, 34, 'Buenavista de Valdavia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5080, 34, 'Bustillo de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5081, 34, 'Bustillo del Páramo de Carrión'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5082, 34, 'Calahorra de Boedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5083, 34, 'Calzada de los Molinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5084, 34, 'Capillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5085, 34, 'Cardeñosa de Volpejera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5086, 34, 'Carrión de los Condes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5087, 34, 'Castil de Vela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5088, 34, 'Castrejón de la Peña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5089, 34, 'Castrillo de Don Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5090, 34, 'Castrillo de Onielo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5107, 34, 'Espinosa de Villagonzalo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5108, 34, 'Frechilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5109, 34, 'Fresno del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5110, 34, 'Frómista'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5111, 34, 'Fuentes de Nava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5112, 34, 'Fuentes de Valdepero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5113, 34, 'Grijota'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5114, 34, 'Guardo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5115, 34, 'Guaza de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5116, 34, 'Hérmedes de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5117, 34, 'Herrera de Pisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5118, 34, 'Herrera de Valdecañas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5119, 34, 'Hontoria de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5120, 34, 'Hornillos de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5121, 34, 'Husillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5122, 34, 'Itero de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5123, 34, 'Lagartos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5124, 34, 'Lantadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5144, 34, 'Osorno la Mayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5145, 34, 'Palencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5146, 34, 'Palenzuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5147, 34, 'Páramo de Boedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5148, 34, 'Paredes de Nava'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5149, 34, 'Payo de Ojeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5150, 34, 'Pedraza de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5151, 34, 'Pedrosa de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5152, 34, 'Perales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5153, 34, 'Pernía (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5154, 34, 'Pino del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5155, 34, 'Piña de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5156, 34, 'Población de Arroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5157, 34, 'Población de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5158, 34, 'Población de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5159, 34, 'Polentinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5160, 34, 'Pomar de Valdivia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5161, 34, 'Poza de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5125, 34, 'Ledigos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5126, 34, 'Loma de Ucieza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5127, 34, 'Lomas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5128, 34, 'Magaz de Pisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5129, 34, 'Manquillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5130, 34, 'Mantinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5131, 34, 'Marcilla de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5132, 34, 'Mazariegos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5133, 34, 'Mazuecos de Valdeginate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5134, 34, 'Melgar de Yuso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5135, 34, 'Meneses de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5136, 34, 'Micieces de Ojeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5137, 34, 'Monzón de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5138, 34, 'Moratinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5139, 34, 'Mudá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5140, 34, 'Nogal de las Huertas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5141, 34, 'Olea de Boedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5142, 34, 'Olmos de Ojeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5143, 34, 'Osornillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5162, 34, 'Pozo de Urama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5163, 34, 'Prádanos de Ojeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5164, 34, 'Puebla de Valdavia (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5165, 34, 'Quintana del Puente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5166, 34, 'Quintanilla de Onsoña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5167, 34, 'Reinoso de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5168, 34, 'Renedo de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5169, 34, 'Requena de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5170, 34, 'Respenda de la Peña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5171, 34, 'Revenga de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5172, 34, 'Revilla de Collazos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5173, 34, 'Ribas de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5174, 34, 'Riberos de la Cueza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5175, 34, 'Saldaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5176, 34, 'Salinas de Pisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5177, 34, 'San Cebrián de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5178, 34, 'San Cebrián de Mudá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5179, 34, 'San Cristóbal de Boedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5198, 34, 'Valbuena de Pisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5199, 34, 'Valdeolmillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5200, 34, 'Valderrábano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5201, 34, 'Valde-Ucieza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5202, 34, 'Valle de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5203, 34, 'Valle del Retortillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5204, 34, 'Velilla del Río Carrión'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5205, 34, 'Venta de Baños'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5206, 34, 'Vertavillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5207, 34, 'Vid de Ojeda (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5208, 34, 'Villabasta de Valdavia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5209, 34, 'Villacidaler'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5210, 34, 'Villaconancio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5211, 34, 'Villada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5212, 34, 'Villaeles de Valdavia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5180, 34, 'San Mamés de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5181, 34, 'San Román de la Cuba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5182, 34, 'Santa Cecilia del Alcor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5183, 34, 'Santa Cruz de Boedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5184, 34, 'Santervás de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5185, 34, 'Santibáñez de Ecla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5186, 34, 'Santibáñez de la Peña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5187, 34, 'Santoyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5188, 34, 'Serna (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5189, 34, 'Soto de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5190, 34, 'Sotobañado y Priorato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5191, 34, 'Tabanera de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5192, 34, 'Tabanera de Valdavia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5193, 34, 'Támara de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5194, 34, 'Tariego de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5195, 34, 'Torquemada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5196, 34, 'Torremormojón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5197, 34, 'Triollo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5213, 34, 'Villahán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5214, 34, 'Villaherreros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5215, 34, 'Villalaco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5216, 34, 'Villalba de Guardo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5217, 34, 'Villalcázar de Sirga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5218, 34, 'Villalcón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5219, 34, 'Villalobón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5220, 34, 'Villaluenga de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5221, 34, 'Villamartín de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5222, 34, 'Villamediana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5223, 34, 'Villameriel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5224, 34, 'Villamoronta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5225, 34, 'Villamuera de la Cueza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5226, 34, 'Villamuriel de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5227, 34, 'Villanueva del Rebollar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5228, 34, 'Villanuño de Valdavia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5229, 34, 'Villaprovedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5230, 34, 'Villarmentero de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5250, 35, 'Arucas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5251, 35, 'Betancuria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5252, 35, 'Firgas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5253, 35, 'Gáldar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5254, 35, 'Haría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5255, 35, 'Ingenio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5256, 35, 'Mogán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5257, 35, 'Moya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5258, 35, 'Oliva (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5259, 35, 'Pájara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5260, 35, 'Palmas de Gran Canaria (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5261, 35, 'Puerto del Rosario'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5262, 35, 'San Bartolomé'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5263, 35, 'San Bartolomé de Tirajana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5264, 35, 'Santa Brígida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5265, 35, 'Santa Lucía de Tirajana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5266, 35, 'Santa María de Guía de Gran Canaria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5267, 35, 'Teguise'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5268, 35, 'Tejeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5231, 34, 'Villarrabé'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5232, 34, 'Villarramiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5233, 34, 'Villasarracino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5234, 34, 'Villasila de Valdavia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5235, 34, 'Villaturde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5236, 34, 'Villaumbrales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5237, 34, 'Villaviudas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5238, 34, 'Villerías de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5239, 34, 'Villodre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5240, 34, 'Villodrigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5241, 34, 'Villoldo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5242, 34, 'Villota del Páramo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5243, 34, 'Villovieco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5244, 35, 'Agaete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5245, 35, 'Agüimes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5246, 35, 'Aldea de San Nicolás (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5247, 35, 'Antigua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5248, 35, 'Arrecife'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5249, 35, 'Artenara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5269, 35, 'Telde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5270, 35, 'Teror'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5271, 35, 'Tías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5272, 35, 'Tinajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5273, 35, 'Tuineje'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5274, 35, 'Valleseco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5275, 35, 'Valsequillo de Gran Canaria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5276, 35, 'Vega de San Mateo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5277, 35, 'Yaiza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5278, 36, 'Agolada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5279, 36, 'Arbo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5280, 36, 'Baiona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5281, 36, 'Barro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5282, 36, 'Bueu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5283, 36, 'Caldas de Reis'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5284, 36, 'Cambados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5285, 36, 'Campo Lameiro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5286, 36, 'Cangas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5287, 36, 'Cañiza (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5326, 36, 'Rosal (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5327, 36, 'Salceda de Caselas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5328, 36, 'Salvaterra de Miño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5329, 36, 'Sanxenxo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5330, 36, 'Silleda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5331, 36, 'Soutomaior'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5332, 36, 'Tomiño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5307, 36, 'Moaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5308, 36, 'Mondariz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5309, 36, 'Mondariz-Balneario'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5310, 36, 'Moraña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5311, 36, 'Mos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5312, 36, 'Neves (As)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5313, 36, 'Nigrán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5314, 36, 'Oia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5315, 36, 'Pazos de Borbén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5316, 36, 'Poio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5317, 36, 'Ponte Caldelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5318, 36, 'Ponteareas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5319, 36, 'Pontecesures'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5320, 36, 'Pontevedra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5321, 36, 'Porriño (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5322, 36, 'Portas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5323, 36, 'Redondela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5324, 36, 'Ribadumia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5325, 36, 'Rodeiro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5288, 36, 'Catoira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5289, 36, 'Cerdedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5290, 36, 'Cotobade'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5291, 36, 'Covelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5292, 36, 'Crecente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5293, 36, 'Cuntis'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5294, 36, 'Dozón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5295, 36, 'Estrada (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5296, 36, 'Forcarei'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5297, 36, 'Fornelos de Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5298, 36, 'Gondomar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5299, 36, 'Grove (O)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5300, 36, 'Guarda (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5301, 36, 'Illa de Arousa (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5302, 36, 'Lalín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5303, 36, 'Lama (A)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5304, 36, 'Marín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5305, 36, 'Meaño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5306, 36, 'Meis'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5333, 36, 'Tui'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5334, 36, 'Valga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5335, 36, 'Vigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5336, 36, 'Vila de Cruces'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5337, 36, 'Vilaboa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5338, 36, 'Vilagarcía de Arousa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5339, 36, 'Vilanova de Arousa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5340, 37, 'Abusejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5341, 37, 'Agallas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5342, 37, 'Ahigal de los Aceiteros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5343, 37, 'Ahigal de Villarino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5344, 37, 'Alameda de Gardón (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5345, 37, 'Alamedilla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5346, 37, 'Alaraz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5347, 37, 'Alba de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5348, 37, 'Alba de Yeltes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5349, 37, 'Alberca (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5350, 37, 'Alberguería de Argañán (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5351, 37, 'Alconada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5370, 37, 'Arabayona de Mógica'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5371, 37, 'Arapiles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5372, 37, 'Arcediano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5373, 37, 'Arco (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5374, 37, 'Armenteros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5375, 37, 'Atalaya (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5376, 37, 'Babilafuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5377, 37, 'Bañobárez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5378, 37, 'Barbadillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5379, 37, 'Barbalos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5380, 37, 'Barceo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5381, 37, 'Barruecopardo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5382, 37, 'Bastida (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5383, 37, 'Béjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5384, 37, 'Beleña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5385, 37, 'Bermellar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5386, 37, 'Berrocal de Huebra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5387, 37, 'Berrocal de Salvatierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5352, 37, 'Aldea del Obispo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5353, 37, 'Aldeacipreste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5354, 37, 'Aldeadávila de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5355, 37, 'Aldealengua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5356, 37, 'Aldeanueva de Figueroa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5357, 37, 'Aldeanueva de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5358, 37, 'Aldearrodrigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5359, 37, 'Aldearrubia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5360, 37, 'Aldeaseca de Alba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5361, 37, 'Aldeaseca de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5362, 37, 'Aldeatejada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5363, 37, 'Aldeavieja de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5364, 37, 'Aldehuela de la Bóveda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5365, 37, 'Aldehuela de Yeltes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5366, 37, 'Almenara de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5367, 37, 'Almendra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5368, 37, 'Anaya de Alba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5369, 37, 'Añover de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5388, 37, 'Boada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5389, 37, 'Bodón (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5390, 37, 'Bogajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5391, 37, 'Bouza (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5392, 37, 'Bóveda del Río Almar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5393, 37, 'Brincones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5394, 37, 'Buenamadre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5395, 37, 'Buenavista'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5396, 37, 'Cabaco (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5397, 37, 'Cabeza de Béjar (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5398, 37, 'Cabeza del Caballo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5399, 37, 'Cabezabellosa de la Calzada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5400, 37, 'Cabrerizos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5401, 37, 'Cabrillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5402, 37, 'Calvarrasa de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5403, 37, 'Calvarrasa de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5404, 37, 'Calzada de Béjar (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5405, 37, 'Calzada de Don Diego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5424, 37, 'Castillejo de Martín Viejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5425, 37, 'Castraz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5426, 37, 'Cepeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5427, 37, 'Cereceda de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5428, 37, 'Cerezal de Peñahorcada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5429, 37, 'Cerralbo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5430, 37, 'Cerro (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5431, 37, 'Cespedosa de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5432, 37, 'Chagarcía Medianero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5433, 37, 'Cilleros de la Bastida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5434, 37, 'Cipérez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5435, 37, 'Ciudad Rodrigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5436, 37, 'Coca de Alba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5437, 37, 'Colmenar de Montemayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5438, 37, 'Cordovilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5439, 37, 'Cristóbal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5406, 37, 'Calzada de Valdunciel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5407, 37, 'Campillo de Azaba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5408, 37, 'Campo de Peñaranda (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5409, 37, 'Candelario'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5410, 37, 'Canillas de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5411, 37, 'Cantagallo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5412, 37, 'Cantalapiedra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5413, 37, 'Cantalpino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5414, 37, 'Cantaracillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5415, 37, 'Carbajosa de la Sagrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5416, 37, 'Carpio de Azaba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5417, 37, 'Carrascal de Barregas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5418, 37, 'Carrascal del Obispo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5419, 37, 'Casafranca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5420, 37, 'Casas del Conde (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5421, 37, 'Casillas de Flores'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5422, 37, 'Castellanos de Moriscos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5423, 37, 'Castellanos de Villiquera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5440, 37, 'Cubo de Don Sancho (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5441, 37, 'Dios le Guarde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5442, 37, 'Doñinos de Ledesma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5443, 37, 'Doñinos de Salamanca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5444, 37, 'Ejeme'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5445, 37, 'Encina (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5446, 37, 'Encina de San Silvestre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5447, 37, 'Encinas de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5448, 37, 'Encinas de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5449, 37, 'Encinasola de los Comendadores'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5450, 37, 'Endrinal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5451, 37, 'Escurial de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5452, 37, 'Espadaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5453, 37, 'Espeja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5454, 37, 'Espino de la Orbada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5455, 37, 'Florida de Liébana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5456, 37, 'Forfoleda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5457, 37, 'Frades de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5476, 37, 'Gejuelo del Barro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5477, 37, 'Golpejas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5478, 37, 'Gomecello'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5479, 37, 'Guadramiro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5480, 37, 'Guijo de Ávila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5481, 37, 'Guijuelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5482, 37, 'Herguijuela de Ciudad Rodrigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5483, 37, 'Herguijuela de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5484, 37, 'Herguijuela del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5485, 37, 'Hinojosa de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5486, 37, 'Horcajo de Montemayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5487, 37, 'Horcajo Medianero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5488, 37, 'Hoya (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5489, 37, 'Huerta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5490, 37, 'Iruelos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5491, 37, 'Ituero de Azaba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5492, 37, 'Juzbado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5458, 37, 'Fregeneda (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5459, 37, 'Fresnedoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5460, 37, 'Fresno Alhándiga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5461, 37, 'Fuente de San Esteban (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5462, 37, 'Fuenteguinaldo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5463, 37, 'Fuenteliante'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5464, 37, 'Fuenterroble de Salvatierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5465, 37, 'Fuentes de Béjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5466, 37, 'Fuentes de Oñoro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5467, 37, 'Gajates'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5468, 37, 'Galindo y Perahuy'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5469, 37, 'Galinduste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5470, 37, 'Galisancho'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5471, 37, 'Gallegos de Argañán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5472, 37, 'Gallegos de Solmirón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5473, 37, 'Garcibuey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5474, 37, 'Garcihernández'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5475, 37, 'Garcirrey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5493, 37, 'Lagunilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5494, 37, 'Larrodrigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5495, 37, 'Ledesma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5496, 37, 'Ledrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5497, 37, 'Linares de Riofrío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5498, 37, 'Lumbrales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5499, 37, 'Machacón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5500, 37, 'Macotera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5501, 37, 'Madroñal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5502, 37, 'Maíllo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5503, 37, 'Malpartida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5504, 37, 'Mancera de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5505, 37, 'Manzano (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5506, 37, 'Martiago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5507, 37, 'Martín de Yeltes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5508, 37, 'Martinamor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5509, 37, 'Masueco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5510, 37, 'Mata de Ledesma (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5511, 37, 'Matilla de los Caños del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5531, 37, 'Moriscos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5532, 37, 'Moronta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5533, 37, 'Mozárbez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5534, 37, 'Narros de Matalayegua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5535, 37, 'Nava de Béjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5536, 37, 'Nava de Francia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5537, 37, 'Nava de Sotrobal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5538, 37, 'Navacarros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5539, 37, 'Navales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5540, 37, 'Navalmoral de Béjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5541, 37, 'Navamorales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5542, 37, 'Navarredonda de la Rinconada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5543, 37, 'Navasfrías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5544, 37, 'Negrilla de Palencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5545, 37, 'Olmedo de Camaces'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5546, 37, 'Orbada (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5547, 37, 'Pajares de la Laguna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5548, 37, 'Palacios del Arzobispo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5512, 37, 'Maya (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5513, 37, 'Membribe de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5514, 37, 'Mieza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5515, 37, 'Milano (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5516, 37, 'Miranda de Azán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5517, 37, 'Miranda del Castañar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5518, 37, 'Mogarraz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5519, 37, 'Molinillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5520, 37, 'Monforte de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5521, 37, 'Monleón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5522, 37, 'Monleras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5523, 37, 'Monsagro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5524, 37, 'Montejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5525, 37, 'Montemayor del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5526, 37, 'Monterrubio de Armuña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5527, 37, 'Monterrubio de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5528, 37, 'Morasverdes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5529, 37, 'Morille'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5530, 37, 'Moríñigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5549, 37, 'Palaciosrubios'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5550, 37, 'Palencia de Negrilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5551, 37, 'Parada de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5552, 37, 'Parada de Rubiales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5553, 37, 'Paradinas de San Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5554, 37, 'Pastores'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5555, 37, 'Payo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5556, 37, 'Pedraza de Alba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5557, 37, 'Pedrosillo de Alba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5558, 37, 'Pedrosillo de los Aires'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5559, 37, 'Pedrosillo el Ralo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5560, 37, 'Pedroso de la Armuña (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5561, 37, 'Pelabravo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5562, 37, 'Pelarrodríguez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5563, 37, 'Pelayos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5564, 37, 'Peña (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5565, 37, 'Peñacaballera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5566, 37, 'Peñaparda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5585, 37, 'Puerto Seguro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5586, 37, 'Rágama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5587, 37, 'Redonda (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5588, 37, 'Retortillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5589, 37, 'Rinconada de la Sierra (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5590, 37, 'Robleda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5591, 37, 'Robliza de Cojos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5592, 37, 'Rollán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5593, 37, 'Saelices el Chico'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5594, 37, 'Sagrada (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5595, 37, 'Sahugo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5596, 37, 'Salamanca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5597, 37, 'Saldeana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5598, 37, 'Salmoral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5599, 37, 'Salvatierra de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5600, 37, 'San Cristóbal de la Cuesta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5601, 37, 'San Esteban de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5602, 37, 'San Felices de los Gallegos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5567, 37, 'Peñaranda de Bracamonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5568, 37, 'Peñarandilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5569, 37, 'Peralejos de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5570, 37, 'Peralejos de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5571, 37, 'Pereña de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5572, 37, 'Peromingo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5573, 37, 'Pinedas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5574, 37, 'Pino de Tormes (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5575, 37, 'Pitiegua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5576, 37, 'Pizarral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5577, 37, 'Poveda de las Cintas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5578, 37, 'Pozos de Hinojo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5579, 37, 'Puebla de Azaba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5580, 37, 'Puebla de San Medel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5581, 37, 'Puebla de Yeltes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5582, 37, 'Puente del Congosto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5583, 37, 'Puertas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5584, 37, 'Puerto de Béjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5603, 37, 'San Martín del Castañar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5604, 37, 'San Miguel de Valero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5605, 37, 'San Miguel del Robledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5606, 37, 'San Morales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5607, 37, 'San Muñoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5608, 37, 'San Pedro de Rozados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5609, 37, 'San Pedro del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5610, 37, 'San Pelayo de Guareña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5611, 37, 'Sanchón de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5612, 37, 'Sanchón de la Sagrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5613, 37, 'Sanchotello'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5614, 37, 'Sancti-Spíritus'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5615, 37, 'Sando'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5616, 37, 'Santa María de Sando'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5617, 37, 'Santa Marta de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5618, 37, 'Santiago de la Puebla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5619, 37, 'Santibáñez de Béjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5620, 37, 'Santibáñez de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5640, 37, 'Tejeda y Segoyuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5641, 37, 'Tenebrón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5642, 37, 'Terradillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5643, 37, 'Topas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5644, 37, 'Tordillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5645, 37, 'Tornadizo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5646, 37, 'Torresmenudas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5647, 37, 'Trabanca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5648, 37, 'Tremedal de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5649, 37, 'Valdecarros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5650, 37, 'Valdefuentes de Sangusín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5651, 37, 'Valdehijaderos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5652, 37, 'Valdelacasa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5653, 37, 'Valdelageve'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5654, 37, 'Valdelosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5655, 37, 'Valdemierque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5656, 37, 'Valderrodrigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5621, 37, 'Santiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5622, 37, 'Santos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5623, 37, 'Sardón de los Frailes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5624, 37, 'Saucelle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5625, 37, 'Sepulcro-Hilario'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5626, 37, 'Sequeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5627, 37, 'Serradilla del Arroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5628, 37, 'Serradilla del Llano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5629, 37, 'Sierpe (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5630, 37, 'Sieteiglesias de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5631, 37, 'Sobradillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5632, 37, 'Sorihuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5633, 37, 'Sotoserrano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5634, 37, 'Tabera de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5635, 37, 'Tala (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5636, 37, 'Tamames'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5637, 37, 'Tarazona de Guareña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5638, 37, 'Tardáguila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5639, 37, 'Tejado (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5657, 37, 'Valdunciel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5658, 37, 'Valero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5659, 37, 'Vallejera de Riofrío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5660, 37, 'Valsalabroso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5661, 37, 'Valverde de Valdelacasa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5662, 37, 'Valverdón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5663, 37, 'Vecinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5664, 37, 'Vega de Tirados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5665, 37, 'Veguillas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5666, 37, 'Vellés (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5667, 37, 'Ventosa del Río Almar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5668, 37, 'Vídola (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5669, 37, 'Villaflores'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5670, 37, 'Villagonzalo de Tormes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5671, 37, 'Villalba de los Llanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5672, 37, 'Villamayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5673, 37, 'Villanueva del Conde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5674, 37, 'Villar de Argañán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5693, 37, 'Villoruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5694, 37, 'Vilvestre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5695, 37, 'Vitigudino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5696, 37, 'Yecla de Yeltes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5697, 37, 'Zamarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5698, 37, 'Zamayón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5699, 37, 'Zarapicos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5700, 37, 'Zarza de Pumareda (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5701, 37, 'Zorita de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5702, 38, 'Adeje'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5703, 38, 'Agulo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5704, 38, 'Alajeró'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5705, 38, 'Arafo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5706, 38, 'Arico'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5707, 38, 'Arona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5708, 38, 'Barlovento'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5709, 38, 'Breña Alta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5710, 38, 'Breña Baja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5711, 38, 'Buenavista del Norte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5675, 37, 'Villar de Ciervo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5676, 37, 'Villar de Gallimazo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5677, 37, 'Villar de la Yegua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5678, 37, 'Villar de Peralonso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5679, 37, 'Villar de Samaniego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5680, 37, 'Villares de la Reina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5681, 37, 'Villares de Yeltes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5682, 37, 'Villarino de los Aires'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5683, 37, 'Villarmayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5684, 37, 'Villarmuerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5685, 37, 'Villasbuenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5686, 37, 'Villasdardo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5687, 37, 'Villaseco de los Gamitos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5688, 37, 'Villaseco de los Reyes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5689, 37, 'Villasrubias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5690, 37, 'Villaverde de Guareña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5691, 37, 'Villavieja de Yeltes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5692, 37, 'Villoria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5712, 38, 'Candelaria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5713, 38, 'Fasnia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5714, 38, 'Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5715, 38, 'Fuencaliente de la Palma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5716, 38, 'Garachico'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5717, 38, 'Garafía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5718, 38, 'Granadilla de Abona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5719, 38, 'Guancha (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5720, 38, 'Guía de Isora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5721, 38, 'Güímar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5722, 38, 'Hermigua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5723, 38, 'Icod de los Vinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5724, 38, 'Llanos de Aridane (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5725, 38, 'Matanza de Acentejo (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5726, 38, 'Orotava (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5727, 38, 'Paso (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5728, 38, 'Puerto de la Cruz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5729, 38, 'Puntagorda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5730, 38, 'Puntallana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5749, 38, 'Valle Gran Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5750, 38, 'Vallehermoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5751, 38, 'Valverde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5752, 38, 'Victoria de Acentejo (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5753, 38, 'Vilaflor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5754, 38, 'Villa de Mazo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5755, 39, 'Alfoz de Lloredo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5756, 39, 'Ampuero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5757, 39, 'Anievas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5758, 39, 'Arenas de Iguña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5759, 39, 'Argoños'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5760, 39, 'Arnuero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5761, 39, 'Arredondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5762, 39, 'Astillero (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5763, 39, 'Bárcena de Cicero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5764, 39, 'Bárcena de Pie de Concha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5731, 38, 'Realejos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5732, 38, 'Rosario (El)'); 
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (5733, 38, 'San Andrés y Sauces');
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (5734, 38, 'San Cristóbal de La Laguna'); 
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5735, 38, 'San Juan de la Rambla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5736, 38, 'San Miguel de Abona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5737, 38, 'San Sebastián de la Gomera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5738, 38, 'Santa Cruz de la Palma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5739, 38, 'Santa Cruz de Tenerife'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5740, 38, 'Santa Úrsula'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5741, 38, 'Santiago del Teide'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5742, 38, 'Sauzal (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5743, 38, 'Silos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5744, 38, 'Tacoronte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5745, 38, 'Tanque (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5746, 38, 'Tazacorte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5747, 38, 'Tegueste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5748, 38, 'Tijarafe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5765, 39, 'Bareyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5766, 39, 'Cabezón de la Sal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5767, 39, 'Cabezón de Liébana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5768, 39, 'Cabuérniga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5769, 39, 'Camaleño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5770, 39, 'Camargo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5771, 39, 'Campoo de Enmedio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5772, 39, 'Campoo de Yuso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5773, 39, 'Cartes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5774, 39, 'Castañeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5775, 39, 'Castro-Urdiales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5776, 39, 'Cieza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5777, 39, 'Cillorigo de Liébana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5778, 39, 'Colindres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5779, 39, 'Comillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5780, 39, 'Corrales de Buelna (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5781, 39, 'Corvera de Toranzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5782, 39, 'Entrambasaguas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5783, 39, 'Escalante'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5822, 39, 'Ruiloba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5823, 39, 'San Felices de Buelna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5824, 39, 'San Miguel de Aguayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5803, 39, 'Peñarrubia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5804, 39, 'Pesaguero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5805, 39, 'Pesquera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5806, 39, 'Piélagos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5807, 39, 'Polaciones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5808, 39, 'Polanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5809, 39, 'Potes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5810, 39, 'Puente Viesgo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5811, 39, 'Ramales de la Victoria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5812, 39, 'Rasines'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5813, 39, 'Reinosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5814, 39, 'Reocín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5815, 39, 'Ribamontán al Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5816, 39, 'Ribamontán al Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5817, 39, 'Rionansa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5818, 39, 'Riotuerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5819, 39, 'Rozas de Valdearroyo (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5820, 39, 'Ruente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5821, 39, 'Ruesga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5784, 39, 'Guriezo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5785, 39, 'Hazas de Cesto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5786, 39, 'Hermandad de Campoo de Suso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5787, 39, 'Herrerías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5788, 39, 'Lamasón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5789, 39, 'Laredo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5790, 39, 'Liendo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5791, 39, 'Liérganes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5792, 39, 'Limpias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5793, 39, 'Luena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5794, 39, 'Marina de Cudeyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5795, 39, 'Mazcuerras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5796, 39, 'Medio Cudeyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5797, 39, 'Meruelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5798, 39, 'Miengo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5799, 39, 'Miera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5800, 39, 'Molledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5801, 39, 'Noja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5802, 39, 'Penagos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5825, 39, 'San Pedro del Romeral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5826, 39, 'San Roque de Riomiera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5827, 39, 'San Vicente de la Barquera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5828, 39, 'Santa Cruz de Bezana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5829, 39, 'Santa María de Cayón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5830, 39, 'Santander'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5831, 39, 'Santillana del Mar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5832, 39, 'Santiurde de Reinosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5833, 39, 'Santiurde de Toranzo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5834, 39, 'Santoña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5835, 39, 'Saro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5836, 39, 'Selaya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5837, 39, 'Soba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5838, 39, 'Solórzano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5839, 39, 'Suances'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5840, 39, 'Tojos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5841, 39, 'Torrelavega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5842, 39, 'Tresviso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5843, 39, 'Tudanca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5863, 40, 'Aldealcorvo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5864, 40, 'Aldealengua de Pedraza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5865, 40, 'Aldealengua de Santa María'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5866, 40, 'Aldeanueva de la Serrezuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5867, 40, 'Aldeanueva del Codonal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5868, 40, 'Aldeasoña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5869, 40, 'Aldehorno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5870, 40, 'Aldehuela del Codonal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5871, 40, 'Aldeonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5872, 40, 'Anaya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5873, 40, 'Añe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5874, 40, 'Arahuetes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5875, 40, 'Arcones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5876, 40, 'Arevalillo de Cega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5877, 40, 'Armuña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5878, 40, 'Ayllón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5879, 40, 'Barbolla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5880, 40, 'Basardilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5881, 40, 'Bercial'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5844, 39, 'Udías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5845, 39, 'Val de San Vicente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5846, 39, 'Valdáliga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5847, 39, 'Valdeolea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5848, 39, 'Valdeprado del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5849, 39, 'Valderredible'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5850, 39, 'Valle de Villaverde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5851, 39, 'Vega de Liébana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5852, 39, 'Vega de Pas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5853, 39, 'Villacarriedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5854, 39, 'Villaescusa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5855, 39, 'Villafufre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5856, 39, 'Voto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5857, 40, 'Abades'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5858, 40, 'Adrada de Pirón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5859, 40, 'Adrados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5860, 40, 'Aguilafuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5861, 40, 'Alconada de Maderuelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5862, 40, 'Aldea Real'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5882, 40, 'Bercimuel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5883, 40, 'Bernardos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5884, 40, 'Bernuy de Porreros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5885, 40, 'Boceguillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5886, 40, 'Brieva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5887, 40, 'Caballar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5888, 40, 'Cabañas de Polendos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5889, 40, 'Cabezuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5890, 40, 'Calabazas de Fuentidueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5891, 40, 'Campo de San Pedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5892, 40, 'Cantalejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5893, 40, 'Cantimpalos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5894, 40, 'Carbonero el Mayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5895, 40, 'Carrascal del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5896, 40, 'Casla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5897, 40, 'Castillejo de Mesleón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5898, 40, 'Castro de Fuentidueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5899, 40, 'Castrojimeno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5918, 40, 'Donhierro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5919, 40, 'Duruelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5920, 40, 'Encinas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5921, 40, 'Encinillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5922, 40, 'Escalona del Prado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5923, 40, 'Escarabajosa de Cabezas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5924, 40, 'Escobar de Polendos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5925, 40, 'Espinar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5926, 40, 'Espirdo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5927, 40, 'Fresneda de Cuéllar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5928, 40, 'Fresno de Cantespino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5929, 40, 'Fresno de la Fuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5930, 40, 'Frumales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5931, 40, 'Fuente de Santa Cruz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5932, 40, 'Fuente el Olmo de Fuentidueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5933, 40, 'Fuente el Olmo de Íscar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5934, 40, 'Fuentepelayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5935, 40, 'Fuentepiñel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5900, 40, 'Castroserna de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5901, 40, 'Castroserracín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5902, 40, 'Cedillo de la Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5903, 40, 'Cerezo de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5904, 40, 'Cerezo de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5905, 40, 'Chañe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5906, 40, 'Cilleruelo de San Mamés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5907, 40, 'Cobos de Fuentidueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5908, 40, 'Coca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5909, 40, 'Codorniz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5910, 40, 'Collado Hermoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5911, 40, 'Condado de Castilnovo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5912, 40, 'Corral de Ayllón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5913, 40, 'Cozuelos de Fuentidueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5914, 40, 'Cubillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5915, 40, 'Cuéllar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5916, 40, 'Cuevas de Provanco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5917, 40, 'Domingo García'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5936, 40, 'Fuenterrebollo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5937, 40, 'Fuentesaúco de Fuentidueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5938, 40, 'Fuentesoto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5939, 40, 'Fuentidueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5940, 40, 'Gallegos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5941, 40, 'Garcillán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5942, 40, 'Gomezserracín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5943, 40, 'Grajera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5944, 40, 'Honrubia de la Cuesta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5945, 40, 'Hontalbilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5946, 40, 'Hontanares de Eresma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5947, 40, 'Huertos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5948, 40, 'Ituero y Lama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5949, 40, 'Juarros de Riomoros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5950, 40, 'Juarros de Voltoya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5951, 40, 'Labajos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5952, 40, 'Laguna de Contreras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5953, 40, 'Languilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5990, 40, 'Orejana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5972, 40, 'Montejo de la Vega de la Serrezuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5973, 40, 'Monterrubio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5974, 40, 'Moral de Hornuez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5975, 40, 'Mozoncillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5976, 40, 'Muñopedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5977, 40, 'Muñoveros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5978, 40, 'Nava de la Asunción'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5979, 40, 'Navafría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5980, 40, 'Navalilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5981, 40, 'Navalmanzano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5982, 40, 'Navares de Ayuso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5983, 40, 'Navares de Enmedio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5984, 40, 'Navares de las Cuevas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5985, 40, 'Navas de Oro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5986, 40, 'Navas de Riofrío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5987, 40, 'Navas de San Antonio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5988, 40, 'Nieva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5989, 40, 'Olombrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5954, 40, 'Lastras de Cuéllar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5955, 40, 'Lastras del Pozo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5956, 40, 'Lastrilla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5957, 40, 'Losa (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5958, 40, 'Maderuelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5959, 40, 'Marazoleja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5960, 40, 'Marazuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5961, 40, 'Martín Miguel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5962, 40, 'Martín Muñoz de la Dehesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5963, 40, 'Martín Muñoz de las Posadas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5964, 40, 'Marugán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5965, 40, 'Mata de Cuéllar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5966, 40, 'Matabuena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5967, 40, 'Matilla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5968, 40, 'Melque de Cercos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5969, 40, 'Membibre de la Hoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5970, 40, 'Migueláñez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5971, 40, 'Montejo de Arévalo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5991, 40, 'Ortigosa de Pestaño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5992, 40, 'Ortigosa del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5993, 40, 'Otero de Herreros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5994, 40, 'Pajarejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5995, 40, 'Palazuelos de Eresma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5996, 40, 'Pedraza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5997, 40, 'Pelayos del Arroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5998, 40, 'Perosillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(5999, 40, 'Pinarejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6000, 40, 'Pinarnegrillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6001, 40, 'Pradales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6002, 40, 'Prádena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6003, 40, 'Puebla de Pedraza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6004, 40, 'Rapariegos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6005, 40, 'Rebollo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6006, 40, 'Remondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6007, 40, 'Riaguas de San Bartolomé'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6008, 40, 'Riaza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6009, 40, 'Ribota'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6028, 40, 'Santo Tomé del Puerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6029, 40, 'Sauquillo de Cabezas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6030, 40, 'Sebúlcor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6031, 40, 'Segovia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6032, 40, 'Sepúlveda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6033, 40, 'Sequera de Fresno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6034, 40, 'Sotillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6035, 40, 'Sotosalbos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6036, 40, 'Tabanera la Luenga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6037, 40, 'Tolocirio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6038, 40, 'Torre Val de San Pedro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6039, 40, 'Torreadrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6040, 40, 'Torrecaballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6041, 40, 'Torrecilla del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6042, 40, 'Torreiglesias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6043, 40, 'Trescasas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6044, 40, 'Turégano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6010, 40, 'Riofrío de Riaza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6011, 40, 'Roda de Eresma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6012, 40, 'Sacramenia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6013, 40, 'Samboal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6014, 40, 'San Cristóbal de Cuéllar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6015, 40, 'San Cristóbal de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6016, 40, 'San Cristóbal de Segovia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6017, 40, 'San Ildefonso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6018, 40, 'San Martín y Mudrián'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6019, 40, 'San Miguel de Bernuy'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6020, 40, 'San Pedro de Gaíllos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6021, 40, 'Sanchonuño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6022, 40, 'Sangarcía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6023, 40, 'Santa María la Real de Nieva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6024, 40, 'Santa Marta del Cerro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6025, 40, 'Santiuste de Pedraza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6026, 40, 'Santiuste de San Juan Bautista'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6027, 40, 'Santo Domingo de Pirón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6045, 40, 'Urueñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6046, 40, 'Valdeprados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6047, 40, 'Valdevacas de Montejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6048, 40, 'Valdevacas y Guijar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6049, 40, 'Valle de Tabladillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6050, 40, 'Vallelado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6051, 40, 'Valleruela de Pedraza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6052, 40, 'Valleruela de Sepúlveda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6053, 40, 'Valseca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6054, 40, 'Valtiendas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6055, 40, 'Valverde del Majano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6056, 40, 'Veganzones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6057, 40, 'Vegas de Matute'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6058, 40, 'Ventosilla y Tejadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6059, 40, 'Villacastín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6060, 40, 'Villaverde de Íscar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6061, 40, 'Villaverde de Montejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6062, 40, 'Villeguillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6081, 41, 'Bollullos de la Mitación'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6082, 41, 'Bormujos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6083, 41, 'Brenes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6084, 41, 'Burguillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6085, 41, 'Cabezas de San Juan (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6086, 41, 'Camas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6087, 41, 'Campana (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6088, 41, 'Cantillana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6089, 41, 'Cañada Rosal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6090, 41, 'Carmona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6091, 41, 'Carrión de los Céspedes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6092, 41, 'Casariche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6093, 41, 'Castilblanco de los Arroyos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6094, 41, 'Castilleja de Guzmán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6095, 41, 'Castilleja de la Cuesta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6096, 41, 'Castilleja del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6097, 41, 'Castillo de las Guardas (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6098, 41, 'Cazalla de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6063, 40, 'Yanguas de Eresma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6064, 40, 'Zarzuela del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6065, 40, 'Zarzuela del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6066, 41, 'Aguadulce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6067, 41, 'Alanís'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6068, 41, 'Albaida del Aljarafe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6069, 41, 'Alcalá de Guadaíra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6070, 41, 'Alcalá del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6071, 41, 'Alcolea del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6072, 41, 'Algaba (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6073, 41, 'Algámitas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6074, 41, 'Almadén de la Plata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6075, 41, 'Almensilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6076, 41, 'Arahal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6077, 41, 'Aznalcázar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6078, 41, 'Aznalcóllar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6079, 41, 'Badolatosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6080, 41, 'Benacazón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6099, 41, 'Constantina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6100, 41, 'Coria del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6101, 41, 'Coripe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6102, 41, 'Coronil (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6103, 41, 'Corrales (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6104, 41, 'Cuervo de Sevilla (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6105, 41, 'Dos Hermanas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6106, 41, 'Écija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6107, 41, 'Espartinas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6108, 41, 'Estepa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6109, 41, 'Fuentes de Andalucía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6110, 41, 'Garrobo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6111, 41, 'Gelves'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6112, 41, 'Gerena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6113, 41, 'Gilena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6114, 41, 'Gines'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6115, 41, 'Guadalcanal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6116, 41, 'Guillena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6117, 41, 'Herrera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6154, 41, 'San Juan de Aznalfarache'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6136, 41, 'Osuna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6137, 41, 'Palacios y Villafranca (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6138, 41, 'Palomares del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6139, 41, 'Paradas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6140, 41, 'Pedrera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6141, 41, 'Pedroso (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6142, 41, 'Peñaflor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6143, 41, 'Pilas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6144, 41, 'Pruna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6145, 41, 'Puebla de Cazalla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6146, 41, 'Puebla de los Infantes (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6147, 41, 'Puebla del Río (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6148, 41, 'Real de la Jara (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6149, 41, 'Rinconada (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6150, 41, 'Roda de Andalucía (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6151, 41, 'Ronquillo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6152, 41, 'Rubio (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6153, 41, 'Salteras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6118, 41, 'Huévar del Aljarafe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6119, 41, 'Isla Mayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6120, 41, 'Lantejuela (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6121, 41, 'Lebrija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6122, 41, 'Lora de Estepa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6123, 41, 'Lora del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6124, 41, 'Luisiana (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6125, 41, 'Madroño (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6126, 41, 'Mairena del Alcor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6127, 41, 'Mairena del Aljarafe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6128, 41, 'Marchena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6129, 41, 'Marinaleda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6130, 41, 'Martín de la Jara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6131, 41, 'Molares (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6132, 41, 'Montellano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6133, 41, 'Morón de la Frontera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6134, 41, 'Navas de la Concepción (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6135, 41, 'Olivares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6155, 41, 'San Nicolás del Puerto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6156, 41, 'Sanlúcar la Mayor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6157, 41, 'Santiponce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6158, 41, 'Saucejo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6159, 41, 'Sevilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6160, 41, 'Tocina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6161, 41, 'Tomares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6162, 41, 'Umbrete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6163, 41, 'Utrera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6164, 41, 'Valencina de la Concepción'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6165, 41, 'Villamanrique de la Condesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6166, 41, 'Villanueva de San Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6167, 41, 'Villanueva del Ariscal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6168, 41, 'Villanueva del Río y Minas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6169, 41, 'Villaverde del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6170, 41, 'Viso del Alcor (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6171, 42, 'Abejar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6172, 42, 'Adradas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6211, 42, 'Cabrejas del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6192, 42, 'Arancón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6193, 42, 'Arcos de Jalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6194, 42, 'Arenillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6195, 42, 'Arévalo de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6196, 42, 'Ausejo de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6197, 42, 'Baraona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6198, 42, 'Barca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6199, 42, 'Barcones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6200, 42, 'Bayubas de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6201, 42, 'Bayubas de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6202, 42, 'Beratón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6203, 42, 'Berlanga de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6204, 42, 'Blacos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6205, 42, 'Bliecos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6206, 42, 'Borjabad'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6207, 42, 'Borobia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6208, 42, 'Buberos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6209, 42, 'Buitrago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6210, 42, 'Burgo de Osma-Ciudad de Osma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6173, 42, 'Ágreda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6174, 42, 'Alconaba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6175, 42, 'Alcubilla de Avellaneda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6176, 42, 'Alcubilla de las Peñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6177, 42, 'Aldealafuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6178, 42, 'Aldealices'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6179, 42, 'Aldealpozo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6180, 42, 'Aldealseñor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6181, 42, 'Aldehuela de Periáñez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6182, 42, 'Aldehuelas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6183, 42, 'Alentisque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6184, 42, 'Aliud'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6185, 42, 'Almajano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6186, 42, 'Almaluez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6187, 42, 'Almarza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6188, 42, 'Almazán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6189, 42, 'Almazul'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6190, 42, 'Almenar de Soria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6191, 42, 'Alpanseque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6212, 42, 'Cabrejas del Pinar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6213, 42, 'Calatañazor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6214, 42, 'Caltojar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6215, 42, 'Candilichera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6216, 42, 'Cañamaque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6217, 42, 'Carabantes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6218, 42, 'Caracena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6219, 42, 'Carrascosa de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6220, 42, 'Carrascosa de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6221, 42, 'Casarejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6222, 42, 'Castilfrío de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6223, 42, 'Castillejo de Robledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6224, 42, 'Castilruiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6225, 42, 'Centenera de Andaluz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6226, 42, 'Cerbón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6227, 42, 'Cidones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6228, 42, 'Cigudosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6229, 42, 'Cihuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6230, 42, 'Ciria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6268, 42, 'Miño de Medinaceli'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6249, 42, 'Fuentelmonge'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6250, 42, 'Fuentelsaz de Soria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6251, 42, 'Fuentepinilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6252, 42, 'Fuentes de Magaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6253, 42, 'Fuentestrún'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6254, 42, 'Garray'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6255, 42, 'Golmayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6256, 42, 'Gómara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6257, 42, 'Gormaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6258, 42, 'Herrera de Soria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6259, 42, 'Hinojosa del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6260, 42, 'Langa de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6261, 42, 'Liceras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6262, 42, 'Losilla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6263, 42, 'Magaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6264, 42, 'Maján'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6265, 42, 'Matalebreras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6266, 42, 'Matamala de Almazán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6267, 42, 'Medinaceli'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6231, 42, 'Cirujales del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6232, 42, 'Coscurita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6233, 42, 'Covaleda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6234, 42, 'Cubilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6235, 42, 'Cubo de la Solana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6236, 42, 'Cueva de Ágreda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6237, 42, 'Dévanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6238, 42, 'Deza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6239, 42, 'Duruelo de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6240, 42, 'Escobosa de Almazán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6241, 42, 'Espeja de San Marcelino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6242, 42, 'Espejón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6243, 42, 'Estepa de San Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6244, 42, 'Frechilla de Almazán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6245, 42, 'Fresno de Caracena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6246, 42, 'Fuentearmegil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6247, 42, 'Fuentecambrón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6248, 42, 'Fuentecantos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6269, 42, 'Miño de San Esteban'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6270, 42, 'Molinos de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6271, 42, 'Momblona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6272, 42, 'Monteagudo de las Vicarías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6273, 42, 'Montejo de Tiermes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6274, 42, 'Montenegro de Cameros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6275, 42, 'Morón de Almazán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6276, 42, 'Muriel de la Fuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6277, 42, 'Muriel Viejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6278, 42, 'Nafría de Ucero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6279, 42, 'Narros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6280, 42, 'Navaleno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6281, 42, 'Nepas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6282, 42, 'Nolay'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6283, 42, 'Noviercas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6284, 42, 'Ólvega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6285, 42, 'Oncala'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6286, 42, 'Pinilla del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6287, 42, 'Portillo de Soria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6307, 42, 'San Leonardo de Yagüe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6308, 42, 'San Pedro Manrique'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6309, 42, 'Santa Cruz de Yanguas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6310, 42, 'Santa María de Huerta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6311, 42, 'Santa María de las Hoyas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6312, 42, 'Serón de Nágima'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6313, 42, 'Soliedra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6314, 42, 'Soria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6315, 42, 'Sotillo del Rincón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6316, 42, 'Suellacabras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6317, 42, 'Tajahuerce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6318, 42, 'Tajueco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6319, 42, 'Talveila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6320, 42, 'Tardelcuende'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6321, 42, 'Taroda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6322, 42, 'Tejado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6323, 42, 'Torlengua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6324, 42, 'Torreblacos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6288, 42, 'Póveda de Soria (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6289, 42, 'Pozalmuro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6290, 42, 'Quintana Redonda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6291, 42, 'Quintanas de Gormaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6292, 42, 'Quiñonería'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6293, 42, 'Rábanos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6294, 42, 'Rebollar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6295, 42, 'Recuerda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6296, 42, 'Rello'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6297, 42, 'Renieblas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6298, 42, 'Retortillo de Soria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6299, 42, 'Reznos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6300, 42, 'Riba de Escalote (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6301, 42, 'Rioseco de Soria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6302, 42, 'Rollamienta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6303, 42, 'Royo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6304, 42, 'Salduero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6305, 42, 'San Esteban de Gormaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6306, 42, 'San Felices'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6325, 42, 'Torrubia de Soria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6326, 42, 'Trévago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6327, 42, 'Ucero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6328, 42, 'Vadillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6329, 42, 'Valdeavellano de Tera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6330, 42, 'Valdegeña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6331, 42, 'Valdelagua del Cerro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6332, 42, 'Valdemaluque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6333, 42, 'Valdenebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6334, 42, 'Valdeprado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6335, 42, 'Valderrodilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6336, 42, 'Valtajeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6337, 42, 'Velamazán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6338, 42, 'Velilla de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6339, 42, 'Velilla de los Ajos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6340, 42, 'Viana de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6341, 42, 'Villaciervos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6342, 42, 'Villanueva de Gormaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6343, 42, 'Villar del Ala'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6382, 43, 'Bisbal de Falset (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6363, 43, 'Alforja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6364, 43, 'Alió'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6365, 43, 'Almoster'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6366, 43, 'Altafulla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6367, 43, 'Ametlla de Mar (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6368, 43, 'Ampolla (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6369, 43, 'Amposta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6370, 43, 'Arboç (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6371, 43, 'Arbolí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6372, 43, 'Argentera (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6373, 43, 'Arnes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6374, 43, 'Ascó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6375, 43, 'Banyeres del Penedès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6376, 43, 'Barberà de la Conca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6377, 43, 'Batea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6378, 43, 'Bellmunt del Priorat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6379, 43, 'Bellvei'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6380, 43, 'Benifallet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6381, 43, 'Benissanet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6344, 42, 'Villar del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6345, 42, 'Villar del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6346, 42, 'Villares de Soria (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6347, 42, 'Villasayas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6348, 42, 'Villaseca de Arciel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6349, 42, 'Vinuesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6350, 42, 'Vizmanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6351, 42, 'Vozmediano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6352, 42, 'Yanguas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6353, 42, 'Yelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6354, 43, 'Aiguamúrcia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6355, 43, 'Albinyana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6356, 43, 'Albiol (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6357, 43, 'Alcanar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6358, 43, 'Alcover'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6359, 43, 'Aldea (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6360, 43, 'Aldover'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6361, 43, 'Aleixar (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6362, 43, 'Alfara de Carles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6383, 43, 'Bisbal del Penedès (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6384, 43, 'Blancafort'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6385, 43, 'Bonastre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6386, 43, 'Borges del Camp (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6387, 43, 'Bot'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6388, 43, 'Botarell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6389, 43, 'Bràfim'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6390, 43, 'Cabacés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6391, 43, 'Cabra del Camp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6392, 43, 'Calafell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6393, 43, 'Camarles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6394, 43, 'Cambrils'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6395, 43, 'Capafonts'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6396, 43, 'Capçanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6397, 43, 'Caseres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6398, 43, 'Castellvell del Camp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6399, 43, 'Catllar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6400, 43, 'Colldejou'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6401, 43, 'Conesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6440, 43, 'Molar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6441, 43, 'Montblanc'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6442, 43, 'Montbrió del Camp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6421, 43, 'Garidells (Els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6422, 43, 'Ginestar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6423, 43, 'Godall'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6424, 43, 'Gratallops'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6425, 43, 'Guiamets (Els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6426, 43, 'Horta de Sant Joan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6427, 43, 'Lloar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6428, 43, 'Llorac'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6429, 43, 'Llorenç del Penedès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6430, 43, 'Marçà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6431, 43, 'Margalef'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6432, 43, 'Mas de Barberans'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6433, 43, 'Masdenverge'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6434, 43, 'Masllorenç'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6435, 43, 'Masó (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6436, 43, 'Maspujols'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6437, 43, 'Masroig (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6438, 43, 'Milà (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6439, 43, 'Miravet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6402, 43, 'Constantí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6403, 43, 'Corbera d''Ebre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6404, 43, 'Cornudella de Montsant'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6405, 43, 'Creixell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6406, 43, 'Cunit'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6407, 43, 'Deltebre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6408, 43, 'Duesaigües'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6409, 43, 'Espluga de Francolí (L'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6410, 43, 'Falset'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6411, 43, 'Fatarella (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6412, 43, 'Febró (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6413, 43, 'Figuera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6414, 43, 'Figuerola del Camp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6415, 43, 'Flix'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6416, 43, 'Forès'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6417, 43, 'Freginals'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6418, 43, 'Galera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6419, 43, 'Gandesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6420, 43, 'Garcia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6443, 43, 'Montferri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6444, 43, 'Montmell (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6445, 43, 'Mont-ral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6446, 43, 'Mont-roig del Camp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6447, 43, 'Móra d''Ebre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6448, 43, 'Móra la Nova'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6449, 43, 'Morell (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6450, 43, 'Morera de Montsant (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6451, 43, 'Nou de Gaià (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6452, 43, 'Nulles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6453, 43, 'Pallaresos (Els)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6454, 43, 'Palma d''Ebre (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6455, 43, 'Passanant i Belltall'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6456, 43, 'Paüls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6457, 43, 'Perafort'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6458, 43, 'Perelló (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6459, 43, 'Piles (Les)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6460, 43, 'Pinell de Brai (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6461, 43, 'Pira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6481, 43, 'Riera de Gaià (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6482, 43, 'Riudecanyes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6483, 43, 'Riudecols'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6484, 43, 'Riudoms'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6485, 43, 'Rocafort de Queralt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6486, 43, 'Roda de Barà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6487, 43, 'Rodonyà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6488, 43, 'Roquetes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6489, 43, 'Rourell (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6490, 43, 'Salomó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6491, 43, 'Salou'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6492, 43, 'Sant Carles de la Ràpita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6493, 43, 'Sant Jaume dels Domenys'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6494, 43, 'Sant Jaume d''Enveja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6495, 43, 'Santa Bàrbara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6496, 43, 'Santa Coloma de Queralt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6497, 43, 'Santa Oliva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6498, 43, 'Sarral'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6462, 43, 'Pla de Santa Maria (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6463, 43, 'Pobla de Mafumet (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6464, 43, 'Pobla de Massaluca (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6465, 43, 'Pobla de Montornès (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6466, 43, 'Poboleda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6467, 43, 'Pont d''Armentera (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6468, 43, 'Pontils'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6469, 43, 'Porrera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6470, 43, 'Pradell de la Teixeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6471, 43, 'Prades'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6472, 43, 'Prat de Comte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6473, 43, 'Pratdip'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6474, 43, 'Puigpelat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6475, 43, 'Querol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6476, 43, 'Rasquera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6477, 43, 'Renau'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6478, 43, 'Reus'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6479, 43, 'Riba (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6480, 43, 'Riba-roja d''Ebre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6499, 43, 'Savallà del Comtat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6500, 43, 'Secuita (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6501, 43, 'Selva del Camp (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6502, 43, 'Senan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6503, 43, 'Sénia (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6504, 43, 'Solivella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6505, 43, 'Tarragona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6506, 43, 'Tivenys'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6507, 43, 'Tivissa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6508, 43, 'Torre de Fontaubella (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6509, 43, 'Torre de l''Espanyol (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6510, 43, 'Torredembarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6511, 43, 'Torroja del Priorat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6512, 43, 'Tortosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6513, 43, 'Ulldecona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6514, 43, 'Ulldemolins'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6515, 43, 'Vallclara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6516, 43, 'Vallfogona de Riucorb'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6517, 43, 'Vallmoll'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6555, 44, 'Allueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6556, 44, 'Almohaja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6536, 43, 'Xerta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6537, 44, 'Ababuj'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6538, 44, 'Abejuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6539, 44, 'Aguatón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6540, 44, 'Aguaviva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6541, 44, 'Aguilar del Alfambra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6542, 44, 'Alacón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6543, 44, 'Alba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6544, 44, 'Albalate del Arzobispo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6545, 44, 'Albarracín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6546, 44, 'Albentosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6547, 44, 'Alcaine'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6548, 44, 'Alcalá de la Selva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6549, 44, 'Alcañiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6550, 44, 'Alcorisa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6551, 44, 'Alfambra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6552, 44, 'Aliaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6553, 44, 'Allepuz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6554, 44, 'Alloza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6518, 43, 'Valls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6519, 43, 'Vandellòs i l''Hospitalet de l''Infant'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6520, 43, 'Vendrell (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6521, 43, 'Vespella de Gaià'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6522, 43, 'Vilabella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6523, 43, 'Vilalba dels Arcs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6524, 43, 'Vilallonga del Camp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6525, 43, 'Vilanova de Prades'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6526, 43, 'Vilanova d''Escornalbou'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6527, 43, 'Vilaplana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6528, 43, 'Vila-rodona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6529, 43, 'Vila-seca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6530, 43, 'Vilaverd'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6531, 43, 'Vilella Alta (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6532, 43, 'Vilella Baixa (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6533, 43, 'Vimbodí i Poblet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6534, 43, 'Vinebre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6535, 43, 'Vinyols i els Arcs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6557, 44, 'Alobras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6558, 44, 'Alpeñés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6559, 44, 'Anadón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6560, 44, 'Andorra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6561, 44, 'Arcos de las Salinas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6562, 44, 'Arens de Lledó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6563, 44, 'Argente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6564, 44, 'Ariño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6565, 44, 'Azaila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6566, 44, 'Bádenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6567, 44, 'Báguena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6568, 44, 'Bañón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6569, 44, 'Barrachina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6570, 44, 'Bea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6571, 44, 'Beceite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6572, 44, 'Bello'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6573, 44, 'Belmonte de San José'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6574, 44, 'Berge'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6575, 44, 'Bezas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6614, 44, 'Cubla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6615, 44, 'Cucalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6616, 44, 'Cuervo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6617, 44, 'Cuevas de Almudén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6595, 44, 'Cañizar del Olivar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6596, 44, 'Cascante del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6597, 44, 'Castejón de Tornos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6598, 44, 'Castel de Cabra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6599, 44, 'Castellar (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6600, 44, 'Castellote'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6601, 44, 'Castelnou'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6602, 44, 'Castelserás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6603, 44, 'Cedrillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6604, 44, 'Celadas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6605, 44, 'Cella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6606, 44, 'Cerollera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6607, 44, 'Codoñera (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6608, 44, 'Corbalán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6609, 44, 'Cortes de Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6610, 44, 'Cosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6611, 44, 'Cretas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6612, 44, 'Crivillén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6613, 44, 'Cuba (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6576, 44, 'Blancas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6577, 44, 'Blesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6578, 44, 'Bordón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6579, 44, 'Bronchales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6580, 44, 'Bueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6581, 44, 'Burbáguena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6582, 44, 'Cabra de Mora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6583, 44, 'Calaceite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6584, 44, 'Calamocha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6585, 44, 'Calanda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6586, 44, 'Calomarde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6587, 44, 'Camañas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6588, 44, 'Camarena de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6589, 44, 'Camarillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6590, 44, 'Caminreal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6591, 44, 'Cantavieja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6592, 44, 'Cañada de Benatanduz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6593, 44, 'Cañada de Verich (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6594, 44, 'Cañada Vellida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6618, 44, 'Cuevas Labradas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6619, 44, 'Ejulve'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6620, 44, 'Escorihuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6621, 44, 'Escucha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6622, 44, 'Estercuel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6623, 44, 'Ferreruela de Huerva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6624, 44, 'Fonfría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6625, 44, 'Formiche Alto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6626, 44, 'Fórnoles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6627, 44, 'Fortanete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6628, 44, 'Foz-Calanda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6629, 44, 'Fresneda (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6630, 44, 'Frías de Albarracín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6631, 44, 'Fuenferrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6632, 44, 'Fuentes Calientes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6633, 44, 'Fuentes Claras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6634, 44, 'Fuentes de Rubielos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6635, 44, 'Fuentespalda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6636, 44, 'Galve'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6675, 44, 'Monterde de Albarracín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6656, 44, 'Lidón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6657, 44, 'Linares de Mora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6658, 44, 'Lledó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6659, 44, 'Loscos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6660, 44, 'Maicas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6661, 44, 'Manzanera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6662, 44, 'Martín del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6663, 44, 'Mas de las Matas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6664, 44, 'Mata de los Olmos (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6665, 44, 'Mazaleón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6666, 44, 'Mezquita de Jarque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6667, 44, 'Mirambel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6668, 44, 'Miravete de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6669, 44, 'Molinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6670, 44, 'Monforte de Moyuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6671, 44, 'Monreal del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6672, 44, 'Monroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6673, 44, 'Montalbán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6674, 44, 'Monteagudo del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6637, 44, 'Gargallo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6638, 44, 'Gea de Albarracín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6639, 44, 'Ginebrosa (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6640, 44, 'Griegos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6641, 44, 'Guadalaviar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6642, 44, 'Gúdar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6643, 44, 'Híjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6644, 44, 'Hinojosa de Jarque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6645, 44, 'Hoz de la Vieja (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6646, 44, 'Huesa del Común'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6647, 44, 'Iglesuela del Cid (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6648, 44, 'Jabaloyas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6649, 44, 'Jarque de la Val'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6650, 44, 'Jatiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6651, 44, 'Jorcas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6652, 44, 'Josa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6653, 44, 'Lagueruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6654, 44, 'Lanzuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6655, 44, 'Libros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6676, 44, 'Mora de Rubielos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6677, 44, 'Moscardón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6678, 44, 'Mosqueruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6679, 44, 'Muniesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6680, 44, 'Noguera de Albarracín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6681, 44, 'Nogueras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6682, 44, 'Nogueruelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6683, 44, 'Obón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6684, 44, 'Odón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6685, 44, 'Ojos Negros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6686, 44, 'Olba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6687, 44, 'Oliete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6688, 44, 'Olmos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6689, 44, 'Orihuela del Tremedal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6690, 44, 'Orrios'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6691, 44, 'Palomar de Arroyos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6692, 44, 'Pancrudo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6693, 44, 'Parras de Castellote (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6694, 44, 'Peñarroya de Tastavins'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6733, 44, 'Torre de las Arcas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6714, 44, 'Rubielos de Mora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6715, 44, 'Salcedillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6716, 44, 'Saldón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6717, 44, 'Samper de Calanda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6718, 44, 'San Agustín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6719, 44, 'San Martín del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6720, 44, 'Santa Cruz de Nogueras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6721, 44, 'Santa Eulalia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6722, 44, 'Sarrión'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6723, 44, 'Segura de los Baños'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6724, 44, 'Seno'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6725, 44, 'Singra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6726, 44, 'Terriente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6727, 44, 'Teruel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6728, 44, 'Toril y Masegoso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6729, 44, 'Tormón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6730, 44, 'Tornos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6731, 44, 'Torralba de los Sisones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6732, 44, 'Torre de Arcas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6695, 44, 'Peracense'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6696, 44, 'Peralejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6697, 44, 'Perales del Alfambra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6698, 44, 'Pitarque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6699, 44, 'Plou'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6700, 44, 'Pobo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6701, 44, 'Portellada (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6702, 44, 'Pozondón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6703, 44, 'Pozuel del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6704, 44, 'Puebla de Híjar (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6705, 44, 'Puebla de Valverde (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6706, 44, 'Puertomingalvo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6707, 44, 'Ráfales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6708, 44, 'Rillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6709, 44, 'Riodeva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6710, 44, 'Ródenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6711, 44, 'Royuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6712, 44, 'Rubiales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6713, 44, 'Rubielos de la Cérida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6734, 44, 'Torre del Compte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6735, 44, 'Torre los Negros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6736, 44, 'Torrecilla de Alcañiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6737, 44, 'Torrecilla del Rebollar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6738, 44, 'Torrelacárcel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6739, 44, 'Torremocha de Jiloca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6740, 44, 'Torres de Albarracín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6741, 44, 'Torrevelilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6742, 44, 'Torrijas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6743, 44, 'Torrijo del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6744, 44, 'Tramacastiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6745, 44, 'Tramacastilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6746, 44, 'Tronchón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6747, 44, 'Urrea de Gaén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6748, 44, 'Utrillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6749, 44, 'Valacloche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6750, 44, 'Valbona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6751, 44, 'Valdealgorfa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6770, 44, 'Visiedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6771, 44, 'Vivel del Río Martín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6772, 44, 'Zoma (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6773, 45, 'Ajofrín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6774, 45, 'Alameda de la Sagra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6775, 45, 'Albarreal de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6776, 45, 'Alcabón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6777, 45, 'Alcañizo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6778, 45, 'Alcaudete de la Jara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6779, 45, 'Alcolea de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6780, 45, 'Aldea en Cabo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6781, 45, 'Aldeanueva de Barbarroya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6782, 45, 'Aldeanueva de San Bartolomé'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6783, 45, 'Almendral de la Cañada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6784, 45, 'Almonacid de Toledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6785, 45, 'Almorox'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6786, 45, 'Añover de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6787, 45, 'Arcicóllar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6752, 44, 'Valdecuenca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6753, 44, 'Valdelinares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6754, 44, 'Valdeltormo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6755, 44, 'Valderrobres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6756, 44, 'Valjunquera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6757, 44, 'Vallecillo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6758, 44, 'Veguillas de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6759, 44, 'Villafranca del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6760, 44, 'Villahermosa del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6761, 44, 'Villanueva del Rebollar de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6762, 44, 'Villar del Cobo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6763, 44, 'Villar del Salz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6764, 44, 'Villarluengo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6765, 44, 'Villarquemado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6766, 44, 'Villarroya de los Pinares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6767, 44, 'Villastar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6768, 44, 'Villel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6769, 44, 'Vinaceite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6788, 45, 'Argés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6789, 45, 'Azután'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6790, 45, 'Barcience'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6791, 45, 'Bargas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6792, 45, 'Belvís de la Jara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6793, 45, 'Borox'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6794, 45, 'Buenaventura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6795, 45, 'Burguillos de Toledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6796, 45, 'Burujón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6797, 45, 'Cabañas de la Sagra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6798, 45, 'Cabañas de Yepes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6799, 45, 'Cabezamesada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6800, 45, 'Calera y Chozas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6801, 45, 'Caleruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6802, 45, 'Calzada de Oropesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6803, 45, 'Camarena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6804, 45, 'Camarenilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6805, 45, 'Campillo de la Jara (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6806, 45, 'Camuñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6844, 45, 'Herreruela de Oropesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6825, 45, 'Cobisa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6826, 45, 'Consuegra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6827, 45, 'Corral de Almaguer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6828, 45, 'Cuerva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6829, 45, 'Domingo Pérez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6830, 45, 'Dosbarrios'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6831, 45, 'Erustes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6832, 45, 'Escalona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6833, 45, 'Escalonilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6834, 45, 'Espinoso del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6835, 45, 'Esquivias'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6836, 45, 'Estrella (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6837, 45, 'Fuensalida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6838, 45, 'Gálvez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6839, 45, 'Garciotum'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6840, 45, 'Gerindote'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6841, 45, 'Guadamur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6842, 45, 'Guardia (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6843, 45, 'Herencias (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6807, 45, 'Cardiel de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6808, 45, 'Carmena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6809, 45, 'Carpio de Tajo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6810, 45, 'Carranque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6811, 45, 'Carriches'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6812, 45, 'Casar de Escalona (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6813, 45, 'Casarrubios del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6814, 45, 'Casasbuenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6815, 45, 'Castillo de Bayuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6816, 45, 'Cazalegas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6817, 45, 'Cebolla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6818, 45, 'Cedillo del Condado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6819, 45, 'Cerralbos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6820, 45, 'Cervera de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6821, 45, 'Chozas de Canales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6822, 45, 'Chueca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6823, 45, 'Ciruelos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6824, 45, 'Cobeja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6845, 45, 'Hinojosa de San Vicente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6846, 45, 'Hontanar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6847, 45, 'Hormigos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6848, 45, 'Huecas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6849, 45, 'Huerta de Valdecarábanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6850, 45, 'Iglesuela (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6851, 45, 'Illán de Vacas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6852, 45, 'Illescas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6853, 45, 'Lagartera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6854, 45, 'Layos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6855, 45, 'Lillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6856, 45, 'Lominchar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6857, 45, 'Lucillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6858, 45, 'Madridejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6859, 45, 'Magán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6860, 45, 'Malpica de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6861, 45, 'Manzaneque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6862, 45, 'Maqueda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6863, 45, 'Marjaliza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6902, 45, 'Pelahustán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6903, 45, 'Pepino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6904, 45, 'Polán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6883, 45, 'Navalmorales (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6884, 45, 'Navalucillos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6885, 45, 'Navamorcuende'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6886, 45, 'Noblejas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6887, 45, 'Noez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6888, 45, 'Nombela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6889, 45, 'Novés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6890, 45, 'Numancia de la Sagra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6891, 45, 'Nuño Gómez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6892, 45, 'Ocaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6893, 45, 'Olías del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6894, 45, 'Ontígola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6895, 45, 'Orgaz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6896, 45, 'Oropesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6897, 45, 'Otero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6898, 45, 'Palomeque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6899, 45, 'Pantoja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6900, 45, 'Paredes de Escalona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6901, 45, 'Parrillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6864, 45, 'Marrupe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6865, 45, 'Mascaraque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6866, 45, 'Mata (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6867, 45, 'Mazarambroz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6868, 45, 'Mejorada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6869, 45, 'Menasalbas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6870, 45, 'Méntrida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6871, 45, 'Mesegar de Tajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6872, 45, 'Miguel Esteban'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6873, 45, 'Mocejón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6874, 45, 'Mohedas de la Jara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6875, 45, 'Montearagón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6876, 45, 'Montesclaros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6877, 45, 'Mora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6878, 45, 'Nambroca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6879, 45, 'Nava de Ricomalillo (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6880, 45, 'Navahermosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6881, 45, 'Navalcán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6882, 45, 'Navalmoralejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6905, 45, 'Portillo de Toledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6906, 45, 'Puebla de Almoradiel (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6907, 45, 'Puebla de Montalbán (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6908, 45, 'Pueblanueva (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6909, 45, 'Puente del Arzobispo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6910, 45, 'Puerto de San Vicente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6911, 45, 'Pulgar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6912, 45, 'Quero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6913, 45, 'Quintanar de la Orden'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6914, 45, 'Quismondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6915, 45, 'Real de San Vicente (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6916, 45, 'Recas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6917, 45, 'Retamoso de la Jara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6918, 45, 'Rielves'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6919, 45, 'Robledo del Mazo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6920, 45, 'Romeral (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6921, 45, 'San Bartolomé de las Abiertas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6922, 45, 'San Martín de Montalbán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6941, 45, 'Torralba de Oropesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6942, 45, 'Torre de Esteban Hambrán (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6943, 45, 'Torrecilla de la Jara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6944, 45, 'Torrico'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6945, 45, 'Torrijos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6946, 45, 'Totanés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6947, 45, 'Turleque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6948, 45, 'Ugena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6949, 45, 'Urda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6950, 45, 'Valdeverdeja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6951, 45, 'Valmojado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6952, 45, 'Velada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6953, 45, 'Ventas con Peña Aguilera (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6954, 45, 'Ventas de Retamosa (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6955, 45, 'Ventas de San Julián (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6956, 45, 'Villa de Don Fadrique (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6923, 45, 'San Martín de Pusa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6924, 45, 'San Pablo de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6925, 45, 'San Román de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6926, 45, 'Santa Ana de Pusa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6927, 45, 'Santa Cruz de la Zarza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6928, 45, 'Santa Cruz del Retamar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6929, 45, 'Santa Olalla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6930, 45, 'Santo Domingo-Caudilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6931, 45, 'Sartajada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6932, 45, 'Segurilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6933, 45, 'Seseña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6934, 45, 'Sevilleja de la Jara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6935, 45, 'Sonseca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6936, 45, 'Sotillo de las Palomas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6937, 45, 'Talavera de la Reina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6938, 45, 'Tembleque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6939, 45, 'Toboso (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6940, 45, 'Toledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6957, 45, 'Villacañas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6958, 45, 'Villafranca de los Caballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6959, 45, 'Villaluenga de la Sagra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6960, 45, 'Villamiel de Toledo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6961, 45, 'Villaminaya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6962, 45, 'Villamuelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6963, 45, 'Villanueva de Alcardete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6964, 45, 'Villanueva de Bogas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6965, 45, 'Villarejo de Montalbán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6966, 45, 'Villarrubia de Santiago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6967, 45, 'Villaseca de la Sagra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6968, 45, 'Villasequilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6969, 45, 'Villatobas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6970, 45, 'Viso de San Juan (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6971, 45, 'Yébenes (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6972, 45, 'Yeles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6973, 45, 'Yepes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6974, 45, 'Yuncler'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6994, 46, 'Alcublas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6995, 46, 'Alcúdia (l'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6996, 46, 'Alcúdia de Crespins (l'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6997, 46, 'Aldaia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6998, 46, 'Alfafar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6999, 46, 'Alfara de Algimia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7000, 46, 'Alfara del Patriarca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7001, 46, 'Alfarp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7002, 46, 'Alfarrasí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7003, 46, 'Alfauir'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7004, 46, 'Algar de Palancia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7005, 46, 'Algemesí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7006, 46, 'Algimia de Alfara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7007, 46, 'Alginet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7008, 46, 'Almàssera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7009, 46, 'Almiserà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7010, 46, 'Almoines'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7011, 46, 'Almussafes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7012, 46, 'Alpuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6975, 45, 'Yunclillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6976, 45, 'Yuncos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6977, 46, 'Ademuz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6978, 46, 'Ador'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6979, 46, 'Agullent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6980, 46, 'Aielo de Malferit'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6981, 46, 'Aielo de Rugat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6982, 46, 'Alaquàs'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6983, 46, 'Albaida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6984, 46, 'Albal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6985, 46, 'Albalat de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6986, 46, 'Albalat dels Sorells'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6987, 46, 'Albalat dels Tarongers'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6988, 46, 'Alberic'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6989, 46, 'Alborache'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6990, 46, 'Alboraya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6991, 46, 'Albuixech'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6992, 46, 'Alcàntera de Xúquer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(6993, 46, 'Alcàsser'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7013, 46, 'Alqueria de la Comtessa (l'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7014, 46, 'Alzira'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7015, 46, 'Andilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7016, 46, 'Anna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7017, 46, 'Antella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7018, 46, 'Aras de los Olmos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7019, 46, 'Atzeneta d''Albaida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7020, 46, 'Ayora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7021, 46, 'Barx'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7022, 46, 'Barxeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7023, 46, 'Bèlgida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7024, 46, 'Bellreguard'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7025, 46, 'Bellús'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7026, 46, 'Benagéber'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7027, 46, 'Benaguasil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7028, 46, 'Benavites'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7029, 46, 'Beneixida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7030, 46, 'Benetússer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7031, 46, 'Beniarjó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7070, 46, 'Catadau'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7071, 46, 'Catarroja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7072, 46, 'Caudete de las Fuentes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7051, 46, 'Bonrepòs i Mirambell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7052, 46, 'Bufali'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7053, 46, 'Bugarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7054, 46, 'Buñol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7055, 46, 'Burjassot'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7056, 46, 'Calles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7057, 46, 'Camporrobles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7058, 46, 'Canals'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7059, 46, 'Canet d''En Berenguer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7060, 46, 'Carcaixent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7061, 46, 'Càrcer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7062, 46, 'Carlet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7063, 46, 'Carrícola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7064, 46, 'Casas Altas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7065, 46, 'Casas Bajas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7066, 46, 'Casinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7067, 46, 'Castelló de Rugat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7068, 46, 'Castellonet de la Conquesta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7069, 46, 'Castielfabib'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7032, 46, 'Beniatjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7033, 46, 'Benicolet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7034, 46, 'Benicull de Xúquer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7035, 46, 'Benifaió'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7036, 46, 'Benifairó de la Valldigna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7037, 46, 'Benifairó de les Valls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7038, 46, 'Beniflá'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7039, 46, 'Benigánim'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7040, 46, 'Benimodo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7041, 46, 'Benimuslem'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7042, 46, 'Beniparrell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7043, 46, 'Benirredrà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7044, 46, 'Benisanó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7045, 46, 'Benissoda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7046, 46, 'Benisuera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7047, 46, 'Bétera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7048, 46, 'Bicorp'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7049, 46, 'Bocairent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7050, 46, 'Bolbaite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7073, 46, 'Cerdà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7074, 46, 'Chella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7075, 46, 'Chelva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7076, 46, 'Chera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7077, 46, 'Cheste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7078, 46, 'Chiva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7079, 46, 'Chulilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7080, 46, 'Cofrentes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7081, 46, 'Corbera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7082, 46, 'Cortes de Pallás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7083, 46, 'Cotes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7084, 46, 'Cullera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7085, 46, 'Daimús'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7086, 46, 'Domeño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7087, 46, 'Dos Aguas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7088, 46, 'Eliana (l'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7089, 46, 'Emperador'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7090, 46, 'Enguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7091, 46, 'Ènova (l'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7092, 46, 'Estivella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7131, 46, 'Marines'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7132, 46, 'Masalavés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7133, 46, 'Massalfassar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7112, 46, 'Guadassuar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7113, 46, 'Guardamar de la Safor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7114, 46, 'Higueruelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7115, 46, 'Jalance'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7116, 46, 'Jarafuel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7117, 46, 'Llanera de Ranes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7118, 46, 'Llaurí'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7119, 46, 'Llíria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7120, 46, 'Llocnou de la Corona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7121, 46, 'Llocnou de Sant Jeroni'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7122, 46, 'Llocnou d''En Fenollet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7123, 46, 'Llombai'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7124, 46, 'Llosa de Ranes (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7125, 46, 'Llutxent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7126, 46, 'Loriguilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7127, 46, 'Losa del Obispo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7128, 46, 'Macastre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7129, 46, 'Manises'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7130, 46, 'Manuel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7093, 46, 'Estubeny'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7094, 46, 'Faura'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7095, 46, 'Favara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7096, 46, 'Foios'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7097, 46, 'Font de la Figuera (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7098, 46, 'Font d''En Carròs (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7099, 46, 'Fontanars dels Alforins'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7100, 46, 'Fortaleny'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7101, 46, 'Fuenterrobles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7102, 46, 'Gandia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7103, 46, 'Gátova'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7104, 46, 'Gavarda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7105, 46, 'Genovés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7106, 46, 'Gestalgar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7107, 46, 'Gilet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7108, 46, 'Godella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7109, 46, 'Godelleta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7110, 46, 'Granja de la Costera (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7111, 46, 'Guadasequies'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7134, 46, 'Massamagrell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7135, 46, 'Massanassa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7136, 46, 'Meliana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7137, 46, 'Millares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7138, 46, 'Miramar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7139, 46, 'Mislata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7140, 46, 'Mogente/Moixent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7141, 46, 'Moncada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7142, 46, 'Montaverner'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7143, 46, 'Montesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7144, 46, 'Montichelvo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7145, 46, 'Montroy'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7146, 46, 'Montserrat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7147, 46, 'Museros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7148, 46, 'Náquera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7149, 46, 'Navarrés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7150, 46, 'Novelé/Novetlè'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7151, 46, 'Oliva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7152, 46, 'Olleria (l'')'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7191, 46, 'Rotglà i Corberà'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7192, 46, 'Rótova'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7193, 46, 'Rugat'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7172, 46, 'Potríes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7173, 46, 'Puçol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7174, 46, 'Puebla de San Miguel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7175, 46, 'Puig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7176, 46, 'Quart de les Valls'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7177, 46, 'Quart de Poblet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7178, 46, 'Quartell'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7179, 46, 'Quatretonda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7180, 46, 'Quesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7181, 46, 'Rafelbuñol/Rafelbunyol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7182, 46, 'Rafelcofer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7183, 46, 'Rafelguaraf'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7184, 46, 'Ráfol de Salem'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7185, 46, 'Real de Gandía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7186, 46, 'Real de Montroi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7187, 46, 'Requena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7188, 46, 'Riba-roja de Túria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7189, 46, 'Riola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7190, 46, 'Rocafort'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7153, 46, 'Olocau'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7154, 46, 'Ontinyent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7155, 46, 'Otos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7156, 46, 'Paiporta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7157, 46, 'Palma de Gandía'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7158, 46, 'Palmera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7159, 46, 'Palomar (el)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7160, 46, 'Paterna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7161, 46, 'Pedralba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7162, 46, 'Petrés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7163, 46, 'Picanya'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7164, 46, 'Picassent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7165, 46, 'Piles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7166, 46, 'Pinet'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7167, 46, 'Pobla de Farnals (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7168, 46, 'Pobla de Vallbona (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7169, 46, 'Pobla del Duc (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7170, 46, 'Pobla Llarga (la)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7171, 46, 'Polinyà de Xúquer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7194, 46, 'Sagunto/Sagunt'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7195, 46, 'Salem'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7196, 46, 'San Antonio de Benagéber'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7197, 46, 'San Juan de Énova'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7198, 46, 'Sedaví'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7199, 46, 'Segart'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7200, 46, 'Sellent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7201, 46, 'Sempere'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7202, 46, 'Senyera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7203, 46, 'Serra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7204, 46, 'Siete Aguas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7205, 46, 'Silla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7206, 46, 'Simat de la Valldigna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7207, 46, 'Sinarcas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7208, 46, 'Sollana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7209, 46, 'Sot de Chera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7210, 46, 'Sueca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7211, 46, 'Sumacàrcer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7212, 46, 'Tavernes Blanques'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7251, 47, 'Amusquillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7252, 47, 'Arroyo de la Encomienda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7253, 47, 'Ataquines'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7232, 46, 'Villanueva de Castellón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7233, 46, 'Villar del Arzobispo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7234, 46, 'Villargordo del Cabriel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7235, 46, 'Vinalesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7236, 46, 'Xàtiva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7237, 46, 'Xeraco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7238, 46, 'Xeresa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7239, 46, 'Xirivella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7240, 46, 'Yátova'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7241, 46, 'Yesa (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7242, 46, 'Zarra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7243, 47, 'Adalia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7244, 47, 'Aguasal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7245, 47, 'Aguilar de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7246, 47, 'Alaejos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7247, 47, 'Alcazarén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7248, 47, 'Aldea de San Miguel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7249, 47, 'Aldeamayor de San Martín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7250, 47, 'Almenara de Adaja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7213, 46, 'Tavernes de la Valldigna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7214, 46, 'Teresa de Cofrentes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7215, 46, 'Terrateig'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7216, 46, 'Titaguas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7217, 46, 'Torrebaja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7218, 46, 'Torrella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7219, 46, 'Torrent'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7220, 46, 'Torres Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7221, 46, 'Tous'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7222, 46, 'Tuéjar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7223, 46, 'Turís'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7224, 46, 'Utiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7225, 46, 'Valencia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7226, 46, 'Vallada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7227, 46, 'Vallanca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7228, 46, 'Vallés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7229, 46, 'Venta del Moro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7230, 46, 'Vilamarxant'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7231, 46, 'Villalonga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7254, 47, 'Bahabón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7255, 47, 'Barcial de la Loma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7256, 47, 'Barruelo del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7257, 47, 'Becilla de Valderaduey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7258, 47, 'Benafarces'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7259, 47, 'Bercero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7260, 47, 'Berceruelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7261, 47, 'Berrueces'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7262, 47, 'Bobadilla del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7263, 47, 'Bocigas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7264, 47, 'Bocos de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7265, 47, 'Boecillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7266, 47, 'Bolaños de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7267, 47, 'Brahojos de Medina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7268, 47, 'Bustillo de Chaves'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7269, 47, 'Cabezón de Pisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7270, 47, 'Cabezón de Valderaduey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7271, 47, 'Cabreros del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7290, 47, 'Ceinos de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7291, 47, 'Cervillego de la Cruz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7292, 47, 'Cigales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7293, 47, 'Ciguñuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7294, 47, 'Cistérniga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7295, 47, 'Cogeces de Íscar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7296, 47, 'Cogeces del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7297, 47, 'Corcos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7298, 47, 'Corrales de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7299, 47, 'Cubillas de Santa Marta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7300, 47, 'Cuenca de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7301, 47, 'Curiel de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7302, 47, 'Encinas de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7303, 47, 'Esguevillas de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7304, 47, 'Fombellida'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7305, 47, 'Fompedraza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7306, 47, 'Fontihoyuelo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7307, 47, 'Fresno el Viejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7272, 47, 'Campaspero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7273, 47, 'Campillo (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7274, 47, 'Camporredondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7275, 47, 'Canalejas de Peñafiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7276, 47, 'Canillas de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7277, 47, 'Carpio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7278, 47, 'Casasola de Arión'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7279, 47, 'Castrejón de Trabancos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7280, 47, 'Castrillo de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7281, 47, 'Castrillo-Tejeriego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7282, 47, 'Castrobol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7283, 47, 'Castrodeza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7284, 47, 'Castromembibre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7285, 47, 'Castromonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7286, 47, 'Castronuevo de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7287, 47, 'Castronuño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7288, 47, 'Castroponce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7289, 47, 'Castroverde de Cerrato'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7308, 47, 'Fuensaldaña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7309, 47, 'Fuente el Sol'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7310, 47, 'Fuente-Olmedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7311, 47, 'Gallegos de Hornija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7312, 47, 'Gatón de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7313, 47, 'Geria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7314, 47, 'Herrín de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7315, 47, 'Hornillos de Eresma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7316, 47, 'Íscar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7317, 47, 'Laguna de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7318, 47, 'Langayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7319, 47, 'Llano de Olmedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7320, 47, 'Lomoviejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7321, 47, 'Manzanillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7322, 47, 'Marzales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7323, 47, 'Matapozuelos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7324, 47, 'Matilla de los Caños'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7325, 47, 'Mayorga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7326, 47, 'Medina de Rioseco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7345, 47, 'Olmedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7346, 47, 'Olmos de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7347, 47, 'Olmos de Peñafiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7348, 47, 'Palazuelo de Vedija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7349, 47, 'Parrilla (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7350, 47, 'Pedraja de Portillo (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7351, 47, 'Pedrajas de San Esteban'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7352, 47, 'Pedrosa del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7353, 47, 'Peñafiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7354, 47, 'Peñaflor de Hornija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7355, 47, 'Pesquera de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7356, 47, 'Piña de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7357, 47, 'Piñel de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7358, 47, 'Piñel de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7359, 47, 'Pollos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7360, 47, 'Portillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7361, 47, 'Pozal de Gallinas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7327, 47, 'Medina del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7328, 47, 'Megeces'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7329, 47, 'Melgar de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7330, 47, 'Melgar de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7331, 47, 'Mojados'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7332, 47, 'Monasterio de Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7333, 47, 'Montealegre de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7334, 47, 'Montemayor de Pililla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7335, 47, 'Moral de la Reina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7336, 47, 'Moraleja de las Panaderas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7337, 47, 'Morales de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7338, 47, 'Mota del Marqués'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7339, 47, 'Mucientes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7340, 47, 'Mudarra (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7341, 47, 'Muriel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7342, 47, 'Nava del Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7343, 47, 'Nueva Villa de las Torres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7344, 47, 'Olivares de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7362, 47, 'Pozaldez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7363, 47, 'Pozuelo de la Orden'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7364, 47, 'Puras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7365, 47, 'Quintanilla de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7366, 47, 'Quintanilla de Onésimo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7367, 47, 'Quintanilla de Trigueros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7368, 47, 'Quintanilla del Molar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7369, 47, 'Rábano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7370, 47, 'Ramiro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7371, 47, 'Renedo de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7372, 47, 'Roales de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7373, 47, 'Robladillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7374, 47, 'Roturas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7375, 47, 'Rubí de Bracamonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7376, 47, 'Rueda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7377, 47, 'Saelices de Mayorga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7378, 47, 'Salvador de Zapardiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7379, 47, 'San Cebrián de Mazote'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7398, 47, 'Simancas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7399, 47, 'Tamariz de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7400, 47, 'Tiedra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7401, 47, 'Tordehumos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7402, 47, 'Tordesillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7403, 47, 'Torre de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7404, 47, 'Torre de Peñafiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7405, 47, 'Torrecilla de la Abadesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7406, 47, 'Torrecilla de la Orden'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7407, 47, 'Torrecilla de la Torre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7408, 47, 'Torrelobatón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7409, 47, 'Torrescárcela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7410, 47, 'Traspinedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7411, 47, 'Trigueros del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7412, 47, 'Tudela de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7413, 47, 'Unión de Campos (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7380, 47, 'San Llorente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7381, 47, 'San Martín de Valvení'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7382, 47, 'San Miguel del Arroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7383, 47, 'San Miguel del Pino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7384, 47, 'San Pablo de la Moraleja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7385, 47, 'San Pedro de Latarce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7386, 47, 'San Pelayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7387, 47, 'San Román de Hornija'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7388, 47, 'San Salvador'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7389, 47, 'San Vicente del Palacio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7390, 47, 'Santa Eufemia del Arroyo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7391, 47, 'Santervás de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7392, 47, 'Santibáñez de Valcorba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7393, 47, 'Santovenia de Pisuerga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7394, 47, 'Sardón de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7395, 47, 'Seca (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7396, 47, 'Serrada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7397, 47, 'Siete Iglesias de Trabancos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7414, 47, 'Urones de Castroponce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7415, 47, 'Urueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7416, 47, 'Valbuena de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7417, 47, 'Valdearcos de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7418, 47, 'Valdenebro de los Valles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7419, 47, 'Valdestillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7420, 47, 'Valdunquillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7421, 47, 'Valladolid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7422, 47, 'Valoria la Buena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7423, 47, 'Valverde de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7424, 47, 'Vega de Ruiponce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7425, 47, 'Vega de Valdetronco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7426, 47, 'Velascálvaro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7427, 47, 'Velilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7428, 47, 'Velliza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7429, 47, 'Ventosa de la Cuesta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7430, 47, 'Viana de Cega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7431, 47, 'Villabáñez'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7450, 47, 'Villán de Tordesillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7451, 47, 'Villanubla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7452, 47, 'Villanueva de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7453, 47, 'Villanueva de la Condesa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7454, 47, 'Villanueva de los Caballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7455, 47, 'Villanueva de los Infantes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7456, 47, 'Villanueva de San Mancio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7457, 47, 'Villardefrades'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7458, 47, 'Villarmentero de Esgueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7459, 47, 'Villasexmir'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7460, 47, 'Villavaquerín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7461, 47, 'Villavellid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7462, 47, 'Villaverde de Medina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7463, 47, 'Villavicencio de los Caballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7464, 47, 'Viloria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7432, 47, 'Villabaruz de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7433, 47, 'Villabrágima'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7434, 47, 'Villacarralón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7435, 47, 'Villacid de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7436, 47, 'Villaco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7437, 47, 'Villafrades de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7438, 47, 'Villafranca de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7439, 47, 'Villafrechós'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7440, 47, 'Villafuerte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7441, 47, 'Villagarcía de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7442, 47, 'Villagómez la Nueva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7443, 47, 'Villalán de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7444, 47, 'Villalar de los Comuneros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7445, 47, 'Villalba de la Loma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7446, 47, 'Villalba de los Alcores'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7447, 47, 'Villalbarba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7448, 47, 'Villalón de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7449, 47, 'Villamuriel de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7465, 47, 'Wamba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7466, 47, 'Zaratán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7467, 47, 'Zarza (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7468, 48, 'Abadiño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7469, 48, 'Abanto y Ciérvana-Abanto Zierbena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7470, 48, 'Ajangiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7471, 48, 'Alonsotegi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7472, 48, 'Amorebieta-Etxano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7473, 48, 'Amoroto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7474, 48, 'Arakaldo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7475, 48, 'Arantzazu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7476, 48, 'Areatza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7477, 48, 'Arrankudiaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7478, 48, 'Arratzu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7479, 48, 'Arrieta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7480, 48, 'Arrigorriaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7481, 48, 'Artea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7482, 48, 'Artzentales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7483, 48, 'Atxondo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7523, 48, 'Ibarrangelu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7524, 48, 'Igorre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7525, 48, 'Ispaster'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7526, 48, 'Iurreta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7527, 48, 'Izurtza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7528, 48, 'Karrantza Harana/Valle de Carranza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7504, 48, 'Ereño'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7505, 48, 'Ermua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7506, 48, 'Errigoiti'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7507, 48, 'Etxebarri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7508, 48, 'Etxebarria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7509, 48, 'Forua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7510, 48, 'Fruiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7511, 48, 'Galdakao'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7512, 48, 'Galdames'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7513, 48, 'Gamiz-Fika'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7514, 48, 'Garai'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7515, 48, 'Gatika'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7516, 48, 'Gautegiz Arteaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7517, 48, 'Gernika-Lumo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7518, 48, 'Getxo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7519, 48, 'Gizaburuaga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7520, 48, 'Gordexola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7521, 48, 'Gorliz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7522, 48, 'Güeñes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7484, 48, 'Aulesti'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7485, 48, 'Bakio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7486, 48, 'Balmaseda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7487, 48, 'Barakaldo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7488, 48, 'Barrika'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7489, 48, 'Basauri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7490, 48, 'Bedia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7491, 48, 'Berango'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7492, 48, 'Bermeo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7493, 48, 'Berriatua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7494, 48, 'Berriz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7495, 48, 'Bilbao'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7496, 48, 'Busturia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7497, 48, 'Derio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7498, 48, 'Dima'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7499, 48, 'Durango'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7500, 48, 'Ea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7501, 48, 'Elantxobe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7502, 48, 'Elorrio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7503, 48, 'Erandio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7529, 48, 'Kortezubi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7530, 48, 'Lanestosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7531, 48, 'Larrabetzu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7532, 48, 'Laukiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7533, 48, 'Leioa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7534, 48, 'Lekeitio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7535, 48, 'Lemoa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7536, 48, 'Lemoiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7537, 48, 'Lezama'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7538, 48, 'Loiu'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7539, 48, 'Mallabia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7540, 48, 'Mañaria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7541, 48, 'Markina-Xemein'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7542, 48, 'Maruri-Jatabe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7543, 48, 'Mendata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7544, 48, 'Mendexa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7545, 48, 'Meñaka'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7546, 48, 'Morga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7547, 48, 'Mundaka'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7548, 48, 'Mungia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7587, 49, 'Andavías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7588, 49, 'Arcenillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7589, 49, 'Arcos de la Polvorosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7590, 49, 'Argañín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7568, 48, 'Ugao-Miraballes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7569, 48, 'Urduliz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7570, 48, 'Urduña-Orduña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7571, 48, 'Valle de Trápaga-Trapagaran'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7572, 48, 'Zaldibar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7573, 48, 'Zalla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7574, 48, 'Zamudio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7575, 48, 'Zaratamo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7576, 48, 'Zeanuri'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7577, 48, 'Zeberio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7578, 48, 'Zierbena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7579, 48, 'Ziortza-Bolibar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7580, 49, 'Abezames'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7581, 49, 'Alcañices'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7582, 49, 'Alcubilla de Nogales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7583, 49, 'Alfaraz de Sayago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7584, 49, 'Algodre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7585, 49, 'Almaraz de Duero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7586, 49, 'Almeida de Sayago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7549, 48, 'Munitibar-Arbatzegi Gerrikaitz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7550, 48, 'Murueta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7551, 48, 'Muskiz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7552, 48, 'Muxika'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7553, 48, 'Nabarniz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7554, 48, 'Ondarroa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7555, 48, 'Orozko'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7556, 48, 'Ortuella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7557, 48, 'Otxandio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7558, 48, 'Plentzia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7559, 48, 'Portugalete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7560, 48, 'Santurtzi'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7561, 48, 'Sestao'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7562, 48, 'Sondika'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7563, 48, 'Sopelana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7564, 48, 'Sopuerta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7565, 48, 'Sukarrieta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7566, 48, 'Trucios-Turtzioz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7567, 48, 'Ubide'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7591, 49, 'Argujillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7592, 49, 'Arquillinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7593, 49, 'Arrabalde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7594, 49, 'Aspariegos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7595, 49, 'Asturianos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7596, 49, 'Ayoó de Vidriales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7597, 49, 'Barcial del Barco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7598, 49, 'Belver de los Montes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7599, 49, 'Benavente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7600, 49, 'Benegiles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7601, 49, 'Bermillo de Sayago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7602, 49, 'Bóveda de Toro (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7603, 49, 'Bretó'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7604, 49, 'Bretocino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7605, 49, 'Brime de Sog'); 
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (7606, 49, 'Brime de Urz');
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (7607, 49, 'Burganes de Valverde'); 
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (7608, 49, 'Bustillo del Oro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7609, 49, 'Cabañas de Sayago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7628, 49, 'Coreses'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7629, 49, 'Corrales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7630, 49, 'Cotanes del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7631, 49, 'Cubillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7632, 49, 'Cubo de Benavente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7633, 49, 'Cubo de Tierra del Vino (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7634, 49, 'Cuelgamures'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7635, 49, 'Entrala'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7636, 49, 'Espadañedo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7637, 49, 'Faramontanos de Tábara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7638, 49, 'Fariza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7639, 49, 'Fermoselle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7640, 49, 'Ferreras de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7641, 49, 'Ferreras de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7642, 49, 'Ferreruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7643, 49, 'Figueruela de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7610, 49, 'Calzadilla de Tera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7611, 49, 'Camarzana de Tera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7612, 49, 'Cañizal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7613, 49, 'Cañizo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7614, 49, 'Carbajales de Alba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7615, 49, 'Carbellino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7616, 49, 'Casaseca de Campeán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7617, 49, 'Casaseca de las Chanas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7618, 49, 'Castrillo de la Guareña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7619, 49, 'Castrogonzalo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7620, 49, 'Castronuevo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7621, 49, 'Castroverde de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7622, 49, 'Cazurra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7623, 49, 'Cerecinos de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7624, 49, 'Cerecinos del Carrizal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7625, 49, 'Cernadilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7626, 49, 'Cobreros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7627, 49, 'Coomonte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7644, 49, 'Fonfría'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7645, 49, 'Fresno de la Polvorosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7646, 49, 'Fresno de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7647, 49, 'Fresno de Sayago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7648, 49, 'Friera de Valverde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7649, 49, 'Fuente Encalada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7650, 49, 'Fuentelapeña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7651, 49, 'Fuentes de Ropel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7652, 49, 'Fuentesaúco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7653, 49, 'Fuentesecas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7654, 49, 'Fuentespreadas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7655, 49, 'Galende'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7656, 49, 'Gallegos del Pan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7657, 49, 'Gallegos del Río'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7658, 49, 'Gamones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7659, 49, 'Gema'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7660, 49, 'Granja de Moreruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7661, 49, 'Granucillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7662, 49, 'Guarrate'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7682, 49, 'Matilla la Seca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7683, 49, 'Mayalde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7684, 49, 'Melgar de Tera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7685, 49, 'Micereces de Tera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7686, 49, 'Milles de la Polvorosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7687, 49, 'Molacillos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7688, 49, 'Molezuelas de la Carballeda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7689, 49, 'Mombuey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7690, 49, 'Monfarracinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7691, 49, 'Montamarta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7692, 49, 'Moral de Sayago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7693, 49, 'Moraleja de Sayago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7694, 49, 'Moraleja del Vino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7695, 49, 'Morales de Rey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7696, 49, 'Morales de Toro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7697, 49, 'Morales de Valverde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7698, 49, 'Morales del Vino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7663, 49, 'Hermisende'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7664, 49, 'Hiniesta (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7665, 49, 'Jambrina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7666, 49, 'Justel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7667, 49, 'Losacino'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7668, 49, 'Losacio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7669, 49, 'Lubián'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7670, 49, 'Luelmo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7671, 49, 'Maderal (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7672, 49, 'Madridanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7673, 49, 'Mahide'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7674, 49, 'Maire de Castroponce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7675, 49, 'Malva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7676, 49, 'Manganeses de la Lampreana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7677, 49, 'Manganeses de la Polvorosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7678, 49, 'Manzanal de Arriba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7679, 49, 'Manzanal de los Infantes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7680, 49, 'Manzanal del Barco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7681, 49, 'Matilla de Arzón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7699, 49, 'Moralina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7700, 49, 'Moreruela de los Infanzones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7701, 49, 'Moreruela de Tábara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7702, 49, 'Muelas de los Caballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7703, 49, 'Muelas del Pan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7704, 49, 'Muga de Sayago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7705, 49, 'Navianos de Valverde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7706, 49, 'Olmillos de Castro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7707, 49, 'Otero de Bodas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7708, 49, 'Pajares de la Lampreana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7709, 49, 'Palacios de Sanabria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7710, 49, 'Palacios del Pan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7711, 49, 'Pedralba de la Pradería'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7712, 49, 'Pego (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7713, 49, 'Peleagonzalo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7714, 49, 'Peleas de Abajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7715, 49, 'Peñausende'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7716, 49, 'Peque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7735, 49, 'Quintanilla del Olmo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7736, 49, 'Quiruelas de Vidriales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7737, 49, 'Rabanales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7738, 49, 'Rábano de Aliste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7739, 49, 'Requejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7740, 49, 'Revellinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7741, 49, 'Riofrío de Aliste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7742, 49, 'Rionegro del Puente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7743, 49, 'Roales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7744, 49, 'Robleda-Cervantes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7745, 49, 'Roelos de Sayago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7746, 49, 'Rosinos de la Requejada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7747, 49, 'Salce'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7748, 49, 'Samir de los Caños'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7749, 49, 'San Agustín del Pozo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7750, 49, 'San Cebrián de Castro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7717, 49, 'Perdigón (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7718, 49, 'Pereruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7719, 49, 'Perilla de Castro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7720, 49, 'Pías'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7721, 49, 'Piedrahita de Castro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7722, 49, 'Pinilla de Toro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7723, 49, 'Pino del Oro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7724, 49, 'Piñero (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7725, 49, 'Pobladura de Valderaduey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7726, 49, 'Pobladura del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7727, 49, 'Porto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7728, 49, 'Pozoantiguo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7729, 49, 'Pozuelo de Tábara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7730, 49, 'Prado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7731, 49, 'Puebla de Sanabria'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7732, 49, 'Pueblica de Valverde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7733, 49, 'Quintanilla de Urz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7734, 49, 'Quintanilla del Monte'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7751, 49, 'San Cristóbal de Entreviñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7752, 49, 'San Esteban del Molar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7753, 49, 'San Justo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7754, 49, 'San Martín de Valderaduey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7755, 49, 'San Miguel de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7756, 49, 'San Miguel del Valle'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7757, 49, 'San Pedro de Ceque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7758, 49, 'San Pedro de la Nave-Almendra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7759, 49, 'San Vicente de la Cabeza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7760, 49, 'San Vitero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7761, 49, 'Santa Clara de Avedillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7762, 49, 'Santa Colomba de las Monjas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7763, 49, 'Santa Cristina de la Polvorosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7764, 49, 'Santa Croya de Tera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7765, 49, 'Santa Eufemia del Barco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7766, 49, 'Santa María de la Vega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7767, 49, 'Santa María de Valverde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7787, 49, 'Vega de Villalobos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7788, 49, 'Vegalatrave'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7789, 49, 'Venialbo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7790, 49, 'Vezdemarbán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7791, 49, 'Vidayanes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7792, 49, 'Videmala'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7793, 49, 'Villabrázaro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7794, 49, 'Villabuena del Puente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7795, 49, 'Villadepera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7796, 49, 'Villaescusa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7797, 49, 'Villafáfila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7798, 49, 'Villaferrueña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7799, 49, 'Villageriz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7800, 49, 'Villalazán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7801, 49, 'Villalba de la Lampreana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7802, 49, 'Villalcampo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7768, 49, 'Santibáñez de Tera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7769, 49, 'Santibáñez de Vidriales'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7770, 49, 'Santovenia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7771, 49, 'Sanzoles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7772, 49, 'Tábara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7773, 49, 'Tapioles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7774, 49, 'Toro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7775, 49, 'Torre del Valle (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7776, 49, 'Torregamones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7777, 49, 'Torres del Carrizal'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7778, 49, 'Trabazos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7779, 49, 'Trefacio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7780, 49, 'Uña de Quintana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7781, 49, 'Vadillo de la Guareña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7782, 49, 'Valcabado'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7783, 49, 'Valdefinjas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7784, 49, 'Valdescorriel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7785, 49, 'Vallesa de la Guareña'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7786, 49, 'Vega de Tera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7803, 49, 'Villalobos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7804, 49, 'Villalonso'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7805, 49, 'Villalpando'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7806, 49, 'Villalube'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7807, 49, 'Villamayor de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7808, 49, 'Villamor de los Escuderos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7809, 49, 'Villanázar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7810, 49, 'Villanueva de Azoague'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7811, 49, 'Villanueva de Campeán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7812, 49, 'Villanueva de las Peras'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7813, 49, 'Villanueva del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7814, 49, 'Villar de Fallaves'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7815, 49, 'Villar del Buey'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7816, 49, 'Villaralbo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7817, 49, 'Villardeciervos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7818, 49, 'Villardiegua de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7819, 49, 'Villárdiga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7820, 49, 'Villardondiego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7858, 50, 'Aranda de Moncayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7840, 50, 'Alcalá de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7841, 50, 'Alcalá de Moncayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7842, 50, 'Alconchel de Ariza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7843, 50, 'Aldehuela de Liestos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7844, 50, 'Alfajarín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7845, 50, 'Alfamén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7846, 50, 'Alforque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7847, 50, 'Alhama de Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7848, 50, 'Almochuel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7849, 50, 'Almolda (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7850, 50, 'Almonacid de la Cuba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7851, 50, 'Almonacid de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7852, 50, 'Almunia de Doña Godina (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7853, 50, 'Alpartir'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7854, 50, 'Ambel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7855, 50, 'Anento'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7856, 50, 'Aniñón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7857, 50, 'Añón de Moncayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7821, 49, 'Villarrín de Campos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7822, 49, 'Villaseco del Pan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7823, 49, 'Villavendimio'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7824, 49, 'Villaveza de Valverde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7825, 49, 'Villaveza del Agua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7826, 49, 'Viñas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7827, 49, 'Zamora'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7828, 50, 'Abanto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7829, 50, 'Acered'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7830, 50, 'Agón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7831, 50, 'Aguarón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7832, 50, 'Aguilón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7833, 50, 'Ainzón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7834, 50, 'Aladrén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7835, 50, 'Alagón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7836, 50, 'Alarba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7837, 50, 'Alberite de San Juan'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7838, 50, 'Albeta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7839, 50, 'Alborge'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7859, 50, 'Arándiga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7860, 50, 'Ardisa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7861, 50, 'Ariza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7862, 50, 'Artieda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7863, 50, 'Asín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7864, 50, 'Atea'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7865, 50, 'Ateca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7866, 50, 'Azuara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7867, 50, 'Badules'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7868, 50, 'Bagüés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7869, 50, 'Balconchán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7870, 50, 'Bárboles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7871, 50, 'Bardallur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7872, 50, 'Belchite'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7873, 50, 'Belmonte de Gracián'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7874, 50, 'Berdejo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7875, 50, 'Berrueco'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7876, 50, 'Biel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7877, 50, 'Bijuesca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7878, 50, 'Biota'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7917, 50, 'Cosuenda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7918, 50, 'Cuarte de Huerva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7919, 50, 'Cubel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7920, 50, 'Cuerlas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7921, 50, 'Daroca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7898, 50, 'Campillo de Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7899, 50, 'Carenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7900, 50, 'Cariñena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7901, 50, 'Caspe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7902, 50, 'Castejón de Alarba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7903, 50, 'Castejón de las Armas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7904, 50, 'Castejón de Valdejasa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7905, 50, 'Castiliscar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7906, 50, 'Cervera de la Cañada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7907, 50, 'Cerveruela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7908, 50, 'Cetina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7909, 50, 'Chiprana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7910, 50, 'Chodes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7911, 50, 'Cimballa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7912, 50, 'Cinco Olivas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7913, 50, 'Clarés de Ribota'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7914, 50, 'Codo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7915, 50, 'Codos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7916, 50, 'Contamina'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7879, 50, 'Bisimbre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7880, 50, 'Boquiñeni'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7881, 50, 'Bordalba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7882, 50, 'Borja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7883, 50, 'Botorrita'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7884, 50, 'Brea de Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7885, 50, 'Bubierca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7886, 50, 'Bujaraloz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7887, 50, 'Bulbuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7888, 50, 'Bureta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7889, 50, 'Burgo de Ebro (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7890, 50, 'Buste (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7891, 50, 'Cabañas de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7892, 50, 'Cabolafuente'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7893, 50, 'Cadrete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7894, 50, 'Calatayud'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7895, 50, 'Calatorao'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7896, 50, 'Calcena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7897, 50, 'Calmarza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7922, 50, 'Ejea de los Caballeros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7923, 50, 'Embid de Ariza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7924, 50, 'Encinacorba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7925, 50, 'Épila'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7926, 50, 'Erla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7927, 50, 'Escatrón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7928, 50, 'Fabara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7929, 50, 'Farlete'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7930, 50, 'Fayón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7931, 50, 'Fayos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7932, 50, 'Figueruelas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7933, 50, 'Fombuena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7934, 50, 'Frago (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7935, 50, 'Frasno (El)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7936, 50, 'Fréscano'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7937, 50, 'Fuendejalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7938, 50, 'Fuendetodos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7939, 50, 'Fuentes de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7940, 50, 'Fuentes de Jiloca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7980, 50, 'Malón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7981, 50, 'Maluenda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7982, 50, 'Manchones'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7983, 50, 'Mara'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7984, 50, 'María de Huerva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7985, 50, 'Marracos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7960, 50, 'Lechón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7961, 50, 'Leciñena'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7962, 50, 'Letux'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7963, 50, 'Litago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7964, 50, 'Lituénigo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7965, 50, 'Lobera de Onsella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7966, 50, 'Longares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7967, 50, 'Longás'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7968, 50, 'Lucena de Jalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7969, 50, 'Luceni'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7970, 50, 'Luesia'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7971, 50, 'Luesma'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7972, 50, 'Lumpiaque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7973, 50, 'Luna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7974, 50, 'Maella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7975, 50, 'Magallón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7976, 50, 'Mainar'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7977, 50, 'Malanquilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7978, 50, 'Maleján'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7979, 50, 'Mallén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7941, 50, 'Gallocanta'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7942, 50, 'Gallur'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7943, 50, 'Gelsa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7944, 50, 'Godojos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7945, 50, 'Gotor'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7946, 50, 'Grisel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7947, 50, 'Grisén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7948, 50, 'Herrera de los Navarros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7949, 50, 'Ibdes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7950, 50, 'Illueca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7951, 50, 'Isuerre'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7952, 50, 'Jaraba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7953, 50, 'Jarque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7954, 50, 'Jaulín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7955, 50, 'Joyosa (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7956, 50, 'Lagata'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7957, 50, 'Langa del Castillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7958, 50, 'Layana'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7959, 50, 'Lécera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7986, 50, 'Mediana de Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7987, 50, 'Mequinenza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7988, 50, 'Mesones de Isuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7989, 50, 'Mezalocha'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7990, 50, 'Mianos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7991, 50, 'Miedes de Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7992, 50, 'Monegrillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7993, 50, 'Moneva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7994, 50, 'Monreal de Ariza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7995, 50, 'Monterde'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7996, 50, 'Montón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7997, 50, 'Morata de Jalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7998, 50, 'Morata de Jiloca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(7999, 50, 'Morés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8000, 50, 'Moros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8001, 50, 'Moyuela'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8002, 50, 'Mozota'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8003, 50, 'Muel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8004, 50, 'Muela (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8043, 50, 'Purujosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8044, 50, 'Quinto'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8045, 50, 'Remolinos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8046, 50, 'Retascón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8024, 50, 'Paracuellos de la Ribera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8025, 50, 'Pastriz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8026, 50, 'Pedrola'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8027, 50, 'Pedrosas (Las)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8028, 50, 'Perdiguera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8029, 50, 'Piedratajada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8030, 50, 'Pina de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8031, 50, 'Pinseque'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8032, 50, 'Pintanos (Los)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8033, 50, 'Plasencia de Jalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8034, 50, 'Pleitas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8035, 50, 'Plenas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8036, 50, 'Pomer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8037, 50, 'Pozuel de Ariza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8038, 50, 'Pozuelo de Aragón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8039, 50, 'Pradilla de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8040, 50, 'Puebla de Albortón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8041, 50, 'Puebla de Alfindén (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8042, 50, 'Puendeluna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8005, 50, 'Munébrega'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8006, 50, 'Murero'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8007, 50, 'Murillo de Gállego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8008, 50, 'Navardún'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8009, 50, 'Nigüella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8010, 50, 'Nombrevilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8011, 50, 'Nonaspe'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8012, 50, 'Novallas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8013, 50, 'Novillas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8014, 50, 'Nuévalos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8015, 50, 'Nuez de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8016, 50, 'Olvés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8017, 50, 'Orcajo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8018, 50, 'Orera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8019, 50, 'Orés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8020, 50, 'Oseja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8021, 50, 'Osera de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8022, 50, 'Paniza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8023, 50, 'Paracuellos de Jiloca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8047, 50, 'Ricla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8048, 50, 'Romanos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8049, 50, 'Rueda de Jalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8050, 50, 'Ruesca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8051, 50, 'Sabiñán'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8052, 50, 'Sádaba'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8053, 50, 'Salillas de Jalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8054, 50, 'Salvatierra de Esca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8055, 50, 'Samper del Salz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8056, 50, 'San Martín de la Virgen de Moncayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8057, 50, 'San Mateo de Gállego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8058, 50, 'Santa Cruz de Grío'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8059, 50, 'Santa Cruz de Moncayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8060, 50, 'Santa Eulalia de Gállego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8061, 50, 'Santed'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8062, 50, 'Sástago'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8063, 50, 'Sediles'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8064, 50, 'Sestrica'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8103, 50, 'Villadoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8104, 50, 'Villafeliche'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8084, 50, 'Torrijo de la Cañada'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8085, 50, 'Tosos'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8086, 50, 'Trasmoz'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8087, 50, 'Trasobares'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8088, 50, 'Uncastillo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8089, 50, 'Undués de Lerda'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8090, 50, 'Urrea de Jalón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8091, 50, 'Urriés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8092, 50, 'Used'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8093, 50, 'Utebo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8094, 50, 'Val de San Martín'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8095, 50, 'Valdehorna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8096, 50, 'Valmadrid'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8097, 50, 'Valpalmas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8098, 50, 'Valtorres'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8099, 50, 'Velilla de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8100, 50, 'Velilla de Jiloca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8101, 50, 'Vera de Moncayo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8102, 50, 'Vierlas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8065, 50, 'Sierra de Luna'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8066, 50, 'Sigüés'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8067, 50, 'Sisamón'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8068, 50, 'Sobradiel'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8069, 50, 'Sos del Rey Católico'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8070, 50, 'Tabuenca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8071, 50, 'Talamantes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8072, 50, 'Tarazona'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8073, 50, 'Tauste'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8074, 50, 'Terrer'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8075, 50, 'Tierga'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8076, 50, 'Tobed'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8077, 50, 'Torralba de los Frailes'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8078, 50, 'Torralba de Ribota'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8079, 50, 'Torralbilla'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8080, 50, 'Torrehermosa'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8081, 50, 'Torrelapaja'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8082, 50, 'Torrellas'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8083, 50, 'Torres de Berrellén'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8105, 50, 'Villafranca de Ebro'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8106, 50, 'Villalba de Perejil'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8107, 50, 'Villalengua'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8108, 50, 'Villamayor de Gállego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8109, 50, 'Villanueva de Gállego'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8110, 50, 'Villanueva de Huerva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8111, 50, 'Villanueva de Jiloca'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8112, 50, 'Villar de los Navarros'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8113, 50, 'Villarreal de Huerva'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8114, 50, 'Villarroya de la Sierra'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8115, 50, 'Villarroya del Campo'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8116, 50, 'Vilueña (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8117, 50, 'Vistabella'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8118, 50, 'Zaida (La)'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8119, 50, 'Zaragoza'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8120, 50, 'Zuera'); INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES 
(8121, 51, 'Ceuta'); 
INSERT INTO N_Poblaciones (ID_Poblacion, ID_Provincia, Nombre) VALUES (8122, 52, 'Melilla');
/*END Insercion de las poblaciones de Espanna*/



/*BEGIN Insertar TiposDeIvaPorDefecto*/
DELETE FROM N_TipoIVA
DBCC CHECKIDENT (N_TipoIVA, RESEED, 1);

INSERT INTO N_TipoIVA (Nombre, Valor) Values ('1.- [16%]', 16);
INSERT INTO N_TipoIVA (Nombre, Valor) Values ('2.- [7%]', 7);
INSERT INTO N_TipoIVA (Nombre, Valor) Values ('3.- [4%]', 4);
/*END*/

/*BEGIN Insertar TiposArticulos*/
DELETE FROM N_Articulos_Tipo
INSERT INTO N_Articulos_Tipo (ID_TipoArticulo,Nombre) Values (1,'General');
INSERT INTO N_Articulos_Tipo (ID_TipoArticulo,Nombre) Values (2,'Medicamento');
/*END*/


/*BEGIN Insertar N_Entradas_Tipos*/
DELETE FROM N_Entradas_Tipos
DBCC CHECKIDENT (N_Entradas_Tipos, RESEED, 1);
INSERT INTO N_Entradas_Tipos (Codigo,Descripcion) Values ('1', 'Serie 1');
INSERT INTO N_Entradas_Tipos (Codigo,Descripcion) Values ('2', 'Serie 2');
INSERT INTO N_Entradas_Tipos (Codigo,Descripcion) Values ('3', 'Serie 3');
INSERT INTO N_Entradas_Tipos (Codigo,Descripcion) Values ('4', 'Serie 4');
INSERT INTO N_Entradas_Tipos (Codigo,Descripcion) Values ('5', 'Serie 5');
INSERT INTO N_Entradas_Tipos (Codigo,Descripcion) Values ('6', 'Serie 6');
INSERT INTO N_Entradas_Tipos (Codigo,Descripcion) Values ('7', 'Serie 7');
INSERT INTO N_Entradas_Tipos (Codigo,Descripcion) Values ('8', 'Serie 8');
INSERT INTO N_Entradas_Tipos (Codigo,Descripcion) Values ('9', 'Serie 9');
/*END Insertar N_Entradas_Tipos*/

/*BEGIN Insertar N_PedidosProveedor_Tipos*/
DELETE FROM N_PedidosProveedor_Tipos
DBCC CHECKIDENT (N_PedidosProveedor_Tipos, RESEED, 1);
INSERT INTO N_PedidosProveedor_Tipos (Codigo,Descripcion) Values ('1', 'Serie 1');
INSERT INTO N_PedidosProveedor_Tipos (Codigo,Descripcion) Values ('2', 'Serie 2');
INSERT INTO N_PedidosProveedor_Tipos (Codigo,Descripcion) Values ('3', 'Serie 3');
INSERT INTO N_PedidosProveedor_Tipos (Codigo,Descripcion) Values ('4', 'Serie 4');
INSERT INTO N_PedidosProveedor_Tipos (Codigo,Descripcion) Values ('5', 'Serie 5');
INSERT INTO N_PedidosProveedor_Tipos (Codigo,Descripcion) Values ('6', 'Serie 6');
INSERT INTO N_PedidosProveedor_Tipos (Codigo,Descripcion) Values ('7', 'Serie 7');
INSERT INTO N_PedidosProveedor_Tipos (Codigo,Descripcion) Values ('8', 'Serie 8');
INSERT INTO N_PedidosProveedor_Tipos (Codigo,Descripcion) Values ('9', 'Serie 9');
/*END Insertar N_PedidosProveedor_Tipos*/

/*BEGIN Insertar N_FacturasRecibidas_Tipos*/
DELETE FROM N_FacturasRecibidas_Tipos
DBCC CHECKIDENT (N_FacturasRecibidas_Tipos, RESEED, 1);
INSERT INTO N_FacturasRecibidas_Tipos (Codigo,Descripcion) Values ('1', 'Serie 1');
INSERT INTO N_FacturasRecibidas_Tipos (Codigo,Descripcion) Values ('2', 'Serie 2');
INSERT INTO N_FacturasRecibidas_Tipos (Codigo,Descripcion) Values ('3', 'Serie 3');
INSERT INTO N_FacturasRecibidas_Tipos (Codigo,Descripcion) Values ('4', 'Serie 4');
INSERT INTO N_FacturasRecibidas_Tipos (Codigo,Descripcion) Values ('5', 'Serie 5');
INSERT INTO N_FacturasRecibidas_Tipos (Codigo,Descripcion) Values ('6', 'Serie 6');
INSERT INTO N_FacturasRecibidas_Tipos (Codigo,Descripcion) Values ('7', 'Serie 7');
INSERT INTO N_FacturasRecibidas_Tipos (Codigo,Descripcion) Values ('8', 'Serie 8');
INSERT INTO N_FacturasRecibidas_Tipos (Codigo,Descripcion) Values ('9', 'Serie 9');
/*END Insertar N_FacturasRecibidas_Tipos*/

/*BEGIN Insertar Familias de Articulos por defecto*/
INSERT INTO N_Familias (Codigo, Nombre) VALUES ('01','Generales');
/*BEGIN Insertar Familias de Articulos por defecto*/

/*BEGIN Almacen por defecto*/
INSERT INTO N_Almacen (Codigo,Descripcion,Observaciones) Values ('01','GENERAL', 'GENERAL');
/*END Almacen por defecto*/

/*BEGIN Lineas Citas*/
CREATE TABLE dbo.LineasCitas
	(
	IdLinea bigint NOT NULL IDENTITY (1, 1),
	IdCita int NOT NULL,
	RefConcepto varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DESCRIPCION varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Cantidad float(53) NOT NULL,
	ImporteClinica float(53) NOT NULL,
	ImporteDr float(53) Not Null
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	DF_LineasCitas_DESCRIPCION DEFAULT '' FOR DESCRIPCION
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	DF_LineasCitas_Cantidad DEFAULT 1 FOR Cantidad
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	DF_LineasCitas_ImporteClinica DEFAULT 0 FOR ImporteClinica
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	DF_LineasCitas_ImporteDr DEFAULT 0 FOR ImporteDr
GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	PK_LineasCitas PRIMARY KEY CLUSTERED 
	(
	IdLinea,
	IdCita
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LineasCitas ADD CONSTRAINT
	FK_LineasCitas_Citas FOREIGN KEY (IdCita) REFERENCES CITAS (IDCITA)
ON UPDATE CASCADE
ON DELETE CASCADE
GO
/*END Lineas Citas*/

/*BEGIN Codigo por defecto para Analiticas*/
ALTER TABLE dbo.ANALITICAS ADD
	REFCONCEPTO varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
GO
ALTER TABLE dbo.ANALITICAS ADD CONSTRAINT
	FK_ANALITICAS_CONCEPTOSFRA FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
GO
/*END Codigo por defecto para Analiticas*/
/*BEGIN Codigo por defecto para plantillaAnalitica*/
ALTER TABLE dbo.PLANTILLAANALITICAS ADD
	REFCONCEPTO varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
GO
ALTER TABLE dbo.PLANTILLAANALITICAS ADD CONSTRAINT
	FK_PLANTILLAANALITICAS_CONCEPTOSFRA FOREIGN KEY
	(
	REFCONCEPTO
	) REFERENCES dbo.CONCEPTOSFRA
	(
	CODIGO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 	
GO
/*END Codigo por defecto para plantillaAnalitica*/
/*BEGIN añado campo codigonacional en tabla medicamentos*/
ALTER TABLE dbo.MEDICAMENTOS ADD
	CODIGONACIONAL nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL CONSTRAINT DF_MEDICAMENTOS_CODIGONACIONAL DEFAULT ''
GO
/*END añado campo codigonacional en tabla medicamentos*/
/*BEGIN tabla para añdir dx a los antecedentes médicos */
CREATE TABLE dbo.AntecedentesDiagnosticos
	(
	IDANTECEDENTEDX int NOT NULL IDENTITY (1, 1),
	IDDIAGNOSTICO int NOT NULL,
	DIAGNOSTICO varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	OBSERVACIONES text COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CIE10 varchar(12) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CPACIENTE int NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.AntecedentesDiagnosticos ADD CONSTRAINT
	DF_AntecedentesDiagnosticos_DIAGNOSTICO DEFAULT '' FOR DIAGNOSTICO
GO
ALTER TABLE dbo.AntecedentesDiagnosticos ADD CONSTRAINT
	DF_AntecedentesDiagnosticos_OBSERVACIONES DEFAULT '' FOR OBSERVACIONES
GO
ALTER TABLE dbo.AntecedentesDiagnosticos ADD CONSTRAINT
	PK_AntecedentesDiagnosticos PRIMARY KEY CLUSTERED 
	(
	IDANTECEDENTEDX
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

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
/*END tabla para añdir dx a los antecedentes médicos */
/*BEGIN tabla que permite añadir mas dx a los historiales */
CREATE TABLE dbo.HistorialesDiagnosticos
	(
	IdLineaDiagnostico int NOT NULL IDENTITY (1, 1),
	CHistorial int NOT NULL,
	IdDiagnostico int NOT NULL,
	CIE10 varchar(12) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	OBSERVACIONES text COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DIAGNOSTICO varchar(70) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.HistorialesDiagnosticos ADD CONSTRAINT
	DF_HistorialesDiagnosticos_OBSERVACIONES DEFAULT '' FOR OBSERVACIONES
GO
ALTER TABLE dbo.HistorialesDiagnosticos ADD CONSTRAINT
	DF_HistorialesDiagnosticos_DIAGNOSTICO DEFAULT '' FOR DIAGNOSTICO
GO
ALTER TABLE dbo.HistorialesDiagnosticos ADD CONSTRAINT
	PK_HistorialesDiagnosticos PRIMARY KEY CLUSTERED 
	(
	IdLineaDiagnostico,
	CHistorial
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

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
/*END tabla que permite añadir mas dx a los historiales */
/*BEGIN tabla qeu permite añadir mas de un medicamento a una receta */
CREATE TABLE dbo.RecetasMedicamentos
	(
	IdLineaReceta int NOT NULL IDENTITY (1, 1),
	IdReceta int NOT NULL,
	REFMEDICAMENTO varchar(5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
	)  ON [PRIMARY]
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
/*END tabla qeu permite añadir mas de un medicamento a una receta */
/*BEGIN Tabla para almacenar valores posibles para el campo "conocio" de los pacinetes*/

CREATE TABLE dbo.ComoConocio
	(
	IDConocio int NOT NULL IDENTITY (1, 1),
	Descripcion varchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.ComoConocio ADD CONSTRAINT
	DF_ComoConocio_Descripcion DEFAULT '' FOR Descripcion
GO
ALTER TABLE dbo.ComoConocio ADD CONSTRAINT
	PK_ComoConocio PRIMARY KEY CLUSTERED 
	(
	IDConocio
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/*END Tabla para almacenar valores posibles para el campo "conocio" de los pacinetes*/
/*BEGIN añado a la tabla pacientes el campo beneficiariocodigosocio que va a permitir definir quienes son los beneficiarios de un socio*/
ALTER TABLE dbo.PACIENTES ADD
	BENEFICIARIOCODIGOSOCIO int NOT NULL CONSTRAINT DF_PACIENTES_BENEFICIARIOCODIGOSOCIO DEFAULT ''
GO
ALTER TABLE dbo.PACIENTES ADD
	BENEFICIARIOPARENTESCO varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL CONSTRAINT DF_PACIENTES_BENEFICIARIOPARENTESCO DEFAULT ''
GO
/*END añado a la tabla pacientes el campo beneficiariocodigosocio que va a permitir definir quienes son los beneficiarios de un socio*/
/*BEGIN creo la tabla que recogera los posibles valores para el campo BENEFICAIRIOPARENTESCO de la tabla PACIENTES*/
CREATE TABLE dbo.Parentescos
	(
	IdParentesco int NOT NULL IDENTITY (1, 1),
	Descripcion varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Parentescos ADD CONSTRAINT
	DF_Parentescos_Descripcion DEFAULT '' FOR Descripcion
GO
/*END creo la tabla que recogera los posibles valores para el campo BENEFICAIRIOPARENTESCO de la tabla PACIENTES*/
/*BEGIN añado una tabla que permita recoger contactos relacionados con los pacientes*/
CREATE TABLE dbo.ContactosPacientes
	(
	IdContacto int NOT NULL IDENTITY (1, 1),
	CPaciente int NOT NULL,
	Nombre varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Apellidos varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Direccion varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Localidad varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CP varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Pais varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Telefono varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Movil varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Fax varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Email varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Parentesco varchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Notas text COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Nombre DEFAULT '' FOR Nombre
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Apellidos DEFAULT '' FOR Apellidos
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Direccion DEFAULT '' FOR Direccion
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Localidad DEFAULT '' FOR Localidad
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_CP DEFAULT '' FOR CP
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Pais DEFAULT '' FOR Pais
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Telefono DEFAULT '' FOR Telefono
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Movil DEFAULT '' FOR Movil
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Fax DEFAULT '' FOR Fax
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Email DEFAULT '' FOR Email
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Parentesco DEFAULT '' FOR Parentesco
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	DF_ContactosPacientes_Notas DEFAULT '' FOR Notas
GO
ALTER TABLE dbo.ContactosPacientes ADD CONSTRAINT
	PK_ContactosPacientes PRIMARY KEY CLUSTERED 
	(
	IdContacto,
	CPaciente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
/*END añado una tabla que permita recoger contactos relacionados con los pacientes*/

/*BEGIN tabla que almacena los puestos de trabajo para usarlos posteriormente en le historial laboral del pacinete*/
CREATE TABLE dbo.PuestoTrabajo
	(
	idPuestoTrabajo int NOT NULL IDENTITY (1, 1),
	Descripcion varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.PuestoTrabajo ADD CONSTRAINT
	DF_PuestoTrabajo_Descripcion DEFAULT '' FOR Descripcion
GO
/*END tabla que almacena los puestos de trabajo para usarlos posteriormente en le historial laboral del pacinete*/
/*BEGIN añado campo a LEMPRESAS para poder definir la profsión del paciente en cada empresa*/
ALTER TABLE dbo.LEMPRESAS ADD
	PUESTOTRABAJO varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL CONSTRAINT DF_LEMPRESAS_PUESTOTRABAJO DEFAULT ''
GO
/*END añado campo a LEMPRESAS para poder definir la profsión del paciente en cada empresa*/
/*BEGIN creo tabla qeu servidar para auditar las acciones de los usuarios */
CREATE TABLE dbo.Auditoria
	(
	idLog int NOT NULL IDENTITY (1, 1),
	FechaHora datetime NOT NULL,
	NombreUsuario varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	TipoDocumento varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CodigoDocumento varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DetallesDocumento varchar(300) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Auditoria ADD CONSTRAINT
	DF_Auditoria_FechaHora DEFAULT getdate() FOR FechaHora
GO
ALTER TABLE dbo.Auditoria ADD CONSTRAINT
	DF_Auditoria_NombreUsuario DEFAULT '' FOR NombreUsuario
GO
ALTER TABLE dbo.Auditoria ADD CONSTRAINT
	DF_Auditoria_TipoDocumento DEFAULT '' FOR TipoDocumento
GO
ALTER TABLE dbo.Auditoria ADD CONSTRAINT
	DF_Auditoria_CodigoDocumento DEFAULT '' FOR CodigoDocumento
GO
ALTER TABLE dbo.Auditoria ADD CONSTRAINT
	DF_Auditoria_DetallesDocumento DEFAULT '' FOR DetallesDocumento
GO
ALTER TABLE dbo.Auditoria ADD CONSTRAINT
	PK_Auditoria PRIMARY KEY CLUSTERED 
	(
	idLog
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/*END creo tabla qeu servira para auditar las acciones de los usuarios */
/*BEGIN creo tabla tarifas que me va a permitir asignar importes diferentes a los conceptos facturables*/
CREATE TABLE dbo.Tarifas
	(
	IdTarifa int NOT NULL IDENTITY (1, 1),
	DescripcionTarifa varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	IdConceptoFra varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Importe float(53) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tarifas ADD CONSTRAINT
	DF_Tarifas_DescripcionTarifa DEFAULT '' FOR DescripcionTarifa
GO
ALTER TABLE dbo.Tarifas ADD CONSTRAINT
	DF_Tarifas_Importe DEFAULT 0 FOR Importe
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
/*END creo tabla tarifas que me va a permitir asignar importes diferentes a los conceptos facturables*/
/*BEGIN añado el campo que vincula las tarifas con las mutuas*/
ALTER TABLE dbo.MUTUAS ADD
	IdTarifa int NULL
GO
/*END añado el campo que vincula las tarifas con las mutuas*/
/*BEGIN añado campo REFMEDICO en tabla derivaciones para saber que medico realiza la derivación*/
ALTER TABLE dbo.DERIVACIONES ADD
	REFMEDICO int NULL
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
/*END añado campo REFMEDICO en tabla derivaciones para saber que medico realiza la derivación*/
/*SE CREAN LAS TABLAS DE TICKETS Y FACTURAS PARA LA VENTAS DE PRODUCTOS.*/
/*TABLA  Ticket TIPOS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[N_Ticket_Tipos](
	[ID_TipoTicket] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Descripcion] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_N_Ticket_Tipos] PRIMARY KEY CLUSTERED 
(
	[ID_TipoTicket] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
/*FIN TicketTIPOS*/
/*TABLA DE Ticket*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[N_Ticket](
	[ID_Ticket] [bigint] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_TipoTicket] [int] NULL,
	[Referencia] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Fecha] [datetime] NOT NULL CONSTRAINT [DF_Ticket_Fecha] DEFAULT getDate(),
	[ID_Estado] [int] NULL,
	[ID_Cliente] [int] NULL,
	[ID_FormaPago] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IRPFPorciento] [float] NULL CONSTRAINT [DF_N_Ticket_REPorciento]  DEFAULT ((0)),
	[IRPFCantidad] [float] NULL CONSTRAINT [DF_N_Ticket_ReCantidad]  DEFAULT ((0)),
	[Total] [float] NULL,
	[Observaciones] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PlazoEntrega] [datetime] NULL,
	[Validez] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PortePagado] [bit] NULL CONSTRAINT [DF_N_Ticket_PortePagado]  DEFAULT ((1)),
	[PorteDebido] [bit] NULL CONSTRAINT [DF_N_Ticket_PorteDebido]  DEFAULT ((0)),
	[PorteTexto] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Privado] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DocumentacionAsociada] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Comentarios] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Imagen] [image] NULL,
	[Pagado] [bit] NOT NULL CONSTRAINT [DF_N_Ticket_Pagado] DEFAULT ((0)),
	[FechaPagado] [datetime] NOT NULL CONSTRAINT [DF_N_Ticket_FechaPagado] DEFAULT getDate(),
 CONSTRAINT [PK_N_Ticket] PRIMARY KEY CLUSTERED 
(
	[ID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[N_Ticket]  WITH CHECK ADD  CONSTRAINT [FK_N_Ticket_FormasPago] FOREIGN KEY([ID_FormaPago])
REFERENCES [dbo].[FORMASPAGO] ([CODIGO])
GO
ALTER TABLE [dbo].[N_Ticket] CHECK CONSTRAINT [FK_N_Ticket_FormasPago]
GO
ALTER TABLE [dbo].[N_Ticket]  WITH CHECK ADD  CONSTRAINT [FK_N_Ticket_N_Ticket_Tipos] FOREIGN KEY([ID_TipoTicket])
REFERENCES [dbo].[N_Ticket_Tipos] ([ID_TipoTicket])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Ticket] CHECK CONSTRAINT [FK_N_Ticket_N_Ticket_Tipos]
GO
ALTER TABLE [dbo].[N_Ticket]  WITH CHECK ADD  CONSTRAINT [FK_N_Ticket_N_Pacientes] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Pacientes] ([CPACIENTE])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Ticket] CHECK CONSTRAINT [FK_N_Ticket_N_Pacientes]
GO
/*FIN TABLA Ticket*/

/*TABLA TicketLINEAS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[N_Ticket_Lineas](
	[ID_TicketLineas] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_Ticket] [bigint] NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_Articulo] [bigint] NULL,
	[Descripcion] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Cantidad] [float] NULL,
	[Precio] [float] NULL,
	[Descuento1] [float] NULL,
	[Descuento2] [float] NULL,
	[Descuento3] [float] NULL,
	[Total] [float] NULL,
	[ID_TipoIVA] [int] NULL,
	[IVAIncluido] [bit] NOT NULL,
	[Costo] [float] NULL,
	[Imagen] [image] NULL,
	[Observaciones] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_Almacen] [int] NULL,
	[Validado] [bit] NULL CONSTRAINT [DF_N_Ticket_Lineas_Validado]  DEFAULT ((0)),
	[ID_DocOrigen] [bigint] NULL,
	[ID_TipoDocOrigen] [int] NULL,
 CONSTRAINT [PK_N_Ticket_Lineas] PRIMARY KEY CLUSTERED 
(
	[ID_TicketLineas] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[N_Ticket_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_Ticket_Lineas_N_Almacen] FOREIGN KEY([ID_Almacen])
REFERENCES [dbo].[N_Almacen] ([ID_Almacen])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Ticket_Lineas] CHECK CONSTRAINT [FK_N_Ticket_Lineas_N_Almacen]
GO
ALTER TABLE [dbo].[N_Ticket_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_Ticket_Lineas_N_Ticket] FOREIGN KEY([ID_Ticket])
REFERENCES [dbo].[N_Ticket] ([ID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Ticket_Lineas] CHECK CONSTRAINT [FK_N_Ticket_Lineas_N_Ticket]
GO
ALTER TABLE [dbo].[N_Ticket_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_Ticket_Lineas_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Ticket_Lineas] CHECK CONSTRAINT [FK_N_Ticket_Lineas_N_TipoIVA]
/*FIN TICKETLINEAS*/

/*TABLA TICKETTOTALES*/

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[N_Ticket_Totales](
	[ID_Ticket] [bigint] NOT NULL,
	[ID_TipoIVA] [int] NOT NULL,
	[DescuentoPorciento] [float] NULL,
	[DescuentoCantidad] [float] NULL,
	[ProntoPagoPorciento] [float] NULL,
	[ProntoPagoCantidad] [float] NULL,
	[PortesPorciento] [float] NULL,
	[PortesCantidad] [float] NULL,
	[FinanciacionPorciento] [float] NULL,
	[FinanciacionCantidad] [float] NULL,
	[ImporteNeto] [float] NULL,
	[SubTotal] [float] NULL,
	[IVAPorciento] [float] NULL,
	[IVACantidad] [float] NULL,
	[REPorciento] [float] NULL,
	[RECantidad] [float] NULL,
 CONSTRAINT [PK_N_Ticket_Totales] PRIMARY KEY CLUSTERED 
(
	[ID_Ticket] ASC,
	[ID_TipoIVA] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[N_Ticket_Totales]  WITH CHECK ADD  CONSTRAINT [FK_N_Ticket_Totales_N_Ticket] FOREIGN KEY([ID_Ticket])
REFERENCES [dbo].[N_Ticket] ([ID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Ticket_Totales] CHECK CONSTRAINT [FK_N_Ticket_Totales_N_Ticket]
GO
ALTER TABLE [dbo].[N_Ticket_Totales]  WITH CHECK ADD  CONSTRAINT [FK_N_Ticket_Totales_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Ticket_Totales] CHECK CONSTRAINT [FK_N_Ticket_Totales_N_TipoIVA]
/*FIN Ticket TOTALES.*/

/*---------------------------------------------------------------------*/
/*TABLA DE Factura*/
/*TABLA  Factura TIPOS*/
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[N_Factura_Tipos](
	[ID_TipoFactura] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Descripcion] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_N_Factura_Tipos] PRIMARY KEY CLUSTERED 
(
	[ID_TipoFactura] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
/*FIN FacturaTIPOS*/
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[N_Factura](
	[ID_Factura] [bigint] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_TipoFactura] [int] NULL,
	[Referencia] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Fecha] [datetime] NULL CONSTRAINT [DF_N_Factura_Fecha] DEFAULT getDate(),
	[ID_Estado] [int] NULL,
	[ID_Cliente] [int] NULL,
	[ID_FormaPago] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IRPFPorciento] [float] NULL CONSTRAINT [DF_N_Factura_REPorciento]  DEFAULT ((0)),
	[IRPFCantidad] [float] NULL CONSTRAINT [DF_N_Factura_ReCantidad]  DEFAULT ((0)),
	[Total] [float] NULL,
	[Observaciones] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PlazoEntrega] [datetime] NULL,
	[Validez] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PortePagado] [bit] NULL CONSTRAINT [DF_N_Factura_PortePagado]  DEFAULT ((1)),
	[PorteDebido] [bit] NULL CONSTRAINT [DF_N_Factura_PorteDebido]  DEFAULT ((0)),
	[PorteTexto] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Privado] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DocumentacionAsociada] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Comentarios] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Imagen] [image] NULL,
	[Pagado] [bit] NOT NULL CONSTRAINT [DF_N_Factura_Pagado] DEFAULT ((0)),
	[FechaPagado] [datetime] NOT NULL CONSTRAINT [DF_N_Factura_FechaPagado] DEFAULT getDate(),
 CONSTRAINT [PK_N_Factura] PRIMARY KEY CLUSTERED 
(
	[ID_Factura] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[N_Factura]  WITH CHECK ADD  CONSTRAINT [FK_N_Factura_FormasPago] FOREIGN KEY([ID_FormaPago])
REFERENCES [dbo].[FORMASPAGO] ([CODIGO])
GO
ALTER TABLE [dbo].[N_Factura] CHECK CONSTRAINT [FK_N_Factura_FormasPago]
GO
ALTER TABLE [dbo].[N_Factura]  WITH CHECK ADD  CONSTRAINT [FK_N_Factura_N_Factura_Tipos] FOREIGN KEY([ID_TipoFactura])
REFERENCES [dbo].[N_Factura_Tipos] ([ID_TipoFactura])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Factura] CHECK CONSTRAINT [FK_N_Factura_N_Factura_Tipos]
GO
ALTER TABLE [dbo].[N_Factura]  WITH CHECK ADD  CONSTRAINT [FK_N_Factura_N_Pacientes] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Pacientes] ([CPACIENTE])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Factura] CHECK CONSTRAINT [FK_N_Factura_N_Pacientes]
GO
/*FIN TABLA Factura*/

/*TABLA FacturaLINEAS*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[N_Factura_Lineas](
	[ID_FacturaLineas] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_Factura] [bigint] NOT NULL,
	[Codigo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_Articulo] [bigint] NULL,
	[Descripcion] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Cantidad] [float] NULL,
	[Precio] [float] NULL,
	[Descuento1] [float] NULL,
	[Descuento2] [float] NULL,
	[Descuento3] [float] NULL,
	[Total] [float] NULL,
	[ID_TipoIVA] [int] NULL,
	[IVAIncluido] [bit] NOT NULL,
	[Costo] [float] NULL,
	[Imagen] [image] NULL,
	[Observaciones] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ID_Almacen] [int] NULL,
	[Validado] [bit] NULL CONSTRAINT [DF_N_Factura_Lineas_Validado]  DEFAULT ((0)),
	[ID_DocOrigen] [bigint] NULL,
	[ID_TipoDocOrigen] [int] NULL,
 CONSTRAINT [PK_N_Factura_Lineas] PRIMARY KEY CLUSTERED 
(
	[ID_FacturaLineas] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[N_Factura_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_Factura_Lineas_N_Almacen] FOREIGN KEY([ID_Almacen])
REFERENCES [dbo].[N_Almacen] ([ID_Almacen])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Factura_Lineas] CHECK CONSTRAINT [FK_N_Factura_Lineas_N_Almacen]
GO
ALTER TABLE [dbo].[N_Factura_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_Factura_Lineas_N_Factura] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[N_Factura] ([ID_Factura])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Factura_Lineas] CHECK CONSTRAINT [FK_N_Factura_Lineas_N_Factura]
GO
ALTER TABLE [dbo].[N_Factura_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_N_Factura_Lineas_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Factura_Lineas] CHECK CONSTRAINT [FK_N_Factura_Lineas_N_TipoIVA]
/*FIN FacturaLINEAS*/
go
/*TABLA FacturaTOTALES*/

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[N_Factura_Totales](
	[ID_Factura] [bigint] NOT NULL,
	[ID_TipoIVA] [int] NOT NULL,
	[DescuentoPorciento] [float] NULL,
	[DescuentoCantidad] [float] NULL,
	[ProntoPagoPorciento] [float] NULL,
	[ProntoPagoCantidad] [float] NULL,
	[PortesPorciento] [float] NULL,
	[PortesCantidad] [float] NULL,
	[FinanciacionPorciento] [float] NULL,
	[FinanciacionCantidad] [float] NULL,
	[ImporteNeto] [float] NULL,
	[SubTotal] [float] NULL,
	[IVAPorciento] [float] NULL,
	[IVACantidad] [float] NULL,
	[REPorciento] [float] NULL,
	[RECantidad] [float] NULL,
 CONSTRAINT [PK_N_Factura_Totales] PRIMARY KEY CLUSTERED 
(
	[ID_Factura] ASC,
	[ID_TipoIVA] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[N_Factura_Totales]  WITH CHECK ADD  CONSTRAINT [FK_N_Factura_Totales_N_Factura] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[N_Factura] ([ID_Factura])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Factura_Totales] CHECK CONSTRAINT [FK_N_Factura_Totales_N_Factura]
GO
ALTER TABLE [dbo].[N_Factura_Totales]  WITH CHECK ADD  CONSTRAINT [FK_N_Factura_Totales_N_TipoIVA] FOREIGN KEY([ID_TipoIVA])
REFERENCES [dbo].[N_TipoIVA] ([ID_TipoIVA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[N_Factura_Totales] CHECK CONSTRAINT [FK_N_Factura_Totales_N_TipoIVA]
/*FIN Factura TOTALES.*/
/*Se insertan los valores por defecto para las tablas tipo*/
/*BEGIN Insertar N_Ticket_Tipos*/
DELETE FROM N_Ticket_Tipos
DBCC CHECKIDENT (N_Ticket_Tipos, RESEED, 1);
INSERT INTO N_Ticket_Tipos (Codigo,Descripcion) Values ('1', 'Serie 1');
INSERT INTO N_Ticket_Tipos (Codigo,Descripcion) Values ('2', 'Serie 2');
INSERT INTO N_Ticket_Tipos (Codigo,Descripcion) Values ('3', 'Serie 3');
INSERT INTO N_Ticket_Tipos (Codigo,Descripcion) Values ('4', 'Serie 4');
INSERT INTO N_Ticket_Tipos (Codigo,Descripcion) Values ('5', 'Serie 5');
INSERT INTO N_Ticket_Tipos (Codigo,Descripcion) Values ('6', 'Serie 6');
INSERT INTO N_Ticket_Tipos (Codigo,Descripcion) Values ('7', 'Serie 7');
INSERT INTO N_Ticket_Tipos (Codigo,Descripcion) Values ('8', 'Serie 8');
INSERT INTO N_Ticket_Tipos (Codigo,Descripcion) Values ('9', 'Serie 9');
/*END Insertar N_Ticket_Tipos*/
/*BEGIN Insertar N_Factura_Tipos*/
DELETE FROM N_Factura_Tipos
DBCC CHECKIDENT (N_Factura_Tipos, RESEED, 1);
INSERT INTO N_Factura_Tipos (Codigo,Descripcion) Values ('1', 'Serie 1');
INSERT INTO N_Factura_Tipos (Codigo,Descripcion) Values ('2', 'Serie 2');
INSERT INTO N_Factura_Tipos (Codigo,Descripcion) Values ('3', 'Serie 3');
INSERT INTO N_Factura_Tipos (Codigo,Descripcion) Values ('4', 'Serie 4');
INSERT INTO N_Factura_Tipos (Codigo,Descripcion) Values ('5', 'Serie 5');
INSERT INTO N_Factura_Tipos (Codigo,Descripcion) Values ('6', 'Serie 6');
INSERT INTO N_Factura_Tipos (Codigo,Descripcion) Values ('7', 'Serie 7');
INSERT INTO N_Factura_Tipos (Codigo,Descripcion) Values ('8', 'Serie 8');
INSERT INTO N_Factura_Tipos (Codigo,Descripcion) Values ('9', 'Serie 9');
/*END Insertar N_Factura_Tipos*/
/*SE CREAN LAS TABLAS DE TICKETS Y FACTURAS PARA LA VENTAS DE PRODUCTOS.*/


Update VariablesGlobales Set Valor = '1.0.0.3' where Clave = 'DB_Version'