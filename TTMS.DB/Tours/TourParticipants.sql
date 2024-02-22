CREATE TABLE [dbo].[TourParticipants]
(
	[ParticipantId] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [Name] VARCHAR(30) NULL, 
    [Age] INT NULL, 
    [Gender] VARCHAR(20) NULL, 
    [Contact] VARCHAR(20) NULL, 
    [VerificationId] INT NULL, 
    [VerificationNumber] VARCHAR(20) NULL
)
