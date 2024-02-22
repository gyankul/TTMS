CREATE TABLE [dbo].[TourPackages]
(
	[PackageId] INT NOT NULL PRIMARY KEY, 
    [PackageName] VARCHAR(50) NULL, 
    [TotalSeats] INT NULL,
    [Duration] VARCHAR(30) NULL, 
    [DepartureDate] DATETIME NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [PackageImage] IMAGE NULL, 
)
