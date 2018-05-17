CREATE TABLE [dbo].[donations]
(
	[donationsNumber] INT NOT NULL PRIMARY KEY, 
    [fullName] VARCHAR(50) NOT NULL, 
    [email] VARCHAR(50) NOT NULL, 
    [bookTitle] VARCHAR(50) NOT NULL
)
