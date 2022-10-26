using animalrescue.mainmodule.dal.repositories;
using animalrescue.mainmodule.dal.repositories.interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace animalrescue.mainmodule.dal.setup
{
    public static class RegistrationExtensions
    {
        public static IServiceCollection RegisterDal(this IServiceCollection serviceColletion)
        {
            serviceColletion.AddDbContext<AnimalRescueContext>();
            serviceColletion.AddScoped<IVolunteerApplicationRepository, VolunteerApplicationRepository>();
            return serviceColletion;
        }
    }
}