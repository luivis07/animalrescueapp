using animalrescue.mainmodule.dal.setup;
using animalrescue.mainmodule.services.handlers;
using animalrescue.mainmodule.services.handlers.interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace animalrescue.mainmodule.services.setup
{
    public static class RegistrationExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection serviceColletion)
        {
            serviceColletion = serviceColletion.RegisterDal();
            serviceColletion.AddScoped<IVolunteerApplicationHandler, VolunteerApplicationHandler>();
            return serviceColletion;
        }
    }
}