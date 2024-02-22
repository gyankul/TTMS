CREATE TABLE [dbo].[TourItinerary]
(
	[ItineraryId] INT NOT NULL PRIMARY KEY, 
    [SrNo] INT NULL, 
    [ItineraryName] VARCHAR(50) NULL, 
    [DayNumber] INT NULL, 
    [Activities] TEXT NULL, 
    [StartDateTime] DATETIME2 NULL, 
    [EndDateTime] DATETIME2 NULL, 
    [ItineraryImg] IMAGE NULL,
    [Cost] MONEY NULL, 
    [DestinationId] INT NOT NULL, 
)
