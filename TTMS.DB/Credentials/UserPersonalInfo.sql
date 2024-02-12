CREATE TABLE [dbo].[UserPersonalInfo]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(30) NOT NULL, 
    [DOB] DATETIME NOT NULL, 
    [Gender] VARCHAR(20) NOT NULL, 
    [PhoneNo] VARCHAR(10) NOT NULL, 
    [Email] VARCHAR(30) NOT NULL, 
    [VerificationId] INT NOT NULL, 
    [VerificationImg] IMAGE NOT NULL
)
