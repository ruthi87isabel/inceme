DECLARE @@CM varchar(30)
SET @@CM = "$(dbname)";

:On Error exit


CREATE DATABASE [$(dbname)] COLLATE Modern_Spanish_CI_AS

GO
EXEC dbo.sp_dbcmptlevel @dbname=N'$(dbname)', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [$(dbname)].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [$(dbname)] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [$(dbname)] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [$(dbname)] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [$(dbname)] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [$(dbname)] SET ARITHABORT OFF 
GO
ALTER DATABASE [$(dbname)] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [$(dbname)] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [$(dbname)] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [$(dbname)] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [$(dbname)] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [$(dbname)] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [$(dbname)] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [$(dbname)] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [$(dbname)] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [$(dbname)] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [$(dbname)] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [$(dbname)] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [$(dbname)] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [$(dbname)] SET  READ_WRITE 
GO
ALTER DATABASE [$(dbname)] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [$(dbname)] SET  MULTI_USER 
GO
ALTER DATABASE [$(dbname)] SET PAGE_VERIFY CHECKSUM  
GO
USE [$(dbname)]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [$(dbname)] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO

/*
PRINT 'Creando base de datos'
:r cm_dbcreator.sql
*/


/*Apagando los warnings*/
SET ANSI_WARNINGS OFF
SET NOCOUNT OFF

USE $(dbname);

PRINT 'db_0.0.0.2_CM.sql'
:r db_0.0.0.2_CM.sql

PRINT 'db_0.0.0.3_nomencladores.sql'
:r db_0.0.0.3_nomencladores.sql


PRINT 'DB_1.0.0.1.sql'
:r DB_1.0.0.1.sql

PRINT 'db_1.0.0.2.sql'
:r db_1.0.0.2.sql

PRINT 'db_1.0.0.3.sql'
:r db_1.0.0.3.sql

PRINT 'db_1.0.0.4.sql'
:r db_1.0.0.4.sql

PRINT 'db_1.0.0.5.sql'
:r db_1.0.0.5.sql

PRINT 'db_1.0.0.6.sql'
:r db_1.0.0.6.sql

PRINT 'db_1.0.0.7.sql'
:r db_1.0.0.7.sql

PRINT 'db_1.0.0.8.sql'
:r db_1.0.0.8.sql

PRINT 'db_1.0.0.9.sql'
:r db_1.0.0.9.sql

PRINT 'Creando tablas del Módulo Dental'
:r db_1.0.1.0.sql
PRINT 'Insertando valores por defecto en Modulo Dental'
:r db_1.0.1.1.sql

PRINT 'db_1.0.1.2.sql'
:r db_1.0.1.2.sql

PRINT 'db_1.0.1.3.sql'
:r db_1.0.1.3.sql

PRINT 'db_1.0.1.4.sql'
:r db_1.0.1.4.sql


PRINT 'db_1.0.1.5.sql'
:r db_1.0.1.5.sql

PRINT 'db_1.0.1.6.sql'
:r db_1.0.1.6.sql

PRINT 'db_1.0.1.7.sql'
:r db_1.0.1.7.sql

PRINT 'db_1.0.1.8.sql'
:r db_1.0.1.8.sql

PRINT 'db_1.0.1.9.sql'
:r db_1.0.1.9.sql

PRINT 'db_1.0.2.0.sql'
:r db_1.0.2.0.sql

PRINT 'db_1.0.2.1.sql'
:r db_1.0.2.1.sql

PRINT 'db_1.0.2.2.sql'
:r db_1.0.2.2.sql

PRINT 'db_1.0.2.3.sql'
:r db_1.0.2.3.sql

PRINT 'db_1.0.2.4.sql'
:r db_1.0.2.4.sql

PRINT 'db_1.0.2.5.sql'
:r db_1.0.2.5.sql

PRINT 'db_1.0.2.6.sql'
:r db_1.0.2.6.sql

PRINT 'db_1.0.2.7.sql'
:r db_1.0.2.7.sql

PRINT 'db_1.0.2.8.sql'
:r db_1.0.2.8.sql

PRINT 'db_1.0.2.9.sql'
:r db_1.0.2.9.sql

PRINT 'db_1.0.3.0.sql'
:r db_1.0.3.0.sql

PRINT 'db_1.0.3.1.sql'
:r db_1.0.3.1.sql

PRINT 'db_1.0.3.2.sql'
:r db_1.0.3.2.sql

/*Restaurando valores*/
SET ANSI_WARNINGS ON
SET NOCOUNT ON


PRINT 'Completado.'
GO