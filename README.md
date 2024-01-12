# DesafioAeC

Foi utizado Console.Application com DDD mais Pattern Repository utiliando Dapper para persistencia de dados.
Camada App -> Inicialização do projeto
Camada Services -> Serviços onde o selenium está sendo utilizado para fazer a busca no alura.
Camada Data --> Configuração e inicialização das conexões com o banco de dados
Camada Domain --> camada de entidades que representam a tabela Courses e a interface IRepository

Para rodar o projeto:

Crie a tabela Courses

CREATE TABLE Courses(
Id int not null primary key identity,
Title nvarchar(max) not null,
Teacher nvarchar(max) not null,
WorkLoad nvarchar(3) not null,
Description nvarchar(max) not null
);

A inicialização do projeto está dentro da camada Desafio AeC.App na classe Initialize.cs.

O software inicializa monta as injeções de dependência, faz a busca no alura e efetua a pesquisa guardando os seguntes dados:   

•Titulo;
• Professor (Pode ser um ou todos);
• Carga Horária;
• Descrição; 
 Verifica se as propriedades acima estão preenchidas e salva no banco de dados.
