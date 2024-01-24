CREATE TABLE [dbo].[CancellationDetails]
(
	[CancelId] INT NOT NULL PRIMARY KEY, 
    [BillId] INT NOT NULL, 
    [OnDate] SMALLDATETIME NOT NULL, 
    [CustomerName] VARCHAR(20) NOT NULL, 
    [AdvAmount] MONEY NOT NULL, 
    [RefundAmount] MONEY NOT NULL
)
