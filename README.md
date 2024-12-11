# Blog CRUD Application

## Prerequisites
- .NET 8 SDK or later
- MS SQL Server
- Visual Studio 2022 or VS Code
- NuGet packages: ASP.NET Core Identity, Entity Framework Core, FluentValidation, CKEditor (JS integration)

## Installation Steps
1. Clone the repository.
2. Restore NuGet packages using `dotnet restore`.
3. Update the database connection string in `appsettings.json`.
4. Run `dotnet ef database update` to create the database.
5. Run the application using `dotnet run`.

## Features
- Two roles: Admin and Editor
- Blog CRUD operations with status management
- File upload validation for image banners
- Rich text editor for content editing

## Database Dump
Refer to `db_dump.sql` in the root directory.

