CREATE TABLE [dbo].[ReceiptDetails]
(
	[ReceiptId] INT NOT NULL PRIMARY KEY, 
    [BookingId] INT NOT NULL, 
    [OnDate] SMALLDATETIME NOT NULL, 
    [CustomerName] VARCHAR(20) NOT NULL, 
    [AmtReceived] MONEY NOT NULL
)
