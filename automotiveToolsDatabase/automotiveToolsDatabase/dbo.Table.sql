CREATE TABLE [dbo].[Table]
(
	[sku] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [description] NVARCHAR(MAX) NULL, 
    [price] DECIMAL NOT NULL, 
    [vendor price] DECIMAL NULL, 
    [category] VARCHAR(50) NOT NULL
)
