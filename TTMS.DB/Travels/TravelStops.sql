CREATE TABLE [dbo].[TravelStops]
(
	[StopId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [TravelId] INT NOT NULL, 
    [StopNumber] INT NULL, 
    [StopName] VARCHAR(30) NULL, 
    [Distance] VARCHAR(20) NULL
)
