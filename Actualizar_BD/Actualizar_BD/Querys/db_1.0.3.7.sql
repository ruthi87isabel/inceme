
/****** Object:  Table [dbo].[VariablesGlobales]    Script Date: 03/11/2015 15:47:44 ******/
INSERT [dbo].[VariablesGlobales] ([Clave], [Valor]) VALUES (N'Folio', N'Folio')
INSERT [dbo].[VariablesGlobales] ([Clave], [Valor]) VALUES (N'Hoja', N'Sheet')
INSERT [dbo].[VariablesGlobales] ([Clave], [Valor]) VALUES (N'Libro', N'Book')
INSERT [dbo].[VariablesGlobales] ([Clave], [Valor]) VALUES (N'RegistroLocalizacion', N'XXXX-YYYY-ZZZZ')
INSERT [dbo].[VariablesGlobales] ([Clave], [Valor]) VALUES (N'Seccion', N'Section')
INSERT [dbo].[VariablesGlobales] ([Clave], [Valor]) VALUES (N'Volumen', N'Volume')
INSERT [dbo].[VariablesGlobales] ([Clave], [Valor]) VALUES (N'FacturaEFicherosParametrosUrl', '')
INSERT [dbo].[VariablesGlobales] ([Clave], [Valor]) VALUES (N'FacturaEEjecutableUrl','')
GO

print 'añadiendo campo recibida en tabla analíticas';
GO
ALTER TABLE dbo.ANALITICAS ADD
	RECIBIDA bit NULL
GO
ALTER TABLE dbo.ANALITICAS ADD CONSTRAINT
	DF_ANALITICAS_RECIBIDA DEFAULT 0 FOR RECIBIDA
GO

print 'añado campo que permite controlar hasta cuando es valido el contrato de socio de un asociado /beneficiario';
ALTER TABLE dbo.PACIENTES ADD
	SOCIOVALIDOHASTA date NULL
GO

Update VariablesGlobales Set Valor = '1.0.3.7' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.3.7';
GO