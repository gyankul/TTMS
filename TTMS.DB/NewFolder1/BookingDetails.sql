CREATE TABLE [dbo].[BookingDetails]
(
	[BookingId] INT NOT NULL PRIMARY KEY,
	[BookingDate] SMALLDATETIME NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [CustomerName] VARCHAR(20) NOT NULL, 
    [ScheduleId] INT NOT NULL, 
    [NumAdult] INT NOT NULL, 
    [NumChild] INT NOT NULL, 
    [TotalAmount] MONEY NOT NULL, 
    [AdvAmount] MONEY NOT NULL, 
    [RemAmount] MONEY NOT NULL 
)
