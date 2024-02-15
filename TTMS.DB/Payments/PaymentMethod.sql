CREATE TABLE [dbo].[PaymentMethod]
(
	[PaymentMethodId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [MethodName] NCHAR(10) NOT NULL
)
