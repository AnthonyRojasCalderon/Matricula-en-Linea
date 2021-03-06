USE [master]
GO
/****** Object:  Database [MatriculaEnLinea]    Script Date: 14-dic-20 12:25:52 AM ******/
CREATE DATABASE [MatriculaEnLinea]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MatriculaEnLinea', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\MatriculaEnLinea.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MatriculaEnLinea_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\MatriculaEnLinea_log.ldf' , SIZE = 1344KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MatriculaEnLinea] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MatriculaEnLinea].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MatriculaEnLinea] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET ARITHABORT OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MatriculaEnLinea] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MatriculaEnLinea] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MatriculaEnLinea] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MatriculaEnLinea] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MatriculaEnLinea] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MatriculaEnLinea] SET  MULTI_USER 
GO
ALTER DATABASE [MatriculaEnLinea] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MatriculaEnLinea] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MatriculaEnLinea] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MatriculaEnLinea] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MatriculaEnLinea] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MatriculaEnLinea] SET QUERY_STORE = OFF
GO
USE [MatriculaEnLinea]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [MatriculaEnLinea]
GO
/****** Object:  Table [dbo].[Aulas]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aulas](
	[CodigoAula] [int] NOT NULL,
	[DescAula] [nvarchar](50) NULL,
	[EstAula] [int] NULL,
 CONSTRAINT [PK_Aulas] PRIMARY KEY CLUSTERED 
(
	[CodigoAula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cantones]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cantones](
	[codCanton] [int] NULL,
	[desCanton] [varchar](50) NULL,
	[codProvincia] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carreras](
	[CodigoCarrera] [int] NOT NULL,
	[DescCarrera] [nvarchar](50) NULL,
	[EstCarrera] [int] NULL,
 CONSTRAINT [PK_Carreras] PRIMARY KEY CLUSTERED 
(
	[CodigoCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[CodigoEstado] [int] NULL,
	[DescEstado] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[CodMaterias] [int] NOT NULL,
	[DescMaterias] [nvarchar](50) NULL,
	[EstMaterias] [int] NULL,
	[CodigoCarrera] [int] NULL,
 CONSTRAINT [PK_Materias] PRIMARY KEY CLUSTERED 
(
	[CodMaterias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matricula]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matricula](
	[CodMatricula] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [varchar](50) NULL,
	[CodCarrera] [int] NULL,
	[CodMateria] [int] NULL,
	[CodProfesor] [int] NULL,
	[FechaRegistro] [date] NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Matricula] PRIMARY KEY CLUSTERED 
(
	[CodMatricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfiles](
	[codigo_perfil] [int] NOT NULL,
	[descripcion_perfil] [varchar](50) NOT NULL,
	[estado_perfil] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[Identificacion] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Primer_Apellido] [nvarchar](50) NULL,
	[Segundo_Apellido] [nvarchar](50) NULL,
	[CodMateria] [int] NULL,
	[estado] [int] NULL,
	[CodProfesor] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[codProvincia] [int] NULL,
	[desProvincia] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[identificacion] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[primer_apellido] [nvarchar](50) NOT NULL,
	[segundo_apellido] [nvarchar](50) NOT NULL,
	[usuario] [nvarchar](50) NOT NULL,
	[clave] [nvarchar](50) NOT NULL,
	[estado] [int] NOT NULL,
	[temp_clave] [int] NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosPorPerfiles]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosPorPerfiles](
	[identificacion] [nvarchar](50) NOT NULL,
	[codigo_perfil] [int] NOT NULL,
	[fecha_asociacion] [datetime] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[UsuariosPorPerfiles] ADD  DEFAULT (getdate()) FOR [fecha_asociacion]
GO
ALTER TABLE [dbo].[Materias]  WITH CHECK ADD  CONSTRAINT [FK_Materias_Carreras] FOREIGN KEY([CodigoCarrera])
REFERENCES [dbo].[Carreras] ([CodigoCarrera])
GO
ALTER TABLE [dbo].[Materias] CHECK CONSTRAINT [FK_Materias_Carreras]
GO
ALTER TABLE [dbo].[Profesores]  WITH CHECK ADD  CONSTRAINT [FK_Profesores_Materias] FOREIGN KEY([CodMateria])
REFERENCES [dbo].[Materias] ([CodMaterias])
GO
ALTER TABLE [dbo].[Profesores] CHECK CONSTRAINT [FK_Profesores_Materias]
GO
ALTER TABLE [dbo].[UsuariosPorPerfiles]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosPorPerfiles_Perfiles] FOREIGN KEY([codigo_perfil])
REFERENCES [dbo].[Perfiles] ([codigo_perfil])
GO
ALTER TABLE [dbo].[UsuariosPorPerfiles] CHECK CONSTRAINT [FK_UsuariosPorPerfiles_Perfiles]
GO
ALTER TABLE [dbo].[UsuariosPorPerfiles]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosPorPerfiles_Usuarios] FOREIGN KEY([identificacion])
REFERENCES [dbo].[Usuarios] ([identificacion])
GO
ALTER TABLE [dbo].[UsuariosPorPerfiles] CHECK CONSTRAINT [FK_UsuariosPorPerfiles_Usuarios]
GO
/****** Object:  StoredProcedure [dbo].[PA_Autenticacion]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Autenticacion] 
@identificacion varchar(50),
@clave varchar(50)
AS
BEGIN
	
	SELECT identificacion, nombre +' '+ primer_apellido +' '+ segundo_apellido as nombre_completo, usuario, clave, estado
	FROM Usuarios
	WHERE identificacion = @identificacion 
	AND	  clave = @clave
	AND estado = 1;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_AutorizacionUsuario]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_AutorizacionUsuario] 
@identificacion varchar(50)
AS
BEGIN
	SELECT u.identificacion,u.nombre +' '+ u.primer_apellido + ' '+ u.segundo_apellido as nombre,
	u.usuario, U.clave, U.estado,
	P.codigo_perfil, P.descripcion_perfil, P.estado_perfil,
	UXP.fecha_asociacion
	from Usuarios U, UsuariosPorPerfiles UXP, Perfiles P
	Where U.identificacion = UXP.identificacion
	AND P.codigo_perfil = UXP.codigo_perfil
	AND P.estado_perfil = 1
	AND U.identificacion = @identificacion;


END

GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultaCorreo_Usuario]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultaCorreo_Usuario]
@identificacion varchar(50)
AS
BEGIN
SELECT u.email
FROM Usuarios u
where u.identificacion = @identificacion;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultaEstadoClave_Usuario]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultaEstadoClave_Usuario]
@identificacion varchar(50)
AS
BEGIN
SELECT u.temp_clave
FROM Usuarios u
where u.identificacion = @identificacion;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarAulas]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarAulas]
AS
BEGIN
SELECT CodigoAula as 'Codigo', DescAula as 'Descripcion', EstAula as 'Estado' FROM Aulas Order by CodigoAula desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarCantones]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[PA_ConsultarCantones]
(
	@codigoCanton int,
	@codigoProvincia int
)
as
begin

SELECT codCanton, desCanton, codProvincia
FROM Cantones
WHERE (@codigoCanton = 0 or codCanton = @codigoCanton)
and (@codigoProvincia = 0 or codProvincia = @codigoProvincia)

end
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarCarreras]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarCarreras]
AS
BEGIN
SELECT [CodigoCarrera] as 'Codigo', [DescCarrera] as 'Descripcion', EstCarrera as 'Estado' FROM Carreras 
Order by [CodigoCarrera] desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarInformacion]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarInformacion]
@identificacion varchar(50)
AS
BEGIN
SELECT u.identificacion as 'Identificacion', u.nombre as 'Nombre', u.primer_apellido as 'Primer_Apellido',
u.segundo_apellido as 'Segundo_Apellido', u.usuario as 'Usuario', u.clave as 'Clave', 
u.estado as 'Estado',
p.descripcion_perfil 'Rol' 
FROM Usuarios u inner join UsuariosPorPerfiles up
on u.identificacion = up.identificacion
inner join Perfiles p 
on p.codigo_perfil = up.codigo_perfil
where u.identificacion = @identificacion
order by identificacion desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarMaterias]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarMaterias]
AS
BEGIN
SELECT M.CodMaterias as 'Codigo', M.DescMaterias as 'Descripcion', M.EstMaterias as 'Estado' ,
C.CodigoCarrera 'Codigo',C.DescCarrera as 'Carrera'
FROM Materias M INNER JOIN Carreras C
ON C.CodigoCarrera = M.CodigoCarrera
Order by CodMaterias desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarMaterias_x_Carrera]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarMaterias_x_Carrera]
@codigoCarrera int
AS
BEGIN
SELECT CodMaterias,DescMaterias,EstMaterias FROM Materias
WHERE CodigoCarrera = @codigoCarrera;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarMatricula]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarMatricula]
@identificacion varchar(50)
AS
BEGIN
SELECT M.CodMatricula as 'Codigo', M.Identificacion as 'Identificacion',
Ca.CodigoCarrera as 'CodCarrera',
Ca.DescCarrera as 'Carrera',
Ma.CodMaterias as 'CodMateria',
Ma.DescMaterias as 'Materia',
P.CodProfesor as 'CodProfesor',
P.Nombre +' '+ P.Primer_Apellido +' '+ P.Segundo_Apellido as 'Nombre',
CASE 
WHEN M.Estado = 1 THEN 'Matriculada' 
WHEN M.Estado = 2 THEN 'Congelada' END as 'Estado'
FROM Matricula M
inner join Carreras Ca
on Ca.CodigoCarrera = M.CodCarrera
inner join Materias Ma
on Ma.CodMaterias = M.CodMateria
inner join Profesores P
on P.CodProfesor = M.CodProfesor
where M.Identificacion = @identificacion
Order by M.CodMatricula desc;
END


GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarProfesores]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarProfesores]
AS
BEGIN
SELECT P.Identificacion as 'Identificacion', P.Nombre as 'Nombre', P.Primer_Apellido as 'Primer_Apellido',
P.Segundo_Apellido as 'Segundo_Apellido', M.CodMaterias as 'Codigo', M.DescMaterias as 'Materia', P.estado as 'Estado' 
FROM Profesores P
INNER JOIN Materias M
on M.CodMaterias = P.CodMateria 
Order by P.Identificacion desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarProfesores_x_Materia]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarProfesores_x_Materia]
@codigoMateria int
AS
BEGIN
SELECT CodProfesor,
Identificacion,Nombre +' '+ Primer_Apellido +' '+ Segundo_Apellido as 'Nombre',estado FROM Profesores
WHERE CodMateria = @codigoMateria;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarProvincias]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[PA_ConsultarProvincias]
(
	@codigo int
)
as
begin

SELECT codProvincia, desProvincia
FROM Provincias
WHERE @codigo = 0 or codProvincia = @codigo

end
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarUsuarios]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarUsuarios]
AS
BEGIN
SELECT u.identificacion as 'Identificacion', u.nombre as 'Nombre', u.primer_apellido as 'Primer_Apellido',
u.segundo_apellido as 'Segundo_Apellido', u.usuario as 'Usuario', u.clave as 'Clave', 
u.estado as 'Estado',
p.descripcion_perfil 'Rol',
u.temp_clave,
u.email as 'Correo'
FROM Usuarios u inner join UsuariosPorPerfiles up
on u.identificacion = up.identificacion
inner join Perfiles p 
on p.codigo_perfil = up.codigo_perfil
order by identificacion desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarUsuarios_X_Estado_Clave]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarUsuarios_X_Estado_Clave]
AS
BEGIN
SELECT u.identificacion as 'Identificacion', u.nombre as 'Nombre', u.primer_apellido as 'Primer_Apellido',
u.segundo_apellido as 'Segundo_Apellido', u.usuario as 'Usuario', u.clave as 'Clave', 
u.estado as 'Estado',
p.descripcion_perfil 'Rol',
u.temp_clave,
u.email as 'Correo'
FROM Usuarios u inner join UsuariosPorPerfiles up
on u.identificacion = up.identificacion
inner join Perfiles p 
on p.codigo_perfil = up.codigo_perfil
where u.temp_clave = 1
order by identificacion desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarUsuarios_X_Estado_Clave_C]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ConsultarUsuarios_X_Estado_Clave_C]
AS
BEGIN
SELECT u.identificacion as 'Identificacion', u.nombre as 'Nombre', u.primer_apellido as 'Primer_Apellido',
u.segundo_apellido as 'Segundo_Apellido', u.usuario as 'Usuario', u.clave as 'Clave', 
u.estado as 'Estado',
p.descripcion_perfil 'Rol',
u.temp_clave,
u.email as 'Correo'
FROM Usuarios u inner join UsuariosPorPerfiles up
on u.identificacion = up.identificacion
inner join Perfiles p 
on p.codigo_perfil = up.codigo_perfil
where u.temp_clave = 0
order by identificacion desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Eliminar_Mant_Aula]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Eliminar_Mant_Aula] 
@codigoAula int
AS
BEGIN
	DELETE FROM Aulas 
	WHERE CodigoAula = @codigoAula;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Eliminar_Mant_Carrera]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Eliminar_Mant_Carrera] 
@codigoCarrera int
AS
BEGIN
	DELETE FROM Carreras 
	WHERE CodigoCarrera = @codigoCarrera;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Eliminar_Mant_Materia]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Eliminar_Mant_Materia] 
@codigoMateria int
AS
BEGIN
	DELETE FROM Materias 
	WHERE CodMaterias = @codigoMateria;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Eliminar_Mant_Profesor]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Eliminar_Mant_Profesor] 
@identificacion varchar(50)
AS
BEGIN
	DELETE FROM Profesores
	WHERE identificacion = @identificacion;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Eliminar_Mant_Usuario]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Eliminar_Mant_Usuario] 
@identificacion varchar(50)
AS
BEGIN
	DELETE FROM UsuariosPorPerfiles 
	WHERE identificacion = @identificacion;
	DELETE FROM Usuarios
	WHERE identificacion = @identificacion;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Ingresar_Mant_Aulas]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Ingresar_Mant_Aulas] 
@codigoAula int,
@descAula varchar(50),
@estAula int
AS
BEGIN
	INSERT INTO Aulas(CodigoAula,DescAula,EstAula)
	VALUES(@codigoAula,@descAula,@estAula);
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Ingresar_Mant_Carreras]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Ingresar_Mant_Carreras] 
@codigoCarrera int,
@descCarrera varchar(50),
@estCarrera int
AS
BEGIN
	INSERT INTO Carreras(CodigoCarrera,DescCarrera,EstCarrera)
	VALUES(@codigoCarrera,@descCarrera,@estCarrera);
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Ingresar_Mant_Materias]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Ingresar_Mant_Materias] 
@codigoMateria int,
@descMateria varchar(50),
@estMateria int,
@codCarrera int
AS
BEGIN
	INSERT INTO Materias(CodMaterias,DescMaterias,EstMaterias,CodigoCarrera)
	VALUES(@codigoMateria,@descMateria,@estMateria,@codCarrera);
END



GO
/****** Object:  StoredProcedure [dbo].[PA_Ingresar_Mant_Profesores]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Ingresar_Mant_Profesores] 
@identificacion varchar(50),
@nombre varchar(50),
@primer_apellido varchar(50),
@segundo_apellido varchar(50),
@codEstado int,
@estado int
AS
BEGIN
	INSERT INTO Profesores(Identificacion,Nombre,Primer_Apellido,Segundo_Apellido,CodMateria,estado)
	VALUES(@identificacion,@nombre,@primer_apellido,@segundo_apellido,@codEstado,@estado);
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Ingresar_Mant_Usuario]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Ingresar_Mant_Usuario] 
@identificacion varchar(50),
@nombre varchar(50),
@primer_apellido varchar(50),
@segundo_apellido varchar(50),
@usuario varchar(50),
@clave varchar(50),
@estado int,
@rol varchar(50),
@email varchar(50)
AS
BEGIN
	INSERT INTO Usuarios(identificacion,nombre,primer_apellido,segundo_apellido,usuario,clave,estado,temp_clave,email)
	VALUES(@identificacion,@nombre,@primer_apellido,@segundo_apellido,@usuario,@clave,@estado,0,@email);

	DECLARE @valor INT;
	SET @valor = 0;
	
	IF (@rol = 'Funcionario')
	BEGIN
	set @valor = 1;
	END
	ELSE
	BEGIN
	set @valor = 2;
	END

	INSERT INTO UsuariosPorPerfiles(identificacion,codigo_perfil,fecha_asociacion)
	VALUES(@identificacion,@valor,GETDATE());
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Ingresar_Matricula]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Ingresar_Matricula] 
@identificacion varchar(50),
@codCarrera int,
@codMateria int,
@codProfesor int
AS
BEGIN
	INSERT INTO Matricula(Identificacion,CodCarrera,CodMateria,CodProfesor,FechaRegistro,Estado)
	VALUES(@identificacion,@codCarrera,@codMateria,@codProfesor, GETDATE(), 1);
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Ingresar_Usuario]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Ingresar_Usuario] 
@identificacion varchar(50),
@nombre varchar(50),
@primer_apellido varchar(50),
@segundo_apellido varchar(50),
@usuario varchar(50),
@clave varchar(50),
@estado int 
AS
BEGIN
	INSERT INTO Usuarios(identificacion,nombre,primer_apellido,segundo_apellido,usuario,clave,estado)
	VALUES(@identificacion,@nombre,@primer_apellido,@segundo_apellido,@usuario,@clave,@estado);
	INSERT INTO UsuariosPorPerfiles(identificacion,codigo_perfil,fecha_asociacion)
	VALUES(@identificacion,2,GETDATE());

	Commit;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Modificar_Mant_Aula]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Modificar_Mant_Aula] 
@codigoAula int,
@descAula varchar(50),
@estAula int
AS
BEGIN
	UPDATE Aulas
	SET
	CodigoAula = @codigoAula,
	DescAula = @descAula,
	EstAula = @estAula
	WHERE CodigoAula = @codigoAula;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Modificar_Mant_Carrera]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Modificar_Mant_Carrera] 
@codigoCarrera int,
@descCarrera varchar(50),
@estCarrera int
AS
BEGIN
	UPDATE Carreras
	SET
	CodigoCarrera = @codigoCarrera,
	DescCarrera = @descCarrera,
	EstCarrera = @estCarrera
	WHERE CodigoCarrera = @codigoCarrera;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Modificar_Mant_Materias]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Modificar_Mant_Materias] 
@codigoMateria int,
@descMateria varchar(50),
@estMateria int,
@codCarrera int
AS
BEGIN
	UPDATE Materias
	SET
	CodMaterias = @codigoMateria,
	DescMaterias = @descMateria,
	EstMaterias = @estMateria,
	CodigoCarrera = @codCarrera
	WHERE CodMaterias = @codigoMateria;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Modificar_Mant_Profesores]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Modificar_Mant_Profesores] 
@identificacion varchar(50),
@nombre varchar(50),
@primer_apellido varchar(50),
@segundo_apellido varchar(50),
@codEstado int,
@estado int
AS
BEGIN
	UPDATE Profesores
	SET
	Nombre = @nombre,
	Primer_Apellido = @primer_apellido,
	Segundo_Apellido = @segundo_apellido,
	CodMateria = @codEstado,
	estado = @estado
	WHERE identificacion = @identificacion;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Modificar_Mant_Usuario]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Modificar_Mant_Usuario] 
@identificacion varchar(50),
@nombre varchar(50),
@primer_apellido varchar(50),
@segundo_apellido varchar(50),
@usuario varchar(50),
@clave varchar(50),
@estado int,
@rol varchar(50),
@email varchar(50) 
AS
BEGIN
	UPDATE Usuarios
	SET
	nombre = @nombre,
	primer_apellido = @primer_apellido,
	segundo_apellido = @segundo_apellido,
	usuario = @usuario,
	clave = @clave,
	estado = @estado,
	email = @email
	WHERE identificacion = @identificacion;

	DECLARE @valor INT;
	SET @valor = 0;
	
	IF (@rol = 'Funcionario')
	BEGIN
	set @valor = 1;
	END
	ELSE
	BEGIN
	set @valor = 2;
	END

	UPDATE UsuariosPorPerfiles
	SET
	codigo_perfil = @valor
	WHERE 
	identificacion = @identificacion;

END

GO
/****** Object:  StoredProcedure [dbo].[PA_Modificar_Matricula]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Modificar_Matricula] 
@codMatricula int,
@Estado varchar(50)
AS
BEGIN

	DECLARE @valor INT;
	SET @valor = 0;

	IF (@Estado = 'Congelada')
	BEGIN
	set @valor = 1;
	END
	ELSE
	BEGIN
	set @valor = 2;
	END

	UPDATE Matricula
	SET Estado = @valor
	WHERE CodMatricula = @codMatricula;
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Modificar_Pass_Usuario]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Modificar_Pass_Usuario] 
@identificacion varchar(50),
@clave varchar(50),
@tempClave int
AS
BEGIN
	UPDATE Usuarios
	SET
	clave = @clave,
	temp_clave = @tempClave
	WHERE identificacion = @identificacion;

END

GO
/****** Object:  StoredProcedure [dbo].[PA_RPT__ProfesoresActivos]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_RPT__ProfesoresActivos]
AS
BEGIN
SELECT P.Identificacion as 'Identificacion', P.Nombre as 'Nombre', P.Primer_Apellido as 'Primer_Apellido',
P.Segundo_Apellido as 'Segundo_Apellido', M.CodMaterias as 'Codigo', M.DescMaterias as 'Materia', P.estado as 'Estado' 
FROM Profesores P
INNER JOIN Materias M
on M.CodMaterias = P.CodMateria 
where P.estado = 1
Order by P.Identificacion desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_RPT__ProfesoresInactivos]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_RPT__ProfesoresInactivos]
AS
BEGIN
SELECT P.Identificacion as 'Identificacion', P.Nombre as 'Nombre', P.Primer_Apellido as 'Primer_Apellido',
P.Segundo_Apellido as 'Segundo_Apellido', M.CodMaterias as 'Codigo', M.DescMaterias as 'Materia', P.estado as 'Estado' 
FROM Profesores P
INNER JOIN Materias M
on M.CodMaterias = P.CodMateria 
where P.estado = 2
Order by P.Identificacion desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_RPT_Congeladas]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_RPT_Congeladas]
AS
BEGIN
SELECT M.CodMatricula as 'Codigo', M.Identificacion as 'Identificacion',
Ca.CodigoCarrera as 'CodCarrera',
Ca.DescCarrera as 'Carrera',
Ma.CodMaterias as 'CodMateria',
Ma.DescMaterias as 'Materia',
P.CodProfesor as 'CodProfesor',
P.Nombre +' '+ P.Primer_Apellido +' '+ P.Segundo_Apellido as 'Nombre',
CASE 
WHEN M.Estado = 1 THEN 'Matriculada' 
WHEN M.Estado = 2 THEN 'Congelada' END as 'Estado'
FROM Matricula M
inner join Carreras Ca
on Ca.CodigoCarrera = M.CodCarrera
inner join Materias Ma
on Ma.CodMaterias = M.CodMateria
inner join Profesores P
on P.CodProfesor = M.CodProfesor
where M.Estado = 2
Order by M.CodMatricula desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_RPT_ConsultarAulasEstados]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_RPT_ConsultarAulasEstados]
AS
BEGIN
SELECT CodigoAula as 'Codigo', DescAula as 'Descripcion', 
CASE EstAula
WHEN 1 THEN 'Perfecto Estado'
WHEN 2 THEN 'Estado Medio'
WHEN 3 THEN 'Deteriorada' END as 'Estado' FROM Aulas Order by CodigoAula desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_RPT_Matriculadas]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_RPT_Matriculadas]
AS
BEGIN
SELECT M.CodMatricula as 'Codigo', M.Identificacion as 'Identificacion',
Ca.CodigoCarrera as 'CodCarrera',
Ca.DescCarrera as 'Carrera',
Ma.CodMaterias as 'CodMateria',
Ma.DescMaterias as 'Materia',
P.CodProfesor as 'CodProfesor',
P.Nombre +' '+ P.Primer_Apellido +' '+ P.Segundo_Apellido as 'Nombre',
CASE 
WHEN M.Estado = 1 THEN 'Matriculada' 
WHEN M.Estado = 2 THEN 'Congelada' END as 'Estado'
FROM Matricula M
inner join Carreras Ca
on Ca.CodigoCarrera = M.CodCarrera
inner join Materias Ma
on Ma.CodMaterias = M.CodMateria
inner join Profesores P
on P.CodProfesor = M.CodProfesor
where M.Estado = 1
Order by M.CodMatricula desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_RPT_UsuariosActivos]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_RPT_UsuariosActivos]
AS
BEGIN
SELECT u.identificacion as 'Identificacion', u.nombre as 'Nombre', u.primer_apellido as 'Primer_Apellido',
u.segundo_apellido as 'Segundo_Apellido', u.usuario as 'Usuario', u.clave as 'Clave', 
u.estado as 'Estado',
p.descripcion_perfil 'Rol' 
FROM Usuarios u inner join UsuariosPorPerfiles up
on u.identificacion = up.identificacion
inner join Perfiles p 
on p.codigo_perfil = up.codigo_perfil
where u.estado = 1
order by identificacion desc;
END
GO
/****** Object:  StoredProcedure [dbo].[PA_RPT_UsuariosInactivos]    Script Date: 14-dic-20 12:25:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_RPT_UsuariosInactivos]
AS
BEGIN
SELECT u.identificacion as 'Identificacion', u.nombre as 'Nombre', u.primer_apellido as 'Primer_Apellido',
u.segundo_apellido as 'Segundo_Apellido', u.usuario as 'Usuario', u.clave as 'Clave', 
u.estado as 'Estado',
p.descripcion_perfil 'Rol' 
FROM Usuarios u inner join UsuariosPorPerfiles up
on u.identificacion = up.identificacion
inner join Perfiles p 
on p.codigo_perfil = up.codigo_perfil
where u.estado = 2
order by identificacion desc;
END
GO
USE [master]
GO
ALTER DATABASE [MatriculaEnLinea] SET  READ_WRITE 
GO
