using animalrescue.mainmodule.dal.repositories;
using animalrescue.mainmodule.dal.repositories.interfaces;
<<<<<<< HEAD
using Microsoft.Extensions.Configuration;
=======
>>>>>>> main
using Microsoft.Extensions.DependencyInjection;

namespace animalrescue.mainmodule.dal.setup
{
    public static class RegistrationExtensions
    {
<<<<<<< HEAD
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
            return serviceCollection;
=======
        public static IServiceCollection RegisterDal(this IServiceCollection serviceColletion)
        {
            serviceColletion.AddDbContext<AnimalRescueContext>();
            serviceColletion.AddScoped<IVolunteerApplicationRepository, VolunteerApplicationRepository>();
            return serviceColletion;
>>>>>>> main
        }
    }
}