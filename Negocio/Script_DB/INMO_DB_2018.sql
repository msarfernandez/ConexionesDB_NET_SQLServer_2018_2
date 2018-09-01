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

CREATE TABLE [dbo].[PROPIEDADES](
	[IdPropiedad] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionGeneral] [varchar](250) NULL,
	[SuperficieCubierta] [int] NULL,
	[SuperficieDescubierta] [int] NULL,
	[Ambientes] [int] NULL,
	[IdDireccion] [int] NULL,
	[FechaAlta] [smalldatetime] NULL,
 CONSTRAINT [PK_PROPIEDADES] PRIMARY KEY CLUSTERED 
(
	[IdPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
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



