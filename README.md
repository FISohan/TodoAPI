# TodoAPI
  > Simple Todo API for learning.
## How to run:
  1. Clone repo
  2. Change directory to this project
  3. Execute this command for install packages:
     - ```dotnet add package Microsoft.AspNetCore.OpenApi```
     - ```dotnet add package Microsoft.EntityFrameworkCore```
     - ```dotnet add package Microsoft.EntityFrameworkCore.Design```
     - ```dotnet add package Microsoft.EntityFrameworkCore.Sqlite```
     - ```dotnet add package Microsoft.EntityFrameworkCore.Tools```
  4. Install entity framework:
     - ```dotnet tool install --global dotnet-ef```
  5. Add migration:
     - ```dotnet ef migrations add InitialCreate```
  6. Update Database:
     - ```dotnet ef database update```
  7. To run this project:
     - ```dotnet watch run```
> # Now You Ready to Run
