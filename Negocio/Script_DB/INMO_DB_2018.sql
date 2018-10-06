use master
go
create database INMO_DB
go
use INMO_DB
go
USE [INMO_DB]
GO

/****** Object:  Table [dbo].[PROPIEDADES]    Script Date: 09/01/2018 11:33:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

USE [INMO_DB]
GO

/****** Object:  Table [dbo].[PROPIEDADES]    Script Date: 10/05/2018 21:51:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PROPIEDADES](
	[IdPropiedad] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionGeneral] [varchar](250) NULL,
	[SuperficieCubierta] [int] NULL,
	[SuperficieDescubierta] [int] NULL,
	[Ambientes] [int] NULL,
	[IdDireccion] [int] NULL,
	[FechaAlta] [smalldatetime] NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_PROPIEDADES] PRIMARY KEY CLUSTERED 
(
	[IdPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



USE [INMO_DB]
GO

/****** Object:  Table [dbo].[AMBIENTES]    Script Date: 09/28/2018 21:33:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[AMBIENTES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPropiedad] [int] NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_AMBIENTES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[AMBIENTES]  WITH CHECK ADD  CONSTRAINT [FK_AMBIENTES_PROPIEDADES] FOREIGN KEY([IdPropiedad])
REFERENCES [dbo].[PROPIEDADES] ([IdPropiedad])
GO

ALTER TABLE [dbo].[AMBIENTES] CHECK CONSTRAINT [FK_AMBIENTES_PROPIEDADES]
GO

USE [INMO_DB]
GO

/****** Object:  Table [dbo].[DIRECCIONES]    Script Date: 09/28/2018 21:34:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DIRECCIONES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Calle] [varchar](50) NULL,
	[Numero] [int] NULL,
	[Piso] [int] NULL,
	[IdLocalidad] [int] NULL,
 CONSTRAINT [PK_DIRECCIONES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [INMO_DB]
GO

/****** Object:  Table [dbo].[LOCALIDADES]    Script Date: 10/06/2018 09:43:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[LOCALIDADES](
	[IdLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[CP] [varchar](50) NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_LOCALIDADES] PRIMARY KEY CLUSTERED 
(
	[IdLocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



GO
select * from PROPIEDADES
INSERT INTO [INMO_DB].[dbo].[PROPIEDADES]
           ([DescripcionGeneral]
           ,[SuperficieCubierta]
           ,[SuperficieDescubierta]
           ,[Ambientes]
           ,[FechaAlta])
     VALUES
           ('Es una casa bastante amplia y luminoza'
           ,100
           ,300
           ,2
           ,'2018-08-31 21:42:00')
GO

INSERT INTO [INMO_DB].[dbo].[PROPIEDADES]
           ([DescripcionGeneral]
           ,[SuperficieCubierta]
           ,[SuperficieDescubierta]
           ,[Ambientes]
           ,[FechaAlta])
     VALUES
           ('Es una casa precaria, pero bue.'
           ,25
           ,120
           ,2
           ,'2018-08-31 21:42:00')
GO

INSERT INTO [INMO_DB].[dbo].[PROPIEDADES]
           ([DescripcionGeneral]
           ,[SuperficieCubierta]
           ,[SuperficieDescubierta]
           ,[Ambientes]
           ,[FechaAlta])
     VALUES
           ('Pequenio depto'
           ,15
           ,0
           ,1
           ,'2018-08-31 21:42:00')
GO


insert into LOCALIDADES values (1665, 'jose c paz')
insert into LOCALIDADES values (1663, 'san miguel')
insert into LOCALIDADES values (1744, 'moreno')
