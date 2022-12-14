using animalrescue.mainmodule.dal.setup;
using animalrescue.mainmodule.helpers;
using animalrescue.mainmodule.services.dtos;
using FluentValidation;
using FluentValidation.Results;
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
            serviceCollection.RegisterHandlers();
            serviceCollection.RegisterValidators();
            serviceCollection.AddScoped<ValidationResult>();
            return serviceCollection;
        }
        private static IServiceCollection RegisterHandlers(this IServiceCollection serviceCollection)
        {
            var handlers = AppDomain.CurrentDomain.GetAssemblies()
                                    .SelectMany(c => c.GetTypes())
                                    .Where(c => c.Name.EndsWith(Constants.HANDLER_NAME_POSTFIX) &&
                                                c.IsClass &&
                                                !c.IsAbstract &&
                                                !c.IsInterface &&
                                                !string.IsNullOrEmpty(c.AssemblyQualifiedName) &&
                                                c.AssemblyQualifiedName.StartsWith(Constants.ASSEMBLY_QUALIFIED_NAME_PREFIX));

            foreach (var handler in handlers)
            {
                var inter = handler.GetInterfaces().FirstOrDefault(i => i.Name.EndsWith(i.Name));
                if (inter != null)
                    serviceCollection.AddScoped(inter, handler);
            }
            return serviceCollection;
        }
        private static IServiceCollection RegisterValidators(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddValidatorsFromAssemblyContaining<AnimalRescueAccountDto>(ServiceLifetime.Transient);
            return serviceCollection;
        }
    }
}