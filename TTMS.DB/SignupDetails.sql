CREATE TABLE [dbo].[SignupDetails]
(
	[Role] VARCHAR(20) NOT NULL PRIMARY KEY, 
    [Username] VARCHAR(20) NOT NULL, 
    [Password] VARCHAR(20) NOT NULL, 
    [SecurityQuestion] VARCHAR(20) NOT NULL, 
    [SecurityAnswer] VARCHAR(20) NOT NULL
)
