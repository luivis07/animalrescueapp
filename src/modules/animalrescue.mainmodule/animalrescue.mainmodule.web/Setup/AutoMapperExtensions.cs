using animalrescue.mainmodule.helpers;
using animalrescue.mainmodule.services.setup;
using AutoMapper;

namespace animalrescue.mainmodule.web.setup
{
    public static class AutoMapperExtensions
    {
        public static void AddProfiles(this IMapperConfigurationExpression mapperConfigurationExpression)
        {
            var profiles = AppDomain.CurrentDomain.GetAssemblies()
                                .SelectMany(a => a.GetTypes())
                                .Where(t => typeof(Profile).IsAssignableFrom(t) &&
                                        !string.IsNullOrEmpty(t.AssemblyQualifiedName) &&
                                        t.AssemblyQualifiedName.StartsWith(Constants.ASSEMBLY_QUALIFIED_NAME_PREFIX));
            foreach(var profile in profiles)
            {
                mapperConfigurationExpression.AddProfile(profile);
            }
            mapperConfigurationExpression.AddServiceProfiles();
        }
    }
}