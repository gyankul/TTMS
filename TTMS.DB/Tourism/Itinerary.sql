CREATE TABLE [dbo].[Itinerary]
(
	[ItineraryId] INT NOT NULL PRIMARY KEY, 
    [DayNumber] INT NOT NULL, 
    [Activity] TEXT NOT NULL, 
    [StartDateTime] SMALLDATETIME NOT NULL, 
    [EndDateTime] SMALLDATETIME NOT NULL, 
    [ItineraryImg] IMAGE NOT NULL, 
    [DestinationId] INT NOT NULL
)
