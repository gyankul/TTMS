CREATE TABLE [dbo].[Destination]
(
	[DestinationId] INT NOT NULL PRIMARY KEY, 
    [DestinationName] VARCHAR(30) NOT NULL, 
    [Description] VARCHAR(MAX) NOT NULL, 
    [DestinationImg] IMAGE NOT NULL
)
