CREATE TABLE [dbo].[CustomerDetails]
(
	[CustomerId] INT NOT NULL PRIMARY KEY, 
    [CustomerName] VARCHAR(20) NOT NULL,
	[CustomerAge] INT NOT NULL, 
    [CustomerAddress] VARCHAR(30) NOT NULL, 
    [ContactInfo] NCHAR(10) NOT NULL, 
    [Email] VARCHAR(30) NOT NULL, 
)
