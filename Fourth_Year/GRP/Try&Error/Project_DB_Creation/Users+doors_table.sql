USE [C:\DB\SDASDB.MDF]
GO
/****** Object:  Table [dbo].[Users_Doors]    Script Date: 02/05/2008 19:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_Doors](
	[userID] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[doorNum] [int] NOT NULL,
 CONSTRAINT [PK_Users_Doors] PRIMARY KEY CLUSTERED 
(
	[userID] ASC,
	[doorNum] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Users_Doors]  WITH CHECK ADD  CONSTRAINT [FK_Users_Doors_Doors] FOREIGN KEY([doorNum])
REFERENCES [dbo].[Doors] ([doorNum])
GO
ALTER TABLE [dbo].[Users_Doors] CHECK CONSTRAINT [FK_Users_Doors_Doors]
GO
ALTER TABLE [dbo].[Users_Doors]  WITH CHECK ADD  CONSTRAINT [FK_Users_Doors_Users] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[Users_Doors] CHECK CONSTRAINT [FK_Users_Doors_Users]