USE VinlyStoreDB
GO

CREATE PROCEDURE Sp_MainPage_Top10NewAlbums
AS
SELECT TOP 10
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
ORDER BY AlbumId ASC
GO

CREATE PROCEDURE Sp_MainPage_Discounted15Album
as
SELECT TOP 15
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
ORDER BY Discount Desc
GO
CREATE PROCEDURE Sp_BestSellers
as
SELECT 
a.AlbumId,
a.AlbumName as 'Album Name',
SUM(od.Quantity) as 'Total Sales'
FROM Albums as a
LEFT JOIN Genres as g on a.GenreId=g.GenreId
LEFT JOIN Artists as ar on a.ArtistId=ar.ArtistId
LEFT JOIN OrderDetails as od on a.AlbumId=od.AlbumId
Where a.IsDeleted =0
GROUP BY a.AlbumId,a.AlbumName
Order by 'Total Sales'
GO

CREATE VIEW View_BestSellers
as
SELECT 
a.AlbumId,
a.AlbumName as 'Album Name',
SUM(od.Quantity) as 'Total Sales'
FROM Albums as a
LEFT JOIN OrderDetails as od on a.AlbumId=od.AlbumId
Where a.IsDeleted =0
GROUP BY a.AlbumId,a.AlbumName
GO

CREATE PROCEDURE Sp_BestSellersWithArtists
as
Select
bs.AlbumId,
bs.[Album Name],
al.ArtistId,
ar.ArtistName,
bs.[Total Sales]
FROM
View_BestSellers as bs 
LEFT JOIN Albums as al on bs.AlbumId=al.AlbumId
LEFT JOIN Artists as ar on al.ArtistId=ar.ArtistId