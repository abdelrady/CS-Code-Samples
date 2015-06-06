USE [C:\DB\SDASDB.MDF]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 02/05/2008 19:58:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userID] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[userfName] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[userlName] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[userValid] [bit] NULL,
	[userEmail] [nchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[userPhone] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[userDescription] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[userStage] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[userImage] [image] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
