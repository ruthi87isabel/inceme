/*BEGIN La longitud de los campos Descripcion y Notas en tabla Liquidacion de Medicos*/
ALTER TABLE Liquidacion_Medico ALTER COLUMN Descripcion nvarchar(MAX)
ALTER TABLE Liquidacion_Medico ALTER COLUMN Notas nvarchar(MAX)
/*END La longitud de los campos Descripcion y Notas en tabla Liquidacion de Medicos*/

/*BEGIN La longitud del campo Descripcion en tabla Liquidacion_Medico_Linea*/
ALTER TABLE Liquidacion_Medico_Linea ALTER COLUMN Descripcion nvarchar(MAX)
/*END La longitud del campo Descripcion en tabla Liquidacion_Medico_Linea*/

/*BEGIN La longitud del campo Notas en tabla PagosPaciente*/
ALTER TABLE PagosPaciente ALTER COLUMN Notas nvarchar(MAX)
/*END La longitud del campo Notas en tabla PagosPaciente */

Update VariablesGlobales Set Valor = '1.0.2.1' where Clave = 'DB_Version';