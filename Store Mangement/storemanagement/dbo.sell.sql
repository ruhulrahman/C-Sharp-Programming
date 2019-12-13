CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [productId] INT NULL, 
    [productQty] INT NULL, 
    [discountPrice] FLOAT NULL, 
    [totalPrice] FLOAT NULL, 
    [date] DATETIME2 NULL, 
    [userId] INT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)
