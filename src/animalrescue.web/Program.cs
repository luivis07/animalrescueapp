using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using OrchardCore.Environment.Shell.Configuration;
using OrchardCore.Media.Azure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOrchardCms()
                .ConfigureServices((tenantServices, serviceProvider) =>
                {
                    var shellConiuration = serviceProvider.GetRequiredService<IShellConfiguration>();
                    var keyVaultName = "animalrescuekv";
                    var kvUri = $"https://{keyVaultName}.vault.azure.net";
                    var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential(
                        new DefaultAzureCredentialOptions{
                        }
                    ));
                    var secret = client.GetSecret("kv-storageaccountconnectionstring");
                    var connectionString = secret.Value.Value;

                    tenantServices.PostConfigure<MediaBlobStorageOptions>(settings =>
                    {
                        settings.ConnectionString = connectionString;
                    });
                })
                .AddSetupFeatures("OrchardCore.AutoSetup");

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseOrchardCore();

app.Run();