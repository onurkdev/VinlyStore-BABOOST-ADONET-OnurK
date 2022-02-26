USE VinlyStoreDB
GO
CREATE PROCEDURE Sp_Album_GetAll 
AS
SELECT 
a.AlbumId,
a.AlbumName as 'Album Name',
a.GenreId,
g.GenreName as 'Genre',
a.ArtistId,
ar.ArtistName as 'Artist Name',
a.Price,
a.Discount
FROM Albums as a
LEFT JOIN Genres as g on a.GenreId=g.GenreId
LEFT JOIN Artists as ar on a.ArtistId=ar.ArtistId
Where a.IsDeleted =0
GO

CREATE PROCEDURE Sp_Album_GetById @AlbumId INT 
AS
SELECT 
a.AlbumId,
a.AlbumName as 'Album Name',
a.GenreId,
g.GenreName as 'Genre',
a.ArtistId,
ar.ArtistName as 'Artist Name',
a.Price,
a.Discount
FROM Albums as a
LEFT JOIN Genres as g on a.GenreId=g.GenreId
LEFT JOIN Artists as ar on a.ArtistId=ar.ArtistId
where a.AlbumId = @AlbumId and a.IsDeleted=0 and ar.IsDeleted=0
GO

CREATE PROCEDURE Sp_Album_GetByArtist @ArtistId INT 
AS
SELECT 
a.AlbumId,
a.AlbumName as 'Album Name',
a.GenreId,
g.GenreName as 'Genre',
a.ArtistId,
ar.ArtistName as 'Artist Name',
a.Price,
a.Discount
FROM Albums as a
LEFT JOIN Genres as g on a.GenreId=g.GenreId
LEFT JOIN Artists as ar on a.ArtistId=ar.ArtistId
where a.ArtistId = @ArtistId and a.IsDeleted=0 and ar.IsDeleted=0
GO

CREATE PROCEDURE Sp_Album_GetbyGenre @GenreId int
AS
SELECT 
a.AlbumId,
a.AlbumName as 'Album Name',
a.GenreId,
g.GenreName as 'Genre',
a.ArtistId,
ar.ArtistName as 'Artist Name',
a.Price,
a.Discount
FROM Albums as a
LEFT JOIN Genres as g on a.GenreId=g.GenreId
LEFT JOIN Artists as ar on a.ArtistId=ar.ArtistId
where a.GenreId = @GenreId and a.IsDeleted=0 and ar.IsDeleted=0
GO


Create procedure Sp_Album_CreateUpdate
@AlbumId int=0,
@AlbumName NVARCHAR(100),
@GenreId INT ,
@ArtistId INT ,
@Price Numeric,
@Discount Numeric
As
IF(@AlbumId=0)
BEGIN
INSERT INTO Albums(
AlbumName,
GenreId,
ArtistId,
Price,
Discount
)
Values(
@AlbumName,
@GenreId,
@ArtistId,
@Price,
@Discount
)
SELECT @@IDENTITY as Id
END
ELSE
BEGIN
UPDATE Albums SET
AlbumName=@AlbumName,
GenreId=@GenreId,
ArtistId=@ArtistId,
Price=@Price,
Discount=@Discount
Where AlbumId=@AlbumId
SELECT @@IDENTITY as Id
END
GO
CREATE PROCEDURE Sp_Album_Delete @AlbumId Int
AS
UPDATE Albums SET

IsDeleted=1

WHERE AlbumId=@AlbumId
SELECT @AlbumId AS ID
GO