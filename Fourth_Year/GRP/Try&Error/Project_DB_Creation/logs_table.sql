USE [C:\DB\SDASDB.MDF]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 02/05/2008 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[time] [datetime] NOT NULL,
	[ID] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[doorNumber] [int] NOT NULL,
	[allowed] [bit] NULL,
 CONSTRAINT [PK_log] PRIMARY KEY CLUSTERED 
(
	[time] ASC,
	[ID] ASC,
	[doorNumber] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_Doors] FOREIGN KEY([doorNumber])
REFERENCES [dbo].[Doors] ([doorNum])
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_Doors]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_Users] FOREIGN KEY([ID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_Users]