CREATE TABLE [dbo].[Pessoa]
(
	[IdPessoa] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [DataCadastro] DATETIME NULL
)
