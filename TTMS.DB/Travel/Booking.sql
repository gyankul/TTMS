CREATE TABLE [dbo].[Booking]
(
	[BookingId] INT NOT NULL PRIMARY KEY, 
    [SeatsAssigned] NCHAR(10) NOT NULL, 
    [TotalPassenger] NCHAR(10) NOT NULL, 
    [TotalFare] NCHAR(10) NOT NULL, 
    [BookingDate] NCHAR(10) NOT NULL, 
    [JourneyDate] NCHAR(10) NOT NULL
)
