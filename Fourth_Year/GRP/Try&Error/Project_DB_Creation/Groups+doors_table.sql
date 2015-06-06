USE [C:\DB\SDASDB.MDF]
GO
/****** Object:  Table [dbo].[Groups_Doors]    Script Date: 02/05/2008 19:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups_Doors](
	[groupNum] [int] NOT NULL,
	[doorNum] [int] NOT NULL,
 CONSTRAINT [PK_Groups_Doors] PRIMARY KEY CLUSTERED 
(
	[groupNum] ASC,
	[doorNum] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Groups_Doors]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Doors_Doors] FOREIGN KEY([doorNum])
REFERENCES [dbo].[Doors] ([doorNum])
GO
ALTER TABLE [dbo].[Groups_Doors] CHECK CONSTRAINT [FK_Groups_Doors_Doors]
GO
ALTER TABLE [dbo].[Groups_Doors]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Doors_Groups] FOREIGN KEY([groupNum])
REFERENCES [dbo].[Groups] ([groupNum])
GO
ALTER TABLE [dbo].[Groups_Doors] CHECK CONSTRAINT [FK_Groups_Doors_Groups]