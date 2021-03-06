use  Integral



/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 15.2 		*/
/*  Created On : 30-Jun.-2021 17:04:54 				*/
/*  DBMS       : SQL Server 2012 						*/
/* ---------------------------------------------------- */

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_CursoEvaluacion_Curso]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [CursoEvaluacion] DROP CONSTRAINT [FK_CursoEvaluacion_Curso]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_CursoPlanificacion_Planificacion]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [CursoPlanificacion] DROP CONSTRAINT [FK_CursoPlanificacion_Planificacion]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_CursoPlanificacion_Curso]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [CursoPlanificacion] DROP CONSTRAINT [FK_CursoPlanificacion_Curso]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Estudiante_Tutorestudiante]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Estudiante] DROP CONSTRAINT [FK_Estudiante_Tutorestudiante]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_EstudianteCurso_Curso]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [EstudianteCurso] DROP CONSTRAINT [FK_EstudianteCurso_Curso]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_EstudianteCurso_Estudiante]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [EstudianteCurso] DROP CONSTRAINT [FK_EstudianteCurso_Estudiante]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_EstudianteMatricula_Matricula]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [EstudianteMatricula] DROP CONSTRAINT [FK_EstudianteMatricula_Matricula]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_EstudianteMatricula_Estudiante]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [EstudianteMatricula] DROP CONSTRAINT [FK_EstudianteMatricula_Estudiante]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_EvaluacionCalificacion_Calificacion]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [EvaluacionCalificacion] DROP CONSTRAINT [FK_EvaluacionCalificacion_Calificacion]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_PlanificacionDocente_Docente]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [PlanificacionDocente] DROP CONSTRAINT [FK_PlanificacionDocente_Docente]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_PlanificacionDocente_Planificacion]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [PlanificacionDocente] DROP CONSTRAINT [FK_PlanificacionDocente_Planificacion]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Tutor_Tutorestudiante]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Tutor] DROP CONSTRAINT [FK_Tutor_Tutorestudiante]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Calificacion]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Calificacion]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Curso]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Curso]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[CursoEvaluacion]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [CursoEvaluacion]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[CursoPlanificacion]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [CursoPlanificacion]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Docente]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Docente]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Estudiante]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Estudiante]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[EstudianteCurso]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [EstudianteCurso]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[EstudianteMatricula]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [EstudianteMatricula]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[EvaluacionCalificacion]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [EvaluacionCalificacion]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Matricula]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Matricula]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Planificacion]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Planificacion]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[PlanificacionDocente]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [PlanificacionDocente]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Tutor]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Tutor]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Tutorestudiante]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Tutorestudiante]
GO

/* Create Tables */

CREATE TABLE [Calificacion]
(
	[Idestudiante] int NULL,
	[Idevaluacion] int NULL,
	[CalificacionID] int NOT NULL
)
GO

CREATE TABLE [Curso]
(
	[Codigocurso] int NULL DEFAULT 1,
	[Descripcion] varchar(50) NULL,
	[Nombre] varchar(50) NULL,
	[CursoID] int NOT NULL
)
GO

CREATE TABLE [CursoEvaluacion]
(
	[CursoID] int NULL
)
GO

CREATE TABLE [CursoPlanificacion]
(
	[PlanificacionID] int NULL,
	[CursoID] int NULL
)
GO

CREATE TABLE [Docente]
(
	[Apellidomaterno] varchar(50) NULL,
	[Apellidopaterno] varchar(50) NULL,
	[Direccion] varchar(50) NULL,
	[Dni] varchar(50) NULL,
	[Email] varchar(50) NULL,
	[Especialidad] varchar(50) NULL,
	[Fechanacimiento] date NULL,
	[Iddocente] int NULL DEFAULT 1,
	[Nombre] varchar(50) NULL,
	[Sexo] varchar(50) NULL,
	[Telefono] varchar(50) NULL,
	[DocenteID] int NOT NULL
)
GO

CREATE TABLE [Estudiante]
(
	[Apellidomaterno] varchar(50) NULL,
	[Apellidopaterno] varchar(50) NULL,
	[Correo] varchar(50) NULL,
	[Direccion] varchar(50) NULL,
	[Dni] varchar(50) NULL,
	[Fechanacimiento] date NULL,
	[Idestudiante] int NULL DEFAULT 1,
	[Nombre] varchar(50) NULL,
	[Sexo] varchar(50) NULL,
	[Telefono] varchar(50) NULL,
	[EstudianteID] int NOT NULL,
	[TutorestudianteID] int NULL
)
GO

CREATE TABLE [EstudianteCurso]
(
	[CursoID] int NULL,
	[EstudianteID] int NULL
)
GO

CREATE TABLE [EstudianteMatricula]
(
	[MatriculaID] int NULL,
	[EstudianteID] int NULL
)
GO

CREATE TABLE [EvaluacionCalificacion]
(
	[CalificacionID] int NULL
)
GO

CREATE TABLE [Matricula]
(
	[Escuelaprocedencia] varchar(50) NULL,
	[Estado] varchar(50) NULL,
	[Fechainscripcion] date NULL,
	[Gradoescolar] int NULL,
	[Idestudiante] int NULL,
	[Idmatricula] int NULL DEFAULT 1,
	[Seccion] varchar(50) NULL,
	[Turno] varchar(50) NULL,
	[MatriculaID] int NOT NULL
)
GO

