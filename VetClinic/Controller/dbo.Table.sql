﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Username] NCHAR(50) NOT NULL, 
    [Password] NVARCHAR(20) NOT NULL
)
