# Projeto Biblioteca

Atividade de manunteção de código .Net MVC para o curso de Técnico em sistemas para internet do Senac RS 

<hr>

## Informações básicas:

<p>Este projeto é para o meu portfólio, podem passar qualquer feedback sobre o projeto e passar dicas sobre qualquer alteração ou melhora que possa ser feita.</p>

<p>E-mail: polibio.l.costa@gmail.com</p>

<p>Contato profissional: <a href="https://www.linkedin.com/in/polibio-lins/">Linkedin</a></p>

## Visão Geral:

O projeto Biblioteca é destinado à biblioteca municipal do bairro B e registra o empréstimo de livros. O sistema é baseado em plataforma web e será manipulado pelos funcionários da biblioteca. O projeto está na fase beta, e os requisitos a seguir se referem a essa versão. Novos requisitos poderão ser acrescentados para versões posteriores.
  

       

## Funcionalidades:

<p>Requisitos adicionados ao projeto implementados por mim na manutenção do código:<p>

**Livros:**

   * Cadastro de livros:
       - Para cada livro, deve-se registrar: título, autor e ano de publicação. 
       - Todos os campos são obrigatórios.
       
   * Listagem de livros:
       - Quando a listagem não trouxer nenhum elemento, deve aparecer na página a mensagem “Nenhum registro encontrado”.
       
   * Edição de livros:
       - Todos os campos de livro devem poder ser editados
       
**Empréstimos:**

   * Cadastro de empréstimo:
       - Todos os campos são obrigatórios.
       - No cadastro, a seleção de livro a emprestar deve trazer em elemento “dropdown” uma lista de livros que estão disponíveis para empréstimo, ou seja, livros que não estão em um empréstimo não devolvido.
       
   * Listagem de empréstimo:
       - A listagem deve mostrar uma tabela zebrada com as seguintes colunas: id, usuário, data de empréstimo, data de previsão de devolução, título do livro e autor. Cada linha deve ter um link para atualização do empréstimo.
       - Os registros devem aparecer em ordem decrescente de data de devolução.
       - A listagem deve conter ainda funcionalidade de filtro por usuário e título do livro. Os filtros devem considerar texto inteiro (título completo de um livro, por exemplo) ou textos parciais (parte do título de um livro, por exemplo), tanto para título quanto para autor.
       - Quando a listagem não trouxer nenhum elemento, deve aparecer na página a mensagem “Nenhum registro encontrado”.
   
   * Edição de empréstimos:
       - A atualização do empréstimo deve permitir apenas a edição do campo de livro e dos campos de data.
       - Os campos que não são editáveis devem ficar em modo “somente leitura”.
       
   * Restrições de acesso:
       - Todas as páginas, exceto a de log in, têm acesso restrito a usuários logados.
       - Quando um usuário tentar entrar em uma página protegida (seja por URL, seja por link), ele será redirecionado ao log in.
                  
**Melhorias:**

   * Cadastramento de usuário:
       - Na versão atual, existe apenas um usuário, cujo log in está definido diretamente via código.
       - É necessário implementar uma estrutura de banco de dados que possibilite o cadastro de usuários.
       - Também é preciso criar páginas de inclusão, edição, listagem e exclusão de usuário. Apenas o usuário de log in “admin” deve ter acesso a essas funcionalidades.
       - A funcionalidade de log in deve ser alterada para que, em vez de usar dados fixos, use informações do banco de dados para validar o usuário.
       - Preferencialmente, deve-se utilizar encriptação MD5 para armazenamento das senhas.
       
   * Cadastramento de usuário:   
       - É preciso incluir funcionalidade de paginação nas listagens de empréstimo e de livros; mostrar dez livros por página; e utilizar Boostrap para a estilização.

   * Ênfase em empréstimos atrasados:
       - Na listagem de empréstimos, deve-se incluir uma estilização que enfatize as linhas com registro de empréstimo atrasado.
       - Sugere-se a aplicação de classes de ênfase do Boostrap.
       
## Tecnologias utilizadas:

<h3> Front-end </h3>

+ HTML
+ CSS
+ Bootstrap
+ JavaScript

<h3> Back-end </h3>

+ C#
+ Asp .net core 3.1 LTS
+ Criptografia em MD5
+ XAMPP -> MySql & Apache
+ Entity FrameWork

**Obs:** Todo projeto foi versionado o Gitub e os open issue foram trackeados no Mantis.



## Instalações necessárias:

<p><strong>Programas utilizados:</strong></p>

+ <a href="https://code.visualstudio.com/">VS Code</a>
+ <a href="https://www.apachefriends.org/pt_br/index.html">XAMPP</a>
+ <a href="https://dotnet.microsoft.com/en-us/download/dotnet">.net core 3.1 SDK</a>

<p> Utilizando o XAMPP, colocar o arquivo sql.txt (a ser adicionado) no: <pre>http://localhost/phpmyadmin/</pre></p> 

<p>Instalar os pacotes no VS Code para conexão com o banco de dados:</p>

<pre><code>dotnet add package MySqlConnector</code></pre>

<pre><code>dotnet add package Mysql.Data</code></pre>

<p>Utilizar o comando abaixo no VS Code:</p>

<pre><code>dotnet run</code></pre>

<hr>

## Páginas:

<p><strong>Login</strong></p>

![Img1](https://github.com/PolibioLins/Senac-EAD-IPI-UC07-Biblioteca/blob/master/wwwroot/css/Login2.png)

<p><strong>Logado</strong></p>

![Img1](https://github.com/PolibioLins/Senac-EAD-IPI-UC07-Biblioteca/blob/master/wwwroot/css/Logado2.png)

<p><strong>Listagem de livros</strong></p>

![Img1](https://github.com/PolibioLins/Senac-EAD-IPI-UC07-Biblioteca/blob/master/wwwroot/css/ListagemLivros2.png)

<p><strong>Cadastro de livros</strong></p>

![Img1](https://github.com/PolibioLins/Senac-EAD-IPI-UC07-Biblioteca/blob/master/wwwroot/css/CadastroLivros2.png)

<p><strong>Listagem de Empréstimos</strong></p>

![Img1](https://github.com/PolibioLins/Senac-EAD-IPI-UC07-Biblioteca/blob/master/wwwroot/css/ListagemEmprestimos2.png)

<p><strong>Cadastro de Empréstimos</strong></p>

![Img1](https://github.com/PolibioLins/Senac-EAD-IPI-UC07-Biblioteca/blob/master/wwwroot/css/CadastroEmprestimos2.png)

<p><strong>Cadastro de Usuários</strong></p>

![Img1](https://github.com/PolibioLins/Senac-EAD-IPI-UC07-Biblioteca/blob/master/wwwroot/css/CadastroUsuario2.png)

<p><strong>Listagem de Usuários</strong></p>

![Img1](https://github.com/PolibioLins/Senac-EAD-IPI-UC07-Biblioteca/blob/master/wwwroot/css/Usuarios2.png)
