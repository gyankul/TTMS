CREATE TABLE [dbo].[TourDetails]
(
	[TourId] INT NOT NULL PRIMARY KEY, 
    [TourName] VARCHAR(30) NOT NULL, 
    [DepartureDate] DATETIME2 NOT NULL, 
    [PackageId] INT NOT NULL, 
    [vehicleId] INT NOT NULL, 
    [GuideId] INT NOT NULL
)
