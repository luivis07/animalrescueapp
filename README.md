## Documentation

- Official Site: https://savingsagerescue.org/

- Tech Requirements
  - Download Net 6.0 SDK
  - Visual Studio Code
  - Git Bash
  - Powershell (latest version)
  - node JS (make sure to install LTS version)

- Setup
  - VS Code Extensions:
    - Azure Account
  - Powershell
    - AZ Module
    - Azure CLI
  - Projects
    - animalrescue.web - CMS-Front End
    - animalrescue.mainmodule - User Management
    - animalrescue.defaulttheme - Custom Theme for CMS
  - EF Diagram
    - https://drive.google.com/file/d/1cGGOYfm_jWr43l7PiLKpv_wE_exhq641/view

- To Build/Run:
  - sign-in to azure from VS code using the extension mentioned above (Azure Account)
    - Note: you don't need to do this all the time but at least once the first time running the app and after if your session expires
  - `dotnet build .\animalrescue.sln`
  - `dotnet run --project .\src\animalrescue.web\animalrescue.web.csproj`

- EF Migrations:
  - The commands below need to be executed at the root level of the application
  - Install dotnet EF tool:
    - `dotnet tool install dotnet-ef --global`
  - Powershell Helper
    - The migration scripts can be replaced by running `.\src\infrastructure\database\helpers\applymigrations.ps1` (at the root level)
    - Examples:
      - `.\src\infrastructure\database\helpers\applymigrations.ps1` updates 'Development' db to the latest migration 
      - `.\src\infrastructure\database\helpers\applymigrations.ps1 -migrationname "NAME"` create a migration with name = NAME and updates db to latest
      - ~~`.\src\infrastructure\database\helpers\applymigrations.ps1 -environment "Production" -connectionstring "CONNECTION_STRING"` updates 'Production' db to the latest migration~~
      - `.\src\infrastructure\database\helpers\applymigrations.ps1 -reset` drops current db and applies latest migration
    - View `.\src\infrastructure\database\helpers\applymigrations.ps1` for more info
  - ~~Development (local environment)~~
    - ~~`$env:ASPNETCORE_ENVIRONMENT="Development"`~~
    - ~~`dotnet ef migrations add MIGRATION_NAME --context LocalAnimalRescueContext --output-dir Migrations/SqliteMigrations --project .\src\modules\animalrescue.mainmodule\animalrescue.mainmodule.dal\animalrescue.mainmodule.dal.csproj  --startup-project .\src\animalrescue.web\animalrescue.web.csproj`~~
    - ~~`dotnet ef database update --context LocalAnimalRescueContext --project .\src\modules\animalrescue.mainmodule\animalrescue.mainmodule.dal\animalrescue.mainmodule.dal.csproj  --startup-project .\src\animalrescue.web\animalrescue.web.csproj`~~
  - Production (sql server db) make sure to replace `MIGRATION_NAME` and `CONNECTION_STRING`
    - `$env:ASPNETCORE_ENVIRONMENT="Production"`
    - `dotnet ef migrations add MIGRATION_NAME --context AnimalRescueContext --output-dir Migrations/SqlServerMigrations --project .\src\modules\animalrescue.mainmodule\animalrescue.mainmodule.dal\animalrescue.mainmodule.dal.csproj  --startup-project .\src\animalrescue.web\animalrescue.web.csproj`
    - `dotnet ef database update --context AnimalRescueContext --project .\src\modules\animalrescue.mainmodule\animalrescue.mainmodule.dal\animalrescue.mainmodule.dal.csproj  --startup-project .\src\animalrescue.web\animalrescue.web.csproj --connection "CONNECTION_STRING"`

- CI/CD:
  - Configured to deploy to https://sageanimalrescue.azurewebsites.net/ from `main` only

- Help
  - UI
    - Code samples for UI components can be found here:
    - https://getbootstrap.com/docs/5.0/examples/cheatsheet/
  - OrchardCore
    - https://orcharddojo.net/orchard-training/dojo-course-3-the-full-orchard-core-tutorial
    - https://www.youtube.com/playlist?list=PLuskKJW0FhJcSX7j0Bd-1X5hq3dgCtYwO
    - https://github.com/Lombiq/Dojo-Course-3-Orchard-Core-Demo

- Branch Naming Conventions
  - feature/FEATURE_NAME/issue-ISSUE_NUMBER (this is the main way to merge PRs into `main`)
  - users/USER_NAME/ANYTHING (this is a last resort in case you are working on something and need to push)

