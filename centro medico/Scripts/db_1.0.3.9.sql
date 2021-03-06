CREATE Procedure [dbo].[DamePacienteBonos]

-- Obtener los id de los nomencladores dela tabla [S_ExpTemSeleccion]

 @nombre NVARCHAR(30),
 @pApellido NVARCHAR(30),
 @sApellido NVARCHAR(30)

AS
BEGIN
  DECLARE @temp TABLE (cpaciente INT, Nombre VARCHAR(30),Apellido1 VARCHAR(30),Apellido2 VARCHAR(30),DNI VARCHAR(10), Fechan DATETIME, Bonos INT, Sesiones INT)
INSERT @temp 

SELECT dbo.PACIENTES.CPACIENTE,NOMBRE,APELLIDO1,APELLIDO2,DNI,FECHAN, COUNT(Bonos.id) AS BONOS,(numsesiones-COUNT(dbo.Sesiones.id)) AS SESIONES FROM dbo.PACIENTES
INNER JOIN  dbo.Bonos ON dbo.PACIENTES.CPACIENTE = dbo.Bonos.cpaciente
LEFT OUTER JOIN dbo.Sesiones ON dbo.Bonos.id = dbo.Sesiones.refbono
GROUP BY Bonos.id,numsesiones,dbo.PACIENTES.cpaciente,NOMBRE,APELLIDO1,APELLIDO2,DNI,FECHAN
--HAVING (numsesiones-COUNT(dbo.Sesiones.id))>0 
ORDER BY NOMBRE,APELLIDO1,APELLIDO2

SELECT Nombre,Apellido1,Apellido2,DNI,Fechan, COUNT(Bonos) AS BONOS, SUM (Sesiones) AS SESIONES FROM @temp
WHERE  ((Nombre LIKE '%'+@nombre+'%') And
((Apellido1 Is NULL) OR (Apellido1 IS NOT NULL AND Apellido1 LIKE '%'+@pApellido+'%')) And
((Apellido2 Is NULL) Or (Apellido2 IS NOT NULL AND Apellido2 LIKE '%'+@sApellido+'%')))
GROUP BY Nombre,Apellido1,Apellido2,DNI,Fechan
HAVING  SUM (Sesiones)>0
ORDER BY NOMBRE 
  
  END 
  
 GO
Update VariablesGlobales Set Valor = '1.0.3.9' where Clave = 'DB_Version';
PRINT 'DB_Version: 1.0.3.9';
GO 