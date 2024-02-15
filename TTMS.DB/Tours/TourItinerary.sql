CREATE TABLE [dbo].[TourItinerary]
(
	[ItineraryId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [SrNo] VARCHAR(10) NOT NULL, 
    [ItineraryName] VARCHAR(50) NOT NULL, 
    [DayNumber] VARCHAR(10) NOT NULL, 
    [Activities] TEXT NOT NULL, 
    [StartDateTime] DATETIME2 NOT NULL, 
    [EndDateTime] DATETIME2 NOT NULL, 
    [ItineraryImg] IMAGE NULL,
    [DestinationId] INT NOT NULL, 
)
