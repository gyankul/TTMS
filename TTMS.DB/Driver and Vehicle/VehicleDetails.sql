CREATE TABLE [dbo].[VehicleDetails]
(
	[VehicleId] INT NOT NULL PRIMARY KEY, 
    [VehicleName] VARCHAR(30) NULL, 
    [Capacity] INT NULL, 
    [DriverId] INT NOT NULL, 
    [SeatingType] VARCHAR(30) NULL, 
    [VehicleLicenceNo] VARCHAR(30) NULL
)
