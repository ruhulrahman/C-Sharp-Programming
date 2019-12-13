CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [productId] INT NULL, 
    [productQty] INT NULL, 
    [totalPrice] FLOAT NULL, 
    [date] DATE NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)
