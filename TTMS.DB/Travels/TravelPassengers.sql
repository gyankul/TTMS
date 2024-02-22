CREATE TABLE [dbo].[TravelPassengers]
(
	[PassengerId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [CustomerId] INT NOT NULL, 
    [SRNO] INT NULL,
    [Name] VARCHAR(30) NULL, 
    [Age] INT NULL, 
    [Gender] VARCHAR(20) NULL, 
    [Contact] VARCHAR(20) NULL, 
    [VerificationId] INT NOT NULL, 
    [VerificationNumber] VARCHAR(20) NULL, 
)
