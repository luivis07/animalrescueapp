using animalrescue.mainmodule.services.handlers;
using animalrescue.mainmodule.services.handlers.interfaces;
using animalrescue.mainmodule.services.setup;
using Microsoft.Extensions.DependencyInjection;

namespace animalrescue.mainmodule.web.setup
{
    public static class RegistrationExtensions
    {
<<<<<<< HEAD
        public static IServiceCollection RegisterModuleLocal(this IServiceCollection serviceCollection)
        {
            serviceCollection.RegisterServicesLocal();
            return serviceCollection;
        }
        public static IServiceCollection RegisterModuleProd(this IServiceCollection serviceCollection)
        {
            serviceCollection.RegisterServicesProd();
            return serviceCollection;
        }
        private static IServiceCollection RegisterOthers(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
=======
        public static IServiceCollection RegisterModule(this IServiceCollection serviceColletion)
        {
            serviceColletion = serviceColletion.RegisterServices();
            return serviceColletion;
>>>>>>> main
        }
    }
}