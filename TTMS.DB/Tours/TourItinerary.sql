CREATE TABLE [dbo].[TourItinerary]
(
	[ItineraryId] INT NOT NULL PRIMARY KEY, 
    [SrNo] INT NULL, 
    [ItineraryName] VARCHAR(50) NULL, 
    [DayNumber] INT NULL, 
    [Activities] TEXT NULL, 
    [StartDateTime] VARCHAR(20) NULL, 
    [EndDateTime] VARCHAR(20) NULL, 
    [ItineraryImg] IMAGE NULL,
    [Cost] MONEY NULL, 
    [DestinationId] INT NOT NULL, 
)
