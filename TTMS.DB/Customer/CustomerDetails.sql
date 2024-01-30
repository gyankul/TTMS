CREATE TABLE [dbo].[CustomerDetails]
(
	[CustomerId] INT NOT NULL PRIMARY KEY, 
    [CustomerName] VARCHAR(30) NOT NULL, 
    [Age] INT NOT NULL, 
    [Gender] VARCHAR(20) NOT NULL, 
    [Contact] VARCHAR(20) NOT NULL, 
    [Email] VARCHAR(30) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [Nationality] VARCHAR(20) NOT NULL, 
    [VerificationId] INT NOT NULL
)
