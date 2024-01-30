CREATE TABLE [dbo].[TravelStops]
(
	[StopId] INT NOT NULL PRIMARY KEY, 
    [TravelId] INT NOT NULL, 
    [StopNumber] INT NOT NULL, 
    [StopName] VARCHAR(30) NOT NULL
)
