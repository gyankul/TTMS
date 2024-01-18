CREATE TABLE [dbo].[ScheduleDetails]
(
	[ScheduleId] INT NOT NULL PRIMARY KEY, 
    [TourName] VARCHAR(30) NOT NULL, 
    [FromDate] SMALLDATETIME NOT NULL, 
    [ToDate] SMALLDATETIME NOT NULL, 
    [Seats] INT NOT NULL 
)
