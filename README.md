git init
dotnet new gitignore
touch README.md

*File new project/ Arquivo novo projeto
dotnet new sln

git add *
git commit -m 'iniciando'


md FrontEnd
md Services


*Migration na pasta do projeto
====
==Comandos usados no Powershell
====
dotnet tool install --global dotnet-ef
dotnet ef migrations add AddProductDataTableOnDB 
dotnet ef migrations remove
dotnet ef database update
==
dotnet ef migrations add SeedProductDataTable
dotnet ef database update


==== ou Comandos usados no Console do Gerenciados de Pacotes
====
add-migration AddProductDataTableOnDB
remove-migration
updade-database


==== Duende.IdentityServer.Templates
dotnet new --install Duende.IdentityServer.Templates
md foo
cd foo
dotnet new isui

Renomear: "HomeController" para "MainModule"
Apagar: "HomeController.cs"
Colar o conteudi di "Duende\Quickstart" na "MainModule"


Instalar no Gerenciador de Pacotes Nuget:
Duende.IdentityServer.AspNetIdentity (versão 5)
Microsoft.AspNetCore.Identity.EntityFramework (versão 6.0.14)
Microsoft.AspNetCore.Identity.UI (versão 6.0.14)


dotnet ef migrations add AddDefaulSecurityTablesOnDB


