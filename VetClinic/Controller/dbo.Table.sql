﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NCHAR(100) NOT NULL, 
    [Password] NVARCHAR(20) NOT NULL
)

