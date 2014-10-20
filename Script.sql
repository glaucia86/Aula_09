---- Criação da tabela Pessoa -----

create table Pessoa
(
	IdPessoa		int primary key identity	not null,
	Nome			nvarchar(50)				not null,
	Email			nvarchar(50)				not null,
	DataCadastro	datetime					not null	
)

---- Criação da tabela Endereco -----

create table Endereco
(
	IdEndereco		int primary key identity	not null,
	Logradouro		nvarchar(50)				not null,
	Cidade			nvarchar(50)				not null,
	Estado			nvarchar(50)				not null,
	Tipo			nvarchar(50)				not null,
	IdPessoa		int							not null
)

-- realizando o relacionamento entre as classes 1 para n:
alter table Endereco
	add constraint Pessoa_Endereco_fk
	foreign key(IdPessoa) references Pessoa(IdPessoa)

	on delete no action
	on update no action
