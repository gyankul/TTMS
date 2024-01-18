CREATE TABLE [dbo].[Itinerary]
(
	[ItineraryId] INT NOT NULL PRIMARY KEY, 
    [DayNumber] INT NOT NULL, 
    [Activity] VARCHAR(MAX) NOT NULL, 
    [StartDateTime] SMALLDATETIME NOT NULL, 
    [EndDateTime] SMALLDATETIME NOT NULL, 
    [ItineraryImg] IMAGE NOT NULL
)
