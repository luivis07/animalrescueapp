using animalrescue.mainmodule.services.handlers;
using animalrescue.mainmodule.services.handlers.interfaces;
using animalrescue.mainmodule.services.setup;
using Microsoft.Extensions.DependencyInjection;

namespace animalrescue.mainmodule.web.setup
{
    public static class RegistrationExtensions
    {
        public static IServiceCollection RegisterModule(this IServiceCollection serviceColletion)
        {
            serviceColletion = serviceColletion.RegisterServices();
            return serviceColletion;
        }
    }
}