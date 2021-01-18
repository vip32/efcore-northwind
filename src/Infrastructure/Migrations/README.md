- new migration: 
`dotnet ef migrations add Initial --context NorthwindDbContext --output-dir Migrations --project src\Infrastructure --startup-project src\Presentation.Web --namespace Infrastructure`

- update database: 
`dotnet ef database update --project src\Infrastructure --startup-project src\Presentation.Web`