CREATE TABLE [dbo].[users]
(
	[numberOfUsers] INT NOT NULL PRIMARY KEY DEFAULT 0, 
    [username] VARCHAR(50) NOT NULL, 
    [email] VARCHAR(50) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [institution] VARCHAR(50) NOT NULL, 
    [location] VARCHAR(50) NOT NULL
)
