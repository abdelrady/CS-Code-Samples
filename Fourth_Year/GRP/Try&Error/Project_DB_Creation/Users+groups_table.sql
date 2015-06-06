USE [C:\DB\SDASDB.MDF]
GO
/****** Object:  Table [dbo].[Users_Groups]    Script Date: 02/05/2008 19:59:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_Groups](
	[userID] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[GroupNum] [int] NOT NULL,
 CONSTRAINT [PK_Users_Groups] PRIMARY KEY CLUSTERED 
(
	[userID] ASC,
	[GroupNum] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Users_Groups]  WITH CHECK ADD  CONSTRAINT [FK_Users_Groups_Groups] FOREIGN KEY([GroupNum])
REFERENCES [dbo].[Groups] ([groupNum])
GO
ALTER TABLE [dbo].[Users_Groups] CHECK CONSTRAINT [FK_Users_Groups_Groups]
GO
ALTER TABLE [dbo].[Users_Groups]  WITH CHECK ADD  CONSTRAINT [FK_Users_Groups_Users] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[Users_Groups] CHECK CONSTRAINT [FK_Users_Groups_Users]