set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UserStatus]
	
	(
	@BarcodeNumber nvarchar(50) ,
	@DoorNum int,
	@Status int OUTPUT
	)
	
AS
declare @rowsNum Int
declare @rowsNum2 Int
select @rowsNum=count(*) FROM dbo.Users 
	where Users.userID=@BarcodeNumber
	
	if (@rowsNum=0)
	BEGIN
		SET @Status=0		--User is Not Found
	END
	else
	BEGIN
select @rowsNum=count(*) FROM dbo.Users 
	where Users.User_valid=1
if(@rowsNum=0)
			SET @Status=3		--User is Not Allowed
		else 
begin
	SELECT @rowsNum2=count(*) from Users_Doors WHERE Users_Doors.DoorNum=@DoorNum
		if(@rowsNum2=0)
			SET @Status=1		--User is Not Allowed
		else SET @Status=2		--User is Allowed
END
	END

SELECT userID, userfName, userlName, userValid, userEmail, userPhone, userDescription, userStage, userImage FROM dbo.Users 
	where Users.userID=@BarcodeNumber
		--SELECT @Status=@
	--select @Status=rowsNum
	/* SET NOCOUNT ON */ 
	RETURN

