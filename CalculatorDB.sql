USE [CalculatorDB]
GO
/****** Object:  Table [dbo].[ADDITION]    Script Date: 13/04/2024 2:31:25 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADDITION](
	[Value1] [int] NULL,
	[Sign] [varchar](1) NULL,
	[Value2] [int] NULL,
	[Result] [float] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIVISION]    Script Date: 13/04/2024 2:31:25 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIVISION](
	[Value1] [int] NULL,
	[Sign] [varchar](1) NULL,
	[Value2] [int] NULL,
	[Result] [float] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MULTIPLICATION]    Script Date: 13/04/2024 2:31:25 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MULTIPLICATION](
	[Value1] [int] NULL,
	[Sign] [varchar](1) NULL,
	[Value2] [int] NULL,
	[Result] [float] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SQUARE]    Script Date: 13/04/2024 2:31:25 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SQUARE](
	[Value] [int] NULL,
	[Sign] [varchar](1) NULL,
	[Result] [float] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SQUAREROOT]    Script Date: 13/04/2024 2:31:25 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SQUAREROOT](
	[Value] [int] NULL,
	[Sign] [varchar](1) NULL,
	[Result] [float] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUBTRACTION]    Script Date: 13/04/2024 2:31:25 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUBTRACTION](
	[Value1] [int] NULL,
	[Sign] [varchar](1) NULL,
	[Value2] [int] NULL,
	[Result] [float] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
