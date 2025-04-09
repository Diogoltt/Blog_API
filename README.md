# Blog API

Este projeto é uma API para gerenciamento de um blog, construída com .NET 8.0 e Entity Framework Core. A API permite gerenciar categorias, posts, usuários, e outras entidades relacionadas.

## Estrutura do Projeto

Abaixo está uma visão geral da estrutura do projeto:

```
Blog/
├── Controllers/
│   ├── CategoryController.cs
│   ├── HomeController.cs
├── Data/
│   ├── BlogDataContext.cs
│   ├── Mappings/
│   │   ├── CategoryMap.cs
│   │   ├── PostMap.cs
│   │   ├── UserMap.cs
├── Extensions/
│   ├── ModelStateExtension.cs
├── Migrations/
│   ├── 20250331133536_CreateDatabase.cs
│   ├── 20250331133536_CreateDatabase.Designer.cs
│   ├── BlogDataContextModelSnapshot.cs
├── Models/
│   ├── Category.cs
│   ├── Post.cs
│   ├── Role.cs
│   ├── Tag.cs
│   ├── User.cs
├── ViewModels/
│   ├── EditorCategoryViewModel.cs
│   ├── ResultViewModel.cs
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
├── Blog.csproj
├── Blog.sln
└── .gitignore
```

### Principais Componentes

#### **Controllers**
- **CategoryController.cs**: Controlador responsável por gerenciar as categorias do blog. Contém endpoints para CRUD (Create, Read, Update, Delete).
- **HomeController.cs**: Controlador simples para a rota raiz da API.

#### **Data**
- **BlogDataContext.cs**: Contexto do Entity Framework Core que gerencia as entidades e a conexão com o banco de dados.
- **Mappings/**: Configurações de mapeamento das entidades para o banco de dados.

#### **Extensions**
- **ModelStateExtension.cs**: Extensão para facilitar a extração de erros do `ModelState`.

#### **Migrations**
- Contém as migrações geradas pelo Entity Framework Core para criar e atualizar o banco de dados.

#### **Models**
- Representam as entidades principais do sistema, como `Category`, `Post`, `User`, `Role`, e `Tag`.

#### **ViewModels**
- **EditorCategoryViewModel.cs**: ViewModel para validação de entrada ao criar ou editar categorias.
- **ResultViewModel.cs**: Classe genérica para padronizar as respostas da API.

#### **Configurações**
- **appsettings.json** e **appsettings.Development.json**: Arquivos de configuração para o ambiente de produção e desenvolvimento.
- **Program.cs**: Configuração inicial da aplicação, incluindo injeção de dependências e mapeamento de controladores.

## Configuração do Banco de Dados

O projeto utiliza o SQL Server como banco de dados. A string de conexão está configurada no arquivo `BlogDataContext.cs`:

```csharp
options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");
```

Certifique-se de que o SQL Server esteja configurado corretamente e que as credenciais sejam válidas.

## Como Executar

1. Clone o repositório.
2. Certifique-se de ter o .NET 8.0 SDK instalado.
3. Restaure os pacotes NuGet:
   ```bash
   dotnet restore
   ```
4. Execute as migrações para criar o banco de dados:
   ```bash
   dotnet ef database update
   ```
5. Inicie a aplicação:
   ```bash
   dotnet run
   ```

A API estará disponível em `http://localhost:5126` (ou conforme configurado no `launchSettings.json`).

## Endpoints Principais

### Categorias
- `GET /v1/categories`: Retorna todas as categorias.
- `GET /v1/categories/{id}`: Retorna uma categoria pelo ID.
- `POST /v1/categories`: Cria uma nova categoria.
- `PUT /v1/categories/{id}`: Atualiza uma categoria existente.
- `DELETE /v1/categories/{id}`: Remove uma categoria.

### Outros
- `GET /`: Endpoint raiz para verificar se a API está funcionando.

## Tecnologias Utilizadas

- **.NET 8.0**
- **Entity Framework Core 9.0**
- **SQL Server**

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## Licença

Este projeto está licenciado sob a [MIT License](https://opensource.org/licenses/MIT).
