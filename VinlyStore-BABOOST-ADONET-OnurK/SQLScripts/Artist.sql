USE VinlyStoreDB
GO
CREATE PROCEDURE Sp_Artist_GetAll
AS
Select a.ArtistId as 'Artist ID', a.ArtistName AS'Artist Name' from Artists as a
GO

CREATE PROCEDURE Sp_Artist_GetById @ArtistId int
AS
Select a.ArtistId as 'Artist ID', a.ArtistName AS'Artist Name' from Artists as a
Where a.ArtistId = @ArtistId
GO

CREATE PROCEDURE Sp_Artist_AddUpdate 
@ArtistId INT=0,
@ArtistName NVARCHAR(100)
AS
IF(@ArtistId=0)
BEGIN
INSERT INTO Artists
(
ArtistName
)
VALUES
(
@ArtistName
)
SELECT @@IDENTITY as Id
END
ELSE
BEGIN
UPDATE Artists SET 
ArtistName=@ArtistName
WHERE ArtistId = @ArtistId
Select @ArtistId as Id
END
GO

CREATE PROCEDURE Sp_Artist_Delete @ArtistId Int
AS
UPDATE Artists SET

IsDeleted=1

WHERE ArtistId=@ArtistId
SELECT @ArtistId AS Id
GO

