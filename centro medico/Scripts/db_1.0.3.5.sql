Print 'Inserción de plantilla consentimiento si no existe';

if(not exists(select 1 from ReportesPersonalizados where FileName='Consentimiento'))
begin
	print 'no existe, se insertara plantilla';
	Insert ReportesPersonalizados (Descripcion,Seccion,FileName,FechaAnnadido,PorDefecto) values ('Consentimiento',1,'Consentimiento.rdlc',getDate(),0)
end

Print 'Tabla de Bonos';
GO
CREATE TABLE dbo.Bonos
	(
	id int NOT NULL IDENTITY (1, 1),
	fecha date NOT NULL,
	cpaciente int NOT NULL,
	numsesiones int NOT NULL,
	idfactura int NULL,
	Notas ntext NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Bonos ADD CONSTRAINT
	DF_Bonos_numsesiones DEFAULT 0 FOR numsesiones
GO
ALTER TABLE dbo.Bonos ADD CONSTRAINT
	DF_Bonos_Notas DEFAULT '' FOR Notas
GO
ALTER TABLE dbo.Bonos ADD CONSTRAINT
	PK_Bonos PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

Print 'Constraint con facturas y pacientes';
GO
ALTER TABLE dbo.Bonos ADD CONSTRAINT
	FK_Bonos_FACTURAS FOREIGN KEY
	(
	idfactura
	) REFERENCES dbo.FACTURAS
	(
	IDFACTURA
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Bonos
	NOCHECK CONSTRAINT FK_Bonos_FACTURAS
GO
ALTER TABLE dbo.Bonos ADD CONSTRAINT
	FK_Bonos_PACIENTES FOREIGN KEY
	(
	cpaciente
	) REFERENCES dbo.PACIENTES
	(
	CPACIENTE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

Print 'Crear tabla sesiones';
CREATE TABLE dbo.Sesiones
(
	id int NOT NULL Identity(1,1),
	refbono int NOT NULL,
	fecha datetime NOT NULL,
	descripcion ntext NOT NULL,
	refcita int NULL,
)
GO

ALTER TABLE dbo.Sesiones ADD CONSTRAINT
		PK_Sesiones PRIMARY  KEY CLUSTERED
		(
		id
		)
GO

ALTER TABLE dbo.Sesiones ADD CONSTRAINT
	FK_Sesiones_Bonos FOREIGN KEY
	(
		refbono
	) REFERENCES dbo.Bonos
	(
		id
	) ON UPDATE NO ACTION
	ON DELETE NO ACTION

GO

ALTER TABLE dbo.Sesiones ADD CONSTRAINT
	FK_Sesiones_Citas FOREIGN KEY
	(
		refcita
	) REFERENCES dbo.Citas
	(
		idcita
	) ON UPDATE NO ACTION
	ON DELETE NO ACTION

GO


PRINT 'ADD CAMPO PARA ALMACENAR RUTA DEL CERTIFICADO DIGITAL DEL USUARIO';
ALTER TABLE dbo.USUARIOS ADD CERTIFICADOPATH NTEXT NULL
GO

PRINT 'ADD CAMPO IMAGE EN LCOMPARATIVAS';
ALTER TABLE dbo.LCOMPARATIVAS ADD
	IMAGEN image NULL
GO

PRINT 'ADD CAMPO PARA OCULTAR PARAMETROS EN INFORME DE CLIENTE';
ALTER TABLE dbo.MODELOSDATOS ADD
	OcultarImpresionCliente bit NULL
GO

ALTER TABLE dbo.DATOSCOMPARATIVA ADD
	OcultarImpresionCliente bit NULL
GO

Update VariablesGlobales Set Valor = '1.0.3.5' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.3.5';




