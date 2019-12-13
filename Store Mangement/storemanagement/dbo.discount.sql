CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [productId] INT NULL, 
    [discountRate] INT NULL, 
    [discountPrice] FLOAT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)
