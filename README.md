# TestCapgemini.API
Projeto de teste para empresa Capgemini

Para executar o projeto de Cadastro de Usuário é preciso seguir os próximos passos:

O projeto roda totalmente de forma local, tanto quanto a API quanto o banco de dados em SQL Server;

Antes de começar, faça o clone do repositório atual e do TestCapgemini.FRONT (onde se encontra a parte do front-end em Angular);

Para executar o projeto, execute esses passos no back-end e no front-end:

Back-End -> 
 - Configurar a string de conexão para executar o banco de dados de forma local;
 - Rodar uma migration para gerar as tabelas via EntityFramework Core.

Front-End -> 
 - Alterar a URLLocal no arquivo UserService.

Após isso, é possível fazer um CRUD na tabela de Usuarios.