CREATE TABLE [Planificacion]
(
	[Descripcion] varchar(50) NULL,
	[Fecharegistro] date NULL,
	[Idplanificacion] int NULL DEFAULT 1,
	[Titulo] varchar(50) NULL,
	[PlanificacionID] int NOT NULL
)
GO

CREATE TABLE [PlanificacionDocente]
(
	[DocenteID] int NULL,
	[PlanificacionID] int NULL
)
GO

CREATE TABLE [Tutor]
(
	[Apellidomaterno] varchar(50) NULL,
	[Apellidopaterno] varchar(50) NULL,
	[Direccion] varchar(50) NULL,
	[Dni] varchar(50) NULL,
	[Email] varchar(50) NULL,
	[Fechanacimiento] date NULL,
	[Idtutor] int NULL DEFAULT 1,
	[Nivelacademico] varchar(50) NULL,
	[Nombre] varchar(50) NULL,
	[Ocupacion] varchar(50) NULL,
	[Sexo] varchar(50) NULL,
	[Telefono] varchar(50) NULL,
	[TutorID] int NOT NULL,
	[TutorestudianteID] int NULL
)
GO

CREATE TABLE [Tutorestudiante]
(
	[Parentesco] varchar(50) NULL,
	[TutorestudianteID] int NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [Calificacion] 
 ADD CONSTRAINT [PK_Calificacion]
	PRIMARY KEY CLUSTERED ([CalificacionID] ASC)
GO

ALTER TABLE [Curso] 
 ADD CONSTRAINT [PK_Curso]
	PRIMARY KEY CLUSTERED ([CursoID] ASC)
GO

ALTER TABLE [Docente] 
 ADD CONSTRAINT [PK_Docente]
	PRIMARY KEY CLUSTERED ([DocenteID] ASC)
GO

ALTER TABLE [Estudiante] 
 ADD CONSTRAINT [PK_Estudiante]
	PRIMARY KEY CLUSTERED ([EstudianteID] ASC)
GO

ALTER TABLE [Matricula] 
 ADD CONSTRAINT [PK_Matricula]
	PRIMARY KEY CLUSTERED ([MatriculaID] ASC)
GO

ALTER TABLE [Planificacion] 
 ADD CONSTRAINT [PK_Planificacion]
	PRIMARY KEY CLUSTERED ([PlanificacionID] ASC)
GO

ALTER TABLE [Tutor] 
 ADD CONSTRAINT [PK_Tutor]
	PRIMARY KEY CLUSTERED ([TutorID] ASC)
GO

ALTER TABLE [Tutorestudiante] 
 ADD CONSTRAINT [PK_Tutorestudiante]
	PRIMARY KEY CLUSTERED ([TutorestudianteID] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [CursoEvaluacion] ADD CONSTRAINT [FK_CursoEvaluacion_Curso]
	FOREIGN KEY ([CursoID]) REFERENCES [Curso] ([CursoID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [CursoPlanificacion] ADD CONSTRAINT [FK_CursoPlanificacion_Planificacion]
	FOREIGN KEY ([PlanificacionID]) REFERENCES [Planificacion] ([PlanificacionID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [CursoPlanificacion] ADD CONSTRAINT [FK_CursoPlanificacion_Curso]
	FOREIGN KEY ([CursoID]) REFERENCES [Curso] ([CursoID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Estudiante] ADD CONSTRAINT [FK_Estudiante_Tutorestudiante]
	FOREIGN KEY ([TutorestudianteID]) REFERENCES [Tutorestudiante] ([TutorestudianteID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [EstudianteCurso] ADD CONSTRAINT [FK_EstudianteCurso_Curso]
	FOREIGN KEY ([CursoID]) REFERENCES [Curso] ([CursoID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [EstudianteCurso] ADD CONSTRAINT [FK_EstudianteCurso_Estudiante]
	FOREIGN KEY ([EstudianteID]) REFERENCES [Estudiante] ([EstudianteID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [EstudianteMatricula] ADD CONSTRAINT [FK_EstudianteMatricula_Matricula]
	FOREIGN KEY ([MatriculaID]) REFERENCES [Matricula] ([MatriculaID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [EstudianteMatricula] ADD CONSTRAINT [FK_EstudianteMatricula_Estudiante]
	FOREIGN KEY ([EstudianteID]) REFERENCES [Estudiante] ([EstudianteID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [EvaluacionCalificacion] ADD CONSTRAINT [FK_EvaluacionCalificacion_Calificacion]
	FOREIGN KEY ([CalificacionID]) REFERENCES [Calificacion] ([CalificacionID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [PlanificacionDocente] ADD CONSTRAINT [FK_PlanificacionDocente_Docente]
	FOREIGN KEY ([DocenteID]) REFERENCES [Docente] ([DocenteID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [PlanificacionDocente] ADD CONSTRAINT [FK_PlanificacionDocente_Planificacion]
	FOREIGN KEY ([PlanificacionID]) REFERENCES [Planificacion] ([PlanificacionID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Tutor] ADD CONSTRAINT [FK_Tutor_Tutorestudiante]
	FOREIGN KEY ([TutorestudianteID]) REFERENCES [Tutorestudiante] ([TutorestudianteID]) ON DELETE No Action ON UPDATE No Action
GO
