USE VinlyStoreDB
GO
CREATE PROCEDURE Sp_OrderDetails_GetAll
AS
SELECT
od.OrderDetailId,
od.OrderId,
od.AlbumId,
a.AlbumName as 'Album Name' ,
od.Discount,
od.Quantity,
od.ListPrice as 'List Price',
od.BilledPrice as  'Discounted Price',
a.GenreId,
g.GenreName as 'Genre',
a.ArtistId,
ar.ArtistName as 'Artist' ,
a.Price as 'Unit Price'
from
OrderDetails as od
LEFT JOIN Albums as a on od.AlbumId=a.AlbumId
LEFT JOIN Genres as g on a.GenreId=g.GenreId
LEFT JOIN Artists as ar on a.ArtistId=ar.ArtistId

GO
CREATE PROCEDURE Sp_OrderDetails_GetbyOrderId @OrderId int
AS
SELECT
od.OrderDetailId,
od.OrderId,
od.AlbumId,
a.AlbumName as 'Album Name' ,
od.Discount,
od.Quantity,
od.ListPrice as 'List Price',
od.BilledPrice as  'Discounted Price',
a.GenreId,
g.GenreName as 'Genre',
a.ArtistId,
ar.ArtistName as 'Artist' ,
a.Price as 'Unit Price'
from
OrderDetails as od
LEFT JOIN Albums as a on od.AlbumId=a.AlbumId
LEFT JOIN Genres as g on a.GenreId=g.GenreId
LEFT JOIN Artists as ar on a.ArtistId=ar.ArtistId
Where od.OrderId=@OrderId

GO
CREATE PROCEDURE Sp_OrderDetails_GetById @OrderDetailId int
AS
SELECT
od.OrderDetailId,
od.OrderId,
od.AlbumId,
a.AlbumName as 'Album Name' ,
od.Discount,
od.Quantity,
od.ListPrice as 'List Price',
od.BilledPrice as  'Discounted Price',
a.GenreId,
g.GenreName as 'Genre',
a.ArtistId,
ar.ArtistName as 'Artist' ,
a.Price as 'Unit Price'
from
OrderDetails as od
LEFT JOIN Albums as a on od.AlbumId=a.AlbumId
LEFT JOIN Genres as g on a.GenreId=g.GenreId
LEFT JOIN Artists as ar on a.ArtistId=ar.ArtistId
Where od.OrderDetailId=@OrderDetailId
GO
CREATE PROCEDURE Sp_OrderDetails_CreateUpdate
@OrderDetailId INT=0,
@OrderId int,
@AlbumId int ,
@Quantity int ,
@Discount numeric,
@ListPrice numeric,
@BilledPrice numeric
AS
IF(@OrderDetailId=0)
Begin
INSERT INTO OrderDetails(
OrderDetailId,
OrderId ,
AlbumId ,
Quantity ,
Discount,
ListPrice,
BilledPrice
)
VALUES(
@OrderDetailId,
@OrderId ,
@AlbumId  ,
@Quantity  ,
@Discount ,
@ListPrice ,
@BilledPrice 
)
SELECT @@IDENTITY as Id
end
else
begin
UPDATE OrderDetails SET
OrderDetailId=@OrderDetailId ,
OrderId=@OrderId ,
AlbumId=@AlbumId  ,
Quantity=@Quantity ,
Discount=@Discount,
ListPrice=@ListPrice ,
BilledPrice=@BilledPrice
Where OrderDetailId=@OrderId
SELECT @@IDENTITY as Id
end
GO
CREATE PROCEDURE Sp_OrderDetail_Delete @OrderDetailId Int
AS
UPDATE OrderDetails SET

IsDeleted=1

WHERE OrderDetailId=@OrderDetailId
SELECT @OrderDetailId AS ID
GO



