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


