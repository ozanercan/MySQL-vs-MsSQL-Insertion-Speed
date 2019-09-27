USE [SpeedTest]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 27.09.2019 13:33:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[PersonNumber] [bigint] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
