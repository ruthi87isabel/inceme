
DECLARE @CollationName NVARCHAR(200)
DECLARE @SQLString NVARCHAR(500)

SET @CollationName = (select collation_name from information_schema.columns where table_name = 'CONCEPTOSFRA' and column_name='CODIGO')

SET @SQLString = 'ALTER TABLE d_Acciones ALTER COLUMN IDTratamiento varchar(10) COLLATE '+@CollationName+' NOT NULL'
EXEC(@SQLString)

SET @SQLString = 'ALTER TABLE d_ConceptosFra_Imagenes ALTER COLUMN d_ConceptosFra_Imagenes varchar(10) COLLATE '+@CollationName+' NOT NULL'
EXEC(@SQLString)

SET @SQLString = 'ALTER TABLE d_PresupuestoLineas ALTER COLUMN d_PresupuestoLineas varchar(10) COLLATE '+@CollationName+' NOT NULL'
EXEC(@SQLString)

GO