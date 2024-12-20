USE [master]
GO
/****** Object:  Database [QUILO3D]    Script Date: 27/11/2024 10:01:58 ******/
CREATE DATABASE [QUILO3D]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUILO3D', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QUILO3D.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUILO3D_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QUILO3D_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QUILO3D] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUILO3D].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUILO3D] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUILO3D] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUILO3D] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUILO3D] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUILO3D] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUILO3D] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUILO3D] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUILO3D] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUILO3D] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUILO3D] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUILO3D] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUILO3D] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUILO3D] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUILO3D] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUILO3D] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUILO3D] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUILO3D] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUILO3D] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUILO3D] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUILO3D] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUILO3D] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUILO3D] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUILO3D] SET RECOVERY FULL 
GO
ALTER DATABASE [QUILO3D] SET  MULTI_USER 
GO
ALTER DATABASE [QUILO3D] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUILO3D] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUILO3D] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUILO3D] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUILO3D] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUILO3D] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUILO3D', N'ON'
GO
ALTER DATABASE [QUILO3D] SET QUERY_STORE = ON
GO
ALTER DATABASE [QUILO3D] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QUILO3D]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Dni] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Impresora]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Impresora](
	[IdImpresora] [int] NOT NULL,
	[ConsumoElectrico] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Impresora] PRIMARY KEY CLUSTERED 
