<#
    Create Migration and update db to latest.
    If no $migrationname is provided then only db update will be executed.
#>
param(
    #migration name - use '_' instead of spaces if needed
    [string]$migrationname,

    #environment to target - Development by default (valid values: 'Development', 'Production')
    [string]$environment = 'Development',

    #connectionstring to db if applicable (require for 'Production')
    [string]$connectionstring
)

$env:ASNETCORE_ENVIRONMENT=$environment
if($environment -eq 'Production')
{
    if($migrationname)
    {
        dotnet ef migrations add $migrationname --context AnimalRescueContext --output-dir Migrations/SqlServerMigrations --project .\src\modules\animalrescue.mainmodule\animalrescue.mainmodule.dal\animalrescue.mainmodule.dal.csproj  --startup-project .\src\animalrescue.web\animalrescue.web.csproj
    }
    dotnet ef database update --context AnimalRescueContext --project .\src\modules\animalrescue.mainmodule\animalrescue.mainmodule.dal\animalrescue.mainmodule.dal.csproj  --startup-project .\src\animalrescue.web\animalrescue.web.csproj --connection $connectionstring
}
else
{
    if($migrationname)
    {
        dotnet ef migrations add $migrationname --context LocalAnimalRescueContext --output-dir Migrations/SqliteMigrations --project .\src\modules\animalrescue.mainmodule\animalrescue.mainmodule.dal\animalrescue.mainmodule.dal.csproj  --startup-project .\src\animalrescue.web\animalrescue.web.csproj
    }
    dotnet ef database update --context LocalAnimalRescueContext --project .\src\modules\animalrescue.mainmodule\animalrescue.mainmodule.dal\animalrescue.mainmodule.dal.csproj  --startup-project .\src\animalrescue.web\animalrescue.web.csproj
}