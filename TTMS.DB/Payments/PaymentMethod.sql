CREATE TABLE [dbo].[PaymentMethod]
(
	[PaymentMethodId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [MethodName] VARCHAR(30) NULL
)
