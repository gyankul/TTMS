CREATE TABLE [dbo].[DriverDetails]
(
	[DriverId] INT NOT NULL PRIMARY KEY, 
    [DriverName] VARCHAR(30) NOT NULL, 
    [LicenceNo] VARCHAR(50) NOT NULL, 
    [Experience] VARCHAR(20) NOT NULL, 
    [ContactNo] VARCHAR(10) NOT NULL, 
    [JoiningDate] DATETIME NOT NULL
)
