CREATE TABLE [dbo].[AdministratorInfoes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Login] NVARCHAR(MAX) NOT NULL, 
    [Password] NVARCHAR(MAX) NOT NULL, 
    [NumberCard] NVARCHAR(MAX) NOT NULL, 
    [SecondName] NVARCHAR(MAX) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [MiddleName] NVARCHAR(MAX) NULL, 
    [BDay] DATETIME NOT NULL, 
    [EMail] NVARCHAR(MAX) NULL, 
    [Phone] NVARCHAR(MAX) NOT NULL
)
