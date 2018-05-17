CREATE TABLE [dbo].[booksBorrowed]
(
	[bookNumber] INT NOT NULL PRIMARY KEY, 
    [dateOut] DATE NOT NULL, 
    [dateIn] DATE NOT NULL
)
