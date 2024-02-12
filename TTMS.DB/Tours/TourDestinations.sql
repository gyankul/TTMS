CREATE TABLE [dbo].[TourDestinations]
(
	[DestinationId] INT NOT NULL PRIMARY KEY, 
    [DestinationName] VARCHAR(30) NOT NULL, 
    [Description] TEXT NOT NULL, 
    [DestinationImg] IMAGE NULL, 
    [PackageId] INT NOT NULL
)
