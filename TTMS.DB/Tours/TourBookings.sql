CREATE TABLE [dbo].[TourBookings]
(
	[BookingId] INT NOT NULL PRIMARY KEY, 
    [BookingDate] DATETIME NOT NULL, 
    [PackageId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [NoOfParticipants] VARCHAR(20) NOT NULL
)
