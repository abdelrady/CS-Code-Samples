USE [C:\DB\SDASDB.MDF]
GO
/****** Object:  StoredProcedure [dbo].[UsersList]    Script Date: 03/22/2008 01:55:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsersList] 
	
	(
	@DoorNum int
	)
	
AS
Declare @NumOfUsers int

SELECT @NumOfUsers=count(*) FROM Users_Doors INNER JOIN Users ON Users_Doors.userID = Users.userID 
WHERE(Users_Doors.doorNum = @DoorNum) AND (Users.userValid = 1)

SELECT DISTINCT Users_Doors.userID FROM Users_Doors INNER JOIN Users ON Users_Doors.userID = Users.userID
 WHERE(Users_Doors.doorNum = @DoorNum) AND (Users.userValid = 1)
	/* SET NOCOUNT ON */ 
	RETURN @NumOfUsers
