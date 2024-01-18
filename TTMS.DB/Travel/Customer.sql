CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT NOT NULL PRIMARY KEY, 
    [CustomerName] NCHAR(10) NOT NULL, 
    [CustomerAge] NCHAR(10) NOT NULL, 
    [CustomerGender] NCHAR(10) NOT NULL, 
    [CustomerContact] NCHAR(10) NOT NULL, 
    [CustomerEmail] NCHAR(10) NOT NULL, 
    [CustomerAddress] NCHAR(10) NOT NULL, 
    [Nationality] NCHAR(10) NOT NULL
)
