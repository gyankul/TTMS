CREATE TABLE [dbo].[TourDestinations]
(
	[DestinationId] INT NOT NULL PRIMARY KEY, 
    [DestinationName] VARCHAR(50) NULL, 
    [Description] TEXT NULL, 
    [SrNo] INT NULL,
    [DestinationImg] IMAGE NULL, 
    [PackageId] INT NOT NULL
)
