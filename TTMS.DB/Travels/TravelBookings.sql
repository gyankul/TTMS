CREATE TABLE [dbo].[TravelBookings]
(
	[BookingId] INT NOT NULL PRIMARY KEY, 
    [BookingDate] DATETIME NOT NULL, 
    [BookingFrom] VARCHAR(20) NOT NULL, 
    [BookingTo] VARCHAR(20) NOT NULL, 
    [TravelId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [NoOfPassenger] INT NOT NULL, 
    [TotalDistance] VARCHAR(10) NULL, 
    [TotalFare] MONEY NULL
)
