CREATE TABLE [dbo].[Travel]
(
	[TravelId] INT NOT NULL PRIMARY KEY, 
    [TravelName] NCHAR(10) NOT NULL, 
    [Source] NCHAR(10) NOT NULL, 
    [Destination] NCHAR(10) NOT NULL, 
    [FarePerPerson] NCHAR(10) NOT NULL
)
