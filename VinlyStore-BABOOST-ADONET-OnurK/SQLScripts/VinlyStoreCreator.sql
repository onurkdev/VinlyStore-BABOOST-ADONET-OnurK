CREATE DATABASE VinlyStoreDB
GO
USE VinlyStoreDB
GO

Create Table Users(
UserId INT IDENTITY(1,1) PRIMARY KEY,
FirstName NVARCHAR(100),
LastName NVARCHAR(100),
Email NVARCHAR(100) Unique,
UserPassword NVARCHAR(16),
Phone NVARCHAR(100) Unique,
IsDeleted BIT DEFAULT 0,
)

CREATE Table Genres(
GenreId INT IDENTITY(1,1) PRIMARY KEY,
GenreName NVARCHAR(100),
IsDeleted BIT DEFAULT 0,
)
GO
Create Table Artists(
ArtistId INT IDENTITY(1,1) PRIMARY KEY,
ArtistName NVARCHAR(100),
IsDeleted BIT DEFAULT 0,
)
GO
Create Table Albums(
AlbumId INT IDENTITY(1,1) PRIMARY KEY,
AlbumName NVARCHAR(100),
GenreId INT FOREIGN KEY REFERENCES Genres(GenreId),
ArtistId INT FOREIGN KEY REFERENCES Artists(ArtistId),
Price Numeric,
Discount Numeric Default 0,
IsDeleted BIT DEFAULT 0,
)
GO
Create Table Orders (
OrderId INT IDENTITY(1,1) PRIMARY KEY,
OrderDate DateTime ,
Adress NVARCHAR(255),
OrderQuantity int,
OrderGrandTotal numeric,
UserId int FOREIGN KEY REFERENCES Users(UserId),
IsDeleted BIT DEFAULT 0
) 
Go
Create Table OrderDetails(
OrderDetailId INT IDENTITY(1,1) PRIMARY KEY,
OrderId int FOREIGN KEY REFERENCES Orders(OrderId),
AlbumId int FOREIGN KEY REFERENCES Albums(AlbumId),
Quantity int ,
Discount numeric,
ListPrice numeric,
BilledPrice numeric,
IsDeleted BIT DEFAULT 0
)

