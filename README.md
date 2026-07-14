# BibliotecaAPI

API REST desenvolvida com **ASP.NET Core** utilizando **Clean Architecture** para gerenciamento de livros e gêneros de uma biblioteca.

Este é um projeto pessoal com o foco em boas práticas de desenvolvimento, separação de responsabilidades e organização em camadas, utilizando Entity Framework Core para persistência de dados e AutoMapper para mapeamento entre entidades e DTOs.

---

## Tecnologias Utilizadas

- C#
- ASP.NET Core Web API
- Entity Framework Core
- MySQL
- AutoMapper
- Swagger
- User Secrets
- Git e GitHub

---

## Arquitetura

O projeto segue o padrão **Clean Architecture**, organizado nas seguintes camadas:

```text
BibliotecaAPI
│
├── APIBiblioteca
├── Biblioteca.Application
├── Biblioteca.CrossCutting
├── Biblioteca.Domain
└── Biblioteca.Infrastructure
```

### Conceitos Aplicados

- Clean Architecture
- Repository Pattern
- Generic Repository
- Unit of Work
- DTOs
- Injeção de Dependência
- Entity Framework Core
- Programação Orientada a Objetos
- APIs REST

---

## Funcionalidades

### Livros e Gêneros

- Cadastrar 
- Listar 
- Buscar por ID
- Atualizar 
- Excluir

---

## Como Executar o Projeto

### 1. Clone o repositório

```bash
git clone https://github.com/Lucass-ux/BibliotecaAPI.git
```

### 2. Abra a solução

Abra o arquivo:

```text
BibliotecaAPI.sln
```

no Visual Studio.

### 3. Crie um banco de dados MySQL

Exemplo:

```sql
CREATE DATABASE BibliotecaDb;
```

### 4. Configure a string de conexão

Clique com o botão direito no projeto **APIBiblioteca** e selecione:

```text
Manage User Secrets
```

Adicione sua string de conexão:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=BibliotecaDb;User=SEU_USUARIO;Password=SUA_SENHA;"
  }
}
```

### 5. Execute as migrations

Abra o terminal na raiz da solução e execute:

```bash
dotnet ef database update --project Biblioteca.Infrastructure --startup-project APIBiblioteca
```

### 6. Execute a aplicação

Pressione **F5** ou clique em **Start** no Visual Studio.

---

## Documentação da API

Após iniciar a aplicação, acesse o Swagger:

```text
https://localhost:xxxx/swagger
```

A porta utilizada será exibida no terminal ou na janela de saída do Visual Studio.

---

## Autor

**Lucas Loiolla Gomes**

- GitHub: https://github.com/Lucass-ux
- LinkedIn: https://www.linkedin.com/in/lucas-loiolla-gomes-280aa739a
