USE [master]
GO
/****** Object:  Database [Sistema_Clinico]    Script Date: 18/07/2023 22:04:08 ******/
CREATE DATABASE [Sistema_Clinico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sistema_Clinico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER2019\MSSQL\DATA\Sistema_Clinico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sistema_Clinico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER2019\MSSQL\DATA\Sistema_Clinico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sistema_Clinico] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sistema_Clinico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sistema_Clinico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sistema_Clinico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sistema_Clinico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sistema_Clinico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sistema_Clinico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sistema_Clinico] SET  MULTI_USER 
GO
ALTER DATABASE [Sistema_Clinico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sistema_Clinico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sistema_Clinico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sistema_Clinico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sistema_Clinico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sistema_Clinico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Sistema_Clinico] SET QUERY_STORE = OFF
GO
USE [Sistema_Clinico]
GO
/****** Object:  Table [dbo].[Descuento]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Descuento](
	[IdDescuento] [int] NOT NULL,
	[Descuento] [float] NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] NOT NULL,
	[NombreEmpleado] [varchar](30) NOT NULL,
	[ApellidoEmpleado] [varchar](30) NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[IdRol] [int] NOT NULL,
	[IdGenero] [int] NOT NULL,
	[IdTurno] [int] NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipoMedico]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipoMedico](
	[NumeroInventario] [int] NOT NULL,
	[NombreEquipo] [varchar](60) NOT NULL,
	[Marca] [varchar](40) NOT NULL,
	[CostoEquipo] [int] NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[FechaDescartado] [date] NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[IdEspecialidad] [int] NOT NULL,
	[Especialidad] [varchar](50) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL,
	[IdEstadoCivil] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoCivil](
	[IdEstadoCivil] [int] NOT NULL,
	[Descripcion] [varchar](20) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[IdGenero] [int] NOT NULL,
	[Descripcion] [varchar](20) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamentos]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamentos](
	[Codigo] [varchar](15) NOT NULL,
	[NombreMedicamento] [varchar](60) NOT NULL,
	[TipoMedicamento] [varchar](50) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[EnExistencia] [int] NOT NULL,
	[Precio] [float] NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[FechaDescartado] [date] NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medico]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medico](
	[IdMedico] [int] NOT NULL,
	[NombreMedico] [varchar](30) NOT NULL,
	[ApellidoMedico] [varchar](30) NOT NULL,
	[Edad] [int] NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[IdEstadoCivil] [int] NOT NULL,
	[IdGenero] [int] NOT NULL,
	[IdEspecialidad] [int] NOT NULL,
	[IdTurno] [int] NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NivelAcceso]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelAcceso](
	[NivelAcceso] [int] NOT NULL,
	[Opcion] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[IdPaciente] [int] NOT NULL,
	[NombrePaciente] [varchar](50) NOT NULL,
	[ApellidoPaciente] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Correo] [varchar](30) NOT NULL,
	[IdEstadoCivil] [int] NOT NULL,
	[IdGenero] [int] NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] NOT NULL,
	[NombreProveedor] [varchar](50) NOT NULL,
	[NombreVendedor] [varchar](50) NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Categoria] [varchar](30) NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolEmpleado]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolEmpleado](
	[IdRol] [int] NOT NULL,
	[Rol] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServicioClinico]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicioClinico](
	[IdServicioClinico] [int] NOT NULL,
	[ServicioClinico] [varchar](100) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoExamen]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoExamen](
	[IdTipoExamen] [int] NOT NULL,
	[TipoExamen] [varchar](60) NOT NULL,
	[IdEspecialidad] [int] NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Costo] [int] NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[IdTurno] [int] NOT NULL,
	[Turno] [varchar](30) NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
	[Horas] [varchar](15) NOT NULL,
	[Dias] [varchar](30) NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdEmpleado] [int] NOT NULL,
	[IdUsuario] [varchar](15) NOT NULL,
	[Contraseña] [varchar](15) NOT NULL,
	[Correo] [varchar](30) NULL,
	[NivelAcceso] [int] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[EstadoActivo] [bit] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Especialidad] ([IdEspecialidad], [Especialidad], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado], [IdEstadoCivil]) VALUES (1, N'Pediatriaa', N'Provee atención a niños y niñas.', CAST(N'2023-07-14T16:44:31.903' AS DateTime), CAST(N'2023-07-14T16:44:31.000' AS DateTime), 0, NULL)
GO
INSERT [dbo].[Especialidad] ([IdEspecialidad], [Especialidad], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado], [IdEstadoCivil]) VALUES (2, N'Cardiología', N'Se concentran en el tratamiento del corazón y los vasos sanguíneos', CAST(N'2023-07-14T16:47:12.557' AS DateTime), CAST(N'2023-07-14T16:47:12.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[Especialidad] ([IdEspecialidad], [Especialidad], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado], [IdEstadoCivil]) VALUES (3, N'Dermatología', N'Son los que tratan los desordenes de la piel en  cabello, uñas y membranas mucosas adyacentes ya sea los adultos o niños.', CAST(N'2023-07-14T16:48:56.133' AS DateTime), CAST(N'2023-07-14T16:48:56.133' AS DateTime), 1, NULL)
GO
INSERT [dbo].[Especialidad] ([IdEspecialidad], [Especialidad], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado], [IdEstadoCivil]) VALUES (4, N'Neumología', N'Tratan el sistema cardíaco-pulmonar, que consiste en los órganos que trabajan juntos para ayudar a que la persona respire, como el corazón y los pulmones.', CAST(N'2023-07-14T16:55:11.560' AS DateTime), CAST(N'2023-07-14T16:55:11.560' AS DateTime), 1, NULL)
GO
INSERT [dbo].[Especialidad] ([IdEspecialidad], [Especialidad], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado], [IdEstadoCivil]) VALUES (5, N'Neurología', N'Los neurólogos son los que tratan a los pacientes con condiciones que afectan al cerebro, espina vertebral o nervios.', CAST(N'2023-07-14T16:59:34.430' AS DateTime), CAST(N'2023-07-14T16:59:34.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[Especialidad] ([IdEspecialidad], [Especialidad], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado], [IdEstadoCivil]) VALUES (7, N'Urología', N'La urología es la especialidad médica que cuida del tracto urinario de los hombres y las mujeres incluyendo los riñones, uréteres, vejiga y uretra.', CAST(N'2023-07-14T17:05:23.220' AS DateTime), CAST(N'2023-07-14T17:05:23.220' AS DateTime), 1, NULL)
GO
INSERT [dbo].[Especialidad] ([IdEspecialidad], [Especialidad], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado], [IdEstadoCivil]) VALUES (6, N'Radiología', N'Es el médico que está entrenado para ver e interpretar las pruebas diagnosticas de imágenes como rayos X, Tomografía computarizadas, Resonancias Magnéticas, etc.', CAST(N'2023-07-14T17:02:34.600' AS DateTime), CAST(N'2023-07-14T17:02:34.600' AS DateTime), 1, NULL)
GO
INSERT [dbo].[EstadoCivil] ([IdEstadoCivil], [Descripcion], [FechaRegistro], [FechaModificacion]) VALUES (1, N'Casado', CAST(N'2023-07-14T20:36:00.000' AS DateTime), CAST(N'2023-07-14T20:36:00.000' AS DateTime))
GO
INSERT [dbo].[EstadoCivil] ([IdEstadoCivil], [Descripcion], [FechaRegistro], [FechaModificacion]) VALUES (2, N'Soltero', CAST(N'2023-07-14T20:36:00.000' AS DateTime), CAST(N'2023-07-14T20:36:00.000' AS DateTime))
GO
INSERT [dbo].[EstadoCivil] ([IdEstadoCivil], [Descripcion], [FechaRegistro], [FechaModificacion]) VALUES (3, N'Divorciado', CAST(N'2023-07-14T20:37:00.000' AS DateTime), CAST(N'2023-07-14T20:37:00.000' AS DateTime))
GO
INSERT [dbo].[EstadoCivil] ([IdEstadoCivil], [Descripcion], [FechaRegistro], [FechaModificacion]) VALUES (4, N'Union libre', CAST(N'2023-07-14T20:37:00.000' AS DateTime), CAST(N'2023-07-14T20:37:00.000' AS DateTime))
GO
INSERT [dbo].[EstadoCivil] ([IdEstadoCivil], [Descripcion], [FechaRegistro], [FechaModificacion]) VALUES (5, N'Viudo', CAST(N'2023-07-14T20:37:00.000' AS DateTime), CAST(N'2023-07-14T20:37:00.000' AS DateTime))
GO
INSERT [dbo].[Genero] ([IdGenero], [Descripcion], [FechaRegistro], [FechaModificacion]) VALUES (1, N'Femenino', CAST(N'2023-07-14T20:30:00.000' AS DateTime), CAST(N'2023-07-14T20:30:00.000' AS DateTime))
GO
INSERT [dbo].[Genero] ([IdGenero], [Descripcion], [FechaRegistro], [FechaModificacion]) VALUES (2, N'Masculino', CAST(N'2023-07-14T20:31:00.000' AS DateTime), CAST(N'2023-07-14T20:31:00.000' AS DateTime))
GO
INSERT [dbo].[RolEmpleado] ([IdRol], [Rol], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (1, N'Medico general', N'Diagnosticar y cuidar pacientes en casos rutinarios, y usualmente refiere a las personas a especiali', CAST(N'2023-07-14T21:46:40.743' AS DateTime), CAST(N'2023-07-14T21:46:40.000' AS DateTime), 1)
GO
INSERT [dbo].[RolEmpleado] ([IdRol], [Rol], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (2, N'Enfermeria', N'Proporciona atención directa a los pacientes, administra medicamentos, realiza cuidados y seguimient', CAST(N'2023-07-14T22:23:53.360' AS DateTime), CAST(N'2023-07-14T22:23:53.360' AS DateTime), 1)
GO
INSERT [dbo].[RolEmpleado] ([IdRol], [Rol], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (3, N'Asistente Médico', N'Ayuda a los médicos en la atención médica, realiza tareas clínicas y administra procedimientos.', CAST(N'2023-07-14T22:24:25.847' AS DateTime), CAST(N'2023-07-14T22:24:25.000' AS DateTime), 1)
GO
INSERT [dbo].[RolEmpleado] ([IdRol], [Rol], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (4, N'Personal de recepción', N'Maneja la recepción y el registro de pacientes, programación de citas y manejo de la información de ', CAST(N'2023-07-14T22:24:46.100' AS DateTime), CAST(N'2023-07-14T22:24:46.100' AS DateTime), 1)
GO
INSERT [dbo].[RolEmpleado] ([IdRol], [Rol], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (5, N'Administrador de la clínica', N'Supervisa las operaciones generales de la clínica, gestiona el personal, finanzas y aspectos adminis', CAST(N'2023-07-14T22:25:08.490' AS DateTime), CAST(N'2023-07-14T22:25:08.490' AS DateTime), 1)
GO
INSERT [dbo].[RolEmpleado] ([IdRol], [Rol], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (6, N'Farmacéutico', N'Dispensa medicamentos y asesora sobre el uso adecuado de medicamentos.', CAST(N'2023-07-14T22:25:40.837' AS DateTime), CAST(N'2023-07-14T22:25:40.837' AS DateTime), 1)
GO
INSERT [dbo].[RolEmpleado] ([IdRol], [Rol], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (7, N'Técnico de laboratorio', N'Realiza pruebas y análisis de muestras de laboratorio para ayudar en el diagnóstico y tratamiento.
', CAST(N'2023-07-14T22:26:02.617' AS DateTime), CAST(N'2023-07-14T22:26:02.000' AS DateTime), 1)
GO
INSERT [dbo].[RolEmpleado] ([IdRol], [Rol], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (8, N'Psicólogo/psiquiatra', N'Proporciona servicios de salud mental, diagnóstico y tratamiento de trastornos psicológicos.', CAST(N'2023-07-14T22:26:24.060' AS DateTime), CAST(N'2023-07-14T22:26:24.060' AS DateTime), 1)
GO
INSERT [dbo].[RolEmpleado] ([IdRol], [Rol], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (9, N'Personal de servicios generales', N'Personal de limpieza, mantenimiento y seguridad de la clínica.', CAST(N'2023-07-14T22:26:42.533' AS DateTime), CAST(N'2023-07-14T22:26:42.533' AS DateTime), 1)
GO
INSERT [dbo].[ServicioClinico] ([IdServicioClinico], [ServicioClinico], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (1, N'Consulta médica general', N'Examen físico, diagnóstico y tratamiento de enfermedades comunes, remisión a especialistas según sea necesario.', CAST(N'2023-07-15T21:28:35.580' AS DateTime), CAST(N'2023-07-15T21:28:35.580' AS DateTime), 1)
GO
INSERT [dbo].[ServicioClinico] ([IdServicioClinico], [ServicioClinico], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (2, N'Servicios de laboratorio', N'Análisis de sangre, orina, heces y otros fluidos corporales para el diagnóstico de enfermedades y control de salud.', CAST(N'2023-07-15T21:29:04.517' AS DateTime), CAST(N'2023-07-15T21:29:04.517' AS DateTime), 1)
GO
INSERT [dbo].[ServicioClinico] ([IdServicioClinico], [ServicioClinico], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (3, N'Radiología', N'Radiografías, tomografías computarizadas (CT), resonancias magnéticas (RM) y ecografías para el diagnóstico de lesiones, enfermedades y control del tratamiento.', CAST(N'2023-07-15T21:29:22.730' AS DateTime), CAST(N'2023-07-15T21:29:22.730' AS DateTime), 1)
GO
INSERT [dbo].[ServicioClinico] ([IdServicioClinico], [ServicioClinico], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (4, N'Servicios de diagnóstico por imágenes', N'Mamografías, densitometría ósea, ecocardiogramas, estudios vasculares y otros procedimientos especializados para el diagnóstico de enfermedades y trastornos específicos.', CAST(N'2023-07-15T21:29:48.370' AS DateTime), CAST(N'2023-07-15T21:29:48.370' AS DateTime), 1)
GO
INSERT [dbo].[ServicioClinico] ([IdServicioClinico], [ServicioClinico], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (5, N'Cirugía', N'Intervenciones quirúrgicas programadas y de emergencia para tratar una amplia gama de condiciones médicas.', CAST(N'2023-07-15T21:30:09.713' AS DateTime), CAST(N'2023-07-15T21:30:09.713' AS DateTime), 1)
GO
INSERT [dbo].[ServicioClinico] ([IdServicioClinico], [ServicioClinico], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (6, N'Ginecología y obstetricia', N'Atención a mujeres, incluyendo exámenes ginecológicos, seguimiento prenatal, atención durante el parto y servicios relacionados con la salud reproductiva.', CAST(N'2023-07-15T21:30:26.077' AS DateTime), CAST(N'2023-07-15T21:30:26.077' AS DateTime), 1)
GO
INSERT [dbo].[ServicioClinico] ([IdServicioClinico], [ServicioClinico], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (7, N'Pediatría', N'Atención médica especializada para bebés, niños y adolescentes, incluyendo exámenes de rutina, vacunas y tratamiento de enfermedades infantiles.', CAST(N'2023-07-15T21:30:41.917' AS DateTime), CAST(N'2023-07-15T21:30:41.000' AS DateTime), 1)
GO
INSERT [dbo].[ServicioClinico] ([IdServicioClinico], [ServicioClinico], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (8, N'Medicina interna', N'Diagnóstico y tratamiento de enfermedades en adultos, incluyendo enfermedades crónicas, enfermedades infecciosas y trastornos del sistema cardiovascular, respiratorio y digestivo.', CAST(N'2023-07-15T21:31:01.407' AS DateTime), CAST(N'2023-07-15T21:31:01.407' AS DateTime), 1)
GO
INSERT [dbo].[ServicioClinico] ([IdServicioClinico], [ServicioClinico], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (9, N'Medicina de emergencia', N'Atención inmediata a pacientes con lesiones o enfermedades graves o potencialmente mortales.', CAST(N'2023-07-15T21:31:21.863' AS DateTime), CAST(N'2023-07-15T21:31:21.863' AS DateTime), 1)
GO
INSERT [dbo].[ServicioClinico] ([IdServicioClinico], [ServicioClinico], [Descripcion], [FechaRegistro], [FechaModificacion], [Estado]) VALUES (10, N'Dermatología', N'Diagnóstico y tratamiento de trastornos de la piel, incluyendo enfermedades, afecciones inflamatorias, infecciones y cáncer de piel.', CAST(N'2023-07-15T21:31:38.290' AS DateTime), CAST(N'2023-07-15T21:31:38.290' AS DateTime), 1)
GO
/****** Object:  StoredProcedure [dbo].[sp_Descuento]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jahely Rivera>
-- Create date: <16 de julio 2023>
-- Description:	<Tabla Descuento>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Descuento]
	-- Add the parameters for the stored procedure here
	@Identificador		int,
	@IdDescuento		int,
	@Descuento			float,
	@Descripcion		varchar(200),
	@FechaRegistro		datetime,
	@FechaModificacion	datetime,
	@Estado				bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	if @Identificador = 1
	INSERT INTO Descuento(IdDescuento, Descuento, Descripcion, FechaRegistro, FechaModificacion, Estado)
	VALUES(@IdDescuento, @Descuento, @Descripcion, GETDATE(), GETDATE(), @Estado)

	else if @Identificador = 2
	Update Descuento
	set Descuento = @Descuento, Descripcion = @Descripcion, FechaModificacion = @FechaModificacion, Estado = @Estado
	where IdDescuento = @IdDescuento

	else if @Identificador = 3
	Delete from Descuento where IdDescuento = @IdDescuento

	else if @Identificador = 4
	Select * from Descuento

	else if @Identificador = 5
	Select * from Descuento where IdDescuento = @IdDescuento
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EquipoMedico]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jahely Rivera>
-- Create date: <12 de julio 2023>
-- Description:	<Tabla EquipoMedico>
-- =============================================
CREATE PROCEDURE [dbo].[sp_EquipoMedico]
	-- Add the parameters for the stored procedure here
	@Identificador		int,
	@NumeroInventario	int,
	@NombreEquipo		varchar(60),
	@Marca				varchar(40),
	@CostoEquipo		int,
	@IdProveedor		int,
	@FechaDescartado	date,
	@FechaRegistro		datetime,
	@FechaModificacion	datetime,
	@Estado				bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	if @Identificador = 1
	INSERT INTO EquipoMedico(NumeroInventario, NombreEquipo, Marca, CostoEquipo, IdProveedor,	
    FechaDescartado, FechaRegistro, FechaModificacion, Estado)
	VALUES(@NumeroInventario, @NombreEquipo, @Marca, @CostoEquipo, @IdProveedor,	
    @FechaDescartado, GETDATE(), GETDATE(), @Estado)

	else if @Identificador = 2
	Update EquipoMedico
	set NombreEquipo = @NombreEquipo, Marca = @Marca, CostoEquipo = @CostoEquipo, 
	IdProveedor = @IdProveedor, FechaDescartado = @FechaDescartado, FechaModificacion = @FechaModificacion, Estado = @Estado
	where NumeroInventario = @NumeroInventario

	else if @Identificador = 3
	Delete from EquipoMedico where NumeroInventario = @NumeroInventario

	else if @Identificador = 4
	Select * from EquipoMedico

	else if @Identificador = 5
	Select * from EquipoMedico where NumeroInventario = @NumeroInventario
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Especialidad]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jahely Rivera>
-- Create date: <12 de julio 023>
-- Description:	<Tabla Especialidad>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Especialidad]
	-- Add the parameters for the stored procedure here
	@Identificador		int,
	@IdEspecialidad		int,
	@Especialidad		varchar(50),
	@Descripcion		varchar(200),
	@FechaRegistro		datetime,
	@FechaModificacion	datetime,
	@Estado				bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	if @Identificador = 1
	INSERT INTO Especialidad(IdEspecialidad, Especialidad, Descripcion, FechaRegistro, FechaModificacion, Estado)
	VALUES(@IdEspecialidad, @Especialidad, @Descripcion, GETDATE(), GETDATE(), @Estado)

	else if @Identificador = 2
	Update Especialidad
	set Especialidad = @Especialidad, Descripcion = @Descripcion, FechaModificacion = @FechaModificacion, Estado = @Estado
	where IdEspecialidad = @IdEspecialidad

	else if @Identificador = 3
	Delete from Especialidad where IdEspecialidad = @IdEspecialidad

	else if @Identificador = 4
	Select * from Especialidad

	else if @Identificador = 5
	Select * from Especialidad where IdEspecialidad = @IdEspecialidad
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Proveedor]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jahely Rivera>
-- Create date: <12 de julio 2023>
-- Description:	<Tabla Proveedor>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Proveedor]
	-- Add the parameters for the stored procedure here
	@Identificador		int,
	@IdProveedor		int,
	@NombreProveedor	varchar(50),
	@NombreVendedor		varchar(50),
	@Direccion			varchar(200),
	@Telefono			varchar(15),
	@Correo				varchar(50),
	@Categoria			varchar(30),
	@FechaRegistro		datetime,
	@FechaModificacion	datetime,
	@Estado				bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	if @Identificador = 1
	INSERT INTO Proveedor(IdProveedor, NombreProveedor, NombreVendedor, Direccion, Telefono,	
    Correo, Categoria, FechaRegistro, FechaModificacion, Estado)
	VALUES(@IdProveedor, @NombreProveedor, @NombreVendedor, @Direccion, @Telefono,	
    @Correo, @Categoria, GETDATE(), GETDATE(), @Estado)

	else if @Identificador = 2
	Update Proveedor
	set NombreProveedor = @NombreProveedor, NombreVendedor = @NombreVendedor, Direccion = @Direccion, 
	Telefono = @Telefono, Correo = @Correo, Categoria = @Categoria, FechaModificacion = @FechaModificacion, Estado = @Estado
	where IdProveedor = @IdProveedor

	else if @Identificador = 3
	Delete from Proveedor where IdProveedor = @IdProveedor

	else if @Identificador = 4
	Select * from Proveedor

	else if @Identificador = 5
	Select * from Proveedor where IdProveedor = @IdProveedor
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Rol]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jahely Rivera>
-- Create date: <14 de julio 2023>
-- Description:	<Tabla RolEmpleado>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Rol]
	-- Add the parameters for the stored procedure here
	@Identificador		int,
	@IdRol				int,
	@Rol				varchar(50),
	@Descripcion		varchar(100),
	@FechaRegistro		datetime,
	@FechaModificacion	datetime,
	@Estado				bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	if @Identificador = 1
	INSERT INTO RolEmpleado(IdRol, Rol, Descripcion, FechaRegistro, FechaModificacion, Estado)
	VALUES(@IdRol, @Rol, @Descripcion, GETDATE(), GETDATE(), @Estado)

	else if @Identificador = 2
	Update RolEmpleado
	set Rol = @Rol, Descripcion = @Descripcion, FechaModificacion = @FechaModificacion, Estado = @Estado
	where IdRol = @IdRol

	else if @Identificador = 3
	Delete from RolEmpleado where IdRol = @IdRol

	else if @Identificador = 4
	Select * from RolEmpleado

	else if @Identificador = 5
	Select * from RolEmpleado where IdRol = @IdRol
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ServicioClinico]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jahely Rivera>
-- Create date: <14 de julio 2023>
-- Description:	<Tabla ServicioCliente>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ServicioClinico]
	-- Add the parameters for the stored procedure here
	@Identificador		int,
	@IdServicioClinico	int,
	@ServicioClinico	varchar(100),
	@Descripcion		varchar(200),
	@FechaRegistro		datetime,
	@FechaModificacion	datetime,
	@Estado				bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	if @Identificador = 1
	INSERT INTO ServicioClinico(IdServicioClinico, ServicioClinico, Descripcion, FechaRegistro, FechaModificacion, Estado)
	VALUES(@IdServicioClinico, @ServicioClinico, @Descripcion, GETDATE(), GETDATE(), @Estado)

	else if @Identificador = 2
	Update ServicioClinico
	set ServicioClinico = @ServicioClinico, Descripcion = @Descripcion, FechaModificacion = @FechaModificacion, Estado = @Estado
	where IdServicioClinico = @IdServicioClinico

	else if @Identificador = 3
	Delete from ServicioClinico where IdServicioClinico = @IdServicioClinico

	else if @Identificador = 4
	Select * from ServicioClinico

	else if @Identificador = 5
	Select * from ServicioClinico where IdServicioClinico = @IdServicioClinico
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoExamen]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jahely Rivera>
-- Create date: <12 de julio 2023>
-- Description:	<Tabla TipoExamen>
-- =============================================
CREATE PROCEDURE [dbo].[sp_TipoExamen]
	-- Add the parameters for the stored procedure here
	@Identificador		int,
	@IdTipoExamen		int,
	@TipoExamen			varchar(60),
	@IdEspecialidad		int,
	@Descripcion		varchar(200),
	@Costo				int,
	@FechaRegistro		datetime,
	@FechaModificacion	datetime,
	@Estado				bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	if @Identificador = 1
	INSERT INTO TipoExamen(IdTipoExamen, TipoExamen, IdEspecialidad, Descripcion, Costo,
	FechaRegistro, FechaModificacion, Estado)
	VALUES(@IdTipoExamen, @TipoExamen, @IdEspecialidad, @Descripcion, @Costo,
	GETDATE(), GETDATE(), @Estado)

	else if @Identificador = 2
	Update TipoExamen
	set TipoExamen = @TipoExamen, IdEspecialidad = @IdEspecialidad, Descripcion = @Descripcion,
	Costo = @Costo, FechaModificacion = @FechaModificacion, Estado = @Estado
	where IdTipoExamen = @IdTipoExamen

	else if @Identificador = 3
	Delete from TipoExamen where IdTipoExamen = @IdTipoExamen

	else if @Identificador = 4
	Select * from TipoExamen

	else if @Identificador = 5
	Select * from TipoExamen where IdTipoExamen = @IdTipoExamen
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Turnos]    Script Date: 18/07/2023 22:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jahely Rivera>
-- Create date: <12 de julio 2023>
-- Description:	<Tabla EquipoMedico>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Turnos]
	-- Add the parameters for the stored procedure here
	@Identificador		int,
	@IdTurno			int,
	@Turno				varchar(30),
	@Descripcion		varchar(30),
	@Dias				varchar(15),
	@Horas				varchar(30),
	@FechaRegistro		datetime,
	@FechaModificacion	datetime,
	@Estado				bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	if @Identificador = 1 
	Insert into Turnos(IdTurno,Turno,Descripcion,Horas,
	Dias,FechaRegistro,FechaModificacion,Estado)
    Values (@IdTurno, @Turno, @Descripcion, @Horas, @Dias,
    GETDATE(), GETDATE(), @Estado)

	else if @Identificador = 2
	Update Turnos
	set IdTurno = @IdTurno, Turno = @Turno, Descripcion = @Descripcion,
	Horas = @Horas, Dias = @Dias, Estado = @Estado
	where @IdTurno =@IdTurno

	else if @Identificador = 3
	delete from Turnos where IdTurno =@IdTurno
	
	else if @Identificador = 4
	Select * from Turnos
	
	else if @Identificador = 5
	Select * from Turnos where IdTurno =@IdTurno
END
GO
USE [master]
GO
ALTER DATABASE [Sistema_Clinico] SET  READ_WRITE 
GO
