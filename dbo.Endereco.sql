CREATE TABLE [dbo].[Endereco]
(
	[IdEndereco] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Logradouro] NVARCHAR(50) NULL, 
    [Cidade] NVARCHAR(50) NULL, 
    [Estado] NVARCHAR(50) NULL, 
    [Tipo] NVARCHAR(50) NULL, 
    [IdPessoa] INT NULL,
)
