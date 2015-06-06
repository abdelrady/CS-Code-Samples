USE [C:\DB\SDASDB.MDF]
GO
/****** Object:  Table [dbo].[Doors]    Script Date: 02/05/2008 19:56:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doors](
	[doorNum] [int] NOT NULL,
	[doorName] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[doorLastListUpdate] [datetime] NULL,
	[doorLastLogRecieved] [datetime] NULL,
	[doorIP] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[doorPassword] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[doorMAC] [nchar](60) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Doors] PRIMARY KEY CLUSTERED 
(
	[doorNum] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