(
	[IdImpresora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[IdMaterial] [int] NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[PesoKg] [decimal](18, 3) NOT NULL,
	[Costo] [decimal](18, 3) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[IdMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] NOT NULL,
	[IdMaterial] [int] NOT NULL,
	[IdImpresora] [int] NOT NULL,
	[TiempoImpresion] [decimal](18, 3) NOT NULL,
	[Peso] [decimal](18, 3) NOT NULL,
	[Costo] [decimal](18, 3) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Contrasenia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[NombreUsuario] ASC,
	[Contrasenia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Valor] [decimal](18, 3) NOT NULL,
	[FechaVenta] [datetime] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cliente] ([IdCliente], [Nombre], [Apellido], [Dni]) VALUES (1, N'Martin Federico', N'Elola', 44714886)
INSERT [dbo].[Cliente] ([IdCliente], [Nombre], [Apellido], [Dni]) VALUES (2, N'Iara', N'Pazos', 44505673)
INSERT [dbo].[Cliente] ([IdCliente], [Nombre], [Apellido], [Dni]) VALUES (3, N'Mariano', N'Messi', 44505513)
INSERT [dbo].[Cliente] ([IdCliente], [Nombre], [Apellido], [Dni]) VALUES (4, N'Jorge', N'Roda', 40505513)
INSERT [dbo].[Cliente] ([IdCliente], [Nombre], [Apellido], [Dni]) VALUES (5, N'Lorena', N'Quintero', 40505098)
INSERT [dbo].[Cliente] ([IdCliente], [Nombre], [Apellido], [Dni]) VALUES (6, N'Raul', N'Quintero', 23505098)
INSERT [dbo].[Cliente] ([IdCliente], [Nombre], [Apellido], [Dni]) VALUES (7, N'Ernesto', N'Valverde', 37505098)
INSERT [dbo].[Cliente] ([IdCliente], [Nombre], [Apellido], [Dni]) VALUES (8, N'Marco', N'Aurelio', 10000001)
INSERT [dbo].[Cliente] ([IdCliente], [Nombre], [Apellido], [Dni]) VALUES (9, N'Esteban', N'Lamote', 29032486)
INSERT [dbo].[Cliente] ([IdCliente], [Nombre], [Apellido], [Dni]) VALUES (10, N'Marcos Daniel', N'Elola', 41846237)
GO
INSERT [dbo].[Impresora] ([IdImpresora], [ConsumoElectrico], [Descripcion]) VALUES (1, 350, N'Ender 3 NEO')
INSERT [dbo].[Impresora] ([IdImpresora], [ConsumoElectrico], [Descripcion]) VALUES (2, 270, N'Ender 3 V2')
INSERT [dbo].[Impresora] ([IdImpresora], [ConsumoElectrico], [Descripcion]) VALUES (3, 370, N'Ender 3 V1')
INSERT [dbo].[Impresora] ([IdImpresora], [ConsumoElectrico], [Descripcion]) VALUES (4, 310, N'Ender 3 NEO V2')
GO
INSERT [dbo].[Material] ([IdMaterial], [Color], [PesoKg], [Costo], [Tipo]) VALUES (1, N'Negro', CAST(1.000 AS Decimal(18, 3)), CAST(20000.000 AS Decimal(18, 3)), N'PLA')
INSERT [dbo].[Material] ([IdMaterial], [Color], [PesoKg], [Costo], [Tipo]) VALUES (2, N'Blanco', CAST(1.000 AS Decimal(18, 3)), CAST(25000.000 AS Decimal(18, 3)), N'PLA+')
INSERT [dbo].[Material] ([IdMaterial], [Color], [PesoKg], [Costo], [Tipo]) VALUES (3, N'Blanco', CAST(1.000 AS Decimal(18, 3)), CAST(20000.000 AS Decimal(18, 3)), N'PLA')
INSERT [dbo].[Material] ([IdMaterial], [Color], [PesoKg], [Costo], [Tipo]) VALUES (4, N'Amarillo', CAST(0.500 AS Decimal(18, 3)), CAST(16500.000 AS Decimal(18, 3)), N'ABS')
INSERT [dbo].[Material] ([IdMaterial], [Color], [PesoKg], [Costo], [Tipo]) VALUES (6, N'Violeta', CAST(1.500 AS Decimal(18, 3)), CAST(35250.000 AS Decimal(18, 3)), N'PLA FLEX')
INSERT [dbo].[Material] ([IdMaterial], [Color], [PesoKg], [Costo], [Tipo]) VALUES (7, N'Rosa', CAST(0.750 AS Decimal(18, 3)), CAST(24750.000 AS Decimal(18, 3)), N'ABS')
INSERT [dbo].[Material] ([IdMaterial], [Color], [PesoKg], [Costo], [Tipo]) VALUES (8, N'Verde', CAST(0.500 AS Decimal(18, 3)), CAST(10000.000 AS Decimal(18, 3)), N'PLA')
INSERT [dbo].[Material] ([IdMaterial], [Color], [PesoKg], [Costo], [Tipo]) VALUES (9, N'Marron', CAST(1.000 AS Decimal(18, 3)), CAST(30000.000 AS Decimal(18, 3)), N'PETG')
GO
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (1, 1, 1, CAST(1.250 AS Decimal(18, 3)), CAST(0.125 AS Decimal(18, 3)), CAST(2500.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (2, 5, 1, CAST(2.500 AS Decimal(18, 3)), CAST(0.250 AS Decimal(18, 3)), CAST(5000.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (3, 1, 1, CAST(1.230 AS Decimal(18, 3)), CAST(0.123 AS Decimal(18, 3)), CAST(2460.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (4, 1, 1, CAST(10.000 AS Decimal(18, 3)), CAST(1.000 AS Decimal(18, 3)), CAST(20000.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (5, 1, 1, CAST(1.200 AS Decimal(18, 3)), CAST(0.120 AS Decimal(18, 3)), CAST(2400.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (6, 1, 1, CAST(1.200 AS Decimal(18, 3)), CAST(0.120 AS Decimal(18, 3)), CAST(2400.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (7, 1, 1, CAST(1.200 AS Decimal(18, 3)), CAST(0.120 AS Decimal(18, 3)), CAST(2400.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (8, 1, 2, CAST(1.200 AS Decimal(18, 3)), CAST(0.120 AS Decimal(18, 3)), CAST(3000.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (9, 3, 9, CAST(2.340 AS Decimal(18, 3)), CAST(0.234 AS Decimal(18, 3)), CAST(7020.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (10, 4, 7, CAST(3.000 AS Decimal(18, 3)), CAST(0.300 AS Decimal(18, 3)), CAST(9900.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (11, 4, 6, CAST(2.700 AS Decimal(18, 3)), CAST(0.270 AS Decimal(18, 3)), CAST(6345.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (12, 1, 7, CAST(3.000 AS Decimal(18, 3)), CAST(0.300 AS Decimal(18, 3)), CAST(9900.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (13, 3, 9, CAST(2.340 AS Decimal(18, 3)), CAST(0.234 AS Decimal(18, 3)), CAST(7020.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (14, 4, 7, CAST(3.560 AS Decimal(18, 3)), CAST(0.356 AS Decimal(18, 3)), CAST(11748.000 AS Decimal(18, 3)))
INSERT [dbo].[Producto] ([IdProducto], [IdMaterial], [IdImpresora], [TiempoImpresion], [Peso], [Costo]) VALUES (15, 2, 8, CAST(1.050 AS Decimal(18, 3)), CAST(0.105 AS Decimal(18, 3)), CAST(2100.000 AS Decimal(18, 3)))
GO
INSERT [dbo].[Usuario] ([NombreUsuario], [Contrasenia]) VALUES (N'admin', N'1234')
INSERT [dbo].[Usuario] ([NombreUsuario], [Contrasenia]) VALUES (N'jorge', N'roda')
GO
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (1, 1, 1, CAST(3250.000 AS Decimal(18, 3)), CAST(N'2024-11-26T00:00:00.000' AS DateTime), N'Maceta Robert')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (2, 1, 2, CAST(6500.000 AS Decimal(18, 3)), CAST(N'2024-11-26T00:00:00.000' AS DateTime), N'Batman Mini')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (3, 1, 5, CAST(3120.000 AS Decimal(18, 3)), CAST(N'2024-11-26T00:00:00.000' AS DateTime), N'Maceta')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (4, 6, 6, CAST(3120.000 AS Decimal(18, 3)), CAST(N'2024-11-26T00:00:00.000' AS DateTime), N'Maceta')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (5, 7, 7, CAST(3120.000 AS Decimal(18, 3)), CAST(N'2024-11-26T00:00:00.000' AS DateTime), N'Maceta')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (6, 7, 8, CAST(3900.000 AS Decimal(18, 3)), CAST(N'2024-11-26T00:00:00.000' AS DateTime), N'Maceta')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (7, 7, 9, CAST(9126.000 AS Decimal(18, 3)), CAST(N'2024-11-26T00:00:00.000' AS DateTime), N'Batman Escultura')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (8, 9, 10, CAST(12870.000 AS Decimal(18, 3)), CAST(N'2024-11-26T00:00:00.000' AS DateTime), N'Mate Messi')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (9, 8, 11, CAST(8248.500 AS Decimal(18, 3)), CAST(N'2024-11-26T00:00:00.000' AS DateTime), N'Juguete Roblox')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (10, 7, 12, CAST(12870.000 AS Decimal(18, 3)), CAST(N'2024-11-26T00:00:00.000' AS DateTime), N'Mate Messi')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (11, 7, 3, CAST(3198.000 AS Decimal(18, 3)), CAST(N'2024-11-23T00:00:00.000' AS DateTime), N'Maceta Robert')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (12, 7, 4, CAST(26000.000 AS Decimal(18, 3)), CAST(N'2024-10-23T00:00:00.000' AS DateTime), N'Esferas del dragon')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (13, 1, 13, CAST(9126.000 AS Decimal(18, 3)), CAST(N'2024-11-27T00:00:00.000' AS DateTime), N'Mate Batman')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (14, 1, 14, CAST(15272.400 AS Decimal(18, 3)), CAST(N'2024-11-27T00:00:00.000' AS DateTime), N'Mate Messi')
INSERT [dbo].[Venta] ([IdVenta], [IdCliente], [IdProducto], [Valor], [FechaVenta], [Descripcion]) VALUES (15, 1, 15, CAST(2730.000 AS Decimal(18, 3)), CAST(N'2024-11-27T00:00:00.000' AS DateTime), N'Florero')
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Producto]
GO
/****** Object:  StoredProcedure [dbo].[AltaCliente]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AltaCliente]
	@IdCliente INT,
	@Nombre nvarchar(50),
	@Apellido nvarchar(50),
	@Dni INT

AS
BEGIN
	INSERT INTO Cliente
	VALUES (@IdCliente, @Nombre, @Apellido, @Dni)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaImpresora]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AltaImpresora]
	@IdImpresora INT,
	@ConsumoElectricoHr INT,
	@Descripcion nvarchar(50)
AS
BEGIN
	INSERT INTO Impresora
	VALUES (@IdImpresora, @ConsumoElectricoHr, @Descripcion)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaMaterial]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AltaMaterial] 
	@IdMaterial INT, 
	@Color nvarchar (50),
	@PesoKg decimal (18, 3),
	@Costo decimal (18, 3),
	@Tipo nvarchar (50)

AS
BEGIN
	INSERT INTO Material
	VALUES (@IdMaterial, @Color, @PesoKG, @Costo, @Tipo)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaProducto]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AltaProducto] 
	@IdProducto INT,
	@IdImpresora INT,
	@IdMaterial INT,
	@TiempoImpresion DECIMAL(18, 3),
	@Peso DECIMAL(18, 3),
	@Costo DECIMAL (18, 3)

AS
BEGIN
	INSERT INTO Producto
	VALUES (@IdProducto, @IdImpresora, @IdMaterial, @TiempoImpresion, @Peso, @Costo)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaVenta]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AltaVenta] 
	@IdVenta INT,
	@IdCliente INT,
	@IdProducto INT,
	@Valor decimal (18, 3),
	@FechaVenta DATETIME,
	@Descripcion nvarchar(50)
AS
BEGIN
	INSERT INTO Venta
	VALUES(@IdVenta, @IdCliente, @IdProducto, @Valor, @FechaVenta, @Descripcion)
END
GO
/****** Object:  StoredProcedure [dbo].[BajaCliente]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BajaCliente]
	@IdCliente INT
AS
BEGIN
	DELETE FROM Cliente
	WHERE IdCliente = @IdCliente
END
GO
/****** Object:  StoredProcedure [dbo].[BajaImpresora]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BajaImpresora] 
	@IdImpresora INT
AS
BEGIN
	DELETE FROM Impresora 
	WHERE IdImpresora = @IdImpresora
END
GO
/****** Object:  StoredProcedure [dbo].[BajaMaterial]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BajaMaterial] 
	@IdMaterial INT

AS
BEGIN
	DELETE FROM Material
	WHERE IdMaterial = @IdMaterial
END
GO
/****** Object:  StoredProcedure [dbo].[BajaProducto]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BajaProducto]

AS
BEGIN
	DELETE FROM Producto 
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarClientes]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarClientes]
AS
BEGIN
	DELETE FROM Cliente
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarImpresora]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarImpresora]
	
AS
BEGIN
	DELETE FROM Impresora
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarMateriales]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarMateriales] 
	
AS
BEGIN
	DELETE FROM Material
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarProductos]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarProductos] 

AS
BEGIN
	DELETE FROM Producto
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarVentas]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarVentas]

AS
BEGIN
	DELETE FROM Venta
END
GO
/****** Object:  StoredProcedure [dbo].[ListarClientes]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ListarClientes]
AS
BEGIN
	SELECT * FROM Cliente
END
GO
/****** Object:  StoredProcedure [dbo].[ListarImpresoras]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarImpresoras] 

AS
BEGIN
	SELECT * FROM Impresora
END
GO
/****** Object:  StoredProcedure [dbo].[ListarMateriales]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarMateriales] 

AS
BEGIN
	SELECT * FROM Material
END
GO
/****** Object:  StoredProcedure [dbo].[ListarMaterialesPorTipo]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarMaterialesPorTipo]
    @Tipo nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON;
	SELECT * FROM Material
    WHERE CAST(Tipo AS nvarchar(50)) = CAST(@Tipo AS nvarchar(50));  
END;
GO
/****** Object:  StoredProcedure [dbo].[ListarProductos]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarProductos] 

AS
BEGIN
	SELECT * FROM Producto
END
GO
/****** Object:  StoredProcedure [dbo].[ListarVentas]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ListarVentas]
AS
BEGIN
	SELECT * FROM Venta
END
GO
/****** Object:  StoredProcedure [dbo].[ListarVentasPorFecha]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarVentasPorFecha]
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    DECLARE @FechaInicioNormalizada DATETIME = DATEADD(DAY, DATEDIFF(DAY, 0, @FechaInicio), 0); -- Inicio del día
    DECLARE @FechaFinNormalizada DATETIME = DATEADD(SECOND, -1, DATEADD(DAY, 1, DATEADD(DAY, DATEDIFF(DAY, 0, @FechaFin), 0))); -- Fin del día

    SELECT * FROM Venta
    WHERE FechaVenta BETWEEN @FechaInicioNormalizada AND @FechaFinNormalizada;
END;
GO
/****** Object:  StoredProcedure [dbo].[ModificarCliente]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarCliente]
	@IdCliente INT,
	@Nombre nvarchar(50),
	@Apellido nvarchar(50),
	@Dni INT
AS
BEGIN
	UPDATE Cliente
	SET
		Nombre = @Nombre,
		Apellido = @Apellido,
		Dni = @Dni
	WHERE IdCliente = @IdCliente
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarImpresora]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ModificarImpresora] 
	@IdImpresora INT,
	@ConsumoElectricoHr INT,
	@Descripcion nvarchar(50)

AS
BEGIN
	UPDATE Impresora
	SET
		ConsumoElectrico = @ConsumoElectricoHr,
		Descripcion = @Descripcion
	WHERE IdImpresora = @IdImpresora
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarMaterial]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarMaterial]
	@IdMaterial INT,
	@Color nvarchar(50),
	@PesoKg decimal(18, 3),
	@Costo decimal(18, 3),
	@Tipo nvarchar(50)
AS
BEGIN
	UPDATE Material
	SET
		Color = @Color,
		PesoKg = @PesoKg,
		Costo = @Costo,
		Tipo = @Tipo
	WHERE IdMaterial = @IdMaterial
END
GO
/****** Object:  StoredProcedure [dbo].[ValidarUsuario]    Script Date: 27/11/2024 10:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValidarUsuario]
    @NombreUsuario nvarchar(50),
    @Contrasenia nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT CASE 
        WHEN EXISTS (
            SELECT 1 
            FROM Usuario
            WHERE NombreUsuario = @NombreUsuario AND Contrasenia = @Contrasenia
        ) THEN 1
        ELSE 0
    END AS LoginExitoso;
END

GO
USE [master]
GO
ALTER DATABASE [QUILO3D] SET  READ_WRITE 
GO
