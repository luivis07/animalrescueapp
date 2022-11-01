using animalrescue.mainmodule.dal.setup;
using animalrescue.mainmodule.services.handlers;
using animalrescue.mainmodule.services.handlers.interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace animalrescue.mainmodule.services.setup
{
    public static class RegistrationExtensions
    {
        public static IServiceCollection RegisterServicesProd(this IServiceCollection serviceCollection)
        {
            serviceCollection.RegisterDalProd();
            serviceCollection.RegisterOthers();
            return serviceCollection;
        }
        public static IServiceCollection RegisterServicesLocal(this IServiceCollection serviceCollection)
        {
            serviceCollection.RegisterDalLocal();
            serviceCollection.RegisterOthers();
            return serviceCollection;
        }
        private static IServiceCollection RegisterOthers(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IVolunteerApplicationHandler, VolunteerApplicationHandler>();
            serviceCollection.AddScoped<IAnimalRescueAccountHandler, AnimalRescueAccountHandler>();
            return serviceCollection;
        }
    }
}