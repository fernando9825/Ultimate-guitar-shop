CREATE TABLE [dbo].[acusticas]
(
	[nombre_producto] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [marca] VARCHAR(50) NULL, 
    [precio] MONEY NOT NULL, 
    [existencias] INT NOT NULL IDENTITY(50, 1), 
    [descripcion] VARCHAR(MAX) NULL
)
