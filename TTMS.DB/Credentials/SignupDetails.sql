CREATE TABLE [dbo].[SignupDetails]
(
    [UserId] INT NOT NULL PRIMARY KEY,
	[Username] VARCHAR(10) NOT NULL , 
    [Name] VARCHAR(30) NOT NULL,
    [Password] VARCHAR(20) NOT NULL, 
    [SecurityQuestion] VARCHAR(30) NOT NULL, 
    [SecurityAnswer] VARCHAR(30) NOT NULL, 
    [StaffTypeId] INT NOT NULL REFERENCES StaffTypes(StaffTypeId), 
)
