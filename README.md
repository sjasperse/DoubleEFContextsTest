# Double EF test project

Process:
- Scaffolded out the project
  - `dotnet new console`
  - `dotnet new gitignore`
  - `dotnet new tool-manifest`
  - `dotnet tool install dotnet-ef`
  - `dotnet tool restore`
  - `dotnet add package Microsoft.EntityFrameworkCore`
  - `dotnet add package Microsoft.EntityFrameworkCore.Design`
  - `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
- Created the FeatureADbContext and model
- `dotnet ef migrations add "InitialA"`
- Created the FeatureBDbContext as model
- `dotnet ef migrations add "InitialB" --context FeatureBDbContext`

## What we wanted to know
- How does EF handle multiple DbContexts in the same project
- Will it keep migrations separate or will it cross-apply them incorrectly?
- Where will it put migrations?

## What we observered
- If two DbContext exist in the same project, it will require the `--context` parameter on the command line, and it will put the migrations in a `Migrations/{db context name}` folder.
- EF tagged each migration with a `DbContext` attribute in the `.Designer.cs` to indicate which DbContext each migration is associated with.
- Running `dotnet ef migrations script -i --context FeatureADbContext` and `dotnet ef migrations script -i --context FeatureBDbContext` produced the correct results.
- We were impressed. A little more magic than I like, but really good default functionality.
