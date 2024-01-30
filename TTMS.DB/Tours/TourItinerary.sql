CREATE TABLE [dbo].[TourItinerary]
(
	[ItineraryId] INT NOT NULL PRIMARY KEY, 
    [DestinationId] INT NOT NULL, 
    [DayNumber] INT NOT NULL, 
    [Activities] TEXT NOT NULL, 
    [StartDateTime] DATETIME2 NOT NULL, 
    [EndDateTime] DATETIME2 NOT NULL, 
    [ItineraryImg] IMAGE NOT NULL
)
