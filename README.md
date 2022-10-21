## Documentation

- Official Site: https://savingsagerescue.org/

- Tech Requirements
  - Download Net 6.0 SDK
  - Visual Studio Code
  - Git Bash
  - Powershell (latest version)

- Setup
  - VS Code Extensions:
    - Azure Account
  - Powershell
    - AZ Module
    - Azure CLI
  - Projects
    - animalrescue.web - FrontEnd
    - animalrescue.mainmodule - Middle Layer
    - animalrescue.defaulttheme - Holds custom theme for app

- To Build/Run:
  - sign-in to azure from VS code using the extension mentioned above (Azure Account)
    - Note: you don't need to do this all the time but at least once first time running the app and after if your session expires
  - `dotnet build .\animalrescue.sln`
  - `dotnet run --project .\src\animalrescue.web\animalrescue.web.csproj`

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

