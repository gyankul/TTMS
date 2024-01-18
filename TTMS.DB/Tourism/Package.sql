CREATE TABLE [dbo].[Package]
(
	[PackageId] INT NOT NULL PRIMARY KEY, 
    [PackageName] VARCHAR(30) NOT NULL, 
    [PackageDescription] VARCHAR(MAX) NOT NULL, 
    [Duration] NCHAR(10) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [PackageImg] IMAGE NOT NULL
)
