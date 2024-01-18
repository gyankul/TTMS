CREATE TABLE [dbo].[Billing]
(
	[BillingId] INT NOT NULL PRIMARY KEY, 
    [BillingDate] NCHAR(10) NOT NULL, 
    [Amount] NCHAR(10) NOT NULL, 
    [TransactionId] NCHAR(10) NOT NULL
)
