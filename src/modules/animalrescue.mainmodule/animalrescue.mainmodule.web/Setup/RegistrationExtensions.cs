using animalrescue.mainmodule.services.handlers;
using animalrescue.mainmodule.services.handlers.interfaces;
using animalrescue.mainmodule.services.setup;
using animalrescue.mainmodule.web.events;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Users.Events;

namespace animalrescue.mainmodule.web.setup
{
    public static class RegistrationExtensions
    {
        public static IServiceCollection RegisterModuleLocal(this IServiceCollection serviceCollection)
        {
            serviceCollection.RegisterServicesLocal();
            serviceCollection.RegisterOthers();
            return serviceCollection;
        }
        public static IServiceCollection RegisterModuleProd(this IServiceCollection serviceCollection)
        {
            serviceCollection.RegisterServicesProd();
            serviceCollection.RegisterOthers();
            return serviceCollection;
        }
        private static IServiceCollection RegisterOthers(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRegistrationFormEvents, UserRegistrationEvent>();
            return serviceCollection;
        }
    }
}