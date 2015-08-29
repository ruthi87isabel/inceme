IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'@@CM')
	DROP DATABASE [@@CM]
GO

CREATE DATABASE [@@CM]  ON (NAME = N'@@CM_Data', FILENAME = N'@@MDF_NAME' , SIZE = 8, FILEGROWTH = 10%) LOG ON (NAME = N'@@CM_Log', FILENAME = N'@@LOG_NAME' , SIZE = 1, FILEGROWTH = 10%)
 COLLATE Modern_Spanish_CI_AS
GO

exec sp_dboption N'@@CM', N'autoclose', N'true'
GO

exec sp_dboption N'@@CM', N'bulkcopy', N'false'
GO

exec sp_dboption N'@@CM', N'trunc. log', N'true'
GO

exec sp_dboption N'@@CM', N'torn page detection', N'true'
GO

exec sp_dboption N'@@CM', N'read only', N'false'
GO

exec sp_dboption N'@@CM', N'dbo use', N'false'
GO

exec sp_dboption N'@@CM', N'single', N'false'
GO

exec sp_dboption N'@@CM', N'autoshrink', N'true'
GO

exec sp_dboption N'@@CM', N'ANSI null default', N'false'
GO

exec sp_dboption N'@@CM', N'recursive triggers', N'false'
GO

exec sp_dboption N'@@CM', N'ANSI nulls', N'false'
GO

exec sp_dboption N'@@CM', N'concat null yields null', N'false'
GO

exec sp_dboption N'@@CM', N'cursor close on commit', N'false'
GO

exec sp_dboption N'@@CM', N'default to local cursor', N'false'
GO

exec sp_dboption N'@@CM', N'quoted identifier', N'false'
GO

exec sp_dboption N'@@CM', N'ANSI warnings', N'false'
GO

exec sp_dboption N'@@CM', N'auto create statistics', N'true'
GO

exec sp_dboption N'@@CM', N'auto update statistics', N'true'
GO

if( (@@microsoftversion / power(2, 24) = 8) and (@@microsoftversion & 0xffff >= 724) )
	exec sp_dboption N'@@CM', N'db chaining', N'false'
GO

use [@@CM]
GO

