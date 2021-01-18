- new migration: 
`dotnet ef migrations add Initial --context NorthwindDbContext --output-dir .\Migrations --project .\src\Infrastructure\Infrastructure.csproj --startup-project .\src\Presentation.Web\Presentation.Web.csproj`

- update database: 
`dotnet ef database update --project src\Infrastructure --startup-project src\Presentation.Web`