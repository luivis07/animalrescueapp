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
            serviceCollection.AddScoped<IVolunteerApplicationRepository, VolunteerApplicationRepository>();
            serviceCollection.AddScoped<IAnimalRescueAccountRepository,AnimalRescueAccountRepository>();
            return serviceCollection;
        }
    }
}