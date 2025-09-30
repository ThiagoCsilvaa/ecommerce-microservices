# Ecommerce Microservices

Este repositório contém o desafio de implementação de um sistema de microserviços para um e-commerce, desenvolvido em .NET 7.  
O projeto está dividido em dois serviços principais:

- **StockService**: responsável pela gestão de produtos e estoque.
- **SalesService**: responsável pela gestão de pedidos e integração futura com RabbitMQ.

---

## Estrutura do Projeto

ecommerce-microservices/
├── src/
│ ├── StockService/
│ │ ├── Controllers/
│ │ ├── Data/
│ │ ├── Models/
│ │ ├── Program.cs
│ │ └── StockService.csproj
│ └── SalesService/
│ ├── Controllers/
│ ├── Data/
│ ├── Models/
│ ├── Program.cs
│ └── SalesService.csproj
├── .gitignore
└── README.md

yaml
Copy code

---

## Tecnologias Utilizadas

- .NET 7
- Entity Framework Core (EF Core)
- SQL Server
- ASP.NET Core Web API
- Swagger (para documentação e teste das APIs)

---

## Como Rodar

1. Clonar o repositório:

```bash
git clone https://github.com/ThiagoCsilvaa/ecommerce-microservices.git
2. Entrar na pasta de cada serviço e restaurar pacotes:

bash
Copy code
cd src/StockService
dotnet restore
bash
Copy code
cd ../SalesService
dotnet restore
3. Rodar cada serviço:

bash
Copy code
dotnet run
4. Acesse o Swagger para testar as APIs:

bash
Copy code
http://localhost:{porta}/swagger
Observação: o banco de dados ainda precisa ser criado via migrations, quando você estiver pronto para persistir dados.

Próximos Passos
Criar migrations e configurar o banco de dados.

Implementar integração do SalesService com StockService via RabbitMQ.

Implementar validações de estoque e confirmação de pedidos.

5. Agradecimentos
Agradeço a todos que contribuíram com orientações e suporte técnico durante o desenvolvimento deste desafio.
Em especial, agradeço ao mentor e à comunidade que ajudou na organização do projeto e resolução de erros iniciais.
