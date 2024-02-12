CREATE TABLE [dbo].[TourItinerary]
(
	[ItineraryId] INT NOT NULL PRIMARY KEY, 
    [DayNumber] INT NOT NULL, 
    [Activities] TEXT NOT NULL, 
    [StartDateTime] DATETIME2 NOT NULL, 
    [EndDateTime] DATETIME2 NOT NULL, 
    [ItineraryImg] IMAGE NULL,
    [DestinationId] INT NOT NULL 
)
