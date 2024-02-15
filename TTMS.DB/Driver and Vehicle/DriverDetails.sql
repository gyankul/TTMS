CREATE TABLE [dbo].[DriverDetails]
(
	[DriverId] INT NOT NULL PRIMARY KEY, 
    [DriverName] VARCHAR(30) NOT NULL, 
    [DOB] DATETIME NOT NULL,
    [Gender] VARCHAR(20) NOT NULL, 
    [ContactNo] VARCHAR(10) NOT NULL, 
    [Email] VARCHAR(30) NOT NULL, 
    [VerificationId] INT NOT NULL, 
    [VerificationImage] IMAGE NOT NULL, 
    [Experience] VARCHAR(20) NOT NULL, 
    [JoiningDate] DATETIME NOT NULL, 
)
