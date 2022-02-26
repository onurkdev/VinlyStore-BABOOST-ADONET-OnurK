USE VinlyStoreDB
GO

CREATE Procedure Sp_User_CheckUser @Email Nvarchar
AS
Select Email from Users Where Email = @Email
GO

CREATE Procedure Sp_User_PasswordCheck @Email Nvarchar, @UserPassword Nvarchar
AS
Select * from Users Where Email = @Email AND UserPassword = @UserPassword
GO

CREATE Procedure Sp_User_Register

@FirstName NVARCHAR(100),
@LastName NVARCHAR(100),
@Email NVARCHAR(100),
@UserPassword NVARCHAR(100),
@Phone NVARCHAR 
AS
INSERT INTO Users(


FirstName ,
LastName,
Email ,
UserPassword ,
Phone 


) VALUES (


@FirstName ,
@LastName,
@Email ,
@UserPassword ,
@Phone

)
SELECT @@IDENTITY as ID
GO


