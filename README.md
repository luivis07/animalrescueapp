## Documentation

- Official Site: https://savingsagerescue.org/

- Tech Requirements
  - Download Net 6.0 SDK
  - Visual Studio Code
  - Git Bash

- Setup
  - Projects
    - animalrescue.web - FrontEnd
    - animalrescue.mainmodule - Middle Layer (future use as of now)
    - animalrescue.defaulttheme - Holds custom theme for app

- To Build/Run:
  - `dotnet build .\animalrescue.sln`
  - `dotnet run --project .\src\animalrescue.web\animalrescue.web.csproj`

- Help
  - UI
    - Code samples for UI components can be found here:
    - https://getbootstrap.com/docs/5.2/examples/cheatsheet/
  - OrchardCore
    - https://orcharddojo.net/orchard-training/dojo-course-3-the-full-orchard-core-tutorial
    - https://www.youtube.com/playlist?list=PLuskKJW0FhJcSX7j0Bd-1X5hq3dgCtYwO
    - https://github.com/Lombiq/Dojo-Course-3-Orchard-Core-Demo

- Branch Naming Conventions
  - feature/FEATURE_NAME/issue-ISSUE_NUMBER (this is the main way to merge PRs into `main`)
  - users/USER_NAME/ANYTHING (this is a last resort in case you are working on something and need to push)

