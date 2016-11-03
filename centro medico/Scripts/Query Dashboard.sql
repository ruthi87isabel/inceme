1) Citas del día según su estado (confirmada, atendida, anulada, cobrada). Se trata de ver para el día actual el nº de citas en tiempo 
   real según la etapa en la que están

		SELECT cast(DATEPART(hh, HORA) as varchar)+':'+cast(DATEPART(mi, HORA) as varchar) AS 'HORARIO',  p.NOMBRE + ' ' + p.APELLIDO1 + ' ' + p.APELLIDO2 AS 'PACIENTE', DESCRIPCION AS 'CITAS',
		 m.NOMBRE + ' ' + m.APELLIDO1 + ' ' + m.APELLIDO2 AS 'MEDICO', ESPECIALIDAD, 
		 CASE WHEN CONFIRMADA = 'S' THEN 'Si' 
			  WHEN CONFIRMADA = 'N' THEN 'No' END AS 'CONFIRMADA',
		 CASE WHEN ATENDIDO = 'S' THEN 'Si' 
			  WHEN ATENDIDO = 'N' THEN 'No' END AS 'ATENDIDO',
		 CASE WHEN FALTA  = 'S' THEN 'Si' 
			  WHEN FALTA  = 'N' THEN 'No' END AS 'ANULADA',
		 CASE WHEN PAGADA = 'S' THEN 'Si' 
			  WHEN PAGADA = 'N' THEN 'No' END AS 'PAGADA'
		 FROM dbo.CITAS
		INNER JOIN dbo.PACIENTES p ON dbo.CITAS.REFPACIENTE = p.CPACIENTE
		INNER JOIN dbo.LineasCitas ON dbo.CITAS.IDCITA = dbo.LineasCitas.IdCita
		INNER JOIN dbo.MEDICOS m ON dbo.CITAS.REFMEDICO = m.CMEDICO
		WHERE FECHA = GETDATE()
		ORDER BY HORA

-- Keda pendiente poner la hora en formato 12:03

--WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW

2)	Nuevos pacientes por meses. Según un intervalo de fechas dado (por defecto que coja el mes completo en el que te encuentras)
	que nos informe del cuantos nuevos pacientes hay (en la ficha de paciente hay un campo que es “fecha alta”).
	
	
		DECLARE @Fecha1 DATETIME=NULL
		DECLARE @Fecha2 DATETIME=NULL
		
			SELECT CPACIENTE,NOMBRE,APELLIDO1,APELLIDO2,DNI,TLFNO,EMAIL,FECHAALTA FROM dbo.PACIENTES
			WHERE (
			((@Fecha1 Is NOT NULL AND @Fecha2 Is NOT NULL) AND (FECHAALTA>=@Fecha1 AND FECHAALTA<=@Fecha2))
			 OR 
			((@Fecha1 Is NULL AND @Fecha2 IS NULL) AND (DATEPART(MM, FECHAALTA) = DATEPART(MM, GETDATE()) AND (DATEPART(yyyy, FECHAALTA) = DATEPART(yyyy, GETDATE())) ) )
			)
			ORDER BY FECHAALTA DESC
		
--WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
		
3)  Citas atendidas por médico /día. Poder indicar intervalo de fechas y que indique cuántas citas atiende el médico en cada uno
    de los días de ese intervalo.
    
		DECLARE @Fecha3 DATETIME=NULL
		DECLARE @Fecha4 DATETIME=NULL
	    
		SELECT FECHA, m.NOMBRE + ' ' + m.APELLIDO1 + ' ' + m.APELLIDO2 AS 'MEDICO', ESPECIALIDAD, COUNT(REFMEDICO) AS 'CantCitas' FROM dbo.CITAS
		INNER JOIN dbo.MEDICOS m ON dbo.CITAS.REFMEDICO = m.CMEDICO
		WHERE (
			((@Fecha3 Is NOT NULL AND @Fecha4 Is NOT NULL) AND (FECHA>=@Fecha3 AND FECHA<=@Fecha4))
			 OR 
			((@Fecha3 Is NULL AND @Fecha4 IS NULL) AND (DATEPART(MM, FECHA) = DATEPART(MM, GETDATE()) AND (DATEPART(yyyy, FECHA) = DATEPART(yyyy, GETDATE())) ) )
			)
		GROUP BY FECHA, ESPECIALIDAD, REFMEDICO,m.NOMBRE,m.APELLIDO1,m.APELLIDO2 	
		ORDER BY FECHA DESC, NOMBRE
	
--WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW	
	
4)  Citas por Especialidad por mes. Según un intervalo de fechas dado (por defecto que coja el mes completo en el que te encuentras)
    que nos informe del nº de citas por cada especialidad (la especialidad va asociada al médico que atiende la cita).
    
		DECLARE @Fecha5 DATETIME=NULL
		DECLARE @Fecha6 DATETIME=NULL
	    
		SELECT (cast(DATEPART(yyyy, FECHA) AS VARCHAR)+'-'+ cast(DATEPART(MM, FECHA) AS VARCHAR)) AS 'FECHA', ESPECIALIDAD, COUNT(ESPECIALIDAD) AS 'CantCitas' FROM dbo.CITAS
		INNER JOIN dbo.MEDICOS m ON dbo.CITAS.REFMEDICO = m.CMEDICO
		WHERE (
			((@Fecha5 Is NOT NULL AND @Fecha6 Is NOT NULL) AND (FECHA>=@Fecha5 AND FECHA<=@Fecha6))
			 OR 
			((@Fecha5 Is NULL AND @Fecha6 IS NULL) AND (DATEPART(MM, FECHA) = DATEPART(MM, GETDATE()) AND (DATEPART(yyyy, FECHA) = DATEPART(yyyy, GETDATE())) ) )
			)
		GROUP BY (cast(DATEPART(yyyy, FECHA) AS VARCHAR)+'-'+ cast(DATEPART(MM, FECHA) AS VARCHAR)), ESPECIALIDAD
		ORDER BY FECHA DESC ,ESPECIALIDAD
		
		-- Keda pendiente poner la fecha en formato 2015-03
		
--WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW

5)  Los 10 tratamientos más realizados por mes (según intervalo de fechas). Los tratamientos se cogen de los conceptos añadidos en las citas que
    esten dados de alta como concepto facturable.	
    
		DECLARE @Fecha7 DATETIME=NULL
		DECLARE @Fecha8 DATETIME=NULL
		
		;WITH q AS 
		(
			SELECT (cast(DATEPART(yyyy, FECHA) AS VARCHAR)+'-'+ cast(DATEPART(MM, FECHA) AS VARCHAR)) AS 'FECHA',c.DESCRIPCION AS 'Tratamiento', COUNT(c.DESCRIPCION) AS 'CantTratamientos' 
			,rn = ROW_NUMBER() 
			OVER (PARTITION BY (cast(DATEPART(yyyy, FECHA) AS VARCHAR)+'-'+ cast(DATEPART(MM, FECHA) AS VARCHAR)) ORDER BY COUNT(c.DESCRIPCION) DESC)
			FROM  dbo.CITAS
			INNER JOIN dbo.LineasCitas ON dbo.CITAS.IDCITA = dbo.LineasCitas.IdCita
			INNER JOIN dbo.CONCEPTOSFRA c ON LineasCitas.RefConcepto=c.CODIGO
			WHERE (
					((@Fecha7 Is NOT NULL AND @Fecha8 Is NOT NULL) AND (FECHA>=@Fecha7 AND FECHA<=@Fecha8))
					 OR 
					(@Fecha7 Is NULL AND @Fecha8 IS NULL) --AND (DATEPART(MM, FECHA) = DATEPART(MM, GETDATE()) AND (DATEPART(yyyy, FECHA) = DATEPART(yyyy, GETDATE())) ) )
				  )
			GROUP BY (cast(DATEPART(yyyy, FECHA) AS VARCHAR)+'-'+ cast(DATEPART(MM, FECHA) AS VARCHAR)),c.DESCRIPCION
		)
		SELECT FECHA,Tratamiento,CantTratamientos
		FROM  q
		WHERE rn<=10
		ORDER BY FECHA DESC, CantTratamientos DESC
		
		-- Keda pendiente poner la fecha en formato 2015-03

--WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW	
	
6)	Dental - Estadística de tratamientos presupuestados frente a tratamientos aceptados por mes en base a intervalo de fechas		
		
		
		
--WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW			

SEGURIDAD

		
		SELECT * FROM dbo.ROLES  
		SELECT * FROM dbo.ROLESUSUARIOS  
		SELECT * FROM dbo.ROLESITEMS  --funcionalidades
		
		SELECT * FROM dbo.PERMISOS  
		SELECT * FROM dbo.PERMISOS_USUARIO
		
		SELECT * FROM dbo.ROLESPERMISOS  --rol-permiso-funcionalidad