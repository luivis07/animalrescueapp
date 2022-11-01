using animalrescue.mainmodule.dal.repositories;
using animalrescue.mainmodule.dal.repositories.interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace animalrescue.mainmodule.dal.setup
{
    public static class RegistrationExtensions
    {
        public static IServiceCollection RegisterDalLocal(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<AnimalRescueContext, LocalAnimalRescueContext>();
            serviceCollection.RegisterOthers();
            return serviceCollection;
        }
        public static IServiceCollection RegisterDalProd(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<AnimalRescueContext>();
            serviceCollection.RegisterOthers();
            return serviceCollection;

        }
        private static IServiceCollection RegisterOthers(this IServiceCollection serviceCollection)
        {
            var repositories = AppDomain.CurrentDomain.GetAssemblies()
                                    .SelectMany(c => c.GetTypes())
                                    .Where(c => c.Name.EndsWith("Repository") && 
                                                c.IsClass && 
                                                !c.IsAbstract &&
                                                !c.IsInterface &&
                                                !string.IsNullOrEmpty(c.AssemblyQualifiedName) &&
                                                c.AssemblyQualifiedName.StartsWith("animalrescue.mainmodule"));
                                                
            foreach (var repository in repositories)
            {
                var inter = repository.GetInterfaces().FirstOrDefault(i => i.Name.EndsWith(i.Name));
                if (inter != null)
                    serviceCollection.AddScoped(inter, repository);
            }
            return serviceCollection;
        }
    }
}