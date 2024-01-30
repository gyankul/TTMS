CREATE TABLE [dbo].[TravelPassengers]
(
	[PassengerId] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [Name] VARCHAR(30) NOT NULL, 
    [Age] INT NOT NULL, 
    [Gender] VARCHAR(10) NOT NULL, 
    [VerificationId] VARCHAR(20) NOT NULL, 
    [Contact] VARCHAR(20) NOT NULL, 
    [VerificationNumber] VARCHAR(20) NOT NULL
)
