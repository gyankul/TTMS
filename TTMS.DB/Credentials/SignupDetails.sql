CREATE TABLE [dbo].[SignupDetails]
(
	[Username] VARCHAR(30) NOT NULL , 
    [Password] VARCHAR(30) NULL, 
    [SecurityQuestion] VARCHAR(30) NULL, 
    [SecurityAnswer] VARCHAR(30) NULL, 
    [StaffTypeId] INT NOT NULL REFERENCES StaffTypes(StaffTypeId), 
    [UserImage] IMAGE NULL, 
    [Name] VARCHAR(30) NULL, 
    [DOB] DATETIME NULL, 
    [Gender] VARCHAR(30) NULL, 
    [PhoneNo] VARCHAR(30) NULL, 
    [Email] VARCHAR(30) NULL, 
    [VerificationId] INT NOT NULL, 
    [VerificationImg] IMAGE NULL, 
    PRIMARY KEY ([Username]),
)
