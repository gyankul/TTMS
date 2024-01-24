CREATE TABLE [dbo].[TourDetails]
(
	[TourId] INT NOT NULL PRIMARY KEY, 
    [TourName] VARCHAR(30) NOT NULL, 
    [Days] INT NOT NULL, 
    [TotalSeats] INT NOT NULL, 
    [AdultRate] MONEY NOT NULL, 
    [Childrate] MONEY NOT NULL
)
