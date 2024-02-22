CREATE TABLE [dbo].[CustomerDetails]
(
	[CustomerId] INT NOT NULL PRIMARY KEY, 
    [CustomerName] VARCHAR(30) NULL, 
    [DOB] DATETIME NULL, 
    [Gender] VARCHAR(20) NULL, 
    [Contact] VARCHAR(20) NULL, 
    [Email] VARCHAR(30) NULL, 
    [Address] VARCHAR(50) NULL, 
    [Nationality] VARCHAR(20) NULL, 
    [VerificationId] INT NOT NULL, 
    [VerificationNo] VARCHAR(30) NULL
)
