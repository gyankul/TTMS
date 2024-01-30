CREATE TABLE [dbo].[TourPackages]
(
	[PackageId] INT NOT NULL PRIMARY KEY, 
    [PackageName] VARCHAR(30) NOT NULL, 
    [Duration] VARCHAR(30) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [DestinationId] INT NOT NULL, 
    [PackageImage] IMAGE NOT NULL
)
