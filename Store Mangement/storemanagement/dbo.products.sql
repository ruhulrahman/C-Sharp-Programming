CREATE TABLE [dbo].[Table]
(
	[productId] INT NOT NULL PRIMARY KEY, 
    [productName] VARCHAR(50) NULL, 
    [productModel] VARCHAR(50) NULL, 
    [productExpireDate] TIMESTAMP NULL, 
    [productPrice] FLOAT NULL, 
    [productQty] INT NULL, 
    [totalPrice] FLOAT NULL, 
    [date] DATE NULL
)
