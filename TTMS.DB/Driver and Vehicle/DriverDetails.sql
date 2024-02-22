CREATE TABLE [dbo].[DriverDetails]
(
	[DriverId] INT NOT NULL PRIMARY KEY, 
    [DriverName] VARCHAR(30) NULL, 
    [DOB] DATETIME NULL,
    [Gender] VARCHAR(20) NULL, 
    [ContactNo] VARCHAR(20) NULL, 
    [Email] VARCHAR(30) NULL, 
    [VerificationId] INT NOT NULL, 
    [VerificationImage] IMAGE NULL, 
    [Experience] VARCHAR(20) NULL, 
    [JoiningDate] DATETIME NULL, 
)
