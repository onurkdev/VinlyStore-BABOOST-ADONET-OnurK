USE VinlyStoreDB
GO
CREATE Procedure Sp_Orders_GetAll
AS
Select
o.OrderId,
o.OrderDate as 'Order Date',
o.Adress,
o.OrderQuantity as 'Order Quantity',
o.OrderGrandTotal as 'Grand Total',
o.UserId,
u.UserName as 'Created By'
From Orders as o 
LEFT JOIN Users as u
on o.UserId = u.UserId
GO

CREATE Procedure Sp_Orders_GetById @OrderId int
AS
SELECT
o.OrderId,
o.OrderDate as 'Order Date',
o.Adress,
o.OrderQuantity as 'Order Quantity',
o.OrderGrandTotal as 'Grand Total',
o.UserId,
u.UserName as 'Created By'
From Orders as o 
LEFT JOIN Users as u
on o.UserId = u.UserId
Where o.OrderId=@OrderId
GO

CREATE Procedure Sp_Orders_CreateUpdate
@OrderId INT=0,
@OrderDate DateTime ,
@Adress NVARCHAR(255),
@OrderQuantity int,
@OrderGrandTotal numeric,
@UserId int 
AS
IF(@OrderId=0)
BEGIN
Insert into Orders(
OrderDate  ,
Adress ,
OrderQuantity,
OrderGrandTotal,
UserId 
)
Values(

@OrderDate  ,
@Adress ,
@OrderQuantity ,
@OrderGrandTotal,
@UserId 
)
SELECT @@IDENTITY as Id
END
ELSE
BEGIN
UPDATE Orders SET
OrderId=@OrderId ,
OrderDate=@OrderDate ,
Adress=@Adress,
OrderQuantity=@OrderQuantity,
OrderGrandTotal=@OrderGrandTotal ,
UserId=@UserId  
Where OrderId=@OrderId
END
GO
CREATE PROCEDURE Sp_Order_Delete @OrderId Int
AS
UPDATE Orders SET

IsDeleted=1

WHERE OrderId=@OrderId
SELECT @OrderId AS ID
GO