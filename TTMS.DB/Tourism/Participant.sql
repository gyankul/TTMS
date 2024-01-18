CREATE TABLE [dbo].[Participant]
(
	[ParticipantId] INT NOT NULL PRIMARY KEY, 
    [ParticipantName] VARCHAR(30) NOT NULL, 
    [Age] INT NOT NULL, 
    [Gender] VARCHAR(50) NOT NULL, 
    [Number] NCHAR(10) NOT NULL
)
