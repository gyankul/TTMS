CREATE TABLE [dbo].[BillDetails]
(
	[BillId] INT NOT NULL PRIMARY KEY, 
    [BillDate] SMALLDATETIME NOT NULL, 
    [BookingId] INT NOT NULL, 
    [TourName] VARCHAR(30) NOT NULL, 
    [CustomerName] VARCHAR(20) NOT NULL, 
    [ScheduleId] INT NOT NULL, 
    [DepartDate] SMALLDATETIME NOT NULL, 
    [ArriveDate] SMALLDATETIME NOT NULL, 
    [AdvAmount] MONEY NOT NULL, 
    [TotalAmount] MONEY NOT NULL
)
